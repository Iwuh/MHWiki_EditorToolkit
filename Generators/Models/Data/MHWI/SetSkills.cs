﻿// <auto-generated />
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace MediawikiTranslator.Models.Data.MHWI
{

	public partial class SetSkills
	{
		[JsonProperty("SetBonusIndex", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(SetSkillsParseStringConverter))]
		public long? SetBonusIndex { get; set; }

		[JsonProperty("SetBonusId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(SetSkillsParseStringConverter))]
		public long? SetBonusId { get; set; }

		[JsonProperty("SetBonusName", NullValueHandling = NullValueHandling.Ignore)]
		public string SetBonusName { get; set; }

		[JsonProperty("PiecesRequired", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(SetSkillsParseStringConverter))]
		public long? PiecesRequired { get; set; }

		[JsonProperty("SetBonusSkillIndex", NullValueHandling = NullValueHandling.Ignore)]
		[JsonConverter(typeof(SetSkillsParseStringConverter))]
		public long? SetBonusSkillIndex { get; set; }

		[JsonProperty("SetBonusTextId", NullValueHandling = NullValueHandling.Ignore)]
		public string SetBonusTextId { get; set; }

		[JsonProperty("SetBonusSkillName", NullValueHandling = NullValueHandling.Ignore)]
		public string SetBonusSkillName { get; set; }

		[JsonProperty("SetBonusDescription", NullValueHandling = NullValueHandling.Ignore)]
		public string SetBonusDescription { get; set; }

		public static SetSkills[] GetSetBonusDescriptions()
		{
			return FromJson(File.ReadAllText(@"D:\MH_Data Repo\MH_Data\Raw Data\MHWI\chunk\common\equip\setskills.json"));
		}
	}

	public partial class SetSkills
	{
		public static SetSkills[] FromJson(string json) => JsonConvert.DeserializeObject<SetSkills[]>(json, MediawikiTranslator.Models.Data.MHWI.SkillDescriptionsConverter.Settings);
	}

	internal static class SetSkillsConverter
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

	internal class SetSkillsParseStringConverter : JsonConverter
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

		public static readonly SetSkillsParseStringConverter Singleton = new SetSkillsParseStringConverter();
	}
}
