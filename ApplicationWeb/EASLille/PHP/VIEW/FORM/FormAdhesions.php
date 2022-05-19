<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Afficher":
	case "Supprimer":
		$disabled = " disabled ";
		break;
}

if (isset($_GET['id'])) {
	$elm = AdhesionsManager::findById($_GET['id']);
} else {
	$elm = new Adhesions();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionAdhesions&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Adhesions</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdAdhesion().'" name=IdAdhesion></div>';

echo '<label for=DateDebutAdhesion class="caseForm labelForm">'.texte("DateDebutAdhesion").'</label>';
echo '<div class="caseForm donneeForm"><input type="Date" '.$disabled .'value="'.$elm->getDateDebutAdhesion().'" name=DateDebutAdhesion pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=DateFinAdhesion class="caseForm labelForm">'.texte("DateFinAdhesion").'</label>';
echo '<div class="caseForm donneeForm"><input type="Date" '.$disabled .'value="'.$elm->getDateFinAdhesion().'" name=DateFinAdhesion pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=IdUtilisateur class="caseForm labelForm">'.texte("IdUtilisateur").'</label>';
echo '<div class="caseForm donneeForm">'.creerSelect(null,"utilisateurs",["Nom"]).'</div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeAdhesions"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';