using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x02000221 RID: 545
[global::Cpp2ILInjected.Token(Token = "0x20002CD")]
public class SaveSynchronisationOperation_SendFile : SaveSynchronisationOperation
{
	// Token: 0x06000F58 RID: 3928 RVA: 0x00024905 File Offset: 0x00022B05
	[global::Cpp2ILInjected.Token(Token = "0x6001090")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44C08", Offset = "0xA44C08", Length = "0x2DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "SendFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "SendFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileManager), Member = "GetFiles", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
	public SaveSynchronisationOperation_SendFile(string filenameToSend, SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		throw null;
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x00024908 File Offset: 0x00022B08
	[global::Cpp2ILInjected.Token(Token = "0x6001091")]
	[global::Cpp2ILInjected.Address(RVA = "0xA476EC", Offset = "0xA476EC", Length = "0x468")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "WriteMessageLength", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFile), Member = "SendNextChunk", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public override void Begin()
	{
		throw null;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x0002490B File Offset: 0x00022B0B
	[global::Cpp2ILInjected.Token(Token = "0x6001092")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47C68", Offset = "0xA47C68", Length = "0x130")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFile), Member = "SendNextChunk", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "ReadAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(bool)
	}, ReturnType = typeof(byte[]))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		throw null;
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x0002490E File Offset: 0x00022B0E
	[global::Cpp2ILInjected.Token(Token = "0x6001093")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47B54", Offset = "0xA47B54", Length = "0x114")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFile), Member = "Begin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFile), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void SendNextChunk()
	{
		throw null;
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x00024911 File Offset: 0x00022B11
	[global::Cpp2ILInjected.Token(Token = "0x6001094")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47D98", Offset = "0xA47D98", Length = "0xBC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
	{
		typeof(string),
		typeof(object)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public override string GetStatus()
	{
		throw null;
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x00024914 File Offset: 0x00022B14
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6001095")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47E54", Offset = "0xA47E54", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static SaveSynchronisationOperation_SendFile()
	{
		throw null;
	}

	// Token: 0x04001A28 RID: 6696
	[global::Cpp2ILInjected.Token(Token = "0x4001F71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string filename;

	// Token: 0x04001A29 RID: 6697
	[global::Cpp2ILInjected.Token(Token = "0x4001F72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private byte[] fileDataToSend;

	// Token: 0x04001A2A RID: 6698
	[global::Cpp2ILInjected.Token(Token = "0x4001F73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private int sendOffset;

	// Token: 0x04001A2B RID: 6699
	[global::Cpp2ILInjected.Token(Token = "0x4001F74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private int pendingChunks;

	// Token: 0x04001A2C RID: 6700
	[global::Cpp2ILInjected.Token(Token = "0x4001F75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private int mapFilesOffset;

	// Token: 0x04001A2D RID: 6701
	[global::Cpp2ILInjected.Token(Token = "0x4001F76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private string[] mapFiles;

	// Token: 0x04001A2E RID: 6702
	[global::Cpp2ILInjected.Token(Token = "0x4001F77")]
	private static byte[] fileDataBuffer;
}
