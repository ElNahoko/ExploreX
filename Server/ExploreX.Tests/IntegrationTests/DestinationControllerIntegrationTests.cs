using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Xunit;

public class DestinationControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;

    public DestinationControllerIntegrationTests(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task CreateDestination_EndpointReturnsSuccess()
    {
        var request = new StringContent(JsonConvert.SerializeObject(new
        {
            Name = "Sample Destination",
            Description = "Sample Description",
            ImageURL = "https://www.sample.com/image.jpg",
            VideoURL = "https://www.sample.com/video.mp4",
            Country = "Sample Country",
            Region = "Sample Region",
            FunFacts = "Sample Fun Facts",
            AverageRating = 4.5
        }), Encoding.UTF8, "application/json");

        var response = await _client.PostAsync("/api/destinations/", request);

        response.EnsureSuccessStatusCode();
        var returnedId = Guid.Parse(await response.Content.ReadAsStringAsync());
        Assert.NotEqual(Guid.Empty, returnedId);
    }
}