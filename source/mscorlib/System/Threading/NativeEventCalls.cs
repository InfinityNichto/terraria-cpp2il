using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x200020C")]
	internal static class NativeEventCalls
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A20", Offset = "0x1CA1A20", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(EventResetMode),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static global::System.IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A78", Offset = "0x1CA1A78", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern global::System.IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode);

		[global::Cpp2ILInjected.Token(Token = "0x60012A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1A84", Offset = "0x1CA1A84", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool SetEvent(Microsoft.Win32.SafeHandles.SafeWaitHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1B48", Offset = "0x1CA1B48", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool SetEvent_internal(global::System.IntPtr handle);

		[global::Cpp2ILInjected.Token(Token = "0x60012A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1B4C", Offset = "0x1CA1B4C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventWaitHandle), Member = "Reset", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool ResetEvent(Microsoft.Win32.SafeHandles.SafeWaitHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1C10", Offset = "0x1CA1C10", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool ResetEvent_internal(global::System.IntPtr handle);

		[global::Cpp2ILInjected.Token(Token = "0x60012A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA1C14", Offset = "0x1CA1C14", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Microsoft.Win32.SafeHandles.SafeWaitHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void CloseEvent_internal(global::System.IntPtr handle);
	}
}
