using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;
public class Customer : Entity<Guid>
{
    //public Customer(int userId)
    //{
    //    UserId = userId;
    //}
    public Customer()
    {

    }

    //public int UserId { get; set; }
    public User? User { get; set; } = null;
    //public Guid CustomerId { get; set; }//sonradan eklenen
    public IndividualCustomer? IndividualCustomer { get; set; } = null;
    public CorporateCustomer? CorporateCustomer { get; set; } = null;
}
