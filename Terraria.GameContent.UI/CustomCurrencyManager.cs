using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x200069D")]
public class CustomCurrencyManager
{
	[Cpp2IlInjected.Token(Token = "0x4006E28")]
	private static int _nextCurrencyIndex;

	[Cpp2IlInjected.Token(Token = "0x4006E29")]
	private static Dictionary<int, CustomCurrencySystem> _currencies;

	[Cpp2IlInjected.Token(Token = "0x60042AE")]
	[Cpp2IlInjected.Address(RVA = "0x1187EA4", Offset = "0x1187EA4", VA = "0x1187EA4")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042AF")]
	[Cpp2IlInjected.Address(RVA = "0x1188050", Offset = "0x1188050", VA = "0x1188050")]
	public static int RegisterCurrency(CustomCurrencySystem collection)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60042B0")]
	[Cpp2IlInjected.Address(RVA = "0x1188100", Offset = "0x1188100", VA = "0x1188100")]
	public static long GetCurrencyCount(int currencyIndex)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60042B1")]
	[Cpp2IlInjected.Address(RVA = "0x1188598", Offset = "0x1188598", VA = "0x1188598")]
	public static void DrawSavings(SpriteBatch sb, int currencyIndex, float shopx, float shopy, bool horizontal = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042B2")]
	[Cpp2IlInjected.Address(RVA = "0x1188E8C", Offset = "0x1188E8C", VA = "0x1188E8C")]
	public static void GetPriceText(int currencyIndex, string[] lines, ref int currentLine, long price)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042B3")]
	[Cpp2IlInjected.Address(RVA = "0x1188F5C", Offset = "0x1188F5C", VA = "0x1188F5C")]
	public static bool CanAffordItem(Player player, long price, int currencyIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60042B4")]
	[Cpp2IlInjected.Address(RVA = "0x118947C", Offset = "0x118947C", VA = "0x118947C")]
	public static bool BuyItem(Player player, long price, int currencyIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60042B5")]
	[Cpp2IlInjected.Address(RVA = "0x1189DC8", Offset = "0x1189DC8", VA = "0x1189DC8")]
	private static void FindEmptySlots(List<Item[]> inventories, Dictionary<int, List<int>> slotsToIgnore, List<Point> emptySlots, int currentInventoryIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042B6")]
	[Cpp2IlInjected.Address(RVA = "0x1189F48", Offset = "0x1189F48", VA = "0x1189F48")]
	public static bool IsCustomCurrency(Item item)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60042B7")]
	[Cpp2IlInjected.Address(RVA = "0x118A0C0", Offset = "0x118A0C0", VA = "0x118A0C0")]
	public static void GetPrices(Item item, out long calcForSelling, out long calcForBuying)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042B8")]
	[Cpp2IlInjected.Address(RVA = "0x118A184", Offset = "0x118A184", VA = "0x118A184")]
	public CustomCurrencyManager()
	{
	}
}
