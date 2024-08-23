using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;

namespace Terraria.Utilities.Terraria.Utilities
{
	// Token: 0x0200037C RID: 892
	[global::Cpp2ILInjected.Token(Token = "0x200050A")]
	public struct FloatRange
	{
		// Token: 0x06002CFD RID: 11517 RVA: 0x0002A11C File Offset: 0x0002831C
		[global::Cpp2ILInjected.Token(Token = "0x6003132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303794", Offset = "0x1303794", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public FloatRange(float minimum, float maximum)
		{
			throw null;
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x0002A11F File Offset: 0x0002831F
		[global::Cpp2ILInjected.Token(Token = "0x6003133")]
		[global::Cpp2ILInjected.Address(RVA = "0x130379C", Offset = "0x130379C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator *(FloatRange range, float scale)
		{
			throw null;
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x0002A122 File Offset: 0x00028322
		[global::Cpp2ILInjected.Token(Token = "0x6003134")]
		[global::Cpp2ILInjected.Address(RVA = "0x13037A8", Offset = "0x13037A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator *(float scale, FloatRange range)
		{
			throw null;
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0002A125 File Offset: 0x00028325
		[global::Cpp2ILInjected.Token(Token = "0x6003135")]
		[global::Cpp2ILInjected.Address(RVA = "0x13037B8", Offset = "0x13037B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator /(FloatRange range, float scale)
		{
			throw null;
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x0002A128 File Offset: 0x00028328
		[global::Cpp2ILInjected.Token(Token = "0x6003136")]
		[global::Cpp2ILInjected.Address(RVA = "0x13037C4", Offset = "0x13037C4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static FloatRange operator /(float scale, FloatRange range)
		{
			throw null;
		}

		// Token: 0x040031A2 RID: 12706
		[JsonProperty("Min")]
		[global::Cpp2ILInjected.Token(Token = "0x4003AFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float Minimum;

		// Token: 0x040031A3 RID: 12707
		[JsonProperty("Max")]
		[global::Cpp2ILInjected.Token(Token = "0x4003AFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float Maximum;
	}
}
