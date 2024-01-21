using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x2000611")]
public class JungleHouseBuilder : HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x6003E62")]
	[Cpp2IlInjected.Address(RVA = "0x144EF20", Offset = "0x144EF20", VA = "0x144EF20")]
	public JungleHouseBuilder(IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E63")]
	[Cpp2IlInjected.Address(RVA = "0x14504C8", Offset = "0x14504C8", VA = "0x14504C8", Slot = "4")]
	protected override void AgeRoom(Rectangle room)
	{
	}
}
