using System;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200047A")]
[Flags]
public enum TileDataType
{
	[Cpp2IlInjected.Token(Token = "0x400643B")]
	Tile = 1,
	[Cpp2IlInjected.Token(Token = "0x400643C")]
	TilePaint = 2,
	[Cpp2IlInjected.Token(Token = "0x400643D")]
	Wall = 4,
	[Cpp2IlInjected.Token(Token = "0x400643E")]
	WallPaint = 8,
	[Cpp2IlInjected.Token(Token = "0x400643F")]
	Liquid = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4006440")]
	Wiring = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4006441")]
	Actuator = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4006442")]
	Slope = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4006443")]
	All = 0xFF
}
