using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PraticeAPi.Models;

namespace PraticeAPi.Service.Interfaces
{
    public interface ICountryService
    {
        /// <summary>
        ///  GetAllData
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CountryAll.Root>> GetAll();
        /// <summary>
        /// Get Country Map Url
        /// </summary>
        /// <param name="country">國家，ex:</param>
        /// <returns></returns>
        Task<string> GetCountryMapUrl(string country);
        Task<CountrySunRegionPost.SubRegionResultPost> GetCountryBySubRegion(CountrySunRegionPost.SubRegionPost post);
    }
}