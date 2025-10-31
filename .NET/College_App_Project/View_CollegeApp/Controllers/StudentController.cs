using Microsoft.AspNetCore.Mvc;

namespace View_CollegeApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Student()
        {
            return View();
        }
    }
}
