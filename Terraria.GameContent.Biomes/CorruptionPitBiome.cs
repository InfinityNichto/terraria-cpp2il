using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F4")]
public class CorruptionPitBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x4006BEF")]
	public static bool[] ValidTiles;

	[Cpp2IlInjected.Token(Token = "0x6003DA1")]
	[Cpp2IlInjected.Address(RVA = "0x1452F88", Offset = "0x1452F88", VA = "0x1452F88", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DA2")]
	[Cpp2IlInjected.Address(RVA = "0x1453D58", Offset = "0x1453D58", VA = "0x1453D58")]
	public CorruptionPitBiome()
	{
	}
}
