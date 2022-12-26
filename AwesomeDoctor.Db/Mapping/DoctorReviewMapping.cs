using AwesomeDoctor.Db.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AwesomeDoctor.Db.Mapping;

public class DoctorReviewMapping: IEntityTypeConfiguration<DoctorReview>
{
    public readonly string TableName = "doctor_reviews";
    public void Configure(EntityTypeBuilder<DoctorReview> builder)
    {
        builder.BaseEntityMapping(TableName);

        builder.Property(x => x.Score);
        builder.Property(x => x.Description);
        builder.Property(x => x.IsRecommended);

        builder.Property(x => x.DoctorId);
        builder.HasOne(x => x.Doctor)
            .WithMany()
            .HasForeignKey(x => x.DoctorId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasIndex(x => x.DoctorId);

        builder.Property(x => x.UserId);
        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        builder.HasIndex(x => x.UserId);

        builder.HasIndex(x => new { x.DoctorId, x.UserId });
    }
}
