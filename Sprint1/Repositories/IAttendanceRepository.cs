using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IAttendanceRepository
    {
        void AddAttendance(int employeeId,DateTime AttendanceDate,bool AttendanceCheck);
        void UpdateAttendance(int EmployeeId,DateTime Date,bool AttendanceCheck);
        void DeleteAttendance(int AttendanceId);
        List<Attendance> GetAttendanceByMonth(int EmployeeId,int month,int year);
        List<Attendance> GetAttendanceByYear(int EmployeeId, int year);
        Attendance GetAttendanceByDate(int EmployeeId,DateTime date);
        List<Attendance> GetAttendance(int EmployeeId);
    }
}
