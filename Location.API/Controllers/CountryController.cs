﻿using Location.API.Utils;
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
        /// Get a country by keyword.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [HttpPost("keyword")]
        [ProducesResponseType(typeof(List<Country>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCountry(string keyword)
        {
            var result = await _countryService
                .GetCountryByKeyword(keyword);

            return ControllerExtensions.HttpResult(this, result.StatusCode, result);
        }
    }
}
