using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000598")]
public class ForestBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C0F")]
	[Cpp2IlInjected.Address(RVA = "0x1197C2C", Offset = "0x1197C2C", VA = "0x1197C2C")]
	public ForestBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C10")]
	[Cpp2IlInjected.Address(RVA = "0x1197C90", Offset = "0x1197C90", VA = "0x1197C90", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
