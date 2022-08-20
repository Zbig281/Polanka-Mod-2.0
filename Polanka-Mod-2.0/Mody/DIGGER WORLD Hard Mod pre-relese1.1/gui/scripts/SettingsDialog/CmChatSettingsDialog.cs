function CmChatSettingsDialog::updateWindowSettings()
{
	%window = CmGuiChatSelectedWindow();
	CmChatSettingsOpacity.value = %window.opacity * 100;
	CmChatSettingsOpacityText.text = mFloor(CmChatSettingsOpacity.value);
	CmChatSettingsShowTimestamps.setStateOn(%window.getShowTimestamps());
	CmChatSettingsLogFileName.text = %window.logFileName;
	CmChatSettingsLogEnabled.setStateOn(strlen(CmChatSettingsLogFileName.text) > 0);
	CmChatSettingsDialog.updateEnableLog();
}

function CmChatSettingsDialog::updateEnableLog()
{
	%e = CmChatSettingsLogEnabled.isStateOn();
	CmChatSettingsLogMaximumMessagesLabel.active = %e;
	CmChatSettingsLogMaximumMessages.active = %e;
	CmChatSettingsLogFileNameLabel.active = %e;
	CmChatSettingsLogFileName.active = %e;
	CmChatSettingsLogFileNameBrowse.active = %e;
	if(!%e)
		CmChatSettingsLogFileName.text = "";
}
