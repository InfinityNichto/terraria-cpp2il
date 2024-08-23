using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200012D RID: 301
	[global::Cpp2ILInjected.Token(Token = "0x2000173")]
	internal static class EmptyArray<T>
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x00016CEE File Offset: 0x00014EEE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000EE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1622B18", Offset = "0x1622B18", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static EmptyArray()
		{
			throw null;
		}

		// Token: 0x040004A2 RID: 1186
		[global::Cpp2ILInjected.Token(Token = "0x4000671")]
		public static readonly T[] Value;
	}
}
