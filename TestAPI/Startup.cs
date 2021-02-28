using Microsoft.Owin;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(TestAPI.Startup))]

namespace TestAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            HttpServer server = new HttpServer(config);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute("WithActionApi", "api/{controller}/{action}/{id}");
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Filters.Add(new CustomActionFilter());

            app.UseWebApi(server);
        }
    }
}