using System;
using System.Net.Security;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000002 RID: 2
[global::Cpp2ILInjected.Token(Token = "0x2000002")]
internal static class Interop
{
	// Token: 0x0200038A RID: 906
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	internal static class NetSecurityNative
	{
		// Token: 0x06001CE7 RID: 7399 RVA: 0x00007FCD File Offset: 0x000061CD
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FB58", Offset = "0x1D3FB58", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void ReleaseGssBuffer(IntPtr bufferPtr, ulong length)
		{
			throw null;
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00007FD0 File Offset: 0x000061D0
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FB90", Offset = "0x1D3FB90", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status DisplayMinorStatus(out Interop.NetSecurityNative.Status minorStatus, Interop.NetSecurityNative.Status statusValue, ref Interop.NetSecurityNative.GssBuffer buffer)
		{
			throw null;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00007FD3 File Offset: 0x000061D3
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FBC8", Offset = "0x1D3FBC8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status DisplayMajorStatus(out Interop.NetSecurityNative.Status minorStatus, Interop.NetSecurityNative.Status statusValue, ref Interop.NetSecurityNative.GssBuffer buffer)
		{
			throw null;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00007FD6 File Offset: 0x000061D6
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FC00", Offset = "0x1D3FC00", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssNameHandle), Member = "CreateUser", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SafeGssNameHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status ImportUserName(out Interop.NetSecurityNative.Status minorStatus, string inputName, int inputNameByteCount, out SafeGssNameHandle outputName)
		{
			throw null;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00007FD9 File Offset: 0x000061D9
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FC38", Offset = "0x1D3FC38", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssNameHandle), Member = "CreatePrincipal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SafeGssNameHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status ImportPrincipalName(out Interop.NetSecurityNative.Status minorStatus, string inputName, int inputNameByteCount, out SafeGssNameHandle outputName)
		{
			throw null;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00007FDC File Offset: 0x000061DC
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FC70", Offset = "0x1D3FC70", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssNameHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status ReleaseName(out Interop.NetSecurityNative.Status minorStatus, ref IntPtr inputName)
		{
			throw null;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00007FDF File Offset: 0x000061DF
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FCA8", Offset = "0x1D3FCA8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssCredHandle), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(SafeGssCredHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status InitiateCredSpNego(out Interop.NetSecurityNative.Status minorStatus, SafeGssNameHandle desiredName, out SafeGssCredHandle outputCredHandle)
		{
			throw null;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00007FE2 File Offset: 0x000061E2
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FCE0", Offset = "0x1D3FCE0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssCredHandle), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(SafeGssCredHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status InitiateCredWithPassword(out Interop.NetSecurityNative.Status minorStatus, bool isNtlm, SafeGssNameHandle desiredName, string password, int passwordLen, out SafeGssCredHandle outputCredHandle)
		{
			throw null;
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00007FE5 File Offset: 0x000061E5
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FD18", Offset = "0x1D3FD18", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssCredHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status ReleaseCred(out Interop.NetSecurityNative.Status minorStatus, ref IntPtr credHandle)
		{
			throw null;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00007FE8 File Offset: 0x000061E8
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FD50", Offset = "0x1D3FD50", Length = "0x38")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status InitSecContext(out Interop.NetSecurityNative.Status minorStatus, SafeGssCredHandle initiatorCredHandle, ref SafeGssContextHandle contextHandle, bool isNtlmOnly, SafeGssNameHandle targetName, uint reqFlags, byte[] inputBytes, int inputLength, ref Interop.NetSecurityNative.GssBuffer token, out uint retFlags, out int isNtlmUsed)
		{
			throw null;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00007FEB File Offset: 0x000061EB
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FD88", Offset = "0x1D3FD88", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssContextHandle), Member = "ReleaseHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static Interop.NetSecurityNative.Status DeleteSecContext(out Interop.NetSecurityNative.Status minorStatus, ref IntPtr contextHandle)
		{
			throw null;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00007FEE File Offset: 0x000061EE
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FDC0", Offset = "0x1D3FDC0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative), Member = "WrapBuffer", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssContextHandle),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref Interop.NetSecurityNative.GssBuffer)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Interop.NetSecurityNative.Status Wrap(out Interop.NetSecurityNative.Status minorStatus, SafeGssContextHandle contextHandle, bool isEncrypt, byte[] inputBytes, int offset, int count, ref Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw null;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00007FF1 File Offset: 0x000061F1
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FDF8", Offset = "0x1D3FDF8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative), Member = "UnwrapBuffer", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssContextHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref Interop.NetSecurityNative.GssBuffer)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Interop.NetSecurityNative.Status Unwrap(out Interop.NetSecurityNative.Status minorStatus, SafeGssContextHandle contextHandle, byte[] inputBytes, int offset, int count, ref Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw null;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00007FF4 File Offset: 0x000061F4
		[global::Cpp2ILInjected.Token(Token = "0x600000E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FE30", Offset = "0x1D3FE30", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssWrap", MemberParameters = new object[]
		{
			typeof(SafeGssContextHandle),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "Wrap", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssContextHandle),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref Interop.NetSecurityNative.GssBuffer)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		internal static Interop.NetSecurityNative.Status WrapBuffer(out Interop.NetSecurityNative.Status minorStatus, SafeGssContextHandle contextHandle, bool isEncrypt, byte[] inputBytes, int offset, int count, ref Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw null;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00007FF7 File Offset: 0x000061F7
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3FE3C", Offset = "0x1D3FE3C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssUnwrap", MemberParameters = new object[]
		{
			typeof(SafeGssContextHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "Unwrap", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssContextHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref Interop.NetSecurityNative.GssBuffer)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		internal static Interop.NetSecurityNative.Status UnwrapBuffer(out Interop.NetSecurityNative.Status minorStatus, SafeGssContextHandle contextHandle, byte[] inputBytes, int offset, int count, ref Interop.NetSecurityNative.GssBuffer outBuffer)
		{
			throw null;
		}

		// Token: 0x02000494 RID: 1172
		[global::Cpp2ILInjected.Token(Token = "0x2000004")]
		internal sealed class GssApiException : Exception
		{
			// Token: 0x06001FC2 RID: 8130 RVA: 0x000087A7 File Offset: 0x000069A7
			[global::Cpp2ILInjected.Token(Token = "0x6000010")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3FE44", Offset = "0x1D3FE44", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "Copy", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public GssApiException(string message)
			{
				throw null;
			}

			// Token: 0x06001FC3 RID: 8131 RVA: 0x000087AA File Offset: 0x000069AA
			[global::Cpp2ILInjected.Token(Token = "0x6000011")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3FEAC", Offset = "0x1D3FEAC", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssNameHandle), Member = "CreateUser", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SafeGssNameHandle))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssNameHandle), Member = "CreatePrincipal", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SafeGssNameHandle))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeGssCredHandle), Member = "Create", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(SafeGssCredHandle))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssWrap", MemberParameters = new object[]
			{
				typeof(SafeGssContextHandle),
				typeof(bool),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssUnwrap", MemberParameters = new object[]
			{
				typeof(SafeGssContextHandle),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
			{
				typeof(Interop.NetSecurityNative.Status),
				typeof(Interop.NetSecurityNative.Status),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public GssApiException(Interop.NetSecurityNative.Status majorStatus, Interop.NetSecurityNative.Status minorStatus)
			{
				throw null;
			}

			// Token: 0x06001FC4 RID: 8132 RVA: 0x000087AD File Offset: 0x000069AD
			[global::Cpp2ILInjected.Token(Token = "0x6000012")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3FF3C", Offset = "0x1D3FF3C", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(Interop.NetSecurityNative.Status),
				typeof(Interop.NetSecurityNative.Status)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
			{
				typeof(Interop.NetSecurityNative.Status),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			private static string GetGssApiDisplayStatus(Interop.NetSecurityNative.Status majorStatus, Interop.NetSecurityNative.Status minorStatus, string helpText)
			{
				throw null;
			}

			// Token: 0x06001FC5 RID: 8133 RVA: 0x000087B0 File Offset: 0x000069B0
			[global::Cpp2ILInjected.Token(Token = "0x6000013")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4010C", Offset = "0x1D4010C", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
			{
				typeof(Interop.NetSecurityNative.Status),
				typeof(Interop.NetSecurityNative.Status),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "DisplayMinorStatus", MemberParameters = new object[]
			{
				typeof(ref Interop.NetSecurityNative.Status),
				typeof(Interop.NetSecurityNative.Status),
				typeof(ref Interop.NetSecurityNative.GssBuffer)
			}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "DisplayMajorStatus", MemberParameters = new object[]
			{
				typeof(ref Interop.NetSecurityNative.Status),
				typeof(Interop.NetSecurityNative.Status),
				typeof(ref Interop.NetSecurityNative.GssBuffer)
			}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			private static string GetGssApiDisplayStatus(Interop.NetSecurityNative.Status status, bool isMinor)
			{
				throw null;
			}

			// Token: 0x040013F4 RID: 5108
			[global::Cpp2ILInjected.Token(Token = "0x4000001")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
			private readonly Interop.NetSecurityNative.Status _minorStatus;
		}

		// Token: 0x02000495 RID: 1173
		[global::Cpp2ILInjected.Token(Token = "0x2000005")]
		internal struct GssBuffer : IDisposable
		{
			// Token: 0x06001FC6 RID: 8134 RVA: 0x000087B3 File Offset: 0x000069B3
			[global::Cpp2ILInjected.Token(Token = "0x6000014")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40204", Offset = "0x1D40204", Length = "0x198")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssUnwrap", MemberParameters = new object[]
			{
				typeof(SafeGssContextHandle),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			internal int Copy(byte[] destination, int offset)
			{
				throw null;
			}

			// Token: 0x06001FC7 RID: 8135 RVA: 0x000087B6 File Offset: 0x000069B6
			[global::Cpp2ILInjected.Token(Token = "0x6000015")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4039C", Offset = "0x1D4039C", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssWrap", MemberParameters = new object[]
			{
				typeof(SafeGssContextHandle),
				typeof(bool),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal byte[] ToByteArray()
			{
				throw null;
			}

			// Token: 0x06001FC8 RID: 8136 RVA: 0x000087B9 File Offset: 0x000069B9
			[global::Cpp2ILInjected.Token(Token = "0x6000016")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D40504", Offset = "0x1D40504", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = "GetGssApiDisplayStatus", MemberParameters = new object[]
			{
				typeof(Interop.NetSecurityNative.Status),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssWrap", MemberParameters = new object[]
			{
				typeof(SafeGssContextHandle),
				typeof(bool),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "GssUnwrap", MemberParameters = new object[]
			{
				typeof(SafeGssContextHandle),
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "ReleaseGssBuffer", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(ulong)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x040013F5 RID: 5109
			[global::Cpp2ILInjected.Token(Token = "0x4000002")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal ulong _length;

			// Token: 0x040013F6 RID: 5110
			[global::Cpp2ILInjected.Token(Token = "0x4000003")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal IntPtr _data;
		}

		// Token: 0x02000496 RID: 1174
		[global::Cpp2ILInjected.Token(Token = "0x2000006")]
		internal enum Status : uint
		{
			// Token: 0x040013F8 RID: 5112
			[global::Cpp2ILInjected.Token(Token = "0x4000005")]
			GSS_S_COMPLETE,
			// Token: 0x040013F9 RID: 5113
			[global::Cpp2ILInjected.Token(Token = "0x4000006")]
			GSS_S_CONTINUE_NEEDED,
			// Token: 0x040013FA RID: 5114
			[global::Cpp2ILInjected.Token(Token = "0x4000007")]
			GSS_S_BAD_MECH = 65536U,
			// Token: 0x040013FB RID: 5115
			[global::Cpp2ILInjected.Token(Token = "0x4000008")]
			GSS_S_BAD_NAME = 131072U,
			// Token: 0x040013FC RID: 5116
			[global::Cpp2ILInjected.Token(Token = "0x4000009")]
			GSS_S_BAD_NAMETYPE = 196608U,
			// Token: 0x040013FD RID: 5117
			[global::Cpp2ILInjected.Token(Token = "0x400000A")]
			GSS_S_BAD_BINDINGS = 262144U,
			// Token: 0x040013FE RID: 5118
			[global::Cpp2ILInjected.Token(Token = "0x400000B")]
			GSS_S_BAD_STATUS = 327680U,
			// Token: 0x040013FF RID: 5119
			[global::Cpp2ILInjected.Token(Token = "0x400000C")]
			GSS_S_BAD_SIG = 393216U,
			// Token: 0x04001400 RID: 5120
			[global::Cpp2ILInjected.Token(Token = "0x400000D")]
			GSS_S_NO_CRED = 458752U,
			// Token: 0x04001401 RID: 5121
			[global::Cpp2ILInjected.Token(Token = "0x400000E")]
			GSS_S_NO_CONTEXT = 524288U,
			// Token: 0x04001402 RID: 5122
			[global::Cpp2ILInjected.Token(Token = "0x400000F")]
			GSS_S_DEFECTIVE_TOKEN = 589824U,
			// Token: 0x04001403 RID: 5123
			[global::Cpp2ILInjected.Token(Token = "0x4000010")]
			GSS_S_DEFECTIVE_CREDENTIAL = 655360U,
			// Token: 0x04001404 RID: 5124
			[global::Cpp2ILInjected.Token(Token = "0x4000011")]
			GSS_S_CREDENTIALS_EXPIRED = 720896U,
			// Token: 0x04001405 RID: 5125
			[global::Cpp2ILInjected.Token(Token = "0x4000012")]
			GSS_S_CONTEXT_EXPIRED = 786432U,
			// Token: 0x04001406 RID: 5126
			[global::Cpp2ILInjected.Token(Token = "0x4000013")]
			GSS_S_FAILURE = 851968U,
			// Token: 0x04001407 RID: 5127
			[global::Cpp2ILInjected.Token(Token = "0x4000014")]
			GSS_S_BAD_QOP = 917504U,
			// Token: 0x04001408 RID: 5128
			[global::Cpp2ILInjected.Token(Token = "0x4000015")]
			GSS_S_UNAUTHORIZED = 983040U,
			// Token: 0x04001409 RID: 5129
			[global::Cpp2ILInjected.Token(Token = "0x4000016")]
			GSS_S_UNAVAILABLE = 1048576U,
			// Token: 0x0400140A RID: 5130
			[global::Cpp2ILInjected.Token(Token = "0x4000017")]
			GSS_S_DUPLICATE_ELEMENT = 1114112U,
			// Token: 0x0400140B RID: 5131
			[global::Cpp2ILInjected.Token(Token = "0x4000018")]
			GSS_S_NAME_NOT_MN = 1179648U
		}

		// Token: 0x02000497 RID: 1175
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x2000007")]
		internal enum GssFlags : uint
		{
			// Token: 0x0400140D RID: 5133
			[global::Cpp2ILInjected.Token(Token = "0x400001A")]
			GSS_C_DELEG_FLAG = 1U,
			// Token: 0x0400140E RID: 5134
			[global::Cpp2ILInjected.Token(Token = "0x400001B")]
			GSS_C_MUTUAL_FLAG = 2U,
			// Token: 0x0400140F RID: 5135
			[global::Cpp2ILInjected.Token(Token = "0x400001C")]
			GSS_C_REPLAY_FLAG = 4U,
			// Token: 0x04001410 RID: 5136
			[global::Cpp2ILInjected.Token(Token = "0x400001D")]
			GSS_C_SEQUENCE_FLAG = 8U,
			// Token: 0x04001411 RID: 5137
			[global::Cpp2ILInjected.Token(Token = "0x400001E")]
			GSS_C_CONF_FLAG = 16U,
			// Token: 0x04001412 RID: 5138
			[global::Cpp2ILInjected.Token(Token = "0x400001F")]
			GSS_C_INTEG_FLAG = 32U,
			// Token: 0x04001413 RID: 5139
			[global::Cpp2ILInjected.Token(Token = "0x4000020")]
			GSS_C_ANON_FLAG = 64U,
			// Token: 0x04001414 RID: 5140
			[global::Cpp2ILInjected.Token(Token = "0x4000021")]
			GSS_C_PROT_READY_FLAG = 128U,
			// Token: 0x04001415 RID: 5141
			[global::Cpp2ILInjected.Token(Token = "0x4000022")]
			GSS_C_TRANS_FLAG = 256U,
			// Token: 0x04001416 RID: 5142
			[global::Cpp2ILInjected.Token(Token = "0x4000023")]
			GSS_C_DCE_STYLE = 4096U,
			// Token: 0x04001417 RID: 5143
			[global::Cpp2ILInjected.Token(Token = "0x4000024")]
			GSS_C_IDENTIFY_FLAG = 8192U,
			// Token: 0x04001418 RID: 5144
			[global::Cpp2ILInjected.Token(Token = "0x4000025")]
			GSS_C_EXTENDED_ERROR_FLAG = 16384U,
			// Token: 0x04001419 RID: 5145
			[global::Cpp2ILInjected.Token(Token = "0x4000026")]
			GSS_C_DELEG_POLICY_FLAG = 32768U
		}
	}
}
