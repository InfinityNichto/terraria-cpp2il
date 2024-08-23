using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	// Token: 0x02000083 RID: 131
	[global::Cpp2ILInjected.Token(Token = "0x20000DE")]
	internal class ProcessWaitHandle : WaitHandle
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x00003B15 File Offset: 0x00001D15
		[global::Cpp2ILInjected.Token(Token = "0x6000521")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC8198", Offset = "0x1EC8198", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "GetCurrentProcess", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HandleRef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(HandleRef),
			typeof(SafeHandle),
			typeof(HandleRef),
			typeof(ref SafeWaitHandle),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "set_SafeWaitHandle", MemberParameters = new object[] { typeof(SafeWaitHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal ProcessWaitHandle(SafeProcessHandle processHandle)
		{
			throw null;
		}
	}
}
