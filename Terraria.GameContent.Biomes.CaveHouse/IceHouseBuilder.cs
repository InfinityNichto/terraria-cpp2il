using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x2000610")]
public class IceHouseBuilder : HouseBuilder
{
	[Cpp2IlInjected.Token(Token = "0x6003E60")]
	[Cpp2IlInjected.Address(RVA = "0x144EE40", Offset = "0x144EE40", VA = "0x144EE40")]
	public IceHouseBuilder(IEnumerable<Rectangle> rooms)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E61")]
	[Cpp2IlInjected.Address(RVA = "0x144FAE8", Offset = "0x144FAE8", VA = "0x144FAE8", Slot = "4")]
	protected override void AgeRoom(Rectangle room)
	{
	}
}
