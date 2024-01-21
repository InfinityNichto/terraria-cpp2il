using System.Text;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class GUIString
{
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public static int MaxLastLineWidthInsertExraLine;

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0xEC0B70", Offset = "0xEC0B70", VA = "0xEC0B70")]
	public static void Draw(String_Layout layout, TextSnippet[] textSnippets, out int snippetSelected, float maxWidth = -1f, int maxLines = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0xEC0E4C", Offset = "0xEC0E4C", VA = "0xEC0E4C")]
	public static string ApplyMultiLineAlignment(String_Layout layout, string value, out int lineCount)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0xEC1864", Offset = "0xEC1864", VA = "0xEC1864")]
	public static void Draw(String_Layout layout, string value, Color overloadedColour, bool multilineAlignmentApplied = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0xEC25BC", Offset = "0xEC25BC", VA = "0xEC25BC")]
	public static void Draw(String_Layout layout, StringBuilder value, Color overloadedColour)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0xEC28B0", Offset = "0xEC28B0", VA = "0xEC28B0")]
	public static void Draw(String_Layout layout, string value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0xEC2944", Offset = "0xEC2944", VA = "0xEC2944")]
	public static void Draw(String_Layout layout, StringBuilder value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0xEC29CC", Offset = "0xEC29CC", VA = "0xEC29CC")]
	public static Vector2 CalculateStringPosition(String_Layout layout, string value)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0xEC2C18", Offset = "0xEC2C18", VA = "0xEC2C18")]
	public static Rectangle GetRegion(String_Layout layout, string value)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0xEC2EA8", Offset = "0xEC2EA8", VA = "0xEC2EA8")]
	public static void DrawWithShadow(String_Layout layout, string value, Vector2 position, Color overloadedColour)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0xEC30C4", Offset = "0xEC30C4", VA = "0xEC30C4")]
	public static void DrawWithShadow(String_Layout layout, string value, Vector2 stringPosition)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0xEC3164", Offset = "0xEC3164", VA = "0xEC3164")]
	public static void DrawWithShadow(String_Layout layout, string value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0xEC320C", Offset = "0xEC320C", VA = "0xEC320C")]
	public static void DrawWithShadow(String_Layout layout, string value, bool calculatePosition, Color overloadedColour)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0xEC3388", Offset = "0xEC3388", VA = "0xEC3388")]
	public static bool DrawButton(String_Layout layout, string value, Color overloadedColour)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xEC3FB0", Offset = "0xEC3FB0", VA = "0xEC3FB0")]
	public static bool DrawButton(String_Layout layout, string value)
	{
		return default(bool);
	}
}
