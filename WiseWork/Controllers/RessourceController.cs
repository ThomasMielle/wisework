using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using TestWebApi.Controllers.Ressources;

namespace TestWebApi.Controllers
{
    public class RessourceController : ApiController
    {
        [HttpGet]
        public List<Utilisateur> getUtilisateur()
        {
            Ressources.Ressources.initialiseData();
            return Ressources.Ressources.listUtilisateur;
        }

        public bool initData()
        {
            try
            {
                Ressources.Ressources.initialiseData();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
