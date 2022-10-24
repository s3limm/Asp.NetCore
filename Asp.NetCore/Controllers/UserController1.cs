using Asp.NetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCore.Controllers
{
    public class UserController1 : Controller
    {
        //user class'ından inctance aldık ve böylelıkle models katmanını görmüş olduk.
        public IActionResult GetUser()
        {
            User user = new User();

            user.İd = 1938;
            user.Name = "Yavuz";
            user.SurName = "Emrem";
            return View();
        }

        //bizim burada yazdıgımız metotların hepsı action olarak gecer oyuzden bunları sayfa ıcerısnde eger gostermek ıstemıyorsak [NonAction] komutunu yazmamız gerekır.

        [NonAction]
        public void GetFullName(User user)
        {
            user.SurName = "Selim";
        }
    }
}
