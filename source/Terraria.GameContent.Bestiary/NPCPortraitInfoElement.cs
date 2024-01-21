using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000647")]
public class NPCPortraitInfoElement : IBestiaryInfoElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C8B")]
	private int? _filledStarsCount;

	[Cpp2IlInjected.Token(Token = "0x6003F45")]
	[Cpp2IlInjected.Address(RVA = "0x10F7C84", Offset = "0x10F7C84", VA = "0x10F7C84")]
	public NPCPortraitInfoElement([Optional] int? rarityStars)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003F46")]
	[Cpp2IlInjected.Address(RVA = "0x10FE744", Offset = "0x10FE744", VA = "0x10FE744", Slot = "4")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003F47")]
	[Cpp2IlInjected.Address(RVA = "0x10FF8E8", Offset = "0x10FF8E8", VA = "0x10FF8E8")]
	public int GetStarCount()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F48")]
	[Cpp2IlInjected.Address(RVA = "0x10FF958", Offset = "0x10FF958", VA = "0x10FF958")]
	private float GetSortingValueForElement(IBestiaryInfoElement element)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003F49")]
	[Cpp2IlInjected.Address(RVA = "0x10FF3B4", Offset = "0x10FF3B4", VA = "0x10FF3B4")]
	private UIElement CreateStarsContainer()
	{
		return null;
	}
}
