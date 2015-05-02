using Microsoft.Owin;
using Owin;
using WiseWork;
using Microsoft.AspNet.SignalR;

namespace WiseWork
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}