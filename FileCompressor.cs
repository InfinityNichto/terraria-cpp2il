using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class FileCompressor
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public static bool Disable;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x20D2A2C", Offset = "0x20D2A2C", VA = "0x20D2A2C")]
	private static bool CanCompress(string filename)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x20D2B08", Offset = "0x20D2B08", VA = "0x20D2B08")]
	private static bool HasCompressionHeader(byte[] inputData, out int decompressedLength)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x20D2C10", Offset = "0x20D2C10", VA = "0x20D2C10")]
	private static byte[] Decompress(byte[] inputData, int outputSize)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x20D2DF8", Offset = "0x20D2DF8", VA = "0x20D2DF8")]
	private static byte[] Compress(byte[] inputData, int fileLength)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x20D2F84", Offset = "0x20D2F84", VA = "0x20D2F84")]
	public static byte[] CompressFile(string filename, byte[] inputFile, ref int fileLength)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x20D30B0", Offset = "0x20D30B0", VA = "0x20D30B0")]
	public static byte[] DecompressFile(string filename, byte[] inputFile)
	{
		return null;
	}
}
