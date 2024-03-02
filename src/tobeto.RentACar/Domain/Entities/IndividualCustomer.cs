using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class IndividualCustomer : Entity<Guid>
{
    public IndividualCustomer(string firstName, string lastName, string nationalIdentity, Guid customerId)//Guid CustomerId
    {
        FirstName = firstName;
        LastName = lastName;
        NationalIdentity = nationalIdentity;
        CustomerId = customerId;
    }
    public IndividualCustomer()
    {

    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
    //eski kod//public int CustomerId { get; set; }
    public Guid CustomerId { get; set; } //yeni eklenne
    public Customer? Customer { get; set; } = null;
}
