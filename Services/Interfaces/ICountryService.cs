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
        Task<List<Country>> GetCountryByKeyword(string keyword);
    }
}
