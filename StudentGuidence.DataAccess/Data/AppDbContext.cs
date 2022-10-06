using Microsoft.EntityFrameworkCore;
using StudentGuidence.Models;
using System;
using System.Collections.Generic;
using System.Text;
//using StudentGuidence.Models;

namespace StudentGuidenc.DataAccess
{
    public  class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                       
           
        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Department> Departments { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Faculty>().Property(u => u.UniversityId).IsRequired(required: true);
            modelBuilder.Entity<Department>().Property(u => u.FacultyId).IsRequired();

        }
    }
}
