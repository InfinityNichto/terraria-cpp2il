using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200020D")]
	public sealed class RegisteredWaitHandle : global::System.MarshalByRefObject
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA03F8", Offset = "0x1CA03F8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new object[]
		{
			typeof(WaitHandle),
			typeof(WaitOrTimerCallback),
			typeof(object),
			typeof(uint),
			typeof(bool),
			typeof(ref StackCrawlMark),
			typeof(bool)
		}, ReturnType = typeof(RegisteredWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, global::System.TimeSpan timeout, bool executeOnlyOnce)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1C18", Offset = "0x1CA1C18", Length = "0x4C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "get_SafeWaitHandle", ReturnType = typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new object[]
		{
			typeof(WaitHandle[]),
			typeof(global::System.TimeSpan),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaitCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new object[]
		{
			typeof(WaitCallback),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeEventCalls), Member = "SetEvent", MemberParameters = new object[] { typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		internal void Wait(object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA20DC", Offset = "0x1CA20DC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void DoCallBack(object timedOut)
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x60012AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA21D8", Offset = "0x1CA21D8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StopWatchingForExit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public bool Unregister(WaitHandle waitObject)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40009DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private WaitHandle _waitObject;

		[global::Cpp2ILInjected.Token(Token = "0x40009DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private WaitOrTimerCallback _callback;

		[global::Cpp2ILInjected.Token(Token = "0x40009DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object _state;

		[global::Cpp2ILInjected.Token(Token = "0x40009DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private WaitHandle _finalEvent;

		[global::Cpp2ILInjected.Token(Token = "0x40009DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ManualResetEvent _cancelEvent;

		[global::Cpp2ILInjected.Token(Token = "0x40009DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.TimeSpan _timeout;

		[global::Cpp2ILInjected.Token(Token = "0x40009E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _callsInProcess;

		[global::Cpp2ILInjected.Token(Token = "0x40009E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private bool _executeOnlyOnce;

		[global::Cpp2ILInjected.Token(Token = "0x40009E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D")]
		private bool _unregistered;
	}
}
