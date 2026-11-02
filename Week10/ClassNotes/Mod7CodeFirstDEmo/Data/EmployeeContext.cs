using Microsoft.EntityFrameworkCore;
using Mod7CodeFirstDEmo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod7CodeFirstDEmo.Data
{
    //represents db
    public  class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }// represents Employee table
        public DbSet<Department> Departments { get; set; }//represents Dept table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LAPTOP-76KFFC21;initial catalog=CCAD23Employees;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }
        //data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId=1, DepartmentName="HR", Location="NY"},
                new Department { DepartmentId =2, DepartmentName = "Marketing", Location = "NC" },
                new Department { DepartmentId = 3, DepartmentName = "SE", Location = "NY" }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId=101, DepartmentId=1, EmployeeName="Amy Faber", Salary=70000}
                );
        }


    }
}
