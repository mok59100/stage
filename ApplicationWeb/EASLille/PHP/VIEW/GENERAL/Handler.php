<?php

/**
 * Connexion simple à la base de données via PDO !
 */
$db = new PDO('mysql:host=localhost;dbname=easlille;charset=utf8', 'root', '', [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION, 
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC
]);

/**
 * On doit analyser la demande faite via l'URL (GET) afin de déterminer si on souhaite récupérer les messages ou en écrire un
 */
$task = "list";// on creer une tache par defaut et on va l'appeler list

if(array_key_exists("task", $_GET)){ //si dans mon tableau get j'ai une cle qui s'appelle task
  $task = $_GET['task'];//tu prend dans le get la task preciser
}

if($task == "write"){ //si la task = write 
  postMessage();//fonction post message
} else { // sinon fonction get message
  getMessages();
}

/**
 * Si on veut récupérer, il faut envoyer du JSON
 */
function getMessages(){ //function get message
  global $db;// pour dire que la function est defini a l'exterieur

  // 1. On requête la base de données pour sortir les 20 derniers messages
  $resultats = $db->query("SELECT * FROM messages ORDER BY create_at DESC LIMIT 20"); //resultat = (db)la base de donnee  
  //et je fais un requete selectionne toute les donnees par descendant par contre je les limit a 20 par ordre descendant
  // 2. On traite les résultats
  $messages = $resultats->fetchAll();// fetchAll recuprere toute les lignes de donnees et me les renvoyer sous forme de tableau dans la variable message
  // 3. On affiche les données sous forme de JSON
  echo json_encode($messages);
}
/**
 * Si on veut écrire au contraire, il faut analyser les paramètres envoyés en POST et les sauver dans la base de données
 */
function postMessage(){
  global $db;
  // 1. Analyser les paramètres passés en POST (auteur, contenu)
  
  if(!array_key_exists('auteur', $_POST) || !array_key_exists('contenu', $_POST)){

    echo json_encode(["status" => "error", "message" => "One field or many have not been sent"]);
    return;

  }

  $auteur = $_POST['auteur'];
  $contenu = $_POST['contenu'];

  // 2. Créer une requête qui permettra d'insérer ces données
  $query = $db->prepare('INSERT INTO messages SET auteur = :auteur, contenu = :contenu, create_at = NOW()');

  $query->execute([
    "auteur" => $auteur,
    "contenu" => $contenu
  ]);

  // 3. Donner un statut de succes ou d'erreur au format JSON
  echo json_encode(["status" => "success"]);
}
/**
 * Voilà c'est tout en gros.
 */