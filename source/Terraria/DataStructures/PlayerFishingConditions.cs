using System;
using Cpp2ILInjected;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000645")]
	public struct PlayerFishingConditions
	{
		[global::Cpp2ILInjected.Token(Token = "0x40077C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int PolePower;

		[global::Cpp2ILInjected.Token(Token = "0x40077C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int PoleItemType;

		[global::Cpp2ILInjected.Token(Token = "0x40077C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int BaitPower;

		[global::Cpp2ILInjected.Token(Token = "0x40077C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int BaitItemType;

		[global::Cpp2ILInjected.Token(Token = "0x40077C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float LevelMultipliers;

		[global::Cpp2ILInjected.Token(Token = "0x40077C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int FinalFishingLevel;
	}
}
