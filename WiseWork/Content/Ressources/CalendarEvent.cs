using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiseWork.Content.Ressources;

namespace WiseWork.Content.Ressources
{
    public class CalendarEvent
    {

        public string DateDebut { get; set; }

        public string HeureDebut { get; set; }

        public string HeureFin { get; set; }

        public string TitreRdv { get; set; }

        public Utilisateur User { get; set; }

        private List<Utilisateur> Invites { get; set; }

        

    }
}