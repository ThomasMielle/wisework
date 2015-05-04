using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WiseWork.Content.Ressources;

namespace WiseWork.Controllers
{
    public class SalonUtilisateurController : ApiController
    {
        [HttpPost]
        public List<Message> getSalon([FromBody] string IdUtilisateur)
        {
            List<Message> mess = null;
            List<Message> listTemp = new List<Message>();
            int idUser = Int32.Parse(IdUtilisateur);
            foreach (SalonUtilisateur su in RessourcesSimon.listSalonUtilisateur)
                if (su.Id == idUser)
                {
                    mess = su.ListMessage;
                    break;
                }

            if (mess != null)
            {
                foreach (Message message in mess)
                {
                    if (!message.Tag.Equals(RessourcesSimon.TAG_CHAT))
                    {
                        if (listTemp.Count - 1 > 0 && message.Tag.Equals(RessourcesSimon.TAG_JOUR_SEPARATEUR) && listTemp.ElementAt(listTemp.Count - 1).Tag.Equals(RessourcesSimon.TAG_JOUR_SEPARATEUR))
                            listTemp.RemoveAt(listTemp.Count - 1);
                        listTemp.Add(message);
                    }
                }
            }
            if (listTemp.Count != 0 && listTemp.ElementAt(listTemp.Count - 1).Tag.Equals(RessourcesSimon.TAG_JOUR_SEPARATEUR))
                listTemp.RemoveAt(listTemp.Count - 1);
            return listTemp;
        }

        [HttpPost]
        public Utilisateur getInfos([FromBody] string IdUtilisateur)
        {
            Utilisateur user = null;
            int idUser = Int32.Parse(IdUtilisateur);
            foreach (Utilisateur u in RessourcesSimon.listUtilisateur)
                if (u.getId.Id == idUser)
                {
                    user = u;
                    break;
                }

            return user;
        }

        [HttpPost]
        public List<Message> getChat(ChatInfos ci)
        {
            SalonUtilisateur s1 = null;
            SalonUtilisateur s2 = null;
            List<Message> listTemp = new List<Message>();
            List<Message> listTemp1 = new List<Message>();
            List<Message> listTemp2 = new List<Message>();
            int i1 = 0, i2 = 0;

            foreach (SalonUtilisateur su in RessourcesSimon.listSalonUtilisateur)
            {
                if (su.Id == ci.IdCurrentSalon)
                    s1 = su;
                if (su.Id == ci.IdCurrentUtilisateur)
                    s2 = su;
            }

            if (s1 != null && s2 != null)
            {
                foreach (Message mess in s1.ListMessage)
                    if (mess.Tag.Equals(RessourcesSimon.TAG_CHAT) && mess.Auteur.Id == ci.IdCurrentUtilisateur)
                        listTemp1.Add(mess);

                foreach (Message mess in s2.ListMessage)
                    if (mess.Tag.Equals(RessourcesSimon.TAG_CHAT) && mess.Auteur.Id == ci.IdCurrentSalon)
                        listTemp2.Add(mess);

                while (i1 != listTemp1.Count || i2 != listTemp2.Count)
                {
                    if (i1 == listTemp1.Count)
                        ajouterMessage(listTemp, listTemp2.ElementAt(i2++));
                    else if (i2 == listTemp2.Count)
                        ajouterMessage(listTemp, listTemp1.ElementAt(i1++));
                    else
                    {
                        if (DateTime.Compare(listTemp1.ElementAt(i1).Date, listTemp2.ElementAt(i2).Date) <= 0)
                            ajouterMessage(listTemp, listTemp1.ElementAt(i1++));
                        else
                            ajouterMessage(listTemp, listTemp2.ElementAt(i2++));
                    }
                }
            }
            return listTemp;
        }

        [HttpPost]
        public List<Message> ajouterMessageSalon(NouveauMessage nm)
        {
            SalonUtilisateur su = null;
            foreach (SalonUtilisateur sutemp in RessourcesSimon.listSalonUtilisateur)
                if (sutemp.getId.Nom.Equals(nm.nomSalon))
                {
                    su = sutemp;
                    break;
                }
            if (su == null) return null;
            foreach (Utilisateur user in RessourcesSimon.listUtilisateur)
                if (user.Id == nm.idUtilisateur)
                {
                    su.ajouterMessage(user, nm.message);
                    return getSalon(su.Id.ToString());
                }
            return null;
        }

        [HttpPost]
        public List<Message> ajouterMessageChat(NouveauMessage nm)
        {
            SalonUtilisateur su = null;
            foreach (SalonUtilisateur sutemp in RessourcesSimon.listSalonUtilisateur)
                if (sutemp.getId.Nom.Equals(nm.nomSalon))
                {
                    su = sutemp;
                    break;
                }
            if (su == null) return null;
            // TODO : PENSER A TESTER S'IL EST DANS LE SALON
            foreach (Utilisateur user in RessourcesSimon.listUtilisateur)
                if (user.Id == nm.idUtilisateur)
                {
                    su.ajouterMessage(user, nm.message, DateTime.Now, nm.tag);
                    return getChat(new ChatInfos(su.Id, user.Id));
                }
            return null;
        }

        private void ajouterMessage(List<Message> list, Message mess)
        {
            if (list.Count == 0 || mess.Date.DayOfYear > list.ElementAt(list.Count - 1).Date.DayOfYear)
            {
                list.Add(new Message(-1, null,
                    mess.Date.DayOfWeek + " " + mess.Date.Day + " " + month(mess.Date.Month) + " " + mess.Date.Year,
                    new DateTime(mess.Date.Year, mess.Date.Month, mess.Date.Day), RessourcesSimon.TAG_JOUR_SEPARATEUR));
            }
            list.Add(mess);
        }

        private string month(int month)
        {
            switch (month)
            {
                case 1: return "janvier";
                case 2: return "février";
                case 3: return "mars";
                case 4: return "avril";
                case 5: return "mai";
                case 6: return "juin";
                case 7: return "juillet";
                case 8: return "août";
                case 9: return "septembre";
                case 10: return "octobre";
                case 11: return "novembre";
                case 12: return "décembre";
                default: return "mois non-existant";
            }
        }
    }
}
