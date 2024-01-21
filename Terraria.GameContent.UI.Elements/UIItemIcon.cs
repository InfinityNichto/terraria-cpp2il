using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006DC")]
public class UIItemIcon : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400706A")]
	private Item _item;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400706B")]
	private bool _blackedOut;

	[Cpp2IlInjected.Token(Token = "0x60044E3")]
	[Cpp2IlInjected.Address(RVA = "0x1482578", Offset = "0x1482578", VA = "0x1482578")]
	public UIItemIcon(Item item, bool blackedOut)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044E4")]
	[Cpp2IlInjected.Address(RVA = "0x14921EC", Offset = "0x14921EC", VA = "0x14921EC", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
