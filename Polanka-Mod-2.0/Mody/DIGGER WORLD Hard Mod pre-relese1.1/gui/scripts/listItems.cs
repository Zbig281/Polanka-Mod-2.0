//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

singleton GuiControlProfile(SelectionListInfoTextProfile: GuiBaseTextProfile)
{
	fontSize = 19;
	fontColor = "203 203 203";
	fontColorNA = "153 153 153";
	textOffset = "0 0";
	autoSizeWidth = true;
};

singleton GuiControlProfile(SelectionListTextProfile: GuiBaseTextProfile)
{
	justify = "left";
	fontSize = 24;
	fontColor = "255 255 255";
	fontColorNA = "204 204 204";
	textOffset = "0 0";
};

function createListItem(%image, %name, %quantity, %quality)
{
	%showInfo = %quantity != 0 || %quality != 0;
	%topIndentForName = %showInfo ? 6 : 16;

	%list_item = new GuiListItem() 
	{
		position = "0 0";
		extent = "300 66";
		profile = "GuiAtlas3ImageProfile";
		internalName = "ListItem";
		altCommand = "SelectionListSelect();";
		class = GuiSelectionListItem;

		new GuiTilingBitmapOverlap()
		{
			position = "3 0";
			extent = "250 40";
			profile = "GuiAtlas3ImageProfile";
			visible = false;
			canHit = false;
			internalName = "highlighPanel";
			TopLeftIndex = ThickMenuItemMouseOverLeft;
			TopIndex0 = ThickMenuItemMouseOverCenter0;
			TopIndexN = ThickMenuItemMouseOverCenter1;
			TopRightIndex = ThickMenuItemMouseOverRight;
			vertSizing = center;
			horizSizing = "width";
		};

		new GuiStackControl()
		{
			position = "0 0";
			extent = "300 66";
			minExtent = "8 8";
			canHit = "false";
			profile = "GuiBaseTextProfile";
			horizSizing = "width";
			stackingType = "Horizontal";
			changeChildSizeToFit = false;
			dynamicSize = false;
			padding = 13;
			LeftIndent = 3;
			visible = "true";
			changeChildPosition = true;

			new GuiBitmapCtrl() 
			{
				position = "0 0";
				extent = "66 66";
				canHit = "false";
				visible = "true";
				internalName = "LeftImage";
				profile = "GuiBaseTextProfile";
				centered = "true";
				bitmap = %image;
			};

			new GuiStackControl()
			{
				position = "0 0";
				extent = "218 66";
				minExtent = "8 8";
				canHit = "false";
				profile = "GuiBaseTextProfile";
				stackingType = "Vertical";
				dynamicSize = false;
				changeChildSizeToFit = false;
				padding = 0;
				visible = "true";
				changeChildPosition = true;
				horizSizing = "width";
				TopIndent = %topIndentForName;

				new GuiTextCtrl() 
				{
					extent = "190 30";
					profile = "SelectionListTextProfile";
					canHit = "false";
					internalName = "Text";
					horizSizing = "width";
					active = false;
					text = %name;
				};

				new GuiStackControl()
				{
					position = "0 0";
					extent = "234 16";
					minExtent = "8 8";
					canHit = "false";
					profile = "GuiBaseTextProfile";
					horizSizing = "width";
					stackingType = "Horizontal";
					changeChildSizeToFit = false;
					padding = 11;
					visible = %showInfo;
					changeChildPosition = true;

					new GuiStackControl()
					{
						position = "0 0";
						extent = "20 16";
						minExtent = "8 8";
						canHit = "false";
						profile = "GuiBaseTextProfile";
						stackingType = "Horizontal";
						changeChildSizeToFit = false;
						padding = 3;
						visible = "true";
						changeChildPosition = false;

						new GuiBitmapCtrl() 
						{
							position = "0 0";
							extent = "15 16";
							canHit = "false";
							visible = "true";
							resize = "true";
							profile = "GuiAtlas3ImageProfile";
							imageIndex = QantityIcon;
						};

						new GuiTextCtrl() 
						{
							position = "0 -2";
							extent = "190 16";
							profile = "SelectionListInfoTextProfile";
							canHit = "false";
							horizSizing = "width";
							internalName = "quantityText";
							active = false;
							text = %quantity;
						};
					};
					
					new GuiStackControl()
					{
						position = "0 0";
						extent = "20 16";
						minExtent = "8 8";
						canHit = "false";
						profile = "GuiBaseTextProfile";
						stackingType = "Horizontal";
						changeChildSizeToFit = false;
						padding = 3;
						visible = "true";
						changeChildPosition = false;

						new GuiBitmapCtrl() 
						{
							position = "0 0";
							extent = "14 16";
							canHit = "false";
							visible = "true";
							resize = "true";
							profile = "GuiAtlas3ImageProfile";
							imageIndex = QualityIcon;
						};

						new GuiTextCtrl() 
						{
							position = "0 -2";
							extent = "190 16";
							profile = "SelectionListInfoTextProfile";
							canHit = "false";
							horizSizing = "width";
							internalName = "qualityText";
							active = false;
							text = %quality;
						};
					};
				};
			};
		};
	};
	
	return %list_item;
}

function createSkillListItem(%image, %name)
{
	%list_item = new GuiListItem() 
	{
		position = "0 0";
		extent = "300 66";
		profile = "GuiAtlas3ImageProfile";
		internalName = "ListItem";
		altCommand = "SelectionListSelect();";
		class = GuiSelectionListItem;

		new GuiTilingBitmapOverlap()
		{
			position = "3 0";
			extent = "250 40";
			profile = "GuiAtlas3ImageProfile";
			visible = false;
			canHit = false;
			internalName = "highlighPanel";
			TopLeftIndex = ThickMenuItemMouseOverLeft;
			TopIndex0 = ThickMenuItemMouseOverCenter0;
			TopIndexN = ThickMenuItemMouseOverCenter1;
			TopRightIndex = ThickMenuItemMouseOverRight;
			vertSizing = center;
			horizSizing = "width";
		};

		new GuiStackControl()
		{
			position = "0 0";
			extent = "300 66";
			minExtent = "8 8";
			canHit = "false";
			profile = "GuiBaseTextProfile";
			horizSizing = "width";
			stackingType = "Horizontal";
			changeChildSizeToFit = false;
			dynamicSize = false;
			padding = 13;
			LeftIndent = 3;
			visible = "true";
			changeChildPosition = false;

			new GuiBitmapCtrl() 
			{
				position = "0 6";
				extent = "53 53";
				canHit = "false";
				profile = "GuiBaseTextProfile";
				centered = "true";
				internalName = "LeftImage";
				bitmap = %image;

				new GuiBitmapCtrl() 
				{
					position = "0 0";
					extent = "53 53";
					canHit = "false";
					profile = "GuiAtlas1ImageProfile";
					vertSizing = "center";
					imageIndex = SmallKnownSkillBorder;
				};
			};

			new GuiStackControl()
			{
				position = "0 0";
				extent = "218 66";
				minExtent = "8 8";
				canHit = "false";
				profile = "GuiBaseTextProfile";
				stackingType = "Vertical";
				dynamicSize = false;
				changeChildSizeToFit = false;
				padding = 0;
				visible = "true";
				changeChildPosition = true;
				horizSizing = "width";
				TopIndent = 16;

				new GuiTextCtrl() 
				{
					extent = "190 30";
					profile = "SelectionListTextProfile";
					canHit = "false";
					internalName = "Text";
					horizSizing = "width";
					active = false;
					text = %name;
				};
			};
		};
	};
	
	return %list_item;
}

function GuiSelectionListItem::setDisableItem(%this)
{
	%gui = new GuiControl() 
	{
		position = "0 0";
		extent = %this.getExtent();
		profile = "GuiAtlas3TiledImageProfile";
		backgroundIndex = "LearningWindowBackground";
		opacity = "0.5";
		horizSizing = "width";
		vertSizing = "height";
		canHit = "false";
	};
	%this.add(%gui);
}


function GuiSelectionListItem::onStateChanged(%this, %state)
{
	if (%state)
	{
		%this-->highlighPanel.opacity = 1;
		SelectionListDlgBtn.setActive(true);
	}

	%this-->text.setActive(%state);
	%this-->quantityText.setActive(%state);
	%this-->qualityText.setActive(%state);
	%this-->highlighPanel.setVisible(%state);
}

function GuiSelectionListItem::onMouseOverChanged(%this, %state)
{
	%onState = %this.getStateOn();
	%this-->highlighPanel.setVisible(%onState || %state);
	if (%state && !%onState)
		%this-->highlighPanel.opacity = 0.5;
}
//-----------------------------------------------------------------------------
