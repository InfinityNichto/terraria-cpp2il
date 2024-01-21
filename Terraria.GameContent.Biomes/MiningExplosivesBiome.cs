using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005FF")]
public class MiningExplosivesBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003DE9")]
	[Cpp2IlInjected.Address(RVA = "0x107A308", Offset = "0x107A308", VA = "0x107A308", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DEA")]
	[Cpp2IlInjected.Address(RVA = "0x107B19C", Offset = "0x107B19C", VA = "0x107B19C")]
	public MiningExplosivesBiome()
	{
	}
}
