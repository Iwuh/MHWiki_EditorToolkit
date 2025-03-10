﻿// <auto-generated />
using System.Globalization;
using MediawikiTranslator.Generators;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace MediawikiTranslator.Models.Data.MHRS
{

	public partial class WeaponTreeData
	{
		[JsonProperty("snow.data.WeaponUpdateTreeUserData", NullValueHandling = NullValueHandling.Ignore)]
		public SnowDataWeaponUpdateTreeUserData SnowDataWeaponUpdateTreeUserData { get; set; }

		public static WeaponTreeDataParam[] GetWeaponTreeData()
		{
			WeaponTreeDataParam[] allData = FromJson(File.ReadAllText(@"D:\MH_Data Repo\MH_Data\Raw Data\MHRS\natives\stm\data\define\player\weapon\weapontree.json")).SnowDataWeaponUpdateTreeUserData.Param;
			foreach (WeaponTreeDataParam data in allData)
			{
				data.Name = CommonMsgs.GetMsg($"WeaponSeries_Hunter_{GetTreeId(data.TreeType):D3}");
			}
			return allData;
		}

		private static int GetTreeId(string treeType)
		{
			return new Dictionary<string, int>()
			{
				{ "None", 0 },
				{ "Ore", 1 },
				{ "Bone", 2 },
				{ "Dummy1", 3 },
				{ "Dummy2", 4 },
				{ "Dummy3", 5 },
				{ "Dummy4", 6 },
				{ "Dummy5", 7 },
				{ "Dummy6", 8 },
				{ "Dummy7", 9 },
				{ "Dummy8", 10 },
				{ "Dummy9", 11 },
				{ "Dummy10", 12 },
				{ "Dummy11", 13 },
				{ "Dummy12", 14 },
				{ "Dummy13", 15 },
				{ "Dummy14", 16 },
				{ "Dummy15", 17 },
				{ "Dummy16", 18 },
				{ "Dummy17", 19 },
				{ "Dummy18", 20 },
				{ "Dummy19", 21 },
				{ "Dummy20", 22 },
				{ "Dummy21", 23 },
				{ "Dummy22", 24 },
				{ "Dummy23", 25 },
				{ "Dummy24", 26 },
				{ "Dummy25", 27 },
				{ "Dummy26", 28 },
				{ "Dummy27", 29 },
				{ "Dummy28", 30 },
				{ "Dummy29", 31 },
				{ "Dummy30", 32 },
				{ "Dummy31", 33 },
				{ "Dummy32", 34 },
				{ "Dummy33", 35 },
				{ "Dummy34", 36 },
				{ "Dummy35", 37 },
				{ "Dummy36", 38 },
				{ "Dummy37", 39 },
				{ "Dummy38", 40 },
				{ "Dummy39", 41 },
				{ "Dummy40", 42 },
				{ "Dummy41", 43 },
				{ "Dummy42", 44 },
				{ "Dummy43", 45 },
				{ "Dummy44", 46 },
				{ "Dummy45", 47 },
				{ "Dummy46", 48 },
				{ "Dummy47", 49 },
				{ "Dummy48", 50 },
				{ "Dummy49", 51 },
				{ "Dummy50", 52 },
				{ "Dummy51", 53 },
				{ "Dummy52", 54 },
				{ "Dummy53", 55 },
				{ "Dummy54", 56 },
				{ "Dummy55", 57 },
				{ "Dummy56", 58 },
				{ "Dummy57", 59 },
				{ "Dummy58", 60 },
				{ "Dummy59", 61 },
				{ "Dummy60", 62 },
				{ "TreeType061", 63 },
				{ "TreeType062", 64 },
				{ "TreeType063", 65 },
				{ "TreeType064", 66 },
				{ "TreeType065", 67 },
				{ "TreeType066", 68 },
				{ "TreeType067", 69 },
				{ "TreeType068", 70 },
				{ "TreeType069", 71 },
				{ "TreeType070", 72 },
				{ "TreeType071", 73 },
				{ "TreeType072", 74 },
				{ "TreeType073", 75 },
				{ "TreeType074", 76 },
				{ "TreeType075", 77 },
				{ "TreeType076", 78 },
				{ "TreeType077", 79 },
				{ "TreeType078", 80 },
				{ "TreeType079", 81 },
				{ "TreeType080", 82 },
				{ "TreeType081", 83 },
				{ "TreeType082", 84 },
				{ "TreeType083", 85 },
				{ "TreeType084", 86 },
				{ "TreeType085", 87 },
				{ "TreeType086", 88 },
				{ "TreeType087", 89 },
				{ "TreeType088", 90 },
				{ "TreeType089", 91 },
				{ "TreeType090", 92 },
				{ "TreeType091", 93 },
				{ "TreeType092", 94 },
				{ "TreeType093", 95 },
				{ "TreeType094", 96 },
				{ "TreeType126", 97 },
				{ "TreeType127", 98 },
				{ "TreeType128", 99 },
				{ "TreeType095", 100 },
				{ "TreeType096", 101 },
				{ "TreeType097", 102 },
				{ "TreeType098", 103 },
				{ "TreeType099", 104 },
				{ "TreeType100", 105 },
				{ "TreeType101", 106 },
				{ "TreeType102", 107 },
				{ "TreeType103", 108 },
				{ "TreeType104", 109 },
				{ "TreeType105", 110 },
				{ "TreeType106", 111 },
				{ "TreeType107", 112 },
				{ "TreeType108", 113 },
				{ "TreeType109", 114 },
				{ "TreeType110", 115 },
				{ "TreeType111", 116 },
				{ "TreeType112", 117 },
				{ "TreeType113", 118 },
				{ "TreeType114", 119 },
				{ "TreeType115", 120 },
				{ "TreeType116", 121 },
				{ "TreeType117", 122 },
				{ "TreeType118", 123 },
				{ "TreeType119", 124 },
				{ "TreeType120", 125 },
				{ "TreeType121", 126 },
				{ "TreeType122", 127 },
				{ "TreeType123", 128 },
				{ "TreeType124", 129 },
				{ "TreeType125", 130 },
				{ "TreeType129", 131 },
				{ "TreeType130", 132 },
				{ "TreeType131", 133 },
				{ "TreeType132", 134 },
				{ "TreeType133", 135 },
				{ "TreeType134", 136 }
			}[treeType] - 1;
		}
	}

	public partial class SnowDataWeaponUpdateTreeUserData
	{
		[JsonProperty("_Param", NullValueHandling = NullValueHandling.Ignore)]
		public WeaponTreeDataParam[] Param { get; set; }
	}

	public partial class WeaponTreeDataParam
	{
		[JsonProperty("_TreeType", NullValueHandling = NullValueHandling.Ignore)]
		public string TreeType { get; set; }

		[JsonProperty("_Index", NullValueHandling = NullValueHandling.Ignore)]
		public long? Index { get; set; }

		[JsonProperty("_VillageProgress", NullValueHandling = NullValueHandling.Ignore)]
		public string VillageProgress { get; set; }

		[JsonProperty("_HallProgress", NullValueHandling = NullValueHandling.Ignore)]
		public string HallProgress { get; set; }

		[JsonProperty("_MRProgress", NullValueHandling = NullValueHandling.Ignore)]
		public string MrProgress { get; set; }

		[JsonProperty("_WeaponId", NullValueHandling = NullValueHandling.Ignore)]
		public string WeaponId { get; set; }

		[JsonProperty("_NextWeaponTypeList", NullValueHandling = NullValueHandling.Ignore)]
		public string[] NextWeaponTypeList { get; set; }

		[JsonProperty("_NextWeaponIndexList", NullValueHandling = NullValueHandling.Ignore)]
		public long[] NextWeaponIndexList { get; set; }

		[JsonProperty("_PrevWeaponType", NullValueHandling = NullValueHandling.Ignore)]
		public string PrevWeaponType { get; set; }

		[JsonProperty("_PrevWeaponIndex", NullValueHandling = NullValueHandling.Ignore)]
		public long? PrevWeaponIndex { get; set; }

		public string Name { get; set; }
	}

	public partial class WeaponTreeData
	{
		public static WeaponTreeData FromJson(string json) => JsonConvert.DeserializeObject<WeaponTreeData>(json, MediawikiTranslator.Models.Data.MHRS.WeaponTreeDataConverter.Settings);
	}

	internal static class WeaponTreeDataConverter
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
