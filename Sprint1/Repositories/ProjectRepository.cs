using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sprint1.Models;
namespace Sprint1.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly SprintDbContext db;

        public ProjectRepository()
        {
            this.db = new SprintDbContext();

        }
        public void AddProject(Project project)
        {

            try
            {
                db.Project.Add(project);
                db.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void DeleteProjectById(int pid)
        {
            try
            {
                Project project = db.Project.Find(pid);
                db.Project.Remove(project);
                db.SaveChanges();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateProject(Project project)
        {
            try
            {
                db.Project.Update(project);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
