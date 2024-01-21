using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000698")]
public class ScreenDarkness
{
	[Cpp2IlInjected.Token(Token = "0x4006E10")]
	public static float screenObstruction;

	[Cpp2IlInjected.Token(Token = "0x4006E11")]
	public static Color frontColor;

	[Cpp2IlInjected.Token(Token = "0x6004279")]
	[Cpp2IlInjected.Address(RVA = "0xF639E4", Offset = "0xF639E4", VA = "0xF639E4")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600427A")]
	[Cpp2IlInjected.Address(RVA = "0xF63FC0", Offset = "0xF63FC0", VA = "0xF63FC0")]
	public static void DrawBack(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600427B")]
	[Cpp2IlInjected.Address(RVA = "0xF64234", Offset = "0xF64234", VA = "0xF64234")]
	public static void DrawFront(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600427C")]
	[Cpp2IlInjected.Address(RVA = "0xF6449C", Offset = "0xF6449C", VA = "0xF6449C")]
	public ScreenDarkness()
	{
	}
}
