$remapDivision[$remapCount] = "Avatar Favorites";
for (%i = 1; %i < 10; %i++) {
	$remapName[$remapCount] = "Switch to Avatar Favorite #" @ %i;
	$remapCmd[$remapCount] = "AK_select" @ %i;
	$remapCount++;
}
$remapName[$remapCount] = "Switch to Avatar Favorite #0";
$remapCmd[$remapCount] = "AK_select0";
$remapCount++;

function AK_select(%isDown, %i) {
	if (%isDown) {
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
}

function AK_select1(%isDown) { AK_select(%isDown, 1); }
function AK_select2(%isDown) { AK_select(%isDown, 2); }
function AK_select3(%isDown) { AK_select(%isDown, 3); }
function AK_select4(%isDown) { AK_select(%isDown, 4); }
function AK_select5(%isDown) { AK_select(%isDown, 5); }
function AK_select6(%isDown) { AK_select(%isDown, 6); }
function AK_select7(%isDown) { AK_select(%isDown, 7); }
function AK_select8(%isDown) { AK_select(%isDown, 8); }
function AK_select9(%isDown) { AK_select(%isDown, 9); }
function AK_select0(%isDown) { AK_select(%isDown, 0); }
