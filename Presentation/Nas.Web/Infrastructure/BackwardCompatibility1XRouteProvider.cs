using System.Web.Mvc;
using System.Web.Routing;
using Nas.Web.Framework.Mvc.Routes;

namespace Nas.Web.Infrastructure
{
    //Routes used for backward compatibility with 1.x versions of NasCommerce
    public partial class BackwardCompatibility1XRouteProvider : IRouteProvider
    {
        public void RegisterRoutes(RouteCollection routes)
        {
            //all old aspx URLs
            routes.MapRoute("", "{oldfilename}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "GeneralRedirect" },
                            new[] { "Nas.Web.Controllers" });
            
            //products
            routes.MapRoute("", "products/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectProduct"},
                            new[] { "Nas.Web.Controllers" });
            
            //categories
            routes.MapRoute("", "category/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectCategory" },
                            new[] { "Nas.Web.Controllers" });

            //manufacturers
            routes.MapRoute("", "manufacturer/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectManufacturer" },
                            new[] { "Nas.Web.Controllers" });

            //product tags
            routes.MapRoute("", "producttag/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectProductTag" },
                            new[] { "Nas.Web.Controllers" });

            //news
            routes.MapRoute("", "news/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectNewsItem" },
                            new[] { "Nas.Web.Controllers" });

            //blog posts
            routes.MapRoute("", "blog/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectBlogPost" },
                            new[] { "Nas.Web.Controllers" });

            //topics
            routes.MapRoute("", "topic/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectTopic" },
                            new[] { "Nas.Web.Controllers" });

            //forums
            routes.MapRoute("", "boards/fg/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectForumGroup" },
                            new[] { "Nas.Web.Controllers" });
            routes.MapRoute("", "boards/f/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectForum" },
                            new[] { "Nas.Web.Controllers" });
            routes.MapRoute("", "boards/t/{id}.aspx",
                            new { controller = "BackwardCompatibility1X", action = "RedirectForumTopic" },
                            new[] { "Nas.Web.Controllers" });
        }

        public int Priority
        {
            get
            {
                //register it after all other IRouteProvider are processed
                return -1000;
            }
        }
    }
}
