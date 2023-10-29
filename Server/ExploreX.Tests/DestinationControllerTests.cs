using ExploreX.Api.Controllers;
using ExploreX.Application.Commands;
using ExploreX.Application.DTOs;
using MediatR;
using Moq;
using Xunit;

public class DestinationControllerTests
{
    [Fact]
    public async Task CreateDestinationAsync_ReturnsDestinationId()
    {
        var mediatorMock = new Mock<IMediator>();
        var mapperMock = new Mock<IMapper>();

        var request = new CreateDestinationRequest
        {
            Name = "Sample Destination"
        };

        var dto = new AddDestinationDTO
        {
            Name = request.Name,
            Description = request.Description,
            ImageURL = request.ImageURL,
            VideoURL = request.VideoURL,
            Country = request.Country,
            Region = request.Region,
            FunFacts = request.FunFacts,
            AverageRating = request.AverageRating
        };

        var expectedId = Guid.NewGuid();

        mapperMock.Setup(m => m.Map<AddDestinationDTO>(request)).Returns(dto);
        mediatorMock.Setup(m => m.Send(It.IsAny<AddDestinationCommand>())).ReturnsAsync(expectedId);

        var controller = new DestinationController(mediatorMock.Object, mapperMock.Object);

        var result = await controller.CreateDestinationAsync(request);

        Assert.Equal(expectedId, result.Value);
    }
}