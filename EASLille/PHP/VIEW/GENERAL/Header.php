<body class="colonne ">
    <header class="background">
        <!-- <div class="demi"></div> -->
        
       
        <div><img src="./IMG/EAS (1).png" alt=""></div>
      
        <!-- <div class="titre"><?php echo texte($titre); ?></div> -->
        <!-- <div class="colonne"> -->
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="center">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=ActionDeconnexion" class="center">'. texte("Deconnexion") .'</a></div>';
               
            } else {
                echo '<a href="index.php?page=Default" class="center">'. texte("Connexion") .'</a>';
                echo '<a href="index.php?page=Inscription" class="center">'. texte("Inscription") .'</a>';
                echo '<div></div>';
            }
            ?>

        </div>
        <!-- <div class="demi"></div> -->
    </header>
  