using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000617")]
public class BestiaryDatabaseNPCsPopulator
{
	[Cpp2IlInjected.Token(Token = "0x2000A07")]
	public static class CommonTags
	{
		[Cpp2IlInjected.Token(Token = "0x2000BA2")]
		public static class SpawnConditions
		{
			[Cpp2IlInjected.Token(Token = "0x2000BCF")]
			public static class Invasions
			{
				[Cpp2IlInjected.Token(Token = "0x4009168")]
				public static SpawnConditionBestiaryInfoElement Goblins;

				[Cpp2IlInjected.Token(Token = "0x4009169")]
				public static SpawnConditionBestiaryInfoElement Pirates;

				[Cpp2IlInjected.Token(Token = "0x400916A")]
				public static SpawnConditionBestiaryInfoElement Martian;

				[Cpp2IlInjected.Token(Token = "0x400916B")]
				public static SpawnConditionBestiaryInfoElement OldOnesArmy;

				[Cpp2IlInjected.Token(Token = "0x400916C")]
				public static SpawnConditionBestiaryInfoElement PumpkinMoon;

				[Cpp2IlInjected.Token(Token = "0x400916D")]
				public static SpawnConditionBestiaryInfoElement FrostMoon;

				[Cpp2IlInjected.Token(Token = "0x400916E")]
				public static SpawnConditionBestiaryInfoElement FrostLegion;
			}

			[Cpp2IlInjected.Token(Token = "0x2000BD0")]
			public static class Events
			{
				[Cpp2IlInjected.Token(Token = "0x400916F")]
				public static SpawnConditionBestiaryInfoElement SlimeRain;

				[Cpp2IlInjected.Token(Token = "0x4009170")]
				public static SpawnConditionBestiaryInfoElement WindyDay;

				[Cpp2IlInjected.Token(Token = "0x4009171")]
				public static SpawnConditionBestiaryInfoElement BloodMoon;

				[Cpp2IlInjected.Token(Token = "0x4009172")]
				public static SpawnConditionBestiaryInfoElement Halloween;

				[Cpp2IlInjected.Token(Token = "0x4009173")]
				public static SpawnConditionBestiaryOverlayInfoElement Rain;

				[Cpp2IlInjected.Token(Token = "0x4009174")]
				public static SpawnConditionBestiaryInfoElement Christmas;

				[Cpp2IlInjected.Token(Token = "0x4009175")]
				public static SpawnConditionBestiaryInfoElement Eclipse;

				[Cpp2IlInjected.Token(Token = "0x4009176")]
				public static SpawnConditionBestiaryInfoElement Party;

				[Cpp2IlInjected.Token(Token = "0x4009177")]
				public static SpawnConditionBestiaryOverlayInfoElement Blizzard;

				[Cpp2IlInjected.Token(Token = "0x4009178")]
				public static SpawnConditionBestiaryOverlayInfoElement Sandstorm;
			}

			[Cpp2IlInjected.Token(Token = "0x2000BD1")]
			public static class Biomes
			{
				[Cpp2IlInjected.Token(Token = "0x4009179")]
				public static SpawnConditionBestiaryInfoElement TheCorruption;

				[Cpp2IlInjected.Token(Token = "0x400917A")]
				public static SpawnConditionBestiaryInfoElement TheCrimson;

				[Cpp2IlInjected.Token(Token = "0x400917B")]
				public static SpawnConditionBestiaryInfoElement Surface;

				[Cpp2IlInjected.Token(Token = "0x400917C")]
				public static SpawnConditionBestiaryInfoElement Graveyard;

				[Cpp2IlInjected.Token(Token = "0x400917D")]
				public static SpawnConditionBestiaryInfoElement UndergroundJungle;

				[Cpp2IlInjected.Token(Token = "0x400917E")]
				public static SpawnConditionBestiaryInfoElement TheUnderworld;

				[Cpp2IlInjected.Token(Token = "0x400917F")]
				public static SpawnConditionBestiaryInfoElement TheDungeon;

				[Cpp2IlInjected.Token(Token = "0x4009180")]
				public static SpawnConditionBestiaryInfoElement Underground;

				[Cpp2IlInjected.Token(Token = "0x4009181")]
				public static SpawnConditionBestiaryInfoElement TheHallow;

				[Cpp2IlInjected.Token(Token = "0x4009182")]
				public static SpawnConditionBestiaryInfoElement UndergroundMushroom;

				[Cpp2IlInjected.Token(Token = "0x4009183")]
				public static SpawnConditionBestiaryInfoElement Jungle;

				[Cpp2IlInjected.Token(Token = "0x4009184")]
				public static SpawnConditionBestiaryInfoElement Caverns;

				[Cpp2IlInjected.Token(Token = "0x4009185")]
				public static SpawnConditionBestiaryInfoElement UndergroundSnow;

				[Cpp2IlInjected.Token(Token = "0x4009186")]
				public static SpawnConditionBestiaryInfoElement Ocean;

				[Cpp2IlInjected.Token(Token = "0x4009187")]
				public static SpawnConditionBestiaryInfoElement SurfaceMushroom;

				[Cpp2IlInjected.Token(Token = "0x4009188")]
				public static SpawnConditionBestiaryInfoElement UndergroundDesert;

				[Cpp2IlInjected.Token(Token = "0x4009189")]
				public static SpawnConditionBestiaryInfoElement Snow;

				[Cpp2IlInjected.Token(Token = "0x400918A")]
				public static SpawnConditionBestiaryInfoElement Desert;

				[Cpp2IlInjected.Token(Token = "0x400918B")]
				public static SpawnConditionBestiaryInfoElement Meteor;

				[Cpp2IlInjected.Token(Token = "0x400918C")]
				public static SpawnConditionBestiaryInfoElement Oasis;

				[Cpp2IlInjected.Token(Token = "0x400918D")]
				public static SpawnConditionBestiaryInfoElement SpiderNest;

				[Cpp2IlInjected.Token(Token = "0x400918E")]
				public static SpawnConditionBestiaryInfoElement TheTemple;

				[Cpp2IlInjected.Token(Token = "0x400918F")]
				public static SpawnConditionBestiaryInfoElement CorruptUndergroundDesert;

				[Cpp2IlInjected.Token(Token = "0x4009190")]
				public static SpawnConditionBestiaryInfoElement CrimsonUndergroundDesert;

				[Cpp2IlInjected.Token(Token = "0x4009191")]
				public static SpawnConditionBestiaryInfoElement HallowUndergroundDesert;

				[Cpp2IlInjected.Token(Token = "0x4009192")]
				public static SpawnConditionBestiaryInfoElement CorruptDesert;

				[Cpp2IlInjected.Token(Token = "0x4009193")]
				public static SpawnConditionBestiaryInfoElement CrimsonDesert;

				[Cpp2IlInjected.Token(Token = "0x4009194")]
				public static SpawnConditionBestiaryInfoElement HallowDesert;

				[Cpp2IlInjected.Token(Token = "0x4009195")]
				public static SpawnConditionBestiaryInfoElement Granite;

				[Cpp2IlInjected.Token(Token = "0x4009196")]
				public static SpawnConditionBestiaryInfoElement UndergroundCorruption;

				[Cpp2IlInjected.Token(Token = "0x4009197")]
				public static SpawnConditionBestiaryInfoElement UndergroundCrimson;

				[Cpp2IlInjected.Token(Token = "0x4009198")]
				public static SpawnConditionBestiaryInfoElement UndergroundHallow;

				[Cpp2IlInjected.Token(Token = "0x4009199")]
				public static SpawnConditionBestiaryInfoElement Marble;

				[Cpp2IlInjected.Token(Token = "0x400919A")]
				public static SpawnConditionBestiaryInfoElement CorruptIce;

				[Cpp2IlInjected.Token(Token = "0x400919B")]
				public static SpawnConditionBestiaryInfoElement HallowIce;

				[Cpp2IlInjected.Token(Token = "0x400919C")]
				public static SpawnConditionBestiaryInfoElement CrimsonIce;

				[Cpp2IlInjected.Token(Token = "0x400919D")]
				public static SpawnConditionBestiaryInfoElement Sky;

				[Cpp2IlInjected.Token(Token = "0x400919E")]
				public static SpawnConditionBestiaryInfoElement NebulaPillar;

				[Cpp2IlInjected.Token(Token = "0x400919F")]
				public static SpawnConditionBestiaryInfoElement SolarPillar;

				[Cpp2IlInjected.Token(Token = "0x40091A0")]
				public static SpawnConditionBestiaryInfoElement VortexPillar;

				[Cpp2IlInjected.Token(Token = "0x40091A1")]
				public static SpawnConditionBestiaryInfoElement StardustPillar;
			}

			[Cpp2IlInjected.Token(Token = "0x2000BD2")]
			public static class Times
			{
				[Cpp2IlInjected.Token(Token = "0x40091A2")]
				public static SpawnConditionBestiaryInfoElement DayTime;

				[Cpp2IlInjected.Token(Token = "0x40091A3")]
				public static SpawnConditionBestiaryInfoElement NightTime;
			}

			[Cpp2IlInjected.Token(Token = "0x2000BD3")]
			public static class Visuals
			{
				[Cpp2IlInjected.Token(Token = "0x40091A4")]
				public static SpawnConditionDecorativeOverlayInfoElement Sun;

				[Cpp2IlInjected.Token(Token = "0x40091A5")]
				public static SpawnConditionDecorativeOverlayInfoElement Moon;

				[Cpp2IlInjected.Token(Token = "0x40091A6")]
				public static SpawnConditionDecorativeOverlayInfoElement EclipseSun;

				[Cpp2IlInjected.Token(Token = "0x40091A7")]
				public static SpawnConditionDecorativeOverlayInfoElement PumpkinMoon;

				[Cpp2IlInjected.Token(Token = "0x40091A8")]
				public static SpawnConditionDecorativeOverlayInfoElement FrostMoon;

				[Cpp2IlInjected.Token(Token = "0x40091A9")]
				public static SpawnConditionDecorativeOverlayInfoElement Meteor;

				[Cpp2IlInjected.Token(Token = "0x40091AA")]
				public static SpawnConditionDecorativeOverlayInfoElement Rain;

				[Cpp2IlInjected.Token(Token = "0x40091AB")]
				public static SpawnConditionDecorativeOverlayInfoElement Blizzard;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FB4")]
		[Cpp2IlInjected.Address(RVA = "0x10F4C08", Offset = "0x10F4C08", VA = "0x10F4C08")]
		public static List<IBestiaryInfoElement> GetCommonInfoElementsForFilters()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A08")]
	public static class Conditions
	{
		[Cpp2IlInjected.Token(Token = "0x6004FB5")]
		[Cpp2IlInjected.Address(RVA = "0x10F7638", Offset = "0x10F7638", VA = "0x10F7638")]
		public static bool ReachHardMode()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A09")]
	public static class CrownosIconIndexes
	{
		[Cpp2IlInjected.Token(Token = "0x4008D21")]
		public const int Surface = 0;

		[Cpp2IlInjected.Token(Token = "0x4008D22")]
		public const int Underground = 1;

		[Cpp2IlInjected.Token(Token = "0x4008D23")]
		public const int Cave = 2;

		[Cpp2IlInjected.Token(Token = "0x4008D24")]
		public const int Desert = 3;

		[Cpp2IlInjected.Token(Token = "0x4008D25")]
		public const int UndergroundDesert = 4;

		[Cpp2IlInjected.Token(Token = "0x4008D26")]
		public const int Snow = 5;

		[Cpp2IlInjected.Token(Token = "0x4008D27")]
		public const int UndergroundIce = 6;

		[Cpp2IlInjected.Token(Token = "0x4008D28")]
		public const int Corruption = 7;

		[Cpp2IlInjected.Token(Token = "0x4008D29")]
		public const int CorruptionUnderground = 8;

		[Cpp2IlInjected.Token(Token = "0x4008D2A")]
		public const int CorruptionDesert = 9;

		[Cpp2IlInjected.Token(Token = "0x4008D2B")]
		public const int CorruptionUndergroundDesert = 10;

		[Cpp2IlInjected.Token(Token = "0x4008D2C")]
		public const int CorruptionIce = 11;

		[Cpp2IlInjected.Token(Token = "0x4008D2D")]
		public const int Crimson = 12;

		[Cpp2IlInjected.Token(Token = "0x4008D2E")]
		public const int CrimsonUnderground = 13;

		[Cpp2IlInjected.Token(Token = "0x4008D2F")]
		public const int CrimsonDesert = 14;

		[Cpp2IlInjected.Token(Token = "0x4008D30")]
		public const int CrimsonUndergroundDesert = 15;

		[Cpp2IlInjected.Token(Token = "0x4008D31")]
		public const int CrimsonIce = 16;

		[Cpp2IlInjected.Token(Token = "0x4008D32")]
		public const int Hallow = 17;

		[Cpp2IlInjected.Token(Token = "0x4008D33")]
		public const int HallowUnderground = 18;

		[Cpp2IlInjected.Token(Token = "0x4008D34")]
		public const int HallowDesert = 19;

		[Cpp2IlInjected.Token(Token = "0x4008D35")]
		public const int HallowUndergroundDesert = 20;

		[Cpp2IlInjected.Token(Token = "0x4008D36")]
		public const int HallowIce = 21;

		[Cpp2IlInjected.Token(Token = "0x4008D37")]
		public const int Jungle = 22;

		[Cpp2IlInjected.Token(Token = "0x4008D38")]
		public const int UndergroundJungle = 23;

		[Cpp2IlInjected.Token(Token = "0x4008D39")]
		public const int SurfaceMushroom = 24;

		[Cpp2IlInjected.Token(Token = "0x4008D3A")]
		public const int UndergroundMushroom = 25;

		[Cpp2IlInjected.Token(Token = "0x4008D3B")]
		public const int Sky = 26;

		[Cpp2IlInjected.Token(Token = "0x4008D3C")]
		public const int Oasis = 27;

		[Cpp2IlInjected.Token(Token = "0x4008D3D")]
		public const int Ocean = 28;

		[Cpp2IlInjected.Token(Token = "0x4008D3E")]
		public const int Marble = 29;

		[Cpp2IlInjected.Token(Token = "0x4008D3F")]
		public const int Granite = 30;

		[Cpp2IlInjected.Token(Token = "0x4008D40")]
		public const int JungleTemple = 31;

		[Cpp2IlInjected.Token(Token = "0x4008D41")]
		public const int Dungeon = 32;

		[Cpp2IlInjected.Token(Token = "0x4008D42")]
		public const int Underworld = 33;

		[Cpp2IlInjected.Token(Token = "0x4008D43")]
		public const int SpiderNest = 34;

		[Cpp2IlInjected.Token(Token = "0x4008D44")]
		public const int Graveyard = 35;

		[Cpp2IlInjected.Token(Token = "0x4008D45")]
		public const int Day = 36;

		[Cpp2IlInjected.Token(Token = "0x4008D46")]
		public const int Night = 37;

		[Cpp2IlInjected.Token(Token = "0x4008D47")]
		public const int BloodMoon = 38;

		[Cpp2IlInjected.Token(Token = "0x4008D48")]
		public const int Eclipse = 39;

		[Cpp2IlInjected.Token(Token = "0x4008D49")]
		public const int Rain = 40;

		[Cpp2IlInjected.Token(Token = "0x4008D4A")]
		public const int WindyDay = 41;

		[Cpp2IlInjected.Token(Token = "0x4008D4B")]
		public const int Blizzard = 42;

		[Cpp2IlInjected.Token(Token = "0x4008D4C")]
		public const int Sandstorm = 43;

		[Cpp2IlInjected.Token(Token = "0x4008D4D")]
		public const int Meteor = 44;

		[Cpp2IlInjected.Token(Token = "0x4008D4E")]
		public const int Halloween = 45;

		[Cpp2IlInjected.Token(Token = "0x4008D4F")]
		public const int Christmas = 46;

		[Cpp2IlInjected.Token(Token = "0x4008D50")]
		public const int SlimeRain = 47;

		[Cpp2IlInjected.Token(Token = "0x4008D51")]
		public const int Party = 48;

		[Cpp2IlInjected.Token(Token = "0x4008D52")]
		public const int GoblinInvasion = 49;

		[Cpp2IlInjected.Token(Token = "0x4008D53")]
		public const int PirateInvasion = 50;

		[Cpp2IlInjected.Token(Token = "0x4008D54")]
		public const int PumpkinMoon = 51;

		[Cpp2IlInjected.Token(Token = "0x4008D55")]
		public const int FrostMoon = 52;

		[Cpp2IlInjected.Token(Token = "0x4008D56")]
		public const int AlienInvasion = 53;

		[Cpp2IlInjected.Token(Token = "0x4008D57")]
		public const int FrostLegion = 54;

		[Cpp2IlInjected.Token(Token = "0x4008D58")]
		public const int OldOnesArmy = 55;

		[Cpp2IlInjected.Token(Token = "0x4008D59")]
		public const int SolarTower = 56;

		[Cpp2IlInjected.Token(Token = "0x4008D5A")]
		public const int VortexTower = 57;

		[Cpp2IlInjected.Token(Token = "0x4008D5B")]
		public const int NebulaTower = 58;

		[Cpp2IlInjected.Token(Token = "0x4008D5C")]
		public const int StardustTower = 59;

		[Cpp2IlInjected.Token(Token = "0x4008D5D")]
		public const int Hardmode = 60;

		[Cpp2IlInjected.Token(Token = "0x4008D5E")]
		public const int ItemSpawn = 61;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C3D")]
	private BestiaryDatabase _currentDatabase;

	[Cpp2IlInjected.Token(Token = "0x6003E78")]
	[Cpp2IlInjected.Address(RVA = "0xFB8948", Offset = "0xFB8948", VA = "0xFB8948")]
	public BestiaryDatabaseNPCsPopulator()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E79")]
	[Cpp2IlInjected.Address(RVA = "0xFB8950", Offset = "0xFB8950", VA = "0xFB8950")]
	private BestiaryEntry FindEntryByNPCID(int npcNetId)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E7A")]
	[Cpp2IlInjected.Address(RVA = "0xFB8958", Offset = "0xFB8958", VA = "0xFB8958")]
	private BestiaryEntry Register(BestiaryEntry entry)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E7B")]
	[Cpp2IlInjected.Address(RVA = "0xFB8960", Offset = "0xFB8960", VA = "0xFB8960")]
	private IBestiaryEntryFilter Register(IBestiaryEntryFilter filter)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E7C")]
	[Cpp2IlInjected.Address(RVA = "0xFB8968", Offset = "0xFB8968", VA = "0xFB8968")]
	public void Populate(BestiaryDatabase database)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E7D")]
	[Cpp2IlInjected.Address(RVA = "0xFD3978", Offset = "0xFD3978", VA = "0xFD3978")]
	private void RegisterTestEntries()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E7E")]
	[Cpp2IlInjected.Address(RVA = "0xFD3684", Offset = "0xFD3684", VA = "0xFD3684")]
	private void RegisterSortSteps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E7F")]
	[Cpp2IlInjected.Address(RVA = "0xFD3544", Offset = "0xFD3544", VA = "0xFD3544")]
	private void RegisterFilters()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E80")]
	[Cpp2IlInjected.Address(RVA = "0xFD3A38", Offset = "0xFD3A38", VA = "0xFD3A38")]
	private void ModifyEntriesThatNeedIt_NameOverride(int npcID, string newNameKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E81")]
	[Cpp2IlInjected.Address(RVA = "0xFCF5A4", Offset = "0xFCF5A4", VA = "0xFCF5A4")]
	private void ModifyEntriesThatNeedIt()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E82")]
	[Cpp2IlInjected.Address(RVA = "0xFD3BF8", Offset = "0xFD3BF8", VA = "0xFD3BF8")]
	private void AdjustEaterOfWorldStats(NPCStatsReportInfoElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E83")]
	[Cpp2IlInjected.Address(RVA = "0xFD3CB8", Offset = "0xFD3CB8", VA = "0xFD3CB8")]
	private void AdjustPirateShipStats(NPCStatsReportInfoElement element)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E84")]
	[Cpp2IlInjected.Address(RVA = "0xFD3E44", Offset = "0xFD3E44", VA = "0xFD3E44")]
	private void TryGivingEntryFlavorTextIfItIsMissing(BestiaryEntry entry)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E85")]
	[Cpp2IlInjected.Address(RVA = "0xFB8BA8", Offset = "0xFB8BA8", VA = "0xFB8BA8")]
	private void AddTownNPCs_Manual()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E86")]
	[Cpp2IlInjected.Address(RVA = "0xFD41F8", Offset = "0xFD41F8", VA = "0xFD41F8")]
	private void AddMultiEntryNPCS_Manual()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E87")]
	[Cpp2IlInjected.Address(RVA = "0xFB89B8", Offset = "0xFB89B8", VA = "0xFB89B8")]
	private void AddEmptyEntries_CrittersAndEnemies_Automated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E88")]
	[Cpp2IlInjected.Address(RVA = "0xFD42A8", Offset = "0xFD42A8", VA = "0xFD42A8")]
	private static HashSet<int> GetExclusions()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003E89")]
	[Cpp2IlInjected.Address(RVA = "0xFB8F78", Offset = "0xFB8F78", VA = "0xFB8F78")]
	private void AddNPCBiomeRelationships_Automated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E8A")]
	[Cpp2IlInjected.Address(RVA = "0xFCA384", Offset = "0xFCA384", VA = "0xFCA384")]
	private void AddNPCBiomeRelationships_Manual()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E8B")]
	[Cpp2IlInjected.Address(RVA = "0xFCEC48", Offset = "0xFCEC48", VA = "0xFCEC48")]
	private void AddNPCBiomeRelationships_AddDecorations_Automated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E8C")]
	[Cpp2IlInjected.Address(RVA = "0xFD4548", Offset = "0xFD4548", VA = "0xFD4548")]
	public void AddDropOverrides(BestiaryDatabase bestiaryDatabase)
	{
	}
}
