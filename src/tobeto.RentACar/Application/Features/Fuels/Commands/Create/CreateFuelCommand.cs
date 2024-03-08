using Application.Features.Fuels.Constants;
using Application.Features.Fuels.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Logging;

namespace Application.Features.Fuels.Commands.Create;
public class CreateFuelCommand : IRequest<CreatedFuelResponse>, ISecuredRequest, ILoggableRequest
{
    public string Name { get; set; }

    public string[] Roles => new string[] { FuelsOperationClaims.Write, FuelsOperationClaims.Create };

    public class CreateFuelCommandHandler : IRequestHandler<CreateFuelCommand, CreatedFuelResponse>
    {
        private readonly IFuelRepository _fuelRepository;
        private readonly IMapper _mapper;
        private readonly FuelBusinessRules _fuelBusinessRules;

        public CreateFuelCommandHandler(IFuelRepository fuelRepository, IMapper mapper, FuelBusinessRules fuelBusinessRules)
        {
            _fuelRepository = fuelRepository;
            _mapper = mapper;
            _fuelBusinessRules = fuelBusinessRules;
        }

        public async Task<CreatedFuelResponse> Handle(CreateFuelCommand request, CancellationToken cancellationToken)
        {
            await _fuelBusinessRules.FuelShouldNotExistsWithSameName(request.Name);
            Fuel fuel = _mapper.Map<Fuel>(request);
            Fuel addedFuel = await _fuelRepository.AddAsync(fuel);
            CreatedFuelResponse createdFuelResponse = _mapper.Map<CreatedFuelResponse>(addedFuel);
            return createdFuelResponse;
        }
    }
}
