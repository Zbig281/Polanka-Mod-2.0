
function showEscMenu()
{
	PlaySound2d(78);
	toggleEscMenu(true);
}

function showEscMenuOptions()
{
	PlaySound2d(78);
	togglSettingsMenu(true);
}

function hideEscMenu()
{
	PlaySound2d(78);
	toggleEscMenu(false);
}

function toggleEscMenu(%show)
{
	if (%show)
	{
		togglSettingsMenu(false);

		// enable windows rendering
		Canvas.setChildRenderEnabled(true);

		Canvas.pushDialog(MainMenuGui, 99); // under console

		%isConnected = isObject("ServerConnection");
		%isInWorld = (%isConnected && (isObject("PlayGui") && PlayGui.isAwake()));

		if ($cmYO)
		{
			MainMenuGuiLabelSale.setVisible(false);
			MainMenuGuiSubscribeBtn.setVisible(false);
			MainMenuGuiLine.setVisible(false);
			MainMenuGuiChangeIslandBtn.setVisible(false);

			MainMenuGuiPlayersBtn.setVisible(true);

			MainMenuGuiPlayersBtn.setActive(%isInWorld);

			MainMenuGuiShopBtn.setPosition(102, 105);
			MainMenuGuiHelpBtn.setPosition(102, 177);
			MainMenuGuiSettingsBtn.setPosition(102, 250);
			MainMenuGuiPlayersBtn.setPosition(102, 322);
			MainMenuGuiDisconnectBtn.setPosition(102, 394);
			MainMenuGuiExitBtn.setPosition(102, 467);

			MainMenuGuiShopBtn.command = "openSteamStore();";
		}
		else
		{
			MainMenuGuiShopBtn.setVisible(true);
			MainMenuGuiLabelSale.setVisible(isPromoActive());
			MainMenuGuiSubscribeBtn.setVisible(true);
			MainMenuGuiLine.setVisible(true);
			MainMenuGuiChangeIslandBtn.setVisible($isNewbieWorld && %isInWorld);

			%changePos = 0;
			if ($isNewbieWorld && %isInWorld)
			{
				%changePos = 32;
			}

			MainMenuGuiPlayersBtn.setVisible(false);

			MainMenuGuiShopBtn.setActive(%isInWorld);
			MainMenuGuiLabelSale.setActive(%isInWorld);
			MainMenuGuiSubscribeBtn.setActive(%isInWorld);

			MainMenuGuiShopBtn.setPosition(102, 105 - %changePos);
			MainMenuGuiLabelSale.setPosition(253, 104 - %changePos);
			MainMenuGuiSubscribeBtn.setPosition(102, 169 - %changePos);
			MainMenuGuiChangeIslandBtn.setPosition(102, 233 - %changePos);

			MainMenuGuiLine.setPosition(55, 243 + %changePos);

			MainMenuGuiHelpBtn.setPosition(102, 277 + %changePos);
			MainMenuGuiSettingsBtn.setPosition(102, 342 + %changePos);
			MainMenuGuiDisconnectBtn.setPosition(102, 406 + %changePos);
			MainMenuGuiExitBtn.setPosition(102, 471 + %changePos);

			MainMenuGuiShopBtn.command = "hideEscMenu(); openXsollaStore();";
		}

		MainMenuGuiHelpBtn.setActive(%isInWorld);
		MainMenuGuiDisconnectBtn.setActive(%isConnected);

		// esc state
		$cmContextMenuMode = 1;
		fadeScreen(true);
	}
	else
	{
		Canvas.popDialog(MainMenuGui);

		// esc state
		$cmContextMenuMode = 0;
		fadeScreen(false);
	}
}

function togglSettingsMenu(%show)
{
	if (%show)
	{
		Canvas.pushDialog(SettingsMenuGui, 99); // under console

		// esc state
		$cmContextMenuMode = 1;
		fadeScreen(true);
	}
	else
	{
		Canvas.popDialog(SettingsMenuGui);

		// esc state
		$cmContextMenuMode = 0;
		fadeScreen(false);
	}
}

function fadeScreen(%fade)
{
	if(%fade)
	{
		$DOFPostEffect::nearmin = 0.0;
		$DOFPostEffect::nearmax = 0.000001;
		$DOFPostEffect::farmin = 0.0;
		$DOFPostEffect::farmax = 0.0001;
		$DOFPostEffect::GatherBlurSize = 20.0;
	}
	else
	{
		$DOFPostEffect::nearmin = $PostFXManager::Settings::DOF::nearmin;
		$DOFPostEffect::nearmax = $PostFXManager::Settings::DOF::nearmax;
		$DOFPostEffect::farmin = $PostFXManager::Settings::DOF::farmin;
		$DOFPostEffect::farmax = $PostFXManager::Settings::DOF::farmax;
		$DOFPostEffect::GatherBlurSize = $PostFXManager::Settings::DOF::GatherBlurSize;
	}
}

