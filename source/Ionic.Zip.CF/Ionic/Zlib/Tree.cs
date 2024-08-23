using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x0200003D RID: 61
	[global::Cpp2ILInjected.Token(Token = "0x200004C")]
	internal sealed class Tree
	{
		// Token: 0x0600037C RID: 892 RVA: 0x000058ED File Offset: 0x00003AED
		[global::Cpp2ILInjected.Token(Token = "0x600039A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A73A34", Offset = "0x1A73A34", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_tally", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "send_compressed_block", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int DistanceCode(int dist)
		{
			throw null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000058F0 File Offset: 0x00003AF0
		[global::Cpp2ILInjected.Token(Token = "0x600039B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A73AAC", Offset = "0x1A73AAC", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tree), Member = "build_tree", MemberParameters = new object[] { typeof(DeflateManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void gen_bitlen(DeflateManager s)
		{
			throw null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000058F3 File Offset: 0x00003AF3
		[global::Cpp2ILInjected.Token(Token = "0x600039C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A73D68", Offset = "0x1A73D68", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "build_bl_tree", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "pqdownheap", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tree), Member = "gen_bitlen", MemberParameters = new object[] { typeof(DeflateManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void build_tree(DeflateManager s)
		{
			throw null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000058F6 File Offset: 0x00003AF6
		[global::Cpp2ILInjected.Token(Token = "0x600039D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A740A4", Offset = "0x1A740A4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
		{
			throw null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000058F9 File Offset: 0x00003AF9
		[global::Cpp2ILInjected.Token(Token = "0x600039E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74228", Offset = "0x1A74228", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static int bi_reverse(int code, int len)
		{
			throw null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x000058FC File Offset: 0x00003AFC
		[global::Cpp2ILInjected.Token(Token = "0x600039F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74250", Offset = "0x1A74250", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Tree()
		{
			throw null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000058FF File Offset: 0x00003AFF
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74258", Offset = "0x1A74258", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		static Tree()
		{
			throw null;
		}

		// Token: 0x0400023B RID: 571
		[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
		internal const int Buf_size = 16;

		// Token: 0x0400023C RID: 572
		[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
		private static readonly int HEAP_SIZE;

		// Token: 0x0400023D RID: 573
		[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
		internal static readonly int[] ExtraLengthBits;

		// Token: 0x0400023E RID: 574
		[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
		internal static readonly int[] ExtraDistanceBits;

		// Token: 0x0400023F RID: 575
		[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
		internal static readonly int[] extra_blbits;

		// Token: 0x04000240 RID: 576
		[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
		internal static readonly sbyte[] bl_order;

		// Token: 0x04000241 RID: 577
		[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
		private static readonly sbyte[] _dist_code;

		// Token: 0x04000242 RID: 578
		[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
		internal static readonly sbyte[] LengthCode;

		// Token: 0x04000243 RID: 579
		[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
		internal static readonly int[] LengthBase;

		// Token: 0x04000244 RID: 580
		[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
		internal static readonly int[] DistanceBase;

		// Token: 0x04000245 RID: 581
		[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal short[] dyn_tree;

		// Token: 0x04000246 RID: 582
		[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int max_code;

		// Token: 0x04000247 RID: 583
		[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal StaticTree staticTree;
	}
}
