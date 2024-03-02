using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Car : Entity<Guid>
{
    public string Name { get; set; }
    public Guid ColorId { get; set; }
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
    public Car()
    {

    }

    public Car(string name, Guid colorId, Guid modelId, int kilometer, string plate)
    {
        Name = name;
        ColorId = colorId;
        ModelId = modelId;
        Kilometer = kilometer;
        Plate = plate;
    }
}
