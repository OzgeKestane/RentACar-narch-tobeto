using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Fuel : Entity<Guid>
{
    public Fuel()
    {

    }

    public Fuel(string name, Model? model)
    {
        Name = name;
        Model = model;
    }

    public string Name { get; set; }
    public Model? Model { get; set; } = null;

}
