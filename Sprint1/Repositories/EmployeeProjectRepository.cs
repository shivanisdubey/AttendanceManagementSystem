using Sprint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint1.Repositories
{
    public class EmployeeProjectRepository : IEmployeeProjectRepository
    {
        private readonly SprintDbContext db;
        public EmployeeProjectRepository()
        {
            this.db = new SprintDbContext();
        }
        public void AddEmployeeProject(EmployeeProject project)
        {
            db.Add(project);
            db.SaveChanges();
        }

        public void AddEmployeeProjectByProjectId(int Empid, int ProID)
        {
            db.Add(new EmployeeProject() { EmployeeId = Empid, ProjectId = ProID });
            db.SaveChanges();
        }

        public void AddEmployeeProjectByProjectName(int EmployeeId, string ProjectName)
        {
            db.Add(new EmployeeProject() { EmployeeId = EmployeeId, ProjectName = ProjectName });
            db.SaveChanges();
        }

        public void DeleteEmployeeProject(EmployeeProject project)
        {
            db.Remove(project);
            db.SaveChanges();
        }

        public List<EmployeeProject> GetEmployeeProject(int id)
        {
            List<EmployeeProject> Data = db.EmployeeProject.ToList();
            return Data;
        }
    }
}
