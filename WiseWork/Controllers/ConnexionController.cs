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
        public Utilisateur verifIdentifiant(Utilisateur identifiant)
        {

            if (identifiant == null)
                throw new ArgumentException("identifiant ne doit pas être null");

            if (!verifLogin(identifiant))
                throw new ArgumentException("Identifiant incorrect");

            if (!verifPassword(identifiant))
                throw new ArgumentException("Le couple Login/Password est incorrect");

            //TODO: Encapsuler l'accès au Ressources dans un Service
            return Ressources.listUtilisateur.First();            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Private
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool verifLogin(Utilisateur identifiant)
        {
            foreach (Utilisateur user in Ressources.listUtilisateur)
            {
                if (identifiant.Login == user.Login)
                    return true;
            }

            return false;
        }

        private bool verifPassword(Utilisateur identifiant)
        {
            foreach (Utilisateur user in Ressources.listUtilisateur)
            {
                if (identifiant.Password == user.Password)
                    return true;
            }

            return false;
        }
    }
}
