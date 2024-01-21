using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006CA")]
public class UIColoredImageButton : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006FEE")]
	private Asset<Texture2D> _backPanelTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006FEF")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006FF0")]
	private Asset<Texture2D> _middleTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006FF1")]
	private Asset<Texture2D> _backPanelHighlightTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006FF2")]
	private Asset<Texture2D> _backPanelBorderTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4006FF3")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4006FF4")]
	private float _visibilityActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4006FF5")]
	private float _visibilityInactive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4006FF6")]
	private bool _selected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x111")]
	[Cpp2IlInjected.Token(Token = "0x4006FF7")]
	private bool _hovered;

	[Cpp2IlInjected.Token(Token = "0x600445C")]
	[Cpp2IlInjected.Address(RVA = "0x1484BB0", Offset = "0x1484BB0", VA = "0x1484BB0")]
	public UIColoredImageButton(Asset<Texture2D> texture, bool isSmall = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600445D")]
	[Cpp2IlInjected.Address(RVA = "0x1485120", Offset = "0x1485120", VA = "0x1485120")]
	public void SetImage(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600445E")]
	[Cpp2IlInjected.Address(RVA = "0x14851EC", Offset = "0x14851EC", VA = "0x14851EC")]
	public void SetImageWithoutSettingSize(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600445F")]
	[Cpp2IlInjected.Address(RVA = "0x14851F4", Offset = "0x14851F4", VA = "0x14851F4", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004460")]
	[Cpp2IlInjected.Address(RVA = "0x14858DC", Offset = "0x14858DC", VA = "0x14858DC", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004461")]
	[Cpp2IlInjected.Address(RVA = "0x1485928", Offset = "0x1485928", VA = "0x1485928")]
	public void SetVisibility(float whenActive, float whenInactive)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004462")]
	[Cpp2IlInjected.Address(RVA = "0x148596C", Offset = "0x148596C", VA = "0x148596C")]
	public void SetColor(Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004463")]
	[Cpp2IlInjected.Address(RVA = "0x1485974", Offset = "0x1485974", VA = "0x1485974")]
	public void SetMiddleTexture(Asset<Texture2D> texAsset)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004464")]
	[Cpp2IlInjected.Address(RVA = "0x148597C", Offset = "0x148597C", VA = "0x148597C")]
	public void SetSelected(bool selected)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004465")]
	[Cpp2IlInjected.Address(RVA = "0x1485984", Offset = "0x1485984", VA = "0x1485984", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}
}
