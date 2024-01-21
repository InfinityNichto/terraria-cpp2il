using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000459")]
public abstract class AEntitySource_Tile : IEntitySource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006413")]
	public readonly Point TileCoords;

	[Cpp2IlInjected.Token(Token = "0x600320F")]
	[Cpp2IlInjected.Address(RVA = "0x1011374", Offset = "0x1011374", VA = "0x1011374")]
	public AEntitySource_Tile(int tileCoordsX, int tileCoordsY)
	{
	}
}
