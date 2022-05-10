 <!-- <div class="bigEspace"></div>  -->
<div class="NousContacter">
<div class="contactez-nous">
    <!-- <div>
    <h1>Contactez-nous</h1>
    </div> -->
<!-- <div> 
    <p>Un problème, une question, envie de nous envoyer un message d’amour ? N’hésitez pas à utiliser ce formulaire pour prendre contact avec nous !</p>
    </div>  -->
    <form name="contact_formu" method="post" action=""> 

        
    <div class="esp">
        <div class="espace"></div>
        <div class="espace"></div>
        <div class="espace"></div>
    
            <label for="nom">Votre nom :</label>
            <input type="text" id="nom" name="nom" placeholder="Dupond" required
            value="<?php if (
isset($_POST['nom'])) echo htmlspecialchars($_POST['nom']);?>"> 

<div class="esp"> </div>
<div class="espace"></div>
 <div class="espace"></div>       
   

            <label for="nom">Votre prénom :</label>
            <input type="text" id="prenom" name="prenom" placeholder="Martin" required
            value="<?php if (
isset($_POST['prenom'])) echo htmlspecialchars($_POST['prenom']);?>"> 
<div class="esp"></div>
            <div class="espace"></div>
            <div class="espace"></div>
        
        
            <label for="email">Votre adresse mail :</label>
            <input type="email" id="email" name="email" placeholder="monadresse@gmail.com" required
            value="<?php if (
isset($_POST['email'])) echo htmlspecialchars($_POST['email']);?>">
        
<div class="esp"></div>
<div class="espace"></div>
<div class="espace"></div>


        
            <label for="telephone">Téléphone :</label>
            <input type="telephone" id="telephone" name="telephone" placeholder="06/23/89/85/21" required
                   value="<?php if (
isset($_POST['telephone'])) echo htmlspecialchars($_POST['telephone']);?>"> 

<div class="esp"> </div>               
<div class="espace"></div>
<div class="espace"></div>


       
            <label for="situationProfessionnelle">Situation 
                 :</label>
            <input type="situationProfessionnelle" id=" situationProfessionnelle" name="situationProfessionnelle" placeholder=" comptable" required
            value="<?php if (
isset($_POST['situationProfessionnelle'])) echo htmlspecialchars($_POST['situationProfessionnelle']);?>"> 

        
<div class="esp"></div>
            <div class="espace"></div>
            <div class="espace"></div>

       
            <label for="sujet">Sujet du message :</label>
          
            <select name="sujet" id="sujet" required
               value="<?php if (
isset($_POST['sujet'])) echo htmlspecialchars($_POST['sujet']);?>"> 
            
                <option value="" disabled selected hidden>Quel est le sujet de votre message</option>
                <option value="creation-compte">Création d'un nouveau compte</option>
                <option value="question-evenement">Question à propos d’un évènement</option>
                <option value="adherent">Vous êtes un adhèrent</option>
                <option value="autre">Autre...</option>
             
            </select>
            <div class="esp">  </div>
            <div class="espace"></div>
            <div class="espace"></div>
      
    
            <label for="message">Votre message :</label>
        
            <textarea id="message" name="message" placeholder="Bonjour, je vous contacte car...." required 
            value="<?php if (
isset($_POST['message'])) echo htmlspecialchars($_POST['message']);?>"> </textarea>

<div class="esp"> </div>
            <div class="espace"></div>
            <div class="espace"></div>
            <div class="espace"></div>
       
       
        
            <button type="submit">Envoyer mon message</button>

            <div class="esp">
            <div class="espace"></div>
       
        <div class="bigEspace"></div> 
    </form>


    <?php

ini_set("SMTP","localhost");
ini_set("smtp_port","1025");

if(isset($_POST['email'])) {
 
    //eDIT THE 2 LINES BELOW AS REQUIRED
   $email_to = "moktar.terki@gmail.com";
   $email_subject = "Contact site ";
}
   function died($error) {
       // your error code can go here
//        echo 
// "Nous sommes désolés, mais des erreurs ont été détectées dans le" .
// " formulaire que vous avez envoyé. ";
//        echo "Ces erreurs apparaissent ci-dessous.<br /><br />";
//        echo $error."<br /><br />";
    // echo "Merci de corriger ces erreurs.<br /><br />";
       die();
   }


   // si la validation des données attendues existe
    if(!isset($_POST['nom']) ||
       !isset($_POST['prenom']) ||
       !isset($_POST['email']) ||
       !isset($_POST['telephone']) ||
       !isset($_POST['situationProfessionnelle']) ||
       !isset($_POST['sujet']) ||
       !isset($_POST['message'])) 
       {
       died(
'Nous sommes désolés, mais le formulaire que vous avez soumis semble poser
problème.');
   }

    

   $nom = $_POST['nom'];  //required
   $prenom = $_POST['prenom']; //required
   $email = $_POST['email']; // required
   $telephone = $_POST['telephone']; // required
   $situationProfessionnelle = $_POST['situationProfessionnelle']; //  required
   $sujet = $_POST['sujet']; // required
   $message = $_POST['message']; // required

   $error_message = "";
   $email_exp = '/^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}$/';

   if(!preg_match($email_exp,$email)) {
     $error_message .= 
'L\'adresse e-mail que vous avez entrée ne semble pas être valide.<br />';
   }
  
     // Prend les caractères alphanumériques + le point et le tiret 6
     $string_exp = "/^[A-Za-z0-9 .'-]+$/";
  
   if(!preg_match($string_exp,$nom)) {
     $error_message .= 
'Le nom que vous avez entré ne semble pas être valide.<br />';
   }
  
   if(!preg_match($string_exp,$prenom)) {
     $error_message .= 
'Le prénom que vous avez entré ne semble pas être valide.<br />';
   }
  
   if(strlen($message) < 2) {
     $error_message .= 
'Le message que vous avez entré ne semble pas être valide.<br />';
   }
  
   if(strlen($error_message) > 0) {
     died($error_message);
   }

   $email_message = "Détail.\n\n";
   $email_message .= "Nom: ".$nom."\n";
   $email_message .= "Prenom: ".$prenom."\n";
   $email_message .= "Email: ".$email."\n";
   $email_message .= "Telephone: ".$telephone."\n";
   $email_message .= "Situation Professionnelle: ".$situationProfessionnelle."\n";
//    $email_message .= "Sujet: ".$Sujet."\n";
   $email_message .= "Message: ".$message."\n";



   // create email headers
   $headers = 'From: '.$email."\r\n".
   'Reply-To: '.$email."\r\n" .
   'X-Mailer: PHP/' . phpversion();
   mail($email_to, $email_subject, $email_message, $headers);



?>

    
 <!-- mettez ici votre propre message de succès en html -->
 Merci de nous avoir contacter. Nous vous contacterons très bientôt

</div>
</div>
</div>
</div>
<div class="bigEspace"></div>



</body>