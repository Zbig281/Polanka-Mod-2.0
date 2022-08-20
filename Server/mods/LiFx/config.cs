if (!isObject(LiFx))
{
  new ScriptObject(LiFx)
  {
  };
}

// Scripts
$LiFx::liveAlignmentActive = true;
$LiFx::offlineRaidProtectionActive = true;

/*****************************
*PVP Raid Protection
*
* raidProtection::timeToProtection- ime delay from last member of a claim disconnecting to when protection is applied.
*/
$LiFx::raidProtection::timeToProtection = 25;

/*****************************
*Live Alignment
*
* AlignmentUpdateDelta - How much alignments will the online player get?
* AlignmentUpdateMinutes - How many minutes should it go between updates
*/
$LiFx::AlignmentUpdateDelta = 1000;
$LiFx::AlignmentUpdateMinutes = 1;
