using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32
{
	// Token: 0x0200002B RID: 43
	[global::Cpp2ILInjected.Token(Token = "0x2000075")]
	internal static class NativeMethods
	{
		// Token: 0x06000131 RID: 305 RVA: 0x0000316D File Offset: 0x0000136D
		[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53790", Offset = "0x1D53790", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(ref IntPtr),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "GetException", MemberParameters = new object[] { "System.IO.MonoIOError" }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			throw null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003170 File Offset: 0x00001370
		[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53970", Offset = "0x1D53970", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(ref IntPtr),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref MonoIOError)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeProcessHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.IO.MonoIO", Member = "GetException", MemberParameters = new object[] { "System.IO.MonoIOError" }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions)
		{
			throw null;
		}

		// Token: 0x06000133 RID: 307
		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53AAC", Offset = "0x1D53AAC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProcessWaitHandle), Member = ".ctor", MemberParameters = new object[] { typeof(SafeProcessHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x06000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53AB0", Offset = "0x1D53AB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool GetExitCodeProcess(IntPtr processHandle, out int exitCode);

		// Token: 0x06000135 RID: 309 RVA: 0x00003173 File Offset: 0x00001373
		[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53AB4", Offset = "0x1D53AB4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "get_HasExited", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetProcessHandle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(SafeProcessHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode)
		{
			throw null;
		}

		// Token: 0x06000136 RID: 310
		[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53B80", Offset = "0x1D53B80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "GetCurrentProcess", ReturnType = typeof(Process))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern int GetCurrentProcessId();

		// Token: 0x06000137 RID: 311
		[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53B84", Offset = "0x1D53B84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern bool SetPriorityClass(IntPtr handle, int priorityClass);

		// Token: 0x06000138 RID: 312 RVA: 0x00003176 File Offset: 0x00001376
		[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53B88", Offset = "0x1D53B88", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "set_PriorityClass", MemberParameters = new object[] { typeof(ProcessPriorityClass) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool SetPriorityClass(SafeProcessHandle handle, int priorityClass)
		{
			throw null;
		}

		// Token: 0x06000139 RID: 313
		[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D53C54", Offset = "0x1D53C54", Length = "0x1004")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeProcessHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[MethodImpl(4096)]
		public static extern bool CloseProcess(IntPtr handle);
	}
}
