using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class ControlsTouchAxisHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x20C3004", Offset = "0x20C3004", VA = "0x20C3004")]
	public static bool MeasureInline(ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x20C3400", Offset = "0x20C3400", VA = "0x20C3400")]
	public static bool PrintInline(SpriteBatch spriteBatch, Vector2 position, Color color, float scale, ref SpriteFont.CharacterSource text, int offset, ref int endOffset, ref Vector2 size)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x20C3A00", Offset = "0x20C3A00", VA = "0x20C3A00", Slot = "4")]
	public TextSnippet Parse(string text, [Optional] Color baseColour, [Optional] string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x20C3A08", Offset = "0x20C3A08", VA = "0x20C3A08")]
	public ControlsTouchAxisHandler()
	{
	}
}
