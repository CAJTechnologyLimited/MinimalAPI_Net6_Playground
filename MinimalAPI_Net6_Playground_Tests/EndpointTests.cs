using System.Net;
using System.Net.Http.Json;
using MinimalAPI_Net6_Playground.Data.Models;

namespace MinimalAPI_Net6_Playground_Tests;

public class EndpointTests
{
    [Fact]
    public async void Verify_Post_ReturnsSuccess()
    {
        await using var application = new ProductApplication();

        var client = application.CreateClient();

        var result = await client.PostAsJsonAsync("/products", new Product("Test Description", 1));

        Assert.Equal(HttpStatusCode.OK, result.StatusCode);
    }
}