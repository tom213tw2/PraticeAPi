using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace PraticeAPi.Models
{
    public class CountryMap
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        [JsonPropertyName("maps")]
        public Map Maps { get; set; }

        public class Map
        {
            [JsonProperty("googleMaps")]
            public string GoogleMap { get; set; }

            [JsonProperty("openStreetMaps")]
            public string OpenStreetMap { get; set; }
        }
    }
}