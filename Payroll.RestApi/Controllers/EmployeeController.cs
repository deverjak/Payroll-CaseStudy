using Microsoft.AspNetCore.Mvc;
using Payroll.Application;
using Payroll.Domain;
using Payroll.RestApi.Models;

namespace Payroll.RestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult SaveEmployee([FromBody] EmployeeModel model)
        {
            if (model == null)
            {
                return BadRequest("Employee data is required");
            }

            var employee = new Employee(model.EmployeeId, model.Name, model.Salary);
            InMemoryDatabase.AddEmployee(model.EmployeeId, employee);
            return Ok();
        }
    }
}