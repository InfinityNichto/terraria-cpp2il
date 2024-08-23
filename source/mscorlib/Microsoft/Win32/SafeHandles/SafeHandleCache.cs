using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200003E RID: 62
	[global::Cpp2ILInjected.Token(Token = "0x2000059")]
	internal static class SafeHandleCache<T> where T : global::System.Runtime.InteropServices.SafeHandle
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00014AD1 File Offset: 0x00012CD1
		[global::Cpp2ILInjected.Token(Token = "0x6000213")]
		[global::Cpp2ILInjected.Address(RVA = "0x18630F4", Offset = "0x18630F4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafePasswordHandle), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static bool IsCachedInvalidHandle(global::System.Runtime.InteropServices.SafeHandle handle)
		{
			throw null;
		}

		// Token: 0x040000DB RID: 219
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		private static T s_invalidHandle;
	}
}
