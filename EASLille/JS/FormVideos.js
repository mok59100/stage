inputFile = document.querySelector("input[type=file]");
video= inputFile.parentNode.parentNode.querySelector("video")
if (inputFile!=undefined)
{
    inputFile.addEventListener("change", choixVideo);
}

function choixVideo(e) {
    if (inputFile.value.length > 0) {
        videoType = /^video\//;
        fichier = e.target.files[0];
        if (!videoType.test(fichier.type)) {
            alert("veuillez sélectionner une video");
            e.target.value = "";
        } else {
            video.file = fichier;
            reader = new FileReader();
            reader.addEventListener("load", chargeVideo);
            reader.readAsDataURL(video.file);
            // on crée un nouvel input pour dire qu'il y a modification
            modif = document.createElement("input");
            modif.name = "modifVideo";
            modif.type = "hidden";
            inputFile.parentNode.appendChild(modif);
        }
    }
}

function chargeVideo(e) {
    video.src = e.target.result;
}