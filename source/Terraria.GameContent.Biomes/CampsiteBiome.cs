using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F2")]
public class CampsiteBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003D8E")]
	[Cpp2IlInjected.Address(RVA = "0x11066E0", Offset = "0x11066E0", VA = "0x11066E0", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D8F")]
	[Cpp2IlInjected.Address(RVA = "0x11078D0", Offset = "0x11078D0", VA = "0x11078D0")]
	public CampsiteBiome()
	{
	}
}
