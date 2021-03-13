//tinfo200:[2020-03-12-tgoddard-dykstra1] -- initial creation of the 'context' for the school database. This class is essential for the coordination of functions in the Entity Framework and denotes what classes are a part of the overall data model.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;


namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //tinfo200:[2020-03-12-tgoddard-dykstra1] -- 
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }


        //tinfo200:[2020-03-12-tgoddard-dykstra1] -- this method creates tables with the names specified in .ToTable()
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
