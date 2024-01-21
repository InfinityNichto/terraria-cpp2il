using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000454")]
public class EntitySource_Buff : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006409")]
	public readonly Entity Entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400640A")]
	public readonly int BuffId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400640B")]
	public readonly int BuffIndex;

	[Cpp2IlInjected.Token(Token = "0x600320A")]
	[Cpp2IlInjected.Address(RVA = "0x1013704", Offset = "0x1013704", VA = "0x1013704")]
	public EntitySource_Buff(Entity entity, int buffId, int buffIndex)
	{
	}
}
