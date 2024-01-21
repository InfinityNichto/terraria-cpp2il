using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x20005A3")]
public interface IShopPersonalityTrait
{
	[Cpp2IlInjected.Token(Token = "0x6003C24")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance);
}
