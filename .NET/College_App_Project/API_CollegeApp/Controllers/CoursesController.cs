using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API_CollegeApp.Data.Repository;
using API_CollegeApp.Models;
using System.Collections.Generic;

namespace API_CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IGenericRepository<Course> _courseRepository;

        public CoursesController(IGenericRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllCourses()
        {
            var courses = await _courseRepository.GetAllAsync();
            return Ok(courses);
        }


        [HttpGet("GetById/{id}")]
        public async Task<ActionResult> GetCourseById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid course ID");
            }
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound($"Course with ID {id} is not found");
            }
            return Ok(course);
        }

        [HttpGet("GetByName/{name}")]
        public async Task<ActionResult> GetCourseByName(string name)
        {
            var course = await _courseRepository.GetByNameAsync(name);
            if (course == null)
            {
                return NotFound($"Course with Name {name} is not found");
            }
            return Ok(course);
        }

        [HttpPost("Add")]
        public async Task<ActionResult> AddCourse([FromBody] Course course)
        {
            if (course == null)
            {
                return BadRequest("Invalid Course Data");
            }
            var addStudent = await _courseRepository.CreateAsync(course);
            return Ok(addStudent);
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult> UpdateStudent(int id, [FromBody] Course course)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid Course ID");
            }
            if (course == null)
            {
                return BadRequest("Invalid Course Data");
            }

            var updatedCourse = await _courseRepository.UpdateAsync(id, course);
            if (updatedCourse == null)
            {
                return NotFound($"Course with ID {id} is not found");
            }
            return Ok(updatedCourse);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> DeleteCourse(int id)
        {
            try
            {
                var deleted = await _courseRepository.DeleteAsync(id);

                if (!deleted)
                {
                    return NotFound($"Course with ID {id} was not found.");
                }

                return Ok("Course deleted successfully.");
            }
            catch (InvalidOperationException ex)
            {
                // Friendly message when FK constraint blocks deletion
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                // General exception fallback
                return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
            }
        }

    }
}
