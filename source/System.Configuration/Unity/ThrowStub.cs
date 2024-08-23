using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Unity
{
	// Token: 0x0200000F RID: 15
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	internal sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3C284", Offset = "0x1D3C284", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ThrowNotSupportedException()
		{
			throw null;
		}
	}
}
