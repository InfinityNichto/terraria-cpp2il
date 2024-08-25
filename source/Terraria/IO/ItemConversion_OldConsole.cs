using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000578")]
	public static class ItemConversion_OldConsole
	{
		[global::Cpp2ILInjected.Token(Token = "0x60033FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1349CA4", Offset = "0x1349CA4", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckWeaponsRack", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadChests", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "GetCoinItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref short),
			typeof(ref short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool ModifyItem(ref short itemId, ref short itemStack, ref byte prefix, bool chestConversion = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003400")]
		[global::Cpp2ILInjected.Address(RVA = "0x1349EBC", Offset = "0x1349EBC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemConversion_OldConsole), Member = "ModifyItem", MemberParameters = new object[]
		{
			typeof(ref short),
			typeof(ref short),
			typeof(ref byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static void GetCoinItem(int coinValue, ref short itemId, ref short itemStack)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1349F98", Offset = "0x1349F98", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ModifyBodySlot(ref int slot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1349FD0", Offset = "0x1349FD0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ModifyHeadSlot(ref int slot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003403")]
		[global::Cpp2ILInjected.Address(RVA = "0x134A000", Offset = "0x134A000", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "CheckMannequin", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool ModifyLegSlot(ref int slot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003E67")]
		private const short DragonMask = 10000;

		[global::Cpp2ILInjected.Token(Token = "0x4003E68")]
		private const short DragonBreastplate = 10001;

		[global::Cpp2ILInjected.Token(Token = "0x4003E69")]
		private const short DragonGreaves = 10002;

		[global::Cpp2ILInjected.Token(Token = "0x4003E6A")]
		private const short SpectralHeadgear = 10003;

		[global::Cpp2ILInjected.Token(Token = "0x4003E6B")]
		private const short SpectralArmor = 10004;

		[global::Cpp2ILInjected.Token(Token = "0x4003E6C")]
		private const short SpectralSubligar = 10005;

		[global::Cpp2ILInjected.Token(Token = "0x4003E6D")]
		private const short TitanHelmet = 10006;

		[global::Cpp2ILInjected.Token(Token = "0x4003E6E")]
		private const short TitanMail = 10007;

		[global::Cpp2ILInjected.Token(Token = "0x4003E6F")]
		private const short TitanLeggings = 10008;

		[global::Cpp2ILInjected.Token(Token = "0x4003E70")]
		private const short OcramMask = 10009;

		[global::Cpp2ILInjected.Token(Token = "0x4003E71")]
		private const short HornedGodMask = 10010;

		[global::Cpp2ILInjected.Token(Token = "0x4003E72")]
		private const short HornedGodRobe = 10011;

		[global::Cpp2ILInjected.Token(Token = "0x4003E73")]
		private const short HornedGodBoots = 10012;

		[global::Cpp2ILInjected.Token(Token = "0x4003E74")]
		private const short OcramTrophy = 10013;

		[global::Cpp2ILInjected.Token(Token = "0x4003E75")]
		private const short AlbinoAntlionBanner = 10014;

		[global::Cpp2ILInjected.Token(Token = "0x4003E76")]
		private const short ArchWyvernBanner = 10015;

		[global::Cpp2ILInjected.Token(Token = "0x4003E77")]
		private const short ArchDemonBanner = 10016;

		[global::Cpp2ILInjected.Token(Token = "0x4003E78")]
		private const short DragonSnatcherBanner = 10017;

		[global::Cpp2ILInjected.Token(Token = "0x4003E79")]
		private const short OrcaBanner = 10018;

		[global::Cpp2ILInjected.Token(Token = "0x4003E7A")]
		private const short ShadowHammerBanner = 10019;

		[global::Cpp2ILInjected.Token(Token = "0x4003E7B")]
		private const short ShadowMummyBanner = 10020;

		[global::Cpp2ILInjected.Token(Token = "0x4003E7C")]
		private const short SpectralGastropodBanner = 10021;

		[global::Cpp2ILInjected.Token(Token = "0x4003E7D")]
		private const short SpectralElementalBanner = 10022;

		[global::Cpp2ILInjected.Token(Token = "0x4003E7E")]
		private const short VampireMinerBanner = 10023;

		[global::Cpp2ILInjected.Token(Token = "0x4003E7F")]
		private const short MusicBoxTutorial = 10024;

		[global::Cpp2ILInjected.Token(Token = "0x4003E80")]
		private const short StarTopper4 = 10025;

		[global::Cpp2ILInjected.Token(Token = "0x4003E81")]
		private const short StarTopper5 = 10026;

		[global::Cpp2ILInjected.Token(Token = "0x4003E82")]
		private const short ShirenHat = 10027;

		[global::Cpp2ILInjected.Token(Token = "0x4003E83")]
		private const short ShirenShirt = 10028;

		[global::Cpp2ILInjected.Token(Token = "0x4003E84")]
		private const short ShirenPants = 10029;

		[global::Cpp2ILInjected.Token(Token = "0x4003E85")]
		private const short MonokumaHead = 10030;

		[global::Cpp2ILInjected.Token(Token = "0x4003E86")]
		private const short MonokumaBody = 10031;

		[global::Cpp2ILInjected.Token(Token = "0x4003E87")]
		private const short MonokumaLegs = 10032;

		[global::Cpp2ILInjected.Token(Token = "0x4003E88")]
		private const short WhiteThread = 10033;

		[global::Cpp2ILInjected.Token(Token = "0x4003E89")]
		private const short MonomiHead = 10034;

		[global::Cpp2ILInjected.Token(Token = "0x4003E8A")]
		private const short MonomiBody = 10035;

		[global::Cpp2ILInjected.Token(Token = "0x4003E8B")]
		private const short MonomiLegs = 10036;

		[global::Cpp2ILInjected.Token(Token = "0x4003E8C")]
		private const short TorosHead = 10037;

		[global::Cpp2ILInjected.Token(Token = "0x4003E8D")]
		private const short TorosBody = 10038;

		[global::Cpp2ILInjected.Token(Token = "0x4003E8E")]
		private const short TorosLegs = 10039;

		[global::Cpp2ILInjected.Token(Token = "0x4003E8F")]
		public static int CompensatedCurrency;

		[global::Cpp2ILInjected.Token(Token = "0x2000579")]
		public enum eBodySlot
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003E91")]
			None = -1,
			[global::Cpp2ILInjected.Token(Token = "0x4003E92")]
			FamiliarShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003E93")]
			CopperChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003E94")]
			IronChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003E95")]
			SilverChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003E96")]
			GoldChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003E97")]
			ShadowScalemail,
			[global::Cpp2ILInjected.Token(Token = "0x4003E98")]
			MeteorSuit,
			[global::Cpp2ILInjected.Token(Token = "0x4003E99")]
			NecroBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003E9A")]
			JungleShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003E9B")]
			MoltenBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003E9C")]
			TuxedoShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003E9D")]
			PlumbersShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003E9E")]
			HerosShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003E9F")]
			ArchaeologistsJacket,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA0")]
			NinjaShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA1")]
			Robe,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA2")]
			TheDoctorsShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA3")]
			CobaltBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA4")]
			MythrilChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA5")]
			AdamantiteBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA6")]
			MiningShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA7")]
			WerewolfBody,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA8")]
			MermanBody,
			[global::Cpp2ILInjected.Token(Token = "0x4003EA9")]
			ClownShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EAA")]
			HallowedPlateMail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EAB")]
			SantaShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EAC")]
			RedsBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EAD")]
			FrostBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EAE")]
			TinChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EAF")]
			LeadChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB0")]
			TungstenChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB1")]
			PlatinumChainmail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB2")]
			WoodBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB3")]
			EbonwoodBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB4")]
			RichMahoganyBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB5")]
			PearlwoodBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB6")]
			RuneRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB7")]
			CrimsonScalemail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB8")]
			EskimoCoat,
			[global::Cpp2ILInjected.Token(Token = "0x4003EB9")]
			SteampunkShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EBA")]
			BeeShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EBB")]
			PrincessDress,
			[global::Cpp2ILInjected.Token(Token = "0x4003EBC")]
			PharaohsRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003EBD")]
			MummyShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EBE")]
			CowboyJacket,
			[global::Cpp2ILInjected.Token(Token = "0x4003EBF")]
			PirateShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC0")]
			CactusBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC1")]
			ShadewoodBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC2")]
			AncientShadowScalemail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC3")]
			AncientCobaltBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC4")]
			PinkEskimoCoat,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC5")]
			ChlorophytePlateMail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC6")]
			RainCoat,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC7")]
			TikiShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC8")]
			PalladiumBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EC9")]
			OrichalcumBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003ECA")]
			TitaniumBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003ECB")]
			SailorShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003ECC")]
			AmethystRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003ECD")]
			TopazRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003ECE")]
			SapphireRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003ECF")]
			EmeraldRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED0")]
			RubyRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED1")]
			DiamondRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED2")]
			WhiteTuxedoShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED3")]
			TurtleScaleMail,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED4")]
			SpectreRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED5")]
			ShroomiteBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED6")]
			CenxsBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED7")]
			CrownosBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED8")]
			WillsBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003ED9")]
			JimsBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EDA")]
			AaronsBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EDB")]
			DTownsBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EDC")]
			CenxsDress,
			[global::Cpp2ILInjected.Token(Token = "0x4003EDD")]
			PumpkinBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EDE")]
			NurseShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EDF")]
			DyeTraderRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE0")]
			CyborgShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE1")]
			CreeperShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE2")]
			CatShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE3")]
			GhostShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE4")]
			PumpkinShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE5")]
			RobotShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE6")]
			UnicornShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE7")]
			VampireShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE8")]
			LeprechaunShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EE9")]
			PixieShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EEA")]
			PrincessDressNew,
			[global::Cpp2ILInjected.Token(Token = "0x4003EEB")]
			WitchDress,
			[global::Cpp2ILInjected.Token(Token = "0x4003EEC")]
			BrideofFrankensteinDress,
			[global::Cpp2ILInjected.Token(Token = "0x4003EED")]
			KarateTortoiseShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EEE")]
			ScarecrowShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EEF")]
			ReaperRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF0")]
			FoxShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF1")]
			SpookyBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF2")]
			SpaceCreatureShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF3")]
			WolfShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF4")]
			TreasureHunterShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF5")]
			DryadCoverings,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF6")]
			MrsClauseShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF7")]
			TreeShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF8")]
			ParkaCoat,
			[global::Cpp2ILInjected.Token(Token = "0x4003EF9")]
			UglySweater,
			[global::Cpp2ILInjected.Token(Token = "0x4003EFA")]
			ElfShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003EFB")]
			BeetleScaleMail,
			[global::Cpp2ILInjected.Token(Token = "0x4003EFC")]
			BeetleShell,
			[global::Cpp2ILInjected.Token(Token = "0x4003EFD")]
			Gi = 165,
			[global::Cpp2ILInjected.Token(Token = "0x4003EFE")]
			Kimono,
			[global::Cpp2ILInjected.Token(Token = "0x4003EFF")]
			GypsyRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003F00")]
			BeeBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F01")]
			AnglerVest,
			[global::Cpp2ILInjected.Token(Token = "0x4003F02")]
			SpiderBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F03")]
			MermaidAdornment,
			[global::Cpp2ILInjected.Token(Token = "0x4003F04")]
			FishCostumeShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F05")]
			BorealWoodBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F06")]
			PalmWoodBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F07")]
			VortexBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F08")]
			NebulaBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F09")]
			SolarFlareBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F0A")]
			MartianCostumeShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F0B")]
			MartianUniformTorso,
			[global::Cpp2ILInjected.Token(Token = "0x4003F0C")]
			WhiteLunaticRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003F0D")]
			BlueLunaticRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003F0E")]
			GladiatorBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F0F")]
			BejeweledValkyrieBody,
			[global::Cpp2ILInjected.Token(Token = "0x4003F10")]
			TaxCollectorSuit,
			[global::Cpp2ILInjected.Token(Token = "0x4003F11")]
			ClothierJacket,
			[global::Cpp2ILInjected.Token(Token = "0x4003F12")]
			BuccaneerShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F13")]
			ObsidianShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F14")]
			FallenTuxedoShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F15")]
			FossilShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F16")]
			StardustBreastplate,
			[global::Cpp2ILInjected.Token(Token = "0x4003F17")]
			TheBrideDress,
			[global::Cpp2ILInjected.Token(Token = "0x4003F18")]
			Yoraiz0rShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F19")]
			SkiphsShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F1A")]
			LokisShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F1B")]
			SillySunflowerTops,
			[global::Cpp2ILInjected.Token(Token = "0x4003F1C")]
			PedguinsJacket,
			[global::Cpp2ILInjected.Token(Token = "0x4003F1D")]
			AncientArmor,
			[global::Cpp2ILInjected.Token(Token = "0x4003F1E")]
			AncientBattleArmor,
			[global::Cpp2ILInjected.Token(Token = "0x4003F1F")]
			Lamia,
			[global::Cpp2ILInjected.Token(Token = "0x4003F20")]
			ApprenticeRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003F21")]
			SquirePlating,
			[global::Cpp2ILInjected.Token(Token = "0x4003F22")]
			HuntressJerkin,
			[global::Cpp2ILInjected.Token(Token = "0x4003F23")]
			MonkShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F24")]
			ValhallaKnight,
			[global::Cpp2ILInjected.Token(Token = "0x4003F25")]
			ApprenticeDark,
			[global::Cpp2ILInjected.Token(Token = "0x4003F26")]
			RedRidingHuntress,
			[global::Cpp2ILInjected.Token(Token = "0x4003F27")]
			ShinobiInfiltrator,
			[global::Cpp2ILInjected.Token(Token = "0x4003F28")]
			ArkhalisShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F29")]
			LeinforsShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F2A")]
			DragonBreastplate = 300,
			[global::Cpp2ILInjected.Token(Token = "0x4003F2B")]
			SpectralArmor,
			[global::Cpp2ILInjected.Token(Token = "0x4003F2C")]
			TitanMail,
			[global::Cpp2ILInjected.Token(Token = "0x4003F2D")]
			HornedGodRobe,
			[global::Cpp2ILInjected.Token(Token = "0x4003F2E")]
			FabulousDress,
			[global::Cpp2ILInjected.Token(Token = "0x4003F2F")]
			GeorgesSuit,
			[global::Cpp2ILInjected.Token(Token = "0x4003F30")]
			ShirenShirt,
			[global::Cpp2ILInjected.Token(Token = "0x4003F31")]
			MonokumaBody,
			[global::Cpp2ILInjected.Token(Token = "0x4003F32")]
			MonomiBody,
			[global::Cpp2ILInjected.Token(Token = "0x4003F33")]
			TorosBody,
			[global::Cpp2ILInjected.Token(Token = "0x4003F34")]
			Count
		}

		[global::Cpp2ILInjected.Token(Token = "0x200057A")]
		public enum eHeadSlot
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003F36")]
			None = -1,
			[global::Cpp2ILInjected.Token(Token = "0x4003F37")]
			FamiliarWig,
			[global::Cpp2ILInjected.Token(Token = "0x4003F38")]
			CopperHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F39")]
			IronHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F3A")]
			SilverHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F3B")]
			GoldHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F3C")]
			ShadowHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F3D")]
			MeteorHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F3E")]
			NecroHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F3F")]
			JungleHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F40")]
			MoltenHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F41")]
			Goggles,
			[global::Cpp2ILInjected.Token(Token = "0x4003F42")]
			MiningHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F43")]
			Sunglasses,
			[global::Cpp2ILInjected.Token(Token = "0x4003F44")]
			EmptyBucket,
			[global::Cpp2ILInjected.Token(Token = "0x4003F45")]
			WizardHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F46")]
			TopHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F47")]
			SummerHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F48")]
			BunnyHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003F49")]
			PlumbersHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F4A")]
			HerosHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F4B")]
			FishBowl,
			[global::Cpp2ILInjected.Token(Token = "0x4003F4C")]
			ArchaeologistsHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F4D")]
			NinjaHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003F4E")]
			JungleRose,
			[global::Cpp2ILInjected.Token(Token = "0x4003F4F")]
			RedHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F50")]
			RobotHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F51")]
			GoldCrown,
			[global::Cpp2ILInjected.Token(Token = "0x4003F52")]
			DivingHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F53")]
			MimeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F54")]
			CobaltHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F55")]
			CobaltHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F56")]
			CobaltMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F57")]
			MythrilHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003F58")]
			MythrilHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F59")]
			MythrilHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F5A")]
			AdamantiteHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003F5B")]
			AdamantiteHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F5C")]
			AdamantiteMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F5D")]
			WerewolfHead,
			[global::Cpp2ILInjected.Token(Token = "0x4003F5E")]
			MermanHead,
			[global::Cpp2ILInjected.Token(Token = "0x4003F5F")]
			ClownHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F60")]
			HallowedHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F61")]
			HallowedHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003F62")]
			HallowedMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F63")]
			SantaHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F64")]
			RedsHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F65")]
			FrostHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F66")]
			TinHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F67")]
			LeadHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F68")]
			TungstenHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F69")]
			PlatinumHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F6A")]
			PlatinumCrown,
			[global::Cpp2ILInjected.Token(Token = "0x4003F6B")]
			WoodHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F6C")]
			EbonwoodHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F6D")]
			RichMahoganyHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F6E")]
			PearlwoodHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F6F")]
			RuneHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F70")]
			CrimsonHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F71")]
			EskimoHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003F72")]
			SteampunkHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F73")]
			BeeHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F74")]
			PharaohsMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F75")]
			Tiara,
			[global::Cpp2ILInjected.Token(Token = "0x4003F76")]
			GreenCap,
			[global::Cpp2ILInjected.Token(Token = "0x4003F77")]
			MushroomCap,
			[global::Cpp2ILInjected.Token(Token = "0x4003F78")]
			TamOShanter,
			[global::Cpp2ILInjected.Token(Token = "0x4003F79")]
			MummyMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F7A")]
			CowboyHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F7B")]
			PirateHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F7C")]
			VikingHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F7D")]
			CactusHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F7E")]
			ShadewoodHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F7F")]
			AncientIronHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F80")]
			AncientGoldHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F81")]
			AncientShadowHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F82")]
			AncientNecroHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F83")]
			AncientCobaltHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F84")]
			PinkEskimoHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003F85")]
			ChlorophyteMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F86")]
			ChlorophyteHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F87")]
			ChlorophyteHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003F88")]
			RainHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F89")]
			TikiMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F8A")]
			PalladiumMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F8B")]
			PalladiumHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F8C")]
			PalladiumHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003F8D")]
			OrichalcumMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F8E")]
			OrichalcumHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F8F")]
			OrichalcumHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003F90")]
			TitaniumMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F91")]
			TitaniumHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F92")]
			TitaniumHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003F93")]
			UmbrellaHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F94")]
			Skull,
			[global::Cpp2ILInjected.Token(Token = "0x4003F95")]
			BallaHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F96")]
			GangstaHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F97")]
			SailorHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003F98")]
			EyePatch,
			[global::Cpp2ILInjected.Token(Token = "0x4003F99")]
			SkeletronMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003F9A")]
			TurtleHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F9B")]
			Beanie,
			[global::Cpp2ILInjected.Token(Token = "0x4003F9C")]
			SpectreHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003F9D")]
			SWATHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003F9E")]
			ShroomiteHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003F9F")]
			ShroomiteMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA0")]
			ShroomiteHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA1")]
			CenxsTiara,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA2")]
			CrownosMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA3")]
			WillsHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA4")]
			JimsHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA5")]
			AaronsHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA6")]
			DTownsHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA7")]
			PumpkinHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA8")]
			NurseHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FA9")]
			WizardsHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FAA")]
			GuyFawkesMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FAB")]
			SteampunkGoggles,
			[global::Cpp2ILInjected.Token(Token = "0x4003FAC")]
			CyborgHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FAD")]
			CreeperMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FAE")]
			CatMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FAF")]
			GhostMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB0")]
			PumpkinMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB1")]
			RobotMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB2")]
			UnicornMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB3")]
			VampireMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB4")]
			WitchHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB5")]
			LeprechaunHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB6")]
			PrincessHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB7")]
			BrideofFrankensteinMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB8")]
			KarateTortoiseMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FB9")]
			ScarecrowHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FBA")]
			ReaperHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003FBB")]
			FoxMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FBC")]
			CatEars,
			[global::Cpp2ILInjected.Token(Token = "0x4003FBD")]
			SpookyHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FBE")]
			SpaceCreatureMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FBF")]
			WolfMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC0")]
			JackOLanternMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC1")]
			GiantBow,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC2")]
			ReindeerAntlers,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC3")]
			MrsClauseHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC4")]
			TreeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC5")]
			ParkaHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC6")]
			SnowHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC7")]
			ElfHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC8")]
			Fez,
			[global::Cpp2ILInjected.Token(Token = "0x4003FC9")]
			BrainMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FCA")]
			FleshMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FCB")]
			TwinMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FCC")]
			SkeletronPrimeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FCD")]
			BeeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FCE")]
			PlanteraMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FCF")]
			GolemMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD0")]
			EaterMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD1")]
			EyeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD2")]
			DestroyerMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD3")]
			SpectreMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD4")]
			BeetleHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD5")]
			PeddlersHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD6")]
			MagicHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD7")]
			BeeHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD8")]
			AnglerHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FD9")]
			SpiderMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FDA")]
			SeashellHairpin,
			[global::Cpp2ILInjected.Token(Token = "0x4003FDB")]
			KingSlimeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FDC")]
			FishCostumeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FDD")]
			BorealWoodHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FDE")]
			PalmWoodHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FDF")]
			DukeFishronMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE0")]
			VortexHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE1")]
			NebulaHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE2")]
			SolarFlareHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE3")]
			MoonMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE4")]
			SunMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE5")]
			MartianCostumeMask,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE6")]
			MartianUniformHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE7")]
			WhiteLunaticHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE8")]
			BlueLunaticHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003FE9")]
			HiTekSunglasses,
			[global::Cpp2ILInjected.Token(Token = "0x4003FEA")]
			NightVisionHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FEB")]
			GladiatorHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FEC")]
			BejeweledValkyrieHead,
			[global::Cpp2ILInjected.Token(Token = "0x4003FED")]
			TaxCollectorHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FEE")]
			DyeTraderTurban,
			[global::Cpp2ILInjected.Token(Token = "0x4003FEF")]
			BuccaneerBandana,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF0")]
			ObsidianHelm,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF1")]
			BossMaskCultist,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF2")]
			BossMaskMoonlord,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF3")]
			FossilHelm,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF4")]
			StardustHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF5")]
			TheBrideHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF6")]
			Yoraiz0rHead,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF7")]
			SkiphsHelm,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF8")]
			LokisHelm,
			[global::Cpp2ILInjected.Token(Token = "0x4003FF9")]
			EngineeringHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4003FFA")]
			PartyHat,
			[global::Cpp2ILInjected.Token(Token = "0x4003FFB")]
			SillySunflowerPetals,
			[global::Cpp2ILInjected.Token(Token = "0x4003FFC")]
			PedguinsHood,
			[global::Cpp2ILInjected.Token(Token = "0x4003FFD")]
			_0x33sAviators,
			[global::Cpp2ILInjected.Token(Token = "0x4003FFE")]
			AncientArmor,
			[global::Cpp2ILInjected.Token(Token = "0x4003FFF")]
			AncientBattleArmor,
			[global::Cpp2ILInjected.Token(Token = "0x4004000")]
			LamiaMale,
			[global::Cpp2ILInjected.Token(Token = "0x4004001")]
			LamiaFemale,
			[global::Cpp2ILInjected.Token(Token = "0x4004002")]
			ApprenticeHat,
			[global::Cpp2ILInjected.Token(Token = "0x4004003")]
			SquireGreatHelm,
			[global::Cpp2ILInjected.Token(Token = "0x4004004")]
			HuntressWig,
			[global::Cpp2ILInjected.Token(Token = "0x4004005")]
			MonkBrows,
			[global::Cpp2ILInjected.Token(Token = "0x4004006")]
			MaskBetsy,
			[global::Cpp2ILInjected.Token(Token = "0x4004007")]
			MaskDarkMage,
			[global::Cpp2ILInjected.Token(Token = "0x4004008")]
			MaskOgre,
			[global::Cpp2ILInjected.Token(Token = "0x4004009")]
			ValhallaKnight,
			[global::Cpp2ILInjected.Token(Token = "0x400400A")]
			ApprenticeDark,
			[global::Cpp2ILInjected.Token(Token = "0x400400B")]
			RedRidingHuntress,
			[global::Cpp2ILInjected.Token(Token = "0x400400C")]
			ShinobiInfiltrator,
			[global::Cpp2ILInjected.Token(Token = "0x400400D")]
			ArkhalisHat,
			[global::Cpp2ILInjected.Token(Token = "0x400400E")]
			LeinforsHat,
			[global::Cpp2ILInjected.Token(Token = "0x400400F")]
			DragonMask = 300,
			[global::Cpp2ILInjected.Token(Token = "0x4004010")]
			SpectralHeadgear,
			[global::Cpp2ILInjected.Token(Token = "0x4004011")]
			TitanHelmet,
			[global::Cpp2ILInjected.Token(Token = "0x4004012")]
			OcramMask,
			[global::Cpp2ILInjected.Token(Token = "0x4004013")]
			HornedGodMask,
			[global::Cpp2ILInjected.Token(Token = "0x4004014")]
			FabulousRibbon,
			[global::Cpp2ILInjected.Token(Token = "0x4004015")]
			GeorgesHat,
			[global::Cpp2ILInjected.Token(Token = "0x4004016")]
			ShirenHat,
			[global::Cpp2ILInjected.Token(Token = "0x4004017")]
			MonokumaHead,
			[global::Cpp2ILInjected.Token(Token = "0x4004018")]
			MonomiHead,
			[global::Cpp2ILInjected.Token(Token = "0x4004019")]
			TorosHead,
			[global::Cpp2ILInjected.Token(Token = "0x400401A")]
			Count
		}

		[global::Cpp2ILInjected.Token(Token = "0x200057B")]
		public enum eLegSlot
		{
			[global::Cpp2ILInjected.Token(Token = "0x400401C")]
			None = -1,
			[global::Cpp2ILInjected.Token(Token = "0x400401D")]
			FamiliarPants,
			[global::Cpp2ILInjected.Token(Token = "0x400401E")]
			CopperGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400401F")]
			IronGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004020")]
			SilverGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004021")]
			GoldGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004022")]
			ShadowGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004023")]
			MeteorLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004024")]
			NecroGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004025")]
			JunglePants,
			[global::Cpp2ILInjected.Token(Token = "0x4004026")]
			MoltenGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004027")]
			TuxedoPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004028")]
			PlumbersPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004029")]
			HerosPants,
			[global::Cpp2ILInjected.Token(Token = "0x400402A")]
			ArchaeologistsPants,
			[global::Cpp2ILInjected.Token(Token = "0x400402B")]
			NinjaPants,
			[global::Cpp2ILInjected.Token(Token = "0x400402C")]
			TheDoctorsPants,
			[global::Cpp2ILInjected.Token(Token = "0x400402D")]
			CobaltLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400402E")]
			MythrilGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400402F")]
			AdamantiteLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004030")]
			MiningPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004031")]
			WerewolfLegs,
			[global::Cpp2ILInjected.Token(Token = "0x4004032")]
			MermanLegs,
			[global::Cpp2ILInjected.Token(Token = "0x4004033")]
			ClownPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004034")]
			HallowedGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004035")]
			SantaPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004036")]
			RedsLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004037")]
			FrostLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004038")]
			TinGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004039")]
			LeadGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400403A")]
			TungstenGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400403B")]
			PlatinumGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400403C")]
			WoodGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400403D")]
			EbonwoodGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400403E")]
			RichMahoganyGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400403F")]
			PearlwoodGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004040")]
			CrimsonGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004041")]
			EskimoPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004042")]
			SteampunkPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004043")]
			BeePants,
			[global::Cpp2ILInjected.Token(Token = "0x4004044")]
			MummyPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004045")]
			CowboyPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004046")]
			PiratePants,
			[global::Cpp2ILInjected.Token(Token = "0x4004047")]
			CactusLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004048")]
			ShadewoodGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004049")]
			AncientShadowGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400404A")]
			AncientCobaltLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400404B")]
			PinkEskimoPants,
			[global::Cpp2ILInjected.Token(Token = "0x400404C")]
			ChlorophyteGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400404D")]
			TikiPants,
			[global::Cpp2ILInjected.Token(Token = "0x400404E")]
			PalladiumLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400404F")]
			OrichalcumLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004050")]
			TitaniumLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004051")]
			SailorPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004052")]
			WhiteTuxedoPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004053")]
			TurtleLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004054")]
			SpectrePants,
			[global::Cpp2ILInjected.Token(Token = "0x4004055")]
			ShroomiteLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004056")]
			CenxsLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004057")]
			CrownosLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004058")]
			WillsLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004059")]
			JimsLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400405A")]
			AaronsLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400405B")]
			DTownsLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400405C")]
			CenxsDressPants,
			[global::Cpp2ILInjected.Token(Token = "0x400405D")]
			PumpkinLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400405E")]
			NursePants,
			[global::Cpp2ILInjected.Token(Token = "0x400405F")]
			CyborgPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004060")]
			CreeperPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004061")]
			CatPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004062")]
			PumpkinPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004063")]
			RobotPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004064")]
			UnicornPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004065")]
			VampirePants,
			[global::Cpp2ILInjected.Token(Token = "0x4004066")]
			LeprechaunPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004067")]
			PixiePants,
			[global::Cpp2ILInjected.Token(Token = "0x4004068")]
			WitchBoots,
			[global::Cpp2ILInjected.Token(Token = "0x4004069")]
			KarateTortoisePants,
			[global::Cpp2ILInjected.Token(Token = "0x400406A")]
			ScarecrowPants,
			[global::Cpp2ILInjected.Token(Token = "0x400406B")]
			FoxPants,
			[global::Cpp2ILInjected.Token(Token = "0x400406C")]
			SpookyLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400406D")]
			SpaceCreaturePants,
			[global::Cpp2ILInjected.Token(Token = "0x400406E")]
			WolfPants,
			[global::Cpp2ILInjected.Token(Token = "0x400406F")]
			TreasureHunterPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004070")]
			DryadLoincloth,
			[global::Cpp2ILInjected.Token(Token = "0x4004071")]
			MrsClauseHeels,
			[global::Cpp2ILInjected.Token(Token = "0x4004072")]
			TreeTrunks,
			[global::Cpp2ILInjected.Token(Token = "0x4004073")]
			ParkaPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004074")]
			ElfPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004075")]
			BeetleLeggings = 98,
			[global::Cpp2ILInjected.Token(Token = "0x4004076")]
			BeeGreaves = 103,
			[global::Cpp2ILInjected.Token(Token = "0x4004077")]
			AnglerPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004078")]
			SpiderGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004079")]
			MermaidTail,
			[global::Cpp2ILInjected.Token(Token = "0x400407A")]
			FishCostumeFinskirt,
			[global::Cpp2ILInjected.Token(Token = "0x400407B")]
			BorealWoodGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400407C")]
			PalmWoodGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x400407D")]
			VortexLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400407E")]
			NebulaLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400407F")]
			SolarFlareLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x4004080")]
			MartianCostumePants,
			[global::Cpp2ILInjected.Token(Token = "0x4004081")]
			MartianUniformPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004082")]
			DryadLoinclothOnMannequin = 117,
			[global::Cpp2ILInjected.Token(Token = "0x4004083")]
			MrsClauseHeelsOnMannequin = 120,
			[global::Cpp2ILInjected.Token(Token = "0x4004084")]
			GladiatorLeggings = 122,
			[global::Cpp2ILInjected.Token(Token = "0x4004085")]
			TaxCollectorPants = 124,
			[global::Cpp2ILInjected.Token(Token = "0x4004086")]
			ClothierPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004087")]
			BuccaneerPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004088")]
			ObsidianPants,
			[global::Cpp2ILInjected.Token(Token = "0x4004089")]
			FallenTuxedoPants,
			[global::Cpp2ILInjected.Token(Token = "0x400408A")]
			FossilPants,
			[global::Cpp2ILInjected.Token(Token = "0x400408B")]
			StardustLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x400408C")]
			Yoraiz0rPants = 132,
			[global::Cpp2ILInjected.Token(Token = "0x400408D")]
			SkiphsPants,
			[global::Cpp2ILInjected.Token(Token = "0x400408E")]
			LokisPants,
			[global::Cpp2ILInjected.Token(Token = "0x400408F")]
			SillySunflowerBottoms = 138,
			[global::Cpp2ILInjected.Token(Token = "0x4004090")]
			PedguinsTrousers,
			[global::Cpp2ILInjected.Token(Token = "0x4004091")]
			DjinnsCurse,
			[global::Cpp2ILInjected.Token(Token = "0x4004092")]
			AncientArmor,
			[global::Cpp2ILInjected.Token(Token = "0x4004093")]
			AncientBattleArmor,
			[global::Cpp2ILInjected.Token(Token = "0x4004094")]
			Lamia,
			[global::Cpp2ILInjected.Token(Token = "0x4004095")]
			ApprenticeTrousers,
			[global::Cpp2ILInjected.Token(Token = "0x4004096")]
			SquireGreaves,
			[global::Cpp2ILInjected.Token(Token = "0x4004097")]
			HuntressPantsMale,
			[global::Cpp2ILInjected.Token(Token = "0x4004098")]
			HuntressPantsFemale,
			[global::Cpp2ILInjected.Token(Token = "0x4004099")]
			MonkPants,
			[global::Cpp2ILInjected.Token(Token = "0x400409A")]
			ApprenticeRobeExtension,
			[global::Cpp2ILInjected.Token(Token = "0x400409B")]
			SquirePlatingExtension,
			[global::Cpp2ILInjected.Token(Token = "0x400409C")]
			HuntressJerkinExtension,
			[global::Cpp2ILInjected.Token(Token = "0x400409D")]
			ValhallaKnight,
			[global::Cpp2ILInjected.Token(Token = "0x400409E")]
			ApprenticeDark,
			[global::Cpp2ILInjected.Token(Token = "0x400409F")]
			RedRidingHuntress,
			[global::Cpp2ILInjected.Token(Token = "0x40040A0")]
			RedRidingHuntress_Male,
			[global::Cpp2ILInjected.Token(Token = "0x40040A1")]
			ShinobiInfiltrator,
			[global::Cpp2ILInjected.Token(Token = "0x40040A2")]
			ArkhalisPants_Male,
			[global::Cpp2ILInjected.Token(Token = "0x40040A3")]
			ArkhalisPants_Female,
			[global::Cpp2ILInjected.Token(Token = "0x40040A4")]
			LeinforsPants,
			[global::Cpp2ILInjected.Token(Token = "0x40040A5")]
			LeinforsPantsCoat,
			[global::Cpp2ILInjected.Token(Token = "0x40040A6")]
			DragonGreaves = 300,
			[global::Cpp2ILInjected.Token(Token = "0x40040A7")]
			SpectralSubligar,
			[global::Cpp2ILInjected.Token(Token = "0x40040A8")]
			TitanLeggings,
			[global::Cpp2ILInjected.Token(Token = "0x40040A9")]
			HornedGodBoots,
			[global::Cpp2ILInjected.Token(Token = "0x40040AA")]
			FabulousSlippers,
			[global::Cpp2ILInjected.Token(Token = "0x40040AB")]
			GeorgesPants,
			[global::Cpp2ILInjected.Token(Token = "0x40040AC")]
			ShirenPants,
			[global::Cpp2ILInjected.Token(Token = "0x40040AD")]
			MonokumaLegs,
			[global::Cpp2ILInjected.Token(Token = "0x40040AE")]
			MonomiLegs,
			[global::Cpp2ILInjected.Token(Token = "0x40040AF")]
			TorosLegs,
			[global::Cpp2ILInjected.Token(Token = "0x40040B0")]
			Count
		}
	}
}
