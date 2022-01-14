// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//fonction qui grise le fond d'un élément lorsqu'on le séléctionne
function select(id) {

    var site = document.getElementById(id);
    //si le fond de l'élément cliqué est blanc, rendre le fond de tous les autres éléments blanc(afin de ne jamais séléctionner deux lignes en même temps).
    if (site.style.backgroundColor !== 'dimgrey') {
        var liste = document.getElementsByTagName('li');

        var taille = liste.length;
        for (i = 0; i < taille; i++) {

            var test = document.getElementById(i + 1);


            if (test != null) {
                console.log(test);
                test.style.backgroundColor = 'white';
                test.style.color = 'black';
            }
        }
    }
    //rendre le fond gris au clic et blanc si on clique une deuxième fois dessus
    if (site.style.backgroundColor == 'dimgrey') {
        site.style.backgroundColor = 'white';
        site.style.color = 'black';
    } else {
        site.style.backgroundColor = 'dimgrey';
        site.style.color = 'white';
    }

}



//fonction qui envoie le formulaire de modification lorsque l'on clique sur modifier
function modifier() {
    var liste = document.getElementsByTagName('li');
    var taille = liste.length;
    for (i = 0; i < taille; i++) {
        if (document.getElementById(i + 1).style.backgroundColor == "dimgrey") {
            //Envoyer une requete post avec le nom de la ville et l'id séléctionnées vers le controller site methode add
            const input = document.createElement('input');
            input.type = 'hidden';
            input.name = 'ville';
            input.value = document.getElementById(i + 1).textContent;
            document.getElementById('form').appendChild(input);
            const inputId = document.createElement('input');
            inputId.type = 'hidden';
            inputId.name = 'id';
            inputId.value = document.getElementById(i + 1).id;
            document.getElementById('form').appendChild(inputId);
            document.getElementById('form').submit();
        };

    }
}
