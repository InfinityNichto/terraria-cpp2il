using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x20002BF")]
	public sealed class RSAEncryptionPadding : global::System.IEquatable<RSAEncryptionPadding>
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000279")]
		public static RSAEncryptionPadding Pkcs1
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7D10", Offset = "0x1AF7D10", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700027A")]
		public static RSAEncryptionPadding OaepSHA1
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7D68", Offset = "0x1AF7D68", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700027B")]
		public static RSAEncryptionPadding OaepSHA256
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7DC0", Offset = "0x1AF7DC0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700027C")]
		public static RSAEncryptionPadding OaepSHA384
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7E18", Offset = "0x1AF7E18", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700027D")]
		public static RSAEncryptionPadding OaepSHA512
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7E70", Offset = "0x1AF7E70", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7EC8", Offset = "0x1AF7EC8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private RSAEncryptionPadding(RSAEncryptionPaddingMode mode, HashAlgorithmName oaepHashAlgorithm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7EF8", Offset = "0x1AF7EF8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAEncryptionPadding), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static RSAEncryptionPadding CreateOaep(HashAlgorithmName hashAlgorithm)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700027E")]
		public RSAEncryptionPaddingMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7FD0", Offset = "0x1AF7FD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700027F")]
		public HashAlgorithmName OaepHashAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF7FD8", Offset = "0x1AF7FD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF7FE0", Offset = "0x1AF7FE0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF806C", Offset = "0x1AF806C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8078", Offset = "0x1AF8078", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF80DC", Offset = "0x1AF80DC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAEncryptionPadding), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(RSAEncryptionPadding),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAEncryptionPadding), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(RSAEncryptionPadding),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAEncryptionPadding), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(RSAEncryptionPadding),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(RSAEncryptionPadding other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF81FC", Offset = "0x1AF81FC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Encrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSACryptoServiceProvider), Member = "Decrypt", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(RSAEncryptionPadding)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAEncryptionPadding), Member = "Equals", MemberParameters = new object[] { typeof(RSAEncryptionPadding) }, ReturnType = typeof(bool))]
		public static bool operator ==(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8178", Offset = "0x1AF8178", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RSAEncryptionPadding), Member = "Equals", MemberParameters = new object[] { typeof(RSAEncryptionPadding) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAEncryptionPadding), Member = "Equals", MemberParameters = new object[] { typeof(RSAEncryptionPadding) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8210", Offset = "0x1AF8210", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60017E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF8284", Offset = "0x1AF8284", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RSAEncryptionPadding), Member = "CreateOaep", MemberParameters = new object[] { typeof(HashAlgorithmName) }, ReturnType = typeof(RSAEncryptionPadding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static RSAEncryptionPadding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF83D8", Offset = "0x1AF83D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RSAEncryptionPadding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000C65")]
		private static readonly RSAEncryptionPadding s_pkcs1;

		[global::Cpp2ILInjected.Token(Token = "0x4000C66")]
		private static readonly RSAEncryptionPadding s_oaepSHA1;

		[global::Cpp2ILInjected.Token(Token = "0x4000C67")]
		private static readonly RSAEncryptionPadding s_oaepSHA256;

		[global::Cpp2ILInjected.Token(Token = "0x4000C68")]
		private static readonly RSAEncryptionPadding s_oaepSHA384;

		[global::Cpp2ILInjected.Token(Token = "0x4000C69")]
		private static readonly RSAEncryptionPadding s_oaepSHA512;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RSAEncryptionPaddingMode _mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000C6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private HashAlgorithmName _oaepHashAlgorithm;
	}
}
