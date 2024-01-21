using Cpp2IlInjected;

namespace Terraria.Physics;

[Cpp2IlInjected.Token(Token = "0x20003A8")]
public class PhysicsProperties
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003204")]
	public readonly float Gravity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003205")]
	public readonly float Drag;

	[Cpp2IlInjected.Token(Token = "0x6002E44")]
	[Cpp2IlInjected.Address(RVA = "0xB7BD58", Offset = "0xB7BD58", VA = "0xB7BD58")]
	public PhysicsProperties(float gravity, float drag)
	{
	}
}
