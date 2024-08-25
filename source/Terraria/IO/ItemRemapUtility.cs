using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Terraria.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x200057C")]
	public static class ItemRemapUtility
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003404")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F420", Offset = "0x135F420", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsForbidden(int id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003405")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F458", Offset = "0x135F458", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "ReadItemID", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "ReadItemID", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemRemapUtility), Member = "RemapNegativeItemID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemRemapUtility), Member = "RemapENGINEItemID", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static short RemapItemID(int itemID, bool remapENGINEItems)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003406")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F558", Offset = "0x135F558", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemRemapUtility), Member = "RemapItemID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int RemapNegativeItemID(int itemID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003407")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F580", Offset = "0x135F580", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemRemapUtility), Member = "RemapItemID", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static int RemapENGINEItemID(int itemID)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003408")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F59C", Offset = "0x135F59C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile_OldConsole), Member = "LoadWorldTiles", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(bool[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void RemapENGINEMannequin(ref short tileFrameX, ref short tileFrameY)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003409")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F624", Offset = "0x135F624", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int RemapENGINEHeadSlot(int headSlot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600340A")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F638", Offset = "0x135F638", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int RemapENGINEBodySlot(int bodySlot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600340B")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F64C", Offset = "0x135F64C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int RemapENGINELegsSlot(int legsSlot)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40040B1")]
		public const short DragonMask = 10000;

		[global::Cpp2ILInjected.Token(Token = "0x40040B2")]
		public const short DragonBreastplate = 10001;

		[global::Cpp2ILInjected.Token(Token = "0x40040B3")]
		public const short DragonGreaves = 10002;

		[global::Cpp2ILInjected.Token(Token = "0x40040B4")]
		public const short SpectralHeadgear = 10003;

		[global::Cpp2ILInjected.Token(Token = "0x40040B5")]
		public const short SpectralArmor = 10004;

		[global::Cpp2ILInjected.Token(Token = "0x40040B6")]
		public const short SpectralSubligar = 10005;

		[global::Cpp2ILInjected.Token(Token = "0x40040B7")]
		public const short TitanHelmet = 10006;

		[global::Cpp2ILInjected.Token(Token = "0x40040B8")]
		public const short TitanMail = 10007;

		[global::Cpp2ILInjected.Token(Token = "0x40040B9")]
		public const short TitanLeggings = 10008;

		[global::Cpp2ILInjected.Token(Token = "0x40040BA")]
		public const short OcramMask = 10009;

		[global::Cpp2ILInjected.Token(Token = "0x40040BB")]
		public const short HornedGodMask = 10010;

		[global::Cpp2ILInjected.Token(Token = "0x40040BC")]
		public const short HornedGodRobe = 10011;

		[global::Cpp2ILInjected.Token(Token = "0x40040BD")]
		public const short HornedGodBoots = 10012;

		[global::Cpp2ILInjected.Token(Token = "0x40040BE")]
		public const short OcramTrophy = 10013;

		[global::Cpp2ILInjected.Token(Token = "0x40040BF")]
		public const short AlbinoAntlionBanner = 10014;

		[global::Cpp2ILInjected.Token(Token = "0x40040C0")]
		public const short ArchWyvernBanner = 10015;

		[global::Cpp2ILInjected.Token(Token = "0x40040C1")]
		public const short ArchDemonBanner = 10016;

		[global::Cpp2ILInjected.Token(Token = "0x40040C2")]
		public const short DragonSnatcherBanner = 10017;

		[global::Cpp2ILInjected.Token(Token = "0x40040C3")]
		public const short OrcaBanner = 10018;

		[global::Cpp2ILInjected.Token(Token = "0x40040C4")]
		public const short ShadowHammerBanner = 10019;

		[global::Cpp2ILInjected.Token(Token = "0x40040C5")]
		public const short ShadowMummyBanner = 10020;

		[global::Cpp2ILInjected.Token(Token = "0x40040C6")]
		public const short SpectralGastropodBanner = 10021;

		[global::Cpp2ILInjected.Token(Token = "0x40040C7")]
		public const short SpectralElementalBanner = 10022;

		[global::Cpp2ILInjected.Token(Token = "0x40040C8")]
		public const short VampireMinerBanner = 10023;

		[global::Cpp2ILInjected.Token(Token = "0x40040C9")]
		public const short MusicBoxTutorial = 10024;

		[global::Cpp2ILInjected.Token(Token = "0x40040CA")]
		public const short StarTopper4 = 10025;

		[global::Cpp2ILInjected.Token(Token = "0x40040CB")]
		public const short StarTopper5 = 10026;

		[global::Cpp2ILInjected.Token(Token = "0x40040CC")]
		public const short ShirenHat = 10027;

		[global::Cpp2ILInjected.Token(Token = "0x40040CD")]
		public const short ShirenShirt = 10028;

		[global::Cpp2ILInjected.Token(Token = "0x40040CE")]
		public const short ShirenPants = 10029;

		[global::Cpp2ILInjected.Token(Token = "0x40040CF")]
		public const short MonokumaHead = 10030;

		[global::Cpp2ILInjected.Token(Token = "0x40040D0")]
		public const short MonokumaBody = 10031;

		[global::Cpp2ILInjected.Token(Token = "0x40040D1")]
		public const short MonokumaLegs = 10032;

		[global::Cpp2ILInjected.Token(Token = "0x40040D2")]
		public const short WhiteThread = 10033;

		[global::Cpp2ILInjected.Token(Token = "0x40040D3")]
		public const short MonomiHead = 10034;

		[global::Cpp2ILInjected.Token(Token = "0x40040D4")]
		public const short MonomiBody = 10035;

		[global::Cpp2ILInjected.Token(Token = "0x40040D5")]
		public const short MonomiLegs = 10036;

		[global::Cpp2ILInjected.Token(Token = "0x40040D6")]
		public const short TorosHead = 10037;

		[global::Cpp2ILInjected.Token(Token = "0x40040D7")]
		public const short TorosBody = 10038;

		[global::Cpp2ILInjected.Token(Token = "0x40040D8")]
		public const short TorosLegs = 10039;
	}
}
