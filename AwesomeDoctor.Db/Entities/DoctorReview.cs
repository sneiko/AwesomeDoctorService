namespace AwesomeDoctor.Db.Entities;

public class DoctorReview : BaseEntity
{
    public int Score { get; set; }
    public string? Description { get; set; }
    public bool IsRecommended { get; set; }

    public int DoctorId { get; set; }
    public virtual Doctor Doctor { get; set; }

    public int UserId { get; set; }
    public virtual User User { get; set; }
}
