using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiseWork.Content.Ressources
{
    public class Message
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Variables
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private int id;
        private Utilisateur auteur;
        private string chaine;
        private DateTime date;
        private Boolean important;
        private string tag;
        private string urlFichier;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Constructeurs
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        // pour un message avec un tag : / drive
        public Message(int id, Utilisateur auteur, string chaine, string url, DateTime date, string tag)
        {
            this.id = id;
            this.auteur = auteur;
            this.chaine = chaine;
            this.urlFichier = url;
            this.date = date;
            this.tag = tag;
            this.important = true;
        }
        // pour un message avec un tag : / rdv
        public Message(int id, Utilisateur auteur, string chaine, DateTime date, string tag)
        {
            this.id = id;
            this.auteur = auteur;
            this.chaine = chaine;
            //this.urlFichier = url;
            this.date = date;
            this.tag = tag;
            this.important = true;
        }

        // un message sans tag et sans importance précisée est initialisé à non-important
        public Message(int id, Utilisateur auteur, string chaine, DateTime date)
        {
            this.id = id;
            this.auteur = auteur;
            this.chaine = chaine;
            this.date = date;
            this.tag = "";
            this.important = false;
        }
        public Message(int id, Utilisateur auteur, string chaine, DateTime date, Boolean important)
        {
            this.id = id;
            this.auteur = auteur;
            this.chaine = chaine;
            this.date = date;
            this.tag = "";
            this.important = important;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Initialise
        ////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Proprietes
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public Utilisateur Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        public string Chaine
        {
            get { return chaine; }
            set { chaine = value; }
        }
        public string UrlFichier
        {
            get { return urlFichier; }
            set { urlFichier = value; }
        }
        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        public int Id { get { return id; } set { id = value; } }
        public Boolean Important { get { return important; } set { important = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Methodes
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Minute { get { return date.Minute.ToString("00"); } }
        public string Hour { get { return date.Hour.ToString("00"); } }
    }
}