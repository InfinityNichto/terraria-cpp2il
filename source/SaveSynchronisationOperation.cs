using System.IO;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000220")]
public class SaveSynchronisationOperation
{
	[Cpp2IlInjected.Token(Token = "0x2000802")]
	public enum MessageId
	{
		[Cpp2IlInjected.Token(Token = "0x4007CF7")]
		BeginFileList,
		[Cpp2IlInjected.Token(Token = "0x4007CF8")]
		PlayerFileEntry,
		[Cpp2IlInjected.Token(Token = "0x4007CF9")]
		WorldFileEntry,
		[Cpp2IlInjected.Token(Token = "0x4007CFA")]
		FileEntryReceived,
		[Cpp2IlInjected.Token(Token = "0x4007CFB")]
		EndFileList,
		[Cpp2IlInjected.Token(Token = "0x4007CFC")]
		RequestFileData,
		[Cpp2IlInjected.Token(Token = "0x4007CFD")]
		BeginFileData,
		[Cpp2IlInjected.Token(Token = "0x4007CFE")]
		FileData,
		[Cpp2IlInjected.Token(Token = "0x4007CFF")]
		FileDataRecieved
	}

	[Cpp2IlInjected.Token(Token = "0x2000803")]
	public delegate void SendDataFunction(byte[] messageData, int length);

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001A2A")]
	protected readonly SendDataFunction SendData;

	[Cpp2IlInjected.Token(Token = "0x4001A2B")]
	private static byte[] emptyMessageData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001A2C")]
	public bool IsComplete;

	[Cpp2IlInjected.Token(Token = "0x6000F61")]
	[Cpp2IlInjected.Address(RVA = "0xFA06B0", Offset = "0xFA06B0", VA = "0xFA06B0")]
	public SaveSynchronisationOperation(SendDataFunction sendOperation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F62")]
	[Cpp2IlInjected.Address(RVA = "0xFA06D0", Offset = "0xFA06D0", VA = "0xFA06D0", Slot = "4")]
	public virtual void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F63")]
	[Cpp2IlInjected.Address(RVA = "0xFA06D4", Offset = "0xFA06D4", VA = "0xFA06D4")]
	public void SendEmptyMessage(MessageId id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F64")]
	[Cpp2IlInjected.Address(RVA = "0xF9D318", Offset = "0xF9D318", VA = "0xF9D318")]
	public static void WriteMessageHeader(BinaryWriter packet, MessageId id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F65")]
	[Cpp2IlInjected.Address(RVA = "0xF9D35C", Offset = "0xF9D35C", VA = "0xF9D35C")]
	public static void WriteMessageLength(BinaryWriter packet)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F66")]
	[Cpp2IlInjected.Address(RVA = "0xFA0C60", Offset = "0xFA0C60", VA = "0xFA0C60", Slot = "5")]
	public virtual void ProcessMessage(MessageId messageId, byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F67")]
	[Cpp2IlInjected.Address(RVA = "0xFA0C64", Offset = "0xFA0C64", VA = "0xFA0C64", Slot = "6")]
	public virtual void Cancel()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F68")]
	[Cpp2IlInjected.Address(RVA = "0xFA0C68", Offset = "0xFA0C68", VA = "0xFA0C68", Slot = "7")]
	public virtual string GetStatus()
	{
		return null;
	}
}
