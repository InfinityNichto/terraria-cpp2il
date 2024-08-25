using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	internal sealed class InflateBlocks
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600037D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71CF8", Offset = "0x1A71CF8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		internal void Free()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71D50", Offset = "0x1A71D50", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int SyncPoint()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000239")]
		private const int MANY = 1440;

		[global::Cpp2ILInjected.Token(Token = "0x400023A")]
		internal static readonly int[] border;

		[global::Cpp2ILInjected.Token(Token = "0x400023B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InflateBlocks.InflateBlockMode mode;

		[global::Cpp2ILInjected.Token(Token = "0x400023C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int left;

		[global::Cpp2ILInjected.Token(Token = "0x400023D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int table;

		[global::Cpp2ILInjected.Token(Token = "0x400023E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int index;

		[global::Cpp2ILInjected.Token(Token = "0x400023F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int[] blens;

		[global::Cpp2ILInjected.Token(Token = "0x4000240")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int[] bb;

		[global::Cpp2ILInjected.Token(Token = "0x4000241")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int[] tb;

		[global::Cpp2ILInjected.Token(Token = "0x4000242")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal InflateCodes codes;

		[global::Cpp2ILInjected.Token(Token = "0x4000243")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int last;

		[global::Cpp2ILInjected.Token(Token = "0x4000244")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ZlibCodec _codec;

		[global::Cpp2ILInjected.Token(Token = "0x4000245")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int bitk;

		[global::Cpp2ILInjected.Token(Token = "0x4000246")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		internal int bitb;

		[global::Cpp2ILInjected.Token(Token = "0x4000247")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int[] hufts;

		[global::Cpp2ILInjected.Token(Token = "0x4000248")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal byte[] window;

		[global::Cpp2ILInjected.Token(Token = "0x4000249")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal int end;

		[global::Cpp2ILInjected.Token(Token = "0x400024A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		internal int readAt;

		[global::Cpp2ILInjected.Token(Token = "0x400024B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal int writeAt;

		[global::Cpp2ILInjected.Token(Token = "0x400024C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal object checkfn;

		[global::Cpp2ILInjected.Token(Token = "0x400024D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal uint check;

		[global::Cpp2ILInjected.Token(Token = "0x400024E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal InfTree inftree;

		[global::Cpp2ILInjected.Token(Token = "0x2000046")]
		private enum InflateBlockMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000250")]
			TYPE,
			[global::Cpp2ILInjected.Token(Token = "0x4000251")]
			LENS,
			[global::Cpp2ILInjected.Token(Token = "0x4000252")]
			STORED,
			[global::Cpp2ILInjected.Token(Token = "0x4000253")]
			TABLE,
			[global::Cpp2ILInjected.Token(Token = "0x4000254")]
			BTREE,
			[global::Cpp2ILInjected.Token(Token = "0x4000255")]
			DTREE,
			[global::Cpp2ILInjected.Token(Token = "0x4000256")]
			CODES,
			[global::Cpp2ILInjected.Token(Token = "0x4000257")]
			DRY,
			[global::Cpp2ILInjected.Token(Token = "0x4000258")]
			DONE,
			[global::Cpp2ILInjected.Token(Token = "0x4000259")]
			BAD
		}
	}
}
