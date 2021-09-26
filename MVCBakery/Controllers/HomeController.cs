using Microsoft.AspNetCore.Mvc;

namespace MVCBakery.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}