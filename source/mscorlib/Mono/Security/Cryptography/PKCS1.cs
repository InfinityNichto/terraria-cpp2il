using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000033 RID: 51
	[global::Cpp2ILInjected.Token(Token = "0x2000049")]
	internal sealed class PKCS1
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00014924 File Offset: 0x00012B24
		[global::Cpp2ILInjected.Token(Token = "0x6000166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB604", Offset = "0x1ABB604", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool Compare(byte[] array1, byte[] array2)
		{
			throw null;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00014927 File Offset: 0x00012B27
		[global::Cpp2ILInjected.Token(Token = "0x6000167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB654", Offset = "0x1ABB654", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Encrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Decrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static byte[] xor(byte[] array1, byte[] array2)
		{
			throw null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001492A File Offset: 0x00012B2A
		[global::Cpp2ILInjected.Token(Token = "0x6000168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB6E8", Offset = "0x1ABB6E8", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Encrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Decrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static byte[] GetEmptyHash(global::System.Security.Cryptography.HashAlgorithm hash)
		{
			throw null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001492D File Offset: 0x00012B2D
		[global::Cpp2ILInjected.Token(Token = "0x6000169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB8A8", Offset = "0x1ABB8A8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "MGF1", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "Reverse", MemberTypeParameters = new object[] { typeof(byte) }, MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static byte[] I2OSP(int x, int size)
		{
			throw null;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00014930 File Offset: 0x00012B30
		[global::Cpp2ILInjected.Token(Token = "0x600016A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB940", Offset = "0x1ABB940", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Encrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Decrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] I2OSP(byte[] x, int size)
		{
			throw null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00014933 File Offset: 0x00012B33
		[global::Cpp2ILInjected.Token(Token = "0x600016B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABB9C0", Offset = "0x1ABB9C0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Encrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Decrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] OS2IP(byte[] x)
		{
			throw null;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00014936 File Offset: 0x00012B36
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABBA60", Offset = "0x1ABBA60", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static byte[] RSAEP(global::System.Security.Cryptography.RSA rsa, byte[] m)
		{
			throw null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00014939 File Offset: 0x00012B39
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABBA70", Offset = "0x1ABBA70", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static byte[] RSADP(global::System.Security.Cryptography.RSA rsa, byte[] c)
		{
			throw null;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001493C File Offset: 0x00012B3C
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABBA80", Offset = "0x1ABBA80", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static byte[] RSASP1(global::System.Security.Cryptography.RSA rsa, byte[] m)
		{
			throw null;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0001493F File Offset: 0x00012B3F
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABBA90", Offset = "0x1ABBA90", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static byte[] RSAVP1(global::System.Security.Cryptography.RSA rsa, byte[] s)
		{
			throw null;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00014942 File Offset: 0x00012B42
		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABBAA0", Offset = "0x1ABBAA0", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Utils), Member = "RsaOaepEncrypt", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(global::System.Security.Cryptography.PKCS1MaskGenerationMethod),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "GetEmptyHash", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.HashAlgorithm) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "MGF1", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "xor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "OS2IP", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "I2OSP", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static byte[] Encrypt_OAEP(global::System.Security.Cryptography.RSA rsa, global::System.Security.Cryptography.HashAlgorithm hash, global::System.Security.Cryptography.RandomNumberGenerator rng, byte[] M)
		{
			throw null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00014945 File Offset: 0x00012B45
		[global::Cpp2ILInjected.Token(Token = "0x6000171")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABBF10", Offset = "0x1ABBF10", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Utils), Member = "RsaOaepDecrypt", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(global::System.Security.Cryptography.PKCS1MaskGenerationMethod),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "OS2IP", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "I2OSP", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "MGF1", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "xor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "GetEmptyHash", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.HashAlgorithm) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static byte[] Decrypt_OAEP(global::System.Security.Cryptography.RSA rsa, global::System.Security.Cryptography.HashAlgorithm hash, byte[] C)
		{
			throw null;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00014948 File Offset: 0x00012B48
		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABC200", Offset = "0x1ABC200", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "OS2IP", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "I2OSP", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] Sign_v15(global::System.Security.Cryptography.RSA rsa, global::System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue)
		{
			throw null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001494B File Offset: 0x00012B4B
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABC588", Offset = "0x1ABC588", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSAPKCS1SignatureFormatter), Member = "CreateSignature", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.Cryptography.HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static byte[] Sign_v15(global::System.Security.Cryptography.RSA rsa, string hashName, byte[] hashValue)
		{
			throw null;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0001494E File Offset: 0x00012B4E
		[global::Cpp2ILInjected.Token(Token = "0x6000174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABCB34", Offset = "0x1ABCB34", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "VerifyData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(object),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool Verify_v15(global::System.Security.Cryptography.RSA rsa, global::System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature)
		{
			throw null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00014951 File Offset: 0x00012B51
		[global::Cpp2ILInjected.Token(Token = "0x6000175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABCDC8", Offset = "0x1ABCDC8", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSAPKCS1SignatureDeformatter), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Security.Cryptography.HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static bool Verify_v15(global::System.Security.Cryptography.RSA rsa, string hashName, byte[] hashValue, byte[] signature)
		{
			throw null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00014954 File Offset: 0x00012B54
		[global::Cpp2ILInjected.Token(Token = "0x6000176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABCBB4", Offset = "0x1ABCBB4", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(string),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "OS2IP", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "I2OSP", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "Encode_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool Verify_v15(global::System.Security.Cryptography.RSA rsa, global::System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding)
		{
			throw null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00014957 File Offset: 0x00012B57
		[global::Cpp2ILInjected.Token(Token = "0x6000177")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABC2A8", Offset = "0x1ABC2A8", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "MapNameToOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "EncodeOID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = "Add", MemberParameters = new object[] { typeof(ASN1) }, ReturnType = typeof(ASN1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static byte[] Encode_v15(global::System.Security.Cryptography.HashAlgorithm hash, byte[] hashValue, int emLength)
		{
			throw null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0001495A File Offset: 0x00012B5A
		[global::Cpp2ILInjected.Token(Token = "0x6000178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABBD2C", Offset = "0x1ABBD2C", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Encrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(global::System.Security.Cryptography.RandomNumberGenerator),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Decrypt_OAEP", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.PKCS1MaskGenerationMethod), Member = "GenerateMask", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PKCS1), Member = "I2OSP", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.OverflowException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static byte[] MGF1(global::System.Security.Cryptography.HashAlgorithm hash, byte[] mgfSeed, int maskLen)
		{
			throw null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0001495D File Offset: 0x00012B5D
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABC750", Offset = "0x1ABC750", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Sign_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1), Member = "Verify_v15", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RSA),
			typeof(string),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.SHA1), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.SHA1))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD2), Member = "Create", ReturnType = typeof(MD2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.MD5), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.MD5))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.SHA384), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.SHA384))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RIPEMD160), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.RIPEMD160))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.SHA256), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.SHA256))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4), Member = "Create", ReturnType = typeof(MD4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.SHA512), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.SHA512))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		internal static global::System.Security.Cryptography.HashAlgorithm CreateFromName(string name)
		{
			throw null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00014960 File Offset: 0x00012B60
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABD084", Offset = "0x1ABD084", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static PKCS1()
		{
			throw null;
		}

		// Token: 0x040000A6 RID: 166
		[global::Cpp2ILInjected.Token(Token = "0x4000153")]
		private static byte[] emptySHA1;

		// Token: 0x040000A7 RID: 167
		[global::Cpp2ILInjected.Token(Token = "0x4000154")]
		private static byte[] emptySHA256;

		// Token: 0x040000A8 RID: 168
		[global::Cpp2ILInjected.Token(Token = "0x4000155")]
		private static byte[] emptySHA384;

		// Token: 0x040000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x4000156")]
		private static byte[] emptySHA512;
	}
}
