using System;
using System.ComponentModel;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Win32.SafeHandles;

namespace System.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000310")]
	internal static class NegotiateStreamPal
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001475")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36044", Offset = "0x1E36044", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetClientSpecifiedSpn", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static string QueryContextClientSpecifiedSpn(SafeDeleteContext securityContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001476")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36090", Offset = "0x1E36090", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "get_ProtocolName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static string QueryContextAuthenticationPackage(SafeDeleteContext securityContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001477")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36124", Offset = "0x1E36124", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "MakeSignature", MemberParameters = new object[]
		{
			typeof(SafeDeleteContext),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "WrapBuffer", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssContextHandle),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref Interop.NetSecurityNative.GssBuffer)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "ToByteArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(Interop.NetSecurityNative.Status)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static byte[] GssWrap(SafeGssContextHandle context, bool encrypt, byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001478")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36248", Offset = "0x1E36248", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(SafeDeleteContext),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "UnwrapBuffer", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssContextHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref Interop.NetSecurityNative.GssBuffer)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "Copy", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(Interop.NetSecurityNative.Status)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static int GssUnwrap(SafeGssContextHandle context, byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001479")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36378", Offset = "0x1E36378", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeGssContextHandle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative), Member = "InitSecContext", MemberParameters = new object[]
		{
			typeof(ref Interop.NetSecurityNative.Status),
			typeof(SafeGssCredHandle),
			typeof(ref SafeGssContextHandle),
			typeof(bool),
			typeof(SafeGssNameHandle),
			typeof(uint),
			typeof(byte[]),
			typeof(int),
			typeof(ref Interop.NetSecurityNative.GssBuffer),
			typeof(ref uint),
			typeof(ref int)
		}, ReturnType = typeof(Interop.NetSecurityNative.Status))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "ToByteArray", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssBuffer), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interop.NetSecurityNative.GssApiException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.Status),
			typeof(Interop.NetSecurityNative.Status)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static bool GssInitSecurityContext(ref SafeGssContextHandle context, SafeGssCredHandle credential, bool isNtlm, SafeGssNameHandle targetName, Interop.NetSecurityNative.GssFlags inFlags, byte[] buffer, out byte[] outputBuffer, out uint outFlags, out int isNtlmUsed)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3654C", Offset = "0x1E3654C", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "InitializeSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer[]),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeDeleteNegoContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextFlagsAdapterPal), Member = "GetInteropFromContextFlagsPal", MemberParameters = new object[]
		{
			typeof(ContextFlagsPal),
			typeof(bool)
		}, ReturnType = typeof(Interop.NetSecurityNative.GssFlags))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "GssInitSecurityContext", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextFlagsAdapterPal), Member = "GetContextFlagsPalFromInterop", MemberParameters = new object[]
		{
			typeof(Interop.NetSecurityNative.GssFlags),
			typeof(bool)
		}, ReturnType = typeof(ContextFlagsPal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityStatusPal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SecurityStatusPalErrorCode),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Error", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static SecurityStatusPal EstablishSecurityContext(SafeFreeNegoCredentials credential, ref SafeDeleteContext context, string targetName, ContextFlagsPal inFlags, SecurityBuffer inputBuffer, SecurityBuffer outputBuffer, ref ContextFlagsPal outFlags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36920", Offset = "0x1E36920", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "EstablishSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeNegoCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal static SecurityStatusPal InitializeSecurityContext(SafeFreeCredentials credentialsHandle, ref SafeDeleteContext securityContext, string spn, ContextFlagsPal requestedContextFlags, SecurityBuffer[] inSecurityBufferArray, SecurityBuffer outSecurityBuffer, ref ContextFlagsPal contextFlags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36AA4", Offset = "0x1E36AA4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static SecurityStatusPal AcceptSecurityContext(SafeFreeCredentials credentialsHandle, ref SafeDeleteContext securityContext, ContextFlagsPal requestedContextFlags, SecurityBuffer[] inSecurityBufferArray, SecurityBuffer outSecurityBuffer, ref ContextFlagsPal contextFlags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36AF0", Offset = "0x1E36AF0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static Win32Exception CreateExceptionFromError(SecurityStatusPal statusCode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36BAC", Offset = "0x1E36BAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(NetworkCredential),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(ChannelBinding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static int QueryMaxTokenSize(string package)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600147F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36BB4", Offset = "0x1E36BB4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(NetworkCredential),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(ChannelBinding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static SafeFreeCredentials AcquireDefaultCredential(string package, bool isServer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001480")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E36C4C", Offset = "0x1E36C4C", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(NetworkCredential),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(ChannelBinding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_UserName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeFreeNegoCredentials), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "get_Domain", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal static SafeFreeCredentials AcquireCredentialsHandle(string package, bool isServer, NetworkCredential credential)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001481")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E370B8", Offset = "0x1E370B8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityStatusPal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SecurityStatusPalErrorCode),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		internal static SecurityStatusPal CompleteAuthToken(ref SafeDeleteContext securityContext, SecurityBuffer[] inSecurityBufferArray)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001482")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E370E8", Offset = "0x1E370E8", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "GssUnwrap", MemberParameters = new object[]
		{
			typeof(SafeGssContextHandle),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal static int VerifySignature(SafeDeleteContext securityContext, byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001483")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3728C", Offset = "0x1E3728C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "MakeSignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "GssWrap", MemberParameters = new object[]
		{
			typeof(SafeGssContextHandle),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static int MakeSignature(SafeDeleteContext securityContext, byte[] buffer, int offset, int count, ref byte[] output)
		{
			throw null;
		}
	}
}
