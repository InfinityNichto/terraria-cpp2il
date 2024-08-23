using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x0200003C RID: 60
	[global::Cpp2ILInjected.Token(Token = "0x200004B")]
	internal sealed class InfTree
	{
		// Token: 0x06000375 RID: 885 RVA: 0x000058D8 File Offset: 0x00003AD8
		[global::Cpp2ILInjected.Token(Token = "0x6000393")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A731B0", Offset = "0x1A731B0", Length = "0x580")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InfTree), Member = "inflate_trees_bits", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(ZlibCodec)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InfTree), Member = "inflate_trees_dynamic", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
		{
			throw null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000058DB File Offset: 0x00003ADB
		[global::Cpp2ILInjected.Token(Token = "0x6000394")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71158", Offset = "0x1A71158", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InfTree), Member = "initWorkArea", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InfTree), Member = "huft_build", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
		{
			throw null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000058DE File Offset: 0x00003ADE
		[global::Cpp2ILInjected.Token(Token = "0x6000395")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71244", Offset = "0x1A71244", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InfTree), Member = "initWorkArea", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InfTree), Member = "huft_build", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
		{
			throw null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000058E1 File Offset: 0x00003AE1
		[global::Cpp2ILInjected.Token(Token = "0x6000396")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71058", Offset = "0x1A71058", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InflateBlocks), Member = "Process", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)
		{
			throw null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000058E4 File Offset: 0x00003AE4
		[global::Cpp2ILInjected.Token(Token = "0x6000397")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A73738", Offset = "0x1A73738", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InfTree), Member = "inflate_trees_bits", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(ZlibCodec)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InfTree), Member = "inflate_trees_dynamic", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void initWorkArea(int vsize)
		{
			throw null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000058E7 File Offset: 0x00003AE7
		[global::Cpp2ILInjected.Token(Token = "0x6000398")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6FD2C", Offset = "0x1A6FD2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InfTree()
		{
			throw null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000058EA File Offset: 0x00003AEA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000399")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A73864", Offset = "0x1A73864", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		static InfTree()
		{
			throw null;
		}

		// Token: 0x04000222 RID: 546
		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		private const int MANY = 1440;

		// Token: 0x04000223 RID: 547
		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		private const int Z_OK = 0;

		// Token: 0x04000224 RID: 548
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		private const int Z_STREAM_END = 1;

		// Token: 0x04000225 RID: 549
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000226 RID: 550
		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		private const int Z_ERRNO = -1;

		// Token: 0x04000227 RID: 551
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000228 RID: 552
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000229 RID: 553
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		private const int Z_MEM_ERROR = -4;

		// Token: 0x0400022A RID: 554
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		private const int Z_BUF_ERROR = -5;

		// Token: 0x0400022B RID: 555
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x0400022C RID: 556
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		internal const int fixed_bl = 9;

		// Token: 0x0400022D RID: 557
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		internal const int fixed_bd = 5;

		// Token: 0x0400022E RID: 558
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		internal const int BMAX = 15;

		// Token: 0x0400022F RID: 559
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		internal static readonly int[] fixed_tl;

		// Token: 0x04000230 RID: 560
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		internal static readonly int[] fixed_td;

		// Token: 0x04000231 RID: 561
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		internal static readonly int[] cplens;

		// Token: 0x04000232 RID: 562
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		internal static readonly int[] cplext;

		// Token: 0x04000233 RID: 563
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		internal static readonly int[] cpdist;

		// Token: 0x04000234 RID: 564
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		internal static readonly int[] cpdext;

		// Token: 0x04000235 RID: 565
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int[] hn;

		// Token: 0x04000236 RID: 566
		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] v;

		// Token: 0x04000237 RID: 567
		[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int[] c;

		// Token: 0x04000238 RID: 568
		[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int[] r;

		// Token: 0x04000239 RID: 569
		[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int[] u;

		// Token: 0x0400023A RID: 570
		[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal int[] x;
	}
}
