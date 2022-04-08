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
        [HttpPost]
        [Route("update attendance")]
        public void UpdateAttendance(Attendance attendance)
        {
            _attendanceRepository.UpdateAttendance(attendance);
        }
        [HttpPost]
        [Route("add attendance")]
        public void AddAttendance(Attendance attendance)
        {
            _attendanceRepository.AddAttendance(attendance);
        }
        [HttpPost]
        [Route("delete attendance")]
        public void DeleteAttendance(Attendance attendance)
        {
            _attendanceRepository.DeleteAttendance(attendance);
        }
    }
}
