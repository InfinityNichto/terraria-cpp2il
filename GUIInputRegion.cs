using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200010B")]
public class GUIInputRegion
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000857")]
	public int xMin;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000858")]
	public int xMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000859")]
	public int yMin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400085A")]
	public int yMax;

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0xDDDFEC", Offset = "0xDDDFEC", VA = "0xDDDFEC")]
	public void Set(int x0, int x1, int y0, int y1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0xDDDFFC", Offset = "0xDDDFFC", VA = "0xDDDFFC")]
	public bool Over(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0xDDE03C", Offset = "0xDDE03C", VA = "0xDDE03C")]
	public bool OverExpanded(int x, int y, float expanded)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0xDDE0E8", Offset = "0xDDE0E8", VA = "0xDDE0E8")]
	public GUIInputRegion()
	{
	}
}
