using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    internal class Program
    {
        public class EmployeeDbContext : DbContext
        {
            public DbSet<Employee> Employees { get; set; }
        }

        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
