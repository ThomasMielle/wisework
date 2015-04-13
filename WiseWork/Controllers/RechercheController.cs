using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class RechercheController : ApiController
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Public
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        public List<string> recherche(Message chaineRechercher)
        {
            List<string> lstTemp = new List<string>();

            foreach (Utilisateur user in Ressources.listUtilisateur)
            {
                if (user.Nom.ToLower().Contains(chaineRechercher.Chaine.ToLower()) || user.Prenom.ToLower().Contains(chaineRechercher.Chaine.ToLower()))
                {
                    lstTemp.Add(user.Nom + " " + user.Prenom);
                }
            }

            foreach (Projet projet in Ressources.listProjet)
            {
                if (projet.Nom.ToLower().Contains(chaineRechercher.Chaine.ToLower()))
                {
                    lstTemp.Add(projet.Nom);
                }
            }

            return lstTemp;
        }
    }
}
