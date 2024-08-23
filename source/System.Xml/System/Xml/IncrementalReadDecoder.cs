using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000021 RID: 33
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	internal abstract class IncrementalReadDecoder
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		internal abstract bool IsFull
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			get;
		}

		// Token: 0x060000B2 RID: 178
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		internal abstract int Decode(char[] chars, int startPos, int len);

		// Token: 0x060000B3 RID: 179 RVA: 0x0000316A File Offset: 0x0000136A
		[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62084", Offset = "0x1D62084", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected IncrementalReadDecoder()
		{
			throw null;
		}
	}
}
