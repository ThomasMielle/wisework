using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class SalonController : ApiController
    {

        [HttpPost]
        public Salon getSalon([FromBody] string nom)
        {
            Salon s = null;
            foreach (Salon salon in RessourcesSimon.listSalon)
            {
                if (salon.Nom.Equals(nom))
                {
                    s = salon;
                    break;
                }
            }

            return s;
        }

        [HttpPost]
        public List<Message> updateTag([FromBody] string ids)
        {
            int index = ids.IndexOf(',');
            string nom = ids.Substring(0, index);
            int idMess = int.Parse(ids.Substring(index + 1));
            Salon s = null;
            foreach (Salon salon in RessourcesSimon.listSalon)
                if (salon.Nom.Equals(nom))
                {
                    s = salon;
                    break;
                }
            if (s != null)
                foreach (Message mess in s.ListMessage)
                {
                    if (mess.Id == idMess)
                    {
                        mess.Important = !mess.Important;
                        break;
                    }
                }
            return s.ListMessage;
        }

        [HttpPost]
        public List<Message> vue([FromBody] string ids)
        {
            int index = ids.IndexOf(',');
            string nom = ids.Substring(0, index);
            string vue = ids.Substring(index + 1);
            Salon s = null;
            var listMessageTemp = new List<Message>();
            foreach (Salon salon in RessourcesSimon.listSalon)
                if (salon.Nom.Equals(nom))
                {
                    s = salon;
                    break;
                }
            if (s != null)
                switch (vue)
                {
                    case "important":
                        foreach (Message mess in s.ListMessage)
                        {
                            if (mess.Important)
                            {
                                listMessageTemp.Add(mess);
                            }
                        }
                        return listMessageTemp;
                    case "normal":
                        return s.ListMessage;
                    case "chat":
                        break;
                    case "Drive":
                        foreach (Message mess in s.ListMessage)
                        {
                            if (mess.Tag.Equals(RessourcesSimon.TAG_DRIVE))
                            {
                                listMessageTemp.Add(mess);
                            }
                        }
                        return listMessageTemp;
                    case "Rdv":
                        foreach (Message mess in s.ListMessage)
                        {
                            if (mess.Tag.Equals(RessourcesSimon.TAG_RDV))
                            {
                                listMessageTemp.Add(mess);
                            }
                        }
                        return listMessageTemp;
                    default:
                        break;
                }

            return listMessageTemp;
        }
        
        [HttpPost]
        public List<Message> filtreDate(DateTest dt)
        {
            Salon s = null;
            var listMessageTemp = new List<Message>();
            foreach (Salon salon in RessourcesSimon.listSalon)
                if (salon.Nom.Equals(dt.nomSalon))
                {
                    s = salon;
                    break;
                }
            if (s != null)
                foreach (Message mess in s.ListMessage)
                    if (mess.Date > dt.dateMin && mess.Date < dt.dateMax)
                        listMessageTemp.Add(mess);

            return listMessageTemp;
        }

        [HttpPost]
        public List<Message> ajouterMessage(NouveauMessage nm)
        {
            Salon s = null;
            Utilisateur u = null;
            foreach (Salon salon in RessourcesSimon.listSalon)
                if (salon.Nom.Equals(nm.nomSalon))
                {
                    s = salon;
                    break;
                }
            if (s == null) return null;
            foreach (Utilisateur user in s.ListUtilisateur)
                if (user.Id == nm.idUtilisateur)
                {
                    u = user;
                    break;
                }

            s.ajouterMessage(u, nm.message);

            return s.ListMessage;
        }

        [HttpGet]
        public List<Salon> getSalons()
        {
            RessourcesSimon.initData();
            return RessourcesSimon.listSalon;
        }
    }
}
