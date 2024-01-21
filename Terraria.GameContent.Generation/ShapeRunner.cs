using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005F0")]
public class ShapeRunner : GenShape
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BDD")]
	private double _startStrength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006BDE")]
	private int _steps;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006BDF")]
	private Vector2D _startVelocity;

	[Cpp2IlInjected.Token(Token = "0x6003D7A")]
	[Cpp2IlInjected.Address(RVA = "0xE6833C", Offset = "0xE6833C", VA = "0xE6833C")]
	public ShapeRunner(double strength, int steps, Vector2D velocity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D7B")]
	[Cpp2IlInjected.Address(RVA = "0xE68390", Offset = "0xE68390", VA = "0xE68390", Slot = "4")]
	public override bool Perform(Point origin, GenAction action)
	{
		return default(bool);
	}
}
