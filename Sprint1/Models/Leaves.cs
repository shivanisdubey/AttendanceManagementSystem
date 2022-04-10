using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sprint1.Models
{
    [Keyless]
    public class Leaves
    {
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        private int LeaveId { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public Employee Employee { get; set; }//Navigation Property
        public string LeaveStatus { get; set; }
    }
}
