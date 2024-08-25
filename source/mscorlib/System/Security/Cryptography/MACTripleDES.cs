using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002E3")]
	public class MACTripleDES : KeyedHashAlgorithm
	{
		[global::Cpp2ILInjected.Token(Token = "0x60018C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF0E8", Offset = "0x1AFF0E8", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "get_StaticRandomNumberGenerator", ReturnType = typeof(RNGCryptoServiceProvider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "Create", ReturnType = typeof(TripleDES))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public MACTripleDES()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF22C", Offset = "0x1AFF22C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MACTripleDES(byte[] rgbKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF284", Offset = "0x1AFF284", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(TripleDES))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TripleDES), Member = "Create", ReturnType = typeof(TripleDES))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public MACTripleDES(string strTripleDES, byte[] rgbKey)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF430", Offset = "0x1AFF430", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Initialize()
		{
			throw null;
		}

		[global::System.Runtime.InteropServices.ComVisible(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170002A5")]
		public PaddingMode Padding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFF438", Offset = "0x1AFF438", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFF44C", Offset = "0x1AFF44C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF4C8", Offset = "0x1AFF4C8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TailStream), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(ICryptoTransform),
			typeof(CryptoStreamMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void HashCore(byte[] rgbData, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF6AC", Offset = "0x1AFF6AC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TailStream), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(ICryptoTransform),
			typeof(CryptoStreamMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "FlushFinalBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60018D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF848", Offset = "0x1AFF848", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoStream), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000CBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ICryptoTransform m_encryptor;

		[global::Cpp2ILInjected.Token(Token = "0x4000CBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private CryptoStream _cs;

		[global::Cpp2ILInjected.Token(Token = "0x4000CBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private TailStream _ts;

		[global::Cpp2ILInjected.Token(Token = "0x4000CBE")]
		private const int m_bitsPerByte = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4000CBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int m_bytesPerBlock;

		[global::Cpp2ILInjected.Token(Token = "0x4000CC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private TripleDES des;
	}
}
