﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseWork.Content.Ressources
{
    public class Projet
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Variables
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private int id;
        private string nom;
        private List<Utilisateur> utilisateur;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Constructeurs
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Projet()
        {
            initialise();
        }

        public Projet(string nom)
        {
            initialise();

            this.nom = nom;
        }

        public Projet(int id, string nom, List<Utilisateur> listUtilisateur)
        {
            initialise();

            this.id = id;
            this.nom = nom;
            this.utilisateur = listUtilisateur;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Initialise
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private void initialise()
        {
            this.nom = null;
            this.utilisateur = new List<Utilisateur>();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        //  Methodes
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
