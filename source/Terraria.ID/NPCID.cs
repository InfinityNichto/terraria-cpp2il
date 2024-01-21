using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;

namespace Terraria.ID;

[Cpp2IlInjected.Token(Token = "0x20003FC")]
public class NPCID
{
	[Cpp2IlInjected.Token(Token = "0x2000919")]
	public static class Sets
	{
		[Cpp2IlInjected.Token(Token = "0x2000B70")]
		public struct NPCBestiaryDrawModifiers
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4009084")]
			public Vector2 Position;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4009085")]
			public float? PortraitPositionXOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4009086")]
			public float? PortraitPositionYOverride;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4009087")]
			public float Rotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4009088")]
			public float Scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4009089")]
			public float? PortraitScale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400908A")]
			public bool Hide;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x400908B")]
			public bool IsWet;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400908C")]
			public int? Frame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400908D")]
			public int? Direction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400908E")]
			public int? SpriteDirection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400908F")]
			public float Velocity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4009090")]
			public string CustomTexturePath;

			[Cpp2IlInjected.Token(Token = "0x60053B0")]
			[Cpp2IlInjected.Address(RVA = "0x39F340", Offset = "0x39F340", VA = "0x39F340")]
			public NPCBestiaryDrawModifiers(int seriouslyWhyCantStructsHaveParameterlessConstructors)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000B71")]
		private static class LocalBuffID
		{
			[Cpp2IlInjected.Token(Token = "0x4009091")]
			public const int Confused = 31;

			[Cpp2IlInjected.Token(Token = "0x4009092")]
			public const int Poisoned = 20;

			[Cpp2IlInjected.Token(Token = "0x4009093")]
			public const int OnFire = 24;

			[Cpp2IlInjected.Token(Token = "0x4009094")]
			public const int OnFire3 = 323;

			[Cpp2IlInjected.Token(Token = "0x4009095")]
			public const int ShadowFlame = 153;

			[Cpp2IlInjected.Token(Token = "0x4009096")]
			public const int Daybreak = 189;

			[Cpp2IlInjected.Token(Token = "0x4009097")]
			public const int Frostburn = 44;

			[Cpp2IlInjected.Token(Token = "0x4009098")]
			public const int Frostburn2 = 324;

			[Cpp2IlInjected.Token(Token = "0x4009099")]
			public const int CursedInferno = 39;

			[Cpp2IlInjected.Token(Token = "0x400909A")]
			public const int BetsysCurse = 203;

			[Cpp2IlInjected.Token(Token = "0x400909B")]
			public const int Ichor = 69;

			[Cpp2IlInjected.Token(Token = "0x400909C")]
			public const int Venom = 70;

			[Cpp2IlInjected.Token(Token = "0x400909D")]
			public const int Oiled = 204;

			[Cpp2IlInjected.Token(Token = "0x400909E")]
			public const int BoneJavelin = 169;

			[Cpp2IlInjected.Token(Token = "0x400909F")]
			public const int TentacleSpike = 337;

			[Cpp2IlInjected.Token(Token = "0x40090A0")]
			public const int BloodButcherer = 344;
		}

		[Cpp2IlInjected.Token(Token = "0x40089B9")]
		public static SetFactory Factory;

		[Cpp2IlInjected.Token(Token = "0x40089BA")]
		public static Dictionary<int, int> SpecialSpawningRules;

		[Cpp2IlInjected.Token(Token = "0x40089BB")]
		public static Dictionary<int, NPCBestiaryDrawModifiers> NPCBestiaryDrawOffset;

		[Cpp2IlInjected.Token(Token = "0x40089BC")]
		public static Dictionary<int, NPCDebuffImmunityData> DebuffImmunitySets;

		[Cpp2IlInjected.Token(Token = "0x40089BD")]
		public static List<int> NormalGoldCritterBestiaryPriority;

		[Cpp2IlInjected.Token(Token = "0x40089BE")]
		public static List<int> BossBestiaryPriority;

		[Cpp2IlInjected.Token(Token = "0x40089BF")]
		public static List<int> TownNPCBestiaryPriority;

		[Cpp2IlInjected.Token(Token = "0x40089C0")]
		public static bool[] DontDoHardmodeScaling;

		[Cpp2IlInjected.Token(Token = "0x40089C1")]
		public static bool[] ReflectStarShotsInForTheWorthy;

		[Cpp2IlInjected.Token(Token = "0x40089C2")]
		public static bool[] IsTownPet;

		[Cpp2IlInjected.Token(Token = "0x40089C3")]
		public static bool[] IsTownSlime;

		[Cpp2IlInjected.Token(Token = "0x40089C4")]
		public static bool[] CanConvertIntoCopperSlimeTownNPC;

		[Cpp2IlInjected.Token(Token = "0x40089C5")]
		public static List<int> GoldCrittersCollection;

		[Cpp2IlInjected.Token(Token = "0x40089C6")]
		public static bool[] ZappingJellyfish;

		[Cpp2IlInjected.Token(Token = "0x40089C7")]
		public static bool[] CantTakeLunchMoney;

		[Cpp2IlInjected.Token(Token = "0x40089C8")]
		public static Dictionary<int, int> RespawnEnemyID;

		[Cpp2IlInjected.Token(Token = "0x40089C9")]
		public static int[] TrailingMode;

		[Cpp2IlInjected.Token(Token = "0x40089CA")]
		public static bool[] IsDragonfly;

		[Cpp2IlInjected.Token(Token = "0x40089CB")]
		public static bool[] BelongsToInvasionOldOnesArmy;

		[Cpp2IlInjected.Token(Token = "0x40089CC")]
		public static bool[] TeleportationImmune;

		[Cpp2IlInjected.Token(Token = "0x40089CD")]
		public static bool[] UsesNewTargetting;

		[Cpp2IlInjected.Token(Token = "0x40089CE")]
		public static bool[] TakesDamageFromHostilesWithoutBeingFriendly;

		[Cpp2IlInjected.Token(Token = "0x40089CF")]
		public static bool[] AllNPCs;

		[Cpp2IlInjected.Token(Token = "0x40089D0")]
		public static bool[] HurtingBees;

		[Cpp2IlInjected.Token(Token = "0x40089D1")]
		public static bool[] FighterUsesDD2PortalAppearEffect;

		[Cpp2IlInjected.Token(Token = "0x40089D2")]
		public static float[] StatueSpawnedDropRarity;

		[Cpp2IlInjected.Token(Token = "0x40089D3")]
		public static bool[] NoEarlymodeLootWhenSpawnedFromStatue;

		[Cpp2IlInjected.Token(Token = "0x40089D4")]
		public static bool[] NeedsExpertScaling;

		[Cpp2IlInjected.Token(Token = "0x40089D5")]
		public static bool[] ProjectileNPC;

		[Cpp2IlInjected.Token(Token = "0x40089D6")]
		public static bool[] SavesAndLoads;

		[Cpp2IlInjected.Token(Token = "0x40089D7")]
		public static int[] TrailCacheLength;

		[Cpp2IlInjected.Token(Token = "0x40089D8")]
		public static bool[] UsesMultiplayerProximitySyncing;

		[Cpp2IlInjected.Token(Token = "0x40089D9")]
		public static bool[] NoMultiplayerSmoothingByType;

		[Cpp2IlInjected.Token(Token = "0x40089DA")]
		public static bool[] NoMultiplayerSmoothingByAI;

		[Cpp2IlInjected.Token(Token = "0x40089DB")]
		public static bool[] MPAllowedEnemies;

		[Cpp2IlInjected.Token(Token = "0x40089DC")]
		public static bool[] TownCritter;

		[Cpp2IlInjected.Token(Token = "0x40089DD")]
		public static bool[] CountsAsCritter;

		[Cpp2IlInjected.Token(Token = "0x40089DE")]
		public static bool[] HasNoPartyText;

		[Cpp2IlInjected.Token(Token = "0x40089DF")]
		public static int[] HatOffsetY;

		[Cpp2IlInjected.Token(Token = "0x40089E0")]
		public static int[] FaceEmote;

		[Cpp2IlInjected.Token(Token = "0x40089E1")]
		public static int[] ExtraFramesCount;

		[Cpp2IlInjected.Token(Token = "0x40089E2")]
		public static int[] AttackFrameCount;

		[Cpp2IlInjected.Token(Token = "0x40089E3")]
		public static int[] DangerDetectRange;

		[Cpp2IlInjected.Token(Token = "0x40089E4")]
		public static bool[] ShimmerImmunity;

		[Cpp2IlInjected.Token(Token = "0x40089E5")]
		public static int[] ShimmerTransformToItem;

		[Cpp2IlInjected.Token(Token = "0x40089E6")]
		public static bool[] ShimmerTownTransform;

		[Cpp2IlInjected.Token(Token = "0x40089E7")]
		public static int[] ShimmerTransformToNPC;

		[Cpp2IlInjected.Token(Token = "0x40089E8")]
		public static int[] AttackTime;

		[Cpp2IlInjected.Token(Token = "0x40089E9")]
		public static int[] AttackAverageChance;

		[Cpp2IlInjected.Token(Token = "0x40089EA")]
		public static int[] AttackType;

		[Cpp2IlInjected.Token(Token = "0x40089EB")]
		public static int[] PrettySafe;

		[Cpp2IlInjected.Token(Token = "0x40089EC")]
		public static Color[] MagicAuraColor;

		[Cpp2IlInjected.Token(Token = "0x40089ED")]
		public static bool[] DemonEyes;

		[Cpp2IlInjected.Token(Token = "0x40089EE")]
		public static bool[] Zombies;

		[Cpp2IlInjected.Token(Token = "0x40089EF")]
		public static bool[] Skeletons;

		[Cpp2IlInjected.Token(Token = "0x40089F0")]
		public static int[] BossHeadTextures;

		[Cpp2IlInjected.Token(Token = "0x40089F1")]
		public static bool[] PositiveNPCTypesExcludedFromDeathTally;

		[Cpp2IlInjected.Token(Token = "0x40089F2")]
		public static bool[] ShouldBeCountedAsBoss;

		[Cpp2IlInjected.Token(Token = "0x40089F3")]
		public static bool[] DangerThatPreventsOtherDangers;

		[Cpp2IlInjected.Token(Token = "0x40089F4")]
		public static bool[] MustAlwaysDraw;

		[Cpp2IlInjected.Token(Token = "0x40089F5")]
		public static bool[] ExpandedCullDraw;

		[Cpp2IlInjected.Token(Token = "0x40089F6")]
		public static int[] ExtraTextureCount;

		[Cpp2IlInjected.Token(Token = "0x40089F7")]
		public static int[] NPCFramingGroup;

		[Cpp2IlInjected.Token(Token = "0x40089F8")]
		public static bool[] CanHitPastShimmer;

		[Cpp2IlInjected.Token(Token = "0x40089F9")]
		public static int[][] TownNPCsFramingGroups;

		[Cpp2IlInjected.Token(Token = "0x6004CB0")]
		[Cpp2IlInjected.Address(RVA = "0x1522978", Offset = "0x1522978", VA = "0x1522978")]
		public static Dictionary<int, NPCBestiaryDrawModifiers> NPCBestiaryDrawOffsetCreation()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB1")]
		[Cpp2IlInjected.Address(RVA = "0x1522D1C", Offset = "0x1522D1C", VA = "0x1522D1C")]
		private static Dictionary<int, NPCBestiaryDrawModifiers> GetRedigitEntries()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB2")]
		[Cpp2IlInjected.Address(RVA = "0x1537394", Offset = "0x1537394", VA = "0x1537394")]
		private static Dictionary<int, NPCBestiaryDrawModifiers> GetGroxEntries()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004CB3")]
		[Cpp2IlInjected.Address(RVA = "0x1523BF8", Offset = "0x1523BF8", VA = "0x1523BF8")]
		private static Dictionary<int, NPCBestiaryDrawModifiers> GetLeinforsEntries()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40052C7")]
	private static readonly int[] NetIdMap;

	[Cpp2IlInjected.Token(Token = "0x40052C8")]
	private static readonly Dictionary<string, int> LegacyNameToIdMap;

	[Cpp2IlInjected.Token(Token = "0x40052C9")]
	public const short NegativeIDCount = -66;

	[Cpp2IlInjected.Token(Token = "0x40052CA")]
	public const short BigHornetStingy = -65;

	[Cpp2IlInjected.Token(Token = "0x40052CB")]
	public const short LittleHornetStingy = -64;

	[Cpp2IlInjected.Token(Token = "0x40052CC")]
	public const short BigHornetSpikey = -63;

	[Cpp2IlInjected.Token(Token = "0x40052CD")]
	public const short LittleHornetSpikey = -62;

	[Cpp2IlInjected.Token(Token = "0x40052CE")]
	public const short BigHornetLeafy = -61;

	[Cpp2IlInjected.Token(Token = "0x40052CF")]
	public const short LittleHornetLeafy = -60;

	[Cpp2IlInjected.Token(Token = "0x40052D0")]
	public const short BigHornetHoney = -59;

	[Cpp2IlInjected.Token(Token = "0x40052D1")]
	public const short LittleHornetHoney = -58;

	[Cpp2IlInjected.Token(Token = "0x40052D2")]
	public const short BigHornetFatty = -57;

	[Cpp2IlInjected.Token(Token = "0x40052D3")]
	public const short LittleHornetFatty = -56;

	[Cpp2IlInjected.Token(Token = "0x40052D4")]
	public const short BigRainZombie = -55;

	[Cpp2IlInjected.Token(Token = "0x40052D5")]
	public const short SmallRainZombie = -54;

	[Cpp2IlInjected.Token(Token = "0x40052D6")]
	public const short BigPantlessSkeleton = -53;

	[Cpp2IlInjected.Token(Token = "0x40052D7")]
	public const short SmallPantlessSkeleton = -52;

	[Cpp2IlInjected.Token(Token = "0x40052D8")]
	public const short BigMisassembledSkeleton = -51;

	[Cpp2IlInjected.Token(Token = "0x40052D9")]
	public const short SmallMisassembledSkeleton = -50;

	[Cpp2IlInjected.Token(Token = "0x40052DA")]
	public const short BigHeadacheSkeleton = -49;

	[Cpp2IlInjected.Token(Token = "0x40052DB")]
	public const short SmallHeadacheSkeleton = -48;

	[Cpp2IlInjected.Token(Token = "0x40052DC")]
	public const short BigSkeleton = -47;

	[Cpp2IlInjected.Token(Token = "0x40052DD")]
	public const short SmallSkeleton = -46;

	[Cpp2IlInjected.Token(Token = "0x40052DE")]
	public const short BigFemaleZombie = -45;

	[Cpp2IlInjected.Token(Token = "0x40052DF")]
	public const short SmallFemaleZombie = -44;

	[Cpp2IlInjected.Token(Token = "0x40052E0")]
	public const short DemonEye2 = -43;

	[Cpp2IlInjected.Token(Token = "0x40052E1")]
	public const short PurpleEye2 = -42;

	[Cpp2IlInjected.Token(Token = "0x40052E2")]
	public const short GreenEye2 = -41;

	[Cpp2IlInjected.Token(Token = "0x40052E3")]
	public const short DialatedEye2 = -40;

	[Cpp2IlInjected.Token(Token = "0x40052E4")]
	public const short SleepyEye2 = -39;

	[Cpp2IlInjected.Token(Token = "0x40052E5")]
	public const short CataractEye2 = -38;

	[Cpp2IlInjected.Token(Token = "0x40052E6")]
	public const short BigTwiggyZombie = -37;

	[Cpp2IlInjected.Token(Token = "0x40052E7")]
	public const short SmallTwiggyZombie = -36;

	[Cpp2IlInjected.Token(Token = "0x40052E8")]
	public const short BigSwampZombie = -35;

	[Cpp2IlInjected.Token(Token = "0x40052E9")]
	public const short SmallSwampZombie = -34;

	[Cpp2IlInjected.Token(Token = "0x40052EA")]
	public const short BigSlimedZombie = -33;

	[Cpp2IlInjected.Token(Token = "0x40052EB")]
	public const short SmallSlimedZombie = -32;

	[Cpp2IlInjected.Token(Token = "0x40052EC")]
	public const short BigPincushionZombie = -31;

	[Cpp2IlInjected.Token(Token = "0x40052ED")]
	public const short SmallPincushionZombie = -30;

	[Cpp2IlInjected.Token(Token = "0x40052EE")]
	public const short BigBaldZombie = -29;

	[Cpp2IlInjected.Token(Token = "0x40052EF")]
	public const short SmallBaldZombie = -28;

	[Cpp2IlInjected.Token(Token = "0x40052F0")]
	public const short BigZombie = -27;

	[Cpp2IlInjected.Token(Token = "0x40052F1")]
	public const short SmallZombie = -26;

	[Cpp2IlInjected.Token(Token = "0x40052F2")]
	public const short BigCrimslime = -25;

	[Cpp2IlInjected.Token(Token = "0x40052F3")]
	public const short LittleCrimslime = -24;

	[Cpp2IlInjected.Token(Token = "0x40052F4")]
	public const short BigCrimera = -23;

	[Cpp2IlInjected.Token(Token = "0x40052F5")]
	public const short LittleCrimera = -22;

	[Cpp2IlInjected.Token(Token = "0x40052F6")]
	public const short GiantMossHornet = -21;

	[Cpp2IlInjected.Token(Token = "0x40052F7")]
	public const short BigMossHornet = -20;

	[Cpp2IlInjected.Token(Token = "0x40052F8")]
	public const short LittleMossHornet = -19;

	[Cpp2IlInjected.Token(Token = "0x40052F9")]
	public const short TinyMossHornet = -18;

	[Cpp2IlInjected.Token(Token = "0x40052FA")]
	public const short BigStinger = -17;

	[Cpp2IlInjected.Token(Token = "0x40052FB")]
	public const short LittleStinger = -16;

	[Cpp2IlInjected.Token(Token = "0x40052FC")]
	public const short HeavySkeleton = -15;

	[Cpp2IlInjected.Token(Token = "0x40052FD")]
	public const short BigBoned = -14;

	[Cpp2IlInjected.Token(Token = "0x40052FE")]
	public const short ShortBones = -13;

	[Cpp2IlInjected.Token(Token = "0x40052FF")]
	public const short BigEater = -12;

	[Cpp2IlInjected.Token(Token = "0x4005300")]
	public const short LittleEater = -11;

	[Cpp2IlInjected.Token(Token = "0x4005301")]
	public const short JungleSlime = -10;

	[Cpp2IlInjected.Token(Token = "0x4005302")]
	public const short YellowSlime = -9;

	[Cpp2IlInjected.Token(Token = "0x4005303")]
	public const short RedSlime = -8;

	[Cpp2IlInjected.Token(Token = "0x4005304")]
	public const short PurpleSlime = -7;

	[Cpp2IlInjected.Token(Token = "0x4005305")]
	public const short BlackSlime = -6;

	[Cpp2IlInjected.Token(Token = "0x4005306")]
	public const short BabySlime = -5;

	[Cpp2IlInjected.Token(Token = "0x4005307")]
	public const short Pinky = -4;

	[Cpp2IlInjected.Token(Token = "0x4005308")]
	public const short GreenSlime = -3;

	[Cpp2IlInjected.Token(Token = "0x4005309")]
	public const short Slimer2 = -2;

	[Cpp2IlInjected.Token(Token = "0x400530A")]
	public const short Slimeling = -1;

	[Cpp2IlInjected.Token(Token = "0x400530B")]
	public const short None = 0;

	[Cpp2IlInjected.Token(Token = "0x400530C")]
	public const short BlueSlime = 1;

	[Cpp2IlInjected.Token(Token = "0x400530D")]
	public const short DemonEye = 2;

	[Cpp2IlInjected.Token(Token = "0x400530E")]
	public const short Zombie = 3;

	[Cpp2IlInjected.Token(Token = "0x400530F")]
	public const short EyeofCthulhu = 4;

	[Cpp2IlInjected.Token(Token = "0x4005310")]
	public const short ServantofCthulhu = 5;

	[Cpp2IlInjected.Token(Token = "0x4005311")]
	public const short EaterofSouls = 6;

	[Cpp2IlInjected.Token(Token = "0x4005312")]
	public const short DevourerHead = 7;

	[Cpp2IlInjected.Token(Token = "0x4005313")]
	public const short DevourerBody = 8;

	[Cpp2IlInjected.Token(Token = "0x4005314")]
	public const short DevourerTail = 9;

	[Cpp2IlInjected.Token(Token = "0x4005315")]
	public const short GiantWormHead = 10;

	[Cpp2IlInjected.Token(Token = "0x4005316")]
	public const short GiantWormBody = 11;

	[Cpp2IlInjected.Token(Token = "0x4005317")]
	public const short GiantWormTail = 12;

	[Cpp2IlInjected.Token(Token = "0x4005318")]
	public const short EaterofWorldsHead = 13;

	[Cpp2IlInjected.Token(Token = "0x4005319")]
	public const short EaterofWorldsBody = 14;

	[Cpp2IlInjected.Token(Token = "0x400531A")]
	public const short EaterofWorldsTail = 15;

	[Cpp2IlInjected.Token(Token = "0x400531B")]
	public const short MotherSlime = 16;

	[Cpp2IlInjected.Token(Token = "0x400531C")]
	public const short Merchant = 17;

	[Cpp2IlInjected.Token(Token = "0x400531D")]
	public const short Nurse = 18;

	[Cpp2IlInjected.Token(Token = "0x400531E")]
	public const short ArmsDealer = 19;

	[Cpp2IlInjected.Token(Token = "0x400531F")]
	public const short Dryad = 20;

	[Cpp2IlInjected.Token(Token = "0x4005320")]
	public const short Skeleton = 21;

	[Cpp2IlInjected.Token(Token = "0x4005321")]
	public const short Guide = 22;

	[Cpp2IlInjected.Token(Token = "0x4005322")]
	public const short MeteorHead = 23;

	[Cpp2IlInjected.Token(Token = "0x4005323")]
	public const short FireImp = 24;

	[Cpp2IlInjected.Token(Token = "0x4005324")]
	public const short BurningSphere = 25;

	[Cpp2IlInjected.Token(Token = "0x4005325")]
	public const short GoblinPeon = 26;

	[Cpp2IlInjected.Token(Token = "0x4005326")]
	public const short GoblinThief = 27;

	[Cpp2IlInjected.Token(Token = "0x4005327")]
	public const short GoblinWarrior = 28;

	[Cpp2IlInjected.Token(Token = "0x4005328")]
	public const short GoblinSorcerer = 29;

	[Cpp2IlInjected.Token(Token = "0x4005329")]
	public const short ChaosBall = 30;

	[Cpp2IlInjected.Token(Token = "0x400532A")]
	public const short AngryBones = 31;

	[Cpp2IlInjected.Token(Token = "0x400532B")]
	public const short DarkCaster = 32;

	[Cpp2IlInjected.Token(Token = "0x400532C")]
	public const short WaterSphere = 33;

	[Cpp2IlInjected.Token(Token = "0x400532D")]
	public const short CursedSkull = 34;

	[Cpp2IlInjected.Token(Token = "0x400532E")]
	public const short SkeletronHead = 35;

	[Cpp2IlInjected.Token(Token = "0x400532F")]
	public const short SkeletronHand = 36;

	[Cpp2IlInjected.Token(Token = "0x4005330")]
	public const short OldMan = 37;

	[Cpp2IlInjected.Token(Token = "0x4005331")]
	public const short Demolitionist = 38;

	[Cpp2IlInjected.Token(Token = "0x4005332")]
	public const short BoneSerpentHead = 39;

	[Cpp2IlInjected.Token(Token = "0x4005333")]
	public const short BoneSerpentBody = 40;

	[Cpp2IlInjected.Token(Token = "0x4005334")]
	public const short BoneSerpentTail = 41;

	[Cpp2IlInjected.Token(Token = "0x4005335")]
	public const short Hornet = 42;

	[Cpp2IlInjected.Token(Token = "0x4005336")]
	public const short ManEater = 43;

	[Cpp2IlInjected.Token(Token = "0x4005337")]
	public const short UndeadMiner = 44;

	[Cpp2IlInjected.Token(Token = "0x4005338")]
	public const short Tim = 45;

	[Cpp2IlInjected.Token(Token = "0x4005339")]
	public const short Bunny = 46;

	[Cpp2IlInjected.Token(Token = "0x400533A")]
	public const short CorruptBunny = 47;

	[Cpp2IlInjected.Token(Token = "0x400533B")]
	public const short Harpy = 48;

	[Cpp2IlInjected.Token(Token = "0x400533C")]
	public const short CaveBat = 49;

	[Cpp2IlInjected.Token(Token = "0x400533D")]
	public const short KingSlime = 50;

	[Cpp2IlInjected.Token(Token = "0x400533E")]
	public const short JungleBat = 51;

	[Cpp2IlInjected.Token(Token = "0x400533F")]
	public const short DoctorBones = 52;

	[Cpp2IlInjected.Token(Token = "0x4005340")]
	public const short TheGroom = 53;

	[Cpp2IlInjected.Token(Token = "0x4005341")]
	public const short Clothier = 54;

	[Cpp2IlInjected.Token(Token = "0x4005342")]
	public const short Goldfish = 55;

	[Cpp2IlInjected.Token(Token = "0x4005343")]
	public const short Snatcher = 56;

	[Cpp2IlInjected.Token(Token = "0x4005344")]
	public const short CorruptGoldfish = 57;

	[Cpp2IlInjected.Token(Token = "0x4005345")]
	public const short Piranha = 58;

	[Cpp2IlInjected.Token(Token = "0x4005346")]
	public const short LavaSlime = 59;

	[Cpp2IlInjected.Token(Token = "0x4005347")]
	public const short Hellbat = 60;

	[Cpp2IlInjected.Token(Token = "0x4005348")]
	public const short Vulture = 61;

	[Cpp2IlInjected.Token(Token = "0x4005349")]
	public const short Demon = 62;

	[Cpp2IlInjected.Token(Token = "0x400534A")]
	public const short BlueJellyfish = 63;

	[Cpp2IlInjected.Token(Token = "0x400534B")]
	public const short PinkJellyfish = 64;

	[Cpp2IlInjected.Token(Token = "0x400534C")]
	public const short Shark = 65;

	[Cpp2IlInjected.Token(Token = "0x400534D")]
	public const short VoodooDemon = 66;

	[Cpp2IlInjected.Token(Token = "0x400534E")]
	public const short Crab = 67;

	[Cpp2IlInjected.Token(Token = "0x400534F")]
	public const short DungeonGuardian = 68;

	[Cpp2IlInjected.Token(Token = "0x4005350")]
	public const short Antlion = 69;

	[Cpp2IlInjected.Token(Token = "0x4005351")]
	public const short SpikeBall = 70;

	[Cpp2IlInjected.Token(Token = "0x4005352")]
	public const short DungeonSlime = 71;

	[Cpp2IlInjected.Token(Token = "0x4005353")]
	public const short BlazingWheel = 72;

	[Cpp2IlInjected.Token(Token = "0x4005354")]
	public const short GoblinScout = 73;

	[Cpp2IlInjected.Token(Token = "0x4005355")]
	public const short Bird = 74;

	[Cpp2IlInjected.Token(Token = "0x4005356")]
	public const short Pixie = 75;

	[Cpp2IlInjected.Token(Token = "0x4005357")]
	public const short None2 = 76;

	[Cpp2IlInjected.Token(Token = "0x4005358")]
	public const short ArmoredSkeleton = 77;

	[Cpp2IlInjected.Token(Token = "0x4005359")]
	public const short Mummy = 78;

	[Cpp2IlInjected.Token(Token = "0x400535A")]
	public const short DarkMummy = 79;

	[Cpp2IlInjected.Token(Token = "0x400535B")]
	public const short LightMummy = 80;

	[Cpp2IlInjected.Token(Token = "0x400535C")]
	public const short CorruptSlime = 81;

	[Cpp2IlInjected.Token(Token = "0x400535D")]
	public const short Wraith = 82;

	[Cpp2IlInjected.Token(Token = "0x400535E")]
	public const short CursedHammer = 83;

	[Cpp2IlInjected.Token(Token = "0x400535F")]
	public const short EnchantedSword = 84;

	[Cpp2IlInjected.Token(Token = "0x4005360")]
	public const short Mimic = 85;

	[Cpp2IlInjected.Token(Token = "0x4005361")]
	public const short Unicorn = 86;

	[Cpp2IlInjected.Token(Token = "0x4005362")]
	public const short WyvernHead = 87;

	[Cpp2IlInjected.Token(Token = "0x4005363")]
	public const short WyvernLegs = 88;

	[Cpp2IlInjected.Token(Token = "0x4005364")]
	public const short WyvernBody = 89;

	[Cpp2IlInjected.Token(Token = "0x4005365")]
	public const short WyvernBody2 = 90;

	[Cpp2IlInjected.Token(Token = "0x4005366")]
	public const short WyvernBody3 = 91;

	[Cpp2IlInjected.Token(Token = "0x4005367")]
	public const short WyvernTail = 92;

	[Cpp2IlInjected.Token(Token = "0x4005368")]
	public const short GiantBat = 93;

	[Cpp2IlInjected.Token(Token = "0x4005369")]
	public const short Corruptor = 94;

	[Cpp2IlInjected.Token(Token = "0x400536A")]
	public const short DiggerHead = 95;

	[Cpp2IlInjected.Token(Token = "0x400536B")]
	public const short DiggerBody = 96;

	[Cpp2IlInjected.Token(Token = "0x400536C")]
	public const short DiggerTail = 97;

	[Cpp2IlInjected.Token(Token = "0x400536D")]
	public const short SeekerHead = 98;

	[Cpp2IlInjected.Token(Token = "0x400536E")]
	public const short SeekerBody = 99;

	[Cpp2IlInjected.Token(Token = "0x400536F")]
	public const short SeekerTail = 100;

	[Cpp2IlInjected.Token(Token = "0x4005370")]
	public const short Clinger = 101;

	[Cpp2IlInjected.Token(Token = "0x4005371")]
	public const short AnglerFish = 102;

	[Cpp2IlInjected.Token(Token = "0x4005372")]
	public const short GreenJellyfish = 103;

	[Cpp2IlInjected.Token(Token = "0x4005373")]
	public const short Werewolf = 104;

	[Cpp2IlInjected.Token(Token = "0x4005374")]
	public const short BoundGoblin = 105;

	[Cpp2IlInjected.Token(Token = "0x4005375")]
	public const short BoundWizard = 106;

	[Cpp2IlInjected.Token(Token = "0x4005376")]
	public const short GoblinTinkerer = 107;

	[Cpp2IlInjected.Token(Token = "0x4005377")]
	public const short Wizard = 108;

	[Cpp2IlInjected.Token(Token = "0x4005378")]
	public const short Clown = 109;

	[Cpp2IlInjected.Token(Token = "0x4005379")]
	public const short SkeletonArcher = 110;

	[Cpp2IlInjected.Token(Token = "0x400537A")]
	public const short GoblinArcher = 111;

	[Cpp2IlInjected.Token(Token = "0x400537B")]
	public const short VileSpit = 112;

	[Cpp2IlInjected.Token(Token = "0x400537C")]
	public const short WallofFlesh = 113;

	[Cpp2IlInjected.Token(Token = "0x400537D")]
	public const short WallofFleshEye = 114;

	[Cpp2IlInjected.Token(Token = "0x400537E")]
	public const short TheHungry = 115;

	[Cpp2IlInjected.Token(Token = "0x400537F")]
	public const short TheHungryII = 116;

	[Cpp2IlInjected.Token(Token = "0x4005380")]
	public const short LeechHead = 117;

	[Cpp2IlInjected.Token(Token = "0x4005381")]
	public const short LeechBody = 118;

	[Cpp2IlInjected.Token(Token = "0x4005382")]
	public const short LeechTail = 119;

	[Cpp2IlInjected.Token(Token = "0x4005383")]
	public const short ChaosElemental = 120;

	[Cpp2IlInjected.Token(Token = "0x4005384")]
	public const short Slimer = 121;

	[Cpp2IlInjected.Token(Token = "0x4005385")]
	public const short Gastropod = 122;

	[Cpp2IlInjected.Token(Token = "0x4005386")]
	public const short BoundMechanic = 123;

	[Cpp2IlInjected.Token(Token = "0x4005387")]
	public const short Mechanic = 124;

	[Cpp2IlInjected.Token(Token = "0x4005388")]
	public const short Retinazer = 125;

	[Cpp2IlInjected.Token(Token = "0x4005389")]
	public const short Spazmatism = 126;

	[Cpp2IlInjected.Token(Token = "0x400538A")]
	public const short SkeletronPrime = 127;

	[Cpp2IlInjected.Token(Token = "0x400538B")]
	public const short PrimeCannon = 128;

	[Cpp2IlInjected.Token(Token = "0x400538C")]
	public const short PrimeSaw = 129;

	[Cpp2IlInjected.Token(Token = "0x400538D")]
	public const short PrimeVice = 130;

	[Cpp2IlInjected.Token(Token = "0x400538E")]
	public const short PrimeLaser = 131;

	[Cpp2IlInjected.Token(Token = "0x400538F")]
	public const short BaldZombie = 132;

	[Cpp2IlInjected.Token(Token = "0x4005390")]
	public const short WanderingEye = 133;

	[Cpp2IlInjected.Token(Token = "0x4005391")]
	public const short TheDestroyer = 134;

	[Cpp2IlInjected.Token(Token = "0x4005392")]
	public const short TheDestroyerBody = 135;

	[Cpp2IlInjected.Token(Token = "0x4005393")]
	public const short TheDestroyerTail = 136;

	[Cpp2IlInjected.Token(Token = "0x4005394")]
	public const short IlluminantBat = 137;

	[Cpp2IlInjected.Token(Token = "0x4005395")]
	public const short IlluminantSlime = 138;

	[Cpp2IlInjected.Token(Token = "0x4005396")]
	public const short Probe = 139;

	[Cpp2IlInjected.Token(Token = "0x4005397")]
	public const short PossessedArmor = 140;

	[Cpp2IlInjected.Token(Token = "0x4005398")]
	public const short ToxicSludge = 141;

	[Cpp2IlInjected.Token(Token = "0x4005399")]
	public const short SantaClaus = 142;

	[Cpp2IlInjected.Token(Token = "0x400539A")]
	public const short SnowmanGangsta = 143;

	[Cpp2IlInjected.Token(Token = "0x400539B")]
	public const short MisterStabby = 144;

	[Cpp2IlInjected.Token(Token = "0x400539C")]
	public const short SnowBalla = 145;

	[Cpp2IlInjected.Token(Token = "0x400539D")]
	public const short None3 = 146;

	[Cpp2IlInjected.Token(Token = "0x400539E")]
	public const short IceSlime = 147;

	[Cpp2IlInjected.Token(Token = "0x400539F")]
	public const short Penguin = 148;

	[Cpp2IlInjected.Token(Token = "0x40053A0")]
	public const short PenguinBlack = 149;

	[Cpp2IlInjected.Token(Token = "0x40053A1")]
	public const short IceBat = 150;

	[Cpp2IlInjected.Token(Token = "0x40053A2")]
	public const short Lavabat = 151;

	[Cpp2IlInjected.Token(Token = "0x40053A3")]
	public const short GiantFlyingFox = 152;

	[Cpp2IlInjected.Token(Token = "0x40053A4")]
	public const short GiantTortoise = 153;

	[Cpp2IlInjected.Token(Token = "0x40053A5")]
	public const short IceTortoise = 154;

	[Cpp2IlInjected.Token(Token = "0x40053A6")]
	public const short Wolf = 155;

	[Cpp2IlInjected.Token(Token = "0x40053A7")]
	public const short RedDevil = 156;

	[Cpp2IlInjected.Token(Token = "0x40053A8")]
	public const short Arapaima = 157;

	[Cpp2IlInjected.Token(Token = "0x40053A9")]
	public const short VampireBat = 158;

	[Cpp2IlInjected.Token(Token = "0x40053AA")]
	public const short Vampire = 159;

	[Cpp2IlInjected.Token(Token = "0x40053AB")]
	public const short Truffle = 160;

	[Cpp2IlInjected.Token(Token = "0x40053AC")]
	public const short ZombieEskimo = 161;

	[Cpp2IlInjected.Token(Token = "0x40053AD")]
	public const short Frankenstein = 162;

	[Cpp2IlInjected.Token(Token = "0x40053AE")]
	public const short BlackRecluse = 163;

	[Cpp2IlInjected.Token(Token = "0x40053AF")]
	public const short WallCreeper = 164;

	[Cpp2IlInjected.Token(Token = "0x40053B0")]
	public const short WallCreeperWall = 165;

	[Cpp2IlInjected.Token(Token = "0x40053B1")]
	public const short SwampThing = 166;

	[Cpp2IlInjected.Token(Token = "0x40053B2")]
	public const short UndeadViking = 167;

	[Cpp2IlInjected.Token(Token = "0x40053B3")]
	public const short CorruptPenguin = 168;

	[Cpp2IlInjected.Token(Token = "0x40053B4")]
	public const short IceElemental = 169;

	[Cpp2IlInjected.Token(Token = "0x40053B5")]
	public const short PigronCorruption = 170;

	[Cpp2IlInjected.Token(Token = "0x40053B6")]
	public const short PigronHallow = 171;

	[Cpp2IlInjected.Token(Token = "0x40053B7")]
	public const short RuneWizard = 172;

	[Cpp2IlInjected.Token(Token = "0x40053B8")]
	public const short Crimera = 173;

	[Cpp2IlInjected.Token(Token = "0x40053B9")]
	public const short Herpling = 174;

	[Cpp2IlInjected.Token(Token = "0x40053BA")]
	public const short AngryTrapper = 175;

	[Cpp2IlInjected.Token(Token = "0x40053BB")]
	public const short MossHornet = 176;

	[Cpp2IlInjected.Token(Token = "0x40053BC")]
	public const short Derpling = 177;

	[Cpp2IlInjected.Token(Token = "0x40053BD")]
	public const short Steampunker = 178;

	[Cpp2IlInjected.Token(Token = "0x40053BE")]
	public const short CrimsonAxe = 179;

	[Cpp2IlInjected.Token(Token = "0x40053BF")]
	public const short PigronCrimson = 180;

	[Cpp2IlInjected.Token(Token = "0x40053C0")]
	public const short FaceMonster = 181;

	[Cpp2IlInjected.Token(Token = "0x40053C1")]
	public const short FloatyGross = 182;

	[Cpp2IlInjected.Token(Token = "0x40053C2")]
	public const short Crimslime = 183;

	[Cpp2IlInjected.Token(Token = "0x40053C3")]
	public const short SpikedIceSlime = 184;

	[Cpp2IlInjected.Token(Token = "0x40053C4")]
	public const short SnowFlinx = 185;

	[Cpp2IlInjected.Token(Token = "0x40053C5")]
	public const short PincushionZombie = 186;

	[Cpp2IlInjected.Token(Token = "0x40053C6")]
	public const short SlimedZombie = 187;

	[Cpp2IlInjected.Token(Token = "0x40053C7")]
	public const short SwampZombie = 188;

	[Cpp2IlInjected.Token(Token = "0x40053C8")]
	public const short TwiggyZombie = 189;

	[Cpp2IlInjected.Token(Token = "0x40053C9")]
	public const short CataractEye = 190;

	[Cpp2IlInjected.Token(Token = "0x40053CA")]
	public const short SleepyEye = 191;

	[Cpp2IlInjected.Token(Token = "0x40053CB")]
	public const short DialatedEye = 192;

	[Cpp2IlInjected.Token(Token = "0x40053CC")]
	public const short GreenEye = 193;

	[Cpp2IlInjected.Token(Token = "0x40053CD")]
	public const short PurpleEye = 194;

	[Cpp2IlInjected.Token(Token = "0x40053CE")]
	public const short LostGirl = 195;

	[Cpp2IlInjected.Token(Token = "0x40053CF")]
	public const short Nymph = 196;

	[Cpp2IlInjected.Token(Token = "0x40053D0")]
	public const short ArmoredViking = 197;

	[Cpp2IlInjected.Token(Token = "0x40053D1")]
	public const short Lihzahrd = 198;

	[Cpp2IlInjected.Token(Token = "0x40053D2")]
	public const short LihzahrdCrawler = 199;

	[Cpp2IlInjected.Token(Token = "0x40053D3")]
	public const short FemaleZombie = 200;

	[Cpp2IlInjected.Token(Token = "0x40053D4")]
	public const short HeadacheSkeleton = 201;

	[Cpp2IlInjected.Token(Token = "0x40053D5")]
	public const short MisassembledSkeleton = 202;

	[Cpp2IlInjected.Token(Token = "0x40053D6")]
	public const short PantlessSkeleton = 203;

	[Cpp2IlInjected.Token(Token = "0x40053D7")]
	public const short SpikedJungleSlime = 204;

	[Cpp2IlInjected.Token(Token = "0x40053D8")]
	public const short Moth = 205;

	[Cpp2IlInjected.Token(Token = "0x40053D9")]
	public const short IcyMerman = 206;

	[Cpp2IlInjected.Token(Token = "0x40053DA")]
	public const short DyeTrader = 207;

	[Cpp2IlInjected.Token(Token = "0x40053DB")]
	public const short PartyGirl = 208;

	[Cpp2IlInjected.Token(Token = "0x40053DC")]
	public const short Cyborg = 209;

	[Cpp2IlInjected.Token(Token = "0x40053DD")]
	public const short Bee = 210;

	[Cpp2IlInjected.Token(Token = "0x40053DE")]
	public const short BeeSmall = 211;

	[Cpp2IlInjected.Token(Token = "0x40053DF")]
	public const short PirateDeckhand = 212;

	[Cpp2IlInjected.Token(Token = "0x40053E0")]
	public const short PirateCorsair = 213;

	[Cpp2IlInjected.Token(Token = "0x40053E1")]
	public const short PirateDeadeye = 214;

	[Cpp2IlInjected.Token(Token = "0x40053E2")]
	public const short PirateCrossbower = 215;

	[Cpp2IlInjected.Token(Token = "0x40053E3")]
	public const short PirateCaptain = 216;

	[Cpp2IlInjected.Token(Token = "0x40053E4")]
	public const short CochinealBeetle = 217;

	[Cpp2IlInjected.Token(Token = "0x40053E5")]
	public const short CyanBeetle = 218;

	[Cpp2IlInjected.Token(Token = "0x40053E6")]
	public const short LacBeetle = 219;

	[Cpp2IlInjected.Token(Token = "0x40053E7")]
	public const short SeaSnail = 220;

	[Cpp2IlInjected.Token(Token = "0x40053E8")]
	public const short Squid = 221;

	[Cpp2IlInjected.Token(Token = "0x40053E9")]
	public const short QueenBee = 222;

	[Cpp2IlInjected.Token(Token = "0x40053EA")]
	public const short ZombieRaincoat = 223;

	[Cpp2IlInjected.Token(Token = "0x40053EB")]
	public const short FlyingFish = 224;

	[Cpp2IlInjected.Token(Token = "0x40053EC")]
	public const short UmbrellaSlime = 225;

	[Cpp2IlInjected.Token(Token = "0x40053ED")]
	public const short FlyingSnake = 226;

	[Cpp2IlInjected.Token(Token = "0x40053EE")]
	public const short Painter = 227;

	[Cpp2IlInjected.Token(Token = "0x40053EF")]
	public const short WitchDoctor = 228;

	[Cpp2IlInjected.Token(Token = "0x40053F0")]
	public const short Pirate = 229;

	[Cpp2IlInjected.Token(Token = "0x40053F1")]
	public const short GoldfishWalker = 230;

	[Cpp2IlInjected.Token(Token = "0x40053F2")]
	public const short HornetFatty = 231;

	[Cpp2IlInjected.Token(Token = "0x40053F3")]
	public const short HornetHoney = 232;

	[Cpp2IlInjected.Token(Token = "0x40053F4")]
	public const short HornetLeafy = 233;

	[Cpp2IlInjected.Token(Token = "0x40053F5")]
	public const short HornetSpikey = 234;

	[Cpp2IlInjected.Token(Token = "0x40053F6")]
	public const short HornetStingy = 235;

	[Cpp2IlInjected.Token(Token = "0x40053F7")]
	public const short JungleCreeper = 236;

	[Cpp2IlInjected.Token(Token = "0x40053F8")]
	public const short JungleCreeperWall = 237;

	[Cpp2IlInjected.Token(Token = "0x40053F9")]
	public const short BlackRecluseWall = 238;

	[Cpp2IlInjected.Token(Token = "0x40053FA")]
	public const short BloodCrawler = 239;

	[Cpp2IlInjected.Token(Token = "0x40053FB")]
	public const short BloodCrawlerWall = 240;

	[Cpp2IlInjected.Token(Token = "0x40053FC")]
	public const short BloodFeeder = 241;

	[Cpp2IlInjected.Token(Token = "0x40053FD")]
	public const short BloodJelly = 242;

	[Cpp2IlInjected.Token(Token = "0x40053FE")]
	public const short IceGolem = 243;

	[Cpp2IlInjected.Token(Token = "0x40053FF")]
	public const short RainbowSlime = 244;

	[Cpp2IlInjected.Token(Token = "0x4005400")]
	public const short Golem = 245;

	[Cpp2IlInjected.Token(Token = "0x4005401")]
	public const short GolemHead = 246;

	[Cpp2IlInjected.Token(Token = "0x4005402")]
	public const short GolemFistLeft = 247;

	[Cpp2IlInjected.Token(Token = "0x4005403")]
	public const short GolemFistRight = 248;

	[Cpp2IlInjected.Token(Token = "0x4005404")]
	public const short GolemHeadFree = 249;

	[Cpp2IlInjected.Token(Token = "0x4005405")]
	public const short AngryNimbus = 250;

	[Cpp2IlInjected.Token(Token = "0x4005406")]
	public const short Eyezor = 251;

	[Cpp2IlInjected.Token(Token = "0x4005407")]
	public const short Parrot = 252;

	[Cpp2IlInjected.Token(Token = "0x4005408")]
	public const short Reaper = 253;

	[Cpp2IlInjected.Token(Token = "0x4005409")]
	public const short ZombieMushroom = 254;

	[Cpp2IlInjected.Token(Token = "0x400540A")]
	public const short ZombieMushroomHat = 255;

	[Cpp2IlInjected.Token(Token = "0x400540B")]
	public const short FungoFish = 256;

	[Cpp2IlInjected.Token(Token = "0x400540C")]
	public const short AnomuraFungus = 257;

	[Cpp2IlInjected.Token(Token = "0x400540D")]
	public const short MushiLadybug = 258;

	[Cpp2IlInjected.Token(Token = "0x400540E")]
	public const short FungiBulb = 259;

	[Cpp2IlInjected.Token(Token = "0x400540F")]
	public const short GiantFungiBulb = 260;

	[Cpp2IlInjected.Token(Token = "0x4005410")]
	public const short FungiSpore = 261;

	[Cpp2IlInjected.Token(Token = "0x4005411")]
	public const short Plantera = 262;

	[Cpp2IlInjected.Token(Token = "0x4005412")]
	public const short PlanterasHook = 263;

	[Cpp2IlInjected.Token(Token = "0x4005413")]
	public const short PlanterasTentacle = 264;

	[Cpp2IlInjected.Token(Token = "0x4005414")]
	public const short Spore = 265;

	[Cpp2IlInjected.Token(Token = "0x4005415")]
	public const short BrainofCthulhu = 266;

	[Cpp2IlInjected.Token(Token = "0x4005416")]
	public const short Creeper = 267;

	[Cpp2IlInjected.Token(Token = "0x4005417")]
	public const short IchorSticker = 268;

	[Cpp2IlInjected.Token(Token = "0x4005418")]
	public const short RustyArmoredBonesAxe = 269;

	[Cpp2IlInjected.Token(Token = "0x4005419")]
	public const short RustyArmoredBonesFlail = 270;

	[Cpp2IlInjected.Token(Token = "0x400541A")]
	public const short RustyArmoredBonesSword = 271;

	[Cpp2IlInjected.Token(Token = "0x400541B")]
	public const short RustyArmoredBonesSwordNoArmor = 272;

	[Cpp2IlInjected.Token(Token = "0x400541C")]
	public const short BlueArmoredBones = 273;

	[Cpp2IlInjected.Token(Token = "0x400541D")]
	public const short BlueArmoredBonesMace = 274;

	[Cpp2IlInjected.Token(Token = "0x400541E")]
	public const short BlueArmoredBonesNoPants = 275;

	[Cpp2IlInjected.Token(Token = "0x400541F")]
	public const short BlueArmoredBonesSword = 276;

	[Cpp2IlInjected.Token(Token = "0x4005420")]
	public const short HellArmoredBones = 277;

	[Cpp2IlInjected.Token(Token = "0x4005421")]
	public const short HellArmoredBonesSpikeShield = 278;

	[Cpp2IlInjected.Token(Token = "0x4005422")]
	public const short HellArmoredBonesMace = 279;

	[Cpp2IlInjected.Token(Token = "0x4005423")]
	public const short HellArmoredBonesSword = 280;

	[Cpp2IlInjected.Token(Token = "0x4005424")]
	public const short RaggedCaster = 281;

	[Cpp2IlInjected.Token(Token = "0x4005425")]
	public const short RaggedCasterOpenCoat = 282;

	[Cpp2IlInjected.Token(Token = "0x4005426")]
	public const short Necromancer = 283;

	[Cpp2IlInjected.Token(Token = "0x4005427")]
	public const short NecromancerArmored = 284;

	[Cpp2IlInjected.Token(Token = "0x4005428")]
	public const short DiabolistRed = 285;

	[Cpp2IlInjected.Token(Token = "0x4005429")]
	public const short DiabolistWhite = 286;

	[Cpp2IlInjected.Token(Token = "0x400542A")]
	public const short BoneLee = 287;

	[Cpp2IlInjected.Token(Token = "0x400542B")]
	public const short DungeonSpirit = 288;

	[Cpp2IlInjected.Token(Token = "0x400542C")]
	public const short GiantCursedSkull = 289;

	[Cpp2IlInjected.Token(Token = "0x400542D")]
	public const short Paladin = 290;

	[Cpp2IlInjected.Token(Token = "0x400542E")]
	public const short SkeletonSniper = 291;

	[Cpp2IlInjected.Token(Token = "0x400542F")]
	public const short TacticalSkeleton = 292;

	[Cpp2IlInjected.Token(Token = "0x4005430")]
	public const short SkeletonCommando = 293;

	[Cpp2IlInjected.Token(Token = "0x4005431")]
	public const short AngryBonesBig = 294;

	[Cpp2IlInjected.Token(Token = "0x4005432")]
	public const short AngryBonesBigMuscle = 295;

	[Cpp2IlInjected.Token(Token = "0x4005433")]
	public const short AngryBonesBigHelmet = 296;

	[Cpp2IlInjected.Token(Token = "0x4005434")]
	public const short BirdBlue = 297;

	[Cpp2IlInjected.Token(Token = "0x4005435")]
	public const short BirdRed = 298;

	[Cpp2IlInjected.Token(Token = "0x4005436")]
	public const short Squirrel = 299;

	[Cpp2IlInjected.Token(Token = "0x4005437")]
	public const short Mouse = 300;

	[Cpp2IlInjected.Token(Token = "0x4005438")]
	public const short Raven = 301;

	[Cpp2IlInjected.Token(Token = "0x4005439")]
	public const short SlimeMasked = 302;

	[Cpp2IlInjected.Token(Token = "0x400543A")]
	public const short BunnySlimed = 303;

	[Cpp2IlInjected.Token(Token = "0x400543B")]
	public const short HoppinJack = 304;

	[Cpp2IlInjected.Token(Token = "0x400543C")]
	public const short Scarecrow1 = 305;

	[Cpp2IlInjected.Token(Token = "0x400543D")]
	public const short Scarecrow2 = 306;

	[Cpp2IlInjected.Token(Token = "0x400543E")]
	public const short Scarecrow3 = 307;

	[Cpp2IlInjected.Token(Token = "0x400543F")]
	public const short Scarecrow4 = 308;

	[Cpp2IlInjected.Token(Token = "0x4005440")]
	public const short Scarecrow5 = 309;

	[Cpp2IlInjected.Token(Token = "0x4005441")]
	public const short Scarecrow6 = 310;

	[Cpp2IlInjected.Token(Token = "0x4005442")]
	public const short Scarecrow7 = 311;

	[Cpp2IlInjected.Token(Token = "0x4005443")]
	public const short Scarecrow8 = 312;

	[Cpp2IlInjected.Token(Token = "0x4005444")]
	public const short Scarecrow9 = 313;

	[Cpp2IlInjected.Token(Token = "0x4005445")]
	public const short Scarecrow10 = 314;

	[Cpp2IlInjected.Token(Token = "0x4005446")]
	public const short HeadlessHorseman = 315;

	[Cpp2IlInjected.Token(Token = "0x4005447")]
	public const short Ghost = 316;

	[Cpp2IlInjected.Token(Token = "0x4005448")]
	public const short DemonEyeOwl = 317;

	[Cpp2IlInjected.Token(Token = "0x4005449")]
	public const short DemonEyeSpaceship = 318;

	[Cpp2IlInjected.Token(Token = "0x400544A")]
	public const short ZombieDoctor = 319;

	[Cpp2IlInjected.Token(Token = "0x400544B")]
	public const short ZombieSuperman = 320;

	[Cpp2IlInjected.Token(Token = "0x400544C")]
	public const short ZombiePixie = 321;

	[Cpp2IlInjected.Token(Token = "0x400544D")]
	public const short SkeletonTopHat = 322;

	[Cpp2IlInjected.Token(Token = "0x400544E")]
	public const short SkeletonAstonaut = 323;

	[Cpp2IlInjected.Token(Token = "0x400544F")]
	public const short SkeletonAlien = 324;

	[Cpp2IlInjected.Token(Token = "0x4005450")]
	public const short MourningWood = 325;

	[Cpp2IlInjected.Token(Token = "0x4005451")]
	public const short Splinterling = 326;

	[Cpp2IlInjected.Token(Token = "0x4005452")]
	public const short Pumpking = 327;

	[Cpp2IlInjected.Token(Token = "0x4005453")]
	public const short PumpkingBlade = 328;

	[Cpp2IlInjected.Token(Token = "0x4005454")]
	public const short Hellhound = 329;

	[Cpp2IlInjected.Token(Token = "0x4005455")]
	public const short Poltergeist = 330;

	[Cpp2IlInjected.Token(Token = "0x4005456")]
	public const short ZombieXmas = 331;

	[Cpp2IlInjected.Token(Token = "0x4005457")]
	public const short ZombieSweater = 332;

	[Cpp2IlInjected.Token(Token = "0x4005458")]
	public const short SlimeRibbonWhite = 333;

	[Cpp2IlInjected.Token(Token = "0x4005459")]
	public const short SlimeRibbonYellow = 334;

	[Cpp2IlInjected.Token(Token = "0x400545A")]
	public const short SlimeRibbonGreen = 335;

	[Cpp2IlInjected.Token(Token = "0x400545B")]
	public const short SlimeRibbonRed = 336;

	[Cpp2IlInjected.Token(Token = "0x400545C")]
	public const short BunnyXmas = 337;

	[Cpp2IlInjected.Token(Token = "0x400545D")]
	public const short ZombieElf = 338;

	[Cpp2IlInjected.Token(Token = "0x400545E")]
	public const short ZombieElfBeard = 339;

	[Cpp2IlInjected.Token(Token = "0x400545F")]
	public const short ZombieElfGirl = 340;

	[Cpp2IlInjected.Token(Token = "0x4005460")]
	public const short PresentMimic = 341;

	[Cpp2IlInjected.Token(Token = "0x4005461")]
	public const short GingerbreadMan = 342;

	[Cpp2IlInjected.Token(Token = "0x4005462")]
	public const short Yeti = 343;

	[Cpp2IlInjected.Token(Token = "0x4005463")]
	public const short Everscream = 344;

	[Cpp2IlInjected.Token(Token = "0x4005464")]
	public const short IceQueen = 345;

	[Cpp2IlInjected.Token(Token = "0x4005465")]
	public const short SantaNK1 = 346;

	[Cpp2IlInjected.Token(Token = "0x4005466")]
	public const short ElfCopter = 347;

	[Cpp2IlInjected.Token(Token = "0x4005467")]
	public const short Nutcracker = 348;

	[Cpp2IlInjected.Token(Token = "0x4005468")]
	public const short NutcrackerSpinning = 349;

	[Cpp2IlInjected.Token(Token = "0x4005469")]
	public const short ElfArcher = 350;

	[Cpp2IlInjected.Token(Token = "0x400546A")]
	public const short Krampus = 351;

	[Cpp2IlInjected.Token(Token = "0x400546B")]
	public const short Flocko = 352;

	[Cpp2IlInjected.Token(Token = "0x400546C")]
	public const short Stylist = 353;

	[Cpp2IlInjected.Token(Token = "0x400546D")]
	public const short WebbedStylist = 354;

	[Cpp2IlInjected.Token(Token = "0x400546E")]
	public const short Firefly = 355;

	[Cpp2IlInjected.Token(Token = "0x400546F")]
	public const short Butterfly = 356;

	[Cpp2IlInjected.Token(Token = "0x4005470")]
	public const short Worm = 357;

	[Cpp2IlInjected.Token(Token = "0x4005471")]
	public const short LightningBug = 358;

	[Cpp2IlInjected.Token(Token = "0x4005472")]
	public const short Snail = 359;

	[Cpp2IlInjected.Token(Token = "0x4005473")]
	public const short GlowingSnail = 360;

	[Cpp2IlInjected.Token(Token = "0x4005474")]
	public const short Frog = 361;

	[Cpp2IlInjected.Token(Token = "0x4005475")]
	public const short Duck = 362;

	[Cpp2IlInjected.Token(Token = "0x4005476")]
	public const short Duck2 = 363;

	[Cpp2IlInjected.Token(Token = "0x4005477")]
	public const short DuckWhite = 364;

	[Cpp2IlInjected.Token(Token = "0x4005478")]
	public const short DuckWhite2 = 365;

	[Cpp2IlInjected.Token(Token = "0x4005479")]
	public const short ScorpionBlack = 366;

	[Cpp2IlInjected.Token(Token = "0x400547A")]
	public const short Scorpion = 367;

	[Cpp2IlInjected.Token(Token = "0x400547B")]
	public const short TravellingMerchant = 368;

	[Cpp2IlInjected.Token(Token = "0x400547C")]
	public const short Angler = 369;

	[Cpp2IlInjected.Token(Token = "0x400547D")]
	public const short DukeFishron = 370;

	[Cpp2IlInjected.Token(Token = "0x400547E")]
	public const short DetonatingBubble = 371;

	[Cpp2IlInjected.Token(Token = "0x400547F")]
	public const short Sharkron = 372;

	[Cpp2IlInjected.Token(Token = "0x4005480")]
	public const short Sharkron2 = 373;

	[Cpp2IlInjected.Token(Token = "0x4005481")]
	public const short TruffleWorm = 374;

	[Cpp2IlInjected.Token(Token = "0x4005482")]
	public const short TruffleWormDigger = 375;

	[Cpp2IlInjected.Token(Token = "0x4005483")]
	public const short SleepingAngler = 376;

	[Cpp2IlInjected.Token(Token = "0x4005484")]
	public const short Grasshopper = 377;

	[Cpp2IlInjected.Token(Token = "0x4005485")]
	public const short ChatteringTeethBomb = 378;

	[Cpp2IlInjected.Token(Token = "0x4005486")]
	public const short CultistArcherBlue = 379;

	[Cpp2IlInjected.Token(Token = "0x4005487")]
	public const short CultistArcherWhite = 380;

	[Cpp2IlInjected.Token(Token = "0x4005488")]
	public const short BrainScrambler = 381;

	[Cpp2IlInjected.Token(Token = "0x4005489")]
	public const short RayGunner = 382;

	[Cpp2IlInjected.Token(Token = "0x400548A")]
	public const short MartianOfficer = 383;

	[Cpp2IlInjected.Token(Token = "0x400548B")]
	public const short ForceBubble = 384;

	[Cpp2IlInjected.Token(Token = "0x400548C")]
	public const short GrayGrunt = 385;

	[Cpp2IlInjected.Token(Token = "0x400548D")]
	public const short MartianEngineer = 386;

	[Cpp2IlInjected.Token(Token = "0x400548E")]
	public const short MartianTurret = 387;

	[Cpp2IlInjected.Token(Token = "0x400548F")]
	public const short MartianDrone = 388;

	[Cpp2IlInjected.Token(Token = "0x4005490")]
	public const short GigaZapper = 389;

	[Cpp2IlInjected.Token(Token = "0x4005491")]
	public const short ScutlixRider = 390;

	[Cpp2IlInjected.Token(Token = "0x4005492")]
	public const short Scutlix = 391;

	[Cpp2IlInjected.Token(Token = "0x4005493")]
	public const short MartianSaucer = 392;

	[Cpp2IlInjected.Token(Token = "0x4005494")]
	public const short MartianSaucerTurret = 393;

	[Cpp2IlInjected.Token(Token = "0x4005495")]
	public const short MartianSaucerCannon = 394;

	[Cpp2IlInjected.Token(Token = "0x4005496")]
	public const short MartianSaucerCore = 395;

	[Cpp2IlInjected.Token(Token = "0x4005497")]
	public const short MoonLordHead = 396;

	[Cpp2IlInjected.Token(Token = "0x4005498")]
	public const short MoonLordHand = 397;

	[Cpp2IlInjected.Token(Token = "0x4005499")]
	public const short MoonLordCore = 398;

	[Cpp2IlInjected.Token(Token = "0x400549A")]
	public const short MartianProbe = 399;

	[Cpp2IlInjected.Token(Token = "0x400549B")]
	public const short MoonLordFreeEye = 400;

	[Cpp2IlInjected.Token(Token = "0x400549C")]
	public const short MoonLordLeechBlob = 401;

	[Cpp2IlInjected.Token(Token = "0x400549D")]
	public const short StardustWormHead = 402;

	[Cpp2IlInjected.Token(Token = "0x400549E")]
	public const short StardustWormBody = 403;

	[Cpp2IlInjected.Token(Token = "0x400549F")]
	public const short StardustWormTail = 404;

	[Cpp2IlInjected.Token(Token = "0x40054A0")]
	public const short StardustCellBig = 405;

	[Cpp2IlInjected.Token(Token = "0x40054A1")]
	public const short StardustCellSmall = 406;

	[Cpp2IlInjected.Token(Token = "0x40054A2")]
	public const short StardustJellyfishBig = 407;

	[Cpp2IlInjected.Token(Token = "0x40054A3")]
	public const short StardustJellyfishSmall = 408;

	[Cpp2IlInjected.Token(Token = "0x40054A4")]
	public const short StardustSpiderBig = 409;

	[Cpp2IlInjected.Token(Token = "0x40054A5")]
	public const short StardustSpiderSmall = 410;

	[Cpp2IlInjected.Token(Token = "0x40054A6")]
	public const short StardustSoldier = 411;

	[Cpp2IlInjected.Token(Token = "0x40054A7")]
	public const short SolarCrawltipedeHead = 412;

	[Cpp2IlInjected.Token(Token = "0x40054A8")]
	public const short SolarCrawltipedeBody = 413;

	[Cpp2IlInjected.Token(Token = "0x40054A9")]
	public const short SolarCrawltipedeTail = 414;

	[Cpp2IlInjected.Token(Token = "0x40054AA")]
	public const short SolarDrakomire = 415;

	[Cpp2IlInjected.Token(Token = "0x40054AB")]
	public const short SolarDrakomireRider = 416;

	[Cpp2IlInjected.Token(Token = "0x40054AC")]
	public const short SolarSroller = 417;

	[Cpp2IlInjected.Token(Token = "0x40054AD")]
	public const short SolarCorite = 418;

	[Cpp2IlInjected.Token(Token = "0x40054AE")]
	public const short SolarSolenian = 419;

	[Cpp2IlInjected.Token(Token = "0x40054AF")]
	public const short NebulaBrain = 420;

	[Cpp2IlInjected.Token(Token = "0x40054B0")]
	public const short NebulaHeadcrab = 421;

	[Cpp2IlInjected.Token(Token = "0x40054B1")]
	public const short NebulaBeast = 423;

	[Cpp2IlInjected.Token(Token = "0x40054B2")]
	public const short NebulaSoldier = 424;

	[Cpp2IlInjected.Token(Token = "0x40054B3")]
	public const short VortexRifleman = 425;

	[Cpp2IlInjected.Token(Token = "0x40054B4")]
	public const short VortexHornetQueen = 426;

	[Cpp2IlInjected.Token(Token = "0x40054B5")]
	public const short VortexHornet = 427;

	[Cpp2IlInjected.Token(Token = "0x40054B6")]
	public const short VortexLarva = 428;

	[Cpp2IlInjected.Token(Token = "0x40054B7")]
	public const short VortexSoldier = 429;

	[Cpp2IlInjected.Token(Token = "0x40054B8")]
	public const short ArmedZombie = 430;

	[Cpp2IlInjected.Token(Token = "0x40054B9")]
	public const short ArmedZombieEskimo = 431;

	[Cpp2IlInjected.Token(Token = "0x40054BA")]
	public const short ArmedZombiePincussion = 432;

	[Cpp2IlInjected.Token(Token = "0x40054BB")]
	public const short ArmedZombieSlimed = 433;

	[Cpp2IlInjected.Token(Token = "0x40054BC")]
	public const short ArmedZombieSwamp = 434;

	[Cpp2IlInjected.Token(Token = "0x40054BD")]
	public const short ArmedZombieTwiggy = 435;

	[Cpp2IlInjected.Token(Token = "0x40054BE")]
	public const short ArmedZombieCenx = 436;

	[Cpp2IlInjected.Token(Token = "0x40054BF")]
	public const short CultistTablet = 437;

	[Cpp2IlInjected.Token(Token = "0x40054C0")]
	public const short CultistDevote = 438;

	[Cpp2IlInjected.Token(Token = "0x40054C1")]
	public const short CultistBoss = 439;

	[Cpp2IlInjected.Token(Token = "0x40054C2")]
	public const short CultistBossClone = 440;

	[Cpp2IlInjected.Token(Token = "0x40054C3")]
	public const short GoldBird = 442;

	[Cpp2IlInjected.Token(Token = "0x40054C4")]
	public const short GoldBunny = 443;

	[Cpp2IlInjected.Token(Token = "0x40054C5")]
	public const short GoldButterfly = 444;

	[Cpp2IlInjected.Token(Token = "0x40054C6")]
	public const short GoldFrog = 445;

	[Cpp2IlInjected.Token(Token = "0x40054C7")]
	public const short GoldGrasshopper = 446;

	[Cpp2IlInjected.Token(Token = "0x40054C8")]
	public const short GoldMouse = 447;

	[Cpp2IlInjected.Token(Token = "0x40054C9")]
	public const short GoldWorm = 448;

	[Cpp2IlInjected.Token(Token = "0x40054CA")]
	public const short BoneThrowingSkeleton = 449;

	[Cpp2IlInjected.Token(Token = "0x40054CB")]
	public const short BoneThrowingSkeleton2 = 450;

	[Cpp2IlInjected.Token(Token = "0x40054CC")]
	public const short BoneThrowingSkeleton3 = 451;

	[Cpp2IlInjected.Token(Token = "0x40054CD")]
	public const short BoneThrowingSkeleton4 = 452;

	[Cpp2IlInjected.Token(Token = "0x40054CE")]
	public const short SkeletonMerchant = 453;

	[Cpp2IlInjected.Token(Token = "0x40054CF")]
	public const short CultistDragonHead = 454;

	[Cpp2IlInjected.Token(Token = "0x40054D0")]
	public const short CultistDragonBody1 = 455;

	[Cpp2IlInjected.Token(Token = "0x40054D1")]
	public const short CultistDragonBody2 = 456;

	[Cpp2IlInjected.Token(Token = "0x40054D2")]
	public const short CultistDragonBody3 = 457;

	[Cpp2IlInjected.Token(Token = "0x40054D3")]
	public const short CultistDragonBody4 = 458;

	[Cpp2IlInjected.Token(Token = "0x40054D4")]
	public const short CultistDragonTail = 459;

	[Cpp2IlInjected.Token(Token = "0x40054D5")]
	public const short Butcher = 460;

	[Cpp2IlInjected.Token(Token = "0x40054D6")]
	public const short CreatureFromTheDeep = 461;

	[Cpp2IlInjected.Token(Token = "0x40054D7")]
	public const short Fritz = 462;

	[Cpp2IlInjected.Token(Token = "0x40054D8")]
	public const short Nailhead = 463;

	[Cpp2IlInjected.Token(Token = "0x40054D9")]
	public const short CrimsonBunny = 464;

	[Cpp2IlInjected.Token(Token = "0x40054DA")]
	public const short CrimsonGoldfish = 465;

	[Cpp2IlInjected.Token(Token = "0x40054DB")]
	public const short Psycho = 466;

	[Cpp2IlInjected.Token(Token = "0x40054DC")]
	public const short DeadlySphere = 467;

	[Cpp2IlInjected.Token(Token = "0x40054DD")]
	public const short DrManFly = 468;

	[Cpp2IlInjected.Token(Token = "0x40054DE")]
	public const short ThePossessed = 469;

	[Cpp2IlInjected.Token(Token = "0x40054DF")]
	public const short CrimsonPenguin = 470;

	[Cpp2IlInjected.Token(Token = "0x40054E0")]
	public const short GoblinSummoner = 471;

	[Cpp2IlInjected.Token(Token = "0x40054E1")]
	public const short ShadowFlameApparition = 472;

	[Cpp2IlInjected.Token(Token = "0x40054E2")]
	public const short BigMimicCorruption = 473;

	[Cpp2IlInjected.Token(Token = "0x40054E3")]
	public const short BigMimicCrimson = 474;

	[Cpp2IlInjected.Token(Token = "0x40054E4")]
	public const short BigMimicHallow = 475;

	[Cpp2IlInjected.Token(Token = "0x40054E5")]
	public const short BigMimicJungle = 476;

	[Cpp2IlInjected.Token(Token = "0x40054E6")]
	public const short Mothron = 477;

	[Cpp2IlInjected.Token(Token = "0x40054E7")]
	public const short MothronEgg = 478;

	[Cpp2IlInjected.Token(Token = "0x40054E8")]
	public const short MothronSpawn = 479;

	[Cpp2IlInjected.Token(Token = "0x40054E9")]
	public const short Medusa = 480;

	[Cpp2IlInjected.Token(Token = "0x40054EA")]
	public const short GreekSkeleton = 481;

	[Cpp2IlInjected.Token(Token = "0x40054EB")]
	public const short GraniteGolem = 482;

	[Cpp2IlInjected.Token(Token = "0x40054EC")]
	public const short GraniteFlyer = 483;

	[Cpp2IlInjected.Token(Token = "0x40054ED")]
	public const short EnchantedNightcrawler = 484;

	[Cpp2IlInjected.Token(Token = "0x40054EE")]
	public const short Grubby = 485;

	[Cpp2IlInjected.Token(Token = "0x40054EF")]
	public const short Sluggy = 486;

	[Cpp2IlInjected.Token(Token = "0x40054F0")]
	public const short Buggy = 487;

	[Cpp2IlInjected.Token(Token = "0x40054F1")]
	public const short TargetDummy = 488;

	[Cpp2IlInjected.Token(Token = "0x40054F2")]
	public const short BloodZombie = 489;

	[Cpp2IlInjected.Token(Token = "0x40054F3")]
	public const short Drippler = 490;

	[Cpp2IlInjected.Token(Token = "0x40054F4")]
	public const short PirateShip = 491;

	[Cpp2IlInjected.Token(Token = "0x40054F5")]
	public const short PirateShipCannon = 492;

	[Cpp2IlInjected.Token(Token = "0x40054F6")]
	public const short LunarTowerStardust = 493;

	[Cpp2IlInjected.Token(Token = "0x40054F7")]
	public const short Crawdad = 494;

	[Cpp2IlInjected.Token(Token = "0x40054F8")]
	public const short Crawdad2 = 495;

	[Cpp2IlInjected.Token(Token = "0x40054F9")]
	public const short GiantShelly = 496;

	[Cpp2IlInjected.Token(Token = "0x40054FA")]
	public const short GiantShelly2 = 497;

	[Cpp2IlInjected.Token(Token = "0x40054FB")]
	public const short Salamander = 498;

	[Cpp2IlInjected.Token(Token = "0x40054FC")]
	public const short Salamander2 = 499;

	[Cpp2IlInjected.Token(Token = "0x40054FD")]
	public const short Salamander3 = 500;

	[Cpp2IlInjected.Token(Token = "0x40054FE")]
	public const short Salamander4 = 501;

	[Cpp2IlInjected.Token(Token = "0x40054FF")]
	public const short Salamander5 = 502;

	[Cpp2IlInjected.Token(Token = "0x4005500")]
	public const short Salamander6 = 503;

	[Cpp2IlInjected.Token(Token = "0x4005501")]
	public const short Salamander7 = 504;

	[Cpp2IlInjected.Token(Token = "0x4005502")]
	public const short Salamander8 = 505;

	[Cpp2IlInjected.Token(Token = "0x4005503")]
	public const short Salamander9 = 506;

	[Cpp2IlInjected.Token(Token = "0x4005504")]
	public const short LunarTowerNebula = 507;

	[Cpp2IlInjected.Token(Token = "0x4005505")]
	public const short LunarTowerVortex = 422;

	[Cpp2IlInjected.Token(Token = "0x4005506")]
	public const short TaxCollector = 441;

	[Cpp2IlInjected.Token(Token = "0x4005507")]
	public const short GiantWalkingAntlion = 508;

	[Cpp2IlInjected.Token(Token = "0x4005508")]
	public const short GiantFlyingAntlion = 509;

	[Cpp2IlInjected.Token(Token = "0x4005509")]
	public const short DuneSplicerHead = 510;

	[Cpp2IlInjected.Token(Token = "0x400550A")]
	public const short DuneSplicerBody = 511;

	[Cpp2IlInjected.Token(Token = "0x400550B")]
	public const short DuneSplicerTail = 512;

	[Cpp2IlInjected.Token(Token = "0x400550C")]
	public const short TombCrawlerHead = 513;

	[Cpp2IlInjected.Token(Token = "0x400550D")]
	public const short TombCrawlerBody = 514;

	[Cpp2IlInjected.Token(Token = "0x400550E")]
	public const short TombCrawlerTail = 515;

	[Cpp2IlInjected.Token(Token = "0x400550F")]
	public const short SolarFlare = 516;

	[Cpp2IlInjected.Token(Token = "0x4005510")]
	public const short LunarTowerSolar = 517;

	[Cpp2IlInjected.Token(Token = "0x4005511")]
	public const short SolarSpearman = 518;

	[Cpp2IlInjected.Token(Token = "0x4005512")]
	public const short SolarGoop = 519;

	[Cpp2IlInjected.Token(Token = "0x4005513")]
	public const short MartianWalker = 520;

	[Cpp2IlInjected.Token(Token = "0x4005514")]
	public const short AncientCultistSquidhead = 521;

	[Cpp2IlInjected.Token(Token = "0x4005515")]
	public const short AncientLight = 522;

	[Cpp2IlInjected.Token(Token = "0x4005516")]
	public const short AncientDoom = 523;

	[Cpp2IlInjected.Token(Token = "0x4005517")]
	public const short DesertGhoul = 524;

	[Cpp2IlInjected.Token(Token = "0x4005518")]
	public const short DesertGhoulCorruption = 525;

	[Cpp2IlInjected.Token(Token = "0x4005519")]
	public const short DesertGhoulCrimson = 526;

	[Cpp2IlInjected.Token(Token = "0x400551A")]
	public const short DesertGhoulHallow = 527;

	[Cpp2IlInjected.Token(Token = "0x400551B")]
	public const short DesertLamiaLight = 528;

	[Cpp2IlInjected.Token(Token = "0x400551C")]
	public const short DesertLamiaDark = 529;

	[Cpp2IlInjected.Token(Token = "0x400551D")]
	public const short DesertScorpionWalk = 530;

	[Cpp2IlInjected.Token(Token = "0x400551E")]
	public const short DesertScorpionWall = 531;

	[Cpp2IlInjected.Token(Token = "0x400551F")]
	public const short DesertBeast = 532;

	[Cpp2IlInjected.Token(Token = "0x4005520")]
	public const short DesertDjinn = 533;

	[Cpp2IlInjected.Token(Token = "0x4005521")]
	public const short DemonTaxCollector = 534;

	[Cpp2IlInjected.Token(Token = "0x4005522")]
	public const short SlimeSpiked = 535;

	[Cpp2IlInjected.Token(Token = "0x4005523")]
	public const short TheBride = 536;

	[Cpp2IlInjected.Token(Token = "0x4005524")]
	public const short SandSlime = 537;

	[Cpp2IlInjected.Token(Token = "0x4005525")]
	public const short SquirrelRed = 538;

	[Cpp2IlInjected.Token(Token = "0x4005526")]
	public const short SquirrelGold = 539;

	[Cpp2IlInjected.Token(Token = "0x4005527")]
	public const short PartyBunny = 540;

	[Cpp2IlInjected.Token(Token = "0x4005528")]
	public const short SandElemental = 541;

	[Cpp2IlInjected.Token(Token = "0x4005529")]
	public const short SandShark = 542;

	[Cpp2IlInjected.Token(Token = "0x400552A")]
	public const short SandsharkCorrupt = 543;

	[Cpp2IlInjected.Token(Token = "0x400552B")]
	public const short SandsharkCrimson = 544;

	[Cpp2IlInjected.Token(Token = "0x400552C")]
	public const short SandsharkHallow = 545;

	[Cpp2IlInjected.Token(Token = "0x400552D")]
	public const short Tumbleweed = 546;

	[Cpp2IlInjected.Token(Token = "0x400552E")]
	public const short DD2AttackerTest = 547;

	[Cpp2IlInjected.Token(Token = "0x400552F")]
	public const short DD2EterniaCrystal = 548;

	[Cpp2IlInjected.Token(Token = "0x4005530")]
	public const short DD2LanePortal = 549;

	[Cpp2IlInjected.Token(Token = "0x4005531")]
	public const short DD2Bartender = 550;

	[Cpp2IlInjected.Token(Token = "0x4005532")]
	public const short DD2Betsy = 551;

	[Cpp2IlInjected.Token(Token = "0x4005533")]
	public const short DD2GoblinT1 = 552;

	[Cpp2IlInjected.Token(Token = "0x4005534")]
	public const short DD2GoblinT2 = 553;

	[Cpp2IlInjected.Token(Token = "0x4005535")]
	public const short DD2GoblinT3 = 554;

	[Cpp2IlInjected.Token(Token = "0x4005536")]
	public const short DD2GoblinBomberT1 = 555;

	[Cpp2IlInjected.Token(Token = "0x4005537")]
	public const short DD2GoblinBomberT2 = 556;

	[Cpp2IlInjected.Token(Token = "0x4005538")]
	public const short DD2GoblinBomberT3 = 557;

	[Cpp2IlInjected.Token(Token = "0x4005539")]
	public const short DD2WyvernT1 = 558;

	[Cpp2IlInjected.Token(Token = "0x400553A")]
	public const short DD2WyvernT2 = 559;

	[Cpp2IlInjected.Token(Token = "0x400553B")]
	public const short DD2WyvernT3 = 560;

	[Cpp2IlInjected.Token(Token = "0x400553C")]
	public const short DD2JavelinstT1 = 561;

	[Cpp2IlInjected.Token(Token = "0x400553D")]
	public const short DD2JavelinstT2 = 562;

	[Cpp2IlInjected.Token(Token = "0x400553E")]
	public const short DD2JavelinstT3 = 563;

	[Cpp2IlInjected.Token(Token = "0x400553F")]
	public const short DD2DarkMageT1 = 564;

	[Cpp2IlInjected.Token(Token = "0x4005540")]
	public const short DD2DarkMageT3 = 565;

	[Cpp2IlInjected.Token(Token = "0x4005541")]
	public const short DD2SkeletonT1 = 566;

	[Cpp2IlInjected.Token(Token = "0x4005542")]
	public const short DD2SkeletonT3 = 567;

	[Cpp2IlInjected.Token(Token = "0x4005543")]
	public const short DD2WitherBeastT2 = 568;

	[Cpp2IlInjected.Token(Token = "0x4005544")]
	public const short DD2WitherBeastT3 = 569;

	[Cpp2IlInjected.Token(Token = "0x4005545")]
	public const short DD2DrakinT2 = 570;

	[Cpp2IlInjected.Token(Token = "0x4005546")]
	public const short DD2DrakinT3 = 571;

	[Cpp2IlInjected.Token(Token = "0x4005547")]
	public const short DD2KoboldWalkerT2 = 572;

	[Cpp2IlInjected.Token(Token = "0x4005548")]
	public const short DD2KoboldWalkerT3 = 573;

	[Cpp2IlInjected.Token(Token = "0x4005549")]
	public const short DD2KoboldFlyerT2 = 574;

	[Cpp2IlInjected.Token(Token = "0x400554A")]
	public const short DD2KoboldFlyerT3 = 575;

	[Cpp2IlInjected.Token(Token = "0x400554B")]
	public const short DD2OgreT2 = 576;

	[Cpp2IlInjected.Token(Token = "0x400554C")]
	public const short DD2OgreT3 = 577;

	[Cpp2IlInjected.Token(Token = "0x400554D")]
	public const short DD2LightningBugT3 = 578;

	[Cpp2IlInjected.Token(Token = "0x400554E")]
	public const short BartenderUnconscious = 579;

	[Cpp2IlInjected.Token(Token = "0x400554F")]
	public const short WalkingAntlion = 580;

	[Cpp2IlInjected.Token(Token = "0x4005550")]
	public const short FlyingAntlion = 581;

	[Cpp2IlInjected.Token(Token = "0x4005551")]
	public const short LarvaeAntlion = 582;

	[Cpp2IlInjected.Token(Token = "0x4005552")]
	public const short FairyCritterPink = 583;

	[Cpp2IlInjected.Token(Token = "0x4005553")]
	public const short FairyCritterGreen = 584;

	[Cpp2IlInjected.Token(Token = "0x4005554")]
	public const short FairyCritterBlue = 585;

	[Cpp2IlInjected.Token(Token = "0x4005555")]
	public const short ZombieMerman = 586;

	[Cpp2IlInjected.Token(Token = "0x4005556")]
	public const short EyeballFlyingFish = 587;

	[Cpp2IlInjected.Token(Token = "0x4005557")]
	public const short Golfer = 588;

	[Cpp2IlInjected.Token(Token = "0x4005558")]
	public const short GolferRescue = 589;

	[Cpp2IlInjected.Token(Token = "0x4005559")]
	public const short TorchZombie = 590;

	[Cpp2IlInjected.Token(Token = "0x400555A")]
	public const short ArmedTorchZombie = 591;

	[Cpp2IlInjected.Token(Token = "0x400555B")]
	public const short GoldGoldfish = 592;

	[Cpp2IlInjected.Token(Token = "0x400555C")]
	public const short GoldGoldfishWalker = 593;

	[Cpp2IlInjected.Token(Token = "0x400555D")]
	public const short WindyBalloon = 594;

	[Cpp2IlInjected.Token(Token = "0x400555E")]
	public const short BlackDragonfly = 595;

	[Cpp2IlInjected.Token(Token = "0x400555F")]
	public const short BlueDragonfly = 596;

	[Cpp2IlInjected.Token(Token = "0x4005560")]
	public const short GreenDragonfly = 597;

	[Cpp2IlInjected.Token(Token = "0x4005561")]
	public const short OrangeDragonfly = 598;

	[Cpp2IlInjected.Token(Token = "0x4005562")]
	public const short RedDragonfly = 599;

	[Cpp2IlInjected.Token(Token = "0x4005563")]
	public const short YellowDragonfly = 600;

	[Cpp2IlInjected.Token(Token = "0x4005564")]
	public const short GoldDragonfly = 601;

	[Cpp2IlInjected.Token(Token = "0x4005565")]
	public const short Seagull = 602;

	[Cpp2IlInjected.Token(Token = "0x4005566")]
	public const short Seagull2 = 603;

	[Cpp2IlInjected.Token(Token = "0x4005567")]
	public const short LadyBug = 604;

	[Cpp2IlInjected.Token(Token = "0x4005568")]
	public const short GoldLadyBug = 605;

	[Cpp2IlInjected.Token(Token = "0x4005569")]
	public const short Maggot = 606;

	[Cpp2IlInjected.Token(Token = "0x400556A")]
	public const short Pupfish = 607;

	[Cpp2IlInjected.Token(Token = "0x400556B")]
	public const short Grebe = 608;

	[Cpp2IlInjected.Token(Token = "0x400556C")]
	public const short Grebe2 = 609;

	[Cpp2IlInjected.Token(Token = "0x400556D")]
	public const short Rat = 610;

	[Cpp2IlInjected.Token(Token = "0x400556E")]
	public const short Owl = 611;

	[Cpp2IlInjected.Token(Token = "0x400556F")]
	public const short WaterStrider = 612;

	[Cpp2IlInjected.Token(Token = "0x4005570")]
	public const short GoldWaterStrider = 613;

	[Cpp2IlInjected.Token(Token = "0x4005571")]
	public const short ExplosiveBunny = 614;

	[Cpp2IlInjected.Token(Token = "0x4005572")]
	public const short Dolphin = 615;

	[Cpp2IlInjected.Token(Token = "0x4005573")]
	public const short Turtle = 616;

	[Cpp2IlInjected.Token(Token = "0x4005574")]
	public const short TurtleJungle = 617;

	[Cpp2IlInjected.Token(Token = "0x4005575")]
	public const short BloodNautilus = 618;

	[Cpp2IlInjected.Token(Token = "0x4005576")]
	public const short BloodSquid = 619;

	[Cpp2IlInjected.Token(Token = "0x4005577")]
	public const short GoblinShark = 620;

	[Cpp2IlInjected.Token(Token = "0x4005578")]
	public const short BloodEelHead = 621;

	[Cpp2IlInjected.Token(Token = "0x4005579")]
	public const short BloodEelBody = 622;

	[Cpp2IlInjected.Token(Token = "0x400557A")]
	public const short BloodEelTail = 623;

	[Cpp2IlInjected.Token(Token = "0x400557B")]
	public const short Gnome = 624;

	[Cpp2IlInjected.Token(Token = "0x400557C")]
	public const short SeaTurtle = 625;

	[Cpp2IlInjected.Token(Token = "0x400557D")]
	public const short Seahorse = 626;

	[Cpp2IlInjected.Token(Token = "0x400557E")]
	public const short GoldSeahorse = 627;

	[Cpp2IlInjected.Token(Token = "0x400557F")]
	public const short Dandelion = 628;

	[Cpp2IlInjected.Token(Token = "0x4005580")]
	public const short IceMimic = 629;

	[Cpp2IlInjected.Token(Token = "0x4005581")]
	public const short BloodMummy = 630;

	[Cpp2IlInjected.Token(Token = "0x4005582")]
	public const short RockGolem = 631;

	[Cpp2IlInjected.Token(Token = "0x4005583")]
	public const short MaggotZombie = 632;

	[Cpp2IlInjected.Token(Token = "0x4005584")]
	public const short BestiaryGirl = 633;

	[Cpp2IlInjected.Token(Token = "0x4005585")]
	public const short SporeBat = 634;

	[Cpp2IlInjected.Token(Token = "0x4005586")]
	public const short SporeSkeleton = 635;

	[Cpp2IlInjected.Token(Token = "0x4005587")]
	public const short HallowBoss = 636;

	[Cpp2IlInjected.Token(Token = "0x4005588")]
	public const short TownCat = 637;

	[Cpp2IlInjected.Token(Token = "0x4005589")]
	public const short TownDog = 638;

	[Cpp2IlInjected.Token(Token = "0x400558A")]
	public const short GemSquirrelAmethyst = 639;

	[Cpp2IlInjected.Token(Token = "0x400558B")]
	public const short GemSquirrelTopaz = 640;

	[Cpp2IlInjected.Token(Token = "0x400558C")]
	public const short GemSquirrelSapphire = 641;

	[Cpp2IlInjected.Token(Token = "0x400558D")]
	public const short GemSquirrelEmerald = 642;

	[Cpp2IlInjected.Token(Token = "0x400558E")]
	public const short GemSquirrelRuby = 643;

	[Cpp2IlInjected.Token(Token = "0x400558F")]
	public const short GemSquirrelDiamond = 644;

	[Cpp2IlInjected.Token(Token = "0x4005590")]
	public const short GemSquirrelAmber = 645;

	[Cpp2IlInjected.Token(Token = "0x4005591")]
	public const short GemBunnyAmethyst = 646;

	[Cpp2IlInjected.Token(Token = "0x4005592")]
	public const short GemBunnyTopaz = 647;

	[Cpp2IlInjected.Token(Token = "0x4005593")]
	public const short GemBunnySapphire = 648;

	[Cpp2IlInjected.Token(Token = "0x4005594")]
	public const short GemBunnyEmerald = 649;

	[Cpp2IlInjected.Token(Token = "0x4005595")]
	public const short GemBunnyRuby = 650;

	[Cpp2IlInjected.Token(Token = "0x4005596")]
	public const short GemBunnyDiamond = 651;

	[Cpp2IlInjected.Token(Token = "0x4005597")]
	public const short GemBunnyAmber = 652;

	[Cpp2IlInjected.Token(Token = "0x4005598")]
	public const short HellButterfly = 653;

	[Cpp2IlInjected.Token(Token = "0x4005599")]
	public const short Lavafly = 654;

	[Cpp2IlInjected.Token(Token = "0x400559A")]
	public const short MagmaSnail = 655;

	[Cpp2IlInjected.Token(Token = "0x400559B")]
	public const short TownBunny = 656;

	[Cpp2IlInjected.Token(Token = "0x400559C")]
	public const short QueenSlimeBoss = 657;

	[Cpp2IlInjected.Token(Token = "0x400559D")]
	public const short QueenSlimeMinionBlue = 658;

	[Cpp2IlInjected.Token(Token = "0x400559E")]
	public const short QueenSlimeMinionPink = 659;

	[Cpp2IlInjected.Token(Token = "0x400559F")]
	public const short QueenSlimeMinionPurple = 660;

	[Cpp2IlInjected.Token(Token = "0x40055A0")]
	public const short EmpressButterfly = 661;

	[Cpp2IlInjected.Token(Token = "0x40055A1")]
	public const short PirateGhost = 662;

	[Cpp2IlInjected.Token(Token = "0x40055A2")]
	public const short Princess = 663;

	[Cpp2IlInjected.Token(Token = "0x40055A3")]
	public const short TorchGod = 664;

	[Cpp2IlInjected.Token(Token = "0x40055A4")]
	public const short ChaosBallTim = 665;

	[Cpp2IlInjected.Token(Token = "0x40055A5")]
	public const short VileSpitEaterOfWorlds = 666;

	[Cpp2IlInjected.Token(Token = "0x40055A6")]
	public const short GoldenSlime = 667;

	[Cpp2IlInjected.Token(Token = "0x40055A7")]
	public const short Deerclops = 668;

	[Cpp2IlInjected.Token(Token = "0x40055A8")]
	public const short Stinkbug = 669;

	[Cpp2IlInjected.Token(Token = "0x40055A9")]
	public const short TownSlimeBlue = 670;

	[Cpp2IlInjected.Token(Token = "0x40055AA")]
	public const short ScarletMacaw = 671;

	[Cpp2IlInjected.Token(Token = "0x40055AB")]
	public const short BlueMacaw = 672;

	[Cpp2IlInjected.Token(Token = "0x40055AC")]
	public const short Toucan = 673;

	[Cpp2IlInjected.Token(Token = "0x40055AD")]
	public const short YellowCockatiel = 674;

	[Cpp2IlInjected.Token(Token = "0x40055AE")]
	public const short GrayCockatiel = 675;

	[Cpp2IlInjected.Token(Token = "0x40055AF")]
	public const short ShimmerSlime = 676;

	[Cpp2IlInjected.Token(Token = "0x40055B0")]
	public const short Shimmerfly = 677;

	[Cpp2IlInjected.Token(Token = "0x40055B1")]
	public const short TownSlimeGreen = 678;

	[Cpp2IlInjected.Token(Token = "0x40055B2")]
	public const short TownSlimeOld = 679;

	[Cpp2IlInjected.Token(Token = "0x40055B3")]
	public const short TownSlimePurple = 680;

	[Cpp2IlInjected.Token(Token = "0x40055B4")]
	public const short TownSlimeRainbow = 681;

	[Cpp2IlInjected.Token(Token = "0x40055B5")]
	public const short TownSlimeRed = 682;

	[Cpp2IlInjected.Token(Token = "0x40055B6")]
	public const short TownSlimeYellow = 683;

	[Cpp2IlInjected.Token(Token = "0x40055B7")]
	public const short TownSlimeCopper = 684;

	[Cpp2IlInjected.Token(Token = "0x40055B8")]
	public const short BoundTownSlimeOld = 685;

	[Cpp2IlInjected.Token(Token = "0x40055B9")]
	public const short BoundTownSlimePurple = 686;

	[Cpp2IlInjected.Token(Token = "0x40055BA")]
	public const short BoundTownSlimeYellow = 687;

	[Cpp2IlInjected.Token(Token = "0x40055BB")]
	public const short Count = 688;

	[Cpp2IlInjected.Token(Token = "0x40055BC")]
	public static readonly IdDictionary Search;

	[Cpp2IlInjected.Token(Token = "0x60030A0")]
	[Cpp2IlInjected.Address(RVA = "0x151EC08", Offset = "0x151EC08", VA = "0x151EC08")]
	public static int FromLegacyName(string name)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60030A1")]
	[Cpp2IlInjected.Address(RVA = "0x151ECBC", Offset = "0x151ECBC", VA = "0x151ECBC")]
	public static int FromNetId(int id)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60030A2")]
	[Cpp2IlInjected.Address(RVA = "0x151ED50", Offset = "0x151ED50", VA = "0x151ED50")]
	public NPCID()
	{
	}
}
