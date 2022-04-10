using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sprint1.Models;
using Sprint1.Repositories;
using System;
using System.Collections.Generic;

namespace Sprint1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public AttendanceController(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        } 
        [HttpGet]
        [Route("Get by id/{employeeid}")]
        public List<Attendance> GetAttendance(int EmployeeId)
        {
            return _attendanceRepository.GetAttendance(EmployeeId);
        }
        [HttpGet]
        [Route("Get by date/{date}")]
        public Attendance GetAttendanceByDate(int Id, DateTime date)
        {
            return _attendanceRepository.GetAttendanceByDate(Id, date);
        }
        [HttpGet]
        [Route("Get by month/{month}")]
        public List<Attendance> GetAttendanceByMonth(int EmployeeId, int month, int year)
        {
            return _attendanceRepository.GetAttendanceByMonth(EmployeeId, month, year);
        }
        [HttpGet]
        [Route("Get by year/{year}")]
        public List<Attendance> GetAttendanceByYear(int EmployeeId, int year)
        {
            return _attendanceRepository.GetAttendanceByYear(EmployeeId, year);
        }
        [HttpPut]
        [Route("update attendance")]
        public IActionResult UpdateAttendance(int EmployeeId, DateTime Date,bool AttendanceCheck)
        {
            try
            {
                _attendanceRepository.UpdateAttendance(EmployeeId, Date,AttendanceCheck);
                return Ok("executed");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("add attendance")]
        public IActionResult AddAttendance(int employeeId, DateTime AttendanceDate, bool AttendanceCheck)
        {
            try
            {
                _attendanceRepository.AddAttendance(employeeId, AttendanceDate, AttendanceCheck);
                return Ok("executed");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("delete attendance/{AttendanceId}")]
        public void DeleteAttendance(int AttendanceId)
        {
            _attendanceRepository.DeleteAttendance(AttendanceId);
        }
    }
}
