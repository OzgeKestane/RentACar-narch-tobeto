﻿using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand : IRequest<CreatedBrandResponse>
{
    public string Name { get; set; }
    public string Logo { get; set; }

    //Inner class
    public class CreareBrandCommanHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;
        public CreareBrandCommanHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
            _brandBusinessRules = brandBusinessRules;
        }
        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
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