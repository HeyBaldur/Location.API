using Common;
using Models.V1;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICountryService
    {
        /// <summary>
        /// Get a country by keyword.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        Task<GenericOperationResponse<List<Country>>> GetCountryByKeyword(string keyword);

        /// <summary>
        /// Get a city.
        /// City will return all the information including the name of the country.
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        Task<GenericOperationResponse<List<City>>> GetCityByKeyword(string keyword);
    }
}
