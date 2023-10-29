using AutoMapper;
using ExploreX.Api.Models;
using ExploreX.Application.DTOs;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateDestinationRequest, AddDestinationDTO>();
    }
}