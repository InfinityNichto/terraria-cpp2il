using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000022 RID: 34
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	internal class IncrementalReadDummyDecoder : IncrementalReadDecoder
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000316D File Offset: 0x0000136D
		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		internal override bool IsFull
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D6208C", Offset = "0x1D6208C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003170 File Offset: 0x00001370
		[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62094", Offset = "0x1D62094", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override int Decode(char[] chars, int startPos, int len)
		{
			throw null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003173 File Offset: 0x00001373
		[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6209C", Offset = "0x1D6209C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishIncrementalRead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public IncrementalReadDummyDecoder()
		{
			throw null;
		}
	}
}
