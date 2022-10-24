using Microsoft.EntityFrameworkCore;
using StudentGuidence.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGuidence.DataAccess.Data
{
    public class AppDbContext2 : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; Database=StudentGuidenceDb; Trusted_Connection=True;");
        }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Article> Articles { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
