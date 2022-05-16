<!DOCTYPE html>
<html lang="fr">
<head>
  <meta charset="UTF-8">
  <title> Tchat !</title>
<link rel="stylesheet" href="./CSS/app.css">

</head>
<body>
  <header>
    <h1></h1>
  </header>
  
  <section class="chat">
    <div class="messages">
     
    </div>
    <div class="user-inputs">
      <form action="Handler.php?task=write" method="POST">
        <input type="text" name="auteur" id="auteur" placeholder=" Veuillez entrer votre pseudo ">
        <input type="text" id="contenu" name="contenu" placeholder=" Veuillez taper votre message ici !">
        <button type="submit">🔥 envoyer !</button>
      </form>
    </div>
</section>
  <script src="./JS/app.js"></script>
</body>
</html>