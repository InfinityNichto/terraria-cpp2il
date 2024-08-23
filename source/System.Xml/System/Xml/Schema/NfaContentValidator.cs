using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000AB RID: 171
	[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
	internal sealed class NfaContentValidator : ContentValidator
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x000045EF File Offset: 0x000027EF
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

		// Token: 0x040002C9 RID: 713
		[global::Cpp2ILInjected.Token(Token = "0x4000440")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BitSet firstpos;

		// Token: 0x040002CA RID: 714
		[global::Cpp2ILInjected.Token(Token = "0x4000441")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private BitSet[] followpos;

		// Token: 0x040002CB RID: 715
		[global::Cpp2ILInjected.Token(Token = "0x4000442")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SymbolsDictionary symbols;

		// Token: 0x040002CC RID: 716
		[global::Cpp2ILInjected.Token(Token = "0x4000443")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Positions positions;

		// Token: 0x040002CD RID: 717
		[global::Cpp2ILInjected.Token(Token = "0x4000444")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int endMarkerPos;
	}
}
