using Microsoft.AspNetCore.Mvc;

namespace WebAPI;
[Route("api/[controller]")]
[ApiController]
public class LocationsController : ControllerBase
{
    [HttpGet("GetCountries")]
    public IActionResult GetCountries()
    {
        var result = TurkeyLocations.GetLocations.GetCountries();
        return Ok(result);
    }
    [HttpGet("GetCities")]
    public IActionResult GetCities()
    {
        var result = TurkeyLocations.GetLocations.GetCities();
        return Ok(result);
    }
    [HttpGet("GetCity")]
    public IActionResult GetCity(int cityId)
    {
        var result = TurkeyLocations.GetLocations.GetCity(cityId);
        return Ok(result);
    }
    [HttpGet("GetRegions")]
    public IActionResult GetRegions()
    {
        var result = TurkeyLocations.GetLocations.GetRegions();
        return Ok(result);
    }
    [HttpGet("GetRegion")]
    public IActionResult GetRegion(int regionId)
    {
        var result = TurkeyLocations.GetLocations.GetRegion(regionId);
        return Ok(result);
    }
    [HttpGet("GetDistricts")]
    public IActionResult GetDistricts(int cityId)
    {
        var result = TurkeyLocations.GetLocations.GetDistricts(cityId);
        return Ok(result);
    }
}
