using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApi.Controllers.Ressources
{
    public class Publication
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Variables
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private Utilisateur auteur;
        private DateTime dateHeurePublication;
        private Projet projet;

        private string message, tag;

        private List<Commentaire> commentaires;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Constructeurs
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Publication(Utilisateur auteur, DateTime dateHeurePublication, Projet projet, string message, string tag)
        {
            initialise();

            this.auteur = auteur;
            this.dateHeurePublication = dateHeurePublication;
            this.projet = projet;
            this.message = message;
            this.tag = tag;
            this.commentaires = new List<Commentaire>();            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Initialise
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void initialise()
        {
            this.auteur = new Utilisateur();
            this.dateHeurePublication = new DateTime();
            this.projet = new Projet();
            this.message = null;
            this.tag = null;
            this.commentaires = new List<Commentaire>();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Methodes
        ////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
