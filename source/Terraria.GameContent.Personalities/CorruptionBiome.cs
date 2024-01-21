using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x20005A0")]
public class CorruptionBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C1F")]
	[Cpp2IlInjected.Address(RVA = "0x1197A6C", Offset = "0x1197A6C", VA = "0x1197A6C")]
	public CorruptionBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C20")]
	[Cpp2IlInjected.Address(RVA = "0x1197AD0", Offset = "0x1197AD0", VA = "0x1197AD0", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
