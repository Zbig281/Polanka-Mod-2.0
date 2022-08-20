//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------
function OptionsAudioDlg::onWake(%this)
{
   // Audio
   //OptAudioHardwareToggle.setStateOn($pref::SFX::useHardware);
   //OptAudioHardwareToggle.setActive( true );
   
   %this-->OptAudioVolumeMaster.setValue( $pref::SFX::masterVolume * 100 );
   //%this-->OptAudioVolumeShell.setValue( $pref::SFX::channelVolume[ $GuiAudioType] );
   %this-->OptAudioVolumeSim.setValue( $pref::SFX::channelVolume[ $SimAudioType ] * 100 );
   %this-->OptAudioVolumeMusic.setValue( $pref::SFX::channelVolume[ $MusicAudioType ] * 100 );
   %this-->OptAudioVolumeVoiceChat.setValue($pref::SFX::channelVolume[ $MessageAudioType ] * 100);
   %this-->OptAudioVolumeObjects.setValue($pref::SFX::channelVolume[ $ObjectsAudioType ] * 100);
   %this-->OptAudioPushToTalkCheckbox.setStateOn($pref::SFX::pushToTalkButtonEnabled);
   
   //$pref::SFX::provider = %text;
   OptAudioDeviceList.clear();
   
   %buffer = sfxGetAvailableDevices();
   %count = getRecordCount( %buffer );
	 %isHideNullProvider = (%count > 1);
   for(%i = 0; %i < %count; %i++)
   {
      %record = getRecord(%buffer, %i);
      %provider = getField(%record, 0);
      %device = getField(%record, 1);
      
      //if (%provider !$= $pref::SFX::provider)
      //   continue;

      // hide null device when we have some other device (when current provider is not null-provider)
      if(%isHideNullProvider && %provider $= "Null" && %provider !$= $pref::SFX::provider)
         continue;
            
       if ( OptAudioDeviceList.findText( %device ) == -1 )
            OptAudioDeviceList.add( %device, %i );
   }

   // Find the previous selected device.
   %selId = OptAudioDeviceList.findText($pref::SFX::device);
   if ( %selId == -1 )
      OptAudioDeviceList.setFirstSelected();
   else
      OptAudioDeviceList.setSelected( %selId );

   $oldMasterVolume = $pref::SFX::masterVolume;

   $channelVolume::previous[ $GuiAudioType ]       = $pref::SFX::channelVolume[ $MusicAudioType ];
   $channelVolume::previous[ $SimAudioType ]       = $pref::SFX::channelVolume[ $SimAudioType ];
   $channelVolume::previous[ $MessageAudioType ]   = $pref::SFX::channelVolume[ $MessageAudioType ];
   $channelVolume::previous[ $MusicAudioType ]     = $pref::SFX::channelVolume[ $MusicAudioType ];
   $channelVolume::previous[ $ObjectsAudioType ]   = $pref::SFX::channelVolume[ $ObjectsAudioType ];

   
   $oldPushToTalkButtonEnabled = $pref::SFX::pushToTalkButtonEnabled;
   $oldDevice = $pref::SFX::device;
}

$AudioTestHandle = 0;
// Description to use for playing the volume test sound.  This isn't
// played with the description of the channel that has its volume changed
// because we know nothing about the playback state of the channel.  If it
// is paused or stopped, the test sound would not play then.
if(!isObject($AudioTestDescription))
$AudioTestDescription = new SFXDescription()
{
   sourceGroup = AudioChannelMaster;
};

function OptAudioUpdateMasterVolume( %volume )
{
   if( %volume == $pref::SFX::masterVolume )
      return;
      
   sfxSetMasterVolume( %volume );
   $pref::SFX::masterVolume = %volume;
   
   if( !isObject( $AudioTestHandle ) )
      $AudioTestHandle = sfxPlayOnce( AudioChannel, "core/art/sound/volumeTest.wav" );
}

function OptAudioUpdateChannelVolume( %description, %volume )
{
   %channel = sfxGroupToOldChannel( %description.sourceGroup );

   if( %volume == $pref::SFX::channelVolume[ %channel ] )
      return;

   sfxSetChannelVolume( %channel, %volume );
   $pref::SFX::channelVolume[ %channel ] = %volume;
   
   if( !isObject( $AudioTestHandle ) )
   {
      $AudioTestDescription.volume = %volume;
      $AudioTestHandle = sfxPlayOnce( $AudioTestDescription, "core/art/sound/volumeTest.wav" );
   }
}

function OptAudioUpdateVoiceChatVolume(%volume)
{
	if (%volume == $pref::SFX::voiceChatVolume)
		return;

	sfxSetVoiceChatVolume(%volume);
	$pref::SFX::voiceChatVolume = %volume;
}

function OptionsAudioDlg::_updatePushToTalk(%this)
{
	%value = %this-->OptAudioPushToTalkCheckbox.getValue();
	if (%value == $pref::SFX::pushToTalkButtonEnabled)
		return;
	
	$pref::SFX::pushToTalkButtonEnabled = %value;
	if (%value)
	{
		steamVoice_popButton();
		if (isObject(PlayGui))
			PlayGui.disableVoiceChat();
	}
	else
	{
		steamVoice_pushButton();
		if (isObject(PlayGui))
			PlayGui.enableVoiceChat();
	}
}

function OptAudioDeviceList::onSelect( %this, %id, %text )
{
   // Skip empty selections.
   if ( %text $= "" )
      return;

   //WORKAROUND: only Null and FMOD devices allowed yet.
   //TODO: use actual provider here
   $pref::SFX::provider = (%text $= "SFX Null Device" ? "Null" : "FMOD");

   $pref::SFX::device = %text;
   
   stopMusic();
   schedule( 1000, 0, restartMusic);
}

function restartMusic() {
	if ( !sfxCreateDevice(  $pref::SFX::provider, $pref::SFX::device, $pref::SFX::useHardware, -1 ) ) {
		error( "Unable to create SFX device: " @ $pref::SFX::provider SPC $pref::SFX::device SPC $pref::SFX::useHardware );
	}
	startMusic();
}

function OptionsAudioDlg::cancelAndClose(%this)
{
	if ($pref::SFX::masterVolume != $oldMasterVolume)
	{
		OptAudioUpdateMasterVolume($oldMasterVolume);
	}

	if ($pref::SFX::channelVolume[ $GuiAudioType ] != $channelVolume::previous[ $GuiAudioType ])
	{
		OptAudioUpdateChannelVolume(AudioGui, $channelVolume::previous[ $GuiAudioType ]);
	}
	if ($pref::SFX::channelVolume[ $SimAudioType ] != $channelVolume::previous[ $SimAudioType ])
	{
		OptAudioUpdateChannelVolume(AudioEffect, $channelVolume::previous[ $SimAudioType ]);
	}
	if ($pref::SFX::channelVolume[ $MessageAudioType ] != $channelVolume::previous[ $MessageAudioType ])
	{
		OptAudioUpdateChannelVolume(AudioMessages, $channelVolume::previous[ $MessageAudioType ]);
	}
	if ($pref::SFX::channelVolume[ $MusicAudioType ] != $channelVolume::previous[ $MusicAudioType ])
	{
		OptAudioUpdateChannelVolume(AudioMusic, $channelVolume::previous[ $MusicAudioType ]);
	}
	if ($pref::SFX::channelVolume[ $ObjectsAudioType ] != $channelVolume::previous[ $ObjectsAudioType ])
	{
		OptAudioUpdateChannelVolume(AudioObjects, $channelVolume::previous[ $ObjectsAudioType ]);
	}

	if ($pref::SFX::pushToTalkButtonEnabled != $oldPushToTalkButtonEnabled)
	{
		%this._updatePushToTalk($oldPushToTalkButtonEnabled);
	}
	if ($pref::SFX::device != $oldDevice)
		$pref::SFX::device = $oldDevice;
   Canvas.popDialog(OptionsAudioDlg);
   OptionsAudioDlg.safeDeleteObject();
}

function OptionsAudioDlg::saveSettings(%this)
{
    exportPrefs();
}


/*
function OptAudioHardwareToggle::onClick(%this)
{
   if (!sfxCreateDevice($pref::SFX::provider, $pref::SFX::device, $pref::SFX::useHardware, -1))
      error("Unable to create SFX device: " @ $pref::SFX::provider SPC $pref::SFX::device SPC $pref::SFX::useHardware);
}
*/
