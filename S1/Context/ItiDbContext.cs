using Microsoft.EntityFrameworkCore;
using S1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1.Context
{
    internal class ItiDbContext : DbContext
    {
        public ItiDbContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .;Database = Iti;Trusted_Connection = True;TrustServerCertificate = true");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Course_Inst> Course_Inst { get; set; }


    }
}
