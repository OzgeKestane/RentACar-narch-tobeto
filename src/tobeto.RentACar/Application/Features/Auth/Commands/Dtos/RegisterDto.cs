using Application.Features.Auth.Commands.Dtos;

namespace Application.Features.Auth.Dtos;
public class RegisterDto
{
    public BaseAuthDto User { get; set; }
    // ... diğer verilecek kayıt bilgileri
    public string Address { get; set; }
    public string TaxNo { get; set; }
}