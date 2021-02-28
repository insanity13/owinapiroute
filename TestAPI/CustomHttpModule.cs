using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI
{
    public class CustomHttpModule : IHttpModule
    {
        public void Dispose()
        {
            
        }

        public void Init(HttpApplication context)
        {
            context.EndRequest += OnEndRequest;
        }

        private void OnEndRequest(object sender, EventArgs e)
        {
            var application = (HttpApplication)sender;
            var context = application.Context;
            var request = application.Request;
            var values = request.RequestContext?.RouteData?.Values; // Incorrect Route Data
        }
    }
}