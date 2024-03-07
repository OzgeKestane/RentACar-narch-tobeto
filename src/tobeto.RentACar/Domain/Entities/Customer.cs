using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Customer : Entity<Guid>
{
    public string? CustomerNo { get; set; }
    public Guid UserId { get; set; }
    public virtual User User { get; set; }
    public virtual CorporateCustomer? CorporateCustomer { get; set; }
    public virtual IndividualCustomer? IndividualCustomer { get; set; }

}
