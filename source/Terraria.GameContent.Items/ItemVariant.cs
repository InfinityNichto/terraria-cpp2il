using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.GameContent.Items;

[Cpp2IlInjected.Token(Token = "0x20005C0")]
public class ItemVariant
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B7C")]
	public readonly NetworkText Description;

	[Cpp2IlInjected.Token(Token = "0x6003C84")]
	[Cpp2IlInjected.Address(RVA = "0x104E144", Offset = "0x104E144", VA = "0x104E144")]
	public ItemVariant(NetworkText description)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C85")]
	[Cpp2IlInjected.Address(RVA = "0x104E164", Offset = "0x104E164", VA = "0x104E164", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
