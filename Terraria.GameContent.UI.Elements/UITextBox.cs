using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006E9")]
internal class UITextBox : UITextPanel<string>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40070B0")]
	private int _cursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40070B1")]
	private int _frameCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40070B2")]
	private int _maxLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40070B3")]
	public bool ShowInputTicker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
	[Cpp2IlInjected.Token(Token = "0x40070B4")]
	public bool HideSelf;

	[Cpp2IlInjected.Token(Token = "0x6004551")]
	[Cpp2IlInjected.Address(RVA = "0x10903D8", Offset = "0x10903D8", VA = "0x10903D8")]
	public UITextBox(string text, float textScale = 1f, bool large = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004552")]
	[Cpp2IlInjected.Address(RVA = "0x1090468", Offset = "0x1090468", VA = "0x1090468")]
	public void Write(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004553")]
	[Cpp2IlInjected.Address(RVA = "0x1090504", Offset = "0x1090504", VA = "0x1090504", Slot = "30")]
	public override void SetText(string text, float textScale, bool large)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004554")]
	[Cpp2IlInjected.Address(RVA = "0x1090620", Offset = "0x1090620", VA = "0x1090620")]
	public void SetTextMaxLength(int maxLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004555")]
	[Cpp2IlInjected.Address(RVA = "0x1090628", Offset = "0x1090628", VA = "0x1090628")]
	public void Backspace()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004556")]
	[Cpp2IlInjected.Address(RVA = "0x10906D8", Offset = "0x10906D8", VA = "0x10906D8")]
	public void CursorLeft()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004557")]
	[Cpp2IlInjected.Address(RVA = "0x10906EC", Offset = "0x10906EC", VA = "0x10906EC")]
	public void CursorRight()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004558")]
	[Cpp2IlInjected.Address(RVA = "0x1090760", Offset = "0x1090760", VA = "0x1090760", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
