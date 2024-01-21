using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x2000613")]
public class MushroomHouseBuilder : HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x6003E66")]
	[Cpp2IlInjected.Address(RVA = "0x144F0D8", Offset = "0x144F0D8", VA = "0x144F0D8")]
	public MushroomHouseBuilder(IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E67")]
	[Cpp2IlInjected.Address(RVA = "0x14516F0", Offset = "0x14516F0", VA = "0x14516F0", Slot = "4")]
	protected override void AgeRoom(Rectangle room)
	{
	}
}
