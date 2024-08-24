using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

// Token: 0x0200021F RID: 543
[global::Cpp2ILInjected.Token(Token = "0x20002C9")]
public class SaveSynchronisationOperation
{
	// Token: 0x06000F4A RID: 3914 RVA: 0x000248DB File Offset: 0x00022ADB
	[global::Cpp2ILInjected.Token(Token = "0x600107E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46AD8", Offset = "0xA46AD8", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = ".ctor", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.SendDataFunction) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SaveSynchronisationOperation(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		throw null;
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x000248DE File Offset: 0x00022ADE
	[global::Cpp2ILInjected.Token(Token = "0x600107F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46B00", Offset = "0xA46B00", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Begin()
	{
		throw null;
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x000248E1 File Offset: 0x00022AE1
	[global::Cpp2ILInjected.Token(Token = "0x6001080")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46B04", Offset = "0xA46B04", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_ReceiveFile), Member = "ProcessMessage", MemberParameters = new object[]
	{
		typeof(SaveSynchronisationOperation.MessageId),
		typeof(byte[])
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "Begin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendNextFile", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public void SendEmptyMessage(SaveSynchronisationOperation.MessageId id)
	{
		throw null;
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x000248E4 File Offset: 0x00022AE4
	[global::Cpp2ILInjected.Token(Token = "0x6001081")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44A6C", Offset = "0xA44A6C", Length = "0x40")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendPlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendWorldFile", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void WriteMessageHeader(BinaryWriter packet, SaveSynchronisationOperation.MessageId id)
	{
		throw null;
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x000248E7 File Offset: 0x00022AE7
	[global::Cpp2ILInjected.Token(Token = "0x6001082")]
	[global::Cpp2ILInjected.Address(RVA = "0xA44AAC", Offset = "0xA44AAC", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationClient), Member = "RequestFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationHost), Member = "RequestFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFile), Member = "Begin", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendPlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = "SendWorldFile", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void WriteMessageLength(BinaryWriter packet)
	{
		throw null;
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x000248EA File Offset: 0x00022AEA
	[global::Cpp2ILInjected.Token(Token = "0x6001083")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46BB4", Offset = "0xA46BB4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		throw null;
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x000248ED File Offset: 0x00022AED
	[global::Cpp2ILInjected.Token(Token = "0x6001084")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46BB8", Offset = "0xA46BB8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Cancel()
	{
		throw null;
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x000248F0 File Offset: 0x00022AF0
	[global::Cpp2ILInjected.Token(Token = "0x6001085")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46BBC", Offset = "0xA46BBC", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public virtual string GetStatus()
	{
		throw null;
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x000248F3 File Offset: 0x00022AF3
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6001086")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46C04", Offset = "0xA46C04", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static SaveSynchronisationOperation()
	{
		throw null;
	}

	// Token: 0x04001A21 RID: 6689
	[global::Cpp2ILInjected.Token(Token = "0x4001F60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	protected readonly SaveSynchronisationOperation.SendDataFunction SendData;

	// Token: 0x04001A22 RID: 6690
	[global::Cpp2ILInjected.Token(Token = "0x4001F61")]
	private static byte[] emptyMessageData;

	// Token: 0x04001A23 RID: 6691
	[global::Cpp2ILInjected.Token(Token = "0x4001F62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool IsComplete;

	// Token: 0x0200080B RID: 2059
	[global::Cpp2ILInjected.Token(Token = "0x20002CA")]
	public enum MessageId
	{
		// Token: 0x04007D0A RID: 32010
		[global::Cpp2ILInjected.Token(Token = "0x4001F64")]
		BeginFileList,
		// Token: 0x04007D0B RID: 32011
		[global::Cpp2ILInjected.Token(Token = "0x4001F65")]
		PlayerFileEntry,
		// Token: 0x04007D0C RID: 32012
		[global::Cpp2ILInjected.Token(Token = "0x4001F66")]
		WorldFileEntry,
		// Token: 0x04007D0D RID: 32013
		[global::Cpp2ILInjected.Token(Token = "0x4001F67")]
		FileEntryReceived,
		// Token: 0x04007D0E RID: 32014
		[global::Cpp2ILInjected.Token(Token = "0x4001F68")]
		EndFileList,
		// Token: 0x04007D0F RID: 32015
		[global::Cpp2ILInjected.Token(Token = "0x4001F69")]
		RequestFileData,
		// Token: 0x04007D10 RID: 32016
		[global::Cpp2ILInjected.Token(Token = "0x4001F6A")]
		BeginFileData,
		// Token: 0x04007D11 RID: 32017
		[global::Cpp2ILInjected.Token(Token = "0x4001F6B")]
		FileData,
		// Token: 0x04007D12 RID: 32018
		[global::Cpp2ILInjected.Token(Token = "0x4001F6C")]
		FileDataRecieved
	}

	// Token: 0x0200080C RID: 2060
	// (Invoke) Token: 0x06004908 RID: 18696
	[global::Cpp2ILInjected.Token(Token = "0x20002CB")]
	public delegate void SendDataFunction(byte[] messageData, int length);
}
