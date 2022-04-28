<?php
$elm = new Appartient($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = AppartientManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = AppartientManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = AppartientManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeAppartient");
}