singleton Material(newMaterial5)
{
   mapTo = "unmapped_mat";
   cubemap = "NewLevelSkyCubemap";
};

// Customization
exec("art/customization_data.cs");

//Tunnel walls, floor and ceiling-----------------------------------------------------------------------------------------------

// soil
singleton Material(TunnelWallsMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   streamable = "0";
};

//SteppeSoil
singleton Material(TunnelWallsSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

singleton Material(TunnelFloorSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

singleton Material(TunnelCeilingSteppeSoilMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Soil/Soil_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   diffuseColor[0] = "1 0.835294 0 1";
   streamable = "0";
};

//Rock
singleton Material(TunnelWallsRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
 //diffuseMap[2] = "art/Textures/TunnelTextures/Rock/Rock_spec.dds";
   streamable = "0";
};

singleton Material(TunnelFloorRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Rock/Rock_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//RockBare
singleton Material(TunnelWallsRockBareMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_diff.DDS";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Granite
singleton Material(TunnelWallsGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingGraniteMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Granite/Granite_ceiling.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//GraniteFrag
singleton Material(TunnelWallsGraniteFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Granite_fragments/Granite_Frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Marble
singleton Material(TunnelWallsMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingMarbleMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Marble/Marble_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//MarbleFrag
singleton Material(TunnelWallsMarbleFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Marble_fragments/Marble_frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Slate
singleton Material(TunnelWallsSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_floor.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingSlateMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Slate/Slate_ceiling.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   streamable = "0";
};

//SlateFrag
singleton Material(TunnelWallsSlateFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Slate_fragments/Slate_frag_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//GoldOre
singleton Material(TunnelWallsGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelFloorGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingGoldOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Gold_Vein_Ceiling_Dif.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//GoldOreFrag
singleton Material(TunnelWallsGoldOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Gold_ore/Gold_Ore_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   materialTag0 = "tunnel";
   streamable = "0";
};

//IronOre
singleton Material(TunnelFloorIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsIronOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Iron_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//IronOreFrag
singleton Material(TunnelWallsIronOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Iron_ore/Iron_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//SilverOre
singleton Material(TunnelFloorSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsSilverOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Silver_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//SilverOreFrag
singleton Material(TunnelWallsSilverOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Silver_ore/Silver_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//CopperOre
singleton Material(TunnelFloorCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Floor_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_floor_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelCeilingCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Ceiling_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_ceiling_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

singleton Material(TunnelWallsCopperOreMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/ORE/Ore_Copper_Vein_Dif.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Rock/Rock_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/ORE/Ore_Vein_Spec_.dds";
   streamable = "0";
};

//CopperOreFrag
singleton Material(TunnelWallsCopperOreFragMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Copper_ore/Copper_Ore_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock_Fragments/Rock_Frag_nm.DDS";
   streamable = "0";
};

//Sand
singleton Material(TunnelWallsSandMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Sand/Sand_wall.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Soil/Soil_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Clay
singleton Material(TunnelWallsClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/Clay_wall_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelFloorClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_floor_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

singleton Material(TunnelCeilingClayMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Clay/Clay_ceiling_diff.dds";
   materialTag0 = "tunnel";
   diffuseMap[1] = "art/Textures/TunnelTextures/Clay/u_ceiling_nm.dds";
   streamable = "0";
};

//Snow
singleton Material(TunnelWallsSnowMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/Snow/Snow_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Snow/Snow_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

//Swamp
singleton Material(TunnelWallsSwampMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_diff.dds";
   diffuseMap[1] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_nm.dds";
   materialTag0 = "tunnel";
   diffuseMap[2] = "art/Textures/TunnelTextures/Swamp/Swamp_wall_spec.dds";
   streamable = "0";
};

//RiverRock
singleton Material(TunnelWallsRiverRockMaterial)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/2D/Terrain/Substances/River_rock/River_Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/River_rock/River_Rock_nm.dds";
   materialTag0 = "tunnel";
   streamable = "0";
};

// Weapons and armor

singleton Material(war_axe_mat)
{
   mapTo = "War_Axe_03.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Flanged_Mace_mat)
{
   mapTo = "Flanged_Mace_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Morgenstern_02_jpg_mat)
{
   mapTo = "Morgenstern_02.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Bardiche_01_jpg_mat)
{
   mapTo = "Bardiche_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Claymore_01_mat)
{
   mapTo = "Claymore_DIFFUSE_01.dds";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_01_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_01_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_01_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Claymore_DIFFUSE_mat)
{
    mapTo = "Claymore_DIFFUSE";
    diffuseMap[0] = "art/Textures/Weapons/Claymore_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Claymore_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Claymore_SPECULAR.dds";
    materialTag0 = "LiF";
    behaveAsParticle = true;
    normal3DC = "1";
};

singleton Material(Cudgel_01_jpg_mat)
{
   mapTo = "Cudgel_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_02_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_02_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_02_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Maul_DIFFUSE_01_jpg_mat)
{
   mapTo = "Maul_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_02_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_02_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_02_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Nordic_Axe_01_jpg_mat)
{
   mapTo = "Nordic_Axe_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapons_Pack_02_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapons_Pack_02_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapons_Pack_02_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Weapon_Pack_03_DIFFUSE_01_mat)
{
   mapTo = "Weapon_Pack_03_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_03_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_03_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_03_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(NordicSword_DIFFUSE_mat)
{
    mapTo = "NordicSword_DIFFUSE";
    diffuseMap[0] = "art/Textures/Weapons/NordicSword_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/NordicSword_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/NordicSword_SPECULAR.dds";
    materialTag0 = "LiF";
    behaveAsParticle = true;
    normal3DC = "1";
};

singleton Material(Lance_pack1_mat)
{
    mapTo = "Lance_pack1";
    diffuseMap[0] = "art/Textures/Weapons/Lance_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Lance_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Lance_SPECULAR.dds";
    materialTag0 = "LiF";
    behaveAsParticle = true;
    normal3DC = "1";
};

singleton Material(JoustingLance_DIFFUSE_mat)
{
    mapTo = "JoustingLance_DIFFUSE";
    diffuseMap[0] = "art/Textures/Weapons/JoustingLance_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/JoustingLance_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/JoustingLance_SPECULAR.dds";
    materialTag0 = "LiF";
    behaveAsParticle = true;
    normal3DC = "1";
};

singleton Material(Bardiche_pack1_mat)
{
    mapTo = "Bardiche_pack1";
    diffuseMap[0] = "art/Textures/Weapons/Bardiche_Pack1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Bardiche_Pack1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Bardiche_Pack1_SPECULAR.dds";
    materialTag0 = "LiF";
    behaveAsParticle = true;
    normal3DC = "1";
};

singleton Material(Bardiche_pack2_mat)
{
    mapTo = "Bardiche_pack2";
    diffuseMap[0] = "art/Textures/Weapons/Bardiche_Pack2_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Bardiche_Pack2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Bardiche_Pack2_SPECULAR.dds";
    materialTag0 = "LiF";
    behaveAsParticle = true;
    normal3DC = "1";
};

singleton Material(Flamberge_pack1_diff_mat)
{
    mapTo = "Flamberge_pack1_diff";
    diffuseMap[0] = "art/Textures/Weapons/Flamberge_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Flamberge_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Flamberge_SPECULAR.dds";
    materialTag0 = "LiF";
    behaveAsParticle = true;
    normal3DC = "1";
};

singleton Material(Light_Crossbow_Pack1_DIFFUSE_mat)
{
    mapTo = "Light_Crossbow_Pack1_DIFFUSE";
    diffuseMap[0] = "art/Textures/Weapons/Light_Crossbow_Pack1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Light_Crossbow_Pack1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Light_Crossbow_Pack1_SPECULAR.dds";
    skinned = true;
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(Arbalest_DIFFUSE_mat)
{
    mapTo = "Arbalest_DIFFUSE";
    diffuseMap[0] = "art/Textures/Weapons/Arbalest_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Arbalest_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Arbalest_SPECULAR.dds";
    skinned = true;
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(Longbow_DIFFUSE_mat)
{
    mapTo = "Longbow_DIFFUSE";
    diffuseMap[0] = "art/Textures/Weapons/Longbow_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Longbow_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Longbow_SPECULAR.dds";
    skinned = true;
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(Tribe_Weapon_DIFFUSE_ns_mat)
{
   mapTo = "Tribe_Weapon_DIFFUSE_ns";
   diffuseMap[0] = "art/Textures/Weapons/Zweihander_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/Zweihander_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/Zweihander_SPECULAR.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};
// Atlas Materials

singleton Material(shops_01_atlas_diff_mat)
{
   mapTo = "shops-01-atlas-diff";
   diffuseMap[0] = "art/Textures/Atlas/shops-01-atlas-diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops-01-atlas-nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops-01-atlas-spec.dds";
   diffuseMap[12] = "art/Textures/Atlas/shops-01-atlas-emiss.dds";
   emission="1";
   emissionIntensityFreq="0.5";
   emissionIntensityMin="0.4";
   emissionIntensityMax="1.5";
   emissionScale="0.05";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "154";
};

// Texture library materials

singleton Material(brick_01_diff_mat)
{
   mapTo = "brick-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/small_brick_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/small_brick_01_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(wood_floor_01_diff_mat)
{
   mapTo = "wood_floor-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_floor_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_floor_01_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(wood_diffuce_01_mat2)
{
   mapTo = "wood_diffuce_01";
   diffuseMap[0] = "art/Textures/TextureLib/wood_diffuce_01.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_normal_01.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wood_specular_01.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(wood_diffuce_01_skinned_diff_mat)
{
   mapTo = "wood_diffuce_01_skinned_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_diffuce_01.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_normal_01.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wood_specular_01.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(planks01)
{
   mapTo = "planks-01-diff";
   diffuseMap[0] = "art/textures/textureLib/planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(planks_01_diff)
{
   mapTo = "planks_01_diff";
   diffuseMap[0] = "art/textures/textureLib/planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(planks02)
{
   mapTo = "planks-02-diff";
   diffuseMap[0] = "art/textures/textureLib/planks-02-diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks-02-nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(planks_02_diff)
{
   mapTo = "planks_02_diff";
   diffuseMap[0] = "art/textures/textureLib/planks_02_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/planks_02_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(small_brick01)
{
   mapTo = "small_brick-01-diff";
   diffuseMap[0] = "art/textures/textureLib/small_brick_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/small_brick_01_nm.dds";
   specularPower[0] = "19";
   diffuseMap[2] = "art/textures/textureLib/small_brick_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(felling02)
{
   mapTo = "felling-02-diff";
   diffuseMap[0] = "art/textures/textureLib/felling_02_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/felling_02_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(whitewash_mat)
{
   mapTo = "whitewash";
   diffuseMap[0] = "art/Textures/TextureLib/whitewash.dds";
   diffuseMap[1] = "art/Textures/TextureLib/whitewash_n.dds";
   materialTag0 = "LiF";
};

singleton Material(door01)
{
   mapTo = "door-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/door_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/door_01_nm.dds";
   specularPower[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/door_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(door_01_diff)
{
   mapTo = "door_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/door_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/door_01_nm.dds";
   specularPower[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/door_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(brick_big01)
{
   mapTo = "brick_big_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/brick_big_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/brick_big_01_nm.dds";
   specularPower[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/brick_big_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(stone_floor01)
{
   mapTo = "stone-floor-01-diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_floor_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_floor_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(roof_planks01)
{
   mapTo = "roof_planks-01-diff";
   diffuseMap[0] = "art/textures/textureLib/roof_planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/roof_planks_01_nm.dds";
   useAnisotropic[0] = "1";
   translucentBlendOp = "LerpAlpha";
   alphaTest = "1";
   alphaRef = "134";
   specularPower[0] = "1";
   doubleSided = "1";
   materialTag0 = "LiF";
};

singleton Material(roof_planks_01_diff)
{
   mapTo = "roof_planks_01_diff";
   diffuseMap[0] = "art/textures/textureLib/roof_planks_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/roof_planks_01_nm.dds";
   useAnisotropic[0] = "1";
   translucentBlendOp = "LerpAlpha";
   alphaTest = "1";
   alphaRef = "134";
   specularPower[0] = "1";
   doubleSided = "1";
   materialTag0 = "LiF";
};

singleton Material(felling01)
{
   mapTo = "felling-01-diff";
   diffuseMap[0] = "art/textures/textureLib/felling_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/felling_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(felling_01_diff)
{
   mapTo = "felling_01_diff";
   diffuseMap[0] = "art/textures/textureLib/felling_01_diff.dds";
   diffuseMap[1] = "art/textures/textureLib/felling_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(ovencoal_mat)
{
   mapTo = "ovencoal";
   diffuseMap[0] = "art/Textures/TextureLib/ovencoal.dds";
   materialTag0 = "LiF";
};

singleton Material(SmoothWood_mat)
{
   mapTo = "SmoothWood";
   diffuseMap[0] = "art/Textures/TextureLib/SmoothWood.dds";
   diffuseMap[1] = "art/Textures/TextureLib/SmoothWood_n.dds";
   materialTag0 = "LiF";
};

singleton Material(Distaff_mat)
{
   mapTo = "Distaff";
   diffuseMap[0] = "art/Textures/TextureLib/Distaff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Distaff_n.dds";
   materialTag0 = "LiF";
};

singleton Material(Wicker_01_mat)
{
   mapTo = "Wicker_01";
   diffuseMap[0] = "art/Textures/TextureLib/Wicker_01.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Wicker_01_n.dds";
   materialTag0 = "LiF";
};

singleton Material(cloth_color_mat)
{
   mapTo = "cloth_color";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_color.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_normals.dds";
};

singleton Material(cloth_nobump_mat)
{
   mapTo = "cloth_nobump";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_color.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_normals.dds";
   materialTag0 = "LiF";
};

// Unique textures

singleton Material(sack_mat)
{
   mapTo = "sack";
   diffuseMap[0] = "art/Textures/TextureLib/sack.dds";
   diffuseMap[1] = "art/Textures/TextureLib/sack_n.dds";
   materialTag0 = "LiF";
};

singleton Material(ExpensiveDesk_mat)
{
   mapTo = "ExpensiveDesk";
   diffuseMap[0] = "art/Textures/TextureLib/ExpensiveDesk.dds";
   diffuseMap[1] = "art/Textures/TextureLib/ExpensiveDesk_n.dds";
   materialTag0 = "LiF";
};


singleton Material(Utensil_d_mat)
{
   mapTo = "Utensil_d";
   diffuseMap[0] = "art/Textures/TextureLib/Utensil_d.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Utensil_n.dds";
   vertColor[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(barrel_mat)
{
   mapTo = "barrel";
   diffuseMap[0] = "art/Textures/TextureLib/barrel.dds";
   diffuseMap[1] = "art/Textures/TextureLib/barrel_n.dds";
   diffuseMap[2] = "art/Textures/TextureLib/barrel_S.dds";
   materialTag0 = "LiF";
};

singleton Material(utensil_02_mat)
{
   mapTo = "Utensil_02";
   diffuseMap[0] = "art/Textures/TextureLib/Utensil_02.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Utensil_02_n.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
};

singleton Material(Utensil_1_mat)
{
   mapTo = "Pasuda_d";
   diffuseMap[0] = "art/Textures/TextureLib/Utensil_d.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Utensil_n.dds";
   vertColor[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(decbed_diffuce_mat)
{
   mapTo = "decbed_diffuce";
   diffuseMap[0] = "art/Textures/TextureLib/decbed_diffuce.dds";
   diffuseMap[1] = "art/Textures/TextureLib/decbed_normals.dds";
   materialTag0 = "LiF";
};


singleton Material(Weapon_Pack_04_03_jpg_mat)
{
   mapTo = "Weapon_Pack_04_03.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Weapon_Pack_05B_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_05B_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(fakhverk_atlas_01_diff_mat)
{
   mapTo = "fakhverk_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/fakhverk_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/fakhverk_atlas_01_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(well_diffuse_mat)
{
    mapTo = "well_diffuse";
    diffuseMap[0] = "art/Textures/TextureLib/Well_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Well_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Well_SPECULAR.dds";
    materialTag0 = "LiF";
    doubleSided = "1";
    normal3DC = "1";
};

singleton Material(black_tex_mat)
{
    mapTo = "BlackTex";
    diffuseMap[0] = "art/Textures/TextureLib/Black.dds";
    materialTag0 = "LiF";
    doubleSided = "1";
};

singleton Material(thatched_01_diff_mat)
{
   mapTo = "thatched_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/thatched_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/thatched_01_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(thatched_02_diff_mat)
{
   mapTo = "thatched_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/thatched_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/thatched_02_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(wood_roof_01_diff_mat)
{
   mapTo = "wood_roof_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_roof_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Wood_roof_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Wood_roof_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
   specularPower[0] = "38";
   pixelSpecular[0] = "1";
};

singleton Material(wood_moss_01_diff_mat)
{
   mapTo = "wood_moss_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_moss_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_moss_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wood_moss_01_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   specularPower[0] = "56";
   pixelSpecular[0] = "1";
};

singleton Material(bark_02_diff_mat)
{
   mapTo = "bark_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/bark_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/bark_02_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(Weapon_Pack_06_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_06_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_06_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_06_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_06_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};


singleton Material(Weapon_Pack_07_DIFFUSE_01_jpg_mat)
{
   mapTo = "Weapon_Pack_07_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_07_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_07_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_07_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Horse_DIFFUSE_WHITE_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BLACK_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_BLACK_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BW_01_png_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BW_01.png";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_WHITE_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BLACK_01_png_mat)
{
   mapTo = "Horse_DIFFUSE_BLACK_01.png";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BW_01_png_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BW_01.png";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(fence_wood_diff_mat)
{
   mapTo = "fence_wood_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fence_wood_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fence_wood_nm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
};

singleton Material(brick_big_02_diff_mat)
{
   mapTo = "brick_big_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/brick_2.dds";
   diffuseMap[1] = "art/Textures/TextureLib/brick_2_normal.dds";
   diffuseMap[2] = "art/Textures/TextureLib/brick_2_spec.dds";
   materialTag0 = "LiF";
   materialTag0 = "LiF";
};

singleton Material(rivet_diff_mat)
{
   mapTo = "rivet_diff";
   diffuseMap[0] = "art/Textures/TextureLib/rivet_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/rivet_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(shops_02_atlas_diff_mat)
{
   mapTo = "shops_02_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/shops_02_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_02_atlas_nm.dds";
   materialTag0 = "LiF";
   specularPower[0] = "2";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Weapon_Pack_06_DIFFUSE_01_mat)
{
   mapTo = "Weapon_Pack_06_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_06_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_06_NORMALMAP_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};


singleton Material(Deer_Diffuse_mat)
{
   mapTo = "Deer_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_Male_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_Male_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Deer/Deer_Male_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Deer_D_Diffuse_mat)
{
   mapTo = "Deer_D_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_Normal.dds";
   materialTag0 = "LiF";
};


singleton Material(Heavy_Horse1_DIFFUSE_05_jpg_mat)
{
   mapTo = "Heavy_Horse1_DIFFUSE_05.jpg";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse1_DIFFUSE_05_jpg_mat)
{
   mapTo = "Heavy_Horse1_DIFFUSE_05.jpg";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(stone_big_diff_mat)
{
   mapTo = "stone_big_diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_big_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_big_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/stone_big_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(floor_diff_mat)
{
   mapTo = "floor_diff";
   diffuseMap[0] = "art/Textures/TextureLib/floor_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/floor_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(stone_big_moss_diff_mat)
{
   mapTo = "stone_big_moss_diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_big_moss_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_big_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/stone_big_moss_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Sheep_Diffuse2_mat)
{
   mapTo = "Sheep_Diffuse2";
   diffuseMap[0] = "art/Textures/Animals/Sheep/Sheep_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Sheep/Sheep_Normal.dds";
   materialTag0 = "LiF";
};

singleton Material(WildHorse_D_mat)
{
   mapTo = "WildHorse_D";
   diffuseMap[0] = "art/Textures/Animals/wildhorse/WildHorse_D.dds";
   diffuseMap[1] = "art/Textures/Animals/wildhorse/WildHorse_N.dds";
   materialTag0 = "LiF";
   //doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   skinned = true;
};

singleton Material(WildHorse_D_D_mat)
{
   mapTo = "WildHorse_D_D";
   diffuseMap[0] = "art/Textures/Animals/wildhorse/WildHorse_D.dds";
   diffuseMap[1] = "art/Textures/Animals/wildhorse/WildHorse_N.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
};

singleton Material(Pig_Diffuse_2_mat)
{
   mapTo = "Pig_Diffuse_2";
   diffuseMap[0] = "art/Textures/Animals/domesticPig/Pig_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/domesticPig/Pig_Normals.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(plaster_diff_mat)
{
   mapTo = "plaster_diff";
   diffuseMap[0] = "art/Textures/TextureLib/plaster_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/plaster_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(tent_cloth_mat)
{
   mapTo = "tent_cloth_diff";
   diffuseMap[0] = "art/Textures/TextureLib/tent_cloth_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
};

singleton Material(tent_cloth_diff_decor_mat)
{
   mapTo = "tent_cloth_diff_decor";
   diffuseMap[0] = "art/Textures/Atlas/tent_cloth_diff_decor.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
};

singleton Material(ruins_diff_mat)
{
   mapTo = "ruins_diff";
   diffuseMap[0] = "art/Textures/TextureLib/ruins_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/ruins_nm.dds";
   specularPower[0] = "128";
   pixelSpecular[0] = "1";
   diffuseMap[2] = "art/Textures/TextureLib/ruins_diff.dds";
   diffuseMap[12] = "art/Textures/TextureLib/ruins_emiss.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   emission="1";
   emissionIntensityFreq="0.35";
   emissionIntensityMin="0.5";
   emissionIntensityMax="1.5";
   emissionScale="0.04";
};

singleton Material(blacksmith_atlas_diff_mat)
{
   mapTo = "blacksmith-atlas-diff";
   diffuseMap[0] = "art/Textures/Atlas/shops-01-atlas-diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops-01-atlas-nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops-01-atlas-spec.dds";
   materialTag0 = "LiF";
};

singleton Material(apple_tex_mat)
{
   mapTo = "apple_tex";
   diffuseMap[0] = "art/models/3d/environment/trees/apple/texture/apple_tex_d.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   diffuseMap[1] = "art/models/3d/environment/trees/apple/texture/apple_tex_n.dds";
   materialTag0 = "LiF";
};

singleton Material(CommonHorseFootprint)
{
   diffuseMap[0] = "art/2D/Terrain/Footsteps/horse_footprint.dds";
   vertColor[0] = true;
   translucent = true;
   castShadows = "0";
   translucentZWrite = "1";
};

singleton Material(detail_wine_mat)
{
   mapTo = "detail_wine";
   diffuseMap[0] = "art/Textures/TextureLib/detail_wine.dds";
   diffuseMap[1] = "art/Textures/TextureLib/detail_wine_nrm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/detail_wine_SPEC.dds";
   materialTag0 = "LiF";
   specularPower[0] = "54";
   pixelSpecular[0] = "1";
   alphaTest = "1";
   alphaRef = "54";
};

singleton Material(roof_tile_diff_mat)
{
   mapTo = "roof_tile_diff";
   diffuseMap[0] = "art/Textures/TextureLib/roof_tile_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/roof_tile_nm.dds";
   materialTag0 = "LiF";
   pixelSpecular[0] = "1";
   specularPower[0] = "38";
   doubleSided = "1";
};

singleton Material(roof_tile_inside_diff_mat)
{
    mapTo = "roof_tile_inside_diff";
    diffuseMap[0] = "art/Textures/TextureLib/roof_tile_inside_diff.dds";
    diffuseMap[1] = "art/Textures/TextureLib/roof_tile_inside_nm.dds";
    materialTag0 = "LiF";
    pixelSpecular[0] = "1";
    specularPower[0] = "38";
    doubleSided = "1";
};

singleton Material(Milaneese_Armor_DIFFUSE_01_nonskined_mat)
{
   mapTo = "Milaneese_Armor_DIFFUSE_01_nonskined";
   diffuseMap[0] = "art/Textures/NonSkinnedArmors/Milaneese_Armor_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/NonSkinnedArmors/Milaneese_Armor_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/NonSkinnedArmors/Milaneese_Armor_SPECULAR_01.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   //envmap = true;
   //fChrome = 1;
};

singleton Material(bull_diffuse4_mat)
{
   mapTo = "bull_diffuse4";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_normals.dds";
   materialTag0 = "LiF";
};

singleton Material(Cow_diffuse4_mat)
{
   mapTo = "Cow_diffuse4";
   diffuseMap[0] = "art/Textures/Animals/Cow/Cow_diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Cow/Cow_Normals.dds";
   materialTag0 = "LiF";
};

singleton Material(WildBull_diffuse_mat)
{
   mapTo = "WildBull_diffuse";
   diffuseMap[0] = "art/Textures/Animals/AurochsBull/WildBull_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/AurochsBull/WildBull_Normals.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "46";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(WildBull_D_diffuse_mat)
{
   mapTo = "WildBull_D_diffuse";
   diffuseMap[0] = "art/Textures/Animals/AurochsBull/WildBull_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/AurochsBull/WildBull_Normals.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "46";
   materialTag0 = "LiF";
};

singleton Material(WildCow_Diffuse_mat)
{
   mapTo = "WildCow_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/AurochsCow/WildCow_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/AurochsCow/WildCow_Normals.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "46";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(WildCow_D_Diffuse_mat)
{
   mapTo = "WildCow_D_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/AurochsCow/WildCow_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/AurochsCow/WildCow_Normals.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "46";
   materialTag0 = "LiF";
};

singleton Material(cloth_02_diff_mat)
{
   mapTo = "cloth_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_normals.dds";
   materialTag0 = "LiF";
};

singleton Material(Rock01Mat_mat)
{
   mapTo = "Rock01Mat";
   diffuseMap[0] = "art/Textures/GroundCover/Rock_Det.dds";
   materialTag0 = "LiF";
};

singleton Material(Rock02Mat_mat)
{
   mapTo = "Rock02Mat";
   diffuseMap[0] = "art/Textures/GroundCover/Rock_Det.dds";
   materialTag0 = "LiF";
};

singleton Material(GrassRockMat_mat)
{
   mapTo = "GrassRockMat";
   diffuseMap[0] = "art/Textures/GroundCover/Grassrock.dds";
   diffuseMap[1] = "art/Textures/GroundCover/GrassrockNm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "10";
};

singleton Material(ForestMat_mat)
{
   mapTo = "ForestMat";
   diffuseMap[0] = "art/Textures/GroundCover/Forest.dds";
   diffuseMap[1] = "art/Textures/GroundCover/ForestNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/ForestSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   materialTag0 = "LiF";
   castShadows = "0";
};

singleton Material(LogMat_mat)
{
   mapTo = "LogMat";
   diffuseMap[0] = "art/Textures/GroundCover/Log01.dds";
   diffuseMap[1] = "art/Textures/GroundCover/Log01Nm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/Log01Spec.dds";
   materialTag0 = "LiF";
};

singleton Material(SwampMat_mat)
{
   mapTo = "SwampMat";
   diffuseMap[0] = "art/Textures/GroundCover/Swam.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SwamNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/SwamSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   materialTag0 = "LiF";
   castShadows = "0";
   streamable = "0";
};

singleton Material(SteppeMat_mat)
{
   mapTo = "SteppeMat";
   diffuseMap[0] = "art/Textures/GroundCover/Steppe.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SteppeNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/SteppeSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   materialTag0 = "LiF";
   castShadows = "0";
   streamable = "0";
};

singleton Material(Boar_Diffuse_mat)
{
   mapTo = "Boar_Male_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/boar/Boar_Male_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/boar/Boar_Male_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/boar/Boar_Male_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
   normal3DC="1";
};

singleton Material(Boar_D_Diffuse_mat)
{
   mapTo = "Boar_Male_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/boar/Boar_Male_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/boar/Boar_Male_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/boar/Boar_Male_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   normal3DC="1";
};

singleton Material(Bear_Diffuse_mat)
{
   mapTo = "Bear_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/bear/Bear_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/bear/Bear_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bear/Bear_SPECULAR.dds";
   normal3DC="1";
   //doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Bear_D_Diffuse_mat)
{
   mapTo = "Bear_D_Diffuse";
   diffuseMap[0] = "art/Textures/Animals/bear/Bear_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/bear/Bear_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bear/Bear_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   normal3DC = "1";
};

singleton Material(Sow_DiffuseFinal_mat)
{
   mapTo = "Sow_DiffuseFinal";
   diffuseMap[0] = "art/Textures/Animals/sow/Sow_DiffuseFinal.dds";
   diffuseMap[1] = "art/Textures/Animals/sow/SowNormalsFinal2.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Sow_D_DiffuseFinal_mat)
{
   mapTo = "Sow_D_DiffuseFinal";
   diffuseMap[0] = "art/Textures/Animals/sow/Sow_DiffuseFinal.dds";
   diffuseMap[1] = "art/Textures/Animals/sow/SowNormalsFinal2.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
};

singleton Material(Boar_Female_DIFFUSE_mat)
{
   mapTo = "Boar_Female_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/boar/Boar_Female_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/boar/Boar_Female_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/boar/Boar_Female_SPECULAR.dds";
   normal3DC="1";
   //doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};


singleton Material(Boar_Female_D_DIFFUSE_mat)
{
   mapTo = "Boar_Female_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/boar/Boar_Female_D_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/boar/Boar_Female_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/boar/Boar_Female_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   normal3DC = "1";
};

singleton Material(Bull_Female_DIFFUSE_mat)
{
   mapTo = "Bull_Female_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_Female_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_Female_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bull/Bull_Female_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   skinned = true;
   normal3DC="1";
};

singleton Material(Bull_Female_D_DIFFUSE_mat)
{
   mapTo = "Bull_Female_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_Female_D_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_Female_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bull/Bull_Female_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   normal3DC="1";
};

singleton Material(Deer_Female_DIFFUSE_mat)
{
   mapTo = "Deer_Female_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_Female_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_Female_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Deer/Deer_Female_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   skinned = true;
   normal3DC="1";
};

singleton Material(Deer_Female_D_DIFFUSE_mat)
{
   mapTo = "Deer_Female_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_Female_D_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_Female_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Deer/Deer_Female_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   normal3DC="1";
};

singleton Material(DummyStand_DIFFUSE_mat)
{
    mapTo = "DummyStand_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/DummyStand_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/DummyStand_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/DummyStand_SPECULAR.dds";
    normal3DC = "1";
    //skinned = true;
};

singleton Material(Shovels_n_Picks_DIFFUSE_02_jpg_mat)
{
   mapTo = "Shovels_n_Picks_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Tools/Shovels_n_Picks_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Shovels_n_Picks_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Shovels_n_Picks_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Pickaxe_pack1_diff_mat)
{
    mapTo = "Pickaxe_pack1_diff";
    diffuseMap[0] = "art/Textures/Tools/Pickaxe_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Tools/Pickaxe_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Tools/Pickaxe_SPECULAR.dds";
    materialTag0 = "LiF";
    normal3DC = "1";
};

singleton Material(Shovel_Pack1_mat)
{
    mapTo = "Shovel_Pack1";
    diffuseMap[0] = "art/Textures/Tools/Shovel_Pack1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Tools/Shovel_Pack1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Tools/Shovel_Pack1_SPECULAR.dds";
    materialTag0 = "LiF";
    normal3DC = "1";
};

singleton Material(Shovel_Pack1_skinC_mat)
{
    mapTo = "Shovel_Pack1_skinC";
    diffuseMap[0] = "art/Textures/Tools/Shovel_Pack1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Tools/Shovel_Pack1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Tools/Shovel_Pack1_SPECULAR.dds";
    materialTag0 = "LiF";
    normal3DC = "1";
};

singleton Material(Shovel_Pack2_mat)
{
    mapTo = "Shovel_Pack2";
    diffuseMap[0] = "art/Textures/Tools/Shovel_Pack2_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Tools/Shovel_Pack2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Tools/Shovel_Pack2_SPECULAR.dds";
    materialTag0 = "LiF";
    normal3DC = "1";
};

singleton Material(Sickles_n_Hammers_DIFFUSE_01_jpg_mat)
{
   mapTo = "Sickles_n_Hammers_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Tools/Sickles_n_Hammers_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Sickles_n_Hammers_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Sickles_n_Hammers_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Sickle_pack1_mat)
{
    mapTo = "Sickle_pack1";
    diffuseMap[0] = "art/Textures/Tools/Sickle_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Tools/Sickle_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Tools/Sickle_SPECULAR.dds";
    materialTag0 = "LiF";
    normal3DC = "1";
};

singleton Material(Swas_n_Pots_DIFFUSE_01_mat)
{
   mapTo = "Swas_n_Pots_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Tools/Swas_n_Pots_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Swas_n_Pots_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Swas_n_Pots_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Swas_n_Pots_DIFFUSE_01_jpg_mat)
{
   mapTo = "Swas_n_Pots_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Tools/Swas_n_Pots_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Swas_n_Pots_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Swas_n_Pots_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Add_Swords_DIFFUSE_02_jpg_mat)
{
   mapTo = "Add_Swords_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Add_Swords_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Add_Swords_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Add_Swords_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

singleton Material(Add_Swords_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Add_Swords_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Add_Swords_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Add_Swords_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Add_Swords_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
   skinned = true;
};

singleton Material(Mutton_ready_diff_mat)
{
   mapTo = "Mutton_ready_diff";
   diffuseMap[0] = "art/Textures/Animals/mutton/Mutton_ready_diff.dds";
   diffuseMap[1] = "art/Textures/Animals/mutton/Mutton_ready_normal.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Mutton_ready_D_diff_mat)
{
   mapTo = "Mutton_ready_D_diff";
   diffuseMap[0] = "art/Textures/Animals/mutton/Mutton_ready_diff.dds";
   diffuseMap[1] = "art/Textures/Animals/mutton/Mutton_ready_normal.dds";
   materialTag0 = "LiF";
};

singleton Material(Wolf_DIFFUSE_mat)
{
   mapTo = "Wolf_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/wolf/Wolf_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/wolf/Wolf_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/wolf/Wolf_SPECULAR.dds";
   diffuseMap[12] = "art/Textures/Animals/wolf/Wolf_EMISSIVE.dds";
   normal3DC="1";
   emission="1";
   emissionIntensityFreq="0.75";
   emissionIntensityMin="1.5";
   emissionIntensityMax="4";
   emissionScale="0.25";
   alphaTest = "1";
   alphaRef = "80";
   skinned = true;
};

singleton Material(Wolf_D_DIFFUSE_mat)
{
   mapTo = "Wolf_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/wolf/Wolf_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/wolf/Wolf_NORMAL.dds";
   diffuseMap[2] = "art/Textures/Animals/wolf/Wolf_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "80";
};

singleton Material(Moose_DIFFUSE_mat)
{
   mapTo = "Moose_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/moose/Moose_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/moose/Moose_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/moose/Moose_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Moose_D_DIFFUSE_mat)
{
   mapTo = "Moose_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/moose/mooze_diff2.dds";
   diffuseMap[1] = "art/Textures/Animals/moose/mooze_norm2.dds";
   materialTag0 = "LiF";
};

singleton Material(Grouse_diff_fixed2_mat)
{
   mapTo = "Grouse_diff_fixed2";
   diffuseMap[0] = "art/Textures/Animals/grouse/Grouse_diff_fixed2.dds";
   diffuseMap[1] = "art/Textures/Animals/grouse/Grouse_nrm_fixed.dds";
   //doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Grouse_D_diff_fixed2_mat)
{
   mapTo = "Grouse_D_diff_fixed2";
   diffuseMap[0] = "art/Textures/Animals/grouse/Grouse_diff_fixed2.dds";
   diffuseMap[1] = "art/Textures/Animals/grouse/Grouse_nrm_fixed.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
};

singleton Material(Rabbit_DIFFUSE_mat)
{
   mapTo = "Rabbit_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/hare/Rabbit_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/hare/Rabbit_NORMAL.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Rabbit_D_DIFFUSE_mat) //corpse mat
{
   mapTo = "Rabbit_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/hare/Rabbit_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/hare/Rabbit_NORMAL.dds";
   materialTag0 = "LiF";
};

singleton Material(common_plant_herbal_plants_atlas)
{
   mapTo = "herbal_plants_atlas";
   diffuseMap[0] = "art/Textures/Atlas/herbal_plants_atlas_diff.dds";
   specular[0] = "0.9 0.9 0.9 1";
   specularPower[0] = "1";
   translucentBlendOp = "LerpAlpha";
   diffuseMap[1] = "art/Textures/Atlas/herbal_plants_atlas_nm.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   translucent = "0";
   translucentZWrite = "0";
   alphaTest = "1";
   alphaRef = "13";
   materialTag0 = "LiF";
};

singleton Material(fountain_diff_mat)
{
   mapTo = "fountain_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fountain_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fountain_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/fountain_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(water_diff_mat)
{
   mapTo = "water_diff";
   diffuseMap[0] = "art/Textures/TextureLib/water_diff.dds";
   diffuseColor[0] = "0.996078 0.996078 0.996078 1";
   specular[0] = "0.8 0.972549 0.996078 1";
   specularPower[0] = "8";
   useAnisotropic[0] = "1";
   glow[0] = "1";
   emissive[0] = "1";
   doubleSided = "1";
   animFlags[0] = "0x00000001";
   scrollDir[0] = "0 -0.31";
   scrollSpeed[0] = "0.824";
   translucent = "1";
   translucentZWrite = "1";
   alphaRef = "0";
   showFootprints = "0";
   showDust = "1";
   materialTag0 = "LiF";
   castShadows = "0";
};

singleton Material(fabric_diff_mat)
{
   mapTo = "fabric_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fabric_diff.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
   diffuseMap[1] = "art/Textures/TextureLib/fabric_nm.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(male_blacksmith_diff_mat)
{
   mapTo = "male_blacksmith_diff";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/blacksmith/male_blacksmith_diff.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/male_blacksmith_norm.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/blacksmith/male_blacksmith_spec.dds";
   doubleSided = "1";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Forest_GC_tex_mat)
{
   mapTo = "Forest_GC_tex";
   diffuseMap[0] = "art/Textures/GroundCover/Forest.dds";
   diffuseMap[1] = "art/Textures/GroundCover/ForestNm.dds";
   diffuseMap[2] = "art/Textures/GroundCover/ForestSpec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "50";
   castShadows = "0";
   materialTag0 = "LiF";
   streamable = "0";
};

singleton Material(cog_diff_mat)
{
   mapTo = "cog_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cog_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cog_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_01_diff_mat)
{
   mapTo = "monument_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_01_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_02_diff_mat)
{
   mapTo = "monument_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_02_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_03_diff_mat)
{
   mapTo = "monument_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_03_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_03_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(monument_04_diff_mat)
{
   mapTo = "monument_04_diff";
   diffuseMap[0] = "art/Textures/TextureLib/monument_04_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/monument_04_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/monument_04_spec.dds";
   materialTag0 = "LiF";
};

singleton CubemapData(FairCubemap)
{
   cubeFace[0] = "art/2D/Skybox/FairSky/sky_Fair_Right.dds";
   cubeFace[1] = "art/2D/Skybox/FairSky/sky_Fair_Left.dds";
   cubeFace[2] = "art/2D/Skybox/FairSky/sky_Fair_Back.dds";
   cubeFace[3] = "art/2D/Skybox/FairSky/sky_Fair_Front.dds";
   cubeFace[4] = "art/2D/Skybox/FairSky/sky_Fair_Top.dds";
   cubeFace[5] = "art/2D/Skybox/FairSky/sky_Fair_Bottom.dds";
};

singleton CubemapData(DuskLightCubemap)
{
   cubeFace[0] = "art/2D/Skybox/DuskLight/sky_dusk_Right.dds";
   cubeFace[1] = "art/2D/Skybox/DuskLight/sky_dusk_Left.dds";
   cubeFace[2] = "art/2D/Skybox/DuskLight/sky_dusk_Back.dds";
   cubeFace[3] = "art/2D/Skybox/DuskLight/sky_dusk_Front.dds";
   cubeFace[4] = "art/2D/Skybox/DuskLight/sky_dusk_Top.dds";
   cubeFace[5] = "art/2D/Skybox/DuskLight/sky_dusk_Bottom.dds";
};

singleton CubemapData(DuskLight2Cubemap)
{
   cubeFace[0] = "art/2D/Skybox/DuskLight2/sky_dusk2_Right.dds";
   cubeFace[1] = "art/2D/Skybox/DuskLight2/sky_dusk2_Left.dds";
   cubeFace[2] = "art/2D/Skybox/DuskLight2/sky_dusk2_Back.dds";
   cubeFace[3] = "art/2D/Skybox/DuskLight2/sky_dusk2_Front.dds";
   cubeFace[4] = "art/2D/Skybox/DuskLight2/sky_dusk2_Top.dds";
   cubeFace[5] = "art/2D/Skybox/DuskLight2/sky_dusk2_Bottom.dds";
};

singleton CubemapData(NightCubemap)
{
   cubeFace[0] = "art/2D/Skybox/nightSky/skybox_1";
   cubeFace[1] = "art/2D/Skybox/nightSky/skybox_2";
   cubeFace[2] = "art/2D/Skybox/nightSky/skybox_3";
   cubeFace[3] = "art/2D/Skybox/nightSky/skybox_4";
   cubeFace[4] = "art/2D/Skybox/nightSky/skybox_5";
   cubeFace[5] = "art/2D/Skybox/nightSky/skybox_6";
};

singleton CubemapData(FoggyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/FoggySky/sky_Foggy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/FoggySky/sky_Foggy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/FoggySky/sky_Foggy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/FoggySky/sky_Foggy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/FoggySky/sky_Foggy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/FoggySky/sky_Foggy_Bottom.dds";
};

singleton CubemapData(SnowyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/SnowySky/Sky_Snowy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/SnowySky/Sky_Snowy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/SnowySky/Sky_Snowy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/SnowySky/Sky_Snowy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/SnowySky/Sky_Snowy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/SnowySky/Sky_Snowy_Bottom.dds";
};

singleton CubemapData(CloudyCubemap)
{
   cubeFace[0] = "art/2D/Skybox/CloudySky/sky_Cloudy_Right.dds";
   cubeFace[1] = "art/2D/Skybox/CloudySky/sky_Cloudy_Left.dds";
   cubeFace[2] = "art/2D/Skybox/CloudySky/sky_Cloudy_Back.dds";
   cubeFace[3] = "art/2D/Skybox/CloudySky/sky_Cloudy_Front.dds";
   cubeFace[4] = "art/2D/Skybox/CloudySky/sky_Cloudy_Top.dds";
   cubeFace[5] = "art/2D/Skybox/CloudySky/sky_Cloudy_Bottom.dds";
};

singleton CubemapData(StartingIslandCubemap)
{
   cubeFace[0] = "art/2D/Skybox/StartingIslandSky/sky_StartingIsland_Right.dds";
   cubeFace[1] = "art/2D/Skybox/StartingIslandSky/sky_StartingIsland_Left.dds";
   cubeFace[2] = "art/2D/Skybox/StartingIslandSky/sky_StartingIsland_Back.dds";
   cubeFace[3] = "art/2D/Skybox/StartingIslandSky/sky_StartingIsland_Front.dds";
   cubeFace[4] = "art/2D/Skybox/StartingIslandSky/sky_StartingIsland_Top.dds";
   cubeFace[5] = "art/2D/Skybox/StartingIslandSky/sky_StartingIsland_Bottom.dds";
};

singleton Material(GC_Soil)
{
   mapTo = "_03";
   diffuseColor[0] = "0.733333 0.733333 0.733333 1";
   diffuseMap[0] = "art/Textures/GroundCover/Soil.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SoilNm.dds";
   castShadows = "0";
   alphaTest = "1";
   alphaRef = "60";
   showFootprints = "0";
   materialTag0 = "LiF_GC";
   doubleSided = "1";
   streamable = "0";
};

singleton Material(felling_02_diff_mat)
{
   mapTo = "felling_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/felling_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/felling_02_nm.dds";
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
   doubleSided = "1";
};


singleton Material(sack_03_diff_mat)
{
   mapTo = "sack_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/sack_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/sack_03_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(ancient_diff_mat)
{
   mapTo = "ancient_diff";
   diffuseMap[0] = "art/Textures/Atlas/ancient_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/ancient_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/ancient_spec.dds";
   materialTag0 = "LiF";
};


singleton Material(Throwing_Stuff_01_png_mat)
{
   mapTo = "Throwing_Stuff_01.png";
   diffuseMap[0] = "art/Textures/Weapons/Throwing_Stuff_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Throwing_Stuff_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Throwing_Stuff_SPECULAR_01.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Throwing_Stuff_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Throwing_Stuff_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Throwing_Stuff_DIFFUSE_01_skin.dds";
   diffuseMap[1] = "art/Textures/Weapons/Throwing_Stuff_NORMALMAP_01_skin.dds";
   diffuseMap[2] = "art/Textures/Weapons/Throwing_Stuff_SPECULAR_01_skin.dds";
   alphaTest = "1";
   alphaRef = "100";
   skinned = true;
};

singleton Material(cloth_trap_diff_mat)
{
   mapTo = "cloth_trap_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_trap_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_trap_nm.dds";
   alphaTest = "1";
   alphaRef = "10";
};

singleton Material(small_brick_01_diff_mat)
{
   mapTo = "small_brick_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/small_brick_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/small_brick_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/small_brick_01_spec.dds";
   specularPower[0] = "19";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};


singleton Material(fmrobe_mat)
{
   mapTo = "fmrobe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/female/FMrobeD.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/female/FMrobeN.dds";
   skinned = true;
};

singleton Material(wood_floor_01_diff_mat2)
{
   mapTo = "wood_floor_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_floor_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_floor_01_nm.dds";
   materialTag0 = "LiF";
   normal3DC="1";
};

singleton Material(skinnedcorpse_diff_mat)
{
   mapTo = "skinnedcorpse_diff";
   diffuseMap[0] = "art/Textures/TextureLib/skinnedcorpse_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/skinnedcorpse_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/skinnedcorpse_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(all_plants_diff_mat)
{
   mapTo = "all_plants_diff";
   diffuseMap[0] = "art/Textures/GroundCover/all_plants_diff.dds";
   diffuseMap[1] = "art/Textures/GroundCover/all_plants_nm.dds";
   doubleSided = "1";
   translucent = "0";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "30";
   streamable = "0";
   normalsUp = "1";
};

singleton Material(planks_03_diff_mat)
{
   mapTo = "planks_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/planks_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/planks_02_nm.dds";
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
};

singleton Material(moss_diff_mat)
{
   mapTo = "moss_diff";
   diffuseMap[0] = "art/Textures/TextureLib/moss_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/moss_nm.dds";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "218";
   doubleSided = "1";
};

singleton Material(Decal_Streaks_diff_mat)
{
   mapTo = "Decal_Streaks_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_Streaks_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   castShadows = "1";
   alphaTest = "1";
   alphaRef = "134";
   doubleSided = "1";
};

singleton Material(Moss_Log_diff_mat)
{
   mapTo = "Moss_Log_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Moss_Log_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Moss_Log_nm.dds";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "94";
   doubleSided = "1";
};

singleton Material(roof_tile_mat)
{
   mapTo = "roof_tile";
   diffuseMap[0] = "art/Textures/TextureLib/roof_tile_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/roof_tile_nm.dds";
};

singleton Material(Decal_Lichens_diff_mat)
{
   mapTo = "Decal_Lichens_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_Lichens_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Decal_Lichens_nm.dds";
   materialTag0 = "LiF";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "193";
   translucent = "0";
   castShadows = "0";
};

singleton Material(Decal_HangingIvy_diff_mat)
{
   mapTo = "Decal_HangingIvy_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_HangingIvy_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Decal_HangingIvy_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Decal_HangingIvy_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "132";
   translucent = "0";
   translucentBlendOp = "None";
   doubleSided = "1";
};

singleton Material(cloth_01_diff_mat)
{
   mapTo = "cloth_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/cloth_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/cloth_01_nm.dds";
   normal3DC = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "132";
};

singleton Material(glass_diff_mat)
{
   mapTo = "glass_diff";
   diffuseMap[0] = "art/Textures/TextureLib/glass_diff.dds";
   diffuseMap[2] = "art/Textures/TextureLib/glass_spec.dds";
   specularScale = "0.01";
   doubleSided = "1";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   translucentZWrite = "1";
   alphaTest = "1";
   doNotZWrite = "1";
};

singleton Material(glass_broken_diff_mat)
{
   mapTo = "glass_broken_diff";
   diffuseMap[0] = "art/Textures/TextureLib/glass_broken_diff.dds";
   translucentBlendOp = "AddAlpha";
   alphaTest = "1";
   alphaRef = "9";
   materialTag0 = "LiF";
   doubleSided = "1";
   translucent = "1";
};

singleton Material(tombstone_01_diff_mat)
{
   mapTo = "tombstone_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/tombstone_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/tombstone_01_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(tombstone_02_diff_mat)
{
   mapTo = "tombstone_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/tombstone_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/tombstone_02_nm.dds";
   materialTag0 = "LiF";
};

singleton Material(wood_roof_01_alpha_diff_mat)
{
   mapTo = "wood_roof_01_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_roof_01_alpha_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_roof_01_alpha_nm.dds";
   materialTag0 = "LiF";
   specularPower[0] = "38";
   pixelSpecular[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "242";
};

singleton Material(wood_roof_01_alpha_diff_mat)
{
   mapTo = "wood_roof_01_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/wood_roof_01_alpha_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wood_roof_01_alpha_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "242";
};

singleton Material(fakhverk_atlas_02_diff_mat)
{
   mapTo = "fakhverk_atlas_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/fakhverk_atlas_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/fakhverk_atlas_02_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(House_detail_atlas_1_diff_mat)
{
   mapTo = "House_detail_atlas_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/House_detail_atlas_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/House_detail_atlas_1_nm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "134";
   materialTag0 = "LiF";
};


singleton Material(House_plants_01_diff_mat)
{
   mapTo = "House_plants_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/House_plants_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/House_plants_01_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "67";
};

singleton Material(Rope_2_diff_mat)
{
   mapTo = "Rope_2_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_2_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_2_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
};

singleton Material(roof_tile_2_alpha_diff_mat)
{
   mapTo = "roof_tile_2_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/roof_tile_2_alpha_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/roof_tile_2_alpha_nm.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "238";
   specularPower[0] = "38";
   pixelSpecular[0] = "1";
};

singleton Material(roof_tile_2_alpha_inside_diff_mat)
{
    mapTo = "roof_tile_2_alpha_inside_diff";
    diffuseMap[0] = "art/Textures/TextureLib/roof_tile_2_alpha_inside_diff.dds";
    diffuseMap[1] = "art/Textures/TextureLib/roof_tile_2_alpha_inside_nm.dds";
    materialTag0 = "LiF";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "238";
    specularPower[0] = "38";
    pixelSpecular[0] = "1";
};

singleton Material(rBlast_mat)
{
   mapTo = "rBlast";
   diffuseMap[0] = "art/decals/rBlast.dds";
   doubleSided = "1";
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
   alphaTest = "1";
   alphaRef = "127";
   materialTag0 = "LiF";
};

singleton Material(stone_big_angle_diff_mat)
{
   mapTo = "stone_big_angle_diff";
   diffuseMap[0] = "art/Textures/TextureLib/stone_big_angle_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/stone_big_nm.dds";
   materialTag0 = "LiF";
   diffuseMap[2] = "art/Textures/TextureLib/stone_big_spec.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "127";
};

singleton Material(Rope_1_diff_mat)
{
   mapTo = "Rope_1_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_1_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_1_nm.dds";
   materialTag0 = "LiF";
};
singleton Material(Rope_1_skinned_diff_mat)
{
   mapTo = "Rope_1_skinned_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_1_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_1_nm.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(robe_D_male_mat)
{
   mapTo = "robe_D";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/male/robe_D.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/male/robe_N.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/male/robe_S.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Decal_Mud_diff_mat)
{
   mapTo = "Decal_Mud_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Decal_Mud_diff.dds";
   translucent = "1";
   materialTag0 = "LiF";
   castShadows = "1";
   translucentBlendOp = "None";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
};

singleton Material(throne_diff_mat)
{
   mapTo = "throne_diff";
   diffuseMap[0] = "art/Textures/TextureLib/throne_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/throne_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/throne_spec.dds";
};

singleton Material(herbal_plants_atlas_diff_mat)
{
   mapTo = "herbal_plants_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/herbal_plants_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/herbal_plants_atlas_nm.dds";
   alphaTest = "1";
   alphaRef = "87";
};

singleton Material(Rock_diff_mat)
{
   mapTo = "Rock_diff";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock/Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock/Rock_nm.dds";
   normal3DC="1";
   materialTag0 = "LiF";
};

singleton Material(Rock_diff_mat_v2)
{
   mapTo = "rock_diff";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock/Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock/Rock_nm.dds";
   normal3DC="1";
   materialTag0 = "LiF";
};

singleton Material(Rock_01_diff_mat)
{
    mapTo = "Rock_01_diff";
    diffuseMap[0] = "art/Textures/TextureLib/Rock_01_diff.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Rock_01_nm.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Rock_01_spec.dds";
    normal3DC = "1";
    materialTag0 = "LiF";
};

singleton Material(Rock_02_diff_mat)
{
    mapTo = "Rock_02_diff";
    diffuseMap[0] = "art/Textures/TextureLib/Rock_02_diff.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Rock_02_nm.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Rock_02_spec.dds";
    normal3DC = "1";
    materialTag0 = "LiF";
};

singleton Material(Rock_03_diff_mat)
{
    mapTo = "Rock_03_diff";
    diffuseMap[0] = "art/Textures/TextureLib/Rock_03_diff.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Rock_03_nm.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Rock_03_spec.dds";
    normal3DC = "1";
    materialTag0 = "LiF";
};

singleton Material(wall_metal_mat)
{
   mapTo = "wall_metal";
   diffuseMap[0] = "art/Textures/TextureLib/wall_metal.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wall_metal_normal.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wall_metal_spec.dds";
};

singleton Material(brick_2_mat)
{
   mapTo = "brick_2";
   diffuseMap[0] = "art/Textures/TextureLib/brick_2.dds";
   diffuseMap[1] = "art/Textures/TextureLib/brick_2_normal.dds";
   materialTag0 = "LiF";
};

singleton Material(Trebushet_atlas_01_diff_mat)
{
   mapTo = "Trebushet_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_01_spec.dds";
   skinned = true;
};

singleton Material(Trebushet_atlas_02_diff_mat)
{
   mapTo = "Trebushet_atlas_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_02_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_02_spec.dds";
   skinned = true;
};

singleton Material(Trebushet_planks_01_diff_mat)
{
   mapTo = "Trebushet_planks_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_01_spec.dds";
   skinned = true;
};

singleton Material(Trebushet_planks_02_diff_mat)
{
   mapTo = "Trebushet_planks_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_02_spec.dds";
   skinned = true;
};

singleton Material(Metall_atlas_01_diff_mat)
{
   mapTo = "Metall_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/Metall_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Metall_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Metall_atlas_01_spec.dds";
   materialTag0 = "LiF";
   translucent = "0";
   alphaTest = "1";
   alphaRef = "93";
};

singleton Material(Metall_atlas_01_skinned_diff_mat)
{
   mapTo = "Metall_atlas_01_skinned_diff";
   diffuseMap[0] = "art/Textures/Atlas/Metall_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Metall_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Metall_atlas_01_spec.dds";
   materialTag0 = "LiF";
   translucent = "0";
   alphaTest = "1";
   alphaRef = "93";
   skinned = true;
};

singleton Material(Trebushet_planks_02_diff_nonskinned_mat)
{
   mapTo = "Trebushet_planks_02_diff_nonskinned";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_02_spec.dds";
   alphaTest = "1";
   alphaRef = "20";
};

singleton Material(Trebushet_atlas_02_diff_nonskinned_mat)
{
   mapTo = "Trebushet_atlas_02_diff_nonskinned";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_02_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_02_spec.dds";
   alphaTest = "1";
   alphaRef = "46";
};

singleton Material(Trebushet_planks_01_diff_nonskinned_mat)
{
   mapTo = "Trebushet_planks_01_diff_nonskinned";
   diffuseMap[0] = "art/Textures/TextureLib/Trebushet_planks_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Trebushet_planks_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Trebushet_planks_01_spec.dds";
};

singleton Material(Metall_atlas_01_diff_nonskinned_mat)
{
   mapTo = "Metall_atlas_01_diff_nonskinned";
   diffuseMap[0] = "art/Textures/Atlas/Metall_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Metall_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Metall_atlas_01_spec.dds";
   alphaTest = "1";
   alphaRef = "46";
};

singleton Material(grenade_diff_mat)
{
   mapTo = "grenade_diff";
   diffuseMap[0] = "art/Textures/Weapons/grenade_diff.dds";
   diffuseMap[1] = "art/Textures/Weapons/grenade_nm.dds";
   diffuseMap[2] = "art/Textures/Weapons/grenade_spec.dds";
};

singleton Material(fishnet_diff_mat)
{
   mapTo = "fishnet_diff";
   diffuseMap[0] = "art/Textures/TextureLib/fishnet_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fishnet_nm.dds";
   specularPower[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "40";
};

singleton Material(shops_03_atlas_diff_mat)
{
   mapTo = "shops_03_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/shops_03_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_03_atlas_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops_03_atlas_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(wooden_sign_diff_mat)
{
   mapTo = "wooden_sign_diff";
   diffuseMap[0] = "art/Textures/Atlas/wooden_sign_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/wooden_sign_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/wooden_sign_spec.dds";
   alphaTest = "1";
   alphaRef = "94";
   doubleSided = "1";
};

singleton Material(WindowGrille_diff_mat)
{
   mapTo = "WindowGrille_diff";
   diffuseMap[0] = "art/Textures/Atlas/WindowGrille_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WindowGrille_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WindowGrille_spec.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(shops_04_atlas_diff_mat)
{
   mapTo = "shops_04_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/shops_04_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_04_atlas_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops_04_atlas_spec.dds";
   materialTag0 = "LiF";
   translucent = "1";
};

singleton Material(Fence_diff_mat)
{
   mapTo = "Fence_diff";
   diffuseMap[0] = "art/Textures/Atlas/Fence_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Fence_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Fence_spec.dds";
   materialTag0 = "LiF";
   normal3DC = "1";
};

singleton Material(Fence_skinned_diff_mat)
{
   mapTo = "Fence_skinned_diff";
   diffuseMap[0] = "art/Textures/Atlas/Fence_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Fence_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Fence_spec.dds";
   skinned= true;
};

singleton Material(Fence_02_diff_mat)
{
   mapTo = "Fence_02_diff";
   diffuseMap[0] = "art/Textures/Atlas/Fence_02_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/fence_02_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/fence_02_spec.dds";
   materialTag0 = "LiF";
   normal3DC = "1";
   doubleSided = "1";
};

singleton Material(fence_02_clean_diff_mat)
{
   mapTo = "fence_02_clean_diff";
   diffuseMap[0] = "art/Textures/Atlas/fence_02_clean_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/fence_02_clean_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/fence_02_clean_spec.dds";
   normal3DC = "1";
};

singleton Material(fence_03_diff_mat)
{
   mapTo = "fence_03_diff";
   diffuseMap[0] = "art/Textures/Atlas/fence_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_1thTier_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_1thTier_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(fence_03_orange_diff_mat)
{
    mapTo = "fence_03_orange_diff";
    diffuseMap[0] = "art/Textures/Atlas/fence_03_orange_diff.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_2thTier_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_2thTier_SPECULAR.dds";
    normal3DC = "1";
    materialTag0 = "LiF";
};

singleton Material(Fence_toilet_planks_orange_diff_mat)
{
    mapTo = "Fence_toilet_planks_orange_diff";
    diffuseMap[0] = "art/Textures/Atlas/Fence_toilet_planks_orange_diff.dds";
    diffuseMap[1] = "art/Textures/Atlas/Fence_nm.dds";
    diffuseMap[2] = "art/Textures/Atlas/Fence_spec.dds";
    materialTag0 = "LiF";
};

singleton Material(Fence_toilet_sign_orange_diff_mat)
{
    mapTo = "Fence_toilet_sign_orange_diff";
    diffuseMap[0] = "art/Textures/Atlas/Fence_toilet_sign_orange_diff.dds";
    diffuseMap[1] = "art/Textures/Atlas/Fence_nm.dds";
    diffuseMap[2] = "art/Textures/Atlas/Fence_spec.dds";
    materialTag0 = "LiF";
};

//-----------------------------------------------------------------------------
// LOD100 Atlas
//-----------------------------------------------------------------------------

singleton Material(LOD100_house_atlas_01_mat)
{
   mapTo = "LOD100_house_atlas_01";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_house_atlas_01.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
   alphaTest = "1";
   alphaRef = "101";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_02_mat)
{
   mapTo = "LOD100_atlas_02";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_02.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_03_mat)
{
   mapTo = "LOD100_atlas_03";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_03.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "90";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_04_mat)
{
   mapTo = "LOD100_atlas_04";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_04.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_05_mat)
{
   mapTo = "LOD100_atlas_05";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_05.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   doubleSided = "1";
};

singleton Material(LOD100_residence_atlas_01_mat)
{
   mapTo = "LOD100_residence_atlas_01";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_residence_atlas_01.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   materialTag0 = "LiF";
   useAnisotropic[0] = "1";
   alphaTest = "1";
   alphaRef = "101";
   doubleSided = "1";
};

singleton Material(lods_atlas_mat)
{
   mapTo = "lods_atlas";
   diffuseMap[0] = "art/Textures/Atlas/lods_atlas.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "80";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_wooden_fortification_mat)
{
   mapTo = "LOD100_atlas_wooden_fortification";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_wooden_fortification.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
};

singleton Material(LOD100_atlas_wooden_fortification_mill_mat)
{
    mapTo = "LOD100_atlas_wooden_fortification_mill";
    diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_wooden_fortification.dds";
    diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds";
    materialTag0 = "LiF";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "127";
};

singleton Material(LOD100_atlas_wooden_fortification_skin_mat)
{
   mapTo = "LOD100_atlas_wooden_fortification_skin";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_wooden_fortification.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
   skinned = true;
};

singleton Material(LOD_atlas_castle_constructions_mat)
{
   mapTo = "LOD_atlas_castle_constructions";
   diffuseMap[0] = "art/Textures/Atlas/LOD_atlas_castle_constructions.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
};

//-----------------------------------------------------------------------------
// HORSES --- START
//-----------------------------------------------------------------------------

singleton Material(Normal_Horse_base_mat)
{
   mapTo = "base.normal_horse";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Normal_Horse_black_mat)
{
   mapTo = "black.normal_horse";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BLACK_01_mat)
{
   mapTo = "Horse_DIFFUSE_BLACK_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BLACK_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Normal_Horse_brown_mat)
{
   mapTo = "brown.normal_horse";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Horse_DIFFUSE_BROWN_01_mat)
{
   mapTo = "Horse_DIFFUSE_BROWN_01";
   diffuseMap[0] = "art/Textures/Animals/Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

// Harnessed horses
singleton Material(Harnessed_Horse_DIFFUSE_WHITE_mat)
{
   mapTo = "Harnessed_Horse_DIFFUSE_WHITE";
   diffuseMap[0] = "art/Textures/Animals/Harnessed_Horse_DIFFUSE_WHITE.dds";
   diffuseMap[1] = "art/Textures/Animals/Harnessed_Horse_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Harnessed_Horse_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Harnessed_Horse_DIFFUSE_BLACK_mat)
{
   mapTo = "Harnessed_Horse_DIFFUSE_BLACK";
   diffuseMap[0] = "art/Textures/Animals/Harnessed_Horse_DIFFUSE_BLACK.dds";
   diffuseMap[1] = "art/Textures/Animals/Harnessed_Horse_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Harnessed_Horse_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
   normal3DC="1";
};

singleton Material(Harnessed_Horse_DIFFUSE_BROWN_mat)
{
   mapTo = "Harnessed_Horse_DIFFUSE_BROWN";
   diffuseMap[0] = "art/Textures/Animals/Harnessed_Horse_DIFFUSE_BROWN.dds";
   diffuseMap[1] = "art/Textures/Animals/Harnessed_Horse_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Harnessed_Horse_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   skinned = true;
};
// end harnessed

singleton Material(Skinny_Horse_base_mat)
{
   mapTo = "base.skinny_horse";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_WHITE_01_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_WHITE_01";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_WHITE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_bw_mat)
{
   mapTo = "bw.skinny_horse";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BW_01_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BW_01";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BW_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_brown_mat)
{
   mapTo = "brown.skinny_horse";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Skinny_Horse_DIFFUSE_BROWN_01_mat)
{
   mapTo = "Skinny_Horse_DIFFUSE_BROWN_01";
   diffuseMap[0] = "art/Textures/Animals/Skinny_Horse_DIFFUSE_BROWN_01.dds";
   diffuseMap[1] = "art/Textures/Animals/Skinny_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Skinny_Horse_SPECULAR_01.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
};

// Harnessed skinny horses
singleton Material(Harnessed_Skinny_Horse_DIFFUSE_WHITE_mat)
{
   mapTo = "Harnessed_Skinny_Horse_DIFFUSE_WHITE";
   diffuseMap[0] = "art/Textures/Animals/Harnessed_Skinny_Horse_DIFFUSE_WHITE.dds";
   diffuseMap[1] = "art/Textures/Animals/Harnessed_Skinny_Horse_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Harnessed_Skinny_Horse_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
   normal3DC="1";
};

singleton Material(Harnessed_Skinny_Horse_DIFFUSE_BW_mat)
{
   mapTo = "Harnessed_Skinny_Horse_DIFFUSE_BW";
   diffuseMap[0] = "art/Textures/Animals/Harnessed_Skinny_Horse_DIFFUSE_BW.dds";
   diffuseMap[1] = "art/Textures/Animals/Harnessed_Skinny_Horse_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Harnessed_Skinny_Horse_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
   normal3DC="1";
};

singleton Material(Harnessed_Skinny_Horse_DIFFUSE_BROWN_mat)
{
   mapTo = "Harnessed_Skinny_Horse_DIFFUSE_BROWN";
   diffuseMap[0] = "art/Textures/Animals/Harnessed_Skinny_Horse_DIFFUSE_BROWN.dds";
   diffuseMap[1] = "art/Textures/Animals/Harnessed_Skinny_Horse_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Harnessed_Skinny_Horse_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "20";
   materialTag0 = "LiF";
   skinned = true;
   normal3DC="1";
};
// end harnessed skinny horses

singleton Material(Heavy_Horse_base_mat)
{
   mapTo = "base.heavy_horse";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse1_DIFFUSE_01_mat)
{
   mapTo = "Heavy_Horse1_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse1_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse1_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse1_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse_clr2_mat)
{
   mapTo = "clr2.heavy_horse";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse2_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse2_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse2_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse2_DIFFUSE_01_mat)
{
   mapTo = "Heavy_Horse2_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse2_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse2_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse2_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse_clr3_mat)
{
   mapTo = "clr3.heavy_horse";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse3_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse3_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse3_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Heavy_Horse3_DIFFUSE_01_mat)
{
   mapTo = "Heavy_Horse3_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Animals/Heavy_Horse3_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Animals/HeavyHorse3_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Animals/Heavy_Horse3_SPECULAR_01.dds";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Ears_DIFFUSE_mat)
{
   mapTo = "Ears_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/Ears_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/Ears_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/Ears_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

//-----------------------------------------------------------------------------
// HORSES --- END
//-----------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//-----------------------------------------------------БОРОДЫ, ВОЛОСЫ, ГОЛОВЫ, ТЕЛА------------------------------------------------------------------
//---------------------------------------------------------МУЖСКОГО ПЕРОНАЖА-------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------


//-------------------------------------------------------------БОРОДЫ------------------------------------------------------------------------


singleton Material(Male_Beard_All_v2_DIFFUSE_mat)//Борода 2
{
   mapTo = "Male_Beard_All_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v2_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v4_DIFFUSE_mat2)//Борода 4
{
   mapTo = "Male_Beard_All_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "80";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v3_DIFFUSE_mat)//Борода евро 3
{
   mapTo = "Male_Beard_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Mon_v3_DIFFUSE_mat)//Борода монгольская 3
{
   mapTo = "Male_Beard_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Mon_v4_DIFFUSE_mat)//Борода монгольская 4
{
   mapTo = "Male_Beard_Mon_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};


singleton Material(Male_Beard_Vik_v1_DIFFUSE_mat)//Борода викинга 1
{
   mapTo = "Male_Beard_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v4_DIFFUSE_mat)//Борода викинга 4
{
   mapTo = "Male_Beard_Vik_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Beard_Mon_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v1_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Beard_Mon_v2_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Beard_Vik_v2_DIFFUSE_mat)//Борода викинга 2
{
   mapTo = "Male_Beard_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v3_DIFFUSE_mat)//Борода викинга 3
{
   mapTo = "Male_Beard_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_All_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_All_v3_DIFFUSE_mat)
{
   mapTo = "Male_Beard_All_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v1_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v4_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};



//------------------------------------------------------------ВОЛОСЫ------------------------------------------------------

singleton Material(Male_Hair_All_v1_DIFFUSE_mat) //мужская прическа 1
{
   mapTo = "Male_Hair_All_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v2_DIFFUSE_mat) //мужская прическа 2
{
   mapTo = "Male_Hair_All_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v4_DIFFUSE_mat) //мужская прическа 4
{
   mapTo = "Male_Hair_All_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v1_DIFFUSE_mat) //мужская евро прическа 1
{
   mapTo = "Male_Hair_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v2_DIFFUSE_mat) //мужская монгольская прическа 2
{
   mapTo = "Male_Hair_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v4_DIFFUSE_mat) //мужская монгольская прическа 4
{
   mapTo = "Male_Hair_Mon_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


singleton Material(Male_Hair_Vik_v2_DIFFUSE_mat) //мужская прическа викингов 1
{
   mapTo = "Male_Hair_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Eur_v4_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};


singleton Material(Male_Hair_Mon_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v3_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Vik_v1_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Vik_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};

singleton Material(Male_Hair_Vik_v4_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Vik_v4_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v4_SPECULAR.dds";
   alphaTest = "1";
   materialTag0 = "LiF";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   useCustomColor = 1;
   isHair = 1;
   skinned = true;
};


singleton Material(Male_Hair_All_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_All_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   useCustomColor = true;
   doubleSided = "1";
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v3_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v1_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};


//------------------------------------------------------------ГОЛОВЫ-----------------------------------------------------

singleton Material(Male_Head_Eur_v1_DIFFUSE_mat)//Муж. европейская голова v1
{
   mapTo = "Male_Head_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};

singleton Material(Male_Head_Mon_v1_DIFFUSE_mat)//Муж. монгольская голова v1
{
   mapTo = "Male_Head_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};

singleton Material(Male_Head_Vik_v1_DIFFUSE_mat)//Муж. голова викинга v1
{
   mapTo = "Male_Head_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};



singleton Material(Male_Head_Eur_v2_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";
   useCustomColor = true;
   useAnisotropic[0] = "1";
   isFace = true;
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Mon_v2_DIFFUSE_mat)
{
   mapTo = "Male_Head_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Vik_v2_DIFFUSE_mat)
{
   mapTo = "Male_Head_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Vik_v3_DIFFUSE_mat)
{
   mapTo = "Male_Head_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};




singleton Material(Male_Head_Eur_v3_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


singleton Material(Male_Head_Mon_v3_DIFFUSE_mat)
{
   mapTo = "Male_Head_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_SPECULAR.dds";
   useCustomColor = true;
   isFace = true;
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;

   // Customization
   CustomizationData[0]  = Custom_Male_Head_Tatoo_1;
   CustomizationData[1]  = Custom_Male_Head_Tatoo_2;
   CustomizationData[2]  = Custom_Male_Head_Tatoo_3;
   CustomizationData[3]  = Custom_Male_Head_Tatoo_4;
   CustomizationData[4]  = Custom_Male_Head_Tatoo_5;
   CustomizationData[5]  = Custom_Male_Head_Tatoo_6;
   CustomizationData[6]  = Custom_Male_Head_Tatoo_7;
   CustomizationData[7]  = Custom_Male_Head_Paint_v1;
   CustomizationData[8]  = Custom_Male_Head_Paint_v2;
   CustomizationData[9]  = Custom_Male_Head_Scar_v1;
   CustomizationData[10]  = Custom_Male_Head_Scar_v2;
   CustomizationData[11]  = Custom_Male_Head_Scar_v3;
   CustomizationData[12]  = Custom_Male_Head_Scar_v4;
   CustomizationData[13]  = Custom_Male_Head_Scar_v5;
   CustomizationData[14]  = Custom_Male_Head_Dirt_v1;
};


//-------------------------------------------------------------ТЕЛА-----------------------------------------------------------

singleton Material(Male_Body_v1_DIFFUSE_mat)//Муж. тело v1
{
   mapTo = "Male_Body_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   useCustomColor = true;
   isBody = true;
   useAnisotropic[0] = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;

    // Customization
   customizationData[0]  = Custom_Male_Body_Tatoo_1;
   customizationData[1]  = Custom_Male_Body_Tatoo_2;
   customizationData[2]  = Custom_Male_Body_Tatoo_3;
   customizationData[3]  = Custom_Male_Body_Tatoo_4;
   customizationData[4]  = Custom_Male_Body_Tatoo_5;
   customizationData[5]  = Custom_Male_Body_Tatoo_6;
   customizationData[6]  = Custom_Male_Body_Tatoo_7;
   customizationData[7]  = Custom_Male_Body_Tatoo_8;
   customizationData[8]  = Custom_Male_Body_Paint_v1;
   customizationData[9]  = Custom_Male_Body_Paint_v2;
   customizationData[10]  = Custom_Male_Body_Scar_v1;
   customizationData[11]  = Custom_Male_Body_Scar_v2;
   customizationData[12]  = Custom_Male_Body_Scar_v3;
   customizationData[13]  = Custom_Male_Body_Scar_v4;
   customizationData[14]  = Custom_Male_Body_Scar_v5;
};



//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------
//---------------------------------------------------------------------------------------------------------------------------------------------------








//-----------------------------------------------------ЛОХМОТЬЯ--------------------------------------------------------

singleton Material(Male_Tatters_Vik_DIFFUSE_mat)//Викинги
{
   mapTo = "Male_Tatters_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Vik_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Tatters_Mon_DIFFUSE_mat)//Монголы
{
   mapTo = "Male_Tatters_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Mon_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

//-----------------------------------------------------НИЖНЕЕ БЕЛЬЕ--------------------------------------------------

singleton Material(Male_Underwear_Eur_DIFFUSE_mat)//Муж. нижнее бельё
{
   mapTo = "Male_Underwear_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Underwear_Eur_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Antiseam_DIFFUSE_mat)//Рубаха
{
   mapTo = "Male_Antiseam_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Antiseam_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


//----------------------------------------------------MALE OUTFITS----------------------------------------------------------

singleton Material(Male_Craft90_All_Carpenter_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Carpenter_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/carpenter/Male_Craft90_All_Carpenter_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/carpenter/Male_Craft90_All_Carpenter_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/carpenter/Male_Craft90_All_Carpenter_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Decorated_DIFFUSE_mat)
{
   mapTo = "Male_Decorated_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/decorated/Male_Decorated_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/decorated/Male_Decorated_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/decorated/Male_Decorated_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Blacksmith_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Blacksmith_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Peasant_Male_DIFFUSE_mat)
{
   mapTo = "Peasant_Male_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


singleton Material(Male_Tatters_Eur_DIFFUSE_mat)
{
   mapTo = "Male_Tatters_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Tatters_Eur_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Engineer_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Engineer_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/engineer/Male_Craft90_All_Engineer_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/engineer/Male_Craft90_All_Engineer_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/engineer/Male_Craft90_All_Engineer_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Cook_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Cook_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/cook/Male_Craft90_All_Cook_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/cook/Male_Craft90_All_Cook_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/cook/Male_Craft90_All_Cook_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Alchemist_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Alchemist_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/alchemist/Male_Craft90_All_Alchemist_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/alchemist/Male_Craft90_All_Alchemist_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/alchemist/Male_Craft90_All_Alchemist_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(table_stuff_diff_mat)
{
   mapTo = "table_stuff_diff";
   diffuseMap[0] = "art/Textures/Atlas/table_stuff_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/table_stuff_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/table_stuff_spec.dds";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   doubleSided = "1";
};

singleton Material(Male_Monk_DIFFUSE_mat)
{
   mapTo = "Male_Monk_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Cardinal_DIFFUSE_mat)
{
    mapTo = "Male_Cardinal_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Cardinal_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Cardinal_Base_SPECULAR.dds";
    materialTag0 = "LiF";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "110";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    skinned = true;
};

singleton Material(Male_Papa_DIFFUSE_mat)
{
    mapTo = "Male_Papa_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Papa_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Papa_Base_SPECULAR.dds";
    materialTag0 = "LiF";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "110";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    skinned = true;
};

singleton Material(GM_Robe_DIFFUSE_mat)
{
   mapTo = "GM_Robe_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "73";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(GM_Robe_Shiny_DIFFUSE_mat)
{
   mapTo = "GM_Robe_Shiny_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_Shiny_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_Shiny_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_Shiny_SPECULAR.dds";
   diffuseMap[12] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_Shiny_EMISSIVE.dds";
   emission="1";
   emissionIntensityFreq="0.9";
   emissionIntensityMin="0.3";
   emissionIntensityMax="0.5";
   emissionScale="3.0";
   alphaTest = "1";
   alphaRef = "73";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(GM_Robe_Dark_DIFFUSE_mat)
{
   mapTo = "GM_Robe_Dark_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_Dark_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/gm/GM_Robe_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "73";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Male_Peasant_DIFFUSE_mat)
{
   mapTo = "Male_Peasant_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Craft90_All_Blacksmith_DIFFUSE_mat)
{
   mapTo = "Male_Craft90_All_Blacksmith_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   alphaRef = "87";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(Mkrestiane_mat) //Simple Male
{
   mapTo = "Mkrestiane";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Mkrestiane.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/MkrestianeN.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/MkrestianeS.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};


singleton Material(MnishiyD_mat) //Rags Male
{
   mapTo = "MnishiyD";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/rags/MnishiyD.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/rags/MnishiyN.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/rags/MnishiyS.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Weapon_Pack_04_DIFFUSE_02_jpg_mat)
{
   mapTo = "Weapon_Pack_04_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_02.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_02.dds";
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_mat)
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01.dds";
   materialTag0 = "LiF";
   behaveAsParticle = true;
};

//---------------------------------------------------------------------------------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Construction materials
//-----------------------------------------------------------------------------

singleton Material(table_stuff_diff_mat)
{
   mapTo = "table_stuff_diff";
   diffuseMap[0] = "art/Textures/Atlas/table_stuff_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/table_stuff_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/table_stuff_spec.dds";
   alphaTest = "1";
   alphaRef = "57";
   doubleSided = "1";
};

singleton Material(table_stuff_skinned_diff_mat)
{
   mapTo = "table_stuff_skinned_diff";
   diffuseMap[0] = "art/Textures/Atlas/table_stuff_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/table_stuff_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/table_stuff_spec.dds";
   alphaTest = "1";
   alphaRef = "57";
   skinned = true;
};

singleton Material(Weaving_basket_diff_mat)
{
   mapTo = "Weaving_basket_diff";
   diffuseMap[0] = "art/Textures/Atlas/Weaving_basket_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Weaving_basket_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Weaving_basket_spec.dds";
   doubleSided = "1";
};

singleton Material(Planks_atlas_diff_mat)
{
   mapTo = "Planks_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/Planks_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Planks_atlas_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Planks_atlas_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(WatchFire01)
{
   mapTo = "WatchFire01";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/TextureLib/WatchFire01_Diffuse.dds";
   specular[0] = "0.392157 0.388235 0.207843 1";
   specularPower[0] = "25";
   diffuseMap[1] = "art/Textures/TextureLib/WatchFire01_Normal.dds";
   diffuseMap[12] = "art/Textures/TextureLib/WatchFire01_Emissive.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   emission="1";
   emissionIntensityFreq="0.75";
   emissionIntensityMin="0.6";
   emissionIntensityMax="1.3";
   emissionScale="0.085";
   alphaTest = "1";
   alphaRef = "111";
   pixelSpecular[0] = "1";
};

singleton Material(VillageOven_diffuse_mat)
{
   mapTo = "VillageOven_diffuse";
   diffuseMap[0] = "art/Textures/Atlas/VillageOven_diffuse.dds";
   diffuseMap[1] = "art/Textures/Atlas/VillageOven_normal.dds";
   diffuseMap[2] = "art/Textures/Atlas/VillageOven_specular.dds";
   materialTag0 = "LiF";
};

singleton Material(VillageOven_dmg_mat)
{
   mapTo = "VillageOven_dmg_diff";
   diffuseMap[0] = "art/Textures/Atlas/VillageOven_dmg_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/VillageOven_dmg_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/VillageOven_dmg_spec.dds";
   alphaTest = "1";
   alphaRef = "111";
   materialTag0 = "LiF";
};

singleton Material(Oven_diff_mat)
{
   mapTo = "Oven_diff";
   diffuseMap[0] = "art/Textures/Atlas/Oven_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Oven_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Oven_spec.dds";
   materialTag0 = "LiF";
   alphaRef = "1";
};

singleton Material(DoorsAtlas_01_diff_mat)
{
   mapTo = "DoorsAtlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/DoorsAtlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/DoorsAtlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/DoorsAtlas_01_spec.dds";
   useAnisotropic[0] = "1";
};

singleton Material(Mats_atlas_1_diff_mat)
{
   mapTo = "Mats_atlas_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/Mats_atlas_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Mats_atlas_1_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Mats_atlas_1_spec.dds";
};

singleton Material(Blind_atlas_1_diff_mat)
{
   mapTo = "Blind_atlas_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/Blind_atlas_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Blind_atlas_1_nm.dds";
};

singleton Material(WoodenColumns_diff_mat)
{
   mapTo = "WoodenColumns_diff";
   diffuseMap[0] = "art/Textures/TextureLib/WoodenColumns_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/WoodenColumns_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/WoodenColumns_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(Shutters_diff_mat)
{
   mapTo = "Shutters_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Shutters_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Shutters_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Shutters_spec.dds";
};

singleton Material(Doorjamb_diff_mat)
{
   mapTo = "Doorjamb_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Doorjamb_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Doorjamb_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Doorjamb_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(FellingInterior_diff_mat)
{
   mapTo = "FellingInterior_diff";
   diffuseMap[0] = "art/Textures/TextureLib/FellingInterior_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/FellingInterior_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/FellingInterior_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   pixelSpecular[0] = "0";
};

singleton Material(FellingExterior_diff_mat)
{
   mapTo = "FellingExterior_diff";
   diffuseMap[0] = "art/Textures/TextureLib/FellingExterior_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/FellingExterior_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/FellingExterior_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   pixelSpecular[0] = "0";
};

singleton Material(glass_no_alpha_diff_mat)
{
   mapTo = "glass_no_alpha_diff";
   diffuseMap[0] = "art/Textures/TextureLib/glass_no_alpha_diff.dds";
};

singleton Material(lockers_diff_mat)
{
   mapTo = "lockers_diff";
   diffuseMap[0] = "art/Textures/Atlas/lockers_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/lockers_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/lockers_spec.dds";
};

singleton Material(woodenTables_diff_mat)
{
   mapTo = "woodenTables_diff";
   diffuseMap[0] = "art/Textures/Atlas/woodenTables_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/woodenTables_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/woodenTables_spec.dds";
};

singleton Material(woodenTables_skinned_diff_mat)
{
   mapTo = "woodenTables_skinned_diff";
   diffuseMap[0] = "art/Textures/Atlas/woodenTables_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/woodenTables_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/woodenTables_spec.dds";
   skinned = true;
};

singleton Material(chairsChests_diff_mat)
{
   mapTo = "chairsChests_diff";
   diffuseMap[0] = "art/Textures/Atlas/chairsChests_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/chairsChests_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/chairsChests_spec.dds";
};

singleton Material(chairsChests_skinned_diff_mat)
{
   mapTo = "chairsChests_skinned_diff";
   diffuseMap[0] = "art/Textures/Atlas/chairsChests_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/chairsChests_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/chairsChests_spec.dds";
   skinned = true;
};

singleton Material(bedSmall_diff_mat)
{
   mapTo = "bedSmall_diff";
   diffuseMap[0] = "art/Textures/Atlas/bedSmall_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/bedSmall_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/bedSmall_spec.dds";
};

singleton Material(Sacks_1_diff_mat)
{
   mapTo = "Sacks_1_diff";
   diffuseMap[0] = "art/Textures/Atlas/Sacks_1_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Sacks_1_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Sacks_1_spec.dds";
   alphaTest = "1";
   alphaRef = "67";
   doubleSided = "1";
};

singleton Material(Rope_3_diff_mat)
{
   mapTo = "Rope_3_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Rope_3_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Rope_3_nm.dds";
   alphaTest = "0";
   alphaRef = "0";
};

singleton Material(tableBenchest_diff_mat)
{
   mapTo = "tableBenchest_diff";
   diffuseMap[0] = "art/Textures/Atlas/tableBenchest_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/tableBenchest_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/tableBenches_spec.dds";
};

singleton Material(beds_diff_mat)
{
   mapTo = "beds_diff";
   diffuseMap[0] = "art/Textures/Atlas/beds_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/beds_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/beds_spec.dds";
};

singleton Material(SignsForChests_diff_mat)
{
   mapTo = "SignsForChests_diff";
   diffuseMap[0] = "art/Textures/Atlas/SignsForChests_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/SignsForChests_nm.dds";
};

singleton Material(shops_02_atlas_DiffAlpha_mat)
{
   mapTo = "shops_02_atlas_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/shops_02_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops_02_atlas_nm.dds";
   alphaTest = "1";
   alphaRef = "87";
};

singleton Material(shops_01_atlas_DiffAlpha_mat)
{
   mapTo = "shops_01_atlas_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/shops-01-atlas-diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/shops-01-atlas-nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/shops-01-atlas-spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "140";
};

singleton Material(table_stuff_DiffAlpha_mat)
{
   mapTo = "table_stuff_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/table_stuff_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/table_stuff_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/table_stuff_spec.dds";
   diffuseMap[12] = "art/Textures/Atlas/table_stuff_emiss.dds";
   alphaTest = "1";
   alphaRef = "109";
   emission="1";
   emissionIntensityFreq="0.35";
   emissionIntensityMin="0.05";
   emissionIntensityMax="2";
};

singleton Material(WindowGrille_DiffAlpha_mat)
{
   mapTo = "WindowGrille_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/WindowGrille_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WindowGrille_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WindowGrille_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "56";
};

singleton Material(wooden_sign_DiffAlpha_mat)
{
   mapTo = "wooden_sign_DiffAlpha";
   diffuseMap[0] = "art/Textures/Atlas/wooden_sign_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/wooden_sign_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/wooden_sign_spec.dds";
   alphaTest = "1";
   alphaRef = "94";
   materialTag0 = "LiF";
};

singleton Material(Tomb_diff_mat)
{
   mapTo = "Tomb_diff";
   diffuseMap[0] = "art/Textures/Atlas/Tomb_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Tomb_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Tomb_spec.dds";
   alphaTest = "1";
   alphaRef = "127";
   doubleSided = "1";
};

singleton Material(Diff_mat)
{
   mapTo = "Diff";
   diffuseMap[0] = "art/Textures/Atlas/SackA_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/SackA_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/SackA_spec.dds";
   alphaTest = "1";
   alphaRef = "154";
   doubleSided = "1";
};

singleton Material(SackA_diff_mat)
{
   mapTo = "SackA_diff";
   diffuseMap[0] = "art/Textures/Atlas/SackA_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/SackA_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/SackA_spec.dds";
   alphaTest = "1";
   alphaRef = "134";
   doubleSided = "1";
};

singleton Material(KiteShield_Horse_DIFFUSE_01_mat)
{
   mapTo = "KiteShield_Horse_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/KiteShield_Horse_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/KiteShield_Horse_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/KiteShield_Horse_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(wall_atlas_diff_mat)
{
   mapTo = "wall_atlas_diff";
   diffuseMap[0] = "art/Textures/Atlas/wall_atlas_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/wall_atlas_nm.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "10";
};


singleton Material(Wood_atlas_01_diff_mat)
{
   mapTo = "Wood_atlas_01_diff";
   diffuseMap[0] = "art/Textures/Atlas/Wood_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Wood_atlas_normal_diff.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(Plow_diff_mat)
{
   mapTo = "Plow_diff";
   diffuseMap[0] = "art/Textures/Atlas/Plow_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Plow_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Plow_spec.dds";
};

singleton Material(TorchSpade_diff_mat)
{
   mapTo = "TorchSpade_diff";
   diffuseMap[0] = "art/Textures/Atlas/TorchSpade_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/TorchSpade_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/TorchSpade_spec.dds";
   alphaTest = "1";
   alphaRef = "60";
   doubleSided = "1";
};

singleton Material(flags_diff_mat)
{
   mapTo = "flags_diff";
   diffuseMap[0] = "art/Textures/TextureLib/flags_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/flags_norm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/flags_spec.dds";
   alphaTest = "1";
   alphaRef = "120";
   materialTag0 = "LiF";
   doubleSided = "1";
   useAnisotropic[0] = "1";
   skinned = true;
};


singleton Material(Log_mat)
{
   mapTo = "Log";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/TextureLib/Log_Diffuse.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Log_Normal.dds";
   specularPower[0] = "50";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
};

singleton Material(Trebushet_atlas_01_diff_nonskinned_mat)
{
   mapTo = "Trebushet_atlas_01_diff_nonskinned";
   diffuseMap[0] = "art/Textures/Atlas/Trebushet_atlas_01_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trebushet_atlas_01_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trebushet_atlas_01_spec.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Bear_Diffuse_nonskinned_mat)
{
   mapTo = "Bear_Diffuse_nonskinned";
   diffuseMap[0] = "art/Textures/Animals/bear/Bear_Diffuse_nonskinned.dds";
   diffuseMap[1] = "art/Textures/Animals/bear/Bear_Normals_nonskinned.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "80";
};

singleton Material(Deer_Diffuse_nonskinned_mat)
{
   mapTo = "Deer_Diffuse_nonskinned";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_deco_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_deco_Normal.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(mooze_diff2_nonskinned_mat)
{
   mapTo = "mooze_diff2_nonskinned";
   diffuseMap[0] = "art/Textures/Animals/moose/mooze_deco_diff2.dds";
   diffuseMap[1] = "art/Textures/Animals/moose/mooze_deco_norm2.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "60";
};

singleton Material(sickles_n_hammers_diffuse_01_nonskinned_mat)
{
   mapTo = "sickles_n_hammers_diffuse_01_nonskinned";
   diffuseMap[0] = "art/Textures/Tools/Sickles_n_Hammers_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Sickles_n_Hammers_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Sickles_n_Hammers_SPECULAR_01.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "239";
};

singleton Material(Bull_Male_DIFFUSE_mat)
{
   mapTo = "Bull_Male_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_Male_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_Male_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bull/Bull_Male_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   skinned = true;
   normal3DC="1";
};

singleton Material(Bull_D_DIFFUSE_mat)
{
   mapTo = "Bull_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_Male_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_Male_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bull/Bull_Male_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   normal3DC="1";
};

singleton Material(wooden_floor_mat)
{  mapTo = "wooden_floor";
   diffuseMap[0] = "art/Textures/TextureLib/wooden_floor_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/wooden_floor_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/wooden_floor_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(fabric_diff_skin_mat)
{
   mapTo = "fabric_diff_skin";
   diffuseMap[0] = "art/Textures/TextureLib/fabric_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/fabric_nm.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "60";
};

singleton Material(wood_diffuce_01_skin_mat)
{
   mapTo = "wood_diffuce_01_skin";
   diffuseMap[0] = "art/Textures/TextureLib/wood_diffuce_01.dds";
};

singleton Material(LOD100_atlas_03_skin_mat)
{
   mapTo = "LOD100_atlas_03_skin";
   diffuseMap[0] = "art/Textures/Atlas/LOD100_atlas_03.dds";
   diffuseMap[1] = "art/Textures/Atlas/LOD100_atlas_nm.dds"; 
   alphaTest = "1";
   alphaRef = "167";
   doubleSided = "1";
};

singleton Material(Cow_whizbang_diffuse_mat)
{
   mapTo = "Cow_whizbang_diffuse";
   diffuseMap[0] = "art/Textures/Animals/Cow/Cow_diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Cow/Cow_Normals.dds";
   skinned = true;
};

singleton Material(WoodRoofB_diff_mat)
{
   mapTo = "WoodRoofB_diff";
   diffuseMap[0] = "art/Textures/Atlas/WoodRoofB_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WoodRoofB_nm.dds";
   diffuseMap[3] = "art/Textures/Atlas/WoodRoofB_spec.dds";
   specularPower[0] = "1";
   specularStrength[0] = "0.5";
   materialTag0 = "LiF";
};

//Lamp, Brazier, Torch

singleton Material(material_25_mat)
{
    mapTo = "material_#25";
    diffuseMap[0] = "art/Textures/TextureLib/Lamp_Torch_A_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Lamp_Torch_A_NORMAL.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Lamp_Torch_A_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(Lamp_Torch_A_DIFFUSE_mat)
{
    mapTo = "Lamp_Torch_A_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Lamp_Torch_A_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Lamp_Torch_A_NORMAL.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Lamp_Torch_A_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(Lamp_Brazier_B_DIFFUSE_mat)
{
    mapTo = "Lamp_Brazier_B_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Lamp_Brazier_B_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Lamp_Brazier_B_NORMAL.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Lamp_Brazier_B_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(Lamp_Brazier_C_DIFFUSE_mat)
{
    mapTo = "Lamp_Brazier_C_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Lamp_Brazier_C_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Lamp_Brazier_C_NORMAL.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Lamp_Brazier_C_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(Lamp_Torch_C_DIFFUSE_mat)
{
    mapTo = "Lamp_Torch_C_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Lamp_Torch_C_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Lamp_Torch_C_NORMAL.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Lamp_Torch_C_SPECULAR.dds";
    normal3DC = "1";
};

//--------------------------Снеговики---------------------------------

singleton Material(snowman_A_mat)
{
   mapTo = "snowman_A";
   diffuseMap[0] = "art/Textures/Atlas/snowman_A_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_B_mat)
{
   mapTo = "snowman_B";
   diffuseMap[0] = "art/Textures/Atlas/snowman_B_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_C_mat)
{
   mapTo = "snowman_C";
   diffuseMap[0] = "art/Textures/Atlas/snowman_C_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_C_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_D_mat)
{
   mapTo = "snowman_D";
   diffuseMap[0] = "art/Textures/Atlas/snowman_D_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(snowman_E_mat)
{
   mapTo = "snowman_E";
   diffuseMap[0] = "art/Textures/Atlas/snowman_E_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "30";
};

singleton Material(sprucet_nonskinned)
{
   mapTo = "sprucet_nonskinned";
   diffuseMap[0] = "art/Textures/Atlas/snowman_spruce_diff.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "120";
   materialTag0 = "LiF";
};

singleton Material(RegularChain_DIFFUSE_01_nonskinned_mat)
{
   mapTo = "RegularChain_DIFFUSE_01_nonskinned";
   diffuseMap[0] = "art/Textures/NonSkinnedArmors/RegularChain_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/NonSkinnedArmors/RegularChain_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/NonSkinnedArmors/RegularChain_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(Throwing_Stuff_DIFFUSE_01_jpg_mat)
{
   mapTo = "Throwing_Stuff_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Throwing_Stuff_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Throwing_Stuff_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Throwing_Stuff_SPECULAR_01.dds";
   alphaTest = "1";
   alphaRef = "93";
};

singleton Material(snowballs_mat)
{  mapTo = "snowballs";
   diffuseMap[0] = "art/Textures/Atlas/snowballs_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowman_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowman_spec.dds";
   materialTag0 = "LiF";
};


singleton Material(snowball_diff_mat)
{
   mapTo = "snowball_diff";
   diffuseMap[0] = "art/Textures/Atlas/snowball_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/snowball_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/snowball_spec.dds";
};

singleton Material(alchemy_box_mat)
{  mapTo = "alchemy_box";
   diffuseMap[0] = "art/Textures/Atlas/alchemy_box_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/alchemy_box_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/alchemy_box_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "67";
   doubleSided = "1";
};

singleton Material(clay_dishes_A_mat)
{  mapTo = "clay_dishes_A";
   diffuseMap[0] = "art/Textures/Atlas/clay_dishes_A_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/clay_dishes_A_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/clay_dishes_A_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(alchemy_box_ground_mat)
{  mapTo = "alchemy_box_ground";
   diffuseMap[0] = "art/Textures/TextureLib/alchemy_box_ground_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/alchemy_box_ground_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/alchemy_box_ground_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(stone_stair_comp_mat)
{  mapTo = "stone_stair_comp";
   diffuseMap[0] = "art/Textures/Atlas/stone_stair_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/stone_stair_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/stone_stair_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(stone_stair_dmg_mat)
{  mapTo = "stone_stair_dmg";
   diffuseMap[0] = "art/Textures/Atlas/stone_stair_dmg_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/stone_stair_dmg_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/stone_stair_dmg_spec.dds";
   materialTag0 = "LiF";
};


//-----------------------------ЛУКИ И АРБАЛЕТЫ--------------------------------------------------------------------

singleton Material(Weapon_Pack_07_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Weapon_Pack_07_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_07_DIFFUSE_01_skin.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_07_NORMALMAP_01_skin.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_07_SPECULAR_01_skin.dds";
   skinned = true;
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_skin_jpg_mat)
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01_skin.jpg";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01_skin.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01_skin.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01_skin.dds";
   skinned = true;
};

singleton Material(Surcoat_armor_DIFFUSE_mat)
{
   mapTo = "Surcoat_armor_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_armor_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_armor_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_armor_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "100";
   useAnisotropic[0] = "1";
   isTabard = true;
   skinned = true;
   doubleSided = "1";
   heraldicCustomizationData = Surcoat_armor_Heraldry;
   normal3DC="1";
   heraldyOffset = "0 0 2 1";
};

singleton Material(Surcoat_Body_DIFFUSE_mat)
{
   mapTo = "Surcoat_Body_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_Body_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_Body_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_Body_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   useAnisotropic[0] = "1";
   isTabard = true;
   skinned = true;
   doubleSided = "1";
   heraldicCustomizationData = Surcoat_Body_Heraldry;
   heraldyOffset = "0 0 2 1";
};

singleton Material(FlagOfficer_A_a_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_A_a_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_A_a_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_A_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_A_Heraldry_OPACITY;
   heraldyOffset = "0.27 -0.22 2 1";
};

singleton Material(FlagOfficer_A_b_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_A_b_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_A_b_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_A_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_A_Heraldry_OPACITY;
   heraldyOffset = "0.27 -0.22 2 1";
};

singleton Material(FlagOfficer_B_a_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_B_a_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_B_a_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_B_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_B_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_B_b_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_B_b_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_B_b_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_B_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_B_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_C_a_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_C_a_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_C_a_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_C_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_C_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_C_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_C_b_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_C_b_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_C_b_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_C_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_C_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_C_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_D_a_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_D_a_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_D_a_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_D_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_D_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_B_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_D_b_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_D_b_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_D_b_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_D_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_D_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_B_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_E_a_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_E_a_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_E_a_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_E_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_E_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_B_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_E_b_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_E_b_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_E_b_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_E_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_E_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_B_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_F_a_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_F_a_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_F_a_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_F_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_F_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_B_Heraldry_OPACITY;
   heraldyOffset = "0.25 -0.25 2 1";
};

singleton Material(FlagOfficer_G_DIFFUSE_mat)
{
   mapTo = "FlagOfficer_G_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_G_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_G_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_G_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "20";
   //useAnisotropic[0] = "1";
   isHeraldic = true;
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
   heraldicCustomizationData = FlagOfficer_G_Heraldry_OPACITY;
   heraldyOffset = "0.27 -0.22 2 1";
};

singleton Material(FlagGeneral_DIFFUSE_mat)
{
    mapTo = "FlagGeneral_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/FlagOfficer/FlagGeneral_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/FlagOfficer/FlagGeneral_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/FlagOfficer/FlagGeneral_SPECULAR.dds";
    alphaTest = "1";
    alphaRef = "20";
    //useAnisotropic[0] = "1";
    isHeraldic = true;
    skinned = true;
    doubleSided = "1";
    normal3DC = "1";
    heraldicCustomizationData = FlagGeneral_Heraldry_OPACITY;
    heraldyOffset = "0.24 0 2 1";
};

singleton Material(Flag_Icons_DIFFUSE_mat)
{
    mapTo = "Flag_Icons_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Flag_Icons_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Flag_Icons_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Flag_Icons_SPECULAR.dds";
    alphaTest = "1";
    alphaRef = "20";
    skinned = true;
    doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Buckler_DIFFUSE_01_jpg_mat)
{
   mapTo = "Buckler_DIFFUSE_01.jpg";
   diffuseMap[0] = "art/Textures/Shields/Buckler_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/Buckler_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/Buckler_SPECULAR_01.dds";
   translucentBlendOp = "None";
   isHeraldic = "0";
   isArmor = "1";
};

singleton Material(PrimitiveShield_DIFFUSE_02_jpg_mat)
{
   mapTo = "PrimitiveShield_DIFFUSE_02.jpg";
   diffuseMap[0] = "art/Textures/Shields/PrimitiveShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/PrimitiveShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/PrimitiveShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   isHeraldic = "0";
   isArmor = "1";
};

//Щиты для геральдики

singleton Material(KiteShield_EXPORT_01_KiteShield_DIFFUSE_01)
{
   mapTo = "KiteShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/KiteShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/KiteShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/KiteShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = KiteShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(HeaterShield_EXPORT_01_HeaterShield_DIFFUSE_01)
{
   mapTo = "HeaterShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/HeaterShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/HeaterShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/HeaterShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = HeaterShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(PaviseShield_EXPORT_01_PaviseShield_DIFFUSE_01)
{
   mapTo = "PaviseShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/PaviseShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/PaviseShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/PaviseShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = PaviseShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(PrimitiveShield_EXPORT_01_PrimitiveShield_DIFFUSE_01)
{
   mapTo = "PrimitiveShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/PrimitiveShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/PrimitiveShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/PrimitiveShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = PrimitiveShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(RoundShield_EXPORT_01_RoundShield_DIFFUSE_01)
{
   mapTo = "RoundShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/RoundShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/RoundShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/RoundShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = RoundShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(SteelRoundache_EXPORT_01_SteelRoundache_DIFFUSE_01)
{
   mapTo = "SteelRoundache_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/SteelRoundache_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/SteelRoundache_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/SteelRoundache_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = SteelRoundacheHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

singleton Material(TowerShield_EXPORT_01_TowerShield_DIFFUSE_01)
{
   mapTo = "TowerShield_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Shields/TowerShield_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Shields/TowerShield_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Shields/TowerShield_SPECULAR_01.dds";
   translucentBlendOp = "None";
   heraldicCustomizationData = TowerShieldHeraldry;
   isHeraldic = "1";
   isArmor = "1";
};

// Материалы нового Wooden Keep

singleton Material(WoodRoof_diff_mat)
{
   mapTo = "WoodRoof_diff";
   diffuseMap[0] = "art/Textures/Atlas/WoodRoof_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WoodRoof_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WoodRoof_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(WoodRoof_trailer_diff)
{
   mapTo = "WoodRoof_trailer_diff";
   diffuseMap[0] = "art/Textures/Atlas/WoodRoof_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WoodRoof_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WoodRoof_spec.dds";
};

singleton Material(Woodbalks_diff_mat)
{
   mapTo = "Woodbalks_diff";
   diffuseMap[0] = "art/Textures/Atlas/Woodbalks_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Woodbalks_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Woodbalks_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(PlanksA_diff_mat)
{
   mapTo = "PlanksA_diff";
   diffuseMap[0] = "art/Textures/Atlas/PlanksA_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/PlanksA_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/PlanksA_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(InteriorElements_diff_mat)
{
   mapTo = "InteriorElements_diff";
   diffuseMap[0] = "art/Textures/Atlas/InteriorElements_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/InteriorElements_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/InteriorElements_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Balcony_diff_mat)
{
   mapTo = "Balcony_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Balcony_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Balcony_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Balcony_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(PlanksB_diff_mat)
{
   mapTo = "PlanksB_diff";
   diffuseMap[0] = "art/Textures/Atlas/PlanksB_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/PlanksB_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/PlanksB_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(WoodRoof_diff_no_snow_mat)
{
   mapTo = "WoodRoof_diff_no_snow";
   diffuseMap[0] = "art/Textures/Atlas/WoodRoof_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/WoodRoof_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/WoodRoof_spec.dds";
   materialTag0 = "LiF";
};

// ТРОФЕИ (TROPHY)

singleton Material(Trophey_DIFFUSE_mat)
{
   mapTo = "Trophey_DIFFUSE";
   diffuseMap[0] = "art/Textures/Atlas/Trophey_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Atlas/Trophey_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Atlas/Trophey_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "90";
   normal3DC = "1";
};

singleton Material(Deer_Diffuse_ns_mat)
{
   mapTo = "Deer_Diffuse_ns";
   diffuseMap[0] = "art/Textures/Animals/Deer/Deer_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/Deer/Deer_Normal.dds";
   alphaTest = "1";
   alphaRef = "73";
   normal3DC = "1";
};

singleton Material(Bear_Diffuse_ns_mat)
{
   mapTo = "Bear_Diffuse_ns";
   diffuseMap[0] = "art/Textures/Animals/bear/Bear_Diffuse.dds";
   diffuseMap[1] = "art/Textures/Animals/bear/Bear_NORMALMAP.dds";
   normal3DC = "1";
};

singleton Material(BoarDiffuseFinal_ns_mat)
{
   mapTo = "BoarDiffuseFinal_ns";
   diffuseMap[0] = "art/Textures/Animals/boar/BoarDiffuseFinal.dds";
   diffuseMap[1] = "art/Textures/Animals/boar/BoarNormalsFinal.dds";
   alphaTest = "1";
   alphaRef = "93";
   doubleSided = "1";
   normal3DC = "1";
};

singleton Material(Bull_Male_DIFFUSE_ns_mat)
{
   mapTo = "Bull_Male_DIFFUSE_ns";
   diffuseMap[0] = "art/Textures/Animals/bull/Bull_Male_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/bull/Bull_Male_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Animals/bull/Bull_Male_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "44";
   normal3DC = "1";

};

singleton Material(mooze_diff2_ns_mat)
{
   mapTo = "mooze_diff2_ns";
   diffuseMap[0] = "art/Textures/Animals/moose/mooze_diff2.dds";
   diffuseMap[1] = "art/Textures/Animals/moose/mooze_norm2.dds";
   alphaTest = "1";
   alphaRef = "75";
   normal3DC = "1";
};

singleton Material(Wolf_DIFFUSE_ns_mat)
{
   mapTo = "Wolf_DIFFUSE_ns";
   diffuseMap[0] = "art/Textures/Animals/wolf/Wolf_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Animals/wolf/Wolf_NORMAL.dds";
   diffuseMap[2] = "art/Textures/Animals/wolf/Wolf_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "65";
   normal3DC = "1";
};

// Материалы нового Loom

singleton Material(Fence_diff_skin_mat)
{
   mapTo = "Fence_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/Fence_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Fence_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Fence_spec.dds";
   normal3DC="1";
};

singleton Material(Loom_LOD10_diff_mat)
{
   mapTo = "Loom_LOD10_diff";
   diffuseMap[0] = "art/Textures/Atlas/Loom_LOD10_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_LOD10_nm.dds";
   normal3DC="1";
};

singleton Material(Loom_Main_diff_skin_mat)
{
   mapTo = "Loom_Main_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Main_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Main_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Main_spec.dds";
   normal3DC="1";
};

singleton Material(Loom_Scissors_diff_mat)
{
   mapTo = "Loom_Scissors_diff";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Scissors_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Scissors_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Scissors_spec.dds";
   normal3DC="1";
};

singleton Material(Loom_Wool_diff_skin_mat)
{
   mapTo = "Loom_Wool_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Wool_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Wool_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Wool_spec.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(Loom_Wool_diff_mat)
{
   mapTo = "Loom_Wool_diff";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Wool_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Wool_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Wool_spec.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(Loom_Main_diff_mat)
{
   mapTo = "Loom_Main_diff";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Main_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Main_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Main_spec.dds";
   normal3DC="1";
};

singleton Material(Loom_LOD10_diff_skin_mat)
{
   mapTo = "Loom_LOD10_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/Loom_LOD10_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_LOD10_nm.dds";
   normal3DC="1";
   doubleSided = "1";
   skinned = true;
   alphaTest = "1";
   alphaRef = "120";
};

singleton Material(Loom_Wool_diff_skin_mat)
{
   mapTo = "Loom_Wool_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Wool_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Wool_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Wool_spec.dds";
   normal3DC="1";
   doubleSided = "1";
   skinned = true;
   alphaTest = "1";
   alphaRef = "120";
};

singleton Material(Loom_Scissors_diff_skin_mat)
{
   mapTo = "Loom_Scissors_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Scissors_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Scissors_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Scissors_spec.dds";
   normal3DC="1";
   skinned = true;
   alphaTest = "1";
   alphaRef = "120";
};

singleton Material(Loom_Main_diff_skin_mat)
{
   mapTo = "Loom_Main_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/Loom_Main_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/Loom_Main_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/Loom_Main_spec.dds";
   normal3DC="1";
   skinned = true;
   alphaTest = "1";
   alphaRef = "120";
};

// -------------- New Monuments ---------------------------

singleton Material(Claim_1thTier_Stone_DIFFUSE)
{
   mapTo = "Claim_1thTier_Stone_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Claim_1thTier_Stone_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Claim_1thTier_Stone_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Claim_1thTier_Stone_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
};

singleton Material(Claim_1thTier_Sword_DIFFUSE)
{
   mapTo = "Claim_1thTier_Sword_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Claim_1thTier_Sword_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Claim_1thTier_Sword_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Claim_1thTier_Sword_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
};

singleton Material(Claim_2thTier_Sword_DIFFUSE)
{
   mapTo = "Claim_2thTier_Sword_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Claim_2thTier_Sword_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Claim_2thTier_Sword_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Claim_2thTier_Sword_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
};

singleton Material(Claim_3thTier_Sword_DIFFUSE)
{
   mapTo = "Claim_3thTier_Sword_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Claim_3thTier_Sword_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Claim_3thTier_Sword_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Claim_3thTier_Sword_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
};


singleton Material(Claim_4thTier_Sword_DIFFUSE)
{
   mapTo = "Claim_4thTier_Sword_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Claim_4thTier_Sword_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Claim_4thTier_Sword_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Claim_4thTier_Sword_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "40";
   normal3DC="1";
};

singleton Material(Halloween_Trophy_DIFFUSE_mat)
{
   mapTo = "Halloween_Trophy_DIFFUSE";
   diffuseMap[0] = "art/Textures/Atlas/Halloween_Trophy_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Atlas/Halloween_Trophy_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Atlas/Halloween_Trophy_SPECULAR.dds";
   diffuseMap[12] = "art/Textures/Atlas/Halloween_Trophy_EMISSIVE.dds";
   emission="1";
   emissionIntensityFreq="2.0";
   emissionIntensityMin="8.0";
   emissionIntensityMax="12.0";
   emissionScale="0.04";
   normal3DC = "1";
   doubleSided = "1";
};

singleton Material(HeavyScale_DIFFUSE_01_ns_mat)
{
   mapTo = "HeavyScale_DIFFUSE_01_ns";
   diffuseMap[0] = "art/Textures/NonSkinnedArmors/HeavyScale_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/NonSkinnedArmors/HeavyScale_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/NonSkinnedArmors/HeavyScale_SPECULAR_01.dds";
   materialTag0 = "LiF";
};

singleton Material(workbench_elements_diff_mat)
{
   mapTo = "workbench_elements_diff";
   diffuseMap[0] = "art/Textures/Atlas/workbench_elements_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/workbench_elements_norm.dds";
   diffuseMap[2] = "art/Textures/Atlas/workbench_elements_spec.dds";
   useAnisotropic[0] = "1";
   materialTag0 = "LiF";
   specularPower[0] = "56";
   pixelSpecular[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "160";
};

// -------------- Hats, Boots, Gloves ---------------------------

singleton Material(Hat_Eur_DIFFUSE_mat)
{
   mapTo = "Hat_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Other/Hat_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Other/Hat_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Other/Hat_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "41";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Boots_Eur_DIFFUSE_mat)
{
   mapTo = "Boots_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Other/Boots_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Other/Boots_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Other/Boots_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "41";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Hat_Eur_DIFFUSE_NY_mat)
{
   mapTo = "Hat_Eur_DIFFUSE_NY";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Other/Hat_Eur_DIFFUSE_NY.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Other/Hat_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Other/Hat_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "41";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Boots_Eur_DIFFUSE_NY_mat)
{
   mapTo = "Boots_Eur_DIFFUSE_NY";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Other/Boots_Eur_DIFFUSE_NY.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Other/Boots_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Other/Boots_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "41";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Torch_DIFFUSE_mat)
{
   mapTo = "Torch_DIFFUSE";
   diffuseMap[0] = "art/Textures/Tools/Torch_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Tools/Torch_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Tools/Torch_SPECULAR.dds";
   diffuseMap[12] = "art/Textures/Tools/Torch_EMISSIVE.dds";
   alphaTest = "1";
   alphaRef = "33";
   emission="1";
   emissionIntensityFreq="2";
   emissionIntensityMin="2.5";
   emissionIntensityMax="5";
   emissionScale="0.4";
   normal3DC="1";
   materialTag0 = "LiF";
};

// -------------- Ferryman NPCs ---------------------------

singleton Material(Surcoat_Body_NPC_DIFFUSE_mat)
{
   mapTo = "Surcoat_Body_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Surcoat_Body_DIFFUSE_Ferryman.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Surcoat_Body_NORMALMAP_Ferryman.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Surcoat_Body_SPECULAR_Ferryman.dds";
   alphaTest = "1";
   alphaRef = "41";
   materialTag0 = "LiF";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Male_Body_v1_NPC_DIFFUSE_mat)
{
   mapTo = "Male_Body_v1_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   doubleSided = "1";
   useAnisotropic[0] = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Head_Vik_v2_NPC_DIFFUSE_mat)
{
   mapTo = "Male_Head_Vik_v2_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_SPECULAR.dds";
   skinned = true;
};

singleton Material(Male_Head_Eur_v2_NPC_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v2_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";
   skinned = true;
};

singleton Material(Male_Head_Eur_v3_NPC_DIFFUSE_mat)
{
   mapTo = "Male_Head_Eur_v3_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_SPECULAR.dds";
   skinned = true;
};

singleton Material(Male_Hair_Vik_v2_NPC_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Vik_v2_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v4_NPC_DIFFUSE_mat)
{
   mapTo = "Male_Hair_Eur_v4_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "50";
   doubleSided = "1";
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Hair_All_v1_NPC_DIFFUSE_mat) //мужская прическа 1
{
   mapTo = "Male_Hair_All_v1_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v4_NPC_DIFFUSE_mat)//Борода викинга 4
{
   mapTo = "Male_Beard_Vik_v4_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v4_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_NPC_DIFFUSE_mat)
{
   mapTo = "Male_Beard_Eur_v2_NPC_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(Male_Head_Eur_v1_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Head_Eur_v1_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Head_Eur_v1_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";
    materialTag0 = "LiF";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    skinned = true;
};

singleton Material(Male_Head_Eur_v2_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Head_Eur_v2_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Head_Eur_v2_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";
    materialTag0 = "LiF";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    skinned = true;
};

singleton Material(Male_Head_Vik_v1_NPC_slave_DIFFUSE)
{
    mapTo = "Male_Head_Vik_v1_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Head_Vik_v1_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_SPECULAR.dds";
    skinned = true;
};

singleton Material(Male_Head_Mon_v1_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Head_Mon_v1_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Head_Mon_v1_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v1_SPECULAR.dds";
    materialTag0 = "LiF";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    skinned = true;
};

singleton Material(Male_Head_Mon_v2_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Head_Mon_v2_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Head_Mon_v2_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_SPECULAR.dds";
    useAnisotropic[0] = "1";
    materialTag0 = "LiF";
    skinned = true;
};

singleton Material(Male_Head_Mon_v3_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Head_Mon_v3_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Head_Mon_v3_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_SPECULAR.dds";
    skinned = true;
};


singleton Material(Male_Beard_All_v1_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Beard_All_v1_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Beard_All_v1_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
    alphaTest = "1";
    translucent = "0";
    alphaRef = "35";
    doubleSided = "1";
    isHair = true;
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    translucentZWrite = "1";
    skinned = true;
};

singleton Material(Male_Beard_Eur_v2_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Beard_Eur_v2_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Beard_Eur_v2_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
    alphaTest = "1";
    alphaRef = "50";
    doubleSided = "1";
    translucentZWrite = "1";
    translucentBlendOp = "LitAndBlendAlpha";
    mipLODBias = -2;
    useAnisotropic[0] = "1";
    skinned = true;
};

singleton Material(Male_Beard_All_v4_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Beard_All_v4_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Beard_All_v4_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
    alphaTest = "1";
    doubleSided = "1";
    translucent = "0";
    alphaRef = "80";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    translucentZWrite = "1";
    skinned = true;
};

singleton Material(Male_Beard_Mon_v3_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Beard_Mon_v3_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Beard_Mon_v3_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_SPECULAR.dds";
    alphaTest = "1";
    doubleSided = "1";
    translucent = "0";
    alphaRef = "35";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    translucentZWrite = "1";
    skinned = true;
};

singleton Material(Male_Beard_Mon_v4_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Beard_Mon_v4_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Beard_Mon_v4_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v4_SPECULAR.dds";
    alphaTest = "1";
    doubleSided = "1";
    translucent = "0";
    alphaRef = "35";
    isHair = true;
    materialTag0 = "LiF";
    mipLODBias = -1.2;
    useAnisotropic[0] = "1";
    translucentZWrite = "1";
    skinned = true;
};

singleton Material(Male_Body_v1_NPC_slave_DIFFUSE_mat)
{
    mapTo = "Male_Body_v1_NPC_slave_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Male_Body_v1_NPC_slave_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
    skinned = true;
};

singleton Material(Stocks_DIFFUSE_skin_mat)
{
    mapTo = "Stocks_DIFFUSE_skin";
    diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Stocks_DIFFUSE_skin.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Stoks_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Stocks_SPECULAR.dds";
    materialTag0 = "LiF";
    skinned = true;
    normal3DC = "1";
};
    // --------------------------- 03-may-2017 armor materials update -----------------------------------------

singleton Material(NoviceLeather_Male_Detail_DIFFUSE_mat)
{
   mapTo = "NoviceLeather_Male_Detail_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Male_Detail_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Male_Detail_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Male_Detail_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(NoviceLeather_Male_Cape_DIFFUSE_mat)
{
   mapTo = "NoviceLeather_Male_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Male_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Male_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Male_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(FullPlate_DIFFUSE_mat)
{
   mapTo = "FullPlate_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/FullPlate/FullPlate_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/FullPlate/FullPlate_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/FullPlate/FullPlate_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(HeavyChain_DIFFUSE_mat)
{
   mapTo = "HeavyChain_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/HeavyChain/HeavyChain_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/HeavyChain/HeavyChain_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/HeavyChain/HeavyChain_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(HeavyLeather_DIFFUSE_mat)
{
   mapTo = "HevayLeather_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/HeavyLeather/HeavyLeather_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/HeavyLeather/HeavyLeather_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/HeavyLeather/HeavyLeather_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(HeavyPadded_DIFFUSE_mat)
{
   mapTo = "HeavyPadded_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/HeavyPadded/HeavyPadded_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/HeavyPadded/HeavyPadded_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/HeavyPadded/HeavyPadded_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(HeavyScale_DIFFUSE_mat)
{
   mapTo = "HeavyScale_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/HeavyScale/HeavyScale_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/HeavyScale/HeavyScale_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/HeavyScale/HeavyScale_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(IronPlate_DIFFUSE_mat)
{
   mapTo = "IronPlate_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/IronPlate/IronPlate_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/IronPlate/IronPlate_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/IronPlate/IronPlate_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LamellarLeather_Male_Cape_DIFFUSE_mat)
{
   mapTo = "LamellarLeather_Male_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Male_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Male_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Male_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LamellarLeather_Helmet_DIFFUSE_mat)
{
   mapTo = "LamellarLeather_Helmet_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Helmet_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Helmet_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Helmet_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LamellarLeather_Gloves_DIFFUSE_mat)
{
   mapTo = "LamellarLeather_Gloves_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Gloves_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Gloves_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Gloves_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LamellarLeather_Male_Trousers_DIFFUSE_mat)
{
   mapTo = "LamellarLeather_Male_Trousers_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Trousers_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Trousers_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Trousers_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LamellarLeather_Foot_DIFFUSE_mat)
{
   mapTo = "LamellarLeather_Foot_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Foot_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Foot_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Foot_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LightChain_DIFFUSE_mat)
{
   mapTo = "LightChain_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/LightChain/LightChain_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/LightChain/LightChain_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/LightChain/LightChain_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LightScale_DIFFUSE_mat)
{
   mapTo = "LightScale_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/LightScale/LightScale_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/LightScale/LightScale_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/LightScale/LightScale_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(NovicePadded_Male_Cape_DIFFUSE_mat)
{
   mapTo = "NovicePadded_Male_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Male_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Male_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Male_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(NovicePadded_Male_Detail_DIFFUSE_mat)
{
   mapTo = "NovicePadded_Male_Detail_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Male_Detail_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Male_Detail_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Male_Detail_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularChain_DIFFUSE_mat)
{
   mapTo = "RegularChain_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/RegularChain/RegularChain_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/RegularChain/RegularChain_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/RegularChain/RegularChain_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularPadded_Male_Cape_DIFFUSE_mat)
{
   mapTo = "RegularPadded_Male_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Male_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Male_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Male_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularPadded_Male_Trousers_DIFFUSE_mat)
{
   mapTo = "RegularPadded_Male_Trousers_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Male_Trousers_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Male_Trousers_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Male_Trousers_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularPadded_Helmet_DIFFUSE_mat)
{
   mapTo = "RegularPadded_Helmet_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Helmet_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Helmet_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Helmet_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularPadded_Gloves_DIFFUSE_mat)
{
   mapTo = "RegularPadded_Gloves_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Gloves_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Gloves_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Gloves_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularScale_Male_Cape_DIFFUSE_mat)
{
   mapTo = "RegularScale_Male_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Male_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Male_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Male_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularScale_Gloves_DIFFUSE_mat)
{
   mapTo = "RegularScale_Gloves_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Gloves_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Gloves_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Gloves_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularScale_Boot_DIFFUSE_mat)
{
   mapTo = "RegularScale_Boot_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Boot_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Boot_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Boot_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularScale_Male_Trousers_DIFFUSE_mat)
{
   mapTo = "RegularScale_Male_Trousers_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Male_Trousers_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Male_Trousers_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Male_Trousers_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularScale_Helmet_DIFFUSE_mat)
{
   mapTo = "RegularScale_Helmet_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Helmet_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Helmet_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Helmet_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RoyalChain_DIFFUSE_mat)
{
   mapTo = "RoyalChain_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/RoyalChain/RoyalChain_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/RoyalChain/RoyalChain_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/RoyalChain/RoyalChain_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "133";
   normal3DC="1";
   skinned = true;
};

singleton Material(RoyalLeather_DIFFUSE_mat)
{
   mapTo = "RoyalLeather_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/RoyalLeather/RoyalLeather_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/RoyalLeather/RoyalLeather_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/RoyalLeather/RoyalLeather_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RoyalPadded_DIFFUSE_mat)
{
   mapTo = "RoyalPadded_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/RoyalPadded/RoyalPadded_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/RoyalPadded/RoyalPadded_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/RoyalPadded/RoyalPadded_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RoyalPlate_DIFFUSE_mat)
{
   mapTo = "RoyalPlate_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/RoyalPlate/RoyalPlate_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/RoyalPlate/RoyalPlate_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/RoyalPlate/RoyalPlate_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RoyalScale_DIFFUSE_mat)
{
   mapTo = "RoyalScale_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RoyalScale/RoyalScale_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RoyalScale/RoyalScale_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RoyalScale/RoyalScale_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Transitional_Mail_and_Plate_DIFFUSE_mat)
{
   mapTo = "Transitional_Mail_and_Plate_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Transitional_Mail_and_Plate/Transitional_Mail_and_Plate_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Transitional_Mail_and_Plate/Transitional_Mail_and_Plate_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Transitional_Mail_and_Plate/Transitional_Mail_and_Plate_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Plate100_Eur_DIFFUSE_mat)
{
   mapTo = "Plate100_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Plate_100_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Plate_100_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Plate90_Eur_DIFFUSE_mat)
{
   mapTo = "Plate90_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Plate60_Eur_DIFFUSE_mat)
{
   mapTo = "Plate60_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Plate_60_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Plate_60_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Plate_60_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Plate0_Eur_DIFFUSE_mat)
{
   mapTo = "Plate0_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Plate_0_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Plate_0_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Plate_0_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Padded0_Vik_DIFFUSE_mat)
{
   mapTo = "Padded0_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/Padded_0_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/Padded_0_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/Padded_0_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Padded60_Vik_DIFFUSE_mat)
{
   mapTo = "Padded60_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/Padded_60_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/Padded_60_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/Padded_60_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Padded90_Vik_DIFFUSE_mat)
{
   mapTo = "Padded90_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/Padded_90_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/Padded_90_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/Padded_90_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Padded100_Vik_DIFFUSE_mat)
{
   mapTo = "Padded100_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/Padded_100_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/Padded_90_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/Padded_90_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Scale0_Mon_DIFFUSE_mat)
{
   mapTo = "Scale0_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/Scale_0_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/Scale_0_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/Scale_0_Mon_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Scale60_Mon_DIFFUSE_mat)
{
   mapTo = "Scale60_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/Scale_60_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/Scale_60_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/Scale_60_Mon_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Scale90_Mon_DIFFUSE_mat)
{
   mapTo = "Scale90_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/Scale_90_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/Scale_90_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/Scale_90_Mon_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Scale100_Mon_DIFFUSE_mat)
{
   mapTo = "Scale100_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/Scale_100_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/Scale_90_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/Scale_100_Mon_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Chain0_Vik_DIFFUSE_mat)
{
   mapTo = "Chain0_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_0_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_0_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_0_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Chain60_Vik_DIFFUSE_mat)
{
   mapTo = "Chain60_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_60_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_60_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_60_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Chain90_Vik_DIFFUSE_mat)
{
   mapTo = "Chain90_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_90_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_90_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_90_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Chain100_Vik_DIFFUSE_mat)
{
   mapTo = "Chain100_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_100_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_100_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Chainmail/Chain_100_Vik_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Leather0_Eur_DIFFUSE_mat)
{
   mapTo = "Leather0_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/Leather_0_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/Leather_0_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/Leather_0_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Leather60_Eur_DIFFUSE_mat)
{
   mapTo = "Leather60_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/Leather_60_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/Leather_60_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/Leather_60_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Leather90_Eur_DIFFUSE_mat)
{
   mapTo = "Leather90_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/Leather_90_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/Leather_90_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/Leather_90_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Leather100_Eur_DIFFUSE_mat)
{
   mapTo = "Leather100_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/Leather_100_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/Leather_90_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/Leather_90_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(Helmet_Eur_DIFFUSE_mat)
{
   mapTo = "Helmet_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Helmet0_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Helmet0_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Helmet0_Eur_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};


singleton Material(Idol_Ferryman_DIFFUSE)
{
   mapTo = "Idol_Ferryman_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Idol_Ferryman_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Idol_Ferryman_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Idol_Ferryman_SPECULAR.dds";
   // specularPower = "100";
   specularScale = 5.0;    
   normal3DC="1";
};

singleton Material(Primitive_Tools_DIFFUSE_mat)
{
   mapTo = "Primitive_Tools_DIFFUSE";
   diffuseMap[0] = "art/Textures/Tools/Primitive_Tools_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Tools/Primitive_Tools_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Tools/Primitive_Tools_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Cart_Bags_DIFFUSE)
{
   mapTo = "Cart_Bags_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Cart_Bags_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Cart_Bags_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Cart_Bags_SPECULAR.dds";
   normal3DC="1";
   //skinned = true;
};

singleton Material(Cart_Body_DIFFUSE)
{
   mapTo = "Cart_Body_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Cart_Body_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Cart_Body_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Cart_Body_SPECULAR.dds";
   normal3DC="1";
   //skinned = true;
};

singleton Material(Cart_Body_DIFFUSE_inside_mat)
{
    mapTo = "Cart_Body_DIFFUSE_inside";
    diffuseMap[0] = "art/Textures/TextureLib/Cart_Body_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Cart_Body_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Cart_Body_SPECULAR.dds";
    normal3DC = "1";
    //skinned = true;
};

singleton Material(Cart_Tent_DIFFUSE)
{
   mapTo = "Cart_Tent_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Cart_Tent_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Cart_Tent_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Cart_Tent_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   normal3DC="1";
   //skinned = true;
};

singleton Material(Cart_Bags_DIFFUSE_nonskinned)
{
   mapTo = "Cart_Bags_DIFFUSE_nonskinned";
   diffuseMap[0] = "art/Textures/TextureLib/Cart_Bags_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Cart_Bags_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Cart_Bags_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Cart_Body_DIFFUSE_nonskinned)
{
   mapTo = "Cart_Body_DIFFUSE_nonskinned";
   diffuseMap[0] = "art/Textures/TextureLib/Cart_Body_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Cart_Body_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Cart_Body_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Cart_Tent_DIFFUSE_nonskinned)
{
   mapTo = "Cart_Tent_DIFFUSE_nonskinned";
   diffuseMap[0] = "art/Textures/TextureLib/Cart_Tent_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Cart_Tent_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Cart_Tent_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   normal3DC="1";
};

// --------------- 09-04-2017 NEW CASTLE WALLS AND KEEPS ---------------

singleton Material(CastleConstructions_Element01_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element01_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element01_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element01_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element01_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Element02_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element02_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element02_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element02_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element02_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Element03_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element03_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element03_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element03_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element03_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_Element04_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element04_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element04_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element04_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element04_SPECULAR.dds";
   normal3DC="1";
};



singleton Material(CastleConstructions_Element05_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element05_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element05_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element05_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element05_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Element06_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element06_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element06_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element06_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element06_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Element07_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element07_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element07_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element07_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element07_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Element08_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element08_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element08_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element08_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element08_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_Element09_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element09_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element09_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element09_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element09_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_Element10_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element10_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element10_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element10_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element10_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_Element11_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element11_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element11_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element11_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element11_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_Element12_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element12_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element12_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element12_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element12_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_Element13_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element13_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element13_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element13_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element13_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_Element14_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element14_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element14_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element14_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element14_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_FloorWood_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_FloorWood_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_FloorWood_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_FloorWood_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_FloorWood_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_WallStone_A_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_WallStone_A_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(CastleConstructions_WallStone_B_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_WallStone_B_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(CastleConstructions_WallStone_C_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_WallStone_C_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(CastleConstructions_Ends_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Ends_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Ends_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Ends_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Ends_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Bricks_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Bricks_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Bricks_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Bricks_SPECULAR.dds";
   normal3DC="1";
};


singleton Material(CastleConstructions_FloorStone_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_FloorStone_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_FloorStone_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_FloorStone_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_FloorStone_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Board_01_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Board_01_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Board_01_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Board_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Board_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(CastleConstructions_Board_02_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Board_02_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Board_02_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Board_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Board_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(CastleConstructions_Roof_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Roof_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Roof_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Roof_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Roof_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
};

singleton Material(CastleConstructions_Beam_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Beam_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Beam_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Beam_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Beam_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleDConstructions_Element01_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element01_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element01_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element01_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element01_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element02_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element02_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element02_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element02_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element02_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element04_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element04_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element04_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element04_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element04_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element05_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element05_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element05_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element05_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element05_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element06_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element06_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element06_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element06_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element06_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element07_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element07_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element07_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element07_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element07_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element08_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element08_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element08_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element08_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element08_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};


singleton Material(CastleConstructions_Element09_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element09_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element09_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element09_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element09_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};


singleton Material(CastleConstructions_Element10_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element10_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element10_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element10_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element10_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element12_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element12_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element12_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element12_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element12_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};


singleton Material(CastleConstructions_Element13_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element13_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element13_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element13_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element13_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};


singleton Material(CastleConstructions_Element14_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Element14_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element14_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element14_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element14_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_FloorWood_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_FloorWood_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_FloorWood_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_FloorWood_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_FloorWood_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_WallStone_A_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_WallStone_A_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_WallStone_B_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_WallStone_B_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_WallStone_C_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_WallStone_C_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Ends_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Ends_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Ends_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Ends_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Ends_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Bricks_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Bricks_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Bricks_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Bricks_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};


singleton Material(CastleConstructions_FloorStone_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_FloorStone_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_FloorStone_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_FloorStone_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_FloorStone_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Board_01_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Board_01_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Board_01_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Board_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Board_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
   skinned = true;
};

singleton Material(CastleConstructions_Board_02_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Board_02_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Board_02_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Board_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Board_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
   skinned = true;
};

singleton Material(CastleConstructions_Roof_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Roof_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Roof_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Roof_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Roof_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
   skinned = true;
};

singleton Material(CastleConstructions_Beam_DIFFUSE_skin_mat)
{
   mapTo = "CastleConstructions_Beam_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Beam_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Beam_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Beam_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(InteriorElements_diff_skin_mat)
{
   mapTo = "InteriorElements_diff_skin";
   diffuseMap[0] = "art/Textures/Atlas/InteriorElements_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/InteriorElements_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/InteriorElements_spec.dds";
   skinned = true;
};

// --------------- 29-09-2017 DAMAGED CASTLE WALLS AND KEEPS ---------------

singleton Material(CastleConstructions_Bricks_DIFFUSE_DMG_mat)
{
   mapTo = "CastleConstructions_Bricks_DIFFUSE_DMG";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Bricks_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Bricks_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Bricks_SPECULAR_DMG.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_FloorWood_DIFFUSE_DMG_mat)
{
   mapTo = "CastleConstructions_FloorWood_DIFFUSE_DMG";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_FloorWood_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_FloorWood_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_FloorWood_SPECULAR_DMG.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_WallStone_A_DIFFUSE_DMG_mat)
{
   mapTo = "CastleConstructions_WallStone_A_DIFFUSE_DMG";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_SPECULAR_DMG.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_WallStone_B_DIFFUSE_DMG_mat)
{
   mapTo = "CastleConstructions_WallStone_B_DIFFUSE_DMG";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_SPECULAR_DMG.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_WallStone_C_DIFFUSE_DMG_mat)
{
   mapTo = "CastleConstructions_WallStone_C_DIFFUSE_DMG";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(CastleConstructions_Bricks_DIFFUSE_DMG_skin_mat)
{
   mapTo = "CastleConstructions_Bricks_DIFFUSE_DMG_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Bricks_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Bricks_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Bricks_SPECULAR_DMG.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_FloorWood_DIFFUSE_DMG_skin_mat)
{
   mapTo = "CastleConstructions_FloorWood_DIFFUSE_DMG_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_FloorWood_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_FloorWood_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_FloorWood_SPECULAR_DMG.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_WallStone_A_DIFFUSE_DMG_skin_mat)
{
   mapTo = "CastleConstructions_WallStone_A_DIFFUSE_DMG_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_A_SPECULAR_DMG.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_WallStone_B_DIFFUSE_DMG_skin_mat)
{
   mapTo = "CastleConstructions_WallStone_B_DIFFUSE_DMG_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_DIFFUSE_DMG.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_NORMALMAP_DMG.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_B_SPECULAR_DMG.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_WallStone_C_DIFFUSE_DMG_skin_mat)
{
   mapTo = "CastleConstructions_WallStone_C_DIFFUSE_DMG_skin";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_WallStone_C_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(CastleConstructions_Element10_Shields_DMG_DIFFUSE_mat)
{
   mapTo = "CastleConstructions_Element10_Shields_DMG_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/CastleConstructions_Element10_Shields_DMG_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/CastleConstructions_Element10_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/CastleConstructions_Element10_SPECULAR.dds";
   normal3DC="1";
};

// -------------- Main City Statues---------------------------

singleton Material(Statue_McTir_mat)
{
   mapTo = "Statue_McTir";
   diffuseMap[0] = "art/Textures/TextureLib/Statue_McTir_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Statue_McTir_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Statue_McTir_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Statue_Sovereign_mat)
{
   mapTo = "Statue_Sovereign";
   diffuseMap[0] = "art/Textures/TextureLib/Statue_Sovereign_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Statue_Sovereign_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Statue_Sovereign_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Statue_Tusgaal_mat)
{
   mapTo = "Statue_Tusgaal";
   diffuseMap[0] = "art/Textures/TextureLib/Statue_Tusgaal_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Statue_Tusgaal_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Statue_Tusgaal_SPECULAR.dds";
   normal3DC="1";
};

// -------------- Temp material Broken Drakkar Ship_Construct---------------------------

singleton Material(Drakkar_BodyTR_DIFFUSE)
{
   mapTo = "Drakkar_BodyTR_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_BodyTR_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_BodyTR_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_BodyTR_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
   normal3DC="1";
};

singleton Material(Drakkar_Sail_skinned_DIFFUSE)
{
   mapTo = "Drakkar_Sail_skinned_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_Sail_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_Sail_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_Sail_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "100";
   //doubleSided = "1";
   normal3DC="1";
   skinned = true;
};

singleton Material(Drakkar_Stuff_skinned_DIFFUSE)
{
   mapTo = "Drakkar_Stuff_skinned_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_Stuff_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_Stuff_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_Stuff_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(Drakkar_Sail_DIFFUSE)
{
   mapTo = "Drakkar_Sail_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_Sail_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_Sail_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_Sail_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "100";
   normal3DC="1";
};

singleton Material(Drakkar_Stuff_DIFFUSE)
{
   mapTo = "Drakkar_Stuff_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_Stuff_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_Stuff_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_Stuff_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Drakkar_BodyB_DIFFUSE)
{
   mapTo = "Drakkar_BodyB_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_BodyB_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_BodyB_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_BodyB_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Drakkar_BodyA_DIFFUSE)
{
   mapTo = "Drakkar_BodyA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_BodyA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_BodyA_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_BodyA_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Drakkar_Debris_DIFFUSE)
{
   mapTo = "Drakkar_Debris_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Drakkar_Debris_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Drakkar_BodyB_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Drakkar_BodyB_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Ship_Construct_A_DIFFUSE)
{
   mapTo = "Ship_Construct_A_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Ship_Construct_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Ship_Construct_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Ship_Construct_A_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Ship_Construct_B_DIFFUSE)
{
   mapTo = "Ship_Construct_B_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Ship_Construct_B_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Ship_Construct_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Ship_Construct_B_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Drakkar_Tower_Back)
{
   mapTo = "Drakkar_Tower_Back";
   diffuseMap[0] = "art/Textures/TextureLib/DrakkarTower_Back_DiffuseMap.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Drakkar_Tower_Right)
{
   mapTo = "Drakkar_Tower_Right";
   diffuseMap[0] = "art/Textures/TextureLib/DrakkarTower_Right_DiffuseMap.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Drakkar_Tower_Front)
{
   mapTo = "Drakkar_Tower_Front";
   diffuseMap[0] = "art/Textures/TextureLib/DrakkarTower_Front_DiffuseMap.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Drakkar_Tower_Left)
{
   mapTo = "Drakkar_Tower_Left";
   diffuseMap[0] = "art/Textures/TextureLib/DrakkarTower_Left_DiffuseMap.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(PotteryWheel_diff_mat)
{
    mapTo = "PotteryWheel_diff";
    diffuseMap[0] = "art/Textures/TextureLib/PotteryWheel_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/PotteryWheel_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/PotteryWheel_SPECULAR.dds";
    normal3DC = "1";
    //skinned = true;
};

// -------------- Temp material Idols---------------------------

singleton Material(GreyColor)
{
   mapTo = "GreyColor";
   diffuseMap[0] = "art/Textures/TextureLib/GreyColor.dds";
   diffuseMap[1] = "art/Textures/TextureLib/NormalMap.dds";
   normal3DC="1";
};

singleton Material(Idols_A_DIFFUSE)
{
   mapTo = "Idols_A_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Idols_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Idols_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Idols_A_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Idols_B_DIFFUSE)
{
   mapTo = "Idols_B_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Idols_B_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Idols_B_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Idols_B_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Idols_C_DIFFUSE)
{
   mapTo = "Idols_C_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Idols_C_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Idols_C_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Idols_C_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Idols_D_DIFFUSE)
{
   mapTo = "Idols_D_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Idols_D_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Idols_D_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Idols_D_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Idol_RobDigger_mat)
{
    mapTo = "Idol_RobDigger";
    diffuseMap[0] = "art/Textures/TextureLib/Idol_RobDigger_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Idol_RobDigger_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Idol_RobDigger_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(IdolLight01)
{
   mapTo = "IdolLight01";
   diffuseMap[0] = "art/Textures/TextureLib/IdolLight01.dds";
   diffuseMap[1] = "art/Textures/TextureLib/NormalMap.dds";
   diffuseMap[12] = "art/Textures/TextureLib/IdolLight01Emission.dds";
   behaveAsParticle = "1";
   doubleSided = "1";
   castShadows = "0";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   //translucentZWrite = "1";
   //alphaTest = "1";
   doNotZWrite = "1";
   emission="1";
   emissionIntensityFreq="0.1";
   emissionIntensityMin="3.0";
   emissionIntensityMax="3.0";   
   emissionScale="1.0";
   normal3DC="1";
};

// -------------- Temp material Gallows and alarm bell---------------------------

singleton Material(Hanged_man_DIFFUSE)
{
   mapTo = "Hanged_man_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Hanged_man_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Hanged_man_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Hanged_man_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "100";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Hanged_man_Nameless_DIFFUSE_mat)
{
    mapTo = "Hanged_man_Nameless_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Hanged_man_Nameless_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Hanged_man_Nameless_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Hanged_man_Nameless_SPECULAR.dds";
    alphaTest = "1";
    alphaRef = "100";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
};

singleton Material(Gallows_DIFFUSE_skin)
{
   mapTo = "Gallows_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/Gallows_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Gallows_NORMAL.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Gallows_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(AlarmBell_1thTier_DIFFUSE_mat)
{
   mapTo = "AlarmBell_1thTier_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_1thTier_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_1thTier_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_1thTier_SPECULAR.dds";
   normal3DC="1";
   doubleSided = "1";
   skinned = true;
};

singleton Material(AlarmBell_1thTier_DIFFUSE_no_skin_mat)
{
    mapTo = "AlarmBell_1thTier_DIFFUSE_no_skin";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_1thTier_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_1thTier_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_1thTier_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(AlarmBell_2thTier_DIFFUSE_mat)
{
    mapTo = "AlarmBell_2thTier_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_2thTier_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_2thTier_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_2thTier_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
    skinned = true;
};

singleton Material(AlarmBell_2thTier_DIFFUSE_no_skin_mat)
{
    mapTo = "AlarmBell_2thTier_DIFFUSE_no_skin";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_2thTier_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_2thTier_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_2thTier_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(AlarmBell_3thTier_Wall_DIFFUSE_mat)
{
    mapTo = "AlarmBell_3thTier_Wall_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_3thTier_Wall_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_3thTier_Wall_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_3thTier_Wall_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
};

singleton Material(AlarmBell_3thTier_Wall_DIFFUSE_no_skin_mat)
{
    mapTo = "AlarmBell_3thTier_Wall_DIFFUSE_no_skin";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_3thTier_Wall_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_3thTier_Wall_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_3thTier_Wall_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(AlarmBell_3thTier_Pt1_DIFFUSE_mat)
{
    mapTo = "AlarmBell_3thTier_Pt1_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt1_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
};

singleton Material(AlarmBell_3thTier_Pt1_DIFFUSE_no_skin_mat)
{
    mapTo = "AlarmBell_3thTier_Pt1_DIFFUSE_no_skin";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt1_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(AlarmBell_3thTier_Pt2_DIFFUSE_mat)
{
    mapTo = "AlarmBell_3thTier_Pt2_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt2_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt2_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
};

singleton Material(AlarmBell_3thTier_Pt2_DIFFUSE_no_skin_mat)
{
    mapTo = "AlarmBell_3thTier_Pt2_DIFFUSE_no_skin";
    diffuseMap[0] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt2_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/AlarmBell_3thTier_Pt2_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(carving_mat)
{
    mapTo = "carving";
    diffuseMap[0] = "art/Textures/TextureLib/Carvings_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Сarvings_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Carvings_SPECULAR.dds";
    materialTag0 = "LiF";
    doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Base_mat)
{
    mapTo = "Altar_Base";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Base_B_A_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Base_B_A_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Base_B_A_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Amate_mat)
{
    mapTo = "Altar_Statue_Amate";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_AmateAori_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_AmateAori_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_AmateAori_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Amate_colored_mat)
{
    mapTo = "Altar_Statue_Amate_colored";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_AmateAori_colored_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_AmateAori_colored_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_AmateAori_colored_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Gloom_mat)
{
    mapTo = "Altar_Statue_Gloom";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_Gloom_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_Gloom_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_Gloom_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Gloom_colored_mat)
{
    mapTo = "Altar_Statue_Gloom_colored";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_Gloom_colored_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_Gloom_colored_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_Gloom_colored_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Holza_mat)
{
    mapTo = "Altar_Statue_Holza";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_JodeHolza_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_JodeHolza_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_JodeHolza_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Holza_colored_mat)
{
    mapTo = "Altar_Statue_Holza_colored";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_JodeHolza_colored_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_JodeHolza_colored_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_JodeHolza_colored_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Kallente_mat)
{
    mapTo = "Altar_Statue_Kallente";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_VelentKalle_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_VelentKalle_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_VelentKalle_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Statue_Kalente_colored_mat)
{
    mapTo = "Altar_Statue_Kalente_colored";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Statue_VelentKalle_colored_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Statue_VelentKalle_colored_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Statue_VelentKalle_colored_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

singleton Material(Altar_Stone_Colored_mat)
{
    mapTo = "Altar_Stone_Colored";
    diffuseMap[0] = "art/Textures/TextureLib/Altar_Stones_colored_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Altar_Stones_colored_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Altar_Stones_colored_SPECULAR.dds";
    materialTag0 = "LiF";
    //doubleSided = "1";
    normal3DC = "1";
};

// -------------- Temp material Ligh Column---------------------------

singleton Material(LightColumn)
{
   mapTo = "LightColumn";
   diffuseMap[0] = "art/Textures/TextureLib/LightColumn.dds";
   diffuseMap[1] = "art/Textures/TextureLib/NormalMap.dds";
   diffuseMap[12] = "art/Textures/TextureLib/LightColumnEmission.dds";
   behaveAsParticle = "1";
   doubleSided = "1";
   castShadows = "0";
   translucent = "1";
   translucentBlendOp = "LerpAlpha";
   //translucentZWrite = "1";
   //alphaTest = "1";
   doNotZWrite = "1";
   emission="1";
   emissionIntensityFreq="0.01";
   emissionIntensityMin="1.0";
   emissionIntensityMax="1.0";   
   emissionScale="0.1";
   normal3DC="1";
};

// -------------- Temp material Long House---------------------------

singleton Material(Gable_diff_mat)
{
   mapTo = "Gable_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Gable_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Gable_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Gable_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Moss_Log_01_mat)
{
   mapTo = "Moss_Log_01";
   diffuseMap[0] = "art/Textures/TextureLib/Moss_Log_01.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "70";
};

singleton Material(PilasterB_diff_mat)
{
   mapTo = "PilasterB_diff";
   diffuseMap[0] = "art/Textures/TextureLib/PilasterB_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/PilasterB_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/PilasterB_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(PilasterC_diff_mat)
{
   mapTo = "PilasterC_diff";
   diffuseMap[0] = "art/Textures/TextureLib/PilasterC_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/PilasterC_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/PilasterC_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(planks_04_mat)
{
   mapTo = "planks_04";
   diffuseMap[0] = "art/Textures/TextureLib/Planks_04.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Planks_02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Planks_02_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(DoorjambRed_diff_mat)
{
   mapTo = "DoorjambRed_diff";
   diffuseMap[0] = "art/Textures/TextureLib/DoorjambRed_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/DoorjambRed_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/DoorjambRed_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(DoorsAtlasRed_01_diff_mat)
{
   mapTo = "DoorsAtlasRed_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/DoorsAtlasRed_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/DoorsAtlasRed_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/DoorsAtlasRed_01_spec.dds";
   materialTag0 = "LiF";
};

singleton Material(Wood_roof_03_diff_mat)
{
   mapTo = "Wood_roof_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Wood_roof_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Wood_roof_01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Wood_roof_01_spec.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "70";
};

singleton Material(Thatch_Decal_01_diff_mat)
{
   mapTo = "Thatch_Decal_01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Thatch_Decal_01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Thatch_Decal_01_nm.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "70";
};

singleton Material(Thatch_Decal_02_diff_mat)
{
   mapTo = "Thatch_Decal_02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Thatch_Decal_02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Thatch_Decal_02_nm.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "70";
};

singleton Material(Thatch_Decal_03_diff_mat)
{
   mapTo = "Thatch_Decal_03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Thatch_Decal_03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Thatch_Decal_03_nm.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "70";
};

singleton Material(TribeCAMP_Totem_v1_Native_Bone_DIFFUSE)
{
   mapTo = "TribeCAMP_Totem_v1_Native_Bone_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Bone_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Bone_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Bone_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(TribeCAMP_Totem_v1_Native_Rock_DIFFUSE)
{
   mapTo = "TribeCAMP_Totem_v1_Native_Rock_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Rock_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Rock_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Rock_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(TribeCAMP_Totem_v1_Native_Wood_DIFFUSE)
{
   mapTo = "TribeCAMP_Totem_v1_Native_Wood_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Wood_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Wood_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Totem_v1_Native_Wood_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(TribeCAMP_Totem_v2_Native_Bone_DIFFUSE)
{
   mapTo = "TribeCAMP_Totem_v2_Native_Bone_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Bone_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Bone_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Bone_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(TribeCAMP_Totem_v2_Native_Rock_DIFFUSE)
{
   mapTo = "TribeCAMP_Totem_v2_Native_Rock_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Rock_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Rock_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Rock_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(TribeCAMP_Totem_v2_Native_Wood_DIFFUSE)
{
   mapTo = "TribeCAMP_Totem_v2_Native_Wood_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Wood_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Wood_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Totem_v2_Native_Wood_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(TribeCAMP_Shield_v1_wood_mat)
{
    mapTo = "TribeCAMP_Shield_v1_wood";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Shields_Wood1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Shields_Wood1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Shields_Wood1_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(TribeCAMP_Shield_v2_wood_mat)
{
    mapTo = "TribeCAMP_Shield_v2_wood";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Shields_Wood2_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Shields_Wood2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Shields_Wood2_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(TribeCAMP_Shield_v1_leather_mat)
{
    mapTo = "TribeCAMP_Shield_v1_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather1_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather1_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather1_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "100";
};

singleton Material(TribeCAMP_Shield_v2_leather_mat)
{
    mapTo = "TribeCAMP_Shield_v2_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather2_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather2_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather2_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "100";
};

singleton Material(TribeCAMP_Shield_v3_leather_mat)
{
    mapTo = "TribeCAMP_Shield_v3_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather3_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather3_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather3_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "100";
};

singleton Material(TribeCAMP_Shield_v4_leather_mat)
{
    mapTo = "TribeCAMP_Shield_v4_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather4_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather4_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather4_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "100";
};

singleton Material(TribeCAMP_Shield_v5_leather_mat)
{
    mapTo = "TribeCAMP_Shield_v5_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather5_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather5_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_Shields_Leather5_SPECULAR.dds";
    normal3DC = "1";
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "100";
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Bones_Diffuse_skin) //torch cow carcass with animation for native torch4
{
    mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Bones_Diffuse_skin";
    diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_bones_diffuse.dds";
    diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_bones_normal.dds";
    diffuseMap[2] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_bones_specular.dds";
    skinned = true;
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Coals_Diffuse) //native coal emission material
{
    mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Coals_Diffuse";
    diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_coals_diffuse.dds";
    diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_coals_normal.dds";
    diffuseMap[12] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_coals_emission.dds";
    emission = "1";
    emissionIntensityFreq = "0.5";
    emissionIntensityMin = "2.5";
    emissionIntensityMax = "5.0";
    emissionScale = "1.0";
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Coals_Diffuse_skin) //SKINNED native coal emission material
{
    mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Coals_Diffuse_skin";
    diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_coals_diffuse.dds";
    diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_coals_normal.dds";
    diffuseMap[12] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_coals_emission.dds";
    emission = "1";
    emissionIntensityFreq = "0.5";
    emissionIntensityMin = "2.5";
    emissionIntensityMax = "5.0";
    emissionScale = "1.0";
    skinned = true;
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Flag_Diffuse_skin) //SKINNED native flag
{
    mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Flag_Diffuse_skin";
    diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_flag_diffuse.dds";
    diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_flag_normal.dds";
    diffuseMap[2] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_flag_specular.dds";
    skinned = true;
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Bones_Diffuse_skin) //SKINNED native bones
{
    mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Bones_Diffuse_skin";
    diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_bones_diffuse.dds";
    diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_bones_normal.dds";
    diffuseMap[2] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_bones_specular.dds";
    skinned = true;
    normal3DC = "1";
    doubleSided = "1";
};

singleton Material(Big_shield_v1_wood_mat)
{
    mapTo = "Big_shield_v1_wood";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_BigShield_Wood_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_BigShield_Wood_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_BigShield_Wood_SPECULAR.dds";
    //alphaTest = "1";
    //alphaRef = "100";
    normal3DC = "1";
    //skinned = true;
    doubleSided = "1";
};

singleton Material(Big_shield_v1_leather_mat)
{
    mapTo = "Big_shield_v1_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_BigShield_v1_Leather_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_BigShield_v1_Leather_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_BigShield_v1_Leather_SPECULAR.dds";
    alphaTest = "1";
    alphaRef = "100";
    normal3DC = "1";
    //skinned = true;
    doubleSided = "1";
};

singleton Material(Big_shield_v2_leather_mat)
{
    mapTo = "Big_shield_v2_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_BigShield_v2_Leather_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_BigShield_v2_Leather_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_BigShield_v2_Leather_SPECULAR.dds";
    alphaTest = "1";
    alphaRef = "100";
    normal3DC = "1";
    //skinned = true;
    doubleSided = "1";
};

singleton Material(Big_shield_v3_leather_mat)
{
    mapTo = "Big_shield_v3_leather";
    diffuseMap[0] = "art/Textures/TextureLib/TribeCAMP_BigShield_v3_Leather_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/TribeCAMP_BigShield_v3_Leather_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/TribeCAMP_BigShield_v3_Leather_SPECULAR.dds";
    alphaTest = "1";
    alphaRef = "100";
    normal3DC = "1";
    //skinned = true;
    doubleSided = "1";
};

singleton Material(BrushwoodPile)
{
    mapTo = "BrushwoodPile";
    diffuseMap[0] = "art/Textures/TextureLib/BrushwoodPile_diffuse.dds";
    diffuseMap[1] = "art/Textures/TextureLib/BrushwoodPile_normal.dds";
    normal3DC = "1";
};

singleton Material(Flag_red_diff_mat)
{
   mapTo = "Flag_red_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Flag_red_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(OutpostFlag_StableFarm_DIFFUSE_mat)
{
    mapTo = "OutpostFlag_StableFarm_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Grey.dds";
    //diffuseMap[1] = "art/Textures/TextureLib/.dds";
    alphaTest = "1";
    alphaRef = "100";
    doubleSided = "1";
};

singleton Material(Ground_Dirt_1k_d_mat)
{
   mapTo = "Ground_Dirt_1k_d";
   diffuseMap[0] = "art/Textures/TextureLib/Ground_Dirt_1k_d.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Ground_Dirt_1k_n.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Ground_Dirt_1k_s.dds";
   materialTag0 = "LiF";
};

// -------------- Temp material Bridges---------------------------

singleton Material(DecalChunks01_diff)
{
   mapTo = "DecalChunks01_diff";
   diffuseMap[0] = "art/Textures/TextureLib/DecalChunks01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/DecalChunks01_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(DecalChunks02_diff)
{
   mapTo = "DecalChunks02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/DecalChunks02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/DecalChunks02_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(DecalChunks03_diff)
{
   mapTo = "DecalChunks03_diff";
   diffuseMap[0] = "art/Textures/TextureLib/DecalChunks03_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/DecalChunks03_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(DecalChunks04_diff)
{
   mapTo = "DecalChunks04_diff";
   diffuseMap[0] = "art/Textures/TextureLib/DecalChunks04_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/DecalChunks04_nm.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(Stones02_diff)
{
   mapTo = "Stones02_diff";
   diffuseMap[0] = "art/Textures/TextureLib/Stones02_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Stones02_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Stones02_spec.dds";

};

singleton Material(RoodStraw_diff)
{
   mapTo = "RoodStraw_diff";
   diffuseMap[0] = "art/Textures/TextureLib/RoodStraw_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/RoodStraw_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/RoodStraw_spec.dds";
   alphaTest = "1";
   alphaRef = "100";
};

singleton Material(PlanksBridge01)
{
   mapTo = "PlanksBridge01";
   diffuseMap[0] = "art/Textures/TextureLib/PlanksBridge01_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/PlanksBridge01_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/PlanksBridge01_spec.dds";

};

singleton Material(ColumnRed_diff)
{
   mapTo = "ColumnRed_diff";
   diffuseMap[0] = "art/Textures/TextureLib/ColumnRed_diff.dds";
   diffuseMap[1] = "art/Textures/TextureLib/ColumnRed_nm.dds";
   diffuseMap[2] = "art/Textures/TextureLib/ColumnRed_spec.dds";

};

singleton Material(Plate60_Eur_DIFFUSE_no_skin_mat)
{
   mapTo = "Plate60_Eur_DIFFUSE_no_skin";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Plate_60_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Plate_60_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Plate_60_Eur_SPECULAR.dds";
   normal3DC="1";
};
// ---------------------- Temp material NPCs---------------------------
//body

singleton Material(Plate90_Eur_DIFFUSE_no_skin_mat)
{
   mapTo = "Plate90_Eur_DIFFUSE_no_skin";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_SPECULAR.dds";
   normal3DC="1";
};

// --------------- 30-10-2017 NEW SHIELDS ---------------

singleton Material(Shield_Kite_A_DIFFUSE_mat)
{
   mapTo = "Shield_Kite_A_DIFFUSE";
   diffuseMap[0] = "art/Textures/Shields/Shield_Kite_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_Kite_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_Kite_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldKiteAHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_WoodenRound_mat)
{
   mapTo = "Shield_WoodenRound";
   diffuseMap[0] = "art/Textures/Shields/Shield_WoodenRound_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_WoodenRound_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_WoodenRound_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldWoodenRoundHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_HeaterA_mat)
{
   mapTo = "Shield_HeaterA";
   diffuseMap[0] = "art/Textures/Shields/Shield_HeaterA_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_HeaterA_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_HeaterA_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldHeaterAHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_HeaterB_mat)
{
   mapTo = "Shield_HeaterB";
   diffuseMap[0] = "art/Textures/Shields/Shield_HeaterB_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_HeaterB_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_HeaterB_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldHeaterBHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_HeaterREG_mat)
{
   mapTo = "Shield_HeaterREG";
   diffuseMap[0] = "art/Textures/Shields/Shield_HeaterREG_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_HeaterREG_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_HeaterREG_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldHeaterREGHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_Kite_mat)
{
   mapTo = "Shield_Kite";
   diffuseMap[0] = "art/Textures/Shields/Shield_Kite_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_Kite_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_Kite_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldKiteHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_KiteREG_mat)
{
   mapTo = "Shield_KiteREG";
   diffuseMap[0] = "art/Textures/Shields/Shield_KiteREG_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_KiteREG_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_KiteREG_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldKiteREGHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_Pavise_mat)
{
   mapTo = "Shield_Pavise";
   diffuseMap[0] = "art/Textures/Shields/Shield_Pavise_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_Pavise_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_Pavise_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldPaviseHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_Primitive_mat)
{
   mapTo = "Shield_Primitive";
   diffuseMap[0] = "art/Textures/Shields/Shield_Primitive_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_Primitive_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_Primitive_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldPrimitiveHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_SteelRound_mat)
{
   mapTo = "Shield_SteelRound";
   diffuseMap[0] = "art/Textures/Shields/Shield_SteelRound_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_SteelRound_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_SteelRound_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldSteelRoundHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_Tower_mat)
{
   mapTo = "Shield_Tower";
   diffuseMap[0] = "art/Textures/Shields/Shield_Tower_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_Tower_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_Tower_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldTowerHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_WoodenRoundREG_A_mat)
{
   mapTo = "Shield_WoodenRoundREG_A";
   diffuseMap[0] = "art/Textures/Shields/Shield_WoodenRoundREG_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_WoodenRoundREG_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_WoodenRoundREG_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldWoodenRoundREGAHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};

singleton Material(Shield_SteelRoundREG_mat)
{
   mapTo = "Shield_SteelRoundREG";
   diffuseMap[0] = "art/Textures/Shields/Shield_SteelRoundREG_A_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Shields/Shield_SteelRoundREG_A_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Shields/Shield_SteelRoundREG_A_SPECULAR.dds";
   heraldicCustomizationData = ShieldSteelRoundREGHeraldry;
   isHeraldic = "1";
   isArmor = "1";
   normal3DC = "1";
};


// ----------------------- Сlothes/Outfits SKINS 22.09.2017 ----------------------------- //

singleton Material(Female_Craft_Alchemis_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Craft_Alchemis_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Craft_Alchemis_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/alchemist/Female_Craft90_All_Alchemist_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Craft_Alchemis_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
};

singleton Material(Female_Craft100_All_Alchemist_DIFFUSE_mat)
{
    mapTo = "Female_Craft100_All_Alchemist_DIFFUSE";
    diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/alchemist/Female_Craft90_All_Alchemist_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/alchemist/Female_Craft90_All_Alchemist_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/alchemist/Female_Craft90_All_Alchemist_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "110";
};

singleton Material(Female_Craft_Blacksmith_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Craft_Blacksmith_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Craft_Blacksmith_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/Female_Craft90_All_Blacksmith_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Craft_Blacksmith_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Female_Craft_Carpenter_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Craft_Carpenter_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Craft_Carpenter_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/cook/Female_Craft90_All_Cook_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Craft_Carpenter_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Female_Craft_Cook_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Craft_Cook_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Craft_Cook_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/cook/Female_Craft90_All_Cook_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Craft_Cook_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Female_Craft_Engineer_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Craft_Engineer_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Craft_Engineer_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/engineer/Female_Craft90_All_Engineer_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Craft_Engineer_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Female_Monk_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Monk_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Monk_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Female_Monk_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Monk_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Female_Cardinal_Base_DIFFUSE_mat)
{
    mapTo = "Female_Cardinal_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Cardinal_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Female_Monk_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Cardinal_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
};

singleton Material(Female_Papa_Base_DIFFUSE_mat)
{
    mapTo = "Female_Papa_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Papa_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Female_Monk_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Papa_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
};


singleton Material(Male_Craft_Alchemist_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Craft_Alchemist_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Craft_Alchemist_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/alchemist/Male_Craft90_All_Alchemist_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Craft_Alchemist_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Craft_Blacksmith_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Craft_Blacksmith_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Craft_Blacksmith_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/Male_Craft90_All_Blacksmith_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Craft_Blacksmith_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Craft_Carpenter_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Craft_Carpenter_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Craft_Carpenter_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/carpenter/Male_Craft90_All_Carpenter_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Craft_Carpenter_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Craft_Cook_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Craft_Cook_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Craft_Cook_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/cook/Male_Craft90_All_Cook_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Craft_Cook_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Craft_Engineer_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Craft_Engineer_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Craft_Engineer_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/engineer/Male_Craft90_All_Engineer_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Craft_Engineer_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Decorated_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Decorated_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Decorated_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/decorated/Male_Decorated_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Decorated_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Female_Decorated_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Decorated_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Decorated_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/decorated/Female_Decorated_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Decorated_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Monk_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Monk_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Monk_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Monk_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Peasant_SkinA_DIFFUSE_mat)
{
   mapTo = "Male_Peasant_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Male_Peasant_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Male_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Male_Peasant_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Female_Peasant_SkinA_DIFFUSE_mat)
{
   mapTo = "Female_Peasant_SkinA_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Female_Peasant_SkinA_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Female_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Female_Peasant_SkinA_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
   doubleSided = "1";
};

singleton Material(Male_Jarl_Base_DIFFUSE_mat)
{
    mapTo = "Male_Jarl_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Jarl_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Jarl_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Jarl_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Jarl_SkinA_DIFFUSE_mat)
{
    mapTo = "Male_Jarl_SkinA_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Jarl_SkinA_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Jarl_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Jarl_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Jarl_SkinB_DIFFUSE_mat)
{
    mapTo = "Male_Jarl_SkinB_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Jarl_SkinB_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Jarl_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Jarl_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Noble_Base_DIFFUSE_mat)
{
    mapTo = "Male_Noble_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Noble_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Noble_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Noble_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Noble_SkinA_DIFFUSE_mat)
{
    mapTo = "Male_Noble_SkinA_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Noble_SkinA_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Noble_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Noble_SkinA_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Noble_SkinB_DIFFUSE_mat)
{
    mapTo = "Male_Noble_SkinB_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Noble_SkinB_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Noble_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Noble_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Villein_Base_DIFFUSE_mat)
{
    mapTo = "Male_Villein_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Villein_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Villein_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Villein_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Villein_SkinA_DIFFUSE_mat)
{
    mapTo = "Male_Villein_SkinA_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Villein_SkinA_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Villein_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Villein_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Male_Villein_SkinB_DIFFUSE_mat)
{
    mapTo = "Male_Villein_SkinB_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Male_Villein_SkinB_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Male_Villein_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Male_Villein_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Jarl_Base_DIFFUSE_mat)
{
    mapTo = "Female_Jarl_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Jarl_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Jarl_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Jarl_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Jarl_SkinA_DIFFUSE_mat)
{
    mapTo = "Female_Jarl_SkinA_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Jarl_SkinA_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Jarl_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Jarl_SkinA_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Jarl_SkinB_DIFFUSE_mat)
{
    mapTo = "Female_Jarl_SkinB_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Jarl_SkinB_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Jarl_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Jarl_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Noble_Base_DIFFUSE_mat)
{
    mapTo = "Female_Noble_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Noble_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Noble_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Noble_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Noble_SkinA_DIFFUSE_mat)
{
    mapTo = "Female_Noble_SkinA_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Noble_SkinA_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Noble_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Noble_SkinA_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Noble_SkinB_DIFFUSE_mat)
{
    mapTo = "Female_Noble_SkinB_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Noble_SkinB_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Noble_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Noble_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Villein_Base_DIFFUSE_mat)
{
    mapTo = "Female_Villein_Base_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Villein_Base_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Villein_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Villein_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Villein_SkinA_DIFFUSE_mat)
{
    mapTo = "Female_Villein_SkinA_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Villein_SkinA_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Villein_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Villein_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

singleton Material(Female_Villein_SkinB_DIFFUSE_mat)
{
    mapTo = "Female_Villein_SkinB_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Female_Villein_SkinB_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Female_Villein_Base_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Female_Villein_Base_SPECULAR.dds";
    normal3DC = "1";
    skinned = true;
    doubleSided = "1";
    alphaTest = "1";
    alphaRef = "130";
};

// ----------------------- Weapons SKINS ----------------------------- //

singleton Material(Zweihander_DIFFUSE_mat)
{
   mapTo = "Zweihander_DIFFUSE";
   diffuseMap[0] = "art/Textures/Weapons/Zweihander_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/Zweihander_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/Zweihander_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Broad_Axe_Pack1_DIFFUSE_mat)
{
   mapTo = "Broad_Axe_pack1";
   diffuseMap[0] = "art/Textures/Weapons/BroadAxe_Pack1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/BroadAxe_Pack1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/BroadAxe_Pack1_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Broad_Axe_Pack2_DIFFUSE_mat)
{
   mapTo = "Broad_Axe_pack2";
   diffuseMap[0] = "art/Textures/Weapons/BroadAxe_Pack2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/BroadAxe_Pack2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/BroadAxe_Pack2_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Glaive_Pack1_DIFFUSE_mat)
{
   mapTo = "Glaive_Pack1";
   diffuseMap[0] = "art/Textures/Weapons/Glaive_Pack1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/Glaive_Pack1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/Glaive_Pack1_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Glaive_Pack2_DIFFUSE_mat)
{
   mapTo = "Glaive_Pack2";
   diffuseMap[0] = "art/Textures/Weapons/Glaive_Pack2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/Glaive_Pack2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/Glaive_Pack2_SPECULAR.dds";
   normal3DC="1";
};

//Skins for Glaive F,G,H,J

singleton Material(Glaive_pack3_mat)
{
    mapTo = "Glaive_Pack3";
    diffuseMap[0] = "art/Textures/Weapons/Glaive_Pack3_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Glaive_Pack3_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Glaive_Pack3_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(BigFalchion_Pack1_DIFFUSE)
{
   mapTo = "BigFalchion_Pack1_DIFFUSE";
   diffuseMap[0] = "art/Textures/Weapons/BigFalchion_Pack1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/BigFalchion_Pack1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/BigFalchion_Pack1_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(BigFalchion_Pack2_DIFFUSE)
{
   mapTo = "BigFalchion_Pack2_DIFFUSE";
   diffuseMap[0] = "art/Textures/Weapons/BigFalchion_Pack2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Weapons/BigFalchion_Pack2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Weapons/BigFalchion_Pack2_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Falchion_mat)
{
    mapTo = "Falchion";
    diffuseMap[0] = "art/Textures/Weapons/Falchion_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/Falchion_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/Falchion_SPECULAR.dds";
    normal3DC = "1";
};


singleton Material(BattleAxe_Skins_diff_mat)
{
    mapTo = "BattleAxe_Skins_diff";
    diffuseMap[0] = "art/Textures/Weapons/BattleAxe_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/Weapons/BattleAxe_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/Weapons/BattleAxe_SPECULAR.dds";
    normal3DC = "1";
};

// ----------------------- Weapons SKINS END ----------------------------- //

singleton Material(Summon_Totem_TEST_DIFFUSE_mat)
{
   mapTo = "Summon_Totem_TEST_DIFFUSE";
   diffuseMap[0] = "art/Textures/TextureLib/Summon_Totem_TEST_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Summon_Totem_TEST_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Summon_Totem_TEST_SPECULAR.dds";
   normal3DC="1";
};

// ---------------------- Temp material NPCs---------------------------
//body

singleton Material(Plate90_Eur_DIFFUSE_no_skin_mat)
{
   mapTo = "Plate90_Eur_DIFFUSE_no_skin";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Plate/Plate_90_Eur_SPECULAR.dds";
   normal3DC="1";
};



singleton Material(Male_Body_Ulf) // тело Ульфа
{
   mapTo = "Male_Body_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Tatoo_4_Ulf;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Body_Assel) // тело Ассела
{
   mapTo = "Male_Body_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Tatoo_2_Assel;  
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Body_v1_Unnwart_the_Gravedigger) // тело Унварта
{
   mapTo = "Male_Body_v1_Unnwart_the_Gravedigger";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v2_Unnwart_the_Gravedigger;  
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Body_v1_Khtyn) // тело Хтина
{
   mapTo = "Male_Body_v1_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v4_Yermyk_Khtyn;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

singleton Material(Male_Body_v1_Wranen_the_Hunter) // тело Вранена
{
   mapTo = "Male_Body_v1_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v5_Wranen_the_Hunter;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Body_v1_Karegast) // тело Карегаста
{
   mapTo = "Male_Body_v1_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Body_v1_Solef_Orosekarpe) // тело Солефа
{
   mapTo = "Male_Body_v1_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.91 0.89 0.87";
};

singleton Material(Male_Body_v1_Dahleborne_Sourgli) // тело Далеборна
{
   mapTo = "Male_Body_v1_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Tatoo_6_Dahleborne_Sourgli;  
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Body_v1_prisoner) // тело плененного крестоносца
{
   mapTo = "Male_Body_v1_prisoner";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v2_prisoner;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Female_Body_v1_Hoytuhanir) //тело Хойтуанир
{
   mapTo = "Female_Body_v1_Hoytuhanir";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Female_Body_Tatoo_1_Hoytuhanir;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

//heads

singleton Material(Male_Head_Eur_v1_Ulf) //голова Ульфа
{
   mapTo = "Male_Head_Eur_v1_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Tatoo_5_Ulf;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Head_Eur_v1_Assel) //голова Ассела
{
   mapTo = "Male_Head_Eur_v1_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Tatoo_3_Assel;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Head_Eur_v3_Unnwart_the_Gravedigger) //голова Унварта
{
   mapTo = "Male_Head_Eur_v3_Unnwart_the_Gravedigger";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Dirt_v1_Unnwart_the_Gravedigger;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Head_Mon_v3_Yermyk_Khtyn) //голова Хтина
{
   mapTo = "Male_Head_Mon_v3_Yermyk_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Scar_v5_Yermyk_Khtyn;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

singleton Material(Male_Head_Vik_v3_Wranen_the_Hunter) //голова Вранена
{
   mapTo = "Male_Head_Vik_v3_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Scar_v5_Wranen_the_Hunter;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Head_Eur_v2_Karegast) //голова Карегаста
{
   mapTo = "Male_Head_Eur_v2_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Dirt_v1_Karegast;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Head_Eur_v2_Solef_Orosekarpe) //голова Солефа
{
   mapTo = "Male_Head_Eur_v2_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Paint_v1_Solef_Orosekarpe;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.91 0.89 0.87";
};

singleton Material(Male_Head_Vik_v2_Dahleborne_Sourgli) //голова Далеборна
{
   mapTo = "Male_Head_Vik_v2_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_SPECULAR.dds";

   customizationMode = "1";
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Head_Vik_v1_prisoner)//голова плененного крестоносца
{
   mapTo = "Male_Head_Vik_v1_prisoner";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Scar_v5_prisoner;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Female_Head_Mon_v3_Hoytuhanir) //голова Хойтуанир
{
   mapTo = "Female_Head_Mon_v3_Hoytuhanir";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "130";

   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

singleton Material(Male_Head_Eur_v2_trinket) //ожерелье 1
{
   mapTo = "Male_Head_Eur_v2_trinket";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Head_Eur_v1_trinket) //ожерелье 2 у плененного крестоносца
{
   mapTo = "Male_Head_Eur_v1_trinket";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Head_Mon_v2_trinket) //ожерелье 3 у Хойтуанир
{
   mapTo = "Male_Head_Mon_v2_trinket";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_SPECULAR.dds";

   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

//hairs

singleton Material(Male_Hair_All_v4_Ulf) //волосы Ульфа
{
   mapTo = "Male_Hair_All_v4_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v4_Assel) // волосы Ассела
{
   mapTo = "Male_Hair_Eur_v4_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v2_Yermyk_Khtyn) //волосы Хтина
{
   mapTo = "Male_Hair_Mon_v2_Yermyk_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.24 0.24 0.24";
   skinned = true;
};

singleton Material(Male_Hair_Vik_v3_Wranen_the_Hunter) //волосы Вранена
{
   mapTo = "Male_Hair_Vik_v3_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v1_Karegast) //волосы Карегаста
{
   mapTo = "Male_Hair_Eur_v1_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.76 0.76 0.76";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v2_Solef_Orosekarpe) //волосы Солефа
{
   mapTo = "Male_Hair_Eur_v2_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Hair_Vik_v1_Dahleborne_Sourgli) //волосы Далеборна
{
   mapTo = "Male_Hair_Vik_v1_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Hair_All_v1_Crusader) //волосы плененного крестоносца
{
   mapTo = "Male_Hair_All_v1_Crusader";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;  
};

singleton Material(Female_Hair_All_v2_Hoytuhanir) // волосы Хойтуанир
{
   mapTo = "Female_Hair_All_v2_Hoytuhanir";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.24 0.24 0.24";
   skinned = true;
};

//beards

singleton Material(Male_Beard_All_v4_Ulf) //борода Ульфа
{
   mapTo = "Male_Beard_All_v4_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
   
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "80";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_Assel) //борода Ассела
{
   mapTo = "Male_Beard_Eur_v2_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_All_v1_Unnwart_the_Gravedigger) //борода Унварта
{
   mapTo = "Male_Beard_All_v1_Unnwart_the_Gravedigger";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   isHair = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_Mon_v3_Yermyk_Khtyn) //борода Хтина
{
   mapTo = "Male_Beard_Mon_v3_Yermyk_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_SPECULAR.dds";
   
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.24 0.24 0.24";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v3_Wranen_the_Hunter) //борода Вранена
{
   mapTo = "Male_Beard_Vik_v3_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_Karegast) //борода Карегаста
{
   mapTo = "Male_Beard_Eur_v2_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.76 0.76 0.76";
   skinned = true;
};

singleton Material(Male_Beard_All_v4_Solef_Orosekarpe) //борода Солефа
{
   mapTo = "Male_Beard_All_v4_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
   
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "80";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v3_Dahleborne_Sourgli) //борода Вранена
{
   mapTo = "Male_Beard_Vik_v3_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Beard_All_v1_prisoner) //борода плененного крестоносца
{
   mapTo = "Male_Beard_All_v1_prisoner";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   isHair = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};


//stuff
singleton Material(Sickles_n_Hammers_DIFFUSE_01_skin) //молот Ульфа
{
   mapTo = "Sickles_n_Hammers_DIFFUSE_01_skin";
   diffuseMap[0] = "art/Textures/Tools/Sickles_n_Hammers_DIFFUSE_01_red.dds";
   diffuseMap[1] = "art/Textures/Tools/Sickles_n_Hammers_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Sickles_n_Hammers_SPECULAR_01.dds";
   diffuseMap[12] = "art/Textures/Tools/Sickles_n_Hammers_emission.dds";
   skinned = true;
   
   emission="1";
   emissionIntensityFreq="0.1";
   emissionIntensityMin="1";
   emissionIntensityMax="1";
   emissionScale="0.5";
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_skin) //меч-заготова Ульфа
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01_skin";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01.dds";
   skinned = true;
};

singleton Material(Male_Monk_Assel) //роба Ассела
{
   mapTo = "Male_Monk_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Primitive_Tools_DIFFUSE_skin) //лопата Унварта
{
   mapTo = "Primitive_Tools_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/Tools/Primitive_Tools_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Tools/Primitive_Tools_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Tools/Primitive_Tools_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(Weapon_Pack_04_DIFFUSE_01_mat) //копье Вранена
{
   mapTo = "Weapon_Pack_04_DIFFUSE_01";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_01.dds";
   skinned = true;
};

singleton Material(Weapon_Pack_04_DIFFUSE_01_skin_mat) //копье Вранена
{
    mapTo = "Weapon_Pack_04_DIFFUSE_01_skin";
    diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_01.dds";
    diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
    diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_01.dds";
    skinned = true;
};

singleton Material(Pipe_DIFFUSE_skin) //трубка Карегаста
{
   mapTo = "Pipe_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/Pipe_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
   skinned = true;
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_Native_Wood_Diffuse) //деревяшка на которой сидит Далеборн
{
   mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_Native_Wood_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_native_wood_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_native_wood_normal.dds";
   diffuseMap[2] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_native_wood_specular.dds";
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Rocks_Diffuse) //куча камней на которых сидит плененный крестоносец
{
   mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Rocks_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_rocks_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_rocks_normal.dds";
   diffuseMap[2] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_rocks_specular.dds";
};

//Lodur

singleton Material(Boy_DIFFUSE) // тело и одежда мальчика Лодура
{
   mapTo = "Boy_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Boy_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Boy_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Boy_SPECULAR.dds";
   normal3DC="1";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Boy_Hair_DIFFUSE) //волосы мальчика Лодура
{
   mapTo = "Boy_Hair_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Boy_Hair_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Boy_Hair_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Boy_Hair_SPECULAR.dds";
   normal3DC="1";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Toy_Horse_skin) // лошадка мальчика Лодура
{
   mapTo = "Toy_Horse_skin";
   diffuseMap[0] = "art/Textures/Atlas/Toy_Horse_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Atlas/Toy_Horse_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Atlas/Toy_Horse_SPECULAR.dds";
   skinned = true;
   normal3DC="1";
};

//Mara

singleton Material(Girl_DIFFUSE) // тело и одежда девочки Мары
{
   mapTo = "Girl_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Girl_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Girl_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Girl_SPECULAR.dds";
   normal3DC="1";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Girl_DIFFUSE_arena) //Mara from Arena
{
   mapTo = "Girl_DIFFUSE_arena";
   diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Girl_DIFFUSE_arena.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Girl_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Girl_SPECULAR.dds";
   normal3DC="1";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
   skinned = true;
};

singleton Material(Girl_Hair_DIFFUSE) //волосы девочки Мары
{
   mapTo = "Girl_Hair_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Girl_Hair_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Girl_Hair_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Girl_Hair_SPECULAR.dds";
   normal3DC="1";
   alphaTest = "1";
   alphaRef = "100";
   doubleSided = "1";
   skinned = true;
};

singleton Material(chairsChests_quest_diff_mat)
{
   mapTo = "chairsChests_quest_diff";
   diffuseMap[0] = "art/Textures/Atlas/chairsChests_quest_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/chairsChests_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/chairsChests_spec.dds";
};

singleton Material(barrel_quest_mat)
{
   mapTo = "barrel_quest";
   diffuseMap[0] = "art/Textures/TextureLib/barrel_quest.dds";
   diffuseMap[1] = "art/Textures/TextureLib/barrel_n.dds";
   diffuseMap[2] = "art/Textures/TextureLib/barrel_S.dds";
   materialTag0 = "LiF";
};

singleton Material(WheelBarrow_DIFFUSE_mat)
{
    mapTo = "WheelBarrow_DIFFUSE";
    diffuseMap[0] = "art/Textures/TextureLib/Wheelbarrow_DIFFUSE.dds";
    diffuseMap[1] = "art/Textures/TextureLib/Wheelbarrow_NORMALMAP.dds";
    diffuseMap[2] = "art/Textures/TextureLib/Wheelbarrow_SPECULAR.dds";
    normal3DC = "1";
};

singleton Material(Male_Body_Ulf) // тело Ульфа
{
   mapTo = "Male_Body_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Tatoo_4_Ulf;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Body_Assel) // тело Ассела
{
   mapTo = "Male_Body_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Tatoo_2_Assel;  
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Body_v1_Unnwart_the_Gravedigger) // тело Унварта
{
   mapTo = "Male_Body_v1_Unnwart_the_Gravedigger";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v2_Unnwart_the_Gravedigger;  
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Body_v1_Khtyn) // тело Хтина
{
   mapTo = "Male_Body_v1_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v4_Yermyk_Khtyn;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

singleton Material(Male_Body_v1_Wranen_the_Hunter) // тело Вранена
{
   mapTo = "Male_Body_v1_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v5_Wranen_the_Hunter;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Body_v1_Karegast) // тело Карегаста
{
   mapTo = "Male_Body_v1_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Body_v1_Solef_Orosekarpe) // тело Солефа
{
   mapTo = "Male_Body_v1_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.91 0.89 0.87";
};

singleton Material(Male_Body_v1_Dahleborne_Sourgli) // тело Далеборна
{
   mapTo = "Male_Body_v1_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Tatoo_6_Dahleborne_Sourgli;  
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Body_v1_prisoner) // тело плененного крестоносца
{
   mapTo = "Male_Body_v1_prisoner";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Body_Scar_v2_prisoner;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Female_Body_v1_Hoytuhanir) //тело Хойтуанир
{
   mapTo = "Female_Body_v1_Hoytuhanir";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Female_Body_Tatoo_1_Hoytuhanir;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

//heads

singleton Material(Male_Head_Eur_v1_Ulf) //голова Ульфа
{
   mapTo = "Male_Head_Eur_v1_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Tatoo_5_Ulf;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Head_Eur_v1_Assel) //голова Ассела
{
   mapTo = "Male_Head_Eur_v1_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Tatoo_3_Assel;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Head_Eur_v3_Unnwart_the_Gravedigger) //голова Унварта
{
   mapTo = "Male_Head_Eur_v3_Unnwart_the_Gravedigger";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v3_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Dirt_v1_Unnwart_the_Gravedigger;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Head_Mon_v3_Yermyk_Khtyn) //голова Хтина
{
   mapTo = "Male_Head_Mon_v3_Yermyk_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v3_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Scar_v5_Yermyk_Khtyn;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

singleton Material(Male_Head_Vik_v3_Wranen_the_Hunter) //голова Вранена
{
   mapTo = "Male_Head_Vik_v3_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v3_SPECULAR.dds";
   
   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Scar_v5_Wranen_the_Hunter;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Head_Eur_v2_Karegast) //голова Карегаста
{
   mapTo = "Male_Head_Eur_v2_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Dirt_v1_Karegast;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.85 0.82 0.80";
};

singleton Material(Male_Head_Eur_v2_Solef_Orosekarpe) //голова Солефа
{
   mapTo = "Male_Head_Eur_v2_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Paint_v1_Solef_Orosekarpe;
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.91 0.89 0.87";
};

singleton Material(Male_Head_Vik_v2_Dahleborne_Sourgli) //голова Далеборна
{
   mapTo = "Male_Head_Vik_v2_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v2_SPECULAR.dds";

   customizationMode = "1";
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Male_Head_Vik_v1_prisoner)//голова плененного крестоносца
{
   mapTo = "Male_Head_Vik_v1_prisoner";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Vik_v1_SPECULAR.dds";

   customizationMode = "1";
   CustomizationData[0]  = Custom_Male_Head_Scar_v5_prisoner;   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.96 0.91 0.89";
};

singleton Material(Female_Head_Mon_v3_Hoytuhanir) //голова Хойтуанир
{
   mapTo = "Female_Head_Mon_v3_Hoytuhanir";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "130";

   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "0.69 0.61 0.52";
};

singleton Material(Male_Head_Eur_v2_trinket) //ожерелье 1
{
   mapTo = "Male_Head_Eur_v2_trinket";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v2_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Head_Eur_v1_trinket) //ожерелье 2 у плененного крестоносца
{
   mapTo = "Male_Head_Eur_v1_trinket";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Eur_v1_SPECULAR.dds";
   
   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

singleton Material(Male_Head_Mon_v2_trinket) //ожерелье 3 у Хойтуанир
{
   mapTo = "Male_Head_Mon_v2_trinket";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Male_Head_Mon_v2_SPECULAR.dds";

   customizationMode = "1";   
   skinned = true;
   useCustomColor = true;
   diffuseColor = "1 1 1";
};

//hairs

singleton Material(Male_Hair_All_v4_Ulf) //волосы Ульфа
{
   mapTo = "Male_Hair_All_v4_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v4_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v4_Assel) // волосы Ассела
{
   mapTo = "Male_Hair_Eur_v4_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v4_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Hair_Mon_v2_Yermyk_Khtyn) //волосы Хтина
{
   mapTo = "Male_Hair_Mon_v2_Yermyk_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Mon_v2_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.24 0.24 0.24";
   skinned = true;
};

singleton Material(Male_Hair_Vik_v3_Wranen_the_Hunter) //волосы Вранена
{
   mapTo = "Male_Hair_Vik_v3_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v3_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v1_Karegast) //волосы Карегаста
{
   mapTo = "Male_Hair_Eur_v1_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.76 0.76 0.76";
   skinned = true;
};

singleton Material(Male_Hair_Eur_v2_Solef_Orosekarpe) //волосы Солефа
{
   mapTo = "Male_Hair_Eur_v2_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Eur_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Hair_Vik_v1_Dahleborne_Sourgli) //волосы Далеборна
{
   mapTo = "Male_Hair_Vik_v1_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_Vik_v1_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Hair_All_v1_Crusader) //волосы плененного крестоносца
{
   mapTo = "Male_Hair_All_v1_Crusader";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Hair_All_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   mipLODBias = -1.2;

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;  
};

singleton Material(Female_Hair_All_v2_Hoytuhanir) // волосы Хойтуанир
{
   mapTo = "Female_Hair_All_v2_Hoytuhanir";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.24 0.24 0.24";
   skinned = true;
};

//beards

singleton Material(Male_Beard_All_v4_Ulf) //борода Ульфа
{
   mapTo = "Male_Beard_All_v4_Ulf";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
   
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "80";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_Assel) //борода Ассела
{
   mapTo = "Male_Beard_Eur_v2_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_All_v1_Unnwart_the_Gravedigger) //борода Унварта
{
   mapTo = "Male_Beard_All_v1_Unnwart_the_Gravedigger";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   isHair = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_Mon_v3_Yermyk_Khtyn) //борода Хтина
{
   mapTo = "Male_Beard_Mon_v3_Yermyk_Khtyn";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Mon_v3_SPECULAR.dds";
   
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "35";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.24 0.24 0.24";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v3_Wranen_the_Hunter) //борода Вранена
{
   mapTo = "Male_Beard_Vik_v3_Wranen_the_Hunter";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Beard_Eur_v2_Karegast) //борода Карегаста
{
   mapTo = "Male_Beard_Eur_v2_Karegast";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Eur_v2_SPECULAR.dds";
   
   alphaTest = "1";
   alphaRef = "50";
   doubleSided = "1";
   translucentZWrite = "1";
   translucentBlendOp = "LitAndBlendAlpha";
   mipLODBias = -2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.76 0.76 0.76";
   skinned = true;
};

singleton Material(Male_Beard_All_v4_Solef_Orosekarpe) //борода Солефа
{
   mapTo = "Male_Beard_All_v4_Solef_Orosekarpe";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v4_SPECULAR.dds";
   
   alphaTest = "1";
   doubleSided = "1";
   translucent = "0";
   alphaRef = "80";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";

   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "0.36 0.34 0.32";
   skinned = true;
};

singleton Material(Male_Beard_Vik_v3_Dahleborne_Sourgli) //борода Вранена
{
   mapTo = "Male_Beard_Vik_v3_Dahleborne_Sourgli";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_Vik_v3_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   doubleSided = "1";
   alphaRef = "35";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Male_Beard_All_v1_prisoner) //борода плененного крестоносца
{
   mapTo = "Male_Beard_All_v1_prisoner";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Hair/Male_Beard_All_v1_SPECULAR.dds";
   
   alphaTest = "1";
   translucent = "0";
   alphaRef = "35";
   doubleSided = "1";
   isHair = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   translucentZWrite = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};


//stuff
singleton Material(Sickles_n_Hammers_DIFFUSE_01_skin) //молот Ульфа
{
   mapTo = "Sickles_n_Hammers_DIFFUSE_01_skin";
   diffuseMap[0] = "art/Textures/Tools/Sickles_n_Hammers_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Tools/Sickles_n_Hammers_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Tools/Sickles_n_Hammers_SPECULAR_01.dds";
   skinned = true;
};

singleton Material(Weapon_Pack_05_DIFFUSE_01_skin) //меч-заготова Ульфа
{
   mapTo = "Weapon_Pack_05_DIFFUSE_01_skin";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_05_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_05_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_05_SPECULAR_01.dds";
   skinned = true;
};

singleton Material(Male_Monk_Assel) //роба Ассела
{
   mapTo = "Male_Monk_Assel";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/Male_Monk_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
   
   customizationMode = "1";
   useCustomColor = true;
   diffuseColor = "1 1 1";
   skinned = true;
};

singleton Material(Primitive_Tools_DIFFUSE_skin) //лопата Унварта
{
   mapTo = "Primitive_Tools_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/Tools/Primitive_Tools_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/Tools/Primitive_Tools_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/Tools/Primitive_Tools_SPECULAR.dds";
   normal3DC="1";
   skinned = true;
};

singleton Material(Weapon_Pack_04_DIFFUSE_01_skin) //копье Вранена
{
   mapTo = "Weapon_Pack_04_DIFFUSE_01_skin";
   diffuseMap[0] = "art/Textures/Weapons/Weapon_Pack_04_DIFFUSE_01.dds";
   diffuseMap[1] = "art/Textures/Weapons/Weapon_Pack_04_NORMALMAP_01.dds";
   diffuseMap[2] = "art/Textures/Weapons/Weapon_Pack_04_SPECULAR_01.dds";
   skinned = true;
};

singleton Material(Pipe_DIFFUSE_skin) //трубка Карегаста
{
   mapTo = "Pipe_DIFFUSE_skin";
   diffuseMap[0] = "art/Textures/TextureLib/Pipe_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/TestTextureA_nm.dds";
   skinned = true;
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_Native_Wood_Diffuse) //деревяшка на которой сидит Далеборн
{
   mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_Native_Wood_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_native_wood_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_native_wood_normal.dds";
   diffuseMap[2] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_native_wood_specular.dds";
};

singleton Material(TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Rocks_Diffuse) //куча камней на которых сидит плененный крестоносец
{
   mapTo = "TribeCAMP_Torch_v1_v2_v3_v4_v5_Native_Rocks_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_rocks_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_rocks_normal.dds";
   diffuseMap[2] = "art/models/3d/environment/natives/textures/tribecamp_torch_v1_v2_v3_v4_v5_native_rocks_specular.dds";
};

singleton Material(Surcoat_Body_prisoner) // роба плененного крестоносца
{
   mapTo = "Surcoat_Body_prisoner";
   diffuseMap[0] = "art/Textures/CharacterTextures/NPC/Surcoat_Crusader_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/NPC/Surcoat_Crusader_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/NPC/Surcoat_Crusader_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "93";
   skinned = true;
   doubleSided = "1";
   normal3DC="1";
};

singleton Material(chairsChests_quest_diff_mat)
{
   mapTo = "chairsChests_quest_diff";
   diffuseMap[0] = "art/Textures/Atlas/chairsChests_quest_diff.dds";
   diffuseMap[1] = "art/Textures/Atlas/chairsChests_nm.dds";
   diffuseMap[2] = "art/Textures/Atlas/chairsChests_spec.dds";
};

singleton Material(barrel_quest_mat)
{
   mapTo = "barrel_quest";
   diffuseMap[0] = "art/Textures/TextureLib/barrel_quest.dds";
   diffuseMap[1] = "art/Textures/TextureLib/barrel_n.dds";
   diffuseMap[2] = "art/Textures/TextureLib/barrel_S.dds";
   materialTag0 = "LiF";
};

// --------------------------------------------------------------------

singleton Material(terrain_zone_own_mat)
{
   mapTo = "terrain_zone_own_mat";
   diffuseMap[0] = "art/Textures/TextureLib/influence_zone_own.dds";
   diffuseMap[12] = "art/Textures/TextureLib/influence_zone_own.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
   
   emission="1";
   emissionIntensityFreq="0.1";
   emissionIntensityMin="1";
   emissionIntensityMax="2";
   emissionScale="0.5";
};

singleton Material(terrain_zone_friendly_mat)
{
   mapTo = "terrain_zone_friendly_mat";
   diffuseMap[0] = "art/Textures/TextureLib/influence_zone_ally.dds";
   diffuseMap[12] = "art/Textures/TextureLib/influence_zone_ally.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
   
   emission="1";
   emissionIntensityFreq="0.1";
   emissionIntensityMin="1";
   emissionIntensityMax="2";
   emissionScale="0.5";
};

singleton Material(terrain_zone_neutral_mat)
{
   mapTo = "terrain_zone_neutral_mat";
   diffuseMap[0] = "art/Textures/TextureLib/influence_zone_neutral.dds";
   diffuseMap[12] = "art/Textures/TextureLib/influence_zone_neutral.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
   
   emission="1";
   emissionIntensityFreq="0.1";
   emissionIntensityMin="1";
   emissionIntensityMax="2";
   emissionScale="0.5";
};

singleton Material(terrain_zone_enemy_mat)
{
   mapTo = "terrain_zone_enemy_mat";
   diffuseMap[0] = "art/Textures/TextureLib/influence_zone_enemy.dds";
   diffuseMap[12] = "art/Textures/TextureLib/influence_zone_enemy.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
   
   emission="1";
   emissionIntensityFreq="0.1";
   emissionIntensityMin="1";
   emissionIntensityMax="2";
   emissionScale="0.5";
};

//------------- wooden cross ---------------->

singleton Material(wooden_cross_JorvikMod_wooden_cross)
{
   mapTo = "JorvikMod_wooden_cross";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_cross_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_cross_nm.dds";
};

//------------- wooden bridge ---------------->

singleton Material(wooden_bridge_JorvikMod_wooden_bridge_rope)
{
   mapTo = "JorvikMod_wooden_bridge_rope";
   diffuseMap[0] = "mods/JorvikMod/art/textures/rope_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/rope_nm.dds";
};

singleton Material(wooden_bridge_JorvikMod_wooden_bridge_base)
{
   mapTo = "JorvikMod_wooden_bridge_base";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_bridge_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_bridge_nm.dds";
};

//------------- wooden bridge construct ---------------->

singleton Material(wooden_bridge_construct_JorvikMod_wooden_bridge_construct)
{
   mapTo = "JorvikMod_wooden_bridge_construct";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_bridge_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_bridge_nm.dds";
};

//------------- wooden bridge damaged ---------------->

singleton Material(wooden_bridge_damaged_JorvikMod_wooden_bridge_rope)
{
   mapTo = "JorvikMod_wooden_bridge_rope";
   diffuseMap[0] = "mods/JorvikMod/art/textures/rope_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/rope_nm.dds";
};

singleton Material(wooden_bridge_damaged_JorvikMod_wooden_bridge_damaged)
{
   mapTo = "JorvikMod_wooden_bridge_damaged";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_bridge_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_bridge_nm.dds";
};

//------------- stone bridge ---------------->

singleton Material(stone_bridge_JorvikMod_stone_bridge_base)
{
   mapTo = "JorvikMod_stone_bridge_base";
   diffuseMap[0] = "mods/JorvikMod/art/textures/stone_bridge_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/stone_bridge_nm.dds";
};

//------------- stone bridge construct ---------------->

singleton Material(stone_bridge_construct_JorvikMod_stone_bridge_construct)
{
   mapTo = "JorvikMod_stone_bridge_construct";
   diffuseMap[0] = "mods/JorvikMod/art/textures/stone_bridge_construct_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/stone_bridge_construct_nm.dds";
};

//------------- stone bridge damage ---------------->

singleton Material(stone_bridge_damaged_JorvikMod_stone_bridge_damaged)
{
   mapTo = "JorvikMod_stone_bridge_damaged";
   diffuseMap[0] = "mods/JorvikMod/art/textures/stone_bridge_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/stone_bridge_nm.dds";
};

//------------- small wooden shed ---------------->

singleton Material(small_wooden_shed_JorvikMod_small_wooden_shed)
{
   mapTo = "JorvikMod_small_wooden_shed";
   diffuseMap[0] = "mods/JorvikMod/art/textures/small_wooden_shed_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/small_wooden_shed_nm.dds";
};

//------------- metal cage ---------------->

singleton Material(metal_cage_JorvikMod_metal_cage)
{
   mapTo = "JorvikMod_metal_cage";
   diffuseMap[0] = "mods/JorvikMod/art/textures/metal_cage_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/metal_cage_nm.dds";
   diffuseMap[2] = "mods/JorvikMod/art/textures/metal_cage_spec.dds";
};

//------------- wooden pier ---------------->

singleton Material(pier_JorvikMod_pier)
{
   mapTo = "JorvikMod_pier";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_pier_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_pier_nm.dds";
};

//------------- wooden barricade ---------------->

singleton Material(wooden_barricade_JorvikMod_barricade)
{
   mapTo = "JorvikMod_barricade";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_barricade_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_barricade_nm.dds";
};

singleton Material(wooden_barricade_JorvikMod_rope)
{
   mapTo = "JorvikMod_rope";
   diffuseMap[0] = "mods/JorvikMod/art/textures/rope_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/rope_nm.dds";
};

//------------- stone altar ---------------->

singleton Material(stone_altar_JorvikMod_stone_altar)
{
   mapTo = "JorvikMod_stone_altar";
   diffuseMap[0] = "mods/JorvikMod/art/textures/stone_altar_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/stone_altar_nm.dds";
};

//------------- wooden house with tower ---------------->

singleton Material(wooden_house_with_tower_JorvikMod_metal)
{
   mapTo = "JorvikMod_metal";
   diffuseMap[0] = "mods/JorvikMod/art/textures/metal_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/metal_nm.dds";
};

singleton Material(wooden_house_with_tower_JorvikMod_walls)
{
   mapTo = "JorvikMod_walls";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_wall_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_wall_nm.dds";
};

singleton Material(wooden_house_with_tower_JorvikMod_roof)
{
   mapTo = "JorvikMod_roof";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_roof_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_roof_nm.dds";
};

singleton Material(wooden_house_with_tower_JorvikMod_floor)
{
   mapTo = "JorvikMod_floor";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_floor_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_floor_nm.dds";
};

singleton Material(wooden_house_with_tower_JorvikMod_beam)
{
   mapTo = "JorvikMod_beam";
   diffuseMap[0] = "mods/JorvikMod/art/textures/beam_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/beam_nm.dds";
};

//---------------------- wooden church ---------------------->

singleton Material(wooden_church_JorvikMod_walls)
{
   mapTo = "JorvikMod_walls";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_wall_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_wall_nm.dds";
   
};

singleton Material(wooden_church_JorvikMod_floor)
{
   mapTo = "JorvikMod_floor";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_floor_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_floor_nm.dds";
   
};

singleton Material(wooden_church_JorvikMod_beam)
{
   mapTo = "JorvikMod_beam";
   diffuseMap[0] = "mods/JorvikMod/art/textures/beam_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/beam_nm.dds";
   
};

singleton Material(wooden_church_JorvikMod_roof)
{
   mapTo = "JorvikMod_roof";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_roof_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_roof_nm.dds";
   
};

singleton Material(wooden_church_JorvikMod_metal)
{
   mapTo = "JorvikMod_metal";
   diffuseMap[0] = "mods/JorvikMod/art/textures/metal_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/metal_nm.dds";
};

//------------- wooden pier T ---------------->

singleton Material(pier_T_JorvikMod_pier)
{
   mapTo = "JorvikMod_pier";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_pier_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_pier_nm.dds";
   translucentBlendOp = "None";
};

singleton Material(pier_T_construct_JorvikMod_pier)
{
   mapTo = "JorvikMod_pier";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_pier_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_pier_nm.dds";
   translucentBlendOp = "None";
};

//------------- wooden pier L ---------------->

singleton Material(pier_L_JorvikMod_pier)
{
   mapTo = "JorvikMod_pier";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_pier_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_pier_nm.dds";
   translucentBlendOp = "None";
};

singleton Material(pier_L_construct_JorvikMod_pier)
{
   mapTo = "JorvikMod_pier";
   diffuseMap[0] = "mods/JorvikMod/art/textures/wooden_pier_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/wooden_pier_nm.dds";
   translucentBlendOp = "None";
};

//------------- stone_tomb_with_cross ---------------->

singleton Material(stone_tomb_with_cross_JorvikMod_stone_tomb)
{
   mapTo = "JorvikMod_stone_tomb";
   diffuseMap[0] = "mods/JorvikMod/art/textures/stone_tomb_with_cross_diff.dds";
   diffuseMap[1] = "mods/JorvikMod/art/textures/stone_tomb_with_cross_nm.dds";
   translucentBlendOp = "None";
};
exec("art/female_materials.cs");
exec("art/materials_environment.cs");
