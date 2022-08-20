//-----------------------------------------------------------------------------
// Torque Game Engine Engine
// Copyright (C) GarageGames.com, Inc.
//-----------------------------------------------------------------------------

datablock AnimalData(TribeHData : DefaultPlayerData)   // datablock PlayerData
{
   id = 782; //CM_REV

   animalTypeId = 3004;
   footprintTexture = "art/Textures/Tribe/tribe_fs.png";
   footprintTextureLinearSize = 0.7;
   footprintGap = 0.8;
   footprintTrackWidth = 0.5;
   shapeFile = "art/models/3d/tribe/tribe_hunter_yo.dts";
   soundFilesPrefix = "bear";

   behavior = "data/ai/cmAiTribeHunter.xml";

   boundingBox = "2.5 6.2 3.7"; //"1.2 6.2 3.5";    7
   
   // should be identical to navmesh walkable slope
   runSurfaceAngle = 50;

   // parameters from BASE:
   maxHP = 400.0;
   bodyRadius = 4.0;
   
   rawCorpseObjectTypeID = 3005;
   skinnedCorpseObjectTypeID = 3005;
   
   weaponData = "Bear_Paw";
   weaponWeight = 10.0;
   
   powerHitStartingDistance = 10.0; // does nothing ?
   powerHitDamagingDistance = 10.0; // fasthitdmgdistance and modeldistance
   powerHitDamagingSector = 90;
   powerHitMinSpeed = 1;
   powerHitMaxSpeed = 1;
   
   fastHitStartingDistance = 0.7; // does nothing ?
   fastHitDamagingDistance = 0.7; // no modeldistance  powerhitdmgdistance
   fastHitDamagingSector = 90;
   fastHitMinSpeed = 1;
   fastHitMaxSpeed = 1;
   
   walkAnimationSpeed = 0.87;
   runAnimationSpeed = 0.75;
   walkSpeed = 2;
   runSpeed = 8;
   
   animalType = "Predator";
};
