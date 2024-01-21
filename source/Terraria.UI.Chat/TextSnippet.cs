using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20004DE")]
public class TextSnippet
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006710")]
	public string Text;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006711")]
	public string TextOriginal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006712")]
	public Color Color;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006713")]
	public float Scale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006714")]
	public bool CheckForHover;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4006715")]
	public bool DeleteWhole;

	[Cpp2IlInjected.Token(Token = "0x60036BB")]
	[Cpp2IlInjected.Address(RVA = "0x14B9E48", Offset = "0x14B9E48", VA = "0x14B9E48")]
	public TextSnippet(string text = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036BC")]
	[Cpp2IlInjected.Address(RVA = "0x14B4444", Offset = "0x14B4444", VA = "0x14B4444")]
	public TextSnippet(string text, Color color, float scale = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036BD")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EE8", Offset = "0x14B9EE8", VA = "0x14B9EE8", Slot = "4")]
	public virtual void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036BE")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EEC", Offset = "0x14B9EEC", VA = "0x14B9EEC", Slot = "5")]
	public virtual void OnHover()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036BF")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EF0", Offset = "0x14B9EF0", VA = "0x14B9EF0", Slot = "6")]
	public virtual void OnClick()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036C0")]
	[Cpp2IlInjected.Address(RVA = "0x14B9EF4", Offset = "0x14B9EF4", VA = "0x14B9EF4", Slot = "7")]
	public virtual Color GetVisibleColor()
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60036C1")]
	[Cpp2IlInjected.Address(RVA = "0x14B9F70", Offset = "0x14B9F70", VA = "0x14B9F70", Slot = "8")]
	public virtual bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60036C2")]
	[Cpp2IlInjected.Address(RVA = "0x14BA050", Offset = "0x14BA050", VA = "0x14BA050", Slot = "9")]
	public virtual TextSnippet CopyMorph(string newText)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60036C3")]
	[Cpp2IlInjected.Address(RVA = "0x14BA0E0", Offset = "0x14BA0E0", VA = "0x14BA0E0", Slot = "10")]
	public virtual float GetStringLength(SpriteFont font)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60036C4")]
	[Cpp2IlInjected.Address(RVA = "0x14BA118", Offset = "0x14BA118", VA = "0x14BA118", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
