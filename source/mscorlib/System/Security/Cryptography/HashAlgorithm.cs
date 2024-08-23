using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000220 RID: 544
	[global::Cpp2ILInjected.Token(Token = "0x20002BD")]
	public abstract class HashAlgorithm : global::System.IDisposable, ICryptoTransform
	{
		// Token: 0x06001597 RID: 5527 RVA: 0x000181B8 File Offset: 0x000163B8
		[global::Cpp2ILInjected.Token(Token = "0x60017B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6BB8", Offset = "0x1AF6BB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.MD2), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.MD2Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.MD4), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.MD4Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.MD2", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.MD2Managed", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.MD4", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.MD4Managed", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected HashAlgorithm()
		{
			throw null;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000181BB File Offset: 0x000163BB
		[global::Cpp2ILInjected.Token(Token = "0x60017B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6BC0", Offset = "0x1AF6BC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfigForwarder), Member = "CreateDefaultHashAlgorithm", ReturnType = typeof(HashAlgorithm))]
		public static HashAlgorithm Create()
		{
			throw null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x000181BE File Offset: 0x000163BE
		[global::Cpp2ILInjected.Token(Token = "0x60017B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6BC8", Offset = "0x1AF6BC8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMAC), Member = "set_HashName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PKCS1MaskGenerationMethod), Member = "GenerateMask", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "GetHashFromString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Builder", Member = "Sign", MemberParameters = new object[] { typeof(RSA) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Builder", Member = "Sign", MemberParameters = new object[] { typeof(DSA) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeDeformatter", Member = "VerifyCounterSignature", MemberParameters = new object[] { "Mono.Security.PKCS7.SignerInfo", "System.Byte[]" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfigForwarder), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static HashAlgorithm Create(string hashName)
		{
			throw null;
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x000181C1 File Offset: 0x000163C1
		[global::Cpp2ILInjected.Token(Token = "0x1700026D")]
		public virtual int HashSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF6C48", Offset = "0x1AF6C48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x000181C4 File Offset: 0x000163C4
		[global::Cpp2ILInjected.Token(Token = "0x1700026E")]
		public virtual byte[] Hash
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF6C50", Offset = "0x1AF6C50", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicUnexpectedOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x000181C7 File Offset: 0x000163C7
		[global::Cpp2ILInjected.Token(Token = "0x60017B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6D84", Offset = "0x1AF6D84", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public byte[] ComputeHash(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000181CA File Offset: 0x000163CA
		[global::Cpp2ILInjected.Token(Token = "0x60017B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6EC8", Offset = "0x1AF6EC8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "Func", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public bool TryComputeHash(global::System.ReadOnlySpan<byte> source, global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000181CD File Offset: 0x000163CD
		[global::Cpp2ILInjected.Token(Token = "0x60017B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7018", Offset = "0x1AF7018", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12.DeriveBytes", Member = "Derive", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "MAC", MemberParameters = new object[]
		{
			"System.Byte[]",
			"System.Byte[]",
			typeof(int),
			"System.Byte[]"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Certificate", Member = "get_Hash", ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public byte[] ComputeHash(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000181D0 File Offset: 0x000163D0
		[global::Cpp2ILInjected.Token(Token = "0x60017B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7178", Offset = "0x1AF7178", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "SignData", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSACryptoServiceProvider), Member = "HashData", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public byte[] ComputeHash(global::System.IO.Stream inputStream)
		{
			throw null;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000181D3 File Offset: 0x000163D3
		[global::Cpp2ILInjected.Token(Token = "0x60017BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6E28", Offset = "0x1AF6E28", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private byte[] CaptureHashCodeAndReinitialize()
		{
			throw null;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x000181D6 File Offset: 0x000163D6
		[global::Cpp2ILInjected.Token(Token = "0x60017BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7364", Offset = "0x1AF7364", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x000181D9 File Offset: 0x000163D9
		[global::Cpp2ILInjected.Token(Token = "0x60017BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF73D4", Offset = "0x1AF73D4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new object[]
		{
			"Mono.Security.Protocol.Ntlm.Type2Message",
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "DeriveKey", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000181DC File Offset: 0x000163DC
		[global::Cpp2ILInjected.Token(Token = "0x60017BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7468", Offset = "0x1AF7468", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1CryptoServiceProvider), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x000181DF File Offset: 0x000163DF
		[global::Cpp2ILInjected.Token(Token = "0x1700026F")]
		public virtual int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7478", Offset = "0x1AF7478", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000181E2 File Offset: 0x000163E2
		[global::Cpp2ILInjected.Token(Token = "0x17000270")]
		public virtual int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7480", Offset = "0x1AF7480", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000181E5 File Offset: 0x000163E5
		[global::Cpp2ILInjected.Token(Token = "0x17000271")]
		public virtual bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7488", Offset = "0x1AF7488", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000181E8 File Offset: 0x000163E8
		[global::Cpp2ILInjected.Token(Token = "0x17000272")]
		public virtual bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7490", Offset = "0x1AF7490", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x000181EB File Offset: 0x000163EB
		[global::Cpp2ILInjected.Token(Token = "0x60017C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7498", Offset = "0x1AF7498", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMAC), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMAC), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = "ComputeBaseValue", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12.DeriveBytes", Member = "Derive", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "GetHash", MemberParameters = new object[] { typeof(HashAlgorithm) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "DeriveKey", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ValidateTransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x000181EE File Offset: 0x000163EE
		[global::Cpp2ILInjected.Token(Token = "0x60017C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7678", Offset = "0x1AF7678", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMAC), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PasswordDeriveBytes), Member = "ComputeBaseValue", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12.DeriveBytes", Member = "Derive", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "GetHash", MemberParameters = new object[] { typeof(HashAlgorithm) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.PrivateKey", Member = "DeriveKey", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ValidateTransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "CaptureHashCodeAndReinitialize", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x000181F1 File Offset: 0x000163F1
		[global::Cpp2ILInjected.Token(Token = "0x60017C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7534", Offset = "0x1AF7534", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x060015AB RID: 5547
		[global::Cpp2ILInjected.Token(Token = "0x60017C5")]
		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		// Token: 0x060015AC RID: 5548
		[global::Cpp2ILInjected.Token(Token = "0x60017C6")]
		protected abstract byte[] HashFinal();

		// Token: 0x060015AD RID: 5549
		[global::Cpp2ILInjected.Token(Token = "0x60017C7")]
		public abstract void Initialize();

		// Token: 0x060015AE RID: 5550 RVA: 0x000181F4 File Offset: 0x000163F4
		[global::Cpp2ILInjected.Token(Token = "0x60017C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF779C", Offset = "0x1AF779C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		protected virtual void HashCore(global::System.ReadOnlySpan<byte> source)
		{
			throw null;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000181F7 File Offset: 0x000163F7
		[global::Cpp2ILInjected.Token(Token = "0x60017C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7964", Offset = "0x1AF7964", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected virtual bool TryHashFinal(global::System.Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		// Token: 0x04000986 RID: 2438
		[global::Cpp2ILInjected.Token(Token = "0x4000C60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _disposed;

		// Token: 0x04000987 RID: 2439
		[global::Cpp2ILInjected.Token(Token = "0x4000C61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		protected int HashSizeValue;

		// Token: 0x04000988 RID: 2440
		[global::Cpp2ILInjected.Token(Token = "0x4000C62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected internal byte[] HashValue;

		// Token: 0x04000989 RID: 2441
		[global::Cpp2ILInjected.Token(Token = "0x4000C63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected int State;
	}
}
