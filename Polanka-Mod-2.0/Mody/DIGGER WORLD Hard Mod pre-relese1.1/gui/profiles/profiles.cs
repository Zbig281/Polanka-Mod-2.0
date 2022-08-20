//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

$GlobalTextFontName = "Open Sans";
$GlobalTextBoldFontName = "Open Sans Bold";
$GlobalCaptionFontName = "PT Serif Bold";
$GlobalTextItalicFontName = "Open Sans Italic";
//-----------------------------------------------------------------------------

singleton GuiControlProfile (GuiBaseTextProfile)
{
	tab = false;
	canKeyFocus = false;
	hasBitmapArray = false;
	mouseOverSelected = false;

	// fill color
	opaque = false;
	fillColorSEL = "255 255 255 0";
	fillColorNA = "255 255 255 0";
	fillColorHL = "64 64 64 125";
	fillColor = "64 64 64 125";

	// border color
	border = "none";
	borderColor	= "255 255 255";
	borderColorHL = "255 255 255";
	borderColorNA = "255 255 255";

	// font
	fontType = $GlobalTextFontName;
	fontSize = 14;
	fontCharset = ANSI;

	//fontColor
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	fontColorNA = "255 255 255";
	fontColorSEL = "64 64 64 125";

	// bitmap information
	bitmap = "";
	bitmapBase = "";
	textOffset = "0 0";

	// used by guiTextControl
	modal = true;
	justify = "left";
	autoSizeWidth = false;
	autoSizeHeight = false;
	returnTab = false;
	numbersOnly = false;
	cursorColor = "0 0 0 255";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiBaseTextBoldProfile : GuiBaseTextProfile)
{
	fontType = $GlobalTextBoldFontName;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiBaseCaptionProfile : GuiBaseTextProfile)
{
	// font
	fontType = $GlobalCaptionFontName;
	fontSize = 14;
	fontCharset = ANSI;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiChatTabBookProfile : GuiBaseTextProfile)
{
	border = "none";
	globalImageIndex = "chat";
	fontColor = "233 233 233";
	fontColorHL = "255 255 255";
	fontColorNA = "50 50 50";
	fontColorSEL = "178 128 28";
	fillColor = "255 0 0";
	fontSize = 18;
	textOffset = "6 2";
	tab = false;
	cankeyfocus = true;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiScrollProfile : GuiBaseTextProfile)
{
	opaque = true;
	fillcolor = "255 255 255";
	fontColor = "0 0 0";
	fontColorHL = "150 150 150";
	border = "none";
	bitmap = "art/gui/images/scrollBar";
	hasBitmapArray = true;
	category = "Core";
};

singleton GuiControlProfile( GuiAtlas1ImageProfile : GuiBaseTextProfile ) {
   globalImageIndex = "atlas1";
};
singleton GuiControlProfile( GuiAtlas2ImageProfile : GuiBaseTextProfile ) {
   globalImageIndex = "atlas2";
};
singleton GuiControlProfile( GuiAtlas3ImageProfile : GuiBaseTextProfile ) {
   globalImageIndex = "atlas3";
};
singleton GuiControlProfile( GuiAtlas1TiledImageProfile : GuiAtlas1ImageProfile ) {
   border = "all_tiling";
};
singleton GuiControlProfile( GuiAtlas2TiledImageProfile : GuiAtlas2ImageProfile ) {
   border = "all_tiling";
};
singleton GuiControlProfile( GuiAtlas3TiledImageProfile : GuiAtlas3ImageProfile ) {
   border = "all_tiling";
};

singleton GuiControlProfile(GuiEagleScrollBarProfile : GuiScrollProfile) {
	globalImageIndex = "eagleScrollBar";
	border = "none";
	opaque = false;
	borderThickness = 0;
};

singleton GuiControlProfile(GuiHorizSliderProfile : GuiBaseTextProfile) {
	globalImageIndex = "horizSlider";
};

singleton GuiControlProfile(GuiPopUpScrollBarProfile : GuiScrollProfile) {
	globalImageIndex = "popUpScroll";
	border = "none";
	opaque = false;
	borderThickness = 0;
};

//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiCmChatWindowScrollProfile : GuiScrollProfile)
{
	globalImageIndex = "chat";
	border = "none";
	opaque = false;
	borderThickness = 0;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiCmChatWindowTransPanelProfile : GuiBaseTextProfile)
{
	fillColor = "28 28 28";
	fillColorHL = "28 28 28";
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	border = "all_tiling";
	globalImageIndex = "chat";
	hasBitmapArray = true;
};

singleton GuiControlProfile(GuiCmMessageWindowProfile : GuiCmChatWindowTransPanelProfile)
{
	autoCursorMode = true;
};

singleton GuiControlProfile(GuiTabBookProfile : GuiBaseTextProfile)
{
	opaque = false;
	fillColor = "59 47 34";
	fillColorHL = "100 100 100";
	fillColorNA = "150 150 150";
	fontColor = "129 129 129";
	fontColorHL = "255 255 255";
	fontColorNA = "50 50 50";
	fontSize = 16;
	globalImageIndex = "chat";
	border = "none";
	textOffset = "6 2";
	tab = false;
	cankeyfocus = true;
	category = "Core";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(HotBarTabBookProfile : GuiTabBookProfile)
{
	opaque = "false";
	border = "none";
	globalImageIndex = "hotbar";
	textOffset = "0 0";
	justify = "center";
};

singleton GuiControlProfile(HotBarCellTextCountProfile: GuiBaseTextProfile)
{
	fontColor = "178 128 28";
	fontSize = 17;
	textOffset = "0 0";
	justify = "center";
	globalImageIndex = "hotbar";
	border = "all_tiling";
	autoSizeWidth = true;
	autoSizeHeight = false;
};

singleton GuiControlProfile(HotBarCellTextProfile : GuiBaseTextProfile)
{
	fontColor = "102 102 102";
	fontSize = 16;
	textOffset = "0 0";
	justify = "center";
	shadowText = "0";
	shadowColor = "0 0 0";
};

singleton GuiControlProfile(HotBarCellImageProfile : GuiBaseTextProfile)
{
	globalImageIndex = "hotbar";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(HotBarCellButtonProfile : GuiBaseTextProfile)
{
	opaque = false;
	fixedExtent = true;
	justify = "center";
};

singleton GuiControlProfile(PlayersListNameProfile : GuiBaseTextProfile)
{
	fontColor = "203 203 203";
	fontColorNA = "203 203 203";
	fontSize = 24;
	textOffset = "0 0";
	justify = "left";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(PlayersListTitleProfile : GuiBaseTextProfile)
{
	fontType = $GlobalCaptionFontName;
	fontColor = "171 159 111";
	fontSize = 32;
	textOffset = "0 0";
	justify = "center";
	globalImageIndex = "players_list";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiModelessDialogProfile : GuiBaseTextProfile)
{
	modal = false;
	category = "Core";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiCursorModelessDialogProfile : GuiModelessDialogProfile)
{
	autoCursorMode = true;
};

singleton GuiControlProfile(GuiWindowProfile : GuiBaseCaptionProfile)
{
	opaque = false;
	fillColor = "39 30 17";
	fillColorHL = "221 221 221";
	fillColorNA = "200 200 200";
	fontSize = "27";
	textOffset = "15 8";
	fontColor = "255 255 255";
	fontColorHL = "0 0 0";
	bevelColorHL = "255 255 255";
	bevelColorLL = "0 0 0";
	justify = "left";
	category = "Core";
	border = "all_tiling";
	globalImageIndex = "window";
};

singleton GuiControlProfile(GuiSmallWindowProfile : GuiBaseCaptionProfile)
{
	opaque = false;
	border = "all_tiling";
	globalImageIndex = "small_window";
	fontSize = "20";
	textOffset = "15 0";
	fontColor = "255 255 255";
	fontColorHL = "0 0 0";
	bevelColorHL = "255 255 255";
	bevelColorLL = "0 0 0";
};

singleton GuiControlProfile(GuiAutoCursorWindowProfile : GuiWindowProfile)
{
	autoCursorMode = true;
};

singleton GuiControlProfile(GuiCursorEscWindowProfile : GuiWindowProfile)
{
	autoCursorMode = true;
	canEscCloseOnPlayGui = true;
};

singleton GuiControlProfile(GuiTabPageProfile : GuiBaseTextProfile)
{
	fontSize = 12;
	justify = "center";
	globalImageIndex = "chat";
	border = "none";
	fillColor = "59 47 34";
	fontColor = "255 255 255";
	category = "Core";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiCmChatSplitContainer : GuiBaseTextProfile)
{
	hasBitmapArray = true;
	globalImageIndex = "chat";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiListBoxProfile : GuiBaseTextProfile)
{
	canKeyFocus = true;
	fontColorSEL = "255 255 255";
	fillColorSEL = "45 45 45";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiButtonBitmapProfile : GuiBaseTextProfile)
{
	globalImageIndex = "chat";
	hasBitmapArray = true;
};

singleton GuiControlProfile(GuiMapCtrlProfile: GuiBaseTextProfile)
{
	opaque = false;
	fontSize = "22";
	textOffset = "-13 6";
	justify = "right";
	fontColor = "196 196 196";
	globalImageIndex = "map";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(ChatTextEditProfile : GuiBaseTextProfile)
{
	globalImageIndex = "chat";
	border = "all_tiling";
	cursorColor = "196 196 196";
	canKeyFocus = true;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiHLineChatProfile : GuiBaseTextProfile)
{
	 globalImageIndex = "chat";
	 border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiBarProfile : GuiBaseTextProfile)
{
	globalImageIndex = "bar";
	border = "none";
	fontSize = "35";
};

singleton GuiControlProfile(GuiSkillStatImageProfile: GuiBaseTextProfile)
{
	globalImageIndex = "skill_stat";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillBackgroundProfile: GuiBaseTextProfile)
{
	opaque = "1";
	fillColor = "13 13 12";
	border = "rect1_color";
	borderColor = "13 13 12";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiGrayTextureProfile : GuiBaseTextProfile)
{
	globalImageIndex = "chat";
	border = "only_background_tiling";
	opaque = false;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiNotModalGrayTextureProfile : GuiGrayTextureProfile)
{
	modal = false;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiBorderGrayTextureProfile : GuiBaseTextProfile)
{
	 globalImageIndex = "chat";
	 border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillStatNameProfile: GuiBaseCaptionProfile)
{
	fontSize = 27;
	fontColor = "159 137 109";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillStatTopBtnProfile: GuiBaseCaptionProfile)
{
	fontSize = 27;
	fontColor = "115 100 79";
	fontColorHL = "173 148 117";
	fontColorSEL = "173 148 117";
	globalImageIndex = "skill_stat";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillStatBtnSkilsProfile: GuiBaseTextProfile)
{
	fontSize = 22;
	fontColor = "115 100 79";
	fontColorHL = "190 164 127";
	fontColorSEL = "190 164 127";
	globalImageIndex = "skill_stat";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillStatLabelTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "109 95 77";
	justify = "right";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiText7pxProfile: GuiBaseTextProfile)
{
	fontSize = 18;
	fontColor = "159 137 109";
	fontColorNA = "159 137 109";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiText9pxProfile: GuiText7pxProfile)
{
	fontSize = 22;
	globalImageIndex = "skill_stat";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillStatValProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "159 155 109";
	justify = "right";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiScrollSkillInfoProfile : GuiScrollProfile)
{
	globalImageIndex = "skill_stat";
	border = "none";
	opaque = false;
	borderThickness = 0;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTextProfile : GuiBaseTextProfile)
{
	fontSize = 24;
	fontColor = "188 163 130";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTextEditBarProfile : GuiBaseTextProfile)
{
	fontSize = 26;
	fontColor = "188 163 130";
	canKeyFocus = true;
};

singleton GuiControlProfile(GuiCrosshairProfile : GuiBaseTextProfile)
{
	globalImageIndex = "cross_hair";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMoveIndicatorImageProfile : GuiBaseTextProfile)
{
	globalImageIndex = "moveIndicator";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiPopUpBorder : GuiBaseTextProfile)
{
	globalImageIndex = "popUpPanel";
	opaque = true;
	fillColor = "0 0 0";
	border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiDarkGreyProfile: GuiBaseTextProfile)
{
	globalImageIndex = "dark_grey";
	border = "only_background_tiling";
	opaque = false;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillPopUpTextListProfile: GuiText9pxProfile)
{
	textOffset = "19 12";
	fontColor = "159 137 109";
	fontColorNA = "159 137 109";
	fontColorHL = "159 137 109";
	fontColorSEL = "159 137 109";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillPopUpProfile: GuiText9pxProfile)
{
	profileForChildren = GuiSkillPopUpTextListProfile;
	textOffset = "43 0";
	fontColor = "203 203 203";
	fontColorNA = "159 137 109";
	fontColorHL = "159 137 109";
	fontColorSEL = "159 137 109";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateCharWindowPopUpTextListProfile: GuiBaseTextProfile)
{
	globalImageIndex = "popUpCtrl";
	textOffset = "9 10";
	fontSize = 24;
	fontColor = "204 204 204";
	fontColorNA = "204 204 204";
	fontColorHL = "204 204 204";
	fontColorSEL = "204 204 204";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateCharWindowPopUpProfile: GuiSkillPopUpProfile)
{
	profileForChildren = CreateCharWindowPopUpTextListProfile;
	textOffset = "32 -2";
	globalImageIndex = "popUpCtrl";
	border = "all_tiling";
	fontSize = 24;
	fontColor = "204 204 204";
	fontColorNA = "102 102 102";
	fontColorHL = "204 204 204";
	fontColorSEL = "204 204 204";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowPopUpProfile: GuiSkillPopUpProfile)
{
	textOffset = "32 0";
	globalImageIndex = "popUpCtrl";
	border = "all_tiling";
	fontSize = 22;
	fontColor = "170 147 116";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(optionsPopUpProfile : GuiSkillPopUpProfile)
{
	textOffset = "32 0";
	globalImageIndex = "popUpCtrl";
	border = "all_tiling";
	fontSize = 24;
	fontColor = "203 203 203";
	fontColorNA = "65 64 64";
};

//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillInfoLvlLabelProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "31 31 31";
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSkillInfoLabelProfile: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "77 77 77";
};

singleton GuiControlProfile(SelectionListSkillNameProfile: GuiBaseCaptionProfile)
{
	border = "none";
	justify = "left";
	fontSize = 26;
	textOffset = "11 0";
	fontColor = "190 163 126";
};
//----------------------------------------------------------

singleton GuiControlProfile(CraftBtnProfile: SelectionListBaseProfile)
{
	justify = "center";
	fontSize = 26;
	fontColor = "170 147 116";
	fontColorNA = "65 64 64";
};
//----------------------------------------------------------

singleton GuiControlProfile(GuiShapeNameImageProfile : GuiBaseTextProfile)
{
	globalImageIndex = "shape_info";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiAlchemyImageProfile: GuiBaseTextProfile)
{
	globalImageIndex = "alchemy";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiEffectImageProfile: GuiBaseTextProfile)
{
	globalImageIndex = "effect";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSmeltingButtonProfile: GuiBaseTextProfile)
{
	globalImageIndex = "furnace";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTextBigProfile : GuiBaseCaptionProfile)
{
	fontSize = 29;
	fontColor = "188 163 130";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(EquipmentBaseProfile: GuiBaseTextProfile)
{
	globalImageIndex = "equipment";
	border = "none";
};

singleton GuiControlProfile(EquipmentDoubleValProfile: GuiBaseTextProfile)
{
	fontSize = 17;
	fontColor = "159 137 109";
	fontColorNA = "159 137 109";  //Второе значение
	fontColorSEL = "159 137 109"; //Первое значение
	fontColorHL = "159 137 109";  //Разделитель
	globalImageIndex = "skill_stat";
	justify = "right";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiComboImageProfile : GuiAtlas3ImageProfile)
{
	//globalImageIndex = "comboIndicator";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CraftBaseProfile: GuiBaseTextProfile)
{
	border = "none";
};

singleton GuiControlProfile(GuiItemRecipeTextProfile: GuiText9pxProfile)
{
	fontSize = 20;
};

singleton GuiControlProfile(CraftDoubleValProfile: EquipmentDoubleValProfile)
{
	fontSize = 22;
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CraftResourcesTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "133 121 106";
	fontColorNA = "133 121 106";
	justify = "center";
};
//-----------------------------------------------------------------------------
singleton GuiControlProfile(CraftBlueprintsSwitchTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "72 132 133";
	fontColorNA = "72 132 133";
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(SplitStackItemTextNameProfile: GuiBaseTextProfile)
{
	justify = "center";
	fontSize = 21;
	fontColor = "203 203 203";
	border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(SplitStackItemRadiusTextProfile: GuiBaseTextProfile)
{
	justify = "left";
	fontSize = 18;
	fontColor = "153 153 153";
	border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(NumericTextEditSliderProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	justify = "center";
	fontColor = "255 255 255";
	border = "none";
	numbersOnly = true;
	canKeyFocus = true;
};

singleton GuiControlProfile(ItemContainerCtrlProfile: GuiBaseTextProfile)
{
	border = "all_tiling";
	globalImageIndex = "item_container";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(ItemContainerBackgroundCtrlProfile: GuiBaseTextProfile)
{
	border = "only_background_tiling";
	globalImageIndex = "item_container";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowImageProfile: GuiBaseTextProfile)
{
	globalImageIndex = "mainMenuWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuTextSmallProfile: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "155 125 90";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuStartupVideoProfile: GuiBaseTextProfile)
{
	canKeyFocus = true;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMLMessageTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "153 153 153";
	textOffset = "0 7";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiLoreMLMessageTextProfile: GuiMLMessageTextProfile)
{
	textOffset = "0 20";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMLMessageBoxTextProfile: GuiMLMessageTextProfile)
{
	fontSize = 22;
	textOffset = "0 0";
	fontColor = "159 137 109";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMLInputBoxTextProfile: GuiMLMessageBoxTextProfile)
{
	fontColor = "156 155 154";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTextSettingsProfile : GuiBaseTextProfile)
{
	fontColor = "178 128 28";
	fontSize = 24;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTextEditSettingsBarProfile : GuiBaseTextProfile)
{
   fontSize = 24;
   fontColor = "204 204 204";
   fontColorHL = "204 204 204";
   fontColorNA = "204 204 204";
   fontColorSEL = "204 204 204";
   justify = "center";
   textOffset = "0 0";
   border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiInventoryContainerProfile : GuiWindowProfile)
{
	fontSize = 20;
	autoCursorMode = true;
	canEscCloseOnPlayGui = true;
	textOffset = "10 3";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(TargetBarImageProfile : GuiBaseTextProfile) {
	globalImageIndex = "shape_info";
};

singleton GuiControlProfile(TargetBarBaseTextProfile : GuiBaseTextProfile) {
	shadowText = "1";
	shadowColor = "0 0 0";
	autoSizeWidth = true;
};

singleton GuiControlProfile(TargetBarBorderProfile : TargetBarImageProfile) {
	border = "all_tiling";
};

singleton GuiControlProfile(TargetBarObjectNameProfile : TargetBarBaseTextProfile) {
	fontSize = "24";
};

singleton GuiControlProfile(TargetBarObjectTypeProfile : TargetBarBaseTextProfile) {
	fontSize = "19";
};

singleton GuiControlProfile(TargetBarMouseActionProfile : TargetBarObjectTypeProfile) {
	fontColor = $TargetBar::secondTextColor;
};

singleton GuiControlProfile(TargetBarExtraInfoProfile : TargetBarObjectTypeProfile) {};

singleton GuiControlProfile(TargetBarObjectDistanceProfile : TargetBarObjectTypeProfile) {
	fontColor = $TargetBar::secondTextColor;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(AlignmentBarImageProfile : GuiBaseTextProfile)
{
	globalImageIndex = "atlas3";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(AlignmentBarPositiveTextProfile : GuiBaseCaptionProfile)
{
	fontSize = "40";
	fontColor = $AlignmentBar::positiveAlignmentColor;
	shadowText = "1";
	shadowColor = "0 0 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(AlignmentBarPositiveSmallTextProfile : AlignmentBarPositiveTextProfile)
{
	fontSize = "18";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(AlignmentBarNegativeTextProfile : GuiBaseCaptionProfile)
{
	fontSize = "40";
	fontColor = $AlignmentBar::negativeAlignmentColor;
	justify = "right";
	shadowText = "1";
	shadowColor = "0 0 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(AlignmentBarNegativeSmallTextProfile : AlignmentBarNegativeTextProfile)
{
	fontSize = "18";
};

singleton GuiControlProfile(Monument11pxTextProfile: GuiBaseTextProfile)
{
	fontSize = 24;
	fontColor = "176 152 122";
	fontColorNA = "176 152 122";
	fontColorHL = "176 152 122";
	fontColorSEL = "64 64 64 125";

	canKeyFocus = true;
	cursorColor = "176 152 122";

	fillColorHL ="255 255 255 0";
	fillColorSEL = "255 255 255 0";
	fillColorNA = "255 255 255 0";
	fillColor = "255 255 255 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MonumentLevelTextProfile: Monument11pxTextProfile)
{
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MonumentInfoTextProfile: Monument11pxTextProfile)
{
	fontSize = 20;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MonumentInfoNumProfile: Monument11pxTextProfile)
{
	fontSize = 23;
	justify = "right";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MonumentUserListPnlProfile: GuiBaseTextProfile)
{
	border = "only_background_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MonumentSacrificeTextProfile: GuiBaseTextProfile)
{
	justify = "center";
	fontSize = 20;
	fontColor = "105 92 75";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(BuildNameProfile: GuiBaseCaptionProfile)
{
	fontSize = 27;
	fontColor = "159 137 109";
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(ComboWindowTextProfile: GuiBaseTextProfile)
{
	fontSize = 24;
	fontColor = "200 0 0";
	autoSizeWidth = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(ComboWindowSmallTextProfile: GuiBaseTextProfile)
{
	fontSize = 18;
	fontColor = "200 0 0";
	autoSizeWidth = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowSubtitleProfile: GuiBaseTextProfile)
{
	fontSize = "24";
	modal = false;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowButtonBaseProfile: GuiBaseCaptionProfile)
{
	justify = "center";
	autoSizeWidth = "1";
	fontSize = 51;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowButtonsProfile: MainMenuWindowButtonBaseProfile)
{
	fontColor = "50 60 72";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowMouseOverButtonsProfile: MainMenuWindowButtonBaseProfile)
{
	fontColor = "83 100 120";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowJoinButtonProfile: MainMenuWindowButtonsProfile)
{
	fontSize = 68;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowOverJoinButtonProfile: MainMenuWindowMouseOverButtonsProfile)
{
	fontSize = 68;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiCmProgressBitmapProfile : GuiBaseTextProfile)
{
	border = "none";
	globalImageIndex = "progress_bar";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowBackgroundProfile: GuiBaseTextProfile)
{
	opaque = "1";
	fillColor = "0 0 0";
	border = "rect1_color";
	borderColor = "0 0 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowBackgroundVideoProfile: GuiBaseTextProfile)
{
	border = "rect1_color";
	borderColor = "0 0 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MainMenuWindowOverlayProfile: GuiOverlayProfile)
{
	autoCursorMode = true;
	border = "rect1_color";
	borderColor = "0 0 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiOverlayAutoCursorProfile: GuiOverlayProfile)
{
	autoCursorMode = true;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiLoadingWindowProfile: GuiContentProfile)
{
	autoCursorMode = true;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(BuildPositionButtonProfile : GuiBaseTextProfile)
{
	globalImageIndex = "atlas2";
	fontSize = 25;
	justify = "center";
	textOffset = "0 -2";
	border = "none";
	fontColor = "203 203 203";
};

singleton GuiControlProfile(CreateWorldWindowBtnProfile: BuildPositionButtonProfile)
{
	justify = "center";
	fontColor = "203 203 203";
	fontColorHL = "203 203 203";
	fontColorNA = "203 203 203";
	fontColorSEL = "203 203 203";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowImageProfile: GuiBaseTextProfile)
{
	globalImageIndex = "createWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowAttentionTextProfile: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "203 203 203";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowTextProfile: GuiBaseTextProfile)
{
	fontSize = 24;
	fontColor = "178 128 28";
};

singleton GuiControlProfile(CreateWorldWindowEditBackProfile: GuiAtlas3TiledImageProfile)
{
	opaque = 1;
	fillColor = "0 0 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowLeftPanelTextProfile: CreateWorldWindowTextProfile)
{
	autoSizeWidth = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowCaptionProfile : GuiBaseTextProfile)
{
	//globalImageIndex = "createWorldWindow";
	//border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(NewGuiTextEditProfile : GuiBaseTextProfile)
{
	fontColor = "203 203 203";
	cursorColor = "203 203 203";
	autoSizeWidth = false;
	autoSizeHeight = false;
	justify = "left";
	tab = true;
	canKeyFocus = true;
	fontSize = 18;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowTextEditProfile: NewGuiTextEditProfile)
{
	tab = true;
	textOffset = "19 0";//22";
	fontSize = 24;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowCaptionTextProfile: GuiBaseCaptionProfile)
{
	fontSize = 36;
	fontColor = "203 203 203";
	autoSizeWidth = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowSmallTextProfile: GuiBaseTextProfile)
{
	fontSize = 18;
	fontColor = "165 165 165";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowJudgeTextProfile: GuiBaseTextProfile)
{
	fontSize = 18;
	fontColor = "178 128 28";
};

singleton GuiControlProfile(CreateWorldWindowJudgeDayTextProfile: CreateWorldWindowJudgeTextProfile)
{
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowDefaultProfile: GuiBaseTextProfile)
{
	//globalImageIndex = "createWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CreateWorldWindowNumbersTextEditProfile: NewGuiTextEditProfile)
{
	tab = "1";
	//globalImageIndex = "createWorldWindow";
	textOffset = "19 0";
	//border = "all_tiling";
	fontSize = 24;
	fontColor = "203 203 203";
	cursorColor = "203 203 203";
	autoSizeHeight = "0";
	autoSizeWidth = "0";
	numbersOnly = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiLoadingProgressTextProfile: GuiBaseTextProfile)
{
	fontSize = "24";
	fontColor = "255 255 255";
};
//------------------------------------------------------------------------------

singleton GuiControlProfile(GuiLoadingGameHintLabelProfile: GuiBaseCaptionProfile)
{
	fontSize = "36";
	fontColor = "255 255 255";
};
//------------------------------------------------------------------------------

singleton GuiControlProfile(GuiLoadingGameHintProfile: GuiBaseTextProfile)
{
	fontSize = "24";
	fontColor = "208 208 208";
};
//------------------------------------------------------------------------------

singleton GuiControlProfile(GuiBarterPlayerNameTextProfile: GuiBaseTextProfile)
{
	fontSize = "24";
	fontColor = "178 128 28";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(BarterWindowWorkAreaProfile: GuiBaseTextProfile)
{
	globalImageIndex = "item_container";
	border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(BarterWindowImageProfile: GuiBaseTextProfile)
{
	globalImageIndex = "atlas3";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(BarterWindowButtonProfile: GuiBaseTextProfile)
{
	justify = "center";
	fontSize = 20;
	fontColor = "170 147 116";
	globalImageIndex = "barter_window";
	border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiBarterLabelTextProfile: GuiBaseTextProfile)
{
	fontSize = "20";
	fontColor = "171 171 171";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiBarterDoubleValueTextProfile: GuiBaseTextProfile)
{
	fontSize = "24";
	fontColor = "164 164 164";
	fontColorSEL = "164 164 164";
	fontColorNA = "164 164 164";
	justify = "right";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(BarterWindowAcceptedAreaProfile: GuiBaseTextProfile)
{
	opaque = "1";
	fillColor = "0 0 0 50";
	border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTransparentTextProfile : GuiBaseTextProfile)
{
	fontColor = "255 255 255 1";
};
//------------------------------------------------------------------------------

singleton GuiControlProfile(TrebuchetWindowWorkAreaProfile: GuiBaseTextProfile)
{
	globalImageIndex = "item_container";
	border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(TrebuchetWindowImageProfile: GuiAtlas2ImageProfile)
{
	//globalImageIndex = "atlas2";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(TrebuchetWindowAttackAngleSliderProfile: GuiBaseTextProfile)
{
	globalImageIndex = "trebuchet_window";
	border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(TrebuchetWindowLabelTextProfile: GuiBaseTextProfile)
{
	fontSize = "24";
	fontColor = "178 128 28";
	justify = "left";
	fontName = $GlobalTextBoldFontName;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(TrebuchetWindowLabelRightTextProfile: GuiBaseTextProfile)
{
	fontSize = "22";
	fontColor = "159 137 109";
	justify = "right";
	fontName = $GlobalTextBoldFontName;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(TrebuchetWindowRotateButtonProfile: GuiBaseTextProfile)
{
	globalImageIndex = "trebuchet_window";
	border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(TrebuchetWindowAngleTextProfile: GuiBaseTextProfile)
{
	fontSize = "24";
	fontColor = "178 128 28";
	justify = "center";
	fontName = $GlobalTextBoldFontName;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GroupUnitWindowDefaultProfile: GuiBaseTextProfile)
{
	globalImageIndex = "createWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GroupUnitWindowWidgetBackgroundProfile: GuiBaseTextProfile)
{
	globalImageIndex = "groupUnitWindow";
	border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GroupUnitWindowNameTextProfile: GuiBaseTextProfile)
{
	fontSize = "16";
	fontColor = "159 137 109";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMessageBoxPasswordDlgButtonProfile: GuiBaseTextProfile)
{
	justify = "center";
	fontSize = 22;
	fontColor = "170 147 116";
	globalImageIndex = "messageBoxPasswordDlg";
	border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiInputBoxButtonProfile: GuiMessageBoxPasswordDlgButtonProfile)
{
	fontColor = "156 155 154";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMessageBoxPasswordDlgTextEditProfile: NewGuiTextEditProfile)
{
	globalImageIndex = "messageBoxPasswordDlg";
	textOffset = "19 0";//22";
	border = "all_tiling";
	fontSize = 18;
	fontColor = "170 147 116";
	cursorColor = "170 147 116";
	autoSizeHeight = "0";
	autoSizeWidth = "0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiInputBoxTextEditProfile: GuiMessageBoxPasswordDlgTextEditProfile)
{
	fontColor = "156 155 154";
	cursorColor = "156 155 154";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMessageBoxPasswordDlgCheckBoxProfile : GuiBaseTextProfile)
{
	fontSize = 18;
	fontColor = "182 182 182";
	globalImageIndex = "joinWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiMessageBoxDirectConnectDlgTextProfile : GuiBaseTextProfile)
{
	fontSize = 19;
	fontColor = "182 182 182";
};
//-----------------------------------------------------------------------------
singleton GuiControlProfile(JoinWorldWindowImageProfile: GuiBaseTextProfile)
{
	globalImageIndex = "joinWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowTabButtonTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "170 147 116";
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowHeaderButtonTextProfile: GuiBaseTextProfile)
{
	fontSize = 18;
	fontColor = "132 132 132";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowBtnProfile: GuiBaseTextProfile)
{
	justify = "center";
	fontSize = 22;
	fontColor = "170 147 116";
	globalImageIndex = "joinWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowButtonProfile: GuiBaseTextProfile)
{
	globalImageIndex = "joinWorldWindow";
	border = "all_tiling";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowButtonTextProfile: GuiBaseTextProfile)
{
	fontSize = "22";
	fontColor = "159 137 109";
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowServerNameLabelTextProfile: GuiBaseTextProfile)
{
	fontSize = "22";
	fontColor = "145 145 145";
	autoSizeWidth = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowServerMainSettingsLabelProfile: GuiBaseTextProfile)
{
	fontSize = "20";
	fontColor = "145 145 145";
	autoSizeWidth = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowServerMainSettinsTextProfile: GuiBaseTextProfile)
{
	fontSize = "20";
	fontColor = "224 224 224";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowServerSettingsLabelProfile: GuiBaseTextProfile)
{
	fontSize = "19";
	fontColor = "145 145 145";
	autoSizeWidth = "1";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiScrollServerListProfile: GuiScrollSkillInfoProfile)
{
	globalImageIndex = "joinWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowHeaderButtonLatencyTextProfile: JoinWorldWindowHeaderButtonTextProfile)
{
	justify = "right";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(JoinWorldWindowDialogButtonProfile: JoinWorldWindowRubberButtonProfile)
{
	fontSize = "22";
	fontColor = "159 137 109";
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTileLegendDescrProfile: GuiAtlas3ImageProfile)
{
	fontSize = 18;
	fontColor = "153 153 153";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiInputCtrlProfile : GuiBaseTextProfile)
{
	tab = false;
	canKeyFocus = true;
	category = "Core";
};

singleton GuiControlProfile(optionsVideoTextProfile : GuiBaseTextProfile)
{
	fontColor = "178 128 28";
	fontSize = 24;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(optionsVideoCheckBoxTextProfile: optionsVideoTextProfile)
{
	fontSize = 22;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(VideoTextEditProfile: optionsVideoTextProfile)
{
	tab = false;
	canKeyFocus = true;
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTextVideoDlgProfile: optionsVideoTextProfile)
{
	fontSize = 24;
	autoSizeWidth = true;
	fontColor = "153 153 153";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiTextVideoCommentProfile: optionsVideoTextProfile)
{
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(VideoBtnProfile: optionsVideoTextProfile)
{
	justify = "center";
	fontColorHL = "178 156 127";
	fontColorSEL= "151 143 132";

	globalImageIndex = "createWorldWindow";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CmComboStackButtonDef: GuiBaseTextProfile)
{
	fontColor = "204 204 204";
	fontSize = 26;
	textOffset = "10 5";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(CharPanelColorProfile: GuiBaseTextProfile)
{
	opaque = true;
	border = "none";
	fillColor = "197 177 144";
	globalImageIndex = "atlas3";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiCharDescProfile: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "175 175 175";
	textOffset = "0 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(optionsAudioMicTextProfile: optionsVideoTextProfile)
{
	fontSize = 22;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(optionsAudioDiscMicTextProfile: optionsAudioMicTextProfile)
{
	fontColor = "147 147 147";
	fontSize = 20;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerRightText1Profile : GuiBaseTextProfile)
{
	fontColor = "203 203 203";
	fontColorNA = "178 128 28";
	fontColorSEL = "199 188 165";
	fontColorHL = "190 160 125";
	fontSize = 18;
	textOffset = "15 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerRightText2Profile : MixerRightText1Profile)
{
	fontColor = "199 188 165";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerCountProfile : MixerRightText2Profile)
{
	fontColor = "203 203 203";
	fontSize = 15; 
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerCaptionBigTextProfile : GuiBaseCaptionProfile)
{
	fontColor = "178 128 28";
	fontSize = 34;
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerCaptionTextProfile : MixerCaptionBigTextProfile)
{
	fontSize = 24;
	fillColor = "0 0 0";
	opaque = true;
	border = "none";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerBackgroundProfile : MixerCaptionTextProfile)
{
	fillColor = "0 0 0 128";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerEffectsTextProfile : GuiBaseTextProfile)
{
	fontColor = "203 203 203";
	fontColorNA = "102 102 102";
	fontSize = 18;
	textOffset = "15 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerEffectsCaptionProfile : MixerEffectsTextProfile)
{
	fontColor = "178 128 28";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(MixerEffectMagnitudeProfile : MixerEffectsTextProfile)
{
	textOffset = "0 0";
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiSmeltingContainerLabelProfile : GuiBaseTextProfile) {
	fontSize = 19;
	fontColor = "255 255 255";
};

singleton GuiControlProfile(GuiSmeltingContainerInventoryButtonProfile : GuiBaseTextProfile ) {
	globalImageIndex = "atlas2";
	fontSize = 24;
	fontColor = "204 204 204";
	fontColorHL = "204 204 204";
	fontColorNA = "204 204 204";
	fontColorSEL = "204 204 204";
	justify = "center";
	textOffset = "0 -2";
	border = "none";
};

singleton GuiControlProfile(GuiSmeltingContainerTemperatureProfile : GuiBaseTextProfile) {
	fontSize = 18;
	fontColor = "204 204 204";
	fontColorNA = "102 102 102";
};

singleton GuiControlProfile(GuiHeraldryColorTextProfile: GuiText7pxProfile)
{
	fontSize = 20;
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(GuiHeraldryImageProfile : GuiBaseTextProfile)
{
	globalImageIndex = "heraldrySlices";
};

singleton GuiControlProfile(GuiHeraldryTabProfile: GuiBaseCaptionProfile)
{
	globalImageIndex = "heraldrySlices";
	justify = "center";
	fontColorNA = "94 82 68";
	fontColor = "178 156 127";
	fontColorHL = "178 156 127";
	fontColorSEL= "159 137 109";

	fontSize = 22;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(OptionsHeaderTextProfile: GuiBaseCaptionProfile)
{
	fontColor = "102 102 102";
	fontSize = 32;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(OptionsHeaderKeyProfile: OptionsHeaderTextProfile)
{
	justify = "center";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(ControlsSubMenuTextProfile: GuiBaseCaptionProfile)
{
	fontColor = "178 128 28";
	fontSize = 30;
	textOffset = "13 0";
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(ControlsTextProfile: GuiBaseTextProfile)
{
	fontColor = "176 152 122";
	fontSize = 26;
};
//-----------------------------------------------------------------------------

singleton GuiControlProfile(BindTextProfile: ControlsTextProfile)
{
	autoSizeWidth = true;
};


singleton GuiControlProfile(HeraldrySetingTextProfile : GuiBaseTextProfile)
{
	fontSize = 22;
	fontColor = "188 163 130";
};

singleton GuiControlProfile(GuiPersonalClaimCellsProfile: GuiBaseCaptionProfile)
{
	fontSize = 22;
	fontColor = "178 128 28";
	justify = "Left";
};

singleton GuiControlProfile(GuiPersonalClaimColNameProfile: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "103 103 103";
	justify = "center";
};

singleton GuiControlProfile(GuiPersonalClaimParamNameProfile: GuiBaseTextProfile)
{
	fontSize = 22;
	fontColor = "153 153 153";
};

singleton GuiControlProfile(GuiPersonalClaimParamValProfile: GuiPersonalClaimParamNameProfile)
{
	fontColor = "255 255 255";
	justify = "Center";
};

singleton GuiControlProfile(GuiPersonalClaimDiscProfile: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "103 103 103";
};

singleton GuiControlProfile(GuiPersonalClaimDaysTxtProfile: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "103 103 103";
};

singleton GuiControlProfile(GuiPersonalClaimDayslblProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "153 153 153";
	autoSizeWidth = true;
};

singleton GuiControlProfile(GuiPersonalClaimDaysValProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "255 255 255";
	autoSizeWidth = true;
};

singleton GuiControlProfile(GuildCtrlCreateGuildTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "154 154 154";
};

singleton GuiControlProfile(GuildHeraldryBackProfile: GuiBaseTextProfile)
{
	opaque = true;
	fillColor = "105 105 105";
};

singleton GuiControlProfile(GuildUsersBackProfile: GuiBaseTextProfile)
{
	opaque = true;
	fillColor = "0 0 0 140";
};

singleton GuiControlProfile(GuildLabelTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "106 96 80";
};

singleton GuiControlProfile(GuildBlackVertLineProfile: GuiBaseTextProfile)
{
	opaque = true;
	fillColor = "0 0 0";
};

singleton GuiControlProfile(GuildCountTextProfile: GuiBaseTextProfile)
{
	fontSize = 23;
	fontColor = "255 255 255";
};

singleton GuiControlProfile(GuildCountNumProfile: GuildCountTextProfile)
{
	fontSize = 24;
};

singleton GuiControlProfile(GuildLeaderNameTextProfile: GuiBaseTextBoldProfile)
{
	fontSize = 20;
	fontColor = "194 178 152";
};

singleton GuiControlProfile(GuildUserListTextProfile : GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "159 137 109";
};

singleton GuiControlProfile(GuildYuoAsMemberTextProfile : GuiBaseTextBoldProfile)
{
	fontSize = 20;
	fontColor = "153 153 153";
};

singleton GuiControlProfile(GuildHeraldryBtnTextProfile: SelectionListBaseProfile)
{
	justify = "center";
	fontSize = 22;
	fontColor = "159 137 109";
};

singleton GuiControlProfile(SelectWorldWindowCaptionTextProfile: GuiBaseTextProfile)
{
	fontSize = 30;
	fontColor = "170 147 116";
	autoSizeWidth = "1";
};

singleton GuiControlProfile(SelectWorldNameTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "170 147 116";
	autoSizeWidth = "0";
};

singleton GuiControlProfile(GuiMLTextTooltipProfile: GuiBaseTextProfile)
{
	fontSize = 19;
	fontColor = "204 204 204";
	autoSizeWidth = true;
};

singleton GuiControlProfile(GuiGrayMLTextTooltipProfile: GuiMLTextTooltipProfile)
{
	fontColor = "102 102 102";
};

singleton GuiControlProfile(GuiMLDescrTextTooltipProfile: GuiMLTextTooltipProfile)
{
	fontType = $GlobalTextItalicFontName;
	fontColor = "153 153 153";
};

singleton GuiControlProfile(GuiTextTooltipProfile: GuiBaseTextProfile)
{
	fontSize = "19";
	autoSizeWidth = true;
};

singleton GuiControlProfile(GuiGrayTextTooltipProfile: GuiTextTooltipProfile)
{
	fontColor = "102 102 102";
};

singleton GuiControlProfile(GuiGoldTextTooltipProfile: GuiTextTooltipProfile)
{
	fontColor = "255 215 0";
};

singleton GuiControlProfile(GuiLightTextTooltipProfile: GuiTextTooltipProfile)
{
	fontColor = "204 204 204";
};

singleton GuiControlProfile(GuiPositiveTextTooltipProfile: GuiTextTooltipProfile)
{
	fontColor = "120 196 121";
};

singleton GuiControlProfile(GuiStatBonusTextTooltipProfile: GuiPositiveTextTooltipProfile)
{
	justify = "Right";
};

singleton GuiControlProfile(GuiNegativeTextTooltipProfile: GuiTextTooltipProfile)
{
	fontColor = "211 87 74";
};

singleton GuiControlProfile(GuiCaptionTextTooltipProfile: GuiBaseCaptionProfile)
{
	fontSize = "22";
	fontColor = "178 128 28";
	autoSizeWidth = true;
};

singleton GuiControlProfile(GuiBoldTextTooltipProfile: GuiBaseTextBoldProfile)
{
	fontSize = "19";
	autoSizeWidth = true;
	fontColor = "178 128 28";
};

singleton GuiControlProfile(GuiMLCaptionTextTooltipProfile: GuiBaseCaptionProfile)
{
	fontSize = 22;
	fontColor = "204 204 204";
	autoSizeWidth = true;
};

singleton GuiControlProfile (InvItemGui: GuiBaseTextProfile)
{
	fontSize = 16;
	fontColor = "201 178 148";
	fontColorNA = "128 128 128";
};

singleton GuiControlProfile(GuiContextMenuProfile : GuiBaseTextProfile)
{
	autoCursorMode = true;
};

singleton GuiControlProfile(EscMenuButtonProfile : GuiBaseCaptionProfile)
{
	globalImageIndex = "atlas2";
	fontSize = 30;
	justify = "center";
	textOffset = "0 -2";
	border = "none";
	fontColor = "203 203 203";
	fontColorNA = "102 102 102";
};

singleton GuiControlProfile(GuiBarValProfile: GuiBaseCaptionProfile)
{
	fontSize = 21;
	fontColor = "255 255 255";
	justify = "center";
};

singleton GuiControlProfile(MessageBoxTextProfile : GuiBaseCaptionProfile)
{
	fontSize = 21;
	fontColor = "178 128 28";
	fontColorHL = "178 128 28";
	fontColorSEL = "178 128 28";
	justify = "center";
};

singleton GuiControlProfile(MessageBoxButtonProfile : GuiAtlas2ImageProfile)
{
	fontSize = 24;
	fontColor = "204 204 204";
	fontColorHL = "204 204 204";
	fontColorSEL = "204 204 204";
	justify = "center";
	textOffset = "0 -2";
};

singleton GuiControlProfile(GuildCtrlNotGuildCaptionProfile: GuiBaseCaptionProfile)
{
	fontSize = 22;
	fontColor = "192 129 0";
	justify = "center";
};

singleton GuiControlProfile(GuildCtrlNotGuildTextProfile: GuiBaseTextProfile)
{
	fontSize = 20;
	fontColor = "154 154 154";
};

singleton GuiControlProfile(GuildCtrlTextValueProfile: GuiBaseTextProfile)
{
	fontSize = 24;
	fontColor = "204 204 204";
	fontColorHL = "204 204 204";
	fontColorNA = "204 204 204";
	fontColorSEL = "204 204 204";
	canKeyFocus = true;
	cursorColor = "204 204 204 255";
};

singleton GuiControlProfile(GuildCtrlTextMemberProfile: GuildCtrlTextValueProfile)
{
	fontSize = 20;
};

singleton GuiControlProfile(GuildCtrlTextYourProfile: GuildCtrlTextMemberProfile)
{
	fontColor = "178 128 28";
};

singleton GuiControlProfile(GuildCtrlTextLeaderProfile: GuiBaseTextBoldProfile)
{
	fontColor = "178 128 28";
	fontSize = 22;
};

singleton GuiControlProfile(GuildCtrlTextMemberCountProfile: GuiBaseCaptionProfile)
{
	fontColor = "178 128 28";
	fontSize = 26;
};

singleton GuiControlProfile(GuildBtnProfile: GuiAtlas2ImageProfile)
{
	fontSize = 24;
	fontColor = "204 204 204";
	fontColorHL = "204 204 204";
	fontColorNA = "204 204 204";
	fontColorSEL = "204 204 204";
	justify = "center";
	textOffset = "0 -2";
	border = "none";
};

singleton GuiControlProfile(SocialTitlePopUpProfile: GuiSkillPopUpProfile)
{
	profileForChildren = CreateCharWindowPopUpTextListProfile;
	textOffset = "15 0";
	globalImageIndex = "popUpCtrl";
	border = "none";
	fontSize = 24;
	fontColor = "204 204 204";
	fontColorNA = "204 204 204";
	fontColorHL = "204 204 204";
	fontColorSEL = "204 204 204";
};

singleton GuiControlProfile( GuiGuildRankLabelProfile : GuiBaseTextProfile) 
{
	fontSize = 20;
	justify = "left";
	fontColor = "104 104 104";
};

singleton GuiControlProfile(MessageBoxInputLabelProfile: GuiBaseCaptionProfile)
{	
	fontSize = 24;
	fontColor = "270 147 116";
	fontColor = "178 128 28";
	fontColorHL = "178 128 28";
	fontColorSEL = "178 128 28";    
};

singleton GuiControlProfile(MessageBoxInputTextProfile: GuiBaseTextProfile)
{	
	fontColor = "170 147 116";
	fontSize = 24;
	fontColor = "255 255 255";
	textOffset = "15 0";
	cursorColor = "255 255 255";
	opaque = false;
	border = "none";
	tab = "1";
	canKeyFocus = true;
};

