using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CourseAcademyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CourseAcademy;Trusted_Connection=true");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
