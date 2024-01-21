using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200047C")]
public class TileDrawSorter
{
	[Cpp2IlInjected.Token(Token = "0x200092D")]
	public struct TileTexPoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008AC5")]
		public int X;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008AC6")]
		public int Y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008AC7")]
		public int TileType;

		[Cpp2IlInjected.Token(Token = "0x6004CD2")]
		[Cpp2IlInjected.Address(RVA = "0x39DBA8", Offset = "0x39DBA8", VA = "0x39DBA8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200092E")]
	public class CustomComparer : Comparer<TileTexPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6004CD3")]
		[Cpp2IlInjected.Address(RVA = "0x122F6B0", Offset = "0x122F6B0", VA = "0x122F6B0", Slot = "6")]
		public override int Compare(TileTexPoint x, TileTexPoint y)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004CD4")]
		[Cpp2IlInjected.Address(RVA = "0x122F510", Offset = "0x122F510", VA = "0x122F510")]
		public CustomComparer()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006475")]
	public TileTexPoint[] tilesToDraw;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006476")]
	private int _holderLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006477")]
	private int _currentCacheIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006478")]
	private CustomComparer _tileComparer;

	[Cpp2IlInjected.Token(Token = "0x6003258")]
	[Cpp2IlInjected.Address(RVA = "0x122F474", Offset = "0x122F474", VA = "0x122F474")]
	public TileDrawSorter()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003259")]
	[Cpp2IlInjected.Address(RVA = "0x122F56C", Offset = "0x122F56C", VA = "0x122F56C")]
	public void reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600325A")]
	[Cpp2IlInjected.Address(RVA = "0x122F578", Offset = "0x122F578", VA = "0x122F578")]
	public void Cache(int x, int y, int type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600325B")]
	[Cpp2IlInjected.Address(RVA = "0x122F5CC", Offset = "0x122F5CC", VA = "0x122F5CC")]
	private void IncreaseArraySize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600325C")]
	[Cpp2IlInjected.Address(RVA = "0x122F634", Offset = "0x122F634", VA = "0x122F634")]
	public void Sort()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600325D")]
	[Cpp2IlInjected.Address(RVA = "0x122F6A8", Offset = "0x122F6A8", VA = "0x122F6A8")]
	public int GetAmountToDraw()
	{
		return default(int);
	}
}
