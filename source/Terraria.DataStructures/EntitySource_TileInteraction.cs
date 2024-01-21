using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200045A")]
public class EntitySource_TileInteraction : AEntitySource_Tile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006414")]
	public readonly Entity Entity;

	[Cpp2IlInjected.Token(Token = "0x6003210")]
	[Cpp2IlInjected.Address(RVA = "0x1013A74", Offset = "0x1013A74", VA = "0x1013A74")]
	public EntitySource_TileInteraction(Entity entity, int tileCoordsX, int tileCoordsY)
	{
	}
}
