using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Reflection;
using Terraria.DataStructures;
using Terraria.IO;
using Terraria.Localization;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005D1")]
	public class ItemID
	{
		[global::Cpp2ILInjected.Token(Token = "0x600354F")]
		[global::Cpp2ILInjected.Address(RVA = "0x138E74C", Offset = "0x138E74C", Length = "0x6654")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID), Member = "FromLegacyName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, short>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, short>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 655)]
		private static Dictionary<string, short> GenerateLegacyItemDictionary()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003550")]
		[global::Cpp2ILInjected.Address(RVA = "0x1394DA0", Offset = "0x1394DA0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GetItemName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static short FromNetId(short id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003551")]
		[global::Cpp2ILInjected.Address(RVA = "0x1394F44", Offset = "0x1394F44", Length = "0x3F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldSwitch), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldSwitch), Member = "LoadWorld_Version1", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "LoadWorld_Version1_Old_BeforeRelease88", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemID), Member = "GenerateLegacyItemDictionary", ReturnType = typeof(Dictionary<string, short>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, short>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref short)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public static short FromLegacyName(string name, int release)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003552")]
		[global::Cpp2ILInjected.Address(RVA = "0x139533C", Offset = "0x139533C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ItemID()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003553")]
		[global::Cpp2ILInjected.Address(RVA = "0x1395344", Offset = "0x1395344", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "Create", MemberTypeParameters = new object[] { "IdClass", "IdType" }, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ItemID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4004E05")]
		private static Dictionary<string, short> _legacyItemLookup;

		[global::Cpp2ILInjected.Token(Token = "0x4004E06")]
		public const short YellowPhasesaberOld = -24;

		[global::Cpp2ILInjected.Token(Token = "0x4004E07")]
		public const short WhitePhasesaberOld = -23;

		[global::Cpp2ILInjected.Token(Token = "0x4004E08")]
		public const short PurplePhasesaberOld = -22;

		[global::Cpp2ILInjected.Token(Token = "0x4004E09")]
		public const short GreenPhasesaberOld = -21;

		[global::Cpp2ILInjected.Token(Token = "0x4004E0A")]
		public const short RedPhasesaberOld = -20;

		[global::Cpp2ILInjected.Token(Token = "0x4004E0B")]
		public const short BluePhasesaberOld = -19;

		[global::Cpp2ILInjected.Token(Token = "0x4004E0C")]
		public const short PlatinumBowOld = -48;

		[global::Cpp2ILInjected.Token(Token = "0x4004E0D")]
		public const short PlatinumHammerOld = -47;

		[global::Cpp2ILInjected.Token(Token = "0x4004E0E")]
		public const short PlatinumAxeOld = -46;

		[global::Cpp2ILInjected.Token(Token = "0x4004E0F")]
		public const short PlatinumShortswordOld = -45;

		[global::Cpp2ILInjected.Token(Token = "0x4004E10")]
		public const short PlatinumBroadswordOld = -44;

		[global::Cpp2ILInjected.Token(Token = "0x4004E11")]
		public const short PlatinumPickaxeOld = -43;

		[global::Cpp2ILInjected.Token(Token = "0x4004E12")]
		public const short TungstenBowOld = -42;

		[global::Cpp2ILInjected.Token(Token = "0x4004E13")]
		public const short TungstenHammerOld = -41;

		[global::Cpp2ILInjected.Token(Token = "0x4004E14")]
		public const short TungstenAxeOld = -40;

		[global::Cpp2ILInjected.Token(Token = "0x4004E15")]
		public const short TungstenShortswordOld = -39;

		[global::Cpp2ILInjected.Token(Token = "0x4004E16")]
		public const short TungstenBroadswordOld = -38;

		[global::Cpp2ILInjected.Token(Token = "0x4004E17")]
		public const short TungstenPickaxeOld = -37;

		[global::Cpp2ILInjected.Token(Token = "0x4004E18")]
		public const short LeadBowOld = -36;

		[global::Cpp2ILInjected.Token(Token = "0x4004E19")]
		public const short LeadHammerOld = -35;

		[global::Cpp2ILInjected.Token(Token = "0x4004E1A")]
		public const short LeadAxeOld = -34;

		[global::Cpp2ILInjected.Token(Token = "0x4004E1B")]
		public const short LeadShortswordOld = -33;

		[global::Cpp2ILInjected.Token(Token = "0x4004E1C")]
		public const short LeadBroadswordOld = -32;

		[global::Cpp2ILInjected.Token(Token = "0x4004E1D")]
		public const short LeadPickaxeOld = -31;

		[global::Cpp2ILInjected.Token(Token = "0x4004E1E")]
		public const short TinBowOld = -30;

		[global::Cpp2ILInjected.Token(Token = "0x4004E1F")]
		public const short TinHammerOld = -29;

		[global::Cpp2ILInjected.Token(Token = "0x4004E20")]
		public const short TinAxeOld = -28;

		[global::Cpp2ILInjected.Token(Token = "0x4004E21")]
		public const short TinShortswordOld = -27;

		[global::Cpp2ILInjected.Token(Token = "0x4004E22")]
		public const short TinBroadswordOld = -26;

		[global::Cpp2ILInjected.Token(Token = "0x4004E23")]
		public const short TinPickaxeOld = -25;

		[global::Cpp2ILInjected.Token(Token = "0x4004E24")]
		public const short CopperBowOld = -18;

		[global::Cpp2ILInjected.Token(Token = "0x4004E25")]
		public const short CopperHammerOld = -17;

		[global::Cpp2ILInjected.Token(Token = "0x4004E26")]
		public const short CopperAxeOld = -16;

		[global::Cpp2ILInjected.Token(Token = "0x4004E27")]
		public const short CopperShortswordOld = -15;

		[global::Cpp2ILInjected.Token(Token = "0x4004E28")]
		public const short CopperBroadswordOld = -14;

		[global::Cpp2ILInjected.Token(Token = "0x4004E29")]
		public const short CopperPickaxeOld = -13;

		[global::Cpp2ILInjected.Token(Token = "0x4004E2A")]
		public const short SilverBowOld = -12;

		[global::Cpp2ILInjected.Token(Token = "0x4004E2B")]
		public const short SilverHammerOld = -11;

		[global::Cpp2ILInjected.Token(Token = "0x4004E2C")]
		public const short SilverAxeOld = -10;

		[global::Cpp2ILInjected.Token(Token = "0x4004E2D")]
		public const short SilverShortswordOld = -9;

		[global::Cpp2ILInjected.Token(Token = "0x4004E2E")]
		public const short SilverBroadswordOld = -8;

		[global::Cpp2ILInjected.Token(Token = "0x4004E2F")]
		public const short SilverPickaxeOld = -7;

		[global::Cpp2ILInjected.Token(Token = "0x4004E30")]
		public const short GoldBowOld = -6;

		[global::Cpp2ILInjected.Token(Token = "0x4004E31")]
		public const short GoldHammerOld = -5;

		[global::Cpp2ILInjected.Token(Token = "0x4004E32")]
		public const short GoldAxeOld = -4;

		[global::Cpp2ILInjected.Token(Token = "0x4004E33")]
		public const short GoldShortswordOld = -3;

		[global::Cpp2ILInjected.Token(Token = "0x4004E34")]
		public const short GoldBroadswordOld = -2;

		[global::Cpp2ILInjected.Token(Token = "0x4004E35")]
		public const short GoldPickaxeOld = -1;

		[global::Cpp2ILInjected.Token(Token = "0x4004E36")]
		public const short None = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4004E37")]
		public const short IronPickaxe = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4004E38")]
		public const short DirtBlock = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4004E39")]
		public const short StoneBlock = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4004E3A")]
		public const short IronBroadsword = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4004E3B")]
		public const short Mushroom = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4004E3C")]
		public const short IronShortsword = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4004E3D")]
		public const short IronHammer = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4004E3E")]
		public const short Torch = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4004E3F")]
		public const short Wood = 9;

		[global::Cpp2ILInjected.Token(Token = "0x4004E40")]
		public const short IronAxe = 10;

		[global::Cpp2ILInjected.Token(Token = "0x4004E41")]
		public const short IronOre = 11;

		[global::Cpp2ILInjected.Token(Token = "0x4004E42")]
		public const short CopperOre = 12;

		[global::Cpp2ILInjected.Token(Token = "0x4004E43")]
		public const short GoldOre = 13;

		[global::Cpp2ILInjected.Token(Token = "0x4004E44")]
		public const short SilverOre = 14;

		[global::Cpp2ILInjected.Token(Token = "0x4004E45")]
		public const short CopperWatch = 15;

		[global::Cpp2ILInjected.Token(Token = "0x4004E46")]
		public const short SilverWatch = 16;

		[global::Cpp2ILInjected.Token(Token = "0x4004E47")]
		public const short GoldWatch = 17;

		[global::Cpp2ILInjected.Token(Token = "0x4004E48")]
		public const short DepthMeter = 18;

		[global::Cpp2ILInjected.Token(Token = "0x4004E49")]
		public const short GoldBar = 19;

		[global::Cpp2ILInjected.Token(Token = "0x4004E4A")]
		public const short CopperBar = 20;

		[global::Cpp2ILInjected.Token(Token = "0x4004E4B")]
		public const short SilverBar = 21;

		[global::Cpp2ILInjected.Token(Token = "0x4004E4C")]
		public const short IronBar = 22;

		[global::Cpp2ILInjected.Token(Token = "0x4004E4D")]
		public const short Gel = 23;

		[global::Cpp2ILInjected.Token(Token = "0x4004E4E")]
		public const short WoodenSword = 24;

		[global::Cpp2ILInjected.Token(Token = "0x4004E4F")]
		public const short WoodenDoor = 25;

		[global::Cpp2ILInjected.Token(Token = "0x4004E50")]
		public const short StoneWall = 26;

		[global::Cpp2ILInjected.Token(Token = "0x4004E51")]
		public const short Acorn = 27;

		[global::Cpp2ILInjected.Token(Token = "0x4004E52")]
		public const short LesserHealingPotion = 28;

		[global::Cpp2ILInjected.Token(Token = "0x4004E53")]
		public const short LifeCrystal = 29;

		[global::Cpp2ILInjected.Token(Token = "0x4004E54")]
		public const short DirtWall = 30;

		[global::Cpp2ILInjected.Token(Token = "0x4004E55")]
		public const short Bottle = 31;

		[global::Cpp2ILInjected.Token(Token = "0x4004E56")]
		public const short WoodenTable = 32;

		[global::Cpp2ILInjected.Token(Token = "0x4004E57")]
		public const short Furnace = 33;

		[global::Cpp2ILInjected.Token(Token = "0x4004E58")]
		public const short WoodenChair = 34;

		[global::Cpp2ILInjected.Token(Token = "0x4004E59")]
		public const short IronAnvil = 35;

		[global::Cpp2ILInjected.Token(Token = "0x4004E5A")]
		public const short WorkBench = 36;

		[global::Cpp2ILInjected.Token(Token = "0x4004E5B")]
		public const short Goggles = 37;

		[global::Cpp2ILInjected.Token(Token = "0x4004E5C")]
		public const short Lens = 38;

		[global::Cpp2ILInjected.Token(Token = "0x4004E5D")]
		public const short WoodenBow = 39;

		[global::Cpp2ILInjected.Token(Token = "0x4004E5E")]
		public const short WoodenArrow = 40;

		[global::Cpp2ILInjected.Token(Token = "0x4004E5F")]
		public const short FlamingArrow = 41;

		[global::Cpp2ILInjected.Token(Token = "0x4004E60")]
		public const short Shuriken = 42;

		[global::Cpp2ILInjected.Token(Token = "0x4004E61")]
		public const short SuspiciousLookingEye = 43;

		[global::Cpp2ILInjected.Token(Token = "0x4004E62")]
		public const short DemonBow = 44;

		[global::Cpp2ILInjected.Token(Token = "0x4004E63")]
		public const short WarAxeoftheNight = 45;

		[global::Cpp2ILInjected.Token(Token = "0x4004E64")]
		public const short LightsBane = 46;

		[global::Cpp2ILInjected.Token(Token = "0x4004E65")]
		public const short UnholyArrow = 47;

		[global::Cpp2ILInjected.Token(Token = "0x4004E66")]
		public const short Chest = 48;

		[global::Cpp2ILInjected.Token(Token = "0x4004E67")]
		public const short BandofRegeneration = 49;

		[global::Cpp2ILInjected.Token(Token = "0x4004E68")]
		public const short MagicMirror = 50;

		[global::Cpp2ILInjected.Token(Token = "0x4004E69")]
		public const short JestersArrow = 51;

		[global::Cpp2ILInjected.Token(Token = "0x4004E6A")]
		public const short AngelStatue = 52;

		[global::Cpp2ILInjected.Token(Token = "0x4004E6B")]
		public const short CloudinaBottle = 53;

		[global::Cpp2ILInjected.Token(Token = "0x4004E6C")]
		public const short HermesBoots = 54;

		[global::Cpp2ILInjected.Token(Token = "0x4004E6D")]
		public const short EnchantedBoomerang = 55;

		[global::Cpp2ILInjected.Token(Token = "0x4004E6E")]
		public const short DemoniteOre = 56;

		[global::Cpp2ILInjected.Token(Token = "0x4004E6F")]
		public const short DemoniteBar = 57;

		[global::Cpp2ILInjected.Token(Token = "0x4004E70")]
		public const short Heart = 58;

		[global::Cpp2ILInjected.Token(Token = "0x4004E71")]
		public const short CorruptSeeds = 59;

		[global::Cpp2ILInjected.Token(Token = "0x4004E72")]
		public const short VileMushroom = 60;

		[global::Cpp2ILInjected.Token(Token = "0x4004E73")]
		public const short EbonstoneBlock = 61;

		[global::Cpp2ILInjected.Token(Token = "0x4004E74")]
		public const short GrassSeeds = 62;

		[global::Cpp2ILInjected.Token(Token = "0x4004E75")]
		public const short Sunflower = 63;

		[global::Cpp2ILInjected.Token(Token = "0x4004E76")]
		public const short Vilethorn = 64;

		[global::Cpp2ILInjected.Token(Token = "0x4004E77")]
		public const short Starfury = 65;

		[global::Cpp2ILInjected.Token(Token = "0x4004E78")]
		public const short PurificationPowder = 66;

		[global::Cpp2ILInjected.Token(Token = "0x4004E79")]
		public const short VilePowder = 67;

		[global::Cpp2ILInjected.Token(Token = "0x4004E7A")]
		public const short RottenChunk = 68;

		[global::Cpp2ILInjected.Token(Token = "0x4004E7B")]
		public const short WormTooth = 69;

		[global::Cpp2ILInjected.Token(Token = "0x4004E7C")]
		public const short WormFood = 70;

		[global::Cpp2ILInjected.Token(Token = "0x4004E7D")]
		public const short CopperCoin = 71;

		[global::Cpp2ILInjected.Token(Token = "0x4004E7E")]
		public const short SilverCoin = 72;

		[global::Cpp2ILInjected.Token(Token = "0x4004E7F")]
		public const short GoldCoin = 73;

		[global::Cpp2ILInjected.Token(Token = "0x4004E80")]
		public const short PlatinumCoin = 74;

		[global::Cpp2ILInjected.Token(Token = "0x4004E81")]
		public const short FallenStar = 75;

		[global::Cpp2ILInjected.Token(Token = "0x4004E82")]
		public const short CopperGreaves = 76;

		[global::Cpp2ILInjected.Token(Token = "0x4004E83")]
		public const short IronGreaves = 77;

		[global::Cpp2ILInjected.Token(Token = "0x4004E84")]
		public const short SilverGreaves = 78;

		[global::Cpp2ILInjected.Token(Token = "0x4004E85")]
		public const short GoldGreaves = 79;

		[global::Cpp2ILInjected.Token(Token = "0x4004E86")]
		public const short CopperChainmail = 80;

		[global::Cpp2ILInjected.Token(Token = "0x4004E87")]
		public const short IronChainmail = 81;

		[global::Cpp2ILInjected.Token(Token = "0x4004E88")]
		public const short SilverChainmail = 82;

		[global::Cpp2ILInjected.Token(Token = "0x4004E89")]
		public const short GoldChainmail = 83;

		[global::Cpp2ILInjected.Token(Token = "0x4004E8A")]
		public const short GrapplingHook = 84;

		[global::Cpp2ILInjected.Token(Token = "0x4004E8B")]
		public const short Chain = 85;

		[global::Cpp2ILInjected.Token(Token = "0x4004E8C")]
		public const short ShadowScale = 86;

		[global::Cpp2ILInjected.Token(Token = "0x4004E8D")]
		public const short PiggyBank = 87;

		[global::Cpp2ILInjected.Token(Token = "0x4004E8E")]
		public const short MiningHelmet = 88;

		[global::Cpp2ILInjected.Token(Token = "0x4004E8F")]
		public const short CopperHelmet = 89;

		[global::Cpp2ILInjected.Token(Token = "0x4004E90")]
		public const short IronHelmet = 90;

		[global::Cpp2ILInjected.Token(Token = "0x4004E91")]
		public const short SilverHelmet = 91;

		[global::Cpp2ILInjected.Token(Token = "0x4004E92")]
		public const short GoldHelmet = 92;

		[global::Cpp2ILInjected.Token(Token = "0x4004E93")]
		public const short WoodWall = 93;

		[global::Cpp2ILInjected.Token(Token = "0x4004E94")]
		public const short WoodPlatform = 94;

		[global::Cpp2ILInjected.Token(Token = "0x4004E95")]
		public const short FlintlockPistol = 95;

		[global::Cpp2ILInjected.Token(Token = "0x4004E96")]
		public const short Musket = 96;

		[global::Cpp2ILInjected.Token(Token = "0x4004E97")]
		public const short MusketBall = 97;

		[global::Cpp2ILInjected.Token(Token = "0x4004E98")]
		public const short Minishark = 98;

		[global::Cpp2ILInjected.Token(Token = "0x4004E99")]
		public const short IronBow = 99;

		[global::Cpp2ILInjected.Token(Token = "0x4004E9A")]
		public const short ShadowGreaves = 100;

		[global::Cpp2ILInjected.Token(Token = "0x4004E9B")]
		public const short ShadowScalemail = 101;

		[global::Cpp2ILInjected.Token(Token = "0x4004E9C")]
		public const short ShadowHelmet = 102;

		[global::Cpp2ILInjected.Token(Token = "0x4004E9D")]
		public const short NightmarePickaxe = 103;

		[global::Cpp2ILInjected.Token(Token = "0x4004E9E")]
		public const short TheBreaker = 104;

		[global::Cpp2ILInjected.Token(Token = "0x4004E9F")]
		public const short Candle = 105;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA0")]
		public const short CopperChandelier = 106;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA1")]
		public const short SilverChandelier = 107;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA2")]
		public const short GoldChandelier = 108;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA3")]
		public const short ManaCrystal = 109;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA4")]
		public const short LesserManaPotion = 110;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA5")]
		public const short BandofStarpower = 111;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA6")]
		public const short FlowerofFire = 112;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA7")]
		public const short MagicMissile = 113;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA8")]
		public const short DirtRod = 114;

		[global::Cpp2ILInjected.Token(Token = "0x4004EA9")]
		public const short ShadowOrb = 115;

		[global::Cpp2ILInjected.Token(Token = "0x4004EAA")]
		public const short Meteorite = 116;

		[global::Cpp2ILInjected.Token(Token = "0x4004EAB")]
		public const short MeteoriteBar = 117;

		[global::Cpp2ILInjected.Token(Token = "0x4004EAC")]
		public const short Hook = 118;

		[global::Cpp2ILInjected.Token(Token = "0x4004EAD")]
		public const short Flamarang = 119;

		[global::Cpp2ILInjected.Token(Token = "0x4004EAE")]
		public const short MoltenFury = 120;

		[global::Cpp2ILInjected.Token(Token = "0x4004EAF")]
		public const short FieryGreatsword = 121;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB0")]
		public const short MoltenPickaxe = 122;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB1")]
		public const short MeteorHelmet = 123;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB2")]
		public const short MeteorSuit = 124;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB3")]
		public const short MeteorLeggings = 125;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB4")]
		public const short BottledWater = 126;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB5")]
		public const short SpaceGun = 127;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB6")]
		public const short RocketBoots = 128;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB7")]
		public const short GrayBrick = 129;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB8")]
		public const short GrayBrickWall = 130;

		[global::Cpp2ILInjected.Token(Token = "0x4004EB9")]
		public const short RedBrick = 131;

		[global::Cpp2ILInjected.Token(Token = "0x4004EBA")]
		public const short RedBrickWall = 132;

		[global::Cpp2ILInjected.Token(Token = "0x4004EBB")]
		public const short ClayBlock = 133;

		[global::Cpp2ILInjected.Token(Token = "0x4004EBC")]
		public const short BlueBrick = 134;

		[global::Cpp2ILInjected.Token(Token = "0x4004EBD")]
		public const short BlueBrickWall = 135;

		[global::Cpp2ILInjected.Token(Token = "0x4004EBE")]
		public const short ChainLantern = 136;

		[global::Cpp2ILInjected.Token(Token = "0x4004EBF")]
		public const short GreenBrick = 137;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC0")]
		public const short GreenBrickWall = 138;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC1")]
		public const short PinkBrick = 139;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC2")]
		public const short PinkBrickWall = 140;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC3")]
		public const short GoldBrick = 141;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC4")]
		public const short GoldBrickWall = 142;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC5")]
		public const short SilverBrick = 143;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC6")]
		public const short SilverBrickWall = 144;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC7")]
		public const short CopperBrick = 145;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC8")]
		public const short CopperBrickWall = 146;

		[global::Cpp2ILInjected.Token(Token = "0x4004EC9")]
		public const short Spike = 147;

		[global::Cpp2ILInjected.Token(Token = "0x4004ECA")]
		public const short WaterCandle = 148;

		[global::Cpp2ILInjected.Token(Token = "0x4004ECB")]
		public const short Book = 149;

		[global::Cpp2ILInjected.Token(Token = "0x4004ECC")]
		public const short Cobweb = 150;

		[global::Cpp2ILInjected.Token(Token = "0x4004ECD")]
		public const short NecroHelmet = 151;

		[global::Cpp2ILInjected.Token(Token = "0x4004ECE")]
		public const short NecroBreastplate = 152;

		[global::Cpp2ILInjected.Token(Token = "0x4004ECF")]
		public const short NecroGreaves = 153;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED0")]
		public const short Bone = 154;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED1")]
		public const short Muramasa = 155;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED2")]
		public const short CobaltShield = 156;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED3")]
		public const short AquaScepter = 157;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED4")]
		public const short LuckyHorseshoe = 158;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED5")]
		public const short ShinyRedBalloon = 159;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED6")]
		public const short Harpoon = 160;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED7")]
		public const short SpikyBall = 161;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED8")]
		public const short BallOHurt = 162;

		[global::Cpp2ILInjected.Token(Token = "0x4004ED9")]
		public const short BlueMoon = 163;

		[global::Cpp2ILInjected.Token(Token = "0x4004EDA")]
		public const short Handgun = 164;

		[global::Cpp2ILInjected.Token(Token = "0x4004EDB")]
		public const short WaterBolt = 165;

		[global::Cpp2ILInjected.Token(Token = "0x4004EDC")]
		public const short Bomb = 166;

		[global::Cpp2ILInjected.Token(Token = "0x4004EDD")]
		public const short Dynamite = 167;

		[global::Cpp2ILInjected.Token(Token = "0x4004EDE")]
		public const short Grenade = 168;

		[global::Cpp2ILInjected.Token(Token = "0x4004EDF")]
		public const short SandBlock = 169;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE0")]
		public const short Glass = 170;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE1")]
		public const short Sign = 171;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE2")]
		public const short AshBlock = 172;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE3")]
		public const short Obsidian = 173;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE4")]
		public const short Hellstone = 174;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE5")]
		public const short HellstoneBar = 175;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE6")]
		public const short MudBlock = 176;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE7")]
		public const short Sapphire = 177;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE8")]
		public const short Ruby = 178;

		[global::Cpp2ILInjected.Token(Token = "0x4004EE9")]
		public const short Emerald = 179;

		[global::Cpp2ILInjected.Token(Token = "0x4004EEA")]
		public const short Topaz = 180;

		[global::Cpp2ILInjected.Token(Token = "0x4004EEB")]
		public const short Amethyst = 181;

		[global::Cpp2ILInjected.Token(Token = "0x4004EEC")]
		public const short Diamond = 182;

		[global::Cpp2ILInjected.Token(Token = "0x4004EED")]
		public const short GlowingMushroom = 183;

		[global::Cpp2ILInjected.Token(Token = "0x4004EEE")]
		public const short Star = 184;

		[global::Cpp2ILInjected.Token(Token = "0x4004EEF")]
		public const short IvyWhip = 185;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF0")]
		public const short BreathingReed = 186;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF1")]
		public const short Flipper = 187;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF2")]
		public const short HealingPotion = 188;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF3")]
		public const short ManaPotion = 189;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF4")]
		public const short BladeofGrass = 190;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF5")]
		public const short ThornChakram = 191;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF6")]
		public const short ObsidianBrick = 192;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF7")]
		public const short ObsidianSkull = 193;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF8")]
		public const short MushroomGrassSeeds = 194;

		[global::Cpp2ILInjected.Token(Token = "0x4004EF9")]
		public const short JungleGrassSeeds = 195;

		[global::Cpp2ILInjected.Token(Token = "0x4004EFA")]
		public const short WoodenHammer = 196;

		[global::Cpp2ILInjected.Token(Token = "0x4004EFB")]
		public const short StarCannon = 197;

		[global::Cpp2ILInjected.Token(Token = "0x4004EFC")]
		public const short BluePhaseblade = 198;

		[global::Cpp2ILInjected.Token(Token = "0x4004EFD")]
		public const short RedPhaseblade = 199;

		[global::Cpp2ILInjected.Token(Token = "0x4004EFE")]
		public const short GreenPhaseblade = 200;

		[global::Cpp2ILInjected.Token(Token = "0x4004EFF")]
		public const short PurplePhaseblade = 201;

		[global::Cpp2ILInjected.Token(Token = "0x4004F00")]
		public const short WhitePhaseblade = 202;

		[global::Cpp2ILInjected.Token(Token = "0x4004F01")]
		public const short YellowPhaseblade = 203;

		[global::Cpp2ILInjected.Token(Token = "0x4004F02")]
		public const short MeteorHamaxe = 204;

		[global::Cpp2ILInjected.Token(Token = "0x4004F03")]
		public const short EmptyBucket = 205;

		[global::Cpp2ILInjected.Token(Token = "0x4004F04")]
		public const short WaterBucket = 206;

		[global::Cpp2ILInjected.Token(Token = "0x4004F05")]
		public const short LavaBucket = 207;

		[global::Cpp2ILInjected.Token(Token = "0x4004F06")]
		public const short JungleRose = 208;

		[global::Cpp2ILInjected.Token(Token = "0x4004F07")]
		public const short Stinger = 209;

		[global::Cpp2ILInjected.Token(Token = "0x4004F08")]
		public const short Vine = 210;

		[global::Cpp2ILInjected.Token(Token = "0x4004F09")]
		public const short FeralClaws = 211;

		[global::Cpp2ILInjected.Token(Token = "0x4004F0A")]
		public const short AnkletoftheWind = 212;

		[global::Cpp2ILInjected.Token(Token = "0x4004F0B")]
		public const short StaffofRegrowth = 213;

		[global::Cpp2ILInjected.Token(Token = "0x4004F0C")]
		public const short HellstoneBrick = 214;

		[global::Cpp2ILInjected.Token(Token = "0x4004F0D")]
		public const short WhoopieCushion = 215;

		[global::Cpp2ILInjected.Token(Token = "0x4004F0E")]
		public const short Shackle = 216;

		[global::Cpp2ILInjected.Token(Token = "0x4004F0F")]
		public const short MoltenHamaxe = 217;

		[global::Cpp2ILInjected.Token(Token = "0x4004F10")]
		public const short Flamelash = 218;

		[global::Cpp2ILInjected.Token(Token = "0x4004F11")]
		public const short PhoenixBlaster = 219;

		[global::Cpp2ILInjected.Token(Token = "0x4004F12")]
		public const short Sunfury = 220;

		[global::Cpp2ILInjected.Token(Token = "0x4004F13")]
		public const short Hellforge = 221;

		[global::Cpp2ILInjected.Token(Token = "0x4004F14")]
		public const short ClayPot = 222;

		[global::Cpp2ILInjected.Token(Token = "0x4004F15")]
		public const short NaturesGift = 223;

		[global::Cpp2ILInjected.Token(Token = "0x4004F16")]
		public const short Bed = 224;

		[global::Cpp2ILInjected.Token(Token = "0x4004F17")]
		public const short Silk = 225;

		[global::Cpp2ILInjected.Token(Token = "0x4004F18")]
		public const short LesserRestorationPotion = 226;

		[global::Cpp2ILInjected.Token(Token = "0x4004F19")]
		public const short RestorationPotion = 227;

		[global::Cpp2ILInjected.Token(Token = "0x4004F1A")]
		public const short JungleHat = 228;

		[global::Cpp2ILInjected.Token(Token = "0x4004F1B")]
		public const short JungleShirt = 229;

		[global::Cpp2ILInjected.Token(Token = "0x4004F1C")]
		public const short JunglePants = 230;

		[global::Cpp2ILInjected.Token(Token = "0x4004F1D")]
		public const short MoltenHelmet = 231;

		[global::Cpp2ILInjected.Token(Token = "0x4004F1E")]
		public const short MoltenBreastplate = 232;

		[global::Cpp2ILInjected.Token(Token = "0x4004F1F")]
		public const short MoltenGreaves = 233;

		[global::Cpp2ILInjected.Token(Token = "0x4004F20")]
		public const short MeteorShot = 234;

		[global::Cpp2ILInjected.Token(Token = "0x4004F21")]
		public const short StickyBomb = 235;

		[global::Cpp2ILInjected.Token(Token = "0x4004F22")]
		public const short BlackLens = 236;

		[global::Cpp2ILInjected.Token(Token = "0x4004F23")]
		public const short Sunglasses = 237;

		[global::Cpp2ILInjected.Token(Token = "0x4004F24")]
		public const short WizardHat = 238;

		[global::Cpp2ILInjected.Token(Token = "0x4004F25")]
		public const short TopHat = 239;

		[global::Cpp2ILInjected.Token(Token = "0x4004F26")]
		public const short TuxedoShirt = 240;

		[global::Cpp2ILInjected.Token(Token = "0x4004F27")]
		public const short TuxedoPants = 241;

		[global::Cpp2ILInjected.Token(Token = "0x4004F28")]
		public const short SummerHat = 242;

		[global::Cpp2ILInjected.Token(Token = "0x4004F29")]
		public const short BunnyHood = 243;

		[global::Cpp2ILInjected.Token(Token = "0x4004F2A")]
		public const short PlumbersHat = 244;

		[global::Cpp2ILInjected.Token(Token = "0x4004F2B")]
		public const short PlumbersShirt = 245;

		[global::Cpp2ILInjected.Token(Token = "0x4004F2C")]
		public const short PlumbersPants = 246;

		[global::Cpp2ILInjected.Token(Token = "0x4004F2D")]
		public const short HerosHat = 247;

		[global::Cpp2ILInjected.Token(Token = "0x4004F2E")]
		public const short HerosShirt = 248;

		[global::Cpp2ILInjected.Token(Token = "0x4004F2F")]
		public const short HerosPants = 249;

		[global::Cpp2ILInjected.Token(Token = "0x4004F30")]
		public const short FishBowl = 250;

		[global::Cpp2ILInjected.Token(Token = "0x4004F31")]
		public const short ArchaeologistsHat = 251;

		[global::Cpp2ILInjected.Token(Token = "0x4004F32")]
		public const short ArchaeologistsJacket = 252;

		[global::Cpp2ILInjected.Token(Token = "0x4004F33")]
		public const short ArchaeologistsPants = 253;

		[global::Cpp2ILInjected.Token(Token = "0x4004F34")]
		public const short BlackThread = 254;

		[global::Cpp2ILInjected.Token(Token = "0x4004F35")]
		public const short GreenThread = 255;

		[global::Cpp2ILInjected.Token(Token = "0x4004F36")]
		public const short NinjaHood = 256;

		[global::Cpp2ILInjected.Token(Token = "0x4004F37")]
		public const short NinjaShirt = 257;

		[global::Cpp2ILInjected.Token(Token = "0x4004F38")]
		public const short NinjaPants = 258;

		[global::Cpp2ILInjected.Token(Token = "0x4004F39")]
		public const short Leather = 259;

		[global::Cpp2ILInjected.Token(Token = "0x4004F3A")]
		public const short RedHat = 260;

		[global::Cpp2ILInjected.Token(Token = "0x4004F3B")]
		public const short Goldfish = 261;

		[global::Cpp2ILInjected.Token(Token = "0x4004F3C")]
		public const short Robe = 262;

		[global::Cpp2ILInjected.Token(Token = "0x4004F3D")]
		public const short RobotHat = 263;

		[global::Cpp2ILInjected.Token(Token = "0x4004F3E")]
		public const short GoldCrown = 264;

		[global::Cpp2ILInjected.Token(Token = "0x4004F3F")]
		public const short HellfireArrow = 265;

		[global::Cpp2ILInjected.Token(Token = "0x4004F40")]
		public const short Sandgun = 266;

		[global::Cpp2ILInjected.Token(Token = "0x4004F41")]
		public const short GuideVoodooDoll = 267;

		[global::Cpp2ILInjected.Token(Token = "0x4004F42")]
		public const short DivingHelmet = 268;

		[global::Cpp2ILInjected.Token(Token = "0x4004F43")]
		public const short FamiliarShirt = 269;

		[global::Cpp2ILInjected.Token(Token = "0x4004F44")]
		public const short FamiliarPants = 270;

		[global::Cpp2ILInjected.Token(Token = "0x4004F45")]
		public const short FamiliarWig = 271;

		[global::Cpp2ILInjected.Token(Token = "0x4004F46")]
		public const short DemonScythe = 272;

		[global::Cpp2ILInjected.Token(Token = "0x4004F47")]
		public const short NightsEdge = 273;

		[global::Cpp2ILInjected.Token(Token = "0x4004F48")]
		public const short DarkLance = 274;

		[global::Cpp2ILInjected.Token(Token = "0x4004F49")]
		public const short Coral = 275;

		[global::Cpp2ILInjected.Token(Token = "0x4004F4A")]
		public const short Cactus = 276;

		[global::Cpp2ILInjected.Token(Token = "0x4004F4B")]
		public const short Trident = 277;

		[global::Cpp2ILInjected.Token(Token = "0x4004F4C")]
		public const short SilverBullet = 278;

		[global::Cpp2ILInjected.Token(Token = "0x4004F4D")]
		public const short ThrowingKnife = 279;

		[global::Cpp2ILInjected.Token(Token = "0x4004F4E")]
		public const short Spear = 280;

		[global::Cpp2ILInjected.Token(Token = "0x4004F4F")]
		public const short Blowpipe = 281;

		[global::Cpp2ILInjected.Token(Token = "0x4004F50")]
		public const short Glowstick = 282;

		[global::Cpp2ILInjected.Token(Token = "0x4004F51")]
		public const short Seed = 283;

		[global::Cpp2ILInjected.Token(Token = "0x4004F52")]
		public const short WoodenBoomerang = 284;

		[global::Cpp2ILInjected.Token(Token = "0x4004F53")]
		public const short Aglet = 285;

		[global::Cpp2ILInjected.Token(Token = "0x4004F54")]
		public const short StickyGlowstick = 286;

		[global::Cpp2ILInjected.Token(Token = "0x4004F55")]
		public const short PoisonedKnife = 287;

		[global::Cpp2ILInjected.Token(Token = "0x4004F56")]
		public const short ObsidianSkinPotion = 288;

		[global::Cpp2ILInjected.Token(Token = "0x4004F57")]
		public const short RegenerationPotion = 289;

		[global::Cpp2ILInjected.Token(Token = "0x4004F58")]
		public const short SwiftnessPotion = 290;

		[global::Cpp2ILInjected.Token(Token = "0x4004F59")]
		public const short GillsPotion = 291;

		[global::Cpp2ILInjected.Token(Token = "0x4004F5A")]
		public const short IronskinPotion = 292;

		[global::Cpp2ILInjected.Token(Token = "0x4004F5B")]
		public const short ManaRegenerationPotion = 293;

		[global::Cpp2ILInjected.Token(Token = "0x4004F5C")]
		public const short MagicPowerPotion = 294;

		[global::Cpp2ILInjected.Token(Token = "0x4004F5D")]
		public const short FeatherfallPotion = 295;

		[global::Cpp2ILInjected.Token(Token = "0x4004F5E")]
		public const short SpelunkerPotion = 296;

		[global::Cpp2ILInjected.Token(Token = "0x4004F5F")]
		public const short InvisibilityPotion = 297;

		[global::Cpp2ILInjected.Token(Token = "0x4004F60")]
		public const short ShinePotion = 298;

		[global::Cpp2ILInjected.Token(Token = "0x4004F61")]
		public const short NightOwlPotion = 299;

		[global::Cpp2ILInjected.Token(Token = "0x4004F62")]
		public const short BattlePotion = 300;

		[global::Cpp2ILInjected.Token(Token = "0x4004F63")]
		public const short ThornsPotion = 301;

		[global::Cpp2ILInjected.Token(Token = "0x4004F64")]
		public const short WaterWalkingPotion = 302;

		[global::Cpp2ILInjected.Token(Token = "0x4004F65")]
		public const short ArcheryPotion = 303;

		[global::Cpp2ILInjected.Token(Token = "0x4004F66")]
		public const short HunterPotion = 304;

		[global::Cpp2ILInjected.Token(Token = "0x4004F67")]
		public const short GravitationPotion = 305;

		[global::Cpp2ILInjected.Token(Token = "0x4004F68")]
		public const short GoldChest = 306;

		[global::Cpp2ILInjected.Token(Token = "0x4004F69")]
		public const short DaybloomSeeds = 307;

		[global::Cpp2ILInjected.Token(Token = "0x4004F6A")]
		public const short MoonglowSeeds = 308;

		[global::Cpp2ILInjected.Token(Token = "0x4004F6B")]
		public const short BlinkrootSeeds = 309;

		[global::Cpp2ILInjected.Token(Token = "0x4004F6C")]
		public const short DeathweedSeeds = 310;

		[global::Cpp2ILInjected.Token(Token = "0x4004F6D")]
		public const short WaterleafSeeds = 311;

		[global::Cpp2ILInjected.Token(Token = "0x4004F6E")]
		public const short FireblossomSeeds = 312;

		[global::Cpp2ILInjected.Token(Token = "0x4004F6F")]
		public const short Daybloom = 313;

		[global::Cpp2ILInjected.Token(Token = "0x4004F70")]
		public const short Moonglow = 314;

		[global::Cpp2ILInjected.Token(Token = "0x4004F71")]
		public const short Blinkroot = 315;

		[global::Cpp2ILInjected.Token(Token = "0x4004F72")]
		public const short Deathweed = 316;

		[global::Cpp2ILInjected.Token(Token = "0x4004F73")]
		public const short Waterleaf = 317;

		[global::Cpp2ILInjected.Token(Token = "0x4004F74")]
		public const short Fireblossom = 318;

		[global::Cpp2ILInjected.Token(Token = "0x4004F75")]
		public const short SharkFin = 319;

		[global::Cpp2ILInjected.Token(Token = "0x4004F76")]
		public const short Feather = 320;

		[global::Cpp2ILInjected.Token(Token = "0x4004F77")]
		public const short Tombstone = 321;

		[global::Cpp2ILInjected.Token(Token = "0x4004F78")]
		public const short MimeMask = 322;

		[global::Cpp2ILInjected.Token(Token = "0x4004F79")]
		public const short AntlionMandible = 323;

		[global::Cpp2ILInjected.Token(Token = "0x4004F7A")]
		public const short IllegalGunParts = 324;

		[global::Cpp2ILInjected.Token(Token = "0x4004F7B")]
		public const short TheDoctorsShirt = 325;

		[global::Cpp2ILInjected.Token(Token = "0x4004F7C")]
		public const short TheDoctorsPants = 326;

		[global::Cpp2ILInjected.Token(Token = "0x4004F7D")]
		public const short GoldenKey = 327;

		[global::Cpp2ILInjected.Token(Token = "0x4004F7E")]
		public const short ShadowChest = 328;

		[global::Cpp2ILInjected.Token(Token = "0x4004F7F")]
		public const short ShadowKey = 329;

		[global::Cpp2ILInjected.Token(Token = "0x4004F80")]
		public const short ObsidianBrickWall = 330;

		[global::Cpp2ILInjected.Token(Token = "0x4004F81")]
		public const short JungleSpores = 331;

		[global::Cpp2ILInjected.Token(Token = "0x4004F82")]
		public const short Loom = 332;

		[global::Cpp2ILInjected.Token(Token = "0x4004F83")]
		public const short Piano = 333;

		[global::Cpp2ILInjected.Token(Token = "0x4004F84")]
		public const short Dresser = 334;

		[global::Cpp2ILInjected.Token(Token = "0x4004F85")]
		public const short Bench = 335;

		[global::Cpp2ILInjected.Token(Token = "0x4004F86")]
		public const short Bathtub = 336;

		[global::Cpp2ILInjected.Token(Token = "0x4004F87")]
		public const short RedBanner = 337;

		[global::Cpp2ILInjected.Token(Token = "0x4004F88")]
		public const short GreenBanner = 338;

		[global::Cpp2ILInjected.Token(Token = "0x4004F89")]
		public const short BlueBanner = 339;

		[global::Cpp2ILInjected.Token(Token = "0x4004F8A")]
		public const short YellowBanner = 340;

		[global::Cpp2ILInjected.Token(Token = "0x4004F8B")]
		public const short LampPost = 341;

		[global::Cpp2ILInjected.Token(Token = "0x4004F8C")]
		public const short TikiTorch = 342;

		[global::Cpp2ILInjected.Token(Token = "0x4004F8D")]
		public const short Barrel = 343;

		[global::Cpp2ILInjected.Token(Token = "0x4004F8E")]
		public const short ChineseLantern = 344;

		[global::Cpp2ILInjected.Token(Token = "0x4004F8F")]
		public const short CookingPot = 345;

		[global::Cpp2ILInjected.Token(Token = "0x4004F90")]
		public const short Safe = 346;

		[global::Cpp2ILInjected.Token(Token = "0x4004F91")]
		public const short SkullLantern = 347;

		[global::Cpp2ILInjected.Token(Token = "0x4004F92")]
		public const short TrashCan = 348;

		[global::Cpp2ILInjected.Token(Token = "0x4004F93")]
		public const short Candelabra = 349;

		[global::Cpp2ILInjected.Token(Token = "0x4004F94")]
		public const short PinkVase = 350;

		[global::Cpp2ILInjected.Token(Token = "0x4004F95")]
		public const short Mug = 351;

		[global::Cpp2ILInjected.Token(Token = "0x4004F96")]
		public const short Keg = 352;

		[global::Cpp2ILInjected.Token(Token = "0x4004F97")]
		public const short Ale = 353;

		[global::Cpp2ILInjected.Token(Token = "0x4004F98")]
		public const short Bookcase = 354;

		[global::Cpp2ILInjected.Token(Token = "0x4004F99")]
		public const short Throne = 355;

		[global::Cpp2ILInjected.Token(Token = "0x4004F9A")]
		public const short Bowl = 356;

		[global::Cpp2ILInjected.Token(Token = "0x4004F9B")]
		public const short BowlofSoup = 357;

		[global::Cpp2ILInjected.Token(Token = "0x4004F9C")]
		public const short Toilet = 358;

		[global::Cpp2ILInjected.Token(Token = "0x4004F9D")]
		public const short GrandfatherClock = 359;

		[global::Cpp2ILInjected.Token(Token = "0x4004F9E")]
		public const short ArmorStatue = 360;

		[global::Cpp2ILInjected.Token(Token = "0x4004F9F")]
		public const short GoblinBattleStandard = 361;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA0")]
		public const short TatteredCloth = 362;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA1")]
		public const short Sawmill = 363;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA2")]
		public const short CobaltOre = 364;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA3")]
		public const short MythrilOre = 365;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA4")]
		public const short AdamantiteOre = 366;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA5")]
		public const short Pwnhammer = 367;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA6")]
		public const short Excalibur = 368;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA7")]
		public const short HallowedSeeds = 369;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA8")]
		public const short EbonsandBlock = 370;

		[global::Cpp2ILInjected.Token(Token = "0x4004FA9")]
		public const short CobaltHat = 371;

		[global::Cpp2ILInjected.Token(Token = "0x4004FAA")]
		public const short CobaltHelmet = 372;

		[global::Cpp2ILInjected.Token(Token = "0x4004FAB")]
		public const short CobaltMask = 373;

		[global::Cpp2ILInjected.Token(Token = "0x4004FAC")]
		public const short CobaltBreastplate = 374;

		[global::Cpp2ILInjected.Token(Token = "0x4004FAD")]
		public const short CobaltLeggings = 375;

		[global::Cpp2ILInjected.Token(Token = "0x4004FAE")]
		public const short MythrilHood = 376;

		[global::Cpp2ILInjected.Token(Token = "0x4004FAF")]
		public const short MythrilHelmet = 377;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB0")]
		public const short MythrilHat = 378;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB1")]
		public const short MythrilChainmail = 379;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB2")]
		public const short MythrilGreaves = 380;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB3")]
		public const short CobaltBar = 381;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB4")]
		public const short MythrilBar = 382;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB5")]
		public const short CobaltChainsaw = 383;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB6")]
		public const short MythrilChainsaw = 384;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB7")]
		public const short CobaltDrill = 385;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB8")]
		public const short MythrilDrill = 386;

		[global::Cpp2ILInjected.Token(Token = "0x4004FB9")]
		public const short AdamantiteChainsaw = 387;

		[global::Cpp2ILInjected.Token(Token = "0x4004FBA")]
		public const short AdamantiteDrill = 388;

		[global::Cpp2ILInjected.Token(Token = "0x4004FBB")]
		public const short DaoofPow = 389;

		[global::Cpp2ILInjected.Token(Token = "0x4004FBC")]
		public const short MythrilHalberd = 390;

		[global::Cpp2ILInjected.Token(Token = "0x4004FBD")]
		public const short AdamantiteBar = 391;

		[global::Cpp2ILInjected.Token(Token = "0x4004FBE")]
		public const short GlassWall = 392;

		[global::Cpp2ILInjected.Token(Token = "0x4004FBF")]
		public const short Compass = 393;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC0")]
		public const short DivingGear = 394;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC1")]
		public const short GPS = 395;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC2")]
		public const short ObsidianHorseshoe = 396;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC3")]
		public const short ObsidianShield = 397;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC4")]
		public const short TinkerersWorkshop = 398;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC5")]
		public const short CloudinaBalloon = 399;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC6")]
		public const short AdamantiteHeadgear = 400;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC7")]
		public const short AdamantiteHelmet = 401;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC8")]
		public const short AdamantiteMask = 402;

		[global::Cpp2ILInjected.Token(Token = "0x4004FC9")]
		public const short AdamantiteBreastplate = 403;

		[global::Cpp2ILInjected.Token(Token = "0x4004FCA")]
		public const short AdamantiteLeggings = 404;

		[global::Cpp2ILInjected.Token(Token = "0x4004FCB")]
		public const short SpectreBoots = 405;

		[global::Cpp2ILInjected.Token(Token = "0x4004FCC")]
		public const short AdamantiteGlaive = 406;

		[global::Cpp2ILInjected.Token(Token = "0x4004FCD")]
		public const short Toolbelt = 407;

		[global::Cpp2ILInjected.Token(Token = "0x4004FCE")]
		public const short PearlsandBlock = 408;

		[global::Cpp2ILInjected.Token(Token = "0x4004FCF")]
		public const short PearlstoneBlock = 409;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD0")]
		public const short MiningShirt = 410;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD1")]
		public const short MiningPants = 411;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD2")]
		public const short PearlstoneBrick = 412;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD3")]
		public const short IridescentBrick = 413;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD4")]
		public const short MudstoneBlock = 414;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD5")]
		public const short CobaltBrick = 415;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD6")]
		public const short MythrilBrick = 416;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD7")]
		public const short PearlstoneBrickWall = 417;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD8")]
		public const short IridescentBrickWall = 418;

		[global::Cpp2ILInjected.Token(Token = "0x4004FD9")]
		public const short MudstoneBrickWall = 419;

		[global::Cpp2ILInjected.Token(Token = "0x4004FDA")]
		public const short CobaltBrickWall = 420;

		[global::Cpp2ILInjected.Token(Token = "0x4004FDB")]
		public const short MythrilBrickWall = 421;

		[global::Cpp2ILInjected.Token(Token = "0x4004FDC")]
		public const short HolyWater = 422;

		[global::Cpp2ILInjected.Token(Token = "0x4004FDD")]
		public const short UnholyWater = 423;

		[global::Cpp2ILInjected.Token(Token = "0x4004FDE")]
		public const short SiltBlock = 424;

		[global::Cpp2ILInjected.Token(Token = "0x4004FDF")]
		public const short FairyBell = 425;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE0")]
		public const short BreakerBlade = 426;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE1")]
		public const short BlueTorch = 427;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE2")]
		public const short RedTorch = 428;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE3")]
		public const short GreenTorch = 429;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE4")]
		public const short PurpleTorch = 430;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE5")]
		public const short WhiteTorch = 431;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE6")]
		public const short YellowTorch = 432;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE7")]
		public const short DemonTorch = 433;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE8")]
		public const short ClockworkAssaultRifle = 434;

		[global::Cpp2ILInjected.Token(Token = "0x4004FE9")]
		public const short CobaltRepeater = 435;

		[global::Cpp2ILInjected.Token(Token = "0x4004FEA")]
		public const short MythrilRepeater = 436;

		[global::Cpp2ILInjected.Token(Token = "0x4004FEB")]
		public const short DualHook = 437;

		[global::Cpp2ILInjected.Token(Token = "0x4004FEC")]
		public const short StarStatue = 438;

		[global::Cpp2ILInjected.Token(Token = "0x4004FED")]
		public const short SwordStatue = 439;

		[global::Cpp2ILInjected.Token(Token = "0x4004FEE")]
		public const short SlimeStatue = 440;

		[global::Cpp2ILInjected.Token(Token = "0x4004FEF")]
		public const short GoblinStatue = 441;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF0")]
		public const short ShieldStatue = 442;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF1")]
		public const short BatStatue = 443;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF2")]
		public const short FishStatue = 444;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF3")]
		public const short BunnyStatue = 445;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF4")]
		public const short SkeletonStatue = 446;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF5")]
		public const short ReaperStatue = 447;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF6")]
		public const short WomanStatue = 448;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF7")]
		public const short ImpStatue = 449;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF8")]
		public const short GargoyleStatue = 450;

		[global::Cpp2ILInjected.Token(Token = "0x4004FF9")]
		public const short GloomStatue = 451;

		[global::Cpp2ILInjected.Token(Token = "0x4004FFA")]
		public const short HornetStatue = 452;

		[global::Cpp2ILInjected.Token(Token = "0x4004FFB")]
		public const short BombStatue = 453;

		[global::Cpp2ILInjected.Token(Token = "0x4004FFC")]
		public const short CrabStatue = 454;

		[global::Cpp2ILInjected.Token(Token = "0x4004FFD")]
		public const short HammerStatue = 455;

		[global::Cpp2ILInjected.Token(Token = "0x4004FFE")]
		public const short PotionStatue = 456;

		[global::Cpp2ILInjected.Token(Token = "0x4004FFF")]
		public const short SpearStatue = 457;

		[global::Cpp2ILInjected.Token(Token = "0x4005000")]
		public const short CrossStatue = 458;

		[global::Cpp2ILInjected.Token(Token = "0x4005001")]
		public const short JellyfishStatue = 459;

		[global::Cpp2ILInjected.Token(Token = "0x4005002")]
		public const short BowStatue = 460;

		[global::Cpp2ILInjected.Token(Token = "0x4005003")]
		public const short BoomerangStatue = 461;

		[global::Cpp2ILInjected.Token(Token = "0x4005004")]
		public const short BootStatue = 462;

		[global::Cpp2ILInjected.Token(Token = "0x4005005")]
		public const short ChestStatue = 463;

		[global::Cpp2ILInjected.Token(Token = "0x4005006")]
		public const short BirdStatue = 464;

		[global::Cpp2ILInjected.Token(Token = "0x4005007")]
		public const short AxeStatue = 465;

		[global::Cpp2ILInjected.Token(Token = "0x4005008")]
		public const short CorruptStatue = 466;

		[global::Cpp2ILInjected.Token(Token = "0x4005009")]
		public const short TreeStatue = 467;

		[global::Cpp2ILInjected.Token(Token = "0x400500A")]
		public const short AnvilStatue = 468;

		[global::Cpp2ILInjected.Token(Token = "0x400500B")]
		public const short PickaxeStatue = 469;

		[global::Cpp2ILInjected.Token(Token = "0x400500C")]
		public const short MushroomStatue = 470;

		[global::Cpp2ILInjected.Token(Token = "0x400500D")]
		public const short EyeballStatue = 471;

		[global::Cpp2ILInjected.Token(Token = "0x400500E")]
		public const short PillarStatue = 472;

		[global::Cpp2ILInjected.Token(Token = "0x400500F")]
		public const short HeartStatue = 473;

		[global::Cpp2ILInjected.Token(Token = "0x4005010")]
		public const short PotStatue = 474;

		[global::Cpp2ILInjected.Token(Token = "0x4005011")]
		public const short SunflowerStatue = 475;

		[global::Cpp2ILInjected.Token(Token = "0x4005012")]
		public const short KingStatue = 476;

		[global::Cpp2ILInjected.Token(Token = "0x4005013")]
		public const short QueenStatue = 477;

		[global::Cpp2ILInjected.Token(Token = "0x4005014")]
		public const short PiranhaStatue = 478;

		[global::Cpp2ILInjected.Token(Token = "0x4005015")]
		public const short PlankedWall = 479;

		[global::Cpp2ILInjected.Token(Token = "0x4005016")]
		public const short WoodenBeam = 480;

		[global::Cpp2ILInjected.Token(Token = "0x4005017")]
		public const short AdamantiteRepeater = 481;

		[global::Cpp2ILInjected.Token(Token = "0x4005018")]
		public const short AdamantiteSword = 482;

		[global::Cpp2ILInjected.Token(Token = "0x4005019")]
		public const short CobaltSword = 483;

		[global::Cpp2ILInjected.Token(Token = "0x400501A")]
		public const short MythrilSword = 484;

		[global::Cpp2ILInjected.Token(Token = "0x400501B")]
		public const short MoonCharm = 485;

		[global::Cpp2ILInjected.Token(Token = "0x400501C")]
		public const short Ruler = 486;

		[global::Cpp2ILInjected.Token(Token = "0x400501D")]
		public const short CrystalBall = 487;

		[global::Cpp2ILInjected.Token(Token = "0x400501E")]
		public const short DiscoBall = 488;

		[global::Cpp2ILInjected.Token(Token = "0x400501F")]
		public const short SorcererEmblem = 489;

		[global::Cpp2ILInjected.Token(Token = "0x4005020")]
		public const short WarriorEmblem = 490;

		[global::Cpp2ILInjected.Token(Token = "0x4005021")]
		public const short RangerEmblem = 491;

		[global::Cpp2ILInjected.Token(Token = "0x4005022")]
		public const short DemonWings = 492;

		[global::Cpp2ILInjected.Token(Token = "0x4005023")]
		public const short AngelWings = 493;

		[global::Cpp2ILInjected.Token(Token = "0x4005024")]
		public const short MagicalHarp = 494;

		[global::Cpp2ILInjected.Token(Token = "0x4005025")]
		public const short RainbowRod = 495;

		[global::Cpp2ILInjected.Token(Token = "0x4005026")]
		public const short IceRod = 496;

		[global::Cpp2ILInjected.Token(Token = "0x4005027")]
		public const short NeptunesShell = 497;

		[global::Cpp2ILInjected.Token(Token = "0x4005028")]
		public const short Mannequin = 498;

		[global::Cpp2ILInjected.Token(Token = "0x4005029")]
		public const short GreaterHealingPotion = 499;

		[global::Cpp2ILInjected.Token(Token = "0x400502A")]
		public const short GreaterManaPotion = 500;

		[global::Cpp2ILInjected.Token(Token = "0x400502B")]
		public const short PixieDust = 501;

		[global::Cpp2ILInjected.Token(Token = "0x400502C")]
		public const short CrystalShard = 502;

		[global::Cpp2ILInjected.Token(Token = "0x400502D")]
		public const short ClownHat = 503;

		[global::Cpp2ILInjected.Token(Token = "0x400502E")]
		public const short ClownShirt = 504;

		[global::Cpp2ILInjected.Token(Token = "0x400502F")]
		public const short ClownPants = 505;

		[global::Cpp2ILInjected.Token(Token = "0x4005030")]
		public const short Flamethrower = 506;

		[global::Cpp2ILInjected.Token(Token = "0x4005031")]
		public const short Bell = 507;

		[global::Cpp2ILInjected.Token(Token = "0x4005032")]
		public const short Harp = 508;

		[global::Cpp2ILInjected.Token(Token = "0x4005033")]
		public const short Wrench = 509;

		[global::Cpp2ILInjected.Token(Token = "0x4005034")]
		public const short WireCutter = 510;

		[global::Cpp2ILInjected.Token(Token = "0x4005035")]
		public const short ActiveStoneBlock = 511;

		[global::Cpp2ILInjected.Token(Token = "0x4005036")]
		public const short InactiveStoneBlock = 512;

		[global::Cpp2ILInjected.Token(Token = "0x4005037")]
		public const short Lever = 513;

		[global::Cpp2ILInjected.Token(Token = "0x4005038")]
		public const short LaserRifle = 514;

		[global::Cpp2ILInjected.Token(Token = "0x4005039")]
		public const short CrystalBullet = 515;

		[global::Cpp2ILInjected.Token(Token = "0x400503A")]
		public const short HolyArrow = 516;

		[global::Cpp2ILInjected.Token(Token = "0x400503B")]
		public const short MagicDagger = 517;

		[global::Cpp2ILInjected.Token(Token = "0x400503C")]
		public const short CrystalStorm = 518;

		[global::Cpp2ILInjected.Token(Token = "0x400503D")]
		public const short CursedFlames = 519;

		[global::Cpp2ILInjected.Token(Token = "0x400503E")]
		public const short SoulofLight = 520;

		[global::Cpp2ILInjected.Token(Token = "0x400503F")]
		public const short SoulofNight = 521;

		[global::Cpp2ILInjected.Token(Token = "0x4005040")]
		public const short CursedFlame = 522;

		[global::Cpp2ILInjected.Token(Token = "0x4005041")]
		public const short CursedTorch = 523;

		[global::Cpp2ILInjected.Token(Token = "0x4005042")]
		public const short AdamantiteForge = 524;

		[global::Cpp2ILInjected.Token(Token = "0x4005043")]
		public const short MythrilAnvil = 525;

		[global::Cpp2ILInjected.Token(Token = "0x4005044")]
		public const short UnicornHorn = 526;

		[global::Cpp2ILInjected.Token(Token = "0x4005045")]
		public const short DarkShard = 527;

		[global::Cpp2ILInjected.Token(Token = "0x4005046")]
		public const short LightShard = 528;

		[global::Cpp2ILInjected.Token(Token = "0x4005047")]
		public const short RedPressurePlate = 529;

		[global::Cpp2ILInjected.Token(Token = "0x4005048")]
		public const short Wire = 530;

		[global::Cpp2ILInjected.Token(Token = "0x4005049")]
		public const short SpellTome = 531;

		[global::Cpp2ILInjected.Token(Token = "0x400504A")]
		public const short StarCloak = 532;

		[global::Cpp2ILInjected.Token(Token = "0x400504B")]
		public const short Megashark = 533;

		[global::Cpp2ILInjected.Token(Token = "0x400504C")]
		public const short Shotgun = 534;

		[global::Cpp2ILInjected.Token(Token = "0x400504D")]
		public const short PhilosophersStone = 535;

		[global::Cpp2ILInjected.Token(Token = "0x400504E")]
		public const short TitanGlove = 536;

		[global::Cpp2ILInjected.Token(Token = "0x400504F")]
		public const short CobaltNaginata = 537;

		[global::Cpp2ILInjected.Token(Token = "0x4005050")]
		public const short Switch = 538;

		[global::Cpp2ILInjected.Token(Token = "0x4005051")]
		public const short DartTrap = 539;

		[global::Cpp2ILInjected.Token(Token = "0x4005052")]
		public const short Boulder = 540;

		[global::Cpp2ILInjected.Token(Token = "0x4005053")]
		public const short GreenPressurePlate = 541;

		[global::Cpp2ILInjected.Token(Token = "0x4005054")]
		public const short GrayPressurePlate = 542;

		[global::Cpp2ILInjected.Token(Token = "0x4005055")]
		public const short BrownPressurePlate = 543;

		[global::Cpp2ILInjected.Token(Token = "0x4005056")]
		public const short MechanicalEye = 544;

		[global::Cpp2ILInjected.Token(Token = "0x4005057")]
		public const short CursedArrow = 545;

		[global::Cpp2ILInjected.Token(Token = "0x4005058")]
		public const short CursedBullet = 546;

		[global::Cpp2ILInjected.Token(Token = "0x4005059")]
		public const short SoulofFright = 547;

		[global::Cpp2ILInjected.Token(Token = "0x400505A")]
		public const short SoulofMight = 548;

		[global::Cpp2ILInjected.Token(Token = "0x400505B")]
		public const short SoulofSight = 549;

		[global::Cpp2ILInjected.Token(Token = "0x400505C")]
		public const short Gungnir = 550;

		[global::Cpp2ILInjected.Token(Token = "0x400505D")]
		public const short HallowedPlateMail = 551;

		[global::Cpp2ILInjected.Token(Token = "0x400505E")]
		public const short HallowedGreaves = 552;

		[global::Cpp2ILInjected.Token(Token = "0x400505F")]
		public const short HallowedHelmet = 553;

		[global::Cpp2ILInjected.Token(Token = "0x4005060")]
		public const short CrossNecklace = 554;

		[global::Cpp2ILInjected.Token(Token = "0x4005061")]
		public const short ManaFlower = 555;

		[global::Cpp2ILInjected.Token(Token = "0x4005062")]
		public const short MechanicalWorm = 556;

		[global::Cpp2ILInjected.Token(Token = "0x4005063")]
		public const short MechanicalSkull = 557;

		[global::Cpp2ILInjected.Token(Token = "0x4005064")]
		public const short HallowedHeadgear = 558;

		[global::Cpp2ILInjected.Token(Token = "0x4005065")]
		public const short HallowedMask = 559;

		[global::Cpp2ILInjected.Token(Token = "0x4005066")]
		public const short SlimeCrown = 560;

		[global::Cpp2ILInjected.Token(Token = "0x4005067")]
		public const short LightDisc = 561;

		[global::Cpp2ILInjected.Token(Token = "0x4005068")]
		public const short MusicBoxOverworldDay = 562;

		[global::Cpp2ILInjected.Token(Token = "0x4005069")]
		public const short MusicBoxEerie = 563;

		[global::Cpp2ILInjected.Token(Token = "0x400506A")]
		public const short MusicBoxNight = 564;

		[global::Cpp2ILInjected.Token(Token = "0x400506B")]
		public const short MusicBoxTitle = 565;

		[global::Cpp2ILInjected.Token(Token = "0x400506C")]
		public const short MusicBoxUnderground = 566;

		[global::Cpp2ILInjected.Token(Token = "0x400506D")]
		public const short MusicBoxBoss1 = 567;

		[global::Cpp2ILInjected.Token(Token = "0x400506E")]
		public const short MusicBoxJungle = 568;

		[global::Cpp2ILInjected.Token(Token = "0x400506F")]
		public const short MusicBoxCorruption = 569;

		[global::Cpp2ILInjected.Token(Token = "0x4005070")]
		public const short MusicBoxUndergroundCorruption = 570;

		[global::Cpp2ILInjected.Token(Token = "0x4005071")]
		public const short MusicBoxTheHallow = 571;

		[global::Cpp2ILInjected.Token(Token = "0x4005072")]
		public const short MusicBoxBoss2 = 572;

		[global::Cpp2ILInjected.Token(Token = "0x4005073")]
		public const short MusicBoxUndergroundHallow = 573;

		[global::Cpp2ILInjected.Token(Token = "0x4005074")]
		public const short MusicBoxBoss3 = 574;

		[global::Cpp2ILInjected.Token(Token = "0x4005075")]
		public const short SoulofFlight = 575;

		[global::Cpp2ILInjected.Token(Token = "0x4005076")]
		public const short MusicBox = 576;

		[global::Cpp2ILInjected.Token(Token = "0x4005077")]
		public const short DemoniteBrick = 577;

		[global::Cpp2ILInjected.Token(Token = "0x4005078")]
		public const short HallowedRepeater = 578;

		[global::Cpp2ILInjected.Token(Token = "0x4005079")]
		public const short Drax = 579;

		[global::Cpp2ILInjected.Token(Token = "0x400507A")]
		public const short Explosives = 580;

		[global::Cpp2ILInjected.Token(Token = "0x400507B")]
		public const short InletPump = 581;

		[global::Cpp2ILInjected.Token(Token = "0x400507C")]
		public const short OutletPump = 582;

		[global::Cpp2ILInjected.Token(Token = "0x400507D")]
		public const short Timer1Second = 583;

		[global::Cpp2ILInjected.Token(Token = "0x400507E")]
		public const short Timer3Second = 584;

		[global::Cpp2ILInjected.Token(Token = "0x400507F")]
		public const short Timer5Second = 585;

		[global::Cpp2ILInjected.Token(Token = "0x4005080")]
		public const short CandyCaneBlock = 586;

		[global::Cpp2ILInjected.Token(Token = "0x4005081")]
		public const short CandyCaneWall = 587;

		[global::Cpp2ILInjected.Token(Token = "0x4005082")]
		public const short SantaHat = 588;

		[global::Cpp2ILInjected.Token(Token = "0x4005083")]
		public const short SantaShirt = 589;

		[global::Cpp2ILInjected.Token(Token = "0x4005084")]
		public const short SantaPants = 590;

		[global::Cpp2ILInjected.Token(Token = "0x4005085")]
		public const short GreenCandyCaneBlock = 591;

		[global::Cpp2ILInjected.Token(Token = "0x4005086")]
		public const short GreenCandyCaneWall = 592;

		[global::Cpp2ILInjected.Token(Token = "0x4005087")]
		public const short SnowBlock = 593;

		[global::Cpp2ILInjected.Token(Token = "0x4005088")]
		public const short SnowBrick = 594;

		[global::Cpp2ILInjected.Token(Token = "0x4005089")]
		public const short SnowBrickWall = 595;

		[global::Cpp2ILInjected.Token(Token = "0x400508A")]
		public const short BlueLight = 596;

		[global::Cpp2ILInjected.Token(Token = "0x400508B")]
		public const short RedLight = 597;

		[global::Cpp2ILInjected.Token(Token = "0x400508C")]
		public const short GreenLight = 598;

		[global::Cpp2ILInjected.Token(Token = "0x400508D")]
		public const short BluePresent = 599;

		[global::Cpp2ILInjected.Token(Token = "0x400508E")]
		public const short GreenPresent = 600;

		[global::Cpp2ILInjected.Token(Token = "0x400508F")]
		public const short YellowPresent = 601;

		[global::Cpp2ILInjected.Token(Token = "0x4005090")]
		public const short SnowGlobe = 602;

		[global::Cpp2ILInjected.Token(Token = "0x4005091")]
		public const short Carrot = 603;

		[global::Cpp2ILInjected.Token(Token = "0x4005092")]
		public const short AdamantiteBeam = 604;

		[global::Cpp2ILInjected.Token(Token = "0x4005093")]
		public const short AdamantiteBeamWall = 605;

		[global::Cpp2ILInjected.Token(Token = "0x4005094")]
		public const short DemoniteBrickWall = 606;

		[global::Cpp2ILInjected.Token(Token = "0x4005095")]
		public const short SandstoneBrick = 607;

		[global::Cpp2ILInjected.Token(Token = "0x4005096")]
		public const short SandstoneBrickWall = 608;

		[global::Cpp2ILInjected.Token(Token = "0x4005097")]
		public const short EbonstoneBrick = 609;

		[global::Cpp2ILInjected.Token(Token = "0x4005098")]
		public const short EbonstoneBrickWall = 610;

		[global::Cpp2ILInjected.Token(Token = "0x4005099")]
		public const short RedStucco = 611;

		[global::Cpp2ILInjected.Token(Token = "0x400509A")]
		public const short YellowStucco = 612;

		[global::Cpp2ILInjected.Token(Token = "0x400509B")]
		public const short GreenStucco = 613;

		[global::Cpp2ILInjected.Token(Token = "0x400509C")]
		public const short GrayStucco = 614;

		[global::Cpp2ILInjected.Token(Token = "0x400509D")]
		public const short RedStuccoWall = 615;

		[global::Cpp2ILInjected.Token(Token = "0x400509E")]
		public const short YellowStuccoWall = 616;

		[global::Cpp2ILInjected.Token(Token = "0x400509F")]
		public const short GreenStuccoWall = 617;

		[global::Cpp2ILInjected.Token(Token = "0x40050A0")]
		public const short GrayStuccoWall = 618;

		[global::Cpp2ILInjected.Token(Token = "0x40050A1")]
		public const short Ebonwood = 619;

		[global::Cpp2ILInjected.Token(Token = "0x40050A2")]
		public const short RichMahogany = 620;

		[global::Cpp2ILInjected.Token(Token = "0x40050A3")]
		public const short Pearlwood = 621;

		[global::Cpp2ILInjected.Token(Token = "0x40050A4")]
		public const short EbonwoodWall = 622;

		[global::Cpp2ILInjected.Token(Token = "0x40050A5")]
		public const short RichMahoganyWall = 623;

		[global::Cpp2ILInjected.Token(Token = "0x40050A6")]
		public const short PearlwoodWall = 624;

		[global::Cpp2ILInjected.Token(Token = "0x40050A7")]
		public const short EbonwoodChest = 625;

		[global::Cpp2ILInjected.Token(Token = "0x40050A8")]
		public const short RichMahoganyChest = 626;

		[global::Cpp2ILInjected.Token(Token = "0x40050A9")]
		public const short PearlwoodChest = 627;

		[global::Cpp2ILInjected.Token(Token = "0x40050AA")]
		public const short EbonwoodChair = 628;

		[global::Cpp2ILInjected.Token(Token = "0x40050AB")]
		public const short RichMahoganyChair = 629;

		[global::Cpp2ILInjected.Token(Token = "0x40050AC")]
		public const short PearlwoodChair = 630;

		[global::Cpp2ILInjected.Token(Token = "0x40050AD")]
		public const short EbonwoodPlatform = 631;

		[global::Cpp2ILInjected.Token(Token = "0x40050AE")]
		public const short RichMahoganyPlatform = 632;

		[global::Cpp2ILInjected.Token(Token = "0x40050AF")]
		public const short PearlwoodPlatform = 633;

		[global::Cpp2ILInjected.Token(Token = "0x40050B0")]
		public const short BonePlatform = 634;

		[global::Cpp2ILInjected.Token(Token = "0x40050B1")]
		public const short EbonwoodWorkBench = 635;

		[global::Cpp2ILInjected.Token(Token = "0x40050B2")]
		public const short RichMahoganyWorkBench = 636;

		[global::Cpp2ILInjected.Token(Token = "0x40050B3")]
		public const short PearlwoodWorkBench = 637;

		[global::Cpp2ILInjected.Token(Token = "0x40050B4")]
		public const short EbonwoodTable = 638;

		[global::Cpp2ILInjected.Token(Token = "0x40050B5")]
		public const short RichMahoganyTable = 639;

		[global::Cpp2ILInjected.Token(Token = "0x40050B6")]
		public const short PearlwoodTable = 640;

		[global::Cpp2ILInjected.Token(Token = "0x40050B7")]
		public const short EbonwoodPiano = 641;

		[global::Cpp2ILInjected.Token(Token = "0x40050B8")]
		public const short RichMahoganyPiano = 642;

		[global::Cpp2ILInjected.Token(Token = "0x40050B9")]
		public const short PearlwoodPiano = 643;

		[global::Cpp2ILInjected.Token(Token = "0x40050BA")]
		public const short EbonwoodBed = 644;

		[global::Cpp2ILInjected.Token(Token = "0x40050BB")]
		public const short RichMahoganyBed = 645;

		[global::Cpp2ILInjected.Token(Token = "0x40050BC")]
		public const short PearlwoodBed = 646;

		[global::Cpp2ILInjected.Token(Token = "0x40050BD")]
		public const short EbonwoodDresser = 647;

		[global::Cpp2ILInjected.Token(Token = "0x40050BE")]
		public const short RichMahoganyDresser = 648;

		[global::Cpp2ILInjected.Token(Token = "0x40050BF")]
		public const short PearlwoodDresser = 649;

		[global::Cpp2ILInjected.Token(Token = "0x40050C0")]
		public const short EbonwoodDoor = 650;

		[global::Cpp2ILInjected.Token(Token = "0x40050C1")]
		public const short RichMahoganyDoor = 651;

		[global::Cpp2ILInjected.Token(Token = "0x40050C2")]
		public const short PearlwoodDoor = 652;

		[global::Cpp2ILInjected.Token(Token = "0x40050C3")]
		public const short EbonwoodSword = 653;

		[global::Cpp2ILInjected.Token(Token = "0x40050C4")]
		public const short EbonwoodHammer = 654;

		[global::Cpp2ILInjected.Token(Token = "0x40050C5")]
		public const short EbonwoodBow = 655;

		[global::Cpp2ILInjected.Token(Token = "0x40050C6")]
		public const short RichMahoganySword = 656;

		[global::Cpp2ILInjected.Token(Token = "0x40050C7")]
		public const short RichMahoganyHammer = 657;

		[global::Cpp2ILInjected.Token(Token = "0x40050C8")]
		public const short RichMahoganyBow = 658;

		[global::Cpp2ILInjected.Token(Token = "0x40050C9")]
		public const short PearlwoodSword = 659;

		[global::Cpp2ILInjected.Token(Token = "0x40050CA")]
		public const short PearlwoodHammer = 660;

		[global::Cpp2ILInjected.Token(Token = "0x40050CB")]
		public const short PearlwoodBow = 661;

		[global::Cpp2ILInjected.Token(Token = "0x40050CC")]
		public const short RainbowBrick = 662;

		[global::Cpp2ILInjected.Token(Token = "0x40050CD")]
		public const short RainbowBrickWall = 663;

		[global::Cpp2ILInjected.Token(Token = "0x40050CE")]
		public const short IceBlock = 664;

		[global::Cpp2ILInjected.Token(Token = "0x40050CF")]
		public const short RedsWings = 665;

		[global::Cpp2ILInjected.Token(Token = "0x40050D0")]
		public const short RedsHelmet = 666;

		[global::Cpp2ILInjected.Token(Token = "0x40050D1")]
		public const short RedsBreastplate = 667;

		[global::Cpp2ILInjected.Token(Token = "0x40050D2")]
		public const short RedsLeggings = 668;

		[global::Cpp2ILInjected.Token(Token = "0x40050D3")]
		public const short Fish = 669;

		[global::Cpp2ILInjected.Token(Token = "0x40050D4")]
		public const short IceBoomerang = 670;

		[global::Cpp2ILInjected.Token(Token = "0x40050D5")]
		public const short Keybrand = 671;

		[global::Cpp2ILInjected.Token(Token = "0x40050D6")]
		public const short Cutlass = 672;

		[global::Cpp2ILInjected.Token(Token = "0x40050D7")]
		public const short BorealWoodWorkBench = 673;

		[global::Cpp2ILInjected.Token(Token = "0x40050D8")]
		public const short TrueExcalibur = 674;

		[global::Cpp2ILInjected.Token(Token = "0x40050D9")]
		public const short TrueNightsEdge = 675;

		[global::Cpp2ILInjected.Token(Token = "0x40050DA")]
		public const short Frostbrand = 676;

		[global::Cpp2ILInjected.Token(Token = "0x40050DB")]
		public const short BorealWoodTable = 677;

		[global::Cpp2ILInjected.Token(Token = "0x40050DC")]
		public const short RedPotion = 678;

		[global::Cpp2ILInjected.Token(Token = "0x40050DD")]
		public const short TacticalShotgun = 679;

		[global::Cpp2ILInjected.Token(Token = "0x40050DE")]
		public const short IvyChest = 680;

		[global::Cpp2ILInjected.Token(Token = "0x40050DF")]
		public const short IceChest = 681;

		[global::Cpp2ILInjected.Token(Token = "0x40050E0")]
		public const short Marrow = 682;

		[global::Cpp2ILInjected.Token(Token = "0x40050E1")]
		public const short UnholyTrident = 683;

		[global::Cpp2ILInjected.Token(Token = "0x40050E2")]
		public const short FrostHelmet = 684;

		[global::Cpp2ILInjected.Token(Token = "0x40050E3")]
		public const short FrostBreastplate = 685;

		[global::Cpp2ILInjected.Token(Token = "0x40050E4")]
		public const short FrostLeggings = 686;

		[global::Cpp2ILInjected.Token(Token = "0x40050E5")]
		public const short TinHelmet = 687;

		[global::Cpp2ILInjected.Token(Token = "0x40050E6")]
		public const short TinChainmail = 688;

		[global::Cpp2ILInjected.Token(Token = "0x40050E7")]
		public const short TinGreaves = 689;

		[global::Cpp2ILInjected.Token(Token = "0x40050E8")]
		public const short LeadHelmet = 690;

		[global::Cpp2ILInjected.Token(Token = "0x40050E9")]
		public const short LeadChainmail = 691;

		[global::Cpp2ILInjected.Token(Token = "0x40050EA")]
		public const short LeadGreaves = 692;

		[global::Cpp2ILInjected.Token(Token = "0x40050EB")]
		public const short TungstenHelmet = 693;

		[global::Cpp2ILInjected.Token(Token = "0x40050EC")]
		public const short TungstenChainmail = 694;

		[global::Cpp2ILInjected.Token(Token = "0x40050ED")]
		public const short TungstenGreaves = 695;

		[global::Cpp2ILInjected.Token(Token = "0x40050EE")]
		public const short PlatinumHelmet = 696;

		[global::Cpp2ILInjected.Token(Token = "0x40050EF")]
		public const short PlatinumChainmail = 697;

		[global::Cpp2ILInjected.Token(Token = "0x40050F0")]
		public const short PlatinumGreaves = 698;

		[global::Cpp2ILInjected.Token(Token = "0x40050F1")]
		public const short TinOre = 699;

		[global::Cpp2ILInjected.Token(Token = "0x40050F2")]
		public const short LeadOre = 700;

		[global::Cpp2ILInjected.Token(Token = "0x40050F3")]
		public const short TungstenOre = 701;

		[global::Cpp2ILInjected.Token(Token = "0x40050F4")]
		public const short PlatinumOre = 702;

		[global::Cpp2ILInjected.Token(Token = "0x40050F5")]
		public const short TinBar = 703;

		[global::Cpp2ILInjected.Token(Token = "0x40050F6")]
		public const short LeadBar = 704;

		[global::Cpp2ILInjected.Token(Token = "0x40050F7")]
		public const short TungstenBar = 705;

		[global::Cpp2ILInjected.Token(Token = "0x40050F8")]
		public const short PlatinumBar = 706;

		[global::Cpp2ILInjected.Token(Token = "0x40050F9")]
		public const short TinWatch = 707;

		[global::Cpp2ILInjected.Token(Token = "0x40050FA")]
		public const short TungstenWatch = 708;

		[global::Cpp2ILInjected.Token(Token = "0x40050FB")]
		public const short PlatinumWatch = 709;

		[global::Cpp2ILInjected.Token(Token = "0x40050FC")]
		public const short TinChandelier = 710;

		[global::Cpp2ILInjected.Token(Token = "0x40050FD")]
		public const short TungstenChandelier = 711;

		[global::Cpp2ILInjected.Token(Token = "0x40050FE")]
		public const short PlatinumChandelier = 712;

		[global::Cpp2ILInjected.Token(Token = "0x40050FF")]
		public const short PlatinumCandle = 713;

		[global::Cpp2ILInjected.Token(Token = "0x4005100")]
		public const short PlatinumCandelabra = 714;

		[global::Cpp2ILInjected.Token(Token = "0x4005101")]
		public const short PlatinumCrown = 715;

		[global::Cpp2ILInjected.Token(Token = "0x4005102")]
		public const short LeadAnvil = 716;

		[global::Cpp2ILInjected.Token(Token = "0x4005103")]
		public const short TinBrick = 717;

		[global::Cpp2ILInjected.Token(Token = "0x4005104")]
		public const short TungstenBrick = 718;

		[global::Cpp2ILInjected.Token(Token = "0x4005105")]
		public const short PlatinumBrick = 719;

		[global::Cpp2ILInjected.Token(Token = "0x4005106")]
		public const short TinBrickWall = 720;

		[global::Cpp2ILInjected.Token(Token = "0x4005107")]
		public const short TungstenBrickWall = 721;

		[global::Cpp2ILInjected.Token(Token = "0x4005108")]
		public const short PlatinumBrickWall = 722;

		[global::Cpp2ILInjected.Token(Token = "0x4005109")]
		public const short BeamSword = 723;

		[global::Cpp2ILInjected.Token(Token = "0x400510A")]
		public const short IceBlade = 724;

		[global::Cpp2ILInjected.Token(Token = "0x400510B")]
		public const short IceBow = 725;

		[global::Cpp2ILInjected.Token(Token = "0x400510C")]
		public const short FrostStaff = 726;

		[global::Cpp2ILInjected.Token(Token = "0x400510D")]
		public const short WoodHelmet = 727;

		[global::Cpp2ILInjected.Token(Token = "0x400510E")]
		public const short WoodBreastplate = 728;

		[global::Cpp2ILInjected.Token(Token = "0x400510F")]
		public const short WoodGreaves = 729;

		[global::Cpp2ILInjected.Token(Token = "0x4005110")]
		public const short EbonwoodHelmet = 730;

		[global::Cpp2ILInjected.Token(Token = "0x4005111")]
		public const short EbonwoodBreastplate = 731;

		[global::Cpp2ILInjected.Token(Token = "0x4005112")]
		public const short EbonwoodGreaves = 732;

		[global::Cpp2ILInjected.Token(Token = "0x4005113")]
		public const short RichMahoganyHelmet = 733;

		[global::Cpp2ILInjected.Token(Token = "0x4005114")]
		public const short RichMahoganyBreastplate = 734;

		[global::Cpp2ILInjected.Token(Token = "0x4005115")]
		public const short RichMahoganyGreaves = 735;

		[global::Cpp2ILInjected.Token(Token = "0x4005116")]
		public const short PearlwoodHelmet = 736;

		[global::Cpp2ILInjected.Token(Token = "0x4005117")]
		public const short PearlwoodBreastplate = 737;

		[global::Cpp2ILInjected.Token(Token = "0x4005118")]
		public const short PearlwoodGreaves = 738;

		[global::Cpp2ILInjected.Token(Token = "0x4005119")]
		public const short AmethystStaff = 739;

		[global::Cpp2ILInjected.Token(Token = "0x400511A")]
		public const short TopazStaff = 740;

		[global::Cpp2ILInjected.Token(Token = "0x400511B")]
		public const short SapphireStaff = 741;

		[global::Cpp2ILInjected.Token(Token = "0x400511C")]
		public const short EmeraldStaff = 742;

		[global::Cpp2ILInjected.Token(Token = "0x400511D")]
		public const short RubyStaff = 743;

		[global::Cpp2ILInjected.Token(Token = "0x400511E")]
		public const short DiamondStaff = 744;

		[global::Cpp2ILInjected.Token(Token = "0x400511F")]
		public const short GrassWall = 745;

		[global::Cpp2ILInjected.Token(Token = "0x4005120")]
		public const short JungleWall = 746;

		[global::Cpp2ILInjected.Token(Token = "0x4005121")]
		public const short FlowerWall = 747;

		[global::Cpp2ILInjected.Token(Token = "0x4005122")]
		public const short Jetpack = 748;

		[global::Cpp2ILInjected.Token(Token = "0x4005123")]
		public const short ButterflyWings = 749;

		[global::Cpp2ILInjected.Token(Token = "0x4005124")]
		public const short CactusWall = 750;

		[global::Cpp2ILInjected.Token(Token = "0x4005125")]
		public const short Cloud = 751;

		[global::Cpp2ILInjected.Token(Token = "0x4005126")]
		public const short CloudWall = 752;

		[global::Cpp2ILInjected.Token(Token = "0x4005127")]
		public const short Seaweed = 753;

		[global::Cpp2ILInjected.Token(Token = "0x4005128")]
		public const short RuneHat = 754;

		[global::Cpp2ILInjected.Token(Token = "0x4005129")]
		public const short RuneRobe = 755;

		[global::Cpp2ILInjected.Token(Token = "0x400512A")]
		public const short MushroomSpear = 756;

		[global::Cpp2ILInjected.Token(Token = "0x400512B")]
		public const short TerraBlade = 757;

		[global::Cpp2ILInjected.Token(Token = "0x400512C")]
		public const short GrenadeLauncher = 758;

		[global::Cpp2ILInjected.Token(Token = "0x400512D")]
		public const short RocketLauncher = 759;

		[global::Cpp2ILInjected.Token(Token = "0x400512E")]
		public const short ProximityMineLauncher = 760;

		[global::Cpp2ILInjected.Token(Token = "0x400512F")]
		public const short FairyWings = 761;

		[global::Cpp2ILInjected.Token(Token = "0x4005130")]
		public const short SlimeBlock = 762;

		[global::Cpp2ILInjected.Token(Token = "0x4005131")]
		public const short FleshBlock = 763;

		[global::Cpp2ILInjected.Token(Token = "0x4005132")]
		public const short MushroomWall = 764;

		[global::Cpp2ILInjected.Token(Token = "0x4005133")]
		public const short RainCloud = 765;

		[global::Cpp2ILInjected.Token(Token = "0x4005134")]
		public const short BoneBlock = 766;

		[global::Cpp2ILInjected.Token(Token = "0x4005135")]
		public const short FrozenSlimeBlock = 767;

		[global::Cpp2ILInjected.Token(Token = "0x4005136")]
		public const short BoneBlockWall = 768;

		[global::Cpp2ILInjected.Token(Token = "0x4005137")]
		public const short SlimeBlockWall = 769;

		[global::Cpp2ILInjected.Token(Token = "0x4005138")]
		public const short FleshBlockWall = 770;

		[global::Cpp2ILInjected.Token(Token = "0x4005139")]
		public const short RocketI = 771;

		[global::Cpp2ILInjected.Token(Token = "0x400513A")]
		public const short RocketII = 772;

		[global::Cpp2ILInjected.Token(Token = "0x400513B")]
		public const short RocketIII = 773;

		[global::Cpp2ILInjected.Token(Token = "0x400513C")]
		public const short RocketIV = 774;

		[global::Cpp2ILInjected.Token(Token = "0x400513D")]
		public const short AsphaltBlock = 775;

		[global::Cpp2ILInjected.Token(Token = "0x400513E")]
		public const short CobaltPickaxe = 776;

		[global::Cpp2ILInjected.Token(Token = "0x400513F")]
		public const short MythrilPickaxe = 777;

		[global::Cpp2ILInjected.Token(Token = "0x4005140")]
		public const short AdamantitePickaxe = 778;

		[global::Cpp2ILInjected.Token(Token = "0x4005141")]
		public const short Clentaminator = 779;

		[global::Cpp2ILInjected.Token(Token = "0x4005142")]
		public const short GreenSolution = 780;

		[global::Cpp2ILInjected.Token(Token = "0x4005143")]
		public const short BlueSolution = 781;

		[global::Cpp2ILInjected.Token(Token = "0x4005144")]
		public const short PurpleSolution = 782;

		[global::Cpp2ILInjected.Token(Token = "0x4005145")]
		public const short DarkBlueSolution = 783;

		[global::Cpp2ILInjected.Token(Token = "0x4005146")]
		public const short RedSolution = 784;

		[global::Cpp2ILInjected.Token(Token = "0x4005147")]
		public const short HarpyWings = 785;

		[global::Cpp2ILInjected.Token(Token = "0x4005148")]
		public const short BoneWings = 786;

		[global::Cpp2ILInjected.Token(Token = "0x4005149")]
		public const short Hammush = 787;

		[global::Cpp2ILInjected.Token(Token = "0x400514A")]
		public const short NettleBurst = 788;

		[global::Cpp2ILInjected.Token(Token = "0x400514B")]
		public const short AnkhBanner = 789;

		[global::Cpp2ILInjected.Token(Token = "0x400514C")]
		public const short SnakeBanner = 790;

		[global::Cpp2ILInjected.Token(Token = "0x400514D")]
		public const short OmegaBanner = 791;

		[global::Cpp2ILInjected.Token(Token = "0x400514E")]
		public const short CrimsonHelmet = 792;

		[global::Cpp2ILInjected.Token(Token = "0x400514F")]
		public const short CrimsonScalemail = 793;

		[global::Cpp2ILInjected.Token(Token = "0x4005150")]
		public const short CrimsonGreaves = 794;

		[global::Cpp2ILInjected.Token(Token = "0x4005151")]
		public const short BloodButcherer = 795;

		[global::Cpp2ILInjected.Token(Token = "0x4005152")]
		public const short TendonBow = 796;

		[global::Cpp2ILInjected.Token(Token = "0x4005153")]
		public const short FleshGrinder = 797;

		[global::Cpp2ILInjected.Token(Token = "0x4005154")]
		public const short DeathbringerPickaxe = 798;

		[global::Cpp2ILInjected.Token(Token = "0x4005155")]
		public const short BloodLustCluster = 799;

		[global::Cpp2ILInjected.Token(Token = "0x4005156")]
		public const short TheUndertaker = 800;

		[global::Cpp2ILInjected.Token(Token = "0x4005157")]
		public const short TheMeatball = 801;

		[global::Cpp2ILInjected.Token(Token = "0x4005158")]
		public const short TheRottedFork = 802;

		[global::Cpp2ILInjected.Token(Token = "0x4005159")]
		public const short EskimoHood = 803;

		[global::Cpp2ILInjected.Token(Token = "0x400515A")]
		public const short EskimoCoat = 804;

		[global::Cpp2ILInjected.Token(Token = "0x400515B")]
		public const short EskimoPants = 805;

		[global::Cpp2ILInjected.Token(Token = "0x400515C")]
		public const short LivingWoodChair = 806;

		[global::Cpp2ILInjected.Token(Token = "0x400515D")]
		public const short CactusChair = 807;

		[global::Cpp2ILInjected.Token(Token = "0x400515E")]
		public const short BoneChair = 808;

		[global::Cpp2ILInjected.Token(Token = "0x400515F")]
		public const short FleshChair = 809;

		[global::Cpp2ILInjected.Token(Token = "0x4005160")]
		public const short MushroomChair = 810;

		[global::Cpp2ILInjected.Token(Token = "0x4005161")]
		public const short BoneWorkBench = 811;

		[global::Cpp2ILInjected.Token(Token = "0x4005162")]
		public const short CactusWorkBench = 812;

		[global::Cpp2ILInjected.Token(Token = "0x4005163")]
		public const short FleshWorkBench = 813;

		[global::Cpp2ILInjected.Token(Token = "0x4005164")]
		public const short MushroomWorkBench = 814;

		[global::Cpp2ILInjected.Token(Token = "0x4005165")]
		public const short SlimeWorkBench = 815;

		[global::Cpp2ILInjected.Token(Token = "0x4005166")]
		public const short CactusDoor = 816;

		[global::Cpp2ILInjected.Token(Token = "0x4005167")]
		public const short FleshDoor = 817;

		[global::Cpp2ILInjected.Token(Token = "0x4005168")]
		public const short MushroomDoor = 818;

		[global::Cpp2ILInjected.Token(Token = "0x4005169")]
		public const short LivingWoodDoor = 819;

		[global::Cpp2ILInjected.Token(Token = "0x400516A")]
		public const short BoneDoor = 820;

		[global::Cpp2ILInjected.Token(Token = "0x400516B")]
		public const short FlameWings = 821;

		[global::Cpp2ILInjected.Token(Token = "0x400516C")]
		public const short FrozenWings = 822;

		[global::Cpp2ILInjected.Token(Token = "0x400516D")]
		public const short GhostWings = 823;

		[global::Cpp2ILInjected.Token(Token = "0x400516E")]
		public const short SunplateBlock = 824;

		[global::Cpp2ILInjected.Token(Token = "0x400516F")]
		public const short DiscWall = 825;

		[global::Cpp2ILInjected.Token(Token = "0x4005170")]
		public const short SkywareChair = 826;

		[global::Cpp2ILInjected.Token(Token = "0x4005171")]
		public const short BoneTable = 827;

		[global::Cpp2ILInjected.Token(Token = "0x4005172")]
		public const short FleshTable = 828;

		[global::Cpp2ILInjected.Token(Token = "0x4005173")]
		public const short LivingWoodTable = 829;

		[global::Cpp2ILInjected.Token(Token = "0x4005174")]
		public const short SkywareTable = 830;

		[global::Cpp2ILInjected.Token(Token = "0x4005175")]
		public const short LivingWoodChest = 831;

		[global::Cpp2ILInjected.Token(Token = "0x4005176")]
		public const short LivingWoodWand = 832;

		[global::Cpp2ILInjected.Token(Token = "0x4005177")]
		public const short PurpleIceBlock = 833;

		[global::Cpp2ILInjected.Token(Token = "0x4005178")]
		public const short PinkIceBlock = 834;

		[global::Cpp2ILInjected.Token(Token = "0x4005179")]
		public const short RedIceBlock = 835;

		[global::Cpp2ILInjected.Token(Token = "0x400517A")]
		public const short CrimstoneBlock = 836;

		[global::Cpp2ILInjected.Token(Token = "0x400517B")]
		public const short SkywareDoor = 837;

		[global::Cpp2ILInjected.Token(Token = "0x400517C")]
		public const short SkywareChest = 838;

		[global::Cpp2ILInjected.Token(Token = "0x400517D")]
		public const short SteampunkHat = 839;

		[global::Cpp2ILInjected.Token(Token = "0x400517E")]
		public const short SteampunkShirt = 840;

		[global::Cpp2ILInjected.Token(Token = "0x400517F")]
		public const short SteampunkPants = 841;

		[global::Cpp2ILInjected.Token(Token = "0x4005180")]
		public const short BeeHat = 842;

		[global::Cpp2ILInjected.Token(Token = "0x4005181")]
		public const short BeeShirt = 843;

		[global::Cpp2ILInjected.Token(Token = "0x4005182")]
		public const short BeePants = 844;

		[global::Cpp2ILInjected.Token(Token = "0x4005183")]
		public const short WorldBanner = 845;

		[global::Cpp2ILInjected.Token(Token = "0x4005184")]
		public const short SunBanner = 846;

		[global::Cpp2ILInjected.Token(Token = "0x4005185")]
		public const short GravityBanner = 847;

		[global::Cpp2ILInjected.Token(Token = "0x4005186")]
		public const short PharaohsMask = 848;

		[global::Cpp2ILInjected.Token(Token = "0x4005187")]
		public const short Actuator = 849;

		[global::Cpp2ILInjected.Token(Token = "0x4005188")]
		public const short BlueWrench = 850;

		[global::Cpp2ILInjected.Token(Token = "0x4005189")]
		public const short GreenWrench = 851;

		[global::Cpp2ILInjected.Token(Token = "0x400518A")]
		public const short BluePressurePlate = 852;

		[global::Cpp2ILInjected.Token(Token = "0x400518B")]
		public const short YellowPressurePlate = 853;

		[global::Cpp2ILInjected.Token(Token = "0x400518C")]
		public const short DiscountCard = 854;

		[global::Cpp2ILInjected.Token(Token = "0x400518D")]
		public const short LuckyCoin = 855;

		[global::Cpp2ILInjected.Token(Token = "0x400518E")]
		public const short UnicornonaStick = 856;

		[global::Cpp2ILInjected.Token(Token = "0x400518F")]
		public const short SandstorminaBottle = 857;

		[global::Cpp2ILInjected.Token(Token = "0x4005190")]
		public const short BorealWoodSofa = 858;

		[global::Cpp2ILInjected.Token(Token = "0x4005191")]
		public const short BeachBall = 859;

		[global::Cpp2ILInjected.Token(Token = "0x4005192")]
		public const short CharmofMyths = 860;

		[global::Cpp2ILInjected.Token(Token = "0x4005193")]
		public const short MoonShell = 861;

		[global::Cpp2ILInjected.Token(Token = "0x4005194")]
		public const short StarVeil = 862;

		[global::Cpp2ILInjected.Token(Token = "0x4005195")]
		public const short WaterWalkingBoots = 863;

		[global::Cpp2ILInjected.Token(Token = "0x4005196")]
		public const short Tiara = 864;

		[global::Cpp2ILInjected.Token(Token = "0x4005197")]
		public const short PrincessDress = 865;

		[global::Cpp2ILInjected.Token(Token = "0x4005198")]
		public const short PharaohsRobe = 866;

		[global::Cpp2ILInjected.Token(Token = "0x4005199")]
		public const short GreenCap = 867;

		[global::Cpp2ILInjected.Token(Token = "0x400519A")]
		public const short MushroomCap = 868;

		[global::Cpp2ILInjected.Token(Token = "0x400519B")]
		public const short TamOShanter = 869;

		[global::Cpp2ILInjected.Token(Token = "0x400519C")]
		public const short MummyMask = 870;

		[global::Cpp2ILInjected.Token(Token = "0x400519D")]
		public const short MummyShirt = 871;

		[global::Cpp2ILInjected.Token(Token = "0x400519E")]
		public const short MummyPants = 872;

		[global::Cpp2ILInjected.Token(Token = "0x400519F")]
		public const short CowboyHat = 873;

		[global::Cpp2ILInjected.Token(Token = "0x40051A0")]
		public const short CowboyJacket = 874;

		[global::Cpp2ILInjected.Token(Token = "0x40051A1")]
		public const short CowboyPants = 875;

		[global::Cpp2ILInjected.Token(Token = "0x40051A2")]
		public const short PirateHat = 876;

		[global::Cpp2ILInjected.Token(Token = "0x40051A3")]
		public const short PirateShirt = 877;

		[global::Cpp2ILInjected.Token(Token = "0x40051A4")]
		public const short PiratePants = 878;

		[global::Cpp2ILInjected.Token(Token = "0x40051A5")]
		public const short VikingHelmet = 879;

		[global::Cpp2ILInjected.Token(Token = "0x40051A6")]
		public const short CrimtaneOre = 880;

		[global::Cpp2ILInjected.Token(Token = "0x40051A7")]
		public const short CactusSword = 881;

		[global::Cpp2ILInjected.Token(Token = "0x40051A8")]
		public const short CactusPickaxe = 882;

		[global::Cpp2ILInjected.Token(Token = "0x40051A9")]
		public const short IceBrick = 883;

		[global::Cpp2ILInjected.Token(Token = "0x40051AA")]
		public const short IceBrickWall = 884;

		[global::Cpp2ILInjected.Token(Token = "0x40051AB")]
		public const short AdhesiveBandage = 885;

		[global::Cpp2ILInjected.Token(Token = "0x40051AC")]
		public const short ArmorPolish = 886;

		[global::Cpp2ILInjected.Token(Token = "0x40051AD")]
		public const short Bezoar = 887;

		[global::Cpp2ILInjected.Token(Token = "0x40051AE")]
		public const short Blindfold = 888;

		[global::Cpp2ILInjected.Token(Token = "0x40051AF")]
		public const short FastClock = 889;

		[global::Cpp2ILInjected.Token(Token = "0x40051B0")]
		public const short Megaphone = 890;

		[global::Cpp2ILInjected.Token(Token = "0x40051B1")]
		public const short Nazar = 891;

		[global::Cpp2ILInjected.Token(Token = "0x40051B2")]
		public const short Vitamins = 892;

		[global::Cpp2ILInjected.Token(Token = "0x40051B3")]
		public const short TrifoldMap = 893;

		[global::Cpp2ILInjected.Token(Token = "0x40051B4")]
		public const short CactusHelmet = 894;

		[global::Cpp2ILInjected.Token(Token = "0x40051B5")]
		public const short CactusBreastplate = 895;

		[global::Cpp2ILInjected.Token(Token = "0x40051B6")]
		public const short CactusLeggings = 896;

		[global::Cpp2ILInjected.Token(Token = "0x40051B7")]
		public const short PowerGlove = 897;

		[global::Cpp2ILInjected.Token(Token = "0x40051B8")]
		public const short LightningBoots = 898;

		[global::Cpp2ILInjected.Token(Token = "0x40051B9")]
		public const short SunStone = 899;

		[global::Cpp2ILInjected.Token(Token = "0x40051BA")]
		public const short MoonStone = 900;

		[global::Cpp2ILInjected.Token(Token = "0x40051BB")]
		public const short ArmorBracing = 901;

		[global::Cpp2ILInjected.Token(Token = "0x40051BC")]
		public const short MedicatedBandage = 902;

		[global::Cpp2ILInjected.Token(Token = "0x40051BD")]
		public const short ThePlan = 903;

		[global::Cpp2ILInjected.Token(Token = "0x40051BE")]
		public const short CountercurseMantra = 904;

		[global::Cpp2ILInjected.Token(Token = "0x40051BF")]
		public const short CoinGun = 905;

		[global::Cpp2ILInjected.Token(Token = "0x40051C0")]
		public const short LavaCharm = 906;

		[global::Cpp2ILInjected.Token(Token = "0x40051C1")]
		public const short ObsidianWaterWalkingBoots = 907;

		[global::Cpp2ILInjected.Token(Token = "0x40051C2")]
		public const short LavaWaders = 908;

		[global::Cpp2ILInjected.Token(Token = "0x40051C3")]
		public const short PureWaterFountain = 909;

		[global::Cpp2ILInjected.Token(Token = "0x40051C4")]
		public const short DesertWaterFountain = 910;

		[global::Cpp2ILInjected.Token(Token = "0x40051C5")]
		public const short Shadewood = 911;

		[global::Cpp2ILInjected.Token(Token = "0x40051C6")]
		public const short ShadewoodDoor = 912;

		[global::Cpp2ILInjected.Token(Token = "0x40051C7")]
		public const short ShadewoodPlatform = 913;

		[global::Cpp2ILInjected.Token(Token = "0x40051C8")]
		public const short ShadewoodChest = 914;

		[global::Cpp2ILInjected.Token(Token = "0x40051C9")]
		public const short ShadewoodChair = 915;

		[global::Cpp2ILInjected.Token(Token = "0x40051CA")]
		public const short ShadewoodWorkBench = 916;

		[global::Cpp2ILInjected.Token(Token = "0x40051CB")]
		public const short ShadewoodTable = 917;

		[global::Cpp2ILInjected.Token(Token = "0x40051CC")]
		public const short ShadewoodDresser = 918;

		[global::Cpp2ILInjected.Token(Token = "0x40051CD")]
		public const short ShadewoodPiano = 919;

		[global::Cpp2ILInjected.Token(Token = "0x40051CE")]
		public const short ShadewoodBed = 920;

		[global::Cpp2ILInjected.Token(Token = "0x40051CF")]
		public const short ShadewoodSword = 921;

		[global::Cpp2ILInjected.Token(Token = "0x40051D0")]
		public const short ShadewoodHammer = 922;

		[global::Cpp2ILInjected.Token(Token = "0x40051D1")]
		public const short ShadewoodBow = 923;

		[global::Cpp2ILInjected.Token(Token = "0x40051D2")]
		public const short ShadewoodHelmet = 924;

		[global::Cpp2ILInjected.Token(Token = "0x40051D3")]
		public const short ShadewoodBreastplate = 925;

		[global::Cpp2ILInjected.Token(Token = "0x40051D4")]
		public const short ShadewoodGreaves = 926;

		[global::Cpp2ILInjected.Token(Token = "0x40051D5")]
		public const short ShadewoodWall = 927;

		[global::Cpp2ILInjected.Token(Token = "0x40051D6")]
		public const short Cannon = 928;

		[global::Cpp2ILInjected.Token(Token = "0x40051D7")]
		public const short Cannonball = 929;

		[global::Cpp2ILInjected.Token(Token = "0x40051D8")]
		public const short FlareGun = 930;

		[global::Cpp2ILInjected.Token(Token = "0x40051D9")]
		public const short Flare = 931;

		[global::Cpp2ILInjected.Token(Token = "0x40051DA")]
		public const short BoneWand = 932;

		[global::Cpp2ILInjected.Token(Token = "0x40051DB")]
		public const short LeafWand = 933;

		[global::Cpp2ILInjected.Token(Token = "0x40051DC")]
		public const short FlyingCarpet = 934;

		[global::Cpp2ILInjected.Token(Token = "0x40051DD")]
		public const short AvengerEmblem = 935;

		[global::Cpp2ILInjected.Token(Token = "0x40051DE")]
		public const short MechanicalGlove = 936;

		[global::Cpp2ILInjected.Token(Token = "0x40051DF")]
		public const short LandMine = 937;

		[global::Cpp2ILInjected.Token(Token = "0x40051E0")]
		public const short PaladinsShield = 938;

		[global::Cpp2ILInjected.Token(Token = "0x40051E1")]
		public const short WebSlinger = 939;

		[global::Cpp2ILInjected.Token(Token = "0x40051E2")]
		public const short JungleWaterFountain = 940;

		[global::Cpp2ILInjected.Token(Token = "0x40051E3")]
		public const short IcyWaterFountain = 941;

		[global::Cpp2ILInjected.Token(Token = "0x40051E4")]
		public const short CorruptWaterFountain = 942;

		[global::Cpp2ILInjected.Token(Token = "0x40051E5")]
		public const short CrimsonWaterFountain = 943;

		[global::Cpp2ILInjected.Token(Token = "0x40051E6")]
		public const short HallowedWaterFountain = 944;

		[global::Cpp2ILInjected.Token(Token = "0x40051E7")]
		public const short BloodWaterFountain = 945;

		[global::Cpp2ILInjected.Token(Token = "0x40051E8")]
		public const short Umbrella = 946;

		[global::Cpp2ILInjected.Token(Token = "0x40051E9")]
		public const short ChlorophyteOre = 947;

		[global::Cpp2ILInjected.Token(Token = "0x40051EA")]
		public const short SteampunkWings = 948;

		[global::Cpp2ILInjected.Token(Token = "0x40051EB")]
		public const short Snowball = 949;

		[global::Cpp2ILInjected.Token(Token = "0x40051EC")]
		public const short IceSkates = 950;

		[global::Cpp2ILInjected.Token(Token = "0x40051ED")]
		public const short SnowballLauncher = 951;

		[global::Cpp2ILInjected.Token(Token = "0x40051EE")]
		public const short WebCoveredChest = 952;

		[global::Cpp2ILInjected.Token(Token = "0x40051EF")]
		public const short ClimbingClaws = 953;

		[global::Cpp2ILInjected.Token(Token = "0x40051F0")]
		public const short AncientIronHelmet = 954;

		[global::Cpp2ILInjected.Token(Token = "0x40051F1")]
		public const short AncientGoldHelmet = 955;

		[global::Cpp2ILInjected.Token(Token = "0x40051F2")]
		public const short AncientShadowHelmet = 956;

		[global::Cpp2ILInjected.Token(Token = "0x40051F3")]
		public const short AncientShadowScalemail = 957;

		[global::Cpp2ILInjected.Token(Token = "0x40051F4")]
		public const short AncientShadowGreaves = 958;

		[global::Cpp2ILInjected.Token(Token = "0x40051F5")]
		public const short AncientNecroHelmet = 959;

		[global::Cpp2ILInjected.Token(Token = "0x40051F6")]
		public const short AncientCobaltHelmet = 960;

		[global::Cpp2ILInjected.Token(Token = "0x40051F7")]
		public const short AncientCobaltBreastplate = 961;

		[global::Cpp2ILInjected.Token(Token = "0x40051F8")]
		public const short AncientCobaltLeggings = 962;

		[global::Cpp2ILInjected.Token(Token = "0x40051F9")]
		public const short BlackBelt = 963;

		[global::Cpp2ILInjected.Token(Token = "0x40051FA")]
		public const short Boomstick = 964;

		[global::Cpp2ILInjected.Token(Token = "0x40051FB")]
		public const short Rope = 965;

		[global::Cpp2ILInjected.Token(Token = "0x40051FC")]
		public const short Campfire = 966;

		[global::Cpp2ILInjected.Token(Token = "0x40051FD")]
		public const short Marshmallow = 967;

		[global::Cpp2ILInjected.Token(Token = "0x40051FE")]
		public const short MarshmallowonaStick = 968;

		[global::Cpp2ILInjected.Token(Token = "0x40051FF")]
		public const short CookedMarshmallow = 969;

		[global::Cpp2ILInjected.Token(Token = "0x4005200")]
		public const short RedRocket = 970;

		[global::Cpp2ILInjected.Token(Token = "0x4005201")]
		public const short GreenRocket = 971;

		[global::Cpp2ILInjected.Token(Token = "0x4005202")]
		public const short BlueRocket = 972;

		[global::Cpp2ILInjected.Token(Token = "0x4005203")]
		public const short YellowRocket = 973;

		[global::Cpp2ILInjected.Token(Token = "0x4005204")]
		public const short IceTorch = 974;

		[global::Cpp2ILInjected.Token(Token = "0x4005205")]
		public const short ShoeSpikes = 975;

		[global::Cpp2ILInjected.Token(Token = "0x4005206")]
		public const short TigerClimbingGear = 976;

		[global::Cpp2ILInjected.Token(Token = "0x4005207")]
		public const short Tabi = 977;

		[global::Cpp2ILInjected.Token(Token = "0x4005208")]
		public const short PinkEskimoHood = 978;

		[global::Cpp2ILInjected.Token(Token = "0x4005209")]
		public const short PinkEskimoCoat = 979;

		[global::Cpp2ILInjected.Token(Token = "0x400520A")]
		public const short PinkEskimoPants = 980;

		[global::Cpp2ILInjected.Token(Token = "0x400520B")]
		public const short PinkThread = 981;

		[global::Cpp2ILInjected.Token(Token = "0x400520C")]
		public const short ManaRegenerationBand = 982;

		[global::Cpp2ILInjected.Token(Token = "0x400520D")]
		public const short SandstorminaBalloon = 983;

		[global::Cpp2ILInjected.Token(Token = "0x400520E")]
		public const short MasterNinjaGear = 984;

		[global::Cpp2ILInjected.Token(Token = "0x400520F")]
		public const short RopeCoil = 985;

		[global::Cpp2ILInjected.Token(Token = "0x4005210")]
		public const short Blowgun = 986;

		[global::Cpp2ILInjected.Token(Token = "0x4005211")]
		public const short BlizzardinaBottle = 987;

		[global::Cpp2ILInjected.Token(Token = "0x4005212")]
		public const short FrostburnArrow = 988;

		[global::Cpp2ILInjected.Token(Token = "0x4005213")]
		public const short EnchantedSword = 989;

		[global::Cpp2ILInjected.Token(Token = "0x4005214")]
		public const short PickaxeAxe = 990;

		[global::Cpp2ILInjected.Token(Token = "0x4005215")]
		public const short CobaltWaraxe = 991;

		[global::Cpp2ILInjected.Token(Token = "0x4005216")]
		public const short MythrilWaraxe = 992;

		[global::Cpp2ILInjected.Token(Token = "0x4005217")]
		public const short AdamantiteWaraxe = 993;

		[global::Cpp2ILInjected.Token(Token = "0x4005218")]
		public const short EatersBone = 994;

		[global::Cpp2ILInjected.Token(Token = "0x4005219")]
		public const short BlendOMatic = 995;

		[global::Cpp2ILInjected.Token(Token = "0x400521A")]
		public const short MeatGrinder = 996;

		[global::Cpp2ILInjected.Token(Token = "0x400521B")]
		public const short Extractinator = 997;

		[global::Cpp2ILInjected.Token(Token = "0x400521C")]
		public const short Solidifier = 998;

		[global::Cpp2ILInjected.Token(Token = "0x400521D")]
		public const short Amber = 999;

		[global::Cpp2ILInjected.Token(Token = "0x400521E")]
		public const short ConfettiGun = 1000;

		[global::Cpp2ILInjected.Token(Token = "0x400521F")]
		public const short ChlorophyteMask = 1001;

		[global::Cpp2ILInjected.Token(Token = "0x4005220")]
		public const short ChlorophyteHelmet = 1002;

		[global::Cpp2ILInjected.Token(Token = "0x4005221")]
		public const short ChlorophyteHeadgear = 1003;

		[global::Cpp2ILInjected.Token(Token = "0x4005222")]
		public const short ChlorophytePlateMail = 1004;

		[global::Cpp2ILInjected.Token(Token = "0x4005223")]
		public const short ChlorophyteGreaves = 1005;

		[global::Cpp2ILInjected.Token(Token = "0x4005224")]
		public const short ChlorophyteBar = 1006;

		[global::Cpp2ILInjected.Token(Token = "0x4005225")]
		public const short RedDye = 1007;

		[global::Cpp2ILInjected.Token(Token = "0x4005226")]
		public const short OrangeDye = 1008;

		[global::Cpp2ILInjected.Token(Token = "0x4005227")]
		public const short YellowDye = 1009;

		[global::Cpp2ILInjected.Token(Token = "0x4005228")]
		public const short LimeDye = 1010;

		[global::Cpp2ILInjected.Token(Token = "0x4005229")]
		public const short GreenDye = 1011;

		[global::Cpp2ILInjected.Token(Token = "0x400522A")]
		public const short TealDye = 1012;

		[global::Cpp2ILInjected.Token(Token = "0x400522B")]
		public const short CyanDye = 1013;

		[global::Cpp2ILInjected.Token(Token = "0x400522C")]
		public const short SkyBlueDye = 1014;

		[global::Cpp2ILInjected.Token(Token = "0x400522D")]
		public const short BlueDye = 1015;

		[global::Cpp2ILInjected.Token(Token = "0x400522E")]
		public const short PurpleDye = 1016;

		[global::Cpp2ILInjected.Token(Token = "0x400522F")]
		public const short VioletDye = 1017;

		[global::Cpp2ILInjected.Token(Token = "0x4005230")]
		public const short PinkDye = 1018;

		[global::Cpp2ILInjected.Token(Token = "0x4005231")]
		public const short RedandBlackDye = 1019;

		[global::Cpp2ILInjected.Token(Token = "0x4005232")]
		public const short OrangeandBlackDye = 1020;

		[global::Cpp2ILInjected.Token(Token = "0x4005233")]
		public const short YellowandBlackDye = 1021;

		[global::Cpp2ILInjected.Token(Token = "0x4005234")]
		public const short LimeandBlackDye = 1022;

		[global::Cpp2ILInjected.Token(Token = "0x4005235")]
		public const short GreenandBlackDye = 1023;

		[global::Cpp2ILInjected.Token(Token = "0x4005236")]
		public const short TealandBlackDye = 1024;

		[global::Cpp2ILInjected.Token(Token = "0x4005237")]
		public const short CyanandBlackDye = 1025;

		[global::Cpp2ILInjected.Token(Token = "0x4005238")]
		public const short SkyBlueandBlackDye = 1026;

		[global::Cpp2ILInjected.Token(Token = "0x4005239")]
		public const short BlueandBlackDye = 1027;

		[global::Cpp2ILInjected.Token(Token = "0x400523A")]
		public const short PurpleandBlackDye = 1028;

		[global::Cpp2ILInjected.Token(Token = "0x400523B")]
		public const short VioletandBlackDye = 1029;

		[global::Cpp2ILInjected.Token(Token = "0x400523C")]
		public const short PinkandBlackDye = 1030;

		[global::Cpp2ILInjected.Token(Token = "0x400523D")]
		public const short FlameDye = 1031;

		[global::Cpp2ILInjected.Token(Token = "0x400523E")]
		public const short FlameAndBlackDye = 1032;

		[global::Cpp2ILInjected.Token(Token = "0x400523F")]
		public const short GreenFlameDye = 1033;

		[global::Cpp2ILInjected.Token(Token = "0x4005240")]
		public const short GreenFlameAndBlackDye = 1034;

		[global::Cpp2ILInjected.Token(Token = "0x4005241")]
		public const short BlueFlameDye = 1035;

		[global::Cpp2ILInjected.Token(Token = "0x4005242")]
		public const short BlueFlameAndBlackDye = 1036;

		[global::Cpp2ILInjected.Token(Token = "0x4005243")]
		public const short SilverDye = 1037;

		[global::Cpp2ILInjected.Token(Token = "0x4005244")]
		public const short BrightRedDye = 1038;

		[global::Cpp2ILInjected.Token(Token = "0x4005245")]
		public const short BrightOrangeDye = 1039;

		[global::Cpp2ILInjected.Token(Token = "0x4005246")]
		public const short BrightYellowDye = 1040;

		[global::Cpp2ILInjected.Token(Token = "0x4005247")]
		public const short BrightLimeDye = 1041;

		[global::Cpp2ILInjected.Token(Token = "0x4005248")]
		public const short BrightGreenDye = 1042;

		[global::Cpp2ILInjected.Token(Token = "0x4005249")]
		public const short BrightTealDye = 1043;

		[global::Cpp2ILInjected.Token(Token = "0x400524A")]
		public const short BrightCyanDye = 1044;

		[global::Cpp2ILInjected.Token(Token = "0x400524B")]
		public const short BrightSkyBlueDye = 1045;

		[global::Cpp2ILInjected.Token(Token = "0x400524C")]
		public const short BrightBlueDye = 1046;

		[global::Cpp2ILInjected.Token(Token = "0x400524D")]
		public const short BrightPurpleDye = 1047;

		[global::Cpp2ILInjected.Token(Token = "0x400524E")]
		public const short BrightVioletDye = 1048;

		[global::Cpp2ILInjected.Token(Token = "0x400524F")]
		public const short BrightPinkDye = 1049;

		[global::Cpp2ILInjected.Token(Token = "0x4005250")]
		public const short BlackDye = 1050;

		[global::Cpp2ILInjected.Token(Token = "0x4005251")]
		public const short RedandSilverDye = 1051;

		[global::Cpp2ILInjected.Token(Token = "0x4005252")]
		public const short OrangeandSilverDye = 1052;

		[global::Cpp2ILInjected.Token(Token = "0x4005253")]
		public const short YellowandSilverDye = 1053;

		[global::Cpp2ILInjected.Token(Token = "0x4005254")]
		public const short LimeandSilverDye = 1054;

		[global::Cpp2ILInjected.Token(Token = "0x4005255")]
		public const short GreenandSilverDye = 1055;

		[global::Cpp2ILInjected.Token(Token = "0x4005256")]
		public const short TealandSilverDye = 1056;

		[global::Cpp2ILInjected.Token(Token = "0x4005257")]
		public const short CyanandSilverDye = 1057;

		[global::Cpp2ILInjected.Token(Token = "0x4005258")]
		public const short SkyBlueandSilverDye = 1058;

		[global::Cpp2ILInjected.Token(Token = "0x4005259")]
		public const short BlueandSilverDye = 1059;

		[global::Cpp2ILInjected.Token(Token = "0x400525A")]
		public const short PurpleandSilverDye = 1060;

		[global::Cpp2ILInjected.Token(Token = "0x400525B")]
		public const short VioletandSilverDye = 1061;

		[global::Cpp2ILInjected.Token(Token = "0x400525C")]
		public const short PinkandSilverDye = 1062;

		[global::Cpp2ILInjected.Token(Token = "0x400525D")]
		public const short IntenseFlameDye = 1063;

		[global::Cpp2ILInjected.Token(Token = "0x400525E")]
		public const short IntenseGreenFlameDye = 1064;

		[global::Cpp2ILInjected.Token(Token = "0x400525F")]
		public const short IntenseBlueFlameDye = 1065;

		[global::Cpp2ILInjected.Token(Token = "0x4005260")]
		public const short RainbowDye = 1066;

		[global::Cpp2ILInjected.Token(Token = "0x4005261")]
		public const short IntenseRainbowDye = 1067;

		[global::Cpp2ILInjected.Token(Token = "0x4005262")]
		public const short YellowGradientDye = 1068;

		[global::Cpp2ILInjected.Token(Token = "0x4005263")]
		public const short CyanGradientDye = 1069;

		[global::Cpp2ILInjected.Token(Token = "0x4005264")]
		public const short VioletGradientDye = 1070;

		[global::Cpp2ILInjected.Token(Token = "0x4005265")]
		public const short Paintbrush = 1071;

		[global::Cpp2ILInjected.Token(Token = "0x4005266")]
		public const short PaintRoller = 1072;

		[global::Cpp2ILInjected.Token(Token = "0x4005267")]
		public const short RedPaint = 1073;

		[global::Cpp2ILInjected.Token(Token = "0x4005268")]
		public const short OrangePaint = 1074;

		[global::Cpp2ILInjected.Token(Token = "0x4005269")]
		public const short YellowPaint = 1075;

		[global::Cpp2ILInjected.Token(Token = "0x400526A")]
		public const short LimePaint = 1076;

		[global::Cpp2ILInjected.Token(Token = "0x400526B")]
		public const short GreenPaint = 1077;

		[global::Cpp2ILInjected.Token(Token = "0x400526C")]
		public const short TealPaint = 1078;

		[global::Cpp2ILInjected.Token(Token = "0x400526D")]
		public const short CyanPaint = 1079;

		[global::Cpp2ILInjected.Token(Token = "0x400526E")]
		public const short SkyBluePaint = 1080;

		[global::Cpp2ILInjected.Token(Token = "0x400526F")]
		public const short BluePaint = 1081;

		[global::Cpp2ILInjected.Token(Token = "0x4005270")]
		public const short PurplePaint = 1082;

		[global::Cpp2ILInjected.Token(Token = "0x4005271")]
		public const short VioletPaint = 1083;

		[global::Cpp2ILInjected.Token(Token = "0x4005272")]
		public const short PinkPaint = 1084;

		[global::Cpp2ILInjected.Token(Token = "0x4005273")]
		public const short DeepRedPaint = 1085;

		[global::Cpp2ILInjected.Token(Token = "0x4005274")]
		public const short DeepOrangePaint = 1086;

		[global::Cpp2ILInjected.Token(Token = "0x4005275")]
		public const short DeepYellowPaint = 1087;

		[global::Cpp2ILInjected.Token(Token = "0x4005276")]
		public const short DeepLimePaint = 1088;

		[global::Cpp2ILInjected.Token(Token = "0x4005277")]
		public const short DeepGreenPaint = 1089;

		[global::Cpp2ILInjected.Token(Token = "0x4005278")]
		public const short DeepTealPaint = 1090;

		[global::Cpp2ILInjected.Token(Token = "0x4005279")]
		public const short DeepCyanPaint = 1091;

		[global::Cpp2ILInjected.Token(Token = "0x400527A")]
		public const short DeepSkyBluePaint = 1092;

		[global::Cpp2ILInjected.Token(Token = "0x400527B")]
		public const short DeepBluePaint = 1093;

		[global::Cpp2ILInjected.Token(Token = "0x400527C")]
		public const short DeepPurplePaint = 1094;

		[global::Cpp2ILInjected.Token(Token = "0x400527D")]
		public const short DeepVioletPaint = 1095;

		[global::Cpp2ILInjected.Token(Token = "0x400527E")]
		public const short DeepPinkPaint = 1096;

		[global::Cpp2ILInjected.Token(Token = "0x400527F")]
		public const short BlackPaint = 1097;

		[global::Cpp2ILInjected.Token(Token = "0x4005280")]
		public const short WhitePaint = 1098;

		[global::Cpp2ILInjected.Token(Token = "0x4005281")]
		public const short GrayPaint = 1099;

		[global::Cpp2ILInjected.Token(Token = "0x4005282")]
		public const short PaintScraper = 1100;

		[global::Cpp2ILInjected.Token(Token = "0x4005283")]
		public const short LihzahrdBrick = 1101;

		[global::Cpp2ILInjected.Token(Token = "0x4005284")]
		public const short LihzahrdBrickWall = 1102;

		[global::Cpp2ILInjected.Token(Token = "0x4005285")]
		public const short SlushBlock = 1103;

		[global::Cpp2ILInjected.Token(Token = "0x4005286")]
		public const short PalladiumOre = 1104;

		[global::Cpp2ILInjected.Token(Token = "0x4005287")]
		public const short OrichalcumOre = 1105;

		[global::Cpp2ILInjected.Token(Token = "0x4005288")]
		public const short TitaniumOre = 1106;

		[global::Cpp2ILInjected.Token(Token = "0x4005289")]
		public const short TealMushroom = 1107;

		[global::Cpp2ILInjected.Token(Token = "0x400528A")]
		public const short GreenMushroom = 1108;

		[global::Cpp2ILInjected.Token(Token = "0x400528B")]
		public const short SkyBlueFlower = 1109;

		[global::Cpp2ILInjected.Token(Token = "0x400528C")]
		public const short YellowMarigold = 1110;

		[global::Cpp2ILInjected.Token(Token = "0x400528D")]
		public const short BlueBerries = 1111;

		[global::Cpp2ILInjected.Token(Token = "0x400528E")]
		public const short LimeKelp = 1112;

		[global::Cpp2ILInjected.Token(Token = "0x400528F")]
		public const short PinkPricklyPear = 1113;

		[global::Cpp2ILInjected.Token(Token = "0x4005290")]
		public const short OrangeBloodroot = 1114;

		[global::Cpp2ILInjected.Token(Token = "0x4005291")]
		public const short RedHusk = 1115;

		[global::Cpp2ILInjected.Token(Token = "0x4005292")]
		public const short CyanHusk = 1116;

		[global::Cpp2ILInjected.Token(Token = "0x4005293")]
		public const short VioletHusk = 1117;

		[global::Cpp2ILInjected.Token(Token = "0x4005294")]
		public const short PurpleMucos = 1118;

		[global::Cpp2ILInjected.Token(Token = "0x4005295")]
		public const short BlackInk = 1119;

		[global::Cpp2ILInjected.Token(Token = "0x4005296")]
		public const short DyeVat = 1120;

		[global::Cpp2ILInjected.Token(Token = "0x4005297")]
		public const short BeeGun = 1121;

		[global::Cpp2ILInjected.Token(Token = "0x4005298")]
		public const short PossessedHatchet = 1122;

		[global::Cpp2ILInjected.Token(Token = "0x4005299")]
		public const short BeeKeeper = 1123;

		[global::Cpp2ILInjected.Token(Token = "0x400529A")]
		public const short Hive = 1124;

		[global::Cpp2ILInjected.Token(Token = "0x400529B")]
		public const short HoneyBlock = 1125;

		[global::Cpp2ILInjected.Token(Token = "0x400529C")]
		public const short HiveWall = 1126;

		[global::Cpp2ILInjected.Token(Token = "0x400529D")]
		public const short CrispyHoneyBlock = 1127;

		[global::Cpp2ILInjected.Token(Token = "0x400529E")]
		public const short HoneyBucket = 1128;

		[global::Cpp2ILInjected.Token(Token = "0x400529F")]
		public const short HiveWand = 1129;

		[global::Cpp2ILInjected.Token(Token = "0x40052A0")]
		public const short Beenade = 1130;

		[global::Cpp2ILInjected.Token(Token = "0x40052A1")]
		public const short GravityGlobe = 1131;

		[global::Cpp2ILInjected.Token(Token = "0x40052A2")]
		public const short HoneyComb = 1132;

		[global::Cpp2ILInjected.Token(Token = "0x40052A3")]
		public const short Abeemination = 1133;

		[global::Cpp2ILInjected.Token(Token = "0x40052A4")]
		public const short BottledHoney = 1134;

		[global::Cpp2ILInjected.Token(Token = "0x40052A5")]
		public const short RainHat = 1135;

		[global::Cpp2ILInjected.Token(Token = "0x40052A6")]
		public const short RainCoat = 1136;

		[global::Cpp2ILInjected.Token(Token = "0x40052A7")]
		public const short LihzahrdDoor = 1137;

		[global::Cpp2ILInjected.Token(Token = "0x40052A8")]
		public const short DungeonDoor = 1138;

		[global::Cpp2ILInjected.Token(Token = "0x40052A9")]
		public const short LeadDoor = 1139;

		[global::Cpp2ILInjected.Token(Token = "0x40052AA")]
		public const short IronDoor = 1140;

		[global::Cpp2ILInjected.Token(Token = "0x40052AB")]
		public const short TempleKey = 1141;

		[global::Cpp2ILInjected.Token(Token = "0x40052AC")]
		public const short LihzahrdChest = 1142;

		[global::Cpp2ILInjected.Token(Token = "0x40052AD")]
		public const short LihzahrdChair = 1143;

		[global::Cpp2ILInjected.Token(Token = "0x40052AE")]
		public const short LihzahrdTable = 1144;

		[global::Cpp2ILInjected.Token(Token = "0x40052AF")]
		public const short LihzahrdWorkBench = 1145;

		[global::Cpp2ILInjected.Token(Token = "0x40052B0")]
		public const short SuperDartTrap = 1146;

		[global::Cpp2ILInjected.Token(Token = "0x40052B1")]
		public const short FlameTrap = 1147;

		[global::Cpp2ILInjected.Token(Token = "0x40052B2")]
		public const short SpikyBallTrap = 1148;

		[global::Cpp2ILInjected.Token(Token = "0x40052B3")]
		public const short SpearTrap = 1149;

		[global::Cpp2ILInjected.Token(Token = "0x40052B4")]
		public const short WoodenSpike = 1150;

		[global::Cpp2ILInjected.Token(Token = "0x40052B5")]
		public const short LihzahrdPressurePlate = 1151;

		[global::Cpp2ILInjected.Token(Token = "0x40052B6")]
		public const short LihzahrdStatue = 1152;

		[global::Cpp2ILInjected.Token(Token = "0x40052B7")]
		public const short LihzahrdWatcherStatue = 1153;

		[global::Cpp2ILInjected.Token(Token = "0x40052B8")]
		public const short LihzahrdGuardianStatue = 1154;

		[global::Cpp2ILInjected.Token(Token = "0x40052B9")]
		public const short WaspGun = 1155;

		[global::Cpp2ILInjected.Token(Token = "0x40052BA")]
		public const short PiranhaGun = 1156;

		[global::Cpp2ILInjected.Token(Token = "0x40052BB")]
		public const short PygmyStaff = 1157;

		[global::Cpp2ILInjected.Token(Token = "0x40052BC")]
		public const short PygmyNecklace = 1158;

		[global::Cpp2ILInjected.Token(Token = "0x40052BD")]
		public const short TikiMask = 1159;

		[global::Cpp2ILInjected.Token(Token = "0x40052BE")]
		public const short TikiShirt = 1160;

		[global::Cpp2ILInjected.Token(Token = "0x40052BF")]
		public const short TikiPants = 1161;

		[global::Cpp2ILInjected.Token(Token = "0x40052C0")]
		public const short LeafWings = 1162;

		[global::Cpp2ILInjected.Token(Token = "0x40052C1")]
		public const short BlizzardinaBalloon = 1163;

		[global::Cpp2ILInjected.Token(Token = "0x40052C2")]
		public const short BundleofBalloons = 1164;

		[global::Cpp2ILInjected.Token(Token = "0x40052C3")]
		public const short BatWings = 1165;

		[global::Cpp2ILInjected.Token(Token = "0x40052C4")]
		public const short BoneSword = 1166;

		[global::Cpp2ILInjected.Token(Token = "0x40052C5")]
		public const short HerculesBeetle = 1167;

		[global::Cpp2ILInjected.Token(Token = "0x40052C6")]
		public const short SmokeBomb = 1168;

		[global::Cpp2ILInjected.Token(Token = "0x40052C7")]
		public const short BoneKey = 1169;

		[global::Cpp2ILInjected.Token(Token = "0x40052C8")]
		public const short Nectar = 1170;

		[global::Cpp2ILInjected.Token(Token = "0x40052C9")]
		public const short TikiTotem = 1171;

		[global::Cpp2ILInjected.Token(Token = "0x40052CA")]
		public const short LizardEgg = 1172;

		[global::Cpp2ILInjected.Token(Token = "0x40052CB")]
		public const short GraveMarker = 1173;

		[global::Cpp2ILInjected.Token(Token = "0x40052CC")]
		public const short CrossGraveMarker = 1174;

		[global::Cpp2ILInjected.Token(Token = "0x40052CD")]
		public const short Headstone = 1175;

		[global::Cpp2ILInjected.Token(Token = "0x40052CE")]
		public const short Gravestone = 1176;

		[global::Cpp2ILInjected.Token(Token = "0x40052CF")]
		public const short Obelisk = 1177;

		[global::Cpp2ILInjected.Token(Token = "0x40052D0")]
		public const short LeafBlower = 1178;

		[global::Cpp2ILInjected.Token(Token = "0x40052D1")]
		public const short ChlorophyteBullet = 1179;

		[global::Cpp2ILInjected.Token(Token = "0x40052D2")]
		public const short ParrotCracker = 1180;

		[global::Cpp2ILInjected.Token(Token = "0x40052D3")]
		public const short StrangeGlowingMushroom = 1181;

		[global::Cpp2ILInjected.Token(Token = "0x40052D4")]
		public const short Seedling = 1182;

		[global::Cpp2ILInjected.Token(Token = "0x40052D5")]
		public const short WispinaBottle = 1183;

		[global::Cpp2ILInjected.Token(Token = "0x40052D6")]
		public const short PalladiumBar = 1184;

		[global::Cpp2ILInjected.Token(Token = "0x40052D7")]
		public const short PalladiumSword = 1185;

		[global::Cpp2ILInjected.Token(Token = "0x40052D8")]
		public const short PalladiumPike = 1186;

		[global::Cpp2ILInjected.Token(Token = "0x40052D9")]
		public const short PalladiumRepeater = 1187;

		[global::Cpp2ILInjected.Token(Token = "0x40052DA")]
		public const short PalladiumPickaxe = 1188;

		[global::Cpp2ILInjected.Token(Token = "0x40052DB")]
		public const short PalladiumDrill = 1189;

		[global::Cpp2ILInjected.Token(Token = "0x40052DC")]
		public const short PalladiumChainsaw = 1190;

		[global::Cpp2ILInjected.Token(Token = "0x40052DD")]
		public const short OrichalcumBar = 1191;

		[global::Cpp2ILInjected.Token(Token = "0x40052DE")]
		public const short OrichalcumSword = 1192;

		[global::Cpp2ILInjected.Token(Token = "0x40052DF")]
		public const short OrichalcumHalberd = 1193;

		[global::Cpp2ILInjected.Token(Token = "0x40052E0")]
		public const short OrichalcumRepeater = 1194;

		[global::Cpp2ILInjected.Token(Token = "0x40052E1")]
		public const short OrichalcumPickaxe = 1195;

		[global::Cpp2ILInjected.Token(Token = "0x40052E2")]
		public const short OrichalcumDrill = 1196;

		[global::Cpp2ILInjected.Token(Token = "0x40052E3")]
		public const short OrichalcumChainsaw = 1197;

		[global::Cpp2ILInjected.Token(Token = "0x40052E4")]
		public const short TitaniumBar = 1198;

		[global::Cpp2ILInjected.Token(Token = "0x40052E5")]
		public const short TitaniumSword = 1199;

		[global::Cpp2ILInjected.Token(Token = "0x40052E6")]
		public const short TitaniumTrident = 1200;

		[global::Cpp2ILInjected.Token(Token = "0x40052E7")]
		public const short TitaniumRepeater = 1201;

		[global::Cpp2ILInjected.Token(Token = "0x40052E8")]
		public const short TitaniumPickaxe = 1202;

		[global::Cpp2ILInjected.Token(Token = "0x40052E9")]
		public const short TitaniumDrill = 1203;

		[global::Cpp2ILInjected.Token(Token = "0x40052EA")]
		public const short TitaniumChainsaw = 1204;

		[global::Cpp2ILInjected.Token(Token = "0x40052EB")]
		public const short PalladiumMask = 1205;

		[global::Cpp2ILInjected.Token(Token = "0x40052EC")]
		public const short PalladiumHelmet = 1206;

		[global::Cpp2ILInjected.Token(Token = "0x40052ED")]
		public const short PalladiumHeadgear = 1207;

		[global::Cpp2ILInjected.Token(Token = "0x40052EE")]
		public const short PalladiumBreastplate = 1208;

		[global::Cpp2ILInjected.Token(Token = "0x40052EF")]
		public const short PalladiumLeggings = 1209;

		[global::Cpp2ILInjected.Token(Token = "0x40052F0")]
		public const short OrichalcumMask = 1210;

		[global::Cpp2ILInjected.Token(Token = "0x40052F1")]
		public const short OrichalcumHelmet = 1211;

		[global::Cpp2ILInjected.Token(Token = "0x40052F2")]
		public const short OrichalcumHeadgear = 1212;

		[global::Cpp2ILInjected.Token(Token = "0x40052F3")]
		public const short OrichalcumBreastplate = 1213;

		[global::Cpp2ILInjected.Token(Token = "0x40052F4")]
		public const short OrichalcumLeggings = 1214;

		[global::Cpp2ILInjected.Token(Token = "0x40052F5")]
		public const short TitaniumMask = 1215;

		[global::Cpp2ILInjected.Token(Token = "0x40052F6")]
		public const short TitaniumHelmet = 1216;

		[global::Cpp2ILInjected.Token(Token = "0x40052F7")]
		public const short TitaniumHeadgear = 1217;

		[global::Cpp2ILInjected.Token(Token = "0x40052F8")]
		public const short TitaniumBreastplate = 1218;

		[global::Cpp2ILInjected.Token(Token = "0x40052F9")]
		public const short TitaniumLeggings = 1219;

		[global::Cpp2ILInjected.Token(Token = "0x40052FA")]
		public const short OrichalcumAnvil = 1220;

		[global::Cpp2ILInjected.Token(Token = "0x40052FB")]
		public const short TitaniumForge = 1221;

		[global::Cpp2ILInjected.Token(Token = "0x40052FC")]
		public const short PalladiumWaraxe = 1222;

		[global::Cpp2ILInjected.Token(Token = "0x40052FD")]
		public const short OrichalcumWaraxe = 1223;

		[global::Cpp2ILInjected.Token(Token = "0x40052FE")]
		public const short TitaniumWaraxe = 1224;

		[global::Cpp2ILInjected.Token(Token = "0x40052FF")]
		public const short HallowedBar = 1225;

		[global::Cpp2ILInjected.Token(Token = "0x4005300")]
		public const short ChlorophyteClaymore = 1226;

		[global::Cpp2ILInjected.Token(Token = "0x4005301")]
		public const short ChlorophyteSaber = 1227;

		[global::Cpp2ILInjected.Token(Token = "0x4005302")]
		public const short ChlorophytePartisan = 1228;

		[global::Cpp2ILInjected.Token(Token = "0x4005303")]
		public const short ChlorophyteShotbow = 1229;

		[global::Cpp2ILInjected.Token(Token = "0x4005304")]
		public const short ChlorophytePickaxe = 1230;

		[global::Cpp2ILInjected.Token(Token = "0x4005305")]
		public const short ChlorophyteDrill = 1231;

		[global::Cpp2ILInjected.Token(Token = "0x4005306")]
		public const short ChlorophyteChainsaw = 1232;

		[global::Cpp2ILInjected.Token(Token = "0x4005307")]
		public const short ChlorophyteGreataxe = 1233;

		[global::Cpp2ILInjected.Token(Token = "0x4005308")]
		public const short ChlorophyteWarhammer = 1234;

		[global::Cpp2ILInjected.Token(Token = "0x4005309")]
		public const short ChlorophyteArrow = 1235;

		[global::Cpp2ILInjected.Token(Token = "0x400530A")]
		public const short AmethystHook = 1236;

		[global::Cpp2ILInjected.Token(Token = "0x400530B")]
		public const short TopazHook = 1237;

		[global::Cpp2ILInjected.Token(Token = "0x400530C")]
		public const short SapphireHook = 1238;

		[global::Cpp2ILInjected.Token(Token = "0x400530D")]
		public const short EmeraldHook = 1239;

		[global::Cpp2ILInjected.Token(Token = "0x400530E")]
		public const short RubyHook = 1240;

		[global::Cpp2ILInjected.Token(Token = "0x400530F")]
		public const short DiamondHook = 1241;

		[global::Cpp2ILInjected.Token(Token = "0x4005310")]
		public const short AmberMosquito = 1242;

		[global::Cpp2ILInjected.Token(Token = "0x4005311")]
		public const short UmbrellaHat = 1243;

		[global::Cpp2ILInjected.Token(Token = "0x4005312")]
		public const short NimbusRod = 1244;

		[global::Cpp2ILInjected.Token(Token = "0x4005313")]
		public const short OrangeTorch = 1245;

		[global::Cpp2ILInjected.Token(Token = "0x4005314")]
		public const short CrimsandBlock = 1246;

		[global::Cpp2ILInjected.Token(Token = "0x4005315")]
		public const short BeeCloak = 1247;

		[global::Cpp2ILInjected.Token(Token = "0x4005316")]
		public const short EyeoftheGolem = 1248;

		[global::Cpp2ILInjected.Token(Token = "0x4005317")]
		public const short HoneyBalloon = 1249;

		[global::Cpp2ILInjected.Token(Token = "0x4005318")]
		public const short BlueHorseshoeBalloon = 1250;

		[global::Cpp2ILInjected.Token(Token = "0x4005319")]
		public const short WhiteHorseshoeBalloon = 1251;

		[global::Cpp2ILInjected.Token(Token = "0x400531A")]
		public const short YellowHorseshoeBalloon = 1252;

		[global::Cpp2ILInjected.Token(Token = "0x400531B")]
		public const short FrozenTurtleShell = 1253;

		[global::Cpp2ILInjected.Token(Token = "0x400531C")]
		public const short SniperRifle = 1254;

		[global::Cpp2ILInjected.Token(Token = "0x400531D")]
		public const short VenusMagnum = 1255;

		[global::Cpp2ILInjected.Token(Token = "0x400531E")]
		public const short CrimsonRod = 1256;

		[global::Cpp2ILInjected.Token(Token = "0x400531F")]
		public const short CrimtaneBar = 1257;

		[global::Cpp2ILInjected.Token(Token = "0x4005320")]
		public const short Stynger = 1258;

		[global::Cpp2ILInjected.Token(Token = "0x4005321")]
		public const short FlowerPow = 1259;

		[global::Cpp2ILInjected.Token(Token = "0x4005322")]
		public const short RainbowGun = 1260;

		[global::Cpp2ILInjected.Token(Token = "0x4005323")]
		public const short StyngerBolt = 1261;

		[global::Cpp2ILInjected.Token(Token = "0x4005324")]
		public const short ChlorophyteJackhammer = 1262;

		[global::Cpp2ILInjected.Token(Token = "0x4005325")]
		public const short Teleporter = 1263;

		[global::Cpp2ILInjected.Token(Token = "0x4005326")]
		public const short FlowerofFrost = 1264;

		[global::Cpp2ILInjected.Token(Token = "0x4005327")]
		public const short Uzi = 1265;

		[global::Cpp2ILInjected.Token(Token = "0x4005328")]
		public const short MagnetSphere = 1266;

		[global::Cpp2ILInjected.Token(Token = "0x4005329")]
		public const short PurpleStainedGlass = 1267;

		[global::Cpp2ILInjected.Token(Token = "0x400532A")]
		public const short YellowStainedGlass = 1268;

		[global::Cpp2ILInjected.Token(Token = "0x400532B")]
		public const short BlueStainedGlass = 1269;

		[global::Cpp2ILInjected.Token(Token = "0x400532C")]
		public const short GreenStainedGlass = 1270;

		[global::Cpp2ILInjected.Token(Token = "0x400532D")]
		public const short RedStainedGlass = 1271;

		[global::Cpp2ILInjected.Token(Token = "0x400532E")]
		public const short MulticoloredStainedGlass = 1272;

		[global::Cpp2ILInjected.Token(Token = "0x400532F")]
		public const short SkeletronHand = 1273;

		[global::Cpp2ILInjected.Token(Token = "0x4005330")]
		public const short Skull = 1274;

		[global::Cpp2ILInjected.Token(Token = "0x4005331")]
		public const short BallaHat = 1275;

		[global::Cpp2ILInjected.Token(Token = "0x4005332")]
		public const short GangstaHat = 1276;

		[global::Cpp2ILInjected.Token(Token = "0x4005333")]
		public const short SailorHat = 1277;

		[global::Cpp2ILInjected.Token(Token = "0x4005334")]
		public const short EyePatch = 1278;

		[global::Cpp2ILInjected.Token(Token = "0x4005335")]
		public const short SailorShirt = 1279;

		[global::Cpp2ILInjected.Token(Token = "0x4005336")]
		public const short SailorPants = 1280;

		[global::Cpp2ILInjected.Token(Token = "0x4005337")]
		public const short SkeletronMask = 1281;

		[global::Cpp2ILInjected.Token(Token = "0x4005338")]
		public const short AmethystRobe = 1282;

		[global::Cpp2ILInjected.Token(Token = "0x4005339")]
		public const short TopazRobe = 1283;

		[global::Cpp2ILInjected.Token(Token = "0x400533A")]
		public const short SapphireRobe = 1284;

		[global::Cpp2ILInjected.Token(Token = "0x400533B")]
		public const short EmeraldRobe = 1285;

		[global::Cpp2ILInjected.Token(Token = "0x400533C")]
		public const short RubyRobe = 1286;

		[global::Cpp2ILInjected.Token(Token = "0x400533D")]
		public const short DiamondRobe = 1287;

		[global::Cpp2ILInjected.Token(Token = "0x400533E")]
		public const short WhiteTuxedoShirt = 1288;

		[global::Cpp2ILInjected.Token(Token = "0x400533F")]
		public const short WhiteTuxedoPants = 1289;

		[global::Cpp2ILInjected.Token(Token = "0x4005340")]
		public const short PanicNecklace = 1290;

		[global::Cpp2ILInjected.Token(Token = "0x4005341")]
		public const short LifeFruit = 1291;

		[global::Cpp2ILInjected.Token(Token = "0x4005342")]
		public const short LihzahrdAltar = 1292;

		[global::Cpp2ILInjected.Token(Token = "0x4005343")]
		public const short LihzahrdPowerCell = 1293;

		[global::Cpp2ILInjected.Token(Token = "0x4005344")]
		public const short Picksaw = 1294;

		[global::Cpp2ILInjected.Token(Token = "0x4005345")]
		public const short HeatRay = 1295;

		[global::Cpp2ILInjected.Token(Token = "0x4005346")]
		public const short StaffofEarth = 1296;

		[global::Cpp2ILInjected.Token(Token = "0x4005347")]
		public const short GolemFist = 1297;

		[global::Cpp2ILInjected.Token(Token = "0x4005348")]
		public const short WaterChest = 1298;

		[global::Cpp2ILInjected.Token(Token = "0x4005349")]
		public const short Binoculars = 1299;

		[global::Cpp2ILInjected.Token(Token = "0x400534A")]
		public const short RifleScope = 1300;

		[global::Cpp2ILInjected.Token(Token = "0x400534B")]
		public const short DestroyerEmblem = 1301;

		[global::Cpp2ILInjected.Token(Token = "0x400534C")]
		public const short HighVelocityBullet = 1302;

		[global::Cpp2ILInjected.Token(Token = "0x400534D")]
		public const short JellyfishNecklace = 1303;

		[global::Cpp2ILInjected.Token(Token = "0x400534E")]
		public const short ZombieArm = 1304;

		[global::Cpp2ILInjected.Token(Token = "0x400534F")]
		public const short TheAxe = 1305;

		[global::Cpp2ILInjected.Token(Token = "0x4005350")]
		public const short IceSickle = 1306;

		[global::Cpp2ILInjected.Token(Token = "0x4005351")]
		public const short ClothierVoodooDoll = 1307;

		[global::Cpp2ILInjected.Token(Token = "0x4005352")]
		public const short PoisonStaff = 1308;

		[global::Cpp2ILInjected.Token(Token = "0x4005353")]
		public const short SlimeStaff = 1309;

		[global::Cpp2ILInjected.Token(Token = "0x4005354")]
		public const short PoisonDart = 1310;

		[global::Cpp2ILInjected.Token(Token = "0x4005355")]
		public const short EyeSpring = 1311;

		[global::Cpp2ILInjected.Token(Token = "0x4005356")]
		public const short ToySled = 1312;

		[global::Cpp2ILInjected.Token(Token = "0x4005357")]
		public const short BookofSkulls = 1313;

		[global::Cpp2ILInjected.Token(Token = "0x4005358")]
		public const short KOCannon = 1314;

		[global::Cpp2ILInjected.Token(Token = "0x4005359")]
		public const short PirateMap = 1315;

		[global::Cpp2ILInjected.Token(Token = "0x400535A")]
		public const short TurtleHelmet = 1316;

		[global::Cpp2ILInjected.Token(Token = "0x400535B")]
		public const short TurtleScaleMail = 1317;

		[global::Cpp2ILInjected.Token(Token = "0x400535C")]
		public const short TurtleLeggings = 1318;

		[global::Cpp2ILInjected.Token(Token = "0x400535D")]
		public const short SnowballCannon = 1319;

		[global::Cpp2ILInjected.Token(Token = "0x400535E")]
		public const short BonePickaxe = 1320;

		[global::Cpp2ILInjected.Token(Token = "0x400535F")]
		public const short MagicQuiver = 1321;

		[global::Cpp2ILInjected.Token(Token = "0x4005360")]
		public const short MagmaStone = 1322;

		[global::Cpp2ILInjected.Token(Token = "0x4005361")]
		public const short ObsidianRose = 1323;

		[global::Cpp2ILInjected.Token(Token = "0x4005362")]
		public const short Bananarang = 1324;

		[global::Cpp2ILInjected.Token(Token = "0x4005363")]
		public const short ChainKnife = 1325;

		[global::Cpp2ILInjected.Token(Token = "0x4005364")]
		public const short RodofDiscord = 1326;

		[global::Cpp2ILInjected.Token(Token = "0x4005365")]
		public const short DeathSickle = 1327;

		[global::Cpp2ILInjected.Token(Token = "0x4005366")]
		public const short TurtleShell = 1328;

		[global::Cpp2ILInjected.Token(Token = "0x4005367")]
		public const short TissueSample = 1329;

		[global::Cpp2ILInjected.Token(Token = "0x4005368")]
		public const short Vertebrae = 1330;

		[global::Cpp2ILInjected.Token(Token = "0x4005369")]
		public const short BloodySpine = 1331;

		[global::Cpp2ILInjected.Token(Token = "0x400536A")]
		public const short Ichor = 1332;

		[global::Cpp2ILInjected.Token(Token = "0x400536B")]
		public const short IchorTorch = 1333;

		[global::Cpp2ILInjected.Token(Token = "0x400536C")]
		public const short IchorArrow = 1334;

		[global::Cpp2ILInjected.Token(Token = "0x400536D")]
		public const short IchorBullet = 1335;

		[global::Cpp2ILInjected.Token(Token = "0x400536E")]
		public const short GoldenShower = 1336;

		[global::Cpp2ILInjected.Token(Token = "0x400536F")]
		public const short BunnyCannon = 1337;

		[global::Cpp2ILInjected.Token(Token = "0x4005370")]
		public const short ExplosiveBunny = 1338;

		[global::Cpp2ILInjected.Token(Token = "0x4005371")]
		public const short VialofVenom = 1339;

		[global::Cpp2ILInjected.Token(Token = "0x4005372")]
		public const short FlaskofVenom = 1340;

		[global::Cpp2ILInjected.Token(Token = "0x4005373")]
		public const short VenomArrow = 1341;

		[global::Cpp2ILInjected.Token(Token = "0x4005374")]
		public const short VenomBullet = 1342;

		[global::Cpp2ILInjected.Token(Token = "0x4005375")]
		public const short FireGauntlet = 1343;

		[global::Cpp2ILInjected.Token(Token = "0x4005376")]
		public const short Cog = 1344;

		[global::Cpp2ILInjected.Token(Token = "0x4005377")]
		public const short Confetti = 1345;

		[global::Cpp2ILInjected.Token(Token = "0x4005378")]
		public const short Nanites = 1346;

		[global::Cpp2ILInjected.Token(Token = "0x4005379")]
		public const short ExplosivePowder = 1347;

		[global::Cpp2ILInjected.Token(Token = "0x400537A")]
		public const short GoldDust = 1348;

		[global::Cpp2ILInjected.Token(Token = "0x400537B")]
		public const short PartyBullet = 1349;

		[global::Cpp2ILInjected.Token(Token = "0x400537C")]
		public const short NanoBullet = 1350;

		[global::Cpp2ILInjected.Token(Token = "0x400537D")]
		public const short ExplodingBullet = 1351;

		[global::Cpp2ILInjected.Token(Token = "0x400537E")]
		public const short GoldenBullet = 1352;

		[global::Cpp2ILInjected.Token(Token = "0x400537F")]
		public const short FlaskofCursedFlames = 1353;

		[global::Cpp2ILInjected.Token(Token = "0x4005380")]
		public const short FlaskofFire = 1354;

		[global::Cpp2ILInjected.Token(Token = "0x4005381")]
		public const short FlaskofGold = 1355;

		[global::Cpp2ILInjected.Token(Token = "0x4005382")]
		public const short FlaskofIchor = 1356;

		[global::Cpp2ILInjected.Token(Token = "0x4005383")]
		public const short FlaskofNanites = 1357;

		[global::Cpp2ILInjected.Token(Token = "0x4005384")]
		public const short FlaskofParty = 1358;

		[global::Cpp2ILInjected.Token(Token = "0x4005385")]
		public const short FlaskofPoison = 1359;

		[global::Cpp2ILInjected.Token(Token = "0x4005386")]
		public const short EyeofCthulhuTrophy = 1360;

		[global::Cpp2ILInjected.Token(Token = "0x4005387")]
		public const short EaterofWorldsTrophy = 1361;

		[global::Cpp2ILInjected.Token(Token = "0x4005388")]
		public const short BrainofCthulhuTrophy = 1362;

		[global::Cpp2ILInjected.Token(Token = "0x4005389")]
		public const short SkeletronTrophy = 1363;

		[global::Cpp2ILInjected.Token(Token = "0x400538A")]
		public const short QueenBeeTrophy = 1364;

		[global::Cpp2ILInjected.Token(Token = "0x400538B")]
		public const short WallofFleshTrophy = 1365;

		[global::Cpp2ILInjected.Token(Token = "0x400538C")]
		public const short DestroyerTrophy = 1366;

		[global::Cpp2ILInjected.Token(Token = "0x400538D")]
		public const short SkeletronPrimeTrophy = 1367;

		[global::Cpp2ILInjected.Token(Token = "0x400538E")]
		public const short RetinazerTrophy = 1368;

		[global::Cpp2ILInjected.Token(Token = "0x400538F")]
		public const short SpazmatismTrophy = 1369;

		[global::Cpp2ILInjected.Token(Token = "0x4005390")]
		public const short PlanteraTrophy = 1370;

		[global::Cpp2ILInjected.Token(Token = "0x4005391")]
		public const short GolemTrophy = 1371;

		[global::Cpp2ILInjected.Token(Token = "0x4005392")]
		public const short BloodMoonRising = 1372;

		[global::Cpp2ILInjected.Token(Token = "0x4005393")]
		public const short TheHangedMan = 1373;

		[global::Cpp2ILInjected.Token(Token = "0x4005394")]
		public const short GloryoftheFire = 1374;

		[global::Cpp2ILInjected.Token(Token = "0x4005395")]
		public const short BoneWarp = 1375;

		[global::Cpp2ILInjected.Token(Token = "0x4005396")]
		public const short WallSkeleton = 1376;

		[global::Cpp2ILInjected.Token(Token = "0x4005397")]
		public const short HangingSkeleton = 1377;

		[global::Cpp2ILInjected.Token(Token = "0x4005398")]
		public const short BlueSlabWall = 1378;

		[global::Cpp2ILInjected.Token(Token = "0x4005399")]
		public const short BlueTiledWall = 1379;

		[global::Cpp2ILInjected.Token(Token = "0x400539A")]
		public const short PinkSlabWall = 1380;

		[global::Cpp2ILInjected.Token(Token = "0x400539B")]
		public const short PinkTiledWall = 1381;

		[global::Cpp2ILInjected.Token(Token = "0x400539C")]
		public const short GreenSlabWall = 1382;

		[global::Cpp2ILInjected.Token(Token = "0x400539D")]
		public const short GreenTiledWall = 1383;

		[global::Cpp2ILInjected.Token(Token = "0x400539E")]
		public const short BlueBrickPlatform = 1384;

		[global::Cpp2ILInjected.Token(Token = "0x400539F")]
		public const short PinkBrickPlatform = 1385;

		[global::Cpp2ILInjected.Token(Token = "0x40053A0")]
		public const short GreenBrickPlatform = 1386;

		[global::Cpp2ILInjected.Token(Token = "0x40053A1")]
		public const short MetalShelf = 1387;

		[global::Cpp2ILInjected.Token(Token = "0x40053A2")]
		public const short BrassShelf = 1388;

		[global::Cpp2ILInjected.Token(Token = "0x40053A3")]
		public const short WoodShelf = 1389;

		[global::Cpp2ILInjected.Token(Token = "0x40053A4")]
		public const short BrassLantern = 1390;

		[global::Cpp2ILInjected.Token(Token = "0x40053A5")]
		public const short CagedLantern = 1391;

		[global::Cpp2ILInjected.Token(Token = "0x40053A6")]
		public const short CarriageLantern = 1392;

		[global::Cpp2ILInjected.Token(Token = "0x40053A7")]
		public const short AlchemyLantern = 1393;

		[global::Cpp2ILInjected.Token(Token = "0x40053A8")]
		public const short DiablostLamp = 1394;

		[global::Cpp2ILInjected.Token(Token = "0x40053A9")]
		public const short OilRagSconse = 1395;

		[global::Cpp2ILInjected.Token(Token = "0x40053AA")]
		public const short BlueDungeonChair = 1396;

		[global::Cpp2ILInjected.Token(Token = "0x40053AB")]
		public const short BlueDungeonTable = 1397;

		[global::Cpp2ILInjected.Token(Token = "0x40053AC")]
		public const short BlueDungeonWorkBench = 1398;

		[global::Cpp2ILInjected.Token(Token = "0x40053AD")]
		public const short GreenDungeonChair = 1399;

		[global::Cpp2ILInjected.Token(Token = "0x40053AE")]
		public const short GreenDungeonTable = 1400;

		[global::Cpp2ILInjected.Token(Token = "0x40053AF")]
		public const short GreenDungeonWorkBench = 1401;

		[global::Cpp2ILInjected.Token(Token = "0x40053B0")]
		public const short PinkDungeonChair = 1402;

		[global::Cpp2ILInjected.Token(Token = "0x40053B1")]
		public const short PinkDungeonTable = 1403;

		[global::Cpp2ILInjected.Token(Token = "0x40053B2")]
		public const short PinkDungeonWorkBench = 1404;

		[global::Cpp2ILInjected.Token(Token = "0x40053B3")]
		public const short BlueDungeonCandle = 1405;

		[global::Cpp2ILInjected.Token(Token = "0x40053B4")]
		public const short GreenDungeonCandle = 1406;

		[global::Cpp2ILInjected.Token(Token = "0x40053B5")]
		public const short PinkDungeonCandle = 1407;

		[global::Cpp2ILInjected.Token(Token = "0x40053B6")]
		public const short BlueDungeonVase = 1408;

		[global::Cpp2ILInjected.Token(Token = "0x40053B7")]
		public const short GreenDungeonVase = 1409;

		[global::Cpp2ILInjected.Token(Token = "0x40053B8")]
		public const short PinkDungeonVase = 1410;

		[global::Cpp2ILInjected.Token(Token = "0x40053B9")]
		public const short BlueDungeonDoor = 1411;

		[global::Cpp2ILInjected.Token(Token = "0x40053BA")]
		public const short GreenDungeonDoor = 1412;

		[global::Cpp2ILInjected.Token(Token = "0x40053BB")]
		public const short PinkDungeonDoor = 1413;

		[global::Cpp2ILInjected.Token(Token = "0x40053BC")]
		public const short BlueDungeonBookcase = 1414;

		[global::Cpp2ILInjected.Token(Token = "0x40053BD")]
		public const short GreenDungeonBookcase = 1415;

		[global::Cpp2ILInjected.Token(Token = "0x40053BE")]
		public const short PinkDungeonBookcase = 1416;

		[global::Cpp2ILInjected.Token(Token = "0x40053BF")]
		public const short Catacomb = 1417;

		[global::Cpp2ILInjected.Token(Token = "0x40053C0")]
		public const short DungeonShelf = 1418;

		[global::Cpp2ILInjected.Token(Token = "0x40053C1")]
		public const short SkellingtonJSkellingsworth = 1419;

		[global::Cpp2ILInjected.Token(Token = "0x40053C2")]
		public const short TheCursedMan = 1420;

		[global::Cpp2ILInjected.Token(Token = "0x40053C3")]
		public const short TheEyeSeestheEnd = 1421;

		[global::Cpp2ILInjected.Token(Token = "0x40053C4")]
		public const short SomethingEvilisWatchingYou = 1422;

		[global::Cpp2ILInjected.Token(Token = "0x40053C5")]
		public const short TheTwinsHaveAwoken = 1423;

		[global::Cpp2ILInjected.Token(Token = "0x40053C6")]
		public const short TheScreamer = 1424;

		[global::Cpp2ILInjected.Token(Token = "0x40053C7")]
		public const short GoblinsPlayingPoker = 1425;

		[global::Cpp2ILInjected.Token(Token = "0x40053C8")]
		public const short Dryadisque = 1426;

		[global::Cpp2ILInjected.Token(Token = "0x40053C9")]
		public const short Sunflowers = 1427;

		[global::Cpp2ILInjected.Token(Token = "0x40053CA")]
		public const short TerrarianGothic = 1428;

		[global::Cpp2ILInjected.Token(Token = "0x40053CB")]
		public const short Beanie = 1429;

		[global::Cpp2ILInjected.Token(Token = "0x40053CC")]
		public const short ImbuingStation = 1430;

		[global::Cpp2ILInjected.Token(Token = "0x40053CD")]
		public const short StarinaBottle = 1431;

		[global::Cpp2ILInjected.Token(Token = "0x40053CE")]
		public const short EmptyBullet = 1432;

		[global::Cpp2ILInjected.Token(Token = "0x40053CF")]
		public const short Impact = 1433;

		[global::Cpp2ILInjected.Token(Token = "0x40053D0")]
		public const short PoweredbyBirds = 1434;

		[global::Cpp2ILInjected.Token(Token = "0x40053D1")]
		public const short TheDestroyer = 1435;

		[global::Cpp2ILInjected.Token(Token = "0x40053D2")]
		public const short ThePersistencyofEyes = 1436;

		[global::Cpp2ILInjected.Token(Token = "0x40053D3")]
		public const short UnicornCrossingtheHallows = 1437;

		[global::Cpp2ILInjected.Token(Token = "0x40053D4")]
		public const short GreatWave = 1438;

		[global::Cpp2ILInjected.Token(Token = "0x40053D5")]
		public const short StarryNight = 1439;

		[global::Cpp2ILInjected.Token(Token = "0x40053D6")]
		public const short GuidePicasso = 1440;

		[global::Cpp2ILInjected.Token(Token = "0x40053D7")]
		public const short TheGuardiansGaze = 1441;

		[global::Cpp2ILInjected.Token(Token = "0x40053D8")]
		public const short FatherofSomeone = 1442;

		[global::Cpp2ILInjected.Token(Token = "0x40053D9")]
		public const short NurseLisa = 1443;

		[global::Cpp2ILInjected.Token(Token = "0x40053DA")]
		public const short ShadowbeamStaff = 1444;

		[global::Cpp2ILInjected.Token(Token = "0x40053DB")]
		public const short InfernoFork = 1445;

		[global::Cpp2ILInjected.Token(Token = "0x40053DC")]
		public const short SpectreStaff = 1446;

		[global::Cpp2ILInjected.Token(Token = "0x40053DD")]
		public const short WoodenFence = 1447;

		[global::Cpp2ILInjected.Token(Token = "0x40053DE")]
		public const short LeadFence = 1448;

		[global::Cpp2ILInjected.Token(Token = "0x40053DF")]
		public const short BubbleMachine = 1449;

		[global::Cpp2ILInjected.Token(Token = "0x40053E0")]
		public const short BubbleWand = 1450;

		[global::Cpp2ILInjected.Token(Token = "0x40053E1")]
		public const short MarchingBonesBanner = 1451;

		[global::Cpp2ILInjected.Token(Token = "0x40053E2")]
		public const short NecromanticSign = 1452;

		[global::Cpp2ILInjected.Token(Token = "0x40053E3")]
		public const short RustedCompanyStandard = 1453;

		[global::Cpp2ILInjected.Token(Token = "0x40053E4")]
		public const short RaggedBrotherhoodSigil = 1454;

		[global::Cpp2ILInjected.Token(Token = "0x40053E5")]
		public const short MoltenLegionFlag = 1455;

		[global::Cpp2ILInjected.Token(Token = "0x40053E6")]
		public const short DiabolicSigil = 1456;

		[global::Cpp2ILInjected.Token(Token = "0x40053E7")]
		public const short ObsidianPlatform = 1457;

		[global::Cpp2ILInjected.Token(Token = "0x40053E8")]
		public const short ObsidianDoor = 1458;

		[global::Cpp2ILInjected.Token(Token = "0x40053E9")]
		public const short ObsidianChair = 1459;

		[global::Cpp2ILInjected.Token(Token = "0x40053EA")]
		public const short ObsidianTable = 1460;

		[global::Cpp2ILInjected.Token(Token = "0x40053EB")]
		public const short ObsidianWorkBench = 1461;

		[global::Cpp2ILInjected.Token(Token = "0x40053EC")]
		public const short ObsidianVase = 1462;

		[global::Cpp2ILInjected.Token(Token = "0x40053ED")]
		public const short ObsidianBookcase = 1463;

		[global::Cpp2ILInjected.Token(Token = "0x40053EE")]
		public const short HellboundBanner = 1464;

		[global::Cpp2ILInjected.Token(Token = "0x40053EF")]
		public const short HellHammerBanner = 1465;

		[global::Cpp2ILInjected.Token(Token = "0x40053F0")]
		public const short HelltowerBanner = 1466;

		[global::Cpp2ILInjected.Token(Token = "0x40053F1")]
		public const short LostHopesofManBanner = 1467;

		[global::Cpp2ILInjected.Token(Token = "0x40053F2")]
		public const short ObsidianWatcherBanner = 1468;

		[global::Cpp2ILInjected.Token(Token = "0x40053F3")]
		public const short LavaEruptsBanner = 1469;

		[global::Cpp2ILInjected.Token(Token = "0x40053F4")]
		public const short BlueDungeonBed = 1470;

		[global::Cpp2ILInjected.Token(Token = "0x40053F5")]
		public const short GreenDungeonBed = 1471;

		[global::Cpp2ILInjected.Token(Token = "0x40053F6")]
		public const short PinkDungeonBed = 1472;

		[global::Cpp2ILInjected.Token(Token = "0x40053F7")]
		public const short ObsidianBed = 1473;

		[global::Cpp2ILInjected.Token(Token = "0x40053F8")]
		public const short Waldo = 1474;

		[global::Cpp2ILInjected.Token(Token = "0x40053F9")]
		public const short Darkness = 1475;

		[global::Cpp2ILInjected.Token(Token = "0x40053FA")]
		public const short DarkSoulReaper = 1476;

		[global::Cpp2ILInjected.Token(Token = "0x40053FB")]
		public const short Land = 1477;

		[global::Cpp2ILInjected.Token(Token = "0x40053FC")]
		public const short TrappedGhost = 1478;

		[global::Cpp2ILInjected.Token(Token = "0x40053FD")]
		public const short DemonsEye = 1479;

		[global::Cpp2ILInjected.Token(Token = "0x40053FE")]
		public const short FindingGold = 1480;

		[global::Cpp2ILInjected.Token(Token = "0x40053FF")]
		public const short FirstEncounter = 1481;

		[global::Cpp2ILInjected.Token(Token = "0x4005400")]
		public const short GoodMorning = 1482;

		[global::Cpp2ILInjected.Token(Token = "0x4005401")]
		public const short UndergroundReward = 1483;

		[global::Cpp2ILInjected.Token(Token = "0x4005402")]
		public const short ThroughtheWindow = 1484;

		[global::Cpp2ILInjected.Token(Token = "0x4005403")]
		public const short PlaceAbovetheClouds = 1485;

		[global::Cpp2ILInjected.Token(Token = "0x4005404")]
		public const short DoNotStepontheGrass = 1486;

		[global::Cpp2ILInjected.Token(Token = "0x4005405")]
		public const short ColdWatersintheWhiteLand = 1487;

		[global::Cpp2ILInjected.Token(Token = "0x4005406")]
		public const short LightlessChasms = 1488;

		[global::Cpp2ILInjected.Token(Token = "0x4005407")]
		public const short TheLandofDeceivingLooks = 1489;

		[global::Cpp2ILInjected.Token(Token = "0x4005408")]
		public const short Daylight = 1490;

		[global::Cpp2ILInjected.Token(Token = "0x4005409")]
		public const short SecretoftheSands = 1491;

		[global::Cpp2ILInjected.Token(Token = "0x400540A")]
		public const short DeadlandComesAlive = 1492;

		[global::Cpp2ILInjected.Token(Token = "0x400540B")]
		public const short EvilPresence = 1493;

		[global::Cpp2ILInjected.Token(Token = "0x400540C")]
		public const short SkyGuardian = 1494;

		[global::Cpp2ILInjected.Token(Token = "0x400540D")]
		public const short AmericanExplosive = 1495;

		[global::Cpp2ILInjected.Token(Token = "0x400540E")]
		public const short Discover = 1496;

		[global::Cpp2ILInjected.Token(Token = "0x400540F")]
		public const short HandEarth = 1497;

		[global::Cpp2ILInjected.Token(Token = "0x4005410")]
		public const short OldMiner = 1498;

		[global::Cpp2ILInjected.Token(Token = "0x4005411")]
		public const short Skelehead = 1499;

		[global::Cpp2ILInjected.Token(Token = "0x4005412")]
		public const short FacingtheCerebralMastermind = 1500;

		[global::Cpp2ILInjected.Token(Token = "0x4005413")]
		public const short LakeofFire = 1501;

		[global::Cpp2ILInjected.Token(Token = "0x4005414")]
		public const short TrioSuperHeroes = 1502;

		[global::Cpp2ILInjected.Token(Token = "0x4005415")]
		public const short SpectreHood = 1503;

		[global::Cpp2ILInjected.Token(Token = "0x4005416")]
		public const short SpectreRobe = 1504;

		[global::Cpp2ILInjected.Token(Token = "0x4005417")]
		public const short SpectrePants = 1505;

		[global::Cpp2ILInjected.Token(Token = "0x4005418")]
		public const short SpectrePickaxe = 1506;

		[global::Cpp2ILInjected.Token(Token = "0x4005419")]
		public const short SpectreHamaxe = 1507;

		[global::Cpp2ILInjected.Token(Token = "0x400541A")]
		public const short Ectoplasm = 1508;

		[global::Cpp2ILInjected.Token(Token = "0x400541B")]
		public const short GothicChair = 1509;

		[global::Cpp2ILInjected.Token(Token = "0x400541C")]
		public const short GothicTable = 1510;

		[global::Cpp2ILInjected.Token(Token = "0x400541D")]
		public const short GothicWorkBench = 1511;

		[global::Cpp2ILInjected.Token(Token = "0x400541E")]
		public const short GothicBookcase = 1512;

		[global::Cpp2ILInjected.Token(Token = "0x400541F")]
		public const short PaladinsHammer = 1513;

		[global::Cpp2ILInjected.Token(Token = "0x4005420")]
		public const short SWATHelmet = 1514;

		[global::Cpp2ILInjected.Token(Token = "0x4005421")]
		public const short BeeWings = 1515;

		[global::Cpp2ILInjected.Token(Token = "0x4005422")]
		public const short GiantHarpyFeather = 1516;

		[global::Cpp2ILInjected.Token(Token = "0x4005423")]
		public const short BoneFeather = 1517;

		[global::Cpp2ILInjected.Token(Token = "0x4005424")]
		public const short FireFeather = 1518;

		[global::Cpp2ILInjected.Token(Token = "0x4005425")]
		public const short IceFeather = 1519;

		[global::Cpp2ILInjected.Token(Token = "0x4005426")]
		public const short BrokenBatWing = 1520;

		[global::Cpp2ILInjected.Token(Token = "0x4005427")]
		public const short TatteredBeeWing = 1521;

		[global::Cpp2ILInjected.Token(Token = "0x4005428")]
		public const short LargeAmethyst = 1522;

		[global::Cpp2ILInjected.Token(Token = "0x4005429")]
		public const short LargeTopaz = 1523;

		[global::Cpp2ILInjected.Token(Token = "0x400542A")]
		public const short LargeSapphire = 1524;

		[global::Cpp2ILInjected.Token(Token = "0x400542B")]
		public const short LargeEmerald = 1525;

		[global::Cpp2ILInjected.Token(Token = "0x400542C")]
		public const short LargeRuby = 1526;

		[global::Cpp2ILInjected.Token(Token = "0x400542D")]
		public const short LargeDiamond = 1527;

		[global::Cpp2ILInjected.Token(Token = "0x400542E")]
		public const short JungleChest = 1528;

		[global::Cpp2ILInjected.Token(Token = "0x400542F")]
		public const short CorruptionChest = 1529;

		[global::Cpp2ILInjected.Token(Token = "0x4005430")]
		public const short CrimsonChest = 1530;

		[global::Cpp2ILInjected.Token(Token = "0x4005431")]
		public const short HallowedChest = 1531;

		[global::Cpp2ILInjected.Token(Token = "0x4005432")]
		public const short FrozenChest = 1532;

		[global::Cpp2ILInjected.Token(Token = "0x4005433")]
		public const short JungleKey = 1533;

		[global::Cpp2ILInjected.Token(Token = "0x4005434")]
		public const short CorruptionKey = 1534;

		[global::Cpp2ILInjected.Token(Token = "0x4005435")]
		public const short CrimsonKey = 1535;

		[global::Cpp2ILInjected.Token(Token = "0x4005436")]
		public const short HallowedKey = 1536;

		[global::Cpp2ILInjected.Token(Token = "0x4005437")]
		public const short FrozenKey = 1537;

		[global::Cpp2ILInjected.Token(Token = "0x4005438")]
		public const short ImpFace = 1538;

		[global::Cpp2ILInjected.Token(Token = "0x4005439")]
		public const short OminousPresence = 1539;

		[global::Cpp2ILInjected.Token(Token = "0x400543A")]
		public const short ShiningMoon = 1540;

		[global::Cpp2ILInjected.Token(Token = "0x400543B")]
		public const short LivingGore = 1541;

		[global::Cpp2ILInjected.Token(Token = "0x400543C")]
		public const short FlowingMagma = 1542;

		[global::Cpp2ILInjected.Token(Token = "0x400543D")]
		public const short SpectrePaintbrush = 1543;

		[global::Cpp2ILInjected.Token(Token = "0x400543E")]
		public const short SpectrePaintRoller = 1544;

		[global::Cpp2ILInjected.Token(Token = "0x400543F")]
		public const short SpectrePaintScraper = 1545;

		[global::Cpp2ILInjected.Token(Token = "0x4005440")]
		public const short ShroomiteHeadgear = 1546;

		[global::Cpp2ILInjected.Token(Token = "0x4005441")]
		public const short ShroomiteMask = 1547;

		[global::Cpp2ILInjected.Token(Token = "0x4005442")]
		public const short ShroomiteHelmet = 1548;

		[global::Cpp2ILInjected.Token(Token = "0x4005443")]
		public const short ShroomiteBreastplate = 1549;

		[global::Cpp2ILInjected.Token(Token = "0x4005444")]
		public const short ShroomiteLeggings = 1550;

		[global::Cpp2ILInjected.Token(Token = "0x4005445")]
		public const short Autohammer = 1551;

		[global::Cpp2ILInjected.Token(Token = "0x4005446")]
		public const short ShroomiteBar = 1552;

		[global::Cpp2ILInjected.Token(Token = "0x4005447")]
		public const short SDMG = 1553;

		[global::Cpp2ILInjected.Token(Token = "0x4005448")]
		public const short CenxsTiara = 1554;

		[global::Cpp2ILInjected.Token(Token = "0x4005449")]
		public const short CenxsBreastplate = 1555;

		[global::Cpp2ILInjected.Token(Token = "0x400544A")]
		public const short CenxsLeggings = 1556;

		[global::Cpp2ILInjected.Token(Token = "0x400544B")]
		public const short CrownosMask = 1557;

		[global::Cpp2ILInjected.Token(Token = "0x400544C")]
		public const short CrownosBreastplate = 1558;

		[global::Cpp2ILInjected.Token(Token = "0x400544D")]
		public const short CrownosLeggings = 1559;

		[global::Cpp2ILInjected.Token(Token = "0x400544E")]
		public const short WillsHelmet = 1560;

		[global::Cpp2ILInjected.Token(Token = "0x400544F")]
		public const short WillsBreastplate = 1561;

		[global::Cpp2ILInjected.Token(Token = "0x4005450")]
		public const short WillsLeggings = 1562;

		[global::Cpp2ILInjected.Token(Token = "0x4005451")]
		public const short JimsHelmet = 1563;

		[global::Cpp2ILInjected.Token(Token = "0x4005452")]
		public const short JimsBreastplate = 1564;

		[global::Cpp2ILInjected.Token(Token = "0x4005453")]
		public const short JimsLeggings = 1565;

		[global::Cpp2ILInjected.Token(Token = "0x4005454")]
		public const short AaronsHelmet = 1566;

		[global::Cpp2ILInjected.Token(Token = "0x4005455")]
		public const short AaronsBreastplate = 1567;

		[global::Cpp2ILInjected.Token(Token = "0x4005456")]
		public const short AaronsLeggings = 1568;

		[global::Cpp2ILInjected.Token(Token = "0x4005457")]
		public const short VampireKnives = 1569;

		[global::Cpp2ILInjected.Token(Token = "0x4005458")]
		public const short BrokenHeroSword = 1570;

		[global::Cpp2ILInjected.Token(Token = "0x4005459")]
		public const short ScourgeoftheCorruptor = 1571;

		[global::Cpp2ILInjected.Token(Token = "0x400545A")]
		public const short StaffoftheFrostHydra = 1572;

		[global::Cpp2ILInjected.Token(Token = "0x400545B")]
		public const short TheCreationoftheGuide = 1573;

		[global::Cpp2ILInjected.Token(Token = "0x400545C")]
		public const short TheMerchant = 1574;

		[global::Cpp2ILInjected.Token(Token = "0x400545D")]
		public const short CrownoDevoursHisLunch = 1575;

		[global::Cpp2ILInjected.Token(Token = "0x400545E")]
		public const short RareEnchantment = 1576;

		[global::Cpp2ILInjected.Token(Token = "0x400545F")]
		public const short GloriousNight = 1577;

		[global::Cpp2ILInjected.Token(Token = "0x4005460")]
		public const short SweetheartNecklace = 1578;

		[global::Cpp2ILInjected.Token(Token = "0x4005461")]
		public const short FlurryBoots = 1579;

		[global::Cpp2ILInjected.Token(Token = "0x4005462")]
		public const short DTownsHelmet = 1580;

		[global::Cpp2ILInjected.Token(Token = "0x4005463")]
		public const short DTownsBreastplate = 1581;

		[global::Cpp2ILInjected.Token(Token = "0x4005464")]
		public const short DTownsLeggings = 1582;

		[global::Cpp2ILInjected.Token(Token = "0x4005465")]
		public const short DTownsWings = 1583;

		[global::Cpp2ILInjected.Token(Token = "0x4005466")]
		public const short WillsWings = 1584;

		[global::Cpp2ILInjected.Token(Token = "0x4005467")]
		public const short CrownosWings = 1585;

		[global::Cpp2ILInjected.Token(Token = "0x4005468")]
		public const short CenxsWings = 1586;

		[global::Cpp2ILInjected.Token(Token = "0x4005469")]
		public const short CenxsDress = 1587;

		[global::Cpp2ILInjected.Token(Token = "0x400546A")]
		public const short CenxsDressPants = 1588;

		[global::Cpp2ILInjected.Token(Token = "0x400546B")]
		public const short PalladiumColumn = 1589;

		[global::Cpp2ILInjected.Token(Token = "0x400546C")]
		public const short PalladiumColumnWall = 1590;

		[global::Cpp2ILInjected.Token(Token = "0x400546D")]
		public const short BubblegumBlock = 1591;

		[global::Cpp2ILInjected.Token(Token = "0x400546E")]
		public const short BubblegumBlockWall = 1592;

		[global::Cpp2ILInjected.Token(Token = "0x400546F")]
		public const short TitanstoneBlock = 1593;

		[global::Cpp2ILInjected.Token(Token = "0x4005470")]
		public const short TitanstoneBlockWall = 1594;

		[global::Cpp2ILInjected.Token(Token = "0x4005471")]
		public const short MagicCuffs = 1595;

		[global::Cpp2ILInjected.Token(Token = "0x4005472")]
		public const short MusicBoxSnow = 1596;

		[global::Cpp2ILInjected.Token(Token = "0x4005473")]
		public const short MusicBoxSpace = 1597;

		[global::Cpp2ILInjected.Token(Token = "0x4005474")]
		public const short MusicBoxCrimson = 1598;

		[global::Cpp2ILInjected.Token(Token = "0x4005475")]
		public const short MusicBoxBoss4 = 1599;

		[global::Cpp2ILInjected.Token(Token = "0x4005476")]
		public const short MusicBoxAltOverworldDay = 1600;

		[global::Cpp2ILInjected.Token(Token = "0x4005477")]
		public const short MusicBoxRain = 1601;

		[global::Cpp2ILInjected.Token(Token = "0x4005478")]
		public const short MusicBoxIce = 1602;

		[global::Cpp2ILInjected.Token(Token = "0x4005479")]
		public const short MusicBoxDesert = 1603;

		[global::Cpp2ILInjected.Token(Token = "0x400547A")]
		public const short MusicBoxOcean = 1604;

		[global::Cpp2ILInjected.Token(Token = "0x400547B")]
		public const short MusicBoxDungeon = 1605;

		[global::Cpp2ILInjected.Token(Token = "0x400547C")]
		public const short MusicBoxPlantera = 1606;

		[global::Cpp2ILInjected.Token(Token = "0x400547D")]
		public const short MusicBoxBoss5 = 1607;

		[global::Cpp2ILInjected.Token(Token = "0x400547E")]
		public const short MusicBoxTemple = 1608;

		[global::Cpp2ILInjected.Token(Token = "0x400547F")]
		public const short MusicBoxEclipse = 1609;

		[global::Cpp2ILInjected.Token(Token = "0x4005480")]
		public const short MusicBoxMushrooms = 1610;

		[global::Cpp2ILInjected.Token(Token = "0x4005481")]
		public const short ButterflyDust = 1611;

		[global::Cpp2ILInjected.Token(Token = "0x4005482")]
		public const short AnkhCharm = 1612;

		[global::Cpp2ILInjected.Token(Token = "0x4005483")]
		public const short AnkhShield = 1613;

		[global::Cpp2ILInjected.Token(Token = "0x4005484")]
		public const short BlueFlare = 1614;

		[global::Cpp2ILInjected.Token(Token = "0x4005485")]
		public const short AnglerFishBanner = 1615;

		[global::Cpp2ILInjected.Token(Token = "0x4005486")]
		public const short AngryNimbusBanner = 1616;

		[global::Cpp2ILInjected.Token(Token = "0x4005487")]
		public const short AnomuraFungusBanner = 1617;

		[global::Cpp2ILInjected.Token(Token = "0x4005488")]
		public const short AntlionBanner = 1618;

		[global::Cpp2ILInjected.Token(Token = "0x4005489")]
		public const short ArapaimaBanner = 1619;

		[global::Cpp2ILInjected.Token(Token = "0x400548A")]
		public const short ArmoredSkeletonBanner = 1620;

		[global::Cpp2ILInjected.Token(Token = "0x400548B")]
		public const short BatBanner = 1621;

		[global::Cpp2ILInjected.Token(Token = "0x400548C")]
		public const short BirdBanner = 1622;

		[global::Cpp2ILInjected.Token(Token = "0x400548D")]
		public const short BlackRecluseBanner = 1623;

		[global::Cpp2ILInjected.Token(Token = "0x400548E")]
		public const short BloodFeederBanner = 1624;

		[global::Cpp2ILInjected.Token(Token = "0x400548F")]
		public const short BloodJellyBanner = 1625;

		[global::Cpp2ILInjected.Token(Token = "0x4005490")]
		public const short BloodCrawlerBanner = 1626;

		[global::Cpp2ILInjected.Token(Token = "0x4005491")]
		public const short BoneSerpentBanner = 1627;

		[global::Cpp2ILInjected.Token(Token = "0x4005492")]
		public const short BunnyBanner = 1628;

		[global::Cpp2ILInjected.Token(Token = "0x4005493")]
		public const short ChaosElementalBanner = 1629;

		[global::Cpp2ILInjected.Token(Token = "0x4005494")]
		public const short MimicBanner = 1630;

		[global::Cpp2ILInjected.Token(Token = "0x4005495")]
		public const short ClownBanner = 1631;

		[global::Cpp2ILInjected.Token(Token = "0x4005496")]
		public const short CorruptBunnyBanner = 1632;

		[global::Cpp2ILInjected.Token(Token = "0x4005497")]
		public const short CorruptGoldfishBanner = 1633;

		[global::Cpp2ILInjected.Token(Token = "0x4005498")]
		public const short CrabBanner = 1634;

		[global::Cpp2ILInjected.Token(Token = "0x4005499")]
		public const short CrimeraBanner = 1635;

		[global::Cpp2ILInjected.Token(Token = "0x400549A")]
		public const short CrimsonAxeBanner = 1636;

		[global::Cpp2ILInjected.Token(Token = "0x400549B")]
		public const short CursedHammerBanner = 1637;

		[global::Cpp2ILInjected.Token(Token = "0x400549C")]
		public const short DemonBanner = 1638;

		[global::Cpp2ILInjected.Token(Token = "0x400549D")]
		public const short DemonEyeBanner = 1639;

		[global::Cpp2ILInjected.Token(Token = "0x400549E")]
		public const short DerplingBanner = 1640;

		[global::Cpp2ILInjected.Token(Token = "0x400549F")]
		public const short EaterofSoulsBanner = 1641;

		[global::Cpp2ILInjected.Token(Token = "0x40054A0")]
		public const short EnchantedSwordBanner = 1642;

		[global::Cpp2ILInjected.Token(Token = "0x40054A1")]
		public const short ZombieEskimoBanner = 1643;

		[global::Cpp2ILInjected.Token(Token = "0x40054A2")]
		public const short FaceMonsterBanner = 1644;

		[global::Cpp2ILInjected.Token(Token = "0x40054A3")]
		public const short FloatyGrossBanner = 1645;

		[global::Cpp2ILInjected.Token(Token = "0x40054A4")]
		public const short FlyingFishBanner = 1646;

		[global::Cpp2ILInjected.Token(Token = "0x40054A5")]
		public const short FlyingSnakeBanner = 1647;

		[global::Cpp2ILInjected.Token(Token = "0x40054A6")]
		public const short FrankensteinBanner = 1648;

		[global::Cpp2ILInjected.Token(Token = "0x40054A7")]
		public const short FungiBulbBanner = 1649;

		[global::Cpp2ILInjected.Token(Token = "0x40054A8")]
		public const short FungoFishBanner = 1650;

		[global::Cpp2ILInjected.Token(Token = "0x40054A9")]
		public const short GastropodBanner = 1651;

		[global::Cpp2ILInjected.Token(Token = "0x40054AA")]
		public const short GoblinThiefBanner = 1652;

		[global::Cpp2ILInjected.Token(Token = "0x40054AB")]
		public const short GoblinSorcererBanner = 1653;

		[global::Cpp2ILInjected.Token(Token = "0x40054AC")]
		public const short GoblinPeonBanner = 1654;

		[global::Cpp2ILInjected.Token(Token = "0x40054AD")]
		public const short GoblinScoutBanner = 1655;

		[global::Cpp2ILInjected.Token(Token = "0x40054AE")]
		public const short GoblinWarriorBanner = 1656;

		[global::Cpp2ILInjected.Token(Token = "0x40054AF")]
		public const short GoldfishBanner = 1657;

		[global::Cpp2ILInjected.Token(Token = "0x40054B0")]
		public const short HarpyBanner = 1658;

		[global::Cpp2ILInjected.Token(Token = "0x40054B1")]
		public const short HellbatBanner = 1659;

		[global::Cpp2ILInjected.Token(Token = "0x40054B2")]
		public const short HerplingBanner = 1660;

		[global::Cpp2ILInjected.Token(Token = "0x40054B3")]
		public const short HornetBanner = 1661;

		[global::Cpp2ILInjected.Token(Token = "0x40054B4")]
		public const short IceElementalBanner = 1662;

		[global::Cpp2ILInjected.Token(Token = "0x40054B5")]
		public const short IcyMermanBanner = 1663;

		[global::Cpp2ILInjected.Token(Token = "0x40054B6")]
		public const short FireImpBanner = 1664;

		[global::Cpp2ILInjected.Token(Token = "0x40054B7")]
		public const short JellyfishBanner = 1665;

		[global::Cpp2ILInjected.Token(Token = "0x40054B8")]
		public const short JungleCreeperBanner = 1666;

		[global::Cpp2ILInjected.Token(Token = "0x40054B9")]
		public const short LihzahrdBanner = 1667;

		[global::Cpp2ILInjected.Token(Token = "0x40054BA")]
		public const short ManEaterBanner = 1668;

		[global::Cpp2ILInjected.Token(Token = "0x40054BB")]
		public const short MeteorHeadBanner = 1669;

		[global::Cpp2ILInjected.Token(Token = "0x40054BC")]
		public const short MothBanner = 1670;

		[global::Cpp2ILInjected.Token(Token = "0x40054BD")]
		public const short MummyBanner = 1671;

		[global::Cpp2ILInjected.Token(Token = "0x40054BE")]
		public const short MushiLadybugBanner = 1672;

		[global::Cpp2ILInjected.Token(Token = "0x40054BF")]
		public const short ParrotBanner = 1673;

		[global::Cpp2ILInjected.Token(Token = "0x40054C0")]
		public const short PigronBanner = 1674;

		[global::Cpp2ILInjected.Token(Token = "0x40054C1")]
		public const short PiranhaBanner = 1675;

		[global::Cpp2ILInjected.Token(Token = "0x40054C2")]
		public const short PirateBanner = 1676;

		[global::Cpp2ILInjected.Token(Token = "0x40054C3")]
		public const short PixieBanner = 1677;

		[global::Cpp2ILInjected.Token(Token = "0x40054C4")]
		public const short RaincoatZombieBanner = 1678;

		[global::Cpp2ILInjected.Token(Token = "0x40054C5")]
		public const short ReaperBanner = 1679;

		[global::Cpp2ILInjected.Token(Token = "0x40054C6")]
		public const short SharkBanner = 1680;

		[global::Cpp2ILInjected.Token(Token = "0x40054C7")]
		public const short SkeletonBanner = 1681;

		[global::Cpp2ILInjected.Token(Token = "0x40054C8")]
		public const short SkeletonMageBanner = 1682;

		[global::Cpp2ILInjected.Token(Token = "0x40054C9")]
		public const short SlimeBanner = 1683;

		[global::Cpp2ILInjected.Token(Token = "0x40054CA")]
		public const short SnowFlinxBanner = 1684;

		[global::Cpp2ILInjected.Token(Token = "0x40054CB")]
		public const short SpiderBanner = 1685;

		[global::Cpp2ILInjected.Token(Token = "0x40054CC")]
		public const short SporeZombieBanner = 1686;

		[global::Cpp2ILInjected.Token(Token = "0x40054CD")]
		public const short SwampThingBanner = 1687;

		[global::Cpp2ILInjected.Token(Token = "0x40054CE")]
		public const short TortoiseBanner = 1688;

		[global::Cpp2ILInjected.Token(Token = "0x40054CF")]
		public const short ToxicSludgeBanner = 1689;

		[global::Cpp2ILInjected.Token(Token = "0x40054D0")]
		public const short UmbrellaSlimeBanner = 1690;

		[global::Cpp2ILInjected.Token(Token = "0x40054D1")]
		public const short UnicornBanner = 1691;

		[global::Cpp2ILInjected.Token(Token = "0x40054D2")]
		public const short VampireBanner = 1692;

		[global::Cpp2ILInjected.Token(Token = "0x40054D3")]
		public const short VultureBanner = 1693;

		[global::Cpp2ILInjected.Token(Token = "0x40054D4")]
		public const short NypmhBanner = 1694;

		[global::Cpp2ILInjected.Token(Token = "0x40054D5")]
		public const short WerewolfBanner = 1695;

		[global::Cpp2ILInjected.Token(Token = "0x40054D6")]
		public const short WolfBanner = 1696;

		[global::Cpp2ILInjected.Token(Token = "0x40054D7")]
		public const short WorldFeederBanner = 1697;

		[global::Cpp2ILInjected.Token(Token = "0x40054D8")]
		public const short WormBanner = 1698;

		[global::Cpp2ILInjected.Token(Token = "0x40054D9")]
		public const short WraithBanner = 1699;

		[global::Cpp2ILInjected.Token(Token = "0x40054DA")]
		public const short WyvernBanner = 1700;

		[global::Cpp2ILInjected.Token(Token = "0x40054DB")]
		public const short ZombieBanner = 1701;

		[global::Cpp2ILInjected.Token(Token = "0x40054DC")]
		public const short GlassPlatform = 1702;

		[global::Cpp2ILInjected.Token(Token = "0x40054DD")]
		public const short GlassChair = 1703;

		[global::Cpp2ILInjected.Token(Token = "0x40054DE")]
		public const short GoldenChair = 1704;

		[global::Cpp2ILInjected.Token(Token = "0x40054DF")]
		public const short GoldenToilet = 1705;

		[global::Cpp2ILInjected.Token(Token = "0x40054E0")]
		public const short BarStool = 1706;

		[global::Cpp2ILInjected.Token(Token = "0x40054E1")]
		public const short HoneyChair = 1707;

		[global::Cpp2ILInjected.Token(Token = "0x40054E2")]
		public const short SteampunkChair = 1708;

		[global::Cpp2ILInjected.Token(Token = "0x40054E3")]
		public const short GlassDoor = 1709;

		[global::Cpp2ILInjected.Token(Token = "0x40054E4")]
		public const short GoldenDoor = 1710;

		[global::Cpp2ILInjected.Token(Token = "0x40054E5")]
		public const short HoneyDoor = 1711;

		[global::Cpp2ILInjected.Token(Token = "0x40054E6")]
		public const short SteampunkDoor = 1712;

		[global::Cpp2ILInjected.Token(Token = "0x40054E7")]
		public const short GlassTable = 1713;

		[global::Cpp2ILInjected.Token(Token = "0x40054E8")]
		public const short BanquetTable = 1714;

		[global::Cpp2ILInjected.Token(Token = "0x40054E9")]
		public const short Bar = 1715;

		[global::Cpp2ILInjected.Token(Token = "0x40054EA")]
		public const short GoldenTable = 1716;

		[global::Cpp2ILInjected.Token(Token = "0x40054EB")]
		public const short HoneyTable = 1717;

		[global::Cpp2ILInjected.Token(Token = "0x40054EC")]
		public const short SteampunkTable = 1718;

		[global::Cpp2ILInjected.Token(Token = "0x40054ED")]
		public const short GlassBed = 1719;

		[global::Cpp2ILInjected.Token(Token = "0x40054EE")]
		public const short GoldenBed = 1720;

		[global::Cpp2ILInjected.Token(Token = "0x40054EF")]
		public const short HoneyBed = 1721;

		[global::Cpp2ILInjected.Token(Token = "0x40054F0")]
		public const short SteampunkBed = 1722;

		[global::Cpp2ILInjected.Token(Token = "0x40054F1")]
		public const short LivingWoodWall = 1723;

		[global::Cpp2ILInjected.Token(Token = "0x40054F2")]
		public const short FartinaJar = 1724;

		[global::Cpp2ILInjected.Token(Token = "0x40054F3")]
		public const short Pumpkin = 1725;

		[global::Cpp2ILInjected.Token(Token = "0x40054F4")]
		public const short PumpkinWall = 1726;

		[global::Cpp2ILInjected.Token(Token = "0x40054F5")]
		public const short Hay = 1727;

		[global::Cpp2ILInjected.Token(Token = "0x40054F6")]
		public const short HayWall = 1728;

		[global::Cpp2ILInjected.Token(Token = "0x40054F7")]
		public const short SpookyWood = 1729;

		[global::Cpp2ILInjected.Token(Token = "0x40054F8")]
		public const short SpookyWoodWall = 1730;

		[global::Cpp2ILInjected.Token(Token = "0x40054F9")]
		public const short PumpkinHelmet = 1731;

		[global::Cpp2ILInjected.Token(Token = "0x40054FA")]
		public const short PumpkinBreastplate = 1732;

		[global::Cpp2ILInjected.Token(Token = "0x40054FB")]
		public const short PumpkinLeggings = 1733;

		[global::Cpp2ILInjected.Token(Token = "0x40054FC")]
		public const short CandyApple = 1734;

		[global::Cpp2ILInjected.Token(Token = "0x40054FD")]
		public const short SoulCake = 1735;

		[global::Cpp2ILInjected.Token(Token = "0x40054FE")]
		public const short NurseHat = 1736;

		[global::Cpp2ILInjected.Token(Token = "0x40054FF")]
		public const short NurseShirt = 1737;

		[global::Cpp2ILInjected.Token(Token = "0x4005500")]
		public const short NursePants = 1738;

		[global::Cpp2ILInjected.Token(Token = "0x4005501")]
		public const short WizardsHat = 1739;

		[global::Cpp2ILInjected.Token(Token = "0x4005502")]
		public const short GuyFawkesMask = 1740;

		[global::Cpp2ILInjected.Token(Token = "0x4005503")]
		public const short DyeTraderRobe = 1741;

		[global::Cpp2ILInjected.Token(Token = "0x4005504")]
		public const short SteampunkGoggles = 1742;

		[global::Cpp2ILInjected.Token(Token = "0x4005505")]
		public const short CyborgHelmet = 1743;

		[global::Cpp2ILInjected.Token(Token = "0x4005506")]
		public const short CyborgShirt = 1744;

		[global::Cpp2ILInjected.Token(Token = "0x4005507")]
		public const short CyborgPants = 1745;

		[global::Cpp2ILInjected.Token(Token = "0x4005508")]
		public const short CreeperMask = 1746;

		[global::Cpp2ILInjected.Token(Token = "0x4005509")]
		public const short CreeperShirt = 1747;

		[global::Cpp2ILInjected.Token(Token = "0x400550A")]
		public const short CreeperPants = 1748;

		[global::Cpp2ILInjected.Token(Token = "0x400550B")]
		public const short CatMask = 1749;

		[global::Cpp2ILInjected.Token(Token = "0x400550C")]
		public const short CatShirt = 1750;

		[global::Cpp2ILInjected.Token(Token = "0x400550D")]
		public const short CatPants = 1751;

		[global::Cpp2ILInjected.Token(Token = "0x400550E")]
		public const short GhostMask = 1752;

		[global::Cpp2ILInjected.Token(Token = "0x400550F")]
		public const short GhostShirt = 1753;

		[global::Cpp2ILInjected.Token(Token = "0x4005510")]
		public const short PumpkinMask = 1754;

		[global::Cpp2ILInjected.Token(Token = "0x4005511")]
		public const short PumpkinShirt = 1755;

		[global::Cpp2ILInjected.Token(Token = "0x4005512")]
		public const short PumpkinPants = 1756;

		[global::Cpp2ILInjected.Token(Token = "0x4005513")]
		public const short RobotMask = 1757;

		[global::Cpp2ILInjected.Token(Token = "0x4005514")]
		public const short RobotShirt = 1758;

		[global::Cpp2ILInjected.Token(Token = "0x4005515")]
		public const short RobotPants = 1759;

		[global::Cpp2ILInjected.Token(Token = "0x4005516")]
		public const short UnicornMask = 1760;

		[global::Cpp2ILInjected.Token(Token = "0x4005517")]
		public const short UnicornShirt = 1761;

		[global::Cpp2ILInjected.Token(Token = "0x4005518")]
		public const short UnicornPants = 1762;

		[global::Cpp2ILInjected.Token(Token = "0x4005519")]
		public const short VampireMask = 1763;

		[global::Cpp2ILInjected.Token(Token = "0x400551A")]
		public const short VampireShirt = 1764;

		[global::Cpp2ILInjected.Token(Token = "0x400551B")]
		public const short VampirePants = 1765;

		[global::Cpp2ILInjected.Token(Token = "0x400551C")]
		public const short WitchHat = 1766;

		[global::Cpp2ILInjected.Token(Token = "0x400551D")]
		public const short LeprechaunHat = 1767;

		[global::Cpp2ILInjected.Token(Token = "0x400551E")]
		public const short LeprechaunShirt = 1768;

		[global::Cpp2ILInjected.Token(Token = "0x400551F")]
		public const short LeprechaunPants = 1769;

		[global::Cpp2ILInjected.Token(Token = "0x4005520")]
		public const short PixieShirt = 1770;

		[global::Cpp2ILInjected.Token(Token = "0x4005521")]
		public const short PixiePants = 1771;

		[global::Cpp2ILInjected.Token(Token = "0x4005522")]
		public const short PrincessHat = 1772;

		[global::Cpp2ILInjected.Token(Token = "0x4005523")]
		public const short PrincessDressNew = 1773;

		[global::Cpp2ILInjected.Token(Token = "0x4005524")]
		public const short GoodieBag = 1774;

		[global::Cpp2ILInjected.Token(Token = "0x4005525")]
		public const short WitchDress = 1775;

		[global::Cpp2ILInjected.Token(Token = "0x4005526")]
		public const short WitchBoots = 1776;

		[global::Cpp2ILInjected.Token(Token = "0x4005527")]
		public const short BrideofFrankensteinMask = 1777;

		[global::Cpp2ILInjected.Token(Token = "0x4005528")]
		public const short BrideofFrankensteinDress = 1778;

		[global::Cpp2ILInjected.Token(Token = "0x4005529")]
		public const short KarateTortoiseMask = 1779;

		[global::Cpp2ILInjected.Token(Token = "0x400552A")]
		public const short KarateTortoiseShirt = 1780;

		[global::Cpp2ILInjected.Token(Token = "0x400552B")]
		public const short KarateTortoisePants = 1781;

		[global::Cpp2ILInjected.Token(Token = "0x400552C")]
		public const short CandyCornRifle = 1782;

		[global::Cpp2ILInjected.Token(Token = "0x400552D")]
		public const short CandyCorn = 1783;

		[global::Cpp2ILInjected.Token(Token = "0x400552E")]
		public const short JackOLanternLauncher = 1784;

		[global::Cpp2ILInjected.Token(Token = "0x400552F")]
		public const short ExplosiveJackOLantern = 1785;

		[global::Cpp2ILInjected.Token(Token = "0x4005530")]
		public const short Sickle = 1786;

		[global::Cpp2ILInjected.Token(Token = "0x4005531")]
		public const short PumpkinPie = 1787;

		[global::Cpp2ILInjected.Token(Token = "0x4005532")]
		public const short ScarecrowHat = 1788;

		[global::Cpp2ILInjected.Token(Token = "0x4005533")]
		public const short ScarecrowShirt = 1789;

		[global::Cpp2ILInjected.Token(Token = "0x4005534")]
		public const short ScarecrowPants = 1790;

		[global::Cpp2ILInjected.Token(Token = "0x4005535")]
		public const short Cauldron = 1791;

		[global::Cpp2ILInjected.Token(Token = "0x4005536")]
		public const short PumpkinChair = 1792;

		[global::Cpp2ILInjected.Token(Token = "0x4005537")]
		public const short PumpkinDoor = 1793;

		[global::Cpp2ILInjected.Token(Token = "0x4005538")]
		public const short PumpkinTable = 1794;

		[global::Cpp2ILInjected.Token(Token = "0x4005539")]
		public const short PumpkinWorkBench = 1795;

		[global::Cpp2ILInjected.Token(Token = "0x400553A")]
		public const short PumpkinPlatform = 1796;

		[global::Cpp2ILInjected.Token(Token = "0x400553B")]
		public const short TatteredFairyWings = 1797;

		[global::Cpp2ILInjected.Token(Token = "0x400553C")]
		public const short SpiderEgg = 1798;

		[global::Cpp2ILInjected.Token(Token = "0x400553D")]
		public const short MagicalPumpkinSeed = 1799;

		[global::Cpp2ILInjected.Token(Token = "0x400553E")]
		public const short BatHook = 1800;

		[global::Cpp2ILInjected.Token(Token = "0x400553F")]
		public const short BatScepter = 1801;

		[global::Cpp2ILInjected.Token(Token = "0x4005540")]
		public const short RavenStaff = 1802;

		[global::Cpp2ILInjected.Token(Token = "0x4005541")]
		public const short JungleKeyMold = 1803;

		[global::Cpp2ILInjected.Token(Token = "0x4005542")]
		public const short CorruptionKeyMold = 1804;

		[global::Cpp2ILInjected.Token(Token = "0x4005543")]
		public const short CrimsonKeyMold = 1805;

		[global::Cpp2ILInjected.Token(Token = "0x4005544")]
		public const short HallowedKeyMold = 1806;

		[global::Cpp2ILInjected.Token(Token = "0x4005545")]
		public const short FrozenKeyMold = 1807;

		[global::Cpp2ILInjected.Token(Token = "0x4005546")]
		public const short HangingJackOLantern = 1808;

		[global::Cpp2ILInjected.Token(Token = "0x4005547")]
		public const short RottenEgg = 1809;

		[global::Cpp2ILInjected.Token(Token = "0x4005548")]
		public const short UnluckyYarn = 1810;

		[global::Cpp2ILInjected.Token(Token = "0x4005549")]
		public const short BlackFairyDust = 1811;

		[global::Cpp2ILInjected.Token(Token = "0x400554A")]
		public const short Jackelier = 1812;

		[global::Cpp2ILInjected.Token(Token = "0x400554B")]
		public const short JackOLantern = 1813;

		[global::Cpp2ILInjected.Token(Token = "0x400554C")]
		public const short SpookyChair = 1814;

		[global::Cpp2ILInjected.Token(Token = "0x400554D")]
		public const short SpookyDoor = 1815;

		[global::Cpp2ILInjected.Token(Token = "0x400554E")]
		public const short SpookyTable = 1816;

		[global::Cpp2ILInjected.Token(Token = "0x400554F")]
		public const short SpookyWorkBench = 1817;

		[global::Cpp2ILInjected.Token(Token = "0x4005550")]
		public const short SpookyPlatform = 1818;

		[global::Cpp2ILInjected.Token(Token = "0x4005551")]
		public const short ReaperHood = 1819;

		[global::Cpp2ILInjected.Token(Token = "0x4005552")]
		public const short ReaperRobe = 1820;

		[global::Cpp2ILInjected.Token(Token = "0x4005553")]
		public const short FoxMask = 1821;

		[global::Cpp2ILInjected.Token(Token = "0x4005554")]
		public const short FoxShirt = 1822;

		[global::Cpp2ILInjected.Token(Token = "0x4005555")]
		public const short FoxPants = 1823;

		[global::Cpp2ILInjected.Token(Token = "0x4005556")]
		public const short CatEars = 1824;

		[global::Cpp2ILInjected.Token(Token = "0x4005557")]
		public const short BloodyMachete = 1825;

		[global::Cpp2ILInjected.Token(Token = "0x4005558")]
		public const short TheHorsemansBlade = 1826;

		[global::Cpp2ILInjected.Token(Token = "0x4005559")]
		public const short BladedGlove = 1827;

		[global::Cpp2ILInjected.Token(Token = "0x400555A")]
		public const short PumpkinSeed = 1828;

		[global::Cpp2ILInjected.Token(Token = "0x400555B")]
		public const short SpookyHook = 1829;

		[global::Cpp2ILInjected.Token(Token = "0x400555C")]
		public const short SpookyWings = 1830;

		[global::Cpp2ILInjected.Token(Token = "0x400555D")]
		public const short SpookyTwig = 1831;

		[global::Cpp2ILInjected.Token(Token = "0x400555E")]
		public const short SpookyHelmet = 1832;

		[global::Cpp2ILInjected.Token(Token = "0x400555F")]
		public const short SpookyBreastplate = 1833;

		[global::Cpp2ILInjected.Token(Token = "0x4005560")]
		public const short SpookyLeggings = 1834;

		[global::Cpp2ILInjected.Token(Token = "0x4005561")]
		public const short StakeLauncher = 1835;

		[global::Cpp2ILInjected.Token(Token = "0x4005562")]
		public const short Stake = 1836;

		[global::Cpp2ILInjected.Token(Token = "0x4005563")]
		public const short CursedSapling = 1837;

		[global::Cpp2ILInjected.Token(Token = "0x4005564")]
		public const short SpaceCreatureMask = 1838;

		[global::Cpp2ILInjected.Token(Token = "0x4005565")]
		public const short SpaceCreatureShirt = 1839;

		[global::Cpp2ILInjected.Token(Token = "0x4005566")]
		public const short SpaceCreaturePants = 1840;

		[global::Cpp2ILInjected.Token(Token = "0x4005567")]
		public const short WolfMask = 1841;

		[global::Cpp2ILInjected.Token(Token = "0x4005568")]
		public const short WolfShirt = 1842;

		[global::Cpp2ILInjected.Token(Token = "0x4005569")]
		public const short WolfPants = 1843;

		[global::Cpp2ILInjected.Token(Token = "0x400556A")]
		public const short PumpkinMoonMedallion = 1844;

		[global::Cpp2ILInjected.Token(Token = "0x400556B")]
		public const short NecromanticScroll = 1845;

		[global::Cpp2ILInjected.Token(Token = "0x400556C")]
		public const short JackingSkeletron = 1846;

		[global::Cpp2ILInjected.Token(Token = "0x400556D")]
		public const short BitterHarvest = 1847;

		[global::Cpp2ILInjected.Token(Token = "0x400556E")]
		public const short BloodMoonCountess = 1848;

		[global::Cpp2ILInjected.Token(Token = "0x400556F")]
		public const short HallowsEve = 1849;

		[global::Cpp2ILInjected.Token(Token = "0x4005570")]
		public const short MorbidCuriosity = 1850;

		[global::Cpp2ILInjected.Token(Token = "0x4005571")]
		public const short TreasureHunterShirt = 1851;

		[global::Cpp2ILInjected.Token(Token = "0x4005572")]
		public const short TreasureHunterPants = 1852;

		[global::Cpp2ILInjected.Token(Token = "0x4005573")]
		public const short DryadCoverings = 1853;

		[global::Cpp2ILInjected.Token(Token = "0x4005574")]
		public const short DryadLoincloth = 1854;

		[global::Cpp2ILInjected.Token(Token = "0x4005575")]
		public const short MourningWoodTrophy = 1855;

		[global::Cpp2ILInjected.Token(Token = "0x4005576")]
		public const short PumpkingTrophy = 1856;

		[global::Cpp2ILInjected.Token(Token = "0x4005577")]
		public const short JackOLanternMask = 1857;

		[global::Cpp2ILInjected.Token(Token = "0x4005578")]
		public const short SniperScope = 1858;

		[global::Cpp2ILInjected.Token(Token = "0x4005579")]
		public const short HeartLantern = 1859;

		[global::Cpp2ILInjected.Token(Token = "0x400557A")]
		public const short JellyfishDivingGear = 1860;

		[global::Cpp2ILInjected.Token(Token = "0x400557B")]
		public const short ArcticDivingGear = 1861;

		[global::Cpp2ILInjected.Token(Token = "0x400557C")]
		public const short FrostsparkBoots = 1862;

		[global::Cpp2ILInjected.Token(Token = "0x400557D")]
		public const short FartInABalloon = 1863;

		[global::Cpp2ILInjected.Token(Token = "0x400557E")]
		public const short PapyrusScarab = 1864;

		[global::Cpp2ILInjected.Token(Token = "0x400557F")]
		public const short CelestialStone = 1865;

		[global::Cpp2ILInjected.Token(Token = "0x4005580")]
		public const short Hoverboard = 1866;

		[global::Cpp2ILInjected.Token(Token = "0x4005581")]
		public const short CandyCane = 1867;

		[global::Cpp2ILInjected.Token(Token = "0x4005582")]
		public const short SugarPlum = 1868;

		[global::Cpp2ILInjected.Token(Token = "0x4005583")]
		public const short Present = 1869;

		[global::Cpp2ILInjected.Token(Token = "0x4005584")]
		public const short RedRyder = 1870;

		[global::Cpp2ILInjected.Token(Token = "0x4005585")]
		public const short FestiveWings = 1871;

		[global::Cpp2ILInjected.Token(Token = "0x4005586")]
		public const short PineTreeBlock = 1872;

		[global::Cpp2ILInjected.Token(Token = "0x4005587")]
		public const short ChristmasTree = 1873;

		[global::Cpp2ILInjected.Token(Token = "0x4005588")]
		public const short StarTopper1 = 1874;

		[global::Cpp2ILInjected.Token(Token = "0x4005589")]
		public const short StarTopper2 = 1875;

		[global::Cpp2ILInjected.Token(Token = "0x400558A")]
		public const short StarTopper3 = 1876;

		[global::Cpp2ILInjected.Token(Token = "0x400558B")]
		public const short BowTopper = 1877;

		[global::Cpp2ILInjected.Token(Token = "0x400558C")]
		public const short WhiteGarland = 1878;

		[global::Cpp2ILInjected.Token(Token = "0x400558D")]
		public const short WhiteAndRedGarland = 1879;

		[global::Cpp2ILInjected.Token(Token = "0x400558E")]
		public const short RedGardland = 1880;

		[global::Cpp2ILInjected.Token(Token = "0x400558F")]
		public const short RedAndGreenGardland = 1881;

		[global::Cpp2ILInjected.Token(Token = "0x4005590")]
		public const short GreenGardland = 1882;

		[global::Cpp2ILInjected.Token(Token = "0x4005591")]
		public const short GreenAndWhiteGarland = 1883;

		[global::Cpp2ILInjected.Token(Token = "0x4005592")]
		public const short MulticoloredBulb = 1884;

		[global::Cpp2ILInjected.Token(Token = "0x4005593")]
		public const short RedBulb = 1885;

		[global::Cpp2ILInjected.Token(Token = "0x4005594")]
		public const short YellowBulb = 1886;

		[global::Cpp2ILInjected.Token(Token = "0x4005595")]
		public const short GreenBulb = 1887;

		[global::Cpp2ILInjected.Token(Token = "0x4005596")]
		public const short RedAndGreenBulb = 1888;

		[global::Cpp2ILInjected.Token(Token = "0x4005597")]
		public const short YellowAndGreenBulb = 1889;

		[global::Cpp2ILInjected.Token(Token = "0x4005598")]
		public const short RedAndYellowBulb = 1890;

		[global::Cpp2ILInjected.Token(Token = "0x4005599")]
		public const short WhiteBulb = 1891;

		[global::Cpp2ILInjected.Token(Token = "0x400559A")]
		public const short WhiteAndRedBulb = 1892;

		[global::Cpp2ILInjected.Token(Token = "0x400559B")]
		public const short WhiteAndYellowBulb = 1893;

		[global::Cpp2ILInjected.Token(Token = "0x400559C")]
		public const short WhiteAndGreenBulb = 1894;

		[global::Cpp2ILInjected.Token(Token = "0x400559D")]
		public const short MulticoloredLights = 1895;

		[global::Cpp2ILInjected.Token(Token = "0x400559E")]
		public const short RedLights = 1896;

		[global::Cpp2ILInjected.Token(Token = "0x400559F")]
		public const short GreenLights = 1897;

		[global::Cpp2ILInjected.Token(Token = "0x40055A0")]
		public const short BlueLights = 1898;

		[global::Cpp2ILInjected.Token(Token = "0x40055A1")]
		public const short YellowLights = 1899;

		[global::Cpp2ILInjected.Token(Token = "0x40055A2")]
		public const short RedAndYellowLights = 1900;

		[global::Cpp2ILInjected.Token(Token = "0x40055A3")]
		public const short RedAndGreenLights = 1901;

		[global::Cpp2ILInjected.Token(Token = "0x40055A4")]
		public const short YellowAndGreenLights = 1902;

		[global::Cpp2ILInjected.Token(Token = "0x40055A5")]
		public const short BlueAndGreenLights = 1903;

		[global::Cpp2ILInjected.Token(Token = "0x40055A6")]
		public const short RedAndBlueLights = 1904;

		[global::Cpp2ILInjected.Token(Token = "0x40055A7")]
		public const short BlueAndYellowLights = 1905;

		[global::Cpp2ILInjected.Token(Token = "0x40055A8")]
		public const short GiantBow = 1906;

		[global::Cpp2ILInjected.Token(Token = "0x40055A9")]
		public const short ReindeerAntlers = 1907;

		[global::Cpp2ILInjected.Token(Token = "0x40055AA")]
		public const short Holly = 1908;

		[global::Cpp2ILInjected.Token(Token = "0x40055AB")]
		public const short CandyCaneSword = 1909;

		[global::Cpp2ILInjected.Token(Token = "0x40055AC")]
		public const short ElfMelter = 1910;

		[global::Cpp2ILInjected.Token(Token = "0x40055AD")]
		public const short ChristmasPudding = 1911;

		[global::Cpp2ILInjected.Token(Token = "0x40055AE")]
		public const short Eggnog = 1912;

		[global::Cpp2ILInjected.Token(Token = "0x40055AF")]
		public const short StarAnise = 1913;

		[global::Cpp2ILInjected.Token(Token = "0x40055B0")]
		public const short ReindeerBells = 1914;

		[global::Cpp2ILInjected.Token(Token = "0x40055B1")]
		public const short CandyCaneHook = 1915;

		[global::Cpp2ILInjected.Token(Token = "0x40055B2")]
		public const short ChristmasHook = 1916;

		[global::Cpp2ILInjected.Token(Token = "0x40055B3")]
		public const short CnadyCanePickaxe = 1917;

		[global::Cpp2ILInjected.Token(Token = "0x40055B4")]
		public const short FruitcakeChakram = 1918;

		[global::Cpp2ILInjected.Token(Token = "0x40055B5")]
		public const short SugarCookie = 1919;

		[global::Cpp2ILInjected.Token(Token = "0x40055B6")]
		public const short GingerbreadCookie = 1920;

		[global::Cpp2ILInjected.Token(Token = "0x40055B7")]
		public const short HandWarmer = 1921;

		[global::Cpp2ILInjected.Token(Token = "0x40055B8")]
		public const short Coal = 1922;

		[global::Cpp2ILInjected.Token(Token = "0x40055B9")]
		public const short Toolbox = 1923;

		[global::Cpp2ILInjected.Token(Token = "0x40055BA")]
		public const short PineDoor = 1924;

		[global::Cpp2ILInjected.Token(Token = "0x40055BB")]
		public const short PineChair = 1925;

		[global::Cpp2ILInjected.Token(Token = "0x40055BC")]
		public const short PineTable = 1926;

		[global::Cpp2ILInjected.Token(Token = "0x40055BD")]
		public const short DogWhistle = 1927;

		[global::Cpp2ILInjected.Token(Token = "0x40055BE")]
		public const short ChristmasTreeSword = 1928;

		[global::Cpp2ILInjected.Token(Token = "0x40055BF")]
		public const short ChainGun = 1929;

		[global::Cpp2ILInjected.Token(Token = "0x40055C0")]
		public const short Razorpine = 1930;

		[global::Cpp2ILInjected.Token(Token = "0x40055C1")]
		public const short BlizzardStaff = 1931;

		[global::Cpp2ILInjected.Token(Token = "0x40055C2")]
		public const short MrsClauseHat = 1932;

		[global::Cpp2ILInjected.Token(Token = "0x40055C3")]
		public const short MrsClauseShirt = 1933;

		[global::Cpp2ILInjected.Token(Token = "0x40055C4")]
		public const short MrsClauseHeels = 1934;

		[global::Cpp2ILInjected.Token(Token = "0x40055C5")]
		public const short ParkaHood = 1935;

		[global::Cpp2ILInjected.Token(Token = "0x40055C6")]
		public const short ParkaCoat = 1936;

		[global::Cpp2ILInjected.Token(Token = "0x40055C7")]
		public const short ParkaPants = 1937;

		[global::Cpp2ILInjected.Token(Token = "0x40055C8")]
		public const short SnowHat = 1938;

		[global::Cpp2ILInjected.Token(Token = "0x40055C9")]
		public const short UglySweater = 1939;

		[global::Cpp2ILInjected.Token(Token = "0x40055CA")]
		public const short TreeMask = 1940;

		[global::Cpp2ILInjected.Token(Token = "0x40055CB")]
		public const short TreeShirt = 1941;

		[global::Cpp2ILInjected.Token(Token = "0x40055CC")]
		public const short TreeTrunks = 1942;

		[global::Cpp2ILInjected.Token(Token = "0x40055CD")]
		public const short ElfHat = 1943;

		[global::Cpp2ILInjected.Token(Token = "0x40055CE")]
		public const short ElfShirt = 1944;

		[global::Cpp2ILInjected.Token(Token = "0x40055CF")]
		public const short ElfPants = 1945;

		[global::Cpp2ILInjected.Token(Token = "0x40055D0")]
		public const short SnowmanCannon = 1946;

		[global::Cpp2ILInjected.Token(Token = "0x40055D1")]
		public const short NorthPole = 1947;

		[global::Cpp2ILInjected.Token(Token = "0x40055D2")]
		public const short ChristmasTreeWallpaper = 1948;

		[global::Cpp2ILInjected.Token(Token = "0x40055D3")]
		public const short OrnamentWallpaper = 1949;

		[global::Cpp2ILInjected.Token(Token = "0x40055D4")]
		public const short CandyCaneWallpaper = 1950;

		[global::Cpp2ILInjected.Token(Token = "0x40055D5")]
		public const short FestiveWallpaper = 1951;

		[global::Cpp2ILInjected.Token(Token = "0x40055D6")]
		public const short StarsWallpaper = 1952;

		[global::Cpp2ILInjected.Token(Token = "0x40055D7")]
		public const short SquigglesWallpaper = 1953;

		[global::Cpp2ILInjected.Token(Token = "0x40055D8")]
		public const short SnowflakeWallpaper = 1954;

		[global::Cpp2ILInjected.Token(Token = "0x40055D9")]
		public const short KrampusHornWallpaper = 1955;

		[global::Cpp2ILInjected.Token(Token = "0x40055DA")]
		public const short BluegreenWallpaper = 1956;

		[global::Cpp2ILInjected.Token(Token = "0x40055DB")]
		public const short GrinchFingerWallpaper = 1957;

		[global::Cpp2ILInjected.Token(Token = "0x40055DC")]
		public const short NaughtyPresent = 1958;

		[global::Cpp2ILInjected.Token(Token = "0x40055DD")]
		public const short BabyGrinchMischiefWhistle = 1959;

		[global::Cpp2ILInjected.Token(Token = "0x40055DE")]
		public const short IceQueenTrophy = 1960;

		[global::Cpp2ILInjected.Token(Token = "0x40055DF")]
		public const short SantaNK1Trophy = 1961;

		[global::Cpp2ILInjected.Token(Token = "0x40055E0")]
		public const short EverscreamTrophy = 1962;

		[global::Cpp2ILInjected.Token(Token = "0x40055E1")]
		public const short MusicBoxPumpkinMoon = 1963;

		[global::Cpp2ILInjected.Token(Token = "0x40055E2")]
		public const short MusicBoxAltUnderground = 1964;

		[global::Cpp2ILInjected.Token(Token = "0x40055E3")]
		public const short MusicBoxFrostMoon = 1965;

		[global::Cpp2ILInjected.Token(Token = "0x40055E4")]
		public const short BrownPaint = 1966;

		[global::Cpp2ILInjected.Token(Token = "0x40055E5")]
		public const short ShadowPaint = 1967;

		[global::Cpp2ILInjected.Token(Token = "0x40055E6")]
		public const short NegativePaint = 1968;

		[global::Cpp2ILInjected.Token(Token = "0x40055E7")]
		public const short TeamDye = 1969;

		[global::Cpp2ILInjected.Token(Token = "0x40055E8")]
		public const short AmethystGemsparkBlock = 1970;

		[global::Cpp2ILInjected.Token(Token = "0x40055E9")]
		public const short TopazGemsparkBlock = 1971;

		[global::Cpp2ILInjected.Token(Token = "0x40055EA")]
		public const short SapphireGemsparkBlock = 1972;

		[global::Cpp2ILInjected.Token(Token = "0x40055EB")]
		public const short EmeraldGemsparkBlock = 1973;

		[global::Cpp2ILInjected.Token(Token = "0x40055EC")]
		public const short RubyGemsparkBlock = 1974;

		[global::Cpp2ILInjected.Token(Token = "0x40055ED")]
		public const short DiamondGemsparkBlock = 1975;

		[global::Cpp2ILInjected.Token(Token = "0x40055EE")]
		public const short AmberGemsparkBlock = 1976;

		[global::Cpp2ILInjected.Token(Token = "0x40055EF")]
		public const short LifeHairDye = 1977;

		[global::Cpp2ILInjected.Token(Token = "0x40055F0")]
		public const short ManaHairDye = 1978;

		[global::Cpp2ILInjected.Token(Token = "0x40055F1")]
		public const short DepthHairDye = 1979;

		[global::Cpp2ILInjected.Token(Token = "0x40055F2")]
		public const short MoneyHairDye = 1980;

		[global::Cpp2ILInjected.Token(Token = "0x40055F3")]
		public const short TimeHairDye = 1981;

		[global::Cpp2ILInjected.Token(Token = "0x40055F4")]
		public const short TeamHairDye = 1982;

		[global::Cpp2ILInjected.Token(Token = "0x40055F5")]
		public const short BiomeHairDye = 1983;

		[global::Cpp2ILInjected.Token(Token = "0x40055F6")]
		public const short PartyHairDye = 1984;

		[global::Cpp2ILInjected.Token(Token = "0x40055F7")]
		public const short RainbowHairDye = 1985;

		[global::Cpp2ILInjected.Token(Token = "0x40055F8")]
		public const short SpeedHairDye = 1986;

		[global::Cpp2ILInjected.Token(Token = "0x40055F9")]
		public const short AngelHalo = 1987;

		[global::Cpp2ILInjected.Token(Token = "0x40055FA")]
		public const short Fez = 1988;

		[global::Cpp2ILInjected.Token(Token = "0x40055FB")]
		public const short Womannquin = 1989;

		[global::Cpp2ILInjected.Token(Token = "0x40055FC")]
		public const short HairDyeRemover = 1990;

		[global::Cpp2ILInjected.Token(Token = "0x40055FD")]
		public const short BugNet = 1991;

		[global::Cpp2ILInjected.Token(Token = "0x40055FE")]
		public const short Firefly = 1992;

		[global::Cpp2ILInjected.Token(Token = "0x40055FF")]
		public const short FireflyinaBottle = 1993;

		[global::Cpp2ILInjected.Token(Token = "0x4005600")]
		public const short MonarchButterfly = 1994;

		[global::Cpp2ILInjected.Token(Token = "0x4005601")]
		public const short PurpleEmperorButterfly = 1995;

		[global::Cpp2ILInjected.Token(Token = "0x4005602")]
		public const short RedAdmiralButterfly = 1996;

		[global::Cpp2ILInjected.Token(Token = "0x4005603")]
		public const short UlyssesButterfly = 1997;

		[global::Cpp2ILInjected.Token(Token = "0x4005604")]
		public const short SulphurButterfly = 1998;

		[global::Cpp2ILInjected.Token(Token = "0x4005605")]
		public const short TreeNymphButterfly = 1999;

		[global::Cpp2ILInjected.Token(Token = "0x4005606")]
		public const short ZebraSwallowtailButterfly = 2000;

		[global::Cpp2ILInjected.Token(Token = "0x4005607")]
		public const short JuliaButterfly = 2001;

		[global::Cpp2ILInjected.Token(Token = "0x4005608")]
		public const short Worm = 2002;

		[global::Cpp2ILInjected.Token(Token = "0x4005609")]
		public const short Mouse = 2003;

		[global::Cpp2ILInjected.Token(Token = "0x400560A")]
		public const short LightningBug = 2004;

		[global::Cpp2ILInjected.Token(Token = "0x400560B")]
		public const short LightningBuginaBottle = 2005;

		[global::Cpp2ILInjected.Token(Token = "0x400560C")]
		public const short Snail = 2006;

		[global::Cpp2ILInjected.Token(Token = "0x400560D")]
		public const short GlowingSnail = 2007;

		[global::Cpp2ILInjected.Token(Token = "0x400560E")]
		public const short FancyGreyWallpaper = 2008;

		[global::Cpp2ILInjected.Token(Token = "0x400560F")]
		public const short IceFloeWallpaper = 2009;

		[global::Cpp2ILInjected.Token(Token = "0x4005610")]
		public const short MusicWallpaper = 2010;

		[global::Cpp2ILInjected.Token(Token = "0x4005611")]
		public const short PurpleRainWallpaper = 2011;

		[global::Cpp2ILInjected.Token(Token = "0x4005612")]
		public const short RainbowWallpaper = 2012;

		[global::Cpp2ILInjected.Token(Token = "0x4005613")]
		public const short SparkleStoneWallpaper = 2013;

		[global::Cpp2ILInjected.Token(Token = "0x4005614")]
		public const short StarlitHeavenWallpaper = 2014;

		[global::Cpp2ILInjected.Token(Token = "0x4005615")]
		public const short Bird = 2015;

		[global::Cpp2ILInjected.Token(Token = "0x4005616")]
		public const short BlueJay = 2016;

		[global::Cpp2ILInjected.Token(Token = "0x4005617")]
		public const short Cardinal = 2017;

		[global::Cpp2ILInjected.Token(Token = "0x4005618")]
		public const short Squirrel = 2018;

		[global::Cpp2ILInjected.Token(Token = "0x4005619")]
		public const short Bunny = 2019;

		[global::Cpp2ILInjected.Token(Token = "0x400561A")]
		public const short CactusBookcase = 2020;

		[global::Cpp2ILInjected.Token(Token = "0x400561B")]
		public const short EbonwoodBookcase = 2021;

		[global::Cpp2ILInjected.Token(Token = "0x400561C")]
		public const short FleshBookcase = 2022;

		[global::Cpp2ILInjected.Token(Token = "0x400561D")]
		public const short HoneyBookcase = 2023;

		[global::Cpp2ILInjected.Token(Token = "0x400561E")]
		public const short SteampunkBookcase = 2024;

		[global::Cpp2ILInjected.Token(Token = "0x400561F")]
		public const short GlassBookcase = 2025;

		[global::Cpp2ILInjected.Token(Token = "0x4005620")]
		public const short RichMahoganyBookcase = 2026;

		[global::Cpp2ILInjected.Token(Token = "0x4005621")]
		public const short PearlwoodBookcase = 2027;

		[global::Cpp2ILInjected.Token(Token = "0x4005622")]
		public const short SpookyBookcase = 2028;

		[global::Cpp2ILInjected.Token(Token = "0x4005623")]
		public const short SkywareBookcase = 2029;

		[global::Cpp2ILInjected.Token(Token = "0x4005624")]
		public const short LihzahrdBookcase = 2030;

		[global::Cpp2ILInjected.Token(Token = "0x4005625")]
		public const short FrozenBookcase = 2031;

		[global::Cpp2ILInjected.Token(Token = "0x4005626")]
		public const short CactusLantern = 2032;

		[global::Cpp2ILInjected.Token(Token = "0x4005627")]
		public const short EbonwoodLantern = 2033;

		[global::Cpp2ILInjected.Token(Token = "0x4005628")]
		public const short FleshLantern = 2034;

		[global::Cpp2ILInjected.Token(Token = "0x4005629")]
		public const short HoneyLantern = 2035;

		[global::Cpp2ILInjected.Token(Token = "0x400562A")]
		public const short SteampunkLantern = 2036;

		[global::Cpp2ILInjected.Token(Token = "0x400562B")]
		public const short GlassLantern = 2037;

		[global::Cpp2ILInjected.Token(Token = "0x400562C")]
		public const short RichMahoganyLantern = 2038;

		[global::Cpp2ILInjected.Token(Token = "0x400562D")]
		public const short PearlwoodLantern = 2039;

		[global::Cpp2ILInjected.Token(Token = "0x400562E")]
		public const short FrozenLantern = 2040;

		[global::Cpp2ILInjected.Token(Token = "0x400562F")]
		public const short LihzahrdLantern = 2041;

		[global::Cpp2ILInjected.Token(Token = "0x4005630")]
		public const short SkywareLantern = 2042;

		[global::Cpp2ILInjected.Token(Token = "0x4005631")]
		public const short SpookyLantern = 2043;

		[global::Cpp2ILInjected.Token(Token = "0x4005632")]
		public const short FrozenDoor = 2044;

		[global::Cpp2ILInjected.Token(Token = "0x4005633")]
		public const short CactusCandle = 2045;

		[global::Cpp2ILInjected.Token(Token = "0x4005634")]
		public const short EbonwoodCandle = 2046;

		[global::Cpp2ILInjected.Token(Token = "0x4005635")]
		public const short FleshCandle = 2047;

		[global::Cpp2ILInjected.Token(Token = "0x4005636")]
		public const short GlassCandle = 2048;

		[global::Cpp2ILInjected.Token(Token = "0x4005637")]
		public const short FrozenCandle = 2049;

		[global::Cpp2ILInjected.Token(Token = "0x4005638")]
		public const short RichMahoganyCandle = 2050;

		[global::Cpp2ILInjected.Token(Token = "0x4005639")]
		public const short PearlwoodCandle = 2051;

		[global::Cpp2ILInjected.Token(Token = "0x400563A")]
		public const short LihzahrdCandle = 2052;

		[global::Cpp2ILInjected.Token(Token = "0x400563B")]
		public const short SkywareCandle = 2053;

		[global::Cpp2ILInjected.Token(Token = "0x400563C")]
		public const short PumpkinCandle = 2054;

		[global::Cpp2ILInjected.Token(Token = "0x400563D")]
		public const short CactusChandelier = 2055;

		[global::Cpp2ILInjected.Token(Token = "0x400563E")]
		public const short EbonwoodChandelier = 2056;

		[global::Cpp2ILInjected.Token(Token = "0x400563F")]
		public const short FleshChandelier = 2057;

		[global::Cpp2ILInjected.Token(Token = "0x4005640")]
		public const short HoneyChandelier = 2058;

		[global::Cpp2ILInjected.Token(Token = "0x4005641")]
		public const short FrozenChandelier = 2059;

		[global::Cpp2ILInjected.Token(Token = "0x4005642")]
		public const short RichMahoganyChandelier = 2060;

		[global::Cpp2ILInjected.Token(Token = "0x4005643")]
		public const short PearlwoodChandelier = 2061;

		[global::Cpp2ILInjected.Token(Token = "0x4005644")]
		public const short LihzahrdChandelier = 2062;

		[global::Cpp2ILInjected.Token(Token = "0x4005645")]
		public const short SkywareChandelier = 2063;

		[global::Cpp2ILInjected.Token(Token = "0x4005646")]
		public const short SpookyChandelier = 2064;

		[global::Cpp2ILInjected.Token(Token = "0x4005647")]
		public const short GlassChandelier = 2065;

		[global::Cpp2ILInjected.Token(Token = "0x4005648")]
		public const short CactusBed = 2066;

		[global::Cpp2ILInjected.Token(Token = "0x4005649")]
		public const short FleshBed = 2067;

		[global::Cpp2ILInjected.Token(Token = "0x400564A")]
		public const short FrozenBed = 2068;

		[global::Cpp2ILInjected.Token(Token = "0x400564B")]
		public const short LihzahrdBed = 2069;

		[global::Cpp2ILInjected.Token(Token = "0x400564C")]
		public const short SkywareBed = 2070;

		[global::Cpp2ILInjected.Token(Token = "0x400564D")]
		public const short SpookyBed = 2071;

		[global::Cpp2ILInjected.Token(Token = "0x400564E")]
		public const short CactusBathtub = 2072;

		[global::Cpp2ILInjected.Token(Token = "0x400564F")]
		public const short EbonwoodBathtub = 2073;

		[global::Cpp2ILInjected.Token(Token = "0x4005650")]
		public const short FleshBathtub = 2074;

		[global::Cpp2ILInjected.Token(Token = "0x4005651")]
		public const short GlassBathtub = 2075;

		[global::Cpp2ILInjected.Token(Token = "0x4005652")]
		public const short FrozenBathtub = 2076;

		[global::Cpp2ILInjected.Token(Token = "0x4005653")]
		public const short RichMahoganyBathtub = 2077;

		[global::Cpp2ILInjected.Token(Token = "0x4005654")]
		public const short PearlwoodBathtub = 2078;

		[global::Cpp2ILInjected.Token(Token = "0x4005655")]
		public const short LihzahrdBathtub = 2079;

		[global::Cpp2ILInjected.Token(Token = "0x4005656")]
		public const short SkywareBathtub = 2080;

		[global::Cpp2ILInjected.Token(Token = "0x4005657")]
		public const short SpookyBathtub = 2081;

		[global::Cpp2ILInjected.Token(Token = "0x4005658")]
		public const short CactusLamp = 2082;

		[global::Cpp2ILInjected.Token(Token = "0x4005659")]
		public const short EbonwoodLamp = 2083;

		[global::Cpp2ILInjected.Token(Token = "0x400565A")]
		public const short FleshLamp = 2084;

		[global::Cpp2ILInjected.Token(Token = "0x400565B")]
		public const short GlassLamp = 2085;

		[global::Cpp2ILInjected.Token(Token = "0x400565C")]
		public const short FrozenLamp = 2086;

		[global::Cpp2ILInjected.Token(Token = "0x400565D")]
		public const short RichMahoganyLamp = 2087;

		[global::Cpp2ILInjected.Token(Token = "0x400565E")]
		public const short PearlwoodLamp = 2088;

		[global::Cpp2ILInjected.Token(Token = "0x400565F")]
		public const short LihzahrdLamp = 2089;

		[global::Cpp2ILInjected.Token(Token = "0x4005660")]
		public const short SkywareLamp = 2090;

		[global::Cpp2ILInjected.Token(Token = "0x4005661")]
		public const short SpookyLamp = 2091;

		[global::Cpp2ILInjected.Token(Token = "0x4005662")]
		public const short CactusCandelabra = 2092;

		[global::Cpp2ILInjected.Token(Token = "0x4005663")]
		public const short EbonwoodCandelabra = 2093;

		[global::Cpp2ILInjected.Token(Token = "0x4005664")]
		public const short FleshCandelabra = 2094;

		[global::Cpp2ILInjected.Token(Token = "0x4005665")]
		public const short HoneyCandelabra = 2095;

		[global::Cpp2ILInjected.Token(Token = "0x4005666")]
		public const short SteampunkCandelabra = 2096;

		[global::Cpp2ILInjected.Token(Token = "0x4005667")]
		public const short GlassCandelabra = 2097;

		[global::Cpp2ILInjected.Token(Token = "0x4005668")]
		public const short RichMahoganyCandelabra = 2098;

		[global::Cpp2ILInjected.Token(Token = "0x4005669")]
		public const short PearlwoodCandelabra = 2099;

		[global::Cpp2ILInjected.Token(Token = "0x400566A")]
		public const short FrozenCandelabra = 2100;

		[global::Cpp2ILInjected.Token(Token = "0x400566B")]
		public const short LihzahrdCandelabra = 2101;

		[global::Cpp2ILInjected.Token(Token = "0x400566C")]
		public const short SkywareCandelabra = 2102;

		[global::Cpp2ILInjected.Token(Token = "0x400566D")]
		public const short SpookyCandelabra = 2103;

		[global::Cpp2ILInjected.Token(Token = "0x400566E")]
		public const short BrainMask = 2104;

		[global::Cpp2ILInjected.Token(Token = "0x400566F")]
		public const short FleshMask = 2105;

		[global::Cpp2ILInjected.Token(Token = "0x4005670")]
		public const short TwinMask = 2106;

		[global::Cpp2ILInjected.Token(Token = "0x4005671")]
		public const short SkeletronPrimeMask = 2107;

		[global::Cpp2ILInjected.Token(Token = "0x4005672")]
		public const short BeeMask = 2108;

		[global::Cpp2ILInjected.Token(Token = "0x4005673")]
		public const short PlanteraMask = 2109;

		[global::Cpp2ILInjected.Token(Token = "0x4005674")]
		public const short GolemMask = 2110;

		[global::Cpp2ILInjected.Token(Token = "0x4005675")]
		public const short EaterMask = 2111;

		[global::Cpp2ILInjected.Token(Token = "0x4005676")]
		public const short EyeMask = 2112;

		[global::Cpp2ILInjected.Token(Token = "0x4005677")]
		public const short DestroyerMask = 2113;

		[global::Cpp2ILInjected.Token(Token = "0x4005678")]
		public const short BlacksmithRack = 2114;

		[global::Cpp2ILInjected.Token(Token = "0x4005679")]
		public const short CarpentryRack = 2115;

		[global::Cpp2ILInjected.Token(Token = "0x400567A")]
		public const short HelmetRack = 2116;

		[global::Cpp2ILInjected.Token(Token = "0x400567B")]
		public const short SpearRack = 2117;

		[global::Cpp2ILInjected.Token(Token = "0x400567C")]
		public const short SwordRack = 2118;

		[global::Cpp2ILInjected.Token(Token = "0x400567D")]
		public const short StoneSlab = 2119;

		[global::Cpp2ILInjected.Token(Token = "0x400567E")]
		public const short SandstoneSlab = 2120;

		[global::Cpp2ILInjected.Token(Token = "0x400567F")]
		public const short Frog = 2121;

		[global::Cpp2ILInjected.Token(Token = "0x4005680")]
		public const short MallardDuck = 2122;

		[global::Cpp2ILInjected.Token(Token = "0x4005681")]
		public const short Duck = 2123;

		[global::Cpp2ILInjected.Token(Token = "0x4005682")]
		public const short HoneyBathtub = 2124;

		[global::Cpp2ILInjected.Token(Token = "0x4005683")]
		public const short SteampunkBathtub = 2125;

		[global::Cpp2ILInjected.Token(Token = "0x4005684")]
		public const short LivingWoodBathtub = 2126;

		[global::Cpp2ILInjected.Token(Token = "0x4005685")]
		public const short ShadewoodBathtub = 2127;

		[global::Cpp2ILInjected.Token(Token = "0x4005686")]
		public const short BoneBathtub = 2128;

		[global::Cpp2ILInjected.Token(Token = "0x4005687")]
		public const short HoneyLamp = 2129;

		[global::Cpp2ILInjected.Token(Token = "0x4005688")]
		public const short SteampunkLamp = 2130;

		[global::Cpp2ILInjected.Token(Token = "0x4005689")]
		public const short LivingWoodLamp = 2131;

		[global::Cpp2ILInjected.Token(Token = "0x400568A")]
		public const short ShadewoodLamp = 2132;

		[global::Cpp2ILInjected.Token(Token = "0x400568B")]
		public const short GoldenLamp = 2133;

		[global::Cpp2ILInjected.Token(Token = "0x400568C")]
		public const short BoneLamp = 2134;

		[global::Cpp2ILInjected.Token(Token = "0x400568D")]
		public const short LivingWoodBookcase = 2135;

		[global::Cpp2ILInjected.Token(Token = "0x400568E")]
		public const short ShadewoodBookcase = 2136;

		[global::Cpp2ILInjected.Token(Token = "0x400568F")]
		public const short GoldenBookcase = 2137;

		[global::Cpp2ILInjected.Token(Token = "0x4005690")]
		public const short BoneBookcase = 2138;

		[global::Cpp2ILInjected.Token(Token = "0x4005691")]
		public const short LivingWoodBed = 2139;

		[global::Cpp2ILInjected.Token(Token = "0x4005692")]
		public const short BoneBed = 2140;

		[global::Cpp2ILInjected.Token(Token = "0x4005693")]
		public const short LivingWoodChandelier = 2141;

		[global::Cpp2ILInjected.Token(Token = "0x4005694")]
		public const short ShadewoodChandelier = 2142;

		[global::Cpp2ILInjected.Token(Token = "0x4005695")]
		public const short GoldenChandelier = 2143;

		[global::Cpp2ILInjected.Token(Token = "0x4005696")]
		public const short BoneChandelier = 2144;

		[global::Cpp2ILInjected.Token(Token = "0x4005697")]
		public const short LivingWoodLantern = 2145;

		[global::Cpp2ILInjected.Token(Token = "0x4005698")]
		public const short ShadewoodLantern = 2146;

		[global::Cpp2ILInjected.Token(Token = "0x4005699")]
		public const short GoldenLantern = 2147;

		[global::Cpp2ILInjected.Token(Token = "0x400569A")]
		public const short BoneLantern = 2148;

		[global::Cpp2ILInjected.Token(Token = "0x400569B")]
		public const short LivingWoodCandelabra = 2149;

		[global::Cpp2ILInjected.Token(Token = "0x400569C")]
		public const short ShadewoodCandelabra = 2150;

		[global::Cpp2ILInjected.Token(Token = "0x400569D")]
		public const short GoldenCandelabra = 2151;

		[global::Cpp2ILInjected.Token(Token = "0x400569E")]
		public const short BoneCandelabra = 2152;

		[global::Cpp2ILInjected.Token(Token = "0x400569F")]
		public const short LivingWoodCandle = 2153;

		[global::Cpp2ILInjected.Token(Token = "0x40056A0")]
		public const short ShadewoodCandle = 2154;

		[global::Cpp2ILInjected.Token(Token = "0x40056A1")]
		public const short GoldenCandle = 2155;

		[global::Cpp2ILInjected.Token(Token = "0x40056A2")]
		public const short BlackScorpion = 2156;

		[global::Cpp2ILInjected.Token(Token = "0x40056A3")]
		public const short Scorpion = 2157;

		[global::Cpp2ILInjected.Token(Token = "0x40056A4")]
		public const short BubbleWallpaper = 2158;

		[global::Cpp2ILInjected.Token(Token = "0x40056A5")]
		public const short CopperPipeWallpaper = 2159;

		[global::Cpp2ILInjected.Token(Token = "0x40056A6")]
		public const short DuckyWallpaper = 2160;

		[global::Cpp2ILInjected.Token(Token = "0x40056A7")]
		public const short FrostCore = 2161;

		[global::Cpp2ILInjected.Token(Token = "0x40056A8")]
		public const short BunnyCage = 2162;

		[global::Cpp2ILInjected.Token(Token = "0x40056A9")]
		public const short SquirrelCage = 2163;

		[global::Cpp2ILInjected.Token(Token = "0x40056AA")]
		public const short MallardDuckCage = 2164;

		[global::Cpp2ILInjected.Token(Token = "0x40056AB")]
		public const short DuckCage = 2165;

		[global::Cpp2ILInjected.Token(Token = "0x40056AC")]
		public const short BirdCage = 2166;

		[global::Cpp2ILInjected.Token(Token = "0x40056AD")]
		public const short BlueJayCage = 2167;

		[global::Cpp2ILInjected.Token(Token = "0x40056AE")]
		public const short CardinalCage = 2168;

		[global::Cpp2ILInjected.Token(Token = "0x40056AF")]
		public const short WaterfallWall = 2169;

		[global::Cpp2ILInjected.Token(Token = "0x40056B0")]
		public const short LavafallWall = 2170;

		[global::Cpp2ILInjected.Token(Token = "0x40056B1")]
		public const short CrimsonSeeds = 2171;

		[global::Cpp2ILInjected.Token(Token = "0x40056B2")]
		public const short HeavyWorkBench = 2172;

		[global::Cpp2ILInjected.Token(Token = "0x40056B3")]
		public const short CopperPlating = 2173;

		[global::Cpp2ILInjected.Token(Token = "0x40056B4")]
		public const short SnailCage = 2174;

		[global::Cpp2ILInjected.Token(Token = "0x40056B5")]
		public const short GlowingSnailCage = 2175;

		[global::Cpp2ILInjected.Token(Token = "0x40056B6")]
		public const short ShroomiteDiggingClaw = 2176;

		[global::Cpp2ILInjected.Token(Token = "0x40056B7")]
		public const short AmmoBox = 2177;

		[global::Cpp2ILInjected.Token(Token = "0x40056B8")]
		public const short MonarchButterflyJar = 2178;

		[global::Cpp2ILInjected.Token(Token = "0x40056B9")]
		public const short PurpleEmperorButterflyJar = 2179;

		[global::Cpp2ILInjected.Token(Token = "0x40056BA")]
		public const short RedAdmiralButterflyJar = 2180;

		[global::Cpp2ILInjected.Token(Token = "0x40056BB")]
		public const short UlyssesButterflyJar = 2181;

		[global::Cpp2ILInjected.Token(Token = "0x40056BC")]
		public const short SulphurButterflyJar = 2182;

		[global::Cpp2ILInjected.Token(Token = "0x40056BD")]
		public const short TreeNymphButterflyJar = 2183;

		[global::Cpp2ILInjected.Token(Token = "0x40056BE")]
		public const short ZebraSwallowtailButterflyJar = 2184;

		[global::Cpp2ILInjected.Token(Token = "0x40056BF")]
		public const short JuliaButterflyJar = 2185;

		[global::Cpp2ILInjected.Token(Token = "0x40056C0")]
		public const short ScorpionCage = 2186;

		[global::Cpp2ILInjected.Token(Token = "0x40056C1")]
		public const short BlackScorpionCage = 2187;

		[global::Cpp2ILInjected.Token(Token = "0x40056C2")]
		public const short VenomStaff = 2188;

		[global::Cpp2ILInjected.Token(Token = "0x40056C3")]
		public const short SpectreMask = 2189;

		[global::Cpp2ILInjected.Token(Token = "0x40056C4")]
		public const short FrogCage = 2190;

		[global::Cpp2ILInjected.Token(Token = "0x40056C5")]
		public const short MouseCage = 2191;

		[global::Cpp2ILInjected.Token(Token = "0x40056C6")]
		public const short BoneWelder = 2192;

		[global::Cpp2ILInjected.Token(Token = "0x40056C7")]
		public const short FleshCloningVaat = 2193;

		[global::Cpp2ILInjected.Token(Token = "0x40056C8")]
		public const short GlassKiln = 2194;

		[global::Cpp2ILInjected.Token(Token = "0x40056C9")]
		public const short LihzahrdFurnace = 2195;

		[global::Cpp2ILInjected.Token(Token = "0x40056CA")]
		public const short LivingLoom = 2196;

		[global::Cpp2ILInjected.Token(Token = "0x40056CB")]
		public const short SkyMill = 2197;

		[global::Cpp2ILInjected.Token(Token = "0x40056CC")]
		public const short IceMachine = 2198;

		[global::Cpp2ILInjected.Token(Token = "0x40056CD")]
		public const short BeetleHelmet = 2199;

		[global::Cpp2ILInjected.Token(Token = "0x40056CE")]
		public const short BeetleScaleMail = 2200;

		[global::Cpp2ILInjected.Token(Token = "0x40056CF")]
		public const short BeetleShell = 2201;

		[global::Cpp2ILInjected.Token(Token = "0x40056D0")]
		public const short BeetleLeggings = 2202;

		[global::Cpp2ILInjected.Token(Token = "0x40056D1")]
		public const short SteampunkBoiler = 2203;

		[global::Cpp2ILInjected.Token(Token = "0x40056D2")]
		public const short HoneyDispenser = 2204;

		[global::Cpp2ILInjected.Token(Token = "0x40056D3")]
		public const short Penguin = 2205;

		[global::Cpp2ILInjected.Token(Token = "0x40056D4")]
		public const short PenguinCage = 2206;

		[global::Cpp2ILInjected.Token(Token = "0x40056D5")]
		public const short WormCage = 2207;

		[global::Cpp2ILInjected.Token(Token = "0x40056D6")]
		public const short Terrarium = 2208;

		[global::Cpp2ILInjected.Token(Token = "0x40056D7")]
		public const short SuperManaPotion = 2209;

		[global::Cpp2ILInjected.Token(Token = "0x40056D8")]
		public const short EbonwoodFence = 2210;

		[global::Cpp2ILInjected.Token(Token = "0x40056D9")]
		public const short RichMahoganyFence = 2211;

		[global::Cpp2ILInjected.Token(Token = "0x40056DA")]
		public const short PearlwoodFence = 2212;

		[global::Cpp2ILInjected.Token(Token = "0x40056DB")]
		public const short ShadewoodFence = 2213;

		[global::Cpp2ILInjected.Token(Token = "0x40056DC")]
		public const short BrickLayer = 2214;

		[global::Cpp2ILInjected.Token(Token = "0x40056DD")]
		public const short ExtendoGrip = 2215;

		[global::Cpp2ILInjected.Token(Token = "0x40056DE")]
		public const short PaintSprayer = 2216;

		[global::Cpp2ILInjected.Token(Token = "0x40056DF")]
		public const short PortableCementMixer = 2217;

		[global::Cpp2ILInjected.Token(Token = "0x40056E0")]
		public const short BeetleHusk = 2218;

		[global::Cpp2ILInjected.Token(Token = "0x40056E1")]
		public const short CelestialMagnet = 2219;

		[global::Cpp2ILInjected.Token(Token = "0x40056E2")]
		public const short CelestialEmblem = 2220;

		[global::Cpp2ILInjected.Token(Token = "0x40056E3")]
		public const short CelestialCuffs = 2221;

		[global::Cpp2ILInjected.Token(Token = "0x40056E4")]
		public const short PeddlersHat = 2222;

		[global::Cpp2ILInjected.Token(Token = "0x40056E5")]
		public const short PulseBow = 2223;

		[global::Cpp2ILInjected.Token(Token = "0x40056E6")]
		public const short DynastyChandelier = 2224;

		[global::Cpp2ILInjected.Token(Token = "0x40056E7")]
		public const short DynastyLamp = 2225;

		[global::Cpp2ILInjected.Token(Token = "0x40056E8")]
		public const short DynastyLantern = 2226;

		[global::Cpp2ILInjected.Token(Token = "0x40056E9")]
		public const short DynastyCandelabra = 2227;

		[global::Cpp2ILInjected.Token(Token = "0x40056EA")]
		public const short DynastyChair = 2228;

		[global::Cpp2ILInjected.Token(Token = "0x40056EB")]
		public const short DynastyWorkBench = 2229;

		[global::Cpp2ILInjected.Token(Token = "0x40056EC")]
		public const short DynastyChest = 2230;

		[global::Cpp2ILInjected.Token(Token = "0x40056ED")]
		public const short DynastyBed = 2231;

		[global::Cpp2ILInjected.Token(Token = "0x40056EE")]
		public const short DynastyBathtub = 2232;

		[global::Cpp2ILInjected.Token(Token = "0x40056EF")]
		public const short DynastyBookcase = 2233;

		[global::Cpp2ILInjected.Token(Token = "0x40056F0")]
		public const short DynastyCup = 2234;

		[global::Cpp2ILInjected.Token(Token = "0x40056F1")]
		public const short DynastyBowl = 2235;

		[global::Cpp2ILInjected.Token(Token = "0x40056F2")]
		public const short DynastyCandle = 2236;

		[global::Cpp2ILInjected.Token(Token = "0x40056F3")]
		public const short DynastyClock = 2237;

		[global::Cpp2ILInjected.Token(Token = "0x40056F4")]
		public const short GoldenClock = 2238;

		[global::Cpp2ILInjected.Token(Token = "0x40056F5")]
		public const short GlassClock = 2239;

		[global::Cpp2ILInjected.Token(Token = "0x40056F6")]
		public const short HoneyClock = 2240;

		[global::Cpp2ILInjected.Token(Token = "0x40056F7")]
		public const short SteampunkClock = 2241;

		[global::Cpp2ILInjected.Token(Token = "0x40056F8")]
		public const short FancyDishes = 2242;

		[global::Cpp2ILInjected.Token(Token = "0x40056F9")]
		public const short GlassBowl = 2243;

		[global::Cpp2ILInjected.Token(Token = "0x40056FA")]
		public const short WineGlass = 2244;

		[global::Cpp2ILInjected.Token(Token = "0x40056FB")]
		public const short LivingWoodPiano = 2245;

		[global::Cpp2ILInjected.Token(Token = "0x40056FC")]
		public const short FleshPiano = 2246;

		[global::Cpp2ILInjected.Token(Token = "0x40056FD")]
		public const short FrozenPiano = 2247;

		[global::Cpp2ILInjected.Token(Token = "0x40056FE")]
		public const short FrozenTable = 2248;

		[global::Cpp2ILInjected.Token(Token = "0x40056FF")]
		public const short HoneyChest = 2249;

		[global::Cpp2ILInjected.Token(Token = "0x4005700")]
		public const short SteampunkChest = 2250;

		[global::Cpp2ILInjected.Token(Token = "0x4005701")]
		public const short HoneyWorkBench = 2251;

		[global::Cpp2ILInjected.Token(Token = "0x4005702")]
		public const short FrozenWorkBench = 2252;

		[global::Cpp2ILInjected.Token(Token = "0x4005703")]
		public const short SteampunkWorkBench = 2253;

		[global::Cpp2ILInjected.Token(Token = "0x4005704")]
		public const short GlassPiano = 2254;

		[global::Cpp2ILInjected.Token(Token = "0x4005705")]
		public const short HoneyPiano = 2255;

		[global::Cpp2ILInjected.Token(Token = "0x4005706")]
		public const short SteampunkPiano = 2256;

		[global::Cpp2ILInjected.Token(Token = "0x4005707")]
		public const short HoneyCup = 2257;

		[global::Cpp2ILInjected.Token(Token = "0x4005708")]
		public const short SteampunkCup = 2258;

		[global::Cpp2ILInjected.Token(Token = "0x4005709")]
		public const short DynastyTable = 2259;

		[global::Cpp2ILInjected.Token(Token = "0x400570A")]
		public const short DynastyWood = 2260;

		[global::Cpp2ILInjected.Token(Token = "0x400570B")]
		public const short RedDynastyShingles = 2261;

		[global::Cpp2ILInjected.Token(Token = "0x400570C")]
		public const short BlueDynastyShingles = 2262;

		[global::Cpp2ILInjected.Token(Token = "0x400570D")]
		public const short WhiteDynastyWall = 2263;

		[global::Cpp2ILInjected.Token(Token = "0x400570E")]
		public const short BlueDynastyWall = 2264;

		[global::Cpp2ILInjected.Token(Token = "0x400570F")]
		public const short DynastyDoor = 2265;

		[global::Cpp2ILInjected.Token(Token = "0x4005710")]
		public const short Sake = 2266;

		[global::Cpp2ILInjected.Token(Token = "0x4005711")]
		public const short PadThai = 2267;

		[global::Cpp2ILInjected.Token(Token = "0x4005712")]
		public const short Pho = 2268;

		[global::Cpp2ILInjected.Token(Token = "0x4005713")]
		public const short Revolver = 2269;

		[global::Cpp2ILInjected.Token(Token = "0x4005714")]
		public const short Gatligator = 2270;

		[global::Cpp2ILInjected.Token(Token = "0x4005715")]
		public const short ArcaneRuneWall = 2271;

		[global::Cpp2ILInjected.Token(Token = "0x4005716")]
		public const short WaterGun = 2272;

		[global::Cpp2ILInjected.Token(Token = "0x4005717")]
		public const short Katana = 2273;

		[global::Cpp2ILInjected.Token(Token = "0x4005718")]
		public const short UltrabrightTorch = 2274;

		[global::Cpp2ILInjected.Token(Token = "0x4005719")]
		public const short MagicHat = 2275;

		[global::Cpp2ILInjected.Token(Token = "0x400571A")]
		public const short DiamondRing = 2276;

		[global::Cpp2ILInjected.Token(Token = "0x400571B")]
		public const short Gi = 2277;

		[global::Cpp2ILInjected.Token(Token = "0x400571C")]
		public const short Kimono = 2278;

		[global::Cpp2ILInjected.Token(Token = "0x400571D")]
		public const short GypsyRobe = 2279;

		[global::Cpp2ILInjected.Token(Token = "0x400571E")]
		public const short BeetleWings = 2280;

		[global::Cpp2ILInjected.Token(Token = "0x400571F")]
		public const short TigerSkin = 2281;

		[global::Cpp2ILInjected.Token(Token = "0x4005720")]
		public const short LeopardSkin = 2282;

		[global::Cpp2ILInjected.Token(Token = "0x4005721")]
		public const short ZebraSkin = 2283;

		[global::Cpp2ILInjected.Token(Token = "0x4005722")]
		public const short CrimsonCloak = 2284;

		[global::Cpp2ILInjected.Token(Token = "0x4005723")]
		public const short MysteriousCape = 2285;

		[global::Cpp2ILInjected.Token(Token = "0x4005724")]
		public const short RedCape = 2286;

		[global::Cpp2ILInjected.Token(Token = "0x4005725")]
		public const short WinterCape = 2287;

		[global::Cpp2ILInjected.Token(Token = "0x4005726")]
		public const short FrozenChair = 2288;

		[global::Cpp2ILInjected.Token(Token = "0x4005727")]
		public const short WoodFishingPole = 2289;

		[global::Cpp2ILInjected.Token(Token = "0x4005728")]
		public const short Bass = 2290;

		[global::Cpp2ILInjected.Token(Token = "0x4005729")]
		public const short ReinforcedFishingPole = 2291;

		[global::Cpp2ILInjected.Token(Token = "0x400572A")]
		public const short FiberglassFishingPole = 2292;

		[global::Cpp2ILInjected.Token(Token = "0x400572B")]
		public const short FisherofSouls = 2293;

		[global::Cpp2ILInjected.Token(Token = "0x400572C")]
		public const short GoldenFishingRod = 2294;

		[global::Cpp2ILInjected.Token(Token = "0x400572D")]
		public const short MechanicsRod = 2295;

		[global::Cpp2ILInjected.Token(Token = "0x400572E")]
		public const short SittingDucksFishingRod = 2296;

		[global::Cpp2ILInjected.Token(Token = "0x400572F")]
		public const short Trout = 2297;

		[global::Cpp2ILInjected.Token(Token = "0x4005730")]
		public const short Salmon = 2298;

		[global::Cpp2ILInjected.Token(Token = "0x4005731")]
		public const short AtlanticCod = 2299;

		[global::Cpp2ILInjected.Token(Token = "0x4005732")]
		public const short Tuna = 2300;

		[global::Cpp2ILInjected.Token(Token = "0x4005733")]
		public const short RedSnapper = 2301;

		[global::Cpp2ILInjected.Token(Token = "0x4005734")]
		public const short NeonTetra = 2302;

		[global::Cpp2ILInjected.Token(Token = "0x4005735")]
		public const short ArmoredCavefish = 2303;

		[global::Cpp2ILInjected.Token(Token = "0x4005736")]
		public const short Damselfish = 2304;

		[global::Cpp2ILInjected.Token(Token = "0x4005737")]
		public const short CrimsonTigerfish = 2305;

		[global::Cpp2ILInjected.Token(Token = "0x4005738")]
		public const short FrostMinnow = 2306;

		[global::Cpp2ILInjected.Token(Token = "0x4005739")]
		public const short PrincessFish = 2307;

		[global::Cpp2ILInjected.Token(Token = "0x400573A")]
		public const short GoldenCarp = 2308;

		[global::Cpp2ILInjected.Token(Token = "0x400573B")]
		public const short SpecularFish = 2309;

		[global::Cpp2ILInjected.Token(Token = "0x400573C")]
		public const short Prismite = 2310;

		[global::Cpp2ILInjected.Token(Token = "0x400573D")]
		public const short VariegatedLardfish = 2311;

		[global::Cpp2ILInjected.Token(Token = "0x400573E")]
		public const short FlarefinKoi = 2312;

		[global::Cpp2ILInjected.Token(Token = "0x400573F")]
		public const short DoubleCod = 2313;

		[global::Cpp2ILInjected.Token(Token = "0x4005740")]
		public const short Honeyfin = 2314;

		[global::Cpp2ILInjected.Token(Token = "0x4005741")]
		public const short Obsidifish = 2315;

		[global::Cpp2ILInjected.Token(Token = "0x4005742")]
		public const short Shrimp = 2316;

		[global::Cpp2ILInjected.Token(Token = "0x4005743")]
		public const short ChaosFish = 2317;

		[global::Cpp2ILInjected.Token(Token = "0x4005744")]
		public const short Ebonkoi = 2318;

		[global::Cpp2ILInjected.Token(Token = "0x4005745")]
		public const short Hemopiranha = 2319;

		[global::Cpp2ILInjected.Token(Token = "0x4005746")]
		public const short Rockfish = 2320;

		[global::Cpp2ILInjected.Token(Token = "0x4005747")]
		public const short Stinkfish = 2321;

		[global::Cpp2ILInjected.Token(Token = "0x4005748")]
		public const short MiningPotion = 2322;

		[global::Cpp2ILInjected.Token(Token = "0x4005749")]
		public const short HeartreachPotion = 2323;

		[global::Cpp2ILInjected.Token(Token = "0x400574A")]
		public const short CalmingPotion = 2324;

		[global::Cpp2ILInjected.Token(Token = "0x400574B")]
		public const short BuilderPotion = 2325;

		[global::Cpp2ILInjected.Token(Token = "0x400574C")]
		public const short TitanPotion = 2326;

		[global::Cpp2ILInjected.Token(Token = "0x400574D")]
		public const short FlipperPotion = 2327;

		[global::Cpp2ILInjected.Token(Token = "0x400574E")]
		public const short SummoningPotion = 2328;

		[global::Cpp2ILInjected.Token(Token = "0x400574F")]
		public const short TrapsightPotion = 2329;

		[global::Cpp2ILInjected.Token(Token = "0x4005750")]
		public const short PurpleClubberfish = 2330;

		[global::Cpp2ILInjected.Token(Token = "0x4005751")]
		public const short ObsidianSwordfish = 2331;

		[global::Cpp2ILInjected.Token(Token = "0x4005752")]
		public const short Swordfish = 2332;

		[global::Cpp2ILInjected.Token(Token = "0x4005753")]
		public const short IronFence = 2333;

		[global::Cpp2ILInjected.Token(Token = "0x4005754")]
		public const short WoodenCrate = 2334;

		[global::Cpp2ILInjected.Token(Token = "0x4005755")]
		public const short IronCrate = 2335;

		[global::Cpp2ILInjected.Token(Token = "0x4005756")]
		public const short GoldenCrate = 2336;

		[global::Cpp2ILInjected.Token(Token = "0x4005757")]
		public const short OldShoe = 2337;

		[global::Cpp2ILInjected.Token(Token = "0x4005758")]
		public const short FishingSeaweed = 2338;

		[global::Cpp2ILInjected.Token(Token = "0x4005759")]
		public const short TinCan = 2339;

		[global::Cpp2ILInjected.Token(Token = "0x400575A")]
		public const short MinecartTrack = 2340;

		[global::Cpp2ILInjected.Token(Token = "0x400575B")]
		public const short ReaverShark = 2341;

		[global::Cpp2ILInjected.Token(Token = "0x400575C")]
		public const short SawtoothShark = 2342;

		[global::Cpp2ILInjected.Token(Token = "0x400575D")]
		public const short Minecart = 2343;

		[global::Cpp2ILInjected.Token(Token = "0x400575E")]
		public const short AmmoReservationPotion = 2344;

		[global::Cpp2ILInjected.Token(Token = "0x400575F")]
		public const short LifeforcePotion = 2345;

		[global::Cpp2ILInjected.Token(Token = "0x4005760")]
		public const short EndurancePotion = 2346;

		[global::Cpp2ILInjected.Token(Token = "0x4005761")]
		public const short RagePotion = 2347;

		[global::Cpp2ILInjected.Token(Token = "0x4005762")]
		public const short InfernoPotion = 2348;

		[global::Cpp2ILInjected.Token(Token = "0x4005763")]
		public const short WrathPotion = 2349;

		[global::Cpp2ILInjected.Token(Token = "0x4005764")]
		public const short RecallPotion = 2350;

		[global::Cpp2ILInjected.Token(Token = "0x4005765")]
		public const short TeleportationPotion = 2351;

		[global::Cpp2ILInjected.Token(Token = "0x4005766")]
		public const short LovePotion = 2352;

		[global::Cpp2ILInjected.Token(Token = "0x4005767")]
		public const short StinkPotion = 2353;

		[global::Cpp2ILInjected.Token(Token = "0x4005768")]
		public const short FishingPotion = 2354;

		[global::Cpp2ILInjected.Token(Token = "0x4005769")]
		public const short SonarPotion = 2355;

		[global::Cpp2ILInjected.Token(Token = "0x400576A")]
		public const short CratePotion = 2356;

		[global::Cpp2ILInjected.Token(Token = "0x400576B")]
		public const short ShiverthornSeeds = 2357;

		[global::Cpp2ILInjected.Token(Token = "0x400576C")]
		public const short Shiverthorn = 2358;

		[global::Cpp2ILInjected.Token(Token = "0x400576D")]
		public const short WarmthPotion = 2359;

		[global::Cpp2ILInjected.Token(Token = "0x400576E")]
		public const short FishHook = 2360;

		[global::Cpp2ILInjected.Token(Token = "0x400576F")]
		public const short BeeHeadgear = 2361;

		[global::Cpp2ILInjected.Token(Token = "0x4005770")]
		public const short BeeBreastplate = 2362;

		[global::Cpp2ILInjected.Token(Token = "0x4005771")]
		public const short BeeGreaves = 2363;

		[global::Cpp2ILInjected.Token(Token = "0x4005772")]
		public const short HornetStaff = 2364;

		[global::Cpp2ILInjected.Token(Token = "0x4005773")]
		public const short ImpStaff = 2365;

		[global::Cpp2ILInjected.Token(Token = "0x4005774")]
		public const short QueenSpiderStaff = 2366;

		[global::Cpp2ILInjected.Token(Token = "0x4005775")]
		public const short AnglerHat = 2367;

		[global::Cpp2ILInjected.Token(Token = "0x4005776")]
		public const short AnglerVest = 2368;

		[global::Cpp2ILInjected.Token(Token = "0x4005777")]
		public const short AnglerPants = 2369;

		[global::Cpp2ILInjected.Token(Token = "0x4005778")]
		public const short SpiderMask = 2370;

		[global::Cpp2ILInjected.Token(Token = "0x4005779")]
		public const short SpiderBreastplate = 2371;

		[global::Cpp2ILInjected.Token(Token = "0x400577A")]
		public const short SpiderGreaves = 2372;

		[global::Cpp2ILInjected.Token(Token = "0x400577B")]
		public const short HighTestFishingLine = 2373;

		[global::Cpp2ILInjected.Token(Token = "0x400577C")]
		public const short AnglerEarring = 2374;

		[global::Cpp2ILInjected.Token(Token = "0x400577D")]
		public const short TackleBox = 2375;

		[global::Cpp2ILInjected.Token(Token = "0x400577E")]
		public const short BlueDungeonPiano = 2376;

		[global::Cpp2ILInjected.Token(Token = "0x400577F")]
		public const short GreenDungeonPiano = 2377;

		[global::Cpp2ILInjected.Token(Token = "0x4005780")]
		public const short PinkDungeonPiano = 2378;

		[global::Cpp2ILInjected.Token(Token = "0x4005781")]
		public const short GoldenPiano = 2379;

		[global::Cpp2ILInjected.Token(Token = "0x4005782")]
		public const short ObsidianPiano = 2380;

		[global::Cpp2ILInjected.Token(Token = "0x4005783")]
		public const short BonePiano = 2381;

		[global::Cpp2ILInjected.Token(Token = "0x4005784")]
		public const short CactusPiano = 2382;

		[global::Cpp2ILInjected.Token(Token = "0x4005785")]
		public const short SpookyPiano = 2383;

		[global::Cpp2ILInjected.Token(Token = "0x4005786")]
		public const short SkywarePiano = 2384;

		[global::Cpp2ILInjected.Token(Token = "0x4005787")]
		public const short LihzahrdPiano = 2385;

		[global::Cpp2ILInjected.Token(Token = "0x4005788")]
		public const short BlueDungeonDresser = 2386;

		[global::Cpp2ILInjected.Token(Token = "0x4005789")]
		public const short GreenDungeonDresser = 2387;

		[global::Cpp2ILInjected.Token(Token = "0x400578A")]
		public const short PinkDungeonDresser = 2388;

		[global::Cpp2ILInjected.Token(Token = "0x400578B")]
		public const short GoldenDresser = 2389;

		[global::Cpp2ILInjected.Token(Token = "0x400578C")]
		public const short ObsidianDresser = 2390;

		[global::Cpp2ILInjected.Token(Token = "0x400578D")]
		public const short BoneDresser = 2391;

		[global::Cpp2ILInjected.Token(Token = "0x400578E")]
		public const short CactusDresser = 2392;

		[global::Cpp2ILInjected.Token(Token = "0x400578F")]
		public const short SpookyDresser = 2393;

		[global::Cpp2ILInjected.Token(Token = "0x4005790")]
		public const short SkywareDresser = 2394;

		[global::Cpp2ILInjected.Token(Token = "0x4005791")]
		public const short HoneyDresser = 2395;

		[global::Cpp2ILInjected.Token(Token = "0x4005792")]
		public const short LihzahrdDresser = 2396;

		[global::Cpp2ILInjected.Token(Token = "0x4005793")]
		public const short Sofa = 2397;

		[global::Cpp2ILInjected.Token(Token = "0x4005794")]
		public const short EbonwoodSofa = 2398;

		[global::Cpp2ILInjected.Token(Token = "0x4005795")]
		public const short RichMahoganySofa = 2399;

		[global::Cpp2ILInjected.Token(Token = "0x4005796")]
		public const short PearlwoodSofa = 2400;

		[global::Cpp2ILInjected.Token(Token = "0x4005797")]
		public const short ShadewoodSofa = 2401;

		[global::Cpp2ILInjected.Token(Token = "0x4005798")]
		public const short BlueDungeonSofa = 2402;

		[global::Cpp2ILInjected.Token(Token = "0x4005799")]
		public const short GreenDungeonSofa = 2403;

		[global::Cpp2ILInjected.Token(Token = "0x400579A")]
		public const short PinkDungeonSofa = 2404;

		[global::Cpp2ILInjected.Token(Token = "0x400579B")]
		public const short GoldenSofa = 2405;

		[global::Cpp2ILInjected.Token(Token = "0x400579C")]
		public const short ObsidianSofa = 2406;

		[global::Cpp2ILInjected.Token(Token = "0x400579D")]
		public const short BoneSofa = 2407;

		[global::Cpp2ILInjected.Token(Token = "0x400579E")]
		public const short CactusSofa = 2408;

		[global::Cpp2ILInjected.Token(Token = "0x400579F")]
		public const short SpookySofa = 2409;

		[global::Cpp2ILInjected.Token(Token = "0x40057A0")]
		public const short SkywareSofa = 2410;

		[global::Cpp2ILInjected.Token(Token = "0x40057A1")]
		public const short HoneySofa = 2411;

		[global::Cpp2ILInjected.Token(Token = "0x40057A2")]
		public const short SteampunkSofa = 2412;

		[global::Cpp2ILInjected.Token(Token = "0x40057A3")]
		public const short MushroomSofa = 2413;

		[global::Cpp2ILInjected.Token(Token = "0x40057A4")]
		public const short GlassSofa = 2414;

		[global::Cpp2ILInjected.Token(Token = "0x40057A5")]
		public const short PumpkinSofa = 2415;

		[global::Cpp2ILInjected.Token(Token = "0x40057A6")]
		public const short LihzahrdSofa = 2416;

		[global::Cpp2ILInjected.Token(Token = "0x40057A7")]
		public const short SeashellHairpin = 2417;

		[global::Cpp2ILInjected.Token(Token = "0x40057A8")]
		public const short MermaidAdornment = 2418;

		[global::Cpp2ILInjected.Token(Token = "0x40057A9")]
		public const short MermaidTail = 2419;

		[global::Cpp2ILInjected.Token(Token = "0x40057AA")]
		public const short ZephyrFish = 2420;

		[global::Cpp2ILInjected.Token(Token = "0x40057AB")]
		public const short Fleshcatcher = 2421;

		[global::Cpp2ILInjected.Token(Token = "0x40057AC")]
		public const short HotlineFishingHook = 2422;

		[global::Cpp2ILInjected.Token(Token = "0x40057AD")]
		public const short FrogLeg = 2423;

		[global::Cpp2ILInjected.Token(Token = "0x40057AE")]
		public const short Anchor = 2424;

		[global::Cpp2ILInjected.Token(Token = "0x40057AF")]
		public const short CookedFish = 2425;

		[global::Cpp2ILInjected.Token(Token = "0x40057B0")]
		public const short CookedShrimp = 2426;

		[global::Cpp2ILInjected.Token(Token = "0x40057B1")]
		public const short Sashimi = 2427;

		[global::Cpp2ILInjected.Token(Token = "0x40057B2")]
		public const short FuzzyCarrot = 2428;

		[global::Cpp2ILInjected.Token(Token = "0x40057B3")]
		public const short ScalyTruffle = 2429;

		[global::Cpp2ILInjected.Token(Token = "0x40057B4")]
		public const short SlimySaddle = 2430;

		[global::Cpp2ILInjected.Token(Token = "0x40057B5")]
		public const short BeeWax = 2431;

		[global::Cpp2ILInjected.Token(Token = "0x40057B6")]
		public const short CopperPlatingWall = 2432;

		[global::Cpp2ILInjected.Token(Token = "0x40057B7")]
		public const short StoneSlabWall = 2433;

		[global::Cpp2ILInjected.Token(Token = "0x40057B8")]
		public const short Sail = 2434;

		[global::Cpp2ILInjected.Token(Token = "0x40057B9")]
		public const short CoralstoneBlock = 2435;

		[global::Cpp2ILInjected.Token(Token = "0x40057BA")]
		public const short BlueJellyfish = 2436;

		[global::Cpp2ILInjected.Token(Token = "0x40057BB")]
		public const short GreenJellyfish = 2437;

		[global::Cpp2ILInjected.Token(Token = "0x40057BC")]
		public const short PinkJellyfish = 2438;

		[global::Cpp2ILInjected.Token(Token = "0x40057BD")]
		public const short BlueJellyfishJar = 2439;

		[global::Cpp2ILInjected.Token(Token = "0x40057BE")]
		public const short GreenJellyfishJar = 2440;

		[global::Cpp2ILInjected.Token(Token = "0x40057BF")]
		public const short PinkJellyfishJar = 2441;

		[global::Cpp2ILInjected.Token(Token = "0x40057C0")]
		public const short LifePreserver = 2442;

		[global::Cpp2ILInjected.Token(Token = "0x40057C1")]
		public const short ShipsWheel = 2443;

		[global::Cpp2ILInjected.Token(Token = "0x40057C2")]
		public const short CompassRose = 2444;

		[global::Cpp2ILInjected.Token(Token = "0x40057C3")]
		public const short WallAnchor = 2445;

		[global::Cpp2ILInjected.Token(Token = "0x40057C4")]
		public const short GoldfishTrophy = 2446;

		[global::Cpp2ILInjected.Token(Token = "0x40057C5")]
		public const short BunnyfishTrophy = 2447;

		[global::Cpp2ILInjected.Token(Token = "0x40057C6")]
		public const short SwordfishTrophy = 2448;

		[global::Cpp2ILInjected.Token(Token = "0x40057C7")]
		public const short SharkteethTrophy = 2449;

		[global::Cpp2ILInjected.Token(Token = "0x40057C8")]
		public const short Batfish = 2450;

		[global::Cpp2ILInjected.Token(Token = "0x40057C9")]
		public const short BumblebeeTuna = 2451;

		[global::Cpp2ILInjected.Token(Token = "0x40057CA")]
		public const short Catfish = 2452;

		[global::Cpp2ILInjected.Token(Token = "0x40057CB")]
		public const short Cloudfish = 2453;

		[global::Cpp2ILInjected.Token(Token = "0x40057CC")]
		public const short Cursedfish = 2454;

		[global::Cpp2ILInjected.Token(Token = "0x40057CD")]
		public const short Dirtfish = 2455;

		[global::Cpp2ILInjected.Token(Token = "0x40057CE")]
		public const short DynamiteFish = 2456;

		[global::Cpp2ILInjected.Token(Token = "0x40057CF")]
		public const short EaterofPlankton = 2457;

		[global::Cpp2ILInjected.Token(Token = "0x40057D0")]
		public const short FallenStarfish = 2458;

		[global::Cpp2ILInjected.Token(Token = "0x40057D1")]
		public const short TheFishofCthulu = 2459;

		[global::Cpp2ILInjected.Token(Token = "0x40057D2")]
		public const short Fishotron = 2460;

		[global::Cpp2ILInjected.Token(Token = "0x40057D3")]
		public const short Harpyfish = 2461;

		[global::Cpp2ILInjected.Token(Token = "0x40057D4")]
		public const short Hungerfish = 2462;

		[global::Cpp2ILInjected.Token(Token = "0x40057D5")]
		public const short Ichorfish = 2463;

		[global::Cpp2ILInjected.Token(Token = "0x40057D6")]
		public const short Jewelfish = 2464;

		[global::Cpp2ILInjected.Token(Token = "0x40057D7")]
		public const short MirageFish = 2465;

		[global::Cpp2ILInjected.Token(Token = "0x40057D8")]
		public const short MutantFlinxfin = 2466;

		[global::Cpp2ILInjected.Token(Token = "0x40057D9")]
		public const short Pengfish = 2467;

		[global::Cpp2ILInjected.Token(Token = "0x40057DA")]
		public const short Pixiefish = 2468;

		[global::Cpp2ILInjected.Token(Token = "0x40057DB")]
		public const short Spiderfish = 2469;

		[global::Cpp2ILInjected.Token(Token = "0x40057DC")]
		public const short TundraTrout = 2470;

		[global::Cpp2ILInjected.Token(Token = "0x40057DD")]
		public const short UnicornFish = 2471;

		[global::Cpp2ILInjected.Token(Token = "0x40057DE")]
		public const short GuideVoodooFish = 2472;

		[global::Cpp2ILInjected.Token(Token = "0x40057DF")]
		public const short Wyverntail = 2473;

		[global::Cpp2ILInjected.Token(Token = "0x40057E0")]
		public const short ZombieFish = 2474;

		[global::Cpp2ILInjected.Token(Token = "0x40057E1")]
		public const short AmanitaFungifin = 2475;

		[global::Cpp2ILInjected.Token(Token = "0x40057E2")]
		public const short Angelfish = 2476;

		[global::Cpp2ILInjected.Token(Token = "0x40057E3")]
		public const short BloodyManowar = 2477;

		[global::Cpp2ILInjected.Token(Token = "0x40057E4")]
		public const short Bonefish = 2478;

		[global::Cpp2ILInjected.Token(Token = "0x40057E5")]
		public const short Bunnyfish = 2479;

		[global::Cpp2ILInjected.Token(Token = "0x40057E6")]
		public const short CapnTunabeard = 2480;

		[global::Cpp2ILInjected.Token(Token = "0x40057E7")]
		public const short Clownfish = 2481;

		[global::Cpp2ILInjected.Token(Token = "0x40057E8")]
		public const short DemonicHellfish = 2482;

		[global::Cpp2ILInjected.Token(Token = "0x40057E9")]
		public const short Derpfish = 2483;

		[global::Cpp2ILInjected.Token(Token = "0x40057EA")]
		public const short Fishron = 2484;

		[global::Cpp2ILInjected.Token(Token = "0x40057EB")]
		public const short InfectedScabbardfish = 2485;

		[global::Cpp2ILInjected.Token(Token = "0x40057EC")]
		public const short Mudfish = 2486;

		[global::Cpp2ILInjected.Token(Token = "0x40057ED")]
		public const short Slimefish = 2487;

		[global::Cpp2ILInjected.Token(Token = "0x40057EE")]
		public const short TropicalBarracuda = 2488;

		[global::Cpp2ILInjected.Token(Token = "0x40057EF")]
		public const short KingSlimeTrophy = 2489;

		[global::Cpp2ILInjected.Token(Token = "0x40057F0")]
		public const short ShipInABottle = 2490;

		[global::Cpp2ILInjected.Token(Token = "0x40057F1")]
		public const short HardySaddle = 2491;

		[global::Cpp2ILInjected.Token(Token = "0x40057F2")]
		public const short PressureTrack = 2492;

		[global::Cpp2ILInjected.Token(Token = "0x40057F3")]
		public const short KingSlimeMask = 2493;

		[global::Cpp2ILInjected.Token(Token = "0x40057F4")]
		public const short FinWings = 2494;

		[global::Cpp2ILInjected.Token(Token = "0x40057F5")]
		public const short TreasureMap = 2495;

		[global::Cpp2ILInjected.Token(Token = "0x40057F6")]
		public const short SeaweedPlanter = 2496;

		[global::Cpp2ILInjected.Token(Token = "0x40057F7")]
		public const short PillaginMePixels = 2497;

		[global::Cpp2ILInjected.Token(Token = "0x40057F8")]
		public const short FishCostumeMask = 2498;

		[global::Cpp2ILInjected.Token(Token = "0x40057F9")]
		public const short FishCostumeShirt = 2499;

		[global::Cpp2ILInjected.Token(Token = "0x40057FA")]
		public const short FishCostumeFinskirt = 2500;

		[global::Cpp2ILInjected.Token(Token = "0x40057FB")]
		public const short GingerBeard = 2501;

		[global::Cpp2ILInjected.Token(Token = "0x40057FC")]
		public const short HoneyedGoggles = 2502;

		[global::Cpp2ILInjected.Token(Token = "0x40057FD")]
		public const short BorealWood = 2503;

		[global::Cpp2ILInjected.Token(Token = "0x40057FE")]
		public const short PalmWood = 2504;

		[global::Cpp2ILInjected.Token(Token = "0x40057FF")]
		public const short BorealWoodWall = 2505;

		[global::Cpp2ILInjected.Token(Token = "0x4005800")]
		public const short PalmWoodWall = 2506;

		[global::Cpp2ILInjected.Token(Token = "0x4005801")]
		public const short BorealWoodFence = 2507;

		[global::Cpp2ILInjected.Token(Token = "0x4005802")]
		public const short PalmWoodFence = 2508;

		[global::Cpp2ILInjected.Token(Token = "0x4005803")]
		public const short BorealWoodHelmet = 2509;

		[global::Cpp2ILInjected.Token(Token = "0x4005804")]
		public const short BorealWoodBreastplate = 2510;

		[global::Cpp2ILInjected.Token(Token = "0x4005805")]
		public const short BorealWoodGreaves = 2511;

		[global::Cpp2ILInjected.Token(Token = "0x4005806")]
		public const short PalmWoodHelmet = 2512;

		[global::Cpp2ILInjected.Token(Token = "0x4005807")]
		public const short PalmWoodBreastplate = 2513;

		[global::Cpp2ILInjected.Token(Token = "0x4005808")]
		public const short PalmWoodGreaves = 2514;

		[global::Cpp2ILInjected.Token(Token = "0x4005809")]
		public const short PalmWoodBow = 2515;

		[global::Cpp2ILInjected.Token(Token = "0x400580A")]
		public const short PalmWoodHammer = 2516;

		[global::Cpp2ILInjected.Token(Token = "0x400580B")]
		public const short PalmWoodSword = 2517;

		[global::Cpp2ILInjected.Token(Token = "0x400580C")]
		public const short PalmWoodPlatform = 2518;

		[global::Cpp2ILInjected.Token(Token = "0x400580D")]
		public const short PalmWoodBathtub = 2519;

		[global::Cpp2ILInjected.Token(Token = "0x400580E")]
		public const short PalmWoodBed = 2520;

		[global::Cpp2ILInjected.Token(Token = "0x400580F")]
		public const short PalmWoodBench = 2521;

		[global::Cpp2ILInjected.Token(Token = "0x4005810")]
		public const short PalmWoodCandelabra = 2522;

		[global::Cpp2ILInjected.Token(Token = "0x4005811")]
		public const short PalmWoodCandle = 2523;

		[global::Cpp2ILInjected.Token(Token = "0x4005812")]
		public const short PalmWoodChair = 2524;

		[global::Cpp2ILInjected.Token(Token = "0x4005813")]
		public const short PalmWoodChandelier = 2525;

		[global::Cpp2ILInjected.Token(Token = "0x4005814")]
		public const short PalmWoodChest = 2526;

		[global::Cpp2ILInjected.Token(Token = "0x4005815")]
		public const short PalmWoodSofa = 2527;

		[global::Cpp2ILInjected.Token(Token = "0x4005816")]
		public const short PalmWoodDoor = 2528;

		[global::Cpp2ILInjected.Token(Token = "0x4005817")]
		public const short PalmWoodDresser = 2529;

		[global::Cpp2ILInjected.Token(Token = "0x4005818")]
		public const short PalmWoodLantern = 2530;

		[global::Cpp2ILInjected.Token(Token = "0x4005819")]
		public const short PalmWoodPiano = 2531;

		[global::Cpp2ILInjected.Token(Token = "0x400581A")]
		public const short PalmWoodTable = 2532;

		[global::Cpp2ILInjected.Token(Token = "0x400581B")]
		public const short PalmWoodLamp = 2533;

		[global::Cpp2ILInjected.Token(Token = "0x400581C")]
		public const short PalmWoodWorkBench = 2534;

		[global::Cpp2ILInjected.Token(Token = "0x400581D")]
		public const short OpticStaff = 2535;

		[global::Cpp2ILInjected.Token(Token = "0x400581E")]
		public const short PalmWoodBookcase = 2536;

		[global::Cpp2ILInjected.Token(Token = "0x400581F")]
		public const short MushroomBathtub = 2537;

		[global::Cpp2ILInjected.Token(Token = "0x4005820")]
		public const short MushroomBed = 2538;

		[global::Cpp2ILInjected.Token(Token = "0x4005821")]
		public const short MushroomBench = 2539;

		[global::Cpp2ILInjected.Token(Token = "0x4005822")]
		public const short MushroomBookcase = 2540;

		[global::Cpp2ILInjected.Token(Token = "0x4005823")]
		public const short MushroomCandelabra = 2541;

		[global::Cpp2ILInjected.Token(Token = "0x4005824")]
		public const short MushroomCandle = 2542;

		[global::Cpp2ILInjected.Token(Token = "0x4005825")]
		public const short MushroomChandelier = 2543;

		[global::Cpp2ILInjected.Token(Token = "0x4005826")]
		public const short MushroomChest = 2544;

		[global::Cpp2ILInjected.Token(Token = "0x4005827")]
		public const short MushroomDresser = 2545;

		[global::Cpp2ILInjected.Token(Token = "0x4005828")]
		public const short MushroomLantern = 2546;

		[global::Cpp2ILInjected.Token(Token = "0x4005829")]
		public const short MushroomLamp = 2547;

		[global::Cpp2ILInjected.Token(Token = "0x400582A")]
		public const short MushroomPiano = 2548;

		[global::Cpp2ILInjected.Token(Token = "0x400582B")]
		public const short MushroomPlatform = 2549;

		[global::Cpp2ILInjected.Token(Token = "0x400582C")]
		public const short MushroomTable = 2550;

		[global::Cpp2ILInjected.Token(Token = "0x400582D")]
		public const short SpiderStaff = 2551;

		[global::Cpp2ILInjected.Token(Token = "0x400582E")]
		public const short BorealWoodBathtub = 2552;

		[global::Cpp2ILInjected.Token(Token = "0x400582F")]
		public const short BorealWoodBed = 2553;

		[global::Cpp2ILInjected.Token(Token = "0x4005830")]
		public const short BorealWoodBookcase = 2554;

		[global::Cpp2ILInjected.Token(Token = "0x4005831")]
		public const short BorealWoodCandelabra = 2555;

		[global::Cpp2ILInjected.Token(Token = "0x4005832")]
		public const short BorealWoodCandle = 2556;

		[global::Cpp2ILInjected.Token(Token = "0x4005833")]
		public const short BorealWoodChair = 2557;

		[global::Cpp2ILInjected.Token(Token = "0x4005834")]
		public const short BorealWoodChandelier = 2558;

		[global::Cpp2ILInjected.Token(Token = "0x4005835")]
		public const short BorealWoodChest = 2559;

		[global::Cpp2ILInjected.Token(Token = "0x4005836")]
		public const short BorealWoodClock = 2560;

		[global::Cpp2ILInjected.Token(Token = "0x4005837")]
		public const short BorealWoodDoor = 2561;

		[global::Cpp2ILInjected.Token(Token = "0x4005838")]
		public const short BorealWoodDresser = 2562;

		[global::Cpp2ILInjected.Token(Token = "0x4005839")]
		public const short BorealWoodLamp = 2563;

		[global::Cpp2ILInjected.Token(Token = "0x400583A")]
		public const short BorealWoodLantern = 2564;

		[global::Cpp2ILInjected.Token(Token = "0x400583B")]
		public const short BorealWoodPiano = 2565;

		[global::Cpp2ILInjected.Token(Token = "0x400583C")]
		public const short BorealWoodPlatform = 2566;

		[global::Cpp2ILInjected.Token(Token = "0x400583D")]
		public const short SlimeBathtub = 2567;

		[global::Cpp2ILInjected.Token(Token = "0x400583E")]
		public const short SlimeBed = 2568;

		[global::Cpp2ILInjected.Token(Token = "0x400583F")]
		public const short SlimeBookcase = 2569;

		[global::Cpp2ILInjected.Token(Token = "0x4005840")]
		public const short SlimeCandelabra = 2570;

		[global::Cpp2ILInjected.Token(Token = "0x4005841")]
		public const short SlimeCandle = 2571;

		[global::Cpp2ILInjected.Token(Token = "0x4005842")]
		public const short SlimeChair = 2572;

		[global::Cpp2ILInjected.Token(Token = "0x4005843")]
		public const short SlimeChandelier = 2573;

		[global::Cpp2ILInjected.Token(Token = "0x4005844")]
		public const short SlimeChest = 2574;

		[global::Cpp2ILInjected.Token(Token = "0x4005845")]
		public const short SlimeClock = 2575;

		[global::Cpp2ILInjected.Token(Token = "0x4005846")]
		public const short SlimeDoor = 2576;

		[global::Cpp2ILInjected.Token(Token = "0x4005847")]
		public const short SlimeDresser = 2577;

		[global::Cpp2ILInjected.Token(Token = "0x4005848")]
		public const short SlimeLamp = 2578;

		[global::Cpp2ILInjected.Token(Token = "0x4005849")]
		public const short SlimeLantern = 2579;

		[global::Cpp2ILInjected.Token(Token = "0x400584A")]
		public const short SlimePiano = 2580;

		[global::Cpp2ILInjected.Token(Token = "0x400584B")]
		public const short SlimePlatform = 2581;

		[global::Cpp2ILInjected.Token(Token = "0x400584C")]
		public const short SlimeSofa = 2582;

		[global::Cpp2ILInjected.Token(Token = "0x400584D")]
		public const short SlimeTable = 2583;

		[global::Cpp2ILInjected.Token(Token = "0x400584E")]
		public const short PirateStaff = 2584;

		[global::Cpp2ILInjected.Token(Token = "0x400584F")]
		public const short SlimeHook = 2585;

		[global::Cpp2ILInjected.Token(Token = "0x4005850")]
		public const short StickyGrenade = 2586;

		[global::Cpp2ILInjected.Token(Token = "0x4005851")]
		public const short TartarSauce = 2587;

		[global::Cpp2ILInjected.Token(Token = "0x4005852")]
		public const short DukeFishronMask = 2588;

		[global::Cpp2ILInjected.Token(Token = "0x4005853")]
		public const short DukeFishronTrophy = 2589;

		[global::Cpp2ILInjected.Token(Token = "0x4005854")]
		public const short MolotovCocktail = 2590;

		[global::Cpp2ILInjected.Token(Token = "0x4005855")]
		public const short BoneClock = 2591;

		[global::Cpp2ILInjected.Token(Token = "0x4005856")]
		public const short CactusClock = 2592;

		[global::Cpp2ILInjected.Token(Token = "0x4005857")]
		public const short EbonwoodClock = 2593;

		[global::Cpp2ILInjected.Token(Token = "0x4005858")]
		public const short FrozenClock = 2594;

		[global::Cpp2ILInjected.Token(Token = "0x4005859")]
		public const short LihzahrdClock = 2595;

		[global::Cpp2ILInjected.Token(Token = "0x400585A")]
		public const short LivingWoodClock = 2596;

		[global::Cpp2ILInjected.Token(Token = "0x400585B")]
		public const short RichMahoganyClock = 2597;

		[global::Cpp2ILInjected.Token(Token = "0x400585C")]
		public const short FleshClock = 2598;

		[global::Cpp2ILInjected.Token(Token = "0x400585D")]
		public const short MushroomClock = 2599;

		[global::Cpp2ILInjected.Token(Token = "0x400585E")]
		public const short ObsidianClock = 2600;

		[global::Cpp2ILInjected.Token(Token = "0x400585F")]
		public const short PalmWoodClock = 2601;

		[global::Cpp2ILInjected.Token(Token = "0x4005860")]
		public const short PearlwoodClock = 2602;

		[global::Cpp2ILInjected.Token(Token = "0x4005861")]
		public const short PumpkinClock = 2603;

		[global::Cpp2ILInjected.Token(Token = "0x4005862")]
		public const short ShadewoodClock = 2604;

		[global::Cpp2ILInjected.Token(Token = "0x4005863")]
		public const short SpookyClock = 2605;

		[global::Cpp2ILInjected.Token(Token = "0x4005864")]
		public const short SkywareClock = 2606;

		[global::Cpp2ILInjected.Token(Token = "0x4005865")]
		public const short SpiderFang = 2607;

		[global::Cpp2ILInjected.Token(Token = "0x4005866")]
		public const short FalconBlade = 2608;

		[global::Cpp2ILInjected.Token(Token = "0x4005867")]
		public const short FishronWings = 2609;

		[global::Cpp2ILInjected.Token(Token = "0x4005868")]
		public const short SlimeGun = 2610;

		[global::Cpp2ILInjected.Token(Token = "0x4005869")]
		public const short Flairon = 2611;

		[global::Cpp2ILInjected.Token(Token = "0x400586A")]
		public const short GreenDungeonChest = 2612;

		[global::Cpp2ILInjected.Token(Token = "0x400586B")]
		public const short PinkDungeonChest = 2613;

		[global::Cpp2ILInjected.Token(Token = "0x400586C")]
		public const short BlueDungeonChest = 2614;

		[global::Cpp2ILInjected.Token(Token = "0x400586D")]
		public const short BoneChest = 2615;

		[global::Cpp2ILInjected.Token(Token = "0x400586E")]
		public const short CactusChest = 2616;

		[global::Cpp2ILInjected.Token(Token = "0x400586F")]
		public const short FleshChest = 2617;

		[global::Cpp2ILInjected.Token(Token = "0x4005870")]
		public const short ObsidianChest = 2618;

		[global::Cpp2ILInjected.Token(Token = "0x4005871")]
		public const short PumpkinChest = 2619;

		[global::Cpp2ILInjected.Token(Token = "0x4005872")]
		public const short SpookyChest = 2620;

		[global::Cpp2ILInjected.Token(Token = "0x4005873")]
		public const short TempestStaff = 2621;

		[global::Cpp2ILInjected.Token(Token = "0x4005874")]
		public const short RazorbladeTyphoon = 2622;

		[global::Cpp2ILInjected.Token(Token = "0x4005875")]
		public const short BubbleGun = 2623;

		[global::Cpp2ILInjected.Token(Token = "0x4005876")]
		public const short Tsunami = 2624;

		[global::Cpp2ILInjected.Token(Token = "0x4005877")]
		public const short Seashell = 2625;

		[global::Cpp2ILInjected.Token(Token = "0x4005878")]
		public const short Starfish = 2626;

		[global::Cpp2ILInjected.Token(Token = "0x4005879")]
		public const short SteampunkPlatform = 2627;

		[global::Cpp2ILInjected.Token(Token = "0x400587A")]
		public const short SkywarePlatform = 2628;

		[global::Cpp2ILInjected.Token(Token = "0x400587B")]
		public const short LivingWoodPlatform = 2629;

		[global::Cpp2ILInjected.Token(Token = "0x400587C")]
		public const short HoneyPlatform = 2630;

		[global::Cpp2ILInjected.Token(Token = "0x400587D")]
		public const short SkywareWorkbench = 2631;

		[global::Cpp2ILInjected.Token(Token = "0x400587E")]
		public const short GlassWorkBench = 2632;

		[global::Cpp2ILInjected.Token(Token = "0x400587F")]
		public const short LivingWoodWorkBench = 2633;

		[global::Cpp2ILInjected.Token(Token = "0x4005880")]
		public const short FleshSofa = 2634;

		[global::Cpp2ILInjected.Token(Token = "0x4005881")]
		public const short FrozenSofa = 2635;

		[global::Cpp2ILInjected.Token(Token = "0x4005882")]
		public const short LivingWoodSofa = 2636;

		[global::Cpp2ILInjected.Token(Token = "0x4005883")]
		public const short PumpkinDresser = 2637;

		[global::Cpp2ILInjected.Token(Token = "0x4005884")]
		public const short SteampunkDresser = 2638;

		[global::Cpp2ILInjected.Token(Token = "0x4005885")]
		public const short GlassDresser = 2639;

		[global::Cpp2ILInjected.Token(Token = "0x4005886")]
		public const short FleshDresser = 2640;

		[global::Cpp2ILInjected.Token(Token = "0x4005887")]
		public const short PumpkinLantern = 2641;

		[global::Cpp2ILInjected.Token(Token = "0x4005888")]
		public const short ObsidianLantern = 2642;

		[global::Cpp2ILInjected.Token(Token = "0x4005889")]
		public const short PumpkinLamp = 2643;

		[global::Cpp2ILInjected.Token(Token = "0x400588A")]
		public const short ObsidianLamp = 2644;

		[global::Cpp2ILInjected.Token(Token = "0x400588B")]
		public const short BlueDungeonLamp = 2645;

		[global::Cpp2ILInjected.Token(Token = "0x400588C")]
		public const short GreenDungeonLamp = 2646;

		[global::Cpp2ILInjected.Token(Token = "0x400588D")]
		public const short PinkDungeonLamp = 2647;

		[global::Cpp2ILInjected.Token(Token = "0x400588E")]
		public const short HoneyCandle = 2648;

		[global::Cpp2ILInjected.Token(Token = "0x400588F")]
		public const short SteampunkCandle = 2649;

		[global::Cpp2ILInjected.Token(Token = "0x4005890")]
		public const short SpookyCandle = 2650;

		[global::Cpp2ILInjected.Token(Token = "0x4005891")]
		public const short ObsidianCandle = 2651;

		[global::Cpp2ILInjected.Token(Token = "0x4005892")]
		public const short BlueDungeonChandelier = 2652;

		[global::Cpp2ILInjected.Token(Token = "0x4005893")]
		public const short GreenDungeonChandelier = 2653;

		[global::Cpp2ILInjected.Token(Token = "0x4005894")]
		public const short PinkDungeonChandelier = 2654;

		[global::Cpp2ILInjected.Token(Token = "0x4005895")]
		public const short SteampunkChandelier = 2655;

		[global::Cpp2ILInjected.Token(Token = "0x4005896")]
		public const short PumpkinChandelier = 2656;

		[global::Cpp2ILInjected.Token(Token = "0x4005897")]
		public const short ObsidianChandelier = 2657;

		[global::Cpp2ILInjected.Token(Token = "0x4005898")]
		public const short BlueDungeonBathtub = 2658;

		[global::Cpp2ILInjected.Token(Token = "0x4005899")]
		public const short GreenDungeonBathtub = 2659;

		[global::Cpp2ILInjected.Token(Token = "0x400589A")]
		public const short PinkDungeonBathtub = 2660;

		[global::Cpp2ILInjected.Token(Token = "0x400589B")]
		public const short PumpkinBathtub = 2661;

		[global::Cpp2ILInjected.Token(Token = "0x400589C")]
		public const short ObsidianBathtub = 2662;

		[global::Cpp2ILInjected.Token(Token = "0x400589D")]
		public const short GoldenBathtub = 2663;

		[global::Cpp2ILInjected.Token(Token = "0x400589E")]
		public const short BlueDungeonCandelabra = 2664;

		[global::Cpp2ILInjected.Token(Token = "0x400589F")]
		public const short GreenDungeonCandelabra = 2665;

		[global::Cpp2ILInjected.Token(Token = "0x40058A0")]
		public const short PinkDungeonCandelabra = 2666;

		[global::Cpp2ILInjected.Token(Token = "0x40058A1")]
		public const short ObsidianCandelabra = 2667;

		[global::Cpp2ILInjected.Token(Token = "0x40058A2")]
		public const short PumpkinCandelabra = 2668;

		[global::Cpp2ILInjected.Token(Token = "0x40058A3")]
		public const short PumpkinBed = 2669;

		[global::Cpp2ILInjected.Token(Token = "0x40058A4")]
		public const short PumpkinBookcase = 2670;

		[global::Cpp2ILInjected.Token(Token = "0x40058A5")]
		public const short PumpkinPiano = 2671;

		[global::Cpp2ILInjected.Token(Token = "0x40058A6")]
		public const short SharkStatue = 2672;

		[global::Cpp2ILInjected.Token(Token = "0x40058A7")]
		public const short TruffleWorm = 2673;

		[global::Cpp2ILInjected.Token(Token = "0x40058A8")]
		public const short ApprenticeBait = 2674;

		[global::Cpp2ILInjected.Token(Token = "0x40058A9")]
		public const short JourneymanBait = 2675;

		[global::Cpp2ILInjected.Token(Token = "0x40058AA")]
		public const short MasterBait = 2676;

		[global::Cpp2ILInjected.Token(Token = "0x40058AB")]
		public const short AmberGemsparkWall = 2677;

		[global::Cpp2ILInjected.Token(Token = "0x40058AC")]
		public const short AmberGemsparkWallOff = 2678;

		[global::Cpp2ILInjected.Token(Token = "0x40058AD")]
		public const short AmethystGemsparkWall = 2679;

		[global::Cpp2ILInjected.Token(Token = "0x40058AE")]
		public const short AmethystGemsparkWallOff = 2680;

		[global::Cpp2ILInjected.Token(Token = "0x40058AF")]
		public const short DiamondGemsparkWall = 2681;

		[global::Cpp2ILInjected.Token(Token = "0x40058B0")]
		public const short DiamondGemsparkWallOff = 2682;

		[global::Cpp2ILInjected.Token(Token = "0x40058B1")]
		public const short EmeraldGemsparkWall = 2683;

		[global::Cpp2ILInjected.Token(Token = "0x40058B2")]
		public const short EmeraldGemsparkWallOff = 2684;

		[global::Cpp2ILInjected.Token(Token = "0x40058B3")]
		public const short RubyGemsparkWall = 2685;

		[global::Cpp2ILInjected.Token(Token = "0x40058B4")]
		public const short RubyGemsparkWallOff = 2686;

		[global::Cpp2ILInjected.Token(Token = "0x40058B5")]
		public const short SapphireGemsparkWall = 2687;

		[global::Cpp2ILInjected.Token(Token = "0x40058B6")]
		public const short SapphireGemsparkWallOff = 2688;

		[global::Cpp2ILInjected.Token(Token = "0x40058B7")]
		public const short TopazGemsparkWall = 2689;

		[global::Cpp2ILInjected.Token(Token = "0x40058B8")]
		public const short TopazGemsparkWallOff = 2690;

		[global::Cpp2ILInjected.Token(Token = "0x40058B9")]
		public const short TinPlatingWall = 2691;

		[global::Cpp2ILInjected.Token(Token = "0x40058BA")]
		public const short TinPlating = 2692;

		[global::Cpp2ILInjected.Token(Token = "0x40058BB")]
		public const short WaterfallBlock = 2693;

		[global::Cpp2ILInjected.Token(Token = "0x40058BC")]
		public const short LavafallBlock = 2694;

		[global::Cpp2ILInjected.Token(Token = "0x40058BD")]
		public const short ConfettiBlock = 2695;

		[global::Cpp2ILInjected.Token(Token = "0x40058BE")]
		public const short ConfettiWall = 2696;

		[global::Cpp2ILInjected.Token(Token = "0x40058BF")]
		public const short ConfettiBlockBlack = 2697;

		[global::Cpp2ILInjected.Token(Token = "0x40058C0")]
		public const short ConfettiWallBlack = 2698;

		[global::Cpp2ILInjected.Token(Token = "0x40058C1")]
		public const short WeaponRack = 2699;

		[global::Cpp2ILInjected.Token(Token = "0x40058C2")]
		public const short FireworksBox = 2700;

		[global::Cpp2ILInjected.Token(Token = "0x40058C3")]
		public const short LivingFireBlock = 2701;

		[global::Cpp2ILInjected.Token(Token = "0x40058C4")]
		public const short AlphabetStatue0 = 2702;

		[global::Cpp2ILInjected.Token(Token = "0x40058C5")]
		public const short AlphabetStatue1 = 2703;

		[global::Cpp2ILInjected.Token(Token = "0x40058C6")]
		public const short AlphabetStatue2 = 2704;

		[global::Cpp2ILInjected.Token(Token = "0x40058C7")]
		public const short AlphabetStatue3 = 2705;

		[global::Cpp2ILInjected.Token(Token = "0x40058C8")]
		public const short AlphabetStatue4 = 2706;

		[global::Cpp2ILInjected.Token(Token = "0x40058C9")]
		public const short AlphabetStatue5 = 2707;

		[global::Cpp2ILInjected.Token(Token = "0x40058CA")]
		public const short AlphabetStatue6 = 2708;

		[global::Cpp2ILInjected.Token(Token = "0x40058CB")]
		public const short AlphabetStatue7 = 2709;

		[global::Cpp2ILInjected.Token(Token = "0x40058CC")]
		public const short AlphabetStatue8 = 2710;

		[global::Cpp2ILInjected.Token(Token = "0x40058CD")]
		public const short AlphabetStatue9 = 2711;

		[global::Cpp2ILInjected.Token(Token = "0x40058CE")]
		public const short AlphabetStatueA = 2712;

		[global::Cpp2ILInjected.Token(Token = "0x40058CF")]
		public const short AlphabetStatueB = 2713;

		[global::Cpp2ILInjected.Token(Token = "0x40058D0")]
		public const short AlphabetStatueC = 2714;

		[global::Cpp2ILInjected.Token(Token = "0x40058D1")]
		public const short AlphabetStatueD = 2715;

		[global::Cpp2ILInjected.Token(Token = "0x40058D2")]
		public const short AlphabetStatueE = 2716;

		[global::Cpp2ILInjected.Token(Token = "0x40058D3")]
		public const short AlphabetStatueF = 2717;

		[global::Cpp2ILInjected.Token(Token = "0x40058D4")]
		public const short AlphabetStatueG = 2718;

		[global::Cpp2ILInjected.Token(Token = "0x40058D5")]
		public const short AlphabetStatueH = 2719;

		[global::Cpp2ILInjected.Token(Token = "0x40058D6")]
		public const short AlphabetStatueI = 2720;

		[global::Cpp2ILInjected.Token(Token = "0x40058D7")]
		public const short AlphabetStatueJ = 2721;

		[global::Cpp2ILInjected.Token(Token = "0x40058D8")]
		public const short AlphabetStatueK = 2722;

		[global::Cpp2ILInjected.Token(Token = "0x40058D9")]
		public const short AlphabetStatueL = 2723;

		[global::Cpp2ILInjected.Token(Token = "0x40058DA")]
		public const short AlphabetStatueM = 2724;

		[global::Cpp2ILInjected.Token(Token = "0x40058DB")]
		public const short AlphabetStatueN = 2725;

		[global::Cpp2ILInjected.Token(Token = "0x40058DC")]
		public const short AlphabetStatueO = 2726;

		[global::Cpp2ILInjected.Token(Token = "0x40058DD")]
		public const short AlphabetStatueP = 2727;

		[global::Cpp2ILInjected.Token(Token = "0x40058DE")]
		public const short AlphabetStatueQ = 2728;

		[global::Cpp2ILInjected.Token(Token = "0x40058DF")]
		public const short AlphabetStatueR = 2729;

		[global::Cpp2ILInjected.Token(Token = "0x40058E0")]
		public const short AlphabetStatueS = 2730;

		[global::Cpp2ILInjected.Token(Token = "0x40058E1")]
		public const short AlphabetStatueT = 2731;

		[global::Cpp2ILInjected.Token(Token = "0x40058E2")]
		public const short AlphabetStatueU = 2732;

		[global::Cpp2ILInjected.Token(Token = "0x40058E3")]
		public const short AlphabetStatueV = 2733;

		[global::Cpp2ILInjected.Token(Token = "0x40058E4")]
		public const short AlphabetStatueW = 2734;

		[global::Cpp2ILInjected.Token(Token = "0x40058E5")]
		public const short AlphabetStatueX = 2735;

		[global::Cpp2ILInjected.Token(Token = "0x40058E6")]
		public const short AlphabetStatueY = 2736;

		[global::Cpp2ILInjected.Token(Token = "0x40058E7")]
		public const short AlphabetStatueZ = 2737;

		[global::Cpp2ILInjected.Token(Token = "0x40058E8")]
		public const short FireworkFountain = 2738;

		[global::Cpp2ILInjected.Token(Token = "0x40058E9")]
		public const short BoosterTrack = 2739;

		[global::Cpp2ILInjected.Token(Token = "0x40058EA")]
		public const short Grasshopper = 2740;

		[global::Cpp2ILInjected.Token(Token = "0x40058EB")]
		public const short GrasshopperCage = 2741;

		[global::Cpp2ILInjected.Token(Token = "0x40058EC")]
		public const short MusicBoxUndergroundCrimson = 2742;

		[global::Cpp2ILInjected.Token(Token = "0x40058ED")]
		public const short CactusTable = 2743;

		[global::Cpp2ILInjected.Token(Token = "0x40058EE")]
		public const short CactusPlatform = 2744;

		[global::Cpp2ILInjected.Token(Token = "0x40058EF")]
		public const short BorealWoodSword = 2745;

		[global::Cpp2ILInjected.Token(Token = "0x40058F0")]
		public const short BorealWoodHammer = 2746;

		[global::Cpp2ILInjected.Token(Token = "0x40058F1")]
		public const short BorealWoodBow = 2747;

		[global::Cpp2ILInjected.Token(Token = "0x40058F2")]
		public const short GlassChest = 2748;

		[global::Cpp2ILInjected.Token(Token = "0x40058F3")]
		public const short XenoStaff = 2749;

		[global::Cpp2ILInjected.Token(Token = "0x40058F4")]
		public const short MeteorStaff = 2750;

		[global::Cpp2ILInjected.Token(Token = "0x40058F5")]
		public const short LivingCursedFireBlock = 2751;

		[global::Cpp2ILInjected.Token(Token = "0x40058F6")]
		public const short LivingDemonFireBlock = 2752;

		[global::Cpp2ILInjected.Token(Token = "0x40058F7")]
		public const short LivingFrostFireBlock = 2753;

		[global::Cpp2ILInjected.Token(Token = "0x40058F8")]
		public const short LivingIchorBlock = 2754;

		[global::Cpp2ILInjected.Token(Token = "0x40058F9")]
		public const short LivingUltrabrightFireBlock = 2755;

		[global::Cpp2ILInjected.Token(Token = "0x40058FA")]
		public const short GenderChangePotion = 2756;

		[global::Cpp2ILInjected.Token(Token = "0x40058FB")]
		public const short VortexHelmet = 2757;

		[global::Cpp2ILInjected.Token(Token = "0x40058FC")]
		public const short VortexBreastplate = 2758;

		[global::Cpp2ILInjected.Token(Token = "0x40058FD")]
		public const short VortexLeggings = 2759;

		[global::Cpp2ILInjected.Token(Token = "0x40058FE")]
		public const short NebulaHelmet = 2760;

		[global::Cpp2ILInjected.Token(Token = "0x40058FF")]
		public const short NebulaBreastplate = 2761;

		[global::Cpp2ILInjected.Token(Token = "0x4005900")]
		public const short NebulaLeggings = 2762;

		[global::Cpp2ILInjected.Token(Token = "0x4005901")]
		public const short SolarFlareHelmet = 2763;

		[global::Cpp2ILInjected.Token(Token = "0x4005902")]
		public const short SolarFlareBreastplate = 2764;

		[global::Cpp2ILInjected.Token(Token = "0x4005903")]
		public const short SolarFlareLeggings = 2765;

		[global::Cpp2ILInjected.Token(Token = "0x4005904")]
		public const short LunarTabletFragment = 2766;

		[global::Cpp2ILInjected.Token(Token = "0x4005905")]
		public const short SolarTablet = 2767;

		[global::Cpp2ILInjected.Token(Token = "0x4005906")]
		public const short DrillContainmentUnit = 2768;

		[global::Cpp2ILInjected.Token(Token = "0x4005907")]
		public const short CosmicCarKey = 2769;

		[global::Cpp2ILInjected.Token(Token = "0x4005908")]
		public const short MothronWings = 2770;

		[global::Cpp2ILInjected.Token(Token = "0x4005909")]
		public const short BrainScrambler = 2771;

		[global::Cpp2ILInjected.Token(Token = "0x400590A")]
		public const short VortexAxe = 2772;

		[global::Cpp2ILInjected.Token(Token = "0x400590B")]
		public const short VortexChainsaw = 2773;

		[global::Cpp2ILInjected.Token(Token = "0x400590C")]
		public const short VortexDrill = 2774;

		[global::Cpp2ILInjected.Token(Token = "0x400590D")]
		public const short VortexHammer = 2775;

		[global::Cpp2ILInjected.Token(Token = "0x400590E")]
		public const short VortexPickaxe = 2776;

		[global::Cpp2ILInjected.Token(Token = "0x400590F")]
		public const short NebulaAxe = 2777;

		[global::Cpp2ILInjected.Token(Token = "0x4005910")]
		public const short NebulaChainsaw = 2778;

		[global::Cpp2ILInjected.Token(Token = "0x4005911")]
		public const short NebulaDrill = 2779;

		[global::Cpp2ILInjected.Token(Token = "0x4005912")]
		public const short NebulaHammer = 2780;

		[global::Cpp2ILInjected.Token(Token = "0x4005913")]
		public const short NebulaPickaxe = 2781;

		[global::Cpp2ILInjected.Token(Token = "0x4005914")]
		public const short SolarFlareAxe = 2782;

		[global::Cpp2ILInjected.Token(Token = "0x4005915")]
		public const short SolarFlareChainsaw = 2783;

		[global::Cpp2ILInjected.Token(Token = "0x4005916")]
		public const short SolarFlareDrill = 2784;

		[global::Cpp2ILInjected.Token(Token = "0x4005917")]
		public const short SolarFlareHammer = 2785;

		[global::Cpp2ILInjected.Token(Token = "0x4005918")]
		public const short SolarFlarePickaxe = 2786;

		[global::Cpp2ILInjected.Token(Token = "0x4005919")]
		public const short HoneyfallBlock = 2787;

		[global::Cpp2ILInjected.Token(Token = "0x400591A")]
		public const short HoneyfallWall = 2788;

		[global::Cpp2ILInjected.Token(Token = "0x400591B")]
		public const short ChlorophyteBrickWall = 2789;

		[global::Cpp2ILInjected.Token(Token = "0x400591C")]
		public const short CrimtaneBrickWall = 2790;

		[global::Cpp2ILInjected.Token(Token = "0x400591D")]
		public const short ShroomitePlatingWall = 2791;

		[global::Cpp2ILInjected.Token(Token = "0x400591E")]
		public const short ChlorophyteBrick = 2792;

		[global::Cpp2ILInjected.Token(Token = "0x400591F")]
		public const short CrimtaneBrick = 2793;

		[global::Cpp2ILInjected.Token(Token = "0x4005920")]
		public const short ShroomitePlating = 2794;

		[global::Cpp2ILInjected.Token(Token = "0x4005921")]
		public const short LaserMachinegun = 2795;

		[global::Cpp2ILInjected.Token(Token = "0x4005922")]
		public const short ElectrosphereLauncher = 2796;

		[global::Cpp2ILInjected.Token(Token = "0x4005923")]
		public const short Xenopopper = 2797;

		[global::Cpp2ILInjected.Token(Token = "0x4005924")]
		public const short LaserDrill = 2798;

		[global::Cpp2ILInjected.Token(Token = "0x4005925")]
		public const short LaserRuler = 2799;

		[global::Cpp2ILInjected.Token(Token = "0x4005926")]
		public const short AntiGravityHook = 2800;

		[global::Cpp2ILInjected.Token(Token = "0x4005927")]
		public const short MoonMask = 2801;

		[global::Cpp2ILInjected.Token(Token = "0x4005928")]
		public const short SunMask = 2802;

		[global::Cpp2ILInjected.Token(Token = "0x4005929")]
		public const short MartianCostumeMask = 2803;

		[global::Cpp2ILInjected.Token(Token = "0x400592A")]
		public const short MartianCostumeShirt = 2804;

		[global::Cpp2ILInjected.Token(Token = "0x400592B")]
		public const short MartianCostumePants = 2805;

		[global::Cpp2ILInjected.Token(Token = "0x400592C")]
		public const short MartianUniformHelmet = 2806;

		[global::Cpp2ILInjected.Token(Token = "0x400592D")]
		public const short MartianUniformTorso = 2807;

		[global::Cpp2ILInjected.Token(Token = "0x400592E")]
		public const short MartianUniformPants = 2808;

		[global::Cpp2ILInjected.Token(Token = "0x400592F")]
		public const short MartianAstroClock = 2809;

		[global::Cpp2ILInjected.Token(Token = "0x4005930")]
		public const short MartianBathtub = 2810;

		[global::Cpp2ILInjected.Token(Token = "0x4005931")]
		public const short MartianBed = 2811;

		[global::Cpp2ILInjected.Token(Token = "0x4005932")]
		public const short MartianHoverChair = 2812;

		[global::Cpp2ILInjected.Token(Token = "0x4005933")]
		public const short MartianChandelier = 2813;

		[global::Cpp2ILInjected.Token(Token = "0x4005934")]
		public const short MartianChest = 2814;

		[global::Cpp2ILInjected.Token(Token = "0x4005935")]
		public const short MartianDoor = 2815;

		[global::Cpp2ILInjected.Token(Token = "0x4005936")]
		public const short MartianDresser = 2816;

		[global::Cpp2ILInjected.Token(Token = "0x4005937")]
		public const short MartianHolobookcase = 2817;

		[global::Cpp2ILInjected.Token(Token = "0x4005938")]
		public const short MartianHoverCandle = 2818;

		[global::Cpp2ILInjected.Token(Token = "0x4005939")]
		public const short MartianLamppost = 2819;

		[global::Cpp2ILInjected.Token(Token = "0x400593A")]
		public const short MartianLantern = 2820;

		[global::Cpp2ILInjected.Token(Token = "0x400593B")]
		public const short MartianPiano = 2821;

		[global::Cpp2ILInjected.Token(Token = "0x400593C")]
		public const short MartianPlatform = 2822;

		[global::Cpp2ILInjected.Token(Token = "0x400593D")]
		public const short MartianSofa = 2823;

		[global::Cpp2ILInjected.Token(Token = "0x400593E")]
		public const short MartianTable = 2824;

		[global::Cpp2ILInjected.Token(Token = "0x400593F")]
		public const short MartianTableLamp = 2825;

		[global::Cpp2ILInjected.Token(Token = "0x4005940")]
		public const short MartianWorkBench = 2826;

		[global::Cpp2ILInjected.Token(Token = "0x4005941")]
		public const short WoodenSink = 2827;

		[global::Cpp2ILInjected.Token(Token = "0x4005942")]
		public const short EbonwoodSink = 2828;

		[global::Cpp2ILInjected.Token(Token = "0x4005943")]
		public const short RichMahoganySink = 2829;

		[global::Cpp2ILInjected.Token(Token = "0x4005944")]
		public const short PearlwoodSink = 2830;

		[global::Cpp2ILInjected.Token(Token = "0x4005945")]
		public const short BoneSink = 2831;

		[global::Cpp2ILInjected.Token(Token = "0x4005946")]
		public const short FleshSink = 2832;

		[global::Cpp2ILInjected.Token(Token = "0x4005947")]
		public const short LivingWoodSink = 2833;

		[global::Cpp2ILInjected.Token(Token = "0x4005948")]
		public const short SkywareSink = 2834;

		[global::Cpp2ILInjected.Token(Token = "0x4005949")]
		public const short ShadewoodSink = 2835;

		[global::Cpp2ILInjected.Token(Token = "0x400594A")]
		public const short LihzahrdSink = 2836;

		[global::Cpp2ILInjected.Token(Token = "0x400594B")]
		public const short BlueDungeonSink = 2837;

		[global::Cpp2ILInjected.Token(Token = "0x400594C")]
		public const short GreenDungeonSink = 2838;

		[global::Cpp2ILInjected.Token(Token = "0x400594D")]
		public const short PinkDungeonSink = 2839;

		[global::Cpp2ILInjected.Token(Token = "0x400594E")]
		public const short ObsidianSink = 2840;

		[global::Cpp2ILInjected.Token(Token = "0x400594F")]
		public const short MetalSink = 2841;

		[global::Cpp2ILInjected.Token(Token = "0x4005950")]
		public const short GlassSink = 2842;

		[global::Cpp2ILInjected.Token(Token = "0x4005951")]
		public const short GoldenSink = 2843;

		[global::Cpp2ILInjected.Token(Token = "0x4005952")]
		public const short HoneySink = 2844;

		[global::Cpp2ILInjected.Token(Token = "0x4005953")]
		public const short SteampunkSink = 2845;

		[global::Cpp2ILInjected.Token(Token = "0x4005954")]
		public const short PumpkinSink = 2846;

		[global::Cpp2ILInjected.Token(Token = "0x4005955")]
		public const short SpookySink = 2847;

		[global::Cpp2ILInjected.Token(Token = "0x4005956")]
		public const short FrozenSink = 2848;

		[global::Cpp2ILInjected.Token(Token = "0x4005957")]
		public const short DynastySink = 2849;

		[global::Cpp2ILInjected.Token(Token = "0x4005958")]
		public const short PalmWoodSink = 2850;

		[global::Cpp2ILInjected.Token(Token = "0x4005959")]
		public const short MushroomSink = 2851;

		[global::Cpp2ILInjected.Token(Token = "0x400595A")]
		public const short BorealWoodSink = 2852;

		[global::Cpp2ILInjected.Token(Token = "0x400595B")]
		public const short SlimeSink = 2853;

		[global::Cpp2ILInjected.Token(Token = "0x400595C")]
		public const short CactusSink = 2854;

		[global::Cpp2ILInjected.Token(Token = "0x400595D")]
		public const short MartianSink = 2855;

		[global::Cpp2ILInjected.Token(Token = "0x400595E")]
		public const short WhiteLunaticHood = 2856;

		[global::Cpp2ILInjected.Token(Token = "0x400595F")]
		public const short BlueLunaticHood = 2857;

		[global::Cpp2ILInjected.Token(Token = "0x4005960")]
		public const short WhiteLunaticRobe = 2858;

		[global::Cpp2ILInjected.Token(Token = "0x4005961")]
		public const short BlueLunaticRobe = 2859;

		[global::Cpp2ILInjected.Token(Token = "0x4005962")]
		public const short MartianConduitPlating = 2860;

		[global::Cpp2ILInjected.Token(Token = "0x4005963")]
		public const short MartianConduitWall = 2861;

		[global::Cpp2ILInjected.Token(Token = "0x4005964")]
		public const short HiTekSunglasses = 2862;

		[global::Cpp2ILInjected.Token(Token = "0x4005965")]
		public const short MartianHairDye = 2863;

		[global::Cpp2ILInjected.Token(Token = "0x4005966")]
		public const short MartianArmorDye = 2864;

		[global::Cpp2ILInjected.Token(Token = "0x4005967")]
		public const short PaintingCastleMarsberg = 2865;

		[global::Cpp2ILInjected.Token(Token = "0x4005968")]
		public const short PaintingMartiaLisa = 2866;

		[global::Cpp2ILInjected.Token(Token = "0x4005969")]
		public const short PaintingTheTruthIsUpThere = 2867;

		[global::Cpp2ILInjected.Token(Token = "0x400596A")]
		public const short SmokeBlock = 2868;

		[global::Cpp2ILInjected.Token(Token = "0x400596B")]
		public const short LivingFlameDye = 2869;

		[global::Cpp2ILInjected.Token(Token = "0x400596C")]
		public const short LivingRainbowDye = 2870;

		[global::Cpp2ILInjected.Token(Token = "0x400596D")]
		public const short ShadowDye = 2871;

		[global::Cpp2ILInjected.Token(Token = "0x400596E")]
		public const short NegativeDye = 2872;

		[global::Cpp2ILInjected.Token(Token = "0x400596F")]
		public const short LivingOceanDye = 2873;

		[global::Cpp2ILInjected.Token(Token = "0x4005970")]
		public const short BrownDye = 2874;

		[global::Cpp2ILInjected.Token(Token = "0x4005971")]
		public const short BrownAndBlackDye = 2875;

		[global::Cpp2ILInjected.Token(Token = "0x4005972")]
		public const short BrightBrownDye = 2876;

		[global::Cpp2ILInjected.Token(Token = "0x4005973")]
		public const short BrownAndSilverDye = 2877;

		[global::Cpp2ILInjected.Token(Token = "0x4005974")]
		public const short WispDye = 2878;

		[global::Cpp2ILInjected.Token(Token = "0x4005975")]
		public const short PixieDye = 2879;

		[global::Cpp2ILInjected.Token(Token = "0x4005976")]
		public const short InfluxWaver = 2880;

		[global::Cpp2ILInjected.Token(Token = "0x4005977")]
		public const short PhasicWarpEjector = 2881;

		[global::Cpp2ILInjected.Token(Token = "0x4005978")]
		public const short ChargedBlasterCannon = 2882;

		[global::Cpp2ILInjected.Token(Token = "0x4005979")]
		public const short ChlorophyteDye = 2883;

		[global::Cpp2ILInjected.Token(Token = "0x400597A")]
		public const short UnicornWispDye = 2884;

		[global::Cpp2ILInjected.Token(Token = "0x400597B")]
		public const short InfernalWispDye = 2885;

		[global::Cpp2ILInjected.Token(Token = "0x400597C")]
		public const short ViciousPowder = 2886;

		[global::Cpp2ILInjected.Token(Token = "0x400597D")]
		public const short ViciousMushroom = 2887;

		[global::Cpp2ILInjected.Token(Token = "0x400597E")]
		public const short BeesKnees = 2888;

		[global::Cpp2ILInjected.Token(Token = "0x400597F")]
		public const short GoldBird = 2889;

		[global::Cpp2ILInjected.Token(Token = "0x4005980")]
		public const short GoldBunny = 2890;

		[global::Cpp2ILInjected.Token(Token = "0x4005981")]
		public const short GoldButterfly = 2891;

		[global::Cpp2ILInjected.Token(Token = "0x4005982")]
		public const short GoldFrog = 2892;

		[global::Cpp2ILInjected.Token(Token = "0x4005983")]
		public const short GoldGrasshopper = 2893;

		[global::Cpp2ILInjected.Token(Token = "0x4005984")]
		public const short GoldMouse = 2894;

		[global::Cpp2ILInjected.Token(Token = "0x4005985")]
		public const short GoldWorm = 2895;

		[global::Cpp2ILInjected.Token(Token = "0x4005986")]
		public const short StickyDynamite = 2896;

		[global::Cpp2ILInjected.Token(Token = "0x4005987")]
		public const short AngryTrapperBanner = 2897;

		[global::Cpp2ILInjected.Token(Token = "0x4005988")]
		public const short ArmoredVikingBanner = 2898;

		[global::Cpp2ILInjected.Token(Token = "0x4005989")]
		public const short BlackSlimeBanner = 2899;

		[global::Cpp2ILInjected.Token(Token = "0x400598A")]
		public const short BlueArmoredBonesBanner = 2900;

		[global::Cpp2ILInjected.Token(Token = "0x400598B")]
		public const short BlueCultistArcherBanner = 2901;

		[global::Cpp2ILInjected.Token(Token = "0x400598C")]
		public const short BlueCultistCasterBanner = 2902;

		[global::Cpp2ILInjected.Token(Token = "0x400598D")]
		public const short BlueCultistFighterBanner = 2903;

		[global::Cpp2ILInjected.Token(Token = "0x400598E")]
		public const short BoneLeeBanner = 2904;

		[global::Cpp2ILInjected.Token(Token = "0x400598F")]
		public const short ClingerBanner = 2905;

		[global::Cpp2ILInjected.Token(Token = "0x4005990")]
		public const short CochinealBeetleBanner = 2906;

		[global::Cpp2ILInjected.Token(Token = "0x4005991")]
		public const short CorruptPenguinBanner = 2907;

		[global::Cpp2ILInjected.Token(Token = "0x4005992")]
		public const short CorruptSlimeBanner = 2908;

		[global::Cpp2ILInjected.Token(Token = "0x4005993")]
		public const short CorruptorBanner = 2909;

		[global::Cpp2ILInjected.Token(Token = "0x4005994")]
		public const short CrimslimeBanner = 2910;

		[global::Cpp2ILInjected.Token(Token = "0x4005995")]
		public const short CursedSkullBanner = 2911;

		[global::Cpp2ILInjected.Token(Token = "0x4005996")]
		public const short CyanBeetleBanner = 2912;

		[global::Cpp2ILInjected.Token(Token = "0x4005997")]
		public const short DevourerBanner = 2913;

		[global::Cpp2ILInjected.Token(Token = "0x4005998")]
		public const short DiablolistBanner = 2914;

		[global::Cpp2ILInjected.Token(Token = "0x4005999")]
		public const short DoctorBonesBanner = 2915;

		[global::Cpp2ILInjected.Token(Token = "0x400599A")]
		public const short DungeonSlimeBanner = 2916;

		[global::Cpp2ILInjected.Token(Token = "0x400599B")]
		public const short DungeonSpiritBanner = 2917;

		[global::Cpp2ILInjected.Token(Token = "0x400599C")]
		public const short ElfArcherBanner = 2918;

		[global::Cpp2ILInjected.Token(Token = "0x400599D")]
		public const short ElfCopterBanner = 2919;

		[global::Cpp2ILInjected.Token(Token = "0x400599E")]
		public const short EyezorBanner = 2920;

		[global::Cpp2ILInjected.Token(Token = "0x400599F")]
		public const short FlockoBanner = 2921;

		[global::Cpp2ILInjected.Token(Token = "0x40059A0")]
		public const short GhostBanner = 2922;

		[global::Cpp2ILInjected.Token(Token = "0x40059A1")]
		public const short GiantBatBanner = 2923;

		[global::Cpp2ILInjected.Token(Token = "0x40059A2")]
		public const short GiantCursedSkullBanner = 2924;

		[global::Cpp2ILInjected.Token(Token = "0x40059A3")]
		public const short GiantFlyingFoxBanner = 2925;

		[global::Cpp2ILInjected.Token(Token = "0x40059A4")]
		public const short GingerbreadManBanner = 2926;

		[global::Cpp2ILInjected.Token(Token = "0x40059A5")]
		public const short GoblinArcherBanner = 2927;

		[global::Cpp2ILInjected.Token(Token = "0x40059A6")]
		public const short GreenSlimeBanner = 2928;

		[global::Cpp2ILInjected.Token(Token = "0x40059A7")]
		public const short HeadlessHorsemanBanner = 2929;

		[global::Cpp2ILInjected.Token(Token = "0x40059A8")]
		public const short HellArmoredBonesBanner = 2930;

		[global::Cpp2ILInjected.Token(Token = "0x40059A9")]
		public const short HellhoundBanner = 2931;

		[global::Cpp2ILInjected.Token(Token = "0x40059AA")]
		public const short HoppinJackBanner = 2932;

		[global::Cpp2ILInjected.Token(Token = "0x40059AB")]
		public const short IceBatBanner = 2933;

		[global::Cpp2ILInjected.Token(Token = "0x40059AC")]
		public const short IceGolemBanner = 2934;

		[global::Cpp2ILInjected.Token(Token = "0x40059AD")]
		public const short IceSlimeBanner = 2935;

		[global::Cpp2ILInjected.Token(Token = "0x40059AE")]
		public const short IchorStickerBanner = 2936;

		[global::Cpp2ILInjected.Token(Token = "0x40059AF")]
		public const short IlluminantBatBanner = 2937;

		[global::Cpp2ILInjected.Token(Token = "0x40059B0")]
		public const short IlluminantSlimeBanner = 2938;

		[global::Cpp2ILInjected.Token(Token = "0x40059B1")]
		public const short JungleBatBanner = 2939;

		[global::Cpp2ILInjected.Token(Token = "0x40059B2")]
		public const short JungleSlimeBanner = 2940;

		[global::Cpp2ILInjected.Token(Token = "0x40059B3")]
		public const short KrampusBanner = 2941;

		[global::Cpp2ILInjected.Token(Token = "0x40059B4")]
		public const short LacBeetleBanner = 2942;

		[global::Cpp2ILInjected.Token(Token = "0x40059B5")]
		public const short LavaBatBanner = 2943;

		[global::Cpp2ILInjected.Token(Token = "0x40059B6")]
		public const short LavaSlimeBanner = 2944;

		[global::Cpp2ILInjected.Token(Token = "0x40059B7")]
		public const short MartianBrainscramblerBanner = 2945;

		[global::Cpp2ILInjected.Token(Token = "0x40059B8")]
		public const short MartianDroneBanner = 2946;

		[global::Cpp2ILInjected.Token(Token = "0x40059B9")]
		public const short MartianEngineerBanner = 2947;

		[global::Cpp2ILInjected.Token(Token = "0x40059BA")]
		public const short MartianGigazapperBanner = 2948;

		[global::Cpp2ILInjected.Token(Token = "0x40059BB")]
		public const short MartianGreyGruntBanner = 2949;

		[global::Cpp2ILInjected.Token(Token = "0x40059BC")]
		public const short MartianOfficerBanner = 2950;

		[global::Cpp2ILInjected.Token(Token = "0x40059BD")]
		public const short MartianRaygunnerBanner = 2951;

		[global::Cpp2ILInjected.Token(Token = "0x40059BE")]
		public const short MartianScutlixGunnerBanner = 2952;

		[global::Cpp2ILInjected.Token(Token = "0x40059BF")]
		public const short MartianTeslaTurretBanner = 2953;

		[global::Cpp2ILInjected.Token(Token = "0x40059C0")]
		public const short MisterStabbyBanner = 2954;

		[global::Cpp2ILInjected.Token(Token = "0x40059C1")]
		public const short MotherSlimeBanner = 2955;

		[global::Cpp2ILInjected.Token(Token = "0x40059C2")]
		public const short NecromancerBanner = 2956;

		[global::Cpp2ILInjected.Token(Token = "0x40059C3")]
		public const short NutcrackerBanner = 2957;

		[global::Cpp2ILInjected.Token(Token = "0x40059C4")]
		public const short PaladinBanner = 2958;

		[global::Cpp2ILInjected.Token(Token = "0x40059C5")]
		public const short PenguinBanner = 2959;

		[global::Cpp2ILInjected.Token(Token = "0x40059C6")]
		public const short PinkyBanner = 2960;

		[global::Cpp2ILInjected.Token(Token = "0x40059C7")]
		public const short PoltergeistBanner = 2961;

		[global::Cpp2ILInjected.Token(Token = "0x40059C8")]
		public const short PossessedArmorBanner = 2962;

		[global::Cpp2ILInjected.Token(Token = "0x40059C9")]
		public const short PresentMimicBanner = 2963;

		[global::Cpp2ILInjected.Token(Token = "0x40059CA")]
		public const short PurpleSlimeBanner = 2964;

		[global::Cpp2ILInjected.Token(Token = "0x40059CB")]
		public const short RaggedCasterBanner = 2965;

		[global::Cpp2ILInjected.Token(Token = "0x40059CC")]
		public const short RainbowSlimeBanner = 2966;

		[global::Cpp2ILInjected.Token(Token = "0x40059CD")]
		public const short RavenBanner = 2967;

		[global::Cpp2ILInjected.Token(Token = "0x40059CE")]
		public const short RedSlimeBanner = 2968;

		[global::Cpp2ILInjected.Token(Token = "0x40059CF")]
		public const short RuneWizardBanner = 2969;

		[global::Cpp2ILInjected.Token(Token = "0x40059D0")]
		public const short RustyArmoredBonesBanner = 2970;

		[global::Cpp2ILInjected.Token(Token = "0x40059D1")]
		public const short ScarecrowBanner = 2971;

		[global::Cpp2ILInjected.Token(Token = "0x40059D2")]
		public const short ScutlixBanner = 2972;

		[global::Cpp2ILInjected.Token(Token = "0x40059D3")]
		public const short SkeletonArcherBanner = 2973;

		[global::Cpp2ILInjected.Token(Token = "0x40059D4")]
		public const short SkeletonCommandoBanner = 2974;

		[global::Cpp2ILInjected.Token(Token = "0x40059D5")]
		public const short SkeletonSniperBanner = 2975;

		[global::Cpp2ILInjected.Token(Token = "0x40059D6")]
		public const short SlimerBanner = 2976;

		[global::Cpp2ILInjected.Token(Token = "0x40059D7")]
		public const short SnatcherBanner = 2977;

		[global::Cpp2ILInjected.Token(Token = "0x40059D8")]
		public const short SnowBallaBanner = 2978;

		[global::Cpp2ILInjected.Token(Token = "0x40059D9")]
		public const short SnowmanGangstaBanner = 2979;

		[global::Cpp2ILInjected.Token(Token = "0x40059DA")]
		public const short SpikedIceSlimeBanner = 2980;

		[global::Cpp2ILInjected.Token(Token = "0x40059DB")]
		public const short SpikedJungleSlimeBanner = 2981;

		[global::Cpp2ILInjected.Token(Token = "0x40059DC")]
		public const short SplinterlingBanner = 2982;

		[global::Cpp2ILInjected.Token(Token = "0x40059DD")]
		public const short SquidBanner = 2983;

		[global::Cpp2ILInjected.Token(Token = "0x40059DE")]
		public const short TacticalSkeletonBanner = 2984;

		[global::Cpp2ILInjected.Token(Token = "0x40059DF")]
		public const short TheGroomBanner = 2985;

		[global::Cpp2ILInjected.Token(Token = "0x40059E0")]
		public const short TimBanner = 2986;

		[global::Cpp2ILInjected.Token(Token = "0x40059E1")]
		public const short UndeadMinerBanner = 2987;

		[global::Cpp2ILInjected.Token(Token = "0x40059E2")]
		public const short UndeadVikingBanner = 2988;

		[global::Cpp2ILInjected.Token(Token = "0x40059E3")]
		public const short WhiteCultistArcherBanner = 2989;

		[global::Cpp2ILInjected.Token(Token = "0x40059E4")]
		public const short WhiteCultistCasterBanner = 2990;

		[global::Cpp2ILInjected.Token(Token = "0x40059E5")]
		public const short WhiteCultistFighterBanner = 2991;

		[global::Cpp2ILInjected.Token(Token = "0x40059E6")]
		public const short YellowSlimeBanner = 2992;

		[global::Cpp2ILInjected.Token(Token = "0x40059E7")]
		public const short YetiBanner = 2993;

		[global::Cpp2ILInjected.Token(Token = "0x40059E8")]
		public const short ZombieElfBanner = 2994;

		[global::Cpp2ILInjected.Token(Token = "0x40059E9")]
		public const short SparkyPainting = 2995;

		[global::Cpp2ILInjected.Token(Token = "0x40059EA")]
		public const short VineRope = 2996;

		[global::Cpp2ILInjected.Token(Token = "0x40059EB")]
		public const short WormholePotion = 2997;

		[global::Cpp2ILInjected.Token(Token = "0x40059EC")]
		public const short SummonerEmblem = 2998;

		[global::Cpp2ILInjected.Token(Token = "0x40059ED")]
		public const short BewitchingTable = 2999;

		[global::Cpp2ILInjected.Token(Token = "0x40059EE")]
		public const short AlchemyTable = 3000;

		[global::Cpp2ILInjected.Token(Token = "0x40059EF")]
		public const short StrangeBrew = 3001;

		[global::Cpp2ILInjected.Token(Token = "0x40059F0")]
		public const short SpelunkerGlowstick = 3002;

		[global::Cpp2ILInjected.Token(Token = "0x40059F1")]
		public const short BoneArrow = 3003;

		[global::Cpp2ILInjected.Token(Token = "0x40059F2")]
		public const short BoneTorch = 3004;

		[global::Cpp2ILInjected.Token(Token = "0x40059F3")]
		public const short VineRopeCoil = 3005;

		[global::Cpp2ILInjected.Token(Token = "0x40059F4")]
		public const short SoulDrain = 3006;

		[global::Cpp2ILInjected.Token(Token = "0x40059F5")]
		public const short DartPistol = 3007;

		[global::Cpp2ILInjected.Token(Token = "0x40059F6")]
		public const short DartRifle = 3008;

		[global::Cpp2ILInjected.Token(Token = "0x40059F7")]
		public const short CrystalDart = 3009;

		[global::Cpp2ILInjected.Token(Token = "0x40059F8")]
		public const short CursedDart = 3010;

		[global::Cpp2ILInjected.Token(Token = "0x40059F9")]
		public const short IchorDart = 3011;

		[global::Cpp2ILInjected.Token(Token = "0x40059FA")]
		public const short ChainGuillotines = 3012;

		[global::Cpp2ILInjected.Token(Token = "0x40059FB")]
		public const short FetidBaghnakhs = 3013;

		[global::Cpp2ILInjected.Token(Token = "0x40059FC")]
		public const short ClingerStaff = 3014;

		[global::Cpp2ILInjected.Token(Token = "0x40059FD")]
		public const short PutridScent = 3015;

		[global::Cpp2ILInjected.Token(Token = "0x40059FE")]
		public const short FleshKnuckles = 3016;

		[global::Cpp2ILInjected.Token(Token = "0x40059FF")]
		public const short FlowerBoots = 3017;

		[global::Cpp2ILInjected.Token(Token = "0x4005A00")]
		public const short Seedler = 3018;

		[global::Cpp2ILInjected.Token(Token = "0x4005A01")]
		public const short HellwingBow = 3019;

		[global::Cpp2ILInjected.Token(Token = "0x4005A02")]
		public const short TendonHook = 3020;

		[global::Cpp2ILInjected.Token(Token = "0x4005A03")]
		public const short ThornHook = 3021;

		[global::Cpp2ILInjected.Token(Token = "0x4005A04")]
		public const short IlluminantHook = 3022;

		[global::Cpp2ILInjected.Token(Token = "0x4005A05")]
		public const short WormHook = 3023;

		[global::Cpp2ILInjected.Token(Token = "0x4005A06")]
		public const short DevDye = 3024;

		[global::Cpp2ILInjected.Token(Token = "0x4005A07")]
		public const short PurpleOozeDye = 3025;

		[global::Cpp2ILInjected.Token(Token = "0x4005A08")]
		public const short ReflectiveSilverDye = 3026;

		[global::Cpp2ILInjected.Token(Token = "0x4005A09")]
		public const short ReflectiveGoldDye = 3027;

		[global::Cpp2ILInjected.Token(Token = "0x4005A0A")]
		public const short BlueAcidDye = 3028;

		[global::Cpp2ILInjected.Token(Token = "0x4005A0B")]
		public const short DaedalusStormbow = 3029;

		[global::Cpp2ILInjected.Token(Token = "0x4005A0C")]
		public const short FlyingKnife = 3030;

		[global::Cpp2ILInjected.Token(Token = "0x4005A0D")]
		public const short BottomlessBucket = 3031;

		[global::Cpp2ILInjected.Token(Token = "0x4005A0E")]
		public const short SuperAbsorbantSponge = 3032;

		[global::Cpp2ILInjected.Token(Token = "0x4005A0F")]
		public const short GoldRing = 3033;

		[global::Cpp2ILInjected.Token(Token = "0x4005A10")]
		public const short CoinRing = 3034;

		[global::Cpp2ILInjected.Token(Token = "0x4005A11")]
		public const short GreedyRing = 3035;

		[global::Cpp2ILInjected.Token(Token = "0x4005A12")]
		public const short FishFinder = 3036;

		[global::Cpp2ILInjected.Token(Token = "0x4005A13")]
		public const short WeatherRadio = 3037;

		[global::Cpp2ILInjected.Token(Token = "0x4005A14")]
		public const short HadesDye = 3038;

		[global::Cpp2ILInjected.Token(Token = "0x4005A15")]
		public const short TwilightDye = 3039;

		[global::Cpp2ILInjected.Token(Token = "0x4005A16")]
		public const short AcidDye = 3040;

		[global::Cpp2ILInjected.Token(Token = "0x4005A17")]
		public const short MushroomDye = 3041;

		[global::Cpp2ILInjected.Token(Token = "0x4005A18")]
		public const short PhaseDye = 3042;

		[global::Cpp2ILInjected.Token(Token = "0x4005A19")]
		public const short MagicLantern = 3043;

		[global::Cpp2ILInjected.Token(Token = "0x4005A1A")]
		public const short MusicBoxLunarBoss = 3044;

		[global::Cpp2ILInjected.Token(Token = "0x4005A1B")]
		public const short RainbowTorch = 3045;

		[global::Cpp2ILInjected.Token(Token = "0x4005A1C")]
		public const short CursedCampfire = 3046;

		[global::Cpp2ILInjected.Token(Token = "0x4005A1D")]
		public const short DemonCampfire = 3047;

		[global::Cpp2ILInjected.Token(Token = "0x4005A1E")]
		public const short FrozenCampfire = 3048;

		[global::Cpp2ILInjected.Token(Token = "0x4005A1F")]
		public const short IchorCampfire = 3049;

		[global::Cpp2ILInjected.Token(Token = "0x4005A20")]
		public const short RainbowCampfire = 3050;

		[global::Cpp2ILInjected.Token(Token = "0x4005A21")]
		public const short CrystalVileShard = 3051;

		[global::Cpp2ILInjected.Token(Token = "0x4005A22")]
		public const short ShadowFlameBow = 3052;

		[global::Cpp2ILInjected.Token(Token = "0x4005A23")]
		public const short ShadowFlameHexDoll = 3053;

		[global::Cpp2ILInjected.Token(Token = "0x4005A24")]
		public const short ShadowFlameKnife = 3054;

		[global::Cpp2ILInjected.Token(Token = "0x4005A25")]
		public const short PaintingAcorns = 3055;

		[global::Cpp2ILInjected.Token(Token = "0x4005A26")]
		public const short PaintingColdSnap = 3056;

		[global::Cpp2ILInjected.Token(Token = "0x4005A27")]
		public const short PaintingCursedSaint = 3057;

		[global::Cpp2ILInjected.Token(Token = "0x4005A28")]
		public const short PaintingSnowfellas = 3058;

		[global::Cpp2ILInjected.Token(Token = "0x4005A29")]
		public const short PaintingTheSeason = 3059;

		[global::Cpp2ILInjected.Token(Token = "0x4005A2A")]
		public const short BoneRattle = 3060;

		[global::Cpp2ILInjected.Token(Token = "0x4005A2B")]
		public const short ArchitectGizmoPack = 3061;

		[global::Cpp2ILInjected.Token(Token = "0x4005A2C")]
		public const short CrimsonHeart = 3062;

		[global::Cpp2ILInjected.Token(Token = "0x4005A2D")]
		public const short Meowmere = 3063;

		[global::Cpp2ILInjected.Token(Token = "0x4005A2E")]
		public const short Sundial = 3064;

		[global::Cpp2ILInjected.Token(Token = "0x4005A2F")]
		public const short StarWrath = 3065;

		[global::Cpp2ILInjected.Token(Token = "0x4005A30")]
		public const short MarbleBlock = 3066;

		[global::Cpp2ILInjected.Token(Token = "0x4005A31")]
		public const short HellstoneBrickWall = 3067;

		[global::Cpp2ILInjected.Token(Token = "0x4005A32")]
		public const short CordageGuide = 3068;

		[global::Cpp2ILInjected.Token(Token = "0x4005A33")]
		public const short WandofSparking = 3069;

		[global::Cpp2ILInjected.Token(Token = "0x4005A34")]
		public const short GoldBirdCage = 3070;

		[global::Cpp2ILInjected.Token(Token = "0x4005A35")]
		public const short GoldBunnyCage = 3071;

		[global::Cpp2ILInjected.Token(Token = "0x4005A36")]
		public const short GoldButterflyCage = 3072;

		[global::Cpp2ILInjected.Token(Token = "0x4005A37")]
		public const short GoldFrogCage = 3073;

		[global::Cpp2ILInjected.Token(Token = "0x4005A38")]
		public const short GoldGrasshopperCage = 3074;

		[global::Cpp2ILInjected.Token(Token = "0x4005A39")]
		public const short GoldMouseCage = 3075;

		[global::Cpp2ILInjected.Token(Token = "0x4005A3A")]
		public const short GoldWormCage = 3076;

		[global::Cpp2ILInjected.Token(Token = "0x4005A3B")]
		public const short SilkRope = 3077;

		[global::Cpp2ILInjected.Token(Token = "0x4005A3C")]
		public const short WebRope = 3078;

		[global::Cpp2ILInjected.Token(Token = "0x4005A3D")]
		public const short SilkRopeCoil = 3079;

		[global::Cpp2ILInjected.Token(Token = "0x4005A3E")]
		public const short WebRopeCoil = 3080;

		[global::Cpp2ILInjected.Token(Token = "0x4005A3F")]
		public const short Marble = 3081;

		[global::Cpp2ILInjected.Token(Token = "0x4005A40")]
		public const short MarbleWall = 3082;

		[global::Cpp2ILInjected.Token(Token = "0x4005A41")]
		public const short MarbleBlockWall = 3083;

		[global::Cpp2ILInjected.Token(Token = "0x4005A42")]
		public const short Radar = 3084;

		[global::Cpp2ILInjected.Token(Token = "0x4005A43")]
		public const short LockBox = 3085;

		[global::Cpp2ILInjected.Token(Token = "0x4005A44")]
		public const short Granite = 3086;

		[global::Cpp2ILInjected.Token(Token = "0x4005A45")]
		public const short GraniteBlock = 3087;

		[global::Cpp2ILInjected.Token(Token = "0x4005A46")]
		public const short GraniteWall = 3088;

		[global::Cpp2ILInjected.Token(Token = "0x4005A47")]
		public const short GraniteBlockWall = 3089;

		[global::Cpp2ILInjected.Token(Token = "0x4005A48")]
		public const short RoyalGel = 3090;

		[global::Cpp2ILInjected.Token(Token = "0x4005A49")]
		public const short NightKey = 3091;

		[global::Cpp2ILInjected.Token(Token = "0x4005A4A")]
		public const short LightKey = 3092;

		[global::Cpp2ILInjected.Token(Token = "0x4005A4B")]
		public const short HerbBag = 3093;

		[global::Cpp2ILInjected.Token(Token = "0x4005A4C")]
		public const short Javelin = 3094;

		[global::Cpp2ILInjected.Token(Token = "0x4005A4D")]
		public const short TallyCounter = 3095;

		[global::Cpp2ILInjected.Token(Token = "0x4005A4E")]
		public const short Sextant = 3096;

		[global::Cpp2ILInjected.Token(Token = "0x4005A4F")]
		public const short EoCShield = 3097;

		[global::Cpp2ILInjected.Token(Token = "0x4005A50")]
		public const short ButchersChainsaw = 3098;

		[global::Cpp2ILInjected.Token(Token = "0x4005A51")]
		public const short Stopwatch = 3099;

		[global::Cpp2ILInjected.Token(Token = "0x4005A52")]
		public const short MeteoriteBrick = 3100;

		[global::Cpp2ILInjected.Token(Token = "0x4005A53")]
		public const short MeteoriteBrickWall = 3101;

		[global::Cpp2ILInjected.Token(Token = "0x4005A54")]
		public const short MetalDetector = 3102;

		[global::Cpp2ILInjected.Token(Token = "0x4005A55")]
		public const short EndlessQuiver = 3103;

		[global::Cpp2ILInjected.Token(Token = "0x4005A56")]
		public const short EndlessMusketPouch = 3104;

		[global::Cpp2ILInjected.Token(Token = "0x4005A57")]
		public const short ToxicFlask = 3105;

		[global::Cpp2ILInjected.Token(Token = "0x4005A58")]
		public const short PsychoKnife = 3106;

		[global::Cpp2ILInjected.Token(Token = "0x4005A59")]
		public const short NailGun = 3107;

		[global::Cpp2ILInjected.Token(Token = "0x4005A5A")]
		public const short Nail = 3108;

		[global::Cpp2ILInjected.Token(Token = "0x4005A5B")]
		public const short NightVisionHelmet = 3109;

		[global::Cpp2ILInjected.Token(Token = "0x4005A5C")]
		public const short CelestialShell = 3110;

		[global::Cpp2ILInjected.Token(Token = "0x4005A5D")]
		public const short PinkGel = 3111;

		[global::Cpp2ILInjected.Token(Token = "0x4005A5E")]
		public const short BouncyGlowstick = 3112;

		[global::Cpp2ILInjected.Token(Token = "0x4005A5F")]
		public const short PinkSlimeBlock = 3113;

		[global::Cpp2ILInjected.Token(Token = "0x4005A60")]
		public const short PinkTorch = 3114;

		[global::Cpp2ILInjected.Token(Token = "0x4005A61")]
		public const short BouncyBomb = 3115;

		[global::Cpp2ILInjected.Token(Token = "0x4005A62")]
		public const short BouncyGrenade = 3116;

		[global::Cpp2ILInjected.Token(Token = "0x4005A63")]
		public const short PeaceCandle = 3117;

		[global::Cpp2ILInjected.Token(Token = "0x4005A64")]
		public const short LifeformAnalyzer = 3118;

		[global::Cpp2ILInjected.Token(Token = "0x4005A65")]
		public const short DPSMeter = 3119;

		[global::Cpp2ILInjected.Token(Token = "0x4005A66")]
		public const short FishermansGuide = 3120;

		[global::Cpp2ILInjected.Token(Token = "0x4005A67")]
		public const short GoblinTech = 3121;

		[global::Cpp2ILInjected.Token(Token = "0x4005A68")]
		public const short REK = 3122;

		[global::Cpp2ILInjected.Token(Token = "0x4005A69")]
		public const short PDA = 3123;

		[global::Cpp2ILInjected.Token(Token = "0x4005A6A")]
		public const short CellPhone = 3124;

		[global::Cpp2ILInjected.Token(Token = "0x4005A6B")]
		public const short GraniteChest = 3125;

		[global::Cpp2ILInjected.Token(Token = "0x4005A6C")]
		public const short MeteoriteClock = 3126;

		[global::Cpp2ILInjected.Token(Token = "0x4005A6D")]
		public const short MarbleClock = 3127;

		[global::Cpp2ILInjected.Token(Token = "0x4005A6E")]
		public const short GraniteClock = 3128;

		[global::Cpp2ILInjected.Token(Token = "0x4005A6F")]
		public const short MeteoriteDoor = 3129;

		[global::Cpp2ILInjected.Token(Token = "0x4005A70")]
		public const short MarbleDoor = 3130;

		[global::Cpp2ILInjected.Token(Token = "0x4005A71")]
		public const short GraniteDoor = 3131;

		[global::Cpp2ILInjected.Token(Token = "0x4005A72")]
		public const short MeteoriteDresser = 3132;

		[global::Cpp2ILInjected.Token(Token = "0x4005A73")]
		public const short MarbleDresser = 3133;

		[global::Cpp2ILInjected.Token(Token = "0x4005A74")]
		public const short GraniteDresser = 3134;

		[global::Cpp2ILInjected.Token(Token = "0x4005A75")]
		public const short MeteoriteLamp = 3135;

		[global::Cpp2ILInjected.Token(Token = "0x4005A76")]
		public const short MarbleLamp = 3136;

		[global::Cpp2ILInjected.Token(Token = "0x4005A77")]
		public const short GraniteLamp = 3137;

		[global::Cpp2ILInjected.Token(Token = "0x4005A78")]
		public const short MeteoriteLantern = 3138;

		[global::Cpp2ILInjected.Token(Token = "0x4005A79")]
		public const short MarbleLantern = 3139;

		[global::Cpp2ILInjected.Token(Token = "0x4005A7A")]
		public const short GraniteLantern = 3140;

		[global::Cpp2ILInjected.Token(Token = "0x4005A7B")]
		public const short MeteoritePiano = 3141;

		[global::Cpp2ILInjected.Token(Token = "0x4005A7C")]
		public const short MarblePiano = 3142;

		[global::Cpp2ILInjected.Token(Token = "0x4005A7D")]
		public const short GranitePiano = 3143;

		[global::Cpp2ILInjected.Token(Token = "0x4005A7E")]
		public const short MeteoritePlatform = 3144;

		[global::Cpp2ILInjected.Token(Token = "0x4005A7F")]
		public const short MarblePlatform = 3145;

		[global::Cpp2ILInjected.Token(Token = "0x4005A80")]
		public const short GranitePlatform = 3146;

		[global::Cpp2ILInjected.Token(Token = "0x4005A81")]
		public const short MeteoriteSink = 3147;

		[global::Cpp2ILInjected.Token(Token = "0x4005A82")]
		public const short MarbleSink = 3148;

		[global::Cpp2ILInjected.Token(Token = "0x4005A83")]
		public const short GraniteSink = 3149;

		[global::Cpp2ILInjected.Token(Token = "0x4005A84")]
		public const short MeteoriteSofa = 3150;

		[global::Cpp2ILInjected.Token(Token = "0x4005A85")]
		public const short MarbleSofa = 3151;

		[global::Cpp2ILInjected.Token(Token = "0x4005A86")]
		public const short GraniteSofa = 3152;

		[global::Cpp2ILInjected.Token(Token = "0x4005A87")]
		public const short MeteoriteTable = 3153;

		[global::Cpp2ILInjected.Token(Token = "0x4005A88")]
		public const short MarbleTable = 3154;

		[global::Cpp2ILInjected.Token(Token = "0x4005A89")]
		public const short GraniteTable = 3155;

		[global::Cpp2ILInjected.Token(Token = "0x4005A8A")]
		public const short MeteoriteWorkBench = 3156;

		[global::Cpp2ILInjected.Token(Token = "0x4005A8B")]
		public const short MarbleWorkBench = 3157;

		[global::Cpp2ILInjected.Token(Token = "0x4005A8C")]
		public const short GraniteWorkBench = 3158;

		[global::Cpp2ILInjected.Token(Token = "0x4005A8D")]
		public const short MeteoriteBathtub = 3159;

		[global::Cpp2ILInjected.Token(Token = "0x4005A8E")]
		public const short MarbleBathtub = 3160;

		[global::Cpp2ILInjected.Token(Token = "0x4005A8F")]
		public const short GraniteBathtub = 3161;

		[global::Cpp2ILInjected.Token(Token = "0x4005A90")]
		public const short MeteoriteBed = 3162;

		[global::Cpp2ILInjected.Token(Token = "0x4005A91")]
		public const short MarbleBed = 3163;

		[global::Cpp2ILInjected.Token(Token = "0x4005A92")]
		public const short GraniteBed = 3164;

		[global::Cpp2ILInjected.Token(Token = "0x4005A93")]
		public const short MeteoriteBookcase = 3165;

		[global::Cpp2ILInjected.Token(Token = "0x4005A94")]
		public const short MarbleBookcase = 3166;

		[global::Cpp2ILInjected.Token(Token = "0x4005A95")]
		public const short GraniteBookcase = 3167;

		[global::Cpp2ILInjected.Token(Token = "0x4005A96")]
		public const short MeteoriteCandelabra = 3168;

		[global::Cpp2ILInjected.Token(Token = "0x4005A97")]
		public const short MarbleCandelabra = 3169;

		[global::Cpp2ILInjected.Token(Token = "0x4005A98")]
		public const short GraniteCandelabra = 3170;

		[global::Cpp2ILInjected.Token(Token = "0x4005A99")]
		public const short MeteoriteCandle = 3171;

		[global::Cpp2ILInjected.Token(Token = "0x4005A9A")]
		public const short MarbleCandle = 3172;

		[global::Cpp2ILInjected.Token(Token = "0x4005A9B")]
		public const short GraniteCandle = 3173;

		[global::Cpp2ILInjected.Token(Token = "0x4005A9C")]
		public const short MeteoriteChair = 3174;

		[global::Cpp2ILInjected.Token(Token = "0x4005A9D")]
		public const short MarbleChair = 3175;

		[global::Cpp2ILInjected.Token(Token = "0x4005A9E")]
		public const short GraniteChair = 3176;

		[global::Cpp2ILInjected.Token(Token = "0x4005A9F")]
		public const short MeteoriteChandelier = 3177;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA0")]
		public const short MarbleChandelier = 3178;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA1")]
		public const short GraniteChandelier = 3179;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA2")]
		public const short MeteoriteChest = 3180;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA3")]
		public const short MarbleChest = 3181;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA4")]
		public const short MagicWaterDropper = 3182;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA5")]
		public const short GoldenBugNet = 3183;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA6")]
		public const short MagicLavaDropper = 3184;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA7")]
		public const short MagicHoneyDropper = 3185;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA8")]
		public const short EmptyDropper = 3186;

		[global::Cpp2ILInjected.Token(Token = "0x4005AA9")]
		public const short GladiatorHelmet = 3187;

		[global::Cpp2ILInjected.Token(Token = "0x4005AAA")]
		public const short GladiatorBreastplate = 3188;

		[global::Cpp2ILInjected.Token(Token = "0x4005AAB")]
		public const short GladiatorLeggings = 3189;

		[global::Cpp2ILInjected.Token(Token = "0x4005AAC")]
		public const short ReflectiveDye = 3190;

		[global::Cpp2ILInjected.Token(Token = "0x4005AAD")]
		public const short EnchantedNightcrawler = 3191;

		[global::Cpp2ILInjected.Token(Token = "0x4005AAE")]
		public const short Grubby = 3192;

		[global::Cpp2ILInjected.Token(Token = "0x4005AAF")]
		public const short Sluggy = 3193;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB0")]
		public const short Buggy = 3194;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB1")]
		public const short GrubSoup = 3195;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB2")]
		public const short BombFish = 3196;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB3")]
		public const short FrostDaggerfish = 3197;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB4")]
		public const short SharpeningStation = 3198;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB5")]
		public const short IceMirror = 3199;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB6")]
		public const short SailfishBoots = 3200;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB7")]
		public const short TsunamiInABottle = 3201;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB8")]
		public const short TargetDummy = 3202;

		[global::Cpp2ILInjected.Token(Token = "0x4005AB9")]
		public const short CorruptFishingCrate = 3203;

		[global::Cpp2ILInjected.Token(Token = "0x4005ABA")]
		public const short CrimsonFishingCrate = 3204;

		[global::Cpp2ILInjected.Token(Token = "0x4005ABB")]
		public const short DungeonFishingCrate = 3205;

		[global::Cpp2ILInjected.Token(Token = "0x4005ABC")]
		public const short FloatingIslandFishingCrate = 3206;

		[global::Cpp2ILInjected.Token(Token = "0x4005ABD")]
		public const short HallowedFishingCrate = 3207;

		[global::Cpp2ILInjected.Token(Token = "0x4005ABE")]
		public const short JungleFishingCrate = 3208;

		[global::Cpp2ILInjected.Token(Token = "0x4005ABF")]
		public const short CrystalSerpent = 3209;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC0")]
		public const short Toxikarp = 3210;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC1")]
		public const short Bladetongue = 3211;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC2")]
		public const short SharkToothNecklace = 3212;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC3")]
		public const short MoneyTrough = 3213;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC4")]
		public const short Bubble = 3214;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC5")]
		public const short DayBloomPlanterBox = 3215;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC6")]
		public const short MoonglowPlanterBox = 3216;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC7")]
		public const short CorruptPlanterBox = 3217;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC8")]
		public const short CrimsonPlanterBox = 3218;

		[global::Cpp2ILInjected.Token(Token = "0x4005AC9")]
		public const short BlinkrootPlanterBox = 3219;

		[global::Cpp2ILInjected.Token(Token = "0x4005ACA")]
		public const short WaterleafPlanterBox = 3220;

		[global::Cpp2ILInjected.Token(Token = "0x4005ACB")]
		public const short ShiverthornPlanterBox = 3221;

		[global::Cpp2ILInjected.Token(Token = "0x4005ACC")]
		public const short FireBlossomPlanterBox = 3222;

		[global::Cpp2ILInjected.Token(Token = "0x4005ACD")]
		public const short BrainOfConfusion = 3223;

		[global::Cpp2ILInjected.Token(Token = "0x4005ACE")]
		public const short WormScarf = 3224;

		[global::Cpp2ILInjected.Token(Token = "0x4005ACF")]
		public const short BalloonPufferfish = 3225;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD0")]
		public const short BejeweledValkyrieHead = 3226;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD1")]
		public const short BejeweledValkyrieBody = 3227;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD2")]
		public const short BejeweledValkyrieWing = 3228;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD3")]
		public const short RichGravestone1 = 3229;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD4")]
		public const short RichGravestone2 = 3230;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD5")]
		public const short RichGravestone3 = 3231;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD6")]
		public const short RichGravestone4 = 3232;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD7")]
		public const short RichGravestone5 = 3233;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD8")]
		public const short CrystalBlock = 3234;

		[global::Cpp2ILInjected.Token(Token = "0x4005AD9")]
		public const short MusicBoxMartians = 3235;

		[global::Cpp2ILInjected.Token(Token = "0x4005ADA")]
		public const short MusicBoxPirates = 3236;

		[global::Cpp2ILInjected.Token(Token = "0x4005ADB")]
		public const short MusicBoxHell = 3237;

		[global::Cpp2ILInjected.Token(Token = "0x4005ADC")]
		public const short CrystalBlockWall = 3238;

		[global::Cpp2ILInjected.Token(Token = "0x4005ADD")]
		public const short Trapdoor = 3239;

		[global::Cpp2ILInjected.Token(Token = "0x4005ADE")]
		public const short TallGate = 3240;

		[global::Cpp2ILInjected.Token(Token = "0x4005ADF")]
		public const short SharkronBalloon = 3241;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE0")]
		public const short TaxCollectorHat = 3242;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE1")]
		public const short TaxCollectorSuit = 3243;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE2")]
		public const short TaxCollectorPants = 3244;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE3")]
		public const short BoneGlove = 3245;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE4")]
		public const short ClothierJacket = 3246;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE5")]
		public const short ClothierPants = 3247;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE6")]
		public const short DyeTraderTurban = 3248;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE7")]
		public const short DeadlySphereStaff = 3249;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE8")]
		public const short BalloonHorseshoeFart = 3250;

		[global::Cpp2ILInjected.Token(Token = "0x4005AE9")]
		public const short BalloonHorseshoeHoney = 3251;

		[global::Cpp2ILInjected.Token(Token = "0x4005AEA")]
		public const short BalloonHorseshoeSharkron = 3252;

		[global::Cpp2ILInjected.Token(Token = "0x4005AEB")]
		public const short LavaLamp = 3253;

		[global::Cpp2ILInjected.Token(Token = "0x4005AEC")]
		public const short CageEnchantedNightcrawler = 3254;

		[global::Cpp2ILInjected.Token(Token = "0x4005AED")]
		public const short CageBuggy = 3255;

		[global::Cpp2ILInjected.Token(Token = "0x4005AEE")]
		public const short CageGrubby = 3256;

		[global::Cpp2ILInjected.Token(Token = "0x4005AEF")]
		public const short CageSluggy = 3257;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF0")]
		public const short SlapHand = 3258;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF1")]
		public const short TwilightHairDye = 3259;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF2")]
		public const short BlessedApple = 3260;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF3")]
		public const short SpectreBar = 3261;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF4")]
		public const short Code1 = 3262;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF5")]
		public const short BuccaneerBandana = 3263;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF6")]
		public const short BuccaneerShirt = 3264;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF7")]
		public const short BuccaneerPants = 3265;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF8")]
		public const short ObsidianHelm = 3266;

		[global::Cpp2ILInjected.Token(Token = "0x4005AF9")]
		public const short ObsidianShirt = 3267;

		[global::Cpp2ILInjected.Token(Token = "0x4005AFA")]
		public const short ObsidianPants = 3268;

		[global::Cpp2ILInjected.Token(Token = "0x4005AFB")]
		public const short MedusaHead = 3269;

		[global::Cpp2ILInjected.Token(Token = "0x4005AFC")]
		public const short ItemFrame = 3270;

		[global::Cpp2ILInjected.Token(Token = "0x4005AFD")]
		public const short Sandstone = 3271;

		[global::Cpp2ILInjected.Token(Token = "0x4005AFE")]
		public const short HardenedSand = 3272;

		[global::Cpp2ILInjected.Token(Token = "0x4005AFF")]
		public const short SandstoneWall = 3273;

		[global::Cpp2ILInjected.Token(Token = "0x4005B00")]
		public const short CorruptHardenedSand = 3274;

		[global::Cpp2ILInjected.Token(Token = "0x4005B01")]
		public const short CrimsonHardenedSand = 3275;

		[global::Cpp2ILInjected.Token(Token = "0x4005B02")]
		public const short CorruptSandstone = 3276;

		[global::Cpp2ILInjected.Token(Token = "0x4005B03")]
		public const short CrimsonSandstone = 3277;

		[global::Cpp2ILInjected.Token(Token = "0x4005B04")]
		public const short WoodYoyo = 3278;

		[global::Cpp2ILInjected.Token(Token = "0x4005B05")]
		public const short CorruptYoyo = 3279;

		[global::Cpp2ILInjected.Token(Token = "0x4005B06")]
		public const short CrimsonYoyo = 3280;

		[global::Cpp2ILInjected.Token(Token = "0x4005B07")]
		public const short JungleYoyo = 3281;

		[global::Cpp2ILInjected.Token(Token = "0x4005B08")]
		public const short Cascade = 3282;

		[global::Cpp2ILInjected.Token(Token = "0x4005B09")]
		public const short Chik = 3283;

		[global::Cpp2ILInjected.Token(Token = "0x4005B0A")]
		public const short Code2 = 3284;

		[global::Cpp2ILInjected.Token(Token = "0x4005B0B")]
		public const short Rally = 3285;

		[global::Cpp2ILInjected.Token(Token = "0x4005B0C")]
		public const short Yelets = 3286;

		[global::Cpp2ILInjected.Token(Token = "0x4005B0D")]
		public const short RedsYoyo = 3287;

		[global::Cpp2ILInjected.Token(Token = "0x4005B0E")]
		public const short ValkyrieYoyo = 3288;

		[global::Cpp2ILInjected.Token(Token = "0x4005B0F")]
		public const short Amarok = 3289;

		[global::Cpp2ILInjected.Token(Token = "0x4005B10")]
		public const short HelFire = 3290;

		[global::Cpp2ILInjected.Token(Token = "0x4005B11")]
		public const short Kraken = 3291;

		[global::Cpp2ILInjected.Token(Token = "0x4005B12")]
		public const short TheEyeOfCthulhu = 3292;

		[global::Cpp2ILInjected.Token(Token = "0x4005B13")]
		public const short RedString = 3293;

		[global::Cpp2ILInjected.Token(Token = "0x4005B14")]
		public const short OrangeString = 3294;

		[global::Cpp2ILInjected.Token(Token = "0x4005B15")]
		public const short YellowString = 3295;

		[global::Cpp2ILInjected.Token(Token = "0x4005B16")]
		public const short LimeString = 3296;

		[global::Cpp2ILInjected.Token(Token = "0x4005B17")]
		public const short GreenString = 3297;

		[global::Cpp2ILInjected.Token(Token = "0x4005B18")]
		public const short TealString = 3298;

		[global::Cpp2ILInjected.Token(Token = "0x4005B19")]
		public const short CyanString = 3299;

		[global::Cpp2ILInjected.Token(Token = "0x4005B1A")]
		public const short SkyBlueString = 3300;

		[global::Cpp2ILInjected.Token(Token = "0x4005B1B")]
		public const short BlueString = 3301;

		[global::Cpp2ILInjected.Token(Token = "0x4005B1C")]
		public const short PurpleString = 3302;

		[global::Cpp2ILInjected.Token(Token = "0x4005B1D")]
		public const short VioletString = 3303;

		[global::Cpp2ILInjected.Token(Token = "0x4005B1E")]
		public const short PinkString = 3304;

		[global::Cpp2ILInjected.Token(Token = "0x4005B1F")]
		public const short BrownString = 3305;

		[global::Cpp2ILInjected.Token(Token = "0x4005B20")]
		public const short WhiteString = 3306;

		[global::Cpp2ILInjected.Token(Token = "0x4005B21")]
		public const short RainbowString = 3307;

		[global::Cpp2ILInjected.Token(Token = "0x4005B22")]
		public const short BlackString = 3308;

		[global::Cpp2ILInjected.Token(Token = "0x4005B23")]
		public const short BlackCounterweight = 3309;

		[global::Cpp2ILInjected.Token(Token = "0x4005B24")]
		public const short BlueCounterweight = 3310;

		[global::Cpp2ILInjected.Token(Token = "0x4005B25")]
		public const short GreenCounterweight = 3311;

		[global::Cpp2ILInjected.Token(Token = "0x4005B26")]
		public const short PurpleCounterweight = 3312;

		[global::Cpp2ILInjected.Token(Token = "0x4005B27")]
		public const short RedCounterweight = 3313;

		[global::Cpp2ILInjected.Token(Token = "0x4005B28")]
		public const short YellowCounterweight = 3314;

		[global::Cpp2ILInjected.Token(Token = "0x4005B29")]
		public const short FormatC = 3315;

		[global::Cpp2ILInjected.Token(Token = "0x4005B2A")]
		public const short Gradient = 3316;

		[global::Cpp2ILInjected.Token(Token = "0x4005B2B")]
		public const short Valor = 3317;

		[global::Cpp2ILInjected.Token(Token = "0x4005B2C")]
		public const short KingSlimeBossBag = 3318;

		[global::Cpp2ILInjected.Token(Token = "0x4005B2D")]
		public const short EyeOfCthulhuBossBag = 3319;

		[global::Cpp2ILInjected.Token(Token = "0x4005B2E")]
		public const short EaterOfWorldsBossBag = 3320;

		[global::Cpp2ILInjected.Token(Token = "0x4005B2F")]
		public const short BrainOfCthulhuBossBag = 3321;

		[global::Cpp2ILInjected.Token(Token = "0x4005B30")]
		public const short QueenBeeBossBag = 3322;

		[global::Cpp2ILInjected.Token(Token = "0x4005B31")]
		public const short SkeletronBossBag = 3323;

		[global::Cpp2ILInjected.Token(Token = "0x4005B32")]
		public const short WallOfFleshBossBag = 3324;

		[global::Cpp2ILInjected.Token(Token = "0x4005B33")]
		public const short DestroyerBossBag = 3325;

		[global::Cpp2ILInjected.Token(Token = "0x4005B34")]
		public const short TwinsBossBag = 3326;

		[global::Cpp2ILInjected.Token(Token = "0x4005B35")]
		public const short SkeletronPrimeBossBag = 3327;

		[global::Cpp2ILInjected.Token(Token = "0x4005B36")]
		public const short PlanteraBossBag = 3328;

		[global::Cpp2ILInjected.Token(Token = "0x4005B37")]
		public const short GolemBossBag = 3329;

		[global::Cpp2ILInjected.Token(Token = "0x4005B38")]
		public const short FishronBossBag = 3330;

		[global::Cpp2ILInjected.Token(Token = "0x4005B39")]
		public const short CultistBossBag = 3331;

		[global::Cpp2ILInjected.Token(Token = "0x4005B3A")]
		public const short MoonLordBossBag = 3332;

		[global::Cpp2ILInjected.Token(Token = "0x4005B3B")]
		public const short HiveBackpack = 3333;

		[global::Cpp2ILInjected.Token(Token = "0x4005B3C")]
		public const short YoYoGlove = 3334;

		[global::Cpp2ILInjected.Token(Token = "0x4005B3D")]
		public const short DemonHeart = 3335;

		[global::Cpp2ILInjected.Token(Token = "0x4005B3E")]
		public const short SporeSac = 3336;

		[global::Cpp2ILInjected.Token(Token = "0x4005B3F")]
		public const short ShinyStone = 3337;

		[global::Cpp2ILInjected.Token(Token = "0x4005B40")]
		public const short HallowHardenedSand = 3338;

		[global::Cpp2ILInjected.Token(Token = "0x4005B41")]
		public const short HallowSandstone = 3339;

		[global::Cpp2ILInjected.Token(Token = "0x4005B42")]
		public const short HardenedSandWall = 3340;

		[global::Cpp2ILInjected.Token(Token = "0x4005B43")]
		public const short CorruptHardenedSandWall = 3341;

		[global::Cpp2ILInjected.Token(Token = "0x4005B44")]
		public const short CrimsonHardenedSandWall = 3342;

		[global::Cpp2ILInjected.Token(Token = "0x4005B45")]
		public const short HallowHardenedSandWall = 3343;

		[global::Cpp2ILInjected.Token(Token = "0x4005B46")]
		public const short CorruptSandstoneWall = 3344;

		[global::Cpp2ILInjected.Token(Token = "0x4005B47")]
		public const short CrimsonSandstoneWall = 3345;

		[global::Cpp2ILInjected.Token(Token = "0x4005B48")]
		public const short HallowSandstoneWall = 3346;

		[global::Cpp2ILInjected.Token(Token = "0x4005B49")]
		public const short DesertFossil = 3347;

		[global::Cpp2ILInjected.Token(Token = "0x4005B4A")]
		public const short DesertFossilWall = 3348;

		[global::Cpp2ILInjected.Token(Token = "0x4005B4B")]
		public const short DyeTradersScimitar = 3349;

		[global::Cpp2ILInjected.Token(Token = "0x4005B4C")]
		public const short PainterPaintballGun = 3350;

		[global::Cpp2ILInjected.Token(Token = "0x4005B4D")]
		public const short TaxCollectorsStickOfDoom = 3351;

		[global::Cpp2ILInjected.Token(Token = "0x4005B4E")]
		public const short StylistKilLaKillScissorsIWish = 3352;

		[global::Cpp2ILInjected.Token(Token = "0x4005B4F")]
		public const short MinecartMech = 3353;

		[global::Cpp2ILInjected.Token(Token = "0x4005B50")]
		public const short MechanicalWheelPiece = 3354;

		[global::Cpp2ILInjected.Token(Token = "0x4005B51")]
		public const short MechanicalWagonPiece = 3355;

		[global::Cpp2ILInjected.Token(Token = "0x4005B52")]
		public const short MechanicalBatteryPiece = 3356;

		[global::Cpp2ILInjected.Token(Token = "0x4005B53")]
		public const short AncientCultistTrophy = 3357;

		[global::Cpp2ILInjected.Token(Token = "0x4005B54")]
		public const short MartianSaucerTrophy = 3358;

		[global::Cpp2ILInjected.Token(Token = "0x4005B55")]
		public const short FlyingDutchmanTrophy = 3359;

		[global::Cpp2ILInjected.Token(Token = "0x4005B56")]
		public const short LivingMahoganyWand = 3360;

		[global::Cpp2ILInjected.Token(Token = "0x4005B57")]
		public const short LivingMahoganyLeafWand = 3361;

		[global::Cpp2ILInjected.Token(Token = "0x4005B58")]
		public const short FallenTuxedoShirt = 3362;

		[global::Cpp2ILInjected.Token(Token = "0x4005B59")]
		public const short FallenTuxedoPants = 3363;

		[global::Cpp2ILInjected.Token(Token = "0x4005B5A")]
		public const short Fireplace = 3364;

		[global::Cpp2ILInjected.Token(Token = "0x4005B5B")]
		public const short Chimney = 3365;

		[global::Cpp2ILInjected.Token(Token = "0x4005B5C")]
		public const short YoyoBag = 3366;

		[global::Cpp2ILInjected.Token(Token = "0x4005B5D")]
		public const short ShrimpyTruffle = 3367;

		[global::Cpp2ILInjected.Token(Token = "0x4005B5E")]
		public const short Arkhalis = 3368;

		[global::Cpp2ILInjected.Token(Token = "0x4005B5F")]
		public const short ConfettiCannon = 3369;

		[global::Cpp2ILInjected.Token(Token = "0x4005B60")]
		public const short MusicBoxTowers = 3370;

		[global::Cpp2ILInjected.Token(Token = "0x4005B61")]
		public const short MusicBoxGoblins = 3371;

		[global::Cpp2ILInjected.Token(Token = "0x4005B62")]
		public const short BossMaskCultist = 3372;

		[global::Cpp2ILInjected.Token(Token = "0x4005B63")]
		public const short BossMaskMoonlord = 3373;

		[global::Cpp2ILInjected.Token(Token = "0x4005B64")]
		public const short FossilHelm = 3374;

		[global::Cpp2ILInjected.Token(Token = "0x4005B65")]
		public const short FossilShirt = 3375;

		[global::Cpp2ILInjected.Token(Token = "0x4005B66")]
		public const short FossilPants = 3376;

		[global::Cpp2ILInjected.Token(Token = "0x4005B67")]
		public const short AmberStaff = 3377;

		[global::Cpp2ILInjected.Token(Token = "0x4005B68")]
		public const short BoneJavelin = 3378;

		[global::Cpp2ILInjected.Token(Token = "0x4005B69")]
		public const short BoneDagger = 3379;

		[global::Cpp2ILInjected.Token(Token = "0x4005B6A")]
		public const short FossilOre = 3380;

		[global::Cpp2ILInjected.Token(Token = "0x4005B6B")]
		public const short StardustHelmet = 3381;

		[global::Cpp2ILInjected.Token(Token = "0x4005B6C")]
		public const short StardustBreastplate = 3382;

		[global::Cpp2ILInjected.Token(Token = "0x4005B6D")]
		public const short StardustLeggings = 3383;

		[global::Cpp2ILInjected.Token(Token = "0x4005B6E")]
		public const short PortalGun = 3384;

		[global::Cpp2ILInjected.Token(Token = "0x4005B6F")]
		public const short StrangePlant1 = 3385;

		[global::Cpp2ILInjected.Token(Token = "0x4005B70")]
		public const short StrangePlant2 = 3386;

		[global::Cpp2ILInjected.Token(Token = "0x4005B71")]
		public const short StrangePlant3 = 3387;

		[global::Cpp2ILInjected.Token(Token = "0x4005B72")]
		public const short StrangePlant4 = 3388;

		[global::Cpp2ILInjected.Token(Token = "0x4005B73")]
		public const short Terrarian = 3389;

		[global::Cpp2ILInjected.Token(Token = "0x4005B74")]
		public const short GoblinSummonerBanner = 3390;

		[global::Cpp2ILInjected.Token(Token = "0x4005B75")]
		public const short SalamanderBanner = 3391;

		[global::Cpp2ILInjected.Token(Token = "0x4005B76")]
		public const short GiantShellyBanner = 3392;

		[global::Cpp2ILInjected.Token(Token = "0x4005B77")]
		public const short CrawdadBanner = 3393;

		[global::Cpp2ILInjected.Token(Token = "0x4005B78")]
		public const short FritzBanner = 3394;

		[global::Cpp2ILInjected.Token(Token = "0x4005B79")]
		public const short CreatureFromTheDeepBanner = 3395;

		[global::Cpp2ILInjected.Token(Token = "0x4005B7A")]
		public const short DrManFlyBanner = 3396;

		[global::Cpp2ILInjected.Token(Token = "0x4005B7B")]
		public const short MothronBanner = 3397;

		[global::Cpp2ILInjected.Token(Token = "0x4005B7C")]
		public const short SeveredHandBanner = 3398;

		[global::Cpp2ILInjected.Token(Token = "0x4005B7D")]
		public const short ThePossessedBanner = 3399;

		[global::Cpp2ILInjected.Token(Token = "0x4005B7E")]
		public const short ButcherBanner = 3400;

		[global::Cpp2ILInjected.Token(Token = "0x4005B7F")]
		public const short PsychoBanner = 3401;

		[global::Cpp2ILInjected.Token(Token = "0x4005B80")]
		public const short DeadlySphereBanner = 3402;

		[global::Cpp2ILInjected.Token(Token = "0x4005B81")]
		public const short NailheadBanner = 3403;

		[global::Cpp2ILInjected.Token(Token = "0x4005B82")]
		public const short PoisonousSporeBanner = 3404;

		[global::Cpp2ILInjected.Token(Token = "0x4005B83")]
		public const short MedusaBanner = 3405;

		[global::Cpp2ILInjected.Token(Token = "0x4005B84")]
		public const short GreekSkeletonBanner = 3406;

		[global::Cpp2ILInjected.Token(Token = "0x4005B85")]
		public const short GraniteFlyerBanner = 3407;

		[global::Cpp2ILInjected.Token(Token = "0x4005B86")]
		public const short GraniteGolemBanner = 3408;

		[global::Cpp2ILInjected.Token(Token = "0x4005B87")]
		public const short BloodZombieBanner = 3409;

		[global::Cpp2ILInjected.Token(Token = "0x4005B88")]
		public const short DripplerBanner = 3410;

		[global::Cpp2ILInjected.Token(Token = "0x4005B89")]
		public const short TombCrawlerBanner = 3411;

		[global::Cpp2ILInjected.Token(Token = "0x4005B8A")]
		public const short DuneSplicerBanner = 3412;

		[global::Cpp2ILInjected.Token(Token = "0x4005B8B")]
		public const short FlyingAntlionBanner = 3413;

		[global::Cpp2ILInjected.Token(Token = "0x4005B8C")]
		public const short WalkingAntlionBanner = 3414;

		[global::Cpp2ILInjected.Token(Token = "0x4005B8D")]
		public const short DesertGhoulBanner = 3415;

		[global::Cpp2ILInjected.Token(Token = "0x4005B8E")]
		public const short DesertLamiaBanner = 3416;

		[global::Cpp2ILInjected.Token(Token = "0x4005B8F")]
		public const short DesertDjinnBanner = 3417;

		[global::Cpp2ILInjected.Token(Token = "0x4005B90")]
		public const short DesertBasiliskBanner = 3418;

		[global::Cpp2ILInjected.Token(Token = "0x4005B91")]
		public const short RavagerScorpionBanner = 3419;

		[global::Cpp2ILInjected.Token(Token = "0x4005B92")]
		public const short StardustSoldierBanner = 3420;

		[global::Cpp2ILInjected.Token(Token = "0x4005B93")]
		public const short StardustWormBanner = 3421;

		[global::Cpp2ILInjected.Token(Token = "0x4005B94")]
		public const short StardustJellyfishBanner = 3422;

		[global::Cpp2ILInjected.Token(Token = "0x4005B95")]
		public const short StardustSpiderBanner = 3423;

		[global::Cpp2ILInjected.Token(Token = "0x4005B96")]
		public const short StardustSmallCellBanner = 3424;

		[global::Cpp2ILInjected.Token(Token = "0x4005B97")]
		public const short StardustLargeCellBanner = 3425;

		[global::Cpp2ILInjected.Token(Token = "0x4005B98")]
		public const short SolarCoriteBanner = 3426;

		[global::Cpp2ILInjected.Token(Token = "0x4005B99")]
		public const short SolarSrollerBanner = 3427;

		[global::Cpp2ILInjected.Token(Token = "0x4005B9A")]
		public const short SolarCrawltipedeBanner = 3428;

		[global::Cpp2ILInjected.Token(Token = "0x4005B9B")]
		public const short SolarDrakomireRiderBanner = 3429;

		[global::Cpp2ILInjected.Token(Token = "0x4005B9C")]
		public const short SolarDrakomireBanner = 3430;

		[global::Cpp2ILInjected.Token(Token = "0x4005B9D")]
		public const short SolarSolenianBanner = 3431;

		[global::Cpp2ILInjected.Token(Token = "0x4005B9E")]
		public const short NebulaSoldierBanner = 3432;

		[global::Cpp2ILInjected.Token(Token = "0x4005B9F")]
		public const short NebulaHeadcrabBanner = 3433;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA0")]
		public const short NebulaBrainBanner = 3434;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA1")]
		public const short NebulaBeastBanner = 3435;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA2")]
		public const short VortexLarvaBanner = 3436;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA3")]
		public const short VortexHornetQueenBanner = 3437;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA4")]
		public const short VortexHornetBanner = 3438;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA5")]
		public const short VortexSoldierBanner = 3439;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA6")]
		public const short VortexRiflemanBanner = 3440;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA7")]
		public const short PirateCaptainBanner = 3441;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA8")]
		public const short PirateDeadeyeBanner = 3442;

		[global::Cpp2ILInjected.Token(Token = "0x4005BA9")]
		public const short PirateCorsairBanner = 3443;

		[global::Cpp2ILInjected.Token(Token = "0x4005BAA")]
		public const short PirateCrossbowerBanner = 3444;

		[global::Cpp2ILInjected.Token(Token = "0x4005BAB")]
		public const short MartianWalkerBanner = 3445;

		[global::Cpp2ILInjected.Token(Token = "0x4005BAC")]
		public const short RedDevilBanner = 3446;

		[global::Cpp2ILInjected.Token(Token = "0x4005BAD")]
		public const short PinkJellyfishBanner = 3447;

		[global::Cpp2ILInjected.Token(Token = "0x4005BAE")]
		public const short GreenJellyfishBanner = 3448;

		[global::Cpp2ILInjected.Token(Token = "0x4005BAF")]
		public const short DarkMummyBanner = 3449;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB0")]
		public const short LightMummyBanner = 3450;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB1")]
		public const short AngryBonesBanner = 3451;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB2")]
		public const short IceTortoiseBanner = 3452;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB3")]
		public const short NebulaPickup1 = 3453;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB4")]
		public const short NebulaPickup2 = 3454;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB5")]
		public const short NebulaPickup3 = 3455;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB6")]
		public const short FragmentVortex = 3456;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB7")]
		public const short FragmentNebula = 3457;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB8")]
		public const short FragmentSolar = 3458;

		[global::Cpp2ILInjected.Token(Token = "0x4005BB9")]
		public const short FragmentStardust = 3459;

		[global::Cpp2ILInjected.Token(Token = "0x4005BBA")]
		public const short LunarOre = 3460;

		[global::Cpp2ILInjected.Token(Token = "0x4005BBB")]
		public const short LunarBrick = 3461;

		[global::Cpp2ILInjected.Token(Token = "0x4005BBC")]
		public const short StardustAxe = 3462;

		[global::Cpp2ILInjected.Token(Token = "0x4005BBD")]
		public const short StardustChainsaw = 3463;

		[global::Cpp2ILInjected.Token(Token = "0x4005BBE")]
		public const short StardustDrill = 3464;

		[global::Cpp2ILInjected.Token(Token = "0x4005BBF")]
		public const short StardustHammer = 3465;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC0")]
		public const short StardustPickaxe = 3466;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC1")]
		public const short LunarBar = 3467;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC2")]
		public const short WingsSolar = 3468;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC3")]
		public const short WingsVortex = 3469;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC4")]
		public const short WingsNebula = 3470;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC5")]
		public const short WingsStardust = 3471;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC6")]
		public const short LunarBrickWall = 3472;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC7")]
		public const short SolarEruption = 3473;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC8")]
		public const short StardustCellStaff = 3474;

		[global::Cpp2ILInjected.Token(Token = "0x4005BC9")]
		public const short VortexBeater = 3475;

		[global::Cpp2ILInjected.Token(Token = "0x4005BCA")]
		public const short NebulaArcanum = 3476;

		[global::Cpp2ILInjected.Token(Token = "0x4005BCB")]
		public const short BloodWater = 3477;

		[global::Cpp2ILInjected.Token(Token = "0x4005BCC")]
		public const short TheBrideHat = 3478;

		[global::Cpp2ILInjected.Token(Token = "0x4005BCD")]
		public const short TheBrideDress = 3479;

		[global::Cpp2ILInjected.Token(Token = "0x4005BCE")]
		public const short PlatinumBow = 3480;

		[global::Cpp2ILInjected.Token(Token = "0x4005BCF")]
		public const short PlatinumHammer = 3481;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD0")]
		public const short PlatinumAxe = 3482;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD1")]
		public const short PlatinumShortsword = 3483;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD2")]
		public const short PlatinumBroadsword = 3484;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD3")]
		public const short PlatinumPickaxe = 3485;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD4")]
		public const short TungstenBow = 3486;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD5")]
		public const short TungstenHammer = 3487;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD6")]
		public const short TungstenAxe = 3488;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD7")]
		public const short TungstenShortsword = 3489;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD8")]
		public const short TungstenBroadsword = 3490;

		[global::Cpp2ILInjected.Token(Token = "0x4005BD9")]
		public const short TungstenPickaxe = 3491;

		[global::Cpp2ILInjected.Token(Token = "0x4005BDA")]
		public const short LeadBow = 3492;

		[global::Cpp2ILInjected.Token(Token = "0x4005BDB")]
		public const short LeadHammer = 3493;

		[global::Cpp2ILInjected.Token(Token = "0x4005BDC")]
		public const short LeadAxe = 3494;

		[global::Cpp2ILInjected.Token(Token = "0x4005BDD")]
		public const short LeadShortsword = 3495;

		[global::Cpp2ILInjected.Token(Token = "0x4005BDE")]
		public const short LeadBroadsword = 3496;

		[global::Cpp2ILInjected.Token(Token = "0x4005BDF")]
		public const short LeadPickaxe = 3497;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE0")]
		public const short TinBow = 3498;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE1")]
		public const short TinHammer = 3499;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE2")]
		public const short TinAxe = 3500;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE3")]
		public const short TinShortsword = 3501;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE4")]
		public const short TinBroadsword = 3502;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE5")]
		public const short TinPickaxe = 3503;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE6")]
		public const short CopperBow = 3504;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE7")]
		public const short CopperHammer = 3505;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE8")]
		public const short CopperAxe = 3506;

		[global::Cpp2ILInjected.Token(Token = "0x4005BE9")]
		public const short CopperShortsword = 3507;

		[global::Cpp2ILInjected.Token(Token = "0x4005BEA")]
		public const short CopperBroadsword = 3508;

		[global::Cpp2ILInjected.Token(Token = "0x4005BEB")]
		public const short CopperPickaxe = 3509;

		[global::Cpp2ILInjected.Token(Token = "0x4005BEC")]
		public const short SilverBow = 3510;

		[global::Cpp2ILInjected.Token(Token = "0x4005BED")]
		public const short SilverHammer = 3511;

		[global::Cpp2ILInjected.Token(Token = "0x4005BEE")]
		public const short SilverAxe = 3512;

		[global::Cpp2ILInjected.Token(Token = "0x4005BEF")]
		public const short SilverShortsword = 3513;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF0")]
		public const short SilverBroadsword = 3514;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF1")]
		public const short SilverPickaxe = 3515;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF2")]
		public const short GoldBow = 3516;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF3")]
		public const short GoldHammer = 3517;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF4")]
		public const short GoldAxe = 3518;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF5")]
		public const short GoldShortsword = 3519;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF6")]
		public const short GoldBroadsword = 3520;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF7")]
		public const short GoldPickaxe = 3521;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF8")]
		public const short LunarHamaxeSolar = 3522;

		[global::Cpp2ILInjected.Token(Token = "0x4005BF9")]
		public const short LunarHamaxeVortex = 3523;

		[global::Cpp2ILInjected.Token(Token = "0x4005BFA")]
		public const short LunarHamaxeNebula = 3524;

		[global::Cpp2ILInjected.Token(Token = "0x4005BFB")]
		public const short LunarHamaxeStardust = 3525;

		[global::Cpp2ILInjected.Token(Token = "0x4005BFC")]
		public const short SolarDye = 3526;

		[global::Cpp2ILInjected.Token(Token = "0x4005BFD")]
		public const short NebulaDye = 3527;

		[global::Cpp2ILInjected.Token(Token = "0x4005BFE")]
		public const short VortexDye = 3528;

		[global::Cpp2ILInjected.Token(Token = "0x4005BFF")]
		public const short StardustDye = 3529;

		[global::Cpp2ILInjected.Token(Token = "0x4005C00")]
		public const short VoidDye = 3530;

		[global::Cpp2ILInjected.Token(Token = "0x4005C01")]
		public const short StardustDragonStaff = 3531;

		[global::Cpp2ILInjected.Token(Token = "0x4005C02")]
		public const short Bacon = 3532;

		[global::Cpp2ILInjected.Token(Token = "0x4005C03")]
		public const short ShiftingSandsDye = 3533;

		[global::Cpp2ILInjected.Token(Token = "0x4005C04")]
		public const short MirageDye = 3534;

		[global::Cpp2ILInjected.Token(Token = "0x4005C05")]
		public const short ShiftingPearlSandsDye = 3535;

		[global::Cpp2ILInjected.Token(Token = "0x4005C06")]
		public const short VortexMonolith = 3536;

		[global::Cpp2ILInjected.Token(Token = "0x4005C07")]
		public const short NebulaMonolith = 3537;

		[global::Cpp2ILInjected.Token(Token = "0x4005C08")]
		public const short StardustMonolith = 3538;

		[global::Cpp2ILInjected.Token(Token = "0x4005C09")]
		public const short SolarMonolith = 3539;

		[global::Cpp2ILInjected.Token(Token = "0x4005C0A")]
		public const short Phantasm = 3540;

		[global::Cpp2ILInjected.Token(Token = "0x4005C0B")]
		public const short LastPrism = 3541;

		[global::Cpp2ILInjected.Token(Token = "0x4005C0C")]
		public const short NebulaBlaze = 3542;

		[global::Cpp2ILInjected.Token(Token = "0x4005C0D")]
		public const short DayBreak = 3543;

		[global::Cpp2ILInjected.Token(Token = "0x4005C0E")]
		public const short SuperHealingPotion = 3544;

		[global::Cpp2ILInjected.Token(Token = "0x4005C0F")]
		public const short Detonator = 3545;

		[global::Cpp2ILInjected.Token(Token = "0x4005C10")]
		public const short FireworksLauncher = 3546;

		[global::Cpp2ILInjected.Token(Token = "0x4005C11")]
		public const short BouncyDynamite = 3547;

		[global::Cpp2ILInjected.Token(Token = "0x4005C12")]
		public const short PartyGirlGrenade = 3548;

		[global::Cpp2ILInjected.Token(Token = "0x4005C13")]
		public const short LunarCraftingStation = 3549;

		[global::Cpp2ILInjected.Token(Token = "0x4005C14")]
		public const short FlameAndSilverDye = 3550;

		[global::Cpp2ILInjected.Token(Token = "0x4005C15")]
		public const short GreenFlameAndSilverDye = 3551;

		[global::Cpp2ILInjected.Token(Token = "0x4005C16")]
		public const short BlueFlameAndSilverDye = 3552;

		[global::Cpp2ILInjected.Token(Token = "0x4005C17")]
		public const short ReflectiveCopperDye = 3553;

		[global::Cpp2ILInjected.Token(Token = "0x4005C18")]
		public const short ReflectiveObsidianDye = 3554;

		[global::Cpp2ILInjected.Token(Token = "0x4005C19")]
		public const short ReflectiveMetalDye = 3555;

		[global::Cpp2ILInjected.Token(Token = "0x4005C1A")]
		public const short MidnightRainbowDye = 3556;

		[global::Cpp2ILInjected.Token(Token = "0x4005C1B")]
		public const short BlackAndWhiteDye = 3557;

		[global::Cpp2ILInjected.Token(Token = "0x4005C1C")]
		public const short BrightSilverDye = 3558;

		[global::Cpp2ILInjected.Token(Token = "0x4005C1D")]
		public const short SilverAndBlackDye = 3559;

		[global::Cpp2ILInjected.Token(Token = "0x4005C1E")]
		public const short RedAcidDye = 3560;

		[global::Cpp2ILInjected.Token(Token = "0x4005C1F")]
		public const short GelDye = 3561;

		[global::Cpp2ILInjected.Token(Token = "0x4005C20")]
		public const short PinkGelDye = 3562;

		[global::Cpp2ILInjected.Token(Token = "0x4005C21")]
		public const short SquirrelRed = 3563;

		[global::Cpp2ILInjected.Token(Token = "0x4005C22")]
		public const short SquirrelGold = 3564;

		[global::Cpp2ILInjected.Token(Token = "0x4005C23")]
		public const short SquirrelOrangeCage = 3565;

		[global::Cpp2ILInjected.Token(Token = "0x4005C24")]
		public const short SquirrelGoldCage = 3566;

		[global::Cpp2ILInjected.Token(Token = "0x4005C25")]
		public const short MoonlordBullet = 3567;

		[global::Cpp2ILInjected.Token(Token = "0x4005C26")]
		public const short MoonlordArrow = 3568;

		[global::Cpp2ILInjected.Token(Token = "0x4005C27")]
		public const short MoonlordTurretStaff = 3569;

		[global::Cpp2ILInjected.Token(Token = "0x4005C28")]
		public const short LunarFlareBook = 3570;

		[global::Cpp2ILInjected.Token(Token = "0x4005C29")]
		public const short RainbowCrystalStaff = 3571;

		[global::Cpp2ILInjected.Token(Token = "0x4005C2A")]
		public const short LunarHook = 3572;

		[global::Cpp2ILInjected.Token(Token = "0x4005C2B")]
		public const short LunarBlockSolar = 3573;

		[global::Cpp2ILInjected.Token(Token = "0x4005C2C")]
		public const short LunarBlockVortex = 3574;

		[global::Cpp2ILInjected.Token(Token = "0x4005C2D")]
		public const short LunarBlockNebula = 3575;

		[global::Cpp2ILInjected.Token(Token = "0x4005C2E")]
		public const short LunarBlockStardust = 3576;

		[global::Cpp2ILInjected.Token(Token = "0x4005C2F")]
		public const short SuspiciousLookingTentacle = 3577;

		[global::Cpp2ILInjected.Token(Token = "0x4005C30")]
		public const short Yoraiz0rShirt = 3578;

		[global::Cpp2ILInjected.Token(Token = "0x4005C31")]
		public const short Yoraiz0rPants = 3579;

		[global::Cpp2ILInjected.Token(Token = "0x4005C32")]
		public const short Yoraiz0rWings = 3580;

		[global::Cpp2ILInjected.Token(Token = "0x4005C33")]
		public const short Yoraiz0rDarkness = 3581;

		[global::Cpp2ILInjected.Token(Token = "0x4005C34")]
		public const short JimsWings = 3582;

		[global::Cpp2ILInjected.Token(Token = "0x4005C35")]
		public const short Yoraiz0rHead = 3583;

		[global::Cpp2ILInjected.Token(Token = "0x4005C36")]
		public const short LivingLeafWall = 3584;

		[global::Cpp2ILInjected.Token(Token = "0x4005C37")]
		public const short SkiphsHelm = 3585;

		[global::Cpp2ILInjected.Token(Token = "0x4005C38")]
		public const short SkiphsShirt = 3586;

		[global::Cpp2ILInjected.Token(Token = "0x4005C39")]
		public const short SkiphsPants = 3587;

		[global::Cpp2ILInjected.Token(Token = "0x4005C3A")]
		public const short SkiphsWings = 3588;

		[global::Cpp2ILInjected.Token(Token = "0x4005C3B")]
		public const short LokisHelm = 3589;

		[global::Cpp2ILInjected.Token(Token = "0x4005C3C")]
		public const short LokisShirt = 3590;

		[global::Cpp2ILInjected.Token(Token = "0x4005C3D")]
		public const short LokisPants = 3591;

		[global::Cpp2ILInjected.Token(Token = "0x4005C3E")]
		public const short LokisWings = 3592;

		[global::Cpp2ILInjected.Token(Token = "0x4005C3F")]
		public const short SandSlimeBanner = 3593;

		[global::Cpp2ILInjected.Token(Token = "0x4005C40")]
		public const short SeaSnailBanner = 3594;

		[global::Cpp2ILInjected.Token(Token = "0x4005C41")]
		public const short MoonLordTrophy = 3595;

		[global::Cpp2ILInjected.Token(Token = "0x4005C42")]
		public const short MoonLordPainting = 3596;

		[global::Cpp2ILInjected.Token(Token = "0x4005C43")]
		public const short BurningHadesDye = 3597;

		[global::Cpp2ILInjected.Token(Token = "0x4005C44")]
		public const short GrimDye = 3598;

		[global::Cpp2ILInjected.Token(Token = "0x4005C45")]
		public const short LokisDye = 3599;

		[global::Cpp2ILInjected.Token(Token = "0x4005C46")]
		public const short ShadowflameHadesDye = 3600;

		[global::Cpp2ILInjected.Token(Token = "0x4005C47")]
		public const short CelestialSigil = 3601;

		[global::Cpp2ILInjected.Token(Token = "0x4005C48")]
		public const short LogicGateLamp_Off = 3602;

		[global::Cpp2ILInjected.Token(Token = "0x4005C49")]
		public const short LogicGate_AND = 3603;

		[global::Cpp2ILInjected.Token(Token = "0x4005C4A")]
		public const short LogicGate_OR = 3604;

		[global::Cpp2ILInjected.Token(Token = "0x4005C4B")]
		public const short LogicGate_NAND = 3605;

		[global::Cpp2ILInjected.Token(Token = "0x4005C4C")]
		public const short LogicGate_NOR = 3606;

		[global::Cpp2ILInjected.Token(Token = "0x4005C4D")]
		public const short LogicGate_XOR = 3607;

		[global::Cpp2ILInjected.Token(Token = "0x4005C4E")]
		public const short LogicGate_NXOR = 3608;

		[global::Cpp2ILInjected.Token(Token = "0x4005C4F")]
		public const short ConveyorBeltLeft = 3609;

		[global::Cpp2ILInjected.Token(Token = "0x4005C50")]
		public const short ConveyorBeltRight = 3610;

		[global::Cpp2ILInjected.Token(Token = "0x4005C51")]
		public const short WireKite = 3611;

		[global::Cpp2ILInjected.Token(Token = "0x4005C52")]
		public const short YellowWrench = 3612;

		[global::Cpp2ILInjected.Token(Token = "0x4005C53")]
		public const short LogicSensor_Sun = 3613;

		[global::Cpp2ILInjected.Token(Token = "0x4005C54")]
		public const short LogicSensor_Moon = 3614;

		[global::Cpp2ILInjected.Token(Token = "0x4005C55")]
		public const short LogicSensor_Above = 3615;

		[global::Cpp2ILInjected.Token(Token = "0x4005C56")]
		public const short WirePipe = 3616;

		[global::Cpp2ILInjected.Token(Token = "0x4005C57")]
		public const short AnnouncementBox = 3617;

		[global::Cpp2ILInjected.Token(Token = "0x4005C58")]
		public const short LogicGateLamp_On = 3618;

		[global::Cpp2ILInjected.Token(Token = "0x4005C59")]
		public const short MechanicalLens = 3619;

		[global::Cpp2ILInjected.Token(Token = "0x4005C5A")]
		public const short ActuationRod = 3620;

		[global::Cpp2ILInjected.Token(Token = "0x4005C5B")]
		public const short TeamBlockRed = 3621;

		[global::Cpp2ILInjected.Token(Token = "0x4005C5C")]
		public const short TeamBlockRedPlatform = 3622;

		[global::Cpp2ILInjected.Token(Token = "0x4005C5D")]
		public const short StaticHook = 3623;

		[global::Cpp2ILInjected.Token(Token = "0x4005C5E")]
		public const short ActuationAccessory = 3624;

		[global::Cpp2ILInjected.Token(Token = "0x4005C5F")]
		public const short MulticolorWrench = 3625;

		[global::Cpp2ILInjected.Token(Token = "0x4005C60")]
		public const short WeightedPressurePlatePink = 3626;

		[global::Cpp2ILInjected.Token(Token = "0x4005C61")]
		public const short EngineeringHelmet = 3627;

		[global::Cpp2ILInjected.Token(Token = "0x4005C62")]
		public const short CompanionCube = 3628;

		[global::Cpp2ILInjected.Token(Token = "0x4005C63")]
		public const short WireBulb = 3629;

		[global::Cpp2ILInjected.Token(Token = "0x4005C64")]
		public const short WeightedPressurePlateOrange = 3630;

		[global::Cpp2ILInjected.Token(Token = "0x4005C65")]
		public const short WeightedPressurePlatePurple = 3631;

		[global::Cpp2ILInjected.Token(Token = "0x4005C66")]
		public const short WeightedPressurePlateCyan = 3632;

		[global::Cpp2ILInjected.Token(Token = "0x4005C67")]
		public const short TeamBlockGreen = 3633;

		[global::Cpp2ILInjected.Token(Token = "0x4005C68")]
		public const short TeamBlockBlue = 3634;

		[global::Cpp2ILInjected.Token(Token = "0x4005C69")]
		public const short TeamBlockYellow = 3635;

		[global::Cpp2ILInjected.Token(Token = "0x4005C6A")]
		public const short TeamBlockPink = 3636;

		[global::Cpp2ILInjected.Token(Token = "0x4005C6B")]
		public const short TeamBlockWhite = 3637;

		[global::Cpp2ILInjected.Token(Token = "0x4005C6C")]
		public const short TeamBlockGreenPlatform = 3638;

		[global::Cpp2ILInjected.Token(Token = "0x4005C6D")]
		public const short TeamBlockBluePlatform = 3639;

		[global::Cpp2ILInjected.Token(Token = "0x4005C6E")]
		public const short TeamBlockYellowPlatform = 3640;

		[global::Cpp2ILInjected.Token(Token = "0x4005C6F")]
		public const short TeamBlockPinkPlatform = 3641;

		[global::Cpp2ILInjected.Token(Token = "0x4005C70")]
		public const short TeamBlockWhitePlatform = 3642;

		[global::Cpp2ILInjected.Token(Token = "0x4005C71")]
		public const short LargeAmber = 3643;

		[global::Cpp2ILInjected.Token(Token = "0x4005C72")]
		public const short GemLockRuby = 3644;

		[global::Cpp2ILInjected.Token(Token = "0x4005C73")]
		public const short GemLockSapphire = 3645;

		[global::Cpp2ILInjected.Token(Token = "0x4005C74")]
		public const short GemLockEmerald = 3646;

		[global::Cpp2ILInjected.Token(Token = "0x4005C75")]
		public const short GemLockTopaz = 3647;

		[global::Cpp2ILInjected.Token(Token = "0x4005C76")]
		public const short GemLockAmethyst = 3648;

		[global::Cpp2ILInjected.Token(Token = "0x4005C77")]
		public const short GemLockDiamond = 3649;

		[global::Cpp2ILInjected.Token(Token = "0x4005C78")]
		public const short GemLockAmber = 3650;

		[global::Cpp2ILInjected.Token(Token = "0x4005C79")]
		public const short SquirrelStatue = 3651;

		[global::Cpp2ILInjected.Token(Token = "0x4005C7A")]
		public const short ButterflyStatue = 3652;

		[global::Cpp2ILInjected.Token(Token = "0x4005C7B")]
		public const short WormStatue = 3653;

		[global::Cpp2ILInjected.Token(Token = "0x4005C7C")]
		public const short FireflyStatue = 3654;

		[global::Cpp2ILInjected.Token(Token = "0x4005C7D")]
		public const short ScorpionStatue = 3655;

		[global::Cpp2ILInjected.Token(Token = "0x4005C7E")]
		public const short SnailStatue = 3656;

		[global::Cpp2ILInjected.Token(Token = "0x4005C7F")]
		public const short GrasshopperStatue = 3657;

		[global::Cpp2ILInjected.Token(Token = "0x4005C80")]
		public const short MouseStatue = 3658;

		[global::Cpp2ILInjected.Token(Token = "0x4005C81")]
		public const short DuckStatue = 3659;

		[global::Cpp2ILInjected.Token(Token = "0x4005C82")]
		public const short PenguinStatue = 3660;

		[global::Cpp2ILInjected.Token(Token = "0x4005C83")]
		public const short FrogStatue = 3661;

		[global::Cpp2ILInjected.Token(Token = "0x4005C84")]
		public const short BuggyStatue = 3662;

		[global::Cpp2ILInjected.Token(Token = "0x4005C85")]
		public const short LogicGateLamp_Faulty = 3663;

		[global::Cpp2ILInjected.Token(Token = "0x4005C86")]
		public const short PortalGunStation = 3664;

		[global::Cpp2ILInjected.Token(Token = "0x4005C87")]
		public const short Fake_Chest = 3665;

		[global::Cpp2ILInjected.Token(Token = "0x4005C88")]
		public const short Fake_GoldChest = 3666;

		[global::Cpp2ILInjected.Token(Token = "0x4005C89")]
		public const short Fake_ShadowChest = 3667;

		[global::Cpp2ILInjected.Token(Token = "0x4005C8A")]
		public const short Fake_EbonwoodChest = 3668;

		[global::Cpp2ILInjected.Token(Token = "0x4005C8B")]
		public const short Fake_RichMahoganyChest = 3669;

		[global::Cpp2ILInjected.Token(Token = "0x4005C8C")]
		public const short Fake_PearlwoodChest = 3670;

		[global::Cpp2ILInjected.Token(Token = "0x4005C8D")]
		public const short Fake_IvyChest = 3671;

		[global::Cpp2ILInjected.Token(Token = "0x4005C8E")]
		public const short Fake_IceChest = 3672;

		[global::Cpp2ILInjected.Token(Token = "0x4005C8F")]
		public const short Fake_LivingWoodChest = 3673;

		[global::Cpp2ILInjected.Token(Token = "0x4005C90")]
		public const short Fake_SkywareChest = 3674;

		[global::Cpp2ILInjected.Token(Token = "0x4005C91")]
		public const short Fake_ShadewoodChest = 3675;

		[global::Cpp2ILInjected.Token(Token = "0x4005C92")]
		public const short Fake_WebCoveredChest = 3676;

		[global::Cpp2ILInjected.Token(Token = "0x4005C93")]
		public const short Fake_LihzahrdChest = 3677;

		[global::Cpp2ILInjected.Token(Token = "0x4005C94")]
		public const short Fake_WaterChest = 3678;

		[global::Cpp2ILInjected.Token(Token = "0x4005C95")]
		public const short Fake_JungleChest = 3679;

		[global::Cpp2ILInjected.Token(Token = "0x4005C96")]
		public const short Fake_CorruptionChest = 3680;

		[global::Cpp2ILInjected.Token(Token = "0x4005C97")]
		public const short Fake_CrimsonChest = 3681;

		[global::Cpp2ILInjected.Token(Token = "0x4005C98")]
		public const short Fake_HallowedChest = 3682;

		[global::Cpp2ILInjected.Token(Token = "0x4005C99")]
		public const short Fake_FrozenChest = 3683;

		[global::Cpp2ILInjected.Token(Token = "0x4005C9A")]
		public const short Fake_DynastyChest = 3684;

		[global::Cpp2ILInjected.Token(Token = "0x4005C9B")]
		public const short Fake_HoneyChest = 3685;

		[global::Cpp2ILInjected.Token(Token = "0x4005C9C")]
		public const short Fake_SteampunkChest = 3686;

		[global::Cpp2ILInjected.Token(Token = "0x4005C9D")]
		public const short Fake_PalmWoodChest = 3687;

		[global::Cpp2ILInjected.Token(Token = "0x4005C9E")]
		public const short Fake_MushroomChest = 3688;

		[global::Cpp2ILInjected.Token(Token = "0x4005C9F")]
		public const short Fake_BorealWoodChest = 3689;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA0")]
		public const short Fake_SlimeChest = 3690;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA1")]
		public const short Fake_GreenDungeonChest = 3691;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA2")]
		public const short Fake_PinkDungeonChest = 3692;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA3")]
		public const short Fake_BlueDungeonChest = 3693;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA4")]
		public const short Fake_BoneChest = 3694;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA5")]
		public const short Fake_CactusChest = 3695;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA6")]
		public const short Fake_FleshChest = 3696;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA7")]
		public const short Fake_ObsidianChest = 3697;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA8")]
		public const short Fake_PumpkinChest = 3698;

		[global::Cpp2ILInjected.Token(Token = "0x4005CA9")]
		public const short Fake_SpookyChest = 3699;

		[global::Cpp2ILInjected.Token(Token = "0x4005CAA")]
		public const short Fake_GlassChest = 3700;

		[global::Cpp2ILInjected.Token(Token = "0x4005CAB")]
		public const short Fake_MartianChest = 3701;

		[global::Cpp2ILInjected.Token(Token = "0x4005CAC")]
		public const short Fake_MeteoriteChest = 3702;

		[global::Cpp2ILInjected.Token(Token = "0x4005CAD")]
		public const short Fake_GraniteChest = 3703;

		[global::Cpp2ILInjected.Token(Token = "0x4005CAE")]
		public const short Fake_MarbleChest = 3704;

		[global::Cpp2ILInjected.Token(Token = "0x4005CAF")]
		public const short Fake_newchest1 = 3705;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB0")]
		public const short Fake_newchest2 = 3706;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB1")]
		public const short ProjectilePressurePad = 3707;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB2")]
		public const short WallCreeperStatue = 3708;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB3")]
		public const short UnicornStatue = 3709;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB4")]
		public const short DripplerStatue = 3710;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB5")]
		public const short WraithStatue = 3711;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB6")]
		public const short BoneSkeletonStatue = 3712;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB7")]
		public const short UndeadVikingStatue = 3713;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB8")]
		public const short MedusaStatue = 3714;

		[global::Cpp2ILInjected.Token(Token = "0x4005CB9")]
		public const short HarpyStatue = 3715;

		[global::Cpp2ILInjected.Token(Token = "0x4005CBA")]
		public const short PigronStatue = 3716;

		[global::Cpp2ILInjected.Token(Token = "0x4005CBB")]
		public const short HopliteStatue = 3717;

		[global::Cpp2ILInjected.Token(Token = "0x4005CBC")]
		public const short GraniteGolemStatue = 3718;

		[global::Cpp2ILInjected.Token(Token = "0x4005CBD")]
		public const short ZombieArmStatue = 3719;

		[global::Cpp2ILInjected.Token(Token = "0x4005CBE")]
		public const short BloodZombieStatue = 3720;

		[global::Cpp2ILInjected.Token(Token = "0x4005CBF")]
		public const short AnglerTackleBag = 3721;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC0")]
		public const short GeyserTrap = 3722;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC1")]
		public const short UltraBrightCampfire = 3723;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC2")]
		public const short BoneCampfire = 3724;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC3")]
		public const short PixelBox = 3725;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC4")]
		public const short LogicSensor_Water = 3726;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC5")]
		public const short LogicSensor_Lava = 3727;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC6")]
		public const short LogicSensor_Honey = 3728;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC7")]
		public const short LogicSensor_Liquid = 3729;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC8")]
		public const short PartyBundleOfBalloonsAccessory = 3730;

		[global::Cpp2ILInjected.Token(Token = "0x4005CC9")]
		public const short PartyBalloonAnimal = 3731;

		[global::Cpp2ILInjected.Token(Token = "0x4005CCA")]
		public const short PartyHat = 3732;

		[global::Cpp2ILInjected.Token(Token = "0x4005CCB")]
		public const short FlowerBoyHat = 3733;

		[global::Cpp2ILInjected.Token(Token = "0x4005CCC")]
		public const short FlowerBoyShirt = 3734;

		[global::Cpp2ILInjected.Token(Token = "0x4005CCD")]
		public const short FlowerBoyPants = 3735;

		[global::Cpp2ILInjected.Token(Token = "0x4005CCE")]
		public const short SillyBalloonPink = 3736;

		[global::Cpp2ILInjected.Token(Token = "0x4005CCF")]
		public const short SillyBalloonPurple = 3737;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD0")]
		public const short SillyBalloonGreen = 3738;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD1")]
		public const short SillyStreamerBlue = 3739;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD2")]
		public const short SillyStreamerGreen = 3740;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD3")]
		public const short SillyStreamerPink = 3741;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD4")]
		public const short SillyBalloonMachine = 3742;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD5")]
		public const short SillyBalloonTiedPink = 3743;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD6")]
		public const short SillyBalloonTiedPurple = 3744;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD7")]
		public const short SillyBalloonTiedGreen = 3745;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD8")]
		public const short Pigronata = 3746;

		[global::Cpp2ILInjected.Token(Token = "0x4005CD9")]
		public const short PartyMonolith = 3747;

		[global::Cpp2ILInjected.Token(Token = "0x4005CDA")]
		public const short PartyBundleOfBalloonTile = 3748;

		[global::Cpp2ILInjected.Token(Token = "0x4005CDB")]
		public const short PartyPresent = 3749;

		[global::Cpp2ILInjected.Token(Token = "0x4005CDC")]
		public const short SliceOfCake = 3750;

		[global::Cpp2ILInjected.Token(Token = "0x4005CDD")]
		public const short CogWall = 3751;

		[global::Cpp2ILInjected.Token(Token = "0x4005CDE")]
		public const short SandFallWall = 3752;

		[global::Cpp2ILInjected.Token(Token = "0x4005CDF")]
		public const short SnowFallWall = 3753;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE0")]
		public const short SandFallBlock = 3754;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE1")]
		public const short SnowFallBlock = 3755;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE2")]
		public const short SnowCloudBlock = 3756;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE3")]
		public const short PedguinHat = 3757;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE4")]
		public const short PedguinShirt = 3758;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE5")]
		public const short PedguinPants = 3759;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE6")]
		public const short SillyBalloonPinkWall = 3760;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE7")]
		public const short SillyBalloonPurpleWall = 3761;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE8")]
		public const short SillyBalloonGreenWall = 3762;

		[global::Cpp2ILInjected.Token(Token = "0x4005CE9")]
		public const short AviatorSunglasses = 3763;

		[global::Cpp2ILInjected.Token(Token = "0x4005CEA")]
		public const short BluePhasesaber = 3764;

		[global::Cpp2ILInjected.Token(Token = "0x4005CEB")]
		public const short RedPhasesaber = 3765;

		[global::Cpp2ILInjected.Token(Token = "0x4005CEC")]
		public const short GreenPhasesaber = 3766;

		[global::Cpp2ILInjected.Token(Token = "0x4005CED")]
		public const short PurplePhasesaber = 3767;

		[global::Cpp2ILInjected.Token(Token = "0x4005CEE")]
		public const short WhitePhasesaber = 3768;

		[global::Cpp2ILInjected.Token(Token = "0x4005CEF")]
		public const short YellowPhasesaber = 3769;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF0")]
		public const short DjinnsCurse = 3770;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF1")]
		public const short AncientHorn = 3771;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF2")]
		public const short AntlionClaw = 3772;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF3")]
		public const short AncientArmorHat = 3773;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF4")]
		public const short AncientArmorShirt = 3774;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF5")]
		public const short AncientArmorPants = 3775;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF6")]
		public const short AncientBattleArmorHat = 3776;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF7")]
		public const short AncientBattleArmorShirt = 3777;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF8")]
		public const short AncientBattleArmorPants = 3778;

		[global::Cpp2ILInjected.Token(Token = "0x4005CF9")]
		public const short SpiritFlame = 3779;

		[global::Cpp2ILInjected.Token(Token = "0x4005CFA")]
		public const short SandElementalBanner = 3780;

		[global::Cpp2ILInjected.Token(Token = "0x4005CFB")]
		public const short PocketMirror = 3781;

		[global::Cpp2ILInjected.Token(Token = "0x4005CFC")]
		public const short MagicSandDropper = 3782;

		[global::Cpp2ILInjected.Token(Token = "0x4005CFD")]
		public const short AncientBattleArmorMaterial = 3783;

		[global::Cpp2ILInjected.Token(Token = "0x4005CFE")]
		public const short LamiaPants = 3784;

		[global::Cpp2ILInjected.Token(Token = "0x4005CFF")]
		public const short LamiaShirt = 3785;

		[global::Cpp2ILInjected.Token(Token = "0x4005D00")]
		public const short LamiaHat = 3786;

		[global::Cpp2ILInjected.Token(Token = "0x4005D01")]
		public const short SkyFracture = 3787;

		[global::Cpp2ILInjected.Token(Token = "0x4005D02")]
		public const short OnyxBlaster = 3788;

		[global::Cpp2ILInjected.Token(Token = "0x4005D03")]
		public const short SandsharkBanner = 3789;

		[global::Cpp2ILInjected.Token(Token = "0x4005D04")]
		public const short SandsharkCorruptBanner = 3790;

		[global::Cpp2ILInjected.Token(Token = "0x4005D05")]
		public const short SandsharkCrimsonBanner = 3791;

		[global::Cpp2ILInjected.Token(Token = "0x4005D06")]
		public const short SandsharkHallowedBanner = 3792;

		[global::Cpp2ILInjected.Token(Token = "0x4005D07")]
		public const short TumbleweedBanner = 3793;

		[global::Cpp2ILInjected.Token(Token = "0x4005D08")]
		public const short AncientCloth = 3794;

		[global::Cpp2ILInjected.Token(Token = "0x4005D09")]
		public const short DjinnLamp = 3795;

		[global::Cpp2ILInjected.Token(Token = "0x4005D0A")]
		public const short MusicBoxSandstorm = 3796;

		[global::Cpp2ILInjected.Token(Token = "0x4005D0B")]
		public const short ApprenticeHat = 3797;

		[global::Cpp2ILInjected.Token(Token = "0x4005D0C")]
		public const short ApprenticeRobe = 3798;

		[global::Cpp2ILInjected.Token(Token = "0x4005D0D")]
		public const short ApprenticeTrousers = 3799;

		[global::Cpp2ILInjected.Token(Token = "0x4005D0E")]
		public const short SquireGreatHelm = 3800;

		[global::Cpp2ILInjected.Token(Token = "0x4005D0F")]
		public const short SquirePlating = 3801;

		[global::Cpp2ILInjected.Token(Token = "0x4005D10")]
		public const short SquireGreaves = 3802;

		[global::Cpp2ILInjected.Token(Token = "0x4005D11")]
		public const short HuntressWig = 3803;

		[global::Cpp2ILInjected.Token(Token = "0x4005D12")]
		public const short HuntressJerkin = 3804;

		[global::Cpp2ILInjected.Token(Token = "0x4005D13")]
		public const short HuntressPants = 3805;

		[global::Cpp2ILInjected.Token(Token = "0x4005D14")]
		public const short MonkBrows = 3806;

		[global::Cpp2ILInjected.Token(Token = "0x4005D15")]
		public const short MonkShirt = 3807;

		[global::Cpp2ILInjected.Token(Token = "0x4005D16")]
		public const short MonkPants = 3808;

		[global::Cpp2ILInjected.Token(Token = "0x4005D17")]
		public const short ApprenticeScarf = 3809;

		[global::Cpp2ILInjected.Token(Token = "0x4005D18")]
		public const short SquireShield = 3810;

		[global::Cpp2ILInjected.Token(Token = "0x4005D19")]
		public const short HuntressBuckler = 3811;

		[global::Cpp2ILInjected.Token(Token = "0x4005D1A")]
		public const short MonkBelt = 3812;

		[global::Cpp2ILInjected.Token(Token = "0x4005D1B")]
		public const short DefendersForge = 3813;

		[global::Cpp2ILInjected.Token(Token = "0x4005D1C")]
		public const short WarTable = 3814;

		[global::Cpp2ILInjected.Token(Token = "0x4005D1D")]
		public const short WarTableBanner = 3815;

		[global::Cpp2ILInjected.Token(Token = "0x4005D1E")]
		public const short DD2ElderCrystalStand = 3816;

		[global::Cpp2ILInjected.Token(Token = "0x4005D1F")]
		public const short DefenderMedal = 3817;

		[global::Cpp2ILInjected.Token(Token = "0x4005D20")]
		public const short DD2FlameburstTowerT1Popper = 3818;

		[global::Cpp2ILInjected.Token(Token = "0x4005D21")]
		public const short DD2FlameburstTowerT2Popper = 3819;

		[global::Cpp2ILInjected.Token(Token = "0x4005D22")]
		public const short DD2FlameburstTowerT3Popper = 3820;

		[global::Cpp2ILInjected.Token(Token = "0x4005D23")]
		public const short AleThrowingGlove = 3821;

		[global::Cpp2ILInjected.Token(Token = "0x4005D24")]
		public const short DD2EnergyCrystal = 3822;

		[global::Cpp2ILInjected.Token(Token = "0x4005D25")]
		public const short DD2SquireDemonSword = 3823;

		[global::Cpp2ILInjected.Token(Token = "0x4005D26")]
		public const short DD2BallistraTowerT1Popper = 3824;

		[global::Cpp2ILInjected.Token(Token = "0x4005D27")]
		public const short DD2BallistraTowerT2Popper = 3825;

		[global::Cpp2ILInjected.Token(Token = "0x4005D28")]
		public const short DD2BallistraTowerT3Popper = 3826;

		[global::Cpp2ILInjected.Token(Token = "0x4005D29")]
		public const short DD2SquireBetsySword = 3827;

		[global::Cpp2ILInjected.Token(Token = "0x4005D2A")]
		public const short DD2ElderCrystal = 3828;

		[global::Cpp2ILInjected.Token(Token = "0x4005D2B")]
		public const short DD2LightningAuraT1Popper = 3829;

		[global::Cpp2ILInjected.Token(Token = "0x4005D2C")]
		public const short DD2LightningAuraT2Popper = 3830;

		[global::Cpp2ILInjected.Token(Token = "0x4005D2D")]
		public const short DD2LightningAuraT3Popper = 3831;

		[global::Cpp2ILInjected.Token(Token = "0x4005D2E")]
		public const short DD2ExplosiveTrapT1Popper = 3832;

		[global::Cpp2ILInjected.Token(Token = "0x4005D2F")]
		public const short DD2ExplosiveTrapT2Popper = 3833;

		[global::Cpp2ILInjected.Token(Token = "0x4005D30")]
		public const short DD2ExplosiveTrapT3Popper = 3834;

		[global::Cpp2ILInjected.Token(Token = "0x4005D31")]
		public const short MonkStaffT1 = 3835;

		[global::Cpp2ILInjected.Token(Token = "0x4005D32")]
		public const short MonkStaffT2 = 3836;

		[global::Cpp2ILInjected.Token(Token = "0x4005D33")]
		public const short DD2GoblinBomberBanner = 3837;

		[global::Cpp2ILInjected.Token(Token = "0x4005D34")]
		public const short DD2GoblinBanner = 3838;

		[global::Cpp2ILInjected.Token(Token = "0x4005D35")]
		public const short DD2SkeletonBanner = 3839;

		[global::Cpp2ILInjected.Token(Token = "0x4005D36")]
		public const short DD2DrakinBanner = 3840;

		[global::Cpp2ILInjected.Token(Token = "0x4005D37")]
		public const short DD2KoboldFlyerBanner = 3841;

		[global::Cpp2ILInjected.Token(Token = "0x4005D38")]
		public const short DD2KoboldBanner = 3842;

		[global::Cpp2ILInjected.Token(Token = "0x4005D39")]
		public const short DD2WitherBeastBanner = 3843;

		[global::Cpp2ILInjected.Token(Token = "0x4005D3A")]
		public const short DD2WyvernBanner = 3844;

		[global::Cpp2ILInjected.Token(Token = "0x4005D3B")]
		public const short DD2JavelinThrowerBanner = 3845;

		[global::Cpp2ILInjected.Token(Token = "0x4005D3C")]
		public const short DD2LightningBugBanner = 3846;

		[global::Cpp2ILInjected.Token(Token = "0x4005D3D")]
		public const short OgreMask = 3847;

		[global::Cpp2ILInjected.Token(Token = "0x4005D3E")]
		public const short GoblinMask = 3848;

		[global::Cpp2ILInjected.Token(Token = "0x4005D3F")]
		public const short GoblinBomberCap = 3849;

		[global::Cpp2ILInjected.Token(Token = "0x4005D40")]
		public const short EtherianJavelin = 3850;

		[global::Cpp2ILInjected.Token(Token = "0x4005D41")]
		public const short KoboldDynamiteBackpack = 3851;

		[global::Cpp2ILInjected.Token(Token = "0x4005D42")]
		public const short BookStaff = 3852;

		[global::Cpp2ILInjected.Token(Token = "0x4005D43")]
		public const short BoringBow = 3853;

		[global::Cpp2ILInjected.Token(Token = "0x4005D44")]
		public const short DD2PhoenixBow = 3854;

		[global::Cpp2ILInjected.Token(Token = "0x4005D45")]
		public const short DD2PetGato = 3855;

		[global::Cpp2ILInjected.Token(Token = "0x4005D46")]
		public const short DD2PetGhost = 3856;

		[global::Cpp2ILInjected.Token(Token = "0x4005D47")]
		public const short DD2PetDragon = 3857;

		[global::Cpp2ILInjected.Token(Token = "0x4005D48")]
		public const short MonkStaffT3 = 3858;

		[global::Cpp2ILInjected.Token(Token = "0x4005D49")]
		public const short DD2BetsyBow = 3859;

		[global::Cpp2ILInjected.Token(Token = "0x4005D4A")]
		public const short BossBagBetsy = 3860;

		[global::Cpp2ILInjected.Token(Token = "0x4005D4B")]
		public const short BossBagOgre = 3861;

		[global::Cpp2ILInjected.Token(Token = "0x4005D4C")]
		public const short BossBagDarkMage = 3862;

		[global::Cpp2ILInjected.Token(Token = "0x4005D4D")]
		public const short BossMaskBetsy = 3863;

		[global::Cpp2ILInjected.Token(Token = "0x4005D4E")]
		public const short BossMaskDarkMage = 3864;

		[global::Cpp2ILInjected.Token(Token = "0x4005D4F")]
		public const short BossMaskOgre = 3865;

		[global::Cpp2ILInjected.Token(Token = "0x4005D50")]
		public const short BossTrophyBetsy = 3866;

		[global::Cpp2ILInjected.Token(Token = "0x4005D51")]
		public const short BossTrophyDarkmage = 3867;

		[global::Cpp2ILInjected.Token(Token = "0x4005D52")]
		public const short BossTrophyOgre = 3868;

		[global::Cpp2ILInjected.Token(Token = "0x4005D53")]
		public const short MusicBoxDD2 = 3869;

		[global::Cpp2ILInjected.Token(Token = "0x4005D54")]
		public const short ApprenticeStaffT3 = 3870;

		[global::Cpp2ILInjected.Token(Token = "0x4005D55")]
		public const short SquireAltHead = 3871;

		[global::Cpp2ILInjected.Token(Token = "0x4005D56")]
		public const short SquireAltShirt = 3872;

		[global::Cpp2ILInjected.Token(Token = "0x4005D57")]
		public const short SquireAltPants = 3873;

		[global::Cpp2ILInjected.Token(Token = "0x4005D58")]
		public const short ApprenticeAltHead = 3874;

		[global::Cpp2ILInjected.Token(Token = "0x4005D59")]
		public const short ApprenticeAltShirt = 3875;

		[global::Cpp2ILInjected.Token(Token = "0x4005D5A")]
		public const short ApprenticeAltPants = 3876;

		[global::Cpp2ILInjected.Token(Token = "0x4005D5B")]
		public const short HuntressAltHead = 3877;

		[global::Cpp2ILInjected.Token(Token = "0x4005D5C")]
		public const short HuntressAltShirt = 3878;

		[global::Cpp2ILInjected.Token(Token = "0x4005D5D")]
		public const short HuntressAltPants = 3879;

		[global::Cpp2ILInjected.Token(Token = "0x4005D5E")]
		public const short MonkAltHead = 3880;

		[global::Cpp2ILInjected.Token(Token = "0x4005D5F")]
		public const short MonkAltShirt = 3881;

		[global::Cpp2ILInjected.Token(Token = "0x4005D60")]
		public const short MonkAltPants = 3882;

		[global::Cpp2ILInjected.Token(Token = "0x4005D61")]
		public const short BetsyWings = 3883;

		[global::Cpp2ILInjected.Token(Token = "0x4005D62")]
		public const short CrystalChest = 3884;

		[global::Cpp2ILInjected.Token(Token = "0x4005D63")]
		public const short GoldenChest = 3885;

		[global::Cpp2ILInjected.Token(Token = "0x4005D64")]
		public const short Fake_CrystalChest = 3886;

		[global::Cpp2ILInjected.Token(Token = "0x4005D65")]
		public const short Fake_GoldenChest = 3887;

		[global::Cpp2ILInjected.Token(Token = "0x4005D66")]
		public const short CrystalDoor = 3888;

		[global::Cpp2ILInjected.Token(Token = "0x4005D67")]
		public const short CrystalChair = 3889;

		[global::Cpp2ILInjected.Token(Token = "0x4005D68")]
		public const short CrystalCandle = 3890;

		[global::Cpp2ILInjected.Token(Token = "0x4005D69")]
		public const short CrystalLantern = 3891;

		[global::Cpp2ILInjected.Token(Token = "0x4005D6A")]
		public const short CrystalLamp = 3892;

		[global::Cpp2ILInjected.Token(Token = "0x4005D6B")]
		public const short CrystalCandelabra = 3893;

		[global::Cpp2ILInjected.Token(Token = "0x4005D6C")]
		public const short CrystalChandelier = 3894;

		[global::Cpp2ILInjected.Token(Token = "0x4005D6D")]
		public const short CrystalBathtub = 3895;

		[global::Cpp2ILInjected.Token(Token = "0x4005D6E")]
		public const short CrystalSink = 3896;

		[global::Cpp2ILInjected.Token(Token = "0x4005D6F")]
		public const short CrystalBed = 3897;

		[global::Cpp2ILInjected.Token(Token = "0x4005D70")]
		public const short CrystalClock = 3898;

		[global::Cpp2ILInjected.Token(Token = "0x4005D71")]
		public const short SkywareClock2 = 3899;

		[global::Cpp2ILInjected.Token(Token = "0x4005D72")]
		public const short DungeonClockBlue = 3900;

		[global::Cpp2ILInjected.Token(Token = "0x4005D73")]
		public const short DungeonClockGreen = 3901;

		[global::Cpp2ILInjected.Token(Token = "0x4005D74")]
		public const short DungeonClockPink = 3902;

		[global::Cpp2ILInjected.Token(Token = "0x4005D75")]
		public const short CrystalPlatform = 3903;

		[global::Cpp2ILInjected.Token(Token = "0x4005D76")]
		public const short GoldenPlatform = 3904;

		[global::Cpp2ILInjected.Token(Token = "0x4005D77")]
		public const short DynastyPlatform = 3905;

		[global::Cpp2ILInjected.Token(Token = "0x4005D78")]
		public const short LihzahrdPlatform = 3906;

		[global::Cpp2ILInjected.Token(Token = "0x4005D79")]
		public const short FleshPlatform = 3907;

		[global::Cpp2ILInjected.Token(Token = "0x4005D7A")]
		public const short FrozenPlatform = 3908;

		[global::Cpp2ILInjected.Token(Token = "0x4005D7B")]
		public const short CrystalWorkbench = 3909;

		[global::Cpp2ILInjected.Token(Token = "0x4005D7C")]
		public const short GoldenWorkbench = 3910;

		[global::Cpp2ILInjected.Token(Token = "0x4005D7D")]
		public const short CrystalDresser = 3911;

		[global::Cpp2ILInjected.Token(Token = "0x4005D7E")]
		public const short DynastyDresser = 3912;

		[global::Cpp2ILInjected.Token(Token = "0x4005D7F")]
		public const short FrozenDresser = 3913;

		[global::Cpp2ILInjected.Token(Token = "0x4005D80")]
		public const short LivingWoodDresser = 3914;

		[global::Cpp2ILInjected.Token(Token = "0x4005D81")]
		public const short CrystalPiano = 3915;

		[global::Cpp2ILInjected.Token(Token = "0x4005D82")]
		public const short DynastyPiano = 3916;

		[global::Cpp2ILInjected.Token(Token = "0x4005D83")]
		public const short CrystalBookCase = 3917;

		[global::Cpp2ILInjected.Token(Token = "0x4005D84")]
		public const short CrystalSofaHowDoesThatEvenWork = 3918;

		[global::Cpp2ILInjected.Token(Token = "0x4005D85")]
		public const short DynastySofa = 3919;

		[global::Cpp2ILInjected.Token(Token = "0x4005D86")]
		public const short CrystalTable = 3920;

		[global::Cpp2ILInjected.Token(Token = "0x4005D87")]
		public const short ArkhalisHat = 3921;

		[global::Cpp2ILInjected.Token(Token = "0x4005D88")]
		public const short ArkhalisShirt = 3922;

		[global::Cpp2ILInjected.Token(Token = "0x4005D89")]
		public const short ArkhalisPants = 3923;

		[global::Cpp2ILInjected.Token(Token = "0x4005D8A")]
		public const short ArkhalisWings = 3924;

		[global::Cpp2ILInjected.Token(Token = "0x4005D8B")]
		public const short LeinforsHat = 3925;

		[global::Cpp2ILInjected.Token(Token = "0x4005D8C")]
		public const short LeinforsShirt = 3926;

		[global::Cpp2ILInjected.Token(Token = "0x4005D8D")]
		public const short LeinforsPants = 3927;

		[global::Cpp2ILInjected.Token(Token = "0x4005D8E")]
		public const short LeinforsWings = 3928;

		[global::Cpp2ILInjected.Token(Token = "0x4005D8F")]
		public const short LeinforsAccessory = 3929;

		[global::Cpp2ILInjected.Token(Token = "0x4005D90")]
		public const short Celeb2 = 3930;

		[global::Cpp2ILInjected.Token(Token = "0x4005D91")]
		public const short SpiderBathtub = 3931;

		[global::Cpp2ILInjected.Token(Token = "0x4005D92")]
		public const short SpiderBed = 3932;

		[global::Cpp2ILInjected.Token(Token = "0x4005D93")]
		public const short SpiderBookcase = 3933;

		[global::Cpp2ILInjected.Token(Token = "0x4005D94")]
		public const short SpiderDresser = 3934;

		[global::Cpp2ILInjected.Token(Token = "0x4005D95")]
		public const short SpiderCandelabra = 3935;

		[global::Cpp2ILInjected.Token(Token = "0x4005D96")]
		public const short SpiderCandle = 3936;

		[global::Cpp2ILInjected.Token(Token = "0x4005D97")]
		public const short SpiderChair = 3937;

		[global::Cpp2ILInjected.Token(Token = "0x4005D98")]
		public const short SpiderChandelier = 3938;

		[global::Cpp2ILInjected.Token(Token = "0x4005D99")]
		public const short SpiderChest = 3939;

		[global::Cpp2ILInjected.Token(Token = "0x4005D9A")]
		public const short SpiderClock = 3940;

		[global::Cpp2ILInjected.Token(Token = "0x4005D9B")]
		public const short SpiderDoor = 3941;

		[global::Cpp2ILInjected.Token(Token = "0x4005D9C")]
		public const short SpiderLamp = 3942;

		[global::Cpp2ILInjected.Token(Token = "0x4005D9D")]
		public const short SpiderLantern = 3943;

		[global::Cpp2ILInjected.Token(Token = "0x4005D9E")]
		public const short SpiderPiano = 3944;

		[global::Cpp2ILInjected.Token(Token = "0x4005D9F")]
		public const short SpiderPlatform = 3945;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA0")]
		public const short SpiderSinkSpiderSinkDoesWhateverASpiderSinkDoes = 3946;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA1")]
		public const short SpiderSofa = 3947;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA2")]
		public const short SpiderTable = 3948;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA3")]
		public const short SpiderWorkbench = 3949;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA4")]
		public const short Fake_SpiderChest = 3950;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA5")]
		public const short IronBrick = 3951;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA6")]
		public const short IronBrickWall = 3952;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA7")]
		public const short LeadBrick = 3953;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA8")]
		public const short LeadBrickWall = 3954;

		[global::Cpp2ILInjected.Token(Token = "0x4005DA9")]
		public const short LesionBlock = 3955;

		[global::Cpp2ILInjected.Token(Token = "0x4005DAA")]
		public const short LesionBlockWall = 3956;

		[global::Cpp2ILInjected.Token(Token = "0x4005DAB")]
		public const short LesionPlatform = 3957;

		[global::Cpp2ILInjected.Token(Token = "0x4005DAC")]
		public const short LesionBathtub = 3958;

		[global::Cpp2ILInjected.Token(Token = "0x4005DAD")]
		public const short LesionBed = 3959;

		[global::Cpp2ILInjected.Token(Token = "0x4005DAE")]
		public const short LesionBookcase = 3960;

		[global::Cpp2ILInjected.Token(Token = "0x4005DAF")]
		public const short LesionCandelabra = 3961;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB0")]
		public const short LesionCandle = 3962;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB1")]
		public const short LesionChair = 3963;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB2")]
		public const short LesionChandelier = 3964;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB3")]
		public const short LesionChest = 3965;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB4")]
		public const short LesionClock = 3966;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB5")]
		public const short LesionDoor = 3967;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB6")]
		public const short LesionDresser = 3968;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB7")]
		public const short LesionLamp = 3969;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB8")]
		public const short LesionLantern = 3970;

		[global::Cpp2ILInjected.Token(Token = "0x4005DB9")]
		public const short LesionPiano = 3971;

		[global::Cpp2ILInjected.Token(Token = "0x4005DBA")]
		public const short LesionSink = 3972;

		[global::Cpp2ILInjected.Token(Token = "0x4005DBB")]
		public const short LesionSofa = 3973;

		[global::Cpp2ILInjected.Token(Token = "0x4005DBC")]
		public const short LesionTable = 3974;

		[global::Cpp2ILInjected.Token(Token = "0x4005DBD")]
		public const short LesionWorkbench = 3975;

		[global::Cpp2ILInjected.Token(Token = "0x4005DBE")]
		public const short Fake_LesionChest = 3976;

		[global::Cpp2ILInjected.Token(Token = "0x4005DBF")]
		public const short HatRack = 3977;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC0")]
		public const short ColorOnlyDye = 3978;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC1")]
		public const short WoodenCrateHard = 3979;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC2")]
		public const short IronCrateHard = 3980;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC3")]
		public const short GoldenCrateHard = 3981;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC4")]
		public const short CorruptFishingCrateHard = 3982;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC5")]
		public const short CrimsonFishingCrateHard = 3983;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC6")]
		public const short DungeonFishingCrateHard = 3984;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC7")]
		public const short FloatingIslandFishingCrateHard = 3985;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC8")]
		public const short HallowedFishingCrateHard = 3986;

		[global::Cpp2ILInjected.Token(Token = "0x4005DC9")]
		public const short JungleFishingCrateHard = 3987;

		[global::Cpp2ILInjected.Token(Token = "0x4005DCA")]
		public const short DeadMansChest = 3988;

		[global::Cpp2ILInjected.Token(Token = "0x4005DCB")]
		public const short GolfBall = 3989;

		[global::Cpp2ILInjected.Token(Token = "0x4005DCC")]
		public const short AmphibianBoots = 3990;

		[global::Cpp2ILInjected.Token(Token = "0x4005DCD")]
		public const short ArcaneFlower = 3991;

		[global::Cpp2ILInjected.Token(Token = "0x4005DCE")]
		public const short BerserkerGlove = 3992;

		[global::Cpp2ILInjected.Token(Token = "0x4005DCF")]
		public const short FairyBoots = 3993;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD0")]
		public const short FrogFlipper = 3994;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD1")]
		public const short FrogGear = 3995;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD2")]
		public const short FrogWebbing = 3996;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD3")]
		public const short FrozenShield = 3997;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD4")]
		public const short HeroShield = 3998;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD5")]
		public const short LavaSkull = 3999;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD6")]
		public const short MagnetFlower = 4000;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD7")]
		public const short ManaCloak = 4001;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD8")]
		public const short MoltenQuiver = 4002;

		[global::Cpp2ILInjected.Token(Token = "0x4005DD9")]
		public const short MoltenSkullRose = 4003;

		[global::Cpp2ILInjected.Token(Token = "0x4005DDA")]
		public const short ObsidianSkullRose = 4004;

		[global::Cpp2ILInjected.Token(Token = "0x4005DDB")]
		public const short ReconScope = 4005;

		[global::Cpp2ILInjected.Token(Token = "0x4005DDC")]
		public const short StalkersQuiver = 4006;

		[global::Cpp2ILInjected.Token(Token = "0x4005DDD")]
		public const short StingerNecklace = 4007;

		[global::Cpp2ILInjected.Token(Token = "0x4005DDE")]
		public const short UltrabrightHelmet = 4008;

		[global::Cpp2ILInjected.Token(Token = "0x4005DDF")]
		public const short Apple = 4009;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE0")]
		public const short ApplePieSlice = 4010;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE1")]
		public const short ApplePie = 4011;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE2")]
		public const short BananaSplit = 4012;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE3")]
		public const short BBQRibs = 4013;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE4")]
		public const short BunnyStew = 4014;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE5")]
		public const short Burger = 4015;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE6")]
		public const short ChickenNugget = 4016;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE7")]
		public const short ChocolateChipCookie = 4017;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE8")]
		public const short CreamSoda = 4018;

		[global::Cpp2ILInjected.Token(Token = "0x4005DE9")]
		public const short Escargot = 4019;

		[global::Cpp2ILInjected.Token(Token = "0x4005DEA")]
		public const short FriedEgg = 4020;

		[global::Cpp2ILInjected.Token(Token = "0x4005DEB")]
		public const short Fries = 4021;

		[global::Cpp2ILInjected.Token(Token = "0x4005DEC")]
		public const short GoldenDelight = 4022;

		[global::Cpp2ILInjected.Token(Token = "0x4005DED")]
		public const short Grapes = 4023;

		[global::Cpp2ILInjected.Token(Token = "0x4005DEE")]
		public const short GrilledSquirrel = 4024;

		[global::Cpp2ILInjected.Token(Token = "0x4005DEF")]
		public const short Hotdog = 4025;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF0")]
		public const short IceCream = 4026;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF1")]
		public const short Milkshake = 4027;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF2")]
		public const short Nachos = 4028;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF3")]
		public const short Pizza = 4029;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF4")]
		public const short PotatoChips = 4030;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF5")]
		public const short RoastedBird = 4031;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF6")]
		public const short RoastedDuck = 4032;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF7")]
		public const short SauteedFrogLegs = 4033;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF8")]
		public const short SeafoodDinner = 4034;

		[global::Cpp2ILInjected.Token(Token = "0x4005DF9")]
		public const short ShrimpPoBoy = 4035;

		[global::Cpp2ILInjected.Token(Token = "0x4005DFA")]
		public const short Spaghetti = 4036;

		[global::Cpp2ILInjected.Token(Token = "0x4005DFB")]
		public const short Steak = 4037;

		[global::Cpp2ILInjected.Token(Token = "0x4005DFC")]
		public const short MoltenCharm = 4038;

		[global::Cpp2ILInjected.Token(Token = "0x4005DFD")]
		public const short GolfClubIron = 4039;

		[global::Cpp2ILInjected.Token(Token = "0x4005DFE")]
		public const short GolfCup = 4040;

		[global::Cpp2ILInjected.Token(Token = "0x4005DFF")]
		public const short FlowerPacketBlue = 4041;

		[global::Cpp2ILInjected.Token(Token = "0x4005E00")]
		public const short FlowerPacketMagenta = 4042;

		[global::Cpp2ILInjected.Token(Token = "0x4005E01")]
		public const short FlowerPacketPink = 4043;

		[global::Cpp2ILInjected.Token(Token = "0x4005E02")]
		public const short FlowerPacketRed = 4044;

		[global::Cpp2ILInjected.Token(Token = "0x4005E03")]
		public const short FlowerPacketYellow = 4045;

		[global::Cpp2ILInjected.Token(Token = "0x4005E04")]
		public const short FlowerPacketViolet = 4046;

		[global::Cpp2ILInjected.Token(Token = "0x4005E05")]
		public const short FlowerPacketWhite = 4047;

		[global::Cpp2ILInjected.Token(Token = "0x4005E06")]
		public const short FlowerPacketTallGrass = 4048;

		[global::Cpp2ILInjected.Token(Token = "0x4005E07")]
		public const short LawnMower = 4049;

		[global::Cpp2ILInjected.Token(Token = "0x4005E08")]
		public const short CrimstoneBrick = 4050;

		[global::Cpp2ILInjected.Token(Token = "0x4005E09")]
		public const short SmoothSandstone = 4051;

		[global::Cpp2ILInjected.Token(Token = "0x4005E0A")]
		public const short CrimstoneBrickWall = 4052;

		[global::Cpp2ILInjected.Token(Token = "0x4005E0B")]
		public const short SmoothSandstoneWall = 4053;

		[global::Cpp2ILInjected.Token(Token = "0x4005E0C")]
		public const short BloodMoonMonolith = 4054;

		[global::Cpp2ILInjected.Token(Token = "0x4005E0D")]
		public const short SandBoots = 4055;

		[global::Cpp2ILInjected.Token(Token = "0x4005E0E")]
		public const short AncientChisel = 4056;

		[global::Cpp2ILInjected.Token(Token = "0x4005E0F")]
		public const short CarbonGuitar = 4057;

		[global::Cpp2ILInjected.Token(Token = "0x4005E10")]
		public const short SkeletonBow = 4058;

		[global::Cpp2ILInjected.Token(Token = "0x4005E11")]
		public const short FossilPickaxe = 4059;

		[global::Cpp2ILInjected.Token(Token = "0x4005E12")]
		public const short SuperStarCannon = 4060;

		[global::Cpp2ILInjected.Token(Token = "0x4005E13")]
		public const short ThunderSpear = 4061;

		[global::Cpp2ILInjected.Token(Token = "0x4005E14")]
		public const short ThunderStaff = 4062;

		[global::Cpp2ILInjected.Token(Token = "0x4005E15")]
		public const short DrumSet = 4063;

		[global::Cpp2ILInjected.Token(Token = "0x4005E16")]
		public const short PicnicTable = 4064;

		[global::Cpp2ILInjected.Token(Token = "0x4005E17")]
		public const short PicnicTableWithCloth = 4065;

		[global::Cpp2ILInjected.Token(Token = "0x4005E18")]
		public const short DesertMinecart = 4066;

		[global::Cpp2ILInjected.Token(Token = "0x4005E19")]
		public const short FishMinecart = 4067;

		[global::Cpp2ILInjected.Token(Token = "0x4005E1A")]
		public const short FairyCritterPink = 4068;

		[global::Cpp2ILInjected.Token(Token = "0x4005E1B")]
		public const short FairyCritterGreen = 4069;

		[global::Cpp2ILInjected.Token(Token = "0x4005E1C")]
		public const short FairyCritterBlue = 4070;

		[global::Cpp2ILInjected.Token(Token = "0x4005E1D")]
		public const short JunoniaShell = 4071;

		[global::Cpp2ILInjected.Token(Token = "0x4005E1E")]
		public const short LightningWhelkShell = 4072;

		[global::Cpp2ILInjected.Token(Token = "0x4005E1F")]
		public const short TulipShell = 4073;

		[global::Cpp2ILInjected.Token(Token = "0x4005E20")]
		public const short PinWheel = 4074;

		[global::Cpp2ILInjected.Token(Token = "0x4005E21")]
		public const short WeatherVane = 4075;

		[global::Cpp2ILInjected.Token(Token = "0x4005E22")]
		public const short VoidVault = 4076;

		[global::Cpp2ILInjected.Token(Token = "0x4005E23")]
		public const short MusicBoxOceanAlt = 4077;

		[global::Cpp2ILInjected.Token(Token = "0x4005E24")]
		public const short MusicBoxSlimeRain = 4078;

		[global::Cpp2ILInjected.Token(Token = "0x4005E25")]
		public const short MusicBoxSpaceAlt = 4079;

		[global::Cpp2ILInjected.Token(Token = "0x4005E26")]
		public const short MusicBoxTownDay = 4080;

		[global::Cpp2ILInjected.Token(Token = "0x4005E27")]
		public const short MusicBoxTownNight = 4081;

		[global::Cpp2ILInjected.Token(Token = "0x4005E28")]
		public const short MusicBoxWindyDay = 4082;

		[global::Cpp2ILInjected.Token(Token = "0x4005E29")]
		public const short GolfCupFlagWhite = 4083;

		[global::Cpp2ILInjected.Token(Token = "0x4005E2A")]
		public const short GolfCupFlagRed = 4084;

		[global::Cpp2ILInjected.Token(Token = "0x4005E2B")]
		public const short GolfCupFlagGreen = 4085;

		[global::Cpp2ILInjected.Token(Token = "0x4005E2C")]
		public const short GolfCupFlagBlue = 4086;

		[global::Cpp2ILInjected.Token(Token = "0x4005E2D")]
		public const short GolfCupFlagYellow = 4087;

		[global::Cpp2ILInjected.Token(Token = "0x4005E2E")]
		public const short GolfCupFlagPurple = 4088;

		[global::Cpp2ILInjected.Token(Token = "0x4005E2F")]
		public const short GolfTee = 4089;

		[global::Cpp2ILInjected.Token(Token = "0x4005E30")]
		public const short ShellPileBlock = 4090;

		[global::Cpp2ILInjected.Token(Token = "0x4005E31")]
		public const short AntiPortalBlock = 4091;

		[global::Cpp2ILInjected.Token(Token = "0x4005E32")]
		public const short GolfClubPutter = 4092;

		[global::Cpp2ILInjected.Token(Token = "0x4005E33")]
		public const short GolfClubWedge = 4093;

		[global::Cpp2ILInjected.Token(Token = "0x4005E34")]
		public const short GolfClubDriver = 4094;

		[global::Cpp2ILInjected.Token(Token = "0x4005E35")]
		public const short GolfWhistle = 4095;

		[global::Cpp2ILInjected.Token(Token = "0x4005E36")]
		public const short ToiletEbonyWood = 4096;

		[global::Cpp2ILInjected.Token(Token = "0x4005E37")]
		public const short ToiletRichMahogany = 4097;

		[global::Cpp2ILInjected.Token(Token = "0x4005E38")]
		public const short ToiletPearlwood = 4098;

		[global::Cpp2ILInjected.Token(Token = "0x4005E39")]
		public const short ToiletLivingWood = 4099;

		[global::Cpp2ILInjected.Token(Token = "0x4005E3A")]
		public const short ToiletCactus = 4100;

		[global::Cpp2ILInjected.Token(Token = "0x4005E3B")]
		public const short ToiletBone = 4101;

		[global::Cpp2ILInjected.Token(Token = "0x4005E3C")]
		public const short ToiletFlesh = 4102;

		[global::Cpp2ILInjected.Token(Token = "0x4005E3D")]
		public const short ToiletMushroom = 4103;

		[global::Cpp2ILInjected.Token(Token = "0x4005E3E")]
		public const short ToiletSunplate = 4104;

		[global::Cpp2ILInjected.Token(Token = "0x4005E3F")]
		public const short ToiletShadewood = 4105;

		[global::Cpp2ILInjected.Token(Token = "0x4005E40")]
		public const short ToiletLihzhard = 4106;

		[global::Cpp2ILInjected.Token(Token = "0x4005E41")]
		public const short ToiletDungeonBlue = 4107;

		[global::Cpp2ILInjected.Token(Token = "0x4005E42")]
		public const short ToiletDungeonGreen = 4108;

		[global::Cpp2ILInjected.Token(Token = "0x4005E43")]
		public const short ToiletDungeonPink = 4109;

		[global::Cpp2ILInjected.Token(Token = "0x4005E44")]
		public const short ToiletObsidian = 4110;

		[global::Cpp2ILInjected.Token(Token = "0x4005E45")]
		public const short ToiletFrozen = 4111;

		[global::Cpp2ILInjected.Token(Token = "0x4005E46")]
		public const short ToiletGlass = 4112;

		[global::Cpp2ILInjected.Token(Token = "0x4005E47")]
		public const short ToiletHoney = 4113;

		[global::Cpp2ILInjected.Token(Token = "0x4005E48")]
		public const short ToiletSteampunk = 4114;

		[global::Cpp2ILInjected.Token(Token = "0x4005E49")]
		public const short ToiletPumpkin = 4115;

		[global::Cpp2ILInjected.Token(Token = "0x4005E4A")]
		public const short ToiletSpooky = 4116;

		[global::Cpp2ILInjected.Token(Token = "0x4005E4B")]
		public const short ToiletDynasty = 4117;

		[global::Cpp2ILInjected.Token(Token = "0x4005E4C")]
		public const short ToiletPalm = 4118;

		[global::Cpp2ILInjected.Token(Token = "0x4005E4D")]
		public const short ToiletBoreal = 4119;

		[global::Cpp2ILInjected.Token(Token = "0x4005E4E")]
		public const short ToiletSlime = 4120;

		[global::Cpp2ILInjected.Token(Token = "0x4005E4F")]
		public const short ToiletMartian = 4121;

		[global::Cpp2ILInjected.Token(Token = "0x4005E50")]
		public const short ToiletGranite = 4122;

		[global::Cpp2ILInjected.Token(Token = "0x4005E51")]
		public const short ToiletMarble = 4123;

		[global::Cpp2ILInjected.Token(Token = "0x4005E52")]
		public const short ToiletCrystal = 4124;

		[global::Cpp2ILInjected.Token(Token = "0x4005E53")]
		public const short ToiletSpider = 4125;

		[global::Cpp2ILInjected.Token(Token = "0x4005E54")]
		public const short ToiletLesion = 4126;

		[global::Cpp2ILInjected.Token(Token = "0x4005E55")]
		public const short ToiletDiamond = 4127;

		[global::Cpp2ILInjected.Token(Token = "0x4005E56")]
		public const short MaidHead = 4128;

		[global::Cpp2ILInjected.Token(Token = "0x4005E57")]
		public const short MaidShirt = 4129;

		[global::Cpp2ILInjected.Token(Token = "0x4005E58")]
		public const short MaidPants = 4130;

		[global::Cpp2ILInjected.Token(Token = "0x4005E59")]
		public const short VoidLens = 4131;

		[global::Cpp2ILInjected.Token(Token = "0x4005E5A")]
		public const short MaidHead2 = 4132;

		[global::Cpp2ILInjected.Token(Token = "0x4005E5B")]
		public const short MaidShirt2 = 4133;

		[global::Cpp2ILInjected.Token(Token = "0x4005E5C")]
		public const short MaidPants2 = 4134;

		[global::Cpp2ILInjected.Token(Token = "0x4005E5D")]
		public const short GolfHat = 4135;

		[global::Cpp2ILInjected.Token(Token = "0x4005E5E")]
		public const short GolfShirt = 4136;

		[global::Cpp2ILInjected.Token(Token = "0x4005E5F")]
		public const short GolfPants = 4137;

		[global::Cpp2ILInjected.Token(Token = "0x4005E60")]
		public const short GolfVisor = 4138;

		[global::Cpp2ILInjected.Token(Token = "0x4005E61")]
		public const short SpiderBlock = 4139;

		[global::Cpp2ILInjected.Token(Token = "0x4005E62")]
		public const short SpiderWall = 4140;

		[global::Cpp2ILInjected.Token(Token = "0x4005E63")]
		public const short ToiletMeteor = 4141;

		[global::Cpp2ILInjected.Token(Token = "0x4005E64")]
		public const short LesionStation = 4142;

		[global::Cpp2ILInjected.Token(Token = "0x4005E65")]
		public const short ManaCloakStar = 4143;

		[global::Cpp2ILInjected.Token(Token = "0x4005E66")]
		public const short Terragrim = 4144;

		[global::Cpp2ILInjected.Token(Token = "0x4005E67")]
		public const short SolarBathtub = 4145;

		[global::Cpp2ILInjected.Token(Token = "0x4005E68")]
		public const short SolarBed = 4146;

		[global::Cpp2ILInjected.Token(Token = "0x4005E69")]
		public const short SolarBookcase = 4147;

		[global::Cpp2ILInjected.Token(Token = "0x4005E6A")]
		public const short SolarDresser = 4148;

		[global::Cpp2ILInjected.Token(Token = "0x4005E6B")]
		public const short SolarCandelabra = 4149;

		[global::Cpp2ILInjected.Token(Token = "0x4005E6C")]
		public const short SolarCandle = 4150;

		[global::Cpp2ILInjected.Token(Token = "0x4005E6D")]
		public const short SolarChair = 4151;

		[global::Cpp2ILInjected.Token(Token = "0x4005E6E")]
		public const short SolarChandelier = 4152;

		[global::Cpp2ILInjected.Token(Token = "0x4005E6F")]
		public const short SolarChest = 4153;

		[global::Cpp2ILInjected.Token(Token = "0x4005E70")]
		public const short SolarClock = 4154;

		[global::Cpp2ILInjected.Token(Token = "0x4005E71")]
		public const short SolarDoor = 4155;

		[global::Cpp2ILInjected.Token(Token = "0x4005E72")]
		public const short SolarLamp = 4156;

		[global::Cpp2ILInjected.Token(Token = "0x4005E73")]
		public const short SolarLantern = 4157;

		[global::Cpp2ILInjected.Token(Token = "0x4005E74")]
		public const short SolarPiano = 4158;

		[global::Cpp2ILInjected.Token(Token = "0x4005E75")]
		public const short SolarPlatform = 4159;

		[global::Cpp2ILInjected.Token(Token = "0x4005E76")]
		public const short SolarSink = 4160;

		[global::Cpp2ILInjected.Token(Token = "0x4005E77")]
		public const short SolarSofa = 4161;

		[global::Cpp2ILInjected.Token(Token = "0x4005E78")]
		public const short SolarTable = 4162;

		[global::Cpp2ILInjected.Token(Token = "0x4005E79")]
		public const short SolarWorkbench = 4163;

		[global::Cpp2ILInjected.Token(Token = "0x4005E7A")]
		public const short Fake_SolarChest = 4164;

		[global::Cpp2ILInjected.Token(Token = "0x4005E7B")]
		public const short SolarToilet = 4165;

		[global::Cpp2ILInjected.Token(Token = "0x4005E7C")]
		public const short VortexBathtub = 4166;

		[global::Cpp2ILInjected.Token(Token = "0x4005E7D")]
		public const short VortexBed = 4167;

		[global::Cpp2ILInjected.Token(Token = "0x4005E7E")]
		public const short VortexBookcase = 4168;

		[global::Cpp2ILInjected.Token(Token = "0x4005E7F")]
		public const short VortexDresser = 4169;

		[global::Cpp2ILInjected.Token(Token = "0x4005E80")]
		public const short VortexCandelabra = 4170;

		[global::Cpp2ILInjected.Token(Token = "0x4005E81")]
		public const short VortexCandle = 4171;

		[global::Cpp2ILInjected.Token(Token = "0x4005E82")]
		public const short VortexChair = 4172;

		[global::Cpp2ILInjected.Token(Token = "0x4005E83")]
		public const short VortexChandelier = 4173;

		[global::Cpp2ILInjected.Token(Token = "0x4005E84")]
		public const short VortexChest = 4174;

		[global::Cpp2ILInjected.Token(Token = "0x4005E85")]
		public const short VortexClock = 4175;

		[global::Cpp2ILInjected.Token(Token = "0x4005E86")]
		public const short VortexDoor = 4176;

		[global::Cpp2ILInjected.Token(Token = "0x4005E87")]
		public const short VortexLamp = 4177;

		[global::Cpp2ILInjected.Token(Token = "0x4005E88")]
		public const short VortexLantern = 4178;

		[global::Cpp2ILInjected.Token(Token = "0x4005E89")]
		public const short VortexPiano = 4179;

		[global::Cpp2ILInjected.Token(Token = "0x4005E8A")]
		public const short VortexPlatform = 4180;

		[global::Cpp2ILInjected.Token(Token = "0x4005E8B")]
		public const short VortexSink = 4181;

		[global::Cpp2ILInjected.Token(Token = "0x4005E8C")]
		public const short VortexSofa = 4182;

		[global::Cpp2ILInjected.Token(Token = "0x4005E8D")]
		public const short VortexTable = 4183;

		[global::Cpp2ILInjected.Token(Token = "0x4005E8E")]
		public const short VortexWorkbench = 4184;

		[global::Cpp2ILInjected.Token(Token = "0x4005E8F")]
		public const short Fake_VortexChest = 4185;

		[global::Cpp2ILInjected.Token(Token = "0x4005E90")]
		public const short VortexToilet = 4186;

		[global::Cpp2ILInjected.Token(Token = "0x4005E91")]
		public const short NebulaBathtub = 4187;

		[global::Cpp2ILInjected.Token(Token = "0x4005E92")]
		public const short NebulaBed = 4188;

		[global::Cpp2ILInjected.Token(Token = "0x4005E93")]
		public const short NebulaBookcase = 4189;

		[global::Cpp2ILInjected.Token(Token = "0x4005E94")]
		public const short NebulaDresser = 4190;

		[global::Cpp2ILInjected.Token(Token = "0x4005E95")]
		public const short NebulaCandelabra = 4191;

		[global::Cpp2ILInjected.Token(Token = "0x4005E96")]
		public const short NebulaCandle = 4192;

		[global::Cpp2ILInjected.Token(Token = "0x4005E97")]
		public const short NebulaChair = 4193;

		[global::Cpp2ILInjected.Token(Token = "0x4005E98")]
		public const short NebulaChandelier = 4194;

		[global::Cpp2ILInjected.Token(Token = "0x4005E99")]
		public const short NebulaChest = 4195;

		[global::Cpp2ILInjected.Token(Token = "0x4005E9A")]
		public const short NebulaClock = 4196;

		[global::Cpp2ILInjected.Token(Token = "0x4005E9B")]
		public const short NebulaDoor = 4197;

		[global::Cpp2ILInjected.Token(Token = "0x4005E9C")]
		public const short NebulaLamp = 4198;

		[global::Cpp2ILInjected.Token(Token = "0x4005E9D")]
		public const short NebulaLantern = 4199;

		[global::Cpp2ILInjected.Token(Token = "0x4005E9E")]
		public const short NebulaPiano = 4200;

		[global::Cpp2ILInjected.Token(Token = "0x4005E9F")]
		public const short NebulaPlatform = 4201;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA0")]
		public const short NebulaSink = 4202;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA1")]
		public const short NebulaSofa = 4203;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA2")]
		public const short NebulaTable = 4204;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA3")]
		public const short NebulaWorkbench = 4205;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA4")]
		public const short Fake_NebulaChest = 4206;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA5")]
		public const short NebulaToilet = 4207;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA6")]
		public const short StardustBathtub = 4208;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA7")]
		public const short StardustBed = 4209;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA8")]
		public const short StardustBookcase = 4210;

		[global::Cpp2ILInjected.Token(Token = "0x4005EA9")]
		public const short StardustDresser = 4211;

		[global::Cpp2ILInjected.Token(Token = "0x4005EAA")]
		public const short StardustCandelabra = 4212;

		[global::Cpp2ILInjected.Token(Token = "0x4005EAB")]
		public const short StardustCandle = 4213;

		[global::Cpp2ILInjected.Token(Token = "0x4005EAC")]
		public const short StardustChair = 4214;

		[global::Cpp2ILInjected.Token(Token = "0x4005EAD")]
		public const short StardustChandelier = 4215;

		[global::Cpp2ILInjected.Token(Token = "0x4005EAE")]
		public const short StardustChest = 4216;

		[global::Cpp2ILInjected.Token(Token = "0x4005EAF")]
		public const short StardustClock = 4217;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB0")]
		public const short StardustDoor = 4218;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB1")]
		public const short StardustLamp = 4219;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB2")]
		public const short StardustLantern = 4220;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB3")]
		public const short StardustPiano = 4221;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB4")]
		public const short StardustPlatform = 4222;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB5")]
		public const short StardustSink = 4223;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB6")]
		public const short StardustSofa = 4224;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB7")]
		public const short StardustTable = 4225;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB8")]
		public const short StardustWorkbench = 4226;

		[global::Cpp2ILInjected.Token(Token = "0x4005EB9")]
		public const short Fake_StardustChest = 4227;

		[global::Cpp2ILInjected.Token(Token = "0x4005EBA")]
		public const short StardustToilet = 4228;

		[global::Cpp2ILInjected.Token(Token = "0x4005EBB")]
		public const short SolarBrick = 4229;

		[global::Cpp2ILInjected.Token(Token = "0x4005EBC")]
		public const short VortexBrick = 4230;

		[global::Cpp2ILInjected.Token(Token = "0x4005EBD")]
		public const short NebulaBrick = 4231;

		[global::Cpp2ILInjected.Token(Token = "0x4005EBE")]
		public const short StardustBrick = 4232;

		[global::Cpp2ILInjected.Token(Token = "0x4005EBF")]
		public const short SolarBrickWall = 4233;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC0")]
		public const short VortexBrickWall = 4234;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC1")]
		public const short NebulaBrickWall = 4235;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC2")]
		public const short StardustBrickWall = 4236;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC3")]
		public const short MusicBoxDayRemix = 4237;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC4")]
		public const short CrackedBlueBrick = 4238;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC5")]
		public const short CrackedGreenBrick = 4239;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC6")]
		public const short CrackedPinkBrick = 4240;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC7")]
		public const short FlowerPacketWild = 4241;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC8")]
		public const short GolfBallDyedBlack = 4242;

		[global::Cpp2ILInjected.Token(Token = "0x4005EC9")]
		public const short GolfBallDyedBlue = 4243;

		[global::Cpp2ILInjected.Token(Token = "0x4005ECA")]
		public const short GolfBallDyedBrown = 4244;

		[global::Cpp2ILInjected.Token(Token = "0x4005ECB")]
		public const short GolfBallDyedCyan = 4245;

		[global::Cpp2ILInjected.Token(Token = "0x4005ECC")]
		public const short GolfBallDyedGreen = 4246;

		[global::Cpp2ILInjected.Token(Token = "0x4005ECD")]
		public const short GolfBallDyedLimeGreen = 4247;

		[global::Cpp2ILInjected.Token(Token = "0x4005ECE")]
		public const short GolfBallDyedOrange = 4248;

		[global::Cpp2ILInjected.Token(Token = "0x4005ECF")]
		public const short GolfBallDyedPink = 4249;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED0")]
		public const short GolfBallDyedPurple = 4250;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED1")]
		public const short GolfBallDyedRed = 4251;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED2")]
		public const short GolfBallDyedSkyBlue = 4252;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED3")]
		public const short GolfBallDyedTeal = 4253;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED4")]
		public const short GolfBallDyedViolet = 4254;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED5")]
		public const short GolfBallDyedYellow = 4255;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED6")]
		public const short AmberRobe = 4256;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED7")]
		public const short AmberHook = 4257;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED8")]
		public const short OrangePhaseblade = 4258;

		[global::Cpp2ILInjected.Token(Token = "0x4005ED9")]
		public const short OrangePhasesaber = 4259;

		[global::Cpp2ILInjected.Token(Token = "0x4005EDA")]
		public const short OrangeStainedGlass = 4260;

		[global::Cpp2ILInjected.Token(Token = "0x4005EDB")]
		public const short OrangePressurePlate = 4261;

		[global::Cpp2ILInjected.Token(Token = "0x4005EDC")]
		public const short MysticCoilSnake = 4262;

		[global::Cpp2ILInjected.Token(Token = "0x4005EDD")]
		public const short MagicConch = 4263;

		[global::Cpp2ILInjected.Token(Token = "0x4005EDE")]
		public const short GolfCart = 4264;

		[global::Cpp2ILInjected.Token(Token = "0x4005EDF")]
		public const short GolfChest = 4265;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE0")]
		public const short Fake_GolfChest = 4266;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE1")]
		public const short DesertChest = 4267;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE2")]
		public const short Fake_DesertChest = 4268;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE3")]
		public const short SanguineStaff = 4269;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE4")]
		public const short SharpTears = 4270;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE5")]
		public const short BloodMoonStarter = 4271;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE6")]
		public const short DripplerFlail = 4272;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE7")]
		public const short VampireFrogStaff = 4273;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE8")]
		public const short GoldGoldfish = 4274;

		[global::Cpp2ILInjected.Token(Token = "0x4005EE9")]
		public const short GoldGoldfishBowl = 4275;

		[global::Cpp2ILInjected.Token(Token = "0x4005EEA")]
		public const short CatBast = 4276;

		[global::Cpp2ILInjected.Token(Token = "0x4005EEB")]
		public const short GoldStarryGlassBlock = 4277;

		[global::Cpp2ILInjected.Token(Token = "0x4005EEC")]
		public const short BlueStarryGlassBlock = 4278;

		[global::Cpp2ILInjected.Token(Token = "0x4005EED")]
		public const short GoldStarryGlassWall = 4279;

		[global::Cpp2ILInjected.Token(Token = "0x4005EEE")]
		public const short BlueStarryGlassWall = 4280;

		[global::Cpp2ILInjected.Token(Token = "0x4005EEF")]
		public const short BabyBirdStaff = 4281;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF0")]
		public const short Apricot = 4282;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF1")]
		public const short Banana = 4283;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF2")]
		public const short BlackCurrant = 4284;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF3")]
		public const short BloodOrange = 4285;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF4")]
		public const short Cherry = 4286;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF5")]
		public const short Coconut = 4287;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF6")]
		public const short Dragonfruit = 4288;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF7")]
		public const short Elderberry = 4289;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF8")]
		public const short Grapefruit = 4290;

		[global::Cpp2ILInjected.Token(Token = "0x4005EF9")]
		public const short Lemon = 4291;

		[global::Cpp2ILInjected.Token(Token = "0x4005EFA")]
		public const short Mango = 4292;

		[global::Cpp2ILInjected.Token(Token = "0x4005EFB")]
		public const short Peach = 4293;

		[global::Cpp2ILInjected.Token(Token = "0x4005EFC")]
		public const short Pineapple = 4294;

		[global::Cpp2ILInjected.Token(Token = "0x4005EFD")]
		public const short Plum = 4295;

		[global::Cpp2ILInjected.Token(Token = "0x4005EFE")]
		public const short Rambutan = 4296;

		[global::Cpp2ILInjected.Token(Token = "0x4005EFF")]
		public const short Starfruit = 4297;

		[global::Cpp2ILInjected.Token(Token = "0x4005F00")]
		public const short SandstoneBathtub = 4298;

		[global::Cpp2ILInjected.Token(Token = "0x4005F01")]
		public const short SandstoneBed = 4299;

		[global::Cpp2ILInjected.Token(Token = "0x4005F02")]
		public const short SandstoneBookcase = 4300;

		[global::Cpp2ILInjected.Token(Token = "0x4005F03")]
		public const short SandstoneDresser = 4301;

		[global::Cpp2ILInjected.Token(Token = "0x4005F04")]
		public const short SandstoneCandelabra = 4302;

		[global::Cpp2ILInjected.Token(Token = "0x4005F05")]
		public const short SandstoneCandle = 4303;

		[global::Cpp2ILInjected.Token(Token = "0x4005F06")]
		public const short SandstoneChair = 4304;

		[global::Cpp2ILInjected.Token(Token = "0x4005F07")]
		public const short SandstoneChandelier = 4305;

		[global::Cpp2ILInjected.Token(Token = "0x4005F08")]
		public const short SandstoneClock = 4306;

		[global::Cpp2ILInjected.Token(Token = "0x4005F09")]
		public const short SandstoneDoor = 4307;

		[global::Cpp2ILInjected.Token(Token = "0x4005F0A")]
		public const short SandstoneLamp = 4308;

		[global::Cpp2ILInjected.Token(Token = "0x4005F0B")]
		public const short SandstoneLantern = 4309;

		[global::Cpp2ILInjected.Token(Token = "0x4005F0C")]
		public const short SandstonePiano = 4310;

		[global::Cpp2ILInjected.Token(Token = "0x4005F0D")]
		public const short SandstonePlatform = 4311;

		[global::Cpp2ILInjected.Token(Token = "0x4005F0E")]
		public const short SandstoneSink = 4312;

		[global::Cpp2ILInjected.Token(Token = "0x4005F0F")]
		public const short SandstoneSofa = 4313;

		[global::Cpp2ILInjected.Token(Token = "0x4005F10")]
		public const short SandstoneTable = 4314;

		[global::Cpp2ILInjected.Token(Token = "0x4005F11")]
		public const short SandstoneWorkbench = 4315;

		[global::Cpp2ILInjected.Token(Token = "0x4005F12")]
		public const short SandstoneToilet = 4316;

		[global::Cpp2ILInjected.Token(Token = "0x4005F13")]
		public const short BloodHamaxe = 4317;

		[global::Cpp2ILInjected.Token(Token = "0x4005F14")]
		public const short VoidMonolith = 4318;

		[global::Cpp2ILInjected.Token(Token = "0x4005F15")]
		public const short ArrowSign = 4319;

		[global::Cpp2ILInjected.Token(Token = "0x4005F16")]
		public const short PaintedArrowSign = 4320;

		[global::Cpp2ILInjected.Token(Token = "0x4005F17")]
		public const short GameMasterShirt = 4321;

		[global::Cpp2ILInjected.Token(Token = "0x4005F18")]
		public const short GameMasterPants = 4322;

		[global::Cpp2ILInjected.Token(Token = "0x4005F19")]
		public const short StarPrincessCrown = 4323;

		[global::Cpp2ILInjected.Token(Token = "0x4005F1A")]
		public const short StarPrincessDress = 4324;

		[global::Cpp2ILInjected.Token(Token = "0x4005F1B")]
		public const short BloodFishingRod = 4325;

		[global::Cpp2ILInjected.Token(Token = "0x4005F1C")]
		public const short FoodPlatter = 4326;

		[global::Cpp2ILInjected.Token(Token = "0x4005F1D")]
		public const short BlackDragonflyJar = 4327;

		[global::Cpp2ILInjected.Token(Token = "0x4005F1E")]
		public const short BlueDragonflyJar = 4328;

		[global::Cpp2ILInjected.Token(Token = "0x4005F1F")]
		public const short GreenDragonflyJar = 4329;

		[global::Cpp2ILInjected.Token(Token = "0x4005F20")]
		public const short OrangeDragonflyJar = 4330;

		[global::Cpp2ILInjected.Token(Token = "0x4005F21")]
		public const short RedDragonflyJar = 4331;

		[global::Cpp2ILInjected.Token(Token = "0x4005F22")]
		public const short YellowDragonflyJar = 4332;

		[global::Cpp2ILInjected.Token(Token = "0x4005F23")]
		public const short GoldDragonflyJar = 4333;

		[global::Cpp2ILInjected.Token(Token = "0x4005F24")]
		public const short BlackDragonfly = 4334;

		[global::Cpp2ILInjected.Token(Token = "0x4005F25")]
		public const short BlueDragonfly = 4335;

		[global::Cpp2ILInjected.Token(Token = "0x4005F26")]
		public const short GreenDragonfly = 4336;

		[global::Cpp2ILInjected.Token(Token = "0x4005F27")]
		public const short OrangeDragonfly = 4337;

		[global::Cpp2ILInjected.Token(Token = "0x4005F28")]
		public const short RedDragonfly = 4338;

		[global::Cpp2ILInjected.Token(Token = "0x4005F29")]
		public const short YellowDragonfly = 4339;

		[global::Cpp2ILInjected.Token(Token = "0x4005F2A")]
		public const short GoldDragonfly = 4340;

		[global::Cpp2ILInjected.Token(Token = "0x4005F2B")]
		public const short PortableStool = 4341;

		[global::Cpp2ILInjected.Token(Token = "0x4005F2C")]
		public const short DragonflyStatue = 4342;

		[global::Cpp2ILInjected.Token(Token = "0x4005F2D")]
		public const short PaperAirplaneA = 4343;

		[global::Cpp2ILInjected.Token(Token = "0x4005F2E")]
		public const short PaperAirplaneB = 4344;

		[global::Cpp2ILInjected.Token(Token = "0x4005F2F")]
		public const short CanOfWorms = 4345;

		[global::Cpp2ILInjected.Token(Token = "0x4005F30")]
		public const short EncumberingStone = 4346;

		[global::Cpp2ILInjected.Token(Token = "0x4005F31")]
		public const short ZapinatorGray = 4347;

		[global::Cpp2ILInjected.Token(Token = "0x4005F32")]
		public const short ZapinatorOrange = 4348;

		[global::Cpp2ILInjected.Token(Token = "0x4005F33")]
		public const short GreenMoss = 4349;

		[global::Cpp2ILInjected.Token(Token = "0x4005F34")]
		public const short BrownMoss = 4350;

		[global::Cpp2ILInjected.Token(Token = "0x4005F35")]
		public const short RedMoss = 4351;

		[global::Cpp2ILInjected.Token(Token = "0x4005F36")]
		public const short BlueMoss = 4352;

		[global::Cpp2ILInjected.Token(Token = "0x4005F37")]
		public const short PurpleMoss = 4353;

		[global::Cpp2ILInjected.Token(Token = "0x4005F38")]
		public const short LavaMoss = 4354;

		[global::Cpp2ILInjected.Token(Token = "0x4005F39")]
		public const short BoulderStatue = 4355;

		[global::Cpp2ILInjected.Token(Token = "0x4005F3A")]
		public const short MusicBoxTitleAlt = 4356;

		[global::Cpp2ILInjected.Token(Token = "0x4005F3B")]
		public const short MusicBoxStorm = 4357;

		[global::Cpp2ILInjected.Token(Token = "0x4005F3C")]
		public const short MusicBoxGraveyard = 4358;

		[global::Cpp2ILInjected.Token(Token = "0x4005F3D")]
		public const short Seagull = 4359;

		[global::Cpp2ILInjected.Token(Token = "0x4005F3E")]
		public const short SeagullStatue = 4360;

		[global::Cpp2ILInjected.Token(Token = "0x4005F3F")]
		public const short LadyBug = 4361;

		[global::Cpp2ILInjected.Token(Token = "0x4005F40")]
		public const short GoldLadyBug = 4362;

		[global::Cpp2ILInjected.Token(Token = "0x4005F41")]
		public const short Maggot = 4363;

		[global::Cpp2ILInjected.Token(Token = "0x4005F42")]
		public const short MaggotCage = 4364;

		[global::Cpp2ILInjected.Token(Token = "0x4005F43")]
		public const short CelestialWand = 4365;

		[global::Cpp2ILInjected.Token(Token = "0x4005F44")]
		public const short EucaluptusSap = 4366;

		[global::Cpp2ILInjected.Token(Token = "0x4005F45")]
		public const short KiteBlue = 4367;

		[global::Cpp2ILInjected.Token(Token = "0x4005F46")]
		public const short KiteBlueAndYellow = 4368;

		[global::Cpp2ILInjected.Token(Token = "0x4005F47")]
		public const short KiteRed = 4369;

		[global::Cpp2ILInjected.Token(Token = "0x4005F48")]
		public const short KiteRedAndYellow = 4370;

		[global::Cpp2ILInjected.Token(Token = "0x4005F49")]
		public const short KiteYellow = 4371;

		[global::Cpp2ILInjected.Token(Token = "0x4005F4A")]
		public const short IvyGuitar = 4372;

		[global::Cpp2ILInjected.Token(Token = "0x4005F4B")]
		public const short Pupfish = 4373;

		[global::Cpp2ILInjected.Token(Token = "0x4005F4C")]
		public const short Grebe = 4374;

		[global::Cpp2ILInjected.Token(Token = "0x4005F4D")]
		public const short Rat = 4375;

		[global::Cpp2ILInjected.Token(Token = "0x4005F4E")]
		public const short RatCage = 4376;

		[global::Cpp2ILInjected.Token(Token = "0x4005F4F")]
		public const short KryptonMoss = 4377;

		[global::Cpp2ILInjected.Token(Token = "0x4005F50")]
		public const short XenonMoss = 4378;

		[global::Cpp2ILInjected.Token(Token = "0x4005F51")]
		public const short KiteWyvern = 4379;

		[global::Cpp2ILInjected.Token(Token = "0x4005F52")]
		public const short LadybugCage = 4380;

		[global::Cpp2ILInjected.Token(Token = "0x4005F53")]
		public const short BloodRainBow = 4381;

		[global::Cpp2ILInjected.Token(Token = "0x4005F54")]
		public const short CombatBook = 4382;

		[global::Cpp2ILInjected.Token(Token = "0x4005F55")]
		public const short DesertTorch = 4383;

		[global::Cpp2ILInjected.Token(Token = "0x4005F56")]
		public const short CoralTorch = 4384;

		[global::Cpp2ILInjected.Token(Token = "0x4005F57")]
		public const short CorruptTorch = 4385;

		[global::Cpp2ILInjected.Token(Token = "0x4005F58")]
		public const short CrimsonTorch = 4386;

		[global::Cpp2ILInjected.Token(Token = "0x4005F59")]
		public const short HallowedTorch = 4387;

		[global::Cpp2ILInjected.Token(Token = "0x4005F5A")]
		public const short JungleTorch = 4388;

		[global::Cpp2ILInjected.Token(Token = "0x4005F5B")]
		public const short ArgonMoss = 4389;

		[global::Cpp2ILInjected.Token(Token = "0x4005F5C")]
		public const short RollingCactus = 4390;

		[global::Cpp2ILInjected.Token(Token = "0x4005F5D")]
		public const short ThinIce = 4391;

		[global::Cpp2ILInjected.Token(Token = "0x4005F5E")]
		public const short EchoBlock = 4392;

		[global::Cpp2ILInjected.Token(Token = "0x4005F5F")]
		public const short ScarabFish = 4393;

		[global::Cpp2ILInjected.Token(Token = "0x4005F60")]
		public const short ScorpioFish = 4394;

		[global::Cpp2ILInjected.Token(Token = "0x4005F61")]
		public const short Owl = 4395;

		[global::Cpp2ILInjected.Token(Token = "0x4005F62")]
		public const short OwlCage = 4396;

		[global::Cpp2ILInjected.Token(Token = "0x4005F63")]
		public const short OwlStatue = 4397;

		[global::Cpp2ILInjected.Token(Token = "0x4005F64")]
		public const short PupfishBowl = 4398;

		[global::Cpp2ILInjected.Token(Token = "0x4005F65")]
		public const short GoldLadybugCage = 4399;

		[global::Cpp2ILInjected.Token(Token = "0x4005F66")]
		public const short Geode = 4400;

		[global::Cpp2ILInjected.Token(Token = "0x4005F67")]
		public const short Flounder = 4401;

		[global::Cpp2ILInjected.Token(Token = "0x4005F68")]
		public const short RockLobster = 4402;

		[global::Cpp2ILInjected.Token(Token = "0x4005F69")]
		public const short LobsterTail = 4403;

		[global::Cpp2ILInjected.Token(Token = "0x4005F6A")]
		public const short FloatingTube = 4404;

		[global::Cpp2ILInjected.Token(Token = "0x4005F6B")]
		public const short FrozenCrate = 4405;

		[global::Cpp2ILInjected.Token(Token = "0x4005F6C")]
		public const short FrozenCrateHard = 4406;

		[global::Cpp2ILInjected.Token(Token = "0x4005F6D")]
		public const short OasisCrate = 4407;

		[global::Cpp2ILInjected.Token(Token = "0x4005F6E")]
		public const short OasisCrateHard = 4408;

		[global::Cpp2ILInjected.Token(Token = "0x4005F6F")]
		public const short SpectreGoggles = 4409;

		[global::Cpp2ILInjected.Token(Token = "0x4005F70")]
		public const short Oyster = 4410;

		[global::Cpp2ILInjected.Token(Token = "0x4005F71")]
		public const short ShuckedOyster = 4411;

		[global::Cpp2ILInjected.Token(Token = "0x4005F72")]
		public const short WhitePearl = 4412;

		[global::Cpp2ILInjected.Token(Token = "0x4005F73")]
		public const short BlackPearl = 4413;

		[global::Cpp2ILInjected.Token(Token = "0x4005F74")]
		public const short PinkPearl = 4414;

		[global::Cpp2ILInjected.Token(Token = "0x4005F75")]
		public const short StoneDoor = 4415;

		[global::Cpp2ILInjected.Token(Token = "0x4005F76")]
		public const short StonePlatform = 4416;

		[global::Cpp2ILInjected.Token(Token = "0x4005F77")]
		public const short OasisFountain = 4417;

		[global::Cpp2ILInjected.Token(Token = "0x4005F78")]
		public const short WaterStrider = 4418;

		[global::Cpp2ILInjected.Token(Token = "0x4005F79")]
		public const short GoldWaterStrider = 4419;

		[global::Cpp2ILInjected.Token(Token = "0x4005F7A")]
		public const short LawnFlamingo = 4420;

		[global::Cpp2ILInjected.Token(Token = "0x4005F7B")]
		public const short MusicBoxUndergroundJungle = 4421;

		[global::Cpp2ILInjected.Token(Token = "0x4005F7C")]
		public const short Grate = 4422;

		[global::Cpp2ILInjected.Token(Token = "0x4005F7D")]
		public const short ScarabBomb = 4423;

		[global::Cpp2ILInjected.Token(Token = "0x4005F7E")]
		public const short WroughtIronFence = 4424;

		[global::Cpp2ILInjected.Token(Token = "0x4005F7F")]
		public const short SharkBait = 4425;

		[global::Cpp2ILInjected.Token(Token = "0x4005F80")]
		public const short BeeMinecart = 4426;

		[global::Cpp2ILInjected.Token(Token = "0x4005F81")]
		public const short LadybugMinecart = 4427;

		[global::Cpp2ILInjected.Token(Token = "0x4005F82")]
		public const short PigronMinecart = 4428;

		[global::Cpp2ILInjected.Token(Token = "0x4005F83")]
		public const short SunflowerMinecart = 4429;

		[global::Cpp2ILInjected.Token(Token = "0x4005F84")]
		public const short PottedForestCedar = 4430;

		[global::Cpp2ILInjected.Token(Token = "0x4005F85")]
		public const short PottedJungleCedar = 4431;

		[global::Cpp2ILInjected.Token(Token = "0x4005F86")]
		public const short PottedHallowCedar = 4432;

		[global::Cpp2ILInjected.Token(Token = "0x4005F87")]
		public const short PottedForestTree = 4433;

		[global::Cpp2ILInjected.Token(Token = "0x4005F88")]
		public const short PottedJungleTree = 4434;

		[global::Cpp2ILInjected.Token(Token = "0x4005F89")]
		public const short PottedHallowTree = 4435;

		[global::Cpp2ILInjected.Token(Token = "0x4005F8A")]
		public const short PottedForestPalm = 4436;

		[global::Cpp2ILInjected.Token(Token = "0x4005F8B")]
		public const short PottedJunglePalm = 4437;

		[global::Cpp2ILInjected.Token(Token = "0x4005F8C")]
		public const short PottedHallowPalm = 4438;

		[global::Cpp2ILInjected.Token(Token = "0x4005F8D")]
		public const short PottedForestBamboo = 4439;

		[global::Cpp2ILInjected.Token(Token = "0x4005F8E")]
		public const short PottedJungleBamboo = 4440;

		[global::Cpp2ILInjected.Token(Token = "0x4005F8F")]
		public const short PottedHallowBamboo = 4441;

		[global::Cpp2ILInjected.Token(Token = "0x4005F90")]
		public const short ScarabFishingRod = 4442;

		[global::Cpp2ILInjected.Token(Token = "0x4005F91")]
		public const short HellMinecart = 4443;

		[global::Cpp2ILInjected.Token(Token = "0x4005F92")]
		public const short WitchBroom = 4444;

		[global::Cpp2ILInjected.Token(Token = "0x4005F93")]
		public const short ClusterRocketI = 4445;

		[global::Cpp2ILInjected.Token(Token = "0x4005F94")]
		public const short ClusterRocketII = 4446;

		[global::Cpp2ILInjected.Token(Token = "0x4005F95")]
		public const short WetRocket = 4447;

		[global::Cpp2ILInjected.Token(Token = "0x4005F96")]
		public const short LavaRocket = 4448;

		[global::Cpp2ILInjected.Token(Token = "0x4005F97")]
		public const short HoneyRocket = 4449;

		[global::Cpp2ILInjected.Token(Token = "0x4005F98")]
		public const short ShroomMinecart = 4450;

		[global::Cpp2ILInjected.Token(Token = "0x4005F99")]
		public const short AmethystMinecart = 4451;

		[global::Cpp2ILInjected.Token(Token = "0x4005F9A")]
		public const short TopazMinecart = 4452;

		[global::Cpp2ILInjected.Token(Token = "0x4005F9B")]
		public const short SapphireMinecart = 4453;

		[global::Cpp2ILInjected.Token(Token = "0x4005F9C")]
		public const short EmeraldMinecart = 4454;

		[global::Cpp2ILInjected.Token(Token = "0x4005F9D")]
		public const short RubyMinecart = 4455;

		[global::Cpp2ILInjected.Token(Token = "0x4005F9E")]
		public const short DiamondMinecart = 4456;

		[global::Cpp2ILInjected.Token(Token = "0x4005F9F")]
		public const short MiniNukeI = 4457;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA0")]
		public const short MiniNukeII = 4458;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA1")]
		public const short DryRocket = 4459;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA2")]
		public const short SandcastleBucket = 4460;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA3")]
		public const short TurtleCage = 4461;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA4")]
		public const short TurtleJungleCage = 4462;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA5")]
		public const short Gladius = 4463;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA6")]
		public const short Turtle = 4464;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA7")]
		public const short TurtleJungle = 4465;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA8")]
		public const short TurtleStatue = 4466;

		[global::Cpp2ILInjected.Token(Token = "0x4005FA9")]
		public const short AmberMinecart = 4467;

		[global::Cpp2ILInjected.Token(Token = "0x4005FAA")]
		public const short BeetleMinecart = 4468;

		[global::Cpp2ILInjected.Token(Token = "0x4005FAB")]
		public const short MeowmereMinecart = 4469;

		[global::Cpp2ILInjected.Token(Token = "0x4005FAC")]
		public const short PartyMinecart = 4470;

		[global::Cpp2ILInjected.Token(Token = "0x4005FAD")]
		public const short PirateMinecart = 4471;

		[global::Cpp2ILInjected.Token(Token = "0x4005FAE")]
		public const short SteampunkMinecart = 4472;

		[global::Cpp2ILInjected.Token(Token = "0x4005FAF")]
		public const short GrebeCage = 4473;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB0")]
		public const short SeagullCage = 4474;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB1")]
		public const short WaterStriderCage = 4475;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB2")]
		public const short GoldWaterStriderCage = 4476;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB3")]
		public const short LuckPotionLesser = 4477;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB4")]
		public const short LuckPotion = 4478;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB5")]
		public const short LuckPotionGreater = 4479;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB6")]
		public const short Seahorse = 4480;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB7")]
		public const short SeahorseCage = 4481;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB8")]
		public const short GoldSeahorse = 4482;

		[global::Cpp2ILInjected.Token(Token = "0x4005FB9")]
		public const short GoldSeahorseCage = 4483;

		[global::Cpp2ILInjected.Token(Token = "0x4005FBA")]
		public const short TimerOneHalfSecond = 4484;

		[global::Cpp2ILInjected.Token(Token = "0x4005FBB")]
		public const short TimerOneFourthSecond = 4485;

		[global::Cpp2ILInjected.Token(Token = "0x4005FBC")]
		public const short EbonstoneEcho = 4486;

		[global::Cpp2ILInjected.Token(Token = "0x4005FBD")]
		public const short MudWallEcho = 4487;

		[global::Cpp2ILInjected.Token(Token = "0x4005FBE")]
		public const short PearlstoneEcho = 4488;

		[global::Cpp2ILInjected.Token(Token = "0x4005FBF")]
		public const short SnowWallEcho = 4489;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC0")]
		public const short AmethystEcho = 4490;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC1")]
		public const short TopazEcho = 4491;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC2")]
		public const short SapphireEcho = 4492;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC3")]
		public const short EmeraldEcho = 4493;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC4")]
		public const short RubyEcho = 4494;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC5")]
		public const short DiamondEcho = 4495;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC6")]
		public const short Cave1Echo = 4496;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC7")]
		public const short Cave2Echo = 4497;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC8")]
		public const short Cave3Echo = 4498;

		[global::Cpp2ILInjected.Token(Token = "0x4005FC9")]
		public const short Cave4Echo = 4499;

		[global::Cpp2ILInjected.Token(Token = "0x4005FCA")]
		public const short Cave5Echo = 4500;

		[global::Cpp2ILInjected.Token(Token = "0x4005FCB")]
		public const short Cave6Echo = 4501;

		[global::Cpp2ILInjected.Token(Token = "0x4005FCC")]
		public const short Cave7Echo = 4502;

		[global::Cpp2ILInjected.Token(Token = "0x4005FCD")]
		public const short SpiderEcho = 4503;

		[global::Cpp2ILInjected.Token(Token = "0x4005FCE")]
		public const short CorruptGrassEcho = 4504;

		[global::Cpp2ILInjected.Token(Token = "0x4005FCF")]
		public const short HallowedGrassEcho = 4505;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD0")]
		public const short IceEcho = 4506;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD1")]
		public const short ObsidianBackEcho = 4507;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD2")]
		public const short CrimsonGrassEcho = 4508;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD3")]
		public const short CrimstoneEcho = 4509;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD4")]
		public const short CaveWall1Echo = 4510;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD5")]
		public const short CaveWall2Echo = 4511;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD6")]
		public const short Cave8Echo = 4512;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD7")]
		public const short Corruption1Echo = 4513;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD8")]
		public const short Corruption2Echo = 4514;

		[global::Cpp2ILInjected.Token(Token = "0x4005FD9")]
		public const short Corruption3Echo = 4515;

		[global::Cpp2ILInjected.Token(Token = "0x4005FDA")]
		public const short Corruption4Echo = 4516;

		[global::Cpp2ILInjected.Token(Token = "0x4005FDB")]
		public const short Crimson1Echo = 4517;

		[global::Cpp2ILInjected.Token(Token = "0x4005FDC")]
		public const short Crimson2Echo = 4518;

		[global::Cpp2ILInjected.Token(Token = "0x4005FDD")]
		public const short Crimson3Echo = 4519;

		[global::Cpp2ILInjected.Token(Token = "0x4005FDE")]
		public const short Crimson4Echo = 4520;

		[global::Cpp2ILInjected.Token(Token = "0x4005FDF")]
		public const short Dirt1Echo = 4521;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE0")]
		public const short Dirt2Echo = 4522;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE1")]
		public const short Dirt3Echo = 4523;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE2")]
		public const short Dirt4Echo = 4524;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE3")]
		public const short Hallow1Echo = 4525;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE4")]
		public const short Hallow2Echo = 4526;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE5")]
		public const short Hallow3Echo = 4527;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE6")]
		public const short Hallow4Echo = 4528;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE7")]
		public const short Jungle1Echo = 4529;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE8")]
		public const short Jungle2Echo = 4530;

		[global::Cpp2ILInjected.Token(Token = "0x4005FE9")]
		public const short Jungle3Echo = 4531;

		[global::Cpp2ILInjected.Token(Token = "0x4005FEA")]
		public const short Jungle4Echo = 4532;

		[global::Cpp2ILInjected.Token(Token = "0x4005FEB")]
		public const short Lava1Echo = 4533;

		[global::Cpp2ILInjected.Token(Token = "0x4005FEC")]
		public const short Lava2Echo = 4534;

		[global::Cpp2ILInjected.Token(Token = "0x4005FED")]
		public const short Lava3Echo = 4535;

		[global::Cpp2ILInjected.Token(Token = "0x4005FEE")]
		public const short Lava4Echo = 4536;

		[global::Cpp2ILInjected.Token(Token = "0x4005FEF")]
		public const short Rocks1Echo = 4537;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF0")]
		public const short Rocks2Echo = 4538;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF1")]
		public const short Rocks3Echo = 4539;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF2")]
		public const short Rocks4Echo = 4540;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF3")]
		public const short TheBrideBanner = 4541;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF4")]
		public const short ZombieMermanBanner = 4542;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF5")]
		public const short EyeballFlyingFishBanner = 4543;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF6")]
		public const short BloodSquidBanner = 4544;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF7")]
		public const short BloodEelBanner = 4545;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF8")]
		public const short GoblinSharkBanner = 4546;

		[global::Cpp2ILInjected.Token(Token = "0x4005FF9")]
		public const short LargeBambooBlock = 4547;

		[global::Cpp2ILInjected.Token(Token = "0x4005FFA")]
		public const short LargeBambooBlockWall = 4548;

		[global::Cpp2ILInjected.Token(Token = "0x4005FFB")]
		public const short DemonHorns = 4549;

		[global::Cpp2ILInjected.Token(Token = "0x4005FFC")]
		public const short BambooLeaf = 4550;

		[global::Cpp2ILInjected.Token(Token = "0x4005FFD")]
		public const short HellCake = 4551;

		[global::Cpp2ILInjected.Token(Token = "0x4005FFE")]
		public const short FogMachine = 4552;

		[global::Cpp2ILInjected.Token(Token = "0x4005FFF")]
		public const short PlasmaLamp = 4553;

		[global::Cpp2ILInjected.Token(Token = "0x4006000")]
		public const short MarbleColumn = 4554;

		[global::Cpp2ILInjected.Token(Token = "0x4006001")]
		public const short ChefHat = 4555;

		[global::Cpp2ILInjected.Token(Token = "0x4006002")]
		public const short ChefShirt = 4556;

		[global::Cpp2ILInjected.Token(Token = "0x4006003")]
		public const short ChefPants = 4557;

		[global::Cpp2ILInjected.Token(Token = "0x4006004")]
		public const short StarHairpin = 4558;

		[global::Cpp2ILInjected.Token(Token = "0x4006005")]
		public const short HeartHairpin = 4559;

		[global::Cpp2ILInjected.Token(Token = "0x4006006")]
		public const short BunnyEars = 4560;

		[global::Cpp2ILInjected.Token(Token = "0x4006007")]
		public const short DevilHorns = 4561;

		[global::Cpp2ILInjected.Token(Token = "0x4006008")]
		public const short Fedora = 4562;

		[global::Cpp2ILInjected.Token(Token = "0x4006009")]
		public const short UnicornHornHat = 4563;

		[global::Cpp2ILInjected.Token(Token = "0x400600A")]
		public const short BambooBlock = 4564;

		[global::Cpp2ILInjected.Token(Token = "0x400600B")]
		public const short BambooBlockWall = 4565;

		[global::Cpp2ILInjected.Token(Token = "0x400600C")]
		public const short BambooBathtub = 4566;

		[global::Cpp2ILInjected.Token(Token = "0x400600D")]
		public const short BambooBed = 4567;

		[global::Cpp2ILInjected.Token(Token = "0x400600E")]
		public const short BambooBookcase = 4568;

		[global::Cpp2ILInjected.Token(Token = "0x400600F")]
		public const short BambooDresser = 4569;

		[global::Cpp2ILInjected.Token(Token = "0x4006010")]
		public const short BambooCandelabra = 4570;

		[global::Cpp2ILInjected.Token(Token = "0x4006011")]
		public const short BambooCandle = 4571;

		[global::Cpp2ILInjected.Token(Token = "0x4006012")]
		public const short BambooChair = 4572;

		[global::Cpp2ILInjected.Token(Token = "0x4006013")]
		public const short BambooChandelier = 4573;

		[global::Cpp2ILInjected.Token(Token = "0x4006014")]
		public const short BambooChest = 4574;

		[global::Cpp2ILInjected.Token(Token = "0x4006015")]
		public const short BambooClock = 4575;

		[global::Cpp2ILInjected.Token(Token = "0x4006016")]
		public const short BambooDoor = 4576;

		[global::Cpp2ILInjected.Token(Token = "0x4006017")]
		public const short BambooLamp = 4577;

		[global::Cpp2ILInjected.Token(Token = "0x4006018")]
		public const short BambooLantern = 4578;

		[global::Cpp2ILInjected.Token(Token = "0x4006019")]
		public const short BambooPiano = 4579;

		[global::Cpp2ILInjected.Token(Token = "0x400601A")]
		public const short BambooPlatform = 4580;

		[global::Cpp2ILInjected.Token(Token = "0x400601B")]
		public const short BambooSink = 4581;

		[global::Cpp2ILInjected.Token(Token = "0x400601C")]
		public const short BambooSofa = 4582;

		[global::Cpp2ILInjected.Token(Token = "0x400601D")]
		public const short BambooTable = 4583;

		[global::Cpp2ILInjected.Token(Token = "0x400601E")]
		public const short BambooWorkbench = 4584;

		[global::Cpp2ILInjected.Token(Token = "0x400601F")]
		public const short Fake_BambooChest = 4585;

		[global::Cpp2ILInjected.Token(Token = "0x4006020")]
		public const short BambooToilet = 4586;

		[global::Cpp2ILInjected.Token(Token = "0x4006021")]
		public const short GolfClubStoneIron = 4587;

		[global::Cpp2ILInjected.Token(Token = "0x4006022")]
		public const short GolfClubRustyPutter = 4588;

		[global::Cpp2ILInjected.Token(Token = "0x4006023")]
		public const short GolfClubBronzeWedge = 4589;

		[global::Cpp2ILInjected.Token(Token = "0x4006024")]
		public const short GolfClubWoodDriver = 4590;

		[global::Cpp2ILInjected.Token(Token = "0x4006025")]
		public const short GolfClubMythrilIron = 4591;

		[global::Cpp2ILInjected.Token(Token = "0x4006026")]
		public const short GolfClubLeadPutter = 4592;

		[global::Cpp2ILInjected.Token(Token = "0x4006027")]
		public const short GolfClubGoldWedge = 4593;

		[global::Cpp2ILInjected.Token(Token = "0x4006028")]
		public const short GolfClubPearlwoodDriver = 4594;

		[global::Cpp2ILInjected.Token(Token = "0x4006029")]
		public const short GolfClubTitaniumIron = 4595;

		[global::Cpp2ILInjected.Token(Token = "0x400602A")]
		public const short GolfClubShroomitePutter = 4596;

		[global::Cpp2ILInjected.Token(Token = "0x400602B")]
		public const short GolfClubDiamondWedge = 4597;

		[global::Cpp2ILInjected.Token(Token = "0x400602C")]
		public const short GolfClubChlorophyteDriver = 4598;

		[global::Cpp2ILInjected.Token(Token = "0x400602D")]
		public const short GolfTrophyBronze = 4599;

		[global::Cpp2ILInjected.Token(Token = "0x400602E")]
		public const short GolfTrophySilver = 4600;

		[global::Cpp2ILInjected.Token(Token = "0x400602F")]
		public const short GolfTrophyGold = 4601;

		[global::Cpp2ILInjected.Token(Token = "0x4006030")]
		public const short BloodNautilusBanner = 4602;

		[global::Cpp2ILInjected.Token(Token = "0x4006031")]
		public const short BirdieRattle = 4603;

		[global::Cpp2ILInjected.Token(Token = "0x4006032")]
		public const short ExoticEasternChewToy = 4604;

		[global::Cpp2ILInjected.Token(Token = "0x4006033")]
		public const short BedazzledNectar = 4605;

		[global::Cpp2ILInjected.Token(Token = "0x4006034")]
		public const short MusicBoxJungleNight = 4606;

		[global::Cpp2ILInjected.Token(Token = "0x4006035")]
		public const short StormTigerStaff = 4607;

		[global::Cpp2ILInjected.Token(Token = "0x4006036")]
		public const short ChumBucket = 4608;

		[global::Cpp2ILInjected.Token(Token = "0x4006037")]
		public const short GardenGnome = 4609;

		[global::Cpp2ILInjected.Token(Token = "0x4006038")]
		public const short KiteBoneSerpent = 4610;

		[global::Cpp2ILInjected.Token(Token = "0x4006039")]
		public const short KiteWorldFeeder = 4611;

		[global::Cpp2ILInjected.Token(Token = "0x400603A")]
		public const short KiteBunny = 4612;

		[global::Cpp2ILInjected.Token(Token = "0x400603B")]
		public const short KitePigron = 4613;

		[global::Cpp2ILInjected.Token(Token = "0x400603C")]
		public const short AppleJuice = 4614;

		[global::Cpp2ILInjected.Token(Token = "0x400603D")]
		public const short GrapeJuice = 4615;

		[global::Cpp2ILInjected.Token(Token = "0x400603E")]
		public const short Lemonade = 4616;

		[global::Cpp2ILInjected.Token(Token = "0x400603F")]
		public const short BananaDaiquiri = 4617;

		[global::Cpp2ILInjected.Token(Token = "0x4006040")]
		public const short PeachSangria = 4618;

		[global::Cpp2ILInjected.Token(Token = "0x4006041")]
		public const short PinaColada = 4619;

		[global::Cpp2ILInjected.Token(Token = "0x4006042")]
		public const short TropicalSmoothie = 4620;

		[global::Cpp2ILInjected.Token(Token = "0x4006043")]
		public const short BloodyMoscato = 4621;

		[global::Cpp2ILInjected.Token(Token = "0x4006044")]
		public const short SmoothieofDarkness = 4622;

		[global::Cpp2ILInjected.Token(Token = "0x4006045")]
		public const short PrismaticPunch = 4623;

		[global::Cpp2ILInjected.Token(Token = "0x4006046")]
		public const short FruitJuice = 4624;

		[global::Cpp2ILInjected.Token(Token = "0x4006047")]
		public const short FruitSalad = 4625;

		[global::Cpp2ILInjected.Token(Token = "0x4006048")]
		public const short AndrewSphinx = 4626;

		[global::Cpp2ILInjected.Token(Token = "0x4006049")]
		public const short WatchfulAntlion = 4627;

		[global::Cpp2ILInjected.Token(Token = "0x400604A")]
		public const short BurningSpirit = 4628;

		[global::Cpp2ILInjected.Token(Token = "0x400604B")]
		public const short JawsOfDeath = 4629;

		[global::Cpp2ILInjected.Token(Token = "0x400604C")]
		public const short TheSandsOfSlime = 4630;

		[global::Cpp2ILInjected.Token(Token = "0x400604D")]
		public const short SnakesIHateSnakes = 4631;

		[global::Cpp2ILInjected.Token(Token = "0x400604E")]
		public const short LifeAboveTheSand = 4632;

		[global::Cpp2ILInjected.Token(Token = "0x400604F")]
		public const short Oasis = 4633;

		[global::Cpp2ILInjected.Token(Token = "0x4006050")]
		public const short PrehistoryPreserved = 4634;

		[global::Cpp2ILInjected.Token(Token = "0x4006051")]
		public const short AncientTablet = 4635;

		[global::Cpp2ILInjected.Token(Token = "0x4006052")]
		public const short Uluru = 4636;

		[global::Cpp2ILInjected.Token(Token = "0x4006053")]
		public const short VisitingThePyramids = 4637;

		[global::Cpp2ILInjected.Token(Token = "0x4006054")]
		public const short BandageBoy = 4638;

		[global::Cpp2ILInjected.Token(Token = "0x4006055")]
		public const short DivineEye = 4639;

		[global::Cpp2ILInjected.Token(Token = "0x4006056")]
		public const short AmethystStoneBlock = 4640;

		[global::Cpp2ILInjected.Token(Token = "0x4006057")]
		public const short TopazStoneBlock = 4641;

		[global::Cpp2ILInjected.Token(Token = "0x4006058")]
		public const short SapphireStoneBlock = 4642;

		[global::Cpp2ILInjected.Token(Token = "0x4006059")]
		public const short EmeraldStoneBlock = 4643;

		[global::Cpp2ILInjected.Token(Token = "0x400605A")]
		public const short RubyStoneBlock = 4644;

		[global::Cpp2ILInjected.Token(Token = "0x400605B")]
		public const short DiamondStoneBlock = 4645;

		[global::Cpp2ILInjected.Token(Token = "0x400605C")]
		public const short AmberStoneBlock = 4646;

		[global::Cpp2ILInjected.Token(Token = "0x400605D")]
		public const short AmberStoneWallEcho = 4647;

		[global::Cpp2ILInjected.Token(Token = "0x400605E")]
		public const short KiteManEater = 4648;

		[global::Cpp2ILInjected.Token(Token = "0x400605F")]
		public const short KiteJellyfishBlue = 4649;

		[global::Cpp2ILInjected.Token(Token = "0x4006060")]
		public const short KiteJellyfishPink = 4650;

		[global::Cpp2ILInjected.Token(Token = "0x4006061")]
		public const short KiteShark = 4651;

		[global::Cpp2ILInjected.Token(Token = "0x4006062")]
		public const short SuperHeroMask = 4652;

		[global::Cpp2ILInjected.Token(Token = "0x4006063")]
		public const short SuperHeroCostume = 4653;

		[global::Cpp2ILInjected.Token(Token = "0x4006064")]
		public const short SuperHeroTights = 4654;

		[global::Cpp2ILInjected.Token(Token = "0x4006065")]
		public const short PinkFairyJar = 4655;

		[global::Cpp2ILInjected.Token(Token = "0x4006066")]
		public const short GreenFairyJar = 4656;

		[global::Cpp2ILInjected.Token(Token = "0x4006067")]
		public const short BlueFairyJar = 4657;

		[global::Cpp2ILInjected.Token(Token = "0x4006068")]
		public const short GolfPainting1 = 4658;

		[global::Cpp2ILInjected.Token(Token = "0x4006069")]
		public const short GolfPainting2 = 4659;

		[global::Cpp2ILInjected.Token(Token = "0x400606A")]
		public const short GolfPainting3 = 4660;

		[global::Cpp2ILInjected.Token(Token = "0x400606B")]
		public const short GolfPainting4 = 4661;

		[global::Cpp2ILInjected.Token(Token = "0x400606C")]
		public const short FogboundDye = 4662;

		[global::Cpp2ILInjected.Token(Token = "0x400606D")]
		public const short BloodbathDye = 4663;

		[global::Cpp2ILInjected.Token(Token = "0x400606E")]
		public const short PrettyPinkDressSkirt = 4664;

		[global::Cpp2ILInjected.Token(Token = "0x400606F")]
		public const short PrettyPinkDressPants = 4665;

		[global::Cpp2ILInjected.Token(Token = "0x4006070")]
		public const short PrettyPinkRibbon = 4666;

		[global::Cpp2ILInjected.Token(Token = "0x4006071")]
		public const short BambooFence = 4667;

		[global::Cpp2ILInjected.Token(Token = "0x4006072")]
		public const short GlowPaint = 4668;

		[global::Cpp2ILInjected.Token(Token = "0x4006073")]
		public const short KiteSandShark = 4669;

		[global::Cpp2ILInjected.Token(Token = "0x4006074")]
		public const short KiteBunnyCorrupt = 4670;

		[global::Cpp2ILInjected.Token(Token = "0x4006075")]
		public const short KiteBunnyCrimson = 4671;

		[global::Cpp2ILInjected.Token(Token = "0x4006076")]
		public const short BlandWhip = 4672;

		[global::Cpp2ILInjected.Token(Token = "0x4006077")]
		public const short DrumStick = 4673;

		[global::Cpp2ILInjected.Token(Token = "0x4006078")]
		public const short KiteGoldfish = 4674;

		[global::Cpp2ILInjected.Token(Token = "0x4006079")]
		public const short KiteAngryTrapper = 4675;

		[global::Cpp2ILInjected.Token(Token = "0x400607A")]
		public const short KiteKoi = 4676;

		[global::Cpp2ILInjected.Token(Token = "0x400607B")]
		public const short KiteCrawltipede = 4677;

		[global::Cpp2ILInjected.Token(Token = "0x400607C")]
		public const short SwordWhip = 4678;

		[global::Cpp2ILInjected.Token(Token = "0x400607D")]
		public const short MaceWhip = 4679;

		[global::Cpp2ILInjected.Token(Token = "0x400607E")]
		public const short ScytheWhip = 4680;

		[global::Cpp2ILInjected.Token(Token = "0x400607F")]
		public const short KiteSpectrum = 4681;

		[global::Cpp2ILInjected.Token(Token = "0x4006080")]
		public const short ReleaseDoves = 4682;

		[global::Cpp2ILInjected.Token(Token = "0x4006081")]
		public const short KiteWanderingEye = 4683;

		[global::Cpp2ILInjected.Token(Token = "0x4006082")]
		public const short KiteUnicorn = 4684;

		[global::Cpp2ILInjected.Token(Token = "0x4006083")]
		public const short UndertakerHat = 4685;

		[global::Cpp2ILInjected.Token(Token = "0x4006084")]
		public const short UndertakerCoat = 4686;

		[global::Cpp2ILInjected.Token(Token = "0x4006085")]
		public const short DandelionBanner = 4687;

		[global::Cpp2ILInjected.Token(Token = "0x4006086")]
		public const short GnomeBanner = 4688;

		[global::Cpp2ILInjected.Token(Token = "0x4006087")]
		public const short DesertCampfire = 4689;

		[global::Cpp2ILInjected.Token(Token = "0x4006088")]
		public const short CoralCampfire = 4690;

		[global::Cpp2ILInjected.Token(Token = "0x4006089")]
		public const short CorruptCampfire = 4691;

		[global::Cpp2ILInjected.Token(Token = "0x400608A")]
		public const short CrimsonCampfire = 4692;

		[global::Cpp2ILInjected.Token(Token = "0x400608B")]
		public const short HallowedCampfire = 4693;

		[global::Cpp2ILInjected.Token(Token = "0x400608C")]
		public const short JungleCampfire = 4694;

		[global::Cpp2ILInjected.Token(Token = "0x400608D")]
		public const short SoulBottleLight = 4695;

		[global::Cpp2ILInjected.Token(Token = "0x400608E")]
		public const short SoulBottleNight = 4696;

		[global::Cpp2ILInjected.Token(Token = "0x400608F")]
		public const short SoulBottleFlight = 4697;

		[global::Cpp2ILInjected.Token(Token = "0x4006090")]
		public const short SoulBottleSight = 4698;

		[global::Cpp2ILInjected.Token(Token = "0x4006091")]
		public const short SoulBottleMight = 4699;

		[global::Cpp2ILInjected.Token(Token = "0x4006092")]
		public const short SoulBottleFright = 4700;

		[global::Cpp2ILInjected.Token(Token = "0x4006093")]
		public const short MudBud = 4701;

		[global::Cpp2ILInjected.Token(Token = "0x4006094")]
		public const short ReleaseLantern = 4702;

		[global::Cpp2ILInjected.Token(Token = "0x4006095")]
		public const short QuadBarrelShotgun = 4703;

		[global::Cpp2ILInjected.Token(Token = "0x4006096")]
		public const short FuneralHat = 4704;

		[global::Cpp2ILInjected.Token(Token = "0x4006097")]
		public const short FuneralCoat = 4705;

		[global::Cpp2ILInjected.Token(Token = "0x4006098")]
		public const short FuneralPants = 4706;

		[global::Cpp2ILInjected.Token(Token = "0x4006099")]
		public const short TragicUmbrella = 4707;

		[global::Cpp2ILInjected.Token(Token = "0x400609A")]
		public const short VictorianGothHat = 4708;

		[global::Cpp2ILInjected.Token(Token = "0x400609B")]
		public const short VictorianGothDress = 4709;

		[global::Cpp2ILInjected.Token(Token = "0x400609C")]
		public const short TatteredWoodSign = 4710;

		[global::Cpp2ILInjected.Token(Token = "0x400609D")]
		public const short GravediggerShovel = 4711;

		[global::Cpp2ILInjected.Token(Token = "0x400609E")]
		public const short DungeonDesertChest = 4712;

		[global::Cpp2ILInjected.Token(Token = "0x400609F")]
		public const short Fake_DungeonDesertChest = 4713;

		[global::Cpp2ILInjected.Token(Token = "0x40060A0")]
		public const short DungeonDesertKey = 4714;

		[global::Cpp2ILInjected.Token(Token = "0x40060A1")]
		public const short SparkleGuitar = 4715;

		[global::Cpp2ILInjected.Token(Token = "0x40060A2")]
		public const short MolluskWhistle = 4716;

		[global::Cpp2ILInjected.Token(Token = "0x40060A3")]
		public const short BorealBeam = 4717;

		[global::Cpp2ILInjected.Token(Token = "0x40060A4")]
		public const short RichMahoganyBeam = 4718;

		[global::Cpp2ILInjected.Token(Token = "0x40060A5")]
		public const short GraniteColumn = 4719;

		[global::Cpp2ILInjected.Token(Token = "0x40060A6")]
		public const short SandstoneColumn = 4720;

		[global::Cpp2ILInjected.Token(Token = "0x40060A7")]
		public const short MushroomBeam = 4721;

		[global::Cpp2ILInjected.Token(Token = "0x40060A8")]
		public const short FirstFractal = 4722;

		[global::Cpp2ILInjected.Token(Token = "0x40060A9")]
		public const short Nevermore = 4723;

		[global::Cpp2ILInjected.Token(Token = "0x40060AA")]
		public const short Reborn = 4724;

		[global::Cpp2ILInjected.Token(Token = "0x40060AB")]
		public const short Graveyard = 4725;

		[global::Cpp2ILInjected.Token(Token = "0x40060AC")]
		public const short GhostManifestation = 4726;

		[global::Cpp2ILInjected.Token(Token = "0x40060AD")]
		public const short WickedUndead = 4727;

		[global::Cpp2ILInjected.Token(Token = "0x40060AE")]
		public const short BloodyGoblet = 4728;

		[global::Cpp2ILInjected.Token(Token = "0x40060AF")]
		public const short StillLife = 4729;

		[global::Cpp2ILInjected.Token(Token = "0x40060B0")]
		public const short GhostarsWings = 4730;

		[global::Cpp2ILInjected.Token(Token = "0x40060B1")]
		public const short TerraToilet = 4731;

		[global::Cpp2ILInjected.Token(Token = "0x40060B2")]
		public const short GhostarSkullPin = 4732;

		[global::Cpp2ILInjected.Token(Token = "0x40060B3")]
		public const short GhostarShirt = 4733;

		[global::Cpp2ILInjected.Token(Token = "0x40060B4")]
		public const short GhostarPants = 4734;

		[global::Cpp2ILInjected.Token(Token = "0x40060B5")]
		public const short BallOfFuseWire = 4735;

		[global::Cpp2ILInjected.Token(Token = "0x40060B6")]
		public const short FullMoonSqueakyToy = 4736;

		[global::Cpp2ILInjected.Token(Token = "0x40060B7")]
		public const short OrnateShadowKey = 4737;

		[global::Cpp2ILInjected.Token(Token = "0x40060B8")]
		public const short DrManFlyMask = 4738;

		[global::Cpp2ILInjected.Token(Token = "0x40060B9")]
		public const short DrManFlyLabCoat = 4739;

		[global::Cpp2ILInjected.Token(Token = "0x40060BA")]
		public const short ButcherMask = 4740;

		[global::Cpp2ILInjected.Token(Token = "0x40060BB")]
		public const short ButcherApron = 4741;

		[global::Cpp2ILInjected.Token(Token = "0x40060BC")]
		public const short ButcherPants = 4742;

		[global::Cpp2ILInjected.Token(Token = "0x40060BD")]
		public const short Football = 4743;

		[global::Cpp2ILInjected.Token(Token = "0x40060BE")]
		public const short HunterCloak = 4744;

		[global::Cpp2ILInjected.Token(Token = "0x40060BF")]
		public const short CoffinMinecart = 4745;

		[global::Cpp2ILInjected.Token(Token = "0x40060C0")]
		public const short SafemanWings = 4746;

		[global::Cpp2ILInjected.Token(Token = "0x40060C1")]
		public const short SafemanSunHair = 4747;

		[global::Cpp2ILInjected.Token(Token = "0x40060C2")]
		public const short SafemanSunDress = 4748;

		[global::Cpp2ILInjected.Token(Token = "0x40060C3")]
		public const short SafemanDressLeggings = 4749;

		[global::Cpp2ILInjected.Token(Token = "0x40060C4")]
		public const short FoodBarbarianWings = 4750;

		[global::Cpp2ILInjected.Token(Token = "0x40060C5")]
		public const short FoodBarbarianHelm = 4751;

		[global::Cpp2ILInjected.Token(Token = "0x40060C6")]
		public const short FoodBarbarianArmor = 4752;

		[global::Cpp2ILInjected.Token(Token = "0x40060C7")]
		public const short FoodBarbarianGreaves = 4753;

		[global::Cpp2ILInjected.Token(Token = "0x40060C8")]
		public const short GroxTheGreatWings = 4754;

		[global::Cpp2ILInjected.Token(Token = "0x40060C9")]
		public const short GroxTheGreatHelm = 4755;

		[global::Cpp2ILInjected.Token(Token = "0x40060CA")]
		public const short GroxTheGreatArmor = 4756;

		[global::Cpp2ILInjected.Token(Token = "0x40060CB")]
		public const short GroxTheGreatGreaves = 4757;

		[global::Cpp2ILInjected.Token(Token = "0x40060CC")]
		public const short Smolstar = 4758;

		[global::Cpp2ILInjected.Token(Token = "0x40060CD")]
		public const short SquirrelHook = 4759;

		[global::Cpp2ILInjected.Token(Token = "0x40060CE")]
		public const short BouncingShield = 4760;

		[global::Cpp2ILInjected.Token(Token = "0x40060CF")]
		public const short RockGolemHead = 4761;

		[global::Cpp2ILInjected.Token(Token = "0x40060D0")]
		public const short CritterShampoo = 4762;

		[global::Cpp2ILInjected.Token(Token = "0x40060D1")]
		public const short DiggingMoleMinecart = 4763;

		[global::Cpp2ILInjected.Token(Token = "0x40060D2")]
		public const short Shroomerang = 4764;

		[global::Cpp2ILInjected.Token(Token = "0x40060D3")]
		public const short TreeGlobe = 4765;

		[global::Cpp2ILInjected.Token(Token = "0x40060D4")]
		public const short WorldGlobe = 4766;

		[global::Cpp2ILInjected.Token(Token = "0x40060D5")]
		public const short DontHurtCrittersBook = 4767;

		[global::Cpp2ILInjected.Token(Token = "0x40060D6")]
		public const short DogEars = 4768;

		[global::Cpp2ILInjected.Token(Token = "0x40060D7")]
		public const short DogTail = 4769;

		[global::Cpp2ILInjected.Token(Token = "0x40060D8")]
		public const short FoxEars = 4770;

		[global::Cpp2ILInjected.Token(Token = "0x40060D9")]
		public const short FoxTail = 4771;

		[global::Cpp2ILInjected.Token(Token = "0x40060DA")]
		public const short LizardEars = 4772;

		[global::Cpp2ILInjected.Token(Token = "0x40060DB")]
		public const short LizardTail = 4773;

		[global::Cpp2ILInjected.Token(Token = "0x40060DC")]
		public const short PandaEars = 4774;

		[global::Cpp2ILInjected.Token(Token = "0x40060DD")]
		public const short BunnyTail = 4775;

		[global::Cpp2ILInjected.Token(Token = "0x40060DE")]
		public const short FairyGlowstick = 4776;

		[global::Cpp2ILInjected.Token(Token = "0x40060DF")]
		public const short LightningCarrot = 4777;

		[global::Cpp2ILInjected.Token(Token = "0x40060E0")]
		public const short HallowBossDye = 4778;

		[global::Cpp2ILInjected.Token(Token = "0x40060E1")]
		public const short MushroomHat = 4779;

		[global::Cpp2ILInjected.Token(Token = "0x40060E2")]
		public const short MushroomVest = 4780;

		[global::Cpp2ILInjected.Token(Token = "0x40060E3")]
		public const short MushroomPants = 4781;

		[global::Cpp2ILInjected.Token(Token = "0x40060E4")]
		public const short FairyQueenBossBag = 4782;

		[global::Cpp2ILInjected.Token(Token = "0x40060E5")]
		public const short FairyQueenTrophy = 4783;

		[global::Cpp2ILInjected.Token(Token = "0x40060E6")]
		public const short FairyQueenMask = 4784;

		[global::Cpp2ILInjected.Token(Token = "0x40060E7")]
		public const short PaintedHorseSaddle = 4785;

		[global::Cpp2ILInjected.Token(Token = "0x40060E8")]
		public const short MajesticHorseSaddle = 4786;

		[global::Cpp2ILInjected.Token(Token = "0x40060E9")]
		public const short DarkHorseSaddle = 4787;

		[global::Cpp2ILInjected.Token(Token = "0x40060EA")]
		public const short JoustingLance = 4788;

		[global::Cpp2ILInjected.Token(Token = "0x40060EB")]
		public const short ShadowJoustingLance = 4789;

		[global::Cpp2ILInjected.Token(Token = "0x40060EC")]
		public const short HallowJoustingLance = 4790;

		[global::Cpp2ILInjected.Token(Token = "0x40060ED")]
		public const short PogoStick = 4791;

		[global::Cpp2ILInjected.Token(Token = "0x40060EE")]
		public const short PirateShipMountItem = 4792;

		[global::Cpp2ILInjected.Token(Token = "0x40060EF")]
		public const short SpookyWoodMountItem = 4793;

		[global::Cpp2ILInjected.Token(Token = "0x40060F0")]
		public const short SantankMountItem = 4794;

		[global::Cpp2ILInjected.Token(Token = "0x40060F1")]
		public const short WallOfFleshGoatMountItem = 4795;

		[global::Cpp2ILInjected.Token(Token = "0x40060F2")]
		public const short DarkMageBookMountItem = 4796;

		[global::Cpp2ILInjected.Token(Token = "0x40060F3")]
		public const short KingSlimePetItem = 4797;

		[global::Cpp2ILInjected.Token(Token = "0x40060F4")]
		public const short EyeOfCthulhuPetItem = 4798;

		[global::Cpp2ILInjected.Token(Token = "0x40060F5")]
		public const short EaterOfWorldsPetItem = 4799;

		[global::Cpp2ILInjected.Token(Token = "0x40060F6")]
		public const short BrainOfCthulhuPetItem = 4800;

		[global::Cpp2ILInjected.Token(Token = "0x40060F7")]
		public const short SkeletronPetItem = 4801;

		[global::Cpp2ILInjected.Token(Token = "0x40060F8")]
		public const short QueenBeePetItem = 4802;

		[global::Cpp2ILInjected.Token(Token = "0x40060F9")]
		public const short DestroyerPetItem = 4803;

		[global::Cpp2ILInjected.Token(Token = "0x40060FA")]
		public const short TwinsPetItem = 4804;

		[global::Cpp2ILInjected.Token(Token = "0x40060FB")]
		public const short SkeletronPrimePetItem = 4805;

		[global::Cpp2ILInjected.Token(Token = "0x40060FC")]
		public const short PlanteraPetItem = 4806;

		[global::Cpp2ILInjected.Token(Token = "0x40060FD")]
		public const short GolemPetItem = 4807;

		[global::Cpp2ILInjected.Token(Token = "0x40060FE")]
		public const short DukeFishronPetItem = 4808;

		[global::Cpp2ILInjected.Token(Token = "0x40060FF")]
		public const short LunaticCultistPetItem = 4809;

		[global::Cpp2ILInjected.Token(Token = "0x4006100")]
		public const short MoonLordPetItem = 4810;

		[global::Cpp2ILInjected.Token(Token = "0x4006101")]
		public const short FairyQueenPetItem = 4811;

		[global::Cpp2ILInjected.Token(Token = "0x4006102")]
		public const short PumpkingPetItem = 4812;

		[global::Cpp2ILInjected.Token(Token = "0x4006103")]
		public const short EverscreamPetItem = 4813;

		[global::Cpp2ILInjected.Token(Token = "0x4006104")]
		public const short IceQueenPetItem = 4814;

		[global::Cpp2ILInjected.Token(Token = "0x4006105")]
		public const short MartianPetItem = 4815;

		[global::Cpp2ILInjected.Token(Token = "0x4006106")]
		public const short DD2OgrePetItem = 4816;

		[global::Cpp2ILInjected.Token(Token = "0x4006107")]
		public const short DD2BetsyPetItem = 4817;

		[global::Cpp2ILInjected.Token(Token = "0x4006108")]
		public const short CombatWrench = 4818;

		[global::Cpp2ILInjected.Token(Token = "0x4006109")]
		public const short DemonConch = 4819;

		[global::Cpp2ILInjected.Token(Token = "0x400610A")]
		public const short BottomlessLavaBucket = 4820;

		[global::Cpp2ILInjected.Token(Token = "0x400610B")]
		public const short FireproofBugNet = 4821;

		[global::Cpp2ILInjected.Token(Token = "0x400610C")]
		public const short FlameWakerBoots = 4822;

		[global::Cpp2ILInjected.Token(Token = "0x400610D")]
		public const short RainbowWings = 4823;

		[global::Cpp2ILInjected.Token(Token = "0x400610E")]
		public const short WetBomb = 4824;

		[global::Cpp2ILInjected.Token(Token = "0x400610F")]
		public const short LavaBomb = 4825;

		[global::Cpp2ILInjected.Token(Token = "0x4006110")]
		public const short HoneyBomb = 4826;

		[global::Cpp2ILInjected.Token(Token = "0x4006111")]
		public const short DryBomb = 4827;

		[global::Cpp2ILInjected.Token(Token = "0x4006112")]
		public const short SuperheatedBlood = 4828;

		[global::Cpp2ILInjected.Token(Token = "0x4006113")]
		public const short LicenseCat = 4829;

		[global::Cpp2ILInjected.Token(Token = "0x4006114")]
		public const short LicenseDog = 4830;

		[global::Cpp2ILInjected.Token(Token = "0x4006115")]
		public const short GemSquirrelAmethyst = 4831;

		[global::Cpp2ILInjected.Token(Token = "0x4006116")]
		public const short GemSquirrelTopaz = 4832;

		[global::Cpp2ILInjected.Token(Token = "0x4006117")]
		public const short GemSquirrelSapphire = 4833;

		[global::Cpp2ILInjected.Token(Token = "0x4006118")]
		public const short GemSquirrelEmerald = 4834;

		[global::Cpp2ILInjected.Token(Token = "0x4006119")]
		public const short GemSquirrelRuby = 4835;

		[global::Cpp2ILInjected.Token(Token = "0x400611A")]
		public const short GemSquirrelDiamond = 4836;

		[global::Cpp2ILInjected.Token(Token = "0x400611B")]
		public const short GemSquirrelAmber = 4837;

		[global::Cpp2ILInjected.Token(Token = "0x400611C")]
		public const short GemBunnyAmethyst = 4838;

		[global::Cpp2ILInjected.Token(Token = "0x400611D")]
		public const short GemBunnyTopaz = 4839;

		[global::Cpp2ILInjected.Token(Token = "0x400611E")]
		public const short GemBunnySapphire = 4840;

		[global::Cpp2ILInjected.Token(Token = "0x400611F")]
		public const short GemBunnyEmerald = 4841;

		[global::Cpp2ILInjected.Token(Token = "0x4006120")]
		public const short GemBunnyRuby = 4842;

		[global::Cpp2ILInjected.Token(Token = "0x4006121")]
		public const short GemBunnyDiamond = 4843;

		[global::Cpp2ILInjected.Token(Token = "0x4006122")]
		public const short GemBunnyAmber = 4844;

		[global::Cpp2ILInjected.Token(Token = "0x4006123")]
		public const short HellButterfly = 4845;

		[global::Cpp2ILInjected.Token(Token = "0x4006124")]
		public const short HellButterflyJar = 4846;

		[global::Cpp2ILInjected.Token(Token = "0x4006125")]
		public const short Lavafly = 4847;

		[global::Cpp2ILInjected.Token(Token = "0x4006126")]
		public const short LavaflyinaBottle = 4848;

		[global::Cpp2ILInjected.Token(Token = "0x4006127")]
		public const short MagmaSnail = 4849;

		[global::Cpp2ILInjected.Token(Token = "0x4006128")]
		public const short MagmaSnailCage = 4850;

		[global::Cpp2ILInjected.Token(Token = "0x4006129")]
		public const short GemTreeTopazSeed = 4851;

		[global::Cpp2ILInjected.Token(Token = "0x400612A")]
		public const short GemTreeAmethystSeed = 4852;

		[global::Cpp2ILInjected.Token(Token = "0x400612B")]
		public const short GemTreeSapphireSeed = 4853;

		[global::Cpp2ILInjected.Token(Token = "0x400612C")]
		public const short GemTreeEmeraldSeed = 4854;

		[global::Cpp2ILInjected.Token(Token = "0x400612D")]
		public const short GemTreeRubySeed = 4855;

		[global::Cpp2ILInjected.Token(Token = "0x400612E")]
		public const short GemTreeDiamondSeed = 4856;

		[global::Cpp2ILInjected.Token(Token = "0x400612F")]
		public const short GemTreeAmberSeed = 4857;

		[global::Cpp2ILInjected.Token(Token = "0x4006130")]
		public const short PotSuspended = 4858;

		[global::Cpp2ILInjected.Token(Token = "0x4006131")]
		public const short PotSuspendedDaybloom = 4859;

		[global::Cpp2ILInjected.Token(Token = "0x4006132")]
		public const short PotSuspendedMoonglow = 4860;

		[global::Cpp2ILInjected.Token(Token = "0x4006133")]
		public const short PotSuspendedWaterleaf = 4861;

		[global::Cpp2ILInjected.Token(Token = "0x4006134")]
		public const short PotSuspendedShiverthorn = 4862;

		[global::Cpp2ILInjected.Token(Token = "0x4006135")]
		public const short PotSuspendedBlinkroot = 4863;

		[global::Cpp2ILInjected.Token(Token = "0x4006136")]
		public const short PotSuspendedDeathweedCorrupt = 4864;

		[global::Cpp2ILInjected.Token(Token = "0x4006137")]
		public const short PotSuspendedDeathweedCrimson = 4865;

		[global::Cpp2ILInjected.Token(Token = "0x4006138")]
		public const short PotSuspendedFireblossom = 4866;

		[global::Cpp2ILInjected.Token(Token = "0x4006139")]
		public const short BrazierSuspended = 4867;

		[global::Cpp2ILInjected.Token(Token = "0x400613A")]
		public const short VolcanoSmall = 4868;

		[global::Cpp2ILInjected.Token(Token = "0x400613B")]
		public const short VolcanoLarge = 4869;

		[global::Cpp2ILInjected.Token(Token = "0x400613C")]
		public const short PotionOfReturn = 4870;

		[global::Cpp2ILInjected.Token(Token = "0x400613D")]
		public const short VanityTreeSakuraSeed = 4871;

		[global::Cpp2ILInjected.Token(Token = "0x400613E")]
		public const short LavaAbsorbantSponge = 4872;

		[global::Cpp2ILInjected.Token(Token = "0x400613F")]
		public const short HallowedHood = 4873;

		[global::Cpp2ILInjected.Token(Token = "0x4006140")]
		public const short HellfireTreads = 4874;

		[global::Cpp2ILInjected.Token(Token = "0x4006141")]
		public const short TeleportationPylonJungle = 4875;

		[global::Cpp2ILInjected.Token(Token = "0x4006142")]
		public const short TeleportationPylonPurity = 4876;

		[global::Cpp2ILInjected.Token(Token = "0x4006143")]
		public const short LavaCrate = 4877;

		[global::Cpp2ILInjected.Token(Token = "0x4006144")]
		public const short LavaCrateHard = 4878;

		[global::Cpp2ILInjected.Token(Token = "0x4006145")]
		public const short ObsidianLockbox = 4879;

		[global::Cpp2ILInjected.Token(Token = "0x4006146")]
		public const short LavaFishbowl = 4880;

		[global::Cpp2ILInjected.Token(Token = "0x4006147")]
		public const short LavaFishingHook = 4881;

		[global::Cpp2ILInjected.Token(Token = "0x4006148")]
		public const short AmethystBunnyCage = 4882;

		[global::Cpp2ILInjected.Token(Token = "0x4006149")]
		public const short TopazBunnyCage = 4883;

		[global::Cpp2ILInjected.Token(Token = "0x400614A")]
		public const short SapphireBunnyCage = 4884;

		[global::Cpp2ILInjected.Token(Token = "0x400614B")]
		public const short EmeraldBunnyCage = 4885;

		[global::Cpp2ILInjected.Token(Token = "0x400614C")]
		public const short RubyBunnyCage = 4886;

		[global::Cpp2ILInjected.Token(Token = "0x400614D")]
		public const short DiamondBunnyCage = 4887;

		[global::Cpp2ILInjected.Token(Token = "0x400614E")]
		public const short AmberBunnyCage = 4888;

		[global::Cpp2ILInjected.Token(Token = "0x400614F")]
		public const short AmethystSquirrelCage = 4889;

		[global::Cpp2ILInjected.Token(Token = "0x4006150")]
		public const short TopazSquirrelCage = 4890;

		[global::Cpp2ILInjected.Token(Token = "0x4006151")]
		public const short SapphireSquirrelCage = 4891;

		[global::Cpp2ILInjected.Token(Token = "0x4006152")]
		public const short EmeraldSquirrelCage = 4892;

		[global::Cpp2ILInjected.Token(Token = "0x4006153")]
		public const short RubySquirrelCage = 4893;

		[global::Cpp2ILInjected.Token(Token = "0x4006154")]
		public const short DiamondSquirrelCage = 4894;

		[global::Cpp2ILInjected.Token(Token = "0x4006155")]
		public const short AmberSquirrelCage = 4895;

		[global::Cpp2ILInjected.Token(Token = "0x4006156")]
		public const short AncientHallowedMask = 4896;

		[global::Cpp2ILInjected.Token(Token = "0x4006157")]
		public const short AncientHallowedHelmet = 4897;

		[global::Cpp2ILInjected.Token(Token = "0x4006158")]
		public const short AncientHallowedHeadgear = 4898;

		[global::Cpp2ILInjected.Token(Token = "0x4006159")]
		public const short AncientHallowedHood = 4899;

		[global::Cpp2ILInjected.Token(Token = "0x400615A")]
		public const short AncientHallowedPlateMail = 4900;

		[global::Cpp2ILInjected.Token(Token = "0x400615B")]
		public const short AncientHallowedGreaves = 4901;

		[global::Cpp2ILInjected.Token(Token = "0x400615C")]
		public const short PottedLavaPlantPalm = 4902;

		[global::Cpp2ILInjected.Token(Token = "0x400615D")]
		public const short PottedLavaPlantBush = 4903;

		[global::Cpp2ILInjected.Token(Token = "0x400615E")]
		public const short PottedLavaPlantBramble = 4904;

		[global::Cpp2ILInjected.Token(Token = "0x400615F")]
		public const short PottedLavaPlantBulb = 4905;

		[global::Cpp2ILInjected.Token(Token = "0x4006160")]
		public const short PottedLavaPlantTendrils = 4906;

		[global::Cpp2ILInjected.Token(Token = "0x4006161")]
		public const short VanityTreeYellowWillowSeed = 4907;

		[global::Cpp2ILInjected.Token(Token = "0x4006162")]
		public const short DirtBomb = 4908;

		[global::Cpp2ILInjected.Token(Token = "0x4006163")]
		public const short DirtStickyBomb = 4909;

		[global::Cpp2ILInjected.Token(Token = "0x4006164")]
		public const short LicenseBunny = 4910;

		[global::Cpp2ILInjected.Token(Token = "0x4006165")]
		public const short CoolWhip = 4911;

		[global::Cpp2ILInjected.Token(Token = "0x4006166")]
		public const short FireWhip = 4912;

		[global::Cpp2ILInjected.Token(Token = "0x4006167")]
		public const short ThornWhip = 4913;

		[global::Cpp2ILInjected.Token(Token = "0x4006168")]
		public const short RainbowWhip = 4914;

		[global::Cpp2ILInjected.Token(Token = "0x4006169")]
		public const short TungstenBullet = 4915;

		[global::Cpp2ILInjected.Token(Token = "0x400616A")]
		public const short TeleportationPylonHallow = 4916;

		[global::Cpp2ILInjected.Token(Token = "0x400616B")]
		public const short TeleportationPylonUnderground = 4917;

		[global::Cpp2ILInjected.Token(Token = "0x400616C")]
		public const short TeleportationPylonOcean = 4918;

		[global::Cpp2ILInjected.Token(Token = "0x400616D")]
		public const short TeleportationPylonDesert = 4919;

		[global::Cpp2ILInjected.Token(Token = "0x400616E")]
		public const short TeleportationPylonSnow = 4920;

		[global::Cpp2ILInjected.Token(Token = "0x400616F")]
		public const short TeleportationPylonMushroom = 4921;

		[global::Cpp2ILInjected.Token(Token = "0x4006170")]
		public const short CavernFountain = 4922;

		[global::Cpp2ILInjected.Token(Token = "0x4006171")]
		public const short PiercingStarlight = 4923;

		[global::Cpp2ILInjected.Token(Token = "0x4006172")]
		public const short EyeofCthulhuMasterTrophy = 4924;

		[global::Cpp2ILInjected.Token(Token = "0x4006173")]
		public const short EaterofWorldsMasterTrophy = 4925;

		[global::Cpp2ILInjected.Token(Token = "0x4006174")]
		public const short BrainofCthulhuMasterTrophy = 4926;

		[global::Cpp2ILInjected.Token(Token = "0x4006175")]
		public const short SkeletronMasterTrophy = 4927;

		[global::Cpp2ILInjected.Token(Token = "0x4006176")]
		public const short QueenBeeMasterTrophy = 4928;

		[global::Cpp2ILInjected.Token(Token = "0x4006177")]
		public const short KingSlimeMasterTrophy = 4929;

		[global::Cpp2ILInjected.Token(Token = "0x4006178")]
		public const short WallofFleshMasterTrophy = 4930;

		[global::Cpp2ILInjected.Token(Token = "0x4006179")]
		public const short TwinsMasterTrophy = 4931;

		[global::Cpp2ILInjected.Token(Token = "0x400617A")]
		public const short DestroyerMasterTrophy = 4932;

		[global::Cpp2ILInjected.Token(Token = "0x400617B")]
		public const short SkeletronPrimeMasterTrophy = 4933;

		[global::Cpp2ILInjected.Token(Token = "0x400617C")]
		public const short PlanteraMasterTrophy = 4934;

		[global::Cpp2ILInjected.Token(Token = "0x400617D")]
		public const short GolemMasterTrophy = 4935;

		[global::Cpp2ILInjected.Token(Token = "0x400617E")]
		public const short DukeFishronMasterTrophy = 4936;

		[global::Cpp2ILInjected.Token(Token = "0x400617F")]
		public const short LunaticCultistMasterTrophy = 4937;

		[global::Cpp2ILInjected.Token(Token = "0x4006180")]
		public const short MoonLordMasterTrophy = 4938;

		[global::Cpp2ILInjected.Token(Token = "0x4006181")]
		public const short UFOMasterTrophy = 4939;

		[global::Cpp2ILInjected.Token(Token = "0x4006182")]
		public const short FlyingDutchmanMasterTrophy = 4940;

		[global::Cpp2ILInjected.Token(Token = "0x4006183")]
		public const short MourningWoodMasterTrophy = 4941;

		[global::Cpp2ILInjected.Token(Token = "0x4006184")]
		public const short PumpkingMasterTrophy = 4942;

		[global::Cpp2ILInjected.Token(Token = "0x4006185")]
		public const short IceQueenMasterTrophy = 4943;

		[global::Cpp2ILInjected.Token(Token = "0x4006186")]
		public const short EverscreamMasterTrophy = 4944;

		[global::Cpp2ILInjected.Token(Token = "0x4006187")]
		public const short SantankMasterTrophy = 4945;

		[global::Cpp2ILInjected.Token(Token = "0x4006188")]
		public const short DarkMageMasterTrophy = 4946;

		[global::Cpp2ILInjected.Token(Token = "0x4006189")]
		public const short OgreMasterTrophy = 4947;

		[global::Cpp2ILInjected.Token(Token = "0x400618A")]
		public const short BetsyMasterTrophy = 4948;

		[global::Cpp2ILInjected.Token(Token = "0x400618B")]
		public const short FairyQueenMasterTrophy = 4949;

		[global::Cpp2ILInjected.Token(Token = "0x400618C")]
		public const short QueenSlimeMasterTrophy = 4950;

		[global::Cpp2ILInjected.Token(Token = "0x400618D")]
		public const short TeleportationPylonVictory = 4951;

		[global::Cpp2ILInjected.Token(Token = "0x400618E")]
		public const short FairyQueenMagicItem = 4952;

		[global::Cpp2ILInjected.Token(Token = "0x400618F")]
		public const short FairyQueenRangedItem = 4953;

		[global::Cpp2ILInjected.Token(Token = "0x4006190")]
		public const short LongRainbowTrailWings = 4954;

		[global::Cpp2ILInjected.Token(Token = "0x4006191")]
		public const short RabbitOrder = 4955;

		[global::Cpp2ILInjected.Token(Token = "0x4006192")]
		public const short Zenith = 4956;

		[global::Cpp2ILInjected.Token(Token = "0x4006193")]
		public const short QueenSlimeBossBag = 4957;

		[global::Cpp2ILInjected.Token(Token = "0x4006194")]
		public const short QueenSlimeTrophy = 4958;

		[global::Cpp2ILInjected.Token(Token = "0x4006195")]
		public const short QueenSlimeMask = 4959;

		[global::Cpp2ILInjected.Token(Token = "0x4006196")]
		public const short QueenSlimePetItem = 4960;

		[global::Cpp2ILInjected.Token(Token = "0x4006197")]
		public const short EmpressButterfly = 4961;

		[global::Cpp2ILInjected.Token(Token = "0x4006198")]
		public const short AccentSlab = 4962;

		[global::Cpp2ILInjected.Token(Token = "0x4006199")]
		public const short TruffleWormCage = 4963;

		[global::Cpp2ILInjected.Token(Token = "0x400619A")]
		public const short EmpressButterflyJar = 4964;

		[global::Cpp2ILInjected.Token(Token = "0x400619B")]
		public const short RockGolemBanner = 4965;

		[global::Cpp2ILInjected.Token(Token = "0x400619C")]
		public const short BloodMummyBanner = 4966;

		[global::Cpp2ILInjected.Token(Token = "0x400619D")]
		public const short SporeSkeletonBanner = 4967;

		[global::Cpp2ILInjected.Token(Token = "0x400619E")]
		public const short SporeBatBanner = 4968;

		[global::Cpp2ILInjected.Token(Token = "0x400619F")]
		public const short LarvaeAntlionBanner = 4969;

		[global::Cpp2ILInjected.Token(Token = "0x40061A0")]
		public const short CrimsonBunnyBanner = 4970;

		[global::Cpp2ILInjected.Token(Token = "0x40061A1")]
		public const short CrimsonGoldfishBanner = 4971;

		[global::Cpp2ILInjected.Token(Token = "0x40061A2")]
		public const short CrimsonPenguinBanner = 4972;

		[global::Cpp2ILInjected.Token(Token = "0x40061A3")]
		public const short BigMimicCorruptionBanner = 4973;

		[global::Cpp2ILInjected.Token(Token = "0x40061A4")]
		public const short BigMimicCrimsonBanner = 4974;

		[global::Cpp2ILInjected.Token(Token = "0x40061A5")]
		public const short BigMimicHallowBanner = 4975;

		[global::Cpp2ILInjected.Token(Token = "0x40061A6")]
		public const short MossHornetBanner = 4976;

		[global::Cpp2ILInjected.Token(Token = "0x40061A7")]
		public const short WanderingEyeBanner = 4977;

		[global::Cpp2ILInjected.Token(Token = "0x40061A8")]
		public const short CreativeWings = 4978;

		[global::Cpp2ILInjected.Token(Token = "0x40061A9")]
		public const short MusicBoxQueenSlime = 4979;

		[global::Cpp2ILInjected.Token(Token = "0x40061AA")]
		public const short QueenSlimeHook = 4980;

		[global::Cpp2ILInjected.Token(Token = "0x40061AB")]
		public const short QueenSlimeMountSaddle = 4981;

		[global::Cpp2ILInjected.Token(Token = "0x40061AC")]
		public const short CrystalNinjaHelmet = 4982;

		[global::Cpp2ILInjected.Token(Token = "0x40061AD")]
		public const short CrystalNinjaChestplate = 4983;

		[global::Cpp2ILInjected.Token(Token = "0x40061AE")]
		public const short CrystalNinjaLeggings = 4984;

		[global::Cpp2ILInjected.Token(Token = "0x40061AF")]
		public const short MusicBoxEmpressOfLight = 4985;

		[global::Cpp2ILInjected.Token(Token = "0x40061B0")]
		public const short GelBalloon = 4986;

		[global::Cpp2ILInjected.Token(Token = "0x40061B1")]
		public const short VolatileGelatin = 4987;

		[global::Cpp2ILInjected.Token(Token = "0x40061B2")]
		public const short QueenSlimeCrystal = 4988;

		[global::Cpp2ILInjected.Token(Token = "0x40061B3")]
		public const short EmpressFlightBooster = 4989;

		[global::Cpp2ILInjected.Token(Token = "0x40061B4")]
		public const short MusicBoxDukeFishron = 4990;

		[global::Cpp2ILInjected.Token(Token = "0x40061B5")]
		public const short MusicBoxMorningRain = 4991;

		[global::Cpp2ILInjected.Token(Token = "0x40061B6")]
		public const short MusicBoxConsoleTitle = 4992;

		[global::Cpp2ILInjected.Token(Token = "0x40061B7")]
		public const short ChippysCouch = 4993;

		[global::Cpp2ILInjected.Token(Token = "0x40061B8")]
		public const short GraduationCapBlue = 4994;

		[global::Cpp2ILInjected.Token(Token = "0x40061B9")]
		public const short GraduationCapMaroon = 4995;

		[global::Cpp2ILInjected.Token(Token = "0x40061BA")]
		public const short GraduationCapBlack = 4996;

		[global::Cpp2ILInjected.Token(Token = "0x40061BB")]
		public const short GraduationGownBlue = 4997;

		[global::Cpp2ILInjected.Token(Token = "0x40061BC")]
		public const short GraduationGownMaroon = 4998;

		[global::Cpp2ILInjected.Token(Token = "0x40061BD")]
		public const short GraduationGownBlack = 4999;

		[global::Cpp2ILInjected.Token(Token = "0x40061BE")]
		public const short TerrasparkBoots = 5000;

		[global::Cpp2ILInjected.Token(Token = "0x40061BF")]
		public const short MoonLordLegs = 5001;

		[global::Cpp2ILInjected.Token(Token = "0x40061C0")]
		public const short OceanCrate = 5002;

		[global::Cpp2ILInjected.Token(Token = "0x40061C1")]
		public const short OceanCrateHard = 5003;

		[global::Cpp2ILInjected.Token(Token = "0x40061C2")]
		public const short BadgersHat = 5004;

		[global::Cpp2ILInjected.Token(Token = "0x40061C3")]
		public const short EmpressBlade = 5005;

		[global::Cpp2ILInjected.Token(Token = "0x40061C4")]
		public const short MusicBoxUndergroundDesert = 5006;

		[global::Cpp2ILInjected.Token(Token = "0x40061C5")]
		public const short DeadMansSweater = 5007;

		[global::Cpp2ILInjected.Token(Token = "0x40061C6")]
		public const short TeaKettle = 5008;

		[global::Cpp2ILInjected.Token(Token = "0x40061C7")]
		public const short Teacup = 5009;

		[global::Cpp2ILInjected.Token(Token = "0x40061C8")]
		public const short TreasureMagnet = 5010;

		[global::Cpp2ILInjected.Token(Token = "0x40061C9")]
		public const short Mace = 5011;

		[global::Cpp2ILInjected.Token(Token = "0x40061CA")]
		public const short FlamingMace = 5012;

		[global::Cpp2ILInjected.Token(Token = "0x40061CB")]
		public const short SleepingIcon = 5013;

		[global::Cpp2ILInjected.Token(Token = "0x40061CC")]
		public const short MusicBoxOWRain = 5014;

		[global::Cpp2ILInjected.Token(Token = "0x40061CD")]
		public const short MusicBoxOWDay = 5015;

		[global::Cpp2ILInjected.Token(Token = "0x40061CE")]
		public const short MusicBoxOWNight = 5016;

		[global::Cpp2ILInjected.Token(Token = "0x40061CF")]
		public const short MusicBoxOWUnderground = 5017;

		[global::Cpp2ILInjected.Token(Token = "0x40061D0")]
		public const short MusicBoxOWDesert = 5018;

		[global::Cpp2ILInjected.Token(Token = "0x40061D1")]
		public const short MusicBoxOWOcean = 5019;

		[global::Cpp2ILInjected.Token(Token = "0x40061D2")]
		public const short MusicBoxOWMushroom = 5020;

		[global::Cpp2ILInjected.Token(Token = "0x40061D3")]
		public const short MusicBoxOWDungeon = 5021;

		[global::Cpp2ILInjected.Token(Token = "0x40061D4")]
		public const short MusicBoxOWSpace = 5022;

		[global::Cpp2ILInjected.Token(Token = "0x40061D5")]
		public const short MusicBoxOWUnderworld = 5023;

		[global::Cpp2ILInjected.Token(Token = "0x40061D6")]
		public const short MusicBoxOWSnow = 5024;

		[global::Cpp2ILInjected.Token(Token = "0x40061D7")]
		public const short MusicBoxOWCorruption = 5025;

		[global::Cpp2ILInjected.Token(Token = "0x40061D8")]
		public const short MusicBoxOWUndergroundCorruption = 5026;

		[global::Cpp2ILInjected.Token(Token = "0x40061D9")]
		public const short MusicBoxOWCrimson = 5027;

		[global::Cpp2ILInjected.Token(Token = "0x40061DA")]
		public const short MusicBoxOWUndergroundCrimson = 5028;

		[global::Cpp2ILInjected.Token(Token = "0x40061DB")]
		public const short MusicBoxOWUndergroundSnow = 5029;

		[global::Cpp2ILInjected.Token(Token = "0x40061DC")]
		public const short MusicBoxOWUndergroundHallow = 5030;

		[global::Cpp2ILInjected.Token(Token = "0x40061DD")]
		public const short MusicBoxOWBloodMoon = 5031;

		[global::Cpp2ILInjected.Token(Token = "0x40061DE")]
		public const short MusicBoxOWBoss2 = 5032;

		[global::Cpp2ILInjected.Token(Token = "0x40061DF")]
		public const short MusicBoxOWBoss1 = 5033;

		[global::Cpp2ILInjected.Token(Token = "0x40061E0")]
		public const short MusicBoxOWInvasion = 5034;

		[global::Cpp2ILInjected.Token(Token = "0x40061E1")]
		public const short MusicBoxOWTowers = 5035;

		[global::Cpp2ILInjected.Token(Token = "0x40061E2")]
		public const short MusicBoxOWMoonLord = 5036;

		[global::Cpp2ILInjected.Token(Token = "0x40061E3")]
		public const short MusicBoxOWPlantera = 5037;

		[global::Cpp2ILInjected.Token(Token = "0x40061E4")]
		public const short MusicBoxOWJungle = 5038;

		[global::Cpp2ILInjected.Token(Token = "0x40061E5")]
		public const short MusicBoxOWWallOfFlesh = 5039;

		[global::Cpp2ILInjected.Token(Token = "0x40061E6")]
		public const short MusicBoxOWHallow = 5040;

		[global::Cpp2ILInjected.Token(Token = "0x40061E7")]
		public const short MilkCarton = 5041;

		[global::Cpp2ILInjected.Token(Token = "0x40061E8")]
		public const short CoffeeCup = 5042;

		[global::Cpp2ILInjected.Token(Token = "0x40061E9")]
		public const short TorchGodsFavor = 5043;

		[global::Cpp2ILInjected.Token(Token = "0x40061EA")]
		public const short MusicBoxCredits = 5044;

		[global::Cpp2ILInjected.Token(Token = "0x40061EB")]
		public const short PlaguebringerHelmet = 5045;

		[global::Cpp2ILInjected.Token(Token = "0x40061EC")]
		public const short PlaguebringerChestplate = 5046;

		[global::Cpp2ILInjected.Token(Token = "0x40061ED")]
		public const short PlaguebringerGreaves = 5047;

		[global::Cpp2ILInjected.Token(Token = "0x40061EE")]
		public const short RoninHat = 5048;

		[global::Cpp2ILInjected.Token(Token = "0x40061EF")]
		public const short RoninShirt = 5049;

		[global::Cpp2ILInjected.Token(Token = "0x40061F0")]
		public const short RoninPants = 5050;

		[global::Cpp2ILInjected.Token(Token = "0x40061F1")]
		public const short TimelessTravelerHood = 5051;

		[global::Cpp2ILInjected.Token(Token = "0x40061F2")]
		public const short TimelessTravelerRobe = 5052;

		[global::Cpp2ILInjected.Token(Token = "0x40061F3")]
		public const short TimelessTravelerBottom = 5053;

		[global::Cpp2ILInjected.Token(Token = "0x40061F4")]
		public const short FloretProtectorHelmet = 5054;

		[global::Cpp2ILInjected.Token(Token = "0x40061F5")]
		public const short FloretProtectorChestplate = 5055;

		[global::Cpp2ILInjected.Token(Token = "0x40061F6")]
		public const short FloretProtectorLegs = 5056;

		[global::Cpp2ILInjected.Token(Token = "0x40061F7")]
		public const short CapricornMask = 5057;

		[global::Cpp2ILInjected.Token(Token = "0x40061F8")]
		public const short CapricornChestplate = 5058;

		[global::Cpp2ILInjected.Token(Token = "0x40061F9")]
		public const short CapricornLegs = 5059;

		[global::Cpp2ILInjected.Token(Token = "0x40061FA")]
		public const short CapricornTail = 5060;

		[global::Cpp2ILInjected.Token(Token = "0x40061FB")]
		public const short TVHeadMask = 5061;

		[global::Cpp2ILInjected.Token(Token = "0x40061FC")]
		public const short TVHeadSuit = 5062;

		[global::Cpp2ILInjected.Token(Token = "0x40061FD")]
		public const short TVHeadPants = 5063;

		[global::Cpp2ILInjected.Token(Token = "0x40061FE")]
		public const short LavaproofTackleBag = 5064;

		[global::Cpp2ILInjected.Token(Token = "0x40061FF")]
		public const short PrincessWeapon = 5065;

		[global::Cpp2ILInjected.Token(Token = "0x4006200")]
		public const short BeeHive = 5066;

		[global::Cpp2ILInjected.Token(Token = "0x4006201")]
		public const short AntlionEggs = 5067;

		[global::Cpp2ILInjected.Token(Token = "0x4006202")]
		public const short FlinxFurCoat = 5068;

		[global::Cpp2ILInjected.Token(Token = "0x4006203")]
		public const short FlinxStaff = 5069;

		[global::Cpp2ILInjected.Token(Token = "0x4006204")]
		public const short FlinxFur = 5070;

		[global::Cpp2ILInjected.Token(Token = "0x4006205")]
		public const short RoyalTiara = 5071;

		[global::Cpp2ILInjected.Token(Token = "0x4006206")]
		public const short RoyalDressTop = 5072;

		[global::Cpp2ILInjected.Token(Token = "0x4006207")]
		public const short RoyalDressBottom = 5073;

		[global::Cpp2ILInjected.Token(Token = "0x4006208")]
		public const short BoneWhip = 5074;

		[global::Cpp2ILInjected.Token(Token = "0x4006209")]
		public const short RainbowCursor = 5075;

		[global::Cpp2ILInjected.Token(Token = "0x400620A")]
		public const short RoyalScepter = 5076;

		[global::Cpp2ILInjected.Token(Token = "0x400620B")]
		public const short GlassSlipper = 5077;

		[global::Cpp2ILInjected.Token(Token = "0x400620C")]
		public const short PrinceUniform = 5078;

		[global::Cpp2ILInjected.Token(Token = "0x400620D")]
		public const short PrincePants = 5079;

		[global::Cpp2ILInjected.Token(Token = "0x400620E")]
		public const short PrinceCape = 5080;

		[global::Cpp2ILInjected.Token(Token = "0x400620F")]
		public const short PottedCrystalPlantFern = 5081;

		[global::Cpp2ILInjected.Token(Token = "0x4006210")]
		public const short PottedCrystalPlantSpiral = 5082;

		[global::Cpp2ILInjected.Token(Token = "0x4006211")]
		public const short PottedCrystalPlantTeardrop = 5083;

		[global::Cpp2ILInjected.Token(Token = "0x4006212")]
		public const short PottedCrystalPlantTree = 5084;

		[global::Cpp2ILInjected.Token(Token = "0x4006213")]
		public const short Princess64 = 5085;

		[global::Cpp2ILInjected.Token(Token = "0x4006214")]
		public const short PaintingOfALass = 5086;

		[global::Cpp2ILInjected.Token(Token = "0x4006215")]
		public const short DarkSideHallow = 5087;

		[global::Cpp2ILInjected.Token(Token = "0x4006216")]
		public const short BerniePetItem = 5088;

		[global::Cpp2ILInjected.Token(Token = "0x4006217")]
		public const short GlommerPetItem = 5089;

		[global::Cpp2ILInjected.Token(Token = "0x4006218")]
		public const short DeerclopsPetItem = 5090;

		[global::Cpp2ILInjected.Token(Token = "0x4006219")]
		public const short PigPetItem = 5091;

		[global::Cpp2ILInjected.Token(Token = "0x400621A")]
		public const short MonsterLasagna = 5092;

		[global::Cpp2ILInjected.Token(Token = "0x400621B")]
		public const short FroggleBunwich = 5093;

		[global::Cpp2ILInjected.Token(Token = "0x400621C")]
		public const short TentacleSpike = 5094;

		[global::Cpp2ILInjected.Token(Token = "0x400621D")]
		public const short LucyTheAxe = 5095;

		[global::Cpp2ILInjected.Token(Token = "0x400621E")]
		public const short HamBat = 5096;

		[global::Cpp2ILInjected.Token(Token = "0x400621F")]
		public const short BatBat = 5097;

		[global::Cpp2ILInjected.Token(Token = "0x4006220")]
		public const short ChesterPetItem = 5098;

		[global::Cpp2ILInjected.Token(Token = "0x4006221")]
		public const short GarlandHat = 5099;

		[global::Cpp2ILInjected.Token(Token = "0x4006222")]
		public const short BoneHelm = 5100;

		[global::Cpp2ILInjected.Token(Token = "0x4006223")]
		public const short Eyebrella = 5101;

		[global::Cpp2ILInjected.Token(Token = "0x4006224")]
		public const short WilsonShirt = 5102;

		[global::Cpp2ILInjected.Token(Token = "0x4006225")]
		public const short WilsonPants = 5103;

		[global::Cpp2ILInjected.Token(Token = "0x4006226")]
		public const short WilsonBeardShort = 5104;

		[global::Cpp2ILInjected.Token(Token = "0x4006227")]
		public const short WilsonBeardLong = 5105;

		[global::Cpp2ILInjected.Token(Token = "0x4006228")]
		public const short WilsonBeardMagnificent = 5106;

		[global::Cpp2ILInjected.Token(Token = "0x4006229")]
		public const short Magiluminescence = 5107;

		[global::Cpp2ILInjected.Token(Token = "0x400622A")]
		public const short DeerclopsTrophy = 5108;

		[global::Cpp2ILInjected.Token(Token = "0x400622B")]
		public const short DeerclopsMask = 5109;

		[global::Cpp2ILInjected.Token(Token = "0x400622C")]
		public const short DeerclopsMasterTrophy = 5110;

		[global::Cpp2ILInjected.Token(Token = "0x400622D")]
		public const short DeerclopsBossBag = 5111;

		[global::Cpp2ILInjected.Token(Token = "0x400622E")]
		public const short MusicBoxDeerclops = 5112;

		[global::Cpp2ILInjected.Token(Token = "0x400622F")]
		public const short DontStarveShaderItem = 5113;

		[global::Cpp2ILInjected.Token(Token = "0x4006230")]
		public const short AbigailsFlower = 5114;

		[global::Cpp2ILInjected.Token(Token = "0x4006231")]
		public const short WillowShirt = 5115;

		[global::Cpp2ILInjected.Token(Token = "0x4006232")]
		public const short WillowSkirt = 5116;

		[global::Cpp2ILInjected.Token(Token = "0x4006233")]
		public const short PewMaticHorn = 5117;

		[global::Cpp2ILInjected.Token(Token = "0x4006234")]
		public const short WeatherPain = 5118;

		[global::Cpp2ILInjected.Token(Token = "0x4006235")]
		public const short HoundiusShootius = 5119;

		[global::Cpp2ILInjected.Token(Token = "0x4006236")]
		public const short DeerThing = 5120;

		[global::Cpp2ILInjected.Token(Token = "0x4006237")]
		public const short PaintingWilson = 5121;

		[global::Cpp2ILInjected.Token(Token = "0x4006238")]
		public const short PaintingWillow = 5122;

		[global::Cpp2ILInjected.Token(Token = "0x4006239")]
		public const short PaintingWendy = 5123;

		[global::Cpp2ILInjected.Token(Token = "0x400623A")]
		public const short PaintingWolfgang = 5124;

		[global::Cpp2ILInjected.Token(Token = "0x400623B")]
		public const short FartMinecart = 5125;

		[global::Cpp2ILInjected.Token(Token = "0x400623C")]
		public const short HandOfCreation = 5126;

		[global::Cpp2ILInjected.Token(Token = "0x400623D")]
		public const short VioletMoss = 5127;

		[global::Cpp2ILInjected.Token(Token = "0x400623E")]
		public const short RainbowMoss = 5128;

		[global::Cpp2ILInjected.Token(Token = "0x400623F")]
		public const short Flymeal = 5129;

		[global::Cpp2ILInjected.Token(Token = "0x4006240")]
		public const short WolfMountItem = 5130;

		[global::Cpp2ILInjected.Token(Token = "0x4006241")]
		public const short ResplendentDessert = 5131;

		[global::Cpp2ILInjected.Token(Token = "0x4006242")]
		public const short Stinkbug = 5132;

		[global::Cpp2ILInjected.Token(Token = "0x4006243")]
		public const short StinkbugCage = 5133;

		[global::Cpp2ILInjected.Token(Token = "0x4006244")]
		public const short Clentaminator2 = 5134;

		[global::Cpp2ILInjected.Token(Token = "0x4006245")]
		public const short VenomDartTrap = 5135;

		[global::Cpp2ILInjected.Token(Token = "0x4006246")]
		public const short VulkelfEar = 5136;

		[global::Cpp2ILInjected.Token(Token = "0x4006247")]
		public const short StinkbugHousingBlocker = 5137;

		[global::Cpp2ILInjected.Token(Token = "0x4006248")]
		public const short StinkbugHousingBlockerEcho = 5138;

		[global::Cpp2ILInjected.Token(Token = "0x4006249")]
		public const short FishingBobber = 5139;

		[global::Cpp2ILInjected.Token(Token = "0x400624A")]
		public const short FishingBobberGlowingStar = 5140;

		[global::Cpp2ILInjected.Token(Token = "0x400624B")]
		public const short FishingBobberGlowingLava = 5141;

		[global::Cpp2ILInjected.Token(Token = "0x400624C")]
		public const short FishingBobberGlowingKrypton = 5142;

		[global::Cpp2ILInjected.Token(Token = "0x400624D")]
		public const short FishingBobberGlowingXenon = 5143;

		[global::Cpp2ILInjected.Token(Token = "0x400624E")]
		public const short FishingBobberGlowingArgon = 5144;

		[global::Cpp2ILInjected.Token(Token = "0x400624F")]
		public const short FishingBobberGlowingViolet = 5145;

		[global::Cpp2ILInjected.Token(Token = "0x4006250")]
		public const short FishingBobberGlowingRainbow = 5146;

		[global::Cpp2ILInjected.Token(Token = "0x4006251")]
		public const short WandofFrosting = 5147;

		[global::Cpp2ILInjected.Token(Token = "0x4006252")]
		public const short CoralBathtub = 5148;

		[global::Cpp2ILInjected.Token(Token = "0x4006253")]
		public const short CoralBed = 5149;

		[global::Cpp2ILInjected.Token(Token = "0x4006254")]
		public const short CoralBookcase = 5150;

		[global::Cpp2ILInjected.Token(Token = "0x4006255")]
		public const short CoralDresser = 5151;

		[global::Cpp2ILInjected.Token(Token = "0x4006256")]
		public const short CoralCandelabra = 5152;

		[global::Cpp2ILInjected.Token(Token = "0x4006257")]
		public const short CoralCandle = 5153;

		[global::Cpp2ILInjected.Token(Token = "0x4006258")]
		public const short CoralChair = 5154;

		[global::Cpp2ILInjected.Token(Token = "0x4006259")]
		public const short CoralChandelier = 5155;

		[global::Cpp2ILInjected.Token(Token = "0x400625A")]
		public const short CoralChest = 5156;

		[global::Cpp2ILInjected.Token(Token = "0x400625B")]
		public const short CoralClock = 5157;

		[global::Cpp2ILInjected.Token(Token = "0x400625C")]
		public const short CoralDoor = 5158;

		[global::Cpp2ILInjected.Token(Token = "0x400625D")]
		public const short CoralLamp = 5159;

		[global::Cpp2ILInjected.Token(Token = "0x400625E")]
		public const short CoralLantern = 5160;

		[global::Cpp2ILInjected.Token(Token = "0x400625F")]
		public const short CoralPiano = 5161;

		[global::Cpp2ILInjected.Token(Token = "0x4006260")]
		public const short CoralPlatform = 5162;

		[global::Cpp2ILInjected.Token(Token = "0x4006261")]
		public const short CoralSink = 5163;

		[global::Cpp2ILInjected.Token(Token = "0x4006262")]
		public const short CoralSofa = 5164;

		[global::Cpp2ILInjected.Token(Token = "0x4006263")]
		public const short CoralTable = 5165;

		[global::Cpp2ILInjected.Token(Token = "0x4006264")]
		public const short CoralWorkbench = 5166;

		[global::Cpp2ILInjected.Token(Token = "0x4006265")]
		public const short Fake_CoralChest = 5167;

		[global::Cpp2ILInjected.Token(Token = "0x4006266")]
		public const short CoralToilet = 5168;

		[global::Cpp2ILInjected.Token(Token = "0x4006267")]
		public const short BalloonBathtub = 5169;

		[global::Cpp2ILInjected.Token(Token = "0x4006268")]
		public const short BalloonBed = 5170;

		[global::Cpp2ILInjected.Token(Token = "0x4006269")]
		public const short BalloonBookcase = 5171;

		[global::Cpp2ILInjected.Token(Token = "0x400626A")]
		public const short BalloonDresser = 5172;

		[global::Cpp2ILInjected.Token(Token = "0x400626B")]
		public const short BalloonCandelabra = 5173;

		[global::Cpp2ILInjected.Token(Token = "0x400626C")]
		public const short BalloonCandle = 5174;

		[global::Cpp2ILInjected.Token(Token = "0x400626D")]
		public const short BalloonChair = 5175;

		[global::Cpp2ILInjected.Token(Token = "0x400626E")]
		public const short BalloonChandelier = 5176;

		[global::Cpp2ILInjected.Token(Token = "0x400626F")]
		public const short BalloonChest = 5177;

		[global::Cpp2ILInjected.Token(Token = "0x4006270")]
		public const short BalloonClock = 5178;

		[global::Cpp2ILInjected.Token(Token = "0x4006271")]
		public const short BalloonDoor = 5179;

		[global::Cpp2ILInjected.Token(Token = "0x4006272")]
		public const short BalloonLamp = 5180;

		[global::Cpp2ILInjected.Token(Token = "0x4006273")]
		public const short BalloonLantern = 5181;

		[global::Cpp2ILInjected.Token(Token = "0x4006274")]
		public const short BalloonPiano = 5182;

		[global::Cpp2ILInjected.Token(Token = "0x4006275")]
		public const short BalloonPlatform = 5183;

		[global::Cpp2ILInjected.Token(Token = "0x4006276")]
		public const short BalloonSink = 5184;

		[global::Cpp2ILInjected.Token(Token = "0x4006277")]
		public const short BalloonSofa = 5185;

		[global::Cpp2ILInjected.Token(Token = "0x4006278")]
		public const short BalloonTable = 5186;

		[global::Cpp2ILInjected.Token(Token = "0x4006279")]
		public const short BalloonWorkbench = 5187;

		[global::Cpp2ILInjected.Token(Token = "0x400627A")]
		public const short Fake_BalloonChest = 5188;

		[global::Cpp2ILInjected.Token(Token = "0x400627B")]
		public const short BalloonToilet = 5189;

		[global::Cpp2ILInjected.Token(Token = "0x400627C")]
		public const short AshWoodBathtub = 5190;

		[global::Cpp2ILInjected.Token(Token = "0x400627D")]
		public const short AshWoodBed = 5191;

		[global::Cpp2ILInjected.Token(Token = "0x400627E")]
		public const short AshWoodBookcase = 5192;

		[global::Cpp2ILInjected.Token(Token = "0x400627F")]
		public const short AshWoodDresser = 5193;

		[global::Cpp2ILInjected.Token(Token = "0x4006280")]
		public const short AshWoodCandelabra = 5194;

		[global::Cpp2ILInjected.Token(Token = "0x4006281")]
		public const short AshWoodCandle = 5195;

		[global::Cpp2ILInjected.Token(Token = "0x4006282")]
		public const short AshWoodChair = 5196;

		[global::Cpp2ILInjected.Token(Token = "0x4006283")]
		public const short AshWoodChandelier = 5197;

		[global::Cpp2ILInjected.Token(Token = "0x4006284")]
		public const short AshWoodChest = 5198;

		[global::Cpp2ILInjected.Token(Token = "0x4006285")]
		public const short AshWoodClock = 5199;

		[global::Cpp2ILInjected.Token(Token = "0x4006286")]
		public const short AshWoodDoor = 5200;

		[global::Cpp2ILInjected.Token(Token = "0x4006287")]
		public const short AshWoodLamp = 5201;

		[global::Cpp2ILInjected.Token(Token = "0x4006288")]
		public const short AshWoodLantern = 5202;

		[global::Cpp2ILInjected.Token(Token = "0x4006289")]
		public const short AshWoodPiano = 5203;

		[global::Cpp2ILInjected.Token(Token = "0x400628A")]
		public const short AshWoodPlatform = 5204;

		[global::Cpp2ILInjected.Token(Token = "0x400628B")]
		public const short AshWoodSink = 5205;

		[global::Cpp2ILInjected.Token(Token = "0x400628C")]
		public const short AshWoodSofa = 5206;

		[global::Cpp2ILInjected.Token(Token = "0x400628D")]
		public const short AshWoodTable = 5207;

		[global::Cpp2ILInjected.Token(Token = "0x400628E")]
		public const short AshWoodWorkbench = 5208;

		[global::Cpp2ILInjected.Token(Token = "0x400628F")]
		public const short Fake_AshWoodChest = 5209;

		[global::Cpp2ILInjected.Token(Token = "0x4006290")]
		public const short AshWoodToilet = 5210;

		[global::Cpp2ILInjected.Token(Token = "0x4006291")]
		public const short BiomeSightPotion = 5211;

		[global::Cpp2ILInjected.Token(Token = "0x4006292")]
		public const short ScarletMacaw = 5212;

		[global::Cpp2ILInjected.Token(Token = "0x4006293")]
		public const short ScarletMacawCage = 5213;

		[global::Cpp2ILInjected.Token(Token = "0x4006294")]
		public const short AshGrassSeeds = 5214;

		[global::Cpp2ILInjected.Token(Token = "0x4006295")]
		public const short AshWood = 5215;

		[global::Cpp2ILInjected.Token(Token = "0x4006296")]
		public const short AshWoodWall = 5216;

		[global::Cpp2ILInjected.Token(Token = "0x4006297")]
		public const short AshWoodFence = 5217;

		[global::Cpp2ILInjected.Token(Token = "0x4006298")]
		public const short Outcast = 5218;

		[global::Cpp2ILInjected.Token(Token = "0x4006299")]
		public const short FairyGuides = 5219;

		[global::Cpp2ILInjected.Token(Token = "0x400629A")]
		public const short AHorribleNightforAlchemy = 5220;

		[global::Cpp2ILInjected.Token(Token = "0x400629B")]
		public const short MorningHunt = 5221;

		[global::Cpp2ILInjected.Token(Token = "0x400629C")]
		public const short SuspiciouslySparkly = 5222;

		[global::Cpp2ILInjected.Token(Token = "0x400629D")]
		public const short Requiem = 5223;

		[global::Cpp2ILInjected.Token(Token = "0x400629E")]
		public const short CatSword = 5224;

		[global::Cpp2ILInjected.Token(Token = "0x400629F")]
		public const short KargohsSummon = 5225;

		[global::Cpp2ILInjected.Token(Token = "0x40062A0")]
		public const short HighPitch = 5226;

		[global::Cpp2ILInjected.Token(Token = "0x40062A1")]
		public const short AMachineforTerrarians = 5227;

		[global::Cpp2ILInjected.Token(Token = "0x40062A2")]
		public const short TerraBladeChronicles = 5228;

		[global::Cpp2ILInjected.Token(Token = "0x40062A3")]
		public const short BennyWarhol = 5229;

		[global::Cpp2ILInjected.Token(Token = "0x40062A4")]
		public const short LizardKing = 5230;

		[global::Cpp2ILInjected.Token(Token = "0x40062A5")]
		public const short MySon = 5231;

		[global::Cpp2ILInjected.Token(Token = "0x40062A6")]
		public const short Duality = 5232;

		[global::Cpp2ILInjected.Token(Token = "0x40062A7")]
		public const short ParsecPals = 5233;

		[global::Cpp2ILInjected.Token(Token = "0x40062A8")]
		public const short RemnantsofDevotion = 5234;

		[global::Cpp2ILInjected.Token(Token = "0x40062A9")]
		public const short NotSoLostInParadise = 5235;

		[global::Cpp2ILInjected.Token(Token = "0x40062AA")]
		public const short OcularResonance = 5236;

		[global::Cpp2ILInjected.Token(Token = "0x40062AB")]
		public const short WingsofEvil = 5237;

		[global::Cpp2ILInjected.Token(Token = "0x40062AC")]
		public const short Constellation = 5238;

		[global::Cpp2ILInjected.Token(Token = "0x40062AD")]
		public const short Eyezorhead = 5239;

		[global::Cpp2ILInjected.Token(Token = "0x40062AE")]
		public const short DreadoftheRedSea = 5240;

		[global::Cpp2ILInjected.Token(Token = "0x40062AF")]
		public const short DoNotEattheVileMushroom = 5241;

		[global::Cpp2ILInjected.Token(Token = "0x40062B0")]
		public const short YuumaTheBlueTiger = 5242;

		[global::Cpp2ILInjected.Token(Token = "0x40062B1")]
		public const short MoonmanandCompany = 5243;

		[global::Cpp2ILInjected.Token(Token = "0x40062B2")]
		public const short SunshineofIsrapony = 5244;

		[global::Cpp2ILInjected.Token(Token = "0x40062B3")]
		public const short Purity = 5245;

		[global::Cpp2ILInjected.Token(Token = "0x40062B4")]
		public const short SufficientlyAdvanced = 5246;

		[global::Cpp2ILInjected.Token(Token = "0x40062B5")]
		public const short StrangeGrowth = 5247;

		[global::Cpp2ILInjected.Token(Token = "0x40062B6")]
		public const short HappyLittleTree = 5248;

		[global::Cpp2ILInjected.Token(Token = "0x40062B7")]
		public const short StrangeDeadFellows = 5249;

		[global::Cpp2ILInjected.Token(Token = "0x40062B8")]
		public const short Secrets = 5250;

		[global::Cpp2ILInjected.Token(Token = "0x40062B9")]
		public const short Thunderbolt = 5251;

		[global::Cpp2ILInjected.Token(Token = "0x40062BA")]
		public const short Crustography = 5252;

		[global::Cpp2ILInjected.Token(Token = "0x40062BB")]
		public const short TheWerewolf = 5253;

		[global::Cpp2ILInjected.Token(Token = "0x40062BC")]
		public const short BlessingfromTheHeavens = 5254;

		[global::Cpp2ILInjected.Token(Token = "0x40062BD")]
		public const short LoveisintheTrashSlot = 5255;

		[global::Cpp2ILInjected.Token(Token = "0x40062BE")]
		public const short Fangs = 5256;

		[global::Cpp2ILInjected.Token(Token = "0x40062BF")]
		public const short HailtotheKing = 5257;

		[global::Cpp2ILInjected.Token(Token = "0x40062C0")]
		public const short SeeTheWorldForWhatItIs = 5258;

		[global::Cpp2ILInjected.Token(Token = "0x40062C1")]
		public const short WhatLurksBelow = 5259;

		[global::Cpp2ILInjected.Token(Token = "0x40062C2")]
		public const short ThisIsGettingOutOfHand = 5260;

		[global::Cpp2ILInjected.Token(Token = "0x40062C3")]
		public const short Buddies = 5261;

		[global::Cpp2ILInjected.Token(Token = "0x40062C4")]
		public const short MidnightSun = 5262;

		[global::Cpp2ILInjected.Token(Token = "0x40062C5")]
		public const short CouchGag = 5263;

		[global::Cpp2ILInjected.Token(Token = "0x40062C6")]
		public const short SilentFish = 5264;

		[global::Cpp2ILInjected.Token(Token = "0x40062C7")]
		public const short TheDuke = 5265;

		[global::Cpp2ILInjected.Token(Token = "0x40062C8")]
		public const short RoyalRomance = 5266;

		[global::Cpp2ILInjected.Token(Token = "0x40062C9")]
		public const short Bioluminescence = 5267;

		[global::Cpp2ILInjected.Token(Token = "0x40062CA")]
		public const short Wildflowers = 5268;

		[global::Cpp2ILInjected.Token(Token = "0x40062CB")]
		public const short VikingVoyage = 5269;

		[global::Cpp2ILInjected.Token(Token = "0x40062CC")]
		public const short Bifrost = 5270;

		[global::Cpp2ILInjected.Token(Token = "0x40062CD")]
		public const short Heartlands = 5271;

		[global::Cpp2ILInjected.Token(Token = "0x40062CE")]
		public const short ForestTroll = 5272;

		[global::Cpp2ILInjected.Token(Token = "0x40062CF")]
		public const short AuroraBorealis = 5273;

		[global::Cpp2ILInjected.Token(Token = "0x40062D0")]
		public const short LadyOfTheLake = 5274;

		[global::Cpp2ILInjected.Token(Token = "0x40062D1")]
		public const short JojaCola = 5275;

		[global::Cpp2ILInjected.Token(Token = "0x40062D2")]
		public const short JunimoPetItem = 5276;

		[global::Cpp2ILInjected.Token(Token = "0x40062D3")]
		public const short SpicyPepper = 5277;

		[global::Cpp2ILInjected.Token(Token = "0x40062D4")]
		public const short Pomegranate = 5278;

		[global::Cpp2ILInjected.Token(Token = "0x40062D5")]
		public const short AshWoodHelmet = 5279;

		[global::Cpp2ILInjected.Token(Token = "0x40062D6")]
		public const short AshWoodBreastplate = 5280;

		[global::Cpp2ILInjected.Token(Token = "0x40062D7")]
		public const short AshWoodGreaves = 5281;

		[global::Cpp2ILInjected.Token(Token = "0x40062D8")]
		public const short AshWoodBow = 5282;

		[global::Cpp2ILInjected.Token(Token = "0x40062D9")]
		public const short AshWoodHammer = 5283;

		[global::Cpp2ILInjected.Token(Token = "0x40062DA")]
		public const short AshWoodSword = 5284;

		[global::Cpp2ILInjected.Token(Token = "0x40062DB")]
		public const short MoonGlobe = 5285;

		[global::Cpp2ILInjected.Token(Token = "0x40062DC")]
		public const short RepairedLifeCrystal = 5286;

		[global::Cpp2ILInjected.Token(Token = "0x40062DD")]
		public const short RepairedManaCrystal = 5287;

		[global::Cpp2ILInjected.Token(Token = "0x40062DE")]
		public const short TerraFartMinecart = 5288;

		[global::Cpp2ILInjected.Token(Token = "0x40062DF")]
		public const short MinecartPowerup = 5289;

		[global::Cpp2ILInjected.Token(Token = "0x40062E0")]
		public const short JimsCap = 5290;

		[global::Cpp2ILInjected.Token(Token = "0x40062E1")]
		public const short EchoWall = 5291;

		[global::Cpp2ILInjected.Token(Token = "0x40062E2")]
		public const short EchoPlatform = 5292;

		[global::Cpp2ILInjected.Token(Token = "0x40062E3")]
		public const short MushroomTorch = 5293;

		[global::Cpp2ILInjected.Token(Token = "0x40062E4")]
		public const short HiveFive = 5294;

		[global::Cpp2ILInjected.Token(Token = "0x40062E5")]
		public const short AcornAxe = 5295;

		[global::Cpp2ILInjected.Token(Token = "0x40062E6")]
		public const short ChlorophyteExtractinator = 5296;

		[global::Cpp2ILInjected.Token(Token = "0x40062E7")]
		public const short BlueEgg = 5297;

		[global::Cpp2ILInjected.Token(Token = "0x40062E8")]
		public const short Trimarang = 5298;

		[global::Cpp2ILInjected.Token(Token = "0x40062E9")]
		public const short MushroomCampfire = 5299;

		[global::Cpp2ILInjected.Token(Token = "0x40062EA")]
		public const short BlueMacaw = 5300;

		[global::Cpp2ILInjected.Token(Token = "0x40062EB")]
		public const short BlueMacawCage = 5301;

		[global::Cpp2ILInjected.Token(Token = "0x40062EC")]
		public const short BottomlessHoneyBucket = 5302;

		[global::Cpp2ILInjected.Token(Token = "0x40062ED")]
		public const short HoneyAbsorbantSponge = 5303;

		[global::Cpp2ILInjected.Token(Token = "0x40062EE")]
		public const short UltraAbsorbantSponge = 5304;

		[global::Cpp2ILInjected.Token(Token = "0x40062EF")]
		public const short GoblorcEar = 5305;

		[global::Cpp2ILInjected.Token(Token = "0x40062F0")]
		public const short ReefBlock = 5306;

		[global::Cpp2ILInjected.Token(Token = "0x40062F1")]
		public const short ReefWall = 5307;

		[global::Cpp2ILInjected.Token(Token = "0x40062F2")]
		public const short PlacePainting = 5308;

		[global::Cpp2ILInjected.Token(Token = "0x40062F3")]
		public const short DontHurtNatureBook = 5309;

		[global::Cpp2ILInjected.Token(Token = "0x40062F4")]
		public const short PrincessStyle = 5310;

		[global::Cpp2ILInjected.Token(Token = "0x40062F5")]
		public const short Toucan = 5311;

		[global::Cpp2ILInjected.Token(Token = "0x40062F6")]
		public const short YellowCockatiel = 5312;

		[global::Cpp2ILInjected.Token(Token = "0x40062F7")]
		public const short GrayCockatiel = 5313;

		[global::Cpp2ILInjected.Token(Token = "0x40062F8")]
		public const short ToucanCage = 5314;

		[global::Cpp2ILInjected.Token(Token = "0x40062F9")]
		public const short YellowCockatielCage = 5315;

		[global::Cpp2ILInjected.Token(Token = "0x40062FA")]
		public const short GrayCockatielCage = 5316;

		[global::Cpp2ILInjected.Token(Token = "0x40062FB")]
		public const short MacawStatue = 5317;

		[global::Cpp2ILInjected.Token(Token = "0x40062FC")]
		public const short ToucanStatue = 5318;

		[global::Cpp2ILInjected.Token(Token = "0x40062FD")]
		public const short CockatielStatue = 5319;

		[global::Cpp2ILInjected.Token(Token = "0x40062FE")]
		public const short PlaceableHealingPotion = 5320;

		[global::Cpp2ILInjected.Token(Token = "0x40062FF")]
		public const short PlaceableManaPotion = 5321;

		[global::Cpp2ILInjected.Token(Token = "0x4006300")]
		public const short ShadowCandle = 5322;

		[global::Cpp2ILInjected.Token(Token = "0x4006301")]
		public const short DontHurtComboBook = 5323;

		[global::Cpp2ILInjected.Token(Token = "0x4006302")]
		public const short RubblemakerSmall = 5324;

		[global::Cpp2ILInjected.Token(Token = "0x4006303")]
		public const short ClosedVoidBag = 5325;

		[global::Cpp2ILInjected.Token(Token = "0x4006304")]
		public const short ArtisanLoaf = 5326;

		[global::Cpp2ILInjected.Token(Token = "0x4006305")]
		public const short TNTBarrel = 5327;

		[global::Cpp2ILInjected.Token(Token = "0x4006306")]
		public const short ChestLock = 5328;

		[global::Cpp2ILInjected.Token(Token = "0x4006307")]
		public const short RubblemakerMedium = 5329;

		[global::Cpp2ILInjected.Token(Token = "0x4006308")]
		public const short RubblemakerLarge = 5330;

		[global::Cpp2ILInjected.Token(Token = "0x4006309")]
		public const short HorseshoeBundle = 5331;

		[global::Cpp2ILInjected.Token(Token = "0x400630A")]
		public const short SpiffoPlush = 5332;

		[global::Cpp2ILInjected.Token(Token = "0x400630B")]
		public const short GlowTulip = 5333;

		[global::Cpp2ILInjected.Token(Token = "0x400630C")]
		public const short MechdusaSummon = 5334;

		[global::Cpp2ILInjected.Token(Token = "0x400630D")]
		public const short RodOfHarmony = 5335;

		[global::Cpp2ILInjected.Token(Token = "0x400630E")]
		public const short CombatBookVolumeTwo = 5336;

		[global::Cpp2ILInjected.Token(Token = "0x400630F")]
		public const short AegisCrystal = 5337;

		[global::Cpp2ILInjected.Token(Token = "0x4006310")]
		public const short AegisFruit = 5338;

		[global::Cpp2ILInjected.Token(Token = "0x4006311")]
		public const short ArcaneCrystal = 5339;

		[global::Cpp2ILInjected.Token(Token = "0x4006312")]
		public const short GalaxyPearl = 5340;

		[global::Cpp2ILInjected.Token(Token = "0x4006313")]
		public const short GummyWorm = 5341;

		[global::Cpp2ILInjected.Token(Token = "0x4006314")]
		public const short Ambrosia = 5342;

		[global::Cpp2ILInjected.Token(Token = "0x4006315")]
		public const short PeddlersSatchel = 5343;

		[global::Cpp2ILInjected.Token(Token = "0x4006316")]
		public const short EchoCoating = 5344;

		[global::Cpp2ILInjected.Token(Token = "0x4006317")]
		public const short EchoMonolith = 5345;

		[global::Cpp2ILInjected.Token(Token = "0x4006318")]
		public const short GasTrap = 5346;

		[global::Cpp2ILInjected.Token(Token = "0x4006319")]
		public const short ShimmerMonolith = 5347;

		[global::Cpp2ILInjected.Token(Token = "0x400631A")]
		public const short ShimmerArrow = 5348;

		[global::Cpp2ILInjected.Token(Token = "0x400631B")]
		public const short ShimmerBlock = 5349;

		[global::Cpp2ILInjected.Token(Token = "0x400631C")]
		public const short Shimmerfly = 5350;

		[global::Cpp2ILInjected.Token(Token = "0x400631D")]
		public const short ShimmerflyinaBottle = 5351;

		[global::Cpp2ILInjected.Token(Token = "0x400631E")]
		public const short ShimmerSlimeBanner = 5352;

		[global::Cpp2ILInjected.Token(Token = "0x400631F")]
		public const short ShimmerTorch = 5353;

		[global::Cpp2ILInjected.Token(Token = "0x4006320")]
		public const short ReflectiveShades = 5354;

		[global::Cpp2ILInjected.Token(Token = "0x4006321")]
		public const short ShimmerCloak = 5355;

		[global::Cpp2ILInjected.Token(Token = "0x4006322")]
		public const short UsedGasTrap = 5356;

		[global::Cpp2ILInjected.Token(Token = "0x4006323")]
		public const short ShimmerCampfire = 5357;

		[global::Cpp2ILInjected.Token(Token = "0x4006324")]
		public const short Shellphone = 5358;

		[global::Cpp2ILInjected.Token(Token = "0x4006325")]
		public const short ShellphoneSpawn = 5359;

		[global::Cpp2ILInjected.Token(Token = "0x4006326")]
		public const short ShellphoneOcean = 5360;

		[global::Cpp2ILInjected.Token(Token = "0x4006327")]
		public const short ShellphoneHell = 5361;

		[global::Cpp2ILInjected.Token(Token = "0x4006328")]
		public const short MusicBoxShimmer = 5362;

		[global::Cpp2ILInjected.Token(Token = "0x4006329")]
		public const short SpiderWallUnsafe = 5363;

		[global::Cpp2ILInjected.Token(Token = "0x400632A")]
		public const short BottomlessShimmerBucket = 5364;

		[global::Cpp2ILInjected.Token(Token = "0x400632B")]
		public const short BlueBrickWallUnsafe = 5365;

		[global::Cpp2ILInjected.Token(Token = "0x400632C")]
		public const short BlueSlabWallUnsafe = 5366;

		[global::Cpp2ILInjected.Token(Token = "0x400632D")]
		public const short BlueTiledWallUnsafe = 5367;

		[global::Cpp2ILInjected.Token(Token = "0x400632E")]
		public const short PinkBrickWallUnsafe = 5368;

		[global::Cpp2ILInjected.Token(Token = "0x400632F")]
		public const short PinkSlabWallUnsafe = 5369;

		[global::Cpp2ILInjected.Token(Token = "0x4006330")]
		public const short PinkTiledWallUnsafe = 5370;

		[global::Cpp2ILInjected.Token(Token = "0x4006331")]
		public const short GreenBrickWallUnsafe = 5371;

		[global::Cpp2ILInjected.Token(Token = "0x4006332")]
		public const short GreenSlabWallUnsafe = 5372;

		[global::Cpp2ILInjected.Token(Token = "0x4006333")]
		public const short GreenTiledWallUnsafe = 5373;

		[global::Cpp2ILInjected.Token(Token = "0x4006334")]
		public const short SandstoneWallUnsafe = 5374;

		[global::Cpp2ILInjected.Token(Token = "0x4006335")]
		public const short HardenedSandWallUnsafe = 5375;

		[global::Cpp2ILInjected.Token(Token = "0x4006336")]
		public const short LihzahrdWallUnsafe = 5376;

		[global::Cpp2ILInjected.Token(Token = "0x4006337")]
		public const short SpelunkerFlare = 5377;

		[global::Cpp2ILInjected.Token(Token = "0x4006338")]
		public const short CursedFlare = 5378;

		[global::Cpp2ILInjected.Token(Token = "0x4006339")]
		public const short RainbowFlare = 5379;

		[global::Cpp2ILInjected.Token(Token = "0x400633A")]
		public const short ShimmerFlare = 5380;

		[global::Cpp2ILInjected.Token(Token = "0x400633B")]
		public const short Moondial = 5381;

		[global::Cpp2ILInjected.Token(Token = "0x400633C")]
		public const short WaffleIron = 5382;

		[global::Cpp2ILInjected.Token(Token = "0x400633D")]
		public const short BouncyBoulder = 5383;

		[global::Cpp2ILInjected.Token(Token = "0x400633E")]
		public const short LifeCrystalBoulder = 5384;

		[global::Cpp2ILInjected.Token(Token = "0x400633F")]
		public const short DizzyHat = 5385;

		[global::Cpp2ILInjected.Token(Token = "0x4006340")]
		public const short LincolnsHoodie = 5386;

		[global::Cpp2ILInjected.Token(Token = "0x4006341")]
		public const short LincolnsPants = 5387;

		[global::Cpp2ILInjected.Token(Token = "0x4006342")]
		public const short SunOrnament = 5388;

		[global::Cpp2ILInjected.Token(Token = "0x4006343")]
		public const short HoplitePizza = 5389;

		[global::Cpp2ILInjected.Token(Token = "0x4006344")]
		public const short LincolnsHood = 5390;

		[global::Cpp2ILInjected.Token(Token = "0x4006345")]
		public const short UncumberingStone = 5391;

		[global::Cpp2ILInjected.Token(Token = "0x4006346")]
		public const short SandSolution = 5392;

		[global::Cpp2ILInjected.Token(Token = "0x4006347")]
		public const short SnowSolution = 5393;

		[global::Cpp2ILInjected.Token(Token = "0x4006348")]
		public const short DirtSolution = 5394;

		[global::Cpp2ILInjected.Token(Token = "0x4006349")]
		public const short PoopBlock = 5395;

		[global::Cpp2ILInjected.Token(Token = "0x400634A")]
		public const short PoopWall = 5396;

		[global::Cpp2ILInjected.Token(Token = "0x400634B")]
		public const short ShimmerWall = 5397;

		[global::Cpp2ILInjected.Token(Token = "0x400634C")]
		public const short ShimmerBrick = 5398;

		[global::Cpp2ILInjected.Token(Token = "0x400634D")]
		public const short ShimmerBrickWall = 5399;

		[global::Cpp2ILInjected.Token(Token = "0x400634E")]
		public const short DirtiestBlock = 5400;

		[global::Cpp2ILInjected.Token(Token = "0x400634F")]
		public const short LunarRustBrick = 5401;

		[global::Cpp2ILInjected.Token(Token = "0x4006350")]
		public const short DarkCelestialBrick = 5402;

		[global::Cpp2ILInjected.Token(Token = "0x4006351")]
		public const short AstraBrick = 5403;

		[global::Cpp2ILInjected.Token(Token = "0x4006352")]
		public const short CosmicEmberBrick = 5404;

		[global::Cpp2ILInjected.Token(Token = "0x4006353")]
		public const short CryocoreBrick = 5405;

		[global::Cpp2ILInjected.Token(Token = "0x4006354")]
		public const short MercuryBrick = 5406;

		[global::Cpp2ILInjected.Token(Token = "0x4006355")]
		public const short StarRoyaleBrick = 5407;

		[global::Cpp2ILInjected.Token(Token = "0x4006356")]
		public const short HeavenforgeBrick = 5408;

		[global::Cpp2ILInjected.Token(Token = "0x4006357")]
		public const short LunarRustBrickWall = 5409;

		[global::Cpp2ILInjected.Token(Token = "0x4006358")]
		public const short DarkCelestialBrickWall = 5410;

		[global::Cpp2ILInjected.Token(Token = "0x4006359")]
		public const short AstraBrickWall = 5411;

		[global::Cpp2ILInjected.Token(Token = "0x400635A")]
		public const short CosmicEmberBrickWall = 5412;

		[global::Cpp2ILInjected.Token(Token = "0x400635B")]
		public const short CryocoreBrickWall = 5413;

		[global::Cpp2ILInjected.Token(Token = "0x400635C")]
		public const short MercuryBrickWall = 5414;

		[global::Cpp2ILInjected.Token(Token = "0x400635D")]
		public const short StarRoyaleBrickWall = 5415;

		[global::Cpp2ILInjected.Token(Token = "0x400635E")]
		public const short HeavenforgeBrickWall = 5416;

		[global::Cpp2ILInjected.Token(Token = "0x400635F")]
		public const short AncientBlueDungeonBrick = 5417;

		[global::Cpp2ILInjected.Token(Token = "0x4006360")]
		public const short AncientBlueDungeonBrickWall = 5418;

		[global::Cpp2ILInjected.Token(Token = "0x4006361")]
		public const short AncientGreenDungeonBrick = 5419;

		[global::Cpp2ILInjected.Token(Token = "0x4006362")]
		public const short AncientGreenDungeonBrickWall = 5420;

		[global::Cpp2ILInjected.Token(Token = "0x4006363")]
		public const short AncientPinkDungeonBrick = 5421;

		[global::Cpp2ILInjected.Token(Token = "0x4006364")]
		public const short AncientPinkDungeonBrickWall = 5422;

		[global::Cpp2ILInjected.Token(Token = "0x4006365")]
		public const short AncientGoldBrick = 5423;

		[global::Cpp2ILInjected.Token(Token = "0x4006366")]
		public const short AncientGoldBrickWall = 5424;

		[global::Cpp2ILInjected.Token(Token = "0x4006367")]
		public const short AncientSilverBrick = 5425;

		[global::Cpp2ILInjected.Token(Token = "0x4006368")]
		public const short AncientSilverBrickWall = 5426;

		[global::Cpp2ILInjected.Token(Token = "0x4006369")]
		public const short AncientCopperBrick = 5427;

		[global::Cpp2ILInjected.Token(Token = "0x400636A")]
		public const short AncientCopperBrickWall = 5428;

		[global::Cpp2ILInjected.Token(Token = "0x400636B")]
		public const short AncientCobaltBrick = 5429;

		[global::Cpp2ILInjected.Token(Token = "0x400636C")]
		public const short AncientCobaltBrickWall = 5430;

		[global::Cpp2ILInjected.Token(Token = "0x400636D")]
		public const short AncientMythrilBrick = 5431;

		[global::Cpp2ILInjected.Token(Token = "0x400636E")]
		public const short AncientMythrilBrickWall = 5432;

		[global::Cpp2ILInjected.Token(Token = "0x400636F")]
		public const short AncientObsidianBrick = 5433;

		[global::Cpp2ILInjected.Token(Token = "0x4006370")]
		public const short AncientObsidianBrickWall = 5434;

		[global::Cpp2ILInjected.Token(Token = "0x4006371")]
		public const short AncientHellstoneBrick = 5435;

		[global::Cpp2ILInjected.Token(Token = "0x4006372")]
		public const short AncientHellstoneBrickWall = 5436;

		[global::Cpp2ILInjected.Token(Token = "0x4006373")]
		public const short ShellphoneDummy = 5437;

		[global::Cpp2ILInjected.Token(Token = "0x4006374")]
		public const short Fertilizer = 5438;

		[global::Cpp2ILInjected.Token(Token = "0x4006375")]
		public const short LavaMossBlock = 5439;

		[global::Cpp2ILInjected.Token(Token = "0x4006376")]
		public const short ArgonMossBlock = 5440;

		[global::Cpp2ILInjected.Token(Token = "0x4006377")]
		public const short KryptonMossBlock = 5441;

		[global::Cpp2ILInjected.Token(Token = "0x4006378")]
		public const short XenonMossBlock = 5442;

		[global::Cpp2ILInjected.Token(Token = "0x4006379")]
		public const short VioletMossBlock = 5443;

		[global::Cpp2ILInjected.Token(Token = "0x400637A")]
		public const short RainbowMossBlock = 5444;

		[global::Cpp2ILInjected.Token(Token = "0x400637B")]
		public const short LavaMossBlockWall = 5445;

		[global::Cpp2ILInjected.Token(Token = "0x400637C")]
		public const short ArgonMossBlockWall = 5446;

		[global::Cpp2ILInjected.Token(Token = "0x400637D")]
		public const short KryptonMossBlockWall = 5447;

		[global::Cpp2ILInjected.Token(Token = "0x400637E")]
		public const short XenonMossBlockWall = 5448;

		[global::Cpp2ILInjected.Token(Token = "0x400637F")]
		public const short VioletMossBlockWall = 5449;

		[global::Cpp2ILInjected.Token(Token = "0x4006380")]
		public const short RainbowMossBlockWall = 5450;

		[global::Cpp2ILInjected.Token(Token = "0x4006381")]
		public const short JimsDrone = 5451;

		[global::Cpp2ILInjected.Token(Token = "0x4006382")]
		public const short JimsDroneVisor = 5452;

		[global::Cpp2ILInjected.Token(Token = "0x4006383")]
		public const short DontHurtCrittersBookInactive = 5453;

		[global::Cpp2ILInjected.Token(Token = "0x4006384")]
		public const short DontHurtNatureBookInactive = 5454;

		[global::Cpp2ILInjected.Token(Token = "0x4006385")]
		public const short DontHurtComboBookInactive = 5455;

		[global::Cpp2ILInjected.Token(Token = "0x4006386")]
		public const short Count = 5456;

		[global::Cpp2ILInjected.Token(Token = "0x4006387")]
		public static readonly IdDictionary Search;

		[global::Cpp2ILInjected.Token(Token = "0x20005D2")]
		public struct BannerEffect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003554")]
			[global::Cpp2ILInjected.Address(RVA = "0x13953A8", Offset = "0x13953A8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public BannerEffect(float strength = 1f)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6003555")]
			[global::Cpp2ILInjected.Address(RVA = "0x13953E4", Offset = "0x13953E4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public BannerEffect(float normalDamageDealt, float expertDamageDealt, float normalDamageReceived, float expertDamageReceived)
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003556")]
			[global::Cpp2ILInjected.Address(RVA = "0x13953F8", Offset = "0x13953F8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static BannerEffect()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4006388")]
			public static readonly ItemID.BannerEffect None;

			[global::Cpp2ILInjected.Token(Token = "0x4006389")]
			public static readonly ItemID.BannerEffect Reduced;

			[global::Cpp2ILInjected.Token(Token = "0x400638A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly float NormalDamageDealt;

			[global::Cpp2ILInjected.Token(Token = "0x400638B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public readonly float ExpertDamageDealt;

			[global::Cpp2ILInjected.Token(Token = "0x400638C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly float NormalDamageReceived;

			[global::Cpp2ILInjected.Token(Token = "0x400638D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public readonly float ExpertDamageReceived;

			[global::Cpp2ILInjected.Token(Token = "0x400638E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly bool Enabled;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20005D3")]
		public class Sets
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003557")]
			[global::Cpp2ILInjected.Address(RVA = "0x139546C", Offset = "0x139546C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Sets()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003558")]
			[global::Cpp2ILInjected.Address(RVA = "0x1395474", Offset = "0x1395474", Length = "0xCB5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int[])
			}, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int[])
			}, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateCustomSet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T",
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FlowerPacketInfo), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(object),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(bool[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(int[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateFloatSet", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float[])
			}, ReturnType = typeof(float[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(ItemID.BannerEffect) }, MemberParameters = new object[]
			{
				typeof(ItemID.BannerEffect),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory[]), Member = "CreateCustomSet", MemberTypeParameters = new object[] { typeof(float?) }, MemberParameters = new object[]
			{
				typeof(float?),
				typeof(object[])
			}, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1005)]
			static Sets()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400638F")]
			public static SetFactory Factory;

			[global::Cpp2ILInjected.Token(Token = "0x4006390")]
			public static List<int> ItemsThatAreProcessedAfterNormalContentSample;

			[global::Cpp2ILInjected.Token(Token = "0x4006391")]
			public static bool[] IsLavaImmuneRegardlessOfRarity;

			[global::Cpp2ILInjected.Token(Token = "0x4006392")]
			public static bool[] ItemsThatAllowRepeatedRightClick;

			[global::Cpp2ILInjected.Token(Token = "0x4006393")]
			public static bool[] ItemsThatCountAsBombsForDemolitionistToSpawn;

			[global::Cpp2ILInjected.Token(Token = "0x4006394")]
			public static bool[] ItemsThatShouldNotBeInInventory;

			[global::Cpp2ILInjected.Token(Token = "0x4006395")]
			public static bool[] DrawUnsafeIndicator;

			[global::Cpp2ILInjected.Token(Token = "0x4006396")]
			public static bool[] UsesBetterMeleeItemLocation;

			[global::Cpp2ILInjected.Token(Token = "0x4006397")]
			public static bool[] WorksInVoidBag;

			[global::Cpp2ILInjected.Token(Token = "0x4006398")]
			public static bool[] GrassSeeds;

			[global::Cpp2ILInjected.Token(Token = "0x4006399")]
			public static int[] ShimmerTransformToItem;

			[global::Cpp2ILInjected.Token(Token = "0x400639A")]
			public static int[] ShimmerCountsAsItem;

			[global::Cpp2ILInjected.Token(Token = "0x400639B")]
			public static int[] OverflowProtectionTimeOffset;

			[global::Cpp2ILInjected.Token(Token = "0x400639C")]
			public static int[] ItemsForStuffCannon;

			[global::Cpp2ILInjected.Token(Token = "0x400639D")]
			public static bool?[] CanBeQuickusedOnGamepad;

			[global::Cpp2ILInjected.Token(Token = "0x400639E")]
			public static bool?[] ForcesBreaksSleeping;

			[global::Cpp2ILInjected.Token(Token = "0x400639F")]
			public static bool[] SkipsInitialUseSound;

			[global::Cpp2ILInjected.Token(Token = "0x40063A0")]
			public static bool[] UsesCursedByPlanteraTooltip;

			[global::Cpp2ILInjected.Token(Token = "0x40063A1")]
			public static bool[] IsAKite;

			[global::Cpp2ILInjected.Token(Token = "0x40063A2")]
			public static bool?[] ForceConsumption;

			[global::Cpp2ILInjected.Token(Token = "0x40063A3")]
			public static bool[] HasAProjectileThatHasAUsabilityCheck;

			[global::Cpp2ILInjected.Token(Token = "0x40063A4")]
			public static bool[] CanGetPrefixes;

			[global::Cpp2ILInjected.Token(Token = "0x40063A5")]
			public static List<int> NonColorfulDyeItems;

			[global::Cpp2ILInjected.Token(Token = "0x40063A6")]
			public static bool[] ColorfulDyeValues;

			[global::Cpp2ILInjected.Token(Token = "0x40063A7")]
			public static FlowerPacketInfo[] flowerPacketInfo;

			[global::Cpp2ILInjected.Token(Token = "0x40063A8")]
			public static bool[] IsAMaterial;

			[global::Cpp2ILInjected.Token(Token = "0x40063A9")]
			public static int[] IsCrafted;

			[global::Cpp2ILInjected.Token(Token = "0x40063AA")]
			public static int[] IsCraftedCrimson;

			[global::Cpp2ILInjected.Token(Token = "0x40063AB")]
			public static int[] IsCraftedCorruption;

			[global::Cpp2ILInjected.Token(Token = "0x40063AC")]
			public static bool[] IgnoresEncumberingStone;

			[global::Cpp2ILInjected.Token(Token = "0x40063AD")]
			public static float[] ToolTipDamageMultiplier;

			[global::Cpp2ILInjected.Token(Token = "0x40063AE")]
			public static bool[] IsAPickup;

			[global::Cpp2ILInjected.Token(Token = "0x40063AF")]
			public static bool[] IsDrill;

			[global::Cpp2ILInjected.Token(Token = "0x40063B0")]
			public static bool[] IsChainsaw;

			[global::Cpp2ILInjected.Token(Token = "0x40063B1")]
			public static bool[] IsPaintScraper;

			[global::Cpp2ILInjected.Token(Token = "0x40063B2")]
			public static bool[] SummonerWeaponThatScalesWithAttackSpeed;

			[global::Cpp2ILInjected.Token(Token = "0x40063B3")]
			public static bool[] IsFood;

			[global::Cpp2ILInjected.Token(Token = "0x40063B4")]
			public static Color[][] FoodParticleColors;

			[global::Cpp2ILInjected.Token(Token = "0x40063B5")]
			public static Color[][] DrinkParticleColors;

			[global::Cpp2ILInjected.Token(Token = "0x40063B6")]
			private static ItemID.BannerEffect DD2BannerEffect;

			[global::Cpp2ILInjected.Token(Token = "0x40063B7")]
			public static ItemID.BannerEffect[] BannerStrength;

			[global::Cpp2ILInjected.Token(Token = "0x40063B8")]
			public static int DefaultKillsForBannerNeeded;

			[global::Cpp2ILInjected.Token(Token = "0x40063B9")]
			public static int[] KillsToBanner;

			[global::Cpp2ILInjected.Token(Token = "0x40063BA")]
			public static bool[] CanFishInLava;

			[global::Cpp2ILInjected.Token(Token = "0x40063BB")]
			public static bool[] IsLavaBait;

			[global::Cpp2ILInjected.Token(Token = "0x40063BC")]
			private const int healingItemsDecayRate = 4;

			[global::Cpp2ILInjected.Token(Token = "0x40063BD")]
			public static int[] ItemSpawnDecaySpeed;

			[global::Cpp2ILInjected.Token(Token = "0x40063BE")]
			public static bool[] IsFishingCrate;

			[global::Cpp2ILInjected.Token(Token = "0x40063BF")]
			public static bool[] IsFishingCrateHardmode;

			[global::Cpp2ILInjected.Token(Token = "0x40063C0")]
			public static bool[] CanBePlacedOnWeaponRacks;

			[global::Cpp2ILInjected.Token(Token = "0x40063C1")]
			public static int[] TextureCopyLoad;

			[global::Cpp2ILInjected.Token(Token = "0x40063C2")]
			public static bool[] TrapSigned;

			[global::Cpp2ILInjected.Token(Token = "0x40063C3")]
			public static bool[] Deprecated;

			[global::Cpp2ILInjected.Token(Token = "0x40063C4")]
			public static bool[] NeverAppearsAsNewInInventory;

			[global::Cpp2ILInjected.Token(Token = "0x40063C5")]
			public static bool[] CommonCoin;

			[global::Cpp2ILInjected.Token(Token = "0x40063C6")]
			public static bool[] ItemIconPulse;

			[global::Cpp2ILInjected.Token(Token = "0x40063C7")]
			public static bool[] ItemNoGravity;

			[global::Cpp2ILInjected.Token(Token = "0x40063C8")]
			public static int[] ExtractinatorMode;

			[global::Cpp2ILInjected.Token(Token = "0x40063C9")]
			public static int[] StaffMinionSlotsRequired;

			[global::Cpp2ILInjected.Token(Token = "0x40063CA")]
			public static bool[] ExoticPlantsForDyeTrade;

			[global::Cpp2ILInjected.Token(Token = "0x40063CB")]
			public static bool[] NebulaPickup;

			[global::Cpp2ILInjected.Token(Token = "0x40063CC")]
			public static bool[] AnimatesAsSoul;

			[global::Cpp2ILInjected.Token(Token = "0x40063CD")]
			public static bool[] gunProj;

			[global::Cpp2ILInjected.Token(Token = "0x40063CE")]
			public static int[] SortingPriorityBossSpawns;

			[global::Cpp2ILInjected.Token(Token = "0x40063CF")]
			public static int[] SortingPriorityWiring;

			[global::Cpp2ILInjected.Token(Token = "0x40063D0")]
			public static int[] SortingPriorityMaterials;

			[global::Cpp2ILInjected.Token(Token = "0x40063D1")]
			public static int[] SortingPriorityExtractibles;

			[global::Cpp2ILInjected.Token(Token = "0x40063D2")]
			public static int[] SortingPriorityRopes;

			[global::Cpp2ILInjected.Token(Token = "0x40063D3")]
			public static int[] SortingPriorityPainting;

			[global::Cpp2ILInjected.Token(Token = "0x40063D4")]
			public static int[] SortingPriorityTerraforming;

			[global::Cpp2ILInjected.Token(Token = "0x40063D5")]
			public static int[] GamepadExtraRange;

			[global::Cpp2ILInjected.Token(Token = "0x40063D6")]
			public static bool[] GamepadWholeScreenUseRange;

			[global::Cpp2ILInjected.Token(Token = "0x40063D7")]
			public static float[] BonusMeleeSpeedMultiplier;

			[global::Cpp2ILInjected.Token(Token = "0x40063D8")]
			public static bool[] GamepadSmartQuickReach;

			[global::Cpp2ILInjected.Token(Token = "0x40063D9")]
			public static bool[] Yoyo;

			[global::Cpp2ILInjected.Token(Token = "0x40063DA")]
			public static bool[] AlsoABuildingItem;

			[global::Cpp2ILInjected.Token(Token = "0x40063DB")]
			public static bool[] LockOnIgnoresCollision;

			[global::Cpp2ILInjected.Token(Token = "0x40063DC")]
			public static int[] LockOnAimAbove;

			[global::Cpp2ILInjected.Token(Token = "0x40063DD")]
			public static float?[] LockOnAimCompensation;

			[global::Cpp2ILInjected.Token(Token = "0x40063DE")]
			public static bool[] SingleUseInGamepad;

			[global::Cpp2ILInjected.Token(Token = "0x40063DF")]
			public static bool[] Torches;

			[global::Cpp2ILInjected.Token(Token = "0x40063E0")]
			public static bool[] WaterTorches;

			[global::Cpp2ILInjected.Token(Token = "0x40063E1")]
			public static short[] Workbenches;

			[global::Cpp2ILInjected.Token(Token = "0x40063E2")]
			public static bool[] BossBag;

			[global::Cpp2ILInjected.Token(Token = "0x40063E3")]
			public static bool[] OpenableBag;
		}
	}
}
