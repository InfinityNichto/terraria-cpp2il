using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F8")]
public class EnchantedSwordBiome : MicroBiome
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BFA")]
	[JsonProperty]
	private double _chanceOfEntrance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006BFB")]
	[JsonProperty]
	private double _chanceOfRealSword;

	[Cpp2IlInjected.Token(Token = "0x6003DC1")]
	[Cpp2IlInjected.Address(RVA = "0x145F708", Offset = "0x145F708", VA = "0x145F708", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DC2")]
	[Cpp2IlInjected.Address(RVA = "0x1460BD8", Offset = "0x1460BD8", VA = "0x1460BD8")]
	public EnchantedSwordBiome()
	{
	}
}
