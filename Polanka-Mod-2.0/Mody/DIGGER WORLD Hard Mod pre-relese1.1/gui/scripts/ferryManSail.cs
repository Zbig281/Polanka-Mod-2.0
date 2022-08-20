function openQuestSailDialog()
{
	selectRegionWorldGui.show();
}

function showWorldTicketConsumptionDialog(%worldId, %worldName)
{
   if ($xsolla::ticket::hasTicket)
   {
      %rulesPath = getWorldRulesTextPath(%worldId);

      if (%rulesPath !$= "")
      {
          OpenAcceptDlg(%rulesPath, GetMessageIDText(4488), GetMessageIDText(4489), "performSailToWorld(\"" @ %worldId @ "\");");
      }
      else
      {
         MessageBoxYesNo("", GetMessageIDText(2935, %worldName), "performSailToWorld(\"" @ %worldId @ "\");", ""); // Sail to Abella confirmation.
      }
   }
   else
   {
      MessageBoxYesNo("", GetMessageIDText(2936), "openXsollaStore(50190);", ""); // Buy ticket to Abella.
   }
}

function performSailToWorld(%worldId)
{
	echo("performSailToWorld = " @ %worldId);
   consumeWorldTicket(%worldId, "MessageBoxOK(\"\", GetMessageIDText(2938), \"\");"); // Consumption failed message
}
