using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x20003F2")]
public class ItemID
{
	[Cpp2IlInjected.Token(Token = "0x2000915")]
	public struct BannerEffect
	{
		[Cpp2IlInjected.Token(Token = "0x4008958")]
		public static readonly BannerEffect None;

		[Cpp2IlInjected.Token(Token = "0x4008959")]
		public static readonly BannerEffect Reduced;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400895A")]
		public readonly float NormalDamageDealt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400895B")]
		public readonly float ExpertDamageDealt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400895C")]
		public readonly float NormalDamageReceived;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400895D")]
		public readonly float ExpertDamageReceived;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400895E")]
		public readonly bool Enabled;

		[Cpp2IlInjected.Token(Token = "0x6004CA9")]
		[Cpp2IlInjected.Address(RVA = "0x39EFFC", Offset = "0x39EFFC", VA = "0x39EFFC")]
		public BannerEffect(float strength = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004CAA")]
		[Cpp2IlInjected.Address(RVA = "0x39F048", Offset = "0x39F048", VA = "0x39F048")]
		public BannerEffect(float normalDamageDealt, float expertDamageDealt, float normalDamageReceived, float expertDamageReceived)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000916")]
	public class Sets
	{
		[Cpp2IlInjected.Token(Token = "0x400895F")]
		public static SetFactory Factory;

		[Cpp2IlInjected.Token(Token = "0x4008960")]
		public static List<int> ItemsThatAreProcessedAfterNormalContentSample;

		[Cpp2IlInjected.Token(Token = "0x4008961")]
		public static bool[] IsLavaImmuneRegardlessOfRarity;

		[Cpp2IlInjected.Token(Token = "0x4008962")]
		public static bool[] ItemsThatAllowRepeatedRightClick;

		[Cpp2IlInjected.Token(Token = "0x4008963")]
		public static bool[] ItemsThatCountAsBombsForDemolitionistToSpawn;

		[Cpp2IlInjected.Token(Token = "0x4008964")]
		public static bool[] ItemsThatShouldNotBeInInventory;

		[Cpp2IlInjected.Token(Token = "0x4008965")]
		public static bool[] DrawUnsafeIndicator;

		[Cpp2IlInjected.Token(Token = "0x4008966")]
		public static bool[] UsesBetterMeleeItemLocation;

		[Cpp2IlInjected.Token(Token = "0x4008967")]
		public static bool[] WorksInVoidBag;

		[Cpp2IlInjected.Token(Token = "0x4008968")]
		public static bool[] GrassSeeds;

		[Cpp2IlInjected.Token(Token = "0x4008969")]
		public static int[] ShimmerTransformToItem;

		[Cpp2IlInjected.Token(Token = "0x400896A")]
		public static int[] ShimmerCountsAsItem;

		[Cpp2IlInjected.Token(Token = "0x400896B")]
		public static int[] OverflowProtectionTimeOffset;

		[Cpp2IlInjected.Token(Token = "0x400896C")]
		public static int[] ItemsForStuffCannon;

		[Cpp2IlInjected.Token(Token = "0x400896D")]
		public static bool?[] CanBeQuickusedOnGamepad;

		[Cpp2IlInjected.Token(Token = "0x400896E")]
		public static bool?[] ForcesBreaksSleeping;

		[Cpp2IlInjected.Token(Token = "0x400896F")]
		public static bool[] SkipsInitialUseSound;

		[Cpp2IlInjected.Token(Token = "0x4008970")]
		public static bool[] UsesCursedByPlanteraTooltip;

		[Cpp2IlInjected.Token(Token = "0x4008971")]
		public static bool[] IsAKite;

		[Cpp2IlInjected.Token(Token = "0x4008972")]
		public static bool?[] ForceConsumption;

		[Cpp2IlInjected.Token(Token = "0x4008973")]
		public static bool[] HasAProjectileThatHasAUsabilityCheck;

		[Cpp2IlInjected.Token(Token = "0x4008974")]
		public static bool[] CanGetPrefixes;

		[Cpp2IlInjected.Token(Token = "0x4008975")]
		public static List<int> NonColorfulDyeItems;

		[Cpp2IlInjected.Token(Token = "0x4008976")]
		public static bool[] ColorfulDyeValues;

		[Cpp2IlInjected.Token(Token = "0x4008977")]
		public static FlowerPacketInfo[] flowerPacketInfo;

		[Cpp2IlInjected.Token(Token = "0x4008978")]
		public static bool[] IsAMaterial;

		[Cpp2IlInjected.Token(Token = "0x4008979")]
		public static int[] IsCrafted;

		[Cpp2IlInjected.Token(Token = "0x400897A")]
		public static int[] IsCraftedCrimson;

		[Cpp2IlInjected.Token(Token = "0x400897B")]
		public static int[] IsCraftedCorruption;

		[Cpp2IlInjected.Token(Token = "0x400897C")]
		public static bool[] IgnoresEncumberingStone;

		[Cpp2IlInjected.Token(Token = "0x400897D")]
		public static float[] ToolTipDamageMultiplier;

		[Cpp2IlInjected.Token(Token = "0x400897E")]
		public static bool[] IsAPickup;

		[Cpp2IlInjected.Token(Token = "0x400897F")]
		public static bool[] IsDrill;

		[Cpp2IlInjected.Token(Token = "0x4008980")]
		public static bool[] IsChainsaw;

		[Cpp2IlInjected.Token(Token = "0x4008981")]
		public static bool[] IsPaintScraper;

		[Cpp2IlInjected.Token(Token = "0x4008982")]
		public static bool[] SummonerWeaponThatScalesWithAttackSpeed;

		[Cpp2IlInjected.Token(Token = "0x4008983")]
		public static bool[] IsFood;

		[Cpp2IlInjected.Token(Token = "0x4008984")]
		public static Color[][] FoodParticleColors;

		[Cpp2IlInjected.Token(Token = "0x4008985")]
		public static Color[][] DrinkParticleColors;

		[Cpp2IlInjected.Token(Token = "0x4008986")]
		private static BannerEffect DD2BannerEffect;

		[Cpp2IlInjected.Token(Token = "0x4008987")]
		public static BannerEffect[] BannerStrength;

		[Cpp2IlInjected.Token(Token = "0x4008988")]
		public static int DefaultKillsForBannerNeeded;

		[Cpp2IlInjected.Token(Token = "0x4008989")]
		public static int[] KillsToBanner;

		[Cpp2IlInjected.Token(Token = "0x400898A")]
		public static bool[] CanFishInLava;

		[Cpp2IlInjected.Token(Token = "0x400898B")]
		public static bool[] IsLavaBait;

		[Cpp2IlInjected.Token(Token = "0x400898C")]
		private const int healingItemsDecayRate = 4;

		[Cpp2IlInjected.Token(Token = "0x400898D")]
		public static int[] ItemSpawnDecaySpeed;

		[Cpp2IlInjected.Token(Token = "0x400898E")]
		public static bool[] IsFishingCrate;

		[Cpp2IlInjected.Token(Token = "0x400898F")]
		public static bool[] IsFishingCrateHardmode;

		[Cpp2IlInjected.Token(Token = "0x4008990")]
		public static bool[] CanBePlacedOnWeaponRacks;

		[Cpp2IlInjected.Token(Token = "0x4008991")]
		public static int[] TextureCopyLoad;

		[Cpp2IlInjected.Token(Token = "0x4008992")]
		public static bool[] TrapSigned;

		[Cpp2IlInjected.Token(Token = "0x4008993")]
		public static bool[] Deprecated;

		[Cpp2IlInjected.Token(Token = "0x4008994")]
		public static bool[] NeverAppearsAsNewInInventory;

		[Cpp2IlInjected.Token(Token = "0x4008995")]
		public static bool[] CommonCoin;

		[Cpp2IlInjected.Token(Token = "0x4008996")]
		public static bool[] ItemIconPulse;

		[Cpp2IlInjected.Token(Token = "0x4008997")]
		public static bool[] ItemNoGravity;

		[Cpp2IlInjected.Token(Token = "0x4008998")]
		public static int[] ExtractinatorMode;

		[Cpp2IlInjected.Token(Token = "0x4008999")]
		public static int[] StaffMinionSlotsRequired;

		[Cpp2IlInjected.Token(Token = "0x400899A")]
		public static bool[] ExoticPlantsForDyeTrade;

		[Cpp2IlInjected.Token(Token = "0x400899B")]
		public static bool[] NebulaPickup;

		[Cpp2IlInjected.Token(Token = "0x400899C")]
		public static bool[] AnimatesAsSoul;

		[Cpp2IlInjected.Token(Token = "0x400899D")]
		public static bool[] gunProj;

		[Cpp2IlInjected.Token(Token = "0x400899E")]
		public static int[] SortingPriorityBossSpawns;

		[Cpp2IlInjected.Token(Token = "0x400899F")]
		public static int[] SortingPriorityWiring;

		[Cpp2IlInjected.Token(Token = "0x40089A0")]
		public static int[] SortingPriorityMaterials;

		[Cpp2IlInjected.Token(Token = "0x40089A1")]
		public static int[] SortingPriorityExtractibles;

		[Cpp2IlInjected.Token(Token = "0x40089A2")]
		public static int[] SortingPriorityRopes;

		[Cpp2IlInjected.Token(Token = "0x40089A3")]
		public static int[] SortingPriorityPainting;

		[Cpp2IlInjected.Token(Token = "0x40089A4")]
		public static int[] SortingPriorityTerraforming;

		[Cpp2IlInjected.Token(Token = "0x40089A5")]
		public static int[] GamepadExtraRange;

		[Cpp2IlInjected.Token(Token = "0x40089A6")]
		public static bool[] GamepadWholeScreenUseRange;

		[Cpp2IlInjected.Token(Token = "0x40089A7")]
		public static float[] BonusMeleeSpeedMultiplier;

		[Cpp2IlInjected.Token(Token = "0x40089A8")]
		public static bool[] GamepadSmartQuickReach;

		[Cpp2IlInjected.Token(Token = "0x40089A9")]
		public static bool[] Yoyo;

		[Cpp2IlInjected.Token(Token = "0x40089AA")]
		public static bool[] AlsoABuildingItem;

		[Cpp2IlInjected.Token(Token = "0x40089AB")]
		public static bool[] LockOnIgnoresCollision;

		[Cpp2IlInjected.Token(Token = "0x40089AC")]
		public static int[] LockOnAimAbove;

		[Cpp2IlInjected.Token(Token = "0x40089AD")]
		public static float?[] LockOnAimCompensation;

		[Cpp2IlInjected.Token(Token = "0x40089AE")]
		public static bool[] SingleUseInGamepad;

		[Cpp2IlInjected.Token(Token = "0x40089AF")]
		public static bool[] Torches;

		[Cpp2IlInjected.Token(Token = "0x40089B0")]
		public static bool[] WaterTorches;

		[Cpp2IlInjected.Token(Token = "0x40089B1")]
		public static short[] Workbenches;

		[Cpp2IlInjected.Token(Token = "0x40089B2")]
		public static bool[] BossBag;

		[Cpp2IlInjected.Token(Token = "0x40089B3")]
		public static bool[] OpenableBag;

		[Cpp2IlInjected.Token(Token = "0x6004CAC")]
		[Cpp2IlInjected.Address(RVA = "0x141B054", Offset = "0x141B054", VA = "0x141B054")]
		public Sets()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4003BBA")]
	private static Dictionary<string, short> _legacyItemLookup;

	[Cpp2IlInjected.Token(Token = "0x4003BBB")]
	public const short YellowPhasesaberOld = -24;

	[Cpp2IlInjected.Token(Token = "0x4003BBC")]
	public const short WhitePhasesaberOld = -23;

	[Cpp2IlInjected.Token(Token = "0x4003BBD")]
	public const short PurplePhasesaberOld = -22;

	[Cpp2IlInjected.Token(Token = "0x4003BBE")]
	public const short GreenPhasesaberOld = -21;

	[Cpp2IlInjected.Token(Token = "0x4003BBF")]
	public const short RedPhasesaberOld = -20;

	[Cpp2IlInjected.Token(Token = "0x4003BC0")]
	public const short BluePhasesaberOld = -19;

	[Cpp2IlInjected.Token(Token = "0x4003BC1")]
	public const short PlatinumBowOld = -48;

	[Cpp2IlInjected.Token(Token = "0x4003BC2")]
	public const short PlatinumHammerOld = -47;

	[Cpp2IlInjected.Token(Token = "0x4003BC3")]
	public const short PlatinumAxeOld = -46;

	[Cpp2IlInjected.Token(Token = "0x4003BC4")]
	public const short PlatinumShortswordOld = -45;

	[Cpp2IlInjected.Token(Token = "0x4003BC5")]
	public const short PlatinumBroadswordOld = -44;

	[Cpp2IlInjected.Token(Token = "0x4003BC6")]
	public const short PlatinumPickaxeOld = -43;

	[Cpp2IlInjected.Token(Token = "0x4003BC7")]
	public const short TungstenBowOld = -42;

	[Cpp2IlInjected.Token(Token = "0x4003BC8")]
	public const short TungstenHammerOld = -41;

	[Cpp2IlInjected.Token(Token = "0x4003BC9")]
	public const short TungstenAxeOld = -40;

	[Cpp2IlInjected.Token(Token = "0x4003BCA")]
	public const short TungstenShortswordOld = -39;

	[Cpp2IlInjected.Token(Token = "0x4003BCB")]
	public const short TungstenBroadswordOld = -38;

	[Cpp2IlInjected.Token(Token = "0x4003BCC")]
	public const short TungstenPickaxeOld = -37;

	[Cpp2IlInjected.Token(Token = "0x4003BCD")]
	public const short LeadBowOld = -36;

	[Cpp2IlInjected.Token(Token = "0x4003BCE")]
	public const short LeadHammerOld = -35;

	[Cpp2IlInjected.Token(Token = "0x4003BCF")]
	public const short LeadAxeOld = -34;

	[Cpp2IlInjected.Token(Token = "0x4003BD0")]
	public const short LeadShortswordOld = -33;

	[Cpp2IlInjected.Token(Token = "0x4003BD1")]
	public const short LeadBroadswordOld = -32;

	[Cpp2IlInjected.Token(Token = "0x4003BD2")]
	public const short LeadPickaxeOld = -31;

	[Cpp2IlInjected.Token(Token = "0x4003BD3")]
	public const short TinBowOld = -30;

	[Cpp2IlInjected.Token(Token = "0x4003BD4")]
	public const short TinHammerOld = -29;

	[Cpp2IlInjected.Token(Token = "0x4003BD5")]
	public const short TinAxeOld = -28;

	[Cpp2IlInjected.Token(Token = "0x4003BD6")]
	public const short TinShortswordOld = -27;

	[Cpp2IlInjected.Token(Token = "0x4003BD7")]
	public const short TinBroadswordOld = -26;

	[Cpp2IlInjected.Token(Token = "0x4003BD8")]
	public const short TinPickaxeOld = -25;

	[Cpp2IlInjected.Token(Token = "0x4003BD9")]
	public const short CopperBowOld = -18;

	[Cpp2IlInjected.Token(Token = "0x4003BDA")]
	public const short CopperHammerOld = -17;

	[Cpp2IlInjected.Token(Token = "0x4003BDB")]
	public const short CopperAxeOld = -16;

	[Cpp2IlInjected.Token(Token = "0x4003BDC")]
	public const short CopperShortswordOld = -15;

	[Cpp2IlInjected.Token(Token = "0x4003BDD")]
	public const short CopperBroadswordOld = -14;

	[Cpp2IlInjected.Token(Token = "0x4003BDE")]
	public const short CopperPickaxeOld = -13;

	[Cpp2IlInjected.Token(Token = "0x4003BDF")]
	public const short SilverBowOld = -12;

	[Cpp2IlInjected.Token(Token = "0x4003BE0")]
	public const short SilverHammerOld = -11;

	[Cpp2IlInjected.Token(Token = "0x4003BE1")]
	public const short SilverAxeOld = -10;

	[Cpp2IlInjected.Token(Token = "0x4003BE2")]
	public const short SilverShortswordOld = -9;

	[Cpp2IlInjected.Token(Token = "0x4003BE3")]
	public const short SilverBroadswordOld = -8;

	[Cpp2IlInjected.Token(Token = "0x4003BE4")]
	public const short SilverPickaxeOld = -7;

	[Cpp2IlInjected.Token(Token = "0x4003BE5")]
	public const short GoldBowOld = -6;

	[Cpp2IlInjected.Token(Token = "0x4003BE6")]
	public const short GoldHammerOld = -5;

	[Cpp2IlInjected.Token(Token = "0x4003BE7")]
	public const short GoldAxeOld = -4;

	[Cpp2IlInjected.Token(Token = "0x4003BE8")]
	public const short GoldShortswordOld = -3;

	[Cpp2IlInjected.Token(Token = "0x4003BE9")]
	public const short GoldBroadswordOld = -2;

	[Cpp2IlInjected.Token(Token = "0x4003BEA")]
	public const short GoldPickaxeOld = -1;

	[Cpp2IlInjected.Token(Token = "0x4003BEB")]
	public const short None = 0;

	[Cpp2IlInjected.Token(Token = "0x4003BEC")]
	public const short IronPickaxe = 1;

	[Cpp2IlInjected.Token(Token = "0x4003BED")]
	public const short DirtBlock = 2;

	[Cpp2IlInjected.Token(Token = "0x4003BEE")]
	public const short StoneBlock = 3;

	[Cpp2IlInjected.Token(Token = "0x4003BEF")]
	public const short IronBroadsword = 4;

	[Cpp2IlInjected.Token(Token = "0x4003BF0")]
	public const short Mushroom = 5;

	[Cpp2IlInjected.Token(Token = "0x4003BF1")]
	public const short IronShortsword = 6;

	[Cpp2IlInjected.Token(Token = "0x4003BF2")]
	public const short IronHammer = 7;

	[Cpp2IlInjected.Token(Token = "0x4003BF3")]
	public const short Torch = 8;

	[Cpp2IlInjected.Token(Token = "0x4003BF4")]
	public const short Wood = 9;

	[Cpp2IlInjected.Token(Token = "0x4003BF5")]
	public const short IronAxe = 10;

	[Cpp2IlInjected.Token(Token = "0x4003BF6")]
	public const short IronOre = 11;

	[Cpp2IlInjected.Token(Token = "0x4003BF7")]
	public const short CopperOre = 12;

	[Cpp2IlInjected.Token(Token = "0x4003BF8")]
	public const short GoldOre = 13;

	[Cpp2IlInjected.Token(Token = "0x4003BF9")]
	public const short SilverOre = 14;

	[Cpp2IlInjected.Token(Token = "0x4003BFA")]
	public const short CopperWatch = 15;

	[Cpp2IlInjected.Token(Token = "0x4003BFB")]
	public const short SilverWatch = 16;

	[Cpp2IlInjected.Token(Token = "0x4003BFC")]
	public const short GoldWatch = 17;

	[Cpp2IlInjected.Token(Token = "0x4003BFD")]
	public const short DepthMeter = 18;

	[Cpp2IlInjected.Token(Token = "0x4003BFE")]
	public const short GoldBar = 19;

	[Cpp2IlInjected.Token(Token = "0x4003BFF")]
	public const short CopperBar = 20;

	[Cpp2IlInjected.Token(Token = "0x4003C00")]
	public const short SilverBar = 21;

	[Cpp2IlInjected.Token(Token = "0x4003C01")]
	public const short IronBar = 22;

	[Cpp2IlInjected.Token(Token = "0x4003C02")]
	public const short Gel = 23;

	[Cpp2IlInjected.Token(Token = "0x4003C03")]
	public const short WoodenSword = 24;

	[Cpp2IlInjected.Token(Token = "0x4003C04")]
	public const short WoodenDoor = 25;

	[Cpp2IlInjected.Token(Token = "0x4003C05")]
	public const short StoneWall = 26;

	[Cpp2IlInjected.Token(Token = "0x4003C06")]
	public const short Acorn = 27;

	[Cpp2IlInjected.Token(Token = "0x4003C07")]
	public const short LesserHealingPotion = 28;

	[Cpp2IlInjected.Token(Token = "0x4003C08")]
	public const short LifeCrystal = 29;

	[Cpp2IlInjected.Token(Token = "0x4003C09")]
	public const short DirtWall = 30;

	[Cpp2IlInjected.Token(Token = "0x4003C0A")]
	public const short Bottle = 31;

	[Cpp2IlInjected.Token(Token = "0x4003C0B")]
	public const short WoodenTable = 32;

	[Cpp2IlInjected.Token(Token = "0x4003C0C")]
	public const short Furnace = 33;

	[Cpp2IlInjected.Token(Token = "0x4003C0D")]
	public const short WoodenChair = 34;

	[Cpp2IlInjected.Token(Token = "0x4003C0E")]
	public const short IronAnvil = 35;

	[Cpp2IlInjected.Token(Token = "0x4003C0F")]
	public const short WorkBench = 36;

	[Cpp2IlInjected.Token(Token = "0x4003C10")]
	public const short Goggles = 37;

	[Cpp2IlInjected.Token(Token = "0x4003C11")]
	public const short Lens = 38;

	[Cpp2IlInjected.Token(Token = "0x4003C12")]
	public const short WoodenBow = 39;

	[Cpp2IlInjected.Token(Token = "0x4003C13")]
	public const short WoodenArrow = 40;

	[Cpp2IlInjected.Token(Token = "0x4003C14")]
	public const short FlamingArrow = 41;

	[Cpp2IlInjected.Token(Token = "0x4003C15")]
	public const short Shuriken = 42;

	[Cpp2IlInjected.Token(Token = "0x4003C16")]
	public const short SuspiciousLookingEye = 43;

	[Cpp2IlInjected.Token(Token = "0x4003C17")]
	public const short DemonBow = 44;

	[Cpp2IlInjected.Token(Token = "0x4003C18")]
	public const short WarAxeoftheNight = 45;

	[Cpp2IlInjected.Token(Token = "0x4003C19")]
	public const short LightsBane = 46;

	[Cpp2IlInjected.Token(Token = "0x4003C1A")]
	public const short UnholyArrow = 47;

	[Cpp2IlInjected.Token(Token = "0x4003C1B")]
	public const short Chest = 48;

	[Cpp2IlInjected.Token(Token = "0x4003C1C")]
	public const short BandofRegeneration = 49;

	[Cpp2IlInjected.Token(Token = "0x4003C1D")]
	public const short MagicMirror = 50;

	[Cpp2IlInjected.Token(Token = "0x4003C1E")]
	public const short JestersArrow = 51;

	[Cpp2IlInjected.Token(Token = "0x4003C1F")]
	public const short AngelStatue = 52;

	[Cpp2IlInjected.Token(Token = "0x4003C20")]
	public const short CloudinaBottle = 53;

	[Cpp2IlInjected.Token(Token = "0x4003C21")]
	public const short HermesBoots = 54;

	[Cpp2IlInjected.Token(Token = "0x4003C22")]
	public const short EnchantedBoomerang = 55;

	[Cpp2IlInjected.Token(Token = "0x4003C23")]
	public const short DemoniteOre = 56;

	[Cpp2IlInjected.Token(Token = "0x4003C24")]
	public const short DemoniteBar = 57;

	[Cpp2IlInjected.Token(Token = "0x4003C25")]
	public const short Heart = 58;

	[Cpp2IlInjected.Token(Token = "0x4003C26")]
	public const short CorruptSeeds = 59;

	[Cpp2IlInjected.Token(Token = "0x4003C27")]
	public const short VileMushroom = 60;

	[Cpp2IlInjected.Token(Token = "0x4003C28")]
	public const short EbonstoneBlock = 61;

	[Cpp2IlInjected.Token(Token = "0x4003C29")]
	public const short GrassSeeds = 62;

	[Cpp2IlInjected.Token(Token = "0x4003C2A")]
	public const short Sunflower = 63;

	[Cpp2IlInjected.Token(Token = "0x4003C2B")]
	public const short Vilethorn = 64;

	[Cpp2IlInjected.Token(Token = "0x4003C2C")]
	public const short Starfury = 65;

	[Cpp2IlInjected.Token(Token = "0x4003C2D")]
	public const short PurificationPowder = 66;

	[Cpp2IlInjected.Token(Token = "0x4003C2E")]
	public const short VilePowder = 67;

	[Cpp2IlInjected.Token(Token = "0x4003C2F")]
	public const short RottenChunk = 68;

	[Cpp2IlInjected.Token(Token = "0x4003C30")]
	public const short WormTooth = 69;

	[Cpp2IlInjected.Token(Token = "0x4003C31")]
	public const short WormFood = 70;

	[Cpp2IlInjected.Token(Token = "0x4003C32")]
	public const short CopperCoin = 71;

	[Cpp2IlInjected.Token(Token = "0x4003C33")]
	public const short SilverCoin = 72;

	[Cpp2IlInjected.Token(Token = "0x4003C34")]
	public const short GoldCoin = 73;

	[Cpp2IlInjected.Token(Token = "0x4003C35")]
	public const short PlatinumCoin = 74;

	[Cpp2IlInjected.Token(Token = "0x4003C36")]
	public const short FallenStar = 75;

	[Cpp2IlInjected.Token(Token = "0x4003C37")]
	public const short CopperGreaves = 76;

	[Cpp2IlInjected.Token(Token = "0x4003C38")]
	public const short IronGreaves = 77;

	[Cpp2IlInjected.Token(Token = "0x4003C39")]
	public const short SilverGreaves = 78;

	[Cpp2IlInjected.Token(Token = "0x4003C3A")]
	public const short GoldGreaves = 79;

	[Cpp2IlInjected.Token(Token = "0x4003C3B")]
	public const short CopperChainmail = 80;

	[Cpp2IlInjected.Token(Token = "0x4003C3C")]
	public const short IronChainmail = 81;

	[Cpp2IlInjected.Token(Token = "0x4003C3D")]
	public const short SilverChainmail = 82;

	[Cpp2IlInjected.Token(Token = "0x4003C3E")]
	public const short GoldChainmail = 83;

	[Cpp2IlInjected.Token(Token = "0x4003C3F")]
	public const short GrapplingHook = 84;

	[Cpp2IlInjected.Token(Token = "0x4003C40")]
	public const short Chain = 85;

	[Cpp2IlInjected.Token(Token = "0x4003C41")]
	public const short ShadowScale = 86;

	[Cpp2IlInjected.Token(Token = "0x4003C42")]
	public const short PiggyBank = 87;

	[Cpp2IlInjected.Token(Token = "0x4003C43")]
	public const short MiningHelmet = 88;

	[Cpp2IlInjected.Token(Token = "0x4003C44")]
	public const short CopperHelmet = 89;

	[Cpp2IlInjected.Token(Token = "0x4003C45")]
	public const short IronHelmet = 90;

	[Cpp2IlInjected.Token(Token = "0x4003C46")]
	public const short SilverHelmet = 91;

	[Cpp2IlInjected.Token(Token = "0x4003C47")]
	public const short GoldHelmet = 92;

	[Cpp2IlInjected.Token(Token = "0x4003C48")]
	public const short WoodWall = 93;

	[Cpp2IlInjected.Token(Token = "0x4003C49")]
	public const short WoodPlatform = 94;

	[Cpp2IlInjected.Token(Token = "0x4003C4A")]
	public const short FlintlockPistol = 95;

	[Cpp2IlInjected.Token(Token = "0x4003C4B")]
	public const short Musket = 96;

	[Cpp2IlInjected.Token(Token = "0x4003C4C")]
	public const short MusketBall = 97;

	[Cpp2IlInjected.Token(Token = "0x4003C4D")]
	public const short Minishark = 98;

	[Cpp2IlInjected.Token(Token = "0x4003C4E")]
	public const short IronBow = 99;

	[Cpp2IlInjected.Token(Token = "0x4003C4F")]
	public const short ShadowGreaves = 100;

	[Cpp2IlInjected.Token(Token = "0x4003C50")]
	public const short ShadowScalemail = 101;

	[Cpp2IlInjected.Token(Token = "0x4003C51")]
	public const short ShadowHelmet = 102;

	[Cpp2IlInjected.Token(Token = "0x4003C52")]
	public const short NightmarePickaxe = 103;

	[Cpp2IlInjected.Token(Token = "0x4003C53")]
	public const short TheBreaker = 104;

	[Cpp2IlInjected.Token(Token = "0x4003C54")]
	public const short Candle = 105;

	[Cpp2IlInjected.Token(Token = "0x4003C55")]
	public const short CopperChandelier = 106;

	[Cpp2IlInjected.Token(Token = "0x4003C56")]
	public const short SilverChandelier = 107;

	[Cpp2IlInjected.Token(Token = "0x4003C57")]
	public const short GoldChandelier = 108;

	[Cpp2IlInjected.Token(Token = "0x4003C58")]
	public const short ManaCrystal = 109;

	[Cpp2IlInjected.Token(Token = "0x4003C59")]
	public const short LesserManaPotion = 110;

	[Cpp2IlInjected.Token(Token = "0x4003C5A")]
	public const short BandofStarpower = 111;

	[Cpp2IlInjected.Token(Token = "0x4003C5B")]
	public const short FlowerofFire = 112;

	[Cpp2IlInjected.Token(Token = "0x4003C5C")]
	public const short MagicMissile = 113;

	[Cpp2IlInjected.Token(Token = "0x4003C5D")]
	public const short DirtRod = 114;

	[Cpp2IlInjected.Token(Token = "0x4003C5E")]
	public const short ShadowOrb = 115;

	[Cpp2IlInjected.Token(Token = "0x4003C5F")]
	public const short Meteorite = 116;

	[Cpp2IlInjected.Token(Token = "0x4003C60")]
	public const short MeteoriteBar = 117;

	[Cpp2IlInjected.Token(Token = "0x4003C61")]
	public const short Hook = 118;

	[Cpp2IlInjected.Token(Token = "0x4003C62")]
	public const short Flamarang = 119;

	[Cpp2IlInjected.Token(Token = "0x4003C63")]
	public const short MoltenFury = 120;

	[Cpp2IlInjected.Token(Token = "0x4003C64")]
	public const short FieryGreatsword = 121;

	[Cpp2IlInjected.Token(Token = "0x4003C65")]
	public const short MoltenPickaxe = 122;

	[Cpp2IlInjected.Token(Token = "0x4003C66")]
	public const short MeteorHelmet = 123;

	[Cpp2IlInjected.Token(Token = "0x4003C67")]
	public const short MeteorSuit = 124;

	[Cpp2IlInjected.Token(Token = "0x4003C68")]
	public const short MeteorLeggings = 125;

	[Cpp2IlInjected.Token(Token = "0x4003C69")]
	public const short BottledWater = 126;

	[Cpp2IlInjected.Token(Token = "0x4003C6A")]
	public const short SpaceGun = 127;

	[Cpp2IlInjected.Token(Token = "0x4003C6B")]
	public const short RocketBoots = 128;

	[Cpp2IlInjected.Token(Token = "0x4003C6C")]
	public const short GrayBrick = 129;

	[Cpp2IlInjected.Token(Token = "0x4003C6D")]
	public const short GrayBrickWall = 130;

	[Cpp2IlInjected.Token(Token = "0x4003C6E")]
	public const short RedBrick = 131;

	[Cpp2IlInjected.Token(Token = "0x4003C6F")]
	public const short RedBrickWall = 132;

	[Cpp2IlInjected.Token(Token = "0x4003C70")]
	public const short ClayBlock = 133;

	[Cpp2IlInjected.Token(Token = "0x4003C71")]
	public const short BlueBrick = 134;

	[Cpp2IlInjected.Token(Token = "0x4003C72")]
	public const short BlueBrickWall = 135;

	[Cpp2IlInjected.Token(Token = "0x4003C73")]
	public const short ChainLantern = 136;

	[Cpp2IlInjected.Token(Token = "0x4003C74")]
	public const short GreenBrick = 137;

	[Cpp2IlInjected.Token(Token = "0x4003C75")]
	public const short GreenBrickWall = 138;

	[Cpp2IlInjected.Token(Token = "0x4003C76")]
	public const short PinkBrick = 139;

	[Cpp2IlInjected.Token(Token = "0x4003C77")]
	public const short PinkBrickWall = 140;

	[Cpp2IlInjected.Token(Token = "0x4003C78")]
	public const short GoldBrick = 141;

	[Cpp2IlInjected.Token(Token = "0x4003C79")]
	public const short GoldBrickWall = 142;

	[Cpp2IlInjected.Token(Token = "0x4003C7A")]
	public const short SilverBrick = 143;

	[Cpp2IlInjected.Token(Token = "0x4003C7B")]
	public const short SilverBrickWall = 144;

	[Cpp2IlInjected.Token(Token = "0x4003C7C")]
	public const short CopperBrick = 145;

	[Cpp2IlInjected.Token(Token = "0x4003C7D")]
	public const short CopperBrickWall = 146;

	[Cpp2IlInjected.Token(Token = "0x4003C7E")]
	public const short Spike = 147;

	[Cpp2IlInjected.Token(Token = "0x4003C7F")]
	public const short WaterCandle = 148;

	[Cpp2IlInjected.Token(Token = "0x4003C80")]
	public const short Book = 149;

	[Cpp2IlInjected.Token(Token = "0x4003C81")]
	public const short Cobweb = 150;

	[Cpp2IlInjected.Token(Token = "0x4003C82")]
	public const short NecroHelmet = 151;

	[Cpp2IlInjected.Token(Token = "0x4003C83")]
	public const short NecroBreastplate = 152;

	[Cpp2IlInjected.Token(Token = "0x4003C84")]
	public const short NecroGreaves = 153;

	[Cpp2IlInjected.Token(Token = "0x4003C85")]
	public const short Bone = 154;

	[Cpp2IlInjected.Token(Token = "0x4003C86")]
	public const short Muramasa = 155;

	[Cpp2IlInjected.Token(Token = "0x4003C87")]
	public const short CobaltShield = 156;

	[Cpp2IlInjected.Token(Token = "0x4003C88")]
	public const short AquaScepter = 157;

	[Cpp2IlInjected.Token(Token = "0x4003C89")]
	public const short LuckyHorseshoe = 158;

	[Cpp2IlInjected.Token(Token = "0x4003C8A")]
	public const short ShinyRedBalloon = 159;

	[Cpp2IlInjected.Token(Token = "0x4003C8B")]
	public const short Harpoon = 160;

	[Cpp2IlInjected.Token(Token = "0x4003C8C")]
	public const short SpikyBall = 161;

	[Cpp2IlInjected.Token(Token = "0x4003C8D")]
	public const short BallOHurt = 162;

	[Cpp2IlInjected.Token(Token = "0x4003C8E")]
	public const short BlueMoon = 163;

	[Cpp2IlInjected.Token(Token = "0x4003C8F")]
	public const short Handgun = 164;

	[Cpp2IlInjected.Token(Token = "0x4003C90")]
	public const short WaterBolt = 165;

	[Cpp2IlInjected.Token(Token = "0x4003C91")]
	public const short Bomb = 166;

	[Cpp2IlInjected.Token(Token = "0x4003C92")]
	public const short Dynamite = 167;

	[Cpp2IlInjected.Token(Token = "0x4003C93")]
	public const short Grenade = 168;

	[Cpp2IlInjected.Token(Token = "0x4003C94")]
	public const short SandBlock = 169;

	[Cpp2IlInjected.Token(Token = "0x4003C95")]
	public const short Glass = 170;

	[Cpp2IlInjected.Token(Token = "0x4003C96")]
	public const short Sign = 171;

	[Cpp2IlInjected.Token(Token = "0x4003C97")]
	public const short AshBlock = 172;

	[Cpp2IlInjected.Token(Token = "0x4003C98")]
	public const short Obsidian = 173;

	[Cpp2IlInjected.Token(Token = "0x4003C99")]
	public const short Hellstone = 174;

	[Cpp2IlInjected.Token(Token = "0x4003C9A")]
	public const short HellstoneBar = 175;

	[Cpp2IlInjected.Token(Token = "0x4003C9B")]
	public const short MudBlock = 176;

	[Cpp2IlInjected.Token(Token = "0x4003C9C")]
	public const short Sapphire = 177;

	[Cpp2IlInjected.Token(Token = "0x4003C9D")]
	public const short Ruby = 178;

	[Cpp2IlInjected.Token(Token = "0x4003C9E")]
	public const short Emerald = 179;

	[Cpp2IlInjected.Token(Token = "0x4003C9F")]
	public const short Topaz = 180;

	[Cpp2IlInjected.Token(Token = "0x4003CA0")]
	public const short Amethyst = 181;

	[Cpp2IlInjected.Token(Token = "0x4003CA1")]
	public const short Diamond = 182;

	[Cpp2IlInjected.Token(Token = "0x4003CA2")]
	public const short GlowingMushroom = 183;

	[Cpp2IlInjected.Token(Token = "0x4003CA3")]
	public const short Star = 184;

	[Cpp2IlInjected.Token(Token = "0x4003CA4")]
	public const short IvyWhip = 185;

	[Cpp2IlInjected.Token(Token = "0x4003CA5")]
	public const short BreathingReed = 186;

	[Cpp2IlInjected.Token(Token = "0x4003CA6")]
	public const short Flipper = 187;

	[Cpp2IlInjected.Token(Token = "0x4003CA7")]
	public const short HealingPotion = 188;

	[Cpp2IlInjected.Token(Token = "0x4003CA8")]
	public const short ManaPotion = 189;

	[Cpp2IlInjected.Token(Token = "0x4003CA9")]
	public const short BladeofGrass = 190;

	[Cpp2IlInjected.Token(Token = "0x4003CAA")]
	public const short ThornChakram = 191;

	[Cpp2IlInjected.Token(Token = "0x4003CAB")]
	public const short ObsidianBrick = 192;

	[Cpp2IlInjected.Token(Token = "0x4003CAC")]
	public const short ObsidianSkull = 193;

	[Cpp2IlInjected.Token(Token = "0x4003CAD")]
	public const short MushroomGrassSeeds = 194;

	[Cpp2IlInjected.Token(Token = "0x4003CAE")]
	public const short JungleGrassSeeds = 195;

	[Cpp2IlInjected.Token(Token = "0x4003CAF")]
	public const short WoodenHammer = 196;

	[Cpp2IlInjected.Token(Token = "0x4003CB0")]
	public const short StarCannon = 197;

	[Cpp2IlInjected.Token(Token = "0x4003CB1")]
	public const short BluePhaseblade = 198;

	[Cpp2IlInjected.Token(Token = "0x4003CB2")]
	public const short RedPhaseblade = 199;

	[Cpp2IlInjected.Token(Token = "0x4003CB3")]
	public const short GreenPhaseblade = 200;

	[Cpp2IlInjected.Token(Token = "0x4003CB4")]
	public const short PurplePhaseblade = 201;

	[Cpp2IlInjected.Token(Token = "0x4003CB5")]
	public const short WhitePhaseblade = 202;

	[Cpp2IlInjected.Token(Token = "0x4003CB6")]
	public const short YellowPhaseblade = 203;

	[Cpp2IlInjected.Token(Token = "0x4003CB7")]
	public const short MeteorHamaxe = 204;

	[Cpp2IlInjected.Token(Token = "0x4003CB8")]
	public const short EmptyBucket = 205;

	[Cpp2IlInjected.Token(Token = "0x4003CB9")]
	public const short WaterBucket = 206;

	[Cpp2IlInjected.Token(Token = "0x4003CBA")]
	public const short LavaBucket = 207;

	[Cpp2IlInjected.Token(Token = "0x4003CBB")]
	public const short JungleRose = 208;

	[Cpp2IlInjected.Token(Token = "0x4003CBC")]
	public const short Stinger = 209;

	[Cpp2IlInjected.Token(Token = "0x4003CBD")]
	public const short Vine = 210;

	[Cpp2IlInjected.Token(Token = "0x4003CBE")]
	public const short FeralClaws = 211;

	[Cpp2IlInjected.Token(Token = "0x4003CBF")]
	public const short AnkletoftheWind = 212;

	[Cpp2IlInjected.Token(Token = "0x4003CC0")]
	public const short StaffofRegrowth = 213;

	[Cpp2IlInjected.Token(Token = "0x4003CC1")]
	public const short HellstoneBrick = 214;

	[Cpp2IlInjected.Token(Token = "0x4003CC2")]
	public const short WhoopieCushion = 215;

	[Cpp2IlInjected.Token(Token = "0x4003CC3")]
	public const short Shackle = 216;

	[Cpp2IlInjected.Token(Token = "0x4003CC4")]
	public const short MoltenHamaxe = 217;

	[Cpp2IlInjected.Token(Token = "0x4003CC5")]
	public const short Flamelash = 218;

	[Cpp2IlInjected.Token(Token = "0x4003CC6")]
	public const short PhoenixBlaster = 219;

	[Cpp2IlInjected.Token(Token = "0x4003CC7")]
	public const short Sunfury = 220;

	[Cpp2IlInjected.Token(Token = "0x4003CC8")]
	public const short Hellforge = 221;

	[Cpp2IlInjected.Token(Token = "0x4003CC9")]
	public const short ClayPot = 222;

	[Cpp2IlInjected.Token(Token = "0x4003CCA")]
	public const short NaturesGift = 223;

	[Cpp2IlInjected.Token(Token = "0x4003CCB")]
	public const short Bed = 224;

	[Cpp2IlInjected.Token(Token = "0x4003CCC")]
	public const short Silk = 225;

	[Cpp2IlInjected.Token(Token = "0x4003CCD")]
	public const short LesserRestorationPotion = 226;

	[Cpp2IlInjected.Token(Token = "0x4003CCE")]
	public const short RestorationPotion = 227;

	[Cpp2IlInjected.Token(Token = "0x4003CCF")]
	public const short JungleHat = 228;

	[Cpp2IlInjected.Token(Token = "0x4003CD0")]
	public const short JungleShirt = 229;

	[Cpp2IlInjected.Token(Token = "0x4003CD1")]
	public const short JunglePants = 230;

	[Cpp2IlInjected.Token(Token = "0x4003CD2")]
	public const short MoltenHelmet = 231;

	[Cpp2IlInjected.Token(Token = "0x4003CD3")]
	public const short MoltenBreastplate = 232;

	[Cpp2IlInjected.Token(Token = "0x4003CD4")]
	public const short MoltenGreaves = 233;

	[Cpp2IlInjected.Token(Token = "0x4003CD5")]
	public const short MeteorShot = 234;

	[Cpp2IlInjected.Token(Token = "0x4003CD6")]
	public const short StickyBomb = 235;

	[Cpp2IlInjected.Token(Token = "0x4003CD7")]
	public const short BlackLens = 236;

	[Cpp2IlInjected.Token(Token = "0x4003CD8")]
	public const short Sunglasses = 237;

	[Cpp2IlInjected.Token(Token = "0x4003CD9")]
	public const short WizardHat = 238;

	[Cpp2IlInjected.Token(Token = "0x4003CDA")]
	public const short TopHat = 239;

	[Cpp2IlInjected.Token(Token = "0x4003CDB")]
	public const short TuxedoShirt = 240;

	[Cpp2IlInjected.Token(Token = "0x4003CDC")]
	public const short TuxedoPants = 241;

	[Cpp2IlInjected.Token(Token = "0x4003CDD")]
	public const short SummerHat = 242;

	[Cpp2IlInjected.Token(Token = "0x4003CDE")]
	public const short BunnyHood = 243;

	[Cpp2IlInjected.Token(Token = "0x4003CDF")]
	public const short PlumbersHat = 244;

	[Cpp2IlInjected.Token(Token = "0x4003CE0")]
	public const short PlumbersShirt = 245;

	[Cpp2IlInjected.Token(Token = "0x4003CE1")]
	public const short PlumbersPants = 246;

	[Cpp2IlInjected.Token(Token = "0x4003CE2")]
	public const short HerosHat = 247;

	[Cpp2IlInjected.Token(Token = "0x4003CE3")]
	public const short HerosShirt = 248;

	[Cpp2IlInjected.Token(Token = "0x4003CE4")]
	public const short HerosPants = 249;

	[Cpp2IlInjected.Token(Token = "0x4003CE5")]
	public const short FishBowl = 250;

	[Cpp2IlInjected.Token(Token = "0x4003CE6")]
	public const short ArchaeologistsHat = 251;

	[Cpp2IlInjected.Token(Token = "0x4003CE7")]
	public const short ArchaeologistsJacket = 252;

	[Cpp2IlInjected.Token(Token = "0x4003CE8")]
	public const short ArchaeologistsPants = 253;

	[Cpp2IlInjected.Token(Token = "0x4003CE9")]
	public const short BlackThread = 254;

	[Cpp2IlInjected.Token(Token = "0x4003CEA")]
	public const short GreenThread = 255;

	[Cpp2IlInjected.Token(Token = "0x4003CEB")]
	public const short NinjaHood = 256;

	[Cpp2IlInjected.Token(Token = "0x4003CEC")]
	public const short NinjaShirt = 257;

	[Cpp2IlInjected.Token(Token = "0x4003CED")]
	public const short NinjaPants = 258;

	[Cpp2IlInjected.Token(Token = "0x4003CEE")]
	public const short Leather = 259;

	[Cpp2IlInjected.Token(Token = "0x4003CEF")]
	public const short RedHat = 260;

	[Cpp2IlInjected.Token(Token = "0x4003CF0")]
	public const short Goldfish = 261;

	[Cpp2IlInjected.Token(Token = "0x4003CF1")]
	public const short Robe = 262;

	[Cpp2IlInjected.Token(Token = "0x4003CF2")]
	public const short RobotHat = 263;

	[Cpp2IlInjected.Token(Token = "0x4003CF3")]
	public const short GoldCrown = 264;

	[Cpp2IlInjected.Token(Token = "0x4003CF4")]
	public const short HellfireArrow = 265;

	[Cpp2IlInjected.Token(Token = "0x4003CF5")]
	public const short Sandgun = 266;

	[Cpp2IlInjected.Token(Token = "0x4003CF6")]
	public const short GuideVoodooDoll = 267;

	[Cpp2IlInjected.Token(Token = "0x4003CF7")]
	public const short DivingHelmet = 268;

	[Cpp2IlInjected.Token(Token = "0x4003CF8")]
	public const short FamiliarShirt = 269;

	[Cpp2IlInjected.Token(Token = "0x4003CF9")]
	public const short FamiliarPants = 270;

	[Cpp2IlInjected.Token(Token = "0x4003CFA")]
	public const short FamiliarWig = 271;

	[Cpp2IlInjected.Token(Token = "0x4003CFB")]
	public const short DemonScythe = 272;

	[Cpp2IlInjected.Token(Token = "0x4003CFC")]
	public const short NightsEdge = 273;

	[Cpp2IlInjected.Token(Token = "0x4003CFD")]
	public const short DarkLance = 274;

	[Cpp2IlInjected.Token(Token = "0x4003CFE")]
	public const short Coral = 275;

	[Cpp2IlInjected.Token(Token = "0x4003CFF")]
	public const short Cactus = 276;

	[Cpp2IlInjected.Token(Token = "0x4003D00")]
	public const short Trident = 277;

	[Cpp2IlInjected.Token(Token = "0x4003D01")]
	public const short SilverBullet = 278;

	[Cpp2IlInjected.Token(Token = "0x4003D02")]
	public const short ThrowingKnife = 279;

	[Cpp2IlInjected.Token(Token = "0x4003D03")]
	public const short Spear = 280;

	[Cpp2IlInjected.Token(Token = "0x4003D04")]
	public const short Blowpipe = 281;

	[Cpp2IlInjected.Token(Token = "0x4003D05")]
	public const short Glowstick = 282;

	[Cpp2IlInjected.Token(Token = "0x4003D06")]
	public const short Seed = 283;

	[Cpp2IlInjected.Token(Token = "0x4003D07")]
	public const short WoodenBoomerang = 284;

	[Cpp2IlInjected.Token(Token = "0x4003D08")]
	public const short Aglet = 285;

	[Cpp2IlInjected.Token(Token = "0x4003D09")]
	public const short StickyGlowstick = 286;

	[Cpp2IlInjected.Token(Token = "0x4003D0A")]
	public const short PoisonedKnife = 287;

	[Cpp2IlInjected.Token(Token = "0x4003D0B")]
	public const short ObsidianSkinPotion = 288;

	[Cpp2IlInjected.Token(Token = "0x4003D0C")]
	public const short RegenerationPotion = 289;

	[Cpp2IlInjected.Token(Token = "0x4003D0D")]
	public const short SwiftnessPotion = 290;

	[Cpp2IlInjected.Token(Token = "0x4003D0E")]
	public const short GillsPotion = 291;

	[Cpp2IlInjected.Token(Token = "0x4003D0F")]
	public const short IronskinPotion = 292;

	[Cpp2IlInjected.Token(Token = "0x4003D10")]
	public const short ManaRegenerationPotion = 293;

	[Cpp2IlInjected.Token(Token = "0x4003D11")]
	public const short MagicPowerPotion = 294;

	[Cpp2IlInjected.Token(Token = "0x4003D12")]
	public const short FeatherfallPotion = 295;

	[Cpp2IlInjected.Token(Token = "0x4003D13")]
	public const short SpelunkerPotion = 296;

	[Cpp2IlInjected.Token(Token = "0x4003D14")]
	public const short InvisibilityPotion = 297;

	[Cpp2IlInjected.Token(Token = "0x4003D15")]
	public const short ShinePotion = 298;

	[Cpp2IlInjected.Token(Token = "0x4003D16")]
	public const short NightOwlPotion = 299;

	[Cpp2IlInjected.Token(Token = "0x4003D17")]
	public const short BattlePotion = 300;

	[Cpp2IlInjected.Token(Token = "0x4003D18")]
	public const short ThornsPotion = 301;

	[Cpp2IlInjected.Token(Token = "0x4003D19")]
	public const short WaterWalkingPotion = 302;

	[Cpp2IlInjected.Token(Token = "0x4003D1A")]
	public const short ArcheryPotion = 303;

	[Cpp2IlInjected.Token(Token = "0x4003D1B")]
	public const short HunterPotion = 304;

	[Cpp2IlInjected.Token(Token = "0x4003D1C")]
	public const short GravitationPotion = 305;

	[Cpp2IlInjected.Token(Token = "0x4003D1D")]
	public const short GoldChest = 306;

	[Cpp2IlInjected.Token(Token = "0x4003D1E")]
	public const short DaybloomSeeds = 307;

	[Cpp2IlInjected.Token(Token = "0x4003D1F")]
	public const short MoonglowSeeds = 308;

	[Cpp2IlInjected.Token(Token = "0x4003D20")]
	public const short BlinkrootSeeds = 309;

	[Cpp2IlInjected.Token(Token = "0x4003D21")]
	public const short DeathweedSeeds = 310;

	[Cpp2IlInjected.Token(Token = "0x4003D22")]
	public const short WaterleafSeeds = 311;

	[Cpp2IlInjected.Token(Token = "0x4003D23")]
	public const short FireblossomSeeds = 312;

	[Cpp2IlInjected.Token(Token = "0x4003D24")]
	public const short Daybloom = 313;

	[Cpp2IlInjected.Token(Token = "0x4003D25")]
	public const short Moonglow = 314;

	[Cpp2IlInjected.Token(Token = "0x4003D26")]
	public const short Blinkroot = 315;

	[Cpp2IlInjected.Token(Token = "0x4003D27")]
	public const short Deathweed = 316;

	[Cpp2IlInjected.Token(Token = "0x4003D28")]
	public const short Waterleaf = 317;

	[Cpp2IlInjected.Token(Token = "0x4003D29")]
	public const short Fireblossom = 318;

	[Cpp2IlInjected.Token(Token = "0x4003D2A")]
	public const short SharkFin = 319;

	[Cpp2IlInjected.Token(Token = "0x4003D2B")]
	public const short Feather = 320;

	[Cpp2IlInjected.Token(Token = "0x4003D2C")]
	public const short Tombstone = 321;

	[Cpp2IlInjected.Token(Token = "0x4003D2D")]
	public const short MimeMask = 322;

	[Cpp2IlInjected.Token(Token = "0x4003D2E")]
	public const short AntlionMandible = 323;

	[Cpp2IlInjected.Token(Token = "0x4003D2F")]
	public const short IllegalGunParts = 324;

	[Cpp2IlInjected.Token(Token = "0x4003D30")]
	public const short TheDoctorsShirt = 325;

	[Cpp2IlInjected.Token(Token = "0x4003D31")]
	public const short TheDoctorsPants = 326;

	[Cpp2IlInjected.Token(Token = "0x4003D32")]
	public const short GoldenKey = 327;

	[Cpp2IlInjected.Token(Token = "0x4003D33")]
	public const short ShadowChest = 328;

	[Cpp2IlInjected.Token(Token = "0x4003D34")]
	public const short ShadowKey = 329;

	[Cpp2IlInjected.Token(Token = "0x4003D35")]
	public const short ObsidianBrickWall = 330;

	[Cpp2IlInjected.Token(Token = "0x4003D36")]
	public const short JungleSpores = 331;

	[Cpp2IlInjected.Token(Token = "0x4003D37")]
	public const short Loom = 332;

	[Cpp2IlInjected.Token(Token = "0x4003D38")]
	public const short Piano = 333;

	[Cpp2IlInjected.Token(Token = "0x4003D39")]
	public const short Dresser = 334;

	[Cpp2IlInjected.Token(Token = "0x4003D3A")]
	public const short Bench = 335;

	[Cpp2IlInjected.Token(Token = "0x4003D3B")]
	public const short Bathtub = 336;

	[Cpp2IlInjected.Token(Token = "0x4003D3C")]
	public const short RedBanner = 337;

	[Cpp2IlInjected.Token(Token = "0x4003D3D")]
	public const short GreenBanner = 338;

	[Cpp2IlInjected.Token(Token = "0x4003D3E")]
	public const short BlueBanner = 339;

	[Cpp2IlInjected.Token(Token = "0x4003D3F")]
	public const short YellowBanner = 340;

	[Cpp2IlInjected.Token(Token = "0x4003D40")]
	public const short LampPost = 341;

	[Cpp2IlInjected.Token(Token = "0x4003D41")]
	public const short TikiTorch = 342;

	[Cpp2IlInjected.Token(Token = "0x4003D42")]
	public const short Barrel = 343;

	[Cpp2IlInjected.Token(Token = "0x4003D43")]
	public const short ChineseLantern = 344;

	[Cpp2IlInjected.Token(Token = "0x4003D44")]
	public const short CookingPot = 345;

	[Cpp2IlInjected.Token(Token = "0x4003D45")]
	public const short Safe = 346;

	[Cpp2IlInjected.Token(Token = "0x4003D46")]
	public const short SkullLantern = 347;

	[Cpp2IlInjected.Token(Token = "0x4003D47")]
	public const short TrashCan = 348;

	[Cpp2IlInjected.Token(Token = "0x4003D48")]
	public const short Candelabra = 349;

	[Cpp2IlInjected.Token(Token = "0x4003D49")]
	public const short PinkVase = 350;

	[Cpp2IlInjected.Token(Token = "0x4003D4A")]
	public const short Mug = 351;

	[Cpp2IlInjected.Token(Token = "0x4003D4B")]
	public const short Keg = 352;

	[Cpp2IlInjected.Token(Token = "0x4003D4C")]
	public const short Ale = 353;

	[Cpp2IlInjected.Token(Token = "0x4003D4D")]
	public const short Bookcase = 354;

	[Cpp2IlInjected.Token(Token = "0x4003D4E")]
	public const short Throne = 355;

	[Cpp2IlInjected.Token(Token = "0x4003D4F")]
	public const short Bowl = 356;

	[Cpp2IlInjected.Token(Token = "0x4003D50")]
	public const short BowlofSoup = 357;

	[Cpp2IlInjected.Token(Token = "0x4003D51")]
	public const short Toilet = 358;

	[Cpp2IlInjected.Token(Token = "0x4003D52")]
	public const short GrandfatherClock = 359;

	[Cpp2IlInjected.Token(Token = "0x4003D53")]
	public const short ArmorStatue = 360;

	[Cpp2IlInjected.Token(Token = "0x4003D54")]
	public const short GoblinBattleStandard = 361;

	[Cpp2IlInjected.Token(Token = "0x4003D55")]
	public const short TatteredCloth = 362;

	[Cpp2IlInjected.Token(Token = "0x4003D56")]
	public const short Sawmill = 363;

	[Cpp2IlInjected.Token(Token = "0x4003D57")]
	public const short CobaltOre = 364;

	[Cpp2IlInjected.Token(Token = "0x4003D58")]
	public const short MythrilOre = 365;

	[Cpp2IlInjected.Token(Token = "0x4003D59")]
	public const short AdamantiteOre = 366;

	[Cpp2IlInjected.Token(Token = "0x4003D5A")]
	public const short Pwnhammer = 367;

	[Cpp2IlInjected.Token(Token = "0x4003D5B")]
	public const short Excalibur = 368;

	[Cpp2IlInjected.Token(Token = "0x4003D5C")]
	public const short HallowedSeeds = 369;

	[Cpp2IlInjected.Token(Token = "0x4003D5D")]
	public const short EbonsandBlock = 370;

	[Cpp2IlInjected.Token(Token = "0x4003D5E")]
	public const short CobaltHat = 371;

	[Cpp2IlInjected.Token(Token = "0x4003D5F")]
	public const short CobaltHelmet = 372;

	[Cpp2IlInjected.Token(Token = "0x4003D60")]
	public const short CobaltMask = 373;

	[Cpp2IlInjected.Token(Token = "0x4003D61")]
	public const short CobaltBreastplate = 374;

	[Cpp2IlInjected.Token(Token = "0x4003D62")]
	public const short CobaltLeggings = 375;

	[Cpp2IlInjected.Token(Token = "0x4003D63")]
	public const short MythrilHood = 376;

	[Cpp2IlInjected.Token(Token = "0x4003D64")]
	public const short MythrilHelmet = 377;

	[Cpp2IlInjected.Token(Token = "0x4003D65")]
	public const short MythrilHat = 378;

	[Cpp2IlInjected.Token(Token = "0x4003D66")]
	public const short MythrilChainmail = 379;

	[Cpp2IlInjected.Token(Token = "0x4003D67")]
	public const short MythrilGreaves = 380;

	[Cpp2IlInjected.Token(Token = "0x4003D68")]
	public const short CobaltBar = 381;

	[Cpp2IlInjected.Token(Token = "0x4003D69")]
	public const short MythrilBar = 382;

	[Cpp2IlInjected.Token(Token = "0x4003D6A")]
	public const short CobaltChainsaw = 383;

	[Cpp2IlInjected.Token(Token = "0x4003D6B")]
	public const short MythrilChainsaw = 384;

	[Cpp2IlInjected.Token(Token = "0x4003D6C")]
	public const short CobaltDrill = 385;

	[Cpp2IlInjected.Token(Token = "0x4003D6D")]
	public const short MythrilDrill = 386;

	[Cpp2IlInjected.Token(Token = "0x4003D6E")]
	public const short AdamantiteChainsaw = 387;

	[Cpp2IlInjected.Token(Token = "0x4003D6F")]
	public const short AdamantiteDrill = 388;

	[Cpp2IlInjected.Token(Token = "0x4003D70")]
	public const short DaoofPow = 389;

	[Cpp2IlInjected.Token(Token = "0x4003D71")]
	public const short MythrilHalberd = 390;

	[Cpp2IlInjected.Token(Token = "0x4003D72")]
	public const short AdamantiteBar = 391;

	[Cpp2IlInjected.Token(Token = "0x4003D73")]
	public const short GlassWall = 392;

	[Cpp2IlInjected.Token(Token = "0x4003D74")]
	public const short Compass = 393;

	[Cpp2IlInjected.Token(Token = "0x4003D75")]
	public const short DivingGear = 394;

	[Cpp2IlInjected.Token(Token = "0x4003D76")]
	public const short GPS = 395;

	[Cpp2IlInjected.Token(Token = "0x4003D77")]
	public const short ObsidianHorseshoe = 396;

	[Cpp2IlInjected.Token(Token = "0x4003D78")]
	public const short ObsidianShield = 397;

	[Cpp2IlInjected.Token(Token = "0x4003D79")]
	public const short TinkerersWorkshop = 398;

	[Cpp2IlInjected.Token(Token = "0x4003D7A")]
	public const short CloudinaBalloon = 399;

	[Cpp2IlInjected.Token(Token = "0x4003D7B")]
	public const short AdamantiteHeadgear = 400;

	[Cpp2IlInjected.Token(Token = "0x4003D7C")]
	public const short AdamantiteHelmet = 401;

	[Cpp2IlInjected.Token(Token = "0x4003D7D")]
	public const short AdamantiteMask = 402;

	[Cpp2IlInjected.Token(Token = "0x4003D7E")]
	public const short AdamantiteBreastplate = 403;

	[Cpp2IlInjected.Token(Token = "0x4003D7F")]
	public const short AdamantiteLeggings = 404;

	[Cpp2IlInjected.Token(Token = "0x4003D80")]
	public const short SpectreBoots = 405;

	[Cpp2IlInjected.Token(Token = "0x4003D81")]
	public const short AdamantiteGlaive = 406;

	[Cpp2IlInjected.Token(Token = "0x4003D82")]
	public const short Toolbelt = 407;

	[Cpp2IlInjected.Token(Token = "0x4003D83")]
	public const short PearlsandBlock = 408;

	[Cpp2IlInjected.Token(Token = "0x4003D84")]
	public const short PearlstoneBlock = 409;

	[Cpp2IlInjected.Token(Token = "0x4003D85")]
	public const short MiningShirt = 410;

	[Cpp2IlInjected.Token(Token = "0x4003D86")]
	public const short MiningPants = 411;

	[Cpp2IlInjected.Token(Token = "0x4003D87")]
	public const short PearlstoneBrick = 412;

	[Cpp2IlInjected.Token(Token = "0x4003D88")]
	public const short IridescentBrick = 413;

	[Cpp2IlInjected.Token(Token = "0x4003D89")]
	public const short MudstoneBlock = 414;

	[Cpp2IlInjected.Token(Token = "0x4003D8A")]
	public const short CobaltBrick = 415;

	[Cpp2IlInjected.Token(Token = "0x4003D8B")]
	public const short MythrilBrick = 416;

	[Cpp2IlInjected.Token(Token = "0x4003D8C")]
	public const short PearlstoneBrickWall = 417;

	[Cpp2IlInjected.Token(Token = "0x4003D8D")]
	public const short IridescentBrickWall = 418;

	[Cpp2IlInjected.Token(Token = "0x4003D8E")]
	public const short MudstoneBrickWall = 419;

	[Cpp2IlInjected.Token(Token = "0x4003D8F")]
	public const short CobaltBrickWall = 420;

	[Cpp2IlInjected.Token(Token = "0x4003D90")]
	public const short MythrilBrickWall = 421;

	[Cpp2IlInjected.Token(Token = "0x4003D91")]
	public const short HolyWater = 422;

	[Cpp2IlInjected.Token(Token = "0x4003D92")]
	public const short UnholyWater = 423;

	[Cpp2IlInjected.Token(Token = "0x4003D93")]
	public const short SiltBlock = 424;

	[Cpp2IlInjected.Token(Token = "0x4003D94")]
	public const short FairyBell = 425;

	[Cpp2IlInjected.Token(Token = "0x4003D95")]
	public const short BreakerBlade = 426;

	[Cpp2IlInjected.Token(Token = "0x4003D96")]
	public const short BlueTorch = 427;

	[Cpp2IlInjected.Token(Token = "0x4003D97")]
	public const short RedTorch = 428;

	[Cpp2IlInjected.Token(Token = "0x4003D98")]
	public const short GreenTorch = 429;

	[Cpp2IlInjected.Token(Token = "0x4003D99")]
	public const short PurpleTorch = 430;

	[Cpp2IlInjected.Token(Token = "0x4003D9A")]
	public const short WhiteTorch = 431;

	[Cpp2IlInjected.Token(Token = "0x4003D9B")]
	public const short YellowTorch = 432;

	[Cpp2IlInjected.Token(Token = "0x4003D9C")]
	public const short DemonTorch = 433;

	[Cpp2IlInjected.Token(Token = "0x4003D9D")]
	public const short ClockworkAssaultRifle = 434;

	[Cpp2IlInjected.Token(Token = "0x4003D9E")]
	public const short CobaltRepeater = 435;

	[Cpp2IlInjected.Token(Token = "0x4003D9F")]
	public const short MythrilRepeater = 436;

	[Cpp2IlInjected.Token(Token = "0x4003DA0")]
	public const short DualHook = 437;

	[Cpp2IlInjected.Token(Token = "0x4003DA1")]
	public const short StarStatue = 438;

	[Cpp2IlInjected.Token(Token = "0x4003DA2")]
	public const short SwordStatue = 439;

	[Cpp2IlInjected.Token(Token = "0x4003DA3")]
	public const short SlimeStatue = 440;

	[Cpp2IlInjected.Token(Token = "0x4003DA4")]
	public const short GoblinStatue = 441;

	[Cpp2IlInjected.Token(Token = "0x4003DA5")]
	public const short ShieldStatue = 442;

	[Cpp2IlInjected.Token(Token = "0x4003DA6")]
	public const short BatStatue = 443;

	[Cpp2IlInjected.Token(Token = "0x4003DA7")]
	public const short FishStatue = 444;

	[Cpp2IlInjected.Token(Token = "0x4003DA8")]
	public const short BunnyStatue = 445;

	[Cpp2IlInjected.Token(Token = "0x4003DA9")]
	public const short SkeletonStatue = 446;

	[Cpp2IlInjected.Token(Token = "0x4003DAA")]
	public const short ReaperStatue = 447;

	[Cpp2IlInjected.Token(Token = "0x4003DAB")]
	public const short WomanStatue = 448;

	[Cpp2IlInjected.Token(Token = "0x4003DAC")]
	public const short ImpStatue = 449;

	[Cpp2IlInjected.Token(Token = "0x4003DAD")]
	public const short GargoyleStatue = 450;

	[Cpp2IlInjected.Token(Token = "0x4003DAE")]
	public const short GloomStatue = 451;

	[Cpp2IlInjected.Token(Token = "0x4003DAF")]
	public const short HornetStatue = 452;

	[Cpp2IlInjected.Token(Token = "0x4003DB0")]
	public const short BombStatue = 453;

	[Cpp2IlInjected.Token(Token = "0x4003DB1")]
	public const short CrabStatue = 454;

	[Cpp2IlInjected.Token(Token = "0x4003DB2")]
	public const short HammerStatue = 455;

	[Cpp2IlInjected.Token(Token = "0x4003DB3")]
	public const short PotionStatue = 456;

	[Cpp2IlInjected.Token(Token = "0x4003DB4")]
	public const short SpearStatue = 457;

	[Cpp2IlInjected.Token(Token = "0x4003DB5")]
	public const short CrossStatue = 458;

	[Cpp2IlInjected.Token(Token = "0x4003DB6")]
	public const short JellyfishStatue = 459;

	[Cpp2IlInjected.Token(Token = "0x4003DB7")]
	public const short BowStatue = 460;

	[Cpp2IlInjected.Token(Token = "0x4003DB8")]
	public const short BoomerangStatue = 461;

	[Cpp2IlInjected.Token(Token = "0x4003DB9")]
	public const short BootStatue = 462;

	[Cpp2IlInjected.Token(Token = "0x4003DBA")]
	public const short ChestStatue = 463;

	[Cpp2IlInjected.Token(Token = "0x4003DBB")]
	public const short BirdStatue = 464;

	[Cpp2IlInjected.Token(Token = "0x4003DBC")]
	public const short AxeStatue = 465;

	[Cpp2IlInjected.Token(Token = "0x4003DBD")]
	public const short CorruptStatue = 466;

	[Cpp2IlInjected.Token(Token = "0x4003DBE")]
	public const short TreeStatue = 467;

	[Cpp2IlInjected.Token(Token = "0x4003DBF")]
	public const short AnvilStatue = 468;

	[Cpp2IlInjected.Token(Token = "0x4003DC0")]
	public const short PickaxeStatue = 469;

	[Cpp2IlInjected.Token(Token = "0x4003DC1")]
	public const short MushroomStatue = 470;

	[Cpp2IlInjected.Token(Token = "0x4003DC2")]
	public const short EyeballStatue = 471;

	[Cpp2IlInjected.Token(Token = "0x4003DC3")]
	public const short PillarStatue = 472;

	[Cpp2IlInjected.Token(Token = "0x4003DC4")]
	public const short HeartStatue = 473;

	[Cpp2IlInjected.Token(Token = "0x4003DC5")]
	public const short PotStatue = 474;

	[Cpp2IlInjected.Token(Token = "0x4003DC6")]
	public const short SunflowerStatue = 475;

	[Cpp2IlInjected.Token(Token = "0x4003DC7")]
	public const short KingStatue = 476;

	[Cpp2IlInjected.Token(Token = "0x4003DC8")]
	public const short QueenStatue = 477;

	[Cpp2IlInjected.Token(Token = "0x4003DC9")]
	public const short PiranhaStatue = 478;

	[Cpp2IlInjected.Token(Token = "0x4003DCA")]
	public const short PlankedWall = 479;

	[Cpp2IlInjected.Token(Token = "0x4003DCB")]
	public const short WoodenBeam = 480;

	[Cpp2IlInjected.Token(Token = "0x4003DCC")]
	public const short AdamantiteRepeater = 481;

	[Cpp2IlInjected.Token(Token = "0x4003DCD")]
	public const short AdamantiteSword = 482;

	[Cpp2IlInjected.Token(Token = "0x4003DCE")]
	public const short CobaltSword = 483;

	[Cpp2IlInjected.Token(Token = "0x4003DCF")]
	public const short MythrilSword = 484;

	[Cpp2IlInjected.Token(Token = "0x4003DD0")]
	public const short MoonCharm = 485;

	[Cpp2IlInjected.Token(Token = "0x4003DD1")]
	public const short Ruler = 486;

	[Cpp2IlInjected.Token(Token = "0x4003DD2")]
	public const short CrystalBall = 487;

	[Cpp2IlInjected.Token(Token = "0x4003DD3")]
	public const short DiscoBall = 488;

	[Cpp2IlInjected.Token(Token = "0x4003DD4")]
	public const short SorcererEmblem = 489;

	[Cpp2IlInjected.Token(Token = "0x4003DD5")]
	public const short WarriorEmblem = 490;

	[Cpp2IlInjected.Token(Token = "0x4003DD6")]
	public const short RangerEmblem = 491;

	[Cpp2IlInjected.Token(Token = "0x4003DD7")]
	public const short DemonWings = 492;

	[Cpp2IlInjected.Token(Token = "0x4003DD8")]
	public const short AngelWings = 493;

	[Cpp2IlInjected.Token(Token = "0x4003DD9")]
	public const short MagicalHarp = 494;

	[Cpp2IlInjected.Token(Token = "0x4003DDA")]
	public const short RainbowRod = 495;

	[Cpp2IlInjected.Token(Token = "0x4003DDB")]
	public const short IceRod = 496;

	[Cpp2IlInjected.Token(Token = "0x4003DDC")]
	public const short NeptunesShell = 497;

	[Cpp2IlInjected.Token(Token = "0x4003DDD")]
	public const short Mannequin = 498;

	[Cpp2IlInjected.Token(Token = "0x4003DDE")]
	public const short GreaterHealingPotion = 499;

	[Cpp2IlInjected.Token(Token = "0x4003DDF")]
	public const short GreaterManaPotion = 500;

	[Cpp2IlInjected.Token(Token = "0x4003DE0")]
	public const short PixieDust = 501;

	[Cpp2IlInjected.Token(Token = "0x4003DE1")]
	public const short CrystalShard = 502;

	[Cpp2IlInjected.Token(Token = "0x4003DE2")]
	public const short ClownHat = 503;

	[Cpp2IlInjected.Token(Token = "0x4003DE3")]
	public const short ClownShirt = 504;

	[Cpp2IlInjected.Token(Token = "0x4003DE4")]
	public const short ClownPants = 505;

	[Cpp2IlInjected.Token(Token = "0x4003DE5")]
	public const short Flamethrower = 506;

	[Cpp2IlInjected.Token(Token = "0x4003DE6")]
	public const short Bell = 507;

	[Cpp2IlInjected.Token(Token = "0x4003DE7")]
	public const short Harp = 508;

	[Cpp2IlInjected.Token(Token = "0x4003DE8")]
	public const short Wrench = 509;

	[Cpp2IlInjected.Token(Token = "0x4003DE9")]
	public const short WireCutter = 510;

	[Cpp2IlInjected.Token(Token = "0x4003DEA")]
	public const short ActiveStoneBlock = 511;

	[Cpp2IlInjected.Token(Token = "0x4003DEB")]
	public const short InactiveStoneBlock = 512;

	[Cpp2IlInjected.Token(Token = "0x4003DEC")]
	public const short Lever = 513;

	[Cpp2IlInjected.Token(Token = "0x4003DED")]
	public const short LaserRifle = 514;

	[Cpp2IlInjected.Token(Token = "0x4003DEE")]
	public const short CrystalBullet = 515;

	[Cpp2IlInjected.Token(Token = "0x4003DEF")]
	public const short HolyArrow = 516;

	[Cpp2IlInjected.Token(Token = "0x4003DF0")]
	public const short MagicDagger = 517;

	[Cpp2IlInjected.Token(Token = "0x4003DF1")]
	public const short CrystalStorm = 518;

	[Cpp2IlInjected.Token(Token = "0x4003DF2")]
	public const short CursedFlames = 519;

	[Cpp2IlInjected.Token(Token = "0x4003DF3")]
	public const short SoulofLight = 520;

	[Cpp2IlInjected.Token(Token = "0x4003DF4")]
	public const short SoulofNight = 521;

	[Cpp2IlInjected.Token(Token = "0x4003DF5")]
	public const short CursedFlame = 522;

	[Cpp2IlInjected.Token(Token = "0x4003DF6")]
	public const short CursedTorch = 523;

	[Cpp2IlInjected.Token(Token = "0x4003DF7")]
	public const short AdamantiteForge = 524;

	[Cpp2IlInjected.Token(Token = "0x4003DF8")]
	public const short MythrilAnvil = 525;

	[Cpp2IlInjected.Token(Token = "0x4003DF9")]
	public const short UnicornHorn = 526;

	[Cpp2IlInjected.Token(Token = "0x4003DFA")]
	public const short DarkShard = 527;

	[Cpp2IlInjected.Token(Token = "0x4003DFB")]
	public const short LightShard = 528;

	[Cpp2IlInjected.Token(Token = "0x4003DFC")]
	public const short RedPressurePlate = 529;

	[Cpp2IlInjected.Token(Token = "0x4003DFD")]
	public const short Wire = 530;

	[Cpp2IlInjected.Token(Token = "0x4003DFE")]
	public const short SpellTome = 531;

	[Cpp2IlInjected.Token(Token = "0x4003DFF")]
	public const short StarCloak = 532;

	[Cpp2IlInjected.Token(Token = "0x4003E00")]
	public const short Megashark = 533;

	[Cpp2IlInjected.Token(Token = "0x4003E01")]
	public const short Shotgun = 534;

	[Cpp2IlInjected.Token(Token = "0x4003E02")]
	public const short PhilosophersStone = 535;

	[Cpp2IlInjected.Token(Token = "0x4003E03")]
	public const short TitanGlove = 536;

	[Cpp2IlInjected.Token(Token = "0x4003E04")]
	public const short CobaltNaginata = 537;

	[Cpp2IlInjected.Token(Token = "0x4003E05")]
	public const short Switch = 538;

	[Cpp2IlInjected.Token(Token = "0x4003E06")]
	public const short DartTrap = 539;

	[Cpp2IlInjected.Token(Token = "0x4003E07")]
	public const short Boulder = 540;

	[Cpp2IlInjected.Token(Token = "0x4003E08")]
	public const short GreenPressurePlate = 541;

	[Cpp2IlInjected.Token(Token = "0x4003E09")]
	public const short GrayPressurePlate = 542;

	[Cpp2IlInjected.Token(Token = "0x4003E0A")]
	public const short BrownPressurePlate = 543;

	[Cpp2IlInjected.Token(Token = "0x4003E0B")]
	public const short MechanicalEye = 544;

	[Cpp2IlInjected.Token(Token = "0x4003E0C")]
	public const short CursedArrow = 545;

	[Cpp2IlInjected.Token(Token = "0x4003E0D")]
	public const short CursedBullet = 546;

	[Cpp2IlInjected.Token(Token = "0x4003E0E")]
	public const short SoulofFright = 547;

	[Cpp2IlInjected.Token(Token = "0x4003E0F")]
	public const short SoulofMight = 548;

	[Cpp2IlInjected.Token(Token = "0x4003E10")]
	public const short SoulofSight = 549;

	[Cpp2IlInjected.Token(Token = "0x4003E11")]
	public const short Gungnir = 550;

	[Cpp2IlInjected.Token(Token = "0x4003E12")]
	public const short HallowedPlateMail = 551;

	[Cpp2IlInjected.Token(Token = "0x4003E13")]
	public const short HallowedGreaves = 552;

	[Cpp2IlInjected.Token(Token = "0x4003E14")]
	public const short HallowedHelmet = 553;

	[Cpp2IlInjected.Token(Token = "0x4003E15")]
	public const short CrossNecklace = 554;

	[Cpp2IlInjected.Token(Token = "0x4003E16")]
	public const short ManaFlower = 555;

	[Cpp2IlInjected.Token(Token = "0x4003E17")]
	public const short MechanicalWorm = 556;

	[Cpp2IlInjected.Token(Token = "0x4003E18")]
	public const short MechanicalSkull = 557;

	[Cpp2IlInjected.Token(Token = "0x4003E19")]
	public const short HallowedHeadgear = 558;

	[Cpp2IlInjected.Token(Token = "0x4003E1A")]
	public const short HallowedMask = 559;

	[Cpp2IlInjected.Token(Token = "0x4003E1B")]
	public const short SlimeCrown = 560;

	[Cpp2IlInjected.Token(Token = "0x4003E1C")]
	public const short LightDisc = 561;

	[Cpp2IlInjected.Token(Token = "0x4003E1D")]
	public const short MusicBoxOverworldDay = 562;

	[Cpp2IlInjected.Token(Token = "0x4003E1E")]
	public const short MusicBoxEerie = 563;

	[Cpp2IlInjected.Token(Token = "0x4003E1F")]
	public const short MusicBoxNight = 564;

	[Cpp2IlInjected.Token(Token = "0x4003E20")]
	public const short MusicBoxTitle = 565;

	[Cpp2IlInjected.Token(Token = "0x4003E21")]
	public const short MusicBoxUnderground = 566;

	[Cpp2IlInjected.Token(Token = "0x4003E22")]
	public const short MusicBoxBoss1 = 567;

	[Cpp2IlInjected.Token(Token = "0x4003E23")]
	public const short MusicBoxJungle = 568;

	[Cpp2IlInjected.Token(Token = "0x4003E24")]
	public const short MusicBoxCorruption = 569;

	[Cpp2IlInjected.Token(Token = "0x4003E25")]
	public const short MusicBoxUndergroundCorruption = 570;

	[Cpp2IlInjected.Token(Token = "0x4003E26")]
	public const short MusicBoxTheHallow = 571;

	[Cpp2IlInjected.Token(Token = "0x4003E27")]
	public const short MusicBoxBoss2 = 572;

	[Cpp2IlInjected.Token(Token = "0x4003E28")]
	public const short MusicBoxUndergroundHallow = 573;

	[Cpp2IlInjected.Token(Token = "0x4003E29")]
	public const short MusicBoxBoss3 = 574;

	[Cpp2IlInjected.Token(Token = "0x4003E2A")]
	public const short SoulofFlight = 575;

	[Cpp2IlInjected.Token(Token = "0x4003E2B")]
	public const short MusicBox = 576;

	[Cpp2IlInjected.Token(Token = "0x4003E2C")]
	public const short DemoniteBrick = 577;

	[Cpp2IlInjected.Token(Token = "0x4003E2D")]
	public const short HallowedRepeater = 578;

	[Cpp2IlInjected.Token(Token = "0x4003E2E")]
	public const short Drax = 579;

	[Cpp2IlInjected.Token(Token = "0x4003E2F")]
	public const short Explosives = 580;

	[Cpp2IlInjected.Token(Token = "0x4003E30")]
	public const short InletPump = 581;

	[Cpp2IlInjected.Token(Token = "0x4003E31")]
	public const short OutletPump = 582;

	[Cpp2IlInjected.Token(Token = "0x4003E32")]
	public const short Timer1Second = 583;

	[Cpp2IlInjected.Token(Token = "0x4003E33")]
	public const short Timer3Second = 584;

	[Cpp2IlInjected.Token(Token = "0x4003E34")]
	public const short Timer5Second = 585;

	[Cpp2IlInjected.Token(Token = "0x4003E35")]
	public const short CandyCaneBlock = 586;

	[Cpp2IlInjected.Token(Token = "0x4003E36")]
	public const short CandyCaneWall = 587;

	[Cpp2IlInjected.Token(Token = "0x4003E37")]
	public const short SantaHat = 588;

	[Cpp2IlInjected.Token(Token = "0x4003E38")]
	public const short SantaShirt = 589;

	[Cpp2IlInjected.Token(Token = "0x4003E39")]
	public const short SantaPants = 590;

	[Cpp2IlInjected.Token(Token = "0x4003E3A")]
	public const short GreenCandyCaneBlock = 591;

	[Cpp2IlInjected.Token(Token = "0x4003E3B")]
	public const short GreenCandyCaneWall = 592;

	[Cpp2IlInjected.Token(Token = "0x4003E3C")]
	public const short SnowBlock = 593;

	[Cpp2IlInjected.Token(Token = "0x4003E3D")]
	public const short SnowBrick = 594;

	[Cpp2IlInjected.Token(Token = "0x4003E3E")]
	public const short SnowBrickWall = 595;

	[Cpp2IlInjected.Token(Token = "0x4003E3F")]
	public const short BlueLight = 596;

	[Cpp2IlInjected.Token(Token = "0x4003E40")]
	public const short RedLight = 597;

	[Cpp2IlInjected.Token(Token = "0x4003E41")]
	public const short GreenLight = 598;

	[Cpp2IlInjected.Token(Token = "0x4003E42")]
	public const short BluePresent = 599;

	[Cpp2IlInjected.Token(Token = "0x4003E43")]
	public const short GreenPresent = 600;

	[Cpp2IlInjected.Token(Token = "0x4003E44")]
	public const short YellowPresent = 601;

	[Cpp2IlInjected.Token(Token = "0x4003E45")]
	public const short SnowGlobe = 602;

	[Cpp2IlInjected.Token(Token = "0x4003E46")]
	public const short Carrot = 603;

	[Cpp2IlInjected.Token(Token = "0x4003E47")]
	public const short AdamantiteBeam = 604;

	[Cpp2IlInjected.Token(Token = "0x4003E48")]
	public const short AdamantiteBeamWall = 605;

	[Cpp2IlInjected.Token(Token = "0x4003E49")]
	public const short DemoniteBrickWall = 606;

	[Cpp2IlInjected.Token(Token = "0x4003E4A")]
	public const short SandstoneBrick = 607;

	[Cpp2IlInjected.Token(Token = "0x4003E4B")]
	public const short SandstoneBrickWall = 608;

	[Cpp2IlInjected.Token(Token = "0x4003E4C")]
	public const short EbonstoneBrick = 609;

	[Cpp2IlInjected.Token(Token = "0x4003E4D")]
	public const short EbonstoneBrickWall = 610;

	[Cpp2IlInjected.Token(Token = "0x4003E4E")]
	public const short RedStucco = 611;

	[Cpp2IlInjected.Token(Token = "0x4003E4F")]
	public const short YellowStucco = 612;

	[Cpp2IlInjected.Token(Token = "0x4003E50")]
	public const short GreenStucco = 613;

	[Cpp2IlInjected.Token(Token = "0x4003E51")]
	public const short GrayStucco = 614;

	[Cpp2IlInjected.Token(Token = "0x4003E52")]
	public const short RedStuccoWall = 615;

	[Cpp2IlInjected.Token(Token = "0x4003E53")]
	public const short YellowStuccoWall = 616;

	[Cpp2IlInjected.Token(Token = "0x4003E54")]
	public const short GreenStuccoWall = 617;

	[Cpp2IlInjected.Token(Token = "0x4003E55")]
	public const short GrayStuccoWall = 618;

	[Cpp2IlInjected.Token(Token = "0x4003E56")]
	public const short Ebonwood = 619;

	[Cpp2IlInjected.Token(Token = "0x4003E57")]
	public const short RichMahogany = 620;

	[Cpp2IlInjected.Token(Token = "0x4003E58")]
	public const short Pearlwood = 621;

	[Cpp2IlInjected.Token(Token = "0x4003E59")]
	public const short EbonwoodWall = 622;

	[Cpp2IlInjected.Token(Token = "0x4003E5A")]
	public const short RichMahoganyWall = 623;

	[Cpp2IlInjected.Token(Token = "0x4003E5B")]
	public const short PearlwoodWall = 624;

	[Cpp2IlInjected.Token(Token = "0x4003E5C")]
	public const short EbonwoodChest = 625;

	[Cpp2IlInjected.Token(Token = "0x4003E5D")]
	public const short RichMahoganyChest = 626;

	[Cpp2IlInjected.Token(Token = "0x4003E5E")]
	public const short PearlwoodChest = 627;

	[Cpp2IlInjected.Token(Token = "0x4003E5F")]
	public const short EbonwoodChair = 628;

	[Cpp2IlInjected.Token(Token = "0x4003E60")]
	public const short RichMahoganyChair = 629;

	[Cpp2IlInjected.Token(Token = "0x4003E61")]
	public const short PearlwoodChair = 630;

	[Cpp2IlInjected.Token(Token = "0x4003E62")]
	public const short EbonwoodPlatform = 631;

	[Cpp2IlInjected.Token(Token = "0x4003E63")]
	public const short RichMahoganyPlatform = 632;

	[Cpp2IlInjected.Token(Token = "0x4003E64")]
	public const short PearlwoodPlatform = 633;

	[Cpp2IlInjected.Token(Token = "0x4003E65")]
	public const short BonePlatform = 634;

	[Cpp2IlInjected.Token(Token = "0x4003E66")]
	public const short EbonwoodWorkBench = 635;

	[Cpp2IlInjected.Token(Token = "0x4003E67")]
	public const short RichMahoganyWorkBench = 636;

	[Cpp2IlInjected.Token(Token = "0x4003E68")]
	public const short PearlwoodWorkBench = 637;

	[Cpp2IlInjected.Token(Token = "0x4003E69")]
	public const short EbonwoodTable = 638;

	[Cpp2IlInjected.Token(Token = "0x4003E6A")]
	public const short RichMahoganyTable = 639;

	[Cpp2IlInjected.Token(Token = "0x4003E6B")]
	public const short PearlwoodTable = 640;

	[Cpp2IlInjected.Token(Token = "0x4003E6C")]
	public const short EbonwoodPiano = 641;

	[Cpp2IlInjected.Token(Token = "0x4003E6D")]
	public const short RichMahoganyPiano = 642;

	[Cpp2IlInjected.Token(Token = "0x4003E6E")]
	public const short PearlwoodPiano = 643;

	[Cpp2IlInjected.Token(Token = "0x4003E6F")]
	public const short EbonwoodBed = 644;

	[Cpp2IlInjected.Token(Token = "0x4003E70")]
	public const short RichMahoganyBed = 645;

	[Cpp2IlInjected.Token(Token = "0x4003E71")]
	public const short PearlwoodBed = 646;

	[Cpp2IlInjected.Token(Token = "0x4003E72")]
	public const short EbonwoodDresser = 647;

	[Cpp2IlInjected.Token(Token = "0x4003E73")]
	public const short RichMahoganyDresser = 648;

	[Cpp2IlInjected.Token(Token = "0x4003E74")]
	public const short PearlwoodDresser = 649;

	[Cpp2IlInjected.Token(Token = "0x4003E75")]
	public const short EbonwoodDoor = 650;

	[Cpp2IlInjected.Token(Token = "0x4003E76")]
	public const short RichMahoganyDoor = 651;

	[Cpp2IlInjected.Token(Token = "0x4003E77")]
	public const short PearlwoodDoor = 652;

	[Cpp2IlInjected.Token(Token = "0x4003E78")]
	public const short EbonwoodSword = 653;

	[Cpp2IlInjected.Token(Token = "0x4003E79")]
	public const short EbonwoodHammer = 654;

	[Cpp2IlInjected.Token(Token = "0x4003E7A")]
	public const short EbonwoodBow = 655;

	[Cpp2IlInjected.Token(Token = "0x4003E7B")]
	public const short RichMahoganySword = 656;

	[Cpp2IlInjected.Token(Token = "0x4003E7C")]
	public const short RichMahoganyHammer = 657;

	[Cpp2IlInjected.Token(Token = "0x4003E7D")]
	public const short RichMahoganyBow = 658;

	[Cpp2IlInjected.Token(Token = "0x4003E7E")]
	public const short PearlwoodSword = 659;

	[Cpp2IlInjected.Token(Token = "0x4003E7F")]
	public const short PearlwoodHammer = 660;

	[Cpp2IlInjected.Token(Token = "0x4003E80")]
	public const short PearlwoodBow = 661;

	[Cpp2IlInjected.Token(Token = "0x4003E81")]
	public const short RainbowBrick = 662;

	[Cpp2IlInjected.Token(Token = "0x4003E82")]
	public const short RainbowBrickWall = 663;

	[Cpp2IlInjected.Token(Token = "0x4003E83")]
	public const short IceBlock = 664;

	[Cpp2IlInjected.Token(Token = "0x4003E84")]
	public const short RedsWings = 665;

	[Cpp2IlInjected.Token(Token = "0x4003E85")]
	public const short RedsHelmet = 666;

	[Cpp2IlInjected.Token(Token = "0x4003E86")]
	public const short RedsBreastplate = 667;

	[Cpp2IlInjected.Token(Token = "0x4003E87")]
	public const short RedsLeggings = 668;

	[Cpp2IlInjected.Token(Token = "0x4003E88")]
	public const short Fish = 669;

	[Cpp2IlInjected.Token(Token = "0x4003E89")]
	public const short IceBoomerang = 670;

	[Cpp2IlInjected.Token(Token = "0x4003E8A")]
	public const short Keybrand = 671;

	[Cpp2IlInjected.Token(Token = "0x4003E8B")]
	public const short Cutlass = 672;

	[Cpp2IlInjected.Token(Token = "0x4003E8C")]
	public const short BorealWoodWorkBench = 673;

	[Cpp2IlInjected.Token(Token = "0x4003E8D")]
	public const short TrueExcalibur = 674;

	[Cpp2IlInjected.Token(Token = "0x4003E8E")]
	public const short TrueNightsEdge = 675;

	[Cpp2IlInjected.Token(Token = "0x4003E8F")]
	public const short Frostbrand = 676;

	[Cpp2IlInjected.Token(Token = "0x4003E90")]
	public const short BorealWoodTable = 677;

	[Cpp2IlInjected.Token(Token = "0x4003E91")]
	public const short RedPotion = 678;

	[Cpp2IlInjected.Token(Token = "0x4003E92")]
	public const short TacticalShotgun = 679;

	[Cpp2IlInjected.Token(Token = "0x4003E93")]
	public const short IvyChest = 680;

	[Cpp2IlInjected.Token(Token = "0x4003E94")]
	public const short IceChest = 681;

	[Cpp2IlInjected.Token(Token = "0x4003E95")]
	public const short Marrow = 682;

	[Cpp2IlInjected.Token(Token = "0x4003E96")]
	public const short UnholyTrident = 683;

	[Cpp2IlInjected.Token(Token = "0x4003E97")]
	public const short FrostHelmet = 684;

	[Cpp2IlInjected.Token(Token = "0x4003E98")]
	public const short FrostBreastplate = 685;

	[Cpp2IlInjected.Token(Token = "0x4003E99")]
	public const short FrostLeggings = 686;

	[Cpp2IlInjected.Token(Token = "0x4003E9A")]
	public const short TinHelmet = 687;

	[Cpp2IlInjected.Token(Token = "0x4003E9B")]
	public const short TinChainmail = 688;

	[Cpp2IlInjected.Token(Token = "0x4003E9C")]
	public const short TinGreaves = 689;

	[Cpp2IlInjected.Token(Token = "0x4003E9D")]
	public const short LeadHelmet = 690;

	[Cpp2IlInjected.Token(Token = "0x4003E9E")]
	public const short LeadChainmail = 691;

	[Cpp2IlInjected.Token(Token = "0x4003E9F")]
	public const short LeadGreaves = 692;

	[Cpp2IlInjected.Token(Token = "0x4003EA0")]
	public const short TungstenHelmet = 693;

	[Cpp2IlInjected.Token(Token = "0x4003EA1")]
	public const short TungstenChainmail = 694;

	[Cpp2IlInjected.Token(Token = "0x4003EA2")]
	public const short TungstenGreaves = 695;

	[Cpp2IlInjected.Token(Token = "0x4003EA3")]
	public const short PlatinumHelmet = 696;

	[Cpp2IlInjected.Token(Token = "0x4003EA4")]
	public const short PlatinumChainmail = 697;

	[Cpp2IlInjected.Token(Token = "0x4003EA5")]
	public const short PlatinumGreaves = 698;

	[Cpp2IlInjected.Token(Token = "0x4003EA6")]
	public const short TinOre = 699;

	[Cpp2IlInjected.Token(Token = "0x4003EA7")]
	public const short LeadOre = 700;

	[Cpp2IlInjected.Token(Token = "0x4003EA8")]
	public const short TungstenOre = 701;

	[Cpp2IlInjected.Token(Token = "0x4003EA9")]
	public const short PlatinumOre = 702;

	[Cpp2IlInjected.Token(Token = "0x4003EAA")]
	public const short TinBar = 703;

	[Cpp2IlInjected.Token(Token = "0x4003EAB")]
	public const short LeadBar = 704;

	[Cpp2IlInjected.Token(Token = "0x4003EAC")]
	public const short TungstenBar = 705;

	[Cpp2IlInjected.Token(Token = "0x4003EAD")]
	public const short PlatinumBar = 706;

	[Cpp2IlInjected.Token(Token = "0x4003EAE")]
	public const short TinWatch = 707;

	[Cpp2IlInjected.Token(Token = "0x4003EAF")]
	public const short TungstenWatch = 708;

	[Cpp2IlInjected.Token(Token = "0x4003EB0")]
	public const short PlatinumWatch = 709;

	[Cpp2IlInjected.Token(Token = "0x4003EB1")]
	public const short TinChandelier = 710;

	[Cpp2IlInjected.Token(Token = "0x4003EB2")]
	public const short TungstenChandelier = 711;

	[Cpp2IlInjected.Token(Token = "0x4003EB3")]
	public const short PlatinumChandelier = 712;

	[Cpp2IlInjected.Token(Token = "0x4003EB4")]
	public const short PlatinumCandle = 713;

	[Cpp2IlInjected.Token(Token = "0x4003EB5")]
	public const short PlatinumCandelabra = 714;

	[Cpp2IlInjected.Token(Token = "0x4003EB6")]
	public const short PlatinumCrown = 715;

	[Cpp2IlInjected.Token(Token = "0x4003EB7")]
	public const short LeadAnvil = 716;

	[Cpp2IlInjected.Token(Token = "0x4003EB8")]
	public const short TinBrick = 717;

	[Cpp2IlInjected.Token(Token = "0x4003EB9")]
	public const short TungstenBrick = 718;

	[Cpp2IlInjected.Token(Token = "0x4003EBA")]
	public const short PlatinumBrick = 719;

	[Cpp2IlInjected.Token(Token = "0x4003EBB")]
	public const short TinBrickWall = 720;

	[Cpp2IlInjected.Token(Token = "0x4003EBC")]
	public const short TungstenBrickWall = 721;

	[Cpp2IlInjected.Token(Token = "0x4003EBD")]
	public const short PlatinumBrickWall = 722;

	[Cpp2IlInjected.Token(Token = "0x4003EBE")]
	public const short BeamSword = 723;

	[Cpp2IlInjected.Token(Token = "0x4003EBF")]
	public const short IceBlade = 724;

	[Cpp2IlInjected.Token(Token = "0x4003EC0")]
	public const short IceBow = 725;

	[Cpp2IlInjected.Token(Token = "0x4003EC1")]
	public const short FrostStaff = 726;

	[Cpp2IlInjected.Token(Token = "0x4003EC2")]
	public const short WoodHelmet = 727;

	[Cpp2IlInjected.Token(Token = "0x4003EC3")]
	public const short WoodBreastplate = 728;

	[Cpp2IlInjected.Token(Token = "0x4003EC4")]
	public const short WoodGreaves = 729;

	[Cpp2IlInjected.Token(Token = "0x4003EC5")]
	public const short EbonwoodHelmet = 730;

	[Cpp2IlInjected.Token(Token = "0x4003EC6")]
	public const short EbonwoodBreastplate = 731;

	[Cpp2IlInjected.Token(Token = "0x4003EC7")]
	public const short EbonwoodGreaves = 732;

	[Cpp2IlInjected.Token(Token = "0x4003EC8")]
	public const short RichMahoganyHelmet = 733;

	[Cpp2IlInjected.Token(Token = "0x4003EC9")]
	public const short RichMahoganyBreastplate = 734;

	[Cpp2IlInjected.Token(Token = "0x4003ECA")]
	public const short RichMahoganyGreaves = 735;

	[Cpp2IlInjected.Token(Token = "0x4003ECB")]
	public const short PearlwoodHelmet = 736;

	[Cpp2IlInjected.Token(Token = "0x4003ECC")]
	public const short PearlwoodBreastplate = 737;

	[Cpp2IlInjected.Token(Token = "0x4003ECD")]
	public const short PearlwoodGreaves = 738;

	[Cpp2IlInjected.Token(Token = "0x4003ECE")]
	public const short AmethystStaff = 739;

	[Cpp2IlInjected.Token(Token = "0x4003ECF")]
	public const short TopazStaff = 740;

	[Cpp2IlInjected.Token(Token = "0x4003ED0")]
	public const short SapphireStaff = 741;

	[Cpp2IlInjected.Token(Token = "0x4003ED1")]
	public const short EmeraldStaff = 742;

	[Cpp2IlInjected.Token(Token = "0x4003ED2")]
	public const short RubyStaff = 743;

	[Cpp2IlInjected.Token(Token = "0x4003ED3")]
	public const short DiamondStaff = 744;

	[Cpp2IlInjected.Token(Token = "0x4003ED4")]
	public const short GrassWall = 745;

	[Cpp2IlInjected.Token(Token = "0x4003ED5")]
	public const short JungleWall = 746;

	[Cpp2IlInjected.Token(Token = "0x4003ED6")]
	public const short FlowerWall = 747;

	[Cpp2IlInjected.Token(Token = "0x4003ED7")]
	public const short Jetpack = 748;

	[Cpp2IlInjected.Token(Token = "0x4003ED8")]
	public const short ButterflyWings = 749;

	[Cpp2IlInjected.Token(Token = "0x4003ED9")]
	public const short CactusWall = 750;

	[Cpp2IlInjected.Token(Token = "0x4003EDA")]
	public const short Cloud = 751;

	[Cpp2IlInjected.Token(Token = "0x4003EDB")]
	public const short CloudWall = 752;

	[Cpp2IlInjected.Token(Token = "0x4003EDC")]
	public const short Seaweed = 753;

	[Cpp2IlInjected.Token(Token = "0x4003EDD")]
	public const short RuneHat = 754;

	[Cpp2IlInjected.Token(Token = "0x4003EDE")]
	public const short RuneRobe = 755;

	[Cpp2IlInjected.Token(Token = "0x4003EDF")]
	public const short MushroomSpear = 756;

	[Cpp2IlInjected.Token(Token = "0x4003EE0")]
	public const short TerraBlade = 757;

	[Cpp2IlInjected.Token(Token = "0x4003EE1")]
	public const short GrenadeLauncher = 758;

	[Cpp2IlInjected.Token(Token = "0x4003EE2")]
	public const short RocketLauncher = 759;

	[Cpp2IlInjected.Token(Token = "0x4003EE3")]
	public const short ProximityMineLauncher = 760;

	[Cpp2IlInjected.Token(Token = "0x4003EE4")]
	public const short FairyWings = 761;

	[Cpp2IlInjected.Token(Token = "0x4003EE5")]
	public const short SlimeBlock = 762;

	[Cpp2IlInjected.Token(Token = "0x4003EE6")]
	public const short FleshBlock = 763;

	[Cpp2IlInjected.Token(Token = "0x4003EE7")]
	public const short MushroomWall = 764;

	[Cpp2IlInjected.Token(Token = "0x4003EE8")]
	public const short RainCloud = 765;

	[Cpp2IlInjected.Token(Token = "0x4003EE9")]
	public const short BoneBlock = 766;

	[Cpp2IlInjected.Token(Token = "0x4003EEA")]
	public const short FrozenSlimeBlock = 767;

	[Cpp2IlInjected.Token(Token = "0x4003EEB")]
	public const short BoneBlockWall = 768;

	[Cpp2IlInjected.Token(Token = "0x4003EEC")]
	public const short SlimeBlockWall = 769;

	[Cpp2IlInjected.Token(Token = "0x4003EED")]
	public const short FleshBlockWall = 770;

	[Cpp2IlInjected.Token(Token = "0x4003EEE")]
	public const short RocketI = 771;

	[Cpp2IlInjected.Token(Token = "0x4003EEF")]
	public const short RocketII = 772;

	[Cpp2IlInjected.Token(Token = "0x4003EF0")]
	public const short RocketIII = 773;

	[Cpp2IlInjected.Token(Token = "0x4003EF1")]
	public const short RocketIV = 774;

	[Cpp2IlInjected.Token(Token = "0x4003EF2")]
	public const short AsphaltBlock = 775;

	[Cpp2IlInjected.Token(Token = "0x4003EF3")]
	public const short CobaltPickaxe = 776;

	[Cpp2IlInjected.Token(Token = "0x4003EF4")]
	public const short MythrilPickaxe = 777;

	[Cpp2IlInjected.Token(Token = "0x4003EF5")]
	public const short AdamantitePickaxe = 778;

	[Cpp2IlInjected.Token(Token = "0x4003EF6")]
	public const short Clentaminator = 779;

	[Cpp2IlInjected.Token(Token = "0x4003EF7")]
	public const short GreenSolution = 780;

	[Cpp2IlInjected.Token(Token = "0x4003EF8")]
	public const short BlueSolution = 781;

	[Cpp2IlInjected.Token(Token = "0x4003EF9")]
	public const short PurpleSolution = 782;

	[Cpp2IlInjected.Token(Token = "0x4003EFA")]
	public const short DarkBlueSolution = 783;

	[Cpp2IlInjected.Token(Token = "0x4003EFB")]
	public const short RedSolution = 784;

	[Cpp2IlInjected.Token(Token = "0x4003EFC")]
	public const short HarpyWings = 785;

	[Cpp2IlInjected.Token(Token = "0x4003EFD")]
	public const short BoneWings = 786;

	[Cpp2IlInjected.Token(Token = "0x4003EFE")]
	public const short Hammush = 787;

	[Cpp2IlInjected.Token(Token = "0x4003EFF")]
	public const short NettleBurst = 788;

	[Cpp2IlInjected.Token(Token = "0x4003F00")]
	public const short AnkhBanner = 789;

	[Cpp2IlInjected.Token(Token = "0x4003F01")]
	public const short SnakeBanner = 790;

	[Cpp2IlInjected.Token(Token = "0x4003F02")]
	public const short OmegaBanner = 791;

	[Cpp2IlInjected.Token(Token = "0x4003F03")]
	public const short CrimsonHelmet = 792;

	[Cpp2IlInjected.Token(Token = "0x4003F04")]
	public const short CrimsonScalemail = 793;

	[Cpp2IlInjected.Token(Token = "0x4003F05")]
	public const short CrimsonGreaves = 794;

	[Cpp2IlInjected.Token(Token = "0x4003F06")]
	public const short BloodButcherer = 795;

	[Cpp2IlInjected.Token(Token = "0x4003F07")]
	public const short TendonBow = 796;

	[Cpp2IlInjected.Token(Token = "0x4003F08")]
	public const short FleshGrinder = 797;

	[Cpp2IlInjected.Token(Token = "0x4003F09")]
	public const short DeathbringerPickaxe = 798;

	[Cpp2IlInjected.Token(Token = "0x4003F0A")]
	public const short BloodLustCluster = 799;

	[Cpp2IlInjected.Token(Token = "0x4003F0B")]
	public const short TheUndertaker = 800;

	[Cpp2IlInjected.Token(Token = "0x4003F0C")]
	public const short TheMeatball = 801;

	[Cpp2IlInjected.Token(Token = "0x4003F0D")]
	public const short TheRottedFork = 802;

	[Cpp2IlInjected.Token(Token = "0x4003F0E")]
	public const short EskimoHood = 803;

	[Cpp2IlInjected.Token(Token = "0x4003F0F")]
	public const short EskimoCoat = 804;

	[Cpp2IlInjected.Token(Token = "0x4003F10")]
	public const short EskimoPants = 805;

	[Cpp2IlInjected.Token(Token = "0x4003F11")]
	public const short LivingWoodChair = 806;

	[Cpp2IlInjected.Token(Token = "0x4003F12")]
	public const short CactusChair = 807;

	[Cpp2IlInjected.Token(Token = "0x4003F13")]
	public const short BoneChair = 808;

	[Cpp2IlInjected.Token(Token = "0x4003F14")]
	public const short FleshChair = 809;

	[Cpp2IlInjected.Token(Token = "0x4003F15")]
	public const short MushroomChair = 810;

	[Cpp2IlInjected.Token(Token = "0x4003F16")]
	public const short BoneWorkBench = 811;

	[Cpp2IlInjected.Token(Token = "0x4003F17")]
	public const short CactusWorkBench = 812;

	[Cpp2IlInjected.Token(Token = "0x4003F18")]
	public const short FleshWorkBench = 813;

	[Cpp2IlInjected.Token(Token = "0x4003F19")]
	public const short MushroomWorkBench = 814;

	[Cpp2IlInjected.Token(Token = "0x4003F1A")]
	public const short SlimeWorkBench = 815;

	[Cpp2IlInjected.Token(Token = "0x4003F1B")]
	public const short CactusDoor = 816;

	[Cpp2IlInjected.Token(Token = "0x4003F1C")]
	public const short FleshDoor = 817;

	[Cpp2IlInjected.Token(Token = "0x4003F1D")]
	public const short MushroomDoor = 818;

	[Cpp2IlInjected.Token(Token = "0x4003F1E")]
	public const short LivingWoodDoor = 819;

	[Cpp2IlInjected.Token(Token = "0x4003F1F")]
	public const short BoneDoor = 820;

	[Cpp2IlInjected.Token(Token = "0x4003F20")]
	public const short FlameWings = 821;

	[Cpp2IlInjected.Token(Token = "0x4003F21")]
	public const short FrozenWings = 822;

	[Cpp2IlInjected.Token(Token = "0x4003F22")]
	public const short GhostWings = 823;

	[Cpp2IlInjected.Token(Token = "0x4003F23")]
	public const short SunplateBlock = 824;

	[Cpp2IlInjected.Token(Token = "0x4003F24")]
	public const short DiscWall = 825;

	[Cpp2IlInjected.Token(Token = "0x4003F25")]
	public const short SkywareChair = 826;

	[Cpp2IlInjected.Token(Token = "0x4003F26")]
	public const short BoneTable = 827;

	[Cpp2IlInjected.Token(Token = "0x4003F27")]
	public const short FleshTable = 828;

	[Cpp2IlInjected.Token(Token = "0x4003F28")]
	public const short LivingWoodTable = 829;

	[Cpp2IlInjected.Token(Token = "0x4003F29")]
	public const short SkywareTable = 830;

	[Cpp2IlInjected.Token(Token = "0x4003F2A")]
	public const short LivingWoodChest = 831;

	[Cpp2IlInjected.Token(Token = "0x4003F2B")]
	public const short LivingWoodWand = 832;

	[Cpp2IlInjected.Token(Token = "0x4003F2C")]
	public const short PurpleIceBlock = 833;

	[Cpp2IlInjected.Token(Token = "0x4003F2D")]
	public const short PinkIceBlock = 834;

	[Cpp2IlInjected.Token(Token = "0x4003F2E")]
	public const short RedIceBlock = 835;

	[Cpp2IlInjected.Token(Token = "0x4003F2F")]
	public const short CrimstoneBlock = 836;

	[Cpp2IlInjected.Token(Token = "0x4003F30")]
	public const short SkywareDoor = 837;

	[Cpp2IlInjected.Token(Token = "0x4003F31")]
	public const short SkywareChest = 838;

	[Cpp2IlInjected.Token(Token = "0x4003F32")]
	public const short SteampunkHat = 839;

	[Cpp2IlInjected.Token(Token = "0x4003F33")]
	public const short SteampunkShirt = 840;

	[Cpp2IlInjected.Token(Token = "0x4003F34")]
	public const short SteampunkPants = 841;

	[Cpp2IlInjected.Token(Token = "0x4003F35")]
	public const short BeeHat = 842;

	[Cpp2IlInjected.Token(Token = "0x4003F36")]
	public const short BeeShirt = 843;

	[Cpp2IlInjected.Token(Token = "0x4003F37")]
	public const short BeePants = 844;

	[Cpp2IlInjected.Token(Token = "0x4003F38")]
	public const short WorldBanner = 845;

	[Cpp2IlInjected.Token(Token = "0x4003F39")]
	public const short SunBanner = 846;

	[Cpp2IlInjected.Token(Token = "0x4003F3A")]
	public const short GravityBanner = 847;

	[Cpp2IlInjected.Token(Token = "0x4003F3B")]
	public const short PharaohsMask = 848;

	[Cpp2IlInjected.Token(Token = "0x4003F3C")]
	public const short Actuator = 849;

	[Cpp2IlInjected.Token(Token = "0x4003F3D")]
	public const short BlueWrench = 850;

	[Cpp2IlInjected.Token(Token = "0x4003F3E")]
	public const short GreenWrench = 851;

	[Cpp2IlInjected.Token(Token = "0x4003F3F")]
	public const short BluePressurePlate = 852;

	[Cpp2IlInjected.Token(Token = "0x4003F40")]
	public const short YellowPressurePlate = 853;

	[Cpp2IlInjected.Token(Token = "0x4003F41")]
	public const short DiscountCard = 854;

	[Cpp2IlInjected.Token(Token = "0x4003F42")]
	public const short LuckyCoin = 855;

	[Cpp2IlInjected.Token(Token = "0x4003F43")]
	public const short UnicornonaStick = 856;

	[Cpp2IlInjected.Token(Token = "0x4003F44")]
	public const short SandstorminaBottle = 857;

	[Cpp2IlInjected.Token(Token = "0x4003F45")]
	public const short BorealWoodSofa = 858;

	[Cpp2IlInjected.Token(Token = "0x4003F46")]
	public const short BeachBall = 859;

	[Cpp2IlInjected.Token(Token = "0x4003F47")]
	public const short CharmofMyths = 860;

	[Cpp2IlInjected.Token(Token = "0x4003F48")]
	public const short MoonShell = 861;

	[Cpp2IlInjected.Token(Token = "0x4003F49")]
	public const short StarVeil = 862;

	[Cpp2IlInjected.Token(Token = "0x4003F4A")]
	public const short WaterWalkingBoots = 863;

	[Cpp2IlInjected.Token(Token = "0x4003F4B")]
	public const short Tiara = 864;

	[Cpp2IlInjected.Token(Token = "0x4003F4C")]
	public const short PrincessDress = 865;

	[Cpp2IlInjected.Token(Token = "0x4003F4D")]
	public const short PharaohsRobe = 866;

	[Cpp2IlInjected.Token(Token = "0x4003F4E")]
	public const short GreenCap = 867;

	[Cpp2IlInjected.Token(Token = "0x4003F4F")]
	public const short MushroomCap = 868;

	[Cpp2IlInjected.Token(Token = "0x4003F50")]
	public const short TamOShanter = 869;

	[Cpp2IlInjected.Token(Token = "0x4003F51")]
	public const short MummyMask = 870;

	[Cpp2IlInjected.Token(Token = "0x4003F52")]
	public const short MummyShirt = 871;

	[Cpp2IlInjected.Token(Token = "0x4003F53")]
	public const short MummyPants = 872;

	[Cpp2IlInjected.Token(Token = "0x4003F54")]
	public const short CowboyHat = 873;

	[Cpp2IlInjected.Token(Token = "0x4003F55")]
	public const short CowboyJacket = 874;

	[Cpp2IlInjected.Token(Token = "0x4003F56")]
	public const short CowboyPants = 875;

	[Cpp2IlInjected.Token(Token = "0x4003F57")]
	public const short PirateHat = 876;

	[Cpp2IlInjected.Token(Token = "0x4003F58")]
	public const short PirateShirt = 877;

	[Cpp2IlInjected.Token(Token = "0x4003F59")]
	public const short PiratePants = 878;

	[Cpp2IlInjected.Token(Token = "0x4003F5A")]
	public const short VikingHelmet = 879;

	[Cpp2IlInjected.Token(Token = "0x4003F5B")]
	public const short CrimtaneOre = 880;

	[Cpp2IlInjected.Token(Token = "0x4003F5C")]
	public const short CactusSword = 881;

	[Cpp2IlInjected.Token(Token = "0x4003F5D")]
	public const short CactusPickaxe = 882;

	[Cpp2IlInjected.Token(Token = "0x4003F5E")]
	public const short IceBrick = 883;

	[Cpp2IlInjected.Token(Token = "0x4003F5F")]
	public const short IceBrickWall = 884;

	[Cpp2IlInjected.Token(Token = "0x4003F60")]
	public const short AdhesiveBandage = 885;

	[Cpp2IlInjected.Token(Token = "0x4003F61")]
	public const short ArmorPolish = 886;

	[Cpp2IlInjected.Token(Token = "0x4003F62")]
	public const short Bezoar = 887;

	[Cpp2IlInjected.Token(Token = "0x4003F63")]
	public const short Blindfold = 888;

	[Cpp2IlInjected.Token(Token = "0x4003F64")]
	public const short FastClock = 889;

	[Cpp2IlInjected.Token(Token = "0x4003F65")]
	public const short Megaphone = 890;

	[Cpp2IlInjected.Token(Token = "0x4003F66")]
	public const short Nazar = 891;

	[Cpp2IlInjected.Token(Token = "0x4003F67")]
	public const short Vitamins = 892;

	[Cpp2IlInjected.Token(Token = "0x4003F68")]
	public const short TrifoldMap = 893;

	[Cpp2IlInjected.Token(Token = "0x4003F69")]
	public const short CactusHelmet = 894;

	[Cpp2IlInjected.Token(Token = "0x4003F6A")]
	public const short CactusBreastplate = 895;

	[Cpp2IlInjected.Token(Token = "0x4003F6B")]
	public const short CactusLeggings = 896;

	[Cpp2IlInjected.Token(Token = "0x4003F6C")]
	public const short PowerGlove = 897;

	[Cpp2IlInjected.Token(Token = "0x4003F6D")]
	public const short LightningBoots = 898;

	[Cpp2IlInjected.Token(Token = "0x4003F6E")]
	public const short SunStone = 899;

	[Cpp2IlInjected.Token(Token = "0x4003F6F")]
	public const short MoonStone = 900;

	[Cpp2IlInjected.Token(Token = "0x4003F70")]
	public const short ArmorBracing = 901;

	[Cpp2IlInjected.Token(Token = "0x4003F71")]
	public const short MedicatedBandage = 902;

	[Cpp2IlInjected.Token(Token = "0x4003F72")]
	public const short ThePlan = 903;

	[Cpp2IlInjected.Token(Token = "0x4003F73")]
	public const short CountercurseMantra = 904;

	[Cpp2IlInjected.Token(Token = "0x4003F74")]
	public const short CoinGun = 905;

	[Cpp2IlInjected.Token(Token = "0x4003F75")]
	public const short LavaCharm = 906;

	[Cpp2IlInjected.Token(Token = "0x4003F76")]
	public const short ObsidianWaterWalkingBoots = 907;

	[Cpp2IlInjected.Token(Token = "0x4003F77")]
	public const short LavaWaders = 908;

	[Cpp2IlInjected.Token(Token = "0x4003F78")]
	public const short PureWaterFountain = 909;

	[Cpp2IlInjected.Token(Token = "0x4003F79")]
	public const short DesertWaterFountain = 910;

	[Cpp2IlInjected.Token(Token = "0x4003F7A")]
	public const short Shadewood = 911;

	[Cpp2IlInjected.Token(Token = "0x4003F7B")]
	public const short ShadewoodDoor = 912;

	[Cpp2IlInjected.Token(Token = "0x4003F7C")]
	public const short ShadewoodPlatform = 913;

	[Cpp2IlInjected.Token(Token = "0x4003F7D")]
	public const short ShadewoodChest = 914;

	[Cpp2IlInjected.Token(Token = "0x4003F7E")]
	public const short ShadewoodChair = 915;

	[Cpp2IlInjected.Token(Token = "0x4003F7F")]
	public const short ShadewoodWorkBench = 916;

	[Cpp2IlInjected.Token(Token = "0x4003F80")]
	public const short ShadewoodTable = 917;

	[Cpp2IlInjected.Token(Token = "0x4003F81")]
	public const short ShadewoodDresser = 918;

	[Cpp2IlInjected.Token(Token = "0x4003F82")]
	public const short ShadewoodPiano = 919;

	[Cpp2IlInjected.Token(Token = "0x4003F83")]
	public const short ShadewoodBed = 920;

	[Cpp2IlInjected.Token(Token = "0x4003F84")]
	public const short ShadewoodSword = 921;

	[Cpp2IlInjected.Token(Token = "0x4003F85")]
	public const short ShadewoodHammer = 922;

	[Cpp2IlInjected.Token(Token = "0x4003F86")]
	public const short ShadewoodBow = 923;

	[Cpp2IlInjected.Token(Token = "0x4003F87")]
	public const short ShadewoodHelmet = 924;

	[Cpp2IlInjected.Token(Token = "0x4003F88")]
	public const short ShadewoodBreastplate = 925;

	[Cpp2IlInjected.Token(Token = "0x4003F89")]
	public const short ShadewoodGreaves = 926;

	[Cpp2IlInjected.Token(Token = "0x4003F8A")]
	public const short ShadewoodWall = 927;

	[Cpp2IlInjected.Token(Token = "0x4003F8B")]
	public const short Cannon = 928;

	[Cpp2IlInjected.Token(Token = "0x4003F8C")]
	public const short Cannonball = 929;

	[Cpp2IlInjected.Token(Token = "0x4003F8D")]
	public const short FlareGun = 930;

	[Cpp2IlInjected.Token(Token = "0x4003F8E")]
	public const short Flare = 931;

	[Cpp2IlInjected.Token(Token = "0x4003F8F")]
	public const short BoneWand = 932;

	[Cpp2IlInjected.Token(Token = "0x4003F90")]
	public const short LeafWand = 933;

	[Cpp2IlInjected.Token(Token = "0x4003F91")]
	public const short FlyingCarpet = 934;

	[Cpp2IlInjected.Token(Token = "0x4003F92")]
	public const short AvengerEmblem = 935;

	[Cpp2IlInjected.Token(Token = "0x4003F93")]
	public const short MechanicalGlove = 936;

	[Cpp2IlInjected.Token(Token = "0x4003F94")]
	public const short LandMine = 937;

	[Cpp2IlInjected.Token(Token = "0x4003F95")]
	public const short PaladinsShield = 938;

	[Cpp2IlInjected.Token(Token = "0x4003F96")]
	public const short WebSlinger = 939;

	[Cpp2IlInjected.Token(Token = "0x4003F97")]
	public const short JungleWaterFountain = 940;

	[Cpp2IlInjected.Token(Token = "0x4003F98")]
	public const short IcyWaterFountain = 941;

	[Cpp2IlInjected.Token(Token = "0x4003F99")]
	public const short CorruptWaterFountain = 942;

	[Cpp2IlInjected.Token(Token = "0x4003F9A")]
	public const short CrimsonWaterFountain = 943;

	[Cpp2IlInjected.Token(Token = "0x4003F9B")]
	public const short HallowedWaterFountain = 944;

	[Cpp2IlInjected.Token(Token = "0x4003F9C")]
	public const short BloodWaterFountain = 945;

	[Cpp2IlInjected.Token(Token = "0x4003F9D")]
	public const short Umbrella = 946;

	[Cpp2IlInjected.Token(Token = "0x4003F9E")]
	public const short ChlorophyteOre = 947;

	[Cpp2IlInjected.Token(Token = "0x4003F9F")]
	public const short SteampunkWings = 948;

	[Cpp2IlInjected.Token(Token = "0x4003FA0")]
	public const short Snowball = 949;

	[Cpp2IlInjected.Token(Token = "0x4003FA1")]
	public const short IceSkates = 950;

	[Cpp2IlInjected.Token(Token = "0x4003FA2")]
	public const short SnowballLauncher = 951;

	[Cpp2IlInjected.Token(Token = "0x4003FA3")]
	public const short WebCoveredChest = 952;

	[Cpp2IlInjected.Token(Token = "0x4003FA4")]
	public const short ClimbingClaws = 953;

	[Cpp2IlInjected.Token(Token = "0x4003FA5")]
	public const short AncientIronHelmet = 954;

	[Cpp2IlInjected.Token(Token = "0x4003FA6")]
	public const short AncientGoldHelmet = 955;

	[Cpp2IlInjected.Token(Token = "0x4003FA7")]
	public const short AncientShadowHelmet = 956;

	[Cpp2IlInjected.Token(Token = "0x4003FA8")]
	public const short AncientShadowScalemail = 957;

	[Cpp2IlInjected.Token(Token = "0x4003FA9")]
	public const short AncientShadowGreaves = 958;

	[Cpp2IlInjected.Token(Token = "0x4003FAA")]
	public const short AncientNecroHelmet = 959;

	[Cpp2IlInjected.Token(Token = "0x4003FAB")]
	public const short AncientCobaltHelmet = 960;

	[Cpp2IlInjected.Token(Token = "0x4003FAC")]
	public const short AncientCobaltBreastplate = 961;

	[Cpp2IlInjected.Token(Token = "0x4003FAD")]
	public const short AncientCobaltLeggings = 962;

	[Cpp2IlInjected.Token(Token = "0x4003FAE")]
	public const short BlackBelt = 963;

	[Cpp2IlInjected.Token(Token = "0x4003FAF")]
	public const short Boomstick = 964;

	[Cpp2IlInjected.Token(Token = "0x4003FB0")]
	public const short Rope = 965;

	[Cpp2IlInjected.Token(Token = "0x4003FB1")]
	public const short Campfire = 966;

	[Cpp2IlInjected.Token(Token = "0x4003FB2")]
	public const short Marshmallow = 967;

	[Cpp2IlInjected.Token(Token = "0x4003FB3")]
	public const short MarshmallowonaStick = 968;

	[Cpp2IlInjected.Token(Token = "0x4003FB4")]
	public const short CookedMarshmallow = 969;

	[Cpp2IlInjected.Token(Token = "0x4003FB5")]
	public const short RedRocket = 970;

	[Cpp2IlInjected.Token(Token = "0x4003FB6")]
	public const short GreenRocket = 971;

	[Cpp2IlInjected.Token(Token = "0x4003FB7")]
	public const short BlueRocket = 972;

	[Cpp2IlInjected.Token(Token = "0x4003FB8")]
	public const short YellowRocket = 973;

	[Cpp2IlInjected.Token(Token = "0x4003FB9")]
	public const short IceTorch = 974;

	[Cpp2IlInjected.Token(Token = "0x4003FBA")]
	public const short ShoeSpikes = 975;

	[Cpp2IlInjected.Token(Token = "0x4003FBB")]
	public const short TigerClimbingGear = 976;

	[Cpp2IlInjected.Token(Token = "0x4003FBC")]
	public const short Tabi = 977;

	[Cpp2IlInjected.Token(Token = "0x4003FBD")]
	public const short PinkEskimoHood = 978;

	[Cpp2IlInjected.Token(Token = "0x4003FBE")]
	public const short PinkEskimoCoat = 979;

	[Cpp2IlInjected.Token(Token = "0x4003FBF")]
	public const short PinkEskimoPants = 980;

	[Cpp2IlInjected.Token(Token = "0x4003FC0")]
	public const short PinkThread = 981;

	[Cpp2IlInjected.Token(Token = "0x4003FC1")]
	public const short ManaRegenerationBand = 982;

	[Cpp2IlInjected.Token(Token = "0x4003FC2")]
	public const short SandstorminaBalloon = 983;

	[Cpp2IlInjected.Token(Token = "0x4003FC3")]
	public const short MasterNinjaGear = 984;

	[Cpp2IlInjected.Token(Token = "0x4003FC4")]
	public const short RopeCoil = 985;

	[Cpp2IlInjected.Token(Token = "0x4003FC5")]
	public const short Blowgun = 986;

	[Cpp2IlInjected.Token(Token = "0x4003FC6")]
	public const short BlizzardinaBottle = 987;

	[Cpp2IlInjected.Token(Token = "0x4003FC7")]
	public const short FrostburnArrow = 988;

	[Cpp2IlInjected.Token(Token = "0x4003FC8")]
	public const short EnchantedSword = 989;

	[Cpp2IlInjected.Token(Token = "0x4003FC9")]
	public const short PickaxeAxe = 990;

	[Cpp2IlInjected.Token(Token = "0x4003FCA")]
	public const short CobaltWaraxe = 991;

	[Cpp2IlInjected.Token(Token = "0x4003FCB")]
	public const short MythrilWaraxe = 992;

	[Cpp2IlInjected.Token(Token = "0x4003FCC")]
	public const short AdamantiteWaraxe = 993;

	[Cpp2IlInjected.Token(Token = "0x4003FCD")]
	public const short EatersBone = 994;

	[Cpp2IlInjected.Token(Token = "0x4003FCE")]
	public const short BlendOMatic = 995;

	[Cpp2IlInjected.Token(Token = "0x4003FCF")]
	public const short MeatGrinder = 996;

	[Cpp2IlInjected.Token(Token = "0x4003FD0")]
	public const short Extractinator = 997;

	[Cpp2IlInjected.Token(Token = "0x4003FD1")]
	public const short Solidifier = 998;

	[Cpp2IlInjected.Token(Token = "0x4003FD2")]
	public const short Amber = 999;

	[Cpp2IlInjected.Token(Token = "0x4003FD3")]
	public const short ConfettiGun = 1000;

	[Cpp2IlInjected.Token(Token = "0x4003FD4")]
	public const short ChlorophyteMask = 1001;

	[Cpp2IlInjected.Token(Token = "0x4003FD5")]
	public const short ChlorophyteHelmet = 1002;

	[Cpp2IlInjected.Token(Token = "0x4003FD6")]
	public const short ChlorophyteHeadgear = 1003;

	[Cpp2IlInjected.Token(Token = "0x4003FD7")]
	public const short ChlorophytePlateMail = 1004;

	[Cpp2IlInjected.Token(Token = "0x4003FD8")]
	public const short ChlorophyteGreaves = 1005;

	[Cpp2IlInjected.Token(Token = "0x4003FD9")]
	public const short ChlorophyteBar = 1006;

	[Cpp2IlInjected.Token(Token = "0x4003FDA")]
	public const short RedDye = 1007;

	[Cpp2IlInjected.Token(Token = "0x4003FDB")]
	public const short OrangeDye = 1008;

	[Cpp2IlInjected.Token(Token = "0x4003FDC")]
	public const short YellowDye = 1009;

	[Cpp2IlInjected.Token(Token = "0x4003FDD")]
	public const short LimeDye = 1010;

	[Cpp2IlInjected.Token(Token = "0x4003FDE")]
	public const short GreenDye = 1011;

	[Cpp2IlInjected.Token(Token = "0x4003FDF")]
	public const short TealDye = 1012;

	[Cpp2IlInjected.Token(Token = "0x4003FE0")]
	public const short CyanDye = 1013;

	[Cpp2IlInjected.Token(Token = "0x4003FE1")]
	public const short SkyBlueDye = 1014;

	[Cpp2IlInjected.Token(Token = "0x4003FE2")]
	public const short BlueDye = 1015;

	[Cpp2IlInjected.Token(Token = "0x4003FE3")]
	public const short PurpleDye = 1016;

	[Cpp2IlInjected.Token(Token = "0x4003FE4")]
	public const short VioletDye = 1017;

	[Cpp2IlInjected.Token(Token = "0x4003FE5")]
	public const short PinkDye = 1018;

	[Cpp2IlInjected.Token(Token = "0x4003FE6")]
	public const short RedandBlackDye = 1019;

	[Cpp2IlInjected.Token(Token = "0x4003FE7")]
	public const short OrangeandBlackDye = 1020;

	[Cpp2IlInjected.Token(Token = "0x4003FE8")]
	public const short YellowandBlackDye = 1021;

	[Cpp2IlInjected.Token(Token = "0x4003FE9")]
	public const short LimeandBlackDye = 1022;

	[Cpp2IlInjected.Token(Token = "0x4003FEA")]
	public const short GreenandBlackDye = 1023;

	[Cpp2IlInjected.Token(Token = "0x4003FEB")]
	public const short TealandBlackDye = 1024;

	[Cpp2IlInjected.Token(Token = "0x4003FEC")]
	public const short CyanandBlackDye = 1025;

	[Cpp2IlInjected.Token(Token = "0x4003FED")]
	public const short SkyBlueandBlackDye = 1026;

	[Cpp2IlInjected.Token(Token = "0x4003FEE")]
	public const short BlueandBlackDye = 1027;

	[Cpp2IlInjected.Token(Token = "0x4003FEF")]
	public const short PurpleandBlackDye = 1028;

	[Cpp2IlInjected.Token(Token = "0x4003FF0")]
	public const short VioletandBlackDye = 1029;

	[Cpp2IlInjected.Token(Token = "0x4003FF1")]
	public const short PinkandBlackDye = 1030;

	[Cpp2IlInjected.Token(Token = "0x4003FF2")]
	public const short FlameDye = 1031;

	[Cpp2IlInjected.Token(Token = "0x4003FF3")]
	public const short FlameAndBlackDye = 1032;

	[Cpp2IlInjected.Token(Token = "0x4003FF4")]
	public const short GreenFlameDye = 1033;

	[Cpp2IlInjected.Token(Token = "0x4003FF5")]
	public const short GreenFlameAndBlackDye = 1034;

	[Cpp2IlInjected.Token(Token = "0x4003FF6")]
	public const short BlueFlameDye = 1035;

	[Cpp2IlInjected.Token(Token = "0x4003FF7")]
	public const short BlueFlameAndBlackDye = 1036;

	[Cpp2IlInjected.Token(Token = "0x4003FF8")]
	public const short SilverDye = 1037;

	[Cpp2IlInjected.Token(Token = "0x4003FF9")]
	public const short BrightRedDye = 1038;

	[Cpp2IlInjected.Token(Token = "0x4003FFA")]
	public const short BrightOrangeDye = 1039;

	[Cpp2IlInjected.Token(Token = "0x4003FFB")]
	public const short BrightYellowDye = 1040;

	[Cpp2IlInjected.Token(Token = "0x4003FFC")]
	public const short BrightLimeDye = 1041;

	[Cpp2IlInjected.Token(Token = "0x4003FFD")]
	public const short BrightGreenDye = 1042;

	[Cpp2IlInjected.Token(Token = "0x4003FFE")]
	public const short BrightTealDye = 1043;

	[Cpp2IlInjected.Token(Token = "0x4003FFF")]
	public const short BrightCyanDye = 1044;

	[Cpp2IlInjected.Token(Token = "0x4004000")]
	public const short BrightSkyBlueDye = 1045;

	[Cpp2IlInjected.Token(Token = "0x4004001")]
	public const short BrightBlueDye = 1046;

	[Cpp2IlInjected.Token(Token = "0x4004002")]
	public const short BrightPurpleDye = 1047;

	[Cpp2IlInjected.Token(Token = "0x4004003")]
	public const short BrightVioletDye = 1048;

	[Cpp2IlInjected.Token(Token = "0x4004004")]
	public const short BrightPinkDye = 1049;

	[Cpp2IlInjected.Token(Token = "0x4004005")]
	public const short BlackDye = 1050;

	[Cpp2IlInjected.Token(Token = "0x4004006")]
	public const short RedandSilverDye = 1051;

	[Cpp2IlInjected.Token(Token = "0x4004007")]
	public const short OrangeandSilverDye = 1052;

	[Cpp2IlInjected.Token(Token = "0x4004008")]
	public const short YellowandSilverDye = 1053;

	[Cpp2IlInjected.Token(Token = "0x4004009")]
	public const short LimeandSilverDye = 1054;

	[Cpp2IlInjected.Token(Token = "0x400400A")]
	public const short GreenandSilverDye = 1055;

	[Cpp2IlInjected.Token(Token = "0x400400B")]
	public const short TealandSilverDye = 1056;

	[Cpp2IlInjected.Token(Token = "0x400400C")]
	public const short CyanandSilverDye = 1057;

	[Cpp2IlInjected.Token(Token = "0x400400D")]
	public const short SkyBlueandSilverDye = 1058;

	[Cpp2IlInjected.Token(Token = "0x400400E")]
	public const short BlueandSilverDye = 1059;

	[Cpp2IlInjected.Token(Token = "0x400400F")]
	public const short PurpleandSilverDye = 1060;

	[Cpp2IlInjected.Token(Token = "0x4004010")]
	public const short VioletandSilverDye = 1061;

	[Cpp2IlInjected.Token(Token = "0x4004011")]
	public const short PinkandSilverDye = 1062;

	[Cpp2IlInjected.Token(Token = "0x4004012")]
	public const short IntenseFlameDye = 1063;

	[Cpp2IlInjected.Token(Token = "0x4004013")]
	public const short IntenseGreenFlameDye = 1064;

	[Cpp2IlInjected.Token(Token = "0x4004014")]
	public const short IntenseBlueFlameDye = 1065;

	[Cpp2IlInjected.Token(Token = "0x4004015")]
	public const short RainbowDye = 1066;

	[Cpp2IlInjected.Token(Token = "0x4004016")]
	public const short IntenseRainbowDye = 1067;

	[Cpp2IlInjected.Token(Token = "0x4004017")]
	public const short YellowGradientDye = 1068;

	[Cpp2IlInjected.Token(Token = "0x4004018")]
	public const short CyanGradientDye = 1069;

	[Cpp2IlInjected.Token(Token = "0x4004019")]
	public const short VioletGradientDye = 1070;

	[Cpp2IlInjected.Token(Token = "0x400401A")]
	public const short Paintbrush = 1071;

	[Cpp2IlInjected.Token(Token = "0x400401B")]
	public const short PaintRoller = 1072;

	[Cpp2IlInjected.Token(Token = "0x400401C")]
	public const short RedPaint = 1073;

	[Cpp2IlInjected.Token(Token = "0x400401D")]
	public const short OrangePaint = 1074;

	[Cpp2IlInjected.Token(Token = "0x400401E")]
	public const short YellowPaint = 1075;

	[Cpp2IlInjected.Token(Token = "0x400401F")]
	public const short LimePaint = 1076;

	[Cpp2IlInjected.Token(Token = "0x4004020")]
	public const short GreenPaint = 1077;

	[Cpp2IlInjected.Token(Token = "0x4004021")]
	public const short TealPaint = 1078;

	[Cpp2IlInjected.Token(Token = "0x4004022")]
	public const short CyanPaint = 1079;

	[Cpp2IlInjected.Token(Token = "0x4004023")]
	public const short SkyBluePaint = 1080;

	[Cpp2IlInjected.Token(Token = "0x4004024")]
	public const short BluePaint = 1081;

	[Cpp2IlInjected.Token(Token = "0x4004025")]
	public const short PurplePaint = 1082;

	[Cpp2IlInjected.Token(Token = "0x4004026")]
	public const short VioletPaint = 1083;

	[Cpp2IlInjected.Token(Token = "0x4004027")]
	public const short PinkPaint = 1084;

	[Cpp2IlInjected.Token(Token = "0x4004028")]
	public const short DeepRedPaint = 1085;

	[Cpp2IlInjected.Token(Token = "0x4004029")]
	public const short DeepOrangePaint = 1086;

	[Cpp2IlInjected.Token(Token = "0x400402A")]
	public const short DeepYellowPaint = 1087;

	[Cpp2IlInjected.Token(Token = "0x400402B")]
	public const short DeepLimePaint = 1088;

	[Cpp2IlInjected.Token(Token = "0x400402C")]
	public const short DeepGreenPaint = 1089;

	[Cpp2IlInjected.Token(Token = "0x400402D")]
	public const short DeepTealPaint = 1090;

	[Cpp2IlInjected.Token(Token = "0x400402E")]
	public const short DeepCyanPaint = 1091;

	[Cpp2IlInjected.Token(Token = "0x400402F")]
	public const short DeepSkyBluePaint = 1092;

	[Cpp2IlInjected.Token(Token = "0x4004030")]
	public const short DeepBluePaint = 1093;

	[Cpp2IlInjected.Token(Token = "0x4004031")]
	public const short DeepPurplePaint = 1094;

	[Cpp2IlInjected.Token(Token = "0x4004032")]
	public const short DeepVioletPaint = 1095;

	[Cpp2IlInjected.Token(Token = "0x4004033")]
	public const short DeepPinkPaint = 1096;

	[Cpp2IlInjected.Token(Token = "0x4004034")]
	public const short BlackPaint = 1097;

	[Cpp2IlInjected.Token(Token = "0x4004035")]
	public const short WhitePaint = 1098;

	[Cpp2IlInjected.Token(Token = "0x4004036")]
	public const short GrayPaint = 1099;

	[Cpp2IlInjected.Token(Token = "0x4004037")]
	public const short PaintScraper = 1100;

	[Cpp2IlInjected.Token(Token = "0x4004038")]
	public const short LihzahrdBrick = 1101;

	[Cpp2IlInjected.Token(Token = "0x4004039")]
	public const short LihzahrdBrickWall = 1102;

	[Cpp2IlInjected.Token(Token = "0x400403A")]
	public const short SlushBlock = 1103;

	[Cpp2IlInjected.Token(Token = "0x400403B")]
	public const short PalladiumOre = 1104;

	[Cpp2IlInjected.Token(Token = "0x400403C")]
	public const short OrichalcumOre = 1105;

	[Cpp2IlInjected.Token(Token = "0x400403D")]
	public const short TitaniumOre = 1106;

	[Cpp2IlInjected.Token(Token = "0x400403E")]
	public const short TealMushroom = 1107;

	[Cpp2IlInjected.Token(Token = "0x400403F")]
	public const short GreenMushroom = 1108;

	[Cpp2IlInjected.Token(Token = "0x4004040")]
	public const short SkyBlueFlower = 1109;

	[Cpp2IlInjected.Token(Token = "0x4004041")]
	public const short YellowMarigold = 1110;

	[Cpp2IlInjected.Token(Token = "0x4004042")]
	public const short BlueBerries = 1111;

	[Cpp2IlInjected.Token(Token = "0x4004043")]
	public const short LimeKelp = 1112;

	[Cpp2IlInjected.Token(Token = "0x4004044")]
	public const short PinkPricklyPear = 1113;

	[Cpp2IlInjected.Token(Token = "0x4004045")]
	public const short OrangeBloodroot = 1114;

	[Cpp2IlInjected.Token(Token = "0x4004046")]
	public const short RedHusk = 1115;

	[Cpp2IlInjected.Token(Token = "0x4004047")]
	public const short CyanHusk = 1116;

	[Cpp2IlInjected.Token(Token = "0x4004048")]
	public const short VioletHusk = 1117;

	[Cpp2IlInjected.Token(Token = "0x4004049")]
	public const short PurpleMucos = 1118;

	[Cpp2IlInjected.Token(Token = "0x400404A")]
	public const short BlackInk = 1119;

	[Cpp2IlInjected.Token(Token = "0x400404B")]
	public const short DyeVat = 1120;

	[Cpp2IlInjected.Token(Token = "0x400404C")]
	public const short BeeGun = 1121;

	[Cpp2IlInjected.Token(Token = "0x400404D")]
	public const short PossessedHatchet = 1122;

	[Cpp2IlInjected.Token(Token = "0x400404E")]
	public const short BeeKeeper = 1123;

	[Cpp2IlInjected.Token(Token = "0x400404F")]
	public const short Hive = 1124;

	[Cpp2IlInjected.Token(Token = "0x4004050")]
	public const short HoneyBlock = 1125;

	[Cpp2IlInjected.Token(Token = "0x4004051")]
	public const short HiveWall = 1126;

	[Cpp2IlInjected.Token(Token = "0x4004052")]
	public const short CrispyHoneyBlock = 1127;

	[Cpp2IlInjected.Token(Token = "0x4004053")]
	public const short HoneyBucket = 1128;

	[Cpp2IlInjected.Token(Token = "0x4004054")]
	public const short HiveWand = 1129;

	[Cpp2IlInjected.Token(Token = "0x4004055")]
	public const short Beenade = 1130;

	[Cpp2IlInjected.Token(Token = "0x4004056")]
	public const short GravityGlobe = 1131;

	[Cpp2IlInjected.Token(Token = "0x4004057")]
	public const short HoneyComb = 1132;

	[Cpp2IlInjected.Token(Token = "0x4004058")]
	public const short Abeemination = 1133;

	[Cpp2IlInjected.Token(Token = "0x4004059")]
	public const short BottledHoney = 1134;

	[Cpp2IlInjected.Token(Token = "0x400405A")]
	public const short RainHat = 1135;

	[Cpp2IlInjected.Token(Token = "0x400405B")]
	public const short RainCoat = 1136;

	[Cpp2IlInjected.Token(Token = "0x400405C")]
	public const short LihzahrdDoor = 1137;

	[Cpp2IlInjected.Token(Token = "0x400405D")]
	public const short DungeonDoor = 1138;

	[Cpp2IlInjected.Token(Token = "0x400405E")]
	public const short LeadDoor = 1139;

	[Cpp2IlInjected.Token(Token = "0x400405F")]
	public const short IronDoor = 1140;

	[Cpp2IlInjected.Token(Token = "0x4004060")]
	public const short TempleKey = 1141;

	[Cpp2IlInjected.Token(Token = "0x4004061")]
	public const short LihzahrdChest = 1142;

	[Cpp2IlInjected.Token(Token = "0x4004062")]
	public const short LihzahrdChair = 1143;

	[Cpp2IlInjected.Token(Token = "0x4004063")]
	public const short LihzahrdTable = 1144;

	[Cpp2IlInjected.Token(Token = "0x4004064")]
	public const short LihzahrdWorkBench = 1145;

	[Cpp2IlInjected.Token(Token = "0x4004065")]
	public const short SuperDartTrap = 1146;

	[Cpp2IlInjected.Token(Token = "0x4004066")]
	public const short FlameTrap = 1147;

	[Cpp2IlInjected.Token(Token = "0x4004067")]
	public const short SpikyBallTrap = 1148;

	[Cpp2IlInjected.Token(Token = "0x4004068")]
	public const short SpearTrap = 1149;

	[Cpp2IlInjected.Token(Token = "0x4004069")]
	public const short WoodenSpike = 1150;

	[Cpp2IlInjected.Token(Token = "0x400406A")]
	public const short LihzahrdPressurePlate = 1151;

	[Cpp2IlInjected.Token(Token = "0x400406B")]
	public const short LihzahrdStatue = 1152;

	[Cpp2IlInjected.Token(Token = "0x400406C")]
	public const short LihzahrdWatcherStatue = 1153;

	[Cpp2IlInjected.Token(Token = "0x400406D")]
	public const short LihzahrdGuardianStatue = 1154;

	[Cpp2IlInjected.Token(Token = "0x400406E")]
	public const short WaspGun = 1155;

	[Cpp2IlInjected.Token(Token = "0x400406F")]
	public const short PiranhaGun = 1156;

	[Cpp2IlInjected.Token(Token = "0x4004070")]
	public const short PygmyStaff = 1157;

	[Cpp2IlInjected.Token(Token = "0x4004071")]
	public const short PygmyNecklace = 1158;

	[Cpp2IlInjected.Token(Token = "0x4004072")]
	public const short TikiMask = 1159;

	[Cpp2IlInjected.Token(Token = "0x4004073")]
	public const short TikiShirt = 1160;

	[Cpp2IlInjected.Token(Token = "0x4004074")]
	public const short TikiPants = 1161;

	[Cpp2IlInjected.Token(Token = "0x4004075")]
	public const short LeafWings = 1162;

	[Cpp2IlInjected.Token(Token = "0x4004076")]
	public const short BlizzardinaBalloon = 1163;

	[Cpp2IlInjected.Token(Token = "0x4004077")]
	public const short BundleofBalloons = 1164;

	[Cpp2IlInjected.Token(Token = "0x4004078")]
	public const short BatWings = 1165;

	[Cpp2IlInjected.Token(Token = "0x4004079")]
	public const short BoneSword = 1166;

	[Cpp2IlInjected.Token(Token = "0x400407A")]
	public const short HerculesBeetle = 1167;

	[Cpp2IlInjected.Token(Token = "0x400407B")]
	public const short SmokeBomb = 1168;

	[Cpp2IlInjected.Token(Token = "0x400407C")]
	public const short BoneKey = 1169;

	[Cpp2IlInjected.Token(Token = "0x400407D")]
	public const short Nectar = 1170;

	[Cpp2IlInjected.Token(Token = "0x400407E")]
	public const short TikiTotem = 1171;

	[Cpp2IlInjected.Token(Token = "0x400407F")]
	public const short LizardEgg = 1172;

	[Cpp2IlInjected.Token(Token = "0x4004080")]
	public const short GraveMarker = 1173;

	[Cpp2IlInjected.Token(Token = "0x4004081")]
	public const short CrossGraveMarker = 1174;

	[Cpp2IlInjected.Token(Token = "0x4004082")]
	public const short Headstone = 1175;

	[Cpp2IlInjected.Token(Token = "0x4004083")]
	public const short Gravestone = 1176;

	[Cpp2IlInjected.Token(Token = "0x4004084")]
	public const short Obelisk = 1177;

	[Cpp2IlInjected.Token(Token = "0x4004085")]
	public const short LeafBlower = 1178;

	[Cpp2IlInjected.Token(Token = "0x4004086")]
	public const short ChlorophyteBullet = 1179;

	[Cpp2IlInjected.Token(Token = "0x4004087")]
	public const short ParrotCracker = 1180;

	[Cpp2IlInjected.Token(Token = "0x4004088")]
	public const short StrangeGlowingMushroom = 1181;

	[Cpp2IlInjected.Token(Token = "0x4004089")]
	public const short Seedling = 1182;

	[Cpp2IlInjected.Token(Token = "0x400408A")]
	public const short WispinaBottle = 1183;

	[Cpp2IlInjected.Token(Token = "0x400408B")]
	public const short PalladiumBar = 1184;

	[Cpp2IlInjected.Token(Token = "0x400408C")]
	public const short PalladiumSword = 1185;

	[Cpp2IlInjected.Token(Token = "0x400408D")]
	public const short PalladiumPike = 1186;

	[Cpp2IlInjected.Token(Token = "0x400408E")]
	public const short PalladiumRepeater = 1187;

	[Cpp2IlInjected.Token(Token = "0x400408F")]
	public const short PalladiumPickaxe = 1188;

	[Cpp2IlInjected.Token(Token = "0x4004090")]
	public const short PalladiumDrill = 1189;

	[Cpp2IlInjected.Token(Token = "0x4004091")]
	public const short PalladiumChainsaw = 1190;

	[Cpp2IlInjected.Token(Token = "0x4004092")]
	public const short OrichalcumBar = 1191;

	[Cpp2IlInjected.Token(Token = "0x4004093")]
	public const short OrichalcumSword = 1192;

	[Cpp2IlInjected.Token(Token = "0x4004094")]
	public const short OrichalcumHalberd = 1193;

	[Cpp2IlInjected.Token(Token = "0x4004095")]
	public const short OrichalcumRepeater = 1194;

	[Cpp2IlInjected.Token(Token = "0x4004096")]
	public const short OrichalcumPickaxe = 1195;

	[Cpp2IlInjected.Token(Token = "0x4004097")]
	public const short OrichalcumDrill = 1196;

	[Cpp2IlInjected.Token(Token = "0x4004098")]
	public const short OrichalcumChainsaw = 1197;

	[Cpp2IlInjected.Token(Token = "0x4004099")]
	public const short TitaniumBar = 1198;

	[Cpp2IlInjected.Token(Token = "0x400409A")]
	public const short TitaniumSword = 1199;

	[Cpp2IlInjected.Token(Token = "0x400409B")]
	public const short TitaniumTrident = 1200;

	[Cpp2IlInjected.Token(Token = "0x400409C")]
	public const short TitaniumRepeater = 1201;

	[Cpp2IlInjected.Token(Token = "0x400409D")]
	public const short TitaniumPickaxe = 1202;

	[Cpp2IlInjected.Token(Token = "0x400409E")]
	public const short TitaniumDrill = 1203;

	[Cpp2IlInjected.Token(Token = "0x400409F")]
	public const short TitaniumChainsaw = 1204;

	[Cpp2IlInjected.Token(Token = "0x40040A0")]
	public const short PalladiumMask = 1205;

	[Cpp2IlInjected.Token(Token = "0x40040A1")]
	public const short PalladiumHelmet = 1206;

	[Cpp2IlInjected.Token(Token = "0x40040A2")]
	public const short PalladiumHeadgear = 1207;

	[Cpp2IlInjected.Token(Token = "0x40040A3")]
	public const short PalladiumBreastplate = 1208;

	[Cpp2IlInjected.Token(Token = "0x40040A4")]
	public const short PalladiumLeggings = 1209;

	[Cpp2IlInjected.Token(Token = "0x40040A5")]
	public const short OrichalcumMask = 1210;

	[Cpp2IlInjected.Token(Token = "0x40040A6")]
	public const short OrichalcumHelmet = 1211;

	[Cpp2IlInjected.Token(Token = "0x40040A7")]
	public const short OrichalcumHeadgear = 1212;

	[Cpp2IlInjected.Token(Token = "0x40040A8")]
	public const short OrichalcumBreastplate = 1213;

	[Cpp2IlInjected.Token(Token = "0x40040A9")]
	public const short OrichalcumLeggings = 1214;

	[Cpp2IlInjected.Token(Token = "0x40040AA")]
	public const short TitaniumMask = 1215;

	[Cpp2IlInjected.Token(Token = "0x40040AB")]
	public const short TitaniumHelmet = 1216;

	[Cpp2IlInjected.Token(Token = "0x40040AC")]
	public const short TitaniumHeadgear = 1217;

	[Cpp2IlInjected.Token(Token = "0x40040AD")]
	public const short TitaniumBreastplate = 1218;

	[Cpp2IlInjected.Token(Token = "0x40040AE")]
	public const short TitaniumLeggings = 1219;

	[Cpp2IlInjected.Token(Token = "0x40040AF")]
	public const short OrichalcumAnvil = 1220;

	[Cpp2IlInjected.Token(Token = "0x40040B0")]
	public const short TitaniumForge = 1221;

	[Cpp2IlInjected.Token(Token = "0x40040B1")]
	public const short PalladiumWaraxe = 1222;

	[Cpp2IlInjected.Token(Token = "0x40040B2")]
	public const short OrichalcumWaraxe = 1223;

	[Cpp2IlInjected.Token(Token = "0x40040B3")]
	public const short TitaniumWaraxe = 1224;

	[Cpp2IlInjected.Token(Token = "0x40040B4")]
	public const short HallowedBar = 1225;

	[Cpp2IlInjected.Token(Token = "0x40040B5")]
	public const short ChlorophyteClaymore = 1226;

	[Cpp2IlInjected.Token(Token = "0x40040B6")]
	public const short ChlorophyteSaber = 1227;

	[Cpp2IlInjected.Token(Token = "0x40040B7")]
	public const short ChlorophytePartisan = 1228;

	[Cpp2IlInjected.Token(Token = "0x40040B8")]
	public const short ChlorophyteShotbow = 1229;

	[Cpp2IlInjected.Token(Token = "0x40040B9")]
	public const short ChlorophytePickaxe = 1230;

	[Cpp2IlInjected.Token(Token = "0x40040BA")]
	public const short ChlorophyteDrill = 1231;

	[Cpp2IlInjected.Token(Token = "0x40040BB")]
	public const short ChlorophyteChainsaw = 1232;

	[Cpp2IlInjected.Token(Token = "0x40040BC")]
	public const short ChlorophyteGreataxe = 1233;

	[Cpp2IlInjected.Token(Token = "0x40040BD")]
	public const short ChlorophyteWarhammer = 1234;

	[Cpp2IlInjected.Token(Token = "0x40040BE")]
	public const short ChlorophyteArrow = 1235;

	[Cpp2IlInjected.Token(Token = "0x40040BF")]
	public const short AmethystHook = 1236;

	[Cpp2IlInjected.Token(Token = "0x40040C0")]
	public const short TopazHook = 1237;

	[Cpp2IlInjected.Token(Token = "0x40040C1")]
	public const short SapphireHook = 1238;

	[Cpp2IlInjected.Token(Token = "0x40040C2")]
	public const short EmeraldHook = 1239;

	[Cpp2IlInjected.Token(Token = "0x40040C3")]
	public const short RubyHook = 1240;

	[Cpp2IlInjected.Token(Token = "0x40040C4")]
	public const short DiamondHook = 1241;

	[Cpp2IlInjected.Token(Token = "0x40040C5")]
	public const short AmberMosquito = 1242;

	[Cpp2IlInjected.Token(Token = "0x40040C6")]
	public const short UmbrellaHat = 1243;

	[Cpp2IlInjected.Token(Token = "0x40040C7")]
	public const short NimbusRod = 1244;

	[Cpp2IlInjected.Token(Token = "0x40040C8")]
	public const short OrangeTorch = 1245;

	[Cpp2IlInjected.Token(Token = "0x40040C9")]
	public const short CrimsandBlock = 1246;

	[Cpp2IlInjected.Token(Token = "0x40040CA")]
	public const short BeeCloak = 1247;

	[Cpp2IlInjected.Token(Token = "0x40040CB")]
	public const short EyeoftheGolem = 1248;

	[Cpp2IlInjected.Token(Token = "0x40040CC")]
	public const short HoneyBalloon = 1249;

	[Cpp2IlInjected.Token(Token = "0x40040CD")]
	public const short BlueHorseshoeBalloon = 1250;

	[Cpp2IlInjected.Token(Token = "0x40040CE")]
	public const short WhiteHorseshoeBalloon = 1251;

	[Cpp2IlInjected.Token(Token = "0x40040CF")]
	public const short YellowHorseshoeBalloon = 1252;

	[Cpp2IlInjected.Token(Token = "0x40040D0")]
	public const short FrozenTurtleShell = 1253;

	[Cpp2IlInjected.Token(Token = "0x40040D1")]
	public const short SniperRifle = 1254;

	[Cpp2IlInjected.Token(Token = "0x40040D2")]
	public const short VenusMagnum = 1255;

	[Cpp2IlInjected.Token(Token = "0x40040D3")]
	public const short CrimsonRod = 1256;

	[Cpp2IlInjected.Token(Token = "0x40040D4")]
	public const short CrimtaneBar = 1257;

	[Cpp2IlInjected.Token(Token = "0x40040D5")]
	public const short Stynger = 1258;

	[Cpp2IlInjected.Token(Token = "0x40040D6")]
	public const short FlowerPow = 1259;

	[Cpp2IlInjected.Token(Token = "0x40040D7")]
	public const short RainbowGun = 1260;

	[Cpp2IlInjected.Token(Token = "0x40040D8")]
	public const short StyngerBolt = 1261;

	[Cpp2IlInjected.Token(Token = "0x40040D9")]
	public const short ChlorophyteJackhammer = 1262;

	[Cpp2IlInjected.Token(Token = "0x40040DA")]
	public const short Teleporter = 1263;

	[Cpp2IlInjected.Token(Token = "0x40040DB")]
	public const short FlowerofFrost = 1264;

	[Cpp2IlInjected.Token(Token = "0x40040DC")]
	public const short Uzi = 1265;

	[Cpp2IlInjected.Token(Token = "0x40040DD")]
	public const short MagnetSphere = 1266;

	[Cpp2IlInjected.Token(Token = "0x40040DE")]
	public const short PurpleStainedGlass = 1267;

	[Cpp2IlInjected.Token(Token = "0x40040DF")]
	public const short YellowStainedGlass = 1268;

	[Cpp2IlInjected.Token(Token = "0x40040E0")]
	public const short BlueStainedGlass = 1269;

	[Cpp2IlInjected.Token(Token = "0x40040E1")]
	public const short GreenStainedGlass = 1270;

	[Cpp2IlInjected.Token(Token = "0x40040E2")]
	public const short RedStainedGlass = 1271;

	[Cpp2IlInjected.Token(Token = "0x40040E3")]
	public const short MulticoloredStainedGlass = 1272;

	[Cpp2IlInjected.Token(Token = "0x40040E4")]
	public const short SkeletronHand = 1273;

	[Cpp2IlInjected.Token(Token = "0x40040E5")]
	public const short Skull = 1274;

	[Cpp2IlInjected.Token(Token = "0x40040E6")]
	public const short BallaHat = 1275;

	[Cpp2IlInjected.Token(Token = "0x40040E7")]
	public const short GangstaHat = 1276;

	[Cpp2IlInjected.Token(Token = "0x40040E8")]
	public const short SailorHat = 1277;

	[Cpp2IlInjected.Token(Token = "0x40040E9")]
	public const short EyePatch = 1278;

	[Cpp2IlInjected.Token(Token = "0x40040EA")]
	public const short SailorShirt = 1279;

	[Cpp2IlInjected.Token(Token = "0x40040EB")]
	public const short SailorPants = 1280;

	[Cpp2IlInjected.Token(Token = "0x40040EC")]
	public const short SkeletronMask = 1281;

	[Cpp2IlInjected.Token(Token = "0x40040ED")]
	public const short AmethystRobe = 1282;

	[Cpp2IlInjected.Token(Token = "0x40040EE")]
	public const short TopazRobe = 1283;

	[Cpp2IlInjected.Token(Token = "0x40040EF")]
	public const short SapphireRobe = 1284;

	[Cpp2IlInjected.Token(Token = "0x40040F0")]
	public const short EmeraldRobe = 1285;

	[Cpp2IlInjected.Token(Token = "0x40040F1")]
	public const short RubyRobe = 1286;

	[Cpp2IlInjected.Token(Token = "0x40040F2")]
	public const short DiamondRobe = 1287;

	[Cpp2IlInjected.Token(Token = "0x40040F3")]
	public const short WhiteTuxedoShirt = 1288;

	[Cpp2IlInjected.Token(Token = "0x40040F4")]
	public const short WhiteTuxedoPants = 1289;

	[Cpp2IlInjected.Token(Token = "0x40040F5")]
	public const short PanicNecklace = 1290;

	[Cpp2IlInjected.Token(Token = "0x40040F6")]
	public const short LifeFruit = 1291;

	[Cpp2IlInjected.Token(Token = "0x40040F7")]
	public const short LihzahrdAltar = 1292;

	[Cpp2IlInjected.Token(Token = "0x40040F8")]
	public const short LihzahrdPowerCell = 1293;

	[Cpp2IlInjected.Token(Token = "0x40040F9")]
	public const short Picksaw = 1294;

	[Cpp2IlInjected.Token(Token = "0x40040FA")]
	public const short HeatRay = 1295;

	[Cpp2IlInjected.Token(Token = "0x40040FB")]
	public const short StaffofEarth = 1296;

	[Cpp2IlInjected.Token(Token = "0x40040FC")]
	public const short GolemFist = 1297;

	[Cpp2IlInjected.Token(Token = "0x40040FD")]
	public const short WaterChest = 1298;

	[Cpp2IlInjected.Token(Token = "0x40040FE")]
	public const short Binoculars = 1299;

	[Cpp2IlInjected.Token(Token = "0x40040FF")]
	public const short RifleScope = 1300;

	[Cpp2IlInjected.Token(Token = "0x4004100")]
	public const short DestroyerEmblem = 1301;

	[Cpp2IlInjected.Token(Token = "0x4004101")]
	public const short HighVelocityBullet = 1302;

	[Cpp2IlInjected.Token(Token = "0x4004102")]
	public const short JellyfishNecklace = 1303;

	[Cpp2IlInjected.Token(Token = "0x4004103")]
	public const short ZombieArm = 1304;

	[Cpp2IlInjected.Token(Token = "0x4004104")]
	public const short TheAxe = 1305;

	[Cpp2IlInjected.Token(Token = "0x4004105")]
	public const short IceSickle = 1306;

	[Cpp2IlInjected.Token(Token = "0x4004106")]
	public const short ClothierVoodooDoll = 1307;

	[Cpp2IlInjected.Token(Token = "0x4004107")]
	public const short PoisonStaff = 1308;

	[Cpp2IlInjected.Token(Token = "0x4004108")]
	public const short SlimeStaff = 1309;

	[Cpp2IlInjected.Token(Token = "0x4004109")]
	public const short PoisonDart = 1310;

	[Cpp2IlInjected.Token(Token = "0x400410A")]
	public const short EyeSpring = 1311;

	[Cpp2IlInjected.Token(Token = "0x400410B")]
	public const short ToySled = 1312;

	[Cpp2IlInjected.Token(Token = "0x400410C")]
	public const short BookofSkulls = 1313;

	[Cpp2IlInjected.Token(Token = "0x400410D")]
	public const short KOCannon = 1314;

	[Cpp2IlInjected.Token(Token = "0x400410E")]
	public const short PirateMap = 1315;

	[Cpp2IlInjected.Token(Token = "0x400410F")]
	public const short TurtleHelmet = 1316;

	[Cpp2IlInjected.Token(Token = "0x4004110")]
	public const short TurtleScaleMail = 1317;

	[Cpp2IlInjected.Token(Token = "0x4004111")]
	public const short TurtleLeggings = 1318;

	[Cpp2IlInjected.Token(Token = "0x4004112")]
	public const short SnowballCannon = 1319;

	[Cpp2IlInjected.Token(Token = "0x4004113")]
	public const short BonePickaxe = 1320;

	[Cpp2IlInjected.Token(Token = "0x4004114")]
	public const short MagicQuiver = 1321;

	[Cpp2IlInjected.Token(Token = "0x4004115")]
	public const short MagmaStone = 1322;

	[Cpp2IlInjected.Token(Token = "0x4004116")]
	public const short ObsidianRose = 1323;

	[Cpp2IlInjected.Token(Token = "0x4004117")]
	public const short Bananarang = 1324;

	[Cpp2IlInjected.Token(Token = "0x4004118")]
	public const short ChainKnife = 1325;

	[Cpp2IlInjected.Token(Token = "0x4004119")]
	public const short RodofDiscord = 1326;

	[Cpp2IlInjected.Token(Token = "0x400411A")]
	public const short DeathSickle = 1327;

	[Cpp2IlInjected.Token(Token = "0x400411B")]
	public const short TurtleShell = 1328;

	[Cpp2IlInjected.Token(Token = "0x400411C")]
	public const short TissueSample = 1329;

	[Cpp2IlInjected.Token(Token = "0x400411D")]
	public const short Vertebrae = 1330;

	[Cpp2IlInjected.Token(Token = "0x400411E")]
	public const short BloodySpine = 1331;

	[Cpp2IlInjected.Token(Token = "0x400411F")]
	public const short Ichor = 1332;

	[Cpp2IlInjected.Token(Token = "0x4004120")]
	public const short IchorTorch = 1333;

	[Cpp2IlInjected.Token(Token = "0x4004121")]
	public const short IchorArrow = 1334;

	[Cpp2IlInjected.Token(Token = "0x4004122")]
	public const short IchorBullet = 1335;

	[Cpp2IlInjected.Token(Token = "0x4004123")]
	public const short GoldenShower = 1336;

	[Cpp2IlInjected.Token(Token = "0x4004124")]
	public const short BunnyCannon = 1337;

	[Cpp2IlInjected.Token(Token = "0x4004125")]
	public const short ExplosiveBunny = 1338;

	[Cpp2IlInjected.Token(Token = "0x4004126")]
	public const short VialofVenom = 1339;

	[Cpp2IlInjected.Token(Token = "0x4004127")]
	public const short FlaskofVenom = 1340;

	[Cpp2IlInjected.Token(Token = "0x4004128")]
	public const short VenomArrow = 1341;

	[Cpp2IlInjected.Token(Token = "0x4004129")]
	public const short VenomBullet = 1342;

	[Cpp2IlInjected.Token(Token = "0x400412A")]
	public const short FireGauntlet = 1343;

	[Cpp2IlInjected.Token(Token = "0x400412B")]
	public const short Cog = 1344;

	[Cpp2IlInjected.Token(Token = "0x400412C")]
	public const short Confetti = 1345;

	[Cpp2IlInjected.Token(Token = "0x400412D")]
	public const short Nanites = 1346;

	[Cpp2IlInjected.Token(Token = "0x400412E")]
	public const short ExplosivePowder = 1347;

	[Cpp2IlInjected.Token(Token = "0x400412F")]
	public const short GoldDust = 1348;

	[Cpp2IlInjected.Token(Token = "0x4004130")]
	public const short PartyBullet = 1349;

	[Cpp2IlInjected.Token(Token = "0x4004131")]
	public const short NanoBullet = 1350;

	[Cpp2IlInjected.Token(Token = "0x4004132")]
	public const short ExplodingBullet = 1351;

	[Cpp2IlInjected.Token(Token = "0x4004133")]
	public const short GoldenBullet = 1352;

	[Cpp2IlInjected.Token(Token = "0x4004134")]
	public const short FlaskofCursedFlames = 1353;

	[Cpp2IlInjected.Token(Token = "0x4004135")]
	public const short FlaskofFire = 1354;

	[Cpp2IlInjected.Token(Token = "0x4004136")]
	public const short FlaskofGold = 1355;

	[Cpp2IlInjected.Token(Token = "0x4004137")]
	public const short FlaskofIchor = 1356;

	[Cpp2IlInjected.Token(Token = "0x4004138")]
	public const short FlaskofNanites = 1357;

	[Cpp2IlInjected.Token(Token = "0x4004139")]
	public const short FlaskofParty = 1358;

	[Cpp2IlInjected.Token(Token = "0x400413A")]
	public const short FlaskofPoison = 1359;

	[Cpp2IlInjected.Token(Token = "0x400413B")]
	public const short EyeofCthulhuTrophy = 1360;

	[Cpp2IlInjected.Token(Token = "0x400413C")]
	public const short EaterofWorldsTrophy = 1361;

	[Cpp2IlInjected.Token(Token = "0x400413D")]
	public const short BrainofCthulhuTrophy = 1362;

	[Cpp2IlInjected.Token(Token = "0x400413E")]
	public const short SkeletronTrophy = 1363;

	[Cpp2IlInjected.Token(Token = "0x400413F")]
	public const short QueenBeeTrophy = 1364;

	[Cpp2IlInjected.Token(Token = "0x4004140")]
	public const short WallofFleshTrophy = 1365;

	[Cpp2IlInjected.Token(Token = "0x4004141")]
	public const short DestroyerTrophy = 1366;

	[Cpp2IlInjected.Token(Token = "0x4004142")]
	public const short SkeletronPrimeTrophy = 1367;

	[Cpp2IlInjected.Token(Token = "0x4004143")]
	public const short RetinazerTrophy = 1368;

	[Cpp2IlInjected.Token(Token = "0x4004144")]
	public const short SpazmatismTrophy = 1369;

	[Cpp2IlInjected.Token(Token = "0x4004145")]
	public const short PlanteraTrophy = 1370;

	[Cpp2IlInjected.Token(Token = "0x4004146")]
	public const short GolemTrophy = 1371;

	[Cpp2IlInjected.Token(Token = "0x4004147")]
	public const short BloodMoonRising = 1372;

	[Cpp2IlInjected.Token(Token = "0x4004148")]
	public const short TheHangedMan = 1373;

	[Cpp2IlInjected.Token(Token = "0x4004149")]
	public const short GloryoftheFire = 1374;

	[Cpp2IlInjected.Token(Token = "0x400414A")]
	public const short BoneWarp = 1375;

	[Cpp2IlInjected.Token(Token = "0x400414B")]
	public const short WallSkeleton = 1376;

	[Cpp2IlInjected.Token(Token = "0x400414C")]
	public const short HangingSkeleton = 1377;

	[Cpp2IlInjected.Token(Token = "0x400414D")]
	public const short BlueSlabWall = 1378;

	[Cpp2IlInjected.Token(Token = "0x400414E")]
	public const short BlueTiledWall = 1379;

	[Cpp2IlInjected.Token(Token = "0x400414F")]
	public const short PinkSlabWall = 1380;

	[Cpp2IlInjected.Token(Token = "0x4004150")]
	public const short PinkTiledWall = 1381;

	[Cpp2IlInjected.Token(Token = "0x4004151")]
	public const short GreenSlabWall = 1382;

	[Cpp2IlInjected.Token(Token = "0x4004152")]
	public const short GreenTiledWall = 1383;

	[Cpp2IlInjected.Token(Token = "0x4004153")]
	public const short BlueBrickPlatform = 1384;

	[Cpp2IlInjected.Token(Token = "0x4004154")]
	public const short PinkBrickPlatform = 1385;

	[Cpp2IlInjected.Token(Token = "0x4004155")]
	public const short GreenBrickPlatform = 1386;

	[Cpp2IlInjected.Token(Token = "0x4004156")]
	public const short MetalShelf = 1387;

	[Cpp2IlInjected.Token(Token = "0x4004157")]
	public const short BrassShelf = 1388;

	[Cpp2IlInjected.Token(Token = "0x4004158")]
	public const short WoodShelf = 1389;

	[Cpp2IlInjected.Token(Token = "0x4004159")]
	public const short BrassLantern = 1390;

	[Cpp2IlInjected.Token(Token = "0x400415A")]
	public const short CagedLantern = 1391;

	[Cpp2IlInjected.Token(Token = "0x400415B")]
	public const short CarriageLantern = 1392;

	[Cpp2IlInjected.Token(Token = "0x400415C")]
	public const short AlchemyLantern = 1393;

	[Cpp2IlInjected.Token(Token = "0x400415D")]
	public const short DiablostLamp = 1394;

	[Cpp2IlInjected.Token(Token = "0x400415E")]
	public const short OilRagSconse = 1395;

	[Cpp2IlInjected.Token(Token = "0x400415F")]
	public const short BlueDungeonChair = 1396;

	[Cpp2IlInjected.Token(Token = "0x4004160")]
	public const short BlueDungeonTable = 1397;

	[Cpp2IlInjected.Token(Token = "0x4004161")]
	public const short BlueDungeonWorkBench = 1398;

	[Cpp2IlInjected.Token(Token = "0x4004162")]
	public const short GreenDungeonChair = 1399;

	[Cpp2IlInjected.Token(Token = "0x4004163")]
	public const short GreenDungeonTable = 1400;

	[Cpp2IlInjected.Token(Token = "0x4004164")]
	public const short GreenDungeonWorkBench = 1401;

	[Cpp2IlInjected.Token(Token = "0x4004165")]
	public const short PinkDungeonChair = 1402;

	[Cpp2IlInjected.Token(Token = "0x4004166")]
	public const short PinkDungeonTable = 1403;

	[Cpp2IlInjected.Token(Token = "0x4004167")]
	public const short PinkDungeonWorkBench = 1404;

	[Cpp2IlInjected.Token(Token = "0x4004168")]
	public const short BlueDungeonCandle = 1405;

	[Cpp2IlInjected.Token(Token = "0x4004169")]
	public const short GreenDungeonCandle = 1406;

	[Cpp2IlInjected.Token(Token = "0x400416A")]
	public const short PinkDungeonCandle = 1407;

	[Cpp2IlInjected.Token(Token = "0x400416B")]
	public const short BlueDungeonVase = 1408;

	[Cpp2IlInjected.Token(Token = "0x400416C")]
	public const short GreenDungeonVase = 1409;

	[Cpp2IlInjected.Token(Token = "0x400416D")]
	public const short PinkDungeonVase = 1410;

	[Cpp2IlInjected.Token(Token = "0x400416E")]
	public const short BlueDungeonDoor = 1411;

	[Cpp2IlInjected.Token(Token = "0x400416F")]
	public const short GreenDungeonDoor = 1412;

	[Cpp2IlInjected.Token(Token = "0x4004170")]
	public const short PinkDungeonDoor = 1413;

	[Cpp2IlInjected.Token(Token = "0x4004171")]
	public const short BlueDungeonBookcase = 1414;

	[Cpp2IlInjected.Token(Token = "0x4004172")]
	public const short GreenDungeonBookcase = 1415;

	[Cpp2IlInjected.Token(Token = "0x4004173")]
	public const short PinkDungeonBookcase = 1416;

	[Cpp2IlInjected.Token(Token = "0x4004174")]
	public const short Catacomb = 1417;

	[Cpp2IlInjected.Token(Token = "0x4004175")]
	public const short DungeonShelf = 1418;

	[Cpp2IlInjected.Token(Token = "0x4004176")]
	public const short SkellingtonJSkellingsworth = 1419;

	[Cpp2IlInjected.Token(Token = "0x4004177")]
	public const short TheCursedMan = 1420;

	[Cpp2IlInjected.Token(Token = "0x4004178")]
	public const short TheEyeSeestheEnd = 1421;

	[Cpp2IlInjected.Token(Token = "0x4004179")]
	public const short SomethingEvilisWatchingYou = 1422;

	[Cpp2IlInjected.Token(Token = "0x400417A")]
	public const short TheTwinsHaveAwoken = 1423;

	[Cpp2IlInjected.Token(Token = "0x400417B")]
	public const short TheScreamer = 1424;

	[Cpp2IlInjected.Token(Token = "0x400417C")]
	public const short GoblinsPlayingPoker = 1425;

	[Cpp2IlInjected.Token(Token = "0x400417D")]
	public const short Dryadisque = 1426;

	[Cpp2IlInjected.Token(Token = "0x400417E")]
	public const short Sunflowers = 1427;

	[Cpp2IlInjected.Token(Token = "0x400417F")]
	public const short TerrarianGothic = 1428;

	[Cpp2IlInjected.Token(Token = "0x4004180")]
	public const short Beanie = 1429;

	[Cpp2IlInjected.Token(Token = "0x4004181")]
	public const short ImbuingStation = 1430;

	[Cpp2IlInjected.Token(Token = "0x4004182")]
	public const short StarinaBottle = 1431;

	[Cpp2IlInjected.Token(Token = "0x4004183")]
	public const short EmptyBullet = 1432;

	[Cpp2IlInjected.Token(Token = "0x4004184")]
	public const short Impact = 1433;

	[Cpp2IlInjected.Token(Token = "0x4004185")]
	public const short PoweredbyBirds = 1434;

	[Cpp2IlInjected.Token(Token = "0x4004186")]
	public const short TheDestroyer = 1435;

	[Cpp2IlInjected.Token(Token = "0x4004187")]
	public const short ThePersistencyofEyes = 1436;

	[Cpp2IlInjected.Token(Token = "0x4004188")]
	public const short UnicornCrossingtheHallows = 1437;

	[Cpp2IlInjected.Token(Token = "0x4004189")]
	public const short GreatWave = 1438;

	[Cpp2IlInjected.Token(Token = "0x400418A")]
	public const short StarryNight = 1439;

	[Cpp2IlInjected.Token(Token = "0x400418B")]
	public const short GuidePicasso = 1440;

	[Cpp2IlInjected.Token(Token = "0x400418C")]
	public const short TheGuardiansGaze = 1441;

	[Cpp2IlInjected.Token(Token = "0x400418D")]
	public const short FatherofSomeone = 1442;

	[Cpp2IlInjected.Token(Token = "0x400418E")]
	public const short NurseLisa = 1443;

	[Cpp2IlInjected.Token(Token = "0x400418F")]
	public const short ShadowbeamStaff = 1444;

	[Cpp2IlInjected.Token(Token = "0x4004190")]
	public const short InfernoFork = 1445;

	[Cpp2IlInjected.Token(Token = "0x4004191")]
	public const short SpectreStaff = 1446;

	[Cpp2IlInjected.Token(Token = "0x4004192")]
	public const short WoodenFence = 1447;

	[Cpp2IlInjected.Token(Token = "0x4004193")]
	public const short LeadFence = 1448;

	[Cpp2IlInjected.Token(Token = "0x4004194")]
	public const short BubbleMachine = 1449;

	[Cpp2IlInjected.Token(Token = "0x4004195")]
	public const short BubbleWand = 1450;

	[Cpp2IlInjected.Token(Token = "0x4004196")]
	public const short MarchingBonesBanner = 1451;

	[Cpp2IlInjected.Token(Token = "0x4004197")]
	public const short NecromanticSign = 1452;

	[Cpp2IlInjected.Token(Token = "0x4004198")]
	public const short RustedCompanyStandard = 1453;

	[Cpp2IlInjected.Token(Token = "0x4004199")]
	public const short RaggedBrotherhoodSigil = 1454;

	[Cpp2IlInjected.Token(Token = "0x400419A")]
	public const short MoltenLegionFlag = 1455;

	[Cpp2IlInjected.Token(Token = "0x400419B")]
	public const short DiabolicSigil = 1456;

	[Cpp2IlInjected.Token(Token = "0x400419C")]
	public const short ObsidianPlatform = 1457;

	[Cpp2IlInjected.Token(Token = "0x400419D")]
	public const short ObsidianDoor = 1458;

	[Cpp2IlInjected.Token(Token = "0x400419E")]
	public const short ObsidianChair = 1459;

	[Cpp2IlInjected.Token(Token = "0x400419F")]
	public const short ObsidianTable = 1460;

	[Cpp2IlInjected.Token(Token = "0x40041A0")]
	public const short ObsidianWorkBench = 1461;

	[Cpp2IlInjected.Token(Token = "0x40041A1")]
	public const short ObsidianVase = 1462;

	[Cpp2IlInjected.Token(Token = "0x40041A2")]
	public const short ObsidianBookcase = 1463;

	[Cpp2IlInjected.Token(Token = "0x40041A3")]
	public const short HellboundBanner = 1464;

	[Cpp2IlInjected.Token(Token = "0x40041A4")]
	public const short HellHammerBanner = 1465;

	[Cpp2IlInjected.Token(Token = "0x40041A5")]
	public const short HelltowerBanner = 1466;

	[Cpp2IlInjected.Token(Token = "0x40041A6")]
	public const short LostHopesofManBanner = 1467;

	[Cpp2IlInjected.Token(Token = "0x40041A7")]
	public const short ObsidianWatcherBanner = 1468;

	[Cpp2IlInjected.Token(Token = "0x40041A8")]
	public const short LavaEruptsBanner = 1469;

	[Cpp2IlInjected.Token(Token = "0x40041A9")]
	public const short BlueDungeonBed = 1470;

	[Cpp2IlInjected.Token(Token = "0x40041AA")]
	public const short GreenDungeonBed = 1471;

	[Cpp2IlInjected.Token(Token = "0x40041AB")]
	public const short PinkDungeonBed = 1472;

	[Cpp2IlInjected.Token(Token = "0x40041AC")]
	public const short ObsidianBed = 1473;

	[Cpp2IlInjected.Token(Token = "0x40041AD")]
	public const short Waldo = 1474;

	[Cpp2IlInjected.Token(Token = "0x40041AE")]
	public const short Darkness = 1475;

	[Cpp2IlInjected.Token(Token = "0x40041AF")]
	public const short DarkSoulReaper = 1476;

	[Cpp2IlInjected.Token(Token = "0x40041B0")]
	public const short Land = 1477;

	[Cpp2IlInjected.Token(Token = "0x40041B1")]
	public const short TrappedGhost = 1478;

	[Cpp2IlInjected.Token(Token = "0x40041B2")]
	public const short DemonsEye = 1479;

	[Cpp2IlInjected.Token(Token = "0x40041B3")]
	public const short FindingGold = 1480;

	[Cpp2IlInjected.Token(Token = "0x40041B4")]
	public const short FirstEncounter = 1481;

	[Cpp2IlInjected.Token(Token = "0x40041B5")]
	public const short GoodMorning = 1482;

	[Cpp2IlInjected.Token(Token = "0x40041B6")]
	public const short UndergroundReward = 1483;

	[Cpp2IlInjected.Token(Token = "0x40041B7")]
	public const short ThroughtheWindow = 1484;

	[Cpp2IlInjected.Token(Token = "0x40041B8")]
	public const short PlaceAbovetheClouds = 1485;

	[Cpp2IlInjected.Token(Token = "0x40041B9")]
	public const short DoNotStepontheGrass = 1486;

	[Cpp2IlInjected.Token(Token = "0x40041BA")]
	public const short ColdWatersintheWhiteLand = 1487;

	[Cpp2IlInjected.Token(Token = "0x40041BB")]
	public const short LightlessChasms = 1488;

	[Cpp2IlInjected.Token(Token = "0x40041BC")]
	public const short TheLandofDeceivingLooks = 1489;

	[Cpp2IlInjected.Token(Token = "0x40041BD")]
	public const short Daylight = 1490;

	[Cpp2IlInjected.Token(Token = "0x40041BE")]
	public const short SecretoftheSands = 1491;

	[Cpp2IlInjected.Token(Token = "0x40041BF")]
	public const short DeadlandComesAlive = 1492;

	[Cpp2IlInjected.Token(Token = "0x40041C0")]
	public const short EvilPresence = 1493;

	[Cpp2IlInjected.Token(Token = "0x40041C1")]
	public const short SkyGuardian = 1494;

	[Cpp2IlInjected.Token(Token = "0x40041C2")]
	public const short AmericanExplosive = 1495;

	[Cpp2IlInjected.Token(Token = "0x40041C3")]
	public const short Discover = 1496;

	[Cpp2IlInjected.Token(Token = "0x40041C4")]
	public const short HandEarth = 1497;

	[Cpp2IlInjected.Token(Token = "0x40041C5")]
	public const short OldMiner = 1498;

	[Cpp2IlInjected.Token(Token = "0x40041C6")]
	public const short Skelehead = 1499;

	[Cpp2IlInjected.Token(Token = "0x40041C7")]
	public const short FacingtheCerebralMastermind = 1500;

	[Cpp2IlInjected.Token(Token = "0x40041C8")]
	public const short LakeofFire = 1501;

	[Cpp2IlInjected.Token(Token = "0x40041C9")]
	public const short TrioSuperHeroes = 1502;

	[Cpp2IlInjected.Token(Token = "0x40041CA")]
	public const short SpectreHood = 1503;

	[Cpp2IlInjected.Token(Token = "0x40041CB")]
	public const short SpectreRobe = 1504;

	[Cpp2IlInjected.Token(Token = "0x40041CC")]
	public const short SpectrePants = 1505;

	[Cpp2IlInjected.Token(Token = "0x40041CD")]
	public const short SpectrePickaxe = 1506;

	[Cpp2IlInjected.Token(Token = "0x40041CE")]
	public const short SpectreHamaxe = 1507;

	[Cpp2IlInjected.Token(Token = "0x40041CF")]
	public const short Ectoplasm = 1508;

	[Cpp2IlInjected.Token(Token = "0x40041D0")]
	public const short GothicChair = 1509;

	[Cpp2IlInjected.Token(Token = "0x40041D1")]
	public const short GothicTable = 1510;

	[Cpp2IlInjected.Token(Token = "0x40041D2")]
	public const short GothicWorkBench = 1511;

	[Cpp2IlInjected.Token(Token = "0x40041D3")]
	public const short GothicBookcase = 1512;

	[Cpp2IlInjected.Token(Token = "0x40041D4")]
	public const short PaladinsHammer = 1513;

	[Cpp2IlInjected.Token(Token = "0x40041D5")]
	public const short SWATHelmet = 1514;

	[Cpp2IlInjected.Token(Token = "0x40041D6")]
	public const short BeeWings = 1515;

	[Cpp2IlInjected.Token(Token = "0x40041D7")]
	public const short GiantHarpyFeather = 1516;

	[Cpp2IlInjected.Token(Token = "0x40041D8")]
	public const short BoneFeather = 1517;

	[Cpp2IlInjected.Token(Token = "0x40041D9")]
	public const short FireFeather = 1518;

	[Cpp2IlInjected.Token(Token = "0x40041DA")]
	public const short IceFeather = 1519;

	[Cpp2IlInjected.Token(Token = "0x40041DB")]
	public const short BrokenBatWing = 1520;

	[Cpp2IlInjected.Token(Token = "0x40041DC")]
	public const short TatteredBeeWing = 1521;

	[Cpp2IlInjected.Token(Token = "0x40041DD")]
	public const short LargeAmethyst = 1522;

	[Cpp2IlInjected.Token(Token = "0x40041DE")]
	public const short LargeTopaz = 1523;

	[Cpp2IlInjected.Token(Token = "0x40041DF")]
	public const short LargeSapphire = 1524;

	[Cpp2IlInjected.Token(Token = "0x40041E0")]
	public const short LargeEmerald = 1525;

	[Cpp2IlInjected.Token(Token = "0x40041E1")]
	public const short LargeRuby = 1526;

	[Cpp2IlInjected.Token(Token = "0x40041E2")]
	public const short LargeDiamond = 1527;

	[Cpp2IlInjected.Token(Token = "0x40041E3")]
	public const short JungleChest = 1528;

	[Cpp2IlInjected.Token(Token = "0x40041E4")]
	public const short CorruptionChest = 1529;

	[Cpp2IlInjected.Token(Token = "0x40041E5")]
	public const short CrimsonChest = 1530;

	[Cpp2IlInjected.Token(Token = "0x40041E6")]
	public const short HallowedChest = 1531;

	[Cpp2IlInjected.Token(Token = "0x40041E7")]
	public const short FrozenChest = 1532;

	[Cpp2IlInjected.Token(Token = "0x40041E8")]
	public const short JungleKey = 1533;

	[Cpp2IlInjected.Token(Token = "0x40041E9")]
	public const short CorruptionKey = 1534;

	[Cpp2IlInjected.Token(Token = "0x40041EA")]
	public const short CrimsonKey = 1535;

	[Cpp2IlInjected.Token(Token = "0x40041EB")]
	public const short HallowedKey = 1536;

	[Cpp2IlInjected.Token(Token = "0x40041EC")]
	public const short FrozenKey = 1537;

	[Cpp2IlInjected.Token(Token = "0x40041ED")]
	public const short ImpFace = 1538;

	[Cpp2IlInjected.Token(Token = "0x40041EE")]
	public const short OminousPresence = 1539;

	[Cpp2IlInjected.Token(Token = "0x40041EF")]
	public const short ShiningMoon = 1540;

	[Cpp2IlInjected.Token(Token = "0x40041F0")]
	public const short LivingGore = 1541;

	[Cpp2IlInjected.Token(Token = "0x40041F1")]
	public const short FlowingMagma = 1542;

	[Cpp2IlInjected.Token(Token = "0x40041F2")]
	public const short SpectrePaintbrush = 1543;

	[Cpp2IlInjected.Token(Token = "0x40041F3")]
	public const short SpectrePaintRoller = 1544;

	[Cpp2IlInjected.Token(Token = "0x40041F4")]
	public const short SpectrePaintScraper = 1545;

	[Cpp2IlInjected.Token(Token = "0x40041F5")]
	public const short ShroomiteHeadgear = 1546;

	[Cpp2IlInjected.Token(Token = "0x40041F6")]
	public const short ShroomiteMask = 1547;

	[Cpp2IlInjected.Token(Token = "0x40041F7")]
	public const short ShroomiteHelmet = 1548;

	[Cpp2IlInjected.Token(Token = "0x40041F8")]
	public const short ShroomiteBreastplate = 1549;

	[Cpp2IlInjected.Token(Token = "0x40041F9")]
	public const short ShroomiteLeggings = 1550;

	[Cpp2IlInjected.Token(Token = "0x40041FA")]
	public const short Autohammer = 1551;

	[Cpp2IlInjected.Token(Token = "0x40041FB")]
	public const short ShroomiteBar = 1552;

	[Cpp2IlInjected.Token(Token = "0x40041FC")]
	public const short SDMG = 1553;

	[Cpp2IlInjected.Token(Token = "0x40041FD")]
	public const short CenxsTiara = 1554;

	[Cpp2IlInjected.Token(Token = "0x40041FE")]
	public const short CenxsBreastplate = 1555;

	[Cpp2IlInjected.Token(Token = "0x40041FF")]
	public const short CenxsLeggings = 1556;

	[Cpp2IlInjected.Token(Token = "0x4004200")]
	public const short CrownosMask = 1557;

	[Cpp2IlInjected.Token(Token = "0x4004201")]
	public const short CrownosBreastplate = 1558;

	[Cpp2IlInjected.Token(Token = "0x4004202")]
	public const short CrownosLeggings = 1559;

	[Cpp2IlInjected.Token(Token = "0x4004203")]
	public const short WillsHelmet = 1560;

	[Cpp2IlInjected.Token(Token = "0x4004204")]
	public const short WillsBreastplate = 1561;

	[Cpp2IlInjected.Token(Token = "0x4004205")]
	public const short WillsLeggings = 1562;

	[Cpp2IlInjected.Token(Token = "0x4004206")]
	public const short JimsHelmet = 1563;

	[Cpp2IlInjected.Token(Token = "0x4004207")]
	public const short JimsBreastplate = 1564;

	[Cpp2IlInjected.Token(Token = "0x4004208")]
	public const short JimsLeggings = 1565;

	[Cpp2IlInjected.Token(Token = "0x4004209")]
	public const short AaronsHelmet = 1566;

	[Cpp2IlInjected.Token(Token = "0x400420A")]
	public const short AaronsBreastplate = 1567;

	[Cpp2IlInjected.Token(Token = "0x400420B")]
	public const short AaronsLeggings = 1568;

	[Cpp2IlInjected.Token(Token = "0x400420C")]
	public const short VampireKnives = 1569;

	[Cpp2IlInjected.Token(Token = "0x400420D")]
	public const short BrokenHeroSword = 1570;

	[Cpp2IlInjected.Token(Token = "0x400420E")]
	public const short ScourgeoftheCorruptor = 1571;

	[Cpp2IlInjected.Token(Token = "0x400420F")]
	public const short StaffoftheFrostHydra = 1572;

	[Cpp2IlInjected.Token(Token = "0x4004210")]
	public const short TheCreationoftheGuide = 1573;

	[Cpp2IlInjected.Token(Token = "0x4004211")]
	public const short TheMerchant = 1574;

	[Cpp2IlInjected.Token(Token = "0x4004212")]
	public const short CrownoDevoursHisLunch = 1575;

	[Cpp2IlInjected.Token(Token = "0x4004213")]
	public const short RareEnchantment = 1576;

	[Cpp2IlInjected.Token(Token = "0x4004214")]
	public const short GloriousNight = 1577;

	[Cpp2IlInjected.Token(Token = "0x4004215")]
	public const short SweetheartNecklace = 1578;

	[Cpp2IlInjected.Token(Token = "0x4004216")]
	public const short FlurryBoots = 1579;

	[Cpp2IlInjected.Token(Token = "0x4004217")]
	public const short DTownsHelmet = 1580;

	[Cpp2IlInjected.Token(Token = "0x4004218")]
	public const short DTownsBreastplate = 1581;

	[Cpp2IlInjected.Token(Token = "0x4004219")]
	public const short DTownsLeggings = 1582;

	[Cpp2IlInjected.Token(Token = "0x400421A")]
	public const short DTownsWings = 1583;

	[Cpp2IlInjected.Token(Token = "0x400421B")]
	public const short WillsWings = 1584;

	[Cpp2IlInjected.Token(Token = "0x400421C")]
	public const short CrownosWings = 1585;

	[Cpp2IlInjected.Token(Token = "0x400421D")]
	public const short CenxsWings = 1586;

	[Cpp2IlInjected.Token(Token = "0x400421E")]
	public const short CenxsDress = 1587;

	[Cpp2IlInjected.Token(Token = "0x400421F")]
	public const short CenxsDressPants = 1588;

	[Cpp2IlInjected.Token(Token = "0x4004220")]
	public const short PalladiumColumn = 1589;

	[Cpp2IlInjected.Token(Token = "0x4004221")]
	public const short PalladiumColumnWall = 1590;

	[Cpp2IlInjected.Token(Token = "0x4004222")]
	public const short BubblegumBlock = 1591;

	[Cpp2IlInjected.Token(Token = "0x4004223")]
	public const short BubblegumBlockWall = 1592;

	[Cpp2IlInjected.Token(Token = "0x4004224")]
	public const short TitanstoneBlock = 1593;

	[Cpp2IlInjected.Token(Token = "0x4004225")]
	public const short TitanstoneBlockWall = 1594;

	[Cpp2IlInjected.Token(Token = "0x4004226")]
	public const short MagicCuffs = 1595;

	[Cpp2IlInjected.Token(Token = "0x4004227")]
	public const short MusicBoxSnow = 1596;

	[Cpp2IlInjected.Token(Token = "0x4004228")]
	public const short MusicBoxSpace = 1597;

	[Cpp2IlInjected.Token(Token = "0x4004229")]
	public const short MusicBoxCrimson = 1598;

	[Cpp2IlInjected.Token(Token = "0x400422A")]
	public const short MusicBoxBoss4 = 1599;

	[Cpp2IlInjected.Token(Token = "0x400422B")]
	public const short MusicBoxAltOverworldDay = 1600;

	[Cpp2IlInjected.Token(Token = "0x400422C")]
	public const short MusicBoxRain = 1601;

	[Cpp2IlInjected.Token(Token = "0x400422D")]
	public const short MusicBoxIce = 1602;

	[Cpp2IlInjected.Token(Token = "0x400422E")]
	public const short MusicBoxDesert = 1603;

	[Cpp2IlInjected.Token(Token = "0x400422F")]
	public const short MusicBoxOcean = 1604;

	[Cpp2IlInjected.Token(Token = "0x4004230")]
	public const short MusicBoxDungeon = 1605;

	[Cpp2IlInjected.Token(Token = "0x4004231")]
	public const short MusicBoxPlantera = 1606;

	[Cpp2IlInjected.Token(Token = "0x4004232")]
	public const short MusicBoxBoss5 = 1607;

	[Cpp2IlInjected.Token(Token = "0x4004233")]
	public const short MusicBoxTemple = 1608;

	[Cpp2IlInjected.Token(Token = "0x4004234")]
	public const short MusicBoxEclipse = 1609;

	[Cpp2IlInjected.Token(Token = "0x4004235")]
	public const short MusicBoxMushrooms = 1610;

	[Cpp2IlInjected.Token(Token = "0x4004236")]
	public const short ButterflyDust = 1611;

	[Cpp2IlInjected.Token(Token = "0x4004237")]
	public const short AnkhCharm = 1612;

	[Cpp2IlInjected.Token(Token = "0x4004238")]
	public const short AnkhShield = 1613;

	[Cpp2IlInjected.Token(Token = "0x4004239")]
	public const short BlueFlare = 1614;

	[Cpp2IlInjected.Token(Token = "0x400423A")]
	public const short AnglerFishBanner = 1615;

	[Cpp2IlInjected.Token(Token = "0x400423B")]
	public const short AngryNimbusBanner = 1616;

	[Cpp2IlInjected.Token(Token = "0x400423C")]
	public const short AnomuraFungusBanner = 1617;

	[Cpp2IlInjected.Token(Token = "0x400423D")]
	public const short AntlionBanner = 1618;

	[Cpp2IlInjected.Token(Token = "0x400423E")]
	public const short ArapaimaBanner = 1619;

	[Cpp2IlInjected.Token(Token = "0x400423F")]
	public const short ArmoredSkeletonBanner = 1620;

	[Cpp2IlInjected.Token(Token = "0x4004240")]
	public const short BatBanner = 1621;

	[Cpp2IlInjected.Token(Token = "0x4004241")]
	public const short BirdBanner = 1622;

	[Cpp2IlInjected.Token(Token = "0x4004242")]
	public const short BlackRecluseBanner = 1623;

	[Cpp2IlInjected.Token(Token = "0x4004243")]
	public const short BloodFeederBanner = 1624;

	[Cpp2IlInjected.Token(Token = "0x4004244")]
	public const short BloodJellyBanner = 1625;

	[Cpp2IlInjected.Token(Token = "0x4004245")]
	public const short BloodCrawlerBanner = 1626;

	[Cpp2IlInjected.Token(Token = "0x4004246")]
	public const short BoneSerpentBanner = 1627;

	[Cpp2IlInjected.Token(Token = "0x4004247")]
	public const short BunnyBanner = 1628;

	[Cpp2IlInjected.Token(Token = "0x4004248")]
	public const short ChaosElementalBanner = 1629;

	[Cpp2IlInjected.Token(Token = "0x4004249")]
	public const short MimicBanner = 1630;

	[Cpp2IlInjected.Token(Token = "0x400424A")]
	public const short ClownBanner = 1631;

	[Cpp2IlInjected.Token(Token = "0x400424B")]
	public const short CorruptBunnyBanner = 1632;

	[Cpp2IlInjected.Token(Token = "0x400424C")]
	public const short CorruptGoldfishBanner = 1633;

	[Cpp2IlInjected.Token(Token = "0x400424D")]
	public const short CrabBanner = 1634;

	[Cpp2IlInjected.Token(Token = "0x400424E")]
	public const short CrimeraBanner = 1635;

	[Cpp2IlInjected.Token(Token = "0x400424F")]
	public const short CrimsonAxeBanner = 1636;

	[Cpp2IlInjected.Token(Token = "0x4004250")]
	public const short CursedHammerBanner = 1637;

	[Cpp2IlInjected.Token(Token = "0x4004251")]
	public const short DemonBanner = 1638;

	[Cpp2IlInjected.Token(Token = "0x4004252")]
	public const short DemonEyeBanner = 1639;

	[Cpp2IlInjected.Token(Token = "0x4004253")]
	public const short DerplingBanner = 1640;

	[Cpp2IlInjected.Token(Token = "0x4004254")]
	public const short EaterofSoulsBanner = 1641;

	[Cpp2IlInjected.Token(Token = "0x4004255")]
	public const short EnchantedSwordBanner = 1642;

	[Cpp2IlInjected.Token(Token = "0x4004256")]
	public const short ZombieEskimoBanner = 1643;

	[Cpp2IlInjected.Token(Token = "0x4004257")]
	public const short FaceMonsterBanner = 1644;

	[Cpp2IlInjected.Token(Token = "0x4004258")]
	public const short FloatyGrossBanner = 1645;

	[Cpp2IlInjected.Token(Token = "0x4004259")]
	public const short FlyingFishBanner = 1646;

	[Cpp2IlInjected.Token(Token = "0x400425A")]
	public const short FlyingSnakeBanner = 1647;

	[Cpp2IlInjected.Token(Token = "0x400425B")]
	public const short FrankensteinBanner = 1648;

	[Cpp2IlInjected.Token(Token = "0x400425C")]
	public const short FungiBulbBanner = 1649;

	[Cpp2IlInjected.Token(Token = "0x400425D")]
	public const short FungoFishBanner = 1650;

	[Cpp2IlInjected.Token(Token = "0x400425E")]
	public const short GastropodBanner = 1651;

	[Cpp2IlInjected.Token(Token = "0x400425F")]
	public const short GoblinThiefBanner = 1652;

	[Cpp2IlInjected.Token(Token = "0x4004260")]
	public const short GoblinSorcererBanner = 1653;

	[Cpp2IlInjected.Token(Token = "0x4004261")]
	public const short GoblinPeonBanner = 1654;

	[Cpp2IlInjected.Token(Token = "0x4004262")]
	public const short GoblinScoutBanner = 1655;

	[Cpp2IlInjected.Token(Token = "0x4004263")]
	public const short GoblinWarriorBanner = 1656;

	[Cpp2IlInjected.Token(Token = "0x4004264")]
	public const short GoldfishBanner = 1657;

	[Cpp2IlInjected.Token(Token = "0x4004265")]
	public const short HarpyBanner = 1658;

	[Cpp2IlInjected.Token(Token = "0x4004266")]
	public const short HellbatBanner = 1659;

	[Cpp2IlInjected.Token(Token = "0x4004267")]
	public const short HerplingBanner = 1660;

	[Cpp2IlInjected.Token(Token = "0x4004268")]
	public const short HornetBanner = 1661;

	[Cpp2IlInjected.Token(Token = "0x4004269")]
	public const short IceElementalBanner = 1662;

	[Cpp2IlInjected.Token(Token = "0x400426A")]
	public const short IcyMermanBanner = 1663;

	[Cpp2IlInjected.Token(Token = "0x400426B")]
	public const short FireImpBanner = 1664;

	[Cpp2IlInjected.Token(Token = "0x400426C")]
	public const short JellyfishBanner = 1665;

	[Cpp2IlInjected.Token(Token = "0x400426D")]
	public const short JungleCreeperBanner = 1666;

	[Cpp2IlInjected.Token(Token = "0x400426E")]
	public const short LihzahrdBanner = 1667;

	[Cpp2IlInjected.Token(Token = "0x400426F")]
	public const short ManEaterBanner = 1668;

	[Cpp2IlInjected.Token(Token = "0x4004270")]
	public const short MeteorHeadBanner = 1669;

	[Cpp2IlInjected.Token(Token = "0x4004271")]
	public const short MothBanner = 1670;

	[Cpp2IlInjected.Token(Token = "0x4004272")]
	public const short MummyBanner = 1671;

	[Cpp2IlInjected.Token(Token = "0x4004273")]
	public const short MushiLadybugBanner = 1672;

	[Cpp2IlInjected.Token(Token = "0x4004274")]
	public const short ParrotBanner = 1673;

	[Cpp2IlInjected.Token(Token = "0x4004275")]
	public const short PigronBanner = 1674;

	[Cpp2IlInjected.Token(Token = "0x4004276")]
	public const short PiranhaBanner = 1675;

	[Cpp2IlInjected.Token(Token = "0x4004277")]
	public const short PirateBanner = 1676;

	[Cpp2IlInjected.Token(Token = "0x4004278")]
	public const short PixieBanner = 1677;

	[Cpp2IlInjected.Token(Token = "0x4004279")]
	public const short RaincoatZombieBanner = 1678;

	[Cpp2IlInjected.Token(Token = "0x400427A")]
	public const short ReaperBanner = 1679;

	[Cpp2IlInjected.Token(Token = "0x400427B")]
	public const short SharkBanner = 1680;

	[Cpp2IlInjected.Token(Token = "0x400427C")]
	public const short SkeletonBanner = 1681;

	[Cpp2IlInjected.Token(Token = "0x400427D")]
	public const short SkeletonMageBanner = 1682;

	[Cpp2IlInjected.Token(Token = "0x400427E")]
	public const short SlimeBanner = 1683;

	[Cpp2IlInjected.Token(Token = "0x400427F")]
	public const short SnowFlinxBanner = 1684;

	[Cpp2IlInjected.Token(Token = "0x4004280")]
	public const short SpiderBanner = 1685;

	[Cpp2IlInjected.Token(Token = "0x4004281")]
	public const short SporeZombieBanner = 1686;

	[Cpp2IlInjected.Token(Token = "0x4004282")]
	public const short SwampThingBanner = 1687;

	[Cpp2IlInjected.Token(Token = "0x4004283")]
	public const short TortoiseBanner = 1688;

	[Cpp2IlInjected.Token(Token = "0x4004284")]
	public const short ToxicSludgeBanner = 1689;

	[Cpp2IlInjected.Token(Token = "0x4004285")]
	public const short UmbrellaSlimeBanner = 1690;

	[Cpp2IlInjected.Token(Token = "0x4004286")]
	public const short UnicornBanner = 1691;

	[Cpp2IlInjected.Token(Token = "0x4004287")]
	public const short VampireBanner = 1692;

	[Cpp2IlInjected.Token(Token = "0x4004288")]
	public const short VultureBanner = 1693;

	[Cpp2IlInjected.Token(Token = "0x4004289")]
	public const short NypmhBanner = 1694;

	[Cpp2IlInjected.Token(Token = "0x400428A")]
	public const short WerewolfBanner = 1695;

	[Cpp2IlInjected.Token(Token = "0x400428B")]
	public const short WolfBanner = 1696;

	[Cpp2IlInjected.Token(Token = "0x400428C")]
	public const short WorldFeederBanner = 1697;

	[Cpp2IlInjected.Token(Token = "0x400428D")]
	public const short WormBanner = 1698;

	[Cpp2IlInjected.Token(Token = "0x400428E")]
	public const short WraithBanner = 1699;

	[Cpp2IlInjected.Token(Token = "0x400428F")]
	public const short WyvernBanner = 1700;

	[Cpp2IlInjected.Token(Token = "0x4004290")]
	public const short ZombieBanner = 1701;

	[Cpp2IlInjected.Token(Token = "0x4004291")]
	public const short GlassPlatform = 1702;

	[Cpp2IlInjected.Token(Token = "0x4004292")]
	public const short GlassChair = 1703;

	[Cpp2IlInjected.Token(Token = "0x4004293")]
	public const short GoldenChair = 1704;

	[Cpp2IlInjected.Token(Token = "0x4004294")]
	public const short GoldenToilet = 1705;

	[Cpp2IlInjected.Token(Token = "0x4004295")]
	public const short BarStool = 1706;

	[Cpp2IlInjected.Token(Token = "0x4004296")]
	public const short HoneyChair = 1707;

	[Cpp2IlInjected.Token(Token = "0x4004297")]
	public const short SteampunkChair = 1708;

	[Cpp2IlInjected.Token(Token = "0x4004298")]
	public const short GlassDoor = 1709;

	[Cpp2IlInjected.Token(Token = "0x4004299")]
	public const short GoldenDoor = 1710;

	[Cpp2IlInjected.Token(Token = "0x400429A")]
	public const short HoneyDoor = 1711;

	[Cpp2IlInjected.Token(Token = "0x400429B")]
	public const short SteampunkDoor = 1712;

	[Cpp2IlInjected.Token(Token = "0x400429C")]
	public const short GlassTable = 1713;

	[Cpp2IlInjected.Token(Token = "0x400429D")]
	public const short BanquetTable = 1714;

	[Cpp2IlInjected.Token(Token = "0x400429E")]
	public const short Bar = 1715;

	[Cpp2IlInjected.Token(Token = "0x400429F")]
	public const short GoldenTable = 1716;

	[Cpp2IlInjected.Token(Token = "0x40042A0")]
	public const short HoneyTable = 1717;

	[Cpp2IlInjected.Token(Token = "0x40042A1")]
	public const short SteampunkTable = 1718;

	[Cpp2IlInjected.Token(Token = "0x40042A2")]
	public const short GlassBed = 1719;

	[Cpp2IlInjected.Token(Token = "0x40042A3")]
	public const short GoldenBed = 1720;

	[Cpp2IlInjected.Token(Token = "0x40042A4")]
	public const short HoneyBed = 1721;

	[Cpp2IlInjected.Token(Token = "0x40042A5")]
	public const short SteampunkBed = 1722;

	[Cpp2IlInjected.Token(Token = "0x40042A6")]
	public const short LivingWoodWall = 1723;

	[Cpp2IlInjected.Token(Token = "0x40042A7")]
	public const short FartinaJar = 1724;

	[Cpp2IlInjected.Token(Token = "0x40042A8")]
	public const short Pumpkin = 1725;

	[Cpp2IlInjected.Token(Token = "0x40042A9")]
	public const short PumpkinWall = 1726;

	[Cpp2IlInjected.Token(Token = "0x40042AA")]
	public const short Hay = 1727;

	[Cpp2IlInjected.Token(Token = "0x40042AB")]
	public const short HayWall = 1728;

	[Cpp2IlInjected.Token(Token = "0x40042AC")]
	public const short SpookyWood = 1729;

	[Cpp2IlInjected.Token(Token = "0x40042AD")]
	public const short SpookyWoodWall = 1730;

	[Cpp2IlInjected.Token(Token = "0x40042AE")]
	public const short PumpkinHelmet = 1731;

	[Cpp2IlInjected.Token(Token = "0x40042AF")]
	public const short PumpkinBreastplate = 1732;

	[Cpp2IlInjected.Token(Token = "0x40042B0")]
	public const short PumpkinLeggings = 1733;

	[Cpp2IlInjected.Token(Token = "0x40042B1")]
	public const short CandyApple = 1734;

	[Cpp2IlInjected.Token(Token = "0x40042B2")]
	public const short SoulCake = 1735;

	[Cpp2IlInjected.Token(Token = "0x40042B3")]
	public const short NurseHat = 1736;

	[Cpp2IlInjected.Token(Token = "0x40042B4")]
	public const short NurseShirt = 1737;

	[Cpp2IlInjected.Token(Token = "0x40042B5")]
	public const short NursePants = 1738;

	[Cpp2IlInjected.Token(Token = "0x40042B6")]
	public const short WizardsHat = 1739;

	[Cpp2IlInjected.Token(Token = "0x40042B7")]
	public const short GuyFawkesMask = 1740;

	[Cpp2IlInjected.Token(Token = "0x40042B8")]
	public const short DyeTraderRobe = 1741;

	[Cpp2IlInjected.Token(Token = "0x40042B9")]
	public const short SteampunkGoggles = 1742;

	[Cpp2IlInjected.Token(Token = "0x40042BA")]
	public const short CyborgHelmet = 1743;

	[Cpp2IlInjected.Token(Token = "0x40042BB")]
	public const short CyborgShirt = 1744;

	[Cpp2IlInjected.Token(Token = "0x40042BC")]
	public const short CyborgPants = 1745;

	[Cpp2IlInjected.Token(Token = "0x40042BD")]
	public const short CreeperMask = 1746;

	[Cpp2IlInjected.Token(Token = "0x40042BE")]
	public const short CreeperShirt = 1747;

	[Cpp2IlInjected.Token(Token = "0x40042BF")]
	public const short CreeperPants = 1748;

	[Cpp2IlInjected.Token(Token = "0x40042C0")]
	public const short CatMask = 1749;

	[Cpp2IlInjected.Token(Token = "0x40042C1")]
	public const short CatShirt = 1750;

	[Cpp2IlInjected.Token(Token = "0x40042C2")]
	public const short CatPants = 1751;

	[Cpp2IlInjected.Token(Token = "0x40042C3")]
	public const short GhostMask = 1752;

	[Cpp2IlInjected.Token(Token = "0x40042C4")]
	public const short GhostShirt = 1753;

	[Cpp2IlInjected.Token(Token = "0x40042C5")]
	public const short PumpkinMask = 1754;

	[Cpp2IlInjected.Token(Token = "0x40042C6")]
	public const short PumpkinShirt = 1755;

	[Cpp2IlInjected.Token(Token = "0x40042C7")]
	public const short PumpkinPants = 1756;

	[Cpp2IlInjected.Token(Token = "0x40042C8")]
	public const short RobotMask = 1757;

	[Cpp2IlInjected.Token(Token = "0x40042C9")]
	public const short RobotShirt = 1758;

	[Cpp2IlInjected.Token(Token = "0x40042CA")]
	public const short RobotPants = 1759;

	[Cpp2IlInjected.Token(Token = "0x40042CB")]
	public const short UnicornMask = 1760;

	[Cpp2IlInjected.Token(Token = "0x40042CC")]
	public const short UnicornShirt = 1761;

	[Cpp2IlInjected.Token(Token = "0x40042CD")]
	public const short UnicornPants = 1762;

	[Cpp2IlInjected.Token(Token = "0x40042CE")]
	public const short VampireMask = 1763;

	[Cpp2IlInjected.Token(Token = "0x40042CF")]
	public const short VampireShirt = 1764;

	[Cpp2IlInjected.Token(Token = "0x40042D0")]
	public const short VampirePants = 1765;

	[Cpp2IlInjected.Token(Token = "0x40042D1")]
	public const short WitchHat = 1766;

	[Cpp2IlInjected.Token(Token = "0x40042D2")]
	public const short LeprechaunHat = 1767;

	[Cpp2IlInjected.Token(Token = "0x40042D3")]
	public const short LeprechaunShirt = 1768;

	[Cpp2IlInjected.Token(Token = "0x40042D4")]
	public const short LeprechaunPants = 1769;

	[Cpp2IlInjected.Token(Token = "0x40042D5")]
	public const short PixieShirt = 1770;

	[Cpp2IlInjected.Token(Token = "0x40042D6")]
	public const short PixiePants = 1771;

	[Cpp2IlInjected.Token(Token = "0x40042D7")]
	public const short PrincessHat = 1772;

	[Cpp2IlInjected.Token(Token = "0x40042D8")]
	public const short PrincessDressNew = 1773;

	[Cpp2IlInjected.Token(Token = "0x40042D9")]
	public const short GoodieBag = 1774;

	[Cpp2IlInjected.Token(Token = "0x40042DA")]
	public const short WitchDress = 1775;

	[Cpp2IlInjected.Token(Token = "0x40042DB")]
	public const short WitchBoots = 1776;

	[Cpp2IlInjected.Token(Token = "0x40042DC")]
	public const short BrideofFrankensteinMask = 1777;

	[Cpp2IlInjected.Token(Token = "0x40042DD")]
	public const short BrideofFrankensteinDress = 1778;

	[Cpp2IlInjected.Token(Token = "0x40042DE")]
	public const short KarateTortoiseMask = 1779;

	[Cpp2IlInjected.Token(Token = "0x40042DF")]
	public const short KarateTortoiseShirt = 1780;

	[Cpp2IlInjected.Token(Token = "0x40042E0")]
	public const short KarateTortoisePants = 1781;

	[Cpp2IlInjected.Token(Token = "0x40042E1")]
	public const short CandyCornRifle = 1782;

	[Cpp2IlInjected.Token(Token = "0x40042E2")]
	public const short CandyCorn = 1783;

	[Cpp2IlInjected.Token(Token = "0x40042E3")]
	public const short JackOLanternLauncher = 1784;

	[Cpp2IlInjected.Token(Token = "0x40042E4")]
	public const short ExplosiveJackOLantern = 1785;

	[Cpp2IlInjected.Token(Token = "0x40042E5")]
	public const short Sickle = 1786;

	[Cpp2IlInjected.Token(Token = "0x40042E6")]
	public const short PumpkinPie = 1787;

	[Cpp2IlInjected.Token(Token = "0x40042E7")]
	public const short ScarecrowHat = 1788;

	[Cpp2IlInjected.Token(Token = "0x40042E8")]
	public const short ScarecrowShirt = 1789;

	[Cpp2IlInjected.Token(Token = "0x40042E9")]
	public const short ScarecrowPants = 1790;

	[Cpp2IlInjected.Token(Token = "0x40042EA")]
	public const short Cauldron = 1791;

	[Cpp2IlInjected.Token(Token = "0x40042EB")]
	public const short PumpkinChair = 1792;

	[Cpp2IlInjected.Token(Token = "0x40042EC")]
	public const short PumpkinDoor = 1793;

	[Cpp2IlInjected.Token(Token = "0x40042ED")]
	public const short PumpkinTable = 1794;

	[Cpp2IlInjected.Token(Token = "0x40042EE")]
	public const short PumpkinWorkBench = 1795;

	[Cpp2IlInjected.Token(Token = "0x40042EF")]
	public const short PumpkinPlatform = 1796;

	[Cpp2IlInjected.Token(Token = "0x40042F0")]
	public const short TatteredFairyWings = 1797;

	[Cpp2IlInjected.Token(Token = "0x40042F1")]
	public const short SpiderEgg = 1798;

	[Cpp2IlInjected.Token(Token = "0x40042F2")]
	public const short MagicalPumpkinSeed = 1799;

	[Cpp2IlInjected.Token(Token = "0x40042F3")]
	public const short BatHook = 1800;

	[Cpp2IlInjected.Token(Token = "0x40042F4")]
	public const short BatScepter = 1801;

	[Cpp2IlInjected.Token(Token = "0x40042F5")]
	public const short RavenStaff = 1802;

	[Cpp2IlInjected.Token(Token = "0x40042F6")]
	public const short JungleKeyMold = 1803;

	[Cpp2IlInjected.Token(Token = "0x40042F7")]
	public const short CorruptionKeyMold = 1804;

	[Cpp2IlInjected.Token(Token = "0x40042F8")]
	public const short CrimsonKeyMold = 1805;

	[Cpp2IlInjected.Token(Token = "0x40042F9")]
	public const short HallowedKeyMold = 1806;

	[Cpp2IlInjected.Token(Token = "0x40042FA")]
	public const short FrozenKeyMold = 1807;

	[Cpp2IlInjected.Token(Token = "0x40042FB")]
	public const short HangingJackOLantern = 1808;

	[Cpp2IlInjected.Token(Token = "0x40042FC")]
	public const short RottenEgg = 1809;

	[Cpp2IlInjected.Token(Token = "0x40042FD")]
	public const short UnluckyYarn = 1810;

	[Cpp2IlInjected.Token(Token = "0x40042FE")]
	public const short BlackFairyDust = 1811;

	[Cpp2IlInjected.Token(Token = "0x40042FF")]
	public const short Jackelier = 1812;

	[Cpp2IlInjected.Token(Token = "0x4004300")]
	public const short JackOLantern = 1813;

	[Cpp2IlInjected.Token(Token = "0x4004301")]
	public const short SpookyChair = 1814;

	[Cpp2IlInjected.Token(Token = "0x4004302")]
	public const short SpookyDoor = 1815;

	[Cpp2IlInjected.Token(Token = "0x4004303")]
	public const short SpookyTable = 1816;

	[Cpp2IlInjected.Token(Token = "0x4004304")]
	public const short SpookyWorkBench = 1817;

	[Cpp2IlInjected.Token(Token = "0x4004305")]
	public const short SpookyPlatform = 1818;

	[Cpp2IlInjected.Token(Token = "0x4004306")]
	public const short ReaperHood = 1819;

	[Cpp2IlInjected.Token(Token = "0x4004307")]
	public const short ReaperRobe = 1820;

	[Cpp2IlInjected.Token(Token = "0x4004308")]
	public const short FoxMask = 1821;

	[Cpp2IlInjected.Token(Token = "0x4004309")]
	public const short FoxShirt = 1822;

	[Cpp2IlInjected.Token(Token = "0x400430A")]
	public const short FoxPants = 1823;

	[Cpp2IlInjected.Token(Token = "0x400430B")]
	public const short CatEars = 1824;

	[Cpp2IlInjected.Token(Token = "0x400430C")]
	public const short BloodyMachete = 1825;

	[Cpp2IlInjected.Token(Token = "0x400430D")]
	public const short TheHorsemansBlade = 1826;

	[Cpp2IlInjected.Token(Token = "0x400430E")]
	public const short BladedGlove = 1827;

	[Cpp2IlInjected.Token(Token = "0x400430F")]
	public const short PumpkinSeed = 1828;

	[Cpp2IlInjected.Token(Token = "0x4004310")]
	public const short SpookyHook = 1829;

	[Cpp2IlInjected.Token(Token = "0x4004311")]
	public const short SpookyWings = 1830;

	[Cpp2IlInjected.Token(Token = "0x4004312")]
	public const short SpookyTwig = 1831;

	[Cpp2IlInjected.Token(Token = "0x4004313")]
	public const short SpookyHelmet = 1832;

	[Cpp2IlInjected.Token(Token = "0x4004314")]
	public const short SpookyBreastplate = 1833;

	[Cpp2IlInjected.Token(Token = "0x4004315")]
	public const short SpookyLeggings = 1834;

	[Cpp2IlInjected.Token(Token = "0x4004316")]
	public const short StakeLauncher = 1835;

	[Cpp2IlInjected.Token(Token = "0x4004317")]
	public const short Stake = 1836;

	[Cpp2IlInjected.Token(Token = "0x4004318")]
	public const short CursedSapling = 1837;

	[Cpp2IlInjected.Token(Token = "0x4004319")]
	public const short SpaceCreatureMask = 1838;

	[Cpp2IlInjected.Token(Token = "0x400431A")]
	public const short SpaceCreatureShirt = 1839;

	[Cpp2IlInjected.Token(Token = "0x400431B")]
	public const short SpaceCreaturePants = 1840;

	[Cpp2IlInjected.Token(Token = "0x400431C")]
	public const short WolfMask = 1841;

	[Cpp2IlInjected.Token(Token = "0x400431D")]
	public const short WolfShirt = 1842;

	[Cpp2IlInjected.Token(Token = "0x400431E")]
	public const short WolfPants = 1843;

	[Cpp2IlInjected.Token(Token = "0x400431F")]
	public const short PumpkinMoonMedallion = 1844;

	[Cpp2IlInjected.Token(Token = "0x4004320")]
	public const short NecromanticScroll = 1845;

	[Cpp2IlInjected.Token(Token = "0x4004321")]
	public const short JackingSkeletron = 1846;

	[Cpp2IlInjected.Token(Token = "0x4004322")]
	public const short BitterHarvest = 1847;

	[Cpp2IlInjected.Token(Token = "0x4004323")]
	public const short BloodMoonCountess = 1848;

	[Cpp2IlInjected.Token(Token = "0x4004324")]
	public const short HallowsEve = 1849;

	[Cpp2IlInjected.Token(Token = "0x4004325")]
	public const short MorbidCuriosity = 1850;

	[Cpp2IlInjected.Token(Token = "0x4004326")]
	public const short TreasureHunterShirt = 1851;

	[Cpp2IlInjected.Token(Token = "0x4004327")]
	public const short TreasureHunterPants = 1852;

	[Cpp2IlInjected.Token(Token = "0x4004328")]
	public const short DryadCoverings = 1853;

	[Cpp2IlInjected.Token(Token = "0x4004329")]
	public const short DryadLoincloth = 1854;

	[Cpp2IlInjected.Token(Token = "0x400432A")]
	public const short MourningWoodTrophy = 1855;

	[Cpp2IlInjected.Token(Token = "0x400432B")]
	public const short PumpkingTrophy = 1856;

	[Cpp2IlInjected.Token(Token = "0x400432C")]
	public const short JackOLanternMask = 1857;

	[Cpp2IlInjected.Token(Token = "0x400432D")]
	public const short SniperScope = 1858;

	[Cpp2IlInjected.Token(Token = "0x400432E")]
	public const short HeartLantern = 1859;

	[Cpp2IlInjected.Token(Token = "0x400432F")]
	public const short JellyfishDivingGear = 1860;

	[Cpp2IlInjected.Token(Token = "0x4004330")]
	public const short ArcticDivingGear = 1861;

	[Cpp2IlInjected.Token(Token = "0x4004331")]
	public const short FrostsparkBoots = 1862;

	[Cpp2IlInjected.Token(Token = "0x4004332")]
	public const short FartInABalloon = 1863;

	[Cpp2IlInjected.Token(Token = "0x4004333")]
	public const short PapyrusScarab = 1864;

	[Cpp2IlInjected.Token(Token = "0x4004334")]
	public const short CelestialStone = 1865;

	[Cpp2IlInjected.Token(Token = "0x4004335")]
	public const short Hoverboard = 1866;

	[Cpp2IlInjected.Token(Token = "0x4004336")]
	public const short CandyCane = 1867;

	[Cpp2IlInjected.Token(Token = "0x4004337")]
	public const short SugarPlum = 1868;

	[Cpp2IlInjected.Token(Token = "0x4004338")]
	public const short Present = 1869;

	[Cpp2IlInjected.Token(Token = "0x4004339")]
	public const short RedRyder = 1870;

	[Cpp2IlInjected.Token(Token = "0x400433A")]
	public const short FestiveWings = 1871;

	[Cpp2IlInjected.Token(Token = "0x400433B")]
	public const short PineTreeBlock = 1872;

	[Cpp2IlInjected.Token(Token = "0x400433C")]
	public const short ChristmasTree = 1873;

	[Cpp2IlInjected.Token(Token = "0x400433D")]
	public const short StarTopper1 = 1874;

	[Cpp2IlInjected.Token(Token = "0x400433E")]
	public const short StarTopper2 = 1875;

	[Cpp2IlInjected.Token(Token = "0x400433F")]
	public const short StarTopper3 = 1876;

	[Cpp2IlInjected.Token(Token = "0x4004340")]
	public const short BowTopper = 1877;

	[Cpp2IlInjected.Token(Token = "0x4004341")]
	public const short WhiteGarland = 1878;

	[Cpp2IlInjected.Token(Token = "0x4004342")]
	public const short WhiteAndRedGarland = 1879;

	[Cpp2IlInjected.Token(Token = "0x4004343")]
	public const short RedGardland = 1880;

	[Cpp2IlInjected.Token(Token = "0x4004344")]
	public const short RedAndGreenGardland = 1881;

	[Cpp2IlInjected.Token(Token = "0x4004345")]
	public const short GreenGardland = 1882;

	[Cpp2IlInjected.Token(Token = "0x4004346")]
	public const short GreenAndWhiteGarland = 1883;

	[Cpp2IlInjected.Token(Token = "0x4004347")]
	public const short MulticoloredBulb = 1884;

	[Cpp2IlInjected.Token(Token = "0x4004348")]
	public const short RedBulb = 1885;

	[Cpp2IlInjected.Token(Token = "0x4004349")]
	public const short YellowBulb = 1886;

	[Cpp2IlInjected.Token(Token = "0x400434A")]
	public const short GreenBulb = 1887;

	[Cpp2IlInjected.Token(Token = "0x400434B")]
	public const short RedAndGreenBulb = 1888;

	[Cpp2IlInjected.Token(Token = "0x400434C")]
	public const short YellowAndGreenBulb = 1889;

	[Cpp2IlInjected.Token(Token = "0x400434D")]
	public const short RedAndYellowBulb = 1890;

	[Cpp2IlInjected.Token(Token = "0x400434E")]
	public const short WhiteBulb = 1891;

	[Cpp2IlInjected.Token(Token = "0x400434F")]
	public const short WhiteAndRedBulb = 1892;

	[Cpp2IlInjected.Token(Token = "0x4004350")]
	public const short WhiteAndYellowBulb = 1893;

	[Cpp2IlInjected.Token(Token = "0x4004351")]
	public const short WhiteAndGreenBulb = 1894;

	[Cpp2IlInjected.Token(Token = "0x4004352")]
	public const short MulticoloredLights = 1895;

	[Cpp2IlInjected.Token(Token = "0x4004353")]
	public const short RedLights = 1896;

	[Cpp2IlInjected.Token(Token = "0x4004354")]
	public const short GreenLights = 1897;

	[Cpp2IlInjected.Token(Token = "0x4004355")]
	public const short BlueLights = 1898;

	[Cpp2IlInjected.Token(Token = "0x4004356")]
	public const short YellowLights = 1899;

	[Cpp2IlInjected.Token(Token = "0x4004357")]
	public const short RedAndYellowLights = 1900;

	[Cpp2IlInjected.Token(Token = "0x4004358")]
	public const short RedAndGreenLights = 1901;

	[Cpp2IlInjected.Token(Token = "0x4004359")]
	public const short YellowAndGreenLights = 1902;

	[Cpp2IlInjected.Token(Token = "0x400435A")]
	public const short BlueAndGreenLights = 1903;

	[Cpp2IlInjected.Token(Token = "0x400435B")]
	public const short RedAndBlueLights = 1904;

	[Cpp2IlInjected.Token(Token = "0x400435C")]
	public const short BlueAndYellowLights = 1905;

	[Cpp2IlInjected.Token(Token = "0x400435D")]
	public const short GiantBow = 1906;

	[Cpp2IlInjected.Token(Token = "0x400435E")]
	public const short ReindeerAntlers = 1907;

	[Cpp2IlInjected.Token(Token = "0x400435F")]
	public const short Holly = 1908;

	[Cpp2IlInjected.Token(Token = "0x4004360")]
	public const short CandyCaneSword = 1909;

	[Cpp2IlInjected.Token(Token = "0x4004361")]
	public const short ElfMelter = 1910;

	[Cpp2IlInjected.Token(Token = "0x4004362")]
	public const short ChristmasPudding = 1911;

	[Cpp2IlInjected.Token(Token = "0x4004363")]
	public const short Eggnog = 1912;

	[Cpp2IlInjected.Token(Token = "0x4004364")]
	public const short StarAnise = 1913;

	[Cpp2IlInjected.Token(Token = "0x4004365")]
	public const short ReindeerBells = 1914;

	[Cpp2IlInjected.Token(Token = "0x4004366")]
	public const short CandyCaneHook = 1915;

	[Cpp2IlInjected.Token(Token = "0x4004367")]
	public const short ChristmasHook = 1916;

	[Cpp2IlInjected.Token(Token = "0x4004368")]
	public const short CnadyCanePickaxe = 1917;

	[Cpp2IlInjected.Token(Token = "0x4004369")]
	public const short FruitcakeChakram = 1918;

	[Cpp2IlInjected.Token(Token = "0x400436A")]
	public const short SugarCookie = 1919;

	[Cpp2IlInjected.Token(Token = "0x400436B")]
	public const short GingerbreadCookie = 1920;

	[Cpp2IlInjected.Token(Token = "0x400436C")]
	public const short HandWarmer = 1921;

	[Cpp2IlInjected.Token(Token = "0x400436D")]
	public const short Coal = 1922;

	[Cpp2IlInjected.Token(Token = "0x400436E")]
	public const short Toolbox = 1923;

	[Cpp2IlInjected.Token(Token = "0x400436F")]
	public const short PineDoor = 1924;

	[Cpp2IlInjected.Token(Token = "0x4004370")]
	public const short PineChair = 1925;

	[Cpp2IlInjected.Token(Token = "0x4004371")]
	public const short PineTable = 1926;

	[Cpp2IlInjected.Token(Token = "0x4004372")]
	public const short DogWhistle = 1927;

	[Cpp2IlInjected.Token(Token = "0x4004373")]
	public const short ChristmasTreeSword = 1928;

	[Cpp2IlInjected.Token(Token = "0x4004374")]
	public const short ChainGun = 1929;

	[Cpp2IlInjected.Token(Token = "0x4004375")]
	public const short Razorpine = 1930;

	[Cpp2IlInjected.Token(Token = "0x4004376")]
	public const short BlizzardStaff = 1931;

	[Cpp2IlInjected.Token(Token = "0x4004377")]
	public const short MrsClauseHat = 1932;

	[Cpp2IlInjected.Token(Token = "0x4004378")]
	public const short MrsClauseShirt = 1933;

	[Cpp2IlInjected.Token(Token = "0x4004379")]
	public const short MrsClauseHeels = 1934;

	[Cpp2IlInjected.Token(Token = "0x400437A")]
	public const short ParkaHood = 1935;

	[Cpp2IlInjected.Token(Token = "0x400437B")]
	public const short ParkaCoat = 1936;

	[Cpp2IlInjected.Token(Token = "0x400437C")]
	public const short ParkaPants = 1937;

	[Cpp2IlInjected.Token(Token = "0x400437D")]
	public const short SnowHat = 1938;

	[Cpp2IlInjected.Token(Token = "0x400437E")]
	public const short UglySweater = 1939;

	[Cpp2IlInjected.Token(Token = "0x400437F")]
	public const short TreeMask = 1940;

	[Cpp2IlInjected.Token(Token = "0x4004380")]
	public const short TreeShirt = 1941;

	[Cpp2IlInjected.Token(Token = "0x4004381")]
	public const short TreeTrunks = 1942;

	[Cpp2IlInjected.Token(Token = "0x4004382")]
	public const short ElfHat = 1943;

	[Cpp2IlInjected.Token(Token = "0x4004383")]
	public const short ElfShirt = 1944;

	[Cpp2IlInjected.Token(Token = "0x4004384")]
	public const short ElfPants = 1945;

	[Cpp2IlInjected.Token(Token = "0x4004385")]
	public const short SnowmanCannon = 1946;

	[Cpp2IlInjected.Token(Token = "0x4004386")]
	public const short NorthPole = 1947;

	[Cpp2IlInjected.Token(Token = "0x4004387")]
	public const short ChristmasTreeWallpaper = 1948;

	[Cpp2IlInjected.Token(Token = "0x4004388")]
	public const short OrnamentWallpaper = 1949;

	[Cpp2IlInjected.Token(Token = "0x4004389")]
	public const short CandyCaneWallpaper = 1950;

	[Cpp2IlInjected.Token(Token = "0x400438A")]
	public const short FestiveWallpaper = 1951;

	[Cpp2IlInjected.Token(Token = "0x400438B")]
	public const short StarsWallpaper = 1952;

	[Cpp2IlInjected.Token(Token = "0x400438C")]
	public const short SquigglesWallpaper = 1953;

	[Cpp2IlInjected.Token(Token = "0x400438D")]
	public const short SnowflakeWallpaper = 1954;

	[Cpp2IlInjected.Token(Token = "0x400438E")]
	public const short KrampusHornWallpaper = 1955;

	[Cpp2IlInjected.Token(Token = "0x400438F")]
	public const short BluegreenWallpaper = 1956;

	[Cpp2IlInjected.Token(Token = "0x4004390")]
	public const short GrinchFingerWallpaper = 1957;

	[Cpp2IlInjected.Token(Token = "0x4004391")]
	public const short NaughtyPresent = 1958;

	[Cpp2IlInjected.Token(Token = "0x4004392")]
	public const short BabyGrinchMischiefWhistle = 1959;

	[Cpp2IlInjected.Token(Token = "0x4004393")]
	public const short IceQueenTrophy = 1960;

	[Cpp2IlInjected.Token(Token = "0x4004394")]
	public const short SantaNK1Trophy = 1961;

	[Cpp2IlInjected.Token(Token = "0x4004395")]
	public const short EverscreamTrophy = 1962;

	[Cpp2IlInjected.Token(Token = "0x4004396")]
	public const short MusicBoxPumpkinMoon = 1963;

	[Cpp2IlInjected.Token(Token = "0x4004397")]
	public const short MusicBoxAltUnderground = 1964;

	[Cpp2IlInjected.Token(Token = "0x4004398")]
	public const short MusicBoxFrostMoon = 1965;

	[Cpp2IlInjected.Token(Token = "0x4004399")]
	public const short BrownPaint = 1966;

	[Cpp2IlInjected.Token(Token = "0x400439A")]
	public const short ShadowPaint = 1967;

	[Cpp2IlInjected.Token(Token = "0x400439B")]
	public const short NegativePaint = 1968;

	[Cpp2IlInjected.Token(Token = "0x400439C")]
	public const short TeamDye = 1969;

	[Cpp2IlInjected.Token(Token = "0x400439D")]
	public const short AmethystGemsparkBlock = 1970;

	[Cpp2IlInjected.Token(Token = "0x400439E")]
	public const short TopazGemsparkBlock = 1971;

	[Cpp2IlInjected.Token(Token = "0x400439F")]
	public const short SapphireGemsparkBlock = 1972;

	[Cpp2IlInjected.Token(Token = "0x40043A0")]
	public const short EmeraldGemsparkBlock = 1973;

	[Cpp2IlInjected.Token(Token = "0x40043A1")]
	public const short RubyGemsparkBlock = 1974;

	[Cpp2IlInjected.Token(Token = "0x40043A2")]
	public const short DiamondGemsparkBlock = 1975;

	[Cpp2IlInjected.Token(Token = "0x40043A3")]
	public const short AmberGemsparkBlock = 1976;

	[Cpp2IlInjected.Token(Token = "0x40043A4")]
	public const short LifeHairDye = 1977;

	[Cpp2IlInjected.Token(Token = "0x40043A5")]
	public const short ManaHairDye = 1978;

	[Cpp2IlInjected.Token(Token = "0x40043A6")]
	public const short DepthHairDye = 1979;

	[Cpp2IlInjected.Token(Token = "0x40043A7")]
	public const short MoneyHairDye = 1980;

	[Cpp2IlInjected.Token(Token = "0x40043A8")]
	public const short TimeHairDye = 1981;

	[Cpp2IlInjected.Token(Token = "0x40043A9")]
	public const short TeamHairDye = 1982;

	[Cpp2IlInjected.Token(Token = "0x40043AA")]
	public const short BiomeHairDye = 1983;

	[Cpp2IlInjected.Token(Token = "0x40043AB")]
	public const short PartyHairDye = 1984;

	[Cpp2IlInjected.Token(Token = "0x40043AC")]
	public const short RainbowHairDye = 1985;

	[Cpp2IlInjected.Token(Token = "0x40043AD")]
	public const short SpeedHairDye = 1986;

	[Cpp2IlInjected.Token(Token = "0x40043AE")]
	public const short AngelHalo = 1987;

	[Cpp2IlInjected.Token(Token = "0x40043AF")]
	public const short Fez = 1988;

	[Cpp2IlInjected.Token(Token = "0x40043B0")]
	public const short Womannquin = 1989;

	[Cpp2IlInjected.Token(Token = "0x40043B1")]
	public const short HairDyeRemover = 1990;

	[Cpp2IlInjected.Token(Token = "0x40043B2")]
	public const short BugNet = 1991;

	[Cpp2IlInjected.Token(Token = "0x40043B3")]
	public const short Firefly = 1992;

	[Cpp2IlInjected.Token(Token = "0x40043B4")]
	public const short FireflyinaBottle = 1993;

	[Cpp2IlInjected.Token(Token = "0x40043B5")]
	public const short MonarchButterfly = 1994;

	[Cpp2IlInjected.Token(Token = "0x40043B6")]
	public const short PurpleEmperorButterfly = 1995;

	[Cpp2IlInjected.Token(Token = "0x40043B7")]
	public const short RedAdmiralButterfly = 1996;

	[Cpp2IlInjected.Token(Token = "0x40043B8")]
	public const short UlyssesButterfly = 1997;

	[Cpp2IlInjected.Token(Token = "0x40043B9")]
	public const short SulphurButterfly = 1998;

	[Cpp2IlInjected.Token(Token = "0x40043BA")]
	public const short TreeNymphButterfly = 1999;

	[Cpp2IlInjected.Token(Token = "0x40043BB")]
	public const short ZebraSwallowtailButterfly = 2000;

	[Cpp2IlInjected.Token(Token = "0x40043BC")]
	public const short JuliaButterfly = 2001;

	[Cpp2IlInjected.Token(Token = "0x40043BD")]
	public const short Worm = 2002;

	[Cpp2IlInjected.Token(Token = "0x40043BE")]
	public const short Mouse = 2003;

	[Cpp2IlInjected.Token(Token = "0x40043BF")]
	public const short LightningBug = 2004;

	[Cpp2IlInjected.Token(Token = "0x40043C0")]
	public const short LightningBuginaBottle = 2005;

	[Cpp2IlInjected.Token(Token = "0x40043C1")]
	public const short Snail = 2006;

	[Cpp2IlInjected.Token(Token = "0x40043C2")]
	public const short GlowingSnail = 2007;

	[Cpp2IlInjected.Token(Token = "0x40043C3")]
	public const short FancyGreyWallpaper = 2008;

	[Cpp2IlInjected.Token(Token = "0x40043C4")]
	public const short IceFloeWallpaper = 2009;

	[Cpp2IlInjected.Token(Token = "0x40043C5")]
	public const short MusicWallpaper = 2010;

	[Cpp2IlInjected.Token(Token = "0x40043C6")]
	public const short PurpleRainWallpaper = 2011;

	[Cpp2IlInjected.Token(Token = "0x40043C7")]
	public const short RainbowWallpaper = 2012;

	[Cpp2IlInjected.Token(Token = "0x40043C8")]
	public const short SparkleStoneWallpaper = 2013;

	[Cpp2IlInjected.Token(Token = "0x40043C9")]
	public const short StarlitHeavenWallpaper = 2014;

	[Cpp2IlInjected.Token(Token = "0x40043CA")]
	public const short Bird = 2015;

	[Cpp2IlInjected.Token(Token = "0x40043CB")]
	public const short BlueJay = 2016;

	[Cpp2IlInjected.Token(Token = "0x40043CC")]
	public const short Cardinal = 2017;

	[Cpp2IlInjected.Token(Token = "0x40043CD")]
	public const short Squirrel = 2018;

	[Cpp2IlInjected.Token(Token = "0x40043CE")]
	public const short Bunny = 2019;

	[Cpp2IlInjected.Token(Token = "0x40043CF")]
	public const short CactusBookcase = 2020;

	[Cpp2IlInjected.Token(Token = "0x40043D0")]
	public const short EbonwoodBookcase = 2021;

	[Cpp2IlInjected.Token(Token = "0x40043D1")]
	public const short FleshBookcase = 2022;

	[Cpp2IlInjected.Token(Token = "0x40043D2")]
	public const short HoneyBookcase = 2023;

	[Cpp2IlInjected.Token(Token = "0x40043D3")]
	public const short SteampunkBookcase = 2024;

	[Cpp2IlInjected.Token(Token = "0x40043D4")]
	public const short GlassBookcase = 2025;

	[Cpp2IlInjected.Token(Token = "0x40043D5")]
	public const short RichMahoganyBookcase = 2026;

	[Cpp2IlInjected.Token(Token = "0x40043D6")]
	public const short PearlwoodBookcase = 2027;

	[Cpp2IlInjected.Token(Token = "0x40043D7")]
	public const short SpookyBookcase = 2028;

	[Cpp2IlInjected.Token(Token = "0x40043D8")]
	public const short SkywareBookcase = 2029;

	[Cpp2IlInjected.Token(Token = "0x40043D9")]
	public const short LihzahrdBookcase = 2030;

	[Cpp2IlInjected.Token(Token = "0x40043DA")]
	public const short FrozenBookcase = 2031;

	[Cpp2IlInjected.Token(Token = "0x40043DB")]
	public const short CactusLantern = 2032;

	[Cpp2IlInjected.Token(Token = "0x40043DC")]
	public const short EbonwoodLantern = 2033;

	[Cpp2IlInjected.Token(Token = "0x40043DD")]
	public const short FleshLantern = 2034;

	[Cpp2IlInjected.Token(Token = "0x40043DE")]
	public const short HoneyLantern = 2035;

	[Cpp2IlInjected.Token(Token = "0x40043DF")]
	public const short SteampunkLantern = 2036;

	[Cpp2IlInjected.Token(Token = "0x40043E0")]
	public const short GlassLantern = 2037;

	[Cpp2IlInjected.Token(Token = "0x40043E1")]
	public const short RichMahoganyLantern = 2038;

	[Cpp2IlInjected.Token(Token = "0x40043E2")]
	public const short PearlwoodLantern = 2039;

	[Cpp2IlInjected.Token(Token = "0x40043E3")]
	public const short FrozenLantern = 2040;

	[Cpp2IlInjected.Token(Token = "0x40043E4")]
	public const short LihzahrdLantern = 2041;

	[Cpp2IlInjected.Token(Token = "0x40043E5")]
	public const short SkywareLantern = 2042;

	[Cpp2IlInjected.Token(Token = "0x40043E6")]
	public const short SpookyLantern = 2043;

	[Cpp2IlInjected.Token(Token = "0x40043E7")]
	public const short FrozenDoor = 2044;

	[Cpp2IlInjected.Token(Token = "0x40043E8")]
	public const short CactusCandle = 2045;

	[Cpp2IlInjected.Token(Token = "0x40043E9")]
	public const short EbonwoodCandle = 2046;

	[Cpp2IlInjected.Token(Token = "0x40043EA")]
	public const short FleshCandle = 2047;

	[Cpp2IlInjected.Token(Token = "0x40043EB")]
	public const short GlassCandle = 2048;

	[Cpp2IlInjected.Token(Token = "0x40043EC")]
	public const short FrozenCandle = 2049;

	[Cpp2IlInjected.Token(Token = "0x40043ED")]
	public const short RichMahoganyCandle = 2050;

	[Cpp2IlInjected.Token(Token = "0x40043EE")]
	public const short PearlwoodCandle = 2051;

	[Cpp2IlInjected.Token(Token = "0x40043EF")]
	public const short LihzahrdCandle = 2052;

	[Cpp2IlInjected.Token(Token = "0x40043F0")]
	public const short SkywareCandle = 2053;

	[Cpp2IlInjected.Token(Token = "0x40043F1")]
	public const short PumpkinCandle = 2054;

	[Cpp2IlInjected.Token(Token = "0x40043F2")]
	public const short CactusChandelier = 2055;

	[Cpp2IlInjected.Token(Token = "0x40043F3")]
	public const short EbonwoodChandelier = 2056;

	[Cpp2IlInjected.Token(Token = "0x40043F4")]
	public const short FleshChandelier = 2057;

	[Cpp2IlInjected.Token(Token = "0x40043F5")]
	public const short HoneyChandelier = 2058;

	[Cpp2IlInjected.Token(Token = "0x40043F6")]
	public const short FrozenChandelier = 2059;

	[Cpp2IlInjected.Token(Token = "0x40043F7")]
	public const short RichMahoganyChandelier = 2060;

	[Cpp2IlInjected.Token(Token = "0x40043F8")]
	public const short PearlwoodChandelier = 2061;

	[Cpp2IlInjected.Token(Token = "0x40043F9")]
	public const short LihzahrdChandelier = 2062;

	[Cpp2IlInjected.Token(Token = "0x40043FA")]
	public const short SkywareChandelier = 2063;

	[Cpp2IlInjected.Token(Token = "0x40043FB")]
	public const short SpookyChandelier = 2064;

	[Cpp2IlInjected.Token(Token = "0x40043FC")]
	public const short GlassChandelier = 2065;

	[Cpp2IlInjected.Token(Token = "0x40043FD")]
	public const short CactusBed = 2066;

	[Cpp2IlInjected.Token(Token = "0x40043FE")]
	public const short FleshBed = 2067;

	[Cpp2IlInjected.Token(Token = "0x40043FF")]
	public const short FrozenBed = 2068;

	[Cpp2IlInjected.Token(Token = "0x4004400")]
	public const short LihzahrdBed = 2069;

	[Cpp2IlInjected.Token(Token = "0x4004401")]
	public const short SkywareBed = 2070;

	[Cpp2IlInjected.Token(Token = "0x4004402")]
	public const short SpookyBed = 2071;

	[Cpp2IlInjected.Token(Token = "0x4004403")]
	public const short CactusBathtub = 2072;

	[Cpp2IlInjected.Token(Token = "0x4004404")]
	public const short EbonwoodBathtub = 2073;

	[Cpp2IlInjected.Token(Token = "0x4004405")]
	public const short FleshBathtub = 2074;

	[Cpp2IlInjected.Token(Token = "0x4004406")]
	public const short GlassBathtub = 2075;

	[Cpp2IlInjected.Token(Token = "0x4004407")]
	public const short FrozenBathtub = 2076;

	[Cpp2IlInjected.Token(Token = "0x4004408")]
	public const short RichMahoganyBathtub = 2077;

	[Cpp2IlInjected.Token(Token = "0x4004409")]
	public const short PearlwoodBathtub = 2078;

	[Cpp2IlInjected.Token(Token = "0x400440A")]
	public const short LihzahrdBathtub = 2079;

	[Cpp2IlInjected.Token(Token = "0x400440B")]
	public const short SkywareBathtub = 2080;

	[Cpp2IlInjected.Token(Token = "0x400440C")]
	public const short SpookyBathtub = 2081;

	[Cpp2IlInjected.Token(Token = "0x400440D")]
	public const short CactusLamp = 2082;

	[Cpp2IlInjected.Token(Token = "0x400440E")]
	public const short EbonwoodLamp = 2083;

	[Cpp2IlInjected.Token(Token = "0x400440F")]
	public const short FleshLamp = 2084;

	[Cpp2IlInjected.Token(Token = "0x4004410")]
	public const short GlassLamp = 2085;

	[Cpp2IlInjected.Token(Token = "0x4004411")]
	public const short FrozenLamp = 2086;

	[Cpp2IlInjected.Token(Token = "0x4004412")]
	public const short RichMahoganyLamp = 2087;

	[Cpp2IlInjected.Token(Token = "0x4004413")]
	public const short PearlwoodLamp = 2088;

	[Cpp2IlInjected.Token(Token = "0x4004414")]
	public const short LihzahrdLamp = 2089;

	[Cpp2IlInjected.Token(Token = "0x4004415")]
	public const short SkywareLamp = 2090;

	[Cpp2IlInjected.Token(Token = "0x4004416")]
	public const short SpookyLamp = 2091;

	[Cpp2IlInjected.Token(Token = "0x4004417")]
	public const short CactusCandelabra = 2092;

	[Cpp2IlInjected.Token(Token = "0x4004418")]
	public const short EbonwoodCandelabra = 2093;

	[Cpp2IlInjected.Token(Token = "0x4004419")]
	public const short FleshCandelabra = 2094;

	[Cpp2IlInjected.Token(Token = "0x400441A")]
	public const short HoneyCandelabra = 2095;

	[Cpp2IlInjected.Token(Token = "0x400441B")]
	public const short SteampunkCandelabra = 2096;

	[Cpp2IlInjected.Token(Token = "0x400441C")]
	public const short GlassCandelabra = 2097;

	[Cpp2IlInjected.Token(Token = "0x400441D")]
	public const short RichMahoganyCandelabra = 2098;

	[Cpp2IlInjected.Token(Token = "0x400441E")]
	public const short PearlwoodCandelabra = 2099;

	[Cpp2IlInjected.Token(Token = "0x400441F")]
	public const short FrozenCandelabra = 2100;

	[Cpp2IlInjected.Token(Token = "0x4004420")]
	public const short LihzahrdCandelabra = 2101;

	[Cpp2IlInjected.Token(Token = "0x4004421")]
	public const short SkywareCandelabra = 2102;

	[Cpp2IlInjected.Token(Token = "0x4004422")]
	public const short SpookyCandelabra = 2103;

	[Cpp2IlInjected.Token(Token = "0x4004423")]
	public const short BrainMask = 2104;

	[Cpp2IlInjected.Token(Token = "0x4004424")]
	public const short FleshMask = 2105;

	[Cpp2IlInjected.Token(Token = "0x4004425")]
	public const short TwinMask = 2106;

	[Cpp2IlInjected.Token(Token = "0x4004426")]
	public const short SkeletronPrimeMask = 2107;

	[Cpp2IlInjected.Token(Token = "0x4004427")]
	public const short BeeMask = 2108;

	[Cpp2IlInjected.Token(Token = "0x4004428")]
	public const short PlanteraMask = 2109;

	[Cpp2IlInjected.Token(Token = "0x4004429")]
	public const short GolemMask = 2110;

	[Cpp2IlInjected.Token(Token = "0x400442A")]
	public const short EaterMask = 2111;

	[Cpp2IlInjected.Token(Token = "0x400442B")]
	public const short EyeMask = 2112;

	[Cpp2IlInjected.Token(Token = "0x400442C")]
	public const short DestroyerMask = 2113;

	[Cpp2IlInjected.Token(Token = "0x400442D")]
	public const short BlacksmithRack = 2114;

	[Cpp2IlInjected.Token(Token = "0x400442E")]
	public const short CarpentryRack = 2115;

	[Cpp2IlInjected.Token(Token = "0x400442F")]
	public const short HelmetRack = 2116;

	[Cpp2IlInjected.Token(Token = "0x4004430")]
	public const short SpearRack = 2117;

	[Cpp2IlInjected.Token(Token = "0x4004431")]
	public const short SwordRack = 2118;

	[Cpp2IlInjected.Token(Token = "0x4004432")]
	public const short StoneSlab = 2119;

	[Cpp2IlInjected.Token(Token = "0x4004433")]
	public const short SandstoneSlab = 2120;

	[Cpp2IlInjected.Token(Token = "0x4004434")]
	public const short Frog = 2121;

	[Cpp2IlInjected.Token(Token = "0x4004435")]
	public const short MallardDuck = 2122;

	[Cpp2IlInjected.Token(Token = "0x4004436")]
	public const short Duck = 2123;

	[Cpp2IlInjected.Token(Token = "0x4004437")]
	public const short HoneyBathtub = 2124;

	[Cpp2IlInjected.Token(Token = "0x4004438")]
	public const short SteampunkBathtub = 2125;

	[Cpp2IlInjected.Token(Token = "0x4004439")]
	public const short LivingWoodBathtub = 2126;

	[Cpp2IlInjected.Token(Token = "0x400443A")]
	public const short ShadewoodBathtub = 2127;

	[Cpp2IlInjected.Token(Token = "0x400443B")]
	public const short BoneBathtub = 2128;

	[Cpp2IlInjected.Token(Token = "0x400443C")]
	public const short HoneyLamp = 2129;

	[Cpp2IlInjected.Token(Token = "0x400443D")]
	public const short SteampunkLamp = 2130;

	[Cpp2IlInjected.Token(Token = "0x400443E")]
	public const short LivingWoodLamp = 2131;

	[Cpp2IlInjected.Token(Token = "0x400443F")]
	public const short ShadewoodLamp = 2132;

	[Cpp2IlInjected.Token(Token = "0x4004440")]
	public const short GoldenLamp = 2133;

	[Cpp2IlInjected.Token(Token = "0x4004441")]
	public const short BoneLamp = 2134;

	[Cpp2IlInjected.Token(Token = "0x4004442")]
	public const short LivingWoodBookcase = 2135;

	[Cpp2IlInjected.Token(Token = "0x4004443")]
	public const short ShadewoodBookcase = 2136;

	[Cpp2IlInjected.Token(Token = "0x4004444")]
	public const short GoldenBookcase = 2137;

	[Cpp2IlInjected.Token(Token = "0x4004445")]
	public const short BoneBookcase = 2138;

	[Cpp2IlInjected.Token(Token = "0x4004446")]
	public const short LivingWoodBed = 2139;

	[Cpp2IlInjected.Token(Token = "0x4004447")]
	public const short BoneBed = 2140;

	[Cpp2IlInjected.Token(Token = "0x4004448")]
	public const short LivingWoodChandelier = 2141;

	[Cpp2IlInjected.Token(Token = "0x4004449")]
	public const short ShadewoodChandelier = 2142;

	[Cpp2IlInjected.Token(Token = "0x400444A")]
	public const short GoldenChandelier = 2143;

	[Cpp2IlInjected.Token(Token = "0x400444B")]
	public const short BoneChandelier = 2144;

	[Cpp2IlInjected.Token(Token = "0x400444C")]
	public const short LivingWoodLantern = 2145;

	[Cpp2IlInjected.Token(Token = "0x400444D")]
	public const short ShadewoodLantern = 2146;

	[Cpp2IlInjected.Token(Token = "0x400444E")]
	public const short GoldenLantern = 2147;

	[Cpp2IlInjected.Token(Token = "0x400444F")]
	public const short BoneLantern = 2148;

	[Cpp2IlInjected.Token(Token = "0x4004450")]
	public const short LivingWoodCandelabra = 2149;

	[Cpp2IlInjected.Token(Token = "0x4004451")]
	public const short ShadewoodCandelabra = 2150;

	[Cpp2IlInjected.Token(Token = "0x4004452")]
	public const short GoldenCandelabra = 2151;

	[Cpp2IlInjected.Token(Token = "0x4004453")]
	public const short BoneCandelabra = 2152;

	[Cpp2IlInjected.Token(Token = "0x4004454")]
	public const short LivingWoodCandle = 2153;

	[Cpp2IlInjected.Token(Token = "0x4004455")]
	public const short ShadewoodCandle = 2154;

	[Cpp2IlInjected.Token(Token = "0x4004456")]
	public const short GoldenCandle = 2155;

	[Cpp2IlInjected.Token(Token = "0x4004457")]
	public const short BlackScorpion = 2156;

	[Cpp2IlInjected.Token(Token = "0x4004458")]
	public const short Scorpion = 2157;

	[Cpp2IlInjected.Token(Token = "0x4004459")]
	public const short BubbleWallpaper = 2158;

	[Cpp2IlInjected.Token(Token = "0x400445A")]
	public const short CopperPipeWallpaper = 2159;

	[Cpp2IlInjected.Token(Token = "0x400445B")]
	public const short DuckyWallpaper = 2160;

	[Cpp2IlInjected.Token(Token = "0x400445C")]
	public const short FrostCore = 2161;

	[Cpp2IlInjected.Token(Token = "0x400445D")]
	public const short BunnyCage = 2162;

	[Cpp2IlInjected.Token(Token = "0x400445E")]
	public const short SquirrelCage = 2163;

	[Cpp2IlInjected.Token(Token = "0x400445F")]
	public const short MallardDuckCage = 2164;

	[Cpp2IlInjected.Token(Token = "0x4004460")]
	public const short DuckCage = 2165;

	[Cpp2IlInjected.Token(Token = "0x4004461")]
	public const short BirdCage = 2166;

	[Cpp2IlInjected.Token(Token = "0x4004462")]
	public const short BlueJayCage = 2167;

	[Cpp2IlInjected.Token(Token = "0x4004463")]
	public const short CardinalCage = 2168;

	[Cpp2IlInjected.Token(Token = "0x4004464")]
	public const short WaterfallWall = 2169;

	[Cpp2IlInjected.Token(Token = "0x4004465")]
	public const short LavafallWall = 2170;

	[Cpp2IlInjected.Token(Token = "0x4004466")]
	public const short CrimsonSeeds = 2171;

	[Cpp2IlInjected.Token(Token = "0x4004467")]
	public const short HeavyWorkBench = 2172;

	[Cpp2IlInjected.Token(Token = "0x4004468")]
	public const short CopperPlating = 2173;

	[Cpp2IlInjected.Token(Token = "0x4004469")]
	public const short SnailCage = 2174;

	[Cpp2IlInjected.Token(Token = "0x400446A")]
	public const short GlowingSnailCage = 2175;

	[Cpp2IlInjected.Token(Token = "0x400446B")]
	public const short ShroomiteDiggingClaw = 2176;

	[Cpp2IlInjected.Token(Token = "0x400446C")]
	public const short AmmoBox = 2177;

	[Cpp2IlInjected.Token(Token = "0x400446D")]
	public const short MonarchButterflyJar = 2178;

	[Cpp2IlInjected.Token(Token = "0x400446E")]
	public const short PurpleEmperorButterflyJar = 2179;

	[Cpp2IlInjected.Token(Token = "0x400446F")]
	public const short RedAdmiralButterflyJar = 2180;

	[Cpp2IlInjected.Token(Token = "0x4004470")]
	public const short UlyssesButterflyJar = 2181;

	[Cpp2IlInjected.Token(Token = "0x4004471")]
	public const short SulphurButterflyJar = 2182;

	[Cpp2IlInjected.Token(Token = "0x4004472")]
	public const short TreeNymphButterflyJar = 2183;

	[Cpp2IlInjected.Token(Token = "0x4004473")]
	public const short ZebraSwallowtailButterflyJar = 2184;

	[Cpp2IlInjected.Token(Token = "0x4004474")]
	public const short JuliaButterflyJar = 2185;

	[Cpp2IlInjected.Token(Token = "0x4004475")]
	public const short ScorpionCage = 2186;

	[Cpp2IlInjected.Token(Token = "0x4004476")]
	public const short BlackScorpionCage = 2187;

	[Cpp2IlInjected.Token(Token = "0x4004477")]
	public const short VenomStaff = 2188;

	[Cpp2IlInjected.Token(Token = "0x4004478")]
	public const short SpectreMask = 2189;

	[Cpp2IlInjected.Token(Token = "0x4004479")]
	public const short FrogCage = 2190;

	[Cpp2IlInjected.Token(Token = "0x400447A")]
	public const short MouseCage = 2191;

	[Cpp2IlInjected.Token(Token = "0x400447B")]
	public const short BoneWelder = 2192;

	[Cpp2IlInjected.Token(Token = "0x400447C")]
	public const short FleshCloningVaat = 2193;

	[Cpp2IlInjected.Token(Token = "0x400447D")]
	public const short GlassKiln = 2194;

	[Cpp2IlInjected.Token(Token = "0x400447E")]
	public const short LihzahrdFurnace = 2195;

	[Cpp2IlInjected.Token(Token = "0x400447F")]
	public const short LivingLoom = 2196;

	[Cpp2IlInjected.Token(Token = "0x4004480")]
	public const short SkyMill = 2197;

	[Cpp2IlInjected.Token(Token = "0x4004481")]
	public const short IceMachine = 2198;

	[Cpp2IlInjected.Token(Token = "0x4004482")]
	public const short BeetleHelmet = 2199;

	[Cpp2IlInjected.Token(Token = "0x4004483")]
	public const short BeetleScaleMail = 2200;

	[Cpp2IlInjected.Token(Token = "0x4004484")]
	public const short BeetleShell = 2201;

	[Cpp2IlInjected.Token(Token = "0x4004485")]
	public const short BeetleLeggings = 2202;

	[Cpp2IlInjected.Token(Token = "0x4004486")]
	public const short SteampunkBoiler = 2203;

	[Cpp2IlInjected.Token(Token = "0x4004487")]
	public const short HoneyDispenser = 2204;

	[Cpp2IlInjected.Token(Token = "0x4004488")]
	public const short Penguin = 2205;

	[Cpp2IlInjected.Token(Token = "0x4004489")]
	public const short PenguinCage = 2206;

	[Cpp2IlInjected.Token(Token = "0x400448A")]
	public const short WormCage = 2207;

	[Cpp2IlInjected.Token(Token = "0x400448B")]
	public const short Terrarium = 2208;

	[Cpp2IlInjected.Token(Token = "0x400448C")]
	public const short SuperManaPotion = 2209;

	[Cpp2IlInjected.Token(Token = "0x400448D")]
	public const short EbonwoodFence = 2210;

	[Cpp2IlInjected.Token(Token = "0x400448E")]
	public const short RichMahoganyFence = 2211;

	[Cpp2IlInjected.Token(Token = "0x400448F")]
	public const short PearlwoodFence = 2212;

	[Cpp2IlInjected.Token(Token = "0x4004490")]
	public const short ShadewoodFence = 2213;

	[Cpp2IlInjected.Token(Token = "0x4004491")]
	public const short BrickLayer = 2214;

	[Cpp2IlInjected.Token(Token = "0x4004492")]
	public const short ExtendoGrip = 2215;

	[Cpp2IlInjected.Token(Token = "0x4004493")]
	public const short PaintSprayer = 2216;

	[Cpp2IlInjected.Token(Token = "0x4004494")]
	public const short PortableCementMixer = 2217;

	[Cpp2IlInjected.Token(Token = "0x4004495")]
	public const short BeetleHusk = 2218;

	[Cpp2IlInjected.Token(Token = "0x4004496")]
	public const short CelestialMagnet = 2219;

	[Cpp2IlInjected.Token(Token = "0x4004497")]
	public const short CelestialEmblem = 2220;

	[Cpp2IlInjected.Token(Token = "0x4004498")]
	public const short CelestialCuffs = 2221;

	[Cpp2IlInjected.Token(Token = "0x4004499")]
	public const short PeddlersHat = 2222;

	[Cpp2IlInjected.Token(Token = "0x400449A")]
	public const short PulseBow = 2223;

	[Cpp2IlInjected.Token(Token = "0x400449B")]
	public const short DynastyChandelier = 2224;

	[Cpp2IlInjected.Token(Token = "0x400449C")]
	public const short DynastyLamp = 2225;

	[Cpp2IlInjected.Token(Token = "0x400449D")]
	public const short DynastyLantern = 2226;

	[Cpp2IlInjected.Token(Token = "0x400449E")]
	public const short DynastyCandelabra = 2227;

	[Cpp2IlInjected.Token(Token = "0x400449F")]
	public const short DynastyChair = 2228;

	[Cpp2IlInjected.Token(Token = "0x40044A0")]
	public const short DynastyWorkBench = 2229;

	[Cpp2IlInjected.Token(Token = "0x40044A1")]
	public const short DynastyChest = 2230;

	[Cpp2IlInjected.Token(Token = "0x40044A2")]
	public const short DynastyBed = 2231;

	[Cpp2IlInjected.Token(Token = "0x40044A3")]
	public const short DynastyBathtub = 2232;

	[Cpp2IlInjected.Token(Token = "0x40044A4")]
	public const short DynastyBookcase = 2233;

	[Cpp2IlInjected.Token(Token = "0x40044A5")]
	public const short DynastyCup = 2234;

	[Cpp2IlInjected.Token(Token = "0x40044A6")]
	public const short DynastyBowl = 2235;

	[Cpp2IlInjected.Token(Token = "0x40044A7")]
	public const short DynastyCandle = 2236;

	[Cpp2IlInjected.Token(Token = "0x40044A8")]
	public const short DynastyClock = 2237;

	[Cpp2IlInjected.Token(Token = "0x40044A9")]
	public const short GoldenClock = 2238;

	[Cpp2IlInjected.Token(Token = "0x40044AA")]
	public const short GlassClock = 2239;

	[Cpp2IlInjected.Token(Token = "0x40044AB")]
	public const short HoneyClock = 2240;

	[Cpp2IlInjected.Token(Token = "0x40044AC")]
	public const short SteampunkClock = 2241;

	[Cpp2IlInjected.Token(Token = "0x40044AD")]
	public const short FancyDishes = 2242;

	[Cpp2IlInjected.Token(Token = "0x40044AE")]
	public const short GlassBowl = 2243;

	[Cpp2IlInjected.Token(Token = "0x40044AF")]
	public const short WineGlass = 2244;

	[Cpp2IlInjected.Token(Token = "0x40044B0")]
	public const short LivingWoodPiano = 2245;

	[Cpp2IlInjected.Token(Token = "0x40044B1")]
	public const short FleshPiano = 2246;

	[Cpp2IlInjected.Token(Token = "0x40044B2")]
	public const short FrozenPiano = 2247;

	[Cpp2IlInjected.Token(Token = "0x40044B3")]
	public const short FrozenTable = 2248;

	[Cpp2IlInjected.Token(Token = "0x40044B4")]
	public const short HoneyChest = 2249;

	[Cpp2IlInjected.Token(Token = "0x40044B5")]
	public const short SteampunkChest = 2250;

	[Cpp2IlInjected.Token(Token = "0x40044B6")]
	public const short HoneyWorkBench = 2251;

	[Cpp2IlInjected.Token(Token = "0x40044B7")]
	public const short FrozenWorkBench = 2252;

	[Cpp2IlInjected.Token(Token = "0x40044B8")]
	public const short SteampunkWorkBench = 2253;

	[Cpp2IlInjected.Token(Token = "0x40044B9")]
	public const short GlassPiano = 2254;

	[Cpp2IlInjected.Token(Token = "0x40044BA")]
	public const short HoneyPiano = 2255;

	[Cpp2IlInjected.Token(Token = "0x40044BB")]
	public const short SteampunkPiano = 2256;

	[Cpp2IlInjected.Token(Token = "0x40044BC")]
	public const short HoneyCup = 2257;

	[Cpp2IlInjected.Token(Token = "0x40044BD")]
	public const short SteampunkCup = 2258;

	[Cpp2IlInjected.Token(Token = "0x40044BE")]
	public const short DynastyTable = 2259;

	[Cpp2IlInjected.Token(Token = "0x40044BF")]
	public const short DynastyWood = 2260;

	[Cpp2IlInjected.Token(Token = "0x40044C0")]
	public const short RedDynastyShingles = 2261;

	[Cpp2IlInjected.Token(Token = "0x40044C1")]
	public const short BlueDynastyShingles = 2262;

	[Cpp2IlInjected.Token(Token = "0x40044C2")]
	public const short WhiteDynastyWall = 2263;

	[Cpp2IlInjected.Token(Token = "0x40044C3")]
	public const short BlueDynastyWall = 2264;

	[Cpp2IlInjected.Token(Token = "0x40044C4")]
	public const short DynastyDoor = 2265;

	[Cpp2IlInjected.Token(Token = "0x40044C5")]
	public const short Sake = 2266;

	[Cpp2IlInjected.Token(Token = "0x40044C6")]
	public const short PadThai = 2267;

	[Cpp2IlInjected.Token(Token = "0x40044C7")]
	public const short Pho = 2268;

	[Cpp2IlInjected.Token(Token = "0x40044C8")]
	public const short Revolver = 2269;

	[Cpp2IlInjected.Token(Token = "0x40044C9")]
	public const short Gatligator = 2270;

	[Cpp2IlInjected.Token(Token = "0x40044CA")]
	public const short ArcaneRuneWall = 2271;

	[Cpp2IlInjected.Token(Token = "0x40044CB")]
	public const short WaterGun = 2272;

	[Cpp2IlInjected.Token(Token = "0x40044CC")]
	public const short Katana = 2273;

	[Cpp2IlInjected.Token(Token = "0x40044CD")]
	public const short UltrabrightTorch = 2274;

	[Cpp2IlInjected.Token(Token = "0x40044CE")]
	public const short MagicHat = 2275;

	[Cpp2IlInjected.Token(Token = "0x40044CF")]
	public const short DiamondRing = 2276;

	[Cpp2IlInjected.Token(Token = "0x40044D0")]
	public const short Gi = 2277;

	[Cpp2IlInjected.Token(Token = "0x40044D1")]
	public const short Kimono = 2278;

	[Cpp2IlInjected.Token(Token = "0x40044D2")]
	public const short GypsyRobe = 2279;

	[Cpp2IlInjected.Token(Token = "0x40044D3")]
	public const short BeetleWings = 2280;

	[Cpp2IlInjected.Token(Token = "0x40044D4")]
	public const short TigerSkin = 2281;

	[Cpp2IlInjected.Token(Token = "0x40044D5")]
	public const short LeopardSkin = 2282;

	[Cpp2IlInjected.Token(Token = "0x40044D6")]
	public const short ZebraSkin = 2283;

	[Cpp2IlInjected.Token(Token = "0x40044D7")]
	public const short CrimsonCloak = 2284;

	[Cpp2IlInjected.Token(Token = "0x40044D8")]
	public const short MysteriousCape = 2285;

	[Cpp2IlInjected.Token(Token = "0x40044D9")]
	public const short RedCape = 2286;

	[Cpp2IlInjected.Token(Token = "0x40044DA")]
	public const short WinterCape = 2287;

	[Cpp2IlInjected.Token(Token = "0x40044DB")]
	public const short FrozenChair = 2288;

	[Cpp2IlInjected.Token(Token = "0x40044DC")]
	public const short WoodFishingPole = 2289;

	[Cpp2IlInjected.Token(Token = "0x40044DD")]
	public const short Bass = 2290;

	[Cpp2IlInjected.Token(Token = "0x40044DE")]
	public const short ReinforcedFishingPole = 2291;

	[Cpp2IlInjected.Token(Token = "0x40044DF")]
	public const short FiberglassFishingPole = 2292;

	[Cpp2IlInjected.Token(Token = "0x40044E0")]
	public const short FisherofSouls = 2293;

	[Cpp2IlInjected.Token(Token = "0x40044E1")]
	public const short GoldenFishingRod = 2294;

	[Cpp2IlInjected.Token(Token = "0x40044E2")]
	public const short MechanicsRod = 2295;

	[Cpp2IlInjected.Token(Token = "0x40044E3")]
	public const short SittingDucksFishingRod = 2296;

	[Cpp2IlInjected.Token(Token = "0x40044E4")]
	public const short Trout = 2297;

	[Cpp2IlInjected.Token(Token = "0x40044E5")]
	public const short Salmon = 2298;

	[Cpp2IlInjected.Token(Token = "0x40044E6")]
	public const short AtlanticCod = 2299;

	[Cpp2IlInjected.Token(Token = "0x40044E7")]
	public const short Tuna = 2300;

	[Cpp2IlInjected.Token(Token = "0x40044E8")]
	public const short RedSnapper = 2301;

	[Cpp2IlInjected.Token(Token = "0x40044E9")]
	public const short NeonTetra = 2302;

	[Cpp2IlInjected.Token(Token = "0x40044EA")]
	public const short ArmoredCavefish = 2303;

	[Cpp2IlInjected.Token(Token = "0x40044EB")]
	public const short Damselfish = 2304;

	[Cpp2IlInjected.Token(Token = "0x40044EC")]
	public const short CrimsonTigerfish = 2305;

	[Cpp2IlInjected.Token(Token = "0x40044ED")]
	public const short FrostMinnow = 2306;

	[Cpp2IlInjected.Token(Token = "0x40044EE")]
	public const short PrincessFish = 2307;

	[Cpp2IlInjected.Token(Token = "0x40044EF")]
	public const short GoldenCarp = 2308;

	[Cpp2IlInjected.Token(Token = "0x40044F0")]
	public const short SpecularFish = 2309;

	[Cpp2IlInjected.Token(Token = "0x40044F1")]
	public const short Prismite = 2310;

	[Cpp2IlInjected.Token(Token = "0x40044F2")]
	public const short VariegatedLardfish = 2311;

	[Cpp2IlInjected.Token(Token = "0x40044F3")]
	public const short FlarefinKoi = 2312;

	[Cpp2IlInjected.Token(Token = "0x40044F4")]
	public const short DoubleCod = 2313;

	[Cpp2IlInjected.Token(Token = "0x40044F5")]
	public const short Honeyfin = 2314;

	[Cpp2IlInjected.Token(Token = "0x40044F6")]
	public const short Obsidifish = 2315;

	[Cpp2IlInjected.Token(Token = "0x40044F7")]
	public const short Shrimp = 2316;

	[Cpp2IlInjected.Token(Token = "0x40044F8")]
	public const short ChaosFish = 2317;

	[Cpp2IlInjected.Token(Token = "0x40044F9")]
	public const short Ebonkoi = 2318;

	[Cpp2IlInjected.Token(Token = "0x40044FA")]
	public const short Hemopiranha = 2319;

	[Cpp2IlInjected.Token(Token = "0x40044FB")]
	public const short Rockfish = 2320;

	[Cpp2IlInjected.Token(Token = "0x40044FC")]
	public const short Stinkfish = 2321;

	[Cpp2IlInjected.Token(Token = "0x40044FD")]
	public const short MiningPotion = 2322;

	[Cpp2IlInjected.Token(Token = "0x40044FE")]
	public const short HeartreachPotion = 2323;

	[Cpp2IlInjected.Token(Token = "0x40044FF")]
	public const short CalmingPotion = 2324;

	[Cpp2IlInjected.Token(Token = "0x4004500")]
	public const short BuilderPotion = 2325;

	[Cpp2IlInjected.Token(Token = "0x4004501")]
	public const short TitanPotion = 2326;

	[Cpp2IlInjected.Token(Token = "0x4004502")]
	public const short FlipperPotion = 2327;

	[Cpp2IlInjected.Token(Token = "0x4004503")]
	public const short SummoningPotion = 2328;

	[Cpp2IlInjected.Token(Token = "0x4004504")]
	public const short TrapsightPotion = 2329;

	[Cpp2IlInjected.Token(Token = "0x4004505")]
	public const short PurpleClubberfish = 2330;

	[Cpp2IlInjected.Token(Token = "0x4004506")]
	public const short ObsidianSwordfish = 2331;

	[Cpp2IlInjected.Token(Token = "0x4004507")]
	public const short Swordfish = 2332;

	[Cpp2IlInjected.Token(Token = "0x4004508")]
	public const short IronFence = 2333;

	[Cpp2IlInjected.Token(Token = "0x4004509")]
	public const short WoodenCrate = 2334;

	[Cpp2IlInjected.Token(Token = "0x400450A")]
	public const short IronCrate = 2335;

	[Cpp2IlInjected.Token(Token = "0x400450B")]
	public const short GoldenCrate = 2336;

	[Cpp2IlInjected.Token(Token = "0x400450C")]
	public const short OldShoe = 2337;

	[Cpp2IlInjected.Token(Token = "0x400450D")]
	public const short FishingSeaweed = 2338;

	[Cpp2IlInjected.Token(Token = "0x400450E")]
	public const short TinCan = 2339;

	[Cpp2IlInjected.Token(Token = "0x400450F")]
	public const short MinecartTrack = 2340;

	[Cpp2IlInjected.Token(Token = "0x4004510")]
	public const short ReaverShark = 2341;

	[Cpp2IlInjected.Token(Token = "0x4004511")]
	public const short SawtoothShark = 2342;

	[Cpp2IlInjected.Token(Token = "0x4004512")]
	public const short Minecart = 2343;

	[Cpp2IlInjected.Token(Token = "0x4004513")]
	public const short AmmoReservationPotion = 2344;

	[Cpp2IlInjected.Token(Token = "0x4004514")]
	public const short LifeforcePotion = 2345;

	[Cpp2IlInjected.Token(Token = "0x4004515")]
	public const short EndurancePotion = 2346;

	[Cpp2IlInjected.Token(Token = "0x4004516")]
	public const short RagePotion = 2347;

	[Cpp2IlInjected.Token(Token = "0x4004517")]
	public const short InfernoPotion = 2348;

	[Cpp2IlInjected.Token(Token = "0x4004518")]
	public const short WrathPotion = 2349;

	[Cpp2IlInjected.Token(Token = "0x4004519")]
	public const short RecallPotion = 2350;

	[Cpp2IlInjected.Token(Token = "0x400451A")]
	public const short TeleportationPotion = 2351;

	[Cpp2IlInjected.Token(Token = "0x400451B")]
	public const short LovePotion = 2352;

	[Cpp2IlInjected.Token(Token = "0x400451C")]
	public const short StinkPotion = 2353;

	[Cpp2IlInjected.Token(Token = "0x400451D")]
	public const short FishingPotion = 2354;

	[Cpp2IlInjected.Token(Token = "0x400451E")]
	public const short SonarPotion = 2355;

	[Cpp2IlInjected.Token(Token = "0x400451F")]
	public const short CratePotion = 2356;

	[Cpp2IlInjected.Token(Token = "0x4004520")]
	public const short ShiverthornSeeds = 2357;

	[Cpp2IlInjected.Token(Token = "0x4004521")]
	public const short Shiverthorn = 2358;

	[Cpp2IlInjected.Token(Token = "0x4004522")]
	public const short WarmthPotion = 2359;

	[Cpp2IlInjected.Token(Token = "0x4004523")]
	public const short FishHook = 2360;

	[Cpp2IlInjected.Token(Token = "0x4004524")]
	public const short BeeHeadgear = 2361;

	[Cpp2IlInjected.Token(Token = "0x4004525")]
	public const short BeeBreastplate = 2362;

	[Cpp2IlInjected.Token(Token = "0x4004526")]
	public const short BeeGreaves = 2363;

	[Cpp2IlInjected.Token(Token = "0x4004527")]
	public const short HornetStaff = 2364;

	[Cpp2IlInjected.Token(Token = "0x4004528")]
	public const short ImpStaff = 2365;

	[Cpp2IlInjected.Token(Token = "0x4004529")]
	public const short QueenSpiderStaff = 2366;

	[Cpp2IlInjected.Token(Token = "0x400452A")]
	public const short AnglerHat = 2367;

	[Cpp2IlInjected.Token(Token = "0x400452B")]
	public const short AnglerVest = 2368;

	[Cpp2IlInjected.Token(Token = "0x400452C")]
	public const short AnglerPants = 2369;

	[Cpp2IlInjected.Token(Token = "0x400452D")]
	public const short SpiderMask = 2370;

	[Cpp2IlInjected.Token(Token = "0x400452E")]
	public const short SpiderBreastplate = 2371;

	[Cpp2IlInjected.Token(Token = "0x400452F")]
	public const short SpiderGreaves = 2372;

	[Cpp2IlInjected.Token(Token = "0x4004530")]
	public const short HighTestFishingLine = 2373;

	[Cpp2IlInjected.Token(Token = "0x4004531")]
	public const short AnglerEarring = 2374;

	[Cpp2IlInjected.Token(Token = "0x4004532")]
	public const short TackleBox = 2375;

	[Cpp2IlInjected.Token(Token = "0x4004533")]
	public const short BlueDungeonPiano = 2376;

	[Cpp2IlInjected.Token(Token = "0x4004534")]
	public const short GreenDungeonPiano = 2377;

	[Cpp2IlInjected.Token(Token = "0x4004535")]
	public const short PinkDungeonPiano = 2378;

	[Cpp2IlInjected.Token(Token = "0x4004536")]
	public const short GoldenPiano = 2379;

	[Cpp2IlInjected.Token(Token = "0x4004537")]
	public const short ObsidianPiano = 2380;

	[Cpp2IlInjected.Token(Token = "0x4004538")]
	public const short BonePiano = 2381;

	[Cpp2IlInjected.Token(Token = "0x4004539")]
	public const short CactusPiano = 2382;

	[Cpp2IlInjected.Token(Token = "0x400453A")]
	public const short SpookyPiano = 2383;

	[Cpp2IlInjected.Token(Token = "0x400453B")]
	public const short SkywarePiano = 2384;

	[Cpp2IlInjected.Token(Token = "0x400453C")]
	public const short LihzahrdPiano = 2385;

	[Cpp2IlInjected.Token(Token = "0x400453D")]
	public const short BlueDungeonDresser = 2386;

	[Cpp2IlInjected.Token(Token = "0x400453E")]
	public const short GreenDungeonDresser = 2387;

	[Cpp2IlInjected.Token(Token = "0x400453F")]
	public const short PinkDungeonDresser = 2388;

	[Cpp2IlInjected.Token(Token = "0x4004540")]
	public const short GoldenDresser = 2389;

	[Cpp2IlInjected.Token(Token = "0x4004541")]
	public const short ObsidianDresser = 2390;

	[Cpp2IlInjected.Token(Token = "0x4004542")]
	public const short BoneDresser = 2391;

	[Cpp2IlInjected.Token(Token = "0x4004543")]
	public const short CactusDresser = 2392;

	[Cpp2IlInjected.Token(Token = "0x4004544")]
	public const short SpookyDresser = 2393;

	[Cpp2IlInjected.Token(Token = "0x4004545")]
	public const short SkywareDresser = 2394;

	[Cpp2IlInjected.Token(Token = "0x4004546")]
	public const short HoneyDresser = 2395;

	[Cpp2IlInjected.Token(Token = "0x4004547")]
	public const short LihzahrdDresser = 2396;

	[Cpp2IlInjected.Token(Token = "0x4004548")]
	public const short Sofa = 2397;

	[Cpp2IlInjected.Token(Token = "0x4004549")]
	public const short EbonwoodSofa = 2398;

	[Cpp2IlInjected.Token(Token = "0x400454A")]
	public const short RichMahoganySofa = 2399;

	[Cpp2IlInjected.Token(Token = "0x400454B")]
	public const short PearlwoodSofa = 2400;

	[Cpp2IlInjected.Token(Token = "0x400454C")]
	public const short ShadewoodSofa = 2401;

	[Cpp2IlInjected.Token(Token = "0x400454D")]
	public const short BlueDungeonSofa = 2402;

	[Cpp2IlInjected.Token(Token = "0x400454E")]
	public const short GreenDungeonSofa = 2403;

	[Cpp2IlInjected.Token(Token = "0x400454F")]
	public const short PinkDungeonSofa = 2404;

	[Cpp2IlInjected.Token(Token = "0x4004550")]
	public const short GoldenSofa = 2405;

	[Cpp2IlInjected.Token(Token = "0x4004551")]
	public const short ObsidianSofa = 2406;

	[Cpp2IlInjected.Token(Token = "0x4004552")]
	public const short BoneSofa = 2407;

	[Cpp2IlInjected.Token(Token = "0x4004553")]
	public const short CactusSofa = 2408;

	[Cpp2IlInjected.Token(Token = "0x4004554")]
	public const short SpookySofa = 2409;

	[Cpp2IlInjected.Token(Token = "0x4004555")]
	public const short SkywareSofa = 2410;

	[Cpp2IlInjected.Token(Token = "0x4004556")]
	public const short HoneySofa = 2411;

	[Cpp2IlInjected.Token(Token = "0x4004557")]
	public const short SteampunkSofa = 2412;

	[Cpp2IlInjected.Token(Token = "0x4004558")]
	public const short MushroomSofa = 2413;

	[Cpp2IlInjected.Token(Token = "0x4004559")]
	public const short GlassSofa = 2414;

	[Cpp2IlInjected.Token(Token = "0x400455A")]
	public const short PumpkinSofa = 2415;

	[Cpp2IlInjected.Token(Token = "0x400455B")]
	public const short LihzahrdSofa = 2416;

	[Cpp2IlInjected.Token(Token = "0x400455C")]
	public const short SeashellHairpin = 2417;

	[Cpp2IlInjected.Token(Token = "0x400455D")]
	public const short MermaidAdornment = 2418;

	[Cpp2IlInjected.Token(Token = "0x400455E")]
	public const short MermaidTail = 2419;

	[Cpp2IlInjected.Token(Token = "0x400455F")]
	public const short ZephyrFish = 2420;

	[Cpp2IlInjected.Token(Token = "0x4004560")]
	public const short Fleshcatcher = 2421;

	[Cpp2IlInjected.Token(Token = "0x4004561")]
	public const short HotlineFishingHook = 2422;

	[Cpp2IlInjected.Token(Token = "0x4004562")]
	public const short FrogLeg = 2423;

	[Cpp2IlInjected.Token(Token = "0x4004563")]
	public const short Anchor = 2424;

	[Cpp2IlInjected.Token(Token = "0x4004564")]
	public const short CookedFish = 2425;

	[Cpp2IlInjected.Token(Token = "0x4004565")]
	public const short CookedShrimp = 2426;

	[Cpp2IlInjected.Token(Token = "0x4004566")]
	public const short Sashimi = 2427;

	[Cpp2IlInjected.Token(Token = "0x4004567")]
	public const short FuzzyCarrot = 2428;

	[Cpp2IlInjected.Token(Token = "0x4004568")]
	public const short ScalyTruffle = 2429;

	[Cpp2IlInjected.Token(Token = "0x4004569")]
	public const short SlimySaddle = 2430;

	[Cpp2IlInjected.Token(Token = "0x400456A")]
	public const short BeeWax = 2431;

	[Cpp2IlInjected.Token(Token = "0x400456B")]
	public const short CopperPlatingWall = 2432;

	[Cpp2IlInjected.Token(Token = "0x400456C")]
	public const short StoneSlabWall = 2433;

	[Cpp2IlInjected.Token(Token = "0x400456D")]
	public const short Sail = 2434;

	[Cpp2IlInjected.Token(Token = "0x400456E")]
	public const short CoralstoneBlock = 2435;

	[Cpp2IlInjected.Token(Token = "0x400456F")]
	public const short BlueJellyfish = 2436;

	[Cpp2IlInjected.Token(Token = "0x4004570")]
	public const short GreenJellyfish = 2437;

	[Cpp2IlInjected.Token(Token = "0x4004571")]
	public const short PinkJellyfish = 2438;

	[Cpp2IlInjected.Token(Token = "0x4004572")]
	public const short BlueJellyfishJar = 2439;

	[Cpp2IlInjected.Token(Token = "0x4004573")]
	public const short GreenJellyfishJar = 2440;

	[Cpp2IlInjected.Token(Token = "0x4004574")]
	public const short PinkJellyfishJar = 2441;

	[Cpp2IlInjected.Token(Token = "0x4004575")]
	public const short LifePreserver = 2442;

	[Cpp2IlInjected.Token(Token = "0x4004576")]
	public const short ShipsWheel = 2443;

	[Cpp2IlInjected.Token(Token = "0x4004577")]
	public const short CompassRose = 2444;

	[Cpp2IlInjected.Token(Token = "0x4004578")]
	public const short WallAnchor = 2445;

	[Cpp2IlInjected.Token(Token = "0x4004579")]
	public const short GoldfishTrophy = 2446;

	[Cpp2IlInjected.Token(Token = "0x400457A")]
	public const short BunnyfishTrophy = 2447;

	[Cpp2IlInjected.Token(Token = "0x400457B")]
	public const short SwordfishTrophy = 2448;

	[Cpp2IlInjected.Token(Token = "0x400457C")]
	public const short SharkteethTrophy = 2449;

	[Cpp2IlInjected.Token(Token = "0x400457D")]
	public const short Batfish = 2450;

	[Cpp2IlInjected.Token(Token = "0x400457E")]
	public const short BumblebeeTuna = 2451;

	[Cpp2IlInjected.Token(Token = "0x400457F")]
	public const short Catfish = 2452;

	[Cpp2IlInjected.Token(Token = "0x4004580")]
	public const short Cloudfish = 2453;

	[Cpp2IlInjected.Token(Token = "0x4004581")]
	public const short Cursedfish = 2454;

	[Cpp2IlInjected.Token(Token = "0x4004582")]
	public const short Dirtfish = 2455;

	[Cpp2IlInjected.Token(Token = "0x4004583")]
	public const short DynamiteFish = 2456;

	[Cpp2IlInjected.Token(Token = "0x4004584")]
	public const short EaterofPlankton = 2457;

	[Cpp2IlInjected.Token(Token = "0x4004585")]
	public const short FallenStarfish = 2458;

	[Cpp2IlInjected.Token(Token = "0x4004586")]
	public const short TheFishofCthulu = 2459;

	[Cpp2IlInjected.Token(Token = "0x4004587")]
	public const short Fishotron = 2460;

	[Cpp2IlInjected.Token(Token = "0x4004588")]
	public const short Harpyfish = 2461;

	[Cpp2IlInjected.Token(Token = "0x4004589")]
	public const short Hungerfish = 2462;

	[Cpp2IlInjected.Token(Token = "0x400458A")]
	public const short Ichorfish = 2463;

	[Cpp2IlInjected.Token(Token = "0x400458B")]
	public const short Jewelfish = 2464;

	[Cpp2IlInjected.Token(Token = "0x400458C")]
	public const short MirageFish = 2465;

	[Cpp2IlInjected.Token(Token = "0x400458D")]
	public const short MutantFlinxfin = 2466;

	[Cpp2IlInjected.Token(Token = "0x400458E")]
	public const short Pengfish = 2467;

	[Cpp2IlInjected.Token(Token = "0x400458F")]
	public const short Pixiefish = 2468;

	[Cpp2IlInjected.Token(Token = "0x4004590")]
	public const short Spiderfish = 2469;

	[Cpp2IlInjected.Token(Token = "0x4004591")]
	public const short TundraTrout = 2470;

	[Cpp2IlInjected.Token(Token = "0x4004592")]
	public const short UnicornFish = 2471;

	[Cpp2IlInjected.Token(Token = "0x4004593")]
	public const short GuideVoodooFish = 2472;

	[Cpp2IlInjected.Token(Token = "0x4004594")]
	public const short Wyverntail = 2473;

	[Cpp2IlInjected.Token(Token = "0x4004595")]
	public const short ZombieFish = 2474;

	[Cpp2IlInjected.Token(Token = "0x4004596")]
	public const short AmanitaFungifin = 2475;

	[Cpp2IlInjected.Token(Token = "0x4004597")]
	public const short Angelfish = 2476;

	[Cpp2IlInjected.Token(Token = "0x4004598")]
	public const short BloodyManowar = 2477;

	[Cpp2IlInjected.Token(Token = "0x4004599")]
	public const short Bonefish = 2478;

	[Cpp2IlInjected.Token(Token = "0x400459A")]
	public const short Bunnyfish = 2479;

	[Cpp2IlInjected.Token(Token = "0x400459B")]
	public const short CapnTunabeard = 2480;

	[Cpp2IlInjected.Token(Token = "0x400459C")]
	public const short Clownfish = 2481;

	[Cpp2IlInjected.Token(Token = "0x400459D")]
	public const short DemonicHellfish = 2482;

	[Cpp2IlInjected.Token(Token = "0x400459E")]
	public const short Derpfish = 2483;

	[Cpp2IlInjected.Token(Token = "0x400459F")]
	public const short Fishron = 2484;

	[Cpp2IlInjected.Token(Token = "0x40045A0")]
	public const short InfectedScabbardfish = 2485;

	[Cpp2IlInjected.Token(Token = "0x40045A1")]
	public const short Mudfish = 2486;

	[Cpp2IlInjected.Token(Token = "0x40045A2")]
	public const short Slimefish = 2487;

	[Cpp2IlInjected.Token(Token = "0x40045A3")]
	public const short TropicalBarracuda = 2488;

	[Cpp2IlInjected.Token(Token = "0x40045A4")]
	public const short KingSlimeTrophy = 2489;

	[Cpp2IlInjected.Token(Token = "0x40045A5")]
	public const short ShipInABottle = 2490;

	[Cpp2IlInjected.Token(Token = "0x40045A6")]
	public const short HardySaddle = 2491;

	[Cpp2IlInjected.Token(Token = "0x40045A7")]
	public const short PressureTrack = 2492;

	[Cpp2IlInjected.Token(Token = "0x40045A8")]
	public const short KingSlimeMask = 2493;

	[Cpp2IlInjected.Token(Token = "0x40045A9")]
	public const short FinWings = 2494;

	[Cpp2IlInjected.Token(Token = "0x40045AA")]
	public const short TreasureMap = 2495;

	[Cpp2IlInjected.Token(Token = "0x40045AB")]
	public const short SeaweedPlanter = 2496;

	[Cpp2IlInjected.Token(Token = "0x40045AC")]
	public const short PillaginMePixels = 2497;

	[Cpp2IlInjected.Token(Token = "0x40045AD")]
	public const short FishCostumeMask = 2498;

	[Cpp2IlInjected.Token(Token = "0x40045AE")]
	public const short FishCostumeShirt = 2499;

	[Cpp2IlInjected.Token(Token = "0x40045AF")]
	public const short FishCostumeFinskirt = 2500;

	[Cpp2IlInjected.Token(Token = "0x40045B0")]
	public const short GingerBeard = 2501;

	[Cpp2IlInjected.Token(Token = "0x40045B1")]
	public const short HoneyedGoggles = 2502;

	[Cpp2IlInjected.Token(Token = "0x40045B2")]
	public const short BorealWood = 2503;

	[Cpp2IlInjected.Token(Token = "0x40045B3")]
	public const short PalmWood = 2504;

	[Cpp2IlInjected.Token(Token = "0x40045B4")]
	public const short BorealWoodWall = 2505;

	[Cpp2IlInjected.Token(Token = "0x40045B5")]
	public const short PalmWoodWall = 2506;

	[Cpp2IlInjected.Token(Token = "0x40045B6")]
	public const short BorealWoodFence = 2507;

	[Cpp2IlInjected.Token(Token = "0x40045B7")]
	public const short PalmWoodFence = 2508;

	[Cpp2IlInjected.Token(Token = "0x40045B8")]
	public const short BorealWoodHelmet = 2509;

	[Cpp2IlInjected.Token(Token = "0x40045B9")]
	public const short BorealWoodBreastplate = 2510;

	[Cpp2IlInjected.Token(Token = "0x40045BA")]
	public const short BorealWoodGreaves = 2511;

	[Cpp2IlInjected.Token(Token = "0x40045BB")]
	public const short PalmWoodHelmet = 2512;

	[Cpp2IlInjected.Token(Token = "0x40045BC")]
	public const short PalmWoodBreastplate = 2513;

	[Cpp2IlInjected.Token(Token = "0x40045BD")]
	public const short PalmWoodGreaves = 2514;

	[Cpp2IlInjected.Token(Token = "0x40045BE")]
	public const short PalmWoodBow = 2515;

	[Cpp2IlInjected.Token(Token = "0x40045BF")]
	public const short PalmWoodHammer = 2516;

	[Cpp2IlInjected.Token(Token = "0x40045C0")]
	public const short PalmWoodSword = 2517;

	[Cpp2IlInjected.Token(Token = "0x40045C1")]
	public const short PalmWoodPlatform = 2518;

	[Cpp2IlInjected.Token(Token = "0x40045C2")]
	public const short PalmWoodBathtub = 2519;

	[Cpp2IlInjected.Token(Token = "0x40045C3")]
	public const short PalmWoodBed = 2520;

	[Cpp2IlInjected.Token(Token = "0x40045C4")]
	public const short PalmWoodBench = 2521;

	[Cpp2IlInjected.Token(Token = "0x40045C5")]
	public const short PalmWoodCandelabra = 2522;

	[Cpp2IlInjected.Token(Token = "0x40045C6")]
	public const short PalmWoodCandle = 2523;

	[Cpp2IlInjected.Token(Token = "0x40045C7")]
	public const short PalmWoodChair = 2524;

	[Cpp2IlInjected.Token(Token = "0x40045C8")]
	public const short PalmWoodChandelier = 2525;

	[Cpp2IlInjected.Token(Token = "0x40045C9")]
	public const short PalmWoodChest = 2526;

	[Cpp2IlInjected.Token(Token = "0x40045CA")]
	public const short PalmWoodSofa = 2527;

	[Cpp2IlInjected.Token(Token = "0x40045CB")]
	public const short PalmWoodDoor = 2528;

	[Cpp2IlInjected.Token(Token = "0x40045CC")]
	public const short PalmWoodDresser = 2529;

	[Cpp2IlInjected.Token(Token = "0x40045CD")]
	public const short PalmWoodLantern = 2530;

	[Cpp2IlInjected.Token(Token = "0x40045CE")]
	public const short PalmWoodPiano = 2531;

	[Cpp2IlInjected.Token(Token = "0x40045CF")]
	public const short PalmWoodTable = 2532;

	[Cpp2IlInjected.Token(Token = "0x40045D0")]
	public const short PalmWoodLamp = 2533;

	[Cpp2IlInjected.Token(Token = "0x40045D1")]
	public const short PalmWoodWorkBench = 2534;

	[Cpp2IlInjected.Token(Token = "0x40045D2")]
	public const short OpticStaff = 2535;

	[Cpp2IlInjected.Token(Token = "0x40045D3")]
	public const short PalmWoodBookcase = 2536;

	[Cpp2IlInjected.Token(Token = "0x40045D4")]
	public const short MushroomBathtub = 2537;

	[Cpp2IlInjected.Token(Token = "0x40045D5")]
	public const short MushroomBed = 2538;

	[Cpp2IlInjected.Token(Token = "0x40045D6")]
	public const short MushroomBench = 2539;

	[Cpp2IlInjected.Token(Token = "0x40045D7")]
	public const short MushroomBookcase = 2540;

	[Cpp2IlInjected.Token(Token = "0x40045D8")]
	public const short MushroomCandelabra = 2541;

	[Cpp2IlInjected.Token(Token = "0x40045D9")]
	public const short MushroomCandle = 2542;

	[Cpp2IlInjected.Token(Token = "0x40045DA")]
	public const short MushroomChandelier = 2543;

	[Cpp2IlInjected.Token(Token = "0x40045DB")]
	public const short MushroomChest = 2544;

	[Cpp2IlInjected.Token(Token = "0x40045DC")]
	public const short MushroomDresser = 2545;

	[Cpp2IlInjected.Token(Token = "0x40045DD")]
	public const short MushroomLantern = 2546;

	[Cpp2IlInjected.Token(Token = "0x40045DE")]
	public const short MushroomLamp = 2547;

	[Cpp2IlInjected.Token(Token = "0x40045DF")]
	public const short MushroomPiano = 2548;

	[Cpp2IlInjected.Token(Token = "0x40045E0")]
	public const short MushroomPlatform = 2549;

	[Cpp2IlInjected.Token(Token = "0x40045E1")]
	public const short MushroomTable = 2550;

	[Cpp2IlInjected.Token(Token = "0x40045E2")]
	public const short SpiderStaff = 2551;

	[Cpp2IlInjected.Token(Token = "0x40045E3")]
	public const short BorealWoodBathtub = 2552;

	[Cpp2IlInjected.Token(Token = "0x40045E4")]
	public const short BorealWoodBed = 2553;

	[Cpp2IlInjected.Token(Token = "0x40045E5")]
	public const short BorealWoodBookcase = 2554;

	[Cpp2IlInjected.Token(Token = "0x40045E6")]
	public const short BorealWoodCandelabra = 2555;

	[Cpp2IlInjected.Token(Token = "0x40045E7")]
	public const short BorealWoodCandle = 2556;

	[Cpp2IlInjected.Token(Token = "0x40045E8")]
	public const short BorealWoodChair = 2557;

	[Cpp2IlInjected.Token(Token = "0x40045E9")]
	public const short BorealWoodChandelier = 2558;

	[Cpp2IlInjected.Token(Token = "0x40045EA")]
	public const short BorealWoodChest = 2559;

	[Cpp2IlInjected.Token(Token = "0x40045EB")]
	public const short BorealWoodClock = 2560;

	[Cpp2IlInjected.Token(Token = "0x40045EC")]
	public const short BorealWoodDoor = 2561;

	[Cpp2IlInjected.Token(Token = "0x40045ED")]
	public const short BorealWoodDresser = 2562;

	[Cpp2IlInjected.Token(Token = "0x40045EE")]
	public const short BorealWoodLamp = 2563;

	[Cpp2IlInjected.Token(Token = "0x40045EF")]
	public const short BorealWoodLantern = 2564;

	[Cpp2IlInjected.Token(Token = "0x40045F0")]
	public const short BorealWoodPiano = 2565;

	[Cpp2IlInjected.Token(Token = "0x40045F1")]
	public const short BorealWoodPlatform = 2566;

	[Cpp2IlInjected.Token(Token = "0x40045F2")]
	public const short SlimeBathtub = 2567;

	[Cpp2IlInjected.Token(Token = "0x40045F3")]
	public const short SlimeBed = 2568;

	[Cpp2IlInjected.Token(Token = "0x40045F4")]
	public const short SlimeBookcase = 2569;

	[Cpp2IlInjected.Token(Token = "0x40045F5")]
	public const short SlimeCandelabra = 2570;

	[Cpp2IlInjected.Token(Token = "0x40045F6")]
	public const short SlimeCandle = 2571;

	[Cpp2IlInjected.Token(Token = "0x40045F7")]
	public const short SlimeChair = 2572;

	[Cpp2IlInjected.Token(Token = "0x40045F8")]
	public const short SlimeChandelier = 2573;

	[Cpp2IlInjected.Token(Token = "0x40045F9")]
	public const short SlimeChest = 2574;

	[Cpp2IlInjected.Token(Token = "0x40045FA")]
	public const short SlimeClock = 2575;

	[Cpp2IlInjected.Token(Token = "0x40045FB")]
	public const short SlimeDoor = 2576;

	[Cpp2IlInjected.Token(Token = "0x40045FC")]
	public const short SlimeDresser = 2577;

	[Cpp2IlInjected.Token(Token = "0x40045FD")]
	public const short SlimeLamp = 2578;

	[Cpp2IlInjected.Token(Token = "0x40045FE")]
	public const short SlimeLantern = 2579;

	[Cpp2IlInjected.Token(Token = "0x40045FF")]
	public const short SlimePiano = 2580;

	[Cpp2IlInjected.Token(Token = "0x4004600")]
	public const short SlimePlatform = 2581;

	[Cpp2IlInjected.Token(Token = "0x4004601")]
	public const short SlimeSofa = 2582;

	[Cpp2IlInjected.Token(Token = "0x4004602")]
	public const short SlimeTable = 2583;

	[Cpp2IlInjected.Token(Token = "0x4004603")]
	public const short PirateStaff = 2584;

	[Cpp2IlInjected.Token(Token = "0x4004604")]
	public const short SlimeHook = 2585;

	[Cpp2IlInjected.Token(Token = "0x4004605")]
	public const short StickyGrenade = 2586;

	[Cpp2IlInjected.Token(Token = "0x4004606")]
	public const short TartarSauce = 2587;

	[Cpp2IlInjected.Token(Token = "0x4004607")]
	public const short DukeFishronMask = 2588;

	[Cpp2IlInjected.Token(Token = "0x4004608")]
	public const short DukeFishronTrophy = 2589;

	[Cpp2IlInjected.Token(Token = "0x4004609")]
	public const short MolotovCocktail = 2590;

	[Cpp2IlInjected.Token(Token = "0x400460A")]
	public const short BoneClock = 2591;

	[Cpp2IlInjected.Token(Token = "0x400460B")]
	public const short CactusClock = 2592;

	[Cpp2IlInjected.Token(Token = "0x400460C")]
	public const short EbonwoodClock = 2593;

	[Cpp2IlInjected.Token(Token = "0x400460D")]
	public const short FrozenClock = 2594;

	[Cpp2IlInjected.Token(Token = "0x400460E")]
	public const short LihzahrdClock = 2595;

	[Cpp2IlInjected.Token(Token = "0x400460F")]
	public const short LivingWoodClock = 2596;

	[Cpp2IlInjected.Token(Token = "0x4004610")]
	public const short RichMahoganyClock = 2597;

	[Cpp2IlInjected.Token(Token = "0x4004611")]
	public const short FleshClock = 2598;

	[Cpp2IlInjected.Token(Token = "0x4004612")]
	public const short MushroomClock = 2599;

	[Cpp2IlInjected.Token(Token = "0x4004613")]
	public const short ObsidianClock = 2600;

	[Cpp2IlInjected.Token(Token = "0x4004614")]
	public const short PalmWoodClock = 2601;

	[Cpp2IlInjected.Token(Token = "0x4004615")]
	public const short PearlwoodClock = 2602;

	[Cpp2IlInjected.Token(Token = "0x4004616")]
	public const short PumpkinClock = 2603;

	[Cpp2IlInjected.Token(Token = "0x4004617")]
	public const short ShadewoodClock = 2604;

	[Cpp2IlInjected.Token(Token = "0x4004618")]
	public const short SpookyClock = 2605;

	[Cpp2IlInjected.Token(Token = "0x4004619")]
	public const short SkywareClock = 2606;

	[Cpp2IlInjected.Token(Token = "0x400461A")]
	public const short SpiderFang = 2607;

	[Cpp2IlInjected.Token(Token = "0x400461B")]
	public const short FalconBlade = 2608;

	[Cpp2IlInjected.Token(Token = "0x400461C")]
	public const short FishronWings = 2609;

	[Cpp2IlInjected.Token(Token = "0x400461D")]
	public const short SlimeGun = 2610;

	[Cpp2IlInjected.Token(Token = "0x400461E")]
	public const short Flairon = 2611;

	[Cpp2IlInjected.Token(Token = "0x400461F")]
	public const short GreenDungeonChest = 2612;

	[Cpp2IlInjected.Token(Token = "0x4004620")]
	public const short PinkDungeonChest = 2613;

	[Cpp2IlInjected.Token(Token = "0x4004621")]
	public const short BlueDungeonChest = 2614;

	[Cpp2IlInjected.Token(Token = "0x4004622")]
	public const short BoneChest = 2615;

	[Cpp2IlInjected.Token(Token = "0x4004623")]
	public const short CactusChest = 2616;

	[Cpp2IlInjected.Token(Token = "0x4004624")]
	public const short FleshChest = 2617;

	[Cpp2IlInjected.Token(Token = "0x4004625")]
	public const short ObsidianChest = 2618;

	[Cpp2IlInjected.Token(Token = "0x4004626")]
	public const short PumpkinChest = 2619;

	[Cpp2IlInjected.Token(Token = "0x4004627")]
	public const short SpookyChest = 2620;

	[Cpp2IlInjected.Token(Token = "0x4004628")]
	public const short TempestStaff = 2621;

	[Cpp2IlInjected.Token(Token = "0x4004629")]
	public const short RazorbladeTyphoon = 2622;

	[Cpp2IlInjected.Token(Token = "0x400462A")]
	public const short BubbleGun = 2623;

	[Cpp2IlInjected.Token(Token = "0x400462B")]
	public const short Tsunami = 2624;

	[Cpp2IlInjected.Token(Token = "0x400462C")]
	public const short Seashell = 2625;

	[Cpp2IlInjected.Token(Token = "0x400462D")]
	public const short Starfish = 2626;

	[Cpp2IlInjected.Token(Token = "0x400462E")]
	public const short SteampunkPlatform = 2627;

	[Cpp2IlInjected.Token(Token = "0x400462F")]
	public const short SkywarePlatform = 2628;

	[Cpp2IlInjected.Token(Token = "0x4004630")]
	public const short LivingWoodPlatform = 2629;

	[Cpp2IlInjected.Token(Token = "0x4004631")]
	public const short HoneyPlatform = 2630;

	[Cpp2IlInjected.Token(Token = "0x4004632")]
	public const short SkywareWorkbench = 2631;

	[Cpp2IlInjected.Token(Token = "0x4004633")]
	public const short GlassWorkBench = 2632;

	[Cpp2IlInjected.Token(Token = "0x4004634")]
	public const short LivingWoodWorkBench = 2633;

	[Cpp2IlInjected.Token(Token = "0x4004635")]
	public const short FleshSofa = 2634;

	[Cpp2IlInjected.Token(Token = "0x4004636")]
	public const short FrozenSofa = 2635;

	[Cpp2IlInjected.Token(Token = "0x4004637")]
	public const short LivingWoodSofa = 2636;

	[Cpp2IlInjected.Token(Token = "0x4004638")]
	public const short PumpkinDresser = 2637;

	[Cpp2IlInjected.Token(Token = "0x4004639")]
	public const short SteampunkDresser = 2638;

	[Cpp2IlInjected.Token(Token = "0x400463A")]
	public const short GlassDresser = 2639;

	[Cpp2IlInjected.Token(Token = "0x400463B")]
	public const short FleshDresser = 2640;

	[Cpp2IlInjected.Token(Token = "0x400463C")]
	public const short PumpkinLantern = 2641;

	[Cpp2IlInjected.Token(Token = "0x400463D")]
	public const short ObsidianLantern = 2642;

	[Cpp2IlInjected.Token(Token = "0x400463E")]
	public const short PumpkinLamp = 2643;

	[Cpp2IlInjected.Token(Token = "0x400463F")]
	public const short ObsidianLamp = 2644;

	[Cpp2IlInjected.Token(Token = "0x4004640")]
	public const short BlueDungeonLamp = 2645;

	[Cpp2IlInjected.Token(Token = "0x4004641")]
	public const short GreenDungeonLamp = 2646;

	[Cpp2IlInjected.Token(Token = "0x4004642")]
	public const short PinkDungeonLamp = 2647;

	[Cpp2IlInjected.Token(Token = "0x4004643")]
	public const short HoneyCandle = 2648;

	[Cpp2IlInjected.Token(Token = "0x4004644")]
	public const short SteampunkCandle = 2649;

	[Cpp2IlInjected.Token(Token = "0x4004645")]
	public const short SpookyCandle = 2650;

	[Cpp2IlInjected.Token(Token = "0x4004646")]
	public const short ObsidianCandle = 2651;

	[Cpp2IlInjected.Token(Token = "0x4004647")]
	public const short BlueDungeonChandelier = 2652;

	[Cpp2IlInjected.Token(Token = "0x4004648")]
	public const short GreenDungeonChandelier = 2653;

	[Cpp2IlInjected.Token(Token = "0x4004649")]
	public const short PinkDungeonChandelier = 2654;

	[Cpp2IlInjected.Token(Token = "0x400464A")]
	public const short SteampunkChandelier = 2655;

	[Cpp2IlInjected.Token(Token = "0x400464B")]
	public const short PumpkinChandelier = 2656;

	[Cpp2IlInjected.Token(Token = "0x400464C")]
	public const short ObsidianChandelier = 2657;

	[Cpp2IlInjected.Token(Token = "0x400464D")]
	public const short BlueDungeonBathtub = 2658;

	[Cpp2IlInjected.Token(Token = "0x400464E")]
	public const short GreenDungeonBathtub = 2659;

	[Cpp2IlInjected.Token(Token = "0x400464F")]
	public const short PinkDungeonBathtub = 2660;

	[Cpp2IlInjected.Token(Token = "0x4004650")]
	public const short PumpkinBathtub = 2661;

	[Cpp2IlInjected.Token(Token = "0x4004651")]
	public const short ObsidianBathtub = 2662;

	[Cpp2IlInjected.Token(Token = "0x4004652")]
	public const short GoldenBathtub = 2663;

	[Cpp2IlInjected.Token(Token = "0x4004653")]
	public const short BlueDungeonCandelabra = 2664;

	[Cpp2IlInjected.Token(Token = "0x4004654")]
	public const short GreenDungeonCandelabra = 2665;

	[Cpp2IlInjected.Token(Token = "0x4004655")]
	public const short PinkDungeonCandelabra = 2666;

	[Cpp2IlInjected.Token(Token = "0x4004656")]
	public const short ObsidianCandelabra = 2667;

	[Cpp2IlInjected.Token(Token = "0x4004657")]
	public const short PumpkinCandelabra = 2668;

	[Cpp2IlInjected.Token(Token = "0x4004658")]
	public const short PumpkinBed = 2669;

	[Cpp2IlInjected.Token(Token = "0x4004659")]
	public const short PumpkinBookcase = 2670;

	[Cpp2IlInjected.Token(Token = "0x400465A")]
	public const short PumpkinPiano = 2671;

	[Cpp2IlInjected.Token(Token = "0x400465B")]
	public const short SharkStatue = 2672;

	[Cpp2IlInjected.Token(Token = "0x400465C")]
	public const short TruffleWorm = 2673;

	[Cpp2IlInjected.Token(Token = "0x400465D")]
	public const short ApprenticeBait = 2674;

	[Cpp2IlInjected.Token(Token = "0x400465E")]
	public const short JourneymanBait = 2675;

	[Cpp2IlInjected.Token(Token = "0x400465F")]
	public const short MasterBait = 2676;

	[Cpp2IlInjected.Token(Token = "0x4004660")]
	public const short AmberGemsparkWall = 2677;

	[Cpp2IlInjected.Token(Token = "0x4004661")]
	public const short AmberGemsparkWallOff = 2678;

	[Cpp2IlInjected.Token(Token = "0x4004662")]
	public const short AmethystGemsparkWall = 2679;

	[Cpp2IlInjected.Token(Token = "0x4004663")]
	public const short AmethystGemsparkWallOff = 2680;

	[Cpp2IlInjected.Token(Token = "0x4004664")]
	public const short DiamondGemsparkWall = 2681;

	[Cpp2IlInjected.Token(Token = "0x4004665")]
	public const short DiamondGemsparkWallOff = 2682;

	[Cpp2IlInjected.Token(Token = "0x4004666")]
	public const short EmeraldGemsparkWall = 2683;

	[Cpp2IlInjected.Token(Token = "0x4004667")]
	public const short EmeraldGemsparkWallOff = 2684;

	[Cpp2IlInjected.Token(Token = "0x4004668")]
	public const short RubyGemsparkWall = 2685;

	[Cpp2IlInjected.Token(Token = "0x4004669")]
	public const short RubyGemsparkWallOff = 2686;

	[Cpp2IlInjected.Token(Token = "0x400466A")]
	public const short SapphireGemsparkWall = 2687;

	[Cpp2IlInjected.Token(Token = "0x400466B")]
	public const short SapphireGemsparkWallOff = 2688;

	[Cpp2IlInjected.Token(Token = "0x400466C")]
	public const short TopazGemsparkWall = 2689;

	[Cpp2IlInjected.Token(Token = "0x400466D")]
	public const short TopazGemsparkWallOff = 2690;

	[Cpp2IlInjected.Token(Token = "0x400466E")]
	public const short TinPlatingWall = 2691;

	[Cpp2IlInjected.Token(Token = "0x400466F")]
	public const short TinPlating = 2692;

	[Cpp2IlInjected.Token(Token = "0x4004670")]
	public const short WaterfallBlock = 2693;

	[Cpp2IlInjected.Token(Token = "0x4004671")]
	public const short LavafallBlock = 2694;

	[Cpp2IlInjected.Token(Token = "0x4004672")]
	public const short ConfettiBlock = 2695;

	[Cpp2IlInjected.Token(Token = "0x4004673")]
	public const short ConfettiWall = 2696;

	[Cpp2IlInjected.Token(Token = "0x4004674")]
	public const short ConfettiBlockBlack = 2697;

	[Cpp2IlInjected.Token(Token = "0x4004675")]
	public const short ConfettiWallBlack = 2698;

	[Cpp2IlInjected.Token(Token = "0x4004676")]
	public const short WeaponRack = 2699;

	[Cpp2IlInjected.Token(Token = "0x4004677")]
	public const short FireworksBox = 2700;

	[Cpp2IlInjected.Token(Token = "0x4004678")]
	public const short LivingFireBlock = 2701;

	[Cpp2IlInjected.Token(Token = "0x4004679")]
	public const short AlphabetStatue0 = 2702;

	[Cpp2IlInjected.Token(Token = "0x400467A")]
	public const short AlphabetStatue1 = 2703;

	[Cpp2IlInjected.Token(Token = "0x400467B")]
	public const short AlphabetStatue2 = 2704;

	[Cpp2IlInjected.Token(Token = "0x400467C")]
	public const short AlphabetStatue3 = 2705;

	[Cpp2IlInjected.Token(Token = "0x400467D")]
	public const short AlphabetStatue4 = 2706;

	[Cpp2IlInjected.Token(Token = "0x400467E")]
	public const short AlphabetStatue5 = 2707;

	[Cpp2IlInjected.Token(Token = "0x400467F")]
	public const short AlphabetStatue6 = 2708;

	[Cpp2IlInjected.Token(Token = "0x4004680")]
	public const short AlphabetStatue7 = 2709;

	[Cpp2IlInjected.Token(Token = "0x4004681")]
	public const short AlphabetStatue8 = 2710;

	[Cpp2IlInjected.Token(Token = "0x4004682")]
	public const short AlphabetStatue9 = 2711;

	[Cpp2IlInjected.Token(Token = "0x4004683")]
	public const short AlphabetStatueA = 2712;

	[Cpp2IlInjected.Token(Token = "0x4004684")]
	public const short AlphabetStatueB = 2713;

	[Cpp2IlInjected.Token(Token = "0x4004685")]
	public const short AlphabetStatueC = 2714;

	[Cpp2IlInjected.Token(Token = "0x4004686")]
	public const short AlphabetStatueD = 2715;

	[Cpp2IlInjected.Token(Token = "0x4004687")]
	public const short AlphabetStatueE = 2716;

	[Cpp2IlInjected.Token(Token = "0x4004688")]
	public const short AlphabetStatueF = 2717;

	[Cpp2IlInjected.Token(Token = "0x4004689")]
	public const short AlphabetStatueG = 2718;

	[Cpp2IlInjected.Token(Token = "0x400468A")]
	public const short AlphabetStatueH = 2719;

	[Cpp2IlInjected.Token(Token = "0x400468B")]
	public const short AlphabetStatueI = 2720;

	[Cpp2IlInjected.Token(Token = "0x400468C")]
	public const short AlphabetStatueJ = 2721;

	[Cpp2IlInjected.Token(Token = "0x400468D")]
	public const short AlphabetStatueK = 2722;

	[Cpp2IlInjected.Token(Token = "0x400468E")]
	public const short AlphabetStatueL = 2723;

	[Cpp2IlInjected.Token(Token = "0x400468F")]
	public const short AlphabetStatueM = 2724;

	[Cpp2IlInjected.Token(Token = "0x4004690")]
	public const short AlphabetStatueN = 2725;

	[Cpp2IlInjected.Token(Token = "0x4004691")]
	public const short AlphabetStatueO = 2726;

	[Cpp2IlInjected.Token(Token = "0x4004692")]
	public const short AlphabetStatueP = 2727;

	[Cpp2IlInjected.Token(Token = "0x4004693")]
	public const short AlphabetStatueQ = 2728;

	[Cpp2IlInjected.Token(Token = "0x4004694")]
	public const short AlphabetStatueR = 2729;

	[Cpp2IlInjected.Token(Token = "0x4004695")]
	public const short AlphabetStatueS = 2730;

	[Cpp2IlInjected.Token(Token = "0x4004696")]
	public const short AlphabetStatueT = 2731;

	[Cpp2IlInjected.Token(Token = "0x4004697")]
	public const short AlphabetStatueU = 2732;

	[Cpp2IlInjected.Token(Token = "0x4004698")]
	public const short AlphabetStatueV = 2733;

	[Cpp2IlInjected.Token(Token = "0x4004699")]
	public const short AlphabetStatueW = 2734;

	[Cpp2IlInjected.Token(Token = "0x400469A")]
	public const short AlphabetStatueX = 2735;

	[Cpp2IlInjected.Token(Token = "0x400469B")]
	public const short AlphabetStatueY = 2736;

	[Cpp2IlInjected.Token(Token = "0x400469C")]
	public const short AlphabetStatueZ = 2737;

	[Cpp2IlInjected.Token(Token = "0x400469D")]
	public const short FireworkFountain = 2738;

	[Cpp2IlInjected.Token(Token = "0x400469E")]
	public const short BoosterTrack = 2739;

	[Cpp2IlInjected.Token(Token = "0x400469F")]
	public const short Grasshopper = 2740;

	[Cpp2IlInjected.Token(Token = "0x40046A0")]
	public const short GrasshopperCage = 2741;

	[Cpp2IlInjected.Token(Token = "0x40046A1")]
	public const short MusicBoxUndergroundCrimson = 2742;

	[Cpp2IlInjected.Token(Token = "0x40046A2")]
	public const short CactusTable = 2743;

	[Cpp2IlInjected.Token(Token = "0x40046A3")]
	public const short CactusPlatform = 2744;

	[Cpp2IlInjected.Token(Token = "0x40046A4")]
	public const short BorealWoodSword = 2745;

	[Cpp2IlInjected.Token(Token = "0x40046A5")]
	public const short BorealWoodHammer = 2746;

	[Cpp2IlInjected.Token(Token = "0x40046A6")]
	public const short BorealWoodBow = 2747;

	[Cpp2IlInjected.Token(Token = "0x40046A7")]
	public const short GlassChest = 2748;

	[Cpp2IlInjected.Token(Token = "0x40046A8")]
	public const short XenoStaff = 2749;

	[Cpp2IlInjected.Token(Token = "0x40046A9")]
	public const short MeteorStaff = 2750;

	[Cpp2IlInjected.Token(Token = "0x40046AA")]
	public const short LivingCursedFireBlock = 2751;

	[Cpp2IlInjected.Token(Token = "0x40046AB")]
	public const short LivingDemonFireBlock = 2752;

	[Cpp2IlInjected.Token(Token = "0x40046AC")]
	public const short LivingFrostFireBlock = 2753;

	[Cpp2IlInjected.Token(Token = "0x40046AD")]
	public const short LivingIchorBlock = 2754;

	[Cpp2IlInjected.Token(Token = "0x40046AE")]
	public const short LivingUltrabrightFireBlock = 2755;

	[Cpp2IlInjected.Token(Token = "0x40046AF")]
	public const short GenderChangePotion = 2756;

	[Cpp2IlInjected.Token(Token = "0x40046B0")]
	public const short VortexHelmet = 2757;

	[Cpp2IlInjected.Token(Token = "0x40046B1")]
	public const short VortexBreastplate = 2758;

	[Cpp2IlInjected.Token(Token = "0x40046B2")]
	public const short VortexLeggings = 2759;

	[Cpp2IlInjected.Token(Token = "0x40046B3")]
	public const short NebulaHelmet = 2760;

	[Cpp2IlInjected.Token(Token = "0x40046B4")]
	public const short NebulaBreastplate = 2761;

	[Cpp2IlInjected.Token(Token = "0x40046B5")]
	public const short NebulaLeggings = 2762;

	[Cpp2IlInjected.Token(Token = "0x40046B6")]
	public const short SolarFlareHelmet = 2763;

	[Cpp2IlInjected.Token(Token = "0x40046B7")]
	public const short SolarFlareBreastplate = 2764;

	[Cpp2IlInjected.Token(Token = "0x40046B8")]
	public const short SolarFlareLeggings = 2765;

	[Cpp2IlInjected.Token(Token = "0x40046B9")]
	public const short LunarTabletFragment = 2766;

	[Cpp2IlInjected.Token(Token = "0x40046BA")]
	public const short SolarTablet = 2767;

	[Cpp2IlInjected.Token(Token = "0x40046BB")]
	public const short DrillContainmentUnit = 2768;

	[Cpp2IlInjected.Token(Token = "0x40046BC")]
	public const short CosmicCarKey = 2769;

	[Cpp2IlInjected.Token(Token = "0x40046BD")]
	public const short MothronWings = 2770;

	[Cpp2IlInjected.Token(Token = "0x40046BE")]
	public const short BrainScrambler = 2771;

	[Cpp2IlInjected.Token(Token = "0x40046BF")]
	public const short VortexAxe = 2772;

	[Cpp2IlInjected.Token(Token = "0x40046C0")]
	public const short VortexChainsaw = 2773;

	[Cpp2IlInjected.Token(Token = "0x40046C1")]
	public const short VortexDrill = 2774;

	[Cpp2IlInjected.Token(Token = "0x40046C2")]
	public const short VortexHammer = 2775;

	[Cpp2IlInjected.Token(Token = "0x40046C3")]
	public const short VortexPickaxe = 2776;

	[Cpp2IlInjected.Token(Token = "0x40046C4")]
	public const short NebulaAxe = 2777;

	[Cpp2IlInjected.Token(Token = "0x40046C5")]
	public const short NebulaChainsaw = 2778;

	[Cpp2IlInjected.Token(Token = "0x40046C6")]
	public const short NebulaDrill = 2779;

	[Cpp2IlInjected.Token(Token = "0x40046C7")]
	public const short NebulaHammer = 2780;

	[Cpp2IlInjected.Token(Token = "0x40046C8")]
	public const short NebulaPickaxe = 2781;

	[Cpp2IlInjected.Token(Token = "0x40046C9")]
	public const short SolarFlareAxe = 2782;

	[Cpp2IlInjected.Token(Token = "0x40046CA")]
	public const short SolarFlareChainsaw = 2783;

	[Cpp2IlInjected.Token(Token = "0x40046CB")]
	public const short SolarFlareDrill = 2784;

	[Cpp2IlInjected.Token(Token = "0x40046CC")]
	public const short SolarFlareHammer = 2785;

	[Cpp2IlInjected.Token(Token = "0x40046CD")]
	public const short SolarFlarePickaxe = 2786;

	[Cpp2IlInjected.Token(Token = "0x40046CE")]
	public const short HoneyfallBlock = 2787;

	[Cpp2IlInjected.Token(Token = "0x40046CF")]
	public const short HoneyfallWall = 2788;

	[Cpp2IlInjected.Token(Token = "0x40046D0")]
	public const short ChlorophyteBrickWall = 2789;

	[Cpp2IlInjected.Token(Token = "0x40046D1")]
	public const short CrimtaneBrickWall = 2790;

	[Cpp2IlInjected.Token(Token = "0x40046D2")]
	public const short ShroomitePlatingWall = 2791;

	[Cpp2IlInjected.Token(Token = "0x40046D3")]
	public const short ChlorophyteBrick = 2792;

	[Cpp2IlInjected.Token(Token = "0x40046D4")]
	public const short CrimtaneBrick = 2793;

	[Cpp2IlInjected.Token(Token = "0x40046D5")]
	public const short ShroomitePlating = 2794;

	[Cpp2IlInjected.Token(Token = "0x40046D6")]
	public const short LaserMachinegun = 2795;

	[Cpp2IlInjected.Token(Token = "0x40046D7")]
	public const short ElectrosphereLauncher = 2796;

	[Cpp2IlInjected.Token(Token = "0x40046D8")]
	public const short Xenopopper = 2797;

	[Cpp2IlInjected.Token(Token = "0x40046D9")]
	public const short LaserDrill = 2798;

	[Cpp2IlInjected.Token(Token = "0x40046DA")]
	public const short LaserRuler = 2799;

	[Cpp2IlInjected.Token(Token = "0x40046DB")]
	public const short AntiGravityHook = 2800;

	[Cpp2IlInjected.Token(Token = "0x40046DC")]
	public const short MoonMask = 2801;

	[Cpp2IlInjected.Token(Token = "0x40046DD")]
	public const short SunMask = 2802;

	[Cpp2IlInjected.Token(Token = "0x40046DE")]
	public const short MartianCostumeMask = 2803;

	[Cpp2IlInjected.Token(Token = "0x40046DF")]
	public const short MartianCostumeShirt = 2804;

	[Cpp2IlInjected.Token(Token = "0x40046E0")]
	public const short MartianCostumePants = 2805;

	[Cpp2IlInjected.Token(Token = "0x40046E1")]
	public const short MartianUniformHelmet = 2806;

	[Cpp2IlInjected.Token(Token = "0x40046E2")]
	public const short MartianUniformTorso = 2807;

	[Cpp2IlInjected.Token(Token = "0x40046E3")]
	public const short MartianUniformPants = 2808;

	[Cpp2IlInjected.Token(Token = "0x40046E4")]
	public const short MartianAstroClock = 2809;

	[Cpp2IlInjected.Token(Token = "0x40046E5")]
	public const short MartianBathtub = 2810;

	[Cpp2IlInjected.Token(Token = "0x40046E6")]
	public const short MartianBed = 2811;

	[Cpp2IlInjected.Token(Token = "0x40046E7")]
	public const short MartianHoverChair = 2812;

	[Cpp2IlInjected.Token(Token = "0x40046E8")]
	public const short MartianChandelier = 2813;

	[Cpp2IlInjected.Token(Token = "0x40046E9")]
	public const short MartianChest = 2814;

	[Cpp2IlInjected.Token(Token = "0x40046EA")]
	public const short MartianDoor = 2815;

	[Cpp2IlInjected.Token(Token = "0x40046EB")]
	public const short MartianDresser = 2816;

	[Cpp2IlInjected.Token(Token = "0x40046EC")]
	public const short MartianHolobookcase = 2817;

	[Cpp2IlInjected.Token(Token = "0x40046ED")]
	public const short MartianHoverCandle = 2818;

	[Cpp2IlInjected.Token(Token = "0x40046EE")]
	public const short MartianLamppost = 2819;

	[Cpp2IlInjected.Token(Token = "0x40046EF")]
	public const short MartianLantern = 2820;

	[Cpp2IlInjected.Token(Token = "0x40046F0")]
	public const short MartianPiano = 2821;

	[Cpp2IlInjected.Token(Token = "0x40046F1")]
	public const short MartianPlatform = 2822;

	[Cpp2IlInjected.Token(Token = "0x40046F2")]
	public const short MartianSofa = 2823;

	[Cpp2IlInjected.Token(Token = "0x40046F3")]
	public const short MartianTable = 2824;

	[Cpp2IlInjected.Token(Token = "0x40046F4")]
	public const short MartianTableLamp = 2825;

	[Cpp2IlInjected.Token(Token = "0x40046F5")]
	public const short MartianWorkBench = 2826;

	[Cpp2IlInjected.Token(Token = "0x40046F6")]
	public const short WoodenSink = 2827;

	[Cpp2IlInjected.Token(Token = "0x40046F7")]
	public const short EbonwoodSink = 2828;

	[Cpp2IlInjected.Token(Token = "0x40046F8")]
	public const short RichMahoganySink = 2829;

	[Cpp2IlInjected.Token(Token = "0x40046F9")]
	public const short PearlwoodSink = 2830;

	[Cpp2IlInjected.Token(Token = "0x40046FA")]
	public const short BoneSink = 2831;

	[Cpp2IlInjected.Token(Token = "0x40046FB")]
	public const short FleshSink = 2832;

	[Cpp2IlInjected.Token(Token = "0x40046FC")]
	public const short LivingWoodSink = 2833;

	[Cpp2IlInjected.Token(Token = "0x40046FD")]
	public const short SkywareSink = 2834;

	[Cpp2IlInjected.Token(Token = "0x40046FE")]
	public const short ShadewoodSink = 2835;

	[Cpp2IlInjected.Token(Token = "0x40046FF")]
	public const short LihzahrdSink = 2836;

	[Cpp2IlInjected.Token(Token = "0x4004700")]
	public const short BlueDungeonSink = 2837;

	[Cpp2IlInjected.Token(Token = "0x4004701")]
	public const short GreenDungeonSink = 2838;

	[Cpp2IlInjected.Token(Token = "0x4004702")]
	public const short PinkDungeonSink = 2839;

	[Cpp2IlInjected.Token(Token = "0x4004703")]
	public const short ObsidianSink = 2840;

	[Cpp2IlInjected.Token(Token = "0x4004704")]
	public const short MetalSink = 2841;

	[Cpp2IlInjected.Token(Token = "0x4004705")]
	public const short GlassSink = 2842;

	[Cpp2IlInjected.Token(Token = "0x4004706")]
	public const short GoldenSink = 2843;

	[Cpp2IlInjected.Token(Token = "0x4004707")]
	public const short HoneySink = 2844;

	[Cpp2IlInjected.Token(Token = "0x4004708")]
	public const short SteampunkSink = 2845;

	[Cpp2IlInjected.Token(Token = "0x4004709")]
	public const short PumpkinSink = 2846;

	[Cpp2IlInjected.Token(Token = "0x400470A")]
	public const short SpookySink = 2847;

	[Cpp2IlInjected.Token(Token = "0x400470B")]
	public const short FrozenSink = 2848;

	[Cpp2IlInjected.Token(Token = "0x400470C")]
	public const short DynastySink = 2849;

	[Cpp2IlInjected.Token(Token = "0x400470D")]
	public const short PalmWoodSink = 2850;

	[Cpp2IlInjected.Token(Token = "0x400470E")]
	public const short MushroomSink = 2851;

	[Cpp2IlInjected.Token(Token = "0x400470F")]
	public const short BorealWoodSink = 2852;

	[Cpp2IlInjected.Token(Token = "0x4004710")]
	public const short SlimeSink = 2853;

	[Cpp2IlInjected.Token(Token = "0x4004711")]
	public const short CactusSink = 2854;

	[Cpp2IlInjected.Token(Token = "0x4004712")]
	public const short MartianSink = 2855;

	[Cpp2IlInjected.Token(Token = "0x4004713")]
	public const short WhiteLunaticHood = 2856;

	[Cpp2IlInjected.Token(Token = "0x4004714")]
	public const short BlueLunaticHood = 2857;

	[Cpp2IlInjected.Token(Token = "0x4004715")]
	public const short WhiteLunaticRobe = 2858;

	[Cpp2IlInjected.Token(Token = "0x4004716")]
	public const short BlueLunaticRobe = 2859;

	[Cpp2IlInjected.Token(Token = "0x4004717")]
	public const short MartianConduitPlating = 2860;

	[Cpp2IlInjected.Token(Token = "0x4004718")]
	public const short MartianConduitWall = 2861;

	[Cpp2IlInjected.Token(Token = "0x4004719")]
	public const short HiTekSunglasses = 2862;

	[Cpp2IlInjected.Token(Token = "0x400471A")]
	public const short MartianHairDye = 2863;

	[Cpp2IlInjected.Token(Token = "0x400471B")]
	public const short MartianArmorDye = 2864;

	[Cpp2IlInjected.Token(Token = "0x400471C")]
	public const short PaintingCastleMarsberg = 2865;

	[Cpp2IlInjected.Token(Token = "0x400471D")]
	public const short PaintingMartiaLisa = 2866;

	[Cpp2IlInjected.Token(Token = "0x400471E")]
	public const short PaintingTheTruthIsUpThere = 2867;

	[Cpp2IlInjected.Token(Token = "0x400471F")]
	public const short SmokeBlock = 2868;

	[Cpp2IlInjected.Token(Token = "0x4004720")]
	public const short LivingFlameDye = 2869;

	[Cpp2IlInjected.Token(Token = "0x4004721")]
	public const short LivingRainbowDye = 2870;

	[Cpp2IlInjected.Token(Token = "0x4004722")]
	public const short ShadowDye = 2871;

	[Cpp2IlInjected.Token(Token = "0x4004723")]
	public const short NegativeDye = 2872;

	[Cpp2IlInjected.Token(Token = "0x4004724")]
	public const short LivingOceanDye = 2873;

	[Cpp2IlInjected.Token(Token = "0x4004725")]
	public const short BrownDye = 2874;

	[Cpp2IlInjected.Token(Token = "0x4004726")]
	public const short BrownAndBlackDye = 2875;

	[Cpp2IlInjected.Token(Token = "0x4004727")]
	public const short BrightBrownDye = 2876;

	[Cpp2IlInjected.Token(Token = "0x4004728")]
	public const short BrownAndSilverDye = 2877;

	[Cpp2IlInjected.Token(Token = "0x4004729")]
	public const short WispDye = 2878;

	[Cpp2IlInjected.Token(Token = "0x400472A")]
	public const short PixieDye = 2879;

	[Cpp2IlInjected.Token(Token = "0x400472B")]
	public const short InfluxWaver = 2880;

	[Cpp2IlInjected.Token(Token = "0x400472C")]
	public const short PhasicWarpEjector = 2881;

	[Cpp2IlInjected.Token(Token = "0x400472D")]
	public const short ChargedBlasterCannon = 2882;

	[Cpp2IlInjected.Token(Token = "0x400472E")]
	public const short ChlorophyteDye = 2883;

	[Cpp2IlInjected.Token(Token = "0x400472F")]
	public const short UnicornWispDye = 2884;

	[Cpp2IlInjected.Token(Token = "0x4004730")]
	public const short InfernalWispDye = 2885;

	[Cpp2IlInjected.Token(Token = "0x4004731")]
	public const short ViciousPowder = 2886;

	[Cpp2IlInjected.Token(Token = "0x4004732")]
	public const short ViciousMushroom = 2887;

	[Cpp2IlInjected.Token(Token = "0x4004733")]
	public const short BeesKnees = 2888;

	[Cpp2IlInjected.Token(Token = "0x4004734")]
	public const short GoldBird = 2889;

	[Cpp2IlInjected.Token(Token = "0x4004735")]
	public const short GoldBunny = 2890;

	[Cpp2IlInjected.Token(Token = "0x4004736")]
	public const short GoldButterfly = 2891;

	[Cpp2IlInjected.Token(Token = "0x4004737")]
	public const short GoldFrog = 2892;

	[Cpp2IlInjected.Token(Token = "0x4004738")]
	public const short GoldGrasshopper = 2893;

	[Cpp2IlInjected.Token(Token = "0x4004739")]
	public const short GoldMouse = 2894;

	[Cpp2IlInjected.Token(Token = "0x400473A")]
	public const short GoldWorm = 2895;

	[Cpp2IlInjected.Token(Token = "0x400473B")]
	public const short StickyDynamite = 2896;

	[Cpp2IlInjected.Token(Token = "0x400473C")]
	public const short AngryTrapperBanner = 2897;

	[Cpp2IlInjected.Token(Token = "0x400473D")]
	public const short ArmoredVikingBanner = 2898;

	[Cpp2IlInjected.Token(Token = "0x400473E")]
	public const short BlackSlimeBanner = 2899;

	[Cpp2IlInjected.Token(Token = "0x400473F")]
	public const short BlueArmoredBonesBanner = 2900;

	[Cpp2IlInjected.Token(Token = "0x4004740")]
	public const short BlueCultistArcherBanner = 2901;

	[Cpp2IlInjected.Token(Token = "0x4004741")]
	public const short BlueCultistCasterBanner = 2902;

	[Cpp2IlInjected.Token(Token = "0x4004742")]
	public const short BlueCultistFighterBanner = 2903;

	[Cpp2IlInjected.Token(Token = "0x4004743")]
	public const short BoneLeeBanner = 2904;

	[Cpp2IlInjected.Token(Token = "0x4004744")]
	public const short ClingerBanner = 2905;

	[Cpp2IlInjected.Token(Token = "0x4004745")]
	public const short CochinealBeetleBanner = 2906;

	[Cpp2IlInjected.Token(Token = "0x4004746")]
	public const short CorruptPenguinBanner = 2907;

	[Cpp2IlInjected.Token(Token = "0x4004747")]
	public const short CorruptSlimeBanner = 2908;

	[Cpp2IlInjected.Token(Token = "0x4004748")]
	public const short CorruptorBanner = 2909;

	[Cpp2IlInjected.Token(Token = "0x4004749")]
	public const short CrimslimeBanner = 2910;

	[Cpp2IlInjected.Token(Token = "0x400474A")]
	public const short CursedSkullBanner = 2911;

	[Cpp2IlInjected.Token(Token = "0x400474B")]
	public const short CyanBeetleBanner = 2912;

	[Cpp2IlInjected.Token(Token = "0x400474C")]
	public const short DevourerBanner = 2913;

	[Cpp2IlInjected.Token(Token = "0x400474D")]
	public const short DiablolistBanner = 2914;

	[Cpp2IlInjected.Token(Token = "0x400474E")]
	public const short DoctorBonesBanner = 2915;

	[Cpp2IlInjected.Token(Token = "0x400474F")]
	public const short DungeonSlimeBanner = 2916;

	[Cpp2IlInjected.Token(Token = "0x4004750")]
	public const short DungeonSpiritBanner = 2917;

	[Cpp2IlInjected.Token(Token = "0x4004751")]
	public const short ElfArcherBanner = 2918;

	[Cpp2IlInjected.Token(Token = "0x4004752")]
	public const short ElfCopterBanner = 2919;

	[Cpp2IlInjected.Token(Token = "0x4004753")]
	public const short EyezorBanner = 2920;

	[Cpp2IlInjected.Token(Token = "0x4004754")]
	public const short FlockoBanner = 2921;

	[Cpp2IlInjected.Token(Token = "0x4004755")]
	public const short GhostBanner = 2922;

	[Cpp2IlInjected.Token(Token = "0x4004756")]
	public const short GiantBatBanner = 2923;

	[Cpp2IlInjected.Token(Token = "0x4004757")]
	public const short GiantCursedSkullBanner = 2924;

	[Cpp2IlInjected.Token(Token = "0x4004758")]
	public const short GiantFlyingFoxBanner = 2925;

	[Cpp2IlInjected.Token(Token = "0x4004759")]
	public const short GingerbreadManBanner = 2926;

	[Cpp2IlInjected.Token(Token = "0x400475A")]
	public const short GoblinArcherBanner = 2927;

	[Cpp2IlInjected.Token(Token = "0x400475B")]
	public const short GreenSlimeBanner = 2928;

	[Cpp2IlInjected.Token(Token = "0x400475C")]
	public const short HeadlessHorsemanBanner = 2929;

	[Cpp2IlInjected.Token(Token = "0x400475D")]
	public const short HellArmoredBonesBanner = 2930;

	[Cpp2IlInjected.Token(Token = "0x400475E")]
	public const short HellhoundBanner = 2931;

	[Cpp2IlInjected.Token(Token = "0x400475F")]
	public const short HoppinJackBanner = 2932;

	[Cpp2IlInjected.Token(Token = "0x4004760")]
	public const short IceBatBanner = 2933;

	[Cpp2IlInjected.Token(Token = "0x4004761")]
	public const short IceGolemBanner = 2934;

	[Cpp2IlInjected.Token(Token = "0x4004762")]
	public const short IceSlimeBanner = 2935;

	[Cpp2IlInjected.Token(Token = "0x4004763")]
	public const short IchorStickerBanner = 2936;

	[Cpp2IlInjected.Token(Token = "0x4004764")]
	public const short IlluminantBatBanner = 2937;

	[Cpp2IlInjected.Token(Token = "0x4004765")]
	public const short IlluminantSlimeBanner = 2938;

	[Cpp2IlInjected.Token(Token = "0x4004766")]
	public const short JungleBatBanner = 2939;

	[Cpp2IlInjected.Token(Token = "0x4004767")]
	public const short JungleSlimeBanner = 2940;

	[Cpp2IlInjected.Token(Token = "0x4004768")]
	public const short KrampusBanner = 2941;

	[Cpp2IlInjected.Token(Token = "0x4004769")]
	public const short LacBeetleBanner = 2942;

	[Cpp2IlInjected.Token(Token = "0x400476A")]
	public const short LavaBatBanner = 2943;

	[Cpp2IlInjected.Token(Token = "0x400476B")]
	public const short LavaSlimeBanner = 2944;

	[Cpp2IlInjected.Token(Token = "0x400476C")]
	public const short MartianBrainscramblerBanner = 2945;

	[Cpp2IlInjected.Token(Token = "0x400476D")]
	public const short MartianDroneBanner = 2946;

	[Cpp2IlInjected.Token(Token = "0x400476E")]
	public const short MartianEngineerBanner = 2947;

	[Cpp2IlInjected.Token(Token = "0x400476F")]
	public const short MartianGigazapperBanner = 2948;

	[Cpp2IlInjected.Token(Token = "0x4004770")]
	public const short MartianGreyGruntBanner = 2949;

	[Cpp2IlInjected.Token(Token = "0x4004771")]
	public const short MartianOfficerBanner = 2950;

	[Cpp2IlInjected.Token(Token = "0x4004772")]
	public const short MartianRaygunnerBanner = 2951;

	[Cpp2IlInjected.Token(Token = "0x4004773")]
	public const short MartianScutlixGunnerBanner = 2952;

	[Cpp2IlInjected.Token(Token = "0x4004774")]
	public const short MartianTeslaTurretBanner = 2953;

	[Cpp2IlInjected.Token(Token = "0x4004775")]
	public const short MisterStabbyBanner = 2954;

	[Cpp2IlInjected.Token(Token = "0x4004776")]
	public const short MotherSlimeBanner = 2955;

	[Cpp2IlInjected.Token(Token = "0x4004777")]
	public const short NecromancerBanner = 2956;

	[Cpp2IlInjected.Token(Token = "0x4004778")]
	public const short NutcrackerBanner = 2957;

	[Cpp2IlInjected.Token(Token = "0x4004779")]
	public const short PaladinBanner = 2958;

	[Cpp2IlInjected.Token(Token = "0x400477A")]
	public const short PenguinBanner = 2959;

	[Cpp2IlInjected.Token(Token = "0x400477B")]
	public const short PinkyBanner = 2960;

	[Cpp2IlInjected.Token(Token = "0x400477C")]
	public const short PoltergeistBanner = 2961;

	[Cpp2IlInjected.Token(Token = "0x400477D")]
	public const short PossessedArmorBanner = 2962;

	[Cpp2IlInjected.Token(Token = "0x400477E")]
	public const short PresentMimicBanner = 2963;

	[Cpp2IlInjected.Token(Token = "0x400477F")]
	public const short PurpleSlimeBanner = 2964;

	[Cpp2IlInjected.Token(Token = "0x4004780")]
	public const short RaggedCasterBanner = 2965;

	[Cpp2IlInjected.Token(Token = "0x4004781")]
	public const short RainbowSlimeBanner = 2966;

	[Cpp2IlInjected.Token(Token = "0x4004782")]
	public const short RavenBanner = 2967;

	[Cpp2IlInjected.Token(Token = "0x4004783")]
	public const short RedSlimeBanner = 2968;

	[Cpp2IlInjected.Token(Token = "0x4004784")]
	public const short RuneWizardBanner = 2969;

	[Cpp2IlInjected.Token(Token = "0x4004785")]
	public const short RustyArmoredBonesBanner = 2970;

	[Cpp2IlInjected.Token(Token = "0x4004786")]
	public const short ScarecrowBanner = 2971;

	[Cpp2IlInjected.Token(Token = "0x4004787")]
	public const short ScutlixBanner = 2972;

	[Cpp2IlInjected.Token(Token = "0x4004788")]
	public const short SkeletonArcherBanner = 2973;

	[Cpp2IlInjected.Token(Token = "0x4004789")]
	public const short SkeletonCommandoBanner = 2974;

	[Cpp2IlInjected.Token(Token = "0x400478A")]
	public const short SkeletonSniperBanner = 2975;

	[Cpp2IlInjected.Token(Token = "0x400478B")]
	public const short SlimerBanner = 2976;

	[Cpp2IlInjected.Token(Token = "0x400478C")]
	public const short SnatcherBanner = 2977;

	[Cpp2IlInjected.Token(Token = "0x400478D")]
	public const short SnowBallaBanner = 2978;

	[Cpp2IlInjected.Token(Token = "0x400478E")]
	public const short SnowmanGangstaBanner = 2979;

	[Cpp2IlInjected.Token(Token = "0x400478F")]
	public const short SpikedIceSlimeBanner = 2980;

	[Cpp2IlInjected.Token(Token = "0x4004790")]
	public const short SpikedJungleSlimeBanner = 2981;

	[Cpp2IlInjected.Token(Token = "0x4004791")]
	public const short SplinterlingBanner = 2982;

	[Cpp2IlInjected.Token(Token = "0x4004792")]
	public const short SquidBanner = 2983;

	[Cpp2IlInjected.Token(Token = "0x4004793")]
	public const short TacticalSkeletonBanner = 2984;

	[Cpp2IlInjected.Token(Token = "0x4004794")]
	public const short TheGroomBanner = 2985;

	[Cpp2IlInjected.Token(Token = "0x4004795")]
	public const short TimBanner = 2986;

	[Cpp2IlInjected.Token(Token = "0x4004796")]
	public const short UndeadMinerBanner = 2987;

	[Cpp2IlInjected.Token(Token = "0x4004797")]
	public const short UndeadVikingBanner = 2988;

	[Cpp2IlInjected.Token(Token = "0x4004798")]
	public const short WhiteCultistArcherBanner = 2989;

	[Cpp2IlInjected.Token(Token = "0x4004799")]
	public const short WhiteCultistCasterBanner = 2990;

	[Cpp2IlInjected.Token(Token = "0x400479A")]
	public const short WhiteCultistFighterBanner = 2991;

	[Cpp2IlInjected.Token(Token = "0x400479B")]
	public const short YellowSlimeBanner = 2992;

	[Cpp2IlInjected.Token(Token = "0x400479C")]
	public const short YetiBanner = 2993;

	[Cpp2IlInjected.Token(Token = "0x400479D")]
	public const short ZombieElfBanner = 2994;

	[Cpp2IlInjected.Token(Token = "0x400479E")]
	public const short SparkyPainting = 2995;

	[Cpp2IlInjected.Token(Token = "0x400479F")]
	public const short VineRope = 2996;

	[Cpp2IlInjected.Token(Token = "0x40047A0")]
	public const short WormholePotion = 2997;

	[Cpp2IlInjected.Token(Token = "0x40047A1")]
	public const short SummonerEmblem = 2998;

	[Cpp2IlInjected.Token(Token = "0x40047A2")]
	public const short BewitchingTable = 2999;

	[Cpp2IlInjected.Token(Token = "0x40047A3")]
	public const short AlchemyTable = 3000;

	[Cpp2IlInjected.Token(Token = "0x40047A4")]
	public const short StrangeBrew = 3001;

	[Cpp2IlInjected.Token(Token = "0x40047A5")]
	public const short SpelunkerGlowstick = 3002;

	[Cpp2IlInjected.Token(Token = "0x40047A6")]
	public const short BoneArrow = 3003;

	[Cpp2IlInjected.Token(Token = "0x40047A7")]
	public const short BoneTorch = 3004;

	[Cpp2IlInjected.Token(Token = "0x40047A8")]
	public const short VineRopeCoil = 3005;

	[Cpp2IlInjected.Token(Token = "0x40047A9")]
	public const short SoulDrain = 3006;

	[Cpp2IlInjected.Token(Token = "0x40047AA")]
	public const short DartPistol = 3007;

	[Cpp2IlInjected.Token(Token = "0x40047AB")]
	public const short DartRifle = 3008;

	[Cpp2IlInjected.Token(Token = "0x40047AC")]
	public const short CrystalDart = 3009;

	[Cpp2IlInjected.Token(Token = "0x40047AD")]
	public const short CursedDart = 3010;

	[Cpp2IlInjected.Token(Token = "0x40047AE")]
	public const short IchorDart = 3011;

	[Cpp2IlInjected.Token(Token = "0x40047AF")]
	public const short ChainGuillotines = 3012;

	[Cpp2IlInjected.Token(Token = "0x40047B0")]
	public const short FetidBaghnakhs = 3013;

	[Cpp2IlInjected.Token(Token = "0x40047B1")]
	public const short ClingerStaff = 3014;

	[Cpp2IlInjected.Token(Token = "0x40047B2")]
	public const short PutridScent = 3015;

	[Cpp2IlInjected.Token(Token = "0x40047B3")]
	public const short FleshKnuckles = 3016;

	[Cpp2IlInjected.Token(Token = "0x40047B4")]
	public const short FlowerBoots = 3017;

	[Cpp2IlInjected.Token(Token = "0x40047B5")]
	public const short Seedler = 3018;

	[Cpp2IlInjected.Token(Token = "0x40047B6")]
	public const short HellwingBow = 3019;

	[Cpp2IlInjected.Token(Token = "0x40047B7")]
	public const short TendonHook = 3020;

	[Cpp2IlInjected.Token(Token = "0x40047B8")]
	public const short ThornHook = 3021;

	[Cpp2IlInjected.Token(Token = "0x40047B9")]
	public const short IlluminantHook = 3022;

	[Cpp2IlInjected.Token(Token = "0x40047BA")]
	public const short WormHook = 3023;

	[Cpp2IlInjected.Token(Token = "0x40047BB")]
	public const short DevDye = 3024;

	[Cpp2IlInjected.Token(Token = "0x40047BC")]
	public const short PurpleOozeDye = 3025;

	[Cpp2IlInjected.Token(Token = "0x40047BD")]
	public const short ReflectiveSilverDye = 3026;

	[Cpp2IlInjected.Token(Token = "0x40047BE")]
	public const short ReflectiveGoldDye = 3027;

	[Cpp2IlInjected.Token(Token = "0x40047BF")]
	public const short BlueAcidDye = 3028;

	[Cpp2IlInjected.Token(Token = "0x40047C0")]
	public const short DaedalusStormbow = 3029;

	[Cpp2IlInjected.Token(Token = "0x40047C1")]
	public const short FlyingKnife = 3030;

	[Cpp2IlInjected.Token(Token = "0x40047C2")]
	public const short BottomlessBucket = 3031;

	[Cpp2IlInjected.Token(Token = "0x40047C3")]
	public const short SuperAbsorbantSponge = 3032;

	[Cpp2IlInjected.Token(Token = "0x40047C4")]
	public const short GoldRing = 3033;

	[Cpp2IlInjected.Token(Token = "0x40047C5")]
	public const short CoinRing = 3034;

	[Cpp2IlInjected.Token(Token = "0x40047C6")]
	public const short GreedyRing = 3035;

	[Cpp2IlInjected.Token(Token = "0x40047C7")]
	public const short FishFinder = 3036;

	[Cpp2IlInjected.Token(Token = "0x40047C8")]
	public const short WeatherRadio = 3037;

	[Cpp2IlInjected.Token(Token = "0x40047C9")]
	public const short HadesDye = 3038;

	[Cpp2IlInjected.Token(Token = "0x40047CA")]
	public const short TwilightDye = 3039;

	[Cpp2IlInjected.Token(Token = "0x40047CB")]
	public const short AcidDye = 3040;

	[Cpp2IlInjected.Token(Token = "0x40047CC")]
	public const short MushroomDye = 3041;

	[Cpp2IlInjected.Token(Token = "0x40047CD")]
	public const short PhaseDye = 3042;

	[Cpp2IlInjected.Token(Token = "0x40047CE")]
	public const short MagicLantern = 3043;

	[Cpp2IlInjected.Token(Token = "0x40047CF")]
	public const short MusicBoxLunarBoss = 3044;

	[Cpp2IlInjected.Token(Token = "0x40047D0")]
	public const short RainbowTorch = 3045;

	[Cpp2IlInjected.Token(Token = "0x40047D1")]
	public const short CursedCampfire = 3046;

	[Cpp2IlInjected.Token(Token = "0x40047D2")]
	public const short DemonCampfire = 3047;

	[Cpp2IlInjected.Token(Token = "0x40047D3")]
	public const short FrozenCampfire = 3048;

	[Cpp2IlInjected.Token(Token = "0x40047D4")]
	public const short IchorCampfire = 3049;

	[Cpp2IlInjected.Token(Token = "0x40047D5")]
	public const short RainbowCampfire = 3050;

	[Cpp2IlInjected.Token(Token = "0x40047D6")]
	public const short CrystalVileShard = 3051;

	[Cpp2IlInjected.Token(Token = "0x40047D7")]
	public const short ShadowFlameBow = 3052;

	[Cpp2IlInjected.Token(Token = "0x40047D8")]
	public const short ShadowFlameHexDoll = 3053;

	[Cpp2IlInjected.Token(Token = "0x40047D9")]
	public const short ShadowFlameKnife = 3054;

	[Cpp2IlInjected.Token(Token = "0x40047DA")]
	public const short PaintingAcorns = 3055;

	[Cpp2IlInjected.Token(Token = "0x40047DB")]
	public const short PaintingColdSnap = 3056;

	[Cpp2IlInjected.Token(Token = "0x40047DC")]
	public const short PaintingCursedSaint = 3057;

	[Cpp2IlInjected.Token(Token = "0x40047DD")]
	public const short PaintingSnowfellas = 3058;

	[Cpp2IlInjected.Token(Token = "0x40047DE")]
	public const short PaintingTheSeason = 3059;

	[Cpp2IlInjected.Token(Token = "0x40047DF")]
	public const short BoneRattle = 3060;

	[Cpp2IlInjected.Token(Token = "0x40047E0")]
	public const short ArchitectGizmoPack = 3061;

	[Cpp2IlInjected.Token(Token = "0x40047E1")]
	public const short CrimsonHeart = 3062;

	[Cpp2IlInjected.Token(Token = "0x40047E2")]
	public const short Meowmere = 3063;

	[Cpp2IlInjected.Token(Token = "0x40047E3")]
	public const short Sundial = 3064;

	[Cpp2IlInjected.Token(Token = "0x40047E4")]
	public const short StarWrath = 3065;

	[Cpp2IlInjected.Token(Token = "0x40047E5")]
	public const short MarbleBlock = 3066;

	[Cpp2IlInjected.Token(Token = "0x40047E6")]
	public const short HellstoneBrickWall = 3067;

	[Cpp2IlInjected.Token(Token = "0x40047E7")]
	public const short CordageGuide = 3068;

	[Cpp2IlInjected.Token(Token = "0x40047E8")]
	public const short WandofSparking = 3069;

	[Cpp2IlInjected.Token(Token = "0x40047E9")]
	public const short GoldBirdCage = 3070;

	[Cpp2IlInjected.Token(Token = "0x40047EA")]
	public const short GoldBunnyCage = 3071;

	[Cpp2IlInjected.Token(Token = "0x40047EB")]
	public const short GoldButterflyCage = 3072;

	[Cpp2IlInjected.Token(Token = "0x40047EC")]
	public const short GoldFrogCage = 3073;

	[Cpp2IlInjected.Token(Token = "0x40047ED")]
	public const short GoldGrasshopperCage = 3074;

	[Cpp2IlInjected.Token(Token = "0x40047EE")]
	public const short GoldMouseCage = 3075;

	[Cpp2IlInjected.Token(Token = "0x40047EF")]
	public const short GoldWormCage = 3076;

	[Cpp2IlInjected.Token(Token = "0x40047F0")]
	public const short SilkRope = 3077;

	[Cpp2IlInjected.Token(Token = "0x40047F1")]
	public const short WebRope = 3078;

	[Cpp2IlInjected.Token(Token = "0x40047F2")]
	public const short SilkRopeCoil = 3079;

	[Cpp2IlInjected.Token(Token = "0x40047F3")]
	public const short WebRopeCoil = 3080;

	[Cpp2IlInjected.Token(Token = "0x40047F4")]
	public const short Marble = 3081;

	[Cpp2IlInjected.Token(Token = "0x40047F5")]
	public const short MarbleWall = 3082;

	[Cpp2IlInjected.Token(Token = "0x40047F6")]
	public const short MarbleBlockWall = 3083;

	[Cpp2IlInjected.Token(Token = "0x40047F7")]
	public const short Radar = 3084;

	[Cpp2IlInjected.Token(Token = "0x40047F8")]
	public const short LockBox = 3085;

	[Cpp2IlInjected.Token(Token = "0x40047F9")]
	public const short Granite = 3086;

	[Cpp2IlInjected.Token(Token = "0x40047FA")]
	public const short GraniteBlock = 3087;

	[Cpp2IlInjected.Token(Token = "0x40047FB")]
	public const short GraniteWall = 3088;

	[Cpp2IlInjected.Token(Token = "0x40047FC")]
	public const short GraniteBlockWall = 3089;

	[Cpp2IlInjected.Token(Token = "0x40047FD")]
	public const short RoyalGel = 3090;

	[Cpp2IlInjected.Token(Token = "0x40047FE")]
	public const short NightKey = 3091;

	[Cpp2IlInjected.Token(Token = "0x40047FF")]
	public const short LightKey = 3092;

	[Cpp2IlInjected.Token(Token = "0x4004800")]
	public const short HerbBag = 3093;

	[Cpp2IlInjected.Token(Token = "0x4004801")]
	public const short Javelin = 3094;

	[Cpp2IlInjected.Token(Token = "0x4004802")]
	public const short TallyCounter = 3095;

	[Cpp2IlInjected.Token(Token = "0x4004803")]
	public const short Sextant = 3096;

	[Cpp2IlInjected.Token(Token = "0x4004804")]
	public const short EoCShield = 3097;

	[Cpp2IlInjected.Token(Token = "0x4004805")]
	public const short ButchersChainsaw = 3098;

	[Cpp2IlInjected.Token(Token = "0x4004806")]
	public const short Stopwatch = 3099;

	[Cpp2IlInjected.Token(Token = "0x4004807")]
	public const short MeteoriteBrick = 3100;

	[Cpp2IlInjected.Token(Token = "0x4004808")]
	public const short MeteoriteBrickWall = 3101;

	[Cpp2IlInjected.Token(Token = "0x4004809")]
	public const short MetalDetector = 3102;

	[Cpp2IlInjected.Token(Token = "0x400480A")]
	public const short EndlessQuiver = 3103;

	[Cpp2IlInjected.Token(Token = "0x400480B")]
	public const short EndlessMusketPouch = 3104;

	[Cpp2IlInjected.Token(Token = "0x400480C")]
	public const short ToxicFlask = 3105;

	[Cpp2IlInjected.Token(Token = "0x400480D")]
	public const short PsychoKnife = 3106;

	[Cpp2IlInjected.Token(Token = "0x400480E")]
	public const short NailGun = 3107;

	[Cpp2IlInjected.Token(Token = "0x400480F")]
	public const short Nail = 3108;

	[Cpp2IlInjected.Token(Token = "0x4004810")]
	public const short NightVisionHelmet = 3109;

	[Cpp2IlInjected.Token(Token = "0x4004811")]
	public const short CelestialShell = 3110;

	[Cpp2IlInjected.Token(Token = "0x4004812")]
	public const short PinkGel = 3111;

	[Cpp2IlInjected.Token(Token = "0x4004813")]
	public const short BouncyGlowstick = 3112;

	[Cpp2IlInjected.Token(Token = "0x4004814")]
	public const short PinkSlimeBlock = 3113;

	[Cpp2IlInjected.Token(Token = "0x4004815")]
	public const short PinkTorch = 3114;

	[Cpp2IlInjected.Token(Token = "0x4004816")]
	public const short BouncyBomb = 3115;

	[Cpp2IlInjected.Token(Token = "0x4004817")]
	public const short BouncyGrenade = 3116;

	[Cpp2IlInjected.Token(Token = "0x4004818")]
	public const short PeaceCandle = 3117;

	[Cpp2IlInjected.Token(Token = "0x4004819")]
	public const short LifeformAnalyzer = 3118;

	[Cpp2IlInjected.Token(Token = "0x400481A")]
	public const short DPSMeter = 3119;

	[Cpp2IlInjected.Token(Token = "0x400481B")]
	public const short FishermansGuide = 3120;

	[Cpp2IlInjected.Token(Token = "0x400481C")]
	public const short GoblinTech = 3121;

	[Cpp2IlInjected.Token(Token = "0x400481D")]
	public const short REK = 3122;

	[Cpp2IlInjected.Token(Token = "0x400481E")]
	public const short PDA = 3123;

	[Cpp2IlInjected.Token(Token = "0x400481F")]
	public const short CellPhone = 3124;

	[Cpp2IlInjected.Token(Token = "0x4004820")]
	public const short GraniteChest = 3125;

	[Cpp2IlInjected.Token(Token = "0x4004821")]
	public const short MeteoriteClock = 3126;

	[Cpp2IlInjected.Token(Token = "0x4004822")]
	public const short MarbleClock = 3127;

	[Cpp2IlInjected.Token(Token = "0x4004823")]
	public const short GraniteClock = 3128;

	[Cpp2IlInjected.Token(Token = "0x4004824")]
	public const short MeteoriteDoor = 3129;

	[Cpp2IlInjected.Token(Token = "0x4004825")]
	public const short MarbleDoor = 3130;

	[Cpp2IlInjected.Token(Token = "0x4004826")]
	public const short GraniteDoor = 3131;

	[Cpp2IlInjected.Token(Token = "0x4004827")]
	public const short MeteoriteDresser = 3132;

	[Cpp2IlInjected.Token(Token = "0x4004828")]
	public const short MarbleDresser = 3133;

	[Cpp2IlInjected.Token(Token = "0x4004829")]
	public const short GraniteDresser = 3134;

	[Cpp2IlInjected.Token(Token = "0x400482A")]
	public const short MeteoriteLamp = 3135;

	[Cpp2IlInjected.Token(Token = "0x400482B")]
	public const short MarbleLamp = 3136;

	[Cpp2IlInjected.Token(Token = "0x400482C")]
	public const short GraniteLamp = 3137;

	[Cpp2IlInjected.Token(Token = "0x400482D")]
	public const short MeteoriteLantern = 3138;

	[Cpp2IlInjected.Token(Token = "0x400482E")]
	public const short MarbleLantern = 3139;

	[Cpp2IlInjected.Token(Token = "0x400482F")]
	public const short GraniteLantern = 3140;

	[Cpp2IlInjected.Token(Token = "0x4004830")]
	public const short MeteoritePiano = 3141;

	[Cpp2IlInjected.Token(Token = "0x4004831")]
	public const short MarblePiano = 3142;

	[Cpp2IlInjected.Token(Token = "0x4004832")]
	public const short GranitePiano = 3143;

	[Cpp2IlInjected.Token(Token = "0x4004833")]
	public const short MeteoritePlatform = 3144;

	[Cpp2IlInjected.Token(Token = "0x4004834")]
	public const short MarblePlatform = 3145;

	[Cpp2IlInjected.Token(Token = "0x4004835")]
	public const short GranitePlatform = 3146;

	[Cpp2IlInjected.Token(Token = "0x4004836")]
	public const short MeteoriteSink = 3147;

	[Cpp2IlInjected.Token(Token = "0x4004837")]
	public const short MarbleSink = 3148;

	[Cpp2IlInjected.Token(Token = "0x4004838")]
	public const short GraniteSink = 3149;

	[Cpp2IlInjected.Token(Token = "0x4004839")]
	public const short MeteoriteSofa = 3150;

	[Cpp2IlInjected.Token(Token = "0x400483A")]
	public const short MarbleSofa = 3151;

	[Cpp2IlInjected.Token(Token = "0x400483B")]
	public const short GraniteSofa = 3152;

	[Cpp2IlInjected.Token(Token = "0x400483C")]
	public const short MeteoriteTable = 3153;

	[Cpp2IlInjected.Token(Token = "0x400483D")]
	public const short MarbleTable = 3154;

	[Cpp2IlInjected.Token(Token = "0x400483E")]
	public const short GraniteTable = 3155;

	[Cpp2IlInjected.Token(Token = "0x400483F")]
	public const short MeteoriteWorkBench = 3156;

	[Cpp2IlInjected.Token(Token = "0x4004840")]
	public const short MarbleWorkBench = 3157;

	[Cpp2IlInjected.Token(Token = "0x4004841")]
	public const short GraniteWorkBench = 3158;

	[Cpp2IlInjected.Token(Token = "0x4004842")]
	public const short MeteoriteBathtub = 3159;

	[Cpp2IlInjected.Token(Token = "0x4004843")]
	public const short MarbleBathtub = 3160;

	[Cpp2IlInjected.Token(Token = "0x4004844")]
	public const short GraniteBathtub = 3161;

	[Cpp2IlInjected.Token(Token = "0x4004845")]
	public const short MeteoriteBed = 3162;

	[Cpp2IlInjected.Token(Token = "0x4004846")]
	public const short MarbleBed = 3163;

	[Cpp2IlInjected.Token(Token = "0x4004847")]
	public const short GraniteBed = 3164;

	[Cpp2IlInjected.Token(Token = "0x4004848")]
	public const short MeteoriteBookcase = 3165;

	[Cpp2IlInjected.Token(Token = "0x4004849")]
	public const short MarbleBookcase = 3166;

	[Cpp2IlInjected.Token(Token = "0x400484A")]
	public const short GraniteBookcase = 3167;

	[Cpp2IlInjected.Token(Token = "0x400484B")]
	public const short MeteoriteCandelabra = 3168;

	[Cpp2IlInjected.Token(Token = "0x400484C")]
	public const short MarbleCandelabra = 3169;

	[Cpp2IlInjected.Token(Token = "0x400484D")]
	public const short GraniteCandelabra = 3170;

	[Cpp2IlInjected.Token(Token = "0x400484E")]
	public const short MeteoriteCandle = 3171;

	[Cpp2IlInjected.Token(Token = "0x400484F")]
	public const short MarbleCandle = 3172;

	[Cpp2IlInjected.Token(Token = "0x4004850")]
	public const short GraniteCandle = 3173;

	[Cpp2IlInjected.Token(Token = "0x4004851")]
	public const short MeteoriteChair = 3174;

	[Cpp2IlInjected.Token(Token = "0x4004852")]
	public const short MarbleChair = 3175;

	[Cpp2IlInjected.Token(Token = "0x4004853")]
	public const short GraniteChair = 3176;

	[Cpp2IlInjected.Token(Token = "0x4004854")]
	public const short MeteoriteChandelier = 3177;

	[Cpp2IlInjected.Token(Token = "0x4004855")]
	public const short MarbleChandelier = 3178;

	[Cpp2IlInjected.Token(Token = "0x4004856")]
	public const short GraniteChandelier = 3179;

	[Cpp2IlInjected.Token(Token = "0x4004857")]
	public const short MeteoriteChest = 3180;

	[Cpp2IlInjected.Token(Token = "0x4004858")]
	public const short MarbleChest = 3181;

	[Cpp2IlInjected.Token(Token = "0x4004859")]
	public const short MagicWaterDropper = 3182;

	[Cpp2IlInjected.Token(Token = "0x400485A")]
	public const short GoldenBugNet = 3183;

	[Cpp2IlInjected.Token(Token = "0x400485B")]
	public const short MagicLavaDropper = 3184;

	[Cpp2IlInjected.Token(Token = "0x400485C")]
	public const short MagicHoneyDropper = 3185;

	[Cpp2IlInjected.Token(Token = "0x400485D")]
	public const short EmptyDropper = 3186;

	[Cpp2IlInjected.Token(Token = "0x400485E")]
	public const short GladiatorHelmet = 3187;

	[Cpp2IlInjected.Token(Token = "0x400485F")]
	public const short GladiatorBreastplate = 3188;

	[Cpp2IlInjected.Token(Token = "0x4004860")]
	public const short GladiatorLeggings = 3189;

	[Cpp2IlInjected.Token(Token = "0x4004861")]
	public const short ReflectiveDye = 3190;

	[Cpp2IlInjected.Token(Token = "0x4004862")]
	public const short EnchantedNightcrawler = 3191;

	[Cpp2IlInjected.Token(Token = "0x4004863")]
	public const short Grubby = 3192;

	[Cpp2IlInjected.Token(Token = "0x4004864")]
	public const short Sluggy = 3193;

	[Cpp2IlInjected.Token(Token = "0x4004865")]
	public const short Buggy = 3194;

	[Cpp2IlInjected.Token(Token = "0x4004866")]
	public const short GrubSoup = 3195;

	[Cpp2IlInjected.Token(Token = "0x4004867")]
	public const short BombFish = 3196;

	[Cpp2IlInjected.Token(Token = "0x4004868")]
	public const short FrostDaggerfish = 3197;

	[Cpp2IlInjected.Token(Token = "0x4004869")]
	public const short SharpeningStation = 3198;

	[Cpp2IlInjected.Token(Token = "0x400486A")]
	public const short IceMirror = 3199;

	[Cpp2IlInjected.Token(Token = "0x400486B")]
	public const short SailfishBoots = 3200;

	[Cpp2IlInjected.Token(Token = "0x400486C")]
	public const short TsunamiInABottle = 3201;

	[Cpp2IlInjected.Token(Token = "0x400486D")]
	public const short TargetDummy = 3202;

	[Cpp2IlInjected.Token(Token = "0x400486E")]
	public const short CorruptFishingCrate = 3203;

	[Cpp2IlInjected.Token(Token = "0x400486F")]
	public const short CrimsonFishingCrate = 3204;

	[Cpp2IlInjected.Token(Token = "0x4004870")]
	public const short DungeonFishingCrate = 3205;

	[Cpp2IlInjected.Token(Token = "0x4004871")]
	public const short FloatingIslandFishingCrate = 3206;

	[Cpp2IlInjected.Token(Token = "0x4004872")]
	public const short HallowedFishingCrate = 3207;

	[Cpp2IlInjected.Token(Token = "0x4004873")]
	public const short JungleFishingCrate = 3208;

	[Cpp2IlInjected.Token(Token = "0x4004874")]
	public const short CrystalSerpent = 3209;

	[Cpp2IlInjected.Token(Token = "0x4004875")]
	public const short Toxikarp = 3210;

	[Cpp2IlInjected.Token(Token = "0x4004876")]
	public const short Bladetongue = 3211;

	[Cpp2IlInjected.Token(Token = "0x4004877")]
	public const short SharkToothNecklace = 3212;

	[Cpp2IlInjected.Token(Token = "0x4004878")]
	public const short MoneyTrough = 3213;

	[Cpp2IlInjected.Token(Token = "0x4004879")]
	public const short Bubble = 3214;

	[Cpp2IlInjected.Token(Token = "0x400487A")]
	public const short DayBloomPlanterBox = 3215;

	[Cpp2IlInjected.Token(Token = "0x400487B")]
	public const short MoonglowPlanterBox = 3216;

	[Cpp2IlInjected.Token(Token = "0x400487C")]
	public const short CorruptPlanterBox = 3217;

	[Cpp2IlInjected.Token(Token = "0x400487D")]
	public const short CrimsonPlanterBox = 3218;

	[Cpp2IlInjected.Token(Token = "0x400487E")]
	public const short BlinkrootPlanterBox = 3219;

	[Cpp2IlInjected.Token(Token = "0x400487F")]
	public const short WaterleafPlanterBox = 3220;

	[Cpp2IlInjected.Token(Token = "0x4004880")]
	public const short ShiverthornPlanterBox = 3221;

	[Cpp2IlInjected.Token(Token = "0x4004881")]
	public const short FireBlossomPlanterBox = 3222;

	[Cpp2IlInjected.Token(Token = "0x4004882")]
	public const short BrainOfConfusion = 3223;

	[Cpp2IlInjected.Token(Token = "0x4004883")]
	public const short WormScarf = 3224;

	[Cpp2IlInjected.Token(Token = "0x4004884")]
	public const short BalloonPufferfish = 3225;

	[Cpp2IlInjected.Token(Token = "0x4004885")]
	public const short BejeweledValkyrieHead = 3226;

	[Cpp2IlInjected.Token(Token = "0x4004886")]
	public const short BejeweledValkyrieBody = 3227;

	[Cpp2IlInjected.Token(Token = "0x4004887")]
	public const short BejeweledValkyrieWing = 3228;

	[Cpp2IlInjected.Token(Token = "0x4004888")]
	public const short RichGravestone1 = 3229;

	[Cpp2IlInjected.Token(Token = "0x4004889")]
	public const short RichGravestone2 = 3230;

	[Cpp2IlInjected.Token(Token = "0x400488A")]
	public const short RichGravestone3 = 3231;

	[Cpp2IlInjected.Token(Token = "0x400488B")]
	public const short RichGravestone4 = 3232;

	[Cpp2IlInjected.Token(Token = "0x400488C")]
	public const short RichGravestone5 = 3233;

	[Cpp2IlInjected.Token(Token = "0x400488D")]
	public const short CrystalBlock = 3234;

	[Cpp2IlInjected.Token(Token = "0x400488E")]
	public const short MusicBoxMartians = 3235;

	[Cpp2IlInjected.Token(Token = "0x400488F")]
	public const short MusicBoxPirates = 3236;

	[Cpp2IlInjected.Token(Token = "0x4004890")]
	public const short MusicBoxHell = 3237;

	[Cpp2IlInjected.Token(Token = "0x4004891")]
	public const short CrystalBlockWall = 3238;

	[Cpp2IlInjected.Token(Token = "0x4004892")]
	public const short Trapdoor = 3239;

	[Cpp2IlInjected.Token(Token = "0x4004893")]
	public const short TallGate = 3240;

	[Cpp2IlInjected.Token(Token = "0x4004894")]
	public const short SharkronBalloon = 3241;

	[Cpp2IlInjected.Token(Token = "0x4004895")]
	public const short TaxCollectorHat = 3242;

	[Cpp2IlInjected.Token(Token = "0x4004896")]
	public const short TaxCollectorSuit = 3243;

	[Cpp2IlInjected.Token(Token = "0x4004897")]
	public const short TaxCollectorPants = 3244;

	[Cpp2IlInjected.Token(Token = "0x4004898")]
	public const short BoneGlove = 3245;

	[Cpp2IlInjected.Token(Token = "0x4004899")]
	public const short ClothierJacket = 3246;

	[Cpp2IlInjected.Token(Token = "0x400489A")]
	public const short ClothierPants = 3247;

	[Cpp2IlInjected.Token(Token = "0x400489B")]
	public const short DyeTraderTurban = 3248;

	[Cpp2IlInjected.Token(Token = "0x400489C")]
	public const short DeadlySphereStaff = 3249;

	[Cpp2IlInjected.Token(Token = "0x400489D")]
	public const short BalloonHorseshoeFart = 3250;

	[Cpp2IlInjected.Token(Token = "0x400489E")]
	public const short BalloonHorseshoeHoney = 3251;

	[Cpp2IlInjected.Token(Token = "0x400489F")]
	public const short BalloonHorseshoeSharkron = 3252;

	[Cpp2IlInjected.Token(Token = "0x40048A0")]
	public const short LavaLamp = 3253;

	[Cpp2IlInjected.Token(Token = "0x40048A1")]
	public const short CageEnchantedNightcrawler = 3254;

	[Cpp2IlInjected.Token(Token = "0x40048A2")]
	public const short CageBuggy = 3255;

	[Cpp2IlInjected.Token(Token = "0x40048A3")]
	public const short CageGrubby = 3256;

	[Cpp2IlInjected.Token(Token = "0x40048A4")]
	public const short CageSluggy = 3257;

	[Cpp2IlInjected.Token(Token = "0x40048A5")]
	public const short SlapHand = 3258;

	[Cpp2IlInjected.Token(Token = "0x40048A6")]
	public const short TwilightHairDye = 3259;

	[Cpp2IlInjected.Token(Token = "0x40048A7")]
	public const short BlessedApple = 3260;

	[Cpp2IlInjected.Token(Token = "0x40048A8")]
	public const short SpectreBar = 3261;

	[Cpp2IlInjected.Token(Token = "0x40048A9")]
	public const short Code1 = 3262;

	[Cpp2IlInjected.Token(Token = "0x40048AA")]
	public const short BuccaneerBandana = 3263;

	[Cpp2IlInjected.Token(Token = "0x40048AB")]
	public const short BuccaneerShirt = 3264;

	[Cpp2IlInjected.Token(Token = "0x40048AC")]
	public const short BuccaneerPants = 3265;

	[Cpp2IlInjected.Token(Token = "0x40048AD")]
	public const short ObsidianHelm = 3266;

	[Cpp2IlInjected.Token(Token = "0x40048AE")]
	public const short ObsidianShirt = 3267;

	[Cpp2IlInjected.Token(Token = "0x40048AF")]
	public const short ObsidianPants = 3268;

	[Cpp2IlInjected.Token(Token = "0x40048B0")]
	public const short MedusaHead = 3269;

	[Cpp2IlInjected.Token(Token = "0x40048B1")]
	public const short ItemFrame = 3270;

	[Cpp2IlInjected.Token(Token = "0x40048B2")]
	public const short Sandstone = 3271;

	[Cpp2IlInjected.Token(Token = "0x40048B3")]
	public const short HardenedSand = 3272;

	[Cpp2IlInjected.Token(Token = "0x40048B4")]
	public const short SandstoneWall = 3273;

	[Cpp2IlInjected.Token(Token = "0x40048B5")]
	public const short CorruptHardenedSand = 3274;

	[Cpp2IlInjected.Token(Token = "0x40048B6")]
	public const short CrimsonHardenedSand = 3275;

	[Cpp2IlInjected.Token(Token = "0x40048B7")]
	public const short CorruptSandstone = 3276;

	[Cpp2IlInjected.Token(Token = "0x40048B8")]
	public const short CrimsonSandstone = 3277;

	[Cpp2IlInjected.Token(Token = "0x40048B9")]
	public const short WoodYoyo = 3278;

	[Cpp2IlInjected.Token(Token = "0x40048BA")]
	public const short CorruptYoyo = 3279;

	[Cpp2IlInjected.Token(Token = "0x40048BB")]
	public const short CrimsonYoyo = 3280;

	[Cpp2IlInjected.Token(Token = "0x40048BC")]
	public const short JungleYoyo = 3281;

	[Cpp2IlInjected.Token(Token = "0x40048BD")]
	public const short Cascade = 3282;

	[Cpp2IlInjected.Token(Token = "0x40048BE")]
	public const short Chik = 3283;

	[Cpp2IlInjected.Token(Token = "0x40048BF")]
	public const short Code2 = 3284;

	[Cpp2IlInjected.Token(Token = "0x40048C0")]
	public const short Rally = 3285;

	[Cpp2IlInjected.Token(Token = "0x40048C1")]
	public const short Yelets = 3286;

	[Cpp2IlInjected.Token(Token = "0x40048C2")]
	public const short RedsYoyo = 3287;

	[Cpp2IlInjected.Token(Token = "0x40048C3")]
	public const short ValkyrieYoyo = 3288;

	[Cpp2IlInjected.Token(Token = "0x40048C4")]
	public const short Amarok = 3289;

	[Cpp2IlInjected.Token(Token = "0x40048C5")]
	public const short HelFire = 3290;

	[Cpp2IlInjected.Token(Token = "0x40048C6")]
	public const short Kraken = 3291;

	[Cpp2IlInjected.Token(Token = "0x40048C7")]
	public const short TheEyeOfCthulhu = 3292;

	[Cpp2IlInjected.Token(Token = "0x40048C8")]
	public const short RedString = 3293;

	[Cpp2IlInjected.Token(Token = "0x40048C9")]
	public const short OrangeString = 3294;

	[Cpp2IlInjected.Token(Token = "0x40048CA")]
	public const short YellowString = 3295;

	[Cpp2IlInjected.Token(Token = "0x40048CB")]
	public const short LimeString = 3296;

	[Cpp2IlInjected.Token(Token = "0x40048CC")]
	public const short GreenString = 3297;

	[Cpp2IlInjected.Token(Token = "0x40048CD")]
	public const short TealString = 3298;

	[Cpp2IlInjected.Token(Token = "0x40048CE")]
	public const short CyanString = 3299;

	[Cpp2IlInjected.Token(Token = "0x40048CF")]
	public const short SkyBlueString = 3300;

	[Cpp2IlInjected.Token(Token = "0x40048D0")]
	public const short BlueString = 3301;

	[Cpp2IlInjected.Token(Token = "0x40048D1")]
	public const short PurpleString = 3302;

	[Cpp2IlInjected.Token(Token = "0x40048D2")]
	public const short VioletString = 3303;

	[Cpp2IlInjected.Token(Token = "0x40048D3")]
	public const short PinkString = 3304;

	[Cpp2IlInjected.Token(Token = "0x40048D4")]
	public const short BrownString = 3305;

	[Cpp2IlInjected.Token(Token = "0x40048D5")]
	public const short WhiteString = 3306;

	[Cpp2IlInjected.Token(Token = "0x40048D6")]
	public const short RainbowString = 3307;

	[Cpp2IlInjected.Token(Token = "0x40048D7")]
	public const short BlackString = 3308;

	[Cpp2IlInjected.Token(Token = "0x40048D8")]
	public const short BlackCounterweight = 3309;

	[Cpp2IlInjected.Token(Token = "0x40048D9")]
	public const short BlueCounterweight = 3310;

	[Cpp2IlInjected.Token(Token = "0x40048DA")]
	public const short GreenCounterweight = 3311;

	[Cpp2IlInjected.Token(Token = "0x40048DB")]
	public const short PurpleCounterweight = 3312;

	[Cpp2IlInjected.Token(Token = "0x40048DC")]
	public const short RedCounterweight = 3313;

	[Cpp2IlInjected.Token(Token = "0x40048DD")]
	public const short YellowCounterweight = 3314;

	[Cpp2IlInjected.Token(Token = "0x40048DE")]
	public const short FormatC = 3315;

	[Cpp2IlInjected.Token(Token = "0x40048DF")]
	public const short Gradient = 3316;

	[Cpp2IlInjected.Token(Token = "0x40048E0")]
	public const short Valor = 3317;

	[Cpp2IlInjected.Token(Token = "0x40048E1")]
	public const short KingSlimeBossBag = 3318;

	[Cpp2IlInjected.Token(Token = "0x40048E2")]
	public const short EyeOfCthulhuBossBag = 3319;

	[Cpp2IlInjected.Token(Token = "0x40048E3")]
	public const short EaterOfWorldsBossBag = 3320;

	[Cpp2IlInjected.Token(Token = "0x40048E4")]
	public const short BrainOfCthulhuBossBag = 3321;

	[Cpp2IlInjected.Token(Token = "0x40048E5")]
	public const short QueenBeeBossBag = 3322;

	[Cpp2IlInjected.Token(Token = "0x40048E6")]
	public const short SkeletronBossBag = 3323;

	[Cpp2IlInjected.Token(Token = "0x40048E7")]
	public const short WallOfFleshBossBag = 3324;

	[Cpp2IlInjected.Token(Token = "0x40048E8")]
	public const short DestroyerBossBag = 3325;

	[Cpp2IlInjected.Token(Token = "0x40048E9")]
	public const short TwinsBossBag = 3326;

	[Cpp2IlInjected.Token(Token = "0x40048EA")]
	public const short SkeletronPrimeBossBag = 3327;

	[Cpp2IlInjected.Token(Token = "0x40048EB")]
	public const short PlanteraBossBag = 3328;

	[Cpp2IlInjected.Token(Token = "0x40048EC")]
	public const short GolemBossBag = 3329;

	[Cpp2IlInjected.Token(Token = "0x40048ED")]
	public const short FishronBossBag = 3330;

	[Cpp2IlInjected.Token(Token = "0x40048EE")]
	public const short CultistBossBag = 3331;

	[Cpp2IlInjected.Token(Token = "0x40048EF")]
	public const short MoonLordBossBag = 3332;

	[Cpp2IlInjected.Token(Token = "0x40048F0")]
	public const short HiveBackpack = 3333;

	[Cpp2IlInjected.Token(Token = "0x40048F1")]
	public const short YoYoGlove = 3334;

	[Cpp2IlInjected.Token(Token = "0x40048F2")]
	public const short DemonHeart = 3335;

	[Cpp2IlInjected.Token(Token = "0x40048F3")]
	public const short SporeSac = 3336;

	[Cpp2IlInjected.Token(Token = "0x40048F4")]
	public const short ShinyStone = 3337;

	[Cpp2IlInjected.Token(Token = "0x40048F5")]
	public const short HallowHardenedSand = 3338;

	[Cpp2IlInjected.Token(Token = "0x40048F6")]
	public const short HallowSandstone = 3339;

	[Cpp2IlInjected.Token(Token = "0x40048F7")]
	public const short HardenedSandWall = 3340;

	[Cpp2IlInjected.Token(Token = "0x40048F8")]
	public const short CorruptHardenedSandWall = 3341;

	[Cpp2IlInjected.Token(Token = "0x40048F9")]
	public const short CrimsonHardenedSandWall = 3342;

	[Cpp2IlInjected.Token(Token = "0x40048FA")]
	public const short HallowHardenedSandWall = 3343;

	[Cpp2IlInjected.Token(Token = "0x40048FB")]
	public const short CorruptSandstoneWall = 3344;

	[Cpp2IlInjected.Token(Token = "0x40048FC")]
	public const short CrimsonSandstoneWall = 3345;

	[Cpp2IlInjected.Token(Token = "0x40048FD")]
	public const short HallowSandstoneWall = 3346;

	[Cpp2IlInjected.Token(Token = "0x40048FE")]
	public const short DesertFossil = 3347;

	[Cpp2IlInjected.Token(Token = "0x40048FF")]
	public const short DesertFossilWall = 3348;

	[Cpp2IlInjected.Token(Token = "0x4004900")]
	public const short DyeTradersScimitar = 3349;

	[Cpp2IlInjected.Token(Token = "0x4004901")]
	public const short PainterPaintballGun = 3350;

	[Cpp2IlInjected.Token(Token = "0x4004902")]
	public const short TaxCollectorsStickOfDoom = 3351;

	[Cpp2IlInjected.Token(Token = "0x4004903")]
	public const short StylistKilLaKillScissorsIWish = 3352;

	[Cpp2IlInjected.Token(Token = "0x4004904")]
	public const short MinecartMech = 3353;

	[Cpp2IlInjected.Token(Token = "0x4004905")]
	public const short MechanicalWheelPiece = 3354;

	[Cpp2IlInjected.Token(Token = "0x4004906")]
	public const short MechanicalWagonPiece = 3355;

	[Cpp2IlInjected.Token(Token = "0x4004907")]
	public const short MechanicalBatteryPiece = 3356;

	[Cpp2IlInjected.Token(Token = "0x4004908")]
	public const short AncientCultistTrophy = 3357;

	[Cpp2IlInjected.Token(Token = "0x4004909")]
	public const short MartianSaucerTrophy = 3358;

	[Cpp2IlInjected.Token(Token = "0x400490A")]
	public const short FlyingDutchmanTrophy = 3359;

	[Cpp2IlInjected.Token(Token = "0x400490B")]
	public const short LivingMahoganyWand = 3360;

	[Cpp2IlInjected.Token(Token = "0x400490C")]
	public const short LivingMahoganyLeafWand = 3361;

	[Cpp2IlInjected.Token(Token = "0x400490D")]
	public const short FallenTuxedoShirt = 3362;

	[Cpp2IlInjected.Token(Token = "0x400490E")]
	public const short FallenTuxedoPants = 3363;

	[Cpp2IlInjected.Token(Token = "0x400490F")]
	public const short Fireplace = 3364;

	[Cpp2IlInjected.Token(Token = "0x4004910")]
	public const short Chimney = 3365;

	[Cpp2IlInjected.Token(Token = "0x4004911")]
	public const short YoyoBag = 3366;

	[Cpp2IlInjected.Token(Token = "0x4004912")]
	public const short ShrimpyTruffle = 3367;

	[Cpp2IlInjected.Token(Token = "0x4004913")]
	public const short Arkhalis = 3368;

	[Cpp2IlInjected.Token(Token = "0x4004914")]
	public const short ConfettiCannon = 3369;

	[Cpp2IlInjected.Token(Token = "0x4004915")]
	public const short MusicBoxTowers = 3370;

	[Cpp2IlInjected.Token(Token = "0x4004916")]
	public const short MusicBoxGoblins = 3371;

	[Cpp2IlInjected.Token(Token = "0x4004917")]
	public const short BossMaskCultist = 3372;

	[Cpp2IlInjected.Token(Token = "0x4004918")]
	public const short BossMaskMoonlord = 3373;

	[Cpp2IlInjected.Token(Token = "0x4004919")]
	public const short FossilHelm = 3374;

	[Cpp2IlInjected.Token(Token = "0x400491A")]
	public const short FossilShirt = 3375;

	[Cpp2IlInjected.Token(Token = "0x400491B")]
	public const short FossilPants = 3376;

	[Cpp2IlInjected.Token(Token = "0x400491C")]
	public const short AmberStaff = 3377;

	[Cpp2IlInjected.Token(Token = "0x400491D")]
	public const short BoneJavelin = 3378;

	[Cpp2IlInjected.Token(Token = "0x400491E")]
	public const short BoneDagger = 3379;

	[Cpp2IlInjected.Token(Token = "0x400491F")]
	public const short FossilOre = 3380;

	[Cpp2IlInjected.Token(Token = "0x4004920")]
	public const short StardustHelmet = 3381;

	[Cpp2IlInjected.Token(Token = "0x4004921")]
	public const short StardustBreastplate = 3382;

	[Cpp2IlInjected.Token(Token = "0x4004922")]
	public const short StardustLeggings = 3383;

	[Cpp2IlInjected.Token(Token = "0x4004923")]
	public const short PortalGun = 3384;

	[Cpp2IlInjected.Token(Token = "0x4004924")]
	public const short StrangePlant1 = 3385;

	[Cpp2IlInjected.Token(Token = "0x4004925")]
	public const short StrangePlant2 = 3386;

	[Cpp2IlInjected.Token(Token = "0x4004926")]
	public const short StrangePlant3 = 3387;

	[Cpp2IlInjected.Token(Token = "0x4004927")]
	public const short StrangePlant4 = 3388;

	[Cpp2IlInjected.Token(Token = "0x4004928")]
	public const short Terrarian = 3389;

	[Cpp2IlInjected.Token(Token = "0x4004929")]
	public const short GoblinSummonerBanner = 3390;

	[Cpp2IlInjected.Token(Token = "0x400492A")]
	public const short SalamanderBanner = 3391;

	[Cpp2IlInjected.Token(Token = "0x400492B")]
	public const short GiantShellyBanner = 3392;

	[Cpp2IlInjected.Token(Token = "0x400492C")]
	public const short CrawdadBanner = 3393;

	[Cpp2IlInjected.Token(Token = "0x400492D")]
	public const short FritzBanner = 3394;

	[Cpp2IlInjected.Token(Token = "0x400492E")]
	public const short CreatureFromTheDeepBanner = 3395;

	[Cpp2IlInjected.Token(Token = "0x400492F")]
	public const short DrManFlyBanner = 3396;

	[Cpp2IlInjected.Token(Token = "0x4004930")]
	public const short MothronBanner = 3397;

	[Cpp2IlInjected.Token(Token = "0x4004931")]
	public const short SeveredHandBanner = 3398;

	[Cpp2IlInjected.Token(Token = "0x4004932")]
	public const short ThePossessedBanner = 3399;

	[Cpp2IlInjected.Token(Token = "0x4004933")]
	public const short ButcherBanner = 3400;

	[Cpp2IlInjected.Token(Token = "0x4004934")]
	public const short PsychoBanner = 3401;

	[Cpp2IlInjected.Token(Token = "0x4004935")]
	public const short DeadlySphereBanner = 3402;

	[Cpp2IlInjected.Token(Token = "0x4004936")]
	public const short NailheadBanner = 3403;

	[Cpp2IlInjected.Token(Token = "0x4004937")]
	public const short PoisonousSporeBanner = 3404;

	[Cpp2IlInjected.Token(Token = "0x4004938")]
	public const short MedusaBanner = 3405;

	[Cpp2IlInjected.Token(Token = "0x4004939")]
	public const short GreekSkeletonBanner = 3406;

	[Cpp2IlInjected.Token(Token = "0x400493A")]
	public const short GraniteFlyerBanner = 3407;

	[Cpp2IlInjected.Token(Token = "0x400493B")]
	public const short GraniteGolemBanner = 3408;

	[Cpp2IlInjected.Token(Token = "0x400493C")]
	public const short BloodZombieBanner = 3409;

	[Cpp2IlInjected.Token(Token = "0x400493D")]
	public const short DripplerBanner = 3410;

	[Cpp2IlInjected.Token(Token = "0x400493E")]
	public const short TombCrawlerBanner = 3411;

	[Cpp2IlInjected.Token(Token = "0x400493F")]
	public const short DuneSplicerBanner = 3412;

	[Cpp2IlInjected.Token(Token = "0x4004940")]
	public const short FlyingAntlionBanner = 3413;

	[Cpp2IlInjected.Token(Token = "0x4004941")]
	public const short WalkingAntlionBanner = 3414;

	[Cpp2IlInjected.Token(Token = "0x4004942")]
	public const short DesertGhoulBanner = 3415;

	[Cpp2IlInjected.Token(Token = "0x4004943")]
	public const short DesertLamiaBanner = 3416;

	[Cpp2IlInjected.Token(Token = "0x4004944")]
	public const short DesertDjinnBanner = 3417;

	[Cpp2IlInjected.Token(Token = "0x4004945")]
	public const short DesertBasiliskBanner = 3418;

	[Cpp2IlInjected.Token(Token = "0x4004946")]
	public const short RavagerScorpionBanner = 3419;

	[Cpp2IlInjected.Token(Token = "0x4004947")]
	public const short StardustSoldierBanner = 3420;

	[Cpp2IlInjected.Token(Token = "0x4004948")]
	public const short StardustWormBanner = 3421;

	[Cpp2IlInjected.Token(Token = "0x4004949")]
	public const short StardustJellyfishBanner = 3422;

	[Cpp2IlInjected.Token(Token = "0x400494A")]
	public const short StardustSpiderBanner = 3423;

	[Cpp2IlInjected.Token(Token = "0x400494B")]
	public const short StardustSmallCellBanner = 3424;

	[Cpp2IlInjected.Token(Token = "0x400494C")]
	public const short StardustLargeCellBanner = 3425;

	[Cpp2IlInjected.Token(Token = "0x400494D")]
	public const short SolarCoriteBanner = 3426;

	[Cpp2IlInjected.Token(Token = "0x400494E")]
	public const short SolarSrollerBanner = 3427;

	[Cpp2IlInjected.Token(Token = "0x400494F")]
	public const short SolarCrawltipedeBanner = 3428;

	[Cpp2IlInjected.Token(Token = "0x4004950")]
	public const short SolarDrakomireRiderBanner = 3429;

	[Cpp2IlInjected.Token(Token = "0x4004951")]
	public const short SolarDrakomireBanner = 3430;

	[Cpp2IlInjected.Token(Token = "0x4004952")]
	public const short SolarSolenianBanner = 3431;

	[Cpp2IlInjected.Token(Token = "0x4004953")]
	public const short NebulaSoldierBanner = 3432;

	[Cpp2IlInjected.Token(Token = "0x4004954")]
	public const short NebulaHeadcrabBanner = 3433;

	[Cpp2IlInjected.Token(Token = "0x4004955")]
	public const short NebulaBrainBanner = 3434;

	[Cpp2IlInjected.Token(Token = "0x4004956")]
	public const short NebulaBeastBanner = 3435;

	[Cpp2IlInjected.Token(Token = "0x4004957")]
	public const short VortexLarvaBanner = 3436;

	[Cpp2IlInjected.Token(Token = "0x4004958")]
	public const short VortexHornetQueenBanner = 3437;

	[Cpp2IlInjected.Token(Token = "0x4004959")]
	public const short VortexHornetBanner = 3438;

	[Cpp2IlInjected.Token(Token = "0x400495A")]
	public const short VortexSoldierBanner = 3439;

	[Cpp2IlInjected.Token(Token = "0x400495B")]
	public const short VortexRiflemanBanner = 3440;

	[Cpp2IlInjected.Token(Token = "0x400495C")]
	public const short PirateCaptainBanner = 3441;

	[Cpp2IlInjected.Token(Token = "0x400495D")]
	public const short PirateDeadeyeBanner = 3442;

	[Cpp2IlInjected.Token(Token = "0x400495E")]
	public const short PirateCorsairBanner = 3443;

	[Cpp2IlInjected.Token(Token = "0x400495F")]
	public const short PirateCrossbowerBanner = 3444;

	[Cpp2IlInjected.Token(Token = "0x4004960")]
	public const short MartianWalkerBanner = 3445;

	[Cpp2IlInjected.Token(Token = "0x4004961")]
	public const short RedDevilBanner = 3446;

	[Cpp2IlInjected.Token(Token = "0x4004962")]
	public const short PinkJellyfishBanner = 3447;

	[Cpp2IlInjected.Token(Token = "0x4004963")]
	public const short GreenJellyfishBanner = 3448;

	[Cpp2IlInjected.Token(Token = "0x4004964")]
	public const short DarkMummyBanner = 3449;

	[Cpp2IlInjected.Token(Token = "0x4004965")]
	public const short LightMummyBanner = 3450;

	[Cpp2IlInjected.Token(Token = "0x4004966")]
	public const short AngryBonesBanner = 3451;

	[Cpp2IlInjected.Token(Token = "0x4004967")]
	public const short IceTortoiseBanner = 3452;

	[Cpp2IlInjected.Token(Token = "0x4004968")]
	public const short NebulaPickup1 = 3453;

	[Cpp2IlInjected.Token(Token = "0x4004969")]
	public const short NebulaPickup2 = 3454;

	[Cpp2IlInjected.Token(Token = "0x400496A")]
	public const short NebulaPickup3 = 3455;

	[Cpp2IlInjected.Token(Token = "0x400496B")]
	public const short FragmentVortex = 3456;

	[Cpp2IlInjected.Token(Token = "0x400496C")]
	public const short FragmentNebula = 3457;

	[Cpp2IlInjected.Token(Token = "0x400496D")]
	public const short FragmentSolar = 3458;

	[Cpp2IlInjected.Token(Token = "0x400496E")]
	public const short FragmentStardust = 3459;

	[Cpp2IlInjected.Token(Token = "0x400496F")]
	public const short LunarOre = 3460;

	[Cpp2IlInjected.Token(Token = "0x4004970")]
	public const short LunarBrick = 3461;

	[Cpp2IlInjected.Token(Token = "0x4004971")]
	public const short StardustAxe = 3462;

	[Cpp2IlInjected.Token(Token = "0x4004972")]
	public const short StardustChainsaw = 3463;

	[Cpp2IlInjected.Token(Token = "0x4004973")]
	public const short StardustDrill = 3464;

	[Cpp2IlInjected.Token(Token = "0x4004974")]
	public const short StardustHammer = 3465;

	[Cpp2IlInjected.Token(Token = "0x4004975")]
	public const short StardustPickaxe = 3466;

	[Cpp2IlInjected.Token(Token = "0x4004976")]
	public const short LunarBar = 3467;

	[Cpp2IlInjected.Token(Token = "0x4004977")]
	public const short WingsSolar = 3468;

	[Cpp2IlInjected.Token(Token = "0x4004978")]
	public const short WingsVortex = 3469;

	[Cpp2IlInjected.Token(Token = "0x4004979")]
	public const short WingsNebula = 3470;

	[Cpp2IlInjected.Token(Token = "0x400497A")]
	public const short WingsStardust = 3471;

	[Cpp2IlInjected.Token(Token = "0x400497B")]
	public const short LunarBrickWall = 3472;

	[Cpp2IlInjected.Token(Token = "0x400497C")]
	public const short SolarEruption = 3473;

	[Cpp2IlInjected.Token(Token = "0x400497D")]
	public const short StardustCellStaff = 3474;

	[Cpp2IlInjected.Token(Token = "0x400497E")]
	public const short VortexBeater = 3475;

	[Cpp2IlInjected.Token(Token = "0x400497F")]
	public const short NebulaArcanum = 3476;

	[Cpp2IlInjected.Token(Token = "0x4004980")]
	public const short BloodWater = 3477;

	[Cpp2IlInjected.Token(Token = "0x4004981")]
	public const short TheBrideHat = 3478;

	[Cpp2IlInjected.Token(Token = "0x4004982")]
	public const short TheBrideDress = 3479;

	[Cpp2IlInjected.Token(Token = "0x4004983")]
	public const short PlatinumBow = 3480;

	[Cpp2IlInjected.Token(Token = "0x4004984")]
	public const short PlatinumHammer = 3481;

	[Cpp2IlInjected.Token(Token = "0x4004985")]
	public const short PlatinumAxe = 3482;

	[Cpp2IlInjected.Token(Token = "0x4004986")]
	public const short PlatinumShortsword = 3483;

	[Cpp2IlInjected.Token(Token = "0x4004987")]
	public const short PlatinumBroadsword = 3484;

	[Cpp2IlInjected.Token(Token = "0x4004988")]
	public const short PlatinumPickaxe = 3485;

	[Cpp2IlInjected.Token(Token = "0x4004989")]
	public const short TungstenBow = 3486;

	[Cpp2IlInjected.Token(Token = "0x400498A")]
	public const short TungstenHammer = 3487;

	[Cpp2IlInjected.Token(Token = "0x400498B")]
	public const short TungstenAxe = 3488;

	[Cpp2IlInjected.Token(Token = "0x400498C")]
	public const short TungstenShortsword = 3489;

	[Cpp2IlInjected.Token(Token = "0x400498D")]
	public const short TungstenBroadsword = 3490;

	[Cpp2IlInjected.Token(Token = "0x400498E")]
	public const short TungstenPickaxe = 3491;

	[Cpp2IlInjected.Token(Token = "0x400498F")]
	public const short LeadBow = 3492;

	[Cpp2IlInjected.Token(Token = "0x4004990")]
	public const short LeadHammer = 3493;

	[Cpp2IlInjected.Token(Token = "0x4004991")]
	public const short LeadAxe = 3494;

	[Cpp2IlInjected.Token(Token = "0x4004992")]
	public const short LeadShortsword = 3495;

	[Cpp2IlInjected.Token(Token = "0x4004993")]
	public const short LeadBroadsword = 3496;

	[Cpp2IlInjected.Token(Token = "0x4004994")]
	public const short LeadPickaxe = 3497;

	[Cpp2IlInjected.Token(Token = "0x4004995")]
	public const short TinBow = 3498;

	[Cpp2IlInjected.Token(Token = "0x4004996")]
	public const short TinHammer = 3499;

	[Cpp2IlInjected.Token(Token = "0x4004997")]
	public const short TinAxe = 3500;

	[Cpp2IlInjected.Token(Token = "0x4004998")]
	public const short TinShortsword = 3501;

	[Cpp2IlInjected.Token(Token = "0x4004999")]
	public const short TinBroadsword = 3502;

	[Cpp2IlInjected.Token(Token = "0x400499A")]
	public const short TinPickaxe = 3503;

	[Cpp2IlInjected.Token(Token = "0x400499B")]
	public const short CopperBow = 3504;

	[Cpp2IlInjected.Token(Token = "0x400499C")]
	public const short CopperHammer = 3505;

	[Cpp2IlInjected.Token(Token = "0x400499D")]
	public const short CopperAxe = 3506;

	[Cpp2IlInjected.Token(Token = "0x400499E")]
	public const short CopperShortsword = 3507;

	[Cpp2IlInjected.Token(Token = "0x400499F")]
	public const short CopperBroadsword = 3508;

	[Cpp2IlInjected.Token(Token = "0x40049A0")]
	public const short CopperPickaxe = 3509;

	[Cpp2IlInjected.Token(Token = "0x40049A1")]
	public const short SilverBow = 3510;

	[Cpp2IlInjected.Token(Token = "0x40049A2")]
	public const short SilverHammer = 3511;

	[Cpp2IlInjected.Token(Token = "0x40049A3")]
	public const short SilverAxe = 3512;

	[Cpp2IlInjected.Token(Token = "0x40049A4")]
	public const short SilverShortsword = 3513;

	[Cpp2IlInjected.Token(Token = "0x40049A5")]
	public const short SilverBroadsword = 3514;

	[Cpp2IlInjected.Token(Token = "0x40049A6")]
	public const short SilverPickaxe = 3515;

	[Cpp2IlInjected.Token(Token = "0x40049A7")]
	public const short GoldBow = 3516;

	[Cpp2IlInjected.Token(Token = "0x40049A8")]
	public const short GoldHammer = 3517;

	[Cpp2IlInjected.Token(Token = "0x40049A9")]
	public const short GoldAxe = 3518;

	[Cpp2IlInjected.Token(Token = "0x40049AA")]
	public const short GoldShortsword = 3519;

	[Cpp2IlInjected.Token(Token = "0x40049AB")]
	public const short GoldBroadsword = 3520;

	[Cpp2IlInjected.Token(Token = "0x40049AC")]
	public const short GoldPickaxe = 3521;

	[Cpp2IlInjected.Token(Token = "0x40049AD")]
	public const short LunarHamaxeSolar = 3522;

	[Cpp2IlInjected.Token(Token = "0x40049AE")]
	public const short LunarHamaxeVortex = 3523;

	[Cpp2IlInjected.Token(Token = "0x40049AF")]
	public const short LunarHamaxeNebula = 3524;

	[Cpp2IlInjected.Token(Token = "0x40049B0")]
	public const short LunarHamaxeStardust = 3525;

	[Cpp2IlInjected.Token(Token = "0x40049B1")]
	public const short SolarDye = 3526;

	[Cpp2IlInjected.Token(Token = "0x40049B2")]
	public const short NebulaDye = 3527;

	[Cpp2IlInjected.Token(Token = "0x40049B3")]
	public const short VortexDye = 3528;

	[Cpp2IlInjected.Token(Token = "0x40049B4")]
	public const short StardustDye = 3529;

	[Cpp2IlInjected.Token(Token = "0x40049B5")]
	public const short VoidDye = 3530;

	[Cpp2IlInjected.Token(Token = "0x40049B6")]
	public const short StardustDragonStaff = 3531;

	[Cpp2IlInjected.Token(Token = "0x40049B7")]
	public const short Bacon = 3532;

	[Cpp2IlInjected.Token(Token = "0x40049B8")]
	public const short ShiftingSandsDye = 3533;

	[Cpp2IlInjected.Token(Token = "0x40049B9")]
	public const short MirageDye = 3534;

	[Cpp2IlInjected.Token(Token = "0x40049BA")]
	public const short ShiftingPearlSandsDye = 3535;

	[Cpp2IlInjected.Token(Token = "0x40049BB")]
	public const short VortexMonolith = 3536;

	[Cpp2IlInjected.Token(Token = "0x40049BC")]
	public const short NebulaMonolith = 3537;

	[Cpp2IlInjected.Token(Token = "0x40049BD")]
	public const short StardustMonolith = 3538;

	[Cpp2IlInjected.Token(Token = "0x40049BE")]
	public const short SolarMonolith = 3539;

	[Cpp2IlInjected.Token(Token = "0x40049BF")]
	public const short Phantasm = 3540;

	[Cpp2IlInjected.Token(Token = "0x40049C0")]
	public const short LastPrism = 3541;

	[Cpp2IlInjected.Token(Token = "0x40049C1")]
	public const short NebulaBlaze = 3542;

	[Cpp2IlInjected.Token(Token = "0x40049C2")]
	public const short DayBreak = 3543;

	[Cpp2IlInjected.Token(Token = "0x40049C3")]
	public const short SuperHealingPotion = 3544;

	[Cpp2IlInjected.Token(Token = "0x40049C4")]
	public const short Detonator = 3545;

	[Cpp2IlInjected.Token(Token = "0x40049C5")]
	public const short FireworksLauncher = 3546;

	[Cpp2IlInjected.Token(Token = "0x40049C6")]
	public const short BouncyDynamite = 3547;

	[Cpp2IlInjected.Token(Token = "0x40049C7")]
	public const short PartyGirlGrenade = 3548;

	[Cpp2IlInjected.Token(Token = "0x40049C8")]
	public const short LunarCraftingStation = 3549;

	[Cpp2IlInjected.Token(Token = "0x40049C9")]
	public const short FlameAndSilverDye = 3550;

	[Cpp2IlInjected.Token(Token = "0x40049CA")]
	public const short GreenFlameAndSilverDye = 3551;

	[Cpp2IlInjected.Token(Token = "0x40049CB")]
	public const short BlueFlameAndSilverDye = 3552;

	[Cpp2IlInjected.Token(Token = "0x40049CC")]
	public const short ReflectiveCopperDye = 3553;

	[Cpp2IlInjected.Token(Token = "0x40049CD")]
	public const short ReflectiveObsidianDye = 3554;

	[Cpp2IlInjected.Token(Token = "0x40049CE")]
	public const short ReflectiveMetalDye = 3555;

	[Cpp2IlInjected.Token(Token = "0x40049CF")]
	public const short MidnightRainbowDye = 3556;

	[Cpp2IlInjected.Token(Token = "0x40049D0")]
	public const short BlackAndWhiteDye = 3557;

	[Cpp2IlInjected.Token(Token = "0x40049D1")]
	public const short BrightSilverDye = 3558;

	[Cpp2IlInjected.Token(Token = "0x40049D2")]
	public const short SilverAndBlackDye = 3559;

	[Cpp2IlInjected.Token(Token = "0x40049D3")]
	public const short RedAcidDye = 3560;

	[Cpp2IlInjected.Token(Token = "0x40049D4")]
	public const short GelDye = 3561;

	[Cpp2IlInjected.Token(Token = "0x40049D5")]
	public const short PinkGelDye = 3562;

	[Cpp2IlInjected.Token(Token = "0x40049D6")]
	public const short SquirrelRed = 3563;

	[Cpp2IlInjected.Token(Token = "0x40049D7")]
	public const short SquirrelGold = 3564;

	[Cpp2IlInjected.Token(Token = "0x40049D8")]
	public const short SquirrelOrangeCage = 3565;

	[Cpp2IlInjected.Token(Token = "0x40049D9")]
	public const short SquirrelGoldCage = 3566;

	[Cpp2IlInjected.Token(Token = "0x40049DA")]
	public const short MoonlordBullet = 3567;

	[Cpp2IlInjected.Token(Token = "0x40049DB")]
	public const short MoonlordArrow = 3568;

	[Cpp2IlInjected.Token(Token = "0x40049DC")]
	public const short MoonlordTurretStaff = 3569;

	[Cpp2IlInjected.Token(Token = "0x40049DD")]
	public const short LunarFlareBook = 3570;

	[Cpp2IlInjected.Token(Token = "0x40049DE")]
	public const short RainbowCrystalStaff = 3571;

	[Cpp2IlInjected.Token(Token = "0x40049DF")]
	public const short LunarHook = 3572;

	[Cpp2IlInjected.Token(Token = "0x40049E0")]
	public const short LunarBlockSolar = 3573;

	[Cpp2IlInjected.Token(Token = "0x40049E1")]
	public const short LunarBlockVortex = 3574;

	[Cpp2IlInjected.Token(Token = "0x40049E2")]
	public const short LunarBlockNebula = 3575;

	[Cpp2IlInjected.Token(Token = "0x40049E3")]
	public const short LunarBlockStardust = 3576;

	[Cpp2IlInjected.Token(Token = "0x40049E4")]
	public const short SuspiciousLookingTentacle = 3577;

	[Cpp2IlInjected.Token(Token = "0x40049E5")]
	public const short Yoraiz0rShirt = 3578;

	[Cpp2IlInjected.Token(Token = "0x40049E6")]
	public const short Yoraiz0rPants = 3579;

	[Cpp2IlInjected.Token(Token = "0x40049E7")]
	public const short Yoraiz0rWings = 3580;

	[Cpp2IlInjected.Token(Token = "0x40049E8")]
	public const short Yoraiz0rDarkness = 3581;

	[Cpp2IlInjected.Token(Token = "0x40049E9")]
	public const short JimsWings = 3582;

	[Cpp2IlInjected.Token(Token = "0x40049EA")]
	public const short Yoraiz0rHead = 3583;

	[Cpp2IlInjected.Token(Token = "0x40049EB")]
	public const short LivingLeafWall = 3584;

	[Cpp2IlInjected.Token(Token = "0x40049EC")]
	public const short SkiphsHelm = 3585;

	[Cpp2IlInjected.Token(Token = "0x40049ED")]
	public const short SkiphsShirt = 3586;

	[Cpp2IlInjected.Token(Token = "0x40049EE")]
	public const short SkiphsPants = 3587;

	[Cpp2IlInjected.Token(Token = "0x40049EF")]
	public const short SkiphsWings = 3588;

	[Cpp2IlInjected.Token(Token = "0x40049F0")]
	public const short LokisHelm = 3589;

	[Cpp2IlInjected.Token(Token = "0x40049F1")]
	public const short LokisShirt = 3590;

	[Cpp2IlInjected.Token(Token = "0x40049F2")]
	public const short LokisPants = 3591;

	[Cpp2IlInjected.Token(Token = "0x40049F3")]
	public const short LokisWings = 3592;

	[Cpp2IlInjected.Token(Token = "0x40049F4")]
	public const short SandSlimeBanner = 3593;

	[Cpp2IlInjected.Token(Token = "0x40049F5")]
	public const short SeaSnailBanner = 3594;

	[Cpp2IlInjected.Token(Token = "0x40049F6")]
	public const short MoonLordTrophy = 3595;

	[Cpp2IlInjected.Token(Token = "0x40049F7")]
	public const short MoonLordPainting = 3596;

	[Cpp2IlInjected.Token(Token = "0x40049F8")]
	public const short BurningHadesDye = 3597;

	[Cpp2IlInjected.Token(Token = "0x40049F9")]
	public const short GrimDye = 3598;

	[Cpp2IlInjected.Token(Token = "0x40049FA")]
	public const short LokisDye = 3599;

	[Cpp2IlInjected.Token(Token = "0x40049FB")]
	public const short ShadowflameHadesDye = 3600;

	[Cpp2IlInjected.Token(Token = "0x40049FC")]
	public const short CelestialSigil = 3601;

	[Cpp2IlInjected.Token(Token = "0x40049FD")]
	public const short LogicGateLamp_Off = 3602;

	[Cpp2IlInjected.Token(Token = "0x40049FE")]
	public const short LogicGate_AND = 3603;

	[Cpp2IlInjected.Token(Token = "0x40049FF")]
	public const short LogicGate_OR = 3604;

	[Cpp2IlInjected.Token(Token = "0x4004A00")]
	public const short LogicGate_NAND = 3605;

	[Cpp2IlInjected.Token(Token = "0x4004A01")]
	public const short LogicGate_NOR = 3606;

	[Cpp2IlInjected.Token(Token = "0x4004A02")]
	public const short LogicGate_XOR = 3607;

	[Cpp2IlInjected.Token(Token = "0x4004A03")]
	public const short LogicGate_NXOR = 3608;

	[Cpp2IlInjected.Token(Token = "0x4004A04")]
	public const short ConveyorBeltLeft = 3609;

	[Cpp2IlInjected.Token(Token = "0x4004A05")]
	public const short ConveyorBeltRight = 3610;

	[Cpp2IlInjected.Token(Token = "0x4004A06")]
	public const short WireKite = 3611;

	[Cpp2IlInjected.Token(Token = "0x4004A07")]
	public const short YellowWrench = 3612;

	[Cpp2IlInjected.Token(Token = "0x4004A08")]
	public const short LogicSensor_Sun = 3613;

	[Cpp2IlInjected.Token(Token = "0x4004A09")]
	public const short LogicSensor_Moon = 3614;

	[Cpp2IlInjected.Token(Token = "0x4004A0A")]
	public const short LogicSensor_Above = 3615;

	[Cpp2IlInjected.Token(Token = "0x4004A0B")]
	public const short WirePipe = 3616;

	[Cpp2IlInjected.Token(Token = "0x4004A0C")]
	public const short AnnouncementBox = 3617;

	[Cpp2IlInjected.Token(Token = "0x4004A0D")]
	public const short LogicGateLamp_On = 3618;

	[Cpp2IlInjected.Token(Token = "0x4004A0E")]
	public const short MechanicalLens = 3619;

	[Cpp2IlInjected.Token(Token = "0x4004A0F")]
	public const short ActuationRod = 3620;

	[Cpp2IlInjected.Token(Token = "0x4004A10")]
	public const short TeamBlockRed = 3621;

	[Cpp2IlInjected.Token(Token = "0x4004A11")]
	public const short TeamBlockRedPlatform = 3622;

	[Cpp2IlInjected.Token(Token = "0x4004A12")]
	public const short StaticHook = 3623;

	[Cpp2IlInjected.Token(Token = "0x4004A13")]
	public const short ActuationAccessory = 3624;

	[Cpp2IlInjected.Token(Token = "0x4004A14")]
	public const short MulticolorWrench = 3625;

	[Cpp2IlInjected.Token(Token = "0x4004A15")]
	public const short WeightedPressurePlatePink = 3626;

	[Cpp2IlInjected.Token(Token = "0x4004A16")]
	public const short EngineeringHelmet = 3627;

	[Cpp2IlInjected.Token(Token = "0x4004A17")]
	public const short CompanionCube = 3628;

	[Cpp2IlInjected.Token(Token = "0x4004A18")]
	public const short WireBulb = 3629;

	[Cpp2IlInjected.Token(Token = "0x4004A19")]
	public const short WeightedPressurePlateOrange = 3630;

	[Cpp2IlInjected.Token(Token = "0x4004A1A")]
	public const short WeightedPressurePlatePurple = 3631;

	[Cpp2IlInjected.Token(Token = "0x4004A1B")]
	public const short WeightedPressurePlateCyan = 3632;

	[Cpp2IlInjected.Token(Token = "0x4004A1C")]
	public const short TeamBlockGreen = 3633;

	[Cpp2IlInjected.Token(Token = "0x4004A1D")]
	public const short TeamBlockBlue = 3634;

	[Cpp2IlInjected.Token(Token = "0x4004A1E")]
	public const short TeamBlockYellow = 3635;

	[Cpp2IlInjected.Token(Token = "0x4004A1F")]
	public const short TeamBlockPink = 3636;

	[Cpp2IlInjected.Token(Token = "0x4004A20")]
	public const short TeamBlockWhite = 3637;

	[Cpp2IlInjected.Token(Token = "0x4004A21")]
	public const short TeamBlockGreenPlatform = 3638;

	[Cpp2IlInjected.Token(Token = "0x4004A22")]
	public const short TeamBlockBluePlatform = 3639;

	[Cpp2IlInjected.Token(Token = "0x4004A23")]
	public const short TeamBlockYellowPlatform = 3640;

	[Cpp2IlInjected.Token(Token = "0x4004A24")]
	public const short TeamBlockPinkPlatform = 3641;

	[Cpp2IlInjected.Token(Token = "0x4004A25")]
	public const short TeamBlockWhitePlatform = 3642;

	[Cpp2IlInjected.Token(Token = "0x4004A26")]
	public const short LargeAmber = 3643;

	[Cpp2IlInjected.Token(Token = "0x4004A27")]
	public const short GemLockRuby = 3644;

	[Cpp2IlInjected.Token(Token = "0x4004A28")]
	public const short GemLockSapphire = 3645;

	[Cpp2IlInjected.Token(Token = "0x4004A29")]
	public const short GemLockEmerald = 3646;

	[Cpp2IlInjected.Token(Token = "0x4004A2A")]
	public const short GemLockTopaz = 3647;

	[Cpp2IlInjected.Token(Token = "0x4004A2B")]
	public const short GemLockAmethyst = 3648;

	[Cpp2IlInjected.Token(Token = "0x4004A2C")]
	public const short GemLockDiamond = 3649;

	[Cpp2IlInjected.Token(Token = "0x4004A2D")]
	public const short GemLockAmber = 3650;

	[Cpp2IlInjected.Token(Token = "0x4004A2E")]
	public const short SquirrelStatue = 3651;

	[Cpp2IlInjected.Token(Token = "0x4004A2F")]
	public const short ButterflyStatue = 3652;

	[Cpp2IlInjected.Token(Token = "0x4004A30")]
	public const short WormStatue = 3653;

	[Cpp2IlInjected.Token(Token = "0x4004A31")]
	public const short FireflyStatue = 3654;

	[Cpp2IlInjected.Token(Token = "0x4004A32")]
	public const short ScorpionStatue = 3655;

	[Cpp2IlInjected.Token(Token = "0x4004A33")]
	public const short SnailStatue = 3656;

	[Cpp2IlInjected.Token(Token = "0x4004A34")]
	public const short GrasshopperStatue = 3657;

	[Cpp2IlInjected.Token(Token = "0x4004A35")]
	public const short MouseStatue = 3658;

	[Cpp2IlInjected.Token(Token = "0x4004A36")]
	public const short DuckStatue = 3659;

	[Cpp2IlInjected.Token(Token = "0x4004A37")]
	public const short PenguinStatue = 3660;

	[Cpp2IlInjected.Token(Token = "0x4004A38")]
	public const short FrogStatue = 3661;

	[Cpp2IlInjected.Token(Token = "0x4004A39")]
	public const short BuggyStatue = 3662;

	[Cpp2IlInjected.Token(Token = "0x4004A3A")]
	public const short LogicGateLamp_Faulty = 3663;

	[Cpp2IlInjected.Token(Token = "0x4004A3B")]
	public const short PortalGunStation = 3664;

	[Cpp2IlInjected.Token(Token = "0x4004A3C")]
	public const short Fake_Chest = 3665;

	[Cpp2IlInjected.Token(Token = "0x4004A3D")]
	public const short Fake_GoldChest = 3666;

	[Cpp2IlInjected.Token(Token = "0x4004A3E")]
	public const short Fake_ShadowChest = 3667;

	[Cpp2IlInjected.Token(Token = "0x4004A3F")]
	public const short Fake_EbonwoodChest = 3668;

	[Cpp2IlInjected.Token(Token = "0x4004A40")]
	public const short Fake_RichMahoganyChest = 3669;

	[Cpp2IlInjected.Token(Token = "0x4004A41")]
	public const short Fake_PearlwoodChest = 3670;

	[Cpp2IlInjected.Token(Token = "0x4004A42")]
	public const short Fake_IvyChest = 3671;

	[Cpp2IlInjected.Token(Token = "0x4004A43")]
	public const short Fake_IceChest = 3672;

	[Cpp2IlInjected.Token(Token = "0x4004A44")]
	public const short Fake_LivingWoodChest = 3673;

	[Cpp2IlInjected.Token(Token = "0x4004A45")]
	public const short Fake_SkywareChest = 3674;

	[Cpp2IlInjected.Token(Token = "0x4004A46")]
	public const short Fake_ShadewoodChest = 3675;

	[Cpp2IlInjected.Token(Token = "0x4004A47")]
	public const short Fake_WebCoveredChest = 3676;

	[Cpp2IlInjected.Token(Token = "0x4004A48")]
	public const short Fake_LihzahrdChest = 3677;

	[Cpp2IlInjected.Token(Token = "0x4004A49")]
	public const short Fake_WaterChest = 3678;

	[Cpp2IlInjected.Token(Token = "0x4004A4A")]
	public const short Fake_JungleChest = 3679;

	[Cpp2IlInjected.Token(Token = "0x4004A4B")]
	public const short Fake_CorruptionChest = 3680;

	[Cpp2IlInjected.Token(Token = "0x4004A4C")]
	public const short Fake_CrimsonChest = 3681;

	[Cpp2IlInjected.Token(Token = "0x4004A4D")]
	public const short Fake_HallowedChest = 3682;

	[Cpp2IlInjected.Token(Token = "0x4004A4E")]
	public const short Fake_FrozenChest = 3683;

	[Cpp2IlInjected.Token(Token = "0x4004A4F")]
	public const short Fake_DynastyChest = 3684;

	[Cpp2IlInjected.Token(Token = "0x4004A50")]
	public const short Fake_HoneyChest = 3685;

	[Cpp2IlInjected.Token(Token = "0x4004A51")]
	public const short Fake_SteampunkChest = 3686;

	[Cpp2IlInjected.Token(Token = "0x4004A52")]
	public const short Fake_PalmWoodChest = 3687;

	[Cpp2IlInjected.Token(Token = "0x4004A53")]
	public const short Fake_MushroomChest = 3688;

	[Cpp2IlInjected.Token(Token = "0x4004A54")]
	public const short Fake_BorealWoodChest = 3689;

	[Cpp2IlInjected.Token(Token = "0x4004A55")]
	public const short Fake_SlimeChest = 3690;

	[Cpp2IlInjected.Token(Token = "0x4004A56")]
	public const short Fake_GreenDungeonChest = 3691;

	[Cpp2IlInjected.Token(Token = "0x4004A57")]
	public const short Fake_PinkDungeonChest = 3692;

	[Cpp2IlInjected.Token(Token = "0x4004A58")]
	public const short Fake_BlueDungeonChest = 3693;

	[Cpp2IlInjected.Token(Token = "0x4004A59")]
	public const short Fake_BoneChest = 3694;

	[Cpp2IlInjected.Token(Token = "0x4004A5A")]
	public const short Fake_CactusChest = 3695;

	[Cpp2IlInjected.Token(Token = "0x4004A5B")]
	public const short Fake_FleshChest = 3696;

	[Cpp2IlInjected.Token(Token = "0x4004A5C")]
	public const short Fake_ObsidianChest = 3697;

	[Cpp2IlInjected.Token(Token = "0x4004A5D")]
	public const short Fake_PumpkinChest = 3698;

	[Cpp2IlInjected.Token(Token = "0x4004A5E")]
	public const short Fake_SpookyChest = 3699;

	[Cpp2IlInjected.Token(Token = "0x4004A5F")]
	public const short Fake_GlassChest = 3700;

	[Cpp2IlInjected.Token(Token = "0x4004A60")]
	public const short Fake_MartianChest = 3701;

	[Cpp2IlInjected.Token(Token = "0x4004A61")]
	public const short Fake_MeteoriteChest = 3702;

	[Cpp2IlInjected.Token(Token = "0x4004A62")]
	public const short Fake_GraniteChest = 3703;

	[Cpp2IlInjected.Token(Token = "0x4004A63")]
	public const short Fake_MarbleChest = 3704;

	[Cpp2IlInjected.Token(Token = "0x4004A64")]
	public const short Fake_newchest1 = 3705;

	[Cpp2IlInjected.Token(Token = "0x4004A65")]
	public const short Fake_newchest2 = 3706;

	[Cpp2IlInjected.Token(Token = "0x4004A66")]
	public const short ProjectilePressurePad = 3707;

	[Cpp2IlInjected.Token(Token = "0x4004A67")]
	public const short WallCreeperStatue = 3708;

	[Cpp2IlInjected.Token(Token = "0x4004A68")]
	public const short UnicornStatue = 3709;

	[Cpp2IlInjected.Token(Token = "0x4004A69")]
	public const short DripplerStatue = 3710;

	[Cpp2IlInjected.Token(Token = "0x4004A6A")]
	public const short WraithStatue = 3711;

	[Cpp2IlInjected.Token(Token = "0x4004A6B")]
	public const short BoneSkeletonStatue = 3712;

	[Cpp2IlInjected.Token(Token = "0x4004A6C")]
	public const short UndeadVikingStatue = 3713;

	[Cpp2IlInjected.Token(Token = "0x4004A6D")]
	public const short MedusaStatue = 3714;

	[Cpp2IlInjected.Token(Token = "0x4004A6E")]
	public const short HarpyStatue = 3715;

	[Cpp2IlInjected.Token(Token = "0x4004A6F")]
	public const short PigronStatue = 3716;

	[Cpp2IlInjected.Token(Token = "0x4004A70")]
	public const short HopliteStatue = 3717;

	[Cpp2IlInjected.Token(Token = "0x4004A71")]
	public const short GraniteGolemStatue = 3718;

	[Cpp2IlInjected.Token(Token = "0x4004A72")]
	public const short ZombieArmStatue = 3719;

	[Cpp2IlInjected.Token(Token = "0x4004A73")]
	public const short BloodZombieStatue = 3720;

	[Cpp2IlInjected.Token(Token = "0x4004A74")]
	public const short AnglerTackleBag = 3721;

	[Cpp2IlInjected.Token(Token = "0x4004A75")]
	public const short GeyserTrap = 3722;

	[Cpp2IlInjected.Token(Token = "0x4004A76")]
	public const short UltraBrightCampfire = 3723;

	[Cpp2IlInjected.Token(Token = "0x4004A77")]
	public const short BoneCampfire = 3724;

	[Cpp2IlInjected.Token(Token = "0x4004A78")]
	public const short PixelBox = 3725;

	[Cpp2IlInjected.Token(Token = "0x4004A79")]
	public const short LogicSensor_Water = 3726;

	[Cpp2IlInjected.Token(Token = "0x4004A7A")]
	public const short LogicSensor_Lava = 3727;

	[Cpp2IlInjected.Token(Token = "0x4004A7B")]
	public const short LogicSensor_Honey = 3728;

	[Cpp2IlInjected.Token(Token = "0x4004A7C")]
	public const short LogicSensor_Liquid = 3729;

	[Cpp2IlInjected.Token(Token = "0x4004A7D")]
	public const short PartyBundleOfBalloonsAccessory = 3730;

	[Cpp2IlInjected.Token(Token = "0x4004A7E")]
	public const short PartyBalloonAnimal = 3731;

	[Cpp2IlInjected.Token(Token = "0x4004A7F")]
	public const short PartyHat = 3732;

	[Cpp2IlInjected.Token(Token = "0x4004A80")]
	public const short FlowerBoyHat = 3733;

	[Cpp2IlInjected.Token(Token = "0x4004A81")]
	public const short FlowerBoyShirt = 3734;

	[Cpp2IlInjected.Token(Token = "0x4004A82")]
	public const short FlowerBoyPants = 3735;

	[Cpp2IlInjected.Token(Token = "0x4004A83")]
	public const short SillyBalloonPink = 3736;

	[Cpp2IlInjected.Token(Token = "0x4004A84")]
	public const short SillyBalloonPurple = 3737;

	[Cpp2IlInjected.Token(Token = "0x4004A85")]
	public const short SillyBalloonGreen = 3738;

	[Cpp2IlInjected.Token(Token = "0x4004A86")]
	public const short SillyStreamerBlue = 3739;

	[Cpp2IlInjected.Token(Token = "0x4004A87")]
	public const short SillyStreamerGreen = 3740;

	[Cpp2IlInjected.Token(Token = "0x4004A88")]
	public const short SillyStreamerPink = 3741;

	[Cpp2IlInjected.Token(Token = "0x4004A89")]
	public const short SillyBalloonMachine = 3742;

	[Cpp2IlInjected.Token(Token = "0x4004A8A")]
	public const short SillyBalloonTiedPink = 3743;

	[Cpp2IlInjected.Token(Token = "0x4004A8B")]
	public const short SillyBalloonTiedPurple = 3744;

	[Cpp2IlInjected.Token(Token = "0x4004A8C")]
	public const short SillyBalloonTiedGreen = 3745;

	[Cpp2IlInjected.Token(Token = "0x4004A8D")]
	public const short Pigronata = 3746;

	[Cpp2IlInjected.Token(Token = "0x4004A8E")]
	public const short PartyMonolith = 3747;

	[Cpp2IlInjected.Token(Token = "0x4004A8F")]
	public const short PartyBundleOfBalloonTile = 3748;

	[Cpp2IlInjected.Token(Token = "0x4004A90")]
	public const short PartyPresent = 3749;

	[Cpp2IlInjected.Token(Token = "0x4004A91")]
	public const short SliceOfCake = 3750;

	[Cpp2IlInjected.Token(Token = "0x4004A92")]
	public const short CogWall = 3751;

	[Cpp2IlInjected.Token(Token = "0x4004A93")]
	public const short SandFallWall = 3752;

	[Cpp2IlInjected.Token(Token = "0x4004A94")]
	public const short SnowFallWall = 3753;

	[Cpp2IlInjected.Token(Token = "0x4004A95")]
	public const short SandFallBlock = 3754;

	[Cpp2IlInjected.Token(Token = "0x4004A96")]
	public const short SnowFallBlock = 3755;

	[Cpp2IlInjected.Token(Token = "0x4004A97")]
	public const short SnowCloudBlock = 3756;

	[Cpp2IlInjected.Token(Token = "0x4004A98")]
	public const short PedguinHat = 3757;

	[Cpp2IlInjected.Token(Token = "0x4004A99")]
	public const short PedguinShirt = 3758;

	[Cpp2IlInjected.Token(Token = "0x4004A9A")]
	public const short PedguinPants = 3759;

	[Cpp2IlInjected.Token(Token = "0x4004A9B")]
	public const short SillyBalloonPinkWall = 3760;

	[Cpp2IlInjected.Token(Token = "0x4004A9C")]
	public const short SillyBalloonPurpleWall = 3761;

	[Cpp2IlInjected.Token(Token = "0x4004A9D")]
	public const short SillyBalloonGreenWall = 3762;

	[Cpp2IlInjected.Token(Token = "0x4004A9E")]
	public const short AviatorSunglasses = 3763;

	[Cpp2IlInjected.Token(Token = "0x4004A9F")]
	public const short BluePhasesaber = 3764;

	[Cpp2IlInjected.Token(Token = "0x4004AA0")]
	public const short RedPhasesaber = 3765;

	[Cpp2IlInjected.Token(Token = "0x4004AA1")]
	public const short GreenPhasesaber = 3766;

	[Cpp2IlInjected.Token(Token = "0x4004AA2")]
	public const short PurplePhasesaber = 3767;

	[Cpp2IlInjected.Token(Token = "0x4004AA3")]
	public const short WhitePhasesaber = 3768;

	[Cpp2IlInjected.Token(Token = "0x4004AA4")]
	public const short YellowPhasesaber = 3769;

	[Cpp2IlInjected.Token(Token = "0x4004AA5")]
	public const short DjinnsCurse = 3770;

	[Cpp2IlInjected.Token(Token = "0x4004AA6")]
	public const short AncientHorn = 3771;

	[Cpp2IlInjected.Token(Token = "0x4004AA7")]
	public const short AntlionClaw = 3772;

	[Cpp2IlInjected.Token(Token = "0x4004AA8")]
	public const short AncientArmorHat = 3773;

	[Cpp2IlInjected.Token(Token = "0x4004AA9")]
	public const short AncientArmorShirt = 3774;

	[Cpp2IlInjected.Token(Token = "0x4004AAA")]
	public const short AncientArmorPants = 3775;

	[Cpp2IlInjected.Token(Token = "0x4004AAB")]
	public const short AncientBattleArmorHat = 3776;

	[Cpp2IlInjected.Token(Token = "0x4004AAC")]
	public const short AncientBattleArmorShirt = 3777;

	[Cpp2IlInjected.Token(Token = "0x4004AAD")]
	public const short AncientBattleArmorPants = 3778;

	[Cpp2IlInjected.Token(Token = "0x4004AAE")]
	public const short SpiritFlame = 3779;

	[Cpp2IlInjected.Token(Token = "0x4004AAF")]
	public const short SandElementalBanner = 3780;

	[Cpp2IlInjected.Token(Token = "0x4004AB0")]
	public const short PocketMirror = 3781;

	[Cpp2IlInjected.Token(Token = "0x4004AB1")]
	public const short MagicSandDropper = 3782;

	[Cpp2IlInjected.Token(Token = "0x4004AB2")]
	public const short AncientBattleArmorMaterial = 3783;

	[Cpp2IlInjected.Token(Token = "0x4004AB3")]
	public const short LamiaPants = 3784;

	[Cpp2IlInjected.Token(Token = "0x4004AB4")]
	public const short LamiaShirt = 3785;

	[Cpp2IlInjected.Token(Token = "0x4004AB5")]
	public const short LamiaHat = 3786;

	[Cpp2IlInjected.Token(Token = "0x4004AB6")]
	public const short SkyFracture = 3787;

	[Cpp2IlInjected.Token(Token = "0x4004AB7")]
	public const short OnyxBlaster = 3788;

	[Cpp2IlInjected.Token(Token = "0x4004AB8")]
	public const short SandsharkBanner = 3789;

	[Cpp2IlInjected.Token(Token = "0x4004AB9")]
	public const short SandsharkCorruptBanner = 3790;

	[Cpp2IlInjected.Token(Token = "0x4004ABA")]
	public const short SandsharkCrimsonBanner = 3791;

	[Cpp2IlInjected.Token(Token = "0x4004ABB")]
	public const short SandsharkHallowedBanner = 3792;

	[Cpp2IlInjected.Token(Token = "0x4004ABC")]
	public const short TumbleweedBanner = 3793;

	[Cpp2IlInjected.Token(Token = "0x4004ABD")]
	public const short AncientCloth = 3794;

	[Cpp2IlInjected.Token(Token = "0x4004ABE")]
	public const short DjinnLamp = 3795;

	[Cpp2IlInjected.Token(Token = "0x4004ABF")]
	public const short MusicBoxSandstorm = 3796;

	[Cpp2IlInjected.Token(Token = "0x4004AC0")]
	public const short ApprenticeHat = 3797;

	[Cpp2IlInjected.Token(Token = "0x4004AC1")]
	public const short ApprenticeRobe = 3798;

	[Cpp2IlInjected.Token(Token = "0x4004AC2")]
	public const short ApprenticeTrousers = 3799;

	[Cpp2IlInjected.Token(Token = "0x4004AC3")]
	public const short SquireGreatHelm = 3800;

	[Cpp2IlInjected.Token(Token = "0x4004AC4")]
	public const short SquirePlating = 3801;

	[Cpp2IlInjected.Token(Token = "0x4004AC5")]
	public const short SquireGreaves = 3802;

	[Cpp2IlInjected.Token(Token = "0x4004AC6")]
	public const short HuntressWig = 3803;

	[Cpp2IlInjected.Token(Token = "0x4004AC7")]
	public const short HuntressJerkin = 3804;

	[Cpp2IlInjected.Token(Token = "0x4004AC8")]
	public const short HuntressPants = 3805;

	[Cpp2IlInjected.Token(Token = "0x4004AC9")]
	public const short MonkBrows = 3806;

	[Cpp2IlInjected.Token(Token = "0x4004ACA")]
	public const short MonkShirt = 3807;

	[Cpp2IlInjected.Token(Token = "0x4004ACB")]
	public const short MonkPants = 3808;

	[Cpp2IlInjected.Token(Token = "0x4004ACC")]
	public const short ApprenticeScarf = 3809;

	[Cpp2IlInjected.Token(Token = "0x4004ACD")]
	public const short SquireShield = 3810;

	[Cpp2IlInjected.Token(Token = "0x4004ACE")]
	public const short HuntressBuckler = 3811;

	[Cpp2IlInjected.Token(Token = "0x4004ACF")]
	public const short MonkBelt = 3812;

	[Cpp2IlInjected.Token(Token = "0x4004AD0")]
	public const short DefendersForge = 3813;

	[Cpp2IlInjected.Token(Token = "0x4004AD1")]
	public const short WarTable = 3814;

	[Cpp2IlInjected.Token(Token = "0x4004AD2")]
	public const short WarTableBanner = 3815;

	[Cpp2IlInjected.Token(Token = "0x4004AD3")]
	public const short DD2ElderCrystalStand = 3816;

	[Cpp2IlInjected.Token(Token = "0x4004AD4")]
	public const short DefenderMedal = 3817;

	[Cpp2IlInjected.Token(Token = "0x4004AD5")]
	public const short DD2FlameburstTowerT1Popper = 3818;

	[Cpp2IlInjected.Token(Token = "0x4004AD6")]
	public const short DD2FlameburstTowerT2Popper = 3819;

	[Cpp2IlInjected.Token(Token = "0x4004AD7")]
	public const short DD2FlameburstTowerT3Popper = 3820;

	[Cpp2IlInjected.Token(Token = "0x4004AD8")]
	public const short AleThrowingGlove = 3821;

	[Cpp2IlInjected.Token(Token = "0x4004AD9")]
	public const short DD2EnergyCrystal = 3822;

	[Cpp2IlInjected.Token(Token = "0x4004ADA")]
	public const short DD2SquireDemonSword = 3823;

	[Cpp2IlInjected.Token(Token = "0x4004ADB")]
	public const short DD2BallistraTowerT1Popper = 3824;

	[Cpp2IlInjected.Token(Token = "0x4004ADC")]
	public const short DD2BallistraTowerT2Popper = 3825;

	[Cpp2IlInjected.Token(Token = "0x4004ADD")]
	public const short DD2BallistraTowerT3Popper = 3826;

	[Cpp2IlInjected.Token(Token = "0x4004ADE")]
	public const short DD2SquireBetsySword = 3827;

	[Cpp2IlInjected.Token(Token = "0x4004ADF")]
	public const short DD2ElderCrystal = 3828;

	[Cpp2IlInjected.Token(Token = "0x4004AE0")]
	public const short DD2LightningAuraT1Popper = 3829;

	[Cpp2IlInjected.Token(Token = "0x4004AE1")]
	public const short DD2LightningAuraT2Popper = 3830;

	[Cpp2IlInjected.Token(Token = "0x4004AE2")]
	public const short DD2LightningAuraT3Popper = 3831;

	[Cpp2IlInjected.Token(Token = "0x4004AE3")]
	public const short DD2ExplosiveTrapT1Popper = 3832;

	[Cpp2IlInjected.Token(Token = "0x4004AE4")]
	public const short DD2ExplosiveTrapT2Popper = 3833;

	[Cpp2IlInjected.Token(Token = "0x4004AE5")]
	public const short DD2ExplosiveTrapT3Popper = 3834;

	[Cpp2IlInjected.Token(Token = "0x4004AE6")]
	public const short MonkStaffT1 = 3835;

	[Cpp2IlInjected.Token(Token = "0x4004AE7")]
	public const short MonkStaffT2 = 3836;

	[Cpp2IlInjected.Token(Token = "0x4004AE8")]
	public const short DD2GoblinBomberBanner = 3837;

	[Cpp2IlInjected.Token(Token = "0x4004AE9")]
	public const short DD2GoblinBanner = 3838;

	[Cpp2IlInjected.Token(Token = "0x4004AEA")]
	public const short DD2SkeletonBanner = 3839;

	[Cpp2IlInjected.Token(Token = "0x4004AEB")]
	public const short DD2DrakinBanner = 3840;

	[Cpp2IlInjected.Token(Token = "0x4004AEC")]
	public const short DD2KoboldFlyerBanner = 3841;

	[Cpp2IlInjected.Token(Token = "0x4004AED")]
	public const short DD2KoboldBanner = 3842;

	[Cpp2IlInjected.Token(Token = "0x4004AEE")]
	public const short DD2WitherBeastBanner = 3843;

	[Cpp2IlInjected.Token(Token = "0x4004AEF")]
	public const short DD2WyvernBanner = 3844;

	[Cpp2IlInjected.Token(Token = "0x4004AF0")]
	public const short DD2JavelinThrowerBanner = 3845;

	[Cpp2IlInjected.Token(Token = "0x4004AF1")]
	public const short DD2LightningBugBanner = 3846;

	[Cpp2IlInjected.Token(Token = "0x4004AF2")]
	public const short OgreMask = 3847;

	[Cpp2IlInjected.Token(Token = "0x4004AF3")]
	public const short GoblinMask = 3848;

	[Cpp2IlInjected.Token(Token = "0x4004AF4")]
	public const short GoblinBomberCap = 3849;

	[Cpp2IlInjected.Token(Token = "0x4004AF5")]
	public const short EtherianJavelin = 3850;

	[Cpp2IlInjected.Token(Token = "0x4004AF6")]
	public const short KoboldDynamiteBackpack = 3851;

	[Cpp2IlInjected.Token(Token = "0x4004AF7")]
	public const short BookStaff = 3852;

	[Cpp2IlInjected.Token(Token = "0x4004AF8")]
	public const short BoringBow = 3853;

	[Cpp2IlInjected.Token(Token = "0x4004AF9")]
	public const short DD2PhoenixBow = 3854;

	[Cpp2IlInjected.Token(Token = "0x4004AFA")]
	public const short DD2PetGato = 3855;

	[Cpp2IlInjected.Token(Token = "0x4004AFB")]
	public const short DD2PetGhost = 3856;

	[Cpp2IlInjected.Token(Token = "0x4004AFC")]
	public const short DD2PetDragon = 3857;

	[Cpp2IlInjected.Token(Token = "0x4004AFD")]
	public const short MonkStaffT3 = 3858;

	[Cpp2IlInjected.Token(Token = "0x4004AFE")]
	public const short DD2BetsyBow = 3859;

	[Cpp2IlInjected.Token(Token = "0x4004AFF")]
	public const short BossBagBetsy = 3860;

	[Cpp2IlInjected.Token(Token = "0x4004B00")]
	public const short BossBagOgre = 3861;

	[Cpp2IlInjected.Token(Token = "0x4004B01")]
	public const short BossBagDarkMage = 3862;

	[Cpp2IlInjected.Token(Token = "0x4004B02")]
	public const short BossMaskBetsy = 3863;

	[Cpp2IlInjected.Token(Token = "0x4004B03")]
	public const short BossMaskDarkMage = 3864;

	[Cpp2IlInjected.Token(Token = "0x4004B04")]
	public const short BossMaskOgre = 3865;

	[Cpp2IlInjected.Token(Token = "0x4004B05")]
	public const short BossTrophyBetsy = 3866;

	[Cpp2IlInjected.Token(Token = "0x4004B06")]
	public const short BossTrophyDarkmage = 3867;

	[Cpp2IlInjected.Token(Token = "0x4004B07")]
	public const short BossTrophyOgre = 3868;

	[Cpp2IlInjected.Token(Token = "0x4004B08")]
	public const short MusicBoxDD2 = 3869;

	[Cpp2IlInjected.Token(Token = "0x4004B09")]
	public const short ApprenticeStaffT3 = 3870;

	[Cpp2IlInjected.Token(Token = "0x4004B0A")]
	public const short SquireAltHead = 3871;

	[Cpp2IlInjected.Token(Token = "0x4004B0B")]
	public const short SquireAltShirt = 3872;

	[Cpp2IlInjected.Token(Token = "0x4004B0C")]
	public const short SquireAltPants = 3873;

	[Cpp2IlInjected.Token(Token = "0x4004B0D")]
	public const short ApprenticeAltHead = 3874;

	[Cpp2IlInjected.Token(Token = "0x4004B0E")]
	public const short ApprenticeAltShirt = 3875;

	[Cpp2IlInjected.Token(Token = "0x4004B0F")]
	public const short ApprenticeAltPants = 3876;

	[Cpp2IlInjected.Token(Token = "0x4004B10")]
	public const short HuntressAltHead = 3877;

	[Cpp2IlInjected.Token(Token = "0x4004B11")]
	public const short HuntressAltShirt = 3878;

	[Cpp2IlInjected.Token(Token = "0x4004B12")]
	public const short HuntressAltPants = 3879;

	[Cpp2IlInjected.Token(Token = "0x4004B13")]
	public const short MonkAltHead = 3880;

	[Cpp2IlInjected.Token(Token = "0x4004B14")]
	public const short MonkAltShirt = 3881;

	[Cpp2IlInjected.Token(Token = "0x4004B15")]
	public const short MonkAltPants = 3882;

	[Cpp2IlInjected.Token(Token = "0x4004B16")]
	public const short BetsyWings = 3883;

	[Cpp2IlInjected.Token(Token = "0x4004B17")]
	public const short CrystalChest = 3884;

	[Cpp2IlInjected.Token(Token = "0x4004B18")]
	public const short GoldenChest = 3885;

	[Cpp2IlInjected.Token(Token = "0x4004B19")]
	public const short Fake_CrystalChest = 3886;

	[Cpp2IlInjected.Token(Token = "0x4004B1A")]
	public const short Fake_GoldenChest = 3887;

	[Cpp2IlInjected.Token(Token = "0x4004B1B")]
	public const short CrystalDoor = 3888;

	[Cpp2IlInjected.Token(Token = "0x4004B1C")]
	public const short CrystalChair = 3889;

	[Cpp2IlInjected.Token(Token = "0x4004B1D")]
	public const short CrystalCandle = 3890;

	[Cpp2IlInjected.Token(Token = "0x4004B1E")]
	public const short CrystalLantern = 3891;

	[Cpp2IlInjected.Token(Token = "0x4004B1F")]
	public const short CrystalLamp = 3892;

	[Cpp2IlInjected.Token(Token = "0x4004B20")]
	public const short CrystalCandelabra = 3893;

	[Cpp2IlInjected.Token(Token = "0x4004B21")]
	public const short CrystalChandelier = 3894;

	[Cpp2IlInjected.Token(Token = "0x4004B22")]
	public const short CrystalBathtub = 3895;

	[Cpp2IlInjected.Token(Token = "0x4004B23")]
	public const short CrystalSink = 3896;

	[Cpp2IlInjected.Token(Token = "0x4004B24")]
	public const short CrystalBed = 3897;

	[Cpp2IlInjected.Token(Token = "0x4004B25")]
	public const short CrystalClock = 3898;

	[Cpp2IlInjected.Token(Token = "0x4004B26")]
	public const short SkywareClock2 = 3899;

	[Cpp2IlInjected.Token(Token = "0x4004B27")]
	public const short DungeonClockBlue = 3900;

	[Cpp2IlInjected.Token(Token = "0x4004B28")]
	public const short DungeonClockGreen = 3901;

	[Cpp2IlInjected.Token(Token = "0x4004B29")]
	public const short DungeonClockPink = 3902;

	[Cpp2IlInjected.Token(Token = "0x4004B2A")]
	public const short CrystalPlatform = 3903;

	[Cpp2IlInjected.Token(Token = "0x4004B2B")]
	public const short GoldenPlatform = 3904;

	[Cpp2IlInjected.Token(Token = "0x4004B2C")]
	public const short DynastyPlatform = 3905;

	[Cpp2IlInjected.Token(Token = "0x4004B2D")]
	public const short LihzahrdPlatform = 3906;

	[Cpp2IlInjected.Token(Token = "0x4004B2E")]
	public const short FleshPlatform = 3907;

	[Cpp2IlInjected.Token(Token = "0x4004B2F")]
	public const short FrozenPlatform = 3908;

	[Cpp2IlInjected.Token(Token = "0x4004B30")]
	public const short CrystalWorkbench = 3909;

	[Cpp2IlInjected.Token(Token = "0x4004B31")]
	public const short GoldenWorkbench = 3910;

	[Cpp2IlInjected.Token(Token = "0x4004B32")]
	public const short CrystalDresser = 3911;

	[Cpp2IlInjected.Token(Token = "0x4004B33")]
	public const short DynastyDresser = 3912;

	[Cpp2IlInjected.Token(Token = "0x4004B34")]
	public const short FrozenDresser = 3913;

	[Cpp2IlInjected.Token(Token = "0x4004B35")]
	public const short LivingWoodDresser = 3914;

	[Cpp2IlInjected.Token(Token = "0x4004B36")]
	public const short CrystalPiano = 3915;

	[Cpp2IlInjected.Token(Token = "0x4004B37")]
	public const short DynastyPiano = 3916;

	[Cpp2IlInjected.Token(Token = "0x4004B38")]
	public const short CrystalBookCase = 3917;

	[Cpp2IlInjected.Token(Token = "0x4004B39")]
	public const short CrystalSofaHowDoesThatEvenWork = 3918;

	[Cpp2IlInjected.Token(Token = "0x4004B3A")]
	public const short DynastySofa = 3919;

	[Cpp2IlInjected.Token(Token = "0x4004B3B")]
	public const short CrystalTable = 3920;

	[Cpp2IlInjected.Token(Token = "0x4004B3C")]
	public const short ArkhalisHat = 3921;

	[Cpp2IlInjected.Token(Token = "0x4004B3D")]
	public const short ArkhalisShirt = 3922;

	[Cpp2IlInjected.Token(Token = "0x4004B3E")]
	public const short ArkhalisPants = 3923;

	[Cpp2IlInjected.Token(Token = "0x4004B3F")]
	public const short ArkhalisWings = 3924;

	[Cpp2IlInjected.Token(Token = "0x4004B40")]
	public const short LeinforsHat = 3925;

	[Cpp2IlInjected.Token(Token = "0x4004B41")]
	public const short LeinforsShirt = 3926;

	[Cpp2IlInjected.Token(Token = "0x4004B42")]
	public const short LeinforsPants = 3927;

	[Cpp2IlInjected.Token(Token = "0x4004B43")]
	public const short LeinforsWings = 3928;

	[Cpp2IlInjected.Token(Token = "0x4004B44")]
	public const short LeinforsAccessory = 3929;

	[Cpp2IlInjected.Token(Token = "0x4004B45")]
	public const short Celeb2 = 3930;

	[Cpp2IlInjected.Token(Token = "0x4004B46")]
	public const short SpiderBathtub = 3931;

	[Cpp2IlInjected.Token(Token = "0x4004B47")]
	public const short SpiderBed = 3932;

	[Cpp2IlInjected.Token(Token = "0x4004B48")]
	public const short SpiderBookcase = 3933;

	[Cpp2IlInjected.Token(Token = "0x4004B49")]
	public const short SpiderDresser = 3934;

	[Cpp2IlInjected.Token(Token = "0x4004B4A")]
	public const short SpiderCandelabra = 3935;

	[Cpp2IlInjected.Token(Token = "0x4004B4B")]
	public const short SpiderCandle = 3936;

	[Cpp2IlInjected.Token(Token = "0x4004B4C")]
	public const short SpiderChair = 3937;

	[Cpp2IlInjected.Token(Token = "0x4004B4D")]
	public const short SpiderChandelier = 3938;

	[Cpp2IlInjected.Token(Token = "0x4004B4E")]
	public const short SpiderChest = 3939;

	[Cpp2IlInjected.Token(Token = "0x4004B4F")]
	public const short SpiderClock = 3940;

	[Cpp2IlInjected.Token(Token = "0x4004B50")]
	public const short SpiderDoor = 3941;

	[Cpp2IlInjected.Token(Token = "0x4004B51")]
	public const short SpiderLamp = 3942;

	[Cpp2IlInjected.Token(Token = "0x4004B52")]
	public const short SpiderLantern = 3943;

	[Cpp2IlInjected.Token(Token = "0x4004B53")]
	public const short SpiderPiano = 3944;

	[Cpp2IlInjected.Token(Token = "0x4004B54")]
	public const short SpiderPlatform = 3945;

	[Cpp2IlInjected.Token(Token = "0x4004B55")]
	public const short SpiderSinkSpiderSinkDoesWhateverASpiderSinkDoes = 3946;

	[Cpp2IlInjected.Token(Token = "0x4004B56")]
	public const short SpiderSofa = 3947;

	[Cpp2IlInjected.Token(Token = "0x4004B57")]
	public const short SpiderTable = 3948;

	[Cpp2IlInjected.Token(Token = "0x4004B58")]
	public const short SpiderWorkbench = 3949;

	[Cpp2IlInjected.Token(Token = "0x4004B59")]
	public const short Fake_SpiderChest = 3950;

	[Cpp2IlInjected.Token(Token = "0x4004B5A")]
	public const short IronBrick = 3951;

	[Cpp2IlInjected.Token(Token = "0x4004B5B")]
	public const short IronBrickWall = 3952;

	[Cpp2IlInjected.Token(Token = "0x4004B5C")]
	public const short LeadBrick = 3953;

	[Cpp2IlInjected.Token(Token = "0x4004B5D")]
	public const short LeadBrickWall = 3954;

	[Cpp2IlInjected.Token(Token = "0x4004B5E")]
	public const short LesionBlock = 3955;

	[Cpp2IlInjected.Token(Token = "0x4004B5F")]
	public const short LesionBlockWall = 3956;

	[Cpp2IlInjected.Token(Token = "0x4004B60")]
	public const short LesionPlatform = 3957;

	[Cpp2IlInjected.Token(Token = "0x4004B61")]
	public const short LesionBathtub = 3958;

	[Cpp2IlInjected.Token(Token = "0x4004B62")]
	public const short LesionBed = 3959;

	[Cpp2IlInjected.Token(Token = "0x4004B63")]
	public const short LesionBookcase = 3960;

	[Cpp2IlInjected.Token(Token = "0x4004B64")]
	public const short LesionCandelabra = 3961;

	[Cpp2IlInjected.Token(Token = "0x4004B65")]
	public const short LesionCandle = 3962;

	[Cpp2IlInjected.Token(Token = "0x4004B66")]
	public const short LesionChair = 3963;

	[Cpp2IlInjected.Token(Token = "0x4004B67")]
	public const short LesionChandelier = 3964;

	[Cpp2IlInjected.Token(Token = "0x4004B68")]
	public const short LesionChest = 3965;

	[Cpp2IlInjected.Token(Token = "0x4004B69")]
	public const short LesionClock = 3966;

	[Cpp2IlInjected.Token(Token = "0x4004B6A")]
	public const short LesionDoor = 3967;

	[Cpp2IlInjected.Token(Token = "0x4004B6B")]
	public const short LesionDresser = 3968;

	[Cpp2IlInjected.Token(Token = "0x4004B6C")]
	public const short LesionLamp = 3969;

	[Cpp2IlInjected.Token(Token = "0x4004B6D")]
	public const short LesionLantern = 3970;

	[Cpp2IlInjected.Token(Token = "0x4004B6E")]
	public const short LesionPiano = 3971;

	[Cpp2IlInjected.Token(Token = "0x4004B6F")]
	public const short LesionSink = 3972;

	[Cpp2IlInjected.Token(Token = "0x4004B70")]
	public const short LesionSofa = 3973;

	[Cpp2IlInjected.Token(Token = "0x4004B71")]
	public const short LesionTable = 3974;

	[Cpp2IlInjected.Token(Token = "0x4004B72")]
	public const short LesionWorkbench = 3975;

	[Cpp2IlInjected.Token(Token = "0x4004B73")]
	public const short Fake_LesionChest = 3976;

	[Cpp2IlInjected.Token(Token = "0x4004B74")]
	public const short HatRack = 3977;

	[Cpp2IlInjected.Token(Token = "0x4004B75")]
	public const short ColorOnlyDye = 3978;

	[Cpp2IlInjected.Token(Token = "0x4004B76")]
	public const short WoodenCrateHard = 3979;

	[Cpp2IlInjected.Token(Token = "0x4004B77")]
	public const short IronCrateHard = 3980;

	[Cpp2IlInjected.Token(Token = "0x4004B78")]
	public const short GoldenCrateHard = 3981;

	[Cpp2IlInjected.Token(Token = "0x4004B79")]
	public const short CorruptFishingCrateHard = 3982;

	[Cpp2IlInjected.Token(Token = "0x4004B7A")]
	public const short CrimsonFishingCrateHard = 3983;

	[Cpp2IlInjected.Token(Token = "0x4004B7B")]
	public const short DungeonFishingCrateHard = 3984;

	[Cpp2IlInjected.Token(Token = "0x4004B7C")]
	public const short FloatingIslandFishingCrateHard = 3985;

	[Cpp2IlInjected.Token(Token = "0x4004B7D")]
	public const short HallowedFishingCrateHard = 3986;

	[Cpp2IlInjected.Token(Token = "0x4004B7E")]
	public const short JungleFishingCrateHard = 3987;

	[Cpp2IlInjected.Token(Token = "0x4004B7F")]
	public const short DeadMansChest = 3988;

	[Cpp2IlInjected.Token(Token = "0x4004B80")]
	public const short GolfBall = 3989;

	[Cpp2IlInjected.Token(Token = "0x4004B81")]
	public const short AmphibianBoots = 3990;

	[Cpp2IlInjected.Token(Token = "0x4004B82")]
	public const short ArcaneFlower = 3991;

	[Cpp2IlInjected.Token(Token = "0x4004B83")]
	public const short BerserkerGlove = 3992;

	[Cpp2IlInjected.Token(Token = "0x4004B84")]
	public const short FairyBoots = 3993;

	[Cpp2IlInjected.Token(Token = "0x4004B85")]
	public const short FrogFlipper = 3994;

	[Cpp2IlInjected.Token(Token = "0x4004B86")]
	public const short FrogGear = 3995;

	[Cpp2IlInjected.Token(Token = "0x4004B87")]
	public const short FrogWebbing = 3996;

	[Cpp2IlInjected.Token(Token = "0x4004B88")]
	public const short FrozenShield = 3997;

	[Cpp2IlInjected.Token(Token = "0x4004B89")]
	public const short HeroShield = 3998;

	[Cpp2IlInjected.Token(Token = "0x4004B8A")]
	public const short LavaSkull = 3999;

	[Cpp2IlInjected.Token(Token = "0x4004B8B")]
	public const short MagnetFlower = 4000;

	[Cpp2IlInjected.Token(Token = "0x4004B8C")]
	public const short ManaCloak = 4001;

	[Cpp2IlInjected.Token(Token = "0x4004B8D")]
	public const short MoltenQuiver = 4002;

	[Cpp2IlInjected.Token(Token = "0x4004B8E")]
	public const short MoltenSkullRose = 4003;

	[Cpp2IlInjected.Token(Token = "0x4004B8F")]
	public const short ObsidianSkullRose = 4004;

	[Cpp2IlInjected.Token(Token = "0x4004B90")]
	public const short ReconScope = 4005;

	[Cpp2IlInjected.Token(Token = "0x4004B91")]
	public const short StalkersQuiver = 4006;

	[Cpp2IlInjected.Token(Token = "0x4004B92")]
	public const short StingerNecklace = 4007;

	[Cpp2IlInjected.Token(Token = "0x4004B93")]
	public const short UltrabrightHelmet = 4008;

	[Cpp2IlInjected.Token(Token = "0x4004B94")]
	public const short Apple = 4009;

	[Cpp2IlInjected.Token(Token = "0x4004B95")]
	public const short ApplePieSlice = 4010;

	[Cpp2IlInjected.Token(Token = "0x4004B96")]
	public const short ApplePie = 4011;

	[Cpp2IlInjected.Token(Token = "0x4004B97")]
	public const short BananaSplit = 4012;

	[Cpp2IlInjected.Token(Token = "0x4004B98")]
	public const short BBQRibs = 4013;

	[Cpp2IlInjected.Token(Token = "0x4004B99")]
	public const short BunnyStew = 4014;

	[Cpp2IlInjected.Token(Token = "0x4004B9A")]
	public const short Burger = 4015;

	[Cpp2IlInjected.Token(Token = "0x4004B9B")]
	public const short ChickenNugget = 4016;

	[Cpp2IlInjected.Token(Token = "0x4004B9C")]
	public const short ChocolateChipCookie = 4017;

	[Cpp2IlInjected.Token(Token = "0x4004B9D")]
	public const short CreamSoda = 4018;

	[Cpp2IlInjected.Token(Token = "0x4004B9E")]
	public const short Escargot = 4019;

	[Cpp2IlInjected.Token(Token = "0x4004B9F")]
	public const short FriedEgg = 4020;

	[Cpp2IlInjected.Token(Token = "0x4004BA0")]
	public const short Fries = 4021;

	[Cpp2IlInjected.Token(Token = "0x4004BA1")]
	public const short GoldenDelight = 4022;

	[Cpp2IlInjected.Token(Token = "0x4004BA2")]
	public const short Grapes = 4023;

	[Cpp2IlInjected.Token(Token = "0x4004BA3")]
	public const short GrilledSquirrel = 4024;

	[Cpp2IlInjected.Token(Token = "0x4004BA4")]
	public const short Hotdog = 4025;

	[Cpp2IlInjected.Token(Token = "0x4004BA5")]
	public const short IceCream = 4026;

	[Cpp2IlInjected.Token(Token = "0x4004BA6")]
	public const short Milkshake = 4027;

	[Cpp2IlInjected.Token(Token = "0x4004BA7")]
	public const short Nachos = 4028;

	[Cpp2IlInjected.Token(Token = "0x4004BA8")]
	public const short Pizza = 4029;

	[Cpp2IlInjected.Token(Token = "0x4004BA9")]
	public const short PotatoChips = 4030;

	[Cpp2IlInjected.Token(Token = "0x4004BAA")]
	public const short RoastedBird = 4031;

	[Cpp2IlInjected.Token(Token = "0x4004BAB")]
	public const short RoastedDuck = 4032;

	[Cpp2IlInjected.Token(Token = "0x4004BAC")]
	public const short SauteedFrogLegs = 4033;

	[Cpp2IlInjected.Token(Token = "0x4004BAD")]
	public const short SeafoodDinner = 4034;

	[Cpp2IlInjected.Token(Token = "0x4004BAE")]
	public const short ShrimpPoBoy = 4035;

	[Cpp2IlInjected.Token(Token = "0x4004BAF")]
	public const short Spaghetti = 4036;

	[Cpp2IlInjected.Token(Token = "0x4004BB0")]
	public const short Steak = 4037;

	[Cpp2IlInjected.Token(Token = "0x4004BB1")]
	public const short MoltenCharm = 4038;

	[Cpp2IlInjected.Token(Token = "0x4004BB2")]
	public const short GolfClubIron = 4039;

	[Cpp2IlInjected.Token(Token = "0x4004BB3")]
	public const short GolfCup = 4040;

	[Cpp2IlInjected.Token(Token = "0x4004BB4")]
	public const short FlowerPacketBlue = 4041;

	[Cpp2IlInjected.Token(Token = "0x4004BB5")]
	public const short FlowerPacketMagenta = 4042;

	[Cpp2IlInjected.Token(Token = "0x4004BB6")]
	public const short FlowerPacketPink = 4043;

	[Cpp2IlInjected.Token(Token = "0x4004BB7")]
	public const short FlowerPacketRed = 4044;

	[Cpp2IlInjected.Token(Token = "0x4004BB8")]
	public const short FlowerPacketYellow = 4045;

	[Cpp2IlInjected.Token(Token = "0x4004BB9")]
	public const short FlowerPacketViolet = 4046;

	[Cpp2IlInjected.Token(Token = "0x4004BBA")]
	public const short FlowerPacketWhite = 4047;

	[Cpp2IlInjected.Token(Token = "0x4004BBB")]
	public const short FlowerPacketTallGrass = 4048;

	[Cpp2IlInjected.Token(Token = "0x4004BBC")]
	public const short LawnMower = 4049;

	[Cpp2IlInjected.Token(Token = "0x4004BBD")]
	public const short CrimstoneBrick = 4050;

	[Cpp2IlInjected.Token(Token = "0x4004BBE")]
	public const short SmoothSandstone = 4051;

	[Cpp2IlInjected.Token(Token = "0x4004BBF")]
	public const short CrimstoneBrickWall = 4052;

	[Cpp2IlInjected.Token(Token = "0x4004BC0")]
	public const short SmoothSandstoneWall = 4053;

	[Cpp2IlInjected.Token(Token = "0x4004BC1")]
	public const short BloodMoonMonolith = 4054;

	[Cpp2IlInjected.Token(Token = "0x4004BC2")]
	public const short SandBoots = 4055;

	[Cpp2IlInjected.Token(Token = "0x4004BC3")]
	public const short AncientChisel = 4056;

	[Cpp2IlInjected.Token(Token = "0x4004BC4")]
	public const short CarbonGuitar = 4057;

	[Cpp2IlInjected.Token(Token = "0x4004BC5")]
	public const short SkeletonBow = 4058;

	[Cpp2IlInjected.Token(Token = "0x4004BC6")]
	public const short FossilPickaxe = 4059;

	[Cpp2IlInjected.Token(Token = "0x4004BC7")]
	public const short SuperStarCannon = 4060;

	[Cpp2IlInjected.Token(Token = "0x4004BC8")]
	public const short ThunderSpear = 4061;

	[Cpp2IlInjected.Token(Token = "0x4004BC9")]
	public const short ThunderStaff = 4062;

	[Cpp2IlInjected.Token(Token = "0x4004BCA")]
	public const short DrumSet = 4063;

	[Cpp2IlInjected.Token(Token = "0x4004BCB")]
	public const short PicnicTable = 4064;

	[Cpp2IlInjected.Token(Token = "0x4004BCC")]
	public const short PicnicTableWithCloth = 4065;

	[Cpp2IlInjected.Token(Token = "0x4004BCD")]
	public const short DesertMinecart = 4066;

	[Cpp2IlInjected.Token(Token = "0x4004BCE")]
	public const short FishMinecart = 4067;

	[Cpp2IlInjected.Token(Token = "0x4004BCF")]
	public const short FairyCritterPink = 4068;

	[Cpp2IlInjected.Token(Token = "0x4004BD0")]
	public const short FairyCritterGreen = 4069;

	[Cpp2IlInjected.Token(Token = "0x4004BD1")]
	public const short FairyCritterBlue = 4070;

	[Cpp2IlInjected.Token(Token = "0x4004BD2")]
	public const short JunoniaShell = 4071;

	[Cpp2IlInjected.Token(Token = "0x4004BD3")]
	public const short LightningWhelkShell = 4072;

	[Cpp2IlInjected.Token(Token = "0x4004BD4")]
	public const short TulipShell = 4073;

	[Cpp2IlInjected.Token(Token = "0x4004BD5")]
	public const short PinWheel = 4074;

	[Cpp2IlInjected.Token(Token = "0x4004BD6")]
	public const short WeatherVane = 4075;

	[Cpp2IlInjected.Token(Token = "0x4004BD7")]
	public const short VoidVault = 4076;

	[Cpp2IlInjected.Token(Token = "0x4004BD8")]
	public const short MusicBoxOceanAlt = 4077;

	[Cpp2IlInjected.Token(Token = "0x4004BD9")]
	public const short MusicBoxSlimeRain = 4078;

	[Cpp2IlInjected.Token(Token = "0x4004BDA")]
	public const short MusicBoxSpaceAlt = 4079;

	[Cpp2IlInjected.Token(Token = "0x4004BDB")]
	public const short MusicBoxTownDay = 4080;

	[Cpp2IlInjected.Token(Token = "0x4004BDC")]
	public const short MusicBoxTownNight = 4081;

	[Cpp2IlInjected.Token(Token = "0x4004BDD")]
	public const short MusicBoxWindyDay = 4082;

	[Cpp2IlInjected.Token(Token = "0x4004BDE")]
	public const short GolfCupFlagWhite = 4083;

	[Cpp2IlInjected.Token(Token = "0x4004BDF")]
	public const short GolfCupFlagRed = 4084;

	[Cpp2IlInjected.Token(Token = "0x4004BE0")]
	public const short GolfCupFlagGreen = 4085;

	[Cpp2IlInjected.Token(Token = "0x4004BE1")]
	public const short GolfCupFlagBlue = 4086;

	[Cpp2IlInjected.Token(Token = "0x4004BE2")]
	public const short GolfCupFlagYellow = 4087;

	[Cpp2IlInjected.Token(Token = "0x4004BE3")]
	public const short GolfCupFlagPurple = 4088;

	[Cpp2IlInjected.Token(Token = "0x4004BE4")]
	public const short GolfTee = 4089;

	[Cpp2IlInjected.Token(Token = "0x4004BE5")]
	public const short ShellPileBlock = 4090;

	[Cpp2IlInjected.Token(Token = "0x4004BE6")]
	public const short AntiPortalBlock = 4091;

	[Cpp2IlInjected.Token(Token = "0x4004BE7")]
	public const short GolfClubPutter = 4092;

	[Cpp2IlInjected.Token(Token = "0x4004BE8")]
	public const short GolfClubWedge = 4093;

	[Cpp2IlInjected.Token(Token = "0x4004BE9")]
	public const short GolfClubDriver = 4094;

	[Cpp2IlInjected.Token(Token = "0x4004BEA")]
	public const short GolfWhistle = 4095;

	[Cpp2IlInjected.Token(Token = "0x4004BEB")]
	public const short ToiletEbonyWood = 4096;

	[Cpp2IlInjected.Token(Token = "0x4004BEC")]
	public const short ToiletRichMahogany = 4097;

	[Cpp2IlInjected.Token(Token = "0x4004BED")]
	public const short ToiletPearlwood = 4098;

	[Cpp2IlInjected.Token(Token = "0x4004BEE")]
	public const short ToiletLivingWood = 4099;

	[Cpp2IlInjected.Token(Token = "0x4004BEF")]
	public const short ToiletCactus = 4100;

	[Cpp2IlInjected.Token(Token = "0x4004BF0")]
	public const short ToiletBone = 4101;

	[Cpp2IlInjected.Token(Token = "0x4004BF1")]
	public const short ToiletFlesh = 4102;

	[Cpp2IlInjected.Token(Token = "0x4004BF2")]
	public const short ToiletMushroom = 4103;

	[Cpp2IlInjected.Token(Token = "0x4004BF3")]
	public const short ToiletSunplate = 4104;

	[Cpp2IlInjected.Token(Token = "0x4004BF4")]
	public const short ToiletShadewood = 4105;

	[Cpp2IlInjected.Token(Token = "0x4004BF5")]
	public const short ToiletLihzhard = 4106;

	[Cpp2IlInjected.Token(Token = "0x4004BF6")]
	public const short ToiletDungeonBlue = 4107;

	[Cpp2IlInjected.Token(Token = "0x4004BF7")]
	public const short ToiletDungeonGreen = 4108;

	[Cpp2IlInjected.Token(Token = "0x4004BF8")]
	public const short ToiletDungeonPink = 4109;

	[Cpp2IlInjected.Token(Token = "0x4004BF9")]
	public const short ToiletObsidian = 4110;

	[Cpp2IlInjected.Token(Token = "0x4004BFA")]
	public const short ToiletFrozen = 4111;

	[Cpp2IlInjected.Token(Token = "0x4004BFB")]
	public const short ToiletGlass = 4112;

	[Cpp2IlInjected.Token(Token = "0x4004BFC")]
	public const short ToiletHoney = 4113;

	[Cpp2IlInjected.Token(Token = "0x4004BFD")]
	public const short ToiletSteampunk = 4114;

	[Cpp2IlInjected.Token(Token = "0x4004BFE")]
	public const short ToiletPumpkin = 4115;

	[Cpp2IlInjected.Token(Token = "0x4004BFF")]
	public const short ToiletSpooky = 4116;

	[Cpp2IlInjected.Token(Token = "0x4004C00")]
	public const short ToiletDynasty = 4117;

	[Cpp2IlInjected.Token(Token = "0x4004C01")]
	public const short ToiletPalm = 4118;

	[Cpp2IlInjected.Token(Token = "0x4004C02")]
	public const short ToiletBoreal = 4119;

	[Cpp2IlInjected.Token(Token = "0x4004C03")]
	public const short ToiletSlime = 4120;

	[Cpp2IlInjected.Token(Token = "0x4004C04")]
	public const short ToiletMartian = 4121;

	[Cpp2IlInjected.Token(Token = "0x4004C05")]
	public const short ToiletGranite = 4122;

	[Cpp2IlInjected.Token(Token = "0x4004C06")]
	public const short ToiletMarble = 4123;

	[Cpp2IlInjected.Token(Token = "0x4004C07")]
	public const short ToiletCrystal = 4124;

	[Cpp2IlInjected.Token(Token = "0x4004C08")]
	public const short ToiletSpider = 4125;

	[Cpp2IlInjected.Token(Token = "0x4004C09")]
	public const short ToiletLesion = 4126;

	[Cpp2IlInjected.Token(Token = "0x4004C0A")]
	public const short ToiletDiamond = 4127;

	[Cpp2IlInjected.Token(Token = "0x4004C0B")]
	public const short MaidHead = 4128;

	[Cpp2IlInjected.Token(Token = "0x4004C0C")]
	public const short MaidShirt = 4129;

	[Cpp2IlInjected.Token(Token = "0x4004C0D")]
	public const short MaidPants = 4130;

	[Cpp2IlInjected.Token(Token = "0x4004C0E")]
	public const short VoidLens = 4131;

	[Cpp2IlInjected.Token(Token = "0x4004C0F")]
	public const short MaidHead2 = 4132;

	[Cpp2IlInjected.Token(Token = "0x4004C10")]
	public const short MaidShirt2 = 4133;

	[Cpp2IlInjected.Token(Token = "0x4004C11")]
	public const short MaidPants2 = 4134;

	[Cpp2IlInjected.Token(Token = "0x4004C12")]
	public const short GolfHat = 4135;

	[Cpp2IlInjected.Token(Token = "0x4004C13")]
	public const short GolfShirt = 4136;

	[Cpp2IlInjected.Token(Token = "0x4004C14")]
	public const short GolfPants = 4137;

	[Cpp2IlInjected.Token(Token = "0x4004C15")]
	public const short GolfVisor = 4138;

	[Cpp2IlInjected.Token(Token = "0x4004C16")]
	public const short SpiderBlock = 4139;

	[Cpp2IlInjected.Token(Token = "0x4004C17")]
	public const short SpiderWall = 4140;

	[Cpp2IlInjected.Token(Token = "0x4004C18")]
	public const short ToiletMeteor = 4141;

	[Cpp2IlInjected.Token(Token = "0x4004C19")]
	public const short LesionStation = 4142;

	[Cpp2IlInjected.Token(Token = "0x4004C1A")]
	public const short ManaCloakStar = 4143;

	[Cpp2IlInjected.Token(Token = "0x4004C1B")]
	public const short Terragrim = 4144;

	[Cpp2IlInjected.Token(Token = "0x4004C1C")]
	public const short SolarBathtub = 4145;

	[Cpp2IlInjected.Token(Token = "0x4004C1D")]
	public const short SolarBed = 4146;

	[Cpp2IlInjected.Token(Token = "0x4004C1E")]
	public const short SolarBookcase = 4147;

	[Cpp2IlInjected.Token(Token = "0x4004C1F")]
	public const short SolarDresser = 4148;

	[Cpp2IlInjected.Token(Token = "0x4004C20")]
	public const short SolarCandelabra = 4149;

	[Cpp2IlInjected.Token(Token = "0x4004C21")]
	public const short SolarCandle = 4150;

	[Cpp2IlInjected.Token(Token = "0x4004C22")]
	public const short SolarChair = 4151;

	[Cpp2IlInjected.Token(Token = "0x4004C23")]
	public const short SolarChandelier = 4152;

	[Cpp2IlInjected.Token(Token = "0x4004C24")]
	public const short SolarChest = 4153;

	[Cpp2IlInjected.Token(Token = "0x4004C25")]
	public const short SolarClock = 4154;

	[Cpp2IlInjected.Token(Token = "0x4004C26")]
	public const short SolarDoor = 4155;

	[Cpp2IlInjected.Token(Token = "0x4004C27")]
	public const short SolarLamp = 4156;

	[Cpp2IlInjected.Token(Token = "0x4004C28")]
	public const short SolarLantern = 4157;

	[Cpp2IlInjected.Token(Token = "0x4004C29")]
	public const short SolarPiano = 4158;

	[Cpp2IlInjected.Token(Token = "0x4004C2A")]
	public const short SolarPlatform = 4159;

	[Cpp2IlInjected.Token(Token = "0x4004C2B")]
	public const short SolarSink = 4160;

	[Cpp2IlInjected.Token(Token = "0x4004C2C")]
	public const short SolarSofa = 4161;

	[Cpp2IlInjected.Token(Token = "0x4004C2D")]
	public const short SolarTable = 4162;

	[Cpp2IlInjected.Token(Token = "0x4004C2E")]
	public const short SolarWorkbench = 4163;

	[Cpp2IlInjected.Token(Token = "0x4004C2F")]
	public const short Fake_SolarChest = 4164;

	[Cpp2IlInjected.Token(Token = "0x4004C30")]
	public const short SolarToilet = 4165;

	[Cpp2IlInjected.Token(Token = "0x4004C31")]
	public const short VortexBathtub = 4166;

	[Cpp2IlInjected.Token(Token = "0x4004C32")]
	public const short VortexBed = 4167;

	[Cpp2IlInjected.Token(Token = "0x4004C33")]
	public const short VortexBookcase = 4168;

	[Cpp2IlInjected.Token(Token = "0x4004C34")]
	public const short VortexDresser = 4169;

	[Cpp2IlInjected.Token(Token = "0x4004C35")]
	public const short VortexCandelabra = 4170;

	[Cpp2IlInjected.Token(Token = "0x4004C36")]
	public const short VortexCandle = 4171;

	[Cpp2IlInjected.Token(Token = "0x4004C37")]
	public const short VortexChair = 4172;

	[Cpp2IlInjected.Token(Token = "0x4004C38")]
	public const short VortexChandelier = 4173;

	[Cpp2IlInjected.Token(Token = "0x4004C39")]
	public const short VortexChest = 4174;

	[Cpp2IlInjected.Token(Token = "0x4004C3A")]
	public const short VortexClock = 4175;

	[Cpp2IlInjected.Token(Token = "0x4004C3B")]
	public const short VortexDoor = 4176;

	[Cpp2IlInjected.Token(Token = "0x4004C3C")]
	public const short VortexLamp = 4177;

	[Cpp2IlInjected.Token(Token = "0x4004C3D")]
	public const short VortexLantern = 4178;

	[Cpp2IlInjected.Token(Token = "0x4004C3E")]
	public const short VortexPiano = 4179;

	[Cpp2IlInjected.Token(Token = "0x4004C3F")]
	public const short VortexPlatform = 4180;

	[Cpp2IlInjected.Token(Token = "0x4004C40")]
	public const short VortexSink = 4181;

	[Cpp2IlInjected.Token(Token = "0x4004C41")]
	public const short VortexSofa = 4182;

	[Cpp2IlInjected.Token(Token = "0x4004C42")]
	public const short VortexTable = 4183;

	[Cpp2IlInjected.Token(Token = "0x4004C43")]
	public const short VortexWorkbench = 4184;

	[Cpp2IlInjected.Token(Token = "0x4004C44")]
	public const short Fake_VortexChest = 4185;

	[Cpp2IlInjected.Token(Token = "0x4004C45")]
	public const short VortexToilet = 4186;

	[Cpp2IlInjected.Token(Token = "0x4004C46")]
	public const short NebulaBathtub = 4187;

	[Cpp2IlInjected.Token(Token = "0x4004C47")]
	public const short NebulaBed = 4188;

	[Cpp2IlInjected.Token(Token = "0x4004C48")]
	public const short NebulaBookcase = 4189;

	[Cpp2IlInjected.Token(Token = "0x4004C49")]
	public const short NebulaDresser = 4190;

	[Cpp2IlInjected.Token(Token = "0x4004C4A")]
	public const short NebulaCandelabra = 4191;

	[Cpp2IlInjected.Token(Token = "0x4004C4B")]
	public const short NebulaCandle = 4192;

	[Cpp2IlInjected.Token(Token = "0x4004C4C")]
	public const short NebulaChair = 4193;

	[Cpp2IlInjected.Token(Token = "0x4004C4D")]
	public const short NebulaChandelier = 4194;

	[Cpp2IlInjected.Token(Token = "0x4004C4E")]
	public const short NebulaChest = 4195;

	[Cpp2IlInjected.Token(Token = "0x4004C4F")]
	public const short NebulaClock = 4196;

	[Cpp2IlInjected.Token(Token = "0x4004C50")]
	public const short NebulaDoor = 4197;

	[Cpp2IlInjected.Token(Token = "0x4004C51")]
	public const short NebulaLamp = 4198;

	[Cpp2IlInjected.Token(Token = "0x4004C52")]
	public const short NebulaLantern = 4199;

	[Cpp2IlInjected.Token(Token = "0x4004C53")]
	public const short NebulaPiano = 4200;

	[Cpp2IlInjected.Token(Token = "0x4004C54")]
	public const short NebulaPlatform = 4201;

	[Cpp2IlInjected.Token(Token = "0x4004C55")]
	public const short NebulaSink = 4202;

	[Cpp2IlInjected.Token(Token = "0x4004C56")]
	public const short NebulaSofa = 4203;

	[Cpp2IlInjected.Token(Token = "0x4004C57")]
	public const short NebulaTable = 4204;

	[Cpp2IlInjected.Token(Token = "0x4004C58")]
	public const short NebulaWorkbench = 4205;

	[Cpp2IlInjected.Token(Token = "0x4004C59")]
	public const short Fake_NebulaChest = 4206;

	[Cpp2IlInjected.Token(Token = "0x4004C5A")]
	public const short NebulaToilet = 4207;

	[Cpp2IlInjected.Token(Token = "0x4004C5B")]
	public const short StardustBathtub = 4208;

	[Cpp2IlInjected.Token(Token = "0x4004C5C")]
	public const short StardustBed = 4209;

	[Cpp2IlInjected.Token(Token = "0x4004C5D")]
	public const short StardustBookcase = 4210;

	[Cpp2IlInjected.Token(Token = "0x4004C5E")]
	public const short StardustDresser = 4211;

	[Cpp2IlInjected.Token(Token = "0x4004C5F")]
	public const short StardustCandelabra = 4212;

	[Cpp2IlInjected.Token(Token = "0x4004C60")]
	public const short StardustCandle = 4213;

	[Cpp2IlInjected.Token(Token = "0x4004C61")]
	public const short StardustChair = 4214;

	[Cpp2IlInjected.Token(Token = "0x4004C62")]
	public const short StardustChandelier = 4215;

	[Cpp2IlInjected.Token(Token = "0x4004C63")]
	public const short StardustChest = 4216;

	[Cpp2IlInjected.Token(Token = "0x4004C64")]
	public const short StardustClock = 4217;

	[Cpp2IlInjected.Token(Token = "0x4004C65")]
	public const short StardustDoor = 4218;

	[Cpp2IlInjected.Token(Token = "0x4004C66")]
	public const short StardustLamp = 4219;

	[Cpp2IlInjected.Token(Token = "0x4004C67")]
	public const short StardustLantern = 4220;

	[Cpp2IlInjected.Token(Token = "0x4004C68")]
	public const short StardustPiano = 4221;

	[Cpp2IlInjected.Token(Token = "0x4004C69")]
	public const short StardustPlatform = 4222;

	[Cpp2IlInjected.Token(Token = "0x4004C6A")]
	public const short StardustSink = 4223;

	[Cpp2IlInjected.Token(Token = "0x4004C6B")]
	public const short StardustSofa = 4224;

	[Cpp2IlInjected.Token(Token = "0x4004C6C")]
	public const short StardustTable = 4225;

	[Cpp2IlInjected.Token(Token = "0x4004C6D")]
	public const short StardustWorkbench = 4226;

	[Cpp2IlInjected.Token(Token = "0x4004C6E")]
	public const short Fake_StardustChest = 4227;

	[Cpp2IlInjected.Token(Token = "0x4004C6F")]
	public const short StardustToilet = 4228;

	[Cpp2IlInjected.Token(Token = "0x4004C70")]
	public const short SolarBrick = 4229;

	[Cpp2IlInjected.Token(Token = "0x4004C71")]
	public const short VortexBrick = 4230;

	[Cpp2IlInjected.Token(Token = "0x4004C72")]
	public const short NebulaBrick = 4231;

	[Cpp2IlInjected.Token(Token = "0x4004C73")]
	public const short StardustBrick = 4232;

	[Cpp2IlInjected.Token(Token = "0x4004C74")]
	public const short SolarBrickWall = 4233;

	[Cpp2IlInjected.Token(Token = "0x4004C75")]
	public const short VortexBrickWall = 4234;

	[Cpp2IlInjected.Token(Token = "0x4004C76")]
	public const short NebulaBrickWall = 4235;

	[Cpp2IlInjected.Token(Token = "0x4004C77")]
	public const short StardustBrickWall = 4236;

	[Cpp2IlInjected.Token(Token = "0x4004C78")]
	public const short MusicBoxDayRemix = 4237;

	[Cpp2IlInjected.Token(Token = "0x4004C79")]
	public const short CrackedBlueBrick = 4238;

	[Cpp2IlInjected.Token(Token = "0x4004C7A")]
	public const short CrackedGreenBrick = 4239;

	[Cpp2IlInjected.Token(Token = "0x4004C7B")]
	public const short CrackedPinkBrick = 4240;

	[Cpp2IlInjected.Token(Token = "0x4004C7C")]
	public const short FlowerPacketWild = 4241;

	[Cpp2IlInjected.Token(Token = "0x4004C7D")]
	public const short GolfBallDyedBlack = 4242;

	[Cpp2IlInjected.Token(Token = "0x4004C7E")]
	public const short GolfBallDyedBlue = 4243;

	[Cpp2IlInjected.Token(Token = "0x4004C7F")]
	public const short GolfBallDyedBrown = 4244;

	[Cpp2IlInjected.Token(Token = "0x4004C80")]
	public const short GolfBallDyedCyan = 4245;

	[Cpp2IlInjected.Token(Token = "0x4004C81")]
	public const short GolfBallDyedGreen = 4246;

	[Cpp2IlInjected.Token(Token = "0x4004C82")]
	public const short GolfBallDyedLimeGreen = 4247;

	[Cpp2IlInjected.Token(Token = "0x4004C83")]
	public const short GolfBallDyedOrange = 4248;

	[Cpp2IlInjected.Token(Token = "0x4004C84")]
	public const short GolfBallDyedPink = 4249;

	[Cpp2IlInjected.Token(Token = "0x4004C85")]
	public const short GolfBallDyedPurple = 4250;

	[Cpp2IlInjected.Token(Token = "0x4004C86")]
	public const short GolfBallDyedRed = 4251;

	[Cpp2IlInjected.Token(Token = "0x4004C87")]
	public const short GolfBallDyedSkyBlue = 4252;

	[Cpp2IlInjected.Token(Token = "0x4004C88")]
	public const short GolfBallDyedTeal = 4253;

	[Cpp2IlInjected.Token(Token = "0x4004C89")]
	public const short GolfBallDyedViolet = 4254;

	[Cpp2IlInjected.Token(Token = "0x4004C8A")]
	public const short GolfBallDyedYellow = 4255;

	[Cpp2IlInjected.Token(Token = "0x4004C8B")]
	public const short AmberRobe = 4256;

	[Cpp2IlInjected.Token(Token = "0x4004C8C")]
	public const short AmberHook = 4257;

	[Cpp2IlInjected.Token(Token = "0x4004C8D")]
	public const short OrangePhaseblade = 4258;

	[Cpp2IlInjected.Token(Token = "0x4004C8E")]
	public const short OrangePhasesaber = 4259;

	[Cpp2IlInjected.Token(Token = "0x4004C8F")]
	public const short OrangeStainedGlass = 4260;

	[Cpp2IlInjected.Token(Token = "0x4004C90")]
	public const short OrangePressurePlate = 4261;

	[Cpp2IlInjected.Token(Token = "0x4004C91")]
	public const short MysticCoilSnake = 4262;

	[Cpp2IlInjected.Token(Token = "0x4004C92")]
	public const short MagicConch = 4263;

	[Cpp2IlInjected.Token(Token = "0x4004C93")]
	public const short GolfCart = 4264;

	[Cpp2IlInjected.Token(Token = "0x4004C94")]
	public const short GolfChest = 4265;

	[Cpp2IlInjected.Token(Token = "0x4004C95")]
	public const short Fake_GolfChest = 4266;

	[Cpp2IlInjected.Token(Token = "0x4004C96")]
	public const short DesertChest = 4267;

	[Cpp2IlInjected.Token(Token = "0x4004C97")]
	public const short Fake_DesertChest = 4268;

	[Cpp2IlInjected.Token(Token = "0x4004C98")]
	public const short SanguineStaff = 4269;

	[Cpp2IlInjected.Token(Token = "0x4004C99")]
	public const short SharpTears = 4270;

	[Cpp2IlInjected.Token(Token = "0x4004C9A")]
	public const short BloodMoonStarter = 4271;

	[Cpp2IlInjected.Token(Token = "0x4004C9B")]
	public const short DripplerFlail = 4272;

	[Cpp2IlInjected.Token(Token = "0x4004C9C")]
	public const short VampireFrogStaff = 4273;

	[Cpp2IlInjected.Token(Token = "0x4004C9D")]
	public const short GoldGoldfish = 4274;

	[Cpp2IlInjected.Token(Token = "0x4004C9E")]
	public const short GoldGoldfishBowl = 4275;

	[Cpp2IlInjected.Token(Token = "0x4004C9F")]
	public const short CatBast = 4276;

	[Cpp2IlInjected.Token(Token = "0x4004CA0")]
	public const short GoldStarryGlassBlock = 4277;

	[Cpp2IlInjected.Token(Token = "0x4004CA1")]
	public const short BlueStarryGlassBlock = 4278;

	[Cpp2IlInjected.Token(Token = "0x4004CA2")]
	public const short GoldStarryGlassWall = 4279;

	[Cpp2IlInjected.Token(Token = "0x4004CA3")]
	public const short BlueStarryGlassWall = 4280;

	[Cpp2IlInjected.Token(Token = "0x4004CA4")]
	public const short BabyBirdStaff = 4281;

	[Cpp2IlInjected.Token(Token = "0x4004CA5")]
	public const short Apricot = 4282;

	[Cpp2IlInjected.Token(Token = "0x4004CA6")]
	public const short Banana = 4283;

	[Cpp2IlInjected.Token(Token = "0x4004CA7")]
	public const short BlackCurrant = 4284;

	[Cpp2IlInjected.Token(Token = "0x4004CA8")]
	public const short BloodOrange = 4285;

	[Cpp2IlInjected.Token(Token = "0x4004CA9")]
	public const short Cherry = 4286;

	[Cpp2IlInjected.Token(Token = "0x4004CAA")]
	public const short Coconut = 4287;

	[Cpp2IlInjected.Token(Token = "0x4004CAB")]
	public const short Dragonfruit = 4288;

	[Cpp2IlInjected.Token(Token = "0x4004CAC")]
	public const short Elderberry = 4289;

	[Cpp2IlInjected.Token(Token = "0x4004CAD")]
	public const short Grapefruit = 4290;

	[Cpp2IlInjected.Token(Token = "0x4004CAE")]
	public const short Lemon = 4291;

	[Cpp2IlInjected.Token(Token = "0x4004CAF")]
	public const short Mango = 4292;

	[Cpp2IlInjected.Token(Token = "0x4004CB0")]
	public const short Peach = 4293;

	[Cpp2IlInjected.Token(Token = "0x4004CB1")]
	public const short Pineapple = 4294;

	[Cpp2IlInjected.Token(Token = "0x4004CB2")]
	public const short Plum = 4295;

	[Cpp2IlInjected.Token(Token = "0x4004CB3")]
	public const short Rambutan = 4296;

	[Cpp2IlInjected.Token(Token = "0x4004CB4")]
	public const short Starfruit = 4297;

	[Cpp2IlInjected.Token(Token = "0x4004CB5")]
	public const short SandstoneBathtub = 4298;

	[Cpp2IlInjected.Token(Token = "0x4004CB6")]
	public const short SandstoneBed = 4299;

	[Cpp2IlInjected.Token(Token = "0x4004CB7")]
	public const short SandstoneBookcase = 4300;

	[Cpp2IlInjected.Token(Token = "0x4004CB8")]
	public const short SandstoneDresser = 4301;

	[Cpp2IlInjected.Token(Token = "0x4004CB9")]
	public const short SandstoneCandelabra = 4302;

	[Cpp2IlInjected.Token(Token = "0x4004CBA")]
	public const short SandstoneCandle = 4303;

	[Cpp2IlInjected.Token(Token = "0x4004CBB")]
	public const short SandstoneChair = 4304;

	[Cpp2IlInjected.Token(Token = "0x4004CBC")]
	public const short SandstoneChandelier = 4305;

	[Cpp2IlInjected.Token(Token = "0x4004CBD")]
	public const short SandstoneClock = 4306;

	[Cpp2IlInjected.Token(Token = "0x4004CBE")]
	public const short SandstoneDoor = 4307;

	[Cpp2IlInjected.Token(Token = "0x4004CBF")]
	public const short SandstoneLamp = 4308;

	[Cpp2IlInjected.Token(Token = "0x4004CC0")]
	public const short SandstoneLantern = 4309;

	[Cpp2IlInjected.Token(Token = "0x4004CC1")]
	public const short SandstonePiano = 4310;

	[Cpp2IlInjected.Token(Token = "0x4004CC2")]
	public const short SandstonePlatform = 4311;

	[Cpp2IlInjected.Token(Token = "0x4004CC3")]
	public const short SandstoneSink = 4312;

	[Cpp2IlInjected.Token(Token = "0x4004CC4")]
	public const short SandstoneSofa = 4313;

	[Cpp2IlInjected.Token(Token = "0x4004CC5")]
	public const short SandstoneTable = 4314;

	[Cpp2IlInjected.Token(Token = "0x4004CC6")]
	public const short SandstoneWorkbench = 4315;

	[Cpp2IlInjected.Token(Token = "0x4004CC7")]
	public const short SandstoneToilet = 4316;

	[Cpp2IlInjected.Token(Token = "0x4004CC8")]
	public const short BloodHamaxe = 4317;

	[Cpp2IlInjected.Token(Token = "0x4004CC9")]
	public const short VoidMonolith = 4318;

	[Cpp2IlInjected.Token(Token = "0x4004CCA")]
	public const short ArrowSign = 4319;

	[Cpp2IlInjected.Token(Token = "0x4004CCB")]
	public const short PaintedArrowSign = 4320;

	[Cpp2IlInjected.Token(Token = "0x4004CCC")]
	public const short GameMasterShirt = 4321;

	[Cpp2IlInjected.Token(Token = "0x4004CCD")]
	public const short GameMasterPants = 4322;

	[Cpp2IlInjected.Token(Token = "0x4004CCE")]
	public const short StarPrincessCrown = 4323;

	[Cpp2IlInjected.Token(Token = "0x4004CCF")]
	public const short StarPrincessDress = 4324;

	[Cpp2IlInjected.Token(Token = "0x4004CD0")]
	public const short BloodFishingRod = 4325;

	[Cpp2IlInjected.Token(Token = "0x4004CD1")]
	public const short FoodPlatter = 4326;

	[Cpp2IlInjected.Token(Token = "0x4004CD2")]
	public const short BlackDragonflyJar = 4327;

	[Cpp2IlInjected.Token(Token = "0x4004CD3")]
	public const short BlueDragonflyJar = 4328;

	[Cpp2IlInjected.Token(Token = "0x4004CD4")]
	public const short GreenDragonflyJar = 4329;

	[Cpp2IlInjected.Token(Token = "0x4004CD5")]
	public const short OrangeDragonflyJar = 4330;

	[Cpp2IlInjected.Token(Token = "0x4004CD6")]
	public const short RedDragonflyJar = 4331;

	[Cpp2IlInjected.Token(Token = "0x4004CD7")]
	public const short YellowDragonflyJar = 4332;

	[Cpp2IlInjected.Token(Token = "0x4004CD8")]
	public const short GoldDragonflyJar = 4333;

	[Cpp2IlInjected.Token(Token = "0x4004CD9")]
	public const short BlackDragonfly = 4334;

	[Cpp2IlInjected.Token(Token = "0x4004CDA")]
	public const short BlueDragonfly = 4335;

	[Cpp2IlInjected.Token(Token = "0x4004CDB")]
	public const short GreenDragonfly = 4336;

	[Cpp2IlInjected.Token(Token = "0x4004CDC")]
	public const short OrangeDragonfly = 4337;

	[Cpp2IlInjected.Token(Token = "0x4004CDD")]
	public const short RedDragonfly = 4338;

	[Cpp2IlInjected.Token(Token = "0x4004CDE")]
	public const short YellowDragonfly = 4339;

	[Cpp2IlInjected.Token(Token = "0x4004CDF")]
	public const short GoldDragonfly = 4340;

	[Cpp2IlInjected.Token(Token = "0x4004CE0")]
	public const short PortableStool = 4341;

	[Cpp2IlInjected.Token(Token = "0x4004CE1")]
	public const short DragonflyStatue = 4342;

	[Cpp2IlInjected.Token(Token = "0x4004CE2")]
	public const short PaperAirplaneA = 4343;

	[Cpp2IlInjected.Token(Token = "0x4004CE3")]
	public const short PaperAirplaneB = 4344;

	[Cpp2IlInjected.Token(Token = "0x4004CE4")]
	public const short CanOfWorms = 4345;

	[Cpp2IlInjected.Token(Token = "0x4004CE5")]
	public const short EncumberingStone = 4346;

	[Cpp2IlInjected.Token(Token = "0x4004CE6")]
	public const short ZapinatorGray = 4347;

	[Cpp2IlInjected.Token(Token = "0x4004CE7")]
	public const short ZapinatorOrange = 4348;

	[Cpp2IlInjected.Token(Token = "0x4004CE8")]
	public const short GreenMoss = 4349;

	[Cpp2IlInjected.Token(Token = "0x4004CE9")]
	public const short BrownMoss = 4350;

	[Cpp2IlInjected.Token(Token = "0x4004CEA")]
	public const short RedMoss = 4351;

	[Cpp2IlInjected.Token(Token = "0x4004CEB")]
	public const short BlueMoss = 4352;

	[Cpp2IlInjected.Token(Token = "0x4004CEC")]
	public const short PurpleMoss = 4353;

	[Cpp2IlInjected.Token(Token = "0x4004CED")]
	public const short LavaMoss = 4354;

	[Cpp2IlInjected.Token(Token = "0x4004CEE")]
	public const short BoulderStatue = 4355;

	[Cpp2IlInjected.Token(Token = "0x4004CEF")]
	public const short MusicBoxTitleAlt = 4356;

	[Cpp2IlInjected.Token(Token = "0x4004CF0")]
	public const short MusicBoxStorm = 4357;

	[Cpp2IlInjected.Token(Token = "0x4004CF1")]
	public const short MusicBoxGraveyard = 4358;

	[Cpp2IlInjected.Token(Token = "0x4004CF2")]
	public const short Seagull = 4359;

	[Cpp2IlInjected.Token(Token = "0x4004CF3")]
	public const short SeagullStatue = 4360;

	[Cpp2IlInjected.Token(Token = "0x4004CF4")]
	public const short LadyBug = 4361;

	[Cpp2IlInjected.Token(Token = "0x4004CF5")]
	public const short GoldLadyBug = 4362;

	[Cpp2IlInjected.Token(Token = "0x4004CF6")]
	public const short Maggot = 4363;

	[Cpp2IlInjected.Token(Token = "0x4004CF7")]
	public const short MaggotCage = 4364;

	[Cpp2IlInjected.Token(Token = "0x4004CF8")]
	public const short CelestialWand = 4365;

	[Cpp2IlInjected.Token(Token = "0x4004CF9")]
	public const short EucaluptusSap = 4366;

	[Cpp2IlInjected.Token(Token = "0x4004CFA")]
	public const short KiteBlue = 4367;

	[Cpp2IlInjected.Token(Token = "0x4004CFB")]
	public const short KiteBlueAndYellow = 4368;

	[Cpp2IlInjected.Token(Token = "0x4004CFC")]
	public const short KiteRed = 4369;

	[Cpp2IlInjected.Token(Token = "0x4004CFD")]
	public const short KiteRedAndYellow = 4370;

	[Cpp2IlInjected.Token(Token = "0x4004CFE")]
	public const short KiteYellow = 4371;

	[Cpp2IlInjected.Token(Token = "0x4004CFF")]
	public const short IvyGuitar = 4372;

	[Cpp2IlInjected.Token(Token = "0x4004D00")]
	public const short Pupfish = 4373;

	[Cpp2IlInjected.Token(Token = "0x4004D01")]
	public const short Grebe = 4374;

	[Cpp2IlInjected.Token(Token = "0x4004D02")]
	public const short Rat = 4375;

	[Cpp2IlInjected.Token(Token = "0x4004D03")]
	public const short RatCage = 4376;

	[Cpp2IlInjected.Token(Token = "0x4004D04")]
	public const short KryptonMoss = 4377;

	[Cpp2IlInjected.Token(Token = "0x4004D05")]
	public const short XenonMoss = 4378;

	[Cpp2IlInjected.Token(Token = "0x4004D06")]
	public const short KiteWyvern = 4379;

	[Cpp2IlInjected.Token(Token = "0x4004D07")]
	public const short LadybugCage = 4380;

	[Cpp2IlInjected.Token(Token = "0x4004D08")]
	public const short BloodRainBow = 4381;

	[Cpp2IlInjected.Token(Token = "0x4004D09")]
	public const short CombatBook = 4382;

	[Cpp2IlInjected.Token(Token = "0x4004D0A")]
	public const short DesertTorch = 4383;

	[Cpp2IlInjected.Token(Token = "0x4004D0B")]
	public const short CoralTorch = 4384;

	[Cpp2IlInjected.Token(Token = "0x4004D0C")]
	public const short CorruptTorch = 4385;

	[Cpp2IlInjected.Token(Token = "0x4004D0D")]
	public const short CrimsonTorch = 4386;

	[Cpp2IlInjected.Token(Token = "0x4004D0E")]
	public const short HallowedTorch = 4387;

	[Cpp2IlInjected.Token(Token = "0x4004D0F")]
	public const short JungleTorch = 4388;

	[Cpp2IlInjected.Token(Token = "0x4004D10")]
	public const short ArgonMoss = 4389;

	[Cpp2IlInjected.Token(Token = "0x4004D11")]
	public const short RollingCactus = 4390;

	[Cpp2IlInjected.Token(Token = "0x4004D12")]
	public const short ThinIce = 4391;

	[Cpp2IlInjected.Token(Token = "0x4004D13")]
	public const short EchoBlock = 4392;

	[Cpp2IlInjected.Token(Token = "0x4004D14")]
	public const short ScarabFish = 4393;

	[Cpp2IlInjected.Token(Token = "0x4004D15")]
	public const short ScorpioFish = 4394;

	[Cpp2IlInjected.Token(Token = "0x4004D16")]
	public const short Owl = 4395;

	[Cpp2IlInjected.Token(Token = "0x4004D17")]
	public const short OwlCage = 4396;

	[Cpp2IlInjected.Token(Token = "0x4004D18")]
	public const short OwlStatue = 4397;

	[Cpp2IlInjected.Token(Token = "0x4004D19")]
	public const short PupfishBowl = 4398;

	[Cpp2IlInjected.Token(Token = "0x4004D1A")]
	public const short GoldLadybugCage = 4399;

	[Cpp2IlInjected.Token(Token = "0x4004D1B")]
	public const short Geode = 4400;

	[Cpp2IlInjected.Token(Token = "0x4004D1C")]
	public const short Flounder = 4401;

	[Cpp2IlInjected.Token(Token = "0x4004D1D")]
	public const short RockLobster = 4402;

	[Cpp2IlInjected.Token(Token = "0x4004D1E")]
	public const short LobsterTail = 4403;

	[Cpp2IlInjected.Token(Token = "0x4004D1F")]
	public const short FloatingTube = 4404;

	[Cpp2IlInjected.Token(Token = "0x4004D20")]
	public const short FrozenCrate = 4405;

	[Cpp2IlInjected.Token(Token = "0x4004D21")]
	public const short FrozenCrateHard = 4406;

	[Cpp2IlInjected.Token(Token = "0x4004D22")]
	public const short OasisCrate = 4407;

	[Cpp2IlInjected.Token(Token = "0x4004D23")]
	public const short OasisCrateHard = 4408;

	[Cpp2IlInjected.Token(Token = "0x4004D24")]
	public const short SpectreGoggles = 4409;

	[Cpp2IlInjected.Token(Token = "0x4004D25")]
	public const short Oyster = 4410;

	[Cpp2IlInjected.Token(Token = "0x4004D26")]
	public const short ShuckedOyster = 4411;

	[Cpp2IlInjected.Token(Token = "0x4004D27")]
	public const short WhitePearl = 4412;

	[Cpp2IlInjected.Token(Token = "0x4004D28")]
	public const short BlackPearl = 4413;

	[Cpp2IlInjected.Token(Token = "0x4004D29")]
	public const short PinkPearl = 4414;

	[Cpp2IlInjected.Token(Token = "0x4004D2A")]
	public const short StoneDoor = 4415;

	[Cpp2IlInjected.Token(Token = "0x4004D2B")]
	public const short StonePlatform = 4416;

	[Cpp2IlInjected.Token(Token = "0x4004D2C")]
	public const short OasisFountain = 4417;

	[Cpp2IlInjected.Token(Token = "0x4004D2D")]
	public const short WaterStrider = 4418;

	[Cpp2IlInjected.Token(Token = "0x4004D2E")]
	public const short GoldWaterStrider = 4419;

	[Cpp2IlInjected.Token(Token = "0x4004D2F")]
	public const short LawnFlamingo = 4420;

	[Cpp2IlInjected.Token(Token = "0x4004D30")]
	public const short MusicBoxUndergroundJungle = 4421;

	[Cpp2IlInjected.Token(Token = "0x4004D31")]
	public const short Grate = 4422;

	[Cpp2IlInjected.Token(Token = "0x4004D32")]
	public const short ScarabBomb = 4423;

	[Cpp2IlInjected.Token(Token = "0x4004D33")]
	public const short WroughtIronFence = 4424;

	[Cpp2IlInjected.Token(Token = "0x4004D34")]
	public const short SharkBait = 4425;

	[Cpp2IlInjected.Token(Token = "0x4004D35")]
	public const short BeeMinecart = 4426;

	[Cpp2IlInjected.Token(Token = "0x4004D36")]
	public const short LadybugMinecart = 4427;

	[Cpp2IlInjected.Token(Token = "0x4004D37")]
	public const short PigronMinecart = 4428;

	[Cpp2IlInjected.Token(Token = "0x4004D38")]
	public const short SunflowerMinecart = 4429;

	[Cpp2IlInjected.Token(Token = "0x4004D39")]
	public const short PottedForestCedar = 4430;

	[Cpp2IlInjected.Token(Token = "0x4004D3A")]
	public const short PottedJungleCedar = 4431;

	[Cpp2IlInjected.Token(Token = "0x4004D3B")]
	public const short PottedHallowCedar = 4432;

	[Cpp2IlInjected.Token(Token = "0x4004D3C")]
	public const short PottedForestTree = 4433;

	[Cpp2IlInjected.Token(Token = "0x4004D3D")]
	public const short PottedJungleTree = 4434;

	[Cpp2IlInjected.Token(Token = "0x4004D3E")]
	public const short PottedHallowTree = 4435;

	[Cpp2IlInjected.Token(Token = "0x4004D3F")]
	public const short PottedForestPalm = 4436;

	[Cpp2IlInjected.Token(Token = "0x4004D40")]
	public const short PottedJunglePalm = 4437;

	[Cpp2IlInjected.Token(Token = "0x4004D41")]
	public const short PottedHallowPalm = 4438;

	[Cpp2IlInjected.Token(Token = "0x4004D42")]
	public const short PottedForestBamboo = 4439;

	[Cpp2IlInjected.Token(Token = "0x4004D43")]
	public const short PottedJungleBamboo = 4440;

	[Cpp2IlInjected.Token(Token = "0x4004D44")]
	public const short PottedHallowBamboo = 4441;

	[Cpp2IlInjected.Token(Token = "0x4004D45")]
	public const short ScarabFishingRod = 4442;

	[Cpp2IlInjected.Token(Token = "0x4004D46")]
	public const short HellMinecart = 4443;

	[Cpp2IlInjected.Token(Token = "0x4004D47")]
	public const short WitchBroom = 4444;

	[Cpp2IlInjected.Token(Token = "0x4004D48")]
	public const short ClusterRocketI = 4445;

	[Cpp2IlInjected.Token(Token = "0x4004D49")]
	public const short ClusterRocketII = 4446;

	[Cpp2IlInjected.Token(Token = "0x4004D4A")]
	public const short WetRocket = 4447;

	[Cpp2IlInjected.Token(Token = "0x4004D4B")]
	public const short LavaRocket = 4448;

	[Cpp2IlInjected.Token(Token = "0x4004D4C")]
	public const short HoneyRocket = 4449;

	[Cpp2IlInjected.Token(Token = "0x4004D4D")]
	public const short ShroomMinecart = 4450;

	[Cpp2IlInjected.Token(Token = "0x4004D4E")]
	public const short AmethystMinecart = 4451;

	[Cpp2IlInjected.Token(Token = "0x4004D4F")]
	public const short TopazMinecart = 4452;

	[Cpp2IlInjected.Token(Token = "0x4004D50")]
	public const short SapphireMinecart = 4453;

	[Cpp2IlInjected.Token(Token = "0x4004D51")]
	public const short EmeraldMinecart = 4454;

	[Cpp2IlInjected.Token(Token = "0x4004D52")]
	public const short RubyMinecart = 4455;

	[Cpp2IlInjected.Token(Token = "0x4004D53")]
	public const short DiamondMinecart = 4456;

	[Cpp2IlInjected.Token(Token = "0x4004D54")]
	public const short MiniNukeI = 4457;

	[Cpp2IlInjected.Token(Token = "0x4004D55")]
	public const short MiniNukeII = 4458;

	[Cpp2IlInjected.Token(Token = "0x4004D56")]
	public const short DryRocket = 4459;

	[Cpp2IlInjected.Token(Token = "0x4004D57")]
	public const short SandcastleBucket = 4460;

	[Cpp2IlInjected.Token(Token = "0x4004D58")]
	public const short TurtleCage = 4461;

	[Cpp2IlInjected.Token(Token = "0x4004D59")]
	public const short TurtleJungleCage = 4462;

	[Cpp2IlInjected.Token(Token = "0x4004D5A")]
	public const short Gladius = 4463;

	[Cpp2IlInjected.Token(Token = "0x4004D5B")]
	public const short Turtle = 4464;

	[Cpp2IlInjected.Token(Token = "0x4004D5C")]
	public const short TurtleJungle = 4465;

	[Cpp2IlInjected.Token(Token = "0x4004D5D")]
	public const short TurtleStatue = 4466;

	[Cpp2IlInjected.Token(Token = "0x4004D5E")]
	public const short AmberMinecart = 4467;

	[Cpp2IlInjected.Token(Token = "0x4004D5F")]
	public const short BeetleMinecart = 4468;

	[Cpp2IlInjected.Token(Token = "0x4004D60")]
	public const short MeowmereMinecart = 4469;

	[Cpp2IlInjected.Token(Token = "0x4004D61")]
	public const short PartyMinecart = 4470;

	[Cpp2IlInjected.Token(Token = "0x4004D62")]
	public const short PirateMinecart = 4471;

	[Cpp2IlInjected.Token(Token = "0x4004D63")]
	public const short SteampunkMinecart = 4472;

	[Cpp2IlInjected.Token(Token = "0x4004D64")]
	public const short GrebeCage = 4473;

	[Cpp2IlInjected.Token(Token = "0x4004D65")]
	public const short SeagullCage = 4474;

	[Cpp2IlInjected.Token(Token = "0x4004D66")]
	public const short WaterStriderCage = 4475;

	[Cpp2IlInjected.Token(Token = "0x4004D67")]
	public const short GoldWaterStriderCage = 4476;

	[Cpp2IlInjected.Token(Token = "0x4004D68")]
	public const short LuckPotionLesser = 4477;

	[Cpp2IlInjected.Token(Token = "0x4004D69")]
	public const short LuckPotion = 4478;

	[Cpp2IlInjected.Token(Token = "0x4004D6A")]
	public const short LuckPotionGreater = 4479;

	[Cpp2IlInjected.Token(Token = "0x4004D6B")]
	public const short Seahorse = 4480;

	[Cpp2IlInjected.Token(Token = "0x4004D6C")]
	public const short SeahorseCage = 4481;

	[Cpp2IlInjected.Token(Token = "0x4004D6D")]
	public const short GoldSeahorse = 4482;

	[Cpp2IlInjected.Token(Token = "0x4004D6E")]
	public const short GoldSeahorseCage = 4483;

	[Cpp2IlInjected.Token(Token = "0x4004D6F")]
	public const short TimerOneHalfSecond = 4484;

	[Cpp2IlInjected.Token(Token = "0x4004D70")]
	public const short TimerOneFourthSecond = 4485;

	[Cpp2IlInjected.Token(Token = "0x4004D71")]
	public const short EbonstoneEcho = 4486;

	[Cpp2IlInjected.Token(Token = "0x4004D72")]
	public const short MudWallEcho = 4487;

	[Cpp2IlInjected.Token(Token = "0x4004D73")]
	public const short PearlstoneEcho = 4488;

	[Cpp2IlInjected.Token(Token = "0x4004D74")]
	public const short SnowWallEcho = 4489;

	[Cpp2IlInjected.Token(Token = "0x4004D75")]
	public const short AmethystEcho = 4490;

	[Cpp2IlInjected.Token(Token = "0x4004D76")]
	public const short TopazEcho = 4491;

	[Cpp2IlInjected.Token(Token = "0x4004D77")]
	public const short SapphireEcho = 4492;

	[Cpp2IlInjected.Token(Token = "0x4004D78")]
	public const short EmeraldEcho = 4493;

	[Cpp2IlInjected.Token(Token = "0x4004D79")]
	public const short RubyEcho = 4494;

	[Cpp2IlInjected.Token(Token = "0x4004D7A")]
	public const short DiamondEcho = 4495;

	[Cpp2IlInjected.Token(Token = "0x4004D7B")]
	public const short Cave1Echo = 4496;

	[Cpp2IlInjected.Token(Token = "0x4004D7C")]
	public const short Cave2Echo = 4497;

	[Cpp2IlInjected.Token(Token = "0x4004D7D")]
	public const short Cave3Echo = 4498;

	[Cpp2IlInjected.Token(Token = "0x4004D7E")]
	public const short Cave4Echo = 4499;

	[Cpp2IlInjected.Token(Token = "0x4004D7F")]
	public const short Cave5Echo = 4500;

	[Cpp2IlInjected.Token(Token = "0x4004D80")]
	public const short Cave6Echo = 4501;

	[Cpp2IlInjected.Token(Token = "0x4004D81")]
	public const short Cave7Echo = 4502;

	[Cpp2IlInjected.Token(Token = "0x4004D82")]
	public const short SpiderEcho = 4503;

	[Cpp2IlInjected.Token(Token = "0x4004D83")]
	public const short CorruptGrassEcho = 4504;

	[Cpp2IlInjected.Token(Token = "0x4004D84")]
	public const short HallowedGrassEcho = 4505;

	[Cpp2IlInjected.Token(Token = "0x4004D85")]
	public const short IceEcho = 4506;

	[Cpp2IlInjected.Token(Token = "0x4004D86")]
	public const short ObsidianBackEcho = 4507;

	[Cpp2IlInjected.Token(Token = "0x4004D87")]
	public const short CrimsonGrassEcho = 4508;

	[Cpp2IlInjected.Token(Token = "0x4004D88")]
	public const short CrimstoneEcho = 4509;

	[Cpp2IlInjected.Token(Token = "0x4004D89")]
	public const short CaveWall1Echo = 4510;

	[Cpp2IlInjected.Token(Token = "0x4004D8A")]
	public const short CaveWall2Echo = 4511;

	[Cpp2IlInjected.Token(Token = "0x4004D8B")]
	public const short Cave8Echo = 4512;

	[Cpp2IlInjected.Token(Token = "0x4004D8C")]
	public const short Corruption1Echo = 4513;

	[Cpp2IlInjected.Token(Token = "0x4004D8D")]
	public const short Corruption2Echo = 4514;

	[Cpp2IlInjected.Token(Token = "0x4004D8E")]
	public const short Corruption3Echo = 4515;

	[Cpp2IlInjected.Token(Token = "0x4004D8F")]
	public const short Corruption4Echo = 4516;

	[Cpp2IlInjected.Token(Token = "0x4004D90")]
	public const short Crimson1Echo = 4517;

	[Cpp2IlInjected.Token(Token = "0x4004D91")]
	public const short Crimson2Echo = 4518;

	[Cpp2IlInjected.Token(Token = "0x4004D92")]
	public const short Crimson3Echo = 4519;

	[Cpp2IlInjected.Token(Token = "0x4004D93")]
	public const short Crimson4Echo = 4520;

	[Cpp2IlInjected.Token(Token = "0x4004D94")]
	public const short Dirt1Echo = 4521;

	[Cpp2IlInjected.Token(Token = "0x4004D95")]
	public const short Dirt2Echo = 4522;

	[Cpp2IlInjected.Token(Token = "0x4004D96")]
	public const short Dirt3Echo = 4523;

	[Cpp2IlInjected.Token(Token = "0x4004D97")]
	public const short Dirt4Echo = 4524;

	[Cpp2IlInjected.Token(Token = "0x4004D98")]
	public const short Hallow1Echo = 4525;

	[Cpp2IlInjected.Token(Token = "0x4004D99")]
	public const short Hallow2Echo = 4526;

	[Cpp2IlInjected.Token(Token = "0x4004D9A")]
	public const short Hallow3Echo = 4527;

	[Cpp2IlInjected.Token(Token = "0x4004D9B")]
	public const short Hallow4Echo = 4528;

	[Cpp2IlInjected.Token(Token = "0x4004D9C")]
	public const short Jungle1Echo = 4529;

	[Cpp2IlInjected.Token(Token = "0x4004D9D")]
	public const short Jungle2Echo = 4530;

	[Cpp2IlInjected.Token(Token = "0x4004D9E")]
	public const short Jungle3Echo = 4531;

	[Cpp2IlInjected.Token(Token = "0x4004D9F")]
	public const short Jungle4Echo = 4532;

	[Cpp2IlInjected.Token(Token = "0x4004DA0")]
	public const short Lava1Echo = 4533;

	[Cpp2IlInjected.Token(Token = "0x4004DA1")]
	public const short Lava2Echo = 4534;

	[Cpp2IlInjected.Token(Token = "0x4004DA2")]
	public const short Lava3Echo = 4535;

	[Cpp2IlInjected.Token(Token = "0x4004DA3")]
	public const short Lava4Echo = 4536;

	[Cpp2IlInjected.Token(Token = "0x4004DA4")]
	public const short Rocks1Echo = 4537;

	[Cpp2IlInjected.Token(Token = "0x4004DA5")]
	public const short Rocks2Echo = 4538;

	[Cpp2IlInjected.Token(Token = "0x4004DA6")]
	public const short Rocks3Echo = 4539;

	[Cpp2IlInjected.Token(Token = "0x4004DA7")]
	public const short Rocks4Echo = 4540;

	[Cpp2IlInjected.Token(Token = "0x4004DA8")]
	public const short TheBrideBanner = 4541;

	[Cpp2IlInjected.Token(Token = "0x4004DA9")]
	public const short ZombieMermanBanner = 4542;

	[Cpp2IlInjected.Token(Token = "0x4004DAA")]
	public const short EyeballFlyingFishBanner = 4543;

	[Cpp2IlInjected.Token(Token = "0x4004DAB")]
	public const short BloodSquidBanner = 4544;

	[Cpp2IlInjected.Token(Token = "0x4004DAC")]
	public const short BloodEelBanner = 4545;

	[Cpp2IlInjected.Token(Token = "0x4004DAD")]
	public const short GoblinSharkBanner = 4546;

	[Cpp2IlInjected.Token(Token = "0x4004DAE")]
	public const short LargeBambooBlock = 4547;

	[Cpp2IlInjected.Token(Token = "0x4004DAF")]
	public const short LargeBambooBlockWall = 4548;

	[Cpp2IlInjected.Token(Token = "0x4004DB0")]
	public const short DemonHorns = 4549;

	[Cpp2IlInjected.Token(Token = "0x4004DB1")]
	public const short BambooLeaf = 4550;

	[Cpp2IlInjected.Token(Token = "0x4004DB2")]
	public const short HellCake = 4551;

	[Cpp2IlInjected.Token(Token = "0x4004DB3")]
	public const short FogMachine = 4552;

	[Cpp2IlInjected.Token(Token = "0x4004DB4")]
	public const short PlasmaLamp = 4553;

	[Cpp2IlInjected.Token(Token = "0x4004DB5")]
	public const short MarbleColumn = 4554;

	[Cpp2IlInjected.Token(Token = "0x4004DB6")]
	public const short ChefHat = 4555;

	[Cpp2IlInjected.Token(Token = "0x4004DB7")]
	public const short ChefShirt = 4556;

	[Cpp2IlInjected.Token(Token = "0x4004DB8")]
	public const short ChefPants = 4557;

	[Cpp2IlInjected.Token(Token = "0x4004DB9")]
	public const short StarHairpin = 4558;

	[Cpp2IlInjected.Token(Token = "0x4004DBA")]
	public const short HeartHairpin = 4559;

	[Cpp2IlInjected.Token(Token = "0x4004DBB")]
	public const short BunnyEars = 4560;

	[Cpp2IlInjected.Token(Token = "0x4004DBC")]
	public const short DevilHorns = 4561;

	[Cpp2IlInjected.Token(Token = "0x4004DBD")]
	public const short Fedora = 4562;

	[Cpp2IlInjected.Token(Token = "0x4004DBE")]
	public const short UnicornHornHat = 4563;

	[Cpp2IlInjected.Token(Token = "0x4004DBF")]
	public const short BambooBlock = 4564;

	[Cpp2IlInjected.Token(Token = "0x4004DC0")]
	public const short BambooBlockWall = 4565;

	[Cpp2IlInjected.Token(Token = "0x4004DC1")]
	public const short BambooBathtub = 4566;

	[Cpp2IlInjected.Token(Token = "0x4004DC2")]
	public const short BambooBed = 4567;

	[Cpp2IlInjected.Token(Token = "0x4004DC3")]
	public const short BambooBookcase = 4568;

	[Cpp2IlInjected.Token(Token = "0x4004DC4")]
	public const short BambooDresser = 4569;

	[Cpp2IlInjected.Token(Token = "0x4004DC5")]
	public const short BambooCandelabra = 4570;

	[Cpp2IlInjected.Token(Token = "0x4004DC6")]
	public const short BambooCandle = 4571;

	[Cpp2IlInjected.Token(Token = "0x4004DC7")]
	public const short BambooChair = 4572;

	[Cpp2IlInjected.Token(Token = "0x4004DC8")]
	public const short BambooChandelier = 4573;

	[Cpp2IlInjected.Token(Token = "0x4004DC9")]
	public const short BambooChest = 4574;

	[Cpp2IlInjected.Token(Token = "0x4004DCA")]
	public const short BambooClock = 4575;

	[Cpp2IlInjected.Token(Token = "0x4004DCB")]
	public const short BambooDoor = 4576;

	[Cpp2IlInjected.Token(Token = "0x4004DCC")]
	public const short BambooLamp = 4577;

	[Cpp2IlInjected.Token(Token = "0x4004DCD")]
	public const short BambooLantern = 4578;

	[Cpp2IlInjected.Token(Token = "0x4004DCE")]
	public const short BambooPiano = 4579;

	[Cpp2IlInjected.Token(Token = "0x4004DCF")]
	public const short BambooPlatform = 4580;

	[Cpp2IlInjected.Token(Token = "0x4004DD0")]
	public const short BambooSink = 4581;

	[Cpp2IlInjected.Token(Token = "0x4004DD1")]
	public const short BambooSofa = 4582;

	[Cpp2IlInjected.Token(Token = "0x4004DD2")]
	public const short BambooTable = 4583;

	[Cpp2IlInjected.Token(Token = "0x4004DD3")]
	public const short BambooWorkbench = 4584;

	[Cpp2IlInjected.Token(Token = "0x4004DD4")]
	public const short Fake_BambooChest = 4585;

	[Cpp2IlInjected.Token(Token = "0x4004DD5")]
	public const short BambooToilet = 4586;

	[Cpp2IlInjected.Token(Token = "0x4004DD6")]
	public const short GolfClubStoneIron = 4587;

	[Cpp2IlInjected.Token(Token = "0x4004DD7")]
	public const short GolfClubRustyPutter = 4588;

	[Cpp2IlInjected.Token(Token = "0x4004DD8")]
	public const short GolfClubBronzeWedge = 4589;

	[Cpp2IlInjected.Token(Token = "0x4004DD9")]
	public const short GolfClubWoodDriver = 4590;

	[Cpp2IlInjected.Token(Token = "0x4004DDA")]
	public const short GolfClubMythrilIron = 4591;

	[Cpp2IlInjected.Token(Token = "0x4004DDB")]
	public const short GolfClubLeadPutter = 4592;

	[Cpp2IlInjected.Token(Token = "0x4004DDC")]
	public const short GolfClubGoldWedge = 4593;

	[Cpp2IlInjected.Token(Token = "0x4004DDD")]
	public const short GolfClubPearlwoodDriver = 4594;

	[Cpp2IlInjected.Token(Token = "0x4004DDE")]
	public const short GolfClubTitaniumIron = 4595;

	[Cpp2IlInjected.Token(Token = "0x4004DDF")]
	public const short GolfClubShroomitePutter = 4596;

	[Cpp2IlInjected.Token(Token = "0x4004DE0")]
	public const short GolfClubDiamondWedge = 4597;

	[Cpp2IlInjected.Token(Token = "0x4004DE1")]
	public const short GolfClubChlorophyteDriver = 4598;

	[Cpp2IlInjected.Token(Token = "0x4004DE2")]
	public const short GolfTrophyBronze = 4599;

	[Cpp2IlInjected.Token(Token = "0x4004DE3")]
	public const short GolfTrophySilver = 4600;

	[Cpp2IlInjected.Token(Token = "0x4004DE4")]
	public const short GolfTrophyGold = 4601;

	[Cpp2IlInjected.Token(Token = "0x4004DE5")]
	public const short BloodNautilusBanner = 4602;

	[Cpp2IlInjected.Token(Token = "0x4004DE6")]
	public const short BirdieRattle = 4603;

	[Cpp2IlInjected.Token(Token = "0x4004DE7")]
	public const short ExoticEasternChewToy = 4604;

	[Cpp2IlInjected.Token(Token = "0x4004DE8")]
	public const short BedazzledNectar = 4605;

	[Cpp2IlInjected.Token(Token = "0x4004DE9")]
	public const short MusicBoxJungleNight = 4606;

	[Cpp2IlInjected.Token(Token = "0x4004DEA")]
	public const short StormTigerStaff = 4607;

	[Cpp2IlInjected.Token(Token = "0x4004DEB")]
	public const short ChumBucket = 4608;

	[Cpp2IlInjected.Token(Token = "0x4004DEC")]
	public const short GardenGnome = 4609;

	[Cpp2IlInjected.Token(Token = "0x4004DED")]
	public const short KiteBoneSerpent = 4610;

	[Cpp2IlInjected.Token(Token = "0x4004DEE")]
	public const short KiteWorldFeeder = 4611;

	[Cpp2IlInjected.Token(Token = "0x4004DEF")]
	public const short KiteBunny = 4612;

	[Cpp2IlInjected.Token(Token = "0x4004DF0")]
	public const short KitePigron = 4613;

	[Cpp2IlInjected.Token(Token = "0x4004DF1")]
	public const short AppleJuice = 4614;

	[Cpp2IlInjected.Token(Token = "0x4004DF2")]
	public const short GrapeJuice = 4615;

	[Cpp2IlInjected.Token(Token = "0x4004DF3")]
	public const short Lemonade = 4616;

	[Cpp2IlInjected.Token(Token = "0x4004DF4")]
	public const short BananaDaiquiri = 4617;

	[Cpp2IlInjected.Token(Token = "0x4004DF5")]
	public const short PeachSangria = 4618;

	[Cpp2IlInjected.Token(Token = "0x4004DF6")]
	public const short PinaColada = 4619;

	[Cpp2IlInjected.Token(Token = "0x4004DF7")]
	public const short TropicalSmoothie = 4620;

	[Cpp2IlInjected.Token(Token = "0x4004DF8")]
	public const short BloodyMoscato = 4621;

	[Cpp2IlInjected.Token(Token = "0x4004DF9")]
	public const short SmoothieofDarkness = 4622;

	[Cpp2IlInjected.Token(Token = "0x4004DFA")]
	public const short PrismaticPunch = 4623;

	[Cpp2IlInjected.Token(Token = "0x4004DFB")]
	public const short FruitJuice = 4624;

	[Cpp2IlInjected.Token(Token = "0x4004DFC")]
	public const short FruitSalad = 4625;

	[Cpp2IlInjected.Token(Token = "0x4004DFD")]
	public const short AndrewSphinx = 4626;

	[Cpp2IlInjected.Token(Token = "0x4004DFE")]
	public const short WatchfulAntlion = 4627;

	[Cpp2IlInjected.Token(Token = "0x4004DFF")]
	public const short BurningSpirit = 4628;

	[Cpp2IlInjected.Token(Token = "0x4004E00")]
	public const short JawsOfDeath = 4629;

	[Cpp2IlInjected.Token(Token = "0x4004E01")]
	public const short TheSandsOfSlime = 4630;

	[Cpp2IlInjected.Token(Token = "0x4004E02")]
	public const short SnakesIHateSnakes = 4631;

	[Cpp2IlInjected.Token(Token = "0x4004E03")]
	public const short LifeAboveTheSand = 4632;

	[Cpp2IlInjected.Token(Token = "0x4004E04")]
	public const short Oasis = 4633;

	[Cpp2IlInjected.Token(Token = "0x4004E05")]
	public const short PrehistoryPreserved = 4634;

	[Cpp2IlInjected.Token(Token = "0x4004E06")]
	public const short AncientTablet = 4635;

	[Cpp2IlInjected.Token(Token = "0x4004E07")]
	public const short Uluru = 4636;

	[Cpp2IlInjected.Token(Token = "0x4004E08")]
	public const short VisitingThePyramids = 4637;

	[Cpp2IlInjected.Token(Token = "0x4004E09")]
	public const short BandageBoy = 4638;

	[Cpp2IlInjected.Token(Token = "0x4004E0A")]
	public const short DivineEye = 4639;

	[Cpp2IlInjected.Token(Token = "0x4004E0B")]
	public const short AmethystStoneBlock = 4640;

	[Cpp2IlInjected.Token(Token = "0x4004E0C")]
	public const short TopazStoneBlock = 4641;

	[Cpp2IlInjected.Token(Token = "0x4004E0D")]
	public const short SapphireStoneBlock = 4642;

	[Cpp2IlInjected.Token(Token = "0x4004E0E")]
	public const short EmeraldStoneBlock = 4643;

	[Cpp2IlInjected.Token(Token = "0x4004E0F")]
	public const short RubyStoneBlock = 4644;

	[Cpp2IlInjected.Token(Token = "0x4004E10")]
	public const short DiamondStoneBlock = 4645;

	[Cpp2IlInjected.Token(Token = "0x4004E11")]
	public const short AmberStoneBlock = 4646;

	[Cpp2IlInjected.Token(Token = "0x4004E12")]
	public const short AmberStoneWallEcho = 4647;

	[Cpp2IlInjected.Token(Token = "0x4004E13")]
	public const short KiteManEater = 4648;

	[Cpp2IlInjected.Token(Token = "0x4004E14")]
	public const short KiteJellyfishBlue = 4649;

	[Cpp2IlInjected.Token(Token = "0x4004E15")]
	public const short KiteJellyfishPink = 4650;

	[Cpp2IlInjected.Token(Token = "0x4004E16")]
	public const short KiteShark = 4651;

	[Cpp2IlInjected.Token(Token = "0x4004E17")]
	public const short SuperHeroMask = 4652;

	[Cpp2IlInjected.Token(Token = "0x4004E18")]
	public const short SuperHeroCostume = 4653;

	[Cpp2IlInjected.Token(Token = "0x4004E19")]
	public const short SuperHeroTights = 4654;

	[Cpp2IlInjected.Token(Token = "0x4004E1A")]
	public const short PinkFairyJar = 4655;

	[Cpp2IlInjected.Token(Token = "0x4004E1B")]
	public const short GreenFairyJar = 4656;

	[Cpp2IlInjected.Token(Token = "0x4004E1C")]
	public const short BlueFairyJar = 4657;

	[Cpp2IlInjected.Token(Token = "0x4004E1D")]
	public const short GolfPainting1 = 4658;

	[Cpp2IlInjected.Token(Token = "0x4004E1E")]
	public const short GolfPainting2 = 4659;

	[Cpp2IlInjected.Token(Token = "0x4004E1F")]
	public const short GolfPainting3 = 4660;

	[Cpp2IlInjected.Token(Token = "0x4004E20")]
	public const short GolfPainting4 = 4661;

	[Cpp2IlInjected.Token(Token = "0x4004E21")]
	public const short FogboundDye = 4662;

	[Cpp2IlInjected.Token(Token = "0x4004E22")]
	public const short BloodbathDye = 4663;

	[Cpp2IlInjected.Token(Token = "0x4004E23")]
	public const short PrettyPinkDressSkirt = 4664;

	[Cpp2IlInjected.Token(Token = "0x4004E24")]
	public const short PrettyPinkDressPants = 4665;

	[Cpp2IlInjected.Token(Token = "0x4004E25")]
	public const short PrettyPinkRibbon = 4666;

	[Cpp2IlInjected.Token(Token = "0x4004E26")]
	public const short BambooFence = 4667;

	[Cpp2IlInjected.Token(Token = "0x4004E27")]
	public const short GlowPaint = 4668;

	[Cpp2IlInjected.Token(Token = "0x4004E28")]
	public const short KiteSandShark = 4669;

	[Cpp2IlInjected.Token(Token = "0x4004E29")]
	public const short KiteBunnyCorrupt = 4670;

	[Cpp2IlInjected.Token(Token = "0x4004E2A")]
	public const short KiteBunnyCrimson = 4671;

	[Cpp2IlInjected.Token(Token = "0x4004E2B")]
	public const short BlandWhip = 4672;

	[Cpp2IlInjected.Token(Token = "0x4004E2C")]
	public const short DrumStick = 4673;

	[Cpp2IlInjected.Token(Token = "0x4004E2D")]
	public const short KiteGoldfish = 4674;

	[Cpp2IlInjected.Token(Token = "0x4004E2E")]
	public const short KiteAngryTrapper = 4675;

	[Cpp2IlInjected.Token(Token = "0x4004E2F")]
	public const short KiteKoi = 4676;

	[Cpp2IlInjected.Token(Token = "0x4004E30")]
	public const short KiteCrawltipede = 4677;

	[Cpp2IlInjected.Token(Token = "0x4004E31")]
	public const short SwordWhip = 4678;

	[Cpp2IlInjected.Token(Token = "0x4004E32")]
	public const short MaceWhip = 4679;

	[Cpp2IlInjected.Token(Token = "0x4004E33")]
	public const short ScytheWhip = 4680;

	[Cpp2IlInjected.Token(Token = "0x4004E34")]
	public const short KiteSpectrum = 4681;

	[Cpp2IlInjected.Token(Token = "0x4004E35")]
	public const short ReleaseDoves = 4682;

	[Cpp2IlInjected.Token(Token = "0x4004E36")]
	public const short KiteWanderingEye = 4683;

	[Cpp2IlInjected.Token(Token = "0x4004E37")]
	public const short KiteUnicorn = 4684;

	[Cpp2IlInjected.Token(Token = "0x4004E38")]
	public const short UndertakerHat = 4685;

	[Cpp2IlInjected.Token(Token = "0x4004E39")]
	public const short UndertakerCoat = 4686;

	[Cpp2IlInjected.Token(Token = "0x4004E3A")]
	public const short DandelionBanner = 4687;

	[Cpp2IlInjected.Token(Token = "0x4004E3B")]
	public const short GnomeBanner = 4688;

	[Cpp2IlInjected.Token(Token = "0x4004E3C")]
	public const short DesertCampfire = 4689;

	[Cpp2IlInjected.Token(Token = "0x4004E3D")]
	public const short CoralCampfire = 4690;

	[Cpp2IlInjected.Token(Token = "0x4004E3E")]
	public const short CorruptCampfire = 4691;

	[Cpp2IlInjected.Token(Token = "0x4004E3F")]
	public const short CrimsonCampfire = 4692;

	[Cpp2IlInjected.Token(Token = "0x4004E40")]
	public const short HallowedCampfire = 4693;

	[Cpp2IlInjected.Token(Token = "0x4004E41")]
	public const short JungleCampfire = 4694;

	[Cpp2IlInjected.Token(Token = "0x4004E42")]
	public const short SoulBottleLight = 4695;

	[Cpp2IlInjected.Token(Token = "0x4004E43")]
	public const short SoulBottleNight = 4696;

	[Cpp2IlInjected.Token(Token = "0x4004E44")]
	public const short SoulBottleFlight = 4697;

	[Cpp2IlInjected.Token(Token = "0x4004E45")]
	public const short SoulBottleSight = 4698;

	[Cpp2IlInjected.Token(Token = "0x4004E46")]
	public const short SoulBottleMight = 4699;

	[Cpp2IlInjected.Token(Token = "0x4004E47")]
	public const short SoulBottleFright = 4700;

	[Cpp2IlInjected.Token(Token = "0x4004E48")]
	public const short MudBud = 4701;

	[Cpp2IlInjected.Token(Token = "0x4004E49")]
	public const short ReleaseLantern = 4702;

	[Cpp2IlInjected.Token(Token = "0x4004E4A")]
	public const short QuadBarrelShotgun = 4703;

	[Cpp2IlInjected.Token(Token = "0x4004E4B")]
	public const short FuneralHat = 4704;

	[Cpp2IlInjected.Token(Token = "0x4004E4C")]
	public const short FuneralCoat = 4705;

	[Cpp2IlInjected.Token(Token = "0x4004E4D")]
	public const short FuneralPants = 4706;

	[Cpp2IlInjected.Token(Token = "0x4004E4E")]
	public const short TragicUmbrella = 4707;

	[Cpp2IlInjected.Token(Token = "0x4004E4F")]
	public const short VictorianGothHat = 4708;

	[Cpp2IlInjected.Token(Token = "0x4004E50")]
	public const short VictorianGothDress = 4709;

	[Cpp2IlInjected.Token(Token = "0x4004E51")]
	public const short TatteredWoodSign = 4710;

	[Cpp2IlInjected.Token(Token = "0x4004E52")]
	public const short GravediggerShovel = 4711;

	[Cpp2IlInjected.Token(Token = "0x4004E53")]
	public const short DungeonDesertChest = 4712;

	[Cpp2IlInjected.Token(Token = "0x4004E54")]
	public const short Fake_DungeonDesertChest = 4713;

	[Cpp2IlInjected.Token(Token = "0x4004E55")]
	public const short DungeonDesertKey = 4714;

	[Cpp2IlInjected.Token(Token = "0x4004E56")]
	public const short SparkleGuitar = 4715;

	[Cpp2IlInjected.Token(Token = "0x4004E57")]
	public const short MolluskWhistle = 4716;

	[Cpp2IlInjected.Token(Token = "0x4004E58")]
	public const short BorealBeam = 4717;

	[Cpp2IlInjected.Token(Token = "0x4004E59")]
	public const short RichMahoganyBeam = 4718;

	[Cpp2IlInjected.Token(Token = "0x4004E5A")]
	public const short GraniteColumn = 4719;

	[Cpp2IlInjected.Token(Token = "0x4004E5B")]
	public const short SandstoneColumn = 4720;

	[Cpp2IlInjected.Token(Token = "0x4004E5C")]
	public const short MushroomBeam = 4721;

	[Cpp2IlInjected.Token(Token = "0x4004E5D")]
	public const short FirstFractal = 4722;

	[Cpp2IlInjected.Token(Token = "0x4004E5E")]
	public const short Nevermore = 4723;

	[Cpp2IlInjected.Token(Token = "0x4004E5F")]
	public const short Reborn = 4724;

	[Cpp2IlInjected.Token(Token = "0x4004E60")]
	public const short Graveyard = 4725;

	[Cpp2IlInjected.Token(Token = "0x4004E61")]
	public const short GhostManifestation = 4726;

	[Cpp2IlInjected.Token(Token = "0x4004E62")]
	public const short WickedUndead = 4727;

	[Cpp2IlInjected.Token(Token = "0x4004E63")]
	public const short BloodyGoblet = 4728;

	[Cpp2IlInjected.Token(Token = "0x4004E64")]
	public const short StillLife = 4729;

	[Cpp2IlInjected.Token(Token = "0x4004E65")]
	public const short GhostarsWings = 4730;

	[Cpp2IlInjected.Token(Token = "0x4004E66")]
	public const short TerraToilet = 4731;

	[Cpp2IlInjected.Token(Token = "0x4004E67")]
	public const short GhostarSkullPin = 4732;

	[Cpp2IlInjected.Token(Token = "0x4004E68")]
	public const short GhostarShirt = 4733;

	[Cpp2IlInjected.Token(Token = "0x4004E69")]
	public const short GhostarPants = 4734;

	[Cpp2IlInjected.Token(Token = "0x4004E6A")]
	public const short BallOfFuseWire = 4735;

	[Cpp2IlInjected.Token(Token = "0x4004E6B")]
	public const short FullMoonSqueakyToy = 4736;

	[Cpp2IlInjected.Token(Token = "0x4004E6C")]
	public const short OrnateShadowKey = 4737;

	[Cpp2IlInjected.Token(Token = "0x4004E6D")]
	public const short DrManFlyMask = 4738;

	[Cpp2IlInjected.Token(Token = "0x4004E6E")]
	public const short DrManFlyLabCoat = 4739;

	[Cpp2IlInjected.Token(Token = "0x4004E6F")]
	public const short ButcherMask = 4740;

	[Cpp2IlInjected.Token(Token = "0x4004E70")]
	public const short ButcherApron = 4741;

	[Cpp2IlInjected.Token(Token = "0x4004E71")]
	public const short ButcherPants = 4742;

	[Cpp2IlInjected.Token(Token = "0x4004E72")]
	public const short Football = 4743;

	[Cpp2IlInjected.Token(Token = "0x4004E73")]
	public const short HunterCloak = 4744;

	[Cpp2IlInjected.Token(Token = "0x4004E74")]
	public const short CoffinMinecart = 4745;

	[Cpp2IlInjected.Token(Token = "0x4004E75")]
	public const short SafemanWings = 4746;

	[Cpp2IlInjected.Token(Token = "0x4004E76")]
	public const short SafemanSunHair = 4747;

	[Cpp2IlInjected.Token(Token = "0x4004E77")]
	public const short SafemanSunDress = 4748;

	[Cpp2IlInjected.Token(Token = "0x4004E78")]
	public const short SafemanDressLeggings = 4749;

	[Cpp2IlInjected.Token(Token = "0x4004E79")]
	public const short FoodBarbarianWings = 4750;

	[Cpp2IlInjected.Token(Token = "0x4004E7A")]
	public const short FoodBarbarianHelm = 4751;

	[Cpp2IlInjected.Token(Token = "0x4004E7B")]
	public const short FoodBarbarianArmor = 4752;

	[Cpp2IlInjected.Token(Token = "0x4004E7C")]
	public const short FoodBarbarianGreaves = 4753;

	[Cpp2IlInjected.Token(Token = "0x4004E7D")]
	public const short GroxTheGreatWings = 4754;

	[Cpp2IlInjected.Token(Token = "0x4004E7E")]
	public const short GroxTheGreatHelm = 4755;

	[Cpp2IlInjected.Token(Token = "0x4004E7F")]
	public const short GroxTheGreatArmor = 4756;

	[Cpp2IlInjected.Token(Token = "0x4004E80")]
	public const short GroxTheGreatGreaves = 4757;

	[Cpp2IlInjected.Token(Token = "0x4004E81")]
	public const short Smolstar = 4758;

	[Cpp2IlInjected.Token(Token = "0x4004E82")]
	public const short SquirrelHook = 4759;

	[Cpp2IlInjected.Token(Token = "0x4004E83")]
	public const short BouncingShield = 4760;

	[Cpp2IlInjected.Token(Token = "0x4004E84")]
	public const short RockGolemHead = 4761;

	[Cpp2IlInjected.Token(Token = "0x4004E85")]
	public const short CritterShampoo = 4762;

	[Cpp2IlInjected.Token(Token = "0x4004E86")]
	public const short DiggingMoleMinecart = 4763;

	[Cpp2IlInjected.Token(Token = "0x4004E87")]
	public const short Shroomerang = 4764;

	[Cpp2IlInjected.Token(Token = "0x4004E88")]
	public const short TreeGlobe = 4765;

	[Cpp2IlInjected.Token(Token = "0x4004E89")]
	public const short WorldGlobe = 4766;

	[Cpp2IlInjected.Token(Token = "0x4004E8A")]
	public const short DontHurtCrittersBook = 4767;

	[Cpp2IlInjected.Token(Token = "0x4004E8B")]
	public const short DogEars = 4768;

	[Cpp2IlInjected.Token(Token = "0x4004E8C")]
	public const short DogTail = 4769;

	[Cpp2IlInjected.Token(Token = "0x4004E8D")]
	public const short FoxEars = 4770;

	[Cpp2IlInjected.Token(Token = "0x4004E8E")]
	public const short FoxTail = 4771;

	[Cpp2IlInjected.Token(Token = "0x4004E8F")]
	public const short LizardEars = 4772;

	[Cpp2IlInjected.Token(Token = "0x4004E90")]
	public const short LizardTail = 4773;

	[Cpp2IlInjected.Token(Token = "0x4004E91")]
	public const short PandaEars = 4774;

	[Cpp2IlInjected.Token(Token = "0x4004E92")]
	public const short BunnyTail = 4775;

	[Cpp2IlInjected.Token(Token = "0x4004E93")]
	public const short FairyGlowstick = 4776;

	[Cpp2IlInjected.Token(Token = "0x4004E94")]
	public const short LightningCarrot = 4777;

	[Cpp2IlInjected.Token(Token = "0x4004E95")]
	public const short HallowBossDye = 4778;

	[Cpp2IlInjected.Token(Token = "0x4004E96")]
	public const short MushroomHat = 4779;

	[Cpp2IlInjected.Token(Token = "0x4004E97")]
	public const short MushroomVest = 4780;

	[Cpp2IlInjected.Token(Token = "0x4004E98")]
	public const short MushroomPants = 4781;

	[Cpp2IlInjected.Token(Token = "0x4004E99")]
	public const short FairyQueenBossBag = 4782;

	[Cpp2IlInjected.Token(Token = "0x4004E9A")]
	public const short FairyQueenTrophy = 4783;

	[Cpp2IlInjected.Token(Token = "0x4004E9B")]
	public const short FairyQueenMask = 4784;

	[Cpp2IlInjected.Token(Token = "0x4004E9C")]
	public const short PaintedHorseSaddle = 4785;

	[Cpp2IlInjected.Token(Token = "0x4004E9D")]
	public const short MajesticHorseSaddle = 4786;

	[Cpp2IlInjected.Token(Token = "0x4004E9E")]
	public const short DarkHorseSaddle = 4787;

	[Cpp2IlInjected.Token(Token = "0x4004E9F")]
	public const short JoustingLance = 4788;

	[Cpp2IlInjected.Token(Token = "0x4004EA0")]
	public const short ShadowJoustingLance = 4789;

	[Cpp2IlInjected.Token(Token = "0x4004EA1")]
	public const short HallowJoustingLance = 4790;

	[Cpp2IlInjected.Token(Token = "0x4004EA2")]
	public const short PogoStick = 4791;

	[Cpp2IlInjected.Token(Token = "0x4004EA3")]
	public const short PirateShipMountItem = 4792;

	[Cpp2IlInjected.Token(Token = "0x4004EA4")]
	public const short SpookyWoodMountItem = 4793;

	[Cpp2IlInjected.Token(Token = "0x4004EA5")]
	public const short SantankMountItem = 4794;

	[Cpp2IlInjected.Token(Token = "0x4004EA6")]
	public const short WallOfFleshGoatMountItem = 4795;

	[Cpp2IlInjected.Token(Token = "0x4004EA7")]
	public const short DarkMageBookMountItem = 4796;

	[Cpp2IlInjected.Token(Token = "0x4004EA8")]
	public const short KingSlimePetItem = 4797;

	[Cpp2IlInjected.Token(Token = "0x4004EA9")]
	public const short EyeOfCthulhuPetItem = 4798;

	[Cpp2IlInjected.Token(Token = "0x4004EAA")]
	public const short EaterOfWorldsPetItem = 4799;

	[Cpp2IlInjected.Token(Token = "0x4004EAB")]
	public const short BrainOfCthulhuPetItem = 4800;

	[Cpp2IlInjected.Token(Token = "0x4004EAC")]
	public const short SkeletronPetItem = 4801;

	[Cpp2IlInjected.Token(Token = "0x4004EAD")]
	public const short QueenBeePetItem = 4802;

	[Cpp2IlInjected.Token(Token = "0x4004EAE")]
	public const short DestroyerPetItem = 4803;

	[Cpp2IlInjected.Token(Token = "0x4004EAF")]
	public const short TwinsPetItem = 4804;

	[Cpp2IlInjected.Token(Token = "0x4004EB0")]
	public const short SkeletronPrimePetItem = 4805;

	[Cpp2IlInjected.Token(Token = "0x4004EB1")]
	public const short PlanteraPetItem = 4806;

	[Cpp2IlInjected.Token(Token = "0x4004EB2")]
	public const short GolemPetItem = 4807;

	[Cpp2IlInjected.Token(Token = "0x4004EB3")]
	public const short DukeFishronPetItem = 4808;

	[Cpp2IlInjected.Token(Token = "0x4004EB4")]
	public const short LunaticCultistPetItem = 4809;

	[Cpp2IlInjected.Token(Token = "0x4004EB5")]
	public const short MoonLordPetItem = 4810;

	[Cpp2IlInjected.Token(Token = "0x4004EB6")]
	public const short FairyQueenPetItem = 4811;

	[Cpp2IlInjected.Token(Token = "0x4004EB7")]
	public const short PumpkingPetItem = 4812;

	[Cpp2IlInjected.Token(Token = "0x4004EB8")]
	public const short EverscreamPetItem = 4813;

	[Cpp2IlInjected.Token(Token = "0x4004EB9")]
	public const short IceQueenPetItem = 4814;

	[Cpp2IlInjected.Token(Token = "0x4004EBA")]
	public const short MartianPetItem = 4815;

	[Cpp2IlInjected.Token(Token = "0x4004EBB")]
	public const short DD2OgrePetItem = 4816;

	[Cpp2IlInjected.Token(Token = "0x4004EBC")]
	public const short DD2BetsyPetItem = 4817;

	[Cpp2IlInjected.Token(Token = "0x4004EBD")]
	public const short CombatWrench = 4818;

	[Cpp2IlInjected.Token(Token = "0x4004EBE")]
	public const short DemonConch = 4819;

	[Cpp2IlInjected.Token(Token = "0x4004EBF")]
	public const short BottomlessLavaBucket = 4820;

	[Cpp2IlInjected.Token(Token = "0x4004EC0")]
	public const short FireproofBugNet = 4821;

	[Cpp2IlInjected.Token(Token = "0x4004EC1")]
	public const short FlameWakerBoots = 4822;

	[Cpp2IlInjected.Token(Token = "0x4004EC2")]
	public const short RainbowWings = 4823;

	[Cpp2IlInjected.Token(Token = "0x4004EC3")]
	public const short WetBomb = 4824;

	[Cpp2IlInjected.Token(Token = "0x4004EC4")]
	public const short LavaBomb = 4825;

	[Cpp2IlInjected.Token(Token = "0x4004EC5")]
	public const short HoneyBomb = 4826;

	[Cpp2IlInjected.Token(Token = "0x4004EC6")]
	public const short DryBomb = 4827;

	[Cpp2IlInjected.Token(Token = "0x4004EC7")]
	public const short SuperheatedBlood = 4828;

	[Cpp2IlInjected.Token(Token = "0x4004EC8")]
	public const short LicenseCat = 4829;

	[Cpp2IlInjected.Token(Token = "0x4004EC9")]
	public const short LicenseDog = 4830;

	[Cpp2IlInjected.Token(Token = "0x4004ECA")]
	public const short GemSquirrelAmethyst = 4831;

	[Cpp2IlInjected.Token(Token = "0x4004ECB")]
	public const short GemSquirrelTopaz = 4832;

	[Cpp2IlInjected.Token(Token = "0x4004ECC")]
	public const short GemSquirrelSapphire = 4833;

	[Cpp2IlInjected.Token(Token = "0x4004ECD")]
	public const short GemSquirrelEmerald = 4834;

	[Cpp2IlInjected.Token(Token = "0x4004ECE")]
	public const short GemSquirrelRuby = 4835;

	[Cpp2IlInjected.Token(Token = "0x4004ECF")]
	public const short GemSquirrelDiamond = 4836;

	[Cpp2IlInjected.Token(Token = "0x4004ED0")]
	public const short GemSquirrelAmber = 4837;

	[Cpp2IlInjected.Token(Token = "0x4004ED1")]
	public const short GemBunnyAmethyst = 4838;

	[Cpp2IlInjected.Token(Token = "0x4004ED2")]
	public const short GemBunnyTopaz = 4839;

	[Cpp2IlInjected.Token(Token = "0x4004ED3")]
	public const short GemBunnySapphire = 4840;

	[Cpp2IlInjected.Token(Token = "0x4004ED4")]
	public const short GemBunnyEmerald = 4841;

	[Cpp2IlInjected.Token(Token = "0x4004ED5")]
	public const short GemBunnyRuby = 4842;

	[Cpp2IlInjected.Token(Token = "0x4004ED6")]
	public const short GemBunnyDiamond = 4843;

	[Cpp2IlInjected.Token(Token = "0x4004ED7")]
	public const short GemBunnyAmber = 4844;

	[Cpp2IlInjected.Token(Token = "0x4004ED8")]
	public const short HellButterfly = 4845;

	[Cpp2IlInjected.Token(Token = "0x4004ED9")]
	public const short HellButterflyJar = 4846;

	[Cpp2IlInjected.Token(Token = "0x4004EDA")]
	public const short Lavafly = 4847;

	[Cpp2IlInjected.Token(Token = "0x4004EDB")]
	public const short LavaflyinaBottle = 4848;

	[Cpp2IlInjected.Token(Token = "0x4004EDC")]
	public const short MagmaSnail = 4849;

	[Cpp2IlInjected.Token(Token = "0x4004EDD")]
	public const short MagmaSnailCage = 4850;

	[Cpp2IlInjected.Token(Token = "0x4004EDE")]
	public const short GemTreeTopazSeed = 4851;

	[Cpp2IlInjected.Token(Token = "0x4004EDF")]
	public const short GemTreeAmethystSeed = 4852;

	[Cpp2IlInjected.Token(Token = "0x4004EE0")]
	public const short GemTreeSapphireSeed = 4853;

	[Cpp2IlInjected.Token(Token = "0x4004EE1")]
	public const short GemTreeEmeraldSeed = 4854;

	[Cpp2IlInjected.Token(Token = "0x4004EE2")]
	public const short GemTreeRubySeed = 4855;

	[Cpp2IlInjected.Token(Token = "0x4004EE3")]
	public const short GemTreeDiamondSeed = 4856;

	[Cpp2IlInjected.Token(Token = "0x4004EE4")]
	public const short GemTreeAmberSeed = 4857;

	[Cpp2IlInjected.Token(Token = "0x4004EE5")]
	public const short PotSuspended = 4858;

	[Cpp2IlInjected.Token(Token = "0x4004EE6")]
	public const short PotSuspendedDaybloom = 4859;

	[Cpp2IlInjected.Token(Token = "0x4004EE7")]
	public const short PotSuspendedMoonglow = 4860;

	[Cpp2IlInjected.Token(Token = "0x4004EE8")]
	public const short PotSuspendedWaterleaf = 4861;

	[Cpp2IlInjected.Token(Token = "0x4004EE9")]
	public const short PotSuspendedShiverthorn = 4862;

	[Cpp2IlInjected.Token(Token = "0x4004EEA")]
	public const short PotSuspendedBlinkroot = 4863;

	[Cpp2IlInjected.Token(Token = "0x4004EEB")]
	public const short PotSuspendedDeathweedCorrupt = 4864;

	[Cpp2IlInjected.Token(Token = "0x4004EEC")]
	public const short PotSuspendedDeathweedCrimson = 4865;

	[Cpp2IlInjected.Token(Token = "0x4004EED")]
	public const short PotSuspendedFireblossom = 4866;

	[Cpp2IlInjected.Token(Token = "0x4004EEE")]
	public const short BrazierSuspended = 4867;

	[Cpp2IlInjected.Token(Token = "0x4004EEF")]
	public const short VolcanoSmall = 4868;

	[Cpp2IlInjected.Token(Token = "0x4004EF0")]
	public const short VolcanoLarge = 4869;

	[Cpp2IlInjected.Token(Token = "0x4004EF1")]
	public const short PotionOfReturn = 4870;

	[Cpp2IlInjected.Token(Token = "0x4004EF2")]
	public const short VanityTreeSakuraSeed = 4871;

	[Cpp2IlInjected.Token(Token = "0x4004EF3")]
	public const short LavaAbsorbantSponge = 4872;

	[Cpp2IlInjected.Token(Token = "0x4004EF4")]
	public const short HallowedHood = 4873;

	[Cpp2IlInjected.Token(Token = "0x4004EF5")]
	public const short HellfireTreads = 4874;

	[Cpp2IlInjected.Token(Token = "0x4004EF6")]
	public const short TeleportationPylonJungle = 4875;

	[Cpp2IlInjected.Token(Token = "0x4004EF7")]
	public const short TeleportationPylonPurity = 4876;

	[Cpp2IlInjected.Token(Token = "0x4004EF8")]
	public const short LavaCrate = 4877;

	[Cpp2IlInjected.Token(Token = "0x4004EF9")]
	public const short LavaCrateHard = 4878;

	[Cpp2IlInjected.Token(Token = "0x4004EFA")]
	public const short ObsidianLockbox = 4879;

	[Cpp2IlInjected.Token(Token = "0x4004EFB")]
	public const short LavaFishbowl = 4880;

	[Cpp2IlInjected.Token(Token = "0x4004EFC")]
	public const short LavaFishingHook = 4881;

	[Cpp2IlInjected.Token(Token = "0x4004EFD")]
	public const short AmethystBunnyCage = 4882;

	[Cpp2IlInjected.Token(Token = "0x4004EFE")]
	public const short TopazBunnyCage = 4883;

	[Cpp2IlInjected.Token(Token = "0x4004EFF")]
	public const short SapphireBunnyCage = 4884;

	[Cpp2IlInjected.Token(Token = "0x4004F00")]
	public const short EmeraldBunnyCage = 4885;

	[Cpp2IlInjected.Token(Token = "0x4004F01")]
	public const short RubyBunnyCage = 4886;

	[Cpp2IlInjected.Token(Token = "0x4004F02")]
	public const short DiamondBunnyCage = 4887;

	[Cpp2IlInjected.Token(Token = "0x4004F03")]
	public const short AmberBunnyCage = 4888;

	[Cpp2IlInjected.Token(Token = "0x4004F04")]
	public const short AmethystSquirrelCage = 4889;

	[Cpp2IlInjected.Token(Token = "0x4004F05")]
	public const short TopazSquirrelCage = 4890;

	[Cpp2IlInjected.Token(Token = "0x4004F06")]
	public const short SapphireSquirrelCage = 4891;

	[Cpp2IlInjected.Token(Token = "0x4004F07")]
	public const short EmeraldSquirrelCage = 4892;

	[Cpp2IlInjected.Token(Token = "0x4004F08")]
	public const short RubySquirrelCage = 4893;

	[Cpp2IlInjected.Token(Token = "0x4004F09")]
	public const short DiamondSquirrelCage = 4894;

	[Cpp2IlInjected.Token(Token = "0x4004F0A")]
	public const short AmberSquirrelCage = 4895;

	[Cpp2IlInjected.Token(Token = "0x4004F0B")]
	public const short AncientHallowedMask = 4896;

	[Cpp2IlInjected.Token(Token = "0x4004F0C")]
	public const short AncientHallowedHelmet = 4897;

	[Cpp2IlInjected.Token(Token = "0x4004F0D")]
	public const short AncientHallowedHeadgear = 4898;

	[Cpp2IlInjected.Token(Token = "0x4004F0E")]
	public const short AncientHallowedHood = 4899;

	[Cpp2IlInjected.Token(Token = "0x4004F0F")]
	public const short AncientHallowedPlateMail = 4900;

	[Cpp2IlInjected.Token(Token = "0x4004F10")]
	public const short AncientHallowedGreaves = 4901;

	[Cpp2IlInjected.Token(Token = "0x4004F11")]
	public const short PottedLavaPlantPalm = 4902;

	[Cpp2IlInjected.Token(Token = "0x4004F12")]
	public const short PottedLavaPlantBush = 4903;

	[Cpp2IlInjected.Token(Token = "0x4004F13")]
	public const short PottedLavaPlantBramble = 4904;

	[Cpp2IlInjected.Token(Token = "0x4004F14")]
	public const short PottedLavaPlantBulb = 4905;

	[Cpp2IlInjected.Token(Token = "0x4004F15")]
	public const short PottedLavaPlantTendrils = 4906;

	[Cpp2IlInjected.Token(Token = "0x4004F16")]
	public const short VanityTreeYellowWillowSeed = 4907;

	[Cpp2IlInjected.Token(Token = "0x4004F17")]
	public const short DirtBomb = 4908;

	[Cpp2IlInjected.Token(Token = "0x4004F18")]
	public const short DirtStickyBomb = 4909;

	[Cpp2IlInjected.Token(Token = "0x4004F19")]
	public const short LicenseBunny = 4910;

	[Cpp2IlInjected.Token(Token = "0x4004F1A")]
	public const short CoolWhip = 4911;

	[Cpp2IlInjected.Token(Token = "0x4004F1B")]
	public const short FireWhip = 4912;

	[Cpp2IlInjected.Token(Token = "0x4004F1C")]
	public const short ThornWhip = 4913;

	[Cpp2IlInjected.Token(Token = "0x4004F1D")]
	public const short RainbowWhip = 4914;

	[Cpp2IlInjected.Token(Token = "0x4004F1E")]
	public const short TungstenBullet = 4915;

	[Cpp2IlInjected.Token(Token = "0x4004F1F")]
	public const short TeleportationPylonHallow = 4916;

	[Cpp2IlInjected.Token(Token = "0x4004F20")]
	public const short TeleportationPylonUnderground = 4917;

	[Cpp2IlInjected.Token(Token = "0x4004F21")]
	public const short TeleportationPylonOcean = 4918;

	[Cpp2IlInjected.Token(Token = "0x4004F22")]
	public const short TeleportationPylonDesert = 4919;

	[Cpp2IlInjected.Token(Token = "0x4004F23")]
	public const short TeleportationPylonSnow = 4920;

	[Cpp2IlInjected.Token(Token = "0x4004F24")]
	public const short TeleportationPylonMushroom = 4921;

	[Cpp2IlInjected.Token(Token = "0x4004F25")]
	public const short CavernFountain = 4922;

	[Cpp2IlInjected.Token(Token = "0x4004F26")]
	public const short PiercingStarlight = 4923;

	[Cpp2IlInjected.Token(Token = "0x4004F27")]
	public const short EyeofCthulhuMasterTrophy = 4924;

	[Cpp2IlInjected.Token(Token = "0x4004F28")]
	public const short EaterofWorldsMasterTrophy = 4925;

	[Cpp2IlInjected.Token(Token = "0x4004F29")]
	public const short BrainofCthulhuMasterTrophy = 4926;

	[Cpp2IlInjected.Token(Token = "0x4004F2A")]
	public const short SkeletronMasterTrophy = 4927;

	[Cpp2IlInjected.Token(Token = "0x4004F2B")]
	public const short QueenBeeMasterTrophy = 4928;

	[Cpp2IlInjected.Token(Token = "0x4004F2C")]
	public const short KingSlimeMasterTrophy = 4929;

	[Cpp2IlInjected.Token(Token = "0x4004F2D")]
	public const short WallofFleshMasterTrophy = 4930;

	[Cpp2IlInjected.Token(Token = "0x4004F2E")]
	public const short TwinsMasterTrophy = 4931;

	[Cpp2IlInjected.Token(Token = "0x4004F2F")]
	public const short DestroyerMasterTrophy = 4932;

	[Cpp2IlInjected.Token(Token = "0x4004F30")]
	public const short SkeletronPrimeMasterTrophy = 4933;

	[Cpp2IlInjected.Token(Token = "0x4004F31")]
	public const short PlanteraMasterTrophy = 4934;

	[Cpp2IlInjected.Token(Token = "0x4004F32")]
	public const short GolemMasterTrophy = 4935;

	[Cpp2IlInjected.Token(Token = "0x4004F33")]
	public const short DukeFishronMasterTrophy = 4936;

	[Cpp2IlInjected.Token(Token = "0x4004F34")]
	public const short LunaticCultistMasterTrophy = 4937;

	[Cpp2IlInjected.Token(Token = "0x4004F35")]
	public const short MoonLordMasterTrophy = 4938;

	[Cpp2IlInjected.Token(Token = "0x4004F36")]
	public const short UFOMasterTrophy = 4939;

	[Cpp2IlInjected.Token(Token = "0x4004F37")]
	public const short FlyingDutchmanMasterTrophy = 4940;

	[Cpp2IlInjected.Token(Token = "0x4004F38")]
	public const short MourningWoodMasterTrophy = 4941;

	[Cpp2IlInjected.Token(Token = "0x4004F39")]
	public const short PumpkingMasterTrophy = 4942;

	[Cpp2IlInjected.Token(Token = "0x4004F3A")]
	public const short IceQueenMasterTrophy = 4943;

	[Cpp2IlInjected.Token(Token = "0x4004F3B")]
	public const short EverscreamMasterTrophy = 4944;

	[Cpp2IlInjected.Token(Token = "0x4004F3C")]
	public const short SantankMasterTrophy = 4945;

	[Cpp2IlInjected.Token(Token = "0x4004F3D")]
	public const short DarkMageMasterTrophy = 4946;

	[Cpp2IlInjected.Token(Token = "0x4004F3E")]
	public const short OgreMasterTrophy = 4947;

	[Cpp2IlInjected.Token(Token = "0x4004F3F")]
	public const short BetsyMasterTrophy = 4948;

	[Cpp2IlInjected.Token(Token = "0x4004F40")]
	public const short FairyQueenMasterTrophy = 4949;

	[Cpp2IlInjected.Token(Token = "0x4004F41")]
	public const short QueenSlimeMasterTrophy = 4950;

	[Cpp2IlInjected.Token(Token = "0x4004F42")]
	public const short TeleportationPylonVictory = 4951;

	[Cpp2IlInjected.Token(Token = "0x4004F43")]
	public const short FairyQueenMagicItem = 4952;

	[Cpp2IlInjected.Token(Token = "0x4004F44")]
	public const short FairyQueenRangedItem = 4953;

	[Cpp2IlInjected.Token(Token = "0x4004F45")]
	public const short LongRainbowTrailWings = 4954;

	[Cpp2IlInjected.Token(Token = "0x4004F46")]
	public const short RabbitOrder = 4955;

	[Cpp2IlInjected.Token(Token = "0x4004F47")]
	public const short Zenith = 4956;

	[Cpp2IlInjected.Token(Token = "0x4004F48")]
	public const short QueenSlimeBossBag = 4957;

	[Cpp2IlInjected.Token(Token = "0x4004F49")]
	public const short QueenSlimeTrophy = 4958;

	[Cpp2IlInjected.Token(Token = "0x4004F4A")]
	public const short QueenSlimeMask = 4959;

	[Cpp2IlInjected.Token(Token = "0x4004F4B")]
	public const short QueenSlimePetItem = 4960;

	[Cpp2IlInjected.Token(Token = "0x4004F4C")]
	public const short EmpressButterfly = 4961;

	[Cpp2IlInjected.Token(Token = "0x4004F4D")]
	public const short AccentSlab = 4962;

	[Cpp2IlInjected.Token(Token = "0x4004F4E")]
	public const short TruffleWormCage = 4963;

	[Cpp2IlInjected.Token(Token = "0x4004F4F")]
	public const short EmpressButterflyJar = 4964;

	[Cpp2IlInjected.Token(Token = "0x4004F50")]
	public const short RockGolemBanner = 4965;

	[Cpp2IlInjected.Token(Token = "0x4004F51")]
	public const short BloodMummyBanner = 4966;

	[Cpp2IlInjected.Token(Token = "0x4004F52")]
	public const short SporeSkeletonBanner = 4967;

	[Cpp2IlInjected.Token(Token = "0x4004F53")]
	public const short SporeBatBanner = 4968;

	[Cpp2IlInjected.Token(Token = "0x4004F54")]
	public const short LarvaeAntlionBanner = 4969;

	[Cpp2IlInjected.Token(Token = "0x4004F55")]
	public const short CrimsonBunnyBanner = 4970;

	[Cpp2IlInjected.Token(Token = "0x4004F56")]
	public const short CrimsonGoldfishBanner = 4971;

	[Cpp2IlInjected.Token(Token = "0x4004F57")]
	public const short CrimsonPenguinBanner = 4972;

	[Cpp2IlInjected.Token(Token = "0x4004F58")]
	public const short BigMimicCorruptionBanner = 4973;

	[Cpp2IlInjected.Token(Token = "0x4004F59")]
	public const short BigMimicCrimsonBanner = 4974;

	[Cpp2IlInjected.Token(Token = "0x4004F5A")]
	public const short BigMimicHallowBanner = 4975;

	[Cpp2IlInjected.Token(Token = "0x4004F5B")]
	public const short MossHornetBanner = 4976;

	[Cpp2IlInjected.Token(Token = "0x4004F5C")]
	public const short WanderingEyeBanner = 4977;

	[Cpp2IlInjected.Token(Token = "0x4004F5D")]
	public const short CreativeWings = 4978;

	[Cpp2IlInjected.Token(Token = "0x4004F5E")]
	public const short MusicBoxQueenSlime = 4979;

	[Cpp2IlInjected.Token(Token = "0x4004F5F")]
	public const short QueenSlimeHook = 4980;

	[Cpp2IlInjected.Token(Token = "0x4004F60")]
	public const short QueenSlimeMountSaddle = 4981;

	[Cpp2IlInjected.Token(Token = "0x4004F61")]
	public const short CrystalNinjaHelmet = 4982;

	[Cpp2IlInjected.Token(Token = "0x4004F62")]
	public const short CrystalNinjaChestplate = 4983;

	[Cpp2IlInjected.Token(Token = "0x4004F63")]
	public const short CrystalNinjaLeggings = 4984;

	[Cpp2IlInjected.Token(Token = "0x4004F64")]
	public const short MusicBoxEmpressOfLight = 4985;

	[Cpp2IlInjected.Token(Token = "0x4004F65")]
	public const short GelBalloon = 4986;

	[Cpp2IlInjected.Token(Token = "0x4004F66")]
	public const short VolatileGelatin = 4987;

	[Cpp2IlInjected.Token(Token = "0x4004F67")]
	public const short QueenSlimeCrystal = 4988;

	[Cpp2IlInjected.Token(Token = "0x4004F68")]
	public const short EmpressFlightBooster = 4989;

	[Cpp2IlInjected.Token(Token = "0x4004F69")]
	public const short MusicBoxDukeFishron = 4990;

	[Cpp2IlInjected.Token(Token = "0x4004F6A")]
	public const short MusicBoxMorningRain = 4991;

	[Cpp2IlInjected.Token(Token = "0x4004F6B")]
	public const short MusicBoxConsoleTitle = 4992;

	[Cpp2IlInjected.Token(Token = "0x4004F6C")]
	public const short ChippysCouch = 4993;

	[Cpp2IlInjected.Token(Token = "0x4004F6D")]
	public const short GraduationCapBlue = 4994;

	[Cpp2IlInjected.Token(Token = "0x4004F6E")]
	public const short GraduationCapMaroon = 4995;

	[Cpp2IlInjected.Token(Token = "0x4004F6F")]
	public const short GraduationCapBlack = 4996;

	[Cpp2IlInjected.Token(Token = "0x4004F70")]
	public const short GraduationGownBlue = 4997;

	[Cpp2IlInjected.Token(Token = "0x4004F71")]
	public const short GraduationGownMaroon = 4998;

	[Cpp2IlInjected.Token(Token = "0x4004F72")]
	public const short GraduationGownBlack = 4999;

	[Cpp2IlInjected.Token(Token = "0x4004F73")]
	public const short TerrasparkBoots = 5000;

	[Cpp2IlInjected.Token(Token = "0x4004F74")]
	public const short MoonLordLegs = 5001;

	[Cpp2IlInjected.Token(Token = "0x4004F75")]
	public const short OceanCrate = 5002;

	[Cpp2IlInjected.Token(Token = "0x4004F76")]
	public const short OceanCrateHard = 5003;

	[Cpp2IlInjected.Token(Token = "0x4004F77")]
	public const short BadgersHat = 5004;

	[Cpp2IlInjected.Token(Token = "0x4004F78")]
	public const short EmpressBlade = 5005;

	[Cpp2IlInjected.Token(Token = "0x4004F79")]
	public const short MusicBoxUndergroundDesert = 5006;

	[Cpp2IlInjected.Token(Token = "0x4004F7A")]
	public const short DeadMansSweater = 5007;

	[Cpp2IlInjected.Token(Token = "0x4004F7B")]
	public const short TeaKettle = 5008;

	[Cpp2IlInjected.Token(Token = "0x4004F7C")]
	public const short Teacup = 5009;

	[Cpp2IlInjected.Token(Token = "0x4004F7D")]
	public const short TreasureMagnet = 5010;

	[Cpp2IlInjected.Token(Token = "0x4004F7E")]
	public const short Mace = 5011;

	[Cpp2IlInjected.Token(Token = "0x4004F7F")]
	public const short FlamingMace = 5012;

	[Cpp2IlInjected.Token(Token = "0x4004F80")]
	public const short SleepingIcon = 5013;

	[Cpp2IlInjected.Token(Token = "0x4004F81")]
	public const short MusicBoxOWRain = 5014;

	[Cpp2IlInjected.Token(Token = "0x4004F82")]
	public const short MusicBoxOWDay = 5015;

	[Cpp2IlInjected.Token(Token = "0x4004F83")]
	public const short MusicBoxOWNight = 5016;

	[Cpp2IlInjected.Token(Token = "0x4004F84")]
	public const short MusicBoxOWUnderground = 5017;

	[Cpp2IlInjected.Token(Token = "0x4004F85")]
	public const short MusicBoxOWDesert = 5018;

	[Cpp2IlInjected.Token(Token = "0x4004F86")]
	public const short MusicBoxOWOcean = 5019;

	[Cpp2IlInjected.Token(Token = "0x4004F87")]
	public const short MusicBoxOWMushroom = 5020;

	[Cpp2IlInjected.Token(Token = "0x4004F88")]
	public const short MusicBoxOWDungeon = 5021;

	[Cpp2IlInjected.Token(Token = "0x4004F89")]
	public const short MusicBoxOWSpace = 5022;

	[Cpp2IlInjected.Token(Token = "0x4004F8A")]
	public const short MusicBoxOWUnderworld = 5023;

	[Cpp2IlInjected.Token(Token = "0x4004F8B")]
	public const short MusicBoxOWSnow = 5024;

	[Cpp2IlInjected.Token(Token = "0x4004F8C")]
	public const short MusicBoxOWCorruption = 5025;

	[Cpp2IlInjected.Token(Token = "0x4004F8D")]
	public const short MusicBoxOWUndergroundCorruption = 5026;

	[Cpp2IlInjected.Token(Token = "0x4004F8E")]
	public const short MusicBoxOWCrimson = 5027;

	[Cpp2IlInjected.Token(Token = "0x4004F8F")]
	public const short MusicBoxOWUndergroundCrimson = 5028;

	[Cpp2IlInjected.Token(Token = "0x4004F90")]
	public const short MusicBoxOWUndergroundSnow = 5029;

	[Cpp2IlInjected.Token(Token = "0x4004F91")]
	public const short MusicBoxOWUndergroundHallow = 5030;

	[Cpp2IlInjected.Token(Token = "0x4004F92")]
	public const short MusicBoxOWBloodMoon = 5031;

	[Cpp2IlInjected.Token(Token = "0x4004F93")]
	public const short MusicBoxOWBoss2 = 5032;

	[Cpp2IlInjected.Token(Token = "0x4004F94")]
	public const short MusicBoxOWBoss1 = 5033;

	[Cpp2IlInjected.Token(Token = "0x4004F95")]
	public const short MusicBoxOWInvasion = 5034;

	[Cpp2IlInjected.Token(Token = "0x4004F96")]
	public const short MusicBoxOWTowers = 5035;

	[Cpp2IlInjected.Token(Token = "0x4004F97")]
	public const short MusicBoxOWMoonLord = 5036;

	[Cpp2IlInjected.Token(Token = "0x4004F98")]
	public const short MusicBoxOWPlantera = 5037;

	[Cpp2IlInjected.Token(Token = "0x4004F99")]
	public const short MusicBoxOWJungle = 5038;

	[Cpp2IlInjected.Token(Token = "0x4004F9A")]
	public const short MusicBoxOWWallOfFlesh = 5039;

	[Cpp2IlInjected.Token(Token = "0x4004F9B")]
	public const short MusicBoxOWHallow = 5040;

	[Cpp2IlInjected.Token(Token = "0x4004F9C")]
	public const short MilkCarton = 5041;

	[Cpp2IlInjected.Token(Token = "0x4004F9D")]
	public const short CoffeeCup = 5042;

	[Cpp2IlInjected.Token(Token = "0x4004F9E")]
	public const short TorchGodsFavor = 5043;

	[Cpp2IlInjected.Token(Token = "0x4004F9F")]
	public const short MusicBoxCredits = 5044;

	[Cpp2IlInjected.Token(Token = "0x4004FA0")]
	public const short PlaguebringerHelmet = 5045;

	[Cpp2IlInjected.Token(Token = "0x4004FA1")]
	public const short PlaguebringerChestplate = 5046;

	[Cpp2IlInjected.Token(Token = "0x4004FA2")]
	public const short PlaguebringerGreaves = 5047;

	[Cpp2IlInjected.Token(Token = "0x4004FA3")]
	public const short RoninHat = 5048;

	[Cpp2IlInjected.Token(Token = "0x4004FA4")]
	public const short RoninShirt = 5049;

	[Cpp2IlInjected.Token(Token = "0x4004FA5")]
	public const short RoninPants = 5050;

	[Cpp2IlInjected.Token(Token = "0x4004FA6")]
	public const short TimelessTravelerHood = 5051;

	[Cpp2IlInjected.Token(Token = "0x4004FA7")]
	public const short TimelessTravelerRobe = 5052;

	[Cpp2IlInjected.Token(Token = "0x4004FA8")]
	public const short TimelessTravelerBottom = 5053;

	[Cpp2IlInjected.Token(Token = "0x4004FA9")]
	public const short FloretProtectorHelmet = 5054;

	[Cpp2IlInjected.Token(Token = "0x4004FAA")]
	public const short FloretProtectorChestplate = 5055;

	[Cpp2IlInjected.Token(Token = "0x4004FAB")]
	public const short FloretProtectorLegs = 5056;

	[Cpp2IlInjected.Token(Token = "0x4004FAC")]
	public const short CapricornMask = 5057;

	[Cpp2IlInjected.Token(Token = "0x4004FAD")]
	public const short CapricornChestplate = 5058;

	[Cpp2IlInjected.Token(Token = "0x4004FAE")]
	public const short CapricornLegs = 5059;

	[Cpp2IlInjected.Token(Token = "0x4004FAF")]
	public const short CapricornTail = 5060;

	[Cpp2IlInjected.Token(Token = "0x4004FB0")]
	public const short TVHeadMask = 5061;

	[Cpp2IlInjected.Token(Token = "0x4004FB1")]
	public const short TVHeadSuit = 5062;

	[Cpp2IlInjected.Token(Token = "0x4004FB2")]
	public const short TVHeadPants = 5063;

	[Cpp2IlInjected.Token(Token = "0x4004FB3")]
	public const short LavaproofTackleBag = 5064;

	[Cpp2IlInjected.Token(Token = "0x4004FB4")]
	public const short PrincessWeapon = 5065;

	[Cpp2IlInjected.Token(Token = "0x4004FB5")]
	public const short BeeHive = 5066;

	[Cpp2IlInjected.Token(Token = "0x4004FB6")]
	public const short AntlionEggs = 5067;

	[Cpp2IlInjected.Token(Token = "0x4004FB7")]
	public const short FlinxFurCoat = 5068;

	[Cpp2IlInjected.Token(Token = "0x4004FB8")]
	public const short FlinxStaff = 5069;

	[Cpp2IlInjected.Token(Token = "0x4004FB9")]
	public const short FlinxFur = 5070;

	[Cpp2IlInjected.Token(Token = "0x4004FBA")]
	public const short RoyalTiara = 5071;

	[Cpp2IlInjected.Token(Token = "0x4004FBB")]
	public const short RoyalDressTop = 5072;

	[Cpp2IlInjected.Token(Token = "0x4004FBC")]
	public const short RoyalDressBottom = 5073;

	[Cpp2IlInjected.Token(Token = "0x4004FBD")]
	public const short BoneWhip = 5074;

	[Cpp2IlInjected.Token(Token = "0x4004FBE")]
	public const short RainbowCursor = 5075;

	[Cpp2IlInjected.Token(Token = "0x4004FBF")]
	public const short RoyalScepter = 5076;

	[Cpp2IlInjected.Token(Token = "0x4004FC0")]
	public const short GlassSlipper = 5077;

	[Cpp2IlInjected.Token(Token = "0x4004FC1")]
	public const short PrinceUniform = 5078;

	[Cpp2IlInjected.Token(Token = "0x4004FC2")]
	public const short PrincePants = 5079;

	[Cpp2IlInjected.Token(Token = "0x4004FC3")]
	public const short PrinceCape = 5080;

	[Cpp2IlInjected.Token(Token = "0x4004FC4")]
	public const short PottedCrystalPlantFern = 5081;

	[Cpp2IlInjected.Token(Token = "0x4004FC5")]
	public const short PottedCrystalPlantSpiral = 5082;

	[Cpp2IlInjected.Token(Token = "0x4004FC6")]
	public const short PottedCrystalPlantTeardrop = 5083;

	[Cpp2IlInjected.Token(Token = "0x4004FC7")]
	public const short PottedCrystalPlantTree = 5084;

	[Cpp2IlInjected.Token(Token = "0x4004FC8")]
	public const short Princess64 = 5085;

	[Cpp2IlInjected.Token(Token = "0x4004FC9")]
	public const short PaintingOfALass = 5086;

	[Cpp2IlInjected.Token(Token = "0x4004FCA")]
	public const short DarkSideHallow = 5087;

	[Cpp2IlInjected.Token(Token = "0x4004FCB")]
	public const short BerniePetItem = 5088;

	[Cpp2IlInjected.Token(Token = "0x4004FCC")]
	public const short GlommerPetItem = 5089;

	[Cpp2IlInjected.Token(Token = "0x4004FCD")]
	public const short DeerclopsPetItem = 5090;

	[Cpp2IlInjected.Token(Token = "0x4004FCE")]
	public const short PigPetItem = 5091;

	[Cpp2IlInjected.Token(Token = "0x4004FCF")]
	public const short MonsterLasagna = 5092;

	[Cpp2IlInjected.Token(Token = "0x4004FD0")]
	public const short FroggleBunwich = 5093;

	[Cpp2IlInjected.Token(Token = "0x4004FD1")]
	public const short TentacleSpike = 5094;

	[Cpp2IlInjected.Token(Token = "0x4004FD2")]
	public const short LucyTheAxe = 5095;

	[Cpp2IlInjected.Token(Token = "0x4004FD3")]
	public const short HamBat = 5096;

	[Cpp2IlInjected.Token(Token = "0x4004FD4")]
	public const short BatBat = 5097;

	[Cpp2IlInjected.Token(Token = "0x4004FD5")]
	public const short ChesterPetItem = 5098;

	[Cpp2IlInjected.Token(Token = "0x4004FD6")]
	public const short GarlandHat = 5099;

	[Cpp2IlInjected.Token(Token = "0x4004FD7")]
	public const short BoneHelm = 5100;

	[Cpp2IlInjected.Token(Token = "0x4004FD8")]
	public const short Eyebrella = 5101;

	[Cpp2IlInjected.Token(Token = "0x4004FD9")]
	public const short WilsonShirt = 5102;

	[Cpp2IlInjected.Token(Token = "0x4004FDA")]
	public const short WilsonPants = 5103;

	[Cpp2IlInjected.Token(Token = "0x4004FDB")]
	public const short WilsonBeardShort = 5104;

	[Cpp2IlInjected.Token(Token = "0x4004FDC")]
	public const short WilsonBeardLong = 5105;

	[Cpp2IlInjected.Token(Token = "0x4004FDD")]
	public const short WilsonBeardMagnificent = 5106;

	[Cpp2IlInjected.Token(Token = "0x4004FDE")]
	public const short Magiluminescence = 5107;

	[Cpp2IlInjected.Token(Token = "0x4004FDF")]
	public const short DeerclopsTrophy = 5108;

	[Cpp2IlInjected.Token(Token = "0x4004FE0")]
	public const short DeerclopsMask = 5109;

	[Cpp2IlInjected.Token(Token = "0x4004FE1")]
	public const short DeerclopsMasterTrophy = 5110;

	[Cpp2IlInjected.Token(Token = "0x4004FE2")]
	public const short DeerclopsBossBag = 5111;

	[Cpp2IlInjected.Token(Token = "0x4004FE3")]
	public const short MusicBoxDeerclops = 5112;

	[Cpp2IlInjected.Token(Token = "0x4004FE4")]
	public const short DontStarveShaderItem = 5113;

	[Cpp2IlInjected.Token(Token = "0x4004FE5")]
	public const short AbigailsFlower = 5114;

	[Cpp2IlInjected.Token(Token = "0x4004FE6")]
	public const short WillowShirt = 5115;

	[Cpp2IlInjected.Token(Token = "0x4004FE7")]
	public const short WillowSkirt = 5116;

	[Cpp2IlInjected.Token(Token = "0x4004FE8")]
	public const short PewMaticHorn = 5117;

	[Cpp2IlInjected.Token(Token = "0x4004FE9")]
	public const short WeatherPain = 5118;

	[Cpp2IlInjected.Token(Token = "0x4004FEA")]
	public const short HoundiusShootius = 5119;

	[Cpp2IlInjected.Token(Token = "0x4004FEB")]
	public const short DeerThing = 5120;

	[Cpp2IlInjected.Token(Token = "0x4004FEC")]
	public const short PaintingWilson = 5121;

	[Cpp2IlInjected.Token(Token = "0x4004FED")]
	public const short PaintingWillow = 5122;

	[Cpp2IlInjected.Token(Token = "0x4004FEE")]
	public const short PaintingWendy = 5123;

	[Cpp2IlInjected.Token(Token = "0x4004FEF")]
	public const short PaintingWolfgang = 5124;

	[Cpp2IlInjected.Token(Token = "0x4004FF0")]
	public const short FartMinecart = 5125;

	[Cpp2IlInjected.Token(Token = "0x4004FF1")]
	public const short HandOfCreation = 5126;

	[Cpp2IlInjected.Token(Token = "0x4004FF2")]
	public const short VioletMoss = 5127;

	[Cpp2IlInjected.Token(Token = "0x4004FF3")]
	public const short RainbowMoss = 5128;

	[Cpp2IlInjected.Token(Token = "0x4004FF4")]
	public const short Flymeal = 5129;

	[Cpp2IlInjected.Token(Token = "0x4004FF5")]
	public const short WolfMountItem = 5130;

	[Cpp2IlInjected.Token(Token = "0x4004FF6")]
	public const short ResplendentDessert = 5131;

	[Cpp2IlInjected.Token(Token = "0x4004FF7")]
	public const short Stinkbug = 5132;

	[Cpp2IlInjected.Token(Token = "0x4004FF8")]
	public const short StinkbugCage = 5133;

	[Cpp2IlInjected.Token(Token = "0x4004FF9")]
	public const short Clentaminator2 = 5134;

	[Cpp2IlInjected.Token(Token = "0x4004FFA")]
	public const short VenomDartTrap = 5135;

	[Cpp2IlInjected.Token(Token = "0x4004FFB")]
	public const short VulkelfEar = 5136;

	[Cpp2IlInjected.Token(Token = "0x4004FFC")]
	public const short StinkbugHousingBlocker = 5137;

	[Cpp2IlInjected.Token(Token = "0x4004FFD")]
	public const short StinkbugHousingBlockerEcho = 5138;

	[Cpp2IlInjected.Token(Token = "0x4004FFE")]
	public const short FishingBobber = 5139;

	[Cpp2IlInjected.Token(Token = "0x4004FFF")]
	public const short FishingBobberGlowingStar = 5140;

	[Cpp2IlInjected.Token(Token = "0x4005000")]
	public const short FishingBobberGlowingLava = 5141;

	[Cpp2IlInjected.Token(Token = "0x4005001")]
	public const short FishingBobberGlowingKrypton = 5142;

	[Cpp2IlInjected.Token(Token = "0x4005002")]
	public const short FishingBobberGlowingXenon = 5143;

	[Cpp2IlInjected.Token(Token = "0x4005003")]
	public const short FishingBobberGlowingArgon = 5144;

	[Cpp2IlInjected.Token(Token = "0x4005004")]
	public const short FishingBobberGlowingViolet = 5145;

	[Cpp2IlInjected.Token(Token = "0x4005005")]
	public const short FishingBobberGlowingRainbow = 5146;

	[Cpp2IlInjected.Token(Token = "0x4005006")]
	public const short WandofFrosting = 5147;

	[Cpp2IlInjected.Token(Token = "0x4005007")]
	public const short CoralBathtub = 5148;

	[Cpp2IlInjected.Token(Token = "0x4005008")]
	public const short CoralBed = 5149;

	[Cpp2IlInjected.Token(Token = "0x4005009")]
	public const short CoralBookcase = 5150;

	[Cpp2IlInjected.Token(Token = "0x400500A")]
	public const short CoralDresser = 5151;

	[Cpp2IlInjected.Token(Token = "0x400500B")]
	public const short CoralCandelabra = 5152;

	[Cpp2IlInjected.Token(Token = "0x400500C")]
	public const short CoralCandle = 5153;

	[Cpp2IlInjected.Token(Token = "0x400500D")]
	public const short CoralChair = 5154;

	[Cpp2IlInjected.Token(Token = "0x400500E")]
	public const short CoralChandelier = 5155;

	[Cpp2IlInjected.Token(Token = "0x400500F")]
	public const short CoralChest = 5156;

	[Cpp2IlInjected.Token(Token = "0x4005010")]
	public const short CoralClock = 5157;

	[Cpp2IlInjected.Token(Token = "0x4005011")]
	public const short CoralDoor = 5158;

	[Cpp2IlInjected.Token(Token = "0x4005012")]
	public const short CoralLamp = 5159;

	[Cpp2IlInjected.Token(Token = "0x4005013")]
	public const short CoralLantern = 5160;

	[Cpp2IlInjected.Token(Token = "0x4005014")]
	public const short CoralPiano = 5161;

	[Cpp2IlInjected.Token(Token = "0x4005015")]
	public const short CoralPlatform = 5162;

	[Cpp2IlInjected.Token(Token = "0x4005016")]
	public const short CoralSink = 5163;

	[Cpp2IlInjected.Token(Token = "0x4005017")]
	public const short CoralSofa = 5164;

	[Cpp2IlInjected.Token(Token = "0x4005018")]
	public const short CoralTable = 5165;

	[Cpp2IlInjected.Token(Token = "0x4005019")]
	public const short CoralWorkbench = 5166;

	[Cpp2IlInjected.Token(Token = "0x400501A")]
	public const short Fake_CoralChest = 5167;

	[Cpp2IlInjected.Token(Token = "0x400501B")]
	public const short CoralToilet = 5168;

	[Cpp2IlInjected.Token(Token = "0x400501C")]
	public const short BalloonBathtub = 5169;

	[Cpp2IlInjected.Token(Token = "0x400501D")]
	public const short BalloonBed = 5170;

	[Cpp2IlInjected.Token(Token = "0x400501E")]
	public const short BalloonBookcase = 5171;

	[Cpp2IlInjected.Token(Token = "0x400501F")]
	public const short BalloonDresser = 5172;

	[Cpp2IlInjected.Token(Token = "0x4005020")]
	public const short BalloonCandelabra = 5173;

	[Cpp2IlInjected.Token(Token = "0x4005021")]
	public const short BalloonCandle = 5174;

	[Cpp2IlInjected.Token(Token = "0x4005022")]
	public const short BalloonChair = 5175;

	[Cpp2IlInjected.Token(Token = "0x4005023")]
	public const short BalloonChandelier = 5176;

	[Cpp2IlInjected.Token(Token = "0x4005024")]
	public const short BalloonChest = 5177;

	[Cpp2IlInjected.Token(Token = "0x4005025")]
	public const short BalloonClock = 5178;

	[Cpp2IlInjected.Token(Token = "0x4005026")]
	public const short BalloonDoor = 5179;

	[Cpp2IlInjected.Token(Token = "0x4005027")]
	public const short BalloonLamp = 5180;

	[Cpp2IlInjected.Token(Token = "0x4005028")]
	public const short BalloonLantern = 5181;

	[Cpp2IlInjected.Token(Token = "0x4005029")]
	public const short BalloonPiano = 5182;

	[Cpp2IlInjected.Token(Token = "0x400502A")]
	public const short BalloonPlatform = 5183;

	[Cpp2IlInjected.Token(Token = "0x400502B")]
	public const short BalloonSink = 5184;

	[Cpp2IlInjected.Token(Token = "0x400502C")]
	public const short BalloonSofa = 5185;

	[Cpp2IlInjected.Token(Token = "0x400502D")]
	public const short BalloonTable = 5186;

	[Cpp2IlInjected.Token(Token = "0x400502E")]
	public const short BalloonWorkbench = 5187;

	[Cpp2IlInjected.Token(Token = "0x400502F")]
	public const short Fake_BalloonChest = 5188;

	[Cpp2IlInjected.Token(Token = "0x4005030")]
	public const short BalloonToilet = 5189;

	[Cpp2IlInjected.Token(Token = "0x4005031")]
	public const short AshWoodBathtub = 5190;

	[Cpp2IlInjected.Token(Token = "0x4005032")]
	public const short AshWoodBed = 5191;

	[Cpp2IlInjected.Token(Token = "0x4005033")]
	public const short AshWoodBookcase = 5192;

	[Cpp2IlInjected.Token(Token = "0x4005034")]
	public const short AshWoodDresser = 5193;

	[Cpp2IlInjected.Token(Token = "0x4005035")]
	public const short AshWoodCandelabra = 5194;

	[Cpp2IlInjected.Token(Token = "0x4005036")]
	public const short AshWoodCandle = 5195;

	[Cpp2IlInjected.Token(Token = "0x4005037")]
	public const short AshWoodChair = 5196;

	[Cpp2IlInjected.Token(Token = "0x4005038")]
	public const short AshWoodChandelier = 5197;

	[Cpp2IlInjected.Token(Token = "0x4005039")]
	public const short AshWoodChest = 5198;

	[Cpp2IlInjected.Token(Token = "0x400503A")]
	public const short AshWoodClock = 5199;

	[Cpp2IlInjected.Token(Token = "0x400503B")]
	public const short AshWoodDoor = 5200;

	[Cpp2IlInjected.Token(Token = "0x400503C")]
	public const short AshWoodLamp = 5201;

	[Cpp2IlInjected.Token(Token = "0x400503D")]
	public const short AshWoodLantern = 5202;

	[Cpp2IlInjected.Token(Token = "0x400503E")]
	public const short AshWoodPiano = 5203;

	[Cpp2IlInjected.Token(Token = "0x400503F")]
	public const short AshWoodPlatform = 5204;

	[Cpp2IlInjected.Token(Token = "0x4005040")]
	public const short AshWoodSink = 5205;

	[Cpp2IlInjected.Token(Token = "0x4005041")]
	public const short AshWoodSofa = 5206;

	[Cpp2IlInjected.Token(Token = "0x4005042")]
	public const short AshWoodTable = 5207;

	[Cpp2IlInjected.Token(Token = "0x4005043")]
	public const short AshWoodWorkbench = 5208;

	[Cpp2IlInjected.Token(Token = "0x4005044")]
	public const short Fake_AshWoodChest = 5209;

	[Cpp2IlInjected.Token(Token = "0x4005045")]
	public const short AshWoodToilet = 5210;

	[Cpp2IlInjected.Token(Token = "0x4005046")]
	public const short BiomeSightPotion = 5211;

	[Cpp2IlInjected.Token(Token = "0x4005047")]
	public const short ScarletMacaw = 5212;

	[Cpp2IlInjected.Token(Token = "0x4005048")]
	public const short ScarletMacawCage = 5213;

	[Cpp2IlInjected.Token(Token = "0x4005049")]
	public const short AshGrassSeeds = 5214;

	[Cpp2IlInjected.Token(Token = "0x400504A")]
	public const short AshWood = 5215;

	[Cpp2IlInjected.Token(Token = "0x400504B")]
	public const short AshWoodWall = 5216;

	[Cpp2IlInjected.Token(Token = "0x400504C")]
	public const short AshWoodFence = 5217;

	[Cpp2IlInjected.Token(Token = "0x400504D")]
	public const short Outcast = 5218;

	[Cpp2IlInjected.Token(Token = "0x400504E")]
	public const short FairyGuides = 5219;

	[Cpp2IlInjected.Token(Token = "0x400504F")]
	public const short AHorribleNightforAlchemy = 5220;

	[Cpp2IlInjected.Token(Token = "0x4005050")]
	public const short MorningHunt = 5221;

	[Cpp2IlInjected.Token(Token = "0x4005051")]
	public const short SuspiciouslySparkly = 5222;

	[Cpp2IlInjected.Token(Token = "0x4005052")]
	public const short Requiem = 5223;

	[Cpp2IlInjected.Token(Token = "0x4005053")]
	public const short CatSword = 5224;

	[Cpp2IlInjected.Token(Token = "0x4005054")]
	public const short KargohsSummon = 5225;

	[Cpp2IlInjected.Token(Token = "0x4005055")]
	public const short HighPitch = 5226;

	[Cpp2IlInjected.Token(Token = "0x4005056")]
	public const short AMachineforTerrarians = 5227;

	[Cpp2IlInjected.Token(Token = "0x4005057")]
	public const short TerraBladeChronicles = 5228;

	[Cpp2IlInjected.Token(Token = "0x4005058")]
	public const short BennyWarhol = 5229;

	[Cpp2IlInjected.Token(Token = "0x4005059")]
	public const short LizardKing = 5230;

	[Cpp2IlInjected.Token(Token = "0x400505A")]
	public const short MySon = 5231;

	[Cpp2IlInjected.Token(Token = "0x400505B")]
	public const short Duality = 5232;

	[Cpp2IlInjected.Token(Token = "0x400505C")]
	public const short ParsecPals = 5233;

	[Cpp2IlInjected.Token(Token = "0x400505D")]
	public const short RemnantsofDevotion = 5234;

	[Cpp2IlInjected.Token(Token = "0x400505E")]
	public const short NotSoLostInParadise = 5235;

	[Cpp2IlInjected.Token(Token = "0x400505F")]
	public const short OcularResonance = 5236;

	[Cpp2IlInjected.Token(Token = "0x4005060")]
	public const short WingsofEvil = 5237;

	[Cpp2IlInjected.Token(Token = "0x4005061")]
	public const short Constellation = 5238;

	[Cpp2IlInjected.Token(Token = "0x4005062")]
	public const short Eyezorhead = 5239;

	[Cpp2IlInjected.Token(Token = "0x4005063")]
	public const short DreadoftheRedSea = 5240;

	[Cpp2IlInjected.Token(Token = "0x4005064")]
	public const short DoNotEattheVileMushroom = 5241;

	[Cpp2IlInjected.Token(Token = "0x4005065")]
	public const short YuumaTheBlueTiger = 5242;

	[Cpp2IlInjected.Token(Token = "0x4005066")]
	public const short MoonmanandCompany = 5243;

	[Cpp2IlInjected.Token(Token = "0x4005067")]
	public const short SunshineofIsrapony = 5244;

	[Cpp2IlInjected.Token(Token = "0x4005068")]
	public const short Purity = 5245;

	[Cpp2IlInjected.Token(Token = "0x4005069")]
	public const short SufficientlyAdvanced = 5246;

	[Cpp2IlInjected.Token(Token = "0x400506A")]
	public const short StrangeGrowth = 5247;

	[Cpp2IlInjected.Token(Token = "0x400506B")]
	public const short HappyLittleTree = 5248;

	[Cpp2IlInjected.Token(Token = "0x400506C")]
	public const short StrangeDeadFellows = 5249;

	[Cpp2IlInjected.Token(Token = "0x400506D")]
	public const short Secrets = 5250;

	[Cpp2IlInjected.Token(Token = "0x400506E")]
	public const short Thunderbolt = 5251;

	[Cpp2IlInjected.Token(Token = "0x400506F")]
	public const short Crustography = 5252;

	[Cpp2IlInjected.Token(Token = "0x4005070")]
	public const short TheWerewolf = 5253;

	[Cpp2IlInjected.Token(Token = "0x4005071")]
	public const short BlessingfromTheHeavens = 5254;

	[Cpp2IlInjected.Token(Token = "0x4005072")]
	public const short LoveisintheTrashSlot = 5255;

	[Cpp2IlInjected.Token(Token = "0x4005073")]
	public const short Fangs = 5256;

	[Cpp2IlInjected.Token(Token = "0x4005074")]
	public const short HailtotheKing = 5257;

	[Cpp2IlInjected.Token(Token = "0x4005075")]
	public const short SeeTheWorldForWhatItIs = 5258;

	[Cpp2IlInjected.Token(Token = "0x4005076")]
	public const short WhatLurksBelow = 5259;

	[Cpp2IlInjected.Token(Token = "0x4005077")]
	public const short ThisIsGettingOutOfHand = 5260;

	[Cpp2IlInjected.Token(Token = "0x4005078")]
	public const short Buddies = 5261;

	[Cpp2IlInjected.Token(Token = "0x4005079")]
	public const short MidnightSun = 5262;

	[Cpp2IlInjected.Token(Token = "0x400507A")]
	public const short CouchGag = 5263;

	[Cpp2IlInjected.Token(Token = "0x400507B")]
	public const short SilentFish = 5264;

	[Cpp2IlInjected.Token(Token = "0x400507C")]
	public const short TheDuke = 5265;

	[Cpp2IlInjected.Token(Token = "0x400507D")]
	public const short RoyalRomance = 5266;

	[Cpp2IlInjected.Token(Token = "0x400507E")]
	public const short Bioluminescence = 5267;

	[Cpp2IlInjected.Token(Token = "0x400507F")]
	public const short Wildflowers = 5268;

	[Cpp2IlInjected.Token(Token = "0x4005080")]
	public const short VikingVoyage = 5269;

	[Cpp2IlInjected.Token(Token = "0x4005081")]
	public const short Bifrost = 5270;

	[Cpp2IlInjected.Token(Token = "0x4005082")]
	public const short Heartlands = 5271;

	[Cpp2IlInjected.Token(Token = "0x4005083")]
	public const short ForestTroll = 5272;

	[Cpp2IlInjected.Token(Token = "0x4005084")]
	public const short AuroraBorealis = 5273;

	[Cpp2IlInjected.Token(Token = "0x4005085")]
	public const short LadyOfTheLake = 5274;

	[Cpp2IlInjected.Token(Token = "0x4005086")]
	public const short JojaCola = 5275;

	[Cpp2IlInjected.Token(Token = "0x4005087")]
	public const short JunimoPetItem = 5276;

	[Cpp2IlInjected.Token(Token = "0x4005088")]
	public const short SpicyPepper = 5277;

	[Cpp2IlInjected.Token(Token = "0x4005089")]
	public const short Pomegranate = 5278;

	[Cpp2IlInjected.Token(Token = "0x400508A")]
	public const short AshWoodHelmet = 5279;

	[Cpp2IlInjected.Token(Token = "0x400508B")]
	public const short AshWoodBreastplate = 5280;

	[Cpp2IlInjected.Token(Token = "0x400508C")]
	public const short AshWoodGreaves = 5281;

	[Cpp2IlInjected.Token(Token = "0x400508D")]
	public const short AshWoodBow = 5282;

	[Cpp2IlInjected.Token(Token = "0x400508E")]
	public const short AshWoodHammer = 5283;

	[Cpp2IlInjected.Token(Token = "0x400508F")]
	public const short AshWoodSword = 5284;

	[Cpp2IlInjected.Token(Token = "0x4005090")]
	public const short MoonGlobe = 5285;

	[Cpp2IlInjected.Token(Token = "0x4005091")]
	public const short RepairedLifeCrystal = 5286;

	[Cpp2IlInjected.Token(Token = "0x4005092")]
	public const short RepairedManaCrystal = 5287;

	[Cpp2IlInjected.Token(Token = "0x4005093")]
	public const short TerraFartMinecart = 5288;

	[Cpp2IlInjected.Token(Token = "0x4005094")]
	public const short MinecartPowerup = 5289;

	[Cpp2IlInjected.Token(Token = "0x4005095")]
	public const short JimsCap = 5290;

	[Cpp2IlInjected.Token(Token = "0x4005096")]
	public const short EchoWall = 5291;

	[Cpp2IlInjected.Token(Token = "0x4005097")]
	public const short EchoPlatform = 5292;

	[Cpp2IlInjected.Token(Token = "0x4005098")]
	public const short MushroomTorch = 5293;

	[Cpp2IlInjected.Token(Token = "0x4005099")]
	public const short HiveFive = 5294;

	[Cpp2IlInjected.Token(Token = "0x400509A")]
	public const short AcornAxe = 5295;

	[Cpp2IlInjected.Token(Token = "0x400509B")]
	public const short ChlorophyteExtractinator = 5296;

	[Cpp2IlInjected.Token(Token = "0x400509C")]
	public const short BlueEgg = 5297;

	[Cpp2IlInjected.Token(Token = "0x400509D")]
	public const short Trimarang = 5298;

	[Cpp2IlInjected.Token(Token = "0x400509E")]
	public const short MushroomCampfire = 5299;

	[Cpp2IlInjected.Token(Token = "0x400509F")]
	public const short BlueMacaw = 5300;

	[Cpp2IlInjected.Token(Token = "0x40050A0")]
	public const short BlueMacawCage = 5301;

	[Cpp2IlInjected.Token(Token = "0x40050A1")]
	public const short BottomlessHoneyBucket = 5302;

	[Cpp2IlInjected.Token(Token = "0x40050A2")]
	public const short HoneyAbsorbantSponge = 5303;

	[Cpp2IlInjected.Token(Token = "0x40050A3")]
	public const short UltraAbsorbantSponge = 5304;

	[Cpp2IlInjected.Token(Token = "0x40050A4")]
	public const short GoblorcEar = 5305;

	[Cpp2IlInjected.Token(Token = "0x40050A5")]
	public const short ReefBlock = 5306;

	[Cpp2IlInjected.Token(Token = "0x40050A6")]
	public const short ReefWall = 5307;

	[Cpp2IlInjected.Token(Token = "0x40050A7")]
	public const short PlacePainting = 5308;

	[Cpp2IlInjected.Token(Token = "0x40050A8")]
	public const short DontHurtNatureBook = 5309;

	[Cpp2IlInjected.Token(Token = "0x40050A9")]
	public const short PrincessStyle = 5310;

	[Cpp2IlInjected.Token(Token = "0x40050AA")]
	public const short Toucan = 5311;

	[Cpp2IlInjected.Token(Token = "0x40050AB")]
	public const short YellowCockatiel = 5312;

	[Cpp2IlInjected.Token(Token = "0x40050AC")]
	public const short GrayCockatiel = 5313;

	[Cpp2IlInjected.Token(Token = "0x40050AD")]
	public const short ToucanCage = 5314;

	[Cpp2IlInjected.Token(Token = "0x40050AE")]
	public const short YellowCockatielCage = 5315;

	[Cpp2IlInjected.Token(Token = "0x40050AF")]
	public const short GrayCockatielCage = 5316;

	[Cpp2IlInjected.Token(Token = "0x40050B0")]
	public const short MacawStatue = 5317;

	[Cpp2IlInjected.Token(Token = "0x40050B1")]
	public const short ToucanStatue = 5318;

	[Cpp2IlInjected.Token(Token = "0x40050B2")]
	public const short CockatielStatue = 5319;

	[Cpp2IlInjected.Token(Token = "0x40050B3")]
	public const short PlaceableHealingPotion = 5320;

	[Cpp2IlInjected.Token(Token = "0x40050B4")]
	public const short PlaceableManaPotion = 5321;

	[Cpp2IlInjected.Token(Token = "0x40050B5")]
	public const short ShadowCandle = 5322;

	[Cpp2IlInjected.Token(Token = "0x40050B6")]
	public const short DontHurtComboBook = 5323;

	[Cpp2IlInjected.Token(Token = "0x40050B7")]
	public const short RubblemakerSmall = 5324;

	[Cpp2IlInjected.Token(Token = "0x40050B8")]
	public const short ClosedVoidBag = 5325;

	[Cpp2IlInjected.Token(Token = "0x40050B9")]
	public const short ArtisanLoaf = 5326;

	[Cpp2IlInjected.Token(Token = "0x40050BA")]
	public const short TNTBarrel = 5327;

	[Cpp2IlInjected.Token(Token = "0x40050BB")]
	public const short ChestLock = 5328;

	[Cpp2IlInjected.Token(Token = "0x40050BC")]
	public const short RubblemakerMedium = 5329;

	[Cpp2IlInjected.Token(Token = "0x40050BD")]
	public const short RubblemakerLarge = 5330;

	[Cpp2IlInjected.Token(Token = "0x40050BE")]
	public const short HorseshoeBundle = 5331;

	[Cpp2IlInjected.Token(Token = "0x40050BF")]
	public const short SpiffoPlush = 5332;

	[Cpp2IlInjected.Token(Token = "0x40050C0")]
	public const short GlowTulip = 5333;

	[Cpp2IlInjected.Token(Token = "0x40050C1")]
	public const short MechdusaSummon = 5334;

	[Cpp2IlInjected.Token(Token = "0x40050C2")]
	public const short RodOfHarmony = 5335;

	[Cpp2IlInjected.Token(Token = "0x40050C3")]
	public const short CombatBookVolumeTwo = 5336;

	[Cpp2IlInjected.Token(Token = "0x40050C4")]
	public const short AegisCrystal = 5337;

	[Cpp2IlInjected.Token(Token = "0x40050C5")]
	public const short AegisFruit = 5338;

	[Cpp2IlInjected.Token(Token = "0x40050C6")]
	public const short ArcaneCrystal = 5339;

	[Cpp2IlInjected.Token(Token = "0x40050C7")]
	public const short GalaxyPearl = 5340;

	[Cpp2IlInjected.Token(Token = "0x40050C8")]
	public const short GummyWorm = 5341;

	[Cpp2IlInjected.Token(Token = "0x40050C9")]
	public const short Ambrosia = 5342;

	[Cpp2IlInjected.Token(Token = "0x40050CA")]
	public const short PeddlersSatchel = 5343;

	[Cpp2IlInjected.Token(Token = "0x40050CB")]
	public const short EchoCoating = 5344;

	[Cpp2IlInjected.Token(Token = "0x40050CC")]
	public const short EchoMonolith = 5345;

	[Cpp2IlInjected.Token(Token = "0x40050CD")]
	public const short GasTrap = 5346;

	[Cpp2IlInjected.Token(Token = "0x40050CE")]
	public const short ShimmerMonolith = 5347;

	[Cpp2IlInjected.Token(Token = "0x40050CF")]
	public const short ShimmerArrow = 5348;

	[Cpp2IlInjected.Token(Token = "0x40050D0")]
	public const short ShimmerBlock = 5349;

	[Cpp2IlInjected.Token(Token = "0x40050D1")]
	public const short Shimmerfly = 5350;

	[Cpp2IlInjected.Token(Token = "0x40050D2")]
	public const short ShimmerflyinaBottle = 5351;

	[Cpp2IlInjected.Token(Token = "0x40050D3")]
	public const short ShimmerSlimeBanner = 5352;

	[Cpp2IlInjected.Token(Token = "0x40050D4")]
	public const short ShimmerTorch = 5353;

	[Cpp2IlInjected.Token(Token = "0x40050D5")]
	public const short ReflectiveShades = 5354;

	[Cpp2IlInjected.Token(Token = "0x40050D6")]
	public const short ShimmerCloak = 5355;

	[Cpp2IlInjected.Token(Token = "0x40050D7")]
	public const short UsedGasTrap = 5356;

	[Cpp2IlInjected.Token(Token = "0x40050D8")]
	public const short ShimmerCampfire = 5357;

	[Cpp2IlInjected.Token(Token = "0x40050D9")]
	public const short Shellphone = 5358;

	[Cpp2IlInjected.Token(Token = "0x40050DA")]
	public const short ShellphoneSpawn = 5359;

	[Cpp2IlInjected.Token(Token = "0x40050DB")]
	public const short ShellphoneOcean = 5360;

	[Cpp2IlInjected.Token(Token = "0x40050DC")]
	public const short ShellphoneHell = 5361;

	[Cpp2IlInjected.Token(Token = "0x40050DD")]
	public const short MusicBoxShimmer = 5362;

	[Cpp2IlInjected.Token(Token = "0x40050DE")]
	public const short SpiderWallUnsafe = 5363;

	[Cpp2IlInjected.Token(Token = "0x40050DF")]
	public const short BottomlessShimmerBucket = 5364;

	[Cpp2IlInjected.Token(Token = "0x40050E0")]
	public const short BlueBrickWallUnsafe = 5365;

	[Cpp2IlInjected.Token(Token = "0x40050E1")]
	public const short BlueSlabWallUnsafe = 5366;

	[Cpp2IlInjected.Token(Token = "0x40050E2")]
	public const short BlueTiledWallUnsafe = 5367;

	[Cpp2IlInjected.Token(Token = "0x40050E3")]
	public const short PinkBrickWallUnsafe = 5368;

	[Cpp2IlInjected.Token(Token = "0x40050E4")]
	public const short PinkSlabWallUnsafe = 5369;

	[Cpp2IlInjected.Token(Token = "0x40050E5")]
	public const short PinkTiledWallUnsafe = 5370;

	[Cpp2IlInjected.Token(Token = "0x40050E6")]
	public const short GreenBrickWallUnsafe = 5371;

	[Cpp2IlInjected.Token(Token = "0x40050E7")]
	public const short GreenSlabWallUnsafe = 5372;

	[Cpp2IlInjected.Token(Token = "0x40050E8")]
	public const short GreenTiledWallUnsafe = 5373;

	[Cpp2IlInjected.Token(Token = "0x40050E9")]
	public const short SandstoneWallUnsafe = 5374;

	[Cpp2IlInjected.Token(Token = "0x40050EA")]
	public const short HardenedSandWallUnsafe = 5375;

	[Cpp2IlInjected.Token(Token = "0x40050EB")]
	public const short LihzahrdWallUnsafe = 5376;

	[Cpp2IlInjected.Token(Token = "0x40050EC")]
	public const short SpelunkerFlare = 5377;

	[Cpp2IlInjected.Token(Token = "0x40050ED")]
	public const short CursedFlare = 5378;

	[Cpp2IlInjected.Token(Token = "0x40050EE")]
	public const short RainbowFlare = 5379;

	[Cpp2IlInjected.Token(Token = "0x40050EF")]
	public const short ShimmerFlare = 5380;

	[Cpp2IlInjected.Token(Token = "0x40050F0")]
	public const short Moondial = 5381;

	[Cpp2IlInjected.Token(Token = "0x40050F1")]
	public const short WaffleIron = 5382;

	[Cpp2IlInjected.Token(Token = "0x40050F2")]
	public const short BouncyBoulder = 5383;

	[Cpp2IlInjected.Token(Token = "0x40050F3")]
	public const short LifeCrystalBoulder = 5384;

	[Cpp2IlInjected.Token(Token = "0x40050F4")]
	public const short DizzyHat = 5385;

	[Cpp2IlInjected.Token(Token = "0x40050F5")]
	public const short LincolnsHoodie = 5386;

	[Cpp2IlInjected.Token(Token = "0x40050F6")]
	public const short LincolnsPants = 5387;

	[Cpp2IlInjected.Token(Token = "0x40050F7")]
	public const short SunOrnament = 5388;

	[Cpp2IlInjected.Token(Token = "0x40050F8")]
	public const short HoplitePizza = 5389;

	[Cpp2IlInjected.Token(Token = "0x40050F9")]
	public const short LincolnsHood = 5390;

	[Cpp2IlInjected.Token(Token = "0x40050FA")]
	public const short UncumberingStone = 5391;

	[Cpp2IlInjected.Token(Token = "0x40050FB")]
	public const short SandSolution = 5392;

	[Cpp2IlInjected.Token(Token = "0x40050FC")]
	public const short SnowSolution = 5393;

	[Cpp2IlInjected.Token(Token = "0x40050FD")]
	public const short DirtSolution = 5394;

	[Cpp2IlInjected.Token(Token = "0x40050FE")]
	public const short PoopBlock = 5395;

	[Cpp2IlInjected.Token(Token = "0x40050FF")]
	public const short PoopWall = 5396;

	[Cpp2IlInjected.Token(Token = "0x4005100")]
	public const short ShimmerWall = 5397;

	[Cpp2IlInjected.Token(Token = "0x4005101")]
	public const short ShimmerBrick = 5398;

	[Cpp2IlInjected.Token(Token = "0x4005102")]
	public const short ShimmerBrickWall = 5399;

	[Cpp2IlInjected.Token(Token = "0x4005103")]
	public const short DirtiestBlock = 5400;

	[Cpp2IlInjected.Token(Token = "0x4005104")]
	public const short LunarRustBrick = 5401;

	[Cpp2IlInjected.Token(Token = "0x4005105")]
	public const short DarkCelestialBrick = 5402;

	[Cpp2IlInjected.Token(Token = "0x4005106")]
	public const short AstraBrick = 5403;

	[Cpp2IlInjected.Token(Token = "0x4005107")]
	public const short CosmicEmberBrick = 5404;

	[Cpp2IlInjected.Token(Token = "0x4005108")]
	public const short CryocoreBrick = 5405;

	[Cpp2IlInjected.Token(Token = "0x4005109")]
	public const short MercuryBrick = 5406;

	[Cpp2IlInjected.Token(Token = "0x400510A")]
	public const short StarRoyaleBrick = 5407;

	[Cpp2IlInjected.Token(Token = "0x400510B")]
	public const short HeavenforgeBrick = 5408;

	[Cpp2IlInjected.Token(Token = "0x400510C")]
	public const short LunarRustBrickWall = 5409;

	[Cpp2IlInjected.Token(Token = "0x400510D")]
	public const short DarkCelestialBrickWall = 5410;

	[Cpp2IlInjected.Token(Token = "0x400510E")]
	public const short AstraBrickWall = 5411;

	[Cpp2IlInjected.Token(Token = "0x400510F")]
	public const short CosmicEmberBrickWall = 5412;

	[Cpp2IlInjected.Token(Token = "0x4005110")]
	public const short CryocoreBrickWall = 5413;

	[Cpp2IlInjected.Token(Token = "0x4005111")]
	public const short MercuryBrickWall = 5414;

	[Cpp2IlInjected.Token(Token = "0x4005112")]
	public const short StarRoyaleBrickWall = 5415;

	[Cpp2IlInjected.Token(Token = "0x4005113")]
	public const short HeavenforgeBrickWall = 5416;

	[Cpp2IlInjected.Token(Token = "0x4005114")]
	public const short AncientBlueDungeonBrick = 5417;

	[Cpp2IlInjected.Token(Token = "0x4005115")]
	public const short AncientBlueDungeonBrickWall = 5418;

	[Cpp2IlInjected.Token(Token = "0x4005116")]
	public const short AncientGreenDungeonBrick = 5419;

	[Cpp2IlInjected.Token(Token = "0x4005117")]
	public const short AncientGreenDungeonBrickWall = 5420;

	[Cpp2IlInjected.Token(Token = "0x4005118")]
	public const short AncientPinkDungeonBrick = 5421;

	[Cpp2IlInjected.Token(Token = "0x4005119")]
	public const short AncientPinkDungeonBrickWall = 5422;

	[Cpp2IlInjected.Token(Token = "0x400511A")]
	public const short AncientGoldBrick = 5423;

	[Cpp2IlInjected.Token(Token = "0x400511B")]
	public const short AncientGoldBrickWall = 5424;

	[Cpp2IlInjected.Token(Token = "0x400511C")]
	public const short AncientSilverBrick = 5425;

	[Cpp2IlInjected.Token(Token = "0x400511D")]
	public const short AncientSilverBrickWall = 5426;

	[Cpp2IlInjected.Token(Token = "0x400511E")]
	public const short AncientCopperBrick = 5427;

	[Cpp2IlInjected.Token(Token = "0x400511F")]
	public const short AncientCopperBrickWall = 5428;

	[Cpp2IlInjected.Token(Token = "0x4005120")]
	public const short AncientCobaltBrick = 5429;

	[Cpp2IlInjected.Token(Token = "0x4005121")]
	public const short AncientCobaltBrickWall = 5430;

	[Cpp2IlInjected.Token(Token = "0x4005122")]
	public const short AncientMythrilBrick = 5431;

	[Cpp2IlInjected.Token(Token = "0x4005123")]
	public const short AncientMythrilBrickWall = 5432;

	[Cpp2IlInjected.Token(Token = "0x4005124")]
	public const short AncientObsidianBrick = 5433;

	[Cpp2IlInjected.Token(Token = "0x4005125")]
	public const short AncientObsidianBrickWall = 5434;

	[Cpp2IlInjected.Token(Token = "0x4005126")]
	public const short AncientHellstoneBrick = 5435;

	[Cpp2IlInjected.Token(Token = "0x4005127")]
	public const short AncientHellstoneBrickWall = 5436;

	[Cpp2IlInjected.Token(Token = "0x4005128")]
	public const short ShellphoneDummy = 5437;

	[Cpp2IlInjected.Token(Token = "0x4005129")]
	public const short Fertilizer = 5438;

	[Cpp2IlInjected.Token(Token = "0x400512A")]
	public const short LavaMossBlock = 5439;

	[Cpp2IlInjected.Token(Token = "0x400512B")]
	public const short ArgonMossBlock = 5440;

	[Cpp2IlInjected.Token(Token = "0x400512C")]
	public const short KryptonMossBlock = 5441;

	[Cpp2IlInjected.Token(Token = "0x400512D")]
	public const short XenonMossBlock = 5442;

	[Cpp2IlInjected.Token(Token = "0x400512E")]
	public const short VioletMossBlock = 5443;

	[Cpp2IlInjected.Token(Token = "0x400512F")]
	public const short RainbowMossBlock = 5444;

	[Cpp2IlInjected.Token(Token = "0x4005130")]
	public const short LavaMossBlockWall = 5445;

	[Cpp2IlInjected.Token(Token = "0x4005131")]
	public const short ArgonMossBlockWall = 5446;

	[Cpp2IlInjected.Token(Token = "0x4005132")]
	public const short KryptonMossBlockWall = 5447;

	[Cpp2IlInjected.Token(Token = "0x4005133")]
	public const short XenonMossBlockWall = 5448;

	[Cpp2IlInjected.Token(Token = "0x4005134")]
	public const short VioletMossBlockWall = 5449;

	[Cpp2IlInjected.Token(Token = "0x4005135")]
	public const short RainbowMossBlockWall = 5450;

	[Cpp2IlInjected.Token(Token = "0x4005136")]
	public const short JimsDrone = 5451;

	[Cpp2IlInjected.Token(Token = "0x4005137")]
	public const short JimsDroneVisor = 5452;

	[Cpp2IlInjected.Token(Token = "0x4005138")]
	public const short DontHurtCrittersBookInactive = 5453;

	[Cpp2IlInjected.Token(Token = "0x4005139")]
	public const short DontHurtNatureBookInactive = 5454;

	[Cpp2IlInjected.Token(Token = "0x400513A")]
	public const short DontHurtComboBookInactive = 5455;

	[Cpp2IlInjected.Token(Token = "0x400513B")]
	public const short Count = 5456;

	[Cpp2IlInjected.Token(Token = "0x400513C")]
	public static readonly IdDictionary Search;

	[Cpp2IlInjected.Token(Token = "0x6003093")]
	[Cpp2IlInjected.Address(RVA = "0x14156F4", Offset = "0x14156F4", VA = "0x14156F4")]
	private static Dictionary<string, short> GenerateLegacyItemDictionary()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003094")]
	[Cpp2IlInjected.Address(RVA = "0x141A8E0", Offset = "0x141A8E0", VA = "0x141A8E0")]
	public static short FromNetId(short id)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6003095")]
	[Cpp2IlInjected.Address(RVA = "0x141AB34", Offset = "0x141AB34", VA = "0x141AB34")]
	public static short FromLegacyName(string name, int release)
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6003096")]
	[Cpp2IlInjected.Address(RVA = "0x141AEE0", Offset = "0x141AEE0", VA = "0x141AEE0")]
	public ItemID()
	{
	}
}
