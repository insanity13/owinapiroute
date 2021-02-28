using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace TestAPI
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_EndRequest(object sender, EventArgs e)
        {
            var application = (HttpApplication)sender;
            var context = application.Context;
            var request = application.Request;
            var values = request.RequestContext?.RouteData?.Values; // incorrect
        }
    }
}