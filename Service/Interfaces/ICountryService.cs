using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PraticeAPi.Models;

namespace PraticeAPi.Service.Interfaces
{
    public interface ICountryService
    {
        /// <summary>
        /// 抓取全部資料
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<CountryAll.Root>> GetAll();
        /// <summary>
        /// 抓取國家之Google Map地圖
        /// </summary>
        /// <param name="country">國家，ex:</param>
        /// <returns></returns>
        Task<string> GetCountryMapUrl(string country);
        /// <summary>
        /// 列出特定大陸上的國家
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        Task<CountrySunRegionPost.SubRegionResultPost> GetCountryBySubRegion(CountrySunRegionPost.SubRegionPost post);
    }
}