using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006B7")]
public class EmoteButton : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4006F85")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4006F86")]
	private Asset<Texture2D> _textureBorder;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4006F87")]
	private int _emoteIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4006F88")]
	private bool _hovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4006F89")]
	private int _frameCounter;

	[Cpp2IlInjected.Token(Token = "0x60043D6")]
	[Cpp2IlInjected.Address(RVA = "0x118C8A4", Offset = "0x118C8A4", VA = "0x118C8A4")]
	public EmoteButton(int emoteIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043D7")]
	[Cpp2IlInjected.Address(RVA = "0x118CB58", Offset = "0x118CB58", VA = "0x118CB58")]
	private Rectangle GetFrame()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60043D8")]
	[Cpp2IlInjected.Address(RVA = "0x118CC6C", Offset = "0x118CC6C", VA = "0x118CC6C")]
	private void UpdateFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043D9")]
	[Cpp2IlInjected.Address(RVA = "0x118CC84", Offset = "0x118CC84", VA = "0x118CC84", Slot = "9")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043DA")]
	[Cpp2IlInjected.Address(RVA = "0x118CCA0", Offset = "0x118CCA0", VA = "0x118CCA0", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043DB")]
	[Cpp2IlInjected.Address(RVA = "0x118D288", Offset = "0x118D288", VA = "0x118D288", Slot = "23")]
	public override void MouseOver(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043DC")]
	[Cpp2IlInjected.Address(RVA = "0x118D2D4", Offset = "0x118D2D4", VA = "0x118D2D4", Slot = "24")]
	public override void MouseOut(UIMouseEvent evt)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60043DD")]
	[Cpp2IlInjected.Address(RVA = "0x118D2F4", Offset = "0x118D2F4", VA = "0x118D2F4", Slot = "17")]
	public override void LeftClick(UIMouseEvent evt)
	{
	}
}
