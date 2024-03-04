using Application.Features.Cars.Commands.Create;
using Application.Features.Cars.Queries.GetList;
using Microsoft.AspNetCore.Mvc;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;

namespace WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCarCommand command)
    {
        CreatedCarResponse response = await Mediator.Send(command);
        return Ok(response);
    }
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PageRequest request)
    {
        GetListCarQuery query = new() { PageRequest = request };
        GetListResponse<GetListCarItemDto> response = await Mediator.Send(query);
        return Ok(response);
    }
}
