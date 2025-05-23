using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StudentSystem.Data
{
     class StudentSysytemContext : DbContext
    {

        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Resources> Resources { get; set; }
        public DbSet<HomeWorks> HomeWorks { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Database=School;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Students>()
                .Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(true);


            modelBuilder.Entity<Students>()
                .Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsRequired(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Birthday)
                .IsRequired(false);
           

            modelBuilder.Entity<Courses>()
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Courses>()
                .Property(e => e.Description)
                .IsUnicode(true)
                .IsRequired(false);

            modelBuilder.Entity<Resources>()
                .Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Resources>()
                .Property(e => e.Url)
                .IsUnicode(false);

            modelBuilder.Entity<HomeWorks>()
                .Property(e => e.Content)
                .IsUnicode(false);
                

        }

    }
}
