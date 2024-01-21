using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003DC")]
public class WorldFile
{
	[Cpp2IlInjected.Token(Token = "0x20008FB")]
	public enum WorldSaveContext
	{
		[Cpp2IlInjected.Token(Token = "0x400852F")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4008530")]
		SaveAndExit
	}

	[Cpp2IlInjected.Token(Token = "0x20008FC")]
	public static class TilePacker
	{
		[Cpp2IlInjected.Token(Token = "0x4008531")]
		public const int Header1_1 = 1;

		[Cpp2IlInjected.Token(Token = "0x4008532")]
		public const int Header1_2 = 2;

		[Cpp2IlInjected.Token(Token = "0x4008533")]
		public const int Header1_4 = 4;

		[Cpp2IlInjected.Token(Token = "0x4008534")]
		public const int Header1_8 = 8;

		[Cpp2IlInjected.Token(Token = "0x4008535")]
		public const int Header1_10 = 16;

		[Cpp2IlInjected.Token(Token = "0x4008536")]
		public const int Header1_18 = 24;

		[Cpp2IlInjected.Token(Token = "0x4008537")]
		public const int Header1_20 = 32;

		[Cpp2IlInjected.Token(Token = "0x4008538")]
		public const int Header1_40 = 64;

		[Cpp2IlInjected.Token(Token = "0x4008539")]
		public const int Header1_80 = 128;

		[Cpp2IlInjected.Token(Token = "0x400853A")]
		public const int Header1_C0 = 192;

		[Cpp2IlInjected.Token(Token = "0x400853B")]
		public const int Header2_1 = 1;

		[Cpp2IlInjected.Token(Token = "0x400853C")]
		public const int Header2_2 = 2;

		[Cpp2IlInjected.Token(Token = "0x400853D")]
		public const int Header2_4 = 4;

		[Cpp2IlInjected.Token(Token = "0x400853E")]
		public const int Header2_8 = 8;

		[Cpp2IlInjected.Token(Token = "0x400853F")]
		public const int Header2_10 = 16;

		[Cpp2IlInjected.Token(Token = "0x4008540")]
		public const int Header2_20 = 32;

		[Cpp2IlInjected.Token(Token = "0x4008541")]
		public const int Header2_40 = 64;

		[Cpp2IlInjected.Token(Token = "0x4008542")]
		public const int Header2_70 = 112;

		[Cpp2IlInjected.Token(Token = "0x4008543")]
		public const int Header2_80 = 128;

		[Cpp2IlInjected.Token(Token = "0x4008544")]
		public const int Header3_1 = 1;

		[Cpp2IlInjected.Token(Token = "0x4008545")]
		public const int Header3_2 = 2;

		[Cpp2IlInjected.Token(Token = "0x4008546")]
		public const int Header3_4 = 4;

		[Cpp2IlInjected.Token(Token = "0x4008547")]
		public const int Header3_8 = 8;

		[Cpp2IlInjected.Token(Token = "0x4008548")]
		public const int Header3_10 = 16;

		[Cpp2IlInjected.Token(Token = "0x4008549")]
		public const int Header3_20 = 32;

		[Cpp2IlInjected.Token(Token = "0x400854A")]
		public const int Header3_40 = 64;

		[Cpp2IlInjected.Token(Token = "0x400854B")]
		public const int Header3_80 = 128;

		[Cpp2IlInjected.Token(Token = "0x400854C")]
		public const int Header4_1 = 1;

		[Cpp2IlInjected.Token(Token = "0x400854D")]
		public const int Header4_2 = 2;

		[Cpp2IlInjected.Token(Token = "0x400854E")]
		public const int Header4_4 = 4;

		[Cpp2IlInjected.Token(Token = "0x400854F")]
		public const int Header4_8 = 8;

		[Cpp2IlInjected.Token(Token = "0x4008550")]
		public const int Header4_10 = 16;

		[Cpp2IlInjected.Token(Token = "0x4008551")]
		public const int Header4_20 = 32;

		[Cpp2IlInjected.Token(Token = "0x4008552")]
		public const int Header4_40 = 64;

		[Cpp2IlInjected.Token(Token = "0x4008553")]
		public const int Header4_80 = 128;
	}

	[Cpp2IlInjected.Token(Token = "0x400335B")]
	private static readonly object IOLock;

	[Cpp2IlInjected.Token(Token = "0x400335C")]
	public static double _tempTime;

	[Cpp2IlInjected.Token(Token = "0x400335D")]
	public static bool _tempRaining;

	[Cpp2IlInjected.Token(Token = "0x400335E")]
	public static float _tempMaxRain;

	[Cpp2IlInjected.Token(Token = "0x400335F")]
	public static int _tempRainTime;

	[Cpp2IlInjected.Token(Token = "0x4003360")]
	public static bool _tempDayTime;

	[Cpp2IlInjected.Token(Token = "0x4003361")]
	public static bool _tempBloodMoon;

	[Cpp2IlInjected.Token(Token = "0x4003362")]
	public static bool _tempEclipse;

	[Cpp2IlInjected.Token(Token = "0x4003363")]
	public static int _tempMoonPhase;

	[Cpp2IlInjected.Token(Token = "0x4003364")]
	public static int _tempCultistDelay;

	[Cpp2IlInjected.Token(Token = "0x4003365")]
	public static int _versionNumber;

	[Cpp2IlInjected.Token(Token = "0x4003366")]
	public static bool _isWorldOnCloud;

	[Cpp2IlInjected.Token(Token = "0x4003367")]
	public static bool _tempPartyGenuine;

	[Cpp2IlInjected.Token(Token = "0x4003368")]
	public static bool _tempPartyManual;

	[Cpp2IlInjected.Token(Token = "0x4003369")]
	public static int _tempPartyCooldown;

	[Cpp2IlInjected.Token(Token = "0x400336A")]
	public static readonly List<int> TempPartyCelebratingNPCs;

	[Cpp2IlInjected.Token(Token = "0x400336B")]
	private static bool _hasCache;

	[Cpp2IlInjected.Token(Token = "0x400336C")]
	private static bool? _cachedDayTime;

	[Cpp2IlInjected.Token(Token = "0x400336D")]
	private static double? _cachedTime;

	[Cpp2IlInjected.Token(Token = "0x400336E")]
	private static int? _cachedMoonPhase;

	[Cpp2IlInjected.Token(Token = "0x400336F")]
	private static bool? _cachedBloodMoon;

	[Cpp2IlInjected.Token(Token = "0x4003370")]
	private static bool? _cachedEclipse;

	[Cpp2IlInjected.Token(Token = "0x4003371")]
	private static int? _cachedCultistDelay;

	[Cpp2IlInjected.Token(Token = "0x4003372")]
	private static bool? _cachedPartyGenuine;

	[Cpp2IlInjected.Token(Token = "0x4003373")]
	private static bool? _cachedPartyManual;

	[Cpp2IlInjected.Token(Token = "0x4003374")]
	private static int? _cachedPartyDaysOnCooldown;

	[Cpp2IlInjected.Token(Token = "0x4003375")]
	private static readonly List<int> CachedCelebratingNPCs;

	[Cpp2IlInjected.Token(Token = "0x4003376")]
	private static bool? _cachedSandstormHappening;

	[Cpp2IlInjected.Token(Token = "0x4003377")]
	public static bool _tempSandstormHappening;

	[Cpp2IlInjected.Token(Token = "0x4003378")]
	private static int? _cachedSandstormTimeLeft;

	[Cpp2IlInjected.Token(Token = "0x4003379")]
	public static int _tempSandstormTimeLeft;

	[Cpp2IlInjected.Token(Token = "0x400337A")]
	private static float? _cachedSandstormSeverity;

	[Cpp2IlInjected.Token(Token = "0x400337B")]
	public static float _tempSandstormSeverity;

	[Cpp2IlInjected.Token(Token = "0x400337C")]
	private static float? _cachedSandstormIntendedSeverity;

	[Cpp2IlInjected.Token(Token = "0x400337D")]
	public static float _tempSandstormIntendedSeverity;

	[Cpp2IlInjected.Token(Token = "0x400337E")]
	public static bool _tempLanternNightGenuine;

	[Cpp2IlInjected.Token(Token = "0x400337F")]
	public static bool _tempLanternNightManual;

	[Cpp2IlInjected.Token(Token = "0x4003380")]
	public static bool _tempLanternNightNextNightIsGenuine;

	[Cpp2IlInjected.Token(Token = "0x4003381")]
	public static int _tempLanternNightCooldown;

	[Cpp2IlInjected.Token(Token = "0x4003382")]
	private static bool? _cachedLanternNightGenuine;

	[Cpp2IlInjected.Token(Token = "0x4003383")]
	private static bool? _cachedLanternNightManual;

	[Cpp2IlInjected.Token(Token = "0x4003384")]
	private static bool? _cachedLanternNightNextNightIsGenuine;

	[Cpp2IlInjected.Token(Token = "0x4003385")]
	private static int? _cachedLanternNightCooldown;

	[Cpp2IlInjected.Token(Token = "0x4003386")]
	public static Exception LastThrownLoadException;

	[Cpp2IlInjected.Token(Token = "0x4003387")]
	private static byte[] TutorialWorldData;

	[Cpp2IlInjected.Token(Token = "0x4003388")]
	private static bool PendingSaveAndExit;

	[Cpp2IlInjected.Token(Token = "0x4003389")]
	public static bool SavingWorld;

	[Cpp2IlInjected.Token(Token = "0x400338A")]
	public static bool RequireConvertOldTileEntities;

	[Cpp2IlInjected.Token(Token = "0x400338B")]
	public static bool RequireClearTempTiles;

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public static event Action OnWorldLoad
	{
		[Cpp2IlInjected.Token(Token = "0x6003016")]
		[Cpp2IlInjected.Address(RVA = "0xE4A5BC", Offset = "0xE4A5BC", VA = "0xE4A5BC")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6003017")]
		[Cpp2IlInjected.Address(RVA = "0xE4A6C0", Offset = "0xE4A6C0", VA = "0xE4A6C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003018")]
	[Cpp2IlInjected.Address(RVA = "0xE4A7C4", Offset = "0xE4A7C4", VA = "0xE4A7C4")]
	public static void CacheSaveTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003019")]
	[Cpp2IlInjected.Address(RVA = "0xE4AC84", Offset = "0xE4AC84", VA = "0xE4AC84")]
	public static void SetOngoingToTemps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600301A")]
	[Cpp2IlInjected.Address(RVA = "0xE4AF58", Offset = "0xE4AF58", VA = "0xE4AF58")]
	public static bool IsValidWorld(string file, bool cloudSave)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600301B")]
	[Cpp2IlInjected.Address(RVA = "0xE4B430", Offset = "0xE4B430", VA = "0xE4B430")]
	public static WorldFileData GetTutorialMetadata()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600301C")]
	[Cpp2IlInjected.Address(RVA = "0xE4C148", Offset = "0xE4C148", VA = "0xE4C148")]
	public static WorldFileData GetAllMetadata(string file, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600301D")]
	[Cpp2IlInjected.Address(RVA = "0xE4D57C", Offset = "0xE4D57C", VA = "0xE4D57C")]
	public static WorldFileData CreateMetadata(string name, bool cloudSave, int GameMode)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600301E")]
	[Cpp2IlInjected.Address(RVA = "0xE4D848", Offset = "0xE4D848", VA = "0xE4D848")]
	public static void ResetTemps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600301F")]
	[Cpp2IlInjected.Address(RVA = "0xE4D950", Offset = "0xE4D950", VA = "0xE4D950")]
	private static void ClearTempTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003020")]
	[Cpp2IlInjected.Address(RVA = "0xE4DAD8", Offset = "0xE4DAD8", VA = "0xE4DAD8")]
	private static void ReregisterTiles()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003021")]
	[Cpp2IlInjected.Address(RVA = "0xE4DC50", Offset = "0xE4DC50", VA = "0xE4DC50")]
	public static void LoadTutorialOnMainThread(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003022")]
	[Cpp2IlInjected.Address(RVA = "0xE4DCF8", Offset = "0xE4DCF8", VA = "0xE4DCF8")]
	public static void LoadWorld(bool loadFromCloud)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003023")]
	[Cpp2IlInjected.Address(RVA = "0xE53BE8", Offset = "0xE53BE8", VA = "0xE53BE8")]
	public static void CheckSavedOreTiers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003024")]
	[Cpp2IlInjected.Address(RVA = "0xE4FAA4", Offset = "0xE4FAA4", VA = "0xE4FAA4")]
	public static void SaveWorld(WorldSaveContext saveContext = WorldSaveContext.Normal)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003025")]
	[Cpp2IlInjected.Address(RVA = "0xE542E4", Offset = "0xE542E4", VA = "0xE542E4")]
	public static void SaveWorld(bool useCloudSaving, bool resetTime = false, WorldSaveContext saveContext = WorldSaveContext.Normal)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003026")]
	[Cpp2IlInjected.Address(RVA = "0xE54864", Offset = "0xE54864", VA = "0xE54864")]
	private static void InternalSaveWorld(bool useCloudSaving, bool resetTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003027")]
	[Cpp2IlInjected.Address(RVA = "0xE57024", Offset = "0xE57024", VA = "0xE57024")]
	public static bool RenameWorld(string newName, bool useCloudSaving = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003028")]
	[Cpp2IlInjected.Address(RVA = "0xE586D0", Offset = "0xE586D0", VA = "0xE586D0")]
	public static bool RenameWorldUsingLoadAndSave(string newName)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003029")]
	[Cpp2IlInjected.Address(RVA = "0xE58840", Offset = "0xE58840", VA = "0xE58840")]
	private static void RenameWorldCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600302A")]
	[Cpp2IlInjected.Address(RVA = "0xE58964", Offset = "0xE58964", VA = "0xE58964")]
	private static void RenameWorldUsingLoadAndSave()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600302B")]
	[Cpp2IlInjected.Address(RVA = "0xE58ABC", Offset = "0xE58ABC", VA = "0xE58ABC")]
	private static void renameWorldCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600302C")]
	[Cpp2IlInjected.Address(RVA = "0xE56DF0", Offset = "0xE56DF0", VA = "0xE56DF0")]
	private static void DoRollingBackups(string backupWorldWritePath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600302D")]
	[Cpp2IlInjected.Address(RVA = "0xE559EC", Offset = "0xE559EC", VA = "0xE559EC")]
	private static void ResetTempsToDayTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600302E")]
	[Cpp2IlInjected.Address(RVA = "0xE55744", Offset = "0xE55744", VA = "0xE55744")]
	private static void SetTempToOngoing()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600302F")]
	[Cpp2IlInjected.Address(RVA = "0xE55410", Offset = "0xE55410", VA = "0xE55410")]
	private static void SetTempToCache()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003030")]
	[Cpp2IlInjected.Address(RVA = "0xE58D84", Offset = "0xE58D84", VA = "0xE58D84")]
	private static void ConvertMannequin(int px, int py)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003031")]
	[Cpp2IlInjected.Address(RVA = "0xE59108", Offset = "0xE59108", VA = "0xE59108")]
	private static void ConvertWeaponRack(int px, int py)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003032")]
	[Cpp2IlInjected.Address(RVA = "0xE53F74", Offset = "0xE53F74", VA = "0xE53F74")]
	private static void ConvertOldTileEntities()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003033")]
	[Cpp2IlInjected.Address(RVA = "0xE55BB0", Offset = "0xE55BB0", VA = "0xE55BB0")]
	private static void SaveWorld_Version2(BinaryWriter writer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003034")]
	[Cpp2IlInjected.Address(RVA = "0xE593C8", Offset = "0xE593C8", VA = "0xE593C8")]
	private static int SaveFileFormatHeader(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003035")]
	[Cpp2IlInjected.Address(RVA = "0xE5CBFC", Offset = "0xE5CBFC", VA = "0xE5CBFC")]
	private static int SaveHeaderPointers(BinaryWriter writer, int[] pointers)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003036")]
	[Cpp2IlInjected.Address(RVA = "0xE59590", Offset = "0xE59590", VA = "0xE59590")]
	private static int SaveWorldHeader(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003037")]
	[Cpp2IlInjected.Address(RVA = "0xE5B13C", Offset = "0xE5B13C", VA = "0xE5B13C")]
	private static int SaveWorldTilesFast(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003038")]
	[Cpp2IlInjected.Address(RVA = "0xE5CD24", Offset = "0xE5CD24", VA = "0xE5CD24")]
	public static int SaveWorldTiles(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003039")]
	[Cpp2IlInjected.Address(RVA = "0xE5BAA8", Offset = "0xE5BAA8", VA = "0xE5BAA8")]
	private static int SaveChests(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600303A")]
	[Cpp2IlInjected.Address(RVA = "0xE5BF08", Offset = "0xE5BF08", VA = "0xE5BF08")]
	private static int SaveSigns(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600303B")]
	[Cpp2IlInjected.Address(RVA = "0xE5C080", Offset = "0xE5C080", VA = "0xE5C080")]
	private static int SaveNPCs(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600303C")]
	[Cpp2IlInjected.Address(RVA = "0xE585E4", Offset = "0xE585E4", VA = "0xE585E4")]
	private static int SaveFooter(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600303D")]
	[Cpp2IlInjected.Address(RVA = "0xE53150", Offset = "0xE53150", VA = "0xE53150")]
	private static int LoadWorld_Version2(BinaryReader reader)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600303E")]
	[Cpp2IlInjected.Address(RVA = "0xE633AC", Offset = "0xE633AC", VA = "0xE633AC")]
	private static void LoadWorld_LastMinuteFixes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600303F")]
	[Cpp2IlInjected.Address(RVA = "0xE63720", Offset = "0xE63720", VA = "0xE63720")]
	private static void FixAgainstExploits()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003040")]
	[Cpp2IlInjected.Address(RVA = "0xE5825C", Offset = "0xE5825C", VA = "0xE5825C")]
	public static bool LoadFileFormatHeader(BinaryReader reader, out bool[] importance, out int[] positions, out int positionsOffset)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003041")]
	[Cpp2IlInjected.Address(RVA = "0xE5D684", Offset = "0xE5D684", VA = "0xE5D684")]
	private static void LoadHeader(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003042")]
	[Cpp2IlInjected.Address(RVA = "0xE60888", Offset = "0xE60888", VA = "0xE60888")]
	private static void LoadWorldTiles(BinaryReader reader, bool[] importance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003043")]
	[Cpp2IlInjected.Address(RVA = "0xE618A0", Offset = "0xE618A0", VA = "0xE618A0")]
	private static void LoadChests(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003044")]
	[Cpp2IlInjected.Address(RVA = "0xE6358C", Offset = "0xE6358C", VA = "0xE6358C")]
	private static void ConvertIlluminantPaintToNewField()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003045")]
	[Cpp2IlInjected.Address(RVA = "0xE61E00", Offset = "0xE61E00", VA = "0xE61E00")]
	private static void LoadSigns(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003046")]
	[Cpp2IlInjected.Address(RVA = "0xE628F0", Offset = "0xE628F0", VA = "0xE628F0")]
	private static void LoadDummies(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003047")]
	[Cpp2IlInjected.Address(RVA = "0xE621E4", Offset = "0xE621E4", VA = "0xE621E4")]
	private static void LoadNPCs(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003048")]
	[Cpp2IlInjected.Address(RVA = "0xE63B3C", Offset = "0xE63B3C", VA = "0xE63B3C")]
	private static void ValidateLoadNPCs(BinaryReader fileIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003049")]
	[Cpp2IlInjected.Address(RVA = "0xE63474", Offset = "0xE63474", VA = "0xE63474")]
	private static int LoadFooter(BinaryReader reader)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600304A")]
	[Cpp2IlInjected.Address(RVA = "0xE55CD4", Offset = "0xE55CD4", VA = "0xE55CD4")]
	private static bool ValidateWorld(BinaryReader fileIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600304B")]
	[Cpp2IlInjected.Address(RVA = "0xE4AFE0", Offset = "0xE4AFE0", VA = "0xE4AFE0")]
	private static FileMetadata GetFileMetadata(string file, bool cloudSave)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600304C")]
	[Cpp2IlInjected.Address(RVA = "0xE6395C", Offset = "0xE6395C", VA = "0xE6395C")]
	private static void FixDresserChests()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600304D")]
	[Cpp2IlInjected.Address(RVA = "0xE5C55C", Offset = "0xE5C55C", VA = "0xE5C55C")]
	private static int SaveTileEntities(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600304E")]
	[Cpp2IlInjected.Address(RVA = "0xE62950", Offset = "0xE62950", VA = "0xE62950")]
	private static void LoadTileEntities(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600304F")]
	[Cpp2IlInjected.Address(RVA = "0xE5C7E0", Offset = "0xE5C7E0", VA = "0xE5C7E0")]
	private static int SaveWeightedPressurePlates(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003050")]
	[Cpp2IlInjected.Address(RVA = "0xE6304C", Offset = "0xE6304C", VA = "0xE6304C")]
	private static void LoadWeightedPressurePlates(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003051")]
	[Cpp2IlInjected.Address(RVA = "0xE5CA5C", Offset = "0xE5CA5C", VA = "0xE5CA5C")]
	private static int SaveTownManager(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003052")]
	[Cpp2IlInjected.Address(RVA = "0xE631E8", Offset = "0xE631E8", VA = "0xE631E8")]
	private static void LoadTownManager(BinaryReader reader)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003053")]
	[Cpp2IlInjected.Address(RVA = "0xE5CB08", Offset = "0xE5CB08", VA = "0xE5CB08")]
	private static int SaveBestiary(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003054")]
	[Cpp2IlInjected.Address(RVA = "0xE63270", Offset = "0xE63270", VA = "0xE63270")]
	private static void LoadBestiary(BinaryReader reader, int loadVersionNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003055")]
	[Cpp2IlInjected.Address(RVA = "0xE63300", Offset = "0xE63300", VA = "0xE63300")]
	private static void LoadBestiaryForVersionsBefore210()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003056")]
	[Cpp2IlInjected.Address(RVA = "0xE5CBB4", Offset = "0xE5CBB4", VA = "0xE5CBB4")]
	private static int SaveCreativePowers(BinaryWriter writer)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003057")]
	[Cpp2IlInjected.Address(RVA = "0xE63380", Offset = "0xE63380", VA = "0xE63380")]
	private static void LoadCreativePowers(BinaryReader reader, int loadVersionNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003058")]
	[Cpp2IlInjected.Address(RVA = "0xE4FC68", Offset = "0xE4FC68", VA = "0xE4FC68")]
	private static int LoadWorld_Version1_Old_BeforeRelease88(BinaryReader fileIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003059")]
	[Cpp2IlInjected.Address(RVA = "0xE63D18", Offset = "0xE63D18", VA = "0xE63D18")]
	public WorldFile()
	{
	}
}
