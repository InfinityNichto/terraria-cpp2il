using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x020003C7 RID: 967
	[global::Cpp2ILInjected.Token(Token = "0x2000571")]
	public static class Player_OldMobile
	{
		// Token: 0x06002F6C RID: 12140 RVA: 0x0002A78E File Offset: 0x0002898E
		[global::Cpp2ILInjected.Token(Token = "0x60033D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13438C8", Offset = "0x13438C8", Length = "0x410")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
		{
			throw null;
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x0002A791 File Offset: 0x00028991
		[global::Cpp2ILInjected.Token(Token = "0x60033D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13448AC", Offset = "0x13448AC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = "Initialize", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private unsafe static void DecryptPlayerData(long offset, long encryptedSize)
		{
			throw null;
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x0002A794 File Offset: 0x00028994
		[global::Cpp2ILInjected.Token(Token = "0x60033DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x13449FC", Offset = "0x13449FC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "LoadOld", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private static bool IsValidBuff(int buffType)
		{
			throw null;
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x0002A797 File Offset: 0x00028997
		[global::Cpp2ILInjected.Token(Token = "0x60033DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1344A98", Offset = "0x1344A98", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "LoadOld", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "DoCoins", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private static void GivePlayerCoins(Player player, int value)
		{
			throw null;
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x0002A79A File Offset: 0x0002899A
		[global::Cpp2ILInjected.Token(Token = "0x60033DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1344EA4", Offset = "0x1344EA4", Length = "0xAA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadOldNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "set_Male", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldMobile), Member = "ModifyItem", MemberParameters = new object[]
		{
			typeof(ref short),
			typeof(ref short),
			typeof(ref byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player_OldMobile), Member = "GivePlayerCoins", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player_OldMobile), Member = "IsValidBuff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static bool LoadOld(BinaryReader reader, int release, ref Player player)
		{
			throw null;
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x0002A79D File Offset: 0x0002899D
		[global::Cpp2ILInjected.Token(Token = "0x60033DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1343CD8", Offset = "0x1343CD8", Length = "0xBD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldMobile), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerFileData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player_OldMobile), Member = "DecryptPlayerData", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "set_Male", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldMobile), Member = "ModifyItem", MemberParameters = new object[]
		{
			typeof(ref short),
			typeof(ref short),
			typeof(ref byte),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileHelpers), Member = "ReadOldNetString", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player_OldMobile), Member = "IsValidBuff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player_OldMobile), Member = "LoadOld", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int),
			typeof(ref Player)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static bool Load(BinaryReader reader, ref Player player)
		{
			throw null;
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x0002A7A0 File Offset: 0x000289A0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60033DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x134594C", Offset = "0x134594C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BlowFish), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Player_OldMobile()
		{
			throw null;
		}

		// Token: 0x040032BB RID: 12987
		[global::Cpp2ILInjected.Token(Token = "0x4003E1B")]
		private const int VERSION_1 = 1;

		// Token: 0x040032BC RID: 12988
		[global::Cpp2ILInjected.Token(Token = "0x4003E1C")]
		private const int VERSION_2 = 2;

		// Token: 0x040032BD RID: 12989
		[global::Cpp2ILInjected.Token(Token = "0x4003E1D")]
		private const int VERSION_3 = 3;

		// Token: 0x040032BE RID: 12990
		[global::Cpp2ILInjected.Token(Token = "0x4003E1E")]
		private const int VERSION_4 = 4;

		// Token: 0x040032BF RID: 12991
		[global::Cpp2ILInjected.Token(Token = "0x4003E1F")]
		private const int VERSION_7 = 7;

		// Token: 0x040032C0 RID: 12992
		[global::Cpp2ILInjected.Token(Token = "0x4003E20")]
		private const int VERSION_9 = 9;

		// Token: 0x040032C1 RID: 12993
		[global::Cpp2ILInjected.Token(Token = "0x4003E21")]
		private const int VERSION_10 = 10;

		// Token: 0x040032C2 RID: 12994
		[global::Cpp2ILInjected.Token(Token = "0x4003E22")]
		private const int VERSION_11 = 11;

		// Token: 0x040032C3 RID: 12995
		[global::Cpp2ILInjected.Token(Token = "0x4003E23")]
		private const int VERSION_12 = 12;

		// Token: 0x040032C4 RID: 12996
		[global::Cpp2ILInjected.Token(Token = "0x4003E24")]
		private const int VERSION_13 = 13;

		// Token: 0x040032C5 RID: 12997
		[global::Cpp2ILInjected.Token(Token = "0x4003E25")]
		private const int VERSION_14 = 14;

		// Token: 0x040032C6 RID: 12998
		[global::Cpp2ILInjected.Token(Token = "0x4003E26")]
		private const int VERSION_15 = 15;

		// Token: 0x040032C7 RID: 12999
		[global::Cpp2ILInjected.Token(Token = "0x4003E27")]
		private const int VERSION_16 = 16;

		// Token: 0x040032C8 RID: 13000
		[global::Cpp2ILInjected.Token(Token = "0x4003E28")]
		private const int VERSION_17 = 17;

		// Token: 0x040032C9 RID: 13001
		[global::Cpp2ILInjected.Token(Token = "0x4003E29")]
		private const int VERSION_18 = 18;

		// Token: 0x040032CA RID: 13002
		[global::Cpp2ILInjected.Token(Token = "0x4003E2A")]
		private const int VERSION_19 = 19;

		// Token: 0x040032CB RID: 13003
		[global::Cpp2ILInjected.Token(Token = "0x4003E2B")]
		private const int VERSION_20 = 20;

		// Token: 0x040032CC RID: 13004
		[global::Cpp2ILInjected.Token(Token = "0x4003E2C")]
		private const int VERSION_21 = 21;

		// Token: 0x040032CD RID: 13005
		[global::Cpp2ILInjected.Token(Token = "0x4003E2D")]
		private const int VERSION_22 = 22;

		// Token: 0x040032CE RID: 13006
		[global::Cpp2ILInjected.Token(Token = "0x4003E2E")]
		private const int VERSION_23 = 23;

		// Token: 0x040032CF RID: 13007
		[global::Cpp2ILInjected.Token(Token = "0x4003E2F")]
		private const int VERSION_24 = 24;

		// Token: 0x040032D0 RID: 13008
		[global::Cpp2ILInjected.Token(Token = "0x4003E30")]
		private const int VERSION_CURRENT = 24;

		// Token: 0x040032D1 RID: 13009
		[global::Cpp2ILInjected.Token(Token = "0x4003E31")]
		private const int PLAYER_DATA_VERSION = 24;

		// Token: 0x040032D2 RID: 13010
		[global::Cpp2ILInjected.Token(Token = "0x4003E32")]
		private static BlowFish playerDecrypter;

		// Token: 0x040032D3 RID: 13011
		[global::Cpp2ILInjected.Token(Token = "0x4003E33")]
		private static byte[] inputData;
	}
}
