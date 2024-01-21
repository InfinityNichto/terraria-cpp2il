using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Physics;

[Cpp2IlInjected.Token(Token = "0x20003A2")]
public struct BallCollisionEvent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40031F0")]
	public readonly Vector2 Normal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031F1")]
	public readonly Vector2 ImpactPoint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40031F2")]
	public readonly Tile Tile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40031F3")]
	public readonly Entity Entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40031F4")]
	public readonly float TimeScale;

	[Cpp2IlInjected.Token(Token = "0x6002E3C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF588", Offset = "0x2AF588", VA = "0x2AF588")]
	public BallCollisionEvent(float timeScale, Vector2 normal, Vector2 impactPoint, Tile tile, Entity entity)
	{
	}
}
