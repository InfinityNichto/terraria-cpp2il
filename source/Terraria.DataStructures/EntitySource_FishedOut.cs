using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000468")]
public class EntitySource_FishedOut : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400641B")]
	public readonly Entity Entity;

	[Cpp2IlInjected.Token(Token = "0x600321E")]
	[Cpp2IlInjected.Address(RVA = "0x10137AC", Offset = "0x10137AC", VA = "0x10137AC")]
	public EntitySource_FishedOut(Entity entity)
	{
	}
}
