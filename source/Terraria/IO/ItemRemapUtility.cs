using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace Terraria.IO
{
	// Token: 0x020003CF RID: 975
	[global::Cpp2ILInjected.Token(Token = "0x200057C")]
	public static class ItemRemapUtility
	{
		// Token: 0x06002F98 RID: 12184 RVA: 0x0002A812 File Offset: 0x00028A12
		[global::Cpp2ILInjected.Token(Token = "0x6003404")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F420", Offset = "0x135F420", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsForbidden(int id)
		{
			throw null;
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x0002A815 File Offset: 0x00028A15
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

		// Token: 0x06002F9A RID: 12186 RVA: 0x0002A818 File Offset: 0x00028A18
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

		// Token: 0x06002F9B RID: 12187 RVA: 0x0002A81B File Offset: 0x00028A1B
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

		// Token: 0x06002F9C RID: 12188 RVA: 0x0002A81E File Offset: 0x00028A1E
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

		// Token: 0x06002F9D RID: 12189 RVA: 0x0002A821 File Offset: 0x00028A21
		[global::Cpp2ILInjected.Token(Token = "0x6003409")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F624", Offset = "0x135F624", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int RemapENGINEHeadSlot(int headSlot)
		{
			throw null;
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x0002A824 File Offset: 0x00028A24
		[global::Cpp2ILInjected.Token(Token = "0x600340A")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F638", Offset = "0x135F638", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int RemapENGINEBodySlot(int bodySlot)
		{
			throw null;
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x0002A827 File Offset: 0x00028A27
		[global::Cpp2ILInjected.Token(Token = "0x600340B")]
		[global::Cpp2ILInjected.Address(RVA = "0x135F64C", Offset = "0x135F64C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int RemapENGINELegsSlot(int legsSlot)
		{
			throw null;
		}

		// Token: 0x04003330 RID: 13104
		[global::Cpp2ILInjected.Token(Token = "0x40040B1")]
		public const short DragonMask = 10000;

		// Token: 0x04003331 RID: 13105
		[global::Cpp2ILInjected.Token(Token = "0x40040B2")]
		public const short DragonBreastplate = 10001;

		// Token: 0x04003332 RID: 13106
		[global::Cpp2ILInjected.Token(Token = "0x40040B3")]
		public const short DragonGreaves = 10002;

		// Token: 0x04003333 RID: 13107
		[global::Cpp2ILInjected.Token(Token = "0x40040B4")]
		public const short SpectralHeadgear = 10003;

		// Token: 0x04003334 RID: 13108
		[global::Cpp2ILInjected.Token(Token = "0x40040B5")]
		public const short SpectralArmor = 10004;

		// Token: 0x04003335 RID: 13109
		[global::Cpp2ILInjected.Token(Token = "0x40040B6")]
		public const short SpectralSubligar = 10005;

		// Token: 0x04003336 RID: 13110
		[global::Cpp2ILInjected.Token(Token = "0x40040B7")]
		public const short TitanHelmet = 10006;

		// Token: 0x04003337 RID: 13111
		[global::Cpp2ILInjected.Token(Token = "0x40040B8")]
		public const short TitanMail = 10007;

		// Token: 0x04003338 RID: 13112
		[global::Cpp2ILInjected.Token(Token = "0x40040B9")]
		public const short TitanLeggings = 10008;

		// Token: 0x04003339 RID: 13113
		[global::Cpp2ILInjected.Token(Token = "0x40040BA")]
		public const short OcramMask = 10009;

		// Token: 0x0400333A RID: 13114
		[global::Cpp2ILInjected.Token(Token = "0x40040BB")]
		public const short HornedGodMask = 10010;

		// Token: 0x0400333B RID: 13115
		[global::Cpp2ILInjected.Token(Token = "0x40040BC")]
		public const short HornedGodRobe = 10011;

		// Token: 0x0400333C RID: 13116
		[global::Cpp2ILInjected.Token(Token = "0x40040BD")]
		public const short HornedGodBoots = 10012;

		// Token: 0x0400333D RID: 13117
		[global::Cpp2ILInjected.Token(Token = "0x40040BE")]
		public const short OcramTrophy = 10013;

		// Token: 0x0400333E RID: 13118
		[global::Cpp2ILInjected.Token(Token = "0x40040BF")]
		public const short AlbinoAntlionBanner = 10014;

		// Token: 0x0400333F RID: 13119
		[global::Cpp2ILInjected.Token(Token = "0x40040C0")]
		public const short ArchWyvernBanner = 10015;

		// Token: 0x04003340 RID: 13120
		[global::Cpp2ILInjected.Token(Token = "0x40040C1")]
		public const short ArchDemonBanner = 10016;

		// Token: 0x04003341 RID: 13121
		[global::Cpp2ILInjected.Token(Token = "0x40040C2")]
		public const short DragonSnatcherBanner = 10017;

		// Token: 0x04003342 RID: 13122
		[global::Cpp2ILInjected.Token(Token = "0x40040C3")]
		public const short OrcaBanner = 10018;

		// Token: 0x04003343 RID: 13123
		[global::Cpp2ILInjected.Token(Token = "0x40040C4")]
		public const short ShadowHammerBanner = 10019;

		// Token: 0x04003344 RID: 13124
		[global::Cpp2ILInjected.Token(Token = "0x40040C5")]
		public const short ShadowMummyBanner = 10020;

		// Token: 0x04003345 RID: 13125
		[global::Cpp2ILInjected.Token(Token = "0x40040C6")]
		public const short SpectralGastropodBanner = 10021;

		// Token: 0x04003346 RID: 13126
		[global::Cpp2ILInjected.Token(Token = "0x40040C7")]
		public const short SpectralElementalBanner = 10022;

		// Token: 0x04003347 RID: 13127
		[global::Cpp2ILInjected.Token(Token = "0x40040C8")]
		public const short VampireMinerBanner = 10023;

		// Token: 0x04003348 RID: 13128
		[global::Cpp2ILInjected.Token(Token = "0x40040C9")]
		public const short MusicBoxTutorial = 10024;

		// Token: 0x04003349 RID: 13129
		[global::Cpp2ILInjected.Token(Token = "0x40040CA")]
		public const short StarTopper4 = 10025;

		// Token: 0x0400334A RID: 13130
		[global::Cpp2ILInjected.Token(Token = "0x40040CB")]
		public const short StarTopper5 = 10026;

		// Token: 0x0400334B RID: 13131
		[global::Cpp2ILInjected.Token(Token = "0x40040CC")]
		public const short ShirenHat = 10027;

		// Token: 0x0400334C RID: 13132
		[global::Cpp2ILInjected.Token(Token = "0x40040CD")]
		public const short ShirenShirt = 10028;

		// Token: 0x0400334D RID: 13133
		[global::Cpp2ILInjected.Token(Token = "0x40040CE")]
		public const short ShirenPants = 10029;

		// Token: 0x0400334E RID: 13134
		[global::Cpp2ILInjected.Token(Token = "0x40040CF")]
		public const short MonokumaHead = 10030;

		// Token: 0x0400334F RID: 13135
		[global::Cpp2ILInjected.Token(Token = "0x40040D0")]
		public const short MonokumaBody = 10031;

		// Token: 0x04003350 RID: 13136
		[global::Cpp2ILInjected.Token(Token = "0x40040D1")]
		public const short MonokumaLegs = 10032;

		// Token: 0x04003351 RID: 13137
		[global::Cpp2ILInjected.Token(Token = "0x40040D2")]
		public const short WhiteThread = 10033;

		// Token: 0x04003352 RID: 13138
		[global::Cpp2ILInjected.Token(Token = "0x40040D3")]
		public const short MonomiHead = 10034;

		// Token: 0x04003353 RID: 13139
		[global::Cpp2ILInjected.Token(Token = "0x40040D4")]
		public const short MonomiBody = 10035;

		// Token: 0x04003354 RID: 13140
		[global::Cpp2ILInjected.Token(Token = "0x40040D5")]
		public const short MonomiLegs = 10036;

		// Token: 0x04003355 RID: 13141
		[global::Cpp2ILInjected.Token(Token = "0x40040D6")]
		public const short TorosHead = 10037;

		// Token: 0x04003356 RID: 13142
		[global::Cpp2ILInjected.Token(Token = "0x40040D7")]
		public const short TorosBody = 10038;

		// Token: 0x04003357 RID: 13143
		[global::Cpp2ILInjected.Token(Token = "0x40040D8")]
		public const short TorosLegs = 10039;
	}
}
