<?php
$elm = new Roles($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = RolesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = RolesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = RolesManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeRoles");
}