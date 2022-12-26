using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AwesomeDoctor.Db.Mapping;

public class LocationMapping: IEntityTypeConfiguration<Location>
{
    public readonly string TableName = "locations";

    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.BaseEntityMapping(TableName);

        builder.Property(x => x.Name);
        builder.Property(x => x.Latitude);
        builder.Property(x => x.Longitude);

        builder.HasIndex(x => x.Name);
        builder.HasIndex(x => new { x.Latitude, x.Longitude });
    }
}
