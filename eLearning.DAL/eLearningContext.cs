using eLearning.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eLearning.DAL
{
    public class eLearningContext : DbContext
    {
        public eLearningContext() : base() { }

        public DbSet<Professor> Professors { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<StudentSubject> Notification { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) /* port = 5432*/
        {
            optionBuilder.UseNpgsql("User ID = postgres; Password = 0000; Server = localhost; Port = 5432 ; Database = eLearning; Integrated Security = true; Pooling = true;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Section>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Professor>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Student>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<Subject>().HasQueryFilter(x => !x.Deleted);
            builder.Entity<School>().HasQueryFilter(x => !x.Deleted);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted && x.Entity is BaseClass))
            {
                entry.State = EntityState.Modified;
                entry.CurrentValues["Deleted"] = true;
            }
            return base.SaveChanges();
        }

    }
}
