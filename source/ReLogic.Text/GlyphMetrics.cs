using Cpp2IlInjected;

namespace ReLogic.Text;

[Cpp2IlInjected.Token(Token = "0x200071D")]
public struct GlyphMetrics
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4007168")]
	public readonly float LeftPadding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4007169")]
	public readonly float CharacterWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400716A")]
	public readonly float RightPadding;

	[Cpp2IlInjected.Token(Token = "0x170007F1")]
	public float KernedWidth
	{
		[Cpp2IlInjected.Token(Token = "0x60046AF")]
		[Cpp2IlInjected.Address(RVA = "0x39A794", Offset = "0x39A794", VA = "0x39A794")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007F2")]
	public float KernedWidthOnNewLine
	{
		[Cpp2IlInjected.Token(Token = "0x60046B0")]
		[Cpp2IlInjected.Address(RVA = "0x39A7B0", Offset = "0x39A7B0", VA = "0x39A7B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60046B1")]
	[Cpp2IlInjected.Address(RVA = "0x39A7B8", Offset = "0x39A7B8", VA = "0x39A7B8")]
	private GlyphMetrics(float leftPadding, float characterWidth, float rightPadding)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046B2")]
	[Cpp2IlInjected.Address(RVA = "0xF93A64", Offset = "0xF93A64", VA = "0xF93A64")]
	public static GlyphMetrics FromKerningData(float leftPadding, float characterWidth, float rightPadding)
	{
		return default(GlyphMetrics);
	}
}
