using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
{
    public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
    {
        builder.HasKey(cc => cc.Id);//PK->Id
        builder.ToTable("CorporateCustomers");//CorporateCustomer entity'sinin hangi tabloyla eþleþeceðini belirt

        //her bir CorporateCustomer kaydýnýn bir müþteriye (yani bir Customer kaydýna) baðlý olmasý gerektiðini belirtir. 
        builder.Property(cc => cc.CustomerId)
               .IsRequired();//.IsRequired() bu özelliðin(CustomerId) NULL olamayacaðýný yani  her zaman bir deðere sahip olmasý gerektiðini belirtir.


        builder.HasOne(cc => cc.Customer)//bir BireyselMüþteri yalnýzca bir müþteri(customer) aittir 
               .WithOne(c => c.CorporateCustomer)//bir müþteri(Customer) yalnýzca bir BireyselMüþteri aittir
               .HasForeignKey<CorporateCustomer>(cc => cc.CustomerId);//FK->CustomerId,CorporateCustomer'ýn baðýmlý taraf olduðunu belirt
    }
}