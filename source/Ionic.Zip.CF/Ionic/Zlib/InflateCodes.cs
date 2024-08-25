using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	[global::Cpp2ILInjected.Token(Token = "0x2000048")]
	internal sealed class InflateCodes
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000383")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6FD24", Offset = "0x1A6FD24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal InflateCodes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000384")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A71134", Offset = "0x1A71134", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		private const int START = 0;

		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		private const int LEN = 1;

		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		private const int LENEXT = 2;

		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		private const int DIST = 3;

		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		private const int DISTEXT = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		private const int COPY = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		private const int LIT = 6;

		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		private const int WASH = 7;

		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		private const int END = 8;

		[global::Cpp2ILInjected.Token(Token = "0x4000264")]
		private const int BADCODE = 9;

		[global::Cpp2ILInjected.Token(Token = "0x4000265")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int mode;

		[global::Cpp2ILInjected.Token(Token = "0x4000266")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int len;

		[global::Cpp2ILInjected.Token(Token = "0x4000267")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] tree;

		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int tree_index;

		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int need;

		[global::Cpp2ILInjected.Token(Token = "0x400026A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int lit;

		[global::Cpp2ILInjected.Token(Token = "0x400026B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int bitsToGet;

		[global::Cpp2ILInjected.Token(Token = "0x400026C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal int dist;

		[global::Cpp2ILInjected.Token(Token = "0x400026D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal byte lbits;

		[global::Cpp2ILInjected.Token(Token = "0x400026E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		internal byte dbits;

		[global::Cpp2ILInjected.Token(Token = "0x400026F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal int[] ltree;

		[global::Cpp2ILInjected.Token(Token = "0x4000270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int ltree_index;

		[global::Cpp2ILInjected.Token(Token = "0x4000271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int[] dtree;

		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int dtree_index;
	}
}
