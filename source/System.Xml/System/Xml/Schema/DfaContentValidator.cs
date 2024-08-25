using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x20000D5")]
	internal sealed class DfaContentValidator : ContentValidator
	{
		[global::Cpp2ILInjected.Token(Token = "0x600086A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB7F6C", Offset = "0x1DB7F6C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal DfaContentValidator(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400043E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int[][] transitionTable;

		[global::Cpp2ILInjected.Token(Token = "0x400043F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SymbolsDictionary symbols;
	}
}
