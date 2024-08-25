using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005D7")]
	public static class LiquidID
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600355C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C25F4", Offset = "0x13C25F4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static LiquidID()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4006406")]
		public const short Water = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4006407")]
		public const short Lava = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4006408")]
		public const short Honey = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4006409")]
		public const short Shimmer = 3;

		[global::Cpp2ILInjected.Token(Token = "0x400640A")]
		public static readonly short Count;
	}
}
