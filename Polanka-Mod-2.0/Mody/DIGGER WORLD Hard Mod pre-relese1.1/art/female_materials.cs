
//--------------------------------------------------ТЕЛА-----------------------------------------------------
singleton Material(Female_Body_v1_DIFFUSE_mat) //женское тело
{
   skinned = true;
   mapTo = "Female_Body_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Body_v1_SPECULAR.dds";
   useCustomColor = true;
   isBody = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";

   // Customization
   customizationData[0]  = Custom_Female_Body_Tatoo_1;
   customizationData[1]  = Custom_Female_Body_Tatoo_2;
   customizationData[2]  = Custom_Female_Body_Tatoo_3;
   customizationData[3]  = Custom_Female_Body_Tatoo_4;
   customizationData[4]  = Custom_Female_Body_Tatoo_5;
   customizationData[5]  = Custom_Female_Body_Tatoo_6;
   customizationData[6]  = Custom_Female_Body_Tatoo_7;
   customizationData[7]  = Custom_Female_Body_Paint_v1;
   customizationData[8]  = Custom_Female_Body_Paint_v2;
   customizationData[9]  = Custom_Female_Body_Paint_v3;
   customizationData[10]  = Custom_Female_Body_Scar_v1;
   customizationData[11]  = Custom_Female_Body_Scar_v2;
   customizationData[12]  = Custom_Female_Body_Scar_v3;
   customizationData[13]  = Custom_Female_Body_Scar_v4;
   customizationData[14]  = Custom_Female_Body_Scar_v5;
};


//------------------------------------------------ГОЛОВЫ------------------------------------------------------


singleton Material(Female_Head_Eur_v1_DIFFUSE_mat)//женская евро голова
{
   skinned = true;
   mapTo = "Female_Head_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v1_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "120";
   useAnisotropic[0] = "1";

   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;

};

singleton Material(Female_Head_Mon_v1_DIFFUSE_mat)//Женская монгольская голова
{
   skinned = true;
   mapTo = "Female_Head_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v1_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "120";
   useAnisotropic[0] = "1";
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};

singleton Material(Female_Head_Vik_v1_DIFFUSE_mat)//Женская голова викингов
{
   skinned = true;
   mapTo = "Female_Head_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v1_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "120";
   useAnisotropic[0] = "1";
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};

singleton Material(Female_Head_Eur_v2_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Head_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v2_NORMAL.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v2_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "100";
   useAnisotropic[0] = "1";
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};

singleton Material(Female_Head_Eur_v3_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Head_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Eur_v3_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "100";
   useAnisotropic[0] = "1";
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};

singleton Material(Female_Head_Mon_v2_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Head_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v2_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "130";
   useAnisotropic[0] = "1";
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};

singleton Material(Female_Head_Vik_v2_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Head_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v2_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "130";
   useAnisotropic[0] = "1";
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};


singleton Material(Female_Head_Mon_v3_DIFFUSE_mat)
{
   mapTo = "Female_Head_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Mon_v3_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "130";
   useAnisotropic[0] = "1";
   skinned = true;
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};

singleton Material(Female_Head_Vik_v3_DIFFUSE_mat)
{
   mapTo = "Female_Head_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Head_Vik_v3_SPECULAR.dds";
   materialTag0 = "LiF";
   useCustomColor = true;
   isFace = true;
   mipLODBias = -1.2;
   alphaTest = "1";
   alphaRef = "130";
   useAnisotropic[0] = "1";
   skinned = true;
   // Customization
  customizationData[0]  = Custom_Female_Head_Paint_v1;
  customizationData[1]  = Custom_Female_Head_Paint_v2;
  customizationData[2]  = Custom_Female_Head_Paint_v3;
  customizationData[3]  = Custom_Female_Head_Paint_v4;
  customizationData[4]  = Custom_Female_Head_Paint_v5;
  customizationData[5]  = Custom_Female_Head_Paint_v6;
  customizationData[6]  = Custom_Female_Head_Paint_v7;
  customizationData[7]  = Custom_Female_Head_Scar_v1;
  customizationData[8]  = Custom_Female_Head_Scar_v2;
  customizationData[9]  = Custom_Female_Head_Scar_v3;
  customizationData[10]  = Custom_Female_Head_Scar_v4;
  customizationData[11]  = Custom_Female_Head_Scar_v5;
  customizationData[12]  = Custom_Female_Head_Meal_v1;
  customizationData[13]  = Custom_Female_Head_Meal_v2;
  customizationData[14]  = Custom_Female_Head_Meal_v3;
};


//------------------------------------------------ВОЛОСЫ------------------------------------------------------

singleton Material(Female_Hair_All_v1_DIFFUSE_mat) //женская причёска для всех 1
{
   skinned = true;
   mapTo = "Female_Hair_All_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "104";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_All_v3_DIFFUSE_mat) //женская причёска для всех 3
{
   skinned = true;
   mapTo = "Female_Hair_All_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "104";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_Eur_v2_DIFFUSE_mat) //женская евро причёска 2
{
   skinned = true;
   mapTo = "Female_Hair_Eur_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v2_SPECULAR.dds";
   materialTag0 = "LiF";
   translucent = "0";
   alphaTest = "1";
   alphaRef = "36";
   useCustomColor = true;
   doubleSided = "1";
   isHair = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_Eur_v3_DIFFUSE_mat) //женская евро причёска 3
{
   skinned = true;
   mapTo = "Female_Hair_Eur_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v3_SPECULAR.dds";
   materialTag0 = "LiF";
   alphaTest = "1";
   alphaRef = "36";
   useCustomColor = true;
   doubleSided = "1";
   isHair = true;
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};


singleton Material(Female_Hair_Mon_v1_DIFFUSE_mat) //женская монгольская причёска 1
{
   skinned = true;
   mapTo = "Female_Hair_Mon_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "104";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mmipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_Mon_v2_DIFFUSE_mat) //женская монгольская причёска 1
{
   skinned = true;
   mapTo = "Female_Hair_Mon_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v2_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "104";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mmipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_Mon_v3_DIFFUSE_mat) //женская монгольская причёска 3
{
   skinned = true;
   mapTo = "Female_Hair_Mon_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Mon_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "104";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_Vik_v1_DIFFUSE_mat) //женская причёска для викингов 1
{
   skinned = true;
   mapTo = "Female_Hair_Vik_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v1_NORMALS.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v1_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "104";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_Vik_v3_DIFFUSE_mat) //женская причёска для викингов 3
{
   skinned = true;
   mapTo = "Female_Hair_Vik_v3_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v3_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v3_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v3_SPECULAR.dds";
   alphaTest = "1";
   translucent = "0";
   alphaRef = "104";
   doubleSided = "1";
   useCustomColor = true;
   isHair = true;
   materialTag0 = "LiF";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Hair_All_v2_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Hair_All_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_All_v2_SPECULAR.dds";
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
};

singleton Material(Female_Hair_Eur_v1_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Hair_Eur_v1_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Eur_v1_SPECULAR.dds";
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
};

singleton Material(Female_Hair_Vik_v2_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Hair_Vik_v2_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v2_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v2_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Hair/Female_Hair_Vik_v2_SPECULAR.dds";
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
};



//----------------------------------------------------НИЖНЕЕ БЕЛЬЁ------------------------------

singleton Material(Female_Underwear_Eur_DIFFUSE_mat)//Жен. европейское нижнее бельё
{
   skinned = true;
   mapTo = "Female_Underwear_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Eur_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "180";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Underwear_Vik_DIFFUSE_mat)//Жен. нижнее бельё викингов
{
   skinned = true;
   mapTo = "Female_Underwear_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Vik_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "180";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Underwear_Mon_DIFFUSE_mat)//Жен. монгольское нижнее бельё
{
   skinned = true;
   mapTo = "Female_Underwear_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Underwear_Mon_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "180";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

//----------------------------------------------------ЛОХМОТЬЯ------------------------------

singleton Material(Female_Tatters_Vik_DIFFUSE_mat)//Викинги
{
   skinned = true;
   mapTo = "Female_Tatters_Vik_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Vik_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Vik_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Vik_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Tatters_Eur_DIFFUSE_mat)//Европейки
{
   skinned = true;
   mapTo = "Female_Tatters_Eur_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Eur_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Eur_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Eur_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Tatters_Mon_DIFFUSE_mat)//Монголы
{
   skinned = true;
   mapTo = "Female_Tatters_Mon_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Mon_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Mon_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/female/Female_Tatters_Mon_SPECULAR.dds";
   normal3DC="1";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};


//______________________________________________
//КРАФТЕРСКИЕ СЕТЫ

singleton Material(Female_Monk_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Monk_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/Female_Monk_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/Female_Monk_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/Female_Monk_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Craft90_All_Alchemist_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Craft90_All_Alchemist_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/alchemist/Female_Craft90_All_Alchemist_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/alchemist/Female_Craft90_All_Alchemist_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/alchemist/Female_Craft90_All_Alchemist_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Craft90_All_Cook_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Craft90_All_Cook_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/cook/Female_Craft90_All_Cook_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/cook/Female_Craft90_All_Cook_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/cook/Female_Craft90_All_Cook_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Craft90_All_Blacksmith_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Craft90_All_Blacksmith_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/blacksmith/Female_Craft90_All_Blacksmith_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/blacksmith/Female_Craft90_All_Blacksmith_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/blacksmith/Female_Craft90_All_Blacksmith_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Craft90_All_Carpenter_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Craft90_All_Carpenter_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/carpenter/Female_Craft90_All_Carpenter_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/carpenter/Female_Craft90_All_Carpenter_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/carpenter/Female_Craft90_All_Carpenter_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Peasant_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Peasant_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Female_Peasant_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Female_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/Female_Peasant_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(Female_Decorated_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Female_Decorated_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/decorated/Female_Decorated_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/decorated/Female_Decorated_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/decorated/Female_Decorated_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};


singleton Material(Female_Craft90_All_Engineer_DIFFUSE_mat)
{
   mapTo = "Female_Craft90_All_Engineer_DIFFUSE";
   skinned = true;
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/engineer/Female_Craft90_All_Engineer_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/engineer/Female_Craft90_All_Engineer_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/engineer/Female_Craft90_All_Engineer_SPECULAR.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "110";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(famale_MnishiyD_mat)
{
   skinned = true;
   mapTo = "famale_MnishiyD";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/rags/FMnishiyD.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/rags/FMnishiyN.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/rags/FMnishiyS.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};

singleton Material(famale_robe_D_mat)
{
   skinned = true;
   mapTo = "famale_robe_D";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/monks/female/FMrobeD.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/monks/female/FMrobeN.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/monks/female/FMrobeS.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};


singleton Material(Fkrestiane_mat)
{
   skinned = true;
   mapTo = "Fkrestiane";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/FAkrestiane.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/FAkrestianeN.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/FAkrestianeS.dds";
   materialTag0 = "LiF";
   doubleSided = "1";
   alphaTest = "1";
   alphaRef = "150";
   mipLODBias = -1.2;
   useAnisotropic[0] = "1";
};


singleton Material(Peasant_Female_DIFFUSE_mat)
{
   skinned = true;
   mapTo = "Peasant_Female_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Outfits/Simple/Female_Peasant_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Outfits/Simple/Female_Peasant_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Outfits/Simple/Female_Peasant_SPECULAR.dds";
   alphaTest = "1";
   doubleSided = "1";
   alphaRef = "80";
   materialTag0 = "LiF";
   isBody = "1";
   useCustomColor = "1";
   useAnisotropic[0] = "1";
};

// --------------------------- 03-may-2017 armor materials update -----------------------------------------

singleton Material(RegularPadded_Female_Trousers_DIFFUSE_mat)
{
   mapTo = "RegularPadded_Female_Trousers_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Female_Trousers_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Female_Trousers_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Female_Trousers_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LamellarLeather_Female_Cape_DIFFUSE_mat)
{
   mapTo = "LamellarLeather_Female_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(LamellarLeather_Female_Trousers_DIFFUSE_mat)
{
   mapTo = "LamellarLeather_Female_Trousers_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Trousers_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Trousers_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/LamellarLeather/LamellarLeather_Female_Trousers_DIFFUSE.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(NoviceLeather_Female_Cape_DIFFUSE_mat)
{
   mapTo = "NoviceLeather_Female_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Female_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Female_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Leather/NoviceLeather/NoviceLeather_Female_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(NovicePadded_Female_Cape_DIFFUSE_mat)
{
   mapTo = "NovicePadded_Female_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Female_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Female_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/NovicePadded/NovicePadded_Female_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularPadded_Female_Cape_DIFFUSE_mat)
{
   mapTo = "RegularPadded_Female_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Female_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Female_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Padded/RegularPadded/RegularPadded_Female_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularScale_Female_Cape_DIFFUSE_mat)
{
   mapTo = "RegularScale_Female_Cape_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Female_Cape_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Female_Cape_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Female_Cape_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};

singleton Material(RegularScale_Female_Trousers_DIFFUSE_mat)
{
   mapTo = "RegularScale_Female_Trousers_DIFFUSE";
   diffuseMap[0] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Female_Trousers_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Female_Trousers_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Armors/Scale/RegularScale/RegularScale_Female_Trousers_SPECULAR.dds";
   alphaTest = "1";
   alphaRef = "33";
   normal3DC="1";
   skinned = true;
};
