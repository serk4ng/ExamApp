
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ExamApp.Core.Models;

namespace MyMusic.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(m => m.Id);

      
            builder
                .Property(m => m.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(m => m.Password);

            builder
                .ToTable("Users");
        }
    }
}