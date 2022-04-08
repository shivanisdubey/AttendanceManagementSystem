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
        private SprintDbContext dbContext = null;


        public EmployeeRepository(SprintDbContext dbContext) //Constructor
        {
            this.dbContext = dbContext;
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
        }

        public void DeleteEmployeeByName(string name) //
        {
            Employee employee = dbContext.Employee.Find(name);
            dbContext.Remove(employee);

        }

        public Employee GetEmployeeById(int EmployeeId)
        {
            return dbContext.Employee.Find(EmployeeId);

        }

        public Employee GetEmployeeByName(string name)
        {
            return dbContext.Employee.Find(name);
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employee = (from i in dbContext.Employee select i).ToList();
            return employee;
        }


        public List<Employee> GetEmployeesByDepartment(string department)
        {
            List<Employee> employee = (from e in dbContext.Employee where e.EmployeeDepartment == department select e).ToList();
            return employee;
        }

        public List<Employee> GetEmployeesByDesignation(string designation)
        {
            List<Employee> employee = (from e in dbContext.Employee where e.EmployeeDesignation == designation select e).ToList();
            return employee;
        }

        public void UpdateEmployeeById(Employee employee)
        {
            dbContext.Employee.Update(employee);
            dbContext.SaveChanges();
        }

        public void UpdateEmployeeByName(Employee employee)
        {
            dbContext.Employee.Update(employee);
            dbContext.SaveChanges();

        }
    }


}
