using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;

namespace Terraria.Utilities.Terraria.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x200050A")]
	public struct FloatRange
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303794", Offset = "0x1303794", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public FloatRange(float minimum, float maximum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003133")]
		[global::Cpp2ILInjected.Address(RVA = "0x130379C", Offset = "0x130379C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator *(FloatRange range, float scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003134")]
		[global::Cpp2ILInjected.Address(RVA = "0x13037A8", Offset = "0x13037A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator *(float scale, FloatRange range)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003135")]
		[global::Cpp2ILInjected.Address(RVA = "0x13037B8", Offset = "0x13037B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator /(FloatRange range, float scale)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003136")]
		[global::Cpp2ILInjected.Address(RVA = "0x13037C4", Offset = "0x13037C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator /(float scale, FloatRange range)
		{
			throw null;
		}

		[JsonProperty("Min")]
		[global::Cpp2ILInjected.Token(Token = "0x4003AFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float Minimum;

		[JsonProperty("Max")]
		[global::Cpp2ILInjected.Token(Token = "0x4003AFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float Maximum;
	}
}
