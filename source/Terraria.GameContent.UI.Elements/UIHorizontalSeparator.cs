using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D6")]
public class UIHorizontalSeparator : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400704E")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400704F")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007050")]
	public int EdgeWidth;

	[Cpp2IlInjected.Token(Token = "0x60044C5")]
	[Cpp2IlInjected.Address(RVA = "0x147F7B0", Offset = "0x147F7B0", VA = "0x147F7B0")]
	public UIHorizontalSeparator(int EdgeWidth = 2, bool highlightSideUp = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044C6")]
	[Cpp2IlInjected.Address(RVA = "0x1490E84", Offset = "0x1490E84", VA = "0x1490E84", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044C7")]
	[Cpp2IlInjected.Address(RVA = "0x1490F70", Offset = "0x1490F70", VA = "0x1490F70", Slot = "12")]
	public override bool ContainsPoint(Vector2 point)
	{
		return default(bool);
	}
}
