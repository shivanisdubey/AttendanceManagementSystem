using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface ILeaveRepository
    {
        void AddLeave(int EmployeeId,DateTime LeaveStartDate,DateTime LeaveEndDate);
        void RemoveLeave(int LeaveId);
        void UpdateLeave(int LeaveId, DateTime LeaveStartDate, DateTime LeaveEndDate);
        List<Leaves> GetLeaves(int EmployeeId);
        List<Leaves> PendingLeaveRequest();
        void PendingLeaveResponse(int LeaveId,string LeaveStatus);
    }
}
