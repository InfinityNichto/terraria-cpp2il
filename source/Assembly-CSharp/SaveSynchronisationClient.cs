using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Telepathy;
using Terraria;
using UnityEngine;

// Token: 0x0200021B RID: 539
[global::Cpp2ILInjected.Token(Token = "0x20002C3")]
public class SaveSynchronisationClient
{
	// Token: 0x06000F2C RID: 3884 RVA: 0x00024881 File Offset: 0x00022A81
	[global::Cpp2ILInjected.Token(Token = "0x600105F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44910", Offset = "0xA44910", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Connect", MemberParameters = new object[]
	{
		typeof(string),
		typeof(int)
	}, ReturnType = typeof(void))]
	public void Connect(string hostName)
	{
		throw null;
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00024884 File Offset: 0x00022A84
	[global::Cpp2ILInjected.Token(Token = "0x6001060")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44920", Offset = "0xA44920", Length = "0xC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
	public void Close()
	{
		throw null;
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00024887 File Offset: 0x00022A87
	[global::Cpp2ILInjected.Token(Token = "0x6001061")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4492C", Offset = "0xA4492C", Length = "0x140")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "RequestFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToUInt16", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(ushort))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = "Send", MemberParameters = new object[]
	{
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

	// Token: 0x06000F2F RID: 3887 RVA: 0x0002488A File Offset: 0x00022A8A
	[global::Cpp2ILInjected.Token(Token = "0x6001062")]
	[global::Cpp2ILInjected.Address(RVA = "0xA356CC", Offset = "0xA356CC", Length = "0x3E4")]
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
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationClient), Member = "SendDataFunction", MemberParameters = new object[]
	{
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
	public void RequestFile(string filename)
	{
		throw null;
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x0002488D File Offset: 0x00022A8D
	[global::Cpp2ILInjected.Token(Token = "0x6001063")]
	[global::Cpp2ILInjected.Address(RVA = "0xA351D0", Offset = "0xA351D0", Length = "0x118")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation_FileList), Member = "DrawCategories", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "Update", ReturnType = typeof(void))]
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

	// Token: 0x06000F31 RID: 3889 RVA: 0x00024890 File Offset: 0x00022A90
	[global::Cpp2ILInjected.Token(Token = "0x6001064")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44EE4", Offset = "0xA44EE4", Length = "0x584")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISaveSynchronisation), Member = "Draw", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = "Update", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Common), Member = "GetNextMessage", MemberParameters = new object[] { typeof(ref Message) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "AttemptClientConnection", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation.SendDataFunction), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = ".ctor", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.SendDataFunction) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationState), Member = "ProcessMessageResponse", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(SaveSynchronisationOperation.SendDataFunction)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Shutdown", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationManager), Member = "Startup", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationOperation_ReceiveFile), Member = ".ctor", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.SendDataFunction) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveSynchronisationClient), Member = "SendFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00024893 File Offset: 0x00022A93
	[global::Cpp2ILInjected.Token(Token = "0x6001065")]
	[global::Cpp2ILInjected.Address(RVA = "0xA455FC", Offset = "0xA455FC", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Client), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SaveSynchronisationClient()
	{
		throw null;
	}

	// Token: 0x04001A0D RID: 6669
	[global::Cpp2ILInjected.Token(Token = "0x4001F42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Client Client;

	// Token: 0x04001A0E RID: 6670
	[global::Cpp2ILInjected.Token(Token = "0x4001F43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public SaveSynchronisationOperation CurrentOperation;
}
