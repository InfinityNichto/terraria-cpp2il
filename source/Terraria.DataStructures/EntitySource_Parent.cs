using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000453")]
public class EntitySource_Parent : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006408")]
	public readonly Entity Entity;

	[Cpp2IlInjected.Token(Token = "0x6003209")]
	[Cpp2IlInjected.Address(RVA = "0x1013974", Offset = "0x1013974", VA = "0x1013974")]
	public EntitySource_Parent(Entity entity)
	{
	}
}
