
//___________________________________________________________________________________
//GRASS CROPS

singleton Material(CropsAtlas) // огород листья
{
   mapTo = "CropsAtlas";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/GroundCover/CropsAtlas.dds";
   specularPower[0] = "10";
   pixelSpecular[0] = "1";
   diffuseMap[2] = "art/Textures/GroundCover/CropsAtlas_Specular.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   materialTag0 = "Crops";
   diffuseMap[1] = "art/Textures/GroundCover/CropsAtlas_Normal.dds";
   useCustomColor = true;
};

singleton Material(OnionSterm) // лук ствол
{
   mapTo = "OnionSterm";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/GroundCover/OnionSterm.dds";
   diffuseMap[1] = "art/Textures/GroundCover/OnionSterm_Normal.dds";
   specularPower[0] = "15";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "Crops";
   useCustomColor = true;
};

singleton Material(GrapeVineBark) // виноград ствол
{
   mapTo = "GrapeVineBark";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/GroundCover/GrapeVine.dds";
   diffuseMap[1] = "art/Textures/GroundCover/GrapeVine_Normal.dds";
   specularPower[0] = "10";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "Crops";
   useCustomColor = true;
};

singleton Material(KoreanStewartiaBark) // палка для винограда и гороха
{
   mapTo = "KoreanStewartiaBark";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/GroundCover/KoreanStewartiaBark.dds";
   diffuseMap[1] = "art/Textures/GroundCover/KoreanStewartiaBark_Normal.dds";
   specularPower[0] = "20";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   materialTag0 = "Crops";
   useCustomColor = true;
};

singleton Material(SoilGrassesAtlas) // луговая трава
{
   mapTo = "SoilGrassesAtlas";
   diffuseColor[0] = "0.96 0.96 0.96 1";
   diffuseMap[0] = "art/Textures/GroundCover/SoilGrassesAtlas_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SoilGrassesAtlas_Normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   useCustomColor = true;
};

singleton Material(SoilGrassesAtlasv2) // луговая трава не граундкавер (не удалять)
{
   mapTo = "SoilGrassesAtlasv2";
   diffuseColor[0] = "0.96 0.96 0.96 1";
   diffuseMap[0] = "art/Textures/GroundCover/SoilGrassesAtlas_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SoilGrassesAtlas_Normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   useCustomColor = true;
};

singleton Material(SwampGrassesAtlas) // болотная трава
{
   mapTo = "SwampGrassesAtlas";
   diffuseMap[0] = "art/Textures/GroundCover/SwampGrassesAtlas_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SwampGrassesAtlas_Normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   useCustomColor = true;
};

singleton Material(SwampGrassesAtlasv2) // болотная трава не граундкавер (не удалять)
{
   mapTo = "SwampGrassesAtlasv2";
   diffuseMap[0] = "art/Textures/GroundCover/SwampGrassesAtlas_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SwampGrassesAtlas_Normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   useCustomColor = true;
};

singleton Material(ForestGrassesAtlas) // лесная трава
{
   mapTo = "ForestGrassesAtlas";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/GroundCover/ForestGrassesAtlas_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/ForestGrassesAtlas_Normal.dds";
   specularPower[0] = "50";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   specular[0] = "0.992157 0.992157 0.976471 1";
   useCustomColor = true;
};

singleton Material(ForestGrassesAtlasv2) // лесная трава не граундкавер (не удалять)
{
   mapTo = "ForestGrassesAtlasv2";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   diffuseMap[0] = "art/Textures/GroundCover/ForestGrassesAtlas_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/ForestGrassesAtlas_Normal.dds";
   specularPower[0] = "50";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   specular[0] = "0.992157 0.992157 0.976471 1";
   useCustomColor = true;
};

singleton Material(SandSteppeSnowGrasses) // степная трава и трава на песке
{
   mapTo = "SandSteppeSnowGrasses";
   diffuseMap[0] = "art/Textures/GroundCover/SandSteppeSnowGrasses_Diffuse.dds";
   diffuseMap[1] = "art/Textures/GroundCover/SandSteppeSnowGrasses_Normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   translucent = "0";
   alphaTest = "1";
   alphaRef = "111";
};

singleton Material(RockOld_NewRockTexture)
{
   mapTo = "RockOld_NewRockTexture";
   diffuseMap[0] = "art/2D/Terrain/Substances/Rock/Rock_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Rock/Rock_nm.dds";
   specular[0] = "1 1 1 1";
   specularPower[0] = "40";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   normal3DC="1";
};

singleton Material(SnowdriftA)
{
   mapTo = "SnowdriftA";

   diffuseMap[0] = "art/2D/Terrain/Substances/Snow/Snow_diff.dds";
   diffuseMap[1] = "art/2D/Terrain/Substances/Snow/Snow_nm.dds";
   doubleSided = "0";
   useAnisotropic[0] = "1";
   normal3DC="1";

};

//___________________________________________________________________________________
//TREES

singleton Material(OakTree) // дуб
{
   mapTo = "OakTree";
   diffuseMap[0] = "art/models/3d/environment/trees/oak/textures/oaktree_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/oak/textures/oaktree_normal.dds";
   //diffuseMap[2] = "art/models/3d/environment/trees/oak/textures/oaktree_specular.dds";
   specularPower[0] = "14";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
};

singleton Material(OakBark01) // дуб ствол
{
   mapTo = "OakBark01";
   diffuseMap[0] = "art/models/3d/environment/trees/oak/textures/oakbark_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/oak/textures/oakbark_normal.dds";
   useAnisotropic[0] = "1";
};

singleton Material(ElmTree) // вяз
{
   mapTo = "ElmTree";
   diffuseMap[0] = "art/models/3d/environment/trees/elm/textures/elmtree_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/elm/textures/elmtree_normal.dds";
   //diffuseMap[2] = "art/models/3d/environment/trees/elm/textures/elmtree_specular.dds";
   specularPower[0] = "14";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
};

singleton Material(ElmBark) // вяз ствол
{
   mapTo = "ElmBark";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[0] = "art/models/3d/environment/trees/elm/textures/elmbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/elm/textures/elmbark_normal.dds";
   useAnisotropic[0] = "1";
};

singleton Material(MapleTree) // клен
{
   mapTo = "MapleTree";
   diffuseMap[0] = "art/models/3d/environment/trees/maple/textures/mapletree_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/maple/textures/mapletree_normal.dds";
   //diffuseMap[2] = "art/models/3d/environment/trees/maple/textures/mapletree_specular.dds";
   specularPower[0] = "4";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
};

singleton Material(MapleBark) // клен ствол
{
   mapTo = "MapleBark";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[0] = "art/models/3d/environment/trees/maple/textures/maplebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/maple/textures/maplebark_normal.dds";
   useAnisotropic[0] = "1";
};

singleton Material(MulberryTree) // шелковица
{
   mapTo = "MulberryTree";
   diffuseMap[0] = "art/models/3d/environment/trees/mulberry/textures/mulberrytree_diffuse.dds";
   diffuseColor[0] = "0.92 0.92 0.92 1";
   diffuseMap[1] = "art/models/3d/environment/trees/mulberry/textures/mulberrytree_normal.dds";
   specular[0] = "0.996078 0.996078 0.996078 1";
   specularPower[0] = "21";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   //useCustomColor = true; // temporary disabled
};

singleton Material(MulberryBark) // шелковица ствол
{
   mapTo = "MulberryBark";
   diffuseMap[0] = "art/models/3d/environment/trees/mulberry/textures/mulberrybark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/mulberry/textures/mulberrybark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   specular[0] = "0.494118 0.419608 0.372549 1";
   specularPower[0] = "18";
   pixelSpecular[0] = "1";
   //useCustomColor = true; // temporary disabled
};

singleton Material(AppleTree) // яблоня
{
   mapTo = "AppleTree";
   diffuseMap[0] = "art/models/3d/environment/trees/apple/textures/appletree_diffuse.dds";
   diffuseColor[0] = "0.83 0.83 0.83 1";
   diffuseMap[1] = "art/models/3d/environment/trees/apple/textures/appletree_normal.dds";
   specular[0] = "0.996078 0.996078 0.996078 1";
   specularPower[0] = "21";
   pixelSpecular[0] = "1";
   //diffuseMap[2] = "art/models/3d/environment/trees/apple/textures/appletree_specular.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   //useCustomColor = true; // temporary disabled
};

singleton Material(AppleBark) // яблоня ствол
{
   mapTo = "AppleBark";
   diffuseMap[0] = "art/models/3d/environment/trees/apple/textures/applebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/apple/textures/applebark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   specular[0] = "0.529412 0.443137 0.282353 1";
   specularPower[0] = "15";
   pixelSpecular[0] = "1";
   //useCustomColor = true; // temporary disabled
};

singleton Material(BirchTree) // береза
{
   mapTo = "BirchTree";
   diffuseMap[0] = "art/models/3d/environment/trees/birch/textures/birchtree_diffuse.dds";
   diffuseColor[0] = "0.905882 0.964706 0.996078 1";
   diffuseMap[1] = "art/models/3d/environment/trees/birch/textures/birchtree_normal.dds";
   specular[0] = "0.831373 0.968628 0.996078 1";
   specularPower[0] = "29";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   //useCustomColor = true; // temporary disabled
};

singleton Material(BirchBark) // береза ствол
{
   mapTo = "BirchBark";
   diffuseMap[0] = "art/models/3d/environment/trees/birch/textures/birchbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/birch/textures/birchbark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.901961 0.901961 0.901961 1";
   specular[0] = "0.894118 0.894118 0.890196 1";
   specularPower[0] = "25";
   pixelSpecular[0] = "1";
   //useCustomColor = true; // temporary disabled
};

singleton Material(AspenTree) // осина (бывшая ива)
{
   mapTo = "AspenTree";
   diffuseMap[0] = "art/models/3d/environment/trees/aspen/textures/aspentree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/aspen/textures/aspentree_normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   materialTag0 = "LiF";
};

singleton Material(AspenBark) // осина (бывшая ива) ствол
{
   mapTo = "AspenBark";
   diffuseMap[0] = "art/models/3d/environment/trees/aspen/textures/aspenbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/aspen/textures/aspenbark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "0";
   materialTag0 = "LiF";
   specular[0] = "0.670588 0.709804 0.513726 1";
   specularPower[0] = "22";
   pixelSpecular[0] = "1";
};

singleton Material(SpruceTree) // ель
{
   mapTo = "SpruceTree";
   diffuseMap[0] = "art/models/3d/environment/trees/spruce/textures/sprucetree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/spruce/textures/sprucetree_normal.dds";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
   specularPower[0] = "14";
};

singleton Material(SpruceBark) // ель ствол
{
   mapTo = "SpruceBark";
   diffuseMap[0] = "art/models/3d/environment/trees/spruce/textures/sprucebark_diffuse.dds";
   materialTag0 = "LiF";
   diffuseMap[1] = "art/models/3d/environment/trees/spruce/textures/sprucetree_normal.dds";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
};

singleton Material(PineTree) // сосна
{
   mapTo = "PineTree";
   diffuseMap[0] = "art/models/3d/environment/trees/pine/textures/pinetree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/pine/textures/pinetree_normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.85 0.85 0.85 1";
   specular[0] = "0.74902 0.6 0.470588 1";
   specularPower[0] = "40";
   pixelSpecular[0] = "1";
   materialTag0 = "LiF";
   //useCustomColor = true; // temporary disabled
};

singleton Material(PineBark) // сосна ствол
{
   mapTo = "PineBark";
   diffuseMap[0] = "art/models/3d/environment/trees/pine/textures/pinebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/pine/textures/pinebark_normal.dds";
   useAnisotropic[0] = "1";
   diffuseColor[0] = "0.901961 0.901961 0.901961 1";
   specular[0] = "0.85098 0.698039 0.509804 1";
   specularPower[0] = "22";
   pixelSpecular[0] = "1";
   //useCustomColor = true; // temporary disabled
};

//___________________________________________________________________________________
//FALLING TREES


singleton Material(OakTree_Diffuse)
{
   mapTo = "OakTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/oak/textures/oaktree_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/oak/textures/oaktree_normal.dds";
   //diffuseMap[2] = "art/models/3d/environment/trees/oak/textures/oaktree_specular.dds";
   specularPower[0] = "14";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   skinned = true;
};

singleton Material(OakBark01_Diffuse)
{
   mapTo = "OakBark01_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/oak/textures/oakbark_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/oak/textures/oakbark_normal.dds";
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(ElmTree_Diffuse)
{
   mapTo = "ElmTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/elm/textures/elmtree_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/elm/textures/elmtree_normal.dds";
   //diffuseMap[2] = "art/models/3d/environment/trees/elm/textures/elmtree_specular.dds";
   specularPower[0] = "14";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   skinned = true;
};

singleton Material(ElmBark_Diffuse)
{
   mapTo = "ElmBark_Diffuse";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[0] = "art/models/3d/environment/trees/elm/textures/elmbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/elm/textures/elmbark_normal.dds";
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(MapleTree_Diffuse)
{
   mapTo = "MapleTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/maple/textures/mapletree_diffuse.dds";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[1] = "art/models/3d/environment/trees/maple/textures/mapletree_normal.dds";
   //diffuseMap[2] = "art/models/3d/environment/trees/maple/textures/mapletree_specular.dds";
   specularPower[0] = "4";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   skinned = true;
};

singleton Material(MapleBark_Diffuse)
{
   mapTo = "MapleBark_Diffuse";
   diffuseColor[0] = "1 1 1 1";
   diffuseMap[0] = "art/models/3d/environment/trees/maple/textures/maplebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/maple/textures/maplebark_normal.dds";
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(MulberryTree_Diffuse)
{
   mapTo = "MulberryTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/mulberry/textures/mulberrytree_diffuse.dds";
   diffuseColor[0] = "0.92 0.92 0.92 1";
   diffuseMap[1] = "art/models/3d/environment/trees/mulberry/textures/mulberrytree_normal.dds";
   specular[0] = "0.996078 0.996078 0.996078 1";
   specularPower[0] = "21";
   pixelSpecular[0] = "1";
   //diffuseMap[2] = "art/models/3d/environment/trees/mulberry/textures/mulberrytree_specular.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(MulberryBark_Diffuse)
{
   mapTo = "MulberryBark_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/mulberry/textures/mulberrybark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/mulberry/textures/mulberrybark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   specular[0] = "0.494118 0.419608 0.372549 1";
   specularPower[0] = "18";
   pixelSpecular[0] = "1";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(AppleTree_Diffuse)
{
   mapTo = "AppleTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/apple/textures/appletree_diffuse.dds";
   diffuseColor[0] = "0.83 0.83 0.83 1";
   diffuseMap[1] = "art/models/3d/environment/trees/apple/textures/appletree_normal.dds";
   specular[0] = "0.996078 0.996078 0.996078 1";
   specularPower[0] = "21";
   pixelSpecular[0] = "1";
   //diffuseMap[2] = "art/models/3d/environment/trees/apple/textures/appletree_specular.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(AppleBark_Diffuse)
{
   mapTo = "AppleBark_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/apple/textures/applebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/apple/textures/applebark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.8 0.8 0.8 1";
   specular[0] = "0.529412 0.443137 0.282353 1";
   specularPower[0] = "15";
   pixelSpecular[0] = "1";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(BirchTree_Diffuse)
{
   mapTo = "BirchTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/birch/textures/birchtree_diffuse.dds";
   diffuseColor[0] = "0.905882 0.964706 0.996078 1";
   diffuseMap[1] = "art/models/3d/environment/trees/birch/textures/birchtree_normal.dds";
   specular[0] = "0.831373 0.968628 0.996078 1";
   specularPower[0] = "29";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "80";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(BirchBark_Diffuse)
{
   mapTo = "BirchBark_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/birch/textures/birchbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/birch/textures/birchbark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.901961 0.901961 0.901961 1";
   specular[0] = "0.894118 0.894118 0.890196 1";
   specularPower[0] = "25";
   pixelSpecular[0] = "1";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(AspenTree_Diffuse)
{
   mapTo = "AspenTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/aspen/textures/aspentree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/aspen/textures/aspentree_normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   materialTag0 = "LiF";
   skinned = true;
};

singleton Material(AspenBark_Diffuse)
{
   mapTo = "AspenBark_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/aspen/textures/aspenbark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/aspen/textures/aspenbark_normal.dds";
   useAnisotropic[0] = "1";
   alphaRef = "0";
   materialTag0 = "LiF";
   specular[0] = "0.670588 0.709804 0.513726 1";
   specularPower[0] = "22";
   pixelSpecular[0] = "1";
   skinned = true;
};

singleton Material(SpruceTree_Diffuse)
{
   mapTo = "SpruceTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/spruce/textures/sprucetree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/spruce/textures/sprucetree_normal.dds";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   materialTag0 = "LiF";
   specularPower[0] = "14";
   skinned = true;
};

singleton Material(SpruceBark_Diffuse)
{
   mapTo = "SpruceBark_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/spruce/textures/sprucebark_diffuse.dds";
   materialTag0 = "LiF";
   diffuseMap[1] = "art/models/3d/environment/trees/spruce/textures/sprucetree_normal.dds";
   pixelSpecular[0] = "1";
   //diffuseMap[2] = "art/models/3d/environment/trees/spruce/textures/sprucebark_specular.dds";
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(PineTree_Diffuse)
{
   mapTo = "PineTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/pine/textures/pinetree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/pine/textures/pinetree_normal.dds";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "111";
   diffuseColor[0] = "0.85 0.85 0.85 1";
   specular[0] = "0.74902 0.6 0.470588 1";
   specularPower[0] = "40";
   pixelSpecular[0] = "1";
   materialTag0 = "LiF";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(PineBark_Diffuse)
{
   mapTo = "PineBark_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/pine/textures/pinebark_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/pine/textures/pinebark_normal.dds";
   useAnisotropic[0] = "1";
   diffuseColor[0] = "0.901961 0.901961 0.901961 1";
   specular[0] = "0.85098 0.698039 0.509804 1";
   specularPower[0] = "22";
   pixelSpecular[0] = "1";
   skinned = true;
   //useCustomColor = true; // temporary disabled
};

singleton Material(JuniperTree_Diffuse)
{
   mapTo = "JuniperTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/juniper/textures/junipertree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/juniper/textures/junipertree_normal.dds";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   skinned = true;
};

singleton Material(JuniperBark)
{
   mapTo = "JuniperBark";
   diffuseMap[0] = "art/models/3d/environment/trees/juniper/textures/juniperbark.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/juniper/textures/juniperbark_normal.dds";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(HazelTree_Diffuse)
{
   mapTo = "HazelTree_Diffuse";
   diffuseMap[0] = "art/models/3d/environment/trees/hazel/textures/hazeltree_diffuse.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/hazel/textures/hazeltree_normal.dds";
   pixelSpecular[0] = "0";
   useAnisotropic[0] = "1";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   skinned = true;
};

singleton Material(CommonHazelBark)
{
   mapTo = "CommonHazelBark";
   diffuseMap[0] = "art/models/3d/environment/trees/hazel/textures/commonhazelbark.dds";
   diffuseMap[1] = "art/models/3d/environment/trees/hazel/textures/commonhazelbark_normal.dds";
   pixelSpecular[0] = "1";
   useAnisotropic[0] = "1";
   skinned = true;
};

singleton Material(MushroomsABCD)
{
   mapTo = "MushroomsABCD";
   diffuseMap[0] = "art/Textures/TextureLib/MushroomsABCD_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/MushroomsABCD_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/MushroomsABCD_SPECULAR.dds";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "100";
   normal3DC="1";
};

singleton Material(Flints_Pile)
{
   mapTo = "Flints_Pile";
   diffuseMap[0] = "art/Textures/TextureLib/Flints_Pile_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Flints_Pile_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Flints_Pile_SPECULAR.dds";
   normal3DC="1";
};

singleton Material(Slingstones_Pile)
{
   mapTo = "Slingstones_Pile";
   diffuseMap[0] = "art/Textures/TextureLib/Slingstones_Pile_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/TextureLib/Slingstones_Pile_NORMAL.dds";
   diffuseMap[2] = "art/Textures/TextureLib/Slingstones_Pile_SPECULAR.dds";
   normal3DC="1";
};