<?php
	date_default_timezone_set("Europe/Paris");
	$msg = $_GET['Message'];
	$auteur = $_GET['Auteur'];
	$dates = date('d/m/Y');
	$heure = date('H:i:s');
	try {
	// $linkpdo = new PDO("mysql:Host={localhost},Port={3308},DbName={easlille}", "{root}", "{}");	
	$linkpdo = new PDO ( 'mysql:host='. Parametres::getHost().';port='. Parametres::getPort() .';dbname='. Parametres::getDbname().';charset=utf8', Parametres::getLogin(), Parametres::getPwd());
	}
	catch(Exception $e){
		die('Erreur : '.$e->getMessage());
	}
	$res = $linkpdo->prepare('INSERT INTO messages(IdMessage,dates,Heure,Auteur,Message) VALUES (NULL,:dates,:heure,:auteur,:msg)');
    $res->bindParam(':heure', $heure);
	$res->bindParam(':dates', $dates);
	$res->bindParam(':auteur', $auteur);
	$res->bindParam(':msg', $msg);
	$res->execute();
