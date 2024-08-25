using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Numerics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	internal static class BigIntegerCalculator
	{
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56038", Offset = "0x1D56038", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint[] Add(uint[] left, uint right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D560E4", Offset = "0x1D560E4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(int),
			typeof(uint*),
			typeof(int),
			typeof(uint*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public unsafe static uint[] Add(uint[] left, uint[] right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56D74", Offset = "0x1D56D74", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigIntegerCalculator), Member = "Add", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(uint[])
		}, ReturnType = typeof(uint[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56380", Offset = "0x1D56380", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint[] Subtract(uint[] left, uint right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56470", Offset = "0x1D56470", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(int),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(int),
			typeof(uint*),
			typeof(int),
			typeof(uint*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public unsafe static uint[] Subtract(uint[] left, uint[] right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56DFC", Offset = "0x1D56DFC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BigIntegerCalculator), Member = "Subtract", MemberParameters = new object[]
		{
			typeof(uint[]),
			typeof(uint[])
		}, ReturnType = typeof(uint[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56418", Offset = "0x1D56418", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int Compare(uint[] left, uint[] right)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D56E74", Offset = "0x1D56E74", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static BigIntegerCalculator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		private static int ReducerThreshold;

		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		private static int SquareThreshold;

		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		private static int AllocationThreshold;

		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		private static int MultiplyThreshold;
	}
}
