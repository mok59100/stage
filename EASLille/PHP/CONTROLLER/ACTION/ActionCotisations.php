<?php
$elm = new Cotisations($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = CotisationsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = CotisationsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = CotisationsManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeCotisations");
}