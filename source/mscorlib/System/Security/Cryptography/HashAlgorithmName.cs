using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000221 RID: 545
	[global::Cpp2ILInjected.Token(Token = "0x20002BE")]
	public readonly struct HashAlgorithmName : global::System.IEquatable<HashAlgorithmName>
	{
		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x000181FA File Offset: 0x000163FA
		[global::Cpp2ILInjected.Token(Token = "0x17000273")]
		public static HashAlgorithmName MD5
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7AA8", Offset = "0x1AF7AA8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000181FD File Offset: 0x000163FD
		[global::Cpp2ILInjected.Token(Token = "0x17000274")]
		public static HashAlgorithmName SHA1
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7AE8", Offset = "0x1AF7AE8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "OidToHashAlgorithmName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithmName))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00018200 File Offset: 0x00016400
		[global::Cpp2ILInjected.Token(Token = "0x17000275")]
		public static HashAlgorithmName SHA256
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7B28", Offset = "0x1AF7B28", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "OidToHashAlgorithmName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithmName))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00018203 File Offset: 0x00016403
		[global::Cpp2ILInjected.Token(Token = "0x17000276")]
		public static HashAlgorithmName SHA384
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7B68", Offset = "0x1AF7B68", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "OidToHashAlgorithmName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithmName))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x00018206 File Offset: 0x00016406
		[global::Cpp2ILInjected.Token(Token = "0x17000277")]
		public static HashAlgorithmName SHA512
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7BA8", Offset = "0x1AF7BA8", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Utils), Member = "OidToHashAlgorithmName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithmName))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x00018209 File Offset: 0x00016409
		[global::Cpp2ILInjected.Token(Token = "0x60017CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7BE8", Offset = "0x1AF7BE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HashAlgorithmName(string name)
		{
			throw null;
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x0001820C File Offset: 0x0001640C
		[global::Cpp2ILInjected.Token(Token = "0x17000278")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7BF0", Offset = "0x1AF7BF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0001820F File Offset: 0x0001640F
		[global::Cpp2ILInjected.Token(Token = "0x60017D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7BF8", Offset = "0x1AF7BF8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00018212 File Offset: 0x00016412
		[global::Cpp2ILInjected.Token(Token = "0x60017D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7C4C", Offset = "0x1AF7C4C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00018215 File Offset: 0x00016415
		[global::Cpp2ILInjected.Token(Token = "0x60017D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7CC8", Offset = "0x1AF7CC8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public bool Equals(HashAlgorithmName other)
		{
			throw null;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00018218 File Offset: 0x00016418
		[global::Cpp2ILInjected.Token(Token = "0x60017D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7CD4", Offset = "0x1AF7CD4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0001821B File Offset: 0x0001641B
		[global::Cpp2ILInjected.Token(Token = "0x60017D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7CEC", Offset = "0x1AF7CEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rfc2898DeriveBytes), Member = "OpenHmac", ReturnType = typeof(HMAC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public static bool operator ==(HashAlgorithmName left, HashAlgorithmName right)
		{
			throw null;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0001821E File Offset: 0x0001641E
		[global::Cpp2ILInjected.Token(Token = "0x60017D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7CF4", Offset = "0x1AF7CF4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(HashAlgorithmName left, HashAlgorithmName right)
		{
			throw null;
		}

		// Token: 0x0400098A RID: 2442
		[global::Cpp2ILInjected.Token(Token = "0x4000C64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;
	}
}
