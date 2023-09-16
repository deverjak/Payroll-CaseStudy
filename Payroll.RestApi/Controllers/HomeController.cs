using Microsoft.AspNetCore.Mvc;
using Payroll.Application;
using Payroll.Domain;

namespace Payroll.RestApi.Controllers;

[ApiController]
[Route("api/")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { project = "Hello world" });
    }
    [HttpGet("test")]
    public IActionResult TestInMemoryDb()
    {
        var id = Guid.NewGuid();
        var e = new Employee(id, "John Smith", 1000);
        InMemoryDatabase.AddEmployee(id, e);

        return Ok();
    }
}

