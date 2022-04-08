using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IProjectRepository
    {
        void AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProjectById(int ProjectId);
    }
}
