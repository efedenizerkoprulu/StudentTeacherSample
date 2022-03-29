using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Mappings
{
    public class StudentMap:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(t => t.ID);

            builder.Property(t => t.Name).HasMaxLength(20);
            builder.Property(t=> t.Surname).HasMaxLength(20);
            builder.Property(t => t.Email).HasMaxLength(75);
            builder.Property(t => t.StudentClass).HasMaxLength(10);
            builder.Property(t => t.StudentNo).HasMaxLength(10);

            builder.ToTable("Students");

            builder.Property(t=> t.ID).HasColumnName("ID");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Surname).HasColumnName("Surname");
            builder.Property(t => t.Email).HasColumnName("Email");
            builder.Property(t => t.StudentClass).HasColumnName("StudentClass");
            builder.Property(t => t.StudentNo).HasColumnName("StudentNo");
        }
    }
}
