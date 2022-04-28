<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = CotisationsManager::getList();
//Création du template de la grid
echo '<div class="grid-col-8 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-8">Liste des Cotisations </div>';
echo '<div class="caseListe grid-columns-span-8">
<div></div>
<div class="caseListe"><a href="index.php?page=FormCotisations&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe labelListe">EtatCotisation</div>';
echo '<div class="caseListe labelListe">MontantCotisation</div>';
echo '<div class="caseListe labelListe">ModePaiement</div>';
echo '<div class="caseListe labelListe">DateCotisation</div>';
echo '<div class="caseListe labelListe">IdUtilisateur</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getEtatCotisation().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getMontantCotisation().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getModePaiement().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getDateCotisation().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getIdUtilisateur().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormCotisations&mode=Afficher&id='.$unObjet->getIdCotisation().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormCotisations&mode=Modifier&id='.$unObjet->getIdCotisation().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormCotisations&mode=Supprimer&id='.$unObjet->getIdCotisation().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-8">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';