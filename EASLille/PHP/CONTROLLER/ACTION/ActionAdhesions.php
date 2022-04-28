<?php
$elm = new Adhesions($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = AdhesionsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = AdhesionsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = AdhesionsManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeAdhesions");
}