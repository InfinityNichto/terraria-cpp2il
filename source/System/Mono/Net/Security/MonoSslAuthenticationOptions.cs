using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x0200001E RID: 30
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	internal abstract class MonoSslAuthenticationOptions
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DB RID: 219
		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public abstract bool ServerMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014C")]
			get;
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DC RID: 220
		// (set) Token: 0x060000DD RID: 221
		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public abstract SslProtocols EnabledSslProtocols
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014D")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600014E")]
			set;
		}

		// Token: 0x1700003F RID: 63
		// (set) Token: 0x060000DE RID: 222
		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		public abstract EncryptionPolicy EncryptionPolicy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014F")]
			set;
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x060000DF RID: 223
		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		public abstract X509RevocationMode CertificateRevocationCheckMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000150")]
			set;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000E0 RID: 224
		// (set) Token: 0x060000E1 RID: 225
		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public abstract string TargetHost
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000151")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000152")]
			set;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000E2 RID: 226
		// (set) Token: 0x060000E3 RID: 227
		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public abstract X509Certificate ServerCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000153")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000154")]
			set;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000E4 RID: 228
		// (set) Token: 0x060000E5 RID: 229
		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public abstract X509CertificateCollection ClientCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000155")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000156")]
			set;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000E6 RID: 230
		// (set) Token: 0x060000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public abstract bool ClientCertificateRequired
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000157")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000158")]
			set;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003092 File Offset: 0x00001292
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

		// Token: 0x060000E9 RID: 233 RVA: 0x00003095 File Offset: 0x00001295
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4D3C8", Offset = "0x1D4D3C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MonoSslAuthenticationOptions()
		{
			throw null;
		}

		// Token: 0x04000058 RID: 88
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000113")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField;
	}
}
