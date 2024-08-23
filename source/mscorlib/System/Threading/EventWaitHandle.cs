using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	// Token: 0x0200018A RID: 394
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20001E9")]
	public class EventWaitHandle : WaitHandle
	{
		// Token: 0x06001031 RID: 4145 RVA: 0x000172E8 File Offset: 0x000154E8
		[global::Cpp2ILInjected.Token(Token = "0x600117A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C93D74", Offset = "0x1C93D74", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		public EventWaitHandle(bool initialState, EventResetMode mode)
		{
			throw null;
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x000172EB File Offset: 0x000154EB
		[global::Cpp2ILInjected.Token(Token = "0x600117B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9A5C4", Offset = "0x1C9A5C4", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AutoResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeEventCalls), Member = "CreateEvent_internal", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandleCannotBeOpenedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.__Error), Member = "WinIOError", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "SetHandleInternal", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public EventWaitHandle(bool initialState, EventResetMode mode, string name)
		{
			throw null;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x000172EE File Offset: 0x000154EE
		[global::Cpp2ILInjected.Token(Token = "0x600117C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C98A34", Offset = "0x1C98A34", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeEventCalls), Member = "ResetEvent", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.IOException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Reset()
		{
			throw null;
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000172F1 File Offset: 0x000154F1
		[global::Cpp2ILInjected.Token(Token = "0x600117D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C956CC", Offset = "0x1C956CC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 56)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeEventCalls), Member = "SetEvent", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.IOException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Set()
		{
			throw null;
		}
	}
}
