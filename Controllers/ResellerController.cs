using Microsoft.AspNetCore.Mvc;

namespace GoogleAuthDemo.Controllers
{
    public class ResellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
