<?php

error_reporting(0);

$Salt = "MsxjVC11";                             // This value should be the same as on the C# application.
$FileSecureCode = "ZqiZXiNG1RvloHChmdoT";       // change this value as soon as possible with a secure key
$Pattern = $_GET['pattern'];                    // $Pattern will be the value given under the "?pattern=" argument.

$Pattern_List = file_get_contents("Pattern_List_" . $FileSecureCode . ".txt");
if(strpos($Pattern_List, $Pattern) !== false) {
	echo strtoupper(md5($Salt . $Pattern));
}
else { echo "Not found."; }
return;

?>