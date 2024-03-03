using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;

namespace Application.Features.Transmissions.Rules;
public class TransmissionBusinessRules : BaseBusinessRules
{
    private readonly ITransmissionRepository _transmissionRepository;

    public TransmissionBusinessRules(ITransmissionRepository transmissionRepository)
    {
        _transmissionRepository = transmissionRepository;
    }
    public async Task TransmissionShouldNotExistsWithSameName(string name)
    {
        Transmission? transmissionWithSameName = await _transmissionRepository.GetAsync(t => t.Name == name);
        if (transmissionWithSameName is not null)
        {
            throw new BusinessException("Aynı isimli mevcut.");
        }
    }
}
