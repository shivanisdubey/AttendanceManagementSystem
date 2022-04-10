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
        public void AddEmployeeProject(int EmployeeId, int ProjectId)
        {
            _employeeProjectRepository.AddEmployeeProject(EmployeeId,ProjectId); 
        }
        
        [HttpPut]
        [Route("update employeeProject")]
        public void UpdateEmployeeProject(int NewProjectId, int EmployeeId, int ProjectId)
        {
            _employeeProjectRepository.UpdateEmployeeProject(NewProjectId,EmployeeId, ProjectId);
        }
        [HttpGet]
        public List<EmployeeProject> GetEmployeeProject(int id)
        {
            return _employeeProjectRepository.GetEmployeeProject(id);
        }
    }
}
