using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.GameContent.Items;

[Cpp2IlInjected.Token(Token = "0x20005C1")]
public class ItemVariantCondition
{
	[Cpp2IlInjected.Token(Token = "0x20009A9")]
	public delegate bool Condition();

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B7D")]
	public readonly NetworkText Description;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B7E")]
	public readonly Condition IsMet;

	[Cpp2IlInjected.Token(Token = "0x6003C86")]
	[Cpp2IlInjected.Address(RVA = "0x104E178", Offset = "0x104E178", VA = "0x104E178")]
	public ItemVariantCondition(NetworkText description, Condition condition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C87")]
	[Cpp2IlInjected.Address(RVA = "0x104E1A0", Offset = "0x104E1A0", VA = "0x104E1A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
