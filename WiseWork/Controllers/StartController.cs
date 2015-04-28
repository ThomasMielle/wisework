using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class StartController : ApiController
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Public
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public bool initialise()
        {
            try
            {
                Ressources.initialiseData();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
