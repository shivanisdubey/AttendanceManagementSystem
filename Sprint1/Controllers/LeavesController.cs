using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sprint1.Controllers;
using Sprint1.Repositories;
using Sprint1.Models;


namespace Sprint1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavesController : ControllerBase
    {
        private readonly ILeaveRepository LeaveRepository;

        public LeavesController(ILeaveRepository leaveRepository)
        {
            this.LeaveRepository = leaveRepository;
        }
        //EndPoints
        [HttpGet]
        [Route("Get leaves by id/{employeeid}")]
        public List<Leaves> GetLeaves(int EmployeeId)
        {
            return LeaveRepository.GetLeaves(EmployeeId);
        }
        [HttpPost]
        [Route("add leave")]
        public void AddLeave(int EmployeeId, DateTime LeaveStartDate, DateTime LeaveEndDate)
        {
            LeaveRepository.AddLeave(EmployeeId, LeaveStartDate, LeaveEndDate);
        }
        //[HttpDelete]
        //public void DeleteLeavesRequest(Leaves leave)
        //{

        //    LeaveRepository.DeleteLeaves(leave);
        //}
        [HttpPut]
        [Route("update leaves")]
        public void UpdateLeave(int LeaveId, DateTime LeaveStartDate, DateTime LeaveEndDate)
        {

            LeaveRepository.UpdateLeave(LeaveId, LeaveStartDate,LeaveEndDate);
        }
        
        [HttpPost]
        [Route("view pendingleavesResponse")]
        public void PendingLeaveResponse(int LeaveId,string LeaveStatus)
        {
            LeaveRepository.PendingLeaveResponse(LeaveId,LeaveStatus);
        }
        [HttpGet]
        [Route("Get pendingLeaves/{pendingleaverequest}")]
        public List<Leaves> PendingLeaveRequest()
        {
            return LeaveRepository.PendingLeaveRequest();
        }
    }
}