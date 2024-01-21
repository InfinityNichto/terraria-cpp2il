using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000469")]
public class EntitySource_Gift : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400641C")]
	public readonly Entity Entity;

	[Cpp2IlInjected.Token(Token = "0x600321F")]
	[Cpp2IlInjected.Address(RVA = "0x10137CC", Offset = "0x10137CC", VA = "0x10137CC")]
	public EntitySource_Gift(Entity entity)
	{
	}
}
