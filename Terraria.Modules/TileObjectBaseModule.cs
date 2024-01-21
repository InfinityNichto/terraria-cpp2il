using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.DataStructures;
using Terraria.Enums;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003AF")]
public class TileObjectBaseModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003247")]
	public int width;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003248")]
	public int height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003249")]
	public Point16 origin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400324A")]
	public TileObjectDirection direction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400324B")]
	public int randomRange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400324C")]
	public bool flattenAnchors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400324D")]
	public int[] specificRandomStyles;

	[Cpp2IlInjected.Token(Token = "0x6002EC7")]
	[Cpp2IlInjected.Address(RVA = "0xFDCBD4", Offset = "0xFDCBD4", VA = "0xFDCBD4")]
	public TileObjectBaseModule([Optional] TileObjectBaseModule copyFrom)
	{
	}
}
