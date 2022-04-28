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
	$elm = AppartientManager::findById($_GET['id']);
} else {
	$elm = new Appartient();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionAppartient&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Appartient</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdActualite().'" name=IdActualite></div>';
echo '<label for=IdVideo class="caseForm labelForm">'.texte("IdVideo").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getIdVideo().'" name=IdVideo pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeAppartient"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i> </button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';