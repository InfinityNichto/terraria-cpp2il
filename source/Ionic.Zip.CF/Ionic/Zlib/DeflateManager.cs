using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000035 RID: 53
	[global::Cpp2ILInjected.Token(Token = "0x2000040")]
	internal sealed class DeflateManager
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0000575B File Offset: 0x0000395B
		[global::Cpp2ILInjected.Token(Token = "0x600030D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68A10", Offset = "0x1A68A10", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tree), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		internal DeflateManager()
		{
			throw null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000575E File Offset: 0x0000395E
		[global::Cpp2ILInjected.Token(Token = "0x600030E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68C04", Offset = "0x1A68C04", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager.Config), Member = "Lookup", MemberParameters = new object[] { typeof(CompressionLevel) }, ReturnType = typeof(DeflateManager.Config))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "SetDeflater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void _InitializeLazyMatch()
		{
			throw null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00005761 File Offset: 0x00003961
		[global::Cpp2ILInjected.Token(Token = "0x600030F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68DA0", Offset = "0x1A68DA0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void _InitializeTreeData()
		{
			throw null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00005764 File Offset: 0x00003964
		[global::Cpp2ILInjected.Token(Token = "0x6000310")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68E48", Offset = "0x1A68E48", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void _InitializeBlocks()
		{
			throw null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00005767 File Offset: 0x00003967
		[global::Cpp2ILInjected.Token(Token = "0x6000311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68FA4", Offset = "0x1A68FA4", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tree), Member = "build_tree", MemberParameters = new object[] { typeof(DeflateManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void pqdownheap(short[] tree, int k)
		{
			throw null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000576A File Offset: 0x0000396A
		[global::Cpp2ILInjected.Token(Token = "0x6000312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6915C", Offset = "0x1A6915C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			throw null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000576D File Offset: 0x0000396D
		[global::Cpp2ILInjected.Token(Token = "0x6000313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A691A4", Offset = "0x1A691A4", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "build_bl_tree", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void scan_tree(short[] tree, int max_code)
		{
			throw null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00005770 File Offset: 0x00003970
		[global::Cpp2ILInjected.Token(Token = "0x6000314")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69364", Offset = "0x1A69364", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "scan_tree", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tree), Member = "build_tree", MemberParameters = new object[] { typeof(DeflateManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal int build_bl_tree()
		{
			throw null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00005773 File Offset: 0x00003973
		[global::Cpp2ILInjected.Token(Token = "0x6000315")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69484", Offset = "0x1A69484", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_bits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_tree", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
			throw null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00005776 File Offset: 0x00003976
		[global::Cpp2ILInjected.Token(Token = "0x6000316")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6969C", Offset = "0x1A6969C", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "send_all_trees", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_bits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void send_tree(short[] tree, int max_code)
		{
			throw null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00005779 File Offset: 0x00003979
		[global::Cpp2ILInjected.Token(Token = "0x6000317")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69934", Offset = "0x1A69934", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void put_bytes(byte[] p, int start, int len)
		{
			throw null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000577C File Offset: 0x0000397C
		[global::Cpp2ILInjected.Token(Token = "0x6000318")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69910", Offset = "0x1A69910", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_bits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void send_code(int c, short[] tree)
		{
			throw null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000577F File Offset: 0x0000397F
		[global::Cpp2ILInjected.Token(Token = "0x6000319")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69590", Offset = "0x1A69590", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "send_all_trees", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "send_tree", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "send_code", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_align", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "send_compressed_block", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_stored_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void send_bits(int value, int length)
		{
			throw null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00005782 File Offset: 0x00003982
		[global::Cpp2ILInjected.Token(Token = "0x600031A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6997C", Offset = "0x1A6997C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_bits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "bi_flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void _tr_align()
		{
			throw null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00005785 File Offset: 0x00003985
		[global::Cpp2ILInjected.Token(Token = "0x600031B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69B94", Offset = "0x1A69B94", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateFast", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateSlow", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tree), Member = "DistanceCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal bool _tr_tally(int dist, int lc)
		{
			throw null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00005788 File Offset: 0x00003988
		[global::Cpp2ILInjected.Token(Token = "0x600031C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69E00", Offset = "0x1A69E00", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_bits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tree), Member = "DistanceCode", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void send_compressed_block(short[] ltree, short[] dtree)
		{
			throw null;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000578B File Offset: 0x0000398B
		[global::Cpp2ILInjected.Token(Token = "0x600031D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A0C4", Offset = "0x1A6A0C4", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void set_data_type()
		{
			throw null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000578E File Offset: 0x0000398E
		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69B00", Offset = "0x1A69B00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_align", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void bi_flush()
		{
			throw null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00005791 File Offset: 0x00003991
		[global::Cpp2ILInjected.Token(Token = "0x600031F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A1E8", Offset = "0x1A6A1E8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "copy_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void bi_windup()
		{
			throw null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00005794 File Offset: 0x00003994
		[global::Cpp2ILInjected.Token(Token = "0x6000320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A250", Offset = "0x1A6A250", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_stored_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "bi_windup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void copy_block(int buf, int len, bool header)
		{
			throw null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00005797 File Offset: 0x00003997
		[global::Cpp2ILInjected.Token(Token = "0x6000321")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A320", Offset = "0x1A6A320", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateNone", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateFast", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateSlow", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "flush_pending", ReturnType = typeof(void))]
		internal void flush_block_only(bool eof)
		{
			throw null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000579A File Offset: 0x0000399A
		[global::Cpp2ILInjected.Token(Token = "0x6000322")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A560", Offset = "0x1A6A560", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_fillWindow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "flush_block_only", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal BlockState DeflateNone(FlushType flush)
		{
			throw null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000579D File Offset: 0x0000399D
		[global::Cpp2ILInjected.Token(Token = "0x6000323")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A8CC", Offset = "0x1A6A8CC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_flush_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_bits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "copy_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
			throw null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000057A0 File Offset: 0x000039A0
		[global::Cpp2ILInjected.Token(Token = "0x6000324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A360", Offset = "0x1A6A360", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "flush_block_only", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "set_data_type", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tree), Member = "build_tree", MemberParameters = new object[] { typeof(DeflateManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "build_bl_tree", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_tr_stored_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_bits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_all_trees", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "send_compressed_block", MemberParameters = new object[]
		{
			typeof(short[]),
			typeof(short[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_InitializeBlocks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "bi_windup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
			throw null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000057A3 File Offset: 0x000039A3
		[global::Cpp2ILInjected.Token(Token = "0x6000325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A6C8", Offset = "0x1A6A6C8", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateNone", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateFast", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateSlow", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "read_buf", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void _fillWindow()
		{
			throw null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000057A6 File Offset: 0x000039A6
		[global::Cpp2ILInjected.Token(Token = "0x6000326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6A968", Offset = "0x1A6A968", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_fillWindow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "longest_match", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_tr_tally", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "flush_block_only", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal BlockState DeflateFast(FlushType flush)
		{
			throw null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000057A9 File Offset: 0x000039A9
		[global::Cpp2ILInjected.Token(Token = "0x6000327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6B08C", Offset = "0x1A6B08C", Length = "0x4F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_fillWindow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "longest_match", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_tr_tally", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "flush_block_only", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal BlockState DeflateSlow(FlushType flush)
		{
			throw null;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000057AC File Offset: 0x000039AC
		[global::Cpp2ILInjected.Token(Token = "0x6000328")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6AD3C", Offset = "0x1A6AD3C", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateFast", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "DeflateSlow", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(BlockState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal int longest_match(int cur_match)
		{
			throw null;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000057AF File Offset: 0x000039AF
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000057B2 File Offset: 0x000039B2
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		internal bool WantRfc1950HeaderBytes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000329")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6B57C", Offset = "0x1A6B57C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600032A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6B584", Offset = "0x1A6B584", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000057B5 File Offset: 0x000039B5
		[global::Cpp2ILInjected.Token(Token = "0x600032B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6B590", Offset = "0x1A6B590", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel),
			typeof(int)
		}, ReturnType = typeof(int))]
		internal int Initialize(ZlibCodec codec, CompressionLevel level)
		{
			throw null;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000057B8 File Offset: 0x000039B8
		[global::Cpp2ILInjected.Token(Token = "0x600032C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6B5A8", Offset = "0x1A6B5A8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel),
			typeof(int),
			typeof(int),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits)
		{
			throw null;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000057BB File Offset: 0x000039BB
		[global::Cpp2ILInjected.Token(Token = "0x600032D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6B8B0", Offset = "0x1A6B8B0", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel),
			typeof(int),
			typeof(int),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy)
		{
			throw null;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000057BE File Offset: 0x000039BE
		[global::Cpp2ILInjected.Token(Token = "0x600032E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6B63C", Offset = "0x1A6B63C", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel),
			typeof(int),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy)
		{
			throw null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000057C1 File Offset: 0x000039C1
		[global::Cpp2ILInjected.Token(Token = "0x600032F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6B948", Offset = "0x1A6B948", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel),
			typeof(int),
			typeof(int),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "ResetDeflate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Adler), Member = "Adler32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_InitializeTreeData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_InitializeLazyMatch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void Reset()
		{
			throw null;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000057C4 File Offset: 0x000039C4
		[global::Cpp2ILInjected.Token(Token = "0x6000330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6BA2C", Offset = "0x1A6BA2C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal int End()
		{
			throw null;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000057C7 File Offset: 0x000039C7
		[global::Cpp2ILInjected.Token(Token = "0x6000331")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68CE0", Offset = "0x1A68CE0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_InitializeLazyMatch", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "SetParams", MemberParameters = new object[]
		{
			typeof(CompressionLevel),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager.CompressFunc), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void SetDeflater()
		{
			throw null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000057CA File Offset: 0x000039CA
		[global::Cpp2ILInjected.Token(Token = "0x6000332")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6BB18", Offset = "0x1A6BB18", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "SetDeflateParams", MemberParameters = new object[]
		{
			typeof(CompressionLevel),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager.Config), Member = "Lookup", MemberParameters = new object[] { typeof(CompressionLevel) }, ReturnType = typeof(DeflateManager.Config))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "SetDeflater", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int SetParams(CompressionLevel level, CompressionStrategy strategy)
		{
			throw null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000057CD File Offset: 0x000039CD
		[global::Cpp2ILInjected.Token(Token = "0x6000333")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6BBEC", Offset = "0x1A6BBEC", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "SetDictionary", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal int SetDictionary(byte[] dictionary)
		{
			throw null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x000057D0 File Offset: 0x000039D0
		[global::Cpp2ILInjected.Token(Token = "0x6000334")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6BE60", Offset = "0x1A6BE60", Length = "0x620")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Adler), Member = "Adler32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "flush_pending", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_tr_align", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "_tr_stored_block", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		internal int Deflate(FlushType flush)
		{
			throw null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000057D3 File Offset: 0x000039D3
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000335")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6C480", Offset = "0x1A6C480", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		static DeflateManager()
		{
			throw null;
		}

		// Token: 0x04000190 RID: 400
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		private static readonly int MEM_LEVEL_MAX;

		// Token: 0x04000191 RID: 401
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		private static readonly int MEM_LEVEL_DEFAULT;

		// Token: 0x04000192 RID: 402
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DeflateManager.CompressFunc DeflateFunction;

		// Token: 0x04000193 RID: 403
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		private static readonly string[] _ErrorMessage;

		// Token: 0x04000194 RID: 404
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		private static readonly int PRESET_DICT;

		// Token: 0x04000195 RID: 405
		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		private static readonly int INIT_STATE;

		// Token: 0x04000196 RID: 406
		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		private static readonly int BUSY_STATE;

		// Token: 0x04000197 RID: 407
		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		private static readonly int FINISH_STATE;

		// Token: 0x04000198 RID: 408
		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		private static readonly int Z_DEFLATED;

		// Token: 0x04000199 RID: 409
		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		private static readonly int STORED_BLOCK;

		// Token: 0x0400019A RID: 410
		[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
		private static readonly int STATIC_TREES;

		// Token: 0x0400019B RID: 411
		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		private static readonly int DYN_TREES;

		// Token: 0x0400019C RID: 412
		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		private static readonly int Z_BINARY;

		// Token: 0x0400019D RID: 413
		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		private static readonly int Z_ASCII;

		// Token: 0x0400019E RID: 414
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		private static readonly int Z_UNKNOWN;

		// Token: 0x0400019F RID: 415
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		private static readonly int Buf_size;

		// Token: 0x040001A0 RID: 416
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		private static readonly int MIN_MATCH;

		// Token: 0x040001A1 RID: 417
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		private static readonly int MAX_MATCH;

		// Token: 0x040001A2 RID: 418
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		private static readonly int MIN_LOOKAHEAD;

		// Token: 0x040001A3 RID: 419
		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		private static readonly int HEAP_SIZE;

		// Token: 0x040001A4 RID: 420
		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		private static readonly int END_BLOCK;

		// Token: 0x040001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		// Token: 0x040001A6 RID: 422
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int status;

		// Token: 0x040001A7 RID: 423
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal byte[] pending;

		// Token: 0x040001A8 RID: 424
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int nextPending;

		// Token: 0x040001A9 RID: 425
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal int pendingCount;

		// Token: 0x040001AA RID: 426
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal sbyte data_type;

		// Token: 0x040001AB RID: 427
		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal int last_flush;

		// Token: 0x040001AC RID: 428
		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int w_size;

		// Token: 0x040001AD RID: 429
		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		internal int w_bits;

		// Token: 0x040001AE RID: 430
		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int w_mask;

		// Token: 0x040001AF RID: 431
		[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal byte[] window;

		// Token: 0x040001B0 RID: 432
		[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int window_size;

		// Token: 0x040001B1 RID: 433
		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal short[] prev;

		// Token: 0x040001B2 RID: 434
		[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal short[] head;

		// Token: 0x040001B3 RID: 435
		[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal int ins_h;

		// Token: 0x040001B4 RID: 436
		[global::Cpp2ILInjected.Token(Token = "0x4000200")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		internal int hash_size;

		// Token: 0x040001B5 RID: 437
		[global::Cpp2ILInjected.Token(Token = "0x4000201")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal int hash_bits;

		// Token: 0x040001B6 RID: 438
		[global::Cpp2ILInjected.Token(Token = "0x4000202")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		internal int hash_mask;

		// Token: 0x040001B7 RID: 439
		[global::Cpp2ILInjected.Token(Token = "0x4000203")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal int hash_shift;

		// Token: 0x040001B8 RID: 440
		[global::Cpp2ILInjected.Token(Token = "0x4000204")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		internal int block_start;

		// Token: 0x040001B9 RID: 441
		[global::Cpp2ILInjected.Token(Token = "0x4000205")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private DeflateManager.Config config;

		// Token: 0x040001BA RID: 442
		[global::Cpp2ILInjected.Token(Token = "0x4000206")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal int match_length;

		// Token: 0x040001BB RID: 443
		[global::Cpp2ILInjected.Token(Token = "0x4000207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		internal int prev_match;

		// Token: 0x040001BC RID: 444
		[global::Cpp2ILInjected.Token(Token = "0x4000208")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal int match_available;

		// Token: 0x040001BD RID: 445
		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		internal int strstart;

		// Token: 0x040001BE RID: 446
		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal int match_start;

		// Token: 0x040001BF RID: 447
		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		internal int lookahead;

		// Token: 0x040001C0 RID: 448
		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal int prev_length;

		// Token: 0x040001C1 RID: 449
		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		internal CompressionLevel compressionLevel;

		// Token: 0x040001C2 RID: 450
		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal CompressionStrategy compressionStrategy;

		// Token: 0x040001C3 RID: 451
		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal short[] dyn_ltree;

		// Token: 0x040001C4 RID: 452
		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal short[] dyn_dtree;

		// Token: 0x040001C5 RID: 453
		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		internal short[] bl_tree;

		// Token: 0x040001C6 RID: 454
		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal Tree treeLiterals;

		// Token: 0x040001C7 RID: 455
		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal Tree treeDistances;

		// Token: 0x040001C8 RID: 456
		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal Tree treeBitLengths;

		// Token: 0x040001C9 RID: 457
		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		internal short[] bl_count;

		// Token: 0x040001CA RID: 458
		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		internal int[] heap;

		// Token: 0x040001CB RID: 459
		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		internal int heap_len;

		// Token: 0x040001CC RID: 460
		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		internal int heap_max;

		// Token: 0x040001CD RID: 461
		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		internal sbyte[] depth;

		// Token: 0x040001CE RID: 462
		[global::Cpp2ILInjected.Token(Token = "0x400021A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		internal int _lengthOffset;

		// Token: 0x040001CF RID: 463
		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		internal int lit_bufsize;

		// Token: 0x040001D0 RID: 464
		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		internal int last_lit;

		// Token: 0x040001D1 RID: 465
		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
		internal int _distanceOffset;

		// Token: 0x040001D2 RID: 466
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		internal int opt_len;

		// Token: 0x040001D3 RID: 467
		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		internal int static_len;

		// Token: 0x040001D4 RID: 468
		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		internal int matches;

		// Token: 0x040001D5 RID: 469
		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		internal int last_eob_len;

		// Token: 0x040001D6 RID: 470
		[global::Cpp2ILInjected.Token(Token = "0x4000222")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		internal short bi_buf;

		// Token: 0x040001D7 RID: 471
		[global::Cpp2ILInjected.Token(Token = "0x4000223")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
		internal int bi_valid;

		// Token: 0x040001D8 RID: 472
		[global::Cpp2ILInjected.Token(Token = "0x4000224")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private bool Rfc1950BytesEmitted;

		// Token: 0x040001D9 RID: 473
		[global::Cpp2ILInjected.Token(Token = "0x4000225")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x131")]
		private bool _WantRfc1950HeaderBytes;

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000429 RID: 1065
		[global::Cpp2ILInjected.Token(Token = "0x2000041")]
		internal delegate BlockState CompressFunc(FlushType flush);

		// Token: 0x02000067 RID: 103
		[global::Cpp2ILInjected.Token(Token = "0x2000042")]
		internal class Config
		{
			// Token: 0x0600042C RID: 1068 RVA: 0x00005AE5 File Offset: 0x00003CE5
			[global::Cpp2ILInjected.Token(Token = "0x600033A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6C904", Offset = "0x1A6C904", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
			{
				throw null;
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x00005AE8 File Offset: 0x00003CE8
			[global::Cpp2ILInjected.Token(Token = "0x600033B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6C954", Offset = "0x1A6C954", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_InitializeLazyMatch", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "SetParams", MemberParameters = new object[]
			{
				typeof(CompressionLevel),
				typeof(CompressionStrategy)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static DeflateManager.Config Lookup(CompressionLevel level)
			{
				throw null;
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x00005AEB File Offset: 0x00003CEB
			[global::Cpp2ILInjected.Token(Token = "0x600033C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6C9B8", Offset = "0x1A6C9B8", Length = "0x310")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			static Config()
			{
				throw null;
			}

			// Token: 0x0400032A RID: 810
			[global::Cpp2ILInjected.Token(Token = "0x4000226")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal int GoodLength;

			// Token: 0x0400032B RID: 811
			[global::Cpp2ILInjected.Token(Token = "0x4000227")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal int MaxLazy;

			// Token: 0x0400032C RID: 812
			[global::Cpp2ILInjected.Token(Token = "0x4000228")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int NiceLength;

			// Token: 0x0400032D RID: 813
			[global::Cpp2ILInjected.Token(Token = "0x4000229")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			internal int MaxChainLength;

			// Token: 0x0400032E RID: 814
			[global::Cpp2ILInjected.Token(Token = "0x400022A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal DeflateFlavor Flavor;

			// Token: 0x0400032F RID: 815
			[global::Cpp2ILInjected.Token(Token = "0x400022B")]
			private static readonly DeflateManager.Config[] Table;
		}
	}
}
