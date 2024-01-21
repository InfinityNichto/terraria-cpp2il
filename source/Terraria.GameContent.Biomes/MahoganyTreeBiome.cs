using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005FD")]
public class MahoganyTreeBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003DE2")]
	[Cpp2IlInjected.Address(RVA = "0x1076EC0", Offset = "0x1076EC0", VA = "0x1076EC0", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DE3")]
	[Cpp2IlInjected.Address(RVA = "0x1078CE4", Offset = "0x1078CE4", VA = "0x1078CE4")]
	public MahoganyTreeBiome()
	{
	}
}
