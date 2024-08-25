using System;
using Cpp2ILInjected;

namespace Terraria.Enums
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200060B")]
	public enum AnchorType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40074D3")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40074D4")]
		SolidTile = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40074D5")]
		SolidWithTop = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40074D6")]
		Table = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40074D7")]
		SolidSide = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40074D8")]
		Tree = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40074D9")]
		AlternateTile = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40074DA")]
		EmptyTile = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40074DB")]
		SolidBottom = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40074DC")]
		Platform = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40074DD")]
		PlanterBox = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40074DE")]
		PlatformNonHammered = 1024
	}
}
