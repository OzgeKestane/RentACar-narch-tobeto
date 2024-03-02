using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;

namespace Application.Features.Fuels.Rules;
public class FuelBusinessRules : BaseBusinessRules
{
    private readonly IFuelRepository _fuelRepository;

    public FuelBusinessRules(IFuelRepository fuelRepository)
    {
        _fuelRepository = fuelRepository;
    }
    public async Task FuelShouldNotExistsWithSameName(string name)
    {
        Fuel? fuelWithSamaName = await _fuelRepository.GetAsync(f => f.Name == name);
        if (fuelWithSamaName is not null)
            throw new BusinessException("Aynı isimli mevcut.");
    }
}
