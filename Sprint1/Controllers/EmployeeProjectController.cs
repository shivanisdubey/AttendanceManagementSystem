using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Sprint1.Repositories;
using Sprint1.Models;

namespace Sprint1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeProjectController : ControllerBase
    {
        private readonly IEmployeeProjectRepository _employeeProjectRepository;
        public EmployeeProjectController(IEmployeeProjectRepository projectRepository)
        {
            _employeeProjectRepository = projectRepository;
        }
        [HttpPost]
        [Route("add employeeProject")]
        public void AddEmployeeProject(EmployeeProject project)
        {
            _employeeProjectRepository.AddEmployeeProject(project); 
        }
        [HttpPost]
        [Route("add employeeProject by id")]
        public void AddEmployeeProjectByProjectId(int Empid, int ProID)
        {
            _employeeProjectRepository.AddEmployeeProjectByProjectId(Empid, ProID);
        }
        [HttpPost]
        [Route("add employeeProject by name")]
        public void AddEmployeeProjectByProjectName(int EmployeeId, string ProjectName)
        {
            _employeeProjectRepository.AddEmployeeProjectByProjectName(EmployeeId, ProjectName); 
        }
        [HttpPost]
        [Route("delete employeeProject")]
        public void DeleteEmployeeProject(EmployeeProject project)
        {
            _employeeProjectRepository.DeleteEmployeeProject(project);
        }
        [HttpGet]
        public List<EmployeeProject> GetEmployeeProject(int id)
        {
            return _employeeProjectRepository.GetEmployeeProject(id);
        }
    }
}
