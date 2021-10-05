using Microsoft.AspNetCore.Mvc;

namespace Festival.Controllers
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