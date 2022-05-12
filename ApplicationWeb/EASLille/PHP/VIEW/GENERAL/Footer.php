
</div>


<div class ="bigEspace"></div>
<footer Class="background ">
<div class= "colonne center"> 
    <div>EST AFRIQUE SPORT DE LILLE</div>
    <div>Adresse : 27 rue Jean Bart 59000 Lille</div>
    <div>Réalisé par Moktar Terki</div>
    </div>
   </footer>
<?php
//  if($page[1]="FormImages") echo ' <script src="./JS/FormImages.js"></script>';
// if($page[1]="FormVideos") echo ' <script src="./JS/FormVideos.js"></script>';
 if (substr($page[1],0,4)=="Form"){
    echo ' <script src="./JS/VerifForm.js"></script>';
 }
 echo ' <script src="./JS/script.js"></script>';
// echo' <script src="./JS/app.js"></script>';
echo '</body>
</html>';