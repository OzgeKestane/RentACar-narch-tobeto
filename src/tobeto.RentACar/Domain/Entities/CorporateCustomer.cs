using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class CorporateCustomer : Entity<Guid>
{
    public string TaxNo { get; set; }
    public Guid CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
}
