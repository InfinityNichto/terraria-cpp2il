using System;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000035 RID: 53
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	internal abstract class SymmetricTransform : global::System.Security.Cryptography.ICryptoTransform, global::System.IDisposable
	{
		// Token: 0x0600014A RID: 330 RVA: 0x00014996 File Offset: 0x00012B96
		[global::Cpp2ILInjected.Token(Token = "0x600018E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABFBFC", Offset = "0x1ABFBFC", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.SymmetricAlgorithm),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RC2Transform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.RC2),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.TripleDESTransform), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.TripleDES),
			typeof(bool),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.AesTransform", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.Aes),
			typeof(bool),
			"System.Byte[]",
			"System.Byte[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyBuilder), Member = "IV", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public SymmetricTransform(global::System.Security.Cryptography.SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV)
		{
			throw null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00014999 File Offset: 0x00012B99
		[global::Cpp2ILInjected.Token(Token = "0x600018F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABFE78", Offset = "0x1ABFE78", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0001499C File Offset: 0x00012B9C
		[global::Cpp2ILInjected.Token(Token = "0x6000190")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABFF18", Offset = "0x1ABFF18", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001499F File Offset: 0x00012B9F
		[global::Cpp2ILInjected.Token(Token = "0x6000191")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABFF84", Offset = "0x1ABFF84", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000149A2 File Offset: 0x00012BA2
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public virtual bool CanTransformMultipleBlocks
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000192")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABFFD8", Offset = "0x1ABFFD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600014F RID: 335 RVA: 0x000149A5 File Offset: 0x00012BA5
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public virtual bool CanReuseTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000193")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABFFE0", Offset = "0x1ABFFE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000149A8 File Offset: 0x00012BA8
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		public virtual int InputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000194")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABFFE8", Offset = "0x1ABFFE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000149AB File Offset: 0x00012BAB
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public virtual int OutputBlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000195")]
			[global::Cpp2ILInjected.Address(RVA = "0x1ABFFF0", Offset = "0x1ABFFF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000149AE File Offset: 0x00012BAE
		[global::Cpp2ILInjected.Token(Token = "0x6000196")]
		[global::Cpp2ILInjected.Address(RVA = "0x1ABFFF8", Offset = "0x1ABFFF8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected virtual void Transform(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x06000153 RID: 339
		[global::Cpp2ILInjected.Token(Token = "0x6000197")]
		protected abstract void ECB(byte[] input, byte[] output);

		// Token: 0x06000154 RID: 340 RVA: 0x000149B1 File Offset: 0x00012BB1
		[global::Cpp2ILInjected.Token(Token = "0x6000198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0144", Offset = "0x1AC0144", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected virtual void CBC(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000149B4 File Offset: 0x00012BB4
		[global::Cpp2ILInjected.Token(Token = "0x6000199")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0258", Offset = "0x1AC0258", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected virtual void CFB(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000149B7 File Offset: 0x00012BB7
		[global::Cpp2ILInjected.Token(Token = "0x600019A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC03C0", Offset = "0x1AC03C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual void OFB(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000149BA File Offset: 0x00012BBA
		[global::Cpp2ILInjected.Token(Token = "0x600019B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC040C", Offset = "0x1AC040C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual void CTS(byte[] input, byte[] output)
		{
			throw null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000149BD File Offset: 0x00012BBD
		[global::Cpp2ILInjected.Token(Token = "0x600019C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0458", Offset = "0x1AC0458", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = "TransformFinalBlock", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000149C0 File Offset: 0x00012BC0
		[global::Cpp2ILInjected.Token(Token = "0x600019D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC059C", Offset = "0x1AC059C", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricTransform), Member = "CheckInput", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricTransform), Member = "InternalTransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000149C3 File Offset: 0x00012BC3
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		private bool KeepLastBlock
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AC079C", Offset = "0x1AC079C", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000149C6 File Offset: 0x00012BC6
		[global::Cpp2ILInjected.Token(Token = "0x600019F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC07C0", Offset = "0x1AC07C0", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = "FinalEncrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = "FinalDecrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			throw null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000149C9 File Offset: 0x00012BC9
		[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0978", Offset = "0x1AC0978", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = "FinalEncrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "Create", ReturnType = typeof(global::System.Security.Cryptography.RandomNumberGenerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Random(byte[] buffer, int start, int length)
		{
			throw null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000149CC File Offset: 0x00012BCC
		[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0A20", Offset = "0x1AC0A20", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymmetricTransform), Member = "FinalDecrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ParamsArray), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "FormatHelper", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(global::System.ParamsArray)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void ThrowBadPaddingException(global::System.Security.Cryptography.PaddingMode padding, int length, int position)
		{
			throw null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000149CF File Offset: 0x00012BCF
		[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0C04", Offset = "0x1AC0C04", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricTransform), Member = "InternalTransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricTransform), Member = "Random", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.Cryptography.CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000149D2 File Offset: 0x00012BD2
		[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC0E78", Offset = "0x1AC0E78", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricTransform), Member = "InternalTransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricTransform), Member = "ThrowBadPaddingException", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.PaddingMode),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000149D5 File Offset: 0x00012BD5
		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AC10E0", Offset = "0x1AC10E0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricTransform), Member = "CheckInput", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x4000164")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected global::System.Security.Cryptography.SymmetricAlgorithm algo;

		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x4000165")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected bool encrypt;

		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x4000166")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		protected int BlockSizeByte;

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x4000167")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected byte[] temp;

		// Token: 0x040000BB RID: 187
		[global::Cpp2ILInjected.Token(Token = "0x4000168")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected byte[] temp2;

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x4000169")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] workBuff;

		// Token: 0x040000BD RID: 189
		[global::Cpp2ILInjected.Token(Token = "0x400016A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] workout;

		// Token: 0x040000BE RID: 190
		[global::Cpp2ILInjected.Token(Token = "0x400016B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected global::System.Security.Cryptography.PaddingMode padmode;

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x400016C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		protected int FeedBackByte;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x400016D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool m_disposed;

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x400016E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		protected bool lastBlock;

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x400016F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::System.Security.Cryptography.RandomNumberGenerator _rng;
	}
}
