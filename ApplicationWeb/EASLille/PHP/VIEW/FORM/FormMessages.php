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
	$elm = MessagesManager::findById($_GET['id']);
} else {
	$elm = new Messages();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionMessages&mode=' . $_GET['mode'] . '" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Messages</div>';

echo '<div class="noDisplay"><input type="hidden" value="' . $elm->getIdMessage() . '" name=IdMessage></div>';






echo '<label for=Auteur class="caseForm labelForm">' . texte("Auteur") . '</label>';
echo '<div class="caseForm donneeForm"><input type="text" ' . $disabled . 'value="' . $elm->getAuteur() . '" name=Auteur pattern="' . $regex["*"] . '"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Contenu class="caseForm labelForm">' . texte("Contenu") . '</label>';
echo '<div class="caseForm donneeForm"><input type="text" ' . $disabled . 'value="' . $elm->getContenu() . '" name=Contenu pattern="' . $regex["*"] . '"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Create_at class="caseForm labelForm">' . texte("Create_at") . '</label>';
echo '<div class="caseForm donneeForm"><input type="text" ' . $disabled . 'value="' . $elm->getCreate_at() . '" name=Create_at pattern="' . $regex["*"] . '"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';
echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeMessages"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
echo '<div></div>
	</div>';

echo '</form>';

echo '</main>';
