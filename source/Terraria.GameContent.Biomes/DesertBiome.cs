using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using Terraria.GameContent.Biomes.Desert;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes;

[Cpp2IlInjected.Token(Token = "0x20005F6")]
public class DesertBiome : MicroBiome
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006BF7")]
	[JsonProperty]
	public double ChanceOfEntrance;

	[Cpp2IlInjected.Token(Token = "0x6003DB7")]
	[Cpp2IlInjected.Address(RVA = "0x145E2CC", Offset = "0x145E2CC", VA = "0x145E2CC", Slot = "4")]
	public override bool Place(Point origin, StructureMap structures)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB8")]
	[Cpp2IlInjected.Address(RVA = "0x145E4F0", Offset = "0x145E4F0", VA = "0x145E4F0")]
	private static void ExportDescriptionToEngine(DesertDescription description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DB9")]
	[Cpp2IlInjected.Address(RVA = "0x145E5B0", Offset = "0x145E5B0", VA = "0x145E5B0")]
	private static void CleanupArea(Rectangle area)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003DBA")]
	[Cpp2IlInjected.Address(RVA = "0x145E754", Offset = "0x145E754", VA = "0x145E754")]
	public DesertBiome()
	{
	}
}
