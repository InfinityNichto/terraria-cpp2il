using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000348")]
public class Sign
{
	[Cpp2IlInjected.Token(Token = "0x4002F52")]
	public const int maxSigns = 1000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002F53")]
	public int x;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002F54")]
	public int y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002F55")]
	public string text;

	[Cpp2IlInjected.Token(Token = "0x60027AB")]
	[Cpp2IlInjected.Address(RVA = "0x14DEE40", Offset = "0x14DEE40", VA = "0x14DEE40")]
	public static void KillSign(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027AC")]
	[Cpp2IlInjected.Address(RVA = "0x14DEF90", Offset = "0x14DEF90", VA = "0x14DEF90")]
	public static int ReadSign(int i, int j, bool CreateIfMissing = true)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60027AD")]
	[Cpp2IlInjected.Address(RVA = "0x14DF384", Offset = "0x14DF384", VA = "0x14DF384")]
	public static void TextSign(int i, string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60027AE")]
	[Cpp2IlInjected.Address(RVA = "0x14DF568", Offset = "0x14DF568", VA = "0x14DF568", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60027AF")]
	[Cpp2IlInjected.Address(RVA = "0x14DF37C", Offset = "0x14DF37C", VA = "0x14DF37C")]
	public Sign()
	{
	}
}
