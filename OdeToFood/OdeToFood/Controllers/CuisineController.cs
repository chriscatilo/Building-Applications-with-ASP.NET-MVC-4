using OdeToFood.Filters;
using System;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize(Role = "Admin"] // redirect the user to the login page if not authenticated and have role of Admin
    [Log]
    public class CuisineController : Controller
    {

        //[Authorize] // filter can be placed in the controller or controller action
        public ActionResult Search(string name = "french")
        {
            throw new Exception("Something terrible has happened");

            var message = Server.HtmlEncode(name);
            return Content(message);
        }

    }
}
