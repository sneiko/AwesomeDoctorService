namespace AwesomeDoctor.Db.Entities;

public class Location: BaseEntity
{
    public string Name { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}
