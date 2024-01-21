using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200046B")]
public abstract class AEntitySource_OnHit : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400641E")]
	public readonly Entity EntityStriking;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400641F")]
	public readonly Entity EntityStruck;

	[Cpp2IlInjected.Token(Token = "0x6003221")]
	[Cpp2IlInjected.Address(RVA = "0x101134C", Offset = "0x101134C", VA = "0x101134C")]
	public AEntitySource_OnHit(Entity entityStriking, Entity entityStruck)
	{
	}
}
