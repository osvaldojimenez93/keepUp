using Microsoft.AspNetCore.Mvc;

namespace keepUp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("KeepUp API is running!");
    }
}
