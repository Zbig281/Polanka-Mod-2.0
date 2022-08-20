//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(TribeWData : DefaultPlayerData)   // datablock PlayerData
{
   id = 784; //CM_REV

   animalTypeId = 3008;
   footprintTexture = "art/Textures/Tribe/tribe_fs.png";
   footprintTextureLinearSize = 0.7;
   footprintGap = 0.8;
   footprintTrackWidth = 0.5;
   shapeFile = "art/models/3d/tribe/tribe_witch_yo.dts";
   soundFilesPrefix = "bear";

   behavior = "data/ai/cmAiTribeWitch.xml";

   boundingBox = "2.5 6.2 3.7"; //"1.2 6.2 3.5";    7
   
   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 350.0;
   bodyRadius = 4.0;
   
   rawCorpseObjectTypeID = 3009;
   skinnedCorpseObjectTypeID = 3009;
   
   weaponData = "Sickle";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 1.0;
   powerHitDamagingDistance = 1.0;
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 1;
   powerHitMaxSpeed = 1;
   
   fastHitStartingDistance = 1.0;
   fastHitDamagingDistance = 1.0;
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 1;
   fastHitMaxSpeed = 1;
   
   walkAnimationSpeed = 0.87;
   runAnimationSpeed = 0.75;
   walkSpeed = 2;
   runSpeed = 10;
   
   animalType = "Predator";
};
