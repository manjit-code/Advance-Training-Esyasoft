using CollegeApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingDependencyInjection : Controller
    {
        private readonly IMyInterface _myinterface;
        public TestingDependencyInjection(IMyInterface myinterface)
        {
            _myinterface = myinterface;
        }

        [HttpGet]
        public ActionResult Test()
        {
            _myinterface.Print("From Testing Dependecy Injection Controller");
            return Ok();
        }
    }
}
