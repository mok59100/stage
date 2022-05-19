<!DOCTYPE html>
<html lang="fr">
<head>
  <meta charset="UTF-8">
  <title> Tchat !</title>
<link rel="stylesheet" href="./CSS/app.css">

<!-- </head>
<body>
  <header>
    <h1></h1>
  </header> -->
  
  <!-- <section class="chat"> -->
    <div class="row">
      <div></div> 
      <div class="messages">
      
      </div> 
      <div></div> 
      </div> 
    <div class="user-inputs">
      <form action="Handler.php?task=write" method="POST">
        <div class="row">
        <input type="text" name="auteur" id="auteur" placeholder="Pseudo ">
        <input type="text" id="contenu" name="contenu" placeholder=" Message">
        </div>
        <button type="submit">🔥 envoyer !</button>
      </form>
    </div>
</section>
  <script src="./JS/app.js"></script>
</body>
</html>