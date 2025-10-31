using Microsoft.AspNetCore.Mvc;

namespace View_CollegeApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Course()
        {
            return View();
        }
    }
}
