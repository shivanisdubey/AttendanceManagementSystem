using System;
using System.Collections.Generic;
using Sprint1.Models;

namespace Sprint1.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        List<Employee> GetEmployeesByDesignation(string designation);
        List<Employee> GetEmployeesByDepartment(string department);
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        Employee GetEmployeeByName(string name);
        void DeleteEmployeeById(int id);
        void DeleteEmployeeByName(string name);
        void UpdateEmployeeById(Employee employee);
        void UpdateEmployeeByName(Employee employee);
        
    }
}
