using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AwesomeDoctor.Db.Mapping;

public class DoctorMapping: IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.Property(x => x.Description);
        builder.Property(x => x.LocationId);

        builder.HasOne(x => x.Location)
            .WithMany()
            .HasForeignKey(x => x.LocationId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasIndex(x => x.LocationId);
    }
}
