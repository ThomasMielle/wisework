using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class UtilisateurController : ApiController
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Public
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public List<Utilisateur> getAllUser()
        {
            return RessourcesSimon.listUtilisateur;
        }

        [HttpPost]
        public Utilisateur modifUser(UtilisateurTest user)
        {
            for (int indice = 1; indice < RessourcesSimon.listUtilisateur.Count; indice++) {
                if (RessourcesSimon.listUtilisateur.ElementAt(indice).Id == user.id)
                {
                    if (user.nom != null && user.nom.Trim() != "")
                        RessourcesSimon.listUtilisateur.ElementAt(indice).Nom = user.nom;
                    if (user.prenom != null && user.prenom.Trim() != "")
                        RessourcesSimon.listUtilisateur.ElementAt(indice).Prenom = user.prenom;
                    if (user.login != null && user.login.Trim() != "")
                        RessourcesSimon.listUtilisateur.ElementAt(indice).Login = user.login;
                    if (user.password != null && user.password.Trim() != "")
                        RessourcesSimon.listUtilisateur.ElementAt(indice).Password = user.password;

                    return RessourcesSimon.listUtilisateur.ElementAt(indice);
                }
            }
            return null;
        }        
    }
}
