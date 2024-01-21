using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000597")]
public class OceanBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C0D")]
	[Cpp2IlInjected.Address(RVA = "0x1197E64", Offset = "0x1197E64", VA = "0x1197E64")]
	public OceanBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C0E")]
	[Cpp2IlInjected.Address(RVA = "0x1197EC8", Offset = "0x1197EC8", VA = "0x1197EC8", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
