using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000458")]
public class EntitySource_Mount : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006411")]
	public readonly Entity Entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006412")]
	public readonly int MountId;

	[Cpp2IlInjected.Token(Token = "0x600320E")]
	[Cpp2IlInjected.Address(RVA = "0x101388C", Offset = "0x101388C", VA = "0x101388C")]
	public EntitySource_Mount(Entity entity, int mountId)
	{
	}
}
