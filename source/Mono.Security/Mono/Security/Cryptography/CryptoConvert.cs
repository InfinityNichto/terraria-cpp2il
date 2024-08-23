using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Authenticode;
using Mono.Security.X509;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000037 RID: 55
	[global::Cpp2ILInjected.Token(Token = "0x2000052")]
	public sealed class CryptoConvert
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x000034BF File Offset: 0x000016BF
		[global::Cpp2ILInjected.Token(Token = "0x6000237")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C4E0", Offset = "0x1A9C4E0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int ToInt32LE(byte[] bytes, int offset)
		{
			throw null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000034C2 File Offset: 0x000016C2
		[global::Cpp2ILInjected.Token(Token = "0x6000238")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C514", Offset = "0x1A9C514", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint ToUInt32LE(byte[] bytes, int offset)
		{
			throw null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000034C5 File Offset: 0x000016C5
		[global::Cpp2ILInjected.Token(Token = "0x6000239")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C548", Offset = "0x1A9C548", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConvert), Member = "GetParametersFromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static byte[] Trim(byte[] array)
		{
			throw null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000034C8 File Offset: 0x000016C8
		[global::Cpp2ILInjected.Token(Token = "0x600023A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C5E8", Offset = "0x1A9C5E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrivateKey), Member = "Decode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static RSA FromCapiPrivateKeyBlob(byte[] blob)
		{
			throw null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000034CB File Offset: 0x000016CB
		[global::Cpp2ILInjected.Token(Token = "0x600023B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C5F0", Offset = "0x1A9C5F0", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConvert), Member = "GetParametersFromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSA), Member = "Create", ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CspParameters), Member = "set_Flags", MemberParameters = new object[] { typeof(CspProviderFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new object[] { typeof(CspParameters) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			throw null;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000034CE File Offset: 0x000016CE
		[global::Cpp2ILInjected.Token(Token = "0x600023C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9C7D8", Offset = "0x1A9C7D8", Length = "0x530")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConvert), Member = "FromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(RSA))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConvert), Member = "Trim", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset)
		{
			throw null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000034D1 File Offset: 0x000016D1
		[global::Cpp2ILInjected.Token(Token = "0x600023D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9CD08", Offset = "0x1A9CD08", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsnEncodedData), Member = "SubjectAltName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X509SubjectKeyIdentifierExtension), Member = "get_SubjectKeyIdentifier", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static string ToHex(byte[] input)
		{
			throw null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000034D4 File Offset: 0x000016D4
		[global::Cpp2ILInjected.Token(Token = "0x600023E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9CE24", Offset = "0x1A9CE24", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConvert), Member = "FromHex", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static byte FromHexChar(char c)
		{
			throw null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000034D7 File Offset: 0x000016D7
		[global::Cpp2ILInjected.Token(Token = "0x600023F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9CEBC", Offset = "0x1A9CEBC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(X501), Member = "ReadHex", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConvert), Member = "FromHexChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static byte[] FromHex(string hex)
		{
			throw null;
		}
	}
}
