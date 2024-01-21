using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000326")]
public struct ShoppingSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002C81")]
	public double PriceAdjustment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002C82")]
	public string HappinessReport;

	[Cpp2IlInjected.Token(Token = "0x17000529")]
	public static ShoppingSettings NotInShop
	{
		[Cpp2IlInjected.Token(Token = "0x600259A")]
		[Cpp2IlInjected.Address(RVA = "0x14DEDD8", Offset = "0x14DEDD8", VA = "0x14DEDD8")]
		get
		{
			return default(ShoppingSettings);
		}
	}
}
