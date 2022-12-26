using AwesomeDoctor.Web.Controllers.Search.Models;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeDoctor.Web.Controllers.Search;

public class SearchController: BaseController
{
    public SearchController(ILogger<SearchController> logger) : base(logger)
    {
    }

    [HttpGet("/doctors")]
    public IActionResult Doctors(SearchDoctors model, CancellationToken cancellationToken)
    {
        return Ok();
    }
}
