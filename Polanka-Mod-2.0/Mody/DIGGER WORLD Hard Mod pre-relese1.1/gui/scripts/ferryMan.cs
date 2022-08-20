
//----------------------------------------------------------
function openQuestFerryManDialog()
{
	if (!QuestFerryManDialog.isAwake())
	{
		Canvas.pushDialog(QuestFerryManDialog);
	}
	$savedFreelook = $cmFreelookMode;
	setCmFreelookMode(false, true);
}
//----------------------------------------------------------
function closeQuestFerryManDialog()
{
	if (QuestFerryManDialog.isAwake())
	{
		Canvas.popDialog(QuestFerryManDialog);
	}
	setCmFreelookMode($savedFreelook, true);
}
//----------------------------------------------------------
function QuestFerryManAnswer(%number)
{
	closeQuestFerryManDialog();
	setCmFreelookMode($savedFreelook, true);

	switch$(%number)
	{
		case 0:
			error("Can't sail to abella from this function.");
		case 1:
			openQuestFerryManSelectionDialog();
	}
}


//----------------------------------------------------------
function openQuestFerryManSelectionDialog()
{
	if (!QuestFerryManSelectionDialog.isAwake())
	{
		Canvas.pushDialog(QuestFerryManSelectionDialog);
	}
	$savedFreelook = $cmFreelookMode;
	setCmFreelookMode(false, true);

	%firstServerId = $cm_config::Server::ServerSkipCount + 1;
	%lastServerId = $cm_config::Server::ServerSkipCount + $cm_config::Server::ServerCount;
	%currentServerId = ServerConnection.getRemoteServerID();

	QuestFerryManSelectionValueEdit.range = %firstServerId @ " " @ %lastServerId;
	QuestFerryManSelectionValueEdit.setText(%currentServerId);

	QuestFerryManSelectionText.setText(GetMessageIDText(2564, %currentServerId, %lastServerId));
}
//----------------------------------------------------------
function closeQuestFerryManSelectionDialog()
{
	if (QuestFerryManSelectionDialog.isAwake())
	{
		Canvas.popDialog(QuestFerryManSelectionDialog);
	}
	setCmFreelookMode($savedFreelook, true);
}
//----------------------------------------------------------
function QuestFerryManSelectionUpPressed()
{
	%min = getWord(QuestFerryManSelectionValueEdit.range, 0);
	%max = getWord(QuestFerryManSelectionValueEdit.range, 1);
	if(QuestFerryManSelectionValueEdit.text < %max)
	{
		QuestFerryManSelectionValueEdit.text = QuestFerryManSelectionValueEdit.text + 1;
	}
}
//----------------------------------------------------------
function QuestFerryManSelectionDownPressed()
{
	%min = getWord(QuestFerryManSelectionValueEdit.range, 0);
	%max = getWord(QuestFerryManSelectionValueEdit.range, 1);
	if(QuestFerryManSelectionValueEdit.text > %min)
	{
		QuestFerryManSelectionValueEdit.text = QuestFerryManSelectionValueEdit.text - 1;
	}
}
//----------------------------------------------------------
function QuestFerryManSelectionSelected()
{
	FerrymanSelectionDialogAnswer(QuestFerryManSelectionValueEdit.text);
	closeQuestFerryManSelectionDialog();
}
//----------------------------------------------------------
