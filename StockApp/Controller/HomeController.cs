using Microsoft.AspNetCore.Mvc;

namespace StockApp.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
