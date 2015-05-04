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
        private string nom, prenom, login, password, urlImg,emailGoogle, poste, bureau, batiment, telephone, description;
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
            this.poste = "";
            this.bureau = "";
            this.batiment = "";
            this.telephone = "";
            this.description = "";
            this.listFollower = new List<Ids>();
        }
        public Utilisateur(int id, string nom, string prenom, string login, string password, string urlImg, string emailGoogle, string poste, string bureau, string batiment, string tel, string desc)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
            this.urlImg = urlImg;
            this.poste = poste;
            this.bureau = bureau;
            this.batiment = batiment;
            this.telephone = tel;
            this.description = desc;
            this.emailGoogle = emailGoogle;

            this.listFollower = new List<Ids>();
        }
        public Utilisateur(int id, string nom, string prenom, string login, string password,string urlImg, string emailGoogle)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.password = password;
            this.poste = "";
            this.bureau = "";
            this.batiment = "";
            this.telephone = "";
            this.description = "";
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

        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }

        public string Bureau
        {
            get { return bureau; }
            set { bureau = value; }
        }

        public string Batiment
        {
            get { return batiment; }
            set { batiment = value; }
        }

        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
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
