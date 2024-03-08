using Application.Features.Cars.Constants;
using Application.Features.Cars.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Logging;

namespace Application.Features.Cars.Commands.Create;
public class CreateCarCommand : IRequest<CreatedCarResponse>, ISecuredRequest, ILoggableRequest
{
    public string Name { get; set; }
    public Guid ColorId { get; set; }
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }

    public string[] Roles => new string[] { CarsOperationClaims.Write, CarsOperationClaims.Create };

    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, CreatedCarResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        private readonly CarBusinessRules _businessRules;

        public CreateCarCommandHandler(ICarRepository carRepository, IMapper mapper, CarBusinessRules businessRules)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _businessRules = businessRules;
        }

        public async Task<CreatedCarResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            Car car = _mapper.Map<Car>(request);
            Car addedCar = await _carRepository.AddAsync(car);
            CreatedCarResponse createdCarResponse = _mapper.Map<CreatedCarResponse>(addedCar);
            return createdCarResponse;
        }
    }
}
