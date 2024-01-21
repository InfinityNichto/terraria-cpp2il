using System.IO;
using System.Text;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CSVWriter
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public byte[] SaveData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private string _outputFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool _open;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private StreamWriter _writer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private MemoryStream _memoryStream;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1202A84", Offset = "0x1202A84", VA = "0x1202A84")]
	public CSVWriter(string file, string[] headers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1202C64", Offset = "0x1202C64", VA = "0x1202C64")]
	public CSVWriter(string file, string[] headers, UTF8Encoding enc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x1202D74", Offset = "0x1202D74", VA = "0x1202D74")]
	public CSVWriter(string[] headers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1202AEC", Offset = "0x1202AEC", VA = "0x1202AEC")]
	private void SetupStreams()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x1202CD4", Offset = "0x1202CD4", VA = "0x1202CD4")]
	private void SetupStreams(UTF8Encoding enc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1202DA4", Offset = "0x1202DA4", VA = "0x1202DA4")]
	private void CloseStreams()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x1202E28", Offset = "0x1202E28", VA = "0x1202E28", Slot = "1")]
	~CSVWriter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1202E88", Offset = "0x1202E88", VA = "0x1202E88")]
	private string EncodeValue(string stringValue)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1202B84", Offset = "0x1202B84", VA = "0x1202B84")]
	public void WriteLine(string[] values)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x1202F5C", Offset = "0x1202F5C", VA = "0x1202F5C")]
	public void Close()
	{
	}
}
