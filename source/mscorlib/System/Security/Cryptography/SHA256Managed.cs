using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002FC")]
	public class SHA256Managed : SHA256
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0DEF0", Offset = "0x1B0DEF0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA256), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256), Member = "Create", ReturnType = typeof(SHA256))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SHA256Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E090", Offset = "0x1B0E090", Length = "0x50")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60019DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E0E0", Offset = "0x1B0E0E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E2B0", Offset = "0x1B0E2B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E070", Offset = "0x1B0E070", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitializeState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E0E4", Offset = "0x1B0E0E4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E2B4", Offset = "0x1B0E2B4", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new object[]
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

		[global::Cpp2ILInjected.Token(Token = "0x60019E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E3D8", Offset = "0x1B0E3D8", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "_HashData", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = "SHA256Expand", MemberParameters = new object[] { typeof(uint*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = "Sigma_1", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = "Sigma_0", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E9F4", Offset = "0x1B0E9F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint RotateRight(uint x, int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E974", Offset = "0x1B0E974", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint Ch(uint x, uint y, uint z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E9E0", Offset = "0x1B0E9E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint Maj(uint x, uint y, uint z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E9FC", Offset = "0x1B0E9FC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "SHA256Expand", MemberParameters = new object[] { typeof(uint*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static uint sigma_0(uint x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0EA58", Offset = "0x1B0EA58", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "SHA256Expand", MemberParameters = new object[] { typeof(uint*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static uint sigma_1(uint x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E984", Offset = "0x1B0E984", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static uint Sigma_0(uint x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E918", Offset = "0x1B0E918", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static uint Sigma_1(uint x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0E870", Offset = "0x1B0E870", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA256Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = "sigma_1", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA256Managed), Member = "sigma_0", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void SHA256Expand(uint* x)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60019E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0EAB4", Offset = "0x1B0EAB4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static SHA256Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D17")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000D18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long _count;

		[global::Cpp2ILInjected.Token(Token = "0x4000D19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint[] _stateSHA256;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private uint[] _W;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1B")]
		private static readonly uint[] _K;
	}
}
