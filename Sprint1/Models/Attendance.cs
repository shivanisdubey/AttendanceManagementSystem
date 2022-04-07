using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sprint1.Models
{
    [Keyless]
    public class Attendance
    {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public bool AttendanceCheck { get; set; }
        public Employee Employee { get; set; }//Navigation Property
    }
}
