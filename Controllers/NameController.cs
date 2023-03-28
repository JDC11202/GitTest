using Microsoft.AspNetCore.Mvc;

namespace GitTest.Controllers;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{

    private readonly ILogger<NameController> _logger;

    public NameController(ILogger<NameController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetName")]
    public IActionResult Get()
    {
        var personName = new Name { PersonName = "Jacob Collier"};
        return Ok(personName);
    }
}
