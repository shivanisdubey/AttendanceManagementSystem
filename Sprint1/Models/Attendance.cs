using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sprint1.Models
{
    public class Attendance
    {
        [ForeignKey("EmployeeId")]
        public  int EmployeeId { get; set; }
        [Key]
        public int AttendanceId { get; set; }
        public DateTime AttendanceDate { get;set;}
        public bool AttendanceCheck { get; set; }
        public Employee Employee { get; set; }//Navigation Property
    }
}
