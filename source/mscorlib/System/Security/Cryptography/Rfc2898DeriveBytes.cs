using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Internal.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x0200021A RID: 538
	[global::Cpp2ILInjected.Token(Token = "0x20002B2")]
	public class Rfc2898DeriveBytes : DeriveBytes
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x00018110 File Offset: 0x00016310
		[global::Cpp2ILInjected.Token(Token = "0x17000262")]
		public HashAlgorithmName HashAlgorithm
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600176B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF1C00", Offset = "0x1AF1C00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00018113 File Offset: 0x00016313
		[global::Cpp2ILInjected.Token(Token = "0x600176C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1C08", Offset = "0x1AF1C08", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations)
		{
			throw null;
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00018116 File Offset: 0x00016316
		[global::Cpp2ILInjected.Token(Token = "0x600176D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1C50", Offset = "0x1AF1C50", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeriveBytes), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public Rfc2898DeriveBytes(byte[] password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00018119 File Offset: 0x00016319
		[global::Cpp2ILInjected.Token(Token = "0x600176E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF207C", Offset = "0x1AF207C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Rfc2898DeriveBytes(string password, byte[] salt)
		{
			throw null;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x0001811C File Offset: 0x0001631C
		[global::Cpp2ILInjected.Token(Token = "0x600176F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2084", Offset = "0x1AF2084", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations)
		{
			throw null;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x0001811F File Offset: 0x0001631F
		[global::Cpp2ILInjected.Token(Token = "0x6001770")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF20E8", Offset = "0x1AF20E8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		public Rfc2898DeriveBytes(string password, byte[] salt, int iterations, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00018122 File Offset: 0x00016322
		[global::Cpp2ILInjected.Token(Token = "0x6001771")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2144", Offset = "0x1AF2144", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		public Rfc2898DeriveBytes(string password, int saltSize)
		{
			throw null;
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00018125 File Offset: 0x00016325
		[global::Cpp2ILInjected.Token(Token = "0x6001772")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2180", Offset = "0x1AF2180", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations)
		{
			throw null;
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00018128 File Offset: 0x00016328
		[global::Cpp2ILInjected.Token(Token = "0x6001773")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF21C8", Offset = "0x1AF21C8", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeriveBytes), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "GenerateRandom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public Rfc2898DeriveBytes(string password, int saltSize, int iterations, HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0001812B File Offset: 0x0001632B
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x0001812E File Offset: 0x0001632E
		[global::Cpp2ILInjected.Token(Token = "0x17000263")]
		public int IterationCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001774")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2340", Offset = "0x1AF2340", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001775")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF2348", Offset = "0x1AF2348", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00018131 File Offset: 0x00016331
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x00018134 File Offset: 0x00016334
		[global::Cpp2ILInjected.Token(Token = "0x17000264")]
		public byte[] Salt
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001776")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF23C4", Offset = "0x1AF23C4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001777")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF23D0", Offset = "0x1AF23D0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "CloneByteArray", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00018137 File Offset: 0x00016337
		[global::Cpp2ILInjected.Token(Token = "0x6001778")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2480", Offset = "0x1AF2480", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeriveBytes), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0001813A File Offset: 0x0001633A
		[global::Cpp2ILInjected.Token(Token = "0x6001779")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2508", Offset = "0x1AF2508", Length = "0x1C4")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "Func", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override byte[] GetBytes(int cb)
		{
			throw null;
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0001813D File Offset: 0x0001633D
		[global::Cpp2ILInjected.Token(Token = "0x600177A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2B14", Offset = "0x1AF2B14", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public byte[] CryptDeriveKey(string algname, string alghashname, int keySize, byte[] rgbIV)
		{
			throw null;
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00018140 File Offset: 0x00016340
		[global::Cpp2ILInjected.Token(Token = "0x600177B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2B4C", Offset = "0x1AF2B4C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rfc2898DeriveBytes), Member = "Initialize", ReturnType = typeof(void))]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00018143 File Offset: 0x00016343
		[global::Cpp2ILInjected.Token(Token = "0x600177C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF1DE8", Offset = "0x1AF1DE8", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA1", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(HashAlgorithmName),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA256", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMACSHA256), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA384", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMACSHA384), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithmName), Member = "get_SHA512", ReturnType = typeof(HashAlgorithmName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMACSHA512), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private HMAC OpenHmac()
		{
			throw null;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00018146 File Offset: 0x00016346
		[global::Cpp2ILInjected.Token(Token = "0x600177D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF2004", Offset = "0x1AF2004", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte[]),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(HashAlgorithmName)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "set_IterationCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "set_Salt", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Initialize()
		{
			throw null;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00018149 File Offset: 0x00016349
		[global::Cpp2ILInjected.Token(Token = "0x600177E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF26CC", Offset = "0x1AF26CC", Length = "0x448")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Internal.Cryptography.Helpers), Member = "WriteInt", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TryComputeHash", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private byte[] Func()
		{
			throw null;
		}

		// Token: 0x04000967 RID: 2407
		[global::Cpp2ILInjected.Token(Token = "0x4000C0F")]
		private const int MinimumSaltSize = 8;

		// Token: 0x04000968 RID: 2408
		[global::Cpp2ILInjected.Token(Token = "0x4000C10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly byte[] _password;

		// Token: 0x04000969 RID: 2409
		[global::Cpp2ILInjected.Token(Token = "0x4000C11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] _salt;

		// Token: 0x0400096A RID: 2410
		[global::Cpp2ILInjected.Token(Token = "0x4000C12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private uint _iterations;

		// Token: 0x0400096B RID: 2411
		[global::Cpp2ILInjected.Token(Token = "0x4000C13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private HMAC _hmac;

		// Token: 0x0400096C RID: 2412
		[global::Cpp2ILInjected.Token(Token = "0x4000C14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _blockSize;

		// Token: 0x0400096D RID: 2413
		[global::Cpp2ILInjected.Token(Token = "0x4000C15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] _buffer;

		// Token: 0x0400096E RID: 2414
		[global::Cpp2ILInjected.Token(Token = "0x4000C16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private uint _block;

		// Token: 0x0400096F RID: 2415
		[global::Cpp2ILInjected.Token(Token = "0x4000C17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int _startIndex;

		// Token: 0x04000970 RID: 2416
		[global::Cpp2ILInjected.Token(Token = "0x4000C18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _endIndex;

		// Token: 0x04000971 RID: 2417
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000C19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly HashAlgorithmName <HashAlgorithm>k__BackingField;
	}
}
