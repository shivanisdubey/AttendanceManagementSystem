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
        public void AddLeave(Leaves leave)
        {
            LeaveRepository.AddLeave(leave);
        }
        //[HttpDelete]
        //public void DeleteLeavesRequest(Leaves leave)
        //{

        //    LeaveRepository.DeleteLeaves(leave);
        //}
        [HttpPut]
        [Route("update leaves")]
        public void UpdateLeave(Leaves leave)
        {

            LeaveRepository.UpdateLeave(leave);
        }
        [HttpPut]
        [Route("set leavesStatus")]
        public void SetStatus(int LeaveId, bool status)
        {
            LeaveRepository.SetStatus(LeaveId, status);
        }
        [HttpPost]
        [Route("view pendingleaves/{employeeId}")]
        public List<Leaves> PendingLeaveRequest(int employeeId)
        {
            return LeaveRepository.PendingLeaveRequest(employeeId);
        }


    }
}