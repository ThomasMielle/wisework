using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseWork.Content.Ressources
{
    public class Utilisateur
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Variables
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private int id;
        private string nom, prenom, login, password, urlImg,emailGoogle;
        private List<Ids> listFollower;
        
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Constructeurs
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Utilisateur(int id, string nom, string prenom, string login, string password)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
            this.listFollower = new List<Ids>();
        }
        public Utilisateur(int id, string nom, string prenom, string login, string password, string urlImg)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
            this.urlImg = urlImg;

            this.listFollower = new List<Ids>();
        }
        public Utilisateur(int id, string nom, string prenom, string login, string password,string urlImg, string emailGoogle)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
            this.urlImg = urlImg;
            this.emailGoogle = emailGoogle;
            this.listFollower = new List<Ids>();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Initialise
        ////////////////////////////////////////////////////////////////////////////////////////////////////



        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Proprietes
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string UrlImg
        {
            get { return urlImg; }
            set { urlImg = value; }
        }
        public int Id
        {
            get { return id; }
        }

        public string EmailGoogle
        {
            get { return emailGoogle; }
            set { emailGoogle = value; }
        }

        public Ids getId
        {
            get { return new Ids(id, prenom + " " + nom); }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Methodes
        ////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
