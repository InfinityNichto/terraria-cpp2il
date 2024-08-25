using System;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	[global::Cpp2ILInjected.Token(Token = "0x20005F5")]
	[global::System.Serializable]
	public abstract class CollectionBase : IList, ICollection, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002DFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08AE0", Offset = "0x1C08AE0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = ".ctor", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2Collection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509CertificateCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509CertificateCollection", Member = ".ctor", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509CertificateCollection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "get_Roots", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "get_CertificateAuthorities", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "get_CertificateCollection", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainPolicy", Member = "get_ExtraStore", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaObjectCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaSequence", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaSimpleTypeRestriction", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509CertificateBuilder", Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509CertificateCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509CertificateCollection", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509CertificateCollection", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.X509.X509CertificateCollection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Chain", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Chain", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.X509.X509CertificateCollection" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "get_TrustAnchors", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "Build", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509ExtensionCollection", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509ExtensionCollection", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "BuildCertificatesCollection", MemberParameters = new object[] { typeof(string) }, ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_IntermediateCACertificates", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_TrustedRootCertificates", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509StoreManager", Member = "get_UntrustedCertificates", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected CollectionBase()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000719")]
		protected ArrayList InnerList
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08BD0", Offset = "0x1C08BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700071A")]
		protected IList List
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DFD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08BD8", Offset = "0x1C08BD8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlSchemaObjectCollection", Member = "Add", MemberParameters = new object[] { "System.Xml.Schema.XmlSchemaObject" }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700071B")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002DFE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08BDC", Offset = "0x1C08BDC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.UnityTlsProvider", Member = "ValidateCertificate", MemberParameters = new object[]
			{
				"Mono.Net.Security.ChainValidationHelper",
				typeof(string),
				typeof(bool),
				"System.Security.Cryptography.X509Certificates.X509CertificateCollection",
				typeof(bool),
				"System.Security.Cryptography.X509Certificates.X509Chain&",
				"System.Net.Security.SslPolicyErrors&",
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = "DefaultSelectionCallback", MemberParameters = new object[]
			{
				typeof(string),
				"System.Security.Cryptography.X509Certificates.X509CertificateCollection",
				typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate),
				"System.String[]"
			}, ReturnType = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileTlsContext", Member = "SelectClientCertificate", MemberParameters = new object[] { "System.String[]" }, ReturnType = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new object[]
			{
				"System.Byte[]",
				typeof(string)
			}, ReturnType = "Mono.Security.X509.X509Certificate")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "SelectBestFromCollection", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2", "System.Security.Cryptography.X509Certificates.X509Certificate2Collection" }, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl.X509CrlEntry", Member = "GetBytes", ReturnType = "System.Byte[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509CertificateBuilder", Member = "ToBeSigned", MemberParameters = new object[] { typeof(string) }, ReturnType = "Mono.Security.ASN1")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "Build", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002DFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08BF0", Offset = "0x1C08BF0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "get_Certificates", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Store", Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "get_Certificates", ReturnType = "Mono.Security.X509.X509CertificateCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Chain", Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "ClearCertificates", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "Import", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "Remove", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "ImportNewFormat", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "RemoveNewFormat", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E00")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08C34", Offset = "0x1C08C34", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700071C")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08DEC", Offset = "0x1C08DEC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700071D")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E02")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08E00", Offset = "0x1C08E00", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700071E")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E03")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08E14", Offset = "0x1C08E14", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700071F")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E04")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08E28", Offset = "0x1C08E28", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C08E3C", Offset = "0x1C08E3C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000720")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002E06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08E50", Offset = "0x1C08E50", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002E07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C08EFC", Offset = "0x1C08EFC", Length = "0x1C8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C090C4", Offset = "0x1C090C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C090D8", Offset = "0x1C090D8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09200", Offset = "0x1C09200", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09380", Offset = "0x1C09380", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09394", Offset = "0x1C09394", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0952C", Offset = "0x1C0952C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "ProcessCrlExtensions", MemberParameters = new object[] { "Mono.Security.X509.X509Crl" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "ProcessCrlEntryExtensions", MemberParameters = new object[] { "Mono.Security.X509.X509Crl.X509CrlEntry" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09540", Offset = "0x1C09540", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnSet(int index, object oldValue, object newValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09544", Offset = "0x1C09544", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnInsert(int index, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09548", Offset = "0x1C09548", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnClear()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C0954C", Offset = "0x1C0954C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnRemove(int index, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C09550", Offset = "0x1C09550", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual void OnValidate(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C095A4", Offset = "0x1C095A4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnSetComplete(int index, object oldValue, object newValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C095A8", Offset = "0x1C095A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnInsertComplete(int index, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C095AC", Offset = "0x1C095AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnClearComplete()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002E16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C095B0", Offset = "0x1C095B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void OnRemoveComplete(int index, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40019B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ArrayList _list;
	}
}
