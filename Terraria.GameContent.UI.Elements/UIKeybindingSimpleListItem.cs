using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006DD")]
public class UIKeybindingSimpleListItem : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x400706C")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400706D")]
	private Func<string> _GetTextFunction;

	[Cpp2IlInjected.Token(Token = "0x60044E5")]
	[Cpp2IlInjected.Address(RVA = "0x149275C", Offset = "0x149275C", VA = "0x149275C")]
	public UIKeybindingSimpleListItem(Func<string> getText, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044E6")]
	[Cpp2IlInjected.Address(RVA = "0x14928A8", Offset = "0x14928A8", VA = "0x14928A8", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
