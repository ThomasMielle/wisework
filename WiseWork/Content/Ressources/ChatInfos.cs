using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WiseWork.Content.Ressources
{
    public class ChatInfos
    {
        public int IdCurrentSalon { get; set; }
        public int IdCurrentUtilisateur { get; set; }

        public ChatInfos(int idCurrentSalon, int idCurrentUser)
        {
            IdCurrentSalon = idCurrentSalon;
            IdCurrentUtilisateur = idCurrentUser;
        }
    }
}