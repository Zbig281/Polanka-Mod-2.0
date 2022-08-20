//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

$GuiCraftComponentRedColor = "159 66 20";
$GuiCraftComponentGreenColor = "29 135 40";
$GuiCraftComponentOrangeColor = "246 127 49";

singleton GuiControlProfile( GuiCraftRecipeComponentNameProfile : GuiBaseTextProfile ) {
	fontSize = 19;
	fontColor = "204 204 204";
	justify = "center";
};

singleton GuiControlProfile( GuiCraftRecipeComponentDoubleValProfile : GuiCraftRecipeComponentNameProfile ) {};

singleton GuiControlProfile( GuiCraftRecipeComponentRegionProfile : GuiBaseTextProfile ) {
	fontSize = 17;
	fontColor = "51 153 153";
	justify = "center";
};

function createCraftingComponentPanel(%name)
{
	%gui = new GuiControl() {
		extent = "172 188";
		internalName = %name;
		canHit = true;
		class = GuiCraftingComponentSlot;
		
		new GuiBitmapCtrl() {
			position = "27 6";
			extent = "118 118";
			canHit = false;
			profile = "GuiAtlas1ImageProfile";
			imageIndex = "LargeSlot";
			internalName = "slotPanel";
		};

		new GuiBitmapTooltip() {
			position = "21 0";
			extent = "130 130";
			canHit = false;
			centered = true;
			internalName = "image";
		};
		
		new CmGuiDoubleValTextCtrl() {
			position = "0 124";
			extent = "172 20";
			profile = "GuiCraftRecipeComponentDoubleValProfile";
			canHit = false;
			internalName = "doubleVal";
		};

		new GuiTextCtrl() {
			position = "0 144";
			extent = "172 20";
			profile = "GuiCraftRecipeComponentNameProfile";
			canHit = false;
			internalName = "itemName";
			text = "---";
		};

		new GuiTextCtrl() {
			position = "0 164";
			extent = "172 20";
			profile = "GuiCraftRecipeComponentRegionProfile";
			canHit = false;
			internalName = "regionName";
			text = "Alpha Region";
		};

		new GuiBitmapCtrl() {
			position = "101 95";
			extent = "29 29";
			profile = "GuiAtlas3ImageProfile";
			canHit = true;
			imageIndex = "RegionalInfoIcon";
			internalName = "optionallyRegional";
			tooltip = GetMessageIDText(4484);
		};
	};

	return %gui;
}

// creates a panel that includes item components
function createCraftingComponentsPanel()
{
	%panel = new GuiControl() {
		extent = "516 376";
		internalName = "components";
	};

	// wtb non-retarded arrays
	%itemPosition[0] = "0 0";
	%itemPosition[1] = "172 0";
	%itemPosition[2] = "344 0";
	%itemPosition[3] = "86 188";
	%itemPosition[4] = "258 188";

	for (%i = 0; %i < 5; %i++)
	{
		%item = createCraftingComponentPanel("component" @ %i);
		%panel.add(%item);
		%item.position = %itemPosition[%i];
	}

	return %panel;
}

function GuiCraftingComponentSlot::setHighlight(%this, %state)
{
	%image = %state ? "LargeSlotHighlight" : "LargeSlot";
	%this-->slotPanel.setGlobalImageIndex(%image);
}

function GuiCraftingComponentSlot::setInfo(%this, %itemTypeId, %itemName, %optionallyRegional, %regionName)
{
	%this-->image.setObjectTypeId(%itemTypeId);
	%this-->itemName.setText(%itemName);
	%this-->optionallyRegional.setVisible(%optionallyRegional);
	%this-->regionName.setText(%regionName);
	%this.setValues(0, 0);
}

function GuiCraftingComponentSlot::setValues(%this, %first, %second)
{
	%this-->doubleVal.setFirstValue(%first);
	%this-->doubleVal.setSecondValue(%second);
	%color = (%first >= %second && %first != 0) ? $GuiCraftComponentGreenColor : $GuiCraftComponentRedColor;
	%this-->doubleVal.setFirstColor(%color);
}

function GuiCraftingComponentSlot::setBuildingValues(%this, %buildItemsCount, %freeItemsCount, %allItemsCount)
{
	%this-->doubleVal.setFirstValue(%buildItemsCount + %freeItemsCount);
	%this-->doubleVal.setSecondValue(%allItemsCount);
	%color = 0;
	if (%freeItemsCount == 0)
	{
		if (%buildItemsCount > 0)
		{
			%color = $GuiCraftComponentGreenColor;
		}
		else
		{
			%color = $GuiCraftComponentRedColor;
		}
	}
	else if (%freeItemsCount > 0)
	{
		%color = $GuiCraftComponentOrangeColor;
	}
	else
	{
		%color = $GuiCraftComponentRedColor;
	}
	%this-->doubleVal.setFirstColor(%color);
}

function GuiCraftingComponentSlot::clearInfo(%this)
{
	%this-->image.setObjectTypeId(0);
	%this-->itemName.setText("");
	%this-->optionallyRegional.setVisible(false);
	%this-->regionName.setText("");
	%this.setValues(0, 0);
}
