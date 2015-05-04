using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiseWork.Content.Ressources
{
    public class RessourcesSimon
    {
        static RessourcesSimon()
        {
            initData();
        }

        public static List<Utilisateur> listUtilisateur { get; set; }
        public static List<SalonUtilisateur> listSalonUtilisateur { get; set; }
        public static List<Salon> listSalon { get; set; }
        public static readonly string TAG_DRIVE = "Drive";
        public static readonly string TAG_RDV = "Rdv";
        public static readonly string TAG_JOUR_SEPARATEUR = "JourSeparateur";
        public static readonly string TAG_CHAT = "Chat";

        public static void initData()
        {
            listUtilisateur = new List<Utilisateur>();
            listSalonUtilisateur = new List<SalonUtilisateur>();
            listSalon = new List<Salon>();

            listUtilisateur.Add(new Utilisateur(1, "Random", "Person", "prandom", "pass", "img/profilLogo.jpg", "bah.founet@gmail.com", "Infographiste", "B1-12", "batiment blériot", "01 30 52 48 64", "J'aime le café"));
            listUtilisateur.Add(new Utilisateur(2, "Croft", "Lara", "lcroft", "pass", "img/photo_profil/profil9.jpg", "bah.founet@gmail.com", "Archeologue", "B1-12", "batiment blériot", "01 30 52 53 63", "Mon père il s'est fait tuer, je vais trouver les méchants"));
            listUtilisateur.Add(new Utilisateur(3, "Man", "Bat", "bman", "pass", "img/photo_profil/profil5.jpg", "bah.founet@gmail.com", "Billionaire playboy", "B1-12", "batiment blériot", "01 30 40 48 63", "Je ne suis pas en couple avec robin !"));
            listUtilisateur.Add(new Utilisateur(4, "Le Gris", "Gandalf", "glegris", "pass", "img/photo_profil/profil1.jpg", "bah.founet@gmail.com", "Magicien", "B1-12", "batiment blériot", "01 30 26 48 63", "Je fume la pipe"));
            listUtilisateur.Add(new Utilisateur(5, "Monkey D.", "Luffy", "lmonkeyd", "pass", "img/photo_profil/profil3.jpg", "bah.founet@gmail.com", "Imbécile Elastique", "B1-12", "batiment blériot", "01 30 52 48 63", "Je veux trouver le One Piece !"));

            listSalonUtilisateur.Add(new SalonUtilisateur(1, listUtilisateur.ElementAt(0).getId.Nom));
            listSalonUtilisateur.Add(new SalonUtilisateur(2, listUtilisateur.ElementAt(1).getId.Nom));
            listSalonUtilisateur.Add(new SalonUtilisateur(3, listUtilisateur.ElementAt(2).getId.Nom));
            listSalonUtilisateur.Add(new SalonUtilisateur(4, listUtilisateur.ElementAt(3).getId.Nom));
            listSalonUtilisateur.Add(new SalonUtilisateur(5, listUtilisateur.ElementAt(4).getId.Nom));

            listSalonUtilisateur.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1), "Salut, tu aurais un moment dans la journée de libre afin qu'on prenne 5 minutes pour faire le point ?",
                new DateTime(2015, 3, 20, 8, 16, 0), TAG_CHAT);
            listSalonUtilisateur.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(0), "Salut, j'ai une réunion de 11h à midi, nous pouvons donc nous voir avant qu'on parte déjeuner",
                new DateTime(2015, 3, 20, 8, 33, 0), TAG_CHAT);

            listSalonUtilisateur.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1), "Un article sympa sur sur les pour et les contres de Bootstrap : http://www.enguerranweiss.fr/bootstrap-nest-pas-na-jamais-ete-indispensable/",
                new DateTime(2015, 3, 20, 8, 16, 0));

            listSalonUtilisateur.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1), "Hey, j'ai vu ça sur internet j'ai pensé a toi : http://9gag.com/gag/ay0v8LV",
                new DateTime(2015, 3, 22, 15, 25, 0), TAG_CHAT);
            listSalonUtilisateur.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(0), "Je l'adoooooooore ! x)",
                new DateTime(2015, 3, 22, 15, 30, 0), TAG_CHAT);
            listSalonUtilisateur.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(0), "Tu comptes partir vers quelle heure ce soir ?",
                new DateTime(2015, 3, 22, 15, 31, 0), TAG_CHAT);
            listSalonUtilisateur.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1), "Autour de 19h je pense, tu veux faire quelque chose après ?",
                new DateTime(2015, 3, 22, 16, 01, 0), TAG_CHAT);
            listSalonUtilisateur.ElementAt(1).ajouterMessage(listUtilisateur.ElementAt(0), "Je me boirai bien un vers chez Julien, le bistro en bas de chez moi, ça te tente ?",
                new DateTime(2015, 3, 22, 16, 02, 0), TAG_CHAT);
            listSalonUtilisateur.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1), "Ca marche pour moi, on se tient au courant pour l'heure !",
                new DateTime(2015, 3, 22, 16, 05, 0), TAG_CHAT);

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
            listSalon.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(2),
                "Je te conseille de regarder ce que j'avais déjà fait, j'avais avancé sur les barres de menus",
                new DateTime(2015, 1, 2, 10, 13, 0), true);
            listSalon.ElementAt(0).ajouterMessage(listUtilisateur.ElementAt(1),
                "Merci à vous deux, je devrais finir d'ici de soir, j'attends un retour de votre part",
                new DateTime(2015, 1, 2, 10, 34, 0), false);
            var listIdUtilisateurSalon = new List<Ids>();
            listIdUtilisateurSalon.Add(listUtilisateur.ElementAt(0).getId);
            listIdUtilisateurSalon.Add(listUtilisateur.ElementAt(1).getId);
            listIdUtilisateurSalon.Add(listUtilisateur.ElementAt(2).getId);

            listSalon.ElementAt(0).ListIdUtilisateur = listIdUtilisateurSalon;

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
            var listIdUtilisateurSalon1 = new List<Ids>();
            listIdUtilisateurSalon1.Add(listUtilisateur.ElementAt(4).getId);
            listIdUtilisateurSalon1.Add(listUtilisateur.ElementAt(3).getId);

            listSalon.ElementAt(1).ListIdUtilisateur = listIdUtilisateurSalon1;

            // AngularJS
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(2),
                "Je bite rien !",
                new DateTime(2015, 1, 2, 10, 5, 0), true);
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(4),
                "Moi non plus faut demander a Nami elle comprendra peut-être !!!!",
                new DateTime(2015, 1, 2, 10, 8, 0), false);
            listSalon.ElementAt(2).ajouterMessage(listUtilisateur.ElementAt(3),
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
            var listUtilisateurSalon2 = new List<Ids>();
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(1).getId);
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(2).getId);
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(3).getId);
            listUtilisateurSalon2.Add(listUtilisateur.ElementAt(4).getId);

            listSalon.ElementAt(2).ListIdUtilisateur = listUtilisateurSalon2;
        }

        public List<Ids> getIdSalons()
        {
            var li = new List<Ids>();
            foreach (Salon salon in listSalon)
            {
                li.Add(salon.getId);
            }
            return li;
        }
        public List<Ids> getIdUtilisateur()
        {
            var li = new List<Ids>();
            foreach (Utilisateur user in listUtilisateur)
            {
                li.Add(user.getId);
            }
            return li;
        }
    }
}