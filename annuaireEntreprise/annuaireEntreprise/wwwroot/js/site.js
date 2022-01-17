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
function sendData(chemin,data) {
    var liste = document.getElementsByTagName('li');
    var taille = liste.length;
    for (i = 0; i < taille; i++) {
        //Eviter de séléctionner des éléments nulls dans la liste
        if (document.getElementById(i + 1) != null) {
            if (document.getElementById(i + 1).style.backgroundColor == "dimgrey") {
                //Envoyer une requete post avec le nom de la ville et l'id séléctionnées vers le controller site, methode add
                //changer la méthode si c'est sur le bouton supprimer que l'on a cliqué
               
                document.getElementById("form").action = chemin;
                
                const input = document.createElement('input');
                input.type = 'hidden';
                input.name = data;
                input.value = document.getElementById(i + 1).textContent;
                document.getElementById('form').appendChild(input);
                const inputId = document.createElement('input');
                inputId.type = 'hidden';
                inputId.name = 'id';

                inputId.value = document.getElementById(i + 1).id;
                

                document.getElementById('form').appendChild(inputId);
                document.getElementById('form').submit();
            };
        };

    };

}
//fonction qui envoie le formulaire de modification lorsque l'on clique sur modifierb spécifique à la page employées
function sendDataEmployees(methode) {
    var liste = document.getElementsByTagName('li');
    var taille = liste.length;
    for (i = 0; i < taille; i++) {
        var li = document.getElementById(i + 1);
        //Eviter de séléctionner des éléments nulls dans la liste
        if (li != null) {
            
            //prendre les informations uniqument dans l'élément séléctionné
            if (li.style.backgroundColor == "dimgrey") {
                console.log(li.childNodes[12].childNodes);

                document.getElementById("form").action = '/Employee/'+methode;

                const idEmployee = document.createElement('input');
                idEmployee.type = 'hidden';
                idEmployee.name = "idEmployee";
                idEmployee.value = li.id;
                document.getElementById('form').appendChild(idEmployee);

                const firstname = document.createElement('input');
                firstname.type = 'hidden';
                firstname.name = "firstname";
                firstname.value = li.childNodes[2].textContent;
                document.getElementById('form').appendChild(firstname);

                const lastname = document.createElement('input');
                lastname.type = 'hidden';
                lastname.name = "lastname";
                lastname.value = li.childNodes[6].textContent;
                document.getElementById('form').appendChild(lastname);

                const phone = document.createElement('input');
                phone.type = 'hidden';
                phone.name = "phone";
                phone.value = li.childNodes[12].childNodes[2].textContent;
                document.getElementById('form').appendChild(phone);

                const mobilePhone = document.createElement('input');
                mobilePhone.type = 'hidden';
                mobilePhone.name = "mobilePhone";
                mobilePhone.value = li.childNodes[12].childNodes[6].textContent;
                document.getElementById('form').appendChild(mobilePhone);

                const mail = document.createElement('input');
                mail.type = 'hidden';
                mail.name = "mail";
                mail.value = li.childNodes[12].childNodes[10].textContent;
                document.getElementById('form').appendChild(mail);

                const service = document.createElement('input');
                service.type = 'hidden';
                service.name = "service";
                service.value = li.childNodes[12].childNodes[14].textContent;
                document.getElementById('form').appendChild(service);

                const idservice = document.createElement('input');
                idservice.type = 'hidden';
                idservice.name = "idservice";
                idservice.value = li.childNodes[12].childNodes[14].id;
                document.getElementById('form').appendChild(idservice);

                const site = document.createElement('input');
                site.type = 'hidden';
                site.name = "site";
                site.value = li.childNodes[12].childNodes[18].textContent;
                document.getElementById('form').appendChild(site);

                const idsite = document.createElement('input');
                idsite.type = 'hidden';
                idsite.name = "idsite";
                idsite.value = li.childNodes[12].childNodes[18].id;
                document.getElementById('form').appendChild(idsite);

                document.getElementById('form').submit();
                //Envoyer une requete post avec le nom de la ville et l'id séléctionnées vers le controller site, methode add
                //changer la méthode si c'est sur le bouton supprimer que l'on a cliqué

            };
        };

    };

}
//fonction de menu déroulant sur la page des employés
function deroulant(id) {
    if (document.getElementById('informations+' + id).style.display === 'none') {
        document.getElementById('informations+' + id).style.display = 'block';
        document.getElementById('down').style.display = 'none';
        document.getElementById('up').style.display = 'block';
    } else {
        document.getElementById('informations+' + id).style.display = 'none';
        document.getElementById('down').style.display = 'block';
        document.getElementById('up').style.display = 'none';
    }
   
}
//Fonction pour la séléction dans la liste des services et sites sur la page de update et create pour les employés
function ChangeValue(element, id) {
    document.getElementById('id' + element).value = id;
}

function search() {
    let input = document.getElementById('searchbar').value
    input = input.toLowerCase();
    let x = document.getElementsByClassName('site');

    for (i = 0; i < x.length; i++) {
        if (!x[i].innerHTML.toLowerCase().includes(input)) {
            x[i].style.display = "none";
        }
        else {
            x[i].style.display = "block";
        }
    }
}
