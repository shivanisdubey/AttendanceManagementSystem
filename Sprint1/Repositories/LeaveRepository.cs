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
        private readonly SprintDbContext db;
        public LeaveRepository()
        {
            this.db = new SprintDbContext();
        }
        public void AddLeave(Leaves leave)
        {
                db.Leaves.Add(leave);
                db.SaveChanges();
        }


        public List<Leaves> GetLeaves(int EmployeeId)
        {
                List<Leaves> leaves = (from i in db.Leaves where i.EmployeeId == EmployeeId select i).ToList();
                return leaves;
        }

        public List<Leaves> PendingLeaveRequest(int employeeId)
        {
            List<Leaves> leaves = (from i in db.Leaves where i.EmployeeId == employeeId where i.Leavestatus !=true where i.Leavestatus != false select i).ToList();
            return leaves;
        }

        public void RemoveLeave(Leaves leave)
        {
                db.Leaves.Remove(leave);
                db.SaveChanges();
        }

        public void RemoveLeave(int LeaveId)
        {
            throw new NotImplementedException();
        }

        public void SetStatus(int LeaveId,bool status)
        {
            Leaves leave = db.Leaves.Find(LeaveId);
            leave.Leavestatus=status;
            db.Leaves.Update(leave);

        }

        public void UpdateLeave(Leaves leave)
        {
                db.Leaves.Update(leave);
                db.SaveChanges();
        }
    }
}
