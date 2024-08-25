using System;
using System.Collections;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Interface;
using Mono.Unity;

namespace Mono.Net.Security
{
	[global::Cpp2ILInjected.Token(Token = "0x200005F")]
	internal abstract class MobileTlsContext : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D446E8", Offset = "0x1D446E8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(MonoSslAuthenticationOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = "GetInternalValidator", MemberParameters = new object[]
		{
			typeof(SslStream),
			typeof(MobileTlsProvider),
			typeof(MonoTlsSettings)
		}, ReturnType = typeof(ChainValidationHelper))]
		protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		internal MobileAuthenticatedStream Parent
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000130")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D2D8", Offset = "0x1D4D2D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		public MonoTlsSettings Settings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000131")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D44F9C", Offset = "0x1D44F9C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000034")]
		public abstract bool IsAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000132")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		public bool IsServer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000133")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D2E0", Offset = "0x1D4D2E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000036")]
		internal string TargetHost
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000134")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D2E8", Offset = "0x1D4D2E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		protected string ServerName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000135")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D2F0", Offset = "0x1D4D2F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		protected bool AskForClientCertificate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000136")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D2F8", Offset = "0x1D4D2F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		protected X509CertificateCollection ClientCertificates
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000137")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D300", Offset = "0x1D4D300", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		public abstract void StartHandshake();

		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		public abstract bool ProcessHandshake();

		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		public abstract void FinishHandshake();

		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		internal X509Certificate LocalServerCertificate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600013B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D308", Offset = "0x1D4D308", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600013C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D4D310", Offset = "0x1D4D310", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		internal abstract X509Certificate LocalClientCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		public abstract X509Certificate2 RemoteCertificate
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600013F")]
		public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

		[global::Cpp2ILInjected.Token(Token = "0x6000140")]
		public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

		[global::Cpp2ILInjected.Token(Token = "0x6000141")]
		public abstract void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x6000142")]
		public abstract bool PendingRenegotiation();

		[global::Cpp2ILInjected.Token(Token = "0x6000143")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D452B8", Offset = "0x1D452B8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(UnityTls.unitytls_x509verify_result))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(X509Certificate),
			typeof(X509Chain)
		}, ReturnType = typeof(ValidationResult))]
		protected unsafe bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000144")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D462E4", Offset = "0x1D462E4", Length = "0x478")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_tlsctx*),
			typeof(byte*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509name*),
			typeof(IntPtr),
			typeof(UnityTls.unitytls_x509list_ref*),
			typeof(UnityTls.unitytls_key_ref*),
			typeof(UnityTls.unitytls_errorstate*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "get_ChainPolicy", ReturnType = typeof(X509ChainPolicy))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainPolicy), Member = "set_RevocationMode", MemberParameters = new object[] { typeof(X509RevocationMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainPolicy), Member = "set_VerificationFlags", MemberParameters = new object[] { typeof(X509VerificationFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "Build", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(X509ChainElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Chain), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AlertDescription),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		protected unsafe X509Certificate SelectClientCertificate(string[] acceptableIssuers)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000145")]
		public abstract void Renegotiate();

		[global::Cpp2ILInjected.Token(Token = "0x6000146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4B8D8", Offset = "0x1D4B8D8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileAuthenticatedStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000147")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4D318", Offset = "0x1D4D318", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000148")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D4D31C", Offset = "0x1D4D31C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000109")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ChainValidationHelper certificateValidator;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly MonoSslAuthenticationOptions <Options>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly MobileAuthenticatedStream <Parent>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly bool <IsServer>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly string <TargetHost>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly string <ServerName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly bool <AskForClientCertificate>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private readonly SslProtocols <EnabledProtocols>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000111")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly X509CertificateCollection <ClientCertificates>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000112")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private X509Certificate <LocalServerCertificate>k__BackingField;
	}
}
