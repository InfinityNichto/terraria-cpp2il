using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x20002BE")]
	public readonly struct HashAlgorithmName : global::System.IEquatable<HashAlgorithmName>
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60017CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7BE8", Offset = "0x1AF7BE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HashAlgorithmName(string name)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60017D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7BF8", Offset = "0x1AF7BF8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x60017D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7CD4", Offset = "0x1AF7CD4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000C64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;
	}
}
