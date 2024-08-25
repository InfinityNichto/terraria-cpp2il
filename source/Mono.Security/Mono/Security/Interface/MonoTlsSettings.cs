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
	[global::Cpp2ILInjected.Token(Token = "0x200004E")]
	public sealed class MonoTlsSettings
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600021C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9B7DC", Offset = "0x1A9B7DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MonoTlsSettings()
		{
			throw null;
		}

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

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400022F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DateTime? <CertificateValidationTime>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000230")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private X509CertificateCollection <TrustAnchors>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000231")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object <UserSettings>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000232")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string[] <CertificateSearchPaths>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000233")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool <SendCloseNotify>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000234")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string[] <ClientCertificateIssuers>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000235")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000236")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private TlsProtocols? <EnabledProtocols>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000237")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private CipherSuiteCode[] <EnabledCiphers>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000238")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool cloned;

		[global::Cpp2ILInjected.Token(Token = "0x4000239")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool checkCertName;

		[global::Cpp2ILInjected.Token(Token = "0x400023A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		private bool checkCertRevocationStatus;

		[global::Cpp2ILInjected.Token(Token = "0x400023B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x73")]
		private bool? useServicePointManagerCallback;

		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x75")]
		private bool skipSystemValidators;

		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x76")]
		private bool callbackNeedsChain;

		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private ICertificateValidator certificateValidator;

		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		private static MonoTlsSettings defaultSettings;
	}
}
