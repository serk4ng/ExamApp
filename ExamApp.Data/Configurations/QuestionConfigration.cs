using ExamApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Data.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder
                .HasKey(m => m.Id);


            builder
                .Property(m => m.Title)
                .IsRequired();

            builder
               .Property(m => m.ExamId)
               .IsRequired();

            builder
                .ToTable("Questions");
        }
    }
}
