//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

function createBuildComponentsItem(%key)
{
	if (isObject(GuiBuildComponentsPanel))
	{
		%gui = new GuiControl()
		{
			position = "0 0";
			extent = "146 236";
			profile = "GuiBaseTextProfile";

			new GuiBitmapCtrl()
			{
				position = "0 8";
				extent = "146 148";
				canHit = "true";
				visible = "true";
				profile = "CraftBaseProfile";
				imageIndex = getCraftComponentBorder();
				internalName = "CraftComponentPnl" @ %key;
			};

			new GuiBitmapCtrl()
			{
				Enabled = "1";
				Profile = "CraftBaseProfile";
				position = "25 0";
				extent = "96 165";
				MinExtent = "8 8";
				Visible = false;
				canHit = false;
				centered = true;
				internalName = "CraftComponentShadowImage" @ %key;
				imageIndex = getEquipmentShadowMiddle();
			};

			new GuiBitmapTooltip()
			{
				position = "0 8";
				extent = "146 148";
				canHit = "true";
				visible = "true";
				profile = "CraftBaseProfile";
				centered = "true";
				internalName = "CraftComponentImage" @ %key;
			};

			new CmGuiDoubleValTextCtrl()
			{
				position = "0 156";
				extent = "146 20";
				Profile = "CraftDoubleValProfile";
				internalName = "CraftComponentDoubleVal" @ %key;
			};
   
			new GuiMLTextCtrl() 
			{
				position = "0 176";
				extent = "146 60";
				profile = "GuiItemRecipeTextProfile";
				canHit = "false";
				rightOffset = 0;
				internalName = "CraftComponentMLText" @ %key;
				text = "<just:center>---";
			};

			new GuiBitmapCtrl()
			{
				bitmap = "art/gui/blueline.png";
				position = "33 200";
				extent = "80 2";
				profile = "CraftBaseProfile";
				visible = "1";
				active = "1";
				Enabled = "1";
				centered = "1";
				canHit = "false"; 
				internalName = "CraftRegionLine" @ %key;
			};

			new GuiMLTextCtrl()
			{
				position = "0 203";
				extent = "146 60";
				profile = "CraftBlueprintsSwitchTextProfile";
				canHit = "false";
				rightOffset = 0;
				internalName = "CraftRegionName" @ %key;
				text = "<just:center>Alpha Region";
			};

		};

		GuiBuildComponentsPanel.add(%gui);
	}
}
//-----------------------------------------------------------------------------

function setBuildName(%name)
{
   BuildNameCtrl.setText(%name);
   BuildResourcesCtrl.setText("<just:center>" @ GetMessageIDText(2193));
}
//-----------------------------------------------------------------------------

