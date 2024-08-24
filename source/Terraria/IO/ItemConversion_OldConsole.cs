using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.IO
{
	// Token: 0x020003CE RID: 974
	[global::Cpp2ILInjected.Token(Token = "0x2000578")]
	public static class ItemConversion_OldConsole
	{
		// Token: 0x06002F93 RID: 12179 RVA: 0x0002A803 File Offset: 0x00028A03
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

		// Token: 0x06002F94 RID: 12180 RVA: 0x0002A806 File Offset: 0x00028A06
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

		// Token: 0x06002F95 RID: 12181 RVA: 0x0002A809 File Offset: 0x00028A09
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

		// Token: 0x06002F96 RID: 12182 RVA: 0x0002A80C File Offset: 0x00028A0C
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

		// Token: 0x06002F97 RID: 12183 RVA: 0x0002A80F File Offset: 0x00028A0F
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

		// Token: 0x04003307 RID: 13063
		[global::Cpp2ILInjected.Token(Token = "0x4003E67")]
		private const short DragonMask = 10000;

		// Token: 0x04003308 RID: 13064
		[global::Cpp2ILInjected.Token(Token = "0x4003E68")]
		private const short DragonBreastplate = 10001;

		// Token: 0x04003309 RID: 13065
		[global::Cpp2ILInjected.Token(Token = "0x4003E69")]
		private const short DragonGreaves = 10002;

		// Token: 0x0400330A RID: 13066
		[global::Cpp2ILInjected.Token(Token = "0x4003E6A")]
		private const short SpectralHeadgear = 10003;

		// Token: 0x0400330B RID: 13067
		[global::Cpp2ILInjected.Token(Token = "0x4003E6B")]
		private const short SpectralArmor = 10004;

		// Token: 0x0400330C RID: 13068
		[global::Cpp2ILInjected.Token(Token = "0x4003E6C")]
		private const short SpectralSubligar = 10005;

		// Token: 0x0400330D RID: 13069
		[global::Cpp2ILInjected.Token(Token = "0x4003E6D")]
		private const short TitanHelmet = 10006;

		// Token: 0x0400330E RID: 13070
		[global::Cpp2ILInjected.Token(Token = "0x4003E6E")]
		private const short TitanMail = 10007;

		// Token: 0x0400330F RID: 13071
		[global::Cpp2ILInjected.Token(Token = "0x4003E6F")]
		private const short TitanLeggings = 10008;

		// Token: 0x04003310 RID: 13072
		[global::Cpp2ILInjected.Token(Token = "0x4003E70")]
		private const short OcramMask = 10009;

		// Token: 0x04003311 RID: 13073
		[global::Cpp2ILInjected.Token(Token = "0x4003E71")]
		private const short HornedGodMask = 10010;

		// Token: 0x04003312 RID: 13074
		[global::Cpp2ILInjected.Token(Token = "0x4003E72")]
		private const short HornedGodRobe = 10011;

		// Token: 0x04003313 RID: 13075
		[global::Cpp2ILInjected.Token(Token = "0x4003E73")]
		private const short HornedGodBoots = 10012;

		// Token: 0x04003314 RID: 13076
		[global::Cpp2ILInjected.Token(Token = "0x4003E74")]
		private const short OcramTrophy = 10013;

		// Token: 0x04003315 RID: 13077
		[global::Cpp2ILInjected.Token(Token = "0x4003E75")]
		private const short AlbinoAntlionBanner = 10014;

		// Token: 0x04003316 RID: 13078
		[global::Cpp2ILInjected.Token(Token = "0x4003E76")]
		private const short ArchWyvernBanner = 10015;

		// Token: 0x04003317 RID: 13079
		[global::Cpp2ILInjected.Token(Token = "0x4003E77")]
		private const short ArchDemonBanner = 10016;

		// Token: 0x04003318 RID: 13080
		[global::Cpp2ILInjected.Token(Token = "0x4003E78")]
		private const short DragonSnatcherBanner = 10017;

		// Token: 0x04003319 RID: 13081
		[global::Cpp2ILInjected.Token(Token = "0x4003E79")]
		private const short OrcaBanner = 10018;

		// Token: 0x0400331A RID: 13082
		[global::Cpp2ILInjected.Token(Token = "0x4003E7A")]
		private const short ShadowHammerBanner = 10019;

		// Token: 0x0400331B RID: 13083
		[global::Cpp2ILInjected.Token(Token = "0x4003E7B")]
		private const short ShadowMummyBanner = 10020;

		// Token: 0x0400331C RID: 13084
		[global::Cpp2ILInjected.Token(Token = "0x4003E7C")]
		private const short SpectralGastropodBanner = 10021;

		// Token: 0x0400331D RID: 13085
		[global::Cpp2ILInjected.Token(Token = "0x4003E7D")]
		private const short SpectralElementalBanner = 10022;

		// Token: 0x0400331E RID: 13086
		[global::Cpp2ILInjected.Token(Token = "0x4003E7E")]
		private const short VampireMinerBanner = 10023;

		// Token: 0x0400331F RID: 13087
		[global::Cpp2ILInjected.Token(Token = "0x4003E7F")]
		private const short MusicBoxTutorial = 10024;

		// Token: 0x04003320 RID: 13088
		[global::Cpp2ILInjected.Token(Token = "0x4003E80")]
		private const short StarTopper4 = 10025;

		// Token: 0x04003321 RID: 13089
		[global::Cpp2ILInjected.Token(Token = "0x4003E81")]
		private const short StarTopper5 = 10026;

		// Token: 0x04003322 RID: 13090
		[global::Cpp2ILInjected.Token(Token = "0x4003E82")]
		private const short ShirenHat = 10027;

		// Token: 0x04003323 RID: 13091
		[global::Cpp2ILInjected.Token(Token = "0x4003E83")]
		private const short ShirenShirt = 10028;

		// Token: 0x04003324 RID: 13092
		[global::Cpp2ILInjected.Token(Token = "0x4003E84")]
		private const short ShirenPants = 10029;

		// Token: 0x04003325 RID: 13093
		[global::Cpp2ILInjected.Token(Token = "0x4003E85")]
		private const short MonokumaHead = 10030;

		// Token: 0x04003326 RID: 13094
		[global::Cpp2ILInjected.Token(Token = "0x4003E86")]
		private const short MonokumaBody = 10031;

		// Token: 0x04003327 RID: 13095
		[global::Cpp2ILInjected.Token(Token = "0x4003E87")]
		private const short MonokumaLegs = 10032;

		// Token: 0x04003328 RID: 13096
		[global::Cpp2ILInjected.Token(Token = "0x4003E88")]
		private const short WhiteThread = 10033;

		// Token: 0x04003329 RID: 13097
		[global::Cpp2ILInjected.Token(Token = "0x4003E89")]
		private const short MonomiHead = 10034;

		// Token: 0x0400332A RID: 13098
		[global::Cpp2ILInjected.Token(Token = "0x4003E8A")]
		private const short MonomiBody = 10035;

		// Token: 0x0400332B RID: 13099
		[global::Cpp2ILInjected.Token(Token = "0x4003E8B")]
		private const short MonomiLegs = 10036;

		// Token: 0x0400332C RID: 13100
		[global::Cpp2ILInjected.Token(Token = "0x4003E8C")]
		private const short TorosHead = 10037;

		// Token: 0x0400332D RID: 13101
		[global::Cpp2ILInjected.Token(Token = "0x4003E8D")]
		private const short TorosBody = 10038;

		// Token: 0x0400332E RID: 13102
		[global::Cpp2ILInjected.Token(Token = "0x4003E8E")]
		private const short TorosLegs = 10039;

		// Token: 0x0400332F RID: 13103
		[global::Cpp2ILInjected.Token(Token = "0x4003E8F")]
		public static int CompensatedCurrency;

		// Token: 0x020008FA RID: 2298
		[global::Cpp2ILInjected.Token(Token = "0x2000579")]
		public enum eBodySlot
		{
			// Token: 0x04008304 RID: 33540
			[global::Cpp2ILInjected.Token(Token = "0x4003E91")]
			None = -1,
			// Token: 0x04008305 RID: 33541
			[global::Cpp2ILInjected.Token(Token = "0x4003E92")]
			FamiliarShirt,
			// Token: 0x04008306 RID: 33542
			[global::Cpp2ILInjected.Token(Token = "0x4003E93")]
			CopperChainmail,
			// Token: 0x04008307 RID: 33543
			[global::Cpp2ILInjected.Token(Token = "0x4003E94")]
			IronChainmail,
			// Token: 0x04008308 RID: 33544
			[global::Cpp2ILInjected.Token(Token = "0x4003E95")]
			SilverChainmail,
			// Token: 0x04008309 RID: 33545
			[global::Cpp2ILInjected.Token(Token = "0x4003E96")]
			GoldChainmail,
			// Token: 0x0400830A RID: 33546
			[global::Cpp2ILInjected.Token(Token = "0x4003E97")]
			ShadowScalemail,
			// Token: 0x0400830B RID: 33547
			[global::Cpp2ILInjected.Token(Token = "0x4003E98")]
			MeteorSuit,
			// Token: 0x0400830C RID: 33548
			[global::Cpp2ILInjected.Token(Token = "0x4003E99")]
			NecroBreastplate,
			// Token: 0x0400830D RID: 33549
			[global::Cpp2ILInjected.Token(Token = "0x4003E9A")]
			JungleShirt,
			// Token: 0x0400830E RID: 33550
			[global::Cpp2ILInjected.Token(Token = "0x4003E9B")]
			MoltenBreastplate,
			// Token: 0x0400830F RID: 33551
			[global::Cpp2ILInjected.Token(Token = "0x4003E9C")]
			TuxedoShirt,
			// Token: 0x04008310 RID: 33552
			[global::Cpp2ILInjected.Token(Token = "0x4003E9D")]
			PlumbersShirt,
			// Token: 0x04008311 RID: 33553
			[global::Cpp2ILInjected.Token(Token = "0x4003E9E")]
			HerosShirt,
			// Token: 0x04008312 RID: 33554
			[global::Cpp2ILInjected.Token(Token = "0x4003E9F")]
			ArchaeologistsJacket,
			// Token: 0x04008313 RID: 33555
			[global::Cpp2ILInjected.Token(Token = "0x4003EA0")]
			NinjaShirt,
			// Token: 0x04008314 RID: 33556
			[global::Cpp2ILInjected.Token(Token = "0x4003EA1")]
			Robe,
			// Token: 0x04008315 RID: 33557
			[global::Cpp2ILInjected.Token(Token = "0x4003EA2")]
			TheDoctorsShirt,
			// Token: 0x04008316 RID: 33558
			[global::Cpp2ILInjected.Token(Token = "0x4003EA3")]
			CobaltBreastplate,
			// Token: 0x04008317 RID: 33559
			[global::Cpp2ILInjected.Token(Token = "0x4003EA4")]
			MythrilChainmail,
			// Token: 0x04008318 RID: 33560
			[global::Cpp2ILInjected.Token(Token = "0x4003EA5")]
			AdamantiteBreastplate,
			// Token: 0x04008319 RID: 33561
			[global::Cpp2ILInjected.Token(Token = "0x4003EA6")]
			MiningShirt,
			// Token: 0x0400831A RID: 33562
			[global::Cpp2ILInjected.Token(Token = "0x4003EA7")]
			WerewolfBody,
			// Token: 0x0400831B RID: 33563
			[global::Cpp2ILInjected.Token(Token = "0x4003EA8")]
			MermanBody,
			// Token: 0x0400831C RID: 33564
			[global::Cpp2ILInjected.Token(Token = "0x4003EA9")]
			ClownShirt,
			// Token: 0x0400831D RID: 33565
			[global::Cpp2ILInjected.Token(Token = "0x4003EAA")]
			HallowedPlateMail,
			// Token: 0x0400831E RID: 33566
			[global::Cpp2ILInjected.Token(Token = "0x4003EAB")]
			SantaShirt,
			// Token: 0x0400831F RID: 33567
			[global::Cpp2ILInjected.Token(Token = "0x4003EAC")]
			RedsBreastplate,
			// Token: 0x04008320 RID: 33568
			[global::Cpp2ILInjected.Token(Token = "0x4003EAD")]
			FrostBreastplate,
			// Token: 0x04008321 RID: 33569
			[global::Cpp2ILInjected.Token(Token = "0x4003EAE")]
			TinChainmail,
			// Token: 0x04008322 RID: 33570
			[global::Cpp2ILInjected.Token(Token = "0x4003EAF")]
			LeadChainmail,
			// Token: 0x04008323 RID: 33571
			[global::Cpp2ILInjected.Token(Token = "0x4003EB0")]
			TungstenChainmail,
			// Token: 0x04008324 RID: 33572
			[global::Cpp2ILInjected.Token(Token = "0x4003EB1")]
			PlatinumChainmail,
			// Token: 0x04008325 RID: 33573
			[global::Cpp2ILInjected.Token(Token = "0x4003EB2")]
			WoodBreastplate,
			// Token: 0x04008326 RID: 33574
			[global::Cpp2ILInjected.Token(Token = "0x4003EB3")]
			EbonwoodBreastplate,
			// Token: 0x04008327 RID: 33575
			[global::Cpp2ILInjected.Token(Token = "0x4003EB4")]
			RichMahoganyBreastplate,
			// Token: 0x04008328 RID: 33576
			[global::Cpp2ILInjected.Token(Token = "0x4003EB5")]
			PearlwoodBreastplate,
			// Token: 0x04008329 RID: 33577
			[global::Cpp2ILInjected.Token(Token = "0x4003EB6")]
			RuneRobe,
			// Token: 0x0400832A RID: 33578
			[global::Cpp2ILInjected.Token(Token = "0x4003EB7")]
			CrimsonScalemail,
			// Token: 0x0400832B RID: 33579
			[global::Cpp2ILInjected.Token(Token = "0x4003EB8")]
			EskimoCoat,
			// Token: 0x0400832C RID: 33580
			[global::Cpp2ILInjected.Token(Token = "0x4003EB9")]
			SteampunkShirt,
			// Token: 0x0400832D RID: 33581
			[global::Cpp2ILInjected.Token(Token = "0x4003EBA")]
			BeeShirt,
			// Token: 0x0400832E RID: 33582
			[global::Cpp2ILInjected.Token(Token = "0x4003EBB")]
			PrincessDress,
			// Token: 0x0400832F RID: 33583
			[global::Cpp2ILInjected.Token(Token = "0x4003EBC")]
			PharaohsRobe,
			// Token: 0x04008330 RID: 33584
			[global::Cpp2ILInjected.Token(Token = "0x4003EBD")]
			MummyShirt,
			// Token: 0x04008331 RID: 33585
			[global::Cpp2ILInjected.Token(Token = "0x4003EBE")]
			CowboyJacket,
			// Token: 0x04008332 RID: 33586
			[global::Cpp2ILInjected.Token(Token = "0x4003EBF")]
			PirateShirt,
			// Token: 0x04008333 RID: 33587
			[global::Cpp2ILInjected.Token(Token = "0x4003EC0")]
			CactusBreastplate,
			// Token: 0x04008334 RID: 33588
			[global::Cpp2ILInjected.Token(Token = "0x4003EC1")]
			ShadewoodBreastplate,
			// Token: 0x04008335 RID: 33589
			[global::Cpp2ILInjected.Token(Token = "0x4003EC2")]
			AncientShadowScalemail,
			// Token: 0x04008336 RID: 33590
			[global::Cpp2ILInjected.Token(Token = "0x4003EC3")]
			AncientCobaltBreastplate,
			// Token: 0x04008337 RID: 33591
			[global::Cpp2ILInjected.Token(Token = "0x4003EC4")]
			PinkEskimoCoat,
			// Token: 0x04008338 RID: 33592
			[global::Cpp2ILInjected.Token(Token = "0x4003EC5")]
			ChlorophytePlateMail,
			// Token: 0x04008339 RID: 33593
			[global::Cpp2ILInjected.Token(Token = "0x4003EC6")]
			RainCoat,
			// Token: 0x0400833A RID: 33594
			[global::Cpp2ILInjected.Token(Token = "0x4003EC7")]
			TikiShirt,
			// Token: 0x0400833B RID: 33595
			[global::Cpp2ILInjected.Token(Token = "0x4003EC8")]
			PalladiumBreastplate,
			// Token: 0x0400833C RID: 33596
			[global::Cpp2ILInjected.Token(Token = "0x4003EC9")]
			OrichalcumBreastplate,
			// Token: 0x0400833D RID: 33597
			[global::Cpp2ILInjected.Token(Token = "0x4003ECA")]
			TitaniumBreastplate,
			// Token: 0x0400833E RID: 33598
			[global::Cpp2ILInjected.Token(Token = "0x4003ECB")]
			SailorShirt,
			// Token: 0x0400833F RID: 33599
			[global::Cpp2ILInjected.Token(Token = "0x4003ECC")]
			AmethystRobe,
			// Token: 0x04008340 RID: 33600
			[global::Cpp2ILInjected.Token(Token = "0x4003ECD")]
			TopazRobe,
			// Token: 0x04008341 RID: 33601
			[global::Cpp2ILInjected.Token(Token = "0x4003ECE")]
			SapphireRobe,
			// Token: 0x04008342 RID: 33602
			[global::Cpp2ILInjected.Token(Token = "0x4003ECF")]
			EmeraldRobe,
			// Token: 0x04008343 RID: 33603
			[global::Cpp2ILInjected.Token(Token = "0x4003ED0")]
			RubyRobe,
			// Token: 0x04008344 RID: 33604
			[global::Cpp2ILInjected.Token(Token = "0x4003ED1")]
			DiamondRobe,
			// Token: 0x04008345 RID: 33605
			[global::Cpp2ILInjected.Token(Token = "0x4003ED2")]
			WhiteTuxedoShirt,
			// Token: 0x04008346 RID: 33606
			[global::Cpp2ILInjected.Token(Token = "0x4003ED3")]
			TurtleScaleMail,
			// Token: 0x04008347 RID: 33607
			[global::Cpp2ILInjected.Token(Token = "0x4003ED4")]
			SpectreRobe,
			// Token: 0x04008348 RID: 33608
			[global::Cpp2ILInjected.Token(Token = "0x4003ED5")]
			ShroomiteBreastplate,
			// Token: 0x04008349 RID: 33609
			[global::Cpp2ILInjected.Token(Token = "0x4003ED6")]
			CenxsBreastplate,
			// Token: 0x0400834A RID: 33610
			[global::Cpp2ILInjected.Token(Token = "0x4003ED7")]
			CrownosBreastplate,
			// Token: 0x0400834B RID: 33611
			[global::Cpp2ILInjected.Token(Token = "0x4003ED8")]
			WillsBreastplate,
			// Token: 0x0400834C RID: 33612
			[global::Cpp2ILInjected.Token(Token = "0x4003ED9")]
			JimsBreastplate,
			// Token: 0x0400834D RID: 33613
			[global::Cpp2ILInjected.Token(Token = "0x4003EDA")]
			AaronsBreastplate,
			// Token: 0x0400834E RID: 33614
			[global::Cpp2ILInjected.Token(Token = "0x4003EDB")]
			DTownsBreastplate,
			// Token: 0x0400834F RID: 33615
			[global::Cpp2ILInjected.Token(Token = "0x4003EDC")]
			CenxsDress,
			// Token: 0x04008350 RID: 33616
			[global::Cpp2ILInjected.Token(Token = "0x4003EDD")]
			PumpkinBreastplate,
			// Token: 0x04008351 RID: 33617
			[global::Cpp2ILInjected.Token(Token = "0x4003EDE")]
			NurseShirt,
			// Token: 0x04008352 RID: 33618
			[global::Cpp2ILInjected.Token(Token = "0x4003EDF")]
			DyeTraderRobe,
			// Token: 0x04008353 RID: 33619
			[global::Cpp2ILInjected.Token(Token = "0x4003EE0")]
			CyborgShirt,
			// Token: 0x04008354 RID: 33620
			[global::Cpp2ILInjected.Token(Token = "0x4003EE1")]
			CreeperShirt,
			// Token: 0x04008355 RID: 33621
			[global::Cpp2ILInjected.Token(Token = "0x4003EE2")]
			CatShirt,
			// Token: 0x04008356 RID: 33622
			[global::Cpp2ILInjected.Token(Token = "0x4003EE3")]
			GhostShirt,
			// Token: 0x04008357 RID: 33623
			[global::Cpp2ILInjected.Token(Token = "0x4003EE4")]
			PumpkinShirt,
			// Token: 0x04008358 RID: 33624
			[global::Cpp2ILInjected.Token(Token = "0x4003EE5")]
			RobotShirt,
			// Token: 0x04008359 RID: 33625
			[global::Cpp2ILInjected.Token(Token = "0x4003EE6")]
			UnicornShirt,
			// Token: 0x0400835A RID: 33626
			[global::Cpp2ILInjected.Token(Token = "0x4003EE7")]
			VampireShirt,
			// Token: 0x0400835B RID: 33627
			[global::Cpp2ILInjected.Token(Token = "0x4003EE8")]
			LeprechaunShirt,
			// Token: 0x0400835C RID: 33628
			[global::Cpp2ILInjected.Token(Token = "0x4003EE9")]
			PixieShirt,
			// Token: 0x0400835D RID: 33629
			[global::Cpp2ILInjected.Token(Token = "0x4003EEA")]
			PrincessDressNew,
			// Token: 0x0400835E RID: 33630
			[global::Cpp2ILInjected.Token(Token = "0x4003EEB")]
			WitchDress,
			// Token: 0x0400835F RID: 33631
			[global::Cpp2ILInjected.Token(Token = "0x4003EEC")]
			BrideofFrankensteinDress,
			// Token: 0x04008360 RID: 33632
			[global::Cpp2ILInjected.Token(Token = "0x4003EED")]
			KarateTortoiseShirt,
			// Token: 0x04008361 RID: 33633
			[global::Cpp2ILInjected.Token(Token = "0x4003EEE")]
			ScarecrowShirt,
			// Token: 0x04008362 RID: 33634
			[global::Cpp2ILInjected.Token(Token = "0x4003EEF")]
			ReaperRobe,
			// Token: 0x04008363 RID: 33635
			[global::Cpp2ILInjected.Token(Token = "0x4003EF0")]
			FoxShirt,
			// Token: 0x04008364 RID: 33636
			[global::Cpp2ILInjected.Token(Token = "0x4003EF1")]
			SpookyBreastplate,
			// Token: 0x04008365 RID: 33637
			[global::Cpp2ILInjected.Token(Token = "0x4003EF2")]
			SpaceCreatureShirt,
			// Token: 0x04008366 RID: 33638
			[global::Cpp2ILInjected.Token(Token = "0x4003EF3")]
			WolfShirt,
			// Token: 0x04008367 RID: 33639
			[global::Cpp2ILInjected.Token(Token = "0x4003EF4")]
			TreasureHunterShirt,
			// Token: 0x04008368 RID: 33640
			[global::Cpp2ILInjected.Token(Token = "0x4003EF5")]
			DryadCoverings,
			// Token: 0x04008369 RID: 33641
			[global::Cpp2ILInjected.Token(Token = "0x4003EF6")]
			MrsClauseShirt,
			// Token: 0x0400836A RID: 33642
			[global::Cpp2ILInjected.Token(Token = "0x4003EF7")]
			TreeShirt,
			// Token: 0x0400836B RID: 33643
			[global::Cpp2ILInjected.Token(Token = "0x4003EF8")]
			ParkaCoat,
			// Token: 0x0400836C RID: 33644
			[global::Cpp2ILInjected.Token(Token = "0x4003EF9")]
			UglySweater,
			// Token: 0x0400836D RID: 33645
			[global::Cpp2ILInjected.Token(Token = "0x4003EFA")]
			ElfShirt,
			// Token: 0x0400836E RID: 33646
			[global::Cpp2ILInjected.Token(Token = "0x4003EFB")]
			BeetleScaleMail,
			// Token: 0x0400836F RID: 33647
			[global::Cpp2ILInjected.Token(Token = "0x4003EFC")]
			BeetleShell,
			// Token: 0x04008370 RID: 33648
			[global::Cpp2ILInjected.Token(Token = "0x4003EFD")]
			Gi = 165,
			// Token: 0x04008371 RID: 33649
			[global::Cpp2ILInjected.Token(Token = "0x4003EFE")]
			Kimono,
			// Token: 0x04008372 RID: 33650
			[global::Cpp2ILInjected.Token(Token = "0x4003EFF")]
			GypsyRobe,
			// Token: 0x04008373 RID: 33651
			[global::Cpp2ILInjected.Token(Token = "0x4003F00")]
			BeeBreastplate,
			// Token: 0x04008374 RID: 33652
			[global::Cpp2ILInjected.Token(Token = "0x4003F01")]
			AnglerVest,
			// Token: 0x04008375 RID: 33653
			[global::Cpp2ILInjected.Token(Token = "0x4003F02")]
			SpiderBreastplate,
			// Token: 0x04008376 RID: 33654
			[global::Cpp2ILInjected.Token(Token = "0x4003F03")]
			MermaidAdornment,
			// Token: 0x04008377 RID: 33655
			[global::Cpp2ILInjected.Token(Token = "0x4003F04")]
			FishCostumeShirt,
			// Token: 0x04008378 RID: 33656
			[global::Cpp2ILInjected.Token(Token = "0x4003F05")]
			BorealWoodBreastplate,
			// Token: 0x04008379 RID: 33657
			[global::Cpp2ILInjected.Token(Token = "0x4003F06")]
			PalmWoodBreastplate,
			// Token: 0x0400837A RID: 33658
			[global::Cpp2ILInjected.Token(Token = "0x4003F07")]
			VortexBreastplate,
			// Token: 0x0400837B RID: 33659
			[global::Cpp2ILInjected.Token(Token = "0x4003F08")]
			NebulaBreastplate,
			// Token: 0x0400837C RID: 33660
			[global::Cpp2ILInjected.Token(Token = "0x4003F09")]
			SolarFlareBreastplate,
			// Token: 0x0400837D RID: 33661
			[global::Cpp2ILInjected.Token(Token = "0x4003F0A")]
			MartianCostumeShirt,
			// Token: 0x0400837E RID: 33662
			[global::Cpp2ILInjected.Token(Token = "0x4003F0B")]
			MartianUniformTorso,
			// Token: 0x0400837F RID: 33663
			[global::Cpp2ILInjected.Token(Token = "0x4003F0C")]
			WhiteLunaticRobe,
			// Token: 0x04008380 RID: 33664
			[global::Cpp2ILInjected.Token(Token = "0x4003F0D")]
			BlueLunaticRobe,
			// Token: 0x04008381 RID: 33665
			[global::Cpp2ILInjected.Token(Token = "0x4003F0E")]
			GladiatorBreastplate,
			// Token: 0x04008382 RID: 33666
			[global::Cpp2ILInjected.Token(Token = "0x4003F0F")]
			BejeweledValkyrieBody,
			// Token: 0x04008383 RID: 33667
			[global::Cpp2ILInjected.Token(Token = "0x4003F10")]
			TaxCollectorSuit,
			// Token: 0x04008384 RID: 33668
			[global::Cpp2ILInjected.Token(Token = "0x4003F11")]
			ClothierJacket,
			// Token: 0x04008385 RID: 33669
			[global::Cpp2ILInjected.Token(Token = "0x4003F12")]
			BuccaneerShirt,
			// Token: 0x04008386 RID: 33670
			[global::Cpp2ILInjected.Token(Token = "0x4003F13")]
			ObsidianShirt,
			// Token: 0x04008387 RID: 33671
			[global::Cpp2ILInjected.Token(Token = "0x4003F14")]
			FallenTuxedoShirt,
			// Token: 0x04008388 RID: 33672
			[global::Cpp2ILInjected.Token(Token = "0x4003F15")]
			FossilShirt,
			// Token: 0x04008389 RID: 33673
			[global::Cpp2ILInjected.Token(Token = "0x4003F16")]
			StardustBreastplate,
			// Token: 0x0400838A RID: 33674
			[global::Cpp2ILInjected.Token(Token = "0x4003F17")]
			TheBrideDress,
			// Token: 0x0400838B RID: 33675
			[global::Cpp2ILInjected.Token(Token = "0x4003F18")]
			Yoraiz0rShirt,
			// Token: 0x0400838C RID: 33676
			[global::Cpp2ILInjected.Token(Token = "0x4003F19")]
			SkiphsShirt,
			// Token: 0x0400838D RID: 33677
			[global::Cpp2ILInjected.Token(Token = "0x4003F1A")]
			LokisShirt,
			// Token: 0x0400838E RID: 33678
			[global::Cpp2ILInjected.Token(Token = "0x4003F1B")]
			SillySunflowerTops,
			// Token: 0x0400838F RID: 33679
			[global::Cpp2ILInjected.Token(Token = "0x4003F1C")]
			PedguinsJacket,
			// Token: 0x04008390 RID: 33680
			[global::Cpp2ILInjected.Token(Token = "0x4003F1D")]
			AncientArmor,
			// Token: 0x04008391 RID: 33681
			[global::Cpp2ILInjected.Token(Token = "0x4003F1E")]
			AncientBattleArmor,
			// Token: 0x04008392 RID: 33682
			[global::Cpp2ILInjected.Token(Token = "0x4003F1F")]
			Lamia,
			// Token: 0x04008393 RID: 33683
			[global::Cpp2ILInjected.Token(Token = "0x4003F20")]
			ApprenticeRobe,
			// Token: 0x04008394 RID: 33684
			[global::Cpp2ILInjected.Token(Token = "0x4003F21")]
			SquirePlating,
			// Token: 0x04008395 RID: 33685
			[global::Cpp2ILInjected.Token(Token = "0x4003F22")]
			HuntressJerkin,
			// Token: 0x04008396 RID: 33686
			[global::Cpp2ILInjected.Token(Token = "0x4003F23")]
			MonkShirt,
			// Token: 0x04008397 RID: 33687
			[global::Cpp2ILInjected.Token(Token = "0x4003F24")]
			ValhallaKnight,
			// Token: 0x04008398 RID: 33688
			[global::Cpp2ILInjected.Token(Token = "0x4003F25")]
			ApprenticeDark,
			// Token: 0x04008399 RID: 33689
			[global::Cpp2ILInjected.Token(Token = "0x4003F26")]
			RedRidingHuntress,
			// Token: 0x0400839A RID: 33690
			[global::Cpp2ILInjected.Token(Token = "0x4003F27")]
			ShinobiInfiltrator,
			// Token: 0x0400839B RID: 33691
			[global::Cpp2ILInjected.Token(Token = "0x4003F28")]
			ArkhalisShirt,
			// Token: 0x0400839C RID: 33692
			[global::Cpp2ILInjected.Token(Token = "0x4003F29")]
			LeinforsShirt,
			// Token: 0x0400839D RID: 33693
			[global::Cpp2ILInjected.Token(Token = "0x4003F2A")]
			DragonBreastplate = 300,
			// Token: 0x0400839E RID: 33694
			[global::Cpp2ILInjected.Token(Token = "0x4003F2B")]
			SpectralArmor,
			// Token: 0x0400839F RID: 33695
			[global::Cpp2ILInjected.Token(Token = "0x4003F2C")]
			TitanMail,
			// Token: 0x040083A0 RID: 33696
			[global::Cpp2ILInjected.Token(Token = "0x4003F2D")]
			HornedGodRobe,
			// Token: 0x040083A1 RID: 33697
			[global::Cpp2ILInjected.Token(Token = "0x4003F2E")]
			FabulousDress,
			// Token: 0x040083A2 RID: 33698
			[global::Cpp2ILInjected.Token(Token = "0x4003F2F")]
			GeorgesSuit,
			// Token: 0x040083A3 RID: 33699
			[global::Cpp2ILInjected.Token(Token = "0x4003F30")]
			ShirenShirt,
			// Token: 0x040083A4 RID: 33700
			[global::Cpp2ILInjected.Token(Token = "0x4003F31")]
			MonokumaBody,
			// Token: 0x040083A5 RID: 33701
			[global::Cpp2ILInjected.Token(Token = "0x4003F32")]
			MonomiBody,
			// Token: 0x040083A6 RID: 33702
			[global::Cpp2ILInjected.Token(Token = "0x4003F33")]
			TorosBody,
			// Token: 0x040083A7 RID: 33703
			[global::Cpp2ILInjected.Token(Token = "0x4003F34")]
			Count
		}

		// Token: 0x020008FB RID: 2299
		[global::Cpp2ILInjected.Token(Token = "0x200057A")]
		public enum eHeadSlot
		{
			// Token: 0x040083A9 RID: 33705
			[global::Cpp2ILInjected.Token(Token = "0x4003F36")]
			None = -1,
			// Token: 0x040083AA RID: 33706
			[global::Cpp2ILInjected.Token(Token = "0x4003F37")]
			FamiliarWig,
			// Token: 0x040083AB RID: 33707
			[global::Cpp2ILInjected.Token(Token = "0x4003F38")]
			CopperHelmet,
			// Token: 0x040083AC RID: 33708
			[global::Cpp2ILInjected.Token(Token = "0x4003F39")]
			IronHelmet,
			// Token: 0x040083AD RID: 33709
			[global::Cpp2ILInjected.Token(Token = "0x4003F3A")]
			SilverHelmet,
			// Token: 0x040083AE RID: 33710
			[global::Cpp2ILInjected.Token(Token = "0x4003F3B")]
			GoldHelmet,
			// Token: 0x040083AF RID: 33711
			[global::Cpp2ILInjected.Token(Token = "0x4003F3C")]
			ShadowHelmet,
			// Token: 0x040083B0 RID: 33712
			[global::Cpp2ILInjected.Token(Token = "0x4003F3D")]
			MeteorHelmet,
			// Token: 0x040083B1 RID: 33713
			[global::Cpp2ILInjected.Token(Token = "0x4003F3E")]
			NecroHelmet,
			// Token: 0x040083B2 RID: 33714
			[global::Cpp2ILInjected.Token(Token = "0x4003F3F")]
			JungleHat,
			// Token: 0x040083B3 RID: 33715
			[global::Cpp2ILInjected.Token(Token = "0x4003F40")]
			MoltenHelmet,
			// Token: 0x040083B4 RID: 33716
			[global::Cpp2ILInjected.Token(Token = "0x4003F41")]
			Goggles,
			// Token: 0x040083B5 RID: 33717
			[global::Cpp2ILInjected.Token(Token = "0x4003F42")]
			MiningHelmet,
			// Token: 0x040083B6 RID: 33718
			[global::Cpp2ILInjected.Token(Token = "0x4003F43")]
			Sunglasses,
			// Token: 0x040083B7 RID: 33719
			[global::Cpp2ILInjected.Token(Token = "0x4003F44")]
			EmptyBucket,
			// Token: 0x040083B8 RID: 33720
			[global::Cpp2ILInjected.Token(Token = "0x4003F45")]
			WizardHat,
			// Token: 0x040083B9 RID: 33721
			[global::Cpp2ILInjected.Token(Token = "0x4003F46")]
			TopHat,
			// Token: 0x040083BA RID: 33722
			[global::Cpp2ILInjected.Token(Token = "0x4003F47")]
			SummerHat,
			// Token: 0x040083BB RID: 33723
			[global::Cpp2ILInjected.Token(Token = "0x4003F48")]
			BunnyHood,
			// Token: 0x040083BC RID: 33724
			[global::Cpp2ILInjected.Token(Token = "0x4003F49")]
			PlumbersHat,
			// Token: 0x040083BD RID: 33725
			[global::Cpp2ILInjected.Token(Token = "0x4003F4A")]
			HerosHat,
			// Token: 0x040083BE RID: 33726
			[global::Cpp2ILInjected.Token(Token = "0x4003F4B")]
			FishBowl,
			// Token: 0x040083BF RID: 33727
			[global::Cpp2ILInjected.Token(Token = "0x4003F4C")]
			ArchaeologistsHat,
			// Token: 0x040083C0 RID: 33728
			[global::Cpp2ILInjected.Token(Token = "0x4003F4D")]
			NinjaHood,
			// Token: 0x040083C1 RID: 33729
			[global::Cpp2ILInjected.Token(Token = "0x4003F4E")]
			JungleRose,
			// Token: 0x040083C2 RID: 33730
			[global::Cpp2ILInjected.Token(Token = "0x4003F4F")]
			RedHat,
			// Token: 0x040083C3 RID: 33731
			[global::Cpp2ILInjected.Token(Token = "0x4003F50")]
			RobotHat,
			// Token: 0x040083C4 RID: 33732
			[global::Cpp2ILInjected.Token(Token = "0x4003F51")]
			GoldCrown,
			// Token: 0x040083C5 RID: 33733
			[global::Cpp2ILInjected.Token(Token = "0x4003F52")]
			DivingHelmet,
			// Token: 0x040083C6 RID: 33734
			[global::Cpp2ILInjected.Token(Token = "0x4003F53")]
			MimeMask,
			// Token: 0x040083C7 RID: 33735
			[global::Cpp2ILInjected.Token(Token = "0x4003F54")]
			CobaltHat,
			// Token: 0x040083C8 RID: 33736
			[global::Cpp2ILInjected.Token(Token = "0x4003F55")]
			CobaltHelmet,
			// Token: 0x040083C9 RID: 33737
			[global::Cpp2ILInjected.Token(Token = "0x4003F56")]
			CobaltMask,
			// Token: 0x040083CA RID: 33738
			[global::Cpp2ILInjected.Token(Token = "0x4003F57")]
			MythrilHood,
			// Token: 0x040083CB RID: 33739
			[global::Cpp2ILInjected.Token(Token = "0x4003F58")]
			MythrilHelmet,
			// Token: 0x040083CC RID: 33740
			[global::Cpp2ILInjected.Token(Token = "0x4003F59")]
			MythrilHat,
			// Token: 0x040083CD RID: 33741
			[global::Cpp2ILInjected.Token(Token = "0x4003F5A")]
			AdamantiteHeadgear,
			// Token: 0x040083CE RID: 33742
			[global::Cpp2ILInjected.Token(Token = "0x4003F5B")]
			AdamantiteHelmet,
			// Token: 0x040083CF RID: 33743
			[global::Cpp2ILInjected.Token(Token = "0x4003F5C")]
			AdamantiteMask,
			// Token: 0x040083D0 RID: 33744
			[global::Cpp2ILInjected.Token(Token = "0x4003F5D")]
			WerewolfHead,
			// Token: 0x040083D1 RID: 33745
			[global::Cpp2ILInjected.Token(Token = "0x4003F5E")]
			MermanHead,
			// Token: 0x040083D2 RID: 33746
			[global::Cpp2ILInjected.Token(Token = "0x4003F5F")]
			ClownHat,
			// Token: 0x040083D3 RID: 33747
			[global::Cpp2ILInjected.Token(Token = "0x4003F60")]
			HallowedHelmet,
			// Token: 0x040083D4 RID: 33748
			[global::Cpp2ILInjected.Token(Token = "0x4003F61")]
			HallowedHeadgear,
			// Token: 0x040083D5 RID: 33749
			[global::Cpp2ILInjected.Token(Token = "0x4003F62")]
			HallowedMask,
			// Token: 0x040083D6 RID: 33750
			[global::Cpp2ILInjected.Token(Token = "0x4003F63")]
			SantaHat,
			// Token: 0x040083D7 RID: 33751
			[global::Cpp2ILInjected.Token(Token = "0x4003F64")]
			RedsHelmet,
			// Token: 0x040083D8 RID: 33752
			[global::Cpp2ILInjected.Token(Token = "0x4003F65")]
			FrostHelmet,
			// Token: 0x040083D9 RID: 33753
			[global::Cpp2ILInjected.Token(Token = "0x4003F66")]
			TinHelmet,
			// Token: 0x040083DA RID: 33754
			[global::Cpp2ILInjected.Token(Token = "0x4003F67")]
			LeadHelmet,
			// Token: 0x040083DB RID: 33755
			[global::Cpp2ILInjected.Token(Token = "0x4003F68")]
			TungstenHelmet,
			// Token: 0x040083DC RID: 33756
			[global::Cpp2ILInjected.Token(Token = "0x4003F69")]
			PlatinumHelmet,
			// Token: 0x040083DD RID: 33757
			[global::Cpp2ILInjected.Token(Token = "0x4003F6A")]
			PlatinumCrown,
			// Token: 0x040083DE RID: 33758
			[global::Cpp2ILInjected.Token(Token = "0x4003F6B")]
			WoodHelmet,
			// Token: 0x040083DF RID: 33759
			[global::Cpp2ILInjected.Token(Token = "0x4003F6C")]
			EbonwoodHelmet,
			// Token: 0x040083E0 RID: 33760
			[global::Cpp2ILInjected.Token(Token = "0x4003F6D")]
			RichMahoganyHelmet,
			// Token: 0x040083E1 RID: 33761
			[global::Cpp2ILInjected.Token(Token = "0x4003F6E")]
			PearlwoodHelmet,
			// Token: 0x040083E2 RID: 33762
			[global::Cpp2ILInjected.Token(Token = "0x4003F6F")]
			RuneHat,
			// Token: 0x040083E3 RID: 33763
			[global::Cpp2ILInjected.Token(Token = "0x4003F70")]
			CrimsonHelmet,
			// Token: 0x040083E4 RID: 33764
			[global::Cpp2ILInjected.Token(Token = "0x4003F71")]
			EskimoHood,
			// Token: 0x040083E5 RID: 33765
			[global::Cpp2ILInjected.Token(Token = "0x4003F72")]
			SteampunkHat,
			// Token: 0x040083E6 RID: 33766
			[global::Cpp2ILInjected.Token(Token = "0x4003F73")]
			BeeHat,
			// Token: 0x040083E7 RID: 33767
			[global::Cpp2ILInjected.Token(Token = "0x4003F74")]
			PharaohsMask,
			// Token: 0x040083E8 RID: 33768
			[global::Cpp2ILInjected.Token(Token = "0x4003F75")]
			Tiara,
			// Token: 0x040083E9 RID: 33769
			[global::Cpp2ILInjected.Token(Token = "0x4003F76")]
			GreenCap,
			// Token: 0x040083EA RID: 33770
			[global::Cpp2ILInjected.Token(Token = "0x4003F77")]
			MushroomCap,
			// Token: 0x040083EB RID: 33771
			[global::Cpp2ILInjected.Token(Token = "0x4003F78")]
			TamOShanter,
			// Token: 0x040083EC RID: 33772
			[global::Cpp2ILInjected.Token(Token = "0x4003F79")]
			MummyMask,
			// Token: 0x040083ED RID: 33773
			[global::Cpp2ILInjected.Token(Token = "0x4003F7A")]
			CowboyHat,
			// Token: 0x040083EE RID: 33774
			[global::Cpp2ILInjected.Token(Token = "0x4003F7B")]
			PirateHat,
			// Token: 0x040083EF RID: 33775
			[global::Cpp2ILInjected.Token(Token = "0x4003F7C")]
			VikingHelmet,
			// Token: 0x040083F0 RID: 33776
			[global::Cpp2ILInjected.Token(Token = "0x4003F7D")]
			CactusHelmet,
			// Token: 0x040083F1 RID: 33777
			[global::Cpp2ILInjected.Token(Token = "0x4003F7E")]
			ShadewoodHelmet,
			// Token: 0x040083F2 RID: 33778
			[global::Cpp2ILInjected.Token(Token = "0x4003F7F")]
			AncientIronHelmet,
			// Token: 0x040083F3 RID: 33779
			[global::Cpp2ILInjected.Token(Token = "0x4003F80")]
			AncientGoldHelmet,
			// Token: 0x040083F4 RID: 33780
			[global::Cpp2ILInjected.Token(Token = "0x4003F81")]
			AncientShadowHelmet,
			// Token: 0x040083F5 RID: 33781
			[global::Cpp2ILInjected.Token(Token = "0x4003F82")]
			AncientNecroHelmet,
			// Token: 0x040083F6 RID: 33782
			[global::Cpp2ILInjected.Token(Token = "0x4003F83")]
			AncientCobaltHelmet,
			// Token: 0x040083F7 RID: 33783
			[global::Cpp2ILInjected.Token(Token = "0x4003F84")]
			PinkEskimoHood,
			// Token: 0x040083F8 RID: 33784
			[global::Cpp2ILInjected.Token(Token = "0x4003F85")]
			ChlorophyteMask,
			// Token: 0x040083F9 RID: 33785
			[global::Cpp2ILInjected.Token(Token = "0x4003F86")]
			ChlorophyteHelmet,
			// Token: 0x040083FA RID: 33786
			[global::Cpp2ILInjected.Token(Token = "0x4003F87")]
			ChlorophyteHeadgear,
			// Token: 0x040083FB RID: 33787
			[global::Cpp2ILInjected.Token(Token = "0x4003F88")]
			RainHat,
			// Token: 0x040083FC RID: 33788
			[global::Cpp2ILInjected.Token(Token = "0x4003F89")]
			TikiMask,
			// Token: 0x040083FD RID: 33789
			[global::Cpp2ILInjected.Token(Token = "0x4003F8A")]
			PalladiumMask,
			// Token: 0x040083FE RID: 33790
			[global::Cpp2ILInjected.Token(Token = "0x4003F8B")]
			PalladiumHelmet,
			// Token: 0x040083FF RID: 33791
			[global::Cpp2ILInjected.Token(Token = "0x4003F8C")]
			PalladiumHeadgear,
			// Token: 0x04008400 RID: 33792
			[global::Cpp2ILInjected.Token(Token = "0x4003F8D")]
			OrichalcumMask,
			// Token: 0x04008401 RID: 33793
			[global::Cpp2ILInjected.Token(Token = "0x4003F8E")]
			OrichalcumHelmet,
			// Token: 0x04008402 RID: 33794
			[global::Cpp2ILInjected.Token(Token = "0x4003F8F")]
			OrichalcumHeadgear,
			// Token: 0x04008403 RID: 33795
			[global::Cpp2ILInjected.Token(Token = "0x4003F90")]
			TitaniumMask,
			// Token: 0x04008404 RID: 33796
			[global::Cpp2ILInjected.Token(Token = "0x4003F91")]
			TitaniumHelmet,
			// Token: 0x04008405 RID: 33797
			[global::Cpp2ILInjected.Token(Token = "0x4003F92")]
			TitaniumHeadgear,
			// Token: 0x04008406 RID: 33798
			[global::Cpp2ILInjected.Token(Token = "0x4003F93")]
			UmbrellaHat,
			// Token: 0x04008407 RID: 33799
			[global::Cpp2ILInjected.Token(Token = "0x4003F94")]
			Skull,
			// Token: 0x04008408 RID: 33800
			[global::Cpp2ILInjected.Token(Token = "0x4003F95")]
			BallaHat,
			// Token: 0x04008409 RID: 33801
			[global::Cpp2ILInjected.Token(Token = "0x4003F96")]
			GangstaHat,
			// Token: 0x0400840A RID: 33802
			[global::Cpp2ILInjected.Token(Token = "0x4003F97")]
			SailorHat,
			// Token: 0x0400840B RID: 33803
			[global::Cpp2ILInjected.Token(Token = "0x4003F98")]
			EyePatch,
			// Token: 0x0400840C RID: 33804
			[global::Cpp2ILInjected.Token(Token = "0x4003F99")]
			SkeletronMask,
			// Token: 0x0400840D RID: 33805
			[global::Cpp2ILInjected.Token(Token = "0x4003F9A")]
			TurtleHelmet,
			// Token: 0x0400840E RID: 33806
			[global::Cpp2ILInjected.Token(Token = "0x4003F9B")]
			Beanie,
			// Token: 0x0400840F RID: 33807
			[global::Cpp2ILInjected.Token(Token = "0x4003F9C")]
			SpectreHood,
			// Token: 0x04008410 RID: 33808
			[global::Cpp2ILInjected.Token(Token = "0x4003F9D")]
			SWATHelmet,
			// Token: 0x04008411 RID: 33809
			[global::Cpp2ILInjected.Token(Token = "0x4003F9E")]
			ShroomiteHeadgear,
			// Token: 0x04008412 RID: 33810
			[global::Cpp2ILInjected.Token(Token = "0x4003F9F")]
			ShroomiteMask,
			// Token: 0x04008413 RID: 33811
			[global::Cpp2ILInjected.Token(Token = "0x4003FA0")]
			ShroomiteHelmet,
			// Token: 0x04008414 RID: 33812
			[global::Cpp2ILInjected.Token(Token = "0x4003FA1")]
			CenxsTiara,
			// Token: 0x04008415 RID: 33813
			[global::Cpp2ILInjected.Token(Token = "0x4003FA2")]
			CrownosMask,
			// Token: 0x04008416 RID: 33814
			[global::Cpp2ILInjected.Token(Token = "0x4003FA3")]
			WillsHelmet,
			// Token: 0x04008417 RID: 33815
			[global::Cpp2ILInjected.Token(Token = "0x4003FA4")]
			JimsHelmet,
			// Token: 0x04008418 RID: 33816
			[global::Cpp2ILInjected.Token(Token = "0x4003FA5")]
			AaronsHelmet,
			// Token: 0x04008419 RID: 33817
			[global::Cpp2ILInjected.Token(Token = "0x4003FA6")]
			DTownsHelmet,
			// Token: 0x0400841A RID: 33818
			[global::Cpp2ILInjected.Token(Token = "0x4003FA7")]
			PumpkinHelmet,
			// Token: 0x0400841B RID: 33819
			[global::Cpp2ILInjected.Token(Token = "0x4003FA8")]
			NurseHat,
			// Token: 0x0400841C RID: 33820
			[global::Cpp2ILInjected.Token(Token = "0x4003FA9")]
			WizardsHat,
			// Token: 0x0400841D RID: 33821
			[global::Cpp2ILInjected.Token(Token = "0x4003FAA")]
			GuyFawkesMask,
			// Token: 0x0400841E RID: 33822
			[global::Cpp2ILInjected.Token(Token = "0x4003FAB")]
			SteampunkGoggles,
			// Token: 0x0400841F RID: 33823
			[global::Cpp2ILInjected.Token(Token = "0x4003FAC")]
			CyborgHelmet,
			// Token: 0x04008420 RID: 33824
			[global::Cpp2ILInjected.Token(Token = "0x4003FAD")]
			CreeperMask,
			// Token: 0x04008421 RID: 33825
			[global::Cpp2ILInjected.Token(Token = "0x4003FAE")]
			CatMask,
			// Token: 0x04008422 RID: 33826
			[global::Cpp2ILInjected.Token(Token = "0x4003FAF")]
			GhostMask,
			// Token: 0x04008423 RID: 33827
			[global::Cpp2ILInjected.Token(Token = "0x4003FB0")]
			PumpkinMask,
			// Token: 0x04008424 RID: 33828
			[global::Cpp2ILInjected.Token(Token = "0x4003FB1")]
			RobotMask,
			// Token: 0x04008425 RID: 33829
			[global::Cpp2ILInjected.Token(Token = "0x4003FB2")]
			UnicornMask,
			// Token: 0x04008426 RID: 33830
			[global::Cpp2ILInjected.Token(Token = "0x4003FB3")]
			VampireMask,
			// Token: 0x04008427 RID: 33831
			[global::Cpp2ILInjected.Token(Token = "0x4003FB4")]
			WitchHat,
			// Token: 0x04008428 RID: 33832
			[global::Cpp2ILInjected.Token(Token = "0x4003FB5")]
			LeprechaunHat,
			// Token: 0x04008429 RID: 33833
			[global::Cpp2ILInjected.Token(Token = "0x4003FB6")]
			PrincessHat,
			// Token: 0x0400842A RID: 33834
			[global::Cpp2ILInjected.Token(Token = "0x4003FB7")]
			BrideofFrankensteinMask,
			// Token: 0x0400842B RID: 33835
			[global::Cpp2ILInjected.Token(Token = "0x4003FB8")]
			KarateTortoiseMask,
			// Token: 0x0400842C RID: 33836
			[global::Cpp2ILInjected.Token(Token = "0x4003FB9")]
			ScarecrowHat,
			// Token: 0x0400842D RID: 33837
			[global::Cpp2ILInjected.Token(Token = "0x4003FBA")]
			ReaperHood,
			// Token: 0x0400842E RID: 33838
			[global::Cpp2ILInjected.Token(Token = "0x4003FBB")]
			FoxMask,
			// Token: 0x0400842F RID: 33839
			[global::Cpp2ILInjected.Token(Token = "0x4003FBC")]
			CatEars,
			// Token: 0x04008430 RID: 33840
			[global::Cpp2ILInjected.Token(Token = "0x4003FBD")]
			SpookyHelmet,
			// Token: 0x04008431 RID: 33841
			[global::Cpp2ILInjected.Token(Token = "0x4003FBE")]
			SpaceCreatureMask,
			// Token: 0x04008432 RID: 33842
			[global::Cpp2ILInjected.Token(Token = "0x4003FBF")]
			WolfMask,
			// Token: 0x04008433 RID: 33843
			[global::Cpp2ILInjected.Token(Token = "0x4003FC0")]
			JackOLanternMask,
			// Token: 0x04008434 RID: 33844
			[global::Cpp2ILInjected.Token(Token = "0x4003FC1")]
			GiantBow,
			// Token: 0x04008435 RID: 33845
			[global::Cpp2ILInjected.Token(Token = "0x4003FC2")]
			ReindeerAntlers,
			// Token: 0x04008436 RID: 33846
			[global::Cpp2ILInjected.Token(Token = "0x4003FC3")]
			MrsClauseHat,
			// Token: 0x04008437 RID: 33847
			[global::Cpp2ILInjected.Token(Token = "0x4003FC4")]
			TreeMask,
			// Token: 0x04008438 RID: 33848
			[global::Cpp2ILInjected.Token(Token = "0x4003FC5")]
			ParkaHood,
			// Token: 0x04008439 RID: 33849
			[global::Cpp2ILInjected.Token(Token = "0x4003FC6")]
			SnowHat,
			// Token: 0x0400843A RID: 33850
			[global::Cpp2ILInjected.Token(Token = "0x4003FC7")]
			ElfHat,
			// Token: 0x0400843B RID: 33851
			[global::Cpp2ILInjected.Token(Token = "0x4003FC8")]
			Fez,
			// Token: 0x0400843C RID: 33852
			[global::Cpp2ILInjected.Token(Token = "0x4003FC9")]
			BrainMask,
			// Token: 0x0400843D RID: 33853
			[global::Cpp2ILInjected.Token(Token = "0x4003FCA")]
			FleshMask,
			// Token: 0x0400843E RID: 33854
			[global::Cpp2ILInjected.Token(Token = "0x4003FCB")]
			TwinMask,
			// Token: 0x0400843F RID: 33855
			[global::Cpp2ILInjected.Token(Token = "0x4003FCC")]
			SkeletronPrimeMask,
			// Token: 0x04008440 RID: 33856
			[global::Cpp2ILInjected.Token(Token = "0x4003FCD")]
			BeeMask,
			// Token: 0x04008441 RID: 33857
			[global::Cpp2ILInjected.Token(Token = "0x4003FCE")]
			PlanteraMask,
			// Token: 0x04008442 RID: 33858
			[global::Cpp2ILInjected.Token(Token = "0x4003FCF")]
			GolemMask,
			// Token: 0x04008443 RID: 33859
			[global::Cpp2ILInjected.Token(Token = "0x4003FD0")]
			EaterMask,
			// Token: 0x04008444 RID: 33860
			[global::Cpp2ILInjected.Token(Token = "0x4003FD1")]
			EyeMask,
			// Token: 0x04008445 RID: 33861
			[global::Cpp2ILInjected.Token(Token = "0x4003FD2")]
			DestroyerMask,
			// Token: 0x04008446 RID: 33862
			[global::Cpp2ILInjected.Token(Token = "0x4003FD3")]
			SpectreMask,
			// Token: 0x04008447 RID: 33863
			[global::Cpp2ILInjected.Token(Token = "0x4003FD4")]
			BeetleHelmet,
			// Token: 0x04008448 RID: 33864
			[global::Cpp2ILInjected.Token(Token = "0x4003FD5")]
			PeddlersHat,
			// Token: 0x04008449 RID: 33865
			[global::Cpp2ILInjected.Token(Token = "0x4003FD6")]
			MagicHat,
			// Token: 0x0400844A RID: 33866
			[global::Cpp2ILInjected.Token(Token = "0x4003FD7")]
			BeeHeadgear,
			// Token: 0x0400844B RID: 33867
			[global::Cpp2ILInjected.Token(Token = "0x4003FD8")]
			AnglerHat,
			// Token: 0x0400844C RID: 33868
			[global::Cpp2ILInjected.Token(Token = "0x4003FD9")]
			SpiderMask,
			// Token: 0x0400844D RID: 33869
			[global::Cpp2ILInjected.Token(Token = "0x4003FDA")]
			SeashellHairpin,
			// Token: 0x0400844E RID: 33870
			[global::Cpp2ILInjected.Token(Token = "0x4003FDB")]
			KingSlimeMask,
			// Token: 0x0400844F RID: 33871
			[global::Cpp2ILInjected.Token(Token = "0x4003FDC")]
			FishCostumeMask,
			// Token: 0x04008450 RID: 33872
			[global::Cpp2ILInjected.Token(Token = "0x4003FDD")]
			BorealWoodHelmet,
			// Token: 0x04008451 RID: 33873
			[global::Cpp2ILInjected.Token(Token = "0x4003FDE")]
			PalmWoodHelmet,
			// Token: 0x04008452 RID: 33874
			[global::Cpp2ILInjected.Token(Token = "0x4003FDF")]
			DukeFishronMask,
			// Token: 0x04008453 RID: 33875
			[global::Cpp2ILInjected.Token(Token = "0x4003FE0")]
			VortexHelmet,
			// Token: 0x04008454 RID: 33876
			[global::Cpp2ILInjected.Token(Token = "0x4003FE1")]
			NebulaHelmet,
			// Token: 0x04008455 RID: 33877
			[global::Cpp2ILInjected.Token(Token = "0x4003FE2")]
			SolarFlareHelmet,
			// Token: 0x04008456 RID: 33878
			[global::Cpp2ILInjected.Token(Token = "0x4003FE3")]
			MoonMask,
			// Token: 0x04008457 RID: 33879
			[global::Cpp2ILInjected.Token(Token = "0x4003FE4")]
			SunMask,
			// Token: 0x04008458 RID: 33880
			[global::Cpp2ILInjected.Token(Token = "0x4003FE5")]
			MartianCostumeMask,
			// Token: 0x04008459 RID: 33881
			[global::Cpp2ILInjected.Token(Token = "0x4003FE6")]
			MartianUniformHelmet,
			// Token: 0x0400845A RID: 33882
			[global::Cpp2ILInjected.Token(Token = "0x4003FE7")]
			WhiteLunaticHood,
			// Token: 0x0400845B RID: 33883
			[global::Cpp2ILInjected.Token(Token = "0x4003FE8")]
			BlueLunaticHood,
			// Token: 0x0400845C RID: 33884
			[global::Cpp2ILInjected.Token(Token = "0x4003FE9")]
			HiTekSunglasses,
			// Token: 0x0400845D RID: 33885
			[global::Cpp2ILInjected.Token(Token = "0x4003FEA")]
			NightVisionHelmet,
			// Token: 0x0400845E RID: 33886
			[global::Cpp2ILInjected.Token(Token = "0x4003FEB")]
			GladiatorHelmet,
			// Token: 0x0400845F RID: 33887
			[global::Cpp2ILInjected.Token(Token = "0x4003FEC")]
			BejeweledValkyrieHead,
			// Token: 0x04008460 RID: 33888
			[global::Cpp2ILInjected.Token(Token = "0x4003FED")]
			TaxCollectorHat,
			// Token: 0x04008461 RID: 33889
			[global::Cpp2ILInjected.Token(Token = "0x4003FEE")]
			DyeTraderTurban,
			// Token: 0x04008462 RID: 33890
			[global::Cpp2ILInjected.Token(Token = "0x4003FEF")]
			BuccaneerBandana,
			// Token: 0x04008463 RID: 33891
			[global::Cpp2ILInjected.Token(Token = "0x4003FF0")]
			ObsidianHelm,
			// Token: 0x04008464 RID: 33892
			[global::Cpp2ILInjected.Token(Token = "0x4003FF1")]
			BossMaskCultist,
			// Token: 0x04008465 RID: 33893
			[global::Cpp2ILInjected.Token(Token = "0x4003FF2")]
			BossMaskMoonlord,
			// Token: 0x04008466 RID: 33894
			[global::Cpp2ILInjected.Token(Token = "0x4003FF3")]
			FossilHelm,
			// Token: 0x04008467 RID: 33895
			[global::Cpp2ILInjected.Token(Token = "0x4003FF4")]
			StardustHelmet,
			// Token: 0x04008468 RID: 33896
			[global::Cpp2ILInjected.Token(Token = "0x4003FF5")]
			TheBrideHat,
			// Token: 0x04008469 RID: 33897
			[global::Cpp2ILInjected.Token(Token = "0x4003FF6")]
			Yoraiz0rHead,
			// Token: 0x0400846A RID: 33898
			[global::Cpp2ILInjected.Token(Token = "0x4003FF7")]
			SkiphsHelm,
			// Token: 0x0400846B RID: 33899
			[global::Cpp2ILInjected.Token(Token = "0x4003FF8")]
			LokisHelm,
			// Token: 0x0400846C RID: 33900
			[global::Cpp2ILInjected.Token(Token = "0x4003FF9")]
			EngineeringHelmet,
			// Token: 0x0400846D RID: 33901
			[global::Cpp2ILInjected.Token(Token = "0x4003FFA")]
			PartyHat,
			// Token: 0x0400846E RID: 33902
			[global::Cpp2ILInjected.Token(Token = "0x4003FFB")]
			SillySunflowerPetals,
			// Token: 0x0400846F RID: 33903
			[global::Cpp2ILInjected.Token(Token = "0x4003FFC")]
			PedguinsHood,
			// Token: 0x04008470 RID: 33904
			[global::Cpp2ILInjected.Token(Token = "0x4003FFD")]
			_0x33sAviators,
			// Token: 0x04008471 RID: 33905
			[global::Cpp2ILInjected.Token(Token = "0x4003FFE")]
			AncientArmor,
			// Token: 0x04008472 RID: 33906
			[global::Cpp2ILInjected.Token(Token = "0x4003FFF")]
			AncientBattleArmor,
			// Token: 0x04008473 RID: 33907
			[global::Cpp2ILInjected.Token(Token = "0x4004000")]
			LamiaMale,
			// Token: 0x04008474 RID: 33908
			[global::Cpp2ILInjected.Token(Token = "0x4004001")]
			LamiaFemale,
			// Token: 0x04008475 RID: 33909
			[global::Cpp2ILInjected.Token(Token = "0x4004002")]
			ApprenticeHat,
			// Token: 0x04008476 RID: 33910
			[global::Cpp2ILInjected.Token(Token = "0x4004003")]
			SquireGreatHelm,
			// Token: 0x04008477 RID: 33911
			[global::Cpp2ILInjected.Token(Token = "0x4004004")]
			HuntressWig,
			// Token: 0x04008478 RID: 33912
			[global::Cpp2ILInjected.Token(Token = "0x4004005")]
			MonkBrows,
			// Token: 0x04008479 RID: 33913
			[global::Cpp2ILInjected.Token(Token = "0x4004006")]
			MaskBetsy,
			// Token: 0x0400847A RID: 33914
			[global::Cpp2ILInjected.Token(Token = "0x4004007")]
			MaskDarkMage,
			// Token: 0x0400847B RID: 33915
			[global::Cpp2ILInjected.Token(Token = "0x4004008")]
			MaskOgre,
			// Token: 0x0400847C RID: 33916
			[global::Cpp2ILInjected.Token(Token = "0x4004009")]
			ValhallaKnight,
			// Token: 0x0400847D RID: 33917
			[global::Cpp2ILInjected.Token(Token = "0x400400A")]
			ApprenticeDark,
			// Token: 0x0400847E RID: 33918
			[global::Cpp2ILInjected.Token(Token = "0x400400B")]
			RedRidingHuntress,
			// Token: 0x0400847F RID: 33919
			[global::Cpp2ILInjected.Token(Token = "0x400400C")]
			ShinobiInfiltrator,
			// Token: 0x04008480 RID: 33920
			[global::Cpp2ILInjected.Token(Token = "0x400400D")]
			ArkhalisHat,
			// Token: 0x04008481 RID: 33921
			[global::Cpp2ILInjected.Token(Token = "0x400400E")]
			LeinforsHat,
			// Token: 0x04008482 RID: 33922
			[global::Cpp2ILInjected.Token(Token = "0x400400F")]
			DragonMask = 300,
			// Token: 0x04008483 RID: 33923
			[global::Cpp2ILInjected.Token(Token = "0x4004010")]
			SpectralHeadgear,
			// Token: 0x04008484 RID: 33924
			[global::Cpp2ILInjected.Token(Token = "0x4004011")]
			TitanHelmet,
			// Token: 0x04008485 RID: 33925
			[global::Cpp2ILInjected.Token(Token = "0x4004012")]
			OcramMask,
			// Token: 0x04008486 RID: 33926
			[global::Cpp2ILInjected.Token(Token = "0x4004013")]
			HornedGodMask,
			// Token: 0x04008487 RID: 33927
			[global::Cpp2ILInjected.Token(Token = "0x4004014")]
			FabulousRibbon,
			// Token: 0x04008488 RID: 33928
			[global::Cpp2ILInjected.Token(Token = "0x4004015")]
			GeorgesHat,
			// Token: 0x04008489 RID: 33929
			[global::Cpp2ILInjected.Token(Token = "0x4004016")]
			ShirenHat,
			// Token: 0x0400848A RID: 33930
			[global::Cpp2ILInjected.Token(Token = "0x4004017")]
			MonokumaHead,
			// Token: 0x0400848B RID: 33931
			[global::Cpp2ILInjected.Token(Token = "0x4004018")]
			MonomiHead,
			// Token: 0x0400848C RID: 33932
			[global::Cpp2ILInjected.Token(Token = "0x4004019")]
			TorosHead,
			// Token: 0x0400848D RID: 33933
			[global::Cpp2ILInjected.Token(Token = "0x400401A")]
			Count
		}

		// Token: 0x020008FC RID: 2300
		[global::Cpp2ILInjected.Token(Token = "0x200057B")]
		public enum eLegSlot
		{
			// Token: 0x0400848F RID: 33935
			[global::Cpp2ILInjected.Token(Token = "0x400401C")]
			None = -1,
			// Token: 0x04008490 RID: 33936
			[global::Cpp2ILInjected.Token(Token = "0x400401D")]
			FamiliarPants,
			// Token: 0x04008491 RID: 33937
			[global::Cpp2ILInjected.Token(Token = "0x400401E")]
			CopperGreaves,
			// Token: 0x04008492 RID: 33938
			[global::Cpp2ILInjected.Token(Token = "0x400401F")]
			IronGreaves,
			// Token: 0x04008493 RID: 33939
			[global::Cpp2ILInjected.Token(Token = "0x4004020")]
			SilverGreaves,
			// Token: 0x04008494 RID: 33940
			[global::Cpp2ILInjected.Token(Token = "0x4004021")]
			GoldGreaves,
			// Token: 0x04008495 RID: 33941
			[global::Cpp2ILInjected.Token(Token = "0x4004022")]
			ShadowGreaves,
			// Token: 0x04008496 RID: 33942
			[global::Cpp2ILInjected.Token(Token = "0x4004023")]
			MeteorLeggings,
			// Token: 0x04008497 RID: 33943
			[global::Cpp2ILInjected.Token(Token = "0x4004024")]
			NecroGreaves,
			// Token: 0x04008498 RID: 33944
			[global::Cpp2ILInjected.Token(Token = "0x4004025")]
			JunglePants,
			// Token: 0x04008499 RID: 33945
			[global::Cpp2ILInjected.Token(Token = "0x4004026")]
			MoltenGreaves,
			// Token: 0x0400849A RID: 33946
			[global::Cpp2ILInjected.Token(Token = "0x4004027")]
			TuxedoPants,
			// Token: 0x0400849B RID: 33947
			[global::Cpp2ILInjected.Token(Token = "0x4004028")]
			PlumbersPants,
			// Token: 0x0400849C RID: 33948
			[global::Cpp2ILInjected.Token(Token = "0x4004029")]
			HerosPants,
			// Token: 0x0400849D RID: 33949
			[global::Cpp2ILInjected.Token(Token = "0x400402A")]
			ArchaeologistsPants,
			// Token: 0x0400849E RID: 33950
			[global::Cpp2ILInjected.Token(Token = "0x400402B")]
			NinjaPants,
			// Token: 0x0400849F RID: 33951
			[global::Cpp2ILInjected.Token(Token = "0x400402C")]
			TheDoctorsPants,
			// Token: 0x040084A0 RID: 33952
			[global::Cpp2ILInjected.Token(Token = "0x400402D")]
			CobaltLeggings,
			// Token: 0x040084A1 RID: 33953
			[global::Cpp2ILInjected.Token(Token = "0x400402E")]
			MythrilGreaves,
			// Token: 0x040084A2 RID: 33954
			[global::Cpp2ILInjected.Token(Token = "0x400402F")]
			AdamantiteLeggings,
			// Token: 0x040084A3 RID: 33955
			[global::Cpp2ILInjected.Token(Token = "0x4004030")]
			MiningPants,
			// Token: 0x040084A4 RID: 33956
			[global::Cpp2ILInjected.Token(Token = "0x4004031")]
			WerewolfLegs,
			// Token: 0x040084A5 RID: 33957
			[global::Cpp2ILInjected.Token(Token = "0x4004032")]
			MermanLegs,
			// Token: 0x040084A6 RID: 33958
			[global::Cpp2ILInjected.Token(Token = "0x4004033")]
			ClownPants,
			// Token: 0x040084A7 RID: 33959
			[global::Cpp2ILInjected.Token(Token = "0x4004034")]
			HallowedGreaves,
			// Token: 0x040084A8 RID: 33960
			[global::Cpp2ILInjected.Token(Token = "0x4004035")]
			SantaPants,
			// Token: 0x040084A9 RID: 33961
			[global::Cpp2ILInjected.Token(Token = "0x4004036")]
			RedsLeggings,
			// Token: 0x040084AA RID: 33962
			[global::Cpp2ILInjected.Token(Token = "0x4004037")]
			FrostLeggings,
			// Token: 0x040084AB RID: 33963
			[global::Cpp2ILInjected.Token(Token = "0x4004038")]
			TinGreaves,
			// Token: 0x040084AC RID: 33964
			[global::Cpp2ILInjected.Token(Token = "0x4004039")]
			LeadGreaves,
			// Token: 0x040084AD RID: 33965
			[global::Cpp2ILInjected.Token(Token = "0x400403A")]
			TungstenGreaves,
			// Token: 0x040084AE RID: 33966
			[global::Cpp2ILInjected.Token(Token = "0x400403B")]
			PlatinumGreaves,
			// Token: 0x040084AF RID: 33967
			[global::Cpp2ILInjected.Token(Token = "0x400403C")]
			WoodGreaves,
			// Token: 0x040084B0 RID: 33968
			[global::Cpp2ILInjected.Token(Token = "0x400403D")]
			EbonwoodGreaves,
			// Token: 0x040084B1 RID: 33969
			[global::Cpp2ILInjected.Token(Token = "0x400403E")]
			RichMahoganyGreaves,
			// Token: 0x040084B2 RID: 33970
			[global::Cpp2ILInjected.Token(Token = "0x400403F")]
			PearlwoodGreaves,
			// Token: 0x040084B3 RID: 33971
			[global::Cpp2ILInjected.Token(Token = "0x4004040")]
			CrimsonGreaves,
			// Token: 0x040084B4 RID: 33972
			[global::Cpp2ILInjected.Token(Token = "0x4004041")]
			EskimoPants,
			// Token: 0x040084B5 RID: 33973
			[global::Cpp2ILInjected.Token(Token = "0x4004042")]
			SteampunkPants,
			// Token: 0x040084B6 RID: 33974
			[global::Cpp2ILInjected.Token(Token = "0x4004043")]
			BeePants,
			// Token: 0x040084B7 RID: 33975
			[global::Cpp2ILInjected.Token(Token = "0x4004044")]
			MummyPants,
			// Token: 0x040084B8 RID: 33976
			[global::Cpp2ILInjected.Token(Token = "0x4004045")]
			CowboyPants,
			// Token: 0x040084B9 RID: 33977
			[global::Cpp2ILInjected.Token(Token = "0x4004046")]
			PiratePants,
			// Token: 0x040084BA RID: 33978
			[global::Cpp2ILInjected.Token(Token = "0x4004047")]
			CactusLeggings,
			// Token: 0x040084BB RID: 33979
			[global::Cpp2ILInjected.Token(Token = "0x4004048")]
			ShadewoodGreaves,
			// Token: 0x040084BC RID: 33980
			[global::Cpp2ILInjected.Token(Token = "0x4004049")]
			AncientShadowGreaves,
			// Token: 0x040084BD RID: 33981
			[global::Cpp2ILInjected.Token(Token = "0x400404A")]
			AncientCobaltLeggings,
			// Token: 0x040084BE RID: 33982
			[global::Cpp2ILInjected.Token(Token = "0x400404B")]
			PinkEskimoPants,
			// Token: 0x040084BF RID: 33983
			[global::Cpp2ILInjected.Token(Token = "0x400404C")]
			ChlorophyteGreaves,
			// Token: 0x040084C0 RID: 33984
			[global::Cpp2ILInjected.Token(Token = "0x400404D")]
			TikiPants,
			// Token: 0x040084C1 RID: 33985
			[global::Cpp2ILInjected.Token(Token = "0x400404E")]
			PalladiumLeggings,
			// Token: 0x040084C2 RID: 33986
			[global::Cpp2ILInjected.Token(Token = "0x400404F")]
			OrichalcumLeggings,
			// Token: 0x040084C3 RID: 33987
			[global::Cpp2ILInjected.Token(Token = "0x4004050")]
			TitaniumLeggings,
			// Token: 0x040084C4 RID: 33988
			[global::Cpp2ILInjected.Token(Token = "0x4004051")]
			SailorPants,
			// Token: 0x040084C5 RID: 33989
			[global::Cpp2ILInjected.Token(Token = "0x4004052")]
			WhiteTuxedoPants,
			// Token: 0x040084C6 RID: 33990
			[global::Cpp2ILInjected.Token(Token = "0x4004053")]
			TurtleLeggings,
			// Token: 0x040084C7 RID: 33991
			[global::Cpp2ILInjected.Token(Token = "0x4004054")]
			SpectrePants,
			// Token: 0x040084C8 RID: 33992
			[global::Cpp2ILInjected.Token(Token = "0x4004055")]
			ShroomiteLeggings,
			// Token: 0x040084C9 RID: 33993
			[global::Cpp2ILInjected.Token(Token = "0x4004056")]
			CenxsLeggings,
			// Token: 0x040084CA RID: 33994
			[global::Cpp2ILInjected.Token(Token = "0x4004057")]
			CrownosLeggings,
			// Token: 0x040084CB RID: 33995
			[global::Cpp2ILInjected.Token(Token = "0x4004058")]
			WillsLeggings,
			// Token: 0x040084CC RID: 33996
			[global::Cpp2ILInjected.Token(Token = "0x4004059")]
			JimsLeggings,
			// Token: 0x040084CD RID: 33997
			[global::Cpp2ILInjected.Token(Token = "0x400405A")]
			AaronsLeggings,
			// Token: 0x040084CE RID: 33998
			[global::Cpp2ILInjected.Token(Token = "0x400405B")]
			DTownsLeggings,
			// Token: 0x040084CF RID: 33999
			[global::Cpp2ILInjected.Token(Token = "0x400405C")]
			CenxsDressPants,
			// Token: 0x040084D0 RID: 34000
			[global::Cpp2ILInjected.Token(Token = "0x400405D")]
			PumpkinLeggings,
			// Token: 0x040084D1 RID: 34001
			[global::Cpp2ILInjected.Token(Token = "0x400405E")]
			NursePants,
			// Token: 0x040084D2 RID: 34002
			[global::Cpp2ILInjected.Token(Token = "0x400405F")]
			CyborgPants,
			// Token: 0x040084D3 RID: 34003
			[global::Cpp2ILInjected.Token(Token = "0x4004060")]
			CreeperPants,
			// Token: 0x040084D4 RID: 34004
			[global::Cpp2ILInjected.Token(Token = "0x4004061")]
			CatPants,
			// Token: 0x040084D5 RID: 34005
			[global::Cpp2ILInjected.Token(Token = "0x4004062")]
			PumpkinPants,
			// Token: 0x040084D6 RID: 34006
			[global::Cpp2ILInjected.Token(Token = "0x4004063")]
			RobotPants,
			// Token: 0x040084D7 RID: 34007
			[global::Cpp2ILInjected.Token(Token = "0x4004064")]
			UnicornPants,
			// Token: 0x040084D8 RID: 34008
			[global::Cpp2ILInjected.Token(Token = "0x4004065")]
			VampirePants,
			// Token: 0x040084D9 RID: 34009
			[global::Cpp2ILInjected.Token(Token = "0x4004066")]
			LeprechaunPants,
			// Token: 0x040084DA RID: 34010
			[global::Cpp2ILInjected.Token(Token = "0x4004067")]
			PixiePants,
			// Token: 0x040084DB RID: 34011
			[global::Cpp2ILInjected.Token(Token = "0x4004068")]
			WitchBoots,
			// Token: 0x040084DC RID: 34012
			[global::Cpp2ILInjected.Token(Token = "0x4004069")]
			KarateTortoisePants,
			// Token: 0x040084DD RID: 34013
			[global::Cpp2ILInjected.Token(Token = "0x400406A")]
			ScarecrowPants,
			// Token: 0x040084DE RID: 34014
			[global::Cpp2ILInjected.Token(Token = "0x400406B")]
			FoxPants,
			// Token: 0x040084DF RID: 34015
			[global::Cpp2ILInjected.Token(Token = "0x400406C")]
			SpookyLeggings,
			// Token: 0x040084E0 RID: 34016
			[global::Cpp2ILInjected.Token(Token = "0x400406D")]
			SpaceCreaturePants,
			// Token: 0x040084E1 RID: 34017
			[global::Cpp2ILInjected.Token(Token = "0x400406E")]
			WolfPants,
			// Token: 0x040084E2 RID: 34018
			[global::Cpp2ILInjected.Token(Token = "0x400406F")]
			TreasureHunterPants,
			// Token: 0x040084E3 RID: 34019
			[global::Cpp2ILInjected.Token(Token = "0x4004070")]
			DryadLoincloth,
			// Token: 0x040084E4 RID: 34020
			[global::Cpp2ILInjected.Token(Token = "0x4004071")]
			MrsClauseHeels,
			// Token: 0x040084E5 RID: 34021
			[global::Cpp2ILInjected.Token(Token = "0x4004072")]
			TreeTrunks,
			// Token: 0x040084E6 RID: 34022
			[global::Cpp2ILInjected.Token(Token = "0x4004073")]
			ParkaPants,
			// Token: 0x040084E7 RID: 34023
			[global::Cpp2ILInjected.Token(Token = "0x4004074")]
			ElfPants,
			// Token: 0x040084E8 RID: 34024
			[global::Cpp2ILInjected.Token(Token = "0x4004075")]
			BeetleLeggings = 98,
			// Token: 0x040084E9 RID: 34025
			[global::Cpp2ILInjected.Token(Token = "0x4004076")]
			BeeGreaves = 103,
			// Token: 0x040084EA RID: 34026
			[global::Cpp2ILInjected.Token(Token = "0x4004077")]
			AnglerPants,
			// Token: 0x040084EB RID: 34027
			[global::Cpp2ILInjected.Token(Token = "0x4004078")]
			SpiderGreaves,
			// Token: 0x040084EC RID: 34028
			[global::Cpp2ILInjected.Token(Token = "0x4004079")]
			MermaidTail,
			// Token: 0x040084ED RID: 34029
			[global::Cpp2ILInjected.Token(Token = "0x400407A")]
			FishCostumeFinskirt,
			// Token: 0x040084EE RID: 34030
			[global::Cpp2ILInjected.Token(Token = "0x400407B")]
			BorealWoodGreaves,
			// Token: 0x040084EF RID: 34031
			[global::Cpp2ILInjected.Token(Token = "0x400407C")]
			PalmWoodGreaves,
			// Token: 0x040084F0 RID: 34032
			[global::Cpp2ILInjected.Token(Token = "0x400407D")]
			VortexLeggings,
			// Token: 0x040084F1 RID: 34033
			[global::Cpp2ILInjected.Token(Token = "0x400407E")]
			NebulaLeggings,
			// Token: 0x040084F2 RID: 34034
			[global::Cpp2ILInjected.Token(Token = "0x400407F")]
			SolarFlareLeggings,
			// Token: 0x040084F3 RID: 34035
			[global::Cpp2ILInjected.Token(Token = "0x4004080")]
			MartianCostumePants,
			// Token: 0x040084F4 RID: 34036
			[global::Cpp2ILInjected.Token(Token = "0x4004081")]
			MartianUniformPants,
			// Token: 0x040084F5 RID: 34037
			[global::Cpp2ILInjected.Token(Token = "0x4004082")]
			DryadLoinclothOnMannequin = 117,
			// Token: 0x040084F6 RID: 34038
			[global::Cpp2ILInjected.Token(Token = "0x4004083")]
			MrsClauseHeelsOnMannequin = 120,
			// Token: 0x040084F7 RID: 34039
			[global::Cpp2ILInjected.Token(Token = "0x4004084")]
			GladiatorLeggings = 122,
			// Token: 0x040084F8 RID: 34040
			[global::Cpp2ILInjected.Token(Token = "0x4004085")]
			TaxCollectorPants = 124,
			// Token: 0x040084F9 RID: 34041
			[global::Cpp2ILInjected.Token(Token = "0x4004086")]
			ClothierPants,
			// Token: 0x040084FA RID: 34042
			[global::Cpp2ILInjected.Token(Token = "0x4004087")]
			BuccaneerPants,
			// Token: 0x040084FB RID: 34043
			[global::Cpp2ILInjected.Token(Token = "0x4004088")]
			ObsidianPants,
			// Token: 0x040084FC RID: 34044
			[global::Cpp2ILInjected.Token(Token = "0x4004089")]
			FallenTuxedoPants,
			// Token: 0x040084FD RID: 34045
			[global::Cpp2ILInjected.Token(Token = "0x400408A")]
			FossilPants,
			// Token: 0x040084FE RID: 34046
			[global::Cpp2ILInjected.Token(Token = "0x400408B")]
			StardustLeggings,
			// Token: 0x040084FF RID: 34047
			[global::Cpp2ILInjected.Token(Token = "0x400408C")]
			Yoraiz0rPants = 132,
			// Token: 0x04008500 RID: 34048
			[global::Cpp2ILInjected.Token(Token = "0x400408D")]
			SkiphsPants,
			// Token: 0x04008501 RID: 34049
			[global::Cpp2ILInjected.Token(Token = "0x400408E")]
			LokisPants,
			// Token: 0x04008502 RID: 34050
			[global::Cpp2ILInjected.Token(Token = "0x400408F")]
			SillySunflowerBottoms = 138,
			// Token: 0x04008503 RID: 34051
			[global::Cpp2ILInjected.Token(Token = "0x4004090")]
			PedguinsTrousers,
			// Token: 0x04008504 RID: 34052
			[global::Cpp2ILInjected.Token(Token = "0x4004091")]
			DjinnsCurse,
			// Token: 0x04008505 RID: 34053
			[global::Cpp2ILInjected.Token(Token = "0x4004092")]
			AncientArmor,
			// Token: 0x04008506 RID: 34054
			[global::Cpp2ILInjected.Token(Token = "0x4004093")]
			AncientBattleArmor,
			// Token: 0x04008507 RID: 34055
			[global::Cpp2ILInjected.Token(Token = "0x4004094")]
			Lamia,
			// Token: 0x04008508 RID: 34056
			[global::Cpp2ILInjected.Token(Token = "0x4004095")]
			ApprenticeTrousers,
			// Token: 0x04008509 RID: 34057
			[global::Cpp2ILInjected.Token(Token = "0x4004096")]
			SquireGreaves,
			// Token: 0x0400850A RID: 34058
			[global::Cpp2ILInjected.Token(Token = "0x4004097")]
			HuntressPantsMale,
			// Token: 0x0400850B RID: 34059
			[global::Cpp2ILInjected.Token(Token = "0x4004098")]
			HuntressPantsFemale,
			// Token: 0x0400850C RID: 34060
			[global::Cpp2ILInjected.Token(Token = "0x4004099")]
			MonkPants,
			// Token: 0x0400850D RID: 34061
			[global::Cpp2ILInjected.Token(Token = "0x400409A")]
			ApprenticeRobeExtension,
			// Token: 0x0400850E RID: 34062
			[global::Cpp2ILInjected.Token(Token = "0x400409B")]
			SquirePlatingExtension,
			// Token: 0x0400850F RID: 34063
			[global::Cpp2ILInjected.Token(Token = "0x400409C")]
			HuntressJerkinExtension,
			// Token: 0x04008510 RID: 34064
			[global::Cpp2ILInjected.Token(Token = "0x400409D")]
			ValhallaKnight,
			// Token: 0x04008511 RID: 34065
			[global::Cpp2ILInjected.Token(Token = "0x400409E")]
			ApprenticeDark,
			// Token: 0x04008512 RID: 34066
			[global::Cpp2ILInjected.Token(Token = "0x400409F")]
			RedRidingHuntress,
			// Token: 0x04008513 RID: 34067
			[global::Cpp2ILInjected.Token(Token = "0x40040A0")]
			RedRidingHuntress_Male,
			// Token: 0x04008514 RID: 34068
			[global::Cpp2ILInjected.Token(Token = "0x40040A1")]
			ShinobiInfiltrator,
			// Token: 0x04008515 RID: 34069
			[global::Cpp2ILInjected.Token(Token = "0x40040A2")]
			ArkhalisPants_Male,
			// Token: 0x04008516 RID: 34070
			[global::Cpp2ILInjected.Token(Token = "0x40040A3")]
			ArkhalisPants_Female,
			// Token: 0x04008517 RID: 34071
			[global::Cpp2ILInjected.Token(Token = "0x40040A4")]
			LeinforsPants,
			// Token: 0x04008518 RID: 34072
			[global::Cpp2ILInjected.Token(Token = "0x40040A5")]
			LeinforsPantsCoat,
			// Token: 0x04008519 RID: 34073
			[global::Cpp2ILInjected.Token(Token = "0x40040A6")]
			DragonGreaves = 300,
			// Token: 0x0400851A RID: 34074
			[global::Cpp2ILInjected.Token(Token = "0x40040A7")]
			SpectralSubligar,
			// Token: 0x0400851B RID: 34075
			[global::Cpp2ILInjected.Token(Token = "0x40040A8")]
			TitanLeggings,
			// Token: 0x0400851C RID: 34076
			[global::Cpp2ILInjected.Token(Token = "0x40040A9")]
			HornedGodBoots,
			// Token: 0x0400851D RID: 34077
			[global::Cpp2ILInjected.Token(Token = "0x40040AA")]
			FabulousSlippers,
			// Token: 0x0400851E RID: 34078
			[global::Cpp2ILInjected.Token(Token = "0x40040AB")]
			GeorgesPants,
			// Token: 0x0400851F RID: 34079
			[global::Cpp2ILInjected.Token(Token = "0x40040AC")]
			ShirenPants,
			// Token: 0x04008520 RID: 34080
			[global::Cpp2ILInjected.Token(Token = "0x40040AD")]
			MonokumaLegs,
			// Token: 0x04008521 RID: 34081
			[global::Cpp2ILInjected.Token(Token = "0x40040AE")]
			MonomiLegs,
			// Token: 0x04008522 RID: 34082
			[global::Cpp2ILInjected.Token(Token = "0x40040AF")]
			TorosLegs,
			// Token: 0x04008523 RID: 34083
			[global::Cpp2ILInjected.Token(Token = "0x40040B0")]
			Count
		}
	}
}
