using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Uygulama çalışıyor.";
        }

        public string NewIndex()
        {
            return "Yavuz Selam";
        }

        public IActionResult Selamla()
        {
            ViewResult result = View("Selamla1");
            return result;
        }

    }
}
