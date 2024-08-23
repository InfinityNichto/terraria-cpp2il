using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000050 RID: 80
	[ComVisible(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000A1")]
	public sealed class Semaphore : WaitHandle
	{
		// Token: 0x0600024C RID: 588 RVA: 0x000034A0 File Offset: 0x000016A0
		[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA80EC", Offset = "0x1EA80EC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Semaphore), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static IntPtr CreateSemaphore_internal(int initialCount, int maximumCount, string name, out int errorCode)
		{
			throw null;
		}

		// Token: 0x0600024D RID: 589
		[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8144", Offset = "0x1EA8144", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern IntPtr CreateSemaphore_icall(int initialCount, int maximumCount, char* name, int name_length, out int errorCode);

		// Token: 0x0600024E RID: 590
		[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA8148", Offset = "0x1EA8148", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Semaphore), Member = "ReleaseSemaphore", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool ReleaseSemaphore_internal(IntPtr handle, int releaseCount, out int previousCount);
	}
}
