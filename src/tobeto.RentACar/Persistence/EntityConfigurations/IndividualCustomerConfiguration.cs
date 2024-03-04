using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class IndividualCustomerConfiguration : IEntityTypeConfiguration<IndividualCustomer>
{
    public void Configure(EntityTypeBuilder<IndividualCustomer> builder)
    {
        builder.HasKey(ic => ic.Id);
        builder.ToTable("IndividualCustomers");
        //her bir IndividualCustomer kaydýnýn bir müþteriye (yani bir Customer kaydýna) baðlý olmasý gerektiðini belirtir. 
        builder.Property(ic => ic.CustomerId)
               .IsRequired();//.IsRequired() bu özelliðin(CustomerId) NULL olamayacaðýný yani  her zaman bir deðere sahip olmasý gerektiðini belirtir.

        //InvidualCustomer - Customer iliþkisini belirt
        builder.HasOne(ic => ic.Customer)//bir KurumsalMüþteri yalnýzca bir müþteri(customer) aittir 
               .WithOne(c => c.IndividualCustomer)//bir müþteri(Customer) yalnýzca bir KurumsalMüþteri aittir 
               .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);//FK->CustomerId InvidualCustomer'ýn baðýmlý taraf olduðunu belirt
    }
}