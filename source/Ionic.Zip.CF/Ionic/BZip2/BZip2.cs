using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.BZip2
{
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	internal static class BZip2
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1575BB8", Offset = "0x1575BB8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.BZip2.BZip2Compressor.CompressionState", Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static T[][] InitRectangularArray<T>(int d1, int d2)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67E64", Offset = "0x1A67E64", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static BZip2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		public static readonly int BlockSizeMultiple;

		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		public static readonly int MinBlockSize;

		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		public static readonly int MaxBlockSize;

		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		public static readonly int MaxAlphaSize;

		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		public static readonly int MaxCodeLength;

		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		public static readonly char RUNA;

		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		public static readonly char RUNB;

		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		public static readonly int NGroups;

		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		public static readonly int G_SIZE;

		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		public static readonly int N_ITERS;

		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		public static readonly int MaxSelectors;

		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		public static readonly int NUM_OVERSHOOT_BYTES;

		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		internal static readonly int QSORT_STACK_SIZE;
	}
}
