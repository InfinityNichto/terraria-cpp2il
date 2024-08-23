using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Security
{
	// Token: 0x02000226 RID: 550
	[global::Cpp2ILInjected.Token(Token = "0x2000316")]
	internal abstract class SafeFreeCredentials : SafeHandle
	{
		// Token: 0x06001257 RID: 4695 RVA: 0x000062B1 File Offset: 0x000044B1
		[global::Cpp2ILInjected.Token(Token = "0x6001493")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E37940", Offset = "0x1E37940", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		protected SafeFreeCredentials(IntPtr handle, bool ownsHandle)
		{
			throw null;
		}
	}
}
