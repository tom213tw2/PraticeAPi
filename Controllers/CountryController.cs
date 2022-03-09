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
            
            var str=await _countryService.GetAll();


            return new JsonResult(str);
        }
        [HttpGet]
        public async Task<IActionResult> Map(string country)
        {
            var str = await _countryService.GetCountryMapUrl(country);
            return string.IsNullOrWhiteSpace(str)
                ? (IActionResult) new JsonResult(new CountryPostNoFoundStatus())
                : RedirectPermanent(str);
        }   
        [HttpPost]
        public async Task<IActionResult> GetCountryBySubRegion([FromBody]CountrySunRegionPost.SubRegionPost subRegion)
        {
            var list =await  _countryService.GetCountryBySubRegion(subRegion);
            return list!=null ? new JsonResult(list) : new JsonResult(new CountryPostNoFoundStatus());
        }
    }
}
