//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------


function setHighlightSlot(%slot_ctrl, %slot)
{
	//echo("!!! >>> setHighlightSlot slot_ctrl = " @ %slot_ctrl @ " slot = " @ %slot);
	%image_id = UnavailableIndex;
	if (%slot $= "slot_head" || %slot $= "slot_hands" || %slot $= "slot_arms" || %slot $= "slot_feet" ||
		%slot $= "slot_weapon_small_left" || %slot $= "slot_weapon_small_right" || %slot $= "slot_weapon_big_left" || %slot $= "slot_weapon_big_right")
		%image_id = MiddleSlotHighlight;
	else if (%slot $= "slot_neck" || %slot $= "slot_ring_right" || %slot $= "slot_ring_left")
		%image_id = SmallSlotHighlight;
	else if (%slot $= "slot_body" || %slot $= "slot_legs" || %slot $= "slot_tabard")
		%image_id = LargeSlotHighlight;

	%slot_ctrl.setGlobalImageIndex(%image_id);
}
//-----------------------------------------------------------------------------

function resetHighlightSlot(%slot_ctrl, %slot)
{
	//echo("!!! >>> resetHighlightSlot slot_ctrl = " @ %slot_ctrl @ " slot = " @ %slot);
	%image_id = UnavailableIndex;
	if (%slot $= "slot_head" || %slot $= "slot_hands" || %slot $= "slot_arms" || %slot $= "slot_feet" ||
		%slot $= "slot_weapon_small_left" || %slot $= "slot_weapon_small_right" || %slot $= "slot_weapon_big_left" || %slot $= "slot_weapon_big_right")
		%image_id = MiddleSlot;
	else if (%slot $= "slot_neck" || %slot $= "slot_ring_right" || %slot $= "slot_ring_left")
		%image_id = SmallSlot;
	else if (%slot $= "slot_body" || %slot $= "slot_legs" || %slot $= "slot_tabard")
		%image_id = LargeSlot;

	%slot_ctrl.setGlobalImageIndex(%image_id);
}

function setEquipCountText(%textCtrl, %Val)
{
	if (isObject(%textCtrl) == false)
		return;

	if (%val >= 1000)
	{
		%val = %val/1000;
		%textCtrl.setText(%val @ "K");

		if (%val < 10)
		{
			%textCtrl.setProfile(equipCount2SignText);
		}
		else
		{
			%textCtrl.setProfile(equipCount3SignText);
		}
	}
	else
	{
		%textCtrl.setText(%val);

		if (%val < 100)
		{
			%textCtrl.setProfile(equipCount2SignText);
		}
		else
		{
			%textCtrl.setProfile(equipCount3SignText);
		}
	}
}

