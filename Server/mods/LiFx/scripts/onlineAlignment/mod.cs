/**
* <author>Christophe Roblin</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Nyton for original idea: https://lifeisfeudal.com/forum/alignment-setting-at-every-restart-t14901/#p158603</credits>
* <description>This will adjust alignment for every online player based on settings in LiFx/config.cs</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

exec("mods/lifx/config.cs");
if(!$LiFx::AlignmentUpdateMinutes)
  $LiFx::AlignmentUpdateMinutes = 1;
if(!$LiFx::AlignmentUpdateDelta)
  $LiFx::AlignmentUpdateDelta = 1;

if (!isObject(LiFxAlignment))
{
    new ScriptObject(LiFxAlignment)
    {
    };
}
package LiFxAlignment
{
  function LiFxAlignment::setup() {
    LiFx::registerCallback($LiFx::hooks::onStartCallbacks,start, LiFxAlignment);
  }
  function LiFxAlignment::start() {
    LiFxAlignment::AlignmentUpdate();
    echo("LiFxAlignment has been loaded");
  }
  function LiFxAlignment::AlignmentUpdate( ) {
    foreach(%player in PlayerList) %player.changeAlignment($LiFx::AlignmentUpdateDelta);
    LiFxAlignment.schedule($LiFx::AlignmentUpdateMinutes * 60000, AlignmentUpdate);
  }
};
activatePackage(LiFxAlignment);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxAlignment);