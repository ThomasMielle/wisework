using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseWork.Content.Ressources
{
    public class Ressources
    {
        private enum Tag
        {
            Aucun, Banal, Regulier, Important, Critique
        };

        public static void initialiseData()
        {
            listIdentifiant.Clear();
            listUtilisateur.Clear();
            listSalon.Clear();
            listProjet.Clear();

            initIdentifiant();
            initUtilisateur();
            initSalon();
            initProjet();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Identifiant
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Identifiant> listIdentifiant = new List<Identifiant>();

        private static void initIdentifiant()
        {
            listIdentifiant.Add(new Identifiant("Alves", "Danny"));
            listIdentifiant.Add(new Identifiant("Dupond", "Martin"));
            listIdentifiant.Add(new Identifiant("Bernard", "Jean"));
            listIdentifiant.Add(new Identifiant("Leprovost", "Laurent"));
            listIdentifiant.Add(new Identifiant("Souadji", "Mohamed"));
            listIdentifiant.Add(new Identifiant("Hego", "Heather"));
            listIdentifiant.Add(new Identifiant("Olhagaray", "Jordan"));
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
            listSalon.Add(new Salon(0, "Titan"));
            listSalon.Add(new Salon(1, "Zora"));
            listSalon.Add(new Salon(2, "Greener"));
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

            listProjet.Add(new Projet(0, "Titan", listTempUser));

            // Projet Zora
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(3));
            listTempUser.Add(listUtilisateur.ElementAt(4));

            listProjet.Add(new Projet(1, "Zora", listTempUser));

            // Projet Greener
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(5));

            listProjet.Add(new Projet(2, "Greener", listTempUser));
        }
    }
}
