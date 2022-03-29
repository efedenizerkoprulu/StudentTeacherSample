using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Mappings
{
    public class LessonMap : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(t => t.ID);

            builder.Property(t => t.Name).HasMaxLength(50);
            builder.Property(t => t.IsActiveData).HasDefaultValue(true);

            builder.ToTable("Lessons");

            builder.Property(t => t.ID).HasColumnName("ID");
            builder.Property(t => t.TeacherID).HasColumnName("TeacherID");
            builder.Property(t => t.Name).HasColumnName("Name");

            builder.HasOne(x => x.Teacher).WithMany(y => y.Lessons).HasForeignKey(z => z.TeacherID);
        }
    }
}
