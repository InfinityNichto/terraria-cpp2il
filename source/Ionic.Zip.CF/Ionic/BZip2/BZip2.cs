using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.BZip2
{
	// Token: 0x02000030 RID: 48
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	internal static class BZip2
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00005710 File Offset: 0x00003910
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

		// Token: 0x060002DE RID: 734 RVA: 0x00005713 File Offset: 0x00003913
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

		// Token: 0x04000171 RID: 369
		[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
		public static readonly int BlockSizeMultiple;

		// Token: 0x04000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
		public static readonly int MinBlockSize;

		// Token: 0x04000173 RID: 371
		[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
		public static readonly int MaxBlockSize;

		// Token: 0x04000174 RID: 372
		[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
		public static readonly int MaxAlphaSize;

		// Token: 0x04000175 RID: 373
		[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
		public static readonly int MaxCodeLength;

		// Token: 0x04000176 RID: 374
		[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
		public static readonly char RUNA;

		// Token: 0x04000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
		public static readonly char RUNB;

		// Token: 0x04000178 RID: 376
		[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
		public static readonly int NGroups;

		// Token: 0x04000179 RID: 377
		[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
		public static readonly int G_SIZE;

		// Token: 0x0400017A RID: 378
		[global::Cpp2ILInjected.Token(Token = "0x40001C1")]
		public static readonly int N_ITERS;

		// Token: 0x0400017B RID: 379
		[global::Cpp2ILInjected.Token(Token = "0x40001C2")]
		public static readonly int MaxSelectors;

		// Token: 0x0400017C RID: 380
		[global::Cpp2ILInjected.Token(Token = "0x40001C3")]
		public static readonly int NUM_OVERSHOOT_BYTES;

		// Token: 0x0400017D RID: 381
		[global::Cpp2ILInjected.Token(Token = "0x40001C4")]
		internal static readonly int QSORT_STACK_SIZE;
	}
}
