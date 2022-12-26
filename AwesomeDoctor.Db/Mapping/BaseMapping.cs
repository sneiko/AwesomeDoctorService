using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AwesomeDoctor.Db.Mapping;

public static class BaseMapping
{
    public static void BaseEntityMapping<T>(this EntityTypeBuilder<T> builder, string tableName) where T : BaseEntity
    {
        builder.ToTable(tableName);
        builder.HasKey(x => x.Id);
        builder.Property(x => x.IsDeleted);
        builder.Property(x => x.CreationDate);
    }
}
