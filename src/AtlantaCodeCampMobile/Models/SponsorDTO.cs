namespace AtlantaCodeCampMobile.Models
{
    // <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using AtlantaCodeCampMobile.Models;
//
//    var sponsors = Sponsors.FromJson(jsonString);

    namespace AtlantaCodeCampMobile.Models
    {
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class Sponsor
        {
            [JsonProperty("id")]
            public long Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("imageUrl")]
            public Uri ImageUrl { get; set; }

            [JsonProperty("link")]
            public Uri Link { get; set; }

            [JsonProperty("sponsorLevel")]
            public string SponsorLevel { get; set; }

            [JsonProperty("paid")]
            public bool Paid { get; set; }
        }

        public partial class Sponsor
        {
            public static List<Sponsor> FromJson(string json) => JsonConvert.DeserializeObject<List<Sponsor>>(json, AtlantaCodeCampMobile.Models.Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this List<Sponsor> self) => JsonConvert.SerializeObject(self, AtlantaCodeCampMobile.Models.Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
                {
                    new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
                },
            };
        }
    }

}