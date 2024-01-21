using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x200060A")]
public class DesertHouseBuilder : HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x6003E1C")]
	[Cpp2IlInjected.Address(RVA = "0x11078D8", Offset = "0x11078D8", VA = "0x11078D8")]
	public DesertHouseBuilder(IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E1D")]
	[Cpp2IlInjected.Address(RVA = "0x1107B68", Offset = "0x1107B68", VA = "0x1107B68", Slot = "4")]
	protected override void AgeRoom(Rectangle room)
	{
	}
}
