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
        public Identifiant verifIdentifiant(Identifiant identifiant)
        {
            Ressources.initialiseData();

            if (identifiant == null)
                throw new ArgumentException("identifiant ne doit pas être null");

            if (!verifLogin(identifiant))
                throw new ArgumentException("Identifiant incorrect");

            if (!verifPassword(identifiant))
                throw new ArgumentException("Le couple Login/Password est incorrect");

            //TODO: Encapsuler l'accès au Ressources dans un Service
            return Ressources.listIdentifiant.First();            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Private
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool verifLogin(Identifiant identifiant)
        {
            foreach (Identifiant identite in Ressources.listIdentifiant)
            {
                if (identifiant.Login == identite.Login)
                    return true;
            }

            return false;
        }

        private bool verifPassword(Identifiant identifiant)
        {
            foreach (Identifiant identite in Ressources.listIdentifiant)
            {
                if (identifiant.Password == identite.Password)
                    return true;
            }

            return false;
        }
    }
}
