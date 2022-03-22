using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PraticeAPi.Models
{
    public class CountrySubregion
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public NameInfo Name { get; set; }
        public class NameInfo
        {
            [JsonPropertyName("common")]
            public string Common { get; set; }

        }


    }
}