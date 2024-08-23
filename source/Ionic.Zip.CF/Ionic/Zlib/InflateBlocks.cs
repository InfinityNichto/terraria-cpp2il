using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000038 RID: 56
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	internal sealed class InflateBlocks
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0000588D File Offset: 0x00003A8D
		[global::Cpp2ILInjected.Token(Token = "0x600037A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6FBF4", Offset = "0x1A6FBF4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
		{
			throw null;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00005890 File Offset: 0x00003A90
		[global::Cpp2ILInjected.Token(Token = "0x600037B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6FD34", Offset = "0x1A6FD34", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "Reset", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "End", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "Sync", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "EndInflate", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal uint Reset()
		{
			throw null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00005893 File Offset: 0x00003A93
		[global::Cpp2ILInjected.Token(Token = "0x600037C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A70050", Offset = "0x1A70050", Length = "0xE74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateManager), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InfTree), Member = "inflate_trees_fixed", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int[][]),
			typeof(int[][]),
			typeof(ZlibCodec)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Flush", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InfTree), Member = "inflate_trees_bits", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(ZlibCodec)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InfTree), Member = "inflate_trees_dynamic", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(ZlibCodec)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateCodes), Member = "Process", MemberParameters = new object[]
		{
			typeof(InflateBlocks),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal int Process(int r)
		{
			throw null;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00005896 File Offset: 0x00003A96
		[global::Cpp2ILInjected.Token(Token = "0x600037D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71CF8", Offset = "0x1A71CF8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		internal void Free()
		{
			throw null;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00005899 File Offset: 0x00003A99
		[global::Cpp2ILInjected.Token(Token = "0x600037E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71D10", Offset = "0x1A71D10", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void SetDictionary(byte[] d, int start, int n)
		{
			throw null;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000589C File Offset: 0x00003A9C
		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71D50", Offset = "0x1A71D50", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int SyncPoint()
		{
			throw null;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000589F File Offset: 0x00003A9F
		[global::Cpp2ILInjected.Token(Token = "0x6000380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A70EC4", Offset = "0x1A70EC4", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateCodes), Member = "Process", MemberParameters = new object[]
		{
			typeof(InflateBlocks),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Adler), Member = "Adler32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int Flush(int r)
		{
			throw null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000058A2 File Offset: 0x00003AA2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000381")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71D60", Offset = "0x1A71D60", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static InflateBlocks()
		{
			throw null;
		}

		// Token: 0x040001E7 RID: 487
		[global::Cpp2ILInjected.Token(Token = "0x4000239")]
		private const int MANY = 1440;

		// Token: 0x040001E8 RID: 488
		[global::Cpp2ILInjected.Token(Token = "0x400023A")]
		internal static readonly int[] border;

		// Token: 0x040001E9 RID: 489
		[global::Cpp2ILInjected.Token(Token = "0x400023B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InflateBlocks.InflateBlockMode mode;

		// Token: 0x040001EA RID: 490
		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int left;

		// Token: 0x040001EB RID: 491
		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int table;

		// Token: 0x040001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int index;

		// Token: 0x040001ED RID: 493
		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int[] blens;

		// Token: 0x040001EE RID: 494
		[global::Cpp2ILInjected.Token(Token = "0x4000240")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int[] bb;

		// Token: 0x040001EF RID: 495
		[global::Cpp2ILInjected.Token(Token = "0x4000241")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int[] tb;

		// Token: 0x040001F0 RID: 496
		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal InflateCodes codes;

		// Token: 0x040001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int last;

		// Token: 0x040001F2 RID: 498
		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ZlibCodec _codec;

		// Token: 0x040001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int bitk;

		// Token: 0x040001F4 RID: 500
		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		internal int bitb;

		// Token: 0x040001F5 RID: 501
		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int[] hufts;

		// Token: 0x040001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal byte[] window;

		// Token: 0x040001F7 RID: 503
		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal int end;

		// Token: 0x040001F8 RID: 504
		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		internal int readAt;

		// Token: 0x040001F9 RID: 505
		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal int writeAt;

		// Token: 0x040001FA RID: 506
		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal object checkfn;

		// Token: 0x040001FB RID: 507
		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal uint check;

		// Token: 0x040001FC RID: 508
		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal InfTree inftree;

		// Token: 0x02000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x2000046")]
		private enum InflateBlockMode
		{
			// Token: 0x04000331 RID: 817
			[global::Cpp2ILInjected.Token(Token = "0x4000250")]
			TYPE,
			// Token: 0x04000332 RID: 818
			[global::Cpp2ILInjected.Token(Token = "0x4000251")]
			LENS,
			// Token: 0x04000333 RID: 819
			[global::Cpp2ILInjected.Token(Token = "0x4000252")]
			STORED,
			// Token: 0x04000334 RID: 820
			[global::Cpp2ILInjected.Token(Token = "0x4000253")]
			TABLE,
			// Token: 0x04000335 RID: 821
			[global::Cpp2ILInjected.Token(Token = "0x4000254")]
			BTREE,
			// Token: 0x04000336 RID: 822
			[global::Cpp2ILInjected.Token(Token = "0x4000255")]
			DTREE,
			// Token: 0x04000337 RID: 823
			[global::Cpp2ILInjected.Token(Token = "0x4000256")]
			CODES,
			// Token: 0x04000338 RID: 824
			[global::Cpp2ILInjected.Token(Token = "0x4000257")]
			DRY,
			// Token: 0x04000339 RID: 825
			[global::Cpp2ILInjected.Token(Token = "0x4000258")]
			DONE,
			// Token: 0x0400033A RID: 826
			[global::Cpp2ILInjected.Token(Token = "0x4000259")]
			BAD
		}
	}
}
