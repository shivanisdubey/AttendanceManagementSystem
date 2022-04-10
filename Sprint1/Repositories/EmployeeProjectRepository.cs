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
        public void AddEmployeeProject(int EmployeeId, int ProjectId)
        {
            Employee emp = db.Employee.Find(EmployeeId);
            Project pro = db.Project.Find(ProjectId);
                if (emp != null && pro != null)
                {
                    EmployeeProject obj = new EmployeeProject();
                    obj.EmployeeId = EmployeeId;
                    obj.ProjectId = ProjectId;
                     Project pr=(from p in db.Project where p.ProjectId==ProjectId select p).FirstOrDefault();
                obj.ProjectName = pr.ProjectName;
                    db.EmployeeProject.Add(obj);
                    db.SaveChanges();
                }
        }


        public void UpdateEmployeeProject(int NewProjectId, int EmployeeId, int ProjectId)
        {
            EmployeeProject obj = db.EmployeeProject.Find(NewProjectId);
            if (obj != null)
            {
                Employee emp = db.Employee.Find(EmployeeId);
                Project pro = db.Project.Find(ProjectId);
                if (emp != null && pro != null)
                {
                    obj.ProjectId = ProjectId;
                    db.EmployeeProject.Update(obj);
                    db.SaveChanges();
                }
            }
        }

        public List<EmployeeProject> GetEmployeeProject(int id)
        {
            List<EmployeeProject> Data = db.EmployeeProject.ToList();
            return Data;
        }
    }
}
