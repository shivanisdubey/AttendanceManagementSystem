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

        [HttpGet]
        [Route("GetEmployeeByName/{name}")]
        public Employee GetEmployeeByName(string name)
        {
            return employeerepository.GetEmployeeByName(name);
        }


        [HttpGet]
        [Route("GetEmployeesByDepartment/{dept}")]
        public List<Employee> GetEmployeesByDepartment(string dept)
        {
            return employeerepository.GetEmployeesByDepartment(dept);

        }
        [HttpGet]
        [Route("GetEmployeesByDesignation/{designation}")]
        public List<Employee> GetEmployeesByDesignation(string designation)
        {
            return employeerepository.GetEmployeesByDesignation(designation);
        }

        [HttpPost]
        [Route("DeleteEmployeeByID/{id}")]
        public void DeleteEmployeeByID(int id)
        {
            employeerepository.DeleteEmployeeById(id);
        }

        [HttpPost]
        [Route("DeleteEmployeeByName/{name}")]
        public void DeleteEmployeeByName(string name)
        {
            employeerepository.DeleteEmployeeByName(name);
        }



    }
}