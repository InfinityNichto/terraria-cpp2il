using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
	internal sealed class NfaContentValidator : ContentValidator
	{
		[global::Cpp2ILInjected.Token(Token = "0x600086B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB800C", Offset = "0x1DB800C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal NfaContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000440")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BitSet firstpos;

		[global::Cpp2ILInjected.Token(Token = "0x4000441")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BitSet[] followpos;

		[global::Cpp2ILInjected.Token(Token = "0x4000442")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SymbolsDictionary symbols;

		[global::Cpp2ILInjected.Token(Token = "0x4000443")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Positions positions;

		[global::Cpp2ILInjected.Token(Token = "0x4000444")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int endMarkerPos;
	}
}
