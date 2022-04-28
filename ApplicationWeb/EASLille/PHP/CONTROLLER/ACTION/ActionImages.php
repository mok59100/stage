<?php
$elm = new Images($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm->setImages(chargerImage());
		$elm = ImagesManager::add($elm);
		break;
	}
	case "Modifier": {
		if (isset($_POST["modifImage"]))
		{   /* suppression de l'ancienne image*/
			unlink("IMG/" . $_POST['AncienneImages']);
			/* on charge la nouvelle image */
			$elm->setImages(chargerImage());
		}
		else $elm->setImages($_POST['AncienneImages']);
		$elm = ImagesManager::update($elm);
		break;
	}
	case "Supprimer": {
		/*suppression de l'image */
		unlink("IMG/" . $elm->getImages());
		$elm = ImagesManager::delete($elm);
		break;
	}
}
if ($_SESSION["utilisateur"]->getIdRole() < 2) {
	header("location:index.php?page=Accueil");
}else{
header("location:index.php?page=ListeImages");
}



function chargerImage()
{
    if (is_uploaded_file($_FILES["Images"]["tmp_name"]))
    {
        $leNom = uniqid('jpg_') . '.jpg';
        move_uploaded_file($_FILES['Images']['tmp_name'], 'IMG/' . $leNom);
    }
    return $leNom;
}