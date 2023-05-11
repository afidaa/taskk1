using Microsoft.AspNetCore.Mvc;

namespace bootstrap_task.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
