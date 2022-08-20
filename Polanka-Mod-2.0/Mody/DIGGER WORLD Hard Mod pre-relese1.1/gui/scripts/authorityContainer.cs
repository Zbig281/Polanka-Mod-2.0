//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

function GuiAuthorityContainer::setGuildName(%this, %name, %max_length)
{
   GuiAuthorityWindowGuildName.maxLength = %max_length;
   GuiAuthorityWindowGuildName.setText(%name);
   GuiAuthorityWindowGuildName.firstText = %name;
}
//----------------------------------------------------------

function GuiAuthorityContainer::onUpdateMaintenance(%this, %val)
{
   GuiMonumentMaintenanceVal.setText(%val);
}
//----------------------------------------------------------

function GuiAuthorityContainer::onUpdateRadius(%this, %radius, %percentageToUpgrade)
{
   GuiMonumentRadius.setText(%radius);
   MonumentProgressBar.setFirstValue(%percentageToUpgrade);
}
//----------------------------------------------------------

function GuiAuthorityContainer::onUpdateSupportPoints(%this, %val)
{
   GuiMonumentSupportPoints.setText(%val);
}
//----------------------------------------------------------

function GuiAuthorityContainer::setUpgradeButton( %this, %val)
{
   if( %this.IsManager == true)
   {
       GuiMonumentLvlUpBtn.active =%val;
       GuiMonumentLvlUpBtn.visible = true;
   }
   else
   {
       GuiMonumentLvlUpBtn.active =false;
       GuiMonumentLvlUpBtn.visible =false;
   }
}

function GuiAuthorityContainer::setTooltipText(%this, %val)
{
	if (%this.IsManager == true)
	{
		GuiMonumentLvlUpBtn.createTextTooltip(GetMessageIDText(4906, %val));
	}
}
