//-----------------------------------------------------------------------------
// Craftsman & Marksman: Life is feudal
//-----------------------------------------------------------------------------

function GuiPlayersWindowSubBtn::onMouseOverChanged(%this, %mouse_over)
{
	%this.GetParent().forceMouseOver(%mouse_over);
}

function GuiPlayersWindowCharBtn::onWake(%this)
{
	%count = %this.getCount();
	for(%i = 0; %i < %count; %i++)
	{
		%ctrl = %this.getObject(%i);
		%ctrl.setActive(false);
	}
}

function GuiPlayersWindowCharBtn::onMouseOverChanged(%this, %mouse_over)
{
	%count = %this.getCount();
	%this-->highlighPanel.setVisible(%mouse_over);
	for(%i = 0; %i < %count; %i++)
	{
		%ctrl = %this.getObject(%i);
		%ctrl.setActive(%mouse_over);
	}
}
