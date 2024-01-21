using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003B0")]
public class TileObjectCoordinatesModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400324E")]
	public int width;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400324F")]
	public int[] heights;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003250")]
	public int padding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4003251")]
	public Point16 paddingFix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4003252")]
	public int styleWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4003253")]
	public int styleHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4003254")]
	public bool calculated;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4003255")]
	public int drawStyleOffset;

	[Cpp2IlInjected.Token(Token = "0x6002EC8")]
	[Cpp2IlInjected.Address(RVA = "0xFDCD08", Offset = "0xFDCD08", VA = "0xFDCD08")]
	public TileObjectCoordinatesModule([Optional] TileObjectCoordinatesModule copyFrom, [Optional] int[] drawHeight)
	{
	}
}
