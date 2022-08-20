function RestartServer(%minutes)
{
   CancelRestart();
   %shutdown = %minutes * 60000;
   %one = %shutdown - 60000;
   %two = %shutdown - 120000;
   %five = %shutdown - 300000;
   %ten = %shutdown - 600000;
   hack("Initiating server restart in " @ %minutes @ " minutes.");
   centerPrintAll("Server going down for restart in " @ %minutes @ " minutes.\n\nPlease ensure you are in a safe area.",15,2);
   if (%minutes > 12)
   {
      $TIMER_TEN = schedule(%ten, 0, "onTimerAnnounce","Server going down for restart in 10 minutes.\n\nPlease ensure you are in a safe area.");
   }
   if (%minutes > 7)
   {
      $TIMER_FIVE = schedule(%five, 0, "onTimerAnnounce","Server going down for restart in 5 minutes.\n\nLog out at your earliest convenience.");
   }
   if (%minutes > 3)
   {
      $TIMER_TWO = schedule(%two, 0, "onTimerAnnounce","Server going down for restart in 2 minutes.\n\nLog out now!");
   }
   if (%minutes > 1)
   {
      $TIMER_ONE = schedule(%one, 0, "onTimerAnnounce","Server going down for restart in 1 minute.\n\nLog out now!");
   }
   $TIMER_Shutdown = schedule(%shutdown, 0, "onTimerShutdown");

}

function CancelRestart()
{
   cancel($TIMER_TEN);
   cancel($TIMER_FIVE);
   cancel($TIMER_TWO);
   cancel($TIMER_ONE);
   cancel($TIMER_SHUTDOWN);
}

CancelRestart();

function OnTimerAnnounce(%str)
{
   hack("Sending server restart message:" SPC %str);
   centerPrintAll(%str,10,2);
}

function onTimerShutdown()
{
   hack("Server restart initiated.");
   shellExecute("check_server.cmd",$cm_config::worldID);
   Quit();
}