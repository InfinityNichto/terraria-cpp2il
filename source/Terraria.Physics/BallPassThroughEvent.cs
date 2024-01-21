using Cpp2IlInjected;

namespace Terraria.Physics;

[Cpp2IlInjected.Token(Token = "0x20003A3")]
public struct BallPassThroughEvent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40031F5")]
	public readonly Tile Tile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40031F6")]
	public readonly Entity Entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031F7")]
	public readonly BallPassThroughType Type;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031F8")]
	public readonly float TimeScale;

	[Cpp2IlInjected.Token(Token = "0x6002E3D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF608", Offset = "0x2AF608", VA = "0x2AF608")]
	public BallPassThroughEvent(float timeScale, Tile tile, Entity entity, BallPassThroughType type)
	{
	}
}
