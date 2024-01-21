using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000549")]
public class DontStarveSeed
{
	[Cpp2IlInjected.Token(Token = "0x60039D9")]
	[Cpp2IlInjected.Address(RVA = "0xD77C50", Offset = "0xD77C50", VA = "0xD77C50")]
	public static void ModifyNightColor(ref Color bgColorToSet, ref Color moonColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039DA")]
	[Cpp2IlInjected.Address(RVA = "0xD77E84", Offset = "0xD77E84", VA = "0xD77E84")]
	public static void ModifyMinimumLightColorAtNight(ref byte minimalLight)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039DB")]
	[Cpp2IlInjected.Address(RVA = "0xD78020", Offset = "0xD78020", VA = "0xD78020")]
	public static void FixBiomeDarkness(ref Color bgColor, ref int R, ref int G, ref int B)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039DC")]
	[Cpp2IlInjected.Address(RVA = "0xD7812C", Offset = "0xD7812C", VA = "0xD7812C")]
	public static void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039DD")]
	[Cpp2IlInjected.Address(RVA = "0xD781BC", Offset = "0xD781BC", VA = "0xD781BC")]
	private static void Hook_OnEnterWorld(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60039DE")]
	[Cpp2IlInjected.Address(RVA = "0xD781C8", Offset = "0xD781C8", VA = "0xD781C8")]
	public DontStarveSeed()
	{
	}
}
