using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x20006FC")]
public class BigProgressBarHelper
{
	[Cpp2IlInjected.Token(Token = "0x400710E")]
	private const string _bossBarTexturePath = "Images/UI/UI_BossBar";

	[Cpp2IlInjected.Token(Token = "0x60045C5")]
	[Cpp2IlInjected.Address(RVA = "0x117C214", Offset = "0x117C214", VA = "0x117C214")]
	public static void DrawBareBonesBar(SpriteBatch spriteBatch, float lifePercent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045C6")]
	[Cpp2IlInjected.Address(RVA = "0x117C6BC", Offset = "0x117C6BC", VA = "0x117C6BC")]
	public static void DrawFancyBar(SpriteBatch spriteBatch, float lifeAmount, float lifeMax, Texture2D barIconTexture, Rectangle barIconFrame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045C7")]
	[Cpp2IlInjected.Address(RVA = "0x117D2D8", Offset = "0x117D2D8", VA = "0x117D2D8")]
	private static void DrawHealthText(SpriteBatch spriteBatch, Rectangle area, float current, float max)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045C8")]
	[Cpp2IlInjected.Address(RVA = "0x117D678", Offset = "0x117D678", VA = "0x117D678")]
	public static void DrawFancyBar(SpriteBatch spriteBatch, float lifeAmount, float lifeMax, Texture2D barIconTexture, Rectangle barIconFrame, float shieldCurrent, float shieldMax)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60045C9")]
	[Cpp2IlInjected.Address(RVA = "0x117E6C0", Offset = "0x117E6C0", VA = "0x117E6C0")]
	public BigProgressBarHelper()
	{
	}
}
