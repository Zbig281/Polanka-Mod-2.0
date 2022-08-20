//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

function createPopUpTitleScroll()
{
	%gui = new GuiScrollCtrl()
	{
		hScrollBar = "alwaysOff";
		vScrollBar = "dynamic";
		horizSizing = "width";
		vertSizing = "height";
		profile = "GuiPopUpScrollBarProfile";
		constantThumbHeight = false;
		childMargin = "10 0";
		trackOffset = 11;
		lockHorizScroll = true;
		arrowSadowSize = 2;
		addContentWidth = 0;
	};
	return %gui;
}

function safeClearChilds(%pnl)
{
	%count = %pnl.getCount();
	for(%i = 0; %i < %count; %i++)
	{
		%ctrl = %pnl.getObject(%i);
		%ctrl.safeDeleteObject();
	}
}

function GuildCtrl::onWake(%this)
{
	%titlePopUp = %this-->TitlePopUp;
	if (isObject(%titlePopUp))
	{
		%this.updateTitulList();
		%titlePopUp.sort(false);
	}

	%nametxt = %this-->NameTxt;
	echo(" nametxt = " @ %nametxt);
	if (IsObject(%nametxt))
	{
		%nametxt.setText(getFirstName() SPC getLastName());
	}
}

function GuildCtrl::addTitulPopupItem(%this, %title, %id)
{
	%titlePopUp = %this-->TitlePopUp;
	if (isObject(%titlePopUp))
	{
		%titlePopUp.add(%title, %id);
	}
}

function GuildCtrl::curTitleChange(%this, %id)
{
	%titlePopUp = %this-->TitlePopUp;
	if (isObject(%titlePopUp))
	{
		%titlePopUp.setSelected(%id, false);
	}
}

function TitlePopUp::onSelect(%this, %id, %txt)
{
	commandToServer('cmSetTitle', %id);
}

function GuildCtrl::onGuildRankChange(%this, %icon, %guild_role_name)
{
	echo("onGuildRankChange %icon = " @ %icon);
	%GuildRankIcon = %this-->GuildRankIcon;
	%GuildRankName = %this-->GuildRankName;
	if (isObject(%GuildRankName))
	{
		%GuildRankName.setText(%guild_role_name);
	}
	if (isObject(%GuildRankIcon))
	{
		%GuildRankIcon.setGlobalImageIndex(%icon);
	}

}

function GuildCtrl::clearGuildMembers(%this)
{
	safeClearChilds(GuiGuildMemberListPnl);
	safeClearChilds(GuiGuildLeaderPnl);
}

function GuildCtrl::showCreateGuild(%this)
{
	%this-->GuildTagTextCtrl.setActive(true);
	%this-->GuildNameTextCtrl.setActive(true);
	%this-->GuildTagTextCtrl.setVisible(true);
	%this-->GuildNameTextCtrl.setVisible(true);
	
	GuiGuildNameBorderBtnEdit.setVisible(false);
	GuiGuildNameBorderBtnCancel.setVisible(false);
	GuiGuildNameBorderBtnApply.setVisible(false);
	
	%this-->GuiGuildlessPnl.setVisible(false);
	%this-->GuiCreateGuildPnl.setVisible(true);
	
	%this-->GuildNamePanel.setVisible(true);
}

function GuildCtrl::hideCreateGuild(%this)
{
	GuiGuildPnl-->GuildTagTextCtrl.setActive(false);
	GuiGuildPnl-->GuildNameTextCtrl.setActive(false);
	
	%this-->GuiGuildlessPnl.setVisible(true);
	%this-->GuiCreateGuildPnl.setVisible(false);
	
	%this-->GuildNamePanel.setVisible(false);
}

function GuiGuildPnl::execShowCreateGuild(%this)
{
	GuiGuildPnl.call("createGuildClick", GuiGuildPnl-->GuildNameTextCtrl.getText(), GuiGuildPnl-->GuildTagTextCtrl.getText());
}

function GuiGuildPnl::setGuildNameAndTag(%this, %name, %tag)
{
	echo("setGuildNameAndTag %name = " @ %name @ " tag =" @ %tag);
	%GuildNameTextCtrl = %this-->GuildNameTextCtrl;
	%GuildNameTextCtrl.setText(%name);
	%GuildNameTextCtrl.firstText = %name;

	%GuildTagTextCtrl = %this-->GuildTagTextCtrl;
	%GuildTagTextCtrl.setText(%tag);
	%GuildTagTextCtrl.firstText = %tag;

	checkGuildTagAndNameCtrl();
}

function GuiGuildPnl::showCurGuildInfo(%this)
{
	%this.showGuildInfo();
	if($cmYO)
	{
		%this-->NamePanel.setPosition(319, 0);
		%this-->GuildNamePanel.setPosition(319, 85);
	}
	%this-->GuildNamePanel.setVisible(true);
	
	%this-->GuiGuildlessPnl.setVisible(false);
	%this-->GuiCreateGuildPnl.setVisible(false);
}

function GuiGuildPnl::showGuildInfo(%this)
{
	if (!isObject(GuiGuildPnl))
		return;

	%createGuildIllustration = GuiGuildPnl-->CreateGuildIllustration;
	if (isObject(%createGuildIllustration))
	{
		%createGuildIllustration.setVisible(false);
	}

	%nameTitlePnl= GuiGuildPnl-->NameTitlePnl;
	if (!$cmYO && isObject(%nameTitlePnl))
	{
		%nameTitlePnl.horizSizing = "right";
		%nameTitlePnl.setPosition(0, 0);
	}
	
	GuiInfoGuildPnl.setVisible(true);
	checkGuildNameEditMode(false);
}

function GuiGuildPnl::hideGuildInfo(%this)
{
	if($cmYO)
	{
		%this-->NamePanel.setPosition(160, 50);
		%this-->GuildNamePanel.setPosition(160, 150);
	}
	
	GuiInfoGuildPnl.setVisible(false);
	%this-->GuildNamePanel.setVisible(false);
	%this-->GuiGuildlessPnl.setVisible(true);
}

function GuildTagTextCtrl::onGainFirstResponder(%this)
{
	if (!isObject(GuiGuildPnl))
		return;

	%GuildTagLabel = GuiGuildPnl-->GuildTagLabel;
	%GuildTagLabel.setVisible(false);
}

function GuildTagTextCtrl::onLoseFirstResponder(%this)
{
	if (%this.getText() $= "")
	{
		if (!isObject(GuiGuildPnl))
		return;

		%GuildTagLabel = GuiGuildPnl-->GuildTagLabel;
		%GuildTagLabel.setVisible(false);
	}
}

function GuildNameTextCtrl::onGainFirstResponder(%this)
{
	GuiGuildPnl-->GuildNameLabel.setVisible(false);
}

function GuildNameTextCtrl::onLoseFirstResponder(%this)
{
	if (%this.getText() $= "")
	{
		GuiGuildPnl-->GuildNameLabel.setVisible(true);
	}
}

function GuildCtrl::addGuildLeader(%this, %name, %leaderId, %isShowKick, %isYou)
{
	%gui = new GuiControl()
	{
		position = "0 0";
		extent = "277 35";
		minExtent = "8 8";
		profile = "GuiBaseTextProfile";
	};

	%bmp = new GuiBitmapButtonCtrl()
	{
		position = "34 10";
		extent = "18 14";
		command = "";
		profile = "GuiAtlas3ImageProfile";
		imageIndex = SetLeader1Btn;
		visible = true;
		defaultState = true;
	};

	%gui.add(%bmp);

	%text = new GuiTextCtrl()
	{
		position = "56 0";
		extent = "178 35";
		canHit = "false";
		Profile = "GuildCtrlTextLeaderProfile";
		active = true;
		text = %name;
	};
	%gui.add(%text);

	if (%isShowKick == true)
	{
		%bmp = new GuiBitmapButtonCtrl()
		{
			position = "163 12";
			extent = "18 14";
			imageIndex = KickMemberBtn;
			profile = "GuiAtlas3ImageProfile";
			visible = true;
			command = GuiGuildPnl @ ".leaveGuild(" @ %leaderId @ ");";
		};
		%gui.add(%bmp);
	}

	GuiGuildLeaderPnl.add(%gui);

	GuiGuildNameBorderBtnEdit.setVisible(%isYou);
}

function GuildCtrl::addGuildMember(%this, %name, %memberId, %isManager, %isYou)
{
	%gui = new GuiStackControl()
	{
		position = "0 0";
		extent = "277 21";
		minExtent = "8 8";
		horizSizing = "width";
		profile = "GuiBaseTextProfile";
		changeChildSizeToFit = false;
		dynamicNonStackExtent = true;
		stackingType = "Horizontal";
		stretchChild = false;
		changeChildPosition = false;
		padding = 10;
	};

	%text = new GuiTextCtrl()
	{
		position = "0 0";
		extent = "172 21";
		text = %name;
		renderDotIfTextDoesNotFit = true;
		tooltipIfTextNotFit = true;
	};
	if (%isYou == true)
	{
		%text.Profile = "GuildCtrlTextYourProfile";
	}
	else
	{
		%text.Profile = "GuildCtrlTextMemberProfile";
	}
	%gui.add(%text);

	if (%isManager== false)
	{
		%text.extent = "201 21";
	}

	if (%isManager== true)
	{
		%bmp = new GuiBitmapButtonCtrl()
		{
			position = "0 3";
			extent = "18 14";
			command = GuiGuildPnl @ ".setLeader(" @ %memberId @ ");";
			profile = "GuiAtlas3ImageProfile";
			imageIndex = SetLeader2Btn;
			visible = true;
		};

		%gui.add(%bmp);
	}

	if (%isManager == true || %isYou == true)
	{
		%bmp = new GuiBitmapButtonCtrl()
		{
			position = "0 3";
			extent = "18 14";
			imageIndex = KickMemberBtn;
			profile = "GuiAtlas3ImageProfile";
			visible = true;
		};

		if (%isYou == true)
		{
			%bmp.command = GuiGuildPnl @ ".leaveGuild(" @ %memberId @ ");";
		}
		else
		{
			%bmp.command = GuiGuildPnl @ ".kickMember(" @ %memberId @ ");";
		}
		%gui.add(%bmp);
	}

	GuiGuildMemberListPnl.add(%gui);
}

function GuildCtrl::onMemberCountChange(%this, %cur_count)
{
	GuildMemberCountTextCtrl.setText(%cur_count @ "/64");
}


function checkGuildNameEditMode(%state)
{
	echo("checkGuildNameEditMode");

	GuiGuildPnl-->GuildTagTextCtrl.setActive(%state);
	GuiGuildPnl-->GuildNameTextCtrl.setActive(%state);

	if (%state)
	{
		GuiGuildPnl-->GuildTagTextCtrl.setFirstResponder();
	}

	GuiGuildNameBorderBtnEdit.setVisible(%state == false);
	GuiGuildNameBorderBtnCancel.setVisible(%state);
	GuiGuildNameBorderBtnApply.setVisible(%state);
}

function setGuildNameEditMode()
{
	checkGuildNameEditMode(true);
}

function cancelGuildNameEditMode()
{
	checkGuildNameEditMode(false);
	GuiGuildPnl-->GuildTagTextCtrl.setText(GuiGuildPnl-->GuildTagTextCtrl.firstText);
	GuiGuildPnl-->GuildNameTextCtrl.setText(GuiGuildPnl-->GuildNameTextCtrl.firstText);
	checkGuildTagAndNameCtrl();
}

function applyGuildName()
{
	GuiGuildPnl-->GuildTagTextCtrl.firstText = GuiGuildPnl-->GuildTagTextCtrl.getText();
	GuiGuildPnl-->GuildNameTextCtrl.firstText = GuiGuildPnl-->GuildNameTextCtrl.getText();

	checkGuildNameEditMode(false);
	checkGuildTagAndNameCtrl();

	GuiGuildPnl.call("renameGuildClick", GuiGuildPnl-->GuildNameTextCtrl.getText(), GuiGuildPnl-->GuildTagTextCtrl.getText());
}

function checkGuildTagAndNameCtrl()
{
	if (!isObject(GuiGuildPnl))
		return;

	%GuildTagLabel = GuiGuildPnl-->GuildTagLabel;
	%GuildTagTextCtrl = GuiGuildPnl-->GuildTagTextCtrl;

	%GuildNameLabel = GuiGuildPnl-->GuildNameLabel;
	%GuildNameTextCtrl = GuiGuildPnl-->GuildNameTextCtrl;

	%showTagLbl = %GuildTagTextCtrl.getText() $= "";
	%GuildTagLabel.setVisible(%showTagLbl);
	%GuildTagTextCtrl.setVisible(!%showTagLbl);

	%showNameLbl = %GuildNameTextCtrl.getText() $= "";
	%GuildNameLabel.setVisible(%showNameLbl);
	%GuildNameTextCtrl.setVisible(!%showNameLbl);
}
