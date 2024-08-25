using System;
using System.Net.Security;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32.SafeHandles
{
	[global::Cpp2ILInjected.Token(Token = "0x2000078")]
	internal sealed class SafeGssContextHandle : SafeHandle
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F4A8", Offset = "0x1E9F4A8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssInitSecurityContext", MemberParameters = new object[]
		{
			typeof(ref SafeGssContextHandle),
			typeof(SafeGssCredHandle),
			typeof(bool),
			typeof(SafeGssNameHandle),
			typeof(Interop.NetSecurityNative.GssFlags),
			typeof(byte[]),
			typeof(ref byte[]),
			typeof(ref uint),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SafeGssContextHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public override bool IsInvalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9F500", Offset = "0x1E9F500", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F554", Offset = "0x1E9F554", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "DeleteSecContext", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(ref IntPtr)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override bool ReleaseHandle()
		{
			throw null;
		}
	}
}
