using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sprint1.Models;
using Sprint1.Repositories;

namespace Sprint1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository employeerepository;

        public EmployeeController(IEmployeeRepository employeerepository)
        {
            this.employeerepository = employeerepository;
        }

        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployee(Employee employee)
        {
            employeerepository.AddEmployee(employee);
        }
        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            List<Employee> employee = employeerepository.GetEmployees();
            return (employee);
        }
        [HttpGet]
        [Route("GetEmployeeById/{id}")]
        public Employee GetEmployeeById(int id)
        {
            Employee employee = employeerepository.GetEmployeeById(id);
            return (employee);
        }
        [HttpDelete]
        [Route("DeleteEmployeeByID/{id}")]
        public void DeleteEmployeeByID(int id)
        {
            employeerepository.DeleteEmployeeById(id);
        }
        [HttpPut]
        [Route("UpdateEmployee")]
        public void UpdateEmployee(string EmployeeName, string EmployeeEmailId, DateTime EmployeeDOB, string EmployeeDesignation, string EmployeeDepartment)
        {
            employeerepository.UpdateEmployee(EmployeeName,EmployeeEmailId,EmployeeDOB, EmployeeDesignation, EmployeeDepartment);
        }

    }
}