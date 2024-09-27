using Microsoft.AspNetCore.Mvc;

namespace LocationCar.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
