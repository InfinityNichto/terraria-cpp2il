using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Authenticode;
using Mono.Security.Cryptography;
using Mono.Security.X509;
using Mono.Security.X509.Extensions;

namespace Mono.Security
{
	// Token: 0x02000004 RID: 4
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public static class ASN1Convert
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002F7F File Offset: 0x0000117F
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A792E0", Offset = "0x1A792E0", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl.X509CrlEntry), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "ToBeSigned", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Year", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ASN1 FromDateTime(DateTime dt)
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002F82 File Offset: 0x00001182
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7946C", Offset = "0x1A7946C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "EncryptedContentInfo", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(string)
		}, ReturnType = typeof(PKCS7.ContentInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicConstraintsExtension), Member = "Encode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "GetUIntBytes", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "set_Value", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe static ASN1 FromInt32(int value)
		{
			throw null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002F85 File Offset: 0x00001185
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A795D0", Offset = "0x1A795D0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7.ContentInfo), Member = "GetASN1", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7), Member = "AlgorithmIdentifier", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS7), Member = "AlgorithmIdentifier", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ASN1)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Pkcs8ShroudedKeyBagSafeBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "KeyBagSafeBag", MemberParameters = new object[]
		{
			typeof(AsymmetricAlgorithm),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "SecretBagSafeBag", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "CertificateSafeBag", MemberParameters = new object[]
		{
			typeof(Mono.Security.X509.X509Certificate),
			typeof(IDictionary)
		}, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "EncryptedContentInfo", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(string)
		}, ReturnType = typeof(PKCS7.ContentInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "IsOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.X509.X509Extension), Member = "get_ASN1", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X520.AttributeTypeAndValue), Member = "GetASN1", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static ASN1 FromOid(string oid)
		{
			throw null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002F88 File Offset: 0x00001188
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A796AC", Offset = "0x1A796AC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509CertificateBuilder), Member = "SubjectPublicKeyInfo", ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(RSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.PrivateKeyInfo), Member = "Encode", MemberParameters = new object[] { typeof(DSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static ASN1 FromUnsignedBigInteger(byte[] big)
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002F8B File Offset: 0x0000118B
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A797B4", Offset = "0x1A797B4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = "System.Security.Cryptography.AsnDecodeStatus")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS12), Member = "Decrypt", MemberParameters = new object[] { typeof(PKCS7.EncryptedData) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicConstraintsExtension), Member = "Decode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS8.EncryptedPrivateKeyInfo), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static int ToInt32(ASN1 asn1)
		{
			throw null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002F8E File Offset: 0x0000118E
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A798B8", Offset = "0x1A798B8", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static string ToOid(ASN1 asn1)
		{
			throw null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002F91 File Offset: 0x00001191
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A79B20", Offset = "0x1A79B20", Length = "0x4F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl.X509CrlEntry), Member = ".ctor", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Crl), Member = "Parse", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.X509.X509Certificate), Member = "Parse", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "VerifyCounterSignature", MemberParameters = new object[]
		{
			typeof(PKCS7.SignerInfo),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ParseExact", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(IFormatProvider),
			typeof(DateTimeStyles)
		}, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		public static DateTime ToDateTime(ASN1 time)
		{
			throw null;
		}
	}
}
