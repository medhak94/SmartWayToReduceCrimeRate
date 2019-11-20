

namespace Smart911Enrollments
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Smart911Enrollment
    {
        [JsonProperty("week_of")]
        public DateTimeOffset WeekOf { get; set; }

        [JsonProperty("zip_code")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ZipCode { get; set; }

        [JsonProperty("web_enrollments")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long WebEnrollments { get; set; }

        [JsonProperty("app_enrollments")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long AppEnrollments { get; set; }

        [JsonProperty("total_enrollments")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long TotalEnrollments { get; set; }
    }

    public partial class Smart911Enrollment
    {
        public static Smart911Enrollment[] FromJson(string json) => JsonConvert.DeserializeObject<Smart911Enrollment[]>(json, Smart911Enrollments.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Smart911Enrollment[] self) => JsonConvert.SerializeObject(self, Smart911Enrollments.Converter.Settings);
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

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
