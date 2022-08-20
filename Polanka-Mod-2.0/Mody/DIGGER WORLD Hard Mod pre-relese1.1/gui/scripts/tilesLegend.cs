function createTilesLegendItem(%tileImageIndex, %tileDescrText)
{
   echo("createTilesLegendItem");
	%tile_legend_item = new GuiControl()
	{
		position = "0 0";
		extent = "100 15";
		profile = "GuiBaseTextProfile";
		visible = "1";
		active = "1";
		isContainer = "1";
		canHit = "false";
			
		new GuiBitmapCtrl()
		{
			position = "0 0";
			extent = "15 15";
			profile = "GuiTileLegendDescrProfile";
			visible = "1";
			active = "1";
			canHit = "false"; 
			imageIndex = %tileImageIndex;
			centered = "1";
			vertSizing = "center";
		};
		
		new GuiTextCtrl()
		{
			text = %tileDescrText;
			position = "22 0";
			extent = "100% 100%";
			profile = "GuiTileLegendDescrProfile";
			canHit = "false"; 
			visible = "1";
		};
	};
	
	return %tile_legend_item;
}
//-----------------------------------------------------------------------------
function createTileLegendItems(%stackCtrl)
{
	%stackCtrl.add(createTilesLegendItem(EmptyUnflattenedTilesIcon, GetMessageIDText(2163)));
	%stackCtrl.add(createTilesLegendItem(EmptyFlattenedTilesIcon, GetMessageIDText(2164)));
	%stackCtrl.add(createTilesLegendItem(BlockedTilesIcon, GetMessageIDText(2165)));
	%stackCtrl.add(createTilesLegendItem(AltitudeAboveTileIcon, GetMessageIDText(2166)));
}
//-----------------------------------------------------------------------------
function createClaimTileLegendItems(%stackCtrl)
{
	%stackCtrl.add(createTilesLegendItem(TileIconClaimRed, GetMessageIDText(2861)));       // "Blocked"));
	%stackCtrl.add(createTilesLegendItem(TileIconClaimWhite, GetMessageIDText(2862)));     // "Claimed"));
	%stackCtrl.add(createTilesLegendItem(TileIconClaimGray, GetMessageIDText(2863)));      // "Allowed"));
	%stackCtrl.add(createTilesLegendItem(TileIconClaimDarkGreen, GetMessageIDText(2864))); // "Selected"));
	%stackCtrl.add(createTilesLegendItem(TileIconClaimGreen, GetMessageIDText(2865)));     // "Started"));
}
//-----------------------------------------------------------------------------
