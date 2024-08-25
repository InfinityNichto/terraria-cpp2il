using System;
using Cpp2ILInjected;

namespace Terraria.DataStructures
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000678")]
	public enum TileDataType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4007833")]
		Tile = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4007834")]
		TilePaint = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4007835")]
		Wall = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4007836")]
		WallPaint = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4007837")]
		Liquid = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4007838")]
		Wiring = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4007839")]
		Actuator = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400783A")]
		Slope = 128,
		[global::Cpp2ILInjected.Token(Token = "0x400783B")]
		All = 255
	}
}
