<?php
$elm = new Videos($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm->setVideos(chargerVideo());
		$elm = VideosManager::add($elm);
		break;
	}
	case "Modifier": {
		if (isset($_POST["modifVideo"]))
		{   /* suppression de l'ancienne video*/
			unlink("Videos/" . $_POST['AncienneVideos']);
			
			/* on charge la nouvelle Video */
			$elm->setVideos(chargerVideo());
		}
		else $elm->setVideos($_POST['AncienneVideos']);
		$elm = VideosManager::update($elm);
		break;
	}
	case "Supprimer": {
			/*suppression de la video */
			unlink("Videos/" . $elm->getVideos());
		$elm = VideosManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeVideos");
}


function chargerVideo()
{
    if (is_uploaded_file($_FILES["Videos"]["tmp_name"]))
    {
        $leNom = uniqid('mp4_') . '.mp4';
        move_uploaded_file($_FILES['Videos']['tmp_name'], 'Videos/' . $leNom);
    }
    return $leNom;
}