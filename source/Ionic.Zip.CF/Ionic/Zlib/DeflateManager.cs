using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	[global::Cpp2ILInjected.Token(Token = "0x2000040")]
	internal sealed class DeflateManager
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6915C", Offset = "0x1A6915C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A69B00", Offset = "0x1A69B00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_tr_align", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void bi_flush()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000330")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6BA2C", Offset = "0x1A6BA2C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal int End()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		private static readonly int MEM_LEVEL_MAX;

		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		private static readonly int MEM_LEVEL_DEFAULT;

		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DeflateManager.CompressFunc DeflateFunction;

		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		private static readonly string[] _ErrorMessage;

		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		private static readonly int PRESET_DICT;

		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		private static readonly int INIT_STATE;

		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		private static readonly int BUSY_STATE;

		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		private static readonly int FINISH_STATE;

		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		private static readonly int Z_DEFLATED;

		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		private static readonly int STORED_BLOCK;

		[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
		private static readonly int STATIC_TREES;

		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		private static readonly int DYN_TREES;

		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		private static readonly int Z_BINARY;

		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		private static readonly int Z_ASCII;

		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		private static readonly int Z_UNKNOWN;

		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		private static readonly int Buf_size;

		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		private static readonly int MIN_MATCH;

		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		private static readonly int MAX_MATCH;

		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		private static readonly int MIN_LOOKAHEAD;

		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		private static readonly int HEAP_SIZE;

		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		private static readonly int END_BLOCK;

		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal ZlibCodec _codec;

		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int status;

		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal byte[] pending;

		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int nextPending;

		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal int pendingCount;

		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal sbyte data_type;

		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		internal int last_flush;

		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int w_size;

		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		internal int w_bits;

		[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int w_mask;

		[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal byte[] window;

		[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int window_size;

		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal short[] prev;

		[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal short[] head;

		[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal int ins_h;

		[global::Cpp2ILInjected.Token(Token = "0x4000200")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		internal int hash_size;

		[global::Cpp2ILInjected.Token(Token = "0x4000201")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal int hash_bits;

		[global::Cpp2ILInjected.Token(Token = "0x4000202")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		internal int hash_mask;

		[global::Cpp2ILInjected.Token(Token = "0x4000203")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal int hash_shift;

		[global::Cpp2ILInjected.Token(Token = "0x4000204")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		internal int block_start;

		[global::Cpp2ILInjected.Token(Token = "0x4000205")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private DeflateManager.Config config;

		[global::Cpp2ILInjected.Token(Token = "0x4000206")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal int match_length;

		[global::Cpp2ILInjected.Token(Token = "0x4000207")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		internal int prev_match;

		[global::Cpp2ILInjected.Token(Token = "0x4000208")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal int match_available;

		[global::Cpp2ILInjected.Token(Token = "0x4000209")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		internal int strstart;

		[global::Cpp2ILInjected.Token(Token = "0x400020A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal int match_start;

		[global::Cpp2ILInjected.Token(Token = "0x400020B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		internal int lookahead;

		[global::Cpp2ILInjected.Token(Token = "0x400020C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal int prev_length;

		[global::Cpp2ILInjected.Token(Token = "0x400020D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		internal CompressionLevel compressionLevel;

		[global::Cpp2ILInjected.Token(Token = "0x400020E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal CompressionStrategy compressionStrategy;

		[global::Cpp2ILInjected.Token(Token = "0x400020F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal short[] dyn_ltree;

		[global::Cpp2ILInjected.Token(Token = "0x4000210")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal short[] dyn_dtree;

		[global::Cpp2ILInjected.Token(Token = "0x4000211")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		internal short[] bl_tree;

		[global::Cpp2ILInjected.Token(Token = "0x4000212")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal Tree treeLiterals;

		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal Tree treeDistances;

		[global::Cpp2ILInjected.Token(Token = "0x4000214")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal Tree treeBitLengths;

		[global::Cpp2ILInjected.Token(Token = "0x4000215")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		internal short[] bl_count;

		[global::Cpp2ILInjected.Token(Token = "0x4000216")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		internal int[] heap;

		[global::Cpp2ILInjected.Token(Token = "0x4000217")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		internal int heap_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000218")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		internal int heap_max;

		[global::Cpp2ILInjected.Token(Token = "0x4000219")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		internal sbyte[] depth;

		[global::Cpp2ILInjected.Token(Token = "0x400021A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		internal int _lengthOffset;

		[global::Cpp2ILInjected.Token(Token = "0x400021B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		internal int lit_bufsize;

		[global::Cpp2ILInjected.Token(Token = "0x400021C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		internal int last_lit;

		[global::Cpp2ILInjected.Token(Token = "0x400021D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
		internal int _distanceOffset;

		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		internal int opt_len;

		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		internal int static_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000220")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		internal int matches;

		[global::Cpp2ILInjected.Token(Token = "0x4000221")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x124")]
		internal int last_eob_len;

		[global::Cpp2ILInjected.Token(Token = "0x4000222")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		internal short bi_buf;

		[global::Cpp2ILInjected.Token(Token = "0x4000223")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
		internal int bi_valid;

		[global::Cpp2ILInjected.Token(Token = "0x4000224")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private bool Rfc1950BytesEmitted;

		[global::Cpp2ILInjected.Token(Token = "0x4000225")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x131")]
		private bool _WantRfc1950HeaderBytes;

		[global::Cpp2ILInjected.Token(Token = "0x2000041")]
		internal delegate BlockState CompressFunc(FlushType flush);

		[global::Cpp2ILInjected.Token(Token = "0x2000042")]
		internal class Config
		{
			[global::Cpp2ILInjected.Token(Token = "0x600033A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6C904", Offset = "0x1A6C904", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, DeflateFlavor flavor)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x600033C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6C9B8", Offset = "0x1A6C9B8", Length = "0x310")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			static Config()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000226")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal int GoodLength;

			[global::Cpp2ILInjected.Token(Token = "0x4000227")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			internal int MaxLazy;

			[global::Cpp2ILInjected.Token(Token = "0x4000228")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int NiceLength;

			[global::Cpp2ILInjected.Token(Token = "0x4000229")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			internal int MaxChainLength;

			[global::Cpp2ILInjected.Token(Token = "0x400022A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal DeflateFlavor Flavor;

			[global::Cpp2ILInjected.Token(Token = "0x400022B")]
			private static readonly DeflateManager.Config[] Table;
		}
	}
}
