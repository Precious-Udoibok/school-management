
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Domain;
using System;

namespace SchoolManagement.Persistence
{
    public class SchoolManagementDbContext : DbContext
    {
        public SchoolManagementDbContext(DbContextOptions<SchoolManagementDbContext>options) : base(options)
        {
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //Creating the tables
        public DbSet<Course> Courses { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<CourseRegistration> CourseRegistrations { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Hostel> Hostels { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<SchoolPortal> SchoolPortals { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
