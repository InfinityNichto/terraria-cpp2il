using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005FB")]
public class HoneyPatchBiome : MicroBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003DD7")]
	[Cpp2IlInjected.Address(RVA = "0x1465700", Offset = "0x1465700", VA = "0x1465700", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DD8")]
	[Cpp2IlInjected.Address(RVA = "0x14660C4", Offset = "0x14660C4", VA = "0x14660C4")]
	public HoneyPatchBiome()
	{
	}
}
