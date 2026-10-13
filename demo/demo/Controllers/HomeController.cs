using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("api/home")]
        public String Home()
        {
            return "api is working";
        }
    }
}
