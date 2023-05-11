using Microsoft.AspNetCore.Mvc;

namespace bootstrap_task.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
