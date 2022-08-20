/**
* <author>Christophe Roblin</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits></credits>
* <description>Disconnects user on preConnect if server is full</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxFullServerFix))
{
    new ScriptObject(LiFxFullServerFix)
    {
    };
}


package LiFxFullServerFix
{
  function LiFxFullServerFix::setup() {
    LiFx::registerCallback($LiFx::hooks::onPreConnectRequestCallbacks, onPreConnectRequest, LiFxFullServerFix);
  }
  function LiFxFullServerFix::version() {
    return "0.0.1";
  }

  function LiFxFullServerFix::onPreConnectRequest(%this, %client, %nettAddress, %name) {
    LiFx::debugEcho($Server::PlayerCount SPC $Server::MaxPlayers );
    if ($Server::PlayerCount >= $Server::MaxPlayers)
    {
        warn("Connection from" SPC %netAddress SPC "(" @ %name @ ")" SPC "dropped due to CR_SERVERFULL");
        %client.scheduleDelete("Server is full", 100);
    }    
  }
};
activatePackage(LiFxFullServerFix);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxFullServerFix);