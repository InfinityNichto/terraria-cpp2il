using System;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200002C RID: 44
	[global::Cpp2ILInjected.Token(Token = "0x2000076")]
	internal sealed class SafeGssNameHandle : SafeHandle
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00003179 File Offset: 0x00001379
		[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9EECC", Offset = "0x1E9EECC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssCredHandle), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(SafeGssCredHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "ImportUserName", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(string),
			typeof(int),
			typeof(ref SafeGssNameHandle)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(Interop.NetSecurityNative.Status)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static SafeGssNameHandle CreateUser(string name)
		{
			throw null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000317C File Offset: 0x0000137C
		[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9EF80", Offset = "0x1E9EF80", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeDeleteNegoContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "ImportPrincipalName", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(string),
			typeof(int),
			typeof(ref SafeGssNameHandle)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(Interop.NetSecurityNative.Status)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static SafeGssNameHandle CreatePrincipal(string name)
		{
			throw null;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000317F File Offset: 0x0000137F
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public override bool IsInvalid
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E9F034", Offset = "0x1E9F034", Length = "0x54")]
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

		// Token: 0x0600013D RID: 317 RVA: 0x00003182 File Offset: 0x00001382
		[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9F088", Offset = "0x1E9F088", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "ReleaseName", MemberParameters = new object[]
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
