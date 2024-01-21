using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005EE")]
public class ShapeFloodFill : GenShape
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BD7")]
	private int _maximumActions;

	[Cpp2IlInjected.Token(Token = "0x4006BD8")]
	private static Queue<Point> checkQueue;

	[Cpp2IlInjected.Token(Token = "0x6003D74")]
	[Cpp2IlInjected.Address(RVA = "0xE67348", Offset = "0xE67348", VA = "0xE67348")]
	public ShapeFloodFill(int maximumActions = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D75")]
	[Cpp2IlInjected.Address(RVA = "0xE67368", Offset = "0xE67368", VA = "0xE67368", Slot = "4")]
	public override bool Perform(Point origin, GenAction action)
	{
		return default(bool);
	}
}
