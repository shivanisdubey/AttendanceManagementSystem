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


        public void UpdateEmployeeProject(EmployeeProject project)
        {
            db.Update(project);
            db.SaveChanges();
        }

        public List<EmployeeProject> GetEmployeeProject(int id)
        {
            List<EmployeeProject> Data = db.EmployeeProject.ToList();
            return Data;
        }
    }
}
