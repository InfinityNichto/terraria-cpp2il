using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000211")]
	internal class Comparer : IComparer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2F6F8", Offset = "0x1F2F6F8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private int System.Collections.IComparer.Compare(object ol, object or)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000D12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F2E444", Offset = "0x1F2E444", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Comparer()
		{
			throw null;
		}
	}
}
