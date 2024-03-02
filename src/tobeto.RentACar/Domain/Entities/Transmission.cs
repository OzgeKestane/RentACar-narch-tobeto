using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Transmission : Entity<Guid>
{
    public Transmission()
    {

    }

    public Transmission(string name, Model? model)
    {
        Name = name;
        Model = model;
    }

    public string Name { get; set; }
    public Model? Model { get; set; } = null;

}
