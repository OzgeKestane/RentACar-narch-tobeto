using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class IndividualCustomer : Entity<Guid>
{
    public string NationalIdentity { get; set; }
    public Guid CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
}
