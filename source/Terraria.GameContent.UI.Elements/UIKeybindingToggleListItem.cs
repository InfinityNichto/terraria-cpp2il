using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006DE")]
public class UIKeybindingToggleListItem : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x400706E")]
	private Color _color;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400706F")]
	private Func<string> _TextDisplayFunction;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007070")]
	private Func<bool> _IsOnFunction;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007071")]
	private Asset<Texture2D> _toggleTexture;

	[Cpp2IlInjected.Token(Token = "0x60044E7")]
	[Cpp2IlInjected.Address(RVA = "0x1492DC4", Offset = "0x1492DC4", VA = "0x1492DC4")]
	public UIKeybindingToggleListItem(Func<string> getText, Func<bool> getStatus, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044E8")]
	[Cpp2IlInjected.Address(RVA = "0x14930D0", Offset = "0x14930D0", VA = "0x14930D0", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
