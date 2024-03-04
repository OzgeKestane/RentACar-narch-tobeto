using Domain.Entities;
using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Customers.Queries.GetList;

public class GetListCustomerListItemDto : IDto
{
    public Guid Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public Guid CustomerId { get; set; }
    public IndividualCustomer? IndividualCustomer { get; set; }
    public CorporateCustomer? CorporateCustomer { get; set; }
}