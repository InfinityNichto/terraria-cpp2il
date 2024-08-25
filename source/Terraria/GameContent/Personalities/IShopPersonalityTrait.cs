using System;
using Cpp2ILInjected;

namespace Terraria.GameContent.Personalities
{
	[global::Cpp2ILInjected.Token(Token = "0x200083E")]
	public interface IShopPersonalityTrait
	{
		[global::Cpp2ILInjected.Token(Token = "0x600430B")]
		void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance);
	}
}
