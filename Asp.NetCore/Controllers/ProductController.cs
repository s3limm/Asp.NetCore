using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
