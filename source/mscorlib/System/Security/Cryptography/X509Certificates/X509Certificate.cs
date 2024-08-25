using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x2000322")]
	[global::System.Serializable]
	public class X509Certificate : global::System.IDisposable, global::System.Runtime.Serialization.IDeserializationCallback, global::System.Runtime.Serialization.ISerializable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001B0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D018", Offset = "0x1B1D018", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509CertificateImpl), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D13C", Offset = "0x1B1D13C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509Certificate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D1B0", Offset = "0x1B1D1B0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePoint", Member = "get_Certificate", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.ServicePoint", Member = "get_ClientCertificate", ReturnType = typeof(X509Certificate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "ImportNewFormat", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Store", Member = "RemoveNewFormat", MemberParameters = new object[] { "Mono.Security.X509.X509Certificate" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "Import", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(X509CertificateImpl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public X509Certificate(byte[] data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D2F0", Offset = "0x1B1D2F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Unity.CertHelper", Member = "AddCertificateToNativeChain", MemberParameters = new object[]
		{
			"unitytls_x509list*",
			typeof(X509Certificate),
			"unitytls_errorstate*"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2Impl" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal X509Certificate(X509CertificateImpl impl)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D3A8", Offset = "0x1B1D3A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public X509Certificate(string fileName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D3B4", Offset = "0x1B1D3B4", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "ValidateKeyStorageFlags", MemberParameters = new object[] { typeof(X509KeyStorageFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.File), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "Import", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Microsoft.Win32.SafeHandles.SafePasswordHandle),
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(X509CertificateImpl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public X509Certificate(string fileName, string password, X509KeyStorageFlags keyStorageFlags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D7E0", Offset = "0x1B1D7E0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainPolicy", Member = "get_ExtraStore", ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "InitFromCertificate", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(X509CertificateImpl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public X509Certificate(X509Certificate cert)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D964", Offset = "0x1B1D964", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509Certificate(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D9A0", Offset = "0x1B1D9A0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D9D8", Offset = "0x1B1D9D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FE")]
		public string Issuer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1DA10", Offset = "0x1B1DA10", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "Equals", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.MobileTlsContext", Member = "SelectClientCertificate", MemberParameters = new object[] { "System.String[]" }, ReturnType = typeof(X509Certificate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
			{
				"System.Security.Cryptography.X509Certificates.X509FindType",
				typeof(object),
				typeof(bool)
			}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "FindParent", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2" }, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsSelfIssued", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002FF")]
		public string Subject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1DA64", Offset = "0x1B1DA64", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
			{
				"System.Security.Cryptography.X509Certificates.X509FindType",
				typeof(object),
				typeof(bool)
			}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsSelfIssued", MemberParameters = new object[] { "System.Security.Cryptography.X509Certificates.X509Certificate2" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DAB0", Offset = "0x1B1DAB0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DAC0", Offset = "0x1B1DAC0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DAD4", Offset = "0x1B1DAD4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DB68", Offset = "0x1B1DB68", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetRawSerialNumber", ReturnType = typeof(byte[]))]
		public virtual bool Equals(X509Certificate other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DC7C", Offset = "0x1B1DC7C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetRawCertHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		public virtual byte[] GetCertHash()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DCE4", Offset = "0x1B1DCE4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetRawCertHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "ToHexStringUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		public virtual string GetCertHashString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DCA0", Offset = "0x1B1DCA0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetCertHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetCertHashString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] GetRawCertHash()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DD08", Offset = "0x1B1DD08", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		public virtual byte[] GetRawCertData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DD34", Offset = "0x1B1DD34", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetRawCertHash", ReturnType = typeof(byte[]))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DD94", Offset = "0x1B1DD94", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual string GetKeyAlgorithm()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DDE4", Offset = "0x1B1DDE4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] GetKeyAlgorithmParameters()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DE38", Offset = "0x1B1DE38", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual byte[] GetPublicKey()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DE8C", Offset = "0x1B1DE8C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetRawSerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Reverse", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual byte[] GetSerialNumber()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DEF4", Offset = "0x1B1DEF4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetRawSerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "ToHexStringUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		public virtual string GetSerialNumberString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DC34", Offset = "0x1B1DC34", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "Equals", MemberParameters = new object[] { typeof(X509Certificate) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "GetSerialNumberString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] GetRawSerialNumber()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DF18", Offset = "0x1B1DF18", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DF2C", Offset = "0x1B1DF2C", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "AppendLine", ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Reverse", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "ToHexArrayUpper", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new object[] { typeof(global::System.DateTime) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Certificate), Member = "GetRawCertHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual string ToString(bool fVerbose)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E410", Offset = "0x1B1E410", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_NotAfter", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.DateTime GetNotAfter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E27C", Offset = "0x1B1E27C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_NotBefore", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection", Member = "Find", MemberParameters = new object[]
		{
			"System.Security.Cryptography.X509Certificates.X509FindType",
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.Security.Cryptography.X509Certificates.X509Certificate2Collection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.DateTime GetNotBefore()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E310", Offset = "0x1B1E310", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Month", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "get_Day", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DateTime), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected static string FormatDate(global::System.DateTime date)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1D614", Offset = "0x1B1D614", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(X509KeyStorageFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1E4A4", Offset = "0x1B1E4A4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = ".ctor", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void ImportHandle(X509CertificateImpl impl)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000300")]
		internal X509CertificateImpl Impl
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1E4D4", Offset = "0x1B1E4D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000301")]
		internal bool IsValid
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1E4DC", Offset = "0x1B1E4DC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001B2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1DA5C", Offset = "0x1B1DA5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Extensions", ReturnType = "System.Security.Cryptography.X509Certificates.X509ExtensionCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_IssuerName", ReturnType = "System.Security.Cryptography.X509Certificates.X500DistinguishedName")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_PublicKey", ReturnType = "System.Security.Cryptography.X509Certificates.PublicKey")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_RawData", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_SignatureAlgorithm", ReturnType = "System.Security.Cryptography.Oid")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_SubjectName", ReturnType = "System.Security.Cryptography.X509Certificates.X500DistinguishedName")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2", Member = "get_Version", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Helper), Member = "ThrowIfContextInvalid", MemberParameters = new object[] { typeof(X509CertificateImpl) }, ReturnType = typeof(void))]
		internal void ThrowIfInvalid()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000DD5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private X509CertificateImpl impl;

		[global::Cpp2ILInjected.Token(Token = "0x4000DD6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] lazyCertHash;

		[global::Cpp2ILInjected.Token(Token = "0x4000DD7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] lazySerialNumber;

		[global::Cpp2ILInjected.Token(Token = "0x4000DD8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string lazyIssuer;

		[global::Cpp2ILInjected.Token(Token = "0x4000DD9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string lazySubject;

		[global::Cpp2ILInjected.Token(Token = "0x4000DDA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string lazyKeyAlgorithm;

		[global::Cpp2ILInjected.Token(Token = "0x4000DDB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private byte[] lazyKeyAlgorithmParameters;

		[global::Cpp2ILInjected.Token(Token = "0x4000DDC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] lazyPublicKey;

		[global::Cpp2ILInjected.Token(Token = "0x4000DDD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.DateTime lazyNotBefore;

		[global::Cpp2ILInjected.Token(Token = "0x4000DDE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.DateTime lazyNotAfter;
	}
}
