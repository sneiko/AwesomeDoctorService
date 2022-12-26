using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AwesomeDoctor.Db.Mapping;

public class UserMapping: IEntityTypeConfiguration<User>
{
    public readonly string TableName = "users";

    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.BaseEntityMapping(TableName);

        builder.Property(x => x.FirstName);
        builder.Property(x => x.LastName);
        builder.Property(x => x.PasswordHash);

        builder.HasDiscriminator(x => x.IsDoctor)
            .HasValue<User>(false)
            .HasValue<Doctor>(true);
    }
}
