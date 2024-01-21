using System;
using Cpp2IlInjected;

namespace Terraria.Enums;

[Cpp2IlInjected.Token(Token = "0x2000413")]
[Flags]
public enum AnchorType
{
	[Cpp2IlInjected.Token(Token = "0x40060EA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40060EB")]
	SolidTile = 1,
	[Cpp2IlInjected.Token(Token = "0x40060EC")]
	SolidWithTop = 2,
	[Cpp2IlInjected.Token(Token = "0x40060ED")]
	Table = 4,
	[Cpp2IlInjected.Token(Token = "0x40060EE")]
	SolidSide = 8,
	[Cpp2IlInjected.Token(Token = "0x40060EF")]
	Tree = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40060F0")]
	AlternateTile = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40060F1")]
	EmptyTile = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40060F2")]
	SolidBottom = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40060F3")]
	Platform = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40060F4")]
	PlanterBox = 0x200,
	[Cpp2IlInjected.Token(Token = "0x40060F5")]
	PlatformNonHammered = 0x400
}
