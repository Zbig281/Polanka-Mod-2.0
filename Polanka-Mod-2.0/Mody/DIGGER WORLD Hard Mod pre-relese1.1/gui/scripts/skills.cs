//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------
function addSkillLine(%parent, %pos, %len)
{
	%line = new GuiBitmapCtrl() 
	{
		position = %pos;
		extent = %len @ " 4";
		canHit = "false";
		visible = "false";
		Profile = "GuiAtlas1ImageProfile";
		resize = false;
		wrap = true;
		imageIndex = KnownSkillLine;
	};

	%parent.add(%line);
	return %line;
}

function createSkillItem(%skillInfo)
{
	%gui = new GuiSkillItem()
	{
		Enabled = "1";
		Profile = "GuiBaseTextProfile";
		position = "0 0";
		extent = "72 72";
		MinExtent = "8 8";
		canSave = "1";
		Visible = "1";
		canHit = true;
		skillInfo = %skillInfo;

		new GuiBitmapCtrl() 
		{
			position = "0 0";
			extent = "45 45";
			canHit = "false";
			visible = "true";
			internalName = "SkillImage";
			horizSizing = "center";
			vertSizing = "center";
			resize = true;
		};

		new GuiBitmapCtrl() 
		{
			position = "0 0";
			extent = "72 72";
			canHit = "false";
			visible = "true";
			Profile = "GuiAtlas1ImageProfile";
			resize = true;
			internalName = "ActiveBorder";
			horizSizing = "center";
			vertSizing = "center";

			new GuiBitmapCtrl() 
			{
				position = "24 44";
				extent = "24 24";
				canHit = "false";
				visible = "true";
				profile = "GuiAtlas1ImageProfile";
				internalName = "LvlNumPnl";
				imageIndex = SkillLvlNumPnl;

				new GuiTextCtrl() {
					text = "";
					maxLength = "1024";
					position = "0 0";
					extent = "24 24";
					profile = "GuiSkillItemValProfile";
					internalName = "SkillValTxt";
					horizSizing = "center";
					vertSizing = "center";
				};
			};
		};

		new GuiBitmapCtrl()
		{
			position = "0 0";
			extent = "72 72";
			canHit = "false";
			visible = "false";
			Profile = "GuiAtlas1ImageProfile";
			resize = true;
			internalName = "SelectBorder";
			horizSizing = "center";
			vertSizing = "center";
		};

	};

	%btn = new GuiBitmapCtrl() 
	{
		position = "47 40";
		extent = "24 24";
		canHit = "true";
		visible = "true";
		profile = "GuiAtlas1ImageProfile";
		internalName = "LockBtnPnl";
		imageIndex = SkillLvlNumPnl;

		new GuiSkillLockButton()
		{
			imageIndex = BtnStatState;
			profile = "GuiSkillStatImageProfile";
			extent = "18 14";
			position = "0 0";
			command = %gui @ ".changeSkilLock();";
			internalName = "LockBtn";
			horizSizing = "center";
			vertSizing = "center";
		};
	};
	%gui.add(%btn);

	return %gui;
}

function getSkillLinePosition(%skillPanel, %skillCtrl, %skillTypeId)
{
	if (%skillTypeId== 51) //Hunting
	{
		%line = addSkillLine(%skillPanel, "124 492", 38);
		%skillCtrl.addKnowLine(%line);
	}
	else if (%skillTypeId== 28)
	{
		%line = addSkillLine(%skillPanel, "207 69", 112);
		%skillCtrl.addKnowLine(%line);
	}
	else if (%skillTypeId== 33)
	{
		%line = addSkillLine(%skillPanel, "123 145", 112);
		%skillCtrl.addKnowLine(%line);
	}
	else if (%skillTypeId== 36)
	{
		%line = addSkillLine(%skillPanel, "207 220", 112);
		%skillCtrl.addKnowLine(%line);
	}
	else if (%skillTypeId== 47)
	{
		%line = addSkillLine(%skillPanel, "123 295", 112);
		%skillCtrl.addKnowLine(%line);
	}
	else if (%skillTypeId== 43)
	{
		%line = addSkillLine(%skillPanel, "207 370", 112);
		%skillCtrl.addKnowLine(%line);
	}
}

function getSkillItemPosition(%skill_type_id)
{
	// craft skills

	if (%skill_type_id == 1) //Artisan
		return "42 19";
	else if (%skill_type_id == 8) //Carpentry
		return "150 139";
	else if (%skill_type_id == 9) //Bowcraft
		return "270 139";
	else if (%skill_type_id == 10) //Warfare engineering
		return "393 139";

	else if (%skill_type_id == 18) //Construction
		return "150 20";
	else if (%skill_type_id == 19) //Masonry
		return "269 20";
	else if (%skill_type_id == 20) //Architecture
		return "419 5";
	else if (%skill_type_id == 7) //Building Maintain
		return "398 38";

	else if (%skill_type_id == 16) //Digging(terr)
		return "210 81";
	else if (%skill_type_id == 2) //Mining
		return "331 81";
	else if (%skill_type_id == 31) //Precious Prospecting
		return "484 71";
	else if (%skill_type_id == 52) //Jewelry
		return "463 104";

	else if (%skill_type_id == 17) //Materials Preparation
		return "210 201";
	else if (%skill_type_id == 3) //Smelting
		return "329 201";
	else if (%skill_type_id == 4) //Forging
		return "489 186";
	else if (%skill_type_id == 5) //Armorsmithing
		return "468 219";
	
	else if (%skill_type_id == 11) //Nature's lore
		return "42 294";

	else if (%skill_type_id == 21) //Farming
		return "150 297";
	else if (%skill_type_id == 32) //Advanced Farming
		return "269 297";
	else if (%skill_type_id == 6) //Forestry
		return "218 277";
	else if (%skill_type_id == 13) //Brewing
		return "418 283";
	else if (%skill_type_id == 24) //Cooking
		return "397 316";

	else if (%skill_type_id == 12) //Herbalism(Gathering)
		return "210 361";
	else if (%skill_type_id == 14) //Healing
		return "330 361";
	else if (%skill_type_id == 15) //Alchemy
		return "453 361";

	else if (%skill_type_id == 51) //Hunting
		return "42 451";
	else if (%skill_type_id == 22) //Animal lore
		return "151 451";
	else if (%skill_type_id == 23) //Procuration
		return "270 451";
	else if (%skill_type_id == 25) //Tailoring
		return "420 436";
	else if (%skill_type_id == 26) //Warhorse training(Handling)
		return "399 469";

	// combat skills

	else if (%skill_type_id == 28)
		return "127 29";
	else if (%skill_type_id == 29)
		return "308 28";
	else if (%skill_type_id == 30)
		return "479 28";

	else if (%skill_type_id == 33)
		return "42 104";
	else if (%skill_type_id == 34)
		return "223 103";
	else if (%skill_type_id == 35)
		return "394 103";

	else if (%skill_type_id == 36)
		return "127 180";
	else if (%skill_type_id == 38)
		return "308 179";
	else if (%skill_type_id == 40)
		return "479 179";

	else if (%skill_type_id == 47)
		return "42 254";
	else if (%skill_type_id == 48)
		return "223 254";
	else if (%skill_type_id == 49)
		return "394 254";

	else if (%skill_type_id == 43)
		return "127 330";
	else if (%skill_type_id == 44)
		return "308 330";
	else if (%skill_type_id == 45)
		return "479 330";

	else if (%skill_type_id == 56)
		return "58 430";
	else if (%skill_type_id == 57)
		return "193 430";
	else if (%skill_type_id == 58)
		return "328 430";
	else if (%skill_type_id == 59)
		return "462 430";

	// minor skills

	else if (%skill_type_id == 61)
		return "80 81";
	else if (%skill_type_id == 62)
		return "255 81";
	else if (%skill_type_id == 63)
		return "430 81";
	else if (%skill_type_id == 64)
		return "167 220";
	else if (%skill_type_id == 65)
		return "342 220";
	else if (%skill_type_id == 54)
		return "80 357";
	else if (%skill_type_id == 55)
		return "255 357";
	else if (%skill_type_id == 53)
		return "430 357";
}
//-----------------------------------------------------------------------------

function addSkills(%skillPanel, %groupSkill, %skillInfo)
{
	for(%base = getFirstBaseSkill(%groupSkill); %base != "-1"; %base = getNextBaseSkill(%groupSkill))
	{
		addSkill(%skillPanel, %base, %skillInfo);
	}

	for(%sec = getFirstSecondSkill(%groupSkill); %sec != "-1"; %sec = getNextSecondSkill(%groupSkill))
	{
		addSkill(%skillPanel, %sec, %skillInfo);
	}
}
//-----------------------------------------------------------------------------

function addSkill(%skillPanel, %skillTypeId, %skillInfo)
{
	if (%skillTypeId <= 0)
		return;

	%skillCtrl = createSkillItem(%skillInfo);

	%skillbackground = %skillCtrl-->ActiveBorder;
	%SkillLvlNumPnl = %skillCtrl-->LvlNumPnl;
	%SkillBtnLockPnl = %skillCtrl-->LockBtnPnl;

	%knowSelIndex = UnavailableIndex;
	%unknowSelIndex = UnavailableIndex;

	%pos = getSkillItemPosition(%skillTypeId);
	%skillCtrl.setPosition(%pos.x, %pos.y);

	if (%skillTypeId == 1)
	{
		%skillbackground.setGlobalImageIndex(ArtisanKnownSkillBorder);
		%skillCtrl.setExtent(86, 274);
		%SkillLvlNumPnl.setPosition(28, 237);
		%SkillBtnLockPnl.setPosition(51, 246);

		%line = addSkillLine(%skillPanel, "123 61", 38);
		%skillCtrl.addKnowLine(%line);

		%line = addSkillLine(%skillPanel, "123 122", 98);
		%skillCtrl.addKnowLine(%line);

		%line = addSkillLine(%skillPanel, "123 180", 38);
		%skillCtrl.addKnowLine(%line);

		%line = addSkillLine(%skillPanel, "123 242", 98);
		%skillCtrl.addKnowLine(%line);


		%knowSelIndex = ArtisanKnownSkillBorderMouseOver;
	}
	else if (%skillTypeId == 11)
	{
		%skillbackground.setGlobalImageIndex(NatureKnownSkillBorder);
		%skillCtrl.setExtent(86, 154);
		%SkillLvlNumPnl.setPosition(28, 114);
		%SkillBtnLockPnl.setPosition(51, 125);
		%knowSelIndex = NatureKnownSkillBorderMouseOver;

		%line = addSkillLine(%skillPanel, "123 337", 38);
		%skillCtrl.addKnowLine(%line);

		%line = addSkillLine(%skillPanel, "122 401", 99);
		%skillCtrl.addKnowLine(%line);

	}
	else if (%skillTypeId == 51 || %skillTypeId == 28 || %skillTypeId == 33 || %skillTypeId == 36 || %skillTypeId == 47
			|| %skillTypeId == 43 || %skillTypeId == 56 || %skillTypeId == 57 || %skillTypeId == 58 || %skillTypeId == 59
			|| %skillTypeId == 61 || %skillTypeId == 62 || %skillTypeId == 63 || %skillTypeId == 64 || %skillTypeId == 65
			|| %skillTypeId == 54 || %skillTypeId == 55 || %skillTypeId == 53)
	{
		%skillbackground.setGlobalImageIndex(HuntingKnownSkillBorder);
		%skillCtrl.setExtent(86, 86);
		%SkillLvlNumPnl.setPosition(28, 51);
		%SkillBtnLockPnl.setPosition(51, 60);
		%knowSelIndex = BigKnownSkillBorderMouseOver;

		getSkillLinePosition(%skillPanel, %skillCtrl, %skillTypeId);
	}
	else if (%skillTypeId == 20 || %skillTypeId == 7 || %skillTypeId == 31 || %skillTypeId == 52
			|| %skillTypeId == 4 || %skillTypeId == 5 || %skillTypeId == 13 || %skillTypeId == 24
			|| %skillTypeId == 25 || %skillTypeId == 26 || %skillTypeId == 6)
	{
		%skillbackground.setGlobalImageIndex(SmallKnownSkillBorder);
		%skillCtrl.setExtent(72, 72);
		%skillCtrl.setCheckAlpha(true);
		%SkillLvlNumPnl.setPosition(14, 26);
		%SkillBtnLockPnl.setPosition(43, 40);
		%knowSelIndex = SmallKnownSkillBorderMouseOver;
		%unknowSelIndex = SmallUnknownSkillBorderMouseOver;
	}
	else
	{
		%skillbackground.setGlobalImageIndex(BigKnownSkillBorder);
		%skillCtrl.setExtent(86, 86);
		%SkillLvlNumPnl.setPosition(21, 39);
		%SkillBtnLockPnl.setPosition(50, 53);
		%knowSelIndex = BigKnownSkillBorderMouseOver;
		%unknowSelIndex = BigUnknownSkillBorderMouseOver;
		if (%skillTypeId == 8 || %skillTypeId == 9 || %skillTypeId == 16 || %skillTypeId == 17 || %skillTypeId == 18
			|| %skillTypeId == 12 || %skillTypeId == 14 || %skillTypeId == 22 || %skillTypeId == 29 || %skillTypeId == 34
			|| %skillTypeId == 38 || %skillTypeId == 48 || %skillTypeId == 44)
		{
			%linePos = %pos;
			%linePos.x += 74;
			%linePos.y += 41;
			%len = 56;

			if (%skillTypeId == 16)
			{
				%len = 58;
			}
			else if (%skillTypeId == 8)
			{
				%len = 57;
			}
			else if (%skillTypeId == 9)
			{
				%len = 60;
			}
			else if (%skillTypeId == 12)
			{
				%len = 57;
				%linePos.y -= 1;
			}
			else if (%skillTypeId == 14)
			{
				%len = 60;
				%linePos.y -= 1;
			}
			else if (%skillTypeId == 29 || %skillTypeId == 34 || %skillTypeId == 38 || %skillTypeId == 48 || %skillTypeId == 44)
			{
				%len = 108;
			}

			%line = addSkillLine(%skillPanel, %linePos, %len);
			%skillCtrl.addKnowLine(%line);
		}
		else if (%skillTypeId == 19)
		{
			%line = addSkillLine(%skillPanel, "320 38", 110);
			%skillCtrl.addKnowLine(%line);

			%line = addSkillLine(%skillPanel, "333 71", 76);
			%skillCtrl.addKnowLine(%line);
		}
		else if (%skillTypeId == 2)
		{
			%line = addSkillLine(%skillPanel, "387 104", 108);
			%skillCtrl.addKnowLine(%line);

			%line = addSkillLine(%skillPanel, "391 137", 83);
			%skillCtrl.addKnowLine(%line);
		}
		else if (%skillTypeId == 3)
		{
			%line = addSkillLine(%skillPanel, "380 219", 120);
			%skillCtrl.addKnowLine(%line);

			%line = addSkillLine(%skillPanel, "392 252", 87);
			%skillCtrl.addKnowLine(%line);
		}
		else if (%skillTypeId == 21)
		{
			%line = addSkillLine(%skillPanel, "212 326", 32);
			%skillCtrl.addKnowLine(%line);

			%line = addSkillLine(%skillPanel, "213 350", 79);
			%skillCtrl.addKnowLine(%line);
		}
		else if (%skillTypeId == 32)
		{
			%line = addSkillLine(%skillPanel, "321 316", 108);
			%skillCtrl.addKnowLine(%line);

			%line = addSkillLine(%skillPanel, "332 349", 76);
			%skillCtrl.addKnowLine(%line);
		}
		else if (%skillTypeId == 23)
		{
			%line = addSkillLine(%skillPanel, "321 469", 110);
			%skillCtrl.addKnowLine(%line);

			%line = addSkillLine(%skillPanel, "334 502", 76);
			%skillCtrl.addKnowLine(%line);
		}
	}

	%skillPanel.add(%skillCtrl);
	%skillCtrl.init(%skillTypeId, %knowSelIndex, %unknowSelIndex);

	if (%skillTypeId == 1 || %skillTypeId == 28 || %skillTypeId == 61)
	{
		%skillCtrl.setStateOn(true);
	}

	%child_count = getChildCount(%skillTypeId);
	for (%i = 0; %i < %child_count; %i++)
	{
		%child = getChildSkill(%skillTypeId, %i);
		addSkill(%skillPanel, %child, %skillInfo);
	}
}
//-----------------------------------------------------------------------------

function GuiSkillItem::onChooseSkill(%this, %skill_type_id)
{
	%skillInfo = %this.skillInfo;
	if (isObject(%skillInfo))
	{
		%skillInfo.init(%skill_type_id);
	}
}

function showStats()
{
	showStatEqip();
}

function showSkills()
{
}

function showGuild()
{
}

function updateSkillcap(%cur_val, %max_val, %skill_group)
{
	%skilcapBar = "";
	%maxSkillcapVal = "";
	%curSkillcapVal ="";

	if (isObject(CharacterWindowCraftingPnl) == false)
		return;

	if (%skill_group == 1)
	{
		%skilcapBar = CharacterWindowCraftingPnl-->skillcapBar;
		%maxSkillcapVal = CharacterWindowCraftingPnl-->maxSkillcapVal;
		%curSkillcapVal = CharacterWindowCraftingPnl-->curSkillcapVal;
	}
	else if (%skill_group == 2)
	{
		%skilcapBar = CharacterWindowCombatPnl-->skillcapBar;
		%maxSkillcapVal = CharacterWindowCombatPnl-->maxSkillcapVal;
		%curSkillcapVal = CharacterWindowCombatPnl-->curSkillcapVal;
	}
	else if (%skill_group == 3)
	{
		%skilcapBar = CharacterWindowMinorSkillsPnl-->skillcapBar;
		%maxSkillcapVal = CharacterWindowMinorSkillsPnl-->maxSkillcapVal;
		%curSkillcapVal = CharacterWindowMinorSkillsPnl-->curSkillcapVal;
	}

	if (isObject(%skilcapBar))
	{
		%skilcapBar.setMaxValue(%max_val);
		%skilcapBar.setFirstValue(%cur_val);
	}

	if (isObject(%curSkillcapVal))
	{
		%curSkillcapVal.setText(%cur_val);
	}

	if (isObject(%maxSkillcapVal))
	{
		%maxSkillcapVal.setText(%max_val);
	}
}
//-----------------------------------------------------------------------------

function updateMaxSkillcap(%max_val1, %max_val2, %max_val3)
{
	if (isObject(CharacterWindowCraftingPnl))
	{
		CharacterWindowCraftingPnl-->skillcapBar.setMaxValue(%max_val1);
		CharacterWindowCraftingPnl-->maxSkillcapVal.setText(%max_val1);
	}

	if (isObject(CharacterWindowCombatPnl))
	{
		CharacterWindowCombatPnl-->skillcapBar.setMaxValue(%max_val2);
		CharacterWindowCombatPnl-->maxSkillcapVal.setText(%max_val2);
	}

	if (isObject(CharacterWindowMinorSkillsPnl))
	{
		CharacterWindowMinorSkillsPnl-->skillcapBar.setMaxValue(%max_val3);
		CharacterWindowMinorSkillsPnl-->maxSkillcapVal.setText(%max_val3);
	}
}
//-----------------------------------------------------------------------------

function showHealthBar()
{
	if (HealthBar.isVisible())
		HealthBar.setVisible(false);
	else
		HealthBar.setVisible(true);
}
//-----------------------------------------------------------------------------

function showStaminaBar()
{
	if (StaminaBar.isVisible())
		StaminaBar.setVisible(false);
	else
		StaminaBar.setVisible(true);
}
//-----------------------------------------------------------------------------

function showHungerBar()
{
	if (HungerBar.isVisible())
		HungerBar.setVisible(false);
	else
		HungerBar.setVisible(true);
}
//-----------------------------------------------------------------------------

function showAlignmentBar()
{
	if (AlignmentBar.isVisible())
		AlignmentBar.setVisible(false);
	else
		AlignmentBar.setVisible(true);
}
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------

function SkillBoosterControl::onWake(%this)
{
	%this.updateStatus();
}

function SkillBoosterControl::onSleep(%this)
{
	if (%this.timerEvent != 0)
	{
		cancel(%this.timerEvent);
		%this.timerEvent = 0;
	}

	if (%this.forceUpdateEvent != 0)
	{
		cancel(%this.forceUpdateEvent);
		%this.forceUpdateEvent = 0;
	}
}


function SkillBoosterControl::updateStatus(%this)
{
	%button = %this->boosterButton;
	%timer = %this->boosterTimer;

	%button.visible = false;
	%button.active = false;
	%timer.visible = false;

	if (%this.timerEvent != 0)
	{
		cancel(%this.timerEvent);
		%this.timerEvent = 0;
	}

	%status = $cmYO ? "None" : getPowerBoosterStatus(%this.skillGroup);
	%this.currentStatus = %status;

	if (%status $= "Ready")
	{
		%button.visible = true;
		%button.active = true;
		%button.command = %this @ ".consumeBooster();";
	}
	else if (%status $= "Active")
	{
		%timer.visible = true;
		%this.updateTimer();
	}
	else if (%status $= "Cooldown")
	{
		%button.visible = true;
		%button.active = false;
		%this.updateCooldownTimer();
	}
}

function GetBoosterSku(%type)
{
	%sku = 0;
	if (%type == 2)
	{
		%sku = 10195; // Combat booster.
	}
	else if (%type == 1)
	{
		%sku = 10196; // Crafting booster.
	}
	return %sku;
}

function SkillBoosterControl::consumeBooster(%this)
{
	%sku = GetBoosterSku(%this.skillGroup);
	if (%sku == 0)
	{
		return;
	}

	checkXsollaItem(%sku, "Store", %this @ ".checkConsume();");
}

function SkillBoosterControl::checkConsume(%this)
{
	if ($xsolla::callback::consumeType $= "NotConsumable")
	{
		openXsollaStore(GetBoosterSku(%this.skillGroup));
	}
	else if ($xsolla::callback::consumeType $= "Consumable"
		|| $xsolla::callback::consumeType $= "Permanent")
	{
		MessageBoxYesNo("", GetMessageIDText(4535), %this @ ".performConsume(\"" @ $xsolla::callback::consumeType @ "\");", "");
	}
	else if ($xsolla::callback::consumeType $= "DetachedConsumable")
	{
		MessageBoxYesNo("", GetMessageIDText(4534), %this @ ".performConsume(\"DetachedConsumable\");", "");
	}
	else if ($xsolla::callback::consumeType $= "NotConsumableTemporary")
	{
		MessageBoxOK("", GetMessageIDText(4536), "");
	}
	else
	{
		MessageBoxOK("", GetMessageIDText(4537), "");
	}
}

function SkillBoosterControl::performConsume(%this, %consumeType)
{
	%sku = GetBoosterSku(%this.skillGroup);
	if (%sku == 0)
	{
		return;
	}

	if (%this.timerEvent != 0)
	{
		cancel(%this.timerEvent);
		%this.timerEvent = 0;
	}

	consumeXsollaItem(%sku, "Store", %consumeType, %this @ ".consumeFinished();");
}

function SkillBoosterControl::consumeFinished(%this)
{
	%this.savedStatus = %this.currentStatus;
	%this.forceUpdateStatus();
}

function SkillBoosterControl::forceUpdateStatus(%this)
{
	%this.forceUpdateEvent = 0;
	if (!%this.isAwake())
	{
		return;
	}

	%this.updateStatus();
	if (%this.savedStatus $= %this.currentStatus)
	{
		%this.forceUpdateEvent = %this.schedule(1000, "forceUpdateStatus");
	}
}

function SkillBoosterControl::updateTimer(%this)
{
	%this.timerEvent = 0;
	%time = getPowerBoosterTimer(%this.skillGroup);

	if (%time $= "")
	{
		%this.updateStatus();
		return;
	}

	%minutes = getWord(%time, 0);
	%seconds = getWord(%time, 1);

	%textControl = %this->boosterTimer.getObject(0);
	%textControl.setText("<just:center>" @ %minutes @ ":" @ %seconds);
	%this.timerEvent = %this.schedule(1000, "updateTimer");
}

function SkillBoosterControl::updateCooldownTimer(%this)
{
	%this.timerEvent = 0;
	%time = getPowerBoosterCooldown(%this.skillGroup);

	if (%time $= "")
	{
		%this.updateStatus();
		return;
	}

	// TODO: Update tooltip

	%this.timerEvent = %this.schedule(1000, "updateCooldownTimer");
}
