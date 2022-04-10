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
        public void AddProject(string ProjectName)
        {

            try
            {
                Project p=new Project();
                p.ProjectName= ProjectName;
                db.Project.Add(p);
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

        public void UpdateProject(string ProjectName)
        {
            try
            {
                Project p=(from n in db.Project where n.ProjectName==ProjectName select n).FirstOrDefault();
                if (p != null)
                {
                    p.ProjectName = ProjectName;
                    db.Project.Update(p);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
