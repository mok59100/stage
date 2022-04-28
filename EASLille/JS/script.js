
// function download(file) {
  
//     //creating an invisible element
//     var element = document.createElement('a');
//     element.setAttribute('download');
  
//     // Above code is equivalent to
//     // <a href="path of file" download="file name">
  
//     document.body.appendChild(element);
  
//     //onClick property
//     element.click();
  
//     document.body.removeChild(element);
// }
  
// // Start file download.
// document.getElementById("btn")
// .addEventListener("click", function() {
   
   
   
  
//     download(file);
// }, false);



					
const download = document.getElementById("fileRequest");

download.addEventListener('click', request);

function request() {
    window.location = 'document.docx';
}


				// 			$(document).ready(function(){
				// 				//Première récupération des messages au chargement de la page
				// 				$.ajax({
				// 					url : "Recuperer.php",
				// 					type : "GET",
				// 					success : function(recup){
				// 						$("#ls_msg").append(recup);
				// 						tableauId = document.getElementsByClassName("msg");
				// 						//Dernier Id pour comparaison avec les nouveaux messages pour empêcher les doublons
				// 						lastId = document.getElementsByClassName("msg")[tableauId.length-1].id;
				// 						element = document.getElementById("conv");
				// 						element.scrollTop = element.scrollHeight;
				// 					}
				// 				});
				// 				//Routine de raffraichissement pour l'affichage des nouveaux messages
				// 				setInterval(function(){
				// 					$.ajax({
				// 						url : "recuperer.php",
				// 						type : "POST",
				// 						data : {lastId : lastId},
				// 						success : function(recup){
				// 							$("#ls_msg").append(recup);
				// 							tableauId = document.getElementsByClassName("msg");
				// 							lastId = document.getElementsByClassName("msg")[tableauId.length-1].id;
				// 							element = document.getElementById('conv');
				// 							element.scrollTop = element.scrollHeight;
				// 						}
				// 					});
				// 				},2000);
				// 			});
						
			
			
				// $(document).ready(function() {
				// 	//Envoi en cliquant sur le bouton Envoyer
				// 	$('#Envoyer').click(function() {
				// 		//Vérification que le champ Auteur est bien rempli
				// 		if($("#Auteur").val()==""){
				// 			alert("Veuillez renseigner vos nom et prénom");
				// 		}
				// 		//Vérification que le champ Message est bien rempli
				// 		else if($("#Message").val()==""){
				// 			alert("Vous ne pouvez pas envoyer de message vide");
				// 		}
				// 		//Envoi des données à la BDD
				// 		else {$.ajax({
				// 			url: "Enregistrer.php",
				// 			type: "GET",
				// 			data: {Auteur:$("#Auteur").val(), Message:$("#Message").val()},
							
				// 			success: function(requete){
				// 				$("#requete").html(requete);
				// 			}
				// 		})}
				// 		$("#Message").val('');
				// 	});
				// 	//Envoi en appuyant sur Entrée
				// 	$("#Message").keyup(function(objEvent){
				// 		if(objEvent.keyCode == 13){
				// 			$("#Envoyer").click();
				// 		}
				// 	});
				// });
				