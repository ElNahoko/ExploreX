using ExploreX.Api.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ExploreX.Application.DTOs;
using ExploreX.Application.Commands;

namespace ExploreX.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public DestinationController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDestinationAsync([FromBody] CreateDestinationRequest request)
        {
            var destinationDto = _mapper.Map<AddDestinationDTO>(request);
            var destinationId = await _mediator.Send(new AddDestinationCommand(destinationDto));
            return Ok(destinationId);
        }
    }
}