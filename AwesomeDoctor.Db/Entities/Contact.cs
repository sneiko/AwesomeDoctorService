using AwesomeDoctor.Db.Entities.Enums;

namespace AwesomeDoctor.Db.Entities;

public class Contact: BaseEntity
{
    public ContactType Type { get; set; }
    public string Value { get; set; }
}
