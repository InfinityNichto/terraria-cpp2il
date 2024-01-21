using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x200059D")]
public class HallowBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C19")]
	[Cpp2IlInjected.Address(RVA = "0x1197C9C", Offset = "0x1197C9C", VA = "0x1197C9C")]
	public HallowBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C1A")]
	[Cpp2IlInjected.Address(RVA = "0x1197D00", Offset = "0x1197D00", VA = "0x1197D00", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
