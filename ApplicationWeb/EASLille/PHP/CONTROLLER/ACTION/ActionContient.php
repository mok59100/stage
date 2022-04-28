<?php
$elm = new Contient($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = ContientManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = ContientManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = ContientManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeContient");
}