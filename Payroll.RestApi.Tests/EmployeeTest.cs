using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Payroll.Application;
using Payroll.Domain;

namespace Payroll.RestApi.Tests;
public class EmployeeTest
{
    [Fact]
    public async Task SendDataAreSaveToInMemoryDb()
    {
        using var factory = new WebApplicationFactory<Startup>();
        var client = factory.CreateClient();

        Guid employeeId = Guid.NewGuid();
        var employeeData = new
        {
            employeeId = employeeId.ToString(),
            name = "John Smith",
            salary = 1000
        };
        var jsonString = JsonSerializer.Serialize(employeeData);

        using var request = new HttpRequestMessage(HttpMethod.Post, new Uri("api/employee/add", UriKind.Relative));
        request.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");
        request.Headers.Accept.ParseAdd("application/json");

        var response = await client.SendAsync(request);
        var responseBody = await response.Content.ReadAsStringAsync();
        var savedEmployee = InMemoryDatabase.GetEmployee(employeeId);

        Assert.True(
            response.IsSuccessStatusCode,
            $"Actual status code: {response.StatusCode}.");
        Assert.Equal("application/json",
            response.Content.Headers.ContentType?.MediaType);
        Assert.Equal("John Smith", savedEmployee.Name);

    }
}
