using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sprint1.Models
{
    public class Login
    {
        public string Role { get; set; }//Admin or Employee
        public int Id { get; set; }
        public string Password { get; set; }
    }
}
