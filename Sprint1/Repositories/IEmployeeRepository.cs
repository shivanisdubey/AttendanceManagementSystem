using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        void DeleteEmployeeById(int id);
        void UpdateEmployee(string EmployeeName,string EmployeeEmailId,DateTime EmployeeDOB,string EmployeeDesignation,string EmployeeDepartment);
        
        
    }
}
