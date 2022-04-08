using System;
using System.Collections.Generic;
using Sprint1.Models;
using Sprint1.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Sprint1.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly SprintDbContext db;
        public AttendanceRepository()
        {
            this.db = new SprintDbContext();
        }
        public void AddAttendance(Attendance attendance)
        {
            db.Attendance.Add(attendance);
            db.SaveChanges();
        }

        public void DeleteAttendance(Attendance attendance)
        {
            db.Remove(attendance);
            db.SaveChanges();
        }

        public List<Attendance> GetAttendance(int EmployeeId)
        {
            List<Attendance> attendances = (from p in db.Attendance where p.EmployeeId == EmployeeId select p).ToList();
            return attendances;
        }

        public Attendance GetAttendanceByDate(int Id, DateTime date)
        {
            Attendance attendance = (from p in db.Attendance where p.EmployeeId == Id where p.AttendanceDate == date select p).Single();
            return attendance;
        }

        public List<Attendance> GetAttendanceByMonth(int EmployeeId, int month, int year)
        {
            DateTime today = DateTime.Today;
            List<Attendance> attendances = (from p in db.Attendance where p.EmployeeId == EmployeeId where p.AttendanceDate.Month == month where p.AttendanceDate.Year==year select p).ToList();
            return attendances;
        }

        public List<Attendance> GetAttendanceByYear(int EmployeeId, int year)
        {
            DateTime today = DateTime.Today;
            List<Attendance> attendances = (from p in db.Attendance where p.EmployeeId == EmployeeId where p.AttendanceDate.Year == year select p).ToList();
            return attendances;
        }

        public void UpdateAttendance(Attendance attendance)
        {
            db.Update(attendance);
            db.SaveChanges();
        }
    }
}
