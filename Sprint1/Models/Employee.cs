using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }
        public string EmployeeEmailId { get; set; }

        public DateTime EmployeeDOB { get;set;}
        public string EmployeeName { get; set; }

        public string EmployeeDesignation { get; set; }

        public string EmployeeDepartment { get; set; }
    }
}
