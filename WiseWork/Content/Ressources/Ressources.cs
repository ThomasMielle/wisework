using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseWork.Content.Ressources
{
    public class Ressources
    {

        static Ressources()
        {
            initialiseData();
        }


        private static void initialiseData()
        {
            listUtilisateur.Clear();
            listSalon.Clear();

            initUtilisateur();
            initSalon();

            ajouteUtilisateur();
            ajouteMessage();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Identifiant
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Utilisateur> listUtilisateur = new List<Utilisateur>();

        private static void initUtilisateur()
        {
            listUtilisateur.Add(new Utilisateur(1, "Alves", "Danny", "alves.danny", "password"));
            listUtilisateur.Add(new Utilisateur(2, "Dupond", "Martin", "dupond.martin", "password"));
            listUtilisateur.Add(new Utilisateur(3, "Bernard", "Jean", "bernard.jean", "password"));
            listUtilisateur.Add(new Utilisateur(4, "Leprovost", "Laurent", "leprovost.laurent", "password"));
            listUtilisateur.Add(new Utilisateur(5, "Hego", "Heather", "hego.heather", "password"));            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Salon
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static List<Salon> listSalon = new List<Salon>();

        private static void initSalon()
        {
            listSalon.Add(new Salon(1, "Titan"));
            listSalon.Add(new Salon(2, "Zora"));
            listSalon.Add(new Salon(3, "Greener"));
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Ajoute Utilisateur
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private static void ajouteUtilisateur()
        {
            List<Utilisateur> listTempUser = new List<Utilisateur>();

            // Projet Titan
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(1));
            listTempUser.Add(listUtilisateur.ElementAt(2));

            listSalon.ElementAt(0).ListUtilisateur = listTempUser;
            listTempUser.Clear();

            // Projet Zora
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(2));
            listTempUser.Add(listUtilisateur.ElementAt(3));

            listSalon.ElementAt(1).ListUtilisateur = listTempUser;
            listTempUser.Clear();

            // Projet Greener
            listTempUser.Add(listUtilisateur.ElementAt(0));
            listTempUser.Add(listUtilisateur.ElementAt(4));

            listSalon.ElementAt(2).ListUtilisateur = listTempUser;
            listTempUser.Clear();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Ajoute Message
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private static void ajouteMessage()
        {
            List<Message> listTempMessage = new List<Message>();

            // Projet Titan
            listTempMessage.Add(new Message(0, listUtilisateur.ElementAt(0), "Message 1 dans salon 1 : Titan", new DateTime(2015, 1, 2, 10, 5, 0), "Pas important"));
            listTempMessage.Add(new Message(1, listUtilisateur.ElementAt(1), "Message 2 dans salon 1 : Titan", new DateTime(2015, 1, 2, 10, 15, 0), "Pas important"));
            listTempMessage.Add(new Message(2, listUtilisateur.ElementAt(2), "Message 3 dans salon 1 : Titan", new DateTime(2015, 1, 3, 9, 30, 0), "Pas important"));
            listTempMessage.Add(new Message(3, listUtilisateur.ElementAt(0), "Message 4 dans salon 1 : Titan", new DateTime(2015, 1, 4, 14, 26, 0), "Pas important"));

            listSalon.ElementAt(0).ListMessage = listTempMessage;

            // Projet Zora
            listTempMessage.Add(new Message(4, listUtilisateur.ElementAt(0), "Message 1 dans salon 2 : Zora", new DateTime(2014, 3, 10, 10, 56, 0), "Pas important"));
            listTempMessage.Add(new Message(5, listUtilisateur.ElementAt(1), "Message 2 dans salon 2 : Zora", new DateTime(2014, 3, 11, 17, 8, 0), "Pas important"));
            listTempMessage.Add(new Message(6, listUtilisateur.ElementAt(2), "Message 3 dans salon 2 : Zora", new DateTime(2014, 3, 11, 18, 0, 0), "Pas important"));
            listTempMessage.Add(new Message(7, listUtilisateur.ElementAt(0), "Message 4 dans salon 2 : Zora", new DateTime(2014, 3, 16, 6, 49, 0), "Pas important"));

            listSalon.ElementAt(1).ListMessage = listTempMessage;

            // Projet Greener
            listTempMessage.Add(new Message(8, listUtilisateur.ElementAt(0), "Message 1 dans salon 2 : Greener", new DateTime(2014, 4, 1, 5, 0, 0), "Important"));
            listTempMessage.Add(new Message(9, listUtilisateur.ElementAt(1), "Message 2 dans salon 2 : Greener", new DateTime(2014, 4, 1, 8, 3, 0), "Pas important"));
            listTempMessage.Add(new Message(10, listUtilisateur.ElementAt(2), "Message 3 dans salon 2 : Greener", new DateTime(2014, 5, 1, 5, 0, 0), "Important"));
            listTempMessage.Add(new Message(11, listUtilisateur.ElementAt(0), "Message 4 dans salon 2 : Greener", new DateTime(2014, 6, 1, 5, 0, 0), "Important"));

            listSalon.ElementAt(2).ListMessage = listTempMessage;

        }
    }
}
