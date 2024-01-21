using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x20006A2")]
public class LegacyMultiplayerClosePlayersOverlay : IMultiplayerClosePlayersOverlay
{
	[Cpp2IlInjected.Token(Token = "0x60042C6")]
	[Cpp2IlInjected.Address(RVA = "0x109A8E4", Offset = "0x109A8E4", VA = "0x109A8E4", Slot = "4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042C7")]
	[Cpp2IlInjected.Address(RVA = "0x109B8E0", Offset = "0x109B8E0", VA = "0x109B8E0")]
	private static void DrawPlayerName2(SpriteBatch spriteBatch, ref Color namePlateColor, string npDist, ref Vector2 npDistPos)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042C8")]
	[Cpp2IlInjected.Address(RVA = "0x109BC14", Offset = "0x109BC14", VA = "0x109BC14")]
	private static void DrawPlayerName(SpriteBatch spriteBatch, string namePlate, ref Vector2 namePlatePos, ref Color namePlateColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042C9")]
	[Cpp2IlInjected.Address(RVA = "0x109BF34", Offset = "0x109BF34", VA = "0x109BF34")]
	public LegacyMultiplayerClosePlayersOverlay()
	{
	}
}
