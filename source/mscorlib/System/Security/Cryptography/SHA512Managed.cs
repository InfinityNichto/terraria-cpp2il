using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000300")]
	public class SHA512Managed : SHA512
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001A01")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F934", Offset = "0x1B0F934", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA512), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512), Member = "Create", ReturnType = typeof(SHA512))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SHA512Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FAFC", Offset = "0x1B0FAFC", Length = "0x64")]
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

		[global::Cpp2ILInjected.Token(Token = "0x6001A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FB60", Offset = "0x1B0FB60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FD30", Offset = "0x1B0FD30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FAC8", Offset = "0x1B0FAC8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitializeState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FB64", Offset = "0x1B0FB64", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(ulong*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private unsafe void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A07")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FD34", Offset = "0x1B0FD34", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "QuadWordToBigEndian", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ulong[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private byte[] _EndHash()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A08")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FE58", Offset = "0x1B0FE58", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "QuadWordFromBigEndian", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(int),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = "SHA512Expand", MemberParameters = new object[] { typeof(ulong*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = "Sigma_1", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = "Sigma_0", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10474", Offset = "0x1B10474", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong RotateRight(ulong x, int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B103F4", Offset = "0x1B103F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10460", Offset = "0x1B10460", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10404", Offset = "0x1B10404", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(ulong*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ulong Sigma_0(ulong x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10398", Offset = "0x1B10398", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(ulong*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ulong Sigma_1(ulong x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1047C", Offset = "0x1B1047C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "SHA512Expand", MemberParameters = new object[] { typeof(ulong*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ulong sigma_0(ulong x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B104D8", Offset = "0x1B104D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "SHA512Expand", MemberParameters = new object[] { typeof(ulong*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ulong sigma_1(ulong x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001A10")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B102F0", Offset = "0x1B102F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA512Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(ulong*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = "sigma_1", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA512Managed), Member = "sigma_0", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void SHA512Expand(ulong* x)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10534", Offset = "0x1B10534", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static SHA512Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000D22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ulong _count;

		[global::Cpp2ILInjected.Token(Token = "0x4000D23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ulong[] _stateSHA512;

		[global::Cpp2ILInjected.Token(Token = "0x4000D24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ulong[] _W;

		[global::Cpp2ILInjected.Token(Token = "0x4000D25")]
		private static readonly ulong[] _K;
	}
}
