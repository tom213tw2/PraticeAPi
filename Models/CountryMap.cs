using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace PraticeAPi.Models
{
    public class CountryMap
    {
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Zho
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class NativeName
        {
            [JsonPropertyName("zho")]
            public Zho Zho { get; set; }
        }

        public class Name
        {
            [JsonPropertyName("common")]
            public string Common { get; set; }

            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("nativeName")]
            public NativeName NativeName { get; set; }
        }

        public class TWD
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("symbol")]
            public string Symbol { get; set; }
        }

        public class Currencies
        {
            [JsonPropertyName("TWD")]
            public TWD TWD { get; set; }
        }

        public class Idd
        {
            [JsonPropertyName("root")]
            public string Root { get; set; }

            [JsonPropertyName("suffixes")]
            public List<string> Suffixes { get; set; }
        }

        public class Languages
        {
            [JsonPropertyName("zho")]
            public string Zho { get; set; }
        }

        public class Ara
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Ces
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Cym
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Deu
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Est
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Fin
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Fra
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }

            [JsonPropertyName("f")]
            public string F { get; set; }

            [JsonPropertyName("m")]
            public string M { get; set; }
        }

        public class Hrv
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Hun
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Ita
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Jpn
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Kor
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Nld
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Per
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Pol
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Por
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Rus
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Slk
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Spa
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Swe
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Urd
        {
            [JsonPropertyName("official")]
            public string Official { get; set; }

            [JsonPropertyName("common")]
            public string Common { get; set; }
        }

        public class Translations
        {
            [JsonPropertyName("ara")]
            public Ara Ara { get; set; }

            [JsonPropertyName("ces")]
            public Ces Ces { get; set; }

            [JsonPropertyName("cym")]
            public Cym Cym { get; set; }

            [JsonPropertyName("deu")]
            public Deu Deu { get; set; }

            [JsonPropertyName("est")]
            public Est Est { get; set; }

            [JsonPropertyName("fin")]
            public Fin Fin { get; set; }

            [JsonPropertyName("fra")]
            public Fra Fra { get; set; }

            [JsonPropertyName("hrv")]
            public Hrv Hrv { get; set; }

            [JsonPropertyName("hun")]
            public Hun Hun { get; set; }

            [JsonPropertyName("ita")]
            public Ita Ita { get; set; }

            [JsonPropertyName("jpn")]
            public Jpn Jpn { get; set; }

            [JsonPropertyName("kor")]
            public Kor Kor { get; set; }

            [JsonPropertyName("nld")]
            public Nld Nld { get; set; }

            [JsonPropertyName("per")]
            public Per Per { get; set; }

            [JsonPropertyName("pol")]
            public Pol Pol { get; set; }

            [JsonPropertyName("por")]
            public Por Por { get; set; }

            [JsonPropertyName("rus")]
            public Rus Rus { get; set; }

            [JsonPropertyName("slk")]
            public Slk Slk { get; set; }

            [JsonPropertyName("spa")]
            public Spa Spa { get; set; }

            [JsonPropertyName("swe")]
            public Swe Swe { get; set; }

            [JsonPropertyName("urd")]
            public Urd Urd { get; set; }
        }

        public class Eng
        {
            [JsonPropertyName("f")]
            public string F { get; set; }

            [JsonPropertyName("m")]
            public string M { get; set; }
        }

        public class Demonyms
        {
            [JsonPropertyName("eng")]
            public Eng Eng { get; set; }

            [JsonPropertyName("fra")]
            public Fra Fra { get; set; }
        }

        public class Maps
        {
            [JsonPropertyName("googleMaps")]
            public string GoogleMaps { get; set; }

            [JsonPropertyName("openStreetMaps")]
            public string OpenStreetMaps { get; set; }
        }

        public class Car
        {
            [JsonPropertyName("signs")]
            public List<string> Signs { get; set; }

            [JsonPropertyName("side")]
            public string Side { get; set; }
        }

        public class Flags
        {
            [JsonPropertyName("png")]
            public string Png { get; set; }

            [JsonPropertyName("svg")]
            public string Svg { get; set; }
        }

        public class CoatOfArms
        {
            [JsonPropertyName("png")]
            public string Png { get; set; }

            [JsonPropertyName("svg")]
            public string Svg { get; set; }
        }

        public class CapitalInfo
        {
            [JsonPropertyName("latlng")]
            public List<double> Latlng { get; set; }
        }

        public class PostalCode
        {
            [JsonPropertyName("format")]
            public string Format { get; set; }

            [JsonPropertyName("regex")]
            public string Regex { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("name")]
            public Name Name { get; set; }

            [JsonPropertyName("tld")]
            public List<string> Tld { get; set; }

            [JsonPropertyName("cca2")]
            public string Cca2 { get; set; }

            [JsonPropertyName("ccn3")]
            public string Ccn3 { get; set; }

            [JsonPropertyName("cca3")]
            public string Cca3 { get; set; }

            [JsonPropertyName("cioc")]
            public string Cioc { get; set; }

            [JsonPropertyName("independent")]
            public bool Independent { get; set; }

            [JsonPropertyName("status")]
            public string Status { get; set; }

            [JsonPropertyName("unMember")]
            public bool UnMember { get; set; }

            [JsonPropertyName("currencies")]
            public Currencies Currencies { get; set; }

            [JsonPropertyName("idd")]
            public Idd Idd { get; set; }

            [JsonPropertyName("capital")]
            public List<string> Capital { get; set; }

            [JsonPropertyName("altSpellings")]
            public List<string> AltSpellings { get; set; }

            [JsonPropertyName("region")]
            public string Region { get; set; }

            [JsonPropertyName("subregion")]
            public string Subregion { get; set; }

            [JsonPropertyName("languages")]
            public Languages Languages { get; set; }

            [JsonPropertyName("translations")]
            public Translations Translations { get; set; }

            [JsonPropertyName("latlng")]
            public List<double> Latlng { get; set; }

            [JsonPropertyName("landlocked")]
            public bool Landlocked { get; set; }

            [JsonPropertyName("area")]
            public double Area { get; set; }

            [JsonPropertyName("demonyms")]
            public Demonyms Demonyms { get; set; }

            [JsonPropertyName("flag")]
            public string Flag { get; set; }

            [JsonPropertyName("maps")]
            public Maps Maps { get; set; }

            [JsonPropertyName("population")]
            public int Population { get; set; }

            [JsonPropertyName("fifa")]
            public string Fifa { get; set; }

            [JsonPropertyName("car")]
            public Car Car { get; set; }

            [JsonPropertyName("timezones")]
            public List<string> Timezones { get; set; }

            [JsonPropertyName("continents")]
            public List<string> Continents { get; set; }

            [JsonPropertyName("flags")]
            public Flags Flags { get; set; }

            [JsonPropertyName("coatOfArms")]
            public CoatOfArms CoatOfArms { get; set; }

            [JsonPropertyName("startOfWeek")]
            public string StartOfWeek { get; set; }

            [JsonPropertyName("capitalInfo")]
            public CapitalInfo CapitalInfo { get; set; }

            [JsonPropertyName("postalCode")]
            public PostalCode PostalCode { get; set; }
        }


    }
}