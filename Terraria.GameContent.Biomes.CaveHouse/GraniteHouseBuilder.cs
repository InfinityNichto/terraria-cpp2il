using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x200060B")]
public class GraniteHouseBuilder : HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x6003E1E")]
	[Cpp2IlInjected.Address(RVA = "0x1108508", Offset = "0x1108508", VA = "0x1108508")]
	public GraniteHouseBuilder(IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E1F")]
	[Cpp2IlInjected.Address(RVA = "0x11085E0", Offset = "0x11085E0", VA = "0x11085E0", Slot = "4")]
	protected override void AgeRoom(Rectangle room)
	{
	}
}
