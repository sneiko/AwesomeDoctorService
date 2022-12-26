﻿using Microsoft.AspNetCore.Mvc;

namespace AwesomeDoctor.Web.Controllers;


[ApiController]
[Route("/api/v1/[controller]")]
public class BaseController: ControllerBase
{
    private readonly ILogger<BaseController> _logger;

    public BaseController(ILogger<BaseController> logger)
    {
        _logger = logger;
    }
}
