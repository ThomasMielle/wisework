﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class SalonController : ApiController
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Public
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpGet]
        public List<Salon> getAllSalon() 
        {
            Ressources.initialiseData();
            return Ressources.listSalon;
        }

        public List<Message> getAllMessage()
        {
            Ressources.initialiseData();
            return Ressources.listSalon.ElementAt(0).ListMessage;
        }
    }
}
