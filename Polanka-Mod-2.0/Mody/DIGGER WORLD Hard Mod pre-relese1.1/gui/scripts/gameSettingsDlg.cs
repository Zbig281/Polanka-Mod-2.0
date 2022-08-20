function showGameSettingsDlg()
{
	createGameSettingsDlg();

	$oldReceiveInvitationGuild = $pref::GameSetting::receiveInvitationGuild;
	$oldReceiveInvitationGroup = $pref::GameSetting::receiveInvitationGroup;
	$oldReceiveRequestsBarter  = $pref::GameSetting::receiveRequestsBarter;
	$Tutorial::Setting::currentShowValue = $pref::GameSetting::showTutorial;
}

function GameSettingsDlg::cancelAndClose(%this)
{
	$pref::GameSetting::receiveInvitationGuild = $oldReceiveInvitationGuild;
	$pref::GameSetting::receiveInvitationGroup = $oldReceiveInvitationGroup;
	$pref::GameSetting::receiveRequestsBarter  = $oldReceiveRequestsBarter;

	%this.closeDialog();
}

function GameSettingsDlg::closeDialog(%this)
{
	if ($applied)
	{
		%this.restoreOlds();
	}

	Canvas.popDialog(GameSettingsDlg);
	GameSettingsDlg.safeDeleteObject();
}

function applyNewGameSettings()
{
	applyGameSettingsLanguageChanged();
	applyGameSettingsShowTutorialChanged();

	if (isObject(GameSettingsDlg))
	{
		GameSettingsDlg.closeDialog();
	}
}