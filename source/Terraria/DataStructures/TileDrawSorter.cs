using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200067A")]
	public class TileDrawSorter
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003743")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E6E8", Offset = "0x141E6E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003744")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E6F0", Offset = "0x141E6F0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Cache(int x, int y, int type)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003747")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E7CC", Offset = "0x141E7CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetAmountToDraw()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400786D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TileDrawSorter.TileTexPoint[] tilesToDraw;

		[global::Cpp2ILInjected.Token(Token = "0x400786E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _holderLength;

		[global::Cpp2ILInjected.Token(Token = "0x400786F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _currentCacheIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4007870")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TileDrawSorter.CustomComparer _tileComparer;

		[global::Cpp2ILInjected.Token(Token = "0x200067B")]
		public struct TileTexPoint
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x4007871")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int X;

			[global::Cpp2ILInjected.Token(Token = "0x4007872")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int Y;

			[global::Cpp2ILInjected.Token(Token = "0x4007873")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int TileType;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200067C")]
		public class CustomComparer : Comparer<TileDrawSorter.TileTexPoint>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003749")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E898", Offset = "0x141E898", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			public override int Compare(TileDrawSorter.TileTexPoint x, TileDrawSorter.TileTexPoint y)
			{
				throw null;
			}

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
