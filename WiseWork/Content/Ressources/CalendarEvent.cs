using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WiseWork.Content.Ressources;

namespace WiseWork.Content.Ressources
{
    public class CalendarEvent
    {
        private string dateDebut, heureDebut, heureFin, titreRdv;
        private string userEmail;
        private List<Utilisateur>invites;
        public string DateDebut
        { 
            get {return dateDebut;}
            set { dateDebut = value; }
        }

        public string HeureDebut 
        {
            get { return heureDebut; }
            set { heureDebut = value; } 
        }

        public string HeureFin 
        {
            get { return heureFin; }
            set { heureFin = value; }
        }

        public List<Utilisateur> Invites 
        {
            get { return invites; }
        }

        public string TitreRdv 
        {
            get { return titreRdv; }
            set { titreRdv = value; }
        
        }

        public string UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }


    }
}