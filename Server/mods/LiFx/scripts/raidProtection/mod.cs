/**
* <author>Christophe Roblin</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits></credits>
* <description></description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/
if (!isObject(LiFxRaidProtection))
{
    new ScriptObject(LiFxRaidProtection)
    {
    };
}
if (isObject(LiFxRaidProtectionTrigger))
{
    LiFxRaidProtectionTrigger.delete();
}
exec("mods/lifx/config.cs");
datablock TriggerData(LiFxRaidProtectionTrigger)
{
    local = 1;
    tickPeriodMs = 1000;
};
if(!isDefined("$LiFx::raidProtection::timeToProtection"))
{
  echo("Raid protection not configured, setting default 5 min");
  $LiFx::raidProtection::timeToProtection = 5;
}

$LiFxRaidProtection::triggers = new SimGroup("");
package LiFxRaidProtection {
  function LifXRaidprotection::table() {
    return "LiFx_character";
  }
  function LiFxRaidProtection::setup() {
    LiFx::registerCallback($LiFx::hooks::onJHStartCallbacks,addProtection, LiFxRaidProtection);
    LiFx::registerCallback($LiFx::hooks::onJHEndCallbacks,forceRemoveProtection, LiFxRaidProtection);
    LiFx::registerCallback($LiFx::hooks::onConnectCallbacks,onConnectClient, LiFxRaidProtection);
    LiFx::registerCallback($LiFx::hooks::onDisconnectCallbacks,onDisconnectClient, LiFxRaidProtection);
    LiFx::registerCallback($LiFx::hooks::onCharacterCreateCallbacks,addCharacter, LiFxRaidProtection);
    LiFx::registerCallback($LiFx::hooks::onPostInitCallbacks,onPostInit, LiFxRaidProtection);
    LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks,dbChanges, LiFxRaidProtection);
  }
  function LiFxRaidProtection::version() {
    return "1.0.2";
  }
  function LifXRaidprotection::dbChanges() {
    dbi.Update("ALTER TABLE `guild_standings` CHANGE COLUMN `StandingTypeID` `StandingTypeID` TINYINT(3) UNSIGNED NOT NULL DEFAULT '3' AFTER `GuildID2`;");
    dbi.Update("CREATE TABLE IF NOT EXISTS `" @ LifXRaidprotection::table() @ "` (	`id` INT UNSIGNED NOT NULL,	`active` BIT NULL DEFAULT NULL,	`loggedIn` TIMESTAMP NULL DEFAULT NULL,	`loggedOut` TIMESTAMP NULL DEFAULT NULL,	PRIMARY KEY (`id`),	CONSTRAINT `fk_character_id` FOREIGN KEY (`id`) REFERENCES `character` (`ID`) ON UPDATE NO ACTION ON DELETE CASCADE) COLLATE='utf8_unicode_ci';");
    dbi.Update("INSERT `" @ LifXRaidprotection::table() @ "` SELECT distinct ID, null, null, null FROM `character` c WHERE NOT EXISTS (select * FROM `" @ LifXRaidprotection::table() @ "` lifxc WHERE lifxc.id = c.ID);");
    dbi.Update("UPDATE `" @ LifXRaidprotection::table() @ "` SET active = 0;");
    dbi.Update("DROP TRIGGER IF EXISTS `character_lifx_after_insert`;");
    %sql = "CREATE TRIGGER `character_lifx_after_insert`\n";
    %sql = %sql @ "AFTER INSERT\n";
    %sql = %sql @ "ON `character`\n";
    %sql = %sql @ "FOR EACH ROW\n";
    %sql = %sql @ "BEGIN\n";
    %sql = %sql @ "  INSERT INTO `" @ LifXRaidprotection::table() @ "` VALUES (NEW.ID, 0, NULL, NULL);\n";
    %sql = %sql @ "END;\n";
    dbi.Update(%sql);
    dbi.Update("UPDATE `" @ LifXRaidprotection::table() @ "` SET active = 0;");
  }
  function LiFxRaidProtection::addProtection(%this, %rs) {
    if(!%rs)
      dbi.Select(LifXRaidprotection, "addProtection", "SELECT g.Name, gl.CenterGeoID, gl.Radius, ret.actives, ret.total, ret.GuildID FROM ( SELECT SUM(lc.active) AS actives, COUNT(lc.active) AS total, c.GuildID AS GuildID FROM `" @ LifXRaidprotection::table() @ "` lc LEFT JOIN `character` c ON c.ID = lc.id GROUP BY c.GuildID ) AS ret LEFT JOIN `guilds` AS g ON ret.GuildID = g.ID LEFT JOIN `guild_lands` gl ON gl.GuildID = g.ID WHERE g.GuildTypeID > 2 AND ret.actives = 0 GROUP BY ret.GuildID");
    else {
      if(%rs.ok())
      {
        while(%rs.nextRecord()){
          echo("Total active players in guild" SPC %rs.getFieldValue("actives") @ "\n");
          echo("Total players in guild" SPC %rs.getFieldValue("total") @ "\n");
          LiFxRaidProtection::createProtection(%rs.getFieldValue("GuildID"),%rs.getFieldValue("Name"),%rs.getFieldValue("CenterGeoID"),%rs.getFieldValue("Radius"));
        }
      }
      dbi.remove(%rs);
      %rs.delete();
    }
  }
  function LiFxRaidProtection::onConnectClient(%this, %obj) {
    dbi.Update("UPDATE `" @ LifXRaidprotection::table() @ "` SET active = 1, loggedIn = now() WHERE id=" @ %obj.getCharacterId());
    dbi.Select(LifXRaidprotection, "removeProtection", "SELECT COUNT(*), g.ID, g.Name FROM `" @ LifXRaidprotection::table() @ "` lifxc LEFT JOIN `character` c ON c.ID = lifxc.id LEFT JOIN `character` cg ON c.GuildID = cg.GuildID LEFT JOIN `guilds` g ON g.ID = cg.GuildID WHERE g.GuildTypeID > 2 AND lifxc.id = " @ %obj.getCharacterId());
  }
  function LiFxRaidProtection::onDisconnectClient(%this, %obj) {
    dbi.Update("UPDATE `" @ LifXRaidprotection::table() @ "` SET active = 0, loggedOut = now() WHERE id=" @ %obj.getCharacterId());
    dbi.Select(LifXRaidprotection, "assessProtection", "SELECT COUNT(*), g.ID,  " @ %obj.getCharacterId() @ " as CharID FROM `" @ LifXRaidprotection::table() @ "` lifxc LEFT JOIN `character` c ON c.ID = lifxc.id LEFT JOIN `character` cg ON c.GuildID = cg.GuildID LEFT JOIN `guilds` g ON g.ID = cg.GuildID WHERE g.GuildTypeID > 2 AND 0 = (SELECT COUNT(*) FROM `" @ LifXRaidprotection::table() @ "` lc LEFT JOIN `character` c2 ON c2.ID = lc.id WHERE lc.active = 1) AND lifxc.active = 1 AND lifxc.id = " @ %obj.getCharacterId());
  }
  function LifXRaidprotection::addCharacter(){}
  function LifXRaidprotection::onPostInit(){}
  function LifXRaidprotection::assessProtection(%this, %rs) {
    if(%rs.ok() && %rs.nextRecord())
    {
      %count = %rs.getFieldValue("count");
      %GuildID = %rs.getFieldValue("ID");
      %CharID = %rs.getFieldValue("CharID");
      if(%count > 0 && %GuildID && %CharID > 0) {// Apply protection only when none are online
        LiFxRaidProtection.schedule($LiFx::raidProtection::timeToProtection * 60000, "verifyProtectionDB", %GuildID);
      }
      else if (%count == 0 && !%GuildID && %CharID > 0)
        dbi.Select(LifXRaidprotection, "assessProtection", "SELECT COUNT(*), g.ID,  c.id as CharID FROM `" @ LifXRaidprotection::table() @ "` lifxc LEFT JOIN `character` c ON c.ID = lifxc.id LEFT JOIN `character` cg ON c.GuildID = cg.GuildID LEFT JOIN `guilds` g ON g.ID = cg.GuildID WHERE lifxc.active = 0 AND g.GuildTypeID > 2 AND lifxc.id = " @ %CharID );
    }
    dbi.remove(%rs);
    %rs.delete();
  }
  function LiFxRaidProtection::verifyProtectionDB(%this,%GuildID) {
    dbi.Select(LifXRaidprotection, "verifyProtection", "SELECT COUNT(*), g.ID as GuildID, g.Name FROM `" @ LifXRaidprotection::table() @ "` lifxc  LEFT JOIN `character` c ON c.ID = lifxc.id LEFT JOIN `guilds` AS g ON c.GuildID = g.ID LEFT JOIN `guild_lands` gl ON gl.GuildID = g.ID  WHERE g.GuildTypeID > 2 AND lifxc.active = 1 AND c.GuildID = "@ %GuildID);
  }
  function LifXRaidprotection::verifyProtection(%this, %rs) {
    if(%rs.ok() && %rs.nextRecord())
    {
      %count = %rs.getFieldValue("count");
      %GuildID = %rs.getFieldValue("GuildID");
      %CenterGeoID = %rs.getFieldValue("CenterGeoID");
      if(%count == 0 && !%CenterGeoID) // Apply protection only when none are online
        dbi.Select(LifXRaidprotection, "verifyProtection", "SELECT gl.CenterGeoID, gl.Radius, g.ID AS GuildID, g.Name FROM `guild_lands` gl, `guilds` g WHERE g.ID = gl.GuildID AND g.ID = "@ %GuildID);
      else if(%CenterGeoID)
        LiFxRaidProtection::createProtection(%rs.getFieldValue("GuildID"),%rs.getFieldValue("Name"),%rs.getFieldValue("CenterGeoID"),%rs.getFieldValue("Radius") );
    }
    dbi.remove(%rs);
    %rs.delete();
  }
  function LiFxRaidProtection::createProtection(%GuildID, %Name, %CenterGeoID, %Radius) {
    LiFx::debugEcho(%GuildID SPC %Name SPC %CenterGeoID SPC %Radius);
    if (isObject(cmChildObjectsGroup) && IsJHActive())
    {
      echo("Creating protection for guild" SPC %Name @ "\n");
      LiFxRaidProtection::addProtectionToModels(LiFxRaidProtection::findShapeFiles("monument_01.xyz", cmChildObjectsGroup), %GuildID, %Name, %CenterGeoID, %Radius);
      LiFxRaidProtection::addProtectionToModels(LiFxRaidProtection::findShapeFiles("monument_02.xyz", cmChildObjectsGroup), %GuildID, %Name, %CenterGeoID, %Radius);
      LiFxRaidProtection::addProtectionToModels(LiFxRaidProtection::findShapeFiles("monument_03.xyz", cmChildObjectsGroup), %GuildID, %Name, %CenterGeoID, %Radius);
      LiFxRaidProtection::addProtectionToModels(LiFxRaidProtection::findShapeFiles("monument_04.xyz", cmChildObjectsGroup), %GuildID, %Name, %CenterGeoID, %Radius);
    }
  }
  function LiFxRaidProtection::addProtectionToModels(%models, %GuildID, %Name, %CenterGeoID, %Radius) {
    LiFx::debugEcho(%models.length SPC %GuildID SPC %Name SPC %CenterGeoID SPC %Radius);
    foreach( %obj in %models ){
      if(%CenterGeoID $= LiFxRaidProtection::getGeoID(%obj.position))
      {
        %Radius = (%Radius * 2) + 5;
        %guildinfo = new ScriptObject("");
        %guildinfo.id = %GuildID;
        %guildinfo.name = %Name;
        foreach(%gi in $LiFxRaidProtection::triggers)
          if(%gi.name $= %Name)
            return;
        %shield = new TSStatic() {
            shapeName = "mods/LiFx/scripts/raidProtection/divineShield.dts";
            playAmbient = "1";
            meshCulling = "0";
            originSort = "0";
            collisionType = "Visible Mesh";
            decalType = "Visible Mesh";
            allowPlayerStep = "0";
            alphaFadeEnable = "0";
            alphaFadeStart = "100";
            alphaFadeEnd = "150";
            alphaFadeInverse = "0";
            renderNormals = "0";
            forceDetail = "-1";
            position = %obj.position;
            rotation = "1 0 0 0";
            scale = (%Radius + 5) SPC (%Radius + 5) SPC %Radius; //"1 1 1";
            canSave = "1";
            canSaveDynamicFields = "1";
        };
        %z = nextToken(nextToken(%obj.position, "x", " "), "y", " ");
        %triggerPos = %x SPC %y SPC (%z - (%Radius / 2));
        %trigger = new Trigger() {
            polyhedron = "-0.5 0.5000000 0.0 1.0 0.0 0.0 0.0 -1.0 0.0 0.0 0.0 1.0";
            dataBlock = "LiFxRaidProtectionTrigger";
            position =  %triggerPos;//VectorScale( "1 1 1", %radius);
            rotation = "1 0 0 0";
            scale = (%Radius * 1.5) SPC (%Radius * 1.5) SPC (%Radius * 5);
            canSave = "1";
            canSaveDynamicFields = "1";
            radius = %Radius;
        };
        %trigger.setHidden(1);
        %guildinfo.shield = %shield;
        %guildinfo.trigger = %trigger;
        $LiFxRaidProtection::triggers.add(%guildinfo);
      }
    }
  }
  
  function LiFxRaidProtection::forceRemoveProtection(%this, %rs) {
    if(!%rs)
      dbi.Select(LifXRaidprotection, "forceRemoveProtection", "SELECT g.Name FROM `guilds` AS g WHERE g.GuildTypeID > 2");
    else {
      if(%rs.ok())
      {
        while(%rs.nextRecord()) 
        {
          echo("Registered triggers:" SPC $LiFxRaidProtection::triggers.getCount());
          for(%i = 0; %i < $LiFxRaidProtection::triggers.getCount(); %i++) {
            echo("Checking:" SPC %rs.getFieldValue("Name"));
            if($LiFxRaidProtection::triggers.getObject(%i).name $= %rs.getFieldValue("Name")) {
              echo("Removing:" SPC $LiFxRaidProtection::triggers.getObject(%i).name);
              $LiFxRaidProtection::triggers.getObject(%i).shield.delete();
              $LiFxRaidProtection::triggers.getObject(%i).Trigger.delete();
              $LiFxRaidProtection::triggers.getObject(%i).delete();
            }
          }
        }
      }
      dbi.remove(%rs);
      %rs.delete();
    }
  }
  function LiFxRaidProtection::removeProtection(%this, %rs) {
    if(!%rs)
      dbi.Select(LifXRaidprotection, "removeProtection", "SELECT g.Name, gl.CenterGeoID, gl.Radius, ret.actives, ret.total, ret.GuildID FROM ( SELECT SUM(lc.active) AS actives, COUNT(lc.active) AS total, c.GuildID AS GuildID FROM `" @ LifXRaidprotection::table() @ "` lc LEFT JOIN `character` c ON c.ID = lc.id GROUP BY c.GuildID ) AS ret LEFT JOIN `guilds` AS g ON ret.GuildID = g.ID LEFT JOIN `guild_lands` gl ON gl.GuildID = g.ID WHERE g.GuildTypeID > 2 AND ret.actives = 0 GROUP BY ret.GuildID");
    else {
      if(%rs.ok())
      {
        while(%rs.nextRecord()) 
        {
          for(%i = 0; %i < $LiFxRaidProtection::triggers.getCount(); %i++) {
            if($LiFxRaidProtection::triggers.getObject(%i).name $= %rs.getFieldValue("Name")) {
              $LiFxRaidProtection::triggers.getObject(%i).shield.delete();
              $LiFxRaidProtection::triggers.getObject(%i).Trigger.delete();
              $LiFxRaidProtection::triggers.getObject(%i).delete();
            }
          }
        }
      }
      dbi.remove(%rs);
      %rs.delete();
    }
  }
  function LiFxRaidProtection::findShapeFiles( %shape, %group) {
    %rs = new SimSet(""){};
    foreach(%obj in %group){
      if(%obj.getClassName() $= "SimGroup") {
        LiFxRaidProtection.findShapeFiles(%shape,%obj);
      }
      else {
        if(%obj.getClassName() $= "SimSet") {
          LiFxRaidProtection.findShapeFiles(%shape,%obj);
        }
        else {
          if(%obj.getClassName() $= "TSStatic") {
            if(strpos(strlwr(%obj.shapeName), %shape) >= 0){
              %rs.add(%obj);
            }
          }
        }
      }
    }
    return %rs;
  }
  function LiFxRaidProtection::getGeoID(%position) {
    %z = nextToken(nextToken(%position, "x", " "), "y", " ");
    if (%x < -1024)
    {
        %x = mFloor((3064 + %x) * 0.25);
        if (%y < -1024)
        {
            
            %y = mFloor((3064 + %y) * 0.25);
            %t = 442;
        }
        else
        {
            if (%y < 1020)
            {
                %y = mFloor((1020 + %y) * 0.25);
                %t = 445;
            }
            else
            {
                %y = mFloor((%y - 1024) * 0.25);
                %t = 448;
            }
        }
    }
    else
    {
        if (%x < 1020)
        {
            %x = mFloor((1020 + %x) * 0.25);
            if (%y < -1024)
            {
                %y = mFloor((3064 + %y) * 0.25);
                %t = 443;
            }
            else
            {
                if (%y < 1020)
                {
                    %y = mFloor((1020 + %y) * 0.25);
                    %t = 446;
                }
                else
                {
                    %y = mFloor((%y - 1024) * 0.25);
                    %t = 449;
                }
            }
        }
        else
        {
            %x = mFloor((%x - 1024) * 0.25);
            if (%y < -1024)
            {
                %y = mFloor((3064 + %y) * 0.25);
                %t = 444;
            }
            else
            {
                if (%y < 1020)
                {
                    %y = mFloor((1020 + %y) * 0.25);
                    %t = 447;
                }
                else
                {
                    %y = mFloor((%y - 1024) * 0.25);
                    %t = 450;
                }
            }
        }
    }
    return ((%t << 18) | (%y << 9)) | %x;
  }
  function LiFxRaidProtectionTrigger::onEnterTrigger(%this, %trigger, %player) {
    %z = nextToken(nextToken(%player.position, "x", " "), "y", " ");
    %player.savePlayer();
    if(getRandom() > 0.5)
      %nX = %x - (%trigger.Radius * 1.3);
    else 
      %nX = %x + (%trigger.Radius * 1.3);
    if(getRandom() > 0.5)
      %nY = %y - (%trigger.Radius * 1.3);
    else 
      %nY = %y + (%trigger.Radius * 1.3);  
    %player.setTransform(LiFxRaidProtectionTrigger::createPositionTransform(%nX, %nY, %z + 15));
  }

  function LiFxRaidProtectionTrigger::onTickTrigger(%this, %trigger, %player) {
    for(%i = 0; %i < %trigger.getNumObjects(); %i++)
    {
      %player = %trigger.getObject(%i);
      if(%player.getClassName() $= "Player")
      {
        %z = nextToken(nextToken(%player.position, "x", " "), "y", " ");
        %player.savePlayer();
        if(getRandom() > 0.5)
          %nX = %x - (%trigger.Radius * 1.3);
        else 
          %nX = %x + (%trigger.Radius * 1.3);
        if(getRandom() > 0.5)
          %nY = %y - (%trigger.Radius * 1.3);
        else 
          %nY = %y + (%trigger.Radius * 1.3);  
        %player.setTransform(LiFxRaidProtectionTrigger::createPositionTransform(%nX, %nY, %z + 15));
      }
    }
    
  }


  function LiFxRaidProtectionTrigger::createPositionTransform(%x, %y, %z)
  {
          %vec = %x SPC %y SPC %z;
          %nullorientation = "0 0 0 0";
          return MatrixCreate(%vec, %nullorientation);
  }
};
activatePackage(LiFxRaidProtection);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxRaidProtection);
