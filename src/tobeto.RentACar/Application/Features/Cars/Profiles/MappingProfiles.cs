using Application.Features.Cars.Commands.Create;
using Application.Features.Cars.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Cars.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Car, CreateCarCommand>().ReverseMap();
        CreateMap<Car, CreatedCarResponse>().ReverseMap();
        CreateMap<Car, GetListCarItemDto>().ReverseMap();
        CreateMap<IPaginate<Car>, GetListResponse<GetListCarItemDto>>().ReverseMap();

    }
}
