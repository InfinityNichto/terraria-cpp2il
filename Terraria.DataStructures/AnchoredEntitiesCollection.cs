using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000477")]
public class AnchoredEntitiesCollection
{
	[Cpp2IlInjected.Token(Token = "0x200092C")]
	private struct IndexPointPair
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008AC3")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008AC4")]
		public Point coords;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400642F")]
	private List<IndexPointPair> _anchoredNPCs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006430")]
	private List<IndexPointPair> _anchoredPlayers;

	[Cpp2IlInjected.Token(Token = "0x17000629")]
	public int AnchoredPlayersAmount
	{
		[Cpp2IlInjected.Token(Token = "0x6003246")]
		[Cpp2IlInjected.Address(RVA = "0x1011538", Offset = "0x1011538", VA = "0x1011538")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003247")]
	[Cpp2IlInjected.Address(RVA = "0x1011584", Offset = "0x1011584", VA = "0x1011584")]
	public AnchoredEntitiesCollection()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003248")]
	[Cpp2IlInjected.Address(RVA = "0x101161C", Offset = "0x101161C", VA = "0x101161C")]
	public void ClearNPCAnchors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003249")]
	[Cpp2IlInjected.Address(RVA = "0x1011678", Offset = "0x1011678", VA = "0x1011678")]
	public void ClearPlayerAnchors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600324A")]
	[Cpp2IlInjected.Address(RVA = "0x10116D4", Offset = "0x10116D4", VA = "0x10116D4")]
	public void AddNPC(int npcIndex, Point coords)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600324B")]
	[Cpp2IlInjected.Address(RVA = "0x1011754", Offset = "0x1011754", VA = "0x1011754")]
	public int GetNextPlayerStackIndexInCoords(Point coords)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600324C")]
	[Cpp2IlInjected.Address(RVA = "0x10118F0", Offset = "0x10118F0", VA = "0x10118F0")]
	public void AddPlayerAndGetItsStackedIndexInCoords(int playerIndex, Point coords, out int stackedIndexInCoords)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600324D")]
	[Cpp2IlInjected.Address(RVA = "0x1011758", Offset = "0x1011758", VA = "0x1011758")]
	private int GetEntitiesInCoords(Point coords)
	{
		return default(int);
	}
}
