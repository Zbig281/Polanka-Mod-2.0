//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(TribeBData : DefaultPlayerData)   // datablock PlayerData
{
   id = 780; //CM_REV

   animalTypeId = 3000;
   footprintTexture = "art/Textures/Tribe/tribe_fs.png";
   footprintTextureLinearSize = 0.7;
   footprintGap = 0.8;
   footprintTrackWidth = 0.5;
   shapeFile = "art/models/3d/tribe/tribe_bear_yo.dts";
   soundFilesPrefix = "BearKnool";

   behavior = "data/ai/cmAiTribeBear.xml";

   boundingBox = "2.5 6.2 3.7"; //"1.2 6.2 3.5";    7
   
   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 500.0;
   bodyRadius = 4.0;
   
   rawCorpseObjectTypeID = 3001;
   skinnedCorpseObjectTypeID = 3001;
   
   weaponData = "Pollaxe";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.3;
   powerHitDamagingDistance = 1.3;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 1;
   powerHitMaxSpeed = 1;
   
   fastHitStartingDistance = 0.7;
   fastHitDamagingDistance = 0.7;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 1;
   fastHitMaxSpeed = 1;
   
   walkAnimationSpeed = 0.87;
   runAnimationSpeed = 0.75;
   walkSpeed = 2;
   runSpeed = 8;
   
   animalType = "Predator";
};
