﻿using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface ILeaveRepository
    {
        void AddLeave(Leaves leave);
        void RemoveLeave(Leaves leave);
        void UpdateLeave(Leaves leave);
        List<Leaves> GetLeaves(int EmployeeId);
    }
}
