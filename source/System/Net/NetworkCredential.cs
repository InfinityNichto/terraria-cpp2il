using System;
using System.Net.Security;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Http;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001C2")]
	public class NetworkCredential : ICredentials, ICredentialsByHost
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10788", Offset = "0x1F10788", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NetworkCredential()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F107E0", Offset = "0x1F107E0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".ctor", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NetworkCredential(string userName, string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10848", Offset = "0x1F10848", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NetworkCredential(string userName, SecureString password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B0E8", Offset = "0x1F0B0E8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpWebRequest), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "AcquireDefaultCredential", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(SafeFreeCredentials))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.SecureStringHelper), Member = "CreateSecureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SecureString))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NetworkCredential(string userName, string password, string domain)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F108B0", Offset = "0x1F108B0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkCredential), Member = "set_SecurePassword", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NetworkCredential(string userName, SecureString password, string domain)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700022B")]
		public string UserName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000ABE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10AC4", Offset = "0x1F10AC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NtlmSession), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "CanReuseConnection", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "PrepareSharingNtlm", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "AcquireCredentialsHandle", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(NetworkCredential)
			}, ReturnType = typeof(SafeFreeCredentials))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000ABF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10970", Offset = "0x1F10970", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700022C")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10ACC", Offset = "0x1F10ACC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NtlmSession), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "CanReuseConnection", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "PrepareSharingNtlm", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "AcquireCredentialsHandle", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(NetworkCredential)
			}, ReturnType = typeof(SafeFreeCredentials))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.SecureStringHelper), Member = "CreateString", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AC1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F109D0", Offset = "0x1F109D0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.SecureStringHelper), Member = "CreateSecureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SecureString))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700022D")]
		public SecureString SecurePassword
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10AE4", Offset = "0x1F10AE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = "Copy", ReturnType = typeof(SecureString))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AC3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10A50", Offset = "0x1F10A50", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkCredential), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(SecureString),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = "Copy", ReturnType = typeof(SecureString))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecureString), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700022E")]
		public string Domain
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AC4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F10AF0", Offset = "0x1F10AF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NtlmSession), Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FtpControlStream), Member = "BuildCommandsList", MemberParameters = new object[] { typeof(WebRequest) }, ReturnType = typeof(CommandStream.PipelineEntry[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new object[]
			{
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "CanReuseConnection", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebConnection), Member = "PrepareSharingNtlm", MemberParameters = new object[] { typeof(WebOperation) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NegotiateStreamPal), Member = "AcquireCredentialsHandle", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(NetworkCredential)
			}, ReturnType = typeof(SafeFreeCredentials))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000AC5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F109F0", Offset = "0x1F109F0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10AF8", Offset = "0x1F10AF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string InternalGetUserName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10AD8", Offset = "0x1F10AD8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.SecureStringHelper), Member = "CreateString", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(string))]
		internal string InternalGetPassword()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B00", Offset = "0x1F10B00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal SecureString InternalGetSecurePassword()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B08", Offset = "0x1F10B08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string InternalGetDomain()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B10", Offset = "0x1F10B10", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string InternalGetDomainUserName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B70", Offset = "0x1F10B70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public NetworkCredential GetCredential(Uri uri, string authType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B74", Offset = "0x1F10B74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000983")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_domain;

		[global::Cpp2ILInjected.Token(Token = "0x4000984")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_userName;

		[global::Cpp2ILInjected.Token(Token = "0x4000985")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SecureString m_password;
	}
}
