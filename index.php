
<?php
$name = 'du da';
$html = file_get_contents('start.html');

if(isset($_POST['btn'])){
	$html = str_replace('{success}',"button erfolgreich gedrueckt",$html);
	
} else {
	$html = str_replace('{success}',json_encode($_POST),$html);
}


$html = str_replace('{titel}','Homepage ' . $name,$html);
$html = str_replace('{name}',$name,$html);
echo $html; 



?>