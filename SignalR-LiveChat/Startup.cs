﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(SignalR_LiveChat.Startup))]

namespace SignalR_LiveChat
{
    public class Startup
    {
        public void Configuration (IAppBuilder app)
        {
            app.MapSignalR();
        }
        
    }
}