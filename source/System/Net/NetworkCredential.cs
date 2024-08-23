using System;
using System.Net.Security;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Http;

namespace System.Net
{
	// Token: 0x0200013B RID: 315
	[global::Cpp2ILInjected.Token(Token = "0x20001C2")]
	public class NetworkCredential : ICredentials, ICredentialsByHost
	{
		// Token: 0x060009AA RID: 2474 RVA: 0x00004979 File Offset: 0x00002B79
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

		// Token: 0x060009AB RID: 2475 RVA: 0x0000497C File Offset: 0x00002B7C
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

		// Token: 0x060009AC RID: 2476 RVA: 0x0000497F File Offset: 0x00002B7F
		[global::Cpp2ILInjected.Token(Token = "0x6000ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10848", Offset = "0x1F10848", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public NetworkCredential(string userName, SecureString password)
		{
			throw null;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00004982 File Offset: 0x00002B82
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

		// Token: 0x060009AE RID: 2478 RVA: 0x00004985 File Offset: 0x00002B85
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

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00004988 File Offset: 0x00002B88
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x0000498B File Offset: 0x00002B8B
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

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x0000498E File Offset: 0x00002B8E
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00004991 File Offset: 0x00002B91
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00004994 File Offset: 0x00002B94
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00004997 File Offset: 0x00002B97
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0000499A File Offset: 0x00002B9A
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0000499D File Offset: 0x00002B9D
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

		// Token: 0x060009B7 RID: 2487 RVA: 0x000049A0 File Offset: 0x00002BA0
		[global::Cpp2ILInjected.Token(Token = "0x6000AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10AF8", Offset = "0x1F10AF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string InternalGetUserName()
		{
			throw null;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000049A3 File Offset: 0x00002BA3
		[global::Cpp2ILInjected.Token(Token = "0x6000AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10AD8", Offset = "0x1F10AD8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnsafeNclNativeMethods.SecureStringHelper), Member = "CreateString", MemberParameters = new object[] { typeof(SecureString) }, ReturnType = typeof(string))]
		internal string InternalGetPassword()
		{
			throw null;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000049A6 File Offset: 0x00002BA6
		[global::Cpp2ILInjected.Token(Token = "0x6000AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B00", Offset = "0x1F10B00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal SecureString InternalGetSecurePassword()
		{
			throw null;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x000049A9 File Offset: 0x00002BA9
		[global::Cpp2ILInjected.Token(Token = "0x6000AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B08", Offset = "0x1F10B08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal string InternalGetDomain()
		{
			throw null;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000049AC File Offset: 0x00002BAC
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

		// Token: 0x060009BC RID: 2492 RVA: 0x000049AF File Offset: 0x00002BAF
		[global::Cpp2ILInjected.Token(Token = "0x6000ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B70", Offset = "0x1F10B70", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public NetworkCredential GetCredential(Uri uri, string authType)
		{
			throw null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000049B2 File Offset: 0x00002BB2
		[global::Cpp2ILInjected.Token(Token = "0x6000ACC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F10B74", Offset = "0x1F10B74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public NetworkCredential GetCredential(string host, int port, string authenticationType)
		{
			throw null;
		}

		// Token: 0x0400076A RID: 1898
		[global::Cpp2ILInjected.Token(Token = "0x4000983")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_domain;

		// Token: 0x0400076B RID: 1899
		[global::Cpp2ILInjected.Token(Token = "0x4000984")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_userName;

		// Token: 0x0400076C RID: 1900
		[global::Cpp2ILInjected.Token(Token = "0x4000985")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private SecureString m_password;
	}
}
