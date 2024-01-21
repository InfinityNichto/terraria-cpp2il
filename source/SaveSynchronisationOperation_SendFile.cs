using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000222")]
public class SaveSynchronisationOperation_SendFile : SaveSynchronisationOperation
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001A31")]
	private string filename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001A32")]
	private byte[] fileDataToSend;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001A33")]
	private int sendOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001A34")]
	private int pendingChunks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001A35")]
	private int mapFilesOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001A36")]
	private string[] mapFiles;

	[Cpp2IlInjected.Token(Token = "0x4001A37")]
	private static byte[] fileDataBuffer;

	[Cpp2IlInjected.Token(Token = "0x6000F6F")]
	[Cpp2IlInjected.Address(RVA = "0xF9D52C", Offset = "0xF9D52C", VA = "0xF9D52C")]
	public SaveSynchronisationOperation_SendFile(string filenameToSend, SendDataFunction sendOperation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F70")]
	[Cpp2IlInjected.Address(RVA = "0xFA17D0", Offset = "0xFA17D0", VA = "0xFA17D0", Slot = "4")]
	public override void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F71")]
	[Cpp2IlInjected.Address(RVA = "0xFA1CA8", Offset = "0xFA1CA8", VA = "0xFA1CA8", Slot = "5")]
	public override void ProcessMessage(MessageId messageId, byte[] data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F72")]
	[Cpp2IlInjected.Address(RVA = "0xFA1B4C", Offset = "0xFA1B4C", VA = "0xFA1B4C")]
	private void SendNextChunk()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F73")]
	[Cpp2IlInjected.Address(RVA = "0xFA1E0C", Offset = "0xFA1E0C", VA = "0xFA1E0C", Slot = "7")]
	public override string GetStatus()
	{
		return null;
	}
}
