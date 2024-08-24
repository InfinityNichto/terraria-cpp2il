using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.IO;

// Token: 0x02000222 RID: 546
[global::Cpp2ILInjected.Token(Token = "0x20002CE")]
public class SaveSynchronisationOperation_SendFileList : SaveSynchronisationOperation
{
	// Token: 0x06000F5E RID: 3934 RVA: 0x00024917 File Offset: 0x00022B17
	[global::Cpp2ILInjected.Token(Token = "0x6001096")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47EBC", Offset = "0xA47EBC", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = ".ctor", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.SendDataFunction) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveSynchronisationOperation_SendFileList(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		throw null;
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x0002491A File Offset: 0x00022B1A
	[global::Cpp2ILInjected.Token(Token = "0x6001097")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47F24", Offset = "0xA47F24", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "SendEmptyMessage", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.MessageId) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendNextFile", ReturnType = typeof(void))]
	public override void Begin()
	{
		throw null;
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x0002491D File Offset: 0x00022B1D
	[global::Cpp2ILInjected.Token(Token = "0x6001098")]
	[global::Cpp2ILInjected.Address(RVA = "0xA480A8", Offset = "0xA480A8", Length = "0x458")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendNextFile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "WriteMessageHeader", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(SaveSynchronisationOperation.MessageId)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Write", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = "GetPlayTime", ReturnType = typeof(TimeSpan))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "WritePlayerData", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(Player)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "WriteMessageLength", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	private void SendPlayerFile(PlayerFileData playerFileData)
	{
		throw null;
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x00024920 File Offset: 0x00022B20
	[global::Cpp2ILInjected.Token(Token = "0x6001099")]
	[global::Cpp2ILInjected.Address(RVA = "0xA48500", Offset = "0xA48500", Length = "0x7F0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendPlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "op_Implicit", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(BitsByte))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitsByte), Member = "set_Item", MemberParameters = new object[]
	{
		typeof(int),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_UsingBiomeTorches", ReturnType = typeof(bool))]
	private void WritePlayerData(BinaryWriter writer, Player player)
	{
		throw null;
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00024923 File Offset: 0x00022B23
	[global::Cpp2ILInjected.Token(Token = "0x600109A")]
	[global::Cpp2ILInjected.Address(RVA = "0xA48CF0", Offset = "0xA48CF0", Length = "0x508")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendNextFile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "WriteMessageHeader", MemberParameters = new object[]
	{
		typeof(BinaryWriter),
		typeof(SaveSynchronisationOperation.MessageId)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileMetadata), Member = "Write", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "WriteMessageLength", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	private void SendWorldFile(WorldFileData worldFileData)
	{
		throw null;
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00024926 File Offset: 0x00022B26
	[global::Cpp2ILInjected.Token(Token = "0x600109B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47F5C", Offset = "0xA47F5C", Length = "0x14C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "Begin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendPlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendWorldFile", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "SendEmptyMessage", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.MessageId) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	private void SendNextFile()
	{
		throw null;
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x00024929 File Offset: 0x00022B29
	[global::Cpp2ILInjected.Token(Token = "0x600109C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA491F8", Offset = "0xA491F8", Length = "0x38")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendNextFile", ReturnType = typeof(void))]
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		throw null;
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x0002492C File Offset: 0x00022B2C
	[global::Cpp2ILInjected.Token(Token = "0x600109D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA49230", Offset = "0xA49230", Length = "0x18C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public override string GetStatus()
	{
		throw null;
	}

	// Token: 0x04001A2F RID: 6703
	[global::Cpp2ILInjected.Token(Token = "0x4001F78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private int fileCountPending;

	// Token: 0x04001A30 RID: 6704
	[global::Cpp2ILInjected.Token(Token = "0x4001F79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private int fileOffset;

	// Token: 0x04001A31 RID: 6705
	[global::Cpp2ILInjected.Token(Token = "0x4001F7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private bool sentPlayers;

	// Token: 0x04001A32 RID: 6706
	[global::Cpp2ILInjected.Token(Token = "0x4001F7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
	private bool sentWorlds;

	// Token: 0x04001A33 RID: 6707
	[global::Cpp2ILInjected.Token(Token = "0x4001F7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
	private bool sentEndList;
}
