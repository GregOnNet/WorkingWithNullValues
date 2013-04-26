using System.Web.Http;

namespace WebApi.Example.Configurations
{
  public class WebApiControllers
  {
    public static void Register(HttpConfiguration configuration)
    {
      configuration.Routes.MapHttpRoute(
        name: "Default",
        routeTemplate: "api/{controller}/{id}",
        defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}