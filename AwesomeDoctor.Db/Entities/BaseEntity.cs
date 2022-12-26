namespace AwesomeDoctor.Db.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
}
