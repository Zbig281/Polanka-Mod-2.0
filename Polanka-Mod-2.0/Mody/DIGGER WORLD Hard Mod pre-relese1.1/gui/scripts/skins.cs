
// SelectSkinPlayGui

// action map that contains only actions that allowed with SkinsSelectWindow
new ActionMap(skinsActionMap);

function SelectSkinPlayGui::showSkins(%this, %slotId)
{
   // rebind existent freelook controls to skinsActionMap
   skinsActionMap.copyBind(moveMap, toggleCmFreelookMode);
   skinsActionMap.copyBind(moveMap, yaw);
   skinsActionMap.copyBind(moveMap, pitch);
   
   if (%this.loadSkins(%slotId))
   {
      SkinsSelectWindow-->skinsCaption.setText("");
      %this.show();
   }
}

function SelectSkinPlayGui::setCaption(%this, %text)
{
   SkinsSelectWindow-->skinsCaption.setText(%text);
}

function SelectSkinPlayGui::updateSkins(%this)
{
   %this.loadSkins(%this.slotId);
}

function SelectSkinPlayGui::clearSkins(%this)
{
   SkinsSelectWindow.clearSkins();
}

function SelectSkinPlayGui::loadSkins(%this, %slotId)
{
   %this.slotId = %slotId;
   %this.premiumTimers = "";
   %this.selectedSkin = -1;
   %this.activeSkin = -1;
   
   SkinsSelectWindow.setLoadingState(true);
   SkinsSelectWindow-->skinsList.freeze(true);
   SkinsSelectWindow.clearSkins();
   
   return SkinsLoadAvailable(%slotId);
}

function SelectSkinPlayGui::finishedLoading(%this)
{
   SkinsSelectWindow-->skinsList.freeze(false);
   SkinsSelectWindow.setLoadingState(false);
}

function SelectSkinPlayGui::setPremiumTimer(%this, %timervalue)
{
   if (%this.timerevent != 0)
   {
      cancel(%this.timerevent);
   }
   
   %this.timervalue = %timervalue + 1;
   if (%timervalue > 0)
   {
      %this.updateTimer();
   }
}

function MakeTimerStringPretty(%timer)
{
   %seconds = %timer % 60;
   %timer = mFloor(%timer / 60);
   
   %minutes = %timer % 60;
   %timer = mFloor(%timer / 60);
   
   %hours = %timer % 24;
   %time = mFloor(%timer / 24);
   
   %days = %hours;
   
   if (%days == 0)
   {
      if (%seconds < 10)
      {
         %seconds = "0" @ %seconds;
      }
      
      if (%minutes < 10)
      {
         %minutes = "0" @ %minutes;
      }
      
      return %hours @ ":" @ %minutes @ ":" @ %seconds;
   }
   
   return GetMessageIDText(4125, %days, %hours);
}

function SelectSkinPlayGui::updateTimer(%this)
{
   %timervalue = %this.timervalue - 1;
   %this.timervalue = %timervalue;
   if (%timervalue <= 0)
   {
      %this.updateSkins();
      return;
   }
   
   %timerstring = MakeTimerStringPretty(%timervalue);
   
   %count = getWordCount(%this.premiumTimers);
   for (%i = 0; %i < %count; %i++)
   {
      %premiumTimer = getWord(%this.premiumTimers, %i);
      %premiumTimer.setText("<just:right>" @ GetMessageIDText(4124, %timerstring)); //avaliable timer
   }
   
   %this.timerevent = %this.schedule(1000, "updateTimer");
}

function SelectSkinPlayGui::show(%this)
{
   setFittingModeCamera(true);

   Canvas.pushDialog(SkinsSelectWindow);
}

function SelectSkinPlayGui::close(%this)
{
   Canvas.popDialog(SkinsSelectWindow);

   if (%this.timerevent != 0)
   {
      cancel(%this.timerevent);
   }
   setFittingModeCamera(false);
}

function SelectSkinPlayGui::addSkin(%this, %id, %icon, %header, %desc, %status)
{
	%equipStatus = getWord(%status, 2);
   %guiControl = SkinsSelectWindow.addSkin(%id, %icon, %header, %desc, %status);
   %guiControl-->equipButton.command = "SelectSkinPlayGui.equipSkin(" @ %id @ ");";
   if ($cmYO)
   {
      %guiControl-->buyButton.command = "openSteamStore(" @ %id @ ");";
   }
   else
   {
      %guiControl-->buyButton.command = "openXsollaStore(" @ %id @ ", false, 1); setXsollaWindowVisibleInClearMode();";
   }
   
   if (%equipStatus == 1)
   {
      %timer = %guiControl-->premiumTimer;
      
      if (getWordCount(%this.premiumTimers) > 0)
      {
         %this.premiumTimers = %this.premiumTimers SPC %timer;
      }
      else
      {
         %this.premiumTimers = %timer;
      }
   }
}

function SelectSkinPlayGui::selectSkin(%this, %id)
{
   if (%this.selectedSkin == %id)
   {
      return;
   }
   
   %skinChanged = %this.selectedSkin >= 0;
   if (%skinChanged)
   {
      SkinsSelectWindow.setSelectedState(%this.selectedSkin, false);
   }
   
   if (SkinsSelectWindow.setSelectedState(%id, true))
   {
      if (%skinChanged)
      {
         SkinsSelectSkin(%this.slotId, %id);
      }
      %this.selectedSkin = %id;
   }
}

function SelectSkinPlayGui::equipSkin(%this, %id)
{
   if (%this.activeSkin == %id)
   {
      return;
   }
   
   %skinApplyChanged = %this.activeSkin >= 0;
   if (%skinApplyChanged)
   {
      SkinsSelectWindow.setActiveState(%this.activeSkin, false);
   }
   
   if (%this.selectedSkin >= 0)
   {
      SkinsSelectWindow.setSelectedState(%this.selectedSkin, false);
   }
   
   if (SkinsSelectWindow.setActiveState(%id, true) && SkinsSelectWindow.setSelectedState(%id, true))
   {
      if (%skinApplyChanged)
      {
         SkinsApplySkin(%this.slotId, %id);
      }
      %this.activeSkin = %id;
      %this.selectedSkin = %id;
   }
}

// SelectSkinsWindow

function SelectSkinsWindow::onWake(%this)
{
   moveMap.pop();
   skinsActionMap.push();

   setClearMode(true);
   addClearModeWindow(SelectSkinDialogWnd);
}

function SelectSkinsWindow::onSleep(%this)
{
   skinsActionMap.pop();
   moveMap.push();

   setClearMode(false);
}

function SelectSkinsWindow::clearSkins(%this)
{
   %this-->skinsList.clear();
}

function SelectSkinsWindow::addSkin(%this, %id, %icon, %header, %desc, %status)
{
   %guiControl = createSkinsSelectElement(%icon, %header, %desc, %status);
   %guiControl.internalName = "skinControl" @ %id;
   %guiControl-->mouseControl.skinId = %id;
   
   %skinsList = %this-->skinsList;
   
   if (%skinsList.getCount() > 0)
   {
      %skinsList.add(createSkinsSelectDivider());
   }
   
   %skinsList.add(%guiControl);
   
   return %guiControl;
}

function SelectSkinsWindow::setLoadingState(%this, %state)
{
   %loadingElement = %this-->loadingSpinner;
   %skinsContent = %this-->skinsContent;
   
   if (%state)
   {
      %loadingElement.setVisible(true);
      %skinsContent.setVisible(false);
   }
   else
   {
      %loadingElement.setVisible(false);
      %skinsContent.setVisible(true);
   }
}

function SelectSkinsWindow::setSelectedState(%this, %skinId, %state)
{
   %guiControl = %this.findObjectByInternalName("skinControl" @ %skinId, true);
   if (%guiControl == 0)
   {
      return false;
   }
   
   %guiControl-->clothedText.setVisible(%state);
   %guiControl-->clothedBackground.setVisible(%state);
   return true;
}

function SelectSkinsWindow::setActiveState(%this, %skinId, %state)
{
   %guiControl = %this.findObjectByInternalName("skinControl" @ %skinId, true);
   if (%guiControl == 0)
   {
      return false;
   }
   
   %guiControl-->equipButton.setActive(!%state);
   return true;
}

// SelectSkinsMouseControl

function SelectSkinsMouseControl::onMouseDown(%this, %modifier, %point, %clickCount)
{
   if (%clickCount == 2)
   {
      SelectSkinPlayGui.selectSkin(%this.skinId);
   }
}

// SkinsListWindow

function SkinsListWindow::clearSkins(%this)
{
   %this-->skinsList.clear();
}

function SkinsListWindow::addSkin(%this, %icon, %equipType, %combine)
{
   %skinsList = %this-->skinsList;
   if (%this.currentStackElement == 0
      || %this.currentStack >= 3)
   {
      if (%skinsList.getCount() > 0)
      {
         %skinsList.add(createSkinsSelectDivider());
      }
      
      %this.currentStack = 0;
      %this.currentStackElement = new GuiFlexCtrl()
      {
         extent = %skinsList.getExtent();
         align = center;
         dynamicHeight = true;
      };
      
      %skinsList.add(%this.currentStackElement);
   }
   
   if (%this.currentStack > 0)
   {
      %this.currentStackElement.add(createSkinsListVerticalDivider());
   }
   
   %this.currentStackElement.add(createSkinsListElement(%icon, %equipType, %combine));
   %this.currentStack++;
}

function SkinsListWindow::setLoadingState(%this, %state)
{
   %loadingElement = %this-->loadingSpinner;
   %skinsContent = %this-->skinsContent;
   
   if (%state)
   {
      %loadingElement.setVisible(true);
      %skinsContent.setVisible(false);
   }
   else
   {
      %loadingElement.setVisible(false);
      %skinsContent.setVisible(true);
   }
}

function SkinsListWindow::loadSkins(%this)
{
   %this.currentStack = 0;
   %this.currentStackElement = 0;
   
   %this.setLoadingState(true);
   %this-->skinsList.freeze(true);
   %this.clearSkins();
   
   skinsLoadAvailable();
}

function SkinsListWindow::setTimer(%this, %timer)
{
   if (%this.timerevent != 0)
   {
      cancel(%this.timerevent);
   }
   
   %this.timervalue = %timervalue + 1;
   if (%timervalue > 0)
   {
      %this.updateTimer();
   }
}

function SkinsListWindow::updateTimer()
{
   %timervalue = %this.timervalue - 1;
   %this.timervalue = %timervalue;
   if (%timervalue <= 0)
   {
      %this.loadSkins();
      return;
   }
   
   %timerstring = MakeTimerStringPretty(%timervalue);
   
   // TODO: Update tooltip
   
   %this.timerevent = %this.schedule(1000, "updateTimer");
}

function SkinsListWindow::finishedLoading(%this)
{
   %this-->skinsList.freeze(false);
   %this.setLoadingState(false);
}

function SkinsListWindow::openStore(%this)
{
   if ($cmYO)
   {
      openSteamStore();
   }
   else
   {
      openXsollaStore();
   }
}

// SkinsApplyWindow

function SkinsApplyWindow::addSkin(%this, %id, %icon, %header, %description, %canBuy)
{
   %skinsList = %this-->skinsList;
   %guiControl = createSkinsApplyElement(%id, %icon, %header, %description, %canBuy == 1);
   if ($cmYO)
   {
      %guiControl-->buyButton.command = "openSteamStore(" @ %id @ ");";
   }
   else
   {
      %guiControl-->buyButton.command = "openXsollaStore(" @ %id @ ");";
   }

   
   if (%skinsList.getCount() > 0)
   {
      %divider = createSkinsSelectDivider();
      %divider.internalName = "skinDivider" @ %id;
      %skinsList.add(%divider);
   }
   
   %skinsList.add(%guiControl);
}

function SkinsApplyWindow::removeSkin(%this, %id)
{
   %skinsList = %this-->skinsList;
   %guiControl = %skinsList.findObjectByInternalName("skinControl" @ %id);
   %divider = %skinsList.findObjectByInternalName("skinDivider" @ %id);
   
   if (%guiControl != 0)
   {
      %skinsList.remove(%guiControl);
   }
   
   if (%divider != 0)
   {
      %skinsList.remove(%divider);
   }
}

function SkinsApplyWindow::clearSkins(%this)
{
   %this-->skinsList.clear();
}

function SkinsApplyWindow::resetSkins(%this)
{
   SkinsReset();
   %this.safeDeleteObject();
}
