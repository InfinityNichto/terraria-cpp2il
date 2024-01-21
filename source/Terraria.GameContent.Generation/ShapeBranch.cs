using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005ED")]
public class ShapeBranch : GenShape
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BD5")]
	private Point _offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006BD6")]
	private List<Point> _endPoints;

	[Cpp2IlInjected.Token(Token = "0x6003D6E")]
	[Cpp2IlInjected.Address(RVA = "0xE669D0", Offset = "0xE669D0", VA = "0xE669D0")]
	public ShapeBranch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D6F")]
	[Cpp2IlInjected.Address(RVA = "0xE66A1C", Offset = "0xE66A1C", VA = "0xE66A1C")]
	public ShapeBranch(Point offset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D70")]
	[Cpp2IlInjected.Address(RVA = "0xE66A44", Offset = "0xE66A44", VA = "0xE66A44")]
	public ShapeBranch(double angle, double distance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D71")]
	[Cpp2IlInjected.Address(RVA = "0xE66B38", Offset = "0xE66B38", VA = "0xE66B38")]
	private bool PerformSegment(Point origin, GenAction action, Point start, Point end, int size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D72")]
	[Cpp2IlInjected.Address(RVA = "0xE66D30", Offset = "0xE66D30", VA = "0xE66D30", Slot = "4")]
	public override bool Perform(Point origin, GenAction action)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D73")]
	[Cpp2IlInjected.Address(RVA = "0xE671E4", Offset = "0xE671E4", VA = "0xE671E4")]
	public ShapeBranch OutputEndpoints(List<Point> endpoints)
	{
		return null;
	}
}
