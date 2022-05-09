<!DOCTYPE html>
<html lang="fr">
<head>
  <meta charset="UTF-8">
  <title>Notre super chat !</title>
  <link rel="stylesheet" href="css/app.css">
</head>
<body>
  <header>
    <h1>bienvenue dans le chat !</h1>
  </header>
  
  <section class="chat">
    <div class="messages">
      <div class="message">
        <span class="date">23:22</span>
        <span class="auteur">LIOR</span> :
        <span class="contenu">salut ca va</span><span class="date">23:22</span>
        
    
      </div>
    </div>
    <div class="user-inputs">
      <form action="handler.php?task=write" method="POST">
        <input type="text" name="auteur" id="auteur" placeholde="Pseudo ?">
        <input type="text" id="contenu" name="contenu" placeholder="Veuillez taper votre message ici !">
        <button type="submit">🔥 envoyer !</button>
      </form>
    </div>
</section>
  <script src="js/app.js"></script>
</body>
</html>