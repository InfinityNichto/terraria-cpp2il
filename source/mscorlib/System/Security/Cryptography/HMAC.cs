using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002DA")]
	public abstract class HMAC : KeyedHashAlgorithm
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000299")]
		protected int BlockSizeValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001899")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFDC98", Offset = "0x1AFDC98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600189A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFDCA0", Offset = "0x1AFDCA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFDCA8", Offset = "0x1AFDCA8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void UpdateIOPadBuffers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600189C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFDDAC", Offset = "0x1AFDDAC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMAC), Member = "set_Key", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACMD5), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACRIPEMD160), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA384), Member = "set_ProduceLegacyHmacValues", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA512), Member = "set_ProduceLegacyHmacValues", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "UpdateIOPadBuffers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void InitializeKey(byte[] key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700029A")]
		public override byte[] Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x600189D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFDE70", Offset = "0x1AFDE70", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600189E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFDEE0", Offset = "0x1AFDEE0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMAC), Member = "InitializeKey", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700029B")]
		public string HashName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600189F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFDF48", Offset = "0x1AFDF48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFDF50", Offset = "0x1AFDF50", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HashAlgorithm))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFDFDC", Offset = "0x1AFDFDC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.PKCS12", Member = "MAC", MemberParameters = new object[]
		{
			"System.Byte[]",
			"System.Byte[]",
			typeof(int),
			"System.Byte[]"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HMACSHA1), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public new static HMAC Create()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE094", Offset = "0x1AFE094", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public new static HMAC Create(string algorithmName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE138", Offset = "0x1AFE138", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE174", Offset = "0x1AFE174", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		protected override void HashCore(byte[] rgb, int ib, int cb)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE1E4", Offset = "0x1AFE1E4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE2E4", Offset = "0x1AFE2E4", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE478", Offset = "0x1AFE478", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "get_AllowOnlyFipsAlgorithms", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static HashAlgorithm GetHashAlgorithmWithFipsFallback(global::System.Func<HashAlgorithm> createStandardHashAlgorithmCallback, global::System.Func<HashAlgorithm> createFipsHashAlgorithmCallback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE5CC", Offset = "0x1AFE5CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected HMAC()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000CB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int blockSizeValue;

		[global::Cpp2ILInjected.Token(Token = "0x4000CB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string m_hashName;

		[global::Cpp2ILInjected.Token(Token = "0x4000CB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal HashAlgorithm m_hash1;

		[global::Cpp2ILInjected.Token(Token = "0x4000CB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal HashAlgorithm m_hash2;

		[global::Cpp2ILInjected.Token(Token = "0x4000CB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] m_inner;

		[global::Cpp2ILInjected.Token(Token = "0x4000CB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte[] m_outer;

		[global::Cpp2ILInjected.Token(Token = "0x4000CB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool m_hashing;
	}
}
