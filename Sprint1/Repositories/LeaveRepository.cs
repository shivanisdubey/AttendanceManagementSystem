using Sprint1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sprint1.Repositories;

namespace Sprint1.Repositories
{
    public class LeaveRepository : ILeaveRepository
    {
        public void AddLeave(Leaves leave)
        {
            using (SprintDbContext db = new SprintDbContext())
            {
                db.Leaves.Add(leave);
                db.SaveChanges();
            }

        }


        public List<Leaves> GetLeaves(int EmployeeId)
        {
            using (SprintDbContext db = new SprintDbContext())
            {

                List<Leaves> leaves = (from i in db.Leaves where i.EmployeeId == EmployeeId select i).ToList();
                return leaves;
            }
        }

        public void RemoveLeave(Leaves leave)
        {
            using (SprintDbContext db = new SprintDbContext())
            {
                db.Leaves.Remove(leave);
                db.SaveChanges();
            }

        }

        public void RemoveLeave(int LeaveId)
        {
            throw new NotImplementedException();
        }

        public void UpdateLeave(Leaves leave)
        {
            using (SprintDbContext db = new SprintDbContext())
            {
                db.Leaves.Update(leave);
                db.SaveChanges();

            }
        }
    }
}
