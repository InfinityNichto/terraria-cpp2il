using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x2000612")]
public class MarbleHouseBuilder : HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x6003E64")]
	[Cpp2IlInjected.Address(RVA = "0x144EFF8", Offset = "0x144EFF8", VA = "0x144EFF8")]
	public MarbleHouseBuilder(IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E65")]
	[Cpp2IlInjected.Address(RVA = "0x1450E88", Offset = "0x1450E88", VA = "0x1450E88", Slot = "4")]
	protected override void AgeRoom(Rectangle room)
	{
	}
}
