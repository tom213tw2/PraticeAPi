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
            var data = await GetUrlData("https://restcountries.com/v3.1/all");
            if (data == null) return null;
            var allCountryData = JsonConvert.DeserializeObject<IEnumerable<CountryAll.Root>>(data);
            return allCountryData;

        }

        private async Task<string> GetUrlData(string url)
        {
            var httpResponseMessage = await _httpClientService.GetAsync(url);
            if (!httpResponseMessage.IsSuccessStatusCode) return null;
            var data = await httpResponseMessage.Content.ReadAsStringAsync();
            return data;
        }

        public async Task<string> GetCountryMapUrl(string country)
        {
            //var httpResponseMessage = await _httpClientService.GetAsync($"https://restcountries.com/v3.1/name/{country.Trim()}");
            //if (!httpResponseMessage.IsSuccessStatusCode) return null;
            //var data = await httpResponseMessage.Content.ReadAsStringAsync();
            var data =await GetUrlData($"https://restcountries.com/v3.1/name/{country.Trim()}");
            var googleMapUrl = (JsonConvert.DeserializeObject<IEnumerable<CountryMap>>(data) ?? Array.Empty<CountryMap>()).FirstOrDefault()?.Maps.GoogleMap;
            return googleMapUrl;
        }

        public async Task<SubRegionResultPost> GetCountryBySubRegion(SubRegionPost post)
        {
            //var httpResponseMessage = await _httpClientService.GetAsync($"https://restcountries.com/v3.1/subregion/{post.SubRegion.Trim()}");
            //if (!httpResponseMessage.IsSuccessStatusCode) return null;
            //var data = await httpResponseMessage.Content.ReadAsStringAsync();
            var data = await GetUrlData($"https://restcountries.com/v3.1/subregion/{post.SubRegion.Trim()}");
            var countrySubregion = JsonConvert.DeserializeObject<IEnumerable<CountrySubregion>>(data);
            var regionResultPost = new SubRegionResultPost
            {
                SubRegion = post.SubRegion,
                Countries = (countrySubregion ?? Array.Empty<CountrySubregion>()).Select(s => s.Name.Common)
            };
            return regionResultPost;
        }
    }
}