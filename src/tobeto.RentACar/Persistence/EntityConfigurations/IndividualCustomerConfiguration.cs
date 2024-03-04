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
        //her bir IndividualCustomer kayd�n�n bir m��teriye (yani bir Customer kayd�na) ba�l� olmas� gerekti�ini belirtir. 
        builder.Property(ic => ic.CustomerId)
               .IsRequired();//.IsRequired() bu �zelli�in(CustomerId) NULL olamayaca��n� yani  her zaman bir de�ere sahip olmas� gerekti�ini belirtir.

        //InvidualCustomer - Customer ili�kisini belirt
        builder.HasOne(ic => ic.Customer)//bir KurumsalM��teri yaln�zca bir m��teri(customer) aittir 
               .WithOne(c => c.IndividualCustomer)//bir m��teri(Customer) yaln�zca bir KurumsalM��teri aittir 
               .HasForeignKey<IndividualCustomer>(ic => ic.CustomerId);//FK->CustomerId InvidualCustomer'�n ba��ml� taraf oldu�unu belirt
    }
}