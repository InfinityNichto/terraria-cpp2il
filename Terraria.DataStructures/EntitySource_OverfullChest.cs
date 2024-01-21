using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200045B")]
public class EntitySource_OverfullChest : AEntitySource_Tile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006415")]
	public readonly Chest Chest;

	[Cpp2IlInjected.Token(Token = "0x6003211")]
	[Cpp2IlInjected.Address(RVA = "0x101391C", Offset = "0x101391C", VA = "0x101391C")]
	public EntitySource_OverfullChest(int tileCoordsX, int tileCoordsY, Chest chest)
	{
	}
}
