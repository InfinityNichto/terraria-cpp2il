using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000593")]
public class NPCPreferenceTrait : IShopPersonalityTrait
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B33")]
	public AffectionLevel Level;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B34")]
	public int NpcId;

	[Cpp2IlInjected.Token(Token = "0x6003C00")]
	[Cpp2IlInjected.Address(RVA = "0x1197DEC", Offset = "0x1197DEC", VA = "0x1197DEC", Slot = "4")]
	public void ModifyShopPrice(HelperInfo info, ShopHelper shopHelperInstance)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C01")]
	[Cpp2IlInjected.Address(RVA = "0x1197E5C", Offset = "0x1197E5C", VA = "0x1197E5C")]
	public NPCPreferenceTrait()
	{
	}
}
