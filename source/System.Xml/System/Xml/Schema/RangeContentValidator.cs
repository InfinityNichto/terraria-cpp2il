using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000AC RID: 172
	[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
	internal sealed class RangeContentValidator : ContentValidator
	{
		// Token: 0x060007DD RID: 2013 RVA: 0x000045F2 File Offset: 0x000027F2
		[global::Cpp2ILInjected.Token(Token = "0x600086C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB78E0", Offset = "0x1DB78E0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RangeContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount)
		{
			throw null;
		}

		// Token: 0x040002CE RID: 718
		[global::Cpp2ILInjected.Token(Token = "0x4000445")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BitSet firstpos;

		// Token: 0x040002CF RID: 719
		[global::Cpp2ILInjected.Token(Token = "0x4000446")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BitSet[] followpos;

		// Token: 0x040002D0 RID: 720
		[global::Cpp2ILInjected.Token(Token = "0x4000447")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private BitSet positionsWithRangeTerminals;

		// Token: 0x040002D1 RID: 721
		[global::Cpp2ILInjected.Token(Token = "0x4000448")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SymbolsDictionary symbols;

		// Token: 0x040002D2 RID: 722
		[global::Cpp2ILInjected.Token(Token = "0x4000449")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Positions positions;

		// Token: 0x040002D3 RID: 723
		[global::Cpp2ILInjected.Token(Token = "0x400044A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int minMaxNodesCount;

		// Token: 0x040002D4 RID: 724
		[global::Cpp2ILInjected.Token(Token = "0x400044B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int endMarkerPos;
	}
}
