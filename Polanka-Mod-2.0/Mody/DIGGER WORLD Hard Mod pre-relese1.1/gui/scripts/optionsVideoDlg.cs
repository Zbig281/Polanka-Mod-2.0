
// presets
$low = 0;
$medium = 1;
$high = 2;
$ultra = 3;
$custom = 4;

exec("./preset_low.cs");
exec("./preset_medium.cs");
exec("./preset_high.cs");
exec("./preset_ultra.cs");


$AA::OptionsArr[0] = ""; // invalid value
$AA::OptionsArr[1] = "FXAA";
$AA::OptionsArr[2] = "SMAA";
$AA::OptionsArrSize = 3;

$precision = 100;

/// Returns true if the current quality settings equal
/// this graphics quality level.
function GraphicsQualityLevel::isCurrent( %this )
{
   // Test each pref to see if the current value
   // equals our stored value.

   for ( %i=0; %i < %this.count(); %i++ )
   {
      %pref = %this.getKey( %i );
      %value = %this.getValue( %i );

      if ( getVariable( %pref ) !$= %value )
         return false;
   }

   return true;
}

/// Applies the graphics quality settings and calls
/// 'onApply' on itself or its parent group if its
/// been overloaded.
function GraphicsQualityLevel::apply( %this )
{
   for ( %i=0; %i < %this.count(); %i++ )
   {
      %pref = %this.getKey( %i );
      %value = %this.getValue( %i );
      setVariable( %pref, %value );
   }

   // If we have an overloaded onApply method then
   // call it now to finalize the changes.
   if ( %this.isMethod( "onApply" ) )
      %this.onApply();
   else
   {
      %group = %this.getGroup();
      if ( isObject( %group ) && %group.isMethod( "onApply" ) )
         %group.onApply( %this );
   }
}

function GraphicsQualityPopup::init( %this, %qualityGroup )
{
   assert( isObject( %this ) );
   assert( isObject( %qualityGroup ) );

   // Clear the existing content first.
   %this.clear();

   // Fill it.
   %select = -1;
   for ( %i=0; %i < %qualityGroup.getCount(); %i++ )
   {
      %level = %qualityGroup.getObject( %i );
      if ( %level.isCurrent() )
         %select = %i;

      %this.add( %level.getInternalName(), %i );
   }

   // Setup a default selection.
   if ( %select == -1 )
      %this.setText( "Custom" );
   else
      %this.setSelected( %select );
}

function GraphicsQualityPopup::apply( %this, %qualityGroup, %testNeedApply )
{
   assert( isObject( %this ) );
   assert( isObject( %qualityGroup ) );

   %quality = %this.getText();

   %index = %this.findText( %quality );
   if ( %index == -1 )
      return false;

   %level = %qualityGroup.getObject( %index );
   if ( isObject( %level ) && !%level.isCurrent() )
   {
      if ( %testNeedApply )
         return true;

      %level.apply();
   }

   return false;
}

function OptionsVideoDlg::setPane(%this, %pane)
{
   %this.findObjectByInternalName( "Opt" @ %pane @ "Pane", true ).setVisible(true);

   %this.fillRemapList();

   // Update the state of the apply button.
   %this._updateApplyState();
}

function OptionsVideoDlg::setOlds( %this )
{
    $oldPreset = $pref::Video::preset;
	$oldDevice = $pref::Video::displayDevice;
	$oldMode = $pref::Video::mode;
	$oldVsync = $pref::Video::disableVerticalSync;
	$oldAntiAliasing = $pref::Video::AntiAliasing;
	$oldDefaultAnisotropy = $pref::Video::defaultAnisotropy;
	$oldShadows = $pref::Video::ShadowQuality;
	$oldReflections = $pref::Video::reflectionsMode;
    $oldSSAO = $pref::Video::EnableSSAO;
    $oldDOF = $pref::Video::EnableDOF;
	$oldColorGrading = $pref::Video::EnableColorGrading;
    $oldLightRays = $pref::Video::EnableLightRays;
	$oldRenderingDistanceSmall = $pref::TS::renderingDistanceSmall;
	$oldRenderingDistanceBig = $pref::TS::renderingDistanceBig;
	$oldRenderingDistanceHuge = $pref::TS::renderingDistanceHuge;
	$oldDetailAdjustForest = $pref::TS::detailAdjustForest;
	$oldTreeDistance = $pref::Video::DistanceForestRender;
	$oldDetailAdjust = $pref::TS::detailAdjust;
	$oldAutoAdjustQuality = $pref::TS::autoAdjustQuality;
	$oldBrightness = $pref::Video::brightness;
	$oldEnablePostEffects = $pref::Video::enablePostEffects;
	$oldGrassRenderingDistance = $pref::TS::grassRenderingDistance;
	$oldShadowDistance = $pref::Video::ShadowDistance;
	$oldWaterQuality = $pref::Video::waterQuality;
	$oldLightingQuality = $pref::Video::lightingQuality;
	$oldTextureQuality = $pref::Video::textureReductionLevel;
	$oldTerrainQuality = $pref::Video::terrainQuality;
	$oldCameraFOV = $pref::player::CurrentFOV;
	$oldParticlesCount = $pref::Video::particlesCount;

	$oldFilmGrain = $pref::Video::EnableFilmGrain;
	$oldLensFlare = $pref::Video::EnableLensFlare;
    $oldEProxyHighQuality = $pref::Video::EProxyHighQuality;
   $oldAdvancedWeather = $pref::Weather::IsEnabled;
}
function OptionsVideoDlg::restoreOlds(%this)
{
	if ($pref::Video::displayDevice != $oldDevice)
		$pref::Video::displayDevice = $oldDevice;
	if ($pref::Video::mode != $oldMode)
		$pref::Video::mode = $oldMode;
	if ($pref::Video::disableVerticalSync != $oldVsync)
		$pref::Video::disableVerticalSync = $oldVsync;
	if ($pref::Video::AntiAliasing != $oldAntiAliasing)
		$pref::Video::AntiAliasing = $oldAntiAliasing;
	if ($pref::Video::defaultAnisotropy != $oldDefaultAnisotropy)
		$pref::Video::defaultAnisotropy = $oldDefaultAnisotropy;
	if ($pref::Video::ShadowQuality != $oldShadows)
		$pref::Video::ShadowQuality = $oldShadows;
	if ($pref::Video::reflectionsMode != $oldReflections)
		$pref::Video::reflectionsMode = $oldReflections;
	if ($pref::Video::EnableSSAO != $oldSSAO)
		$pref::Video::EnableSSAO = $oldSSAO;
	if ($pref::Video::EnableDOF != $oldDOF)
		$pref::Video::EnableDOF = $oldDOF;
	if ($pref::Video::EnableColorGrading != $oldColorGrading)
		$pref::Video::EnableColorGrading = $oldColorGrading;
	if ($pref::Video::EnableLightRays != $oldLightRays)
		$pref::Video::EnableLightRays = $oldLightRays;

	if ($pref::TS::renderingDistanceSmall != $oldRenderingDistanceSmall)
		$pref::TS::renderingDistanceSmall = $oldRenderingDistanceSmall;
	if ($pref::TS::renderingDistanceBig != $oldRenderingDistanceBig)
		$pref::TS::renderingDistanceBig = $oldRenderingDistanceBig;
	if ($pref::TS::renderingDistanceHuge != $oldRenderingDistanceHuge)
		$pref::TS::renderingDistanceHuge = $oldRenderingDistanceHuge;
	if ($pref::TS::detailAdjustForest != $oldDetailAdjustForest)
		$pref::TS::detailAdjustForest = $oldDetailAdjustForest;
	if ($pref::Video::DistanceForestRender != $oldTreeDistance)
		$pref::Video::DistanceForestRender = $oldTreeDistance;
	if ($pref::TS::detailAdjust != $oldDetailAdjust)
		$pref::TS::detailAdjust = $oldDetailAdjust;
	if ($pref::TS::autoAdjustQuality != $oldAutoAdjustQuality)
		$pref::TS::autoAdjustQuality = $oldAutoAdjustQuality;
	if ($pref::Video::brightness != $oldBrightness)
		$pref::Video::brightness= $oldBrightness;
	if ($pref::Video::enablePostEffects != $oldEnablePostEffects)
		$pref::Video::enablePostEffects = $oldEnablePostEffects;
	if ($pref::TS::grassRenderingDistance != $oldGrassRenderingDistance)
		$pref::TS::grassRenderingDistance = $oldGrassRenderingDistance;
	if ($pref::Video::shadowDistance != $oldShadowDistance)
		$pref::Video::shadowDistance = $oldShadowDistance;
	if ($pref::player::CurrentFOV != $oldCameraFOV)
		$pref::player::CurrentFOV = $oldCameraFOV;
	if ($pref::Video::ParticlesCount != $oldParticlesCount)
		$pref::Video::ParticlesCount = $oldParticlesCount;

	if ($pref::Video::waterQuality != $oldWaterQuality)
	{
		$pref::Video::waterQuality = $oldWaterQuality;
		reloadWater();
	}

	if ($pref::Video::terrainQuality != $oldTerrainQuality)
	{
		$pref::Video::terrainQuality = $oldTerrainQuality;
		reloadTerrain();
	}

	if ($pref::Video::lightingQuality != $oldLightingQuality)
		$pref::Video::lightingQuality = $oldLightingQuality;
	if ($pref::Video::textureReductionLevel != $oldTextureQuality)
		$pref::Video::textureReductionLevel = $oldTextureQuality;

	if ($pref::Video::EnableLensFlare != $oldLensFlare)
		$pref::Video::EnableLensFlare = $oldLensFlare;
	if ($pref::Video::EProxyHighQuality != $oldEProxyHighQuality)
		$pref::Video::EProxyHighQuality = $oldEProxyHighQuality;
	if ($pref::Video::EnableFilmGrain != $oldFilmGrain)
		$pref::Video::EnableFilmGrain = $oldFilmGrain;
	if ($pref::Weather::IsEnabled != $oldAdvancedWeather)
		$pref::Weather::IsEnabled = $oldAdvancedWeather;
}

/*
===================================================================
This function invoked when this window is opened
===================================================================
*/
function OptionsVideoDlg::onWake(%this)
{
   if ( isFunction("getWebDeployment") && getWebDeployment() )
   {
      // Cannot enable full screen under web deployment
      %this-->OptGraphicsFullscreenToggle.setVisible( false );
      $pref::Video::mode = setWord($pref::Video::mode, $WORD::FULLSCREEN, false);
      $pref::Video::mode = setWord($pref::Video::mode, $WORD::BORDERLESS, false);
   }
   else
   {
      %opt_fullscreen = %this-->OptGraphicsFullscreenToggle;
      %opt_fullscreen.clear();
      %opt_fullscreen.Add(GetMessageIDText(2303), 0); //Windowed
      %opt_fullscreen.Add(GetMessageIDText(2487), 3); //Maximize
      %opt_fullscreen.Add(GetMessageIDText(2304), 1); //Windowed Borderless
      %opt_fullscreen.Add(GetMessageIDText(2305), 2); //Fullscreen

      %fullscreen = getWord($pref::Video::mode, $WORD::FULLSCREEN);
      %borderless = getWord($pref::Video::mode, $WORD::BORDERLESS);

      if (%fullscreen $= "false" && %borderless $= "false")
      {
         if ($pref::gui::autoMaximizeOnLaunch == true)
            %opt_fullscreen.setSelected(3);
         else
            %opt_fullscreen.setSelected(0);
      }
      else if (%fullscreen $= "true")
      {
         %opt_fullscreen.setSelected(2);
      }
      else if (%borderless $= "true")
      {
         %opt_fullscreen.setSelected(1);
      }
      OptionsVideoDlg. checkdResolutionMenu();
   }

   %this-->OptGraphicsVSyncToggle.setStateOn( !$pref::Video::disableVerticalSync );

   OptionsVideoDlg.initResMenu();
   %resSelId = OptionsVideoDlg-->OptGraphicsResolutionMenu.findText( _makePrettyResString( $pref::Video::mode ) );
   if( %resSelId != -1 )
      OptionsVideoDlg-->OptGraphicsResolutionMenu.setSelected( %resSelId );

   %buffer = getDisplayDeviceList();
   %count = getFieldCount( %buffer );

   //PostFXManager::loadPresetHandler($PostFXManager::userSettingsFilePath);

   %presetMenu = %this-->OptGraphicsPresetMenu;
   %presetMenu.clear();
   %presetMenu.Add(GetMessageIDText(1205), $low);
   %presetMenu.Add(GetMessageIDText(1371), $medium);
   %presetMenu.Add(GetMessageIDText(1221), $high);
   %presetMenu.Add(GetMessageIDText(1372), $ultra);
   %presetMenu.Add(GetMessageIDText(1373), $custom);
   %presetMenu.setSelected($pref::Video::preset);

   //%this-->OptGraphicsShadowsToggle.setStateOn( $pref::Shadows::disable );
   %shadowsMenu = %this-->OptGraphicsShadowsMenu;
   %shadowsMenu.clear();

   %shadowsMenu.Add(GetMessageIDText(1374), 0); // None
   %shadowsMenu.Add(GetMessageIDText(1205), 1); // Low
   %shadowsMenu.Add(GetMessageIDText(1371), 2); // Medium
   %shadowsMenu.Add(GetMessageIDText(1221), 3); // High
   %shadowsMenu.Add(GetMessageIDText(1372), 4); // Ultra
   %shadowsMenu.setSelected( $pref::Video::ShadowQuality );

   %this-->OptGraphicsReflectionsToggle.setStateOn(!$pref::Video::DisableReflections);

   %this-->OptAnisotropicFilteringToggle.setStateOn($pref::Video::defaultAnisotropy == 16);

   %waterQuality = %this-->OptWaterQualityPopup;
   %waterQuality.clear();
   %waterQuality.Add(GetMessageIDText(1205), 0); // Low
   %waterQuality.Add(GetMessageIDText(1371), 1); // Medium
   %waterQuality.Add(GetMessageIDText(1221), 2); // High
   %waterQuality.setSelected( $pref::Video::waterQuality );

	%terrainQuality = %this-->OptTerrainQualityPopup;
	%terrainQuality.clear();
	%terrainQuality.Add(GetMessageIDText(1205), 0); // Low
	%terrainQuality.Add(GetMessageIDText(1371), 1); // Medium
	%terrainQuality.Add(GetMessageIDText(1221), 2); // High
	%terrainQuality.setSelected( $pref::Video::terrainQuality );
	
	%particlesCount = %this-->OptParticlesCountPopup;
	%particlesCount.clear();
	%particlesCount.Add(GetMessageIDText(1205), 0); // Low
	%particlesCount.Add(GetMessageIDText(1371), 1); // Medium
	%particlesCount.Add(GetMessageIDText(1221), 2); // High
	%particlesCount.setSelected( $pref::Video::particlesCount );

   %lightingQuality = %this-->OptLightingQualityPopup;
   %lightingQuality.clear();
   %lightingQuality.Add(GetMessageIDText(1205), $QualityPreset::Lighting_Low);	// Low
   %lightingQuality.Add(GetMessageIDText(1371), $QualityPreset::Lighting_Medium);	// Medium
   %lightingQuality.Add(GetMessageIDText(1221), $QualityPreset::Lighting_High);	// High
   %lightingQuality.setSelected( $pref::Video::lightingQuality );

   %textureQuality = %this-->OptTextureQualityPopup;
   %textureQuality.clear();
   %textureQuality.Add(GetMessageIDText(1205), 2);	// Low
   %textureQuality.Add(GetMessageIDText(1371), 1);	// Medium
   %textureQuality.Add(GetMessageIDText(1221), 0);	// High
   %textureQuality.setSelected( $pref::Video::textureReductionLevel );

   %this-->OptAmbientOcclusionToggle.setStateOn($pref::Video::EnableSSAO);
   %this-->OptDepthOfFieldToggle.setStateOn($pref::Video::EnableDOF);
   %this-->OptColorGradingToggle.setStateOn($pref::Video::EnableColorGrading);
   %this-->OptLightRaysToggle.setStateOn($pref::Video::EnableLightRays);
   %this-->OptLensFlareToggle.setStateOn($pref::Video::EnableLensFlare);
   %this-->OptEProxyHighQualityToggle.setStateOn($pref::Video::EProxyHighQuality);
   %this-->OptFilmGrainToggle.setStateOn($pref::Video::EnableFilmGrain);
   %this-->OptAdvancedWeather.setStateOn($pref::Weather::IsEnabled);

   // Populate the Anti-aliasing popup.
   %aaMenu = %this-->OptAAQualityPopup;
   %aaMenu.clear();
   %aaMenu.Add( GetMessageIDText(1209), %this.aaNameToIndex(""));
   %aaMenu.Add( GetMessageIDText(858),  %this.aaNameToIndex("FXAA"));
   %aaMenu.Add( GetMessageIDText(860),  %this.aaNameToIndex("SMAA"));
   %aaMenu.setSelected(%this.aaNameToIndex($pref::Video::AntiAliasing));


   %smallObjects = $pref::TS::renderingDistanceSmall;
   %this-->OptSmallSlider.setValue(%smallObjects);
   %this-->TxtEditSmall.setValue(%smallObjects);

   %bigObjects = $pref::TS::renderingDistanceBig;
   %this-->OptBigSlider.setValue(%bigObjects);
   %this-->TxtEditBig.setValue(%bigObjects);

   %hugeObjects = $pref::TS::renderingDistanceHuge;
   %this-->OptHugeSlider.setValue(%hugeObjects);
   %this-->TxtEditHuge.setValue(%hugeObjects);

   %treeLOD = $pref::TS::detailAdjustForest;
   %this-->OptTreeSlider.setValue(%treeLOD * $precision);
   %this-->TxtEditTree.setValue(mFloatLength(%treeLOD, 2));

   %treeDistance = $pref::Video::DistanceForestRender;
   %this-->OptTreeDistanceSlider.setValue(%treeDistance);
   %this-->TxtEditTreeDistance.setValue(%treeDistance);

   %objectLOD = $pref::TS::detailAdjust;
   %this-->OptObjectSlider.setValue(%objectLOD * $precision);
   %this-->TxtEditObject.setValue(mFloatLength(%objectLOD, 2));

   %autoAdjust = %this-->OptAdjustQualityToggle;
   %autoAdjust.setStateOn($pref::TS::autoAdjustQuality);
   if ($pref::TS::autoAdjustQuality)
   {
      %this-->OptTreeSlider.setActive(false);
      %this-->OptObjectSlider.setActive(false);
   }
   else
   {
      %this-->OptTreeSlider.setActive(true);
      %this-->OptObjectSlider.setActive(true);
   }

   %brightness = $pref::Video::brightness;
   %this-->OptBrightnessSlider.setValue(%brightness * $precision);
   %this-->TxtEditBrightness.setValue(mFloatLength(%brightness, 2));


   %grassRenderingDistance = $pref::TS::grassRenderingDistance;
   %this-->OptGrassRenderingDistanceSlider.setValue(%grassRenderingDistance);
   %this-->TxtEditGrassRenderingDistance.setValue(mFloatLength(%grassRenderingDistance, 2));

   %shadowDistance = $pref::Video::ShadowDistance;
   %this-->OptShadowDistanceSlider.setValue(%shadowDistance);
   %this-->TxtEditShadowDistance.setValue(%shadowDistance);
   
	%cameraFOV = $pref::player::CurrentFOV;
	%this-->OptCameraFOVSlider.setValue(%cameraFOV);
	%this-->TxtEditCameraFOV.setValue(%cameraFOV);

	%this-->OptGraphicsPresetMenu.createObjectTooltip(1065);
	%this-->OptGraphicsResolutionMenu.createObjectTooltip(1066);
	%this-->OptGraphicsFullscreenToggle.createObjectTooltip(1067);
	%this-->OptGraphicsVSyncToggle.createObjectTooltip(1068);
	%this-->OptAdjustQualityToggle.createObjectTooltip(1069);
	%this-->OptBrightnessSlider.createObjectTooltip(1070);
	%this-->OptAAQualityPopup.createObjectTooltip(1071);
	%this-->OptGraphicsShadowsMenu.createObjectTooltip(1072);
	%this-->OptGraphicsReflectionsMenu.createObjectTooltip(1073);
	%this-->OptAmbientOcclusionToggle.createObjectTooltip(1074);
	%this-->OptDepthOfFieldToggle.createObjectTooltip(1075);
	%this-->OptColorGradingToggle.createObjectTooltip(1076);
	%this-->OptLightRaysToggle.createObjectTooltip(1077);
	%this-->OptGrassRenderingDistanceSlider.createObjectTooltip(1078);
	%this-->OptTreeSlider.createObjectTooltip(1079);
	%this-->OptTreeDistanceSlider.createObjectTooltip(1080);
	%this-->OptObjectSlider.createObjectTooltip(1081);
	%this-->RenderingDistanceText.createObjectTooltip(1082);
	%this-->OptSmallSlider.createObjectTooltip(1083);
	%this-->OptBigSlider.createObjectTooltip(1084);
	%this-->OptHugeSlider.createObjectTooltip(1085);
	%this-->OptShadowDistanceSlider.createObjectTooltip(1481);
	
	// set olds
	%this.setOlds();

   // Update the state of the apply button.
   %this._updateApplyState();
   $applied = false;
}

function OptionsVideoDlg::aaNameToIndex(%this, %aaName)
{
	for(%i = 0; %i < $AA::OptionsArrSize; %i++)
	{
		if(%aaName $= $AA::OptionsArr[%i])
			return %i;
	}
	return 0;
}

function OptionsVideoDlg::aaIndexToName(%this, %aaIdx)
{
	if(%aaIdx >= $AA::OptionsArrSize)
		%aaIdx = ($AA::OptionsArrSize - 1); // max setting
	if(%aaIdx >= 0)
		return $AA::OptionsArr[%aaIdx];

	return $AA::OptionsArr[0];
}

function OptionsVideoDlg::_smallSliderChanged(%this)
{
	%value = %this-->OptSmallSlider.getValue();

	//preset check
	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::renderingDistanceSmall[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


   %this-->TxtEditSmall.setValue(%value);
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditSmallChanged(%this)
{
	%value = mFloatLength(%this-->TxtEditSmall.getValue(), 1);

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::renderingDistanceSmall[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	if (%value < getWord(%this-->OptSmallSlider.range, 0))
		%value = getWord(%this-->OptSmallSlider.range, 0);
	else if (%value > getWord(%this-->OptSmallSlider.range, 1))
		%value = getWord(%this-->OptSmallSlider.range, 1);

    %this-->OptSmallSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_bigSliderChanged(%this)
{
	%value = %this-->OptBigSlider.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::renderingDistanceBig[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


   %this-->TxtEditBig.setValue(%value);
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditBigChanged(%this)
{
	%value = %this-->TxtEditBig.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::renderingDistanceBig[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


	if (%value < getWord(%this-->OptBigSlider.range, 0))
		%value = getWord(%this-->OptBigSlider.range, 0);
	else if (%value > getWord(%this-->OptBigSlider.range, 1))
		%value = getWord(%this-->OptBigSlider.range, 1);

    %this-->OptBigSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_hugeSliderChanged(%this)
{
	%value = %this-->OptHugeSlider.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::renderingDistanceHuge[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

   %this-->TxtEditHuge.setValue(%value);
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditHugeChanged(%this)
{
	%value = %this-->TxtEditHuge.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::renderingDistanceHuge[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	if (%value < getWord(%this-->OptHugeSlider.range, 0))
		%value = getWord(%this-->OptHugeSlider.range, 0);
	else if (%value > getWord(%this-->OptHugeSlider.range, 1))
		%value = getWord(%this-->OptHugeSlider.range, 1);

    %this-->OptHugeSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_treeSliderChanged(%this)
{
	%value = %this-->OptTreeSlider.getValue() / $precision;

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::detailAdjustForest[%preset])
			%this-->OptGraphicsPresetMenu.setSelected($custom);

   %this-->TxtEditTree.setValue(mFloatLength(%value, 2));
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditTreeChanged(%this)
{
	%value = %this-->TxtEditTree.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::detailAdjustForest[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	%value *= $precision;

	if (%value < getWord(%this-->OptTreeSlider.range, 0))
		%value = getWord(%this-->OptTreeSlider.range, 0);
	else if (%value > getWord(%this-->OptTreeSlider.range, 1))
		%value = getWord(%this-->OptTreeSlider.range, 1);

    %this-->OptTreeSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_treeDistanceSliderChanged(%this)
{
	%value = %this-->OptTreeDistanceSlider.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::DistanceForestRender[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


   %this-->TxtEditTreeDistance.setValue(%value);
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditTreeDistanceChanged(%this)
{
	%value = %this-->TxtEditTreeDistance.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::DistanceForestRender[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	if (%value < getWord(%this-->OptTreeDistanceSlider.range, 0))
		%value = getWord(%this-->OptTreeDistanceSlider.range, 0);
	else if (%value > getWord(%this-->OptTreeDistanceSlider.range, 1))
		%value = getWord(%this-->OptTreeDistanceSlider.range, 1);

    %this-->OptTreeDistanceSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_objectSliderChanged(%this)
{
	%value = %this-->OptObjectSlider.getValue() / $precision;

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::detailAdjust[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


   %this-->TxtEditObject.setValue(mFloatLength(%value, 2));
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditObjectChanged(%this)
{
	%value = %this-->TxtEditObject.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::detailAdjust[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	%value *= $precision;

	if (%value < getWord(%this-->OptObjectSlider.range, 0))
		%value = getWord(%this-->OptObjectSlider.range, 0);
	else if (%value > getWord(%this-->OptObjectSlider.range, 1))
		%value = getWord(%this-->OptObjectSlider.range, 1);

    %this-->OptObjectSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_autoAdjustClick(%this)
{
   %this-->OptTreeSlider.setActive(!%this-->OptTreeSlider.isActive());
   %this-->OptObjectSlider.setActive(!%this-->OptObjectSlider.isActive());
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_brightnessSliderChanged(%this)
{
   %brightness = %this-->OptBrightnessSlider.getValue();
   %this-->TxtEditBrightness.setValue(mFloatLength(%brightness / $precision, 2));
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditBrightnessChanged(%this)
{
	%value = %this-->TxtEditBrightness.getValue();
	%value *= $precision;

	if (%value < getWord(%this-->OptBrightnessSlider.range, 0))
		%value = getWord(%this-->OptBrightnessSlider.range, 0);
	else if (%value > getWord(%this-->OptBrightnessSlider.range, 1))
		%value = getWord(%this-->OptBrightnessSlider.range, 1);

    %this-->OptBrightnessSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::AAQualityChanged(%this)
{
	%value = %this-->OptAAQualityPopup.getSelected();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::antiAliasing[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::ShadowsMenuChanged(%this)
{
	%value = %this-->OptGraphicsShadowsMenu.getSelected();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::shadowsQuality[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::WaterMenuChanged(%this)
{
	%value = %this-->OptWaterQualityPopup.getSelected();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::waterQuality[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::TerrainMenuChanged(%this)
{
	%value = %this-->OptTerrainQualityPopup.getSelected();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::terrainQuality[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::ParticlesCountMenuChanged(%this)
{
	%value = %this-->OptParticlesCountPopup.getSelected();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::particlesCount[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::LightingMenuChanged(%this)
{
	%value = %this-->OptLightingQualityPopup.getSelected();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::lightingQuality[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::TextureMenuChanged(%this)
{
	%value = %this-->OptTextureQualityPopup.getSelected();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::textureMode[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::ReflectionsChanged(%this)
{
	%value = %this-->OptGraphicsReflectionsToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::reflectionsMode[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::AnisotropicFilteringChanged(%this)
{
   %value = %this-->OptAnisotropicFilteringToggle.getValue() ? 16 : 1;

   %preset = %this-->OptGraphicsPresetMenu.getSelected();
   if (%preset != $custom && %value != $preset::anisotropicFiltering[%preset])
      %this-->OptGraphicsPresetMenu.setSelected($custom);

   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::AmbientOcclusionChanged(%this)
{
	%value = %this-->OptAmbientOcclusionToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::EnableSSAO[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

   OptionsVideoDlg._updateApplyState();
}


function OptionsVideoDlg::LensFlareChanged(%this)
{
	%value = %this-->OptLensFlareToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::EnableLensFlare[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::EProxyHighQualityChanged(%this)
{
    %value = %this-->OptEProxyHighQualityToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::EProxyHighQuality[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::FilmGrainChanged(%this)
{
	%value = %this-->OptFilmGrainToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::EnableFilmGrain[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::AdvancedWeatherChanged(%this)
{
	%value = %this-->OptAdvancedWeather.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::AdvancedWeather[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::DepthOfFieldChanged(%this)
{
	%value = %this-->OptDepthOfFieldToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::EnableDOF[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::ColorGradingChanged(%this)
{
	%value = %this-->OptColorGradingToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::EnableColorGrading[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::LightRaysChanged(%this)
{
	%value = %this-->OptLightRaysToggle.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %value != $preset::EnableLightRays[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_grassRenderingDistanceSliderChanged(%this)
{
	%value = %this-->OptGrassRenderingDistanceSlider.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %grassRenderingDistance != $preset::grassRenderingDistance[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);

	%this-->TxtEditGrassRenderingDistance.setValue(mFloatLength(%value, 2));
	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditGrassRenderingDistanceChanged(%this)
{
	%value = %this-->TxtEditGrassRenderingDistance.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %grassRenderingDistance != $preset::grassRenderingDistance[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


	if (%value < getWord(%this-->OptGrassRenderingDistanceSlider.range, 0))
		%value = getWord(%this-->OptGrassRenderingDistanceSlider.range, 0);
	else if (%value > getWord(%this-->OptGrassRenderingDistanceSlider.range, 1))
		%value = getWord(%this-->OptGrassRenderingDistanceSlider.range, 1);

    %this-->OptGrassRenderingDistanceSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_shadowDistanceSliderChanged(%this)
{
	%value = %this-->OptShadowDistanceSlider.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %shadowDistance != $preset::shadowDistance[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


   %this-->TxtEditShadowDistance.setValue(%value);
   OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_txtEditShadowDistanceChanged(%this)
{
	%value = %this-->TxtEditShadowDistance.getValue();

	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	if (%preset != $custom && %shadowDistance != $preset::shadowDistance[%preset])
		%this-->OptGraphicsPresetMenu.setSelected($custom);


	if (%value < getWord(%this-->OptShadowDistanceSlider.range, 0))
		%value = getWord(%this-->OptShadowDistanceSlider.range, 0);
	else if (%value > getWord(%this-->OptShadowDistanceSlider.range, 1))
		%value = getWord(%this-->OptShadowDistanceSlider.range, 1);

    %this-->OptShadowDistanceSlider.setValue(%value);
    OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_cameraFOVSliderChanged(%this)
{
	%value = %this-->OptCameraFOVSlider.getValue();

   %this-->TxtEditCameraFOV.setValue(%value);
   OptionsVideoDlg._updateApplyState();
}

function _makePrettyResString( %resString )
{
   %width = getWord( %resString, $WORD::RES_X );
   %height = getWord( %resString, $WORD::RES_Y );

   %aspect = %width / %height;
   %aspect = mRound( %aspect * 100 ) * 0.01;

   switch$( %aspect )
   {
      case "1.33":
         %aspect = "4:3";
      case "1.78":
         %aspect = "16:9";
      default:
         %aspect = "";
   }

   %outRes = %width @ " x " @ %height;
   if ( %aspect !$= "" )
      %outRes = %outRes @ "  (" @ %aspect @ ")";

   return %outRes;
}

function OptionsVideoDlg::initResMenu( %this )
{
   // Clear out previous values
   %resMenu = %this-->OptGraphicsResolutionMenu;
   %resMenu.clear();

   // If we are in a browser then we can't change our resolution through
   // the options dialog
   if (getWebDeployment())
   {
      %count = 0;
      %currRes = getWords(Canvas.getVideoMode(), $WORD::RES_X, $WORD::RES_Y);
      %resMenu.add(%currRes, %count);
      %count++;

      return;
   }

   // Loop through all and add all valid resolutions
   %count = 0;
   %resCount = Canvas.getModeCount();
   for (%i = 0; %i < %resCount; %i++)
   {
      %testResString = Canvas.getMode( %i );
      %testRes = _makePrettyResString( %testResString );

      // Only add to list if it isn't there already.
      if (%resMenu.findText(%testRes) == -1)
      {
         %resMenu.add(%testRes, %i);
         %count++;
      }
   }

   %resMenu.sort(false);
}

function OptionsVideoDlg::buildVideoMode(%this)
{
	// Gather the new video mode.
   if ( isFunction("getWebDeployment") && getWebDeployment() )
   {
      // Under web deployment, we use the custom resolution rather than a Canvas
      // defined one.
      %newRes = %this-->OptGraphicsResolutionMenu.getText();
   }
   else
   {
      %newRes = getWords( Canvas.getMode( %this-->OptGraphicsResolutionMenu.getSelected() ), $WORD::RES_X, $WORD::RES_Y );
   }

   %newBpp        = 32; // ... its not 1997 anymore.
   %display_mode = %this-->OptGraphicsFullscreenToggle.getSelected();

   %newFullScreen = false;
   %newBorderless = false;

   if (%display_mode == 1)
      %newBorderless = true;
   else if (%display_mode == 2)
      %newFullScreen = true;

   // Under web deployment we can't be full screen.
   if (isFunction("getWebDeployment") && getWebDeployment())
   {
      %newFullScreen = false;
   }
   else if (%newFullScreen == false)
   {
      // If we're in windowed mode switch the fullscreen check
      // if the resolution is bigger than the desktop.
      %deskRes    = getDesktopResolution();
      %deskResX   = getWord(%deskRes, $WORD::RES_X);
      %deskResY   = getWord(%deskRes, $WORD::RES_Y);
      if (  getWord( %newRes, $WORD::RES_X ) > %deskResX ||
            getWord( %newRes, $WORD::RES_Y ) > %deskResY )
      {
         %newFullScreen = true;
         %newBorderless = false;
         %this-->OptGraphicsFullscreenToggle.setSelected(2); //FullScreen
      }
   }

   // Build the final mode string.
   %newMode = %newRes SPC %newFullScreen SPC %newBpp SPC /*%newRefresh*/"60" SPC "0"/*%newFSAA*/ SPC %newBorderless;

   return %newMode;
}

function OptionsVideoDlg::applyGraphics( %this, %testNeedApply )
{
   %newVsync = !%this-->OptGraphicsVSyncToggle.getValue();
   %newMode = OptionsVideoDlg.buildVideoMode();
   %newFSAA = %this-->OptAAQualityPopup.getSelected();

   %reloadAllShaders = false;
   %setDisplayMode = false;
   // Change the video mode.
   if (  %newMode !$= $pref::Video::mode ||
         %newVsync != $pref::Video::disableVerticalSync )
   {
      if ( %testNeedApply )
         return true;

      $pref::Video::mode = %newMode;
      $pref::Video::disableVerticalSync = %newVsync;
      configureCanvas();

      %setDisplayMode = true;
   }

   if ( %newFSAA != %this.aaNameToIndex($pref::Video::AntiAliasing))
   {
      if ( %testNeedApply )
         return true;

      %this.changeAntiAliasing(%newFSAA);
      $pref::Video::AntiAliasing = %this.aaIndexToName(%newFSAA);
   }


   %reflections = %this-->OptGraphicsReflectionsToggle.getValue();
   if (%reflections != !$pref::Video::DisableReflections)
   {
      if (%testNeedApply)
         return true;

      $pref::Video::DisableReflections = !%reflections;	// $pref::Video::reflectionsMode = %reflections;
   }

   %anisotropicFiltering = %this-->OptAnisotropicFilteringToggle.getValue() ? 16 : 1;
   if (%anisotropicFiltering != $pref::Video::defaultAnisotropy)
   {
      if (%testNeedApply)
         return true;

      $pref::Video::defaultAnisotropy = %anisotropicFiltering;
   }

   // !!!
   /*%softShadows = %this-->OptSoftShadowsToggle.getValue();
   if (%softShadows != $PostFXManager::PostFX::EnableColorGrading)
   {
		if (%testNeedApply)
			return true;

		$PostFXManager::PostFX::EnableColorGrading = %softShadows;
   }*/

   %ssao = %this-->OptAmbientOcclusionToggle.getValue();
   if (%ssao != $pref::Video::EnableSSAO)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::EnableSSAO = %ssao;

		if ( $pref::Video::EnableSSAO )
         SSAOPostFx.enable();
		else
         SSAOPostFx.disable();
   }

   %lensflare = %this-->OptLensFlareToggle.getValue();
   if(%lensflare != $pref::Video::EnableLensFlare)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::EnableLensFlare = %lensflare;

		if ( $pref::Video::EnableLensFlare )
         PseudoLensFlarePFX.enable();
		else
         PseudoLensFlarePFX.disable();
        %reloadAllShaders = true;
   }
   
   %eproxyHighQuality = %this-->OptEProxyHighQualityToggle.getValue();
   if(%eproxyHighQuality != $pref::Video::EProxyHighQuality)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::EProxyHighQuality = %eproxyHighQuality;
   }
        

   %filmgrain = %this-->OptFilmGrainToggle.getValue();
   if(%filmgrain != $pref::Video::EnableFilmGrain)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::EnableFilmGrain = %filmgrain;

		if ( $pref::Video::EnableFilmGrain )
         FilmGrainPostFX.enable();
		else
         FilmGrainPostFX.disable();
        %reloadAllShaders = true;
   }

   %weather = %this-->OptAdvancedWeather.getValue();
   if(%weather != $pref::Weather::IsEnabled)
   {
      if (%testNeedApply)
         return true;

      $pref::Weather::IsEnabled = %weather;
   }

   %dof = %this-->OptDepthOfFieldToggle.getValue();
   if (%dof != $pref::Video::EnableDOF)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::EnableDOF = %dof;
        %reloadAllShaders = true;

   }

   %colorGrading = %this-->OptColorGradingToggle.getValue();
   if (%colorGrading != $pref::Video::EnableColorGrading)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::EnableColorGrading = %colorGrading;

		if ( $pref::Video::EnableColorGrading)
         ColorGradingPostFx.enable();
		else
         ColorGradingPostFx.disable();
        %reloadAllShaders = true;
   }

   %lightRays = %this-->OptLightRaysToggle.getValue();
   if (%lightRays != $pref::Video::EnableLightRays)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::EnableLightRays = %lightRays;

		if ( $pref::Video::EnableLightRays )
         LightRayPostFX.enable();
		else
         LightRayPostFX.disable();
   }

   /*%brightScalar = %this-->OptLightRaysBrightSlider.getValue() / $precision;
   if (%brightScalar != $LightRayPostFX::brightScalar)
   {
		if (%testNeedApply)
			return true;

		$LightRayPostFX::brightScalar = %brightScalar;
	}*/

   %smallObjects = %this-->OptSmallSlider.getValue();
   if ( %smallObjects != $pref::TS::renderingDistanceSmall )
   {
      if ( %testNeedApply )
         return true;

      $pref::TS::renderingDistanceSmall = %smallObjects;
   }

   %bigObjects = %this-->OptBigSlider.getValue();
   if ( %bigObjects != $pref::TS::renderingDistanceBig )
   {
      if ( %testNeedApply )
         return true;

      $pref::TS::renderingDistanceBig = %bigObjects;
   }

   %hugeObjects = %this-->OptHugeSlider.getValue();
   if ( %hugeObjects != $pref::TS::renderingDistanceHuge )
   {
      if ( %testNeedApply )
         return true;

      $pref::TS::renderingDistanceHuge = %hugeObjects;
   }

   %treeLOD = %this-->OptTreeSlider.getValue() / $precision;
   if ( %treeLOD != $pref::TS::detailAdjustForest )
   {
      if ( %testNeedApply )
         return true;

      $pref::TS::detailAdjustForest = %treeLOD;
   }

   %treeDistance = %this-->OptTreeDistanceSlider.getValue();
   if ( %treeDistance != $pref::Video::DistanceForestRender )
   {
      if ( %testNeedApply )
         return true;

      $pref::Video::DistanceForestRender = %treeDistance;
   }

   %objectLOD = %this-->OptObjectSlider.getValue() / $precision;
   if ( %objectLOD != $pref::TS::detailAdjust )
   {
      if ( %testNeedApply )
         return true;

      $pref::TS::detailAdjust = %objectLOD;
   }

   %autoAdjust = %this-->OptAdjustQualityToggle.getValue();
   if ( %autoAdjust != $pref::TS::autoAdjustQuality )
   {
      if ( %testNeedApply )
         return true;

      $pref::TS::autoAdjustQuality = %autoAdjust;
   }

   %brightness = %this-->OptBrightnessSlider.getValue() / $precision;
   if ( %brightness != $pref::Video::brightness )
   {
      if ( %testNeedApply )
         return true;

      $pref::Video::brightness = %brightness;
	  $ComboPFX::brightness = %brightness;
   }

   /*%enablePostFX = %this-->OptPostFXEnableToggle.getValue();
   if (%enablePostFX != $pref::Video::enablePostEffects)
   {
	  if (%testNeedApply)
		return true;

	  $pref::Video::enablePostEffects = %enablePostFX;
	  PostFXManager.settingsSetEnabled(%enablePostFX);
   }*/

   %grassRenderingDistance = %this-->OptGrassRenderingDistanceSlider.getValue();
   if ( %grassRenderingDistance != $pref::TS::grassRenderingDistance )
   {
      if ( %testNeedApply )
         return true;

      $pref::TS::grassRenderingDistance = %grassRenderingDistance;
   }

   %shadowDistance = %this-->OptShadowDistanceSlider.getValue();
   if ( %shadowDistance != $pref::Video::ShadowDistance )
   {
      if ( %testNeedApply )
         return true;

      $pref::Video::ShadowDistance = %shadowDistance;
   }
   
	%cameraFOV = %this-->OptCameraFOVSlider.getValue();
	if ( %cameraFOV != $pref::player::CurrentFOV )
	{
		if ( %testNeedApply )
			return true;

		$pref::player::CurrentFOV = %cameraFOV;
		setFov(%cameraFOV);
	}

   %shadows = %this-->OptGraphicsShadowsMenu.getSelected();
   if (%shadows != $pref::Video::ShadowQuality)
   {
		if (%testNeedApply)
			return true;

		switch (%shadows)
		{
		case 0:
			$pref::Video::DisableShadows = 1;
			$pref::Video::ForestCastShadows = 0;
			$pref::Video::SunShadowmapSize = "4096";
		case 1:
			$pref::Video::DisableShadows = 0;
			$pref::Video::ForestCastShadows = 0;
			$pref::Video::SunShadowmapSize = "4096";
		case 2:
			$pref::Video::DisableShadows = 0;
			$pref::Video::ForestCastShadows = 1;
			$pref::Video::SunShadowmapSize = "4096";
		case 3:
			$pref::Video::DisableShadows = 0;
			$pref::Video::ForestCastShadows = 1;
			$pref::Video::SunShadowmapSize = "4096";
		case 4:
			$pref::Video::DisableShadows = 0;
			$pref::Video::ForestCastShadows = 1;
			$pref::Video::SunShadowmapSize = "8192";
		}

		$pref::Video::ShadowQuality = %shadows;
		%reloadAllShaders = true;
   }

	%water = %this-->OptWaterQualityPopup.getSelected();
	if (%water != $pref::Video::waterQuality)
	{
		if (%testNeedApply)
			return true;

		$pref::Video::waterQuality = %water;
		reloadWater();
	}

	 %terrain = %this-->OptTerrainQualityPopup.getSelected();
	if (%terrain != $pref::Video::terrainQuality)
	{
		if (%testNeedApply)
			return true;

		$pref::Video::terrainQuality = %terrain;
		reloadTerrain();
	}
	
	%particlesCount = %this-->OptParticlesCountPopup.getSelected();
	if (%particlesCount != $pref::Video::particlesCount)
	{
		if (%testNeedApply)
			return true;

		$pref::Video::particlesCount = %particlesCount;
	}


	%lighting = %this-->OptLightingQualityPopup.getSelected();
	if (%lighting != $pref::Video::lightingQuality)
	{
		if (%testNeedApply)
			return true;

		$pref::Video::lightingQuality = %lighting;
        %reloadAllShaders = true;
        configureCanvas();
	}

   if (%setDisplayMode == true)
   {
      %display_mode = %this-->OptGraphicsFullscreenToggle.getSelected();
      if (%display_mode == 3)
      {
         $pref::gui::autoMaximizeOnLaunch = true;
         Canvas.maximizeWindow();
      }
      else
      {
         $pref::gui::autoMaximizeOnLaunch = false;
         Canvas.restoreWindow();
      }
   }

   %texture = %this-->OptTextureQualityPopup.getSelected();
   if (%texture != $pref::Video::textureReductionLevel)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::textureReductionLevel = %texture;
		reloadTextures();
		reloadStreamableTextures();
   }

   %preset = %this-->OptGraphicsPresetMenu.getSelected();
   if (%preset != $pref::Video::preset)
   {
		if (%testNeedApply)
			return true;

		$pref::Video::preset = %preset;
   }

   if(%reloadAllShaders == true)
   {
		reloadAllShaders();
   }

   // If we're applying the state then recheck the
   // state to update the apply button.
   if ( !%testNeedApply )
      %this._updateApplyState();

   if ( %testNeedApply )
      cleanupTexturePool();

   return false;
}

function toggleBorderlessWindow()
{
   $pref::GFX::BorderlessWindow = !$pref::GFX::BorderlessWindow;
   $pref::Video::mode = setWord($pref::Video::mode, $WORD::BORDERLESS, $pref::GFX::BorderlessWindow);
   $pref::Video::mode = setWord($pref::Video::mode, $WORD::FULLSCREEN, false);
   configureCanvas();
}

function OptionsVideoDlg::checkdResolutionMenu(%this)
{
	%display_mode = %this-->OptGraphicsFullscreenToggle.getSelected();
	if (%display_mode == 1 || %display_mode == 3)
	{
		%this-->OptGraphicsResolutionMenu.setActive(false);
		%this-->OptGraphicsResolutionMenu.textXMLID = 2499;
	}
	else
	{
		%this-->OptGraphicsResolutionMenu.setActive(true);
		%this-->OptGraphicsResolutionMenu.textXMLID = 0;
		%this-->OptGraphicsResolutionMenu.setSelected(%this-->OptGraphicsResolutionMenu.getSelected());
	}
}

function OptionsVideoDlg::changedWindowMode(%this)
{
	OptionsVideoDlg.checkdResolutionMenu();
	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_updateApplyState( %this )
{
	echo("_updateApplyState");
   %applyCtrl = %this-->Apply;

   assert( isObject( %applyCtrl ) );

   %applyCtrl.active = %this.applyGraphics( true );
   $applied = !%applyCtrl.active;
}

function OptionsVideoDlg::_autoDetectQuality( %this )
{
   %msg = GraphicsQualityAutodetect();
   %this.onWake();

   if ( %msg !$= "" )
   {
      MessageBoxOK( "Notice", %msg );
   }
}

function OptionsVideoDlg::_applyAndClose(%this)
{
   if (!$applied)
      OptionsVideoDlg.applyGraphics();

   Canvas.popDialog(OptionsVideoDlg);
   OptionsVideoDlg.safeDeleteObject();
}

function OptionsVideoDlg::changeAntiAliasing(%this, %newAA)
{
	PostFXManager.aaSetEnabled(%this.aaIndexToName(%newAA));
}

function changePreset(%preset)
{
	if (%preset $= $custom)
		return;

	if (OptionsVideoDlg-->OptAAQualityPopup.getSelected() !$= $preset::antiAliasing[%preset])
	{
		OptionsVideoDlg-->OptAAQualityPopup.setSelected($preset::antiAliasing[%preset]);
	}

	if (OptionsVideoDlg-->OptGraphicsShadowsMenu.getSelected() !$= $preset::shadowsMode[%preset])
	{
		OptionsVideoDlg-->OptGraphicsShadowsMenu.setSelected($preset::shadowsMode[%preset]);
	}


	if (OptionsVideoDlg-->OptWaterQualityPopup.getSelected() !$= $preset::waterQuality[%preset])
	{
		OptionsVideoDlg-->OptWaterQualityPopup.setSelected($preset::waterQuality[%preset]);
	}

	if (OptionsVideoDlg-->OptTerrainQualityPopup.getSelected() !$= $preset::terrainQuality[%preset])
	{
		OptionsVideoDlg-->OptTerrainQualityPopup.setSelected($preset::terrainQuality[%preset]);
	}
	
	if (OptionsVideoDlg-->OptParticlesCountPopup.getSelected() !$= $preset::particlesCount[%preset])
	{
		OptionsVideoDlg-->OptParticlesCountPopup.setSelected($preset::particlesCount[%preset]);
	}

	if (OptionsVideoDlg-->OptTextureQualityPopup.getSelected() !$= $preset::textureReductionLevel[%preset])
	{
		OptionsVideoDlg-->OptTextureQualityPopup.setSelected($preset::textureReductionLevel[%preset]);
	}

	if (OptionsVideoDlg-->OptLightingQualityPopup.getSelected() !$= $preset::lightingQuality[%preset])
	{
		OptionsVideoDlg-->OptLightingQualityPopup.setSelected($preset::lightingQuality[%preset]);
	}


	if (OptionsVideoDlg-->OptGraphicsReflectionsToggle.getValue() !$= $preset::reflectionsMode[%preset])
	{
		OptionsVideoDlg-->OptGraphicsReflectionsToggle.setStateOn($preset::reflectionsMode[%preset]);
	}
	if (OptionsVideoDlg-->OptAnisotropicFilteringToggle.getValue() !$= $preset::anisotropicFiltering[%preset])
	{
		OptionsVideoDlg-->OptAnisotropicFilteringToggle.setStateOn($preset::anisotropicFiltering[%preset] == 16);
	}
	if (OptionsVideoDlg-->OptSoftShadowsToggle.getValue() !$= $preset::softShadows[%preset])
	{
		OptionsVideoDlg-->OptSoftShadowsToggle.setStateOn($preset::softShadows[%preset]);
	}
	if (OptionsVideoDlg-->OptAmbientOcclusionToggle.getValue() !$= $preset::EnableSSAO[%preset])
	{
		OptionsVideoDlg-->OptAmbientOcclusionToggle.setStateOn($preset::EnableSSAO[%preset]);
	}

	if (OptionsVideoDlg-->OptFilmGrainToggle.getValue() !$= $preset::EnableFilmGrain[%preset])
	{
		OptionsVideoDlg-->OptFilmGrainToggle.setStateOn($preset::EnableFilmGrain[%preset]);
	}
	if (OptionsVideoDlg-->OptLensFlareToggle.getValue() !$= $preset::EnableLensFlare[%preset])
	{
		OptionsVideoDlg-->OptLensFlareToggle.setStateOn($preset::EnableLensFlare[%preset]);
	}
	if (OptionsVideoDlg-->OptEProxyHighQualityToggle.getValue() !$= $preset::EnableEProxyHighQuality[%preset])
	{
		OptionsVideoDlg-->OptEProxyHighQualityToggle.setStateOn($preset::EnableEProxyHighQuality[%preset]);
	}
	if (OptionsVideoDlg-->OptDepthOfFieldToggle.getValue() !$= $preset::EnableDOF[%preset])
	{
		OptionsVideoDlg-->OptDepthOfFieldToggle.setStateOn($preset::EnableDOF[%preset]);
	}
	if (OptionsVideoDlg-->OptAdvancedWeather.getValue() !$= $preset::AdvancedWeather[%preset])
	{
		OptionsVideoDlg-->OptAdvancedWeather.setStateOn($preset::AdvancedWeather[%preset]);
	}
	if (OptionsVideoDlg-->OptColorGradingToggle.getValue() !$= $preset::EnableColorGrading[%preset])
	{
		OptionsVideoDlg-->OptColorGradingToggle.setStateOn($preset::EnableColorGrading[%preset]);
	}
	if (OptionsVideoDlg-->OptLightRaysToggle.getValue() !$= $preset::EnableLightRays[%preset])
	{
		OptionsVideoDlg-->OptLightRaysToggle.setStateOn($preset::EnableLightRays[%preset]);
	}
	if (OptionsVideoDlg-->OptSmallSlider.getValue() !$= $preset::renderingDistanceSmall[%preset])
	{
		OptionsVideoDlg-->OptSmallSlider.setValue($preset::renderingDistanceSmall[%preset]);
		OptionsVideoDlg-->TxtEditSmall.setValue(mFloatLength($preset::renderingDistanceSmall[%preset], 2));
	}
	if (OptionsVideoDlg-->OptBigSlider.getValue() !$= $preset::renderingDistanceBig[%preset])
	{
		OptionsVideoDlg-->OptBigSlider.setValue($preset::renderingDistanceBig[%preset]);
		OptionsVideoDlg-->TxtEditBig.setValue(mFloatLength($preset::renderingDistanceBig[%preset], 2));
	}
	if (OptionsVideoDlg-->OptHugeSlider.getValue() !$= $preset::renderingDistanceHuge[%preset])
	{
		OptionsVideoDlg-->OptHugeSlider.setValue($preset::renderingDistanceHuge[%preset]);
		OptionsVideoDlg-->TxtEditHuge.setValue(mFloatLength($preset::renderingDistanceHuge[%preset], 2));
	}
	if (OptionsVideoDlg-->OptTreeSlider.getValue() / $precision !$= $preset::detailAdjustForest[%preset])
	{
		OptionsVideoDlg-->OptTreeSlider.setValue($preset::detailAdjustForest[%preset] * $precision);
		OptionsVideoDlg-->TxtEditTree.setValue(mFloatLength($preset::detailAdjustForest[%preset], 2));
	}
	if (OptionsVideoDlg-->OptTreeDistanceSlider.getValue() !$= $preset::DistanceForestRender[%preset])
	{
		OptionsVideoDlg-->OptTreeDistanceSlider.setValue($preset::DistanceForestRender[%preset]);
		OptionsVideoDlg-->TxtEditTreeDistance.setValue($preset::DistanceForestRender[%preset]);
	}
	if (OptionsVideoDlg-->OptObjectSlider.getValue() / $precision !$= $preset::detailAdjust[%preset])
	{
		OptionsVideoDlg-->OptObjectSlider.setValue($preset::detailAdjust[%preset] * $precision);
		OptionsVideoDlg-->TxtEditObject.setValue(mFloatLength($preset::detailAdjust[%preset], 2));
	}
	if (OptionsVideoDlg-->OptGrassRenderingDistanceSlider.getValue() !$= $preset::grassRenderingDistance[%preset])
	{
		OptionsVideoDlg-->OptGrassRenderingDistanceSlider.setValue($preset::grassRenderingDistance[%preset]);
		OptionsVideoDlg-->TxtEditGrassRenderingDistance.setValue(mFloatLength($preset::grassRenderingDistance[%preset], 2));
	}
	if (OptionsVideoDlg-->OptShadowDistanceSlider.getValue() !$= $preset::shadowDistance[%preset])
	{
		OptionsVideoDlg-->OptShadowDistanceSlider.setValue($preset::shadowDistance[%preset]);
		OptionsVideoDlg-->TxtEditShadowDistance.setValue($preset::shadowDistance[%preset]);
	}
}

function OptionsVideoDlg::presetPopUpMenuChanged(%this)
{
	%preset = %this-->OptGraphicsPresetMenu.getSelected();
	changePreset(%preset);
	OptionsVideoDlg._updateApplyState();
}

function OptionsVideoDlg::_cancelAndClose(%this)
{
   if ($applied)
   {
   	%this.restoreOlds();
   }
   $ComboPFX::brightness = $pref::Video::brightness;
   Canvas.popDialog(OptionsVideoDlg);
   OptionsVideoDlg.safeDeleteObject();
}

function OptionsVideoDlg::saveSettings(%this)
{
    exportPrefs();
	//PostFXManager::savePresetHandler($PostFXManager::userSettingsFilePath);
}

function GuiCanvas::onFullScreenToggled(%this, %newValue)
{
   //OptionsVideoDlg-->OptGraphicsFullscreenToggle.setStateOn(%newValue);
   $pref::Video::mode = OptionsVideoDlg.buildVideoMode();
   configureCanvas();
}

function addDropDown(%id_label, %popup_name, %popup_command)
{
   %gui = new GuiControl() {
      position = "0 0";
      extent = "739 90";
      minExtent = "8 2";
      horizSizing = "width";
      profile = "GuiDefaultProfile";

      new GuiTextCtrl() {
         text = GetMessageIDText(%id_label);
         maxLength = "255";
         margin = "0 0 0 0";
         padding = "0 0 0 0";
         anchorTop = "1";
         anchorBottom = "0";
         anchorLeft = "1";
         anchorRight = "0";
         position = "38 10";
         extent = "500 35";
         minExtent = "8 8";
         profile = "optionsVideoTextProfile";
      };

      new GuiPopUpMenuCtrlEx()
      {
         position = "14 40";
         extent = "650 52";
         Profile = "CreateCharWindowPopUpProfile";
         backPnlProfile = "GuiPopUpBorder";
         buttonOffset = 5;
         cellHeight = 46;
         createScrollCommand = "createPopUpScroll();";
         maxPopupHeight = 235;
         leftIndentMenu = 24;
         rightIndentMenu = 24;
         addScrollSize = "-3 0";
         horizSizing = "width";
         menuOffset = 0;
         command = %popup_command;
         internalName = %popup_name;
      };
   };//control

   return %gui;
}

function addCheckBoxRow(%id_label_left, %id_descrip_left, %name_check_box_left, %command_check_box_left, %id_label_right, %id_descrip_right, %name_check_box_right, %command_check_box_right)
{
   %gui = new GuiStackControl()
   {
      StackingType = "Horizontal";
      DynamicSize = "1";
      ChangeChildSizeToFit = "0";
      ChangeChildPosition = "1";
      dynamicNonStackExtent = true;
      isContainer = "1";
      profile = "GuiBaseTextProfile";
      position = "0 0";
      MinExtent = "16 16";
      LeftIndent = "18";
      padding = 0;
   };

   %cb = addCheckBox(%id_label_left, %id_descrip_left, %name_check_box_left, %command_check_box_left);
   %gui.add(%cb);

   if (%name_check_box_right !$= "")
   {
      %cb = addCheckBox(%id_label_right, %id_descrip_right, %name_check_box_right, %command_check_box_right);
      %gui.add(%cb);
   }
   return %gui;
}

function addCheckBox(%id_label, %id_descrip, %name_check_box, %command_check_box)
{
   %gui = new GuiStackControl()
   {
      StackingType = "Horizontal";
      DynamicSize = "1";
      ChangeChildSizeToFit = "0";
      ChangeChildPosition = "0";
      dynamicNonStackExtent = true;
      isContainer = "1";
      profile = "GuiBaseTextProfile";
      padding = 9;

      new GuiBigSmallCheckBoxCtrl()
      {
         position = "0 0";
         extent = "65 36";
         buttonType = "ToggleButton";
         profile = "GuiAtlas3ImageProfile";
         visible = "1";
         active = "1";
         isBig = "1";
         bitmapMode = "centered";
         internalName = %name_check_box;
         vertSizing = "center";
         command = %command_check_box;
      };

      new GuiStackControl()
      {
         StackingType = "Vertical";
         Padding = "0";
         DynamicSize = "1";
         ChangeChildSizeToFit = "0";
         ChangeChildPosition = 1;
         dynamicNonStackExtent = true;
         isContainer = "1";
         profile = "GuiBaseTextProfile";
         position = "0 5";

         new GuiTextCtrl()
         {
            text = GetMessageIDText(%id_label);
            position = "0 0";
            extent = "235 30";
            profile = "optionsVideoCheckBoxTextProfile";
            canHit = "false";
            visible = "1";
         };

         new GuiMLTextCtrl()
         {
            text = GetMessageIDText(%id_descrip);
            position = "0 0";
            lineSpacing = "0";
            bottomOffset = "0";
            extent = "235 10";
            profile = "optionsVideoTextProfile";
            canHit = "false";
            visible = "0";
            vertSizing = "center";
         };
      };
   };

   return %gui;
}

function addArrowSlider(%id_label, %slider_range, %slider_name, %slider_command, %text_edit_name, %text_edit_command, %id_descrip)
{
	%gui = new GuiStackControl()
	{
		StackingType = "Vertical";
		Padding = "0";
		DynamicSize = "1";
		ChangeChildSizeToFit = "0";
		ChangeChildPosition = "0";
		dynamicNonStackExtent = true;
		isContainer = "1";
		profile = "GuiBaseTextProfile";
		position = "0 0";
		Extent = "0 0";
		LeftIndent = "0";
		padding = -3;

		new GuiTextCtrl() 
		{
			text = GetMessageIDText(%id_label);
			maxLength = "255";
			margin = "0 0 0 0";
			padding = "0 0 0 0";
			anchorTop = "1";
			anchorBottom = "0";
			anchorLeft = "1";
			anchorRight = "0";
			position = "35 0";
			extent = "500 32";
			profile = "optionsVideoTextProfile";
		};

		new GuiStackControl()
		{
			StackingType = "Horizontal";
			Padding = "0";
			DynamicSize = "1";
			ChangeChildSizeToFit = "0";
			ChangeChildPosition = "0";
			dynamicNonStackExtent = true;
			isContainer = "1";
			profile = "GuiBaseTextProfile";
			position = "35 10";
			Extent = "0 0";
			LeftIndent = "0";
			padding = 10;

			new CmGuiArrowSliderCtrl()
			{
				ticks = "0";
				snap = "0";
				value = "1";
				position = "0 2";
				extent = "500 32";
				profile = "GuiHorizSliderProfile";
				active = "1";
				range = %slider_range;
				altCommand = %slider_command;
				internalName = %slider_name;
				useMouseWheel = "0";
				trackVOffset = "8";
				thumbOffset = "0 0";
			};

			new GuiControl()
			{
				position = "10 1";
				extent = "80 35";
				profile = GuiAtlas3TiledImageProfile;
				visible = "1";
				active = "1";
				isContainer = "1";

				leftIndex0 = SmallHexagonalTextFieldLeft;
				backgroundIndex = SmallHexagonalTextFieldCenter;
				rightIndex0 = SmallHexagonalTextFieldRight;

				new GuiTextEditSliderCtrl()
				{
					renderArrow = "false";
					increment = "1";
					focusOnMouseWheel = "0";
					historySize = "0";
					tabComplete = "0";
					sinkAllKeyEvents = "0";
					text = "0";
					maxLength = "1024";
					position = "10 0";
					extent = "60 35";
					horizSizing = "right";
					vertSizing = "bottom";
					profile = "CreateCharButtonProfile";
					visible = "1";
					active = "1";
					command = %text_edit_command;
					internalName = %text_edit_name;
				};
			};

			new GuiMLTextCtrl()
			{
				text = GetMessageIDText(%id_descrip);
				position = "0 0";
				lineSpacing = "0";
				bottomOffset = "0";
				extent = "300 10";
				profile = "optionsVideoTextProfile";
				canHit = "false";
				visible = "0";
				vertSizing = "center";
			};
		};
	};

	return %gui;
}
