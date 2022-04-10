using System;
using System.Collections.Generic;
using Sprint1.Models;
using Sprint1.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Sprint1.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly SprintDbContext db;
        public LoginRepository()
        {
            this.db = new SprintDbContext();
        }
        public bool CheckLogin(string Role, int EmployeeId, string Password)
        {
            Login l = db.Login.Find(EmployeeId);
            if (l != null)
            {
                Login l1 = new Login();
                l1.Role = Role;
                l1.EmployeeId = EmployeeId;
                l1.Password=Password;
                if (l.Equals(l1))
                {
                    return true;
                }
            }
            return false;
        }
    }
}