using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Brand : Entity<Guid>
{
    public string Name { get; set; }
    public string Logo { get; set; }
}
