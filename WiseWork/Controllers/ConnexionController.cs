using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class ConnexionController : ApiController
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Public
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        public Utilisateur verifIdentifiant(UtilisateurTest identifiant)
        {

            if (identifiant == null)
                throw new ArgumentException("identifiant ne doit pas être null");

            Utilisateur user = verifPassword(identifiant) ;
            
            return user;            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Private
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool verifLogin(UtilisateurTest identifiant)
        {
            foreach (Utilisateur user in RessourcesSimon.listUtilisateur)
            {
                if (identifiant.login == user.Login)
                    return true;
            }

            return false;
        }

        private Utilisateur verifPassword(UtilisateurTest identifiant)
        {
            foreach (Utilisateur user in RessourcesSimon.listUtilisateur)
            {
                if (identifiant.password == user.Password && identifiant.login == user.Login)
                    return user;
            }

            return null;
        }
    }
}
