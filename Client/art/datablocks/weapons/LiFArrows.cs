//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

// определены в audioProfiles.cs:
//SFXProfile( ArrowFlySound)
//SFXProfile( BoltFlySound)
//SFXProfile( ThrowingFlySound)

//art/Models/3D-2D/Weapons/Ammunition/Arrows/ArrowBodkin_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Arrows/ArrowSlash_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Arrows/ArrowStand_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Arrows/ArrowStun_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Bolts/BoltHeavy_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Bolts/BoltStand_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Bolts/BoltStun_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Throwing/Francisca_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Throwing/SlingStone_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Throwing/ThrowingKnife_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Throwing/ThrowingSpear_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Throwing/SlingStone_EXPORT_01.dts

// колчаны:
//art/Models/3D-2D/Weapons/Ammunition/Quivers/QuiverFull_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/Quivers/BoltBagFull_EXPORT_01.dts
//art/Models/3D-2D/Weapons/Ammunition/AmmoPouch/sling_ammo_pouch.dts

//-----------------------------------------------------------------------------
// датаблок стрелы вставленной в лук, т.е. когда её удерживают рукой, и она замаунтена как дополнительный имидж.
// так же этот датаблок передаётся в систему демеджа.
// должен быть определён ДО ArrowData.

datablock WeaponData(BodkinArrowLoaded)
{
	id = 560;
	shapeFile = "art/models/3d-2d/weapons/ammunition/arrowbodkin_export_01.dts";// стрела одиночная
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Piercing;
	hitGroupDmgLevel[0] = 6.3;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1";
	FractureMultiplier = "0";
	StunMultiplier = "0";
};
//-----------------------------------------------------------------------------
// датаблок летящей стрелы и колчана.
datablock ArrowData(BodkinArrow)
{
	// BaseData:
	id = 559;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/arrowbodkin_export_01.dts";// стрела одиночная
	upForce = 0.05;
	loadedAmmo = "BodkinArrowLoaded";
	Friction = 0.025;
	// ShapeBaseImageData:
	Object_typeID = 656;
	shapeFile = "art/models/3d-2d/weapons/ammunition/quiverfull_export_01.dts";// колчан
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(BroadheadLoaded)
{
	id = 562;
	shapeFile = "art/models/3d-2d/weapons/ammunition/arrowslash_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Slashing;
	hitGroupDmgLevel[0] = 8.8;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1.5";
	FractureMultiplier = "0.5";
	StunMultiplier = "0";
};

datablock ArrowData(BroadheadArrow)
{
	// BaseData:
	id = 561;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/arrowslash_export_01.dts";
	upForce = 0.05;
	loadedAmmo = "BroadheadLoaded";
	Friction = 0.025;
	// ShapeBaseImageData:
	Object_typeID = 657;
	shapeFile = "art/models/3d-2d/weapons/ammunition/quiverfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(StandArrowLoaded)
{
	id = 564;
	shapeFile = "art/models/3d-2d/weapons/ammunition/arrowstand_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Slashing;
	hitGroupDmgLevel[0] = 7.0;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1";
	FractureMultiplier = "0";
	StunMultiplier = "0";
};

datablock ArrowData(StandArrow)
{
	// BaseData:
	id = 563;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/arrowstand_export_01.dts";
	upForce = 0.05;
	loadedAmmo = "StandArrowLoaded";
	Friction = 0.0;
	// ShapeBaseImageData:
	Object_typeID = 660;
	shapeFile = "art/models/3d-2d/weapons/ammunition/quiverfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;
	
	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(DullArrowLoaded)
{
	id = 566;
	shapeFile = "art/models/3d-2d/weapons/ammunition/arrowstun_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Blunt;
	hitGroupDmgLevel[0] = 7.2;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "0.5";
	StunMultiplier = "0.5";
};

datablock ArrowData(DullArrow)
{
	// BaseData:
	id = 565;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/arrowstun_export_01.dts";
	upForce = 0.05;
	loadedAmmo = "DullArrowLoaded";
	Friction = 0.025;
	// ShapeBaseImageData:
	Object_typeID = 659;
	shapeFile = "art/models/3d-2d/weapons/ammunition/quiverfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(FireArrowLoaded)
{
	id = 585;
	shapeFile = "art/models/3d-2d/weapons/ammunition/arrowfire_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = siege;
	hitGroupDmgLevel[0] = 4.5;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1";
	FractureMultiplier = "0";
	StunMultiplier = "0";

	permanentEmitterNode[0] = "firenode0";
	permanentEmitterNode[1] = "firenode0";
	permanentEmitter[0] = FireOfTorchEmitter;
	permanentEmitter[1] = weapon_smoke;
};

datablock ArrowData(FireArrow)
{
	// BaseData:
	id = 586;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/arrowfire_export_01.dts";
	upForce = 0.05;
	loadedAmmo = "FireArrowLoaded";
	Friction = 0.025;
	// ShapeBaseImageData:
	Object_typeID = 658;
	shapeFile = "art/models/3d-2d/weapons/ammunition/quiverfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(FireworkArrowLoaded)
{
	id = 587;
	shapeFile = "art/models/3d-2d/weapons/ammunition/arrowfire_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = siege;
	hitGroupDmgLevel[0] = 2.0;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1";
	FractureMultiplier = "0";
	StunMultiplier = "0";

	permanentEmitter[0] = spark_star;
    permanentEmitterNode[0] = "hitpoint0n0";
};

datablock ArrowData(FireworkArrow)
{
	// BaseData:
	id = 588;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/arrowfire_export_01.dts";
	upForce = 0.05;
	loadedAmmo = "FireworkArrowLoaded";
	Friction = 0.025;
	// ShapeBaseImageData:
	Object_typeID = 1339;
	shapeFile = "art/models/3d-2d/weapons/ammunition/quiverfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(HeavyBoltLoaded)
{
	id = 568;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltheavy_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Piercing;
	hitGroupDmgLevel[0] = 9.0;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1";
	FractureMultiplier = "1";
	StunMultiplier = "0";
};

datablock ArrowData(HeavyBolt)
{
	// BaseData:
	id = 567;
	// ArrowData:
	sound = "BoltFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/boltheavy_export_01.dts";
	upForce = 0.03;
	loadedAmmo = "HeavyBoltLoaded";
	Friction = 0.03;
	// ShapeBaseImageData:
	Object_typeID = 664;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltbagfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(StandBoltLoaded)
{
	id = 570;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltstand_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Slashing;
	hitGroupDmgLevel[0] = 10.05;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1";
	FractureMultiplier = "0.5";
	StunMultiplier = "0";
};

datablock ArrowData(StandBolt)
{
	// BaseData:
	id = 569;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/boltstand_export_01.dts";
	upForce = 0.03;
	loadedAmmo = "StandBoltLoaded";
	Friction = 0.0;
	// ShapeBaseImageData:
	Object_typeID = 662;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltbagfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(DullBoltLoaded)
{
	id = 572;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltstun_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Blunt;
	hitGroupDmgLevel[0] = 9.05;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "0.5";
	StunMultiplier = "0.5";
};

datablock ArrowData(DullBolt)
{
	// BaseData:
	id = 571;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/boltstun_export_01.dts";
	upForce = 0.03;
	loadedAmmo = "DullBoltLoaded";
	Friction = 0.03;
	// ShapeBaseImageData:
	Object_typeID = 663;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltbagfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(FireworkBoltLoaded)
{
	id = 589;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltfire_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = siege;
	hitGroupDmgLevel[0] = 2.0;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "0.5";
	StunMultiplier = "0.5";

	permanentEmitter[0] = spark_star;
    permanentEmitterNode[0] = "hitpoint0n0";
};

datablock ArrowData(FireworkBolt)
{
	// BaseData:
	id = 590;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime = 10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/boltfire_export_01.dts";
	upForce = 0.03;
	loadedAmmo = "FireworkBoltLoaded";
	Friction = 0.03;
	// ShapeBaseImageData:
	Object_typeID = 1340;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltbagfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(SlingStoneLoaded)
{
	id = 576;
	shapeFile = "art/models/3d-2d/weapons/ammunition/slingstone_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Blunt;
	hitGroupDmgLevel[0] = 3.4;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "0.1";
	StunMultiplier = "0.1";
};

datablock ArrowData(SlingStone)
{
	// BaseData:
	id = 575;
	// ArrowData:
	sound = "ThrowingFlySound";
	stuckArrowLifeTime = 10;
	projectileShape = "art/models/3d-2d/weapons/ammunition/slingstone_export_01.dts";
	upForce = 0.0;
	loadedAmmo = "SlingStoneLoaded";
	Friction = 0.1;
	// ShapeBaseImageData:
	Object_typeID = 1096;
	shapeFile = "art/models/3d-2d/weapons/ammunition/sling_ammo_pouch.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;
};

datablock WeaponData(WoodenArrowLoaded)
{
	id = 644;
	shapeFile = "art/models/3d-2d/weapons/ammunition/arrowtrain.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Slashing;
	hitGroupDmgLevel[0] = 3.0;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "1";
	FractureMultiplier = "0";
	StunMultiplier = "0";
};

datablock ArrowData(WoodenArrow)
{
	// BaseData:
	id = 643;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime =10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/arrowtrain.dts";
	upForce = 0.05;
	loadedAmmo = "WoodenArrowLoaded";
	Friction = 0.0;
	// ShapeBaseImageData:
	Object_typeID = 1582;
	shapeFile = "art/models/3d-2d/weapons/ammunition/quiverfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;
	
	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};

datablock WeaponData(WoodenBoltLoaded)
{
	id = 646;
	shapeFile = "art/models/3d-2d/weapons/ammunition/bolttrain.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	hitGroupType[0] = Slashing;
	hitGroupDmgLevel[0] = 3.0;
	hitDirection[0] = ""; // Thrust
	hitDirection[1] = ""; // Overhead
	hitDirection[2] = ""; // RightToLeftHit
	hitDirection[3] = ""; // LeftToRightHit
	WoundMultiplier = "0";
	FractureMultiplier = "0.5";
	StunMultiplier = "0";
};

datablock ArrowData(WoodenBolt)
{
	// BaseData:
	id = 645;
	// ArrowData:
	sound = "ArrowFlySound";
	stuckArrowLifeTime = 10000;
	projectileShape = "art/models/3d-2d/weapons/ammunition/bolttrain.dts";
	upForce = 0.03;
	loadedAmmo = "WoodenBoltLoaded";
	Friction = 0.0;
	// ShapeBaseImageData:
	Object_typeID = 1583;
	shapeFile = "art/models/3d-2d/weapons/ammunition/boltbagfull_export_01.dts";
	mountPoint = 0;
	offset = "0 0 0";
	eyeOffset = "0 0 0";
	correctMuzzleVector = false;
	WeaponType = WeaponAmmo;
	// State for attached(inactive) weapons. Manually-controlled state
	stateName[0] = "Attach";
	stateFireSubState[0] = Attached;
	stateAllowImageChange[0] = false;

	trailInstanceLifeTime = 0.5;
	trailDensity = 2;
};
