using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IEmployeeProjectRepository
    {
        void AddEmployeeProject(int EmployeeId, int ProjectId);
        List<EmployeeProject> GetEmployeeProject(int ProjectId);
        void UpdateEmployeeProject(int NewProjectId, int EmployeeId, int ProjectId);
    }
}
