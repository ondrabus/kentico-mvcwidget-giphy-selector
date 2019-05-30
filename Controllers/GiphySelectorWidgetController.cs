using Kentico.PageBuilder.Web.Mvc;
using KenticoCommunity.GiphySelectorWidget;
using System.Configuration;
using System.Web.Mvc;

[assembly: RegisterWidget("KenticoCommunity.GiphySelectorWidget", typeof(GiphySelectorWidgetController), "Giphy selector widget", Description = "Shows selected Giphy animation", IconClass = "icon-picture")]

namespace KenticoCommunity.GiphySelectorWidget
{
    public class GiphySelectorWidgetController : WidgetController<GiphySelectorWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();

            var viewModel = new GiphySelectorWidgetViewModel
            {
                Url = properties.Url,
                ApiKey = ConfigurationManager.AppSettings["GiphyApiKey"]
            };


            return PartialView("Widgets/GiphySelectorWidget/_GiphySelectorWidget", viewModel);
        }
    }
}