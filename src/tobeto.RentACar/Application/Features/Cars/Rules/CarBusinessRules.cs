using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;

namespace Application.Features.Cars.Rules;
public class CarBusinessRules : BaseBusinessRules
{
    private readonly ICarRepository _carRepository;

    public CarBusinessRules(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }
}
