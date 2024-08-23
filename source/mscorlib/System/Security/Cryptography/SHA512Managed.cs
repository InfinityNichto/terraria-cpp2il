using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000263 RID: 611
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000300")]
	public class SHA512Managed : SHA512
	{
		// Token: 0x060017E7 RID: 6119 RVA: 0x00018845 File Offset: 0x00016A45
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

		// Token: 0x060017E8 RID: 6120 RVA: 0x00018848 File Offset: 0x00016A48
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

		// Token: 0x060017E9 RID: 6121 RVA: 0x0001884B File Offset: 0x00016A4B
		[global::Cpp2ILInjected.Token(Token = "0x6001A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FB60", Offset = "0x1B0FB60", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x0001884E File Offset: 0x00016A4E
		[global::Cpp2ILInjected.Token(Token = "0x6001A04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FD30", Offset = "0x1B0FD30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00018851 File Offset: 0x00016A51
		[global::Cpp2ILInjected.Token(Token = "0x6001A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0FAC8", Offset = "0x1B0FAC8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitializeState()
		{
			throw null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00018854 File Offset: 0x00016A54
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

		// Token: 0x060017ED RID: 6125 RVA: 0x00018857 File Offset: 0x00016A57
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

		// Token: 0x060017EE RID: 6126 RVA: 0x0001885A File Offset: 0x00016A5A
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

		// Token: 0x060017EF RID: 6127 RVA: 0x0001885D File Offset: 0x00016A5D
		[global::Cpp2ILInjected.Token(Token = "0x6001A09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10474", Offset = "0x1B10474", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong RotateRight(ulong x, int n)
		{
			throw null;
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00018860 File Offset: 0x00016A60
		[global::Cpp2ILInjected.Token(Token = "0x6001A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B103F4", Offset = "0x1B103F4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			throw null;
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00018863 File Offset: 0x00016A63
		[global::Cpp2ILInjected.Token(Token = "0x6001A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B10460", Offset = "0x1B10460", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			throw null;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00018866 File Offset: 0x00016A66
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

		// Token: 0x060017F3 RID: 6131 RVA: 0x00018869 File Offset: 0x00016A69
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

		// Token: 0x060017F4 RID: 6132 RVA: 0x0001886C File Offset: 0x00016A6C
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

		// Token: 0x060017F5 RID: 6133 RVA: 0x0001886F File Offset: 0x00016A6F
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

		// Token: 0x060017F6 RID: 6134 RVA: 0x00018872 File Offset: 0x00016A72
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

		// Token: 0x060017F7 RID: 6135 RVA: 0x00018875 File Offset: 0x00016A75
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

		// Token: 0x04000A47 RID: 2631
		[global::Cpp2ILInjected.Token(Token = "0x4000D21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000A48 RID: 2632
		[global::Cpp2ILInjected.Token(Token = "0x4000D22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ulong _count;

		// Token: 0x04000A49 RID: 2633
		[global::Cpp2ILInjected.Token(Token = "0x4000D23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ulong[] _stateSHA512;

		// Token: 0x04000A4A RID: 2634
		[global::Cpp2ILInjected.Token(Token = "0x4000D24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ulong[] _W;

		// Token: 0x04000A4B RID: 2635
		[global::Cpp2ILInjected.Token(Token = "0x4000D25")]
		private static readonly ulong[] _K;
	}
}
