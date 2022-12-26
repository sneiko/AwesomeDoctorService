namespace AwesomeDoctor.Db.Entities;

public class UserContact: BaseEntity
{
    public int UserId { get; set; }
    public int ContactId { get; set; }

    public virtual User User { get; set; }
    public virtual Contact Contact { get; set; }
}
