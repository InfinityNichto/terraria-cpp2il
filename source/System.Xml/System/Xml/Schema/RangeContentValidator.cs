using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
	internal sealed class RangeContentValidator : ContentValidator
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000445")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BitSet firstpos;

		[global::Cpp2ILInjected.Token(Token = "0x4000446")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BitSet[] followpos;

		[global::Cpp2ILInjected.Token(Token = "0x4000447")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private BitSet positionsWithRangeTerminals;

		[global::Cpp2ILInjected.Token(Token = "0x4000448")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private SymbolsDictionary symbols;

		[global::Cpp2ILInjected.Token(Token = "0x4000449")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Positions positions;

		[global::Cpp2ILInjected.Token(Token = "0x400044A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int minMaxNodesCount;

		[global::Cpp2ILInjected.Token(Token = "0x400044B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int endMarkerPos;
	}
}
