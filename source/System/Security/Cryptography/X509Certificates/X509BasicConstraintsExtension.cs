using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000A7 RID: 167
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	public sealed class X509BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00003C9E File Offset: 0x00001E9E
		[global::Cpp2ILInjected.Token(Token = "0x60005AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED1854", Offset = "0x1ED1854", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(X509Extension))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509BasicConstraintsExtension()
		{
			throw null;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00003CA1 File Offset: 0x00001EA1
		[global::Cpp2ILInjected.Token(Token = "0x60005AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED04D0", Offset = "0x1ED04D0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "BasicConstraintsExtension", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
		{
			throw null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00003CA4 File Offset: 0x00001EA4
		[global::Cpp2ILInjected.Token(Token = "0x60005AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED1A9C", Offset = "0x1ED1A9C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509Extension), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = "Encode", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
		{
			throw null;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00003CA7 File Offset: 0x00001EA7
		[global::Cpp2ILInjected.Token(Token = "0x17000117")]
		public bool CertificateAuthority
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED1D04", Offset = "0x1ED1D04", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00003CAA File Offset: 0x00001EAA
		[global::Cpp2ILInjected.Token(Token = "0x17000118")]
		public bool HasPathLengthConstraint
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED1D6C", Offset = "0x1ED1D6C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00003CAD File Offset: 0x00001EAD
		[global::Cpp2ILInjected.Token(Token = "0x17000119")]
		public int PathLengthConstraint
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED1DD4", Offset = "0x1ED1DD4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00003CB0 File Offset: 0x00001EB0
		[global::Cpp2ILInjected.Token(Token = "0x60005B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED1E3C", Offset = "0x1ED1E3C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X509BasicConstraintsExtension), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(AsnDecodeStatus))]
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

		// Token: 0x0600050E RID: 1294 RVA: 0x00003CB3 File Offset: 0x00001EB3
		[global::Cpp2ILInjected.Token(Token = "0x60005B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED18F4", Offset = "0x1ED18F4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AsnEncodedData),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = "CopyFrom", MemberParameters = new object[] { typeof(AsnEncodedData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			throw null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00003CB6 File Offset: 0x00001EB6
		[global::Cpp2ILInjected.Token(Token = "0x60005B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED1BD0", Offset = "0x1ED1BD0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1Convert), Member = "FromInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal byte[] Encode()
		{
			throw null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00003CB9 File Offset: 0x00001EB9
		[global::Cpp2ILInjected.Token(Token = "0x60005B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED2004", Offset = "0x1ED2004", Length = "0x288")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal override string ToString(bool multiLine)
		{
			throw null;
		}

		// Token: 0x04000386 RID: 902
		[global::Cpp2ILInjected.Token(Token = "0x40004EF")]
		internal const string oid = "2.5.29.19";

		// Token: 0x04000387 RID: 903
		[global::Cpp2ILInjected.Token(Token = "0x40004F0")]
		internal const string friendlyName = "Basic Constraints";

		// Token: 0x04000388 RID: 904
		[global::Cpp2ILInjected.Token(Token = "0x40004F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool _certificateAuthority;

		// Token: 0x04000389 RID: 905
		[global::Cpp2ILInjected.Token(Token = "0x40004F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x22")]
		private bool _hasPathLengthConstraint;

		// Token: 0x0400038A RID: 906
		[global::Cpp2ILInjected.Token(Token = "0x40004F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _pathLengthConstraint;

		// Token: 0x0400038B RID: 907
		[global::Cpp2ILInjected.Token(Token = "0x40004F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AsnDecodeStatus _status;
	}
}
