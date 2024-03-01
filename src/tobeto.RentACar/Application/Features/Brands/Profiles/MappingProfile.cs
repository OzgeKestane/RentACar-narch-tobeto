using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Brands.Profiles;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
        CreateMap<Brand, GetListBrandItemDto>().ReverseMap();
        CreateMap<IPaginate<Brand>, GetListResponse<GetListBrandItemDto>>().ReverseMap();
    }
}
