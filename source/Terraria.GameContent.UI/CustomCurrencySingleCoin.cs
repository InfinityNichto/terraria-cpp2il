using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x200069C")]
public class CustomCurrencySingleCoin : CustomCurrencySystem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006E25")]
	public float CurrencyDrawScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006E26")]
	public string CurrencyTextKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006E27")]
	public Color CurrencyTextColor;

	[Cpp2IlInjected.Token(Token = "0x60042AA")]
	[Cpp2IlInjected.Address(RVA = "0x1187F94", Offset = "0x1187F94", VA = "0x1187F94")]
	public CustomCurrencySingleCoin(int coinItemID, long currencyCap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042AB")]
	[Cpp2IlInjected.Address(RVA = "0x118A314", Offset = "0x118A314", VA = "0x118A314", Slot = "6")]
	public override bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60042AC")]
	[Cpp2IlInjected.Address(RVA = "0x118A8C4", Offset = "0x118A8C4", VA = "0x118A8C4", Slot = "8")]
	public override void DrawSavingsMoney(SpriteBatch sb, string text, float shopx, float shopy, long totalCoins, bool horizontal = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042AD")]
	[Cpp2IlInjected.Address(RVA = "0x118AF1C", Offset = "0x118AF1C", VA = "0x118AF1C", Slot = "9")]
	public override void GetPriceText(string[] lines, ref int currentLine, long price)
	{
	}
}
