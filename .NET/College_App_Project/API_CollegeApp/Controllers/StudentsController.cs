using Microsoft.AspNetCore.Mvc;
using API_CollegeApp.Models;
using API_CollegeApp.Data.Repository;
using System.Threading.Tasks;

namespace API_CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IGenericRepository<Student> _studentRepository;

        public StudentsController(IGenericRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllStudents()
        {
            var students = await _studentRepository.GetAllAsync();
            return Ok(students);
        }


        [HttpGet("GetById/{id}")]
        public async Task<ActionResult> GetStudentById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid student ID");
            }
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} is not found");
            }
            return Ok(student);
        }

        [HttpGet("GetByName/{name}")]
        public async Task<ActionResult> GetStudnetByName(string name)
        {
            var student = await _studentRepository.GetByNameAsync(name);
            if(student == null)
            {
                return NotFound($"Student with Name {name} is not found");
            }
            return Ok(student);
        }

        [HttpPost("Add")]
        public async Task<ActionResult> AddStudent([FromBody] Student student)
        {
            if(student == null)
            {
                return BadRequest("Invalid Student Data");
            }
            var addStudent = await _studentRepository.CreateAsync(student);
            return Ok(addStudent);
        }

        [HttpPut("Update/{id}")]
        public async Task<ActionResult> UpdateStudent(int id, [FromBody] Student student)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid Student ID");
            }
            if(student == null)
            {
                return BadRequest("Invalid Student Data");
            }

            var updatedStudent = await _studentRepository.UpdateAsync(id, student);
            if (updatedStudent == null)
            {
                return NotFound($"Student with ID {id} is not found");
            }
            return Ok(updatedStudent);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<ActionResult> DeleteStudent(int id)
        {
            var deleted = await _studentRepository.DeleteAsync(id);
            if(deleted == null)
            {
                return NotFound($"Student with ID {id} is not found");
            }
            return Ok(deleted);
        }
    }
}
