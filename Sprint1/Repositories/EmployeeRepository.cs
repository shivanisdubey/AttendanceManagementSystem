using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sprint1.Models;
using Sprint1.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Sprint1
{

    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly SprintDbContext dbContext;


        public EmployeeRepository() //Constructor
        {
            this.dbContext = new SprintDbContext();
        }
        public void AddEmployee(Employee employee) //Add Employees all fields
        {
            dbContext.Employee.Add(employee);
            dbContext.SaveChanges();
        }

        public void DeleteEmployeeById(int EmployeeId)
        {
            Employee employee = dbContext.Employee.Find(EmployeeId);
            dbContext.Remove(employee);
            dbContext.SaveChanges();
        }
        public Employee GetEmployeeById(int EmployeeId)
        {
            return dbContext.Employee.Find(EmployeeId);

        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employee = (from i in dbContext.Employee select i).ToList();
            return employee;
        }
        public void UpdateEmployee(string EmployeeName,string EmployeeEmailId, DateTime EmployeeDOB, string EmployeeDesignation, string EmployeeDepartment)
        {
            Employee e = (from em in dbContext.Employee where em.EmployeeName ==EmployeeName select em).Single();
            e.EmployeeDOB = EmployeeDOB;
            e.EmployeeDesignation = EmployeeDesignation;
            e.EmployeeDepartment = EmployeeDepartment;
            e.EmployeeEmailId=EmployeeEmailId;
            dbContext.SaveChanges();
        }

    }


}
