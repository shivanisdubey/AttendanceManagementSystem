using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sprint1.Models
{
    public class EmployeeProject
    {
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [Key]
        public int EmployeeProjectId { get; set; }
        public string ProjectName { get; set; }
        public Project Project { get; set; }//Navigation Property
        public Employee Employee { get; set; }//Navigation Property
    }
}
