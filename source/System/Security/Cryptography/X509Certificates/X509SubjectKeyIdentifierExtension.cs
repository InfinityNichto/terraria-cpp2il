using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000BF RID: 191
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	public sealed class X509SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x00003F8F File Offset: 0x0000218F
		[global::Cpp2ILInjected.Token(Token = "0x60006BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDE85C", Offset = "0x1EDE85C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509SubjectKeyIdentifierExtension()
		{
			throw null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00003F92 File Offset: 0x00002192
		[global::Cpp2ILInjected.Token(Token = "0x60006C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDE8F8", Offset = "0x1EDE8F8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "SubjectKeyIdentifierExtension", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
		{
			throw null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00003F95 File Offset: 0x00002195
		[global::Cpp2ILInjected.Token(Token = "0x60006C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDEB10", Offset = "0x1EDEB10", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical)
		{
			throw null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00003F98 File Offset: 0x00002198
		[global::Cpp2ILInjected.Token(Token = "0x60006C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDED24", Offset = "0x1EDED24", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "FromHex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
		{
			throw null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00003F9B File Offset: 0x0000219B
		[global::Cpp2ILInjected.Token(Token = "0x60006C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDEF5C", Offset = "0x1EDEF5C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
		{
			throw null;
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00003F9E File Offset: 0x0000219E
		[global::Cpp2ILInjected.Token(Token = "0x60006C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDEF68", Offset = "0x1EDEF68", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
		{
			throw null;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00003FA1 File Offset: 0x000021A1
		[global::Cpp2ILInjected.Token(Token = "0x17000177")]
		public string SubjectKeyIdentifier
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EDF2E4", Offset = "0x1EDF2E4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConvert), Member = "ToHex", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00003FA4 File Offset: 0x000021A4
		[global::Cpp2ILInjected.Token(Token = "0x60006C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF368", Offset = "0x1EDF368", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
			throw null;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00003FA7 File Offset: 0x000021A7
		[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF534", Offset = "0x1EDF534", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static byte FromHexChar(char c)
		{
			throw null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00003FAA File Offset: 0x000021AA
		[global::Cpp2ILInjected.Token(Token = "0x60006C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF57C", Offset = "0x1EDF57C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "FromHex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static byte FromHexChars(char c1, char c2)
		{
			throw null;
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00003FAD File Offset: 0x000021AD
		[global::Cpp2ILInjected.Token(Token = "0x60006C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDEE7C", Offset = "0x1EDEE7C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "FromHexChars", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static byte[] FromHex(string hex)
		{
			throw null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003FB0 File Offset: 0x000021B0
		[global::Cpp2ILInjected.Token(Token = "0x60006CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDE9C0", Offset = "0x1EDE9C0", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			throw null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00003FB3 File Offset: 0x000021B3
		[global::Cpp2ILInjected.Token(Token = "0x60006CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDECB8", Offset = "0x1EDECB8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PublicKey),
			typeof(X509SubjectKeyIdentifierHashAlgorithm),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal byte[] Encode()
		{
			throw null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00003FB6 File Offset: 0x000021B6
		[global::Cpp2ILInjected.Token(Token = "0x60006CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDF618", Offset = "0x1EDF618", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = "FormatUnkownData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal override string ToString(bool multiLine)
		{
			throw null;
		}

		// Token: 0x040003CF RID: 975
		[global::Cpp2ILInjected.Token(Token = "0x4000539")]
		internal const string oid = "2.5.29.14";

		// Token: 0x040003D0 RID: 976
		[global::Cpp2ILInjected.Token(Token = "0x400053A")]
		internal const string friendlyName = "Subject Key Identifier";

		// Token: 0x040003D1 RID: 977
		[global::Cpp2ILInjected.Token(Token = "0x400053B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _subjectKeyIdentifier;

		// Token: 0x040003D2 RID: 978
		[global::Cpp2ILInjected.Token(Token = "0x400053C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _ski;

		// Token: 0x040003D3 RID: 979
		[global::Cpp2ILInjected.Token(Token = "0x400053D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private AsnDecodeStatus _status;
	}
}
