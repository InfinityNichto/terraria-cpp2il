using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

[global::Cpp2ILInjected.Token(Token = "0x20002C9")]
public class SaveSynchronisationOperation
{
	[global::Cpp2ILInjected.Token(Token = "0x600107E")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46AD8", Offset = "0xA46AD8", Length = "0x28")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SaveSynchronisationOperation_SendFileList), Member = ".ctor", MemberParameters = new object[] { typeof(SaveSynchronisationOperation.SendDataFunction) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SaveSynchronisationOperation(SaveSynchronisationOperation.SendDataFunction sendOperation)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600107F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46B00", Offset = "0xA46B00", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Begin()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x6001083")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46BB4", Offset = "0xA46BB4", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void ProcessMessage(SaveSynchronisationOperation.MessageId messageId, byte[] data)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001084")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46BB8", Offset = "0xA46BB8", Length = "0x4")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	public virtual void Cancel()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6001085")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46BBC", Offset = "0xA46BBC", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public virtual string GetStatus()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6001086")]
	[global::Cpp2ILInjected.Address(RVA = "0xA46C04", Offset = "0xA46C04", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	static SaveSynchronisationOperation()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001F60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	protected readonly SaveSynchronisationOperation.SendDataFunction SendData;

	[global::Cpp2ILInjected.Token(Token = "0x4001F61")]
	private static byte[] emptyMessageData;

	[global::Cpp2ILInjected.Token(Token = "0x4001F62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool IsComplete;

	[global::Cpp2ILInjected.Token(Token = "0x20002CA")]
	public enum MessageId
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001F64")]
		BeginFileList,
		[global::Cpp2ILInjected.Token(Token = "0x4001F65")]
		PlayerFileEntry,
		[global::Cpp2ILInjected.Token(Token = "0x4001F66")]
		WorldFileEntry,
		[global::Cpp2ILInjected.Token(Token = "0x4001F67")]
		FileEntryReceived,
		[global::Cpp2ILInjected.Token(Token = "0x4001F68")]
		EndFileList,
		[global::Cpp2ILInjected.Token(Token = "0x4001F69")]
		RequestFileData,
		[global::Cpp2ILInjected.Token(Token = "0x4001F6A")]
		BeginFileData,
		[global::Cpp2ILInjected.Token(Token = "0x4001F6B")]
		FileData,
		[global::Cpp2ILInjected.Token(Token = "0x4001F6C")]
		FileDataRecieved
	}

	[global::Cpp2ILInjected.Token(Token = "0x20002CB")]
	public delegate void SendDataFunction(byte[] messageData, int length);
}
