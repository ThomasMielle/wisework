using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiseWork.Content.Ressources
{
    public class SalonUtilisateur
    {
        public List<Message> ListMessage { get; set; }
        public int Id { get; set; }
        public List<Ids> ListFollower { get; set; }
        private int idMessage;
        private string Nom { get; set; }

        public SalonUtilisateur(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
            this.ListFollower = new List<Ids>();
            this.ListMessage = new List<Message>();
            this.idMessage = 0;
        }

        public Ids getId
        {
            get { return new Ids(Id, Nom); }
        }

        public void ajouterMessage(Utilisateur auteur, string chaine)
        {
            ajouterSeparateurJour(DateTime.Now);
            ListMessage.Add(new Message(idMessage++, auteur, chaine, DateTime.Now));
        }
        public void ajouterMessage(Utilisateur auteur, string chaine, DateTime date)
        {
            ajouterSeparateurJour(date);
            ListMessage.Add(new Message(idMessage++, auteur, chaine, date));
        }
        public void ajouterMessage(Utilisateur auteur, string chaine, DateTime date, string tag)
        {
            ajouterSeparateurJour(date);
            ListMessage.Add(new Message(idMessage++, auteur, chaine, date, tag));
        }
        public void ajouterMessage(Utilisateur auteur, string chaine, DateTime date, Boolean important)
        {
            ajouterSeparateurJour(date);
            ListMessage.Add(new Message(idMessage++, auteur, chaine, date, important));
        }

        private void ajouterSeparateurJour(DateTime date)
        {
            if (ListMessage.Count == 0 || date.DayOfYear > ListMessage.ElementAt(ListMessage.Count - 1).Date.DayOfYear)
            {
                ListMessage.Add(new Message(-1, null,
                    date.DayOfWeek + " " + date.Day + " " + month(date.Month) + " " + date.Year,
                    new DateTime(date.Year, date.Month, date.Day), RessourcesSimon.TAG_JOUR_SEPARATEUR));
            }
        }
        private string month(int month)
        {
            switch (month)
            {
                case 1: return "janvier";
                case 2: return "février";
                case 3: return "mars";
                case 4: return "avril";
                case 5: return "mai";
                case 6: return "juin";
                case 7: return "juillet";
                case 8: return "août";
                case 9: return "septembre";
                case 10: return "octobre";
                case 11: return "novembre";
                case 12: return "décembre";
                default: return "mois non-existant";
            }
        }
    }
}