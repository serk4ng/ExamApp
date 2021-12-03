using ExamApp.Core.Models;
using ExamApp.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyMusic.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite($"Data Source=exam.db");

            }
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<User>().HasData(new User { Id = 123, Username = "sa", Password = "123", Status = true, CreationDate = DateTime.Now, UpdateDate = DateTime.Now });

            base.OnModelCreating(builder);

            builder
                .ApplyConfiguration(new UserConfiguration());
            builder
            .ApplyConfiguration(new QuestionConfiguration());
            builder
            .ApplyConfiguration(new ExamConfiguration());
            builder
            .ApplyConfiguration(new QuestionOptionConfiguration());

        }

        
    }
}
