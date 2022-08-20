//-----------------------------------------------------------------------------
// Create new character
//-----------------------------------------------------------------------------

function createCharacterWindow::onWake(%this)
{
	createCharacterEnteredName.makeFirstResponder(true);
}

function createCharacterWindow::InitVoices()
{
	%currentGender =GetCurrentGender();

	createCharacterVoicePopUpMenu.clear();
	if( %currentGender == 1) {	// MALE
		createCharacterVoicePopUpMenu.add("Male voice 0", 0);
		createCharacterVoicePopUpMenu.add("Male voice 1", 1);
		createCharacterVoicePopUpMenu.add("Male voice 2", 2);
		createCharacterVoicePopUpMenu.add("Male voice 3", 3);
	} else {			// FEMALE
		createCharacterVoicePopUpMenu.add("Female voice 0", 0);
		createCharacterVoicePopUpMenu.add("Female voice 1", 1);
		createCharacterVoicePopUpMenu.add("Female voice 2", 2);
		createCharacterVoicePopUpMenu.add("Female voice 3", 3);
	}
	createCharacterVoicePopUpMenu.setSelected( 0);
}

function createCharacterWindow::InitHaircuts()
{
	%currentGender =GetCurrentGender();

	createCharacterHaircutPopUpMenu.clear();
	if( %currentGender == 1) {	// MALE
		createCharacterHaircutPopUpMenu.add("Haircut 0", 0);
		createCharacterHaircutPopUpMenu.add("Haircut 1", 1);
		createCharacterHaircutPopUpMenu.add("Haircut 2", 2);
		createCharacterHaircutPopUpMenu.add("Haircut 3", 3);
		createCharacterHaircutPopUpMenu.add("Haircut 4", 4);
		createCharacterHaircutPopUpMenu.add("Haircut 5", 5);
		createCharacterHaircutPopUpMenu.add("Haircut 6", 6);
		createCharacterHaircutPopUpMenu.add("Haircut 7", 7);
		createCharacterHaircutPopUpMenu.add("Haircut 8", 8);
		createCharacterHaircutPopUpMenu.add("Haircut 9", 9);
		createCharacterHaircutPopUpMenu.add("Haircut 10", 10);
		createCharacterHaircutPopUpMenu.add("Haircut 11", 11);
		createCharacterHaircutPopUpMenu.add("Haircut 12", 12);			
		createCharacterHaircutPopUpMenu.add("Haircut 13", 13);
		createCharacterHaircutPopUpMenu.add("Haircut 14", 14);
		createCharacterHaircutPopUpMenu.add("Haircut 15", 15);
		createCharacterHaircutPopUpMenu.add("Haircut 16", 16);		
	} else {			// FEMALE
		createCharacterHaircutPopUpMenu.add("Haircut 0", 0);
		createCharacterHaircutPopUpMenu.add("Haircut 1", 1);
		createCharacterHaircutPopUpMenu.add("Haircut 2", 2);
		createCharacterHaircutPopUpMenu.add("Haircut 3", 3);
		createCharacterHaircutPopUpMenu.add("Haircut 4", 4);
		createCharacterHaircutPopUpMenu.add("Haircut 5", 5);
		createCharacterHaircutPopUpMenu.add("Haircut 6", 6);
		createCharacterHaircutPopUpMenu.add("Haircut 7", 7);
		createCharacterHaircutPopUpMenu.add("Haircut 8", 8);
		createCharacterHaircutPopUpMenu.add("Haircut 9", 9);
		createCharacterHaircutPopUpMenu.add("Haircut 10", 10);
		createCharacterHaircutPopUpMenu.add("Haircut 11", 11);

	}
	createCharacterHaircutPopUpMenu.setSelected( 0);
}

function createCharacterWindow::InitBeards() {
	%currentGender =GetCurrentGender();

	createCharacterFacialHairPopUpMenu.clear();
	if( %currentGender == 1) {	// MALE
		createCharacterFacialHairPopUpMenu.add("Facial hair 0", 0);
		createCharacterFacialHairPopUpMenu.add("Facial hair 1", 1);
		createCharacterFacialHairPopUpMenu.add("Facial hair 2", 2);
		createCharacterFacialHairPopUpMenu.add("Facial hair 3", 3);
		createCharacterFacialHairPopUpMenu.add("Facial hair 4", 4);
		createCharacterFacialHairPopUpMenu.add("Facial hair 5", 5);
		createCharacterFacialHairPopUpMenu.add("Facial hair 6", 6);
		createCharacterFacialHairPopUpMenu.add("Facial hair 7", 7);
		createCharacterFacialHairPopUpMenu.add("Facial hair 8", 8);
		createCharacterFacialHairPopUpMenu.add("Facial hair 9", 9);
		createCharacterFacialHairPopUpMenu.add("Facial hair 10", 10);
		createCharacterFacialHairPopUpMenu.add("Facial hair 11", 11);
		createCharacterFacialHairPopUpMenu.add("Facial hair 12", 12);
		createCharacterFacialHairPopUpMenu.add("Facial hair 13", 13);
		createCharacterFacialHairPopUpMenu.add("Facial hair 14", 14);
		createCharacterFacialHairPopUpMenu.add("Facial hair 15", 15);
		createCharacterFacialHairPopUpMenu.add("Facial hair 16", 16);
		createCharacterFacialHairPopUpMenu.active ="1";
	} else {			// FEMALE
		createCharacterFacialHairPopUpMenu.add("No facial hair", 0);
		createCharacterFacialHairPopUpMenu.active ="0";
	}
	createCharacterFacialHairPopUpMenu.setSelected( 0);
}

function createCharacterWindow::InitHeads()
{
	createCharacterHeadSlider.setRange( "0" SPC strformat( "%u", GetNumberOfHeads() -1));
}

function createCharacterWindow::InitHairColors()
{
	HairColorSliderCtrl.setRange( "0" SPC strformat( "%u", GetNumberOfHairColors() -1));
}

function createCharacterWindow::InitSkinColors()
{
	SkinToneGuiSliderCtrl.setRange( "0" SPC strformat( "%u", GetNumberOfSkinColors() -1));
}

function createCharacterWindow::OnCancelBtn()
{
   CreateCharacterCancelPressed();
}   

function createCharacterWindow::OnNextBtn()
{
   CreateCharacterNextPressed();
}   

function createCharacterWindow::OnPlusBtn()
{
	createCharacterModel.setOrbitZPos( 2.82);
	createCharacterModel.setOrbitDistance( 3.2);
}   

function createCharacterWindow::OnMinusBtn()
{
	createCharacterModel.setOrbitZPos( 2.2);
	createCharacterModel.setOrbitDistance( 7.5);
}

function createCharacterEnteredName::onTabComplete( %this, %val)
{
	createCharacterEnteredFamily.makeFirstResponder(true);
}

function createCharacterEnteredFamily::onTabComplete( %this, %val)
{
	createCharacterEnteredName.makeFirstResponder(true);
}

//----------------------------------------

function createCharacterMaleBut::onStateChanged( %this, %state)
{
	if( %state ==1) {
		GenderMalePressed();
	}
}

function createCharacterFemaleBut::onStateChanged( %this, %state)
{
	if( %state ==1) {
		GenderFemalePressed();
	}
}

//HeadSliderCtrl (3 variants)
function createCharacterHeadSlider::onValueChanged(%this)
{
	HeadChangePressed( createCharacterHeadSlider.getValue());
}

//FacialFeaturesSliderCtrl (16 variants)
function FacialFeaturesSliderCtrl::onValueChanged(%this)
{
	FacialFeaturesChangePressed( FacialFeaturesSliderCtrl.getValue());
}

//createCharacterHaircutPopUpMenu (8 variants)
function createCharacterHaircutPopUpMenu::onSelect( %this, %id, %text)
{
	HairChangePressed( createCharacterHaircutPopUpMenu.getSelected());
}

//createCharacterFacialHairPopUpMenu (8 variants (only for men))
function createCharacterFacialHairPopUpMenu::onSelect( %this, %id, %text)
{
	BeardChangePressed( createCharacterFacialHairPopUpMenu.getSelected());
}

//HairColorSliderCtrl (8 variants)
function HairColorSliderCtrl::onValueChanged(%this)
{
	HairColorChangePressed( HairColorSliderCtrl.getValue());
}

//BodyFeaturesSliderCtrl (8 variants)
function BodyFeaturesSliderCtrl::onValueChanged(%this)
{
	BodyFeaturesChangePressed( BodyFeaturesSliderCtrl.getValue());
}

//SkinToneGuiSliderCtrl (8 variants)
function SkinToneGuiSliderCtrl::onValueChanged(%this)
{
	SkinColorChangePressed( SkinToneGuiSliderCtrl.getValue());
}

function createCharacterWindow::OnRandomAppearance( %this, %state)
{
	RandomAppearancePressed();
}

//createCharacterVoicePopUpMenu (4 variants)
function createCharacterVoicePopUpMenu::onSelect( %this, %id, %text)
{
	VoiceChangePressed( createCharacterVoicePopUpMenu.getSelected());
}

function clearSliders()
{
	SetArtisanRange         (0, 0);
	SetConstructRange       (0, 0);
	SetNatureloreRange      (0, 0);
	SetHuntingRange         (0, 0);
	
	SetCavalrymanRange      (0, 0);
	SetMilitiaRange		    (0, 0);
	SetFootmanRange			(0, 0);
	SetSlingerRange         (0, 0);
	SetAssaulterRange       (0, 0);

	ArtisanSlider.setValue(0);
	ConstructSlider.setValue(0);
	NatureloreSlider.setValue(0);
	HuntingSlider.setValue(0);

	CavalrymanSlider.setValue(0);
	MilitiaSlider.setValue(0);
	FootmanSlider.setValue(0);
	SlingerSlider.setValue(0);
	AssaulterSlider.setValue(0);
}

//createCharacterEurBut
function createCharacterEurBut::onStateChanged( %this, %state)
{
   if(%state == 1)
   {
      createCharacterDescriptionText.setText(GetMessageIDText(698));
      createCharacterRaceIcon.setGlobalImageIndex("CharSelectRace1");
      createCharacterRaceName.setText(GetMessageIDText(1257));
      SetStrenghtRange        (12, 30);
      SetAgilityRange         (12, 30);
      SetConstitutionRange    (12, 30);
      SetWillpowerRange       (12, 30);
      SetIntelligenceRange    (12, 30);

		clearSliders();
		SetArtisanRange         (35, 55);
		SetConstructRange       (0,  25);
		SetNatureloreRange      (0,  25);
		SetHuntingRange         (0,  25);

		SetCavalrymanRange      (30, 55);
		SetMilitiaRange		    (0,  25);
		SetFootmanRange		   	(0,  25);
		SetSlingerRange         (0,  25);
		SetAssaulterRange       (0,  25);

		//basic Euro skills

		ArtisanSlider.setValue(45);
		ConstructSlider.setValue(15);
		NatureloreSlider.setValue(0);
		HuntingSlider.setValue(0);

		CavalrymanSlider.setValue(30);
		MilitiaSlider.setValue(25);
		FootmanSlider.setValue(0);
		SlingerSlider.setValue(0);
		AssaulterSlider.setValue(0);

		StrenghtGuiSliderCtrl.setValue(15);
		AgilityGuiSliderCtrl.setValue(15);
		ConstitutionGuiSliderCtrl.setValue(15);
		WillpowerGuiSliderCtrl.setValue(15);
		IntelligenceGuiSliderCtrl.setValue(15);

      RaceChangePressed( 1);
   }
}

//createCharacterVikBut
function createCharacterVikBut::onStateChanged( %this, %state)
{
   if (%state == 1)
   {
      createCharacterDescriptionText.setText( GetMessageIDText(699));
      createCharacterRaceIcon.setGlobalImageIndex("CharSelectRace2");
      createCharacterRaceName.setText(GetMessageIDText(1258));

      SetStrenghtRange        (15, 30);
      SetAgilityRange         (10, 30);
      SetConstitutionRange    (15, 30);
      SetWillpowerRange       (10, 30);
      SetIntelligenceRange    (10, 30);
      
		clearSliders();
		SetArtisanRange         (30, 55);
		SetConstructRange       (0,  25);
		SetNatureloreRange      (5,  30);
		SetHuntingRange         (0,  25);
		
		SetCavalrymanRange      (0,  25);
		SetMilitiaRange		    (0,  25);
		SetFootmanRange		   	(30,  55);
		SetSlingerRange         (0, 25);
		SetAssaulterRange       (0,  25);

		//basic Vik skills

		ArtisanSlider.setValue(30);
		ConstructSlider.setValue(0);
		NatureloreSlider.setValue(30);
		HuntingSlider.setValue(0);

		CavalrymanSlider.setValue(0);
		MilitiaSlider.setValue(0);
		FootmanSlider.setValue(40);
		SlingerSlider.setValue(0);
		AssaulterSlider.setValue(15);

		StrenghtGuiSliderCtrl.setValue(15);
		AgilityGuiSliderCtrl.setValue(15);
		ConstitutionGuiSliderCtrl.setValue(15);
		WillpowerGuiSliderCtrl.setValue(15);
		IntelligenceGuiSliderCtrl.setValue(15);

		RaceChangePressed(2);
   }
}

//createCharacterMonBut
function createCharacterMonBut::onStateChanged( %this, %state)
{
   if( %state ==1)
   {
      createCharacterDescriptionText.setText( GetMessageIDText( 700));
      createCharacterRaceIcon.setGlobalImageIndex("CharSelectRace3");
      createCharacterRaceName.setText(GetMessageIDText(1259));

      SetStrenghtRange        (10, 30);
      SetAgilityRange         (15, 30);
      SetConstitutionRange    (10, 30);
      SetWillpowerRange       (15, 30);
      SetIntelligenceRange    (10, 30);

		clearSliders();
		SetArtisanRange         (30, 55);
		SetConstructRange       (0,  25);
		SetNatureloreRange      (0,  25);
		SetHuntingRange         (5,  25);
		
		SetCavalrymanRange      (0,  25);
		SetMilitiaRange		    (0,  25);
		SetFootmanRange		   	(0,  25);
		SetSlingerRange         (30, 55);
		SetAssaulterRange       (0,  25);

		// basic mon skills

		ArtisanSlider.setValue(30);
		ConstructSlider.setValue(0);
		NatureloreSlider.setValue(5);
		HuntingSlider.setValue(25);

		CavalrymanSlider.setValue(0);
		MilitiaSlider.setValue(0);
		FootmanSlider.setValue(0);
		SlingerSlider.setValue(55);
		AssaulterSlider.setValue(0);

		StrenghtGuiSliderCtrl.setValue(15);
		AgilityGuiSliderCtrl.setValue(15);
		ConstitutionGuiSliderCtrl.setValue(15);
		WillpowerGuiSliderCtrl.setValue(15);
		IntelligenceGuiSliderCtrl.setValue(15);

      RaceChangePressed( 3);
   }
}

//----------------------------------------

function StrenghtGuiSliderCtrl::onValueChanged(%this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 0);
	StrenghtValTextCtrl.text = StrenghtGuiSliderCtrl.getValue();
}

function AgilityGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 1);
	AgilityValTextCtrl.text = AgilityGuiSliderCtrl.getValue();
}

function ConstitutionGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 2);
	ConstitutionValTextCtrl.text = ConstitutionGuiSliderCtrl.getValue();
}

function WillpowerGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 3);
	WillpowerValTextCtrl.text = WillpowerGuiSliderCtrl.getValue();
}

function IntelligenceGuiSliderCtrl::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeStatSliders( 4);
	IntelligenceValTextCtrl.text = IntelligenceGuiSliderCtrl.getValue();
}

function checkChilSkillSlider(%parentSlider, %childSlider)
{
	%val = %parentSlider.getValue();
	if (%val >= 30)
	{
		%childSlider.setActive(true);
		%childSlider.createObjectTooltip(0);
	}
	else
	{
		%childSlider.setActive(false);
		%childSlider.setValue(0);
		%childSlider.createObjectTooltip(2416);
	}

}

function ArtisanSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 0);
	ArtisanValTextCtrl.text = ArtisanSlider.getValue();
	checkChilSkillSlider(ArtisanSlider, ConstructSlider);
}

function ConstructSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 1);
	ConstructValTextCtrl.text = ConstructSlider.getValue();
}

function NatureloreSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 2);
	NatureloreValTextCtrl.text = NatureloreSlider.getValue();
}

function HuntingSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeCraftingSkillSliders( 3);
	HuntingValTextCtrl.text = HuntingSlider.getValue();
}

function CavalrymanSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 0);
	CavalrymanValTextCtrl.text = CavalrymanSlider.getValue();
}

function MilitiaSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 1);
	MilitiaValTextCtrl.text = MilitiaSlider.getValue();
}

function FootmanSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 2);
	FootmanValTextCtrl.text = FootmanSlider.getValue();
}

function SlingerSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 3);
	SlingerValTextCtrl.text = SlingerSlider.getValue();
}

function AssaulterSlider::onValueChanged( %this)
{
   if (!%this.isAwake())
      return;

	normalizeFightingSkillSliders( 4);
	AssaulterValTextCtrl.text = AssaulterSlider.getValue();
}

//----------------------------------------

function CharSelectionCreatePressed()
{
   closeCharacterSelectionDialog();
   createWindowCreateCharacter();
   OpenCharacterCreationDialog();
}
//----------------------------------------

function CreateCharacterAcceptLosePoints()
{
	if (isObject(createCharacterWindow))
	{
		createCharacterWindow.acceptLosePoints = true;
		CreateCharacterNextPressed();
	}
}

function CreateCharacterIsAcceptLosePoints()
{
	if (isObject(createCharacterWindow))
	{
		return createCharacterWindow.acceptLosePoints;
	}
	return false;
}