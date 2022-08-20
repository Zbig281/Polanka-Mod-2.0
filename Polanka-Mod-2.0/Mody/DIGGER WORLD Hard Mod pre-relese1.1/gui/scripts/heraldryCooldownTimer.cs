//----------------------------------------------------------
function StartHeraldryTimer(%HeraldryButton)
{
	if (!isObject(%HeraldryButton))
	{
		return;
	}
	if (%HeraldryButton.schid != 0) // already scheduled
	{
		return;
	}
	UpdateHeraldryTimer(%HeraldryButton);
}
//----------------------------------------------------------
function StopHeraldryTimer(%HeraldryButton)
{
	if (!isObject(%HeraldryButton))
	{
		return;
	}
	if (%HeraldryButton.schid != 0) // scheduled
	{
		cancel(%HeraldryButton.schid);
		%HeraldryButton.schid = 0;
	}

	%HeraldryButton.setActive(true);
	%HeraldryButton.setText(GetMessageIDText(2406)); // Heraldry
}
//----------------------------------------------------------
function UpdateHeraldryTimer(%HeraldryButton)
{
	%timeString = getGuildHeraldryCooldown();

	if (%timeString $= "")
	{
		StopHeraldryTimer(%HeraldryButton);
		return;
	}

	%HeraldryButton.setActive(false);
	%HeraldryButton.setText(%timeString);

	%HeraldryButton.schid = schedule(1000, %HeraldryButton, "UpdateHeraldryTimer", %HeraldryButton);
}
//----------------------------------------------------------
