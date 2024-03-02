using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;
public class CarConfiguration
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(i => i.Id);//PK değeri->Id 
        builder.ToTable("Cars");//Hangi veritabanı tablosuyla eşleşeceğini belirt

        //ekstra ilişki kısmı
        //Car - Model ilişki
        builder.HasOne<Model>()//Bir arabanın yalnızca bir (Model) ile ilişkili olabilir
               .WithMany()//Bir Model'in birden çok araba ile ilişkili olabileceğini belirtmek için WithMany
               .HasForeignKey(c => c.ModelId);//FK değeri->ModelId 
    }
}
