<html>
<div class="bigEspace"></div>
<div class="bigEspace"></div>
<div class="card-group">

  <div class="card center">


    <?php

    if ($_SESSION['utilisateur']->getIdRole() < 2) {
      echo '<a class="center" href="?page=FormDons&mode=Ajouter">
        <img src="./IMG/2.png" class="card-img-top" alt="...">
           </a>';
    } else {

      echo '<a class="center" href="?page=ListeDons">
      <img src="./IMG/2.png" class="card-img-top" alt="..."></a>';
    }
    //var_dump($_SESSION["utilisateur"]);  
    ?>







  </div>

  <div class="card center">

    <?php if ($_SESSION["utilisateur"]->getIdRole() < 2) {
      // echo '<a class="center" href="?page=FormActualites&mode=ajouter">
      //renvoi sur un epage web actualite sportive //
      echo '<a class="center" href="https://www.afrik-foot.com/">
        <img src="./IMG/7.png" class="card-img-top" alt="...">
        </a>';
    } else {
      echo '<a  class="center"  href="?page=ListeActualites">
         <img src="./IMG/7.png" class="card-img-top" alt="...">
         </a>';
    }

    // var_dump($_SESSION["utilisateur"]);  

    ?>
  </div>

  <div class="card center">


    <?php if ($_SESSION["utilisateur"]->getIdRole() < 2) {
      echo '<a class="center" href="?page=FormUtilisateurs&mode=Ajouter"> 
        <img src="./IMG/4.png" class="card-img-top" alt="...">
        </a>';
    } else {
      echo '<a  class="center"  href="?page=ListeUtilisateurs">
         <img src="./IMG/4.png" class="card-img-top" alt="...">
         </a>';
    }

    ?>



  </div>

  <div class="card center">

    <?php if ($_SESSION["utilisateur"]->getIdRole() < 2) {
      echo '<a class="center" href="?page=FormVideos&mode=Ajouter"> 
        <img src="./IMG/9.png" class="card-img-top" alt="...">
        </a>';
    } else {
      echo '<a  class="center"  href="?page=ListeVideos">
         <img src="./IMG/9.png" class="card-img-top" alt="...">
         </a>';
    }

    ?>






  </div>

</div>
<div class="bigEspace"></div>
<div class="bigEspace"></div>

<div class="card-group">

  <div class="card center">

    <?php if ($_SESSION["utilisateur"]->getIdRole() < 2) {
      echo '<a class="center" href="?page=FormAdhesions&mode=Ajouter"> 
        <img src="./IMG/6.png" class="card-img-top" alt="...">
        </a>';
    } else {
      echo '<a  class="center"  href="?page=ListeAdhesions">
         <img src="./IMG/6.png" class="card-img-top" alt="...">
         </a>';
    }

    ?>





  </div>
  <div class="card center">

    <?php if ($_SESSION["utilisateur"]->getIdRole() < 2) {
      echo '<a class="center" href="?page=Tchat"> 
      <img src="./IMG/3.png" class="card-img-top" alt="...">
        </a>';
    } else {

        echo '<a  class="center"  href="?page=ListeMessages">
  
         <img src="./IMG/3.png" class="card-img-top" alt="...">
         </a>';
    }

    ?>


  </div>
  <div class="card center">
    <?php if ($_SESSION["utilisateur"]->getIdRole() < 2) {
      echo '<a class="center" href="?page=FormCotisations&mode=Ajouter"> 
        <img src="./IMG/5.png" class="card-img-top" alt="...">
        </a>';
    } else {
      echo '<a  class="center"  href="?page=ListeCotisations">
         <img src="./IMG/5.png" class="card-img-top" alt="...">
         </a>';
    }

    ?>




  </div>
  <div class="card center">
    <?php if ($_SESSION["utilisateur"]->getIdRole() < 2) {
      echo '<a class="center" href="?page=FormImages&mode=Ajouter"> 
        <img src="./IMG/8.png" class="card-img-top" alt="...">
        </a>';
    } else {
      echo '<a  class="center"  href="?page=ListeImages">
         <img src="./IMG/8.png" class="card-img-top" alt="...">
         </a>';
    }

    ?>






  </div>
</div>

<div class="bigEspace"></div>
<div class="bigEspace"></div>
<?php


?>



</html>