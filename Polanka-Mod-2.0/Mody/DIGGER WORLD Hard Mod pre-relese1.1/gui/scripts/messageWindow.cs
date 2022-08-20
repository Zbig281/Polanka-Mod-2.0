//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------
function createMessageWindow(%pos, %ext, %saveFileName, %autoWidth, %msgCount, %msgTime)
{
   %horizSizing = "width";
   if (%autoWidth == true)
      %horizSizing = "right";

   %changeChildSizeToFit = true;
   if (%autoWidth == true)
      %changeChildSizeToFit = false;

   %wnd = new StackMessageWindow()
   {
      text = GetMessageIDText(1050); // Message
      resizeWidth = "1";
      resizeHeight = "0";
      canMove = "1";
      canClose = "1";
      canSetup = "1";
      canMinimize = "0";
      canMaximize = "0";
      canCollapse = "0";
      edgeSnap = "0";
      margin = "0 0 0 0";
      padding = "0 0 0 0";
      anchorTop = "1";
      anchorBottom = "0";
      anchorLeft = "1";
      anchorRight = "0";
      position = %pos;
      extent = %ext;
      minExtent = "300 150";
      horizSizing = "right";
      vertSizing = "bottom";
      profile = "GuiSmallWindowProfile";
      visible = "1";
      active = "1";
      isContainer = "1";
      canSave = "0";
      canSaveDynamicFields = "0";
      closeCommand ="";
      canHideOnFreelook = "1";
      forGuiEdit = "1";
      msgCount = %msgCount;
      msgTimeOut = %msgTime;
      autoHeight = true;
      autoWidth = %autoWidth;
      saveFileName = %saveFileName;
      timeShowAnim = 600;

      new GuiContainer()
      {
         docking = Client;
         extent = "350 400";
         canSaveDynamicFields = "0";
         Enabled = "1";
         Profile = "GuiBaseTextProfile";
         canSave = "1";
         Visible = "1";
         canHit = "true";

         new GuiStackControl()
         {
            position = "0 0";
            extent = "350 400";
            minExtent = "8 8";
            horizSizing = %horizSizing;
            profile = "GuiBaseTextProfile";
            changeChildSizeToFit = %changeChildSizeToFit;
            dynamicNonStackExtent = %autoWidth;
            padding = 1;
            internalName = "msgPnl";
            vertStacking = "Bottom to Top";
         };
      };
   };//GuiWindowCtrl

   %pnl = %wnd.findObjectByInternalName("msgPnl", true);
   %wnd.msgPnl = %pnl;

   return %wnd;
}
//----------------------------------------------------------

function addMsgInfoWindow(%text, %important, %type, %infoHint)
{
   if (%important == 2)
      addMsgStackInfoWindow(%text, %type, %infoHint);
   else if (%important == 3)
      addEventMsgInfoWindow(%text, %type);
}
//----------------------------------------------------------

function msgStackInfoWindowDefaultProperty()
{
   if (isObject(MsgStackInfoWindow))
   {
      MsgStackInfoWindow.position = "50 50";
      MsgStackInfoWindow.Extent = "360 400";
      MsgStackInfoWindow.locked = true;
      MsgStackInfoWindow.opacity = 1;
      MsgStackInfoWindow.msgCount = 6;
      MsgStackInfoWindow.msgTimeOut = 5000;
   }
}
//----------------------------------------------------------

function createMsgStackInfoWindow()
{
   if (!isObject(MsgStackInfoWindow))
   {
      %wnd = createMessageWindow("50 50", "360 400", "MsgStackInfo", false, 6, 5000);
      %wnd.setName("MsgStackInfoWindow");
      msgStackInfoWindowDefaultProperty();
      PlayGui.add(%wnd);
   }
}

//----------------------------------------------------------
//important="2" message
function addMsgStackInfoWindow(%text, %type, %infoHint)
{
	createMsgStackInfoWindow();

	%pnl = MsgStackInfoWindow.msgPnl;
	if (!isObject(%pnl))
		return;

	%show_icon = false;

	if (MsgStackInfoWindow.isCanAdd() == false)
	{
		if (MsgStackInfoWindow.isLogQueue())
		{
			error("skip msg: " @ %text);
		}
		return;
	}


	%bitmap = "";
	if (%type $= "char")
		%bitmap = "gui/images/message/torso.png";
	else if (%type $= "inv")
		%bitmap = "gui/images/message/bag.png";
	else if (%type $= "map")
		%bitmap = "gui/images/message/forest.png";

	//background
	%gui = new GuiStackControl()
	{
		position = "0 0";
		extent = "300 20";
		minExtent = "8 8";
		changeChildSizeToFit = false;
		dynamicNonStackExtent = true;
		dynamicSize = true;
		padding = 0;
		stackingType = "Vertical";

		profile = GuiAtlas3TiledImageProfile;
		BackgroundIndex = LearningWindowBackground;

		new GuiStackControl()
		{
			position = "0 0";
			extent = "100% 20";
			minExtent = "8 8";
			changeChildSizeToFit = false;
			dynamicNonStackExtent = true;
			dynamicSize = true;
			padding = 0;
			stackingType = "Horizontal";
			command = "MsgStackCommand($ThisControl);";
			internalName = "stack";
			msgType = %type;
			msgInfoHint = %infoHint;

			profile = GuiAtlas1TiledImageProfile;
			LeftIndex0 = FringeLeftShadow;
			RightIndex0 = FringeRightShadow;
			TopIndex0 = FringeTopShadow;
			BottomIndex0 = FringeBottomShadow;
			TopLeftIndex = FringeTLAngleShadow;
			TopRightIndex = FringeTRAngleShadow;
			BottomRightIndex = FringeBRAngleShadow;
			BottomLeftIndex = FringeBLAngleShadow;
		};
	};

	//скрываем иконки пока они не отрисованы
	if (%show_icon)
	{
		%icon_ctrl = new GuiBitmapCtrl() 
		{
			position = "0 0";
			extent = "66 45";
			canHit = "false";
			visible = "true";
			centered = "true";
			profile = "GuiBaseTextProfile";
			bitmap = %bitmap;
		};
		%gui-->stack.add(%icon_ctrl);
	}
	else
	{
		%gui-->stack.LeftIndent = 20;
	}

	%ml_text = new GuiMLTextCtrl() 
	{
		position = "0 0";
		extent = "194 45";
		horizSizing = "width";
		profile = "GuiMLMessageTextProfile";
		canHit = "false";
		text = %text;
		rightOffset = 0;
		class = "MessageDlg";
	}; 
	%gui-->stack.add(%ml_text);

	if (%show_icon == false)
	{
		%ml_text.setExtent(240, 45);
	}

	if (%type $= "hint" && %infoHint !$= "")
	{
		// add F1 icon to msg
		
		%help_icon = new GuiControl()
		{
			extent = "35 45";
			canSaveDynamicFields = "0";
			Enabled = "1";
			Profile = "GuiBaseTextProfile";
			canSave = "1";
			Visible = "1";
			canHit = "false";

			new GuiBitmapCtrl() 
			{
				position = "0 0";
				extent = "29 29";
				canHit = "false";
				visible = "true";
				centered = "true";
				profile = "GuiAtlas3ImageProfile";
				imageIndex = InfoBtnNormal;
				vertSizing = "center";
			};
		};

		%gui-->stack.add(%help_icon);
		%ml_text.additionalIcon = %help_icon;

		%mlExtent = %ml_text.getExtent();
		%ml_text.setExtent(%mlExtent.x - %help_icon.extent.x, %mlExtent.y);
	}

	%btn_ctrl = new GuiControl()
	{
		extent = "40 45";
		canSaveDynamicFields = "0";
		Enabled = "1";
		Profile = "GuiBaseTextProfile";
		canSave = "1";
		Visible = "1";
		canHit = "true";

		new GuiBitmapButtonCtrl()
		{
			extent = "19 19";
			position = "9 0";
			vertSizing = "center";
			command = MsgStackInfoWindow @ ".closeMsg(" @ %gui @ ");";
			profile = GuiAtlas3ImageProfile;
			imageIndex = Cross;
		};
	};
	%gui-->stack.add(%btn_ctrl);

	%ml_text.btnCtrl = %btn_ctrl;
	//%ml_text.iconCtrl = %icon_ctrl;
	%ml_text.wnd = MsgStackInfoWindow;
	%ml_text.pnl = %pnl;
	%ml_text.line = %gui;

	%gui.dynamicSize = true;
	%gui.setVisible(false);
	%pnl.add(%gui);
	MsgStackInfoWindow.addQueue(%gui);
}
//----------------------------------------------------------

function MsgStackCommand(%ctrl)
{
   if (%ctrl.msgType $= "char")
   {
      showCharWindow(true);
   }
   else if (%ctrl.msgType $= "inv")
   {
      showInventoryWnd();
   }
   else if (%ctrl.msgType $= "skill")
   {
      showSkill(true);
   }
   else if (%ctrl.msgType $= "equip")
   {
      //ShowEquipmentWnd();
   }
   else if (%ctrl.msgType $= "hint")
   {
      if (%ctrl.msgInfoHint !$= "")
      {
         showTutorialInfoHint(%ctrl.msgInfoHint);
      }
   }

}
//-----------------------------------------------------------------------------

function StackMessageWindow::onNextAnimate(%this, %ctrl)
{
   %ctrl.opacity = 0.01;
   %ctrl.setVisible(true);
   %this.msgPnl.setPosition(0, 0);
   %ctrl_pos = %ctrl.getPosition();

   %this.setAnimatePos(%ctrl_pos.y);
}
//-----------------------------------------------------------------------------

function StackMessageWindow::onStopAnimate(%this)
{
   %this.msgPnl.setPosition(0, 0);
   %this.setAnimatePos(0);
}
//-----------------------------------------------------------------------------

function StackMessageWindow::setAnimatePos(%this, %maxY)
{
   %wnd_pos = %this.getPosition();
   %wnd_ext = %this.getExtent();

   %delta_y = %maxY - %this.getAnimateHeight();

   %this.setAnimateHeight(%maxY);
   %this.setPosition(%wnd_pos.x, %wnd_pos.y - %delta_y);
   %this.setExtent(%wnd_ext.x, %wnd_ext.y + %delta_y);
}
//-----------------------------------------------------------------------------

function MessageDlg::onResize(%this, %width, %maxY)
{
   %x = %this.btnCtrl.getExtent();
   %this.btnCtrl.setExtent(%x.x, %maxY);

	if (isObject(%this.additionalIcon))
	{
		%additionalIconExtent = %this.additionalIcon.getExtent();
		%this.additionalIcon.setExtent(%additionalIconExtent.x, %maxY);
	}

   %this.wnd.autoResize(%this.pnl);
	
   if (%this.line == %this.wnd.getCurShowCtrl())
	{
      %this.wnd.setAnimatePos(%maxY);
	}
}
//-----------------------------------------------------------------------------

function msgEventWindowDefaultProperty()
{
   if (isObject(MsgEventWindow))
   {
      MsgEventWindow.position = "70% 50";
      MsgEventWindow.Extent = "454 400";
      MsgEventWindow.locked = true;
      MsgEventWindow.opacity = 1;
      MsgEventWindow.msgCount = 1;
      MsgStackInfoWindow.msgTimeOut = 20000;
   }
}
//----------------------------------------------------------

function createMsgEventWindow()
{
   if (!isObject(MsgEventWindow))
   {
      %wnd = createMessageWindow("70% 50", "454 400", "MsgLoreEvent", true, 1, 20000);
      %wnd.setName("MsgEventWindow");
      msgEventWindowDefaultProperty();
      PlayGui.add(%wnd);
   }
}
//----------------------------------------------------------
//important="3" message
function addEventMsgInfoWindow(%text, %type)
{
   createMsgEventWindow();

   %pnl = MsgEventWindow.msgPnl;
   if (isObject(%pnl))
   {
      %gui = new GuiStackControl()
      {
         position = "0 0";
         extent = "438 200";
         minExtent = "8 8";
         profile = "GuiCmChatWindowTransPanelProfile";
         changeChildSizeToFit = false;
         dynamicNonStackExtent = true;
         changeChildPosition = false;
         dynamicSize = true;
         padding = 0;

         new GuiBitmapCtrl() 
         {
            position = "0 0";
            extent = "438 129";
            canHit = "false";
            visible = "true";
            centered = "true";
            profile = "GuiBaseTextProfile";
            bitmap = %type;
         };
      };

      %h_stck = new GuiStackControl()
      {
         position = "33 0";
         extent = "405 71";
         minExtent = "8 8";
         profile = "GuiBaseTextProfile";
         changeChildSizeToFit = false;
         dynamicNonStackExtent = true;
         dynamicSize = true;
         padding = 0;
         stackingType = "Horizontal";
      };
      %gui.add(%h_stck);

      %ml_text = new GuiMLTextCtrl() 
      {
         position = "0 0";
         extent = "353 71";
         profile = "GuiLoreMLMessageTextProfile";
         canHit = "false";
         text = %text;
         rightOffset = 0;
         bottomOffset = 27;
         class = "MessageDlg";
      }; 
      %h_stck.add(%ml_text);

      %btn_ctrl = new GuiControl()
      {
         extent = "52 45";
         canSaveDynamicFields = "0";
         Enabled = "1";
         Profile = "GuiBaseTextProfile";
         canSave = "1";
         Visible = "1";
         canHit = "true";

         new GuiBitmapButtonCtrl()
         {
            extent = "19 19";
            position = "9 0";
            vertSizing = "center";
            command = %gui @ ".safeDeleteObject();";
            profile = GuiAtlas3ImageProfile;
            imageIndex = Cross;
         };
      };
      %h_stck.add(%btn_ctrl);

      %ml_text.btnCtrl = %btn_ctrl;
      %ml_text.wnd = MsgEventWindow;
      %ml_text.pnl = %pnl;
      %ml_text.line = %gui;

      %gui.setVisible(false);
      %pnl.add(%gui);
      MsgEventWindow.addQueue(%gui);
   }
}
//-----------------------------------------------------------------------------

function testStackMsg(%count)
{
	for(%i = 0; %i < %count; %i++)
	{
		cmShowMessage(10);
	}
}
