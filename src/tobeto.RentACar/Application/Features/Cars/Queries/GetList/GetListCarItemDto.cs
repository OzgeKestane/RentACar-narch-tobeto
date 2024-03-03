namespace Application.Features.Cars.Queries.GetList;
public class GetListCarItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid ColorId { get; set; }
    public Guid ModelId { get; set; }
    public int Kilometer { get; set; }
    public string Plate { get; set; }
}
