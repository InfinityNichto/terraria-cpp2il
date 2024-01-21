using System.Globalization;
using System.Text;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Text;

[Cpp2IlInjected.Token(Token = "0x2000721")]
public class WrappedTextBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000ACD")]
	private struct NonBreakingText
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F84")]
		public readonly string Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008F85")]
		public readonly float Width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008F86")]
		public readonly float WidthOnNewLine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008F87")]
		public readonly bool IsWhitespace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008F88")]
		private readonly SpriteFont _font;

		[Cpp2IlInjected.Token(Token = "0x600530C")]
		[Cpp2IlInjected.Address(RVA = "0x39A810", Offset = "0x39A810", VA = "0x39A810")]
		public NonBreakingText(SpriteFont font, string text)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600530D")]
		[Cpp2IlInjected.Address(RVA = "0x39A818", Offset = "0x39A818", VA = "0x39A818")]
		public string GetAsWrappedText(float maxWidth)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400716B")]
	private readonly SpriteFont _font;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400716C")]
	private readonly CultureInfo _culture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400716D")]
	private readonly float _maxWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400716E")]
	private readonly StringBuilder _completedText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400716F")]
	private readonly StringBuilder _workingLine;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007170")]
	private float _workingLineWidth;

	[Cpp2IlInjected.Token(Token = "0x60046B7")]
	[Cpp2IlInjected.Address(RVA = "0xF94818", Offset = "0xF94818", VA = "0xF94818")]
	public WrappedTextBuilder(SpriteFont font, float maxWidth, CultureInfo culture)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046B8")]
	[Cpp2IlInjected.Address(RVA = "0xF948CC", Offset = "0xF948CC", VA = "0xF948CC")]
	public void CommitWorkingLine()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046B9")]
	[Cpp2IlInjected.Address(RVA = "0xF94924", Offset = "0xF94924", VA = "0xF94924")]
	private void Append(NonBreakingText textToken)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046BA")]
	[Cpp2IlInjected.Address(RVA = "0xF94C44", Offset = "0xF94C44", VA = "0xF94C44")]
	public void Append(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046BB")]
	[Cpp2IlInjected.Address(RVA = "0xF94F4C", Offset = "0xF94F4C", VA = "0xF94F4C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
