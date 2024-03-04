using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Customers.Commands.Update;

public class UpdatedCustomerResponse : IResponse
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public Guid CustomerId { get; set; }
    public IndividualCustomer? IndividualCustomer { get; set; }
    public CorporateCustomer? CorporateCustomer { get; set; }
}