using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using annuaireEntreprise.Models;

namespace annuaireEntreprise.ViewModels
{
    //Cette classe permettra de passer deux paramètres à la vue update de employee
    public class ViewModelEmployee
    {
        public List<Site> listeSites { get; set; }
        public List<Service> listeServices { get; set; }
       
    }
}
