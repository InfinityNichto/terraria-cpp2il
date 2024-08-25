using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	internal abstract class MonoSslAuthenticationOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public abstract bool ServerMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014C")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public abstract SslProtocols EnabledSslProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014D")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600014E")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		public abstract EncryptionPolicy EncryptionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014F")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public abstract X509RevocationMode CertificateRevocationCheckMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000150")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public abstract string TargetHost
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000151")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000152")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public abstract X509Certificate ServerCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000153")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000154")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public abstract X509CertificateCollection ClientCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000155")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000156")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public abstract bool ClientCertificateRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000157")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000158")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		internal ServerCertSelectionCallback ServerCertSelectionDelegate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000159")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D3C0", Offset = "0x1D4D3C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4D3C8", Offset = "0x1D4D3C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MonoSslAuthenticationOptions()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000113")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;
	}
}
