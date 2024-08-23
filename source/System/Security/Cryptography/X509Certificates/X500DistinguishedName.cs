using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography.Pal;
using Mono.Security;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x020000A6 RID: 166
	[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
	[global::Cpp2ILInjected.Token(Token = "0x2000103")]
	public sealed class X500DistinguishedName : AsnEncodedData
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x00003C86 File Offset: 0x00001E86
		[global::Cpp2ILInjected.Token(Token = "0x60005A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED10E8", Offset = "0x1ED10E8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_Oid", MemberParameters = new object[] { typeof(Oid) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsnEncodedData), Member = "set_RawData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public X500DistinguishedName(byte[] encodedDistinguishedName)
		{
			throw null;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00003C89 File Offset: 0x00001E89
		[global::Cpp2ILInjected.Token(Token = "0x17000116")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60005A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ED12DC", Offset = "0x1ED12DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00003C8C File Offset: 0x00001E8C
		[global::Cpp2ILInjected.Token(Token = "0x60005A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED12E4", Offset = "0x1ED12E4", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X500DistinguishedName), Member = "Format", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X500DistinguishedName), Member = "AreEqual", MemberParameters = new object[]
		{
			typeof(X500DistinguishedName),
			typeof(X500DistinguishedName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new object[] { typeof(X509Certificate2) }, ReturnType = typeof(X509Crl))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X500DistinguishedName), Member = "GetSeparator", MemberParameters = new object[] { typeof(X500DistinguishedNameFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(bool),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string Decode(X500DistinguishedNameFlags flag)
		{
			throw null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00003C8F File Offset: 0x00001E8F
		[global::Cpp2ILInjected.Token(Token = "0x60005A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED14A0", Offset = "0x1ED14A0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X500DistinguishedName), Member = "Decode", MemberParameters = new object[] { typeof(X500DistinguishedNameFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public override string Format(bool multiLine)
		{
			throw null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00003C92 File Offset: 0x00001E92
		[global::Cpp2ILInjected.Token(Token = "0x60005A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED142C", Offset = "0x1ED142C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X500DistinguishedName), Member = "Decode", MemberParameters = new object[] { typeof(X500DistinguishedNameFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static string GetSeparator(X500DistinguishedNameFlags flag)
		{
			throw null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00003C95 File Offset: 0x00001E95
		[global::Cpp2ILInjected.Token(Token = "0x60005A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED11EC", Offset = "0x1ED11EC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new object[]
		{
			typeof(ASN1),
			typeof(bool),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void DecodeRawData()
		{
			throw null;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00003C98 File Offset: 0x00001E98
		[global::Cpp2ILInjected.Token(Token = "0x60005AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED14F4", Offset = "0x1ED14F4", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X500DistinguishedName), Member = "AreEqual", MemberParameters = new object[]
		{
			typeof(X500DistinguishedName),
			typeof(X500DistinguishedName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static string Canonize(string s)
		{
			throw null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00003C9B File Offset: 0x00001E9B
		[global::Cpp2ILInjected.Token(Token = "0x60005AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ED16B0", Offset = "0x1ED16B0", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X500DistinguishedName), Member = "Decode", MemberParameters = new object[] { typeof(X500DistinguishedNameFlags) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(X500DistinguishedName), Member = "Canonize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2)
		{
			throw null;
		}

		// Token: 0x04000384 RID: 900
		[global::Cpp2ILInjected.Token(Token = "0x40004ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x04000385 RID: 901
		[global::Cpp2ILInjected.Token(Token = "0x40004EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] canonEncoding;
	}
}
