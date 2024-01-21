using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.Desert;

[Cpp2IlInjected.Token(Token = "0x2000606")]
public static class LarvaHoleEntrance
{
	[Cpp2IlInjected.Token(Token = "0x6003E10")]
	[Cpp2IlInjected.Address(RVA = "0x145C618", Offset = "0x145C618", VA = "0x145C618")]
	public static void Place(DesertDescription description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E11")]
	[Cpp2IlInjected.Address(RVA = "0x145C788", Offset = "0x145C788", VA = "0x145C788")]
	private static void PlaceAt(DesertDescription description, Point position, int holeRadius)
	{
	}
}
