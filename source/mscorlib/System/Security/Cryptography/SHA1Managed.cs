using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002FA")]
	public class SHA1Managed : SHA1
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D5A8", Offset = "0x1B0D5A8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SHA1Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D6B8", Offset = "0x1B0D6B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D70C", Offset = "0x1B0D70C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D88C", Offset = "0x1B0D88C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D694", Offset = "0x1B0D694", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitializeState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D710", Offset = "0x1B0D710", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		private unsafe void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D890", Offset = "0x1B0D890", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DWORDToBigEndian", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private byte[] _EndHash()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D9B4", Offset = "0x1B0D9B4", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DWORDFromBigEndian", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(int),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Managed), Member = "SHAExpand", MemberParameters = new object[] { typeof(uint*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0DE94", Offset = "0x1B0DE94", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe static void SHAExpand(uint* x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000D14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long _count;

		[global::Cpp2ILInjected.Token(Token = "0x4000D15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint[] _stateSHA1;

		[global::Cpp2ILInjected.Token(Token = "0x4000D16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private uint[] _expandedBuffer;
	}
}
