using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Telepathy;
using Terraria;
using Terraria.Net;
using UnityEngine;

// Token: 0x0200021D RID: 541
[global::Cpp2ILInjected.Token(Token = "0x20002C6")]
public class SaveSynchronisationHost
{
	// Token: 0x06000F38 RID: 3896 RVA: 0x000248A5 File Offset: 0x00022AA5
	[global::Cpp2ILInjected.Token(Token = "0x600106C")]
	[global::Cpp2ILInjected.Address(RVA = "0xA461F4", Offset = "0xA461F4", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Start", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
	public void Start()
	{
		throw null;
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x000248A8 File Offset: 0x00022AA8
	[global::Cpp2ILInjected.Token(Token = "0x600106D")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46204", Offset = "0xA46204", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Stop", ReturnType = typeof(void))]
	public void Close()
	{
		throw null;
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x000248AB File Offset: 0x00022AAB
	[global::Cpp2ILInjected.Token(Token = "0x600106E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46210", Offset = "0xA46210", Length = "0x144")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "RequestFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToUInt16", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "Send", MemberParameters = new object[]
	{
		typeof(int),
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string),
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
	private void SendDataFunction(byte[] messageData, int length)
	{
		throw null;
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x000248AE File Offset: 0x00022AAE
	[global::Cpp2ILInjected.Token(Token = "0x600106F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA352E8", Offset = "0xA352E8", Length = "0x3E4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation), Member = "WriteMessageLength", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationHost), Member = "SendDataFunction", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public void RequestFile(string filename)
	{
		throw null;
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x000248B1 File Offset: 0x00022AB1
	[global::Cpp2ILInjected.Token(Token = "0x6001070")]
	[global::Cpp2ILInjected.Address(RVA = "0xA350B8", Offset = "0xA350B8", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation.SendDataFunction), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFile), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public void SendFile(string filename)
	{
		throw null;
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x000248B4 File Offset: 0x00022AB4
	[global::Cpp2ILInjected.Token(Token = "0x6001071")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46354", Offset = "0xA46354", Length = "0x5DC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = "GetNextMessage", MemberParameters = new object[] { typeof(ref Message) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = "GetClientAddress", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TcpAddress), Member = "IsLocalHost", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "AttemptHostConnection", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation.SendDataFunction), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = ".ctor", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.SendDataFunction) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "ProcessServerMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[]),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_ReceiveFile), Member = ".ctor", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.SendDataFunction) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationHost), Member = "SendFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x000248B7 File Offset: 0x00022AB7
	[global::Cpp2ILInjected.Token(Token = "0x6001072")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46A78", Offset = "0xA46A78", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Server), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveSynchronisationHost()
	{
		throw null;
	}

	// Token: 0x04001A15 RID: 6677
	[global::Cpp2ILInjected.Token(Token = "0x4001F50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Server Server;

	// Token: 0x04001A16 RID: 6678
	[global::Cpp2ILInjected.Token(Token = "0x4001F51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SaveSynchronisationOperation CurrentOperation;

	// Token: 0x04001A17 RID: 6679
	[global::Cpp2ILInjected.Token(Token = "0x4001F52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int connectedClient;
}
