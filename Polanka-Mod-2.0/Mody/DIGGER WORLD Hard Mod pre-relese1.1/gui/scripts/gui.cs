exec("gui/forms/hotBarWindow.gui");
exec("gui/forms/mapWindow.gui");
exec("gui/forms/characterWindow.gui");
exec("gui/forms/charParamStats.gui");
exec("gui/forms/equipmentWindow.gui");
exec("gui/scripts/equipment.cs");
exec("gui/forms/craftWindow.gui");
exec("gui/scripts/craft.cs");
exec("gui/scripts/skills.cs");
exec("gui/forms/skilMap.gui");
exec("gui/forms/skillInfo.gui");
exec("gui/scripts/contextMenu.cs");
exec("gui/scripts/messageWindow.cs");
exec("gui/forms/AnimalHusbandry.gui");
exec("gui/forms/Outpost.gui");
exec("gui/forms/cmMessageIDBox.gui");
exec("gui/forms/MessageBoxInputText.gui");
exec("gui/scripts/messageBox.cs");
exec("gui/forms/authorityContainerWindow.gui");
exec("gui/scripts/authorityContainer.cs");
exec("gui/forms/buildWindow.gui");
exec("gui/forms/introWindow.gui");
exec("gui/forms/selectCharacter.gui");
exec("gui/scripts/build.cs");
exec("gui/forms/mainMenuGui.gui");
exec("gui/scripts/mainMenuGui.cs");
exec("gui/forms/createCharacterWindow.gui");
exec("gui/scripts/createCharacterUtil.cs");
exec("gui/scripts/createCharacterWindow.cs");
exec("gui/forms/guiBarter.gui");
exec("gui/forms/guiTrebuchet.gui");
exec("gui/forms/optionsVideoDialog.gui");
exec("gui/scripts/optionsVideoDlg.cs");
exec("gui/forms/optionsAudioDialog.gui");
exec("gui/scripts/optionsAudioDlg.cs");
exec("gui/forms/optionsControlsDialog.gui");
exec("gui/scripts/tilesLegend.cs");
exec("gui/forms/CmBuildPosition.gui");
exec("gui/forms/CmObservePosition.gui");
exec("gui/forms/CmDropPosition.gui");
exec("gui/forms/CmSiegePosition.gui");
exec("gui/scripts/hud_presets.cs");
exec("gui/forms/cmMinigame.gui");
exec("gui/forms/cmCraftOptionsDialog.gui");
exec("gui/forms/heraldryDialog.gui");
exec("gui/forms/heraldrySymbolPanel.gui");
exec("gui/forms/HeraldrySettingDialog.gui");
exec("gui/scripts/heraldryDialog.cs");
exec("gui/forms/selectWorld.gui");
exec("gui/forms/selectRegionWorld.gui");
exec("gui/forms/gameSettingsDialog.gui");
exec("gui/scripts/gameSettingsDlg.cs");
exec("gui/forms/exitTimer.gui");
exec("gui/forms/personalClaimWindow.gui");
exec("gui/scripts/personalClaimContainer.cs");
exec("gui/scripts/guiPlayers.cs");
exec("gui/scripts/tooltipManager.cs");
exec("gui/forms/guiTooltip.gui");
exec("gui/forms/claimResize.gui");
exec("gui/scripts/heraldryCooldownTimer.cs");
exec("gui/forms/guiTutorialHint.gui");
exec("gui/forms/guiTradePost.gui");
exec("gui/forms/guiPayForTradePostStore.gui");
exec("gui/forms/guiChangeStoreSize.gui");
exec("gui/forms/guiTradePostRenameDialog.gui");
exec("gui/forms/guiRecordPoints.gui");
exec("gui/forms/horseTraining.gui");
exec("gui/scripts/ferryMan.cs");
exec("gui/forms/ferryManSelection.gui");
exec("gui/forms/guiQuestDialog.gui");
exec("gui/forms/guiQuestTasks.gui");
exec("gui/forms/guiAlertQuest.gui");
exec("gui/forms/progressBar.gui");
exec("gui/forms/progressBar.gui");
exec("gui/forms/deathWindow.gui");
exec("gui/forms/skins.gui");
exec("gui/scripts/skins.cs");
exec("gui/scripts/ferryManSail.cs");
exec("gui/scripts/world-infos.cs");
exec("gui/forms/helpWindow.gui");
exec("gui/forms/guiBanner.gui");
exec("gui/forms/guiPollVoting.gui");
exec("gui/forms/guiCreditsWindow.gui");
exec("gui/forms/guiCreditsWindow2.gui");
exec("gui/forms/guiCreditsWindowD.gui");
exec("gui/forms/subscriptionInfoDialog.gui");
exec("gui/scripts/subscriptionInfoDialog.cs");


exec("gui/forms/SettingsDialog/CmChatSettingsDialog.gui");
exec("gui/forms/SettingsDialog/CmWindowCtrlSettingsDialog.gui");
exec("gui/forms/SettingsDialog/HotBarSettingsDialog.gui");
exec("gui/forms/SettingsDialog/messageWindowSettings.gui");
exec("gui/scripts/SettingsDialog/CmBarSettingsDialog.cs");
exec("gui/scripts/SettingsDialog/CmWindowCtrlSettingsDialog.cs");

if($cmYO)
{
	exec("gui/forms/guiGuildYoCtrl.gui");
}
else
{
	exec("gui/forms/guiGuildMMOCtrl.gui");
}
exec("gui/scripts/guiGuildCtrl.cs");


createMsgStackInfoWindow();
createMsgEventWindow();
//-----------------------------------------------------------------------------

function showSkill(%val)
{
   if(!%val)
      return;

	if (isObject(CharacterWindowCraftingPnl) && CharacterWindowCraftingPnl.visible)
	{
		closeCharacterWindow();
	}
	else
	{
		showCraftingSkills();
	}
}
//-----------------------------------------------------------------------------

function showCharWindow(%val)
{
   if(!%val)
      return;

	if (isObject(CharacterWindowStatEquipPnl) && CharacterWindowStatEquipPnl.visible)
	{
		closeCharacterWindow();
	}
	else
	{
		showStatEqip();
	}
}
//-----------------------------------------------------------------------------

function openSelectionListDlg()
{
	exec("gui/forms/selectionList.gui");
	exec("gui/scripts/listItems.cs");
	Canvas.pushDialog(SelectionListDlg);
}

//-----------------------------------------------------------------------------

function initSelectionListDlg(%buttonText)
{
	SelectionListDlgBtn.setText(%buttonText);
	SelectionListDlgBtn.setActive(false);
}

//-----------------------------------------------------------------------------

function closeSelectionListDlg()
{
	if (isObject(SelectionListDlg))
	{
		Canvas.popDialog(SelectionListDlg);
		SelectionListDlg.safeDeleteObject();
	}
}

//-----------------------------------------------------------------------------

function createChatTab()
{
   exec("gui/forms/chatTab.gui");
   return %guiContent;
}

//-----------------------------------------------------------------------------

function createBuildSelectionGui()
{
   exec("gui/scripts/buildSelection.cs");
}
createBuildSelectionGui();
