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
    public class TeacherMap:IEntityTypeConfiguration<Teacher>
    {
        public void  Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t=> t.Name).HasMaxLength(20);
            builder.Property(t => t.Surname).HasMaxLength(20);
            builder.Property(t => t.Email).HasMaxLength(75);
            builder.Property(t => t.Phone).HasMaxLength(15);
            builder.Property(t => t.StartedDate).HasDefaultValueSql("GETDATE()");

            builder.ToTable("Teachers");

            builder.Property(t=> t.Id).HasColumnName("ID");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Surname).HasColumnName("Surname");
            builder.Property(t => t.Email).HasColumnName("Email");
            builder.Property(t => t.Phone).HasColumnName("Phone");
            builder.Property(t => t.StartedDate).HasColumnName("StartedDate");
        }
    }
}
