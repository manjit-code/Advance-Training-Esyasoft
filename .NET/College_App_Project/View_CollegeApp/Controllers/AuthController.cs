using Microsoft.AspNetCore.Mvc;

namespace View_CollegeApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
