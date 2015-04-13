using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class CommunicationController : ApiController
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //      Public
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        [HttpPost]
        public string getMessageEntrer(Message message)
        {
            return "Message : " + message.Chaine + " dans le salon : " + message.Salon;            
        }
    }
}
