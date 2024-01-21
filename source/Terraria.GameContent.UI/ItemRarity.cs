using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x20006A0")]
public class ItemRarity
{
	[Cpp2IlInjected.Token(Token = "0x4006ECA")]
	private static Dictionary<int, Color> _rarities;

	[Cpp2IlInjected.Token(Token = "0x60042C1")]
	[Cpp2IlInjected.Address(RVA = "0x109A4BC", Offset = "0x109A4BC", VA = "0x109A4BC")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042C2")]
	[Cpp2IlInjected.Address(RVA = "0x109A710", Offset = "0x109A710", VA = "0x109A710")]
	public static Color GetColor(int rarity)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60042C3")]
	[Cpp2IlInjected.Address(RVA = "0x109A854", Offset = "0x109A854", VA = "0x109A854")]
	public ItemRarity()
	{
	}
}
