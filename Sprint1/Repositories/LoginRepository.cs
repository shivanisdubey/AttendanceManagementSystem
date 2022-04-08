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
        public bool CheckLogin(Login login)
        {
            var res = db.Login.Where(x => x.EmployeeId == login.EmployeeId && x.Password == login.Password).ToList();
            if (res != null && res.Count == 1)
            {
                return true;
            }
            return false;
        }
    }
}