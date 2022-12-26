namespace AwesomeDoctor.Db.Entities;

public class Doctor: User
{
    public string Description { get; set; }

    public int LocationId { get; set; }
    public virtual Location Location { get; set; }
}
