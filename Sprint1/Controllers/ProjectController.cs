using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using Sprint1.Repositories;
using System;
using System.Collections.Generic;


namespace Sprint1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        [HttpPost]
        [Route("Add Project")]
        public IActionResult AddProject(string ProjectName)
        {
            try
            {
                _projectRepository.AddProject(ProjectName);
                return Ok("Project Added");
            }
            catch(Exception ex)
            {
                return Content(ex.Message);
            }
        }

        [HttpPut]
        [Route("Update Project")]
        public void UpdateProject(string ProjectName)
        {
            _projectRepository.UpdateProject(ProjectName);
        }

        [HttpDelete]
        [Route("Delete Project")]
        public void DeleteProjectById(int Pid)
        {
            _projectRepository.DeleteProjectById(Pid);
        }
    }
}
