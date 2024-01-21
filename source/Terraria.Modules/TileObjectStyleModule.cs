using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003B2")]
public class TileObjectStyleModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400325B")]
	public int style;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400325C")]
	public bool horizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400325D")]
	public int styleWrapLimit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400325E")]
	public int styleMultiplier;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400325F")]
	public int styleLineSkip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4003260")]
	public int? styleWrapLimitVisualOverride;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4003261")]
	public int? styleLineSkipVisualoverride;

	[Cpp2IlInjected.Token(Token = "0x6002ECA")]
	[Cpp2IlInjected.Address(RVA = "0xFDCEB4", Offset = "0xFDCEB4", VA = "0xFDCEB4")]
	public TileObjectStyleModule([Optional] TileObjectStyleModule copyFrom)
	{
	}
}
