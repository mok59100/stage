
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


				
				