using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Models.Queries.GetDynamic;
public class GetDynamicModelItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public short Year { get; set; }

    public decimal DailyPrice { get; set; }

    public Guid BrandId { get; set; }

    public Guid FuelId { get; set; }
    public Guid TransmissionId { get; set; }
    public string BrandName { get; set; }
    public string FuelName { get; set; }
    public string TransmissionName { get; set; }

}
