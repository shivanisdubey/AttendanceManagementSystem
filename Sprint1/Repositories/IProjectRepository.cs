using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IProjectRepository
    {
        void AddProject(string ProjectName);
        void UpdateProject(string ProjectName);
        void DeleteProjectById(int ProjectId);
    }
}
