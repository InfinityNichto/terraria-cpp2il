using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Terraria.GameContent.Biomes;

namespace Terraria.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x20004FA")]
	public struct IntRange
	{
		[global::Cpp2ILInjected.Token(Token = "0x60030E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x130167C", Offset = "0x130167C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeadMansChestBiome), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public IntRange(int minimum, int maximum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1301684", Offset = "0x1301684", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator *(IntRange range, float scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13016CC", Offset = "0x13016CC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator *(float scale, IntRange range)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1301714", Offset = "0x1301714", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator /(IntRange range, float scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x130175C", Offset = "0x130175C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static IntRange operator /(float scale, IntRange range)
		{
			throw null;
		}

		[JsonProperty("Min")]
		[global::Cpp2ILInjected.Token(Token = "0x4003ACD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly int Minimum;

		[JsonProperty("Max")]
		[global::Cpp2ILInjected.Token(Token = "0x4003ACE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly int Maximum;
	}
}
