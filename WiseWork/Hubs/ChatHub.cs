using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WiseWork.Content.Ressources
{
    public class ChatHub : Hub
    {
        public void NotifyMessage(List<Message> msg)
        {
            Clients.Others.onMessageSend(msg);
        }
    }
}