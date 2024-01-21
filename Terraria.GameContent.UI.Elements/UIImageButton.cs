using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D9")]
public class UIImageButton : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007063")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007064")]
	private float _visibilityActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007065")]
	private float _visibilityInactive;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007066")]
	private Asset<Texture2D> _borderTexture;

	[Cpp2IlInjected.Token(Token = "0x60044D3")]
	[Cpp2IlInjected.Address(RVA = "0x148BA3C", Offset = "0x148BA3C", VA = "0x148BA3C")]
	public UIImageButton(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D4")]
	[Cpp2IlInjected.Address(RVA = "0x1491F5C", Offset = "0x1491F5C", VA = "0x1491F5C")]
	public void SetHoverImage(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D5")]
	[Cpp2IlInjected.Address(RVA = "0x1491F64", Offset = "0x1491F64", VA = "0x1491F64")]
	public void SetImage(Asset<Texture2D> texture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D6")]
	[Cpp2IlInjected.Address(RVA = "0x149051C", Offset = "0x149051C", VA = "0x149051C", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D7")]
	[Cpp2IlInjected.Address(RVA = "0x149077C", Offset = "0x149077C", VA = "0x149077C", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D8")]
	[Cpp2IlInjected.Address(RVA = "0x14907DC", Offset = "0x14907DC", VA = "0x14907DC", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044D9")]
	[Cpp2IlInjected.Address(RVA = "0x148BB54", Offset = "0x148BB54", VA = "0x148BB54")]
	public void SetVisibility(float whenActive, float whenInactive)
	{
	}
}
