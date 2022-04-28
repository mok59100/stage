<?php
$elm = new Dons($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = DonsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = DonsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = DonsManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeDons");
}