using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000221")]
public class SaveSynchronisationOperation_ReceiveFile : SaveSynchronisationOperation
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001A2D")]
	private string filename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001A2E")]
	private int fileOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001A2F")]
	private int fileLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001A30")]
	private byte[] fileData;

	[Cpp2IlInjected.Token(Token = "0x6000F6A")]
	[Cpp2IlInjected.Address(RVA = "0xF9DF38", Offset = "0xF9DF38", VA = "0xF9DF38")]
	public SaveSynchronisationOperation_ReceiveFile(SendDataFunction sendOperation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F6B")]
	[Cpp2IlInjected.Address(RVA = "0xFA0DD4", Offset = "0xFA0DD4", VA = "0xFA0DD4", Slot = "4")]
	public override void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F6C")]
	[Cpp2IlInjected.Address(RVA = "0xFA0DD8", Offset = "0xFA0DD8", VA = "0xFA0DD8", Slot = "5")]
	public override void ProcessMessage(MessageId messageId, byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F6D")]
	[Cpp2IlInjected.Address(RVA = "0xFA14C8", Offset = "0xFA14C8", VA = "0xFA14C8")]
	private void WriteFile()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F6E")]
	[Cpp2IlInjected.Address(RVA = "0xFA1728", Offset = "0xFA1728", VA = "0xFA1728", Slot = "7")]
	public override string GetStatus()
	{
		return null;
	}
}
