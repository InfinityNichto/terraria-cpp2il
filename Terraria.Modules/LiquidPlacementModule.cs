using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.Enums;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003AD")]
public class LiquidPlacementModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003244")]
	public LiquidPlacement water;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003245")]
	public LiquidPlacement lava;

	[Cpp2IlInjected.Token(Token = "0x6002EC5")]
	[Cpp2IlInjected.Address(RVA = "0xFDCA44", Offset = "0xFDCA44", VA = "0xFDCA44")]
	public LiquidPlacementModule([Optional] LiquidPlacementModule copyFrom)
	{
	}
}
