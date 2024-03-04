using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id);//PK->Id
        builder.ToTable("Customers");//Hangi veritaban� tablosuyla e�le�ece�ini belirt
                                     // Customer - IndividualCustomer ili�kisini belirt//
        builder.HasOne(c => c.IndividualCustomer)
               .WithOne(ic => ic.Customer)
               .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);// Customer'�n ba��ml� taraf oldu�unu belirt
                                                                       // Customer - CorporateCustomer ili�kisini belirt//
        builder.HasOne(c => c.CorporateCustomer)
               .WithOne(cc => cc.Customer)
               .HasForeignKey<CorporateCustomer>(cc => cc.CustomerId);
    }
}