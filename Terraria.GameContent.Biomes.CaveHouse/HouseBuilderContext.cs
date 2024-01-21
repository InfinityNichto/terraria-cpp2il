using Cpp2IlInjected;

namespace Terraria.GameContent.Biomes.CaveHouse;

[Cpp2IlInjected.Token(Token = "0x200060D")]
public class HouseBuilderContext
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C2A")]
	public int SharpenerCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C2B")]
	public int ExtractinatorCount;

	[Cpp2IlInjected.Token(Token = "0x6003E56")]
	[Cpp2IlInjected.Address(RVA = "0x144D658", Offset = "0x144D658", VA = "0x144D658")]
	public HouseBuilderContext()
	{
	}
}
