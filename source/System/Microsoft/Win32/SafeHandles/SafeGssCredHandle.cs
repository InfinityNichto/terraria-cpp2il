using System;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200002D RID: 45
	[global::Cpp2ILInjected.Token(Token = "0x2000077")]
	internal class SafeGssCredHandle : SafeHandle
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00003185 File Offset: 0x00001385
		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F0FC", Offset = "0x1E9F0FC", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeFreeNegoCredentials), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeGssCredHandle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeGssNameHandle), Member = "CreateUser", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SafeGssNameHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "InitiateCredSpNego", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssNameHandle),
			typeof(ref SafeGssCredHandle)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "InitiateCredWithPassword", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(bool),
			typeof(SafeGssNameHandle),
			typeof(string),
			typeof(int),
			typeof(ref SafeGssCredHandle)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(Interop.NetSecurityNative.Status)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static SafeGssCredHandle Create(string username, string password, bool isNtlmOnly)
		{
			throw null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003188 File Offset: 0x00001388
		[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F388", Offset = "0x1E9F388", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssCredHandle), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(SafeGssCredHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private SafeGssCredHandle()
		{
			throw null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000318B File Offset: 0x0000138B
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public override bool IsInvalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9F3E0", Offset = "0x1E9F3E0", Length = "0x54")]
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

		// Token: 0x06000141 RID: 321 RVA: 0x0000318E File Offset: 0x0000138E
		[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F434", Offset = "0x1E9F434", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "ReleaseCred", MemberParameters = new object[]
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
