using ExamApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamApp.Data.Configurations
{
    public class QuestionOptionConfiguration : IEntityTypeConfiguration<QuestionOption>
    {
        public void Configure(EntityTypeBuilder<QuestionOption> builder)
        {
            builder
                .HasKey(m => m.Id);


            builder
                .Property(m => m.Title)
                .IsRequired();

            builder
               .Property(m => m.Option)
               .IsRequired();
           

            builder
                .ToTable("QuestionOptions");
        }
    }
}
