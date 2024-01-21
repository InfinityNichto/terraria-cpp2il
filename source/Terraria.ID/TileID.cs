using System.Collections.Generic;
using Cpp2IlInjected;
using ReLogic.Reflection;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x200040E")]
public class TileID
{
	[Cpp2IlInjected.Token(Token = "0x2000920")]
	public static class Sets
	{
		[Cpp2IlInjected.Token(Token = "0x2000B72")]
		public static class Conversion
		{
			[Cpp2IlInjected.Token(Token = "0x40090A1")]
			public static bool[] MergesWithDirtInASpecialWay;

			[Cpp2IlInjected.Token(Token = "0x40090A2")]
			public static bool[] JungleGrass;

			[Cpp2IlInjected.Token(Token = "0x40090A3")]
			public static bool[] MushroomGrass;

			[Cpp2IlInjected.Token(Token = "0x40090A4")]
			public static bool[] Grass;

			[Cpp2IlInjected.Token(Token = "0x40090A5")]
			public static bool[] GolfGrass;

			[Cpp2IlInjected.Token(Token = "0x40090A6")]
			public static bool[] Dirt;

			[Cpp2IlInjected.Token(Token = "0x40090A7")]
			public static bool[] Snow;

			[Cpp2IlInjected.Token(Token = "0x40090A8")]
			public static bool[] Stone;

			[Cpp2IlInjected.Token(Token = "0x40090A9")]
			public static bool[] Ice;

			[Cpp2IlInjected.Token(Token = "0x40090AA")]
			public static bool[] Sand;

			[Cpp2IlInjected.Token(Token = "0x40090AB")]
			public static bool[] HardenedSand;

			[Cpp2IlInjected.Token(Token = "0x40090AC")]
			public static bool[] Sandstone;

			[Cpp2IlInjected.Token(Token = "0x40090AD")]
			public static bool[] Thorn;

			[Cpp2IlInjected.Token(Token = "0x40090AE")]
			public static bool[] Moss;

			[Cpp2IlInjected.Token(Token = "0x40090AF")]
			public static bool[] MossBrick;
		}

		[Cpp2IlInjected.Token(Token = "0x2000B73")]
		public static class TileCutIgnore
		{
			[Cpp2IlInjected.Token(Token = "0x40090B0")]
			public static bool[] None;

			[Cpp2IlInjected.Token(Token = "0x40090B1")]
			public static bool[] IgnoreDontHurtNature;

			[Cpp2IlInjected.Token(Token = "0x40090B2")]
			public static bool[] Regrowth;
		}

		[Cpp2IlInjected.Token(Token = "0x2000B74")]
		public static class ForAdvancedCollision
		{
			[Cpp2IlInjected.Token(Token = "0x40090B3")]
			public static bool[] ForSandshark;
		}

		[Cpp2IlInjected.Token(Token = "0x2000B75")]
		public static class RoomNeeds
		{
			[Cpp2IlInjected.Token(Token = "0x40090B4")]
			public static int[] CountsAsChair;

			[Cpp2IlInjected.Token(Token = "0x40090B5")]
			public static int[] CountsAsTable;

			[Cpp2IlInjected.Token(Token = "0x40090B6")]
			public static int[] CountsAsTorch;

			[Cpp2IlInjected.Token(Token = "0x40090B7")]
			public static int[] CountsAsDoor;
		}

		[Cpp2IlInjected.Token(Token = "0x4008A37")]
		public static SetFactory Factory;

		[Cpp2IlInjected.Token(Token = "0x4008A38")]
		public static bool[] FrameDrawModifier;

		[Cpp2IlInjected.Token(Token = "0x4008A39")]
		public static bool[] IceSkateSlippery;

		[Cpp2IlInjected.Token(Token = "0x4008A3A")]
		public static bool[] DontDrawTileSliced;

		[Cpp2IlInjected.Token(Token = "0x4008A3B")]
		public static bool[] AllowsSaveCompressionBatching;

		[Cpp2IlInjected.Token(Token = "0x4008A3C")]
		public static bool[] CountsAsGemTree;

		[Cpp2IlInjected.Token(Token = "0x4008A3D")]
		public static bool[] IsATreeTrunk;

		[Cpp2IlInjected.Token(Token = "0x4008A3E")]
		public static bool[] IsShakeable;

		[Cpp2IlInjected.Token(Token = "0x4008A3F")]
		public static bool[] GetsDestroyedForMeteors;

		[Cpp2IlInjected.Token(Token = "0x4008A40")]
		public static bool[] GetsCheckedForLeaves;

		[Cpp2IlInjected.Token(Token = "0x4008A41")]
		public static bool[] PreventsTileRemovalIfOnTopOfIt;

		[Cpp2IlInjected.Token(Token = "0x4008A42")]
		public static bool[] PreventsTileReplaceIfOnTopOfIt;

		[Cpp2IlInjected.Token(Token = "0x4008A43")]
		public static bool[] CommonSapling;

		[Cpp2IlInjected.Token(Token = "0x4008A44")]
		public static bool[] CacheSpecialDrawTree;

		[Cpp2IlInjected.Token(Token = "0x4008A45")]
		public static bool[] AllBlocksWithSmoothBordersToResolveHalfBlockIssue;

		[Cpp2IlInjected.Token(Token = "0x4008A46")]
		public static bool[] CanBeDugByShovel;

		[Cpp2IlInjected.Token(Token = "0x4008A47")]
		public static bool[] NonSolidSaveSlopes;

		[Cpp2IlInjected.Token(Token = "0x4008A48")]
		public static bool[] ResetsHalfBrickPlacementAttempt;

		[Cpp2IlInjected.Token(Token = "0x4008A49")]
		public static bool[] CrackedBricks;

		[Cpp2IlInjected.Token(Token = "0x4008A4A")]
		public static bool[] ForcedDirtMerging;

		[Cpp2IlInjected.Token(Token = "0x4008A4B")]
		public static bool[] Paintings;

		[Cpp2IlInjected.Token(Token = "0x4008A4C")]
		public static bool[] isDesertBiomeSand;

		[Cpp2IlInjected.Token(Token = "0x4008A4D")]
		public static bool[] MergesWithClouds;

		[Cpp2IlInjected.Token(Token = "0x4008A4E")]
		public static bool[] Boulders;

		[Cpp2IlInjected.Token(Token = "0x4008A4F")]
		public static bool[] Clouds;

		[Cpp2IlInjected.Token(Token = "0x4008A50")]
		public static int[] CritterCageLidStyle;

		[Cpp2IlInjected.Token(Token = "0x4008A51")]
		public static int[] SmartCursorPickaxePriorityOverride;

		[Cpp2IlInjected.Token(Token = "0x4008A52")]
		public static bool[] IgnoreSmartCursorPriorityAxe;

		[Cpp2IlInjected.Token(Token = "0x4008A53")]
		public static bool[] CanBeSatOnForNPCs;

		[Cpp2IlInjected.Token(Token = "0x4008A54")]
		public static bool[] CanBeSatOnForPlayers;

		[Cpp2IlInjected.Token(Token = "0x4008A55")]
		public static bool[] CanBeSleptIn;

		[Cpp2IlInjected.Token(Token = "0x4008A56")]
		public static bool[] IgnoresTileReplacementDropCheckWhenBeingPlaced;

		[Cpp2IlInjected.Token(Token = "0x4008A57")]
		public static bool?[] DrawTileInSolidLayer;

		[Cpp2IlInjected.Token(Token = "0x4008A58")]
		public static bool[] DoesntPlaceWithTileReplacement;

		[Cpp2IlInjected.Token(Token = "0x4008A59")]
		public static bool[] DoesntGetReplacedWithTileReplacement;

		[Cpp2IlInjected.Token(Token = "0x4008A5A")]
		public static bool[] IsVine;

		[Cpp2IlInjected.Token(Token = "0x4008A5B")]
		public static bool[] IsBeam;

		[Cpp2IlInjected.Token(Token = "0x4008A5C")]
		public static bool[] Platforms;

		[Cpp2IlInjected.Token(Token = "0x4008A5D")]
		public static bool[] ReplaceTileBreakUp;

		[Cpp2IlInjected.Token(Token = "0x4008A5E")]
		public static bool[] ReplaceTileBreakDown;

		[Cpp2IlInjected.Token(Token = "0x4008A5F")]
		public static bool[] SlowlyDiesInWater;

		[Cpp2IlInjected.Token(Token = "0x4008A60")]
		public static bool[] DrawsWalls;

		[Cpp2IlInjected.Token(Token = "0x4008A61")]
		public static ushort[] GemsparkFramingTypes;

		[Cpp2IlInjected.Token(Token = "0x4008A62")]
		public static bool[] TeamTiles;

		[Cpp2IlInjected.Token(Token = "0x4008A63")]
		public static int[] ConveyorDirection;

		[Cpp2IlInjected.Token(Token = "0x4008A64")]
		public static bool[] VineThreads;

		[Cpp2IlInjected.Token(Token = "0x4008A65")]
		public static bool[] ReverseVineThreads;

		[Cpp2IlInjected.Token(Token = "0x4008A66")]
		public static bool[] HasSlopeFrames;

		[Cpp2IlInjected.Token(Token = "0x4008A67")]
		public static bool[] TileInteractRead;

		[Cpp2IlInjected.Token(Token = "0x4008A68")]
		public static bool[] IgnoresNearbyHalfbricksWhenDrawn;

		[Cpp2IlInjected.Token(Token = "0x4008A69")]
		public static bool[] SwaysInWindBasic;

		[Cpp2IlInjected.Token(Token = "0x4008A6A")]
		public static int[] DrawFlipMode;

		[Cpp2IlInjected.Token(Token = "0x4008A6B")]
		public static bool[] CollectSpecials;

		[Cpp2IlInjected.Token(Token = "0x4008A6C")]
		public static bool[] HasOutlines;

		[Cpp2IlInjected.Token(Token = "0x4008A6D")]
		public static bool[] AllTiles;

		[Cpp2IlInjected.Token(Token = "0x4008A6E")]
		public static bool[] Dirt;

		[Cpp2IlInjected.Token(Token = "0x4008A6F")]
		public static bool[] Mud;

		[Cpp2IlInjected.Token(Token = "0x4008A70")]
		public static bool[] Ash;

		[Cpp2IlInjected.Token(Token = "0x4008A71")]
		public static bool[] Snow;

		[Cpp2IlInjected.Token(Token = "0x4008A72")]
		public static bool[] Ices;

		[Cpp2IlInjected.Token(Token = "0x4008A73")]
		public static bool[] IcesSlush;

		[Cpp2IlInjected.Token(Token = "0x4008A74")]
		public static bool[] IcesSnow;

		[Cpp2IlInjected.Token(Token = "0x4008A75")]
		public static bool[] GrassSpecial;

		[Cpp2IlInjected.Token(Token = "0x4008A76")]
		public static bool[] JungleSpecial;

		[Cpp2IlInjected.Token(Token = "0x4008A77")]
		public static bool[] HellSpecial;

		[Cpp2IlInjected.Token(Token = "0x4008A78")]
		public static bool[] Leaves;

		[Cpp2IlInjected.Token(Token = "0x4008A79")]
		public static bool[] tileMossBrick;

		[Cpp2IlInjected.Token(Token = "0x4008A7A")]
		public static bool[] GeneralPlacementTiles;

		[Cpp2IlInjected.Token(Token = "0x4008A7B")]
		public static bool[] BasicChest;

		[Cpp2IlInjected.Token(Token = "0x4008A7C")]
		public static bool[] BasicChestFake;

		[Cpp2IlInjected.Token(Token = "0x4008A7D")]
		public static bool[] BasicDresser;

		[Cpp2IlInjected.Token(Token = "0x4008A7E")]
		public static bool[] CanBeClearedDuringGeneration;

		[Cpp2IlInjected.Token(Token = "0x4008A7F")]
		public static List<int> CorruptCountCollection;

		[Cpp2IlInjected.Token(Token = "0x4008A80")]
		public static bool[] CorruptBiomeSight;

		[Cpp2IlInjected.Token(Token = "0x4008A81")]
		public static bool[] Corrupt;

		[Cpp2IlInjected.Token(Token = "0x4008A82")]
		public static List<int> HallowCountCollection;

		[Cpp2IlInjected.Token(Token = "0x4008A83")]
		public static bool[] HallowBiomeSight;

		[Cpp2IlInjected.Token(Token = "0x4008A84")]
		public static bool[] Hallow;

		[Cpp2IlInjected.Token(Token = "0x4008A85")]
		public static bool[] CanGrowCrystalShards;

		[Cpp2IlInjected.Token(Token = "0x4008A86")]
		public static List<int> CrimsonCountCollection;

		[Cpp2IlInjected.Token(Token = "0x4008A87")]
		public static bool[] CrimsonBiomeSight;

		[Cpp2IlInjected.Token(Token = "0x4008A88")]
		public static bool[] Crimson;

		[Cpp2IlInjected.Token(Token = "0x4008A89")]
		public static bool[] IsSkippedForNPCSpawningGroundTypeCheck;

		[Cpp2IlInjected.Token(Token = "0x4008A8A")]
		public static bool[] BlocksStairs;

		[Cpp2IlInjected.Token(Token = "0x4008A8B")]
		public static bool[] BlocksStairsAbove;

		[Cpp2IlInjected.Token(Token = "0x4008A8C")]
		public static bool[] NotReallySolid;

		[Cpp2IlInjected.Token(Token = "0x4008A8D")]
		public static bool[] BlocksWaterDrawingBehindSelf;

		[Cpp2IlInjected.Token(Token = "0x4008A8E")]
		public static bool[] AllowLightInWater;

		[Cpp2IlInjected.Token(Token = "0x4008A8F")]
		public static bool[] NeedsGrassFraming;

		[Cpp2IlInjected.Token(Token = "0x4008A90")]
		public static int[] NeedsGrassFramingDirt;

		[Cpp2IlInjected.Token(Token = "0x4008A91")]
		public static bool[] ChecksForMerge;

		[Cpp2IlInjected.Token(Token = "0x4008A92")]
		public static bool[] FramesOnKillWall;

		[Cpp2IlInjected.Token(Token = "0x4008A93")]
		public static bool[] AvoidedByNPCs;

		[Cpp2IlInjected.Token(Token = "0x4008A94")]
		public static bool[] InteractibleByNPCs;

		[Cpp2IlInjected.Token(Token = "0x4008A95")]
		public static bool[] HousingWalls;

		[Cpp2IlInjected.Token(Token = "0x4008A96")]
		public static bool[] BreakableWhenPlacing;

		[Cpp2IlInjected.Token(Token = "0x4008A97")]
		public static bool[] TouchDamageDestroyTile;

		[Cpp2IlInjected.Token(Token = "0x4008A98")]
		public static bool[] Suffocate;

		[Cpp2IlInjected.Token(Token = "0x4008A99")]
		public static bool[] TouchDamageHot;

		[Cpp2IlInjected.Token(Token = "0x4008A9A")]
		public static bool[] TouchDamageBleeding;

		[Cpp2IlInjected.Token(Token = "0x4008A9B")]
		public static int[] TouchDamageImmediate;

		[Cpp2IlInjected.Token(Token = "0x4008A9C")]
		public static bool[] Falling;

		[Cpp2IlInjected.Token(Token = "0x4008A9D")]
		public static bool[] BlockMergesWithMergeAllBlock;

		[Cpp2IlInjected.Token(Token = "0x4008A9E")]
		public static bool[] OreMergesWithMud;

		[Cpp2IlInjected.Token(Token = "0x4008A9F")]
		public static bool[] Ore;

		[Cpp2IlInjected.Token(Token = "0x4008AA0")]
		public static bool[] IsAContainer;

		[Cpp2IlInjected.Token(Token = "0x4008AA1")]
		public static bool[] IsAMechanism;

		[Cpp2IlInjected.Token(Token = "0x4008AA2")]
		public static bool[] IsATrigger;

		[Cpp2IlInjected.Token(Token = "0x4008AA3")]
		public static bool[] FriendlyFairyCanLureTo;

		[Cpp2IlInjected.Token(Token = "0x4008AA4")]
		public static bool[] IgnoredInHouseScore;

		[Cpp2IlInjected.Token(Token = "0x4008AA5")]
		public static bool[] SpreadOverground;

		[Cpp2IlInjected.Token(Token = "0x4008AA6")]
		public static bool[] SpreadUnderground;
	}

	[Cpp2IlInjected.Token(Token = "0x4005CAC")]
	public const ushort Dirt = 0;

	[Cpp2IlInjected.Token(Token = "0x4005CAD")]
	public const ushort Stone = 1;

	[Cpp2IlInjected.Token(Token = "0x4005CAE")]
	public const ushort Grass = 2;

	[Cpp2IlInjected.Token(Token = "0x4005CAF")]
	public const ushort Plants = 3;

	[Cpp2IlInjected.Token(Token = "0x4005CB0")]
	public const ushort Torches = 4;

	[Cpp2IlInjected.Token(Token = "0x4005CB1")]
	public const ushort Trees = 5;

	[Cpp2IlInjected.Token(Token = "0x4005CB2")]
	public const ushort Iron = 6;

	[Cpp2IlInjected.Token(Token = "0x4005CB3")]
	public const ushort Copper = 7;

	[Cpp2IlInjected.Token(Token = "0x4005CB4")]
	public const ushort Gold = 8;

	[Cpp2IlInjected.Token(Token = "0x4005CB5")]
	public const ushort Silver = 9;

	[Cpp2IlInjected.Token(Token = "0x4005CB6")]
	public const ushort ClosedDoor = 10;

	[Cpp2IlInjected.Token(Token = "0x4005CB7")]
	public const ushort OpenDoor = 11;

	[Cpp2IlInjected.Token(Token = "0x4005CB8")]
	public const ushort Heart = 12;

	[Cpp2IlInjected.Token(Token = "0x4005CB9")]
	public const ushort Bottles = 13;

	[Cpp2IlInjected.Token(Token = "0x4005CBA")]
	public const ushort Tables = 14;

	[Cpp2IlInjected.Token(Token = "0x4005CBB")]
	public const ushort Chairs = 15;

	[Cpp2IlInjected.Token(Token = "0x4005CBC")]
	public const ushort Anvils = 16;

	[Cpp2IlInjected.Token(Token = "0x4005CBD")]
	public const ushort Furnaces = 17;

	[Cpp2IlInjected.Token(Token = "0x4005CBE")]
	public const ushort WorkBenches = 18;

	[Cpp2IlInjected.Token(Token = "0x4005CBF")]
	public const ushort Platforms = 19;

	[Cpp2IlInjected.Token(Token = "0x4005CC0")]
	public const ushort Saplings = 20;

	[Cpp2IlInjected.Token(Token = "0x4005CC1")]
	public const ushort Containers = 21;

	[Cpp2IlInjected.Token(Token = "0x4005CC2")]
	public const ushort Demonite = 22;

	[Cpp2IlInjected.Token(Token = "0x4005CC3")]
	public const ushort CorruptGrass = 23;

	[Cpp2IlInjected.Token(Token = "0x4005CC4")]
	public const ushort CorruptPlants = 24;

	[Cpp2IlInjected.Token(Token = "0x4005CC5")]
	public const ushort Ebonstone = 25;

	[Cpp2IlInjected.Token(Token = "0x4005CC6")]
	public const ushort DemonAltar = 26;

	[Cpp2IlInjected.Token(Token = "0x4005CC7")]
	public const ushort Sunflower = 27;

	[Cpp2IlInjected.Token(Token = "0x4005CC8")]
	public const ushort Pots = 28;

	[Cpp2IlInjected.Token(Token = "0x4005CC9")]
	public const ushort PiggyBank = 29;

	[Cpp2IlInjected.Token(Token = "0x4005CCA")]
	public const ushort WoodBlock = 30;

	[Cpp2IlInjected.Token(Token = "0x4005CCB")]
	public const ushort ShadowOrbs = 31;

	[Cpp2IlInjected.Token(Token = "0x4005CCC")]
	public const ushort CorruptThorns = 32;

	[Cpp2IlInjected.Token(Token = "0x4005CCD")]
	public const ushort Candles = 33;

	[Cpp2IlInjected.Token(Token = "0x4005CCE")]
	public const ushort Chandeliers = 34;

	[Cpp2IlInjected.Token(Token = "0x4005CCF")]
	public const ushort Jackolanterns = 35;

	[Cpp2IlInjected.Token(Token = "0x4005CD0")]
	public const ushort Presents = 36;

	[Cpp2IlInjected.Token(Token = "0x4005CD1")]
	public const ushort Meteorite = 37;

	[Cpp2IlInjected.Token(Token = "0x4005CD2")]
	public const ushort GrayBrick = 38;

	[Cpp2IlInjected.Token(Token = "0x4005CD3")]
	public const ushort RedBrick = 39;

	[Cpp2IlInjected.Token(Token = "0x4005CD4")]
	public const ushort ClayBlock = 40;

	[Cpp2IlInjected.Token(Token = "0x4005CD5")]
	public const ushort BlueDungeonBrick = 41;

	[Cpp2IlInjected.Token(Token = "0x4005CD6")]
	public const ushort HangingLanterns = 42;

	[Cpp2IlInjected.Token(Token = "0x4005CD7")]
	public const ushort GreenDungeonBrick = 43;

	[Cpp2IlInjected.Token(Token = "0x4005CD8")]
	public const ushort PinkDungeonBrick = 44;

	[Cpp2IlInjected.Token(Token = "0x4005CD9")]
	public const ushort GoldBrick = 45;

	[Cpp2IlInjected.Token(Token = "0x4005CDA")]
	public const ushort SilverBrick = 46;

	[Cpp2IlInjected.Token(Token = "0x4005CDB")]
	public const ushort CopperBrick = 47;

	[Cpp2IlInjected.Token(Token = "0x4005CDC")]
	public const ushort Spikes = 48;

	[Cpp2IlInjected.Token(Token = "0x4005CDD")]
	public const ushort WaterCandle = 49;

	[Cpp2IlInjected.Token(Token = "0x4005CDE")]
	public const ushort Books = 50;

	[Cpp2IlInjected.Token(Token = "0x4005CDF")]
	public const ushort Cobweb = 51;

	[Cpp2IlInjected.Token(Token = "0x4005CE0")]
	public const ushort Vines = 52;

	[Cpp2IlInjected.Token(Token = "0x4005CE1")]
	public const ushort Sand = 53;

	[Cpp2IlInjected.Token(Token = "0x4005CE2")]
	public const ushort Glass = 54;

	[Cpp2IlInjected.Token(Token = "0x4005CE3")]
	public const ushort Signs = 55;

	[Cpp2IlInjected.Token(Token = "0x4005CE4")]
	public const ushort Obsidian = 56;

	[Cpp2IlInjected.Token(Token = "0x4005CE5")]
	public const ushort Ash = 57;

	[Cpp2IlInjected.Token(Token = "0x4005CE6")]
	public const ushort Hellstone = 58;

	[Cpp2IlInjected.Token(Token = "0x4005CE7")]
	public const ushort Mud = 59;

	[Cpp2IlInjected.Token(Token = "0x4005CE8")]
	public const ushort JungleGrass = 60;

	[Cpp2IlInjected.Token(Token = "0x4005CE9")]
	public const ushort JunglePlants = 61;

	[Cpp2IlInjected.Token(Token = "0x4005CEA")]
	public const ushort JungleVines = 62;

	[Cpp2IlInjected.Token(Token = "0x4005CEB")]
	public const ushort Sapphire = 63;

	[Cpp2IlInjected.Token(Token = "0x4005CEC")]
	public const ushort Ruby = 64;

	[Cpp2IlInjected.Token(Token = "0x4005CED")]
	public const ushort Emerald = 65;

	[Cpp2IlInjected.Token(Token = "0x4005CEE")]
	public const ushort Topaz = 66;

	[Cpp2IlInjected.Token(Token = "0x4005CEF")]
	public const ushort Amethyst = 67;

	[Cpp2IlInjected.Token(Token = "0x4005CF0")]
	public const ushort Diamond = 68;

	[Cpp2IlInjected.Token(Token = "0x4005CF1")]
	public const ushort JungleThorns = 69;

	[Cpp2IlInjected.Token(Token = "0x4005CF2")]
	public const ushort MushroomGrass = 70;

	[Cpp2IlInjected.Token(Token = "0x4005CF3")]
	public const ushort MushroomPlants = 71;

	[Cpp2IlInjected.Token(Token = "0x4005CF4")]
	public const ushort MushroomTrees = 72;

	[Cpp2IlInjected.Token(Token = "0x4005CF5")]
	public const ushort Plants2 = 73;

	[Cpp2IlInjected.Token(Token = "0x4005CF6")]
	public const ushort JunglePlants2 = 74;

	[Cpp2IlInjected.Token(Token = "0x4005CF7")]
	public const ushort ObsidianBrick = 75;

	[Cpp2IlInjected.Token(Token = "0x4005CF8")]
	public const ushort HellstoneBrick = 76;

	[Cpp2IlInjected.Token(Token = "0x4005CF9")]
	public const ushort Hellforge = 77;

	[Cpp2IlInjected.Token(Token = "0x4005CFA")]
	public const ushort ClayPot = 78;

	[Cpp2IlInjected.Token(Token = "0x4005CFB")]
	public const ushort Beds = 79;

	[Cpp2IlInjected.Token(Token = "0x4005CFC")]
	public const ushort Cactus = 80;

	[Cpp2IlInjected.Token(Token = "0x4005CFD")]
	public const ushort Coral = 81;

	[Cpp2IlInjected.Token(Token = "0x4005CFE")]
	public const ushort ImmatureHerbs = 82;

	[Cpp2IlInjected.Token(Token = "0x4005CFF")]
	public const ushort MatureHerbs = 83;

	[Cpp2IlInjected.Token(Token = "0x4005D00")]
	public const ushort BloomingHerbs = 84;

	[Cpp2IlInjected.Token(Token = "0x4005D01")]
	public const ushort Tombstones = 85;

	[Cpp2IlInjected.Token(Token = "0x4005D02")]
	public const ushort Loom = 86;

	[Cpp2IlInjected.Token(Token = "0x4005D03")]
	public const ushort Pianos = 87;

	[Cpp2IlInjected.Token(Token = "0x4005D04")]
	public const ushort Dressers = 88;

	[Cpp2IlInjected.Token(Token = "0x4005D05")]
	public const ushort Benches = 89;

	[Cpp2IlInjected.Token(Token = "0x4005D06")]
	public const ushort Bathtubs = 90;

	[Cpp2IlInjected.Token(Token = "0x4005D07")]
	public const ushort Banners = 91;

	[Cpp2IlInjected.Token(Token = "0x4005D08")]
	public const ushort Lampposts = 92;

	[Cpp2IlInjected.Token(Token = "0x4005D09")]
	public const ushort Lamps = 93;

	[Cpp2IlInjected.Token(Token = "0x4005D0A")]
	public const ushort Kegs = 94;

	[Cpp2IlInjected.Token(Token = "0x4005D0B")]
	public const ushort ChineseLanterns = 95;

	[Cpp2IlInjected.Token(Token = "0x4005D0C")]
	public const ushort CookingPots = 96;

	[Cpp2IlInjected.Token(Token = "0x4005D0D")]
	public const ushort Safes = 97;

	[Cpp2IlInjected.Token(Token = "0x4005D0E")]
	public const ushort SkullLanterns = 98;

	[Cpp2IlInjected.Token(Token = "0x4005D0F")]
	public const ushort TrashCan = 99;

	[Cpp2IlInjected.Token(Token = "0x4005D10")]
	public const ushort Candelabras = 100;

	[Cpp2IlInjected.Token(Token = "0x4005D11")]
	public const ushort Bookcases = 101;

	[Cpp2IlInjected.Token(Token = "0x4005D12")]
	public const ushort Thrones = 102;

	[Cpp2IlInjected.Token(Token = "0x4005D13")]
	public const ushort Bowls = 103;

	[Cpp2IlInjected.Token(Token = "0x4005D14")]
	public const ushort GrandfatherClocks = 104;

	[Cpp2IlInjected.Token(Token = "0x4005D15")]
	public const ushort Statues = 105;

	[Cpp2IlInjected.Token(Token = "0x4005D16")]
	public const ushort Sawmill = 106;

	[Cpp2IlInjected.Token(Token = "0x4005D17")]
	public const ushort Cobalt = 107;

	[Cpp2IlInjected.Token(Token = "0x4005D18")]
	public const ushort Mythril = 108;

	[Cpp2IlInjected.Token(Token = "0x4005D19")]
	public const ushort HallowedGrass = 109;

	[Cpp2IlInjected.Token(Token = "0x4005D1A")]
	public const ushort HallowedPlants = 110;

	[Cpp2IlInjected.Token(Token = "0x4005D1B")]
	public const ushort Adamantite = 111;

	[Cpp2IlInjected.Token(Token = "0x4005D1C")]
	public const ushort Ebonsand = 112;

	[Cpp2IlInjected.Token(Token = "0x4005D1D")]
	public const ushort HallowedPlants2 = 113;

	[Cpp2IlInjected.Token(Token = "0x4005D1E")]
	public const ushort TinkerersWorkbench = 114;

	[Cpp2IlInjected.Token(Token = "0x4005D1F")]
	public const ushort HallowedVines = 115;

	[Cpp2IlInjected.Token(Token = "0x4005D20")]
	public const ushort Pearlsand = 116;

	[Cpp2IlInjected.Token(Token = "0x4005D21")]
	public const ushort Pearlstone = 117;

	[Cpp2IlInjected.Token(Token = "0x4005D22")]
	public const ushort PearlstoneBrick = 118;

	[Cpp2IlInjected.Token(Token = "0x4005D23")]
	public const ushort IridescentBrick = 119;

	[Cpp2IlInjected.Token(Token = "0x4005D24")]
	public const ushort Mudstone = 120;

	[Cpp2IlInjected.Token(Token = "0x4005D25")]
	public const ushort CobaltBrick = 121;

	[Cpp2IlInjected.Token(Token = "0x4005D26")]
	public const ushort MythrilBrick = 122;

	[Cpp2IlInjected.Token(Token = "0x4005D27")]
	public const ushort Silt = 123;

	[Cpp2IlInjected.Token(Token = "0x4005D28")]
	public const ushort WoodenBeam = 124;

	[Cpp2IlInjected.Token(Token = "0x4005D29")]
	public const ushort CrystalBall = 125;

	[Cpp2IlInjected.Token(Token = "0x4005D2A")]
	public const ushort DiscoBall = 126;

	[Cpp2IlInjected.Token(Token = "0x4005D2B")]
	public const ushort MagicalIceBlock = 127;

	[Cpp2IlInjected.Token(Token = "0x4005D2C")]
	public const ushort Mannequin = 128;

	[Cpp2IlInjected.Token(Token = "0x4005D2D")]
	public const ushort Crystals = 129;

	[Cpp2IlInjected.Token(Token = "0x4005D2E")]
	public const ushort ActiveStoneBlock = 130;

	[Cpp2IlInjected.Token(Token = "0x4005D2F")]
	public const ushort InactiveStoneBlock = 131;

	[Cpp2IlInjected.Token(Token = "0x4005D30")]
	public const ushort Lever = 132;

	[Cpp2IlInjected.Token(Token = "0x4005D31")]
	public const ushort AdamantiteForge = 133;

	[Cpp2IlInjected.Token(Token = "0x4005D32")]
	public const ushort MythrilAnvil = 134;

	[Cpp2IlInjected.Token(Token = "0x4005D33")]
	public const ushort PressurePlates = 135;

	[Cpp2IlInjected.Token(Token = "0x4005D34")]
	public const ushort Switches = 136;

	[Cpp2IlInjected.Token(Token = "0x4005D35")]
	public const ushort Traps = 137;

	[Cpp2IlInjected.Token(Token = "0x4005D36")]
	public const ushort Boulder = 138;

	[Cpp2IlInjected.Token(Token = "0x4005D37")]
	public const ushort MusicBoxes = 139;

	[Cpp2IlInjected.Token(Token = "0x4005D38")]
	public const ushort DemoniteBrick = 140;

	[Cpp2IlInjected.Token(Token = "0x4005D39")]
	public const ushort Explosives = 141;

	[Cpp2IlInjected.Token(Token = "0x4005D3A")]
	public const ushort InletPump = 142;

	[Cpp2IlInjected.Token(Token = "0x4005D3B")]
	public const ushort OutletPump = 143;

	[Cpp2IlInjected.Token(Token = "0x4005D3C")]
	public const ushort Timers = 144;

	[Cpp2IlInjected.Token(Token = "0x4005D3D")]
	public const ushort CandyCaneBlock = 145;

	[Cpp2IlInjected.Token(Token = "0x4005D3E")]
	public const ushort GreenCandyCaneBlock = 146;

	[Cpp2IlInjected.Token(Token = "0x4005D3F")]
	public const ushort SnowBlock = 147;

	[Cpp2IlInjected.Token(Token = "0x4005D40")]
	public const ushort SnowBrick = 148;

	[Cpp2IlInjected.Token(Token = "0x4005D41")]
	public const ushort HolidayLights = 149;

	[Cpp2IlInjected.Token(Token = "0x4005D42")]
	public const ushort AdamantiteBeam = 150;

	[Cpp2IlInjected.Token(Token = "0x4005D43")]
	public const ushort SandstoneBrick = 151;

	[Cpp2IlInjected.Token(Token = "0x4005D44")]
	public const ushort EbonstoneBrick = 152;

	[Cpp2IlInjected.Token(Token = "0x4005D45")]
	public const ushort RedStucco = 153;

	[Cpp2IlInjected.Token(Token = "0x4005D46")]
	public const ushort YellowStucco = 154;

	[Cpp2IlInjected.Token(Token = "0x4005D47")]
	public const ushort GreenStucco = 155;

	[Cpp2IlInjected.Token(Token = "0x4005D48")]
	public const ushort GrayStucco = 156;

	[Cpp2IlInjected.Token(Token = "0x4005D49")]
	public const ushort Ebonwood = 157;

	[Cpp2IlInjected.Token(Token = "0x4005D4A")]
	public const ushort RichMahogany = 158;

	[Cpp2IlInjected.Token(Token = "0x4005D4B")]
	public const ushort Pearlwood = 159;

	[Cpp2IlInjected.Token(Token = "0x4005D4C")]
	public const ushort RainbowBrick = 160;

	[Cpp2IlInjected.Token(Token = "0x4005D4D")]
	public const ushort IceBlock = 161;

	[Cpp2IlInjected.Token(Token = "0x4005D4E")]
	public const ushort BreakableIce = 162;

	[Cpp2IlInjected.Token(Token = "0x4005D4F")]
	public const ushort CorruptIce = 163;

	[Cpp2IlInjected.Token(Token = "0x4005D50")]
	public const ushort HallowedIce = 164;

	[Cpp2IlInjected.Token(Token = "0x4005D51")]
	public const ushort Stalactite = 165;

	[Cpp2IlInjected.Token(Token = "0x4005D52")]
	public const ushort Tin = 166;

	[Cpp2IlInjected.Token(Token = "0x4005D53")]
	public const ushort Lead = 167;

	[Cpp2IlInjected.Token(Token = "0x4005D54")]
	public const ushort Tungsten = 168;

	[Cpp2IlInjected.Token(Token = "0x4005D55")]
	public const ushort Platinum = 169;

	[Cpp2IlInjected.Token(Token = "0x4005D56")]
	public const ushort PineTree = 170;

	[Cpp2IlInjected.Token(Token = "0x4005D57")]
	public const ushort ChristmasTree = 171;

	[Cpp2IlInjected.Token(Token = "0x4005D58")]
	public const ushort Sinks = 172;

	[Cpp2IlInjected.Token(Token = "0x4005D59")]
	public const ushort PlatinumCandelabra = 173;

	[Cpp2IlInjected.Token(Token = "0x4005D5A")]
	public const ushort PlatinumCandle = 174;

	[Cpp2IlInjected.Token(Token = "0x4005D5B")]
	public const ushort TinBrick = 175;

	[Cpp2IlInjected.Token(Token = "0x4005D5C")]
	public const ushort TungstenBrick = 176;

	[Cpp2IlInjected.Token(Token = "0x4005D5D")]
	public const ushort PlatinumBrick = 177;

	[Cpp2IlInjected.Token(Token = "0x4005D5E")]
	public const ushort ExposedGems = 178;

	[Cpp2IlInjected.Token(Token = "0x4005D5F")]
	public const ushort GreenMoss = 179;

	[Cpp2IlInjected.Token(Token = "0x4005D60")]
	public const ushort BrownMoss = 180;

	[Cpp2IlInjected.Token(Token = "0x4005D61")]
	public const ushort RedMoss = 181;

	[Cpp2IlInjected.Token(Token = "0x4005D62")]
	public const ushort BlueMoss = 182;

	[Cpp2IlInjected.Token(Token = "0x4005D63")]
	public const ushort PurpleMoss = 183;

	[Cpp2IlInjected.Token(Token = "0x4005D64")]
	public const ushort LongMoss = 184;

	[Cpp2IlInjected.Token(Token = "0x4005D65")]
	public const ushort SmallPiles = 185;

	[Cpp2IlInjected.Token(Token = "0x4005D66")]
	public const ushort LargePiles = 186;

	[Cpp2IlInjected.Token(Token = "0x4005D67")]
	public const ushort LargePiles2 = 187;

	[Cpp2IlInjected.Token(Token = "0x4005D68")]
	public const ushort CactusBlock = 188;

	[Cpp2IlInjected.Token(Token = "0x4005D69")]
	public const ushort Cloud = 189;

	[Cpp2IlInjected.Token(Token = "0x4005D6A")]
	public const ushort MushroomBlock = 190;

	[Cpp2IlInjected.Token(Token = "0x4005D6B")]
	public const ushort LivingWood = 191;

	[Cpp2IlInjected.Token(Token = "0x4005D6C")]
	public const ushort LeafBlock = 192;

	[Cpp2IlInjected.Token(Token = "0x4005D6D")]
	public const ushort SlimeBlock = 193;

	[Cpp2IlInjected.Token(Token = "0x4005D6E")]
	public const ushort BoneBlock = 194;

	[Cpp2IlInjected.Token(Token = "0x4005D6F")]
	public const ushort FleshBlock = 195;

	[Cpp2IlInjected.Token(Token = "0x4005D70")]
	public const ushort RainCloud = 196;

	[Cpp2IlInjected.Token(Token = "0x4005D71")]
	public const ushort FrozenSlimeBlock = 197;

	[Cpp2IlInjected.Token(Token = "0x4005D72")]
	public const ushort Asphalt = 198;

	[Cpp2IlInjected.Token(Token = "0x4005D73")]
	public const ushort CrimsonGrass = 199;

	[Cpp2IlInjected.Token(Token = "0x4005D74")]
	public const ushort FleshIce = 200;

	[Cpp2IlInjected.Token(Token = "0x4005D75")]
	public const ushort CrimsonPlants = 201;

	[Cpp2IlInjected.Token(Token = "0x4005D76")]
	public const ushort Sunplate = 202;

	[Cpp2IlInjected.Token(Token = "0x4005D77")]
	public const ushort Crimstone = 203;

	[Cpp2IlInjected.Token(Token = "0x4005D78")]
	public const ushort Crimtane = 204;

	[Cpp2IlInjected.Token(Token = "0x4005D79")]
	public const ushort CrimsonVines = 205;

	[Cpp2IlInjected.Token(Token = "0x4005D7A")]
	public const ushort IceBrick = 206;

	[Cpp2IlInjected.Token(Token = "0x4005D7B")]
	public const ushort WaterFountain = 207;

	[Cpp2IlInjected.Token(Token = "0x4005D7C")]
	public const ushort Shadewood = 208;

	[Cpp2IlInjected.Token(Token = "0x4005D7D")]
	public const ushort Cannon = 209;

	[Cpp2IlInjected.Token(Token = "0x4005D7E")]
	public const ushort LandMine = 210;

	[Cpp2IlInjected.Token(Token = "0x4005D7F")]
	public const ushort Chlorophyte = 211;

	[Cpp2IlInjected.Token(Token = "0x4005D80")]
	public const ushort SnowballLauncher = 212;

	[Cpp2IlInjected.Token(Token = "0x4005D81")]
	public const ushort Rope = 213;

	[Cpp2IlInjected.Token(Token = "0x4005D82")]
	public const ushort Chain = 214;

	[Cpp2IlInjected.Token(Token = "0x4005D83")]
	public const ushort Campfire = 215;

	[Cpp2IlInjected.Token(Token = "0x4005D84")]
	public const ushort Firework = 216;

	[Cpp2IlInjected.Token(Token = "0x4005D85")]
	public const ushort Blendomatic = 217;

	[Cpp2IlInjected.Token(Token = "0x4005D86")]
	public const ushort MeatGrinder = 218;

	[Cpp2IlInjected.Token(Token = "0x4005D87")]
	public const ushort Extractinator = 219;

	[Cpp2IlInjected.Token(Token = "0x4005D88")]
	public const ushort Solidifier = 220;

	[Cpp2IlInjected.Token(Token = "0x4005D89")]
	public const ushort Palladium = 221;

	[Cpp2IlInjected.Token(Token = "0x4005D8A")]
	public const ushort Orichalcum = 222;

	[Cpp2IlInjected.Token(Token = "0x4005D8B")]
	public const ushort Titanium = 223;

	[Cpp2IlInjected.Token(Token = "0x4005D8C")]
	public const ushort Slush = 224;

	[Cpp2IlInjected.Token(Token = "0x4005D8D")]
	public const ushort Hive = 225;

	[Cpp2IlInjected.Token(Token = "0x4005D8E")]
	public const ushort LihzahrdBrick = 226;

	[Cpp2IlInjected.Token(Token = "0x4005D8F")]
	public const ushort DyePlants = 227;

	[Cpp2IlInjected.Token(Token = "0x4005D90")]
	public const ushort DyeVat = 228;

	[Cpp2IlInjected.Token(Token = "0x4005D91")]
	public const ushort HoneyBlock = 229;

	[Cpp2IlInjected.Token(Token = "0x4005D92")]
	public const ushort CrispyHoneyBlock = 230;

	[Cpp2IlInjected.Token(Token = "0x4005D93")]
	public const ushort Larva = 231;

	[Cpp2IlInjected.Token(Token = "0x4005D94")]
	public const ushort WoodenSpikes = 232;

	[Cpp2IlInjected.Token(Token = "0x4005D95")]
	public const ushort PlantDetritus = 233;

	[Cpp2IlInjected.Token(Token = "0x4005D96")]
	public const ushort Crimsand = 234;

	[Cpp2IlInjected.Token(Token = "0x4005D97")]
	public const ushort Teleporter = 235;

	[Cpp2IlInjected.Token(Token = "0x4005D98")]
	public const ushort LifeFruit = 236;

	[Cpp2IlInjected.Token(Token = "0x4005D99")]
	public const ushort LihzahrdAltar = 237;

	[Cpp2IlInjected.Token(Token = "0x4005D9A")]
	public const ushort PlanteraBulb = 238;

	[Cpp2IlInjected.Token(Token = "0x4005D9B")]
	public const ushort MetalBars = 239;

	[Cpp2IlInjected.Token(Token = "0x4005D9C")]
	public const ushort Painting3X3 = 240;

	[Cpp2IlInjected.Token(Token = "0x4005D9D")]
	public const ushort Painting4X3 = 241;

	[Cpp2IlInjected.Token(Token = "0x4005D9E")]
	public const ushort Painting6X4 = 242;

	[Cpp2IlInjected.Token(Token = "0x4005D9F")]
	public const ushort ImbuingStation = 243;

	[Cpp2IlInjected.Token(Token = "0x4005DA0")]
	public const ushort BubbleMachine = 244;

	[Cpp2IlInjected.Token(Token = "0x4005DA1")]
	public const ushort Painting2X3 = 245;

	[Cpp2IlInjected.Token(Token = "0x4005DA2")]
	public const ushort Painting3X2 = 246;

	[Cpp2IlInjected.Token(Token = "0x4005DA3")]
	public const ushort Autohammer = 247;

	[Cpp2IlInjected.Token(Token = "0x4005DA4")]
	public const ushort PalladiumColumn = 248;

	[Cpp2IlInjected.Token(Token = "0x4005DA5")]
	public const ushort BubblegumBlock = 249;

	[Cpp2IlInjected.Token(Token = "0x4005DA6")]
	public const ushort Titanstone = 250;

	[Cpp2IlInjected.Token(Token = "0x4005DA7")]
	public const ushort PumpkinBlock = 251;

	[Cpp2IlInjected.Token(Token = "0x4005DA8")]
	public const ushort HayBlock = 252;

	[Cpp2IlInjected.Token(Token = "0x4005DA9")]
	public const ushort SpookyWood = 253;

	[Cpp2IlInjected.Token(Token = "0x4005DAA")]
	public const ushort Pumpkins = 254;

	[Cpp2IlInjected.Token(Token = "0x4005DAB")]
	public const ushort AmethystGemsparkOff = 255;

	[Cpp2IlInjected.Token(Token = "0x4005DAC")]
	public const ushort TopazGemsparkOff = 256;

	[Cpp2IlInjected.Token(Token = "0x4005DAD")]
	public const ushort SapphireGemsparkOff = 257;

	[Cpp2IlInjected.Token(Token = "0x4005DAE")]
	public const ushort EmeraldGemsparkOff = 258;

	[Cpp2IlInjected.Token(Token = "0x4005DAF")]
	public const ushort RubyGemsparkOff = 259;

	[Cpp2IlInjected.Token(Token = "0x4005DB0")]
	public const ushort DiamondGemsparkOff = 260;

	[Cpp2IlInjected.Token(Token = "0x4005DB1")]
	public const ushort AmberGemsparkOff = 261;

	[Cpp2IlInjected.Token(Token = "0x4005DB2")]
	public const ushort AmethystGemspark = 262;

	[Cpp2IlInjected.Token(Token = "0x4005DB3")]
	public const ushort TopazGemspark = 263;

	[Cpp2IlInjected.Token(Token = "0x4005DB4")]
	public const ushort SapphireGemspark = 264;

	[Cpp2IlInjected.Token(Token = "0x4005DB5")]
	public const ushort EmeraldGemspark = 265;

	[Cpp2IlInjected.Token(Token = "0x4005DB6")]
	public const ushort RubyGemspark = 266;

	[Cpp2IlInjected.Token(Token = "0x4005DB7")]
	public const ushort DiamondGemspark = 267;

	[Cpp2IlInjected.Token(Token = "0x4005DB8")]
	public const ushort AmberGemspark = 268;

	[Cpp2IlInjected.Token(Token = "0x4005DB9")]
	public const ushort Womannequin = 269;

	[Cpp2IlInjected.Token(Token = "0x4005DBA")]
	public const ushort FireflyinaBottle = 270;

	[Cpp2IlInjected.Token(Token = "0x4005DBB")]
	public const ushort LightningBuginaBottle = 271;

	[Cpp2IlInjected.Token(Token = "0x4005DBC")]
	public const ushort Cog = 272;

	[Cpp2IlInjected.Token(Token = "0x4005DBD")]
	public const ushort StoneSlab = 273;

	[Cpp2IlInjected.Token(Token = "0x4005DBE")]
	public const ushort SandStoneSlab = 274;

	[Cpp2IlInjected.Token(Token = "0x4005DBF")]
	public const ushort BunnyCage = 275;

	[Cpp2IlInjected.Token(Token = "0x4005DC0")]
	public const ushort SquirrelCage = 276;

	[Cpp2IlInjected.Token(Token = "0x4005DC1")]
	public const ushort MallardDuckCage = 277;

	[Cpp2IlInjected.Token(Token = "0x4005DC2")]
	public const ushort DuckCage = 278;

	[Cpp2IlInjected.Token(Token = "0x4005DC3")]
	public const ushort BirdCage = 279;

	[Cpp2IlInjected.Token(Token = "0x4005DC4")]
	public const ushort BlueJay = 280;

	[Cpp2IlInjected.Token(Token = "0x4005DC5")]
	public const ushort CardinalCage = 281;

	[Cpp2IlInjected.Token(Token = "0x4005DC6")]
	public const ushort FishBowl = 282;

	[Cpp2IlInjected.Token(Token = "0x4005DC7")]
	public const ushort HeavyWorkBench = 283;

	[Cpp2IlInjected.Token(Token = "0x4005DC8")]
	public const ushort CopperPlating = 284;

	[Cpp2IlInjected.Token(Token = "0x4005DC9")]
	public const ushort SnailCage = 285;

	[Cpp2IlInjected.Token(Token = "0x4005DCA")]
	public const ushort GlowingSnailCage = 286;

	[Cpp2IlInjected.Token(Token = "0x4005DCB")]
	public const ushort AmmoBox = 287;

	[Cpp2IlInjected.Token(Token = "0x4005DCC")]
	public const ushort MonarchButterflyJar = 288;

	[Cpp2IlInjected.Token(Token = "0x4005DCD")]
	public const ushort PurpleEmperorButterflyJar = 289;

	[Cpp2IlInjected.Token(Token = "0x4005DCE")]
	public const ushort RedAdmiralButterflyJar = 290;

	[Cpp2IlInjected.Token(Token = "0x4005DCF")]
	public const ushort UlyssesButterflyJar = 291;

	[Cpp2IlInjected.Token(Token = "0x4005DD0")]
	public const ushort SulphurButterflyJar = 292;

	[Cpp2IlInjected.Token(Token = "0x4005DD1")]
	public const ushort TreeNymphButterflyJar = 293;

	[Cpp2IlInjected.Token(Token = "0x4005DD2")]
	public const ushort ZebraSwallowtailButterflyJar = 294;

	[Cpp2IlInjected.Token(Token = "0x4005DD3")]
	public const ushort JuliaButterflyJar = 295;

	[Cpp2IlInjected.Token(Token = "0x4005DD4")]
	public const ushort ScorpionCage = 296;

	[Cpp2IlInjected.Token(Token = "0x4005DD5")]
	public const ushort BlackScorpionCage = 297;

	[Cpp2IlInjected.Token(Token = "0x4005DD6")]
	public const ushort FrogCage = 298;

	[Cpp2IlInjected.Token(Token = "0x4005DD7")]
	public const ushort MouseCage = 299;

	[Cpp2IlInjected.Token(Token = "0x4005DD8")]
	public const ushort BoneWelder = 300;

	[Cpp2IlInjected.Token(Token = "0x4005DD9")]
	public const ushort FleshCloningVat = 301;

	[Cpp2IlInjected.Token(Token = "0x4005DDA")]
	public const ushort GlassKiln = 302;

	[Cpp2IlInjected.Token(Token = "0x4005DDB")]
	public const ushort LihzahrdFurnace = 303;

	[Cpp2IlInjected.Token(Token = "0x4005DDC")]
	public const ushort LivingLoom = 304;

	[Cpp2IlInjected.Token(Token = "0x4005DDD")]
	public const ushort SkyMill = 305;

	[Cpp2IlInjected.Token(Token = "0x4005DDE")]
	public const ushort IceMachine = 306;

	[Cpp2IlInjected.Token(Token = "0x4005DDF")]
	public const ushort SteampunkBoiler = 307;

	[Cpp2IlInjected.Token(Token = "0x4005DE0")]
	public const ushort HoneyDispenser = 308;

	[Cpp2IlInjected.Token(Token = "0x4005DE1")]
	public const ushort PenguinCage = 309;

	[Cpp2IlInjected.Token(Token = "0x4005DE2")]
	public const ushort WormCage = 310;

	[Cpp2IlInjected.Token(Token = "0x4005DE3")]
	public const ushort DynastyWood = 311;

	[Cpp2IlInjected.Token(Token = "0x4005DE4")]
	public const ushort RedDynastyShingles = 312;

	[Cpp2IlInjected.Token(Token = "0x4005DE5")]
	public const ushort BlueDynastyShingles = 313;

	[Cpp2IlInjected.Token(Token = "0x4005DE6")]
	public const ushort MinecartTrack = 314;

	[Cpp2IlInjected.Token(Token = "0x4005DE7")]
	public const ushort Coralstone = 315;

	[Cpp2IlInjected.Token(Token = "0x4005DE8")]
	public const ushort BlueJellyfishBowl = 316;

	[Cpp2IlInjected.Token(Token = "0x4005DE9")]
	public const ushort GreenJellyfishBowl = 317;

	[Cpp2IlInjected.Token(Token = "0x4005DEA")]
	public const ushort PinkJellyfishBowl = 318;

	[Cpp2IlInjected.Token(Token = "0x4005DEB")]
	public const ushort ShipInABottle = 319;

	[Cpp2IlInjected.Token(Token = "0x4005DEC")]
	public const ushort SeaweedPlanter = 320;

	[Cpp2IlInjected.Token(Token = "0x4005DED")]
	public const ushort BorealWood = 321;

	[Cpp2IlInjected.Token(Token = "0x4005DEE")]
	public const ushort PalmWood = 322;

	[Cpp2IlInjected.Token(Token = "0x4005DEF")]
	public const ushort PalmTree = 323;

	[Cpp2IlInjected.Token(Token = "0x4005DF0")]
	public const ushort BeachPiles = 324;

	[Cpp2IlInjected.Token(Token = "0x4005DF1")]
	public const ushort TinPlating = 325;

	[Cpp2IlInjected.Token(Token = "0x4005DF2")]
	public const ushort Waterfall = 326;

	[Cpp2IlInjected.Token(Token = "0x4005DF3")]
	public const ushort Lavafall = 327;

	[Cpp2IlInjected.Token(Token = "0x4005DF4")]
	public const ushort Confetti = 328;

	[Cpp2IlInjected.Token(Token = "0x4005DF5")]
	public const ushort ConfettiBlack = 329;

	[Cpp2IlInjected.Token(Token = "0x4005DF6")]
	public const ushort CopperCoinPile = 330;

	[Cpp2IlInjected.Token(Token = "0x4005DF7")]
	public const ushort SilverCoinPile = 331;

	[Cpp2IlInjected.Token(Token = "0x4005DF8")]
	public const ushort GoldCoinPile = 332;

	[Cpp2IlInjected.Token(Token = "0x4005DF9")]
	public const ushort PlatinumCoinPile = 333;

	[Cpp2IlInjected.Token(Token = "0x4005DFA")]
	public const ushort WeaponsRack = 334;

	[Cpp2IlInjected.Token(Token = "0x4005DFB")]
	public const ushort FireworksBox = 335;

	[Cpp2IlInjected.Token(Token = "0x4005DFC")]
	public const ushort LivingFire = 336;

	[Cpp2IlInjected.Token(Token = "0x4005DFD")]
	public const ushort AlphabetStatues = 337;

	[Cpp2IlInjected.Token(Token = "0x4005DFE")]
	public const ushort FireworkFountain = 338;

	[Cpp2IlInjected.Token(Token = "0x4005DFF")]
	public const ushort GrasshopperCage = 339;

	[Cpp2IlInjected.Token(Token = "0x4005E00")]
	public const ushort LivingCursedFire = 340;

	[Cpp2IlInjected.Token(Token = "0x4005E01")]
	public const ushort LivingDemonFire = 341;

	[Cpp2IlInjected.Token(Token = "0x4005E02")]
	public const ushort LivingFrostFire = 342;

	[Cpp2IlInjected.Token(Token = "0x4005E03")]
	public const ushort LivingIchor = 343;

	[Cpp2IlInjected.Token(Token = "0x4005E04")]
	public const ushort LivingUltrabrightFire = 344;

	[Cpp2IlInjected.Token(Token = "0x4005E05")]
	public const ushort Honeyfall = 345;

	[Cpp2IlInjected.Token(Token = "0x4005E06")]
	public const ushort ChlorophyteBrick = 346;

	[Cpp2IlInjected.Token(Token = "0x4005E07")]
	public const ushort CrimtaneBrick = 347;

	[Cpp2IlInjected.Token(Token = "0x4005E08")]
	public const ushort ShroomitePlating = 348;

	[Cpp2IlInjected.Token(Token = "0x4005E09")]
	public const ushort MushroomStatue = 349;

	[Cpp2IlInjected.Token(Token = "0x4005E0A")]
	public const ushort MartianConduitPlating = 350;

	[Cpp2IlInjected.Token(Token = "0x4005E0B")]
	public const ushort ChimneySmoke = 351;

	[Cpp2IlInjected.Token(Token = "0x4005E0C")]
	public const ushort CrimsonThorns = 352;

	[Cpp2IlInjected.Token(Token = "0x4005E0D")]
	public const ushort VineRope = 353;

	[Cpp2IlInjected.Token(Token = "0x4005E0E")]
	public const ushort BewitchingTable = 354;

	[Cpp2IlInjected.Token(Token = "0x4005E0F")]
	public const ushort AlchemyTable = 355;

	[Cpp2IlInjected.Token(Token = "0x4005E10")]
	public const ushort Sundial = 356;

	[Cpp2IlInjected.Token(Token = "0x4005E11")]
	public const ushort MarbleBlock = 357;

	[Cpp2IlInjected.Token(Token = "0x4005E12")]
	public const ushort GoldBirdCage = 358;

	[Cpp2IlInjected.Token(Token = "0x4005E13")]
	public const ushort GoldBunnyCage = 359;

	[Cpp2IlInjected.Token(Token = "0x4005E14")]
	public const ushort GoldButterflyCage = 360;

	[Cpp2IlInjected.Token(Token = "0x4005E15")]
	public const ushort GoldFrogCage = 361;

	[Cpp2IlInjected.Token(Token = "0x4005E16")]
	public const ushort GoldGrasshopperCage = 362;

	[Cpp2IlInjected.Token(Token = "0x4005E17")]
	public const ushort GoldMouseCage = 363;

	[Cpp2IlInjected.Token(Token = "0x4005E18")]
	public const ushort GoldWormCage = 364;

	[Cpp2IlInjected.Token(Token = "0x4005E19")]
	public const ushort SilkRope = 365;

	[Cpp2IlInjected.Token(Token = "0x4005E1A")]
	public const ushort WebRope = 366;

	[Cpp2IlInjected.Token(Token = "0x4005E1B")]
	public const ushort Marble = 367;

	[Cpp2IlInjected.Token(Token = "0x4005E1C")]
	public const ushort Granite = 368;

	[Cpp2IlInjected.Token(Token = "0x4005E1D")]
	public const ushort GraniteBlock = 369;

	[Cpp2IlInjected.Token(Token = "0x4005E1E")]
	public const ushort MeteoriteBrick = 370;

	[Cpp2IlInjected.Token(Token = "0x4005E1F")]
	public const ushort PinkSlimeBlock = 371;

	[Cpp2IlInjected.Token(Token = "0x4005E20")]
	public const ushort PeaceCandle = 372;

	[Cpp2IlInjected.Token(Token = "0x4005E21")]
	public const ushort WaterDrip = 373;

	[Cpp2IlInjected.Token(Token = "0x4005E22")]
	public const ushort LavaDrip = 374;

	[Cpp2IlInjected.Token(Token = "0x4005E23")]
	public const ushort HoneyDrip = 375;

	[Cpp2IlInjected.Token(Token = "0x4005E24")]
	public const ushort FishingCrate = 376;

	[Cpp2IlInjected.Token(Token = "0x4005E25")]
	public const ushort SharpeningStation = 377;

	[Cpp2IlInjected.Token(Token = "0x4005E26")]
	public const ushort TargetDummy = 378;

	[Cpp2IlInjected.Token(Token = "0x4005E27")]
	public const ushort Bubble = 379;

	[Cpp2IlInjected.Token(Token = "0x4005E28")]
	public const ushort PlanterBox = 380;

	[Cpp2IlInjected.Token(Token = "0x4005E29")]
	public const ushort LavaMoss = 381;

	[Cpp2IlInjected.Token(Token = "0x4005E2A")]
	public const ushort VineFlowers = 382;

	[Cpp2IlInjected.Token(Token = "0x4005E2B")]
	public const ushort LivingMahogany = 383;

	[Cpp2IlInjected.Token(Token = "0x4005E2C")]
	public const ushort LivingMahoganyLeaves = 384;

	[Cpp2IlInjected.Token(Token = "0x4005E2D")]
	public const ushort CrystalBlock = 385;

	[Cpp2IlInjected.Token(Token = "0x4005E2E")]
	public const ushort TrapdoorOpen = 386;

	[Cpp2IlInjected.Token(Token = "0x4005E2F")]
	public const ushort TrapdoorClosed = 387;

	[Cpp2IlInjected.Token(Token = "0x4005E30")]
	public const ushort TallGateClosed = 388;

	[Cpp2IlInjected.Token(Token = "0x4005E31")]
	public const ushort TallGateOpen = 389;

	[Cpp2IlInjected.Token(Token = "0x4005E32")]
	public const ushort LavaLamp = 390;

	[Cpp2IlInjected.Token(Token = "0x4005E33")]
	public const ushort CageEnchantedNightcrawler = 391;

	[Cpp2IlInjected.Token(Token = "0x4005E34")]
	public const ushort CageBuggy = 392;

	[Cpp2IlInjected.Token(Token = "0x4005E35")]
	public const ushort CageGrubby = 393;

	[Cpp2IlInjected.Token(Token = "0x4005E36")]
	public const ushort CageSluggy = 394;

	[Cpp2IlInjected.Token(Token = "0x4005E37")]
	public const ushort ItemFrame = 395;

	[Cpp2IlInjected.Token(Token = "0x4005E38")]
	public const ushort Sandstone = 396;

	[Cpp2IlInjected.Token(Token = "0x4005E39")]
	public const ushort HardenedSand = 397;

	[Cpp2IlInjected.Token(Token = "0x4005E3A")]
	public const ushort CorruptHardenedSand = 398;

	[Cpp2IlInjected.Token(Token = "0x4005E3B")]
	public const ushort CrimsonHardenedSand = 399;

	[Cpp2IlInjected.Token(Token = "0x4005E3C")]
	public const ushort CorruptSandstone = 400;

	[Cpp2IlInjected.Token(Token = "0x4005E3D")]
	public const ushort CrimsonSandstone = 401;

	[Cpp2IlInjected.Token(Token = "0x4005E3E")]
	public const ushort HallowHardenedSand = 402;

	[Cpp2IlInjected.Token(Token = "0x4005E3F")]
	public const ushort HallowSandstone = 403;

	[Cpp2IlInjected.Token(Token = "0x4005E40")]
	public const ushort DesertFossil = 404;

	[Cpp2IlInjected.Token(Token = "0x4005E41")]
	public const ushort Fireplace = 405;

	[Cpp2IlInjected.Token(Token = "0x4005E42")]
	public const ushort Chimney = 406;

	[Cpp2IlInjected.Token(Token = "0x4005E43")]
	public const ushort FossilOre = 407;

	[Cpp2IlInjected.Token(Token = "0x4005E44")]
	public const ushort LunarOre = 408;

	[Cpp2IlInjected.Token(Token = "0x4005E45")]
	public const ushort LunarBrick = 409;

	[Cpp2IlInjected.Token(Token = "0x4005E46")]
	public const ushort LunarMonolith = 410;

	[Cpp2IlInjected.Token(Token = "0x4005E47")]
	public const ushort Detonator = 411;

	[Cpp2IlInjected.Token(Token = "0x4005E48")]
	public const ushort LunarCraftingStation = 412;

	[Cpp2IlInjected.Token(Token = "0x4005E49")]
	public const ushort SquirrelOrangeCage = 413;

	[Cpp2IlInjected.Token(Token = "0x4005E4A")]
	public const ushort SquirrelGoldCage = 414;

	[Cpp2IlInjected.Token(Token = "0x4005E4B")]
	public const ushort LunarBlockSolar = 415;

	[Cpp2IlInjected.Token(Token = "0x4005E4C")]
	public const ushort LunarBlockVortex = 416;

	[Cpp2IlInjected.Token(Token = "0x4005E4D")]
	public const ushort LunarBlockNebula = 417;

	[Cpp2IlInjected.Token(Token = "0x4005E4E")]
	public const ushort LunarBlockStardust = 418;

	[Cpp2IlInjected.Token(Token = "0x4005E4F")]
	public const ushort LogicGateLamp = 419;

	[Cpp2IlInjected.Token(Token = "0x4005E50")]
	public const ushort LogicGate = 420;

	[Cpp2IlInjected.Token(Token = "0x4005E51")]
	public const ushort ConveyorBeltLeft = 421;

	[Cpp2IlInjected.Token(Token = "0x4005E52")]
	public const ushort ConveyorBeltRight = 422;

	[Cpp2IlInjected.Token(Token = "0x4005E53")]
	public const ushort LogicSensor = 423;

	[Cpp2IlInjected.Token(Token = "0x4005E54")]
	public const ushort WirePipe = 424;

	[Cpp2IlInjected.Token(Token = "0x4005E55")]
	public const ushort AnnouncementBox = 425;

	[Cpp2IlInjected.Token(Token = "0x4005E56")]
	public const ushort TeamBlockRed = 426;

	[Cpp2IlInjected.Token(Token = "0x4005E57")]
	public const ushort TeamBlockRedPlatform = 427;

	[Cpp2IlInjected.Token(Token = "0x4005E58")]
	public const ushort WeightedPressurePlate = 428;

	[Cpp2IlInjected.Token(Token = "0x4005E59")]
	public const ushort WireBulb = 429;

	[Cpp2IlInjected.Token(Token = "0x4005E5A")]
	public const ushort TeamBlockGreen = 430;

	[Cpp2IlInjected.Token(Token = "0x4005E5B")]
	public const ushort TeamBlockBlue = 431;

	[Cpp2IlInjected.Token(Token = "0x4005E5C")]
	public const ushort TeamBlockYellow = 432;

	[Cpp2IlInjected.Token(Token = "0x4005E5D")]
	public const ushort TeamBlockPink = 433;

	[Cpp2IlInjected.Token(Token = "0x4005E5E")]
	public const ushort TeamBlockWhite = 434;

	[Cpp2IlInjected.Token(Token = "0x4005E5F")]
	public const ushort TeamBlockGreenPlatform = 435;

	[Cpp2IlInjected.Token(Token = "0x4005E60")]
	public const ushort TeamBlockBluePlatform = 436;

	[Cpp2IlInjected.Token(Token = "0x4005E61")]
	public const ushort TeamBlockYellowPlatform = 437;

	[Cpp2IlInjected.Token(Token = "0x4005E62")]
	public const ushort TeamBlockPinkPlatform = 438;

	[Cpp2IlInjected.Token(Token = "0x4005E63")]
	public const ushort TeamBlockWhitePlatform = 439;

	[Cpp2IlInjected.Token(Token = "0x4005E64")]
	public const ushort GemLocks = 440;

	[Cpp2IlInjected.Token(Token = "0x4005E65")]
	public const ushort FakeContainers = 441;

	[Cpp2IlInjected.Token(Token = "0x4005E66")]
	public const ushort ProjectilePressurePad = 442;

	[Cpp2IlInjected.Token(Token = "0x4005E67")]
	public const ushort GeyserTrap = 443;

	[Cpp2IlInjected.Token(Token = "0x4005E68")]
	public const ushort BeeHive = 444;

	[Cpp2IlInjected.Token(Token = "0x4005E69")]
	public const ushort PixelBox = 445;

	[Cpp2IlInjected.Token(Token = "0x4005E6A")]
	public const ushort SillyBalloonPink = 446;

	[Cpp2IlInjected.Token(Token = "0x4005E6B")]
	public const ushort SillyBalloonPurple = 447;

	[Cpp2IlInjected.Token(Token = "0x4005E6C")]
	public const ushort SillyBalloonGreen = 448;

	[Cpp2IlInjected.Token(Token = "0x4005E6D")]
	public const ushort SillyStreamerBlue = 449;

	[Cpp2IlInjected.Token(Token = "0x4005E6E")]
	public const ushort SillyStreamerGreen = 450;

	[Cpp2IlInjected.Token(Token = "0x4005E6F")]
	public const ushort SillyStreamerPink = 451;

	[Cpp2IlInjected.Token(Token = "0x4005E70")]
	public const ushort SillyBalloonMachine = 452;

	[Cpp2IlInjected.Token(Token = "0x4005E71")]
	public const ushort SillyBalloonTile = 453;

	[Cpp2IlInjected.Token(Token = "0x4005E72")]
	public const ushort Pigronata = 454;

	[Cpp2IlInjected.Token(Token = "0x4005E73")]
	public const ushort PartyMonolith = 455;

	[Cpp2IlInjected.Token(Token = "0x4005E74")]
	public const ushort PartyBundleOfBalloonTile = 456;

	[Cpp2IlInjected.Token(Token = "0x4005E75")]
	public const ushort PartyPresent = 457;

	[Cpp2IlInjected.Token(Token = "0x4005E76")]
	public const ushort SandFallBlock = 458;

	[Cpp2IlInjected.Token(Token = "0x4005E77")]
	public const ushort SnowFallBlock = 459;

	[Cpp2IlInjected.Token(Token = "0x4005E78")]
	public const ushort SnowCloud = 460;

	[Cpp2IlInjected.Token(Token = "0x4005E79")]
	public const ushort SandDrip = 461;

	[Cpp2IlInjected.Token(Token = "0x4005E7A")]
	public const ushort DjinnLamp = 462;

	[Cpp2IlInjected.Token(Token = "0x4005E7B")]
	public const ushort DefendersForge = 463;

	[Cpp2IlInjected.Token(Token = "0x4005E7C")]
	public const ushort WarTable = 464;

	[Cpp2IlInjected.Token(Token = "0x4005E7D")]
	public const ushort WarTableBanner = 465;

	[Cpp2IlInjected.Token(Token = "0x4005E7E")]
	public const ushort ElderCrystalStand = 466;

	[Cpp2IlInjected.Token(Token = "0x4005E7F")]
	public const ushort Containers2 = 467;

	[Cpp2IlInjected.Token(Token = "0x4005E80")]
	public const ushort FakeContainers2 = 468;

	[Cpp2IlInjected.Token(Token = "0x4005E81")]
	public const ushort Tables2 = 469;

	[Cpp2IlInjected.Token(Token = "0x4005E82")]
	public const ushort DisplayDoll = 470;

	[Cpp2IlInjected.Token(Token = "0x4005E83")]
	public const ushort WeaponsRack2 = 471;

	[Cpp2IlInjected.Token(Token = "0x4005E84")]
	public const ushort IronBrick = 472;

	[Cpp2IlInjected.Token(Token = "0x4005E85")]
	public const ushort LeadBrick = 473;

	[Cpp2IlInjected.Token(Token = "0x4005E86")]
	public const ushort LesionBlock = 474;

	[Cpp2IlInjected.Token(Token = "0x4005E87")]
	public const ushort HatRack = 475;

	[Cpp2IlInjected.Token(Token = "0x4005E88")]
	public const ushort GolfHole = 476;

	[Cpp2IlInjected.Token(Token = "0x4005E89")]
	public const ushort GolfGrass = 477;

	[Cpp2IlInjected.Token(Token = "0x4005E8A")]
	public const ushort CrimstoneBrick = 478;

	[Cpp2IlInjected.Token(Token = "0x4005E8B")]
	public const ushort SmoothSandstone = 479;

	[Cpp2IlInjected.Token(Token = "0x4005E8C")]
	public const ushort BloodMoonMonolith = 480;

	[Cpp2IlInjected.Token(Token = "0x4005E8D")]
	public const ushort CrackedBlueDungeonBrick = 481;

	[Cpp2IlInjected.Token(Token = "0x4005E8E")]
	public const ushort CrackedGreenDungeonBrick = 482;

	[Cpp2IlInjected.Token(Token = "0x4005E8F")]
	public const ushort CrackedPinkDungeonBrick = 483;

	[Cpp2IlInjected.Token(Token = "0x4005E90")]
	public const ushort RollingCactus = 484;

	[Cpp2IlInjected.Token(Token = "0x4005E91")]
	public const ushort AntlionLarva = 485;

	[Cpp2IlInjected.Token(Token = "0x4005E92")]
	public const ushort DrumSet = 486;

	[Cpp2IlInjected.Token(Token = "0x4005E93")]
	public const ushort PicnicTable = 487;

	[Cpp2IlInjected.Token(Token = "0x4005E94")]
	public const ushort FallenLog = 488;

	[Cpp2IlInjected.Token(Token = "0x4005E95")]
	public const ushort PinWheel = 489;

	[Cpp2IlInjected.Token(Token = "0x4005E96")]
	public const ushort WeatherVane = 490;

	[Cpp2IlInjected.Token(Token = "0x4005E97")]
	public const ushort VoidVault = 491;

	[Cpp2IlInjected.Token(Token = "0x4005E98")]
	public const ushort GolfGrassHallowed = 492;

	[Cpp2IlInjected.Token(Token = "0x4005E99")]
	public const ushort GolfCupFlag = 493;

	[Cpp2IlInjected.Token(Token = "0x4005E9A")]
	public const ushort GolfTee = 494;

	[Cpp2IlInjected.Token(Token = "0x4005E9B")]
	public const ushort ShellPile = 495;

	[Cpp2IlInjected.Token(Token = "0x4005E9C")]
	public const ushort AntiPortalBlock = 496;

	[Cpp2IlInjected.Token(Token = "0x4005E9D")]
	public const ushort Toilets = 497;

	[Cpp2IlInjected.Token(Token = "0x4005E9E")]
	public const ushort Spider = 498;

	[Cpp2IlInjected.Token(Token = "0x4005E9F")]
	public const ushort LesionStation = 499;

	[Cpp2IlInjected.Token(Token = "0x4005EA0")]
	public const ushort SolarBrick = 500;

	[Cpp2IlInjected.Token(Token = "0x4005EA1")]
	public const ushort VortexBrick = 501;

	[Cpp2IlInjected.Token(Token = "0x4005EA2")]
	public const ushort NebulaBrick = 502;

	[Cpp2IlInjected.Token(Token = "0x4005EA3")]
	public const ushort StardustBrick = 503;

	[Cpp2IlInjected.Token(Token = "0x4005EA4")]
	public const ushort MysticSnakeRope = 504;

	[Cpp2IlInjected.Token(Token = "0x4005EA5")]
	public const ushort GoldGoldfishBowl = 505;

	[Cpp2IlInjected.Token(Token = "0x4005EA6")]
	public const ushort CatBast = 506;

	[Cpp2IlInjected.Token(Token = "0x4005EA7")]
	public const ushort GoldStarryGlassBlock = 507;

	[Cpp2IlInjected.Token(Token = "0x4005EA8")]
	public const ushort BlueStarryGlassBlock = 508;

	[Cpp2IlInjected.Token(Token = "0x4005EA9")]
	public const ushort VoidMonolith = 509;

	[Cpp2IlInjected.Token(Token = "0x4005EAA")]
	public const ushort ArrowSign = 510;

	[Cpp2IlInjected.Token(Token = "0x4005EAB")]
	public const ushort PaintedArrowSign = 511;

	[Cpp2IlInjected.Token(Token = "0x4005EAC")]
	public const ushort GreenMossBrick = 512;

	[Cpp2IlInjected.Token(Token = "0x4005EAD")]
	public const ushort BrownMossBrick = 513;

	[Cpp2IlInjected.Token(Token = "0x4005EAE")]
	public const ushort RedMossBrick = 514;

	[Cpp2IlInjected.Token(Token = "0x4005EAF")]
	public const ushort BlueMossBrick = 515;

	[Cpp2IlInjected.Token(Token = "0x4005EB0")]
	public const ushort PurpleMossBrick = 516;

	[Cpp2IlInjected.Token(Token = "0x4005EB1")]
	public const ushort LavaMossBrick = 517;

	[Cpp2IlInjected.Token(Token = "0x4005EB2")]
	public const ushort LilyPad = 518;

	[Cpp2IlInjected.Token(Token = "0x4005EB3")]
	public const ushort Cattail = 519;

	[Cpp2IlInjected.Token(Token = "0x4005EB4")]
	public const ushort FoodPlatter = 520;

	[Cpp2IlInjected.Token(Token = "0x4005EB5")]
	public const ushort BlackDragonflyJar = 521;

	[Cpp2IlInjected.Token(Token = "0x4005EB6")]
	public const ushort BlueDragonflyJar = 522;

	[Cpp2IlInjected.Token(Token = "0x4005EB7")]
	public const ushort GreenDragonflyJar = 523;

	[Cpp2IlInjected.Token(Token = "0x4005EB8")]
	public const ushort OrangeDragonflyJar = 524;

	[Cpp2IlInjected.Token(Token = "0x4005EB9")]
	public const ushort RedDragonflyJar = 525;

	[Cpp2IlInjected.Token(Token = "0x4005EBA")]
	public const ushort YellowDragonflyJar = 526;

	[Cpp2IlInjected.Token(Token = "0x4005EBB")]
	public const ushort GoldDragonflyJar = 527;

	[Cpp2IlInjected.Token(Token = "0x4005EBC")]
	public const ushort MushroomVines = 528;

	[Cpp2IlInjected.Token(Token = "0x4005EBD")]
	public const ushort SeaOats = 529;

	[Cpp2IlInjected.Token(Token = "0x4005EBE")]
	public const ushort OasisPlants = 530;

	[Cpp2IlInjected.Token(Token = "0x4005EBF")]
	public const ushort BoulderStatue = 531;

	[Cpp2IlInjected.Token(Token = "0x4005EC0")]
	public const ushort MaggotCage = 532;

	[Cpp2IlInjected.Token(Token = "0x4005EC1")]
	public const ushort RatCage = 533;

	[Cpp2IlInjected.Token(Token = "0x4005EC2")]
	public const ushort KryptonMoss = 534;

	[Cpp2IlInjected.Token(Token = "0x4005EC3")]
	public const ushort KryptonMossBrick = 535;

	[Cpp2IlInjected.Token(Token = "0x4005EC4")]
	public const ushort XenonMoss = 536;

	[Cpp2IlInjected.Token(Token = "0x4005EC5")]
	public const ushort XenonMossBrick = 537;

	[Cpp2IlInjected.Token(Token = "0x4005EC6")]
	public const ushort LadybugCage = 538;

	[Cpp2IlInjected.Token(Token = "0x4005EC7")]
	public const ushort ArgonMoss = 539;

	[Cpp2IlInjected.Token(Token = "0x4005EC8")]
	public const ushort ArgonMossBrick = 540;

	[Cpp2IlInjected.Token(Token = "0x4005EC9")]
	public const ushort EchoBlock = 541;

	[Cpp2IlInjected.Token(Token = "0x4005ECA")]
	public const ushort OwlCage = 542;

	[Cpp2IlInjected.Token(Token = "0x4005ECB")]
	public const ushort PupfishBowl = 543;

	[Cpp2IlInjected.Token(Token = "0x4005ECC")]
	public const ushort GoldLadybugCage = 544;

	[Cpp2IlInjected.Token(Token = "0x4005ECD")]
	public const ushort LawnFlamingo = 545;

	[Cpp2IlInjected.Token(Token = "0x4005ECE")]
	public const ushort Grate = 546;

	[Cpp2IlInjected.Token(Token = "0x4005ECF")]
	public const ushort PottedPlants1 = 547;

	[Cpp2IlInjected.Token(Token = "0x4005ED0")]
	public const ushort PottedPlants2 = 548;

	[Cpp2IlInjected.Token(Token = "0x4005ED1")]
	public const ushort Seaweed = 549;

	[Cpp2IlInjected.Token(Token = "0x4005ED2")]
	public const ushort TurtleCage = 550;

	[Cpp2IlInjected.Token(Token = "0x4005ED3")]
	public const ushort TurtleJungleCage = 551;

	[Cpp2IlInjected.Token(Token = "0x4005ED4")]
	public const ushort Sandcastles = 552;

	[Cpp2IlInjected.Token(Token = "0x4005ED5")]
	public const ushort GrebeCage = 553;

	[Cpp2IlInjected.Token(Token = "0x4005ED6")]
	public const ushort SeagullCage = 554;

	[Cpp2IlInjected.Token(Token = "0x4005ED7")]
	public const ushort WaterStriderCage = 555;

	[Cpp2IlInjected.Token(Token = "0x4005ED8")]
	public const ushort GoldWaterStriderCage = 556;

	[Cpp2IlInjected.Token(Token = "0x4005ED9")]
	public const ushort GrateClosed = 557;

	[Cpp2IlInjected.Token(Token = "0x4005EDA")]
	public const ushort SeahorseCage = 558;

	[Cpp2IlInjected.Token(Token = "0x4005EDB")]
	public const ushort GoldSeahorseCage = 559;

	[Cpp2IlInjected.Token(Token = "0x4005EDC")]
	public const ushort GolfTrophies = 560;

	[Cpp2IlInjected.Token(Token = "0x4005EDD")]
	public const ushort MarbleColumn = 561;

	[Cpp2IlInjected.Token(Token = "0x4005EDE")]
	public const ushort BambooBlock = 562;

	[Cpp2IlInjected.Token(Token = "0x4005EDF")]
	public const ushort LargeBambooBlock = 563;

	[Cpp2IlInjected.Token(Token = "0x4005EE0")]
	public const ushort PlasmaLamp = 564;

	[Cpp2IlInjected.Token(Token = "0x4005EE1")]
	public const ushort FogMachine = 565;

	[Cpp2IlInjected.Token(Token = "0x4005EE2")]
	public const ushort AmberStoneBlock = 566;

	[Cpp2IlInjected.Token(Token = "0x4005EE3")]
	public const ushort GardenGnome = 567;

	[Cpp2IlInjected.Token(Token = "0x4005EE4")]
	public const ushort PinkFairyJar = 568;

	[Cpp2IlInjected.Token(Token = "0x4005EE5")]
	public const ushort GreenFairyJar = 569;

	[Cpp2IlInjected.Token(Token = "0x4005EE6")]
	public const ushort BlueFairyJar = 570;

	[Cpp2IlInjected.Token(Token = "0x4005EE7")]
	public const ushort Bamboo = 571;

	[Cpp2IlInjected.Token(Token = "0x4005EE8")]
	public const ushort SoulBottles = 572;

	[Cpp2IlInjected.Token(Token = "0x4005EE9")]
	public const ushort TatteredWoodSign = 573;

	[Cpp2IlInjected.Token(Token = "0x4005EEA")]
	public const ushort BorealBeam = 574;

	[Cpp2IlInjected.Token(Token = "0x4005EEB")]
	public const ushort RichMahoganyBeam = 575;

	[Cpp2IlInjected.Token(Token = "0x4005EEC")]
	public const ushort GraniteColumn = 576;

	[Cpp2IlInjected.Token(Token = "0x4005EED")]
	public const ushort SandstoneColumn = 577;

	[Cpp2IlInjected.Token(Token = "0x4005EEE")]
	public const ushort MushroomBeam = 578;

	[Cpp2IlInjected.Token(Token = "0x4005EEF")]
	public const ushort RockGolemHead = 579;

	[Cpp2IlInjected.Token(Token = "0x4005EF0")]
	public const ushort HellButterflyJar = 580;

	[Cpp2IlInjected.Token(Token = "0x4005EF1")]
	public const ushort LavaflyinaBottle = 581;

	[Cpp2IlInjected.Token(Token = "0x4005EF2")]
	public const ushort MagmaSnailCage = 582;

	[Cpp2IlInjected.Token(Token = "0x4005EF3")]
	public const ushort TreeTopaz = 583;

	[Cpp2IlInjected.Token(Token = "0x4005EF4")]
	public const ushort TreeAmethyst = 584;

	[Cpp2IlInjected.Token(Token = "0x4005EF5")]
	public const ushort TreeSapphire = 585;

	[Cpp2IlInjected.Token(Token = "0x4005EF6")]
	public const ushort TreeEmerald = 586;

	[Cpp2IlInjected.Token(Token = "0x4005EF7")]
	public const ushort TreeRuby = 587;

	[Cpp2IlInjected.Token(Token = "0x4005EF8")]
	public const ushort TreeDiamond = 588;

	[Cpp2IlInjected.Token(Token = "0x4005EF9")]
	public const ushort TreeAmber = 589;

	[Cpp2IlInjected.Token(Token = "0x4005EFA")]
	public const ushort GemSaplings = 590;

	[Cpp2IlInjected.Token(Token = "0x4005EFB")]
	public const ushort PotsSuspended = 591;

	[Cpp2IlInjected.Token(Token = "0x4005EFC")]
	public const ushort BrazierSuspended = 592;

	[Cpp2IlInjected.Token(Token = "0x4005EFD")]
	public const ushort VolcanoSmall = 593;

	[Cpp2IlInjected.Token(Token = "0x4005EFE")]
	public const ushort VolcanoLarge = 594;

	[Cpp2IlInjected.Token(Token = "0x4005EFF")]
	public const ushort VanityTreeSakuraSaplings = 595;

	[Cpp2IlInjected.Token(Token = "0x4005F00")]
	public const ushort VanityTreeSakura = 596;

	[Cpp2IlInjected.Token(Token = "0x4005F01")]
	public const ushort TeleportationPylon = 597;

	[Cpp2IlInjected.Token(Token = "0x4005F02")]
	public const ushort LavafishBowl = 598;

	[Cpp2IlInjected.Token(Token = "0x4005F03")]
	public const ushort AmethystBunnyCage = 599;

	[Cpp2IlInjected.Token(Token = "0x4005F04")]
	public const ushort TopazBunnyCage = 600;

	[Cpp2IlInjected.Token(Token = "0x4005F05")]
	public const ushort SapphireBunnyCage = 601;

	[Cpp2IlInjected.Token(Token = "0x4005F06")]
	public const ushort EmeraldBunnyCage = 602;

	[Cpp2IlInjected.Token(Token = "0x4005F07")]
	public const ushort RubyBunnyCage = 603;

	[Cpp2IlInjected.Token(Token = "0x4005F08")]
	public const ushort DiamondBunnyCage = 604;

	[Cpp2IlInjected.Token(Token = "0x4005F09")]
	public const ushort AmberBunnyCage = 605;

	[Cpp2IlInjected.Token(Token = "0x4005F0A")]
	public const ushort AmethystSquirrelCage = 606;

	[Cpp2IlInjected.Token(Token = "0x4005F0B")]
	public const ushort TopazSquirrelCage = 607;

	[Cpp2IlInjected.Token(Token = "0x4005F0C")]
	public const ushort SapphireSquirrelCage = 608;

	[Cpp2IlInjected.Token(Token = "0x4005F0D")]
	public const ushort EmeraldSquirrelCage = 609;

	[Cpp2IlInjected.Token(Token = "0x4005F0E")]
	public const ushort RubySquirrelCage = 610;

	[Cpp2IlInjected.Token(Token = "0x4005F0F")]
	public const ushort DiamondSquirrelCage = 611;

	[Cpp2IlInjected.Token(Token = "0x4005F10")]
	public const ushort AmberSquirrelCage = 612;

	[Cpp2IlInjected.Token(Token = "0x4005F11")]
	public const ushort PottedLavaPlants = 613;

	[Cpp2IlInjected.Token(Token = "0x4005F12")]
	public const ushort PottedLavaPlantTendrils = 614;

	[Cpp2IlInjected.Token(Token = "0x4005F13")]
	public const ushort VanityTreeWillowSaplings = 615;

	[Cpp2IlInjected.Token(Token = "0x4005F14")]
	public const ushort VanityTreeYellowWillow = 616;

	[Cpp2IlInjected.Token(Token = "0x4005F15")]
	public const ushort MasterTrophyBase = 617;

	[Cpp2IlInjected.Token(Token = "0x4005F16")]
	public const ushort AccentSlab = 618;

	[Cpp2IlInjected.Token(Token = "0x4005F17")]
	public const ushort TruffleWormCage = 619;

	[Cpp2IlInjected.Token(Token = "0x4005F18")]
	public const ushort EmpressButterflyJar = 620;

	[Cpp2IlInjected.Token(Token = "0x4005F19")]
	public const ushort SliceOfCake = 621;

	[Cpp2IlInjected.Token(Token = "0x4005F1A")]
	public const ushort TeaKettle = 622;

	[Cpp2IlInjected.Token(Token = "0x4005F1B")]
	public const ushort PottedCrystalPlants = 623;

	[Cpp2IlInjected.Token(Token = "0x4005F1C")]
	public const ushort AbigailsFlower = 624;

	[Cpp2IlInjected.Token(Token = "0x4005F1D")]
	public const ushort VioletMoss = 625;

	[Cpp2IlInjected.Token(Token = "0x4005F1E")]
	public const ushort VioletMossBrick = 626;

	[Cpp2IlInjected.Token(Token = "0x4005F1F")]
	public const ushort RainbowMoss = 627;

	[Cpp2IlInjected.Token(Token = "0x4005F20")]
	public const ushort RainbowMossBrick = 628;

	[Cpp2IlInjected.Token(Token = "0x4005F21")]
	public const ushort StinkbugCage = 629;

	[Cpp2IlInjected.Token(Token = "0x4005F22")]
	public const ushort StinkbugHousingBlocker = 630;

	[Cpp2IlInjected.Token(Token = "0x4005F23")]
	public const ushort StinkbugHousingBlockerEcho = 631;

	[Cpp2IlInjected.Token(Token = "0x4005F24")]
	public const ushort ScarletMacawCage = 632;

	[Cpp2IlInjected.Token(Token = "0x4005F25")]
	public const ushort AshGrass = 633;

	[Cpp2IlInjected.Token(Token = "0x4005F26")]
	public const ushort TreeAsh = 634;

	[Cpp2IlInjected.Token(Token = "0x4005F27")]
	public const ushort AshWood = 635;

	[Cpp2IlInjected.Token(Token = "0x4005F28")]
	public const ushort CorruptVines = 636;

	[Cpp2IlInjected.Token(Token = "0x4005F29")]
	public const ushort AshPlants = 637;

	[Cpp2IlInjected.Token(Token = "0x4005F2A")]
	public const ushort AshVines = 638;

	[Cpp2IlInjected.Token(Token = "0x4005F2B")]
	public const ushort ManaCrystal = 639;

	[Cpp2IlInjected.Token(Token = "0x4005F2C")]
	public const ushort BlueMacawCage = 640;

	[Cpp2IlInjected.Token(Token = "0x4005F2D")]
	public const ushort ReefBlock = 641;

	[Cpp2IlInjected.Token(Token = "0x4005F2E")]
	public const ushort ChlorophyteExtractinator = 642;

	[Cpp2IlInjected.Token(Token = "0x4005F2F")]
	public const ushort ToucanCage = 643;

	[Cpp2IlInjected.Token(Token = "0x4005F30")]
	public const ushort YellowCockatielCage = 644;

	[Cpp2IlInjected.Token(Token = "0x4005F31")]
	public const ushort GrayCockatielCage = 645;

	[Cpp2IlInjected.Token(Token = "0x4005F32")]
	public const ushort ShadowCandle = 646;

	[Cpp2IlInjected.Token(Token = "0x4005F33")]
	public const ushort LargePilesEcho = 647;

	[Cpp2IlInjected.Token(Token = "0x4005F34")]
	public const ushort LargePiles2Echo = 648;

	[Cpp2IlInjected.Token(Token = "0x4005F35")]
	public const ushort SmallPiles2x1Echo = 649;

	[Cpp2IlInjected.Token(Token = "0x4005F36")]
	public const ushort SmallPiles1x1Echo = 650;

	[Cpp2IlInjected.Token(Token = "0x4005F37")]
	public const ushort PlantDetritus3x2Echo = 651;

	[Cpp2IlInjected.Token(Token = "0x4005F38")]
	public const ushort PlantDetritus2x2Echo = 652;

	[Cpp2IlInjected.Token(Token = "0x4005F39")]
	public const ushort PotsEcho = 653;

	[Cpp2IlInjected.Token(Token = "0x4005F3A")]
	public const ushort TNTBarrel = 654;

	[Cpp2IlInjected.Token(Token = "0x4005F3B")]
	public const ushort PlanteraThorns = 655;

	[Cpp2IlInjected.Token(Token = "0x4005F3C")]
	public const ushort GlowTulip = 656;

	[Cpp2IlInjected.Token(Token = "0x4005F3D")]
	public const ushort EchoMonolith = 657;

	[Cpp2IlInjected.Token(Token = "0x4005F3E")]
	public const ushort ShimmerMonolith = 658;

	[Cpp2IlInjected.Token(Token = "0x4005F3F")]
	public const ushort ShimmerBlock = 659;

	[Cpp2IlInjected.Token(Token = "0x4005F40")]
	public const ushort ShimmerflyinaBottle = 660;

	[Cpp2IlInjected.Token(Token = "0x4005F41")]
	public const ushort CorruptJungleGrass = 661;

	[Cpp2IlInjected.Token(Token = "0x4005F42")]
	public const ushort CrimsonJungleGrass = 662;

	[Cpp2IlInjected.Token(Token = "0x4005F43")]
	public const ushort Moondial = 663;

	[Cpp2IlInjected.Token(Token = "0x4005F44")]
	public const ushort BouncyBoulder = 664;

	[Cpp2IlInjected.Token(Token = "0x4005F45")]
	public const ushort LifeCrystalBoulder = 665;

	[Cpp2IlInjected.Token(Token = "0x4005F46")]
	public const ushort PoopBlock = 666;

	[Cpp2IlInjected.Token(Token = "0x4005F47")]
	public const ushort ShimmerBrick = 667;

	[Cpp2IlInjected.Token(Token = "0x4005F48")]
	public const ushort DirtiestBlock = 668;

	[Cpp2IlInjected.Token(Token = "0x4005F49")]
	public const ushort LunarRustBrick = 669;

	[Cpp2IlInjected.Token(Token = "0x4005F4A")]
	public const ushort DarkCelestialBrick = 670;

	[Cpp2IlInjected.Token(Token = "0x4005F4B")]
	public const ushort AstraBrick = 671;

	[Cpp2IlInjected.Token(Token = "0x4005F4C")]
	public const ushort CosmicEmberBrick = 672;

	[Cpp2IlInjected.Token(Token = "0x4005F4D")]
	public const ushort CryocoreBrick = 673;

	[Cpp2IlInjected.Token(Token = "0x4005F4E")]
	public const ushort MercuryBrick = 674;

	[Cpp2IlInjected.Token(Token = "0x4005F4F")]
	public const ushort StarRoyaleBrick = 675;

	[Cpp2IlInjected.Token(Token = "0x4005F50")]
	public const ushort HeavenforgeBrick = 676;

	[Cpp2IlInjected.Token(Token = "0x4005F51")]
	public const ushort AncientBlueBrick = 677;

	[Cpp2IlInjected.Token(Token = "0x4005F52")]
	public const ushort AncientGreenBrick = 678;

	[Cpp2IlInjected.Token(Token = "0x4005F53")]
	public const ushort AncientPinkBrick = 679;

	[Cpp2IlInjected.Token(Token = "0x4005F54")]
	public const ushort AncientGoldBrick = 680;

	[Cpp2IlInjected.Token(Token = "0x4005F55")]
	public const ushort AncientSilverBrick = 681;

	[Cpp2IlInjected.Token(Token = "0x4005F56")]
	public const ushort AncientCopperBrick = 682;

	[Cpp2IlInjected.Token(Token = "0x4005F57")]
	public const ushort AncientObsidianBrick = 683;

	[Cpp2IlInjected.Token(Token = "0x4005F58")]
	public const ushort AncientHellstoneBrick = 684;

	[Cpp2IlInjected.Token(Token = "0x4005F59")]
	public const ushort AncientCobaltBrick = 685;

	[Cpp2IlInjected.Token(Token = "0x4005F5A")]
	public const ushort AncientMythrilBrick = 686;

	[Cpp2IlInjected.Token(Token = "0x4005F5B")]
	public const ushort LavaMossBlock = 687;

	[Cpp2IlInjected.Token(Token = "0x4005F5C")]
	public const ushort ArgonMossBlock = 688;

	[Cpp2IlInjected.Token(Token = "0x4005F5D")]
	public const ushort KryptonMossBlock = 689;

	[Cpp2IlInjected.Token(Token = "0x4005F5E")]
	public const ushort XenonMossBlock = 690;

	[Cpp2IlInjected.Token(Token = "0x4005F5F")]
	public const ushort VioletMossBlock = 691;

	[Cpp2IlInjected.Token(Token = "0x4005F60")]
	public const ushort RainbowMossBlock = 692;

	[Cpp2IlInjected.Token(Token = "0x4005F61")]
	public const ushort Count = 693;

	[Cpp2IlInjected.Token(Token = "0x4005F62")]
	public static readonly IdDictionary Search;

	[Cpp2IlInjected.Token(Token = "0x60030C9")]
	[Cpp2IlInjected.Address(RVA = "0x1478908", Offset = "0x1478908", VA = "0x1478908")]
	public TileID()
	{
	}
}
