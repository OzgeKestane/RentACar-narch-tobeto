using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Auth.Dtos;
public class RegisterDto
{
    public UserForRegisterDto User { get; set; }
    // ... diğer verilecek kayıt bilgileri
    public string Address { get; set; }
    public string TaxNo { get; set; }
}