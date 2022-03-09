using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PraticeAPi.Models;
using PraticeAPi.Service.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static PraticeAPi.Models.CountrySunRegionPost;
using JsonConverter = Newtonsoft.Json.JsonConverter;


namespace PraticeAPi.Service
{
    public class CountryService : ICountryService
    {
        private IHttpClientService _httpClientService;

        public CountryService(IHttpClientService httpClientService)
        {
            _httpClientService = httpClientService;
        }
        public async Task<IEnumerable<CountryAll.Root>> GetAll()
        {
            var httpResponseMessage = await _httpClientService.GetAsync("https://restcountries.com/v3.1/all");
            if (!httpResponseMessage.IsSuccessStatusCode) return null;
            var data = await httpResponseMessage.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<IEnumerable<CountryAll.Root>>(data);
            return obj;

        }
      
        public async Task<string> GetCountryMapUrl(string country)
        {
            var httpResponseMessage = await _httpClientService.GetAsync($"https://restcountries.com/v3.1/name/{country.Trim()}");
            if (!httpResponseMessage.IsSuccessStatusCode) return null;
            var data = await httpResponseMessage.Content.ReadAsStringAsync();
            var obj = (JsonConvert.DeserializeObject<IEnumerable<CountryMap.Root>>(data) ?? Array.Empty<CountryMap.Root>()).FirstOrDefault()?.Maps.GoogleMaps;
            return obj;
        }

        public async Task<SubRegionResultPost> GetCountryBySubRegion(SubRegionPost post)
        {
            var httpResponseMessage = await _httpClientService.GetAsync($"https://restcountries.com/v3.1/subregion/{post.SubRegion.Trim()}");
            if (!httpResponseMessage.IsSuccessStatusCode) return null;
            var data = await httpResponseMessage.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<IEnumerable<CountrySubregion.Root>>(data);
            var regionResultPost = new SubRegionResultPost
            {
                SubRegion = post.SubRegion,
                Countries = (obj ?? Array.Empty<CountrySubregion.Root>()).Select(s => s.Name.Common)
            };
            return regionResultPost;
        }
    }
}