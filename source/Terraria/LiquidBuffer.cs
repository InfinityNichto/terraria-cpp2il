using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200031A")]
public class LiquidBuffer
{
	[Cpp2IlInjected.Token(Token = "0x4002279")]
	public static int numLiquidBuffer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400227A")]
	public int x;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400227B")]
	public int y;

	[Cpp2IlInjected.Token(Token = "0x6001A5F")]
	[Cpp2IlInjected.Address(RVA = "0x4745A0", Offset = "0x4745A0", VA = "0x4745A0")]
	public static void AddBuffer(int x, int y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A60")]
	[Cpp2IlInjected.Address(RVA = "0x47471C", Offset = "0x47471C", VA = "0x47471C")]
	public static void DelBuffer(int l)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001A61")]
	[Cpp2IlInjected.Address(RVA = "0x4747FC", Offset = "0x4747FC", VA = "0x4747FC")]
	public LiquidBuffer()
	{
	}
}
