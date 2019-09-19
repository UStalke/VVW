
<?php
$name = 'du da';

$html = file_get_contents('start.html');
$html = str_replace('{titel}','Homepage ' . $name,$html);
$html = str_replace('{name}',$name,$html);
echo $html; 

?>