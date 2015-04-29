using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseWork.Content.Ressources
{
    public class Salon
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Variables
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private int id;
        private string nom;
        private List<Utilisateur> listUtilisateur;
        private List<Message> listMessage;
        private int idMessage;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Constructeurs
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Salon(int id, string nom)
        {
            this.id = id;
            this.nom = nom;

            this.listUtilisateur = new List<Utilisateur>();
            this.listMessage = new List<Message>();
            this.idMessage = 0;
        }

        public Salon(int id, string nom, List<Utilisateur> users, List<Message> listMessage)
        {
            this.id = id; this.nom = nom; this.listUtilisateur = users; this.listMessage = listMessage;
            this.idMessage = 0;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Initialise
        ////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Proprietes
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public List<Utilisateur> ListUtilisateur
        {
            get { return listUtilisateur; }
            set { listUtilisateur = value; }
        }

        public List<Message> ListMessage
        {
            get { return listMessage; }
            set { listMessage = value; }
        }
        public string Nom { get { return nom; } set { nom = value; } }
        public int Id { get { return id; } set { id = value; } }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Methodes
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public void ajouterMessage(Utilisateur auteur, string chaine)
        {
            ajouterSeparateurJour(DateTime.Now);
            listMessage.Add(new Message(idMessage++, auteur, chaine, DateTime.Now));
        }
        public void ajouterMessage(Utilisateur auteur, string chaine, DateTime date)
        {
            ajouterSeparateurJour(date);
            listMessage.Add(new Message(idMessage++, auteur, chaine, date));
        }
        public void ajouterMessage(Utilisateur auteur, string chaine, DateTime date, string tag)
        {
            ajouterSeparateurJour(date);
            listMessage.Add(new Message(idMessage++, auteur, chaine, date, tag));
        }
        public void ajouterMessage(Utilisateur auteur, string chaine, DateTime date, Boolean important)
        {
            ajouterSeparateurJour(date);
            listMessage.Add(new Message(idMessage++, auteur, chaine, date, important));
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
