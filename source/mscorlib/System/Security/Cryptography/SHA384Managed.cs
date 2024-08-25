using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002FE")]
	public class SHA384Managed : SHA384
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0EB68", Offset = "0x1B0EB68", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA384), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384), Member = "Create", ReturnType = typeof(SHA384))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SHA384Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ED30", Offset = "0x1B0ED30", Length = "0x64")]
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

		[global::Cpp2ILInjected.Token(Token = "0x60019EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ED94", Offset = "0x1B0ED94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0EF64", Offset = "0x1B0EF64", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ECFC", Offset = "0x1B0ECFC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitializeState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0ED98", Offset = "0x1B0ED98", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new object[]
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

		[global::Cpp2ILInjected.Token(Token = "0x60019F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0EF68", Offset = "0x1B0EF68", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = "_HashData", MemberParameters = new object[]
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

		[global::Cpp2ILInjected.Token(Token = "0x60019F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F08C", Offset = "0x1B0F08C", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "_HashData", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = "SHA384Expand", MemberParameters = new object[] { typeof(ulong*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = "Sigma_1", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = "Sigma_0", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private unsafe static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F7C0", Offset = "0x1B0F7C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong RotateRight(ulong x, int n)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F740", Offset = "0x1B0F740", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F7AC", Offset = "0x1B0F7AC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F750", Offset = "0x1B0F750", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new object[]
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

		[global::Cpp2ILInjected.Token(Token = "0x60019F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F6E4", Offset = "0x1B0F6E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new object[]
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

		[global::Cpp2ILInjected.Token(Token = "0x60019FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F7C8", Offset = "0x1B0F7C8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "SHA384Expand", MemberParameters = new object[] { typeof(ulong*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ulong sigma_0(ulong x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F824", Offset = "0x1B0F824", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "SHA384Expand", MemberParameters = new object[] { typeof(ulong*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static ulong sigma_1(ulong x)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F63C", Offset = "0x1B0F63C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA384Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(ulong*),
			typeof(ulong*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = "sigma_1", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA384Managed), Member = "sigma_0", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void SHA384Expand(ulong* x)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60019FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0F880", Offset = "0x1B0F880", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static SHA384Managed()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ulong _count;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ulong[] _stateSHA384;

		[global::Cpp2ILInjected.Token(Token = "0x4000D1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ulong[] _W;

		[global::Cpp2ILInjected.Token(Token = "0x4000D20")]
		private static readonly ulong[] _K;
	}
}
