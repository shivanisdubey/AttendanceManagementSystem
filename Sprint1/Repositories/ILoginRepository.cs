using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface ILoginRepository
    {
        bool CheckLogin(Login login);
    }
}
