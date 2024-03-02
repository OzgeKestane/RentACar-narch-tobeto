using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Fuels.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Fuel, CreateFuelCommand>().ReverseMap();
        CreateMap<Fuel, CreatedFuelResponse>().ReverseMap();
        CreateMap<Fuel, GetListFuelItemDto>().ReverseMap();
        CreateMap<IPaginate<Fuel>, GetListResponse<GetListFuelItemDto>>().ReverseMap();

    }
}
