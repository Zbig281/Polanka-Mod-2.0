
if (isObject(GuiBuildSelection))
	GuiBuildSelection.delete();

function GuiBuildSelection::onAdd(%this)
{
	echo(%this.getName() @ "::onAdd()");

	%this._createProfiles();

	%this.window = %this._createWindow();

	%this.categoriesPanel = %this.window-->categories;

	%this.itemInfo = %this._createItemInfoPanel();
	%this.window-->itemInfoPanel.add(%this.itemInfo);

	%this.window-->itemListPanel.add(%this._createItemList());

	%this.window.closeCommand = "BuildSelection_Close();";
	%this.window-->buildButton.command = %this.getId() @ "._onBuildClicked();";

	%this.itemListCount = 0;
	%this.itemListMaxCount = 0;

	%this.categoriesCount = 0;
	%this.categoriesMaxCount = 0;

	%this.subcategories = new SimSet() {
		count = 0; // currently used
	};
}

function GuiBuildSelection::onRemove(%this)
{
	echo(%this.getName() @ "::onRemove()");

	PlayGui.remove(%this.window);
}

function GuiBuildSelection::open(%this, %caption, %complex)
{
	if (%this.isOpen)
	{
		%this.close();
	}
	
	%this.isOpen = true;
	%this.window.text = %caption;
	%this.window.setExtent(%complex ? 1038 : 753, 772);
	%this.window-->categoriesPanel.setVisible(%complex);
	%this.window-->categoriesPanel.setActive(%complex);
	%this.complex = %complex;

	PlayGui.add(%this.window);
}

function GuiBuildSelection::close(%this)
{
	echo("GuiBuildSelection::close");
	%this.isOpen = false;
	%this.clearItemList();
	%this.clearItemCategories();
	%this.clearDecorationsSubcategory();
	PlayGui.remove(%this.window);
}

function GuiBuildSelection::clearItemList(%this)
{
	for (%i = 0; %i < %this.itemListCount; %i++)
		%this.itemList[%i].setVisible(false);
	%this.itemListCount = 0;
}

function GuiBuildSelection::addListItem(%this, %id, %name, %active)
{
	if (%this.itemListCount >= %this.itemListMaxCount)
		%this._createListItem();

	%listItem = %this.itemList[%this.itemListCount];
	%this.itemListCount++;

	%listItem.setup(%id, %name, %active);
}

function GuiBuildSelection::getSelectedItemId(%this)
{
	for (%i = 0; %i < %this.itemListCount; %i++)
	{
		%listItem = %this.itemList[%i];
		if (%listItem.getStateOn())
			return %listItem.itemId;
	}
	return -1;
}

function GuiBuildSelection::selectItem(%this, %index)
{
	if (%index < %this.itemListCount)
		%this.itemList[%index].setStateOn(true);
}

function GuiBuildSelection::setItemInfo(%this, %name, %imagePath, %description, %active)
{
	%this.itemInfo-->name.setText(%name);
	%this.itemInfo-->image.setBitmap(%imagePath);
	%this.itemInfo-->description.setText(%description);

	%this.window-->buildButton.setActive(%active);

	for (%i = 0; %i < 5; %i++)
		%this.itemComponents[%i].setVisible(false);
	%this.itemComponentCount = 0;
}

function GuiBuildSelection::addItemComponent(%this, %name, %icon, %count, %isRegional)
{
	if (%this.itemComponentCount == 5)
		return; // XXX: error?

	%component = %this.itemComponents[%this.itemComponentCount];
	%component.setVisible(true);
	%component-->name.setText(%name);
	%component-->image.setBitmap(%icon);
	%component-->count.setText("x" @ %count);
	%component-->isRegional.setVisible(%isRegional);

	%this.itemComponentCount++;
	return %component;
}

function GuiBuildSelection::clearItemCategories(%this)
{
	for (%i = 0; %i < %this.categoriesCount; %i++)
		%this.categories[%i].hide();
	%this.categoriesCount = 0;
	%this.subcategories.count = 0;
}

function GuiBuildSelection::addItemCategory(%this, %id, %name, %icon, %active)
{
	if (%this.categoriesCount >= %this.categoriesMaxCount)
		%this._createItemCategory();

	%category = %this.categories[%this.categoriesCount];
	%this.categoriesCount++;

	%category.setup(%id, %name, %icon, %active);
}

function GuiBuildSelection::clearDecorationsSubcategory(%this)
{
	%this.window-->decorSubcategoryPanel.clear();
	%this.window-->decorSubcategoryContainer.setVisible(false);
}

function GuiBuildSelection::addDecorationsSubcategory(%this, %abilityId, %id, %name, %defState)
{
	%btn = new guiHorzTilingButtonCtrl()
	{
		text = %name;
		position = "0 0";
		extent = "182 82";
		minExtent = "8 2";
		profile = "CharacterWindowTabText";
		groupNum = "1";
		buttonType = "RadioButton";
		useMouseEvents = "1";
		visible = "1";
		active = "1";
		command = "BuildSelection_SelectSubcategory(" @ %abilityId @ ", " @ %id @ ");";
		useManualIndex = 1;
		depressedImageIndex = CharWndTabSelected;
		mouseOverImageIndex = CharWndTabNormal;
		imageIndex = CharWndTabNormal;
		class = "DecorSubcategoryButtonClass";
		defaultState = %defState;
	};
	%this.window-->decorSubcategoryPanel.add(%btn);
	%this.window-->decorSubcategoryContainer.setVisible(true);
	if (%defState)
	{
		%btn.onStateChanged(%defState);
		BuildSelection_SelectSubcategory(%abilityId, %id);
	}
}

function GuiBuildSelection::addItemSubcategory(%this, %id, %name)
{
	if (%this.categoriesCount <= 0)
		return; // XXX: error?
	%category = %this.categories[%this.categoriesCount - 1];

	if (%this.subcategories.count >= %this.subcategories.getCount())
		%this._createItemSubcategory();
	%subcategory = %this.subcategories.getObject(%this.subcategories.count);
	%this.subcategories.count++;

	%category.subcategories.add(%subcategory);
	%subcategory.category = %category;
	%subcategory.setup(%id, %name);
}

function GuiBuildSelection::selectItemCategory(%this, %categoryId, %subcategoryId)
{
	for (%i = 0; %i < %this.categoriesCount; %i++)
	{
		%category = %this.categories[%i];
		if (%category.categoryId != %categoryId)
			continue;

		%category.button.setStateOn(true);
		if (%subcategoryId == -1)
		{
			%subcategory = %category.subcategories.getObject(0);
			if (%subcategory)
				%subcategory.setStateOn(true);
			return;
		}

		for (%i = 0; %i < %category.subcategories.getCount(); %i++)
		{
			%subcategory = %category.subcategories.getObject(%i);
			if (%subcategory.subcategoryId == %subcategoryId)
			{
				%subcategory.setStateOn(true);
				return;
			}
		}
	}
}

function GuiBuildSelection::_onBuildClicked(%this)
{
	%itemId = %this.getSelectedItemId();
	if (%itemId != -1)
		BuildSelection_OnBuildClicked(%itemId);
}

function GuiBuildSelection::_createProfiles(%this)
{
	%profiles = new SimObject() {};
	%this.profiles = %profiles;

	%profiles.blackVLine = new GuiControlProfile( : GuiBaseTextProfile ) {
		opaque = true;
		fillColor = "0 0 0";
	};

	%profiles.button = new GuiControlProfile( : GuiBaseTextProfile ) {
		globalImageIndex = "atlas2";
		fontSize = 24;
		fontColor = "204 204 204";
		fontColorHL = "204 204 204";
		fontColorNA = "204 204 204";
		fontColorSEL = "204 204 204";
		justify = "center";
		textOffset = "0 -2";
		border = "none";
	};

	%profiles.itemNameText = new GuiControlProfile( : GuiBaseTextProfile ) {
		fontSize = 23;
		fontColor = "178 128 28";
	};

	%profiles.itemComponentQtyText = new GuiControlProfile( : GuiBaseTextProfile ) {
		fontSize = 23;
		fontColor = "178 128 28";
		justify = "right";
	};

	%profiles.itemMiscText = new GuiControlProfile( : GuiBaseTextProfile ) {
		fontSize = 19;
		fontColor = "255 255 255";
	};

	%profiles.itemRegionalText = new GuiControlProfile( : GuiBaseTextProfile ) {
		fontSize = 17;
		fontColor = "51 153 153";
	};

	%profiles.itemDescriptionText = new GuiControlProfile( : GuiBaseTextProfile ) {
		fontSize = 19;
		fontColor = "102 102 102";
	};

	%profiles.listItem = new GuiControlProfile( : GuiBaseTextProfile ) {
		fontSize = 19;
		fontColor = "255 255 255";
		fontColorNA = "178 128 28";
		justify = "left";
		fillColorHL = "255 255 255 0";
		fillColor = "255 255 255 0";
	};

	%profiles.category = new GuiControlProfile( : GuiBaseCaptionProfile ) {
		fontSize = 24;
		fontColor = "178 128 28";
		fontColorNA = "102 102 102";
		fillColorHL = "255 255 255 0";
		fillColor = "255 255 255 0";
	};

	%profiles.subcategory = new GuiControlProfile( : GuiBaseTextProfile ) {
		fontSize = 19;
		fontColor = "255 255 255";
		fontColorNA = "154 154 154";
		justify = "left";
		fillColorHL = "255 255 255 0";
		fillColor = "255 255 255 0";
	};
}

function GuiBuildSelection::_createWindow(%this)
{
	%window = new GuiWindowCtrl() {
		position = "0 0";
		extent = "1038 772";
		minExtent = "753 772";
		maxExtent = "1038 772";
		resizeWidth = false;
		resizeHeight = false;
		canMove = true;
		canClose = true;
		canMinimize = false;
		canMaximize = false;
		canCollapse = false;
		canHideOnFreelook = false;
		canLock = true;
		canSetup = true;
		edgeSnap = true;
		margin = "0 0 0 0";
		padding = "0 0 0 0";
		anchorTop = "1";
		anchorBottom = "0";
		anchorLeft = "1";
		anchorRight = "0";
		horizSizing = "center";
		vertSizing = "center";
		profile = "GuiCursorEscWindowProfile";
		visible = true;
		active = true;
		isContainer = true;
		canSave = false;

		new GuiContainer() {
			docking = Client;
			extent = "1038 772";
			enabled = true;
			canSave = true;
			visible = true;

			// groups & subgroups
			new GuiContainer() {
				docking = Left;
				extent = "285 690";
				internalName = "categoriesPanel";
				profile = %this.profiles.blackVLine;

				new GuiStackControl() {
					position = "0 0";
					extent = "285 100";
					stackingType = Vertical;
					dynamicSize = true;
					changeChildPosition = false;
					changeChildSizeToFit = false;
					topIndent = "15";
					internalName = "categories";
				};
			};

			new GuiContainer() {
				docking = Client;
				extent = "1920 1080";

				new GuiBitmapCtrl() {
					position = "0 0";
					extent = "1920 1080";
					bitmap = "gui/images/Main_back_ornament.png";
					profile = "GuiContentProfile";
					horizSizing = "left";
					vertSizing = "top";
				};

				new GuiBitmapCtrl() {
					position = "0 0";
					extent = "36 1080";
					profile = "GuiAtlas1ImageProfile";
					imageIndex = "FringeLeftShadow";
					horizSizing = "right";
					vertSizing = "height";
					wrap = true;
				};

				// main item list
				new GuiContainer()
				{
					docking = Left;
					extent = "365 690";

					new GuiContainer()
					{
						docking = Top;
						canSaveDynamicFields = "0";
						extent = "365 82";
						Enabled = "1";
						Profile = "GuiBaseTextProfile";
						canSave = "1";
						Visible = "0";
						internalName = "decorSubcategoryContainer";

						new GuiBitmapCtrl()
						{
							position = "0 0";
							extent = "365 82";
							minExtent = "0 0";
							profile = "GuiAtlas1ImageProfile";
							visible = "1";
							active = "1";
							imageIndex = CharWndTabBackground;
						};

						new GuiStackControl()
						{
							position = "0 0";
							extent = "365 82";
							minExtent = "8 8";
							horizSizing = "center";
							profile = "GuiBaseTextProfile";
							changeChildSizeToFit = true;
							changeChildPosition = true;
							stackingType = "Horizontal";
							padding = 0;
							internalName = "decorSubcategoryPanel";
						};
					};

					new GuiContainer()
					{
						docking = Client;
						extent = "365 690";
						internalName = "itemListPanel";
					};
				};

				// per item info
				new GuiContainer() {
					docking = Client;
					extent = "374 690";
					internalName = "itemInfoPanel";

					new GuiControl() {
						extent = "2 690";
						profile = %this.profiles.blackVLine;
					};

					new guiHorzTilingButtonCtrl() {
						text = GetMessageIDText(1343);
						position = "36 611";
						extent = "158 44";
						profile = %this.profiles.button;
						groupNum = "-1";
						buttonType = "PushButton";
						useMouseEvents = false;
						imageIndex = "H44Btn";
						internalName = "buildButton";
					};
				};
			};
		};
	};

	return %window;
}

function GuiBuildSelection::_createItemInfoPanel(%this)
{
	%panel = new GuiStackControl() {
		position = "35 30";
		extent = "295 100";
		stacking = Vertical;
		dynamicSize = true;
		dynamicNonStackExtent = false;
		changeChildPosition = false;
		changeChildSizeToFit = false;
		padding = 10;

		new GuiBitmapCtrl() {
			extent = "295 166";
			bitmap = "art/2D/Objects/3Floor_Big_Plaster_House.png";
			profile = "GuiContentProfile";
			internalName = "image";
		};

		new GuiTextCtrl() {
			extent = "295 25";
			profile = %this.profiles.itemNameText;
			internalName = "name";
		};

		new GuiControl() {
			extent = "295 75";

			new GuiMLTextCtrl() {
				extent = "295 75";
				profile = %this.profiles.itemDescriptionText;
				canHit = false;
				internalName = "description";
			};
		};
	};

	for (%i = 0; %i < 5; %i++)
	{
		%component = new GuiControl() {
			extent = "295 41";
			canHit = true;

			new GuiBitmapCtrl() {
				position = "0 0";
				extent = "42 38";
				canHit = false;
				centered = true;
				profile = "GuiContentProfile";
				internalName = "image";
			};

			new GuiTextCtrl() {
				canHit = false;
				position = "50 9";
				extent = "183 19";
				profile = %this.profiles.itemMiscText;
				internalName = "name";
			};

			new GuiTextCtrl() {
				canHit = false;
				text = GetMessageIDText(3141); // Regional resource
				position = "50 24";
				extent = "183 17";
				profile = %this.profiles.itemRegionalText;
				internalName = "isRegional";
			};

			new GuiTextCtrl() {
				canHit = false;
				position = "220 6";
				extent = "75 23";
				profile = %this.profiles.itemComponentQtyText;
				internalName = "count";
			};
		};
		%panel.add(%component);
		%this.itemComponents[%i] = %component;
	}
	return %panel;
}

function GuiBuildSelection::_createItemList(%this)
{
	%scroll = new GuiScrollCtrl() {
		position = "0 5";
		extent = "374 675";
		willFirstRespond = true;
		hScrollBar = "alwaysOff";
		vScrollBar = "alwaysOn";
		lockHorizScroll = false;
		lockVertScroll = false;
		childMargin = "0 0";
		mouseWheelScrollSpeed = "-1";
		margin = "0 0 0 0";
		padding = "0 0 0 0";
		anchorTop = "1";
		anchorBottom = "0";
		anchorLeft = "1";
		anchorRight = "0";
		profile = "GuiEagleScrollBarProfile";
		constantThumbHeight = true;
		alwaysShowThumb = true;
		trackOffset = 12;
		arrowSadowSize = 2;
		addContentWidth = 0;
		horizSizing = "width";
		vertSizing = "height";

		new GuiStackControl() {
			position = "0 0";
			extent = "374 100";
			stacking = Vertical;
			dynamicSize = true;
			changeChildPosition = false;
			changeChildSizeToFit = false;
			padding = 0;
			internalName = "itemListCtrl";
		};
	};

	return %scroll;
}

function GuiBuildSelection::_createListItem(%this)
{
	%control = new GuiButtonCtrl() {
		position = "10 0";
		extent = "350 40";
		buttonType = RadioButton;
		groupNum = 1;
		profile = %this.profiles.listItem;
		canSaveDynamicFields = true;
		class = GuiBuildSelectionListItem;

		new GuiTilingBitmapOverlap() {
			position = "0 0";
			extent = "280 40";
			profile = "GuiAtlas3ImageProfile";
			visible = false;
			canHit = false;

			internalName = "highlighPanel";

			TopLeftIndex = ThickMenuItemMouseOverLeft;
			TopIndex0 = ThickMenuItemMouseOverCenter0;
			TopIndexN = ThickMenuItemMouseOverCenter1;
			TopRightIndex = ThickMenuItemMouseOverRight;
		};

		new GuiTextCtrl() {
			position = "20 0";
			extent = "330 40";
			profile = %this.profiles.listItem;
			canHit = false;

			internalName = "text";
		};
	};

	%this.window-->itemListCtrl.add(%control);
	%this.itemList[%this.itemListCount] = %control;
	%this.itemListMaxCount++;
}

function GuiBuildSelection::_createItemCategory(%this)
{
	%category = new SimObject() {
		class = GuiBuildSelectionCategory;
	};

	%category.subcategories = new GuiStackControl() {
		position = "60 0";
		extent = "225 0";
		stackingType = Vertical;
		dynamicSize = true;
		changeChildPosition = false;
		changeChildSizeToFit = false;
		isContainer = true;
		visible = false;
	};

	%category.button = new GuiButtonCtrl() {
		extent = "285 50";
		buttonType = RadioButton;
		profile = %this.profiles.category;
		class = GuiBuildSelectionCategoryButton;

		subcategories = %category.subcategories;
		category = %category;

		new GuiBitmapCtrl() {
			position = "15 2";
			extent = "45 45";
			profile = "GuiContentProfile";
			canHit = false;

			internalName = "icon";
		};

		new GuiBitmapCtrl() {
			position = "13 0";
			extent = "50 50";
			profile = "GuiAtlas1ImageProfile";
			canHit = false;
			imageIndex = "BuildWindowBorder";
		};

		new GuiTextCtrl() {
			position = "70 12";
			extent = "200 24";
			profile = %this.profiles.category;
			canHit = false;

			internalName = "text";
		};

		new GuiBitmapCtrl() {
			position = "242 16";
			extent = "32 20";
			profile = "GuiAtlas1ImageProfile";
			canHit = false;
			imageIndex = "MetalArrowDown";

			internalName = "arrow";
		};
	};

	%category.gui = %this;

	%padding = new GuiControl() {
		extent = "20 15";
	};

	%this.categories[%this.categoriesCount] = %category;
	%this.categoriesMaxCount++;

	%this.categoriesPanel.add(%category.button);
	%this.categoriesPanel.add(%category.subcategories);
	%this.categoriesPanel.add(%padding);
}

function GuiBuildSelection::_createItemSubcategory(%this)
{
	%subcategory = new GuiButtonCtrl() {
		extent = "225 26";
		buttonType = RadioButton;
		profile = %this.profiles.subcategory;
		class = GuiBuildSelectionSubcategory;

		new GuiTilingBitmapOverlap() {
			position = "0 0";
			extent = "200 26";
			profile = "GuiAtlas3ImageProfile";
			visible = false;
			canHit = false;

			internalName = "highlighPanel";

			TopLeftIndex = SlimMenuItem2MouseOverLeft;
			TopIndex0 = SlimMenuItem2MouseOverCenter0;
			TopIndexN = SlimMenuItem2MouseOverCenter1;
			TopRightIndex = SlimMenuItem2MouseOverRight;
		};

		new GuiTextCtrl() {
			position = "10 0";
			extent = "215 26";
			profile = %this.profiles.subcategory;
			canHit = false;
			active = false;

			internalName = "text";
		};
	};

	%this.subcategories.add(%subcategory);
}

function GuiBuildSelectionListItem::setup(%this, %id, %name, %active)
{
	%this.itemId = %id;
	%this.setVisible(true);
	%this-->highlighPanel.setVisible(false);
	%this-->text.setActive(false);
	%this-->text.setText(%name);
}

function GuiBuildSelectionListItem::onStateChanged(%this, %state)
{
	if (%state)
	{
		BuildSelection_SelectListItem(%this.itemId);
		%this-->highlighPanel.opacity = 1;
	}
	%this-->text.setActive(%state);
	%this-->highlighPanel.setVisible(%state);
}

function GuiBuildSelectionListItem::onMouseOverChanged(%this, %state)
{
	%onState = %this.getStateOn();
	%this-->highlighPanel.setVisible(%onState || %state);
	if (%state && !%onState)
		%this-->highlighPanel.opacity = 0.5;
}

function GuiBuildSelectionCategory::setup(%this, %id, %name, %icon, %active)
{
	%this.categoryId = %id;
	%this.button-->icon.setBitmap(%icon);
	%this.button-->text.setText(%name);
	%this.button-->text.setActive(%active);
	%this.button.setVisible(true);
}

function GuiBuildSelectionCategory::hide(%this)
{
	%this.button.setVisible(false);
	%this.subcategories.setVisible(false);
	%this.subcategories.clear();
}

function GuiBuildSelectionCategoryButton::onStateChanged(%this, %state)
{
	%this.subcategories.setVisible(%state);
	%this-->arrow.setGlobalImageIndex(%state ? "MetalArrowUp" : "MetalArrowDown");
}

function GuiBuildSelectionCategoryButton::onMouseOverChanged(%this, %state)
{
	%baseIndex = %this.getStateOn() ? "MetalArrowUp" : "MetalArrowDown";
	%this-->arrow.setGlobalImageIndex(%state ? %baseIndex @ "MouseOver" : %baseIndex);
}

function GuiBuildSelectionSubcategory::setup(%this, %id, %name)
{
	%this.subcategoryId = %id;
	%this-->text.setText(%name);
	%this-->text.setActive(false);
	%this-->highlighPanel.setVisible(false);
}

function GuiBuildSelectionSubcategory::onStateChanged(%this, %state)
{
	if (%state)
	{
		BuildSelection_SelectSubcategory(%this.category.categoryId, %this.subcategoryId);
		// torque does not support grouped radio buttons from diff parents...
		%gui = %this.category.gui;
		for (%i = 0; %i < %gui.subcategories.count; %i++)
		{
			%subcategory = %gui.subcategories.getObject(%i);
			if (%subcategory.getStateOn() && %subcategory != %this)
				%subcategory.setStateOn(false);
		}
		%this-->highlighPanel.opacity = 1;
	}
	%this-->text.setActive(%state);
	%this-->highlighPanel.setVisible(%state);
}

function GuiBuildSelectionSubcategory::onMouseOverChanged(%this, %state)
{
	%onState = %this.getStateOn();
	%this-->highlighPanel.setVisible(%onState || %state);
	if (%state && !%onState)
		%this-->highlighPanel.opacity = 0.5;
}

singleton ScriptObject( GuiBuildSelection ) {};

function DecorSubcategoryButtonClass::onStateChanged(%this, %state)
{
	if (%state)
	{
		%selectDecor = GuiBuildSelection.window-->selectDecor;
		if (isObject(%selectDecor) == false)
		{
			//select tab decor
			%selectDecor = new GuiControl()
			{
				position = "0 0";
				extent = "100 77";
				Profile = "CharacterWindowSelectedTabDecorProfile";
				BottomLeftIndex = CharWndTabSelectLineLeft;
				BottomIndex0 = CharWndTabSelectLineCenter;
				BottomRightIndex = CharWndTabSelectLineRight;
				visible = false;
				canHit = false;
				internalName = "selectDecor";

				new GuiBitmapCtrl() 
				{
					position = "0 61";
					extent = "26 12";
					minExtent = "0 0";
					profile = "GuiAtlas1ImageProfile";
					visible = "1";
					active = "1";
					imageIndex = CharWndTabSelectArrow;
					horizSizing = "center";
					vertSizing = "top";
				};
			};
		}

		%this.add(%selectDecor);
		%selectDecor.setExtent(%this.getExtent());
		%selectDecor.setVisible(true);
	}
}


