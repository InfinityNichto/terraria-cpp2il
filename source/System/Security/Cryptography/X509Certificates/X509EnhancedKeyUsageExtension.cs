using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000B8 RID: 184
	[global::Cpp2ILInjected.Token(Token = "0x2000116")]
	public sealed class X509EnhancedKeyUsageExtension : X509Extension
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x00003EF6 File Offset: 0x000020F6
		[global::Cpp2ILInjected.Token(Token = "0x600068C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDBDD8", Offset = "0x1EDBDD8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509EnhancedKeyUsageExtension()
		{
			throw null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00003EF9 File Offset: 0x000020F9
		[global::Cpp2ILInjected.Token(Token = "0x600068D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDBE7C", Offset = "0x1EDBE7C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "EnhancedKeyUsageExtension", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509EnhancedKeyUsageExtension(AsnEncodedData encodedEnhancedKeyUsages, bool critical)
		{
			throw null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00003EFC File Offset: 0x000020FC
		[global::Cpp2ILInjected.Token(Token = "0x600068E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDC170", Offset = "0x1EDC170", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "GetEnumerator", ReturnType = typeof(OidEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidEnumerator), Member = "get_Current", ReturnType = typeof(Oid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "Add", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public X509EnhancedKeyUsageExtension(OidCollection enhancedKeyUsages, bool critical)
		{
			throw null;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00003EFF File Offset: 0x000020FF
		[global::Cpp2ILInjected.Token(Token = "0x600068F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDC3A4", Offset = "0x1EDC3A4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
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

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003F02 File Offset: 0x00002102
		[global::Cpp2ILInjected.Token(Token = "0x6000690")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDBF44", Offset = "0x1EDBF44", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "Add", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			throw null;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00003F05 File Offset: 0x00002105
		[global::Cpp2ILInjected.Token(Token = "0x6000691")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDC2F4", Offset = "0x1EDC2F4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(OidCollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "GetEnumerator", ReturnType = typeof(OidEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidEnumerator), Member = "get_Current", ReturnType = typeof(Oid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromOid", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal byte[] Encode()
		{
			throw null;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00003F08 File Offset: 0x00002108
		[global::Cpp2ILInjected.Token(Token = "0x6000692")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EDC570", Offset = "0x1EDC570", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OidCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Oid))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal override string ToString(bool multiLine)
		{
			throw null;
		}

		// Token: 0x040003BF RID: 959
		[global::Cpp2ILInjected.Token(Token = "0x4000529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private OidCollection _enhKeyUsage;

		// Token: 0x040003C0 RID: 960
		[global::Cpp2ILInjected.Token(Token = "0x400052A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private AsnDecodeStatus _status;
	}
}
