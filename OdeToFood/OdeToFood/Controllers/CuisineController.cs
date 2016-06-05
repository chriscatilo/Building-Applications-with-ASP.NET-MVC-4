using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        [HttpPost] // can only be invoked on a POST request
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);

            return Content(message);
        }

        [HttpGet] // can only be invoked on a GET request
        public ActionResult Search()
        {
            return Content("Search!");
        }
    }
}
