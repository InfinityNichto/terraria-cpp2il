using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.Utilities;
using UnityEngine;

// Token: 0x02000220 RID: 544
[global::Cpp2ILInjected.Token(Token = "0x20002CC")]
public class SaveSynchronisationOperation_ReceiveFile : SaveSynchronisationOperation
{
	// Token: 0x06000F53 RID: 3923 RVA: 0x000248F6 File Offset: 0x00022AF6
	[global::Cpp2ILInjected.Token(Token = "0x600108B")]
	[global::Cpp2ILInjected.Address(RVA = "0xA45590", Offset = "0xA45590", Length = "0x6C")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveSynchronisationOperation_ReceiveFile(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		throw null;
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x000248F9 File Offset: 0x00022AF9
	[global::Cpp2ILInjected.Token(Token = "0x600108C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46D20", Offset = "0xA46D20", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public override void Begin()
	{
		throw null;
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x000248FC File Offset: 0x00022AFC
	[global::Cpp2ILInjected.Token(Token = "0x600108D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46D24", Offset = "0xA46D24", Length = "0x758")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
	{
		typeof(Array),
		typeof(int),
		typeof(Array),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "SendEmptyMessage", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.MessageId) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_ReceiveFile), Member = "WriteFile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
	public override void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		throw null;
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x000248FF File Offset: 0x00022AFF
	[global::Cpp2ILInjected.Token(Token = "0x600108E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4747C", Offset = "0xA4747C", Length = "0x1BC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_ReceiveFile), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
	{
		typeof(string),
		typeof(byte[]),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	private void WriteFile()
	{
		throw null;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x00024902 File Offset: 0x00022B02
	[global::Cpp2ILInjected.Token(Token = "0x600108F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA47638", Offset = "0xA47638", Length = "0xB4")]
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

	// Token: 0x04001A24 RID: 6692
	[global::Cpp2ILInjected.Token(Token = "0x4001F6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private string filename;

	// Token: 0x04001A25 RID: 6693
	[global::Cpp2ILInjected.Token(Token = "0x4001F6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private int fileOffset;

	// Token: 0x04001A26 RID: 6694
	[global::Cpp2ILInjected.Token(Token = "0x4001F6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private int fileLength;

	// Token: 0x04001A27 RID: 6695
	[global::Cpp2ILInjected.Token(Token = "0x4001F70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private byte[] fileData;
}
