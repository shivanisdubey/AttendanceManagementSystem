using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sprint1.Models
{
    [Keyless]
    public class Login
    {
        public string Role { get; set; }//Admin or Employee
        public int EmployeeId { get; set; }
        public string Password { get; set; }
    }
}
