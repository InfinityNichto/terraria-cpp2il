using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Unity
{
	// Token: 0x0200001A RID: 26
	[global::Cpp2ILInjected.Token(Token = "0x2000020")]
	internal sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000226F File Offset: 0x0000046F
		[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F4F0", Offset = "0x1D6F4F0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ThrowNotSupportedException()
		{
			throw null;
		}
	}
}
