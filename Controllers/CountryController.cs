using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PraticeAPi.Models;
using PraticeAPi.Service.Interfaces;
using JsonConverter = Newtonsoft.Json.JsonConverter;

namespace PraticeAPi.Controllers
{
    public class CountryController : ControllerBase
    {
        private ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }
        [HttpGet]
        public IActionResult Welcome()
        {
            return Ok("OK!");
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {

            var allCountryAllData = await _countryService.GetAll();

            return new JsonResult(allCountryAllData);
        }
        [HttpGet]
        public async Task<IActionResult> Map(string country)
        {
            var countryMapUrl = await _countryService.GetCountryMapUrl(country);
            return string.IsNullOrWhiteSpace(countryMapUrl)
                ? (IActionResult)new JsonResult(new CountryPostNoFoundStatus())
                : RedirectPermanent(countryMapUrl);
        }
        [HttpPost]
        public async Task<IActionResult> GetCountryBySubRegion([FromBody] CountrySunRegionPost.SubRegionPost subRegion)
        {
            var GetCountryBySubRegion = await _countryService.GetCountryBySubRegion(subRegion);
            return GetCountryBySubRegion != null ? new JsonResult(GetCountryBySubRegion) : new JsonResult(new CountryPostNoFoundStatus());
        }
    }
}
