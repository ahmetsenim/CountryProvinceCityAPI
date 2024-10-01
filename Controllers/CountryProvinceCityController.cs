using CountryProvinceCityAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryProvinceCityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryProvinceCityController : ControllerBase
    {
        private readonly CountryProvinceCityService _countryProvinceCityService;

        public CountryProvinceCityController(CountryProvinceCityService countryProvinceCityService)
        {
            _countryProvinceCityService = countryProvinceCityService;
        }

        [HttpGet("GetAllCountry")]
        public IActionResult GetAllCountry([FromQuery] string lang)
        {
            var result = _countryProvinceCityService.GetAllCountries(lang);
            return Ok(result);
        }

        [HttpGet("GetAllProvince")]
        public IActionResult GetAllProvince([FromQuery] string countryCode)
        {
            var result = _countryProvinceCityService.GetProvinces(countryCode);
            return Ok(result);
        }

        [HttpGet("GetAllDistrict")]
        public IActionResult GetAllDistrict([FromQuery] string countryCode, [FromQuery] string provinceCode)
        {
            var result = _countryProvinceCityService.GetCities(countryCode, provinceCode);
            return Ok(result);
        }

    }
}
