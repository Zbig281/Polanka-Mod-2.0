//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

// Attack types:
//  Attack1H
//  Attack2HSword
//  Attack2HWeapon
//  AttackPike
//  Attack1_2HSword
//  AttackBow
//  AttackCrossbow
//  AttackThrowing
//  AttackSpear

// Weapon types:
//  Weapon1_2HSword
//  Weapon1HAxe
//  Weapon1HMace
//  Weapon1HSword
//  Weapon2HAxe
//  Weapon2HMace
//  Weapon2HSword
//  WeaponBow
//  WeaponCrossbow
//  WeaponLance
//  WeaponPike
//  WeaponPolearm
//  WeaponSpear
//  WeaponThrowing
//  WeaponShield
//  WeaponMisc

// HitGroup types:
//  Slashing
//  Piercing
//  Chopping
//  Siege
//  Blunt

datablock ShapeBaseImageData(BaseMeleeWeapon)
{
   local = true;
   BasePrefireAnimTime = 1;
   BaseFireAnimTime = 1;
   BaseRecoilAnimTime = 1;

   // Ready to hit. Just waiting for the trigger
   stateName[0] = "Ready";
   stateTransitionOnTriggerDown[0] = "PreFire";
   stateTransitionOnAltTriggerDown[0] = "PreBlocking";
   // PreFire. Almost hit. Timeout depends on current animation
   stateName[1] = "PreFire";
   stateFireSubState[1] = PreFire;
   stateTransitionOnTimeout[1] = "PreFire_onTimeout";
   stateTransitionOnTriggerUp[1] = "PreFire_onTrigerUp";
   stateTransitionOnAltTriggerDown[1] = "PreBlocking";
   stateWaitForTimeout[1] = false;
   stateAllowImageChange[1] = false;
   stateScript[1] = "onImagePrefire";
   // After timeout onPreFire. Wait for trigger up.
   stateName[2] = "PreFire_onTimeout";
   stateFireSubState[2] = PreFire;
   stateTransitionOnTriggerUp[2] = "Fire";
   stateTransitionOnAltTriggerDown[2] = "PreBlocking";
   stateAllowImageChange[2] = false;
   //stateTransitionOnTimeout[2] = "Fire";
   //stateWaitForTimeout[2] = false;
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
   stateScript[4] = "onImageFireCancel";
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   stateTransitionOnTimeout[5] = "PostFire";
   stateTransitionOnAltTriggerDown[5] = "FireCancelRecoil"; // force
   stateWaitForTimeout[5] = false;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // Cancels hit with recoil
   stateName[6] = "FireCancelRecoil";
   stateTransitionOnTimeout[6] = "PostFire"; // go imediately
   stateAllowImageChange[6] = false;
   stateScript[6] = "onImageFireCancel";
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
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[13] = "PreBlocking";
   stateFireSubState[13] = PreBlocking;
   stateWaitForTimeout[13] = true;
   stateAllowImageChange[13] = false;
   stateTransitionOnTimeout[13] = "Blocking";
   
   stateName[14] = "Blocking";
   stateFireSubState[14] = Blocking;
   stateWaitForTimeout[14] = false;
   stateTimeoutValue[14] = 1.0; // active block in seconds
   stateAllowImageChange[14] = false;
   stateTransitionOnTimeout[14] = "PostFireWait";
   stateTransitionOnAltTriggerUp[14] = "Ready";
   // State for enemies' hit blocked (parryed). Manually-controlled state
   stateName[15] = "BlockedHit";
   stateFireSubState[15] = BlockedHit;
   stateTransitionOnTimeout[15] = "PostFireWait";
   stateWaitForTimeout[15] = true;
   stateAllowImageChange[15] = false;
   
   stateName[16] = "Trickmove";
   stateFireSubState[16] = Trickmove;
   stateTransitionOnTimeout[16] = "Ready";
   stateTransitionOnTriggerDown[16] = "PreFire";
   stateTransitionOnAltTriggerDown[16] = "PreBlocking";
   stateWaitForTimeout[16] = false;
   stateAllowImageChange[16] = false;
};

datablock ShapeBaseImageData(BaseShield)
{
   local = true;

   // Armed. Idle
   stateName[0] = "Ready";
   stateTransitionOnAltTriggerDown[0] = "PreBlocking";
   // Weapon draw from "Attach" to "Ready". Manually-controlled state
   stateName[1] = "Draw";
   stateFireSubState[1] = Draw;
   stateTransitionOnTimeout[1] = "Ready";
   stateWaitForTimeout[1] = true;
   stateAllowImageChange[1] = false;
   // Hit. Timeout depends on current animation
   stateName[5] = "Fire";
   stateFireSubState[5] = Fire;
   stateFire[5] = true;
   //stateTransitionOnTriggerUp[5] = "BlockingReady"; //go back
   //stateTransitionOnAltTriggerUp[5] = "Ready"; //go back
   stateTransitionOnTimeout[5] = "Blocking";
   stateWaitForTimeout[5] = true;
   stateAllowImageChange[5] = false;
   stateScript[5] = "onImageFire";
   // State for blocking(parryng) weapons. Manually-controlled state
   stateName[6] = "PreBlocking";
   stateFireSubState[6] = PreBlocking;
   stateWaitForTimeout[6] = true;
   stateAllowImageChange[6] = false;
   stateTransitionOnTimeout[6] = "Blocking";
   
   stateName[7] = "Blocking";
   stateFireSubState[7] = Blocking;
   stateAllowImageChange[7] = false;
   stateWaitForTimeout[7] = false;
   stateTransitionOnAltTriggerUp[7] = "Ready";
   
   // State for enemies' hit blocked(parryed). Manually-controlled state
   stateName[8] = "BlockedHit";
   stateFireSubState[8] = BlockedHit;
   stateTransitionOnTimeout[8] = "Blocking";
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
   
   // State for attached(inactive) weapons. Manually-controlled state
   stateName[12] = "Attach";
   stateFireSubState[12] = Attached;
   stateAllowImageChange[12] = true;

   stateName[15] = "Trickmove";
   stateFireSubState[15] = Trickmove;
   stateTransitionOnTimeout[15] = "Ready";
   stateTransitionOnTriggerDown[15] = "PreFire";
   stateWaitForTimeout[15] = false;
   stateAllowImageChange[15] = false;
};

datablock WeaponData(PracticeSword : BaseMeleeWeapon)
{
   id = 4;
   Object_typeID = 555;
   
   shapefile = "art/models/3d-2d/weapons/1hswords/practice_sword_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace; // sound hack
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeSwordItem;
};

datablock WeaponData(NordicSword : BaseMeleeWeapon)
{
   id = 5;
   Object_typeID = 556;
   
   shapefile = "art/models/3d-2d/weapons/1hswords/nordic_sword_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.55;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.83;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = NordicSwordItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.0;
};

datablock WeaponData(KnightSword : BaseMeleeWeapon)
{
   id = 6;
   Object_typeID = 557;
   
   shapefile = "art/models/3d-2d/weapons/1-2hswords/knight_sword_export_02.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.6;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.08;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = KnightSwordItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 0.9;
   BaseRecoilAnimTime = 0.9;
};

datablock WeaponData(LightSaber : BaseMeleeWeapon)
{
   id = 7;
   Object_typeID = 558;
   
   shapefile = "art/models/3d-2d/weapons/1hswords/light_saber_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.16;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.46;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0.9;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = LightSaberItem;
   BasePrefireAnimTime = 0.9;
   BaseFireAnimTime = 0.9;
   BaseRecoilAnimTime = 0.65;
};

datablock WeaponData(Scimitar : BaseMeleeWeapon)
{
   id = 8;
   Object_typeID = 559;
   
   shapefile = "art/models/3d-2d/weapons/1hswords/scimitar_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.9;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.01;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ScimitarItem;
   BasePrefireAnimTime = 0.9;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 0.8;
};

datablock WeaponData(Falchion : BaseMeleeWeapon)
{
   id = 9;
   Object_typeID = 560;
   
   shapefile = "art/models/3d-2d/weapons/1hswords/falchion_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.92;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.9;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0.7;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = FalchionItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 0.95;
   BaseRecoilAnimTime = 1.3;
};

datablock WeaponData(PracticeBastard : BaseMeleeWeapon)
{
   id = 10;
   Object_typeID = 561;
   
   shapefile = "art/models/3d-2d/weapons/1-2hswords/practice_bastard_sword_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.6;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.6;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeBastardItem;
};

datablock WeaponData(Estoc : BaseMeleeWeapon)
{
   id = 11;
   Object_typeID = 562;
   
   shapefile = "art/models/3d-2d/weapons/1-2hswords/estoc_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.7;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 0.8;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.5;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = EstocItem;
   BasePrefireAnimTime = 0.5;
   BaseFireAnimTime = 0.8;
   BaseRecoilAnimTime = 0.8;
};

datablock WeaponData(BastardSword : BaseMeleeWeapon)
{
   id = 12;
   Object_typeID = 563;
   
   shapefile = "art/models/3d-2d/weapons/1-2hswords/bastard.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.63;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 2.35;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BastardSwordItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1;
   BaseRecoilAnimTime = 0.9;
};

datablock WeaponData(BigFalchion : BaseMeleeWeapon)
{
   id = 13;
   Object_typeID = 564;
   
   shapefile = "art/models/3d-2d/weapons/1-2hswords/bigfalchion.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1_2HSword;
   WeaponType = Weapon1_2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.1;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.98;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0.7;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BigFalchionItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 0.95;
   BaseRecoilAnimTime = 1.2;
};

datablock WeaponData(GrossMesser : BaseMeleeWeapon)
{
   id = 14;
   Object_typeID = 565;
   
   shapefile = "art/models/3d-2d/weapons/1hswords/grossmesser_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.6;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.7;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = GrossMesserItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(PracticeAxe : BaseMeleeWeapon)
{
   id = 15;
   Object_typeID = 566;
   
   shapefile = "art/models/3d-2d/weapons/1haxes/practice_axe_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeAxeItem;
};

datablock WeaponData(WarAxe : BaseMeleeWeapon)
{
   id = 16;
   Object_typeID = 567;
   
   shapefile = "art/models/3d-2d/weapons/1haxes/waraxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.8;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 1.94;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 0.9;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = WarAxeItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};
//Hunter Axe
datablock WeaponData(Hunter_Axe : BaseMeleeWeapon)
{
   id = 16;
   Object_typeID = 3012;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/hunteraxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 2.2;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.4;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 2.1;
   FractureMultiplier = 2.1;
   StunMultiplier = 0.4;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HunterAxeItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(BattleAxe : BaseMeleeWeapon)
{
   id = 17;
   Object_typeID = 568;
   
   shapefile = "art/models/3d-2d/weapons/1haxes/battleaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.8;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 2.09;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.0;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1.8;
   FractureMultiplier = 0.9;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BattleAxeItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(NordicAxe : BaseMeleeWeapon)
{
   id = 18;
   Object_typeID = 569;
   
   shapefile = "art/models/3d-2d/weapons/1haxes/nordicaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HAxe;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.35;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 1.74;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1.5;
   FractureMultiplier = 0.9;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = NordicAxeItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(MorningStar : BaseMeleeWeapon)
{
   id = 19;
   Object_typeID = 570;
   
   shapefile = "art/models/3d-2d/weapons/1hmaces/morningstar.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.36;
   hitGroupType[1] = Piercing;
   hitGroupDmgLevel[1] = 1.69;
   hitGroupType[2] = Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MorningStarItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.2;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(FlangedMace : BaseMeleeWeapon)
{
   id = 20;
   Object_typeID = 571;
   
   shapefile = "art/models/3d-2d/weapons/1hmaces/flangedmace.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.8;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.79;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.1;
   FractureMultiplier = 0.7;
   StunMultiplier = 0.35;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = FlangedMaceItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(Cudgel : BaseMeleeWeapon)
{
   id = 21;
   Object_typeID = 572;
   
   shapefile = "art/models/3d-2d/weapons/1hmaces/cudgel.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.8;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = CudgelItem;
   BasePrefireAnimTime = 1;
   BaseFireAnimTime = 1;
   BaseRecoilAnimTime = 0.8;
};

datablock WeaponData(WarPick : BaseMeleeWeapon)
{
   id = 22;
   Object_typeID = 573;
   
   shapefile = "art/models/3d-2d/weapons/1hmaces/warpick.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = Weapon1HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.8;
   hitGroupType[1] = Piercing;
   hitGroupDmgLevel[1] = 1.31;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = WarPickItem;
   BasePrefireAnimTime = 0.8;
   BaseFireAnimTime = 0.9;
   BaseRecoilAnimTime = 1.4;
};

datablock WeaponData(PracticeLongsword : BaseMeleeWeapon)
{
   id = 23;
   Object_typeID = 574;
   
   shapefile = "art/models/3d-2d/weapons/2hswords/practice_longsword_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeLongswordItem;
};

datablock WeaponData(Claymore : BaseMeleeWeapon)
{
   id = 24;
   Object_typeID = 575;
   
   shapefile = "art/models/3d-2d/weapons/2hswords/claymore.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.9;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.65;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.15;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ClaymoreItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.2;
};

datablock WeaponData(Zweihaender : BaseMeleeWeapon)
{
   id = 25;
   Object_typeID = 576;
   
   shapefile = "art/models/3d-2d/weapons/2hswords/zweihander.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.07;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.6;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.1;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ZweihaenderItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.15;
};
//chieftainsword
datablock WeaponData(Chieftain_Sword : BaseMeleeWeapon)
{
   id = 25;
   Object_typeID = 3011;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/chieftainsword.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.10;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.9;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.0;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.6;
   FractureMultiplier = 0.7;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = chieftainswordItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.15;
};

datablock WeaponData(Flamberge : BaseMeleeWeapon)
{
   id = 26;
   Object_typeID = 577;
   
   shapefile = "art/models/3d-2d/weapons/2hswords/flamberge.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = Weapon2HSword;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.55;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.62;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.5;
   FractureMultiplier = 0.7;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = FlambergeItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.15;
};

datablock WeaponData(PracticeGreataxe : BaseMeleeWeapon)
{
   id = 27;
   Object_typeID = 578;
   
   shapefile = "art/models/3d-2d/weapons/2haxes/practice_greataxe_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeGreataxeItem;
};

datablock WeaponData(Pollaxe : BaseMeleeWeapon)
{
   id = 28;
   Object_typeID = 579;
   
   shapefile = "art/models/3d-2d/weapons/polearms/pollaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponPolearm;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.85;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 1.4;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 1.0;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 3"; // Overhead
   hitDirection[2] = "1 3"; // RightToLeftHit
   hitDirection[3] = "1 3"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.8;
   StunMultiplier = 0.21;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PollaxeItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(Bardiche : BaseMeleeWeapon)
{
   id = 29;
   Object_typeID = 580;
   
   shapefile = "art/models/3d-2d/weapons/2haxes/bardiche.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.96;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 1.5;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.7;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BardicheItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.7;
};

datablock WeaponData(BroadAxe : BaseMeleeWeapon)
{
   id = 30;
   Object_typeID = 581;
   
   shapefile = "art/models/3d-2d/weapons/2haxes/broad_axe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.72;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 1.6;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0.8;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BroadAxeItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.8;
};

datablock WeaponData(SledgeHammer : BaseMeleeWeapon)
{
   id = 31;
   Object_typeID = 582;
   
   shapefile = "art/models/3d-2d/weapons/2hmaces/sledgehammer.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.28;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2.0;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.9;
   StunMultiplier = 0.35;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SledgeHammerItem;
   BasePrefireAnimTime = 1.3;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.5;
};

datablock WeaponData(Maul : BaseMeleeWeapon)
{
   id = 32;
   Object_typeID = 583;
   
   shapefile = "art/models/3d-2d/weapons/2hmaces/maul.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.28;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2.07;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.80;
   StunMultiplier = 0.4;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MaulItem;
   BasePrefireAnimTime = 1.3;
   BaseFireAnimTime = 1.2;
   BaseRecoilAnimTime = 1.6;
};

datablock WeaponData(PracticeMaul : BaseMeleeWeapon)
{
   id = 33;
   Object_typeID = 584;
   
   shapefile = "art/models/3d-2d/weapons/2hmaces/practice_maul_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HMace;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.1;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PracticeMaulItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.2;
};
//bearaxe
datablock WeaponData(Bear_Axe : BaseMeleeWeapon)
{
   id = 33;
   Object_typeID = 3010;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/bearaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = Weapon2HAxe;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.9;
   hitGroupType[1] =  Chopping;
   hitGroupDmgLevel[1] = 1.8;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.7;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.7;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0.9;
   StunMultiplier = 0.00;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BearaxelItem;
   BasePrefireAnimTime = 1.3;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.8;
};

datablock WeaponData(Glaive : BaseMeleeWeapon)
{
   id = 34;
   Object_typeID = 585;
   
   shapefile = "art/models/3d-2d/weapons/polearms/glaive.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.28;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.52;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.4;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = GlaiveItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(Guisarme : BaseMeleeWeapon)
{
   id = 35;
   Object_typeID = 586;
   
   shapefile = "art/models/3d-2d/weapons/polearms/guisarme.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.16;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.48;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.7;
   FractureMultiplier = 0.1;
   StunMultiplier = 0.2;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = GuisarmeItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(WarScythe : BaseMeleeWeapon)
{
   id = 36;
   Object_typeID = 587;
   
   shapefile = "art/models/3d-2d/weapons/polearms/warscythe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.12;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.47;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitGroupType[3] =  Blunt;
   hitGroupDmgLevel[3] = 0.5;
   hitDirection[0] = "0 3"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.5;
   FractureMultiplier = 0.2;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = WarScytheItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(Pitchfork : BaseMeleeWeapon)
{
   id = 37;
   Object_typeID = 588;
   
   shapefile = "art/models/3d-2d/tools/pitchfork.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.6;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.88;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PitchforkItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.0;
};

datablock WeaponData(Partisan : BaseMeleeWeapon)
{
   id = 38;
   Object_typeID = 589;
   
   shapefile = "art/models/3d-2d/weapons/polearms/partisan_export_02.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponPolearm;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.05;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.31;
   hitGroupType[2] =  Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0.2;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PartisanItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(Staff : BaseMeleeWeapon)
{
   id = 39;
   Object_typeID = 590;
   
   shapefile = "art/models/3d-2d/weapons/polearms/staff.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = StaffItem;
   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.1;
   BaseRecoilAnimTime = 1.0;
};

datablock WeaponData(Spear : BaseMeleeWeapon)
{
   id = 40;
   Object_typeID = 591;
   
   shapefile = "art/models/3d-2d/weapons/spears/spear_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackSpear;
   WeaponType = WeaponSpear;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.36;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.56;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SpearItem;
   BasePrefireAnimTime = 0.8;
   BaseFireAnimTime = 0.8;
   BaseRecoilAnimTime = 0.8;
};

datablock WeaponData(BoarSpear : BaseMeleeWeapon)
{
   id = 41;
   Object_typeID = 592;
   
   shapefile = "art/models/3d-2d/weapons/spears/boar_spear_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackSpear;
   WeaponType = WeaponSpear;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.52;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.56;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.3;
   FractureMultiplier = 0;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BoarSpearItem;
   BasePrefireAnimTime =0.8;
   BaseFireAnimTime = 0.7;
   BaseRecoilAnimTime = 1.1;
};

datablock WeaponData(AwlPike : BaseMeleeWeapon)
{
   id = 42;
   Object_typeID = 593;
   
   shapefile = "art/models/3d-2d/weapons/spears/ahlspiess_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackSpear;
   WeaponType = WeaponSpear;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 4.27;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.64;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1.2;
   FractureMultiplier = 0;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = AwlPikeItem;
   BasePrefireAnimTime = 1;
   BaseFireAnimTime = 0.8;
   BaseRecoilAnimTime = 0.8;
};

datablock WeaponData(BecdeCorbin : BaseMeleeWeapon)
{
   id = 43;
   Object_typeID = 594;
   
   shapefile = "art/models/3d-2d/weapons/spears/bec_de_corbin_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponSpear;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.2;
   hitGroupType[1] = Piercing;
   hitGroupDmgLevel[1] = 1.37;
   hitGroupType[2] = Blunt;
   hitGroupDmgLevel[2] = 0.5;
   hitDirection[0] = "0 2"; // Thrust
   hitDirection[1] = "1 2"; // Overhead
   hitDirection[2] = "1 2"; // RightToLeftHit
   hitDirection[3] = "1 2"; // LeftToRightHit
   WoundMultiplier = 0.8;
   FractureMultiplier = 0;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BecdeCorbinItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 1.0;
   BaseRecoilAnimTime = 1.0;
};

datablock WeaponData(ShortPike : BaseMeleeWeapon)
{
   id = 44;
   Object_typeID = 595;
   
   shapefile = "art/models/3d-2d/weapons/pikes/short_pike_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponPike;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 0;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ShortPikeItem;
   BasePrefireAnimTime = 0.7;
   BaseFireAnimTime = 3.0;
   BaseRecoilAnimTime = 0.9;

   // parrying not allowed
   stateTransitionOnAltTriggerDown[0] = "";
   stateTransitionOnAltTriggerDown[1] = "FireCancel";
   stateTransitionOnAltTriggerDown[2] = "FireCancel";
   stateTransitionOnAltTriggerDown[16] = "";
};

datablock WeaponData(MediumPike : BaseMeleeWeapon)
{
   id = 45;
   Object_typeID = 596;
   
   shapefile = "art/models/3d-2d/weapons/pikes/medium_pike_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponPike;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 0;
   StunMultiplier = 0.35;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MediumPikeItem;
   BasePrefireAnimTime = 0.85;
   BaseFireAnimTime = 3.0;
   BaseRecoilAnimTime = 1.0;

   // parrying not allowed
   stateTransitionOnAltTriggerDown[0] = "";
   stateTransitionOnAltTriggerDown[1] = "FireCancel";
   stateTransitionOnAltTriggerDown[2] = "FireCancel";
   stateTransitionOnAltTriggerDown[16] = "";
};

datablock WeaponData(LongPike : BaseMeleeWeapon)
{
   id = 46;
   Object_typeID = 597;
   
   shapefile = "art/models/3d-2d/weapons/pikes/long_pike_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponPike;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 3.1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 2;
   FractureMultiplier = 0;
   StunMultiplier = 0.4;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = LongPikeItem;
   BasePrefireAnimTime = 1.0;
   BaseFireAnimTime = 3.0;
   BaseRecoilAnimTime = 1.0;

   // parrying not allowed
   stateTransitionOnAltTriggerDown[0] = "";
   stateTransitionOnAltTriggerDown[1] = "FireCancel";
   stateTransitionOnAltTriggerDown[2] = "FireCancel";
   stateTransitionOnAltTriggerDown[16] = "";
};

datablock WeaponData(Lance : BaseMeleeWeapon)
{
   id = 47;
   Object_typeID = 598;
   
   shapefile = "art/models/3d-2d/weapons/lances/lance_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponLance;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 2.8;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0;
   StunMultiplier = 0.25;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = LanceItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 3.0;
   BaseRecoilAnimTime = 1;

   stateCheckTransition[1] = true;
   // parrying not allowed
   stateTransitionOnAltTriggerDown[0] = "";
   stateTransitionOnAltTriggerDown[1] = "FireCancel";
   stateTransitionOnAltTriggerDown[2] = "FireCancel";
   stateTransitionOnAltTriggerDown[16] = "";
};

datablock WeaponData(JoustingLance : BaseMeleeWeapon)
{
   id = 48;
   Object_typeID = 599;
   
   shapefile = "art/models/3d-2d/weapons/lances/jousting_lance_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponLance;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 2.65;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = JoustingLanceItem;
   BasePrefireAnimTime = 1;
   BaseFireAnimTime = 3.0;
   BaseRecoilAnimTime = 0.8;

   stateCheckTransition[1] = true;
   // parrying not allowed
   stateTransitionOnAltTriggerDown[0] = "";
   stateTransitionOnAltTriggerDown[1] = "FireCancel";
   stateTransitionOnAltTriggerDown[2] = "FireCancel";
   stateTransitionOnAltTriggerDown[16] = "";

};

datablock ShieldData(TargeShield : BaseShield)
{
   id = 70;
   Object_typeID = 612;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_woodenround.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = TargeShieldItem;
};

datablock ShieldData(PrimitiveShield : BaseShield)
{
   id = 71;
   Object_typeID = 613;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_primitive.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PrimitiveShieldItem;
};

datablock ShieldData(BucklerShield : BaseShield)
{
   id = 72;
   Object_typeID = 614;
   
   shapefile = "art/models/3d-2d/armors/shields/buckler_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BucklerShieldItem;
};

datablock ShieldData(HeaterShield : BaseShield)
{
   id = 73;
   Object_typeID = 615;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_heaterb.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HeaterShieldItem;
};

datablock ShieldData(KiteShield : BaseShield)
{
   id = 74;
   Object_typeID = 616;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_kite.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = KiteShieldItem;
};

datablock ShieldData(TowerShield : BaseShield)
{
   id = 75;
   Object_typeID = 617;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_tower.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = TowerShieldItem;
};

datablock ShieldData(PaviseShield : BaseShield)
{
   id = 76;
   Object_typeID = 618;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_pavise.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PaviseShieldItem;
};

datablock WeaponData(Shovel : BaseMeleeWeapon)
{
   id = 120;
   Object_typeID = 40;
   
   shapefile = "art/models/3d-2d/tools/shovel.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = ShovelItem;
};

datablock WeaponData(Primitive_shovel : BaseMeleeWeapon)
{
   id = 121;
   Object_typeID = 41;
   
   shapefile = "art/models/3d-2d/tools/primitive_shovel.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_shovelItem;
};

datablock WeaponData(Primitive_pickaxe : BaseMeleeWeapon)
{
   id = 122;
   Object_typeID = 47;
   
   shapefile = "art/models/3d-2d/tools/primitivepickaxe_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_pickaxeItem;
};

datablock WeaponData(Pickaxe : BaseMeleeWeapon)
{
   id = 123;
   Object_typeID = 48;
   
   shapefile = "art/models/3d-2d/tools/pickaxe_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.1;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PickaxeItem;
};
//molepickaxe
datablock WeaponData(Mole_Pickaxe : BaseMeleeWeapon)
{
   id = 123;
   Object_typeID = 3014;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/molepickaxe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.3;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = PickaxeItem;
};

datablock WeaponData(Hardened_steel_pickaxe : BaseMeleeWeapon)
{
   id = 124;
   Object_typeID = 49;
   
   shapefile = "art/models/3d-2d/tools/steelpickaxe_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] = Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Hardened_steel_pickaxeItem;
};

datablock WeaponData(Primitive_hammer : BaseMeleeWeapon)
{
   id = 125;
   Object_typeID = 43;
   
   shapefile = "art/models/3d-2d/tools/primitive_hammer.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_hammerItem;
};

datablock WeaponData(Smiths_Hammer : BaseMeleeWeapon)
{
   id = 126;
   Object_typeID = 42;
   
   shapefile = "art/models/3d-2d/tools/blacksmithhammer_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Smiths_HammerItem;
};

datablock WeaponData(Mallet : BaseMeleeWeapon)
{
   id = 127;
   Object_typeID = 44;
   
   shapefile = "art/models/3d-2d/tools/mallet_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = MalletItem;
};

datablock WeaponData(Fishing_Pole : BaseMeleeWeapon)
{
   id = 128;
   Object_typeID = 621;
   
   shapefile = "art/models/3d-2d/tools/fishingrod_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Fishing_PoleItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.2;
   BaseRecoilAnimTime = 1.2;
};

datablock WeaponData(Primitive_Axe : BaseMeleeWeapon)
{
   id = 129;
   Object_typeID = 45;
   
   shapefile = "art/models/3d-2d/tools/primitive_axe.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_AxeItem;
};

datablock WeaponData(Hatchet : BaseMeleeWeapon)
{
   id = 130;
   Object_typeID = 46;
   
   shapefile = "art/models/3d-2d/tools/hatchet_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HatchetItem;
};

datablock WeaponData(Primitive_Saw : BaseMeleeWeapon)
{
   id = 131;
   Object_typeID = 50;
   
   shapefile = "art/models/3d-2d/tools/primitivesaw_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_SawItem;
};

datablock WeaponData(Saw : BaseMeleeWeapon)
{
   id = 132;
   Object_typeID = 51;
   
   shapefile = "art/models/3d-2d/tools/saw_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SawItem;
};

datablock WeaponData(Primitive_CrucibleandStick : BaseMeleeWeapon)
{
   id = 133;
   Object_typeID = 463;
   
   shapefile = "art/models/3d-2d/tools/primitivecas_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_CrucibleandStickItem;
};

datablock WeaponData(CrucibleandTongs : BaseMeleeWeapon)
{
   id = 134;
   Object_typeID = 464;
   
   shapefile = "art/models/3d-2d/tools/cas_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = CrucibleandTongsItem;
};

datablock WeaponData(Primitive_Sickle : BaseMeleeWeapon)
{
   id = 135;
   Object_typeID = 30;
   
   shapefile = "art/models/3d-2d/tools/primitive_sickle.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Slashing;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_SickleItem;
};

datablock WeaponData(Sickle : BaseMeleeWeapon)
{
   id = 136;
   Object_typeID = 33;
   
   shapefile = "art/models/3d-2d/tools/sickle_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SickleItem;
};
//Witch Sickle
datablock WeaponData(Witch_Sickle : BaseMeleeWeapon)
{
   id = 136;
   Object_typeID = 3015;
   
   shapefile = "art/models/3d-2d/weapons/Tribe/witchsickle.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.2;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SickleItem;
};

datablock ShieldData(IronRoundShield : BaseShield)
{
   id = 147;
   Object_typeID = 1066;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_steelround.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = IronRoundShieldItem;
};

datablock WeaponData(Primitive_Cooking_Pot : BaseMeleeWeapon)
{
   id = 319;
   Object_typeID = 1028;
   
   shapefile = "art/models/3d-2d/tools/primitivecookingpot_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_Cooking_PotItem;
};

datablock WeaponData(Cooking_Pot : BaseMeleeWeapon)
{
   id = 320;
   Object_typeID = 1029;
   
   shapefile = "art/models/3d-2d/tools/cookingpot_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Blunt;
   hitGroupDmgLevel[0] = 0.8;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Cooking_PotItem;
};

datablock WeaponData(Primitive_Knife : BaseMeleeWeapon)
{
   id = 321;
   Object_typeID = 289;
   
   shapefile = "art/models/3d-2d/tools/primitive_knife.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Piercing;
   hitGroupDmgLevel[0] = 1.0;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_KnifeItem;
};

datablock WeaponData(Knife : BaseMeleeWeapon)
{
   id = 322;
   Object_typeID = 290;
   
   shapefile = "art/models/3d-2d/tools/simpleknife_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.9;
   hitGroupType[1] = Slashing;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = KnifeItem;
};

datablock WeaponData(Skinning_knife : BaseMeleeWeapon)
{
   id = 323;
   Object_typeID = 291;
   
   shapefile = "art/models/3d-2d/tools/heavyknife_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 1.9;
   hitGroupType[1] = Slashing;
   hitGroupDmgLevel[1] = 1.2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Skinning_knifeItem;
};

datablock WeaponData(Glassblower_toolkit : BaseMeleeWeapon)
{
   id = 324;
   Object_typeID = 294;
   
   shapefile = "art/models/3d-2d/tools/gstick_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Glassblower_toolkitItem;
};

datablock WeaponData(Bear_Paw)
{
   id = 325;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 2;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.5;
   FractureMultiplier = 0.1;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Bear_PawItem;
};

datablock WeaponData(Wild_Horse_Hoof)
{
   id = 326;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Wild_Horse_HoofItem;
};

datablock WeaponData(Deer_Hoof)
{
   id = 327;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Deer_HoofItem;
};

datablock WeaponData(Hind_Hoof)
{
   id = 328;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.8;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Hind_HoofItem;
};

datablock WeaponData(Wolf_Fang)
{
   id = 329;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 0.3;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.5;
   FractureMultiplier = 0.2;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Wolf_FangItem;
};

datablock WeaponData(Moose_Hoof)
{
   id = 330;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.5;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Moose_HoofItem;
};

datablock WeaponData(Boar_Tusk)
{
   id = 331;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.3;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.4;
   FractureMultiplier = 0.2;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Boar_TuskItem;
};

datablock WeaponData(Sow_Tusk)
{
   id = 332;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.2;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.4;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0.2;
   FractureMultiplier = 0.1;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Sow_TuskItem;
};

datablock WeaponData(Mutton_Horns)
{
   id = 333;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.4;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Mutton_HornsItem;
};

datablock WeaponData(Bull_Horns)
{
   id = 334;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.8;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.6;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.6;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Bull_HornsItem;
};

datablock WeaponData(Cow_Horns)
{
   id = 335;
   
   shapefile = "";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.5;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.3;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Cow_HornsItem;
};

datablock WeaponData(Primitive_Fishing_Pole : BaseMeleeWeapon)
{
   id = 336;
   Object_typeID = 620;
   
   shapefile = "art/models/3d-2d/tools/fishingrod_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = Primitive_Fishing_PoleItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.2;
   BaseRecoilAnimTime = 1.2;
};

datablock WeaponData(Torch : BaseMeleeWeapon)
{
   id = 337;
   Object_typeID = 38;
   
   shapefile = "art/models/3d-2d/tools/torch.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Siege;
   hitGroupDmgLevel[0] = 0.1;
   hitGroupType[1] = Siege;
   hitGroupDmgLevel[1] = 0.1;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = TorchItem;

   permanentEmitter[0] = weapon_smoke;
   permanentEmitter[1] = SparksOfTorchEmitter;
   //permanentEmitterNode[0] = "fire_node";
   permanentEmitterNode[0] = "smoke_node";
   permanentEmitterNode[1] = "sparks_node";
   
   fireEmitter = TestFireEmitter;
   fireEmitterNode = "fire_node";
   
   animatedBillboard = TestAnimatedBillboard;
   animatedBillboardNode = "fire_node";
   
   permanentSound = TorchFireSound;
   
   lightType=ConstantLight;
   lightColor = "1.0 1.0 0.9";
   lightRadius = 20;
   lightImageNode = "fire_node";

   lightPrototype = "Torch_light";
};

datablock WeaponData(DecoratedJoustingLance : BaseMeleeWeapon)
{
   id = 338;
   Object_typeID = 1141;
   
   shapefile = "art/models/3d-2d/weapons/lances/jousting_lance_export_02.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackPike;
   WeaponType = WeaponLance;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Piercing;
   hitGroupDmgLevel[0] = 2.35;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.5;
   hitDirection[0] = "0 1"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 1;
   FractureMultiplier = 0;
   StunMultiplier = 0.3;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = DecoratedJoustingLanceItem;
   BasePrefireAnimTime = 1;
   BaseFireAnimTime = 3.0;
   BaseRecoilAnimTime = 0.8;

   stateCheckTransition[1] = true;
   // parrying not allowed
   stateTransitionOnAltTriggerDown[0] = "";
   stateTransitionOnAltTriggerDown[1] = "FireCancel";
   stateTransitionOnAltTriggerDown[2] = "FireCancel";
   stateTransitionOnAltTriggerDown[16] = "";
};

datablock WeaponData(HandOfBoris : BaseMeleeWeapon)
{
   id = 583;
   Object_typeID = 1120;
   
   shapefile = "art/models/3d-2d/weapons/unarmed/fist.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackUnarmed;
   WeaponType = WeaponUnarmed;
   weaponMaterial = Wooden;
   hitGroupType[0] = Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HandOfBorisItem;
};

datablock WeaponData(HandOfIlyas : BaseMeleeWeapon)
{
   id = 584;
   Object_typeID = 1122;
   
   shapefile = "art/models/3d-2d/weapons/unarmed/fist.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = AttackUnarmed;
   WeaponType = WeaponUnarmed;
   weaponMaterial = Wooden;
   hitGroupType[0] = Blunt;
   hitGroupDmgLevel[0] = 0.7;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.1;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HandOfIlyasItem;
};

datablock WeaponData(SiegeTorch : BaseMeleeWeapon)
{
   id = 611;
   Object_typeID = 1414;
   
   shapefile = "art/models/3d-2d/tools/siege_torch.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Siege;
   hitGroupDmgLevel[0] = 2.4;
   hitGroupType[1] = Siege;
   hitGroupDmgLevel[1] = 1.6;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0.0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SiegeTorchItem;

   permanentEmitter[0] = weapon_smoke;
   permanentEmitter[1] = SparksOfTorchEmitter;
   //permanentEmitterNode[0] = "fire_node";
   permanentEmitterNode[0] = "smoke_node";
   permanentEmitterNode[1] = "sparks_node";
   
   fireEmitter = TestFireEmitter;
   fireEmitterNode = "fire_node";
   
   animatedBillboard = TestAnimatedBillboard;
   animatedBillboardNode = "fire_node";
   
   permanentSound = TorchFireSound;
   
   lightType=ConstantLight;
   lightColor = "1.0 1.0 0.9";
   lightRadius = 20;
   lightImageNode = "fire_node";

   lightPrototype = "Torch_light";
};

datablock WeaponData(BelieverShovel : BaseMeleeWeapon)
{
   id = 650;
   Object_typeID = 1463;
   
   shapefile = "art/models/3d-2d/tools/shovel.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.0;
   hitGroupType[1] =  Slashing;
   hitGroupDmgLevel[1] = 0.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverShovelItem;
};

datablock WeaponData(BelieverHammer : BaseMeleeWeapon)
{
   id = 651;
   Object_typeID = 1464;
   
   shapefile = "art/models/3d-2d/tools/blacksmithhammer_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverHammerItem;
};

datablock WeaponData(BelieverHatchet : BaseMeleeWeapon)
{
   id = 652;
   Object_typeID = 1465;
   
   shapefile = "art/models/3d-2d/tools/hatchet_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Slashing;
   hitGroupDmgLevel[0] = 0.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverHatchetItem;
};

datablock WeaponData(BelieverPickaxe : BaseMeleeWeapon)
{
   id = 653;
   Object_typeID = 1466;
   
   shapefile = "art/models/3d-2d/tools/pickaxe_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HSword;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverPickaxeItem;
};

datablock WeaponData(BelieverSaw : BaseMeleeWeapon)
{
   id = 654;
   Object_typeID = 1467;
   
   shapefile = "art/models/3d-2d/tools/saw_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverSawItem;
};

datablock WeaponData(BelieverKnife : BaseMeleeWeapon)
{
   id = 655;
   Object_typeID = 1468;
   
   shapefile = "art/models/3d-2d/tools/simpleknife_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.0;
   hitGroupType[1] = Slashing;
   hitGroupDmgLevel[1] = 0.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverKnifeItem;
};

datablock WeaponData(BelieverSickle : BaseMeleeWeapon)
{
   id = 656;
   Object_typeID = 1469;
   
   shapefile = "art/models/3d-2d/tools/sickle_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Metal;
   hitGroupType[0] = Piercing;
   hitGroupDmgLevel[0] = 0.0;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 0.0;
   hitDirection[0] = "1"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverSickleItem;
};

datablock WeaponData(BelieverCrucibleTongs : BaseMeleeWeapon)
{
   id = 657;
   Object_typeID = 1470;
   
   shapefile = "art/models/3d-2d/tools/cas_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverCrucibleTongsItem;
};

datablock WeaponData(BelieverFishingPole : BaseMeleeWeapon)
{
   id = 658;
   Object_typeID = 1471;
   
   shapefile = "art/models/3d-2d/tools/fishingrod_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 0.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverFishingPoleItem;
   BasePrefireAnimTime = 1.2;
   BaseFireAnimTime = 1.2;
   BaseRecoilAnimTime = 1.2;
};

datablock WeaponData(BelieverCookingPot : BaseMeleeWeapon)
{
   id = 659;
   Object_typeID = 1559;
   
   shapefile = "art/models/3d-2d/tools/cookingpot_export_01.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] = Blunt;
   hitGroupDmgLevel[0] = 0.0;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BelieverCookingPotItem;
};

datablock ShieldData(HeavyTargeShield : BaseShield)
{
   id = 614;
   Object_typeID = 1522;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_woodenroundreg.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HeavyTargeShieldItem;
};

datablock ShieldData(HeavyHeaterShield : BaseShield)
{
   id = 615;
   Object_typeID = 1523;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_heaterreg.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HeavyHeaterShieldItem;
};

datablock ShieldData(HeavyKiteShield : BaseShield)
{
   id = 616;
   Object_typeID = 1524;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_kitereg.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HeavyKiteShieldItem;
};

datablock ShieldData(SmallKiteShield : BaseShield)
{
   id = 617;
   Object_typeID = 1535;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_heatera.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = SmallKiteShieldItem;
};

datablock ShieldData(HeavyIronShield : BaseShield)
{
   id = 618;
   Object_typeID = 1537;
   
   shapefile = "art/models/3d-2d/armors/shields/shield_steelroundreg.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack1H;
   WeaponType = WeaponShield;

   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "0"; // Overhead
   hitDirection[2] = "0"; // RightToLeftHit
   hitDirection[3] = "0"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0;
   StunMultiplier = 0;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = HeavyIronShieldItem;
};

datablock WeaponData(BalancedStaff : BaseMeleeWeapon)
{
   id = 619;
   Object_typeID = 1408;
   
   shapefile = "art/models/3d-2d/weapons/polearms/staff.dts";
   
   mountPoint = 0;
   offset = "0 0 0";
   eyeOffset = "0 0 0";

   attackType = Attack2HWeapon;
   WeaponType = WeaponMisc;
   weaponMaterial = Wooden;
   hitGroupType[0] =  Blunt;
   hitGroupDmgLevel[0] = 1.4;
   hitGroupType[1] =  Blunt;
   hitGroupDmgLevel[1] = 1.4;
   hitDirection[0] = "0"; // Thrust
   hitDirection[1] = "1"; // Overhead
   hitDirection[2] = "1"; // RightToLeftHit
   hitDirection[3] = "1"; // LeftToRightHit
   WoundMultiplier = 0;
   FractureMultiplier = 0.5;
   StunMultiplier = 0.05;
   correctMuzzleVector = false;
   className = "WeaponImage";
   item = BalancedStaffItem;

   BasePrefireAnimTime = 1.1;
   BaseFireAnimTime = 1.05;
   BaseRecoilAnimTime = 1.0;
};