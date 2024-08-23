using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Interface
{
	// Token: 0x02000033 RID: 51
	[global::Cpp2ILInjected.Token(Token = "0x200004E")]
	public sealed class MonoTlsSettings
	{
		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00003423 File Offset: 0x00001623
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00003426 File Offset: 0x00001626
		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000203")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B708", Offset = "0x1A9B708", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000204")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B710", Offset = "0x1A9B710", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00003429 File Offset: 0x00001629
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000342C File Offset: 0x0000162C
		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000205")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B718", Offset = "0x1A9B718", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000206")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B720", Offset = "0x1A9B720", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000342F File Offset: 0x0000162F
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00003432 File Offset: 0x00001632
		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		public bool? UseServicePointManagerCallback
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000207")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B728", Offset = "0x1A9B728", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000208")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B730", Offset = "0x1A9B730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00003435 File Offset: 0x00001635
		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		public bool CallbackNeedsCertificateChain
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000209")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B738", Offset = "0x1A9B738", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000343B File Offset: 0x0000163B
		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		public DateTime? CertificateValidationTime
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600020A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B740", Offset = "0x1A9B740", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600020B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B74C", Offset = "0x1A9B74C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000343E File Offset: 0x0000163E
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00003441 File Offset: 0x00001641
		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		public X509CertificateCollection TrustAnchors
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600020C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B754", Offset = "0x1A9B754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600020D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B75C", Offset = "0x1A9B75C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00003444 File Offset: 0x00001644
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00003447 File Offset: 0x00001647
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		public object UserSettings
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600020E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B764", Offset = "0x1A9B764", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600020F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B76C", Offset = "0x1A9B76C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000344A File Offset: 0x0000164A
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000344D File Offset: 0x0000164D
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		internal string[] CertificateSearchPaths
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000210")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B774", Offset = "0x1A9B774", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000211")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B77C", Offset = "0x1A9B77C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00003450 File Offset: 0x00001650
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00003453 File Offset: 0x00001653
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		internal bool SendCloseNotify
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B784", Offset = "0x1A9B784", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000213")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B78C", Offset = "0x1A9B78C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00003456 File Offset: 0x00001656
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00003459 File Offset: 0x00001659
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		public string[] ClientCertificateIssuers
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000214")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B798", Offset = "0x1A9B798", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000215")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7A0", Offset = "0x1A9B7A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000345C File Offset: 0x0000165C
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000345F File Offset: 0x0000165F
		[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
		public bool DisallowUnauthenticatedCertificateRequest
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000216")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7A8", Offset = "0x1A9B7A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000217")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7B0", Offset = "0x1A9B7B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00003462 File Offset: 0x00001662
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00003465 File Offset: 0x00001665
		[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
		public TlsProtocols? EnabledProtocols
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000218")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7BC", Offset = "0x1A9B7BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000219")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7C4", Offset = "0x1A9B7C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00003468 File Offset: 0x00001668
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000346B File Offset: 0x0000166B
		[CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
		public CipherSuiteCode[] EnabledCiphers
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600021A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7CC", Offset = "0x1A9B7CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600021B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7D4", Offset = "0x1A9B7D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000346E File Offset: 0x0000166E
		[global::Cpp2ILInjected.Token(Token = "0x600021C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B7DC", Offset = "0x1A9B7DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MonoTlsSettings()
		{
			throw null;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00003471 File Offset: 0x00001671
		[global::Cpp2ILInjected.Token(Token = "0x170000A9")]
		public static MonoTlsSettings DefaultSettings
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B7F0", Offset = "0x1A9B7F0", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(bool),
				typeof(RemoteCertificateValidationCallback)
			}, ReturnType = typeof(SslStream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00003474 File Offset: 0x00001674
		[global::Cpp2ILInjected.Token(Token = "0x600021E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B87C", Offset = "0x1A9B87C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SslStream),
			"Mono.Net.Security.MobileTlsProvider",
			typeof(MonoTlsSettings),
			typeof(bool),
			"Mono.Net.Security.MonoTlsStream"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback),
			typeof(LocalCertificateSelectionCallback)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = "get_DefaultSettings", ReturnType = typeof(MonoTlsSettings))]
		public static MonoTlsSettings CopyDefaultSettings()
		{
			throw null;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00003477 File Offset: 0x00001677
		[Obsolete("Do not use outside System.dll!")]
		[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
		public ICertificateValidator CertificateValidator
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9B8E4", Offset = "0x1A9B8E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000347A File Offset: 0x0000167A
		[Obsolete("Do not use outside System.dll!")]
		[global::Cpp2ILInjected.Token(Token = "0x6000220")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B8EC", Offset = "0x1A9B8EC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(SslStream),
			"Mono.Net.Security.MobileTlsProvider",
			typeof(MonoTlsSettings),
			typeof(bool),
			"Mono.Net.Security.MonoTlsStream"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new object[] { typeof(MonoTlsSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
		{
			throw null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000347D File Offset: 0x0000167D
		[global::Cpp2ILInjected.Token(Token = "0x6000221")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B88C", Offset = "0x1A9B88C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "CreateSslStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(RemoteCertificateValidationCallback)
		}, ReturnType = typeof(SslStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(MonoTlsProvider),
			typeof(MonoTlsSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new object[] { typeof(MonoTlsSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MonoTlsSettings Clone()
		{
			throw null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00003480 File Offset: 0x00001680
		[global::Cpp2ILInjected.Token(Token = "0x6000222")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B964", Offset = "0x1A9B964", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsSettings), Member = "CloneWithValidator", MemberParameters = new object[] { typeof(ICertificateValidator) }, ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoTlsSettings), Member = "Clone", ReturnType = typeof(MonoTlsSettings))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = ".ctor", MemberParameters = new object[] { typeof(X509CertificateCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private MonoTlsSettings(MonoTlsSettings other)
		{
			throw null;
		}

		// Token: 0x04000200 RID: 512
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField;

		// Token: 0x04000201 RID: 513
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField;

		// Token: 0x04000202 RID: 514
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DateTime? <CertificateValidationTime>k__BackingField;

		// Token: 0x04000203 RID: 515
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000230")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private X509CertificateCollection <TrustAnchors>k__BackingField;

		// Token: 0x04000204 RID: 516
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000231")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object <UserSettings>k__BackingField;

		// Token: 0x04000205 RID: 517
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000232")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string[] <CertificateSearchPaths>k__BackingField;

		// Token: 0x04000206 RID: 518
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000233")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool <SendCloseNotify>k__BackingField;

		// Token: 0x04000207 RID: 519
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000234")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string[] <ClientCertificateIssuers>k__BackingField;

		// Token: 0x04000208 RID: 520
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000235")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField;

		// Token: 0x04000209 RID: 521
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000236")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private TlsProtocols? <EnabledProtocols>k__BackingField;

		// Token: 0x0400020A RID: 522
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000237")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private CipherSuiteCode[] <EnabledCiphers>k__BackingField;

		// Token: 0x0400020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x4000238")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool cloned;

		// Token: 0x0400020C RID: 524
		[global::Cpp2ILInjected.Token(Token = "0x4000239")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool checkCertName;

		// Token: 0x0400020D RID: 525
		[global::Cpp2ILInjected.Token(Token = "0x400023A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		private bool checkCertRevocationStatus;

		// Token: 0x0400020E RID: 526
		[global::Cpp2ILInjected.Token(Token = "0x400023B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x73")]
		private bool? useServicePointManagerCallback;

		// Token: 0x0400020F RID: 527
		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x75")]
		private bool skipSystemValidators;

		// Token: 0x04000210 RID: 528
		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x76")]
		private bool callbackNeedsChain;

		// Token: 0x04000211 RID: 529
		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ICertificateValidator certificateValidator;

		// Token: 0x04000212 RID: 530
		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		private static MonoTlsSettings defaultSettings;
	}
}
