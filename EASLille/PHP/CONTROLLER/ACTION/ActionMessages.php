<?php
$elm = new Messages($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = MessagesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = MessagesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = MessagesManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeMessages");
}