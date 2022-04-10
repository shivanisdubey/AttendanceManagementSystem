using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IEmployeeProjectRepository
    {
        void AddEmployeeProject(EmployeeProject project);
        List<EmployeeProject> GetEmployeeProject(int ProjectId);
        void UpdateEmployeeProject(EmployeeProject project);
    }
}
