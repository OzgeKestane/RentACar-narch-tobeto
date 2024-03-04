using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class CorporateCustomerConfiguration : IEntityTypeConfiguration<CorporateCustomer>
{
    public void Configure(EntityTypeBuilder<CorporateCustomer> builder)
    {
        builder.HasKey(cc => cc.Id);//PK->Id
        builder.ToTable("CorporateCustomers");//CorporateCustomer entity'sinin hangi tabloyla e�le�ece�ini belirt

        //her bir CorporateCustomer kayd�n�n bir m��teriye (yani bir Customer kayd�na) ba�l� olmas� gerekti�ini belirtir. 
        builder.Property(cc => cc.CustomerId)
               .IsRequired();//.IsRequired() bu �zelli�in(CustomerId) NULL olamayaca��n� yani  her zaman bir de�ere sahip olmas� gerekti�ini belirtir.


        builder.HasOne(cc => cc.Customer)//bir BireyselM��teri yaln�zca bir m��teri(customer) aittir 
               .WithOne(c => c.CorporateCustomer)//bir m��teri(Customer) yaln�zca bir BireyselM��teri aittir
               .HasForeignKey<CorporateCustomer>(cc => cc.CustomerId);//FK->CustomerId,CorporateCustomer'�n ba��ml� taraf oldu�unu belirt
    }
}