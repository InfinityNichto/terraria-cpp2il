using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x20005A1")]
public class CrimsonBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C21")]
	[Cpp2IlInjected.Address(RVA = "0x1197ADC", Offset = "0x1197ADC", VA = "0x1197ADC")]
	public CrimsonBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C22")]
	[Cpp2IlInjected.Address(RVA = "0x1197B40", Offset = "0x1197B40", VA = "0x1197B40", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
