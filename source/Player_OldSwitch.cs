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

// Token: 0x0200022F RID: 559
[global::Cpp2ILInjected.Token(Token = "0x20002E1")]
internal class Player_OldSwitch
{
	// Token: 0x06000FAC RID: 4012 RVA: 0x00024A01 File Offset: 0x00022C01
	[global::Cpp2ILInjected.Token(Token = "0x60010F5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BF74", Offset = "0xA5BF74", Length = "0x1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	private static short ReadItemID(BinaryReader fileIO, int playerFileVersion)
	{
		throw null;
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00024A04 File Offset: 0x00022C04
	[global::Cpp2ILInjected.Token(Token = "0x60010F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5BF90", Offset = "0xA5BF90", Length = "0x1D90")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "netDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Clone", ReturnType = typeof(Item))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "PlayerFrame", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 71)]
	public static bool LoadPlayer(string playerPath, PlayerFileData playerData)
	{
		throw null;
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00024A07 File Offset: 0x00022C07
	[global::Cpp2ILInjected.Token(Token = "0x60010F7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5DD20", Offset = "0xA5DD20", Length = "0x40C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "DoCoins", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
	private static void GivePlayerCoins(Player player, int value)
	{
		throw null;
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00024A0A File Offset: 0x00022C0A
	[global::Cpp2ILInjected.Token(Token = "0x60010F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5E12C", Offset = "0xA5E12C", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public Player_OldSwitch()
	{
		throw null;
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00024A0D File Offset: 0x00022C0D
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x60010F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA5E134", Offset = "0xA5E134", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	static Player_OldSwitch()
	{
		throw null;
	}

	// Token: 0x04001B42 RID: 6978
	[global::Cpp2ILInjected.Token(Token = "0x40020CF")]
	private const int PlayerFileVersion_GUID = 1000;

	// Token: 0x04001B43 RID: 6979
	[global::Cpp2ILInjected.Token(Token = "0x40020D0")]
	private const int PlayerFileVersion_1_3_1 = 1001;

	// Token: 0x04001B44 RID: 6980
	[global::Cpp2ILInjected.Token(Token = "0x40020D1")]
	private const int PlayerFileVersion_1_3_4 = 1002;

	// Token: 0x04001B45 RID: 6981
	[global::Cpp2ILInjected.Token(Token = "0x40020D2")]
	private const int PlayerFileVersion_RemapENGINEItems = 1003;

	// Token: 0x04001B46 RID: 6982
	[global::Cpp2ILInjected.Token(Token = "0x40020D3")]
	private const int PlayerFileVersion_RememberDPadShortcut = 1004;

	// Token: 0x04001B47 RID: 6983
	[global::Cpp2ILInjected.Token(Token = "0x40020D4")]
	public static byte[] EncryptionKey;
}
