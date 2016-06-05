using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);
            return Content(message);
        }       
    }
}
