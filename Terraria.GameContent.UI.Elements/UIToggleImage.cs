using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006EB")]
public class UIToggleImage : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40070BE")]
	private Asset<Texture2D> _onTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40070BF")]
	private Asset<Texture2D> _offTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40070C0")]
	private int _drawWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40070C1")]
	private int _drawHeight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40070C2")]
	private Point _onTextureOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40070C3")]
	private Point _offTextureOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40070C4")]
	private bool _isOn;

	[Cpp2IlInjected.Token(Token = "0x170007DD")]
	public bool IsOn
	{
		[Cpp2IlInjected.Token(Token = "0x6004568")]
		[Cpp2IlInjected.Address(RVA = "0x1090ACC", Offset = "0x1090ACC", VA = "0x1090ACC")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004569")]
	[Cpp2IlInjected.Address(RVA = "0x1090AD4", Offset = "0x1090AD4", VA = "0x1090AD4")]
	public UIToggleImage(Asset<Texture2D> texture, int width, int height, Point onTextureOffset, Point offTextureOffset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600456A")]
	[Cpp2IlInjected.Address(RVA = "0x1090CF0", Offset = "0x1090CF0", VA = "0x1090CF0", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600456B")]
	[Cpp2IlInjected.Address(RVA = "0x1090EF4", Offset = "0x1090EF4", VA = "0x1090EF4", Slot = "17")]
	public override void LeftClick(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600456C")]
	[Cpp2IlInjected.Address(RVA = "0x1090F18", Offset = "0x1090F18", VA = "0x1090F18")]
	public void SetState(bool value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600456D")]
	[Cpp2IlInjected.Address(RVA = "0x1090F08", Offset = "0x1090F08", VA = "0x1090F08")]
	public void Toggle()
	{
	}
}
