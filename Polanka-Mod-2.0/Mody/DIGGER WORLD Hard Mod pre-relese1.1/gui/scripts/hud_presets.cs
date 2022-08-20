//-----------------------------------------------------------------------------
function loadGui()
{
	echo("loadGui");
	%OldPath = "data/";

	checkDefHotBarPresetPath();
	$HUDPresetPath = $pref::HUD::pathPresets @ $pref::HUD::preset @ "/";

	%server_uuid = getServerUuid();
	if (%server_uuid $= "")
		$InventoryPath = $pref::Inventory::pathDefault @ getFirstName() @ "_" @ getLastName() @ "/";
	else
		$InventoryPath = $pref::Inventory::pathDefault @ %server_uuid @ "_" @ getFirstName() @ "_" @ getLastName() @ "/";

	echo("HUDPresetPath = " @ $HUDPresetPath);
	echo("HotBarPath = " @ $HotBarPath);
	echo("InventoryPath = " @ $InventoryPath);
	createPath($HUDPresetPath);
	createPath($HotBarPath);
	createPath($InventoryPath);

	//Добавлено 19.06.2015 для совместимости версий. Через несколько месяцев можно удалить

		//Переносим старые настрйоки окон в пресетки по умолчанию
		%mask = "*.obj";
		%filespec = %OldPath @ %mask;
		%hot_bar_name = %OldPath @ "HotBar.obj";

		for(%file = findFirstFile(%filespec, false); %file !$= ""; %file = findNextFile())
		{
			%new_file_name = $HUDPresetPath @ fileName(%file);
			pathCopy(%file, %new_file_name, true);

			if (%file $= %hot_bar_name)
			{
				%new_hot_bar_file_name = $HotBarPath @ fileName(%file);
				pathCopy(%file, %new_hot_bar_file_name, true);
			}
			fileDelete(%file);
		}

		//переносим файл с позициями инвенторя в новое место
		for(%pos_item_file = findFirstFile("cm_pos.pos", false); %pos_item_file !$= ""; %pos_item_file= findNextFile())
		{
			%new_pos_item_file_name = $InventoryPath @ fileName(%pos_item_file);
			pathCopy(%pos_item_file, %new_pos_item_file_name, true);
			fileDelete(%pos_item_file);
		}

	// переносим дефолтные настройки абилок
	%def_abilities_file = findFirstFile("data/DefaultAbilities.xml", false);
	if (%def_abilities_file $= "")
	{
		%preset_abilities_file = "data/defabilities/DefaultAbilities.xml";
		pathCopy( %preset_abilities_file, "data/DefaultAbilities.xml", true);
	}

	loadInventoryPos($InventoryPath @ "cm_pos.pos");

	loadAllGuiProperty();
	showWelcomeMessage();
	commandToServer('checkServerGameMode');
	onLoadGuiComplete();
	setCmFreelookMode(isCanvasFocused(), true);
}
//-----------------------------------------------------------------------------

function loadHotBarData()
{
	cmHotBarLoadDataXml($HotBarPath @ "HotBar.obj");
}
//-----------------------------------------------------------------------------

function loadAllGuiProperty(%only_pos)
{
	if (!isObject(PlayGui) || PlayGui.isAwake() == false)
		return;

	echo("loadAllGuiProperty");
	//Проверяем есть ли файлы в текущей пресетке
	%mask = "*.obj";
	%filespec = $HUDPresetPath @ %mask;
	echo("%filespec = " @ %filespec);
	%file = findFirstFile(%filespec, false);
	echo("%file = " @ %file);
	if (%file $= "")
	{
		//файлов не найдено необходимо подгрузить файлы по умолчанию
		%def_path = $pref::HUD::defPathPresets;

		%extent = PlayGui.getExtent();
		if (%extent.x < 1280)
			%def_path = %def_path @ "1024/";
		else if (%extent.x < 1600)
			%def_path = %def_path @ "1280/";
		else if (%extent.x < 1920)
			%def_path = %def_path @ "1600/";
		else
			%def_path = %def_path @ "1920/";

		copyObjToPath(%def_path, $HUDPresetPath);
	}

	loadPropertyXml(HealthBarWindow, $HUDPresetPath @ "HealthBar.obj");
	loadPropertyXml(StaminaBarWindow, $HUDPresetPath @ "StaminaBar.obj");
	loadPropertyXml(HungerBarWindow, $HUDPresetPath @ "HungerBar.obj");
	loadPropertyXml(OxygenBarWindow, $HUDPresetPath @ "OxygenBar.obj");
	loadPropertyXml(EffectsBar, $HUDPresetPath @ "EffectsBar.obj");
	loadPropertyXml(TargetBar, $HUDPresetPath @ "TargetBar.obj");
	loadPropertyXml(AlignmentBar, $HUDPresetPath @ "AlignmentBar.obj");
	loadPropertyXml(CombosBar, $HUDPresetPath @ "CombosBar.obj");
	loadPropertyXml(MiniCharWindow, $HUDPresetPath @ "MiniCharWindow.obj");
	loadPropertyXml(MoveIndicator, $HUDPresetPath @ "MoveIndicator.obj");
	loadPropertyXml(HorseHPBarWindow, $HUDPresetPath @ "HorseHPBarWindow.obj");
	loadPropertyXml(HorseStamBarWindow, $HUDPresetPath @ "HorseStamBarWindow.obj");
	loadPropertyXml(HorseSpeedWindow, $HUDPresetPath @ "HorseSpeedWindow.obj");
	loadPropertyXml(GroupUnitWindow, $HUDPresetPath @ "GroupUnitWindow.obj");

	if(!cmChatExist())
		cmChatCreate();
	if(!cmChatOnline())
	{
		if($cmChatClient::ircServer !$= "")
			cmChatConnect();
	}
	cmChatLoadPropertyXml($HUDPresetPath @ "ChatWindow.obj");
	cmJoinDefaultChats();

	clearHotBars();
	cmHotBarLoadPropertyXml($HUDPresetPath @ "HotBar.obj");
	loadHotBarData();

	MsgStackInfoWindow.loadWindowProperty();
	MsgEventWindow.loadWindowProperty();
}
//-----------------------------------------------------------------------------


function saveHotBar()
{
	cmHotBarSavePropertyXml($HUDPresetPath @ "HotBar.obj");
	createPath($HotBarPath);
	cmHotBarSaveDataXml($HotBarPath @ "HotBar.obj");
}
//-----------------------------------------------------------------------------

function saveGui()
{
	echo("saveGui");
	createPath($HUDPresetPath);
	savePropertyXml(HealthBarWindow, $HUDPresetPath @ "HealthBar.obj");
	savePropertyXml(StaminaBarWindow, $HUDPresetPath @ "StaminaBar.obj");
	savePropertyXml(HungerBarWindow, $HUDPresetPath @ "HungerBar.obj");
	savePropertyXml(OxygenBarWindow, $HUDPresetPath @ "OxygenBar.obj");
	savePropertyXml(EffectsBar, $HUDPresetPath @ "EffectsBar.obj");
	savePropertyXml(TargetBar, $HUDPresetPath @ "TargetBar.obj");
	savePropertyXml(AlignmentBar, $HUDPresetPath @ "AlignmentBar.obj");
	savePropertyXml(CombosBar,$HUDPresetPath @ "CombosBar.obj");
	savePropertyXml(MiniCharWindow, $HUDPresetPath @ "MiniCharWindow.obj");
	savePropertyXml(MoveIndicator, $HUDPresetPath @ "MoveIndicator.obj");
	savePropertyXml(HorseHPBarWindow, $HUDPresetPath @ "HorseHPBarWindow.obj");
	savePropertyXml(HorseStamBarWindow, $HUDPresetPath @ "HorseStamBarWindow.obj");
	savePropertyXml(HorseSpeedWindow, $HUDPresetPath @ "HorseSpeedWindow.obj");
	savePropertyXml(GroupUnitWindow, $HUDPresetPath @ "GroupUnitWindow.obj");

	cmChatSavePropertyXml($HUDPresetPath @ "ChatWindow.obj");

	saveHotBar();

	MsgStackInfoWindow.saveWindowProperty();
	MsgEventWindow.saveWindowProperty();
}
//-----------------------------------------------------------------------------

function saveObjectPropertyXml(%object, %file_name)
{
	savePropertyXml(%object, $HUDPresetPath @ %file_name @ ".obj");
}
//-----------------------------------------------------------------------------

function loadObjectPropertyXml(%object, %file_name)
{
	loadPropertyXml(%object, $HUDPresetPath @ %file_name @ ".obj");
}
//-----------------------------------------------------------------------------

function deletePreset(%name_preset, %name_menu)
{
	%preset_path = getVariable("$pref::" @ %name_menu @ "::pathPresets") @ %name_preset @ "/";
	%cur_preset = getVariable("$pref::" @ %name_menu @ "::preset");

	if (%cur_preset $= %name_preset)
	{
		echo("delete curent preset " @ %name_menu SPC %name_preset);
		if (%name_menu $= "HotBar")
		{
			$pref::HotBar::preset = "";
			checkDefHotBarPresetPath();
			loadHotBarData();
		}
		else
		{
			return;
		}
	}

	echo("fileDelete " @ %preset_path);
	deleteAllPresetFile(%preset_path);
	fileDelete(%preset_path);
}
//-----------------------------------------------------------------------------

function resetPreset(%name_preset, %name_menu)
{
	%preset_path = getVariable("$pref::" @ %name_menu @ "::pathPresets") @ %name_preset @ "/";
	echo("resetPreset " @ %preset_path);
	deleteAllPresetFile(%preset_path);
	if (%name_preset $= getVariable("$pref::" @ %name_menu @ "::preset"))
	{
		loadAllGuiProperty();
	}
}
//-----------------------------------------------------------------------------

function setCheckBoxHUDPreset(%name_preset)
{
	echo("setCheckBoxHUDPreset" @ %name_preset);
	setStateCheckBox("CheckBoxHUD" @ $pref::HUD::preset, "CheckBoxHUD" @ %name_preset);
}
//-----------------------------------------------------------------------------

function checkDefaultHUDPreset(%name_preset)
{
	echo("checkDefaultHUDPreset " @ %name_preset);
	setStateCheckBox("CheckBoxHUD" @ $winHUDPreset, "CheckBoxHUD" @ %name_preset);
	$winHUDPreset = %name_preset;
	echo("winHUDPreset = " @ $winHUDPreset);
}
//-----------------------------------------------------------------------------

function setDefaultHUDPreset(%name_preset)
{
	echo("setDefaultHUDPreset" @ %name_preset);

	$pref::HUD::preset = %name_preset;
	$HUDPresetPath = $pref::HUD::pathPresets @ $pref::HUD::preset @ "/";

	loadAllGuiProperty();
}
//-----------------------------------------------------------------------------

function checkHotBarPresetCheckBox(%name_preset)
{
	echo("checkHotBarPresetCheckBox" @ %name_preset);
	%old_check_box_name = "CheckBoxHotBar" @ $winHotBarPreset;

	if ($winHotBarPreset $= %name_preset)
		$winHotBarPreset = "";
	else
		$winHotBarPreset = %name_preset;

	setStateCheckBox(%old_check_box_name, "CheckBoxHotBar" @ $winHotBarPreset);
}
//-----------------------------------------------------------------------------

function setDefaultHotBarPreset(%name_preset)
{
	echo("setDefaultHotBarPreset" @ %name_preset);
	%old_check_box_name = "CheckBoxHotBar" @ $pref::HotBar::preset;

	if ($pref::HotBar::preset $= %name_preset)
		$pref::HotBar::preset = "";
	else
		$pref::HotBar::preset = %name_preset;

	checkDefHotBarPresetPath();

	loadHotBarData();
}
//-----------------------------------------------------------------------------

function setStateCheckBox(%old_check_box, %new_check_box)
{
	echo("setStateCheckBox: " @ %old_check_box SPC %new_check_box);
	%old_check_box.setStateOn(false);
	%new_check_box.setStateOn(true);
}
//-----------------------------------------------------------------------------

function checkDefHotBarPresetPath()
{
	if ($pref::HotBar::preset $= "")
	{
		%server_uuid = getServerUuid();
		if (%server_uuid $= "")
			$HotBarPath = $pref::HotBar::pathDefault @ getFirstName() @ "_" @ getLastName() @ "/";
		else
			$HotBarPath = $pref::HotBar::pathDefault @ %server_uuid @ "_" @ getFirstName() @ "_" @ getLastName() @ "/";
	}
	else
	{
		$HotBarPath = $pref::HotBar::pathPresets @ $pref::HotBar::preset @ "/";
	}

	echo("HotBarPath: " @ $HotBarPath);
}
//-----------------------------------------------------------------------------

function deleteAllPresetFile(%preset_path)
{
	%mask = "*.obj";
	%filespec = %preset_path @ %mask;
	for(%file = findFirstFile(%filespec, false); %file !$= ""; %file = findNextFile())
	{
		echo("fileDelete " @ %file);
		fileDelete(%file);
	}
}
//-----------------------------------------------------------------------------

function copyObjToPath(%old_path, %new_path)
{
	echo("copyObjToPath old_path = " SPC %old_path SPC "new_path = " SPC %new_path);

	%mask = "*.obj";
	%filespec = %old_path @ %mask;
	for(%file = findFirstFile(%filespec, false); %file !$= ""; %file = findNextFile())
	{
		echo("file " @ %file);
		%new_file_name = %new_path @ fileName(%file);
		echo("new_file_name " @ %new_file_name);

		pathCopy(%file, %new_file_name, true);
	}
}
//-----------------------------------------------------------------------------

function createNewPresetCopyFrom(%new_preset, %cur_preset, %name_menu)
{
	echo("createNewPresetCopyFrom new_preset=" @ %new_preset @ " name_menu=" @ %name_menu @ " cur_preset=" @ %cur_preset);

	if (!checkPresetName(%new_preset))
	{
		cmShowMessage(1022);	// You can not use that name
		return;
	}

	%preset_path = getVariable("$pref::" @ %name_menu @ "::pathPresets");
	echo("preset_path=" @ %preset_path);

	%new_preset_path = %preset_path @ %new_preset @ "/";
	echo("new_preset_path=" @ %new_preset_path);

	%find_preset = findFirstFile(%new_preset_path);
	if (%find_preset !$= "")
	{
		echo("Preset " @ %new_preset @ " in menu " @ %name_menu @ "is find");
		return; //указанная пресетка уже существует
	}

	createPath(%new_preset_path);

	%cur_preset_path = %preset_path @ %cur_preset @ "/";
	if (%cur_preset $= "")
	{
		if (%name_menu $= "HotBar")
		{
			%cur_preset_path = $HotBarPath;
		}
		else
		{
			return;
		}
	}
	echo("cur_preset_path=" @ %cur_preset_path);

	copyObjToPath(%cur_preset_path, %new_preset_path);
}
//-----------------------------------------------------------------------------

function createNewPreset(%name_preset, %name_menu)
{
	%cur_preset = getVariable("$pref::" @ %name_menu @ "::preset");

	echo(" > createNewPreset name_preset" SPC %name_preset SPC "name_menu" SPC %name_menu);

	createNewPresetCopyFrom(%name_preset, %cur_preset, %name_menu);
}
//-----------------------------------------------------------------------------

function setNewPresetName(%renameDialog, %new_preset_name)
{
	addRenamePreset(%new_preset_name, $curRenamePreset, $curRenameMenu);
}
//----------------------------------------------

function applyRenamePreset(%new_preset_name, %cur_name_preset, %cur_name_menu)
{
	createNewPresetCopyFrom(%new_preset_name, %cur_name_preset, %cur_name_menu);
	%cur_preset = getVariable("$pref::" @ %cur_name_menu @ "::preset");
	if (%cur_preset $= %cur_name_preset)
	{
		if (%cur_name_menu $= "HUD")
			setDefaultHUDPreset(%new_preset_name);
		else if (%cur_name_menu $= "HotBar")
			setDefaultHotBarPreset(%new_preset_name);
	}

	deletePreset(%cur_name_preset, %cur_name_menu);
}
//----------------------------------------------
