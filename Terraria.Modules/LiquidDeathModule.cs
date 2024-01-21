using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003AC")]
public class LiquidDeathModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003242")]
	public bool water;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4003243")]
	public bool lava;

	[Cpp2IlInjected.Token(Token = "0x6002EC4")]
	[Cpp2IlInjected.Address(RVA = "0xFDCA04", Offset = "0xFDCA04", VA = "0xFDCA04")]
	public LiquidDeathModule([Optional] LiquidDeathModule copyFrom)
	{
	}
}
