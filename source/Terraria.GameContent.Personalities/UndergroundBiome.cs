using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x200059C")]
public class UndergroundBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C17")]
	[Cpp2IlInjected.Address(RVA = "0x1198A08", Offset = "0x1198A08", VA = "0x1198A08")]
	public UndergroundBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C18")]
	[Cpp2IlInjected.Address(RVA = "0x1198A80", Offset = "0x1198A80", VA = "0x1198A80", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
