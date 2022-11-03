﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CountryCodeList;
//
//    var countryCodes = CountryCodes.FromJson(jsonString);

namespace CountryCodeList
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CountryCodes
    {
        [JsonProperty("Code")]
        public string Code { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class CountryCodes
    {
        public static List<CountryCodes> FromJson(string json) => JsonConvert.DeserializeObject<List<CountryCodes>>(json, CountryCodeList.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<CountryCodes> self) => JsonConvert.SerializeObject(self, CountryCodeList.Converter.Settings);
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