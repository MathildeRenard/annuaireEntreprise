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

            var li = document.getElementById(i + 1);

            //Eviter de séléctionner des éléments nulls dans la liste
            if (li != null) {
                li.style.backgroundColor = 'white';
                li.style.color = 'black';
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
function modifier(methode) {
    var liste = document.getElementsByTagName('li');
    var taille = liste.length;
    for (i = 0; i < taille; i++) {
        //Eviter de séléctionner des éléments nulls dans la liste
        if (document.getElementById(i + 1) != null) {
            if (document.getElementById(i + 1).style.backgroundColor == "dimgrey") {
                //Envoyer une requete post avec le nom de la ville et l'id séléctionnées vers le controller site, methode add
                //changer la méthode si c'est sur le bouton supprimer que l'on a cliqué
                if (methode != 1) {
                    document.getElementById("form").action = '/Site/Update';
                };
                const input = document.createElement('input');
                input.type = 'hidden';
                input.name = 'ville';
                input.value = document.getElementById(i + 1).textContent;
                document.getElementById('form').appendChild(input);
                const inputId = document.createElement('input');
                inputId.type = 'hidden';
                inputId.name = 'id';

                inputId.value = document.getElementById(i + 1).id;
                console.log(document.getElementById(i + 1));

                document.getElementById('form').appendChild(inputId);
                document.getElementById('form').submit();
            };
        };

    };
}
