using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Utilities;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.IO;
using Terraria.Localization;
using Terraria.Utilities;
using Terraria.WorldBuilding;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000355")]
public class WorldGen
{
	[Cpp2IlInjected.Token(Token = "0x200086F")]
	public static class WorldSize
	{
		[Cpp2IlInjected.Token(Token = "0x4007FA1")]
		public const int Small = 0;

		[Cpp2IlInjected.Token(Token = "0x4007FA2")]
		public const int Medium = 1;

		[Cpp2IlInjected.Token(Token = "0x4007FA3")]
		public const int Large = 2;
	}

	[Cpp2IlInjected.Token(Token = "0x2000870")]
	public static class SavedOreTiers
	{
		[Cpp2IlInjected.Token(Token = "0x4007FA4")]
		public static int Copper;

		[Cpp2IlInjected.Token(Token = "0x4007FA5")]
		public static int Iron;

		[Cpp2IlInjected.Token(Token = "0x4007FA6")]
		public static int Silver;

		[Cpp2IlInjected.Token(Token = "0x4007FA7")]
		public static int Gold;

		[Cpp2IlInjected.Token(Token = "0x4007FA8")]
		public static int Cobalt;

		[Cpp2IlInjected.Token(Token = "0x4007FA9")]
		public static int Mythril;

		[Cpp2IlInjected.Token(Token = "0x4007FAA")]
		public static int Adamantite;
	}

	[Cpp2IlInjected.Token(Token = "0x2000871")]
	public static class Hooks
	{
		[Cpp2IlInjected.Token(Token = "0x2000B54")]
		public delegate void WorldGenConfigProcessEvent(ref WorldGenConfiguration config);

		[Cpp2IlInjected.Token(Token = "0x14000064")]
		public static event WorldGenConfigProcessEvent OnWorldGenConfigProcess
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC7")]
			[Cpp2IlInjected.Address(RVA = "0x10C3448", Offset = "0x10C3448", VA = "0x10C3448")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6004AC8")]
			[Cpp2IlInjected.Address(RVA = "0x10C350C", Offset = "0x10C350C", VA = "0x10C350C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000065")]
		public static event Action OnWorldLoad
		{
			[Cpp2IlInjected.Token(Token = "0x6004AC9")]
			[Cpp2IlInjected.Address(RVA = "0x10C35D0", Offset = "0x10C35D0", VA = "0x10C35D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6004ACA")]
			[Cpp2IlInjected.Address(RVA = "0x10C3698", Offset = "0x10C3698", VA = "0x10C3698")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004ACB")]
		[Cpp2IlInjected.Address(RVA = "0x10C3760", Offset = "0x10C3760", VA = "0x10C3760")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004ACC")]
		[Cpp2IlInjected.Address(RVA = "0x10C3944", Offset = "0x10C3944", VA = "0x10C3944")]
		public static void WorldLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004ACD")]
		[Cpp2IlInjected.Address(RVA = "0x10C39B0", Offset = "0x10C39B0", VA = "0x10C39B0")]
		public static void ProcessWorldGenConfig(ref WorldGenConfiguration config)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000872")]
	public static class Spread
	{
		[Cpp2IlInjected.Token(Token = "0x6004ACE")]
		[Cpp2IlInjected.Address(RVA = "0x10C3F10", Offset = "0x10C3F10", VA = "0x10C3F10")]
		public static void Wall(int x, int y, int wallType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004ACF")]
		[Cpp2IlInjected.Address(RVA = "0x10C4C30", Offset = "0x10C4C30", VA = "0x10C4C30")]
		public static void Wall2(int x, int y, int wallType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD0")]
		[Cpp2IlInjected.Address(RVA = "0x10C6478", Offset = "0x10C6478", VA = "0x10C6478")]
		public static void Moss(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD1")]
		[Cpp2IlInjected.Address(RVA = "0x10C69BC", Offset = "0x10C69BC", VA = "0x10C69BC")]
		public static void Gem(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD2")]
		[Cpp2IlInjected.Address(RVA = "0x10C7250", Offset = "0x10C7250", VA = "0x10C7250")]
		public static void Spider(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD3")]
		[Cpp2IlInjected.Address(RVA = "0x10C8430", Offset = "0x10C8430", VA = "0x10C8430")]
		public static void WallDungeon(int x, int y, int wallType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD4")]
		[Cpp2IlInjected.Address(RVA = "0x10C7200", Offset = "0x10C7200", VA = "0x10C7200")]
		private static bool Gemmable(int type)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000873")]
	public struct PendingRefame
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007FAD")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007FAE")]
		public int y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007FAF")]
		public bool resetFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4007FB0")]
		public bool noBreak;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007FB1")]
		public int reframeCount;
	}

	[Cpp2IlInjected.Token(Token = "0x2000874")]
	public class nextCountNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007FB2")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007FB3")]
		public int y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007FB4")]
		public bool jungle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4007FB5")]
		public bool lavaOk;

		[Cpp2IlInjected.Token(Token = "0x6004AD5")]
		[Cpp2IlInjected.Address(RVA = "0x10C4C18", Offset = "0x10C4C18", VA = "0x10C4C18")]
		public void Setup(int x, int y, bool jungle, bool lavaOk)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD6")]
		[Cpp2IlInjected.Address(RVA = "0x10C4C10", Offset = "0x10C4C10", VA = "0x10C4C10")]
		public nextCountNode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000875")]
	internal class nextCountDirtNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007FB6")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007FB7")]
		public int y;

		[Cpp2IlInjected.Token(Token = "0x6004AD7")]
		[Cpp2IlInjected.Address(RVA = "0x10C8B50", Offset = "0x10C8B50", VA = "0x10C8B50")]
		public void Setup(int x, int y)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004AD8")]
		[Cpp2IlInjected.Address(RVA = "0x10C8B5C", Offset = "0x10C8B5C", VA = "0x10C8B5C")]
		public nextCountDirtNode()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000876")]
	public static class TenthAnniversaryWorldInfo
	{
		[Cpp2IlInjected.Token(Token = "0x4007FB8")]
		public static int[] GoodPrefixIdsForAccessory;

		[Cpp2IlInjected.Token(Token = "0x4007FB9")]
		public static int[] GoodPrefixIdsForMeleeWeapon;

		[Cpp2IlInjected.Token(Token = "0x4007FBA")]
		public static int[] GoodPrefixIdsForRangedWeapon;

		[Cpp2IlInjected.Token(Token = "0x4007FBB")]
		public static int[] GoodPrefixIdsForMagicWeapon;

		[Cpp2IlInjected.Token(Token = "0x4007FBC")]
		public static int[] GoodPrefixIdsForSummonerWeapon;
	}

	[Cpp2IlInjected.Token(Token = "0x2000877")]
	public struct GrowTreeSettings
	{
		[Cpp2IlInjected.Token(Token = "0x2000B56")]
		public delegate bool IsTileFitForTreeGroundTest(int tileType);

		[Cpp2IlInjected.Token(Token = "0x2000B57")]
		public delegate bool IsWallTypeFitForTreeBack(int wallType);

		[Cpp2IlInjected.Token(Token = "0x2000B58")]
		public static class Profiles
		{
			[Cpp2IlInjected.Token(Token = "0x4008FF1")]
			public static GrowTreeSettings GemTree_Ruby;

			[Cpp2IlInjected.Token(Token = "0x4008FF2")]
			public static GrowTreeSettings GemTree_Diamond;

			[Cpp2IlInjected.Token(Token = "0x4008FF3")]
			public static GrowTreeSettings GemTree_Topaz;

			[Cpp2IlInjected.Token(Token = "0x4008FF4")]
			public static GrowTreeSettings GemTree_Amethyst;

			[Cpp2IlInjected.Token(Token = "0x4008FF5")]
			public static GrowTreeSettings GemTree_Sappphire;

			[Cpp2IlInjected.Token(Token = "0x4008FF6")]
			public static GrowTreeSettings GemTree_Emerald;

			[Cpp2IlInjected.Token(Token = "0x4008FF7")]
			public static GrowTreeSettings GemTree_Amber;

			[Cpp2IlInjected.Token(Token = "0x4008FF8")]
			public static GrowTreeSettings VanityTree_Sakura;

			[Cpp2IlInjected.Token(Token = "0x4008FF9")]
			public static GrowTreeSettings VanityTree_Willow;

			[Cpp2IlInjected.Token(Token = "0x4008FFA")]
			public static GrowTreeSettings Tree_Ash;

			[Cpp2IlInjected.Token(Token = "0x6005374")]
			[Cpp2IlInjected.Address(RVA = "0x10C290C", Offset = "0x10C290C", VA = "0x10C290C")]
			public static bool TryGetFromItemId(int itemType, out GrowTreeSettings profile)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6005375")]
			[Cpp2IlInjected.Address(RVA = "0x10C2BE0", Offset = "0x10C2BE0", VA = "0x10C2BE0")]
			public static bool TryGetFromTreeId(int tileType, out GrowTreeSettings profile)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007FBD")]
		public ushort TreeTileType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007FBE")]
		public int TreeHeightMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007FBF")]
		public int TreeHeightMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007FC0")]
		public int TreeTopPaddingNeeded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007FC1")]
		public IsTileFitForTreeGroundTest GroundTest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007FC2")]
		public IsWallTypeFitForTreeBack WallTest;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007FC3")]
		public ushort SaplingTileType;
	}

	[Cpp2IlInjected.Token(Token = "0x2000878")]
	public struct CheckTreeSettings
	{
		[Cpp2IlInjected.Token(Token = "0x2000B59")]
		public delegate bool GroundValidTest(int groundTileType);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007FC4")]
		public GroundValidTest IsGroundValid;
	}

	[Cpp2IlInjected.Token(Token = "0x2000879")]
	public enum SpecialKillTileContext
	{
		[Cpp2IlInjected.Token(Token = "0x4007FC6")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007FC7")]
		MowingTheGrass
	}

	[Cpp2IlInjected.Token(Token = "0x200087A")]
	public delegate bool GetTreeFoliageDataMethod(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight);

	[Cpp2IlInjected.Token(Token = "0x200087B")]
	public struct TileMergeCullCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007FC8")]
		public bool CullTop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4007FC9")]
		public bool CullBottom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4007FCA")]
		public bool CullLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4007FCB")]
		public bool CullRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007FCC")]
		public bool CullTopLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4007FCD")]
		public bool CullTopRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4007FCE")]
		public bool CullBottomLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
		[Cpp2IlInjected.Token(Token = "0x4007FCF")]
		public bool CullBottomRight;

		[Cpp2IlInjected.Token(Token = "0x6004ADE")]
		[Cpp2IlInjected.Address(RVA = "0x39C37C", Offset = "0x39C37C", VA = "0x39C37C")]
		public void Cull(ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4002FF7")]
	public static TownRoomManager TownManager;

	[Cpp2IlInjected.Token(Token = "0x4002FF8")]
	private static Queue<Action<StructureMap>> _postGenActions;

	[Cpp2IlInjected.Token(Token = "0x4002FF9")]
	public static int tileReframeCount;

	[Cpp2IlInjected.Token(Token = "0x4002FFA")]
	public static int globalTileReframeCount;

	[Cpp2IlInjected.Token(Token = "0x4002FFB")]
	public static List<PendingRefame> pendingGlobalFrames;

	[Cpp2IlInjected.Token(Token = "0x4002FFC")]
	public static bool noMapUpdate;

	[Cpp2IlInjected.Token(Token = "0x4002FFD")]
	public static int treeBG1;

	[Cpp2IlInjected.Token(Token = "0x4002FFE")]
	public static int treeBG2;

	[Cpp2IlInjected.Token(Token = "0x4002FFF")]
	public static int treeBG3;

	[Cpp2IlInjected.Token(Token = "0x4003000")]
	public static int treeBG4;

	[Cpp2IlInjected.Token(Token = "0x4003001")]
	public static int corruptBG;

	[Cpp2IlInjected.Token(Token = "0x4003002")]
	public static int jungleBG;

	[Cpp2IlInjected.Token(Token = "0x4003003")]
	public static int snowBG;

	[Cpp2IlInjected.Token(Token = "0x4003004")]
	public static int hallowBG;

	[Cpp2IlInjected.Token(Token = "0x4003005")]
	public static int crimsonBG;

	[Cpp2IlInjected.Token(Token = "0x4003006")]
	public static int desertBG;

	[Cpp2IlInjected.Token(Token = "0x4003007")]
	public static int oceanBG;

	[Cpp2IlInjected.Token(Token = "0x4003008")]
	public static int mushroomBG;

	[Cpp2IlInjected.Token(Token = "0x4003009")]
	public static int underworldBG;

	[Cpp2IlInjected.Token(Token = "0x400300A")]
	public static readonly int oceanDistance;

	[Cpp2IlInjected.Token(Token = "0x400300B")]
	public static readonly int beachDistance;

	[Cpp2IlInjected.Token(Token = "0x400300C")]
	public static readonly int shimmerSafetyDistance;

	[Cpp2IlInjected.Token(Token = "0x400300D")]
	public static bool crimson;

	[Cpp2IlInjected.Token(Token = "0x400300E")]
	public static int[] tileCounts;

	[Cpp2IlInjected.Token(Token = "0x400300F")]
	public static int totalEvil;

	[Cpp2IlInjected.Token(Token = "0x4003010")]
	public static int totalBlood;

	[Cpp2IlInjected.Token(Token = "0x4003011")]
	public static int totalGood;

	[Cpp2IlInjected.Token(Token = "0x4003012")]
	public static int totalSolid;

	[Cpp2IlInjected.Token(Token = "0x4003013")]
	public static int totalEvil2;

	[Cpp2IlInjected.Token(Token = "0x4003014")]
	public static int totalBlood2;

	[Cpp2IlInjected.Token(Token = "0x4003015")]
	public static int totalGood2;

	[Cpp2IlInjected.Token(Token = "0x4003016")]
	public static int totalSolid2;

	[Cpp2IlInjected.Token(Token = "0x4003017")]
	public static byte tEvil;

	[Cpp2IlInjected.Token(Token = "0x4003018")]
	public static byte tBlood;

	[Cpp2IlInjected.Token(Token = "0x4003019")]
	public static byte tGood;

	[Cpp2IlInjected.Token(Token = "0x400301A")]
	public static string currentWorldSeed;

	[Cpp2IlInjected.Token(Token = "0x400301B")]
	public static int totalX;

	[Cpp2IlInjected.Token(Token = "0x400301C")]
	public static int totalD;

	[Cpp2IlInjected.Token(Token = "0x400301D")]
	public static bool IsGeneratingHardMode;

	[Cpp2IlInjected.Token(Token = "0x400301E")]
	public static int HardModeProgress;

	[Cpp2IlInjected.Token(Token = "0x400301F")]
	public static bool noTileActions;

	[Cpp2IlInjected.Token(Token = "0x4003020")]
	public static bool spawnEye;

	[Cpp2IlInjected.Token(Token = "0x4003021")]
	public static int spawnHardBoss;

	[Cpp2IlInjected.Token(Token = "0x4003022")]
	public static bool gen;

	[Cpp2IlInjected.Token(Token = "0x4003023")]
	public static bool shadowOrbSmashed;

	[Cpp2IlInjected.Token(Token = "0x4003024")]
	public static int shadowOrbCount;

	[Cpp2IlInjected.Token(Token = "0x4003025")]
	public static int altarCount;

	[Cpp2IlInjected.Token(Token = "0x4003026")]
	public static bool spawnMeteor;

	[Cpp2IlInjected.Token(Token = "0x4003027")]
	public static bool loadFailed;

	[Cpp2IlInjected.Token(Token = "0x4003028")]
	public static bool loadSuccess;

	[Cpp2IlInjected.Token(Token = "0x4003029")]
	public static bool worldCleared;

	[Cpp2IlInjected.Token(Token = "0x400302A")]
	public static bool worldBackup;

	[Cpp2IlInjected.Token(Token = "0x400302B")]
	public static bool loadBackup;

	[Cpp2IlInjected.Token(Token = "0x400302C")]
	private static int lastMaxTilesX;

	[Cpp2IlInjected.Token(Token = "0x400302D")]
	private static int lastMaxTilesY;

	[Cpp2IlInjected.Token(Token = "0x400302E")]
	private static bool mergeUp;

	[Cpp2IlInjected.Token(Token = "0x400302F")]
	private static bool mergeDown;

	[Cpp2IlInjected.Token(Token = "0x4003030")]
	private static bool mergeLeft;

	[Cpp2IlInjected.Token(Token = "0x4003031")]
	private static bool mergeRight;

	[Cpp2IlInjected.Token(Token = "0x4003032")]
	private static bool stopDrops;

	[Cpp2IlInjected.Token(Token = "0x4003033")]
	public static bool noLiquidCheck;

	[Cpp2IlInjected.Token(Token = "0x4003034")]
	public static bool AllowedToSpreadInfections;

	[Cpp2IlInjected.Token(Token = "0x4003035")]
	[ThreadStatic]
	public static UnifiedRandom _genRand;

	[Cpp2IlInjected.Token(Token = "0x4003036")]
	[ThreadStatic]
	public static int _genRandSeed;

	[Cpp2IlInjected.Token(Token = "0x4003037")]
	public static int _lastSeed;

	[Cpp2IlInjected.Token(Token = "0x4003038")]
	public static string statusText;

	[Cpp2IlInjected.Token(Token = "0x4003039")]
	public static bool destroyObject;

	[Cpp2IlInjected.Token(Token = "0x400303A")]
	public static int spawnDelay;

	[Cpp2IlInjected.Token(Token = "0x400303B")]
	public static int prioritizedTownNPCType;

	[Cpp2IlInjected.Token(Token = "0x400303C")]
	public static int numTileCount;

	[Cpp2IlInjected.Token(Token = "0x400303D")]
	public static int maxTileCount;

	[Cpp2IlInjected.Token(Token = "0x400303E")]
	public static int maxWallOut2;

	[Cpp2IlInjected.Token(Token = "0x400303F")]
	public static int lavaCount;

	[Cpp2IlInjected.Token(Token = "0x4003040")]
	public static int iceCount;

	[Cpp2IlInjected.Token(Token = "0x4003041")]
	public static int sandCount;

	[Cpp2IlInjected.Token(Token = "0x4003042")]
	public static int rockCount;

	[Cpp2IlInjected.Token(Token = "0x4003043")]
	public static int shroomCount;

	[Cpp2IlInjected.Token(Token = "0x4003044")]
	public static int maxRoomTiles;

	[Cpp2IlInjected.Token(Token = "0x4003045")]
	public static int numRoomTiles;

	[Cpp2IlInjected.Token(Token = "0x4003046")]
	public static int[] roomX;

	[Cpp2IlInjected.Token(Token = "0x4003047")]
	public static int[] roomY;

	[Cpp2IlInjected.Token(Token = "0x4003048")]
	public static int roomCeilingsCount;

	[Cpp2IlInjected.Token(Token = "0x4003049")]
	public static int[] roomCeilingX;

	[Cpp2IlInjected.Token(Token = "0x400304A")]
	public static int[] roomCeilingY;

	[Cpp2IlInjected.Token(Token = "0x400304B")]
	public static int roomX1;

	[Cpp2IlInjected.Token(Token = "0x400304C")]
	public static int roomX2;

	[Cpp2IlInjected.Token(Token = "0x400304D")]
	public static int roomY1;

	[Cpp2IlInjected.Token(Token = "0x400304E")]
	public static int roomY2;

	[Cpp2IlInjected.Token(Token = "0x400304F")]
	public static bool canSpawn;

	[Cpp2IlInjected.Token(Token = "0x4003050")]
	public static bool[] houseTile;

	[Cpp2IlInjected.Token(Token = "0x4003051")]
	public static int bestX;

	[Cpp2IlInjected.Token(Token = "0x4003052")]
	public static int bestY;

	[Cpp2IlInjected.Token(Token = "0x4003053")]
	public static int hiScore;

	[Cpp2IlInjected.Token(Token = "0x4003054")]
	private static bool roomTorch;

	[Cpp2IlInjected.Token(Token = "0x4003055")]
	private static bool roomDoor;

	[Cpp2IlInjected.Token(Token = "0x4003056")]
	private static bool roomChair;

	[Cpp2IlInjected.Token(Token = "0x4003057")]
	private static bool roomTable;

	[Cpp2IlInjected.Token(Token = "0x4003058")]
	private static bool roomOccupied;

	[Cpp2IlInjected.Token(Token = "0x4003059")]
	private static bool roomEvil;

	[Cpp2IlInjected.Token(Token = "0x400305A")]
	private static bool roomHasStinkbug;

	[Cpp2IlInjected.Token(Token = "0x400305B")]
	private static bool roomHasEchoStinkbug;

	[Cpp2IlInjected.Token(Token = "0x400305C")]
	public static int WorldGenParam_Evil;

	[Cpp2IlInjected.Token(Token = "0x400305D")]
	public static readonly int cactusWaterWidth;

	[Cpp2IlInjected.Token(Token = "0x400305E")]
	public static readonly int cactusWaterHeight;

	[Cpp2IlInjected.Token(Token = "0x400305F")]
	public static readonly int cactusWaterLimit;

	[Cpp2IlInjected.Token(Token = "0x4003060")]
	public static MysticLogFairiesEvent mysticLogsEvent;

	[Cpp2IlInjected.Token(Token = "0x4003061")]
	private static bool currentlyTryingToUseAlternateHousingSpot;

	[Cpp2IlInjected.Token(Token = "0x4003062")]
	private static int sharedRoomX;

	[Cpp2IlInjected.Token(Token = "0x4003063")]
	public static TownNPCRoomCheckFailureReason roomCheckFailureReason;

	[Cpp2IlInjected.Token(Token = "0x4003064")]
	public const int WorldSizeSmallX = 4200;

	[Cpp2IlInjected.Token(Token = "0x4003065")]
	public const int WorldSizeSmallY = 1200;

	[Cpp2IlInjected.Token(Token = "0x4003066")]
	public const int WorldSizeMediumX = 6400;

	[Cpp2IlInjected.Token(Token = "0x4003067")]
	public const int WorldSizeMediumY = 1800;

	[Cpp2IlInjected.Token(Token = "0x4003068")]
	public const int WorldSizeLargeX = 8400;

	[Cpp2IlInjected.Token(Token = "0x4003069")]
	public const int WorldSizeLargeY = 2400;

	[Cpp2IlInjected.Token(Token = "0x400306A")]
	public const int InfectionAndGrassSpreadOuterWorldBuffer = 10;

	[Cpp2IlInjected.Token(Token = "0x400306B")]
	public static bool generatingWorld;

	[Cpp2IlInjected.Token(Token = "0x400306C")]
	public static ManagedThread worldGenThread;

	[Cpp2IlInjected.Token(Token = "0x400306D")]
	public static bool SavingSettings;

	[Cpp2IlInjected.Token(Token = "0x400306E")]
	public static bool SavingPlayer;

	[Cpp2IlInjected.Token(Token = "0x400306F")]
	private static int[,] trapDiag;

	[Cpp2IlInjected.Token(Token = "0x4003070")]
	public static List<nextCountNode> _countOpenNodes;

	[Cpp2IlInjected.Token(Token = "0x4003071")]
	public static List<nextCountNode> _countAvailableNodes;

	[Cpp2IlInjected.Token(Token = "0x4003072")]
	private static List<nextCountDirtNode> _dirtCountOpenNodes;

	[Cpp2IlInjected.Token(Token = "0x4003073")]
	private static List<nextCountDirtNode> _dirtCountAvailableNodes;

	[Cpp2IlInjected.Token(Token = "0x4003074")]
	private static bool[] gem;

	[Cpp2IlInjected.Token(Token = "0x4003075")]
	private static int[] mossType;

	[Cpp2IlInjected.Token(Token = "0x4003076")]
	private static ushort neonMossType;

	[Cpp2IlInjected.Token(Token = "0x4003077")]
	private static int tileCounterNum;

	[Cpp2IlInjected.Token(Token = "0x4003078")]
	private static int tileCounterMax;

	[Cpp2IlInjected.Token(Token = "0x4003079")]
	private static int[] tileCounterX;

	[Cpp2IlInjected.Token(Token = "0x400307A")]
	private static int[] tileCounterY;

	[Cpp2IlInjected.Token(Token = "0x400307B")]
	public static ushort lastTileCounterSearch;

	[Cpp2IlInjected.Token(Token = "0x400307C")]
	private static WorldGenerator _generator;

	[Cpp2IlInjected.Token(Token = "0x400307D")]
	public static int SmallConsecutivesFound;

	[Cpp2IlInjected.Token(Token = "0x400307E")]
	public static int SmallConsecutivesEliminated;

	[Cpp2IlInjected.Token(Token = "0x400307F")]
	public static bool tempRemixWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003080")]
	public static bool remixWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003081")]
	public static bool everythingWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003082")]
	public static bool noTrapsWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003083")]
	public static bool drunkWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003084")]
	public static bool getGoodWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003085")]
	public static bool tempTenthAnniversaryWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003086")]
	public static bool tenthAnniversaryWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003087")]
	public static bool dontStarveWorldGen;

	[Cpp2IlInjected.Token(Token = "0x4003088")]
	public static bool notTheBees;

	[Cpp2IlInjected.Token(Token = "0x4003089")]
	public static bool drunkWorldGenText;

	[Cpp2IlInjected.Token(Token = "0x400308A")]
	public static bool placingTraps;

	[Cpp2IlInjected.Token(Token = "0x400308B")]
	public const bool USE_FRAMING_SKIP_FOR_UNIMPORTANT_TILES_IN_WORLDGEN = false;

	[Cpp2IlInjected.Token(Token = "0x400308C")]
	private const int ItemSpawnProtectionTime = 18000;

	[Cpp2IlInjected.Token(Token = "0x400308D")]
	public static Thread ConversionThread;

	[Cpp2IlInjected.Token(Token = "0x400308E")]
	private static List<Point> ShimmerTiles;

	[Cpp2IlInjected.Token(Token = "0x400308F")]
	private static List<Color> _coatingColors;

	[Cpp2IlInjected.Token(Token = "0x4003090")]
	private static int catTailDistance;

	[Cpp2IlInjected.Token(Token = "0x4003091")]
	public static TreeTopsInfo TreeTops;

	[Cpp2IlInjected.Token(Token = "0x4003092")]
	public static BackgroundChangeFlashInfo BackgroundsCache;

	[Cpp2IlInjected.Token(Token = "0x4003093")]
	private static int maxTreeShakes;

	[Cpp2IlInjected.Token(Token = "0x4003094")]
	private static int numTreeShakes;

	[Cpp2IlInjected.Token(Token = "0x4003095")]
	private static int[] treeShakeX;

	[Cpp2IlInjected.Token(Token = "0x4003096")]
	private static int[] treeShakeY;

	[Cpp2IlInjected.Token(Token = "0x4003097")]
	private static bool fossilBreak;

	[Cpp2IlInjected.Token(Token = "0x4003098")]
	public static Queue<Point> ExploitDestroyQueue;

	[Cpp2IlInjected.Token(Token = "0x4003099")]
	private static int _lastFrame;

	[Cpp2IlInjected.Token(Token = "0x400309A")]
	private static bool growGrassUnderground;

	[Cpp2IlInjected.Token(Token = "0x400309B")]
	public const bool BUBBLES_SOLID_STATE_FOR_HOUSING = true;

	[Cpp2IlInjected.Token(Token = "0x400309C")]
	public static int grassSpread;

	[Cpp2IlInjected.Token(Token = "0x400309D")]
	private static Point[] heartPos;

	[Cpp2IlInjected.Token(Token = "0x400309E")]
	private static int heartCount;

	[Cpp2IlInjected.Token(Token = "0x400309F")]
	private static object WaitingLock;

	[Cpp2IlInjected.Token(Token = "0x40030A0")]
	private static bool ThreadWaiting;

	[Cpp2IlInjected.Token(Token = "0x40030A1")]
	private static bool ThreadRunning;

	[Cpp2IlInjected.Token(Token = "0x40030A2")]
	private static DateTime ThreadStarted;

	[Cpp2IlInjected.Token(Token = "0x40030A3")]
	private static bool threadInProgress;

	[Cpp2IlInjected.Token(Token = "0x40030A4")]
	private const int strip_w = 200;

	[Cpp2IlInjected.Token(Token = "0x40030A5")]
	private const int strip_h = 50;

	[Cpp2IlInjected.Token(Token = "0x40030A6")]
	private static readonly Vertical64BitStrips bitStrip;

	[Cpp2IlInjected.Token(Token = "0x40030A7")]
	public static bool noMapUpdateRefresh;

	[Cpp2IlInjected.Token(Token = "0x40030A8")]
	private const int MaxCachedUpdates = 20000;

	[Cpp2IlInjected.Token(Token = "0x40030A9")]
	private static uint[] CachedMapTileUpdates;

	[Cpp2IlInjected.Token(Token = "0x40030AA")]
	private static int CachedMapTileUpdateCount;

	[Cpp2IlInjected.Token(Token = "0x40030AB")]
	private static bool skipFramingDuringGen;

	[Cpp2IlInjected.Token(Token = "0x40030AC")]
	public static bool LogFrames;

	[Cpp2IlInjected.Token(Token = "0x40030AD")]
	private static int currentStack;

	[Cpp2IlInjected.Token(Token = "0x40030AE")]
	private static int maxStack;

	[Cpp2IlInjected.Token(Token = "0x40030AF")]
	private static Rectangle fallingBlockRegion;

	[Cpp2IlInjected.Token(Token = "0x40030B0")]
	private static int maxCount;

	[Cpp2IlInjected.Token(Token = "0x17000590")]
	public static UnifiedRandom genRand
	{
		[Cpp2IlInjected.Token(Token = "0x60029AB")]
		[Cpp2IlInjected.Address(RVA = "0xA1ACD0", Offset = "0xA1ACD0", VA = "0xA1ACD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000591")]
	public static double oceanLevel
	{
		[Cpp2IlInjected.Token(Token = "0x6002A1E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E230", Offset = "0xA4E230", VA = "0xA4E230")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000592")]
	public static bool SkipFramingBecauseOfGen
	{
		[Cpp2IlInjected.Token(Token = "0x6002C18")]
		[Cpp2IlInjected.Address(RVA = "0xB65604", Offset = "0xB65604", VA = "0xB65604")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60029AC")]
	[Cpp2IlInjected.Address(RVA = "0xA1AE98", Offset = "0xA1AE98", VA = "0xA1AE98")]
	public static void SetupStatueList()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029AD")]
	[Cpp2IlInjected.Address(RVA = "0xA1B4A0", Offset = "0xA1B4A0", VA = "0xA1B4A0")]
	public static void PlaceStatueTrap(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029AE")]
	[Cpp2IlInjected.Address(RVA = "0xA21D04", Offset = "0xA21D04", VA = "0xA21D04")]
	private static EntitySource_TileBreak GetProjectileSource_TileBreak(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60029AF")]
	[Cpp2IlInjected.Address(RVA = "0xA21D0C", Offset = "0xA21D0C", VA = "0xA21D0C")]
	private static EntitySource_TileBreak GetNPCSource_TileBreak(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60029B0")]
	[Cpp2IlInjected.Address(RVA = "0xA21D14", Offset = "0xA21D14", VA = "0xA21D14")]
	public static EntitySource_ShakeTree GetNPCSource_ShakeTree(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60029B1")]
	[Cpp2IlInjected.Address(RVA = "0xA21D88", Offset = "0xA21D88", VA = "0xA21D88")]
	private static EntitySource_ShakeTree GetProjectileSource_ShakeTree(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60029B2")]
	[Cpp2IlInjected.Address(RVA = "0xA21DFC", Offset = "0xA21DFC", VA = "0xA21DFC")]
	private static EntitySource_ShakeTree GetItemSource_ShakeTree(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60029B3")]
	[Cpp2IlInjected.Address(RVA = "0xA21E70", Offset = "0xA21E70", VA = "0xA21E70")]
	private static IEntitySource GetProjectileSource_PlayerOrWires(int x, int y, bool fromWiring, Player player)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60029B4")]
	[Cpp2IlInjected.Address(RVA = "0xA21F34", Offset = "0xA21F34", VA = "0xA21F34")]
	public static bool EmptyLiquid(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029B5")]
	[Cpp2IlInjected.Address(RVA = "0xA22400", Offset = "0xA22400", VA = "0xA22400")]
	public static bool PlaceLiquid(int x, int y, byte liquidType, byte amount)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029B6")]
	[Cpp2IlInjected.Address(RVA = "0xA22998", Offset = "0xA22998", VA = "0xA22998")]
	public static void PlayLiquidChangeSound(TileChangeType eventType, int x, int y, int count = 1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029B7")]
	[Cpp2IlInjected.Address(RVA = "0xA228C8", Offset = "0xA228C8", VA = "0xA228C8")]
	public static TileChangeType GetLiquidChangeType(int liquidType, int otherLiquidType)
	{
		return default(TileChangeType);
	}

	[Cpp2IlInjected.Token(Token = "0x60029B8")]
	[Cpp2IlInjected.Address(RVA = "0xA22B30", Offset = "0xA22B30", VA = "0xA22B30")]
	public static bool MoveTownNPC(int x, int y, int n)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029B9")]
	[Cpp2IlInjected.Address(RVA = "0xA24E08", Offset = "0xA24E08", VA = "0xA24E08")]
	public static void moveRoom(int x, int y, int n)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029BA")]
	[Cpp2IlInjected.Address(RVA = "0xA26590", Offset = "0xA26590", VA = "0xA26590")]
	public static bool IsNPCEvictable(int n)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029BB")]
	[Cpp2IlInjected.Address(RVA = "0xA266D0", Offset = "0xA266D0", VA = "0xA266D0")]
	public static void kickOut(int n)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029BC")]
	[Cpp2IlInjected.Address(RVA = "0xA26860", Offset = "0xA26860", VA = "0xA26860")]
	public static bool IsThereASpawnablePrioritizedTownNPC(int x, int y, ref bool canSpawnNewTownNPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029BD")]
	[Cpp2IlInjected.Address(RVA = "0xA26D68", Offset = "0xA26D68", VA = "0xA26D68")]
	public static bool IsThereASpawnablePrioritizedTownNPC_Old(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029BE")]
	[Cpp2IlInjected.Address(RVA = "0xA24B18", Offset = "0xA24B18", VA = "0xA24B18")]
	public static bool CheckSpecialTownNPCSpawningConditions(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029BF")]
	[Cpp2IlInjected.Address(RVA = "0xA27494", Offset = "0xA27494", VA = "0xA27494")]
	public static void UnspawnTravelNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029C0")]
	[Cpp2IlInjected.Address(RVA = "0xA27BBC", Offset = "0xA27BBC", VA = "0xA27BBC")]
	public static void SpawnTravelNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029C1")]
	[Cpp2IlInjected.Address(RVA = "0xA24FEC", Offset = "0xA24FEC", VA = "0xA24FEC")]
	public static TownNPCSpawnResult SpawnTownNPC(int x, int y)
	{
		return default(TownNPCSpawnResult);
	}

	[Cpp2IlInjected.Token(Token = "0x60029C2")]
	[Cpp2IlInjected.Address(RVA = "0xA2998C", Offset = "0xA2998C", VA = "0xA2998C")]
	private static int FindAHomelessNPC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60029C3")]
	[Cpp2IlInjected.Address(RVA = "0xA29B48", Offset = "0xA29B48", VA = "0xA29B48")]
	private static bool IsRoomConsideredAlreadyOccupied(int spawnTileX, int spawnTileY, int npcTypeToSpawn)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029C4")]
	[Cpp2IlInjected.Address(RVA = "0xA29C84", Offset = "0xA29C84", VA = "0xA29C84")]
	public static void CheckAchievement_RealEstateAndTownSlimes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029C5")]
	[Cpp2IlInjected.Address(RVA = "0xA23818", Offset = "0xA23818", VA = "0xA23818")]
	public static bool RoomNeeds(int npcType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029C6")]
	[Cpp2IlInjected.Address(RVA = "0xA29F50", Offset = "0xA29F50", VA = "0xA29F50")]
	public static void QuickFindHome(int npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029C7")]
	[Cpp2IlInjected.Address(RVA = "0xA2A738", Offset = "0xA2A738", VA = "0xA2A738")]
	private static bool IsRoomConsideredOccupiedForNPCIndex(int npc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029C8")]
	[Cpp2IlInjected.Address(RVA = "0xA2A910", Offset = "0xA2A910", VA = "0xA2A910")]
	private static bool ScoreRoom_IsThisRoomOccupiedBySomeone(int ignoreNPC = -1, int npcTypeAsking = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029C9")]
	[Cpp2IlInjected.Address(RVA = "0xA2AD98", Offset = "0xA2AD98", VA = "0xA2AD98")]
	public static void CountTileTypesInArea(int[] tileTypeCounts, int startX, int endX, int startY, int endY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029CA")]
	[Cpp2IlInjected.Address(RVA = "0xA2AEF0", Offset = "0xA2AEF0", VA = "0xA2AEF0")]
	public static int GetTileTypeCountByCategory(int[] tileTypeCounts, TileScanGroup group)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60029CB")]
	[Cpp2IlInjected.Address(RVA = "0xA23DB0", Offset = "0xA23DB0", VA = "0xA23DB0")]
	public static void ScoreRoom(int ignoreNPC = -1, int npcTypeAskingToScoreRoom = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029CC")]
	[Cpp2IlInjected.Address(RVA = "0xA272C4", Offset = "0xA272C4", VA = "0xA272C4")]
	public static void Housing_GetTestedRoomBounds(out int startX, out int endX, out int startY, out int endY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029CD")]
	[Cpp2IlInjected.Address(RVA = "0xA2B09C", Offset = "0xA2B09C", VA = "0xA2B09C")]
	private static bool ScoreRoom_CanBeHomeSpot(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029CE")]
	[Cpp2IlInjected.Address(RVA = "0xA2B394", Offset = "0xA2B394", VA = "0xA2B394")]
	private static bool Housing_CheckIfIsCeiling(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029CF")]
	[Cpp2IlInjected.Address(RVA = "0xA2B288", Offset = "0xA2B288", VA = "0xA2B288")]
	private static bool Housing_CheckIfInRoom(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029D0")]
	[Cpp2IlInjected.Address(RVA = "0xA234B0", Offset = "0xA234B0", VA = "0xA234B0")]
	public static bool StartRoomCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029D1")]
	[Cpp2IlInjected.Address(RVA = "0xA2B4A0", Offset = "0xA2B4A0", VA = "0xA2B4A0")]
	public static void CheckRoom(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029D2")]
	[Cpp2IlInjected.Address(RVA = "0xA2C3F8", Offset = "0xA2C3F8", VA = "0xA2C3F8")]
	public static void dropMeteor()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029D3")]
	[Cpp2IlInjected.Address(RVA = "0xA2CCF0", Offset = "0xA2CCF0", VA = "0xA2CCF0")]
	public static bool meteor(int i, int j, bool ignorePlayers = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029D4")]
	[Cpp2IlInjected.Address(RVA = "0xA3137C", Offset = "0xA3137C", VA = "0xA3137C")]
	public static void setWorldSize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029D5")]
	[Cpp2IlInjected.Address(RVA = "0xA31514", Offset = "0xA31514", VA = "0xA31514")]
	public static int GetWorldSize()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60029D6")]
	[Cpp2IlInjected.Address(RVA = "0xA315D4", Offset = "0xA315D4", VA = "0xA315D4")]
	public static void worldGenCallback(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029D7")]
	[Cpp2IlInjected.Address(RVA = "0xA31A6C", Offset = "0xA31A6C", VA = "0xA31A6C")]
	public static void CreateNewWorld([Optional] GenerationProgress progress)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029D8")]
	[Cpp2IlInjected.Address(RVA = "0xA31C28", Offset = "0xA31C28", VA = "0xA31C28")]
	public static void JustQuit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029D9")]
	[Cpp2IlInjected.Address(RVA = "0xA31F44", Offset = "0xA31F44", VA = "0xA31F44")]
	private static void ShutDownServer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029DA")]
	[Cpp2IlInjected.Address(RVA = "0xA31FD4", Offset = "0xA31FD4", VA = "0xA31FD4")]
	private static void WaitForFileSync()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029DB")]
	[Cpp2IlInjected.Address(RVA = "0xA32178", Offset = "0xA32178", VA = "0xA32178")]
	public static void SaveAndQuitCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029DC")]
	[Cpp2IlInjected.Address(RVA = "0xA32C40", Offset = "0xA32C40", VA = "0xA32C40")]
	private static void LocalUserQuitOnMainThread(object localUserContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029DD")]
	[Cpp2IlInjected.Address(RVA = "0xA32D00", Offset = "0xA32D00", VA = "0xA32D00")]
	public static void SaveAndQuit()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029DE")]
	[Cpp2IlInjected.Address(RVA = "0xA32E5C", Offset = "0xA32E5C", VA = "0xA32E5C")]
	public static void RenameWorld(WorldFileData data, string newName, [Optional] Action<string> callback)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029DF")]
	[Cpp2IlInjected.Address(RVA = "0xA32F20", Offset = "0xA32F20", VA = "0xA32F20")]
	public static void RenameWorldCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E0")]
	[Cpp2IlInjected.Address(RVA = "0xA33200", Offset = "0xA33200", VA = "0xA33200")]
	public static void playWorldCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E1")]
	[Cpp2IlInjected.Address(RVA = "0xA340E8", Offset = "0xA340E8", VA = "0xA340E8")]
	public static void JoinLocalWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E2")]
	[Cpp2IlInjected.Address(RVA = "0xA341DC", Offset = "0xA341DC", VA = "0xA341DC")]
	public static void joinLocalWorldCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E3")]
	[Cpp2IlInjected.Address(RVA = "0xA3471C", Offset = "0xA3471C", VA = "0xA3471C")]
	public static void FinaliseOnMainThread(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E4")]
	[Cpp2IlInjected.Address(RVA = "0xA34C74", Offset = "0xA34C74", VA = "0xA34C74")]
	public static void playWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E5")]
	[Cpp2IlInjected.Address(RVA = "0xA34DCC", Offset = "0xA34DCC", VA = "0xA34DCC")]
	public static void saveAndPlayCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E6")]
	[Cpp2IlInjected.Address(RVA = "0xA34E8C", Offset = "0xA34E8C", VA = "0xA34E8C")]
	public static void saveAndPlay()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E7")]
	[Cpp2IlInjected.Address(RVA = "0xA34F80", Offset = "0xA34F80", VA = "0xA34F80")]
	public static void saveToonWhilePlayingCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E8")]
	[Cpp2IlInjected.Address(RVA = "0xA352E0", Offset = "0xA352E0", VA = "0xA352E0")]
	public static void saveToonWhilePlaying()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029E9")]
	[Cpp2IlInjected.Address(RVA = "0xA353D4", Offset = "0xA353D4", VA = "0xA353D4")]
	public static void serverLoadWorldCallBack()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029EA")]
	[Cpp2IlInjected.Address(RVA = "0xA35C28", Offset = "0xA35C28", VA = "0xA35C28")]
	public static ManagedThread serverLoadWorld()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60029EB")]
	[Cpp2IlInjected.Address(RVA = "0xA35CD8", Offset = "0xA35CD8", VA = "0xA35CD8")]
	private static void SetWorldSizeOnMainThread(object data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029EC")]
	[Cpp2IlInjected.Address(RVA = "0xA12E20", Offset = "0xA12E20", VA = "0xA12E20")]
	public static void clearWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029ED")]
	[Cpp2IlInjected.Address(RVA = "0xA35FE0", Offset = "0xA35FE0", VA = "0xA35FE0")]
	public static void setBG(int bg, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029EE")]
	[Cpp2IlInjected.Address(RVA = "0xA37B2C", Offset = "0xA37B2C", VA = "0xA37B2C")]
	private static void SetForestBGSet(int style, int[] mountainSet, int[] treeSet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029EF")]
	[Cpp2IlInjected.Address(RVA = "0xA37D3C", Offset = "0xA37D3C", VA = "0xA37D3C")]
	public static void RandomizeWeather()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029F0")]
	[Cpp2IlInjected.Address(RVA = "0xA37F0C", Offset = "0xA37F0C", VA = "0xA37F0C")]
	public static void RandomizeMoonState(UnifiedRandom random, bool garenteeNewStyle = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029F1")]
	[Cpp2IlInjected.Address(RVA = "0xA3800C", Offset = "0xA3800C", VA = "0xA3800C")]
	public static void RandomizeBackgroundBasedOnPlayer(UnifiedRandom random, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029F2")]
	[Cpp2IlInjected.Address(RVA = "0xA3904C", Offset = "0xA3904C", VA = "0xA3904C")]
	public static void RandomizeBackgrounds(UnifiedRandom random)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029F3")]
	[Cpp2IlInjected.Address(RVA = "0xA38EB0", Offset = "0xA38EB0", VA = "0xA38EB0")]
	private static int RollRandomForestBGStyle(UnifiedRandom random)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60029F4")]
	[Cpp2IlInjected.Address(RVA = "0xA38FB0", Offset = "0xA38FB0", VA = "0xA38FB0")]
	public static bool IsBackgroundConsideredTheSame(int oldBG, int newBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029F5")]
	[Cpp2IlInjected.Address(RVA = "0xA39698", Offset = "0xA39698", VA = "0xA39698")]
	public static void RandomizeTreeStyle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029F6")]
	[Cpp2IlInjected.Address(RVA = "0xA3A290", Offset = "0xA3A290", VA = "0xA3A290")]
	public static void RandomizeCaveBackgrounds()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029F7")]
	[Cpp2IlInjected.Address(RVA = "0xA3ACCC", Offset = "0xA3ACCC", VA = "0xA3ACCC")]
	private static void ResetGenerator()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60029F8")]
	[Cpp2IlInjected.Address(RVA = "0xA3AE74", Offset = "0xA3AE74", VA = "0xA3AE74")]
	public static bool mayanTrap(int x2, int y2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029F9")]
	[Cpp2IlInjected.Address(RVA = "0xA3D248", Offset = "0xA3D248", VA = "0xA3D248")]
	public static bool placeLavaTrap(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029FA")]
	[Cpp2IlInjected.Address(RVA = "0xA3DDA4", Offset = "0xA3DDA4", VA = "0xA3DDA4")]
	public static bool IsTileNearby(int x, int y, int type, int distance)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029FB")]
	[Cpp2IlInjected.Address(RVA = "0xA3E098", Offset = "0xA3E098", VA = "0xA3E098")]
	private static bool placeTNTBarrel(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029FC")]
	[Cpp2IlInjected.Address(RVA = "0xA3E250", Offset = "0xA3E250", VA = "0xA3E250")]
	public static bool placeTrap(int x2, int y2, int type = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60029FD")]
	[Cpp2IlInjected.Address(RVA = "0xA40ED0", Offset = "0xA40ED0", VA = "0xA40ED0")]
	public static int countWires(int x, int y, int size)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60029FE")]
	[Cpp2IlInjected.Address(RVA = "0xA41118", Offset = "0xA41118", VA = "0xA41118")]
	public static int countTiles(int x, int y, bool jungle = false, bool lavaOk = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60029FF")]
	[Cpp2IlInjected.Address(RVA = "0xA411F4", Offset = "0xA411F4", VA = "0xA411F4")]
	public static void nextCount(int x, int y, bool jungle = false, bool lavaOk = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A00")]
	[Cpp2IlInjected.Address(RVA = "0xA42100", Offset = "0xA42100", VA = "0xA42100")]
	public static int countDirtTiles(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A01")]
	[Cpp2IlInjected.Address(RVA = "0xA4219C", Offset = "0xA4219C", VA = "0xA4219C")]
	public static void nextDirtCount(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A02")]
	[Cpp2IlInjected.Address(RVA = "0xA221E0", Offset = "0xA221E0", VA = "0xA221E0")]
	public static bool InWorld(int x, int y, int fluff = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A03")]
	[Cpp2IlInjected.Address(RVA = "0xA43CC4", Offset = "0xA43CC4", VA = "0xA43CC4")]
	public static void gemCave(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A04")]
	[Cpp2IlInjected.Address(RVA = "0xA43E70", Offset = "0xA43E70", VA = "0xA43E70")]
	public static int randGem()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A05")]
	[Cpp2IlInjected.Address(RVA = "0xA43F30", Offset = "0xA43F30", VA = "0xA43F30")]
	public static ushort randGemTile()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A06")]
	[Cpp2IlInjected.Address(RVA = "0xA44030", Offset = "0xA44030", VA = "0xA44030")]
	public static void randMoss(bool justNeon = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A07")]
	[Cpp2IlInjected.Address(RVA = "0xA44300", Offset = "0xA44300", VA = "0xA44300")]
	public static void neonMossBiome(int i, int j, int maxY = 99999)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A08")]
	[Cpp2IlInjected.Address(RVA = "0xA45A00", Offset = "0xA45A00", VA = "0xA45A00")]
	public static void setMoss(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A09")]
	[Cpp2IlInjected.Address(RVA = "0xA45BA4", Offset = "0xA45BA4", VA = "0xA45BA4")]
	public static void FillWallHolesInArea(Rectangle worldCoordsArea)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A0A")]
	[Cpp2IlInjected.Address(RVA = "0xA45D34", Offset = "0xA45D34", VA = "0xA45D34")]
	private static int FillWallHolesInColumn(int x, int startY, int endY)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A0B")]
	[Cpp2IlInjected.Address(RVA = "0xA45F54", Offset = "0xA45F54", VA = "0xA45F54")]
	private static bool FillWallHolesInSpot(int originX, int originY, int maxWallsThreshold)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A0C")]
	[Cpp2IlInjected.Address(RVA = "0xA4688C", Offset = "0xA4688C", VA = "0xA4688C")]
	public static void tileCountAndDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A0D")]
	[Cpp2IlInjected.Address(RVA = "0xA46AA0", Offset = "0xA46AA0", VA = "0xA46AA0")]
	public static int tileCounter(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A0E")]
	[Cpp2IlInjected.Address(RVA = "0xA46DBC", Offset = "0xA46DBC", VA = "0xA46DBC")]
	public static void tileCounterNext(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A0F")]
	[Cpp2IlInjected.Address(RVA = "0xA46C4C", Offset = "0xA46C4C", VA = "0xA46C4C")]
	public static void tileCounterKill()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A10")]
	[Cpp2IlInjected.Address(RVA = "0xA47168", Offset = "0xA47168", VA = "0xA47168")]
	private static void AddGenerationPass(string name, WorldGenLegacyMethod method)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A11")]
	[Cpp2IlInjected.Address(RVA = "0xA4721C", Offset = "0xA4721C", VA = "0xA4721C")]
	private static void AddGenerationPass(GenPass pass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A12")]
	[Cpp2IlInjected.Address(RVA = "0xA472A0", Offset = "0xA472A0", VA = "0xA472A0")]
	private static void AddGenerationPass(string name, double weight, WorldGenLegacyMethod method)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A13")]
	[Cpp2IlInjected.Address(RVA = "0xA47380", Offset = "0xA47380", VA = "0xA47380")]
	public static bool checkUnderground(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A14")]
	[Cpp2IlInjected.Address(RVA = "0xA476E8", Offset = "0xA476E8", VA = "0xA476E8")]
	public static int GetNextJungleChestItem()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A15")]
	[Cpp2IlInjected.Address(RVA = "0xA47888", Offset = "0xA47888", VA = "0xA47888")]
	private static void ScanTileColumnAndRemoveClumps(int x)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A16")]
	[Cpp2IlInjected.Address(RVA = "0xA47BAC", Offset = "0xA47BAC", VA = "0xA47BAC")]
	public static void OreHelper(int X, int Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A17")]
	[Cpp2IlInjected.Address(RVA = "0xA47CC8", Offset = "0xA47CC8", VA = "0xA47CC8")]
	public static bool StonePatch(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A18")]
	[Cpp2IlInjected.Address(RVA = "0xA492A8", Offset = "0xA492A8", VA = "0xA492A8")]
	public static bool ShellPile(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A19")]
	[Cpp2IlInjected.Address(RVA = "0xA49E00", Offset = "0xA49E00", VA = "0xA49E00")]
	public static bool MarblePileWithStatues(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A1A")]
	[Cpp2IlInjected.Address(RVA = "0xA4AD0C", Offset = "0xA4AD0C", VA = "0xA4AD0C")]
	public static bool Statue(int x, int y, byte paint)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A1B")]
	[Cpp2IlInjected.Address(RVA = "0xA4AFB8", Offset = "0xA4AFB8", VA = "0xA4AFB8")]
	public static bool OrePatch(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A1C")]
	[Cpp2IlInjected.Address(RVA = "0xA4C3C8", Offset = "0xA4C3C8", VA = "0xA4C3C8")]
	public static bool PlaceOasis(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A1D")]
	[Cpp2IlInjected.Address(RVA = "0xA4DFC8", Offset = "0xA4DFC8", VA = "0xA4DFC8")]
	public static bool BiomeTileCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A1F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E2CC", Offset = "0xA4E2CC", VA = "0xA4E2CC")]
	public static bool oceanDepths(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A20")]
	[Cpp2IlInjected.Address(RVA = "0xA4E418", Offset = "0xA4E418", VA = "0xA4E418")]
	public static void UpdateDesertHiveBounds(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A21")]
	[Cpp2IlInjected.Address(RVA = "0xA14204", Offset = "0xA14204", VA = "0xA14204")]
	public static void GenerateWorld(int seed, [Optional] GenerationProgress customProgressObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A22")]
	[Cpp2IlInjected.Address(RVA = "0xA4E6C4", Offset = "0xA4E6C4", VA = "0xA4E6C4")]
	private static Point GetAdjustedFloorPosition(int x, int y)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A23")]
	[Cpp2IlInjected.Address(RVA = "0xA4E87C", Offset = "0xA4E87C", VA = "0xA4E87C")]
	private static void Scan3By3(int topLeftX, int topLeftY, out bool isEmpty, out bool hasFloor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A24")]
	[Cpp2IlInjected.Address(RVA = "0xA4E9CC", Offset = "0xA4E9CC", VA = "0xA4E9CC")]
	private static void FinishTenthAnniversaryWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A25")]
	[Cpp2IlInjected.Address(RVA = "0xA505E4", Offset = "0xA505E4", VA = "0xA505E4")]
	private static void PaintTheMushrooms()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A26")]
	[Cpp2IlInjected.Address(RVA = "0xA50348", Offset = "0xA50348", VA = "0xA50348")]
	private static void PaintTheTrees()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A27")]
	[Cpp2IlInjected.Address(RVA = "0xA4FB2C", Offset = "0xA4FB2C", VA = "0xA4FB2C")]
	private static void PaintTheSand(byte tilePaintColor, byte wallPaintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A28")]
	[Cpp2IlInjected.Address(RVA = "0xA50D24", Offset = "0xA50D24", VA = "0xA50D24")]
	private static void PaintThePurityGrass(byte tilePaintColor, byte wallPaintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A29")]
	[Cpp2IlInjected.Address(RVA = "0xA501CC", Offset = "0xA501CC", VA = "0xA501CC")]
	private static void PaintThePyramids(byte tilePaintColor, byte wallPaintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A2A")]
	[Cpp2IlInjected.Address(RVA = "0xA4F7CC", Offset = "0xA4F7CC", VA = "0xA4F7CC")]
	private static void PaintTheTemple(byte tilePaintColor, byte wallPaintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A2B")]
	[Cpp2IlInjected.Address(RVA = "0xA4F988", Offset = "0xA4F988", VA = "0xA4F988")]
	private static void PaintTheClouds(byte tilePaintColor, byte wallPaintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A2C")]
	[Cpp2IlInjected.Address(RVA = "0xA4F218", Offset = "0xA4F218", VA = "0xA4F218")]
	private static void PaintTheDungeon(byte tilePaintColor, byte wallPaintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A2D")]
	[Cpp2IlInjected.Address(RVA = "0xA4F49C", Offset = "0xA4F49C", VA = "0xA4F49C")]
	private static void PaintTheLivingTrees(byte livingTreePaintColor, byte livingTreeWallPaintColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A2E")]
	[Cpp2IlInjected.Address(RVA = "0xA4EE04", Offset = "0xA4EE04", VA = "0xA4EE04")]
	private static void ConvertSkyIslands(int convertType, bool growTrees)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A2F")]
	[Cpp2IlInjected.Address(RVA = "0xA50C24", Offset = "0xA50C24", VA = "0xA50C24")]
	private static void ImproveAllChestContents()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A30")]
	[Cpp2IlInjected.Address(RVA = "0xA57488", Offset = "0xA57488", VA = "0xA57488")]
	private static void GiveItemGoodPrefixes(Item item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A31")]
	[Cpp2IlInjected.Address(RVA = "0xA57750", Offset = "0xA57750", VA = "0xA57750")]
	private static void PrefixItemFromOptions(Item item, int[] options)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A32")]
	[Cpp2IlInjected.Address(RVA = "0xA578B8", Offset = "0xA578B8", VA = "0xA578B8")]
	private static void NotTheBees()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A33")]
	[Cpp2IlInjected.Address(RVA = "0xA58C44", Offset = "0xA58C44", VA = "0xA58C44")]
	private static void FinishNotTheBees()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A34")]
	[Cpp2IlInjected.Address(RVA = "0xA5C208", Offset = "0xA5C208", VA = "0xA5C208")]
	private static void FinishGetGoodWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A35")]
	[Cpp2IlInjected.Address(RVA = "0xA5D418", Offset = "0xA5D418", VA = "0xA5D418")]
	private static void FinishNoTraps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A36")]
	[Cpp2IlInjected.Address(RVA = "0xA5E600", Offset = "0xA5E600", VA = "0xA5E600")]
	private static void FinishDrunkGen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A37")]
	[Cpp2IlInjected.Address(RVA = "0xA5F328", Offset = "0xA5F328", VA = "0xA5F328")]
	private static void FinishRemixWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A38")]
	[Cpp2IlInjected.Address(RVA = "0xA62E50", Offset = "0xA62E50", VA = "0xA62E50")]
	public static bool IsItATrap(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A39")]
	[Cpp2IlInjected.Address(RVA = "0xA62F28", Offset = "0xA62F28", VA = "0xA62F28")]
	public static bool IsItATrigger(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A3A")]
	[Cpp2IlInjected.Address(RVA = "0xA6307C", Offset = "0xA6307C", VA = "0xA6307C")]
	public static void ClearAllBrokenTraps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A3B")]
	[Cpp2IlInjected.Address(RVA = "0xA6327C", Offset = "0xA6327C", VA = "0xA6327C")]
	public static void ClearBrokenTraps(Point startTileCoords, List<Point> pointsWeAlreadyWentOver)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A3C")]
	[Cpp2IlInjected.Address(RVA = "0xA63A30", Offset = "0xA63A30", VA = "0xA63A30")]
	private static double TuneOceanDepth(int count, double depth, bool floridaStyle = false)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A3D")]
	[Cpp2IlInjected.Address(RVA = "0xA643DC", Offset = "0xA643DC", VA = "0xA643DC")]
	public static void QueuePostGenAction(Action<StructureMap> action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A3E")]
	[Cpp2IlInjected.Address(RVA = "0xA4E5E0", Offset = "0xA4E5E0", VA = "0xA4E5E0")]
	public static void ConsumePostGenActions(StructureMap structures)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A3F")]
	[Cpp2IlInjected.Address(RVA = "0xA64470", Offset = "0xA64470", VA = "0xA64470")]
	public static Point RandomRectanglePoint(Rectangle rectangle)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A40")]
	[Cpp2IlInjected.Address(RVA = "0xA6453C", Offset = "0xA6453C", VA = "0xA6453C")]
	public static Point RandomRectanglePoint(int x, int y, int width, int height)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A41")]
	[Cpp2IlInjected.Address(RVA = "0xA64608", Offset = "0xA64608", VA = "0xA64608")]
	public static Point RandomWorldPoint(int padding)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A42")]
	[Cpp2IlInjected.Address(RVA = "0xA6469C", Offset = "0xA6469C", VA = "0xA6469C")]
	public static Point RandomWorldPoint(int top = 0, int right = 0, int bottom = 0, int left = 0)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A43")]
	[Cpp2IlInjected.Address(RVA = "0xA647C0", Offset = "0xA647C0", VA = "0xA647C0")]
	public static bool GrowPalmTree(int i, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A44")]
	[Cpp2IlInjected.Address(RVA = "0xA65548", Offset = "0xA65548", VA = "0xA65548")]
	public static bool IsPalmOasisTree(int x)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A45")]
	[Cpp2IlInjected.Address(RVA = "0xA6564C", Offset = "0xA6564C", VA = "0xA6564C")]
	public static bool GrowEpicTree(int i, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A46")]
	[Cpp2IlInjected.Address(RVA = "0xA67338", Offset = "0xA67338", VA = "0xA67338")]
	public static bool Pyramid(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A47")]
	[Cpp2IlInjected.Address(RVA = "0xA6E950", Offset = "0xA6E950", VA = "0xA6E950")]
	public static bool GrowLivingTree(int i, int j, bool patch = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A48")]
	[Cpp2IlInjected.Address(RVA = "0xA731F8", Offset = "0xA731F8", VA = "0xA731F8")]
	public static bool GrowDungeonTree(int i, int j, bool patch = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A49")]
	[Cpp2IlInjected.Address(RVA = "0xA7667C", Offset = "0xA7667C", VA = "0xA7667C")]
	private static bool GrowLivingTree_HorizontalTunnel(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A4A")]
	[Cpp2IlInjected.Address(RVA = "0xA75188", Offset = "0xA75188", VA = "0xA75188")]
	private static void GrowDungeonTree_MakePassage(int j, int W, ref int minl, ref int minr, bool noSecretRoom = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A4B")]
	[Cpp2IlInjected.Address(RVA = "0xA713D0", Offset = "0xA713D0", VA = "0xA713D0")]
	private static void GrowLivingTree_MakePassage(int j, int W, ref int minl, ref int minr, bool noSecretRoom = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A4C")]
	[Cpp2IlInjected.Address(RVA = "0xA77FB4", Offset = "0xA77FB4", VA = "0xA77FB4")]
	private static void GrowLivingTreePassageRoom(int minl, int minr, int Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A4D")]
	[Cpp2IlInjected.Address(RVA = "0xA7939C", Offset = "0xA7939C", VA = "0xA7939C")]
	public static void TreeGrowFXCheck(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A4E")]
	[Cpp2IlInjected.Address(RVA = "0xA797BC", Offset = "0xA797BC", VA = "0xA797BC")]
	public static void GetTreeLeaf(int x, Tile topTile, Tile t, ref int treeHeight, out int treeFrame, out int passStyle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A4F")]
	[Cpp2IlInjected.Address(RVA = "0xA79CBC", Offset = "0xA79CBC", VA = "0xA79CBC")]
	public static void TreeGrowFX(int x, int y, int height, int treeGore, bool hitTree = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A50")]
	[Cpp2IlInjected.Address(RVA = "0xA7A460", Offset = "0xA7A460", VA = "0xA7A460")]
	private static void TreeGrowFX_AshShake(int x, int y, int height, bool hitTree = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A51")]
	[Cpp2IlInjected.Address(RVA = "0xA7AE78", Offset = "0xA7AE78", VA = "0xA7AE78")]
	public static bool IsTileALeafyTreeTop(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A52")]
	[Cpp2IlInjected.Address(RVA = "0xA7AFC4", Offset = "0xA7AFC4", VA = "0xA7AFC4")]
	public static bool IsTileTypeFitForTree(ushort type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A53")]
	[Cpp2IlInjected.Address(RVA = "0xA55428", Offset = "0xA55428", VA = "0xA55428")]
	public static bool GrowTree(int i, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A54")]
	[Cpp2IlInjected.Address(RVA = "0xA7B060", Offset = "0xA7B060", VA = "0xA7B060")]
	public static bool DefaultTreeWallTest(int wallType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A55")]
	[Cpp2IlInjected.Address(RVA = "0xA7B140", Offset = "0xA7B140", VA = "0xA7B140")]
	public static bool GemTreeWallTest(int wallType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A56")]
	[Cpp2IlInjected.Address(RVA = "0xA7B214", Offset = "0xA7B214", VA = "0xA7B214")]
	public static bool GemTreeGroundTest(int tileType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A57")]
	[Cpp2IlInjected.Address(RVA = "0xA7B2E8", Offset = "0xA7B2E8", VA = "0xA7B2E8")]
	public static bool VanityTreeGroundTest(int tileType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A58")]
	[Cpp2IlInjected.Address(RVA = "0xA7B37C", Offset = "0xA7B37C", VA = "0xA7B37C")]
	public static bool AshTreeGroundTest(int tileType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A59")]
	[Cpp2IlInjected.Address(RVA = "0xA7B398", Offset = "0xA7B398", VA = "0xA7B398")]
	public static bool TryGrowingTreeByType(int treeTileType, int checkedX, int checkedY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A5A")]
	[Cpp2IlInjected.Address(RVA = "0xA5A76C", Offset = "0xA5A76C", VA = "0xA5A76C")]
	public static bool GrowTreeWithSettings(int checkedX, int checkedY, GrowTreeSettings settings)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A5B")]
	[Cpp2IlInjected.Address(RVA = "0xA7B854", Offset = "0xA7B854", VA = "0xA7B854")]
	public static void GrowUndergroundTree(int i, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A5C")]
	[Cpp2IlInjected.Address(RVA = "0xA7D4E0", Offset = "0xA7D4E0", VA = "0xA7D4E0")]
	public static bool GrowShroom(int i, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A5D")]
	[Cpp2IlInjected.Address(RVA = "0xA619D8", Offset = "0xA619D8", VA = "0xA619D8")]
	public static void AddTrees(bool undergroundOnly = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A5E")]
	[Cpp2IlInjected.Address(RVA = "0xA7DE9C", Offset = "0xA7DE9C", VA = "0xA7DE9C")]
	public static void ExplodeMine(int i, int j, bool fromWiring)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A5F")]
	[Cpp2IlInjected.Address(RVA = "0xA64F88", Offset = "0xA64F88", VA = "0xA64F88")]
	public static bool EmptyTileCheck(int startX, int endX, int startY, int endY, int ignoreID = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A60")]
	[Cpp2IlInjected.Address(RVA = "0xA7E098", Offset = "0xA7E098", VA = "0xA7E098")]
	public static void StartHardmode()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A61")]
	[Cpp2IlInjected.Address(RVA = "0xA7E254", Offset = "0xA7E254", VA = "0xA7E254")]
	public static void TryProtectingSpawnedItems()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A62")]
	[Cpp2IlInjected.Address(RVA = "0xA7E328", Offset = "0xA7E328", VA = "0xA7E328")]
	private static bool EligibleForSpawnProtection(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A63")]
	[Cpp2IlInjected.Address(RVA = "0xA7E3CC", Offset = "0xA7E3CC", VA = "0xA7E3CC")]
	public static void UndoSpawnedItemProtection()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A64")]
	[Cpp2IlInjected.Address(RVA = "0xA7E4A8", Offset = "0xA7E4A8", VA = "0xA7E4A8")]
	public static void smCallBack(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A65")]
	[Cpp2IlInjected.Address(RVA = "0xA81230", Offset = "0xA81230", VA = "0xA81230")]
	private static void FinaliseHardModeOnMainThread(object data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A66")]
	[Cpp2IlInjected.Address(RVA = "0xA81610", Offset = "0xA81610", VA = "0xA81610")]
	public static bool PlaceDoor(int i, int j, int type, int style = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A67")]
	[Cpp2IlInjected.Address(RVA = "0xA81A34", Offset = "0xA81A34", VA = "0xA81A34")]
	public static bool CloseDoor(int i, int j, bool forced = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A68")]
	[Cpp2IlInjected.Address(RVA = "0xA81F2C", Offset = "0xA81F2C", VA = "0xA81F2C")]
	public static bool AddLifeCrystal(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A69")]
	[Cpp2IlInjected.Address(RVA = "0xA825A8", Offset = "0xA825A8", VA = "0xA825A8")]
	public static void AddShadowOrb(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A6A")]
	[Cpp2IlInjected.Address(RVA = "0xA82978", Offset = "0xA82978", VA = "0xA82978")]
	public static void AddHellHouses()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A6B")]
	[Cpp2IlInjected.Address(RVA = "0xA86124", Offset = "0xA86124", VA = "0xA86124")]
	public static void HellFort(int i, int j, ushort tileType = 75, byte wallType = 14)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A6C")]
	[Cpp2IlInjected.Address(RVA = "0xA89300", Offset = "0xA89300", VA = "0xA89300")]
	public static void HellHouse(int i, int j, byte type = 76, byte wall = 13)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A6D")]
	[Cpp2IlInjected.Address(RVA = "0xA8A370", Offset = "0xA8A370", VA = "0xA8A370")]
	public static void HellRoom(int i, int j, int width, int height, byte type = 76, byte wall = 13)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A6E")]
	[Cpp2IlInjected.Address(RVA = "0xA8A6E4", Offset = "0xA8A6E4", VA = "0xA8A6E4")]
	public static void templeCleaner(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A6F")]
	[Cpp2IlInjected.Address(RVA = "0xA8AC08", Offset = "0xA8AC08", VA = "0xA8AC08")]
	public static Vector2D templePather(Vector2D templePath, int destX, int destY)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A70")]
	[Cpp2IlInjected.Address(RVA = "0xA8AE50", Offset = "0xA8AE50", VA = "0xA8AE50")]
	public static void outerTempled(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A71")]
	[Cpp2IlInjected.Address(RVA = "0xA8B130", Offset = "0xA8B130", VA = "0xA8B130")]
	public static void makeTemple(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A72")]
	[Cpp2IlInjected.Address(RVA = "0xA8F0B0", Offset = "0xA8F0B0", VA = "0xA8F0B0")]
	public static void templePart2()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A73")]
	[Cpp2IlInjected.Address(RVA = "0xA891F8", Offset = "0xA891F8", VA = "0xA891F8")]
	public static bool nearPicture(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A74")]
	[Cpp2IlInjected.Address(RVA = "0xA88B18", Offset = "0xA88B18", VA = "0xA88B18")]
	public static bool nearPicture2(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A75")]
	[Cpp2IlInjected.Address(RVA = "0xA90250", Offset = "0xA90250", VA = "0xA90250")]
	private static void ShimmerCleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A76")]
	[Cpp2IlInjected.Address(RVA = "0xA9127C", Offset = "0xA9127C", VA = "0xA9127C")]
	public static void ShimmerRemoveWater()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A77")]
	[Cpp2IlInjected.Address(RVA = "0xA916D0", Offset = "0xA916D0", VA = "0xA916D0")]
	public static bool ShimmerMakeBiome(int X, int Y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A78")]
	[Cpp2IlInjected.Address(RVA = "0xA92C5C", Offset = "0xA92C5C", VA = "0xA92C5C")]
	private static void ShimmerMakeBiomeOpening(int direction, int X, int Y, int caveOpenningSize)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A79")]
	[Cpp2IlInjected.Address(RVA = "0xA93134", Offset = "0xA93134", VA = "0xA93134")]
	private static void Shimminate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A7A")]
	[Cpp2IlInjected.Address(RVA = "0xA915B8", Offset = "0xA915B8", VA = "0xA915B8")]
	public static void Shimmerator(int x, int y, bool jungle = false, bool lavaOk = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A7B")]
	[Cpp2IlInjected.Address(RVA = "0xA933FC", Offset = "0xA933FC", VA = "0xA933FC")]
	public static void ShimmeratorNext(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A7C")]
	[Cpp2IlInjected.Address(RVA = "0xA94130", Offset = "0xA94130", VA = "0xA94130")]
	public static void MakeDungeon(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A7D")]
	[Cpp2IlInjected.Address(RVA = "0xAA5D10", Offset = "0xAA5D10", VA = "0xAA5D10")]
	private static void MakeDungeon_Traps(ref int failCount, int failMax, ref int numAdd)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A7E")]
	[Cpp2IlInjected.Address(RVA = "0xAA3FB0", Offset = "0xAA3FB0", VA = "0xAA3FB0")]
	private static void MakeDungeon_Lights(ushort tileType, ref int failCount, int failMax, ref int numAdd, int[] roomWall)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A7F")]
	[Cpp2IlInjected.Address(RVA = "0xAAA298", Offset = "0xAAA298", VA = "0xAAA298")]
	private static double MakeDungeon_Banners(int[] roomWall, double count)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A80")]
	[Cpp2IlInjected.Address(RVA = "0xAA8288", Offset = "0xAA8288", VA = "0xAA8288")]
	private static double MakeDungeon_Pictures(int[] roomWall, double count)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A81")]
	[Cpp2IlInjected.Address(RVA = "0xAA5FD0", Offset = "0xAA5FD0", VA = "0xAA5FD0")]
	private static double MakeDungeon_GroundFurniture(int wallType)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A82")]
	[Cpp2IlInjected.Address(RVA = "0xAAB4A4", Offset = "0xAAB4A4", VA = "0xAAB4A4")]
	public static PaintingEntry RandBonePicture()
	{
		return default(PaintingEntry);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A83")]
	[Cpp2IlInjected.Address(RVA = "0xA88FC8", Offset = "0xA88FC8", VA = "0xA88FC8")]
	public static PaintingEntry RandHellPicture()
	{
		return default(PaintingEntry);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A84")]
	[Cpp2IlInjected.Address(RVA = "0xAAB5C8", Offset = "0xAAB5C8", VA = "0xAAB5C8")]
	public static PaintingEntry RandHousePictureDesert()
	{
		return default(PaintingEntry);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A85")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6E0", Offset = "0xAAB6E0", VA = "0xAAB6E0")]
	public static PaintingEntry RandHousePicture()
	{
		return default(PaintingEntry);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A86")]
	[Cpp2IlInjected.Address(RVA = "0xAAB324", Offset = "0xAAB324", VA = "0xAAB324")]
	public static PaintingEntry RandPictureTile()
	{
		return default(PaintingEntry);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A87")]
	[Cpp2IlInjected.Address(RVA = "0xA9ECB0", Offset = "0xA9ECB0", VA = "0xA9ECB0")]
	public static void DungeonStairs(int i, int j, ushort tileType, int wallType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A88")]
	[Cpp2IlInjected.Address(RVA = "0xAAEA80", Offset = "0xAAEA80", VA = "0xAAEA80")]
	public static bool PlaceSandTrap(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A89")]
	[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA3370", VA = "0xAA3370")]
	public static bool DungeonPitTrap(int i, int j, ushort tileType, int wallType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A8A")]
	[Cpp2IlInjected.Address(RVA = "0xA9C700", Offset = "0xA9C700", VA = "0xA9C700")]
	public static void DungeonHalls(int i, int j, ushort tileType, int wallType, bool forceX = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A8B")]
	[Cpp2IlInjected.Address(RVA = "0xA9BC20", Offset = "0xA9BC20", VA = "0xA9BC20")]
	public static void DungeonRoom(int i, int j, ushort tileType, int wallType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A8C")]
	[Cpp2IlInjected.Address(RVA = "0xA9FCA8", Offset = "0xA9FCA8", VA = "0xA9FCA8")]
	public static void DungeonEnt(int i, int j, ushort tileType, int wallType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A8D")]
	[Cpp2IlInjected.Address(RVA = "0xAB0734", Offset = "0xAB0734", VA = "0xAB0734")]
	public static bool AddBuriedChest(Point point, int contain = 0, bool notNearOtherChests = false, int Style = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A8E")]
	[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAB07E0", VA = "0xAB07E0")]
	public static bool IsChestRigged(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A8F")]
	[Cpp2IlInjected.Address(RVA = "0xAB0900", Offset = "0xAB0900", VA = "0xAB0900")]
	private static bool IsUndergroundDesert(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A90")]
	[Cpp2IlInjected.Address(RVA = "0xAB0B78", Offset = "0xAB0B78", VA = "0xAB0B78")]
	private static bool IsDungeon(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A91")]
	[Cpp2IlInjected.Address(RVA = "0xA68688", Offset = "0xA68688", VA = "0xA68688")]
	public static bool AddBuriedChest(int i, int j, int contain = 0, bool notNearOtherChests = false, int Style = -1, bool trySlope = false, ushort chestTileType = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A92")]
	[Cpp2IlInjected.Address(RVA = "0xAB1180", Offset = "0xAB1180", VA = "0xAB1180")]
	public static void UnlockDoor(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A93")]
	[Cpp2IlInjected.Address(RVA = "0xAB1498", Offset = "0xAB1498", VA = "0xAB1498")]
	public static bool OpenDoor(int i, int j, int direction)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A94")]
	[Cpp2IlInjected.Address(RVA = "0xAB22D0", Offset = "0xAB22D0", VA = "0xAB22D0")]
	public static void Check1xX(int x, int j, short type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A95")]
	[Cpp2IlInjected.Address(RVA = "0xAB2CF0", Offset = "0xAB2CF0", VA = "0xAB2CF0")]
	public static void Check2xX(int i, int j, ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A96")]
	[Cpp2IlInjected.Address(RVA = "0xAB4620", Offset = "0xAB4620", VA = "0xAB4620")]
	public static bool IsBelowANonHammeredPlatform(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A97")]
	[Cpp2IlInjected.Address(RVA = "0xA92AB4", Offset = "0xA92AB4", VA = "0xA92AB4")]
	public static void PlaceTight(int x, int y, bool spiders = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A98")]
	[Cpp2IlInjected.Address(RVA = "0xAB4934", Offset = "0xAB4934", VA = "0xAB4934")]
	public static void PlaceUncheckedStalactite(int x, int y, bool preferSmall, int variation, bool spiders)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A99")]
	[Cpp2IlInjected.Address(RVA = "0xAB6CC4", Offset = "0xAB6CC4", VA = "0xAB6CC4")]
	public static bool UpdateStalagtiteStyle(int x, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A9A")]
	[Cpp2IlInjected.Address(RVA = "0xAB71E4", Offset = "0xAB71E4", VA = "0xAB71E4")]
	private static void GetDesiredStalagtiteStyle(int x, int j, out bool fail, out int desiredStyle, out int height, out int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A9B")]
	[Cpp2IlInjected.Address(RVA = "0xAB7060", Offset = "0xAB7060", VA = "0xAB7060")]
	private static void GetStalagtiteStyle(int x, int y, out int style, out bool fail)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A9C")]
	[Cpp2IlInjected.Address(RVA = "0xAB6500", Offset = "0xAB6500", VA = "0xAB6500")]
	public static void CheckTight(int x, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A9D")]
	[Cpp2IlInjected.Address(RVA = "0xAB761C", Offset = "0xAB761C", VA = "0xAB761C")]
	public static void Place1xX(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002A9E")]
	[Cpp2IlInjected.Address(RVA = "0xAB7C40", Offset = "0xAB7C40", VA = "0xAB7C40")]
	public static int checkXmasTreeDrop(int x, int y, int obj)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002A9F")]
	[Cpp2IlInjected.Address(RVA = "0xAB82E8", Offset = "0xAB82E8", VA = "0xAB82E8")]
	public static void dropXmasTree(int x, int y, int obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA0")]
	[Cpp2IlInjected.Address(RVA = "0xAB8C14", Offset = "0xAB8C14", VA = "0xAB8C14")]
	public static void setXmasTree(int x, int y, int obj, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA1")]
	[Cpp2IlInjected.Address(RVA = "0xAB8FA4", Offset = "0xAB8FA4", VA = "0xAB8FA4")]
	public static int PlaceXmasTree_Direct(int x, int y, int type, int style, int dir, int alternate)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA2")]
	[Cpp2IlInjected.Address(RVA = "0xAB90E8", Offset = "0xAB90E8", VA = "0xAB90E8")]
	public static void PlaceXmasTree(int x, int y, ushort type = 171)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA3")]
	[Cpp2IlInjected.Address(RVA = "0xAB9388", Offset = "0xAB9388", VA = "0xAB9388")]
	public static void CheckXmasTree(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA4")]
	[Cpp2IlInjected.Address(RVA = "0xAB99E8", Offset = "0xAB99E8", VA = "0xAB99E8")]
	public static void Place2xX(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA5")]
	[Cpp2IlInjected.Address(RVA = "0xAB9D8C", Offset = "0xAB9D8C", VA = "0xAB9D8C")]
	public static int GetItemDrop_Benches(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA6")]
	[Cpp2IlInjected.Address(RVA = "0xAB9DB0", Offset = "0xAB9DB0", VA = "0xAB9DB0")]
	public static int GetItemDrop_PicnicTables(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA7")]
	[Cpp2IlInjected.Address(RVA = "0xAB9DD0", Offset = "0xAB9DD0", VA = "0xAB9DD0")]
	public static int GetItemDrop_Chair(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA8")]
	[Cpp2IlInjected.Address(RVA = "0xAB9DF4", Offset = "0xAB9DF4", VA = "0xAB9DF4")]
	public static int GetItemDrop_Toilet(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AA9")]
	[Cpp2IlInjected.Address(RVA = "0xAB9E28", Offset = "0xAB9E28", VA = "0xAB9E28")]
	public static void Check1x2(int x, int j, ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AAA")]
	[Cpp2IlInjected.Address(RVA = "0xABAB74", Offset = "0xABAB74", VA = "0xABAB74")]
	public static void CheckOnTable1x1(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AAB")]
	[Cpp2IlInjected.Address(RVA = "0xABB1B8", Offset = "0xABB1B8", VA = "0xABB1B8")]
	public static void CheckSign(int x, int y, ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AAC")]
	[Cpp2IlInjected.Address(RVA = "0xABCEE0", Offset = "0xABCEE0", VA = "0xABCEE0")]
	public static bool PlaceSign(int x, int y, ushort type, int Style = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AAD")]
	[Cpp2IlInjected.Address(RVA = "0xABDF3C", Offset = "0xABDF3C", VA = "0xABDF3C")]
	public static bool Place2x2Horizontal(int x, int y, ushort type, int Style = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AAE")]
	[Cpp2IlInjected.Address(RVA = "0xABE378", Offset = "0xABE378", VA = "0xABE378")]
	public static Color paintColor(int color)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AAF")]
	[Cpp2IlInjected.Address(RVA = "0xABE5B0", Offset = "0xABE5B0", VA = "0xABE5B0")]
	public static Color coatingColor(int coating)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB0")]
	[Cpp2IlInjected.Address(RVA = "0xABE69C", Offset = "0xABE69C", VA = "0xABE69C")]
	public static List<Color> coatingColors(Tile tile, bool block)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB1")]
	[Cpp2IlInjected.Address(RVA = "0xABE85C", Offset = "0xABE85C", VA = "0xABE85C")]
	public static void paintEffect(int x, int y, byte color, byte oldColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB2")]
	[Cpp2IlInjected.Address(RVA = "0xABEAA0", Offset = "0xABEAA0", VA = "0xABEAA0")]
	public static void paintCoatEffect(int x, int y, byte paintCoatId, List<Color> oldColors)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB3")]
	[Cpp2IlInjected.Address(RVA = "0xABED88", Offset = "0xABED88", VA = "0xABED88")]
	public static bool paintTile(int x, int y, byte color, bool broadCast = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB4")]
	[Cpp2IlInjected.Address(RVA = "0xABEF50", Offset = "0xABEF50", VA = "0xABEF50")]
	public static bool paintCoatTile(int x, int y, byte paintCoatId, bool broadcast = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB5")]
	[Cpp2IlInjected.Address(RVA = "0xABF20C", Offset = "0xABF20C", VA = "0xABF20C")]
	public static bool paintCoatWall(int x, int y, byte paintCoatId, bool broadcast = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB6")]
	[Cpp2IlInjected.Address(RVA = "0xABF4CC", Offset = "0xABF4CC", VA = "0xABF4CC")]
	public static bool paintWall(int x, int y, byte color, bool broadCast = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB7")]
	[Cpp2IlInjected.Address(RVA = "0xABF694", Offset = "0xABF694", VA = "0xABF694")]
	public static void Place3x3Wall(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB8")]
	[Cpp2IlInjected.Address(RVA = "0xABF974", Offset = "0xABF974", VA = "0xABF974")]
	public static void Check3x3Wall(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AB9")]
	[Cpp2IlInjected.Address(RVA = "0xAC0F48", Offset = "0xAC0F48", VA = "0xAC0F48")]
	public static void Place2x3Wall(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ABA")]
	[Cpp2IlInjected.Address(RVA = "0xAC11C4", Offset = "0xAC11C4", VA = "0xAC11C4")]
	public static void Check2x3Wall(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ABB")]
	[Cpp2IlInjected.Address(RVA = "0xAC1CD0", Offset = "0xAC1CD0", VA = "0xAC1CD0")]
	public static void Place3x2Wall(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ABC")]
	[Cpp2IlInjected.Address(RVA = "0xAC1F44", Offset = "0xAC1F44", VA = "0xAC1F44")]
	public static void Check3x2Wall(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ABD")]
	[Cpp2IlInjected.Address(RVA = "0xAC282C", Offset = "0xAC282C", VA = "0xAC282C")]
	public static void Place4x3Wall(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ABE")]
	[Cpp2IlInjected.Address(RVA = "0xAC2AB8", Offset = "0xAC2AB8", VA = "0xAC2AB8")]
	public static void Check4x3Wall(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ABF")]
	[Cpp2IlInjected.Address(RVA = "0xAC3118", Offset = "0xAC3118", VA = "0xAC3118")]
	public static void Place6x4Wall(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC0")]
	[Cpp2IlInjected.Address(RVA = "0xAC33D0", Offset = "0xAC33D0", VA = "0xAC33D0")]
	public static void Check6x4Wall(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC1")]
	[Cpp2IlInjected.Address(RVA = "0xAC4398", Offset = "0xAC4398", VA = "0xAC4398")]
	private static int RollRandomSeaShellStyle()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC2")]
	[Cpp2IlInjected.Address(RVA = "0xAC44AC", Offset = "0xAC44AC", VA = "0xAC44AC")]
	public static void Place1x1(int x, int y, int type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC3")]
	[Cpp2IlInjected.Address(RVA = "0xAC479C", Offset = "0xAC479C", VA = "0xAC479C")]
	public static void Check1x1(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC4")]
	[Cpp2IlInjected.Address(RVA = "0xAC4AE0", Offset = "0xAC4AE0", VA = "0xAC4AE0")]
	public static void CheckGolf1x1(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC5")]
	[Cpp2IlInjected.Address(RVA = "0xAC4C60", Offset = "0xAC4C60", VA = "0xAC4C60")]
	public static void CheckLogicTiles(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC6")]
	[Cpp2IlInjected.Address(RVA = "0xAC4E44", Offset = "0xAC4E44", VA = "0xAC4E44")]
	public static void PlaceLogicTiles(int x, int y, int type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC7")]
	[Cpp2IlInjected.Address(RVA = "0xAC50AC", Offset = "0xAC50AC", VA = "0xAC50AC")]
	public static void PlaceOnTable1x1(int x, int y, int type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC8")]
	[Cpp2IlInjected.Address(RVA = "0xAC5528", Offset = "0xAC5528", VA = "0xAC5528")]
	public static bool PlaceAlch(int x, int y, int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AC9")]
	[Cpp2IlInjected.Address(RVA = "0xAC64B4", Offset = "0xAC64B4", VA = "0xAC64B4")]
	public static void GrowSpike(int i, int j, ushort spikeType, ushort landType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ACA")]
	[Cpp2IlInjected.Address(RVA = "0xAC7308", Offset = "0xAC7308", VA = "0xAC7308")]
	private static bool GrowMoreVines(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002ACB")]
	[Cpp2IlInjected.Address(RVA = "0xAC7680", Offset = "0xAC7680", VA = "0xAC7680")]
	private static void GrowGlowTulips()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ACC")]
	[Cpp2IlInjected.Address(RVA = "0xAC7E30", Offset = "0xAC7E30", VA = "0xAC7E30")]
	private static void MatureTheHerbPlants()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ACD")]
	[Cpp2IlInjected.Address(RVA = "0xAC8220", Offset = "0xAC8220", VA = "0xAC8220")]
	public static void GrowAlch(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ACE")]
	[Cpp2IlInjected.Address(RVA = "0xAC8A88", Offset = "0xAC8A88", VA = "0xAC8A88")]
	public static void PlantAlch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ACF")]
	[Cpp2IlInjected.Address(RVA = "0xAC9A1C", Offset = "0xAC9A1C", VA = "0xAC9A1C")]
	public static void CheckAlch(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD0")]
	[Cpp2IlInjected.Address(RVA = "0xACA7F8", Offset = "0xACA7F8", VA = "0xACA7F8")]
	public static void CheckBanner(int x, int j, byte type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD1")]
	[Cpp2IlInjected.Address(RVA = "0xACB6A0", Offset = "0xACB6A0", VA = "0xACB6A0")]
	public static void PlaceBanner(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD2")]
	[Cpp2IlInjected.Address(RVA = "0xACBB44", Offset = "0xACBB44", VA = "0xACBB44")]
	public static void PlaceMan(int i, int j, int dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD3")]
	[Cpp2IlInjected.Address(RVA = "0xACBF5C", Offset = "0xACBF5C", VA = "0xACBF5C")]
	public static void PlaceWoman(int i, int j, int dir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD4")]
	[Cpp2IlInjected.Address(RVA = "0xACC374", Offset = "0xACC374", VA = "0xACC374")]
	public static void CheckWeaponsRack(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD5")]
	[Cpp2IlInjected.Address(RVA = "0xACCBEC", Offset = "0xACCBEC", VA = "0xACCBEC")]
	public static void ToggleGemLock(int i, int j, bool on)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD6")]
	[Cpp2IlInjected.Address(RVA = "0xACD088", Offset = "0xACD088", VA = "0xACD088")]
	public static void CheckMan(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD7")]
	[Cpp2IlInjected.Address(RVA = "0xACD6F8", Offset = "0xACD6F8", VA = "0xACD6F8")]
	public static void CheckWoman(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD8")]
	[Cpp2IlInjected.Address(RVA = "0xACDD74", Offset = "0xACDD74", VA = "0xACDD74")]
	public static void Place1x2(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AD9")]
	[Cpp2IlInjected.Address(RVA = "0xAAB050", Offset = "0xAAB050", VA = "0xAAB050")]
	public static void Place1x2Top(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ADA")]
	[Cpp2IlInjected.Address(RVA = "0xACDFFC", Offset = "0xACDFFC", VA = "0xACDFFC")]
	public static void Check1x2Top(int x, int j, ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ADB")]
	[Cpp2IlInjected.Address(RVA = "0xA48E7C", Offset = "0xA48E7C", VA = "0xA48E7C")]
	public static bool PlaceSmallPile(int i, int j, int X, int Y, ushort type = 185)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002ADC")]
	[Cpp2IlInjected.Address(RVA = "0xACEA70", Offset = "0xACEA70", VA = "0xACEA70")]
	public static void CheckPile(int i, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ADD")]
	[Cpp2IlInjected.Address(RVA = "0xACEE5C", Offset = "0xACEE5C", VA = "0xACEE5C")]
	public static void Check2x1(int i, int y, ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ADE")]
	[Cpp2IlInjected.Address(RVA = "0xAD14FC", Offset = "0xAD14FC", VA = "0xAD14FC")]
	public static void Place2x1(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002ADF")]
	[Cpp2IlInjected.Address(RVA = "0xAD19E4", Offset = "0xAD19E4", VA = "0xAD19E4")]
	public static void Check4x2(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE0")]
	[Cpp2IlInjected.Address(RVA = "0xAD2698", Offset = "0xAD2698", VA = "0xAD2698")]
	private static bool OasisPlantWaterCheck(int x, int y, bool boost = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE1")]
	[Cpp2IlInjected.Address(RVA = "0xAD29CC", Offset = "0xAD29CC", VA = "0xAD29CC")]
	public static void PlaceOasisPlant(int X, int Y, ushort type = 530)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE2")]
	[Cpp2IlInjected.Address(RVA = "0xAD30C4", Offset = "0xAD30C4", VA = "0xAD30C4")]
	public static void CheckOasisPlant(int i, int j, int type = 530)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE3")]
	[Cpp2IlInjected.Address(RVA = "0xAD3780", Offset = "0xAD3780", VA = "0xAD3780")]
	public static void GetCactusType(int tileX, int tileY, int frameX, int frameY, out bool evil, out bool good, out bool crimson)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE4")]
	[Cpp2IlInjected.Address(RVA = "0xAD39E4", Offset = "0xAD39E4", VA = "0xAD39E4")]
	public static void GetBiomeInfluence(int startX, int endX, int startY, int endY, out int corruptCount, out int crimsonCount, out int hallowedCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE5")]
	[Cpp2IlInjected.Address(RVA = "0xAD3C24", Offset = "0xAD3C24", VA = "0xAD3C24")]
	public static void PlaceJunglePlant(int X2, int Y2, ushort type, int styleX, int styleY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE6")]
	[Cpp2IlInjected.Address(RVA = "0xAD4AA8", Offset = "0xAD4AA8", VA = "0xAD4AA8")]
	public static void CheckJunglePlant(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE7")]
	[Cpp2IlInjected.Address(RVA = "0xAD5BAC", Offset = "0xAD5BAC", VA = "0xAD5BAC")]
	public static void CheckSuper(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE8")]
	[Cpp2IlInjected.Address(RVA = "0xAD7364", Offset = "0xAD7364", VA = "0xAD7364")]
	public static void Check2x2(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AE9")]
	[Cpp2IlInjected.Address(RVA = "0xAD92B4", Offset = "0xAD92B4", VA = "0xAD92B4")]
	public static bool CheckBoulderChest(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AEA")]
	[Cpp2IlInjected.Address(RVA = "0xAD950C", Offset = "0xAD950C", VA = "0xAD950C")]
	public static bool IsAContainer(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AEB")]
	[Cpp2IlInjected.Address(RVA = "0xAD9678", Offset = "0xAD9678", VA = "0xAD9678")]
	public static void OreRunner(int i, int j, double strength, int steps, ushort type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AEC")]
	[Cpp2IlInjected.Address(RVA = "0xAD9FE8", Offset = "0xAD9FE8", VA = "0xAD9FE8")]
	public static void SmashAltar(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AED")]
	[Cpp2IlInjected.Address(RVA = "0xADB7A0", Offset = "0xADB7A0", VA = "0xADB7A0")]
	public static void Check3x1(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AEE")]
	[Cpp2IlInjected.Address(RVA = "0xADC0F4", Offset = "0xADC0F4", VA = "0xADC0F4")]
	public static void Check3x2(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AEF")]
	[Cpp2IlInjected.Address(RVA = "0xAE0BD8", Offset = "0xAE0BD8", VA = "0xAE0BD8")]
	private static int GetDresserItemDrop(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF0")]
	[Cpp2IlInjected.Address(RVA = "0xAE0B5C", Offset = "0xAE0B5C", VA = "0xAE0B5C")]
	private static int GetCampfireItemDrop(int style)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF1")]
	[Cpp2IlInjected.Address(RVA = "0xAE0C44", Offset = "0xAE0C44", VA = "0xAE0C44")]
	public static void Check3x4(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF2")]
	[Cpp2IlInjected.Address(RVA = "0xAE14E8", Offset = "0xAE14E8", VA = "0xAE14E8")]
	public static void Check5x4(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF3")]
	[Cpp2IlInjected.Address(RVA = "0xAE1BE4", Offset = "0xAE1BE4", VA = "0xAE1BE4")]
	public static void Check6x3(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF4")]
	[Cpp2IlInjected.Address(RVA = "0xAE32F0", Offset = "0xAE32F0", VA = "0xAE32F0")]
	public static void Place6x3(int x, int y, ushort type, int direction = -1, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF5")]
	[Cpp2IlInjected.Address(RVA = "0xA88584", Offset = "0xA88584", VA = "0xA88584")]
	public static void Place4x2(int x, int y, ushort type, int direction = -1, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF6")]
	[Cpp2IlInjected.Address(RVA = "0xAE36AC", Offset = "0xAE36AC", VA = "0xAE36AC")]
	public static void ShootFromCannon(int x, int y, int angle, int ammo, int Damage, float KnockBack, int owner, bool fromWire)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF7")]
	[Cpp2IlInjected.Address(RVA = "0xAE3B70", Offset = "0xAE3B70", VA = "0xAE3B70")]
	public static bool BunnyCannonCanFire()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF8")]
	[Cpp2IlInjected.Address(RVA = "0xAE3CC0", Offset = "0xAE3CC0", VA = "0xAE3CC0")]
	public static void SwitchCannon(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AF9")]
	[Cpp2IlInjected.Address(RVA = "0xAE4020", Offset = "0xAE4020", VA = "0xAE4020")]
	public static void CheckCannon(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AFA")]
	[Cpp2IlInjected.Address(RVA = "0xAE46DC", Offset = "0xAE46DC", VA = "0xAE46DC")]
	public static void PlaceCannon(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AFB")]
	[Cpp2IlInjected.Address(RVA = "0xAE4DF8", Offset = "0xAE4DF8", VA = "0xAE4DF8")]
	public static void SwitchMB(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AFC")]
	[Cpp2IlInjected.Address(RVA = "0xAE514C", Offset = "0xAE514C", VA = "0xAE514C")]
	public static void SwitchMonolith(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AFD")]
	[Cpp2IlInjected.Address(RVA = "0xAE55C0", Offset = "0xAE55C0", VA = "0xAE55C0")]
	public static void SwitchFountain(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AFE")]
	[Cpp2IlInjected.Address(RVA = "0xAE5948", Offset = "0xAE5948", VA = "0xAE5948")]
	public static void CheckMB(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002AFF")]
	[Cpp2IlInjected.Address(RVA = "0xAE78DC", Offset = "0xAE78DC", VA = "0xAE78DC")]
	public static void PlaceMB(int X, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B00")]
	[Cpp2IlInjected.Address(RVA = "0xAE7DF8", Offset = "0xAE7DF8", VA = "0xAE7DF8")]
	public static void Place2x2(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B01")]
	[Cpp2IlInjected.Address(RVA = "0xAE88BC", Offset = "0xAE88BC", VA = "0xAE88BC")]
	public static bool PlaceObject(int x, int y, int type, bool mute = false, int style = 0, int alternate = 0, int random = -1, int direction = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B02")]
	[Cpp2IlInjected.Address(RVA = "0xAE8A90", Offset = "0xAE8A90", VA = "0xAE8A90")]
	public static bool ShiftTrapdoor(int x, int y, bool playerAbove, int onlyCloseOrOpen = -1)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B03")]
	[Cpp2IlInjected.Address(RVA = "0xAE9790", Offset = "0xAE9790", VA = "0xAE9790")]
	public static void CheckTrapDoor(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B04")]
	[Cpp2IlInjected.Address(RVA = "0xAE9FC4", Offset = "0xAE9FC4", VA = "0xAE9FC4")]
	public static void CheckTallGate(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B05")]
	[Cpp2IlInjected.Address(RVA = "0xAEA4E4", Offset = "0xAEA4E4", VA = "0xAEA4E4")]
	public static bool ShiftTallGate(int x, int y, bool closing, bool forced = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B06")]
	[Cpp2IlInjected.Address(RVA = "0xAE966C", Offset = "0xAE966C", VA = "0xAE966C")]
	public static Point GetTopLeftAndStyles(ref int x, ref int y, int w, int h, int frameXinc, int frameYinc)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B07")]
	[Cpp2IlInjected.Address(RVA = "0xAE9C7C", Offset = "0xAE9C7C", VA = "0xAE9C7C")]
	public static bool CheckTileFrames(int type, int sx, int sy, int w, int h, int styleX, int frameXinc, int styleY, int frameYinc)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B08")]
	[Cpp2IlInjected.Address(RVA = "0xAE9DB0", Offset = "0xAE9DB0", VA = "0xAE9DB0")]
	public static bool CheckTileAnchors(int sx, int sy, int w, int h, int mode, AnchorType anchor)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B09")]
	[Cpp2IlInjected.Address(RVA = "0xAD6D10", Offset = "0xAD6D10", VA = "0xAD6D10")]
	public static bool AnchorValid(Tile tileCache, AnchorType anchor)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B0A")]
	[Cpp2IlInjected.Address(RVA = "0xAE8704", Offset = "0xAE8704", VA = "0xAE8704")]
	public static bool CanPlaceSink(int x, int y, ushort type, int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B0B")]
	[Cpp2IlInjected.Address(RVA = "0xAEAA68", Offset = "0xAEAA68", VA = "0xAEAA68")]
	public static void Place3x4(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B0C")]
	[Cpp2IlInjected.Address(RVA = "0xAEAE0C", Offset = "0xAEAE0C", VA = "0xAEAE0C")]
	public static void Place5x4(int x, int y, ushort type, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B0D")]
	[Cpp2IlInjected.Address(RVA = "0xAEB290", Offset = "0xAEB290", VA = "0xAEB290")]
	public static void Place3x1(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B0E")]
	[Cpp2IlInjected.Address(RVA = "0xAEB60C", Offset = "0xAEB60C", VA = "0xAEB60C")]
	public static void Place3x2(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B0F")]
	[Cpp2IlInjected.Address(RVA = "0xAEBFF0", Offset = "0xAEBFF0", VA = "0xAEBFF0")]
	public static void Place2x2Style(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B10")]
	[Cpp2IlInjected.Address(RVA = "0xAEC56C", Offset = "0xAEC56C", VA = "0xAEC56C")]
	public static bool NearFriendlyWall(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B11")]
	[Cpp2IlInjected.Address(RVA = "0xAEC9E4", Offset = "0xAEC9E4", VA = "0xAEC9E4")]
	public static void Check2x2Style(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B12")]
	[Cpp2IlInjected.Address(RVA = "0xAED910", Offset = "0xAED910", VA = "0xAED910")]
	public static void PlacePumpkin(int x, int superY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B13")]
	[Cpp2IlInjected.Address(RVA = "0xAEE00C", Offset = "0xAEE00C", VA = "0xAEE00C")]
	public static void GrowPumpkin(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B14")]
	[Cpp2IlInjected.Address(RVA = "0xAEE660", Offset = "0xAEE660", VA = "0xAEE660")]
	public static void FixHearts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B15")]
	[Cpp2IlInjected.Address(RVA = "0xAEEE08", Offset = "0xAEEE08", VA = "0xAEEE08")]
	public static void DestroyHeart(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B16")]
	[Cpp2IlInjected.Address(RVA = "0xAEE800", Offset = "0xAEE800", VA = "0xAEE800")]
	public static void FixHeart(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B17")]
	[Cpp2IlInjected.Address(RVA = "0xAEF044", Offset = "0xAEF044", VA = "0xAEF044")]
	public static void FixChands()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B18")]
	[Cpp2IlInjected.Address(RVA = "0xAEF24C", Offset = "0xAEF24C", VA = "0xAEF24C")]
	public static void FixChand(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B19")]
	[Cpp2IlInjected.Address(RVA = "0xAAAA04", Offset = "0xAAAA04", VA = "0xAAAA04")]
	public static void PlaceChand(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B1A")]
	[Cpp2IlInjected.Address(RVA = "0xAEF560", Offset = "0xAEF560", VA = "0xAEF560")]
	public static void CheckChand(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B1B")]
	[Cpp2IlInjected.Address(RVA = "0xAF09B0", Offset = "0xAF09B0", VA = "0xAF09B0")]
	public static void Check3x3(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B1C")]
	[Cpp2IlInjected.Address(RVA = "0xAF1F7C", Offset = "0xAF1F7C", VA = "0xAF1F7C")]
	public static void Check2x5(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B1D")]
	[Cpp2IlInjected.Address(RVA = "0xAF26C4", Offset = "0xAF26C4", VA = "0xAF26C4")]
	public static void Check3x5(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B1E")]
	[Cpp2IlInjected.Address(RVA = "0xAF2DAC", Offset = "0xAF2DAC", VA = "0xAF2DAC")]
	public static void Check3x6(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B1F")]
	[Cpp2IlInjected.Address(RVA = "0xAF359C", Offset = "0xAF359C", VA = "0xAF359C")]
	public static void Place3x3(int x, int y, ushort type, int style = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B20")]
	[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF3D70", VA = "0xAF3D70")]
	public static void PlaceSunflower(int x, int y, ushort type = 27)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B21")]
	[Cpp2IlInjected.Address(RVA = "0xAF4368", Offset = "0xAF4368", VA = "0xAF4368")]
	public static void FixSunflowers()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B22")]
	[Cpp2IlInjected.Address(RVA = "0xAF4534", Offset = "0xAF4534", VA = "0xAF4534")]
	public static void FixSunflower(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B23")]
	[Cpp2IlInjected.Address(RVA = "0xAF47B4", Offset = "0xAF47B4", VA = "0xAF47B4")]
	public static void CheckSunflower(int i, int j, int type = 27)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B24")]
	[Cpp2IlInjected.Address(RVA = "0xAF5154", Offset = "0xAF5154", VA = "0xAF5154")]
	public static void CheckDye(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B25")]
	[Cpp2IlInjected.Address(RVA = "0xAF5398", Offset = "0xAF5398", VA = "0xAF5398")]
	public static void CheckRockGolemHead(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B26")]
	[Cpp2IlInjected.Address(RVA = "0xAF5464", Offset = "0xAF5464", VA = "0xAF5464")]
	public static void CheckStinkbugBlocker(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B27")]
	[Cpp2IlInjected.Address(RVA = "0xAF55B8", Offset = "0xAF55B8", VA = "0xAF55B8")]
	public static bool AttemptReorientingStinkbugBlocker(int x, int y, int wall, ref int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B28")]
	[Cpp2IlInjected.Address(RVA = "0xAF5758", Offset = "0xAF5758", VA = "0xAF5758")]
	public static void CheckGnome(int x, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B29")]
	[Cpp2IlInjected.Address(RVA = "0xAF5B30", Offset = "0xAF5B30", VA = "0xAF5B30")]
	public static void PlaceGnome(int x, int y, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B2A")]
	[Cpp2IlInjected.Address(RVA = "0xAF5BD4", Offset = "0xAF5BD4", VA = "0xAF5BD4")]
	public static void PlaceDye(int x, int y, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B2B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E438", Offset = "0xA6E438", VA = "0xA6E438")]
	public static bool PlacePot(int x, int y, ushort type = 28, int style = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B2C")]
	[Cpp2IlInjected.Address(RVA = "0xAF66B0", Offset = "0xAF66B0", VA = "0xAF66B0")]
	public static bool CheckCactus(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B2D")]
	[Cpp2IlInjected.Address(RVA = "0xAF7324", Offset = "0xAF7324", VA = "0xAF7324")]
	public static void PlantCactus(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B2E")]
	[Cpp2IlInjected.Address(RVA = "0xAF9310", Offset = "0xAF9310", VA = "0xAF9310")]
	public static void CheckOrb(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B2F")]
	[Cpp2IlInjected.Address(RVA = "0xAFA7B8", Offset = "0xAFA7B8", VA = "0xAFA7B8")]
	public static void CheckPalmTree(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B30")]
	[Cpp2IlInjected.Address(RVA = "0xAFAC50", Offset = "0xAFAC50", VA = "0xAFAC50")]
	public static void CheckTreeWithSettings(int x, int y, CheckTreeSettings settings)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B31")]
	[Cpp2IlInjected.Address(RVA = "0xAFC000", Offset = "0xAFC000", VA = "0xAFC000")]
	public static void CheckTree(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B32")]
	[Cpp2IlInjected.Address(RVA = "0xAFD8F8", Offset = "0xAFD8F8", VA = "0xAFD8F8")]
	public static bool TileIsExposedToAir(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B33")]
	[Cpp2IlInjected.Address(RVA = "0xAFDB04", Offset = "0xAFDB04", VA = "0xAFDB04")]
	public static bool TryKillingTreesAboveIfTheyWouldBecomeInvalid(int i, int j, int newFloorType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B34")]
	[Cpp2IlInjected.Address(RVA = "0xA51174", Offset = "0xA51174", VA = "0xA51174")]
	public static void Convert(int i, int j, int conversionType, int size = 4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B35")]
	[Cpp2IlInjected.Address(RVA = "0xAFE0F0", Offset = "0xAFE0F0", VA = "0xAFE0F0")]
	public static void CactusFrame(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B36")]
	[Cpp2IlInjected.Address(RVA = "0xAF7420", Offset = "0xAF7420", VA = "0xAF7420")]
	public static void GrowCactus(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B37")]
	[Cpp2IlInjected.Address(RVA = "0xAFF250", Offset = "0xAFF250", VA = "0xAFF250")]
	public static void CheckPot(int i, int j, int type = 28)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B38")]
	[Cpp2IlInjected.Address(RVA = "0xB005B0", Offset = "0xB005B0", VA = "0xB005B0")]
	private static void SpawnThingsFromPot(int i, int j, int x2, int y2, int style)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B39")]
	[Cpp2IlInjected.Address(RVA = "0xAB0CB4", Offset = "0xAB0CB4", VA = "0xAB0CB4")]
	public static int PlaceChest(int x, int y, ushort type = 21, bool notNearOtherChests = false, int style = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B3A")]
	[Cpp2IlInjected.Address(RVA = "0xB04958", Offset = "0xB04958", VA = "0xB04958")]
	public static void PlaceChestDirect(int x, int y, ushort type, int style, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B3B")]
	[Cpp2IlInjected.Address(RVA = "0xB04C1C", Offset = "0xB04C1C", VA = "0xB04C1C")]
	public static void PlaceDresserDirect(int x, int y, ushort type, int style, int id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B3C")]
	[Cpp2IlInjected.Address(RVA = "0xB04F7C", Offset = "0xB04F7C", VA = "0xB04F7C")]
	public static void CheckChest(int i, int j, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B3D")]
	[Cpp2IlInjected.Address(RVA = "0xB05784", Offset = "0xB05784", VA = "0xB05784")]
	private static int GetChestItemDrop(int x, int y, int type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B3E")]
	[Cpp2IlInjected.Address(RVA = "0xB058CC", Offset = "0xB058CC", VA = "0xB058CC")]
	public static bool PlaceActuator(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B3F")]
	[Cpp2IlInjected.Address(RVA = "0xB05A04", Offset = "0xB05A04", VA = "0xB05A04")]
	public static bool KillActuator(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B40")]
	[Cpp2IlInjected.Address(RVA = "0xA12C04", Offset = "0xA12C04", VA = "0xA12C04")]
	public static bool PlaceWire(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B41")]
	[Cpp2IlInjected.Address(RVA = "0xB05C98", Offset = "0xB05C98", VA = "0xB05C98")]
	public static bool KillWire(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B42")]
	[Cpp2IlInjected.Address(RVA = "0xB05F2C", Offset = "0xB05F2C", VA = "0xB05F2C")]
	public static bool PlaceWire2(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B43")]
	[Cpp2IlInjected.Address(RVA = "0xB06064", Offset = "0xB06064", VA = "0xB06064")]
	public static bool KillWire2(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B44")]
	[Cpp2IlInjected.Address(RVA = "0xB062F8", Offset = "0xB062F8", VA = "0xB062F8")]
	public static bool PlaceWire3(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B45")]
	[Cpp2IlInjected.Address(RVA = "0xB06430", Offset = "0xB06430", VA = "0xB06430")]
	public static bool KillWire3(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B46")]
	[Cpp2IlInjected.Address(RVA = "0xB066C4", Offset = "0xB066C4", VA = "0xB066C4")]
	public static bool PlaceWire4(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B47")]
	[Cpp2IlInjected.Address(RVA = "0xB067FC", Offset = "0xB067FC", VA = "0xB067FC")]
	public static bool KillWire4(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B48")]
	[Cpp2IlInjected.Address(RVA = "0xB06A90", Offset = "0xB06A90", VA = "0xB06A90")]
	public static bool IsFitToPlaceFlowerIn(int x, int y, int typeAttemptedToPlace)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B49")]
	[Cpp2IlInjected.Address(RVA = "0xB06D44", Offset = "0xB06D44", VA = "0xB06D44")]
	private static bool SeaOatWaterCheck(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B4A")]
	[Cpp2IlInjected.Address(RVA = "0xB070EC", Offset = "0xB070EC", VA = "0xB070EC")]
	private static bool PlantSeaOat(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B4B")]
	[Cpp2IlInjected.Address(RVA = "0xB0740C", Offset = "0xB0740C", VA = "0xB0740C")]
	private static bool CheckSeaOat(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B4C")]
	[Cpp2IlInjected.Address(RVA = "0xB07590", Offset = "0xB07590", VA = "0xB07590")]
	private static bool GrowSeaOat(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B4D")]
	[Cpp2IlInjected.Address(RVA = "0xB076E8", Offset = "0xB076E8", VA = "0xB076E8")]
	private static int GetWaterDepth(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B4E")]
	[Cpp2IlInjected.Address(RVA = "0xB0787C", Offset = "0xB0787C", VA = "0xB0787C")]
	private static int CountGrowingPlantTiles(int x, int y, int range, int type)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B4F")]
	[Cpp2IlInjected.Address(RVA = "0xB079E4", Offset = "0xB079E4", VA = "0xB079E4")]
	private static bool PlaceBamboo(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B50")]
	[Cpp2IlInjected.Address(RVA = "0xB07E6C", Offset = "0xB07E6C", VA = "0xB07E6C")]
	public static void CheckBamboo(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B51")]
	[Cpp2IlInjected.Address(RVA = "0xB08370", Offset = "0xB08370", VA = "0xB08370")]
	public static void PlaceUnderwaterPlant(ushort type, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B52")]
	[Cpp2IlInjected.Address(RVA = "0xB084F8", Offset = "0xB084F8", VA = "0xB084F8")]
	public static bool CanUnderwaterPlantGrowHere(ushort type, int x, int y, bool ignoreSelf)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B53")]
	[Cpp2IlInjected.Address(RVA = "0xB08720", Offset = "0xB08720", VA = "0xB08720")]
	public static void CheckUnderwaterPlant(ushort type, int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B54")]
	[Cpp2IlInjected.Address(RVA = "0xB08AFC", Offset = "0xB08AFC", VA = "0xB08AFC")]
	public static Point PlaceCatTail(int x, int j)
	{
		return default(Point);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B55")]
	[Cpp2IlInjected.Address(RVA = "0xB09950", Offset = "0xB09950", VA = "0xB09950")]
	public static void CheckCatTail(int x, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B56")]
	[Cpp2IlInjected.Address(RVA = "0xB0AD64", Offset = "0xB0AD64", VA = "0xB0AD64")]
	public static void GrowCheckSeaweed(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B57")]
	[Cpp2IlInjected.Address(RVA = "0xB0B500", Offset = "0xB0B500", VA = "0xB0B500")]
	public static void GrowCatTail(int x, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B58")]
	[Cpp2IlInjected.Address(RVA = "0xB0C494", Offset = "0xB0C494", VA = "0xB0C494")]
	public static bool PlaceLilyPad(int x, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B59")]
	[Cpp2IlInjected.Address(RVA = "0xA62368", Offset = "0xA62368", VA = "0xA62368")]
	public static void CheckLilyPad(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B5A")]
	[Cpp2IlInjected.Address(RVA = "0xB0D24C", Offset = "0xB0D24C", VA = "0xB0D24C")]
	public static bool TryKillingReplaceableTile(int x, int y, int tileType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B5B")]
	[Cpp2IlInjected.Address(RVA = "0xA1B7C0", Offset = "0xA1B7C0", VA = "0xA1B7C0")]
	public static bool PlaceTile(int i, int j, int Type, bool mute = false, bool forced = false, int plr = -1, int style = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B5C")]
	[Cpp2IlInjected.Address(RVA = "0xB0DFA0", Offset = "0xB0DFA0", VA = "0xB0DFA0")]
	public static void KillWall(int i, int j, bool fail = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B5D")]
	[Cpp2IlInjected.Address(RVA = "0xB0E2B0", Offset = "0xB0E2B0", VA = "0xB0E2B0")]
	private static bool KillWall_CheckFailure(bool fail, Tile tileCache)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B5E")]
	[Cpp2IlInjected.Address(RVA = "0xB0E3FC", Offset = "0xB0E3FC", VA = "0xB0E3FC")]
	private static void KillWall_PlaySounds(int i, int j, Tile tileCache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B5F")]
	[Cpp2IlInjected.Address(RVA = "0xB0FFF8", Offset = "0xB0FFF8", VA = "0xB0FFF8")]
	private static void KillWall_DropItems(int i, int j, Tile tileCache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B60")]
	[Cpp2IlInjected.Address(RVA = "0xB10114", Offset = "0xB10114", VA = "0xB10114")]
	private static int KillWall_GetItemDrops(Tile tileCache)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B61")]
	[Cpp2IlInjected.Address(RVA = "0xB0E600", Offset = "0xB0E600", VA = "0xB0E600")]
	private static void KillWall_MakeWallDust(int i, int j, Tile tileCache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B62")]
	[Cpp2IlInjected.Address(RVA = "0xB114F4", Offset = "0xB114F4", VA = "0xB114F4")]
	public static void LaunchRocket(int x, int y, bool fromWiring)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B63")]
	[Cpp2IlInjected.Address(RVA = "0xB11814", Offset = "0xB11814", VA = "0xB11814")]
	public static void LaunchRocketSmall(int x, int y, bool fromWiring)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B64")]
	[Cpp2IlInjected.Address(RVA = "0xB11AA4", Offset = "0xB11AA4", VA = "0xB11AA4")]
	public static bool CanKillTile(int i, int j, SpecialKillTileContext context)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B65")]
	[Cpp2IlInjected.Address(RVA = "0xB11BD8", Offset = "0xB11BD8", VA = "0xB11BD8")]
	public static bool CanKillTile(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B66")]
	[Cpp2IlInjected.Address(RVA = "0xB11C6C", Offset = "0xB11C6C", VA = "0xB11C6C")]
	public static bool CanKillTile(int i, int j, out bool blockDamaged)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B67")]
	[Cpp2IlInjected.Address(RVA = "0xB12574", Offset = "0xB12574", VA = "0xB12574")]
	public static bool IsTileReplacable(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B68")]
	[Cpp2IlInjected.Address(RVA = "0xB12888", Offset = "0xB12888", VA = "0xB12888")]
	public static int CheckTileBreakability(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B69")]
	[Cpp2IlInjected.Address(RVA = "0xB13164", Offset = "0xB13164", VA = "0xB13164")]
	public static bool CheckTileBreakability2_ShouldTileSurvive(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B6A")]
	[Cpp2IlInjected.Address(RVA = "0xB13494", Offset = "0xB13494", VA = "0xB13494")]
	public static bool ReplaceWall(int x, int y, ushort targetWall)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B6B")]
	[Cpp2IlInjected.Address(RVA = "0xB136BC", Offset = "0xB136BC", VA = "0xB136BC")]
	public static bool ReplaceTile(int x, int y, ushort targetType, int targetStyle)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B6C")]
	[Cpp2IlInjected.Address(RVA = "0xB1B5D8", Offset = "0xB1B5D8", VA = "0xB1B5D8")]
	private static void ReplaceTIle_DoActualReplacement(ushort targetType, int targetStyle, int topLeftX, int topLeftY, Tile t)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B6D")]
	[Cpp2IlInjected.Address(RVA = "0xB1BAC8", Offset = "0xB1BAC8", VA = "0xB1BAC8")]
	private static void ReplaceTile_DoActualReplacement_Single(ushort targetType, int targetStyle, int topLeftX, int topLeftY, Tile t)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B6E")]
	[Cpp2IlInjected.Address(RVA = "0xB1BE1C", Offset = "0xB1BE1C", VA = "0xB1BE1C")]
	private static void ReplaceTile_EliminateNaturalExtras(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B6F")]
	[Cpp2IlInjected.Address(RVA = "0xB1B8DC", Offset = "0xB1B8DC", VA = "0xB1B8DC")]
	private static void ReplaceTile_DoActualReplacement_Area(ushort targetType, int targetStyle, int topLeftX, int topLeftY, int areaSizeX, int areaSizeY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B70")]
	[Cpp2IlInjected.Address(RVA = "0xB14034", Offset = "0xB14034", VA = "0xB14034")]
	private static void MoveReplaceTileAnchor(ref int x, ref int y, ushort targetType, Tile t)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B71")]
	[Cpp2IlInjected.Address(RVA = "0xB1C790", Offset = "0xB1C790", VA = "0xB1C790")]
	public static bool WouldTileReplacementBeBlockedByLiquid(int x, int y, int liquidType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B72")]
	[Cpp2IlInjected.Address(RVA = "0xB138D0", Offset = "0xB138D0", VA = "0xB138D0")]
	public static bool WouldTileReplacementWork(ushort attemptingToReplaceWith, int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B73")]
	[Cpp2IlInjected.Address(RVA = "0xB1CA10", Offset = "0xB1CA10", VA = "0xB1CA10")]
	private static bool ReplaceTile_IsValidSolid(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B74")]
	[Cpp2IlInjected.Address(RVA = "0xB1CB50", Offset = "0xB1CB50", VA = "0xB1CB50")]
	private static bool ReplaceTile_IsValidTorch(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B75")]
	[Cpp2IlInjected.Address(RVA = "0xB1CB60", Offset = "0xB1CB60", VA = "0xB1CB60")]
	private static bool ReplaceTile_IsValidCampfire(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B76")]
	[Cpp2IlInjected.Address(RVA = "0xB1CBF4", Offset = "0xB1CBF4", VA = "0xB1CBF4")]
	private static bool ReplaceTile_IsValidChest(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B77")]
	[Cpp2IlInjected.Address(RVA = "0xB1CC78", Offset = "0xB1CC78", VA = "0xB1CC78")]
	private static bool ReplaceTile_IsValidDresser(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B78")]
	[Cpp2IlInjected.Address(RVA = "0xB1CB70", Offset = "0xB1CB70", VA = "0xB1CB70")]
	private static bool ReplaceTile_IsValidPlatform(int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B79")]
	[Cpp2IlInjected.Address(RVA = "0xB1CCFC", Offset = "0xB1CCFC", VA = "0xB1CCFC")]
	public static bool GetAshTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B7A")]
	[Cpp2IlInjected.Address(RVA = "0xB1CE54", Offset = "0xB1CE54", VA = "0xB1CE54")]
	public static bool GetVanityTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B7B")]
	[Cpp2IlInjected.Address(RVA = "0xB1D058", Offset = "0xB1D058", VA = "0xB1D058")]
	public static bool GetGemTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B7C")]
	[Cpp2IlInjected.Address(RVA = "0xB1D2C8", Offset = "0xB1D2C8", VA = "0xB1D2C8")]
	public static bool GetCommonTreeFoliageData(int i, int j, int xoffset, ref int treeFrame, ref int treeStyle, out int floorY, out int topTextureFrameWidth, out int topTextureFrameHeight)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B7D")]
	[Cpp2IlInjected.Address(RVA = "0xA7A3B0", Offset = "0xA7A3B0", VA = "0xA7A3B0")]
	public static int GetHollowTreeFoliageStyle()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B7E")]
	[Cpp2IlInjected.Address(RVA = "0xB1D988", Offset = "0xB1D988", VA = "0xB1D988")]
	public static int GetTreeFrame(Tile t)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B7F")]
	[Cpp2IlInjected.Address(RVA = "0xB1D9DC", Offset = "0xB1D9DC", VA = "0xB1D9DC")]
	public static TreeTypes GetTreeType(int tileType)
	{
		return default(TreeTypes);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B80")]
	[Cpp2IlInjected.Address(RVA = "0xB1DACC", Offset = "0xB1DACC", VA = "0xB1DACC")]
	public static bool IsThisAMushroomTree(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B81")]
	[Cpp2IlInjected.Address(RVA = "0xA35F64", Offset = "0xA35F64", VA = "0xA35F64")]
	public static void ResetTreeShakes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B82")]
	[Cpp2IlInjected.Address(RVA = "0xB1DEB8", Offset = "0xB1DEB8", VA = "0xB1DEB8")]
	private static void ShakeTree(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B83")]
	[Cpp2IlInjected.Address(RVA = "0xA51014", Offset = "0xA51014", VA = "0xA51014")]
	private static void GetVineTop(int i, int j, out int x, out int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B84")]
	[Cpp2IlInjected.Address(RVA = "0xB1DBD4", Offset = "0xB1DBD4", VA = "0xB1DBD4")]
	public static void GetTreeBottom(int i, int j, out int x, out int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B85")]
	[Cpp2IlInjected.Address(RVA = "0xB1B154", Offset = "0xB1B154", VA = "0xB1B154")]
	private static void AttemptFossilShattering(int i, int j, Tile tileCache, bool fail)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B86")]
	[Cpp2IlInjected.Address(RVA = "0xA2EA24", Offset = "0xA2EA24", VA = "0xA2EA24")]
	public static void KillTile(int i, int j, bool fail = false, bool effectOnly = false, bool noItem = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B87")]
	[Cpp2IlInjected.Address(RVA = "0xB256DC", Offset = "0xB256DC", VA = "0xB256DC")]
	private static Player GetPlayerForTile(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002B88")]
	[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB1AE80", VA = "0xB1AE80")]
	private static void KillTile_DropItems(int x, int y, Tile tileCache, bool includeLargeObjectDrops = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B89")]
	[Cpp2IlInjected.Address(RVA = "0xB20CEC", Offset = "0xB20CEC", VA = "0xB20CEC")]
	public static void KillTile_GetItemDrops(int x, int y, Tile tileCache, out int dropItem, out int dropItemStack, out int secondaryItem, out int secondaryItemStack, bool includeLargeObjectDrops = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B8A")]
	[Cpp2IlInjected.Address(RVA = "0xB2602C", Offset = "0xB2602C", VA = "0xB2602C")]
	private static void SetGemTreeDrops(int gemType, int seedType, Tile tileCache, ref int dropItem, ref int secondaryItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B8B")]
	[Cpp2IlInjected.Address(RVA = "0xB26140", Offset = "0xB26140", VA = "0xB26140")]
	private static void SetVanityTreeDrops(int dropType, Tile tileCache, ref int dropItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B8C")]
	[Cpp2IlInjected.Address(RVA = "0xB0DA48", Offset = "0xB0DA48", VA = "0xB0DA48")]
	public static bool IsHarvestableHerbWithSeed(int type, int style)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B8D")]
	[Cpp2IlInjected.Address(RVA = "0xB2582C", Offset = "0xB2582C", VA = "0xB2582C")]
	private static bool KillTile_ShouldDropSeeds(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B8E")]
	[Cpp2IlInjected.Address(RVA = "0xB25954", Offset = "0xB25954", VA = "0xB25954")]
	private static void KillTile_GetTreeDrops(int i, int j, Tile tileCache, ref bool bonusWood, ref int dropItem, ref int secondaryItem)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B8F")]
	[Cpp2IlInjected.Address(RVA = "0xB246B0", Offset = "0xB246B0", VA = "0xB246B0")]
	private static void KillTile_DropBait(int i, int j, Tile tileCache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B90")]
	[Cpp2IlInjected.Address(RVA = "0xB1A290", Offset = "0xB1A290", VA = "0xB1A290")]
	public static void KillTile_PlaySounds(int i, int j, bool fail, Tile tileCache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B91")]
	[Cpp2IlInjected.Address(RVA = "0xB261D4", Offset = "0xB261D4", VA = "0xB261D4")]
	public static Rectangle? GetTileVisualHitbox(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002B92")]
	[Cpp2IlInjected.Address(RVA = "0xB142BC", Offset = "0xB142BC", VA = "0xB142BC")]
	public static int KillTile_GetTileDustAmount(bool fail, Tile tileCache)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B93")]
	[Cpp2IlInjected.Address(RVA = "0xB14504", Offset = "0xB14504", VA = "0xB14504")]
	public static int KillTile_MakeTileDust(int i, int j, Tile tileCache)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B94")]
	[Cpp2IlInjected.Address(RVA = "0xA2B17C", Offset = "0xA2B17C", VA = "0xA2B17C")]
	public static bool IsOpenDoorAnchorFrame(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B95")]
	[Cpp2IlInjected.Address(RVA = "0xB1309C", Offset = "0xB1309C", VA = "0xB1309C")]
	public static bool IsLockedDoor(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B96")]
	[Cpp2IlInjected.Address(RVA = "0xAB224C", Offset = "0xAB224C", VA = "0xAB224C")]
	public static bool IsLockedDoor(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B97")]
	[Cpp2IlInjected.Address(RVA = "0xB2637C", Offset = "0xB2637C", VA = "0xB2637C")]
	public static void DropDoorItem(int x, int y, int doorStyle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B98")]
	[Cpp2IlInjected.Address(RVA = "0xAB2CE8", Offset = "0xAB2CE8", VA = "0xAB2CE8")]
	public static IEntitySource GetItemSource_FromTileBreak(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002B99")]
	[Cpp2IlInjected.Address(RVA = "0xB114EC", Offset = "0xB114EC", VA = "0xB114EC")]
	public static IEntitySource GetItemSource_FromWallBreak(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002B9A")]
	[Cpp2IlInjected.Address(RVA = "0xB2463C", Offset = "0xB2463C", VA = "0xB2463C")]
	public static IEntitySource GetItemSource_FromTreeShake(int x, int y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002B9B")]
	[Cpp2IlInjected.Address(RVA = "0xB264F8", Offset = "0xB264F8", VA = "0xB264F8")]
	public static bool PlayerLOS(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B9C")]
	[Cpp2IlInjected.Address(RVA = "0xB26760", Offset = "0xB26760", VA = "0xB26760")]
	public static void ChlorophyteDefense(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002B9D")]
	[Cpp2IlInjected.Address(RVA = "0xB26AF0", Offset = "0xB26AF0", VA = "0xB26AF0")]
	public static bool Chlorophyte(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B9E")]
	[Cpp2IlInjected.Address(RVA = "0xB26F74", Offset = "0xB26F74", VA = "0xB26F74")]
	private static bool nearbyChlorophyte(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002B9F")]
	[Cpp2IlInjected.Address(RVA = "0xB27254", Offset = "0xB27254", VA = "0xB27254")]
	public static int CountNearBlocksTypes(int i, int j, int radius, int cap, ushort tiletypes)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA0")]
	[Cpp2IlInjected.Address(RVA = "0xB274D4", Offset = "0xB274D4", VA = "0xB274D4")]
	public static void hardUpdateWorld(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA1")]
	[Cpp2IlInjected.Address(RVA = "0xB294A4", Offset = "0xB294A4", VA = "0xB294A4")]
	public static bool SolidTile(short tileSHeader, ushort tileType)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA2")]
	[Cpp2IlInjected.Address(RVA = "0xAEA94C", Offset = "0xAEA94C", VA = "0xAEA94C")]
	public static bool SolidTile(Tile testTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA3")]
	[Cpp2IlInjected.Address(RVA = "0xB29588", Offset = "0xB29588", VA = "0xB29588")]
	public static bool TileEmpty(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA4")]
	[Cpp2IlInjected.Address(RVA = "0xB296EC", Offset = "0xB296EC", VA = "0xB296EC")]
	public static bool SolidOrSlopedTile(Tile tile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA5")]
	[Cpp2IlInjected.Address(RVA = "0xA44E94", Offset = "0xA44E94", VA = "0xA44E94")]
	public static int TileType(int x, int y)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA6")]
	[Cpp2IlInjected.Address(RVA = "0xA3D180", Offset = "0xA3D180", VA = "0xA3D180")]
	public static bool SolidOrSlopedTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA7")]
	[Cpp2IlInjected.Address(RVA = "0xB297EC", Offset = "0xB297EC", VA = "0xB297EC")]
	public static bool IsRope(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA8")]
	[Cpp2IlInjected.Address(RVA = "0xB29BC8", Offset = "0xB29BC8", VA = "0xB29BC8")]
	public static bool SolidTile(Point p)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BA9")]
	[Cpp2IlInjected.Address(RVA = "0xA297D0", Offset = "0xA297D0", VA = "0xA297D0")]
	public static bool SolidTile(int i, int j, bool noDoors = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BAA")]
	[Cpp2IlInjected.Address(RVA = "0xB29C4C", Offset = "0xB29C4C", VA = "0xB29C4C")]
	public static bool SolidTile(Tile tileCache, bool noDoors = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BAB")]
	[Cpp2IlInjected.Address(RVA = "0xA1B6E0", Offset = "0xA1B6E0", VA = "0xA1B6E0")]
	public static bool SolidTile2(Tile testTile)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BAC")]
	[Cpp2IlInjected.Address(RVA = "0xB29DC8", Offset = "0xB29DC8", VA = "0xB29DC8")]
	public static bool PlatformProperTopFrame(short frameX)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BAD")]
	[Cpp2IlInjected.Address(RVA = "0xAB2AA0", Offset = "0xAB2AA0", VA = "0xAB2AA0")]
	public static bool SolidTileAllowBottomSlope(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BAE")]
	[Cpp2IlInjected.Address(RVA = "0xB29E24", Offset = "0xB29E24", VA = "0xB29E24")]
	public static bool ActiveAndWalkableTile(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BAF")]
	[Cpp2IlInjected.Address(RVA = "0xAB476C", Offset = "0xAB476C", VA = "0xAB476C")]
	public static bool SolidTileAllowTopSlope(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB0")]
	[Cpp2IlInjected.Address(RVA = "0xB29F5C", Offset = "0xB29F5C", VA = "0xB29F5C")]
	public static bool SolidTileAllowLeftSlope(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB1")]
	[Cpp2IlInjected.Address(RVA = "0xB2A17C", Offset = "0xB2A17C", VA = "0xB2A17C")]
	public static bool SolidTileAllowRightSlope(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB2")]
	[Cpp2IlInjected.Address(RVA = "0xABC6DC", Offset = "0xABC6DC", VA = "0xABC6DC")]
	public static bool TopEdgeCanBeAttachedTo(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB3")]
	[Cpp2IlInjected.Address(RVA = "0xABCB00", Offset = "0xABCB00", VA = "0xABCB00")]
	public static bool RightEdgeCanBeAttachedTo(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB4")]
	[Cpp2IlInjected.Address(RVA = "0xABCCF0", Offset = "0xABCCF0", VA = "0xABCCF0")]
	public static bool LeftEdgeCanBeAttachedTo(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB5")]
	[Cpp2IlInjected.Address(RVA = "0xABC924", Offset = "0xABC924", VA = "0xABC924")]
	public static bool BottomEdgeCanBeAttachedTo(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB6")]
	[Cpp2IlInjected.Address(RVA = "0xB2A39C", Offset = "0xB2A39C", VA = "0xB2A39C")]
	public static bool SolidTile3(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB7")]
	[Cpp2IlInjected.Address(RVA = "0xB2A4A4", Offset = "0xB2A4A4", VA = "0xB2A4A4")]
	public static bool SolidTile3(Tile t)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB8")]
	[Cpp2IlInjected.Address(RVA = "0xAB7888", Offset = "0xAB7888", VA = "0xAB7888")]
	public static bool SolidTile2(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BB9")]
	[Cpp2IlInjected.Address(RVA = "0xB2A5DC", Offset = "0xB2A5DC", VA = "0xB2A5DC")]
	public static bool SolidTileNoAttach(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BBA")]
	[Cpp2IlInjected.Address(RVA = "0xB2A8B4", Offset = "0xB2A8B4", VA = "0xB2A8B4")]
	public static void MineHouse(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BBB")]
	[Cpp2IlInjected.Address(RVA = "0xB2EE98", Offset = "0xB2EE98", VA = "0xB2EE98")]
	public static void CountTiles(int X)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BBC")]
	[Cpp2IlInjected.Address(RVA = "0xB2F748", Offset = "0xB2F748", VA = "0xB2F748")]
	public static void AddUpAlignmentCounts(bool clearCounts = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BBD")]
	[Cpp2IlInjected.Address(RVA = "0xB2FBB8", Offset = "0xB2FBB8", VA = "0xB2FBB8")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x393388", Offset = "0x393388")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x393388", Offset = "0x393388")]
	public static bool checkPlantDye(int i, int j, bool exoticPlant = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BBE")]
	[Cpp2IlInjected.Address(RVA = "0xB2FE0C", Offset = "0xB2FE0C", VA = "0xB2FE0C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39343C", Offset = "0x39343C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39343C", Offset = "0x39343C")]
	public static void plantDye(int i, int j, bool exoticPlant = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BBF")]
	[Cpp2IlInjected.Address(RVA = "0xB31204", Offset = "0xB31204", VA = "0xB31204")]
	private static int MossConversion(int thisType, int otherType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC0")]
	[Cpp2IlInjected.Address(RVA = "0xB31480", Offset = "0xB31480", VA = "0xB31480")]
	public static void UpdateWorld()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC1")]
	[Cpp2IlInjected.Address(RVA = "0xB32B2C", Offset = "0xB32B2C", VA = "0xB32B2C")]
	public static int GetWorldUpdateRate()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC2")]
	[Cpp2IlInjected.Address(RVA = "0xB32C18", Offset = "0xB32C18", VA = "0xB32C18")]
	private static void UpdateWorld_OvergroundTile(int i, int j, bool checkNPCSpawns, int wallDist)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC3")]
	[Cpp2IlInjected.Address(RVA = "0xB44488", Offset = "0xB44488", VA = "0xB44488")]
	public static bool AttemptToGrowTreeFromSapling(int x, int y, bool underground)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC4")]
	[Cpp2IlInjected.Address(RVA = "0xB45650", Offset = "0xB45650", VA = "0xB45650")]
	public static void DontStarveTryWateringTile(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC5")]
	[Cpp2IlInjected.Address(RVA = "0xB45C88", Offset = "0xB45C88", VA = "0xB45C88")]
	public static bool HasAnyWireNearby(int sourceX, int sourceY, int boxSpread)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC6")]
	[Cpp2IlInjected.Address(RVA = "0xB458D4", Offset = "0xB458D4", VA = "0xB458D4")]
	public static bool IsSafeFromRain(int startX, int startY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC7")]
	[Cpp2IlInjected.Address(RVA = "0xB45EB0", Offset = "0xB45EB0", VA = "0xB45EB0")]
	public static bool TryToggleLight(int x, int y, bool? forcedState, bool skipWires)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC8")]
	[Cpp2IlInjected.Address(RVA = "0xAC4930", Offset = "0xAC4930", VA = "0xAC4930")]
	private static bool HasValidGroundForAbigailsFlowerBelowSpot(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BC9")]
	[Cpp2IlInjected.Address(RVA = "0xB3F8D8", Offset = "0xB3F8D8", VA = "0xB3F8D8")]
	private static bool TryGrowingAbigailsFlower(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BCA")]
	[Cpp2IlInjected.Address(RVA = "0xB463C4", Offset = "0xB463C4", VA = "0xB463C4")]
	private static bool NoNearbyAbigailsFlower(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BCB")]
	[Cpp2IlInjected.Address(RVA = "0xB0DD5C", Offset = "0xB0DD5C", VA = "0xB0DD5C")]
	private static bool HasValidGroundForGlowTulipBelowSpot(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BCC")]
	[Cpp2IlInjected.Address(RVA = "0xAC79F8", Offset = "0xAC79F8", VA = "0xAC79F8")]
	private static bool TryGrowingGlowTulip(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BCD")]
	[Cpp2IlInjected.Address(RVA = "0xB465C8", Offset = "0xB465C8", VA = "0xB465C8")]
	private static bool NoNearbyGlowTulips(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BCE")]
	[Cpp2IlInjected.Address(RVA = "0xB39B70", Offset = "0xB39B70", VA = "0xB39B70")]
	private static void UpdateWorld_UndergroundTile(int i, int j, bool checkNPCSpawns, int wallDist)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BCF")]
	[Cpp2IlInjected.Address(RVA = "0xB4483C", Offset = "0xB4483C", VA = "0xB4483C")]
	private static void GrowWeb(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD0")]
	[Cpp2IlInjected.Address(RVA = "0xB467D0", Offset = "0xB467D0", VA = "0xB467D0")]
	public static bool GeneratePlanteraBulbOnAllMechsDefeated()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD1")]
	[Cpp2IlInjected.Address(RVA = "0xB46CE4", Offset = "0xB46CE4", VA = "0xB46CE4")]
	private static bool AttemptToGeneratePlanteraBulbAt(int i, int j, bool forceBulb)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD2")]
	[Cpp2IlInjected.Address(RVA = "0xB3FD14", Offset = "0xB3FD14", VA = "0xB3FD14")]
	private static void UpdateWorld_GrassGrowth(int i, int j, int minI, int maxI, int minJ, int maxJ, bool underground)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD3")]
	[Cpp2IlInjected.Address(RVA = "0xB44AD8", Offset = "0xB44AD8", VA = "0xB44AD8")]
	private static void TrySpawningTownNPC(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD4")]
	[Cpp2IlInjected.Address(RVA = "0xB44CA4", Offset = "0xB44CA4", VA = "0xB44CA4")]
	public static void SpreadDesertWalls(int wallDist, int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD5")]
	[Cpp2IlInjected.Address(RVA = "0xAAE8CC", Offset = "0xAAE8CC", VA = "0xAAE8CC")]
	public static void PlaceWall(int i, int j, int type, bool mute = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD6")]
	[Cpp2IlInjected.Address(RVA = "0xA44FA0", Offset = "0xA44FA0", VA = "0xA44FA0")]
	public static void SpreadGrass(int i, int j, int dirt = 0, int grass = 2, bool repeat = true, [Optional] TileColorCache color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD7")]
	[Cpp2IlInjected.Address(RVA = "0xB47538", Offset = "0xB47538", VA = "0xB47538")]
	public static void ChasmRunnerSideways(int i, int j, int direction, int steps)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD8")]
	[Cpp2IlInjected.Address(RVA = "0xB48598", Offset = "0xB48598", VA = "0xB48598")]
	public static void CrimStart(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BD9")]
	[Cpp2IlInjected.Address(RVA = "0xB4AAF8", Offset = "0xB4AAF8", VA = "0xB4AAF8")]
	public static void CrimPlaceHearts()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BDA")]
	[Cpp2IlInjected.Address(RVA = "0xB4A658", Offset = "0xB4A658", VA = "0xB4A658")]
	public static void CrimEnt(Vector2D position, int crimDir)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BDB")]
	[Cpp2IlInjected.Address(RVA = "0xB49F68", Offset = "0xB49F68", VA = "0xB49F68")]
	public static void CrimVein(Vector2D position, Vector2D velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BDC")]
	[Cpp2IlInjected.Address(RVA = "0xB4B070", Offset = "0xB4B070", VA = "0xB4B070")]
	public static void ChasmRunner(int i, int j, int steps, bool makeOrb = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BDD")]
	[Cpp2IlInjected.Address(RVA = "0xB4C374", Offset = "0xB4C374", VA = "0xB4C374")]
	public static void ExecuteThreadTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BDE")]
	[Cpp2IlInjected.Address(RVA = "0xA810DC", Offset = "0xA810DC", VA = "0xA810DC")]
	private static void CloseThreadTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BDF")]
	[Cpp2IlInjected.Address(RVA = "0xA80BEC", Offset = "0xA80BEC", VA = "0xA80BEC")]
	private static void WaitForThreadTime()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE0")]
	[Cpp2IlInjected.Address(RVA = "0xB4C708", Offset = "0xB4C708", VA = "0xB4C708")]
	public static void SpawnPlanteraThorns(Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE1")]
	[Cpp2IlInjected.Address(RVA = "0xA7FC90", Offset = "0xA7FC90", VA = "0xA7FC90")]
	public static void GERunner(int i, int j, double speedX = 0.0, double speedY = 0.0, bool good = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE2")]
	[Cpp2IlInjected.Address(RVA = "0xB4CBD8", Offset = "0xB4CBD8", VA = "0xB4CBD8")]
	private static bool badOceanCaveTiles(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE3")]
	[Cpp2IlInjected.Address(RVA = "0xB4CF00", Offset = "0xB4CF00", VA = "0xB4CF00")]
	public static void oceanCave(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE4")]
	[Cpp2IlInjected.Address(RVA = "0xB4E458", Offset = "0xB4E458", VA = "0xB4E458")]
	public static void WavyCaverer(int startX, int startY, double waveStrengthScalar, double wavePercentScalar, int steps, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE5")]
	[Cpp2IlInjected.Address(RVA = "0xAABB08", Offset = "0xAABB08", VA = "0xAABB08")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3934F0", Offset = "0x3934F0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3934F0", Offset = "0x3934F0")]
	public static void TileRunner(int i, int j, double strength, int steps, int type, bool addTile = false, double speedX = 0.0, double speedY = 0.0, bool noYChange = false, bool overRide = true, int ignoreTileType = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE6")]
	[Cpp2IlInjected.Address(RVA = "0xB4EA58", Offset = "0xB4EA58", VA = "0xB4EA58")]
	public static void DirtyRockRunner(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE7")]
	[Cpp2IlInjected.Address(RVA = "0xB4F060", Offset = "0xB4F060", VA = "0xB4F060")]
	public static void MudWallRunner(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE8")]
	[Cpp2IlInjected.Address(RVA = "0xB4F678", Offset = "0xB4F678", VA = "0xB4F678")]
	public static void SnowCloudIsland(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BE9")]
	[Cpp2IlInjected.Address(RVA = "0xB520C8", Offset = "0xB520C8", VA = "0xB520C8")]
	public static void DesertCloudIsland(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BEA")]
	[Cpp2IlInjected.Address(RVA = "0xB54668", Offset = "0xB54668", VA = "0xB54668")]
	public static void CloudIsland(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BEB")]
	[Cpp2IlInjected.Address(RVA = "0xB51C14", Offset = "0xB51C14", VA = "0xB51C14")]
	public static bool WillWaterPlacedHereStayPut(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BEC")]
	[Cpp2IlInjected.Address(RVA = "0xB56C08", Offset = "0xB56C08", VA = "0xB56C08")]
	public static void CloudLake(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BED")]
	[Cpp2IlInjected.Address(RVA = "0xB58DA8", Offset = "0xB58DA8", VA = "0xB58DA8")]
	public static void FloatingIsland(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BEE")]
	[Cpp2IlInjected.Address(RVA = "0xB59820", Offset = "0xB59820", VA = "0xB59820")]
	public static void Caverer(int X, int Y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BEF")]
	[Cpp2IlInjected.Address(RVA = "0xB59EB0", Offset = "0xB59EB0", VA = "0xB59EB0")]
	public static Vector2D digTunnel(double X, double Y, double xDir, double yDir, int Steps, int Size, bool Wet = false)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF0")]
	[Cpp2IlInjected.Address(RVA = "0xB5A4CC", Offset = "0xB5A4CC", VA = "0xB5A4CC")]
	public static void IslandHouse(int i, int j, int islandStyle)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF1")]
	[Cpp2IlInjected.Address(RVA = "0xB5BB40", Offset = "0xB5BB40", VA = "0xB5BB40")]
	public static void Mountinater(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF2")]
	[Cpp2IlInjected.Address(RVA = "0xB5C1BC", Offset = "0xB5C1BC", VA = "0xB5C1BC")]
	public static void MakeWateryIceThing(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF3")]
	[Cpp2IlInjected.Address(RVA = "0xB5CA08", Offset = "0xB5CA08", VA = "0xB5CA08")]
	public static void Lakinater(int i, int j, double strengthMultiplier = 1.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF4")]
	[Cpp2IlInjected.Address(RVA = "0xB5D128", Offset = "0xB5D128", VA = "0xB5D128")]
	public static void SonOfLakinater(int i, int j, double strengthMultiplier = 1.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF5")]
	[Cpp2IlInjected.Address(RVA = "0xB5E418", Offset = "0xB5E418", VA = "0xB5E418")]
	public static void ShroomPatch(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF6")]
	[Cpp2IlInjected.Address(RVA = "0xB5EEE0", Offset = "0xB5EEE0", VA = "0xB5EEE0")]
	public static void Cavinator(int i, int j, int steps)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF7")]
	[Cpp2IlInjected.Address(RVA = "0xB5F650", Offset = "0xB5F650", VA = "0xB5F650")]
	public static void CaveOpenater(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF8")]
	[Cpp2IlInjected.Address(RVA = "0xAFF184", Offset = "0xAFF184", VA = "0xAFF184")]
	public static void DiamondTileFrame(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BF9")]
	[Cpp2IlInjected.Address(RVA = "0xA222BC", Offset = "0xA222BC", VA = "0xA222BC")]
	public static void SquareTileFrame(int i, int j, bool resetFrame = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BFA")]
	[Cpp2IlInjected.Address(RVA = "0xA127F0", Offset = "0xA127F0", VA = "0xA127F0")]
	public static void SquareWallFrame(int i, int j, bool resetFrame = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BFB")]
	[Cpp2IlInjected.Address(RVA = "0xB5FDA0", Offset = "0xB5FDA0", VA = "0xB5FDA0")]
	public static void SectionTileFrameWithCheck(int startX, int startY, int endX, int endY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BFC")]
	[Cpp2IlInjected.Address(RVA = "0xB60228", Offset = "0xB60228", VA = "0xB60228")]
	public static void RefreshSections(int startX, int startY, int endX, int endY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BFD")]
	[Cpp2IlInjected.Address(RVA = "0xB6039C", Offset = "0xB6039C", VA = "0xB6039C")]
	public static void RefreshSection(int sectionX, int sectionY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BFE")]
	[Cpp2IlInjected.Address(RVA = "0xB608B0", Offset = "0xB608B0", VA = "0xB608B0")]
	public static void RefreshStrip(int xStart, int yStart, int xEnd, int yEnd, ref int totalEcho, ref int totalFramed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002BFF")]
	[Cpp2IlInjected.Address(RVA = "0xB60C04", Offset = "0xB60C04", VA = "0xB60C04")]
	public static void Reframe(int x, int y, bool resetFrame = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C00")]
	[Cpp2IlInjected.Address(RVA = "0xB5FF94", Offset = "0xB5FF94", VA = "0xB5FF94")]
	public static void SectionTileFrame(int sectionStartX, int sectionStartY, int sectionEndXInclusive, int sectionEndYInclusive)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C01")]
	[Cpp2IlInjected.Address(RVA = "0xB60620", Offset = "0xB60620", VA = "0xB60620")]
	public static void GetSectionBounds(int sectionStartX, int sectionStartY, int sectionEndXInclusive, int sectionEndYInclusive, out int tileStartX, out int tileEndX, out int tileStartY, out int tileEndY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C02")]
	[Cpp2IlInjected.Address(RVA = "0xA6544C", Offset = "0xA6544C", VA = "0xA6544C")]
	public static void RangeFrame(int startX, int startY, int endX, int endY)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C03")]
	[Cpp2IlInjected.Address(RVA = "0xB60CAC", Offset = "0xB60CAC", VA = "0xB60CAC")]
	public static void WaterCheck()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C04")]
	[Cpp2IlInjected.Address(RVA = "0xB61528", Offset = "0xB61528", VA = "0xB61528")]
	public static void EveryTileFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C05")]
	[Cpp2IlInjected.Address(RVA = "0xB6199C", Offset = "0xB6199C", VA = "0xB6199C")]
	public static void PlantCheck(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C06")]
	[Cpp2IlInjected.Address(RVA = "0xB1C3FC", Offset = "0xB1C3FC", VA = "0xB1C3FC")]
	public static bool CanPoundTile(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C07")]
	[Cpp2IlInjected.Address(RVA = "0xB62A74", Offset = "0xB62A74", VA = "0xB62A74")]
	public static bool SlopeTile(int i, int j, int slope = 0, bool noEffects = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C08")]
	[Cpp2IlInjected.Address(RVA = "0xB62F00", Offset = "0xB62F00", VA = "0xB62F00")]
	public static bool PoundTile(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C09")]
	[Cpp2IlInjected.Address(RVA = "0xB633C4", Offset = "0xB633C4", VA = "0xB633C4")]
	public static void PoundPlatform(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C0A")]
	[Cpp2IlInjected.Address(RVA = "0xB63A2C", Offset = "0xB63A2C", VA = "0xB63A2C")]
	public static int PlatformProperSides(int x, int y, bool acceptNonOpposing = false)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C0B")]
	[Cpp2IlInjected.Address(RVA = "0xB641D8", Offset = "0xB641D8", VA = "0xB641D8")]
	public static bool CacheUpdateMapTile(int i, int j, bool addToList = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C0C")]
	[Cpp2IlInjected.Address(RVA = "0xB642BC", Offset = "0xB642BC", VA = "0xB642BC")]
	public static void PerformCachedMapTileUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C0D")]
	[Cpp2IlInjected.Address(RVA = "0xB643C0", Offset = "0xB643C0", VA = "0xB643C0")]
	public static bool UpdateMapTile(int i, int j, bool addToList = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C0E")]
	[Cpp2IlInjected.Address(RVA = "0xB646A8", Offset = "0xB646A8", VA = "0xB646A8")]
	public static void TileMergeAttemptFrametest(int i, int j, int myType, int lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C0F")]
	[Cpp2IlInjected.Address(RVA = "0xB648D0", Offset = "0xB648D0", VA = "0xB648D0")]
	public static void TileMergeAttemptFrametest(int i, int j, int myType, bool[] lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C10")]
	[Cpp2IlInjected.Address(RVA = "0xB64B78", Offset = "0xB64B78", VA = "0xB64B78")]
	public static void TileMergeAttempt(int myType, int lookfor, ref int up, ref int down, ref int left, ref int right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C11")]
	[Cpp2IlInjected.Address(RVA = "0xB64BB4", Offset = "0xB64BB4", VA = "0xB64BB4")]
	public static void TileMergeAttempt(int myType, bool[] lookfor, ref int up, ref int down, ref int left, ref int right)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C12")]
	[Cpp2IlInjected.Address(RVA = "0xB64C30", Offset = "0xB64C30", VA = "0xB64C30")]
	public static void TileMergeAttempt(int myType, int lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C13")]
	[Cpp2IlInjected.Address(RVA = "0xB64CAC", Offset = "0xB64CAC", VA = "0xB64CAC")]
	public static void TileMergeAttempt(int myType, bool[] lookfor, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C14")]
	[Cpp2IlInjected.Address(RVA = "0xB64DA8", Offset = "0xB64DA8", VA = "0xB64DA8")]
	public static void TileMergeAttempt(int myType, bool[] lookfor, bool[] exclude, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C15")]
	[Cpp2IlInjected.Address(RVA = "0xB64F30", Offset = "0xB64F30", VA = "0xB64F30")]
	public static void TileMergeAttemptWeird(int myType, int changeTo, bool[] exclude, ref int up, ref int down, ref int left, ref int right, ref int upLeft, ref int upRight, ref int downLeft, ref int downRight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C16")]
	[Cpp2IlInjected.Address(RVA = "0xB65078", Offset = "0xB65078", VA = "0xB65078")]
	public static int GetTileMossColor(int tileType)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C17")]
	[Cpp2IlInjected.Address(RVA = "0xB65170", Offset = "0xB65170", VA = "0xB65170")]
	public static void CheckFoodPlatter(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C19")]
	[Cpp2IlInjected.Address(RVA = "0xB656BC", Offset = "0xB656BC", VA = "0xB656BC")]
	public static void TileFrameDoWork(int i, int j, bool resetFrame, bool noBreak, ref bool mapCheck)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C1A")]
	[Cpp2IlInjected.Address(RVA = "0xA0FC48", Offset = "0xA0FC48", VA = "0xA0FC48")]
	public static void TileFrame(int i, int j, bool resetFrame = false, bool noBreak = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C1B")]
	[Cpp2IlInjected.Address(RVA = "0xB7604C", Offset = "0xB7604C", VA = "0xB7604C")]
	private static void StopMergingByInvsibility(ref int currentMerge, Tile block, bool wantedInvisibilityState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C1C")]
	[Cpp2IlInjected.Address(RVA = "0xB7593C", Offset = "0xB7593C", VA = "0xB7593C")]
	private static bool SpawnFallingBlockProjectile(int i, int j, Tile tileCache, Tile tileTopCache, Tile tileBottomCache, int type)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C1D")]
	[Cpp2IlInjected.Address(RVA = "0xB74594", Offset = "0xB74594", VA = "0xB74594")]
	public static void CheckTorch(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C1E")]
	[Cpp2IlInjected.Address(RVA = "0xB74EB0", Offset = "0xB74EB0", VA = "0xB74EB0")]
	public static void CheckProjectilePressurePad(int i, int j)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C1F")]
	[Cpp2IlInjected.Address(RVA = "0xB76538", Offset = "0xB76538", VA = "0xB76538")]
	private static void CheckProjectilePressurePad_GetPossiblePlacementDirections(int i, int j, out bool canUp, out bool canLeft, out bool canRight, out bool canDown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C20")]
	[Cpp2IlInjected.Address(RVA = "0xAFDEF0", Offset = "0xAFDEF0", VA = "0xAFDEF0")]
	public static bool IsTreeType(int tree)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C21")]
	[Cpp2IlInjected.Address(RVA = "0xB76E90", Offset = "0xB76E90", VA = "0xB76E90")]
	public static int CanPlaceProjectilePressurePad(int x, int y, int type = 442, int style = 0, int direction = 0, int alternate = 0)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C22")]
	[Cpp2IlInjected.Address(RVA = "0xB754A8", Offset = "0xB754A8", VA = "0xB754A8")]
	private static void CheckDoorOpen(int i, int j, Tile tileCache)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C23")]
	[Cpp2IlInjected.Address(RVA = "0xB750D4", Offset = "0xB750D4", VA = "0xB750D4")]
	private static void CheckDoorClosed(int i, int j, Tile tileCache, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C24")]
	[Cpp2IlInjected.Address(RVA = "0xB76448", Offset = "0xB76448", VA = "0xB76448")]
	private static void GetSandfallProjData(int type, out int projType, out int dmg)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C25")]
	[Cpp2IlInjected.Address(RVA = "0xAFDF8C", Offset = "0xAFDF8C", VA = "0xAFDF8C")]
	public static bool BlockBelowMakesSandConvertIntoHardenedSand(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C26")]
	[Cpp2IlInjected.Address(RVA = "0xB76094", Offset = "0xB76094", VA = "0xB76094")]
	public static bool BlockBelowMakesSandFall(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C27")]
	[Cpp2IlInjected.Address(RVA = "0xB7628C", Offset = "0xB7628C", VA = "0xB7628C")]
	public static bool AllowsSandfall(Tile tileTopCache)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C28")]
	[Cpp2IlInjected.Address(RVA = "0xB76FC4", Offset = "0xB76FC4", VA = "0xB76FC4")]
	public static void TriggerLunarApocalypse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C29")]
	[Cpp2IlInjected.Address(RVA = "0xB3278C", Offset = "0xB3278C", VA = "0xB3278C")]
	public static void UpdateLunarApocalypse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C2A")]
	[Cpp2IlInjected.Address(RVA = "0xB77C10", Offset = "0xB77C10", VA = "0xB77C10")]
	public static void StartImpendingDoom(int countdownTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C2B")]
	[Cpp2IlInjected.Address(RVA = "0xB77F8C", Offset = "0xB77F8C", VA = "0xB77F8C")]
	public static void GetRidOfCultists()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C2C")]
	[Cpp2IlInjected.Address(RVA = "0xB77924", Offset = "0xB77924", VA = "0xB77924")]
	public static void MessageLunarApocalypse()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C2D")]
	[Cpp2IlInjected.Address(RVA = "0xB78198", Offset = "0xB78198", VA = "0xB78198")]
	public static void BroadcastText(NetworkText text, Vector4 color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C2E")]
	[Cpp2IlInjected.Address(RVA = "0xB783B8", Offset = "0xB783B8", VA = "0xB783B8")]
	public static void BroadcastText(NetworkText text, Vector3 color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C2F")]
	[Cpp2IlInjected.Address(RVA = "0xB77EDC", Offset = "0xB77EDC", VA = "0xB77EDC")]
	public static void BroadcastText(NetworkText text, int r, int g, int b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C30")]
	[Cpp2IlInjected.Address(RVA = "0xB78468", Offset = "0xB78468", VA = "0xB78468")]
	public static void BroadcastText(NetworkText text, byte r, byte g, byte b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C31")]
	[Cpp2IlInjected.Address(RVA = "0xB78250", Offset = "0xB78250", VA = "0xB78250")]
	public static void BroadcastText(NetworkText text, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002C32")]
	[Cpp2IlInjected.Address(RVA = "0xB78518", Offset = "0xB78518", VA = "0xB78518")]
	public static bool CanCutTile(int x, int y, TileCuttingContext context)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C33")]
	[Cpp2IlInjected.Address(RVA = "0xB7866C", Offset = "0xB7866C", VA = "0xB7866C")]
	public static bool InAPlaceWithWind(Vector2 position, int width, int height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C34")]
	[Cpp2IlInjected.Address(RVA = "0xB789F0", Offset = "0xB789F0", VA = "0xB789F0")]
	public static bool DoesWindBlowAtThisHeight(int tileY)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C35")]
	[Cpp2IlInjected.Address(RVA = "0xB787E8", Offset = "0xB787E8", VA = "0xB787E8")]
	public static bool InAPlaceWithWind(int x, int y, int width, int height)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C36")]
	[Cpp2IlInjected.Address(RVA = "0xB78A94", Offset = "0xB78A94", VA = "0xB78A94")]
	public static int[] CountTileTypesInWorld(params int[] oreTypes)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C37")]
	[Cpp2IlInjected.Address(RVA = "0xB78C6C", Offset = "0xB78C6C", VA = "0xB78C6C")]
	public WorldGen()
	{
	}
}
