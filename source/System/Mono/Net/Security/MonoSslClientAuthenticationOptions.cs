using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x0200001F RID: 31
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00003098 File Offset: 0x00001298
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public SslClientAuthenticationOptions Options
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600015B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D3D0", Offset = "0x1D4D3D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000309B File Offset: 0x0000129B
		[global::Cpp2ILInjected.Token(Token = "0x17000047")]
		public override bool ServerMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D3D8", Offset = "0x1D4D3D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000309E File Offset: 0x0000129E
		[global::Cpp2ILInjected.Token(Token = "0x600015D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4AB3C", Offset = "0x1D4AB3C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClient", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "AuthenticateAsClientAsync", MemberParameters = new object[]
		{
			typeof(string),
			typeof(X509CertificateCollection),
			typeof(SslProtocols),
			typeof(bool)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslClientAuthenticationOptions), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MonoSslClientAuthenticationOptions()
		{
			throw null;
		}

		// Token: 0x17000048 RID: 72
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000030A1 File Offset: 0x000012A1
		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		public override X509RevocationMode CertificateRevocationCheckMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D3E0", Offset = "0x1D4D3E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslClientAuthenticationOptions), Member = "set_CertificateRevocationCheckMode", MemberParameters = new object[] { typeof(X509RevocationMode) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000030A4 File Offset: 0x000012A4
		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		public override EncryptionPolicy EncryptionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D3EC", Offset = "0x1D4D3EC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SslClientAuthenticationOptions), Member = "set_EncryptionPolicy", MemberParameters = new object[] { typeof(EncryptionPolicy) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000030A7 File Offset: 0x000012A7
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000030AA File Offset: 0x000012AA
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		public override SslProtocols EnabledSslProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000160")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D3F8", Offset = "0x1D4D3F8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000161")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D404", Offset = "0x1D4D404", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000030AD File Offset: 0x000012AD
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x000030B0 File Offset: 0x000012B0
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		public override string TargetHost
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000162")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D410", Offset = "0x1D4D410", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000163")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D41C", Offset = "0x1D4D41C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000030B3 File Offset: 0x000012B3
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000030B6 File Offset: 0x000012B6
		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		public override bool ClientCertificateRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000164")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D428", Offset = "0x1D4D428", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000165")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D460", Offset = "0x1D4D460", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000030B9 File Offset: 0x000012B9
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000030BC File Offset: 0x000012BC
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		public override X509CertificateCollection ClientCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000166")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D498", Offset = "0x1D4D498", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000167")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D4A4", Offset = "0x1D4D4A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000030BF File Offset: 0x000012BF
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000030C2 File Offset: 0x000012C2
		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public override X509Certificate ServerCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000168")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D4B0", Offset = "0x1D4D4B0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000169")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D4E8", Offset = "0x1D4D4E8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000059 RID: 89
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000114")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly SslClientAuthenticationOptions <Options>k__BackingField;
	}
}
