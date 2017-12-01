$remapDivision[$remapCount] = "Avatar Favorites";
for (%i = 1; %i < 10; %i++) {
	$remapName[$remapCount] = "Switch to Avatar Favorite #" @ %i;
	$remapCmd[$remapCount] = "AK_select" @ %i;
	$remapCount++;
}
$remapName[$remapCount] = "Switch to Avatar Favorite #0";
$remapCmd[$remapCount] = "AK_select0";
$remapCount++;

function AK_select(%i) {
	%fn = "config/client/AvatarFavorites/" @ %i @ ".cs";
	if (isFile(%fn)) {
		exec(%fn);
		echo("Switched to avatar favorite #" @ %i);
	}
	else {
		echo("No config found for avatar favorite #" @ %i);
	}
	clientCmdUpdatePrefs();
}

function AK_select1() { AK_select(1); }
function AK_select2() { AK_select(2); }
function AK_select3() { AK_select(3); }
function AK_select4() { AK_select(4); }
function AK_select5() { AK_select(5); }
function AK_select6() { AK_select(6); }
function AK_select7() { AK_select(7); }
function AK_select8() { AK_select(8); }
function AK_select9() { AK_select(9); }
function AK_select0() { AK_select(0); }
