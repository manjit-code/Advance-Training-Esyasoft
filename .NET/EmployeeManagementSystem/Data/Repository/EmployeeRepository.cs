using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace EmployeeManagementSystem.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeContext;
        public EmployeeRepository(EmployeeDbContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public async Task AddAsync(Employee employee)
        {
           await _employeeContext.Employees.AddAsync(employee);
           await _employeeContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employee = _employeeContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
             _employeeContext.Employees.Remove(employee);
            await _employeeContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            var employees = await _employeeContext.Employees.Select(e => new Employee()
            {
                Email = e.Email,
                Department = e.Department,
                EmployeeId = e.EmployeeId,
                FullName = e.FullName,
                Salary = e.Salary,
            }).ToListAsync();

            return employees;
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            var employee = _employeeContext.Employees.Where(e => e.EmployeeId == id).FirstOrDefault();
            return employee;
        }

        public async Task UpdateAsync(Employee employee)
        {
            var existingEmployee = _employeeContext.Employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();
            if (existingEmployee == null)
            {
                return;
            }
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Email = employee.Email;
            existingEmployee.FullName = employee.FullName;
            existingEmployee.Department = employee.Department;
            await _employeeContext.SaveChangesAsync();
            return;
        }
    }
}
