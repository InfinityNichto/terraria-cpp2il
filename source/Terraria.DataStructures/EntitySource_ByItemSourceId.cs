using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000460")]
public class EntitySource_ByItemSourceId : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006417")]
	public readonly Entity Entity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006418")]
	public readonly int SourceId;

	[Cpp2IlInjected.Token(Token = "0x6003216")]
	[Cpp2IlInjected.Address(RVA = "0x1013734", Offset = "0x1013734", VA = "0x1013734")]
	public EntitySource_ByItemSourceId(Entity entity, int itemSourceId)
	{
	}
}
