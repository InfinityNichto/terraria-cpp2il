using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x2000601")]
public class ThinIceBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003DF1")]
	[Cpp2IlInjected.Address(RVA = "0x107CFC0", Offset = "0x107CFC0", VA = "0x107CFC0", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DF2")]
	[Cpp2IlInjected.Address(RVA = "0x107D6D0", Offset = "0x107D6D0", VA = "0x107D6D0")]
	public ThinIceBiome()
	{
	}
}
