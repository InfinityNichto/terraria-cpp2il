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
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
	{
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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000114")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly SslClientAuthenticationOptions <Options>k__BackingField;
	}
}
