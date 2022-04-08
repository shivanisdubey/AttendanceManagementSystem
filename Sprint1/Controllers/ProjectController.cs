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
        [HttpGet]
        [Route("Add Project/{AddProject}")]
        public void AddProject(Project project)
        {
            _projectRepository.AddProject(project);
        }

        [HttpGet]
        [Route("Update Project/{Update Project}")]
        public void UpdateProject(Project project)
        {
            _projectRepository.UpdateProject(project);
        }

        [HttpGet]
        [Route("Delete Project/{ProjectId}")]
        public void DeleteProjectByTD(int Pid)
        {
            _projectRepository.DeleteProjectById(Pid);
        }
    }
}
