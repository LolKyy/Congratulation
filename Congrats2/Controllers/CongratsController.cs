using Microsoft.AspNetCore.Mvc;

namespace Congrats2.Controllers
{
    public class CongratsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
