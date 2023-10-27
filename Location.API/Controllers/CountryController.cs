using Location.API.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.V1;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Location.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryService _countryService;

        public CountryController(
            ILogger<CountryController> logger, 
            ICountryService countryService)
        {
            _logger = logger;
            _countryService = countryService;
        }

        /// <summary>
        /// Return the city information including the country name.
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        [HttpGet("{cityName}")]
        [ProducesResponseType(typeof(List<City>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCity(string cityName)
        {
            var result = await _countryService
                .GetCityByKeyword(cityName);

            return ControllerExtensions.HttpResult(this, result.StatusCode, result);
        }
    }
}
