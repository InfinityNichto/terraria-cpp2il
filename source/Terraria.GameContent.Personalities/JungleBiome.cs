using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x200059B")]
public class JungleBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C15")]
	[Cpp2IlInjected.Address(RVA = "0x1197D0C", Offset = "0x1197D0C", VA = "0x1197D0C")]
	public JungleBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C16")]
	[Cpp2IlInjected.Address(RVA = "0x1197D70", Offset = "0x1197D70", VA = "0x1197D70", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
