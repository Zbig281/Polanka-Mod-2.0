singleton SimGroup(CustomizationDataGroup);

$oldInstantGroup = $instantGroup;
$instantGroup = CustomizationDataGroup;

singleton ShaderData( CharacterCustomizationShaderData )
{
   DXVertexShaderFile = "shaders/common/material/UberShader.hlsl";
   DXPixelShaderFile  = "shaders/common/material/UberShader.hlsl";

   defines = "CHARACTER_CUSTOMIZATION=1;TORQUE_CUSTOM_COLOR=1;VS_SKINNING=1;";
};

//ТЕЛЕСНЫЕ ФИЧИ
//
// -----------------------------------------------MALE----------------------------------------------------
//
//--------------------------Tatoo------------------

singleton CustomizationData(Custom_Male_Body_Tatoo_1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v1_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Tatoo_2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v2_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Body_Tatoo_3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v3_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Body_Tatoo_4)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v4_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Tatoo_5)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v5_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Body_Tatoo_6)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v6_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Body_Tatoo_7)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v7_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Body_Tatoo_8)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v8_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

//--------------------------Paints------------------

singleton CustomizationData(Custom_Male_Body_Paint_v1)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Paint_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Paint_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Paint_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Paint_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Paint_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Paint_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Paint_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

//--------------------------Scars------------------

singleton CustomizationData(Custom_Male_Body_Scar_v1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v1_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v1_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v3_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v3_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v3_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v4)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v4_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v4_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v4_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v5)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v5_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};


// -----------------------------------------------FEMALE----------------------------------------------------//
//-------------------------Tatoo--------------------//

singleton CustomizationData(Custom_Female_Body_Tatoo_1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v1_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Tatoo_2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v2_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Female_Body_Tatoo_3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v3_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Female_Body_Tatoo_4)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v4_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Tatoo_5)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v5_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Tatoo_6)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v6_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Tatoo_7)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v7_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};



//-------------------------Paints--------------------//

singleton CustomizationData(Custom_Female_Body_Paint_v1)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v1_NORMALMAP.dds";
   diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Paint_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Paint_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v3_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v3_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Paint_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

//-------------------------Scars--------------------//

singleton CustomizationData(Custom_Female_Body_Scar_v1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v1_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v1_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Scar_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v2_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Scar_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v3_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v3_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v3_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Scar_v4)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v4_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v4_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v4_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Scar_v5)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Scar_v5_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};










//Лицевые фичи

//-------------------------------------------------------------MALE----------------------------------------------------

//----------------------------Tatoo------------------------//

singleton CustomizationData(Custom_Male_Head_Tatoo_1)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v1_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Head_Tatoo_2)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v2_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Head_Tatoo_3)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v3_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};


singleton CustomizationData(Custom_Male_Head_Tatoo_4)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v4_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Tatoo_5)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v5_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Tatoo_6)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v6_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Tatoo_7)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v7_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

//----------------------------Paints------------------------//

singleton CustomizationData(Custom_Male_Head_Paint_v1)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Paint_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Paint_v1_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Paint_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Paint_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Paint_v2_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

//----------------------------Scars------------------------//

singleton CustomizationData(Custom_Male_Head_Scar_v1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v1_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v1_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v1_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Scar_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v2_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Scar_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v3_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v3_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v3_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Scar_v4)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v4_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v4_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v4_SPECULAR.dds";
   shader = CharacterCustomizationShaderData;
};
singleton CustomizationData(Custom_Male_Head_Scar_v5)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

//--------------------------Dirt------------------

singleton CustomizationData(Custom_Male_Head_Dirt_v1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};


//--------------------------Meal------------------

singleton CustomizationData(Custom_Male_Head_Meal_v1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Meal_v1_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Meal_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Meal_v2_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Meal_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Meal_v3_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

//-------------------------------------------------------------FEMALE----------------------------------------------------

//----------------------------Paints------------------------//

singleton CustomizationData(Custom_Female_Head_Paint_v1)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v1_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Paint_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v2_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Paint_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v3_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v3_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Paint_v4)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v4_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v2_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Paint_v5)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v2_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Paint_v6)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v6_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v2_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Paint_v7)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v7_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Paint_v2_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};



//----------------------------Scars------------------------//

singleton CustomizationData(Custom_Female_Head_Scar_v1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v1_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v1_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v1_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Scar_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v2_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Scar_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v3_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v3_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v3_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Scar_v4)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v4_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v4_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v4_SPECULAR.dds";
   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Scar_v5)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Scar_v5_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

//--------------------------Meal------------------

singleton CustomizationData(Custom_Female_Head_Meal_v1)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Meal_v1_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Meal_v2)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Meal_v2_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Head_Meal_v3)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Head/Female_Feature_Head_Meal_v3_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

// Heraldry
singleton CustomizationData(Surcoat_armor_Heraldry)
{
	diffuseMap[3] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_Armor_ALPHA.dds";
};

singleton CustomizationData(Surcoat_Body_Heraldry)
{
	diffuseMap[3] = "art/Textures/CharacterTextures/Outfits/Surcoat/Surcoat_Body_ALPHA.dds";
};

singleton CustomizationData(KiteShieldHeraldry)
{
	diffuseMap[3] = "art/Textures/Shields/KiteShield_ALPHA_01.dds";
};

singleton CustomizationData(HeaterShieldHeraldry)
{
	diffuseMap[3] = "art/Textures/Shields/HeaterShield_ALPHA_01.dds";
};

singleton CustomizationData(PaviseShieldHeraldry)
{
	diffuseMap[3] = "art/Textures/Shields/PaviseShield_ALPHA_01.dds";
};

singleton CustomizationData(PrimitiveShieldHeraldry)
{
	diffuseMap[3] = "art/Textures/Shields/PrimitiveShield_ALPHA_01.dds";
};

singleton CustomizationData(RoundShieldHeraldry)
{
	diffuseMap[3] = "art/Textures/Shields/RoundShield_ALPHA_01.dds";
};

singleton CustomizationData(SteelRoundacheHeraldry)
{
	diffuseMap[3] = "art/Textures/Shields/SteelRoundache_ALPHA_01.dds";
};

singleton CustomizationData(TowerShieldHeraldry)
{
	diffuseMap[3] = "art/Textures/Shields/TowerShield_ALPHA_01.dds";
};

// ------------------- NEW SHIELDS HERALDRY ----------------

singleton CustomizationData(ShieldKiteAHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_Kite_A_ALPHA.dds";
};

singleton CustomizationData(ShieldWoodenRoundHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_WoodenRound_A_ALPHA.dds";
};

singleton CustomizationData(ShieldHeaterAHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_HeaterA_A_ALPHA.dds";
};

singleton CustomizationData(ShieldHeaterBHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_HeaterB_A_ALPHA.dds";
};

singleton CustomizationData(ShieldHeaterREGHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_HeaterREG_A_ALPHA.dds";
};

singleton CustomizationData(ShieldKiteHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_Kite_A_ALPHA.dds";
};

singleton CustomizationData(ShieldKiteREGHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_KiteREG_A_ALPHA.dds";
};

singleton CustomizationData(ShieldPaviseHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_Pavise_A_ALPHA.dds";
};

singleton CustomizationData(ShieldPrimitiveHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_Primitive_A_ALPHA.dds";
};

singleton CustomizationData(ShieldSteelRoundHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_SteelRound_A_ALPHA.dds";
};

singleton CustomizationData(ShieldTowerHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_Tower_A_ALPHA.dds";
};

singleton CustomizationData(ShieldWoodenRoundREGAHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_WoodenRoundREG_A_ALPHA.dds";
};

singleton CustomizationData(ShieldSteelRoundREGHeraldry)
{
  diffuseMap[3] = "art/Textures/Shields/Shield_SteelRoundREG_A_ALPHA.dds";
};

singleton CustomizationData(FlagOfficer_A_Heraldry_OPACITY)
{
  diffuseMap[3] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_A_Heraldry_OPACITY.dds";
};

singleton CustomizationData(FlagOfficer_B_Heraldry_OPACITY)
{
  diffuseMap[3] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_B_Heraldry_OPACITY.dds";
};

singleton CustomizationData(FlagOfficer_C_Heraldry_OPACITY)
{
  diffuseMap[3] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_C_Heraldry_OPACITY.dds";
};

singleton CustomizationData(FlagOfficer_G_Heraldry_OPACITY)
{
  diffuseMap[3] = "art/Textures/CharacterTextures/FlagOfficer/FlagOfficer_G_Heraldry_OPACITY.dds";
};

singleton CustomizationData(FlagGeneral_Heraldry_OPACITY)
{
    diffuseMap[3] = "art/Textures/CharacterTextures/FlagOfficer/FlagGeneral_Heraldry_OPACITY.dds";
};


//--------------------------NPC CUSTOMIZATION------------------

singleton CustomizationData(Custom_Male_Body_Tatoo_4_Ulf)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v4_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Tatoo_5_Ulf)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v5_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v5_Wranen_the_Hunter)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v5_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Scar_v5_Wranen_the_Hunter)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v2_prisoner)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Scar_v5_prisoner)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Tatoo_2_Assel)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v2_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Tatoo_3_Assel)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Tattoo_v3_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v2_Unnwart_the_Gravedigger)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v2_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Dirt_v1_Unnwart_the_Gravedigger)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Paint_v1_Solef_Orosekarpe)
{
   diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Paint_v1_DIFFUSE.dds";
   diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Paint_v1_NORMALMAP.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Dirt_v1_Karegast)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Dirt_v1_SPECULAR.dds";


   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Tatoo_6_Dahleborne_Sourgli)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Tattoo_v6_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Body_Scar_v4_Yermyk_Khtyn)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v4_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v4_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Body/Male_Feature_Body_Scar_v4_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Male_Head_Scar_v5_Yermyk_Khtyn)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_DIFFUSE.dds";
  diffuseMap[1] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_NORMALMAP.dds";
  diffuseMap[2] = "art/Textures/CharacterTextures/Customization/male/Features/Head/Male_Feature_Head_Scar_v5_SPECULAR.dds";

   shader = CharacterCustomizationShaderData;
};

singleton CustomizationData(Custom_Female_Body_Tatoo_1_Hoytuhanir)
{
  diffuseMap[0] = "art/Textures/CharacterTextures/Customization/Female/Features/Body/Female_Feature_Body_Tattoo_v1_DIFFUSE.dds";

   shader = CharacterCustomizationShaderData;
};



$instantGroup = $oldInstantGroup;
$oldInstantGroup = "";
