//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

datablock RangedWeaponData(BaseBow)
{
   local = true;

   // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "AmmoCheck";
   stateScript[0] = "onRangedImageReady";

   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   // stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnTriggerUp[1] = "Fire";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateSequence[1] = "Prefire"; // анимация в луке
   stateDirection[1] =true;      // с начала
   stateFreezeAnimation[1] =false;  // играть
   stateScript[1] = "onRangedImagePrefire";

   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   stateSequence[2] = "Prefire"; // анимация в луке
   stateDirection[2] =false;     // с конца
   stateFreezeAnimation[2] =true;   // стоять

   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;

   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onRangedImageFireCancel";

   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;       // будет просчитываться анимация персонажа
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onRangedImageFire";

   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onRangedImageFireCancel";

   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;

   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;

   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;

   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;

   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   stateScript[11] = "onRangedImageDraw";

   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   stateScript[12] = "onRangedImageInactive";

   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;

   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[16] = "AmmoCheck";
   stateFireSubState[16] = AmmoCheck;
   stateTransitionOnTriggerUp[16] = "AmmoCheckFailTimeout";
   stateWaitForTimeout[16] = false;

   stateName[17] = "AmmoCheckFailTimeout";
   stateTransitionOnTimeout[17] = "Ready";
   stateTimeoutValue[17] = 0.5;
};

datablock RangedWeaponData(CompositeBow : BaseBow)
{
   id = 52;
   Object_typeID = 603;

   AgilityNeed = 40.0;
   StrengthNeed = 30.0;
   MaxAccuracy = 0.8;
   Emax = 2.9;
   BasePrefireAnimTime = 1.3;
   BaseRecoilAnimTime = 1.2;
   allowedAmmoIDs = "656 657 658 659 660 1339 1582";
   DurabilityPerShot = 40.0;
   StaminaRate = 20.0;

   shapefile = "art/models/3d-2d/weapons/bows/composite_bow_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackBow;
   WeaponType = WeaponBow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};

datablock RangedWeaponData(SimpleBow : BaseBow)
{
   id = 49;
   Object_typeID = 600;

   AgilityNeed = 10.0;
   StrengthNeed = 10.0;
   MaxAccuracy = 1.2;
   Emax = 1.9;
   BasePrefireAnimTime = 1.3;
   BaseRecoilAnimTime = 1.2;
   allowedAmmoIDs = "656 657 658 659 660 1339 1582";
   DurabilityPerShot = 40.0;
   StaminaRate = 20;

   shapefile = "art/models/3d-2d/weapons/bows/simple_bow_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackBow;
   WeaponType = WeaponBow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};

datablock RangedWeaponData(ShortBow : BaseBow)
{
   id = 50;
   Object_typeID = 601;

   AgilityNeed = 30.0;
   StrengthNeed = 20.0;
   MaxAccuracy = 0.9;
   Emax = 2.3;
   BasePrefireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.1;
   allowedAmmoIDs = "656 657 658 659 660 1339 1582";
   DurabilityPerShot = 20.0;
   StaminaRate = 10.0;

   shapefile = "art/models/3d-2d/weapons/bows/short_bow_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackBow;
   WeaponType = WeaponBow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};

datablock RangedWeaponData(LongBow : BaseBow)
{
   id = 51;
   Object_typeID = 602;

   AgilityNeed = 50.0;
   StrengthNeed = 40.0;
   MaxAccuracy = 0.5;
   Emax = 3.7;
   BasePrefireAnimTime = 1.7;
   BaseRecoilAnimTime = 1.3;
   allowedAmmoIDs = "656 657 658 659 660 1339 1582";
   DurabilityPerShot = 20.0;
   StaminaRate = 30;

   shapefile = "art/models/3d-2d/weapons/bows/longbow_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackBow;
   WeaponType = WeaponBow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};
//Hunterbow
datablock RangedWeaponData(LongBow : BaseBow)
{
   id = 51;
   Object_typeID = 3013;

   AgilityNeed = 50.0;
   StrengthNeed = 40.0;
   MaxAccuracy = 0.5;
   Emax = 3.7;
   BasePrefireAnimTime = 1.7;
   BaseRecoilAnimTime = 1.3;
   allowedAmmoIDs = "656 657 658 659 660 1339 1582";
   DurabilityPerShot = 20.0;
   StaminaRate = 30;

   shapefile = "art/models/3d-2d/weapons/Tribe/hunterbow.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackBow;
   WeaponType = WeaponBow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};

datablock RangedWeaponData(BaseCrossbow)
{
   local = true;

   // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "AmmoCheck";
   stateScript[0] = "onRangedImageReady";

   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   // stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnTriggerUp[1] = "Fire";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateSequence[1] = "Reload";  // анимация в оружии
   stateDirection[1] =true;      // с начала
   stateFreezeAnimation[1] =false;  // играть
   stateScript[1] = "onRangedImagePrefire";

   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   stateSequence[2] = "Reload";  // анимация в оружии
   stateDirection[2] =false;     // с конца
   stateFreezeAnimation[2] =true;   // стоять

   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;

   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onRangedImageFireCancel";

   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;       // будет просчитываться анимация персонажа
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onRangedImageFire";

   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onRangedImageFireCancel";

   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   // stateTransitionOnTimeout[7] = "PostFireWait";
   stateTransitionOnTimeout[7] = "Reload";
   stateAllowImageChange[7] = false;

   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;

   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;

   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;

   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Reload";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   stateScript[11] = "onRangedImageDraw";
   
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   stateScript[12] = "onRangedImageInactive";

   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;

   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[15] = "Reload";
   stateFireSubState[15] = Reload;
   stateTransitionOnTimeout[15] = "Reloaded";
   stateAllowImageChange[15] = false;

   stateName[16] = "AmmoCheck";
   stateFireSubState[16] = AmmoCheck;
   stateTransitionOnTriggerUp[16] = "AmmoCheckFailTimeout";
   stateWaitForTimeout[16] = false;

   stateName[17] = "AmmoCheckFailTimeout";
   stateTransitionOnTimeout[17] = "Ready";
   stateTimeoutValue[17] = 0.5;
   
   stateName[18] = "Reloaded";
   stateTransitionOnTimeout[18] = "Ready";
   stateAllowImageChange[18] = false;
   stateScript[18] = "onRangedImageReloaded";
};

datablock RangedWeaponData(LightCrossbow : BaseCrossbow)
{
   id = 53;
   Object_typeID = 604;

   AgilityNeed = 10.0;
   StrengthNeed = 15.0;
   MaxAccuracy = 0.9;
   Emax = 4.2;
   BasePrefireAnimTime = 0.8;
   BaseRecoilAnimTime = 1.0;
   allowedAmmoIDs = "662 663 664 1340 1583";
   DurabilityPerShot = 20.0;
   StaminaRate = 25.0;

   shapefile = "art/models/3d-2d/weapons/crossbows/light_crossbow_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackCrossbow;
   WeaponType = WeaponCrossbow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};

datablock RangedWeaponData(Arbalest : BaseCrossbow)
 {
   id = 54;
   Object_typeID = 605;

   AgilityNeed = 10.0;
   StrengthNeed = 20.0;
   MaxAccuracy = 0.8;
   Emax = 4.9;
   BasePrefireAnimTime = 0.8;
   BaseRecoilAnimTime = 1.1;
   allowedAmmoIDs = "662 663 664 1340 1583";
   DurabilityPerShot = 20.0;
   StaminaRate = 25.0;

   shapefile = "art/models/3d-2d/weapons/crossbows/arbalest_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackCrossbow;
   WeaponType = WeaponCrossbow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};

datablock RangedWeaponData(HeavyCrossbow : BaseCrossbow)
{
   id = 55;
   Object_typeID = 606;

   AgilityNeed = 10.0;
   StrengthNeed = 40.0;
   MaxAccuracy = 0.7;
   Emax = 5.6;
   BasePrefireAnimTime = 0.9;
   BaseRecoilAnimTime = 1.3;
   allowedAmmoIDs = "662 663 664 1340 1583";
   DurabilityPerShot = 20.0;
   StaminaRate = 50.0;

   shapefile = "art/models/3d-2d/weapons/crossbows/heavy_crossbow_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackCrossbow;
   WeaponType = WeaponCrossbow;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;
};

datablock RangedWeaponData(Sling)
{
   id = 56;
   Object_typeID = 607;

   AgilityNeed = 10.0;
   StrengthNeed = 10.0;
   MaxAccuracy = 1.9;
   Emax = 8.0;
   BasePrefireAnimTime = 1.0;
   BaseRecoilAnimTime = 0.8;
   allowedAmmoIDs = "1096";
   DurabilityPerShot = 20.0;
   StaminaRate = 20.0;

   shapefile = "art/models/3d-2d/weapons/ammunition/sling_export_01.dts";

   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackSling;
   WeaponType = WeaponSling;

   hitDirection[0] = ""; // Thrust
   hitDirection[1] = ""; // Overhead
   hitDirection[2] = ""; // RightToLeftHit
   hitDirection[3] = ""; // LeftToRightHit
   WoundMultiplier = "";
   FractureMultiplier = "";
   StunMultiplier = "";
   correctMuzzleVector = false;

   // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "AmmoCheck";
   stateScript[0] = "onRangedImageReady";

   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "Fire";
   stateTransitionOnAltTriggerDown[1] = "FireCancel"; //go back
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateSequence[1] = "Sling_prefire";	// анимация в оружии
   stateScript[1] = "onRangedImagePrefire";

   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "FireCancel"; //go back
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
   stateSequence[2] = "Sling_prefire";	// анимация в оружии

   // After trigger up on PreFire. Wait for timeout. Time delay inherits from previous state
   stateName[3] = "PreFire_onTrigerUp";
   stateFireSubState[3] = PreFire;
   stateTransitionOnTimeout[3] = "Fire";
   stateTransitionOnAltTriggerDown[3] = "FireCancel"; //go back
   stateWaitForTimeout[3] = false;
   stateAllowImageChange[3] = false;

   // Cancels hit
   stateName[4] = "FireCancel";
   stateTransitionOnTimeout[4] = "PostFireWait"; // go imediately
   stateAllowImageChange[4] = false;
   stateScript[4] = "onRangedImageFireCancel";

   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;			// будет просчитываться анимация персонажа
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onRangedImageFire";

   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onRangedImageFireCancel";

   // After hit
   stateName[7] = "PostFire";
   stateFireSubState[7] = Recoil;
   stateTransitionOnTimeout[7] = "PostFireWait";
   stateAllowImageChange[7] = false;

   // After hit. Wait for time
   stateName[8] = "PostFireWait";
   stateFireSubState[8] = PostFire;
   stateTimeoutValue[8] = 0.0; //wait a second
   stateTransitionOnTimeout[8] = "PostFireWaitForTriggerUp";
   stateAllowImageChange[8] = false;

   // After hit. Wait for trigger up
   stateName[9] = "PostFireWaitForTriggerUp";
   //stateFireSubState[9] = PostFire;
   stateTransitionOnTriggerUp[9] = "PostFireWaitForAltTriggerUp";
   stateAllowImageChange[9] = false;

   // And wait for alt trigger up as well
   stateName[10] = "PostFireWaitForAltTriggerUp";
   //stateFireSubState[10] = PostFire;
   stateTransitionOnAltTriggerUp[10] = "Ready";
   stateAllowImageChange[10] = false;

   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[11] = "Draw";
   stateFireSubState[11] = Draw;
   stateTransitionOnTimeout[11] = "Ready";
   stateWaitForTimeout[11] = true;
   stateAllowImageChange[11] = false;
   stateScript[11] = "onRangedImageDraw";
   
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   stateScript[12] = "onRangedImageInactive";

   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "BlockingReady";
   stateFireSubState[13] = Blocking;
   stateAllowImageChange[13] = false;

   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[14] = "BlockedHit";
   stateFireSubState[14] = BlockedHit;
   stateTransitionOnTimeout[14] = "BlockingReady";
   stateWaitForTimeout[14] = true;
   stateAllowImageChange[14] = false;

   stateName[16] = "AmmoCheck";
   stateFireSubState[16] = AmmoCheck;
   stateTransitionOnTriggerUp[16] = "AmmoCheckFailTimeout";
   stateWaitForTimeout[16] = false;

   stateName[17] = "AmmoCheckFailTimeout";
   stateTransitionOnTimeout[17] = "Ready";
   stateTimeoutValue[17] = 0.5;
};
