using System.Collections.Generic;
using System.Text;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CSVReader
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static StringBuilder builder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private byte[] _fileData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int _fileOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private string _filename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private List<string> _tokens;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public string[] Headers;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1202038", Offset = "0x1202038", VA = "0x1202038")]
	public static CSVReader Load(string file)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1202234", Offset = "0x1202234", VA = "0x1202234")]
	public static CSVReader LoadFromFile(string file)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x12022E4", Offset = "0x12022E4", VA = "0x12022E4")]
	public static CSVReader Load(byte[] fileData)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x12020A8", Offset = "0x12020A8", VA = "0x12020A8")]
	public CSVReader()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x120212C", Offset = "0x120212C", VA = "0x120212C")]
	public void Begin(string file)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x12022BC", Offset = "0x12022BC", VA = "0x12022BC")]
	public void Begin(byte[] fileData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x12024CC", Offset = "0x12024CC", VA = "0x12024CC", Slot = "1")]
	~CSVReader()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x12024D4", Offset = "0x12024D4", VA = "0x12024D4")]
	public string GetRawLine()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1202360", Offset = "0x1202360", VA = "0x1202360")]
	public string[] ReadLine()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1202610", Offset = "0x1202610", VA = "0x1202610")]
	private string[] DecodeLine(string line)
	{
		return null;
	}
}
