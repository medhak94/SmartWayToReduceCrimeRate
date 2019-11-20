
namespace CrimeIncident
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class CrimeIncidents
    {
        [JsonProperty("instanceid")]
        public string Instanceid { get; set; }

        [JsonProperty("incident_no")]
        public string IncidentNo { get; set; }

        [JsonProperty("date_reported")]
        public DateTimeOffset DateReported { get; set; }

        [JsonProperty("date_from")]
        public DateTimeOffset DateFrom { get; set; }

        [JsonProperty("date_to", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateTo { get; set; }

        [JsonProperty("clsd", NullValueHandling = NullValueHandling.Ignore)]
        public Clsd? Clsd { get; set; }

        [JsonProperty("ucr", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Ucr { get; set; }

        [JsonProperty("dst", NullValueHandling = NullValueHandling.Ignore)]
        public DstUnion? Dst { get; set; }

        [JsonProperty("beat", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Beat { get; set; }

        [JsonProperty("offense", NullValueHandling = NullValueHandling.Ignore)]
        public string Offense { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("floor", NullValueHandling = NullValueHandling.Ignore)]
        public string Floor { get; set; }

        [JsonProperty("side", NullValueHandling = NullValueHandling.Ignore)]
        public string Side { get; set; }

        [JsonProperty("opening", NullValueHandling = NullValueHandling.Ignore)]
        public string Opening { get; set; }

        [JsonProperty("hate_bias")]
        public HateBias HateBias { get; set; }

        [JsonProperty("dayofweek", NullValueHandling = NullValueHandling.Ignore)]
        public Dayofweek? Dayofweek { get; set; }

        [JsonProperty("rpt_area", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? RptArea { get; set; }

        [JsonProperty("cpd_neighborhood", NullValueHandling = NullValueHandling.Ignore)]
        public string CpdNeighborhood { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("weapons", NullValueHandling = NullValueHandling.Ignore)]
        public string Weapons { get; set; }

        [JsonProperty("date_of_clearance", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfClearance { get; set; }

        [JsonProperty("hour_from")]
        public string HourFrom { get; set; }

        [JsonProperty("hour_to", NullValueHandling = NullValueHandling.Ignore)]
        public string HourTo { get; set; }

        [JsonProperty("address_x", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressX { get; set; }

        [JsonProperty("victim_age")]
        public Age VictimAge { get; set; }

        [JsonProperty("victim_race", NullValueHandling = NullValueHandling.Ignore)]
        public Race? VictimRace { get; set; }

        [JsonProperty("victim_ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public Ethnicity? VictimEthnicity { get; set; }

        [JsonProperty("victim_gender", NullValueHandling = NullValueHandling.Ignore)]
        public Gender? VictimGender { get; set; }

        [JsonProperty("suspect_age")]
        public Age SuspectAge { get; set; }

        [JsonProperty("totalnumbervictims", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Totalnumbervictims { get; set; }

        [JsonProperty("ucr_group", NullValueHandling = NullValueHandling.Ignore)]
        public UcrGroup? UcrGroup { get; set; }

        [JsonProperty("community_council_neighborhood")]
        public string CommunityCouncilNeighborhood { get; set; }

        [JsonProperty("zip")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Zip { get; set; }

        [JsonProperty("theft_code", NullValueHandling = NullValueHandling.Ignore)]
        public TheftCode? TheftCode { get; set; }

        [JsonProperty("suspect_race", NullValueHandling = NullValueHandling.Ignore)]
        public Race? SuspectRace { get; set; }

        [JsonProperty("suspect_ethnicity", NullValueHandling = NullValueHandling.Ignore)]
        public Ethnicity? SuspectEthnicity { get; set; }

        [JsonProperty("suspect_gender", NullValueHandling = NullValueHandling.Ignore)]
        public Gender? SuspectGender { get; set; }

        [JsonProperty("totalsuspects", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Totalsuspects { get; set; }
    }

    public enum Clsd { BProsecutionDeclined, DVictimRefusedToCooperate, EJuvenileNoCustody, FClearedByArrestAdult, GClearedByArrestJuvenile, HWarrantIssued, IInvestigationPending, JClosed, KUnfounded, ZEarlyClosed };

    public enum Dayofweek { Friday, Monday, Saturday, Sunday, Thursday, Tuesday, Wednesday };

    public enum DstEnum { CentralBusiness, Other };

    public enum HateBias { NNoBiasNotApplicable, The88DomesticViolence };

    public enum Age { Adult18, JuvenileUnder18, Over70, The00, The1825, The2630, The3140, The4150, The5160, The6170, Under18, Unknown };

    public enum Ethnicity { AfricanAmerican, HispanicOrigin, NotOfHispanicOrig, Unknown, WhiteAmerican };

    public enum Gender { Female, Male, Unknown };

    public enum Race { AmericanIndianAlas, AsianOrPacificIsl, AsianPacificIsland, Black, Hispanic, Unknown, White };

    public enum TheftCode { The23APocketPicking, The23BPurseSnatching, The23CShoplifting, The23DTheftFromBuilding, The23FTheftFromMotorVehicle, The23GTheftOfMotorVehiclePartsOrAccessories, The23HAllOtherLarceny, The24ITheftOfLicensePlate, The24OMotorVehicleTheft };

    public enum UcrGroup { AggravatedAssaults, BurglaryBreakingEntering, Homicide, Part2Minor, Rape, Robbery, Theft, UnauthorizedUse };

    public partial struct DstUnion
    {
        public DstEnum? Enum;
        public long? Integer;

        public static implicit operator DstUnion(DstEnum Enum) => new DstUnion { Enum = Enum };
        public static implicit operator DstUnion(long Integer) => new DstUnion { Integer = Integer };
    }

    public partial class CrimeIncidents
    {
        public static CrimeIncidents[] FromJson(string json) => JsonConvert.DeserializeObject<CrimeIncidents[]>(json, CrimeIncident.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CrimeIncidents[] self) => JsonConvert.SerializeObject(self, CrimeIncident.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ClsdConverter.Singleton,
                DayofweekConverter.Singleton,
                DstUnionConverter.Singleton,
                DstEnumConverter.Singleton,
                HateBiasConverter.Singleton,
                AgeConverter.Singleton,
                EthnicityConverter.Singleton,
                GenderConverter.Singleton,
                RaceConverter.Singleton,
                TheftCodeConverter.Singleton,
                UcrGroupConverter.Singleton,
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

    internal class ClsdConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Clsd) || t == typeof(Clsd?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "B--PROSECUTION DECLINED":
                    return Clsd.BProsecutionDeclined;
                case "D--VICTIM REFUSED TO COOPERATE":
                    return Clsd.DVictimRefusedToCooperate;
                case "E--JUVENILE/NO CUSTODY":
                    return Clsd.EJuvenileNoCustody;
                case "F--CLEARED BY ARREST - ADULT":
                    return Clsd.FClearedByArrestAdult;
                case "G--CLEARED BY ARREST - JUVENILE":
                    return Clsd.GClearedByArrestJuvenile;
                case "H--WARRANT ISSUED":
                    return Clsd.HWarrantIssued;
                case "I--INVESTIGATION PENDING":
                    return Clsd.IInvestigationPending;
                case "J--CLOSED":
                    return Clsd.JClosed;
                case "K--UNFOUNDED":
                    return Clsd.KUnfounded;
                case "Z--EARLY CLOSED":
                    return Clsd.ZEarlyClosed;
            }
            throw new Exception("Cannot unmarshal type Clsd");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Clsd)untypedValue;
            switch (value)
            {
                case Clsd.BProsecutionDeclined:
                    serializer.Serialize(writer, "B--PROSECUTION DECLINED");
                    return;
                case Clsd.DVictimRefusedToCooperate:
                    serializer.Serialize(writer, "D--VICTIM REFUSED TO COOPERATE");
                    return;
                case Clsd.EJuvenileNoCustody:
                    serializer.Serialize(writer, "E--JUVENILE/NO CUSTODY");
                    return;
                case Clsd.FClearedByArrestAdult:
                    serializer.Serialize(writer, "F--CLEARED BY ARREST - ADULT");
                    return;
                case Clsd.GClearedByArrestJuvenile:
                    serializer.Serialize(writer, "G--CLEARED BY ARREST - JUVENILE");
                    return;
                case Clsd.HWarrantIssued:
                    serializer.Serialize(writer, "H--WARRANT ISSUED");
                    return;
                case Clsd.IInvestigationPending:
                    serializer.Serialize(writer, "I--INVESTIGATION PENDING");
                    return;
                case Clsd.JClosed:
                    serializer.Serialize(writer, "J--CLOSED");
                    return;
                case Clsd.KUnfounded:
                    serializer.Serialize(writer, "K--UNFOUNDED");
                    return;
                case Clsd.ZEarlyClosed:
                    serializer.Serialize(writer, "Z--EARLY CLOSED");
                    return;
            }
            throw new Exception("Cannot marshal type Clsd");
        }

        public static readonly ClsdConverter Singleton = new ClsdConverter();
    }

    internal class DayofweekConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Dayofweek) || t == typeof(Dayofweek?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FRIDAY":
                    return Dayofweek.Friday;
                case "MONDAY":
                    return Dayofweek.Monday;
                case "SATURDAY":
                    return Dayofweek.Saturday;
                case "SUNDAY":
                    return Dayofweek.Sunday;
                case "THURSDAY":
                    return Dayofweek.Thursday;
                case "TUESDAY":
                    return Dayofweek.Tuesday;
                case "WEDNESDAY":
                    return Dayofweek.Wednesday;
            }
            throw new Exception("Cannot unmarshal type Dayofweek");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Dayofweek)untypedValue;
            switch (value)
            {
                case Dayofweek.Friday:
                    serializer.Serialize(writer, "FRIDAY");
                    return;
                case Dayofweek.Monday:
                    serializer.Serialize(writer, "MONDAY");
                    return;
                case Dayofweek.Saturday:
                    serializer.Serialize(writer, "SATURDAY");
                    return;
                case Dayofweek.Sunday:
                    serializer.Serialize(writer, "SUNDAY");
                    return;
                case Dayofweek.Thursday:
                    serializer.Serialize(writer, "THURSDAY");
                    return;
                case Dayofweek.Tuesday:
                    serializer.Serialize(writer, "TUESDAY");
                    return;
                case Dayofweek.Wednesday:
                    serializer.Serialize(writer, "WEDNESDAY");
                    return;
            }
            throw new Exception("Cannot marshal type Dayofweek");
        }

        public static readonly DayofweekConverter Singleton = new DayofweekConverter();
    }

    internal class DstUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DstUnion) || t == typeof(DstUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "CENTRAL BUSINESS":
                            return new DstUnion { Enum = DstEnum.CentralBusiness };
                        case "OTHER":
                            return new DstUnion { Enum = DstEnum.Other };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new DstUnion { Integer = l };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type DstUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (DstUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case DstEnum.CentralBusiness:
                        serializer.Serialize(writer, "CENTRAL BUSINESS");
                        return;
                    case DstEnum.Other:
                        serializer.Serialize(writer, "OTHER");
                        return;
                }
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            throw new Exception("Cannot marshal type DstUnion");
        }

        public static readonly DstUnionConverter Singleton = new DstUnionConverter();
    }

    internal class DstEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DstEnum) || t == typeof(DstEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CENTRAL BUSINESS":
                    return DstEnum.CentralBusiness;
                case "OTHER":
                    return DstEnum.Other;
            }
            throw new Exception("Cannot unmarshal type DstEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DstEnum)untypedValue;
            switch (value)
            {
                case DstEnum.CentralBusiness:
                    serializer.Serialize(writer, "CENTRAL BUSINESS");
                    return;
                case DstEnum.Other:
                    serializer.Serialize(writer, "OTHER");
                    return;
            }
            throw new Exception("Cannot marshal type DstEnum");
        }

        public static readonly DstEnumConverter Singleton = new DstEnumConverter();
    }

    internal class HateBiasConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(HateBias) || t == typeof(HateBias?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "88--DOMESTIC VIOLENCE":
                    return HateBias.The88DomesticViolence;
                case "N--NO BIAS/NOT APPLICABLE":
                    return HateBias.NNoBiasNotApplicable;
            }
            throw new Exception("Cannot unmarshal type HateBias");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (HateBias)untypedValue;
            switch (value)
            {
                case HateBias.The88DomesticViolence:
                    serializer.Serialize(writer, "88--DOMESTIC VIOLENCE");
                    return;
                case HateBias.NNoBiasNotApplicable:
                    serializer.Serialize(writer, "N--NO BIAS/NOT APPLICABLE");
                    return;
            }
            throw new Exception("Cannot marshal type HateBias");
        }

        public static readonly HateBiasConverter Singleton = new HateBiasConverter();
    }

    internal class AgeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Age) || t == typeof(Age?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "00":
                    return Age.The00;
                case "18-25":
                    return Age.The1825;
                case "26-30":
                    return Age.The2630;
                case "31-40":
                    return Age.The3140;
                case "41-50":
                    return Age.The4150;
                case "51-60":
                    return Age.The5160;
                case "61-70":
                    return Age.The6170;
                case "ADULT (18+)":
                    return Age.Adult18;
                case "JUVENILE (UNDER 18)":
                    return Age.JuvenileUnder18;
                case "OVER 70":
                    return Age.Over70;
                case "UNDER 18":
                    return Age.Under18;
                case "UNKNOWN":
                    return Age.Unknown;
            }
            throw new Exception("Cannot unmarshal type Age");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Age)untypedValue;
            switch (value)
            {
                case Age.The00:
                    serializer.Serialize(writer, "00");
                    return;
                case Age.The1825:
                    serializer.Serialize(writer, "18-25");
                    return;
                case Age.The2630:
                    serializer.Serialize(writer, "26-30");
                    return;
                case Age.The3140:
                    serializer.Serialize(writer, "31-40");
                    return;
                case Age.The4150:
                    serializer.Serialize(writer, "41-50");
                    return;
                case Age.The5160:
                    serializer.Serialize(writer, "51-60");
                    return;
                case Age.The6170:
                    serializer.Serialize(writer, "61-70");
                    return;
                case Age.Adult18:
                    serializer.Serialize(writer, "ADULT (18+)");
                    return;
                case Age.JuvenileUnder18:
                    serializer.Serialize(writer, "JUVENILE (UNDER 18)");
                    return;
                case Age.Over70:
                    serializer.Serialize(writer, "OVER 70");
                    return;
                case Age.Under18:
                    serializer.Serialize(writer, "UNDER 18");
                    return;
                case Age.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Age");
        }

        public static readonly AgeConverter Singleton = new AgeConverter();
    }

    internal class EthnicityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ethnicity) || t == typeof(Ethnicity?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AFRICAN AMERICAN":
                    return Ethnicity.AfricanAmerican;
                case "HISPANIC ORIGIN":
                    return Ethnicity.HispanicOrigin;
                case "NOT OF HISPANIC ORIG":
                    return Ethnicity.NotOfHispanicOrig;
                case "UNKNOWN":
                    return Ethnicity.Unknown;
                case "WHITE AMERICAN":
                    return Ethnicity.WhiteAmerican;
            }
            throw new Exception("Cannot unmarshal type Ethnicity");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Ethnicity)untypedValue;
            switch (value)
            {
                case Ethnicity.AfricanAmerican:
                    serializer.Serialize(writer, "AFRICAN AMERICAN");
                    return;
                case Ethnicity.HispanicOrigin:
                    serializer.Serialize(writer, "HISPANIC ORIGIN");
                    return;
                case Ethnicity.NotOfHispanicOrig:
                    serializer.Serialize(writer, "NOT OF HISPANIC ORIG");
                    return;
                case Ethnicity.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
                case Ethnicity.WhiteAmerican:
                    serializer.Serialize(writer, "WHITE AMERICAN");
                    return;
            }
            throw new Exception("Cannot marshal type Ethnicity");
        }

        public static readonly EthnicityConverter Singleton = new EthnicityConverter();
    }

    internal class GenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Gender) || t == typeof(Gender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FEMALE":
                    return Gender.Female;
                case "MALE":
                    return Gender.Male;
                case "UNKNOWN":
                    return Gender.Unknown;
            }
            throw new Exception("Cannot unmarshal type Gender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Gender)untypedValue;
            switch (value)
            {
                case Gender.Female:
                    serializer.Serialize(writer, "FEMALE");
                    return;
                case Gender.Male:
                    serializer.Serialize(writer, "MALE");
                    return;
                case Gender.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
            }
            throw new Exception("Cannot marshal type Gender");
        }

        public static readonly GenderConverter Singleton = new GenderConverter();
    }

    internal class RaceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Race) || t == typeof(Race?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AMERICAN INDIAN/ALAS":
                    return Race.AmericanIndianAlas;
                case "ASIAN OR PACIFIC ISL":
                    return Race.AsianOrPacificIsl;
                case "ASIAN/PACIFIC ISLAND":
                    return Race.AsianPacificIsland;
                case "BLACK":
                    return Race.Black;
                case "HISPANIC":
                    return Race.Hispanic;
                case "UNKNOWN":
                    return Race.Unknown;
                case "WHITE":
                    return Race.White;
            }
            throw new Exception("Cannot unmarshal type Race");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Race)untypedValue;
            switch (value)
            {
                case Race.AmericanIndianAlas:
                    serializer.Serialize(writer, "AMERICAN INDIAN/ALAS");
                    return;
                case Race.AsianOrPacificIsl:
                    serializer.Serialize(writer, "ASIAN OR PACIFIC ISL");
                    return;
                case Race.AsianPacificIsland:
                    serializer.Serialize(writer, "ASIAN/PACIFIC ISLAND");
                    return;
                case Race.Black:
                    serializer.Serialize(writer, "BLACK");
                    return;
                case Race.Hispanic:
                    serializer.Serialize(writer, "HISPANIC");
                    return;
                case Race.Unknown:
                    serializer.Serialize(writer, "UNKNOWN");
                    return;
                case Race.White:
                    serializer.Serialize(writer, "WHITE");
                    return;
            }
            throw new Exception("Cannot marshal type Race");
        }

        public static readonly RaceConverter Singleton = new RaceConverter();
    }

    internal class TheftCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TheftCode) || t == typeof(TheftCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "23A-POCKET-PICKING":
                    return TheftCode.The23APocketPicking;
                case "23B-PURSE-SNATCHING":
                    return TheftCode.The23BPurseSnatching;
                case "23C-SHOPLIFTING":
                    return TheftCode.The23CShoplifting;
                case "23D-THEFT FROM BUILDING":
                    return TheftCode.The23DTheftFromBuilding;
                case "23F-THEFT FROM MOTOR VEHICLE":
                    return TheftCode.The23FTheftFromMotorVehicle;
                case "23G-THEFT OF MOTOR VEHICLE PARTS OR ACCESSORIES":
                    return TheftCode.The23GTheftOfMotorVehiclePartsOrAccessories;
                case "23H-ALL OTHER LARCENY":
                    return TheftCode.The23HAllOtherLarceny;
                case "24I-THEFT OF LICENSE PLATE":
                    return TheftCode.The24ITheftOfLicensePlate;
                case "24O-MOTOR VEHICLE THEFT":
                    return TheftCode.The24OMotorVehicleTheft;
            }
            throw new Exception("Cannot unmarshal type TheftCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TheftCode)untypedValue;
            switch (value)
            {
                case TheftCode.The23APocketPicking:
                    serializer.Serialize(writer, "23A-POCKET-PICKING");
                    return;
                case TheftCode.The23BPurseSnatching:
                    serializer.Serialize(writer, "23B-PURSE-SNATCHING");
                    return;
                case TheftCode.The23CShoplifting:
                    serializer.Serialize(writer, "23C-SHOPLIFTING");
                    return;
                case TheftCode.The23DTheftFromBuilding:
                    serializer.Serialize(writer, "23D-THEFT FROM BUILDING");
                    return;
                case TheftCode.The23FTheftFromMotorVehicle:
                    serializer.Serialize(writer, "23F-THEFT FROM MOTOR VEHICLE");
                    return;
                case TheftCode.The23GTheftOfMotorVehiclePartsOrAccessories:
                    serializer.Serialize(writer, "23G-THEFT OF MOTOR VEHICLE PARTS OR ACCESSORIES");
                    return;
                case TheftCode.The23HAllOtherLarceny:
                    serializer.Serialize(writer, "23H-ALL OTHER LARCENY");
                    return;
                case TheftCode.The24ITheftOfLicensePlate:
                    serializer.Serialize(writer, "24I-THEFT OF LICENSE PLATE");
                    return;
                case TheftCode.The24OMotorVehicleTheft:
                    serializer.Serialize(writer, "24O-MOTOR VEHICLE THEFT");
                    return;
            }
            throw new Exception("Cannot marshal type TheftCode");
        }

        public static readonly TheftCodeConverter Singleton = new TheftCodeConverter();
    }

    internal class UcrGroupConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(UcrGroup) || t == typeof(UcrGroup?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AGGRAVATED ASSAULTS":
                    return UcrGroup.AggravatedAssaults;
                case "BURGLARY/BREAKING ENTERING":
                    return UcrGroup.BurglaryBreakingEntering;
                case "HOMICIDE":
                    return UcrGroup.Homicide;
                case "PART 2 MINOR":
                    return UcrGroup.Part2Minor;
                case "RAPE":
                    return UcrGroup.Rape;
                case "ROBBERY":
                    return UcrGroup.Robbery;
                case "THEFT":
                    return UcrGroup.Theft;
                case "UNAUTHORIZED USE":
                    return UcrGroup.UnauthorizedUse;
            }
            throw new Exception("Cannot unmarshal type UcrGroup");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (UcrGroup)untypedValue;
            switch (value)
            {
                case UcrGroup.AggravatedAssaults:
                    serializer.Serialize(writer, "AGGRAVATED ASSAULTS");
                    return;
                case UcrGroup.BurglaryBreakingEntering:
                    serializer.Serialize(writer, "BURGLARY/BREAKING ENTERING");
                    return;
                case UcrGroup.Homicide:
                    serializer.Serialize(writer, "HOMICIDE");
                    return;
                case UcrGroup.Part2Minor:
                    serializer.Serialize(writer, "PART 2 MINOR");
                    return;
                case UcrGroup.Rape:
                    serializer.Serialize(writer, "RAPE");
                    return;
                case UcrGroup.Robbery:
                    serializer.Serialize(writer, "ROBBERY");
                    return;
                case UcrGroup.Theft:
                    serializer.Serialize(writer, "THEFT");
                    return;
                case UcrGroup.UnauthorizedUse:
                    serializer.Serialize(writer, "UNAUTHORIZED USE");
                    return;
            }
            throw new Exception("Cannot marshal type UcrGroup");
        }

        public static readonly UcrGroupConverter Singleton = new UcrGroupConverter();
    }
}

