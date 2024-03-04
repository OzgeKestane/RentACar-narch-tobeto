using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Queries.GetById;

public class GetByIdCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public Guid CustomerId { get; set; }
    public IndividualCustomer? IndividualCustomer { get; set; }
    public CorporateCustomer? CorporateCustomer { get; set; }
}