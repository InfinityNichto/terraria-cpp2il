using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000270 RID: 624
	[global::Cpp2ILInjected.Token(Token = "0x200030D")]
	internal static class Utils
	{
		// Token: 0x06001838 RID: 6200 RVA: 0x0001892C File Offset: 0x00016B2C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12574", Offset = "0x1B12574", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static Utils()
		{
			throw null;
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0001892F File Offset: 0x00016B2F
		[global::Cpp2ILInjected.Token(Token = "0x170002DC")]
		internal static RNGCryptoServiceProvider StaticRandomNumberGenerator
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B1241C", Offset = "0x1B1241C", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(ref byte[]),
				typeof(int),
				typeof(PaddingMode),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateKey", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDESCryptoServiceProvider), Member = "GenerateIV", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RNGCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00018932 File Offset: 0x00016B32
		[global::Cpp2ILInjected.Token(Token = "0x6001A54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12578", Offset = "0x1B12578", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACMD5), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACRIPEMD160), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManaged), Member = "GenerateKey", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManaged), Member = "GenerateIV", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RijndaelManaged), Member = "NewEncryptor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(CipherMode),
			typeof(byte[]),
			typeof(int),
			typeof(RijndaelManagedTransformMode)
		}, ReturnType = typeof(ICryptoTransform))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static byte[] GenerateRandom(int keySize)
		{
			throw null;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00018935 File Offset: 0x00016B35
		[global::Cpp2ILInjected.Token(Token = "0x6001A55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12114", Offset = "0x1B12114", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DESCryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RC2CryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			throw null;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00018938 File Offset: 0x00016B38
		[global::Cpp2ILInjected.Token(Token = "0x6001A56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B08264", Offset = "0x1B08264", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DiscardWhiteSpaces", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static string DiscardWhiteSpaces(string inputBuffer)
		{
			throw null;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0001893B File Offset: 0x00016B3B
		[global::Cpp2ILInjected.Token(Token = "0x6001A57")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12610", Offset = "0x1B12610", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DiscardWhiteSpaces", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0001893E File Offset: 0x00016B3E
		[global::Cpp2ILInjected.Token(Token = "0x6001A58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12780", Offset = "0x1B12780", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "FromXmlString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static int ConvertByteArrayToInt(byte[] input)
		{
			throw null;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00018941 File Offset: 0x00016B41
		[global::Cpp2ILInjected.Token(Token = "0x6001A59")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B127C0", Offset = "0x1B127C0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSA), Member = "ToXmlString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static byte[] ConvertIntToByteArray(int dwInput)
		{
			throw null;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00018944 File Offset: 0x00016B44
		[global::Cpp2ILInjected.Token(Token = "0x6001A5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B128A4", Offset = "0x1B128A4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal static void ConvertIntToByteArray(uint dwInput, ref byte[] counter)
		{
			throw null;
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00018947 File Offset: 0x00016B47
		[global::Cpp2ILInjected.Token(Token = "0x6001A5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B11DF8", Offset = "0x1B11DF8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DES), Member = "IsSemiWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TripleDES), Member = "IsWeakKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static byte[] FixupKeyParity(byte[] key)
		{
			throw null;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0001894A File Offset: 0x00016B4A
		[global::Cpp2ILInjected.Token(Token = "0x6001A5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B128F4", Offset = "0x1B128F4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RIPEMD160Managed), Member = "MDTransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
			throw null;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0001894D File Offset: 0x00016B4D
		[global::Cpp2ILInjected.Token(Token = "0x6001A5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12940", Offset = "0x1B12940", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RIPEMD160Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits)
		{
			throw null;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00018950 File Offset: 0x00016B50
		[global::Cpp2ILInjected.Token(Token = "0x6001A5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0DE44", Offset = "0x1B0DE44", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
			throw null;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00018953 File Offset: 0x00016B53
		[global::Cpp2ILInjected.Token(Token = "0x6001A5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0DDE8", Offset = "0x1B0DDE8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits)
		{
			throw null;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00018956 File Offset: 0x00016B56
		[global::Cpp2ILInjected.Token(Token = "0x6001A60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F5BC", Offset = "0x1B0F5BC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(ulong*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(ulong*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
			throw null;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00018959 File Offset: 0x00016B59
		[global::Cpp2ILInjected.Token(Token = "0x6001A61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F524", Offset = "0x1B0F524", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits)
		{
			throw null;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0001895C File Offset: 0x00016B5C
		[global::Cpp2ILInjected.Token(Token = "0x6001A62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1299C", Offset = "0x1B1299C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static byte[] Int(uint i)
		{
			throw null;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0001895F File Offset: 0x00016B5F
		[global::Cpp2ILInjected.Token(Token = "0x6001A63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C9D8", Offset = "0x1B0C9D8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = "CreateKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Encrypt_OAEP", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static byte[] RsaOaepEncrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, RandomNumberGenerator rng, byte[] data)
		{
			throw null;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00018962 File Offset: 0x00016B62
		[global::Cpp2ILInjected.Token(Token = "0x6001A64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C1A4", Offset = "0x1B0C1A4", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = "DecryptKeyExchange", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "Decrypt_OAEP", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static byte[] RsaOaepDecrypt(RSA rsa, HashAlgorithm hash, PKCS1MaskGenerationMethod mgf, byte[] encryptedData)
		{
			throw null;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00018965 File Offset: 0x00016B65
		[global::Cpp2ILInjected.Token(Token = "0x6001A65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B129F0", Offset = "0x1B129F0", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static byte[] RsaPkcs1Padding(RSA rsa, byte[] oid, byte[] hash)
		{
			throw null;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00018968 File Offset: 0x00016B68
		[global::Cpp2ILInjected.Token(Token = "0x6001A66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12C0C", Offset = "0x1B12C0C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool CompareBigIntArrays(byte[] lhs, byte[] rhs)
		{
			throw null;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0001896B File Offset: 0x00016B6B
		[global::Cpp2ILInjected.Token(Token = "0x6001A67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12CD8", Offset = "0x1B12CD8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA256", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA384", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA512", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal static HashAlgorithmName OidToHashAlgorithmName(string oid)
		{
			throw null;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x0001896E File Offset: 0x00016B6E
		[global::Cpp2ILInjected.Token(Token = "0x6001A68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0C358", Offset = "0x1B0C358", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeDeformatter), Member = "get_OverridesDecrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAOAEPKeyExchangeFormatter), Member = "get_OverridesEncrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeDeformatter), Member = "get_OverridesDecrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAPKCS1KeyExchangeFormatter), Member = "get_OverridesEncrypt", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DoesRsaKeyOverrideSlowPath", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static bool DoesRsaKeyOverride(RSA rsaKey, string methodName, global::System.Type[] parameterTypes)
		{
			throw null;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00018971 File Offset: 0x00016B71
		[global::Cpp2ILInjected.Token(Token = "0x6001A69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12E0C", Offset = "0x1B12E0C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "DoesRsaKeyOverride", MemberParameters = new object[]
		{
			typeof(RSA),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool DoesRsaKeyOverrideSlowPath(global::System.Type t, string methodName, global::System.Type[] parameterTypes)
		{
			throw null;
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00018974 File Offset: 0x00016B74
		[global::Cpp2ILInjected.Token(Token = "0x6001A6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B12EE4", Offset = "0x1B12EE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static bool _ProduceLegacyHmacValues()
		{
			throw null;
		}

		// Token: 0x04000AA4 RID: 2724
		[global::Cpp2ILInjected.Token(Token = "0x4000D7E")]
		internal const int DefaultRsaProviderType = 1;

		// Token: 0x04000AA5 RID: 2725
		[global::Cpp2ILInjected.Token(Token = "0x4000D7F")]
		private static RNGCryptoServiceProvider _rng;
	}
}
