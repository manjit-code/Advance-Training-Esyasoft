using CollegeApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Xml.Linq;

namespace CollegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeApp : ControllerBase
    {
        private readonly IMyInterface _myInterface;
        public CollegeApp(IMyInterface myInterface)
        {
            _myInterface = myInterface;
        }

        [HttpGet]
        [Route("All")]
        public ActionResult<IEnumerable<StudentDTO>> GetStudents()
        {
            _myInterface.Print("From College App Controller");
            // Store required data fetched from DB (here consider collegeRepository)
            var student = collegeRepository.students.Select(s => new StudentDTO() {
                studentID = s.studentID,
                name = s.name,
                age = s.age,
                email = s.email
            });
            return Ok(student);
        }

        [HttpGet("{id:int}", Name = "getStudentById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<StudentDTO> getStudentById(int id)
        {
            if (id == 0) {
                return BadRequest();
            }

            //var studentFind = collegeRepository.students.Where(s => s.studentID == id);
            var student = collegeRepository.students.Where(s => s.studentID == id).Select(s => new StudentDTO()
            {
                studentID = s.studentID,
                name = s.name,
                age = s.age,
                email = s.email
            });

            if (student == null)
            {
                return NotFound($"Student with ID: {id} not found !");
            }
            return Ok(student);
        }

        [HttpGet]
        [Route("{Name:Alpha}", Name = "getStudentByName")] // "String is not allowed in Routing => use  "Alpha"
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<Student> getStudentByName(string Name)
        {
            if (String.IsNullOrEmpty(Name))
            {
                return BadRequest();
            }
            var student = collegeRepository.students.Where(n => n.name == Name).FirstOrDefault();

            if (student == null)
            {
                return NotFound($"Student with Name: {Name} not found !");
            }
            return Ok(student);
        }

        [HttpDelete]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<bool> deletestudent(int id)
        {
            if (int.IsNegative(id) || id == 0)
            {
                return BadRequest();
            }
            var deleting = collegeRepository.students.Where(n => n.studentID == id).FirstOrDefault();
            if (deleting == null)
            {
                return NotFound($"Student with ID: {id} not found !");
            }

            collegeRepository.students.Remove(deleting);


            return Ok(true);

        }

        [HttpPost("Create")]
        public ActionResult<StudentDTO> CreateStudent([FromBody] StudentDTO model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            int newId = collegeRepository.students.LastOrDefault().studentID + 1;

            Student newStudent = new Student {
                studentID = newId,
                name = model.name,
                age = model.age,
                email = model.email
            };

            collegeRepository.students.Add(newStudent);
            return Ok(newStudent);
        }

        [HttpPut("Update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(204)]
        public ActionResult UpdateStudent([FromBody] StudentDTO model)
        {
            if (model == null || model.studentID <= 0)
            {
                return BadRequest();
            }

            var existingStudent = collegeRepository.students.Where(s => s.studentID == model.studentID).FirstOrDefault();
            if (existingStudent == null)
            {
                return NotFound($"The studnet with id {model.studentID} is not found !");
            }

            existingStudent.name = model.name;
            existingStudent.age = model.age;
            existingStudent.email = model.email;

            return NoContent();
        }

        [HttpPatch("{id:int}/updatePartial")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(204)]
        public ActionResult UpdatePartial(int id, [FromBody] JsonPatchDocument<StudentDTO> patchDocument)
        {
            if(patchDocument == null || id <= 0)
            {
                return BadRequest();
            }

            var existingStudnet = collegeRepository.students.Where(s => s.studentID == id).FirstOrDefault();
            if (existingStudnet == null)
            {
                return NotFound($"The studnet with id {id} is not found !");
            }

            var tempStudentDTO = new StudentDTO()
            {
                name = existingStudnet.name,
                age = existingStudnet.age,
                email = existingStudnet.email
            };

            patchDocument.ApplyTo(tempStudentDTO, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            existingStudnet.name = tempStudentDTO.name;
            existingStudnet.age = tempStudentDTO.age;
            existingStudnet.email = tempStudentDTO.email;

            return NoContent();
        }

    }
}
