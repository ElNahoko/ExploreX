using ExploreX.Application.DTOs;
using MediatR;

namespace ExploreX.Application.Commands
{
    public class AddDestinationCommand : IRequest<Guid>
    {
        public AddDestinationDTO Destination { get; set; }

        public AddDestinationCommand(AddDestinationDTO destination)
        {
            Destination = destination;
        }
    }
}