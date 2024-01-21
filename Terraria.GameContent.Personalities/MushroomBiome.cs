using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x200059E")]
public class MushroomBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C1B")]
	[Cpp2IlInjected.Address(RVA = "0x1197D7C", Offset = "0x1197D7C", VA = "0x1197D7C")]
	public MushroomBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C1C")]
	[Cpp2IlInjected.Address(RVA = "0x1197DE0", Offset = "0x1197DE0", VA = "0x1197DE0", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
