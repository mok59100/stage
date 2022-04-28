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
	$elm = VideosManager::findById($_GET['id']);
} else {
	$elm = new Videos();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionVideos&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm titreForm col-span-form">Formulaire Videos</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdVideo().'" name=IdVideo></div>';
	
echo '<label for=Description class="caseForm labelForm">'.texte("Description").'</label>';
echo '<div class="caseForm donneeForm"><input type="text" '.$disabled .'value="'.$elm->getDescription().'" name=Description pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm infoForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=Videos class="caseForm labelForm">'.texte("Videos").'</label>';
echo '<div class="caseForm donneeForm"><video src="./Videos/'.$elm->getVideos().'" </video></div>';   
echo '<div class="caseForm">
				<input type="hidden" name="AncienneVideos" value="'.$elm->getVideos().'">
				<input type="file" name="Videos" '.$disabled.'/></div>';
echo '<div class="caseForm checkForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeVideos"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';