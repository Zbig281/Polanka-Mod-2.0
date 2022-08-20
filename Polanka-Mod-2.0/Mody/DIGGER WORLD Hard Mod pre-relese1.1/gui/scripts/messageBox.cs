//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

if ( isObject( cmMessageIDBoxDlg ) )
   cmMessageIDBoxDlg.delete();
if ( isObject( cmCoreMessageBoxDlg ) )
   cmCoreMessageBoxDlg.delete();

createMessageIDBoxDlg("cmMessageIDBoxDlg");
createMessageIDBoxDlg("cmCoreMessageBoxDlg");

$dialogueMessageID = 0;

//---------------------------------------------------------------------------------------------
// messageCallback
// Calls a callback passed to a message box.
//---------------------------------------------------------------------------------------------
function messageCallback(%dlg, %callback)

{
   %dlg.cmMBFrame.cmMBTimer.stopTimer();

   //echo(">>>!!! messageCallback(" @ %dlg @ ", " @ %callback @ ")");
   Canvas.popDialog(%dlg);
   $dialogueMessageID = 0;
   eval(%callback);
}

//---------------------------------------------------------------------------------------------
// MBSetText
// Sets the text of a message box and resizes it to accomodate the new string.
//---------------------------------------------------------------------------------------------
function MBSetText(%text, %frame, %msg)
{
   // Get the extent of the text box.
   %ext = %text.getExtent();
   // Set the text in the center of the text box.
   %text.setText("<just:center>" @ %msg);
   // Force the textbox to resize itself vertically.
   %text.forceReflow();
   // Grab the new extent of the text box.
   %newExtent = %text.getExtent();

   // Get the vertical change in extent.
   %deltaY = getWord(%newExtent, 1) - getWord(%ext, 1);

   // Resize the window housing the text box.
   %windowPos = %frame.getPosition();
   %windowExt = %frame.getExtent();
   %frame.resize(getWord(%windowPos, 0), getWord(%windowPos, 1) - (%deltaY / 2),
                 getWord(%windowExt, 0), getWord(%windowExt, 1) + %deltaY);

   %frame.canMove = "0";
   //%frame.canClose = "0";
   %frame.resizeWidth = "0";
   %frame.resizeHeight = "0";
   %frame.canMinimize = "0";
   %frame.canMaximize = "0";
}
//---------------------------------------------------------------------------------------------
// Various message box display functions. Each one takes a window title, a message, and a
// callback for each button.
//---------------------------------------------------------------------------------------------
function MessageBoxOK(%title, %message, %callback)
{
   %okText = GetMessageIDText(1218); // OK
   MessageIDBoxDlg(cmCoreMessageBoxDlg, %title, %message, %callback, %okText, "", "", "", "", 0);
}

function MessageBoxOKCancel(%title, %message, %callback, %cancelCallback)
{
   %okText = GetMessageIDText(1218); // OK
   %cancelText = GetMessageIDText(1113); // Cancel
   MessageIDBoxDlg(cmCoreMessageBoxDlg, %title, %message, %callback, %okText, %cancelCallback, %cancelText, "", "", 0);
}

function MessageBoxOKCancelDlg::onSleep( %this )
{
   %this.callback = "";
}

function MessageBoxYesNo(%title, %message, %yesCallback, %noCallback)
{
   %yesText = GetMessageIDText(1111); // Yes
   %noText = GetMessageIDText(1112); // No
   MessageIDBoxDlg(cmCoreMessageBoxDlg, %title, %message, %yesCallback, %yesText, %noCallBack, %noText, "", "", 0);
}

function MessageBoxYesNoCancel(%title, %message, %yesCallback, %noCallback, %cancelCallback)
{
   %yesText = GetMessageIDText(1111); // Yes
   %noText = GetMessageIDText(1112); // No
   %cancelText = GetMessageIDText(1113); // Cancel
   MessageIDBoxDlg(cmCoreMessageBoxDlg, %title, %message, %yesCallback, %yesText, %noCallBack, %noText, cancelCallback, %cancelText, 0);
}

function MessageBoxYesNoDlg::onSleep( %this )
{
   %this.yesCallback = "";
   %this.noCallback = "";
}

function MBIDSetText(%text, %frame, %msg)
{
   // Get the extent of the text box.
   %ext = %text.getExtent();
   // Set the text in the center of the text box.
   %text.setText(%msg);
   // Force the textbox to resize itself vertically.
   %text.forceReflow();
   // Grab the new extent of the text box.
   %newExtent = %text.getExtent();

   // Get the vertical change in extent.
   %deltaY = getWord(%newExtent, 1) - getWord(%ext, 1);
}
//---------------------------------------------------------------------------------------------

function setBtnPos(%btn, %x)
{
   %btn_pos = %btn.getPosition();
   %btn.setPosition(%x, getWord(%btn_pos, 1));
}
//---------------------------------------------------------------------------------------------

function setBtnCenterXPos(%btn)
{
   %frame_extent_x = getWord(cmMessageIDBoxDlg.cmMBFrame.getExtent(), 0);
   %btn_width = getWord(%btn.getExtent(), 0);
   %btn_x = (%frame_extent_x - %btn_width) / 2;

   %btn_pos = %btn.getPosition();
   %btn.setPosition(%btn_x, getWord(%btn_pos, 1));
}
//---------------------------------------------------------------------------------------------

function CmMessageIDBox(%title, %message, %btnCallback, %btn1Caption, %btn2Caption, %btn3Caption, %closeBtnIndex, %timer)
{
   echo(">>>!!! CmMessageIDBox(" @ %title @ ", " @ %message @ ", " @ %btnCallback @ ", " @ %btn1Caption @ ", " @ %btn2Caption @ ", " @ %btn3Caption @ ", " @ %closeBtnIndex @ ", " @ ")");


   %btn1Callback = %btnCallback @ "(1);";
   %btn2Callback = %btnCallback @ "(2);";
   %btn3Callback = %btnCallback @ "(3);";

   if (%closeBtnIndex == 0)
   {
      cmMessageIDBoxDlg.closebtnCallback="";
   }
   else
   {
      cmMessageIDBoxDlg.closebtnCallback= %btnCallback @ "(" @ %closeBtnIndex @ ");";
   }

   MessageIDBoxDlg(cmMessageIDBoxDlg, %title, %message, %btn1Callback, %btn1Caption, %btn2Callback, %btn2Caption, %btn3Callback, %btn3Caption, %timer);
}
//---------------------------------------------------------------------------------------------

function CmMessageIDBoxClose()
{
   Canvas.popDialog(cmMessageIDBoxDlg);
}

function MessageIDBoxDlg(%dialog, %title, %message, %btn1Callback, %btn1Caption, %btn2Callback, %btn2Caption, %btn3Callback, %btn3Caption, %timer)
{
   %dialog.cmMBFrame.text = %title;
   %dialog.profile = "GuiOverlayAutoCursorProfile";
   Canvas.pushDialog(%dialog, 1); // layer > 0 чтобы не скрывалось при скрывании худа
   MBIDSetText(%dialog.cmMBFrame.cmMBText, %dialog.cmMBFrame, "<just:center>" @ %message);

   %visible_count = 0;
   %btn1_pos = 29 + 45;
   %delta_pos = 200;
   %btn2_pos = %btn1_pos + %delta_pos;
   %btn3_pos = %btn2_pos + %delta_pos;

   %dialog.cmMBFrame.setExtent("704 183");
   %center = %dialog.getCenter();
   %dialog.cmMBFrame.setCenter(%center.x, %center.y);
   %dialog.btn1CallBack = "";
   %dialog.btn2CallBack = "";
   %dialog.btn3CallBack = "";

   if(%btn1Caption $= "")
   {
      %dialog.cmMBFrame.cmMBIdBtn1.setVisible(false);
      %dialog.cmMBFrame.cmMBIdBtn1.setActive(false);
   }
   else
   {
      %dialog.cmMBFrame.cmMBIdBtn1.setVisible(true);
      %dialog.cmMBFrame.cmMBIdBtn1.setActive(true);
      %dialog.btn1CallBack = %btn1Callback;
      %dialog.cmMBFrame.cmMBIdBtn1.text = %btn1Caption;
      setBtnPos(%dialog.cmMBFrame.cmMBIdBtn1, %btn1_pos);
      %visible_count ++;
   }

   if(%btn2Caption $= "")
   {
      %dialog.cmMBFrame.cmMBIdBtn2.setVisible(false);
   }
   else
   {
      %dialog.cmMBFrame.cmMBIdBtn2.setVisible(true);
      %dialog.btn2CallBack = %btn2Callback;
      %dialog.cmMBFrame.cmMBIdBtn2.text = %btn2Caption;
      setBtnPos(%dialog.cmMBFrame.cmMBIdBtn2, %btn2_pos);
      %visible_count ++;
   }

   if(%btn3Caption $= "")
   {
      %dialog.cmMBFrame.cmMBIdBtn3.setVisible(false);
   }
   else
   {
      %dialog.cmMBFrame.cmMBIdBtn3.setVisible(true);
      %dialog.btn3CallBack = %btn3Callback;
      %dialog.cmMBFrame.cmMBIdBtn3.text = %btn3Caption;
      setBtnPos(%dialog.cmMBFrame.cmMBIdBtn3, %btn3_pos);
      %visible_count ++;
   }

   if (%btn1Caption $= "" && %btn2Caption $= "" && %btn3Caption $= "")
   {
      %dialog.cmMBFrame.cmMBIdBtn1.setVisible(true);
      %dialog.cmMBFrame.cmMBIdBtn1.setActive(true);
      %dialog.btn1CallBack = %btn1Callback;
      setBtnPos(%dialog.cmMBFrame.cmMBIdBtn1, %btn1_pos);
      %dialog.cmMBFrame.cmMBIdBtn1.text = "OK";
      %visible_count ++;
   }

   if (%visible_count == 1)
   {
      %frame_pos = %dialog.cmMBFrame.getPosition();
      %dialog.cmMBFrame.setPosition((%frame_pos.x + %delta_pos / 2), %frame_pos.y);

      %frame_ext = %dialog.cmMBFrame.getExtent();
      %dialog.cmMBFrame.setExtent(%frame_ext.x - %delta_pos, %frame_ext.y);

      if (%dialog.cmMBFrame.cmMBIdBtn1.isVisible() == true)
      {
         setBtnCenterXPos(%dialog.cmMBFrame.cmMBIdBtn1);
      }
      else if (%dialog.cmMBFrame.cmMBIdBtn2.isVisible() == true)
      {
         setBtnCenterXPos(%dialog.cmMBFrame.cmMBIdBtn2);
      }
      else if (%dialog.cmMBFrame.cmMBIdBtn3.isVisible() == true)
      {
         setBtnCenterXPos(%dialog.cmMBFrame.cmMBIdBtn3);
      }
   }
   else if (%visible_count == 2)
   {
      %btn_pos_x = %btn3_pos - %delta_pos;
      if (%dialog.cmMBFrame.cmMBIdBtn3.isVisible() == true)
      {
         setBtnPos(%dialog.cmMBFrame.cmMBIdBtn3, %btn_pos_x);
         %btn_pos_x = %btn_pos_x - %delta_pos;
      }

      if (%dialog.cmMBFrame.cmMBIdBtn2.isVisible() == true)
      {
         setBtnPos(%dialog.cmMBFrame.cmMBIdBtn2, %btn_pos_x);
         %btn_pos_x = %btn_pos_x - %delta_pos;
      }

      if (%dialog.cmMBFrame.cmMBIdBtn1.isVisible() == true)
      {
         setBtnPos(%dialog.cmMBFrame.cmMBIdBtn1, %btn_pos_x);
      }

      %frame_pos = %dialog.cmMBFrame.getPosition();
      %dialog.cmMBFrame.setPosition((%frame_pos.x + %delta_pos / 2), %frame_pos.y);

      %frame_ext = %dialog.cmMBFrame.getExtent();
      %dialog.cmMBFrame.setExtent(%frame_ext.x - %delta_pos, %frame_ext.y);
   }

   if (%dialog.closebtnCallback $= "")
   {
      if (%dialog.cmMBFrame.cmMBIdBtn3.isVisible() == true)
      {
         %dialog.closebtnCallback = "MessageCallback("@ %dialog @ "," @ %dialog @ ".btn3Callback);";
      }
      else if (%dialog.cmMBFrame.cmMBIdBtn2.isVisible() == true)
      {
         %dialog.closebtnCallback = "MessageCallback("@ %dialog @ "," @ %dialog @ ".btn2Callback);";
      }
      else if (%dialog.cmMBFrame.cmMBIdBtn1.isVisible() == true)
      {
         %dialog.closebtnCallback = "MessageCallback("@ %dialog @ "," @ %dialog @ ".btn1Callback);";
      }
   }

    //clear dialogue message id
    $dialogueMessageID = 0;

   if (%timer != 0)
   {
      %dialog.cmMBFrame.cmMBTimer.setVisible(true);
      %dialog.cmMBFrame.cmMBTimer.dialog = %dialog;
      %dialog.cmMBFrame.cmMBTimer.startTimer(%timer);
   }
   else
   {
      %dialog.cmMBFrame.cmMBTimer.setVisible(false);
   }

}

function CmSetDialogueMessageID(%messageID)
{
    //echo("!!!!!!!CmSetDialogueMessageID ID:" @ %messageID);
    $dialogueMessageID = %messageID;
}

function CmTerminateMessageDialogue(%messageIDToDelete)
{
    //echo("!!!!!!!CmTerminateMessageDialogue ID:" @ %messageIDToDelete);
    //echo("!!!!!!!CmTerminateMessageDialogue current ID:" @ $dialogueMessageID);
    //0 is a special value of invalid ID
    if ($dialogueMessageID == %messageIDToDelete && $dialogueMessageID != 0)
    {
        //echo("!!!!!!!CmTerminateMessageDialogue popping dialog.");
        Canvas.popDialog(cmMessageIDBoxDlg);
        $dialogueMessageID = 0;
    }
}

//----------------------------------------------------------

// When timer finishes, we should simulate clicking on default action
// (that will be our first button == btn1Callback)
function exitTimerCtrl::onTimerDone(%this)
{
	%dialog = %this.dialog;
	if (%dialog !$= "")
	{
		if (%dialog.btn1Callback !$= "")
		{
			messageCallback(%dialog,%dialog.btn1Callback);
		}
	}
}

function GuiTimerCtrl::onTimerDone(%this)
{
   // If you ever need to do anything special with your own implementation,
   // please override ::onTimerDone() method for object directly.
   // See implementation of exitTimeCtrl::onTimerDone(%this) as example.
}

//----------------------------------------------------------

function MessageBoxDlg::onResize(%this, %width, %maxY)
{
   %x = %this.Dialog.getExtent();

   %additionalY = 0;
   if(%this.Dialog.cmMBTimer.isVisible() == "1")
   {
      %additionalY = 15;
   }

   if (%maxY <= 31)
   {
      %x.y = 220 + %additionalY;
   }
   else
   {
      %d = %maxY - 31;
      %x.y = 220 + %d + %additionalY;
   }

   %this.Dialog.setExtent(%x.x, %x.y);
}

function MessageBoxDlg::onURL(%this, %url)
{
   %scheme = getWord(%url, 0);
   
   if (%scheme $= "xsolla")
   {
      %itemId = 0;
      if (getWordCount(%url) > 1)
      {
         %itemId = getWord(%url, 1);
      }
      openXsollaStore(%itemId);
   }
}


//---------------------------------------------------------------------------------------------
// "Old" message box function aliases for backwards-compatibility.
//---------------------------------------------------------------------------------------------

function MessageBoxOKOld( %title, %message, %callback )
{
   MessageBoxOK( %title, %message, %callback );
}
//----------------------------------------------------------
function MessageBoxOKCancelOld( %title, %message, %callback, %cancelCallback )
{
   MessageBoxOKCancel( %title, %message, %callback, %cancelCallback );
}
//----------------------------------------------------------
function MessageBoxYesNoOld( %title, %message, %yesCallback, %noCallback )
{
   MessageBoxYesNo( %title, %message, %yesCallback, %noCallback );
}
//----------------------------------------------------------
