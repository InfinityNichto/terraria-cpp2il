using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E0")]
public class UIPanel : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007078")]
	private int _cornerSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007079")]
	private int _barSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400707A")]
	private Asset<Texture2D> _borderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400707B")]
	private Asset<Texture2D> _backgroundTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400707C")]
	public Color BorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400707D")]
	public Color BackgroundColor;

	[Cpp2IlInjected.Token(Token = "0x60044FB")]
	[Cpp2IlInjected.Address(RVA = "0x147E314", Offset = "0x147E314", VA = "0x147E314")]
	public UIPanel()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044FC")]
	[Cpp2IlInjected.Address(RVA = "0x14949B0", Offset = "0x14949B0", VA = "0x14949B0")]
	public UIPanel(Asset<Texture2D> customBackground, Asset<Texture2D> customborder, int customCornerSize = 12, int customBarSize = 4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044FD")]
	[Cpp2IlInjected.Address(RVA = "0x1494B20", Offset = "0x1494B20", VA = "0x1494B20")]
	private void DrawPanel(SpriteBatch spriteBatch, Texture2D texture, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044FE")]
	[Cpp2IlInjected.Address(RVA = "0x1482664", Offset = "0x1482664", VA = "0x1482664", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
