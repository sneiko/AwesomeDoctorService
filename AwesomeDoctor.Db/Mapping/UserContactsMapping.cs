using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AwesomeDoctor.Db.Mapping;

public class UserContactsMapping: IEntityTypeConfiguration<UserContact>
{
    public readonly string TableName = "user_contacts";

    public void Configure(EntityTypeBuilder<UserContact> builder)
    {
        builder.BaseEntityMapping(TableName);

        builder.Property(x => x.UserId);
        builder.Property(x => x.ContactId);

        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasIndex(x => x.UserId);

        builder.HasOne(x => x.Contact)
            .WithMany()
            .HasForeignKey(x => x.ContactId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasIndex(x => x.ContactId);

        builder.HasIndex(x => new { x.UserId, x.ContactId });
    }
}
