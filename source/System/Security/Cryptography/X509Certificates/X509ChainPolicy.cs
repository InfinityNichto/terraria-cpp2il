using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Net.Security;
using Mono.Unity;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x2000114")]
	public sealed class X509ChainPolicy
	{
		[global::Cpp2ILInjected.Token(Token = "0x600067E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED8FF4", Offset = "0x1ED8FF4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplUnityTls), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(UnityTls.unitytls_x509list_ref),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509ChainPolicy), Member = "Reset", ReturnType = typeof(void))]
		public X509ChainPolicy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000165")]
		public X509Certificate2Collection ExtraStore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600067F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED9DD0", Offset = "0x1ED9DD0", Length = "0x240")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateCollection.X509CertificateEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateCollection.X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate2Collection), Member = "Add", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000166")]
		public X509RevocationFlag RevocationFlag
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000680")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBCE0", Offset = "0x1EDBCE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000167")]
		public X509RevocationMode RevocationMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000681")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBCE8", Offset = "0x1EDBCE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000682")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBCF0", Offset = "0x1EDBCF0", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000168")]
		public X509VerificationFlags VerificationFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000683")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBD50", Offset = "0x1EDBD50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000684")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBD58", Offset = "0x1EDBD58", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000169")]
		public DateTime VerificationTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000685")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDBDB8", Offset = "0x1EDBDB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000686")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDBBF8", Offset = "0x1EDBBF8", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400051E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private OidCollection apps;

		[global::Cpp2ILInjected.Token(Token = "0x400051F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private OidCollection cert;

		[global::Cpp2ILInjected.Token(Token = "0x4000520")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private X509CertificateCollection store;

		[global::Cpp2ILInjected.Token(Token = "0x4000521")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private X509Certificate2Collection store2;

		[global::Cpp2ILInjected.Token(Token = "0x4000522")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private X509RevocationFlag rflag;

		[global::Cpp2ILInjected.Token(Token = "0x4000523")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private X509RevocationMode mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private TimeSpan timeout;

		[global::Cpp2ILInjected.Token(Token = "0x4000525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private X509VerificationFlags vflags;

		[global::Cpp2ILInjected.Token(Token = "0x4000526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private DateTime vtime;
	}
}
