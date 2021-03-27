using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CURD27.Models
{
    public class EmployeeDataContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }
    }
}