using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005EF")]
public class ShapeRoot : GenShape
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BD9")]
	private double _angle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006BDA")]
	private double _startingSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006BDB")]
	private double _endingSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4006BDC")]
	private double _distance;

	[Cpp2IlInjected.Token(Token = "0x6003D77")]
	[Cpp2IlInjected.Address(RVA = "0xE67E80", Offset = "0xE67E80", VA = "0xE67E80")]
	public ShapeRoot(double angle, double distance = 10.0, double startingSize = 4.0, double endingSize = 1.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D78")]
	[Cpp2IlInjected.Address(RVA = "0xE67EC0", Offset = "0xE67EC0", VA = "0xE67EC0")]
	private bool DoRoot(Point origin, GenAction action, double angle, double distance, double startingSize)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D79")]
	[Cpp2IlInjected.Address(RVA = "0xE6830C", Offset = "0xE6830C", VA = "0xE6830C", Slot = "4")]
	public override bool Perform(Point origin, GenAction action)
	{
		return default(bool);
	}
}
