using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Model : Entity<Guid>
{
    public Model()
    {

    }

    public Model(string name, short year, decimal dailyPrice, Guid brandId, Guid fuelId, Guid transmissionId)
    {
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
    }

    public string Name { get; set; }

    public short Year { get; set; }

    public decimal DailyPrice { get; set; }

    public Guid BrandId { get; set; }

    public Guid FuelId { get; set; }
    public Guid TransmissionId { get; set; }

    public Brand? Brand { get; set; } = null;

    public Fuel? Fuel { get; set; } = null;

    public Transmission? Transmission { get; set; } = null; //one-to-one 

    public ICollection<Car>? Cars { get; set; } = null; //one-to many 
}
