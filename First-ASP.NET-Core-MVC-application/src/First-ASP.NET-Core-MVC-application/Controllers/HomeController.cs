using Microsoft.AspNetCore.Mvc;

namespace First_ASP.NET_Core_MVC_application.Controllers
{
    public class HomeController : Controller
    {
        [Route("home/index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
