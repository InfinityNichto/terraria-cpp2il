using System;
using System.ComponentModel;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200012B")]
	internal class NTAuthentication
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700017D")]
		internal bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000719")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3D78", Offset = "0x1EE3D78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700017E")]
		internal bool IsValidContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x600071A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3D80", Offset = "0x1EE3D80", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700017F")]
		internal string Package
		{
			[global::Cpp2ILInjected.Token(Token = "0x600071B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3DB0", Offset = "0x1EE3DB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000180")]
		internal bool IsServer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600071C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3DB8", Offset = "0x1EE3DB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000181")]
		internal string ClientSpecifiedSpn
		{
			[global::Cpp2ILInjected.Token(Token = "0x600071D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3DC0", Offset = "0x1EE3DC0", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NTAuthentication), Member = "GetClientSpecifiedSpn", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000182")]
		internal string ProtocolName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600071E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3F5C", Offset = "0x1EE3F5C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "get_IsKerberos", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "QueryContextAuthenticationPackage", MemberParameters = new object[] { typeof(SafeDeleteContext) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000183")]
		internal bool IsKerberos
		{
			[global::Cpp2ILInjected.Token(Token = "0x600071F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE3FE4", Offset = "0x1EE3FE4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NTAuthentication), Member = "get_ProtocolName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000720")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE4044", Offset = "0x1EE4044", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal NTAuthentication(bool isServer, string package, NetworkCredential credential, string spn, ContextFlagsPal requestedContextFlags, ChannelBinding channelBinding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000721")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE40A8", Offset = "0x1EE40A8", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "QueryMaxTokenSize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "AcquireCredentialsHandle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(NetworkCredential)
		}, ReturnType = typeof(SafeFreeCredentials))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "AcquireDefaultCredential", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(SafeFreeCredentials))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void Initialize(bool isServer, string package, NetworkCredential credential, string spn, ContextFlagsPal requestedContextFlags, ChannelBinding channelBinding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000722")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE433C", Offset = "0x1EE433C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal SafeDeleteContext GetContext(out SecurityStatusPal status)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000723")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE447C", Offset = "0x1EE447C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "get_IsClosed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		internal void CloseContext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000724")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE44B0", Offset = "0x1EE44B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(SafeDeleteContext),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		internal int VerifySignature(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000725")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE44BC", Offset = "0x1EE44BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "MakeSignature", MemberParameters = new object[]
		{
			typeof(SafeDeleteContext),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[])
		}, ReturnType = typeof(int))]
		internal int MakeSignature(byte[] buffer, int offset, int count, ref byte[] output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000726")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE44C8", Offset = "0x1EE44C8", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NTAuthentication), Member = "CloseContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal string GetOutgoingBlob(string incomingBlob)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000727")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE512C", Offset = "0x1EE512C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool),
			typeof(ref SecurityStatusPal)
		}, ReturnType = typeof(byte[]))]
		internal byte[] GetOutgoingBlob(byte[] incomingBlob, bool thrownOnError)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000728")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE45E8", Offset = "0x1EE45E8", Length = "0xB44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "GetOutgoingBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityBuffer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(SecurityBufferType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityBuffer), Member = ".ctor", MemberParameters = new object[] { typeof(ChannelBinding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityBuffer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SecurityBufferType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "AcceptSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeCredentials),
			typeof(ref SafeDeleteContext),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer[]),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "InitializeSecurityContext", MemberParameters = new object[]
		{
			typeof(SafeFreeCredentials),
			typeof(ref SafeDeleteContext),
			typeof(string),
			typeof(ContextFlagsPal),
			typeof(SecurityBuffer[]),
			typeof(SecurityBuffer),
			typeof(ref ContextFlagsPal)
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "CompleteAuthToken", MemberParameters = new object[]
		{
			typeof(ref SafeDeleteContext),
			typeof(SecurityBuffer[])
		}, ReturnType = typeof(SecurityStatusPal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SSPIHandleCache), Member = "CacheCredential", MemberParameters = new object[] { typeof(SafeFreeCredentials) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NTAuthentication), Member = "CloseContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "CreateExceptionFromError", MemberParameters = new object[] { typeof(SecurityStatusPal) }, ReturnType = typeof(Win32Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Exit", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 104)]
		internal byte[] GetOutgoingBlob(byte[] incomingBlob, bool throwOnError, out SecurityStatusPal statusCode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000729")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE3DE4", Offset = "0x1EE3DE4", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NTAuthentication), Member = "get_ClientSpecifiedSpn", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Fail", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NegotiateStreamPal), Member = "QueryContextClientSpecifiedSpn", MemberParameters = new object[] { typeof(SafeDeleteContext) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "get_IsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormattableStringFactory), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(FormattableString))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetEventSource), Member = "Info", MemberParameters = new object[]
		{
			typeof(object),
			typeof(FormattableString),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private string GetClientSpecifiedSpn()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000584")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _isServer;

		[global::Cpp2ILInjected.Token(Token = "0x4000585")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SafeFreeCredentials _credentialsHandle;

		[global::Cpp2ILInjected.Token(Token = "0x4000586")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SafeDeleteContext _securityContext;

		[global::Cpp2ILInjected.Token(Token = "0x4000587")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _spn;

		[global::Cpp2ILInjected.Token(Token = "0x4000588")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _tokenSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000589")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private ContextFlagsPal _requestedContextFlags;

		[global::Cpp2ILInjected.Token(Token = "0x400058A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ContextFlagsPal _contextFlags;

		[global::Cpp2ILInjected.Token(Token = "0x400058B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private bool _isCompleted;

		[global::Cpp2ILInjected.Token(Token = "0x400058C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _package;

		[global::Cpp2ILInjected.Token(Token = "0x400058D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _lastProtocolName;

		[global::Cpp2ILInjected.Token(Token = "0x400058E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _protocolName;

		[global::Cpp2ILInjected.Token(Token = "0x400058F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string _clientSpecifiedSpn;

		[global::Cpp2ILInjected.Token(Token = "0x4000590")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ChannelBinding _channelBinding;
	}
}
