using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D7")]
public class UIIconTextButton : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007051")]
	private readonly Asset<Texture2D> _BasePanelTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007052")]
	private readonly Asset<Texture2D> _hoveredTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007053")]
	private readonly Asset<Texture2D> _iconTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007054")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007055")]
	private Color _hoverColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4007056")]
	public float FadeFromBlack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4007057")]
	private float _whiteLerp;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4007058")]
	private float _opacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4007059")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
	[Cpp2IlInjected.Token(Token = "0x400705A")]
	private bool _soundedHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x400705B")]
	private UIText _title;

	[Cpp2IlInjected.Token(Token = "0x60044C8")]
	[Cpp2IlInjected.Address(RVA = "0x1490F78", Offset = "0x1490F78", VA = "0x1490F78")]
	public UIIconTextButton(LocalizedText title, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044C9")]
	[Cpp2IlInjected.Address(RVA = "0x149142C", Offset = "0x149142C", VA = "0x149142C")]
	public void SetText(LocalizedText text, float textSize, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044CA")]
	[Cpp2IlInjected.Address(RVA = "0x1491660", Offset = "0x1491660", VA = "0x1491660", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044CB")]
	[Cpp2IlInjected.Address(RVA = "0x1491944", Offset = "0x1491944", VA = "0x1491944", Slot = "15")]
	public override void LeftMouseDown(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044CC")]
	[Cpp2IlInjected.Address(RVA = "0x1491998", Offset = "0x1491998", VA = "0x1491998", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044CD")]
	[Cpp2IlInjected.Address(RVA = "0x1491A8C", Offset = "0x1491A8C", VA = "0x1491A8C", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044CE")]
	[Cpp2IlInjected.Address(RVA = "0x1491420", Offset = "0x1491420", VA = "0x1491420")]
	public void SetColor(Color color, float opacity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044CF")]
	[Cpp2IlInjected.Address(RVA = "0x1491B7C", Offset = "0x1491B7C", VA = "0x1491B7C")]
	public void SetHoverColor(Color color)
	{
	}
}
