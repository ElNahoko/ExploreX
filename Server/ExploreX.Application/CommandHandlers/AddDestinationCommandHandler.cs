using ExploreX.Application.Commands;
using ExploreX.Domain.Entities;
using ExploreX.Domain.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExploreX.Application.CommandHandlers
{
    public class AddDestinationCommandHandler : IRequestHandler<AddDestinationCommand, Guid>
    {
        private readonly IRepository<Destination> _destinationRepository;

        public AddDestinationCommandHandler(IRepository<Destination> destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        public async Task<Guid> Handle(AddDestinationCommand command, CancellationToken cancellationToken)
        {
            var destination = new Destination
            {
                Name = command.Destination.Name,
                Description = command.Destination.Description,
                ImageURL = command.Destination.ImageURL,
                VideoURL = command.Destination.VideoURL,
                Country = command.Destination.Country,
                Region = command.Destination.Region,
                FunFacts = command.Destination.FunFacts,
                AverageRating = command.Destination.AverageRating
            };

            await _destinationRepository.AddAsync(destination);
            return destination.Id;
        }
    }
}