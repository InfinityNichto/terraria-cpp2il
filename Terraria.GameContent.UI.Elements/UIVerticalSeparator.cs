using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006EC")]
public class UIVerticalSeparator : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40070C5")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40070C6")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40070C7")]
	public int EdgeWidth;

	[Cpp2IlInjected.Token(Token = "0x600456E")]
	[Cpp2IlInjected.Address(RVA = "0x1090F20", Offset = "0x1090F20", VA = "0x1090F20")]
	public UIVerticalSeparator()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600456F")]
	[Cpp2IlInjected.Address(RVA = "0x1091144", Offset = "0x1091144", VA = "0x1091144", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004570")]
	[Cpp2IlInjected.Address(RVA = "0x10911E0", Offset = "0x10911E0", VA = "0x10911E0", Slot = "12")]
	public override bool ContainsPoint(Vector2 point)
	{
		return default(bool);
	}
}
