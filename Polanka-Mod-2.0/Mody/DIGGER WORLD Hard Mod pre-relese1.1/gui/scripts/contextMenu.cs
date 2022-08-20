//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

$addedWidthForbtnMode = 10;


// non-default abilities
singleton GuiControlProfile(ContextMenuTextProfile: GuiBaseTextProfile)
{
	justify = "left";
	fontSize = 24;
	fontColor = "140 140 140";
	fontColorNA = "64 64 64";
	fontColorHL = "255 255 255";
	textOffset = "0 0";
	autoSizeWidth = true;
};

// default ability name
singleton GuiControlProfile(ContextMenuDefaultNameProfile: ContextMenuTextProfile)
{
	fontColor = "195 129 0";
	fontColorNA = "127 127 127";
	fontColorHL = "213 167 0";
	textOffset = "0 0";
};

// default ability text ("default")
singleton GuiControlProfile(ContextMenuDefaultTextProfile: ContextMenuTextProfile)
{
	fontColor = "132 84 0";
	fontColorNA = "96 96 96";
	textOffset = "0 0";
};

//-----------------------------------------------------------------------------

function Lif_ContextMenu_OnPressedDefault(%val)
{
	if(%val)
	{
		SelectionHighlight(false);
		AbilityWidgetRun(false);
	}
}
//-----------------------------------------------------------------------------

function Lif_ContextMenu_OnPressedContext(%val)
{
	if(%val)
	{
		SelectionHighlight(true);
	}
	else if(isInSelectionHighlightMode())
	{
		SelectionHighlight(false);
		AbilityWidgetRun(true);
	}
}
//-----------------------------------------------------------------------------

function createAbilityWidget(%menu_pos, %full_screen)
{
	%gui = new AbilityWidget()
	{
		position = "0 0";
		extent = "800 600";
		profile = "GuiContextMenuProfile";
		visible = "1";
		menuPos = %menu_pos;
		fullscreen = %full_screen;
	};

	PlayGui.add(%gui);
	%gui.setExtent(PlayGui.getExtent());

	if (%full_screen)
		%gui.menuPos = PlayGui.getCenter();

	if(isObject(ClientMissionCleanupSet))
		ClientMissionCleanupSet.add(%gui);

	return %gui;
}
//-----------------------------------------------------------------------------

function createContextSubMenuContainer(%main_pnl, %pos)
{
	%gui = new AbilityWidgetContainer()
	{
		position = %pos;
		minExtent = "8 8";
		extent = "100 20";
		profile = "GuiAtlas3TiledImageProfile";
		dynamicNonStackExtent = true;
		stackingType = "Vertical";
		command = "ContextMenuClose()";
		altCommand = "ContextMenuClose();";
		TopIndent = 23;
		BottomIndent = 27;
		subMenuOffset = "0 0";
		addedWidth = 17;
		showRightBorder = true;
		showLeftBorder = false;
		LeftIndent = 16;
		RightIndent = 16;
		addedWidth = 34;
		TopIndex0 = LearningWindowBorderTop;
		RightIndex0 = ContextMenuRightBorder0;
		RightIndexN = ContextMenuRightBorderN;
		BottomIndex0 = LearningWindowBorderBottom;
		//LeftIndex0 = ContextMenuLeftBorderSubMenu0;
		//LeftIndexN = ContextMenuLeftBorderSubMenu0;

		TopRightIndex = ContextMenuRightTopDecor;
		BottomRightIndex = ContextMenuRightBottomDecor;
		BackgroundIndex = LearningWindowBackground;
	};

	%main_pnl.add(%gui);
	return %gui;
}
//-----------------------------------------------------------------------------

function createContextMenuContainer(%main_pnl, %pos)
{
	%gui = new SkillWidgetContainer()
	{
		position = %pos;
		minExtent = "8 8";
		extent = "100 20";
		profile = "GuiAtlas3TiledImageProfile";
		dynamicNonStackExtent = true;
		stackingType = "Vertical";
		command = "ContextMenuClose()";
		altCommand = "ContextMenuClose();";
		TopIndent = 14;
		BottomIndent = 27;
		subMenuOffset = "6 -24";
		addedWidth = 20;
		showRightBorder = true;
		showLeftBorder = true;
		RightIndent = 16;
		LeftIndent = 16;
		accelerator = "escape";
		padding = 1;

		TopIndex0 = LearningWindowBorderTop;
		RightIndex0 = ContextMenuRightBorder0;
		RightIndexN = ContextMenuRightBorderN;
		BottomIndex0 = LearningWindowBorderBottom;
		LeftIndex0 = ContextMenuLeftBorder0;
		LeftIndexN = ContextMenuLeftBorderN;
		TopLeftIndex = ContextMenuLeftTopDecor;
		TopRightIndex = ContextMenuRightTopDecor;
		BottomRightIndex = ContextMenuRightBottomDecor;
		BottomLeftIndex = ContextMenuLeftBottomDecor;
		BackgroundIndex = LearningWindowBackground;

		new GuiScrollCtrl() {
			willFirstRespond = "1";
			hScrollBar = "alwaysOff";
			vScrollBar = "alwaysOff";
			lockHorizScroll = "1";
			lockVertScroll = "0";
			constantThumbHeight = "0";
			childMargin = "0 0";
			mouseWheelScrollSpeed = "-1";
			margin = "0 0 0 0";
			padding = "0 0 0 0";
			anchorTop = "1";
			anchorBottom = "0";
			anchorLeft = "1";
			anchorRight = "0";
			position = "0 0";
			minExtent = "8 0";
			extent = "100 0";
			profile = "GuiCmChatWindowScrollProfile";
			internalName = "ContextMenuScroll";
			class = "ContextMenuScroll";

			new GuiStackControl()
			{
				position = "0 0";
				minExtent = "0 0";
				extent = "100 0";
				horizSizing = "right";
				vertSizing = "bottom";
				profile = "GuiBaseTextProfile";
				changeChildSizeToFit = true;
				dynamicNonStackExtent = true;
				stackingType = "Vertical";
				changeChildPosition = true;
				internalName = "MainContextMenuContainer";
			};
		};
	};
	%gui-->ContextMenuDown.command = "onContextMenuDown(" @ %gui @ ");";
	%gui-->ContextMenuUp.command = "onContextMenuUp(" @ %gui @ ");";

	%main_pnl.add(%gui);
	return %gui;
}

function createGroupAbilitysStack(%skillID, %image)
{
	%gui = new GuiControl()
	{
		position = "0 0";
		extent = "100 40";
		minExtent = "8 8";
		profile = "GuiBaseTextProfile";
		canHit = "true";
		internalName = "SkillGroupControl" @ %skillID;

		new GuiControl()
		{
			position = "2 0";
			extent = "40 40";
			vertSizing = "height";
			Profile = "GuiBaseTextProfile";
			visible = true;

			new GuiControl() 
			{
				position = "0 15";
				extent = "3 10";
				canHit = "false";
				profile = "GuiAtlas3TiledImageProfile";
				centered = "true";
				vertSizing = "height";
				horizSizing = "center";

				TopLeftIndex = ContextMenuLineTop;
				LeftIndex0 = ContextMenuLineCenter;
				BottomLeftIndex = ContextMenuLineBottom;
			};

			new GuiBitmapCtrl() 
			{
				position = "0 0";
				extent = "36 36";
				canHit = "false";
				profile = "GuiAtlas3ImageProfile";
				centered = "true";
				vertSizing = "center";
				horizSizing = "center";
				bitmap = %image;

				new GuiBitmapCtrl() 
				{
					position = "0 0";
					extent = "36 36";
					canHit = "false";
					profile = "GuiAtlas1ImageProfile";
					vertSizing = "center";
					imageIndex = ContextMenuSkillBorder;
				};
			};
		};

		new GuiStackControl()
		{
			position = "42 0";
			minExtent = "0 0";
			extent = "58 40";
			horizSizing = "width";
			profile = "GuiBaseTextProfile";
			changeChildSizeToFit = true;
			dynamicNonStackExtent = true;
			stackingType = "Vertical";
			changeChildPosition = true;
			internalName = "stackControl" @ %skillID;
		};
	};

	return %gui;
}

function createAbilityWidgetButton(%menu)
{
	%gui = new AbilityWidgetButton()
	{
		position = "0 0";
		extent = "225 40";
		minExtent = "225 40";
		profile = "GuiBaseTextProfile";
		visible = "1";
		ParentMenu = %menu;

		new GuiTilingBitmapOverlap() 
		{
			position = "0 0";
			extent = "225 40";
			minExtent = "225 40";
			canHit = "false";
			profile = "GuiAtlas3ImageProfile";
			internalName = "";
			horizSizing = "width";
			visible = "0";

			TopLeftIndex = ThickMenuItemMouseOverLeft;
			TopIndex0 = ThickMenuItemMouseOverCenter0;
			TopIndexN = ThickMenuItemMouseOverCenter1;
			TopRightIndex = ThickMenuItemMouseOverRight;
			internalName = "MouseOverPnl";
		};

		new GuiStackControl()
		{
			position = "0 0";
			extent = "225 40";
			horizSizing = "right";
			vertSizing = "bottom";
			minExtent = "8 8";
			profile = "GuiBaseTextProfile";
			changeChildSizeToFit = false;
			dynamicNonStackExtent = false;
			stackingType = "Horizontal";
			canHit = "false";
			changeChildPosition = false;
			internalName = "stackControl";
		};
	};

	%btnMode = new GuiButtonCtrl()
	{
		buttonType = "PushButton";
		useMouseEvents = "1";
		position = "178 -3";
		horizSizing = "left";
		extent = "47 46";
		profile = "GuiAtlas2ImageProfile";
		visible = "1";
		active = "1";
		imageIndex = BtnPlusOne;
		internalName = "AbilityModeButton";
		command = %gui @ ".changeAbilityMode();";
	};
	%gui.add(%btnMode);

	return %gui;
}

function createDefaultAbilityWidgetButton(%menu, %text)
{
	%nameTextPos = 23;
	%btn = createAbilityWidgetButton(%menu);
	%btn-->stackControl.setPosition(%nameTextPos, 0);

	%txt = new GuiTextCtrl() 
	{
		position = "0 0";
		extent = "10 40";
		profile = "ContextMenuDefaultNameProfile";
		canHit = "false";
		text = %text;
		internalName = "textName";
	};
	%btn-->stackControl.add(%txt);

	%def_txt = new GuiTextCtrl() 
	{
		position = "0 0";
		extent = "10 40";
		profile = "ContextMenuDefaultTextProfile";
		canHit = "false";
		text = " (" @ GetMessageIDText(1199) @ ")";
		internalName = "textDefault";
	};
	%btn-->stackControl.add(%def_txt);

	%ext = %btn-->stackControl.getExtent();
	%pos = %btn-->stackControl.getPosition();
	%ext.x = %ext.x + %pos.x + %nameTextPos + $addedWidthForbtnMode;

	%decor = new GuiBitmapCtrl() 
	{
		position = "0 0";
		extent = "16 34";
		canHit = "false";
		visible = "true";
		profile = "GuiAtlas3ImageProfile";
		centered = "true";
		imageIndex = ContextMenuDefaultItemDecor;
	};

	%center = (%ext.y - %decor.getExtent().y) / 2;
	%decor.setPosition(0, %center);
	%btn.add(%decor);

	%menu.add(%btn);
	%lineDecor = new GuiControl()
	{
		position = "0 0";
		extent = "100 20";
		Profile = "GuiBaseTextProfile";
		visible = true;

		new GuiBitmapCtrl() 
		{
			position = "0 3";
			extent = "100% 6";
			canHit = "false";
			visible = "true";
			profile = "GuiAtlas3ImageProfile";
			wrap = "true";
			imageIndex = ContextMenuDefaultPnl;
		};
	};
	%menu.add(%lineDecor);
	%menu.bringToFront(%lineDecor);
	%menu.bringToFront(%btn);

	%btn.setExtent(%ext);
	return %btn;
}

function createSingleAbilityWidgetButton(%menu, %text, %image)
{
	%nameTextPos = 4;
	%btn = createAbilityWidgetButton(%menu);

	%btn-->stackControl.setPosition(%nameTextPos, 0);
	%btn-->stackControl.padding = 7;
	%btn.minExtent = "267 40";
	%btn.setExtent(267, 40);
	%btn-->MouseOverPnl.setPosition(42, 0);
	%btn-->MouseOverPnl.setExtent(225, 40);

	%icon = new GuiBitmapCtrl() 
	{
		position = "0 0";
		extent = "36 36";
		canHit = "false";
		profile = "GuiAtlas3ImageProfile";
		centered = "true";
		vertSizing = "center";
		bitmap = %image;

		new GuiBitmapCtrl() 
		{
			position = "0 0";
			extent = "36 36";
			canHit = "false";
			profile = "GuiAtlas1ImageProfile";
			vertSizing = "center";
			imageIndex = ContextMenuSkillBorder;
		};

	};
	%btn-->stackControl.add(%icon);

	%txt = new GuiTextCtrl() 
	{
		position = "0 0";
		extent = "10 40";
		profile = "ContextMenuTextProfile";
		canHit = "false";
		text = %text;
		internalName = "textName";
	};

	%btn-->stackControl.add(%txt);

	%ext = %btn-->stackControl.getExtent();
	%pos = %btn-->stackControl.getPosition();
	%ext.x = %ext.x + %pos.x + %nameTextPos + $addedWidthForbtnMode;

	%menu.add(%btn);
	%btn.setExtent(%ext);
	return %btn;
}

function addInGroupAbilityWidgetButton(%menu, %text, %skillID, %image)
{
	%nameTextPos = 6;
	%btn = createAbilityWidgetButton(%menu);
	%btn-->stackControl.setPosition(%nameTextPos, 0);

	%txt = new GuiTextCtrl() 
	{
		position = "0 0";
		extent = "10 40";
		profile = "ContextMenuTextProfile";
		canHit = "false";
		text = %text;
		internalName = "textName";
	};
	%btn-->stackControl.add(%txt);

	%ext = %btn-->stackControl.getExtent();
	%pos = %btn-->stackControl.getPosition();
	%ext.x = %ext.x + %pos.x;

	%stack = %menu.findObjectByInternalName("stackControl"@ %skillID, true);
	%group = %menu.findObjectByInternalName("SkillGroupControl" @ %skillID, true);

	if (!isObject(%group))
	{
		%group = createGroupAbilitysStack(%skillID, %image);
		%menu.add(%group);
		%stack = %menu.findObjectByInternalName("stackControl"@ %skillID, true);
	}

	%btn.setExtent(%ext);
	%ext = %btn.GetExtent();
	%groupExt = %group.getExtent();

	%stacPos = %stack.getPosition();
	%max = getMax(%ext.x + %stacPos.x + %nameTextPos + $addedWidthForbtnMode, %groupExt.x);
	%stack.add(%btn);
	%stackExt = %stack.getExtent();
	%group.setExtent(%max, %stackExt.y);

	return %btn;
}

function createGroupWidgetButton(%menu, %text, %group)
{
	%gui = new GuiBitmapButtonTextCtrl()
	{
		position = "0 0";
		extent = "267 40";
		profile = "GuiAtlas3ImageProfile";
		visible = "1";
		bitmapMode = "HorizontalTiling";
		contextGroup = %group;
		class = "ContextMenuGroupBtn";

		new GuiTilingBitmapOverlap() 
		{
			position = "42 0";
			extent = "225 40";
			canHit = "false";
			profile = "GuiAtlas3ImageProfile";
			internalName = "";
			horizSizing = "width";
			visible = "0";
			TopLeftIndex = ThickMenuItemMouseOverLeft;
			TopIndex0 = ThickMenuItemMouseOverCenter0;
			TopIndexN = ThickMenuItemMouseOverCenter1;
			TopRightIndex = ThickMenuItemMouseOverRight;
			internalName = "MouseOverPnl";
		};
	};

	%stack = new GuiStackControl()
	{
		position = "7 0";
		extent = "267 40";
		horizSizing = "right";
		vertSizing = "bottom";
		minExtent = "8 8";
		profile = "GuiBaseTextProfile";
		changeChildSizeToFit = true;
		dynamicNonStackExtent = true;
		stackingType = "Horizontal";
		canHit = "false";

		new GuiBitmapCtrl() 
		{
			position = "0 0";
			extent = "40 40";
			canHit = "false";
			visible = "true";
			profile = "GuiAtlas3ImageProfile";
			centered = "true";
			vertSizing = "center";
		};

		new GuiTextCtrl() 
		{
			position = "0 0";
			extent = "6 40";
			profile = "ContextMenuTextProfile";
			canHit = "false";
			text = %text;
			internalName = "textName";
		};
	};

	%gui.add(%stack);
	%menu-->MainContextMenuContainer.add(%gui);

	%ext = %stack.getExtent();
	%gui.setExtent(%ext);
	%scrol_ext = %menu-->ContextMenuScroll.getExtent();

	if (%scrol_ext.x < %ext.x)
		%menu-->ContextMenuScroll.setExtent(%ext.x, %scrol_ext.y);

	return %gui;
}

function createContextMenuDecor(%parent, %is_left, %is_sub)
{
	%index = UnavailableIndex;
	if (%is_left)
	{
		//%index = getContextMenuLeftDecor();
	}
	else
	{
		if (%is_sub)
			%index = ContextMenuRightDecor;
	}

	if (%index !$= UnavailableIndex)
	{
		%gui = new GuiBitmapCtrl()
		{
			position = "0 0";
			extent = "27 64";
			canHit = "false";
			visible = "false";
			profile = "GuiAtlas3ImageProfile";
			imageIndex = %index;
			resize = true;
		};

		%parent.add(%gui);
	}
	return %gui;
}
//-----------------------------------------------------------------------------

function showMenuDecor(%decor, %menu_item, %is_left, %is_def, %is_sub)
{
	%decor.setVisible(true);
	%pos = %menu_item.getGlobalPosition();

	%menu_ext = %menu_item.getExtent();
	%decor_ext = %decor.getExtent();

	%center = %menu_ext.y / 2;
	%pos.y = %pos.y + %center - %decor_ext.y / 2;

	if (%is_sub)
	{
		%menuPos = %menu_item.ParentMenu.getPosition();
		%pos.x = %menuPos.x - 2;
		%decor.setPosition(%pos.x, %pos.y);
	}
}

function onContextMenuUp(%container)
{
	%container-->ContextMenuScroll.scrollToTop();
	ContextMenuScroll();
}
//-----------------------------------------------------------------------------

function onContextMenuDown(%container)
{
	%container-->ContextMenuScroll.scrollToBottom();
	ContextMenuScroll();
}
//-----------------------------------------------------------------------------

function ContextMenuScroll::onScroll(%this)
{
	ContextMenuScroll();
}

function ContextMenuGroupBtn::onMouseOverChanged(%this, %mouse_over)
{
	if (%mouse_over)
	{
		ShowSubContextMenu(%this.contextGroup, %this);
	}

	%this-->textName.setHighlighted(%mouse_over);
	%this-->MouseOverPnl.setVisible(%mouse_over);
}
