package YoPackage
{
   // cServer.cs
   function _connectToGameServer()
   {
      // already connected
      hack("yo::connectToGameServer" SPC $tmp::pendingSpawnGeoID);

      if(!isObject(ServerConnection))
      {
         error("no ServerConnection object");
         return;
      }

      // check loading status
      if(!ServerConnection.initPatchesDone)
      {
         echo("Waiting for managers init");
         return;
      }
      if(!ServerConnection.initManagersDone)
      {
         echo("Waiting for patches done");
         return;
      }

      ServerConnection.initStartupDone = true;
      commandToPeer(ServerConnection, 'ClientReadyToEnterGame');
   }

   // serverConnection.cs
   function startConnection(%addr)
   {
      hack("yo::startConnection(" @ %addr @ ")"); //###

      loadLoadingGui(GetMessageIDText(1340)); //Waiting for Server

      // obtain IP address
      %addrSpaced = strreplace(%addr, ":", " ");
      if(getWordCount(%addrSpaced) != 2)
      {
         error("invalid address");
         return;
      }
      %ip = getWord(%addrSpaced, 0);

      $tmp::regionServerIP = %ip;
      connect(%addr);
   }

   // cServer.cs
   function peerCmdCS(%peer, %serverPort, %accountHash)
   {
      $tmp::contentServerPort = %serverPort;
      $tmp::contentServerHash = %accountHash;
      schedule(32, PlayGui, connectToContentServer);

      loadLoadingGui(GetMessageIDText(1523)); //Patching World
   }

   function reconnectToContentServer(%errorMessage)
   {
      warn("reconnect: " @ %errorMessage);
      //connectToContentServer();

      //TODO: fix reconnect problem
      //if($tmp::csPatched)
      //   connectToContentServer();
      //else
      //   MessageBoxOK("DISCONNECT", "Connection lost" @ (%errorMessage !$= "" ? ": " @ %errorMessage : ""), "disconnect();");

      if(isObject(contentServer))
         schedule(32, PlayGui, connectToContentServer);
      else
         connectToContentServer();
   }

   function connectToContentServer()
   {
      if($tmp::csPatched)
      {
         warn("Client already patched");
         return;
      }

      if(isObject(contentServer))
      {
         if(contentServer.pendingHash $= $tmp::contentServerHash)
         {
            warn("The connection to ContentServer is already established. Nothing to do!");
            return;
         }
         %prevCS = contentServer.getId();
         %prevCS.setName("prevContentServer");
         %prevCS.delete("DoubleConnection");
      }

      // connect at to same address as GS
      if($tmp::regionServerIP $= "")
      {
         error("No Content Server available!");
         return;
      }

      hack("connecting to " @ $tmp::regionServerIP @ ":" @ $tmp::contentServerPort); //###

      %cs = new TCPConnection(contentServer);
      %cs.isConnected = false;
      %cs.setClassNamespace("clContentServer");
      %cs.setConnectArgs("CLIENT-CS", "CS-CLIENT");
      %cs.pendingIP   = $tmp::regionServerIP;
      %cs.pendingPort = $tmp::contentServerPort;
      %cs.pendingHash = $tmp::contentServerHash;
      %cs.connect(%cs.pendingIP, %cs.pendingPort);
   }

   function clContentServer::sendCharSelected(%this)
   {
      // nothing to do in yo - we send changes for all terrains
   }

   function clientRpcGetPVer(%cs)
   {
      initPatchConnection(%cs);
   }

   function clientRpcPREPATCHOK(%cs)
   {
      _clientCreateWorld($tmp::pendingSpawnGeoID, "_onWorldCreated();");

      // disconnect from tcp
      $tmp::csPatched = true;
      cancel($tmp::csSch);
      %cs.delete();
   }

   function clientCmdPATCHOK(%server)
   {
      if(!isObject(ServerConnection))
      {
         error("no ServerConnection object");
         return;
      }
      ServerConnection.initPatchesDone = true;

      stopPatchConnection();
      _connectToGameServer();

      setLoadingGuiText(GetMessageIDText(1527)); //Entering
   }

   function cmJoinDefaultChats() {
      cmChatJoin("@");   // System channel
      cmChatJoin("");      // Local channel
      cmChatJoin("$");   // Global channel for standalone server
   }

   function getLocalIP()
   {
      %ipLine = getIPLocal();
      if(getWordCount(%ipLine) <= 0)
      {
         error("Can't get IP address");
         return;
      }
      // get first ip
      return getWord(%ipLine, 0);
   }

   // launching new world
   function GuiCreateWorldWindow::prepareWorldStarting(%this, %port, %password, %worldID)
   {
      if(!%port)
         %port = $pref::Net::Port; // use default
      hack("prepareWorldStarting(" @ %port @ ")");

      $JoinGameAddress = (getLocalIP() @ ":" @ %port);
      $JoinGamePassword = %password;
      $LocalWorldID = %worldID;

      loadLoadingGui();

      //startRedingSharedServerLoadingStatus();
   }

   function prepareWorldDB()
   {
      %worldID = $LocalWorldID;
      if(!%worldID)
      {
         error("Not world id given!");
         return true;
      }
      %configDir = getServerConfigFolder();
      %dbFolder = %configDir @ "world_"@ %worldID @"_db";
      %backupFolder = %configDir @ "backup/world_"@ %worldID @"_db";
      // First, check if the new world db exists or not
      if(fileExists(%dbFolder @"/performance_schema/db.opt"))
      {
         //TODO: Check the database for validity and recover from backup if needed!
         return true;
      }
      // Check maybe we have a backup?
      if(fileExists(%backupFolder @"/performance_schema/db.opt"))
      {
         //TODO: Check the database for validity before trying to use it?!
         pathCopy(%backupFolder, %dbFolder);
         return true;
      }
      // If not, extract empty DB into new folder
      if(!extractEmptyDB(%worldID))
      {
         _lifError(2221, "Error");
         return false;
      }
      // Check if we have an exported version of SQL dump
      if(isFile(%configDir@"lif_"@%worldID@".sql"))
      {
         // The file will be picked up by the server and imported automaticallly
         return true;
         //importCommonDB(%worldID, %configDir@"lif_"@%worldID@".sql", "startLocalWorld");
         //return false;
      }
      // Check if we have the world in common database
      if(fileExists($ChildProcessHelper::mariaDBDataPath @ "lif_"@%worldID @"/db.opt"))
      {
         schedule(0, RootGroup, loadLoadingGui, GetMessageIDText(2220));
         // We need to export the data
         exportCommonDB(%worldID, "startLocalWorld();");
         return false;
      }
      // No previous DB found, the server will init a new DB
      error("No previous DB found, the server will init a new DB!");
      return true;
   }

   //function startRedingSharedServerLoadingStatus()
   //{
   //   if(!$sharedLoadingStatusStartTime)
   //      $sharedLoadingStatusStartTime = getSimTime();
   //   else if((getSimTime() - $sharedLoadingStatusStartTime) > 5*60*1000) // 5 minute timeout
   //   {
   //      // server was not started
   //      MessageBoxOK(GetMessageIDText(1511), GetMessageIDText(1533), "disconnect();"); // TIMED OUT // The local server can't be accessed.
   //      return;
   //   }
   //
   //   if(!isObject($sharedLoadingStatus))
   //   {
   //      $sharedLoadingStatus = new CmServerSharedLoadingStatus();
   //      if($sharedLoadingStatus)
   //      {
   //         ClientMissionCleanup.add($sharedLoadingStatus);
   //         $sharedLoadingStatus.setOnServerLoadedCallback("onLocalServerLoaded");
   //
   //         setLoadingGuiText(GetMessageIDText(2132)); // Loading Server
   //      }
   //      else
   //      {
   //         // server not started - try again in second
   //         schedule(1000, 0, startRedingSharedServerLoadingStatus);
   //      }
   //   }
   //}

   function onLocalServerLoaded()
   {
      hack("onLocalServerLoaded()");

      //if(isObject($sharedLoadingStatus))
      //{
      //   $sharedLoadingStatus.schedule(0, "delete"); //$sharedLoadingStatus.delete();
      //   $sharedLoadingStatus = 0;
      //}

      initConnection();
   }

   function showWelcomeMessage()
   {
      cmShowMessage(688);   // Life is Feudal welcomes you! &#10; Press F1 for help and basic controls.
   }

   function updateVersionBarText()
   {
      // don't need it in yo
      if(isObject("versionBar"))
         versionBar.delete();
   }

   function initLocalConnection(%port)
   {
      $JoinGameAddress = getLocalIP() @ ":" @ (%port ? %port : $pref::Net::Port);
      initConnection();
   }

   function joinToRemoteServer(%addr, %password)
   {
      $JoinGameAddress = %addr;
      $JoinGamePassword = %password;

      initConnection();
   }

	function joinToRemoteServer1(%addr, %password)
   {
      $JoinGameAddress = "193.70.81.39:23045";
      $JoinGamePassword = "";
      
      initConnection();
   }
   function updatePatchingCounterGui(%patchedTerCount, %totalTerCount)
   {
      setLoadingGuiText(GetMessageIDText(1523) @ " (" @ %patchedTerCount @ "/" @ %totalTerCount @ ")"); //Patching World
   }

   function updateGeoPatchingCounterGui(%loadedTerCount, %totalTerCount)
   {
      setLoadingGuiText(GetMessageIDText(1524) @ " (" @ %loadedTerCount @ "/" @ %totalTerCount @ ")"); //Terraforming changes
   }

   function updateObjPatchingCounterGui(%loadedTerCount, %totalTerCount)
   {
      setLoadingGuiText(GetMessageIDText(1525) @ " (" @ %loadedTerCount @ "/" @ %totalTerCount @ ")"); //Object changes
   }

   function updateForestPatchingCounterGui(%loadedTerCount, %totalTerCount)
   {
      setLoadingGuiText(GetMessageIDText(1526) @ " (" @ %loadedTerCount @ "/" @ %totalTerCount @ ")"); //Forest changes
   }

   function updatePatchedTerCounterGui(%loadedTerCount, %totalTerCount)
   {
         setLoadingGuiText(GetMessageIDText(1377) @ " (" @ %loadedTerCount @ "/" @ %totalTerCount @ ")"); // Loading World
   }

   function cleanupPatches()
   {
      stopPatchConnection(false);
      recreatePatcher();
   }

   function ServerConnection::onCharSelected(%this, %geoId)
   {
      $tmp::pendingSpawnGeoID = %geoID;
      //connectManagers();
      initManagersOnCharSelected("onManagersInitDone();");
   }

   function onManagersInitDone()
   {
      if(!isClientInventoryInitialized())
      {
         error("Fatal: Can't load object types. Terminating.");
         _disconnectQuit();
         return;
      }

      if(!isObject(ServerConnection))
      {
         error("no ServerConnection object");
         return;
      }
      ServerConnection.initManagersDone = true;

      commandToServer('ReadyToPatch');
      commandToServer('ReadyToInventory');
      commandToServer('ClientManagersInitialized');
      _connectToGameServer();
   }

   //---------------------------------------------------------------------
   // DB check routine
   //---------------------------------------------------------------------
   // In order to check if the database is valid, we should start the mysql client and call the following:
   // SHOW TABLE STATUS FROM `lif_X`;
   // If we receive something like "rows in set", than we got the data.
   // If we receive "Empty set", than the database is either corrupted or not exists.
   // At the same time, the cphMariaDB could get a message like "[ERROR] Cannot find or open table lif_X"

   // Check if the world is valid/exists
   // 1: if world_X.xml is readable
   // 2: if world_X_db folder exists
   // 2.1: if 2==false check if [commonDB]\lif_X exists and DB valid, if so, create world_X_db and copy it over from commonDB via mysqldump
   // 2.2: if 2==1 start the world

   function extractEmptyDB(%world)
   {
      %configDir = getServerConfigFolder();
      %worldDir = %configDir @ "world_"@%world@"_db";
      if(fileExists(%worldDir @ "/performance_schema/db.opt"))
      {
         if(!removeFolderWithAllFiles(%worldDir))
         {
            error("Can't cleanup the folder '"@ %worldDir @"' for new world! Some other application may have open files/path.");
            return false;
         }
      }
      %emptyDB = %configDir @ "emptyDB";
      if(!fileExists(%emptyDB @ "/performance_schema/db.opt"))
      {
         error("Missing file '"@ %emptyDB @"/performance_schema/db.opt'! Can't continue! Please verify integrity of game cache via Steam!");
         return false;
      }
      if(!pathCopy(%emptyDB, %worldDir))
      {
         error("Can't copy from '"@%emptyDB@"' to '"@%worldDir@"'!");
         return false;
      }
      return true;
   }

   function backupWorld(%worldId)
   {
      %configDir = getServerConfigFolder();
      // original path
      %origin = %configDir @ "world_"@%worldId@"_db";
      %destin = %configDir @ "backup/world_"@%worldId@"_db";
      %deleted = removeFolderWithAllFiles(%destin);
      %copied = pathCopy(%origin, %destin);
      hack("backupWorld for world", %worldId, "results - deleted prev folder:", %deleted, "copied new:", %copied);
   }

   function dropCommonDB(%worldId)
   {
      // launch the mysql_embedded and perform "drop database `lif_%d`;" on it
      %objName = "cphMyCommonDB"@%worldId;
      new ChildProcessHelper(%objName)
      {
         class = "cphMyCommonDB";
      };
      return %objName.prepareAndDropDB(%worldId);
   }
   function createCommonDB(%worldId)
   {
      // launch the mysql_embedded and perform "CREATE DATABASE `lif_%d`;" on it
      %objName = "cphMyCommonDB"@%worldId;
      new ChildProcessHelper(%objName)
      {
         class = "cphMyCommonDB";
      };
      %objName.prepareAndCreateDB(%worldId);
   }
   function importCommonDB(%worldId, %file)
   {
      // launch the mysql_embedded and perform "SOURCE filename;" on it
      %objName = "cphMyCommonDB"@%worldId;
      new ChildProcessHelper(%objName)
      {
         class = "cphMyCommonDB";
      };
      %objName.prepareAndImportDB(%worldId, %file);
   }
   function doCommonDB(%worldId, %sql)
   {
      // launch the mysql_embedded and perform given sql command on it
      %objName = "cphMyCommonDB"@%worldId;
      new ChildProcessHelper(%objName)
      {
         class = "cphMyCommonDB";
      };
      %objName.prepareAndDoCMD(%worldId, %sql);
   }
   function   cphMyCommonDB::prepEmbedded(%this, %worldId)
   {
      if(isObject(cphMariaDB))
      {
         cphMariaDB.terminateProcess();
         cphMariaDB.schedule(256, delete);
         backtrace();
         _lifError(2225, "MD205");
         %this.schedule(128, delete);
         return false;
      }
      %this.execStatus = 0; // Nothing, 1 for OK, 2 for warning
      %this.appName = "MyCommonDB_"@%worldId;
      %this.appPath = $ChildProcessHelper::mariaDBEmbeddedPath;
      %this.appArgs = "-B -n -N --show-warnings -v -v";
      if(isDebugBuild())
         %this.appArgs = %this.appArgs SPC "-v";
      %this.onExitCallback = "";
      %this.callbackObject = "";
      %this.redirectStdIO = true;
      %this.showWindow = false;
      %this.slashAlias = "";
      if(!fileExists(%this.appPath))
      {
         _lifError(2224, "MD204-E");
         %this.schedule(128, delete);
         return false;
      }
      %this.addKeywordCallback("onReadyForConnections", "mysqld.exe : ready for connections.", true);
      %this.addKeywordCallback("onShutdownComplete", ": Shutdown complete ", true);
      return true;
   }
   function   cphMyCommonDB::prepErrorHandling(%this)
   {
      %this.addKeywordCallback("onError", "error", true);
      %this.addKeywordCallback("onCorrupt", "corrupt", true);
      %this.addKeywordCallback("onFailed", "failed", true);
      %this.addKeywordCallback("onWarning", "Note (Code", true);
      %this.addKeywordCallback("onOK", "Query OK", true);
   }
   function   cphMyCommonDB::prepareAndDoCMD(%this, %worldId, %sql)
   {
      if(!%this.prepEmbedded(%worldId))
         return false;
      %this.prepErrorHandling();
      %this.appArgs = %this.appArgs SPC "-e \""@%sql@"\"";
      return %this.launchProcess();
   }
   function   cphMyCommonDB::onOK(%this, %line)
   {
      hack("cphMyCommonDB::onOK", %this);
      %this.execStatus = 1;
   }
   function   cphMyCommonDB::onWarning(%this, %line)
   {
      hack("cphMyCommonDB::onWarning", %this);
      %this.execStatus = 2;
   }
   function   cphMyCommonDB::prepareAndDropDB(%this, %worldId)
   {
      if(!%this.prepEmbedded(%worldId))
         return false;
      %this.prepErrorHandling();
      %this.appArgs = %this.appArgs SPC "-e \"DROP DATABASE IF EXISTS `lif_"@%worldId@"`\";";
      return %this.launchProcess();
   }
   function   cphMyCommonDB::prepareAndCreateDB(%this, %worldId)
   {
      if(!%this.prepEmbedded(%worldId))
         return false;
      %this.prepErrorHandling();
      %this.appArgs = %this.appArgs SPC "-e \"CREATE DATABASE IF NOT EXISTS `lif_"@%worldId@"`\";";
      return %this.launchProcess();
   }
   function   cphMyCommonDB::prepareAndImportDB(%this, %worldId, %file)
   {
      if(!%this.prepEmbedded(%worldId))
         return false;
      %this.appArgs = %this.appArgs SPC "--database=lif_"@%worldId@" -e \"source "@ %file @"\";";
      return %this.launchProcess();
   }

   function cphMyCommonDB::errorHandler(%this)
   {
      hack("cphMyCommonDB::errorHandler");
      // Forcing shutdown of the game server, as it is not possible to continue running it without DB
      //TODO!!!!!!!!
      if(isObject(cphGameServer))
      {
         error("Forcing terminateProcess on cphGameServer!");
         cphGameServer.terminateProcess();
      }
      error("Forcing terminateProcess on cphMyCommonDB!");
      %this.terminateProcess();
      %this.schedule(128, delete);
      _lifError(2219, "MD203-2");
   }

   function cphMyCommonDB::onError(%this, %line)
   {
      %this.errorHandler(%line);
   }
   function cphMyCommonDB::onCorrupt(%this, %line)
   {
      %this.errorHandler(%line);
   }
   function cphMyCommonDB::onFailed(%this, %line)
   {
      %this.errorHandler(%line);
   }

   function cphMyCommonDB::onFinished(%this, %success, %retCode)
   {
      echo("cphMyCommonDB::onFinished", %this, %success, %retCode);
      if(!%success || %retCode != 0)
      {
         error("Failed!!! Success:", %success, "retCode:", %retCode);
         %this.schedule(128, delete);
         return;
      }
      if(%this.warning)
         warn("Success:", %success, "retCode:", %retCode, "Ok:", %this.ok, "Warninig:", %this.warning);
      else
      if(%this.ok)
         hack("Success:", %success, "retCode:", %retCode, "Ok:", %this.ok, "Warninig:", %this.warning);
      else
         echo("Success:", %success, "retCode:", %retCode, "Ok:", %this.ok, "Warninig:", %this.warning);
      if(%this.callbackOnDone !$= "")
      {
         schedule(0, 0, eval, %this.callbackOnDone);
      }
      %this.schedule(0, delete);
   }

   function cphMyCommonDB::onReadyForConnections(%this, %line)
   {
      hack("cphMyCommonDB::onReadyForConnections", %this);
   }

   function cphMyCommonDB::onShutdownComplete(%this, %line)
   {
      hack("cphMyCommonDB::onShutdownComplete", %this);
      %this.schedule(0, delete);
   }


   //---------------------------------------------------------------------
   // MariaDB for exporting data
   //---------------------------------------------------------------------
   function exportCommonDB(%worldId, %callback)
   {
      // launch the mysqld and perform "drop database `lif_%d`;" on it
      %objName = "cphMariaDBExport";
      new ChildProcessHelper(%objName)
      {
         class = "cphMaria_DB";
      };
      return %objName.prepareAndExportDB(%worldId, %callback);
   }
   function cphMariaDBExport::prepareAndExportDB(%this, %worldId, %callback)
   {
      %this.worldId = %worldId;
      if(!%this.prepare(true))
         return false;
      $LocalWorldID = %worldId;
      %this.shutdownRoutine = "prepAndKillMariaDB(\"quit\");";
      // Add callbacks
      %this.addKeywordCallback("onReadyForConnections", "mysqld.exe : ready for connections.", true);
      %this.addKeywordCallback("onShutdownComplete", ": Shutdown complete ", true);
      %this.addKeywordCallback("onError32", "error number 32", true);
      %this.addKeywordCallback("onDBCorrupted", "Database page corruption on disk or a failed", true);
      %this.addKeywordCallback("onError2", "Operating system error number 2 in a file operation.", true);
      %this.callbackForDump = %callback;
      return %this.launchProcess();
   }
   function cphMariaDBExport::onReadyForConnections(%this, %line)
   {
      hack("cphMariaDBExport::onReadyForConnections", %this);
      schedule(0, 0, mysqldumpDatabase, %this.callbackForDump);
   }

   //---------------------------------------------------------------------
   // mysqldump
   //---------------------------------------------------------------------
   function mysqldumpDatabase(%callback)
   {
      if(isObject(cphMysqlDump))
      {
         error("Already running!");
         return;
      }
      new ChildProcessHelper(cphMysqlDump);
      cphMysqlDump.prepare(%callback);
      cphMysqlDump.dumpDatabase();
   }
   function cphMysqlDump::prepare(%this, %callback)
   {
      %this.appName = "MariaDB";
      %this.appPath = $ChildProcessHelper::mysqldumpPath;
      %authInfo = "-u root -p"@ $ChildProcessHelper::mariaDBPass;
      %pipeName = "--pipe --socket="@ $ChildProcessHelper::mariaDBPipe;
      %resultsFile = $ChildProcessHelper::worldConfigPath @ "lif_"@ $LocalWorldID @".sql";
      %misc = "-x --disable-keys --hex-blob --result-file="@ %resultsFile;
      %dbName = "lif_"@$LocalWorldID;
      %this.appArgs = $ChildProcessHelper::mariaDBArgs SPC %authInfo SPC %pipeName SPC %misc SPC %dbName;
      %this.onExitCallback = "";
      %this.callbackObject = "";
      %this.redirectStdIO = true;
      %this.showWindow = false;
      %this.slashAlias = "";
      %this.callbackOnDone = %callback;
   }
   function cphMysqlDump::dumpDatabase(%this)
   {
      if(!fileExists(%this.appPath))
      {
         _lifError(2224, "MD204-D");
         %this.schedule(128, delete);
         return;
      }
      %this.launchProcess();
   }
   function cphMysqlDump::onFinished(%this, %success, %retCode)
   {
      hack("cphMysqlDump::onFinished", %this, %success, %retCode);
      if(%this.callbackOnDone !$= "")
      {
         hack("Shut down MariaDB...");
         prepAndKillMariaDB(%this.callbackOnDone);
      }
      else
      {
         hack("Not calling anything, as no callback was given!!!");
      }
      %this.schedule(0, delete);
   }
   //---------------------------------------------------------------------
   // Local piped MariaDB
   //---------------------------------------------------------------------
   function prepAndKillMariaDB(%callback)
   {
      if(!isObject(cphMyAdmin))
         new ChildProcessHelper(cphMyAdmin);
      if(cphMyAdmin.shutdownInitiated)
      {
         error("cphMyAdmin is already running shutdown command!");
         return;
      }
      cphMyAdmin.shutdownInitiated = true;
      cphMyAdmin.prepare(%callback);
      cphMyAdmin.shutdownMariaDB();
   }
   function cphMaria_DB::prepare(%this, %skipDataDir)
   {
      %this.appName = "MariaDB";
      %this.appPath = $ChildProcessHelper::mariaDBPath;
      %addParams = "--standalone --console";
      %pipeName = "--socket="@ $ChildProcessHelper::mariaDBPipe;
      if(%skipDataDir)
         %dataDir = "";
      else
         %dataDir = "--datadir="@$ChildProcessHelper::worldConfigPath@"world_"@$LocalWorldID@"_db";
      //%dataDir = "--datadir="@".\\server\\config\\"@"world_"@$LocalWorldID@"_db";
      %this.appArgs = $ChildProcessHelper::mariaDBArgs SPC %addParams SPC %pipeName SPC %dataDir;
      %this.onExitCallback = "";
      %this.callbackObject = "";
      %this.redirectStdIO = true;
      %this.showWindow = false;
      %this.slashAlias = "";
      if(!fileExists(%this.appPath))
      {
         _lifError(2208, "MD201-1");
         %this.schedule(128, delete);
         return false;
      }
      return true;
   }
   function cphMaria_DB::prepareAndLaunch(%this)
   {
      if(!%this.prepare())
         return false;
      %this.shutdownRoutine = "prepAndKillMariaDB(\"quit\");";
      // Add callbacks
      %this.addKeywordCallback("onReadyForConnections", "mysqld.exe : ready for connections.", true);
      %this.addKeywordCallback("onShutdownComplete", ": Shutdown complete ", true);
      %this.addKeywordCallback("onError32", "error number 32", true);
      %this.addKeywordCallback("onDBCorrupted", "Database page corruption on disk or a failed", true);
      %this.addKeywordCallback("onError2", "Operating system error number 2 in a file operation.", true);
      return %this.launchProcess();
   }

   function cphMaria_DB::onError2(%this, %line)
   {
      hack("cphMaria_DB::onError2", %line);
      // Forcing shutdown of the game server, as it is not possible to continue running it without DB
      if(isObject(cphGameServer))
      {
         error("Forcing terminateProcess on cphGameServer!");
         cphGameServer.terminateProcess();
      }
      error("Forcing terminateProcess on cphMaria_DB!");
      %this.terminateProcess();
      %this.schedule(128, delete);
      _lifError(2219, "MD203-2");
   }

   function cphMaria_DB::onDBCorrupted(%this, %line)
   {
      hack("cphMaria_DB::onDBCorrupted", %line);
      // Forcing shutdown of the game server, as it is not possible to continue running it without DB
      if(isObject(cphGameServer))
      {
         error("Forcing terminateProcess on cphGameServer!");
         cphGameServer.terminateProcess();
      }
      error("Forcing terminateProcess on cphMaria_DB!");
      %this.terminateProcess();
      %this.schedule(128, delete);
      _lifError(2219, "MD203-1");
   }

   function cphMaria_DB::onData(%this, %line)
   {
      hack("cphMaria_DB::onData", %line);
   }

   function cphMaria_DB::onLaunched(%this)
   {
      hack("cphMaria_DB::onLaunched", %this);
   }

   function cphMaria_DB::onFinished(%this, %success, %retCode)
   {
      hack("cphMaria_DB::onFinished", %this, %success, %retCode);
      if(!%success || %retCode != 0)
      {
         error("Error #MD101: Can not start local instance of the database server. Please restart your computer and try again. If the problem still persist consider reinstalling the game.");
         _lifError(2201, "MD101"); // Error #MD101: Can not start local instance of the database server. Please restart your computer and try again. If the problem still persist consider reinstalling the game.
         %this.schedule(128, delete);
         return;
      }
      %this.schedule(0, delete);
      // backup the game data
      if(%this.needBackupOnShutdown)
         $shutdownNeedBackupWorld = $LocalWorldID;
   }

   function cphMaria_DB::onReadyForConnections(%this, %line)
   {
      hack("cphMaria_DB::onReadyForConnections", %this);
      schedule(0, 0, startLocalWorld);
   }

   function cphMaria_DB::onError32(%this, %line)
   {
      hack("cphMaria_DB::onError32", %this);
      // Some other instance of MariaDB is already running, so something is not right.
      // Lets try to shut it down with myadmin!
      if(%this.error32tried)
      {
         %this.error32tried = true;
         prepAndKillMariaDB("");
      }
      %this.error32retries++;
      if(%this.error32retries = 32)
      {
         error("Error #MD102: Can not initialize database server, another instance is already running. Please restart your computer and try again. If the problem still persist consider reinstalling the game.");
         _lifError(2202, "MD102"); // Error #MD101: Can not initialize database server, another instance is already running. Please restart your computer and try again. If the problem still persist consider reinstalling the game.");
         %this.schedule(128, delete);
         return;
      }
   }

   function cphMaria_DB::onShutdownComplete(%this, %line)
   {
      hack("cphMaria_DB::onShutdownComplete", %this);
      %this.schedule(0, delete);
   }

   //---------------------------------------------------------------------
   // MyAdmin
   //---------------------------------------------------------------------
   function cphMyAdmin::prepare(%this, %cb)
   {
      hack("cphMyAdmin::prepare", %this, %cb);
      %this.appName = "MyAdmin";
      %this.appPath = $ChildProcessHelper::mariaAdminPath;
      if(!fileExists(%this.appPath))
      {
         _lifError(2208, "MD201-2");
         return;
      }
      %this.appArgs = "--no-beep --silent -u root -p"@ $ChildProcessHelper::mariaDBPass SPC "--pipe --socket="@ $ChildProcessHelper::mariaDBPipe;
      %this.onExitCallback = "";
      %this.callbackObject = "";
      %this.redirectStdIO = true;
      %this.showWindow = false;
      %this.slashAlias = "";
      %this.cb = %cb;
   }
   function cphMyAdmin::shutdownMariaDB(%this)
   {
      hack("cphMyAdmin::shutdownMariaDB", %this);
      %this.appArgs = "--shutdown_timeout=" @ $ChildProcessHelper::shutdownMariaTimeoutSec @ " shutdown" SPC %this.appArgs;
      %this.executeTimeout = $ChildProcessHelper::shutdownAdminTimeoutSec;
      %this.launchProcess();
   }

   function cphMyAdmin::onLaunched(%this)
   {
      hack("cphMyAdmin::onLaunched", %this);
   }

   function cphMyAdmin::onFinished(%this, %success, %retCode)
   {
      hack("cphMyAdmin::onFinished", %this, %success, %retCode);
      if(!%success)
      {
         _lifError(2209, "MD202");
         return;
      }
      // We do not check if return code, just kick off the world starting routine again
      %this.schedule(0, delete);
      if(%this.cb !$= "")
      {
         warn("calling:" SPC %this.cb);
         if(strstr(%this.cb, ");") == -1)
            call(%this.cb);
         else
            eval(%this.cb);
      }
   }

   //---------------------------------------------------------------------
   // GameServer
   //---------------------------------------------------------------------
   function cphGameServer::prepareAndLaunch(%this)
   {
      %this.appName = "GameServer";
      %this.appPath = $ChildProcessHelper::gameServerPath;
      if(!fileExists(%this.appPath))
      {
         _lifError(2203, "GS201");
         return;
      }
      %this.appArgs = "-worldID" SPC $LocalWorldID SPC "-dbPipeName" SPC "\\\\.\\pipe\\" @ $ChildProcessHelper::mariaDBPipe;
      %this.onExitCallback = "";
      %this.callbackObject = "";
      %this.redirectStdIO = true;
      %this.showWindow = false;
      %this.slashAlias = "s";
      %this.shutdownSlashCommand = "quit();";
      // Add callbacks
      %this.addKeywordCallback("onStartUpCheck", "Loading CmConfiguration", true);
      %this.addKeywordCallback("onSyntaxError", " - syntax error", true);
      %this.arrayObject = new ArrayObject();
      %this.launchProcess();
      %this.loadStep = 0;
      //CreateWorldWindow.onWorldStarting();
      //setEscState(EST_ShowGameEscMenu);
      //CreateWorldWindow.schedule(0, delete);
      setLoadingGuiText(GetMessageIDText(2132)); // Loading Server
   }

   function cphGameServer::onSyntaxError(%this, %line)
   {
      hack("cphGameServer::onSyntaxError", %this, %line);
      %script = getWord(%line, 0);
      %line = getWord(%line, 2);
      %debugInfo = "Script:" SPC %script NL "Line:" SPC (%line-1);
      _lifError(2214, "GS305", %debugInfo);
      %this.sendCommand("quit();");
   }

   function cphGameServer::onStartUpCheck(%this, %line)
   {
      hack("cphGameServer::onStartUpCheck", %this, %line);
      %this.loadStep++;
      %this.addKeywordCallback("onDBConnectError", "connection error #1045: Access denied for user", true);
      %this.addKeywordCallback("onDBOutOfMemory", "Out of memory; ", true); // MySQL errors 1037 & 1041
      %this.addKeywordCallback("onDBImportError", "You have an error in your SQL syntax", true);
      %this.addKeywordCallback("onWorldIdUsed", "Can't init server... looks like another instance is already started", true);
      %this.addKeywordCallback("onUDPInitFailed", "Unable to initialize UDP - error ", true);
      %this.addKeywordCallback("onUDPInitOK", "UDP initialized on port ", true);
      %this.addKeywordCallback("onDebugBreak", "Platform::debugBreak() -- triggered!", true);
   }

   function cphGameServer::onDBOutOfMemory(%this, %line)
   {
      hack("cphGameServer::onDBOutOfMemory", %this, %line);
      _lifError(2218, "GS309");
   }

   function cphGameServer::onDBImportError(%this, %line)
   {
      hack("cphGameServer::onDBImportError", %this, %line);
      _lifError(2217, "GS308");
   }

   function cphGameServer::onDBConnectError(%this, %line)
   {
      hack("cphGameServer::onDBConnectError", %this, %line);
      _lifError(2216, "GS307");
   }

   function cphGameServer::onDebugBreak(%this, %line)
   {
      hack("cphGameServer::onDebugBreak", %this, %line);
      _lifError(2215, "GS306");
   }
   function cphGameServer::onWorldIdUsed(%this, %line)
   {
      hack("cphGameServer::onWorldIdUsed", %this, %line);
      _lifError(2211, "GS302");
   }

   function cphGameServer::onUDPInitFailed(%this, %line)
   {
      hack("cphGameServer::onUDPInitFailed", %this, %line);
      %cnt = getWordCount(%line);
      %errorId = getWord(%line, %cnt - 1);
      _lifError(2210, "GS301-"@%errorId);
   }

   function cphGameServer::onUDPInitOK(%this, %line)
   {
      hack("cphGameServer::onUDPInitOK", %this, %line);
      %cnt = getWordCount(%line);
      %this.netPort = getWord(%line, %cnt - 1);
      %this.loadStep++;
      %this.removeCallback("onUDPInitFailed");
      %this.remoteCallback("onDBImportError");
      %this.addKeywordCallback("onReadyForConnectionsTickOn", "> Steam initialized", true);
      %this.addKeywordCallback("onReadyForConnectionsTickOff", "] Steam initialized", true);
   }

   function cphGameServer::onReadyForConnectionsTickOn(%this, %line)
   {
      %this.removeCallback("onReadyForConnectionsTickOff");
      %this.onReadyForConnections(%line);
   }
   function cphGameServer::onReadyForConnectionsTickOff(%this, %line)
   {
      %this.removeCallback("onReadyForConnectionsTickOn");
      %this.onReadyForConnections(%line);
   }
   function cphGameServer::onReadyForConnections(%this, %line)
   {
      hack("cphGameServer::onReadyForConnections", %this, %line);
      %this.initialized = true;
      if(%this.loadStep != 12)
         error("Something is wrong! The startup step doesn't match");
      schedule(32, %this, onLocalServerLoaded);

      %this.removeCallback("onSyntaxError");
      %this.removeCallback("onWorldIdUsed");

      %this.addKeywordCallback("onShutdownComplete", "The server has been shut down!", true);
      %this.addKeywordCallback("pingPongResponse", "PING RESPONSE: PONG AT");
      %this.schedule(60, sendPing);
   }

   function cphGameServer::onShutdownComplete(%this, %line)
   {
      hack("cphGameServer::onShutdownComplete", %this, %line);
      if(isObject(cphMariaDB))
         cphMariaDB.shutdown();
   }

   function cphGameServer::sendPing(%this)
   {
      %this.pingTick++;
      if(%this.pingTick >= 4)
         %this.pingTick = 0;
      %simtime = getSimTime();
      %this.sendCommand("ping("@%this.pingTick@","@getSimTime()@");");
      %this.arrayObject.add(%simtime, %this.pingTick);
      %diff = %simtime - %this.lastMessage();
      %time = 3 * 60 * 1000;
      if(%diff > %time)
      {
         error("No response from the GameServer for 3 minutes! Forcing shut down!");
         %this.terminateProcess();
         schedule(512, RootGroup, quit);
      }
      %this.schPing = %this.schedule(60 * 1000, sendPing);
   }

   function cphGameServer::pingPongResponse(%this, %line)
   {
      %simtime = getWord(%line, getWordCount(%line) - 1);
      %srvtime = getWord(%line, getWordCount(%line) - 2);
      %idx = %this.arrayObject.getIndexFromKey(%simtime);
      %msg = "Got ping response from the server in" SPC (getSimTime()-%simtime) SPC "ms, diff with server:" SPC (getSimTime()-%srvtime);
      if(%idx != -1)
      {
         // We have it recorded.
         %val = %this.arrayObject.getValue(%idx);
         %this.arrayObject.erase(%idx);
         switch(%val)
         {
            case 0:
               echo(%msg);
            case 1:
               warn(%msg);
            case 2:
               hack(%msg);
            case 3:
               error(%msg);
            default:
               error(%msg);
               error("Unrecognized level:", %val);
         }
      }
      else
      {
         hack(%msg);
         error("Can't find given ping as recorded pings!");
      }
   }

   function cphGameServer::onFinished(%this, %success, %retCode)
   {
      hack("cphGameServer::onShutdownComplete", %this, %success, %retCode);
      %this.schedule(128, delete);
      if($lifErrorHandled)
         return;
      if(!%success)
      {
         // Can't launch EXE file. EXE failed to start up [can't createProcess()]
         _lifError(2204, "GS202-"@%retCode);
         return;
      }
      if(!%this.initialized || !%this.isShuttingDown)
      {
         if(!%this.initialized)
         {
            // Can't start up the server didn't finished initialization for some reason.
            _lifError(2205, "GS203-"@%retCode);
            return;
         }
         else
         {
            // The server have crashes
            _lifError(2206, "GS204-"@%retCode);
            return;
         }
      }
      if(%retCode != 0)
      {
         _lifError(2207, "GS205-"@%retCode);
         return;
      }
      hack("cphGameServer has been shut down successfully:", %success, %retCode);
      if(isObject(cphMariaDB))
         cphMariaDB.needBackupOnShutdown = true;
   }

   function cphGameServer::onRemove(%this)
   {
      if(isObject(%this.arrayObject))
         %this.arrayObject.delete();
      Parent::onRemove(%this);
   }

   //---------------------------------------------------------------------
   // Support/helper function
   //---------------------------------------------------------------------

   function _disconnectedCleanupFinalDone(%needQuit)
   {
      if(cmChatExist())
         cmChatShutdown("Goodbye cruel world!");

      if(isObject(cphGameServer))
      {
         if(!cphGameServer.isShuttingDown)
         {
            hack("Forcing cphGameServer to shutdown now!");
            cphGameServer.isShuttingDown = true;
            cphGameServer.shutdown();
         }
         cphGameServer.shutdownTickCount++;
         hack("cphGameServer is shutting down, hold on!");
         if(cphGameServer.shutdownTickCount > 20)
         {
            error("Server doesn't response for a long time, terminating the process!");
            cphGameServer.terminateProcess();
            cphGameServer.delete();
         }
         schedule(256, RootGroup, _disconnectedCleanupFinalDone, %needQuit);
         return;
      }
      if(isObject(cphMariaDB))
      {
         if(!cphMariaDB.isShuttingDown)
         {
            hack("Forcing cphMariaDB to shutdown now!");
            cphMariaDB.isShuttingDown = true;
            cphMariaDB.shutdown();
         }
         cphMariaDB.shutdownTickCount++;
         if(cphMariaDB.shutdownTickCount > 20)
         {
            error("MariaDB doesn't response for a long time, terminating the process!");
            cphMariaDB.terminateProcess();
            cphMariaDB.delete();
         }
         hack("cphMariaDB is shutting down, hold on!");
         schedule(256, RootGroup, _disconnectedCleanupFinalDone, %needQuit);
         return;
      }
      if($shutdownNeedBackupWorld)
      {
         backupWorld($shutdownNeedBackupWorld);
         $shutdownNeedBackupWorld = 0;
      }
      // Looks like everything has been shutdown now, so we can actually quit!
      hack("Looks like everything has been shutdown now, so we can actually quit!");
      _disconnectedCleanupMakeQuit(%needQuit);
   }

   function ChildProcessHelper::onAdd(%this)
   {
      hack(%this, %this.getName());
   }
   function ChildProcessHelper::onRemove(%this)
   {
      hack(%this, %this.getName());
   }
   function ChildProcessHelper::shutdown(%this)
   {
      if(%this.shutdownMethod !$= "")
      {
         %this.call(%this.shutdownMethod);
         return;
      }
      if(%this.shutdownSlashCommand !$= "")
      {
         %this.sendCommand(%this.shutdownSlashCommand);
         return;
      }
      if(%this.shutdownRoutine !$= "")
      {
         eval(%this.shutdownRoutine);
         return;
      }
      error("Error:", %this.getName(), "doesn't have shutdown instruction. Specify %this.shutdownSlashCommand (to send to child process) or %this.shutdownRoutine (to call eval() on it)!");
   }
   function _lifError(%msgCode, %errCode, %debugInfo)
   {
      error("_lifError(" @ %msgCode @ ", \"" @ %errCode @ "\", \"" @ %debugInfo @ "\") - " @ GetMessageIDText(%msgCode));

      $lifErrorHandled = true;
      backtrace();
      if(ConsoleDlg.isAwake())
         Canvas.popDialog(ConsoleDlg);
      schedule(0, RootGroup, loadLoadingGui, GetMessageIDText(2199));
      %title = GetMessageIDText(2199) SPC %errCode;
      %message = GetMessageIDText(%msgCode);
      %cb = "_askToGenerateCrashReport("@%msgCode@",\""@%errCode@"\"); if(isObject(ServerConnection)) ServerConnection.schedule(0, delete); schedule(0, RootGroup, loadLoadingGui, GetMessageIDText(2199));";
      if(%debugInfo !$= "")
         %message = %message NL %debugInfo;
      schedule(0, RootGroup, MessageBoxOK, %title, %message, %cb);
   }
   function _askToGenerateCrashReport(%msgCode, %errCode)
   {
      // Ask a player to generate a report
      if(!$lifCrashReportGenerated)
      {
         $lifCrashReportGenerated = true;
         %title = GetMessageIDText(2199); // Error title
         %message = GetMessageIDText(2200); // Ask to generate crash report
         %cbYes = "askToGenerateCrashReport("@%msgCode@",\""@%errCode@"\");";
         %cbNo = "scheduleQuit(3000,"@%msgCode@");";
         MessageBoxYesNo(%title, %message, %cbYes, %cbNo);
         //askToGenerateCrashReport(%msgCode, %errCode);
         //hack("Scheduling exit in 10 seconds.");
         //schedule(10000, RootGroup, quit);
      }
      else
      {
         hack("Forcing exit in 10 seconds.");
         scheduleQuit(10000, %msgCode);
         //schedule(10000, RootGroup, quit);
      }
   }

   function dumpEnhancedInfoReport()
   {
      listAllServers();
      // TODO: Dump here as much as possible
      dumpSysInfo("dumpEnhancedInfoReport");
      hack("MariaDB pipe:", $ChildProcessHelper::mariaDBPipe, "open:", checkNamedPipeOpen($ChildProcessHelper::mariaDBPipe));
      %cnt = isObject(ChildProcessHelperSet) ? ChildProcessHelperSet.getCount() : 0;
      hack("ChildProcessHelpers count:", %cnt);
      for(%i=0;%i<%cnt;%i++)
      {
         %cph = ChildProcessHelperSet.getObject(%cnt);
         echo(%cph.getName(), "Running:", %cph.isRunning(), "RetCode:", %cph.getReturnCode(), "LastMessage:", %cph.lastMessage());
         %cph.dumpFields();
      }
   }
   function scheduleQuit(%timeout, %msgId)
   {
      if(%timeout == 0)
         %timeout = 10000;
      if(%msgId == 0)
         %msgId = 1386;
      loadLoadingGui(GetMessageIDText(%msgId));
      schedule(%timeout, RootGroup, quit);
   }
}; // YoPackage

activatePackage(YoPackage);
hack("v" @ getCmVersionString());
