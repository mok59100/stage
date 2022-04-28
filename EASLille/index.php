<?php

include "./PHP/CONTROLLER/Outils.php";

spl_autoload_register("ChargerClasse");

Parametres::init();

DbConnect::init();

session_start();

/******Les langues******/
/***On récupère la langue***/
if (isset($_GET['lang']) && TextesManager::checkIfLangExist($_GET['lang'])) {
	// tester si la langue est gérée
	$_SESSION['lang'] = $_GET['lang'];
} else if (isset($_COOKIE['lang'])) {
	$_SESSION['lang'] = $_COOKIE['lang'];
} else {
	$_SESSION['lang'] = 'FR';
}
//Crée un cookie lang sur la machine de l'utilisateur d'une durée de 10h.
setcookie("lang", $_SESSION['lang'], time() + 36000, '/');
/******Fin des langues******/

$routes = [
	"Default" => ["PHP/VIEW/FORM/", "FormConnexion", "Connexion", 0, false],
	"Inscription" => ["PHP/VIEW/FORM/", "FormInscription", "Inscription", 0, false],
	"Accueil" => ["PHP/VIEW/GENERAL/", "Accueil", "Accueil", 0, false],
	// "connection" => ["PHP/VIEW/FORM/", "FormInscription", "Identification", 0, false],
	"NousContacter" => ["PHP/VIEW/GENERAL/", "NousContacter", "Nous Contacter", 0, false],
	"DeposezVotreCv" => ["PHP/VIEW/GENERAL/", "DeposezVotreCv", "Deposez votre cv", 0, false],
	"QuiSommesNous" => ["PHP/VIEW/GENERAL/", "QuiSommesNous", "Qui sommes nous", 0, false],
	"Afficher" => ["PHP/VIEW/GENERAL/", "Afficher", "Afficher", 1, false],
	"Recuperer" => ["PHP/VIEW/GENERAL/", "Recuperer", "Recuperer", 1, false],

	// "index"=>["PHP/VIEW/GENERAL/","index","index",0,false],

	"ActionConnexion" => ["PHP/CONTROLLER/ACTION/", "ActionConnexion", "Action de la connexion", 0, false],
	"ActionInscription" => ["PHP/CONTROLLER/ACTION/", "ActionInscription", "Action de l'inscription", 0, false],
	"ActionDeconnexion" => ["PHP/CONTROLLER/ACTION/", "ActionDeconnexion", "Action de deconnexion", 0, false],

	"ListeMailAPI" => ["PHP/MODEL/API/", "ListeMailAPI", "ListeMailAPI", 0, true],

	"ListeActualites" => ["PHP/VIEW/LISTE/", "ListeActualites", "Liste Actualites", 2, false],
	"FormActualites" => ["PHP/VIEW/FORM/", "FormActualites", "Formulaire Actualites", 1, false],
	"ActionActualites" => ["PHP/CONTROLLER/ACTION/", "ActionActualites", "Action Actualites", 1, false],

	"ListeAdhesions" => ["PHP/VIEW/LISTE/", "ListeAdhesions", "Liste Adhesions", 2, false],
	"FormAdhesions" => ["PHP/VIEW/FORM/", "FormAdhesions", "Formulaire Adhesions", 1, false],
	"ActionAdhesions" => ["PHP/CONTROLLER/ACTION/", "ActionAdhesions", "Action Adhesions", 1, false],

	"ListeAppartient" => ["PHP/VIEW/LISTE/", "ListeAppartient", "Liste Appartient", 2, false],
	"FormAppartient" => ["PHP/VIEW/FORM/", "FormAppartient", "Formulaire Appartient", 1, false],
	"ActionAppartient" => ["PHP/CONTROLLER/ACTION/", "ActionAppartient", "Action Appartient", 1, false],

	"ListeContient" => ["PHP/VIEW/LISTE/", "ListeContient", "Liste Contient", 2, false],
	"FormContient" => ["PHP/VIEW/FORM/", "FormContient", "Formulaire Contient", 1, false],
	"ActionContient" => ["PHP/CONTROLLER/ACTION/", "ActionContient", "Action Contient", 1, false],

	"ListeCotisations" => ["PHP/VIEW/LISTE/", "ListeCotisations", "Liste Cotisations", 2, false],
	"FormCotisations" => ["PHP/VIEW/FORM/", "FormCotisations", "Formulaire Cotisations", 1, false],
	"ActionCotisations" => ["PHP/CONTROLLER/ACTION/", "ActionCotisations", "Action Cotisations", 1, false],

	"ListeDons" => ["PHP/VIEW/LISTE/", "ListeDons", "Liste Dons", 2, false],
	"FormDons" => ["PHP/VIEW/FORM/", "FormDons", "Formulaire Dons", 1, false],
	"ActionDons" => ["PHP/CONTROLLER/ACTION/", "ActionDons", "Action Dons", 1, false],

	"ListeImages" => ["PHP/VIEW/LISTE/", "ListeImages", "Liste Images", 2, false],
	"FormImages" => ["PHP/VIEW/FORM/", "FormImages", "Formulaire Images", 1, false],
	"ActionImages" => ["PHP/CONTROLLER/ACTION/", "ActionImages", "Action Images", 1, false],

	"ListeMessages" => ["PHP/VIEW/LISTE/", "ListeMessages", "Liste Messages", 2, false],
    "FormMessages" => ["PHP/VIEW/FORM/", "FormMessages", "Formulaire Messages", 1, false],
	"ActionMessages" => ["PHP/CONTROLLER/ACTION/", "ActionMessages", "Action Messages", 1, false],

	"ListeRoles" => ["PHP/VIEW/LISTE/", "ListeRoles", "Liste Roles", 2, false],
	"FormRoles" => ["PHP/VIEW/FORM/", "FormRoles", "Formulaire Roles", 2, false],
	"ActionRoles" => ["PHP/CONTROLLER/ACTION/", "ActionRoles", "Action Roles", 2, false],

	"ListeUtilisateurs" => ["PHP/VIEW/LISTE/", "ListeUtilisateurs", "Liste Utilisateurs", 2, false],
	"FormUtilisateurs" => ["PHP/VIEW/FORM/", "FormUtilisateurs", "Formulaire Utilisateurs", 1, false],
	"ActionUtilisateurs" => ["PHP/CONTROLLER/ACTION/", "ActionUtilisateurs", "Action Utilisateurs", 1, false],

	"ListeVideos" => ["PHP/VIEW/LISTE/", "ListeVideos", "Liste Videos", 2, false],
	"FormVideos" => ["PHP/VIEW/FORM/", "FormVideos", "Formulaire Videos", 1, false],
	"ActionVideos" => ["PHP/CONTROLLER/ACTION/", "ActionVideos", "Action Videos", 1, false],

];

if (isset($_GET["page"])) {

	$page = $_GET["page"];

	if (isset($routes[$page])) {
		AfficherPage($routes[$page]);
	} else {
		AfficherPage($routes["Default"]);
	}
} else {
	AfficherPage($routes["Default"]);
}
