using Microsoft.AspNetCore.Mvc;

namespace bootstrap_task.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
