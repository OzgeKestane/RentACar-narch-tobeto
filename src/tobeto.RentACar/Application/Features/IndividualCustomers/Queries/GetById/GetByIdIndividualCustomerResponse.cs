using NArchitecture.Core.Application.Responses;

namespace Application.Features.IndividualCustomers.Queries.GetById;

public class GetByIdIndividualCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public string NationalIdentity { get; set; }
    public Guid CustomerId { get; set; }
}