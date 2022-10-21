using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentGuidence.Models;
using System;
using System.Collections.Generic;
using System.Text;
//using StudentGuidence.Models;

namespace StudentGuidenc.DataAccess
{
    public  class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

            
        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Admin> Admins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(u => u.FacultyId).IsRequired();   
            modelBuilder.Entity<University>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Faculty>().HasIndex(u => u.Name).IsUnique();
            modelBuilder.Entity<Department>().HasIndex(u => u.Name).IsUnique();

            modelBuilder.Entity<University>().Property(u => u.Establishment).HasColumnType("Date");
            modelBuilder.Entity<Article>().Property(u => u.DateOfIssue).HasColumnType("Date");
            modelBuilder.Entity<Student>().Property(u => u.UniversityStartDate).HasColumnType("Date");
            modelBuilder.Entity<ApplicationUser>().HasIndex(u => u.Email).IsUnique(unique: true);
            //DateTime d = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            //modelBuilder.Entity<University>().Property(u => u.Establishment).HasDefaultValue(d);
            base.OnModelCreating(modelBuilder);

        }
    }
}
