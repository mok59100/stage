<?php
$elm = new Actualites($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = ActualitesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = ActualitesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = ActualitesManager::delete($elm);
		break;
	}
}

if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
	header("location:index.php?page=ListeActualites");
}
