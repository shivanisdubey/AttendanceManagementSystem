using System;
using System.Collections.Generic;
using Sprint1.Models;
using Sprint1.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Sprint1.Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly SprintDbContext db;
        public AttendanceRepository()
        {
            this.db = new SprintDbContext();
        }
        public void AddAttendance(int employeeId, DateTime AttendanceDate, bool AttendanceCheck)
        {
                EmployeeProject e=(from p in db.EmployeeProject where p.EmployeeId==employeeId select p).Single();
                if (e != null)
                {
                    Attendance attendance = new Attendance();
                    attendance.EmployeeId = employeeId;
                    attendance.AttendanceDate = AttendanceDate;
                    attendance.AttendanceCheck = AttendanceCheck;
                    db.Attendance.Add(attendance);
                    db.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Invalid Employee Id");
                }
        }

        public void DeleteAttendance(int AttendanceId)
        {
            Attendance attendance=db.Attendance.Find(AttendanceId);
            if (attendance != null)
            {
                db.Remove(attendance);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Invalid Attendance Id");
            }
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

        public void UpdateAttendance(int EmployeeId, DateTime Date,bool AttendanceCheck)
        {
            List<Attendance> attendance = (from a in db.Attendance where a.EmployeeId == EmployeeId select a).ToList();
            if (attendance != null)
            {
                Attendance a=(from b in attendance where b.AttendanceDate==Date select b).Single();
                    a.AttendanceCheck = AttendanceCheck;
                    db.Update(a);
                    db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Invalid Attendance Id");
            }
        }
    }
}
