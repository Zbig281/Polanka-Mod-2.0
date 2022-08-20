//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

function GuiPersonalClaimContainer::onUpdateMaintenance(%this, %point, %godsFavor)
{
	GuiPersonalClaimMaintenancePoints.SetText(%point);
	GuiPersonalClaimMaintenanceGodsFavor.SetText(%godsFavor);
}
//----------------------------------------------------------

function GuiPersonalClaimContainer::onUpdateStock(%this, %point, %godsFavor)
{
	GuiPersonalClaimStockPoints.SetText(%point);
	GuiPersonalClaimStockGodsFavor.SetText(%godsFavor);
}
//----------------------------------------------------------

function GuiPersonalClaimContainer::onUpdateCels(%this, %curVal, %maxVal)
{
	GuiPersonalClaimCells.setText(GetMessageIDText(2528) @ " " @ %curVal @ "/" @ %maxVal);
}
//----------------------------------------------------------

function GuiPersonalClaimContainer::onEnoughResources(%this, %gameDays, %realDays)
{
	GuiPersonalClaimGameDay.setText(%gameDays);
	GuiPersonalClaimRealDay.setText(%realDays);
}
