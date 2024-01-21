using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x20005A6")]
public class AllPersonalitiesModifier : IShopPersonalityTrait
{
	[Cpp2IlInjected.Token(Token = "0x6003C25")]
	[Cpp2IlInjected.Address(RVA = "0x1196834", Offset = "0x1196834", VA = "0x1196834", Slot = "4")]
	public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C26")]
	[Cpp2IlInjected.Address(RVA = "0x1196868", Offset = "0x1196868", VA = "0x1196868")]
	private static void ModifyShopPrice_Relationships(HelperInfo info, ShopHelper shopHelperInstance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C27")]
	[Cpp2IlInjected.Address(RVA = "0x1197660", Offset = "0x1197660", VA = "0x1197660")]
	public AllPersonalitiesModifier()
	{
	}
}
