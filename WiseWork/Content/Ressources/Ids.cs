using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiseWork.Content.Ressources
{
    public class Ids
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public Ids(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}