
singleton ArrayObject(globalWorldInfos);

//----------------------------------------------------------
function getWorldRulesTextPath(%worldId)
{
	if(globalWorldInfos.count() == 0)
	{
		fillWorldInfos();
	}

	return globalWorldInfos.getValueFromKey(%worldId);
}
//----------------------------------------------------------
function fillWorldInfos()
{
	// add world id and path to world rules file
	globalWorldInfos.add("eu-main", "data/worlds_info/eu-main.txt");          // Avalon
	globalWorldInfos.add("na-main", "data/worlds_info/na-main.txt");          // Buyan
	globalWorldInfos.add("eu-second", "data/worlds_info/eu-second.txt");      // Epleland
	globalWorldInfos.add("eu-steam", "data/worlds_info/eu-steam.txt");        // Skjultland
	globalWorldInfos.add("eu-steam2", "data/worlds_info/eu-steam2.txt");      // Fannland
	globalWorldInfos.add("na-second", "data/worlds_info/na-second.txt");      // Telmun
	globalWorldInfos.add("eu-cis", "data/worlds_info/eu-cis.txt");            // Iriy
	globalWorldInfos.add("testshop-main", "data/worlds_info/eu-main.txt");    // testshop
}
//----------------------------------------------------------
