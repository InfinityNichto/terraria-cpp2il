using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000599")]
public class SnowBiome : AShoppingBiome
{
	[Cpp2IlInjected.Token(Token = "0x6003C11")]
	[Cpp2IlInjected.Address(RVA = "0x11989A4", Offset = "0x11989A4", VA = "0x11989A4")]
	public SnowBiome()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C12")]
	[Cpp2IlInjected.Address(RVA = "0x1198A74", Offset = "0x1198A74", VA = "0x1198A74", Slot = "4")]
	public override bool IsInBiome(Player player)
	{
		return default(bool);
	}
}
