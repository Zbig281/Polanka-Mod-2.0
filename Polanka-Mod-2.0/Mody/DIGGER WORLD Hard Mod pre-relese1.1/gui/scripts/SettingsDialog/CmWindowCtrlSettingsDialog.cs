function CmWindowCtrlSettingsDialog::updateWindowSettings(%obj, %window)
{
   $Window = %window;

   CmWindowCtrlSettingsOpacity.value = $Window.opacity * 100;
   CmWindowCtrlSettingsOpacityText.setText(mFloor(CmWindowCtrlSettingsOpacity.value));
}
//------------------------------------------------------------------------

function CmWindowCtrlSettingsDialog::SaveXml()
{
   $Window.onSaveXml();
}
//------------------------------------------------------------------------

function CmWindowCtrlSettingsDialog::onClose()
{
   Canvas.popDialog(CmWindowCtrlSettingsDialog);
}
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------

//CmWindowCtrlSettingsOpacityText
function CmWindowCtrlSettingsOpacityText::UpdateText()
{
   CmWindowCtrlSettingsOpacity.value = CmWindowCtrlSettingsOpacityText.getText();
   CmWindowCtrlSettingsOpacityText.setText(mFloor(CmWindowCtrlSettingsOpacity.value));
   $Window.opacity = CmWindowCtrlSettingsOpacity.value * 0.01; 
}
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------

//CmWindowCtrlSettingsOpacity
function CmWindowCtrlSettingsOpacity::UpdateValue()
{
   CmWindowCtrlSettingsOpacityText.setText(mFloor(CmWindowCtrlSettingsOpacity.value));
   $Window.opacity = CmWindowCtrlSettingsOpacity.value * 0.01; 
}
//------------------------------------------------------------------------
//------------------------------------------------------------------------
//------------------------------------------------------------------------

//GuiWindowCtrl
function GuiWindowCtrl::onSettings(%obj)
{
   if (!isObject(CmWindowCtrlSettingsDialog))
      return;

   CmWindowCtrlSettingsDialog.updateWindowSettings(%obj);
   Canvas.pushDialog(CmWindowCtrlSettingsDialog);
}
//------------------------------------------------------------------------