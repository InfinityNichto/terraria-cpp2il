using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x02000020 RID: 32
	[global::Cpp2ILInjected.Token(Token = "0x2000063")]
	internal sealed class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000030C5 File Offset: 0x000012C5
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public SslServerAuthenticationOptions Options
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600016A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D520", Offset = "0x1D4D520", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000030C8 File Offset: 0x000012C8
		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public override bool ServerMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D528", Offset = "0x1D4D528", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000030CB File Offset: 0x000012CB
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4AE64", Offset = "0x1D4AE64", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsServer", MemberParameters = new object[]
		{
			typeof(X509Certificate),
			typeof(bool),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslServerAuthenticationOptions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MonoSslServerAuthenticationOptions()
		{
			throw null;
		}

		// Token: 0x17000051 RID: 81
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000030CE File Offset: 0x000012CE
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public override X509RevocationMode CertificateRevocationCheckMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D530", Offset = "0x1D4D530", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslServerAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new object[] { typeof(X509RevocationMode) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000030D1 File Offset: 0x000012D1
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public override EncryptionPolicy EncryptionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D53C", Offset = "0x1D4D53C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslServerAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new object[] { typeof(EncryptionPolicy) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FE RID: 254 RVA: 0x000030D4 File Offset: 0x000012D4
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000030D7 File Offset: 0x000012D7
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public override SslProtocols EnabledSslProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x600016F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D548", Offset = "0x1D4D548", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000170")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D554", Offset = "0x1D4D554", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000030DA File Offset: 0x000012DA
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000030DD File Offset: 0x000012DD
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public override bool ClientCertificateRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000171")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D560", Offset = "0x1D4D560", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000172")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D56C", Offset = "0x1D4D56C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000102 RID: 258 RVA: 0x000030E0 File Offset: 0x000012E0
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000030E3 File Offset: 0x000012E3
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public override string TargetHost
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000173")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D57C", Offset = "0x1D4D57C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000174")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D5B4", Offset = "0x1D4D5B4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000030E6 File Offset: 0x000012E6
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000030E9 File Offset: 0x000012E9
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public override X509Certificate ServerCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000175")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D5EC", Offset = "0x1D4D5EC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000176")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D5F8", Offset = "0x1D4D5F8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000030EC File Offset: 0x000012EC
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000030EF File Offset: 0x000012EF
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public override X509CertificateCollection ClientCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000177")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D604", Offset = "0x1D4D604", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000178")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D63C", Offset = "0x1D4D63C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400005A RID: 90
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000115")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly SslServerAuthenticationOptions <Options>k__BackingField;
	}
}
