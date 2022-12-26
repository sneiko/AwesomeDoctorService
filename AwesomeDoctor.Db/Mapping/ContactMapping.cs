using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AwesomeDoctor.Db.Mapping;

public class ContactMapping: IEntityTypeConfiguration<Contact>
{
    public readonly string TableName = "contacts";

    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.BaseEntityMapping(TableName);

        builder.Property(x => x.Type);
        builder.Property(x => x.Value);
    }
}
