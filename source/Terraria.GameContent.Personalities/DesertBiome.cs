using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x200059A")]
public class DesertBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C13")]
	[Cpp2IlInjected.Address(RVA = "0x1197B4C", Offset = "0x1197B4C", VA = "0x1197B4C")]
	public DesertBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C14")]
	[Cpp2IlInjected.Address(RVA = "0x1197BB0", Offset = "0x1197BB0", VA = "0x1197BB0", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
