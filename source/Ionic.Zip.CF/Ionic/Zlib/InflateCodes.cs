using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x0200003A RID: 58
	[global::Cpp2ILInjected.Token(Token = "0x2000048")]
	internal sealed class InflateCodes
	{
		// Token: 0x06000365 RID: 869 RVA: 0x000058A8 File Offset: 0x00003AA8
		[global::Cpp2ILInjected.Token(Token = "0x6000383")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6FD24", Offset = "0x1A6FD24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal InflateCodes()
		{
			throw null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000058AB File Offset: 0x00003AAB
		[global::Cpp2ILInjected.Token(Token = "0x6000384")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71134", Offset = "0x1A71134", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
		{
			throw null;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000058AE File Offset: 0x00003AAE
		[global::Cpp2ILInjected.Token(Token = "0x6000385")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71454", Offset = "0x1A71454", Length = "0x8A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateCodes), Member = "InflateFast", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(int[]),
			typeof(int),
			typeof(InflateBlocks),
			typeof(ZlibCodec)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Flush", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal int Process(InflateBlocks blocks, int r)
		{
			throw null;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000058B1 File Offset: 0x00003AB1
		[global::Cpp2ILInjected.Token(Token = "0x6000386")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71E88", Offset = "0x1A71E88", Length = "0x6B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateCodes), Member = "Process", MemberParameters = new object[]
		{
			typeof(InflateBlocks),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z)
		{
			throw null;
		}

		// Token: 0x040001FE RID: 510
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		private const int START = 0;

		// Token: 0x040001FF RID: 511
		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		private const int LEN = 1;

		// Token: 0x04000200 RID: 512
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		private const int LENEXT = 2;

		// Token: 0x04000201 RID: 513
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		private const int DIST = 3;

		// Token: 0x04000202 RID: 514
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		private const int DISTEXT = 4;

		// Token: 0x04000203 RID: 515
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		private const int COPY = 5;

		// Token: 0x04000204 RID: 516
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		private const int LIT = 6;

		// Token: 0x04000205 RID: 517
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		private const int WASH = 7;

		// Token: 0x04000206 RID: 518
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		private const int END = 8;

		// Token: 0x04000207 RID: 519
		[global::Cpp2ILInjected.Token(Token = "0x4000264")]
		private const int BADCODE = 9;

		// Token: 0x04000208 RID: 520
		[global::Cpp2ILInjected.Token(Token = "0x4000265")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int mode;

		// Token: 0x04000209 RID: 521
		[global::Cpp2ILInjected.Token(Token = "0x4000266")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int len;

		// Token: 0x0400020A RID: 522
		[global::Cpp2ILInjected.Token(Token = "0x4000267")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] tree;

		// Token: 0x0400020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int tree_index;

		// Token: 0x0400020C RID: 524
		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int need;

		// Token: 0x0400020D RID: 525
		[global::Cpp2ILInjected.Token(Token = "0x400026A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int lit;

		// Token: 0x0400020E RID: 526
		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int bitsToGet;

		// Token: 0x0400020F RID: 527
		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int dist;

		// Token: 0x04000210 RID: 528
		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal byte lbits;

		// Token: 0x04000211 RID: 529
		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		internal byte dbits;

		// Token: 0x04000212 RID: 530
		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal int[] ltree;

		// Token: 0x04000213 RID: 531
		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int ltree_index;

		// Token: 0x04000214 RID: 532
		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int[] dtree;

		// Token: 0x04000215 RID: 533
		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int dtree_index;
	}
}
