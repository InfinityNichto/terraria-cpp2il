using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.IO;
using Terraria.Utilities;

// Token: 0x0200022D RID: 557
[global::Cpp2ILInjected.Token(Token = "0x20002DF")]
internal class Player_OldConsole
{
	// Token: 0x06000F8F RID: 3983 RVA: 0x000249AA File Offset: 0x00022BAA
	[global::Cpp2ILInjected.Token(Token = "0x60010D8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4FFA4", Offset = "0xA4FFA4", Length = "0x30")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemRemapUtility), Member = "RemapItemID", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(short))]
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		throw null;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x000249AD File Offset: 0x00022BAD
	[global::Cpp2ILInjected.Token(Token = "0x60010D9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4FFD4", Offset = "0xA4FFD4", Length = "0x21E0")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RijndaelManaged), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(Stream),
		typeof(ICryptoTransform),
		typeof(CryptoStreamMode)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "FromCurrentSettings", MemberParameters = new object[] { typeof(FileType) }, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Read", MemberParameters = new object[]
	{
		typeof(BinaryReader),
		typeof(FileType)
	}, ReturnType = typeof(FileMetadata))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "set_Player", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BitsByte))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "set_Male", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ReadRGB", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(Color))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemID), Member = "FromLegacyName", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Prefix", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemRemapUtility), Member = "RemapItemID", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(short))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemConversion_OldConsole), Member = "ModifyItem", MemberParameters = new object[]
	{
		typeof(ref short),
		typeof(ref short),
		typeof(ref byte),
		typeof(bool)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player_OldConsole), Member = "GivePlayerCoins", MemberParameters = new object[]
	{
		typeof(Player),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 75)]
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		throw null;
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x000249B0 File Offset: 0x00022BB0
	[global::Cpp2ILInjected.Token(Token = "0x60010DA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA521B4", Offset = "0xA521B4", Length = "0x40C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player_OldConsole), Member = "LoadPlayer", MemberParameters = new object[]
	{
		typeof(string),
		typeof(PlayerFileData)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "DoCoins", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	private static void GivePlayerCoins(Player player, int value)
	{
		throw null;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x000249B3 File Offset: 0x00022BB3
	[global::Cpp2ILInjected.Token(Token = "0x60010DB")]
	[global::Cpp2ILInjected.Address(RVA = "0xA525C0", Offset = "0xA525C0", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Player_OldConsole()
	{
		throw null;
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x000249B6 File Offset: 0x00022BB6
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60010DC")]
	[global::Cpp2ILInjected.Address(RVA = "0xA525C8", Offset = "0xA525C8", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	static Player_OldConsole()
	{
		throw null;
	}

	// Token: 0x04001B30 RID: 6960
	[global::Cpp2ILInjected.Token(Token = "0x40020BD")]
	private const int PlayerFileVersion_GUID = 1000;

	// Token: 0x04001B31 RID: 6961
	[global::Cpp2ILInjected.Token(Token = "0x40020BE")]
	private const int PlayerFileVersion_1_3_1 = 1001;

	// Token: 0x04001B32 RID: 6962
	[global::Cpp2ILInjected.Token(Token = "0x40020BF")]
	private const int PlayerFileVersion_1_3_4 = 1002;

	// Token: 0x04001B33 RID: 6963
	[global::Cpp2ILInjected.Token(Token = "0x40020C0")]
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	// Token: 0x04001B34 RID: 6964
	[global::Cpp2ILInjected.Token(Token = "0x40020C1")]
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	// Token: 0x04001B35 RID: 6965
	[global::Cpp2ILInjected.Token(Token = "0x40020C2")]
	public static byte[] EncryptionKey;
}
