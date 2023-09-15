using Microsoft.AspNetCore.Mvc;

namespace Payroll.RestApi.Controllers;

[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { project = "Hello world" });
    }
}

