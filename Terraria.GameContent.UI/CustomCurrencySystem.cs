using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x200069B")]
public class CustomCurrencySystem
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006E23")]
	protected Dictionary<int, int> _valuePerUnit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006E24")]
	private long _currencyCap;

	[Cpp2IlInjected.Token(Token = "0x170007A8")]
	public long CurrencyCap
	{
		[Cpp2IlInjected.Token(Token = "0x600429C")]
		[Cpp2IlInjected.Address(RVA = "0x118B274", Offset = "0x118B274", VA = "0x118B274")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600429D")]
	[Cpp2IlInjected.Address(RVA = "0x118A2A8", Offset = "0x118A2A8", VA = "0x118A2A8")]
	public void Include(int coin, int howMuchIsItWorth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600429E")]
	[Cpp2IlInjected.Address(RVA = "0x118B27C", Offset = "0x118B27C", VA = "0x118B27C")]
	public void SetCurrencyCap(long cap)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600429F")]
	[Cpp2IlInjected.Address(RVA = "0x118B28C", Offset = "0x118B28C", VA = "0x118B28C", Slot = "4")]
	public virtual long CountCurrency(out bool overFlowing, Item[] inv, params int[] ignoreSlots)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60042A0")]
	[Cpp2IlInjected.Address(RVA = "0x118B408", Offset = "0x118B408", VA = "0x118B408", Slot = "5")]
	public virtual long CombineStacks(out bool overFlowing, params long[] coinCounts)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60042A1")]
	[Cpp2IlInjected.Address(RVA = "0x118B48C", Offset = "0x118B48C", VA = "0x118B48C", Slot = "6")]
	public virtual bool TryPurchasing(long price, List<Item[]> inv, List<Point> slotCoins, List<Point> slotsEmpty, List<Point> slotEmptyBank, List<Point> slotEmptyBank2, List<Point> slotEmptyBank3, List<Point> slotEmptyBank4)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60042A2")]
	[Cpp2IlInjected.Address(RVA = "0x118C7A4", Offset = "0x118C7A4", VA = "0x118C7A4", Slot = "7")]
	public virtual bool Accepts(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60042A3")]
	[Cpp2IlInjected.Address(RVA = "0x118C808", Offset = "0x118C808", VA = "0x118C808", Slot = "8")]
	public virtual void DrawSavingsMoney(SpriteBatch sb, string text, float shopx, float shopy, long totalCoins, bool horizontal = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042A4")]
	[Cpp2IlInjected.Address(RVA = "0x118C80C", Offset = "0x118C80C", VA = "0x118C80C", Slot = "9")]
	public virtual void GetPriceText(string[] lines, ref int currentLine, long price)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042A5")]
	[Cpp2IlInjected.Address(RVA = "0x118C810", Offset = "0x118C810", VA = "0x118C810")]
	protected int SortByHighest(Tuple<int, int> valueA, Tuple<int, int> valueB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60042A6")]
	[Cpp2IlInjected.Address(RVA = "0x118A5C4", Offset = "0x118A5C4", VA = "0x118A5C4")]
	protected List<Tuple<Point, Item>> ItemCacheCreate(List<Item[]> inventories)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60042A7")]
	[Cpp2IlInjected.Address(RVA = "0x118A750", Offset = "0x118A750", VA = "0x118A750")]
	protected void ItemCacheRestore(List<Tuple<Point, Item>> cache, List<Item[]> inventories)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042A8")]
	[Cpp2IlInjected.Address(RVA = "0x118C878", Offset = "0x118C878", VA = "0x118C878", Slot = "10")]
	public virtual void GetItemExpectedPrice(Item item, out long calcForSelling, out long calcForBuying)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042A9")]
	[Cpp2IlInjected.Address(RVA = "0x118A214", Offset = "0x118A214", VA = "0x118A214")]
	public CustomCurrencySystem()
	{
	}
}
