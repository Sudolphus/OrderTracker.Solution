using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Homepage() {
      return View();
    }
  }
}