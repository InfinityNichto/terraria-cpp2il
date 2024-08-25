using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography.X509Certificates
{
	[global::Cpp2ILInjected.Token(Token = "0x2000108")]
	internal abstract class X509Certificate2Impl : X509CertificateImpl
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		public abstract IEnumerable<X509Extension> Extensions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E1")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012C")]
		public abstract X500DistinguishedName IssuerName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E2")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012D")]
		public abstract AsymmetricAlgorithm PrivateKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012E")]
		public abstract string SignatureAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700012F")]
		public abstract X500DistinguishedName SubjectName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000130")]
		public abstract int Version
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E7")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000131")]
		internal abstract X509CertificateImplCollection IntermediateCertificates
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005E8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005E9")]
		public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

		[global::Cpp2ILInjected.Token(Token = "0x60005EA")]
		public abstract bool Verify(X509Certificate2 thisCertificate);

		[global::Cpp2ILInjected.Token(Token = "0x60005EB")]
		public abstract void AppendPrivateKeyInfo(StringBuilder sb);

		[global::Cpp2ILInjected.Token(Token = "0x60005EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED58EC", Offset = "0x1ED58EC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public sealed override X509CertificateImpl CopyWithPrivateKey(RSA privateKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60005ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED5998", Offset = "0x1ED5998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = ".ctor", ReturnType = typeof(void))]
		protected X509Certificate2Impl()
		{
			throw null;
		}
	}
}
