using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Unity
{
	// Token: 0x0200037D RID: 893
	[global::Cpp2ILInjected.Token(Token = "0x20004B4")]
	internal sealed class ThrowStub : ObjectDisposedException
	{
		// Token: 0x06001CDA RID: 7386 RVA: 0x00007FA6 File Offset: 0x000061A6
		[global::Cpp2ILInjected.Token(Token = "0x6002033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9DE94", Offset = "0x1E9DE94", Length = "0x1038")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void ThrowNotSupportedException()
		{
			throw null;
		}
	}
}
