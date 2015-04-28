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
            //Ressources.initialiseData();
            //RessourcesSimon.initData();

            if (identifiant == null)
                throw new ArgumentException("identifiant ne doit pas être null");

            //if (!verifLogin(identifiant))
              //  throw new ArgumentException("Identifiant incorrect");

            Utilisateur user = verifPassword(identifiant) ;
            
            //if (User == null)
              //  throw new ArgumentException("Le couple Login/Password est incorrect");

            //TODO: Encapsuler l'accès au Ressources dans un Service
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
