using Microsoft.AspNetCore.Mvc;

namespace bootstrap_task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
