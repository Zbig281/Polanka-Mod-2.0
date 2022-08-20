//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//----------------------------------------------------------------------------- 

$HeraldryBackground1 = 13;
$HeraldryBackground2 = 16;
$HeraldryfillTypeIndex = 2;
$HeraldryChargeImageIndex[0] = 1;
$HeraldryChargePosition[0] = "TrueCenter";
$HeraldryChargeOn[0] = true;
$HeraldryChargeSize[0] = "Large";
$HeraldryChargeColor[0] = 1;
$HeraldryChargeImageIndex[1] = 1;
$HeraldryChargePosition[1] = "TrueCenter";
$HeraldryChargeOn[1] = false;
$HeraldryChargeSize[1] = "Large";
$HeraldryChargeColor[1] = 1;

function HeraldryWindow::onWake(%this)
{
	echo("HeraldryWindow::onWake");
	HeraldryWindow.applyHeraldryDialogCharge1($HeraldryChargeImageIndex[0], $HeraldryChargePosition[0], $HeraldryChargeSize[0], $HeraldryChargeColor[0], $HeraldryChargeOn[0]);
	HeraldryWindow.applyHeraldryDialogCharge2($HeraldryChargeImageIndex[1], $HeraldryChargePosition[1], $HeraldryChargeSize[1], $HeraldryChargeColor[1], $HeraldryChargeOn[1]);
	HeraldryWindow.applyHeraldryDialogBackground($HeraldryfillTypeIndex, $HeraldryBackground1, $HeraldryBackground2);
}

function HeraldryWindow::setBackground()
{
	echo("HeraldryWindow::setBackground() $HeraldryBackground1 = " @ $HeraldryBackground1 @ ", $HeraldryBackground2 = " @ $HeraldryBackground2 @ ", $HeraldryfillTypeIndex= " @ $HeraldryfillTypeIndex);

	%btn = HeraldryColor1Panel.findObjectByInternalName("BtnColor" @ $HeraldryBackground1);
	if (isObject(%btn) && %btn.getStateOn() == false)
	{
		%btn.setStateOn(true);
		onColorClick(%btn);
	}

	%btn = HeraldryColor2Panel.findObjectByInternalName("BtnColor" @ $HeraldryBackground2);
	if (isObject(%btn) && %btn.getStateOn() == false)
	{
		%btn.setStateOn(true);
		onColorClick(%btn);
	}

	%btn = HeraldryTabsPanel-->heraldryFillTypePanel.findObjectByInternalName(getHeraldryFillTypeName($HeraldryfillTypeIndex));
	if (isObject(%btn))
	{
		if (%btn.getStateOn() == false)
			%btn.setStateOn(true);
	}
	else
	{
		echo("HeraldryWindow::setBackground fillType not found active first btn");
		%f = HeraldryTabsPanel-->heraldryFillTypePanel.getObject(0);
		%f.performClick(); //инициируем клик чтобы записались новые данные
	}
}

function HeraldryWindow::setCharge(%this, %num)
{
	%btn = "heraldryBtnSymbol" @ %num + 1;
	if (%btn.getStateOn() == true)
	{
		%btn = HeraldryColor1Panel.findObjectByInternalName("BtnColor" @ $HeraldryChargeColor[%num]);
		if (isObject(%btn) && %btn.getStateOn() == false)
		{
			%btn.setStateOn(true);
			onColorClick(%btn);
		}

		%btnName = getHeraldrySymbolName($HeraldryChargeImageIndex[%num]);
		echo("HeraldryWindow::setCharge %btnName = " @ %btnName);

		%btn = HeraldryTabsPanel-->heraldrySymbolPanel.findObjectByInternalName(%btnName);
		if (isObject(%btn))
		{
			if (%btn.getStateOn() == false)
				%btn.setStateOn(true);
		}
		else
		{
			echo("HeraldryWindow::setCharge Symbol not found active first btn");
			%f = HeraldryTabsPanel-->heraldrySymbolPanel.getObject(0);
			%f.performClick(); //инициируем клик чтобы записались новые данные
		}

		%btnSize = "HeraldrySymbol" @ $HeraldryChargeSize[%num] @ "Btn";
		%btnSize.setStateOn(true);

		%btnPos = "Heraldry" @ $HeraldryChargePosition[%num] @ "PosBtn";
		%btnPos.setStateOn(true);
	}

	HeraldryOnOffSymbol1.setStateOn($HeraldryChargeOn[0]);
	HeraldryOnOffSymbol2.setStateOn($HeraldryChargeOn[1]);
}

function HeraldryWindow::ClickBtnColor(%this, %colorIndex, %pnlIndex)
{
	echo("HeraldryWindow::ClickBtnColor(" @ %colorIndex @ ", " @ %pnlIndex @ ");");

	if (heraldryBtnSymbol1.getStateOn())
	{
		$HeraldryChargeColor[0] = %colorIndex;
		HeraldryWindow.applyHeraldryDialogCharge1($HeraldryChargeImageIndex[0], $HeraldryChargePosition[0], $HeraldryChargeSize[0], $HeraldryChargeColor[0], $HeraldryChargeOn[0]);
	}
	else if (heraldryBtnSymbol2.getStateOn())
	{
		$HeraldryChargeColor[1] = %colorIndex;
		HeraldryWindow.applyHeraldryDialogCharge2($HeraldryChargeImageIndex[1], $HeraldryChargePosition[1], $HeraldryChargeSize[1], $HeraldryChargeColor[1], $HeraldryChargeOn[1]);
	}
	else if (heraldryBtnFillType.getStateOn())
	{
	
		if (%pnlIndex == 1)
			$HeraldryBackground1 = %colorIndex;
	
		if (%pnlIndex == 2)
			$HeraldryBackground2 = %colorIndex;
	
		HeraldryWindow.applyHeraldryDialogBackground($HeraldryfillTypeIndex, $HeraldryBackground1, $HeraldryBackground2);
	}
	HeraldryShowLog();
}

function HeraldryWindow::HeraldrySymbolSizeBtnClick(%this, %btnIndex)
{
	echo("HeraldryWindow::HeraldrySymbolSizeBtnClick(" @ %btnIndex @ ");");
	if (heraldryBtnSymbol1.getStateOn())
	{
		$HeraldryChargeSize[0] = %btnIndex;
		HeraldryWindow.applyHeraldryDialogCharge1($HeraldryChargeImageIndex[0], $HeraldryChargePosition[0], $HeraldryChargeSize[0], $HeraldryChargeColor[0], $HeraldryChargeOn[0]);
	}
	else if (heraldryBtnSymbol2.getStateOn())
	{
		$HeraldryChargeSize[1] = %btnIndex;
		HeraldryWindow.applyHeraldryDialogCharge2($HeraldryChargeImageIndex[1], $HeraldryChargePosition[1], $HeraldryChargeSize[1], $HeraldryChargeColor[1], $HeraldryChargeOn[1]);
	}
	HeraldryShowLog();
}

function HeraldryWindow::HeraldrySymbolPosBtnClick(%this, %btnIndex)
{
	echo("HeraldryWindow::HeraldrySymbolPosBtnClick(" @ %btnIndex @ ");");
	if (heraldryBtnSymbol1.getStateOn())
	{
		$HeraldryChargePosition[0] = %btnIndex;
		HeraldryWindow.applyHeraldryDialogCharge1($HeraldryChargeImageIndex[0], $HeraldryChargePosition[0], $HeraldryChargeSize[0], $HeraldryChargeColor[0], $HeraldryChargeOn[0]);
	}
	else if (heraldryBtnSymbol2.getStateOn())
	{
		$HeraldryChargePosition[1]= %btnIndex;
		HeraldryWindow.applyHeraldryDialogCharge2($HeraldryChargeImageIndex[1], $HeraldryChargePosition[1], $HeraldryChargeSize[1], $HeraldryChargeColor[1], $HeraldryChargeOn[1]);
	}
	HeraldryShowLog();
}

function HeraldryWindow::chooseSymbol(%this, %image)
{
	echo("HeraldryWindow::chooseSymbol(" @ %image @ ");");
	if (heraldryBtnSymbol1.getStateOn())
	{
		$HeraldryChargeImageIndex[0] = %image;
		HeraldryWindow.applyHeraldryDialogCharge1($HeraldryChargeImageIndex[0], $HeraldryChargePosition[0], $HeraldryChargeSize[0], $HeraldryChargeColor[0], $HeraldryChargeOn[0]);
	}
	else if (heraldryBtnSymbol2.getStateOn())
	{
		$HeraldryChargeImageIndex[1] = %image;
		HeraldryWindow.applyHeraldryDialogCharge2($HeraldryChargeImageIndex[1], $HeraldryChargePosition[1], $HeraldryChargeSize[1], $HeraldryChargeColor[1], $HeraldryChargeOn[1]);
	}
	HeraldryShowLog();
}

function HeraldryWindow::chooseFillType(%this, %fillTypeIndex)
{
	echo("HeraldryWindow::chooseFillType(" @ %fillTypeIndex @ ");");
	$HeraldryfillTypeIndex = %fillTypeIndex;
	HeraldryWindow.applyHeraldryDialogBackground($HeraldryfillTypeIndex, $HeraldryBackground1, $HeraldryBackground2);
	HeraldryShowLog();
}

function HeraldryWindow::HeraldryPreview(%this)
{
	echo("HeraldryWindow::HeraldryPreview()");
}

function HeraldryWindow::HeraldrySeting(%this)
{
	createHeraldrySettingDialog();
	Canvas.pushDialog(HeraldrySetingControl);
}

function HeraldryShowLog()
{
	echo("$HeraldryBackground1 = " @ $HeraldryBackground1);
	echo("$HeraldryBackground2 = " @ $HeraldryBackground2);
	echo("$HeraldryfillTypeIndex = " @ $HeraldryfillTypeIndex);
	echo("$HeraldryChargeImageIndex[0] = " @ $HeraldryChargeImageIndex[0]);
	echo("$HeraldryChargePosition[0] = " @ $HeraldryChargePosition[0]);
	echo("$HeraldryChargeSize[0] = " @ $HeraldryChargeSize[0]);
	echo("$HeraldryChargeColor[0] = " @ $HeraldryChargeColor[0]);
	echo("$HeraldryChargeImageIndex[1] = " @ $HeraldryChargeImageIndex[1]);
	echo("$HeraldryChargePosition[1] = " @ $HeraldryChargePosition[1]);
	echo("$HeraldryChargeSize[1] = " @ $HeraldryChargeSize[1]);
	echo("$HeraldryChargeColor[1] = " @ $HeraldryChargeColor[1]);
}

function HeraldryDialogSetBackground(%fillTypeIndex, %color1, %color2)
{
	echo("HeraldryDialogSetBackground(" @ %fillTypeIndex @ ", " @ %color1 @ ", " @ %color2 @ ");");

	$HeraldryBackground1 = %color1;
	$HeraldryBackground2 = %color2;
	$HeraldryfillTypeIndex = %fillTypeIndex;
	HeraldryWindow.setBackground();
}

function HeraldryDialogSetCharge(%num, %imageIndex, %position, %size, %color)
{
	echo("HeraldryDialogSetCharge(" @ %num @ ", " @ %imageIndex @ ", " @ %position @ ", " @ %size @ ", " @ %color @ ");");

	%isValid = true;
	if (%imageIndex == 0)
		%isValid = false;
	else
		$HeraldryChargeImageIndex[%num] = %imageIndex;

	if (%position $= "Absent")
		%isValid = false;
	else
		$HeraldryChargePosition[%num] = %position;

	if (%size $= "Zero")
		%isValid = false;
	else
		$HeraldryChargeSize[%num] = %size;

	if (%color == 0)
		%isValid = false;
	else
		$HeraldryChargeColor[%num] = %color;

	$HeraldryChargeOn[%num] = %isValid;
	HeraldryWindow.setCharge(%num);
}

function HeraldryOnOffSymbol1::onStateChanged(%this, %state)
{
	if ($HeraldryChargeOn[0] != %state)
	{
		$HeraldryChargeOn[0] = %state;
		HeraldryWindow.applyHeraldryDialogCharge1($HeraldryChargeImageIndex[0], $HeraldryChargePosition[0], $HeraldryChargeSize[0], $HeraldryChargeColor[0], $HeraldryChargeOn[0]);
	}

	if (%state)
	{
		%this.imageIndexMouseOver = "RadioButtonActiveMouseOver";
	}
	else
	{
		%this.imageIndexMouseOver = "CheckBoxRadioButtonMouseOver";
	}
}

function HeraldryOnOffSymbol2::onStateChanged(%this, %state)
{
	if ($HeraldryChargeOn[1] != %state)
	{
		$HeraldryChargeOn[1] = %state;
		HeraldryWindow.applyHeraldryDialogCharge2($HeraldryChargeImageIndex[1], $HeraldryChargePosition[1], $HeraldryChargeSize[1], $HeraldryChargeColor[1], $HeraldryChargeOn[1]);
	}

	if (%state)
	{
		%this.imageIndexMouseOver = "RadioButtonActiveMouseOver";
	}
	else
	{
		%this.imageIndexMouseOver = "CheckBoxRadioButtonMouseOver";
	}
}
