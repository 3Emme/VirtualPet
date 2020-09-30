using Microsoft.AspNetCore.Mvc;

namespace Tamagotochi.Controllers
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