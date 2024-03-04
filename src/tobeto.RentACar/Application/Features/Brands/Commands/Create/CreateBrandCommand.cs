using Application.Features.Brands.Constants;
using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Performance;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand : IRequest<CreatedBrandResponse>, ISecuredRequest, ILoggableRequest, IIntervalRequest
{
    public string Name { get; set; }
    public string Logo { get; set; }

    //public string[] Roles => new string[] { "Brand.Add" };
    // veya kontrolü var
    public string[] Roles => new string[] { BrandsOperationClaims.Write, BrandsOperationClaims.Create };

    public int Interval => 3;

    //Brand.Update, Brand.Add, Brand.Delete, Brand.General

    //Inner class
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;
        public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _brandBusinessRules = brandBusinessRules;
        }
        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            await Task.Delay(5000);
            //thread.Sleep(5000) -> sync 
            await _brandBusinessRules.CarShouldNotExistsWithSameName(request.Name);
            Brand brand = _mapper.Map<Brand>(request);
            Brand addedBrand = await _brandRepository.AddAsync(brand);
            CreatedBrandResponse createdBrandResponse = _mapper.Map<CreatedBrandResponse>(addedBrand);
            return createdBrandResponse;
            //Brand brand = new();
            //brand.Name = request.Name;
            //brand.Logo = request.Logo;
            //Brand addedBrand = await _brandRepository.AddAsync(brand);
            //CreatedBrandResponse createdBrandResponse = new();
            //createdBrandResponse.Name = addedBrand.Name;
            //createdBrandResponse.Logo = addedBrand.Logo;
            //createdBrandResponse.Id = addedBrand.Id;
            //return createdBrandResponse;

        }
    }
}
