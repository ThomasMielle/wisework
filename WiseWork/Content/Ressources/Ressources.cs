using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebApi.Controllers.Ressources
{
    public class Ressources
    {
        private enum Tag
        {
            Aucun, Banal, Regulier, Important, Critique
        };

        public static void initialiseData()
        {
            listUtilisateur.Clear();
            listSalon.Clear();
            listProjet.Clear();
            listPublication.Clear();
            listCommentaire.Clear();

            initUtilisateur();
            initSalon();
            initProjet();
            initPublication();
            initCommentaire();
        } 

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Utilisateur
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Utilisateur> listUtilisateur = new List<Utilisateur>();

        private static void initUtilisateur()
        {
            listUtilisateur.Add(new Utilisateur("Alves", "Danny", 24));
            listUtilisateur.Add(new Utilisateur("Dupond", "Martin", 45));
            listUtilisateur.Add(new Utilisateur("Bernard", "Jean", 41));
            listUtilisateur.Add(new Utilisateur("Leprovost", "Laurent", 36));
            listUtilisateur.Add(new Utilisateur("Souadji", "Mohamed", 28));
            listUtilisateur.Add(new Utilisateur("Hego", "Heather", 26));
            listUtilisateur.Add(new Utilisateur("Olhagaray", "Jordan", 22));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Salon
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Salon> listSalon = new List<Salon>();

        private static void initSalon()
        {
            listSalon.Add(new Salon("Salon Titan"));
            listSalon.Add(new Salon("Salon Zora"));
            listSalon.Add(new Salon("Salon Greener"));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Projet
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Projet> listProjet = new List<Projet>();

        private static void initProjet()
        {
            List<Utilisateur> listTempUser = new List<Utilisateur>();

            // Projet Titan
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(1));
            listTempUser.Add(listUtilisateur.ElementAt(2));

            listProjet.Add(new Projet("Titan", listTempUser));

            // Projet Zora
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(3));
            listTempUser.Add(listUtilisateur.ElementAt(4));

            listProjet.Add(new Projet("Zora", listTempUser));

            // Projet Greener
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(5));

            listProjet.Add(new Projet("Greener", listTempUser));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Publication
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Publication> listPublication = new List<Publication>();

        private static void initPublication()
        {
            Publication publi = new Publication(
                listUtilisateur.ElementAt(0),
                new DateTime(2015, 1, 10, 14, 10, 0),
                listProjet.ElementAt(0),
                "Le projet démarre le 15 janvier.",
                Tag.Regulier.ToString());

            listPublication.Add(publi);

            //////////////////////////////////////////////////

            publi = new Publication(
                listUtilisateur.ElementAt(1),
                new DateTime(2015, 1, 11, 10, 23, 0),
                listProjet.ElementAt(0),
                "Je crois qu'il y a eu un problème avec l'import des decuments sur le serveur, à régler de tout urgence.",
                Tag.Important.ToString());

            listPublication.Add(publi);

            //////////////////////////////////////////////////
            //////////////////////////////////////////////////

            publi = new Publication(
                listUtilisateur.ElementAt(3),
                new DateTime(2015, 1, 9, 11, 3, 0),
                listProjet.ElementAt(1),
                "Les classes pour la gestion des ressources SQL sont terminées, je les importe dans la journée.",
                Tag.Banal.ToString());

            listPublication.Add(publi);

            //////////////////////////////////////////////////

            publi = new Publication(
                listUtilisateur.ElementAt(3),
                new DateTime(2015, 1, 10, 10, 33, 0),
                listProjet.ElementAt(1),
                "La doc sur les classes de gestion SQL sont à jour, je viens de les upload.",
                Tag.Banal.ToString());

            listPublication.Add(publi);

            //////////////////////////////////////////////////
            //////////////////////////////////////////////////

            publi = new Publication(
                listUtilisateur.ElementAt(5),
                new DateTime(2015, 2, 2, 9, 53, 0),
                listProjet.ElementAt(2),
                "OK, gros problème le serveur a crash il y a tous juste 5 minutes, je le relance mais stoper les requetes pour 10 - 15 minutes.",
                Tag.Critique.ToString());

            listPublication.Add(publi);

            //////////////////////////////////////////////////

            publi = new Publication(
                listUtilisateur.ElementAt(0),
                new DateTime(2015, 2, 13, 11, 0, 0),
                listProjet.ElementAt(2),
                "Le crash serveur du 2 Février n'est absolument pas normal, réunion demain à 10 heure, vos agenda sont à jour.",
                Tag.Important.ToString());

            listPublication.Add(publi);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Commentaire
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Commentaire> listCommentaire = new List<Commentaire>();

        private static void initCommentaire()
        {
            Commentaire comm = new Commentaire(
                listUtilisateur.ElementAt(0),
                new DateTime(2015, 1, 11, 10, 30, 0),
                "Exact, je les reupload correctement de suite, merci.");
        }
    }
}
