using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.Controllers
{
    public class UserController1 : Controller
    {
        public IActionResult GetUser()
        {
            return View();
        }
    }
}
