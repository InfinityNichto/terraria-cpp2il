using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Numerics
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	internal static class NumericsHelpers
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000020CB File Offset: 0x000002CB
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D552CC", Offset = "0x1D552CC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ReadOnlySpan<byte>),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "op_RightShift", MemberParameters = new object[]
		{
			typeof(BigInteger),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static void DangerousMakeTwosComplement(uint[] d)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020CE File Offset: 0x000002CE
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5848C", Offset = "0x1D5848C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ulong MakeUlong(uint uHi, uint uLo)
		{
			throw null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020D1 File Offset: 0x000002D1
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5602C", Offset = "0x1D5602C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static uint Abs(int a)
		{
			throw null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020D4 File Offset: 0x000002D4
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D585DC", Offset = "0x1D585DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static uint CombineHash(uint u1, uint u2)
		{
			throw null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020D7 File Offset: 0x000002D7
		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D5556C", Offset = "0x1D5556C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int CombineHash(int n1, int n2)
		{
			throw null;
		}
	}
}
