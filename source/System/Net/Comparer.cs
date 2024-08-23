using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000171 RID: 369
	[global::Cpp2ILInjected.Token(Token = "0x2000211")]
	internal class Comparer : IComparer
	{
		// Token: 0x06000BBA RID: 3002 RVA: 0x00004F8E File Offset: 0x0000318E
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

		// Token: 0x06000BBB RID: 3003 RVA: 0x00004F91 File Offset: 0x00003191
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
