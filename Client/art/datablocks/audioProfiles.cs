//-----------------------------------------------------------------------------
// Torque
// Copyright GarageGames, LLC 2011
//-----------------------------------------------------------------------------
// Always declare audio Descriptions (the type of sound) before Profiles (the
// sound itself) when creating new ones.
// ----------------------------------------------------------------------------
// Now for the profiles - these are the usable sounds
// ----------------------------------------------------------------------------


//-----------------------------------------------------------------------------

/*
datablock SFXProfile(ThrowSnd)
{
   filename = "art/sound/throw";
   description = AudioClose3d;
   preload = false;
};

datablock SFXProfile(OOBWarningSnd)
{
   filename = "art/sound/orc_pain";
   description = "AudioLoop2D";
   preload = false;
};
*/

//-----------------------------------------------------------------------------
datablock SFXProfile( ArrowFlySound) {
 local = 1;
 filename = "art/sound/SFX/weapon_arrow_swish_01";
 description = AudioClosestLoop3D;
 dopplerFactor = 0;
 reverbDopplerFactor = 0;
 fadeInTime = 0.4;
 fadeInTime = 0.2;
 useCustomReverb = true;
};
//-----------------------------------------------------------------------------
datablock SFXProfile( BoltFlySound) {
 local = 1;
 filename = "art/sound/SFX/weapon_bolt_swish_01";
 description = AudioClosestLoop3D;
 dopplerFactor = 10;
 reverbDopplerFactor = 10;
 fadeInTime = 0.4;
 fadeInTime = 0.2;
 useCustomReverb = false;
};
//-----------------------------------------------------------------------------
datablock SFXProfile( ThrowingFlySound) {
	local = 1;
	filename = "art/sound/SFX/weapon_throwing_swish_01";
//	filename = "art/sound/SFX/weapon_throwing_swish_02";
//	filename = "art/sound/SFX/weapon_throwing_swish_03";
	description = AudioClosest3D;
};
datablock SFXProfile( SiegeFlySound) {
   local = 1;
   filename = "art/sound/SFX/trebuchet_projectile_swish_01";
   description = AudioClosest3D;
};//звук полета осадного снаряда

//-----------------------------------------------------------------------------
datablock SFXProfile(TrebuchetShot)
{
   local = 1;
   filename = "art/sound/SFX/trebuchet_shot_01.ogg";
   description = AudioOutlyingLoop3D;
};//звук работы требушета
//----------------------------------------------------------------------------
// Horse sounds
/*
datablock SFXProfile( horse_hindlegs) {
   id = 357 ;
   filename = "art/sound/horse/horse_hindlegs";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_pant) {
   id = 358 ;
   filename = "art/sound/horse/horse_pant";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_death) {
   id = 359 ;
   filename = "art/sound/horse/horse_death_01";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_damage) {
   id = 360 ;
   filename = "art/sound/horse/horse_damage_01";
   description = HorseAudioLoop;
};
*/
//-----------------------------------------------------------------------------
datablock SFXProfile(TerFallSound)
{
   local = 1;
   filename = "art/sound/SFX/downfall.ogg";
   description = AudioDefaultLoop3D;
};

//Animal death sounds profiles {
datablock SFXProfile(BearDeathSound)
{
   local = 1;
   filename = "art/sound/animals/bear_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(WildHorseDeathSound)
{
   local = 1;
   filename = "art/sound/animals/wildhorse_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(DeerDeathSound)
{
   local = 1;
   filename = "art/sound/animals/deer_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(WolfDeathSound)
{
   local = 1;
   filename = "art/sound/animals/wolf_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(MooseDeathSound)
{
   local = 1;
   filename = "art/sound/animals/moose_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(BoarDeathSound)
{
   local = 1;
   filename = "art/sound/animals/boar_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(MuttonDeathSound)
{
   local = 1;
   filename = "art/sound/animals/mutton_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(AurochsDeathSound)
{
   local = 1;
   filename = "art/sound/animals/aurochs_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(GrouseDeathSound)
{
   local = 1;
   filename = "art/sound/animals/grouse_death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(HareDeathSound)
{
   local = 1;
   filename = "art/sound/animals/hare_death.ogg";
   description = AudioDefault3D;
};

//Knool Death sound by Zbig Brodaty
datablock SFXProfile(TribeB_DeathSound)
{
   local = 1;
   filename = "art/sound/Tribe/TribeB_Death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(TribeC_DeathSound)
{
   local = 1;
   filename = "art/sound/Tribe/TribeC_Death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(TribeH_DeathSound)
{
   local = 1;
   filename = "art/sound/Tribe/TribeH_Death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(TribeM_DeathSound)
{
   local = 1;
   filename = "art/sound/Tribe/TribeM_Death.ogg";
   description = AudioDefault3D;
};

datablock SFXProfile(TribeW_DeathSound)
{
   local = 1;
   filename = "art/sound/Tribe/TribeW_Death.ogg";
   description = AudioDefault3D;
};
//Knool Sound
//} Animal death sounds profiles


//Ambient sounds
datablock SFXProfile(EnvFireSmallSound)
{
   local = 1;
   filename = "art/sound/SFX/env_fire_small.ogg";
   description = AudioDefaultLoop3D;
};

datablock SFXProfile(env_barn)
{
   local = 1;
   filename = "art/sound/SFX/env_barn.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_barn_cow)
{
   local = 1;
   filename = "art/sound/SFX/env_barn_cow.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_barn_sheep)
{
   local = 1;
   filename = "art/sound/SFX/env_barn_sheep.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_beehive)
{
   local = 1;
   filename = "art/sound/SFX/env_beehive.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_bloomery)
{
   local = 1;
   filename = "art/sound/SFX/env_bloomery.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_cauldron)
{
   local = 1;
   filename = "art/sound/SFX/env_cauldron.ogg";
   description = AudioClosestLoop3D;
};
datablock SFXProfile(env_coop)
{
   local = 1;
   filename = "art/sound/SFX/env_coop.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_coop_cock)
{
   local = 1;
   filename = "art/sound/SFX/env_coop_cock.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_desert_sand_debris)
{
   local = 1;
   filename = "art/sound/SFX/env_desert_sand_debris.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_desert_noise)
{
   local = 1;
   filename = "art/sound/SFX/env_desert_noise.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_desert_wind)
{
   local = 1;
   filename = "art/sound/SFX/env_desert_wind.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_fire)
{
   local = 1;
   filename = "art/sound/SFX/env_fire.ogg";
   description = AudioObjectsDefaultLoop3D;
};
datablock SFXProfile(env_fire_medium)
{
   local = 1;
   filename = "art/sound/SFX/env_fire_small.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_fire_oven)
{
   local = 1;
   filename = "art/sound/SFX/env_fire_oven.ogg";
   description = AudioObjectsNearLoop3D;
};
datablock SFXProfile(env_fire_small)
{
   local = 1;
   filename = "art/sound/SFX/env_fire_small.ogg";
   description = AudioObjectsClosestLoop3D;
};
datablock SFXProfile(env_forest_bird)
{
   local = 1;
   filename = "art/sound/SFX/env_forest_bird.ogg";
//   description = AudioDefaultLoop3D;
   description = AudioClosest3D;
};
datablock SFXProfile(env_forest_owl)
{
   local = 1;
   filename = "art/sound/SFX/env_forest_owl.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_forest_pecker)
{
   local = 1;
   filename = "art/sound/SFX/env_forest_pecker.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_forest_creak)
{
   local = 1;
   filename = "art/sound/SFX/env_forest_creak.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_forest_insect)
{
   local = 1;
   filename = "art/sound/SFX/env_forest_insect.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_forest_rustle)
{
   local = 1;
   filename = "art/sound/SFX/env_forest_rustle.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_forge)
{
   local = 1;
   filename = "art/sound/SFX/env_forge.ogg";
   description = AudioFarLoop3D;
};
datablock SFXProfile(env_fountain)
{
   local = 1;
   filename = "art/sound/SFX/env_fountain.ogg";
   description = AudioObjectsCloseLoop3D;
};
datablock SFXProfile(env_indoor_loop_day)
{
   local = 1;
   filename = "art/sound/SFX/env_indoor_loop_day.ogg";
   description = AudioLoop2D;
};
datablock SFXProfile(env_indoor_loop_night)
{
   local = 1;
   filename = "art/sound/SFX/env_indoor_loop_night.ogg";
   description = AudioLoop2D;
};
datablock SFXProfile(env_indoor_noise)
{
   local = 1;
   filename = "art/sound/SFX/env_indoor_noise.ogg";
   description = AudioLoop2D;
};
datablock SFXProfile(env_mountains_bird)
{
   local = 1;
   filename = "art/sound/SFX/env_mountains_bird.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_mountains_debris)
{
   local = 1;
   filename = "art/sound/SFX/env_mountains_debris.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_mountains_debris2)
{
   local = 1;
   filename = "art/sound/SFX/env_mountains_debris2.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_mountains_wind)
{
   local = 1;
   filename = "art/sound/SFX/env_mountains_wind.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_outdoor_loop_day)
{
   local = 1;
   filename = "art/sound/SFX/env_outdoor_loop_day.ogg";
   description = AudioLoop2D;
};
datablock SFXProfile(env_outdoor_loop_night)
{
   local = 1;
   filename = "art/sound/SFX/env_outdoor_loop_night.ogg";
   description = AudioLoop2D;
};
datablock SFXProfile(env_rainfall)
{
   local = 1;
   filename = "art/sound/SFX/env_rainfall.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_ruins)
{
   local = 1;
   filename = "art/sound/SFX/env_ruins.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_snow_bird)
{
   local = 1;
   filename = "art/sound/SFX/env_snow_bird.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_snow_crackle)
{
   local = 1;
   filename = "art/sound/SFX/env_snow_crackle.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_snow_wind)
{
   local = 1;
   filename = "art/sound/SFX/env_snow_wind.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_snowfall)
{
   local = 1;
   filename = "art/sound/SFX/env_snowfall.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_spinning_wheel)
{
   local = 1;
   filename = "art/sound/SFX/env_spinning_wheel.ogg";
   description = AudioObjectsCloseLoop3D;
};
datablock SFXProfile(env_stable)
{
   local = 1;
   filename = "art/sound/SFX/env_stable.ogg";
   description = AudioObjectsNearLoop3D;
};
datablock SFXProfile(env_stable_small)
{
   local = 1;
   filename = "art/sound/SFX/env_stable_small.ogg";
   description = AudioObjectsCloseLoop3D;
};
datablock SFXProfile(env_stable_horse)
{
   local = 1;
   filename = "art/sound/SFX/env_stable_horse.ogg";
   description = AudioObjectsFarLoop3D;
};
datablock SFXProfile(env_steppe_insect)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_insect.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_grasshopper)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_grasshopper.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_bee)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_bee.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_bird_fly)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_bird_fly.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_cricket)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_cricket.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_grass_rustle)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_grass_rustle.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_crow)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_crow.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_lark)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_lark.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_steppe_breeze)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_breeze.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_steppe_wind)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_wind.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_steppe_noise)
{
   local = 1;
   filename = "art/sound/SFX/env_steppe_noise.ogg";
   description = AudioClose3D;
};
datablock SFXProfile(env_swamp_bird)
{
   local = 1;
   filename = "art/sound/SFX/env_swamp_bird.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_swamp_bubble)
{
   local = 1;
   filename = "art/sound/SFX/env_swamp_bubble.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_swamp_frog)
{
   local = 1;
   filename = "art/sound/SFX/env_swamp_frog.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_swamp_toad)
{
   local = 1;
   filename = "art/sound/SFX/env_swamp_toad.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_swamp_insect)
{
   local = 1;
   filename = "art/sound/SFX/env_swamp_insect.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_swamp_water)
{
   local = 1;
   filename = "art/sound/SFX/env_swamp_water.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_swamp_water_loop)
{
   local = 1;
   filename = "art/sound/SFX/env_swamp_water.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(env_tanning_tub)
{
   local = 1;
   filename = "art/sound/SFX/env_tanning_tub.ogg";
   description = AudioObjectsCloseLoop3D;
};
datablock SFXProfile(env_thunder)
{
   local = 1;
   filename = "art/sound/SFX/env_thunder.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_underground_fire)
{
   local = 1;
   filename = "art/sound/SFX/env_underground_fire.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_underground_loop)
{
   local = 1;
   filename = "art/sound/SFX/env_underground_loop.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_underground_rumble)
{
   local = 1;
   filename = "art/sound/SFX/env_underground_rumble.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_underground_tap)
{
   local = 1;
   filename = "art/sound/SFX/env_underground_tap.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_warehouse)
{
   local = 1;
   filename = "art/sound/SFX/env_warehouse.ogg";
   description = AudioObjectsNearLoop3D;
};
datablock SFXProfile(env_warehouse_large)
{
   local = 1;
   filename = "art/sound/SFX/env_warehouse.ogg";
   description = AudioMediumLoop3D;
};
datablock SFXProfile(env_water_bird)
{
   local = 1;
   filename = "art/sound/SFX/env_water_bird.ogg";
   description = AudioClosest3D;
};
datablock SFXProfile(env_water_hum)
{
   local = 1;
   filename = "art/sound/SFX/env_water_hum.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(env_water_wave)
{
   local = 1;
   filename = "art/sound/SFX/env_water_wave.ogg";
   description = AudioWater3D;
};
datablock SFXProfile(env_watermill)
{
   local = 1;
   filename = "art/sound/SFX/env_watermill.ogg";
   description = AudioOutlyingLoop3D;
};
datablock SFXProfile(env_windmill)
{
   local = 1;
   filename = "art/sound/SFX/env_windmill.ogg";
   description = AudioObjectsOutlyingLoop3D;
};
datablock SFXProfile(env_wine_press)
{
   local = 1;
   filename = "art/sound/SFX/env_wine_press.ogg";
   description = AudioClosest3D;
};

//Player Ability Animations Sounds {
datablock SFXProfile(player_cooking)
{
   local = 1;
   filename = "art/sound/SFX/player_cooking_01.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(player_equip)
{
   local = 1;
   filename = "art/sound/SFX/player_equip_01.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(player_dig)
{
   local = 1;
   filename = "art/sound/SFX/player_dig_01.ogg";
   description = AudioNearLoop3D;
};
datablock SFXProfile(player_build)
{
   local = 1;
   filename = "art/sound/SFX/player_build_01.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(player_saw)
{
   local = 1;
   filename = "art/sound/SFX/player_saw_01.ogg";
   description = AudioMediumLoop3D;
};
datablock SFXProfile(player_plow)
{
   local = 1;
   filename = "art/sound/SFX/player_plow_01.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(player_mow)
{
   local = 1;
   filename = "art/sound/SFX/player_mow_01.ogg";
   description = AudioNearLoop3D;
};
datablock SFXProfile(player_nail)
{
   local = 1;
   filename = "art/sound/SFX/player_nail_01.ogg";
   description = AudioMediumLoop3D;
};
datablock SFXProfile(player_mine)
{
   local = 1;
   filename = "art/sound/SFX/player_mine_01.ogg";
   description = AudioOutlyingLoop3D;
};
datablock SFXProfile(player_drink)
{
   local = 1;
   filename = "art/sound/SFX/player_drink_01.ogg";
   description = AudioDefaultLoop3D;
};
datablock SFXProfile(player_eat)
{
   local = 1;
   filename = "art/sound/SFX/player_eat_01.ogg";
   description = AudioClosestLoop3D;
};
datablock SFXProfile(player_fishing)
{
   local = 1;
   filename = "art/sound/SFX/player_fishing_01.ogg";
   description = AudioNearLoop3D;
};
datablock SFXProfile(player_treecut)
{
   local = 1;
   filename = "art/sound/SFX/player_treecut_01.ogg";
   description = AudioOutlyingLoop3D;
};
datablock SFXProfile(player_skinrip)
{
   local = 1;
   filename = "art/sound/SFX/player_skinrip_01.ogg";
   description = AudioMediumLoop3D;
};
datablock SFXProfile(player_perform)
{
   local = 1;
   filename = "art/sound/SFX/player_perform_01.ogg";
   description = AudioClosestLoop3D;
};
datablock SFXProfile(player_pray)
{
   local = 1;
   filename = "art/sound/SFX/player_praying_01.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(player_smelting)
{
   local = 1;
   filename = "art/sound/SFX/player_smelting_01.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(player_smithing)
{
   local = 1;
   filename = "art/sound/SFX/player_smithing_01.ogg";
   description = AudioOutlyingLoop3D;
};
// } Player Ability Animations Sounds

//-----------------------------------------------------------------------------
datablock SFXProfile( WagonSound) {
	local = 1;
	filename = "art/sound/wagon_cycle3.ogg";
	description = WheelSound;
};
//-----------------------------------------------------------------------------
datablock SFXProfile( TorchFireSound) {
	local = 1;
	filename = "art/sound/SFX/torch_fire.ogg";
	description = AudioClosestLoop3D;
};
//-----------------------------------------------------------------------------
datablock SFXProfile( horse_move_walk_naked) {
   id = 274;
   filename = "art/sound/horse/horse_move_walk_naked";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_move_walk_armoured) {
   id = 275;
   filename = "art/sound/horse/horse_move_walk_armoured";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_move_trot_naked) {
   id = 276;
   filename = "art/sound/horse/horse_move_trot_naked";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_move_trot_armoured) {
   id = 277;
   filename = "art/sound/horse/horse_move_trot_armoured";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_move_gallop_naked) {
   id = 278;
   filename = "art/sound/horse/horse_move_gallop_naked";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_move_gallop_armoured) {
   id = 279;
   filename = "art/sound/horse/horse_move_gallop_armoured";
   description = HorseAudioLoop;
};

datablock SFXProfile( revoke_ritual )
{
   id = 1016;
   filename = "art/sound/SFX/player_praying_01.ogg";
   description = AudioObjectsFarLoop3D;
};

datablock SFXProfile( horse_idle) {
   id = 1018;
   filename = "art/sound/SFX/horse_idle_01";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_move_gallop_armoured_tremble) {
   id = 1019;
   filename = "art/sound/horse/horse_move_gallop_armoured_tremble";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_climbing) {
   id = 1022;
   filename = "art/sound/horse/horse_climbing_01";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_climbing_down) {
   id = 1023;
   filename = "art/sound/horse/horse_climbingdown_01";
   description = HorseAudioLoop;
};
datablock SFXProfile( horse_jump) {
   id = 1017;
   filename = "art/sound/horse/horse_jump_01";
   description = AudioClosest3D;
};
//-----------------------------------------------------------------------------
datablock SFXProfile(npc_blacksmith)
{
   local = 1;
   filename = "art/sound/SFX/npc_blacksmith_01.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(npc_gallow_a)
{
   local = 1;
   filename = "art/sound/SFX/npc_gallow_a_01.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(npc_gallow_b)
{
   local = 1;
   filename = "art/sound/SFX/npc_gallow_b_01.ogg";
   description = AudioCloseLoop3D;
};
datablock SFXProfile(npc_gallow_c)
{
   local = 1;
   filename = "art/sound/SFX/npc_gallow_c_01.ogg";
   description = AudioCloseLoop3D;
};
