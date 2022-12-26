namespace AwesomeDoctor.Web.Controllers.Search.Models;

public class SearchDoctors
{
    public List<int> DoctorsIds { get; set; }
    public List<int> LocationsIds { get; set; }
    public List<int> DirectionsIds { get; set; }
}
