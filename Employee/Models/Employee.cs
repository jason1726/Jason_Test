using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Employee.Models
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpTel { get; set; }
        public string EmpAddress { get; set; }
    }

    public class EmpDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}