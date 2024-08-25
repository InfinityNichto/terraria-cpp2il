using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005DF")]
	public class NPCID
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003563")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2B34", Offset = "0x13C2B34", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadNPCs", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static int FromLegacyName(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003564")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2BCC", Offset = "0x13C2BCC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SetDefaultsFromNetId", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "InitializeLegacyLocalization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static int FromNetId(int id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003565")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2C3C", Offset = "0x13C2C3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCID()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003566")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2C44", Offset = "0x13C2C44", Length = "0x4B18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "Create", MemberTypeParameters = new object[] { "IdClass", "IdType" }, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 482)]
		static NPCID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4006573")]
		private static readonly int[] NetIdMap;

		[global::Cpp2ILInjected.Token(Token = "0x4006574")]
		private static readonly Dictionary<string, int> LegacyNameToIdMap;

		[global::Cpp2ILInjected.Token(Token = "0x4006575")]
		public const short NegativeIDCount = -66;

		[global::Cpp2ILInjected.Token(Token = "0x4006576")]
		public const short BigHornetStingy = -65;

		[global::Cpp2ILInjected.Token(Token = "0x4006577")]
		public const short LittleHornetStingy = -64;

		[global::Cpp2ILInjected.Token(Token = "0x4006578")]
		public const short BigHornetSpikey = -63;

		[global::Cpp2ILInjected.Token(Token = "0x4006579")]
		public const short LittleHornetSpikey = -62;

		[global::Cpp2ILInjected.Token(Token = "0x400657A")]
		public const short BigHornetLeafy = -61;

		[global::Cpp2ILInjected.Token(Token = "0x400657B")]
		public const short LittleHornetLeafy = -60;

		[global::Cpp2ILInjected.Token(Token = "0x400657C")]
		public const short BigHornetHoney = -59;

		[global::Cpp2ILInjected.Token(Token = "0x400657D")]
		public const short LittleHornetHoney = -58;

		[global::Cpp2ILInjected.Token(Token = "0x400657E")]
		public const short BigHornetFatty = -57;

		[global::Cpp2ILInjected.Token(Token = "0x400657F")]
		public const short LittleHornetFatty = -56;

		[global::Cpp2ILInjected.Token(Token = "0x4006580")]
		public const short BigRainZombie = -55;

		[global::Cpp2ILInjected.Token(Token = "0x4006581")]
		public const short SmallRainZombie = -54;

		[global::Cpp2ILInjected.Token(Token = "0x4006582")]
		public const short BigPantlessSkeleton = -53;

		[global::Cpp2ILInjected.Token(Token = "0x4006583")]
		public const short SmallPantlessSkeleton = -52;

		[global::Cpp2ILInjected.Token(Token = "0x4006584")]
		public const short BigMisassembledSkeleton = -51;

		[global::Cpp2ILInjected.Token(Token = "0x4006585")]
		public const short SmallMisassembledSkeleton = -50;

		[global::Cpp2ILInjected.Token(Token = "0x4006586")]
		public const short BigHeadacheSkeleton = -49;

		[global::Cpp2ILInjected.Token(Token = "0x4006587")]
		public const short SmallHeadacheSkeleton = -48;

		[global::Cpp2ILInjected.Token(Token = "0x4006588")]
		public const short BigSkeleton = -47;

		[global::Cpp2ILInjected.Token(Token = "0x4006589")]
		public const short SmallSkeleton = -46;

		[global::Cpp2ILInjected.Token(Token = "0x400658A")]
		public const short BigFemaleZombie = -45;

		[global::Cpp2ILInjected.Token(Token = "0x400658B")]
		public const short SmallFemaleZombie = -44;

		[global::Cpp2ILInjected.Token(Token = "0x400658C")]
		public const short DemonEye2 = -43;

		[global::Cpp2ILInjected.Token(Token = "0x400658D")]
		public const short PurpleEye2 = -42;

		[global::Cpp2ILInjected.Token(Token = "0x400658E")]
		public const short GreenEye2 = -41;

		[global::Cpp2ILInjected.Token(Token = "0x400658F")]
		public const short DialatedEye2 = -40;

		[global::Cpp2ILInjected.Token(Token = "0x4006590")]
		public const short SleepyEye2 = -39;

		[global::Cpp2ILInjected.Token(Token = "0x4006591")]
		public const short CataractEye2 = -38;

		[global::Cpp2ILInjected.Token(Token = "0x4006592")]
		public const short BigTwiggyZombie = -37;

		[global::Cpp2ILInjected.Token(Token = "0x4006593")]
		public const short SmallTwiggyZombie = -36;

		[global::Cpp2ILInjected.Token(Token = "0x4006594")]
		public const short BigSwampZombie = -35;

		[global::Cpp2ILInjected.Token(Token = "0x4006595")]
		public const short SmallSwampZombie = -34;

		[global::Cpp2ILInjected.Token(Token = "0x4006596")]
		public const short BigSlimedZombie = -33;

		[global::Cpp2ILInjected.Token(Token = "0x4006597")]
		public const short SmallSlimedZombie = -32;

		[global::Cpp2ILInjected.Token(Token = "0x4006598")]
		public const short BigPincushionZombie = -31;

		[global::Cpp2ILInjected.Token(Token = "0x4006599")]
		public const short SmallPincushionZombie = -30;

		[global::Cpp2ILInjected.Token(Token = "0x400659A")]
		public const short BigBaldZombie = -29;

		[global::Cpp2ILInjected.Token(Token = "0x400659B")]
		public const short SmallBaldZombie = -28;

		[global::Cpp2ILInjected.Token(Token = "0x400659C")]
		public const short BigZombie = -27;

		[global::Cpp2ILInjected.Token(Token = "0x400659D")]
		public const short SmallZombie = -26;

		[global::Cpp2ILInjected.Token(Token = "0x400659E")]
		public const short BigCrimslime = -25;

		[global::Cpp2ILInjected.Token(Token = "0x400659F")]
		public const short LittleCrimslime = -24;

		[global::Cpp2ILInjected.Token(Token = "0x40065A0")]
		public const short BigCrimera = -23;

		[global::Cpp2ILInjected.Token(Token = "0x40065A1")]
		public const short LittleCrimera = -22;

		[global::Cpp2ILInjected.Token(Token = "0x40065A2")]
		public const short GiantMossHornet = -21;

		[global::Cpp2ILInjected.Token(Token = "0x40065A3")]
		public const short BigMossHornet = -20;

		[global::Cpp2ILInjected.Token(Token = "0x40065A4")]
		public const short LittleMossHornet = -19;

		[global::Cpp2ILInjected.Token(Token = "0x40065A5")]
		public const short TinyMossHornet = -18;

		[global::Cpp2ILInjected.Token(Token = "0x40065A6")]
		public const short BigStinger = -17;

		[global::Cpp2ILInjected.Token(Token = "0x40065A7")]
		public const short LittleStinger = -16;

		[global::Cpp2ILInjected.Token(Token = "0x40065A8")]
		public const short HeavySkeleton = -15;

		[global::Cpp2ILInjected.Token(Token = "0x40065A9")]
		public const short BigBoned = -14;

		[global::Cpp2ILInjected.Token(Token = "0x40065AA")]
		public const short ShortBones = -13;

		[global::Cpp2ILInjected.Token(Token = "0x40065AB")]
		public const short BigEater = -12;

		[global::Cpp2ILInjected.Token(Token = "0x40065AC")]
		public const short LittleEater = -11;

		[global::Cpp2ILInjected.Token(Token = "0x40065AD")]
		public const short JungleSlime = -10;

		[global::Cpp2ILInjected.Token(Token = "0x40065AE")]
		public const short YellowSlime = -9;

		[global::Cpp2ILInjected.Token(Token = "0x40065AF")]
		public const short RedSlime = -8;

		[global::Cpp2ILInjected.Token(Token = "0x40065B0")]
		public const short PurpleSlime = -7;

		[global::Cpp2ILInjected.Token(Token = "0x40065B1")]
		public const short BlackSlime = -6;

		[global::Cpp2ILInjected.Token(Token = "0x40065B2")]
		public const short BabySlime = -5;

		[global::Cpp2ILInjected.Token(Token = "0x40065B3")]
		public const short Pinky = -4;

		[global::Cpp2ILInjected.Token(Token = "0x40065B4")]
		public const short GreenSlime = -3;

		[global::Cpp2ILInjected.Token(Token = "0x40065B5")]
		public const short Slimer2 = -2;

		[global::Cpp2ILInjected.Token(Token = "0x40065B6")]
		public const short Slimeling = -1;

		[global::Cpp2ILInjected.Token(Token = "0x40065B7")]
		public const short None = 0;

		[global::Cpp2ILInjected.Token(Token = "0x40065B8")]
		public const short BlueSlime = 1;

		[global::Cpp2ILInjected.Token(Token = "0x40065B9")]
		public const short DemonEye = 2;

		[global::Cpp2ILInjected.Token(Token = "0x40065BA")]
		public const short Zombie = 3;

		[global::Cpp2ILInjected.Token(Token = "0x40065BB")]
		public const short EyeofCthulhu = 4;

		[global::Cpp2ILInjected.Token(Token = "0x40065BC")]
		public const short ServantofCthulhu = 5;

		[global::Cpp2ILInjected.Token(Token = "0x40065BD")]
		public const short EaterofSouls = 6;

		[global::Cpp2ILInjected.Token(Token = "0x40065BE")]
		public const short DevourerHead = 7;

		[global::Cpp2ILInjected.Token(Token = "0x40065BF")]
		public const short DevourerBody = 8;

		[global::Cpp2ILInjected.Token(Token = "0x40065C0")]
		public const short DevourerTail = 9;

		[global::Cpp2ILInjected.Token(Token = "0x40065C1")]
		public const short GiantWormHead = 10;

		[global::Cpp2ILInjected.Token(Token = "0x40065C2")]
		public const short GiantWormBody = 11;

		[global::Cpp2ILInjected.Token(Token = "0x40065C3")]
		public const short GiantWormTail = 12;

		[global::Cpp2ILInjected.Token(Token = "0x40065C4")]
		public const short EaterofWorldsHead = 13;

		[global::Cpp2ILInjected.Token(Token = "0x40065C5")]
		public const short EaterofWorldsBody = 14;

		[global::Cpp2ILInjected.Token(Token = "0x40065C6")]
		public const short EaterofWorldsTail = 15;

		[global::Cpp2ILInjected.Token(Token = "0x40065C7")]
		public const short MotherSlime = 16;

		[global::Cpp2ILInjected.Token(Token = "0x40065C8")]
		public const short Merchant = 17;

		[global::Cpp2ILInjected.Token(Token = "0x40065C9")]
		public const short Nurse = 18;

		[global::Cpp2ILInjected.Token(Token = "0x40065CA")]
		public const short ArmsDealer = 19;

		[global::Cpp2ILInjected.Token(Token = "0x40065CB")]
		public const short Dryad = 20;

		[global::Cpp2ILInjected.Token(Token = "0x40065CC")]
		public const short Skeleton = 21;

		[global::Cpp2ILInjected.Token(Token = "0x40065CD")]
		public const short Guide = 22;

		[global::Cpp2ILInjected.Token(Token = "0x40065CE")]
		public const short MeteorHead = 23;

		[global::Cpp2ILInjected.Token(Token = "0x40065CF")]
		public const short FireImp = 24;

		[global::Cpp2ILInjected.Token(Token = "0x40065D0")]
		public const short BurningSphere = 25;

		[global::Cpp2ILInjected.Token(Token = "0x40065D1")]
		public const short GoblinPeon = 26;

		[global::Cpp2ILInjected.Token(Token = "0x40065D2")]
		public const short GoblinThief = 27;

		[global::Cpp2ILInjected.Token(Token = "0x40065D3")]
		public const short GoblinWarrior = 28;

		[global::Cpp2ILInjected.Token(Token = "0x40065D4")]
		public const short GoblinSorcerer = 29;

		[global::Cpp2ILInjected.Token(Token = "0x40065D5")]
		public const short ChaosBall = 30;

		[global::Cpp2ILInjected.Token(Token = "0x40065D6")]
		public const short AngryBones = 31;

		[global::Cpp2ILInjected.Token(Token = "0x40065D7")]
		public const short DarkCaster = 32;

		[global::Cpp2ILInjected.Token(Token = "0x40065D8")]
		public const short WaterSphere = 33;

		[global::Cpp2ILInjected.Token(Token = "0x40065D9")]
		public const short CursedSkull = 34;

		[global::Cpp2ILInjected.Token(Token = "0x40065DA")]
		public const short SkeletronHead = 35;

		[global::Cpp2ILInjected.Token(Token = "0x40065DB")]
		public const short SkeletronHand = 36;

		[global::Cpp2ILInjected.Token(Token = "0x40065DC")]
		public const short OldMan = 37;

		[global::Cpp2ILInjected.Token(Token = "0x40065DD")]
		public const short Demolitionist = 38;

		[global::Cpp2ILInjected.Token(Token = "0x40065DE")]
		public const short BoneSerpentHead = 39;

		[global::Cpp2ILInjected.Token(Token = "0x40065DF")]
		public const short BoneSerpentBody = 40;

		[global::Cpp2ILInjected.Token(Token = "0x40065E0")]
		public const short BoneSerpentTail = 41;

		[global::Cpp2ILInjected.Token(Token = "0x40065E1")]
		public const short Hornet = 42;

		[global::Cpp2ILInjected.Token(Token = "0x40065E2")]
		public const short ManEater = 43;

		[global::Cpp2ILInjected.Token(Token = "0x40065E3")]
		public const short UndeadMiner = 44;

		[global::Cpp2ILInjected.Token(Token = "0x40065E4")]
		public const short Tim = 45;

		[global::Cpp2ILInjected.Token(Token = "0x40065E5")]
		public const short Bunny = 46;

		[global::Cpp2ILInjected.Token(Token = "0x40065E6")]
		public const short CorruptBunny = 47;

		[global::Cpp2ILInjected.Token(Token = "0x40065E7")]
		public const short Harpy = 48;

		[global::Cpp2ILInjected.Token(Token = "0x40065E8")]
		public const short CaveBat = 49;

		[global::Cpp2ILInjected.Token(Token = "0x40065E9")]
		public const short KingSlime = 50;

		[global::Cpp2ILInjected.Token(Token = "0x40065EA")]
		public const short JungleBat = 51;

		[global::Cpp2ILInjected.Token(Token = "0x40065EB")]
		public const short DoctorBones = 52;

		[global::Cpp2ILInjected.Token(Token = "0x40065EC")]
		public const short TheGroom = 53;

		[global::Cpp2ILInjected.Token(Token = "0x40065ED")]
		public const short Clothier = 54;

		[global::Cpp2ILInjected.Token(Token = "0x40065EE")]
		public const short Goldfish = 55;

		[global::Cpp2ILInjected.Token(Token = "0x40065EF")]
		public const short Snatcher = 56;

		[global::Cpp2ILInjected.Token(Token = "0x40065F0")]
		public const short CorruptGoldfish = 57;

		[global::Cpp2ILInjected.Token(Token = "0x40065F1")]
		public const short Piranha = 58;

		[global::Cpp2ILInjected.Token(Token = "0x40065F2")]
		public const short LavaSlime = 59;

		[global::Cpp2ILInjected.Token(Token = "0x40065F3")]
		public const short Hellbat = 60;

		[global::Cpp2ILInjected.Token(Token = "0x40065F4")]
		public const short Vulture = 61;

		[global::Cpp2ILInjected.Token(Token = "0x40065F5")]
		public const short Demon = 62;

		[global::Cpp2ILInjected.Token(Token = "0x40065F6")]
		public const short BlueJellyfish = 63;

		[global::Cpp2ILInjected.Token(Token = "0x40065F7")]
		public const short PinkJellyfish = 64;

		[global::Cpp2ILInjected.Token(Token = "0x40065F8")]
		public const short Shark = 65;

		[global::Cpp2ILInjected.Token(Token = "0x40065F9")]
		public const short VoodooDemon = 66;

		[global::Cpp2ILInjected.Token(Token = "0x40065FA")]
		public const short Crab = 67;

		[global::Cpp2ILInjected.Token(Token = "0x40065FB")]
		public const short DungeonGuardian = 68;

		[global::Cpp2ILInjected.Token(Token = "0x40065FC")]
		public const short Antlion = 69;

		[global::Cpp2ILInjected.Token(Token = "0x40065FD")]
		public const short SpikeBall = 70;

		[global::Cpp2ILInjected.Token(Token = "0x40065FE")]
		public const short DungeonSlime = 71;

		[global::Cpp2ILInjected.Token(Token = "0x40065FF")]
		public const short BlazingWheel = 72;

		[global::Cpp2ILInjected.Token(Token = "0x4006600")]
		public const short GoblinScout = 73;

		[global::Cpp2ILInjected.Token(Token = "0x4006601")]
		public const short Bird = 74;

		[global::Cpp2ILInjected.Token(Token = "0x4006602")]
		public const short Pixie = 75;

		[global::Cpp2ILInjected.Token(Token = "0x4006603")]
		public const short None2 = 76;

		[global::Cpp2ILInjected.Token(Token = "0x4006604")]
		public const short ArmoredSkeleton = 77;

		[global::Cpp2ILInjected.Token(Token = "0x4006605")]
		public const short Mummy = 78;

		[global::Cpp2ILInjected.Token(Token = "0x4006606")]
		public const short DarkMummy = 79;

		[global::Cpp2ILInjected.Token(Token = "0x4006607")]
		public const short LightMummy = 80;

		[global::Cpp2ILInjected.Token(Token = "0x4006608")]
		public const short CorruptSlime = 81;

		[global::Cpp2ILInjected.Token(Token = "0x4006609")]
		public const short Wraith = 82;

		[global::Cpp2ILInjected.Token(Token = "0x400660A")]
		public const short CursedHammer = 83;

		[global::Cpp2ILInjected.Token(Token = "0x400660B")]
		public const short EnchantedSword = 84;

		[global::Cpp2ILInjected.Token(Token = "0x400660C")]
		public const short Mimic = 85;

		[global::Cpp2ILInjected.Token(Token = "0x400660D")]
		public const short Unicorn = 86;

		[global::Cpp2ILInjected.Token(Token = "0x400660E")]
		public const short WyvernHead = 87;

		[global::Cpp2ILInjected.Token(Token = "0x400660F")]
		public const short WyvernLegs = 88;

		[global::Cpp2ILInjected.Token(Token = "0x4006610")]
		public const short WyvernBody = 89;

		[global::Cpp2ILInjected.Token(Token = "0x4006611")]
		public const short WyvernBody2 = 90;

		[global::Cpp2ILInjected.Token(Token = "0x4006612")]
		public const short WyvernBody3 = 91;

		[global::Cpp2ILInjected.Token(Token = "0x4006613")]
		public const short WyvernTail = 92;

		[global::Cpp2ILInjected.Token(Token = "0x4006614")]
		public const short GiantBat = 93;

		[global::Cpp2ILInjected.Token(Token = "0x4006615")]
		public const short Corruptor = 94;

		[global::Cpp2ILInjected.Token(Token = "0x4006616")]
		public const short DiggerHead = 95;

		[global::Cpp2ILInjected.Token(Token = "0x4006617")]
		public const short DiggerBody = 96;

		[global::Cpp2ILInjected.Token(Token = "0x4006618")]
		public const short DiggerTail = 97;

		[global::Cpp2ILInjected.Token(Token = "0x4006619")]
		public const short SeekerHead = 98;

		[global::Cpp2ILInjected.Token(Token = "0x400661A")]
		public const short SeekerBody = 99;

		[global::Cpp2ILInjected.Token(Token = "0x400661B")]
		public const short SeekerTail = 100;

		[global::Cpp2ILInjected.Token(Token = "0x400661C")]
		public const short Clinger = 101;

		[global::Cpp2ILInjected.Token(Token = "0x400661D")]
		public const short AnglerFish = 102;

		[global::Cpp2ILInjected.Token(Token = "0x400661E")]
		public const short GreenJellyfish = 103;

		[global::Cpp2ILInjected.Token(Token = "0x400661F")]
		public const short Werewolf = 104;

		[global::Cpp2ILInjected.Token(Token = "0x4006620")]
		public const short BoundGoblin = 105;

		[global::Cpp2ILInjected.Token(Token = "0x4006621")]
		public const short BoundWizard = 106;

		[global::Cpp2ILInjected.Token(Token = "0x4006622")]
		public const short GoblinTinkerer = 107;

		[global::Cpp2ILInjected.Token(Token = "0x4006623")]
		public const short Wizard = 108;

		[global::Cpp2ILInjected.Token(Token = "0x4006624")]
		public const short Clown = 109;

		[global::Cpp2ILInjected.Token(Token = "0x4006625")]
		public const short SkeletonArcher = 110;

		[global::Cpp2ILInjected.Token(Token = "0x4006626")]
		public const short GoblinArcher = 111;

		[global::Cpp2ILInjected.Token(Token = "0x4006627")]
		public const short VileSpit = 112;

		[global::Cpp2ILInjected.Token(Token = "0x4006628")]
		public const short WallofFlesh = 113;

		[global::Cpp2ILInjected.Token(Token = "0x4006629")]
		public const short WallofFleshEye = 114;

		[global::Cpp2ILInjected.Token(Token = "0x400662A")]
		public const short TheHungry = 115;

		[global::Cpp2ILInjected.Token(Token = "0x400662B")]
		public const short TheHungryII = 116;

		[global::Cpp2ILInjected.Token(Token = "0x400662C")]
		public const short LeechHead = 117;

		[global::Cpp2ILInjected.Token(Token = "0x400662D")]
		public const short LeechBody = 118;

		[global::Cpp2ILInjected.Token(Token = "0x400662E")]
		public const short LeechTail = 119;

		[global::Cpp2ILInjected.Token(Token = "0x400662F")]
		public const short ChaosElemental = 120;

		[global::Cpp2ILInjected.Token(Token = "0x4006630")]
		public const short Slimer = 121;

		[global::Cpp2ILInjected.Token(Token = "0x4006631")]
		public const short Gastropod = 122;

		[global::Cpp2ILInjected.Token(Token = "0x4006632")]
		public const short BoundMechanic = 123;

		[global::Cpp2ILInjected.Token(Token = "0x4006633")]
		public const short Mechanic = 124;

		[global::Cpp2ILInjected.Token(Token = "0x4006634")]
		public const short Retinazer = 125;

		[global::Cpp2ILInjected.Token(Token = "0x4006635")]
		public const short Spazmatism = 126;

		[global::Cpp2ILInjected.Token(Token = "0x4006636")]
		public const short SkeletronPrime = 127;

		[global::Cpp2ILInjected.Token(Token = "0x4006637")]
		public const short PrimeCannon = 128;

		[global::Cpp2ILInjected.Token(Token = "0x4006638")]
		public const short PrimeSaw = 129;

		[global::Cpp2ILInjected.Token(Token = "0x4006639")]
		public const short PrimeVice = 130;

		[global::Cpp2ILInjected.Token(Token = "0x400663A")]
		public const short PrimeLaser = 131;

		[global::Cpp2ILInjected.Token(Token = "0x400663B")]
		public const short BaldZombie = 132;

		[global::Cpp2ILInjected.Token(Token = "0x400663C")]
		public const short WanderingEye = 133;

		[global::Cpp2ILInjected.Token(Token = "0x400663D")]
		public const short TheDestroyer = 134;

		[global::Cpp2ILInjected.Token(Token = "0x400663E")]
		public const short TheDestroyerBody = 135;

		[global::Cpp2ILInjected.Token(Token = "0x400663F")]
		public const short TheDestroyerTail = 136;

		[global::Cpp2ILInjected.Token(Token = "0x4006640")]
		public const short IlluminantBat = 137;

		[global::Cpp2ILInjected.Token(Token = "0x4006641")]
		public const short IlluminantSlime = 138;

		[global::Cpp2ILInjected.Token(Token = "0x4006642")]
		public const short Probe = 139;

		[global::Cpp2ILInjected.Token(Token = "0x4006643")]
		public const short PossessedArmor = 140;

		[global::Cpp2ILInjected.Token(Token = "0x4006644")]
		public const short ToxicSludge = 141;

		[global::Cpp2ILInjected.Token(Token = "0x4006645")]
		public const short SantaClaus = 142;

		[global::Cpp2ILInjected.Token(Token = "0x4006646")]
		public const short SnowmanGangsta = 143;

		[global::Cpp2ILInjected.Token(Token = "0x4006647")]
		public const short MisterStabby = 144;

		[global::Cpp2ILInjected.Token(Token = "0x4006648")]
		public const short SnowBalla = 145;

		[global::Cpp2ILInjected.Token(Token = "0x4006649")]
		public const short None3 = 146;

		[global::Cpp2ILInjected.Token(Token = "0x400664A")]
		public const short IceSlime = 147;

		[global::Cpp2ILInjected.Token(Token = "0x400664B")]
		public const short Penguin = 148;

		[global::Cpp2ILInjected.Token(Token = "0x400664C")]
		public const short PenguinBlack = 149;

		[global::Cpp2ILInjected.Token(Token = "0x400664D")]
		public const short IceBat = 150;

		[global::Cpp2ILInjected.Token(Token = "0x400664E")]
		public const short Lavabat = 151;

		[global::Cpp2ILInjected.Token(Token = "0x400664F")]
		public const short GiantFlyingFox = 152;

		[global::Cpp2ILInjected.Token(Token = "0x4006650")]
		public const short GiantTortoise = 153;

		[global::Cpp2ILInjected.Token(Token = "0x4006651")]
		public const short IceTortoise = 154;

		[global::Cpp2ILInjected.Token(Token = "0x4006652")]
		public const short Wolf = 155;

		[global::Cpp2ILInjected.Token(Token = "0x4006653")]
		public const short RedDevil = 156;

		[global::Cpp2ILInjected.Token(Token = "0x4006654")]
		public const short Arapaima = 157;

		[global::Cpp2ILInjected.Token(Token = "0x4006655")]
		public const short VampireBat = 158;

		[global::Cpp2ILInjected.Token(Token = "0x4006656")]
		public const short Vampire = 159;

		[global::Cpp2ILInjected.Token(Token = "0x4006657")]
		public const short Truffle = 160;

		[global::Cpp2ILInjected.Token(Token = "0x4006658")]
		public const short ZombieEskimo = 161;

		[global::Cpp2ILInjected.Token(Token = "0x4006659")]
		public const short Frankenstein = 162;

		[global::Cpp2ILInjected.Token(Token = "0x400665A")]
		public const short BlackRecluse = 163;

		[global::Cpp2ILInjected.Token(Token = "0x400665B")]
		public const short WallCreeper = 164;

		[global::Cpp2ILInjected.Token(Token = "0x400665C")]
		public const short WallCreeperWall = 165;

		[global::Cpp2ILInjected.Token(Token = "0x400665D")]
		public const short SwampThing = 166;

		[global::Cpp2ILInjected.Token(Token = "0x400665E")]
		public const short UndeadViking = 167;

		[global::Cpp2ILInjected.Token(Token = "0x400665F")]
		public const short CorruptPenguin = 168;

		[global::Cpp2ILInjected.Token(Token = "0x4006660")]
		public const short IceElemental = 169;

		[global::Cpp2ILInjected.Token(Token = "0x4006661")]
		public const short PigronCorruption = 170;

		[global::Cpp2ILInjected.Token(Token = "0x4006662")]
		public const short PigronHallow = 171;

		[global::Cpp2ILInjected.Token(Token = "0x4006663")]
		public const short RuneWizard = 172;

		[global::Cpp2ILInjected.Token(Token = "0x4006664")]
		public const short Crimera = 173;

		[global::Cpp2ILInjected.Token(Token = "0x4006665")]
		public const short Herpling = 174;

		[global::Cpp2ILInjected.Token(Token = "0x4006666")]
		public const short AngryTrapper = 175;

		[global::Cpp2ILInjected.Token(Token = "0x4006667")]
		public const short MossHornet = 176;

		[global::Cpp2ILInjected.Token(Token = "0x4006668")]
		public const short Derpling = 177;

		[global::Cpp2ILInjected.Token(Token = "0x4006669")]
		public const short Steampunker = 178;

		[global::Cpp2ILInjected.Token(Token = "0x400666A")]
		public const short CrimsonAxe = 179;

		[global::Cpp2ILInjected.Token(Token = "0x400666B")]
		public const short PigronCrimson = 180;

		[global::Cpp2ILInjected.Token(Token = "0x400666C")]
		public const short FaceMonster = 181;

		[global::Cpp2ILInjected.Token(Token = "0x400666D")]
		public const short FloatyGross = 182;

		[global::Cpp2ILInjected.Token(Token = "0x400666E")]
		public const short Crimslime = 183;

		[global::Cpp2ILInjected.Token(Token = "0x400666F")]
		public const short SpikedIceSlime = 184;

		[global::Cpp2ILInjected.Token(Token = "0x4006670")]
		public const short SnowFlinx = 185;

		[global::Cpp2ILInjected.Token(Token = "0x4006671")]
		public const short PincushionZombie = 186;

		[global::Cpp2ILInjected.Token(Token = "0x4006672")]
		public const short SlimedZombie = 187;

		[global::Cpp2ILInjected.Token(Token = "0x4006673")]
		public const short SwampZombie = 188;

		[global::Cpp2ILInjected.Token(Token = "0x4006674")]
		public const short TwiggyZombie = 189;

		[global::Cpp2ILInjected.Token(Token = "0x4006675")]
		public const short CataractEye = 190;

		[global::Cpp2ILInjected.Token(Token = "0x4006676")]
		public const short SleepyEye = 191;

		[global::Cpp2ILInjected.Token(Token = "0x4006677")]
		public const short DialatedEye = 192;

		[global::Cpp2ILInjected.Token(Token = "0x4006678")]
		public const short GreenEye = 193;

		[global::Cpp2ILInjected.Token(Token = "0x4006679")]
		public const short PurpleEye = 194;

		[global::Cpp2ILInjected.Token(Token = "0x400667A")]
		public const short LostGirl = 195;

		[global::Cpp2ILInjected.Token(Token = "0x400667B")]
		public const short Nymph = 196;

		[global::Cpp2ILInjected.Token(Token = "0x400667C")]
		public const short ArmoredViking = 197;

		[global::Cpp2ILInjected.Token(Token = "0x400667D")]
		public const short Lihzahrd = 198;

		[global::Cpp2ILInjected.Token(Token = "0x400667E")]
		public const short LihzahrdCrawler = 199;

		[global::Cpp2ILInjected.Token(Token = "0x400667F")]
		public const short FemaleZombie = 200;

		[global::Cpp2ILInjected.Token(Token = "0x4006680")]
		public const short HeadacheSkeleton = 201;

		[global::Cpp2ILInjected.Token(Token = "0x4006681")]
		public const short MisassembledSkeleton = 202;

		[global::Cpp2ILInjected.Token(Token = "0x4006682")]
		public const short PantlessSkeleton = 203;

		[global::Cpp2ILInjected.Token(Token = "0x4006683")]
		public const short SpikedJungleSlime = 204;

		[global::Cpp2ILInjected.Token(Token = "0x4006684")]
		public const short Moth = 205;

		[global::Cpp2ILInjected.Token(Token = "0x4006685")]
		public const short IcyMerman = 206;

		[global::Cpp2ILInjected.Token(Token = "0x4006686")]
		public const short DyeTrader = 207;

		[global::Cpp2ILInjected.Token(Token = "0x4006687")]
		public const short PartyGirl = 208;

		[global::Cpp2ILInjected.Token(Token = "0x4006688")]
		public const short Cyborg = 209;

		[global::Cpp2ILInjected.Token(Token = "0x4006689")]
		public const short Bee = 210;

		[global::Cpp2ILInjected.Token(Token = "0x400668A")]
		public const short BeeSmall = 211;

		[global::Cpp2ILInjected.Token(Token = "0x400668B")]
		public const short PirateDeckhand = 212;

		[global::Cpp2ILInjected.Token(Token = "0x400668C")]
		public const short PirateCorsair = 213;

		[global::Cpp2ILInjected.Token(Token = "0x400668D")]
		public const short PirateDeadeye = 214;

		[global::Cpp2ILInjected.Token(Token = "0x400668E")]
		public const short PirateCrossbower = 215;

		[global::Cpp2ILInjected.Token(Token = "0x400668F")]
		public const short PirateCaptain = 216;

		[global::Cpp2ILInjected.Token(Token = "0x4006690")]
		public const short CochinealBeetle = 217;

		[global::Cpp2ILInjected.Token(Token = "0x4006691")]
		public const short CyanBeetle = 218;

		[global::Cpp2ILInjected.Token(Token = "0x4006692")]
		public const short LacBeetle = 219;

		[global::Cpp2ILInjected.Token(Token = "0x4006693")]
		public const short SeaSnail = 220;

		[global::Cpp2ILInjected.Token(Token = "0x4006694")]
		public const short Squid = 221;

		[global::Cpp2ILInjected.Token(Token = "0x4006695")]
		public const short QueenBee = 222;

		[global::Cpp2ILInjected.Token(Token = "0x4006696")]
		public const short ZombieRaincoat = 223;

		[global::Cpp2ILInjected.Token(Token = "0x4006697")]
		public const short FlyingFish = 224;

		[global::Cpp2ILInjected.Token(Token = "0x4006698")]
		public const short UmbrellaSlime = 225;

		[global::Cpp2ILInjected.Token(Token = "0x4006699")]
		public const short FlyingSnake = 226;

		[global::Cpp2ILInjected.Token(Token = "0x400669A")]
		public const short Painter = 227;

		[global::Cpp2ILInjected.Token(Token = "0x400669B")]
		public const short WitchDoctor = 228;

		[global::Cpp2ILInjected.Token(Token = "0x400669C")]
		public const short Pirate = 229;

		[global::Cpp2ILInjected.Token(Token = "0x400669D")]
		public const short GoldfishWalker = 230;

		[global::Cpp2ILInjected.Token(Token = "0x400669E")]
		public const short HornetFatty = 231;

		[global::Cpp2ILInjected.Token(Token = "0x400669F")]
		public const short HornetHoney = 232;

		[global::Cpp2ILInjected.Token(Token = "0x40066A0")]
		public const short HornetLeafy = 233;

		[global::Cpp2ILInjected.Token(Token = "0x40066A1")]
		public const short HornetSpikey = 234;

		[global::Cpp2ILInjected.Token(Token = "0x40066A2")]
		public const short HornetStingy = 235;

		[global::Cpp2ILInjected.Token(Token = "0x40066A3")]
		public const short JungleCreeper = 236;

		[global::Cpp2ILInjected.Token(Token = "0x40066A4")]
		public const short JungleCreeperWall = 237;

		[global::Cpp2ILInjected.Token(Token = "0x40066A5")]
		public const short BlackRecluseWall = 238;

		[global::Cpp2ILInjected.Token(Token = "0x40066A6")]
		public const short BloodCrawler = 239;

		[global::Cpp2ILInjected.Token(Token = "0x40066A7")]
		public const short BloodCrawlerWall = 240;

		[global::Cpp2ILInjected.Token(Token = "0x40066A8")]
		public const short BloodFeeder = 241;

		[global::Cpp2ILInjected.Token(Token = "0x40066A9")]
		public const short BloodJelly = 242;

		[global::Cpp2ILInjected.Token(Token = "0x40066AA")]
		public const short IceGolem = 243;

		[global::Cpp2ILInjected.Token(Token = "0x40066AB")]
		public const short RainbowSlime = 244;

		[global::Cpp2ILInjected.Token(Token = "0x40066AC")]
		public const short Golem = 245;

		[global::Cpp2ILInjected.Token(Token = "0x40066AD")]
		public const short GolemHead = 246;

		[global::Cpp2ILInjected.Token(Token = "0x40066AE")]
		public const short GolemFistLeft = 247;

		[global::Cpp2ILInjected.Token(Token = "0x40066AF")]
		public const short GolemFistRight = 248;

		[global::Cpp2ILInjected.Token(Token = "0x40066B0")]
		public const short GolemHeadFree = 249;

		[global::Cpp2ILInjected.Token(Token = "0x40066B1")]
		public const short AngryNimbus = 250;

		[global::Cpp2ILInjected.Token(Token = "0x40066B2")]
		public const short Eyezor = 251;

		[global::Cpp2ILInjected.Token(Token = "0x40066B3")]
		public const short Parrot = 252;

		[global::Cpp2ILInjected.Token(Token = "0x40066B4")]
		public const short Reaper = 253;

		[global::Cpp2ILInjected.Token(Token = "0x40066B5")]
		public const short ZombieMushroom = 254;

		[global::Cpp2ILInjected.Token(Token = "0x40066B6")]
		public const short ZombieMushroomHat = 255;

		[global::Cpp2ILInjected.Token(Token = "0x40066B7")]
		public const short FungoFish = 256;

		[global::Cpp2ILInjected.Token(Token = "0x40066B8")]
		public const short AnomuraFungus = 257;

		[global::Cpp2ILInjected.Token(Token = "0x40066B9")]
		public const short MushiLadybug = 258;

		[global::Cpp2ILInjected.Token(Token = "0x40066BA")]
		public const short FungiBulb = 259;

		[global::Cpp2ILInjected.Token(Token = "0x40066BB")]
		public const short GiantFungiBulb = 260;

		[global::Cpp2ILInjected.Token(Token = "0x40066BC")]
		public const short FungiSpore = 261;

		[global::Cpp2ILInjected.Token(Token = "0x40066BD")]
		public const short Plantera = 262;

		[global::Cpp2ILInjected.Token(Token = "0x40066BE")]
		public const short PlanterasHook = 263;

		[global::Cpp2ILInjected.Token(Token = "0x40066BF")]
		public const short PlanterasTentacle = 264;

		[global::Cpp2ILInjected.Token(Token = "0x40066C0")]
		public const short Spore = 265;

		[global::Cpp2ILInjected.Token(Token = "0x40066C1")]
		public const short BrainofCthulhu = 266;

		[global::Cpp2ILInjected.Token(Token = "0x40066C2")]
		public const short Creeper = 267;

		[global::Cpp2ILInjected.Token(Token = "0x40066C3")]
		public const short IchorSticker = 268;

		[global::Cpp2ILInjected.Token(Token = "0x40066C4")]
		public const short RustyArmoredBonesAxe = 269;

		[global::Cpp2ILInjected.Token(Token = "0x40066C5")]
		public const short RustyArmoredBonesFlail = 270;

		[global::Cpp2ILInjected.Token(Token = "0x40066C6")]
		public const short RustyArmoredBonesSword = 271;

		[global::Cpp2ILInjected.Token(Token = "0x40066C7")]
		public const short RustyArmoredBonesSwordNoArmor = 272;

		[global::Cpp2ILInjected.Token(Token = "0x40066C8")]
		public const short BlueArmoredBones = 273;

		[global::Cpp2ILInjected.Token(Token = "0x40066C9")]
		public const short BlueArmoredBonesMace = 274;

		[global::Cpp2ILInjected.Token(Token = "0x40066CA")]
		public const short BlueArmoredBonesNoPants = 275;

		[global::Cpp2ILInjected.Token(Token = "0x40066CB")]
		public const short BlueArmoredBonesSword = 276;

		[global::Cpp2ILInjected.Token(Token = "0x40066CC")]
		public const short HellArmoredBones = 277;

		[global::Cpp2ILInjected.Token(Token = "0x40066CD")]
		public const short HellArmoredBonesSpikeShield = 278;

		[global::Cpp2ILInjected.Token(Token = "0x40066CE")]
		public const short HellArmoredBonesMace = 279;

		[global::Cpp2ILInjected.Token(Token = "0x40066CF")]
		public const short HellArmoredBonesSword = 280;

		[global::Cpp2ILInjected.Token(Token = "0x40066D0")]
		public const short RaggedCaster = 281;

		[global::Cpp2ILInjected.Token(Token = "0x40066D1")]
		public const short RaggedCasterOpenCoat = 282;

		[global::Cpp2ILInjected.Token(Token = "0x40066D2")]
		public const short Necromancer = 283;

		[global::Cpp2ILInjected.Token(Token = "0x40066D3")]
		public const short NecromancerArmored = 284;

		[global::Cpp2ILInjected.Token(Token = "0x40066D4")]
		public const short DiabolistRed = 285;

		[global::Cpp2ILInjected.Token(Token = "0x40066D5")]
		public const short DiabolistWhite = 286;

		[global::Cpp2ILInjected.Token(Token = "0x40066D6")]
		public const short BoneLee = 287;

		[global::Cpp2ILInjected.Token(Token = "0x40066D7")]
		public const short DungeonSpirit = 288;

		[global::Cpp2ILInjected.Token(Token = "0x40066D8")]
		public const short GiantCursedSkull = 289;

		[global::Cpp2ILInjected.Token(Token = "0x40066D9")]
		public const short Paladin = 290;

		[global::Cpp2ILInjected.Token(Token = "0x40066DA")]
		public const short SkeletonSniper = 291;

		[global::Cpp2ILInjected.Token(Token = "0x40066DB")]
		public const short TacticalSkeleton = 292;

		[global::Cpp2ILInjected.Token(Token = "0x40066DC")]
		public const short SkeletonCommando = 293;

		[global::Cpp2ILInjected.Token(Token = "0x40066DD")]
		public const short AngryBonesBig = 294;

		[global::Cpp2ILInjected.Token(Token = "0x40066DE")]
		public const short AngryBonesBigMuscle = 295;

		[global::Cpp2ILInjected.Token(Token = "0x40066DF")]
		public const short AngryBonesBigHelmet = 296;

		[global::Cpp2ILInjected.Token(Token = "0x40066E0")]
		public const short BirdBlue = 297;

		[global::Cpp2ILInjected.Token(Token = "0x40066E1")]
		public const short BirdRed = 298;

		[global::Cpp2ILInjected.Token(Token = "0x40066E2")]
		public const short Squirrel = 299;

		[global::Cpp2ILInjected.Token(Token = "0x40066E3")]
		public const short Mouse = 300;

		[global::Cpp2ILInjected.Token(Token = "0x40066E4")]
		public const short Raven = 301;

		[global::Cpp2ILInjected.Token(Token = "0x40066E5")]
		public const short SlimeMasked = 302;

		[global::Cpp2ILInjected.Token(Token = "0x40066E6")]
		public const short BunnySlimed = 303;

		[global::Cpp2ILInjected.Token(Token = "0x40066E7")]
		public const short HoppinJack = 304;

		[global::Cpp2ILInjected.Token(Token = "0x40066E8")]
		public const short Scarecrow1 = 305;

		[global::Cpp2ILInjected.Token(Token = "0x40066E9")]
		public const short Scarecrow2 = 306;

		[global::Cpp2ILInjected.Token(Token = "0x40066EA")]
		public const short Scarecrow3 = 307;

		[global::Cpp2ILInjected.Token(Token = "0x40066EB")]
		public const short Scarecrow4 = 308;

		[global::Cpp2ILInjected.Token(Token = "0x40066EC")]
		public const short Scarecrow5 = 309;

		[global::Cpp2ILInjected.Token(Token = "0x40066ED")]
		public const short Scarecrow6 = 310;

		[global::Cpp2ILInjected.Token(Token = "0x40066EE")]
		public const short Scarecrow7 = 311;

		[global::Cpp2ILInjected.Token(Token = "0x40066EF")]
		public const short Scarecrow8 = 312;

		[global::Cpp2ILInjected.Token(Token = "0x40066F0")]
		public const short Scarecrow9 = 313;

		[global::Cpp2ILInjected.Token(Token = "0x40066F1")]
		public const short Scarecrow10 = 314;

		[global::Cpp2ILInjected.Token(Token = "0x40066F2")]
		public const short HeadlessHorseman = 315;

		[global::Cpp2ILInjected.Token(Token = "0x40066F3")]
		public const short Ghost = 316;

		[global::Cpp2ILInjected.Token(Token = "0x40066F4")]
		public const short DemonEyeOwl = 317;

		[global::Cpp2ILInjected.Token(Token = "0x40066F5")]
		public const short DemonEyeSpaceship = 318;

		[global::Cpp2ILInjected.Token(Token = "0x40066F6")]
		public const short ZombieDoctor = 319;

		[global::Cpp2ILInjected.Token(Token = "0x40066F7")]
		public const short ZombieSuperman = 320;

		[global::Cpp2ILInjected.Token(Token = "0x40066F8")]
		public const short ZombiePixie = 321;

		[global::Cpp2ILInjected.Token(Token = "0x40066F9")]
		public const short SkeletonTopHat = 322;

		[global::Cpp2ILInjected.Token(Token = "0x40066FA")]
		public const short SkeletonAstonaut = 323;

		[global::Cpp2ILInjected.Token(Token = "0x40066FB")]
		public const short SkeletonAlien = 324;

		[global::Cpp2ILInjected.Token(Token = "0x40066FC")]
		public const short MourningWood = 325;

		[global::Cpp2ILInjected.Token(Token = "0x40066FD")]
		public const short Splinterling = 326;

		[global::Cpp2ILInjected.Token(Token = "0x40066FE")]
		public const short Pumpking = 327;

		[global::Cpp2ILInjected.Token(Token = "0x40066FF")]
		public const short PumpkingBlade = 328;

		[global::Cpp2ILInjected.Token(Token = "0x4006700")]
		public const short Hellhound = 329;

		[global::Cpp2ILInjected.Token(Token = "0x4006701")]
		public const short Poltergeist = 330;

		[global::Cpp2ILInjected.Token(Token = "0x4006702")]
		public const short ZombieXmas = 331;

		[global::Cpp2ILInjected.Token(Token = "0x4006703")]
		public const short ZombieSweater = 332;

		[global::Cpp2ILInjected.Token(Token = "0x4006704")]
		public const short SlimeRibbonWhite = 333;

		[global::Cpp2ILInjected.Token(Token = "0x4006705")]
		public const short SlimeRibbonYellow = 334;

		[global::Cpp2ILInjected.Token(Token = "0x4006706")]
		public const short SlimeRibbonGreen = 335;

		[global::Cpp2ILInjected.Token(Token = "0x4006707")]
		public const short SlimeRibbonRed = 336;

		[global::Cpp2ILInjected.Token(Token = "0x4006708")]
		public const short BunnyXmas = 337;

		[global::Cpp2ILInjected.Token(Token = "0x4006709")]
		public const short ZombieElf = 338;

		[global::Cpp2ILInjected.Token(Token = "0x400670A")]
		public const short ZombieElfBeard = 339;

		[global::Cpp2ILInjected.Token(Token = "0x400670B")]
		public const short ZombieElfGirl = 340;

		[global::Cpp2ILInjected.Token(Token = "0x400670C")]
		public const short PresentMimic = 341;

		[global::Cpp2ILInjected.Token(Token = "0x400670D")]
		public const short GingerbreadMan = 342;

		[global::Cpp2ILInjected.Token(Token = "0x400670E")]
		public const short Yeti = 343;

		[global::Cpp2ILInjected.Token(Token = "0x400670F")]
		public const short Everscream = 344;

		[global::Cpp2ILInjected.Token(Token = "0x4006710")]
		public const short IceQueen = 345;

		[global::Cpp2ILInjected.Token(Token = "0x4006711")]
		public const short SantaNK1 = 346;

		[global::Cpp2ILInjected.Token(Token = "0x4006712")]
		public const short ElfCopter = 347;

		[global::Cpp2ILInjected.Token(Token = "0x4006713")]
		public const short Nutcracker = 348;

		[global::Cpp2ILInjected.Token(Token = "0x4006714")]
		public const short NutcrackerSpinning = 349;

		[global::Cpp2ILInjected.Token(Token = "0x4006715")]
		public const short ElfArcher = 350;

		[global::Cpp2ILInjected.Token(Token = "0x4006716")]
		public const short Krampus = 351;

		[global::Cpp2ILInjected.Token(Token = "0x4006717")]
		public const short Flocko = 352;

		[global::Cpp2ILInjected.Token(Token = "0x4006718")]
		public const short Stylist = 353;

		[global::Cpp2ILInjected.Token(Token = "0x4006719")]
		public const short WebbedStylist = 354;

		[global::Cpp2ILInjected.Token(Token = "0x400671A")]
		public const short Firefly = 355;

		[global::Cpp2ILInjected.Token(Token = "0x400671B")]
		public const short Butterfly = 356;

		[global::Cpp2ILInjected.Token(Token = "0x400671C")]
		public const short Worm = 357;

		[global::Cpp2ILInjected.Token(Token = "0x400671D")]
		public const short LightningBug = 358;

		[global::Cpp2ILInjected.Token(Token = "0x400671E")]
		public const short Snail = 359;

		[global::Cpp2ILInjected.Token(Token = "0x400671F")]
		public const short GlowingSnail = 360;

		[global::Cpp2ILInjected.Token(Token = "0x4006720")]
		public const short Frog = 361;

		[global::Cpp2ILInjected.Token(Token = "0x4006721")]
		public const short Duck = 362;

		[global::Cpp2ILInjected.Token(Token = "0x4006722")]
		public const short Duck2 = 363;

		[global::Cpp2ILInjected.Token(Token = "0x4006723")]
		public const short DuckWhite = 364;

		[global::Cpp2ILInjected.Token(Token = "0x4006724")]
		public const short DuckWhite2 = 365;

		[global::Cpp2ILInjected.Token(Token = "0x4006725")]
		public const short ScorpionBlack = 366;

		[global::Cpp2ILInjected.Token(Token = "0x4006726")]
		public const short Scorpion = 367;

		[global::Cpp2ILInjected.Token(Token = "0x4006727")]
		public const short TravellingMerchant = 368;

		[global::Cpp2ILInjected.Token(Token = "0x4006728")]
		public const short Angler = 369;

		[global::Cpp2ILInjected.Token(Token = "0x4006729")]
		public const short DukeFishron = 370;

		[global::Cpp2ILInjected.Token(Token = "0x400672A")]
		public const short DetonatingBubble = 371;

		[global::Cpp2ILInjected.Token(Token = "0x400672B")]
		public const short Sharkron = 372;

		[global::Cpp2ILInjected.Token(Token = "0x400672C")]
		public const short Sharkron2 = 373;

		[global::Cpp2ILInjected.Token(Token = "0x400672D")]
		public const short TruffleWorm = 374;

		[global::Cpp2ILInjected.Token(Token = "0x400672E")]
		public const short TruffleWormDigger = 375;

		[global::Cpp2ILInjected.Token(Token = "0x400672F")]
		public const short SleepingAngler = 376;

		[global::Cpp2ILInjected.Token(Token = "0x4006730")]
		public const short Grasshopper = 377;

		[global::Cpp2ILInjected.Token(Token = "0x4006731")]
		public const short ChatteringTeethBomb = 378;

		[global::Cpp2ILInjected.Token(Token = "0x4006732")]
		public const short CultistArcherBlue = 379;

		[global::Cpp2ILInjected.Token(Token = "0x4006733")]
		public const short CultistArcherWhite = 380;

		[global::Cpp2ILInjected.Token(Token = "0x4006734")]
		public const short BrainScrambler = 381;

		[global::Cpp2ILInjected.Token(Token = "0x4006735")]
		public const short RayGunner = 382;

		[global::Cpp2ILInjected.Token(Token = "0x4006736")]
		public const short MartianOfficer = 383;

		[global::Cpp2ILInjected.Token(Token = "0x4006737")]
		public const short ForceBubble = 384;

		[global::Cpp2ILInjected.Token(Token = "0x4006738")]
		public const short GrayGrunt = 385;

		[global::Cpp2ILInjected.Token(Token = "0x4006739")]
		public const short MartianEngineer = 386;

		[global::Cpp2ILInjected.Token(Token = "0x400673A")]
		public const short MartianTurret = 387;

		[global::Cpp2ILInjected.Token(Token = "0x400673B")]
		public const short MartianDrone = 388;

		[global::Cpp2ILInjected.Token(Token = "0x400673C")]
		public const short GigaZapper = 389;

		[global::Cpp2ILInjected.Token(Token = "0x400673D")]
		public const short ScutlixRider = 390;

		[global::Cpp2ILInjected.Token(Token = "0x400673E")]
		public const short Scutlix = 391;

		[global::Cpp2ILInjected.Token(Token = "0x400673F")]
		public const short MartianSaucer = 392;

		[global::Cpp2ILInjected.Token(Token = "0x4006740")]
		public const short MartianSaucerTurret = 393;

		[global::Cpp2ILInjected.Token(Token = "0x4006741")]
		public const short MartianSaucerCannon = 394;

		[global::Cpp2ILInjected.Token(Token = "0x4006742")]
		public const short MartianSaucerCore = 395;

		[global::Cpp2ILInjected.Token(Token = "0x4006743")]
		public const short MoonLordHead = 396;

		[global::Cpp2ILInjected.Token(Token = "0x4006744")]
		public const short MoonLordHand = 397;

		[global::Cpp2ILInjected.Token(Token = "0x4006745")]
		public const short MoonLordCore = 398;

		[global::Cpp2ILInjected.Token(Token = "0x4006746")]
		public const short MartianProbe = 399;

		[global::Cpp2ILInjected.Token(Token = "0x4006747")]
		public const short MoonLordFreeEye = 400;

		[global::Cpp2ILInjected.Token(Token = "0x4006748")]
		public const short MoonLordLeechBlob = 401;

		[global::Cpp2ILInjected.Token(Token = "0x4006749")]
		public const short StardustWormHead = 402;

		[global::Cpp2ILInjected.Token(Token = "0x400674A")]
		public const short StardustWormBody = 403;

		[global::Cpp2ILInjected.Token(Token = "0x400674B")]
		public const short StardustWormTail = 404;

		[global::Cpp2ILInjected.Token(Token = "0x400674C")]
		public const short StardustCellBig = 405;

		[global::Cpp2ILInjected.Token(Token = "0x400674D")]
		public const short StardustCellSmall = 406;

		[global::Cpp2ILInjected.Token(Token = "0x400674E")]
		public const short StardustJellyfishBig = 407;

		[global::Cpp2ILInjected.Token(Token = "0x400674F")]
		public const short StardustJellyfishSmall = 408;

		[global::Cpp2ILInjected.Token(Token = "0x4006750")]
		public const short StardustSpiderBig = 409;

		[global::Cpp2ILInjected.Token(Token = "0x4006751")]
		public const short StardustSpiderSmall = 410;

		[global::Cpp2ILInjected.Token(Token = "0x4006752")]
		public const short StardustSoldier = 411;

		[global::Cpp2ILInjected.Token(Token = "0x4006753")]
		public const short SolarCrawltipedeHead = 412;

		[global::Cpp2ILInjected.Token(Token = "0x4006754")]
		public const short SolarCrawltipedeBody = 413;

		[global::Cpp2ILInjected.Token(Token = "0x4006755")]
		public const short SolarCrawltipedeTail = 414;

		[global::Cpp2ILInjected.Token(Token = "0x4006756")]
		public const short SolarDrakomire = 415;

		[global::Cpp2ILInjected.Token(Token = "0x4006757")]
		public const short SolarDrakomireRider = 416;

		[global::Cpp2ILInjected.Token(Token = "0x4006758")]
		public const short SolarSroller = 417;

		[global::Cpp2ILInjected.Token(Token = "0x4006759")]
		public const short SolarCorite = 418;

		[global::Cpp2ILInjected.Token(Token = "0x400675A")]
		public const short SolarSolenian = 419;

		[global::Cpp2ILInjected.Token(Token = "0x400675B")]
		public const short NebulaBrain = 420;

		[global::Cpp2ILInjected.Token(Token = "0x400675C")]
		public const short NebulaHeadcrab = 421;

		[global::Cpp2ILInjected.Token(Token = "0x400675D")]
		public const short NebulaBeast = 423;

		[global::Cpp2ILInjected.Token(Token = "0x400675E")]
		public const short NebulaSoldier = 424;

		[global::Cpp2ILInjected.Token(Token = "0x400675F")]
		public const short VortexRifleman = 425;

		[global::Cpp2ILInjected.Token(Token = "0x4006760")]
		public const short VortexHornetQueen = 426;

		[global::Cpp2ILInjected.Token(Token = "0x4006761")]
		public const short VortexHornet = 427;

		[global::Cpp2ILInjected.Token(Token = "0x4006762")]
		public const short VortexLarva = 428;

		[global::Cpp2ILInjected.Token(Token = "0x4006763")]
		public const short VortexSoldier = 429;

		[global::Cpp2ILInjected.Token(Token = "0x4006764")]
		public const short ArmedZombie = 430;

		[global::Cpp2ILInjected.Token(Token = "0x4006765")]
		public const short ArmedZombieEskimo = 431;

		[global::Cpp2ILInjected.Token(Token = "0x4006766")]
		public const short ArmedZombiePincussion = 432;

		[global::Cpp2ILInjected.Token(Token = "0x4006767")]
		public const short ArmedZombieSlimed = 433;

		[global::Cpp2ILInjected.Token(Token = "0x4006768")]
		public const short ArmedZombieSwamp = 434;

		[global::Cpp2ILInjected.Token(Token = "0x4006769")]
		public const short ArmedZombieTwiggy = 435;

		[global::Cpp2ILInjected.Token(Token = "0x400676A")]
		public const short ArmedZombieCenx = 436;

		[global::Cpp2ILInjected.Token(Token = "0x400676B")]
		public const short CultistTablet = 437;

		[global::Cpp2ILInjected.Token(Token = "0x400676C")]
		public const short CultistDevote = 438;

		[global::Cpp2ILInjected.Token(Token = "0x400676D")]
		public const short CultistBoss = 439;

		[global::Cpp2ILInjected.Token(Token = "0x400676E")]
		public const short CultistBossClone = 440;

		[global::Cpp2ILInjected.Token(Token = "0x400676F")]
		public const short GoldBird = 442;

		[global::Cpp2ILInjected.Token(Token = "0x4006770")]
		public const short GoldBunny = 443;

		[global::Cpp2ILInjected.Token(Token = "0x4006771")]
		public const short GoldButterfly = 444;

		[global::Cpp2ILInjected.Token(Token = "0x4006772")]
		public const short GoldFrog = 445;

		[global::Cpp2ILInjected.Token(Token = "0x4006773")]
		public const short GoldGrasshopper = 446;

		[global::Cpp2ILInjected.Token(Token = "0x4006774")]
		public const short GoldMouse = 447;

		[global::Cpp2ILInjected.Token(Token = "0x4006775")]
		public const short GoldWorm = 448;

		[global::Cpp2ILInjected.Token(Token = "0x4006776")]
		public const short BoneThrowingSkeleton = 449;

		[global::Cpp2ILInjected.Token(Token = "0x4006777")]
		public const short BoneThrowingSkeleton2 = 450;

		[global::Cpp2ILInjected.Token(Token = "0x4006778")]
		public const short BoneThrowingSkeleton3 = 451;

		[global::Cpp2ILInjected.Token(Token = "0x4006779")]
		public const short BoneThrowingSkeleton4 = 452;

		[global::Cpp2ILInjected.Token(Token = "0x400677A")]
		public const short SkeletonMerchant = 453;

		[global::Cpp2ILInjected.Token(Token = "0x400677B")]
		public const short CultistDragonHead = 454;

		[global::Cpp2ILInjected.Token(Token = "0x400677C")]
		public const short CultistDragonBody1 = 455;

		[global::Cpp2ILInjected.Token(Token = "0x400677D")]
		public const short CultistDragonBody2 = 456;

		[global::Cpp2ILInjected.Token(Token = "0x400677E")]
		public const short CultistDragonBody3 = 457;

		[global::Cpp2ILInjected.Token(Token = "0x400677F")]
		public const short CultistDragonBody4 = 458;

		[global::Cpp2ILInjected.Token(Token = "0x4006780")]
		public const short CultistDragonTail = 459;

		[global::Cpp2ILInjected.Token(Token = "0x4006781")]
		public const short Butcher = 460;

		[global::Cpp2ILInjected.Token(Token = "0x4006782")]
		public const short CreatureFromTheDeep = 461;

		[global::Cpp2ILInjected.Token(Token = "0x4006783")]
		public const short Fritz = 462;

		[global::Cpp2ILInjected.Token(Token = "0x4006784")]
		public const short Nailhead = 463;

		[global::Cpp2ILInjected.Token(Token = "0x4006785")]
		public const short CrimsonBunny = 464;

		[global::Cpp2ILInjected.Token(Token = "0x4006786")]
		public const short CrimsonGoldfish = 465;

		[global::Cpp2ILInjected.Token(Token = "0x4006787")]
		public const short Psycho = 466;

		[global::Cpp2ILInjected.Token(Token = "0x4006788")]
		public const short DeadlySphere = 467;

		[global::Cpp2ILInjected.Token(Token = "0x4006789")]
		public const short DrManFly = 468;

		[global::Cpp2ILInjected.Token(Token = "0x400678A")]
		public const short ThePossessed = 469;

		[global::Cpp2ILInjected.Token(Token = "0x400678B")]
		public const short CrimsonPenguin = 470;

		[global::Cpp2ILInjected.Token(Token = "0x400678C")]
		public const short GoblinSummoner = 471;

		[global::Cpp2ILInjected.Token(Token = "0x400678D")]
		public const short ShadowFlameApparition = 472;

		[global::Cpp2ILInjected.Token(Token = "0x400678E")]
		public const short BigMimicCorruption = 473;

		[global::Cpp2ILInjected.Token(Token = "0x400678F")]
		public const short BigMimicCrimson = 474;

		[global::Cpp2ILInjected.Token(Token = "0x4006790")]
		public const short BigMimicHallow = 475;

		[global::Cpp2ILInjected.Token(Token = "0x4006791")]
		public const short BigMimicJungle = 476;

		[global::Cpp2ILInjected.Token(Token = "0x4006792")]
		public const short Mothron = 477;

		[global::Cpp2ILInjected.Token(Token = "0x4006793")]
		public const short MothronEgg = 478;

		[global::Cpp2ILInjected.Token(Token = "0x4006794")]
		public const short MothronSpawn = 479;

		[global::Cpp2ILInjected.Token(Token = "0x4006795")]
		public const short Medusa = 480;

		[global::Cpp2ILInjected.Token(Token = "0x4006796")]
		public const short GreekSkeleton = 481;

		[global::Cpp2ILInjected.Token(Token = "0x4006797")]
		public const short GraniteGolem = 482;

		[global::Cpp2ILInjected.Token(Token = "0x4006798")]
		public const short GraniteFlyer = 483;

		[global::Cpp2ILInjected.Token(Token = "0x4006799")]
		public const short EnchantedNightcrawler = 484;

		[global::Cpp2ILInjected.Token(Token = "0x400679A")]
		public const short Grubby = 485;

		[global::Cpp2ILInjected.Token(Token = "0x400679B")]
		public const short Sluggy = 486;

		[global::Cpp2ILInjected.Token(Token = "0x400679C")]
		public const short Buggy = 487;

		[global::Cpp2ILInjected.Token(Token = "0x400679D")]
		public const short TargetDummy = 488;

		[global::Cpp2ILInjected.Token(Token = "0x400679E")]
		public const short BloodZombie = 489;

		[global::Cpp2ILInjected.Token(Token = "0x400679F")]
		public const short Drippler = 490;

		[global::Cpp2ILInjected.Token(Token = "0x40067A0")]
		public const short PirateShip = 491;

		[global::Cpp2ILInjected.Token(Token = "0x40067A1")]
		public const short PirateShipCannon = 492;

		[global::Cpp2ILInjected.Token(Token = "0x40067A2")]
		public const short LunarTowerStardust = 493;

		[global::Cpp2ILInjected.Token(Token = "0x40067A3")]
		public const short Crawdad = 494;

		[global::Cpp2ILInjected.Token(Token = "0x40067A4")]
		public const short Crawdad2 = 495;

		[global::Cpp2ILInjected.Token(Token = "0x40067A5")]
		public const short GiantShelly = 496;

		[global::Cpp2ILInjected.Token(Token = "0x40067A6")]
		public const short GiantShelly2 = 497;

		[global::Cpp2ILInjected.Token(Token = "0x40067A7")]
		public const short Salamander = 498;

		[global::Cpp2ILInjected.Token(Token = "0x40067A8")]
		public const short Salamander2 = 499;

		[global::Cpp2ILInjected.Token(Token = "0x40067A9")]
		public const short Salamander3 = 500;

		[global::Cpp2ILInjected.Token(Token = "0x40067AA")]
		public const short Salamander4 = 501;

		[global::Cpp2ILInjected.Token(Token = "0x40067AB")]
		public const short Salamander5 = 502;

		[global::Cpp2ILInjected.Token(Token = "0x40067AC")]
		public const short Salamander6 = 503;

		[global::Cpp2ILInjected.Token(Token = "0x40067AD")]
		public const short Salamander7 = 504;

		[global::Cpp2ILInjected.Token(Token = "0x40067AE")]
		public const short Salamander8 = 505;

		[global::Cpp2ILInjected.Token(Token = "0x40067AF")]
		public const short Salamander9 = 506;

		[global::Cpp2ILInjected.Token(Token = "0x40067B0")]
		public const short LunarTowerNebula = 507;

		[global::Cpp2ILInjected.Token(Token = "0x40067B1")]
		public const short LunarTowerVortex = 422;

		[global::Cpp2ILInjected.Token(Token = "0x40067B2")]
		public const short TaxCollector = 441;

		[global::Cpp2ILInjected.Token(Token = "0x40067B3")]
		public const short GiantWalkingAntlion = 508;

		[global::Cpp2ILInjected.Token(Token = "0x40067B4")]
		public const short GiantFlyingAntlion = 509;

		[global::Cpp2ILInjected.Token(Token = "0x40067B5")]
		public const short DuneSplicerHead = 510;

		[global::Cpp2ILInjected.Token(Token = "0x40067B6")]
		public const short DuneSplicerBody = 511;

		[global::Cpp2ILInjected.Token(Token = "0x40067B7")]
		public const short DuneSplicerTail = 512;

		[global::Cpp2ILInjected.Token(Token = "0x40067B8")]
		public const short TombCrawlerHead = 513;

		[global::Cpp2ILInjected.Token(Token = "0x40067B9")]
		public const short TombCrawlerBody = 514;

		[global::Cpp2ILInjected.Token(Token = "0x40067BA")]
		public const short TombCrawlerTail = 515;

		[global::Cpp2ILInjected.Token(Token = "0x40067BB")]
		public const short SolarFlare = 516;

		[global::Cpp2ILInjected.Token(Token = "0x40067BC")]
		public const short LunarTowerSolar = 517;

		[global::Cpp2ILInjected.Token(Token = "0x40067BD")]
		public const short SolarSpearman = 518;

		[global::Cpp2ILInjected.Token(Token = "0x40067BE")]
		public const short SolarGoop = 519;

		[global::Cpp2ILInjected.Token(Token = "0x40067BF")]
		public const short MartianWalker = 520;

		[global::Cpp2ILInjected.Token(Token = "0x40067C0")]
		public const short AncientCultistSquidhead = 521;

		[global::Cpp2ILInjected.Token(Token = "0x40067C1")]
		public const short AncientLight = 522;

		[global::Cpp2ILInjected.Token(Token = "0x40067C2")]
		public const short AncientDoom = 523;

		[global::Cpp2ILInjected.Token(Token = "0x40067C3")]
		public const short DesertGhoul = 524;

		[global::Cpp2ILInjected.Token(Token = "0x40067C4")]
		public const short DesertGhoulCorruption = 525;

		[global::Cpp2ILInjected.Token(Token = "0x40067C5")]
		public const short DesertGhoulCrimson = 526;

		[global::Cpp2ILInjected.Token(Token = "0x40067C6")]
		public const short DesertGhoulHallow = 527;

		[global::Cpp2ILInjected.Token(Token = "0x40067C7")]
		public const short DesertLamiaLight = 528;

		[global::Cpp2ILInjected.Token(Token = "0x40067C8")]
		public const short DesertLamiaDark = 529;

		[global::Cpp2ILInjected.Token(Token = "0x40067C9")]
		public const short DesertScorpionWalk = 530;

		[global::Cpp2ILInjected.Token(Token = "0x40067CA")]
		public const short DesertScorpionWall = 531;

		[global::Cpp2ILInjected.Token(Token = "0x40067CB")]
		public const short DesertBeast = 532;

		[global::Cpp2ILInjected.Token(Token = "0x40067CC")]
		public const short DesertDjinn = 533;

		[global::Cpp2ILInjected.Token(Token = "0x40067CD")]
		public const short DemonTaxCollector = 534;

		[global::Cpp2ILInjected.Token(Token = "0x40067CE")]
		public const short SlimeSpiked = 535;

		[global::Cpp2ILInjected.Token(Token = "0x40067CF")]
		public const short TheBride = 536;

		[global::Cpp2ILInjected.Token(Token = "0x40067D0")]
		public const short SandSlime = 537;

		[global::Cpp2ILInjected.Token(Token = "0x40067D1")]
		public const short SquirrelRed = 538;

		[global::Cpp2ILInjected.Token(Token = "0x40067D2")]
		public const short SquirrelGold = 539;

		[global::Cpp2ILInjected.Token(Token = "0x40067D3")]
		public const short PartyBunny = 540;

		[global::Cpp2ILInjected.Token(Token = "0x40067D4")]
		public const short SandElemental = 541;

		[global::Cpp2ILInjected.Token(Token = "0x40067D5")]
		public const short SandShark = 542;

		[global::Cpp2ILInjected.Token(Token = "0x40067D6")]
		public const short SandsharkCorrupt = 543;

		[global::Cpp2ILInjected.Token(Token = "0x40067D7")]
		public const short SandsharkCrimson = 544;

		[global::Cpp2ILInjected.Token(Token = "0x40067D8")]
		public const short SandsharkHallow = 545;

		[global::Cpp2ILInjected.Token(Token = "0x40067D9")]
		public const short Tumbleweed = 546;

		[global::Cpp2ILInjected.Token(Token = "0x40067DA")]
		public const short DD2AttackerTest = 547;

		[global::Cpp2ILInjected.Token(Token = "0x40067DB")]
		public const short DD2EterniaCrystal = 548;

		[global::Cpp2ILInjected.Token(Token = "0x40067DC")]
		public const short DD2LanePortal = 549;

		[global::Cpp2ILInjected.Token(Token = "0x40067DD")]
		public const short DD2Bartender = 550;

		[global::Cpp2ILInjected.Token(Token = "0x40067DE")]
		public const short DD2Betsy = 551;

		[global::Cpp2ILInjected.Token(Token = "0x40067DF")]
		public const short DD2GoblinT1 = 552;

		[global::Cpp2ILInjected.Token(Token = "0x40067E0")]
		public const short DD2GoblinT2 = 553;

		[global::Cpp2ILInjected.Token(Token = "0x40067E1")]
		public const short DD2GoblinT3 = 554;

		[global::Cpp2ILInjected.Token(Token = "0x40067E2")]
		public const short DD2GoblinBomberT1 = 555;

		[global::Cpp2ILInjected.Token(Token = "0x40067E3")]
		public const short DD2GoblinBomberT2 = 556;

		[global::Cpp2ILInjected.Token(Token = "0x40067E4")]
		public const short DD2GoblinBomberT3 = 557;

		[global::Cpp2ILInjected.Token(Token = "0x40067E5")]
		public const short DD2WyvernT1 = 558;

		[global::Cpp2ILInjected.Token(Token = "0x40067E6")]
		public const short DD2WyvernT2 = 559;

		[global::Cpp2ILInjected.Token(Token = "0x40067E7")]
		public const short DD2WyvernT3 = 560;

		[global::Cpp2ILInjected.Token(Token = "0x40067E8")]
		public const short DD2JavelinstT1 = 561;

		[global::Cpp2ILInjected.Token(Token = "0x40067E9")]
		public const short DD2JavelinstT2 = 562;

		[global::Cpp2ILInjected.Token(Token = "0x40067EA")]
		public const short DD2JavelinstT3 = 563;

		[global::Cpp2ILInjected.Token(Token = "0x40067EB")]
		public const short DD2DarkMageT1 = 564;

		[global::Cpp2ILInjected.Token(Token = "0x40067EC")]
		public const short DD2DarkMageT3 = 565;

		[global::Cpp2ILInjected.Token(Token = "0x40067ED")]
		public const short DD2SkeletonT1 = 566;

		[global::Cpp2ILInjected.Token(Token = "0x40067EE")]
		public const short DD2SkeletonT3 = 567;

		[global::Cpp2ILInjected.Token(Token = "0x40067EF")]
		public const short DD2WitherBeastT2 = 568;

		[global::Cpp2ILInjected.Token(Token = "0x40067F0")]
		public const short DD2WitherBeastT3 = 569;

		[global::Cpp2ILInjected.Token(Token = "0x40067F1")]
		public const short DD2DrakinT2 = 570;

		[global::Cpp2ILInjected.Token(Token = "0x40067F2")]
		public const short DD2DrakinT3 = 571;

		[global::Cpp2ILInjected.Token(Token = "0x40067F3")]
		public const short DD2KoboldWalkerT2 = 572;

		[global::Cpp2ILInjected.Token(Token = "0x40067F4")]
		public const short DD2KoboldWalkerT3 = 573;

		[global::Cpp2ILInjected.Token(Token = "0x40067F5")]
		public const short DD2KoboldFlyerT2 = 574;

		[global::Cpp2ILInjected.Token(Token = "0x40067F6")]
		public const short DD2KoboldFlyerT3 = 575;

		[global::Cpp2ILInjected.Token(Token = "0x40067F7")]
		public const short DD2OgreT2 = 576;

		[global::Cpp2ILInjected.Token(Token = "0x40067F8")]
		public const short DD2OgreT3 = 577;

		[global::Cpp2ILInjected.Token(Token = "0x40067F9")]
		public const short DD2LightningBugT3 = 578;

		[global::Cpp2ILInjected.Token(Token = "0x40067FA")]
		public const short BartenderUnconscious = 579;

		[global::Cpp2ILInjected.Token(Token = "0x40067FB")]
		public const short WalkingAntlion = 580;

		[global::Cpp2ILInjected.Token(Token = "0x40067FC")]
		public const short FlyingAntlion = 581;

		[global::Cpp2ILInjected.Token(Token = "0x40067FD")]
		public const short LarvaeAntlion = 582;

		[global::Cpp2ILInjected.Token(Token = "0x40067FE")]
		public const short FairyCritterPink = 583;

		[global::Cpp2ILInjected.Token(Token = "0x40067FF")]
		public const short FairyCritterGreen = 584;

		[global::Cpp2ILInjected.Token(Token = "0x4006800")]
		public const short FairyCritterBlue = 585;

		[global::Cpp2ILInjected.Token(Token = "0x4006801")]
		public const short ZombieMerman = 586;

		[global::Cpp2ILInjected.Token(Token = "0x4006802")]
		public const short EyeballFlyingFish = 587;

		[global::Cpp2ILInjected.Token(Token = "0x4006803")]
		public const short Golfer = 588;

		[global::Cpp2ILInjected.Token(Token = "0x4006804")]
		public const short GolferRescue = 589;

		[global::Cpp2ILInjected.Token(Token = "0x4006805")]
		public const short TorchZombie = 590;

		[global::Cpp2ILInjected.Token(Token = "0x4006806")]
		public const short ArmedTorchZombie = 591;

		[global::Cpp2ILInjected.Token(Token = "0x4006807")]
		public const short GoldGoldfish = 592;

		[global::Cpp2ILInjected.Token(Token = "0x4006808")]
		public const short GoldGoldfishWalker = 593;

		[global::Cpp2ILInjected.Token(Token = "0x4006809")]
		public const short WindyBalloon = 594;

		[global::Cpp2ILInjected.Token(Token = "0x400680A")]
		public const short BlackDragonfly = 595;

		[global::Cpp2ILInjected.Token(Token = "0x400680B")]
		public const short BlueDragonfly = 596;

		[global::Cpp2ILInjected.Token(Token = "0x400680C")]
		public const short GreenDragonfly = 597;

		[global::Cpp2ILInjected.Token(Token = "0x400680D")]
		public const short OrangeDragonfly = 598;

		[global::Cpp2ILInjected.Token(Token = "0x400680E")]
		public const short RedDragonfly = 599;

		[global::Cpp2ILInjected.Token(Token = "0x400680F")]
		public const short YellowDragonfly = 600;

		[global::Cpp2ILInjected.Token(Token = "0x4006810")]
		public const short GoldDragonfly = 601;

		[global::Cpp2ILInjected.Token(Token = "0x4006811")]
		public const short Seagull = 602;

		[global::Cpp2ILInjected.Token(Token = "0x4006812")]
		public const short Seagull2 = 603;

		[global::Cpp2ILInjected.Token(Token = "0x4006813")]
		public const short LadyBug = 604;

		[global::Cpp2ILInjected.Token(Token = "0x4006814")]
		public const short GoldLadyBug = 605;

		[global::Cpp2ILInjected.Token(Token = "0x4006815")]
		public const short Maggot = 606;

		[global::Cpp2ILInjected.Token(Token = "0x4006816")]
		public const short Pupfish = 607;

		[global::Cpp2ILInjected.Token(Token = "0x4006817")]
		public const short Grebe = 608;

		[global::Cpp2ILInjected.Token(Token = "0x4006818")]
		public const short Grebe2 = 609;

		[global::Cpp2ILInjected.Token(Token = "0x4006819")]
		public const short Rat = 610;

		[global::Cpp2ILInjected.Token(Token = "0x400681A")]
		public const short Owl = 611;

		[global::Cpp2ILInjected.Token(Token = "0x400681B")]
		public const short WaterStrider = 612;

		[global::Cpp2ILInjected.Token(Token = "0x400681C")]
		public const short GoldWaterStrider = 613;

		[global::Cpp2ILInjected.Token(Token = "0x400681D")]
		public const short ExplosiveBunny = 614;

		[global::Cpp2ILInjected.Token(Token = "0x400681E")]
		public const short Dolphin = 615;

		[global::Cpp2ILInjected.Token(Token = "0x400681F")]
		public const short Turtle = 616;

		[global::Cpp2ILInjected.Token(Token = "0x4006820")]
		public const short TurtleJungle = 617;

		[global::Cpp2ILInjected.Token(Token = "0x4006821")]
		public const short BloodNautilus = 618;

		[global::Cpp2ILInjected.Token(Token = "0x4006822")]
		public const short BloodSquid = 619;

		[global::Cpp2ILInjected.Token(Token = "0x4006823")]
		public const short GoblinShark = 620;

		[global::Cpp2ILInjected.Token(Token = "0x4006824")]
		public const short BloodEelHead = 621;

		[global::Cpp2ILInjected.Token(Token = "0x4006825")]
		public const short BloodEelBody = 622;

		[global::Cpp2ILInjected.Token(Token = "0x4006826")]
		public const short BloodEelTail = 623;

		[global::Cpp2ILInjected.Token(Token = "0x4006827")]
		public const short Gnome = 624;

		[global::Cpp2ILInjected.Token(Token = "0x4006828")]
		public const short SeaTurtle = 625;

		[global::Cpp2ILInjected.Token(Token = "0x4006829")]
		public const short Seahorse = 626;

		[global::Cpp2ILInjected.Token(Token = "0x400682A")]
		public const short GoldSeahorse = 627;

		[global::Cpp2ILInjected.Token(Token = "0x400682B")]
		public const short Dandelion = 628;

		[global::Cpp2ILInjected.Token(Token = "0x400682C")]
		public const short IceMimic = 629;

		[global::Cpp2ILInjected.Token(Token = "0x400682D")]
		public const short BloodMummy = 630;

		[global::Cpp2ILInjected.Token(Token = "0x400682E")]
		public const short RockGolem = 631;

		[global::Cpp2ILInjected.Token(Token = "0x400682F")]
		public const short MaggotZombie = 632;

		[global::Cpp2ILInjected.Token(Token = "0x4006830")]
		public const short BestiaryGirl = 633;

		[global::Cpp2ILInjected.Token(Token = "0x4006831")]
		public const short SporeBat = 634;

		[global::Cpp2ILInjected.Token(Token = "0x4006832")]
		public const short SporeSkeleton = 635;

		[global::Cpp2ILInjected.Token(Token = "0x4006833")]
		public const short HallowBoss = 636;

		[global::Cpp2ILInjected.Token(Token = "0x4006834")]
		public const short TownCat = 637;

		[global::Cpp2ILInjected.Token(Token = "0x4006835")]
		public const short TownDog = 638;

		[global::Cpp2ILInjected.Token(Token = "0x4006836")]
		public const short GemSquirrelAmethyst = 639;

		[global::Cpp2ILInjected.Token(Token = "0x4006837")]
		public const short GemSquirrelTopaz = 640;

		[global::Cpp2ILInjected.Token(Token = "0x4006838")]
		public const short GemSquirrelSapphire = 641;

		[global::Cpp2ILInjected.Token(Token = "0x4006839")]
		public const short GemSquirrelEmerald = 642;

		[global::Cpp2ILInjected.Token(Token = "0x400683A")]
		public const short GemSquirrelRuby = 643;

		[global::Cpp2ILInjected.Token(Token = "0x400683B")]
		public const short GemSquirrelDiamond = 644;

		[global::Cpp2ILInjected.Token(Token = "0x400683C")]
		public const short GemSquirrelAmber = 645;

		[global::Cpp2ILInjected.Token(Token = "0x400683D")]
		public const short GemBunnyAmethyst = 646;

		[global::Cpp2ILInjected.Token(Token = "0x400683E")]
		public const short GemBunnyTopaz = 647;

		[global::Cpp2ILInjected.Token(Token = "0x400683F")]
		public const short GemBunnySapphire = 648;

		[global::Cpp2ILInjected.Token(Token = "0x4006840")]
		public const short GemBunnyEmerald = 649;

		[global::Cpp2ILInjected.Token(Token = "0x4006841")]
		public const short GemBunnyRuby = 650;

		[global::Cpp2ILInjected.Token(Token = "0x4006842")]
		public const short GemBunnyDiamond = 651;

		[global::Cpp2ILInjected.Token(Token = "0x4006843")]
		public const short GemBunnyAmber = 652;

		[global::Cpp2ILInjected.Token(Token = "0x4006844")]
		public const short HellButterfly = 653;

		[global::Cpp2ILInjected.Token(Token = "0x4006845")]
		public const short Lavafly = 654;

		[global::Cpp2ILInjected.Token(Token = "0x4006846")]
		public const short MagmaSnail = 655;

		[global::Cpp2ILInjected.Token(Token = "0x4006847")]
		public const short TownBunny = 656;

		[global::Cpp2ILInjected.Token(Token = "0x4006848")]
		public const short QueenSlimeBoss = 657;

		[global::Cpp2ILInjected.Token(Token = "0x4006849")]
		public const short QueenSlimeMinionBlue = 658;

		[global::Cpp2ILInjected.Token(Token = "0x400684A")]
		public const short QueenSlimeMinionPink = 659;

		[global::Cpp2ILInjected.Token(Token = "0x400684B")]
		public const short QueenSlimeMinionPurple = 660;

		[global::Cpp2ILInjected.Token(Token = "0x400684C")]
		public const short EmpressButterfly = 661;

		[global::Cpp2ILInjected.Token(Token = "0x400684D")]
		public const short PirateGhost = 662;

		[global::Cpp2ILInjected.Token(Token = "0x400684E")]
		public const short Princess = 663;

		[global::Cpp2ILInjected.Token(Token = "0x400684F")]
		public const short TorchGod = 664;

		[global::Cpp2ILInjected.Token(Token = "0x4006850")]
		public const short ChaosBallTim = 665;

		[global::Cpp2ILInjected.Token(Token = "0x4006851")]
		public const short VileSpitEaterOfWorlds = 666;

		[global::Cpp2ILInjected.Token(Token = "0x4006852")]
		public const short GoldenSlime = 667;

		[global::Cpp2ILInjected.Token(Token = "0x4006853")]
		public const short Deerclops = 668;

		[global::Cpp2ILInjected.Token(Token = "0x4006854")]
		public const short Stinkbug = 669;

		[global::Cpp2ILInjected.Token(Token = "0x4006855")]
		public const short TownSlimeBlue = 670;

		[global::Cpp2ILInjected.Token(Token = "0x4006856")]
		public const short ScarletMacaw = 671;

		[global::Cpp2ILInjected.Token(Token = "0x4006857")]
		public const short BlueMacaw = 672;

		[global::Cpp2ILInjected.Token(Token = "0x4006858")]
		public const short Toucan = 673;

		[global::Cpp2ILInjected.Token(Token = "0x4006859")]
		public const short YellowCockatiel = 674;

		[global::Cpp2ILInjected.Token(Token = "0x400685A")]
		public const short GrayCockatiel = 675;

		[global::Cpp2ILInjected.Token(Token = "0x400685B")]
		public const short ShimmerSlime = 676;

		[global::Cpp2ILInjected.Token(Token = "0x400685C")]
		public const short Shimmerfly = 677;

		[global::Cpp2ILInjected.Token(Token = "0x400685D")]
		public const short TownSlimeGreen = 678;

		[global::Cpp2ILInjected.Token(Token = "0x400685E")]
		public const short TownSlimeOld = 679;

		[global::Cpp2ILInjected.Token(Token = "0x400685F")]
		public const short TownSlimePurple = 680;

		[global::Cpp2ILInjected.Token(Token = "0x4006860")]
		public const short TownSlimeRainbow = 681;

		[global::Cpp2ILInjected.Token(Token = "0x4006861")]
		public const short TownSlimeRed = 682;

		[global::Cpp2ILInjected.Token(Token = "0x4006862")]
		public const short TownSlimeYellow = 683;

		[global::Cpp2ILInjected.Token(Token = "0x4006863")]
		public const short TownSlimeCopper = 684;

		[global::Cpp2ILInjected.Token(Token = "0x4006864")]
		public const short BoundTownSlimeOld = 685;

		[global::Cpp2ILInjected.Token(Token = "0x4006865")]
		public const short BoundTownSlimePurple = 686;

		[global::Cpp2ILInjected.Token(Token = "0x4006866")]
		public const short BoundTownSlimeYellow = 687;

		[global::Cpp2ILInjected.Token(Token = "0x4006867")]
		public const short Count = 688;

		[global::Cpp2ILInjected.Token(Token = "0x4006868")]
		public static readonly IdDictionary Search;

		[global::Cpp2ILInjected.Token(Token = "0x20005E0")]
		public static class Sets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003567")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B2644", Offset = "0x13B2644", Length = "0x4A0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "GetRedigitEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "GetLeinforsEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "GetGroxEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCID.Sets.NPCBestiaryDrawModifiers)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffsetCreation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003568")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B2AE4", Offset = "0x13B2AE4", Length = "0xBE0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets.NPCBestiaryDrawModifiers), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCID.Sets.NPCBestiaryDrawModifiers)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetRedigitEntries()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003569")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B36C4", Offset = "0x13B36C4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetGroxEntries()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600356A")]
			[global::Cpp2ILInjected.Address(RVA = "0x13A1FD0", Offset = "0x13A1FD0", Length = "0x10674")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets.NPCBestiaryDrawModifiers), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(NPCID.Sets.NPCBestiaryDrawModifiers)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 683)]
			private static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> GetLeinforsEntries()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600356B")]
			[global::Cpp2ILInjected.Address(RVA = "0x13B372C", Offset = "0x13B372C", Length = "0xEE6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCID.Sets), Member = "NPCBestiaryDrawOffsetCreation", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
			{
				typeof(int),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCDebuffImmunityData), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int[])
			}, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int[])
			}, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(float),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(byte)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(Color) }, MemberParameters = new object[]
			{
				typeof(Color),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1351)]
			static Sets()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4006869")]
			public static SetFactory Factory;

			[global::Cpp2ILInjected.Token(Token = "0x400686A")]
			public static Dictionary<int, int> SpecialSpawningRules;

			[global::Cpp2ILInjected.Token(Token = "0x400686B")]
			public static Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers> NPCBestiaryDrawOffset;

			[global::Cpp2ILInjected.Token(Token = "0x400686C")]
			public static Dictionary<int, NPCDebuffImmunityData> DebuffImmunitySets;

			[global::Cpp2ILInjected.Token(Token = "0x400686D")]
			public static List<int> NormalGoldCritterBestiaryPriority;

			[global::Cpp2ILInjected.Token(Token = "0x400686E")]
			public static List<int> BossBestiaryPriority;

			[global::Cpp2ILInjected.Token(Token = "0x400686F")]
			public static List<int> TownNPCBestiaryPriority;

			[global::Cpp2ILInjected.Token(Token = "0x4006870")]
			public static bool[] DontDoHardmodeScaling;

			[global::Cpp2ILInjected.Token(Token = "0x4006871")]
			public static bool[] ReflectStarShotsInForTheWorthy;

			[global::Cpp2ILInjected.Token(Token = "0x4006872")]
			public static bool[] IsTownPet;

			[global::Cpp2ILInjected.Token(Token = "0x4006873")]
			public static bool[] IsTownSlime;

			[global::Cpp2ILInjected.Token(Token = "0x4006874")]
			public static bool[] CanConvertIntoCopperSlimeTownNPC;

			[global::Cpp2ILInjected.Token(Token = "0x4006875")]
			public static List<int> GoldCrittersCollection;

			[global::Cpp2ILInjected.Token(Token = "0x4006876")]
			public static bool[] ZappingJellyfish;

			[global::Cpp2ILInjected.Token(Token = "0x4006877")]
			public static bool[] CantTakeLunchMoney;

			[global::Cpp2ILInjected.Token(Token = "0x4006878")]
			public static Dictionary<int, int> RespawnEnemyID;

			[global::Cpp2ILInjected.Token(Token = "0x4006879")]
			public static int[] TrailingMode;

			[global::Cpp2ILInjected.Token(Token = "0x400687A")]
			public static bool[] IsDragonfly;

			[global::Cpp2ILInjected.Token(Token = "0x400687B")]
			public static bool[] BelongsToInvasionOldOnesArmy;

			[global::Cpp2ILInjected.Token(Token = "0x400687C")]
			public static bool[] TeleportationImmune;

			[global::Cpp2ILInjected.Token(Token = "0x400687D")]
			public static bool[] UsesNewTargetting;

			[global::Cpp2ILInjected.Token(Token = "0x400687E")]
			public static bool[] TakesDamageFromHostilesWithoutBeingFriendly;

			[global::Cpp2ILInjected.Token(Token = "0x400687F")]
			public static bool[] AllNPCs;

			[global::Cpp2ILInjected.Token(Token = "0x4006880")]
			public static bool[] HurtingBees;

			[global::Cpp2ILInjected.Token(Token = "0x4006881")]
			public static bool[] FighterUsesDD2PortalAppearEffect;

			[global::Cpp2ILInjected.Token(Token = "0x4006882")]
			public static float[] StatueSpawnedDropRarity;

			[global::Cpp2ILInjected.Token(Token = "0x4006883")]
			public static bool[] NoEarlymodeLootWhenSpawnedFromStatue;

			[global::Cpp2ILInjected.Token(Token = "0x4006884")]
			public static bool[] NeedsExpertScaling;

			[global::Cpp2ILInjected.Token(Token = "0x4006885")]
			public static bool[] ProjectileNPC;

			[global::Cpp2ILInjected.Token(Token = "0x4006886")]
			public static bool[] SavesAndLoads;

			[global::Cpp2ILInjected.Token(Token = "0x4006887")]
			public static int[] TrailCacheLength;

			[global::Cpp2ILInjected.Token(Token = "0x4006888")]
			public static bool[] UsesMultiplayerProximitySyncing;

			[global::Cpp2ILInjected.Token(Token = "0x4006889")]
			public static bool[] NoMultiplayerSmoothingByType;

			[global::Cpp2ILInjected.Token(Token = "0x400688A")]
			public static bool[] NoMultiplayerSmoothingByAI;

			[global::Cpp2ILInjected.Token(Token = "0x400688B")]
			public static bool[] MPAllowedEnemies;

			[global::Cpp2ILInjected.Token(Token = "0x400688C")]
			public static bool[] TownCritter;

			[global::Cpp2ILInjected.Token(Token = "0x400688D")]
			public static bool[] CountsAsCritter;

			[global::Cpp2ILInjected.Token(Token = "0x400688E")]
			public static bool[] HasNoPartyText;

			[global::Cpp2ILInjected.Token(Token = "0x400688F")]
			public static int[] HatOffsetY;

			[global::Cpp2ILInjected.Token(Token = "0x4006890")]
			public static int[] FaceEmote;

			[global::Cpp2ILInjected.Token(Token = "0x4006891")]
			public static int[] ExtraFramesCount;

			[global::Cpp2ILInjected.Token(Token = "0x4006892")]
			public static int[] AttackFrameCount;

			[global::Cpp2ILInjected.Token(Token = "0x4006893")]
			public static int[] DangerDetectRange;

			[global::Cpp2ILInjected.Token(Token = "0x4006894")]
			public static bool[] ShimmerImmunity;

			[global::Cpp2ILInjected.Token(Token = "0x4006895")]
			public static int[] ShimmerTransformToItem;

			[global::Cpp2ILInjected.Token(Token = "0x4006896")]
			public static bool[] ShimmerTownTransform;

			[global::Cpp2ILInjected.Token(Token = "0x4006897")]
			public static int[] ShimmerTransformToNPC;

			[global::Cpp2ILInjected.Token(Token = "0x4006898")]
			public static int[] AttackTime;

			[global::Cpp2ILInjected.Token(Token = "0x4006899")]
			public static int[] AttackAverageChance;

			[global::Cpp2ILInjected.Token(Token = "0x400689A")]
			public static int[] AttackType;

			[global::Cpp2ILInjected.Token(Token = "0x400689B")]
			public static int[] PrettySafe;

			[global::Cpp2ILInjected.Token(Token = "0x400689C")]
			public static Color[] MagicAuraColor;

			[global::Cpp2ILInjected.Token(Token = "0x400689D")]
			public static bool[] DemonEyes;

			[global::Cpp2ILInjected.Token(Token = "0x400689E")]
			public static bool[] Zombies;

			[global::Cpp2ILInjected.Token(Token = "0x400689F")]
			public static bool[] Skeletons;

			[global::Cpp2ILInjected.Token(Token = "0x40068A0")]
			public static int[] BossHeadTextures;

			[global::Cpp2ILInjected.Token(Token = "0x40068A1")]
			public static bool[] PositiveNPCTypesExcludedFromDeathTally;

			[global::Cpp2ILInjected.Token(Token = "0x40068A2")]
			public static bool[] ShouldBeCountedAsBoss;

			[global::Cpp2ILInjected.Token(Token = "0x40068A3")]
			public static bool[] DangerThatPreventsOtherDangers;

			[global::Cpp2ILInjected.Token(Token = "0x40068A4")]
			public static bool[] MustAlwaysDraw;

			[global::Cpp2ILInjected.Token(Token = "0x40068A5")]
			public static bool[] ExpandedCullDraw;

			[global::Cpp2ILInjected.Token(Token = "0x40068A6")]
			public static int[] ExtraTextureCount;

			[global::Cpp2ILInjected.Token(Token = "0x40068A7")]
			public static int[] NPCFramingGroup;

			[global::Cpp2ILInjected.Token(Token = "0x40068A8")]
			public static bool[] CanHitPastShimmer;

			[global::Cpp2ILInjected.Token(Token = "0x40068A9")]
			public static int[][] TownNPCsFramingGroups;

			[global::Cpp2ILInjected.Token(Token = "0x20005E1")]
			public struct NPCBestiaryDrawModifiers
			{
				[global::Cpp2ILInjected.Token(Token = "0x600356C")]
				[global::Cpp2ILInjected.Address(RVA = "0x13C775C", Offset = "0x13C775C", Length = "0x8C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "GetRedigitEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = "GetLeinforsEntries", ReturnType = typeof(Dictionary<int, NPCID.Sets.NPCBestiaryDrawModifiers>))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 700)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				public NPCBestiaryDrawModifiers(int seriouslyWhyCantStructsHaveParameterlessConstructors)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x40068AA")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
				public Vector2 Position;

				[global::Cpp2ILInjected.Token(Token = "0x40068AB")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
				public float? PortraitPositionXOverride;

				[global::Cpp2ILInjected.Token(Token = "0x40068AC")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
				public float? PortraitPositionYOverride;

				[global::Cpp2ILInjected.Token(Token = "0x40068AD")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
				public float Rotation;

				[global::Cpp2ILInjected.Token(Token = "0x40068AE")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
				public float Scale;

				[global::Cpp2ILInjected.Token(Token = "0x40068AF")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
				public float? PortraitScale;

				[global::Cpp2ILInjected.Token(Token = "0x40068B0")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
				public bool Hide;

				[global::Cpp2ILInjected.Token(Token = "0x40068B1")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
				public bool IsWet;

				[global::Cpp2ILInjected.Token(Token = "0x40068B2")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
				public int? Frame;

				[global::Cpp2ILInjected.Token(Token = "0x40068B3")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
				public int? Direction;

				[global::Cpp2ILInjected.Token(Token = "0x40068B4")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
				public int? SpriteDirection;

				[global::Cpp2ILInjected.Token(Token = "0x40068B5")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
				public float Velocity;

				[global::Cpp2ILInjected.Token(Token = "0x40068B6")]
				[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
				public string CustomTexturePath;
			}

			[global::Cpp2ILInjected.Token(Token = "0x20005E2")]
			private static class LocalBuffID
			{
				[global::Cpp2ILInjected.Token(Token = "0x40068B7")]
				public const int Confused = 31;

				[global::Cpp2ILInjected.Token(Token = "0x40068B8")]
				public const int Poisoned = 20;

				[global::Cpp2ILInjected.Token(Token = "0x40068B9")]
				public const int OnFire = 24;

				[global::Cpp2ILInjected.Token(Token = "0x40068BA")]
				public const int OnFire3 = 323;

				[global::Cpp2ILInjected.Token(Token = "0x40068BB")]
				public const int ShadowFlame = 153;

				[global::Cpp2ILInjected.Token(Token = "0x40068BC")]
				public const int Daybreak = 189;

				[global::Cpp2ILInjected.Token(Token = "0x40068BD")]
				public const int Frostburn = 44;

				[global::Cpp2ILInjected.Token(Token = "0x40068BE")]
				public const int Frostburn2 = 324;

				[global::Cpp2ILInjected.Token(Token = "0x40068BF")]
				public const int CursedInferno = 39;

				[global::Cpp2ILInjected.Token(Token = "0x40068C0")]
				public const int BetsysCurse = 203;

				[global::Cpp2ILInjected.Token(Token = "0x40068C1")]
				public const int Ichor = 69;

				[global::Cpp2ILInjected.Token(Token = "0x40068C2")]
				public const int Venom = 70;

				[global::Cpp2ILInjected.Token(Token = "0x40068C3")]
				public const int Oiled = 204;

				[global::Cpp2ILInjected.Token(Token = "0x40068C4")]
				public const int BoneJavelin = 169;

				[global::Cpp2ILInjected.Token(Token = "0x40068C5")]
				public const int TentacleSpike = 337;

				[global::Cpp2ILInjected.Token(Token = "0x40068C6")]
				public const int BloodButcherer = 344;
			}
		}
	}
}
