using Microsoft.AspNetCore.Mvc.Testing;

namespace Payroll.RestApi.Tests;

public class HomePageTest
{
    [Fact]
    public async Task HomeReturnsJson()
    {
        using var factory = new WebApplicationFactory<Startup>();
        var client = factory.CreateClient();

        using var request = new HttpRequestMessage(HttpMethod.Get, new Uri("", UriKind.Relative));
        request.Headers.Accept.ParseAdd("application/json");

        var response = await client.SendAsync(request);

        Assert.True(
            response.IsSuccessStatusCode,
            $"Actual status code: {response.StatusCode}.");
        Assert.Equal("application/json",
            response.Content.Headers.ContentType?.MediaType);
    }
}