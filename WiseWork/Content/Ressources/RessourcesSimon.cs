using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiseWork.Content.Ressources
{
    public class RessourcesSimon
    {
        public static List<Utilisateur> listUtilisateur { get; set; }
        public static List<Salon> listSalon { get; set; }
        public static readonly string TAG_DRIVE = "Drive";
        public static readonly string TAG_RDV = "Rdv";
        public static readonly string TAG_JOUR_SEPARATEUR = "JourSeparateur";

        public static void initData()
        {
            listUtilisateur = new List<Utilisateur>();
            listSalon = new List<Salon>();

            listUtilisateur.Add(new Utilisateur(1, "Random", "Person", "prandom", "pass", "img/profilLogo.jpg"));
            listUtilisateur.Add(new Utilisateur(2, "Croft", "Lara", "lcroft", "pass", "img/photo_profil/profil9.jpg"));
            listUtilisateur.Add(new Utilisateur(3, "Man", "Bat", "mnintendo", "pass", "img/photo_profil/profil5.jpg"));
            listUtilisateur.Add(new Utilisateur(4, "Le Gris", "Gandalf", "glegris", "pass", "img/photo_profil/profil1.jpg"));
            listUtilisateur.Add(new Utilisateur(5, "Monkey D.", "Luffy", "lmonkeyd", "pass", "img/photo_profil/profil3.jpg"));

            listSalon.Add(new Salon(1, "Design"));
            listSalon.Add(new Salon(2, "Jeux video"));
            listSalon.Add(new Salon(3, "AngularJS"));

            // Design
            listSalon.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(0),
                "J'ai fini le design de la page d'acceuil de l'appli, je dépose ça dans 5 minutes après avoir tout mis au propre.",
                new DateTime(2015, 1, 2, 10, 5, 0));
            listSalon.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1),
                "Ok niquel, j'attends que tu le partage pour commencer le CSS",
                new DateTime(2015, 1, 2, 10, 8, 0));
            listSalon.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(0),
                "maquettes_projetTest_page_d_accueil",
                new DateTime(2015, 1, 2, 10, 12, 0), TAG_DRIVE);
            listSalon.ElementAt(0).ajouterMessage( listUtilisateur.ElementAt(2),
                "Je te conseille de regarder ce que j'avais déjà fait, j'avais avancé sur les barres de menus",
                new DateTime(2015, 1, 2, 10, 13, 0), true);
            listSalon.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1),
                "Merci à vous deux, je devrais finir d'ici de soir, j'attends un retour de votre part",
                new DateTime(2015, 1, 2, 10, 34, 0), false);
            var listUtilisateurSalon = new List<Utilisateur>();
            listUtilisateurSalon.Add(listUtilisateur.ElementAt(0));
            listUtilisateurSalon.Add(listUtilisateur.ElementAt(1));
            listUtilisateurSalon.Add(listUtilisateur.ElementAt(2));

            listSalon.ElementAt(0).ListUtilisateur = listUtilisateurSalon;

            // Jeux video
            listSalon.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(4),
                "Je vais trouver le ONE PIECE !!!!!",
                new DateTime(2015, 1, 2, 10, 5, 0));
            listSalon.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(4),
                "Quoiiiiiiiiiiiiiii ?!?! Mon bras s'allonge !!!!",
                new DateTime(2015, 1, 2, 10, 8, 0));
            listSalon.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(4),
                "J'ai faiiiiiiiiiiiiim !!!",
                new DateTime(2015, 1, 2, 10, 12, 0));
            listSalon.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(4),
                "Quand est-ce qu'on mange ?!",
                new DateTime(2015, 1, 2, 10, 13, 0), true);
            listSalon.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(3),
                "J'ai connu des Hobbit plutôt turbulants, mais tu décroches la palme alors arrete de spam !",
                new DateTime(2015, 1, 2, 10, 15, 0), false);
            var listUtilisateurSalon1 = new List<Utilisateur>();
            listUtilisateurSalon1.Add(listUtilisateur.ElementAt(4));
            listUtilisateurSalon1.Add(listUtilisateur.ElementAt(3));

            listSalon.ElementAt(1).ListUtilisateur = listUtilisateurSalon1;

            // AngularJS
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(2),
                "Je bite rien !",
                new DateTime(2015, 1, 2, 10, 5, 0), true);
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(4),
                "Moi non plus faut demander a Nami elle comprendra peut-être !!!!",
                new DateTime(2015, 1, 2, 10, 8, 0), false);
            listSalon.ElementAt(2).ajouterMessage( listUtilisateur.ElementAt(3),
                "Moi je comprends mais ce n'est pas une tache pour moi",
                new DateTime(2015, 1, 2, 10, 12, 0), false);
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(4),
                "Quand est-ce qu'on mange ?!",
                new DateTime(2015, 1, 2, 10, 13, 0), true);
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(2),
                "Et ben je suis aidé -.-",
                new DateTime(2015, 1, 2, 11, 07, 0));
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(2),
                "c'est bon j'ai réussi après avoir passé la nuit dessus !",
                new DateTime(2015, 1, 3, 8, 15, 0));
            var listUtilisateurSalon2 = new List<Utilisateur>();
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(1));
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(2));
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(3));
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(4));

            listSalon.ElementAt(2).ListUtilisateur = listUtilisateurSalon2;
        }
    }
}