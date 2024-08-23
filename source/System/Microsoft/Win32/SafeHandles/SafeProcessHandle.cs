using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200002F RID: 47
	[global::Cpp2ILInjected.Token(Token = "0x2000079")]
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000145 RID: 325 RVA: 0x0000319A File Offset: 0x0000139A
		[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F5C8", Offset = "0x1E9F5C8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		internal SafeProcessHandle(IntPtr handle)
		{
			throw null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000319D File Offset: 0x0000139D
		[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F5F4", Offset = "0x1E9F5F4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeMethods), Member = "DuplicateHandle", MemberParameters = new object[]
		{
			typeof(HandleRef),
			typeof(HandleRef),
			typeof(HandleRef),
			typeof(ref SafeProcessHandle),
			typeof(int),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithShellExecuteEx", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Process), Member = "StartWithCreateProcess", MemberParameters = new object[] { typeof(ProcessStartInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public SafeProcessHandle(IntPtr existingHandle, bool ownsHandle)
		{
			throw null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000031A0 File Offset: 0x000013A0
		[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F620", Offset = "0x1E9F620", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeMethods), Member = "CloseProcess", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(bool))]
		protected override bool ReleaseHandle()
		{
			throw null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000031A3 File Offset: 0x000013A3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F62C", Offset = "0x1E9F62C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandleZeroOrMinusOneIsInvalid), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static SafeProcessHandle()
		{
			throw null;
		}

		// Token: 0x0400008F RID: 143
		[global::Cpp2ILInjected.Token(Token = "0x400015F")]
		internal static SafeProcessHandle InvalidHandle;
	}
}
