using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	internal class ContractionComparer : global::System.Collections.Generic.IComparer<Contraction>
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADC14", Offset = "0x1AADC14", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int Compare(Contraction c1, Contraction c2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADC74", Offset = "0x1AADC74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ContractionComparer()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AADC7C", Offset = "0x1AADC7C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ContractionComparer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		public static readonly ContractionComparer Instance;
	}
}
