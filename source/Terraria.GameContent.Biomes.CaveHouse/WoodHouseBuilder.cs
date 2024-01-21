using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x2000614")]
public class WoodHouseBuilder : HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x6003E68")]
	[Cpp2IlInjected.Address(RVA = "0x144EC50", Offset = "0x144EC50", VA = "0x144EC50")]
	public WoodHouseBuilder(IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E69")]
	[Cpp2IlInjected.Address(RVA = "0x1452000", Offset = "0x1452000", VA = "0x1452000", Slot = "4")]
	protected override void AgeRoom(Rectangle room)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E6A")]
	[Cpp2IlInjected.Address(RVA = "0x14527D0", Offset = "0x14527D0", VA = "0x14527D0", Slot = "5")]
	public override void Place(HouseBuilderContext context, StructureMap structures)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E6B")]
	[Cpp2IlInjected.Address(RVA = "0x14527F0", Offset = "0x14527F0", VA = "0x14527F0")]
	private void RainbowifyOnTenthAnniversaryWorlds()
	{
	}
}
