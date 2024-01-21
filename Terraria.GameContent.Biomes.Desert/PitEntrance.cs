using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Biomes.Desert;

[Cpp2IlInjected.Token(Token = "0x2000607")]
public static class PitEntrance
{
	[Cpp2IlInjected.Token(Token = "0x6003E12")]
	[Cpp2IlInjected.Address(RVA = "0x145D0DC", Offset = "0x145D0DC", VA = "0x145D0DC")]
	public static void Place(DesertDescription description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E13")]
	[Cpp2IlInjected.Address(RVA = "0x145D1C0", Offset = "0x145D1C0", VA = "0x145D1C0")]
	private static void PlaceAt(DesertDescription description, Point position, int holeRadius)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E14")]
	[Cpp2IlInjected.Address(RVA = "0x145D760", Offset = "0x145D760", VA = "0x145D760")]
	private static double GetHoleRadiusScaleAt(double yProgress)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6003E15")]
	[Cpp2IlInjected.Address(RVA = "0x145D7D8", Offset = "0x145D7D8", VA = "0x145D7D8")]
	private static double SmootherStep(double delta)
	{
		return default(double);
	}
}
