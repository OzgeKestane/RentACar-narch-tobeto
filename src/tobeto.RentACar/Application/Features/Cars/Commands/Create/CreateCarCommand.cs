using Application.Features.Cars.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Cars.Commands.Create;
public class CreateCarCommand : IRequest<CreatedCarResponse>
{
    public string Name { get; set; }
    public Guid ColorId { get; set; }
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
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
