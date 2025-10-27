using Microsoft.AspNetCore.Mvc;
using StudentDBFirst.Models;

namespace StudentDBFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly CollegeContext _dbContext;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, CollegeContext myContext)
        {
            _logger = logger;
            _dbContext = myContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Student> Get()
        {
            var students = _dbContext.Students.ToList();
            return students;
        }
    }
}
