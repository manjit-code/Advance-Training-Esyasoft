using EmployeeManagementSystem.Data.Repository;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost("add")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> AddAsync([FromBody] Employee employee)
        {
            await _employeeRepository.AddAsync(employee);
            return Ok();
        }

        [HttpDelete("delete")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }
            var employee = await _employeeRepository.GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            await _employeeRepository.DeleteAsync(id);

            return Ok();
        }

        [HttpGet("all")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            return Ok(employees);
        }

        [HttpGet("id")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult<Employee?>> GetByIdAsync(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }
            var employee = await _employeeRepository.GetByIdAsync(id);
            if(employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPut("update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateAsync([FromBody] Employee employee)
        {
            _employeeRepository.UpdateAsync(employee);
            return Ok();
        }
    }
}
