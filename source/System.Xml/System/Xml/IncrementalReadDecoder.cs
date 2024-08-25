using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	internal abstract class IncrementalReadDecoder
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		internal abstract bool IsFull
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		internal abstract int Decode(char[] chars, int startPos, int len);

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
