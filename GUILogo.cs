using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001CA")]
public class GUILogo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001457")]
	private int LogoA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001458")]
	private int LogoB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001459")]
	private bool LogoT;

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0xDF0DC8", Offset = "0xDF0DC8", VA = "0xDF0DC8")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0xDF2144", Offset = "0xDF2144", VA = "0xDF2144")]
	public GUILogo()
	{
	}
}
