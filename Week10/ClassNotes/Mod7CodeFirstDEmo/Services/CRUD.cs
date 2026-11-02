using Microsoft.EntityFrameworkCore.Storage;
using Mod7CodeFirstDEmo.Data;
using Mod7CodeFirstDEmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7CodeFirstDEmo.Services
{
    public class CRUD
    {
        public void AddEmployee(Employee emp)
        {
            Records.context.Employees.Add(emp);// adding the record in dbset
            Records.context.SaveChanges();//save changes to db
        }

        public List<Employee> GetEmployees()
        {
            return Records.context.Employees.ToList();
        }
        public List<Department>GetDepartments()
        {
            return Records.context.Departments.ToList();
        }
        public void DeleteEmployee(int id)
        {
            var emp = Records.context.Employees.Find(id);
            if(emp!=null)
            {
                Records.context.Employees.Remove(emp);
                Records.context.SaveChanges();
            }

        }
        public void UpdateEmployee(int id, Employee changedemp)
        {
            var existingemp = Records.context.Employees.Find(id);
            if(existingemp!=null)
            {
                existingemp.EmployeeName = changedemp.EmployeeName;
                existingemp.Salary = changedemp.Salary;
                existingemp.DepartmentId = changedemp.DepartmentId;
                Records.context.SaveChanges();
            }
        }

        public Employee? GetEmployee(int id)
        {
            return Records.context.Employees.Find(id);
        }


    }
}
