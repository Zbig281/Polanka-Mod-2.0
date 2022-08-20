function CloseSubscriptionInfoDialog()
{
	if (isObject(SubscriptionInfoGui) && SubscriptionInfoGui.isAwake())
	{
		Canvas.popDialog(SubscriptionInfoGui);
		SubscriptionInfoGui.safeDeleteObject();
	}
}

function SubscriptionInfoDialog::show(%this)
{
	Canvas.pushDialog(%this);
}

function SubscriptionInfoDialog::setLoadingState(%this, %state)
{
	%this-->loading.visible = %state;
	%this-->content.visible = !%state;
	%this-->header1.visible = !%state;
	%this-->header2.visible = !%state;
	%this-->buySubscription.visible = !%state;

	%this-->stacker.freeze(%state);
	%this-->boosterStacker.freeze(%state);
}

function SubscriptionInfoDialog::setSubscriptionState(%this, %state)
{
	%this-->boosterStacker.visible = %state;
	%this-->boosterStackerPlaceholder.visible = !%state;
}

function SubscriptionInfoDialog::setTitleText(%this, %text)
{
	%this-->window.setText(%text);
}

function SubscriptionInfoDialog::setTitle(%this, %textId)
{
	%this.setTitleText(GetMessageIDText(%textId));
}

function SubscriptionInfoDialog::setHeader1Text(%this, %text)
{
	%this-->header1.setText(%text);
}

function SubscriptionInfoDialog::setHeader1(%this, %textId)
{
	%this.setHeader1Text(GetMessageIDText(%textId));
}

function SubscriptionInfoDialog::setHeader2Text(%this, %text)
{
	%this-->header2.setText(%text);
}

function SubscriptionInfoDialog::setHeader2(%this, %textId)
{
	%this.setHeader2Text(GetMessageIDText(%textId));
}

function SubscriptionInfoDialog::setButtonText(%this, %textId)
{
	%this-->buySubscription.setText(GetMessageIDText(%textId));
}

function SubscriptionInfoDialog::addBullet(%this, %textId)
{
	%ctrl = new GuiFlexCtrl()
	{
		profile = "subscriptionInfoDialogBulletProfile";
		stackingType = "row";
		align = "start"; // vertical align
		dynamicHeight = "1";
		padding = "5 0";

		// Bullet
		new GuiControl() // parent will align this control
		{
			extent = "16 18";

			new GuiBitmapCtrl() // but not this one
			{
				position = "0 2";
				extent = "16 16";
				profile = "GuiAtlas3ImageProfile";
				imageIndex = TaskCheckBoxDisabled;
				centered = "0";
				canHit = "0";
				wrap = "0";
				resize = "0";
			};
		};

		// Text
		new GuiMLTextCtrl()
		{
			position = "24 0";
			text = GetMessageIDText(%textId);
			profile = "subscriptionInfoDialogBulletTextProfile";
			horizSizing = "width";
			canHit = "0";
			bottomOffset = "0";
			rightOffset = "50";
		};
	};

	%this-->stacker.add(%ctrl);
}

function SubscriptionInfoDialog::createDelimiter(%this, %verticalPadding)
{
	%ctrl = new GuiContainer()
	{
		extent = "100% " @ (%verticalPadding * 2 + 1);
		profile = "subscriptionInfoDialogDelimiterProfile";
		horizSizing = "width";

		new GuiControl()
		{
			extent = "100% 1";
			profile = "GuiAtlas3TiledImageProfile";
			visible = "1";
			canHit = "0";
			horizSizing = "width";
			vertSizing = "center";
			TopIndex0 = HLine1;
			TopIndexN = HLine4;
		};
	};

	return %ctrl;
}

function SubscriptionInfoDialog::addDelimiter(%this)
{
	%ctrl = %this.createDelimiter(8);
	%this-->stacker.add(%ctrl);
}

function SubscriptionInfoDialog::addBoosterDelimiter(%this)
{
	%ctrl = %this.createDelimiter(0);
	%this-->boosterStacker.add(%ctrl);
}

function SubscriptionInfoDialog::formatTimeout(%this, %timeout)
{
	%days = mFloor(%timeout / (24 * 60 * 60));
	%hours = mFloor((%timeout / (60 * 60)) % 24);
	%minutes = mFloor((%timeout / 60) % 60);
	%seconds = mFloor(%timeout % 60);
	return ("" @ %days @ ":" @ strformat("%02d", %hours) @ ":" @ strformat("%02d", %minutes) @ ":" @ strformat("%02d", %seconds));
}

function SubscriptionInfoDialog::addSkin(%this, %icon, %name, %desc, %timeout)
{
	%ctrl = new GuiFlexCtrl()
	{
		profile = "subscriptionInfoDialogSkinProfile";
		horizSizing = "width";
		align = "top";
		justify = "stretch";
		dynamicHeight = "1";

		// Skin Icon
		new GuiFlexCtrl()
		{
			position = "0 0";
			extent = "130 220";
			direction = "column";
			dynamicHeight = "1";
			canHit = "0";
			align = "center";
			marginTop = 15;

			new GuiBitmapCtrl()
			{
				profile = "GuiDefaultProfile";
				bitmap = %icon;
				centered = "0";
				canHit = "0";
				wrap = "0";
				resize = "1";
			};
		};

		// Skin content
		new GuiFlexCtrl()
		{
			horizSizing = "relative";
			direction = "column";
			dynamicHeight = "1";
			padding = "0 5";

			// Skin header (name)
			new GuiFlexCtrl()
			{
				justify = "stretch";
				align = "start";
				canHit = "0";
				dynamicHeight = "1";
				marginTop = 7;

				new GuiMLTextCtrl()
				{
					horizSizing = "relative";
					profile = "subscriptionInfoDialogSkinHeaderProfile";
					text = %name;
					bottomOffset = 0;
				};
			};

			// Skin description
			new GuiMLTextCtrl()
			{
				canHit = "0";
				profile = "subscriptionInfoDialogSkinDescriptionProfile";
				text = %desc;
				bottomOffset = 0;
			};

			// Skin footer
			new GuiFlexCtrl()
			{
				extent = "100% 1";
				stackingType = "row";
				justify = "stretch";
				align = "center";
				dynamicHeight = "1";
				padding = "5 0";

				new GuiControl()
				{
					extent = "15 19";

					new GuiBitmapCtrl()
					{
						position = "0 3";
						extent = "15 16";
						profile = "GuiAtlas3ImageProfile";
						imageIndex = LightTimeIcon;
						centered = "0";
						canHit = "0";
						wrap = "0";
						resize = "0";
						visible = "1";
					};
				};

				new GuiMLTextCtrl()
				{
					internalName = "timer";
					profile = "subscriptionInfoDialogSkinTimerProfile";
					text = GetMessageIDText(4901, %this.formatTimeout(%timeout));
					horizSizing = "width";
					visible = "1";
					canHit = "0";
					bottomOffset = 0;
				};
			};
		};
	};

	%this-->stacker.add(%ctrl);
	%this.schedule(1000, updateSkinTimer, %ctrl, %timeout);
}

function SubscriptionInfoDialog::updateSkinTimer(%this, %ctrl, %timeout)
{
	if (!%this.isAwake())
	{
		return;
	}

	%timeout = getMax(0, %timeout - 1);

	%ctrl-->timer.firstText = %timeout;
	%ctrl-->timer.setText(GetMessageIDText(4901, %this.formatTimeout(%timeout)));

	%this.schedule(1000, updateSkinTimer, %ctrl, %timeout);
}

function SubscriptionInfoDialog::addBooster(%this, %descId, %tooltipId, %type)
{
	%ctrl = new GuiFlexCtrl()
	{
		extent = "100% 1";
		profile = "subscriptionInfoDialogBoosterProfile";
		horizSizing = "width";
		align = "center";
		justify = "stretch";
		dynamicHeight = "1";
		padding = "5 0";
		marginRight = 55;
		tooltip = GetMessageIDText(%tooltipId);

		// Booster name
		new GuiMLTextCtrl()
		{
			profile = "subscriptionInfoDialogBoosterNameProfile";
			text = GetMessageIDText(%descId);
			horizSizing = "relative";
			visible = "1";
			canHit = "0";
			bottomOffset = "0";
		};

		// Booster button
		new GuiControl()
		{
			extent = "65 65";
			profile = "subscriptionInfoDialogBoosterButtonProfile";

			new GuiButtonCtrl()
			{
				internalName = "boosterButton";
				position = "0 0";
				extent = "65 65";
				visible = "1";
				active = "0";
				profile = "GuiAtlas2ImageProfile";
				imageIndex = BtnBooster;
				// command = ""; // will be set in booster update
				tooltip = GetMessageIDText(%tooltipId);
			};

			new GuiBitmapCtrl()
			{
				internalName = "boosterTimer";
				position = "0 0";
				extent = "65 65";
				profile = "GuiAtlas2ImageProfile";
				visible = "0";
				canHit = "0";
				imageIndex = BtnBoosterTimer;

				new GuiMLTextCtrl()
				{
					position = "3 23";
					extent = "63 2";
					profile = "subscriptionInfoDialogBoosterTimerProfile";
					canHit = "0";
				};
			};
		};
	};

	%this-->boosterStacker.add(%ctrl);

	%this.updateBooster(%ctrl, %type);
}

function SubscriptionInfoDialog::updateBooster(%this, %ctrl, %type)
{
	%status = ($cmYO ? "None" : getPowerBoosterStatus(%type));

	%button = %ctrl-->boosterButton;
	%timer = %ctrl-->boosterTimer;

	%timer.visible = (%status $= "Active");
	%button.active = (%status $= "Ready");
	%button.visible = !%timer.visible;

	if (%button.active)
	{
		%button.command = %this @ ".activateBooster(" @ %type @ ", " @ %ctrl @ ");";
	}
	else if (%timer.visible)
	{
		%time = getPowerBoosterTimer(%type);

		if (%time !$= "")
		{
			%minutes = getWord(%time, 0);
			%seconds = getWord(%time, 1);

			%timerText = %timer.getObject(0);
			%timerText.setText("<just:center>" @ %minutes @ ":" @ %seconds);
		}

		%this.schedule(1000, updateBooster, %ctrl, %type);
	}
}

function SubscriptionInfoDialog::activateBooster(%this, %type, %ctrl)
{
	%sku = GetBoosterSku(%type);
	if (%sku == 0)
	{
		return;
	}

	%ctrl-->boosterButton.active = false;

	checkXsollaItem(%sku, "Store", %this @ ".checkActivateBooster(" @ %sku @ ", " @ %ctrl @ ", " @ %type @ ");");
}

function SubscriptionInfoDialog::checkActivateBooster(%this, %sku, %ctrl, %type)
{
	if ($xsolla::callback::consumeType $= "DetachedConsumable")
	{
		MessageBoxYesNo("", GetMessageIDText(4534),
			%this @ ".performActivateBooster(" @ %sku @ ", " @ %ctrl @ ", " @ %type @ ");", // yes
			%this @ ".updateBooster(" @ %ctrl @ ", " @ %type @ ");"); // no
	}
	else
	{
		if ($xsolla::callback::consumeType $= "NotConsumableTemporary")
		{
			MessageBoxOK("", GetMessageIDText(4536), "");
		}
		else
		{
			MessageBoxOK("", GetMessageIDText(4537), "");
		}

		%this.updateBooster(%ctrl, %type);
	}
}

function SubscriptionInfoDialog::performActivateBooster(%this, %sku, %ctrl, %type)
{
	consumeXsollaItem(%sku, "Store", "DetachedConsumable", %this @ ".finishActivateBooster(" @ %ctrl @ ", " @ %type @ ");");
}

function SubscriptionInfoDialog::finishActivateBooster(%this, %ctrl, %type)
{
	%this.updateBooster(%ctrl, %type);
}
