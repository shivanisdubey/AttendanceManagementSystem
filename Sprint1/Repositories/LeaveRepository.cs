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
        public void AddLeave(int EmployeeId, DateTime LeaveStartDate, DateTime LeaveEndDate)
        {
            Employee e = db.Employee.Find(EmployeeId);
            if (e != null) {
                Leaves l = new Leaves();
                l.EmployeeId = EmployeeId;
                l.LeaveStartDate = LeaveStartDate;
                l.LeaveEndDate=LeaveEndDate;
                db.Leaves.Add(l);
            }
        }


        public List<Leaves> GetLeaves(int EmployeeId)
        {
                List<Leaves> leaves = (from i in db.Leaves where i.EmployeeId == EmployeeId select i).ToList();
                return leaves;
        }

        public List<Leaves> PendingLeaveRequest()
        {
            List<Leaves> l = (from n in db.Leaves where n.LeaveStatus == null select n).ToList();
            if (l != null)
            {
                return l;
            }
            return null;
        }

        public void PendingLeaveResponse(int LeaveId,string LeaveStatus)
        {
            Leaves l = db.Leaves.Find(LeaveId);
            if (l != null)
            {
                l.LeaveStatus= LeaveStatus;
                db.Leaves.Update(l);
                db.SaveChanges();
            }
        }

        public void RemoveLeave(int LeaveId)
        {
            Leaves l = db.Leaves.Find(LeaveId);
            if (l != null)
            {
                db.Leaves.Remove(l);
            }
            else
            {
                Console.WriteLine("Invalid LeaveId");
            }
        }


        public void UpdateLeave(int LeaveId, DateTime LeaveStartDate, DateTime LeaveEndDate)
        {
            Leaves l = db.Leaves.Find(LeaveId);
            if (l != null)
            {
                l.LeaveEndDate = LeaveEndDate;
                l.LeaveStartDate= LeaveStartDate;
                db.Leaves.Update(l);
                db.SaveChanges();
            }
        }
    }
}
