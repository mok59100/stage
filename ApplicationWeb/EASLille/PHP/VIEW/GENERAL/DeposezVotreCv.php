<div class="bigEspace"></div>
<div class="NousContacter">
<div class="contactez-nous">

        <!-- <div> 
    <p>Un problème, une question, envie de nous envoyer un message d’amour ? N’hésitez pas à utiliser ce formulaire pour prendre contact avec nous !</p>
    </div>  -->

        <form name="contact_formu" method="post" action="">


         
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>
                <div class="espace"></div>

                <label for="nom">Votre nom :</label>
                <INPUT type="text" id="nom" name="nom" placeholder="Dupond" required value="<?php if (
                                                                                                isset($_POST['nom'])
                                                                                            ) echo htmlspecialchars($_POST['nom']); ?>">

                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>


                <label for="prenom">Votre prénom :</label>
                <INPUT type="text" id="prenom" name="prenom" placeholder="Martin" required value="<?php if (
                                                                                                        isset($_POST['prenom'])
                                                                                                    ) echo htmlspecialchars($_POST['prenom']); ?>">
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>

                <label for="email">Votre adresse mail :</label>
                <INPUT type="text" id="email" name="email" placeholder="monadresse@gmail.com" required value="<?php if (
                                                                                                                    isset($_POST['email'])
                                                                                                                ) echo htmlspecialchars($_POST['email']); ?>">
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>


                <label for="telephone">Téléphone :</label>
                <INPUT type="text" id="telephone" name="telephone" placeholder="06/23/89/85/21" required value="<?php if (
                                                                                                                    isset($_POST['telephone'])
                                                                                                                ) echo htmlspecialchars($_POST['telephone']); ?>">
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>



                <label for="situationProfessionnelle">Situation professionnelle :</label>
                <INPUT type="text" id=" situationProfessionnelle" name="situationProfessionnelle" placeholder=" comptable" required value="<?php if (
                                                                                                                                                isset($_POST['situationProfessionnelle'])
                                                                                                                                            ) echo htmlspecialchars($_POST['situationProfessionnelle']); ?>">
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>


                <!-- <div> -->
                <!-- <label for="sujet">Déposez votre CV :</label> -->
                <!-- <input type="button" id="btn" name="deposez votre cv" value="Download" /> -->
                <!-- <button id="fileRequest" class="dwnld-cta">Télécharger votre cv</button> -->
                <!-- <input type="file" id="avatar" name="avatar" accept=".doc,.pdf,.docx,.xml"> -->

                <!-- </div> -->

                <!-- <input type="button" id="btn" name="deposez votre lettre de motivation"   value="Download" />  -->
                <!-- <button id="fileRequest" class="dwnld-cta">Télécharger votre lettre de motivation</button> -->
               
                
               
                <label for='fichier'>Déposez votre CV <span> (max 2Mo)</span></label>
                <input type="file" id="fichier" name="fichier" accept=".doc,.pdf,.docx,.xml" required value="<?php if (
                                                                                                        isset($_POST['fichier'])
                                                                                                    ) echo htmlspecialchars($_POST['fichier']); ?>">
                                                                                                   
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>


                <label for="message">Votre message :</label>

                <textarea id="message" name="message" placeholder="Lettre de motivation...." required value="<?php if (
                                                                                                                    isset($_POST['message'])
                                                                                                                ) echo htmlspecialchars($_POST['message']); ?>">

       </textarea>
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>
                <div class="espace"></div>
              

                <button type="submit">Envoyer mon message</button>
                <div class="esp"> </div>
                <div class="espace"></div>
                <div class="espace"></div>
                <div class="espace"></div>

                <!-- <button type="submit">Envoyer mon message</button> -->



        </FORM>


        <?php


        ini_set("SMTP", "localhost");
        ini_set("smtp_port", "1025");

        //    $dest="contact@chiny.me";
        //    $objet="Rendez-vous";
        //    $message="
        //       <font face='arial'>
        //       Bonjourn
        //       Prière de se retrouver sur Skype à <b>18h</b> aujourd'hui.n
        //       Merci et bonne journée.
        //       </font>
        //    ";
        //    $entetes="From: sc@example.comn";
        //    $entetes.="Cc: chiny@example.comn";
        //    $entetes.="Content-Type: text/html; charset=iso-8859-1";

        //    if(mail($dest,$objet,$message,$entetes))
        //       echo "Mail envoyé avec succès.";
        //    else
        //       echo "Un problème est survenu.";
        //    exit;


        if (isset($_POST['email'])) {

            //eDIT THE 2 LINES BELOW AS REQUIRED
            $email_to = "moktar.terki@gmail.com";
            $email_subject = "Candidature";
        }
        function died($error)
        {
            //your error code can go here
            echo
            "Nous sommes désolés, mais des erreurs ont été détectées dans le" .
                " formulaire que vous avez envoyé. ";
            echo "Ces erreurs apparaissent ci-dessous.<br /><br />";
            echo $error . "<br /><br />";
            echo "Merci de corriger ces erreurs.<br /><br />";
            die();
        }


        // si la validation des données attendues existe
        if (
            !isset($_POST['nom']) ||
            !isset($_POST['prenom']) ||
            !isset($_POST['email']) ||
            !isset($_POST['telephone']) ||
            !isset($_POST['situationProfessionnelle']) ||
            !isset($_POST['fichier']) ||
            !isset($_POST['message'])
        ) {
            died(
                'Nous sommes désolés, mais le formulaire que vous avez soumis semble poser
 problème.'
            );
        }



        $nom = $_POST['nom']; // required
        $prenom = $_POST['prenom']; // required
        $email = $_POST['email']; // required
        $telephone = $_POST['telephone']; // required
        $situationProfessionnelle = $_POST['situationProfessionnelle']; //  required
        $fichier = $_POST['fichier']; // required
        $message = $_POST['message']; // required

        $error_message = "";
        $email_exp = '/^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$/';

        if (!preg_match($email_exp, $email)) {
            $error_message .=
                'L\'adresse e-mail que vous avez entrée ne semble pas être valide.<br />';
        }

        // Prend les caractères alphanumériques + le point et le tiret 6
        $string_exp = "/^[A-Za-z0-9 .'-]+$/";

        if (!preg_match($string_exp, $nom)) {
            $error_message .=
                'Le nom que vous avez entré ne semble pas être valide.<br />';
        }

        if (!preg_match($string_exp, $prenom)) {
            $error_message .=
                'Le prénom que vous avez entré ne semble pas être valide.<br />';
        }

        if (strlen($message) < 2) {
            $error_message .=
                'Le message que vous avez entré ne semble pas être valide.<br />';
        }

        if (strlen($error_message) > 0) {
            died($error_message);
        }

        $email_message = "Détail.\n\n";
        $email_message .= "Nom: " . $nom . "\n";
        $email_message .= "Prenom: " . $prenom . "\n";
        $email_message .= "Email: " . $email . "\n";
        $email_message .= "Telephone: " . $telephone . "\n";
        $email_message .= "Situation Professionnelle: " . $situationProfessionnelle . "\n";
        // $email_message .= "Fichier: ".$Fichier."\n";
        $email_message .= "Message: " . $message . "\n";



        // create email headers
        $headers = 'From: ' . $email . "\r\n" .
            'Reply-To: ' . $email . "\r\n" .
            'X-Mailer: PHP/' . phpversion();
        mail($email_to, $email_subject, $email_message, $headers);


        //*************************************************************** */
        //     error_reporting(E_ALL); 
        //     ini_set("display_errors", 1); //Affichage des erreurs

        //     //Eviter les insertions de scripts dans le cas d'un e-mail HTML
        //     $nom = htmlentities($_POST['nom']);
        //     $email_from = htmlentities($_POST['email']); 
        //     $message = htmlentities($_POST['message']);

        //     //Verifie si le fournisseur prend en charge les r
        //     if(preg_match("#@(hotmail|live|msn).[a-z]{2,4}$#", $email_from)){
        //         $passage_ligne = "\n";
        //     }else{
        //         $passage_ligne = "\r\n";
        //     }

        //     $email_to = "moktar.terki@gmail.com"; //Destinataire
        //     $email_subject = "Contact"; //Sujet du mail
        //     $boundary = md5(rand()); // clé aléatoire de limite

        //     function clean_string($string) {
        //         $bad = array("content-type","bcc:","to:","cc:","href");
        //         return str_replace($bad,"",$string);
        //     }

        //     $headers = "From: ".$nom." <".$email_from.">" . $passage_ligne; //Emetteur
        //     $headers.= "Reply-to: ".$nom." <".$email_from.">" . $passage_ligne; //Emetteur
        //     $headers.= "MIME-Version: 1.0" . $passage_ligne; //Version de MIME
        //     $headers.= 'Content-Type: multipart/mixed; boundary='.$boundary .' '. $passage_ligne; 
        //  //Contenu du message (alternative pour deux versions ex:text/plain et text/html

        // $email_message = '--' . $boundary . $passage_ligne; //Séparateur d'ouverture
        // $email_message .= "Content-Type: text/plain; charset=utf-8" . $passage_ligne; //Type du contenu
        // $email_message .= "Content-Transfer-Encoding: 8bit" . $passage_ligne; //Encodage
        // $email_message .= $passage_ligne .clean_string($message). $passage_ligne; //Contenu du message

        //     //Pièce jointe
        //         if(isset($_FILES["fichier"]) &&  $_FILES['fichier']['name'] != ""){ //Vérifie sur formulaire envoyé et que le fichier existe
        //             $nom_fichier = $_FILES['fichier']['name'];
        //             $source = $_FILES['fichier']['tmp_name'];
        //             $type_fichier = $_FILES['fichier']['type'];
        //             $taille_fichier = $_FILES['fichier']['size'];

        //             if($nom_fichier != ".htaccess"){ //Vérifie que ce n'est pas un .htaccess
        //                  if($type_fichier == "image/jpeg" 
        //                     || $type_fichier == "image/pjpeg" 
        //                     || $type_fichier == "application/pdf"){ //Soit un jpeg soit un pdf

        //                     if ($taille_fichier <= 2097152) { //Taille supérieure à Mo (en octets)
        //                         $tabRemplacement = array("é"=>"e", "è"=>"e", "à"=>"a"); //Remplacement des caractères spéciaux

        //                         $handle = fopen($source, 'r'); //Ouverture du fichier
        //                         $content = fread($handle, $taille_fichier); //Lecture du fichier
        //                         $encoded_content = chunk_split(base64_encode($content)); //Encodage
        //                         $f = fclose($handle); //Fermeture du fichier

        //                         $email_message .= $passage_ligne . "--" . $boundary . $passage_ligne; //Deuxième séparateur d'ouverture
        //                         $email_message .= 'Content-type:'.$type_fichier.';name="'.$nom_fichier.'"'. $passage_ligne; //Type de contenu (application/pdf ou image/jpeg)
        //                         $email_message .='Content-Disposition: attachment; filename="'.$nom_fichier.'"'. $passage_ligne; //Précision de pièce jointe
        //                         $email_message .= 'Content-transfer-encoding:base64'. $passage_ligne; //Encodage
        //                         $email_message .= $passage_ligne; //Ligne blanche. IMPORTANT !
        //                         $email_message .= $encoded_content. $passage_ligne; //Pièce jointe

        //                     }else{
        //                         //Message d'erreur
        //                         $email_message .= $passage_ligne ."L'utilisateur a tenté de vous envoyer une pièce jointe mais celle ci était superieure à 2Mo.". $passage_ligne;
        //                     }
        //                 }else{
        //                     //Message d'erreur
        //                     $email_message .= $passage_ligne ."L'utilisateur a tenté de vous envoyer une pièce jointe mais elle n'était pas au bon format.". $passage_ligne;
        //                 }
        //             }else{
        //                 //Message d'erreur
        //                 $email_message .= $passage_ligne ."L'utilisateur a tenté de vous envoyer une pièce jointe .htaccess.". $passage_ligne;
        //             }
        //         }
        //     $email_message .= $passage_ligne . "--" . $boundary . "--" . $passage_ligne; //Séparateur de fermeture

        //     
        ?>

        <!-- ************************************************************ -->



        <!-- mettez ici votre propre message de succès en html -->
        Merci de nous avoir contacter. Nous vous contacterons très bientôt


    </div>
</div>
</div>

</div>
<div class="bigEspace"></div>

</body>
<div class="bigEspace"></div>
<script src="./JS/script.js"></script>