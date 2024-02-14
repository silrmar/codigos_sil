using Microsoft.AspNetCore.Mvc;

namespace tasca3p.Views
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}
