using Microsoft.EntityFrameworkCore;
using S1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S1.Context
{
    internal class CompanyG01DBContext : DbContext
    {

        public CompanyG01DBContext() : base()
        {
               
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = .;intial Catalog = CompanyG01;integraded Security = true");

            optionsBuilder.UseSqlServer("Server = .;Database = CompanyG01;Trusted_Connection = True;TrustServerCertificate = true");

        }

        public DbSet<Employee> Employees { get; set; }

    }
}
