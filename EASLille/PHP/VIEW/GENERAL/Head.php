<!DOCTYPE html>
<html>
<head>
<?php


//Si le titre est indiqué, on l'affiche entre les balises <title>
echo (!empty($titre)) ? '<title>' . $titre . '</title>' : '<title> Titre de la page </title>';
echo '<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.15.4/css/all.css"
    integrity="sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm" crossorigin="anonymous">
<link rel="stylesheet" href="CSS/root.css">
<link rel="stylesheet" href="CSS/style.css">
<link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Alfa+Slab+One&family=Staatliches&display=swap" rel="stylesheet">';
if (substr($nom,0,4)=="Form"){
    echo '  <link rel="stylesheet" href="CSS/grids.css">
            <link rel="stylesheet" href="CSS/form.css">';
}
else if (substr($nom,0,4)=="List"){
    echo '  <link rel="stylesheet" href="CSS/grids.css">';
}
 echo '</head>';