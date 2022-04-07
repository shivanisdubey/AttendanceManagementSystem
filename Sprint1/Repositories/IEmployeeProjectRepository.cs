using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IEmployeeProjectRepository
    {
        void AddEmployeeProject(EmployeeProject project);
        void AddEmployeeProjectByProjectId(int EmployeeId,int ProjectId);
        void AddEmployeeProjectByProjectName(int EmployeeId,string ProjectName);
        List<EmployeeProject> GetEmployeeProject(int id);
        void DeleteEmployeeProject(EmployeeProject project);
    }
}
