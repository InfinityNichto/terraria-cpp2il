using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000479 RID: 1145
	[global::Cpp2ILInjected.Token(Token = "0x200067A")]
	public class TileDrawSorter
	{
		// Token: 0x0600321C RID: 12828 RVA: 0x0002AF6B File Offset: 0x0002916B
		[global::Cpp2ILInjected.Token(Token = "0x6003742")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E608", Offset = "0x141E608", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawSorter.CustomComparer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public TileDrawSorter()
		{
			throw null;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x0002AF6E File Offset: 0x0002916E
		[global::Cpp2ILInjected.Token(Token = "0x6003743")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E6E8", Offset = "0x141E6E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void reset()
		{
			throw null;
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x0002AF71 File Offset: 0x00029171
		[global::Cpp2ILInjected.Token(Token = "0x6003744")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E6F0", Offset = "0x141E6F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Cache(int x, int y, int type)
		{
			throw null;
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x0002AF74 File Offset: 0x00029174
		[global::Cpp2ILInjected.Token(Token = "0x6003745")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E724", Offset = "0x141E724", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(TileDrawSorter.TileTexPoint) }, MemberParameters = new object[]
		{
			typeof(ref TileDrawSorter.TileTexPoint[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void IncreaseArraySize()
		{
			throw null;
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x0002AF77 File Offset: 0x00029177
		[global::Cpp2ILInjected.Token(Token = "0x6003746")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E778", Offset = "0x141E778", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Sort", MemberTypeParameters = new object[] { typeof(TileDrawSorter.TileTexPoint) }, MemberParameters = new object[]
		{
			typeof(TileDrawSorter.TileTexPoint[]),
			typeof(int),
			typeof(int),
			typeof(IComparer<TileDrawSorter.TileTexPoint>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Sort()
		{
			throw null;
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0002AF7A File Offset: 0x0002917A
		[global::Cpp2ILInjected.Token(Token = "0x6003747")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E7CC", Offset = "0x141E7CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetAmountToDraw()
		{
			throw null;
		}

		// Token: 0x04006474 RID: 25716
		[global::Cpp2ILInjected.Token(Token = "0x400786D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TileDrawSorter.TileTexPoint[] tilesToDraw;

		// Token: 0x04006475 RID: 25717
		[global::Cpp2ILInjected.Token(Token = "0x400786E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _holderLength;

		// Token: 0x04006476 RID: 25718
		[global::Cpp2ILInjected.Token(Token = "0x400786F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _currentCacheIndex;

		// Token: 0x04006477 RID: 25719
		[global::Cpp2ILInjected.Token(Token = "0x4007870")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TileDrawSorter.CustomComparer _tileComparer;

		// Token: 0x02000936 RID: 2358
		[global::Cpp2ILInjected.Token(Token = "0x200067B")]
		public struct TileTexPoint
		{
			// Token: 0x06004C9B RID: 19611 RVA: 0x0002F8EB File Offset: 0x0002DAEB
			[global::Cpp2ILInjected.Token(Token = "0x6003748")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E7D4", Offset = "0x141E7D4", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x04008AD8 RID: 35544
			[global::Cpp2ILInjected.Token(Token = "0x4007871")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int X;

			// Token: 0x04008AD9 RID: 35545
			[global::Cpp2ILInjected.Token(Token = "0x4007872")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int Y;

			// Token: 0x04008ADA RID: 35546
			[global::Cpp2ILInjected.Token(Token = "0x4007873")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int TileType;
		}

		// Token: 0x02000937 RID: 2359
		[global::Cpp2ILInjected.Token(Token = "0x200067C")]
		public class CustomComparer : Comparer<TileDrawSorter.TileTexPoint>
		{
			// Token: 0x06004C9C RID: 19612 RVA: 0x0002F8EE File Offset: 0x0002DAEE
			[global::Cpp2ILInjected.Token(Token = "0x6003749")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E898", Offset = "0x141E898", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(TileDrawSorter.TileTexPoint x, TileDrawSorter.TileTexPoint y)
			{
				throw null;
			}

			// Token: 0x06004C9D RID: 19613 RVA: 0x0002F8F1 File Offset: 0x0002DAF1
			[global::Cpp2ILInjected.Token(Token = "0x600374A")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E6A0", Offset = "0x141E6A0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawSorter), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer<TileDrawSorter.TileTexPoint>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public CustomComparer()
			{
				throw null;
			}
		}
	}
}
